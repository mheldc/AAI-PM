<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayrollSetup))
        Me.tcPS = New System.Windows.Forms.TabControl()
        Me.tpTB = New System.Windows.Forms.TabPage()
        Me.tcTB = New System.Windows.Forms.TabControl()
        Me.tpTBET = New System.Windows.Forms.TabPage()
        Me.dgvET = New System.Windows.Forms.DataGridView()
        Me.colETSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colETDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlTBET = New System.Windows.Forms.Panel()
        Me.txtETDesc = New System.Windows.Forms.TextBox()
        Me.lblETDesc = New System.Windows.Forms.Label()
        Me.txtETCode = New System.Windows.Forms.TextBox()
        Me.lblETCode = New System.Windows.Forms.Label()
        Me.btnETCancel = New System.Windows.Forms.Button()
        Me.btnETSave = New System.Windows.Forms.Button()
        Me.tpTBTEB = New System.Windows.Forms.TabPage()
        Me.dgvTEB = New System.Windows.Forms.DataGridView()
        Me.colTEBSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colTEBDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlTBTEB = New System.Windows.Forms.Panel()
        Me.txtTEBPlusEx = New System.Windows.Forms.TextBox()
        Me.txtTEBPlusPCT = New System.Windows.Forms.TextBox()
        Me.lblAppTaxLabel = New System.Windows.Forms.Label()
        Me.txtTEBAT = New System.Windows.Forms.TextBox()
        Me.lblTEBAT = New System.Windows.Forms.Label()
        Me.lblTEBPE = New System.Windows.Forms.Label()
        Me.txtTEBPE = New System.Windows.Forms.TextBox()
        Me.cboTEBPayBasis = New System.Windows.Forms.ComboBox()
        Me.lblTEBET = New System.Windows.Forms.Label()
        Me.cboTEBET = New System.Windows.Forms.ComboBox()
        Me.lblTEBPayBasis = New System.Windows.Forms.Label()
        Me.btnTEBCancel = New System.Windows.Forms.Button()
        Me.btnTEBSave = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.dgvATB = New System.Windows.Forms.DataGridView()
        Me.colATSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colATDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlTBATB = New System.Windows.Forms.Panel()
        Me.txtATBPlusEx = New System.Windows.Forms.TextBox()
        Me.txtATBPlusPct = New System.Windows.Forms.TextBox()
        Me.lblTBPlus = New System.Windows.Forms.Label()
        Me.txtATBAT = New System.Windows.Forms.TextBox()
        Me.lblATBAT = New System.Windows.Forms.Label()
        Me.txtATBBEnd = New System.Windows.Forms.TextBox()
        Me.lblTBTo = New System.Windows.Forms.Label()
        Me.txtATBBStart = New System.Windows.Forms.TextBox()
        Me.lblATBTB = New System.Windows.Forms.Label()
        Me.btnATBCancel = New System.Windows.Forms.Button()
        Me.btnATBSave = New System.Windows.Forms.Button()
        Me.tpSD = New System.Windows.Forms.TabPage()
        Me.tcSD = New System.Windows.Forms.TabControl()
        Me.tpSSS = New System.Windows.Forms.TabPage()
        Me.tcSSetting = New System.Windows.Forms.TabControl()
        Me.tpSSSSettings = New System.Windows.Forms.TabPage()
        Me.dgvSSet = New System.Windows.Forms.DataGridView()
        Me.colSSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colSDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlSSet = New System.Windows.Forms.Panel()
        Me.chkSSRef1ER = New System.Windows.Forms.CheckBox()
        Me.chkSSRef1EE = New System.Windows.Forms.CheckBox()
        Me.lblSSRef1ER = New System.Windows.Forms.Label()
        Me.txtSSRef1ER = New System.Windows.Forms.TextBox()
        Me.lblSSRef1EE = New System.Windows.Forms.Label()
        Me.lblSSetRef = New System.Windows.Forms.Label()
        Me.cboSSetSched = New System.Windows.Forms.ComboBox()
        Me.lblSSetSched = New System.Windows.Forms.Label()
        Me.cboSSetCB = New System.Windows.Forms.ComboBox()
        Me.lblSSetCB = New System.Windows.Forms.Label()
        Me.txtSSRef1EE = New System.Windows.Forms.TextBox()
        Me.rdbSSRef1 = New System.Windows.Forms.RadioButton()
        Me.rdbSSRef0 = New System.Windows.Forms.RadioButton()
        Me.cboSSetComp = New System.Windows.Forms.ComboBox()
        Me.lblSSetComp = New System.Windows.Forms.Label()
        Me.btnSSetCancel = New System.Windows.Forms.Button()
        Me.btnSSetSave = New System.Windows.Forms.Button()
        Me.tpSSSMatrix = New System.Windows.Forms.TabPage()
        Me.dgvSSS = New System.Windows.Forms.DataGridView()
        Me.colSCMSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colSCMDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlSSS = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSCancel = New System.Windows.Forms.Button()
        Me.btnSSave = New System.Windows.Forms.Button()
        Me.txtSEEShare = New System.Windows.Forms.TextBox()
        Me.txtERSPlusAdj = New System.Windows.Forms.TextBox()
        Me.lblSPlus = New System.Windows.Forms.Label()
        Me.txtSERShare = New System.Windows.Forms.TextBox()
        Me.lblSEEShare = New System.Windows.Forms.Label()
        Me.txtSSC = New System.Windows.Forms.TextBox()
        Me.txtSSBEnd = New System.Windows.Forms.TextBox()
        Me.lblSTo = New System.Windows.Forms.Label()
        Me.txtSSBStart = New System.Windows.Forms.TextBox()
        Me.lblSERShare = New System.Windows.Forms.Label()
        Me.lblSSC = New System.Windows.Forms.Label()
        Me.lblSSB = New System.Windows.Forms.Label()
        Me.tpPhilhealth = New System.Windows.Forms.TabPage()
        Me.tcPSetting = New System.Windows.Forms.TabControl()
        Me.TabPage19 = New System.Windows.Forms.TabPage()
        Me.dgvPS = New System.Windows.Forms.DataGridView()
        Me.colPSetSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPSetDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPS = New System.Windows.Forms.Panel()
        Me.chkPSRef1ER = New System.Windows.Forms.CheckBox()
        Me.chkPSRef1EE = New System.Windows.Forms.CheckBox()
        Me.lblPSRef1ER = New System.Windows.Forms.Label()
        Me.txtPSRef1ER = New System.Windows.Forms.TextBox()
        Me.lblPSRef1EE = New System.Windows.Forms.Label()
        Me.lblPSRef = New System.Windows.Forms.Label()
        Me.cboPSSched = New System.Windows.Forms.ComboBox()
        Me.lblPSSched = New System.Windows.Forms.Label()
        Me.cboPSCB = New System.Windows.Forms.ComboBox()
        Me.lblPSCB = New System.Windows.Forms.Label()
        Me.txtPSRef1EE = New System.Windows.Forms.TextBox()
        Me.rdbPSRef1 = New System.Windows.Forms.RadioButton()
        Me.rdbPSRef0 = New System.Windows.Forms.RadioButton()
        Me.cboPSComp = New System.Windows.Forms.ComboBox()
        Me.lblPSComp = New System.Windows.Forms.Label()
        Me.btnPSCancel = New System.Windows.Forms.Button()
        Me.btnPSSave = New System.Windows.Forms.Button()
        Me.TabPage18 = New System.Windows.Forms.TabPage()
        Me.dgvPH = New System.Windows.Forms.DataGridView()
        Me.colPCMSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPCMDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPH = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPHCancel = New System.Windows.Forms.Button()
        Me.btnPHSave = New System.Windows.Forms.Button()
        Me.txtPHERShare = New System.Windows.Forms.TextBox()
        Me.txtPHERPlusAdj = New System.Windows.Forms.TextBox()
        Me.lblPPlus = New System.Windows.Forms.Label()
        Me.txtPHEEShare = New System.Windows.Forms.TextBox()
        Me.lblPHEEShare = New System.Windows.Forms.Label()
        Me.txtPHSC = New System.Windows.Forms.TextBox()
        Me.txtPHSBEnd = New System.Windows.Forms.TextBox()
        Me.lblPTo = New System.Windows.Forms.Label()
        Me.txtPHSBStart = New System.Windows.Forms.TextBox()
        Me.lblPHERShare = New System.Windows.Forms.Label()
        Me.lblPHSC = New System.Windows.Forms.Label()
        Me.lblPHSB = New System.Windows.Forms.Label()
        Me.tpHDMF = New System.Windows.Forms.TabPage()
        Me.tcHSetting = New System.Windows.Forms.TabControl()
        Me.TabPage21 = New System.Windows.Forms.TabPage()
        Me.dgvHS = New System.Windows.Forms.DataGridView()
        Me.colHSetSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colHSetDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlHS = New System.Windows.Forms.Panel()
        Me.chkHSRef1ER = New System.Windows.Forms.CheckBox()
        Me.chkHSRef1EE = New System.Windows.Forms.CheckBox()
        Me.lblHSRef1ER = New System.Windows.Forms.Label()
        Me.txtHSRef1ER = New System.Windows.Forms.TextBox()
        Me.lblHSRef1EE = New System.Windows.Forms.Label()
        Me.lblHSRef = New System.Windows.Forms.Label()
        Me.cboHSSched = New System.Windows.Forms.ComboBox()
        Me.lblHSSched = New System.Windows.Forms.Label()
        Me.cboHSCB = New System.Windows.Forms.ComboBox()
        Me.lblHSCB = New System.Windows.Forms.Label()
        Me.txtHSRef1EE = New System.Windows.Forms.TextBox()
        Me.rdbHSRef1 = New System.Windows.Forms.RadioButton()
        Me.rdbHSRef0 = New System.Windows.Forms.RadioButton()
        Me.cboHSComp = New System.Windows.Forms.ComboBox()
        Me.lblHSComp = New System.Windows.Forms.Label()
        Me.btnHSCancel = New System.Windows.Forms.Button()
        Me.btnHSSave = New System.Windows.Forms.Button()
        Me.TabPage20 = New System.Windows.Forms.TabPage()
        Me.dgvHDMF = New System.Windows.Forms.DataGridView()
        Me.colHDMFSelect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colHDMFDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlHDMF = New System.Windows.Forms.Panel()
        Me.chkHDER = New System.Windows.Forms.CheckBox()
        Me.lblHDCER = New System.Windows.Forms.Label()
        Me.txtHDCER = New System.Windows.Forms.TextBox()
        Me.txtHDERA = New System.Windows.Forms.TextBox()
        Me.lblHDCERA = New System.Windows.Forms.Label()
        Me.txtHDCEE = New System.Windows.Forms.TextBox()
        Me.lblHDCEE = New System.Windows.Forms.Label()
        Me.txtHDSC = New System.Windows.Forms.TextBox()
        Me.txtHDSBEnd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHDSBStart = New System.Windows.Forms.TextBox()
        Me.lblHCC = New System.Windows.Forms.Label()
        Me.lblHSC = New System.Windows.Forms.Label()
        Me.lblHSB = New System.Windows.Forms.Label()
        Me.btnHDMFCancel = New System.Windows.Forms.Button()
        Me.btnHDMFSave = New System.Windows.Forms.Button()
        Me.chkHDEE = New System.Windows.Forms.CheckBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.dgvEC = New System.Windows.Forms.DataGridView()
        Me.colESel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colEDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlEC = New System.Windows.Forms.Panel()
        Me.btnECCancel = New System.Windows.Forms.Button()
        Me.btnECSave = New System.Windows.Forms.Button()
        Me.chkECProRate = New System.Windows.Forms.CheckBox()
        Me.txtECAR = New System.Windows.Forms.TextBox()
        Me.lblECAR = New System.Windows.Forms.Label()
        Me.txtECDesc = New System.Windows.Forms.TextBox()
        Me.lblECDesc = New System.Windows.Forms.Label()
        Me.txtECCode = New System.Windows.Forms.TextBox()
        Me.lblECCode = New System.Windows.Forms.Label()
        Me.cboECComp = New System.Windows.Forms.ComboBox()
        Me.lblECComp = New System.Windows.Forms.Label()
        Me.tpPayParams = New System.Windows.Forms.TabPage()
        Me.tcPayParams = New System.Windows.Forms.TabControl()
        Me.tpPR = New System.Windows.Forms.TabPage()
        Me.dgvPRef = New System.Windows.Forms.DataGridView()
        Me.colPFSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPFDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPRef = New System.Windows.Forms.Panel()
        Me.txtPRDPY = New System.Windows.Forms.TextBox()
        Me.lblPRDPY = New System.Windows.Forms.Label()
        Me.btnPFCancel = New System.Windows.Forms.Button()
        Me.btnPFSave = New System.Windows.Forms.Button()
        Me.txtPRDesc = New System.Windows.Forms.TextBox()
        Me.lblPRDesc = New System.Windows.Forms.Label()
        Me.txtPRCode = New System.Windows.Forms.TextBox()
        Me.lblPRCode = New System.Windows.Forms.Label()
        Me.tpPB = New System.Windows.Forms.TabPage()
        Me.dgvPB = New System.Windows.Forms.DataGridView()
        Me.colPBSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPBDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPB = New System.Windows.Forms.Panel()
        Me.cboPBCycle = New System.Windows.Forms.ComboBox()
        Me.lblPBCycle = New System.Windows.Forms.Label()
        Me.btnPBCancel = New System.Windows.Forms.Button()
        Me.btnPBSave = New System.Windows.Forms.Button()
        Me.txtPBDesc = New System.Windows.Forms.TextBox()
        Me.lblPBDesc = New System.Windows.Forms.Label()
        Me.txtPBCode = New System.Windows.Forms.TextBox()
        Me.lblPBCode = New System.Windows.Forms.Label()
        Me.tpPAT = New System.Windows.Forms.TabPage()
        Me.dgvPA = New System.Windows.Forms.DataGridView()
        Me.colPATSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPATDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPA = New System.Windows.Forms.Panel()
        Me.chkPATaxable = New System.Windows.Forms.CheckBox()
        Me.cboPAComp = New System.Windows.Forms.ComboBox()
        Me.lblPAComp = New System.Windows.Forms.Label()
        Me.btnPACancel = New System.Windows.Forms.Button()
        Me.btnPASave = New System.Windows.Forms.Button()
        Me.txtPADesc = New System.Windows.Forms.TextBox()
        Me.lblPADesc = New System.Windows.Forms.Label()
        Me.txtPACode = New System.Windows.Forms.TextBox()
        Me.lblPACode = New System.Windows.Forms.Label()
        Me.tpPPS = New System.Windows.Forms.TabPage()
        Me.dgvPPS = New System.Windows.Forms.DataGridView()
        Me.colPPSSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPPSDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPPS = New System.Windows.Forms.Panel()
        Me.cboPPEG = New System.Windows.Forms.ComboBox()
        Me.lblPPEG = New System.Windows.Forms.Label()
        Me.cboPPEC = New System.Windows.Forms.ComboBox()
        Me.lblPPEC = New System.Windows.Forms.Label()
        Me.cboPPComp = New System.Windows.Forms.ComboBox()
        Me.lblPPComp = New System.Windows.Forms.Label()
        Me.chkPPNM = New System.Windows.Forms.CheckBox()
        Me.cboPPSequence = New System.Windows.Forms.ComboBox()
        Me.lblPPSequence = New System.Windows.Forms.Label()
        Me.btnPPCancel = New System.Windows.Forms.Button()
        Me.btnPPSave = New System.Windows.Forms.Button()
        Me.txtPPPayDate = New System.Windows.Forms.TextBox()
        Me.lblPPPayDate = New System.Windows.Forms.Label()
        Me.txtPPCovTo = New System.Windows.Forms.TextBox()
        Me.txtPPCovFrom = New System.Windows.Forms.TextBox()
        Me.lblPPCov = New System.Windows.Forms.Label()
        Me.lblPPCoverage = New System.Windows.Forms.Label()
        Me.txtPPDesc = New System.Windows.Forms.TextBox()
        Me.lblPPDesc = New System.Windows.Forms.Label()
        Me.txtPPCode = New System.Windows.Forms.TextBox()
        Me.lblPPCode = New System.Windows.Forms.Label()
        Me.lblPPPDate = New System.Windows.Forms.Label()
        Me.tpPPR = New System.Windows.Forms.TabPage()
        Me.tcRates = New System.Windows.Forms.TabControl()
        Me.tpRateList = New System.Windows.Forms.TabPage()
        Me.dgvPR = New System.Windows.Forms.DataGridView()
        Me.colSRSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colSRDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPR = New System.Windows.Forms.Panel()
        Me.btnPRCancel = New System.Windows.Forms.Button()
        Me.btnPRSave = New System.Windows.Forms.Button()
        Me.lblRSDesc = New System.Windows.Forms.Label()
        Me.txtRSDesc = New System.Windows.Forms.TextBox()
        Me.txtRSCode = New System.Windows.Forms.TextBox()
        Me.lblRSCode = New System.Windows.Forms.Label()
        Me.chkRSSC = New System.Windows.Forms.CheckBox()
        Me.cboRSDept = New System.Windows.Forms.ComboBox()
        Me.lblRSDept = New System.Windows.Forms.Label()
        Me.cboRSPB = New System.Windows.Forms.ComboBox()
        Me.lblRSPB = New System.Windows.Forms.Label()
        Me.cboRSComp = New System.Windows.Forms.ComboBox()
        Me.lblRSComp = New System.Windows.Forms.Label()
        Me.tpRPR = New System.Windows.Forms.TabPage()
        Me.pnlPRStandard = New System.Windows.Forms.Panel()
        Me.btnPRStdCancel = New System.Windows.Forms.Button()
        Me.lblPRCompStd = New System.Windows.Forms.Label()
        Me.btnPRStdSave = New System.Windows.Forms.Button()
        Me.cboPRCompStd = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPRStandard = New System.Windows.Forms.ComboBox()
        Me.lblPRDH = New System.Windows.Forms.Label()
        Me.txtPRDHOTND = New System.Windows.Forms.TextBox()
        Me.txtPRDHND = New System.Windows.Forms.TextBox()
        Me.txtPRDHOT = New System.Windows.Forms.TextBox()
        Me.txtPRDH = New System.Windows.Forms.TextBox()
        Me.lblPRRH = New System.Windows.Forms.Label()
        Me.txtPRRHOTND = New System.Windows.Forms.TextBox()
        Me.txtPRRHND = New System.Windows.Forms.TextBox()
        Me.txtPRRHOT = New System.Windows.Forms.TextBox()
        Me.txtPRRH = New System.Windows.Forms.TextBox()
        Me.lblPRSH = New System.Windows.Forms.Label()
        Me.txtPRSHOTND = New System.Windows.Forms.TextBox()
        Me.txtPRSHND = New System.Windows.Forms.TextBox()
        Me.txtPRSHOT = New System.Windows.Forms.TextBox()
        Me.txtPRSH = New System.Windows.Forms.TextBox()
        Me.lblPRRDDH = New System.Windows.Forms.Label()
        Me.txtPRRDDHOTND = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHND = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHOT = New System.Windows.Forms.TextBox()
        Me.txtPRRDDH = New System.Windows.Forms.TextBox()
        Me.lblPRRDRH = New System.Windows.Forms.Label()
        Me.txtPRRDRHOTND = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHND = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHOT = New System.Windows.Forms.TextBox()
        Me.txtPRRDRH = New System.Windows.Forms.TextBox()
        Me.lblPRRDSH = New System.Windows.Forms.Label()
        Me.txtPRRDSHOTND = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHND = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHOT = New System.Windows.Forms.TextBox()
        Me.txtPRRDSH = New System.Windows.Forms.TextBox()
        Me.lblPRRD = New System.Windows.Forms.Label()
        Me.txtPRRDOTND = New System.Windows.Forms.TextBox()
        Me.txtPRRDND = New System.Windows.Forms.TextBox()
        Me.txtPRRDOT = New System.Windows.Forms.TextBox()
        Me.txtPRRD = New System.Windows.Forms.TextBox()
        Me.txtPRRegOTND = New System.Windows.Forms.TextBox()
        Me.txtPRRegND = New System.Windows.Forms.TextBox()
        Me.txtPRRegOT = New System.Windows.Forms.TextBox()
        Me.txtPRReg = New System.Windows.Forms.TextBox()
        Me.lblRegOTNS = New System.Windows.Forms.Label()
        Me.lblRegNS = New System.Windows.Forms.Label()
        Me.lblRegOT = New System.Windows.Forms.Label()
        Me.lblRegBR = New System.Windows.Forms.Label()
        Me.lblPRReg = New System.Windows.Forms.Label()
        Me.tpSPC = New System.Windows.Forms.TabPage()
        Me.lblPRS4A = New System.Windows.Forms.Label()
        Me.lblPRS3A = New System.Windows.Forms.Label()
        Me.lblPRS2A = New System.Windows.Forms.Label()
        Me.lblPRS1A = New System.Windows.Forms.Label()
        Me.pnlPRCustom = New System.Windows.Forms.Panel()
        Me.btnPRCusCancel = New System.Windows.Forms.Button()
        Me.btnPRCusSave = New System.Windows.Forms.Button()
        Me.lblPRCompCus = New System.Windows.Forms.Label()
        Me.cboPRCompCus = New System.Windows.Forms.ComboBox()
        Me.lblPRCustom = New System.Windows.Forms.Label()
        Me.cboPRCustom = New System.Windows.Forms.ComboBox()
        Me.lblPRS4 = New System.Windows.Forms.Label()
        Me.lblPRS3 = New System.Windows.Forms.Label()
        Me.lblPRS2 = New System.Windows.Forms.Label()
        Me.lblPRS1 = New System.Windows.Forms.Label()
        Me.txtPRDHOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRHOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRSHOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRegOTNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRDHNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRHNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRSHNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRRegNS1 = New System.Windows.Forms.TextBox()
        Me.txtPRDHOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRRHOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRSHOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRRegOT1 = New System.Windows.Forms.TextBox()
        Me.txtPRDH1 = New System.Windows.Forms.TextBox()
        Me.txtPRRH1 = New System.Windows.Forms.TextBox()
        Me.txtPRSH1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDH1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRH1 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSH1 = New System.Windows.Forms.TextBox()
        Me.txtPRRD1 = New System.Windows.Forms.TextBox()
        Me.txtPRReg1 = New System.Windows.Forms.TextBox()
        Me.lblPRSDH = New System.Windows.Forms.Label()
        Me.txtPRDHOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRDHNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRDHOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRDH0 = New System.Windows.Forms.TextBox()
        Me.lblPRSRH = New System.Windows.Forms.Label()
        Me.txtPRRHOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRHNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRHOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRRH0 = New System.Windows.Forms.TextBox()
        Me.lblPRSSH = New System.Windows.Forms.Label()
        Me.txtPRSHOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRSHNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRSHOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRSH0 = New System.Windows.Forms.TextBox()
        Me.lblPRSRDDH = New System.Windows.Forms.Label()
        Me.txtPRRDDHOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDHOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDDH0 = New System.Windows.Forms.TextBox()
        Me.lblPRSRDRH = New System.Windows.Forms.Label()
        Me.txtPRRDRHOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRHOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDRH0 = New System.Windows.Forms.TextBox()
        Me.lblPRSRDSH = New System.Windows.Forms.Label()
        Me.txtPRRDSHOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSHOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDSH0 = New System.Windows.Forms.TextBox()
        Me.lblPRSRD = New System.Windows.Forms.Label()
        Me.txtPRRDOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRDOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRRD0 = New System.Windows.Forms.TextBox()
        Me.txtPRRegOTNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRegNS0 = New System.Windows.Forms.TextBox()
        Me.txtPRRegOT0 = New System.Windows.Forms.TextBox()
        Me.txtPRReg0 = New System.Windows.Forms.TextBox()
        Me.lblPRSOTNS = New System.Windows.Forms.Label()
        Me.lblPRSNS = New System.Windows.Forms.Label()
        Me.lblPRSPOT = New System.Windows.Forms.Label()
        Me.lblPRSBR = New System.Windows.Forms.Label()
        Me.lblPRSReg = New System.Windows.Forms.Label()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.tcPSet = New System.Windows.Forms.TabControl()
        Me.tpPayChannels = New System.Windows.Forms.TabPage()
        Me.dgvPC = New System.Windows.Forms.DataGridView()
        Me.colPCSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPCDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPC = New System.Windows.Forms.Panel()
        Me.btnPCCancel = New System.Windows.Forms.Button()
        Me.btnPCSave = New System.Windows.Forms.Button()
        Me.cboPCComp = New System.Windows.Forms.ComboBox()
        Me.lblPCComp = New System.Windows.Forms.Label()
        Me.txtPCDesc = New System.Windows.Forms.TextBox()
        Me.lblPCDesc = New System.Windows.Forms.Label()
        Me.txtPCCode = New System.Windows.Forms.TextBox()
        Me.lblPCCode = New System.Windows.Forms.Label()
        Me.tpBanks = New System.Windows.Forms.TabPage()
        Me.dgvBanks = New System.Windows.Forms.DataGridView()
        Me.colBSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colBDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlBS = New System.Windows.Forms.Panel()
        Me.cboBChannel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBCancel = New System.Windows.Forms.Button()
        Me.btnBSave = New System.Windows.Forms.Button()
        Me.cboBComp = New System.Windows.Forms.ComboBox()
        Me.lblBComp = New System.Windows.Forms.Label()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.lblBName = New System.Windows.Forms.Label()
        Me.txtBCode = New System.Windows.Forms.TextBox()
        Me.lblBCode = New System.Windows.Forms.Label()
        Me.tpPProc = New System.Windows.Forms.TabPage()
        Me.dgvPPR = New System.Windows.Forms.DataGridView()
        Me.colPPRSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colPPRDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPPR = New System.Windows.Forms.Panel()
        Me.cboPPRComp = New System.Windows.Forms.ComboBox()
        Me.lblPPRComp = New System.Windows.Forms.Label()
        Me.btnPPRCancel = New System.Windows.Forms.Button()
        Me.btnPPRSave = New System.Windows.Forms.Button()
        Me.cboPPProc = New System.Windows.Forms.ComboBox()
        Me.lblPPProc = New System.Windows.Forms.Label()
        Me.cboPPREG = New System.Windows.Forms.ComboBox()
        Me.cboPPREC = New System.Windows.Forms.ComboBox()
        Me.lblPPREG = New System.Windows.Forms.Label()
        Me.lblPPREC = New System.Windows.Forms.Label()
        Me.lblPRB = New System.Windows.Forms.Label()
        Me.cboPRB = New System.Windows.Forms.ComboBox()
        Me.tcPS.SuspendLayout()
        Me.tpTB.SuspendLayout()
        Me.tcTB.SuspendLayout()
        Me.tpTBET.SuspendLayout()
        CType(Me.dgvET, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTBET.SuspendLayout()
        Me.tpTBTEB.SuspendLayout()
        CType(Me.dgvTEB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTBTEB.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.dgvATB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTBATB.SuspendLayout()
        Me.tpSD.SuspendLayout()
        Me.tcSD.SuspendLayout()
        Me.tpSSS.SuspendLayout()
        Me.tcSSetting.SuspendLayout()
        Me.tpSSSSettings.SuspendLayout()
        CType(Me.dgvSSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSSet.SuspendLayout()
        Me.tpSSSMatrix.SuspendLayout()
        CType(Me.dgvSSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSSS.SuspendLayout()
        Me.tpPhilhealth.SuspendLayout()
        Me.tcPSetting.SuspendLayout()
        Me.TabPage19.SuspendLayout()
        CType(Me.dgvPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPS.SuspendLayout()
        Me.TabPage18.SuspendLayout()
        CType(Me.dgvPH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPH.SuspendLayout()
        Me.tpHDMF.SuspendLayout()
        Me.tcHSetting.SuspendLayout()
        Me.TabPage21.SuspendLayout()
        CType(Me.dgvHS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHS.SuspendLayout()
        Me.TabPage20.SuspendLayout()
        CType(Me.dgvHDMF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHDMF.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.dgvEC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEC.SuspendLayout()
        Me.tpPayParams.SuspendLayout()
        Me.tcPayParams.SuspendLayout()
        Me.tpPR.SuspendLayout()
        CType(Me.dgvPRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPRef.SuspendLayout()
        Me.tpPB.SuspendLayout()
        CType(Me.dgvPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPB.SuspendLayout()
        Me.tpPAT.SuspendLayout()
        CType(Me.dgvPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPA.SuspendLayout()
        Me.tpPPS.SuspendLayout()
        CType(Me.dgvPPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPPS.SuspendLayout()
        Me.tpPPR.SuspendLayout()
        Me.tcRates.SuspendLayout()
        Me.tpRateList.SuspendLayout()
        CType(Me.dgvPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPR.SuspendLayout()
        Me.tpRPR.SuspendLayout()
        Me.pnlPRStandard.SuspendLayout()
        Me.tpSPC.SuspendLayout()
        Me.pnlPRCustom.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        Me.tcPSet.SuspendLayout()
        Me.tpPayChannels.SuspendLayout()
        CType(Me.dgvPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPC.SuspendLayout()
        Me.tpBanks.SuspendLayout()
        CType(Me.dgvBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBS.SuspendLayout()
        Me.tpPProc.SuspendLayout()
        CType(Me.dgvPPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPPR.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcPS
        '
        Me.tcPS.Controls.Add(Me.tpTB)
        Me.tcPS.Controls.Add(Me.tpSD)
        Me.tcPS.Controls.Add(Me.TabPage9)
        Me.tcPS.Controls.Add(Me.tpPayParams)
        Me.tcPS.Controls.Add(Me.TabPage15)
        Me.tcPS.Controls.Add(Me.tpPProc)
        Me.tcPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPS.Location = New System.Drawing.Point(0, 0)
        Me.tcPS.Name = "tcPS"
        Me.tcPS.SelectedIndex = 0
        Me.tcPS.Size = New System.Drawing.Size(934, 521)
        Me.tcPS.TabIndex = 0
        '
        'tpTB
        '
        Me.tpTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpTB.Controls.Add(Me.tcTB)
        Me.tpTB.Location = New System.Drawing.Point(4, 23)
        Me.tpTB.Name = "tpTB"
        Me.tpTB.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTB.Size = New System.Drawing.Size(926, 494)
        Me.tpTB.TabIndex = 0
        Me.tpTB.Text = "Tax Bracket"
        Me.tpTB.UseVisualStyleBackColor = True
        '
        'tcTB
        '
        Me.tcTB.Controls.Add(Me.tpTBET)
        Me.tcTB.Controls.Add(Me.tpTBTEB)
        Me.tcTB.Controls.Add(Me.TabPage8)
        Me.tcTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTB.Location = New System.Drawing.Point(3, 3)
        Me.tcTB.Name = "tcTB"
        Me.tcTB.SelectedIndex = 0
        Me.tcTB.Size = New System.Drawing.Size(918, 486)
        Me.tcTB.TabIndex = 1
        '
        'tpTBET
        '
        Me.tpTBET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpTBET.Controls.Add(Me.dgvET)
        Me.tpTBET.Controls.Add(Me.pnlTBET)
        Me.tpTBET.Location = New System.Drawing.Point(4, 23)
        Me.tpTBET.Name = "tpTBET"
        Me.tpTBET.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTBET.Size = New System.Drawing.Size(910, 459)
        Me.tpTBET.TabIndex = 0
        Me.tpTBET.Text = "Exemption Types"
        Me.tpTBET.UseVisualStyleBackColor = True
        '
        'dgvET
        '
        Me.dgvET.AllowUserToAddRows = False
        Me.dgvET.AllowUserToDeleteRows = False
        Me.dgvET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvET.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colETSel, Me.colETDel})
        Me.dgvET.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvET.Location = New System.Drawing.Point(3, 107)
        Me.dgvET.Name = "dgvET"
        Me.dgvET.ReadOnly = True
        Me.dgvET.Size = New System.Drawing.Size(902, 347)
        Me.dgvET.TabIndex = 6
        '
        'colETSel
        '
        Me.colETSel.Frozen = True
        Me.colETSel.HeaderText = ""
        Me.colETSel.Name = "colETSel"
        Me.colETSel.ReadOnly = True
        Me.colETSel.Text = "Select"
        Me.colETSel.UseColumnTextForButtonValue = True
        Me.colETSel.Width = 60
        '
        'colETDel
        '
        Me.colETDel.Frozen = True
        Me.colETDel.HeaderText = ""
        Me.colETDel.Name = "colETDel"
        Me.colETDel.ReadOnly = True
        Me.colETDel.Text = "Remove"
        Me.colETDel.UseColumnTextForButtonValue = True
        Me.colETDel.Width = 60
        '
        'pnlTBET
        '
        Me.pnlTBET.Controls.Add(Me.txtETDesc)
        Me.pnlTBET.Controls.Add(Me.lblETDesc)
        Me.pnlTBET.Controls.Add(Me.txtETCode)
        Me.pnlTBET.Controls.Add(Me.lblETCode)
        Me.pnlTBET.Controls.Add(Me.btnETCancel)
        Me.pnlTBET.Controls.Add(Me.btnETSave)
        Me.pnlTBET.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTBET.Location = New System.Drawing.Point(3, 3)
        Me.pnlTBET.Name = "pnlTBET"
        Me.pnlTBET.Size = New System.Drawing.Size(902, 104)
        Me.pnlTBET.TabIndex = 5
        '
        'txtETDesc
        '
        Me.txtETDesc.Location = New System.Drawing.Point(120, 33)
        Me.txtETDesc.MaxLength = 150
        Me.txtETDesc.Name = "txtETDesc"
        Me.txtETDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtETDesc.TabIndex = 22
        '
        'lblETDesc
        '
        Me.lblETDesc.AutoSize = True
        Me.lblETDesc.Location = New System.Drawing.Point(7, 36)
        Me.lblETDesc.Name = "lblETDesc"
        Me.lblETDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblETDesc.TabIndex = 21
        Me.lblETDesc.Text = "Description"
        '
        'txtETCode
        '
        Me.txtETCode.Location = New System.Drawing.Point(120, 9)
        Me.txtETCode.MaxLength = 25
        Me.txtETCode.Name = "txtETCode"
        Me.txtETCode.Size = New System.Drawing.Size(160, 22)
        Me.txtETCode.TabIndex = 20
        '
        'lblETCode
        '
        Me.lblETCode.AutoSize = True
        Me.lblETCode.Location = New System.Drawing.Point(7, 12)
        Me.lblETCode.Name = "lblETCode"
        Me.lblETCode.Size = New System.Drawing.Size(61, 14)
        Me.lblETCode.TabIndex = 19
        Me.lblETCode.Text = "Type Code"
        '
        'btnETCancel
        '
        Me.btnETCancel.Image = CType(resources.GetObject("btnETCancel.Image"), System.Drawing.Image)
        Me.btnETCancel.Location = New System.Drawing.Point(198, 61)
        Me.btnETCancel.Name = "btnETCancel"
        Me.btnETCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnETCancel.TabIndex = 16
        Me.btnETCancel.Text = "Cancel"
        Me.btnETCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnETCancel.UseVisualStyleBackColor = True
        '
        'btnETSave
        '
        Me.btnETSave.Image = CType(resources.GetObject("btnETSave.Image"), System.Drawing.Image)
        Me.btnETSave.Location = New System.Drawing.Point(120, 61)
        Me.btnETSave.Name = "btnETSave"
        Me.btnETSave.Size = New System.Drawing.Size(77, 29)
        Me.btnETSave.TabIndex = 15
        Me.btnETSave.Text = "Save"
        Me.btnETSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnETSave.UseVisualStyleBackColor = True
        '
        'tpTBTEB
        '
        Me.tpTBTEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpTBTEB.Controls.Add(Me.dgvTEB)
        Me.tpTBTEB.Controls.Add(Me.pnlTBTEB)
        Me.tpTBTEB.Location = New System.Drawing.Point(4, 23)
        Me.tpTBTEB.Name = "tpTBTEB"
        Me.tpTBTEB.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTBTEB.Size = New System.Drawing.Size(910, 459)
        Me.tpTBTEB.TabIndex = 1
        Me.tpTBTEB.Text = "Tax Exemption Bracket"
        Me.tpTBTEB.UseVisualStyleBackColor = True
        '
        'dgvTEB
        '
        Me.dgvTEB.AllowUserToAddRows = False
        Me.dgvTEB.AllowUserToDeleteRows = False
        Me.dgvTEB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTEB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTEBSel, Me.colTEBDel})
        Me.dgvTEB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTEB.Location = New System.Drawing.Point(3, 158)
        Me.dgvTEB.Name = "dgvTEB"
        Me.dgvTEB.ReadOnly = True
        Me.dgvTEB.Size = New System.Drawing.Size(902, 296)
        Me.dgvTEB.TabIndex = 6
        '
        'colTEBSel
        '
        Me.colTEBSel.Frozen = True
        Me.colTEBSel.HeaderText = ""
        Me.colTEBSel.Name = "colTEBSel"
        Me.colTEBSel.ReadOnly = True
        Me.colTEBSel.Text = "Select"
        Me.colTEBSel.UseColumnTextForButtonValue = True
        Me.colTEBSel.Width = 60
        '
        'colTEBDel
        '
        Me.colTEBDel.Frozen = True
        Me.colTEBDel.HeaderText = ""
        Me.colTEBDel.Name = "colTEBDel"
        Me.colTEBDel.ReadOnly = True
        Me.colTEBDel.Text = "Remove"
        Me.colTEBDel.UseColumnTextForButtonValue = True
        Me.colTEBDel.Width = 60
        '
        'pnlTBTEB
        '
        Me.pnlTBTEB.Controls.Add(Me.txtTEBPlusEx)
        Me.pnlTBTEB.Controls.Add(Me.txtTEBPlusPCT)
        Me.pnlTBTEB.Controls.Add(Me.lblAppTaxLabel)
        Me.pnlTBTEB.Controls.Add(Me.txtTEBAT)
        Me.pnlTBTEB.Controls.Add(Me.lblTEBAT)
        Me.pnlTBTEB.Controls.Add(Me.lblTEBPE)
        Me.pnlTBTEB.Controls.Add(Me.txtTEBPE)
        Me.pnlTBTEB.Controls.Add(Me.cboTEBPayBasis)
        Me.pnlTBTEB.Controls.Add(Me.lblTEBET)
        Me.pnlTBTEB.Controls.Add(Me.cboTEBET)
        Me.pnlTBTEB.Controls.Add(Me.lblTEBPayBasis)
        Me.pnlTBTEB.Controls.Add(Me.btnTEBCancel)
        Me.pnlTBTEB.Controls.Add(Me.btnTEBSave)
        Me.pnlTBTEB.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTBTEB.Location = New System.Drawing.Point(3, 3)
        Me.pnlTBTEB.Name = "pnlTBTEB"
        Me.pnlTBTEB.Size = New System.Drawing.Size(902, 155)
        Me.pnlTBTEB.TabIndex = 5
        '
        'txtTEBPlusEx
        '
        Me.txtTEBPlusEx.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEBPlusEx.Location = New System.Drawing.Point(427, 81)
        Me.txtTEBPlusEx.MaxLength = 25
        Me.txtTEBPlusEx.Name = "txtTEBPlusEx"
        Me.txtTEBPlusEx.Size = New System.Drawing.Size(100, 22)
        Me.txtTEBPlusEx.TabIndex = 29
        Me.txtTEBPlusEx.Text = "0.00"
        Me.txtTEBPlusEx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTEBPlusPCT
        '
        Me.txtTEBPlusPCT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEBPlusPCT.Location = New System.Drawing.Point(287, 81)
        Me.txtTEBPlusPCT.MaxLength = 10
        Me.txtTEBPlusPCT.Name = "txtTEBPlusPCT"
        Me.txtTEBPlusPCT.Size = New System.Drawing.Size(50, 22)
        Me.txtTEBPlusPCT.TabIndex = 28
        Me.txtTEBPlusPCT.Text = "0.00"
        Me.txtTEBPlusPCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAppTaxLabel
        '
        Me.lblAppTaxLabel.AutoSize = True
        Me.lblAppTaxLabel.Location = New System.Drawing.Point(256, 84)
        Me.lblAppTaxLabel.Name = "lblAppTaxLabel"
        Me.lblAppTaxLabel.Size = New System.Drawing.Size(167, 14)
        Me.lblAppTaxLabel.TabIndex = 27
        Me.lblAppTaxLabel.Text = "plus                    % in excess of"
        '
        'txtTEBAT
        '
        Me.txtTEBAT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEBAT.Location = New System.Drawing.Point(150, 81)
        Me.txtTEBAT.MaxLength = 25
        Me.txtTEBAT.Name = "txtTEBAT"
        Me.txtTEBAT.Size = New System.Drawing.Size(100, 22)
        Me.txtTEBAT.TabIndex = 26
        Me.txtTEBAT.Text = "0.00"
        Me.txtTEBAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTEBAT
        '
        Me.lblTEBAT.AutoSize = True
        Me.lblTEBAT.Location = New System.Drawing.Point(7, 84)
        Me.lblTEBAT.Name = "lblTEBAT"
        Me.lblTEBAT.Size = New System.Drawing.Size(70, 14)
        Me.lblTEBAT.TabIndex = 25
        Me.lblTEBAT.Text = "Applied Tax"
        '
        'lblTEBPE
        '
        Me.lblTEBPE.AutoSize = True
        Me.lblTEBPE.Location = New System.Drawing.Point(7, 60)
        Me.lblTEBPE.Name = "lblTEBPE"
        Me.lblTEBPE.Size = New System.Drawing.Size(114, 14)
        Me.lblTEBPE.TabIndex = 24
        Me.lblTEBPE.Text = "Personal Exemption"
        '
        'txtTEBPE
        '
        Me.txtTEBPE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEBPE.Location = New System.Drawing.Point(150, 57)
        Me.txtTEBPE.MaxLength = 25
        Me.txtTEBPE.Name = "txtTEBPE"
        Me.txtTEBPE.Size = New System.Drawing.Size(100, 22)
        Me.txtTEBPE.TabIndex = 23
        Me.txtTEBPE.Text = "0.00"
        Me.txtTEBPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTEBPayBasis
        '
        Me.cboTEBPayBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTEBPayBasis.FormattingEnabled = True
        Me.cboTEBPayBasis.Location = New System.Drawing.Point(150, 9)
        Me.cboTEBPayBasis.Name = "cboTEBPayBasis"
        Me.cboTEBPayBasis.Size = New System.Drawing.Size(350, 22)
        Me.cboTEBPayBasis.TabIndex = 22
        '
        'lblTEBET
        '
        Me.lblTEBET.AutoSize = True
        Me.lblTEBET.Location = New System.Drawing.Point(7, 36)
        Me.lblTEBET.Name = "lblTEBET"
        Me.lblTEBET.Size = New System.Drawing.Size(90, 14)
        Me.lblTEBET.TabIndex = 21
        Me.lblTEBET.Text = "Exemption Type"
        '
        'cboTEBET
        '
        Me.cboTEBET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTEBET.FormattingEnabled = True
        Me.cboTEBET.Location = New System.Drawing.Point(150, 33)
        Me.cboTEBET.Name = "cboTEBET"
        Me.cboTEBET.Size = New System.Drawing.Size(350, 22)
        Me.cboTEBET.TabIndex = 20
        '
        'lblTEBPayBasis
        '
        Me.lblTEBPayBasis.AutoSize = True
        Me.lblTEBPayBasis.Location = New System.Drawing.Point(7, 12)
        Me.lblTEBPayBasis.Name = "lblTEBPayBasis"
        Me.lblTEBPayBasis.Size = New System.Drawing.Size(58, 14)
        Me.lblTEBPayBasis.TabIndex = 19
        Me.lblTEBPayBasis.Text = "Pay Basis"
        '
        'btnTEBCancel
        '
        Me.btnTEBCancel.Image = CType(resources.GetObject("btnTEBCancel.Image"), System.Drawing.Image)
        Me.btnTEBCancel.Location = New System.Drawing.Point(228, 109)
        Me.btnTEBCancel.Name = "btnTEBCancel"
        Me.btnTEBCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnTEBCancel.TabIndex = 16
        Me.btnTEBCancel.Text = "Cancel"
        Me.btnTEBCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTEBCancel.UseVisualStyleBackColor = True
        '
        'btnTEBSave
        '
        Me.btnTEBSave.Image = CType(resources.GetObject("btnTEBSave.Image"), System.Drawing.Image)
        Me.btnTEBSave.Location = New System.Drawing.Point(150, 109)
        Me.btnTEBSave.Name = "btnTEBSave"
        Me.btnTEBSave.Size = New System.Drawing.Size(77, 29)
        Me.btnTEBSave.TabIndex = 15
        Me.btnTEBSave.Text = "Save"
        Me.btnTEBSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTEBSave.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.dgvATB)
        Me.TabPage8.Controls.Add(Me.pnlTBATB)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(910, 459)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "Annualized Tax Bracket"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'dgvATB
        '
        Me.dgvATB.AllowUserToAddRows = False
        Me.dgvATB.AllowUserToDeleteRows = False
        Me.dgvATB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvATB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colATSel, Me.colATDel})
        Me.dgvATB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvATB.Location = New System.Drawing.Point(3, 107)
        Me.dgvATB.Name = "dgvATB"
        Me.dgvATB.ReadOnly = True
        Me.dgvATB.Size = New System.Drawing.Size(902, 347)
        Me.dgvATB.TabIndex = 6
        '
        'colATSel
        '
        Me.colATSel.Frozen = True
        Me.colATSel.HeaderText = ""
        Me.colATSel.Name = "colATSel"
        Me.colATSel.ReadOnly = True
        Me.colATSel.Text = "Select"
        Me.colATSel.UseColumnTextForButtonValue = True
        Me.colATSel.Width = 60
        '
        'colATDel
        '
        Me.colATDel.Frozen = True
        Me.colATDel.HeaderText = ""
        Me.colATDel.Name = "colATDel"
        Me.colATDel.ReadOnly = True
        Me.colATDel.Text = "Remove"
        Me.colATDel.UseColumnTextForButtonValue = True
        Me.colATDel.Width = 60
        '
        'pnlTBATB
        '
        Me.pnlTBATB.Controls.Add(Me.txtATBPlusEx)
        Me.pnlTBATB.Controls.Add(Me.txtATBPlusPct)
        Me.pnlTBATB.Controls.Add(Me.lblTBPlus)
        Me.pnlTBATB.Controls.Add(Me.txtATBAT)
        Me.pnlTBATB.Controls.Add(Me.lblATBAT)
        Me.pnlTBATB.Controls.Add(Me.txtATBBEnd)
        Me.pnlTBATB.Controls.Add(Me.lblTBTo)
        Me.pnlTBATB.Controls.Add(Me.txtATBBStart)
        Me.pnlTBATB.Controls.Add(Me.lblATBTB)
        Me.pnlTBATB.Controls.Add(Me.btnATBCancel)
        Me.pnlTBATB.Controls.Add(Me.btnATBSave)
        Me.pnlTBATB.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTBATB.Location = New System.Drawing.Point(3, 3)
        Me.pnlTBATB.Name = "pnlTBATB"
        Me.pnlTBATB.Size = New System.Drawing.Size(902, 104)
        Me.pnlTBATB.TabIndex = 5
        '
        'txtATBPlusEx
        '
        Me.txtATBPlusEx.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATBPlusEx.Location = New System.Drawing.Point(411, 33)
        Me.txtATBPlusEx.MaxLength = 25
        Me.txtATBPlusEx.Name = "txtATBPlusEx"
        Me.txtATBPlusEx.Size = New System.Drawing.Size(100, 22)
        Me.txtATBPlusEx.TabIndex = 25
        Me.txtATBPlusEx.Text = "0.00"
        Me.txtATBPlusEx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtATBPlusPct
        '
        Me.txtATBPlusPct.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATBPlusPct.Location = New System.Drawing.Point(270, 33)
        Me.txtATBPlusPct.MaxLength = 10
        Me.txtATBPlusPct.Name = "txtATBPlusPct"
        Me.txtATBPlusPct.Size = New System.Drawing.Size(51, 22)
        Me.txtATBPlusPct.TabIndex = 24
        Me.txtATBPlusPct.Text = "0.00"
        Me.txtATBPlusPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTBPlus
        '
        Me.lblTBPlus.AutoSize = True
        Me.lblTBPlus.Location = New System.Drawing.Point(236, 36)
        Me.lblTBPlus.Name = "lblTBPlus"
        Me.lblTBPlus.Size = New System.Drawing.Size(173, 14)
        Me.lblTBPlus.TabIndex = 23
        Me.lblTBPlus.Text = "plus                     % in excess of "
        '
        'txtATBAT
        '
        Me.txtATBAT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATBAT.Location = New System.Drawing.Point(130, 33)
        Me.txtATBAT.MaxLength = 25
        Me.txtATBAT.Name = "txtATBAT"
        Me.txtATBAT.Size = New System.Drawing.Size(100, 22)
        Me.txtATBAT.TabIndex = 22
        Me.txtATBAT.Text = "0.00"
        Me.txtATBAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblATBAT
        '
        Me.lblATBAT.AutoSize = True
        Me.lblATBAT.Location = New System.Drawing.Point(7, 36)
        Me.lblATBAT.Name = "lblATBAT"
        Me.lblATBAT.Size = New System.Drawing.Size(70, 14)
        Me.lblATBAT.TabIndex = 21
        Me.lblATBAT.Text = "Applied Tax"
        '
        'txtATBBEnd
        '
        Me.txtATBBEnd.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATBBEnd.Location = New System.Drawing.Point(260, 9)
        Me.txtATBBEnd.MaxLength = 25
        Me.txtATBBEnd.Name = "txtATBBEnd"
        Me.txtATBBEnd.Size = New System.Drawing.Size(100, 22)
        Me.txtATBBEnd.TabIndex = 20
        Me.txtATBBEnd.Text = "0.00"
        Me.txtATBBEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTBTo
        '
        Me.lblTBTo.AutoSize = True
        Me.lblTBTo.Location = New System.Drawing.Point(236, 12)
        Me.lblTBTo.Name = "lblTBTo"
        Me.lblTBTo.Size = New System.Drawing.Size(18, 14)
        Me.lblTBTo.TabIndex = 19
        Me.lblTBTo.Text = "to"
        '
        'txtATBBStart
        '
        Me.txtATBBStart.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATBBStart.Location = New System.Drawing.Point(130, 9)
        Me.txtATBBStart.MaxLength = 25
        Me.txtATBBStart.Name = "txtATBBStart"
        Me.txtATBBStart.Size = New System.Drawing.Size(100, 22)
        Me.txtATBBStart.TabIndex = 18
        Me.txtATBBStart.Text = "0.00"
        Me.txtATBBStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblATBTB
        '
        Me.lblATBTB.AutoSize = True
        Me.lblATBTB.Location = New System.Drawing.Point(7, 12)
        Me.lblATBTB.Name = "lblATBTB"
        Me.lblATBTB.Size = New System.Drawing.Size(67, 14)
        Me.lblATBTB.TabIndex = 17
        Me.lblATBTB.Text = "Tax Bracket"
        '
        'btnATBCancel
        '
        Me.btnATBCancel.Image = CType(resources.GetObject("btnATBCancel.Image"), System.Drawing.Image)
        Me.btnATBCancel.Location = New System.Drawing.Point(208, 61)
        Me.btnATBCancel.Name = "btnATBCancel"
        Me.btnATBCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnATBCancel.TabIndex = 16
        Me.btnATBCancel.Text = "Cancel"
        Me.btnATBCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnATBCancel.UseVisualStyleBackColor = True
        '
        'btnATBSave
        '
        Me.btnATBSave.Image = CType(resources.GetObject("btnATBSave.Image"), System.Drawing.Image)
        Me.btnATBSave.Location = New System.Drawing.Point(130, 61)
        Me.btnATBSave.Name = "btnATBSave"
        Me.btnATBSave.Size = New System.Drawing.Size(77, 29)
        Me.btnATBSave.TabIndex = 15
        Me.btnATBSave.Text = "Save"
        Me.btnATBSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnATBSave.UseVisualStyleBackColor = True
        '
        'tpSD
        '
        Me.tpSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSD.Controls.Add(Me.tcSD)
        Me.tpSD.Location = New System.Drawing.Point(4, 23)
        Me.tpSD.Name = "tpSD"
        Me.tpSD.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSD.Size = New System.Drawing.Size(926, 494)
        Me.tpSD.TabIndex = 1
        Me.tpSD.Text = "Statutory Dues"
        Me.tpSD.UseVisualStyleBackColor = True
        '
        'tcSD
        '
        Me.tcSD.Controls.Add(Me.tpSSS)
        Me.tcSD.Controls.Add(Me.tpPhilhealth)
        Me.tcSD.Controls.Add(Me.tpHDMF)
        Me.tcSD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSD.Location = New System.Drawing.Point(3, 3)
        Me.tcSD.Name = "tcSD"
        Me.tcSD.SelectedIndex = 0
        Me.tcSD.Size = New System.Drawing.Size(918, 486)
        Me.tcSD.TabIndex = 0
        '
        'tpSSS
        '
        Me.tpSSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSSS.Controls.Add(Me.tcSSetting)
        Me.tpSSS.Location = New System.Drawing.Point(4, 23)
        Me.tpSSS.Name = "tpSSS"
        Me.tpSSS.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSSS.Size = New System.Drawing.Size(910, 459)
        Me.tpSSS.TabIndex = 0
        Me.tpSSS.Text = "SSS "
        Me.tpSSS.UseVisualStyleBackColor = True
        '
        'tcSSetting
        '
        Me.tcSSetting.Controls.Add(Me.tpSSSSettings)
        Me.tcSSetting.Controls.Add(Me.tpSSSMatrix)
        Me.tcSSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSSetting.Location = New System.Drawing.Point(3, 3)
        Me.tcSSetting.Name = "tcSSetting"
        Me.tcSSetting.SelectedIndex = 0
        Me.tcSSetting.Size = New System.Drawing.Size(902, 451)
        Me.tcSSetting.TabIndex = 0
        '
        'tpSSSSettings
        '
        Me.tpSSSSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSSSSettings.Controls.Add(Me.dgvSSet)
        Me.tpSSSSettings.Controls.Add(Me.pnlSSet)
        Me.tpSSSSettings.Location = New System.Drawing.Point(4, 23)
        Me.tpSSSSettings.Name = "tpSSSSettings"
        Me.tpSSSSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSSSSettings.Size = New System.Drawing.Size(894, 424)
        Me.tpSSSSettings.TabIndex = 1
        Me.tpSSSSettings.Text = "Setting"
        Me.tpSSSSettings.UseVisualStyleBackColor = True
        '
        'dgvSSet
        '
        Me.dgvSSet.AllowUserToAddRows = False
        Me.dgvSSet.AllowUserToDeleteRows = False
        Me.dgvSSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSSel, Me.colSDel})
        Me.dgvSSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSSet.Location = New System.Drawing.Point(3, 205)
        Me.dgvSSet.Name = "dgvSSet"
        Me.dgvSSet.ReadOnly = True
        Me.dgvSSet.Size = New System.Drawing.Size(886, 214)
        Me.dgvSSet.TabIndex = 8
        '
        'colSSel
        '
        Me.colSSel.Frozen = True
        Me.colSSel.HeaderText = ""
        Me.colSSel.Name = "colSSel"
        Me.colSSel.ReadOnly = True
        Me.colSSel.Text = "Select"
        Me.colSSel.UseColumnTextForButtonValue = True
        Me.colSSel.Width = 60
        '
        'colSDel
        '
        Me.colSDel.Frozen = True
        Me.colSDel.HeaderText = ""
        Me.colSDel.Name = "colSDel"
        Me.colSDel.ReadOnly = True
        Me.colSDel.Text = "Remove"
        Me.colSDel.UseColumnTextForButtonValue = True
        Me.colSDel.Width = 60
        '
        'pnlSSet
        '
        Me.pnlSSet.Controls.Add(Me.chkSSRef1ER)
        Me.pnlSSet.Controls.Add(Me.chkSSRef1EE)
        Me.pnlSSet.Controls.Add(Me.lblSSRef1ER)
        Me.pnlSSet.Controls.Add(Me.txtSSRef1ER)
        Me.pnlSSet.Controls.Add(Me.lblSSRef1EE)
        Me.pnlSSet.Controls.Add(Me.lblSSetRef)
        Me.pnlSSet.Controls.Add(Me.cboSSetSched)
        Me.pnlSSet.Controls.Add(Me.lblSSetSched)
        Me.pnlSSet.Controls.Add(Me.cboSSetCB)
        Me.pnlSSet.Controls.Add(Me.lblSSetCB)
        Me.pnlSSet.Controls.Add(Me.txtSSRef1EE)
        Me.pnlSSet.Controls.Add(Me.rdbSSRef1)
        Me.pnlSSet.Controls.Add(Me.rdbSSRef0)
        Me.pnlSSet.Controls.Add(Me.cboSSetComp)
        Me.pnlSSet.Controls.Add(Me.lblSSetComp)
        Me.pnlSSet.Controls.Add(Me.btnSSetCancel)
        Me.pnlSSet.Controls.Add(Me.btnSSetSave)
        Me.pnlSSet.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSSet.Location = New System.Drawing.Point(3, 3)
        Me.pnlSSet.Name = "pnlSSet"
        Me.pnlSSet.Size = New System.Drawing.Size(886, 202)
        Me.pnlSSet.TabIndex = 7
        '
        'chkSSRef1ER
        '
        Me.chkSSRef1ER.AutoSize = True
        Me.chkSSRef1ER.Location = New System.Drawing.Point(481, 87)
        Me.chkSSRef1ER.Name = "chkSSRef1ER"
        Me.chkSSRef1ER.Size = New System.Drawing.Size(49, 18)
        Me.chkSSRef1ER.TabIndex = 77
        Me.chkSSRef1ER.Text = "in %"
        Me.chkSSRef1ER.UseVisualStyleBackColor = True
        '
        'chkSSRef1EE
        '
        Me.chkSSRef1EE.AutoSize = True
        Me.chkSSRef1EE.Location = New System.Drawing.Point(481, 62)
        Me.chkSSRef1EE.Name = "chkSSRef1EE"
        Me.chkSSRef1EE.Size = New System.Drawing.Size(49, 18)
        Me.chkSSRef1EE.TabIndex = 76
        Me.chkSSRef1EE.Text = "in %"
        Me.chkSSRef1EE.UseVisualStyleBackColor = True
        '
        'lblSSRef1ER
        '
        Me.lblSSRef1ER.AutoSize = True
        Me.lblSSRef1ER.Location = New System.Drawing.Point(299, 88)
        Me.lblSSRef1ER.Name = "lblSSRef1ER"
        Me.lblSSRef1ER.Size = New System.Drawing.Size(97, 14)
        Me.lblSSRef1ER.TabIndex = 67
        Me.lblSSRef1ER.Text = "Employer Share :"
        '
        'txtSSRef1ER
        '
        Me.txtSSRef1ER.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSRef1ER.Location = New System.Drawing.Point(405, 85)
        Me.txtSSRef1ER.MaxLength = 15
        Me.txtSSRef1ER.Name = "txtSSRef1ER"
        Me.txtSSRef1ER.Size = New System.Drawing.Size(70, 22)
        Me.txtSSRef1ER.TabIndex = 66
        Me.txtSSRef1ER.Text = "0.00"
        Me.txtSSRef1ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSSRef1EE
        '
        Me.lblSSRef1EE.AutoSize = True
        Me.lblSSRef1EE.Location = New System.Drawing.Point(299, 63)
        Me.lblSSRef1EE.Name = "lblSSRef1EE"
        Me.lblSSRef1EE.Size = New System.Drawing.Size(100, 14)
        Me.lblSSRef1EE.TabIndex = 65
        Me.lblSSRef1EE.Text = "Employee Share :"
        '
        'lblSSetRef
        '
        Me.lblSSetRef.AutoSize = True
        Me.lblSSetRef.Location = New System.Drawing.Point(7, 39)
        Me.lblSSetRef.Name = "lblSSetRef"
        Me.lblSSetRef.Size = New System.Drawing.Size(62, 14)
        Me.lblSSetRef.TabIndex = 61
        Me.lblSSetRef.Text = "Reference"
        '
        'cboSSetSched
        '
        Me.cboSSetSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSSetSched.FormattingEnabled = True
        Me.cboSSetSched.Items.AddRange(New Object() {"- Select Contribution Schedule -", "1st Payroll", "2nd Payroll", "1st and 2nd Payroll"})
        Me.cboSSetSched.Location = New System.Drawing.Point(125, 138)
        Me.cboSSetSched.Name = "cboSSetSched"
        Me.cboSSetSched.Size = New System.Drawing.Size(350, 22)
        Me.cboSSetSched.TabIndex = 60
        '
        'lblSSetSched
        '
        Me.lblSSetSched.AutoSize = True
        Me.lblSSetSched.Location = New System.Drawing.Point(7, 141)
        Me.lblSSetSched.Name = "lblSSetSched"
        Me.lblSSetSched.Size = New System.Drawing.Size(57, 14)
        Me.lblSSetSched.TabIndex = 59
        Me.lblSSetSched.Text = "Schedule"
        '
        'cboSSetCB
        '
        Me.cboSSetCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSSetCB.FormattingEnabled = True
        Me.cboSSetCB.Items.AddRange(New Object() {"- Select Contribution Basis -", "Base Rate", "Gross Pay"})
        Me.cboSSetCB.Location = New System.Drawing.Point(125, 113)
        Me.cboSSetCB.Name = "cboSSetCB"
        Me.cboSSetCB.Size = New System.Drawing.Size(350, 22)
        Me.cboSSetCB.TabIndex = 58
        '
        'lblSSetCB
        '
        Me.lblSSetCB.AutoSize = True
        Me.lblSSetCB.Location = New System.Drawing.Point(7, 116)
        Me.lblSSetCB.Name = "lblSSetCB"
        Me.lblSSetCB.Size = New System.Drawing.Size(107, 14)
        Me.lblSSetCB.TabIndex = 57
        Me.lblSSetCB.Text = "Contribution Basis"
        '
        'txtSSRef1EE
        '
        Me.txtSSRef1EE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSRef1EE.Location = New System.Drawing.Point(405, 60)
        Me.txtSSRef1EE.MaxLength = 15
        Me.txtSSRef1EE.Name = "txtSSRef1EE"
        Me.txtSSRef1EE.Size = New System.Drawing.Size(70, 22)
        Me.txtSSRef1EE.TabIndex = 55
        Me.txtSSRef1EE.Text = "0.00"
        Me.txtSSRef1EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdbSSRef1
        '
        Me.rdbSSRef1.AutoSize = True
        Me.rdbSSRef1.Location = New System.Drawing.Point(125, 61)
        Me.rdbSSRef1.Name = "rdbSSRef1"
        Me.rdbSSRef1.Size = New System.Drawing.Size(127, 18)
        Me.rdbSSRef1.TabIndex = 53
        Me.rdbSSRef1.Text = "Use custom values"
        Me.rdbSSRef1.UseVisualStyleBackColor = True
        '
        'rdbSSRef0
        '
        Me.rdbSSRef0.AutoSize = True
        Me.rdbSSRef0.Checked = True
        Me.rdbSSRef0.Location = New System.Drawing.Point(125, 37)
        Me.rdbSSRef0.Name = "rdbSSRef0"
        Me.rdbSSRef0.Size = New System.Drawing.Size(153, 18)
        Me.rdbSSRef0.TabIndex = 52
        Me.rdbSSRef0.TabStop = True
        Me.rdbSSRef0.Text = "Use Contribution Matrix"
        Me.rdbSSRef0.UseVisualStyleBackColor = True
        '
        'cboSSetComp
        '
        Me.cboSSetComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSSetComp.FormattingEnabled = True
        Me.cboSSetComp.Location = New System.Drawing.Point(125, 9)
        Me.cboSSetComp.Name = "cboSSetComp"
        Me.cboSSetComp.Size = New System.Drawing.Size(350, 22)
        Me.cboSSetComp.TabIndex = 51
        '
        'lblSSetComp
        '
        Me.lblSSetComp.AutoSize = True
        Me.lblSSetComp.Location = New System.Drawing.Point(7, 12)
        Me.lblSSetComp.Name = "lblSSetComp"
        Me.lblSSetComp.Size = New System.Drawing.Size(56, 14)
        Me.lblSSetComp.TabIndex = 50
        Me.lblSSetComp.Text = "Company"
        '
        'btnSSetCancel
        '
        Me.btnSSetCancel.Image = CType(resources.GetObject("btnSSetCancel.Image"), System.Drawing.Image)
        Me.btnSSetCancel.Location = New System.Drawing.Point(205, 165)
        Me.btnSSetCancel.Name = "btnSSetCancel"
        Me.btnSSetCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnSSetCancel.TabIndex = 49
        Me.btnSSetCancel.Text = "Cancel"
        Me.btnSSetCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSSetCancel.UseVisualStyleBackColor = True
        '
        'btnSSetSave
        '
        Me.btnSSetSave.Image = CType(resources.GetObject("btnSSetSave.Image"), System.Drawing.Image)
        Me.btnSSetSave.Location = New System.Drawing.Point(125, 165)
        Me.btnSSetSave.Name = "btnSSetSave"
        Me.btnSSetSave.Size = New System.Drawing.Size(77, 29)
        Me.btnSSetSave.TabIndex = 48
        Me.btnSSetSave.Text = "Save"
        Me.btnSSetSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSSetSave.UseVisualStyleBackColor = True
        '
        'tpSSSMatrix
        '
        Me.tpSSSMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSSSMatrix.Controls.Add(Me.dgvSSS)
        Me.tpSSSMatrix.Controls.Add(Me.pnlSSS)
        Me.tpSSSMatrix.Location = New System.Drawing.Point(4, 23)
        Me.tpSSSMatrix.Name = "tpSSSMatrix"
        Me.tpSSSMatrix.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSSSMatrix.Size = New System.Drawing.Size(894, 425)
        Me.tpSSSMatrix.TabIndex = 0
        Me.tpSSSMatrix.Text = "Contribution Matrix"
        Me.tpSSSMatrix.UseVisualStyleBackColor = True
        '
        'dgvSSS
        '
        Me.dgvSSS.AllowUserToAddRows = False
        Me.dgvSSS.AllowUserToDeleteRows = False
        Me.dgvSSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSSS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSCMSel, Me.colSCMDel})
        Me.dgvSSS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSSS.Location = New System.Drawing.Point(3, 178)
        Me.dgvSSS.Name = "dgvSSS"
        Me.dgvSSS.ReadOnly = True
        Me.dgvSSS.Size = New System.Drawing.Size(886, 242)
        Me.dgvSSS.TabIndex = 6
        '
        'colSCMSel
        '
        Me.colSCMSel.Frozen = True
        Me.colSCMSel.HeaderText = ""
        Me.colSCMSel.Name = "colSCMSel"
        Me.colSCMSel.ReadOnly = True
        Me.colSCMSel.Text = "Select"
        Me.colSCMSel.UseColumnTextForButtonValue = True
        Me.colSCMSel.Width = 60
        '
        'colSCMDel
        '
        Me.colSCMDel.Frozen = True
        Me.colSCMDel.HeaderText = ""
        Me.colSCMDel.Name = "colSCMDel"
        Me.colSCMDel.ReadOnly = True
        Me.colSCMDel.Text = "Remove"
        Me.colSCMDel.UseColumnTextForButtonValue = True
        Me.colSCMDel.Width = 60
        '
        'pnlSSS
        '
        Me.pnlSSS.Controls.Add(Me.Label5)
        Me.pnlSSS.Controls.Add(Me.btnSCancel)
        Me.pnlSSS.Controls.Add(Me.btnSSave)
        Me.pnlSSS.Controls.Add(Me.txtSEEShare)
        Me.pnlSSS.Controls.Add(Me.txtERSPlusAdj)
        Me.pnlSSS.Controls.Add(Me.lblSPlus)
        Me.pnlSSS.Controls.Add(Me.txtSERShare)
        Me.pnlSSS.Controls.Add(Me.lblSEEShare)
        Me.pnlSSS.Controls.Add(Me.txtSSC)
        Me.pnlSSS.Controls.Add(Me.txtSSBEnd)
        Me.pnlSSS.Controls.Add(Me.lblSTo)
        Me.pnlSSS.Controls.Add(Me.txtSSBStart)
        Me.pnlSSS.Controls.Add(Me.lblSERShare)
        Me.pnlSSS.Controls.Add(Me.lblSSC)
        Me.pnlSSS.Controls.Add(Me.lblSSB)
        Me.pnlSSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSSS.Location = New System.Drawing.Point(3, 3)
        Me.pnlSSS.Name = "pnlSSS"
        Me.pnlSSS.Size = New System.Drawing.Size(886, 175)
        Me.pnlSSS.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 14)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "ER"
        '
        'btnSCancel
        '
        Me.btnSCancel.Image = CType(resources.GetObject("btnSCancel.Image"), System.Drawing.Image)
        Me.btnSCancel.Location = New System.Drawing.Point(230, 137)
        Me.btnSCancel.Name = "btnSCancel"
        Me.btnSCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnSCancel.TabIndex = 31
        Me.btnSCancel.Text = "Cancel"
        Me.btnSCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSCancel.UseVisualStyleBackColor = True
        '
        'btnSSave
        '
        Me.btnSSave.Image = CType(resources.GetObject("btnSSave.Image"), System.Drawing.Image)
        Me.btnSSave.Location = New System.Drawing.Point(150, 137)
        Me.btnSSave.Name = "btnSSave"
        Me.btnSSave.Size = New System.Drawing.Size(77, 29)
        Me.btnSSave.TabIndex = 30
        Me.btnSSave.Text = "Save"
        Me.btnSSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSSave.UseVisualStyleBackColor = True
        '
        'txtSEEShare
        '
        Me.txtSEEShare.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEEShare.Location = New System.Drawing.Point(150, 59)
        Me.txtSEEShare.Name = "txtSEEShare"
        Me.txtSEEShare.Size = New System.Drawing.Size(100, 22)
        Me.txtSEEShare.TabIndex = 29
        Me.txtSEEShare.Text = "0.00"
        Me.txtSEEShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtERSPlusAdj
        '
        Me.txtERSPlusAdj.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtERSPlusAdj.Location = New System.Drawing.Point(150, 109)
        Me.txtERSPlusAdj.Name = "txtERSPlusAdj"
        Me.txtERSPlusAdj.Size = New System.Drawing.Size(100, 22)
        Me.txtERSPlusAdj.TabIndex = 28
        Me.txtERSPlusAdj.Text = "0.00"
        Me.txtERSPlusAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSPlus
        '
        Me.lblSPlus.AutoSize = True
        Me.lblSPlus.Location = New System.Drawing.Point(109, 112)
        Me.lblSPlus.Name = "lblSPlus"
        Me.lblSPlus.Size = New System.Drawing.Size(36, 14)
        Me.lblSPlus.TabIndex = 27
        Me.lblSPlus.Text = "+ Adj."
        '
        'txtSERShare
        '
        Me.txtSERShare.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSERShare.Location = New System.Drawing.Point(150, 84)
        Me.txtSERShare.Name = "txtSERShare"
        Me.txtSERShare.Size = New System.Drawing.Size(100, 22)
        Me.txtSERShare.TabIndex = 26
        Me.txtSERShare.Text = "0.00"
        Me.txtSERShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSEEShare
        '
        Me.lblSEEShare.AutoSize = True
        Me.lblSEEShare.Location = New System.Drawing.Point(125, 62)
        Me.lblSEEShare.Name = "lblSEEShare"
        Me.lblSEEShare.Size = New System.Drawing.Size(19, 14)
        Me.lblSEEShare.TabIndex = 25
        Me.lblSEEShare.Text = "EE"
        '
        'txtSSC
        '
        Me.txtSSC.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSC.Location = New System.Drawing.Point(150, 34)
        Me.txtSSC.Name = "txtSSC"
        Me.txtSSC.Size = New System.Drawing.Size(100, 22)
        Me.txtSSC.TabIndex = 24
        Me.txtSSC.Text = "0.00"
        Me.txtSSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSSBEnd
        '
        Me.txtSSBEnd.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSBEnd.Location = New System.Drawing.Point(298, 9)
        Me.txtSSBEnd.Name = "txtSSBEnd"
        Me.txtSSBEnd.Size = New System.Drawing.Size(100, 22)
        Me.txtSSBEnd.TabIndex = 23
        Me.txtSSBEnd.Text = "0.00"
        Me.txtSSBEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSTo
        '
        Me.lblSTo.AutoSize = True
        Me.lblSTo.Location = New System.Drawing.Point(264, 12)
        Me.lblSTo.Name = "lblSTo"
        Me.lblSTo.Size = New System.Drawing.Size(18, 14)
        Me.lblSTo.TabIndex = 22
        Me.lblSTo.Text = "to"
        '
        'txtSSBStart
        '
        Me.txtSSBStart.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSBStart.Location = New System.Drawing.Point(150, 9)
        Me.txtSSBStart.Name = "txtSSBStart"
        Me.txtSSBStart.Size = New System.Drawing.Size(100, 22)
        Me.txtSSBStart.TabIndex = 21
        Me.txtSSBStart.Text = "0.00"
        Me.txtSSBStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSERShare
        '
        Me.lblSERShare.AutoSize = True
        Me.lblSERShare.Location = New System.Drawing.Point(7, 62)
        Me.lblSERShare.Name = "lblSERShare"
        Me.lblSERShare.Size = New System.Drawing.Size(107, 14)
        Me.lblSERShare.TabIndex = 2
        Me.lblSERShare.Text = "Contribution EE/ER"
        '
        'lblSSC
        '
        Me.lblSSC.AutoSize = True
        Me.lblSSC.Location = New System.Drawing.Point(7, 37)
        Me.lblSSC.Name = "lblSSC"
        Me.lblSSC.Size = New System.Drawing.Size(75, 14)
        Me.lblSSC.TabIndex = 1
        Me.lblSSC.Text = "Salary Credit"
        '
        'lblSSB
        '
        Me.lblSSB.AutoSize = True
        Me.lblSSB.Location = New System.Drawing.Point(7, 12)
        Me.lblSSB.Name = "lblSSB"
        Me.lblSSB.Size = New System.Drawing.Size(83, 14)
        Me.lblSSB.TabIndex = 0
        Me.lblSSB.Text = "Salary Bracket"
        '
        'tpPhilhealth
        '
        Me.tpPhilhealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPhilhealth.Controls.Add(Me.tcPSetting)
        Me.tpPhilhealth.Location = New System.Drawing.Point(4, 23)
        Me.tpPhilhealth.Name = "tpPhilhealth"
        Me.tpPhilhealth.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPhilhealth.Size = New System.Drawing.Size(910, 459)
        Me.tpPhilhealth.TabIndex = 1
        Me.tpPhilhealth.Text = "Philhealth"
        Me.tpPhilhealth.UseVisualStyleBackColor = True
        '
        'tcPSetting
        '
        Me.tcPSetting.Controls.Add(Me.TabPage19)
        Me.tcPSetting.Controls.Add(Me.TabPage18)
        Me.tcPSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPSetting.Location = New System.Drawing.Point(3, 3)
        Me.tcPSetting.Name = "tcPSetting"
        Me.tcPSetting.SelectedIndex = 0
        Me.tcPSetting.Size = New System.Drawing.Size(902, 451)
        Me.tcPSetting.TabIndex = 1
        '
        'TabPage19
        '
        Me.TabPage19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage19.Controls.Add(Me.dgvPS)
        Me.TabPage19.Controls.Add(Me.pnlPS)
        Me.TabPage19.Location = New System.Drawing.Point(4, 23)
        Me.TabPage19.Name = "TabPage19"
        Me.TabPage19.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage19.Size = New System.Drawing.Size(894, 424)
        Me.TabPage19.TabIndex = 1
        Me.TabPage19.Text = "Setting"
        Me.TabPage19.UseVisualStyleBackColor = True
        '
        'dgvPS
        '
        Me.dgvPS.AllowUserToAddRows = False
        Me.dgvPS.AllowUserToDeleteRows = False
        Me.dgvPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPSetSel, Me.colPSetDel})
        Me.dgvPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPS.Location = New System.Drawing.Point(3, 205)
        Me.dgvPS.Name = "dgvPS"
        Me.dgvPS.ReadOnly = True
        Me.dgvPS.Size = New System.Drawing.Size(886, 214)
        Me.dgvPS.TabIndex = 8
        '
        'colPSetSel
        '
        Me.colPSetSel.Frozen = True
        Me.colPSetSel.HeaderText = ""
        Me.colPSetSel.Name = "colPSetSel"
        Me.colPSetSel.ReadOnly = True
        Me.colPSetSel.Text = "Select"
        Me.colPSetSel.UseColumnTextForButtonValue = True
        Me.colPSetSel.Width = 60
        '
        'colPSetDel
        '
        Me.colPSetDel.Frozen = True
        Me.colPSetDel.HeaderText = ""
        Me.colPSetDel.Name = "colPSetDel"
        Me.colPSetDel.ReadOnly = True
        Me.colPSetDel.Text = "Remove"
        Me.colPSetDel.UseColumnTextForButtonValue = True
        Me.colPSetDel.Width = 60
        '
        'pnlPS
        '
        Me.pnlPS.Controls.Add(Me.chkPSRef1ER)
        Me.pnlPS.Controls.Add(Me.chkPSRef1EE)
        Me.pnlPS.Controls.Add(Me.lblPSRef1ER)
        Me.pnlPS.Controls.Add(Me.txtPSRef1ER)
        Me.pnlPS.Controls.Add(Me.lblPSRef1EE)
        Me.pnlPS.Controls.Add(Me.lblPSRef)
        Me.pnlPS.Controls.Add(Me.cboPSSched)
        Me.pnlPS.Controls.Add(Me.lblPSSched)
        Me.pnlPS.Controls.Add(Me.cboPSCB)
        Me.pnlPS.Controls.Add(Me.lblPSCB)
        Me.pnlPS.Controls.Add(Me.txtPSRef1EE)
        Me.pnlPS.Controls.Add(Me.rdbPSRef1)
        Me.pnlPS.Controls.Add(Me.rdbPSRef0)
        Me.pnlPS.Controls.Add(Me.cboPSComp)
        Me.pnlPS.Controls.Add(Me.lblPSComp)
        Me.pnlPS.Controls.Add(Me.btnPSCancel)
        Me.pnlPS.Controls.Add(Me.btnPSSave)
        Me.pnlPS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPS.Location = New System.Drawing.Point(3, 3)
        Me.pnlPS.Name = "pnlPS"
        Me.pnlPS.Size = New System.Drawing.Size(886, 202)
        Me.pnlPS.TabIndex = 7
        '
        'chkPSRef1ER
        '
        Me.chkPSRef1ER.AutoSize = True
        Me.chkPSRef1ER.Location = New System.Drawing.Point(481, 87)
        Me.chkPSRef1ER.Name = "chkPSRef1ER"
        Me.chkPSRef1ER.Size = New System.Drawing.Size(49, 18)
        Me.chkPSRef1ER.TabIndex = 75
        Me.chkPSRef1ER.Text = "in %"
        Me.chkPSRef1ER.UseVisualStyleBackColor = True
        '
        'chkPSRef1EE
        '
        Me.chkPSRef1EE.AutoSize = True
        Me.chkPSRef1EE.Location = New System.Drawing.Point(481, 62)
        Me.chkPSRef1EE.Name = "chkPSRef1EE"
        Me.chkPSRef1EE.Size = New System.Drawing.Size(49, 18)
        Me.chkPSRef1EE.TabIndex = 74
        Me.chkPSRef1EE.Text = "in %"
        Me.chkPSRef1EE.UseVisualStyleBackColor = True
        '
        'lblPSRef1ER
        '
        Me.lblPSRef1ER.AutoSize = True
        Me.lblPSRef1ER.Location = New System.Drawing.Point(299, 88)
        Me.lblPSRef1ER.Name = "lblPSRef1ER"
        Me.lblPSRef1ER.Size = New System.Drawing.Size(97, 14)
        Me.lblPSRef1ER.TabIndex = 73
        Me.lblPSRef1ER.Text = "Employer Share :"
        '
        'txtPSRef1ER
        '
        Me.txtPSRef1ER.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPSRef1ER.Location = New System.Drawing.Point(405, 85)
        Me.txtPSRef1ER.MaxLength = 15
        Me.txtPSRef1ER.Name = "txtPSRef1ER"
        Me.txtPSRef1ER.Size = New System.Drawing.Size(70, 22)
        Me.txtPSRef1ER.TabIndex = 72
        Me.txtPSRef1ER.Text = "0.00"
        Me.txtPSRef1ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPSRef1EE
        '
        Me.lblPSRef1EE.AutoSize = True
        Me.lblPSRef1EE.Location = New System.Drawing.Point(299, 63)
        Me.lblPSRef1EE.Name = "lblPSRef1EE"
        Me.lblPSRef1EE.Size = New System.Drawing.Size(100, 14)
        Me.lblPSRef1EE.TabIndex = 71
        Me.lblPSRef1EE.Text = "Employee Share :"
        '
        'lblPSRef
        '
        Me.lblPSRef.AutoSize = True
        Me.lblPSRef.Location = New System.Drawing.Point(7, 39)
        Me.lblPSRef.Name = "lblPSRef"
        Me.lblPSRef.Size = New System.Drawing.Size(62, 14)
        Me.lblPSRef.TabIndex = 62
        Me.lblPSRef.Text = "Reference"
        '
        'cboPSSched
        '
        Me.cboPSSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPSSched.FormattingEnabled = True
        Me.cboPSSched.Items.AddRange(New Object() {"- Select Contribution Schedule -", "1st Payroll", "2nd Payroll", "1st and 2nd Payroll"})
        Me.cboPSSched.Location = New System.Drawing.Point(125, 138)
        Me.cboPSSched.Name = "cboPSSched"
        Me.cboPSSched.Size = New System.Drawing.Size(350, 22)
        Me.cboPSSched.TabIndex = 60
        '
        'lblPSSched
        '
        Me.lblPSSched.AutoSize = True
        Me.lblPSSched.Location = New System.Drawing.Point(7, 141)
        Me.lblPSSched.Name = "lblPSSched"
        Me.lblPSSched.Size = New System.Drawing.Size(57, 14)
        Me.lblPSSched.TabIndex = 59
        Me.lblPSSched.Text = "Schedule"
        '
        'cboPSCB
        '
        Me.cboPSCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPSCB.FormattingEnabled = True
        Me.cboPSCB.Items.AddRange(New Object() {"- Select Contribution Basis -", "Base Rate", "Gross Pay"})
        Me.cboPSCB.Location = New System.Drawing.Point(125, 113)
        Me.cboPSCB.Name = "cboPSCB"
        Me.cboPSCB.Size = New System.Drawing.Size(350, 22)
        Me.cboPSCB.TabIndex = 58
        '
        'lblPSCB
        '
        Me.lblPSCB.AutoSize = True
        Me.lblPSCB.Location = New System.Drawing.Point(7, 116)
        Me.lblPSCB.Name = "lblPSCB"
        Me.lblPSCB.Size = New System.Drawing.Size(107, 14)
        Me.lblPSCB.TabIndex = 57
        Me.lblPSCB.Text = "Contribution Basis"
        '
        'txtPSRef1EE
        '
        Me.txtPSRef1EE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPSRef1EE.Location = New System.Drawing.Point(405, 60)
        Me.txtPSRef1EE.Name = "txtPSRef1EE"
        Me.txtPSRef1EE.Size = New System.Drawing.Size(70, 22)
        Me.txtPSRef1EE.TabIndex = 55
        Me.txtPSRef1EE.Text = "0.00"
        Me.txtPSRef1EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdbPSRef1
        '
        Me.rdbPSRef1.AutoSize = True
        Me.rdbPSRef1.Location = New System.Drawing.Point(125, 61)
        Me.rdbPSRef1.Name = "rdbPSRef1"
        Me.rdbPSRef1.Size = New System.Drawing.Size(127, 18)
        Me.rdbPSRef1.TabIndex = 53
        Me.rdbPSRef1.Text = "Use custom values"
        Me.rdbPSRef1.UseVisualStyleBackColor = True
        '
        'rdbPSRef0
        '
        Me.rdbPSRef0.AutoSize = True
        Me.rdbPSRef0.Checked = True
        Me.rdbPSRef0.Location = New System.Drawing.Point(125, 37)
        Me.rdbPSRef0.Name = "rdbPSRef0"
        Me.rdbPSRef0.Size = New System.Drawing.Size(153, 18)
        Me.rdbPSRef0.TabIndex = 52
        Me.rdbPSRef0.TabStop = True
        Me.rdbPSRef0.Text = "Use Contribution Matrix"
        Me.rdbPSRef0.UseVisualStyleBackColor = True
        '
        'cboPSComp
        '
        Me.cboPSComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPSComp.FormattingEnabled = True
        Me.cboPSComp.Location = New System.Drawing.Point(125, 9)
        Me.cboPSComp.Name = "cboPSComp"
        Me.cboPSComp.Size = New System.Drawing.Size(350, 22)
        Me.cboPSComp.TabIndex = 51
        '
        'lblPSComp
        '
        Me.lblPSComp.AutoSize = True
        Me.lblPSComp.Location = New System.Drawing.Point(7, 12)
        Me.lblPSComp.Name = "lblPSComp"
        Me.lblPSComp.Size = New System.Drawing.Size(56, 14)
        Me.lblPSComp.TabIndex = 50
        Me.lblPSComp.Text = "Company"
        '
        'btnPSCancel
        '
        Me.btnPSCancel.Image = CType(resources.GetObject("btnPSCancel.Image"), System.Drawing.Image)
        Me.btnPSCancel.Location = New System.Drawing.Point(205, 165)
        Me.btnPSCancel.Name = "btnPSCancel"
        Me.btnPSCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPSCancel.TabIndex = 49
        Me.btnPSCancel.Text = "Cancel"
        Me.btnPSCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPSCancel.UseVisualStyleBackColor = True
        '
        'btnPSSave
        '
        Me.btnPSSave.Image = CType(resources.GetObject("btnPSSave.Image"), System.Drawing.Image)
        Me.btnPSSave.Location = New System.Drawing.Point(125, 165)
        Me.btnPSSave.Name = "btnPSSave"
        Me.btnPSSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPSSave.TabIndex = 48
        Me.btnPSSave.Text = "Save"
        Me.btnPSSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPSSave.UseVisualStyleBackColor = True
        '
        'TabPage18
        '
        Me.TabPage18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage18.Controls.Add(Me.dgvPH)
        Me.TabPage18.Controls.Add(Me.pnlPH)
        Me.TabPage18.Location = New System.Drawing.Point(4, 23)
        Me.TabPage18.Name = "TabPage18"
        Me.TabPage18.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage18.Size = New System.Drawing.Size(894, 425)
        Me.TabPage18.TabIndex = 0
        Me.TabPage18.Text = "Contribution Matrix"
        Me.TabPage18.UseVisualStyleBackColor = True
        '
        'dgvPH
        '
        Me.dgvPH.AllowUserToAddRows = False
        Me.dgvPH.AllowUserToDeleteRows = False
        Me.dgvPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPCMSel, Me.colPCMDel})
        Me.dgvPH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPH.Location = New System.Drawing.Point(3, 178)
        Me.dgvPH.Name = "dgvPH"
        Me.dgvPH.ReadOnly = True
        Me.dgvPH.Size = New System.Drawing.Size(886, 242)
        Me.dgvPH.TabIndex = 5
        '
        'colPCMSel
        '
        Me.colPCMSel.Frozen = True
        Me.colPCMSel.HeaderText = ""
        Me.colPCMSel.Name = "colPCMSel"
        Me.colPCMSel.ReadOnly = True
        Me.colPCMSel.Text = "Select"
        Me.colPCMSel.UseColumnTextForButtonValue = True
        Me.colPCMSel.Width = 60
        '
        'colPCMDel
        '
        Me.colPCMDel.Frozen = True
        Me.colPCMDel.HeaderText = ""
        Me.colPCMDel.Name = "colPCMDel"
        Me.colPCMDel.ReadOnly = True
        Me.colPCMDel.Text = "Remove"
        Me.colPCMDel.UseColumnTextForButtonValue = True
        Me.colPCMDel.Width = 60
        '
        'pnlPH
        '
        Me.pnlPH.Controls.Add(Me.Label6)
        Me.pnlPH.Controls.Add(Me.btnPHCancel)
        Me.pnlPH.Controls.Add(Me.btnPHSave)
        Me.pnlPH.Controls.Add(Me.txtPHERShare)
        Me.pnlPH.Controls.Add(Me.txtPHERPlusAdj)
        Me.pnlPH.Controls.Add(Me.lblPPlus)
        Me.pnlPH.Controls.Add(Me.txtPHEEShare)
        Me.pnlPH.Controls.Add(Me.lblPHEEShare)
        Me.pnlPH.Controls.Add(Me.txtPHSC)
        Me.pnlPH.Controls.Add(Me.txtPHSBEnd)
        Me.pnlPH.Controls.Add(Me.lblPTo)
        Me.pnlPH.Controls.Add(Me.txtPHSBStart)
        Me.pnlPH.Controls.Add(Me.lblPHERShare)
        Me.pnlPH.Controls.Add(Me.lblPHSC)
        Me.pnlPH.Controls.Add(Me.lblPHSB)
        Me.pnlPH.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPH.Location = New System.Drawing.Point(3, 3)
        Me.pnlPH.Name = "pnlPH"
        Me.pnlPH.Size = New System.Drawing.Size(886, 175)
        Me.pnlPH.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 14)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "ER"
        '
        'btnPHCancel
        '
        Me.btnPHCancel.Image = CType(resources.GetObject("btnPHCancel.Image"), System.Drawing.Image)
        Me.btnPHCancel.Location = New System.Drawing.Point(230, 137)
        Me.btnPHCancel.Name = "btnPHCancel"
        Me.btnPHCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPHCancel.TabIndex = 45
        Me.btnPHCancel.Text = "Cancel"
        Me.btnPHCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPHCancel.UseVisualStyleBackColor = True
        '
        'btnPHSave
        '
        Me.btnPHSave.Image = CType(resources.GetObject("btnPHSave.Image"), System.Drawing.Image)
        Me.btnPHSave.Location = New System.Drawing.Point(150, 137)
        Me.btnPHSave.Name = "btnPHSave"
        Me.btnPHSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPHSave.TabIndex = 44
        Me.btnPHSave.Text = "Save"
        Me.btnPHSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPHSave.UseVisualStyleBackColor = True
        '
        'txtPHERShare
        '
        Me.txtPHERShare.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHERShare.Location = New System.Drawing.Point(150, 84)
        Me.txtPHERShare.Name = "txtPHERShare"
        Me.txtPHERShare.Size = New System.Drawing.Size(100, 22)
        Me.txtPHERShare.TabIndex = 43
        Me.txtPHERShare.Text = "0.00"
        Me.txtPHERShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPHERPlusAdj
        '
        Me.txtPHERPlusAdj.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHERPlusAdj.Location = New System.Drawing.Point(150, 109)
        Me.txtPHERPlusAdj.Name = "txtPHERPlusAdj"
        Me.txtPHERPlusAdj.Size = New System.Drawing.Size(100, 22)
        Me.txtPHERPlusAdj.TabIndex = 42
        Me.txtPHERPlusAdj.Text = "0.00"
        Me.txtPHERPlusAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPPlus
        '
        Me.lblPPlus.AutoSize = True
        Me.lblPPlus.Location = New System.Drawing.Point(109, 112)
        Me.lblPPlus.Name = "lblPPlus"
        Me.lblPPlus.Size = New System.Drawing.Size(36, 14)
        Me.lblPPlus.TabIndex = 41
        Me.lblPPlus.Text = "+ Adj."
        '
        'txtPHEEShare
        '
        Me.txtPHEEShare.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHEEShare.Location = New System.Drawing.Point(150, 59)
        Me.txtPHEEShare.Name = "txtPHEEShare"
        Me.txtPHEEShare.Size = New System.Drawing.Size(100, 22)
        Me.txtPHEEShare.TabIndex = 40
        Me.txtPHEEShare.Text = "0.00"
        Me.txtPHEEShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPHEEShare
        '
        Me.lblPHEEShare.AutoSize = True
        Me.lblPHEEShare.Location = New System.Drawing.Point(125, 62)
        Me.lblPHEEShare.Name = "lblPHEEShare"
        Me.lblPHEEShare.Size = New System.Drawing.Size(19, 14)
        Me.lblPHEEShare.TabIndex = 39
        Me.lblPHEEShare.Text = "EE"
        '
        'txtPHSC
        '
        Me.txtPHSC.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHSC.Location = New System.Drawing.Point(150, 34)
        Me.txtPHSC.Name = "txtPHSC"
        Me.txtPHSC.Size = New System.Drawing.Size(100, 22)
        Me.txtPHSC.TabIndex = 38
        Me.txtPHSC.Text = "0.00"
        Me.txtPHSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPHSBEnd
        '
        Me.txtPHSBEnd.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHSBEnd.Location = New System.Drawing.Point(298, 9)
        Me.txtPHSBEnd.Name = "txtPHSBEnd"
        Me.txtPHSBEnd.Size = New System.Drawing.Size(100, 22)
        Me.txtPHSBEnd.TabIndex = 37
        Me.txtPHSBEnd.Text = "0.00"
        Me.txtPHSBEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPTo
        '
        Me.lblPTo.AutoSize = True
        Me.lblPTo.Location = New System.Drawing.Point(264, 12)
        Me.lblPTo.Name = "lblPTo"
        Me.lblPTo.Size = New System.Drawing.Size(18, 14)
        Me.lblPTo.TabIndex = 36
        Me.lblPTo.Text = "to"
        '
        'txtPHSBStart
        '
        Me.txtPHSBStart.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHSBStart.Location = New System.Drawing.Point(150, 9)
        Me.txtPHSBStart.Name = "txtPHSBStart"
        Me.txtPHSBStart.Size = New System.Drawing.Size(100, 22)
        Me.txtPHSBStart.TabIndex = 35
        Me.txtPHSBStart.Text = "0.00"
        Me.txtPHSBStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPHERShare
        '
        Me.lblPHERShare.AutoSize = True
        Me.lblPHERShare.Location = New System.Drawing.Point(7, 62)
        Me.lblPHERShare.Name = "lblPHERShare"
        Me.lblPHERShare.Size = New System.Drawing.Size(107, 14)
        Me.lblPHERShare.TabIndex = 34
        Me.lblPHERShare.Text = "Contribution EE/ER"
        '
        'lblPHSC
        '
        Me.lblPHSC.AutoSize = True
        Me.lblPHSC.Location = New System.Drawing.Point(7, 37)
        Me.lblPHSC.Name = "lblPHSC"
        Me.lblPHSC.Size = New System.Drawing.Size(75, 14)
        Me.lblPHSC.TabIndex = 33
        Me.lblPHSC.Text = "Salary Credit"
        '
        'lblPHSB
        '
        Me.lblPHSB.AutoSize = True
        Me.lblPHSB.Location = New System.Drawing.Point(7, 12)
        Me.lblPHSB.Name = "lblPHSB"
        Me.lblPHSB.Size = New System.Drawing.Size(83, 14)
        Me.lblPHSB.TabIndex = 32
        Me.lblPHSB.Text = "Salary Bracket"
        '
        'tpHDMF
        '
        Me.tpHDMF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpHDMF.Controls.Add(Me.tcHSetting)
        Me.tpHDMF.Location = New System.Drawing.Point(4, 23)
        Me.tpHDMF.Name = "tpHDMF"
        Me.tpHDMF.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHDMF.Size = New System.Drawing.Size(910, 459)
        Me.tpHDMF.TabIndex = 2
        Me.tpHDMF.Text = "HDMF"
        Me.tpHDMF.UseVisualStyleBackColor = True
        '
        'tcHSetting
        '
        Me.tcHSetting.Controls.Add(Me.TabPage21)
        Me.tcHSetting.Controls.Add(Me.TabPage20)
        Me.tcHSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcHSetting.Location = New System.Drawing.Point(3, 3)
        Me.tcHSetting.Name = "tcHSetting"
        Me.tcHSetting.SelectedIndex = 0
        Me.tcHSetting.Size = New System.Drawing.Size(902, 451)
        Me.tcHSetting.TabIndex = 1
        '
        'TabPage21
        '
        Me.TabPage21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage21.Controls.Add(Me.dgvHS)
        Me.TabPage21.Controls.Add(Me.pnlHS)
        Me.TabPage21.Location = New System.Drawing.Point(4, 23)
        Me.TabPage21.Name = "TabPage21"
        Me.TabPage21.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage21.Size = New System.Drawing.Size(894, 424)
        Me.TabPage21.TabIndex = 1
        Me.TabPage21.Text = "Setting"
        Me.TabPage21.UseVisualStyleBackColor = True
        '
        'dgvHS
        '
        Me.dgvHS.AllowUserToAddRows = False
        Me.dgvHS.AllowUserToDeleteRows = False
        Me.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHSetSel, Me.colHSetDel})
        Me.dgvHS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHS.Location = New System.Drawing.Point(3, 205)
        Me.dgvHS.Name = "dgvHS"
        Me.dgvHS.ReadOnly = True
        Me.dgvHS.Size = New System.Drawing.Size(886, 214)
        Me.dgvHS.TabIndex = 6
        '
        'colHSetSel
        '
        Me.colHSetSel.Frozen = True
        Me.colHSetSel.HeaderText = ""
        Me.colHSetSel.Name = "colHSetSel"
        Me.colHSetSel.ReadOnly = True
        Me.colHSetSel.Text = "Select"
        Me.colHSetSel.UseColumnTextForButtonValue = True
        Me.colHSetSel.Width = 60
        '
        'colHSetDel
        '
        Me.colHSetDel.Frozen = True
        Me.colHSetDel.HeaderText = ""
        Me.colHSetDel.Name = "colHSetDel"
        Me.colHSetDel.ReadOnly = True
        Me.colHSetDel.Text = "Remove"
        Me.colHSetDel.UseColumnTextForButtonValue = True
        Me.colHSetDel.Width = 60
        '
        'pnlHS
        '
        Me.pnlHS.Controls.Add(Me.chkHSRef1ER)
        Me.pnlHS.Controls.Add(Me.chkHSRef1EE)
        Me.pnlHS.Controls.Add(Me.lblHSRef1ER)
        Me.pnlHS.Controls.Add(Me.txtHSRef1ER)
        Me.pnlHS.Controls.Add(Me.lblHSRef1EE)
        Me.pnlHS.Controls.Add(Me.lblHSRef)
        Me.pnlHS.Controls.Add(Me.cboHSSched)
        Me.pnlHS.Controls.Add(Me.lblHSSched)
        Me.pnlHS.Controls.Add(Me.cboHSCB)
        Me.pnlHS.Controls.Add(Me.lblHSCB)
        Me.pnlHS.Controls.Add(Me.txtHSRef1EE)
        Me.pnlHS.Controls.Add(Me.rdbHSRef1)
        Me.pnlHS.Controls.Add(Me.rdbHSRef0)
        Me.pnlHS.Controls.Add(Me.cboHSComp)
        Me.pnlHS.Controls.Add(Me.lblHSComp)
        Me.pnlHS.Controls.Add(Me.btnHSCancel)
        Me.pnlHS.Controls.Add(Me.btnHSSave)
        Me.pnlHS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHS.Location = New System.Drawing.Point(3, 3)
        Me.pnlHS.Name = "pnlHS"
        Me.pnlHS.Size = New System.Drawing.Size(886, 202)
        Me.pnlHS.TabIndex = 0
        '
        'chkHSRef1ER
        '
        Me.chkHSRef1ER.AutoSize = True
        Me.chkHSRef1ER.Location = New System.Drawing.Point(481, 87)
        Me.chkHSRef1ER.Name = "chkHSRef1ER"
        Me.chkHSRef1ER.Size = New System.Drawing.Size(49, 18)
        Me.chkHSRef1ER.TabIndex = 81
        Me.chkHSRef1ER.Text = "in %"
        Me.chkHSRef1ER.UseVisualStyleBackColor = True
        '
        'chkHSRef1EE
        '
        Me.chkHSRef1EE.AutoSize = True
        Me.chkHSRef1EE.Location = New System.Drawing.Point(481, 62)
        Me.chkHSRef1EE.Name = "chkHSRef1EE"
        Me.chkHSRef1EE.Size = New System.Drawing.Size(49, 18)
        Me.chkHSRef1EE.TabIndex = 80
        Me.chkHSRef1EE.Text = "in %"
        Me.chkHSRef1EE.UseVisualStyleBackColor = True
        '
        'lblHSRef1ER
        '
        Me.lblHSRef1ER.AutoSize = True
        Me.lblHSRef1ER.Location = New System.Drawing.Point(299, 88)
        Me.lblHSRef1ER.Name = "lblHSRef1ER"
        Me.lblHSRef1ER.Size = New System.Drawing.Size(97, 14)
        Me.lblHSRef1ER.TabIndex = 79
        Me.lblHSRef1ER.Text = "Employer Share :"
        '
        'txtHSRef1ER
        '
        Me.txtHSRef1ER.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSRef1ER.Location = New System.Drawing.Point(405, 85)
        Me.txtHSRef1ER.MaxLength = 15
        Me.txtHSRef1ER.Name = "txtHSRef1ER"
        Me.txtHSRef1ER.Size = New System.Drawing.Size(70, 22)
        Me.txtHSRef1ER.TabIndex = 78
        Me.txtHSRef1ER.Text = "0.00"
        Me.txtHSRef1ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHSRef1EE
        '
        Me.lblHSRef1EE.AutoSize = True
        Me.lblHSRef1EE.Location = New System.Drawing.Point(299, 63)
        Me.lblHSRef1EE.Name = "lblHSRef1EE"
        Me.lblHSRef1EE.Size = New System.Drawing.Size(100, 14)
        Me.lblHSRef1EE.TabIndex = 77
        Me.lblHSRef1EE.Text = "Employee Share :"
        '
        'lblHSRef
        '
        Me.lblHSRef.AutoSize = True
        Me.lblHSRef.Location = New System.Drawing.Point(7, 39)
        Me.lblHSRef.Name = "lblHSRef"
        Me.lblHSRef.Size = New System.Drawing.Size(62, 14)
        Me.lblHSRef.TabIndex = 62
        Me.lblHSRef.Text = "Reference"
        '
        'cboHSSched
        '
        Me.cboHSSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHSSched.FormattingEnabled = True
        Me.cboHSSched.Items.AddRange(New Object() {"- Select Contribution Schedule -", "1st Payroll", "2nd Payroll", "1st and 2nd Payroll"})
        Me.cboHSSched.Location = New System.Drawing.Point(125, 138)
        Me.cboHSSched.Name = "cboHSSched"
        Me.cboHSSched.Size = New System.Drawing.Size(350, 22)
        Me.cboHSSched.TabIndex = 60
        '
        'lblHSSched
        '
        Me.lblHSSched.AutoSize = True
        Me.lblHSSched.Location = New System.Drawing.Point(7, 141)
        Me.lblHSSched.Name = "lblHSSched"
        Me.lblHSSched.Size = New System.Drawing.Size(57, 14)
        Me.lblHSSched.TabIndex = 59
        Me.lblHSSched.Text = "Schedule"
        '
        'cboHSCB
        '
        Me.cboHSCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHSCB.FormattingEnabled = True
        Me.cboHSCB.Items.AddRange(New Object() {"- Select Contribution Basis -", "Base Rate", "Gross Pay"})
        Me.cboHSCB.Location = New System.Drawing.Point(125, 113)
        Me.cboHSCB.Name = "cboHSCB"
        Me.cboHSCB.Size = New System.Drawing.Size(350, 22)
        Me.cboHSCB.TabIndex = 58
        '
        'lblHSCB
        '
        Me.lblHSCB.AutoSize = True
        Me.lblHSCB.Location = New System.Drawing.Point(7, 116)
        Me.lblHSCB.Name = "lblHSCB"
        Me.lblHSCB.Size = New System.Drawing.Size(107, 14)
        Me.lblHSCB.TabIndex = 57
        Me.lblHSCB.Text = "Contribution Basis"
        '
        'txtHSRef1EE
        '
        Me.txtHSRef1EE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSRef1EE.Location = New System.Drawing.Point(405, 60)
        Me.txtHSRef1EE.Name = "txtHSRef1EE"
        Me.txtHSRef1EE.Size = New System.Drawing.Size(70, 22)
        Me.txtHSRef1EE.TabIndex = 55
        Me.txtHSRef1EE.Text = "0.00"
        Me.txtHSRef1EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdbHSRef1
        '
        Me.rdbHSRef1.AutoSize = True
        Me.rdbHSRef1.Location = New System.Drawing.Point(125, 61)
        Me.rdbHSRef1.Name = "rdbHSRef1"
        Me.rdbHSRef1.Size = New System.Drawing.Size(127, 18)
        Me.rdbHSRef1.TabIndex = 53
        Me.rdbHSRef1.Text = "Use custom values"
        Me.rdbHSRef1.UseVisualStyleBackColor = True
        '
        'rdbHSRef0
        '
        Me.rdbHSRef0.AutoSize = True
        Me.rdbHSRef0.Checked = True
        Me.rdbHSRef0.Location = New System.Drawing.Point(125, 37)
        Me.rdbHSRef0.Name = "rdbHSRef0"
        Me.rdbHSRef0.Size = New System.Drawing.Size(153, 18)
        Me.rdbHSRef0.TabIndex = 52
        Me.rdbHSRef0.TabStop = True
        Me.rdbHSRef0.Text = "Use Contribution Matrix"
        Me.rdbHSRef0.UseVisualStyleBackColor = True
        '
        'cboHSComp
        '
        Me.cboHSComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHSComp.FormattingEnabled = True
        Me.cboHSComp.Location = New System.Drawing.Point(125, 9)
        Me.cboHSComp.Name = "cboHSComp"
        Me.cboHSComp.Size = New System.Drawing.Size(350, 22)
        Me.cboHSComp.TabIndex = 51
        '
        'lblHSComp
        '
        Me.lblHSComp.AutoSize = True
        Me.lblHSComp.Location = New System.Drawing.Point(7, 12)
        Me.lblHSComp.Name = "lblHSComp"
        Me.lblHSComp.Size = New System.Drawing.Size(56, 14)
        Me.lblHSComp.TabIndex = 50
        Me.lblHSComp.Text = "Company"
        '
        'btnHSCancel
        '
        Me.btnHSCancel.Image = CType(resources.GetObject("btnHSCancel.Image"), System.Drawing.Image)
        Me.btnHSCancel.Location = New System.Drawing.Point(205, 165)
        Me.btnHSCancel.Name = "btnHSCancel"
        Me.btnHSCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnHSCancel.TabIndex = 49
        Me.btnHSCancel.Text = "Cancel"
        Me.btnHSCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHSCancel.UseVisualStyleBackColor = True
        '
        'btnHSSave
        '
        Me.btnHSSave.Image = CType(resources.GetObject("btnHSSave.Image"), System.Drawing.Image)
        Me.btnHSSave.Location = New System.Drawing.Point(125, 165)
        Me.btnHSSave.Name = "btnHSSave"
        Me.btnHSSave.Size = New System.Drawing.Size(77, 29)
        Me.btnHSSave.TabIndex = 48
        Me.btnHSSave.Text = "Save"
        Me.btnHSSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHSSave.UseVisualStyleBackColor = True
        '
        'TabPage20
        '
        Me.TabPage20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage20.Controls.Add(Me.dgvHDMF)
        Me.TabPage20.Controls.Add(Me.pnlHDMF)
        Me.TabPage20.Location = New System.Drawing.Point(4, 23)
        Me.TabPage20.Name = "TabPage20"
        Me.TabPage20.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage20.Size = New System.Drawing.Size(894, 425)
        Me.TabPage20.TabIndex = 0
        Me.TabPage20.Text = "Contribution Matrix"
        Me.TabPage20.UseVisualStyleBackColor = True
        '
        'dgvHDMF
        '
        Me.dgvHDMF.AllowUserToAddRows = False
        Me.dgvHDMF.AllowUserToDeleteRows = False
        Me.dgvHDMF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHDMF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHDMFSelect, Me.colHDMFDel})
        Me.dgvHDMF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHDMF.Location = New System.Drawing.Point(3, 178)
        Me.dgvHDMF.Name = "dgvHDMF"
        Me.dgvHDMF.ReadOnly = True
        Me.dgvHDMF.Size = New System.Drawing.Size(886, 242)
        Me.dgvHDMF.TabIndex = 5
        '
        'colHDMFSelect
        '
        Me.colHDMFSelect.Frozen = True
        Me.colHDMFSelect.HeaderText = ""
        Me.colHDMFSelect.Name = "colHDMFSelect"
        Me.colHDMFSelect.ReadOnly = True
        Me.colHDMFSelect.Text = "Select"
        Me.colHDMFSelect.UseColumnTextForButtonValue = True
        Me.colHDMFSelect.Width = 60
        '
        'colHDMFDel
        '
        Me.colHDMFDel.Frozen = True
        Me.colHDMFDel.HeaderText = ""
        Me.colHDMFDel.Name = "colHDMFDel"
        Me.colHDMFDel.ReadOnly = True
        Me.colHDMFDel.Text = "Remove"
        Me.colHDMFDel.UseColumnTextForButtonValue = True
        Me.colHDMFDel.Width = 60
        '
        'pnlHDMF
        '
        Me.pnlHDMF.Controls.Add(Me.chkHDER)
        Me.pnlHDMF.Controls.Add(Me.lblHDCER)
        Me.pnlHDMF.Controls.Add(Me.txtHDCER)
        Me.pnlHDMF.Controls.Add(Me.txtHDERA)
        Me.pnlHDMF.Controls.Add(Me.lblHDCERA)
        Me.pnlHDMF.Controls.Add(Me.txtHDCEE)
        Me.pnlHDMF.Controls.Add(Me.lblHDCEE)
        Me.pnlHDMF.Controls.Add(Me.txtHDSC)
        Me.pnlHDMF.Controls.Add(Me.txtHDSBEnd)
        Me.pnlHDMF.Controls.Add(Me.Label4)
        Me.pnlHDMF.Controls.Add(Me.txtHDSBStart)
        Me.pnlHDMF.Controls.Add(Me.lblHCC)
        Me.pnlHDMF.Controls.Add(Me.lblHSC)
        Me.pnlHDMF.Controls.Add(Me.lblHSB)
        Me.pnlHDMF.Controls.Add(Me.btnHDMFCancel)
        Me.pnlHDMF.Controls.Add(Me.btnHDMFSave)
        Me.pnlHDMF.Controls.Add(Me.chkHDEE)
        Me.pnlHDMF.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHDMF.Location = New System.Drawing.Point(3, 3)
        Me.pnlHDMF.Name = "pnlHDMF"
        Me.pnlHDMF.Size = New System.Drawing.Size(886, 175)
        Me.pnlHDMF.TabIndex = 4
        '
        'chkHDER
        '
        Me.chkHDER.AutoSize = True
        Me.chkHDER.Location = New System.Drawing.Point(256, 86)
        Me.chkHDER.Name = "chkHDER"
        Me.chkHDER.Size = New System.Drawing.Size(80, 18)
        Me.chkHDER.TabIndex = 61
        Me.chkHDER.Text = "in Percent"
        Me.chkHDER.UseVisualStyleBackColor = True
        '
        'lblHDCER
        '
        Me.lblHDCER.AutoSize = True
        Me.lblHDCER.Location = New System.Drawing.Point(125, 87)
        Me.lblHDCER.Name = "lblHDCER"
        Me.lblHDCER.Size = New System.Drawing.Size(20, 14)
        Me.lblHDCER.TabIndex = 60
        Me.lblHDCER.Text = "ER"
        '
        'txtHDCER
        '
        Me.txtHDCER.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDCER.Location = New System.Drawing.Point(150, 84)
        Me.txtHDCER.Name = "txtHDCER"
        Me.txtHDCER.Size = New System.Drawing.Size(100, 22)
        Me.txtHDCER.TabIndex = 59
        Me.txtHDCER.Text = "0.00"
        Me.txtHDCER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHDERA
        '
        Me.txtHDERA.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDERA.Location = New System.Drawing.Point(150, 109)
        Me.txtHDERA.Name = "txtHDERA"
        Me.txtHDERA.ReadOnly = True
        Me.txtHDERA.Size = New System.Drawing.Size(100, 22)
        Me.txtHDERA.TabIndex = 58
        Me.txtHDERA.Text = "0.00"
        Me.txtHDERA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHDERA.Visible = False
        '
        'lblHDCERA
        '
        Me.lblHDCERA.AutoSize = True
        Me.lblHDCERA.Location = New System.Drawing.Point(109, 112)
        Me.lblHDCERA.Name = "lblHDCERA"
        Me.lblHDCERA.Size = New System.Drawing.Size(36, 14)
        Me.lblHDCERA.TabIndex = 57
        Me.lblHDCERA.Text = "+ Adj."
        Me.lblHDCERA.Visible = False
        '
        'txtHDCEE
        '
        Me.txtHDCEE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDCEE.Location = New System.Drawing.Point(150, 59)
        Me.txtHDCEE.Name = "txtHDCEE"
        Me.txtHDCEE.Size = New System.Drawing.Size(100, 22)
        Me.txtHDCEE.TabIndex = 56
        Me.txtHDCEE.Text = "0.00"
        Me.txtHDCEE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHDCEE
        '
        Me.lblHDCEE.AutoSize = True
        Me.lblHDCEE.Location = New System.Drawing.Point(125, 62)
        Me.lblHDCEE.Name = "lblHDCEE"
        Me.lblHDCEE.Size = New System.Drawing.Size(19, 14)
        Me.lblHDCEE.TabIndex = 55
        Me.lblHDCEE.Text = "EE"
        '
        'txtHDSC
        '
        Me.txtHDSC.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDSC.Location = New System.Drawing.Point(150, 34)
        Me.txtHDSC.Name = "txtHDSC"
        Me.txtHDSC.Size = New System.Drawing.Size(100, 22)
        Me.txtHDSC.TabIndex = 54
        Me.txtHDSC.Text = "0.00"
        Me.txtHDSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHDSBEnd
        '
        Me.txtHDSBEnd.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDSBEnd.Location = New System.Drawing.Point(298, 9)
        Me.txtHDSBEnd.Name = "txtHDSBEnd"
        Me.txtHDSBEnd.Size = New System.Drawing.Size(100, 22)
        Me.txtHDSBEnd.TabIndex = 53
        Me.txtHDSBEnd.Text = "0.00"
        Me.txtHDSBEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 14)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "to"
        '
        'txtHDSBStart
        '
        Me.txtHDSBStart.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDSBStart.Location = New System.Drawing.Point(150, 9)
        Me.txtHDSBStart.Name = "txtHDSBStart"
        Me.txtHDSBStart.Size = New System.Drawing.Size(100, 22)
        Me.txtHDSBStart.TabIndex = 51
        Me.txtHDSBStart.Text = "0.00"
        Me.txtHDSBStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHCC
        '
        Me.lblHCC.AutoSize = True
        Me.lblHCC.Location = New System.Drawing.Point(7, 62)
        Me.lblHCC.Name = "lblHCC"
        Me.lblHCC.Size = New System.Drawing.Size(107, 14)
        Me.lblHCC.TabIndex = 50
        Me.lblHCC.Text = "Contribution EE/ER"
        '
        'lblHSC
        '
        Me.lblHSC.AutoSize = True
        Me.lblHSC.Location = New System.Drawing.Point(7, 37)
        Me.lblHSC.Name = "lblHSC"
        Me.lblHSC.Size = New System.Drawing.Size(75, 14)
        Me.lblHSC.TabIndex = 49
        Me.lblHSC.Text = "Salary Credit"
        '
        'lblHSB
        '
        Me.lblHSB.AutoSize = True
        Me.lblHSB.Location = New System.Drawing.Point(7, 12)
        Me.lblHSB.Name = "lblHSB"
        Me.lblHSB.Size = New System.Drawing.Size(83, 14)
        Me.lblHSB.TabIndex = 48
        Me.lblHSB.Text = "Salary Bracket"
        '
        'btnHDMFCancel
        '
        Me.btnHDMFCancel.Image = CType(resources.GetObject("btnHDMFCancel.Image"), System.Drawing.Image)
        Me.btnHDMFCancel.Location = New System.Drawing.Point(230, 137)
        Me.btnHDMFCancel.Name = "btnHDMFCancel"
        Me.btnHDMFCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnHDMFCancel.TabIndex = 47
        Me.btnHDMFCancel.Text = "Cancel"
        Me.btnHDMFCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHDMFCancel.UseVisualStyleBackColor = True
        '
        'btnHDMFSave
        '
        Me.btnHDMFSave.Image = CType(resources.GetObject("btnHDMFSave.Image"), System.Drawing.Image)
        Me.btnHDMFSave.Location = New System.Drawing.Point(150, 137)
        Me.btnHDMFSave.Name = "btnHDMFSave"
        Me.btnHDMFSave.Size = New System.Drawing.Size(77, 29)
        Me.btnHDMFSave.TabIndex = 46
        Me.btnHDMFSave.Text = "Save"
        Me.btnHDMFSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHDMFSave.UseVisualStyleBackColor = True
        '
        'chkHDEE
        '
        Me.chkHDEE.AutoSize = True
        Me.chkHDEE.Location = New System.Drawing.Point(256, 61)
        Me.chkHDEE.Name = "chkHDEE"
        Me.chkHDEE.Size = New System.Drawing.Size(80, 18)
        Me.chkHDEE.TabIndex = 6
        Me.chkHDEE.Text = "in Percent"
        Me.chkHDEE.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage9.Controls.Add(Me.dgvEC)
        Me.TabPage9.Controls.Add(Me.pnlEC)
        Me.TabPage9.Location = New System.Drawing.Point(4, 23)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(926, 494)
        Me.TabPage9.TabIndex = 2
        Me.TabPage9.Text = "ECOLA"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'dgvEC
        '
        Me.dgvEC.AllowUserToAddRows = False
        Me.dgvEC.AllowUserToDeleteRows = False
        Me.dgvEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colESel, Me.colEDel})
        Me.dgvEC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEC.Location = New System.Drawing.Point(3, 153)
        Me.dgvEC.Name = "dgvEC"
        Me.dgvEC.ReadOnly = True
        Me.dgvEC.Size = New System.Drawing.Size(918, 336)
        Me.dgvEC.TabIndex = 7
        '
        'colESel
        '
        Me.colESel.Frozen = True
        Me.colESel.HeaderText = ""
        Me.colESel.Name = "colESel"
        Me.colESel.ReadOnly = True
        Me.colESel.Text = "Select"
        Me.colESel.UseColumnTextForButtonValue = True
        Me.colESel.Width = 60
        '
        'colEDel
        '
        Me.colEDel.Frozen = True
        Me.colEDel.HeaderText = ""
        Me.colEDel.Name = "colEDel"
        Me.colEDel.ReadOnly = True
        Me.colEDel.Text = "Remove"
        Me.colEDel.UseColumnTextForButtonValue = True
        Me.colEDel.Width = 60
        '
        'pnlEC
        '
        Me.pnlEC.Controls.Add(Me.btnECCancel)
        Me.pnlEC.Controls.Add(Me.btnECSave)
        Me.pnlEC.Controls.Add(Me.chkECProRate)
        Me.pnlEC.Controls.Add(Me.txtECAR)
        Me.pnlEC.Controls.Add(Me.lblECAR)
        Me.pnlEC.Controls.Add(Me.txtECDesc)
        Me.pnlEC.Controls.Add(Me.lblECDesc)
        Me.pnlEC.Controls.Add(Me.txtECCode)
        Me.pnlEC.Controls.Add(Me.lblECCode)
        Me.pnlEC.Controls.Add(Me.cboECComp)
        Me.pnlEC.Controls.Add(Me.lblECComp)
        Me.pnlEC.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEC.Location = New System.Drawing.Point(3, 3)
        Me.pnlEC.Name = "pnlEC"
        Me.pnlEC.Size = New System.Drawing.Size(918, 150)
        Me.pnlEC.TabIndex = 6
        '
        'btnECCancel
        '
        Me.btnECCancel.Image = CType(resources.GetObject("btnECCancel.Image"), System.Drawing.Image)
        Me.btnECCancel.Location = New System.Drawing.Point(211, 112)
        Me.btnECCancel.Name = "btnECCancel"
        Me.btnECCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnECCancel.TabIndex = 49
        Me.btnECCancel.Text = "Cancel"
        Me.btnECCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnECCancel.UseVisualStyleBackColor = True
        '
        'btnECSave
        '
        Me.btnECSave.Image = CType(resources.GetObject("btnECSave.Image"), System.Drawing.Image)
        Me.btnECSave.Location = New System.Drawing.Point(130, 112)
        Me.btnECSave.Name = "btnECSave"
        Me.btnECSave.Size = New System.Drawing.Size(77, 29)
        Me.btnECSave.TabIndex = 48
        Me.btnECSave.Text = "Save"
        Me.btnECSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnECSave.UseVisualStyleBackColor = True
        '
        'chkECProRate
        '
        Me.chkECProRate.AutoSize = True
        Me.chkECProRate.Location = New System.Drawing.Point(205, 86)
        Me.chkECProRate.Name = "chkECProRate"
        Me.chkECProRate.Size = New System.Drawing.Size(79, 18)
        Me.chkECProRate.TabIndex = 8
        Me.chkECProRate.Text = "Pro-Rated"
        Me.chkECProRate.UseVisualStyleBackColor = True
        '
        'txtECAR
        '
        Me.txtECAR.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECAR.Location = New System.Drawing.Point(130, 84)
        Me.txtECAR.MaxLength = 15
        Me.txtECAR.Name = "txtECAR"
        Me.txtECAR.Size = New System.Drawing.Size(69, 22)
        Me.txtECAR.TabIndex = 7
        Me.txtECAR.Text = "0.00"
        Me.txtECAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblECAR
        '
        Me.lblECAR.AutoSize = True
        Me.lblECAR.Location = New System.Drawing.Point(7, 84)
        Me.lblECAR.Name = "lblECAR"
        Me.lblECAR.Size = New System.Drawing.Size(78, 14)
        Me.lblECAR.TabIndex = 6
        Me.lblECAR.Text = "Applied Rate"
        '
        'txtECDesc
        '
        Me.txtECDesc.Location = New System.Drawing.Point(130, 59)
        Me.txtECDesc.MaxLength = 150
        Me.txtECDesc.Name = "txtECDesc"
        Me.txtECDesc.Size = New System.Drawing.Size(350, 22)
        Me.txtECDesc.TabIndex = 5
        '
        'lblECDesc
        '
        Me.lblECDesc.AutoSize = True
        Me.lblECDesc.Location = New System.Drawing.Point(7, 60)
        Me.lblECDesc.Name = "lblECDesc"
        Me.lblECDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblECDesc.TabIndex = 4
        Me.lblECDesc.Text = "Description"
        '
        'txtECCode
        '
        Me.txtECCode.Location = New System.Drawing.Point(130, 34)
        Me.txtECCode.MaxLength = 25
        Me.txtECCode.Name = "txtECCode"
        Me.txtECCode.Size = New System.Drawing.Size(150, 22)
        Me.txtECCode.TabIndex = 3
        '
        'lblECCode
        '
        Me.lblECCode.AutoSize = True
        Me.lblECCode.Location = New System.Drawing.Point(7, 36)
        Me.lblECCode.Name = "lblECCode"
        Me.lblECCode.Size = New System.Drawing.Size(34, 14)
        Me.lblECCode.TabIndex = 2
        Me.lblECCode.Text = "Code"
        '
        'cboECComp
        '
        Me.cboECComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboECComp.FormattingEnabled = True
        Me.cboECComp.Location = New System.Drawing.Point(130, 9)
        Me.cboECComp.Name = "cboECComp"
        Me.cboECComp.Size = New System.Drawing.Size(350, 22)
        Me.cboECComp.TabIndex = 1
        '
        'lblECComp
        '
        Me.lblECComp.AutoSize = True
        Me.lblECComp.Location = New System.Drawing.Point(7, 12)
        Me.lblECComp.Name = "lblECComp"
        Me.lblECComp.Size = New System.Drawing.Size(56, 14)
        Me.lblECComp.TabIndex = 0
        Me.lblECComp.Text = "Company"
        '
        'tpPayParams
        '
        Me.tpPayParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPayParams.Controls.Add(Me.tcPayParams)
        Me.tpPayParams.Location = New System.Drawing.Point(4, 23)
        Me.tpPayParams.Name = "tpPayParams"
        Me.tpPayParams.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPayParams.Size = New System.Drawing.Size(926, 494)
        Me.tpPayParams.TabIndex = 3
        Me.tpPayParams.Text = "Payroll Parameters"
        Me.tpPayParams.UseVisualStyleBackColor = True
        '
        'tcPayParams
        '
        Me.tcPayParams.Controls.Add(Me.tpPR)
        Me.tcPayParams.Controls.Add(Me.tpPB)
        Me.tcPayParams.Controls.Add(Me.tpPAT)
        Me.tcPayParams.Controls.Add(Me.tpPPS)
        Me.tcPayParams.Controls.Add(Me.tpPPR)
        Me.tcPayParams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPayParams.Location = New System.Drawing.Point(3, 3)
        Me.tcPayParams.Name = "tcPayParams"
        Me.tcPayParams.SelectedIndex = 0
        Me.tcPayParams.Size = New System.Drawing.Size(918, 486)
        Me.tcPayParams.TabIndex = 0
        '
        'tpPR
        '
        Me.tpPR.AutoScroll = True
        Me.tpPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPR.Controls.Add(Me.dgvPRef)
        Me.tpPR.Controls.Add(Me.pnlPRef)
        Me.tpPR.Location = New System.Drawing.Point(4, 23)
        Me.tpPR.Name = "tpPR"
        Me.tpPR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPR.Size = New System.Drawing.Size(910, 459)
        Me.tpPR.TabIndex = 0
        Me.tpPR.Text = "Pay Reference"
        Me.tpPR.UseVisualStyleBackColor = True
        '
        'dgvPRef
        '
        Me.dgvPRef.AllowUserToAddRows = False
        Me.dgvPRef.AllowUserToDeleteRows = False
        Me.dgvPRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPRef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPFSel, Me.colPFDel})
        Me.dgvPRef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPRef.Location = New System.Drawing.Point(3, 153)
        Me.dgvPRef.Name = "dgvPRef"
        Me.dgvPRef.ReadOnly = True
        Me.dgvPRef.Size = New System.Drawing.Size(902, 301)
        Me.dgvPRef.TabIndex = 14
        '
        'colPFSel
        '
        Me.colPFSel.Frozen = True
        Me.colPFSel.HeaderText = ""
        Me.colPFSel.Name = "colPFSel"
        Me.colPFSel.ReadOnly = True
        Me.colPFSel.Text = "Select"
        Me.colPFSel.UseColumnTextForButtonValue = True
        Me.colPFSel.Width = 60
        '
        'colPFDel
        '
        Me.colPFDel.Frozen = True
        Me.colPFDel.HeaderText = ""
        Me.colPFDel.Name = "colPFDel"
        Me.colPFDel.ReadOnly = True
        Me.colPFDel.Text = "Remove"
        Me.colPFDel.UseColumnTextForButtonValue = True
        Me.colPFDel.Width = 60
        '
        'pnlPRef
        '
        Me.pnlPRef.Controls.Add(Me.cboPRB)
        Me.pnlPRef.Controls.Add(Me.lblPRB)
        Me.pnlPRef.Controls.Add(Me.txtPRDPY)
        Me.pnlPRef.Controls.Add(Me.lblPRDPY)
        Me.pnlPRef.Controls.Add(Me.btnPFCancel)
        Me.pnlPRef.Controls.Add(Me.btnPFSave)
        Me.pnlPRef.Controls.Add(Me.txtPRDesc)
        Me.pnlPRef.Controls.Add(Me.lblPRDesc)
        Me.pnlPRef.Controls.Add(Me.txtPRCode)
        Me.pnlPRef.Controls.Add(Me.lblPRCode)
        Me.pnlPRef.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPRef.Location = New System.Drawing.Point(3, 3)
        Me.pnlPRef.Name = "pnlPRef"
        Me.pnlPRef.Size = New System.Drawing.Size(902, 150)
        Me.pnlPRef.TabIndex = 13
        '
        'txtPRDPY
        '
        Me.txtPRDPY.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDPY.Location = New System.Drawing.Point(130, 59)
        Me.txtPRDPY.MaxLength = 4
        Me.txtPRDPY.Name = "txtPRDPY"
        Me.txtPRDPY.Size = New System.Drawing.Size(53, 22)
        Me.txtPRDPY.TabIndex = 55
        Me.txtPRDPY.Text = "0"
        Me.txtPRDPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPRDPY
        '
        Me.lblPRDPY.AutoSize = True
        Me.lblPRDPY.Location = New System.Drawing.Point(7, 62)
        Me.lblPRDPY.Name = "lblPRDPY"
        Me.lblPRDPY.Size = New System.Drawing.Size(107, 14)
        Me.lblPRDPY.TabIndex = 54
        Me.lblPRDPY.Text = "Applied Days/Year"
        '
        'btnPFCancel
        '
        Me.btnPFCancel.Image = CType(resources.GetObject("btnPFCancel.Image"), System.Drawing.Image)
        Me.btnPFCancel.Location = New System.Drawing.Point(210, 112)
        Me.btnPFCancel.Name = "btnPFCancel"
        Me.btnPFCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPFCancel.TabIndex = 53
        Me.btnPFCancel.Text = "Cancel"
        Me.btnPFCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPFCancel.UseVisualStyleBackColor = True
        '
        'btnPFSave
        '
        Me.btnPFSave.Image = CType(resources.GetObject("btnPFSave.Image"), System.Drawing.Image)
        Me.btnPFSave.Location = New System.Drawing.Point(130, 112)
        Me.btnPFSave.Name = "btnPFSave"
        Me.btnPFSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPFSave.TabIndex = 52
        Me.btnPFSave.Text = "Save"
        Me.btnPFSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPFSave.UseVisualStyleBackColor = True
        '
        'txtPRDesc
        '
        Me.txtPRDesc.Location = New System.Drawing.Point(130, 34)
        Me.txtPRDesc.MaxLength = 150
        Me.txtPRDesc.Name = "txtPRDesc"
        Me.txtPRDesc.Size = New System.Drawing.Size(350, 22)
        Me.txtPRDesc.TabIndex = 3
        '
        'lblPRDesc
        '
        Me.lblPRDesc.AutoSize = True
        Me.lblPRDesc.Location = New System.Drawing.Point(7, 37)
        Me.lblPRDesc.Name = "lblPRDesc"
        Me.lblPRDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblPRDesc.TabIndex = 2
        Me.lblPRDesc.Text = "Description"
        '
        'txtPRCode
        '
        Me.txtPRCode.Location = New System.Drawing.Point(130, 9)
        Me.txtPRCode.MaxLength = 25
        Me.txtPRCode.Name = "txtPRCode"
        Me.txtPRCode.Size = New System.Drawing.Size(150, 22)
        Me.txtPRCode.TabIndex = 1
        '
        'lblPRCode
        '
        Me.lblPRCode.AutoSize = True
        Me.lblPRCode.Location = New System.Drawing.Point(7, 12)
        Me.lblPRCode.Name = "lblPRCode"
        Me.lblPRCode.Size = New System.Drawing.Size(34, 14)
        Me.lblPRCode.TabIndex = 0
        Me.lblPRCode.Text = "Code"
        '
        'tpPB
        '
        Me.tpPB.AutoScroll = True
        Me.tpPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPB.Controls.Add(Me.dgvPB)
        Me.tpPB.Controls.Add(Me.pnlPB)
        Me.tpPB.Location = New System.Drawing.Point(4, 23)
        Me.tpPB.Name = "tpPB"
        Me.tpPB.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPB.Size = New System.Drawing.Size(910, 459)
        Me.tpPB.TabIndex = 1
        Me.tpPB.Text = "Pay Basis"
        Me.tpPB.UseVisualStyleBackColor = True
        '
        'dgvPB
        '
        Me.dgvPB.AllowUserToAddRows = False
        Me.dgvPB.AllowUserToDeleteRows = False
        Me.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPBSel, Me.colPBDel})
        Me.dgvPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPB.Location = New System.Drawing.Point(3, 128)
        Me.dgvPB.Name = "dgvPB"
        Me.dgvPB.ReadOnly = True
        Me.dgvPB.Size = New System.Drawing.Size(902, 326)
        Me.dgvPB.TabIndex = 16
        '
        'colPBSel
        '
        Me.colPBSel.Frozen = True
        Me.colPBSel.HeaderText = ""
        Me.colPBSel.Name = "colPBSel"
        Me.colPBSel.ReadOnly = True
        Me.colPBSel.Text = "Select"
        Me.colPBSel.UseColumnTextForButtonValue = True
        Me.colPBSel.Width = 60
        '
        'colPBDel
        '
        Me.colPBDel.Frozen = True
        Me.colPBDel.HeaderText = ""
        Me.colPBDel.Name = "colPBDel"
        Me.colPBDel.ReadOnly = True
        Me.colPBDel.Text = "Remove"
        Me.colPBDel.UseColumnTextForButtonValue = True
        Me.colPBDel.Width = 60
        '
        'pnlPB
        '
        Me.pnlPB.Controls.Add(Me.cboPBCycle)
        Me.pnlPB.Controls.Add(Me.lblPBCycle)
        Me.pnlPB.Controls.Add(Me.btnPBCancel)
        Me.pnlPB.Controls.Add(Me.btnPBSave)
        Me.pnlPB.Controls.Add(Me.txtPBDesc)
        Me.pnlPB.Controls.Add(Me.lblPBDesc)
        Me.pnlPB.Controls.Add(Me.txtPBCode)
        Me.pnlPB.Controls.Add(Me.lblPBCode)
        Me.pnlPB.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPB.Location = New System.Drawing.Point(3, 3)
        Me.pnlPB.Name = "pnlPB"
        Me.pnlPB.Size = New System.Drawing.Size(902, 125)
        Me.pnlPB.TabIndex = 15
        '
        'cboPBCycle
        '
        Me.cboPBCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPBCycle.FormattingEnabled = True
        Me.cboPBCycle.Items.AddRange(New Object() {"- Select Cycle Count -", "1", "2", "3", "4"})
        Me.cboPBCycle.Location = New System.Drawing.Point(130, 59)
        Me.cboPBCycle.Name = "cboPBCycle"
        Me.cboPBCycle.Size = New System.Drawing.Size(150, 22)
        Me.cboPBCycle.TabIndex = 55
        '
        'lblPBCycle
        '
        Me.lblPBCycle.AutoSize = True
        Me.lblPBCycle.Location = New System.Drawing.Point(7, 62)
        Me.lblPBCycle.Name = "lblPBCycle"
        Me.lblPBCycle.Size = New System.Drawing.Size(99, 14)
        Me.lblPBCycle.TabIndex = 54
        Me.lblPBCycle.Text = "Cycles per Month"
        '
        'btnPBCancel
        '
        Me.btnPBCancel.Image = CType(resources.GetObject("btnPBCancel.Image"), System.Drawing.Image)
        Me.btnPBCancel.Location = New System.Drawing.Point(210, 87)
        Me.btnPBCancel.Name = "btnPBCancel"
        Me.btnPBCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPBCancel.TabIndex = 53
        Me.btnPBCancel.Text = "Cancel"
        Me.btnPBCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPBCancel.UseVisualStyleBackColor = True
        '
        'btnPBSave
        '
        Me.btnPBSave.Image = CType(resources.GetObject("btnPBSave.Image"), System.Drawing.Image)
        Me.btnPBSave.Location = New System.Drawing.Point(130, 87)
        Me.btnPBSave.Name = "btnPBSave"
        Me.btnPBSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPBSave.TabIndex = 52
        Me.btnPBSave.Text = "Save"
        Me.btnPBSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPBSave.UseVisualStyleBackColor = True
        '
        'txtPBDesc
        '
        Me.txtPBDesc.Location = New System.Drawing.Point(130, 34)
        Me.txtPBDesc.MaxLength = 150
        Me.txtPBDesc.Name = "txtPBDesc"
        Me.txtPBDesc.Size = New System.Drawing.Size(350, 22)
        Me.txtPBDesc.TabIndex = 3
        '
        'lblPBDesc
        '
        Me.lblPBDesc.AutoSize = True
        Me.lblPBDesc.Location = New System.Drawing.Point(7, 37)
        Me.lblPBDesc.Name = "lblPBDesc"
        Me.lblPBDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblPBDesc.TabIndex = 2
        Me.lblPBDesc.Text = "Description"
        '
        'txtPBCode
        '
        Me.txtPBCode.Location = New System.Drawing.Point(130, 9)
        Me.txtPBCode.MaxLength = 25
        Me.txtPBCode.Name = "txtPBCode"
        Me.txtPBCode.Size = New System.Drawing.Size(150, 22)
        Me.txtPBCode.TabIndex = 1
        '
        'lblPBCode
        '
        Me.lblPBCode.AutoSize = True
        Me.lblPBCode.Location = New System.Drawing.Point(7, 12)
        Me.lblPBCode.Name = "lblPBCode"
        Me.lblPBCode.Size = New System.Drawing.Size(34, 14)
        Me.lblPBCode.TabIndex = 0
        Me.lblPBCode.Text = "Code"
        '
        'tpPAT
        '
        Me.tpPAT.AutoScroll = True
        Me.tpPAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPAT.Controls.Add(Me.dgvPA)
        Me.tpPAT.Controls.Add(Me.pnlPA)
        Me.tpPAT.Location = New System.Drawing.Point(4, 23)
        Me.tpPAT.Name = "tpPAT"
        Me.tpPAT.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPAT.Size = New System.Drawing.Size(910, 459)
        Me.tpPAT.TabIndex = 2
        Me.tpPAT.Text = "Adjustment Types"
        Me.tpPAT.UseVisualStyleBackColor = True
        '
        'dgvPA
        '
        Me.dgvPA.AllowUserToAddRows = False
        Me.dgvPA.AllowUserToDeleteRows = False
        Me.dgvPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPATSel, Me.colPATDel})
        Me.dgvPA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPA.Location = New System.Drawing.Point(3, 149)
        Me.dgvPA.Name = "dgvPA"
        Me.dgvPA.ReadOnly = True
        Me.dgvPA.Size = New System.Drawing.Size(902, 305)
        Me.dgvPA.TabIndex = 7
        '
        'colPATSel
        '
        Me.colPATSel.Frozen = True
        Me.colPATSel.HeaderText = ""
        Me.colPATSel.Name = "colPATSel"
        Me.colPATSel.ReadOnly = True
        Me.colPATSel.Text = "Select"
        Me.colPATSel.UseColumnTextForButtonValue = True
        Me.colPATSel.Width = 60
        '
        'colPATDel
        '
        Me.colPATDel.Frozen = True
        Me.colPATDel.HeaderText = ""
        Me.colPATDel.Name = "colPATDel"
        Me.colPATDel.ReadOnly = True
        Me.colPATDel.Text = "Remove"
        Me.colPATDel.UseColumnTextForButtonValue = True
        Me.colPATDel.Width = 60
        '
        'pnlPA
        '
        Me.pnlPA.Controls.Add(Me.chkPATaxable)
        Me.pnlPA.Controls.Add(Me.cboPAComp)
        Me.pnlPA.Controls.Add(Me.lblPAComp)
        Me.pnlPA.Controls.Add(Me.btnPACancel)
        Me.pnlPA.Controls.Add(Me.btnPASave)
        Me.pnlPA.Controls.Add(Me.txtPADesc)
        Me.pnlPA.Controls.Add(Me.lblPADesc)
        Me.pnlPA.Controls.Add(Me.txtPACode)
        Me.pnlPA.Controls.Add(Me.lblPACode)
        Me.pnlPA.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPA.Location = New System.Drawing.Point(3, 3)
        Me.pnlPA.Name = "pnlPA"
        Me.pnlPA.Size = New System.Drawing.Size(902, 146)
        Me.pnlPA.TabIndex = 6
        '
        'chkPATaxable
        '
        Me.chkPATaxable.AutoSize = True
        Me.chkPATaxable.Location = New System.Drawing.Point(130, 86)
        Me.chkPATaxable.Name = "chkPATaxable"
        Me.chkPATaxable.Size = New System.Drawing.Size(68, 18)
        Me.chkPATaxable.TabIndex = 58
        Me.chkPATaxable.Text = "Taxable"
        Me.chkPATaxable.UseVisualStyleBackColor = True
        '
        'cboPAComp
        '
        Me.cboPAComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPAComp.FormattingEnabled = True
        Me.cboPAComp.Location = New System.Drawing.Point(130, 9)
        Me.cboPAComp.Name = "cboPAComp"
        Me.cboPAComp.Size = New System.Drawing.Size(350, 22)
        Me.cboPAComp.TabIndex = 57
        '
        'lblPAComp
        '
        Me.lblPAComp.AutoSize = True
        Me.lblPAComp.Location = New System.Drawing.Point(7, 12)
        Me.lblPAComp.Name = "lblPAComp"
        Me.lblPAComp.Size = New System.Drawing.Size(56, 14)
        Me.lblPAComp.TabIndex = 56
        Me.lblPAComp.Text = "Company"
        '
        'btnPACancel
        '
        Me.btnPACancel.Image = CType(resources.GetObject("btnPACancel.Image"), System.Drawing.Image)
        Me.btnPACancel.Location = New System.Drawing.Point(210, 109)
        Me.btnPACancel.Name = "btnPACancel"
        Me.btnPACancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPACancel.TabIndex = 55
        Me.btnPACancel.Text = "Cancel"
        Me.btnPACancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPACancel.UseVisualStyleBackColor = True
        '
        'btnPASave
        '
        Me.btnPASave.Image = CType(resources.GetObject("btnPASave.Image"), System.Drawing.Image)
        Me.btnPASave.Location = New System.Drawing.Point(130, 109)
        Me.btnPASave.Name = "btnPASave"
        Me.btnPASave.Size = New System.Drawing.Size(77, 29)
        Me.btnPASave.TabIndex = 54
        Me.btnPASave.Text = "Save"
        Me.btnPASave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPASave.UseVisualStyleBackColor = True
        '
        'txtPADesc
        '
        Me.txtPADesc.Location = New System.Drawing.Point(130, 59)
        Me.txtPADesc.MaxLength = 150
        Me.txtPADesc.Name = "txtPADesc"
        Me.txtPADesc.Size = New System.Drawing.Size(350, 22)
        Me.txtPADesc.TabIndex = 53
        '
        'lblPADesc
        '
        Me.lblPADesc.AutoSize = True
        Me.lblPADesc.Location = New System.Drawing.Point(7, 62)
        Me.lblPADesc.Name = "lblPADesc"
        Me.lblPADesc.Size = New System.Drawing.Size(69, 14)
        Me.lblPADesc.TabIndex = 52
        Me.lblPADesc.Text = "Description"
        '
        'txtPACode
        '
        Me.txtPACode.Location = New System.Drawing.Point(130, 34)
        Me.txtPACode.MaxLength = 25
        Me.txtPACode.Name = "txtPACode"
        Me.txtPACode.Size = New System.Drawing.Size(150, 22)
        Me.txtPACode.TabIndex = 51
        '
        'lblPACode
        '
        Me.lblPACode.AutoSize = True
        Me.lblPACode.Location = New System.Drawing.Point(7, 37)
        Me.lblPACode.Name = "lblPACode"
        Me.lblPACode.Size = New System.Drawing.Size(34, 14)
        Me.lblPACode.TabIndex = 50
        Me.lblPACode.Text = "Code"
        '
        'tpPPS
        '
        Me.tpPPS.AutoScroll = True
        Me.tpPPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPPS.Controls.Add(Me.dgvPPS)
        Me.tpPPS.Controls.Add(Me.pnlPPS)
        Me.tpPPS.Location = New System.Drawing.Point(4, 23)
        Me.tpPPS.Name = "tpPPS"
        Me.tpPPS.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPPS.Size = New System.Drawing.Size(910, 459)
        Me.tpPPS.TabIndex = 3
        Me.tpPPS.Text = "Payroll Schedule"
        Me.tpPPS.UseVisualStyleBackColor = True
        '
        'dgvPPS
        '
        Me.dgvPPS.AllowUserToAddRows = False
        Me.dgvPPS.AllowUserToDeleteRows = False
        Me.dgvPPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPPSSel, Me.colPPSDel})
        Me.dgvPPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPPS.Location = New System.Drawing.Point(3, 253)
        Me.dgvPPS.Name = "dgvPPS"
        Me.dgvPPS.ReadOnly = True
        Me.dgvPPS.Size = New System.Drawing.Size(902, 201)
        Me.dgvPPS.TabIndex = 8
        '
        'colPPSSel
        '
        Me.colPPSSel.Frozen = True
        Me.colPPSSel.HeaderText = ""
        Me.colPPSSel.Name = "colPPSSel"
        Me.colPPSSel.ReadOnly = True
        Me.colPPSSel.Text = "Select"
        Me.colPPSSel.UseColumnTextForButtonValue = True
        Me.colPPSSel.Width = 60
        '
        'colPPSDel
        '
        Me.colPPSDel.Frozen = True
        Me.colPPSDel.HeaderText = ""
        Me.colPPSDel.Name = "colPPSDel"
        Me.colPPSDel.ReadOnly = True
        Me.colPPSDel.Text = "Remove"
        Me.colPPSDel.UseColumnTextForButtonValue = True
        Me.colPPSDel.Width = 60
        '
        'pnlPPS
        '
        Me.pnlPPS.Controls.Add(Me.cboPPEG)
        Me.pnlPPS.Controls.Add(Me.lblPPEG)
        Me.pnlPPS.Controls.Add(Me.cboPPEC)
        Me.pnlPPS.Controls.Add(Me.lblPPEC)
        Me.pnlPPS.Controls.Add(Me.cboPPComp)
        Me.pnlPPS.Controls.Add(Me.lblPPComp)
        Me.pnlPPS.Controls.Add(Me.chkPPNM)
        Me.pnlPPS.Controls.Add(Me.cboPPSequence)
        Me.pnlPPS.Controls.Add(Me.lblPPSequence)
        Me.pnlPPS.Controls.Add(Me.btnPPCancel)
        Me.pnlPPS.Controls.Add(Me.btnPPSave)
        Me.pnlPPS.Controls.Add(Me.txtPPPayDate)
        Me.pnlPPS.Controls.Add(Me.lblPPPayDate)
        Me.pnlPPS.Controls.Add(Me.txtPPCovTo)
        Me.pnlPPS.Controls.Add(Me.txtPPCovFrom)
        Me.pnlPPS.Controls.Add(Me.lblPPCov)
        Me.pnlPPS.Controls.Add(Me.lblPPCoverage)
        Me.pnlPPS.Controls.Add(Me.txtPPDesc)
        Me.pnlPPS.Controls.Add(Me.lblPPDesc)
        Me.pnlPPS.Controls.Add(Me.txtPPCode)
        Me.pnlPPS.Controls.Add(Me.lblPPCode)
        Me.pnlPPS.Controls.Add(Me.lblPPPDate)
        Me.pnlPPS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPPS.Location = New System.Drawing.Point(3, 3)
        Me.pnlPPS.Name = "pnlPPS"
        Me.pnlPPS.Size = New System.Drawing.Size(902, 250)
        Me.pnlPPS.TabIndex = 7
        '
        'cboPPEG
        '
        Me.cboPPEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPEG.FormattingEnabled = True
        Me.cboPPEG.Location = New System.Drawing.Point(130, 59)
        Me.cboPPEG.Name = "cboPPEG"
        Me.cboPPEG.Size = New System.Drawing.Size(350, 22)
        Me.cboPPEG.TabIndex = 60
        '
        'lblPPEG
        '
        Me.lblPPEG.AutoSize = True
        Me.lblPPEG.Location = New System.Drawing.Point(7, 62)
        Me.lblPPEG.Name = "lblPPEG"
        Me.lblPPEG.Size = New System.Drawing.Size(96, 14)
        Me.lblPPEG.TabIndex = 59
        Me.lblPPEG.Text = "Employee Group"
        '
        'cboPPEC
        '
        Me.cboPPEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPEC.FormattingEnabled = True
        Me.cboPPEC.Location = New System.Drawing.Point(130, 34)
        Me.cboPPEC.Name = "cboPPEC"
        Me.cboPPEC.Size = New System.Drawing.Size(350, 22)
        Me.cboPPEC.TabIndex = 58
        '
        'lblPPEC
        '
        Me.lblPPEC.AutoSize = True
        Me.lblPPEC.Location = New System.Drawing.Point(7, 37)
        Me.lblPPEC.Name = "lblPPEC"
        Me.lblPPEC.Size = New System.Drawing.Size(92, 14)
        Me.lblPPEC.TabIndex = 57
        Me.lblPPEC.Text = "Employee Class"
        '
        'cboPPComp
        '
        Me.cboPPComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPComp.FormattingEnabled = True
        Me.cboPPComp.Location = New System.Drawing.Point(130, 9)
        Me.cboPPComp.Name = "cboPPComp"
        Me.cboPPComp.Size = New System.Drawing.Size(350, 22)
        Me.cboPPComp.TabIndex = 56
        '
        'lblPPComp
        '
        Me.lblPPComp.AutoSize = True
        Me.lblPPComp.Location = New System.Drawing.Point(7, 12)
        Me.lblPPComp.Name = "lblPPComp"
        Me.lblPPComp.Size = New System.Drawing.Size(56, 14)
        Me.lblPPComp.TabIndex = 55
        Me.lblPPComp.Text = "Company"
        '
        'chkPPNM
        '
        Me.chkPPNM.AutoSize = True
        Me.chkPPNM.Location = New System.Drawing.Point(285, 136)
        Me.chkPPNM.Name = "chkPPNM"
        Me.chkPPNM.Size = New System.Drawing.Size(104, 18)
        Me.chkPPNM.TabIndex = 54
        Me.chkPPNM.Text = "of next month."
        Me.chkPPNM.UseVisualStyleBackColor = True
        '
        'cboPPSequence
        '
        Me.cboPPSequence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPSequence.FormattingEnabled = True
        Me.cboPPSequence.Items.AddRange(New Object() {"- Select Payroll Sequence -", "1st Payroll (Semi-Monthly)", "2nd Payroll (Semi-Monthly)"})
        Me.cboPPSequence.Location = New System.Drawing.Point(130, 184)
        Me.cboPPSequence.Name = "cboPPSequence"
        Me.cboPPSequence.Size = New System.Drawing.Size(350, 22)
        Me.cboPPSequence.TabIndex = 53
        '
        'lblPPSequence
        '
        Me.lblPPSequence.AutoSize = True
        Me.lblPPSequence.Location = New System.Drawing.Point(7, 189)
        Me.lblPPSequence.Name = "lblPPSequence"
        Me.lblPPSequence.Size = New System.Drawing.Size(100, 14)
        Me.lblPPSequence.TabIndex = 52
        Me.lblPPSequence.Text = "Payroll Sequence"
        '
        'btnPPCancel
        '
        Me.btnPPCancel.Image = CType(resources.GetObject("btnPPCancel.Image"), System.Drawing.Image)
        Me.btnPPCancel.Location = New System.Drawing.Point(210, 212)
        Me.btnPPCancel.Name = "btnPPCancel"
        Me.btnPPCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPPCancel.TabIndex = 51
        Me.btnPPCancel.Text = "Cancel"
        Me.btnPPCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPPCancel.UseVisualStyleBackColor = True
        '
        'btnPPSave
        '
        Me.btnPPSave.Image = CType(resources.GetObject("btnPPSave.Image"), System.Drawing.Image)
        Me.btnPPSave.Location = New System.Drawing.Point(130, 212)
        Me.btnPPSave.Name = "btnPPSave"
        Me.btnPPSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPPSave.TabIndex = 50
        Me.btnPPSave.Text = "Save"
        Me.btnPPSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPPSave.UseVisualStyleBackColor = True
        '
        'txtPPPayDate
        '
        Me.txtPPPayDate.Location = New System.Drawing.Point(167, 159)
        Me.txtPPPayDate.MaxLength = 2
        Me.txtPPPayDate.Name = "txtPPPayDate"
        Me.txtPPPayDate.Size = New System.Drawing.Size(41, 22)
        Me.txtPPPayDate.TabIndex = 9
        Me.txtPPPayDate.Text = "1"
        Me.txtPPPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPPPayDate
        '
        Me.lblPPPayDate.AutoSize = True
        Me.lblPPPayDate.Location = New System.Drawing.Point(7, 162)
        Me.lblPPPayDate.Name = "lblPPPayDate"
        Me.lblPPPayDate.Size = New System.Drawing.Size(50, 14)
        Me.lblPPPayDate.TabIndex = 8
        Me.lblPPPayDate.Text = "Paydate"
        '
        'txtPPCovTo
        '
        Me.txtPPCovTo.Location = New System.Drawing.Point(238, 134)
        Me.txtPPCovTo.MaxLength = 2
        Me.txtPPCovTo.Name = "txtPPCovTo"
        Me.txtPPCovTo.Size = New System.Drawing.Size(41, 22)
        Me.txtPPCovTo.TabIndex = 7
        Me.txtPPCovTo.Text = "31"
        Me.txtPPCovTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPPCovFrom
        '
        Me.txtPPCovFrom.Location = New System.Drawing.Point(167, 134)
        Me.txtPPCovFrom.MaxLength = 2
        Me.txtPPCovFrom.Name = "txtPPCovFrom"
        Me.txtPPCovFrom.Size = New System.Drawing.Size(41, 22)
        Me.txtPPCovFrom.TabIndex = 6
        Me.txtPPCovFrom.Text = "1"
        Me.txtPPCovFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPPCov
        '
        Me.lblPPCov.AutoSize = True
        Me.lblPPCov.Location = New System.Drawing.Point(127, 137)
        Me.lblPPCov.Name = "lblPPCov"
        Me.lblPPCov.Size = New System.Drawing.Size(105, 14)
        Me.lblPPCov.TabIndex = 5
        Me.lblPPCov.Text = "From                    to"
        '
        'lblPPCoverage
        '
        Me.lblPPCoverage.AutoSize = True
        Me.lblPPCoverage.Location = New System.Drawing.Point(7, 137)
        Me.lblPPCoverage.Name = "lblPPCoverage"
        Me.lblPPCoverage.Size = New System.Drawing.Size(80, 14)
        Me.lblPPCoverage.TabIndex = 4
        Me.lblPPCoverage.Text = "Cut-off Period"
        '
        'txtPPDesc
        '
        Me.txtPPDesc.Location = New System.Drawing.Point(130, 109)
        Me.txtPPDesc.MaxLength = 150
        Me.txtPPDesc.Name = "txtPPDesc"
        Me.txtPPDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtPPDesc.TabIndex = 3
        '
        'lblPPDesc
        '
        Me.lblPPDesc.AutoSize = True
        Me.lblPPDesc.Location = New System.Drawing.Point(7, 112)
        Me.lblPPDesc.Name = "lblPPDesc"
        Me.lblPPDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblPPDesc.TabIndex = 2
        Me.lblPPDesc.Text = "Description"
        '
        'txtPPCode
        '
        Me.txtPPCode.Location = New System.Drawing.Point(130, 84)
        Me.txtPPCode.MaxLength = 25
        Me.txtPPCode.Name = "txtPPCode"
        Me.txtPPCode.Size = New System.Drawing.Size(150, 22)
        Me.txtPPCode.TabIndex = 1
        '
        'lblPPCode
        '
        Me.lblPPCode.AutoSize = True
        Me.lblPPCode.Location = New System.Drawing.Point(7, 87)
        Me.lblPPCode.Name = "lblPPCode"
        Me.lblPPCode.Size = New System.Drawing.Size(87, 14)
        Me.lblPPCode.TabIndex = 0
        Me.lblPPCode.Text = "Schedule Code"
        '
        'lblPPPDate
        '
        Me.lblPPPDate.AutoSize = True
        Me.lblPPPDate.Location = New System.Drawing.Point(127, 162)
        Me.lblPPPDate.Name = "lblPPPDate"
        Me.lblPPPDate.Size = New System.Drawing.Size(161, 14)
        Me.lblPPPDate.TabIndex = 10
        Me.lblPPPDate.Text = "Every                   of the month"
        '
        'tpPPR
        '
        Me.tpPPR.AutoScroll = True
        Me.tpPPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPPR.Controls.Add(Me.tcRates)
        Me.tpPPR.Location = New System.Drawing.Point(4, 23)
        Me.tpPPR.Name = "tpPPR"
        Me.tpPPR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPPR.Size = New System.Drawing.Size(910, 459)
        Me.tpPPR.TabIndex = 4
        Me.tpPPR.Text = "Premium Rates"
        Me.tpPPR.UseVisualStyleBackColor = True
        '
        'tcRates
        '
        Me.tcRates.Controls.Add(Me.tpRateList)
        Me.tcRates.Controls.Add(Me.tpRPR)
        Me.tcRates.Controls.Add(Me.tpSPC)
        Me.tcRates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcRates.Location = New System.Drawing.Point(3, 3)
        Me.tcRates.Name = "tcRates"
        Me.tcRates.SelectedIndex = 0
        Me.tcRates.Size = New System.Drawing.Size(902, 451)
        Me.tcRates.TabIndex = 10
        '
        'tpRateList
        '
        Me.tpRateList.AutoScroll = True
        Me.tpRateList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpRateList.Controls.Add(Me.dgvPR)
        Me.tpRateList.Controls.Add(Me.pnlPR)
        Me.tpRateList.Location = New System.Drawing.Point(4, 23)
        Me.tpRateList.Name = "tpRateList"
        Me.tpRateList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRateList.Size = New System.Drawing.Size(894, 424)
        Me.tpRateList.TabIndex = 2
        Me.tpRateList.Text = "Setup Rates"
        Me.tpRateList.UseVisualStyleBackColor = True
        '
        'dgvPR
        '
        Me.dgvPR.AllowUserToAddRows = False
        Me.dgvPR.AllowUserToDeleteRows = False
        Me.dgvPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSRSel, Me.colSRDel})
        Me.dgvPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPR.Location = New System.Drawing.Point(3, 205)
        Me.dgvPR.Name = "dgvPR"
        Me.dgvPR.ReadOnly = True
        Me.dgvPR.Size = New System.Drawing.Size(886, 214)
        Me.dgvPR.TabIndex = 11
        '
        'colSRSel
        '
        Me.colSRSel.Frozen = True
        Me.colSRSel.HeaderText = ""
        Me.colSRSel.Name = "colSRSel"
        Me.colSRSel.ReadOnly = True
        Me.colSRSel.Text = "Select"
        Me.colSRSel.UseColumnTextForButtonValue = True
        Me.colSRSel.Width = 60
        '
        'colSRDel
        '
        Me.colSRDel.Frozen = True
        Me.colSRDel.HeaderText = ""
        Me.colSRDel.Name = "colSRDel"
        Me.colSRDel.ReadOnly = True
        Me.colSRDel.Text = "Remove"
        Me.colSRDel.UseColumnTextForButtonValue = True
        Me.colSRDel.Width = 60
        '
        'pnlPR
        '
        Me.pnlPR.Controls.Add(Me.btnPRCancel)
        Me.pnlPR.Controls.Add(Me.btnPRSave)
        Me.pnlPR.Controls.Add(Me.lblRSDesc)
        Me.pnlPR.Controls.Add(Me.txtRSDesc)
        Me.pnlPR.Controls.Add(Me.txtRSCode)
        Me.pnlPR.Controls.Add(Me.lblRSCode)
        Me.pnlPR.Controls.Add(Me.chkRSSC)
        Me.pnlPR.Controls.Add(Me.cboRSDept)
        Me.pnlPR.Controls.Add(Me.lblRSDept)
        Me.pnlPR.Controls.Add(Me.cboRSPB)
        Me.pnlPR.Controls.Add(Me.lblRSPB)
        Me.pnlPR.Controls.Add(Me.cboRSComp)
        Me.pnlPR.Controls.Add(Me.lblRSComp)
        Me.pnlPR.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPR.Location = New System.Drawing.Point(3, 3)
        Me.pnlPR.Name = "pnlPR"
        Me.pnlPR.Size = New System.Drawing.Size(886, 202)
        Me.pnlPR.TabIndex = 10
        '
        'btnPRCancel
        '
        Me.btnPRCancel.Image = CType(resources.GetObject("btnPRCancel.Image"), System.Drawing.Image)
        Me.btnPRCancel.Location = New System.Drawing.Point(210, 161)
        Me.btnPRCancel.Name = "btnPRCancel"
        Me.btnPRCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPRCancel.TabIndex = 62
        Me.btnPRCancel.Text = "Cancel"
        Me.btnPRCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPRCancel.UseVisualStyleBackColor = True
        '
        'btnPRSave
        '
        Me.btnPRSave.Image = CType(resources.GetObject("btnPRSave.Image"), System.Drawing.Image)
        Me.btnPRSave.Location = New System.Drawing.Point(130, 161)
        Me.btnPRSave.Name = "btnPRSave"
        Me.btnPRSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPRSave.TabIndex = 61
        Me.btnPRSave.Text = "Save"
        Me.btnPRSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPRSave.UseVisualStyleBackColor = True
        '
        'lblRSDesc
        '
        Me.lblRSDesc.AutoSize = True
        Me.lblRSDesc.Location = New System.Drawing.Point(7, 38)
        Me.lblRSDesc.Name = "lblRSDesc"
        Me.lblRSDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblRSDesc.TabIndex = 60
        Me.lblRSDesc.Text = "Description"
        '
        'txtRSDesc
        '
        Me.txtRSDesc.Location = New System.Drawing.Point(130, 35)
        Me.txtRSDesc.MaxLength = 150
        Me.txtRSDesc.Name = "txtRSDesc"
        Me.txtRSDesc.Size = New System.Drawing.Size(350, 22)
        Me.txtRSDesc.TabIndex = 59
        '
        'txtRSCode
        '
        Me.txtRSCode.Location = New System.Drawing.Point(130, 10)
        Me.txtRSCode.MaxLength = 25
        Me.txtRSCode.Name = "txtRSCode"
        Me.txtRSCode.Size = New System.Drawing.Size(150, 22)
        Me.txtRSCode.TabIndex = 58
        '
        'lblRSCode
        '
        Me.lblRSCode.AutoSize = True
        Me.lblRSCode.Location = New System.Drawing.Point(7, 13)
        Me.lblRSCode.Name = "lblRSCode"
        Me.lblRSCode.Size = New System.Drawing.Size(73, 14)
        Me.lblRSCode.TabIndex = 57
        Me.lblRSCode.Text = "Setting Code"
        '
        'chkRSSC
        '
        Me.chkRSSC.AutoSize = True
        Me.chkRSSC.Location = New System.Drawing.Point(130, 137)
        Me.chkRSSC.Name = "chkRSSC"
        Me.chkRSSC.Size = New System.Drawing.Size(203, 18)
        Me.chkRSSC.TabIndex = 56
        Me.chkRSSC.Text = "Use Custom Rates (Cost-Sharing)"
        Me.chkRSSC.UseVisualStyleBackColor = True
        '
        'cboRSDept
        '
        Me.cboRSDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRSDept.FormattingEnabled = True
        Me.cboRSDept.Location = New System.Drawing.Point(130, 85)
        Me.cboRSDept.Name = "cboRSDept"
        Me.cboRSDept.Size = New System.Drawing.Size(350, 22)
        Me.cboRSDept.TabIndex = 55
        '
        'lblRSDept
        '
        Me.lblRSDept.AutoSize = True
        Me.lblRSDept.Location = New System.Drawing.Point(7, 88)
        Me.lblRSDept.Name = "lblRSDept"
        Me.lblRSDept.Size = New System.Drawing.Size(109, 14)
        Me.lblRSDept.TabIndex = 54
        Me.lblRSDept.Text = "Department/Client"
        '
        'cboRSPB
        '
        Me.cboRSPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRSPB.FormattingEnabled = True
        Me.cboRSPB.Location = New System.Drawing.Point(130, 110)
        Me.cboRSPB.Name = "cboRSPB"
        Me.cboRSPB.Size = New System.Drawing.Size(350, 22)
        Me.cboRSPB.TabIndex = 53
        '
        'lblRSPB
        '
        Me.lblRSPB.AutoSize = True
        Me.lblRSPB.Location = New System.Drawing.Point(7, 113)
        Me.lblRSPB.Name = "lblRSPB"
        Me.lblRSPB.Size = New System.Drawing.Size(58, 14)
        Me.lblRSPB.TabIndex = 52
        Me.lblRSPB.Text = "Pay Basis"
        '
        'cboRSComp
        '
        Me.cboRSComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRSComp.FormattingEnabled = True
        Me.cboRSComp.Location = New System.Drawing.Point(130, 60)
        Me.cboRSComp.Name = "cboRSComp"
        Me.cboRSComp.Size = New System.Drawing.Size(350, 22)
        Me.cboRSComp.TabIndex = 3
        '
        'lblRSComp
        '
        Me.lblRSComp.AutoSize = True
        Me.lblRSComp.Location = New System.Drawing.Point(7, 63)
        Me.lblRSComp.Name = "lblRSComp"
        Me.lblRSComp.Size = New System.Drawing.Size(56, 14)
        Me.lblRSComp.TabIndex = 2
        Me.lblRSComp.Text = "Company"
        '
        'tpRPR
        '
        Me.tpRPR.AutoScroll = True
        Me.tpRPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpRPR.Controls.Add(Me.pnlPRStandard)
        Me.tpRPR.Controls.Add(Me.lblPRDH)
        Me.tpRPR.Controls.Add(Me.txtPRDHOTND)
        Me.tpRPR.Controls.Add(Me.txtPRDHND)
        Me.tpRPR.Controls.Add(Me.txtPRDHOT)
        Me.tpRPR.Controls.Add(Me.txtPRDH)
        Me.tpRPR.Controls.Add(Me.lblPRRH)
        Me.tpRPR.Controls.Add(Me.txtPRRHOTND)
        Me.tpRPR.Controls.Add(Me.txtPRRHND)
        Me.tpRPR.Controls.Add(Me.txtPRRHOT)
        Me.tpRPR.Controls.Add(Me.txtPRRH)
        Me.tpRPR.Controls.Add(Me.lblPRSH)
        Me.tpRPR.Controls.Add(Me.txtPRSHOTND)
        Me.tpRPR.Controls.Add(Me.txtPRSHND)
        Me.tpRPR.Controls.Add(Me.txtPRSHOT)
        Me.tpRPR.Controls.Add(Me.txtPRSH)
        Me.tpRPR.Controls.Add(Me.lblPRRDDH)
        Me.tpRPR.Controls.Add(Me.txtPRRDDHOTND)
        Me.tpRPR.Controls.Add(Me.txtPRRDDHND)
        Me.tpRPR.Controls.Add(Me.txtPRRDDHOT)
        Me.tpRPR.Controls.Add(Me.txtPRRDDH)
        Me.tpRPR.Controls.Add(Me.lblPRRDRH)
        Me.tpRPR.Controls.Add(Me.txtPRRDRHOTND)
        Me.tpRPR.Controls.Add(Me.txtPRRDRHND)
        Me.tpRPR.Controls.Add(Me.txtPRRDRHOT)
        Me.tpRPR.Controls.Add(Me.txtPRRDRH)
        Me.tpRPR.Controls.Add(Me.lblPRRDSH)
        Me.tpRPR.Controls.Add(Me.txtPRRDSHOTND)
        Me.tpRPR.Controls.Add(Me.txtPRRDSHND)
        Me.tpRPR.Controls.Add(Me.txtPRRDSHOT)
        Me.tpRPR.Controls.Add(Me.txtPRRDSH)
        Me.tpRPR.Controls.Add(Me.lblPRRD)
        Me.tpRPR.Controls.Add(Me.txtPRRDOTND)
        Me.tpRPR.Controls.Add(Me.txtPRRDND)
        Me.tpRPR.Controls.Add(Me.txtPRRDOT)
        Me.tpRPR.Controls.Add(Me.txtPRRD)
        Me.tpRPR.Controls.Add(Me.txtPRRegOTND)
        Me.tpRPR.Controls.Add(Me.txtPRRegND)
        Me.tpRPR.Controls.Add(Me.txtPRRegOT)
        Me.tpRPR.Controls.Add(Me.txtPRReg)
        Me.tpRPR.Controls.Add(Me.lblRegOTNS)
        Me.tpRPR.Controls.Add(Me.lblRegNS)
        Me.tpRPR.Controls.Add(Me.lblRegOT)
        Me.tpRPR.Controls.Add(Me.lblRegBR)
        Me.tpRPR.Controls.Add(Me.lblPRReg)
        Me.tpRPR.Location = New System.Drawing.Point(4, 23)
        Me.tpRPR.Name = "tpRPR"
        Me.tpRPR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRPR.Size = New System.Drawing.Size(894, 425)
        Me.tpRPR.TabIndex = 0
        Me.tpRPR.Text = "Standard Premium Rates"
        Me.tpRPR.UseVisualStyleBackColor = True
        '
        'pnlPRStandard
        '
        Me.pnlPRStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPRStandard.Controls.Add(Me.btnPRStdCancel)
        Me.pnlPRStandard.Controls.Add(Me.lblPRCompStd)
        Me.pnlPRStandard.Controls.Add(Me.btnPRStdSave)
        Me.pnlPRStandard.Controls.Add(Me.cboPRCompStd)
        Me.pnlPRStandard.Controls.Add(Me.Label1)
        Me.pnlPRStandard.Controls.Add(Me.cboPRStandard)
        Me.pnlPRStandard.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPRStandard.Location = New System.Drawing.Point(3, 3)
        Me.pnlPRStandard.Name = "pnlPRStandard"
        Me.pnlPRStandard.Size = New System.Drawing.Size(886, 92)
        Me.pnlPRStandard.TabIndex = 44
        '
        'btnPRStdCancel
        '
        Me.btnPRStdCancel.Image = CType(resources.GetObject("btnPRStdCancel.Image"), System.Drawing.Image)
        Me.btnPRStdCancel.Location = New System.Drawing.Point(178, 56)
        Me.btnPRStdCancel.Name = "btnPRStdCancel"
        Me.btnPRStdCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPRStdCancel.TabIndex = 64
        Me.btnPRStdCancel.Text = "Cancel"
        Me.btnPRStdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPRStdCancel.UseVisualStyleBackColor = True
        '
        'lblPRCompStd
        '
        Me.lblPRCompStd.AutoSize = True
        Me.lblPRCompStd.Location = New System.Drawing.Point(3, 7)
        Me.lblPRCompStd.Name = "lblPRCompStd"
        Me.lblPRCompStd.Size = New System.Drawing.Size(56, 14)
        Me.lblPRCompStd.TabIndex = 3
        Me.lblPRCompStd.Text = "Company"
        '
        'btnPRStdSave
        '
        Me.btnPRStdSave.Image = CType(resources.GetObject("btnPRStdSave.Image"), System.Drawing.Image)
        Me.btnPRStdSave.Location = New System.Drawing.Point(98, 56)
        Me.btnPRStdSave.Name = "btnPRStdSave"
        Me.btnPRStdSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPRStdSave.TabIndex = 63
        Me.btnPRStdSave.Text = "Save"
        Me.btnPRStdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPRStdSave.UseVisualStyleBackColor = True
        '
        'cboPRCompStd
        '
        Me.cboPRCompStd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPRCompStd.FormattingEnabled = True
        Me.cboPRCompStd.Location = New System.Drawing.Point(98, 4)
        Me.cboPRCompStd.Name = "cboPRCompStd"
        Me.cboPRCompStd.Size = New System.Drawing.Size(450, 22)
        Me.cboPRCompStd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rate Setting"
        '
        'cboPRStandard
        '
        Me.cboPRStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPRStandard.FormattingEnabled = True
        Me.cboPRStandard.Location = New System.Drawing.Point(98, 29)
        Me.cboPRStandard.Name = "cboPRStandard"
        Me.cboPRStandard.Size = New System.Drawing.Size(450, 22)
        Me.cboPRStandard.TabIndex = 0
        '
        'lblPRDH
        '
        Me.lblPRDH.AutoSize = True
        Me.lblPRDH.Location = New System.Drawing.Point(13, 307)
        Me.lblPRDH.Name = "lblPRDH"
        Me.lblPRDH.Size = New System.Drawing.Size(92, 14)
        Me.lblPRDH.TabIndex = 43
        Me.lblPRDH.Text = "Double Holiday"
        '
        'txtPRDHOTND
        '
        Me.txtPRDHOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHOTND.Location = New System.Drawing.Point(725, 304)
        Me.txtPRDHOTND.MaxLength = 10
        Me.txtPRDHOTND.Name = "txtPRDHOTND"
        Me.txtPRDHOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHOTND.TabIndex = 42
        Me.txtPRDHOTND.Text = "0.0000"
        Me.txtPRDHOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDHND
        '
        Me.txtPRDHND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHND.Location = New System.Drawing.Point(576, 304)
        Me.txtPRDHND.MaxLength = 10
        Me.txtPRDHND.Name = "txtPRDHND"
        Me.txtPRDHND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHND.TabIndex = 41
        Me.txtPRDHND.Text = "0.0000"
        Me.txtPRDHND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDHOT
        '
        Me.txtPRDHOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHOT.Location = New System.Drawing.Point(426, 304)
        Me.txtPRDHOT.MaxLength = 10
        Me.txtPRDHOT.Name = "txtPRDHOT"
        Me.txtPRDHOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHOT.TabIndex = 40
        Me.txtPRDHOT.Text = "0.0000"
        Me.txtPRDHOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDH
        '
        Me.txtPRDH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDH.Location = New System.Drawing.Point(275, 304)
        Me.txtPRDH.MaxLength = 10
        Me.txtPRDH.Name = "txtPRDH"
        Me.txtPRDH.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDH.TabIndex = 39
        Me.txtPRDH.Text = "0.0000"
        Me.txtPRDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRRH
        '
        Me.lblPRRH.AutoSize = True
        Me.lblPRRH.Location = New System.Drawing.Point(13, 282)
        Me.lblPRRH.Name = "lblPRRH"
        Me.lblPRRH.Size = New System.Drawing.Size(94, 14)
        Me.lblPRRH.TabIndex = 38
        Me.lblPRRH.Text = "Regular Holiday"
        '
        'txtPRRHOTND
        '
        Me.txtPRRHOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHOTND.Location = New System.Drawing.Point(725, 279)
        Me.txtPRRHOTND.MaxLength = 10
        Me.txtPRRHOTND.Name = "txtPRRHOTND"
        Me.txtPRRHOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHOTND.TabIndex = 37
        Me.txtPRRHOTND.Text = "0.0000"
        Me.txtPRRHOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHND
        '
        Me.txtPRRHND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHND.Location = New System.Drawing.Point(576, 279)
        Me.txtPRRHND.MaxLength = 10
        Me.txtPRRHND.Name = "txtPRRHND"
        Me.txtPRRHND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHND.TabIndex = 36
        Me.txtPRRHND.Text = "0.0000"
        Me.txtPRRHND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHOT
        '
        Me.txtPRRHOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHOT.Location = New System.Drawing.Point(426, 279)
        Me.txtPRRHOT.MaxLength = 10
        Me.txtPRRHOT.Name = "txtPRRHOT"
        Me.txtPRRHOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHOT.TabIndex = 35
        Me.txtPRRHOT.Text = "0.0000"
        Me.txtPRRHOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRH
        '
        Me.txtPRRH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRH.Location = New System.Drawing.Point(275, 279)
        Me.txtPRRH.MaxLength = 10
        Me.txtPRRH.Name = "txtPRRH"
        Me.txtPRRH.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRH.TabIndex = 34
        Me.txtPRRH.Text = "0.0000"
        Me.txtPRRH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSH
        '
        Me.lblPRSH.AutoSize = True
        Me.lblPRSH.Location = New System.Drawing.Point(13, 257)
        Me.lblPRSH.Name = "lblPRSH"
        Me.lblPRSH.Size = New System.Drawing.Size(92, 14)
        Me.lblPRSH.TabIndex = 33
        Me.lblPRSH.Text = "Special Holiday"
        '
        'txtPRSHOTND
        '
        Me.txtPRSHOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHOTND.Location = New System.Drawing.Point(725, 254)
        Me.txtPRSHOTND.MaxLength = 10
        Me.txtPRSHOTND.Name = "txtPRSHOTND"
        Me.txtPRSHOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHOTND.TabIndex = 32
        Me.txtPRSHOTND.Text = "0.0000"
        Me.txtPRSHOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHND
        '
        Me.txtPRSHND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHND.Location = New System.Drawing.Point(576, 254)
        Me.txtPRSHND.MaxLength = 10
        Me.txtPRSHND.Name = "txtPRSHND"
        Me.txtPRSHND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHND.TabIndex = 31
        Me.txtPRSHND.Text = "0.0000"
        Me.txtPRSHND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHOT
        '
        Me.txtPRSHOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHOT.Location = New System.Drawing.Point(426, 254)
        Me.txtPRSHOT.MaxLength = 10
        Me.txtPRSHOT.Name = "txtPRSHOT"
        Me.txtPRSHOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHOT.TabIndex = 30
        Me.txtPRSHOT.Text = "0.0000"
        Me.txtPRSHOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSH
        '
        Me.txtPRSH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSH.Location = New System.Drawing.Point(275, 254)
        Me.txtPRSH.MaxLength = 10
        Me.txtPRSH.Name = "txtPRSH"
        Me.txtPRSH.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSH.TabIndex = 29
        Me.txtPRSH.Text = "0.0000"
        Me.txtPRSH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRRDDH
        '
        Me.lblPRRDDH.AutoSize = True
        Me.lblPRRDDH.Location = New System.Drawing.Point(13, 232)
        Me.lblPRRDDH.Name = "lblPRRDDH"
        Me.lblPRRDDH.Size = New System.Drawing.Size(155, 14)
        Me.lblPRRDDH.TabIndex = 28
        Me.lblPRRDDH.Text = "Restday on Double Holiday"
        '
        'txtPRRDDHOTND
        '
        Me.txtPRRDDHOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHOTND.Location = New System.Drawing.Point(725, 229)
        Me.txtPRRDDHOTND.MaxLength = 10
        Me.txtPRRDDHOTND.Name = "txtPRRDDHOTND"
        Me.txtPRRDDHOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHOTND.TabIndex = 27
        Me.txtPRRDDHOTND.Text = "0.0000"
        Me.txtPRRDDHOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHND
        '
        Me.txtPRRDDHND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHND.Location = New System.Drawing.Point(576, 229)
        Me.txtPRRDDHND.MaxLength = 10
        Me.txtPRRDDHND.Name = "txtPRRDDHND"
        Me.txtPRRDDHND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHND.TabIndex = 26
        Me.txtPRRDDHND.Text = "0.0000"
        Me.txtPRRDDHND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHOT
        '
        Me.txtPRRDDHOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHOT.Location = New System.Drawing.Point(426, 229)
        Me.txtPRRDDHOT.MaxLength = 10
        Me.txtPRRDDHOT.Name = "txtPRRDDHOT"
        Me.txtPRRDDHOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHOT.TabIndex = 25
        Me.txtPRRDDHOT.Text = "0.0000"
        Me.txtPRRDDHOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDH
        '
        Me.txtPRRDDH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDH.Location = New System.Drawing.Point(275, 229)
        Me.txtPRRDDH.MaxLength = 10
        Me.txtPRRDDH.Name = "txtPRRDDH"
        Me.txtPRRDDH.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDH.TabIndex = 24
        Me.txtPRRDDH.Text = "0.0000"
        Me.txtPRRDDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRRDRH
        '
        Me.lblPRRDRH.AutoSize = True
        Me.lblPRRDRH.Location = New System.Drawing.Point(13, 207)
        Me.lblPRRDRH.Name = "lblPRRDRH"
        Me.lblPRRDRH.Size = New System.Drawing.Size(157, 14)
        Me.lblPRRDRH.TabIndex = 23
        Me.lblPRRDRH.Text = "Restday on Regular Holiday"
        '
        'txtPRRDRHOTND
        '
        Me.txtPRRDRHOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHOTND.Location = New System.Drawing.Point(725, 204)
        Me.txtPRRDRHOTND.MaxLength = 10
        Me.txtPRRDRHOTND.Name = "txtPRRDRHOTND"
        Me.txtPRRDRHOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHOTND.TabIndex = 22
        Me.txtPRRDRHOTND.Text = "0.0000"
        Me.txtPRRDRHOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHND
        '
        Me.txtPRRDRHND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHND.Location = New System.Drawing.Point(576, 204)
        Me.txtPRRDRHND.MaxLength = 10
        Me.txtPRRDRHND.Name = "txtPRRDRHND"
        Me.txtPRRDRHND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHND.TabIndex = 21
        Me.txtPRRDRHND.Text = "0.0000"
        Me.txtPRRDRHND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHOT
        '
        Me.txtPRRDRHOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHOT.Location = New System.Drawing.Point(426, 204)
        Me.txtPRRDRHOT.MaxLength = 10
        Me.txtPRRDRHOT.Name = "txtPRRDRHOT"
        Me.txtPRRDRHOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHOT.TabIndex = 20
        Me.txtPRRDRHOT.Text = "0.0000"
        Me.txtPRRDRHOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRH
        '
        Me.txtPRRDRH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRH.Location = New System.Drawing.Point(275, 204)
        Me.txtPRRDRH.MaxLength = 10
        Me.txtPRRDRH.Name = "txtPRRDRH"
        Me.txtPRRDRH.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRH.TabIndex = 19
        Me.txtPRRDRH.Text = "0.0000"
        Me.txtPRRDRH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRRDSH
        '
        Me.lblPRRDSH.AutoSize = True
        Me.lblPRRDSH.Location = New System.Drawing.Point(13, 182)
        Me.lblPRRDSH.Name = "lblPRRDSH"
        Me.lblPRRDSH.Size = New System.Drawing.Size(155, 14)
        Me.lblPRRDSH.TabIndex = 18
        Me.lblPRRDSH.Text = "Restday on Special Holiday"
        '
        'txtPRRDSHOTND
        '
        Me.txtPRRDSHOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHOTND.Location = New System.Drawing.Point(725, 179)
        Me.txtPRRDSHOTND.MaxLength = 10
        Me.txtPRRDSHOTND.Name = "txtPRRDSHOTND"
        Me.txtPRRDSHOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHOTND.TabIndex = 17
        Me.txtPRRDSHOTND.Text = "0.0000"
        Me.txtPRRDSHOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHND
        '
        Me.txtPRRDSHND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHND.Location = New System.Drawing.Point(576, 179)
        Me.txtPRRDSHND.MaxLength = 10
        Me.txtPRRDSHND.Name = "txtPRRDSHND"
        Me.txtPRRDSHND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHND.TabIndex = 16
        Me.txtPRRDSHND.Text = "0.0000"
        Me.txtPRRDSHND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHOT
        '
        Me.txtPRRDSHOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHOT.Location = New System.Drawing.Point(426, 179)
        Me.txtPRRDSHOT.MaxLength = 10
        Me.txtPRRDSHOT.Name = "txtPRRDSHOT"
        Me.txtPRRDSHOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHOT.TabIndex = 15
        Me.txtPRRDSHOT.Text = "0.0000"
        Me.txtPRRDSHOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSH
        '
        Me.txtPRRDSH.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSH.Location = New System.Drawing.Point(275, 179)
        Me.txtPRRDSH.MaxLength = 10
        Me.txtPRRDSH.Name = "txtPRRDSH"
        Me.txtPRRDSH.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSH.TabIndex = 14
        Me.txtPRRDSH.Text = "0.0000"
        Me.txtPRRDSH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRRD
        '
        Me.lblPRRD.AutoSize = True
        Me.lblPRRD.Location = New System.Drawing.Point(13, 157)
        Me.lblPRRD.Name = "lblPRRD"
        Me.lblPRRD.Size = New System.Drawing.Size(50, 14)
        Me.lblPRRD.TabIndex = 13
        Me.lblPRRD.Text = "Restday"
        '
        'txtPRRDOTND
        '
        Me.txtPRRDOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDOTND.Location = New System.Drawing.Point(725, 154)
        Me.txtPRRDOTND.MaxLength = 10
        Me.txtPRRDOTND.Name = "txtPRRDOTND"
        Me.txtPRRDOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDOTND.TabIndex = 12
        Me.txtPRRDOTND.Text = "0.0000"
        Me.txtPRRDOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDND
        '
        Me.txtPRRDND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDND.Location = New System.Drawing.Point(576, 154)
        Me.txtPRRDND.MaxLength = 10
        Me.txtPRRDND.Name = "txtPRRDND"
        Me.txtPRRDND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDND.TabIndex = 11
        Me.txtPRRDND.Text = "0.0000"
        Me.txtPRRDND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDOT
        '
        Me.txtPRRDOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDOT.Location = New System.Drawing.Point(426, 154)
        Me.txtPRRDOT.MaxLength = 10
        Me.txtPRRDOT.Name = "txtPRRDOT"
        Me.txtPRRDOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDOT.TabIndex = 10
        Me.txtPRRDOT.Text = "0.0000"
        Me.txtPRRDOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRD
        '
        Me.txtPRRD.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRD.Location = New System.Drawing.Point(275, 154)
        Me.txtPRRD.MaxLength = 10
        Me.txtPRRD.Name = "txtPRRD"
        Me.txtPRRD.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRD.TabIndex = 9
        Me.txtPRRD.Text = "0.0000"
        Me.txtPRRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegOTND
        '
        Me.txtPRRegOTND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegOTND.Location = New System.Drawing.Point(725, 129)
        Me.txtPRRegOTND.MaxLength = 10
        Me.txtPRRegOTND.Name = "txtPRRegOTND"
        Me.txtPRRegOTND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegOTND.TabIndex = 8
        Me.txtPRRegOTND.Text = "0.0000"
        Me.txtPRRegOTND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegND
        '
        Me.txtPRRegND.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegND.Location = New System.Drawing.Point(576, 129)
        Me.txtPRRegND.MaxLength = 10
        Me.txtPRRegND.Name = "txtPRRegND"
        Me.txtPRRegND.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegND.TabIndex = 7
        Me.txtPRRegND.Text = "0.0000"
        Me.txtPRRegND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegOT
        '
        Me.txtPRRegOT.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegOT.Location = New System.Drawing.Point(426, 129)
        Me.txtPRRegOT.MaxLength = 10
        Me.txtPRRegOT.Name = "txtPRRegOT"
        Me.txtPRRegOT.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegOT.TabIndex = 6
        Me.txtPRRegOT.Text = "0.0000"
        Me.txtPRRegOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRReg
        '
        Me.txtPRReg.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRReg.Location = New System.Drawing.Point(275, 129)
        Me.txtPRReg.MaxLength = 10
        Me.txtPRReg.Name = "txtPRReg"
        Me.txtPRReg.Size = New System.Drawing.Size(60, 22)
        Me.txtPRReg.TabIndex = 5
        Me.txtPRReg.Text = "0.0000"
        Me.txtPRReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRegOTNS
        '
        Me.lblRegOTNS.Location = New System.Drawing.Point(690, 105)
        Me.lblRegOTNS.Name = "lblRegOTNS"
        Me.lblRegOTNS.Size = New System.Drawing.Size(130, 16)
        Me.lblRegOTNS.TabIndex = 4
        Me.lblRegOTNS.Text = "+ (OT + NS)"
        Me.lblRegOTNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegNS
        '
        Me.lblRegNS.Location = New System.Drawing.Point(540, 105)
        Me.lblRegNS.Name = "lblRegNS"
        Me.lblRegNS.Size = New System.Drawing.Size(130, 16)
        Me.lblRegNS.TabIndex = 3
        Me.lblRegNS.Text = "+ Night Shift"
        Me.lblRegNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegOT
        '
        Me.lblRegOT.Location = New System.Drawing.Point(390, 105)
        Me.lblRegOT.Name = "lblRegOT"
        Me.lblRegOT.Size = New System.Drawing.Size(130, 16)
        Me.lblRegOT.TabIndex = 2
        Me.lblRegOT.Text = "+ Overtime"
        Me.lblRegOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegBR
        '
        Me.lblRegBR.Location = New System.Drawing.Point(240, 105)
        Me.lblRegBR.Name = "lblRegBR"
        Me.lblRegBR.Size = New System.Drawing.Size(130, 16)
        Me.lblRegBR.TabIndex = 1
        Me.lblRegBR.Text = "Base Rate"
        Me.lblRegBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRReg
        '
        Me.lblPRReg.AutoSize = True
        Me.lblPRReg.Location = New System.Drawing.Point(13, 132)
        Me.lblPRReg.Name = "lblPRReg"
        Me.lblPRReg.Size = New System.Drawing.Size(72, 14)
        Me.lblPRReg.TabIndex = 0
        Me.lblPRReg.Text = "Regular Day"
        '
        'tpSPC
        '
        Me.tpSPC.AutoScroll = True
        Me.tpSPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSPC.Controls.Add(Me.lblPRS4A)
        Me.tpSPC.Controls.Add(Me.lblPRS3A)
        Me.tpSPC.Controls.Add(Me.lblPRS2A)
        Me.tpSPC.Controls.Add(Me.lblPRS1A)
        Me.tpSPC.Controls.Add(Me.pnlPRCustom)
        Me.tpSPC.Controls.Add(Me.lblPRS4)
        Me.tpSPC.Controls.Add(Me.lblPRS3)
        Me.tpSPC.Controls.Add(Me.lblPRS2)
        Me.tpSPC.Controls.Add(Me.lblPRS1)
        Me.tpSPC.Controls.Add(Me.txtPRDHOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRHOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRSHOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDDHOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDRHOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDSHOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRegOTNS1)
        Me.tpSPC.Controls.Add(Me.txtPRDHNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRHNS1)
        Me.tpSPC.Controls.Add(Me.txtPRSHNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDDHNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDRHNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDSHNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRDNS1)
        Me.tpSPC.Controls.Add(Me.txtPRRegNS1)
        Me.tpSPC.Controls.Add(Me.txtPRDHOT1)
        Me.tpSPC.Controls.Add(Me.txtPRRHOT1)
        Me.tpSPC.Controls.Add(Me.txtPRSHOT1)
        Me.tpSPC.Controls.Add(Me.txtPRRDDHOT1)
        Me.tpSPC.Controls.Add(Me.txtPRRDRHOT1)
        Me.tpSPC.Controls.Add(Me.txtPRRDSHOT1)
        Me.tpSPC.Controls.Add(Me.txtPRRDOT1)
        Me.tpSPC.Controls.Add(Me.txtPRRegOT1)
        Me.tpSPC.Controls.Add(Me.txtPRDH1)
        Me.tpSPC.Controls.Add(Me.txtPRRH1)
        Me.tpSPC.Controls.Add(Me.txtPRSH1)
        Me.tpSPC.Controls.Add(Me.txtPRRDDH1)
        Me.tpSPC.Controls.Add(Me.txtPRRDRH1)
        Me.tpSPC.Controls.Add(Me.txtPRRDSH1)
        Me.tpSPC.Controls.Add(Me.txtPRRD1)
        Me.tpSPC.Controls.Add(Me.txtPRReg1)
        Me.tpSPC.Controls.Add(Me.lblPRSDH)
        Me.tpSPC.Controls.Add(Me.txtPRDHOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRDHNS0)
        Me.tpSPC.Controls.Add(Me.txtPRDHOT0)
        Me.tpSPC.Controls.Add(Me.txtPRDH0)
        Me.tpSPC.Controls.Add(Me.lblPRSRH)
        Me.tpSPC.Controls.Add(Me.txtPRRHOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRHNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRHOT0)
        Me.tpSPC.Controls.Add(Me.txtPRRH0)
        Me.tpSPC.Controls.Add(Me.lblPRSSH)
        Me.tpSPC.Controls.Add(Me.txtPRSHOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRSHNS0)
        Me.tpSPC.Controls.Add(Me.txtPRSHOT0)
        Me.tpSPC.Controls.Add(Me.txtPRSH0)
        Me.tpSPC.Controls.Add(Me.lblPRSRDDH)
        Me.tpSPC.Controls.Add(Me.txtPRRDDHOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDDHNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDDHOT0)
        Me.tpSPC.Controls.Add(Me.txtPRRDDH0)
        Me.tpSPC.Controls.Add(Me.lblPRSRDRH)
        Me.tpSPC.Controls.Add(Me.txtPRRDRHOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDRHNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDRHOT0)
        Me.tpSPC.Controls.Add(Me.txtPRRDRH0)
        Me.tpSPC.Controls.Add(Me.lblPRSRDSH)
        Me.tpSPC.Controls.Add(Me.txtPRRDSHOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDSHNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDSHOT0)
        Me.tpSPC.Controls.Add(Me.txtPRRDSH0)
        Me.tpSPC.Controls.Add(Me.lblPRSRD)
        Me.tpSPC.Controls.Add(Me.txtPRRDOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRDOT0)
        Me.tpSPC.Controls.Add(Me.txtPRRD0)
        Me.tpSPC.Controls.Add(Me.txtPRRegOTNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRegNS0)
        Me.tpSPC.Controls.Add(Me.txtPRRegOT0)
        Me.tpSPC.Controls.Add(Me.txtPRReg0)
        Me.tpSPC.Controls.Add(Me.lblPRSOTNS)
        Me.tpSPC.Controls.Add(Me.lblPRSNS)
        Me.tpSPC.Controls.Add(Me.lblPRSPOT)
        Me.tpSPC.Controls.Add(Me.lblPRSBR)
        Me.tpSPC.Controls.Add(Me.lblPRSReg)
        Me.tpSPC.Location = New System.Drawing.Point(4, 23)
        Me.tpSPC.Name = "tpSPC"
        Me.tpSPC.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSPC.Size = New System.Drawing.Size(894, 425)
        Me.tpSPC.TabIndex = 1
        Me.tpSPC.Text = "Custom Rates (Cost-Sharing)"
        Me.tpSPC.UseVisualStyleBackColor = True
        '
        'lblPRS4A
        '
        Me.lblPRS4A.Location = New System.Drawing.Point(757, 121)
        Me.lblPRS4A.Name = "lblPRS4A"
        Me.lblPRS4A.Size = New System.Drawing.Size(63, 16)
        Me.lblPRS4A.TabIndex = 128
        Me.lblPRS4A.Text = "Dept/Clnt"
        Me.lblPRS4A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRS3A
        '
        Me.lblPRS3A.Location = New System.Drawing.Point(610, 121)
        Me.lblPRS3A.Name = "lblPRS3A"
        Me.lblPRS3A.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS3A.TabIndex = 127
        Me.lblPRS3A.Text = "Dept/Clnt"
        Me.lblPRS3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRS2A
        '
        Me.lblPRS2A.Location = New System.Drawing.Point(460, 121)
        Me.lblPRS2A.Name = "lblPRS2A"
        Me.lblPRS2A.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS2A.TabIndex = 126
        Me.lblPRS2A.Text = "Dept/Clnt"
        Me.lblPRS2A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRS1A
        '
        Me.lblPRS1A.Location = New System.Drawing.Point(310, 121)
        Me.lblPRS1A.Name = "lblPRS1A"
        Me.lblPRS1A.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS1A.TabIndex = 125
        Me.lblPRS1A.Text = "Dept/Clnt"
        Me.lblPRS1A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPRCustom
        '
        Me.pnlPRCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPRCustom.Controls.Add(Me.btnPRCusCancel)
        Me.pnlPRCustom.Controls.Add(Me.btnPRCusSave)
        Me.pnlPRCustom.Controls.Add(Me.lblPRCompCus)
        Me.pnlPRCustom.Controls.Add(Me.cboPRCompCus)
        Me.pnlPRCustom.Controls.Add(Me.lblPRCustom)
        Me.pnlPRCustom.Controls.Add(Me.cboPRCustom)
        Me.pnlPRCustom.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPRCustom.Location = New System.Drawing.Point(3, 3)
        Me.pnlPRCustom.Name = "pnlPRCustom"
        Me.pnlPRCustom.Size = New System.Drawing.Size(886, 92)
        Me.pnlPRCustom.TabIndex = 124
        '
        'btnPRCusCancel
        '
        Me.btnPRCusCancel.Image = CType(resources.GetObject("btnPRCusCancel.Image"), System.Drawing.Image)
        Me.btnPRCusCancel.Location = New System.Drawing.Point(178, 56)
        Me.btnPRCusCancel.Name = "btnPRCusCancel"
        Me.btnPRCusCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPRCusCancel.TabIndex = 64
        Me.btnPRCusCancel.Text = "Cancel"
        Me.btnPRCusCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPRCusCancel.UseVisualStyleBackColor = True
        '
        'btnPRCusSave
        '
        Me.btnPRCusSave.Image = CType(resources.GetObject("btnPRCusSave.Image"), System.Drawing.Image)
        Me.btnPRCusSave.Location = New System.Drawing.Point(98, 56)
        Me.btnPRCusSave.Name = "btnPRCusSave"
        Me.btnPRCusSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPRCusSave.TabIndex = 63
        Me.btnPRCusSave.Text = "Save"
        Me.btnPRCusSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPRCusSave.UseVisualStyleBackColor = True
        '
        'lblPRCompCus
        '
        Me.lblPRCompCus.AutoSize = True
        Me.lblPRCompCus.Location = New System.Drawing.Point(3, 7)
        Me.lblPRCompCus.Name = "lblPRCompCus"
        Me.lblPRCompCus.Size = New System.Drawing.Size(56, 14)
        Me.lblPRCompCus.TabIndex = 3
        Me.lblPRCompCus.Text = "Company"
        '
        'cboPRCompCus
        '
        Me.cboPRCompCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPRCompCus.FormattingEnabled = True
        Me.cboPRCompCus.Location = New System.Drawing.Point(98, 4)
        Me.cboPRCompCus.Name = "cboPRCompCus"
        Me.cboPRCompCus.Size = New System.Drawing.Size(450, 22)
        Me.cboPRCompCus.TabIndex = 2
        '
        'lblPRCustom
        '
        Me.lblPRCustom.AutoSize = True
        Me.lblPRCustom.Location = New System.Drawing.Point(3, 32)
        Me.lblPRCustom.Name = "lblPRCustom"
        Me.lblPRCustom.Size = New System.Drawing.Size(71, 14)
        Me.lblPRCustom.TabIndex = 1
        Me.lblPRCustom.Text = "Rate Setting"
        '
        'cboPRCustom
        '
        Me.cboPRCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPRCustom.FormattingEnabled = True
        Me.cboPRCustom.Location = New System.Drawing.Point(98, 29)
        Me.cboPRCustom.Name = "cboPRCustom"
        Me.cboPRCustom.Size = New System.Drawing.Size(450, 22)
        Me.cboPRCustom.TabIndex = 0
        '
        'lblPRS4
        '
        Me.lblPRS4.Location = New System.Drawing.Point(690, 121)
        Me.lblPRS4.Name = "lblPRS4"
        Me.lblPRS4.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS4.TabIndex = 123
        Me.lblPRS4.Text = "Company"
        Me.lblPRS4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRS3
        '
        Me.lblPRS3.Location = New System.Drawing.Point(540, 121)
        Me.lblPRS3.Name = "lblPRS3"
        Me.lblPRS3.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS3.TabIndex = 122
        Me.lblPRS3.Text = "Company"
        Me.lblPRS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRS2
        '
        Me.lblPRS2.Location = New System.Drawing.Point(390, 121)
        Me.lblPRS2.Name = "lblPRS2"
        Me.lblPRS2.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS2.TabIndex = 121
        Me.lblPRS2.Text = "Company"
        Me.lblPRS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRS1
        '
        Me.lblPRS1.Location = New System.Drawing.Point(240, 121)
        Me.lblPRS1.Name = "lblPRS1"
        Me.lblPRS1.Size = New System.Drawing.Size(60, 16)
        Me.lblPRS1.TabIndex = 120
        Me.lblPRS1.Text = "Company"
        Me.lblPRS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPRDHOTNS1
        '
        Me.txtPRDHOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHOTNS1.Location = New System.Drawing.Point(760, 316)
        Me.txtPRDHOTNS1.MaxLength = 10
        Me.txtPRDHOTNS1.Name = "txtPRDHOTNS1"
        Me.txtPRDHOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHOTNS1.TabIndex = 112
        Me.txtPRDHOTNS1.Text = "0.0000"
        Me.txtPRDHOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHOTNS1
        '
        Me.txtPRRHOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHOTNS1.Location = New System.Drawing.Point(760, 291)
        Me.txtPRRHOTNS1.MaxLength = 10
        Me.txtPRRHOTNS1.Name = "txtPRRHOTNS1"
        Me.txtPRRHOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHOTNS1.TabIndex = 104
        Me.txtPRRHOTNS1.Text = "0.0000"
        Me.txtPRRHOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHOTNS1
        '
        Me.txtPRSHOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHOTNS1.Location = New System.Drawing.Point(760, 266)
        Me.txtPRSHOTNS1.MaxLength = 10
        Me.txtPRSHOTNS1.Name = "txtPRSHOTNS1"
        Me.txtPRSHOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHOTNS1.TabIndex = 96
        Me.txtPRSHOTNS1.Text = "0.0000"
        Me.txtPRSHOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHOTNS1
        '
        Me.txtPRRDDHOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHOTNS1.Location = New System.Drawing.Point(760, 240)
        Me.txtPRRDDHOTNS1.MaxLength = 10
        Me.txtPRRDDHOTNS1.Name = "txtPRRDDHOTNS1"
        Me.txtPRRDDHOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHOTNS1.TabIndex = 88
        Me.txtPRRDDHOTNS1.Text = "0.0000"
        Me.txtPRRDDHOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHOTNS1
        '
        Me.txtPRRDRHOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHOTNS1.Location = New System.Drawing.Point(760, 215)
        Me.txtPRRDRHOTNS1.MaxLength = 10
        Me.txtPRRDRHOTNS1.Name = "txtPRRDRHOTNS1"
        Me.txtPRRDRHOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHOTNS1.TabIndex = 80
        Me.txtPRRDRHOTNS1.Text = "0.0000"
        Me.txtPRRDRHOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHOTNS1
        '
        Me.txtPRRDSHOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHOTNS1.Location = New System.Drawing.Point(760, 190)
        Me.txtPRRDSHOTNS1.MaxLength = 10
        Me.txtPRRDSHOTNS1.Name = "txtPRRDSHOTNS1"
        Me.txtPRRDSHOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHOTNS1.TabIndex = 72
        Me.txtPRRDSHOTNS1.Text = "0.0000"
        Me.txtPRRDSHOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDOTNS1
        '
        Me.txtPRRDOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDOTNS1.Location = New System.Drawing.Point(760, 165)
        Me.txtPRRDOTNS1.Name = "txtPRRDOTNS1"
        Me.txtPRRDOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDOTNS1.TabIndex = 64
        Me.txtPRRDOTNS1.Text = "0.0000"
        Me.txtPRRDOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegOTNS1
        '
        Me.txtPRRegOTNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegOTNS1.Location = New System.Drawing.Point(760, 140)
        Me.txtPRRegOTNS1.MaxLength = 10
        Me.txtPRRegOTNS1.Name = "txtPRRegOTNS1"
        Me.txtPRRegOTNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegOTNS1.TabIndex = 56
        Me.txtPRRegOTNS1.Text = "0.0000"
        Me.txtPRRegOTNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDHNS1
        '
        Me.txtPRDHNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHNS1.Location = New System.Drawing.Point(610, 316)
        Me.txtPRDHNS1.MaxLength = 10
        Me.txtPRDHNS1.Name = "txtPRDHNS1"
        Me.txtPRDHNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHNS1.TabIndex = 110
        Me.txtPRDHNS1.Text = "0.0000"
        Me.txtPRDHNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHNS1
        '
        Me.txtPRRHNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHNS1.Location = New System.Drawing.Point(610, 291)
        Me.txtPRRHNS1.MaxLength = 10
        Me.txtPRRHNS1.Name = "txtPRRHNS1"
        Me.txtPRRHNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHNS1.TabIndex = 102
        Me.txtPRRHNS1.Text = "0.0000"
        Me.txtPRRHNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHNS1
        '
        Me.txtPRSHNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHNS1.Location = New System.Drawing.Point(610, 266)
        Me.txtPRSHNS1.MaxLength = 0
        Me.txtPRSHNS1.Name = "txtPRSHNS1"
        Me.txtPRSHNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHNS1.TabIndex = 94
        Me.txtPRSHNS1.Text = "0.0000"
        Me.txtPRSHNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHNS1
        '
        Me.txtPRRDDHNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHNS1.Location = New System.Drawing.Point(610, 240)
        Me.txtPRRDDHNS1.MaxLength = 1
        Me.txtPRRDDHNS1.Name = "txtPRRDDHNS1"
        Me.txtPRRDDHNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHNS1.TabIndex = 86
        Me.txtPRRDDHNS1.Text = "0.0000"
        Me.txtPRRDDHNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHNS1
        '
        Me.txtPRRDRHNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHNS1.Location = New System.Drawing.Point(610, 215)
        Me.txtPRRDRHNS1.MaxLength = 10
        Me.txtPRRDRHNS1.Name = "txtPRRDRHNS1"
        Me.txtPRRDRHNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHNS1.TabIndex = 78
        Me.txtPRRDRHNS1.Text = "0.0000"
        Me.txtPRRDRHNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHNS1
        '
        Me.txtPRRDSHNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHNS1.Location = New System.Drawing.Point(610, 190)
        Me.txtPRRDSHNS1.MaxLength = 10
        Me.txtPRRDSHNS1.Name = "txtPRRDSHNS1"
        Me.txtPRRDSHNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHNS1.TabIndex = 70
        Me.txtPRRDSHNS1.Text = "0.0000"
        Me.txtPRRDSHNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDNS1
        '
        Me.txtPRRDNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDNS1.Location = New System.Drawing.Point(610, 165)
        Me.txtPRRDNS1.MaxLength = 10
        Me.txtPRRDNS1.Name = "txtPRRDNS1"
        Me.txtPRRDNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDNS1.TabIndex = 62
        Me.txtPRRDNS1.Text = "0.0000"
        Me.txtPRRDNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegNS1
        '
        Me.txtPRRegNS1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegNS1.Location = New System.Drawing.Point(610, 140)
        Me.txtPRRegNS1.MaxLength = 10
        Me.txtPRRegNS1.Name = "txtPRRegNS1"
        Me.txtPRRegNS1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegNS1.TabIndex = 54
        Me.txtPRRegNS1.Text = "0.0000"
        Me.txtPRRegNS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDHOT1
        '
        Me.txtPRDHOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHOT1.Location = New System.Drawing.Point(460, 316)
        Me.txtPRDHOT1.MaxLength = 10
        Me.txtPRDHOT1.Name = "txtPRDHOT1"
        Me.txtPRDHOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHOT1.TabIndex = 108
        Me.txtPRDHOT1.Text = "0.0000"
        Me.txtPRDHOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHOT1
        '
        Me.txtPRRHOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHOT1.Location = New System.Drawing.Point(460, 291)
        Me.txtPRRHOT1.MaxLength = 10
        Me.txtPRRHOT1.Name = "txtPRRHOT1"
        Me.txtPRRHOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHOT1.TabIndex = 100
        Me.txtPRRHOT1.Text = "0.0000"
        Me.txtPRRHOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHOT1
        '
        Me.txtPRSHOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHOT1.Location = New System.Drawing.Point(460, 266)
        Me.txtPRSHOT1.MaxLength = 10
        Me.txtPRSHOT1.Name = "txtPRSHOT1"
        Me.txtPRSHOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHOT1.TabIndex = 92
        Me.txtPRSHOT1.Text = "0.0000"
        Me.txtPRSHOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHOT1
        '
        Me.txtPRRDDHOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHOT1.Location = New System.Drawing.Point(460, 240)
        Me.txtPRRDDHOT1.MaxLength = 10
        Me.txtPRRDDHOT1.Name = "txtPRRDDHOT1"
        Me.txtPRRDDHOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHOT1.TabIndex = 84
        Me.txtPRRDDHOT1.Text = "0.0000"
        Me.txtPRRDDHOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHOT1
        '
        Me.txtPRRDRHOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHOT1.Location = New System.Drawing.Point(460, 215)
        Me.txtPRRDRHOT1.MaxLength = 10
        Me.txtPRRDRHOT1.Name = "txtPRRDRHOT1"
        Me.txtPRRDRHOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHOT1.TabIndex = 76
        Me.txtPRRDRHOT1.Text = "0.0000"
        Me.txtPRRDRHOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHOT1
        '
        Me.txtPRRDSHOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHOT1.Location = New System.Drawing.Point(460, 190)
        Me.txtPRRDSHOT1.MaxLength = 10
        Me.txtPRRDSHOT1.Name = "txtPRRDSHOT1"
        Me.txtPRRDSHOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHOT1.TabIndex = 68
        Me.txtPRRDSHOT1.Text = "0.0000"
        Me.txtPRRDSHOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDOT1
        '
        Me.txtPRRDOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDOT1.Location = New System.Drawing.Point(460, 165)
        Me.txtPRRDOT1.MaxLength = 10
        Me.txtPRRDOT1.Name = "txtPRRDOT1"
        Me.txtPRRDOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDOT1.TabIndex = 60
        Me.txtPRRDOT1.Text = "0.0000"
        Me.txtPRRDOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegOT1
        '
        Me.txtPRRegOT1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegOT1.Location = New System.Drawing.Point(460, 140)
        Me.txtPRRegOT1.MaxLength = 10
        Me.txtPRRegOT1.Name = "txtPRRegOT1"
        Me.txtPRRegOT1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegOT1.TabIndex = 52
        Me.txtPRRegOT1.Text = "0.0000"
        Me.txtPRRegOT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDH1
        '
        Me.txtPRDH1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDH1.Location = New System.Drawing.Point(310, 316)
        Me.txtPRDH1.MaxLength = 10
        Me.txtPRDH1.Name = "txtPRDH1"
        Me.txtPRDH1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDH1.TabIndex = 106
        Me.txtPRDH1.Text = "0.0000"
        Me.txtPRDH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRH1
        '
        Me.txtPRRH1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRH1.Location = New System.Drawing.Point(310, 291)
        Me.txtPRRH1.MaxLength = 10
        Me.txtPRRH1.Name = "txtPRRH1"
        Me.txtPRRH1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRH1.TabIndex = 98
        Me.txtPRRH1.Text = "0.0000"
        Me.txtPRRH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSH1
        '
        Me.txtPRSH1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSH1.Location = New System.Drawing.Point(310, 266)
        Me.txtPRSH1.MaxLength = 10
        Me.txtPRSH1.Name = "txtPRSH1"
        Me.txtPRSH1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSH1.TabIndex = 90
        Me.txtPRSH1.Text = "0.0000"
        Me.txtPRSH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDH1
        '
        Me.txtPRRDDH1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDH1.Location = New System.Drawing.Point(310, 240)
        Me.txtPRRDDH1.MaxLength = 10
        Me.txtPRRDDH1.Name = "txtPRRDDH1"
        Me.txtPRRDDH1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDH1.TabIndex = 82
        Me.txtPRRDDH1.Text = "0.0000"
        Me.txtPRRDDH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRH1
        '
        Me.txtPRRDRH1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRH1.Location = New System.Drawing.Point(310, 215)
        Me.txtPRRDRH1.MaxLength = 10
        Me.txtPRRDRH1.Name = "txtPRRDRH1"
        Me.txtPRRDRH1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRH1.TabIndex = 74
        Me.txtPRRDRH1.Text = "0.0000"
        Me.txtPRRDRH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSH1
        '
        Me.txtPRRDSH1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSH1.Location = New System.Drawing.Point(310, 190)
        Me.txtPRRDSH1.MaxLength = 10
        Me.txtPRRDSH1.Name = "txtPRRDSH1"
        Me.txtPRRDSH1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSH1.TabIndex = 66
        Me.txtPRRDSH1.Text = "0.0000"
        Me.txtPRRDSH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRD1
        '
        Me.txtPRRD1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRD1.Location = New System.Drawing.Point(310, 165)
        Me.txtPRRD1.MaxLength = 10
        Me.txtPRRD1.Name = "txtPRRD1"
        Me.txtPRRD1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRD1.TabIndex = 58
        Me.txtPRRD1.Text = "0.0000"
        Me.txtPRRD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRReg1
        '
        Me.txtPRReg1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRReg1.Location = New System.Drawing.Point(310, 140)
        Me.txtPRReg1.MaxLength = 10
        Me.txtPRReg1.Name = "txtPRReg1"
        Me.txtPRReg1.Size = New System.Drawing.Size(60, 22)
        Me.txtPRReg1.TabIndex = 50
        Me.txtPRReg1.Text = "0.0000"
        Me.txtPRReg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSDH
        '
        Me.lblPRSDH.AutoSize = True
        Me.lblPRSDH.Location = New System.Drawing.Point(13, 319)
        Me.lblPRSDH.Name = "lblPRSDH"
        Me.lblPRSDH.Size = New System.Drawing.Size(92, 14)
        Me.lblPRSDH.TabIndex = 87
        Me.lblPRSDH.Text = "Double Holiday"
        '
        'txtPRDHOTNS0
        '
        Me.txtPRDHOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHOTNS0.Location = New System.Drawing.Point(690, 316)
        Me.txtPRDHOTNS0.MaxLength = 10
        Me.txtPRDHOTNS0.Name = "txtPRDHOTNS0"
        Me.txtPRDHOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHOTNS0.TabIndex = 111
        Me.txtPRDHOTNS0.Text = "0.0000"
        Me.txtPRDHOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDHNS0
        '
        Me.txtPRDHNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHNS0.Location = New System.Drawing.Point(540, 316)
        Me.txtPRDHNS0.MaxLength = 10
        Me.txtPRDHNS0.Name = "txtPRDHNS0"
        Me.txtPRDHNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHNS0.TabIndex = 109
        Me.txtPRDHNS0.Text = "0.0000"
        Me.txtPRDHNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDHOT0
        '
        Me.txtPRDHOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDHOT0.Location = New System.Drawing.Point(390, 316)
        Me.txtPRDHOT0.MaxLength = 10
        Me.txtPRDHOT0.Name = "txtPRDHOT0"
        Me.txtPRDHOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDHOT0.TabIndex = 107
        Me.txtPRDHOT0.Text = "0.0000"
        Me.txtPRDHOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRDH0
        '
        Me.txtPRDH0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDH0.Location = New System.Drawing.Point(240, 316)
        Me.txtPRDH0.MaxLength = 10
        Me.txtPRDH0.Name = "txtPRDH0"
        Me.txtPRDH0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRDH0.TabIndex = 105
        Me.txtPRDH0.Text = "0.0000"
        Me.txtPRDH0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSRH
        '
        Me.lblPRSRH.AutoSize = True
        Me.lblPRSRH.Location = New System.Drawing.Point(13, 294)
        Me.lblPRSRH.Name = "lblPRSRH"
        Me.lblPRSRH.Size = New System.Drawing.Size(94, 14)
        Me.lblPRSRH.TabIndex = 82
        Me.lblPRSRH.Text = "Regular Holiday"
        '
        'txtPRRHOTNS0
        '
        Me.txtPRRHOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHOTNS0.Location = New System.Drawing.Point(690, 291)
        Me.txtPRRHOTNS0.MaxLength = 10
        Me.txtPRRHOTNS0.Name = "txtPRRHOTNS0"
        Me.txtPRRHOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHOTNS0.TabIndex = 103
        Me.txtPRRHOTNS0.Text = "0.0000"
        Me.txtPRRHOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHNS0
        '
        Me.txtPRRHNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHNS0.Location = New System.Drawing.Point(540, 291)
        Me.txtPRRHNS0.MaxLength = 10
        Me.txtPRRHNS0.Name = "txtPRRHNS0"
        Me.txtPRRHNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHNS0.TabIndex = 101
        Me.txtPRRHNS0.Text = "0.0000"
        Me.txtPRRHNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRHOT0
        '
        Me.txtPRRHOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRHOT0.Location = New System.Drawing.Point(390, 291)
        Me.txtPRRHOT0.MaxLength = 10
        Me.txtPRRHOT0.Name = "txtPRRHOT0"
        Me.txtPRRHOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRHOT0.TabIndex = 99
        Me.txtPRRHOT0.Text = "0.0000"
        Me.txtPRRHOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRH0
        '
        Me.txtPRRH0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRH0.Location = New System.Drawing.Point(240, 291)
        Me.txtPRRH0.MaxLength = 10
        Me.txtPRRH0.Name = "txtPRRH0"
        Me.txtPRRH0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRH0.TabIndex = 97
        Me.txtPRRH0.Text = "0.0000"
        Me.txtPRRH0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSSH
        '
        Me.lblPRSSH.AutoSize = True
        Me.lblPRSSH.Location = New System.Drawing.Point(13, 269)
        Me.lblPRSSH.Name = "lblPRSSH"
        Me.lblPRSSH.Size = New System.Drawing.Size(92, 14)
        Me.lblPRSSH.TabIndex = 77
        Me.lblPRSSH.Text = "Special Holiday"
        '
        'txtPRSHOTNS0
        '
        Me.txtPRSHOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHOTNS0.Location = New System.Drawing.Point(690, 266)
        Me.txtPRSHOTNS0.MaxLength = 10
        Me.txtPRSHOTNS0.Name = "txtPRSHOTNS0"
        Me.txtPRSHOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHOTNS0.TabIndex = 95
        Me.txtPRSHOTNS0.Text = "0.0000"
        Me.txtPRSHOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHNS0
        '
        Me.txtPRSHNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHNS0.Location = New System.Drawing.Point(540, 266)
        Me.txtPRSHNS0.MaxLength = 10
        Me.txtPRSHNS0.Name = "txtPRSHNS0"
        Me.txtPRSHNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHNS0.TabIndex = 93
        Me.txtPRSHNS0.Text = "0.0000"
        Me.txtPRSHNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSHOT0
        '
        Me.txtPRSHOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSHOT0.Location = New System.Drawing.Point(390, 266)
        Me.txtPRSHOT0.MaxLength = 10
        Me.txtPRSHOT0.Name = "txtPRSHOT0"
        Me.txtPRSHOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSHOT0.TabIndex = 91
        Me.txtPRSHOT0.Text = "0.0000"
        Me.txtPRSHOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRSH0
        '
        Me.txtPRSH0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRSH0.Location = New System.Drawing.Point(240, 266)
        Me.txtPRSH0.MaxLength = 10
        Me.txtPRSH0.Name = "txtPRSH0"
        Me.txtPRSH0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRSH0.TabIndex = 89
        Me.txtPRSH0.Text = "0.0000"
        Me.txtPRSH0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSRDDH
        '
        Me.lblPRSRDDH.AutoSize = True
        Me.lblPRSRDDH.Location = New System.Drawing.Point(13, 243)
        Me.lblPRSRDDH.Name = "lblPRSRDDH"
        Me.lblPRSRDDH.Size = New System.Drawing.Size(155, 14)
        Me.lblPRSRDDH.TabIndex = 72
        Me.lblPRSRDDH.Text = "Restday on Double Holiday"
        '
        'txtPRRDDHOTNS0
        '
        Me.txtPRRDDHOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHOTNS0.Location = New System.Drawing.Point(690, 240)
        Me.txtPRRDDHOTNS0.MaxLength = 10
        Me.txtPRRDDHOTNS0.Name = "txtPRRDDHOTNS0"
        Me.txtPRRDDHOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHOTNS0.TabIndex = 87
        Me.txtPRRDDHOTNS0.Text = "0.0000"
        Me.txtPRRDDHOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHNS0
        '
        Me.txtPRRDDHNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHNS0.Location = New System.Drawing.Point(540, 240)
        Me.txtPRRDDHNS0.MaxLength = 10
        Me.txtPRRDDHNS0.Name = "txtPRRDDHNS0"
        Me.txtPRRDDHNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHNS0.TabIndex = 85
        Me.txtPRRDDHNS0.Text = "0.0000"
        Me.txtPRRDDHNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDHOT0
        '
        Me.txtPRRDDHOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDHOT0.Location = New System.Drawing.Point(390, 240)
        Me.txtPRRDDHOT0.MaxLength = 10
        Me.txtPRRDDHOT0.Name = "txtPRRDDHOT0"
        Me.txtPRRDDHOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDHOT0.TabIndex = 83
        Me.txtPRRDDHOT0.Text = "0.0000"
        Me.txtPRRDDHOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDDH0
        '
        Me.txtPRRDDH0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDDH0.Location = New System.Drawing.Point(240, 240)
        Me.txtPRRDDH0.MaxLength = 10
        Me.txtPRRDDH0.Name = "txtPRRDDH0"
        Me.txtPRRDDH0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDDH0.TabIndex = 81
        Me.txtPRRDDH0.Text = "0.0000"
        Me.txtPRRDDH0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSRDRH
        '
        Me.lblPRSRDRH.AutoSize = True
        Me.lblPRSRDRH.Location = New System.Drawing.Point(13, 218)
        Me.lblPRSRDRH.Name = "lblPRSRDRH"
        Me.lblPRSRDRH.Size = New System.Drawing.Size(157, 14)
        Me.lblPRSRDRH.TabIndex = 67
        Me.lblPRSRDRH.Text = "Restday on Regular Holiday"
        '
        'txtPRRDRHOTNS0
        '
        Me.txtPRRDRHOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHOTNS0.Location = New System.Drawing.Point(690, 215)
        Me.txtPRRDRHOTNS0.MaxLength = 10
        Me.txtPRRDRHOTNS0.Name = "txtPRRDRHOTNS0"
        Me.txtPRRDRHOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHOTNS0.TabIndex = 79
        Me.txtPRRDRHOTNS0.Text = "0.0000"
        Me.txtPRRDRHOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHNS0
        '
        Me.txtPRRDRHNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHNS0.Location = New System.Drawing.Point(540, 215)
        Me.txtPRRDRHNS0.MaxLength = 0
        Me.txtPRRDRHNS0.Name = "txtPRRDRHNS0"
        Me.txtPRRDRHNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHNS0.TabIndex = 77
        Me.txtPRRDRHNS0.Text = "0.0000"
        Me.txtPRRDRHNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRHOT0
        '
        Me.txtPRRDRHOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRHOT0.Location = New System.Drawing.Point(390, 215)
        Me.txtPRRDRHOT0.MaxLength = 10
        Me.txtPRRDRHOT0.Name = "txtPRRDRHOT0"
        Me.txtPRRDRHOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRHOT0.TabIndex = 75
        Me.txtPRRDRHOT0.Text = "0.0000"
        Me.txtPRRDRHOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDRH0
        '
        Me.txtPRRDRH0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDRH0.Location = New System.Drawing.Point(240, 215)
        Me.txtPRRDRH0.MaxLength = 10
        Me.txtPRRDRH0.Name = "txtPRRDRH0"
        Me.txtPRRDRH0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDRH0.TabIndex = 73
        Me.txtPRRDRH0.Text = "0.0000"
        Me.txtPRRDRH0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSRDSH
        '
        Me.lblPRSRDSH.AutoSize = True
        Me.lblPRSRDSH.Location = New System.Drawing.Point(13, 193)
        Me.lblPRSRDSH.Name = "lblPRSRDSH"
        Me.lblPRSRDSH.Size = New System.Drawing.Size(155, 14)
        Me.lblPRSRDSH.TabIndex = 62
        Me.lblPRSRDSH.Text = "Restday on Special Holiday"
        '
        'txtPRRDSHOTNS0
        '
        Me.txtPRRDSHOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHOTNS0.Location = New System.Drawing.Point(690, 190)
        Me.txtPRRDSHOTNS0.MaxLength = 10
        Me.txtPRRDSHOTNS0.Name = "txtPRRDSHOTNS0"
        Me.txtPRRDSHOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHOTNS0.TabIndex = 71
        Me.txtPRRDSHOTNS0.Text = "0.0000"
        Me.txtPRRDSHOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHNS0
        '
        Me.txtPRRDSHNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHNS0.Location = New System.Drawing.Point(540, 190)
        Me.txtPRRDSHNS0.MaxLength = 1
        Me.txtPRRDSHNS0.Name = "txtPRRDSHNS0"
        Me.txtPRRDSHNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHNS0.TabIndex = 69
        Me.txtPRRDSHNS0.Text = "0.0000"
        Me.txtPRRDSHNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSHOT0
        '
        Me.txtPRRDSHOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSHOT0.Location = New System.Drawing.Point(390, 190)
        Me.txtPRRDSHOT0.MaxLength = 10
        Me.txtPRRDSHOT0.Name = "txtPRRDSHOT0"
        Me.txtPRRDSHOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSHOT0.TabIndex = 67
        Me.txtPRRDSHOT0.Text = "0.0000"
        Me.txtPRRDSHOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDSH0
        '
        Me.txtPRRDSH0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDSH0.Location = New System.Drawing.Point(240, 190)
        Me.txtPRRDSH0.MaxLength = 0
        Me.txtPRRDSH0.Name = "txtPRRDSH0"
        Me.txtPRRDSH0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDSH0.TabIndex = 65
        Me.txtPRRDSH0.Text = "0.0000"
        Me.txtPRRDSH0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSRD
        '
        Me.lblPRSRD.AutoSize = True
        Me.lblPRSRD.Location = New System.Drawing.Point(13, 168)
        Me.lblPRSRD.Name = "lblPRSRD"
        Me.lblPRSRD.Size = New System.Drawing.Size(50, 14)
        Me.lblPRSRD.TabIndex = 57
        Me.lblPRSRD.Text = "Restday"
        '
        'txtPRRDOTNS0
        '
        Me.txtPRRDOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDOTNS0.Location = New System.Drawing.Point(690, 165)
        Me.txtPRRDOTNS0.MaxLength = 10
        Me.txtPRRDOTNS0.Name = "txtPRRDOTNS0"
        Me.txtPRRDOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDOTNS0.TabIndex = 63
        Me.txtPRRDOTNS0.Text = "0.0000"
        Me.txtPRRDOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDNS0
        '
        Me.txtPRRDNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDNS0.Location = New System.Drawing.Point(540, 165)
        Me.txtPRRDNS0.MaxLength = 10
        Me.txtPRRDNS0.Name = "txtPRRDNS0"
        Me.txtPRRDNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDNS0.TabIndex = 61
        Me.txtPRRDNS0.Text = "0.0000"
        Me.txtPRRDNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRDOT0
        '
        Me.txtPRRDOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRDOT0.Location = New System.Drawing.Point(390, 165)
        Me.txtPRRDOT0.MaxLength = 10
        Me.txtPRRDOT0.Name = "txtPRRDOT0"
        Me.txtPRRDOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRDOT0.TabIndex = 59
        Me.txtPRRDOT0.Text = "0.0000"
        Me.txtPRRDOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRD0
        '
        Me.txtPRRD0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRD0.Location = New System.Drawing.Point(240, 165)
        Me.txtPRRD0.MaxLength = 1
        Me.txtPRRD0.Name = "txtPRRD0"
        Me.txtPRRD0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRD0.TabIndex = 57
        Me.txtPRRD0.Text = "0.0000"
        Me.txtPRRD0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegOTNS0
        '
        Me.txtPRRegOTNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegOTNS0.Location = New System.Drawing.Point(690, 140)
        Me.txtPRRegOTNS0.MaxLength = 10
        Me.txtPRRegOTNS0.Name = "txtPRRegOTNS0"
        Me.txtPRRegOTNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegOTNS0.TabIndex = 55
        Me.txtPRRegOTNS0.Text = "0.0000"
        Me.txtPRRegOTNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegNS0
        '
        Me.txtPRRegNS0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegNS0.Location = New System.Drawing.Point(540, 140)
        Me.txtPRRegNS0.MaxLength = 10
        Me.txtPRRegNS0.Name = "txtPRRegNS0"
        Me.txtPRRegNS0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegNS0.TabIndex = 53
        Me.txtPRRegNS0.Text = "0.0000"
        Me.txtPRRegNS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRRegOT0
        '
        Me.txtPRRegOT0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRRegOT0.Location = New System.Drawing.Point(390, 140)
        Me.txtPRRegOT0.MaxLength = 10
        Me.txtPRRegOT0.Name = "txtPRRegOT0"
        Me.txtPRRegOT0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRRegOT0.TabIndex = 51
        Me.txtPRRegOT0.Text = "0.0000"
        Me.txtPRRegOT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPRReg0
        '
        Me.txtPRReg0.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRReg0.Location = New System.Drawing.Point(240, 140)
        Me.txtPRReg0.MaxLength = 10
        Me.txtPRReg0.Name = "txtPRReg0"
        Me.txtPRReg0.Size = New System.Drawing.Size(60, 22)
        Me.txtPRReg0.TabIndex = 49
        Me.txtPRReg0.Text = "0.0000"
        Me.txtPRReg0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPRSOTNS
        '
        Me.lblPRSOTNS.Location = New System.Drawing.Point(690, 105)
        Me.lblPRSOTNS.Name = "lblPRSOTNS"
        Me.lblPRSOTNS.Size = New System.Drawing.Size(130, 16)
        Me.lblPRSOTNS.TabIndex = 48
        Me.lblPRSOTNS.Text = "+ (OT + NS)"
        Me.lblPRSOTNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRSNS
        '
        Me.lblPRSNS.Location = New System.Drawing.Point(540, 105)
        Me.lblPRSNS.Name = "lblPRSNS"
        Me.lblPRSNS.Size = New System.Drawing.Size(130, 16)
        Me.lblPRSNS.TabIndex = 47
        Me.lblPRSNS.Text = "+ Night Shift"
        Me.lblPRSNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRSPOT
        '
        Me.lblPRSPOT.Location = New System.Drawing.Point(390, 105)
        Me.lblPRSPOT.Name = "lblPRSPOT"
        Me.lblPRSPOT.Size = New System.Drawing.Size(130, 16)
        Me.lblPRSPOT.TabIndex = 46
        Me.lblPRSPOT.Text = "+ Overtime"
        Me.lblPRSPOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRSBR
        '
        Me.lblPRSBR.Location = New System.Drawing.Point(240, 105)
        Me.lblPRSBR.Name = "lblPRSBR"
        Me.lblPRSBR.Size = New System.Drawing.Size(130, 16)
        Me.lblPRSBR.TabIndex = 45
        Me.lblPRSBR.Text = "Base Rate"
        Me.lblPRSBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPRSReg
        '
        Me.lblPRSReg.AutoSize = True
        Me.lblPRSReg.Location = New System.Drawing.Point(13, 143)
        Me.lblPRSReg.Name = "lblPRSReg"
        Me.lblPRSReg.Size = New System.Drawing.Size(72, 14)
        Me.lblPRSReg.TabIndex = 44
        Me.lblPRSReg.Text = "Regular Day"
        '
        'TabPage15
        '
        Me.TabPage15.AutoScroll = True
        Me.TabPage15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage15.Controls.Add(Me.tcPSet)
        Me.TabPage15.Location = New System.Drawing.Point(4, 23)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(926, 494)
        Me.TabPage15.TabIndex = 4
        Me.TabPage15.Text = "Payment Setup"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'tcPSet
        '
        Me.tcPSet.Controls.Add(Me.tpPayChannels)
        Me.tcPSet.Controls.Add(Me.tpBanks)
        Me.tcPSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPSet.Location = New System.Drawing.Point(3, 3)
        Me.tcPSet.Name = "tcPSet"
        Me.tcPSet.SelectedIndex = 0
        Me.tcPSet.Size = New System.Drawing.Size(918, 486)
        Me.tcPSet.TabIndex = 0
        '
        'tpPayChannels
        '
        Me.tpPayChannels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPayChannels.Controls.Add(Me.dgvPC)
        Me.tpPayChannels.Controls.Add(Me.pnlPC)
        Me.tpPayChannels.Location = New System.Drawing.Point(4, 23)
        Me.tpPayChannels.Name = "tpPayChannels"
        Me.tpPayChannels.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPayChannels.Size = New System.Drawing.Size(910, 459)
        Me.tpPayChannels.TabIndex = 0
        Me.tpPayChannels.Text = "Payment Channels"
        Me.tpPayChannels.UseVisualStyleBackColor = True
        '
        'dgvPC
        '
        Me.dgvPC.AllowUserToAddRows = False
        Me.dgvPC.AllowUserToDeleteRows = False
        Me.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPCSel, Me.colPCDel})
        Me.dgvPC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPC.Location = New System.Drawing.Point(3, 130)
        Me.dgvPC.Name = "dgvPC"
        Me.dgvPC.ReadOnly = True
        Me.dgvPC.Size = New System.Drawing.Size(902, 324)
        Me.dgvPC.TabIndex = 14
        '
        'colPCSel
        '
        Me.colPCSel.Frozen = True
        Me.colPCSel.HeaderText = ""
        Me.colPCSel.Name = "colPCSel"
        Me.colPCSel.ReadOnly = True
        Me.colPCSel.Text = "Select"
        Me.colPCSel.UseColumnTextForButtonValue = True
        Me.colPCSel.Width = 60
        '
        'colPCDel
        '
        Me.colPCDel.Frozen = True
        Me.colPCDel.HeaderText = ""
        Me.colPCDel.Name = "colPCDel"
        Me.colPCDel.ReadOnly = True
        Me.colPCDel.Text = "Remove"
        Me.colPCDel.UseColumnTextForButtonValue = True
        Me.colPCDel.Width = 60
        '
        'pnlPC
        '
        Me.pnlPC.Controls.Add(Me.btnPCCancel)
        Me.pnlPC.Controls.Add(Me.btnPCSave)
        Me.pnlPC.Controls.Add(Me.cboPCComp)
        Me.pnlPC.Controls.Add(Me.lblPCComp)
        Me.pnlPC.Controls.Add(Me.txtPCDesc)
        Me.pnlPC.Controls.Add(Me.lblPCDesc)
        Me.pnlPC.Controls.Add(Me.txtPCCode)
        Me.pnlPC.Controls.Add(Me.lblPCCode)
        Me.pnlPC.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPC.Location = New System.Drawing.Point(3, 3)
        Me.pnlPC.Name = "pnlPC"
        Me.pnlPC.Size = New System.Drawing.Size(902, 127)
        Me.pnlPC.TabIndex = 13
        '
        'btnPCCancel
        '
        Me.btnPCCancel.Image = CType(resources.GetObject("btnPCCancel.Image"), System.Drawing.Image)
        Me.btnPCCancel.Location = New System.Drawing.Point(208, 86)
        Me.btnPCCancel.Name = "btnPCCancel"
        Me.btnPCCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPCCancel.TabIndex = 53
        Me.btnPCCancel.Text = "Cancel"
        Me.btnPCCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPCCancel.UseVisualStyleBackColor = True
        '
        'btnPCSave
        '
        Me.btnPCSave.Image = CType(resources.GetObject("btnPCSave.Image"), System.Drawing.Image)
        Me.btnPCSave.Location = New System.Drawing.Point(130, 86)
        Me.btnPCSave.Name = "btnPCSave"
        Me.btnPCSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPCSave.TabIndex = 52
        Me.btnPCSave.Text = "Save"
        Me.btnPCSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPCSave.UseVisualStyleBackColor = True
        '
        'cboPCComp
        '
        Me.cboPCComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPCComp.FormattingEnabled = True
        Me.cboPCComp.Location = New System.Drawing.Point(130, 10)
        Me.cboPCComp.Name = "cboPCComp"
        Me.cboPCComp.Size = New System.Drawing.Size(350, 22)
        Me.cboPCComp.TabIndex = 5
        '
        'lblPCComp
        '
        Me.lblPCComp.AutoSize = True
        Me.lblPCComp.Location = New System.Drawing.Point(7, 13)
        Me.lblPCComp.Name = "lblPCComp"
        Me.lblPCComp.Size = New System.Drawing.Size(56, 14)
        Me.lblPCComp.TabIndex = 4
        Me.lblPCComp.Text = "Company"
        '
        'txtPCDesc
        '
        Me.txtPCDesc.Location = New System.Drawing.Point(130, 58)
        Me.txtPCDesc.MaxLength = 150
        Me.txtPCDesc.Name = "txtPCDesc"
        Me.txtPCDesc.Size = New System.Drawing.Size(350, 22)
        Me.txtPCDesc.TabIndex = 3
        '
        'lblPCDesc
        '
        Me.lblPCDesc.AutoSize = True
        Me.lblPCDesc.Location = New System.Drawing.Point(7, 61)
        Me.lblPCDesc.Name = "lblPCDesc"
        Me.lblPCDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblPCDesc.TabIndex = 2
        Me.lblPCDesc.Text = "Description"
        '
        'txtPCCode
        '
        Me.txtPCCode.Location = New System.Drawing.Point(130, 34)
        Me.txtPCCode.MaxLength = 25
        Me.txtPCCode.Name = "txtPCCode"
        Me.txtPCCode.Size = New System.Drawing.Size(150, 22)
        Me.txtPCCode.TabIndex = 1
        '
        'lblPCCode
        '
        Me.lblPCCode.AutoSize = True
        Me.lblPCCode.Location = New System.Drawing.Point(7, 37)
        Me.lblPCCode.Name = "lblPCCode"
        Me.lblPCCode.Size = New System.Drawing.Size(82, 14)
        Me.lblPCCode.TabIndex = 0
        Me.lblPCCode.Text = "Channel Code"
        '
        'tpBanks
        '
        Me.tpBanks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpBanks.Controls.Add(Me.dgvBanks)
        Me.tpBanks.Controls.Add(Me.pnlBS)
        Me.tpBanks.Location = New System.Drawing.Point(4, 23)
        Me.tpBanks.Name = "tpBanks"
        Me.tpBanks.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBanks.Size = New System.Drawing.Size(910, 459)
        Me.tpBanks.TabIndex = 1
        Me.tpBanks.Text = "Banks Setup"
        Me.tpBanks.UseVisualStyleBackColor = True
        '
        'dgvBanks
        '
        Me.dgvBanks.AllowUserToAddRows = False
        Me.dgvBanks.AllowUserToDeleteRows = False
        Me.dgvBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBanks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBSel, Me.colBDel})
        Me.dgvBanks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBanks.Location = New System.Drawing.Point(3, 153)
        Me.dgvBanks.Name = "dgvBanks"
        Me.dgvBanks.ReadOnly = True
        Me.dgvBanks.Size = New System.Drawing.Size(902, 301)
        Me.dgvBanks.TabIndex = 12
        '
        'colBSel
        '
        Me.colBSel.Frozen = True
        Me.colBSel.HeaderText = ""
        Me.colBSel.Name = "colBSel"
        Me.colBSel.ReadOnly = True
        Me.colBSel.Text = "Select"
        Me.colBSel.UseColumnTextForButtonValue = True
        Me.colBSel.Width = 60
        '
        'colBDel
        '
        Me.colBDel.Frozen = True
        Me.colBDel.HeaderText = ""
        Me.colBDel.Name = "colBDel"
        Me.colBDel.ReadOnly = True
        Me.colBDel.Text = "Remove"
        Me.colBDel.UseColumnTextForButtonValue = True
        Me.colBDel.Width = 60
        '
        'pnlBS
        '
        Me.pnlBS.Controls.Add(Me.cboBChannel)
        Me.pnlBS.Controls.Add(Me.Label2)
        Me.pnlBS.Controls.Add(Me.btnBCancel)
        Me.pnlBS.Controls.Add(Me.btnBSave)
        Me.pnlBS.Controls.Add(Me.cboBComp)
        Me.pnlBS.Controls.Add(Me.lblBComp)
        Me.pnlBS.Controls.Add(Me.txtBName)
        Me.pnlBS.Controls.Add(Me.lblBName)
        Me.pnlBS.Controls.Add(Me.txtBCode)
        Me.pnlBS.Controls.Add(Me.lblBCode)
        Me.pnlBS.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBS.Location = New System.Drawing.Point(3, 3)
        Me.pnlBS.Name = "pnlBS"
        Me.pnlBS.Size = New System.Drawing.Size(902, 150)
        Me.pnlBS.TabIndex = 11
        '
        'cboBChannel
        '
        Me.cboBChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBChannel.FormattingEnabled = True
        Me.cboBChannel.Location = New System.Drawing.Point(130, 35)
        Me.cboBChannel.Name = "cboBChannel"
        Me.cboBChannel.Size = New System.Drawing.Size(350, 22)
        Me.cboBChannel.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Pay Channel"
        '
        'btnBCancel
        '
        Me.btnBCancel.Image = CType(resources.GetObject("btnBCancel.Image"), System.Drawing.Image)
        Me.btnBCancel.Location = New System.Drawing.Point(208, 112)
        Me.btnBCancel.Name = "btnBCancel"
        Me.btnBCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnBCancel.TabIndex = 53
        Me.btnBCancel.Text = "Cancel"
        Me.btnBCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBCancel.UseVisualStyleBackColor = True
        '
        'btnBSave
        '
        Me.btnBSave.Image = CType(resources.GetObject("btnBSave.Image"), System.Drawing.Image)
        Me.btnBSave.Location = New System.Drawing.Point(130, 112)
        Me.btnBSave.Name = "btnBSave"
        Me.btnBSave.Size = New System.Drawing.Size(77, 29)
        Me.btnBSave.TabIndex = 52
        Me.btnBSave.Text = "Save"
        Me.btnBSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBSave.UseVisualStyleBackColor = True
        '
        'cboBComp
        '
        Me.cboBComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBComp.FormattingEnabled = True
        Me.cboBComp.Location = New System.Drawing.Point(130, 10)
        Me.cboBComp.Name = "cboBComp"
        Me.cboBComp.Size = New System.Drawing.Size(350, 22)
        Me.cboBComp.TabIndex = 5
        '
        'lblBComp
        '
        Me.lblBComp.AutoSize = True
        Me.lblBComp.Location = New System.Drawing.Point(7, 13)
        Me.lblBComp.Name = "lblBComp"
        Me.lblBComp.Size = New System.Drawing.Size(56, 14)
        Me.lblBComp.TabIndex = 4
        Me.lblBComp.Text = "Company"
        '
        'txtBName
        '
        Me.txtBName.Location = New System.Drawing.Point(130, 84)
        Me.txtBName.MaxLength = 150
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(350, 22)
        Me.txtBName.TabIndex = 3
        '
        'lblBName
        '
        Me.lblBName.AutoSize = True
        Me.lblBName.Location = New System.Drawing.Point(7, 87)
        Me.lblBName.Name = "lblBName"
        Me.lblBName.Size = New System.Drawing.Size(69, 14)
        Me.lblBName.TabIndex = 2
        Me.lblBName.Text = "Bank Name"
        '
        'txtBCode
        '
        Me.txtBCode.Location = New System.Drawing.Point(130, 60)
        Me.txtBCode.MaxLength = 25
        Me.txtBCode.Name = "txtBCode"
        Me.txtBCode.Size = New System.Drawing.Size(150, 22)
        Me.txtBCode.TabIndex = 1
        '
        'lblBCode
        '
        Me.lblBCode.AutoSize = True
        Me.lblBCode.Location = New System.Drawing.Point(7, 63)
        Me.lblBCode.Name = "lblBCode"
        Me.lblBCode.Size = New System.Drawing.Size(64, 14)
        Me.lblBCode.TabIndex = 0
        Me.lblBCode.Text = "Bank Code"
        '
        'tpPProc
        '
        Me.tpPProc.AutoScroll = True
        Me.tpPProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpPProc.Controls.Add(Me.dgvPPR)
        Me.tpPProc.Controls.Add(Me.pnlPPR)
        Me.tpPProc.Location = New System.Drawing.Point(4, 23)
        Me.tpPProc.Name = "tpPProc"
        Me.tpPProc.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPProc.Size = New System.Drawing.Size(926, 494)
        Me.tpPProc.TabIndex = 5
        Me.tpPProc.Text = "Payroll Processors"
        Me.tpPProc.UseVisualStyleBackColor = True
        '
        'dgvPPR
        '
        Me.dgvPPR.AllowUserToAddRows = False
        Me.dgvPPR.AllowUserToDeleteRows = False
        Me.dgvPPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPPR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPPRSel, Me.colPPRDel})
        Me.dgvPPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPPR.Location = New System.Drawing.Point(3, 153)
        Me.dgvPPR.Name = "dgvPPR"
        Me.dgvPPR.ReadOnly = True
        Me.dgvPPR.Size = New System.Drawing.Size(918, 336)
        Me.dgvPPR.TabIndex = 15
        '
        'colPPRSel
        '
        Me.colPPRSel.Frozen = True
        Me.colPPRSel.HeaderText = ""
        Me.colPPRSel.Name = "colPPRSel"
        Me.colPPRSel.ReadOnly = True
        Me.colPPRSel.Text = "Select"
        Me.colPPRSel.UseColumnTextForButtonValue = True
        Me.colPPRSel.Width = 60
        '
        'colPPRDel
        '
        Me.colPPRDel.Frozen = True
        Me.colPPRDel.HeaderText = ""
        Me.colPPRDel.Name = "colPPRDel"
        Me.colPPRDel.ReadOnly = True
        Me.colPPRDel.Text = "Remove"
        Me.colPPRDel.UseColumnTextForButtonValue = True
        Me.colPPRDel.Width = 60
        '
        'pnlPPR
        '
        Me.pnlPPR.Controls.Add(Me.cboPPRComp)
        Me.pnlPPR.Controls.Add(Me.lblPPRComp)
        Me.pnlPPR.Controls.Add(Me.btnPPRCancel)
        Me.pnlPPR.Controls.Add(Me.btnPPRSave)
        Me.pnlPPR.Controls.Add(Me.cboPPProc)
        Me.pnlPPR.Controls.Add(Me.lblPPProc)
        Me.pnlPPR.Controls.Add(Me.cboPPREG)
        Me.pnlPPR.Controls.Add(Me.cboPPREC)
        Me.pnlPPR.Controls.Add(Me.lblPPREG)
        Me.pnlPPR.Controls.Add(Me.lblPPREC)
        Me.pnlPPR.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPPR.Location = New System.Drawing.Point(3, 3)
        Me.pnlPPR.Name = "pnlPPR"
        Me.pnlPPR.Size = New System.Drawing.Size(918, 150)
        Me.pnlPPR.TabIndex = 0
        '
        'cboPPRComp
        '
        Me.cboPPRComp.BackColor = System.Drawing.Color.White
        Me.cboPPRComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPRComp.FormattingEnabled = True
        Me.cboPPRComp.Location = New System.Drawing.Point(150, 9)
        Me.cboPPRComp.Name = "cboPPRComp"
        Me.cboPPRComp.Size = New System.Drawing.Size(350, 22)
        Me.cboPPRComp.TabIndex = 57
        '
        'lblPPRComp
        '
        Me.lblPPRComp.AutoSize = True
        Me.lblPPRComp.Location = New System.Drawing.Point(7, 12)
        Me.lblPPRComp.Name = "lblPPRComp"
        Me.lblPPRComp.Size = New System.Drawing.Size(56, 14)
        Me.lblPPRComp.TabIndex = 56
        Me.lblPPRComp.Text = "Company"
        '
        'btnPPRCancel
        '
        Me.btnPPRCancel.Image = CType(resources.GetObject("btnPPRCancel.Image"), System.Drawing.Image)
        Me.btnPPRCancel.Location = New System.Drawing.Point(228, 112)
        Me.btnPPRCancel.Name = "btnPPRCancel"
        Me.btnPPRCancel.Size = New System.Drawing.Size(77, 29)
        Me.btnPPRCancel.TabIndex = 55
        Me.btnPPRCancel.Text = "Cancel"
        Me.btnPPRCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPPRCancel.UseVisualStyleBackColor = True
        '
        'btnPPRSave
        '
        Me.btnPPRSave.Image = CType(resources.GetObject("btnPPRSave.Image"), System.Drawing.Image)
        Me.btnPPRSave.Location = New System.Drawing.Point(150, 112)
        Me.btnPPRSave.Name = "btnPPRSave"
        Me.btnPPRSave.Size = New System.Drawing.Size(77, 29)
        Me.btnPPRSave.TabIndex = 54
        Me.btnPPRSave.Text = "Save"
        Me.btnPPRSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPPRSave.UseVisualStyleBackColor = True
        '
        'cboPPProc
        '
        Me.cboPPProc.BackColor = System.Drawing.Color.White
        Me.cboPPProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPProc.FormattingEnabled = True
        Me.cboPPProc.Location = New System.Drawing.Point(150, 84)
        Me.cboPPProc.Name = "cboPPProc"
        Me.cboPPProc.Size = New System.Drawing.Size(350, 22)
        Me.cboPPProc.TabIndex = 5
        '
        'lblPPProc
        '
        Me.lblPPProc.AutoSize = True
        Me.lblPPProc.Location = New System.Drawing.Point(7, 87)
        Me.lblPPProc.Name = "lblPPProc"
        Me.lblPPProc.Size = New System.Drawing.Size(99, 14)
        Me.lblPPProc.TabIndex = 4
        Me.lblPPProc.Text = "Payroll Processor"
        '
        'cboPPREG
        '
        Me.cboPPREG.BackColor = System.Drawing.Color.White
        Me.cboPPREG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPREG.FormattingEnabled = True
        Me.cboPPREG.Location = New System.Drawing.Point(150, 59)
        Me.cboPPREG.Name = "cboPPREG"
        Me.cboPPREG.Size = New System.Drawing.Size(350, 22)
        Me.cboPPREG.TabIndex = 3
        '
        'cboPPREC
        '
        Me.cboPPREC.BackColor = System.Drawing.Color.White
        Me.cboPPREC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPPREC.FormattingEnabled = True
        Me.cboPPREC.Location = New System.Drawing.Point(150, 34)
        Me.cboPPREC.Name = "cboPPREC"
        Me.cboPPREC.Size = New System.Drawing.Size(350, 22)
        Me.cboPPREC.TabIndex = 2
        '
        'lblPPREG
        '
        Me.lblPPREG.AutoSize = True
        Me.lblPPREG.Location = New System.Drawing.Point(7, 62)
        Me.lblPPREG.Name = "lblPPREG"
        Me.lblPPREG.Size = New System.Drawing.Size(96, 14)
        Me.lblPPREG.TabIndex = 1
        Me.lblPPREG.Text = "Employee Group"
        '
        'lblPPREC
        '
        Me.lblPPREC.AutoSize = True
        Me.lblPPREC.Location = New System.Drawing.Point(7, 37)
        Me.lblPPREC.Name = "lblPPREC"
        Me.lblPPREC.Size = New System.Drawing.Size(92, 14)
        Me.lblPPREC.TabIndex = 0
        Me.lblPPREC.Text = "Employee Class"
        '
        'lblPRB
        '
        Me.lblPRB.AutoSize = True
        Me.lblPRB.Location = New System.Drawing.Point(7, 87)
        Me.lblPRB.Name = "lblPRB"
        Me.lblPRB.Size = New System.Drawing.Size(37, 14)
        Me.lblPRB.TabIndex = 56
        Me.lblPRB.Text = "Basis"
        '
        'cboPRB
        '
        Me.cboPRB.FormattingEnabled = True
        Me.cboPRB.Items.AddRange(New Object() {"- Select Basis -", "Daily", "Monthly"})
        Me.cboPRB.Location = New System.Drawing.Point(130, 84)
        Me.cboPRB.Name = "cboPRB"
        Me.cboPRB.Size = New System.Drawing.Size(150, 22)
        Me.cboPRB.TabIndex = 57
        '
        'frmPayrollSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 521)
        Me.Controls.Add(Me.tcPS)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayrollSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Setup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcPS.ResumeLayout(False)
        Me.tpTB.ResumeLayout(False)
        Me.tcTB.ResumeLayout(False)
        Me.tpTBET.ResumeLayout(False)
        CType(Me.dgvET, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTBET.ResumeLayout(False)
        Me.pnlTBET.PerformLayout()
        Me.tpTBTEB.ResumeLayout(False)
        CType(Me.dgvTEB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTBTEB.ResumeLayout(False)
        Me.pnlTBTEB.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.dgvATB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTBATB.ResumeLayout(False)
        Me.pnlTBATB.PerformLayout()
        Me.tpSD.ResumeLayout(False)
        Me.tcSD.ResumeLayout(False)
        Me.tpSSS.ResumeLayout(False)
        Me.tcSSetting.ResumeLayout(False)
        Me.tpSSSSettings.ResumeLayout(False)
        CType(Me.dgvSSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSSet.ResumeLayout(False)
        Me.pnlSSet.PerformLayout()
        Me.tpSSSMatrix.ResumeLayout(False)
        CType(Me.dgvSSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSSS.ResumeLayout(False)
        Me.pnlSSS.PerformLayout()
        Me.tpPhilhealth.ResumeLayout(False)
        Me.tcPSetting.ResumeLayout(False)
        Me.TabPage19.ResumeLayout(False)
        CType(Me.dgvPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPS.ResumeLayout(False)
        Me.pnlPS.PerformLayout()
        Me.TabPage18.ResumeLayout(False)
        CType(Me.dgvPH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPH.ResumeLayout(False)
        Me.pnlPH.PerformLayout()
        Me.tpHDMF.ResumeLayout(False)
        Me.tcHSetting.ResumeLayout(False)
        Me.TabPage21.ResumeLayout(False)
        CType(Me.dgvHS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHS.ResumeLayout(False)
        Me.pnlHS.PerformLayout()
        Me.TabPage20.ResumeLayout(False)
        CType(Me.dgvHDMF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHDMF.ResumeLayout(False)
        Me.pnlHDMF.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        CType(Me.dgvEC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEC.ResumeLayout(False)
        Me.pnlEC.PerformLayout()
        Me.tpPayParams.ResumeLayout(False)
        Me.tcPayParams.ResumeLayout(False)
        Me.tpPR.ResumeLayout(False)
        CType(Me.dgvPRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPRef.ResumeLayout(False)
        Me.pnlPRef.PerformLayout()
        Me.tpPB.ResumeLayout(False)
        CType(Me.dgvPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPB.ResumeLayout(False)
        Me.pnlPB.PerformLayout()
        Me.tpPAT.ResumeLayout(False)
        CType(Me.dgvPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPA.ResumeLayout(False)
        Me.pnlPA.PerformLayout()
        Me.tpPPS.ResumeLayout(False)
        CType(Me.dgvPPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPPS.ResumeLayout(False)
        Me.pnlPPS.PerformLayout()
        Me.tpPPR.ResumeLayout(False)
        Me.tcRates.ResumeLayout(False)
        Me.tpRateList.ResumeLayout(False)
        CType(Me.dgvPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPR.ResumeLayout(False)
        Me.pnlPR.PerformLayout()
        Me.tpRPR.ResumeLayout(False)
        Me.tpRPR.PerformLayout()
        Me.pnlPRStandard.ResumeLayout(False)
        Me.pnlPRStandard.PerformLayout()
        Me.tpSPC.ResumeLayout(False)
        Me.tpSPC.PerformLayout()
        Me.pnlPRCustom.ResumeLayout(False)
        Me.pnlPRCustom.PerformLayout()
        Me.TabPage15.ResumeLayout(False)
        Me.tcPSet.ResumeLayout(False)
        Me.tpPayChannels.ResumeLayout(False)
        CType(Me.dgvPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPC.ResumeLayout(False)
        Me.pnlPC.PerformLayout()
        Me.tpBanks.ResumeLayout(False)
        CType(Me.dgvBanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBS.ResumeLayout(False)
        Me.pnlBS.PerformLayout()
        Me.tpPProc.ResumeLayout(False)
        CType(Me.dgvPPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPPR.ResumeLayout(False)
        Me.pnlPPR.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcPS As System.Windows.Forms.TabControl
    Friend WithEvents tpTB As System.Windows.Forms.TabPage
    Friend WithEvents tcTB As System.Windows.Forms.TabControl
    Friend WithEvents tpTBET As System.Windows.Forms.TabPage
    Friend WithEvents tpTBTEB As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents tpSD As System.Windows.Forms.TabPage
    Friend WithEvents tcSD As System.Windows.Forms.TabControl
    Friend WithEvents tpSSS As System.Windows.Forms.TabPage
    Friend WithEvents tpPhilhealth As System.Windows.Forms.TabPage
    Friend WithEvents tpHDMF As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents tpPayParams As System.Windows.Forms.TabPage
    Friend WithEvents tcPayParams As System.Windows.Forms.TabControl
    Friend WithEvents tpPR As System.Windows.Forms.TabPage
    Friend WithEvents tpPB As System.Windows.Forms.TabPage
    Friend WithEvents tpPAT As System.Windows.Forms.TabPage
    Friend WithEvents tpPPS As System.Windows.Forms.TabPage
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Private WithEvents dgvET As System.Windows.Forms.DataGridView
    Private WithEvents pnlTBET As System.Windows.Forms.Panel
    Private WithEvents txtETDesc As System.Windows.Forms.TextBox
    Private WithEvents lblETDesc As System.Windows.Forms.Label
    Private WithEvents txtETCode As System.Windows.Forms.TextBox
    Private WithEvents lblETCode As System.Windows.Forms.Label
    Private WithEvents btnETCancel As System.Windows.Forms.Button
    Private WithEvents btnETSave As System.Windows.Forms.Button
    Private WithEvents dgvTEB As System.Windows.Forms.DataGridView
    Private WithEvents pnlTBTEB As System.Windows.Forms.Panel
    Private WithEvents txtTEBPlusEx As System.Windows.Forms.TextBox
    Private WithEvents txtTEBPlusPCT As System.Windows.Forms.TextBox
    Private WithEvents lblAppTaxLabel As System.Windows.Forms.Label
    Private WithEvents txtTEBAT As System.Windows.Forms.TextBox
    Private WithEvents lblTEBAT As System.Windows.Forms.Label
    Private WithEvents lblTEBPE As System.Windows.Forms.Label
    Private WithEvents txtTEBPE As System.Windows.Forms.TextBox
    Private WithEvents cboTEBPayBasis As System.Windows.Forms.ComboBox
    Private WithEvents lblTEBET As System.Windows.Forms.Label
    Private WithEvents cboTEBET As System.Windows.Forms.ComboBox
    Private WithEvents lblTEBPayBasis As System.Windows.Forms.Label
    Private WithEvents btnTEBCancel As System.Windows.Forms.Button
    Private WithEvents btnTEBSave As System.Windows.Forms.Button
    Private WithEvents dgvATB As System.Windows.Forms.DataGridView
    Private WithEvents pnlTBATB As System.Windows.Forms.Panel
    Private WithEvents txtATBPlusEx As System.Windows.Forms.TextBox
    Private WithEvents txtATBPlusPct As System.Windows.Forms.TextBox
    Private WithEvents lblTBPlus As System.Windows.Forms.Label
    Private WithEvents txtATBAT As System.Windows.Forms.TextBox
    Private WithEvents lblATBAT As System.Windows.Forms.Label
    Private WithEvents txtATBBEnd As System.Windows.Forms.TextBox
    Private WithEvents lblTBTo As System.Windows.Forms.Label
    Private WithEvents txtATBBStart As System.Windows.Forms.TextBox
    Private WithEvents lblATBTB As System.Windows.Forms.Label
    Private WithEvents btnATBCancel As System.Windows.Forms.Button
    Private WithEvents btnATBSave As System.Windows.Forms.Button
    Friend WithEvents tcSSetting As System.Windows.Forms.TabControl
    Friend WithEvents tpSSSMatrix As System.Windows.Forms.TabPage
    Private WithEvents dgvSSS As System.Windows.Forms.DataGridView
    Private WithEvents pnlSSS As System.Windows.Forms.Panel
    Private WithEvents btnSCancel As System.Windows.Forms.Button
    Private WithEvents btnSSave As System.Windows.Forms.Button
    Private WithEvents txtSEEShare As System.Windows.Forms.TextBox
    Private WithEvents txtERSPlusAdj As System.Windows.Forms.TextBox
    Private WithEvents lblSPlus As System.Windows.Forms.Label
    Private WithEvents txtSERShare As System.Windows.Forms.TextBox
    Private WithEvents lblSEEShare As System.Windows.Forms.Label
    Private WithEvents txtSSC As System.Windows.Forms.TextBox
    Private WithEvents txtSSBEnd As System.Windows.Forms.TextBox
    Private WithEvents lblSTo As System.Windows.Forms.Label
    Private WithEvents txtSSBStart As System.Windows.Forms.TextBox
    Private WithEvents lblSERShare As System.Windows.Forms.Label
    Private WithEvents lblSSC As System.Windows.Forms.Label
    Private WithEvents lblSSB As System.Windows.Forms.Label
    Friend WithEvents tpSSSSettings As System.Windows.Forms.TabPage
    Private WithEvents dgvSSet As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSSet As System.Windows.Forms.Panel
    Friend WithEvents lblSSetRef As System.Windows.Forms.Label
    Friend WithEvents cboSSetSched As System.Windows.Forms.ComboBox
    Friend WithEvents lblSSetSched As System.Windows.Forms.Label
    Friend WithEvents cboSSetCB As System.Windows.Forms.ComboBox
    Friend WithEvents lblSSetCB As System.Windows.Forms.Label
    Friend WithEvents txtSSRef1EE As System.Windows.Forms.TextBox
    Friend WithEvents rdbSSRef1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSSRef0 As System.Windows.Forms.RadioButton
    Friend WithEvents cboSSetComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblSSetComp As System.Windows.Forms.Label
    Private WithEvents btnSSetCancel As System.Windows.Forms.Button
    Private WithEvents btnSSetSave As System.Windows.Forms.Button
    Friend WithEvents tcPSetting As System.Windows.Forms.TabControl
    Friend WithEvents TabPage18 As System.Windows.Forms.TabPage
    Private WithEvents dgvPH As System.Windows.Forms.DataGridView
    Private WithEvents pnlPH As System.Windows.Forms.Panel
    Private WithEvents btnPHCancel As System.Windows.Forms.Button
    Private WithEvents btnPHSave As System.Windows.Forms.Button
    Private WithEvents txtPHERShare As System.Windows.Forms.TextBox
    Private WithEvents txtPHERPlusAdj As System.Windows.Forms.TextBox
    Private WithEvents lblPPlus As System.Windows.Forms.Label
    Private WithEvents txtPHEEShare As System.Windows.Forms.TextBox
    Private WithEvents lblPHEEShare As System.Windows.Forms.Label
    Private WithEvents txtPHSC As System.Windows.Forms.TextBox
    Private WithEvents txtPHSBEnd As System.Windows.Forms.TextBox
    Private WithEvents lblPTo As System.Windows.Forms.Label
    Private WithEvents txtPHSBStart As System.Windows.Forms.TextBox
    Private WithEvents lblPHERShare As System.Windows.Forms.Label
    Private WithEvents lblPHSC As System.Windows.Forms.Label
    Private WithEvents lblPHSB As System.Windows.Forms.Label
    Friend WithEvents TabPage19 As System.Windows.Forms.TabPage
    Private WithEvents dgvPS As System.Windows.Forms.DataGridView
    Friend WithEvents pnlPS As System.Windows.Forms.Panel
    Friend WithEvents lblPSRef As System.Windows.Forms.Label
    Friend WithEvents cboPSSched As System.Windows.Forms.ComboBox
    Friend WithEvents lblPSSched As System.Windows.Forms.Label
    Friend WithEvents cboPSCB As System.Windows.Forms.ComboBox
    Friend WithEvents lblPSCB As System.Windows.Forms.Label
    Friend WithEvents txtPSRef1EE As System.Windows.Forms.TextBox
    Friend WithEvents rdbPSRef1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPSRef0 As System.Windows.Forms.RadioButton
    Friend WithEvents cboPSComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblPSComp As System.Windows.Forms.Label
    Private WithEvents btnPSCancel As System.Windows.Forms.Button
    Private WithEvents btnPSSave As System.Windows.Forms.Button
    Friend WithEvents tcHSetting As System.Windows.Forms.TabControl
    Friend WithEvents TabPage20 As System.Windows.Forms.TabPage
    Private WithEvents dgvHDMF As System.Windows.Forms.DataGridView
    Private WithEvents colHDMFSelect As System.Windows.Forms.DataGridViewButtonColumn
    Private WithEvents colHDMFDel As System.Windows.Forms.DataGridViewButtonColumn
    Private WithEvents pnlHDMF As System.Windows.Forms.Panel
    Private WithEvents btnHDMFCancel As System.Windows.Forms.Button
    Private WithEvents btnHDMFSave As System.Windows.Forms.Button
    Private WithEvents chkHDEE As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage21 As System.Windows.Forms.TabPage
    Private WithEvents dgvHS As System.Windows.Forms.DataGridView
    Friend WithEvents pnlHS As System.Windows.Forms.Panel
    Friend WithEvents lblHSRef As System.Windows.Forms.Label
    Friend WithEvents cboHSSched As System.Windows.Forms.ComboBox
    Friend WithEvents lblHSSched As System.Windows.Forms.Label
    Friend WithEvents cboHSCB As System.Windows.Forms.ComboBox
    Friend WithEvents lblHSCB As System.Windows.Forms.Label
    Friend WithEvents txtHSRef1EE As System.Windows.Forms.TextBox
    Friend WithEvents rdbHSRef1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHSRef0 As System.Windows.Forms.RadioButton
    Friend WithEvents cboHSComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblHSComp As System.Windows.Forms.Label
    Private WithEvents btnHSCancel As System.Windows.Forms.Button
    Private WithEvents btnHSSave As System.Windows.Forms.Button
    Private WithEvents dgvEC As System.Windows.Forms.DataGridView
    Private WithEvents pnlEC As System.Windows.Forms.Panel
    Private WithEvents btnECCancel As System.Windows.Forms.Button
    Private WithEvents btnECSave As System.Windows.Forms.Button
    Private WithEvents chkECProRate As System.Windows.Forms.CheckBox
    Private WithEvents txtECAR As System.Windows.Forms.TextBox
    Private WithEvents lblECAR As System.Windows.Forms.Label
    Private WithEvents txtECDesc As System.Windows.Forms.TextBox
    Private WithEvents lblECDesc As System.Windows.Forms.Label
    Private WithEvents txtECCode As System.Windows.Forms.TextBox
    Private WithEvents lblECCode As System.Windows.Forms.Label
    Private WithEvents cboECComp As System.Windows.Forms.ComboBox
    Private WithEvents lblECComp As System.Windows.Forms.Label
    Private WithEvents dgvPRef As System.Windows.Forms.DataGridView
    Private WithEvents pnlPRef As System.Windows.Forms.Panel
    Private WithEvents btnPFCancel As System.Windows.Forms.Button
    Private WithEvents btnPFSave As System.Windows.Forms.Button
    Private WithEvents txtPRDesc As System.Windows.Forms.TextBox
    Private WithEvents lblPRDesc As System.Windows.Forms.Label
    Private WithEvents txtPRCode As System.Windows.Forms.TextBox
    Private WithEvents lblPRCode As System.Windows.Forms.Label
    Private WithEvents dgvPB As System.Windows.Forms.DataGridView
    Private WithEvents pnlPB As System.Windows.Forms.Panel
    Private WithEvents btnPBCancel As System.Windows.Forms.Button
    Private WithEvents btnPBSave As System.Windows.Forms.Button
    Private WithEvents txtPBDesc As System.Windows.Forms.TextBox
    Private WithEvents lblPBDesc As System.Windows.Forms.Label
    Private WithEvents txtPBCode As System.Windows.Forms.TextBox
    Private WithEvents lblPBCode As System.Windows.Forms.Label
    Private WithEvents dgvPA As System.Windows.Forms.DataGridView
    Private WithEvents pnlPA As System.Windows.Forms.Panel
    Private WithEvents cboPAComp As System.Windows.Forms.ComboBox
    Private WithEvents lblPAComp As System.Windows.Forms.Label
    Private WithEvents btnPACancel As System.Windows.Forms.Button
    Private WithEvents btnPASave As System.Windows.Forms.Button
    Private WithEvents txtPADesc As System.Windows.Forms.TextBox
    Private WithEvents lblPADesc As System.Windows.Forms.Label
    Private WithEvents txtPACode As System.Windows.Forms.TextBox
    Private WithEvents lblPACode As System.Windows.Forms.Label
    Private WithEvents dgvPPS As System.Windows.Forms.DataGridView
    Private WithEvents pnlPPS As System.Windows.Forms.Panel
    Private WithEvents cboPPComp As System.Windows.Forms.ComboBox
    Private WithEvents lblPPComp As System.Windows.Forms.Label
    Private WithEvents chkPPNM As System.Windows.Forms.CheckBox
    Private WithEvents cboPPSequence As System.Windows.Forms.ComboBox
    Private WithEvents lblPPSequence As System.Windows.Forms.Label
    Private WithEvents btnPPCancel As System.Windows.Forms.Button
    Private WithEvents btnPPSave As System.Windows.Forms.Button
    Private WithEvents txtPPPayDate As System.Windows.Forms.TextBox
    Private WithEvents lblPPPayDate As System.Windows.Forms.Label
    Private WithEvents txtPPCovTo As System.Windows.Forms.TextBox
    Private WithEvents txtPPCovFrom As System.Windows.Forms.TextBox
    Private WithEvents lblPPCov As System.Windows.Forms.Label
    Private WithEvents lblPPCoverage As System.Windows.Forms.Label
    Private WithEvents txtPPDesc As System.Windows.Forms.TextBox
    Private WithEvents lblPPDesc As System.Windows.Forms.Label
    Private WithEvents txtPPCode As System.Windows.Forms.TextBox
    Private WithEvents lblPPCode As System.Windows.Forms.Label
    Private WithEvents lblPPPDate As System.Windows.Forms.Label
    Friend WithEvents tpPPR As System.Windows.Forms.TabPage
    Friend WithEvents tcPSet As System.Windows.Forms.TabControl
    Friend WithEvents tpPayChannels As System.Windows.Forms.TabPage
    Private WithEvents dgvPC As System.Windows.Forms.DataGridView
    Private WithEvents pnlPC As System.Windows.Forms.Panel
    Private WithEvents btnPCCancel As System.Windows.Forms.Button
    Private WithEvents btnPCSave As System.Windows.Forms.Button
    Private WithEvents cboPCComp As System.Windows.Forms.ComboBox
    Private WithEvents lblPCComp As System.Windows.Forms.Label
    Private WithEvents txtPCDesc As System.Windows.Forms.TextBox
    Private WithEvents lblPCDesc As System.Windows.Forms.Label
    Private WithEvents txtPCCode As System.Windows.Forms.TextBox
    Private WithEvents lblPCCode As System.Windows.Forms.Label
    Friend WithEvents tpBanks As System.Windows.Forms.TabPage
    Private WithEvents dgvBanks As System.Windows.Forms.DataGridView
    Private WithEvents pnlBS As System.Windows.Forms.Panel
    Private WithEvents btnBCancel As System.Windows.Forms.Button
    Private WithEvents btnBSave As System.Windows.Forms.Button
    Private WithEvents cboBComp As System.Windows.Forms.ComboBox
    Private WithEvents lblBComp As System.Windows.Forms.Label
    Private WithEvents txtBName As System.Windows.Forms.TextBox
    Private WithEvents lblBName As System.Windows.Forms.Label
    Private WithEvents txtBCode As System.Windows.Forms.TextBox
    Private WithEvents lblBCode As System.Windows.Forms.Label
    Friend WithEvents tpPProc As System.Windows.Forms.TabPage
    Private WithEvents dgvPPR As System.Windows.Forms.DataGridView
    Friend WithEvents pnlPPR As System.Windows.Forms.Panel
    Private WithEvents btnPPRCancel As System.Windows.Forms.Button
    Private WithEvents btnPPRSave As System.Windows.Forms.Button
    Friend WithEvents cboPPProc As System.Windows.Forms.ComboBox
    Friend WithEvents lblPPProc As System.Windows.Forms.Label
    Friend WithEvents cboPPREG As System.Windows.Forms.ComboBox
    Friend WithEvents cboPPREC As System.Windows.Forms.ComboBox
    Friend WithEvents lblPPREG As System.Windows.Forms.Label
    Friend WithEvents lblPPREC As System.Windows.Forms.Label
    Friend WithEvents cboPPRComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblPPRComp As System.Windows.Forms.Label
    Friend WithEvents colETSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colETDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colTEBSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colTEBDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colATSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colATDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSCMSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSCMDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPSetSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPSetDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPCMSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPCMDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colHSetSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colHSetDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colESel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colEDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPFSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPFDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPBSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPBDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPATSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPATDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPPSSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPPSDel As System.Windows.Forms.DataGridViewButtonColumn
    Private WithEvents tcRates As System.Windows.Forms.TabControl
    Friend WithEvents tpRateList As System.Windows.Forms.TabPage
    Private WithEvents tpRPR As System.Windows.Forms.TabPage
    Private WithEvents lblPRDH As System.Windows.Forms.Label
    Private WithEvents txtPRDHOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRDHND As System.Windows.Forms.TextBox
    Private WithEvents txtPRDHOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRDH As System.Windows.Forms.TextBox
    Private WithEvents lblPRRH As System.Windows.Forms.Label
    Private WithEvents txtPRRHOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRRH As System.Windows.Forms.TextBox
    Private WithEvents lblPRSH As System.Windows.Forms.Label
    Private WithEvents txtPRSHOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHND As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRSH As System.Windows.Forms.TextBox
    Private WithEvents lblPRRDDH As System.Windows.Forms.Label
    Private WithEvents txtPRRDDHOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDH As System.Windows.Forms.TextBox
    Private WithEvents lblPRRDRH As System.Windows.Forms.Label
    Private WithEvents txtPRRDRHOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRH As System.Windows.Forms.TextBox
    Private WithEvents lblPRRDSH As System.Windows.Forms.Label
    Private WithEvents txtPRRDSHOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSH As System.Windows.Forms.TextBox
    Private WithEvents lblPRRD As System.Windows.Forms.Label
    Private WithEvents txtPRRDOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRRD As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegOTND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegND As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegOT As System.Windows.Forms.TextBox
    Private WithEvents txtPRReg As System.Windows.Forms.TextBox
    Private WithEvents lblRegOTNS As System.Windows.Forms.Label
    Private WithEvents lblRegNS As System.Windows.Forms.Label
    Private WithEvents lblRegOT As System.Windows.Forms.Label
    Private WithEvents lblRegBR As System.Windows.Forms.Label
    Private WithEvents lblPRReg As System.Windows.Forms.Label
    Friend WithEvents tpSPC As System.Windows.Forms.TabPage
    Private WithEvents lblPRS4 As System.Windows.Forms.Label
    Private WithEvents lblPRS3 As System.Windows.Forms.Label
    Private WithEvents lblPRS2 As System.Windows.Forms.Label
    Private WithEvents lblPRS1 As System.Windows.Forms.Label
    Private WithEvents txtPRDHOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegOTNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRDHNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegNS1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRDHOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegOT1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRDH1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRH1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSH1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDH1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRH1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSH1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRD1 As System.Windows.Forms.TextBox
    Private WithEvents txtPRReg1 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSDH As System.Windows.Forms.Label
    Private WithEvents txtPRDHOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRDHNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRDHOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRDH0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSRH As System.Windows.Forms.Label
    Private WithEvents txtPRRHOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRHOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRH0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSSH As System.Windows.Forms.Label
    Private WithEvents txtPRSHOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSHOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRSH0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSRDDH As System.Windows.Forms.Label
    Private WithEvents txtPRRDDHOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDHOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDDH0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSRDRH As System.Windows.Forms.Label
    Private WithEvents txtPRRDRHOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRHOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDRH0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSRDSH As System.Windows.Forms.Label
    Private WithEvents txtPRRDSHOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSHOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDSH0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSRD As System.Windows.Forms.Label
    Private WithEvents txtPRRDOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRDOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRD0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegOTNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegNS0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRRegOT0 As System.Windows.Forms.TextBox
    Private WithEvents txtPRReg0 As System.Windows.Forms.TextBox
    Private WithEvents lblPRSOTNS As System.Windows.Forms.Label
    Private WithEvents lblPRSNS As System.Windows.Forms.Label
    Private WithEvents lblPRSPOT As System.Windows.Forms.Label
    Private WithEvents lblPRSBR As System.Windows.Forms.Label
    Private WithEvents lblPRSReg As System.Windows.Forms.Label
    Friend WithEvents colPCSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPCDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colBSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colBDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPPRSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colPPRDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblSSRef1ER As System.Windows.Forms.Label
    Friend WithEvents txtSSRef1ER As System.Windows.Forms.TextBox
    Friend WithEvents lblSSRef1EE As System.Windows.Forms.Label
    Friend WithEvents lblPSRef1ER As System.Windows.Forms.Label
    Friend WithEvents txtPSRef1ER As System.Windows.Forms.TextBox
    Friend WithEvents lblPSRef1EE As System.Windows.Forms.Label
    Friend WithEvents lblHSRef1ER As System.Windows.Forms.Label
    Friend WithEvents txtHSRef1ER As System.Windows.Forms.TextBox
    Friend WithEvents lblHSRef1EE As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkPSRef1ER As System.Windows.Forms.CheckBox
    Friend WithEvents chkPSRef1EE As System.Windows.Forms.CheckBox
    Friend WithEvents chkSSRef1ER As System.Windows.Forms.CheckBox
    Friend WithEvents chkSSRef1EE As System.Windows.Forms.CheckBox
    Friend WithEvents chkHSRef1ER As System.Windows.Forms.CheckBox
    Friend WithEvents chkHSRef1EE As System.Windows.Forms.CheckBox
    Private WithEvents chkHDER As System.Windows.Forms.CheckBox
    Private WithEvents lblHDCER As System.Windows.Forms.Label
    Private WithEvents txtHDCER As System.Windows.Forms.TextBox
    Private WithEvents txtHDERA As System.Windows.Forms.TextBox
    Private WithEvents lblHDCERA As System.Windows.Forms.Label
    Private WithEvents txtHDCEE As System.Windows.Forms.TextBox
    Private WithEvents lblHDCEE As System.Windows.Forms.Label
    Private WithEvents txtHDSC As System.Windows.Forms.TextBox
    Private WithEvents txtHDSBEnd As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtHDSBStart As System.Windows.Forms.TextBox
    Private WithEvents lblHCC As System.Windows.Forms.Label
    Private WithEvents lblHSC As System.Windows.Forms.Label
    Private WithEvents lblHSB As System.Windows.Forms.Label
    Private WithEvents txtPRDPY As System.Windows.Forms.TextBox
    Private WithEvents lblPRDPY As System.Windows.Forms.Label
    Private WithEvents lblPBCycle As System.Windows.Forms.Label
    Friend WithEvents cboPBCycle As System.Windows.Forms.ComboBox
    Friend WithEvents chkPATaxable As System.Windows.Forms.CheckBox
    Private WithEvents cboPPEG As System.Windows.Forms.ComboBox
    Private WithEvents lblPPEG As System.Windows.Forms.Label
    Private WithEvents cboPPEC As System.Windows.Forms.ComboBox
    Private WithEvents lblPPEC As System.Windows.Forms.Label
    Private WithEvents pnlPR As System.Windows.Forms.Panel
    Private WithEvents lblRSDesc As System.Windows.Forms.Label
    Private WithEvents txtRSDesc As System.Windows.Forms.TextBox
    Private WithEvents txtRSCode As System.Windows.Forms.TextBox
    Private WithEvents lblRSCode As System.Windows.Forms.Label
    Friend WithEvents chkRSSC As System.Windows.Forms.CheckBox
    Private WithEvents cboRSDept As System.Windows.Forms.ComboBox
    Private WithEvents lblRSDept As System.Windows.Forms.Label
    Private WithEvents cboRSPB As System.Windows.Forms.ComboBox
    Private WithEvents lblRSPB As System.Windows.Forms.Label
    Private WithEvents cboRSComp As System.Windows.Forms.ComboBox
    Private WithEvents lblRSComp As System.Windows.Forms.Label
    Friend WithEvents pnlPRStandard As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPRStandard As System.Windows.Forms.ComboBox
    Friend WithEvents pnlPRCustom As System.Windows.Forms.Panel
    Friend WithEvents lblPRCustom As System.Windows.Forms.Label
    Friend WithEvents cboPRCustom As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRCompCus As System.Windows.Forms.Label
    Friend WithEvents cboPRCompCus As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRCompStd As System.Windows.Forms.Label
    Friend WithEvents cboPRCompStd As System.Windows.Forms.ComboBox
    Private WithEvents dgvPR As System.Windows.Forms.DataGridView
    Friend WithEvents colSRSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSRDel As System.Windows.Forms.DataGridViewButtonColumn
    Private WithEvents btnPRCancel As System.Windows.Forms.Button
    Private WithEvents btnPRSave As System.Windows.Forms.Button
    Private WithEvents btnPRStdCancel As System.Windows.Forms.Button
    Private WithEvents btnPRStdSave As System.Windows.Forms.Button
    Private WithEvents btnPRCusCancel As System.Windows.Forms.Button
    Private WithEvents btnPRCusSave As System.Windows.Forms.Button
    Private WithEvents cboBChannel As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents lblPRS4A As System.Windows.Forms.Label
    Private WithEvents lblPRS3A As System.Windows.Forms.Label
    Private WithEvents lblPRS2A As System.Windows.Forms.Label
    Private WithEvents lblPRS1A As System.Windows.Forms.Label
    Friend WithEvents cboPRB As System.Windows.Forms.ComboBox
    Private WithEvents lblPRB As System.Windows.Forms.Label
End Class
