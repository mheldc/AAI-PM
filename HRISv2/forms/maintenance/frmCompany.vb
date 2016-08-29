Imports MySql.Data.MySqlClient
Imports HRISv2.HRISLibrary

Public Class frmCompany

    Private SelCompanyId As Int64 = 0, SelCompanyName As String = ""
    Private SelDepartmentId As Int64 = 0, SelDepartmentName As String = ""
    Private SelDivisionId As Int64 = 0, SelDivisionName As String = ""
    Private SelSectionId As Int64 = 0, SelSectionName As String = ""
    Private SelLaborClassId As Int64 = 0, SelLaborLocationId As Int64 = 0
    Private SelCostCenterId As Int64 = 0
    Private SelEmpClassId As Int64 = 0, SelEmpClassName As String = ""
    Private SelEmpGroupId As Int64 = 0, SelEmpGroupName As String = ""

    Private AffectedRows As Int64 = 0
    Private Dt As DataTable

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

    Private Sub TranCompany(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranCompany (
                                            @ttype, @recid, @ccode, @cname, @caddr, @cid, @pid, @rid, 
                                            @sno, @hno, @pno, @sec, @dti, @tin, @cnos, @wsite, @userid
                                        );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelCompanyId))
                .Add(New MySqlParameter("@ccode", txtCOCode.Text))
                .Add(New MySqlParameter("@cname", txtCOName.Text))
                .Add(New MySqlParameter("@caddr", txtCOAddr.Text))
                .Add(New MySqlParameter("@cid", cboCOCity.SelectedValue))
                .Add(New MySqlParameter("@pid", cboCOProv.SelectedValue))
                .Add(New MySqlParameter("@rid", cboCORegion.SelectedValue))
                .Add(New MySqlParameter("@sno", txtCOSSS.Text))
                .Add(New MySqlParameter("@hno", txtCOHDMF.Text))
                .Add(New MySqlParameter("@pno", txtCOPH.Text))
                .Add(New MySqlParameter("@sec", txtCOSEC.Text))
                .Add(New MySqlParameter("@dti", txtCODTI.Text))
                .Add(New MySqlParameter("@tin", txtCOTIN.Text))
                .Add(New MySqlParameter("@cnos", txtCOContactNos.Text))
                .Add(New MySqlParameter("@wsite", txtCOWebsite.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvCo.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvCo.Rows.Count <= 0 Then dgvCo.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for COMPANY : " + txtCOName.Text + " due to COMPANY CODE and/or COMPANY NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique COMPANY information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW COMPANY information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for COMPANY : " + txtCOName.Text + " due to COMPANY CODE and/or COMPANY NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique COMPANY information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of COMPANY information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("COMPANY has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE COMPANY has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranDepartment(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_trandepartment ( @ttype, @recid, @cid, @dcode, @dname, @dheadid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelDepartmentId))
                .Add(New MySqlParameter("@cid", cboDeComp.SelectedValue))
                .Add(New MySqlParameter("@dcode", txtDeCode.Text))
                .Add(New MySqlParameter("@dname", txtDeName.Text))
                .Add(New MySqlParameter("@dheadid", cboCOCity.SelectedValue))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvDe.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvDe.Rows.Count <= 0 Then dgvDe.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for DEPARTMENT : " + txtDeName.Text + " due to DEPARTMENT CODE and/or DEPARTMENT NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique DEPARTMENT information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW DEPARTMENT information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for DEPARTMENT : " + txtDeName.Text + " due to DEPARTMENT CODE and/or DEPARTMENT NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique DEPARTMENT information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of DEPARTMENT information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("DEPARTMENT has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE DEPARTMENT has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranDivision(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_trandivision ( @ttype, @recid, @did, @dcode, @dname, @dheadid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelDivisionId))
                .Add(New MySqlParameter("@did", cboDiDept.SelectedValue))
                .Add(New MySqlParameter("@dcode", txtDiCode.Text))
                .Add(New MySqlParameter("@dname", txtDiName.Text))
                .Add(New MySqlParameter("@dheadid", cboDiHead.SelectedValue))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvDi.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvDi.Rows.Count <= 0 Then dgvDi.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for DIVISION : " + txtDiName.Text + " due to DIVISION CODE and/or DIVISION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique DIVISION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW DIVISION information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for DIVISION : " + txtDiName.Text + " due to DIVISION CODE and/or DIVISION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique DIVISION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of DIVISION information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("DIVISION has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE DIVISION has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranSection(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_transection ( @ttype, @recid, @did, @scode, @sname, @sheadid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelSectionId))
                .Add(New MySqlParameter("@did", cboSeDivision.SelectedValue))
                .Add(New MySqlParameter("@scode", txtSeCode.Text))
                .Add(New MySqlParameter("@sname", txtSeName.Text))
                .Add(New MySqlParameter("@sheadid", cboSeHead.SelectedValue))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvSe.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvSe.Rows.Count <= 0 Then dgvSe.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for SECTION : " + txtSeName.Text + " due to SECTION CODE and/or SECTION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique SECTION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW SECTION information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for SECTION : " + txtSeName.Text + " due to SECTION CODE and/or SECTION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique SECTION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of SECTION information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("SECTION has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE SECTION has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranEmployeeClass(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranemployeeclass ( @ttype, @recid, @compid, @clscode, @clsdesc, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelEmpClassId))
                .Add(New MySqlParameter("@compid", cboECComp.SelectedValue))
                .Add(New MySqlParameter("@clscode", txtECCode.Text))
                .Add(New MySqlParameter("@clsdesc", txtECDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvEC.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvEC.Rows.Count <= 0 Then dgvEC.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for EMPLOYEE CLASS : " + txtECDesc.Text + " due to EMPLOYEE CLASS CODE and/or EMPLOYEE CLASS NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique EMPLOYEE CLASS information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW EMPLOYEE CLASS information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for EMPLOYEE CLASS : " + txtECDesc.Text + " due to EMPLOYEE CLASS CODE and/or EMPLOYEE CLASS NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique EMPLOYEE CLASS information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of EMPLOYEE CLASS information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("EMPLOYEE CLASS has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE EMPLOYEE CLASS has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranEmployeeGroup(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranemployeegroup ( @ttype, @recid, @ecid, @egcode, @egname, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelEmpGroupId))
                .Add(New MySqlParameter("@ecid", cboEGEC.SelectedValue))
                .Add(New MySqlParameter("@egcode", txtEGCode.Text))
                .Add(New MySqlParameter("@egname", txtEGDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvEG.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvEG.Rows.Count <= 0 Then dgvEG.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for EMPLOYEE GROUP : " + txtEGDesc.Text + " due to EMPLOYEE GROUP CODE and/or EMPLOYEE GROUP NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique EMPLOYEE GROUP information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW EMPLOYEE GROUP information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for EMPLOYEE GROUP : " + txtEGDesc.Text + " due to EMPLOYEE GROUP CODE and/or EMPLOYEE GROUP NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique EMPLOYEE GROUP information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of EMPLOYEE GROUP information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("EMPLOYEE GROUP has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE EMPLOYEE GROUP has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranLaborClassification(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranlaborclassification ( @ttype, @recid, @deid, @lccode, @lcdesc, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelLaborClassId))
                .Add(New MySqlParameter("@deid", cboCLDept.SelectedValue))
                .Add(New MySqlParameter("@lccode", txtCLCode.Text))
                .Add(New MySqlParameter("@lcdesc", txtCLDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvCL.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvCL.Rows.Count <= 0 Then dgvCL.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create LABOR CLASSIFICATION : " + txtCLDesc.Text + " due to LABOR CLASSIFICATION CODE and/or LABOR CLASSIFICATION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique LABOR CLASSIFICATION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW LABOR CLASSIFICATION information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create LABOR CLASSIFICATION : " + txtCLDesc.Text + " due to LABOR CLASSIFICATION CODE and/or LABOR CLASSIFICATION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique LABOR CLASSIFICATION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of LABOR CLASSIFICATION information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("LABOR CLASSIFICATION has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE LABOR CLASSIFICATION has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranLaborLocation(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranlaborlocation ( @ttype, @recid, @deid, @lcode, @ldesc, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelLaborLocationId))
                .Add(New MySqlParameter("@deid", cboLLDept.SelectedValue))
                .Add(New MySqlParameter("@lcode", txtLLCode.Text))
                .Add(New MySqlParameter("@ldesc", txtLLDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvLL.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvLL.Rows.Count <= 0 Then dgvLL.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create LABOR LOCATION : " + txtLLDesc.Text + " due to LABOR LOCATION CODE and/or LABOR LOCATION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique LABOR LOCATION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW LABOR LOCATION information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create LABOR LOCATION : " + txtLLDesc.Text + " due to LABOR LOCATION CODE and/or LABOR LOCATION NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique LABOR LOCATION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of LABOR LOCATION information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("LABOR LOCATION has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE LABOR LOCATION has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranCostCenter(ByVal TranType As Declares.DataEventType)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_trancostcenter ( @ttype, @recid, @did, @cccode, @ccdesc, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelCostCenterId))
                .Add(New MySqlParameter("@did", cboLCDept.SelectedValue))
                .Add(New MySqlParameter("@cccode", txtLCCode.Text))
                .Add(New MySqlParameter("@ccdesc", txtLCDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvLC.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvLC.Rows.Count <= 0 Then dgvLC.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for COST CENTER : " + txtLCDesc.Text + " due to LABOR COST CENTER CODE and/or LABOR COST CENTER NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique LABOR COST CENTER information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW COST CENTER information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for LABOR COST CENTER : " + txtLCDesc.Text + " due to LABOR COST CENTER CODE and/or LABOR COST CENTER NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique LABOR COST CENTER information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of COST CENTER information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("COST CENTER has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE COST CENTER has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub GetCityLocation(ByVal CityId As Int64)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_getcitylocation (@recid);
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@recid", CityId))
            End With
            Dt = New DataTable()
            Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)

            For Each Dr As DataRow In Dt.Rows
                cboCOProv.SelectedValue = Convert.ToInt64(Dr(1))
                cboCORegion.SelectedValue = Convert.ToInt64(Dr(2))
            Next
        End Using
    End Sub

    Private Sub GetEmployeeClassInfo(ByVal EmpClassId As Int64)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_getempclassinfo (@empclassid);
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@empclassid", EmpClassId))
            End With
            Dt = New DataTable()
            Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)

            For Each Dr As DataRow In Dt.Rows
                cboECComp.SelectedValue = Convert.ToInt64(Dr(1))
                txtECCode.Text = Dr(2).ToString
                txtECDesc.Text = Dr(3).ToString
            Next
        End Using
    End Sub

    Private Sub GetEmployeeGroupInfo(ByVal EmpGroupId As Int64)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_getempgroupinfo (@empgroupid);
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@empgroupid", EmpGroupId))
            End With
            Dt = New DataTable()
            Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)

            For Each Dr As DataRow In Dt.Rows
                cboEGComp.SelectedValue = Convert.ToInt64(Dr(1))
                cboEGEC.SelectedValue = Convert.ToInt64(Dr(2))
                txtEGCode.Text = Dr(3).ToString
                txtEGDesc.Text = Dr(4).ToString
            Next
        End Using
    End Sub

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call LoadDataToComboBox("company", 0, cboDeComp)
        Call LoadDataToComboBox("company", 0, cboDiComp)
        Call LoadDataToComboBox("company", 0, cboSeComp)
        Call LoadDataToComboBox("company", 0, cboECComp)
        Call LoadDataToComboBox("company", 0, cboEGComp)
        Call LoadDataToComboBox("company", 0, cboLCComp)
        Call LoadDataToComboBox("company", 0, cboCLComp)
        Call LoadDataToComboBox("company", 0, cboLLComp)

        Call LoadDataToComboBox("city", 0, cboCOCity)
        Call LoadDataToComboBox("province", 0, cboCOProv)
        Call LoadDataToComboBox("region", 0, cboCORegion)

        Call LoadDataToComboBox("employeeclass", 0, cboEGEC)

        Call TranCompany(DataEventType.SearchNLoad)

    End Sub

    Private Sub dgvCo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCo.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvCo.Rows(e.RowIndex)
                    SelCompanyId = Convert.ToDouble(.Cells(2).Value)
                    SelCompanyName = .Cells(5).Value.ToString()
                    txtCOCode.Text = .Cells(4).Value.ToString()
                    txtCOName.Text = .Cells(5).Value.ToString()
                    txtCOAddr.Text = .Cells(6).Value.ToString()
                    cboCOCity.SelectedValue = Convert.ToDouble(.Cells(7).Value)
                    cboCOProv.SelectedValue = Convert.ToDouble(.Cells(8).Value)
                    cboCORegion.SelectedValue = Convert.ToDouble(.Cells(9).Value)
                    txtCOSSS.Text = .Cells(10).Value
                    txtCOHDMF.Text = .Cells(11).Value
                    txtCOPH.Text = .Cells(12).Value
                    txtCOSEC.Text = .Cells(13).Value
                    txtCODTI.Text = .Cells(14).Value
                    txtCOTIN.Text = .Cells(15).Value
                    txtCOContactNos.Text = .Cells(16).Value
                    txtCOWebsite.Text = .Cells(17).Value
                End With
                btnCOSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete company " + dgvCo.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelCompanyId = Convert.ToDouble(dgvCo.Rows(e.RowIndex).Cells(2).Value)
                    Call TranCompany(DataEventType.Delete)
                    Call TranCompany(DataEventType.SearchNLoad)
                    Call LoadDataToComboBox("company", 0, cboDeComp)
                    Call LoadDataToComboBox("company", 0, cboDiComp)
                    Call LoadDataToComboBox("company", 0, cboSeComp)
                    Call LoadDataToComboBox("company", 0, cboECComp)
                    Call LoadDataToComboBox("company", 0, cboEGComp)
                    SelCompanyId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvCo_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCo.DataBindingComplete
        With dgvCo
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Company Name"
                .MinimumWidth = 450
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(4).Visible = False
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
        End With
    End Sub

    Private Sub dgvDe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDe.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvDe.Rows(e.RowIndex)
                    SelDepartmentId = Convert.ToDouble(.Cells(2).Value)
                    cboDeComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    txtDeCode.Text = .Cells(6).Value
                    txtDeName.Text = .Cells(7).Value
                    cboDeHead.SelectedValue = Convert.ToDouble(.Cells(8).Value)
                End With
                btnDeSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete departmet " + dgvDe.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelDepartmentId = Convert.ToDouble(dgvDe.Rows(e.RowIndex).Cells(2).Value)
                    Call TranDepartment(DataEventType.Delete)
                    Call TranDepartment(DataEventType.SearchNLoad)
                    SelDepartmentId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvDe_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDe.DataBindingComplete
        With dgvDe
            .Columns(2).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            With .Columns(3)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Department"
            End With
            With .Columns(4)
                .MinimumWidth = 450
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Company"
            End With
        End With
    End Sub

    Private Sub dgvDi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDi.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvDi.Rows(e.RowIndex)
                    SelDivisionId = Convert.ToDouble(.Cells(2).Value)
                    cboDiComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    cboDiDept.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    txtDiCode.Text = .Cells(7).Value
                    txtDiName.Text = .Cells(8).Value
                    cboDiHead.SelectedValue = Convert.ToDouble(.Cells(9).Value)
                End With
                btnDiSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete division " + dgvDi.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelDivisionId = Convert.ToDouble(dgvDi.Rows(e.RowIndex).Cells(2).Value)
                    Call TranDivision(DataEventType.Delete)
                    Call TranDivision(DataEventType.SearchNLoad)
                    SelDivisionId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvDi_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDi.DataBindingComplete
        With dgvDi
            .Columns(2).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            With .Columns(3)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Division"
            End With
            With .Columns(4)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Department"
            End With
        End With
    End Sub

    Private Sub dgvSe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSe.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvSe.Rows(e.RowIndex)
                    SelDivisionId = Convert.ToDouble(.Cells(2).Value)
                    cboSeComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    cboSeDept.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    cboSeDivision.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                    txtSeCode.Text = .Cells(8).Value
                    txtSeName.Text = .Cells(9).Value
                    cboDiHead.SelectedValue = Convert.ToDouble(.Cells(10).Value)
                End With
                btnSeSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete section " + dgvSe.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelDivisionId = Convert.ToDouble(dgvSe.Rows(e.RowIndex).Cells(2).Value)
                    Call TranSection(DataEventType.Delete)
                    Call TranSection(DataEventType.SearchNLoad)
                    SelDivisionId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvSe_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSe.DataBindingComplete
        With dgvSe
            .Columns(2).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            With .Columns(3)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Section"
            End With
            With .Columns(4)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Division"
            End With
        End With
    End Sub

    Private Sub dgvEC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEC.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvEC.Rows(e.RowIndex)
                    SelEmpClassId = Convert.ToDouble(.Cells(2).Value)
                    Call GetEmployeeClassInfo(SelEmpClassId)
                End With
                btnECSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete employee class " + dgvEC.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelEmpClassId = Convert.ToDouble(dgvEC.Rows(e.RowIndex).Cells(2).Value)
                    Call TranEmployeeClass(DataEventType.Delete)
                    Call TranEmployeeClass(DataEventType.SearchNLoad)
                    SelEmpClassId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvEC_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEC.DataBindingComplete
        With dgvEC
            .Columns(2).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            With .Columns(3)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Employee Class"
            End With
        End With
    End Sub

    Private Sub dgvEG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEG.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvEG.Rows(e.RowIndex)
                    SelEmpGroupId = Convert.ToDouble(.Cells(2).Value)
                    Call GetEmployeeGroupInfo(SelEmpGroupId)
                End With
                btnEGSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete employee group " + dgvEG.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelEmpClassId = Convert.ToDouble(dgvEG.Rows(e.RowIndex).Cells(2).Value)
                    Call TranEmployeeGroup(DataEventType.Delete)
                    Call TranEmployeeGroup(DataEventType.SearchNLoad)
                    SelEmpGroupId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvEG_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEG.DataBindingComplete
        With dgvEG
            .Columns(2).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            With .Columns(3)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Employee Group"
            End With
            With .Columns(4)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Employee Class"
            End With
        End With
    End Sub

    Private Sub dgvLC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLC.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvLC.Rows(e.RowIndex)
                    SelCostCenterId = Convert.ToDouble(.Cells(2).Value)
                    cboLCComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    cboLCDept.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    txtLCCode.Text = .Cells(7).Value
                    txtLCDesc.Text = .Cells(8).Value
                End With
                btnLCSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete cost center " + dgvLC.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelCostCenterId = Convert.ToDouble(dgvLC.Rows(e.RowIndex).Cells(2).Value)
                    Call TranCostCenter(DataEventType.Delete)
                    Call TranCostCenter(DataEventType.SearchNLoad)
                    SelCostCenterId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvLC_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLC.DataBindingComplete
        With dgvLC
            .Columns(2).Visible = False
            With .Columns(3)
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Cost Center"
            End With
            With .Columns(4)
                .MinimumWidth = 350
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Department"
            End With
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
    End Sub

    Private Sub dgvCL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCL.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvCL.Rows(e.RowIndex)
                    SelLaborClassId = Convert.ToDouble(.Cells(2).Value)
                    txtCLCode.Text = .Cells(3).Value
                    txtCLDesc.Text = .Cells(4).Value
                    cboCLComp.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    cboCLDept.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                End With
                btnCLSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete labor classification " + dgvCL.Rows(e.RowIndex).Cells(4).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelLaborClassId = Convert.ToDouble(dgvCL.Rows(e.RowIndex).Cells(2).Value)
                    Call TranLaborClassification(DataEventType.Delete)
                    Call TranLaborClassification(DataEventType.SearchNLoad)
                    SelLaborClassId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvCL_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCL.DataBindingComplete
        With dgvCL
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            With .Columns(4)
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Labor Classification"
            End With
            With .Columns(5)
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Department"
            End With
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    Private Sub dgvLL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLL.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvLL.Rows(e.RowIndex)
                    SelLaborLocationId = Convert.ToDouble(.Cells(2).Value)
                    txtLLDesc.Text = .Cells(3).Value
                    txtLLCode.Text = .Cells(5).Value
                    cboLLComp.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    cboLLDept.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                End With
                btnLLSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete labor location " + dgvLL.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelLaborLocationId = Convert.ToDouble(dgvLL.Rows(e.RowIndex).Cells(2).Value)
                    Call TranLaborLocation(DataEventType.Delete)
                    Call TranLaborLocation(DataEventType.SearchNLoad)
                    SelLaborLocationId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvLL_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLL.DataBindingComplete
        With dgvLL
            If .Rows.Count <= 0 Then Exit Sub
            .Columns(2).Visible = False
            With .Columns(3)
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Location"
            End With
            With .Columns(4)
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Department"
            End With
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    Private Sub btnCOCancel_Click(sender As Object, e As EventArgs) Handles btnCOCancel.Click
        For Each Ctrl As Control In tcCompany.TabPages(0).Controls
            If TypeOf Ctrl Is Panel Then
                For Each SCtrl As Control In DirectCast(Ctrl, Panel).Controls
                    If TypeOf SCtrl Is TextBox Then
                        DirectCast(SCtrl, TextBox).Clear()
                    ElseIf TypeOf SCtrl Is ComboBox Then
                        DirectCast(SCtrl, ComboBox).SelectedValue = 0
                    Else
                        'MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
                    End If
                Next
            End If
        Next
        txtCOCode.Focus()
        btnCOSave.Text = "Save"
    End Sub

    Private Sub btnCOSave_Click(sender As Object, e As EventArgs) Handles btnCOSave.Click
        If txtCOCode.TextLength <= 0 Then
            MsgBox("COMPANY Code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOCode.Focus()
            Exit Sub
        End If
        If txtCOName.TextLength <= 0 Then
            MsgBox("COMPANY Name cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOName.Focus()
            Exit Sub
        End If
        If txtCOAddr.TextLength <= 0 Then
            MsgBox("COMPANY ADDRESS cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOAddr.Focus()
            Exit Sub
        End If
        If cboCOCity.SelectedValue <= 0 Then
            MsgBox("Please select a valid CITY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboCOProv.SelectedValue <= 0 Then
            MsgBox("Please select a valid PROVINCE from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboCORegion.SelectedValue <= 0 Then
            MsgBox("Please select a valid REGION from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtCOTIN.TextLength <= 0 Then
            MsgBox("TAX IDENTIFICATION NUMBER (TIN) cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOTIN.Focus()
            Exit Sub
        End If
        If txtCOSSS.TextLength <= 0 Then
            MsgBox("SSS NUMBER cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOSSS.Focus()
            Exit Sub
        End If
        If txtCOPH.TextLength <= 0 Then
            MsgBox("PHILHEALTH NUMBER cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOPH.Focus()
            Exit Sub
        End If
        If txtCOHDMF.TextLength <= 0 Then
            MsgBox("HDMF NUMBER cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtCOHDMF.Focus()
            Exit Sub
        End If

        If btnCOSave.Text = "Save" Then
            If MsgBox("Save new COMPANY Profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranCompany(DataEventType.Insert)
                Call TranCompany(DataEventType.SearchNLoad)
                btnCOCancel.PerformClick()
            End If
        ElseIf btnCOSave.Text = "Update" Then
            If MsgBox("Update COMPANY information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranCompany(DataEventType.Update)
                Call TranCompany(DataEventType.SearchNLoad)
                btnCOCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnDeCancel_Click(sender As Object, e As EventArgs) Handles btnDeCancel.Click
        cboDeComp.SelectedValue = 0
        txtDeCode.Clear()
        txtDeName.Clear()
        txtDeCode.Focus()
        btnDeSave.Text = "Save"
    End Sub

    Private Sub btnDeSave_Click(sender As Object, e As EventArgs) Handles btnDeSave.Click
        If cboDeComp.SelectedValue <= 0 Then
            MsgBox("Please select a valid COMPANY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtDeCode.TextLength <= 0 Then
            MsgBox("DEPARTMENT Code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtDeCode.Focus()
            Exit Sub
        End If
        If txtDeName.TextLength <= 0 Then
            MsgBox("DEPARTMENT Name cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtDeName.Focus()
            Exit Sub
        End If

        If btnDeSave.Text = "Save" Then
            If MsgBox("Save new DEPARTMENT Profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranDepartment(DataEventType.Insert)
                Call TranDepartment(DataEventType.SearchNLoad)
                If MsgBox("Add another entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    txtDeCode.Clear()
                    txtDeName.Clear()
                    cboDeHead.SelectedValue = 0
                    txtDeCode.Focus()
                Else
                    btnDeCancel.PerformClick()
                End If

            End If
        ElseIf btnDeSave.Text = "Update" Then
            If MsgBox("Update DEPARTMENT information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranDepartment(DataEventType.Update)
                Call TranDepartment(DataEventType.SearchNLoad)
                btnDeCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnDiCancel_Click(sender As Object, e As EventArgs) Handles btnDiCancel.Click
        cboDiComp.SelectedValue = 0
        cboDiDept.SelectedValue = 0
        txtDiCode.Clear()
        txtDiName.Clear()
        cboDiHead.SelectedValue = 0
        btnDiSave.Text = "Save"
    End Sub

    Private Sub btnDiSave_Click(sender As Object, e As EventArgs) Handles btnDiSave.Click
        If cboDiComp.SelectedValue <= 0 Then
            MsgBox("Please select a valid COMPANY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboDiDept.SelectedValue <= 0 Then
            MsgBox("Please select a valid DEPARTMENT from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtDiCode.TextLength <= 0 Then
            MsgBox("DIVISION Code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtDiCode.Focus()
            Exit Sub
        End If
        If txtDiName.TextLength <= 0 Then
            MsgBox("DIVISION Name cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtDiName.Focus()
            Exit Sub
        End If

        If btnDiSave.Text = "Save" Then
            If MsgBox("Save new DIVISION Profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranDivision(DataEventType.Insert)
                Call TranDivision(DataEventType.SearchNLoad)
                If MsgBox("Add another entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    txtDiCode.Clear()
                    txtDiName.Clear()
                    cboDiHead.SelectedValue = 0
                    txtDiCode.Focus()
                Else
                    btnDiCancel.PerformClick()
                End If

            End If
        ElseIf btnDiSave.Text = "Update" Then
            If MsgBox("Update DIVISION information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranDivision(DataEventType.Update)
                Call TranDivision(DataEventType.SearchNLoad)
                btnDiCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnSeCancel_Click(sender As Object, e As EventArgs) Handles btnSeCancel.Click
        cboSeComp.SelectedValue = 0
        cboSeDept.SelectedValue = 0
        cboSeDivision.SelectedValue = 0
        txtSeCode.Clear()
        txtSeName.Clear()
        cboSeHead.SelectedValue = 0
        txtSeCode.Focus()
        btnSeSave.Text = "Save"
    End Sub

    Private Sub btnSeSave_Click(sender As Object, e As EventArgs) Handles btnSeSave.Click
        If cboSeComp.SelectedValue <= 0 Then
            MsgBox("Please select a valid COMPANY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboSeDept.SelectedValue <= 0 Then
            MsgBox("Please select a valid DEPARTMENT from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboSeDivision.SelectedValue <= 0 Then
            MsgBox("Please select a valid DIVISION from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtSeCode.TextLength <= 0 Then
            MsgBox("SECTION Code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtSeCode.Focus()
            Exit Sub
        End If
        If txtSeName.TextLength <= 0 Then
            MsgBox("SECTION Name cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtSeCode.Focus()
            Exit Sub
        End If

        If btnSeSave.Text = "Save" Then
            If MsgBox("Save new SECTION Profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSection(DataEventType.Insert)
                Call TranSection(DataEventType.SearchNLoad)
                If MsgBox("Create another entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    txtSeCode.Clear()
                    txtSeName.Clear()
                    cboSeHead.SelectedValue = 0
                    txtSeCode.Focus()
                Else
                    btnSeCancel.PerformClick()
                End If

            End If
        ElseIf btnSeSave.Text = "Update" Then
            If MsgBox("Update SECTION information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSection(DataEventType.Update)
                Call TranSection(DataEventType.SearchNLoad)
                btnSeCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnECCancel_Click(sender As Object, e As EventArgs) Handles btnECCancel.Click
        cboECComp.SelectedValue = 0
        txtECCode.Clear()
        txtECDesc.Clear()
        txtECCode.Focus()
        btnECSave.Text = "Save"
    End Sub

    Private Sub btnECSave_Click(sender As Object, e As EventArgs) Handles btnECSave.Click
        If cboECComp.SelectedValue <= 0 Then
            MsgBox("Please select a valid COMPANY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtECCode.TextLength <= 0 Then
            MsgBox("EMPLOYEE CLASS Code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtECCode.Focus()
            Exit Sub
        End If
        If txtECDesc.TextLength <= 0 Then
            MsgBox("EMPLOYEE CLASS name cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtECDesc.Focus()
            Exit Sub
        End If

        If btnECSave.Text = "Save" Then
            If MsgBox("Save new EMPLOYEE CLASS?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranEmployeeClass(DataEventType.Insert)
                Call TranEmployeeClass(DataEventType.SearchNLoad)
                If MsgBox("Add another entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    txtECCode.Clear()
                    txtECDesc.Clear()
                    txtECCode.Focus()
                Else
                    btnECCancel.PerformClick()
                End If

            End If
        ElseIf btnECSave.Text = "Update" Then
            If MsgBox("Update EMPLOYEE CLASS information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranEmployeeClass(DataEventType.Update)
                Call TranEmployeeClass(DataEventType.SearchNLoad)
                btnECCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnEGSave_Click(sender As Object, e As EventArgs) Handles btnEGSave.Click
        If cboEGComp.SelectedValue = 0 Then
            MsgBox("Please select a valid COMPANY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboEGEC.SelectedValue = 0 Then
            MsgBox("Please select a valid EMPLOYEE CLASS from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtEGCode.Text.Length = 0 Then
            MsgBox("EMPLOYEE GROUP code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtEGCode.Focus()
            Exit Sub
        End If
        If txtEGDesc.Text.Length = 0 Then
            MsgBox("EMPLOYEE GROUP description cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtEGDesc.Focus()
            Exit Sub
        End If

        If btnEGSave.Text = "Save" Then
            If MsgBox("Save new EMPLOYEE GROUP?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranEmployeeGroup(DataEventType.Insert)
                Call TranEmployeeGroup(DataEventType.SearchNLoad)
                If MsgBox("Add another entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    txtEGCode.Clear()
                    txtEGDesc.Clear()
                    txtEGCode.Focus()
                    btnLCSave.Text = "Save"
                Else
                    btnEGCancel.PerformClick()
                End If
            End If
        ElseIf btnEGSave.Text = "Update" Then
            If MsgBox("Update EMPLOYEE GROUP information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranEmployeeGroup(DataEventType.Update)
                Call TranEmployeeGroup(DataEventType.SearchNLoad)
                btnEGCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnEGCancel_Click(sender As Object, e As EventArgs) Handles btnEGCancel.Click
        cboEGComp.SelectedValue = 0
        cboEGEC.SelectedValue = 0
        txtEGCode.Clear()
        txtEGDesc.Clear()
        txtEGCode.Focus()
        btnEGSave.Text = "Save"
    End Sub

    Private Sub btnLCSave_Click(sender As Object, e As EventArgs) Handles btnLCSave.Click
        If cboLCComp.SelectedValue <= 0 Then
            MsgBox("Please select a valid COMPANY from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If cboLCDept.SelectedValue <= 0 Then
            MsgBox("Please select a valid DEPARTMENT from the drop down list.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If txtLCCode.TextLength <= 0 Then
            MsgBox("LABOR CLASSIFICATION Code cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtLCCode.Focus()
            Exit Sub
        End If
        If txtLCDesc.TextLength <= 0 Then
            MsgBox("LABOR CLASSIFICATION DESCRIPTION cannot be NULL. Please supply a value.", MsgBoxStyle.Exclamation, "Error")
            txtLCDesc.Focus()
            Exit Sub
        End If

        If btnLCSave.Text = "Save" Then
            If MsgBox("Save new COST CENTER?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranCostCenter(DataEventType.Insert)
                Call TranCostCenter(DataEventType.SearchNLoad)
                If MsgBox("Add another entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    txtLCCode.Clear()
                    txtLCDesc.Clear()
                    txtLCCode.Focus()
                    btnLCSave.Text = "Save"
                Else
                    btnLCCancel.PerformClick()
                End If
            End If
        ElseIf btnLCSave.Text = "Update" Then
            If MsgBox("Update COST CENTER information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranCostCenter(DataEventType.Update)
                Call TranCostCenter(DataEventType.SearchNLoad)
                btnLCCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnLCCancel_Click(sender As Object, e As EventArgs) Handles btnLCCancel.Click
        cboLCComp.SelectedValue = 0
        cboLCDept.SelectedValue = 0
        txtLCCode.Clear()
        txtLCDesc.Clear()
        txtLCCode.Focus()
        btnLCSave.Text = "Save"
    End Sub

    Private Sub btnCLSave_Click(sender As Object, e As EventArgs) Handles btnCLSave.Click
        If cboCLComp.SelectedValue = 0 Then
            MsgBox("Invalid or no COMPANY has been selected. Please select from the list then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboCLDept.SelectedValue = 0 Then
            MsgBox("Invalid or no DEPARTMENT has been selected. Please select from the list then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtCLCode.TextLength = 0 Then
            MsgBox("Invalid or no CODE has been entered. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtCLCode.Focus()
            Exit Sub
        End If
        If txtCLDesc.TextLength = 0 Then
            MsgBox("Invalid or no DESCRIPTION has been entered. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtCLDesc.Focus()
            Exit Sub
        End If

        Select Case btnCLSave.Text
            Case "Save"
                If MsgBox("Save new LABOR CLASSIFICATION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Call TranLaborClassification(DataEventType.Insert)
                    Call TranLaborClassification(DataEventType.SearchNLoad)
                    If MsgBox("Create another LABOR CLASSIFICATION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Create") = MsgBoxResult.Yes Then
                        txtCLCode.Clear()
                        txtCLDesc.Clear()
                        txtCLCode.Focus()
                    Else
                        btnLCCancel.PerformClick()
                    End If
                End If
            Case "Update"
                If MsgBox("Update LABOR CLASSIFICATION information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Call TranLaborClassification(DataEventType.Update)
                    Call TranLaborClassification(DataEventType.SearchNLoad)
                    btnLCCancel.PerformClick()
                End If
            Case Else
                ' No conditions met.
        End Select
    End Sub

    Private Sub btnCLCancel_Click(sender As Object, e As EventArgs) Handles btnCLCancel.Click
        cboCLComp.SelectedValue = 0
        cboCLDept.SelectedValue = 0
        txtCLCode.Clear()
        txtCLDesc.Clear()
        txtCLCode.Focus()
        btnCLSave.Text = "Save"
        SelLaborClassId = 0
    End Sub

    Private Sub btnLLSave_Click(sender As Object, e As EventArgs) Handles btnLLSave.Click
        Select Case btnLLSave.Text
            Case "Save"
                If MsgBox("Save new LABOR LOCATION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Call TranLaborLocation(DataEventType.Insert)
                    Call TranLaborLocation(DataEventType.SearchNLoad)
                    If MsgBox("Create another LABOR LOCATION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Create") = MsgBoxResult.Yes Then
                        txtLLCode.Clear()
                        txtLLDesc.Clear()
                        txtLLCode.Focus()
                    Else
                        btnLLCancel.PerformClick()
                    End If
                End If
            Case "Update"
                If MsgBox("Update LABOR CLASSIFICATION information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Call TranLaborLocation(DataEventType.Update)
                    Call TranLaborLocation(DataEventType.SearchNLoad)
                    btnLLCancel.PerformClick()
                End If
            Case Else
                ' No conditions met.
        End Select
    End Sub

    Private Sub btnLLCancel_Click(sender As Object, e As EventArgs) Handles btnLLCancel.Click
        cboLLComp.SelectedValue = 0
        cboLLDept.SelectedValue = 0
        txtLLCode.Clear()
        txtLLDesc.Clear()
        txtLLCode.Focus()
        SelLaborLocationId = 0
        btnLLSave.Text = "Save"
    End Sub

    Private Sub cboCOCity_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCOCity.SelectedValueChanged
        Try
            Call GetCityLocation(cboCOCity.SelectedValue)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboDeComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDeComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employees", cboDeComp.SelectedValue, cboDeHead)
            Call TranDepartment(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboDiComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDiComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("department", cboDiComp.SelectedValue, cboDiDept)
            Call LoadDataToComboBox("employees", cboDiComp.SelectedValue, cboDiHead)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboSeComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSeComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("department", cboSeComp.SelectedValue, cboSeDept)
            Call LoadDataToComboBox("employees", cboSeComp.SelectedValue, cboSeHead)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboSeDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSeDept.SelectedValueChanged
        Try
            Call LoadDataToComboBox("division", cboSeDept.SelectedValue, cboSeDivision)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboSeDivision_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSeDivision.SelectedValueChanged
        Try
            Call TranSection(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboECComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboECComp.SelectedValueChanged
        Try
            Call TranEmployeeClass(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboEGComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEGComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employeeclass", cboEGComp.SelectedValue, cboEGEC)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboEGEC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEGEC.SelectedValueChanged
        Try
            Call TranEmployeeGroup(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboLCComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLCComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("department", cboLCComp.SelectedValue, cboLCDept)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboLCDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLCDept.SelectedValueChanged
        Try
            Call TranCostCenter(4)
        Catch ex As Exception
            'Bypass error
        End Try
    End Sub

    Private Sub cboDiDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDiDept.SelectedValueChanged
        Try
            Call TranDivision(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboCLComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCLComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("department", cboCLComp.SelectedValue, cboCLDept)
        Catch ex As Exception
            ' Bypass error.
        End Try
    End Sub

    Private Sub cboCLDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCLDept.SelectedValueChanged
        Try
            Call TranLaborClassification(DataEventType.SearchNLoad)
        Catch ex As Exception
            ' Bypass error.
        End Try
    End Sub

    Private Sub cboLLComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLLComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("department", cboLLComp.SelectedValue, cboLLDept)
        Catch ex As Exception
            ' Bypass error.
        End Try
    End Sub

    Private Sub cboLLDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLLDept.SelectedValueChanged
        Try
            Call TranLaborLocation(DataEventType.SearchNLoad)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

End Class
