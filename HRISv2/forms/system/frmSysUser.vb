Imports HRISv2.HRISLibrary
Imports MySql.Data.MySqlClient

Public Class frmSysUser

    Private SelSystemUserId As Int64 = 0

    Private AffectedRows As Integer = 0

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

    Private Sub TranSystemUsers(ByVal TranType As Integer)
        Using cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_transysusers ( @ttype, @recid, @compid, @empid, @lid, @lip, @urole, @eml, @userid );
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelSystemUserId))
                .Add(New MySqlParameter("@compid", cboComp.SelectedValue))
                .Add(New MySqlParameter("@empid", cboEmp.SelectedValue))
                .Add(New MySqlParameter("@lid", txtLID.Text))
                .Add(New MySqlParameter("@lip", txtLIP.Text))
                .Add(New MySqlParameter("@urole", cboUR.SelectedIndex))
                .Add(New MySqlParameter("@eml", txtEmail.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3
                    AffectedRows = Database.ExecuteCommand(cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4
                    dgvUser.DataSource = Database.GetResults(cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvUser.Rows.Count <= 0 Then dgvUser.DataSource = Nothing
                Case Else
                    ' Conditions not met.
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create User for employee " + cboEmp.Text + " due to user account already exists.", MsgBoxStyle.Critical, "Creation Error")
                    Else
                        MsgBox("User account for employee " + cboEmp.Text + " has been created successfully.", MsgBoxStyle.Information, "User Created")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to update User for employee " + cboEmp.Text + " due to user account already exists or in conflict with other user account.", MsgBoxStyle.Critical, "Update Error")
                    Else
                        MsgBox("User account for employee " + cboEmp.Text + " has been updated successfully.", MsgBoxStyle.Information, "User Updated")
                    End If
                Case 2 ' Delete
                    If AffectedRows = 0 Then
                        MsgBox("Unable to remove User " + cboEmp.Text + " from users list.", MsgBoxStyle.Critical, "Remove Error")
                    Else
                        MsgBox("User account for employee " + cboEmp.Text + " has been removed successfully.", MsgBoxStyle.Information, "User Rempved")
                    End If
                Case 3 ' Purge
                Case Else
                    ' Conditions not met.
            End Select

        End Using
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvUser.Rows(e.RowIndex)
                    SelSystemUserId = Convert.ToInt64(.Cells(2).Value)
                    cboComp.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    cboEmp.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                    txtLID.Text = .Cells(8).Value
                    cboUR.SelectedIndex = Convert.ToInt64(.Cells(9).Value)
                End With
                btnSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete user " + dgvUser.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelSystemUserId = Convert.ToDouble(dgvUser.Rows(e.RowIndex).Cells(2).Value)
                    Call TranSystemUsers(2)
                    Call TranSystemUsers(4)
                    SelSystemUserId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Exclamation, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvUser_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvUser.DataBindingComplete
        Try
            With dgvUser
                .Columns(2).Visible = False
                With .Columns(3)
                    .HeaderText = "Employee Name"
                    .MinimumWidth = 250
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End With
                With .Columns(4)
                    .HeaderText = "Company"
                    .MinimumWidth = 250
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End With
                With .Columns(5)
                    .HeaderText = "User Role"
                    .MinimumWidth = 250
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End With
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False
            End With
        Catch ex As Exception
            ' Bypass error
        End Try

    End Sub

    Private Sub frmSysUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TranSystemUsers(4)
        Call LoadDataToComboBox("company", 0, cboComp)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLID.Text.Length = 0 Or txtLID.Text.Length < 6 Then
            MsgBox("User/Login Id should be at least six (6) characters in length. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtLID.Focus()
            Exit Sub
        End If

        If btnSave.Text = "Save" Then
            If txtLIP.Text.Length = 0 Or txtLIP.Text.Length < 6 Then
                MsgBox("User/Login Password should be at least six (6) characters in length. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
                txtLIP.Focus()
                Exit Sub
            End If

            If Not txtLIP.Text = txtCLIP.Text Then
                MsgBox("User/Login Password does not match. Please re-enter your chosen password then try again.", MsgBoxStyle.Critical, "Error")
                txtLIP.Focus()
                Exit Sub
            End If

            If cboUR.SelectedIndex < 1 Then
                MsgBox("Invalid ROLE selected. Please select a valid role for the new user then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Else
            If txtLIP.Text.Length > 0 Then
                If txtLIP.Text = 0 Or txtLIP.Text.Length < 6 Then
                    MsgBox("User/Login Password should be at least six (6) characters in length. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtLIP.Focus()
                    Exit Sub
                End If

                If Not txtLIP.Text = txtCLIP.Text Then
                    MsgBox("User/Login Password does not match. Please re-enter your chosen password then try again.", MsgBoxStyle.Critical, "Error")
                    txtLIP.Focus()
                    Exit Sub
                End If

                If cboUR.SelectedText < 1 Then
                    MsgBox("Invalid ROLE selected. Please select a valid role for the new user then try again.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            End If
        End If

        If cboComp.SelectedValue = 0 Then
            MsgBox("Invalid COMPANY selected. Please select a valid value from the list then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If cboEmp.SelectedValue = 0 Then
            MsgBox("Invalid EMPLOYEE selected. Please select a valid value from the list then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If txtEmail.Text.Trim.Length = 0 Then
            MsgBox("Email address cannot be EMPTRY. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtEmail.Focus()
            Exit Sub
        End If

        If btnSave.Text = "Save" Then
            If MsgBox("Create USER ACCOUNT from employee " + cboEmp.Text + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSystemUsers(0)
                Call TranSystemUsers(4)
                btnCancel.PerformClick()
            End If
        Else
            If MsgBox("Update USER ACCOUNT from employee " + cboEmp.Text + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSystemUsers(1)
                Call TranSystemUsers(4)
                btnCancel.PerformClick()
            End If
        End If
    End Sub

    Private Sub cboComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employees", cboComp.SelectedValue, cboEmp)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cboComp.SelectedValue = 0
        cboEmp.SelectedValue = 0
        cboUR.SelectedIndex = 0
        txtLID.Clear()
        txtLIP.Clear()
        txtCLIP.Clear()
        txtEmail.Clear()
        txtLID.Focus()
        btnSave.Text = "Save"
        SelSystemUserId = 0
    End Sub

End Class