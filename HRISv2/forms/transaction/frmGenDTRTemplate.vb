Imports HRISv2.HRISLibrary
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmGenDTRTemplate

    ' Header Information
    Private PayrollYear As Integer = 1900, PayrollMonth As Integer = 1, PayrollDay As Integer = 1, _
            PayrollCS As Integer = 1, PayrollCE As Integer = 1, EmpClassId As Int64 = 0, EmpGroupId As Int64 = 0

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

    Private Sub GenerateEDFEXCELFile()
        'Dim xlsApp As Excel.Application
        'Dim xlsWkb As Excel.Workbook
        'Dim xlsWks As Excel.Worksheet
        'Dim xlsRng As Excel.Range




        'xlsWkb.Close()
        'xlsApp.Quit()

        'ReleaseObject(xlsRng)
        'ReleaseObject(xlsWks)
        'ReleaseObject(xlsWkb)
        'ReleaseObject(xlsApp)
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

    Private Sub frmGenDTRTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class