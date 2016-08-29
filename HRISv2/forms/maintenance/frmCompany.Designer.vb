<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompany))
        Me.tcCompany = New System.Windows.Forms.TabControl()
        Me.tpCompany = New System.Windows.Forms.TabPage()
        Me.dgvCo = New System.Windows.Forms.DataGridView()
        Me.colCompSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colCompDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlCO = New System.Windows.Forms.Panel()
        Me.txtCOWebsite = New System.Windows.Forms.TextBox()
        Me.lblCOWebsite = New System.Windows.Forms.Label()
        Me.txtCOContactNos = New System.Windows.Forms.TextBox()
        Me.lblCOContactNos = New System.Windows.Forms.Label()
        Me.txtCOHDMF = New System.Windows.Forms.TextBox()
        Me.txtCOPH = New System.Windows.Forms.TextBox()
        Me.txtCOSSS = New System.Windows.Forms.TextBox()
        Me.txtCOTIN = New System.Windows.Forms.TextBox()
        Me.txtCODTI = New System.Windows.Forms.TextBox()
        Me.txtCOSEC = New System.Windows.Forms.TextBox()
        Me.lblCOHDMF = New System.Windows.Forms.Label()
        Me.lblCOPH = New System.Windows.Forms.Label()
        Me.lblCOSSS = New System.Windows.Forms.Label()
        Me.lblCOTIN = New System.Windows.Forms.Label()
        Me.lblCODTI = New System.Windows.Forms.Label()
        Me.lblCOSEC = New System.Windows.Forms.Label()
        Me.cboCORegion = New System.Windows.Forms.ComboBox()
        Me.cboCOProv = New System.Windows.Forms.ComboBox()
        Me.cboCOCity = New System.Windows.Forms.ComboBox()
        Me.txtCOAddr = New System.Windows.Forms.TextBox()
        Me.txtCOName = New System.Windows.Forms.TextBox()
        Me.txtCOCode = New System.Windows.Forms.TextBox()
        Me.lblCORegion = New System.Windows.Forms.Label()
        Me.lblCOProv = New System.Windows.Forms.Label()
        Me.lblCOCity = New System.Windows.Forms.Label()
        Me.lblCOAddr = New System.Windows.Forms.Label()
        Me.lblCOName = New System.Windows.Forms.Label()
        Me.lblCOCode = New System.Windows.Forms.Label()
        Me.btnCOCancel = New System.Windows.Forms.Button()
        Me.btnCOSave = New System.Windows.Forms.Button()
        Me.tpDepartment = New System.Windows.Forms.TabPage()
        Me.dgvDe = New System.Windows.Forms.DataGridView()
        Me.colDeSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDeDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlDe = New System.Windows.Forms.Panel()
        Me.txtDeName = New System.Windows.Forms.TextBox()
        Me.cboDeHead = New System.Windows.Forms.ComboBox()
        Me.lblDeHead = New System.Windows.Forms.Label()
        Me.lblDeName = New System.Windows.Forms.Label()
        Me.lblDeCode = New System.Windows.Forms.Label()
        Me.cboDeComp = New System.Windows.Forms.ComboBox()
        Me.txtDeCode = New System.Windows.Forms.TextBox()
        Me.lblDeComp = New System.Windows.Forms.Label()
        Me.btnDeCancel = New System.Windows.Forms.Button()
        Me.btnDeSave = New System.Windows.Forms.Button()
        Me.tpDivision = New System.Windows.Forms.TabPage()
        Me.dgvDi = New System.Windows.Forms.DataGridView()
        Me.colDiSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDiDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlDi = New System.Windows.Forms.Panel()
        Me.cboDiDept = New System.Windows.Forms.ComboBox()
        Me.lblDiDept = New System.Windows.Forms.Label()
        Me.txtDiName = New System.Windows.Forms.TextBox()
        Me.cboDiHead = New System.Windows.Forms.ComboBox()
        Me.lblDiHead = New System.Windows.Forms.Label()
        Me.lblDiName = New System.Windows.Forms.Label()
        Me.lblDiCode = New System.Windows.Forms.Label()
        Me.cboDiComp = New System.Windows.Forms.ComboBox()
        Me.txtDiCode = New System.Windows.Forms.TextBox()
        Me.lblDiComp = New System.Windows.Forms.Label()
        Me.btnDiCancel = New System.Windows.Forms.Button()
        Me.btnDiSave = New System.Windows.Forms.Button()
        Me.tpSection = New System.Windows.Forms.TabPage()
        Me.dgvSe = New System.Windows.Forms.DataGridView()
        Me.colSeSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colSeDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlSe = New System.Windows.Forms.Panel()
        Me.cboSeDivision = New System.Windows.Forms.ComboBox()
        Me.lblSeDivision = New System.Windows.Forms.Label()
        Me.cboSeDept = New System.Windows.Forms.ComboBox()
        Me.lblSeDept = New System.Windows.Forms.Label()
        Me.txtSeName = New System.Windows.Forms.TextBox()
        Me.cboSeHead = New System.Windows.Forms.ComboBox()
        Me.lblSeHead = New System.Windows.Forms.Label()
        Me.lblSeName = New System.Windows.Forms.Label()
        Me.lblSeCode = New System.Windows.Forms.Label()
        Me.cboSeComp = New System.Windows.Forms.ComboBox()
        Me.txtSeCode = New System.Windows.Forms.TextBox()
        Me.lblSeComp = New System.Windows.Forms.Label()
        Me.btnSeCancel = New System.Windows.Forms.Button()
        Me.btnSeSave = New System.Windows.Forms.Button()
        Me.tpLaborClassification = New System.Windows.Forms.TabPage()
        Me.dgvCL = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlCL = New System.Windows.Forms.Panel()
        Me.cboCLDept = New System.Windows.Forms.ComboBox()
        Me.lblCLDept = New System.Windows.Forms.Label()
        Me.txtCLDesc = New System.Windows.Forms.TextBox()
        Me.lblCLDesc = New System.Windows.Forms.Label()
        Me.lblCLCode = New System.Windows.Forms.Label()
        Me.cboCLComp = New System.Windows.Forms.ComboBox()
        Me.txtCLCode = New System.Windows.Forms.TextBox()
        Me.lblCLComp = New System.Windows.Forms.Label()
        Me.btnCLCancel = New System.Windows.Forms.Button()
        Me.btnCLSave = New System.Windows.Forms.Button()
        Me.tpLaborLocation = New System.Windows.Forms.TabPage()
        Me.dgvLL = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboLLDept = New System.Windows.Forms.ComboBox()
        Me.lblLLDept = New System.Windows.Forms.Label()
        Me.txtLLDesc = New System.Windows.Forms.TextBox()
        Me.lblLLDesc = New System.Windows.Forms.Label()
        Me.lblLLCode = New System.Windows.Forms.Label()
        Me.cboLLComp = New System.Windows.Forms.ComboBox()
        Me.txtLLCode = New System.Windows.Forms.TextBox()
        Me.lblLLComp = New System.Windows.Forms.Label()
        Me.btnLLCancel = New System.Windows.Forms.Button()
        Me.btnLLSave = New System.Windows.Forms.Button()
        Me.tpCostCenter = New System.Windows.Forms.TabPage()
        Me.dgvLC = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlCC = New System.Windows.Forms.Panel()
        Me.cboLCDept = New System.Windows.Forms.ComboBox()
        Me.lblLCDept = New System.Windows.Forms.Label()
        Me.txtLCDesc = New System.Windows.Forms.TextBox()
        Me.lblLCDesc = New System.Windows.Forms.Label()
        Me.lblLCCode = New System.Windows.Forms.Label()
        Me.cboLCComp = New System.Windows.Forms.ComboBox()
        Me.txtLCCode = New System.Windows.Forms.TextBox()
        Me.lblLCComp = New System.Windows.Forms.Label()
        Me.btnLCCancel = New System.Windows.Forms.Button()
        Me.btnLCSave = New System.Windows.Forms.Button()
        Me.tpEmp = New System.Windows.Forms.TabPage()
        Me.tcEmp = New System.Windows.Forms.TabControl()
        Me.tpEmpClass = New System.Windows.Forms.TabPage()
        Me.dgvEC = New System.Windows.Forms.DataGridView()
        Me.colECSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colECDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlEmpClass = New System.Windows.Forms.Panel()
        Me.lblECDesc = New System.Windows.Forms.Label()
        Me.lblECCode = New System.Windows.Forms.Label()
        Me.btnECCancel = New System.Windows.Forms.Button()
        Me.btnECSave = New System.Windows.Forms.Button()
        Me.txtECDesc = New System.Windows.Forms.TextBox()
        Me.txtECCode = New System.Windows.Forms.TextBox()
        Me.cboECComp = New System.Windows.Forms.ComboBox()
        Me.lblECComp = New System.Windows.Forms.Label()
        Me.tpEmpGroup = New System.Windows.Forms.TabPage()
        Me.dgvEG = New System.Windows.Forms.DataGridView()
        Me.colEGSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colEGDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblEGDesc = New System.Windows.Forms.Label()
        Me.lblEGCode = New System.Windows.Forms.Label()
        Me.lblEGEC = New System.Windows.Forms.Label()
        Me.cboEGEC = New System.Windows.Forms.ComboBox()
        Me.btnEGCancel = New System.Windows.Forms.Button()
        Me.btnEGSave = New System.Windows.Forms.Button()
        Me.txtEGDesc = New System.Windows.Forms.TextBox()
        Me.txtEGCode = New System.Windows.Forms.TextBox()
        Me.cboEGComp = New System.Windows.Forms.ComboBox()
        Me.lblEGComp = New System.Windows.Forms.Label()
        Me.tcCompany.SuspendLayout()
        Me.tpCompany.SuspendLayout()
        CType(Me.dgvCo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCO.SuspendLayout()
        Me.tpDepartment.SuspendLayout()
        CType(Me.dgvDe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDe.SuspendLayout()
        Me.tpDivision.SuspendLayout()
        CType(Me.dgvDi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDi.SuspendLayout()
        Me.tpSection.SuspendLayout()
        CType(Me.dgvSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSe.SuspendLayout()
        Me.tpLaborClassification.SuspendLayout()
        CType(Me.dgvCL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCL.SuspendLayout()
        Me.tpLaborLocation.SuspendLayout()
        CType(Me.dgvLL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tpCostCenter.SuspendLayout()
        CType(Me.dgvLC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCC.SuspendLayout()
        Me.tpEmp.SuspendLayout()
        Me.tcEmp.SuspendLayout()
        Me.tpEmpClass.SuspendLayout()
        CType(Me.dgvEC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmpClass.SuspendLayout()
        Me.tpEmpGroup.SuspendLayout()
        CType(Me.dgvEG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcCompany
        '
        Me.tcCompany.Controls.Add(Me.tpCompany)
        Me.tcCompany.Controls.Add(Me.tpDepartment)
        Me.tcCompany.Controls.Add(Me.tpDivision)
        Me.tcCompany.Controls.Add(Me.tpSection)
        Me.tcCompany.Controls.Add(Me.tpLaborClassification)
        Me.tcCompany.Controls.Add(Me.tpLaborLocation)
        Me.tcCompany.Controls.Add(Me.tpCostCenter)
        Me.tcCompany.Controls.Add(Me.tpEmp)
        Me.tcCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCompany.Location = New System.Drawing.Point(0, 0)
        Me.tcCompany.Name = "tcCompany"
        Me.tcCompany.SelectedIndex = 0
        Me.tcCompany.Size = New System.Drawing.Size(834, 511)
        Me.tcCompany.TabIndex = 0
        '
        'tpCompany
        '
        Me.tpCompany.AutoScroll = True
        Me.tpCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpCompany.Controls.Add(Me.dgvCo)
        Me.tpCompany.Controls.Add(Me.pnlCO)
        Me.tpCompany.Location = New System.Drawing.Point(4, 23)
        Me.tpCompany.Name = "tpCompany"
        Me.tpCompany.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCompany.Size = New System.Drawing.Size(826, 484)
        Me.tpCompany.TabIndex = 0
        Me.tpCompany.Text = "Company Profile"
        Me.tpCompany.UseVisualStyleBackColor = True
        '
        'dgvCo
        '
        Me.dgvCo.AllowUserToAddRows = False
        Me.dgvCo.AllowUserToDeleteRows = False
        Me.dgvCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCompSel, Me.colCompDel})
        Me.dgvCo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCo.Location = New System.Drawing.Point(3, 283)
        Me.dgvCo.Name = "dgvCo"
        Me.dgvCo.ReadOnly = True
        Me.dgvCo.Size = New System.Drawing.Size(818, 196)
        Me.dgvCo.TabIndex = 1
        '
        'colCompSel
        '
        Me.colCompSel.Frozen = True
        Me.colCompSel.HeaderText = ""
        Me.colCompSel.Name = "colCompSel"
        Me.colCompSel.ReadOnly = True
        Me.colCompSel.Text = "Select"
        Me.colCompSel.UseColumnTextForButtonValue = True
        Me.colCompSel.Width = 60
        '
        'colCompDel
        '
        Me.colCompDel.Frozen = True
        Me.colCompDel.HeaderText = ""
        Me.colCompDel.Name = "colCompDel"
        Me.colCompDel.ReadOnly = True
        Me.colCompDel.Text = "Delete"
        Me.colCompDel.UseColumnTextForButtonValue = True
        Me.colCompDel.Width = 60
        '
        'pnlCO
        '
        Me.pnlCO.Controls.Add(Me.txtCOWebsite)
        Me.pnlCO.Controls.Add(Me.lblCOWebsite)
        Me.pnlCO.Controls.Add(Me.txtCOContactNos)
        Me.pnlCO.Controls.Add(Me.lblCOContactNos)
        Me.pnlCO.Controls.Add(Me.txtCOHDMF)
        Me.pnlCO.Controls.Add(Me.txtCOPH)
        Me.pnlCO.Controls.Add(Me.txtCOSSS)
        Me.pnlCO.Controls.Add(Me.txtCOTIN)
        Me.pnlCO.Controls.Add(Me.txtCODTI)
        Me.pnlCO.Controls.Add(Me.txtCOSEC)
        Me.pnlCO.Controls.Add(Me.lblCOHDMF)
        Me.pnlCO.Controls.Add(Me.lblCOPH)
        Me.pnlCO.Controls.Add(Me.lblCOSSS)
        Me.pnlCO.Controls.Add(Me.lblCOTIN)
        Me.pnlCO.Controls.Add(Me.lblCODTI)
        Me.pnlCO.Controls.Add(Me.lblCOSEC)
        Me.pnlCO.Controls.Add(Me.cboCORegion)
        Me.pnlCO.Controls.Add(Me.cboCOProv)
        Me.pnlCO.Controls.Add(Me.cboCOCity)
        Me.pnlCO.Controls.Add(Me.txtCOAddr)
        Me.pnlCO.Controls.Add(Me.txtCOName)
        Me.pnlCO.Controls.Add(Me.txtCOCode)
        Me.pnlCO.Controls.Add(Me.lblCORegion)
        Me.pnlCO.Controls.Add(Me.lblCOProv)
        Me.pnlCO.Controls.Add(Me.lblCOCity)
        Me.pnlCO.Controls.Add(Me.lblCOAddr)
        Me.pnlCO.Controls.Add(Me.lblCOName)
        Me.pnlCO.Controls.Add(Me.lblCOCode)
        Me.pnlCO.Controls.Add(Me.btnCOCancel)
        Me.pnlCO.Controls.Add(Me.btnCOSave)
        Me.pnlCO.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCO.Location = New System.Drawing.Point(3, 3)
        Me.pnlCO.Name = "pnlCO"
        Me.pnlCO.Size = New System.Drawing.Size(818, 280)
        Me.pnlCO.TabIndex = 0
        '
        'txtCOWebsite
        '
        Me.txtCOWebsite.Location = New System.Drawing.Point(125, 211)
        Me.txtCOWebsite.MaxLength = 100
        Me.txtCOWebsite.Name = "txtCOWebsite"
        Me.txtCOWebsite.Size = New System.Drawing.Size(350, 22)
        Me.txtCOWebsite.TabIndex = 7
        '
        'lblCOWebsite
        '
        Me.lblCOWebsite.AutoSize = True
        Me.lblCOWebsite.Location = New System.Drawing.Point(7, 214)
        Me.lblCOWebsite.Name = "lblCOWebsite"
        Me.lblCOWebsite.Size = New System.Drawing.Size(53, 14)
        Me.lblCOWebsite.TabIndex = 28
        Me.lblCOWebsite.Text = "Website"
        '
        'txtCOContactNos
        '
        Me.txtCOContactNos.Location = New System.Drawing.Point(125, 186)
        Me.txtCOContactNos.MaxLength = 100
        Me.txtCOContactNos.Name = "txtCOContactNos"
        Me.txtCOContactNos.Size = New System.Drawing.Size(350, 22)
        Me.txtCOContactNos.TabIndex = 6
        '
        'lblCOContactNos
        '
        Me.lblCOContactNos.AutoSize = True
        Me.lblCOContactNos.Location = New System.Drawing.Point(7, 189)
        Me.lblCOContactNos.Name = "lblCOContactNos"
        Me.lblCOContactNos.Size = New System.Drawing.Size(74, 14)
        Me.lblCOContactNos.TabIndex = 26
        Me.lblCOContactNos.Text = "Contact Nos."
        '
        'txtCOHDMF
        '
        Me.txtCOHDMF.Location = New System.Drawing.Point(665, 137)
        Me.txtCOHDMF.MaxLength = 25
        Me.txtCOHDMF.Name = "txtCOHDMF"
        Me.txtCOHDMF.Size = New System.Drawing.Size(150, 22)
        Me.txtCOHDMF.TabIndex = 13
        '
        'txtCOPH
        '
        Me.txtCOPH.Location = New System.Drawing.Point(665, 112)
        Me.txtCOPH.MaxLength = 25
        Me.txtCOPH.Name = "txtCOPH"
        Me.txtCOPH.Size = New System.Drawing.Size(150, 22)
        Me.txtCOPH.TabIndex = 12
        '
        'txtCOSSS
        '
        Me.txtCOSSS.Location = New System.Drawing.Point(665, 87)
        Me.txtCOSSS.MaxLength = 25
        Me.txtCOSSS.Name = "txtCOSSS"
        Me.txtCOSSS.Size = New System.Drawing.Size(150, 22)
        Me.txtCOSSS.TabIndex = 11
        '
        'txtCOTIN
        '
        Me.txtCOTIN.Location = New System.Drawing.Point(665, 62)
        Me.txtCOTIN.MaxLength = 25
        Me.txtCOTIN.Name = "txtCOTIN"
        Me.txtCOTIN.Size = New System.Drawing.Size(150, 22)
        Me.txtCOTIN.TabIndex = 10
        '
        'txtCODTI
        '
        Me.txtCODTI.Location = New System.Drawing.Point(665, 37)
        Me.txtCODTI.MaxLength = 25
        Me.txtCODTI.Name = "txtCODTI"
        Me.txtCODTI.Size = New System.Drawing.Size(150, 22)
        Me.txtCODTI.TabIndex = 9
        '
        'txtCOSEC
        '
        Me.txtCOSEC.Location = New System.Drawing.Point(665, 12)
        Me.txtCOSEC.MaxLength = 25
        Me.txtCOSEC.Name = "txtCOSEC"
        Me.txtCOSEC.Size = New System.Drawing.Size(150, 22)
        Me.txtCOSEC.TabIndex = 8
        '
        'lblCOHDMF
        '
        Me.lblCOHDMF.AutoSize = True
        Me.lblCOHDMF.Location = New System.Drawing.Point(567, 140)
        Me.lblCOHDMF.Name = "lblCOHDMF"
        Me.lblCOHDMF.Size = New System.Drawing.Size(60, 14)
        Me.lblCOHDMF.TabIndex = 19
        Me.lblCOHDMF.Text = "HDMF No."
        '
        'lblCOPH
        '
        Me.lblCOPH.AutoSize = True
        Me.lblCOPH.Location = New System.Drawing.Point(567, 114)
        Me.lblCOPH.Name = "lblCOPH"
        Me.lblCOPH.Size = New System.Drawing.Size(85, 14)
        Me.lblCOPH.TabIndex = 18
        Me.lblCOPH.Text = "Philhealth No."
        '
        'lblCOSSS
        '
        Me.lblCOSSS.AutoSize = True
        Me.lblCOSSS.Location = New System.Drawing.Point(567, 90)
        Me.lblCOSSS.Name = "lblCOSSS"
        Me.lblCOSSS.Size = New System.Drawing.Size(46, 14)
        Me.lblCOSSS.TabIndex = 17
        Me.lblCOSSS.Text = "SSS No."
        '
        'lblCOTIN
        '
        Me.lblCOTIN.AutoSize = True
        Me.lblCOTIN.Location = New System.Drawing.Point(567, 65)
        Me.lblCOTIN.Name = "lblCOTIN"
        Me.lblCOTIN.Size = New System.Drawing.Size(25, 14)
        Me.lblCOTIN.TabIndex = 16
        Me.lblCOTIN.Text = "TIN"
        '
        'lblCODTI
        '
        Me.lblCODTI.AutoSize = True
        Me.lblCODTI.Location = New System.Drawing.Point(567, 40)
        Me.lblCODTI.Name = "lblCODTI"
        Me.lblCODTI.Size = New System.Drawing.Size(72, 14)
        Me.lblCODTI.TabIndex = 15
        Me.lblCODTI.Text = "DTI Reg. No."
        '
        'lblCOSEC
        '
        Me.lblCOSEC.AutoSize = True
        Me.lblCOSEC.Location = New System.Drawing.Point(567, 15)
        Me.lblCOSEC.Name = "lblCOSEC"
        Me.lblCOSEC.Size = New System.Drawing.Size(72, 14)
        Me.lblCOSEC.TabIndex = 14
        Me.lblCOSEC.Text = "SEC Reg. No."
        '
        'cboCORegion
        '
        Me.cboCORegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCORegion.FormattingEnabled = True
        Me.cboCORegion.Location = New System.Drawing.Point(125, 161)
        Me.cboCORegion.Name = "cboCORegion"
        Me.cboCORegion.Size = New System.Drawing.Size(350, 22)
        Me.cboCORegion.TabIndex = 5
        '
        'cboCOProv
        '
        Me.cboCOProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOProv.FormattingEnabled = True
        Me.cboCOProv.Location = New System.Drawing.Point(125, 136)
        Me.cboCOProv.Name = "cboCOProv"
        Me.cboCOProv.Size = New System.Drawing.Size(350, 22)
        Me.cboCOProv.TabIndex = 4
        '
        'cboCOCity
        '
        Me.cboCOCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOCity.FormattingEnabled = True
        Me.cboCOCity.Location = New System.Drawing.Point(125, 111)
        Me.cboCOCity.Name = "cboCOCity"
        Me.cboCOCity.Size = New System.Drawing.Size(350, 22)
        Me.cboCOCity.TabIndex = 3
        '
        'txtCOAddr
        '
        Me.txtCOAddr.Location = New System.Drawing.Point(125, 62)
        Me.txtCOAddr.Multiline = True
        Me.txtCOAddr.Name = "txtCOAddr"
        Me.txtCOAddr.Size = New System.Drawing.Size(350, 46)
        Me.txtCOAddr.TabIndex = 2
        '
        'txtCOName
        '
        Me.txtCOName.Location = New System.Drawing.Point(125, 37)
        Me.txtCOName.MaxLength = 100
        Me.txtCOName.Name = "txtCOName"
        Me.txtCOName.Size = New System.Drawing.Size(350, 22)
        Me.txtCOName.TabIndex = 1
        '
        'txtCOCode
        '
        Me.txtCOCode.Location = New System.Drawing.Point(125, 12)
        Me.txtCOCode.MaxLength = 25
        Me.txtCOCode.Name = "txtCOCode"
        Me.txtCOCode.Size = New System.Drawing.Size(150, 22)
        Me.txtCOCode.TabIndex = 0
        '
        'lblCORegion
        '
        Me.lblCORegion.AutoSize = True
        Me.lblCORegion.Location = New System.Drawing.Point(7, 164)
        Me.lblCORegion.Name = "lblCORegion"
        Me.lblCORegion.Size = New System.Drawing.Size(45, 14)
        Me.lblCORegion.TabIndex = 7
        Me.lblCORegion.Text = "Region"
        '
        'lblCOProv
        '
        Me.lblCOProv.AutoSize = True
        Me.lblCOProv.Location = New System.Drawing.Point(7, 139)
        Me.lblCOProv.Name = "lblCOProv"
        Me.lblCOProv.Size = New System.Drawing.Size(52, 14)
        Me.lblCOProv.TabIndex = 6
        Me.lblCOProv.Text = "Province"
        '
        'lblCOCity
        '
        Me.lblCOCity.AutoSize = True
        Me.lblCOCity.Location = New System.Drawing.Point(7, 114)
        Me.lblCOCity.Name = "lblCOCity"
        Me.lblCOCity.Size = New System.Drawing.Size(26, 14)
        Me.lblCOCity.TabIndex = 5
        Me.lblCOCity.Text = "City"
        '
        'lblCOAddr
        '
        Me.lblCOAddr.AutoSize = True
        Me.lblCOAddr.Location = New System.Drawing.Point(7, 65)
        Me.lblCOAddr.Name = "lblCOAddr"
        Me.lblCOAddr.Size = New System.Drawing.Size(51, 14)
        Me.lblCOAddr.TabIndex = 4
        Me.lblCOAddr.Text = "Address"
        '
        'lblCOName
        '
        Me.lblCOName.AutoSize = True
        Me.lblCOName.Location = New System.Drawing.Point(7, 40)
        Me.lblCOName.Name = "lblCOName"
        Me.lblCOName.Size = New System.Drawing.Size(91, 14)
        Me.lblCOName.TabIndex = 3
        Me.lblCOName.Text = "Company Name"
        '
        'lblCOCode
        '
        Me.lblCOCode.AutoSize = True
        Me.lblCOCode.Location = New System.Drawing.Point(7, 15)
        Me.lblCOCode.Name = "lblCOCode"
        Me.lblCOCode.Size = New System.Drawing.Size(34, 14)
        Me.lblCOCode.TabIndex = 2
        Me.lblCOCode.Text = "Code"
        '
        'btnCOCancel
        '
        Me.btnCOCancel.Image = CType(resources.GetObject("btnCOCancel.Image"), System.Drawing.Image)
        Me.btnCOCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCOCancel.Location = New System.Drawing.Point(203, 239)
        Me.btnCOCancel.Name = "btnCOCancel"
        Me.btnCOCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCOCancel.TabIndex = 15
        Me.btnCOCancel.Text = "Cancel"
        Me.btnCOCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCOCancel.UseVisualStyleBackColor = True
        '
        'btnCOSave
        '
        Me.btnCOSave.Image = CType(resources.GetObject("btnCOSave.Image"), System.Drawing.Image)
        Me.btnCOSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCOSave.Location = New System.Drawing.Point(125, 239)
        Me.btnCOSave.Name = "btnCOSave"
        Me.btnCOSave.Size = New System.Drawing.Size(75, 28)
        Me.btnCOSave.TabIndex = 14
        Me.btnCOSave.Text = "Save"
        Me.btnCOSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCOSave.UseVisualStyleBackColor = True
        '
        'tpDepartment
        '
        Me.tpDepartment.AutoScroll = True
        Me.tpDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpDepartment.Controls.Add(Me.dgvDe)
        Me.tpDepartment.Controls.Add(Me.pnlDe)
        Me.tpDepartment.Location = New System.Drawing.Point(4, 23)
        Me.tpDepartment.Name = "tpDepartment"
        Me.tpDepartment.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDepartment.Size = New System.Drawing.Size(826, 484)
        Me.tpDepartment.TabIndex = 1
        Me.tpDepartment.Text = "Department/Client"
        Me.tpDepartment.UseVisualStyleBackColor = True
        '
        'dgvDe
        '
        Me.dgvDe.AllowUserToAddRows = False
        Me.dgvDe.AllowUserToDeleteRows = False
        Me.dgvDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDeSel, Me.colDeDel})
        Me.dgvDe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDe.Location = New System.Drawing.Point(3, 158)
        Me.dgvDe.Name = "dgvDe"
        Me.dgvDe.ReadOnly = True
        Me.dgvDe.Size = New System.Drawing.Size(818, 321)
        Me.dgvDe.TabIndex = 3
        '
        'colDeSel
        '
        Me.colDeSel.Frozen = True
        Me.colDeSel.HeaderText = ""
        Me.colDeSel.Name = "colDeSel"
        Me.colDeSel.ReadOnly = True
        Me.colDeSel.Text = "Select"
        Me.colDeSel.UseColumnTextForButtonValue = True
        Me.colDeSel.Width = 60
        '
        'colDeDel
        '
        Me.colDeDel.Frozen = True
        Me.colDeDel.HeaderText = ""
        Me.colDeDel.Name = "colDeDel"
        Me.colDeDel.ReadOnly = True
        Me.colDeDel.Text = "Delete"
        Me.colDeDel.UseColumnTextForButtonValue = True
        Me.colDeDel.Width = 60
        '
        'pnlDe
        '
        Me.pnlDe.Controls.Add(Me.txtDeName)
        Me.pnlDe.Controls.Add(Me.cboDeHead)
        Me.pnlDe.Controls.Add(Me.lblDeHead)
        Me.pnlDe.Controls.Add(Me.lblDeName)
        Me.pnlDe.Controls.Add(Me.lblDeCode)
        Me.pnlDe.Controls.Add(Me.cboDeComp)
        Me.pnlDe.Controls.Add(Me.txtDeCode)
        Me.pnlDe.Controls.Add(Me.lblDeComp)
        Me.pnlDe.Controls.Add(Me.btnDeCancel)
        Me.pnlDe.Controls.Add(Me.btnDeSave)
        Me.pnlDe.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDe.Location = New System.Drawing.Point(3, 3)
        Me.pnlDe.Name = "pnlDe"
        Me.pnlDe.Size = New System.Drawing.Size(818, 155)
        Me.pnlDe.TabIndex = 2
        '
        'txtDeName
        '
        Me.txtDeName.Location = New System.Drawing.Point(125, 62)
        Me.txtDeName.MaxLength = 150
        Me.txtDeName.Name = "txtDeName"
        Me.txtDeName.Size = New System.Drawing.Size(450, 22)
        Me.txtDeName.TabIndex = 18
        '
        'cboDeHead
        '
        Me.cboDeHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeHead.FormattingEnabled = True
        Me.cboDeHead.Location = New System.Drawing.Point(125, 87)
        Me.cboDeHead.Name = "cboDeHead"
        Me.cboDeHead.Size = New System.Drawing.Size(450, 22)
        Me.cboDeHead.TabIndex = 19
        '
        'lblDeHead
        '
        Me.lblDeHead.AutoSize = True
        Me.lblDeHead.Location = New System.Drawing.Point(7, 90)
        Me.lblDeHead.Name = "lblDeHead"
        Me.lblDeHead.Size = New System.Drawing.Size(98, 14)
        Me.lblDeHead.TabIndex = 15
        Me.lblDeHead.Text = "Head/Supervisor"
        '
        'lblDeName
        '
        Me.lblDeName.AutoSize = True
        Me.lblDeName.Location = New System.Drawing.Point(7, 65)
        Me.lblDeName.Name = "lblDeName"
        Me.lblDeName.Size = New System.Drawing.Size(105, 14)
        Me.lblDeName.TabIndex = 14
        Me.lblDeName.Text = "Dept/Client Name"
        '
        'lblDeCode
        '
        Me.lblDeCode.AutoSize = True
        Me.lblDeCode.Location = New System.Drawing.Point(7, 40)
        Me.lblDeCode.Name = "lblDeCode"
        Me.lblDeCode.Size = New System.Drawing.Size(34, 14)
        Me.lblDeCode.TabIndex = 13
        Me.lblDeCode.Text = "Code"
        '
        'cboDeComp
        '
        Me.cboDeComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeComp.FormattingEnabled = True
        Me.cboDeComp.Location = New System.Drawing.Point(125, 12)
        Me.cboDeComp.Name = "cboDeComp"
        Me.cboDeComp.Size = New System.Drawing.Size(450, 22)
        Me.cboDeComp.TabIndex = 16
        '
        'txtDeCode
        '
        Me.txtDeCode.Location = New System.Drawing.Point(125, 37)
        Me.txtDeCode.MaxLength = 25
        Me.txtDeCode.Name = "txtDeCode"
        Me.txtDeCode.Size = New System.Drawing.Size(150, 22)
        Me.txtDeCode.TabIndex = 17
        '
        'lblDeComp
        '
        Me.lblDeComp.AutoSize = True
        Me.lblDeComp.Location = New System.Drawing.Point(7, 15)
        Me.lblDeComp.Name = "lblDeComp"
        Me.lblDeComp.Size = New System.Drawing.Size(56, 14)
        Me.lblDeComp.TabIndex = 9
        Me.lblDeComp.Text = "Company"
        '
        'btnDeCancel
        '
        Me.btnDeCancel.Image = CType(resources.GetObject("btnDeCancel.Image"), System.Drawing.Image)
        Me.btnDeCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeCancel.Location = New System.Drawing.Point(203, 115)
        Me.btnDeCancel.Name = "btnDeCancel"
        Me.btnDeCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnDeCancel.TabIndex = 21
        Me.btnDeCancel.Text = "Cancel"
        Me.btnDeCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeCancel.UseVisualStyleBackColor = True
        '
        'btnDeSave
        '
        Me.btnDeSave.Image = CType(resources.GetObject("btnDeSave.Image"), System.Drawing.Image)
        Me.btnDeSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeSave.Location = New System.Drawing.Point(125, 115)
        Me.btnDeSave.Name = "btnDeSave"
        Me.btnDeSave.Size = New System.Drawing.Size(75, 28)
        Me.btnDeSave.TabIndex = 20
        Me.btnDeSave.Text = "Save"
        Me.btnDeSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeSave.UseVisualStyleBackColor = True
        '
        'tpDivision
        '
        Me.tpDivision.AutoScroll = True
        Me.tpDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpDivision.Controls.Add(Me.dgvDi)
        Me.tpDivision.Controls.Add(Me.pnlDi)
        Me.tpDivision.Location = New System.Drawing.Point(4, 23)
        Me.tpDivision.Name = "tpDivision"
        Me.tpDivision.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDivision.Size = New System.Drawing.Size(826, 484)
        Me.tpDivision.TabIndex = 2
        Me.tpDivision.Text = "Division"
        Me.tpDivision.UseVisualStyleBackColor = True
        '
        'dgvDi
        '
        Me.dgvDi.AllowUserToAddRows = False
        Me.dgvDi.AllowUserToDeleteRows = False
        Me.dgvDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDiSel, Me.colDiDel})
        Me.dgvDi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDi.Location = New System.Drawing.Point(3, 183)
        Me.dgvDi.Name = "dgvDi"
        Me.dgvDi.ReadOnly = True
        Me.dgvDi.Size = New System.Drawing.Size(818, 296)
        Me.dgvDi.TabIndex = 3
        '
        'colDiSel
        '
        Me.colDiSel.Frozen = True
        Me.colDiSel.HeaderText = ""
        Me.colDiSel.Name = "colDiSel"
        Me.colDiSel.ReadOnly = True
        Me.colDiSel.Text = "Select"
        Me.colDiSel.UseColumnTextForButtonValue = True
        Me.colDiSel.Width = 60
        '
        'colDiDel
        '
        Me.colDiDel.Frozen = True
        Me.colDiDel.HeaderText = ""
        Me.colDiDel.Name = "colDiDel"
        Me.colDiDel.ReadOnly = True
        Me.colDiDel.Text = "Delete"
        Me.colDiDel.UseColumnTextForButtonValue = True
        Me.colDiDel.Width = 60
        '
        'pnlDi
        '
        Me.pnlDi.Controls.Add(Me.cboDiDept)
        Me.pnlDi.Controls.Add(Me.lblDiDept)
        Me.pnlDi.Controls.Add(Me.txtDiName)
        Me.pnlDi.Controls.Add(Me.cboDiHead)
        Me.pnlDi.Controls.Add(Me.lblDiHead)
        Me.pnlDi.Controls.Add(Me.lblDiName)
        Me.pnlDi.Controls.Add(Me.lblDiCode)
        Me.pnlDi.Controls.Add(Me.cboDiComp)
        Me.pnlDi.Controls.Add(Me.txtDiCode)
        Me.pnlDi.Controls.Add(Me.lblDiComp)
        Me.pnlDi.Controls.Add(Me.btnDiCancel)
        Me.pnlDi.Controls.Add(Me.btnDiSave)
        Me.pnlDi.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDi.Location = New System.Drawing.Point(3, 3)
        Me.pnlDi.Name = "pnlDi"
        Me.pnlDi.Size = New System.Drawing.Size(818, 180)
        Me.pnlDi.TabIndex = 2
        '
        'cboDiDept
        '
        Me.cboDiDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiDept.FormattingEnabled = True
        Me.cboDiDept.Location = New System.Drawing.Point(125, 37)
        Me.cboDiDept.Name = "cboDiDept"
        Me.cboDiDept.Size = New System.Drawing.Size(450, 22)
        Me.cboDiDept.TabIndex = 23
        '
        'lblDiDept
        '
        Me.lblDiDept.AutoSize = True
        Me.lblDiDept.Location = New System.Drawing.Point(7, 40)
        Me.lblDiDept.Name = "lblDiDept"
        Me.lblDiDept.Size = New System.Drawing.Size(70, 14)
        Me.lblDiDept.TabIndex = 26
        Me.lblDiDept.Text = "Dept/Client"
        '
        'txtDiName
        '
        Me.txtDiName.Location = New System.Drawing.Point(125, 87)
        Me.txtDiName.MaxLength = 150
        Me.txtDiName.Name = "txtDiName"
        Me.txtDiName.Size = New System.Drawing.Size(450, 22)
        Me.txtDiName.TabIndex = 25
        '
        'cboDiHead
        '
        Me.cboDiHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiHead.FormattingEnabled = True
        Me.cboDiHead.Location = New System.Drawing.Point(125, 112)
        Me.cboDiHead.Name = "cboDiHead"
        Me.cboDiHead.Size = New System.Drawing.Size(450, 22)
        Me.cboDiHead.TabIndex = 26
        '
        'lblDiHead
        '
        Me.lblDiHead.AutoSize = True
        Me.lblDiHead.Location = New System.Drawing.Point(7, 115)
        Me.lblDiHead.Name = "lblDiHead"
        Me.lblDiHead.Size = New System.Drawing.Size(98, 14)
        Me.lblDiHead.TabIndex = 23
        Me.lblDiHead.Text = "Head/Supervisor"
        '
        'lblDiName
        '
        Me.lblDiName.AutoSize = True
        Me.lblDiName.Location = New System.Drawing.Point(7, 90)
        Me.lblDiName.Name = "lblDiName"
        Me.lblDiName.Size = New System.Drawing.Size(87, 14)
        Me.lblDiName.TabIndex = 22
        Me.lblDiName.Text = "Division Name"
        '
        'lblDiCode
        '
        Me.lblDiCode.AutoSize = True
        Me.lblDiCode.Location = New System.Drawing.Point(7, 65)
        Me.lblDiCode.Name = "lblDiCode"
        Me.lblDiCode.Size = New System.Drawing.Size(34, 14)
        Me.lblDiCode.TabIndex = 21
        Me.lblDiCode.Text = "Code"
        '
        'cboDiComp
        '
        Me.cboDiComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiComp.FormattingEnabled = True
        Me.cboDiComp.Location = New System.Drawing.Point(125, 12)
        Me.cboDiComp.Name = "cboDiComp"
        Me.cboDiComp.Size = New System.Drawing.Size(450, 22)
        Me.cboDiComp.TabIndex = 22
        '
        'txtDiCode
        '
        Me.txtDiCode.Location = New System.Drawing.Point(125, 62)
        Me.txtDiCode.MaxLength = 25
        Me.txtDiCode.Name = "txtDiCode"
        Me.txtDiCode.Size = New System.Drawing.Size(150, 22)
        Me.txtDiCode.TabIndex = 24
        '
        'lblDiComp
        '
        Me.lblDiComp.AutoSize = True
        Me.lblDiComp.Location = New System.Drawing.Point(7, 15)
        Me.lblDiComp.Name = "lblDiComp"
        Me.lblDiComp.Size = New System.Drawing.Size(56, 14)
        Me.lblDiComp.TabIndex = 18
        Me.lblDiComp.Text = "Company"
        '
        'btnDiCancel
        '
        Me.btnDiCancel.Image = CType(resources.GetObject("btnDiCancel.Image"), System.Drawing.Image)
        Me.btnDiCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiCancel.Location = New System.Drawing.Point(203, 140)
        Me.btnDiCancel.Name = "btnDiCancel"
        Me.btnDiCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnDiCancel.TabIndex = 28
        Me.btnDiCancel.Text = "Cancel"
        Me.btnDiCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiCancel.UseVisualStyleBackColor = True
        '
        'btnDiSave
        '
        Me.btnDiSave.Image = CType(resources.GetObject("btnDiSave.Image"), System.Drawing.Image)
        Me.btnDiSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiSave.Location = New System.Drawing.Point(125, 140)
        Me.btnDiSave.Name = "btnDiSave"
        Me.btnDiSave.Size = New System.Drawing.Size(75, 28)
        Me.btnDiSave.TabIndex = 27
        Me.btnDiSave.Text = "Save"
        Me.btnDiSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiSave.UseVisualStyleBackColor = True
        '
        'tpSection
        '
        Me.tpSection.AutoScroll = True
        Me.tpSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSection.Controls.Add(Me.dgvSe)
        Me.tpSection.Controls.Add(Me.pnlSe)
        Me.tpSection.Location = New System.Drawing.Point(4, 23)
        Me.tpSection.Name = "tpSection"
        Me.tpSection.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSection.Size = New System.Drawing.Size(826, 484)
        Me.tpSection.TabIndex = 3
        Me.tpSection.Text = "Section"
        Me.tpSection.UseVisualStyleBackColor = True
        '
        'dgvSe
        '
        Me.dgvSe.AllowUserToAddRows = False
        Me.dgvSe.AllowUserToDeleteRows = False
        Me.dgvSe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeSel, Me.colSeDel})
        Me.dgvSe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSe.Location = New System.Drawing.Point(3, 208)
        Me.dgvSe.Name = "dgvSe"
        Me.dgvSe.ReadOnly = True
        Me.dgvSe.Size = New System.Drawing.Size(818, 271)
        Me.dgvSe.TabIndex = 3
        '
        'colSeSel
        '
        Me.colSeSel.Frozen = True
        Me.colSeSel.HeaderText = ""
        Me.colSeSel.Name = "colSeSel"
        Me.colSeSel.ReadOnly = True
        Me.colSeSel.Text = "Select"
        Me.colSeSel.UseColumnTextForButtonValue = True
        Me.colSeSel.Width = 60
        '
        'colSeDel
        '
        Me.colSeDel.Frozen = True
        Me.colSeDel.HeaderText = ""
        Me.colSeDel.Name = "colSeDel"
        Me.colSeDel.ReadOnly = True
        Me.colSeDel.Text = "Delete"
        Me.colSeDel.UseColumnTextForButtonValue = True
        Me.colSeDel.Width = 60
        '
        'pnlSe
        '
        Me.pnlSe.Controls.Add(Me.cboSeDivision)
        Me.pnlSe.Controls.Add(Me.lblSeDivision)
        Me.pnlSe.Controls.Add(Me.cboSeDept)
        Me.pnlSe.Controls.Add(Me.lblSeDept)
        Me.pnlSe.Controls.Add(Me.txtSeName)
        Me.pnlSe.Controls.Add(Me.cboSeHead)
        Me.pnlSe.Controls.Add(Me.lblSeHead)
        Me.pnlSe.Controls.Add(Me.lblSeName)
        Me.pnlSe.Controls.Add(Me.lblSeCode)
        Me.pnlSe.Controls.Add(Me.cboSeComp)
        Me.pnlSe.Controls.Add(Me.txtSeCode)
        Me.pnlSe.Controls.Add(Me.lblSeComp)
        Me.pnlSe.Controls.Add(Me.btnSeCancel)
        Me.pnlSe.Controls.Add(Me.btnSeSave)
        Me.pnlSe.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSe.Location = New System.Drawing.Point(3, 3)
        Me.pnlSe.Name = "pnlSe"
        Me.pnlSe.Size = New System.Drawing.Size(818, 205)
        Me.pnlSe.TabIndex = 2
        '
        'cboSeDivision
        '
        Me.cboSeDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeDivision.FormattingEnabled = True
        Me.cboSeDivision.Location = New System.Drawing.Point(125, 62)
        Me.cboSeDivision.Name = "cboSeDivision"
        Me.cboSeDivision.Size = New System.Drawing.Size(450, 22)
        Me.cboSeDivision.TabIndex = 31
        '
        'lblSeDivision
        '
        Me.lblSeDivision.AutoSize = True
        Me.lblSeDivision.Location = New System.Drawing.Point(7, 65)
        Me.lblSeDivision.Name = "lblSeDivision"
        Me.lblSeDivision.Size = New System.Drawing.Size(52, 14)
        Me.lblSeDivision.TabIndex = 38
        Me.lblSeDivision.Text = "Division"
        '
        'cboSeDept
        '
        Me.cboSeDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeDept.FormattingEnabled = True
        Me.cboSeDept.Location = New System.Drawing.Point(125, 37)
        Me.cboSeDept.Name = "cboSeDept"
        Me.cboSeDept.Size = New System.Drawing.Size(450, 22)
        Me.cboSeDept.TabIndex = 30
        '
        'lblSeDept
        '
        Me.lblSeDept.AutoSize = True
        Me.lblSeDept.Location = New System.Drawing.Point(7, 40)
        Me.lblSeDept.Name = "lblSeDept"
        Me.lblSeDept.Size = New System.Drawing.Size(70, 14)
        Me.lblSeDept.TabIndex = 36
        Me.lblSeDept.Text = "Dept/Client"
        '
        'txtSeName
        '
        Me.txtSeName.Location = New System.Drawing.Point(125, 112)
        Me.txtSeName.MaxLength = 150
        Me.txtSeName.Name = "txtSeName"
        Me.txtSeName.Size = New System.Drawing.Size(450, 22)
        Me.txtSeName.TabIndex = 33
        '
        'cboSeHead
        '
        Me.cboSeHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeHead.FormattingEnabled = True
        Me.cboSeHead.Location = New System.Drawing.Point(125, 137)
        Me.cboSeHead.Name = "cboSeHead"
        Me.cboSeHead.Size = New System.Drawing.Size(450, 22)
        Me.cboSeHead.TabIndex = 34
        '
        'lblSeHead
        '
        Me.lblSeHead.AutoSize = True
        Me.lblSeHead.Location = New System.Drawing.Point(7, 140)
        Me.lblSeHead.Name = "lblSeHead"
        Me.lblSeHead.Size = New System.Drawing.Size(98, 14)
        Me.lblSeHead.TabIndex = 33
        Me.lblSeHead.Text = "Head/Supervisor"
        '
        'lblSeName
        '
        Me.lblSeName.AutoSize = True
        Me.lblSeName.Location = New System.Drawing.Point(7, 115)
        Me.lblSeName.Name = "lblSeName"
        Me.lblSeName.Size = New System.Drawing.Size(81, 14)
        Me.lblSeName.TabIndex = 32
        Me.lblSeName.Text = "Section Name"
        '
        'lblSeCode
        '
        Me.lblSeCode.AutoSize = True
        Me.lblSeCode.Location = New System.Drawing.Point(7, 90)
        Me.lblSeCode.Name = "lblSeCode"
        Me.lblSeCode.Size = New System.Drawing.Size(34, 14)
        Me.lblSeCode.TabIndex = 31
        Me.lblSeCode.Text = "Code"
        '
        'cboSeComp
        '
        Me.cboSeComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeComp.FormattingEnabled = True
        Me.cboSeComp.Location = New System.Drawing.Point(125, 12)
        Me.cboSeComp.Name = "cboSeComp"
        Me.cboSeComp.Size = New System.Drawing.Size(450, 22)
        Me.cboSeComp.TabIndex = 29
        '
        'txtSeCode
        '
        Me.txtSeCode.Location = New System.Drawing.Point(125, 87)
        Me.txtSeCode.MaxLength = 25
        Me.txtSeCode.Name = "txtSeCode"
        Me.txtSeCode.Size = New System.Drawing.Size(150, 22)
        Me.txtSeCode.TabIndex = 32
        '
        'lblSeComp
        '
        Me.lblSeComp.AutoSize = True
        Me.lblSeComp.Location = New System.Drawing.Point(7, 15)
        Me.lblSeComp.Name = "lblSeComp"
        Me.lblSeComp.Size = New System.Drawing.Size(56, 14)
        Me.lblSeComp.TabIndex = 28
        Me.lblSeComp.Text = "Company"
        '
        'btnSeCancel
        '
        Me.btnSeCancel.Image = CType(resources.GetObject("btnSeCancel.Image"), System.Drawing.Image)
        Me.btnSeCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeCancel.Location = New System.Drawing.Point(203, 165)
        Me.btnSeCancel.Name = "btnSeCancel"
        Me.btnSeCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnSeCancel.TabIndex = 36
        Me.btnSeCancel.Text = "Cancel"
        Me.btnSeCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSeCancel.UseVisualStyleBackColor = True
        '
        'btnSeSave
        '
        Me.btnSeSave.Image = CType(resources.GetObject("btnSeSave.Image"), System.Drawing.Image)
        Me.btnSeSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeSave.Location = New System.Drawing.Point(125, 165)
        Me.btnSeSave.Name = "btnSeSave"
        Me.btnSeSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSeSave.TabIndex = 35
        Me.btnSeSave.Text = "Save"
        Me.btnSeSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSeSave.UseVisualStyleBackColor = True
        '
        'tpLaborClassification
        '
        Me.tpLaborClassification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpLaborClassification.Controls.Add(Me.dgvCL)
        Me.tpLaborClassification.Controls.Add(Me.pnlCL)
        Me.tpLaborClassification.Location = New System.Drawing.Point(4, 23)
        Me.tpLaborClassification.Name = "tpLaborClassification"
        Me.tpLaborClassification.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLaborClassification.Size = New System.Drawing.Size(826, 484)
        Me.tpLaborClassification.TabIndex = 6
        Me.tpLaborClassification.Text = "Labor Classification"
        Me.tpLaborClassification.UseVisualStyleBackColor = True
        '
        'dgvCL
        '
        Me.dgvCL.AllowUserToAddRows = False
        Me.dgvCL.AllowUserToDeleteRows = False
        Me.dgvCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn3, Me.DataGridViewButtonColumn4})
        Me.dgvCL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCL.Location = New System.Drawing.Point(3, 158)
        Me.dgvCL.Name = "dgvCL"
        Me.dgvCL.ReadOnly = True
        Me.dgvCL.Size = New System.Drawing.Size(818, 321)
        Me.dgvCL.TabIndex = 5
        '
        'DataGridViewButtonColumn3
        '
        Me.DataGridViewButtonColumn3.Frozen = True
        Me.DataGridViewButtonColumn3.HeaderText = ""
        Me.DataGridViewButtonColumn3.Name = "DataGridViewButtonColumn3"
        Me.DataGridViewButtonColumn3.ReadOnly = True
        Me.DataGridViewButtonColumn3.Text = "Select"
        Me.DataGridViewButtonColumn3.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn3.Width = 60
        '
        'DataGridViewButtonColumn4
        '
        Me.DataGridViewButtonColumn4.Frozen = True
        Me.DataGridViewButtonColumn4.HeaderText = ""
        Me.DataGridViewButtonColumn4.Name = "DataGridViewButtonColumn4"
        Me.DataGridViewButtonColumn4.ReadOnly = True
        Me.DataGridViewButtonColumn4.Text = "Delete"
        Me.DataGridViewButtonColumn4.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn4.Width = 60
        '
        'pnlCL
        '
        Me.pnlCL.Controls.Add(Me.cboCLDept)
        Me.pnlCL.Controls.Add(Me.lblCLDept)
        Me.pnlCL.Controls.Add(Me.txtCLDesc)
        Me.pnlCL.Controls.Add(Me.lblCLDesc)
        Me.pnlCL.Controls.Add(Me.lblCLCode)
        Me.pnlCL.Controls.Add(Me.cboCLComp)
        Me.pnlCL.Controls.Add(Me.txtCLCode)
        Me.pnlCL.Controls.Add(Me.lblCLComp)
        Me.pnlCL.Controls.Add(Me.btnCLCancel)
        Me.pnlCL.Controls.Add(Me.btnCLSave)
        Me.pnlCL.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCL.Location = New System.Drawing.Point(3, 3)
        Me.pnlCL.Name = "pnlCL"
        Me.pnlCL.Size = New System.Drawing.Size(818, 155)
        Me.pnlCL.TabIndex = 4
        '
        'cboCLDept
        '
        Me.cboCLDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCLDept.FormattingEnabled = True
        Me.cboCLDept.Location = New System.Drawing.Point(125, 37)
        Me.cboCLDept.Name = "cboCLDept"
        Me.cboCLDept.Size = New System.Drawing.Size(450, 22)
        Me.cboCLDept.TabIndex = 30
        '
        'lblCLDept
        '
        Me.lblCLDept.AutoSize = True
        Me.lblCLDept.Location = New System.Drawing.Point(7, 40)
        Me.lblCLDept.Name = "lblCLDept"
        Me.lblCLDept.Size = New System.Drawing.Size(70, 14)
        Me.lblCLDept.TabIndex = 36
        Me.lblCLDept.Text = "Dept/Client"
        '
        'txtCLDesc
        '
        Me.txtCLDesc.Location = New System.Drawing.Point(125, 87)
        Me.txtCLDesc.MaxLength = 150
        Me.txtCLDesc.Name = "txtCLDesc"
        Me.txtCLDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtCLDesc.TabIndex = 33
        '
        'lblCLDesc
        '
        Me.lblCLDesc.AutoSize = True
        Me.lblCLDesc.Location = New System.Drawing.Point(7, 90)
        Me.lblCLDesc.Name = "lblCLDesc"
        Me.lblCLDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblCLDesc.TabIndex = 32
        Me.lblCLDesc.Text = "Description"
        '
        'lblCLCode
        '
        Me.lblCLCode.AutoSize = True
        Me.lblCLCode.Location = New System.Drawing.Point(7, 65)
        Me.lblCLCode.Name = "lblCLCode"
        Me.lblCLCode.Size = New System.Drawing.Size(34, 14)
        Me.lblCLCode.TabIndex = 31
        Me.lblCLCode.Text = "Code"
        '
        'cboCLComp
        '
        Me.cboCLComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCLComp.FormattingEnabled = True
        Me.cboCLComp.Location = New System.Drawing.Point(125, 12)
        Me.cboCLComp.Name = "cboCLComp"
        Me.cboCLComp.Size = New System.Drawing.Size(450, 22)
        Me.cboCLComp.TabIndex = 29
        '
        'txtCLCode
        '
        Me.txtCLCode.Location = New System.Drawing.Point(125, 62)
        Me.txtCLCode.MaxLength = 25
        Me.txtCLCode.Name = "txtCLCode"
        Me.txtCLCode.Size = New System.Drawing.Size(150, 22)
        Me.txtCLCode.TabIndex = 32
        '
        'lblCLComp
        '
        Me.lblCLComp.AutoSize = True
        Me.lblCLComp.Location = New System.Drawing.Point(7, 15)
        Me.lblCLComp.Name = "lblCLComp"
        Me.lblCLComp.Size = New System.Drawing.Size(56, 14)
        Me.lblCLComp.TabIndex = 28
        Me.lblCLComp.Text = "Company"
        '
        'btnCLCancel
        '
        Me.btnCLCancel.Image = CType(resources.GetObject("btnCLCancel.Image"), System.Drawing.Image)
        Me.btnCLCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCLCancel.Location = New System.Drawing.Point(203, 115)
        Me.btnCLCancel.Name = "btnCLCancel"
        Me.btnCLCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCLCancel.TabIndex = 36
        Me.btnCLCancel.Text = "Cancel"
        Me.btnCLCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCLCancel.UseVisualStyleBackColor = True
        '
        'btnCLSave
        '
        Me.btnCLSave.Image = CType(resources.GetObject("btnCLSave.Image"), System.Drawing.Image)
        Me.btnCLSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCLSave.Location = New System.Drawing.Point(125, 115)
        Me.btnCLSave.Name = "btnCLSave"
        Me.btnCLSave.Size = New System.Drawing.Size(75, 28)
        Me.btnCLSave.TabIndex = 35
        Me.btnCLSave.Text = "Save"
        Me.btnCLSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCLSave.UseVisualStyleBackColor = True
        '
        'tpLaborLocation
        '
        Me.tpLaborLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpLaborLocation.Controls.Add(Me.dgvLL)
        Me.tpLaborLocation.Controls.Add(Me.Panel4)
        Me.tpLaborLocation.Location = New System.Drawing.Point(4, 23)
        Me.tpLaborLocation.Name = "tpLaborLocation"
        Me.tpLaborLocation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLaborLocation.Size = New System.Drawing.Size(826, 484)
        Me.tpLaborLocation.TabIndex = 7
        Me.tpLaborLocation.Text = "Labor Location"
        Me.tpLaborLocation.UseVisualStyleBackColor = True
        '
        'dgvLL
        '
        Me.dgvLL.AllowUserToAddRows = False
        Me.dgvLL.AllowUserToDeleteRows = False
        Me.dgvLL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn5, Me.DataGridViewButtonColumn6})
        Me.dgvLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLL.Location = New System.Drawing.Point(3, 158)
        Me.dgvLL.Name = "dgvLL"
        Me.dgvLL.ReadOnly = True
        Me.dgvLL.Size = New System.Drawing.Size(818, 321)
        Me.dgvLL.TabIndex = 7
        '
        'DataGridViewButtonColumn5
        '
        Me.DataGridViewButtonColumn5.Frozen = True
        Me.DataGridViewButtonColumn5.HeaderText = ""
        Me.DataGridViewButtonColumn5.Name = "DataGridViewButtonColumn5"
        Me.DataGridViewButtonColumn5.ReadOnly = True
        Me.DataGridViewButtonColumn5.Text = "Select"
        Me.DataGridViewButtonColumn5.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn5.Width = 60
        '
        'DataGridViewButtonColumn6
        '
        Me.DataGridViewButtonColumn6.Frozen = True
        Me.DataGridViewButtonColumn6.HeaderText = ""
        Me.DataGridViewButtonColumn6.Name = "DataGridViewButtonColumn6"
        Me.DataGridViewButtonColumn6.ReadOnly = True
        Me.DataGridViewButtonColumn6.Text = "Delete"
        Me.DataGridViewButtonColumn6.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn6.Width = 60
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cboLLDept)
        Me.Panel4.Controls.Add(Me.lblLLDept)
        Me.Panel4.Controls.Add(Me.txtLLDesc)
        Me.Panel4.Controls.Add(Me.lblLLDesc)
        Me.Panel4.Controls.Add(Me.lblLLCode)
        Me.Panel4.Controls.Add(Me.cboLLComp)
        Me.Panel4.Controls.Add(Me.txtLLCode)
        Me.Panel4.Controls.Add(Me.lblLLComp)
        Me.Panel4.Controls.Add(Me.btnLLCancel)
        Me.Panel4.Controls.Add(Me.btnLLSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(818, 155)
        Me.Panel4.TabIndex = 6
        '
        'cboLLDept
        '
        Me.cboLLDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLLDept.FormattingEnabled = True
        Me.cboLLDept.Location = New System.Drawing.Point(125, 37)
        Me.cboLLDept.Name = "cboLLDept"
        Me.cboLLDept.Size = New System.Drawing.Size(450, 22)
        Me.cboLLDept.TabIndex = 30
        '
        'lblLLDept
        '
        Me.lblLLDept.AutoSize = True
        Me.lblLLDept.Location = New System.Drawing.Point(7, 40)
        Me.lblLLDept.Name = "lblLLDept"
        Me.lblLLDept.Size = New System.Drawing.Size(70, 14)
        Me.lblLLDept.TabIndex = 36
        Me.lblLLDept.Text = "Dept/Client"
        '
        'txtLLDesc
        '
        Me.txtLLDesc.Location = New System.Drawing.Point(125, 87)
        Me.txtLLDesc.MaxLength = 150
        Me.txtLLDesc.Name = "txtLLDesc"
        Me.txtLLDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtLLDesc.TabIndex = 33
        '
        'lblLLDesc
        '
        Me.lblLLDesc.AutoSize = True
        Me.lblLLDesc.Location = New System.Drawing.Point(7, 90)
        Me.lblLLDesc.Name = "lblLLDesc"
        Me.lblLLDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblLLDesc.TabIndex = 32
        Me.lblLLDesc.Text = "Description"
        '
        'lblLLCode
        '
        Me.lblLLCode.AutoSize = True
        Me.lblLLCode.Location = New System.Drawing.Point(7, 65)
        Me.lblLLCode.Name = "lblLLCode"
        Me.lblLLCode.Size = New System.Drawing.Size(34, 14)
        Me.lblLLCode.TabIndex = 31
        Me.lblLLCode.Text = "Code"
        '
        'cboLLComp
        '
        Me.cboLLComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLLComp.FormattingEnabled = True
        Me.cboLLComp.Location = New System.Drawing.Point(125, 12)
        Me.cboLLComp.Name = "cboLLComp"
        Me.cboLLComp.Size = New System.Drawing.Size(450, 22)
        Me.cboLLComp.TabIndex = 29
        '
        'txtLLCode
        '
        Me.txtLLCode.Location = New System.Drawing.Point(125, 62)
        Me.txtLLCode.MaxLength = 25
        Me.txtLLCode.Name = "txtLLCode"
        Me.txtLLCode.Size = New System.Drawing.Size(150, 22)
        Me.txtLLCode.TabIndex = 32
        '
        'lblLLComp
        '
        Me.lblLLComp.AutoSize = True
        Me.lblLLComp.Location = New System.Drawing.Point(7, 15)
        Me.lblLLComp.Name = "lblLLComp"
        Me.lblLLComp.Size = New System.Drawing.Size(56, 14)
        Me.lblLLComp.TabIndex = 28
        Me.lblLLComp.Text = "Company"
        '
        'btnLLCancel
        '
        Me.btnLLCancel.Image = CType(resources.GetObject("btnLLCancel.Image"), System.Drawing.Image)
        Me.btnLLCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLLCancel.Location = New System.Drawing.Point(203, 115)
        Me.btnLLCancel.Name = "btnLLCancel"
        Me.btnLLCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnLLCancel.TabIndex = 36
        Me.btnLLCancel.Text = "Cancel"
        Me.btnLLCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLLCancel.UseVisualStyleBackColor = True
        '
        'btnLLSave
        '
        Me.btnLLSave.Image = CType(resources.GetObject("btnLLSave.Image"), System.Drawing.Image)
        Me.btnLLSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLLSave.Location = New System.Drawing.Point(125, 115)
        Me.btnLLSave.Name = "btnLLSave"
        Me.btnLLSave.Size = New System.Drawing.Size(75, 28)
        Me.btnLLSave.TabIndex = 35
        Me.btnLLSave.Text = "Save"
        Me.btnLLSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLLSave.UseVisualStyleBackColor = True
        '
        'tpCostCenter
        '
        Me.tpCostCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpCostCenter.Controls.Add(Me.dgvLC)
        Me.tpCostCenter.Controls.Add(Me.pnlCC)
        Me.tpCostCenter.Location = New System.Drawing.Point(4, 23)
        Me.tpCostCenter.Name = "tpCostCenter"
        Me.tpCostCenter.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCostCenter.Size = New System.Drawing.Size(826, 484)
        Me.tpCostCenter.TabIndex = 5
        Me.tpCostCenter.Text = "Cost Center"
        Me.tpCostCenter.UseVisualStyleBackColor = True
        '
        'dgvLC
        '
        Me.dgvLC.AllowUserToAddRows = False
        Me.dgvLC.AllowUserToDeleteRows = False
        Me.dgvLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn1, Me.DataGridViewButtonColumn2})
        Me.dgvLC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLC.Location = New System.Drawing.Point(3, 157)
        Me.dgvLC.Name = "dgvLC"
        Me.dgvLC.ReadOnly = True
        Me.dgvLC.Size = New System.Drawing.Size(818, 322)
        Me.dgvLC.TabIndex = 5
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.Frozen = True
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Select"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 60
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.Frozen = True
        Me.DataGridViewButtonColumn2.HeaderText = ""
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.ReadOnly = True
        Me.DataGridViewButtonColumn2.Text = "Delete"
        Me.DataGridViewButtonColumn2.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn2.Width = 60
        '
        'pnlCC
        '
        Me.pnlCC.Controls.Add(Me.cboLCDept)
        Me.pnlCC.Controls.Add(Me.lblLCDept)
        Me.pnlCC.Controls.Add(Me.txtLCDesc)
        Me.pnlCC.Controls.Add(Me.lblLCDesc)
        Me.pnlCC.Controls.Add(Me.lblLCCode)
        Me.pnlCC.Controls.Add(Me.cboLCComp)
        Me.pnlCC.Controls.Add(Me.txtLCCode)
        Me.pnlCC.Controls.Add(Me.lblLCComp)
        Me.pnlCC.Controls.Add(Me.btnLCCancel)
        Me.pnlCC.Controls.Add(Me.btnLCSave)
        Me.pnlCC.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCC.Location = New System.Drawing.Point(3, 3)
        Me.pnlCC.Name = "pnlCC"
        Me.pnlCC.Size = New System.Drawing.Size(818, 154)
        Me.pnlCC.TabIndex = 4
        '
        'cboLCDept
        '
        Me.cboLCDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLCDept.FormattingEnabled = True
        Me.cboLCDept.Location = New System.Drawing.Point(125, 37)
        Me.cboLCDept.Name = "cboLCDept"
        Me.cboLCDept.Size = New System.Drawing.Size(450, 22)
        Me.cboLCDept.TabIndex = 38
        '
        'lblLCDept
        '
        Me.lblLCDept.AutoSize = True
        Me.lblLCDept.Location = New System.Drawing.Point(7, 40)
        Me.lblLCDept.Name = "lblLCDept"
        Me.lblLCDept.Size = New System.Drawing.Size(70, 14)
        Me.lblLCDept.TabIndex = 36
        Me.lblLCDept.Text = "Dept/Client"
        '
        'txtLCDesc
        '
        Me.txtLCDesc.Location = New System.Drawing.Point(125, 86)
        Me.txtLCDesc.MaxLength = 150
        Me.txtLCDesc.Name = "txtLCDesc"
        Me.txtLCDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtLCDesc.TabIndex = 40
        '
        'lblLCDesc
        '
        Me.lblLCDesc.AutoSize = True
        Me.lblLCDesc.Location = New System.Drawing.Point(7, 89)
        Me.lblLCDesc.Name = "lblLCDesc"
        Me.lblLCDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblLCDesc.TabIndex = 32
        Me.lblLCDesc.Text = "Description"
        '
        'lblLCCode
        '
        Me.lblLCCode.AutoSize = True
        Me.lblLCCode.Location = New System.Drawing.Point(7, 65)
        Me.lblLCCode.Name = "lblLCCode"
        Me.lblLCCode.Size = New System.Drawing.Size(34, 14)
        Me.lblLCCode.TabIndex = 31
        Me.lblLCCode.Text = "Code"
        '
        'cboLCComp
        '
        Me.cboLCComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLCComp.FormattingEnabled = True
        Me.cboLCComp.Location = New System.Drawing.Point(125, 12)
        Me.cboLCComp.Name = "cboLCComp"
        Me.cboLCComp.Size = New System.Drawing.Size(450, 22)
        Me.cboLCComp.TabIndex = 37
        '
        'txtLCCode
        '
        Me.txtLCCode.Location = New System.Drawing.Point(125, 62)
        Me.txtLCCode.MaxLength = 25
        Me.txtLCCode.Name = "txtLCCode"
        Me.txtLCCode.Size = New System.Drawing.Size(150, 22)
        Me.txtLCCode.TabIndex = 39
        '
        'lblLCComp
        '
        Me.lblLCComp.AutoSize = True
        Me.lblLCComp.Location = New System.Drawing.Point(7, 15)
        Me.lblLCComp.Name = "lblLCComp"
        Me.lblLCComp.Size = New System.Drawing.Size(56, 14)
        Me.lblLCComp.TabIndex = 28
        Me.lblLCComp.Text = "Company"
        '
        'btnLCCancel
        '
        Me.btnLCCancel.Image = CType(resources.GetObject("btnLCCancel.Image"), System.Drawing.Image)
        Me.btnLCCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLCCancel.Location = New System.Drawing.Point(203, 114)
        Me.btnLCCancel.Name = "btnLCCancel"
        Me.btnLCCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnLCCancel.TabIndex = 42
        Me.btnLCCancel.Text = "Cancel"
        Me.btnLCCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLCCancel.UseVisualStyleBackColor = True
        '
        'btnLCSave
        '
        Me.btnLCSave.Image = CType(resources.GetObject("btnLCSave.Image"), System.Drawing.Image)
        Me.btnLCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLCSave.Location = New System.Drawing.Point(125, 114)
        Me.btnLCSave.Name = "btnLCSave"
        Me.btnLCSave.Size = New System.Drawing.Size(75, 28)
        Me.btnLCSave.TabIndex = 41
        Me.btnLCSave.Text = "Save"
        Me.btnLCSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLCSave.UseVisualStyleBackColor = True
        '
        'tpEmp
        '
        Me.tpEmp.AutoScroll = True
        Me.tpEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpEmp.Controls.Add(Me.tcEmp)
        Me.tpEmp.Location = New System.Drawing.Point(4, 23)
        Me.tpEmp.Name = "tpEmp"
        Me.tpEmp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmp.Size = New System.Drawing.Size(826, 484)
        Me.tpEmp.TabIndex = 4
        Me.tpEmp.Text = "Employee"
        Me.tpEmp.UseVisualStyleBackColor = True
        '
        'tcEmp
        '
        Me.tcEmp.Controls.Add(Me.tpEmpClass)
        Me.tcEmp.Controls.Add(Me.tpEmpGroup)
        Me.tcEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcEmp.Location = New System.Drawing.Point(3, 3)
        Me.tcEmp.Name = "tcEmp"
        Me.tcEmp.SelectedIndex = 0
        Me.tcEmp.Size = New System.Drawing.Size(818, 476)
        Me.tcEmp.TabIndex = 0
        '
        'tpEmpClass
        '
        Me.tpEmpClass.AutoScroll = True
        Me.tpEmpClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpEmpClass.Controls.Add(Me.dgvEC)
        Me.tpEmpClass.Controls.Add(Me.pnlEmpClass)
        Me.tpEmpClass.Location = New System.Drawing.Point(4, 23)
        Me.tpEmpClass.Name = "tpEmpClass"
        Me.tpEmpClass.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmpClass.Size = New System.Drawing.Size(810, 449)
        Me.tpEmpClass.TabIndex = 0
        Me.tpEmpClass.Text = "Class"
        Me.tpEmpClass.UseVisualStyleBackColor = True
        '
        'dgvEC
        '
        Me.dgvEC.AllowUserToAddRows = False
        Me.dgvEC.AllowUserToDeleteRows = False
        Me.dgvEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colECSel, Me.colECDel})
        Me.dgvEC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEC.Location = New System.Drawing.Point(3, 128)
        Me.dgvEC.Name = "dgvEC"
        Me.dgvEC.ReadOnly = True
        Me.dgvEC.Size = New System.Drawing.Size(802, 316)
        Me.dgvEC.TabIndex = 4
        '
        'colECSel
        '
        Me.colECSel.Frozen = True
        Me.colECSel.HeaderText = ""
        Me.colECSel.Name = "colECSel"
        Me.colECSel.ReadOnly = True
        Me.colECSel.Text = "Select"
        Me.colECSel.UseColumnTextForButtonValue = True
        Me.colECSel.Width = 60
        '
        'colECDel
        '
        Me.colECDel.Frozen = True
        Me.colECDel.HeaderText = ""
        Me.colECDel.Name = "colECDel"
        Me.colECDel.ReadOnly = True
        Me.colECDel.Text = "Delete"
        Me.colECDel.UseColumnTextForButtonValue = True
        Me.colECDel.Width = 60
        '
        'pnlEmpClass
        '
        Me.pnlEmpClass.Controls.Add(Me.lblECDesc)
        Me.pnlEmpClass.Controls.Add(Me.lblECCode)
        Me.pnlEmpClass.Controls.Add(Me.btnECCancel)
        Me.pnlEmpClass.Controls.Add(Me.btnECSave)
        Me.pnlEmpClass.Controls.Add(Me.txtECDesc)
        Me.pnlEmpClass.Controls.Add(Me.txtECCode)
        Me.pnlEmpClass.Controls.Add(Me.cboECComp)
        Me.pnlEmpClass.Controls.Add(Me.lblECComp)
        Me.pnlEmpClass.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEmpClass.Location = New System.Drawing.Point(3, 3)
        Me.pnlEmpClass.Name = "pnlEmpClass"
        Me.pnlEmpClass.Size = New System.Drawing.Size(802, 125)
        Me.pnlEmpClass.TabIndex = 0
        '
        'lblECDesc
        '
        Me.lblECDesc.AutoSize = True
        Me.lblECDesc.Location = New System.Drawing.Point(7, 65)
        Me.lblECDesc.Name = "lblECDesc"
        Me.lblECDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblECDesc.TabIndex = 38
        Me.lblECDesc.Text = "Description"
        '
        'lblECCode
        '
        Me.lblECCode.AutoSize = True
        Me.lblECCode.Location = New System.Drawing.Point(7, 40)
        Me.lblECCode.Name = "lblECCode"
        Me.lblECCode.Size = New System.Drawing.Size(34, 14)
        Me.lblECCode.TabIndex = 37
        Me.lblECCode.Text = "Code"
        '
        'btnECCancel
        '
        Me.btnECCancel.Image = CType(resources.GetObject("btnECCancel.Image"), System.Drawing.Image)
        Me.btnECCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnECCancel.Location = New System.Drawing.Point(203, 90)
        Me.btnECCancel.Name = "btnECCancel"
        Me.btnECCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnECCancel.TabIndex = 47
        Me.btnECCancel.Text = "Cancel"
        Me.btnECCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnECCancel.UseVisualStyleBackColor = True
        '
        'btnECSave
        '
        Me.btnECSave.Image = CType(resources.GetObject("btnECSave.Image"), System.Drawing.Image)
        Me.btnECSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnECSave.Location = New System.Drawing.Point(125, 90)
        Me.btnECSave.Name = "btnECSave"
        Me.btnECSave.Size = New System.Drawing.Size(75, 28)
        Me.btnECSave.TabIndex = 46
        Me.btnECSave.Text = "Save"
        Me.btnECSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnECSave.UseVisualStyleBackColor = True
        '
        'txtECDesc
        '
        Me.txtECDesc.Location = New System.Drawing.Point(125, 62)
        Me.txtECDesc.MaxLength = 150
        Me.txtECDesc.Name = "txtECDesc"
        Me.txtECDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtECDesc.TabIndex = 45
        '
        'txtECCode
        '
        Me.txtECCode.Location = New System.Drawing.Point(125, 37)
        Me.txtECCode.MaxLength = 25
        Me.txtECCode.Name = "txtECCode"
        Me.txtECCode.Size = New System.Drawing.Size(150, 22)
        Me.txtECCode.TabIndex = 44
        '
        'cboECComp
        '
        Me.cboECComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboECComp.FormattingEnabled = True
        Me.cboECComp.Location = New System.Drawing.Point(125, 12)
        Me.cboECComp.Name = "cboECComp"
        Me.cboECComp.Size = New System.Drawing.Size(450, 22)
        Me.cboECComp.TabIndex = 43
        '
        'lblECComp
        '
        Me.lblECComp.AutoSize = True
        Me.lblECComp.Location = New System.Drawing.Point(7, 15)
        Me.lblECComp.Name = "lblECComp"
        Me.lblECComp.Size = New System.Drawing.Size(56, 14)
        Me.lblECComp.TabIndex = 31
        Me.lblECComp.Text = "Company"
        '
        'tpEmpGroup
        '
        Me.tpEmpGroup.AutoScroll = True
        Me.tpEmpGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpEmpGroup.Controls.Add(Me.dgvEG)
        Me.tpEmpGroup.Controls.Add(Me.Panel2)
        Me.tpEmpGroup.Location = New System.Drawing.Point(4, 23)
        Me.tpEmpGroup.Name = "tpEmpGroup"
        Me.tpEmpGroup.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmpGroup.Size = New System.Drawing.Size(810, 449)
        Me.tpEmpGroup.TabIndex = 1
        Me.tpEmpGroup.Text = "Group"
        Me.tpEmpGroup.UseVisualStyleBackColor = True
        '
        'dgvEG
        '
        Me.dgvEG.AllowUserToAddRows = False
        Me.dgvEG.AllowUserToDeleteRows = False
        Me.dgvEG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEGSel, Me.colEGDel})
        Me.dgvEG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEG.Location = New System.Drawing.Point(3, 157)
        Me.dgvEG.Name = "dgvEG"
        Me.dgvEG.ReadOnly = True
        Me.dgvEG.Size = New System.Drawing.Size(802, 287)
        Me.dgvEG.TabIndex = 6
        '
        'colEGSel
        '
        Me.colEGSel.Frozen = True
        Me.colEGSel.HeaderText = ""
        Me.colEGSel.Name = "colEGSel"
        Me.colEGSel.ReadOnly = True
        Me.colEGSel.Text = "Select"
        Me.colEGSel.UseColumnTextForButtonValue = True
        Me.colEGSel.Width = 60
        '
        'colEGDel
        '
        Me.colEGDel.Frozen = True
        Me.colEGDel.HeaderText = ""
        Me.colEGDel.Name = "colEGDel"
        Me.colEGDel.ReadOnly = True
        Me.colEGDel.Text = "Delete"
        Me.colEGDel.UseColumnTextForButtonValue = True
        Me.colEGDel.Width = 60
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblEGDesc)
        Me.Panel2.Controls.Add(Me.lblEGCode)
        Me.Panel2.Controls.Add(Me.lblEGEC)
        Me.Panel2.Controls.Add(Me.cboEGEC)
        Me.Panel2.Controls.Add(Me.btnEGCancel)
        Me.Panel2.Controls.Add(Me.btnEGSave)
        Me.Panel2.Controls.Add(Me.txtEGDesc)
        Me.Panel2.Controls.Add(Me.txtEGCode)
        Me.Panel2.Controls.Add(Me.cboEGComp)
        Me.Panel2.Controls.Add(Me.lblEGComp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 154)
        Me.Panel2.TabIndex = 5
        '
        'lblEGDesc
        '
        Me.lblEGDesc.AutoSize = True
        Me.lblEGDesc.Location = New System.Drawing.Point(7, 90)
        Me.lblEGDesc.Name = "lblEGDesc"
        Me.lblEGDesc.Size = New System.Drawing.Size(69, 14)
        Me.lblEGDesc.TabIndex = 40
        Me.lblEGDesc.Text = "Description"
        '
        'lblEGCode
        '
        Me.lblEGCode.AutoSize = True
        Me.lblEGCode.Location = New System.Drawing.Point(7, 65)
        Me.lblEGCode.Name = "lblEGCode"
        Me.lblEGCode.Size = New System.Drawing.Size(34, 14)
        Me.lblEGCode.TabIndex = 39
        Me.lblEGCode.Text = "Code"
        '
        'lblEGEC
        '
        Me.lblEGEC.AutoSize = True
        Me.lblEGEC.Location = New System.Drawing.Point(7, 40)
        Me.lblEGEC.Name = "lblEGEC"
        Me.lblEGEC.Size = New System.Drawing.Size(92, 14)
        Me.lblEGEC.TabIndex = 38
        Me.lblEGEC.Text = "Employee Class"
        '
        'cboEGEC
        '
        Me.cboEGEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEGEC.FormattingEnabled = True
        Me.cboEGEC.Location = New System.Drawing.Point(125, 37)
        Me.cboEGEC.Name = "cboEGEC"
        Me.cboEGEC.Size = New System.Drawing.Size(450, 22)
        Me.cboEGEC.TabIndex = 49
        '
        'btnEGCancel
        '
        Me.btnEGCancel.Image = CType(resources.GetObject("btnEGCancel.Image"), System.Drawing.Image)
        Me.btnEGCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEGCancel.Location = New System.Drawing.Point(203, 115)
        Me.btnEGCancel.Name = "btnEGCancel"
        Me.btnEGCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnEGCancel.TabIndex = 53
        Me.btnEGCancel.Text = "Cancel"
        Me.btnEGCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEGCancel.UseVisualStyleBackColor = True
        '
        'btnEGSave
        '
        Me.btnEGSave.Image = CType(resources.GetObject("btnEGSave.Image"), System.Drawing.Image)
        Me.btnEGSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEGSave.Location = New System.Drawing.Point(125, 115)
        Me.btnEGSave.Name = "btnEGSave"
        Me.btnEGSave.Size = New System.Drawing.Size(75, 28)
        Me.btnEGSave.TabIndex = 52
        Me.btnEGSave.Text = "Save"
        Me.btnEGSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEGSave.UseVisualStyleBackColor = True
        '
        'txtEGDesc
        '
        Me.txtEGDesc.Location = New System.Drawing.Point(125, 87)
        Me.txtEGDesc.MaxLength = 150
        Me.txtEGDesc.Name = "txtEGDesc"
        Me.txtEGDesc.Size = New System.Drawing.Size(450, 22)
        Me.txtEGDesc.TabIndex = 51
        '
        'txtEGCode
        '
        Me.txtEGCode.Location = New System.Drawing.Point(125, 62)
        Me.txtEGCode.MaxLength = 25
        Me.txtEGCode.Name = "txtEGCode"
        Me.txtEGCode.Size = New System.Drawing.Size(150, 22)
        Me.txtEGCode.TabIndex = 50
        '
        'cboEGComp
        '
        Me.cboEGComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEGComp.FormattingEnabled = True
        Me.cboEGComp.Location = New System.Drawing.Point(125, 12)
        Me.cboEGComp.Name = "cboEGComp"
        Me.cboEGComp.Size = New System.Drawing.Size(450, 22)
        Me.cboEGComp.TabIndex = 48
        '
        'lblEGComp
        '
        Me.lblEGComp.AutoSize = True
        Me.lblEGComp.Location = New System.Drawing.Point(7, 15)
        Me.lblEGComp.Name = "lblEGComp"
        Me.lblEGComp.Size = New System.Drawing.Size(56, 14)
        Me.lblEGComp.TabIndex = 31
        Me.lblEGComp.Text = "Company"
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.tcCompany)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Setup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcCompany.ResumeLayout(False)
        Me.tpCompany.ResumeLayout(False)
        CType(Me.dgvCo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCO.ResumeLayout(False)
        Me.pnlCO.PerformLayout()
        Me.tpDepartment.ResumeLayout(False)
        CType(Me.dgvDe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDe.ResumeLayout(False)
        Me.pnlDe.PerformLayout()
        Me.tpDivision.ResumeLayout(False)
        CType(Me.dgvDi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDi.ResumeLayout(False)
        Me.pnlDi.PerformLayout()
        Me.tpSection.ResumeLayout(False)
        CType(Me.dgvSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSe.ResumeLayout(False)
        Me.pnlSe.PerformLayout()
        Me.tpLaborClassification.ResumeLayout(False)
        CType(Me.dgvCL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCL.ResumeLayout(False)
        Me.pnlCL.PerformLayout()
        Me.tpLaborLocation.ResumeLayout(False)
        CType(Me.dgvLL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tpCostCenter.ResumeLayout(False)
        CType(Me.dgvLC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCC.ResumeLayout(False)
        Me.pnlCC.PerformLayout()
        Me.tpEmp.ResumeLayout(False)
        Me.tcEmp.ResumeLayout(False)
        Me.tpEmpClass.ResumeLayout(False)
        CType(Me.dgvEC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmpClass.ResumeLayout(False)
        Me.pnlEmpClass.PerformLayout()
        Me.tpEmpGroup.ResumeLayout(False)
        CType(Me.dgvEG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcCompany As System.Windows.Forms.TabControl
    Friend WithEvents tpCompany As System.Windows.Forms.TabPage
    Friend WithEvents pnlCO As System.Windows.Forms.Panel
    Friend WithEvents btnCOCancel As System.Windows.Forms.Button
    Friend WithEvents btnCOSave As System.Windows.Forms.Button
    Friend WithEvents tpDepartment As System.Windows.Forms.TabPage
    Friend WithEvents tpDivision As System.Windows.Forms.TabPage
    Friend WithEvents tpSection As System.Windows.Forms.TabPage
    Friend WithEvents dgvCo As System.Windows.Forms.DataGridView
    Friend WithEvents colCompSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colCompDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtCOWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lblCOWebsite As System.Windows.Forms.Label
    Friend WithEvents txtCOContactNos As System.Windows.Forms.TextBox
    Friend WithEvents lblCOContactNos As System.Windows.Forms.Label
    Friend WithEvents txtCOHDMF As System.Windows.Forms.TextBox
    Friend WithEvents txtCOPH As System.Windows.Forms.TextBox
    Friend WithEvents txtCOSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtCOTIN As System.Windows.Forms.TextBox
    Friend WithEvents txtCODTI As System.Windows.Forms.TextBox
    Friend WithEvents txtCOSEC As System.Windows.Forms.TextBox
    Friend WithEvents lblCOHDMF As System.Windows.Forms.Label
    Friend WithEvents lblCOPH As System.Windows.Forms.Label
    Friend WithEvents lblCOSSS As System.Windows.Forms.Label
    Friend WithEvents lblCOTIN As System.Windows.Forms.Label
    Friend WithEvents lblCODTI As System.Windows.Forms.Label
    Friend WithEvents lblCOSEC As System.Windows.Forms.Label
    Friend WithEvents cboCORegion As System.Windows.Forms.ComboBox
    Friend WithEvents cboCOProv As System.Windows.Forms.ComboBox
    Friend WithEvents cboCOCity As System.Windows.Forms.ComboBox
    Friend WithEvents txtCOAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtCOName As System.Windows.Forms.TextBox
    Friend WithEvents txtCOCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCORegion As System.Windows.Forms.Label
    Friend WithEvents lblCOProv As System.Windows.Forms.Label
    Friend WithEvents lblCOCity As System.Windows.Forms.Label
    Friend WithEvents lblCOAddr As System.Windows.Forms.Label
    Friend WithEvents lblCOName As System.Windows.Forms.Label
    Friend WithEvents lblCOCode As System.Windows.Forms.Label
    Friend WithEvents dgvDe As System.Windows.Forms.DataGridView
    Friend WithEvents pnlDe As System.Windows.Forms.Panel
    Friend WithEvents btnDeCancel As System.Windows.Forms.Button
    Friend WithEvents btnDeSave As System.Windows.Forms.Button
    Friend WithEvents dgvDi As System.Windows.Forms.DataGridView
    Friend WithEvents pnlDi As System.Windows.Forms.Panel
    Friend WithEvents btnDiCancel As System.Windows.Forms.Button
    Friend WithEvents btnDiSave As System.Windows.Forms.Button
    Friend WithEvents dgvSe As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSe As System.Windows.Forms.Panel
    Friend WithEvents btnSeCancel As System.Windows.Forms.Button
    Friend WithEvents btnSeSave As System.Windows.Forms.Button
    Friend WithEvents txtDeName As System.Windows.Forms.TextBox
    Friend WithEvents cboDeHead As System.Windows.Forms.ComboBox
    Friend WithEvents lblDeHead As System.Windows.Forms.Label
    Friend WithEvents lblDeName As System.Windows.Forms.Label
    Friend WithEvents lblDeCode As System.Windows.Forms.Label
    Friend WithEvents cboDeComp As System.Windows.Forms.ComboBox
    Friend WithEvents txtDeCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDeComp As System.Windows.Forms.Label
    Friend WithEvents cboDiDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiDept As System.Windows.Forms.Label
    Friend WithEvents txtDiName As System.Windows.Forms.TextBox
    Friend WithEvents cboDiHead As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiHead As System.Windows.Forms.Label
    Friend WithEvents lblDiName As System.Windows.Forms.Label
    Friend WithEvents lblDiCode As System.Windows.Forms.Label
    Friend WithEvents cboDiComp As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDiComp As System.Windows.Forms.Label
    Friend WithEvents cboSeDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeDivision As System.Windows.Forms.Label
    Friend WithEvents cboSeDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeDept As System.Windows.Forms.Label
    Friend WithEvents txtSeName As System.Windows.Forms.TextBox
    Friend WithEvents cboSeHead As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeHead As System.Windows.Forms.Label
    Friend WithEvents lblSeName As System.Windows.Forms.Label
    Friend WithEvents lblSeCode As System.Windows.Forms.Label
    Friend WithEvents cboSeComp As System.Windows.Forms.ComboBox
    Friend WithEvents txtSeCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSeComp As System.Windows.Forms.Label
    Friend WithEvents tpEmp As System.Windows.Forms.TabPage
    Friend WithEvents tcEmp As System.Windows.Forms.TabControl
    Friend WithEvents tpEmpClass As System.Windows.Forms.TabPage
    Friend WithEvents tpEmpGroup As System.Windows.Forms.TabPage
    Friend WithEvents pnlEmpClass As System.Windows.Forms.Panel
    Friend WithEvents txtECDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtECCode As System.Windows.Forms.TextBox
    Friend WithEvents cboECComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblECComp As System.Windows.Forms.Label
    Friend WithEvents dgvEC As System.Windows.Forms.DataGridView
    Friend WithEvents lblECDesc As System.Windows.Forms.Label
    Friend WithEvents lblECCode As System.Windows.Forms.Label
    Friend WithEvents btnECCancel As System.Windows.Forms.Button
    Friend WithEvents btnECSave As System.Windows.Forms.Button
    Friend WithEvents dgvEG As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEGDesc As System.Windows.Forms.Label
    Friend WithEvents lblEGCode As System.Windows.Forms.Label
    Friend WithEvents lblEGEC As System.Windows.Forms.Label
    Friend WithEvents cboEGEC As System.Windows.Forms.ComboBox
    Friend WithEvents btnEGCancel As System.Windows.Forms.Button
    Friend WithEvents btnEGSave As System.Windows.Forms.Button
    Friend WithEvents txtEGDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtEGCode As System.Windows.Forms.TextBox
    Friend WithEvents cboEGComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblEGComp As System.Windows.Forms.Label
    Friend WithEvents colDeSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDeDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDiSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDiDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSeSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colSeDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colECSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colECDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colEGSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colEGDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents tpCostCenter As System.Windows.Forms.TabPage
    Friend WithEvents dgvLC As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlCC As System.Windows.Forms.Panel
    Friend WithEvents cboLCDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblLCDept As System.Windows.Forms.Label
    Friend WithEvents txtLCDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblLCDesc As System.Windows.Forms.Label
    Friend WithEvents lblLCCode As System.Windows.Forms.Label
    Friend WithEvents cboLCComp As System.Windows.Forms.ComboBox
    Friend WithEvents txtLCCode As System.Windows.Forms.TextBox
    Friend WithEvents lblLCComp As System.Windows.Forms.Label
    Friend WithEvents btnLCCancel As System.Windows.Forms.Button
    Friend WithEvents btnLCSave As System.Windows.Forms.Button
    Friend WithEvents tpLaborClassification As System.Windows.Forms.TabPage
    Friend WithEvents tpLaborLocation As System.Windows.Forms.TabPage
    Friend WithEvents dgvCL As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewButtonColumn3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlCL As System.Windows.Forms.Panel
    Friend WithEvents cboCLDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblCLDept As System.Windows.Forms.Label
    Friend WithEvents txtCLDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblCLDesc As System.Windows.Forms.Label
    Friend WithEvents lblCLCode As System.Windows.Forms.Label
    Friend WithEvents cboCLComp As System.Windows.Forms.ComboBox
    Friend WithEvents txtCLCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCLComp As System.Windows.Forms.Label
    Friend WithEvents btnCLCancel As System.Windows.Forms.Button
    Friend WithEvents btnCLSave As System.Windows.Forms.Button
    Friend WithEvents dgvLL As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewButtonColumn5 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn6 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cboLLDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblLLDept As System.Windows.Forms.Label
    Friend WithEvents txtLLDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblLLDesc As System.Windows.Forms.Label
    Friend WithEvents lblLLCode As System.Windows.Forms.Label
    Friend WithEvents cboLLComp As System.Windows.Forms.ComboBox
    Friend WithEvents txtLLCode As System.Windows.Forms.TextBox
    Friend WithEvents lblLLComp As System.Windows.Forms.Label
    Friend WithEvents btnLLCancel As System.Windows.Forms.Button
    Friend WithEvents btnLLSave As System.Windows.Forms.Button

End Class
