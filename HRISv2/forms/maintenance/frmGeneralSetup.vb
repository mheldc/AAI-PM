Imports HRISv2.HRISLibrary
Imports MySql.Data.MySqlClient
Imports System.Management

Public Class frmGeneralSetup

    Private SelRegionId As Double = 0, SelRegionName As String = ""
    Private SelProvinceId As Double = 0, SelProvinceName As String = ""
    Private SelCityId As Double = 0, SelCityName As String = ""
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

    Private Sub TranRegion(ByVal TranType As Integer)
        Try
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Declares.CmdString = _
                    <Command>
                        Call sp_tranRegion (@ttype, @recid, @rcode, @rname, @userid);
                    </Command>.Value
                Declares.CmdParameterList = New ArrayList
                With Declares.CmdParameterList
                    .Add(New MySqlParameter("@ttype", TranType))
                    .Add(New MySqlParameter("@recid", SelRegionId))
                    .Add(New MySqlParameter("@rcode", txtReCode.Text))
                    .Add(New MySqlParameter("@rname", txtReName.Text))
                    .Add(New MySqlParameter("@userid", Declares.UserHandleId))
                End With

                Select Case TranType
                    Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                        AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                    Case 4 ' Get Company List/Information
                        dgvRe.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    Case 5 ' Print
                    Case Else
                        MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
                End Select

                Select Case TranType
                    Case 0 ' Insert
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Region : " + txtReName.Text + " due to REGION CODE and/or REGION NAME already exists." + _
                                   "The system does not allow duplicates. Please key in a unique REGION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Saving of NEW Region information succeeded.", MsgBoxStyle.Information, "SAVED")
                        End If
                    Case 1 ' Update
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Region : " + txtReName.Text + " due to REGION CODE and/or REGION NAME already exists." + _
                                   "The system does not allow duplicates. Please key in a unique REGION information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Updating of Region information succeeded.", MsgBoxStyle.Information, "UPDATED")
                        End If
                    Case 2 ' Delete
                        MsgBox("Region has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                    Case 3 ' Purge
                        MsgBox("All INACTIVE Region has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                    Case Else
                End Select

            End Using
        Catch ex As Exception
            MsgBox("Error in transacting Region data." & vbCrLf & _
                   "Error Details:" + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub TranProvince(ByVal TranType As Integer)
        Try
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Declares.CmdString = _
                    <Command>
                    Call sp_tranProvince (@ttype, @recid, @rid, @pcode, @pname, @userid);
                </Command>.Value
                Declares.CmdParameterList = New ArrayList
                With Declares.CmdParameterList
                    .Add(New MySqlParameter("@ttype", TranType))
                    .Add(New MySqlParameter("@recid", SelProvinceId))
                    .Add(New MySqlParameter("@rid", cboPrRegion.SelectedValue))
                    .Add(New MySqlParameter("@pcode", txtPrCode.Text))
                    .Add(New MySqlParameter("@pname", txtPrName.Text))
                    .Add(New MySqlParameter("@userid", Declares.UserHandleId))
                End With

                Select Case TranType
                    Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                        AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                    Case 4 ' Get Company List/Information
                        dgvPr.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    Case 5 ' Print
                    Case Else
                        MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
                End Select

                Select Case TranType
                    Case 0 ' Insert
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Province : " + txtPrName.Text + " due to PROVINCE CODE and/or PROVINCE NAME already exists." + _
                                   "The system does not allow duplicates. Please key in a unique PROVINCE information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Saving of NEW Province information succeeded.", MsgBoxStyle.Information, "SAVED")
                        End If
                    Case 1 ' Update
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Province : " + txtPrName.Text + " due to PROVINCE CODE and/or PROVINCE NAME already exists." + _
                                   "The system does not allow duplicates. Please key in a unique PROVINCE information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Updating of Province information succeeded.", MsgBoxStyle.Information, "UPDATED")
                        End If
                    Case 2 ' Delete
                        MsgBox("Province has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                    Case 3 ' Purge
                        MsgBox("All INACTIVE Province has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                    Case Else
                End Select
            End Using
        Catch ex As Exception
            MsgBox("Error in transacting Province data." & vbCrLf & _
                   "Error Details:" + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TranCity(ByVal TranType As Integer)
        Try
            Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
                Declares.CmdString = _
                    <Command>
                    Call sp_tranCity (@ttype, @recid, @pid, @ccode, @cname, @userid);
                </Command>.Value
                Declares.CmdParameterList = New ArrayList
                With Declares.CmdParameterList
                    .Add(New MySqlParameter("@ttype", TranType))
                    .Add(New MySqlParameter("@recid", SelProvinceId))
                    .Add(New MySqlParameter("@pid", cboCiProvince.SelectedValue))
                    .Add(New MySqlParameter("@ccode", txtCiCode.Text))
                    .Add(New MySqlParameter("@cname", txtCiName.Text))
                    .Add(New MySqlParameter("@userid", Declares.UserHandleId))
                End With

                Select Case TranType
                    Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                        AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                    Case 4 ' Get Company List/Information
                        dgvCi.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    Case 5 ' Print
                    Case Else
                        MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
                End Select

                Select Case TranType
                    Case 0 ' Insert
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for City : " + txtCiName.Text + " due to CITY CODE and/or CITY NAME already exists." + _
                                   "The system does not allow duplicates. Please key in a unique CITY information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Saving of NEW Province information succeeded.", MsgBoxStyle.Information, "SAVED")
                        End If
                    Case 1 ' Update
                        If AffectedRows = 0 Then
                            MsgBox("Unable to create profile for Province : " + txtCiName.Text + " due to CITY CODE and/or CITY NAME already exists." + _
                                   "The system does not allow duplicates. Please key in a unique CITY information then try again.", MsgBoxStyle.Exclamation, "Error : DUPLICATES")
                        Else
                            MsgBox("Updating of City information succeeded.", MsgBoxStyle.Information, "UPDATED")
                        End If
                    Case 2 ' Delete
                        MsgBox("City has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                    Case 3 ' Purge
                        MsgBox("All INACTIVE City has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                    Case Else
                End Select
            End Using
        Catch ex As Exception
            MsgBox("Error in transacting City data." & vbCrLf & _
                   "Error Details:" + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmGeneralSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Declares.CnString = "Server=localhost;Database=paymodule;uid=root;pwd=;"
        Declares.UserHandleId = 0

        Call LoadDataToComboBox("region", 0, cboPrRegion)
        Call LoadDataToComboBox("region", 0, cboCiRegion)
        Call TranRegion(4)
        Call TranProvince(4)
        Call TranCity(4)
    End Sub

    Private Sub cboPrRegion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPrRegion.SelectedValueChanged
        Try
            Call TranProvince(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboCiProvince_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCiProvince.SelectedValueChanged
        Try
            Call TranCity(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboCiRegion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCiRegion.SelectedValueChanged
        Try
            Call LoadDataToComboBox("province", cboCiRegion.SelectedValue, cboCiProvince)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub dgvRe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRe.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvRe.Rows(e.RowIndex)
                    SelRegionId = Convert.ToDouble(.Cells(2).Value)
                    SelRegionName = .Cells(3).Value.ToString()
                    txtReCode.Text = .Cells(4).Value.ToString()
                    txtReName.Text = .Cells(5).Value.ToString()
                End With
                btnReSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete region " + dgvRe.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelRegionId = Convert.ToDouble(dgvRe.Rows(e.RowIndex).Cells(2).Value)
                    Call TranRegion(2) ' Delete selected item
                    Call TranRegion(4) ' Refresh List
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvRe_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRe.CellFormatting
        With dgvRe
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Region"
                .Width = 500
            End With
            .Columns(4).Visible = False
            .Columns(5).Visible = False
        End With
    End Sub

    Private Sub dgvPr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPr.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPr.Rows(e.RowIndex)
                    SelProvinceId = Convert.ToDouble(.Cells(2).Value)
                    SelProvinceName = .Cells(3).Value.ToString()
                    cboPrRegion.SelectedValue = Convert.ToDouble(.Cells(4).Value)
                    txtPrCode.Text = .Cells(5).Value.ToString()
                    txtPrName.Text = .Cells(6).Value.ToString()
                End With
                btnPrSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete region " + dgvRe.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelRegionId = Convert.ToDouble(dgvRe.Rows(e.RowIndex).Cells(2).Value)
                    Call TranProvince(2) ' Delete selected item
                    Call TranProvince(4) ' Refresh List
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPr_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPr.CellFormatting
        With dgvPr
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Province"
                .Width = 500
            End With
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
        End With
    End Sub

    Private Sub dgvCi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCi.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvCi.Rows(e.RowIndex)
                    SelCityId = Convert.ToDouble(.Cells(2).Value)
                    SelCityName = .Cells(3).Value.ToString()
                    cboCiRegion.SelectedValue = Convert.ToDouble(.Cells(5).Value)
                    cboCiProvince.SelectedValue = Convert.ToDouble(.Cells(6).Value)
                    txtCiCode.Text = .Cells(7).Value.ToString()
                    txtCiName.Text = .Cells(8).Value.ToString()
                End With
                btnCiSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete region " + dgvRe.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelCityId = Convert.ToDouble(dgvCi.Rows(e.RowIndex).Cells(2).Value)
                    Call TranCity(2) ' Delete selected item
                    Call TranCity(4) ' Refresh List
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvCi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCi.CellFormatting
        With dgvCi
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Province"
                .Width = 350
            End With
            With .Columns(4)
                .HeaderText = "City"
                .Width = 350
            End With
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
    End Sub

    Private Sub btnReSave_Click(sender As Object, e As EventArgs) Handles btnReSave.Click
        If Trim(txtReCode.Text).Length = 0 Then
            MsgBox("Unable to process data due to incomplete information supplied.", MsgBoxStyle.Exclamation, "Invalid REGION CODE")
            txtReCode.Focus()
            Exit Sub
        End If

        If Trim(txtReName.Text).Length = 0 Then
            MsgBox("Unable to process data due to incomplete information supplied.", MsgBoxStyle.Exclamation, "Invalid REGION NAME")
            txtReName.Focus()
            Exit Sub
        End If

        If btnReSave.Text = "Save" Then
            If MsgBox("Save new Region?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
                Call TranRegion(0) ' Add Region Information
                Call TranRegion(4) ' Refresh Region Grid
                Call btnReCancel.PerformClick()
            End If
        ElseIf btnReSave.Text = "Update" Then
            If MsgBox("Update region information of " + SelRegionName + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                Call TranRegion(1) ' Update Region Information
                Call TranRegion(4) ' Refresh Region Grid
                Call btnReCancel.PerformClick()
            End If
        Else
            ' Nothing matches the condition
        End If
    End Sub

    Private Sub btnPrSave_Click(sender As Object, e As EventArgs) Handles btnPrSave.Click
        If btnPrSave.Text = "Save" Then
            If MsgBox("Save new Province?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
                Call TranProvince(0) ' Add Region Information
                Call TranProvince(4) ' Refresh Region Grid
                txtPrCode.Clear()
                txtPrName.Clear()
                txtPrCode.Focus()
            End If
        ElseIf btnPrSave.Text = "Update" Then
            If MsgBox("Update information of province " + SelProvinceName + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                Call TranProvince(1) ' Update Region Information
                Call TranProvince(4) ' Refresh Region Grid
                txtPrCode.Clear()
                txtPrName.Clear()
                txtPrCode.Focus()
            End If
        Else
            ' Nothing matches the condition
        End If
    End Sub

    Private Sub btnCiSave_Click(sender As Object, e As EventArgs) Handles btnCiSave.Click
        If btnCiSave.Text = "Save" Then
            If MsgBox("Save new City information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
                Call TranCity(0) ' Add Region Information
                Call TranCity(4) ' Refresh Region Grid
                txtCiCode.Clear()
                txtCiName.Clear()
                txtCiCode.Focus()
            End If
        ElseIf btnCiSave.Text = "Update" Then
            If MsgBox("Update information of city " + SelCityName + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Update") = MsgBoxResult.Yes Then
                Call TranCity(1) ' Update Region Information
                Call TranCity(4) ' Refresh Region Grid
                txtCiCode.Clear()
                txtCiName.Clear()
                txtCiCode.Focus()
            End If
        Else
            ' Nothing matches the condition
        End If
    End Sub

    Private Sub btnReCancel_Click(sender As Object, e As EventArgs) Handles btnReCancel.Click
        txtReCode.Clear()
        txtReName.Clear()
        txtReCode.Focus()
        btnReSave.Text = "Save"
        SelRegionId = 0
        SelRegionName = ""
    End Sub

    Private Sub btnPrCancel_Click(sender As Object, e As EventArgs) Handles btnPrCancel.Click
        cboPrRegion.SelectedValue = 0
        txtPrCode.Clear()
        txtPrName.Clear()
        txtPrCode.Focus()
        btnPrSave.Text = "Save"
        SelProvinceId = 0
        SelProvinceName = ""
    End Sub

    Private Sub btnCiCancel_Click(sender As Object, e As EventArgs) Handles btnCiCancel.Click
        cboCiRegion.SelectedValue = 0
        cboCiProvince.SelectedValue = 0
        txtCiCode.Clear()
        txtCiName.Clear()
        txtCiCode.Focus()
        btnCiSave.Text = "Save"
        SelCityId = 0
        SelCityName = ""
    End Sub

    Private Sub btnLicReg_Click(sender As Object, e As EventArgs)
        'My.Computer.Registry.CurrentUser.CreateSubKey("CSI-PH")
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\CSI-PH", "Hash1", 1)
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\CSI-PH", "Hash2", 2)
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\CSI-PH", "HashLimit", 300)
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\CSI-PH", "HashOwner", txtLicCompany.Text)


        'My.Computer.Registry.GetValue("HKEY_CURRENT_USER\CSI-PH", "Hash1", 0)


        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = _
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers = _
            serial_numbers.Substring(2)


        Dim objMOS As ManagementObjectSearcher
        Dim objMOC As Management.ManagementObjectCollection
        Dim objMO As Management.ManagementObject

        objMOS = New ManagementObjectSearcher("Select * From Win32_OperatingSystem")
        objMOC = objMOS.Get
        Dim OsSerial As String = ""

        For Each objMO In objMOC
            OsSerial = objMO("SerialNumber")
        Next
        Console.WriteLine("Motherboard Serial No : " + serial_numbers)

        Dim x As New Cryptography()
        Declares.HashKeyCode = OsSerial
        Declares.SaltKeyCode = serial_numbers
        Console.WriteLine("Hash Key : " + Declares.HashKeyCode + vbCrLf + "Salt Key : " + Declares.SaltKeyCode)
        Console.WriteLine(x.EncryptData("AAI Business Pro Inc. @ 3000"))

        Licensing.AddUpdateAppSettings("HashKey0", x.EncryptData("Server=localhost;Database=paymodule;uid=root;pwd=;"))
        Licensing.AddUpdateAppSettings("HashKey1", x.EncryptData("localhost"))
        Licensing.AddUpdateAppSettings("HashKey2", x.EncryptData("paymodule"))
        Licensing.AddUpdateAppSettings("HashKey3", x.EncryptData("root"))
        Licensing.AddUpdateAppSettings("HashKey4", x.EncryptData(""))
        Licensing.AddUpdateAppSettings("HashKey5", x.EncryptData("3306"))
        Licensing.AddUpdateAppSettings("HashKey6", x.EncryptData("30-Day Demo"))
        Licensing.AddUpdateAppSettings("HashKey7", x.EncryptData("AAI Business Pro Inc."))
        Licensing.AddUpdateAppSettings("HashKey8", x.EncryptData("5000"))

    End Sub

End Class