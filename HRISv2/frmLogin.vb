Imports HRISv2.HRISLibrary
Imports MySql.Data.MySqlClient

Public Class frmLogIn

    Private Dt As New DataTable

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = <Command>
                                    Call sp_validateuser ( @lid, @lip );
                                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@lid", txtLID.Text))
                .Add(New MySqlParameter("@lip", txtLIP.Text))
            End With

            Try
                Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                If Dt.Rows.Count > 0 Then
                    For Each Dr As DataRow In Dt.Rows
                        Declares.UserHandleId = Convert.ToInt64(Dr(0))
                        Declares.UserHandleName = Dr(1)
                        Declares.UserRoleId = Convert.ToInt64(Dr(2))
                        Declares.UserRoleDesc = Dr(3)
                        Declares.UserCompanyId = Convert.ToInt64(Dr(4))
                    Next
                Else
                    MsgBox("Invalid credentials supplied. Either Login Id or Password supplied is invalid.", MsgBoxStyle.Critical, "Error Login")
                    txtLID.Clear()
                    txtLIP.Clear()
                    txtLID.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Unhandled Error")
                txtLID.Clear()
                txtLIP.Clear()
                txtLID.Focus()

            Finally
                If Not Declares.UserHandleId = 0 Then
                    mdiHRIS.Show()
                    Me.Hide()
                End If
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

End Class
