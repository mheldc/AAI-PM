Imports HRISv2.HRISLibrary
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmProcessPayroll

    Private DTRDirectory As String = Application.StartupPath + "\DTR", _
            DTRLogFile As String = DTRDirectory + "\DTRLog" + Format(Now(), "MMddyyyy") + ".txt", _
            DTRExportFile As String = DTRDirectory + "\DTRExportFile" + Format(Now(), "MMddyyyy") + ".xlsx"

    Private dPayYear As Integer = 1900, dPayMonth As Integer = 1, dPayDay As Integer = 1, _
            dPayCutOffStart As Integer = 1, dPayCutOffEnd As Integer = 1, _
            dProcessedEmpClass As Int64 = 0, dProcessedEmpGroup As Int64 = 0, dIsDTRProcessed As Boolean = False, _
            dTotalLines As Int64 = 0
    Private aPayYear As Integer = 1900, aPayMonth As Integer = 1, aPayDay As Integer = 1, _
            aPayCutOffStart As Integer = 1, aPayCutOffEnd As Integer = 1, _
            aProcessedEmpClass As Int64 = 0, aProcessedEmpGroup As Int64 = 0, aTotalLines As Int64 = 0
    Private ProcessedLines As Long = 0, ProcessedFailed As Long = 0, ProcessedSuccess As Long = 0, _
            LongFileName As String = "", MinifiedFileName As String = ""
    Private ReturnProcId As Int64 = 0, EmpNo As String = "", EmpName As String = "", _
            Reg0 As Double = 0, Reg1 As Double = 0, Reg2 As Double = 0, Reg3 As Double = 0, _
            Rdr0 As Double = 0, Rdr1 As Double = 0, Rdr2 As Double = 0, Rdr3 As Double = 0, _
            Rds0 As Double = 0, Rds1 As Double = 0, Rds2 As Double = 0, Rds3 As Double = 0, _
            Rdh0 As Double = 0, Rdh1 As Double = 0, Rdh2 As Double = 0, Rdh3 As Double = 0, _
            Rdd0 As Double = 0, Rdd1 As Double = 0, Rdd2 As Double = 0, Rdd3 As Double = 0, _
            Spc0 As Double = 0, Spc1 As Double = 0, Spc2 As Double = 0, Spc3 As Double = 0, _
            Hol0 As Double = 0, Hol1 As Double = 0, Hol2 As Double = 0, Hol3 As Double = 0, _
            Dbl0 As Double = 0, Dbl1 As Double = 0, Dbl2 As Double = 0, Dbl3 As Double = 0, _
            Trdy As Double = 0, UTme As Double = 0, Abst As Double = 0, Ttlh As Double = 0, Ttld As Double = 0
    Private AdjRefId As Int64 = 0, AdjValue As Double = 0
    Private rFilename As String = "", rProcessesor As String = "", rIsPosted As String = "", rDatePosted As Date = Now
    Private AffectedRows As Integer = 0, SCounter As Int64 = 0, FCounter As Int64 = 0, PCounter As Int64 = 0

    Private Sub LoadDataToComboBox(ByVal ListType As String, ReferenceId As Int64, ByRef objCombo As ComboBox)
        Try
            Declares.CmdString = _
                    <Command>
                        Call sp_loadcombolist (@listtype, @referenceid);
                    </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@listtype", ListType))
                .Add(New MySqlParameter("@referenceid", ReferenceId))
            End With
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Database.LoadDataToControl(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, objCombo, Declares.CmdParameterList)
            End Using
        Catch ex As Exception
            MsgBox("Error loading data to dropdown box." + vbCrLf + _
                    "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ProcessDTRFile(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_processdtrfile (@ttype, @recid, @srcfile, @srcfn, @py, @pm, @pcs, @pce, @pd, @pline, @ecid, @egid, @userid)
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", cboLProcFiles.SelectedValue))
                .Add(New MySqlParameter("@srcfile", txtSelDTRFile.Text))
                .Add(New MySqlParameter("@srcfn", MinifiedFileName))
                .Add(New MySqlParameter("@py", dPayYear))
                .Add(New MySqlParameter("@pm", dPayMonth))
                .Add(New MySqlParameter("@pcs", dPayCutOffStart))
                .Add(New MySqlParameter("@pce", dPayCutOffEnd))
                .Add(New MySqlParameter("@pd", dPayDay))
                .Add(New MySqlParameter("@pline", ProcessedLines))
                .Add(New MySqlParameter("@ecid", dProcessedEmpClass))
                .Add(New MySqlParameter("@egid", dProcessedEmpGroup))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case -1
                    Dim Dt As New DataTable
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            rFilename = Dr(1).ToString
                            rProcessesor = Dr(5).ToString
                            rIsPosted = Dr(3).ToString
                            rDatePosted = Convert.ToDateTime(Dr(4))
                        Next
                    End If

                Case 0
                    Dim Dt As New DataTable
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    For Each Dr As DataRow In Dt.Rows
                        ReturnProcId = Convert.ToInt64(Dr(0))
                    Next
                Case Else

            End Select
        End Using
    End Sub

    Private Sub ProcessDTRDetail(ByVal TranType As Integer)
        Using cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_procdtrdetail (  @ttype, @dpid, @eno,
                                                            @reg0, @reg1, @reg2, @reg3, @rdr0, @rdr1, @rdr2, @rdr3,
                                                            @rds0, @rds1, @rds2, @rds3, @rdh0, @rdh1, @rdh2, @rdh3,
                                                            @rdd0, @rdd1, @rdd2, @rdd3, @spc0, @spc1, @spc2, @spc3,
                                                            @hol0, @hol1, @hol2, @hol3, @dbl0, @dbl1, @dbl2, @dbl3,
                                                            @tdy, @uth, @absh, @ttlh, @ttld,	
                                                            @userid );
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@dpid", ReturnProcId))
                .Add(New MySqlParameter("@eno", EmpNo))

                .Add(New MySqlParameter("@reg0", Reg0))
                .Add(New MySqlParameter("@reg1", Reg1))
                .Add(New MySqlParameter("@reg2", Reg2))
                .Add(New MySqlParameter("@reg3", Reg3))

                .Add(New MySqlParameter("@rdr0", Rdr0))
                .Add(New MySqlParameter("@rdr1", Rdr1))
                .Add(New MySqlParameter("@rdr2", Rdr2))
                .Add(New MySqlParameter("@rdr3", Rdr3))

                .Add(New MySqlParameter("@rds0", Rds0))
                .Add(New MySqlParameter("@rds1", Rds1))
                .Add(New MySqlParameter("@rds2", Rds2))
                .Add(New MySqlParameter("@rds3", Rds3))

                .Add(New MySqlParameter("@rdh0", Rdh0))
                .Add(New MySqlParameter("@rdh1", Rdh1))
                .Add(New MySqlParameter("@rdh2", Rdh2))
                .Add(New MySqlParameter("@rdh3", Rdh3))

                .Add(New MySqlParameter("@rdd0", Rdd0))
                .Add(New MySqlParameter("@rdd1", Rdd1))
                .Add(New MySqlParameter("@rdd2", Rdd2))
                .Add(New MySqlParameter("@rdd3", Rdd3))

                .Add(New MySqlParameter("@spc0", Spc0))
                .Add(New MySqlParameter("@spc1", Spc1))
                .Add(New MySqlParameter("@spc2", Spc2))
                .Add(New MySqlParameter("@spc3", Spc3))

                .Add(New MySqlParameter("@hol0", Hol0))
                .Add(New MySqlParameter("@hol1", Hol1))
                .Add(New MySqlParameter("@hol2", Hol2))
                .Add(New MySqlParameter("@hol3", Hol3))

                .Add(New MySqlParameter("@dbl0", Dbl0))
                .Add(New MySqlParameter("@dbl1", Dbl1))
                .Add(New MySqlParameter("@dbl2", Dbl2))
                .Add(New MySqlParameter("@dbl3", Dbl3))

                .Add(New MySqlParameter("@tdy", Trdy))
                .Add(New MySqlParameter("@uth", UTme))
                .Add(New MySqlParameter("@absh", Abst))
                .Add(New MySqlParameter("@ttlh", Ttlh))
                .Add(New MySqlParameter("@ttld", Ttld))

                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0
                    AffectedRows = Database.ExecuteCommand(cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)

                    If AffectedRows > 0 Then
                        ProcessedLines += 1
                        ProcessedSuccess += 1
                        lblPProcessed.Text = "Processed : " + ProcessedLines.ToString
                        lblPSuccess.Text = "Success : " + ProcessedSuccess.ToString
                    Else
                        ProcessedLines += 1
                        ProcessedFailed += 1
                        lblPProcessed.Text = "Processed : " + ProcessedLines.ToString
                        lblPFail.Text = "Failed : " + ProcessedFailed.ToString
                    End If
                Case 4
                    dgvCDTR.DataSource = Database.GetResults(cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvCDTR.Rows.Count <= 0 Then dgvCDTR.DataSource = Nothing
                Case Else
                    ' Conditions not met.
            End Select


        End Using
    End Sub

    Private Sub ProcessAdjustments(ByVal TranType As Integer)
        Using cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_procdtradjustments (  @ttype, @dtpid, @eno, @adjid, @adjval, @userid );
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@dtpid", ReturnProcId))
                .Add(New MySqlParameter("@eno", EmpNo))
                .Add(New MySqlParameter("@adjid", AdjRefId))
                .Add(New MySqlParameter("@adjval", AdjValue))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0
                    AffectedRows = Database.ExecuteCommand(cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                    If AffectedRows > 0 Then
                        PCounter += 1
                        lblPProcessed.Text = "Processed : " + PCounter.ToString
                        SCounter += 1
                        lblPSuccess.Text = "Success : " + SCounter.ToString
                    Else
                        FCounter += 1
                        lblPFail.Text = "Failed : " + FCounter.ToString
                    End If
                Case 4
                    dgvCAdj.DataSource = Database.GetResults(cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvCAdj.Rows.Count <= 0 Then dgvCAdj.DataSource = Nothing
                Case Else
                    ' Conditions not met.
            End Select
        End Using
    End Sub

    Private Sub GetProcessedDTRFileInfo()
        Using cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_getprocdtrfileinfo (@dtrpid)
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@dtrpid", cboLProcFiles.SelectedValue))
            End With
            Dim Dt As New DataTable
            Dt = Database.GetResults(cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            If Dt.Rows.Count > 0 Then
                For Each Dr As DataRow In Dt.Rows
                    txtHPM.Text = Dr(1)
                    txtHPY.Text = Dr(2)
                    txtHPCS.Text = Dr(3)
                    txtHPCE.Text = Dr(4)
                    txtHPD.Text = Dr(5)
                    txtHTPL.Text = Dr(6)
                Next
            Else
                txtHPM.Clear()
                txtHPY.Clear()
                txtHPCS.Clear()
                txtHPCE.Clear()
                txtHPD.Clear()
                txtHTPL.Clear()
            End If
        End Using
    End Sub

    Private Sub GetProcessedDTRDetails()
        Using cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_getprocdtrdetail (@dtrpid);
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@dtrpid", cboLProcFiles.SelectedValue))
            End With
            dgvHDTR.DataSource = Database.GetResults(cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            If dgvHDTR.Rows.Count <= 0 Then dgvHDTR.DataSource = Nothing
        End Using
    End Sub

    Private Sub GetProcessedDTRRates()
        Using cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_getprocdtrsummary (@dtrpid);
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@dtrpid", cboLProcFiles.SelectedValue))
            End With
            dgvHDTRR.DataSource = Database.GetResults(cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            If dgvHDTRR.Rows.Count <= 0 Then dgvHDTRR.DataSource = Nothing
        End Using
    End Sub

    Private Function ValidateEmployeeInformation(ByVal EmployeeNo As String, EmployeeName As String, Optional ByVal EmployeeClass As Int64 = 1, Optional ByVal EmployeeGroup As Int64 = 0) As Boolean
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>

                                 </Command>.Value
        End Using
        Return False
    End Function

    Private Sub ProcessDTRFilev2(ByVal SourceFile As String)
        Dim startPos As Integer = InStr(SourceFile, ".", CompareMethod.Text)
        lblProcStat.Text = "Validating file before processing..."
        If Mid(SourceFile, startPos, 5).Replace(".", "") = "xlsx" Or Mid(SourceFile, startPos, 5).Replace(".", "") = "xls" Then

            ' Declarations
            Dim xlsApp As Excel.Application = Nothing
            Dim xlsWkb As Excel.Workbook = Nothing
            Dim xlsWks As Excel.Worksheet = Nothing

            Dim xCols As Integer = 1, xRows As Integer = 1

            Try

                xlsApp = New Excel.Application
                xlsWkb = xlsApp.Workbooks.Open(SourceFile)

                For Each xlsWks In xlsWkb.Worksheets
                    xlsWks.Activate()
                    Select Case xlsWks.Name
                        Case "DTR"
                            ' Get header contents of DTR
                            lblProcStat.Text = "Reading DTR headers..."
                            With xlsWks
                                dPayYear = .Cells(1, 2).Value
                                dPayMonth = .Cells(1, 3).Value
                                dPayCutOffStart = .Cells(1, 4).Value
                                dPayCutOffEnd = .Cells(1, 5).Value
                                dPayDay = .Cells(1, 6).Value
                                dProcessedEmpClass = .Cells(1, 7).Value
                                dProcessedEmpGroup = .Cells(1, 8).Value
                            End With
                            lblProcStat.Text = "Reading DTR headers... DONE!"

                            ' Get DTR Trailer information
                            lblProcStat.Text = "Reading DTR content trailer..."
                            xRows = 1
                            ProcessedLines = 0
                            With xlsWks
                                While Not .Cells(xRows, 1).Value = ""
                                    If .Cells(xRows, 1).Value = "D" Then
                                        ProcessedLines += 1
                                    ElseIf .Cells(xRows, 1).Value = "T" Then
                                        dTotalLines = .Cells(xRows, 5).Value
                                    Else
                                        ' No conditions met.
                                    End If

                                    xRows += 1
                                End While
                            End With
                            lblProcStat.Text = "Reading DTR content trailer...DONE!"

                            ' Check if DTR Detail count matches with actual lines to process.
                            lblProcStat.Text = "Validating DTR content trailer..."
                            If Not ProcessedLines = dTotalLines Then
                                MsgBox("DTR Trailer details does not match with total lines to process. Please check the contents of the file then try again.", MsgBoxStyle.Critical, "File Process Error")

                                xlsWkb.Close()
                                xlsApp.Quit()

                                ReleaseObject(xlsWks)
                                ReleaseObject(xlsWkb)
                                ReleaseObject(xlsApp)

                                lblProcStat.Text = "Validating DTR content trailer... FAILED! Due to Line summary does not match to actual lines to process."

                                Exit Sub
                            End If
                            lblProcStat.Text = "Validating DTR content trailer... DONE!"

                        Case "ADJUSTMENTS"
                            ' Get header contents of ADJUSTMENTS
                            lblProcStat.Text = "Reading ADJUSTMENTS content headers..."
                            With xlsWks
                                aPayYear = .Cells(1, 2).Value
                                aPayMonth = .Cells(1, 3).Value
                                aPayCutOffStart = .Cells(1, 4).Value
                                aPayCutOffEnd = .Cells(1, 5).Value
                                aPayDay = .Cells(1, 6).Value
                                aProcessedEmpClass = .Cells(1, 7).Value
                                aProcessedEmpGroup = .Cells(1, 8).Value
                            End With
                            lblProcStat.Text = "Reading ADJUSTMENTS content headers... DONE!"

                            ' Get ADJUSTMENTS Trailer information
                            lblProcStat.Text = "Reading ADJUSTMENTS content trailer..."
                            xRows = 1
                            ProcessedLines = 0
                            With xlsWks
                                While Not .Cells(xRows, 1).Value = ""
                                    If .Cells(xRows, 1).Value = "D" Then
                                        ProcessedLines += 1
                                    ElseIf .Cells(xRows, 1).Value = "T" Then
                                        aTotalLines = .Cells(xRows, 5).Value
                                    Else
                                        ' No conditions met.
                                    End If

                                    xRows += 1
                                End While
                            End With
                            lblProcStat.Text = "Reading ADJUSTMENTS content trailer... DONE!"
                        Case "ADJUSTMENT REFERENCE"
                            ' Bypass worksheet.
                        Case Else
                            ' No conditions have been met.
                    End Select
                Next

                ' Check if DTR and ADJUSTMENT Header data matches.
                lblProcStat.Text = "Validating content headers..."
                If Not dPayYear = aPayYear Or Not dPayMonth = aPayMonth Or Not dPayDay = aPayDay Or _
                   Not dPayCutOffStart = aPayCutOffStart Or Not dPayCutOffEnd = aPayCutOffEnd Or _
                   Not dProcessedEmpClass = aProcessedEmpClass Or Not dProcessedEmpGroup = aProcessedEmpGroup Then

                    MsgBox("The system cannot process the file due to contents DTR and ADJUSTMENTS have different header information." + vbCrLf + _
                           "Please correct the contents then try again.", MsgBoxStyle.Critical, "File Process Error")

                    lblProcStat.Text = "Validating content headers... FAILED! Due to content mismatch."
                    Exit Sub
                End If
                lblProcStat.Text = "Validating content headers... DONE!"

                ' Check if ADJUSTMENT Detail count matches with actual lines to process.
                lblProcStat.Text = "Validating ADJUSTMENTS content trailer..."
                If Not ProcessedLines = aTotalLines Then
                    MsgBox("ADJUSTMENT Trailer details does not match with total lines to process. Please check the contents of the file then try again.", MsgBoxStyle.Critical, "File Process Error")

                    lblProcStat.Text = "Validating ADJUSTMENTS content trailer... FAILED! Due to Line summary does not match to actual lines to process."

                    Exit Sub
                End If
                lblProcStat.Text = "Validating ADJUSTMENTS content trailer... DONE!"

                ' Check if file contents have been processed earlier.
                lblProcStat.Text = "Validating File from the server..."
                Call ProcessDTRFile(-1)
                If rIsPosted = "Posted" Then
                    MsgBox("Unable to process file due to file contents have already been posted on " + rDatePosted.ToString + vbCrLf + _
                           "by " + rProcessesor + ".", MsgBoxStyle.Exclamation, "Error Processing DTR")

                    lblProcStat.Text = "File/Payroll file cannot be processed  due to file already been marked as POSTED and cannot be modified."

                    Exit Sub
                End If

                lblProcStat.Text = "Awaiting user command..."
                If rProcessesor.Length > 0 Then
                    If MsgBox(rProcessesor + " already processed a file in reference to " + vbCrLf + _
                          "Payroll Period : " + dPayMonth.ToString.PadLeft(2, "0") + "/" + dPayDay.ToString.PadLeft(2, "0") + "/" + dPayYear.ToString + vbCrLf + _
                          "by " + rProcessesor + ". Reprocess DTR file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Re-process DTR") = MsgBoxResult.No Then
                        rFilename = ""
                        rProcessesor = ""
                        rDatePosted = Nothing
                        rIsPosted = ""

                        lblProcStat.Text = "Awaiting user command... User CANCELLED the process!"

                        Exit Try
                    End If
                End If
                lblProcStat.Text = "Validating File from the server... DONE!"

                ' Save DTR file
                lblProcStat.Text = "Saving file to the server..."
                Call ProcessDTRFile(0)
                txtCPY.Text = dPayYear
                txtCPM.Text = dPayMonth
                txtCPD.Text = dPayDay
                txtCPCS.Text = dPayCutOffStart
                txtCPCE.Text = dPayCutOffEnd
                txtCTFL.Text = dTotalLines
                txtTALines.Text = aTotalLines
                lblProcStat.Text = "Saving file to the server... DONE!"
                pnlDTRProc.Enabled = False

                'Process file contents

                For Each xlsWks In xlsWkb.Worksheets
                    xlsWks.Activate()
                    Select Case xlsWks.Name
                        Case "DTR"
                            ' Process DTR Details
                            ProcessedLines = 0
                            PCounter = 0
                            SCounter = 0
                            FCounter = 0
                            lblPFail.Text = "Failed: 0"
                            lblPProcessed.Text = "Processed: 0"
                            lblPSuccess.Text = "Success: 0"
                            xRows = 4
                            lblProcStat.Text = "Saving DTR contents to the server... 0 out of " + dTotalLines.ToString

                            With xlsWks
                                While .Cells(xRows, 1).Value = "D" Or .Cells(xRows, 1).Value = "D-"
                                    EmpNo = .Cells(xRows, 2).Value
                                    EmpName = .Cells(xRows, 3).Value
                                    Reg0 = Convert.ToDouble(.Cells(xRows, 4).Value)
                                    Reg1 = Convert.ToDouble(.Cells(xRows, 5).Value)
                                    Reg2 = Convert.ToDouble(.Cells(xRows, 6).Value)
                                    Reg3 = Convert.ToDouble(.Cells(xRows, 6).Value)

                                    Rdr0 = Convert.ToDouble(.Cells(xRows, 8).Value)
                                    Rdr1 = Convert.ToDouble(.Cells(xRows, 9).Value)
                                    Rdr2 = Convert.ToDouble(.Cells(xRows, 10).Value)
                                    Rdr3 = Convert.ToDouble(.Cells(xRows, 11).Value)

                                    Rds0 = Convert.ToDouble(.Cells(xRows, 12).Value)
                                    Rds1 = Convert.ToDouble(.Cells(xRows, 13).Value)
                                    Rds2 = Convert.ToDouble(.Cells(xRows, 14).Value)
                                    Rds3 = Convert.ToDouble(.Cells(xRows, 15).Value)

                                    Rdh0 = Convert.ToDouble(.Cells(xRows, 16).Value)
                                    Rdh1 = Convert.ToDouble(.Cells(xRows, 17).Value)
                                    Rdh2 = Convert.ToDouble(.Cells(xRows, 18).Value)
                                    Rdh3 = Convert.ToDouble(.Cells(xRows, 19).Value)

                                    Rdd0 = Convert.ToDouble(.Cells(xRows, 20).Value)
                                    Rdd1 = Convert.ToDouble(.Cells(xRows, 21).Value)
                                    Rdd2 = Convert.ToDouble(.Cells(xRows, 22).Value)
                                    Rdd3 = Convert.ToDouble(.Cells(xRows, 23).Value)

                                    Spc0 = Convert.ToDouble(.Cells(xRows, 24).Value)
                                    Spc1 = Convert.ToDouble(.Cells(xRows, 25).Value)
                                    Spc2 = Convert.ToDouble(.Cells(xRows, 26).Value)
                                    Spc3 = Convert.ToDouble(.Cells(xRows, 27).Value)

                                    Hol0 = Convert.ToDouble(.Cells(xRows, 28).Value)
                                    Hol1 = Convert.ToDouble(.Cells(xRows, 29).Value)
                                    Hol2 = Convert.ToDouble(.Cells(xRows, 30).Value)
                                    Hol3 = Convert.ToDouble(.Cells(xRows, 31).Value)

                                    Dbl0 = Convert.ToDouble(.Cells(xRows, 32).Value)
                                    Dbl1 = Convert.ToDouble(.Cells(xRows, 33).Value)
                                    Dbl2 = Convert.ToDouble(.Cells(xRows, 34).Value)
                                    Dbl3 = Convert.ToDouble(.Cells(xRows, 35).Value)

                                    Trdy = Convert.ToDouble(.Cells(xRows, 36).Value)
                                    UTme = Convert.ToDouble(.Cells(xRows, 37).Value)
                                    Abst = Convert.ToDouble(.Cells(xRows, 38).Value)
                                    Ttlh = Convert.ToDouble(.Cells(xRows, 39).Value)
                                    Ttld = Convert.ToDouble(.Cells(xRows, 40).Value)

                                    ' Check if employee is a member of the employee class/group

                                    Select Case .Cells(xRows, 1).Value
                                        Case "D"
                                            Call ProcessDTRDetail(0)
                                        Case "D-"
                                            Call ProcessDTRDetail(2)
                                        Case Else
                                            ' No conditions matched.
                                    End Select
                                    xRows += 1
                                    lblProcStat.Text = "Saving DTR contents to the server... " + (xRows - 3).ToString + " out of " + dTotalLines.ToString
                                End While
                            End With
                            lblProcStat.Text = "Saving DTR contents to the server... DONE!"

                        Case "ADJUSTMENTS"
                            ' Process ADJUSTMENT Details
                            lblProcStat.Text = "Saving ADJUSTMENT contents to the server... 0 out of " + aTotalLines.ToString
                            ProcessedLines = 0
                            PCounter = 0
                            SCounter = 0
                            FCounter = 0
                            lblPFail.Text = "Failed: 0"
                            lblPProcessed.Text = "Processed: 0"
                            lblPSuccess.Text = "Success: 0"
                            xRows = 3
                            With xlsWks
                                While .Cells(xRows, 1).Value = "D" Or .Cells(xRows, 1).Value = "D-"
                                    EmpNo = .Cells(xRows, 2).Value
                                    AdjRefId = .Cells(xRows, 4).Value
                                    If .Cells(xRows, 3).Value = "D" Then AdjValue = Convert.ToDouble(.Cells(xRows, 5).Value) * -1 Else AdjValue = Convert.ToDouble(.Cells(xRows, 5).Value)

                                    Select Case .Cells(xRows, 1).Value
                                        Case "D"
                                            Call ProcessAdjustments(0)
                                        Case "D-"
                                            Call ProcessAdjustments(2)
                                        Case Else
                                            ' No conditions matched.
                                    End Select
                                    xRows += 1
                                    lblProcStat.Text = "Saving ADJUSTMENT contents to the server... " + (xRows - 2).ToString + " out of " + aTotalLines.ToString
                                End While
                            End With
                            lblProcStat.Text = "Saving ADJUSTMENT contents to the server... DONE!"

                        Case Else
                            ' Bypass other worksheets.
                    End Select
                Next
                MsgBox("DTR has been uploaded and processed successfully.", MsgBoxStyle.Information, "SUCCESS")
                Call ProcessDTRDetail(4)
                Call ProcessAdjustments(4)
                Call LoadDataToComboBox("procdtrfiles", Declares.UserHandleId, cboLProcFiles)
                lblProcStat.Text = "DTR uploading and processing...DONE!"

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Unhandled Error ")
            Finally

                pnlDTRProc.Enabled = True
                lblPFail.Text = "Failed: 0"
                lblPProcessed.Text = "Processed: 0"
                lblPSuccess.Text = "Success: 0"
                lblProcStat.Text = "Awaiting user command..."

                xlsWkb.Close()
                xlsApp.Quit()

                ReleaseObject(xlsWks)
                ReleaseObject(xlsWkb)
                ReleaseObject(xlsApp)
            End Try

        Else '  *.edf extension

        End If
    End Sub

    Private Sub ProcessDTRFileOld(ByVal SourceFile As String)
        Dim startPos As Integer = InStr(SourceFile, ".", CompareMethod.Text)

        Select Case Mid(SourceFile, startPos, 5).Replace(".", "")
            Case "edf"
            Case "xls", "xlsx"
                Dim xlsApp As Excel.Application
                Dim xlsWkb As Excel.Workbook
                Dim xlsWks As Excel.Worksheet
                Dim xlsCols As Integer = 1, xlsRows As Integer = 1

                lblProcStat.Text = "Processing file : " + MinifiedFileName + "..."

                xlsApp = New Excel.Application
                xlsWkb = xlsApp.Workbooks.Open(SourceFile)
                xlsWks = xlsWkb.Worksheets("DTR")
                Try
                    Do While Not xlsWks.Cells(xlsCols, xlsRows).Value = ""
                        Select Case xlsWks.Cells(xlsCols, 1).Value
                            Case "H" ' Header
                                lblProcStat.Text = "Reading DTR header information..."
                                With xlsWks
                                    dPayYear = txtCPY.Text = Convert.ToInt64(.Cells(xlsCols, 2).Value)
                                    dPayMonth = txtCPM.Text = Convert.ToInt64(.Cells(xlsCols, 3).Value)
                                    dPayCutOffStart = txtCPCS.Text = Convert.ToInt64(.Cells(xlsCols, 4).Value)
                                    dPayCutOffEnd = txtCPCE.Text = Convert.ToInt64(.Cells(xlsCols, 5).Value)
                                    dPayDay = txtCPD.Text = Convert.ToInt64(.Cells(xlsCols, 6).Value)
                                    dProcessedEmpClass = Convert.ToInt64(.Cells(xlsCols, 7).Value)
                                    dProcessedEmpGroup = Convert.ToInt64(.Cells(xlsCols, 8).Value)
                                End With
                                Call ProcessDTRFile(-1)
                                If rIsPosted = "Posted" Then
                                    MsgBox("Unable to process DTR file due to file contents have already been posted on " + rDatePosted.ToString + vbCrLf + _
                                           "by " + rProcessesor + ".", MsgBoxStyle.Exclamation, "Error Processing DTR")
                                    Exit Sub
                                Else
                                    If MsgBox(rProcessesor + " already processed a DTR file in reference to " + vbCrLf + _
                                              "Payroll Period : " + dPayMonth.ToString.PadLeft(2, "0") + "/" + dPayDay.ToString.PadLeft(2, "0") + "/" + dPayYear.ToString + vbCrLf + _
                                              "by " + rProcessesor + ". Reprocess DTR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Re-process DTR") = MsgBoxResult.No Then
                                        rFilename = ""
                                        rProcessesor = ""
                                        rDatePosted = Nothing
                                        rIsPosted = ""
                                        lblProcStat.Text = "Reading DTR header information... DONE!"
                                        Exit Sub
                                    End If
                                End If
                                lblProcStat.Text = "Reading DTR header information... DONE!"
                            Case "D" ' Detail
                                ProcessedLines += 1
                                lblProcStat.Text = "Reading DTR detail information in line " + ProcessedLines.ToString + "... DONE!"

                            Case "T" ' Trail
                                lblProcStat.Text = "Reading DTR trailer information..."
                                With xlsWks
                                    If Not ProcessedLines = Convert.ToInt64(.Cells(xlsCols, 5).Value) Then
                                        lblProcStat.Text = "Error processing file " + MinifiedFileName + " due to LINE COUNT and PROCESSED COUNT mismatch."
                                        lblPFail.Text = "Failed : 1"
                                        lblPProcessed.Text = "Processed : 1"

                                        xlsWkb.Close()
                                        xlsApp.Quit()

                                        ReleaseObject(xlsWks)
                                        ReleaseObject(xlsWkb)
                                        ReleaseObject(xlsApp)
                                        lblProcStat.Text = "Reading DTR trailer information...DONE!"
                                        Exit Sub
                                    Else
                                        Call ProcessDTRFile(0)
                                        ProcessedLines = 0
                                    End If
                                End With
                                lblProcStat.Text = "Reading DTR trailer information...DONE!"
                            Case Else
                                ' L : Label
                                ' Conditions not met
                        End Select
                        xlsCols += 1
                    Loop

                    ' DTR Detail Processing
                    xlsCols = 1
                    xlsRows = 1

                    Do While Not xlsWks.Cells(xlsCols, xlsRows).Value = ""
                        With xlsWks
                            If .Cells(xlsCols, 1).Value = "D" Then
                                EmpNo = .Cells(xlsCols, 2).Value
                                Reg0 = Convert.ToDouble(.Cells(xlsCols, 3).Value)
                                Reg1 = Convert.ToDouble(.Cells(xlsCols, 4).Value)
                                Reg2 = Convert.ToDouble(.Cells(xlsCols, 5).Value)
                                Reg3 = Convert.ToDouble(.Cells(xlsCols, 6).Value)

                                Rdr0 = Convert.ToDouble(.Cells(xlsCols, 7).Value)
                                Rdr1 = Convert.ToDouble(.Cells(xlsCols, 8).Value)
                                Rdr2 = Convert.ToDouble(.Cells(xlsCols, 9).Value)
                                Rdr3 = Convert.ToDouble(.Cells(xlsCols, 10).Value)

                                Rds0 = Convert.ToDouble(.Cells(xlsCols, 11).Value)
                                Rds1 = Convert.ToDouble(.Cells(xlsCols, 12).Value)
                                Rds2 = Convert.ToDouble(.Cells(xlsCols, 13).Value)
                                Rds3 = Convert.ToDouble(.Cells(xlsCols, 14).Value)

                                Rdh0 = Convert.ToDouble(.Cells(xlsCols, 15).Value)
                                Rdh1 = Convert.ToDouble(.Cells(xlsCols, 16).Value)
                                Rdh2 = Convert.ToDouble(.Cells(xlsCols, 17).Value)
                                Rdh3 = Convert.ToDouble(.Cells(xlsCols, 18).Value)

                                Rdd0 = Convert.ToDouble(.Cells(xlsCols, 19).Value)
                                Rdd1 = Convert.ToDouble(.Cells(xlsCols, 20).Value)
                                Rdd2 = Convert.ToDouble(.Cells(xlsCols, 21).Value)
                                Rdd3 = Convert.ToDouble(.Cells(xlsCols, 22).Value)

                                Spc0 = Convert.ToDouble(.Cells(xlsCols, 23).Value)
                                Spc1 = Convert.ToDouble(.Cells(xlsCols, 24).Value)
                                Spc2 = Convert.ToDouble(.Cells(xlsCols, 25).Value)
                                Spc3 = Convert.ToDouble(.Cells(xlsCols, 26).Value)

                                Hol0 = Convert.ToDouble(.Cells(xlsCols, 27).Value)
                                Hol1 = Convert.ToDouble(.Cells(xlsCols, 28).Value)
                                Hol2 = Convert.ToDouble(.Cells(xlsCols, 29).Value)
                                Hol3 = Convert.ToDouble(.Cells(xlsCols, 30).Value)

                                Dbl0 = Convert.ToDouble(.Cells(xlsCols, 31).Value)
                                Dbl1 = Convert.ToDouble(.Cells(xlsCols, 32).Value)
                                Dbl2 = Convert.ToDouble(.Cells(xlsCols, 33).Value)
                                Dbl3 = Convert.ToDouble(.Cells(xlsCols, 34).Value)

                                Trdy = Convert.ToDouble(.Cells(xlsCols, 35).Value)
                                UTme = Convert.ToDouble(.Cells(xlsCols, 36).Value)
                                Abst = Convert.ToDouble(.Cells(xlsCols, 37).Value)
                                Ttlh = Convert.ToDouble(.Cells(xlsCols, 38).Value)
                                Ttld = Convert.ToDouble(.Cells(xlsCols, 39).Value)

                                Call ProcessDTRDetail(0)
                            End If
                        End With

                        xlsCols += 1
                    Loop

                    lblProcStat.Text = "Reading ADJUSTMENT information..."
                    xlsWks = xlsWkb.Worksheets("ADJUSTMENTS")
                    xlsCols = 1
                    xlsRows = 1

                    Do While xlsWks.Cells(xlsCols, 1).Value = ""
                        Select Case xlsWks.Cells(xlsCols, 1).Value
                            Case "H" ' Header
                                lblProcStat.Text = "Reading header information..."
                                With xlsWks
                                    aPayYear = txtCPY.Text = Convert.ToInt64(.Cells(xlsCols, 2).Value)
                                    aPayMonth = txtCPM.Text = Convert.ToInt64(.Cells(xlsCols, 3).Value)
                                    aPayCutOffStart = txtCPCS.Text = Convert.ToInt64(.Cells(xlsCols, 4).Value)
                                    aPayCutOffEnd = txtCPCE.Text = Convert.ToInt64(.Cells(xlsCols, 5).Value)
                                    aPayDay = txtCPD.Text = Convert.ToInt64(.Cells(xlsCols, 6).Value)
                                    aProcessedEmpClass = Convert.ToInt64(.Cells(xlsCols, 7).Value)
                                    aProcessedEmpGroup = Convert.ToInt64(.Cells(xlsCols, 8).Value)
                                End With

                                If Not dPayYear = aPayYear Or Not dPayMonth = aPayMonth Or Not dPayCutOffEnd = aPayCutOffEnd Or Not dPayCutOffStart = aPayCutOffStart Or Not _
                                   dPayDay = aPayDay Or Not dProcessedEmpClass = aProcessedEmpClass Or Not dProcessedEmpGroup = aProcessedEmpGroup Then
                                    MsgBox("")
                                    Exit Sub
                                End If

                                Call ProcessDTRFile(-1)
                                If rIsPosted = "Posted" Then
                                    MsgBox("Unable to process file due to file contents have already been posted on " + rDatePosted.ToString + vbCrLf + _
                                           "by " + rProcessesor + ".", MsgBoxStyle.Exclamation, "Error Processing DTR")
                                    Exit Sub
                                Else
                                    If MsgBox(rProcessesor + " already processed a file in reference to " + vbCrLf + _
                                              "Payroll Period : " + aPayMonth.ToString.PadLeft(2, "0") + "/" + aPayDay.ToString.PadLeft(2, "0") + "/" + aPayYear.ToString + vbCrLf + _
                                              "by " + rProcessesor + ". Reprocess DTR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Re-process DTR") = MsgBoxResult.No Then
                                        rFilename = ""
                                        rProcessesor = ""
                                        rDatePosted = Nothing
                                        rIsPosted = ""
                                        lblProcStat.Text = "Reading header information... DONE!"
                                        Exit Sub
                                    End If
                                End If
                                lblProcStat.Text = "Reading header information... DONE!"
                            Case "D" ' Detail
                                ProcessedLines += 1
                                lblProcStat.Text = "Reading detail information in line " + ProcessedLines.ToString + "... DONE!"

                            Case "T" ' Trail
                                lblProcStat.Text = "Reading trailer information..."
                                With xlsWks
                                    If Not ProcessedLines = Convert.ToInt64(.Cells(xlsCols, 5).Value) Then
                                        lblProcStat.Text = "Error processing file " + MinifiedFileName + " due to LINE COUNT and PROCESSED COUNT mismatch."
                                        lblPFail.Text = "Failed : 1"
                                        lblPProcessed.Text = "Processed : 1"

                                        xlsWkb.Close()
                                        xlsApp.Quit()

                                        ReleaseObject(xlsWks)
                                        ReleaseObject(xlsWkb)
                                        ReleaseObject(xlsApp)
                                        lblProcStat.Text = "Reading trailer information...DONE!"
                                        Exit Sub
                                    Else
                                        Call ProcessDTRFile(0)
                                        ProcessedLines = 0
                                    End If
                                End With
                                lblProcStat.Text = "Reading trailer information...DONE!"
                            Case Else
                                ' L : Label
                                ' Conditions not met
                        End Select
                        xlsCols += 1
                    Loop
                Catch ex As Exception
                    MsgBox("An error occured while processing file. Exeption : " + vbCrLf + _
                            ex.Message, MsgBoxStyle.Critical, "File Error")
                End Try

                Call ProcessDTRDetail(4)
                xlsWkb.Close()
                xlsApp.Quit()

                ReleaseObject(xlsWks)
                ReleaseObject(xlsWkb)
                ReleaseObject(xlsApp)
                MsgBox("Processing of DTR File " + MinifiedFileName + " succeeded.", MsgBoxStyle.Information, "Processed")
            Case Else
                ' File type not supported
        End Select

    End Sub

    Private Sub ReleaseObject(ByVal Obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Obj)
            Obj = Nothing
        Catch ex As Exception
            Obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub frmProcessPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDataToComboBox("procdtrfiles", Declares.UserHandleId, cboLProcFiles)
        If IO.Directory.Exists(DTRDirectory) = False Then IO.Directory.CreateDirectory(DTRDirectory)
        Declares.UserHandleId = 431
    End Sub

    Private Sub btnProcDTR_Click(sender As Object, e As EventArgs) Handles btnProcDTR.Click
        ofdDTR.ShowDialog()
        If IO.File.Exists(ofdDTR.FileName) = True Then
            MinifiedFileName = ofdDTR.SafeFileName
            LongFileName = ofdDTR.FileName
            txtSelDTRFile.Text = LongFileName
            Call ProcessDTRFilev2(LongFileName)
        End If
    End Sub

    Private Sub btnGenTemplate_Click(sender As Object, e As EventArgs) Handles btnGenTemplate.Click
        Dim fGenDTR As New frmDTRSetup
        fGenDTR.ShowDialog()
    End Sub

    Private Sub lnkSelDTRFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSelDTRFile.LinkClicked
        'ofdDTR.ShowDialog()
        'If IO.File.Exists(ofdDTR.FileName) = True Then
        '    MinifiedFileName = ofdDTR.SafeFileName
        '    LongFileName = ofdDTR.FileName
        '    txtSelDTRFile.Text = LongFileName
        'End If
    End Sub

    Private Sub cboLProcFiles_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLProcFiles.SelectedValueChanged
        Try
            Call GetProcessedDTRFileInfo()
            Call GetProcessedDTRDetails()
            Call GetProcessedDTRRates()
        Catch ex As Exception
            ' Bypass Error
        End Try
    End Sub

    Private Sub dgvHDTR_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvHDTR.DataBindingComplete
        For iRow As Integer = 0 To dgvHDTR.Rows.Count - 1 Step 1
            With dgvHDTR.Rows(iRow)
                For iCells As Integer = 2 To 38 Step 1
                    If Convert.ToDouble(.Cells(iCells).Value) > 0 Then
                        .Cells(iCells).Style.ForeColor = Color.Red
                    End If
                Next
            End With
        Next

        With dgvHDTR
            With .Columns(0)
                .HeaderText = "Employee No"
                .Width = 110
                .Frozen = True
            End With
            With .Columns(1)
                .HeaderText = "Employee Name"
                .Width = 300
                .Frozen = True
            End With
            With .Columns(2)
                .HeaderText = "REGULAR"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(3)
                .HeaderText = "REGOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(4)
                .HeaderText = "REGNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(5)
                .HeaderText = "REGOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(6)
                .HeaderText = "RESTDAY"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(7)
                .HeaderText = "RDOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(8)
                .HeaderText = "RDNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(9)
                .HeaderText = "RDOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(10)
                .HeaderText = "RDSPECIAL"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(11)
                .HeaderText = "RDSHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(12)
                .HeaderText = "RDSHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(13)
                .HeaderText = "RDSHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(14)
                .HeaderText = "RDHOLIDAY"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(15)
                .HeaderText = "RDRHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(16)
                .HeaderText = "RDRHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(17)
                .HeaderText = "RDRHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(18)
                .HeaderText = "RDDOUBLEH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(19)
                .HeaderText = "RDDHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(20)
                .HeaderText = "RDDHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(21)
                .HeaderText = "RDDHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(22)
                .HeaderText = "SPECIALH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(23)
                .HeaderText = "SHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(24)
                .HeaderText = "SHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(25)
                .HeaderText = "SHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(26)
                .HeaderText = "REGULARH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(27)
                .HeaderText = "RHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(28)
                .HeaderText = "RHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(29)
                .HeaderText = "RHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(30)
                .HeaderText = "DOUBLEH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(31)
                .HeaderText = "DHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(32)
                .HeaderText = "DHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(33)
                .HeaderText = "DHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(34)
                .HeaderText = "TARDY"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(35)
                .HeaderText = "UNDERTIME"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(36)
                .HeaderText = "ABSENT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(37)
                .HeaderText = "TOTAL HOURS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(38)
                .HeaderText = "TOTAL DAYS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
        End With

    End Sub

    Private Sub dgvHDTRR_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvHDTRR.DataBindingComplete
        For iRow As Integer = 0 To dgvHDTR.Rows.Count - 1 Step 1
            With dgvHDTRR.Rows(iRow)
                For iCells As Integer = 2 To 38 Step 1
                    If Convert.ToDouble(.Cells(iCells).Value) > 0 Then
                        .Cells(iCells).Style.ForeColor = Color.Red
                    End If
                Next
            End With
        Next

        With dgvHDTRR
            With .Columns(0)
                .HeaderText = "Employee No"
                .Width = 110
                .Frozen = True
            End With
            With .Columns(1)
                .HeaderText = "Employee Name"
                .Width = 300
                .Frozen = True
            End With
            With .Columns(2)
                .HeaderText = "REGULAR"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(3)
                .HeaderText = "REGOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(4)
                .HeaderText = "REGNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(5)
                .HeaderText = "REGOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "RESTDAY"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(7)
                .HeaderText = "RDOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(8)
                .HeaderText = "RDNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(9)
                .HeaderText = "RDOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(10)
                .HeaderText = "RDSPECIAL"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(11)
                .HeaderText = "RDSHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(12)
                .HeaderText = "RDSHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(13)
                .HeaderText = "RDSHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(14)
                .HeaderText = "RDHOLIDAY"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(15)
                .HeaderText = "RDRHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(16)
                .HeaderText = "RDRHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(17)
                .HeaderText = "RDRHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(18)
                .HeaderText = "RDDOUBLEH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(19)
                .HeaderText = "RDDHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(20)
                .HeaderText = "RDDHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(21)
                .HeaderText = "RDDHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(22)
                .HeaderText = "SPECIALH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(23)
                .HeaderText = "SHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(24)
                .HeaderText = "SHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(25)
                .HeaderText = "SHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(26)
                .HeaderText = "REGULARH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(27)
                .HeaderText = "RHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(28)
                .HeaderText = "RHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(29)
                .HeaderText = "RHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(30)
                .HeaderText = "DOUBLEH"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(31)
                .HeaderText = "DHOT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(32)
                .HeaderText = "DHNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(33)
                .HeaderText = "DHOTNS"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(34)
                .HeaderText = "TARDY"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(35)
                .HeaderText = "UNDERTIME"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(36)
                .HeaderText = "ABSENT"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            'With .Columns(37)
            '    .HeaderText = "TOTAL HOURS"
            '    With .DefaultCellStyle
            '        .Alignment = DataGridViewContentAlignment.MiddleRight
            '        .Format = "N2"
            '    End With
            'End With
            'With .Columns(38)
            '    .HeaderText = "TOTAL DAYS"
            '    With .DefaultCellStyle
            '        .Alignment = DataGridViewContentAlignment.MiddleRight
            '        .Format = "N2"
            '    End With
            'End With
            .Columns(37).Visible = False
            .Columns(38).Visible = False
            .Columns(39).Visible = False
            .Columns(40).Visible = False
            .Columns(41).Visible = False
            .Columns(42).Visible = False
            .Columns(43).Visible = False
            .Columns(44).Visible = False
            .Columns(45).Visible = False
        End With
    End Sub

    Private Sub dgvCDTR_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCDTR.DataBindingComplete
        For iRow As Integer = 0 To dgvCDTR.Rows.Count - 1 Step 1
            With dgvCDTR.Rows(iRow)
                For iCells As Integer = 2 To 38 Step 1
                    If Convert.ToDouble(.Cells(iCells).Value) > 0 Then
                        .Cells(iCells).Style.ForeColor = Color.Red
                    End If
                Next
            End With
        Next

        With dgvCDTR
            With .Columns(0)
                .HeaderText = "Employee No."
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Frozen = True
            End With
            With .Columns(1)
                .HeaderText = "Employee Name"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Frozen = True
            End With
            With .Columns(2)
                .HeaderText = "REGULAR"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(3)
                .HeaderText = "REGOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(4)
                .HeaderText = "REGNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(5)
                .HeaderText = "REGOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(6)
                .HeaderText = "RESTDAY"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(7)
                .HeaderText = "RDOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(8)
                .HeaderText = "RDNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(9)
                .HeaderText = "RDOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(10)
                .HeaderText = "RDSPECIAL"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(11)
                .HeaderText = "RDSHOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(12)
                .HeaderText = "RDSHNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(13)
                .HeaderText = "RDSHOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(14)
                .HeaderText = "RDHOLIDAY"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(15)
                .HeaderText = "RDRHOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(16)
                .HeaderText = "RDRHNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(17)
                .HeaderText = "RDRHOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(18)
                .HeaderText = "RDDOUBLEH"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(19)
                .HeaderText = "RDDHOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(20)
                .HeaderText = "RDDHNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(21)
                .HeaderText = "RDDHOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(22)
                .HeaderText = "SPECIALH"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(23)
                .HeaderText = "SHOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(24)
                .HeaderText = "SHNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(25)
                .HeaderText = "SHOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(26)
                .HeaderText = "REGULARH"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(27)
                .HeaderText = "RHOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(28)
                .HeaderText = "RHNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(29)
                .HeaderText = "RHOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(30)
                .HeaderText = "DOUBLEH"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(31)
                .HeaderText = "DHOT"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(32)
                .HeaderText = "DHNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(33)
                .HeaderText = "DHOTNS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(34)
                .HeaderText = "TARDY"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(35)
                .HeaderText = "UNDERTIME"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(36)
                .HeaderText = "ABSENCES"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(37)
                .HeaderText = "TOTAL HOURS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
            With .Columns(38)
                .HeaderText = "TOTAL DAYS"
                .MinimumWidth = 100
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "N6"
                End With
            End With
        End With
    End Sub

End Class