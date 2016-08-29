Imports HRISv2.HRISLibrary
Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO

Public Class frmEmployeeMaster

    Private LogsDirectory As String = Application.StartupPath + "\Logs", _
            ImportDirectory As String = Application.StartupPath + "\Import", _
            ExportDirectory As String = Application.StartupPath + "\Export", _
            LogFile As String = LogsDirectory + "\Employee-Import-Log" + Format(Now, "MMddyyyy") + ".txt", _
            EmpExportFile As String = ExportDirectory + "\Employee-Export-File" + Format(Now, "MMddyyyy") + ".xlsx"

    Private SelEmployeeId As Int64 = 0, SelEmployeeName As String = "", SelImagePath As String = ""

    Private pFirstName As String = "", pMiddleName As String = "", pLastName As String = "", pSuffix As String = "", _
            pGender As Int64 = 0, pBirthDate As Date = "01/01/1900", pCivilStatus As Int64 = 0, pEmployeeNo As String = "", _
            pBiometricsId As String = "", pOCN As String = "", pCompanyId As Int64 = 0, pEmployeeClassId As Int64 = 0, _
            pEmployeeGroupId As Int64 = 0, pDepartmentId As Int64 = 0, pDivisionId As Int64 = 0, pSectionId As Int64 = 0, pCostCenterId As Int64 = 0, pLaborClassId As Int64 = 0, pLocationId As Int64 = 0, _
            pJobPost As String = "", pHiredDate As Date = "01/01/1900", pReportingDate As Date = "01/01/1900", pSeparationDate As Date = "01/01/1900", _
            pSeparationReasonId As Int64 = 0, pSalaryRate As Double = 0, pRateType As String = "D", pIsMinimumWageEarner As Boolean = False, pTaxExemptId As Int64 = 0, _
            pTIN As String = "", pWithSSS As Boolean = True, pSSSNumber As String = "", pWithPhilhealth As Boolean = True, pPhilhealthNumber As String = "", _
            pWithHDMF As Boolean = True, pHDMFNumber As String = "", pECOLABasisId As Int64 = 0, pPayReferenceId As Int64 = 0, pPayBasisId As Int64 = 0, _
            pPayChannelId As Int64 = 0, pBanksId As Int64 = 0, pPayAccountNumber As String = ""

    Private TotalImported As Int64 = 0, TotalFailed As Int64 = 0, TotalUpdated As Int64 = 0, TotalRemoved As Int64 = 0

    Private AffectedRows As Double = 0

    Private Dt As New DataTable

    Private Sub LoadDataToComboBox(ByVal ListType As String, ReferenceId As Int64, ByRef objCombo As ComboBox)
        Try
            Declares.CmdString = _
                    <Command>
                        Call sp_loadComboList (@listtype, @referenceid);
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

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub SearchEmployees(sender As Object, e As KeyEventArgs) Handles txtEmpNo.KeyDown, txtEmpBioId.KeyDown, txtEmpOCN.KeyDown, txtFirstName.KeyDown, txtLastName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim SearchedValue As String = ""

                Select Case DirectCast(sender, TextBox).Name
                    Case "txtEmpNo"
                        SearchedValue = txtEmpNo.Text
                    Case "txtEmpBioId"
                        SearchedValue = txtEmpBioId.Text
                    Case "txtEmpOCN"
                        SearchedValue = txtEmpOCN.Text
                    Case "txtFirstName"
                        SearchedValue = txtFirstName.Text
                    Case "txtLastName"
                        SearchedValue = txtLastName.Text
                    Case Else
                        SearchedValue = ""
                End Select

                Declares.CmdString = "Call sp_searchemployee (@searchedvalue);"
                Declares.CmdParameterList = New ArrayList
                With Declares.CmdParameterList
                    .Add(New MySqlParameter("@searchedvalue", SearchedValue))
                End With
                Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                    dgvEMS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvEMS.Rows.Count <= 0 Then
                        MsgBox("Unable to find employee in the database.", MsgBoxStyle.Exclamation, "Search Result")
                        btnCancel.PerformClick()
                    End If

                End Using
            Catch ex As Exception
                MsgBox("Error loading results to grid " + vbCrLf + _
                        "Error Detais : " + ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub TranEmployeeProfile(ByVal TranType As Integer)
        Try
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Declares.CmdString = _
                    <Command>
                        Call sp_tranemployeeprofile ( @ttype, @recid, @lname, @fname, @mname, @sfx, @gndr, @bdate, @csid,			
                                                      @empno, @bioid, @ocn, @pimg, @cid, @ecid, @egid, 
                                                      @deid, @diid, @seid, @ccid, @lcid, @locid, @jpost, @hdate, @rdate, @ldate, @lrid,	
                                                      @srate, @rtype, @mwe, @teid, @tno, @wsss, @sno, @wph, @pno, @whdmf,		
                                                      @hno, @ebid, @prid, @pbid, @pcid, @pbkid, @pano, 
                                                      @userid );
                    </Command>.Value
                Declares.CmdParameterList = New ArrayList
                With Declares.CmdParameterList
                    .Add(New MySqlParameter("@ttype", TranType))
                    .Add(New MySqlParameter("@recid", SelEmployeeId))
                    .Add(New MySqlParameter("@lname", txtLastName.Text))
                    .Add(New MySqlParameter("@fname", txtFirstName.Text))
                    .Add(New MySqlParameter("@mname", txtMiddleName.Text))
                    .Add(New MySqlParameter("@sfx", txtSuffix.Text))
                    .Add(New MySqlParameter("@gndr", cboGender.SelectedIndex))
                    .Add(New MySqlParameter("@bdate", dtpBDate.Value))
                    .Add(New MySqlParameter("@csid", cboCStatus.SelectedIndex))
                    .Add(New MySqlParameter("@empno", txtEmpNo.Text))
                    .Add(New MySqlParameter("@bioid", txtEmpBioId.Text))
                    .Add(New MySqlParameter("@ocn", txtEmpOCN.Text))

                    If SelImagePath.Length > 0 Then
                        Using imgPic As Image = Image.FromFile(SelImagePath)
                            Using imgStream As New MemoryStream()
                                imgPic.Save(imgStream, Imaging.ImageFormat.Jpeg)
                                .Add(New MySqlParameter("@pimg", imgStream.GetBuffer()))
                            End Using
                        End Using
                    Else
                        .Add(New MySqlParameter("@pimg", Nothing))
                    End If

                    .Add(New MySqlParameter("@cid", cboEmpComp.SelectedValue))
                    .Add(New MySqlParameter("@ecid", cboEmpClass.SelectedValue))
                    .Add(New MySqlParameter("@egid", cboEmpGroup.SelectedValue))
                    .Add(New MySqlParameter("@deid", cboEmpDept.SelectedValue))
                    .Add(New MySqlParameter("@diid", cboEmpDivi.SelectedValue))
                    .Add(New MySqlParameter("@seid", cboEmpSect.SelectedValue))
                    .Add(New MySqlParameter("@ccid", cboEmpCC.SelectedValue))
                    .Add(New MySqlParameter("@lcid", cboEmpLC.SelectedValue))
                    .Add(New MySqlParameter("@locid", cboEmpLoc.SelectedValue))
                    .Add(New MySqlParameter("@jpost", txtEmpJP.Text))
                    .Add(New MySqlParameter("@hdate", dtpEmpHD.Value))
                    .Add(New MySqlParameter("@rdate", dtpEmpRD.Value))
                    .Add(New MySqlParameter("@ldate", dtpEmpLD.Value))
                    .Add(New MySqlParameter("@lrid", cboEmpLR.SelectedIndex))
                    .Add(New MySqlParameter("@srate", txtEmpSR.Text))
                    .Add(New MySqlParameter("@rtype", cboRateType.SelectedValue))
                    .Add(New MySqlParameter("@mwe", chkEmpMW.Checked))
                    .Add(New MySqlParameter("@teid", cboEmpTxT.SelectedValue))
                    .Add(New MySqlParameter("@tno", txtTin.Text))
                    .Add(New MySqlParameter("@wsss", chkSSS.Checked))
                    .Add(New MySqlParameter("@sno", txtEmpSNo.Text))
                    .Add(New MySqlParameter("@wph", chkPH.Checked))
                    .Add(New MySqlParameter("@pno", txtEmpPHNo.Text))
                    .Add(New MySqlParameter("@whdmf", chkHDMF.Checked))
                    .Add(New MySqlParameter("@hno", txtEmpHNo.Text))
                    .Add(New MySqlParameter("@ebid", cboEmpEB.SelectedValue))
                    .Add(New MySqlParameter("@prid", cboEmpPR.SelectedValue))
                    .Add(New MySqlParameter("@pbid", cboEmpPyB.SelectedValue))
                    .Add(New MySqlParameter("@pcid", cboEmpPC.SelectedValue))
                    .Add(New MySqlParameter("@pbkid", cboEmpPB.SelectedValue))
                    .Add(New MySqlParameter("@pano", txtEmpAN.Text))
                    .Add(New MySqlParameter("@userid", Declares.UserHandleId))
                End With

                Select Case TranType
                    Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                        AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                    Case 4 ' Get Employee List/Information
                        dgvEMS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                        If dgvEMS.Rows.Count <= 0 Then dgvEMS.DataSource = Nothing
                    Case 5 ' Print
                    Case Else
                        MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
                End Select

                Dim SelEmpInfo As String = txtEmpNo.Text + ": " + txtLastName.Text + ", " + txtFirstName.Text

                Select Case TranType
                    Case 0 ' Insert
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Employee : " + SelEmpInfo + " due to EMPLOYEE PROFILE already exists." + _
                                   "The system does not allow duplicates. Please key in a unique EMPLOYEE information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Saving of NEW EMPLOYEE information succeeded.", MsgBoxStyle.Information, "SAVED")
                        End If
                    Case 1 ' Update
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Employee : " + SelEmpInfo + " due to EMPLOYEE PROFILE already exists." + _
                                   "The system does not allow duplicates. Please key in a unique EMPLOYEE information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Updating of EMPLOYEE PROFILE succeeded.", MsgBoxStyle.Information, "UPDATED")
                        End If
                    Case 2 ' Delete
                        MsgBox("Employee has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                    Case 3 ' Purge
                        MsgBox("All INACTIVE Region has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                    Case Else
                End Select

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Unhandled Error")
        End Try
    End Sub

    Private Function ProcessEmployeeFromImport(ByVal TranType As Integer) As Boolean
        Dim ProcResults As Boolean = False

        Try
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Declares.CmdString = _
                    <Command>
                        Call sp_procemployeeimport ( @ttype, @recid, @lname, @fname, @mname, @sfx, @gndr, @bdate, @csid,			
                                                     @empno, @bioid, @ocn, @pimg, @cid, @ecid, @egid, 
                                                     @deid, @diid, @seid, @ccid, @lcid, @locid, @jpost, @hdate, @rdate, @ldate, @lrid,	
                                                     @msalary, @mwe, @teid, @tno, @wsss, @sno, @wph, @pno, @whdmf,		
                                                     @hno, @ebid, @prid, @pbid, @pcid, @pbkid, @pano, 
                                                     @userid );
                    </Command>.Value
                Declares.CmdParameterList = New ArrayList
                With Declares.CmdParameterList
                    .Add(New MySqlParameter("@ttype", TranType))
                    .Add(New MySqlParameter("@recid", 0))
                    .Add(New MySqlParameter("@lname", pLastName))
                    .Add(New MySqlParameter("@fname", pFirstName))
                    .Add(New MySqlParameter("@mname", pMiddleName))
                    .Add(New MySqlParameter("@sfx", pSuffix))
                    .Add(New MySqlParameter("@gndr", pGender))
                    .Add(New MySqlParameter("@bdate", pBirthDate))
                    .Add(New MySqlParameter("@csid", pCivilStatus))
                    .Add(New MySqlParameter("@empno", pEmployeeNo))
                    .Add(New MySqlParameter("@bioid", pBiometricsId))
                    .Add(New MySqlParameter("@ocn", pOCN))
                    .Add(New MySqlParameter("@pimg", Nothing))
                    .Add(New MySqlParameter("@cid", pCompanyId))
                    .Add(New MySqlParameter("@ecid", pEmployeeClassId))
                    .Add(New MySqlParameter("@egid", pEmployeeGroupId))
                    .Add(New MySqlParameter("@deid", pDepartmentId))
                    .Add(New MySqlParameter("@diid", pDivisionId))
                    .Add(New MySqlParameter("@seid", pSectionId))
                    .Add(New MySqlParameter("@ccid", pCostCenterId))
                    .Add(New MySqlParameter("@lcid", pLaborClassId))
                    .Add(New MySqlParameter("@locid", pLocationId))
                    .Add(New MySqlParameter("@jpost", pJobPost))
                    .Add(New MySqlParameter("@hdate", pHiredDate))
                    .Add(New MySqlParameter("@rdate", pReportingDate))
                    .Add(New MySqlParameter("@ldate", pSeparationDate))
                    .Add(New MySqlParameter("@lrid", pSeparationReasonId))
                    .Add(New MySqlParameter("@msalary", pSalaryRate))
                    .Add(New MySqlParameter("@mwe", pIsMinimumWageEarner))
                    .Add(New MySqlParameter("@teid", pTaxExemptId))
                    .Add(New MySqlParameter("@tno", pTIN))
                    .Add(New MySqlParameter("@wsss", pWithSSS))
                    .Add(New MySqlParameter("@sno", pSSSNumber))
                    .Add(New MySqlParameter("@wph", pWithPhilhealth))
                    .Add(New MySqlParameter("@pno", pPhilhealthNumber))
                    .Add(New MySqlParameter("@whdmf", pWithHDMF))
                    .Add(New MySqlParameter("@hno", pHDMFNumber))
                    .Add(New MySqlParameter("@ebid", pECOLABasisId))
                    .Add(New MySqlParameter("@prid", pPayReferenceId))
                    .Add(New MySqlParameter("@pbid", pPayBasisId))
                    .Add(New MySqlParameter("@pcid", pPayChannelId))
                    .Add(New MySqlParameter("@pbkid", pBanksId))
                    .Add(New MySqlParameter("@pano", pPayAccountNumber))
                    .Add(New MySqlParameter("@userid", Declares.UserHandleId))
                End With

                Select Case TranType
                    Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                        AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                        If AffectedRows = 0 Then
                            TotalFailed += 1
                            ProcResults = False
                        Else
                            TotalImported += 1
                            ProcResults = True
                        End If
                    Case 4 ' Get Employee List/Information
                        dgvEMS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                        If dgvEMS.Rows.Count <= 0 Then dgvEMS.DataSource = Nothing
                    Case 5 ' Print
                    Case Else
                        MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
                End Select
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Unhandled Error")
        End Try
        Return ProcResults
    End Function

    Private Sub LogToFile(ByVal LogMessage As String)
        Using EmpLogFile As New StreamWriter(LogFile, True)
            EmpLogFile.WriteLine(Format(Now, "dd-MMM-yyyy hh:mm:ss") + vbTab + LogMessage)
        End Using
    End Sub

    Private Sub btnSelImg_Click(sender As Object, e As EventArgs) Handles btnSelImg.Click
        ofdEmpImg.InitialDirectory = "C:\"
        ofdEmpImg.ShowDialog()
        picEmpImg.Image = Image.FromFile(ofdEmpImg.FileName)
        SelImagePath = ofdEmpImg.FileName
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLastName.Text.Length = 0 Then
            MsgBox("Error saving employee information, LAST NAME field cannot be empty. Please supply a valid value then try again.", vbExclamation, "Error")
            txtLastName.Focus()
            Exit Sub
        End If
        If txtFirstName.Text.Length = 0 Then
            MsgBox("Error saving employee information, FIRST NAME field cannot be empty. Please supply a valid value then try again.", vbExclamation, "Error")
            txtFirstName.Focus()
            Exit Sub
        End If
        If cboGender.SelectedIndex <= 0 Then
            MsgBox("Invalid value selected for GENDER field. Please select from MALE or FEMALE then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If dtpBDate.Value = Convert.ToDateTime("01/01/1900") Then
            MsgBox("Invalid value selected for BIRTH DATE field. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpComp.SelectedValue = 0 Then
            MsgBox("Invalid COMPANY affiliation selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpDept.SelectedValue = 0 Then
            MsgBox("Invalid DEPARTMENT affliation selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpDivi.SelectedValue = 0 Then
            MsgBox("Invalid DIVISION affliation selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpSect.SelectedValue = 0 Then
            MsgBox("Invalid SECTION affliation selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtEmpJP.Text.Length = 0 Then
            MsgBox("Error saving employee information, JOB POSITION field cannot be empty. Please supply a valid value then try again.", vbExclamation, "Error")
            txtEmpJP.Focus()
            Exit Sub
        End If
        If cboEmpClass.SelectedValue = 0 Then
            MsgBox("Invalid EMPLOYEE CLASS selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        'If dtpEmpHD.Value < Now Then
        '    MsgBox("Invalid HIRE DATE value selected. Please select a valid date value then try again.", MsgBoxStyle.Exclamation, "Error")
        '    Exit Sub
        'End If
        'If dtpEmpRD.Value < Now Then
        '    MsgBox("Invalid REPORTING DATE value selected. Please select a valid date value then try again.", MsgBoxStyle.Exclamation, "Error")
        '    Exit Sub
        'End If
        If cboEmpPR.SelectedValue = 0 Then
            MsgBox("Invalid PAYROLL REFERENCE value selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpPyB.SelectedValue = 0 Then
            MsgBox("Invalid PAYROLL PAY BASIS value selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpPC.SelectedValue = 0 Then
            MsgBox("Invalid PAYMENT CHANNEL value selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEmpPB.SelectedValue = 0 Then
            MsgBox("Invalid PAYMENT BANK value selected. Please select a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtEmpAN.Text.Length = 0 Then
            MsgBox("PAYROLL ACCOUNT NUMBER cannpt be EMPTY or NULL. Please enter a valid value then try again.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If btnSave.Text = "Save" Then
            If MsgBox("Save new Employee information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
                Call TranEmployeeProfile(0) ' Add Employee Information
                Call TranEmployeeProfile(4) ' Refresh Employee Grid
                Call btnCancel.PerformClick()
            End If
        ElseIf btnSave.Text = "Update" Then
            If MsgBox("Update employee information of " + SelEmployeeName + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                Call TranEmployeeProfile(1) ' Update Employee Information
                Call TranEmployeeProfile(4) ' Refresh Employee Grid
                Call btnCancel.PerformClick()
            End If
        Else
            ' Nothing matches the condition
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Employee Information
        txtEmpNo.Clear()
        txtEmpBioId.Clear()
        txtEmpOCN.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtSuffix.Clear()
        cboGender.SelectedIndex = 0
        dtpBDate.Value = "01/01/1900"
        cboCStatus.SelectedValue = 0
        txtTin.Clear()
        txtEmpSNo.Clear()
        txtEmpHNo.Clear()
        txtEmpPHNo.Clear()
        picEmpImg.Image = picEmpImg.InitialImage

        ' Employment Details
        cboEmpComp.SelectedValue = 0
        cboEmpClass.SelectedValue = 0
        cboEmpGroup.SelectedValue = 0
        cboEmpDept.SelectedValue = 0
        cboEmpDivi.SelectedValue = 0
        cboEmpSect.SelectedValue = 0
        cboEmpCC.SelectedValue = 0
        cboEmpLC.SelectedValue = 0
        cboEmpLoc.SelectedValue = 0
        txtEmpJP.Clear()
        dtpEmpHD.Value = "01/01/1900"
        dtpEmpRD.Value = "01/01/1900"
        dtpEmpLD.Value = "01/01/1900"
        cboEmpLR.SelectedIndex = 0

        ' Payroll Details
        txtEmpSR.Text = "0.00"
        cboRateType.SelectedIndex = 0
        chkEmpMW.CheckState = CheckState.Unchecked
        cboEmpPR.SelectedValue = 0
        cboEmpPyB.SelectedValue = 0
        cboEmpTxT.SelectedValue = 0
        cboEmpEB.SelectedValue = 0
        chkSSS.CheckState = CheckState.Unchecked
        chkPH.CheckState = CheckState.Unchecked
        chkHDMF.CheckState = CheckState.Unchecked
        cboEmpPC.SelectedValue = 0
        cboEmpPB.SelectedValue = 0
        txtEmpAN.Clear()

        btnSave.Text = "Save"
        txtEmpNo.Focus()

        If dgvEMS.Rows.Count <= 0 Then Call TranEmployeeProfile(4)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        ofdImportFile.ShowDialog()

        If ofdImportFile.FileName.Length = 0 Then
            Exit Sub
        End If

        If MsgBox("Proceed processing the file " + ofdImportFile.SafeFileName + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            MsgBox("User cancelled processing of the file.", MsgBoxStyle.Information, "Cancelled")
            Exit Sub
        End If

        Dim xlsApp As Excel.Application = Nothing
        Dim xlsWkb As Excel.Workbook = Nothing
        Dim xlsWks As Excel.Worksheet = Nothing

        Dim TotalLines As Int64 = 0
        Dim xRows As Int64 = 1

        Dim HasHeader As Boolean = False, HasLabel As Boolean = False, HasExpectedValue As Boolean = False, _
            HasDetail As Boolean = False, HasTrailer As Boolean = False

        Try

            btnGenerate.Enabled = False
            btnImport.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False

            Call LogToFile("Processing import file " + ofdImportFile.SafeFileName)
            Call LogToFile("Initiated import process.")
            lblPStat.Text = "Initializing importation process..."

            xlsApp = New Excel.Application
            xlsWkb = xlsApp.Workbooks.Open(ofdImportFile.FileName)
            xlsWks = xlsWkb.Worksheets(1)

            lblPStat.Text = "Initializing importation process...DONE!"

            lblPStat.Text = "Checking file contents..."
            With xlsWks
                While Not .Cells(xRows, 1).Value = ""
                    Select Case .Cells(xRows, 1).Value
                        Case "H"
                            HasHeader = True
                        Case "L"
                            HasLabel = True
                        Case "E"
                            HasExpectedValue = True
                        Case "D", "D-", "D+"
                            HasDetail = True
                            TotalLines += 1
                        Case "T"
                            HasTrailer = True
                        Case Else
                            ' No conditions met
                    End Select
                    xRows += 1
                End While
            End With

            lblPStat.Text = "Checking file contents...DONE!"

            If HasHeader = False Or HasLabel = False Or HasExpectedValue = False Or HasDetail = False Or HasTrailer = False Then
                MsgBox("The system cannot process the file due to the file contains invalid or have missing contents.", MsgBoxStyle.Critical, "Process Terminated")
                lblPStat.Text = "Awaiting file to process..."

                xlsWkb.Close()
                xlsApp.Quit()

                ReleaseObject(xlsWks)
                ReleaseObject(xlsWkb)
                ReleaseObject(xlsApp)

                Exit Try
            End If

            lblPStat.Text = "Processing file contents...0 of " + TotalLines.ToString
            xRows = 4
            With xlsWks
                While Not .Cells(xRows, 1).Value = "T"
                    If .Cells(xRows, 1).Value = "D" Or _
                       .Cells(xRows, 1).Value = "D-" Or _
                       .Cells(xRows, 1).Value = "D+" Then
                        Try
                            pLastName = .Cells(xRows, 2).Value
                            pFirstName = .Cells(xRows, 3).Value
                            pMiddleName = .Cells(xRows, 4).Value
                            pSuffix = .Cells(xRows, 5).Value
                            pGender = Convert.ToInt64(.Cells(xRows, 6).Value)
                            pBirthDate = Convert.ToDateTime(.Cells(xRows, 7).Value)
                            pCivilStatus = Convert.ToInt64(.Cells(xRows, 8).Value)
                            pEmployeeNo = .Cells(xRows, 9).Value
                            pBiometricsId = .Cells(xRows, 10).Value
                            pOCN = .Cells(xRows, 11).Value
                            pCompanyId = Convert.ToInt64(.Cells(xRows, 12).Value)
                            pEmployeeClassId = Convert.ToInt64(.Cells(xRows, 13).Value)
                            pEmployeeGroupId = Convert.ToInt64(.Cells(xRows, 14).Value)
                            pDepartmentId = Convert.ToInt64(.Cells(xRows, 15).Value)
                            pDivisionId = Convert.ToInt64(.Cells(xRows, 16).Value)
                            pSectionId = Convert.ToInt64(.Cells(xRows, 17).Value)
                            pCostCenterId = Convert.ToInt64(.Cells(xRows, 18).Value)
                            pLocationId = Convert.ToInt64(.Cells(xRows, 19).Value)
                            pLaborClassId = Convert.ToInt64(.Cells(xRows, 20).Value)
                            pJobPost = .Cells(xRows, 21).Value
                            pHiredDate = Convert.ToDateTime(.Cells(xRows, 22).Value)
                            pReportingDate = Convert.ToDateTime(.Cells(xRows, 23).Value)
                            pSeparationDate = Convert.ToDateTime(.Cells(xRows, 24).Value)
                            pSeparationReasonId = Convert.ToInt64(.Cells(xRows, 25).Value)
                            pSalaryRate = Convert.ToDouble(.Cells(xRows, 26).Value)
                            pRateType = Convert.ToInt64(.Cells(xRows, 27).Value)
                            pIsMinimumWageEarner = Convert.ToBoolean(.Cells(xRows, 28).Value)
                            pTaxExemptId = Convert.ToInt64(.Cells(xRows, 29).Value)
                            pTIN = .Cells(xRows, 30).Value
                            pWithSSS = Convert.ToBoolean(.Cells(xRows, 31).Value)
                            pSSSNumber = .Cells(xRows, 32).Value
                            pWithPhilhealth = Convert.ToBoolean(.Cells(xRows, 33).Value)
                            pPhilhealthNumber = .Cells(xRows, 34).Value
                            pWithHDMF = Convert.ToBoolean(.Cells(xRows, 35).Value)
                            pHDMFNumber = .Cells(xRows, 36).Value
                            pECOLABasisId = Convert.ToInt64(.Cells(xRows, 37).Value)
                            pPayReferenceId = Convert.ToInt64(.Cells(xRows, 38).Value)
                            pPayBasisId = Convert.ToInt64(.Cells(xRows, 39).Value)
                            pPayChannelId = Convert.ToInt64(.Cells(xRows, 40).Value)
                            pBanksId = Convert.ToInt64(.Cells(xRows, 41).Value)
                            pPayAccountNumber = .Cells(xRows, 42).Value

                            Dim EmpName As String = pLastName + IIf(Len(Trim(pSuffix)) = 0, "", " " + pSuffix) + ", " + pFirstName + IIf(Len(Trim(pMiddleName)) = 0, " ", " " + Mid(pMiddleName, 1, 1) + ".")
                            Select Case .Cells(xRows, 1).Value
                                Case "D"
                                    If ProcessEmployeeFromImport(0) = True Then
                                        Call LogToFile(EmpName + " and its information has been imported the employee masterlist.")
                                    Else
                                        Call LogToFile("Failed to import information for employee " + EmpName + ".")
                                    End If
                                Case "D+"
                                    If ProcessEmployeeFromImport(1) = True Then
                                        Call LogToFile(EmpName + " and its information has been updated from the employee masterlist.")
                                    Else
                                        Call LogToFile("Failed to update information for employee " + EmpName + ".")
                                    End If
                                Case "D-"
                                    If ProcessEmployeeFromImport(2) = True Then
                                        Call LogToFile(EmpName + " and its information has been removed from the employee masterlist.")
                                    Else
                                        Call LogToFile("Failed to remove information for employee " + EmpName + ".")
                                    End If
                                Case Else
                                    ' No conditions have been met
                            End Select

                        Catch ex As Exception
                            TotalFailed += 1
                            Call LogToFile("Error processing line " + (xRows - 3).ToString + " due to " + ex.Message)
                        End Try

                        lblPStat.Text = "Processing file contents..." + (xRows - 3).ToString + " of " + TotalLines.ToString
                        xRows += 1
                    End If
                End While
            End With

            xlsWkb.Close()
            xlsApp.Quit()

            Call LogToFile("Importation of employee masterlist succeeded.")

            MsgBox("Importation of employee masterlist succeeded." + vbCrLf + _
                   "Total records imported : " + TotalImported.ToString + vbCrLf + _
                   "Total records failed : " + TotalFailed.ToString + vbCrLf + _
                   "Total records removed : " + TotalRemoved.ToString + vbCrLf + _
                   "Total records processed : " + TotalLines.ToString, MsgBoxStyle.Information, "Importation Succeeded")

        Catch ex As Exception

            Call LogToFile("Error occured during import. " + ex.Message)

        Finally

            ReleaseObject(xlsWks)
            ReleaseObject(xlsWkb)
            ReleaseObject(xlsApp)

            btnGenerate.Enabled = True
            btnImport.Enabled = True
            btnSave.Enabled = True
            btnCancel.Enabled = True

        End Try

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Call LogToFile("Checking if exportfile already exists.")

        If File.Exists(EmpExportFile) = True Then
            If MsgBox("File already exists at " + Application.StartupPath + ". Would you like to replace the file instead?", _
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Replace") = MsgBoxResult.Yes Then
                Try
                    Call LogToFile("The file already exists, removing the file...")
                    File.Delete(EmpExportFile)
                    Call LogToFile("File has been deleted.")
                Catch ex As Exception
                    MsgBox("Unable to remove/replace file due to file is currently open or is being used by another application." + vbCrLf + _
                           "Please close the file first then try again.", MsgBoxStyle.Exclamation, "Generate Template")
                    Call LogToFile("Unable to remove file due to an application currently using the file and its resources. Terminating process.")
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If

        Call LogToFile("Initializing template generation process...")
        lblPStat.Text = "Initializing template generation process..."

        Dim xlsApp As Excel.Application = Nothing
        Dim xlsWkb As Excel.Workbook = Nothing
        Dim xlsWks As Excel.Worksheet = Nothing
        Dim xlsRng As Excel.Range = Nothing

        Call LogToFile("Initializing template generation process...SUCCESS!")
        lblPStat.Text = "Initializing template generation process... SUCCESS!"

        Try

            btnGenerate.Enabled = False
            btnImport.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False

            Call LogToFile("Scanning file contents...")
            lblPStat.Text = "Scanning file contents..."

            xlsApp = New Excel.Application
            xlsWkb = xlsApp.Workbooks.Add(Type.Missing)
            xlsWks = xlsWkb.Worksheets(1)
            xlsWks.Name = "EMPLOYEES"
            xlsWks.Activate()

            Call LogToFile("Creating template for EMPLOYEES...")
            lblPStat.Text = "Creating template for EMPLOYEES..."

            With xlsWks
                .Cells(1, 1).Value = "H"
                .Cells(2, 1).Value = "L"
                .Cells(2, 2).Value = "Last Name"
                .Cells(2, 3).Value = "First Name"
                .Cells(2, 4).Value = "Middle Name"
                .Cells(2, 5).Value = "Suffix"
                .Cells(2, 6).Value = "Gender"
                .Cells(2, 7).Value = "Birth date"
                .Cells(2, 8).Value = "Civil Status"
                .Cells(2, 9).Value = "Employee No"
                .Cells(2, 10).Value = "Biometrics Id"
                .Cells(2, 11).Value = "OCN"
                .Cells(2, 12).Value = "Company"
                .Cells(2, 13).Value = "Employee Class"
                .Cells(2, 14).Value = "Employee Group"
                .Cells(2, 15).Value = "Department"
                .Cells(2, 16).Value = "Division"
                .Cells(2, 17).Value = "Section"
                .Cells(2, 18).Value = "Cost Center"
                .Cells(2, 19).Value = "Station/Location"
                .Cells(2, 20).Value = "Labor Classification"
                .Cells(2, 21).Value = "Job Position"
                .Cells(2, 22).Value = "Date Hired"
                .Cells(2, 23).Value = "Reporting Date"
                .Cells(2, 24).Value = "Separation Date"

                .Cells(2, 25).Value = "Separation Reason"
                .Cells(2, 26).Value = "Salary Rate"
                .Cells(2, 27).Value = "Rate Type"
                .Cells(2, 28).Value = "Mininimum" + vbCrLf + "Wage Earner?"
                .Cells(2, 29).Value = "Tax Exemption Type"
                .Cells(2, 30).Value = "TIN"
                .Cells(2, 31).Value = "Deduct SSS"
                .Cells(2, 32).Value = "SSS Number"
                .Cells(2, 33).Value = "Deduct Philhealth"
                .Cells(2, 34).Value = "Philhealth Number"
                .Cells(2, 35).Value = "Deduct HDMF"
                .Cells(2, 36).Value = "HDMF Number"
                .Cells(2, 37).Value = "ECOLA Basis"
                .Cells(2, 38).Value = "Pay Reference"
                .Cells(2, 39).Value = "Pay Basis"
                .Cells(2, 40).Value = "Payroll Channel"
                .Cells(2, 41).Value = "Payroll Bank"
                .Cells(2, 42).Value = "Payroll Account No."

                ' Expected/Suggested Values
                .Cells(3, 1).Value = "E"
                .Cells(3, 6).Value = "1-Male" + vbCrLf + "2-Female"
                .Cells(3, 8).Value = "(see CIVIL STATUS sheet)"
                .Cells(3, 12).Value = "(see Company sheet)"
                .Cells(3, 13).Value = "(see Employee Class sheet)"
                .Cells(3, 14).Value = "(see Employee Group sheet)"
                .Cells(3, 15).Value = "(see Department sheet)"
                .Cells(3, 16).Value = "(see Division sheet)"
                .Cells(3, 17).Value = "(see Section sheet)"
                .Cells(3, 18).Value = "(see Cost Center sheet)"
                .Cells(3, 19).Value = "(see Location sheet)"
                .Cells(3, 20).Value = "(see Labor Classification sheet)"
                .Cells(3, 25).Value = "(see Separation Reason sheet)"
                .Cells(3, 27).Value = "(see Rate Type sheet)"
                .Cells(3, 28).Value = "0-No" + vbCrLf + "1-Yes"

                .Cells(3, 29).Value = "(see Tax Exemption Type sheet)"
                .Cells(3, 31).Value = "0-No" + vbCrLf + "1-Yes"
                .Cells(3, 33).Value = "0-No" + vbCrLf + "1-Yes"
                .Cells(3, 35).Value = "0-No" + vbCrLf + "1-Yes"
                .Cells(3, 37).Value = "(see ECOLA Basis sheet)"
                .Cells(3, 38).Value = "(see Pay Reference sheet)"
                .Cells(3, 39).Value = "(see Pay Basis sheet)"
                .Cells(3, 40).Value = "(see Pay Channel sheet)"
                .Cells(3, 41).Value = "(see Banks sheet)"
                .Cells(4, 1).Value = "D"
                .Cells(5, 1).Value = "T"
                .Cells(5, 2).Value = Year(Now).ToString
                .Cells(5, 3).Value = Month(Now).ToString
                .Cells(5, 4).Value = DatePart(DateInterval.Day, Now).ToString

                xlsRng = xlsWks.Range("A1", "AN3000")
                xlsRng.EntireRow.Font.Size = 10
                xlsRng.EntireColumn.AutoFit()

                xlsRng = xlsWks.Range("A3", "AL3")
                xlsRng.EntireRow.VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                xlsRng.EntireRow.AutoFit()

                Call LogToFile("Creating template for EMPLOYEES... DONE!")
                lblPStat.Text = "Creating template for EMPLOYEES... DONE!"

                Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                    Dim Dt As New DataTable
                    Dim xRows As Integer = 1
                    Dim xCell1 As String = "A3", xCell2 As String = ""

                    ' Civil Status
                    Call LogToFile("Creating dependency for CIVIL STATUS...")
                    lblPStat.Text = "Creating dependency for CIVIL STATUS..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(1))
                    xlsWks.Name = "Civil Status"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    With xlsWks
                        .Cells(1, 1).Value = "Reference Id"
                        .Cells(1, 2).Value = "Code"
                        .Cells(1, 3).Value = "Description"
                    End With
                    xRows = 2

                    Declares.CmdString = "select `refid`, `statuscode`, `statusdesc` from pm_civilstatus where `recordstatus` = true;"
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "C" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for CIVIL STATUS...DONE!")
                    lblPStat.Text = "Creating dependency for CIVIL STATUS...DONE!"

                    ' Company
                    Call LogToFile("Creating dependency for COMPANY...")
                    lblPStat.Text = "Creating dependency for COMPANY..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(2))
                    xlsWks.Name = "Company"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "Reference Id"
                    xlsWks.Cells(1, 2).Value = "Code"
                    xlsWks.Cells(1, 3).Value = "Company Name"
                    xRows = 2

                    Declares.CmdString = "select `refid`, `companycode`, `companyname` from pm_company where `recordstatus` = true;"
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "C" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for COMPANY...DONE!")
                    lblPStat.Text = "Creating dependency for COMPANY...DONE!"

                    ' Employee Class
                    Call LogToFile("Creating dependency for EMPLOYEE CLASS...")
                    lblPStat.Text = "Creating dependency for EMPLOYEE CLASS..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(3))
                    xlsWks.Name = "Employee Class"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "Reference Id"
                    xlsWks.Cells(1, 2).Value = "Code"
                    xlsWks.Cells(1, 3).Value = "Description"
                    xlsWks.Cells(1, 3).Value = "Company"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,  
                                                    a.`classcode`,  
                                                    a.`classdesc`,
                                                    b.`companyname`
                                            from 			`pm_employeeclass` as a
	                                            inner join 	`pm_company` as b on a.`companyid` = b.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "D" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for EMPLOYEE CLASS...DONE!")
                    lblPStat.Text = "Creating dependency for EMPLOYEE CLASS...DONE!"

                    ' Employee Group
                    Call LogToFile("Creating dependency for EMPLOYEE GROUP...")
                    lblPStat.Text = "Creating dependency for EMPLOYEE GROUP..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(4))
                    xlsWks.Name = "Employee Group"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "Reference Id"
                    xlsWks.Cells(1, 2).Value = "Code"
                    xlsWks.Cells(1, 3).Value = "Description"
                    xlsWks.Cells(1, 4).Value = "Employee Class"
                    xlsWks.Cells(1, 5).Value = "Company"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`, 
		                                            a.`egroupcode`,
                                                    a.`egroupname`,
		                                            b.`classdesc`,
                                                    c.`companyname` 
                                            from 			`pm_employeegroup` as a
	                                            inner join 	`pm_employeeclass` as b on a.`eclassid` = b.`refid`
	                                            inner join 	`pm_company`	   as c on b.`companyid` = c.`refid`	
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xlsWks.Cells(xRows, 5).Value = Dr(4)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "E" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for EMPLOYEE GROUP...DONE!")
                    lblPStat.Text = "Creating dependency for EMPLOYEE GROUP...DONE!"

                    ' Department
                    Call LogToFile("Creating dependency for DEPARTMENT...")
                    lblPStat.Text = "Creating dependency for DEPARTMENT..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(5))
                    xlsWks.Name = "DEPARTMENT"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY"
                    xlsWks.Cells(1, 3).Value = "DEPARTMENT CODE"
                    xlsWks.Cells(1, 4).Value = "DEPARTMENT NAME"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,
		                                            b.`companyname`,
		                                            a.`deptcode`,
                                                    a.`deptname`
                                            from 	`pm_department` 	as a
	                                            inner join `pm_company` as b on a.`companyid` = b.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(2)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "D" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for DEPARTMENT...DONE!")
                    lblPStat.Text = "Creating dependency for DEPARTMENT...DONE!"

                    ' Division
                    Call LogToFile("Creating dependency for DIVISION...")
                    lblPStat.Text = "Creating dependency for DIVISION..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(6))
                    xlsWks.Name = "DIVISION"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY"
                    xlsWks.Cells(1, 3).Value = "DEPARTMENT"
                    xlsWks.Cells(1, 4).Value = "DIVISION CODE"
                    xlsWks.Cells(1, 4).Value = "DIVISION NAME"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,
		                                            c.`companyname`,
		                                            b.`deptname`,
		                                            a.`divicode`,
                                                    a.`diviname`
                                            from 			`pm_division` 	as a
	                                            inner join 	`pm_department` as b on a.`deptid` = b.`refid`
	                                            inner join 	`pm_company`	as c on b.`companyid` = c.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xlsWks.Cells(xRows, 5).Value = Dr(4)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "E" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for DIVISION...DONE!")
                    lblPStat.Text = "Creating dependency for DIVISION...DONE!"

                    ' Section
                    Call LogToFile("Creating dependency for SECTION...")
                    lblPStat.Text = "Creating dependency for SECTION..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(7))
                    xlsWks.Name = "SECTION"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY"
                    xlsWks.Cells(1, 3).Value = "DEPARTMENT"
                    xlsWks.Cells(1, 4).Value = "DIVISION"
                    xlsWks.Cells(1, 5).Value = "SECTION CODE"
                    xlsWks.Cells(1, 5).Value = "SECTION NAME"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,
		                                            d.`companyname`,
		                                            c.`deptname`,
		                                            b.`diviname`,
		                                            a.`sectcode`,
                                                    a.`sectname`
                                            from 			`pm_section` 	as a
	                                            inner join	`pm_division` 	as b on a.`divisionid` = b.`refid`
	                                            inner join 	`pm_department`	as c on b.`deptid` = c.`refid`
	                                            inner join	`pm_company`	as d on c.`companyid` = d.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xlsWks.Cells(xRows, 5).Value = Dr(4)
                            xlsWks.Cells(xRows, 6).Value = Dr(5)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "F" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for SECTION...DONE!")
                    lblPStat.Text = "Creating dependency for SECTION...DONE!"

                    ' Cost Center
                    Call LogToFile("Creating dependency for COST CENTER...")
                    lblPStat.Text = "Creating dependency for COST CENTER..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(8))
                    xlsWks.Name = "COST CENTER"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY"
                    xlsWks.Cells(1, 3).Value = "DEPARTMENT"
                    xlsWks.Cells(1, 4).Value = "DIVISION"
                    xlsWks.Cells(1, 5).Value = "SECTION"
                    xlsWks.Cells(1, 6).Value = "COST CENTER CODE"
                    xlsWks.Cells(1, 7).Value = "COST CENTER "
                    xRows = 2

                    Declares.CmdString = <Command>
                                                select	e.`refid`,
		                                                a.`companyname`,
		                                                b.`deptname`,
		                                                c.`diviname`,
		                                                d.`sectname`,
		                                                e.`laborclasscode`, 
                                                        e.`laborclassdesc`
                                                from 			`pm_company` 		 as a
	                                                inner join 	`pm_department` 	 as b on a.`refid` = b.`companyid`
	                                                left  join	`pm_division`		 as c on b.`refid` = c.`deptid`
	                                                left  join	`pm_section`		 as d on c.`refid` = d.`divisionid`
	                                                left  join	`pm_laborcostcenter` as e on c.`refid` = e.`sectid`
                                                where e.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xlsWks.Cells(xRows, 5).Value = Dr(4)
                            xlsWks.Cells(xRows, 6).Value = Dr(5)
                            xlsWks.Cells(xRows, 7).Value = Dr(6)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "G" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for COST CENTER...DONE!")
                    lblPStat.Text = "Creating dependency for COST CENTER...DONE!"

                    ' Tax Exemption Types
                    Call LogToFile("Creating dependency for TAX EXEMPTION TYPE...")
                    lblPStat.Text = "Creating dependency for TAX EXEMPTION TYPE..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(9))
                    xlsWks.Name = "TAX EXEMPTION"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "TAX EXEMPTION TYPE"
                    xRows = 2

                    Declares.CmdString = "select `refid`, `taxexemptcode`, `taxexemptdesc` from `pm_taxexemptiontype` where `recordstatus` = true;"
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "C" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for TAX EXEMPTION TYPE...DONE!")
                    lblPStat.Text = "Creating dependency for TAX EXEMPTION TYPE...DONE!"

                    ' ECOLA Basis
                    Call LogToFile("Creating dependency for ECOLA BASIS...")
                    lblPStat.Text = "Creating dependency for ECOLA BASIS..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(10))
                    xlsWks.Name = "ECOLA BASIS"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY ID"
                    xlsWks.Cells(1, 3).Value = "ECOLA BASIS CODE"
                    xlsWks.Cells(1, 4).Value = "ECOLA BASIS"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,
		                                            b.`companyname`,
		                                            a.`eccode`,
                                                    a.`ecdesc`
                                            from 			`pm_ecola` 		as a
	                                            inner join 	`pm_company` 	as b on a.`companyid` = b.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "D" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for ECOLA BASIS...DONE!")
                    lblPStat.Text = "Creating dependency for ECOLA BASIS...DONE!"

                    ' Pay Reference
                    Call LogToFile("Creating dependency for PAY REFERENCE...")
                    lblPStat.Text = "Creating dependency for PAY REFERENCE..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(11))
                    xlsWks.Name = "PAY REFERENCE"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "PAY REFERENCE CODE"
                    xlsWks.Cells(1, 3).Value = "PAY REFERENCE"
                    xlsWks.Cells(1, 4).Value = "PAY REFERENCE BASIS"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select 	`refid`,  
		                                            `prcode`,
                                                    `prdesc`,
		                                            case `ratebasis` when 1 then 'Daily-Based' else 'Monthly-Based' end as refbasis  
                                            from `pm_payreference` 
                                            where `recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "D" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for PAY REFEREMCE...DONE!")
                    lblPStat.Text = "Creating dependency for PAY REFEREMCE...DONE!"

                    ' Pay Basis
                    lblPStat.Text = "Creating dependency for PAY BASIS..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(12))
                    xlsWks.Name = "PAY PERIOD"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "DESCRIPTION"
                    xRows = 2

                    Declares.CmdString = "select `refid`,  `basiscode`, `basisdesc` from `pm_paybasis` where `recordstatus` = true;"
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "B" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for PAY BASIS...DONE!")
                    lblPStat.Text = "Creating dependency for PAY BASIS...DONE!"

                    ' Pay Channel
                    Call LogToFile("Creating dependency for PAY CHANNELS...")
                    lblPStat.Text = "Creating dependency for PAY CHANNELS..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(13))
                    xlsWks.Name = "PAY CHANNEL"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY"
                    xlsWks.Cells(1, 3).Value = "PAYMENT CHANNEL"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,
		                                            b.`companyname`,
		                                            concat(a.`channelcode`, ': ', a.`channeldesc`)
                                            from 			`pm_paychannels` as a
	                                            inner join 	`pm_company`	 as b on a.`companyid` = b.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "C" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for PAY CHANNELS...DONE!")
                    lblPStat.Text = "Creating dependency for PAY CHANNELS...DONE!"

                    ' Banks
                    Call LogToFile("Creating dependency for BANKS...")
                    lblPStat.Text = "Creating dependency for BANKS..."

                    xlsWks = xlsWkb.Worksheets.Add(Type.Missing, xlsWkb.Sheets(14))
                    xlsWks.Name = "BANKS"
                    xlsWks.Activate()

                    xlsRng = xlsWks.Range("A1", "Z100")
                    xlsRng.EntireColumn.Font.Size = "10"

                    xlsRng = xlsWks.Range("A1")
                    xlsRng.AddComment("Select only the REFERENCE ID value and place it to the necessary placeholder in the EMPLOYEES sheet.")

                    xlsWks.Cells(1, 1).Value = "REFERENCE ID"
                    xlsWks.Cells(1, 2).Value = "COMPANY"
                    xlsWks.Cells(1, 3).Value = "PAY CHANNEL"
                    xlsWks.Cells(1, 4).Value = "BANK"
                    xRows = 2

                    Declares.CmdString = <Command>
                                            select	a.`refid`,
		                                            c.`companyname`,
		                                            b.`channeldesc`,
		                                            concat(a.`bankcode`, ': ', a.`bankname`)
                                            from 			`pm_banks`   		as a 
	                                            inner join	`pm_paychannels`	as b on a.`channelid` = b.`refid`
	                                            inner join	`pm_company` 		as c on b.`companyid` = c.`refid`
                                            where a.`recordstatus` = true;
                                         </Command>.Value
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            xlsWks.Cells(xRows, 1).Value = Dr(0)
                            xlsWks.Cells(xRows, 2).Value = Dr(1)
                            xlsWks.Cells(xRows, 3).Value = Dr(2)
                            xlsWks.Cells(xRows, 4).Value = Dr(3)
                            xRows += 1
                        Next
                    End If

                    xCell2 = "D" + xRows.ToString
                    xlsRng = xlsWks.Range("A1", xCell2)
                    xlsRng.EntireColumn.AutoFit()

                    Call LogToFile("Creating dependency for BANKS...DONE!")
                    lblPStat.Text = "Creating dependency for BANKS...DONE!"

                    xlsWks = xlsWkb.Sheets(1)
                    xlsWks.Activate()

                End Using

            End With

            lblPStat.Text = "Finalizing file contents..."

            xlsWkb.SaveAs(EmpExportFile)
            xlsWkb.Close()
            xlsApp.Quit()

            lblPStat.Text = "Template generation COMPLETED!"

            MsgBox("Template has been created and saved in " + Application.StartupPath, MsgBoxStyle.Information, "Success")

        Catch ex As Exception

            lblPStat.Text = "Template generation FAILED!"
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Export Error")

        Finally

            lblPStat.Text = "Releasing used resources...."
            ReleaseObject(xlsWks)
            ReleaseObject(xlsWkb)
            ReleaseObject(xlsApp)
            lblPStat.Text = "Releasing used resources....DONE!"

            btnGenerate.Enabled = True
            btnImport.Enabled = True
            btnSave.Enabled = True
            btnCancel.Enabled = True

        End Try

        lblPStat.Text = "Awaiting file to process..."

    End Sub

    Private Sub cboEmpComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEmpComp.SelectedValueChanged
        Try
            LoadDataToComboBox("department", cboEmpComp.SelectedValue, cboEmpDept)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboEmpDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEmpDept.SelectedValueChanged
        Try
            Call LoadDataToComboBox("division", cboEmpDept.SelectedValue, cboEmpDivi)
            Call LoadDataToComboBox("costcenter", cboEmpDept.SelectedValue, cboEmpCC)
            Call LoadDataToComboBox("laborclassification", cboEmpDept.SelectedValue, cboEmpLC)
            Call LoadDataToComboBox("laborlocation", cboEmpDept.SelectedValue, cboEmpLoc)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboEmpDivi_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEmpDivi.SelectedValueChanged
        Try
            LoadDataToComboBox("section", cboEmpDivi.SelectedValue, cboEmpSect)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboEmpClass_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEmpClass.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employeegroup", cboEmpClass.SelectedValue, cboEmpGroup)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub dgvEMS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEMS.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvEMS.Rows(e.RowIndex)
                    ' Employee Information
                    SelEmployeeId = Convert.ToInt64(.Cells(2).Value)
                    SelEmployeeName = .Cells(4).Value.ToString()

                    txtLastName.Text = .Cells(5).Value.ToString()
                    txtFirstName.Text = .Cells(6).Value.ToString()
                    txtMiddleName.Text = .Cells(7).Value.ToString()
                    txtSuffix.Text = .Cells(8).Value.ToString()
                    cboGender.SelectedIndex = Convert.ToInt64(.Cells(9).Value)
                    dtpBDate.Value = Convert.ToDateTime(.Cells(10).Value)
                    cboCStatus.SelectedValue = Convert.ToInt64(.Cells(11).Value)
                    txtEmpNo.Text = .Cells(12).Value.ToString()
                    txtEmpBioId.Text = .Cells(13).Value.ToString()
                    txtEmpOCN.Text = .Cells(14).Value.ToString()

                    If IsDBNull(.Cells(15).Value) = False Then
                        Dim imgBlob() As Byte = .Cells(15).Value
                        Using imgStream As New MemoryStream(imgBlob)
                            picEmpImg.Image = Image.FromStream(imgStream)
                        End Using
                    Else
                        picEmpImg.Image = picEmpImg.InitialImage
                    End If

                    cboEmpComp.SelectedValue = Convert.ToInt64(.Cells(16).Value)
                    cboEmpClass.SelectedValue = Convert.ToInt64(.Cells(17).Value)
                    cboEmpGroup.SelectedValue = Convert.ToInt64(.Cells(18).Value)
                    cboEmpDept.SelectedValue = Convert.ToInt64(.Cells(19).Value)
                    cboEmpDivi.SelectedValue = Convert.ToInt64(.Cells(20).Value)
                    cboEmpSect.SelectedValue = Convert.ToInt64(.Cells(21).Value)
                    cboEmpCC.SelectedIndex = Convert.ToInt64(.Cells(22).Value)
                    txtEmpJP.Text = .Cells(23).Value.ToString()
                    dtpEmpHD.Value = Convert.ToDateTime(.Cells(24).Value)
                    dtpEmpRD.Value = Convert.ToDateTime(.Cells(25).Value)
                    dtpEmpLD.Value = Convert.ToDateTime(.Cells(26).Value)
                    cboEmpLR.SelectedIndex = Convert.ToInt64(.Cells(27).Value)

                    txtEmpSR.Text = FormatNumber(Convert.ToDecimal(.Cells(28).Value), 2).ToString
                    cboRateType.SelectedValue = Convert.ToInt64(.Cells(29).Value)
                    chkEmpMW.Checked = Convert.ToBoolean(.Cells(30).Value)
                    cboEmpTxT.SelectedValue = Convert.ToInt64(.Cells(31).Value)
                    txtTin.Text = .Cells(32).Value.ToString()
                    chkSSS.Checked = Convert.ToBoolean(.Cells(33).Value)
                    txtEmpSNo.Text = .Cells(34).Value.ToString()
                    chkPH.Checked = Convert.ToBoolean(.Cells(35).Value)
                    txtEmpPHNo.Text = .Cells(36).Value.ToString()
                    chkHDMF.Checked = Convert.ToBoolean(.Cells(37).Value)
                    txtEmpHNo.Text = .Cells(38).Value.ToString()
                    cboEmpEB.SelectedValue = Convert.ToInt64(.Cells(39).Value)
                    cboEmpPR.SelectedValue = Convert.ToInt64(.Cells(40).Value)
                    cboEmpPyB.SelectedValue = Convert.ToInt64(.Cells(41).Value)
                    cboEmpPC.SelectedValue = Convert.ToInt64(.Cells(42).Value)
                    cboEmpPB.SelectedValue = Convert.ToInt64(.Cells(43).Value)
                    txtEmpAN.Text = .Cells(44).Value.ToString()
                End With
                btnSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete Employee " + dgvEMS.Rows(e.RowIndex).Cells(4).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelEmployeeId = Convert.ToDouble(dgvEMS.Rows(e.RowIndex).Cells(2).Value)
                    Call TranEmployeeProfile(2) ' Delete selected item
                    Call TranEmployeeProfile(4) ' Refresh List
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvEMS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEMS.DataBindingComplete
        With dgvEMS
            .Columns(2).Visible = False
            With .Columns(3)
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Employee No."
            End With
            With .Columns(4)
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Employee Name"
            End With
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            '.Columns(23).Visible = False
            With .Columns(23)
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "JOB POSITION"
            End With
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(28).Visible = False
            .Columns(29).Visible = False
            .Columns(30).Visible = False
            .Columns(31).Visible = False
            .Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            .Columns(36).Visible = False
            .Columns(37).Visible = False
            .Columns(38).Visible = False
            .Columns(39).Visible = False
            .Columns(40).Visible = False
            .Columns(41).Visible = False
            .Columns(42).Visible = False
            .Columns(43).Visible = False
            .Columns(44).Visible = False
        End With
    End Sub

    Private Sub frmEmployeeMaster_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        btnCancel.PerformClick()
        Call TranEmployeeProfile(4)
        Call LoadDataToComboBox("civilstatus", 0, cboCStatus)
        Call LoadDataToComboBox("paybasis", 0, cboEmpPyB)
        Call LoadDataToComboBox("ratetype", 0, cboRateType)
        Call LoadDataToComboBox("payreference", 0, cboEmpPR)
        Call LoadDataToComboBox("taxexemptiontype", 0, cboEmpTxT)
        cboGender.SelectedIndex = 0

        Call LoadDataToComboBox("company", 0, cboEmpComp)
        Call LoadDataToComboBox("employeeclass", cboEmpComp.SelectedValue, cboEmpClass)
        Call LoadDataToComboBox("employeegroup", cboEmpClass.SelectedValue, cboEmpGroup)
        Call LoadDataToComboBox("department", cboEmpComp.SelectedValue, cboEmpDept)
        Call LoadDataToComboBox("division", cboEmpDept.SelectedValue, cboEmpDivi)
        Call LoadDataToComboBox("section", cboEmpDivi.SelectedValue, cboEmpSect)
        Call LoadDataToComboBox("costcenter", cboEmpSect.SelectedValue, cboEmpCC)
        Call LoadDataToComboBox("ecola", cboEmpComp.SelectedValue, cboEmpEB)

        Call LoadDataToComboBox("paychannels", cboEmpComp.SelectedValue, cboEmpPC)
        Call LoadDataToComboBox("banks", cboEmpPC.SelectedValue, cboEmpPB)
    End Sub

    Private Sub frmEmployeeMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCancel.PerformClick()
        Call TranEmployeeProfile(4)
        Call LoadDataToComboBox("civilstatus", 0, cboCStatus)
        Call LoadDataToComboBox("paybasis", 0, cboEmpPyB)
        Call LoadDataToComboBox("ratetype", 0, cboRateType)
        Call LoadDataToComboBox("payreference", 0, cboEmpPR)
        Call LoadDataToComboBox("taxexemptiontype", 0, cboEmpTxT)
        cboGender.SelectedIndex = 0

        Call LoadDataToComboBox("company", 0, cboEmpComp)
        Call LoadDataToComboBox("employeeclass", cboEmpComp.SelectedValue, cboEmpClass)
        Call LoadDataToComboBox("employeegroup", cboEmpClass.SelectedValue, cboEmpGroup)
        Call LoadDataToComboBox("department", cboEmpComp.SelectedValue, cboEmpDept)
        Call LoadDataToComboBox("division", cboEmpDept.SelectedValue, cboEmpDivi)
        Call LoadDataToComboBox("section", cboEmpDivi.SelectedValue, cboEmpSect)
        Call LoadDataToComboBox("costcenter", cboEmpSect.SelectedValue, cboEmpCC)
        Call LoadDataToComboBox("ecola", cboEmpComp.SelectedValue, cboEmpEB)

        Call LoadDataToComboBox("paychannels", cboEmpComp.SelectedValue, cboEmpPC)
        Call LoadDataToComboBox("banks", cboEmpPC.SelectedValue, cboEmpPB)

        If IO.Directory.Exists(LogsDirectory) = False Then IO.Directory.CreateDirectory(LogsDirectory)
        If IO.Directory.Exists(ImportDirectory) = False Then IO.Directory.CreateDirectory(ImportDirectory)
        If IO.Directory.Exists(ExportDirectory) = False Then IO.Directory.CreateDirectory(ExportDirectory)

    End Sub

End Class