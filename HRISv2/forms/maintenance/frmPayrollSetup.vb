Imports MySql.Data.MySqlClient
Imports HRISv2.HRISLibrary

Public Class frmPayrollSetup

    Private SelExemptTypeId As Int64 = 0, SelExemptBracketId As Int64 = 0, SelAnnualTaxBracketId As Int64 = 0
    Private SelSSSSettingId As Int64 = 0, SelSSSTableRefId As Int64 = 0
    Private SelPHSettingId As Int64 = 0, SelPHTableRefId As Int64 = 0
    Private SelHDMFSettingId As Int64 = 0, SelHDMFTableRefId As Int64 = 0
    Private SelPayReferenceId As Int64 = 0, SelPayBasisId As Int64 = 0, SelPayAdjustmentId As Int64 = 0, _
            SelPayScheduleId As Int64 = 0, SelPayRateSettingId As Int64 = 0, SelPayRegRateId As Int64 = 0, _
            SelPaySpcRateId As Int64 = 0
    Private SelPayChannelId As Int64 = 0, SelPayBanksId As Int64 = 0
    Private SelPayrollProcessorId As Int64 = 0
    Private SelECOLAId As Int64 = 0

    Private AffectedRows As Int64 = 0
    Private Dt As DataTable

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

    Private Sub TranTaxExemptionTypes(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranexemptypes ( @ttype, @recid, @tecode, @tedesc, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelExemptTypeId))
                .Add(New MySqlParameter("@tecode", txtETCode.Text))
                .Add(New MySqlParameter("@tedesc", txtETDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvET.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvET.Rows.Count <= 0 Then dgvET.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for TAX EXEMPTION TYPE : " + txtETDesc.Text + " due to TAX EXEMPTION TYPE CODE and/or TAX EXEMPTION TYPE NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique TAX EXEMPTION TYPE information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW TAX EXEMPTION TYPE information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for TAX EXEMPTION TYPE : " + txtETDesc.Text + " due to TAX EXEMPTION TYPE CODE and/or TAX EXEMPTION TYPE NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique TAX EXEMPTION TYPE information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of TAX EXEMPTION TYPE information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("TAX EXEMPTION TYPE has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE TAX EXEMPTION TYPE has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranTaxExemptBracket(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranexemptbracket ( @ttype, @recid, @pfid, @extid, @pex, @examt, @pover, @pamt, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelExemptBracketId))
                .Add(New MySqlParameter("@pfid", cboTEBPayBasis.SelectedValue))
                .Add(New MySqlParameter("@extid", cboTEBET.SelectedValue))
                .Add(New MySqlParameter("@pex", txtTEBPE.Text))
                .Add(New MySqlParameter("@examt", txtTEBAT.Text))
                .Add(New MySqlParameter("@pover", txtTEBPlusPCT.Text))
                .Add(New MySqlParameter("@pamt", txtTEBPlusEx.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvTEB.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvTEB.Rows.Count <= 0 Then dgvTEB.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for TAX EXEMPTION BRACKET : " + cboTEBET.Text + " " + cboTEBPayBasis.Text + " due to TAX EXEMPTION BRACKET CODE and/or TAX EXEMPTION BRACKET NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique TAX EXEMPTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW TAX EXEMPTION BRACKET information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for TAX EXEMPTION BRACKET : " + cboTEBET.Text + " " + cboTEBPayBasis.Text + " due to TAX EXEMPTION BRACKET CODE and/or TAX EXEMPTION BRACKET NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique TAX EXEMPTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of TAX EXEMPTION BRACKET information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("TAX EXEMPTION BRACKET has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE TAX EXEMPTION BRACKET has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranAnnualizedTaxBracket(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranannualizetaxtable ( @ttype, @recid, @bstart, @bend, @plustx, @pluspct, @baseamt, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelAnnualTaxBracketId))
                .Add(New MySqlParameter("@bstart", txtATBBStart.Text))
                .Add(New MySqlParameter("@bend", txtATBBEnd.Text))
                .Add(New MySqlParameter("@plustx", txtATBAT.Text))
                .Add(New MySqlParameter("@pluspct", txtATBPlusPct.Text))
                .Add(New MySqlParameter("@baseamt", txtATBPlusEx.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvATB.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvATB.Rows.Count <= 0 Then dgvATB.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("ANNUALIZED TAX BRACKET cannot be saved due to range conflicts in other range.", MsgBoxStyle.Critical, "Error : RANGE ERROR")
                    Else
                        MsgBox("Saving of NEW ANNUALIZED TAX BRACKET information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("ANNUALIZED TAX BRACKET cannot be saved due to range conflicts in other range.", MsgBoxStyle.Critical, "Error : RANGE ERROR")
                    Else
                        MsgBox("Updating of ANNUALIZED TAX BRACKET information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("ANNUALIZED TAX BRACKET has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE ANNUALIZED TAX BRACKET has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranSSSSettings(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_transsssettings ( @ttype, @recid, @compid, @usetbl, @usecus, @ees, @eepct, 
                                              @ers, @erpct, @dbaseid, @sbaseid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelSSSSettingId))
                .Add(New MySqlParameter("@compid", cboSSetComp.SelectedValue))
                .Add(New MySqlParameter("@usetbl", Convert.ToBoolean(rdbSSRef0.Checked)))
                .Add(New MySqlParameter("@usecus", Convert.ToBoolean(rdbSSRef1.Checked)))
                .Add(New MySqlParameter("@ees", txtSSRef1EE.Text))
                .Add(New MySqlParameter("@eepct", Convert.ToBoolean(chkSSRef1EE.Checked)))
                .Add(New MySqlParameter("@ers", txtSSRef1ER.Text))
                .Add(New MySqlParameter("@erpct", Convert.ToBoolean(chkSSRef1ER.Checked)))
                .Add(New MySqlParameter("@dbaseid", cboSSetCB.SelectedIndex))
                .Add(New MySqlParameter("@sbaseid", cboSSetSched.SelectedIndex))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvSSet.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvSSet.Rows.Count <= 0 Then dgvSSet.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION SETTINGS for SSS due to SETTING already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION SETTING for SSS succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION SETTINGS for SSS due to SETTING already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION SETTING for SSS succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 2 ' Delete
                    MsgBox("SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE SETTING has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranSSSContributionTable(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_transsstable ( @ttype, @recid, @bstart, @bend, @cbase, @ers, @ees, @era, @userid );
                    
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelSSSTableRefId))
                .Add(New MySqlParameter("@bstart", txtSSBStart.Text))
                .Add(New MySqlParameter("@bend", txtSSBEnd.Text))
                .Add(New MySqlParameter("@cbase", txtSSC.Text))
                .Add(New MySqlParameter("@ers", txtSERShare.Text))
                .Add(New MySqlParameter("@ees", txtSEEShare.Text))
                .Add(New MySqlParameter("@era", txtERSPlusAdj.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvSSS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvSSS.Rows.Count <= 0 Then dgvSSS.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION TABLE for SSS due to SETTING or BRACKET already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION BRACKET for SSS succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION TABLE for SSS due to SETTING or BRACKET  already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION BRACKET for SSS succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 2 ' Delete
                    MsgBox("SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE BRACKET has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPhilhealthSettings(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranphilhealthsettings ( @ttype, @recid, @compid, @usetbl, @usecus, @ees, @eepct, 
                                                     @ers, @erpct, @dbaseid, @sbaseid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPHSettingId))
                .Add(New MySqlParameter("@compid", cboPSComp.SelectedValue))
                .Add(New MySqlParameter("@usetbl", Convert.ToBoolean(rdbPSRef0.Checked)))
                .Add(New MySqlParameter("@usecus", Convert.ToBoolean(rdbPSRef1.Checked)))
                .Add(New MySqlParameter("@ees", txtPSRef1EE.Text))
                .Add(New MySqlParameter("@eepct", Convert.ToBoolean(chkPSRef1EE.Checked)))
                .Add(New MySqlParameter("@ers", txtPSRef1ER.Text))
                .Add(New MySqlParameter("@erpct", Convert.ToBoolean(chkPSRef1ER.Checked)))
                .Add(New MySqlParameter("@dbaseid", cboPSCB.SelectedIndex))
                .Add(New MySqlParameter("@sbaseid", cboPSSched.SelectedIndex))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPS.Rows.Count <= 0 Then dgvPS.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION SETTINGS for PHILHEALTH due to SETTING already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION SETTING for PHILHEALTH succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION SETTINGS for PHILHEALTH due to SETTING already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION SETTING for PHILHEALTH succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 2 ' Delete
                    MsgBox("SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE SETTING has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPhilhealthContributionTable(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranphilhealthtable ( @ttype, @recid, @bstart, @bend, @cbase, @ers, @ees, @era, @userid );
                    
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelSSSTableRefId))
                .Add(New MySqlParameter("@bstart", txtSSBStart.Text))
                .Add(New MySqlParameter("@bend", txtSSBEnd.Text))
                .Add(New MySqlParameter("@cbase", txtSSC.Text))
                .Add(New MySqlParameter("@ers", txtSERShare.Text))
                .Add(New MySqlParameter("@ees", txtSEEShare.Text))
                .Add(New MySqlParameter("@era", txtERSPlusAdj.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPH.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPH.Rows.Count <= 0 Then dgvPH.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION TABLE for PHILHEALTH due to SETTING or BRACKET already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION BRACKET for PHILHEALTH succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION TABLE for PHILHEALTH due to SETTING or BRACKET  already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION BRACKET for PHILHEALTH succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 2 ' Delete
                    MsgBox("SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE BRACKET has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranHDMFSettings(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranhdmfsettings ( @ttype, @recid, @compid, @usetbl, @usecus, @ees, @eepct, 
                                              @ers, @erpct, @dbaseid, @sbaseid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelHDMFSettingId))
                .Add(New MySqlParameter("@compid", cboHSComp.SelectedValue))
                .Add(New MySqlParameter("@usetbl", Convert.ToBoolean(rdbHSRef0.Checked)))
                .Add(New MySqlParameter("@usecus", Convert.ToBoolean(rdbHSRef1.Checked)))
                .Add(New MySqlParameter("@ees", txtHSRef1EE.Text))
                .Add(New MySqlParameter("@eepct", Convert.ToBoolean(chkHSRef1EE.Checked)))
                .Add(New MySqlParameter("@ers", txtHSRef1ER.Text))
                .Add(New MySqlParameter("@erpct", Convert.ToBoolean(chkHSRef1ER.Checked)))
                .Add(New MySqlParameter("@dbaseid", cboHSCB.SelectedIndex))
                .Add(New MySqlParameter("@sbaseid", cboHSSched.SelectedIndex))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvHS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvHS.Rows.Count <= 0 Then dgvHS.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION SETTINGS for HDMF due to SETTING already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION SETTING for HDMF succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION SETTINGS for HDMF due to SETTING already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION SETTING for HDMF succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 2 ' Delete
                    MsgBox("SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE SETTING has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranHDMFContributionTable(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranhdmftable ( @ttype, @recid, @bstart, @bend, @cbase, @ers, @erpct, @ees, @eepct, @userid );
                    
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelHDMFTableRefId))
                .Add(New MySqlParameter("@bstart", txtHDSBStart.Text))
                .Add(New MySqlParameter("@bend", txtHDSBEnd.Text))
                .Add(New MySqlParameter("@cbase", txtHDSC.Text))
                .Add(New MySqlParameter("@ers", txtHDCER.Text))
                .Add(New MySqlParameter("@erpct", Convert.ToBoolean(chkHDER.Checked)))
                .Add(New MySqlParameter("@ees", txtHDCEE.Text))
                .Add(New MySqlParameter("@eepct", Convert.ToBoolean(chkHDEE.Checked)))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvHDMF.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvHDMF.Rows.Count <= 0 Then dgvHDMF.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION TABLE for HDMF due to SETTING or BRACKET already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION BRACKET for HDMF succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to save CONTRIBUTION TABLE for HDMF due to SETTING or BRACKET  already exists." + _
                               "The system does not allow duplicates. Please key in a unique CONTRIBUTION BRACKET information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW CONTRIBUTION BRACKET for HDMF succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 2 ' Delete
                    MsgBox("SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE BRACKET has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranECOLASetting(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranecola ( @ttype, @recid, @cid, @ecode, @edesc, @erate, @epr, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelECOLAId))
                .Add(New MySqlParameter("@cid", cboECComp.SelectedValue))
                .Add(New MySqlParameter("@ecode", txtECCode.Text))
                .Add(New MySqlParameter("@edesc", txtECDesc.Text))
                .Add(New MySqlParameter("@erate", txtECAR.Text))
                .Add(New MySqlParameter("@epr", Convert.ToBoolean(chkECProRate.Checked)))
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
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for ECOLA : " + txtECDesc.Text + " due to ECOLA CODE and/or ECOLA NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique ECOLA information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW ECOLA information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for ECOLA : " + txtECDesc.Text + " due to ECOLA CODE and/or ECOLA NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique ECOLA information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of ECOLA information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("ECOLA has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE ECOLA has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayReference(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpayreference ( @ttype, @recid, @pcode, @pdesc, @dpy, @rbase, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayReferenceId))
                .Add(New MySqlParameter("@pcode", txtPRCode.Text))
                .Add(New MySqlParameter("@pdesc", txtPRDesc.Text))
                .Add(New MySqlParameter("@dpy", txtPRDPY.Text))
                .Add(New MySqlParameter("@rbase", cboPRB.SelectedIndex))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPRef.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPRef.Rows.Count <= 0 Then dgvPRef.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL REFERENCE : " + txtPRDesc.Text + " due to PAYROLL REFERENCE CODE and/or PAYROLL REFERENCE NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique PAYROLL REFERENCE information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW PAYROLL REFERENCE information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL REFERENCE : " + txtPRDesc.Text + " due to PAYROLL REFERENCE CODE and/or PAYROLL REFERENCE NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique PAYROLL REFERENCE information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of PAYROLL REFERENCE information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("PAYROLL REFERENCE has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE PAYROLL REFERENCE has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayBasis(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpaybasis ( @ttype, @recid, @bcode, @bdesc, @cycleno, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayReferenceId))
                .Add(New MySqlParameter("@bcode", txtPBCode.Text))
                .Add(New MySqlParameter("@bdesc", txtPBDesc.Text))
                .Add(New MySqlParameter("@cycleno", cboPBCycle.SelectedIndex))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPB.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPB.Rows.Count <= 0 Then dgvPB.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAY BASIS : " + txtPRDesc.Text + " due to PAY BASIS CODE and/or PAY BASIS NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique PAY BASIS information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW PAY BASIS information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAY BASIS : " + txtPRDesc.Text + " due to PAY BASIS CODE and/or PAY BASIS NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique PAY BASIS information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of PAY BASIS information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("PAY BASIS has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE PAY BASIS has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranAdjustmentTypes(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranadjustments ( @ttype, @recid, @cid, @acode, @adesc, @istaxed, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayAdjustmentId))
                .Add(New MySqlParameter("@cid", cboPAComp.SelectedValue))
                .Add(New MySqlParameter("@acode", txtPACode.Text))
                .Add(New MySqlParameter("@adesc", txtPADesc.Text))
                .Add(New MySqlParameter("@istaxed", chkPATaxable.Checked))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPA.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPA.Rows.Count <= 0 Then dgvPA.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for ADJUSTMENT TYPE : " + txtPADesc.Text + " due to ADJUSTMENT TYPE CODE and/or  ADJUSTMENT TYPE NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique  ADJUSTMENT TYPE information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW  ADJUSTMENT TYPE information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for ADJUSTMENT TYPE : " + txtPADesc.Text + " due to ADJUSTMENT TYPE CODE and/or  ADJUSTMENT TYPE NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique  ADJUSTMENT TYPE information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of ADJUSTMENT TYPE information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("ADJUSTMENT TYPE has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE ADJUSTMENT TYPE has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayrollSchedule(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpayperiod ( @ttype, @recid, @cid, @ecid, @egid, @pcode, @pdesc, @isnextmon, @cstart, @cend, @pday, @pseqno,	@userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayScheduleId))
                .Add(New MySqlParameter("@cid", cboPPComp.SelectedValue))
                .Add(New MySqlParameter("@ecid", cboPPEC.SelectedValue))
                .Add(New MySqlParameter("@egid", cboPPEG.SelectedValue))
                .Add(New MySqlParameter("@pcode", txtPPCode.Text))
                .Add(New MySqlParameter("@pdesc", txtPPDesc.Text))
                .Add(New MySqlParameter("@isnextmon", chkPPNM.Checked))
                .Add(New MySqlParameter("@cstart", txtPPCovFrom.Text))
                .Add(New MySqlParameter("@cend", txtPPCovTo.Text))
                .Add(New MySqlParameter("@pday", txtPPPayDate.Text))
                .Add(New MySqlParameter("@pseqno", cboPPSequence.SelectedIndex))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPPS.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPPS.Rows.Count <= 0 Then dgvPPS.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL PERIOD : " + txtPPDesc.Text + " due to PAYROLL PERIOD CODE and/or  PAYROLL PERIOD NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique  PAYROLL PERIOD information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW  PAYROLL PERIOD information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL PERIOD : " + txtPPDesc.Text + " due to PAYROLL PERIOD CODE and/or  PAYROLL PERIOD NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique  PAYROLL PERIOD information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of PAYROLL PERIOD information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("PAYROLL PERIOD has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE PAYROLL PERIOD has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayrollRateSetting(TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpayratesetting ( @ttype, @recid, @rcode, @rdesc, @cid, @did, @pid, @usecr, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayRateSettingId))
                .Add(New MySqlParameter("@rcode", txtRSCode.Text))
                .Add(New MySqlParameter("@rdesc", txtRSDesc.Text))
                .Add(New MySqlParameter("@cid", cboRSComp.SelectedValue))
                .Add(New MySqlParameter("@did", cboRSDept.SelectedValue))
                .Add(New MySqlParameter("@pid", cboRSPB.SelectedValue))
                .Add(New MySqlParameter("@usecr", chkRSSC.Checked))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPR.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPR.Rows.Count <= 0 Then dgvPR.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL RATE SETTING : " + txtPPDesc.Text + " due to PAYROLL RATE SETTING CODE and/or  PAYROLL RATE SETTING NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique  PAYROLL RATE SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW  PAYROLL RATE SETTING information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL RATE SETTING : " + txtPPDesc.Text + " due to PAYROLL RATE SETTING CODE and/or  PAYROLL RATE SETTING NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique  PAYROLL RATE SETTING information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of PAYROLL RATE SETTING information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("PAYROLL RATE SETTING has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE PAYROLL RATE SETTING has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayrollRatesStandard(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpayratesregular ( @ttype, @recid, @setid,
                                                  @reg0, @reg1, @reg2, @reg3, @rdr0, @rdr1, @rdr2, @rdr3,
                                                  @rds0, @rds1, @rds2, @rds3, @rdh0, @rdh1, @rdh2, @rdh3,
                                                  @rdd0, @rdd1, @rdd2, @rdd3, @spc0, @spc1, @spc2, @spc3,
                                                  @hol0, @hol1, @hol2, @hol3, @dbl0, @dbl1, @dbl2, @dbl3,		
                                                  @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayRegRateId))
                .Add(New MySqlParameter("@setid", cboPRStandard.SelectedValue))
                .Add(New MySqlParameter("@reg0", txtPRReg.Text))
                .Add(New MySqlParameter("@reg1", txtPRRegOT.Text))
                .Add(New MySqlParameter("@reg2", txtPRRegND.Text))
                .Add(New MySqlParameter("@reg3", txtPRRegOTND.Text))
                .Add(New MySqlParameter("@rdr0", txtPRRD.Text))
                .Add(New MySqlParameter("@rdr1", txtPRRDOT.Text))
                .Add(New MySqlParameter("@rdr2", txtPRRDND.Text))
                .Add(New MySqlParameter("@rdr3", txtPRRDOTND.Text))
                .Add(New MySqlParameter("@rds0", txtPRRDSH.Text))
                .Add(New MySqlParameter("@rds1", txtPRRDSHOT.Text))
                .Add(New MySqlParameter("@rds2", txtPRRDSHND.Text))
                .Add(New MySqlParameter("@rds3", txtPRRDSHOTND.Text))
                .Add(New MySqlParameter("@rdh0", txtPRRDRH.Text))
                .Add(New MySqlParameter("@rdh1", txtPRRDRHOT.Text))
                .Add(New MySqlParameter("@rdh2", txtPRRDRHND.Text))
                .Add(New MySqlParameter("@rdh3", txtPRRDRHOTND.Text))
                .Add(New MySqlParameter("@rdd0", txtPRRDDH.Text))
                .Add(New MySqlParameter("@rdd1", txtPRRDDHOT.Text))
                .Add(New MySqlParameter("@rdd2", txtPRRDDHND.Text))
                .Add(New MySqlParameter("@rdd3", txtPRRDDHOTND.Text))
                .Add(New MySqlParameter("@spc0", txtPRSH.Text))
                .Add(New MySqlParameter("@spc1", txtPRSHOT.Text))
                .Add(New MySqlParameter("@spc2", txtPRSHND.Text))
                .Add(New MySqlParameter("@spc3", txtPRSHOTND.Text))
                .Add(New MySqlParameter("@hol0", txtPRRH.Text))
                .Add(New MySqlParameter("@hol1", txtPRRHOT.Text))
                .Add(New MySqlParameter("@hol2", txtPRRHND.Text))
                .Add(New MySqlParameter("@hol3", txtPRRHOTND.Text))
                .Add(New MySqlParameter("@dbl0", txtPRDH.Text))
                .Add(New MySqlParameter("@dbl1", txtPRDHOT.Text))
                .Add(New MySqlParameter("@dbl2", txtPRDHND.Text))
                .Add(New MySqlParameter("@dbl3", txtPRDHOTND.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    If cboPRCompStd.SelectedValue = 0 And cboPRStandard.SelectedValue = 0 Then Exit Select
                    Dt = New DataTable
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            SelPayRateSettingId = Convert.ToInt64(Dr(0))
                            SelPayRegRateId = Convert.ToInt64(Dr(1))
                            txtPRReg.Text = FormatNumber(Dr(2), 2)
                            txtPRRegOT.Text = FormatNumber(Dr(3), 2)
                            txtPRRegND.Text = FormatNumber(Dr(4), 2)
                            txtPRRegOTND.Text = FormatNumber(Dr(5), 2)

                            txtPRRD.Text = FormatNumber(Dr(6), 2)
                            txtPRRDOT.Text = FormatNumber(Dr(7), 2)
                            txtPRRDND.Text = FormatNumber(Dr(8), 2)
                            txtPRRDOTND.Text = FormatNumber(Dr(9), 2)

                            txtPRRDSH.Text = FormatNumber(Dr(10), 2)
                            txtPRRDSHOT.Text = FormatNumber(Dr(11), 2)
                            txtPRRDSHND.Text = FormatNumber(Dr(12), 2)
                            txtPRRDSHOTND.Text = FormatNumber(Dr(13), 2)

                            txtPRRDRH.Text = FormatNumber(Dr(14), 2)
                            txtPRRDRHOT.Text = FormatNumber(Dr(15), 2)
                            txtPRRDRHND.Text = FormatNumber(Dr(16), 2)
                            txtPRRDRHOTND.Text = FormatNumber(Dr(17), 2)

                            txtPRRDDH.Text = FormatNumber(Dr(18), 2)
                            txtPRRDDHOT.Text = FormatNumber(Dr(19), 2)
                            txtPRRDDHND.Text = FormatNumber(Dr(20), 2)
                            txtPRRDDHOTND.Text = FormatNumber(Dr(21), 2)

                            txtPRSH.Text = FormatNumber(Dr(22), 2)
                            txtPRSHOT.Text = FormatNumber(Dr(23), 2)
                            txtPRSHND.Text = FormatNumber(Dr(24), 2)
                            txtPRSHOTND.Text = FormatNumber(Dr(25), 2)

                            txtPRRH.Text = FormatNumber(Dr(26), 2)
                            txtPRRHOT.Text = FormatNumber(Dr(27), 2)
                            txtPRRHND.Text = FormatNumber(Dr(28), 2)
                            txtPRRHOTND.Text = FormatNumber(Dr(29), 2)

                            txtPRDH.Text = FormatNumber(Dr(30), 2)
                            txtPRDHOT.Text = FormatNumber(Dr(31), 2)
                            txtPRDHND.Text = FormatNumber(Dr(32), 2)
                            txtPRDHOTND.Text = FormatNumber(Dr(33), 2)
                        Next
                        btnPRStdSave.Text = "Update"
                    Else
                        btnPRStdSave.Text = "Save"
                    End If
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to process information, RATE MATRIX (Standard) already exists.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW RATE MATRIX (Standard) information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to process information, RATE MATRIX (Standard) already exists.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of RATE MATRIX (Standard) information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("RATE MATRIX (Standard) has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE RATE MATRIX (Standard) has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayrollRatesCustom(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpayratescustom ( @ttype, @recid, @setid,
                                                 @reg0c, @reg1c, @reg2c, @reg3c, @reg0d, @reg1d, @reg2d, @reg3d,	
                                                 @rdr0c, @rdr1c, @rdr2c, @rdr3c, @rdr0d, @rdr1d, @rdr2d, @rdr3d,	
                                                 @rds0c, @rds1c, @rds2c, @rds3c, @rds0d, @rds1d, @rds2d, @rds3d,	
                                                 @rdh0c, @rdh1c, @rdh2c, @rdh3c, @rdh0d, @rdh1d, @rdh2d, @rdh3d,	
                                                 @rdd0c, @rdd1c, @rdd2c, @rdd3c, @rdd0d, @rdd1d, @rdd2d, @rdd3d,
                                                 @spc0c, @spc1c, @spc2c, @spc3c, @spc0d, @spc1d, @spc2d, @spc3d,
                                                 @hol0c, @hol1c, @hol2c, @hol3c, @hol0d, @hol1d, @hol2d, @hol3d,
                                                 @dbl0c, @dbl1c, @dbl2c, @dbl3c, @dbl0d, @dbl1d, @dbl2d, @dbl3d,			
                                                 @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPaySpcRateId))
                .Add(New MySqlParameter("@setid", cboPRCustom.SelectedValue))

                .Add(New MySqlParameter("@reg0c", txtPRReg0.Text))
                .Add(New MySqlParameter("@reg1c", txtPRRegOT0.Text))
                .Add(New MySqlParameter("@reg2c", txtPRRegNS0.Text))
                .Add(New MySqlParameter("@reg3c", txtPRRegOTNS0.Text))
                .Add(New MySqlParameter("@reg0d", txtPRReg1.Text))
                .Add(New MySqlParameter("@reg1d", txtPRRegOT1.Text))
                .Add(New MySqlParameter("@reg2d", txtPRRegNS1.Text))
                .Add(New MySqlParameter("@reg3d", txtPRRegOTNS1.Text))

                .Add(New MySqlParameter("@rdr0c", txtPRRD0.Text))
                .Add(New MySqlParameter("@rdr1c", txtPRRDOT0.Text))
                .Add(New MySqlParameter("@rdr2c", txtPRRDNS0.Text))
                .Add(New MySqlParameter("@rdr3c", txtPRRDOTNS0.Text))
                .Add(New MySqlParameter("@rdr0d", txtPRRD1.Text))
                .Add(New MySqlParameter("@rdr1d", txtPRRDOT1.Text))
                .Add(New MySqlParameter("@rdr2d", txtPRRDNS1.Text))
                .Add(New MySqlParameter("@rdr3d", txtPRRDOTNS1.Text))

                .Add(New MySqlParameter("@rds0c", txtPRRDSH0.Text))
                .Add(New MySqlParameter("@rds1c", txtPRRDSHOT0.Text))
                .Add(New MySqlParameter("@rds2c", txtPRRDSHNS0.Text))
                .Add(New MySqlParameter("@rds3c", txtPRRDSHOTNS0.Text))
                .Add(New MySqlParameter("@rds0d", txtPRRDSH1.Text))
                .Add(New MySqlParameter("@rds1d", txtPRRDSHOT1.Text))
                .Add(New MySqlParameter("@rds2d", txtPRRDSHNS1.Text))
                .Add(New MySqlParameter("@rds3d", txtPRRDSHOTNS1.Text))

                .Add(New MySqlParameter("@rdh0c", txtPRRDRH0.Text))
                .Add(New MySqlParameter("@rdh1c", txtPRRDRHOT0.Text))
                .Add(New MySqlParameter("@rdh2c", txtPRRDRHNS0.Text))
                .Add(New MySqlParameter("@rdh3c", txtPRRDRHOTNS0.Text))
                .Add(New MySqlParameter("@rdh0d", txtPRRDRH1.Text))
                .Add(New MySqlParameter("@rdh1d", txtPRRDRHOT1.Text))
                .Add(New MySqlParameter("@rdh2d", txtPRRDRHNS1.Text))
                .Add(New MySqlParameter("@rdh3d", txtPRRDRHOTNS1.Text))

                .Add(New MySqlParameter("@rdd0c", txtPRRDDH0.Text))
                .Add(New MySqlParameter("@rdd1c", txtPRRDDHOT0.Text))
                .Add(New MySqlParameter("@rdd2c", txtPRRDDHNS0.Text))
                .Add(New MySqlParameter("@rdd3c", txtPRRDDHOTNS0.Text))
                .Add(New MySqlParameter("@rdd0d", txtPRRDDH1.Text))
                .Add(New MySqlParameter("@rdd1d", txtPRRDDHOT1.Text))
                .Add(New MySqlParameter("@rdd2d", txtPRRDDHNS1.Text))
                .Add(New MySqlParameter("@rdd3d", txtPRRDDHOTNS1.Text))

                .Add(New MySqlParameter("@spc0c", txtPRSH0.Text))
                .Add(New MySqlParameter("@spc1c", txtPRSHOT0.Text))
                .Add(New MySqlParameter("@spc2c", txtPRSHNS0.Text))
                .Add(New MySqlParameter("@spc3c", txtPRSHOTNS0.Text))
                .Add(New MySqlParameter("@spc0d", txtPRSH1.Text))
                .Add(New MySqlParameter("@spc1d", txtPRSHOT1.Text))
                .Add(New MySqlParameter("@spc2d", txtPRSHNS1.Text))
                .Add(New MySqlParameter("@spc3d", txtPRSHOTNS1.Text))

                .Add(New MySqlParameter("@hol0c", txtPRRH0.Text))
                .Add(New MySqlParameter("@hol1c", txtPRRHOT0.Text))
                .Add(New MySqlParameter("@hol2c", txtPRRHNS0.Text))
                .Add(New MySqlParameter("@hol3c", txtPRRHOTNS0.Text))
                .Add(New MySqlParameter("@hol0d", txtPRRH1.Text))
                .Add(New MySqlParameter("@hol1d", txtPRRHOT1.Text))
                .Add(New MySqlParameter("@hol2d", txtPRRHOTNS1.Text))
                .Add(New MySqlParameter("@hol3d", txtPRRHOTNS1.Text))

                .Add(New MySqlParameter("@dbl0c", txtPRDH0.Text))
                .Add(New MySqlParameter("@dbl1c", txtPRDHOT0.Text))
                .Add(New MySqlParameter("@dbl2c", txtPRDHNS0.Text))
                .Add(New MySqlParameter("@dbl3c", txtPRDHOTNS0.Text))
                .Add(New MySqlParameter("@dbl0d", txtPRDH1.Text))
                .Add(New MySqlParameter("@dbl1d", txtPRDHOT1.Text))
                .Add(New MySqlParameter("@dbl2d", txtPRDHNS1.Text))
                .Add(New MySqlParameter("@dbl3d", txtPRDHOTNS1.Text))

                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    If cboPRCompCus.SelectedValue = 0 And cboPRCustom.SelectedValue = 0 Then Exit Select
                    Dt = New DataTable
                    Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If Dt.Rows.Count > 0 Then
                        For Each Dr As DataRow In Dt.Rows
                            SelPaySpcRateId = Convert.ToInt64(Dr(0))
                            SelPayRateSettingId = Convert.ToInt64(Dr(1))

                            txtPRReg0.Text = FormatNumber(Dr(2), 2)
                            txtPRReg1.Text = FormatNumber(Dr(3), 2)
                            txtPRRegOT0.Text = FormatNumber(Dr(4), 2)
                            txtPRRegOT1.Text = FormatNumber(Dr(5), 2)
                            txtPRRegNS0.Text = FormatNumber(Dr(6), 2)
                            txtPRRegNS1.Text = FormatNumber(Dr(7), 2)
                            txtPRRegOTNS0.Text = FormatNumber(Dr(8), 2)
                            txtPRRegOTNS1.Text = FormatNumber(Dr(9), 2)

                            txtPRRD0.Text = FormatNumber(Dr(10), 2)
                            txtPRRD1.Text = FormatNumber(Dr(11), 2)
                            txtPRRDOT0.Text = FormatNumber(Dr(12), 2)
                            txtPRRDOT1.Text = FormatNumber(Dr(13), 2)
                            txtPRRDNS0.Text = FormatNumber(Dr(14), 2)
                            txtPRRDNS1.Text = FormatNumber(Dr(15), 2)
                            txtPRRDOTNS0.Text = FormatNumber(Dr(16), 2)
                            txtPRRDOTNS1.Text = FormatNumber(Dr(17), 2)

                            txtPRRDSH0.Text = FormatNumber(Dr(18), 2)
                            txtPRRDSH1.Text = FormatNumber(Dr(19), 2)
                            txtPRRDSHOT0.Text = FormatNumber(Dr(20), 2)
                            txtPRRDSHOT1.Text = FormatNumber(Dr(21), 2)
                            txtPRRDSHNS0.Text = FormatNumber(Dr(22), 2)
                            txtPRRDSHNS1.Text = FormatNumber(Dr(23), 2)
                            txtPRRDSHOTNS0.Text = FormatNumber(Dr(24), 2)
                            txtPRRDSHOTNS1.Text = FormatNumber(Dr(25), 2)

                            txtPRRDRH0.Text = FormatNumber(Dr(26), 2)
                            txtPRRDRH1.Text = FormatNumber(Dr(27), 2)
                            txtPRRDRHOT0.Text = FormatNumber(Dr(28), 2)
                            txtPRRDRHOT1.Text = FormatNumber(Dr(29), 2)
                            txtPRRDRHNS0.Text = FormatNumber(Dr(30), 2)
                            txtPRRDRHNS1.Text = FormatNumber(Dr(31), 2)
                            txtPRRDRHOTNS0.Text = FormatNumber(Dr(32), 2)
                            txtPRRDRHOTNS1.Text = FormatNumber(Dr(33), 2)

                            txtPRRDDH0.Text = FormatNumber(Dr(34), 2)
                            txtPRRDDH1.Text = FormatNumber(Dr(35), 2)
                            txtPRRDDHOT0.Text = FormatNumber(Dr(36), 2)
                            txtPRRDDHOT1.Text = FormatNumber(Dr(37), 2)
                            txtPRRDDHNS0.Text = FormatNumber(Dr(38), 2)
                            txtPRRDDHNS1.Text = FormatNumber(Dr(39), 2)
                            txtPRRDDHOTNS0.Text = FormatNumber(Dr(40), 2)
                            txtPRRDDHOTNS1.Text = FormatNumber(Dr(41), 2)

                            txtPRSH0.Text = FormatNumber(Dr(41), 2)
                            txtPRSH1.Text = FormatNumber(Dr(42), 2)
                            txtPRSHOT0.Text = FormatNumber(Dr(43), 2)
                            txtPRSHOT1.Text = FormatNumber(Dr(44), 2)
                            txtPRSHNS0.Text = FormatNumber(Dr(45), 2)
                            txtPRSHNS1.Text = FormatNumber(Dr(46), 2)
                            txtPRSHOTNS0.Text = FormatNumber(Dr(47), 2)
                            txtPRSHOTNS1.Text = FormatNumber(Dr(48), 2)

                            txtPRRH0.Text = FormatNumber(Dr(49), 2)
                            txtPRRH1.Text = FormatNumber(Dr(50), 2)
                            txtPRRHOT0.Text = FormatNumber(Dr(51), 2)
                            txtPRRHOT1.Text = FormatNumber(Dr(52), 2)
                            txtPRRHNS0.Text = FormatNumber(Dr(53), 2)
                            txtPRRHOTNS1.Text = FormatNumber(Dr(54), 2)
                            txtPRRHOTNS0.Text = FormatNumber(Dr(55), 2)
                            txtPRRHOTNS1.Text = FormatNumber(Dr(56), 2)

                            txtPRDH0.Text = FormatNumber(Dr(57), 2)
                            txtPRDH1.Text = FormatNumber(Dr(58), 2)
                            txtPRDHOT0.Text = FormatNumber(Dr(59), 2)
                            txtPRDHOT1.Text = FormatNumber(Dr(60), 2)
                            txtPRDHNS0.Text = FormatNumber(Dr(61), 2)
                            txtPRDHNS1.Text = FormatNumber(Dr(62), 2)
                            txtPRDHOTNS0.Text = FormatNumber(Dr(63), 2)
                            txtPRDHOTNS1.Text = FormatNumber(Dr(64), 2)
                        Next
                        btnPRCusSave.Text = "Update"
                    Else
                        btnPRCusSave.Text = "Save"
                    End If
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to process information, RATE MATRIX (Custom) already exists.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW RATE MATRIX (Custom) information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to process information, RATE MATRIX (Custom) already exists.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of RATE MATRIX (Custom) information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("RATE MATRIX (Custom) has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE RATE MATRIX (Custom) has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub GetStandardRates(ByVal SettingId As Int64)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_getstandardrates ( @setid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@setid", SettingId))
            End With

            If SettingId = 0 Then Exit Sub
            Dt = New DataTable
            Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            If Dt.Rows.Count > 0 Then
                For Each Dr As DataRow In Dt.Rows
                    SelPayRateSettingId = Convert.ToInt64(Dr(0))
                    SelPayRegRateId = Convert.ToInt64(Dr(1))

                    txtPRReg.Text = FormatNumber(Dr(2), 4)
                    txtPRRegOT.Text = FormatNumber(Dr(3), 4)
                    txtPRRegND.Text = FormatNumber(Dr(4), 4)
                    txtPRRegOTND.Text = FormatNumber(Dr(5), 4)

                    txtPRRD.Text = FormatNumber(Dr(6), 4)
                    txtPRRDOT.Text = FormatNumber(Dr(7), 4)
                    txtPRRDND.Text = FormatNumber(Dr(8), 4)
                    txtPRRDOTND.Text = FormatNumber(Dr(9), 4)

                    txtPRRDSH.Text = FormatNumber(Dr(10), 4)
                    txtPRRDSHOT.Text = FormatNumber(Dr(11), 4)
                    txtPRRDSHND.Text = FormatNumber(Dr(12), 4)
                    txtPRRDSHOTND.Text = FormatNumber(Dr(13), 4)

                    txtPRRDRH.Text = FormatNumber(Dr(14), 4)
                    txtPRRDRHOT.Text = FormatNumber(Dr(15), 4)
                    txtPRRDRHND.Text = FormatNumber(Dr(16), 4)
                    txtPRRDRHOTND.Text = FormatNumber(Dr(17), 4)

                    txtPRRDDH.Text = FormatNumber(Dr(18), 4)
                    txtPRRDDHOT.Text = FormatNumber(Dr(19), 4)
                    txtPRRDDHND.Text = FormatNumber(Dr(20), 4)
                    txtPRRDDHOTND.Text = FormatNumber(Dr(21), 4)

                    txtPRSH.Text = FormatNumber(Dr(22), 4)
                    txtPRSHOT.Text = FormatNumber(Dr(23), 4)
                    txtPRSHND.Text = FormatNumber(Dr(24), 4)
                    txtPRSHOTND.Text = FormatNumber(Dr(25), 4)

                    txtPRRH.Text = FormatNumber(Dr(26), 4)
                    txtPRRHOT.Text = FormatNumber(Dr(27), 4)
                    txtPRRHND.Text = FormatNumber(Dr(28), 4)
                    txtPRRHOTND.Text = FormatNumber(Dr(29), 4)

                    txtPRDH.Text = FormatNumber(Dr(30), 4)
                    txtPRDHOT.Text = FormatNumber(Dr(31), 4)
                    txtPRDHND.Text = FormatNumber(Dr(32), 4)
                    txtPRDHOTND.Text = FormatNumber(Dr(33), 4)
                Next
                btnPRStdSave.Text = "Update"
            Else
                btnPRStdSave.Text = "Save"
            End If
        End Using
    End Sub

    Private Sub GetCustomRates(ByVal SettingId As Int64)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_getcustomrates ( @setid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@setid", SettingId))
            End With

            If SettingId = 0 Then Exit Sub
            Dt = New DataTable
            Dt = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
            If Dt.Rows.Count > 0 Then
                For Each Dr As DataRow In Dt.Rows
                    SelPaySpcRateId = Convert.ToInt64(Dr(0))
                    SelPayRateSettingId = Convert.ToInt64(Dr(1))

                    txtPRReg0.Text = FormatNumber(Dr(2), 4)
                    txtPRReg1.Text = FormatNumber(Dr(3), 4)
                    txtPRRegOT0.Text = FormatNumber(Dr(4), 4)
                    txtPRRegOT1.Text = FormatNumber(Dr(5), 4)
                    txtPRRegNS0.Text = FormatNumber(Dr(6), 4)
                    txtPRRegNS1.Text = FormatNumber(Dr(7), 4)
                    txtPRRegOTNS0.Text = FormatNumber(Dr(8), 4)
                    txtPRRegOTNS1.Text = FormatNumber(Dr(9), 4)

                    txtPRRD0.Text = FormatNumber(Dr(10), 4)
                    txtPRRD1.Text = FormatNumber(Dr(11), 4)
                    txtPRRDOT0.Text = FormatNumber(Dr(12), 4)
                    txtPRRDOT1.Text = FormatNumber(Dr(13), 4)
                    txtPRRDNS0.Text = FormatNumber(Dr(14), 4)
                    txtPRRDNS1.Text = FormatNumber(Dr(15), 4)
                    txtPRRDOTNS0.Text = FormatNumber(Dr(16), 4)
                    txtPRRDOTNS1.Text = FormatNumber(Dr(17), 4)

                    txtPRRDSH0.Text = FormatNumber(Dr(18), 4)
                    txtPRRDSH1.Text = FormatNumber(Dr(19), 4)
                    txtPRRDSHOT0.Text = FormatNumber(Dr(20), 4)
                    txtPRRDSHOT1.Text = FormatNumber(Dr(21), 4)
                    txtPRRDSHNS0.Text = FormatNumber(Dr(22), 4)
                    txtPRRDSHNS1.Text = FormatNumber(Dr(23), 4)
                    txtPRRDSHOTNS0.Text = FormatNumber(Dr(24), 4)
                    txtPRRDSHOTNS1.Text = FormatNumber(Dr(25), 4)

                    txtPRRDRH0.Text = FormatNumber(Dr(26), 4)
                    txtPRRDRH1.Text = FormatNumber(Dr(27), 4)
                    txtPRRDRHOT0.Text = FormatNumber(Dr(28), 4)
                    txtPRRDRHOT1.Text = FormatNumber(Dr(29), 4)
                    txtPRRDRHNS0.Text = FormatNumber(Dr(30), 4)
                    txtPRRDRHNS1.Text = FormatNumber(Dr(31), 4)
                    txtPRRDRHOTNS0.Text = FormatNumber(Dr(32), 4)
                    txtPRRDRHOTNS1.Text = FormatNumber(Dr(33), 4)

                    txtPRRDDH0.Text = FormatNumber(Dr(34), 4)
                    txtPRRDDH1.Text = FormatNumber(Dr(35), 4)
                    txtPRRDDHOT0.Text = FormatNumber(Dr(36), 4)
                    txtPRRDDHOT1.Text = FormatNumber(Dr(37), 4)
                    txtPRRDDHNS0.Text = FormatNumber(Dr(38), 4)
                    txtPRRDDHNS1.Text = FormatNumber(Dr(39), 4)
                    txtPRRDDHOTNS0.Text = FormatNumber(Dr(40), 4)
                    txtPRRDDHOTNS1.Text = FormatNumber(Dr(41), 4)

                    txtPRSH0.Text = FormatNumber(Dr(41), 4)
                    txtPRSH1.Text = FormatNumber(Dr(42), 4)
                    txtPRSHOT0.Text = FormatNumber(Dr(43), 4)
                    txtPRSHOT1.Text = FormatNumber(Dr(44), 4)
                    txtPRSHNS0.Text = FormatNumber(Dr(45), 4)
                    txtPRSHNS1.Text = FormatNumber(Dr(46), 4)
                    txtPRSHOTNS0.Text = FormatNumber(Dr(47), 4)
                    txtPRSHOTNS1.Text = FormatNumber(Dr(48), 4)

                    txtPRRH0.Text = FormatNumber(Dr(49), 4)
                    txtPRRH1.Text = FormatNumber(Dr(50), 4)
                    txtPRRHOT0.Text = FormatNumber(Dr(51), 4)
                    txtPRRHOT1.Text = FormatNumber(Dr(52), 4)
                    txtPRRHNS0.Text = FormatNumber(Dr(53), 4)
                    txtPRRHOTNS1.Text = FormatNumber(Dr(54), 4)
                    txtPRRHOTNS0.Text = FormatNumber(Dr(55), 4)
                    txtPRRHOTNS1.Text = FormatNumber(Dr(56), 4)

                    txtPRDH0.Text = FormatNumber(Dr(57), 4)
                    txtPRDH1.Text = FormatNumber(Dr(58), 4)
                    txtPRDHOT0.Text = FormatNumber(Dr(59), 4)
                    txtPRDHOT1.Text = FormatNumber(Dr(60), 4)
                    txtPRDHNS0.Text = FormatNumber(Dr(61), 4)
                    txtPRDHNS1.Text = FormatNumber(Dr(62), 4)
                    txtPRDHOTNS0.Text = FormatNumber(Dr(63), 4)
                    txtPRDHOTNS1.Text = FormatNumber(Dr(64), 4)
                Next
                btnPRCusSave.Text = "Update"
            Else
                btnPRCusSave.Text = "Save"
            End If
        End Using
    End Sub

    Private Sub TranPayChannels(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpaychannels ( @ttype, @recid, @compid, @ccode, @cdesc, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayChannelId))
                .Add(New MySqlParameter("@compid", cboPCComp.SelectedValue))
                .Add(New MySqlParameter("@ccode", txtPCCode.Text))
                .Add(New MySqlParameter("@cdesc", txtPCDesc.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPC.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPC.Rows.Count <= 0 Then dgvPC.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAY CHANNEL : " + txtPCDesc.Text + " due to PAY CHANNEL CODE and/or PAY CHANNEL NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique PAY CHANNEL information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW PAY CHANNEL information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAY CHANNEL : " + txtPCDesc.Text + " due to PAY CHANNEL CODE and/or PAY CHANNEL NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique PAY CHANNEL information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of PAY CHANNEL information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("PAY CHANNEL has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE PAY CHANNEL has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranBanks(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranbanks ( @ttype, @recid, @compid, @chnlid, @bcode, @bname, @userid );
                </Command>.Value

            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayBanksId))
                .Add(New MySqlParameter("@compid", cboBComp.SelectedValue))
                .Add(New MySqlParameter("@chnlid", cboBChannel.SelectedValue))
                .Add(New MySqlParameter("@bcode", txtBCode.Text))
                .Add(New MySqlParameter("@bname", txtBName.Text))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvBanks.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvBanks.Rows.Count <= 0 Then dgvBanks.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for BANK : " + txtBName.Text + " due to BANK CODE and/or BANK NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique BANK information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW BANK information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for BANK : " + txtBName.Text + " due to BANK CODE and/or BANK NAME already exists." + _
                               "The system does not allow duplicates. Please key in a unique BANK information then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of BANK information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("BANK has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE BANK has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub TranPayrollProcessor(ByVal TranType As Integer)
        Using Cn As MySqlConnection = Database.Open(Declares.CnString, PreferedDbType.DB_MYSQL)
            Declares.CmdString = _
                <Command>
                    Call sp_tranpayprocessors ( @ttype, @recid, @cid, @clsid, @grpid, @empid, @userid );
                </Command>.Value
            Declares.CmdParameterList = New ArrayList
            With Declares.CmdParameterList
                .Add(New MySqlParameter("@ttype", TranType))
                .Add(New MySqlParameter("@recid", SelPayrollProcessorId))
                .Add(New MySqlParameter("@cid", cboPPRComp.SelectedValue))
                .Add(New MySqlParameter("@clsid", cboPPREC.SelectedValue))
                .Add(New MySqlParameter("@grpid", cboPPREG.SelectedValue))
                .Add(New MySqlParameter("@empid", cboPPProc.SelectedValue))
                .Add(New MySqlParameter("@userid", Declares.UserHandleId))
            End With

            Select Case TranType
                Case 0, 1, 2, 3 ' 0-Insert : 1-Update : 2-Delete : 3-Purge
                    AffectedRows = Database.ExecuteCommand(Cn, PreferedDbType.DB_MYSQL, Declares.CmdString, Declares.CmdParameterList)
                Case 4 ' Get Company List/Information
                    dgvPPR.DataSource = Database.GetResults(Cn, Declares.CmdString, PreferedDbType.DB_MYSQL, Declares.CmdParameterList)
                    If dgvPPR.Rows.Count <= 0 Then dgvPPR.DataSource = Nothing
                Case 5 ' Print
                Case Else
                    MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End Select

            Select Case TranType
                Case 0 ' Insert
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL PROCESSOR : " + cboPPProc.Text + " due to PAYROLL PROCESSOR already exists or already assigned. Please select a different processor then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Saving of NEW PAYROLL PROCESSOR information succeeded.", MsgBoxStyle.Information, "SAVED")
                    End If
                Case 1 ' Update
                    If AffectedRows = 0 Then
                        MsgBox("Unable to create profile for PAYROLL PROCESSOR : " + cboPPProc.Text + " due to PAYROLL PROCESSOR already exists or already assigned. Please select a different processor then try again.", MsgBoxStyle.Critical, "Error : DUPLICATES")
                    Else
                        MsgBox("Updating of PAYROLL PROCESSOR information succeeded.", MsgBoxStyle.Information, "UPDATED")
                    End If
                Case 2 ' Delete
                    MsgBox("PAYROLL PROCESSOR has been removed successfully.", MsgBoxStyle.Information, "REMOVED")
                Case 3 ' Purge
                    MsgBox("All INACTIVE PAYROLL PROCESSOR has been removed successfully.", MsgBoxStyle.Information, "PURGED")
                Case Else
            End Select
        End Using
    End Sub

    Private Sub btnETSave_Click(sender As Object, e As EventArgs) Handles btnETSave.Click
        If txtETCode.TextLength = 0 Then
            MsgBox("Unable to process information, EXEMPTION TYPE Code cannot be NULL. Please supply a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If txtETDesc.TextLength = 0 Then
            MsgBox("Unable to process information, EXEMPTION TYPE Description cannot be NULL. Please supply a value then try again", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If btnETSave.Text = "Save" Then
            If MsgBox("Save new TAX EXEMPTION TYPE?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranTaxExemptionTypes(0)
                Call TranTaxExemptionTypes(4)
                btnETCancel.PerformClick()
            End If
        ElseIf btnETSave.Text = "Update" Then
            If MsgBox("Update TAX EXEMPTION TYPE information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranTaxExemptionTypes(1)
                Call TranTaxExemptionTypes(4)
                btnETCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnETCancel_Click(sender As Object, e As EventArgs) Handles btnETCancel.Click
        SelExemptTypeId = 0
        txtETCode.Clear()
        txtETDesc.Clear()
        btnETSave.Text = "Save"
        txtETCode.Focus()
    End Sub

    Private Sub btnTEBSave_Click(sender As Object, e As EventArgs) Handles btnTEBSave.Click
        If cboTEBPayBasis.SelectedValue = 0 Then
            MsgBox("Unable to process information, no PAYROLL BASIS has been selected from the list.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboTEBET.SelectedValue = 0 Then
            MsgBox("Unable to process information, no EXEMPTION TYPE has been selected from the list.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Try
            Convert.ToDouble(txtTEBPE.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value entered in PERSONAL EXEMPTION field.", MsgBoxStyle.Critical, "Error")
            txtTEBPE.Text = "0.00"
            txtTEBPE.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtTEBAT.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value entered in APPLIED TAX field.", MsgBoxStyle.Critical, "Error")
            txtTEBAT.Text = "0.00"
            txtTEBAT.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtTEBPlusPCT.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value entered in APPLIED TAX PERCENTAGE field.", MsgBoxStyle.Critical, "Error")
            txtTEBPlusPCT.Text = "0.00"
            txtTEBPlusPCT.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtTEBPlusEx.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value entered in APPLIED TAX IN EXCESS field.", MsgBoxStyle.Critical, "Error")
            txtTEBPlusEx.Text = "0.00"
            txtTEBPlusEx.Focus()
            Exit Sub
        End Try

        If btnTEBSave.Text = "Save" Then
            If MsgBox("Save new TAX EXEMPTION BRACKET?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranTaxExemptBracket(0)
                Call TranTaxExemptBracket(4)
                btnTEBCancel.PerformClick()
            End If
        ElseIf btnTEBSave.Text = "Update" Then
            If MsgBox("Update TAX EXEMPTION BRACKET information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranTaxExemptBracket(1)
                Call TranTaxExemptBracket(4)
                btnTEBCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnTEBCancel_Click(sender As Object, e As EventArgs) Handles btnTEBCancel.Click
        SelExemptBracketId = 0
        cboTEBET.SelectedValue = 0
        cboTEBPayBasis.SelectedValue = 0
        txtTEBPE.Text = "0.00"
        txtTEBAT.Text = "0.00"
        txtTEBPlusPCT.Text = "0.00"
        txtTEBPlusEx.Text = "0.00"
        btnTEBSave.Text = "Save"
    End Sub

    Private Sub btnATBSave_Click(sender As Object, e As EventArgs) Handles btnATBSave.Click
        Try
            Convert.ToDouble(txtATBBStart.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value supplied in TAX BRACKET RANGE (Initial). Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtATBBStart.Text = "0.00"
            txtATBBStart.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtATBBEnd.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value supplied in TAX BRACKET RANGE (Ending). Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtATBBEnd.Text = "0.00"
            txtATBBEnd.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtATBAT.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value supplied in APPLIED TAX field. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtATBAT.Text = "0.00"
            txtATBAT.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtATBPlusPct.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value supplied in APPLIED TAX field. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtATBPlusPct.Text = "0.00"
            txtATBPlusPct.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtATBPlusEx.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value supplied in APPLIED TAX field. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtATBPlusEx.Text = "0.00"
            txtATBPlusEx.Focus()
            Exit Sub
        End Try

        If btnATBSave.Text = "Save" Then
            If MsgBox("Save new ANNUALIZED TAX BRACKET?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranAnnualizedTaxBracket(0)
                Call TranAnnualizedTaxBracket(4)
                btnATBCancel.PerformClick()
            End If
        ElseIf btnATBSave.Text = "Update" Then
            If MsgBox("Update ANNUALIZED TAX BRACKET information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranAnnualizedTaxBracket(1)
                Call TranAnnualizedTaxBracket(4)
                btnATBCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnATBCancel_Click(sender As Object, e As EventArgs) Handles btnATBCancel.Click
        SelAnnualTaxBracketId = 0
        txtATBBStart.Text = "0.00"
        txtATBBEnd.Text = "0.00"
        txtATBAT.Text = "0.00"
        txtATBPlusPct.Text = "0.00"
        txtATBPlusEx.Text = "0.00"
        btnATBSave.Text = "Save"
        txtATBBStart.Focus()
    End Sub

    Private Sub btnECSave_Click(sender As Object, e As EventArgs) Handles btnECSave.Click
        If cboECComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtECCode.TextLength = 0 Then
            MsgBox("Unable to process information, ECOLA SETTING Code cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtECCode.Focus()
            Exit Sub
        End If
        If txtECDesc.TextLength = 0 Then
            MsgBox("Unable to process information, ECOLA SETTING Description cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtECDesc.Focus()
            Exit Sub
        End If
        Try
            Convert.ToDouble(txtECAR.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, ECOLA rate entered is invalid. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtECAR.Text = "0.00"
            txtECAR.Focus()
            Exit Sub
        End Try

        If btnECSave.Text = "Save" Then
            If MsgBox("Save new ECOLA SETTING?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranECOLASetting(0)
                Call TranECOLASetting(4)
                btnECCancel.PerformClick()
            End If
        ElseIf btnECSave.Text = "Update" Then
            If MsgBox("Update ECOLA SETTING information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranECOLASetting(1)
                Call TranECOLASetting(4)
                btnECCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnECCancel_Click(sender As Object, e As EventArgs) Handles btnECCancel.Click
        cboECComp.SelectedValue = 0
        txtECCode.Clear()
        txtECDesc.Clear()
        txtECAR.Text = "0.00"
        chkECProRate.CheckState = CheckState.Unchecked
        SelECOLAId = 0
        btnECSave.Text = "Save"
    End Sub

    Private Sub btnSSetSave_Click(sender As Object, e As EventArgs) Handles btnSSetSave.Click
        If cboSSetComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboSSetCB.SelectedIndex <= 0 Then
            MsgBox("Unable to process information, no CONTRIBUTION BASIS has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboSSetSched.SelectedIndex <= 0 Then
            MsgBox("Unable to process information, no CONTRIBUTION SCHEDULE has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If rdbSSRef1.Checked = True Then
            If txtSSRef1EE.Text = "0.00" Then
                MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Try
                    Convert.ToDouble(txtSSRef1EE.Text)
                Catch ex As Exception
                    MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtSSRef1EE.Text = "0.00"
                    txtSSRef1EE.Focus()
                    Exit Sub
                End Try
            End If
            If txtSSRef1ER.Text = "0.00" Then
                MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Try
                    Convert.ToDouble(txtSSRef1ER.Text)
                Catch ex As Exception
                    MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtSSRef1ER.Text = "0.00"
                    txtSSRef1ER.Focus()
                    Exit Sub
                End Try
            End If
        End If

        If btnSSetSave.Text = "Save" Then
            If MsgBox("Save new CONTRIBUTION SETTING for SSS?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSSSSettings(0)
                Call TranSSSSettings(4)
                btnSSetCancel.PerformClick()
            End If
        ElseIf btnSSetSave.Text = "Update" Then
            If MsgBox("Update CONTRIBUTION SETTING for SSS?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSSSSettings(1)
                Call TranSSSSettings(4)
                btnSSetCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnSSetCancel_Click(sender As Object, e As EventArgs) Handles btnSSetCancel.Click
        cboSSetComp.SelectedValue = 0
        rdbSSRef0.Checked = True
        rdbSSRef1.Checked = False
        cboSSetCB.SelectedIndex = 0
        cboSSetSched.SelectedIndex = 0
        btnSSetSave.Text = "Save"
    End Sub

    Private Sub btnSSave_Click(sender As Object, e As EventArgs) Handles btnSSave.Click
        Try
            Convert.ToDouble(txtSSBStart.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid CONTRIBUTION BRACKET (Initial) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtSSBStart.Text = "0.00"
            txtSSBStart.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtSSBEnd.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid CONTRIBUTION BRACKET (Ending) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtSSBEnd.Text = "0.00"
            txtSSBEnd.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtSSRef1EE.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION VALUE supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtSSRef1EE.Text = "0.00"
            txtSSRef1EE.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtSSRef1ER.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION VALUE supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtSSRef1ER.Text = "0.00"
            txtSSRef1ER.Focus()
            Exit Sub
        End Try

        If (Convert.ToDouble(txtSSBEnd.Text) < Convert.ToDouble(txtSSBStart.Text)) Or _
           (Convert.ToDouble(txtSSBEnd.Text) = Convert.ToDouble(txtSSBStart.Text)) Then
            MsgBox("Unable to process information, CONTRIBUTION ENDING RANGE is less than or equal to CONTRIBUTION STARTING RANGE. Please enter a valid range then try again.", MsgBoxStyle.Critical, "Error")
            txtSSBStart.Focus()
            Exit Sub
        End If

        If btnSSave.Text = "Save" Then
            If MsgBox("Save new CONTRIBUTION BRACKET for SSS?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSSSContributionTable(0)
                Call TranSSSContributionTable(4)
                btnSCancel.PerformClick()
            End If
        ElseIf btnSSave.Text = "Update" Then
            If MsgBox("Update CONTRIBUTION BRACKET for SSS?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranSSSContributionTable(1)
                Call TranSSSContributionTable(4)
                btnSCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnSCancel_Click(sender As Object, e As EventArgs) Handles btnSCancel.Click
        txtSSBStart.Text = "0.00"
        txtSSBEnd.Text = "0.00"
        txtSSC.Text = "0.00"
        txtSEEShare.Text = "0.00"
        txtSERShare.Text = "0.00"
        txtERSPlusAdj.Text = "0.00"
        txtSSBStart.Focus()
        SelSSSSettingId = 0
        btnSSave.Text = "Save"
    End Sub

    Private Sub btnPSSave_Click(sender As Object, e As EventArgs) Handles btnPSSave.Click
        If cboPSComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPSCB.SelectedIndex <= 0 Then
            MsgBox("Unable to process information, no CONTRIBUTION BASIS has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPSSched.SelectedIndex <= 0 Then
            MsgBox("Unable to process information, no CONTRIBUTION SCHEDULE has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If rdbPSRef1.Checked = True Then
            If txtPSRef1EE.Text = "0.00" Then
                MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Try
                    Convert.ToDouble(txtPSRef1EE.Text)
                Catch ex As Exception
                    MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtPSRef1EE.Text = "0.00"
                    txtPSRef1EE.Focus()
                    Exit Sub
                End Try
            End If
            If txtPSRef1ER.Text = "0.00" Then
                MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Try
                    Convert.ToDouble(txtPSRef1ER.Text)
                Catch ex As Exception
                    MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtPSRef1ER.Text = "0.00"
                    txtPSRef1ER.Focus()
                    Exit Sub
                End Try
            End If
        End If

        If btnPSSave.Text = "Save" Then
            If MsgBox("Save new CONTRIBUTION SETTING for PHILHEALTH?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPhilhealthSettings(0)
                Call TranPhilhealthSettings(4)
                btnPSCancel.PerformClick()
            End If
        ElseIf btnPSSave.Text = "Update" Then
            If MsgBox("Update CONTRIBUTION SETTING for PHILHEALTH?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPhilhealthSettings(1)
                Call TranPhilhealthSettings(4)
                btnPSCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPSCancel_Click(sender As Object, e As EventArgs) Handles btnPSCancel.Click
        cboPSComp.SelectedValue = 0
        rdbPSRef0.Checked = True
        rdbPSRef1.Checked = False
        cboPSCB.SelectedIndex = 0
        cboPSSched.SelectedIndex = 0
        btnSSetSave.Text = "Save"
    End Sub

    Private Sub btnPHSave_Click(sender As Object, e As EventArgs) Handles btnPHSave.Click
        Try
            Convert.ToDouble(txtPHSBStart.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid CONTRIBUTION BRACKET (Initial) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPHSBStart.Text = "0.00"
            txtPHSBStart.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtPHSBEnd.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid CONTRIBUTION BRACKET (Ending) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPHSBEnd.Text = "0.00"
            txtPHSBEnd.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtPHEEShare.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION VALUE supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPHEEShare.Text = "0.00"
            txtPHEEShare.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtPHERShare.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION VALUE supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPHERShare.Text = "0.00"
            txtPHERShare.Focus()
            Exit Sub
        End Try

        If (Convert.ToDouble(txtPHSBEnd.Text) < Convert.ToDouble(txtPHSBStart.Text)) Or _
           (Convert.ToDouble(txtPHSBEnd.Text) = Convert.ToDouble(txtPHSBStart.Text)) Then
            MsgBox("Unable to process information, CONTRIBUTION ENDING RANGE is less than or equal to CONTRIBUTION STARTING RANGE. Please enter a valid range then try again.", MsgBoxStyle.Critical, "Error")
            txtSSBStart.Focus()
            Exit Sub
        End If

        If btnPHSave.Text = "Save" Then
            If MsgBox("Save new CONTRIBUTION BRACKET for PHILHEALTH?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPhilhealthContributionTable(0)
                Call TranPhilhealthContributionTable(4)
                btnPHCancel.PerformClick()
            End If
        ElseIf btnPHSave.Text = "Update" Then
            If MsgBox("Update CONTRIBUTION BRACKET for PHILHEALTH?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPhilhealthContributionTable(1)
                Call TranPhilhealthContributionTable(4)
                btnPHCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If

    End Sub

    Private Sub btnPHCancel_Click(sender As Object, e As EventArgs) Handles btnPHCancel.Click
        txtPHSBStart.Text = "0.00"
        txtPHSBEnd.Text = "0.00"
        txtPHSC.Text = "0.00"
        txtPHEEShare.Text = "0.00"
        txtPHERShare.Text = "0.00"
        txtPHERPlusAdj.Text = "0.00"
        txtPHSBStart.Focus()
        btnPHSave.Text = "Save"
        SelPHTableRefId = 0
    End Sub

    Private Sub btnHSSave_Click(sender As Object, e As EventArgs) Handles btnHSSave.Click
        If cboHSComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboHSCB.SelectedIndex <= 0 Then
            MsgBox("Unable to process information, no CONTRIBUTION BASIS has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboHSSched.SelectedIndex <= 0 Then
            MsgBox("Unable to process information, no CONTRIBUTION SCHEDULE has been selected from the list. Please select a value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If rdbHSRef1.Checked = True Then
            If txtHSRef1EE.Text = "0.00" Then
                MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Try
                    Convert.ToDouble(txtHSRef1EE.Text)
                Catch ex As Exception
                    MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtHSRef1EE.Text = "0.00"
                    txtHSRef1EE.Focus()
                    Exit Sub
                End Try
            End If
            If txtHSRef1ER.Text = "0.00" Then
                MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Try
                    Convert.ToDouble(txtHSRef1ER.Text)
                Catch ex As Exception
                    MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
                    txtHSRef1ER.Text = "0.00"
                    txtHSRef1ER.Focus()
                    Exit Sub
                End Try
            End If
        End If

        If btnHSSave.Text = "Save" Then
            If MsgBox("Save new CONTRIBUTION SETTING for HDMF?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranHDMFSettings(0)
                Call TranHDMFSettings(4)
                btnHSCancel.PerformClick()
            End If
        ElseIf btnHSSave.Text = "Update" Then
            If MsgBox("Update CONTRIBUTION SETTING for HDMF?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranHDMFSettings(1)
                Call TranHDMFSettings(4)
                btnHSCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnHSCancel_Click(sender As Object, e As EventArgs) Handles btnHSCancel.Click
        cboHSComp.SelectedValue = 0
        rdbHSRef0.Checked = True
        rdbHSRef1.Checked = False
        cboHSCB.SelectedIndex = 0
        cboHSSched.SelectedIndex = 0
        btnHSSave.Text = "Save"
    End Sub

    Private Sub btnHDMFSave_Click(sender As Object, e As EventArgs) Handles btnHDMFSave.Click
        Try
            Convert.ToDouble(txtHDSBStart.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid CONTRIBUTION BRACKET (Initial) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtHDSBStart.Text = "0.00"
            txtHDSBStart.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtHDSBEnd.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid CONTRIBUTION BRACKET (Ending) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtHDSBEnd.Text = "0.00"
            txtHDSBEnd.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtHDCEE.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid EMPLOYEE CONTRIBUTION VALUE supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtHDCEE.Text = "0.00"
            txtHDCEE.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToDouble(txtHDCER.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid EMPLOYER CONTRIBUTION VALUE supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtHDCER.Text = "0.00"
            txtHDCER.Focus()
            Exit Sub
        End Try

        If (Convert.ToDouble(txtHDSBEnd.Text) < Convert.ToDouble(txtHDSBStart.Text)) Or _
           (Convert.ToDouble(txtHDSBEnd.Text) = Convert.ToDouble(txtHDSBStart.Text)) Then
            MsgBox("Unable to process information, CONTRIBUTION ENDING RANGE is less than or equal to CONTRIBUTION STARTING RANGE. Please enter a valid range then try again.", MsgBoxStyle.Critical, "Error")
            txtHDSBStart.Focus()
            Exit Sub
        End If

        If btnHDMFSave.Text = "Save" Then
            If MsgBox("Save new CONTRIBUTION BRACKET for HDMF?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranHDMFContributionTable(0)
                Call TranHDMFContributionTable(4)
                btnHDMFCancel.PerformClick()
            End If
        ElseIf btnHDMFSave.Text = "Update" Then
            If MsgBox("Update CONTRIBUTION BRACKET for HDMF?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranHDMFContributionTable(1)
                Call TranHDMFContributionTable(4)
                btnHDMFCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnHDMFCancel_Click(sender As Object, e As EventArgs) Handles btnHDMFCancel.Click
        txtHDSBStart.Text = "0.00"
        txtHDSBEnd.Text = "0.00"
        txtHDSC.Text = "0.00"
        txtHDCEE.Text = "0.00"
        chkHDEE.CheckState = CheckState.Unchecked
        txtHDCER.Text = "0.00"
        chkHDER.CheckState = CheckState.Unchecked
        txtHDERA.Text = "0.00"
        txtHDSBStart.Focus()
        SelHDMFTableRefId = 0
        btnHDMFSave.Text = "Save"
    End Sub

    Private Sub btnPFSave_Click(sender As Object, e As EventArgs) Handles btnPFSave.Click
        If txtPRCode.TextLength = 0 Then
            MsgBox("Unable to process information, no PAYROLL REFERENCE Code supplied and cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPRCode.Focus()
            Exit Sub
        End If
        If txtPRDesc.TextLength = 0 Then
            MsgBox("Unable to process information, no PAYROLL REFERENCE Description supplied and cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPRDesc.Focus()
            Exit Sub
        End If
        Try
            Convert.ToDouble(txtPRDPY.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value supplied in DAYS-PER-YEAR REFERENCE . Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPRDPY.Focus()
            Exit Sub
        End Try
        If txtPRDPY.Text = "0" Then
            MsgBox("Unable to process information, DAYS-PER-YEAR REFERENCE cannot be zero(0). Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPRDPY.Focus()
            Exit Sub
        End If
        If cboPRB.SelectedIndex < 0 Then
            MsgBox("Unable to process information, invalid value selected from list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If btnHSSave.Text = "Save" Then
            If MsgBox("Save new PAYROLL REFERENCE profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayReference(0)
                Call TranPayReference(4)
                btnPFCancel.PerformClick()
            End If
        ElseIf btnHSSave.Text = "Update" Then
            If MsgBox("Update PAYROLL REFERENCE profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayReference(1)
                Call TranPayReference(4)
                btnPFCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPFCancel_Click(sender As Object, e As EventArgs) Handles btnPFCancel.Click
        txtPRCode.Clear()
        txtPRDesc.Clear()
        txtPRDPY.Text = "0"
        txtPRCode.Focus()
        SelPayReferenceId = 0
        btnPFSave.Text = "Save"
    End Sub

    Private Sub btnPBSave_Click(sender As Object, e As EventArgs) Handles btnPBSave.Click
        If txtPBCode.TextLength = 0 Then
            MsgBox("Unable to process information, no PAY BASIS Code supplied and cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPBCode.Focus()
            Exit Sub
        End If
        If txtPBDesc.TextLength = 0 Then
            MsgBox("Unable to process information, no PAY BASIS Description supplied and cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPBDesc.Focus()
            Exit Sub
        End If
        If cboPBCycle.SelectedIndex = 0 Then
            MsgBox("Unable to process information, no CYCLE COUNT has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If btnHSSave.Text = "Save" Then
            If MsgBox("Save new PAY BASIS profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayBasis(0)
                Call TranPayBasis(4)
                btnPBCancel.PerformClick()
            End If
        ElseIf btnHSSave.Text = "Update" Then
            If MsgBox("Update PAY BASIS profile?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayBasis(1)
                Call TranPayBasis(4)
                btnPBCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPBCancel_Click(sender As Object, e As EventArgs) Handles btnPBCancel.Click
        txtPBCode.Clear()
        txtPBDesc.Clear()
        cboPBCycle.SelectedIndex = 0
        SelPayBasisId = 0
        btnPBSave.Text = "Save"
    End Sub

    Private Sub btnPASave_Click(sender As Object, e As EventArgs) Handles btnPASave.Click
        If cboPAComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a valid value from the list then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtPACode.TextLength = 0 Then
            MsgBox("Unable to process information, no ADJUSTMENT TYPE CODE has been supplied and cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPACode.Focus()
            Exit Sub
        End If
        If txtPADesc.TextLength = 0 Then
            MsgBox("Unable to process information, no ADJUSTMENT TYPE DESCRIPTION has been supplied and cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPADesc.Focus()
            Exit Sub
        End If

        If btnPASave.Text = "Save" Then
            If MsgBox("Save new ADJUSTMENT TYPE information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranAdjustmentTypes(0)
                Call TranAdjustmentTypes(4)
                btnPACancel.PerformClick()
            End If
        ElseIf btnPASave.Text = "Update" Then
            If MsgBox("Update ADJUSTMENT TYPE information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranAdjustmentTypes(1)
                Call TranAdjustmentTypes(4)
                btnPACancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPACancel_Click(sender As Object, e As EventArgs) Handles btnPACancel.Click
        cboPAComp.SelectedValue = 0
        txtPACode.Clear()
        txtPADesc.Clear()
        txtPACode.Focus()
        SelPayAdjustmentId = 0
        btnPASave.Text = "Save"
    End Sub

    Private Sub btnPPSave_Click(sender As Object, e As EventArgs) Handles btnPPSave.Click
        Dim LastDayOfTheMonth As Date = DateAdd(DateInterval.Month, 1, Convert.ToDateTime("1/" + Now.Month.ToString + "/" + Now.Year.ToString))

        If cboPPComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPPEC.SelectedValue = 0 Then
            MsgBox("Unable to process information, no EMPLOYEE CLASS has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPPEG.SelectedValue = 0 Then
            MsgBox("Unable to process information, no EMPLOYEE GROUP has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Try
            Convert.ToInt16(txtPPCovFrom.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid PAYROLL CUTOFF (Starting) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPPCovFrom.Text = "1"
            txtPPCovFrom.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToInt16(txtPPCovTo.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid PAYROLL CUTOFF (Ending) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPPCovTo.Text = Convert.ToInt16(DateAdd(DateInterval.Day, -1, LastDayOfTheMonth).Day.ToString)
            txtPPCovTo.Focus()
            Exit Sub
        End Try
        Try
            Convert.ToInt16(txtPPPayDate.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid PAYROLL CUTOFF (Ending) supplied. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPPPayDate.Text = "1"
            txtPPPayDate.Focus()
            Exit Sub
        End Try

        If txtPPCovFrom.Text = "0" Or txtPPCovTo.Text = "0" Then
            MsgBox("Unable to process information, invalid COVERED PERIOD entered. Please enter a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPPCovFrom.Text = "1"
            txtPPCovTo.Text = Convert.ToInt16(DateAdd(DateInterval.Day, -1, LastDayOfTheMonth).Day.ToString)
            Exit Sub
        ElseIf Convert.ToInt16(txtPPCovFrom.Text) > Convert.ToInt16(txtPPCovTo.Text) Then
            chkPPNM.Checked = True
        Else
            ' No conditions met.
        End If
        If cboPPSequence.SelectedIndex = 0 Then
            MsgBox("Unable to process information, no PAY PERIOD SEQUENCE has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If btnPPSave.Text = "Save" Then
            If MsgBox("Save new PAYROLL SCHEDULE information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollSchedule(0)
                Call TranPayrollSchedule(4)
                btnPPCancel.PerformClick()
            End If
        ElseIf btnPPSave.Text = "Update" Then
            If MsgBox("Update PAYROLL SCHEDULE information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollSchedule(1)
                Call TranPayrollSchedule(4)
                btnPPCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPPCancel_Click(sender As Object, e As EventArgs) Handles btnPPCancel.Click
        Dim LastDayOfTheMonth As Date = DateAdd(DateInterval.Month, 1, Convert.ToDateTime("1/" + Now.Month.ToString + "/" + Now.Year.ToString))
        cboPPComp.SelectedValue = 0
        cboPPEC.SelectedValue = 0
        cboPPEG.SelectedValue = 0
        txtPPCode.Clear()
        txtPPDesc.Clear()
        txtPPCovFrom.Text = "1"
        txtPPCovTo.Text = Convert.ToInt16(DateAdd(DateInterval.Day, -1, LastDayOfTheMonth).Day.ToString)
        txtPPPayDate.Text = "1"
        cboPPSequence.SelectedIndex = 0
        btnPPSave.Text = "Save"
    End Sub

    Private Sub btnPRSave_Click(sender As Object, e As EventArgs) Handles btnPRSave.Click
        If cboRSComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboRSDept.SelectedValue = 0 Then
            MsgBox("Unable to process information, no DEPARTMENT/CLIENT has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboRSPB.SelectedValue = 0 Then
            MsgBox("Unable to process information, no PAY BASIS has been selected from the list. Please select a valid value then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtRSCode.TextLength = 0 Then
            MsgBox("Unable to process information, invalid SETTING CODE cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtRSCode.Focus()
            Exit Sub
        End If
        If txtRSDesc.TextLength = 0 Then
            MsgBox("Unable to process information, invalid SETTING CODE cannot be NULL. Please supply a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtRSCode.Focus()
            Exit Sub
        End If

        If btnPRSave.Text = "Save" Then
            If MsgBox("Save new PREMIUM RATES SETTING information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollRateSetting(0)
                Call TranPayrollRateSetting(4)
                Call LoadDataToComboBox("payratesetting-standard", cboPRCompStd.SelectedValue, cboPRStandard)
                Call LoadDataToComboBox("payratesetting-custom", cboPRCompCus.SelectedValue, cboPRCustom)
                btnPRCancel.PerformClick()
            End If
        ElseIf btnPRSave.Text = "Update" Then
            If MsgBox("Update PREMIUM RATES SETTING information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollRateSetting(1)
                Call TranPayrollRateSetting(4)
                Call LoadDataToComboBox("payratesetting-standard", cboPRCompStd.SelectedValue, cboPRStandard)
                Call LoadDataToComboBox("payratesetting-custom", cboPRCompCus.SelectedValue, cboPRCustom)
                btnPRCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPRCancel_Click(sender As Object, e As EventArgs) Handles btnPRCancel.Click
        cboRSComp.SelectedValue = 0
        cboRSDept.SelectedValue = 0
        cboRSPB.SelectedValue = 0
        txtRSCode.Clear()
        txtRSDesc.Clear()
        txtRSCode.Focus()
        SelPayRateSettingId = 0
        SelPayRegRateId = 0
        SelPaySpcRateId = 0
        btnPRSave.Text = "Save"

    End Sub

    Private Sub btnPRStdSave_Click(sender As Object, e As EventArgs) Handles btnPRStdSave.Click
        Try
            Convert.ToDouble(txtPRReg.Text)
            Convert.ToDouble(txtPRRegOT.Text)
            Convert.ToDouble(txtPRRegND.Text)
            Convert.ToDouble(txtPRRegOTND.Text)
            Convert.ToDouble(txtPRRD.Text)
            Convert.ToDouble(txtPRRDOT.Text)
            Convert.ToDouble(txtPRRDND.Text)
            Convert.ToDouble(txtPRRDOTND.Text)
            Convert.ToDouble(txtPRRDSH.Text)
            Convert.ToDouble(txtPRRDSHOT.Text)
            Convert.ToDouble(txtPRRDSHND.Text)
            Convert.ToDouble(txtPRRDOTND.Text)
            Convert.ToDouble(txtPRRDRH.Text)
            Convert.ToDouble(txtPRRDRHOT.Text)
            Convert.ToDouble(txtPRRDRHND.Text)
            Convert.ToDouble(txtPRRDOTND.Text)
            Convert.ToDouble(txtPRRDDH.Text)
            Convert.ToDouble(txtPRRDDHOT.Text)
            Convert.ToDouble(txtPRRDDHND.Text)
            Convert.ToDouble(txtPRRDDHOTND.Text)
            Convert.ToDouble(txtPRSH.Text)
            Convert.ToDouble(txtPRSHOT.Text)
            Convert.ToDouble(txtPRSHND.Text)
            Convert.ToDouble(txtPRSHOTND.Text)
            Convert.ToDouble(txtPRRH.Text)
            Convert.ToDouble(txtPRRHOT.Text)
            Convert.ToDouble(txtPRRHND.Text)
            Convert.ToDouble(txtPRRHOTND.Text)
            Convert.ToDouble(txtPRDH.Text)
            Convert.ToDouble(txtPRDHOT.Text)
            Convert.ToDouble(txtPRDHND.Text)
            Convert.ToDouble(txtPRDHOTND.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value(s) supplied. Please check inputted values then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        If btnPRStdSave.Text = "Save" Then
            If MsgBox("Save new PREMIUM RATES (Standard) setting?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollRatesStandard(0)
                btnPRStdCancel.PerformClick()
            End If
        ElseIf btnPRStdSave.Text = "Update" Then
            If MsgBox("Update PREMIUM RATES (Standard) setting?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollRatesStandard(1)
                btnPRStdCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If

    End Sub

    Private Sub btnPRStdCancel_Click(sender As Object, e As EventArgs) Handles btnPRStdCancel.Click
        ' Standard Rates
        txtPRReg.Text = "0.0000"
        txtPRRegOT.Text = "0.0000"
        txtPRRegND.Text = "0.0000"
        txtPRRegOTND.Text = "0.0000"
        txtPRRD.Text = "0.0000"
        txtPRRDOT.Text = "0.0000"
        txtPRRDND.Text = "0.0000"
        txtPRRDOTND.Text = "0.0000"
        txtPRRDSH.Text = "0.0000"
        txtPRRDSHOT.Text = "0.0000"
        txtPRRDSHND.Text = "0.0000"
        txtPRRDSHOTND.Text = "0.0000"
        txtPRRDRH.Text = "0.0000"
        txtPRRDRHOT.Text = "0.0000"
        txtPRRDRHND.Text = "0.0000"
        txtPRRDRHOTND.Text = "0.0000"
        txtPRRDDH.Text = "0.0000"
        txtPRRDDHOT.Text = "0.0000"
        txtPRRDDHND.Text = "0.0000"
        txtPRRDDHOTND.Text = "0.0000"
        txtPRSH.Text = "0.0000"
        txtPRSHOT.Text = "0.0000"
        txtPRSHND.Text = "0.0000"
        txtPRSHOTND.Text = "0.0000"
        txtPRRH.Text = "0.0000"
        txtPRRHOT.Text = "0.0000"
        txtPRRHND.Text = "0.0000"
        txtPRRHOTND.Text = "0.0000"
        txtPRDH.Text = "0.0000"
        txtPRDHOT.Text = "0.0000"
        txtPRDHND.Text = "0.0000"
        txtPRDHOTND.Text = "0.0000"
        btnPRStdSave.Text = "Save"
    End Sub

    Private Sub btnPRCusSave_Click(sender As Object, e As EventArgs) Handles btnPRCusSave.Click
        Try
            Convert.ToDouble(txtPRReg0.Text)
            Convert.ToDouble(txtPRRegOT0.Text)
            Convert.ToDouble(txtPRRegNS0.Text)
            Convert.ToDouble(txtPRRegOTNS0.Text)
            Convert.ToDouble(txtPRReg1.Text)
            Convert.ToDouble(txtPRRegOT1.Text)
            Convert.ToDouble(txtPRRegNS1.Text)
            Convert.ToDouble(txtPRRegOTNS1.Text)

            Convert.ToDouble(txtPRRD0.Text)
            Convert.ToDouble(txtPRRDOT0.Text)
            Convert.ToDouble(txtPRRDNS0.Text)
            Convert.ToDouble(txtPRRDOTNS0.Text)
            Convert.ToDouble(txtPRRD1.Text)
            Convert.ToDouble(txtPRRDOT1.Text)
            Convert.ToDouble(txtPRRDNS1.Text)
            Convert.ToDouble(txtPRRDOTNS1.Text)

            Convert.ToDouble(txtPRRDSH0.Text)
            Convert.ToDouble(txtPRRDSHOT0.Text)
            Convert.ToDouble(txtPRRDSHNS0.Text)
            Convert.ToDouble(txtPRRDSHOTNS0.Text)
            Convert.ToDouble(txtPRRDSH1.Text)
            Convert.ToDouble(txtPRRDSHOT1.Text)
            Convert.ToDouble(txtPRRDSHNS1.Text)
            Convert.ToDouble(txtPRRDSHOTNS1.Text)

            Convert.ToDouble(txtPRRDRH0.Text)
            Convert.ToDouble(txtPRRDRHOT0.Text)
            Convert.ToDouble(txtPRRDRHNS0.Text)
            Convert.ToDouble(txtPRRDRHOTNS0.Text)
            Convert.ToDouble(txtPRRDRH1.Text)
            Convert.ToDouble(txtPRRDRHOT1.Text)
            Convert.ToDouble(txtPRRDRHNS1.Text)
            Convert.ToDouble(txtPRRDRHOTNS1.Text)

            Convert.ToDouble(txtPRRDDH0.Text)
            Convert.ToDouble(txtPRRDDHOT0.Text)
            Convert.ToDouble(txtPRRDDHNS0.Text)
            Convert.ToDouble(txtPRRDDHOTNS0.Text)
            Convert.ToDouble(txtPRRDDH1.Text)
            Convert.ToDouble(txtPRRDDHOT1.Text)
            Convert.ToDouble(txtPRRDDHNS1.Text)
            Convert.ToDouble(txtPRRDDHOTNS1.Text)

            Convert.ToDouble(txtPRSH0.Text)
            Convert.ToDouble(txtPRSHOT0.Text)
            Convert.ToDouble(txtPRSHNS0.Text)
            Convert.ToDouble(txtPRSHOTNS0.Text)
            Convert.ToDouble(txtPRSH1.Text)
            Convert.ToDouble(txtPRSHOT1.Text)
            Convert.ToDouble(txtPRSHNS1.Text)
            Convert.ToDouble(txtPRSHOTNS1.Text)

            Convert.ToDouble(txtPRRH0.Text)
            Convert.ToDouble(txtPRRHOT0.Text)
            Convert.ToDouble(txtPRRHNS0.Text)
            Convert.ToDouble(txtPRRHOTNS0.Text)
            Convert.ToDouble(txtPRRH1.Text)
            Convert.ToDouble(txtPRRHOT1.Text)
            Convert.ToDouble(txtPRRHOTNS1.Text)
            Convert.ToDouble(txtPRRHOTNS1.Text)

            Convert.ToDouble(txtPRDH0.Text)
            Convert.ToDouble(txtPRDHOT0.Text)
            Convert.ToDouble(txtPRDHNS0.Text)
            Convert.ToDouble(txtPRDHOTNS0.Text)
            Convert.ToDouble(txtPRDH1.Text)
            Convert.ToDouble(txtPRDHOT1.Text)
            Convert.ToDouble(txtPRDHNS1.Text)
            Convert.ToDouble(txtPRDHOTNS1.Text)
        Catch ex As Exception
            MsgBox("Unable to process information, invalid value(s) supplied. Please check inputted values then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        If btnPRCusSave.Text = "Save" Then
            If MsgBox("Save new PREMIUM RATES (Custom) setting?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollRatesCustom(0)
                cboPRCompCus.SelectedValue = 0
                cboPRCustom.SelectedValue = 0
                btnPRCusCancel.PerformClick()
            End If
        ElseIf btnPRCusSave.Text = "Update" Then
            If MsgBox("Update PREMIUM RATES (Custom) setting?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollRatesCustom(1)
                cboPRCompCus.SelectedValue = 0
                cboPRCustom.SelectedValue = 0
                btnPRCusCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPRCusCancel_Click(sender As Object, e As EventArgs) Handles btnPRCusCancel.Click
        ' Custom Rates                 
        txtPRReg0.Text = "0.0000"
        txtPRRegOT0.Text = "0.0000"
        txtPRRegNS0.Text = "0.0000"
        txtPRRegOTNS0.Text = "0.0000"
        txtPRReg1.Text = "0.0000"
        txtPRRegOT1.Text = "0.0000"
        txtPRRegNS1.Text = "0.0000"
        txtPRRegOTNS1.Text = "0.0000"

        txtPRRD0.Text = "0.0000"
        txtPRRDOT0.Text = "0.0000"
        txtPRRDNS0.Text = "0.0000"
        txtPRRDOTNS0.Text = "0.0000"
        txtPRRD1.Text = "0.0000"
        txtPRRDOT1.Text = "0.0000"
        txtPRRDNS1.Text = "0.0000"
        txtPRRDOTNS1.Text = "0.0000"

        txtPRRDSH0.Text = "0.0000"
        txtPRRDSHOT0.Text = "0.0000"
        txtPRRDSHNS0.Text = "0.0000"
        txtPRRDSHOTNS0.Text = "0.0000"
        txtPRRDSH1.Text = "0.0000"
        txtPRRDSHOT1.Text = "0.0000"
        txtPRRDSHNS1.Text = "0.0000"
        txtPRRDSHOTNS1.Text = "0.0000"

        txtPRRDRH0.Text = "0.0000"
        txtPRRDRHOT0.Text = "0.0000"
        txtPRRDRHNS0.Text = "0.0000"
        txtPRRDRHOTNS0.Text = "0.0000"
        txtPRRDRH1.Text = "0.0000"
        txtPRRDRHOT1.Text = "0.0000"
        txtPRRDRHNS1.Text = "0.0000"
        txtPRRDRHOTNS1.Text = "0.0000"

        txtPRRDDH0.Text = "0.0000"
        txtPRRDDHOT0.Text = "0.0000"
        txtPRRDDHNS0.Text = "0.0000"
        txtPRRDDHOTNS0.Text = "0.0000"
        txtPRRDDH1.Text = "0.0000"
        txtPRRDDHOT1.Text = "0.0000"
        txtPRRDDHNS1.Text = "0.0000"
        txtPRRDDHOTNS1.Text = "0.0000"

        txtPRSH0.Text = "0.0000"
        txtPRSHOT0.Text = "0.0000"
        txtPRSHNS0.Text = "0.0000"
        txtPRSHOTNS0.Text = "0.0000"
        txtPRSH1.Text = "0.0000"
        txtPRSHOT1.Text = "0.0000"
        txtPRSHNS1.Text = "0.0000"
        txtPRSHOTNS1.Text = "0.0000"

        txtPRRH0.Text = "0.0000"
        txtPRRHOT0.Text = "0.0000"
        txtPRRHNS0.Text = "0.0000"
        txtPRRHOTNS0.Text = "0.0000"
        txtPRRH1.Text = "0.0000"
        txtPRRHOT1.Text = "0.0000"
        txtPRRHOTNS1.Text = "0.0000"
        txtPRRHOTNS1.Text = "0.0000"

        txtPRDH0.Text = "0.0000"
        txtPRDHOT0.Text = "0.0000"
        txtPRDHNS0.Text = "0.0000"
        txtPRDHOTNS0.Text = "0.0000"
        txtPRDH1.Text = "0.0000"
        txtPRDHOT1.Text = "0.0000"
        txtPRDHNS1.Text = "0.0000"
        txtPRDHOTNS1.Text = "0.0000"

        btnPRCusSave.Text = "Save"
    End Sub

    Private Sub btnPPRSave_Click(sender As Object, e As EventArgs) Handles btnPPRSave.Click
        If cboPPRComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a valid value from the list then try again", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPPREC.SelectedValue = 0 Then
            MsgBox("Unable to process information, no EMPLOYEE CLASS has been selected from the list. Please select a valid value from the list then try again", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPPREG.SelectedValue = 0 Then
            MsgBox("Unable to process information, no EMPLOYEE GROUP has been selected from the list. Please select a valid value from the list then try again", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cboPPProc.SelectedValue = 0 Then
            MsgBox("Unable to process information, no PROCESSOR has been selected from the list. Please select a valid value from the list then try again", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If btnBSave.Text = "Save" Then
            If MsgBox("Save new PAYROLL PROCESSOR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollProcessor(0)
                Call TranPayrollProcessor(4)
                btnPPRSave.PerformClick()
            End If
        ElseIf btnBSave.Text = "Update" Then
            If MsgBox("Update PAYROLL PROCESSOR information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayrollProcessor(1)
                Call TranPayrollProcessor(4)
                btnPPRSave.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPPRCancel_Click(sender As Object, e As EventArgs) Handles btnPPRCancel.Click
        cboPPRComp.SelectedValue = 0
        cboPPREC.SelectedValue = 0
        cboPPREG.SelectedValue = 0
        cboPPProc.SelectedValue = 0
        SelPayrollProcessorId = 0
        btnPPRSave.Text = "Save"
    End Sub

    Private Sub cboTEBPayBasis_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTEBPayBasis.SelectedValueChanged
        Try
            Call TranTaxExemptBracket(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboTEBET_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTEBET.SelectedValueChanged
        Try
            Call TranTaxExemptBracket(4)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPPComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPPComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employeeclass", cboPPComp.SelectedValue, cboPPEC)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPRStandard_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPRStandard.SelectedValueChanged
        Try
            btnPRStdCancel.PerformClick()
            Call GetStandardRates(cboPRStandard.SelectedValue)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPRCustom_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPRCustom.SelectedValueChanged
        Try
            btnPRCusCancel.PerformClick()
            Call GetCustomRates(cboPRCustom.SelectedValue)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPRCompStd_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPRCompStd.SelectedValueChanged
        Try
            Call LoadDataToComboBox("payratesetting-standard", cboPRCompStd.SelectedValue, cboPRStandard)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPRCompCus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPRCompCus.SelectedValueChanged
        Try
            Call LoadDataToComboBox("payratesetting-custom", cboPRCompCus.SelectedValue, cboPRCustom)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPPEC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPPEC.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employeegroup", cboPPEC.SelectedValue, cboPPEG)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPPRComp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPPRComp.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employeeclass", cboPPRComp.SelectedValue, cboPPREC)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub cboPPREC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPPREC.SelectedValueChanged
        Try
            Call LoadDataToComboBox("employeegroup", cboPPREC.SelectedValue, cboPPREG)
        Catch ex As Exception
            ' Bypass error
        End Try
    End Sub

    Private Sub dgvET_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvET.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvET.Rows(e.RowIndex)
                    SelExemptTypeId = Convert.ToInt64(.Cells(2).Value)
                    txtETCode.Text = .Cells(4).Value.ToString
                    txtETDesc.Text = .Cells(5).Value.ToString
                End With
                btnETSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvET.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelExemptTypeId = Convert.ToInt64(dgvET.Rows(e.RowIndex).Cells(2).Value)
                    Call TranTaxExemptionTypes(2)
                    Call TranTaxExemptionTypes(4)
                    SelExemptTypeId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvET_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvET.DataBindingComplete
        With dgvET
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Tax Exemption Type"
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(4).Visible = False
            .Columns(5).Visible = False
        End With
    End Sub

    Private Sub dgvTEB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTEB.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvTEB.Rows(e.RowIndex)
                    SelExemptBracketId = Convert.ToInt64(.Cells(2).Value)
                    cboTEBET.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    cboTEBPayBasis.SelectedValue = Convert.ToInt64(.Cells(4).Value)
                    txtTEBPE.Text = FormatNumber(.Cells(6).Value, 2)
                    txtTEBAT.Text = FormatNumber(.Cells(7).Value, 2)
                    txtTEBPlusPCT.Text = FormatNumber(.Cells(8).Value, 2)
                    txtTEBPlusEx.Text = FormatNumber(.Cells(9).Value, 2)
                End With
                btnTEBSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvTEB.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelExemptBracketId = Convert.ToInt64(dgvTEB.Rows(e.RowIndex).Cells(2).Value)
                    Call TranTaxExemptBracket(2)
                    Call TranTaxExemptBracket(4)
                    SelExemptBracketId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvTEB_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTEB.DataBindingComplete
        With dgvTEB
            .Columns(2).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            With .Columns(3)
                .HeaderText = "Exemption Type"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(6)
                .HeaderText = "Personal Exemption"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "c"
            End With
            With .Columns(7)
                .HeaderText = "Exemption Amount"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "c"
            End With
            With .Columns(8)
                .HeaderText = "Plus % Over"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "n"
            End With
            With .Columns(9)
                .HeaderText = "Plus Amount over EA"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .DefaultCellStyle.Format = "c"
            End With
        End With
    End Sub

    Private Sub dgvATB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvATB.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvATB.Rows(e.RowIndex)
                    SelAnnualTaxBracketId = Convert.ToInt64(.Cells(2).Value)
                    txtATBBStart.Text = FormatNumber(.Cells(3).Value, 2)
                    txtATBBEnd.Text = FormatNumber(.Cells(4).Value, 2)
                    txtATBAT.Text = FormatNumber(.Cells(5).Value, 2)
                    txtATBPlusPct.Text = FormatNumber(.Cells(6).Value, 2)
                    txtATBPlusEx.Text = FormatNumber(.Cells(7).Value, 2)
                End With
                btnATBSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvATB.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelAnnualTaxBracketId = Convert.ToInt64(dgvATB.Rows(e.RowIndex).Cells(2).Value)
                    Call TranAnnualizedTaxBracket(2)
                    Call TranAnnualizedTaxBracket(4)
                    SelAnnualTaxBracketId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvATB_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvATB.DataBindingComplete
        With dgvATB
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Amount Over"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Format = "c"
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                End With
            End With
            With .Columns(4)
                .HeaderText = "Amount NOT Over"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Format = "c"
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                End With
            End With
            With .Columns(5)
                .HeaderText = "Applied Tax"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Format = "c"
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                End With
            End With
            With .Columns(6)
                .HeaderText = "Plus % Over BA"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Format = "n"
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                End With
            End With
            With .Columns(7)
                .HeaderText = "Base Amount"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Format = "c"
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                End With
            End With
        End With
    End Sub

    Private Sub dgvEC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEC.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvEC.Rows(e.RowIndex)
                    SelECOLAId = Convert.ToInt64(.Cells(2).Value)
                    cboECComp.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                    txtECCode.Text = .Cells(8).Value.ToString
                    txtECDesc.Text = .Cells(9).Value.ToString
                    txtECAR.Text = FormatNumber(.Cells(10).Value, 2)
                    chkECProRate.Checked = Convert.ToBoolean(.Cells(11).Value)
                End With
                btnECSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvEC.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelECOLAId = Convert.ToInt64(dgvEC.Rows(e.RowIndex).Cells(2).Value)
                    Call TranECOLASetting(2)
                    Call TranECOLASetting(4)
                    SelECOLAId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvEC_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEC.DataBindingComplete
        With dgvEC
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "ECOLA Setting"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "ECOLA Rate"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "n"
                End With
            End With
            With .Columns(5)
                .HeaderText = "Pro-Rated"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(6)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
        End With
    End Sub

    Private Sub dgvSSet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSSet.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvSSet.Rows(e.RowIndex)
                    SelSSSSettingId = Convert.ToInt64(.Cells(2).Value)
                    cboSSetComp.SelectedValue = Convert.ToInt64(.Cells(9).Value)
                    rdbSSRef0.Checked = Convert.ToBoolean(.Cells(10).Value)
                    rdbSSRef1.Checked = Convert.ToBoolean(.Cells(11).Value)
                    txtSSRef1EE.Text = FormatNumber(.Cells(12).Value, 2).ToString
                    chkSSRef1EE.Checked = Convert.ToBoolean(.Cells(13).Value)
                    txtSSRef1ER.Text = FormatNumber(.Cells(14).Value, 2).ToString
                    chkSSRef1ER.Checked = Convert.ToBoolean(.Cells(15).Value)
                    cboSSetCB.SelectedIndex = Convert.ToInt64(.Cells(16).Value)
                    cboSSetSched.SelectedIndex = Convert.ToInt64(.Cells(17).Value)
                End With
                btnSSetSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvSSet.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelSSSSettingId = Convert.ToInt64(dgvSSet.Rows(e.RowIndex).Cells(2).Value)
                    Call TranSSSSettings(2)
                    Call TranSSSSettings(4)
                    SelSSSSettingId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvSSet_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSSet.DataBindingComplete
        With dgvSSet
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Reference"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(5)
                .HeaderText = "EE Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "ER Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(7)
                .HeaderText = "Deduction Basis"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(8)
                .HeaderText = "Deduction Schedule"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
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

    Private Sub dgvSSS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSSS.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvSSS.Rows(e.RowIndex)
                    SelSSSTableRefId = Convert.ToInt64(.Cells(2).Value)
                    txtSSBStart.Text = FormatNumber(.Cells(7).Value, 2).ToString
                    txtSSBEnd.Text = FormatNumber(.Cells(8).Value, 2).ToString
                    txtSSC.Text = FormatNumber(.Cells(9).Value, 2).ToString
                    txtSEEShare.Text = FormatNumber(.Cells(10).Value, 2).ToString
                    txtSERShare.Text = FormatNumber(.Cells(11).Value, 2).ToString
                    txtERSPlusAdj.Text = FormatNumber(.Cells(12).Value, 2).ToString
                End With
                btnSSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvSSS.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelSSSTableRefId = Convert.ToInt64(dgvSSS.Rows(e.RowIndex).Cells(2).Value)
                    Call TranSSSContributionTable(2)
                    Call TranSSSContributionTable(4)
                    SelSSSTableRefId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvSSS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSSS.DataBindingComplete
        With dgvSSS
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Salary Bracket"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(4)
                .HeaderText = "Salary Credit"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(5)
                .HeaderText = "EE Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "ER Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
        End With
    End Sub

    Private Sub dgvPS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPS.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvSSet.Rows(e.RowIndex)
                    SelPHSettingId = Convert.ToInt64(.Cells(2).Value)
                    cboPSComp.SelectedValue = Convert.ToInt64(.Cells(9).Value)
                    rdbPSRef0.Checked = Convert.ToBoolean(.Cells(10).Value)
                    rdbPSRef1.Checked = Convert.ToBoolean(.Cells(11).Value)
                    txtPSRef1EE.Text = FormatNumber(.Cells(12).Value, 2).ToString
                    chkPSRef1EE.Checked = Convert.ToBoolean(.Cells(13).Value)
                    txtPSRef1ER.Text = FormatNumber(.Cells(14).Value, 2).ToString
                    chkPSRef1ER.Checked = Convert.ToBoolean(.Cells(15).Value)
                    cboPSCB.SelectedIndex = Convert.ToInt64(.Cells(16).Value)
                    cboPSSched.SelectedIndex = Convert.ToInt64(.Cells(17).Value)
                End With
                btnPSSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvPS.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPHSettingId = Convert.ToInt64(dgvPS.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPhilhealthSettings(2)
                    Call TranPhilhealthSettings(4)
                    SelPHSettingId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPS.DataBindingComplete
        With dgvPS
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Reference"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(5)
                .HeaderText = "EE Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "ER Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(7)
                .HeaderText = "Deduction Basis"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(8)
                .HeaderText = "Deduction Schedule"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
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

    Private Sub dgvPH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPH.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPH.Rows(e.RowIndex)
                    SelPHTableRefId = Convert.ToInt64(.Cells(2).Value)
                    txtPHSBStart.Text = FormatNumber(.Cells(7).Value, 2).ToString
                    txtPHSBEnd.Text = FormatNumber(.Cells(8).Value, 2).ToString
                    txtPHSC.Text = FormatNumber(.Cells(9).Value, 2).ToString
                    txtPHERShare.Text = FormatNumber(.Cells(10).Value, 2).ToString
                    txtPHEEShare.Text = FormatNumber(.Cells(11).Value, 2).ToString
                    txtPHERPlusAdj.Text = FormatNumber(.Cells(12).Value, 2).ToString
                End With
                btnSSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvPH.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPHTableRefId = Convert.ToInt64(dgvPH.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPhilhealthContributionTable(2)
                    Call TranPhilhealthContributionTable(4)
                    SelPHTableRefId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPH_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPH.DataBindingComplete
        With dgvPH
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Salary Bracket"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(4)
                .HeaderText = "Salary Credit"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(5)
                .HeaderText = "EE Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "ER Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
        End With
    End Sub

    Private Sub dgvHS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHS.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvHS.Rows(e.RowIndex)
                    SelHDMFSettingId = Convert.ToInt64(.Cells(2).Value)
                    cboHSComp.SelectedValue = Convert.ToInt64(.Cells(9).Value)
                    rdbHSRef0.Checked = Convert.ToBoolean(.Cells(10).Value)
                    rdbHSRef1.Checked = Convert.ToBoolean(.Cells(11).Value)
                    txtHSRef1EE.Text = FormatNumber(.Cells(12).Value, 2).ToString
                    chkHSRef1EE.Checked = Convert.ToBoolean(.Cells(13).Value)
                    txtHSRef1ER.Text = FormatNumber(.Cells(14).Value, 2).ToString
                    chkHSRef1ER.Checked = Convert.ToBoolean(.Cells(15).Value)
                    cboHSCB.SelectedIndex = Convert.ToInt64(.Cells(16).Value)
                    cboHSSched.SelectedIndex = Convert.ToInt64(.Cells(17).Value)
                End With
                btnHDMFSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvHS.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelHDMFSettingId = Convert.ToInt64(dgvHS.Rows(e.RowIndex).Cells(2).Value)
                    Call TranHDMFSettings(2)
                    Call TranHDMFSettings(4)
                    SelHDMFSettingId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvHS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvHS.DataBindingComplete
        With dgvHS
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Reference"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(5)
                .HeaderText = "EE Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "ER Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(7)
                .HeaderText = "Deduction Basis"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(8)
                .HeaderText = "Deduction Schedule"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
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

    Private Sub dgvHDMF_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHDMF.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPH.Rows(e.RowIndex)
                    SelHDMFTableRefId = Convert.ToInt64(.Cells(2).Value)
                    txtHDSBStart.Text = FormatNumber(.Cells(7).Value, 2).ToString
                    txtHDSBEnd.Text = FormatNumber(.Cells(8).Value, 2).ToString
                    txtHDSC.Text = FormatNumber(.Cells(9).Value, 2).ToString
                    txtHDCEE.Text = FormatNumber(.Cells(10).Value, 2).ToString
                    chkHDEE.Checked = Convert.ToBoolean(.Cells(11).Value)
                    txtHDCER.Text = FormatNumber(.Cells(12).Value, 2).ToString
                    chkHDER.Checked = Convert.ToBoolean(.Cells(13).Value)
                End With
                btnHDMFSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete TAX EXEMPTION TYPE " + dgvPH.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelHDMFTableRefId = Convert.ToInt64(dgvPH.Rows(e.RowIndex).Cells(2).Value)
                    Call TranHDMFContributionTable(2)
                    Call TranHDMFContributionTable(4)
                    SelHDMFTableRefId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvHDMF_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvHDMF.DataBindingComplete
        With dgvHDMF
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Salary Bracket"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(4)
                .HeaderText = "Salary Credit"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(5)
                .HeaderText = "EE Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            With .Columns(6)
                .HeaderText = "ER Share"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleRight
                    .Format = "c"
                End With
            End With
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
        End With
    End Sub

    Private Sub dgvPRef_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPRef.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPRef.Rows(e.RowIndex)
                    SelPayReferenceId = Convert.ToInt64(.Cells(2).Value)
                    txtPRCode.Text = .Cells(4).Value.ToString
                    txtPRDesc.Text = .Cells(5).Value.ToString
                    txtPRDPY.Text = .Cells(6).Value.ToString
                End With
                btnPFSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete PAYROLL REFERENCE " + dgvPRef.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayReferenceId = Convert.ToInt64(dgvPRef.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayReference(2)
                    Call TranPayReference(4)
                    SelPayReferenceId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPRef_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPRef.DataBindingComplete
        With dgvPRef
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Payroll Reference"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
        End With
    End Sub

    Private Sub dgvPB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPB.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPB.Rows(e.RowIndex)
                    SelPayBasisId = Convert.ToInt64(.Cells(2).Value)
                    txtPBCode.Text = .Cells(4).Value.ToString
                    txtPBDesc.Text = .Cells(5).Value.ToString
                    cboPBCycle.SelectedIndex = Convert.ToInt16(.Cells(6).Value)
                End With
                btnPBSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete PAY BASIS " + dgvPB.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayBasisId = Convert.ToInt64(dgvPB.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayReference(2)
                    Call TranPayReference(4)
                    SelPayBasisId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPB_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPB.DataBindingComplete
        With dgvPB
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Pay Basis"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
        End With
    End Sub

    Private Sub dgvPA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPA.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPA.Rows(e.RowIndex)
                    SelPayAdjustmentId = Convert.ToInt64(.Cells(2).Value)
                    cboPAComp.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    txtPACode.Text = .Cells(7).Value.ToString
                    txtPADesc.Text = .Cells(8).Value.ToString
                    chkPATaxable.Checked = Convert.ToBoolean(.Cells(9).Value)
                End With
                btnPASave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete PAYROLL ADJUSTMENT TYPE " + dgvPA.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayAdjustmentId = Convert.ToInt64(dgvPA.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayReference(2)
                    Call TranPayReference(4)
                    SelPayAdjustmentId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPA_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPA.DataBindingComplete
        With dgvPA
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Adjustment Type"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Taxable"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(5)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
        End With
    End Sub

    Private Sub dgvPPS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPPS.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPPS.Rows(e.RowIndex)
                    SelPayScheduleId = Convert.ToInt64(.Cells(2).Value)
                    cboPPComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    cboPPEC.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    cboPPEG.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                    txtPPCode.Text = .Cells(8).Value.ToString
                    txtPPDesc.Text = .Cells(9).Value.ToString
                    txtPPCovFrom.Text = .Cells(10).Value.ToString
                    txtPPCovTo.Text = .Cells(11).Value.ToString
                    chkPPNM.Checked = Convert.ToBoolean(.Cells(12).Value)
                    txtPPPayDate.Text = .Cells(13).Value.ToString
                    cboPPSequence.SelectedIndex = Convert.ToInt16(.Cells(14).Value)
                End With
                btnPPSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete PAYROLL ADJUSTMENT TYPE " + dgvPPS.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayScheduleId = Convert.ToInt64(dgvPPS.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayReference(2)
                    Call TranPayReference(4)
                    SelPayScheduleId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPPS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPPS.DataBindingComplete
        With dgvPPS
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Pay Period"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Covered Employees"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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
        End With
    End Sub

    Private Sub dgvPR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPR.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPR.Rows(e.RowIndex)
                    SelPayRateSettingId = Convert.ToInt64(.Cells(2).Value)
                    cboRSComp.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                    cboRSDept.SelectedValue = Convert.ToInt64(.Cells(8).Value)
                    cboRSPB.SelectedValue = Convert.ToInt64(.Cells(9).Value)
                    txtRSCode.Text = .Cells(10).Value.ToString
                    txtRSDesc.Text = .Cells(11).Value.ToString
                    chkRSSC.Checked = Convert.ToBoolean(.Cells(12).Value)
                    SelPayRegRateId = Convert.ToInt64(.Cells(13).Value)
                    SelPaySpcRateId = Convert.ToInt64(.Cells(14).Value)
                End With
                btnPRSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete RATE SETTING " + dgvPR.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayRateSettingId = Convert.ToInt64(dgvPR.Rows(e.RowIndex).Cells(2).Value)
                    SelPayRegRateId = Convert.ToInt64(dgvPR.Rows(e.RowIndex).Cells(13).Value)
                    SelPaySpcRateId = Convert.ToInt64(dgvPR.Rows(e.RowIndex).Cells(14).Value)
                    Call TranPayrollRateSetting(2)
                    Call TranPayrollRateSetting(4)
                    SelPayRateSettingId = 0
                    SelPayRegRateId = 0
                    SelPaySpcRateId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPR_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPR.DataBindingComplete
        With dgvPR
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Rate Setting"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Covered Employees"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(5)
                .HeaderText = "Payment Basis"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(6)
                .HeaderText = "Use Cost-Sharing"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
        End With
    End Sub

    Private Sub dgvPC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPC.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPC.Rows(e.RowIndex)
                    SelPayChannelId = Convert.ToInt64(.Cells(2).Value)
                    cboPCComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    txtPCCode.Text = .Cells(6).Value.ToString
                    txtPCDesc.Text = .Cells(7).Value.ToString
                End With
                btnPCSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete RATE SETTING " + dgvPC.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayChannelId = Convert.ToInt64(dgvPC.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayChannels(2)
                    Call TranPayChannels(4)
                    SelPayChannelId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPC_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPC.DataBindingComplete
        With dgvPC
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Payment Channels"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
        End With
    End Sub

    Private Sub dgvBanks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBanks.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvBanks.Rows(e.RowIndex)
                    SelPayBanksId = Convert.ToInt64(.Cells(2).Value)
                    cboPCComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    txtPCCode.Text = .Cells(6).Value.ToString
                    txtPCDesc.Text = .Cells(7).Value.ToString
                End With
                btnBSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete BANK " + dgvBanks.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayBanksId = Convert.ToInt64(dgvBanks.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayChannels(2)
                    Call TranPayChannels(4)
                    SelPayBanksId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvBanks_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvBanks.DataBindingComplete
        With dgvBanks
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Bank"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Payment Channel"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(5)
                .HeaderText = "Company"
                .MinimumWidth = 150
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
        End With
    End Sub

    Private Sub dgvPPR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPPR.CellContentClick
        If TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.RowIndex >= 0 Then
            If e.ColumnIndex = 0 Then
                With dgvPPR.Rows(e.RowIndex)
                    SelPayrollProcessorId = Convert.ToInt64(.Cells(2).Value)
                    cboPPRComp.SelectedValue = Convert.ToInt64(.Cells(5).Value)
                    cboPPEC.SelectedValue = Convert.ToInt64(.Cells(6).Value)
                    cboPPEG.SelectedValue = Convert.ToInt64(.Cells(7).Value)
                    cboPPProc.SelectedValue = Convert.ToInt64(.Cells(8).Value)
                End With
                btnPPRSave.Text = "Update"

            ElseIf e.ColumnIndex = 1 Then
                If MsgBox("Are you sure you want to delete PAYROLL PROCESSOR " + dgvPPR.Rows(e.RowIndex).Cells(3).Value + " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SelPayrollProcessorId = Convert.ToInt64(dgvPPR.Rows(e.RowIndex).Cells(2).Value)
                    Call TranPayrollProcessor(2)
                    Call TranPayrollProcessor(4)
                    SelPayrollProcessorId = 0
                End If
            Else
                MsgBox("No conditions have been met.", MsgBoxStyle.Critical, "No conditions")
            End If
        End If
    End Sub

    Private Sub dgvPPR_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvPPR.DataBindingComplete
        With dgvPPR
            .Columns(2).Visible = False
            With .Columns(3)
                .HeaderText = "Employee"
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            With .Columns(4)
                .HeaderText = "Covered Employees"
                .MinimumWidth = 250
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
    End Sub

    Private Sub frmPayrollSetup_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

        Call TranTaxExemptionTypes(4)

        Call TranTaxExemptBracket(4)
        Call LoadDataToComboBox("taxexemptiontype", 0, cboTEBET)
        Call LoadDataToComboBox("paybasis", 0, cboTEBPayBasis)

        Call TranAnnualizedTaxBracket(4)

        Call TranSSSSettings(4)
        Call TranSSSContributionTable(4)
        Call LoadDataToComboBox("company", 0, cboSSetComp)
        btnSSetCancel.PerformClick()

        Call TranPhilhealthSettings(4)
        Call TranPhilhealthContributionTable(4)
        Call LoadDataToComboBox("company", 0, cboPSComp)
        btnPSCancel.PerformClick()

        Call TranHDMFSettings(4)
        Call TranHDMFContributionTable(4)
        Call LoadDataToComboBox("company", 0, cboHSComp)
        btnHSCancel.PerformClick()

        Call TranECOLASetting(4)
        Call LoadDataToComboBox("company", 0, cboECComp)

        Call TranPayReference(4)

        Call TranPayBasis(4)
        cboPBCycle.SelectedIndex = 0

        Call TranAdjustmentTypes(4)
        Call LoadDataToComboBox("company", 0, cboPAComp)

        Call TranPayrollSchedule(4)
        Call LoadDataToComboBox("company", 0, cboPPComp)
        Call LoadDataToComboBox("employeeclass", cboPPComp.SelectedValue, cboPPEC)
        Call LoadDataToComboBox("employeegroup", cboPPEC.SelectedValue, cboPPEG)
        cboPPSequence.SelectedIndex = 0

        Call TranPayrollRateSetting(4)
        Call LoadDataToComboBox("company", 0, cboRSComp)
        Call LoadDataToComboBox("department", cboRSComp.SelectedValue, cboRSDept)
        Call LoadDataToComboBox("paybasis", 0, cboRSPB)

        Call LoadDataToComboBox("company", 0, cboPRCompCus)
        Call LoadDataToComboBox("company", 0, cboPRCompStd)

        Call TranPayChannels(4)
        Call LoadDataToComboBox("company", 0, cboPCComp)

        Call TranBanks(4)
        Call LoadDataToComboBox("company", 0, cboBComp)
        Call LoadDataToComboBox("paychannels", cboBComp.SelectedValue, cboBChannel)

        Call TranPayrollProcessor(4)
        Call LoadDataToComboBox("company", 0, cboPPRComp)
        Call LoadDataToComboBox("employeeclass", cboPPRComp.SelectedValue, cboPPREC)
        Call LoadDataToComboBox("employeegroup", cboPPREC.SelectedValue, cboPPREG)
        Call LoadDataToComboBox("processors", cboPPRComp.SelectedValue, cboPPProc)
    End Sub

    Private Sub frmPayrollSetup_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TranTaxExemptionTypes(4)

        Call TranTaxExemptBracket(4)
        Call LoadDataToComboBox("taxexemptiontype", 0, cboTEBET)
        Call LoadDataToComboBox("paybasis", 0, cboTEBPayBasis)

        Call TranAnnualizedTaxBracket(4)

        Call TranSSSSettings(4)
        Call TranSSSContributionTable(4)
        Call LoadDataToComboBox("company", 0, cboSSetComp)
        btnSSetCancel.PerformClick()

        Call TranPhilhealthSettings(4)
        Call TranPhilhealthContributionTable(4)
        Call LoadDataToComboBox("company", 0, cboPSComp)
        btnPSCancel.PerformClick()

        Call TranHDMFSettings(4)
        Call TranHDMFContributionTable(4)
        Call LoadDataToComboBox("company", 0, cboHSComp)
        btnHSCancel.PerformClick()

        Call TranECOLASetting(4)
        Call LoadDataToComboBox("company", 0, cboECComp)

        Call TranPayReference(4)

        Call TranPayBasis(4)
        cboPBCycle.SelectedIndex = 0

        Call TranAdjustmentTypes(4)
        Call LoadDataToComboBox("company", 0, cboPAComp)

        Call TranPayrollSchedule(4)
        Call LoadDataToComboBox("company", 0, cboPPComp)
        Call LoadDataToComboBox("employeeclass", cboPPComp.SelectedValue, cboPPEC)
        Call LoadDataToComboBox("employeegroup", cboPPEC.SelectedValue, cboPPEG)
        cboPPSequence.SelectedIndex = 0

        Call TranPayrollRateSetting(4)
        Call LoadDataToComboBox("company", 0, cboRSComp)
        Call LoadDataToComboBox("department", cboRSComp.SelectedValue, cboRSDept)
        Call LoadDataToComboBox("paybasis", 0, cboRSPB)

        Call LoadDataToComboBox("company", 0, cboPRCompCus)
        Call LoadDataToComboBox("company", 0, cboPRCompStd)

        Call TranPayChannels(4)
        Call LoadDataToComboBox("company", 0, cboPCComp)

        Call TranBanks(4)
        Call LoadDataToComboBox("company", 0, cboBComp)
        Call LoadDataToComboBox("paychannels", cboBComp.SelectedValue, cboBChannel)

        Call TranPayrollProcessor(4)
        Call LoadDataToComboBox("company", 0, cboPPRComp)
        Call LoadDataToComboBox("employeeclass", cboPPRComp.SelectedValue, cboPPREC)
        Call LoadDataToComboBox("employeegroup", cboPPREC.SelectedValue, cboPPREG)
        Call LoadDataToComboBox("processors", cboPPRComp.SelectedValue, cboPPProc)

    End Sub

    Private Sub rdbSSRef0_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSSRef0.CheckedChanged, rdbSSRef1.CheckedChanged
        txtSSRef1EE.Enabled = Convert.ToBoolean(rdbSSRef1.Checked)
        txtSSRef1EE.Text = "0.00"
        txtSSRef1ER.Enabled = Convert.ToBoolean(rdbSSRef1.Checked)
        txtSSRef1ER.Text = "0.00"
        chkSSRef1EE.Enabled = Convert.ToBoolean(rdbSSRef1.Checked)
        chkSSRef1ER.Enabled = Convert.ToBoolean(rdbSSRef1.Checked)
    End Sub

    Private Sub rdbPSRef0_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPSRef0.CheckedChanged, rdbPSRef1.CheckedChanged
        txtPSRef1EE.Enabled = Convert.ToBoolean(rdbPSRef1.Checked)
        txtPSRef1EE.Text = "0.00"
        txtPSRef1ER.Enabled = Convert.ToBoolean(rdbPSRef1.Checked)
        txtPSRef1ER.Text = "0.00"
        chkPSRef1EE.Enabled = Convert.ToBoolean(rdbPSRef1.Checked)
        chkPSRef1ER.Enabled = Convert.ToBoolean(rdbPSRef1.Checked)
    End Sub

    Private Sub rdbHSRef0_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHSRef0.CheckedChanged, rdbHSRef1.CheckedChanged
        txtHSRef1EE.Enabled = Convert.ToBoolean(rdbHSRef1.Checked)
        txtHSRef1EE.Text = "0.00"
        txtHSRef1ER.Enabled = Convert.ToBoolean(rdbHSRef1.Checked)
        txtHSRef1ER.Text = "0.00"
        chkHSRef1EE.Enabled = Convert.ToBoolean(rdbHSRef1.Checked)
        chkHSRef1ER.Enabled = Convert.ToBoolean(rdbHSRef1.Checked)
    End Sub

    Private Sub btnPCSave_Click(sender As Object, e As EventArgs) Handles btnPCSave.Click
        If cboPCComp.SelectedValue = 0 Then
            MsgBox("Unable to process information, no COMPANY has been selected from the list. Please select a valid value from the list then try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If txtPCCode.TextLength = 0 Then
            MsgBox("Unable to process information, invalid or no CHANNEL CODE supplied. Please keyin a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPCCode.Focus()
            Exit Sub
        End If
        If txtPCDesc.TextLength = 0 Then
            MsgBox("Unable to process information, invalid or no CHANNEL DESCRIPTION supplied. Please keyin a valid value then try again.", MsgBoxStyle.Critical, "Error")
            txtPCDesc.Focus()
            Exit Sub
        End If

        If btnPCSave.Text = "Save" Then
            If MsgBox("Save new PREMIUM RATES SETTING information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayChannels(0)
                Call TranPayChannels(4)
                Call LoadDataToComboBox("paychannels", cboBComp.SelectedValue, cboBChannel)
                btnPCCancel.PerformClick()
            End If
        ElseIf btnPCSave.Text = "Update" Then
            If MsgBox("Update PREMIUM RATES SETTING information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranPayChannels(1)
                Call TranPayChannels(4)
                Call LoadDataToComboBox("paychannels", cboBComp.SelectedValue, cboBChannel)
                btnPCCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnPCCancel_Click(sender As Object, e As EventArgs) Handles btnPCCancel.Click
        cboPCComp.SelectedValue = 0
        txtPCCode.Clear()
        txtPCDesc.Clear()
        txtPCCode.Focus()
        SelPayChannelId = 0
        btnPCSave.Text = "Save"
    End Sub

    Private Sub btnBSave_Click(sender As Object, e As EventArgs) Handles btnBSave.Click
        If btnBSave.Text = "Save" Then
            If MsgBox("Save new BANK information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranBanks(0)
                Call TranBanks(4)
                btnPCCancel.PerformClick()
            End If
        ElseIf btnBSave.Text = "Update" Then
            If MsgBox("Update BANK information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Call TranBanks(1)
                Call TranBanks(4)
                btnPCCancel.PerformClick()
            End If
        Else
            ' No conditions have been met.
        End If
    End Sub

    Private Sub btnBCancel_Click(sender As Object, e As EventArgs) Handles btnBCancel.Click
        cboBComp.SelectedValue = 0
        cboBChannel.SelectedValue = 0
        txtBCode.Clear()
        txtBName.Clear()
        txtBCode.Focus()
        btnBSave.Text = "Save"
    End Sub

    Private Sub pnlSSet_Paint(sender As Object, e As PaintEventArgs) Handles pnlSSet.Paint

    End Sub
End Class