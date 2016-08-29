Imports HRISv2.HRISLibrary
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmDTRSetup

    Private DTRDirectory As String = Application.StartupPath + "\DTR", _
        DTRLogFile As String = DTRDirectory + "\DTRLog" + Format(Now(), "MMddyyyy") + ".txt", _
        DTRExportFile As String = DTRDirectory + "\DTRExportFile" + Format(Now(), "MMddyyyy") + ".xlsx"

    Dim PayrollYear As Integer = 1900, PayrollMonth As Integer = 1, PayDate As Integer = 1, _
        PayrollCOStart As Integer = 1, PayrollCOEnd As Integer = 31, PaySequence As Integer = 1

    Private Dt As New DataTable

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

    Private Sub LoadEGroupToComboBox(ByVal EmployeeClass As Int64)
        Try
            Declares.CmdString = _
                    <Command>
                        Call sp_gettemplateegroup (@eid0, @eid1);
                    </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@eid0", EmployeeClass))
                .Add(New MySqlParameter("@eid1", Declares.UserHandleId))
            End With
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Database.LoadDataToControl(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, cboEG, Declares.CmdParameterList)
            End Using
        Catch ex As Exception
            MsgBox("Error loading data to dropdown box." + vbCrLf + _
                    "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadPayoutPeriodToComboBox(ByVal EmployeeClass As Int64, EmployeeGroup As Int64)
        Try
            Declares.CmdString = _
                    <Command>
                        Call sp_gettemplatepayoutperiod (@eid0, @eid1, @eid2);
                    </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@eid0", EmployeeClass))
                .Add(New MySqlParameter("@eid1", EmployeeGroup))
                .Add(New MySqlParameter("@eid2", Declares.UserHandleId))
            End With
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Database.LoadDataToControl(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, cboPP, Declares.CmdParameterList)
            End Using
        Catch ex As Exception
            MsgBox("Error loading data to dropdown box." + vbCrLf + _
                    "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GetPayoutPeriodInformation(ByVal PayoutId As Int64)
        Try
            Declares.CmdString = _
                    <Command>
                        Call sp_getpayoutperiodinfo (@ppid);
                    </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ppid", PayoutId))
            End With
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                If Dt.Rows.Count > 0 Then
                    For Each Dr As DataRow In Dt.Rows
                        cboCOS.SelectedIndex = Convert.ToInt64(Dr(0))
                        cboCOE.SelectedIndex = Convert.ToInt64(Dr(1))
                        cboPD.SelectedIndex = Convert.ToInt64(Dr(2))
                        PaySequence = Convert.ToInt64(Dr(3))
                    Next
                Else
                    cboCOS.SelectedIndex = -1
                    cboCOE.SelectedIndex = -1
                    cboPD.SelectedIndex = -1
                    PaySequence = 0
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error loading data to dropdown box." + vbCrLf + _
                    "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GetEmployeesToProcess() As DataTable
        Try
            Declares.CmdString = _
                    <Command>
                        Call sp_getdtremployees ( @ecid, @egid, @ipe );
                    </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ecid", cboEC.SelectedValue))
                .Add(New MySqlParameter("@egid", cboEG.SelectedValue))
                .Add(New MySqlParameter("@ipe", chkProcEmp.Checked))
            End With
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            End Using
        Catch ex As Exception
            MsgBox("Error loading data to dropdown box." + vbCrLf + _
                    "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Dt
    End Function

    Private Function GetAdjustmentReference()
        Try
            Declares.CmdString = _
                    <Command>
                        select 	`refid`, `adjcode`, `adjdesc`,
		                        case `istaxable` when true then 'Yes' else 'No' end as taxable
                        from pm_adjustments
                        where `recordstatus` = true
                          and `companyid` = @cid; 
                    </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@cid", cboEC.SelectedValue))
            End With
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            End Using
        Catch ex As Exception
            MsgBox("Error loading data to dropdown box." + vbCrLf + _
                    "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Dt
    End Function

    Private Sub GenerateDTRTemplate()

        lblStat.Text = "Processing template generation..."
        lblStat.Text = "Checking DTR template if exists..."
        If IO.File.Exists(DTRExportFile) = True Then
            Try
                lblStat.Text = "Template already exists... removing file.."
                IO.File.Delete(DTRExportFile)
                lblStat.Text = "Template already exists... removing file.. DONE!"
            Catch ex As Exception
                MsgBox("Unable to generate DTR Template due to file is currently used by another process. Please close the file then try again.", MsgBoxStyle.Critical, "Error Generation")
                lblStat.Text = "Awaiting user command..."
                Exit Sub
            End Try
        End If

        lblStat.Text = "Awaiting user command..."
        If MsgBox("Proceed creating DTR template?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Create") = MsgBoxResult.No Then
            lblStat.Text = "User cancelled operation... exiting."
            Exit Sub
        Else
            btnGenerate.Enabled = False
            btnCancel.Enabled = False
            cboEC.Enabled = False
            cboEG.Enabled = False
            cboPP.Enabled = False
            cboPY.Enabled = False
            cboPM.Enabled = False
        End If

        lblStat.Text = "Preparing template for export..."

        Dim xlsApp As Excel.Application = Nothing
        Dim xlsWkb As Excel.Workbook = Nothing
        Dim xlsWks As Excel.Worksheet = Nothing
        Dim xlsRng As Excel.Range = Nothing
        Dim xRows As Integer = 1
        Dim TotalEmployees As Int64 = 0, TotalAdjReference As Int64 = 0

        lblStat.Text = "Preparing template for export...DONE!"

        Try
            lblStat.Text = "Generating DTR Template..."

            xlsApp = New Excel.Application
            xlsWkb = xlsApp.Workbooks.Add(Type.Missing)
            xlsWks = xlsWkb.Worksheets(1)
            xlsWks.Name = "DTR"
            xlsWks.Activate()

            With xlsWks
                lblStat.Text = "Generating DTR Template Header..."
                ' Header
                .Cells(1, 1).Value = "H"
                .Cells(1, 2).Value = cboPY.SelectedIndex
                .Cells(1, 3).Value = cboPM.SelectedIndex
                .Cells(1, 4).Value = cboCOS.SelectedIndex
                .Cells(1, 5).Value = cboCOE.SelectedIndex
                .Cells(1, 6).Value = cboPD.SelectedIndex
                .Cells(1, 7).Value = cboEC.SelectedValue
                .Cells(1, 8).Value = cboEG.SelectedValue
                .Cells(1, 9).Value = PaySequence
                lblStat.Text = "Generating DTR Template Header...DONE!"

                lblStat.Text = "Generating DTR Template Labels..."
                ' Label
                .Cells(2, 1).Value = "L"
                With .Range("D2", "G2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Regular"
                End With
                xlsRng = .Range("D2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("H2", "K2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Restday"
                End With
                xlsRng = .Range("H2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("L2", "O2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Restday on Special Holiday"
                End With
                xlsRng = .Range("L2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("P2", "S2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Restday on Regular Holiday"
                End With
                xlsRng = .Range("P2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("T2", "W2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Restday on Double Holiday"
                End With
                xlsRng = .Range("T2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("X2", "AA2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Special Holiday"
                End With
                xlsRng = .Range("X2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("AB2", "AE2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Regular Holiday"
                End With
                xlsRng = .Range("AB2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("AF2", "AI2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Double Holiday"
                End With
                xlsRng = .Range("AF2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("AJ2", "AL2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "Adjustments"
                End With
                xlsRng = .Range("AJ2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                With .Range("AM2", "AN2")
                    .Merge()
                    .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Value = "DTR Summary"
                End With
                xlsRng = .Range("AJ2")
                xlsRng.AddComment("All values must be converted into HOURS and with at least 6 decimal places.")

                ' Label
                .Cells(3, 1).Value = "L"
                .Cells(3, 2).Value = "Employee No."
                .Cells(3, 3).Value = "Employee Name"

                ' Regular
                .Cells(3, 4).Value = "Basic"
                .Cells(3, 5).Value = "'+ OT"
                .Cells(3, 6).Value = "'+ NS"
                .Cells(3, 7).Value = "'+OT +NS"

                ' Restday
                .Cells(3, 8).Value = "Basic"
                .Cells(3, 9).Value = "'+ OT"
                .Cells(3, 10).Value = "'+ NS"
                .Cells(3, 11).Value = "'+OT +NS"

                ' Restday on Special Holiday
                .Cells(3, 12).Value = "Basic"
                .Cells(3, 13).Value = "'+ OT"
                .Cells(3, 14).Value = "'+ NS"
                .Cells(3, 15).Value = "'+OT +NS"

                ' Restday on Regular Holiday
                .Cells(3, 16).Value = "Basic"
                .Cells(3, 17).Value = "'+ OT"
                .Cells(3, 18).Value = "'+ NS"
                .Cells(3, 19).Value = "'+OT +NS"

                ' Restday on Double Holiday
                .Cells(3, 20).Value = "Basic"
                .Cells(3, 21).Value = "'+ OT"
                .Cells(3, 22).Value = "'+ NS"
                .Cells(3, 23).Value = "'+OT +NS"

                ' Special Holiday
                .Cells(3, 24).Value = "Basic"
                .Cells(3, 25).Value = "'+ OT"
                .Cells(3, 26).Value = "'+ NS"
                .Cells(3, 27).Value = "'+OT +NS"

                ' Regular Holiday
                .Cells(3, 28).Value = "Basic"
                .Cells(3, 29).Value = "'+ OT"
                .Cells(3, 30).Value = "'+ NS"
                .Cells(3, 31).Value = "'+OT +NS"

                ' Double Holiday
                .Cells(3, 32).Value = "Basic"
                .Cells(3, 33).Value = "'+ OT"
                .Cells(3, 34).Value = "'+ NS"
                .Cells(3, 35).Value = "'+OT +NS"

                ' Adjustments
                .Cells(3, 36).Value = "Tardy"
                .Cells(3, 37).Value = "Undertime"
                .Cells(3, 38).Value = "Absences/LWOP"
                .Cells(3, 39).Value = "Total Hours"
                .Cells(3, 40).Value = "Total Days"

                xlsRng = .Range("AM3")
                xlsRng.AddComment("Formula (All Basic): " + vbCrLf + "(Regular + Restday + Restday-Special Holiday + Restday-Regular Holiday + Restday-Double Holiday + Special Holiday + Regular Holiday + Double Holiday) - (Tardy + Undertime + Absences/LWOP)")

                xlsRng = .Range("AN3")
                xlsRng.AddComment("Formula: Total Hours / 8")

                With .Range("D3", "AN3")
                    .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                End With
                lblStat.Text = "Generating DTR Template Labels...DONE!"

                ' Detail
                xRows = 4
                Dim Dt As DataTable = GetEmployeesToProcess()
                If Dt.Rows.Count > 0 Then
                    lblStat.Text = "Generating Employees for DTR template... 0 out of " + Dt.Rows.Count.ToString
                    For Each Dr As DataRow In Dt.Rows
                        .Cells(xRows, 1).Value = "D"
                        .Cells(xRows, 2).Value = Dr(0)
                        .Cells(xRows, 3).Value = Dr(1)
                        For xCols As Integer = 4 To 40 Step 1
                            .Cells(xRows, xCols).Value = 0
                        Next
                        .Range("AM" + xRows.ToString).Formula = "=SUM(AF" + xRows.ToString + ",AB" + xRows.ToString + ",X" + xRows.ToString + ",T" + xRows.ToString + ",P" + xRows.ToString + ",L" + xRows.ToString + ",H" + xRows.ToString + ",D" + xRows.ToString + ") - SUM(AJ" + xRows.ToString + ", AK" + xRows.ToString + ", AL" + xRows.ToString + ")"
                        .Range("AN" + xRows.ToString, ).Formula = "=AM" + xRows.ToString + "/8"
                        xRows += 1
                        lblStat.Text = "Generating Employees for DTR template... " + (xRows - 3).ToString + " out of " + Dt.Rows.Count.ToString
                    Next

                    With .Range("D4", "AN" + xRows.ToString)
                        .NumberFormat = "#####0.000000"
                    End With
                    lblStat.Text = "Generating Employees for DTR template... DONE!"
                Else
                    lblStat.Text = "Generating DTR template for Employees..."
                    .Cells(xRows, 1).Value = "D"
                    For xlCol As Integer = 4 To 40 Step 1
                        .Cells(xRows, xlCol).Value = 0
                    Next
                    .Range("AM" + xRows.ToString).Formula = "=SUM(AF" + xRows.ToString + ",AB" + xRows.ToString + ",X" + xRows.ToString + ",T" + xRows.ToString + ",P" + xRows.ToString + ",L" + xRows.ToString + ",H" + xRows.ToString + ",D" + xRows.ToString + ") - SUM(AJ" + xRows.ToString + ", AK" + xRows.ToString + ", AL" + xRows.ToString + ")"
                    .Range("AN" + xRows.ToString).Formula = "=AM" + xRows.ToString + "/8"
                    With .Range("D4", "AN4")
                        .NumberFormat = "#####0.000000"
                    End With
                    lblStat.Text = "Generating DTR template for Employees...DONE!"
                End If

                ' Trailer
                lblStat.Text = "Generating Trailer for DTR template..."

                .Cells(xRows, 1) = "T"
                .Cells(xRows, 2) = DatePart(DateInterval.Year, Now)
                .Cells(xRows, 3) = DatePart(DateInterval.Month, Now)
                .Cells(xRows, 4) = DatePart(DateInterval.Day, Now)
                With .Range("E" + xRows.ToString)
                    .FormulaR1C1 = "=COUNTIF(A1:A" + xRows.ToString + ",""D"")"
                End With

                With .Range("A1", "AN" + xRows.ToString)
                    .EntireColumn.AutoFit()
                    .Font.Size = 10
                End With
                lblStat.Text = "Generating Trailer for DTR template...DONE!"

                ' Adjustments
                lblStat.Text = "Generating DTR ADJUSTMENT template..."
                xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(1))
                With xlsWks
                    .Name = "ADJUSTMENTS"
                    .Activate()

                    ' Header
                    .Cells(1, 1).Value = "H"
                    .Cells(1, 2).Value = cboPY.SelectedIndex
                    .Cells(1, 3).Value = cboPM.SelectedIndex
                    .Cells(1, 4).Value = cboCOS.SelectedIndex
                    .Cells(1, 5).Value = cboCOE.SelectedIndex
                    .Cells(1, 6).Value = cboPD.SelectedIndex
                    .Cells(1, 7).Value = cboEC.SelectedValue
                    .Cells(1, 8).Value = cboEG.SelectedValue
                    .Cells(1, 9).Value = PaySequence

                    ' Label
                    .Cells(2, 1).Value = "L"
                    .Cells(2, 2).Value = "Employee No."
                    .Cells(2, 3).Value = "Adjustment Type"
                    .Cells(2, 4).Value = "Adjustment Ref.Id"
                    .Cells(2, 5).Value = "Value"

                    ' Label
                    .Cells(3, 3).Value = "D-Debit" + vbCrLf + "C-Credit"
                    .Cells(3, 4).Value = "(see ADJUSTMENT REFERENCE sheet)"
                    .Cells(3, 5).Value = "(Monetary value " + vbCrLf + "to Debit/Credit)"

                    ' Details
                    .Cells(4, 1).Value = "D"
                    .Cells(4, 5).Value = 0
                    .Range("E5").NumberFormat = "#####0.00"
                    .Range("A3", "H3").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    ' Trailer
                    lblStat.Text = "Generating Trailer for DTR template..."

                    .Cells(6, 1) = "T"
                    .Cells(6, 2) = DatePart(DateInterval.Year, Now)
                    .Cells(6, 3) = DatePart(DateInterval.Month, Now)
                    .Cells(6, 4) = DatePart(DateInterval.Day, Now)

                    With .Range("A1", "Z5000")
                        .EntireColumn.AutoFit()
                        .Font.Size = 10
                    End With
                End With
                lblStat.Text = "Generating DTR ADJUSTMENT template...DONE!"


                ' Adjustment Reference
                lblStat.Text = "Generating ADJUSTMENT Reference..."
                Dt = New DataTable
                Dt = GetAdjustmentReference()
                xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(2))
                With xlsWks
                    .Name = "ADJUSTMENT REFERENCE"
                    .Activate()

                    ' Label
                    .Cells(1, 1).Value = "Reference Id"
                    .Cells(1, 2).Value = "Code"
                    .Cells(1, 3).Value = "Description"
                    .Cells(1, 4).Value = "Taxable"

                    xRows = 2
                    If Dt.Rows.Count > 0 Then
                        lblStat.Text = "Generating ADJUSTMENT Reference... 0 out of " + Dt.Rows.Count.ToString
                        For Each Dr As DataRow In Dt.Rows
                            .Cells(xRows, 1).Value = Convert.ToInt64(Dr(0))
                            .Cells(xRows, 2).Value = Dr(1)
                            .Cells(xRows, 3).Value = Dr(2)
                            .Cells(xRows, 4).Value = Dr(3)
                            xRows += 1
                            lblStat.Text = "Generating ADJUSTMENT Reference... " + (xRows - 1).ToString + " out of " + Dt.Rows.Count.ToString
                        Next
                    End If
                    With .Range("A1", "Z100")
                        .EntireColumn.AutoFit()
                        .Font.Size = 10
                    End With
                End With
            End With

            lblStat.Text = "Saving template..."
            xlsWkb.SaveAs(DTRExportFile)
            xlsApp.Quit()

            MsgBox("DTR Template has been generated successfully." + vbCrLf + _
                   "See " + DTRDirectory + " folder to open the file.", MsgBoxStyle.Information, "DONE")

        Catch ex As Exception
            MsgBox(ex.Message + vbCrLf + "File not generated.", MsgBoxStyle.Critical, "Generation Error")

        Finally
            lblStat.Text = "Finalizing process... unloading used resources.."
            ReleaseObject(xlsWks)
            ReleaseObject(xlsWkb)
            ReleaseObject(xlsApp)

            btnGenerate.Enabled = True
            btnCancel.Enabled = True
            cboEC.Enabled = True
            cboEG.Enabled = True
            cboPP.Enabled = True
            cboPY.Enabled = True
            cboPM.Enabled = True
            lblStat.Text = "Finalizing process... unloading used resources..DONE!"
            lblStat.Text = "Awaiting user command..."
        End Try

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

    Private Sub frmDTRSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDataToComboBox("employeeclasstemplate", Declares.UserHandleId, cboEC)
        Call LoadEGroupToComboBox(cboEC.SelectedValue)
        Call LoadPayoutPeriodToComboBox(cboEC.SelectedValue, cboEG.SelectedValue)

        ' Set Default Month
        cboPM.SelectedIndex = Convert.ToInt64(DatePart(DateInterval.Month, Now))

        ' Load Year and set default
        For iYear As Integer = 1990 To Convert.ToInt64(DatePart(DateInterval.Year, Now)) + 2 Step 1
            cboPY.Items.Add(iYear)
        Next
        cboPY.SelectedIndex = CInt(cboPY.Items.Count - 3)

    End Sub

    Private Sub cboEC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEC.SelectedValueChanged
        Try
            Call LoadEGroupToComboBox(cboEC.SelectedValue)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboEG_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEG.SelectedValueChanged
        Try
            Call LoadPayoutPeriodToComboBox(cboEC.SelectedValue, cboEG.SelectedValue)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Call GenerateDTRTemplate()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cboPP_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPP.SelectedValueChanged
        Try
            Call GetPayoutPeriodInformation(cboPP.SelectedValue)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

End Class