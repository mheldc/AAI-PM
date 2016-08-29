<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneralSetup))
        Me.tcGS = New System.Windows.Forms.TabControl()
        Me.tpSystem = New System.Windows.Forms.TabPage()
        Me.tcLic = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCnTest = New System.Windows.Forms.Button()
        Me.btnCnSave = New System.Windows.Forms.Button()
        Me.pnlCnUser = New System.Windows.Forms.Panel()
        Me.lblCnDefPort = New System.Windows.Forms.Label()
        Me.txtCnDefPort = New System.Windows.Forms.TextBox()
        Me.lblCnLogPw = New System.Windows.Forms.Label()
        Me.txtCnLogPw = New System.Windows.Forms.TextBox()
        Me.lblCnLogId = New System.Windows.Forms.Label()
        Me.txtCnLogId = New System.Windows.Forms.TextBox()
        Me.lblCnDbase = New System.Windows.Forms.Label()
        Me.txtCnDbase = New System.Windows.Forms.TextBox()
        Me.lblCnServer = New System.Windows.Forms.Label()
        Me.rdbCnUserDef = New System.Windows.Forms.RadioButton()
        Me.txtCnServer = New System.Windows.Forms.TextBox()
        Me.pnlCnUseString = New System.Windows.Forms.Panel()
        Me.rdbCnUseString = New System.Windows.Forms.RadioButton()
        Me.txtCnUseString = New System.Windows.Forms.TextBox()
        Me.cboCnDbEnv = New System.Windows.Forms.ComboBox()
        Me.lblCnDbEnv = New System.Windows.Forms.Label()
        Me.tpMailServer = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tpLocation = New System.Windows.Forms.TabPage()
        Me.tcLocation = New System.Windows.Forms.TabControl()
        Me.tpRegion = New System.Windows.Forms.TabPage()
        Me.dgvRe = New System.Windows.Forms.DataGridView()
        Me.colReSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colReDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlRe = New System.Windows.Forms.Panel()
        Me.txtReName = New System.Windows.Forms.TextBox()
        Me.lblReName = New System.Windows.Forms.Label()
        Me.txtReCode = New System.Windows.Forms.TextBox()
        Me.lblReCode = New System.Windows.Forms.Label()
        Me.btnReCancel = New System.Windows.Forms.Button()
        Me.btnReSave = New System.Windows.Forms.Button()
        Me.tpProvince = New System.Windows.Forms.TabPage()
        Me.dgvPr = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPr = New System.Windows.Forms.Panel()
        Me.cboPrRegion = New System.Windows.Forms.ComboBox()
        Me.lblPrRegion = New System.Windows.Forms.Label()
        Me.txtPrName = New System.Windows.Forms.TextBox()
        Me.lblPrName = New System.Windows.Forms.Label()
        Me.txtPrCode = New System.Windows.Forms.TextBox()
        Me.lblPrCode = New System.Windows.Forms.Label()
        Me.btnPrCancel = New System.Windows.Forms.Button()
        Me.btnPrSave = New System.Windows.Forms.Button()
        Me.tpCity = New System.Windows.Forms.TabPage()
        Me.dgvCi = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlCi = New System.Windows.Forms.Panel()
        Me.cboCiProvince = New System.Windows.Forms.ComboBox()
        Me.lblCiProvince = New System.Windows.Forms.Label()
        Me.cboCiRegion = New System.Windows.Forms.ComboBox()
        Me.lblCiRegion = New System.Windows.Forms.Label()
        Me.txtCiName = New System.Windows.Forms.TextBox()
        Me.lblCiName = New System.Windows.Forms.Label()
        Me.txtCiCode = New System.Windows.Forms.TextBox()
        Me.lblCiCode = New System.Windows.Forms.Label()
        Me.btnCiCancel = New System.Windows.Forms.Button()
        Me.btnCiSave = New System.Windows.Forms.Button()
        Me.tcGS.SuspendLayout()
        Me.tpSystem.SuspendLayout()
        Me.tcLic.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlCnUser.SuspendLayout()
        Me.pnlCnUseString.SuspendLayout()
        Me.tpMailServer.SuspendLayout()
        Me.tpLocation.SuspendLayout()
        Me.tcLocation.SuspendLayout()
        Me.tpRegion.SuspendLayout()
        CType(Me.dgvRe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRe.SuspendLayout()
        Me.tpProvince.SuspendLayout()
        CType(Me.dgvPr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPr.SuspendLayout()
        Me.tpCity.SuspendLayout()
        CType(Me.dgvCi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCi.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcGS
        '
        Me.tcGS.Controls.Add(Me.tpSystem)
        Me.tcGS.Controls.Add(Me.tpLocation)
        Me.tcGS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcGS.Location = New System.Drawing.Point(0, 0)
        Me.tcGS.Name = "tcGS"
        Me.tcGS.SelectedIndex = 0
        Me.tcGS.Size = New System.Drawing.Size(704, 493)
        Me.tcGS.TabIndex = 0
        '
        'tpSystem
        '
        Me.tpSystem.AutoScroll = True
        Me.tpSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpSystem.Controls.Add(Me.tcLic)
        Me.tpSystem.Location = New System.Drawing.Point(4, 23)
        Me.tpSystem.Name = "tpSystem"
        Me.tpSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSystem.Size = New System.Drawing.Size(696, 466)
        Me.tpSystem.TabIndex = 1
        Me.tpSystem.Text = "System"
        Me.tpSystem.UseVisualStyleBackColor = True
        '
        'tcLic
        '
        Me.tcLic.Controls.Add(Me.TabPage1)
        Me.tcLic.Controls.Add(Me.tpMailServer)
        Me.tcLic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcLic.Location = New System.Drawing.Point(3, 3)
        Me.tcLic.Name = "tcLic"
        Me.tcLic.SelectedIndex = 0
        Me.tcLic.Size = New System.Drawing.Size(688, 458)
        Me.tcLic.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btnCnTest)
        Me.TabPage1.Controls.Add(Me.btnCnSave)
        Me.TabPage1.Controls.Add(Me.pnlCnUser)
        Me.TabPage1.Controls.Add(Me.pnlCnUseString)
        Me.TabPage1.Controls.Add(Me.cboCnDbEnv)
        Me.TabPage1.Controls.Add(Me.lblCnDbEnv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(680, 431)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Database Connectivity"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCnTest
        '
        Me.btnCnTest.Image = CType(resources.GetObject("btnCnTest.Image"), System.Drawing.Image)
        Me.btnCnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCnTest.Location = New System.Drawing.Point(6, 301)
        Me.btnCnTest.Name = "btnCnTest"
        Me.btnCnTest.Size = New System.Drawing.Size(135, 25)
        Me.btnCnTest.TabIndex = 4
        Me.btnCnTest.Text = "Test Connectivity"
        Me.btnCnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCnTest.UseVisualStyleBackColor = True
        '
        'btnCnSave
        '
        Me.btnCnSave.Image = CType(resources.GetObject("btnCnSave.Image"), System.Drawing.Image)
        Me.btnCnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCnSave.Location = New System.Drawing.Point(147, 301)
        Me.btnCnSave.Name = "btnCnSave"
        Me.btnCnSave.Size = New System.Drawing.Size(106, 25)
        Me.btnCnSave.TabIndex = 3
        Me.btnCnSave.Text = "Save Settings"
        Me.btnCnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCnSave.UseVisualStyleBackColor = True
        '
        'pnlCnUser
        '
        Me.pnlCnUser.Controls.Add(Me.lblCnDefPort)
        Me.pnlCnUser.Controls.Add(Me.txtCnDefPort)
        Me.pnlCnUser.Controls.Add(Me.lblCnLogPw)
        Me.pnlCnUser.Controls.Add(Me.txtCnLogPw)
        Me.pnlCnUser.Controls.Add(Me.lblCnLogId)
        Me.pnlCnUser.Controls.Add(Me.txtCnLogId)
        Me.pnlCnUser.Controls.Add(Me.lblCnDbase)
        Me.pnlCnUser.Controls.Add(Me.txtCnDbase)
        Me.pnlCnUser.Controls.Add(Me.lblCnServer)
        Me.pnlCnUser.Controls.Add(Me.rdbCnUserDef)
        Me.pnlCnUser.Controls.Add(Me.txtCnServer)
        Me.pnlCnUser.Location = New System.Drawing.Point(2, 125)
        Me.pnlCnUser.Name = "pnlCnUser"
        Me.pnlCnUser.Size = New System.Drawing.Size(386, 170)
        Me.pnlCnUser.TabIndex = 14
        '
        'lblCnDefPort
        '
        Me.lblCnDefPort.AutoSize = True
        Me.lblCnDefPort.Location = New System.Drawing.Point(39, 139)
        Me.lblCnDefPort.Name = "lblCnDefPort"
        Me.lblCnDefPort.Size = New System.Drawing.Size(72, 14)
        Me.lblCnDefPort.TabIndex = 17
        Me.lblCnDefPort.Text = "Default Port"
        '
        'txtCnDefPort
        '
        Me.txtCnDefPort.Location = New System.Drawing.Point(151, 136)
        Me.txtCnDefPort.Name = "txtCnDefPort"
        Me.txtCnDefPort.Size = New System.Drawing.Size(48, 22)
        Me.txtCnDefPort.TabIndex = 16
        Me.txtCnDefPort.Text = "00000"
        '
        'lblCnLogPw
        '
        Me.lblCnLogPw.AutoSize = True
        Me.lblCnLogPw.Location = New System.Drawing.Point(39, 115)
        Me.lblCnLogPw.Name = "lblCnLogPw"
        Me.lblCnLogPw.Size = New System.Drawing.Size(59, 14)
        Me.lblCnLogPw.TabIndex = 15
        Me.lblCnLogPw.Text = "Password"
        '
        'txtCnLogPw
        '
        Me.txtCnLogPw.Location = New System.Drawing.Point(151, 112)
        Me.txtCnLogPw.Name = "txtCnLogPw"
        Me.txtCnLogPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtCnLogPw.Size = New System.Drawing.Size(227, 22)
        Me.txtCnLogPw.TabIndex = 14
        '
        'lblCnLogId
        '
        Me.lblCnLogId.AutoSize = True
        Me.lblCnLogId.Location = New System.Drawing.Point(39, 91)
        Me.lblCnLogId.Name = "lblCnLogId"
        Me.lblCnLogId.Size = New System.Drawing.Size(50, 14)
        Me.lblCnLogId.TabIndex = 13
        Me.lblCnLogId.Text = "Login Id"
        '
        'txtCnLogId
        '
        Me.txtCnLogId.Location = New System.Drawing.Point(151, 88)
        Me.txtCnLogId.Name = "txtCnLogId"
        Me.txtCnLogId.Size = New System.Drawing.Size(227, 22)
        Me.txtCnLogId.TabIndex = 12
        '
        'lblCnDbase
        '
        Me.lblCnDbase.AutoSize = True
        Me.lblCnDbase.Location = New System.Drawing.Point(39, 67)
        Me.lblCnDbase.Name = "lblCnDbase"
        Me.lblCnDbase.Size = New System.Drawing.Size(104, 14)
        Me.lblCnDbase.TabIndex = 11
        Me.lblCnDbase.Text = "Default Database"
        '
        'txtCnDbase
        '
        Me.txtCnDbase.Location = New System.Drawing.Point(151, 64)
        Me.txtCnDbase.Name = "txtCnDbase"
        Me.txtCnDbase.Size = New System.Drawing.Size(227, 22)
        Me.txtCnDbase.TabIndex = 10
        '
        'lblCnServer
        '
        Me.lblCnServer.AutoSize = True
        Me.lblCnServer.Location = New System.Drawing.Point(39, 43)
        Me.lblCnServer.Name = "lblCnServer"
        Me.lblCnServer.Size = New System.Drawing.Size(68, 14)
        Me.lblCnServer.TabIndex = 9
        Me.lblCnServer.Text = "Host Server"
        '
        'rdbCnUserDef
        '
        Me.rdbCnUserDef.AutoSize = True
        Me.rdbCnUserDef.Location = New System.Drawing.Point(4, 3)
        Me.rdbCnUserDef.Name = "rdbCnUserDef"
        Me.rdbCnUserDef.Size = New System.Drawing.Size(160, 18)
        Me.rdbCnUserDef.TabIndex = 8
        Me.rdbCnUserDef.TabStop = True
        Me.rdbCnUserDef.Text = "Use User-Defined Values"
        Me.rdbCnUserDef.UseVisualStyleBackColor = True
        '
        'txtCnServer
        '
        Me.txtCnServer.Location = New System.Drawing.Point(151, 40)
        Me.txtCnServer.Name = "txtCnServer"
        Me.txtCnServer.Size = New System.Drawing.Size(227, 22)
        Me.txtCnServer.TabIndex = 7
        '
        'pnlCnUseString
        '
        Me.pnlCnUseString.Controls.Add(Me.rdbCnUseString)
        Me.pnlCnUseString.Controls.Add(Me.txtCnUseString)
        Me.pnlCnUseString.Location = New System.Drawing.Point(2, 62)
        Me.pnlCnUseString.Name = "pnlCnUseString"
        Me.pnlCnUseString.Size = New System.Drawing.Size(386, 57)
        Me.pnlCnUseString.TabIndex = 13
        '
        'rdbCnUseString
        '
        Me.rdbCnUseString.AutoSize = True
        Me.rdbCnUseString.Location = New System.Drawing.Point(4, 3)
        Me.rdbCnUseString.Name = "rdbCnUseString"
        Me.rdbCnUseString.Size = New System.Drawing.Size(143, 18)
        Me.rdbCnUseString.TabIndex = 8
        Me.rdbCnUseString.TabStop = True
        Me.rdbCnUseString.Text = "Use Connection String"
        Me.rdbCnUseString.UseVisualStyleBackColor = True
        '
        'txtCnUseString
        '
        Me.txtCnUseString.Location = New System.Drawing.Point(4, 27)
        Me.txtCnUseString.Name = "txtCnUseString"
        Me.txtCnUseString.Size = New System.Drawing.Size(374, 22)
        Me.txtCnUseString.TabIndex = 7
        '
        'cboCnDbEnv
        '
        Me.cboCnDbEnv.FormattingEnabled = True
        Me.cboCnDbEnv.Items.AddRange(New Object() {"Microsoft SQL Server", "My SQL Community Server", "Oracle Server"})
        Me.cboCnDbEnv.Location = New System.Drawing.Point(153, 12)
        Me.cboCnDbEnv.Name = "cboCnDbEnv"
        Me.cboCnDbEnv.Size = New System.Drawing.Size(231, 22)
        Me.cboCnDbEnv.TabIndex = 12
        '
        'lblCnDbEnv
        '
        Me.lblCnDbEnv.AutoSize = True
        Me.lblCnDbEnv.Location = New System.Drawing.Point(7, 15)
        Me.lblCnDbEnv.Name = "lblCnDbEnv"
        Me.lblCnDbEnv.Size = New System.Drawing.Size(131, 14)
        Me.lblCnDbEnv.TabIndex = 11
        Me.lblCnDbEnv.Text = "Database Environment"
        '
        'tpMailServer
        '
        Me.tpMailServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpMailServer.Controls.Add(Me.Button2)
        Me.tpMailServer.Controls.Add(Me.Button1)
        Me.tpMailServer.Location = New System.Drawing.Point(4, 23)
        Me.tpMailServer.Name = "tpMailServer"
        Me.tpMailServer.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMailServer.Size = New System.Drawing.Size(680, 431)
        Me.tpMailServer.TabIndex = 2
        Me.tpMailServer.Text = "Mail Server"
        Me.tpMailServer.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(134, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Save Settings"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(7, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Send Test Email"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tpLocation
        '
        Me.tpLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpLocation.Controls.Add(Me.tcLocation)
        Me.tpLocation.Location = New System.Drawing.Point(4, 23)
        Me.tpLocation.Name = "tpLocation"
        Me.tpLocation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLocation.Size = New System.Drawing.Size(696, 466)
        Me.tpLocation.TabIndex = 0
        Me.tpLocation.Text = "Location"
        Me.tpLocation.UseVisualStyleBackColor = True
        '
        'tcLocation
        '
        Me.tcLocation.Controls.Add(Me.tpRegion)
        Me.tcLocation.Controls.Add(Me.tpProvince)
        Me.tcLocation.Controls.Add(Me.tpCity)
        Me.tcLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcLocation.Location = New System.Drawing.Point(3, 3)
        Me.tcLocation.Name = "tcLocation"
        Me.tcLocation.SelectedIndex = 0
        Me.tcLocation.Size = New System.Drawing.Size(688, 458)
        Me.tcLocation.TabIndex = 0
        '
        'tpRegion
        '
        Me.tpRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpRegion.Controls.Add(Me.dgvRe)
        Me.tpRegion.Controls.Add(Me.pnlRe)
        Me.tpRegion.Location = New System.Drawing.Point(4, 23)
        Me.tpRegion.Name = "tpRegion"
        Me.tpRegion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegion.Size = New System.Drawing.Size(680, 431)
        Me.tpRegion.TabIndex = 0
        Me.tpRegion.Text = "Region"
        Me.tpRegion.UseVisualStyleBackColor = True
        '
        'dgvRe
        '
        Me.dgvRe.AllowUserToAddRows = False
        Me.dgvRe.AllowUserToDeleteRows = False
        Me.dgvRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReSel, Me.colReDel})
        Me.dgvRe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRe.Location = New System.Drawing.Point(3, 102)
        Me.dgvRe.Name = "dgvRe"
        Me.dgvRe.ReadOnly = True
        Me.dgvRe.Size = New System.Drawing.Size(672, 324)
        Me.dgvRe.TabIndex = 2
        '
        'colReSel
        '
        Me.colReSel.Frozen = True
        Me.colReSel.HeaderText = ""
        Me.colReSel.Name = "colReSel"
        Me.colReSel.ReadOnly = True
        Me.colReSel.Text = "Select"
        Me.colReSel.UseColumnTextForButtonValue = True
        Me.colReSel.Width = 60
        '
        'colReDel
        '
        Me.colReDel.Frozen = True
        Me.colReDel.HeaderText = ""
        Me.colReDel.Name = "colReDel"
        Me.colReDel.ReadOnly = True
        Me.colReDel.Text = "Delete"
        Me.colReDel.UseColumnTextForButtonValue = True
        Me.colReDel.Width = 60
        '
        'pnlRe
        '
        Me.pnlRe.Controls.Add(Me.txtReName)
        Me.pnlRe.Controls.Add(Me.lblReName)
        Me.pnlRe.Controls.Add(Me.txtReCode)
        Me.pnlRe.Controls.Add(Me.lblReCode)
        Me.pnlRe.Controls.Add(Me.btnReCancel)
        Me.pnlRe.Controls.Add(Me.btnReSave)
        Me.pnlRe.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRe.Location = New System.Drawing.Point(3, 3)
        Me.pnlRe.Name = "pnlRe"
        Me.pnlRe.Size = New System.Drawing.Size(672, 99)
        Me.pnlRe.TabIndex = 0
        '
        'txtReName
        '
        Me.txtReName.Location = New System.Drawing.Point(125, 36)
        Me.txtReName.MaxLength = 150
        Me.txtReName.Name = "txtReName"
        Me.txtReName.Size = New System.Drawing.Size(350, 22)
        Me.txtReName.TabIndex = 7
        '
        'lblReName
        '
        Me.lblReName.AutoSize = True
        Me.lblReName.Location = New System.Drawing.Point(7, 39)
        Me.lblReName.Name = "lblReName"
        Me.lblReName.Size = New System.Drawing.Size(80, 14)
        Me.lblReName.TabIndex = 6
        Me.lblReName.Text = "Region Name"
        '
        'txtReCode
        '
        Me.txtReCode.Location = New System.Drawing.Point(125, 12)
        Me.txtReCode.MaxLength = 25
        Me.txtReCode.Name = "txtReCode"
        Me.txtReCode.Size = New System.Drawing.Size(150, 22)
        Me.txtReCode.TabIndex = 5
        '
        'lblReCode
        '
        Me.lblReCode.AutoSize = True
        Me.lblReCode.Location = New System.Drawing.Point(7, 15)
        Me.lblReCode.Name = "lblReCode"
        Me.lblReCode.Size = New System.Drawing.Size(75, 14)
        Me.lblReCode.TabIndex = 4
        Me.lblReCode.Text = "Region Code"
        '
        'btnReCancel
        '
        Me.btnReCancel.Image = CType(resources.GetObject("btnReCancel.Image"), System.Drawing.Image)
        Me.btnReCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReCancel.Location = New System.Drawing.Point(203, 64)
        Me.btnReCancel.Name = "btnReCancel"
        Me.btnReCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnReCancel.TabIndex = 3
        Me.btnReCancel.Text = "Cancel"
        Me.btnReCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReCancel.UseVisualStyleBackColor = True
        '
        'btnReSave
        '
        Me.btnReSave.Image = CType(resources.GetObject("btnReSave.Image"), System.Drawing.Image)
        Me.btnReSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReSave.Location = New System.Drawing.Point(125, 64)
        Me.btnReSave.Name = "btnReSave"
        Me.btnReSave.Size = New System.Drawing.Size(75, 25)
        Me.btnReSave.TabIndex = 2
        Me.btnReSave.Text = "Save"
        Me.btnReSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReSave.UseVisualStyleBackColor = True
        '
        'tpProvince
        '
        Me.tpProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpProvince.Controls.Add(Me.dgvPr)
        Me.tpProvince.Controls.Add(Me.pnlPr)
        Me.tpProvince.Location = New System.Drawing.Point(4, 23)
        Me.tpProvince.Name = "tpProvince"
        Me.tpProvince.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProvince.Size = New System.Drawing.Size(680, 431)
        Me.tpProvince.TabIndex = 1
        Me.tpProvince.Text = "Province"
        Me.tpProvince.UseVisualStyleBackColor = True
        '
        'dgvPr
        '
        Me.dgvPr.AllowUserToAddRows = False
        Me.dgvPr.AllowUserToDeleteRows = False
        Me.dgvPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn1, Me.DataGridViewButtonColumn2})
        Me.dgvPr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPr.Location = New System.Drawing.Point(3, 126)
        Me.dgvPr.Name = "dgvPr"
        Me.dgvPr.ReadOnly = True
        Me.dgvPr.Size = New System.Drawing.Size(672, 300)
        Me.dgvPr.TabIndex = 4
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
        'pnlPr
        '
        Me.pnlPr.Controls.Add(Me.cboPrRegion)
        Me.pnlPr.Controls.Add(Me.lblPrRegion)
        Me.pnlPr.Controls.Add(Me.txtPrName)
        Me.pnlPr.Controls.Add(Me.lblPrName)
        Me.pnlPr.Controls.Add(Me.txtPrCode)
        Me.pnlPr.Controls.Add(Me.lblPrCode)
        Me.pnlPr.Controls.Add(Me.btnPrCancel)
        Me.pnlPr.Controls.Add(Me.btnPrSave)
        Me.pnlPr.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPr.Location = New System.Drawing.Point(3, 3)
        Me.pnlPr.Name = "pnlPr"
        Me.pnlPr.Size = New System.Drawing.Size(672, 123)
        Me.pnlPr.TabIndex = 3
        '
        'cboPrRegion
        '
        Me.cboPrRegion.FormattingEnabled = True
        Me.cboPrRegion.Location = New System.Drawing.Point(125, 12)
        Me.cboPrRegion.Name = "cboPrRegion"
        Me.cboPrRegion.Size = New System.Drawing.Size(350, 22)
        Me.cboPrRegion.TabIndex = 9
        '
        'lblPrRegion
        '
        Me.lblPrRegion.AutoSize = True
        Me.lblPrRegion.Location = New System.Drawing.Point(7, 15)
        Me.lblPrRegion.Name = "lblPrRegion"
        Me.lblPrRegion.Size = New System.Drawing.Size(45, 14)
        Me.lblPrRegion.TabIndex = 8
        Me.lblPrRegion.Text = "Region"
        '
        'txtPrName
        '
        Me.txtPrName.Location = New System.Drawing.Point(125, 60)
        Me.txtPrName.MaxLength = 150
        Me.txtPrName.Name = "txtPrName"
        Me.txtPrName.Size = New System.Drawing.Size(350, 22)
        Me.txtPrName.TabIndex = 7
        '
        'lblPrName
        '
        Me.lblPrName.AutoSize = True
        Me.lblPrName.Location = New System.Drawing.Point(7, 63)
        Me.lblPrName.Name = "lblPrName"
        Me.lblPrName.Size = New System.Drawing.Size(87, 14)
        Me.lblPrName.TabIndex = 6
        Me.lblPrName.Text = "Province Name"
        '
        'txtPrCode
        '
        Me.txtPrCode.Location = New System.Drawing.Point(125, 36)
        Me.txtPrCode.MaxLength = 25
        Me.txtPrCode.Name = "txtPrCode"
        Me.txtPrCode.Size = New System.Drawing.Size(150, 22)
        Me.txtPrCode.TabIndex = 5
        '
        'lblPrCode
        '
        Me.lblPrCode.AutoSize = True
        Me.lblPrCode.Location = New System.Drawing.Point(7, 39)
        Me.lblPrCode.Name = "lblPrCode"
        Me.lblPrCode.Size = New System.Drawing.Size(82, 14)
        Me.lblPrCode.TabIndex = 4
        Me.lblPrCode.Text = "Province Code"
        '
        'btnPrCancel
        '
        Me.btnPrCancel.Image = CType(resources.GetObject("btnPrCancel.Image"), System.Drawing.Image)
        Me.btnPrCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrCancel.Location = New System.Drawing.Point(203, 88)
        Me.btnPrCancel.Name = "btnPrCancel"
        Me.btnPrCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnPrCancel.TabIndex = 3
        Me.btnPrCancel.Text = "Cancel"
        Me.btnPrCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrCancel.UseVisualStyleBackColor = True
        '
        'btnPrSave
        '
        Me.btnPrSave.Image = CType(resources.GetObject("btnPrSave.Image"), System.Drawing.Image)
        Me.btnPrSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrSave.Location = New System.Drawing.Point(125, 88)
        Me.btnPrSave.Name = "btnPrSave"
        Me.btnPrSave.Size = New System.Drawing.Size(75, 25)
        Me.btnPrSave.TabIndex = 2
        Me.btnPrSave.Text = "Save"
        Me.btnPrSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrSave.UseVisualStyleBackColor = True
        '
        'tpCity
        '
        Me.tpCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpCity.Controls.Add(Me.dgvCi)
        Me.tpCity.Controls.Add(Me.pnlCi)
        Me.tpCity.Location = New System.Drawing.Point(4, 23)
        Me.tpCity.Name = "tpCity"
        Me.tpCity.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCity.Size = New System.Drawing.Size(680, 431)
        Me.tpCity.TabIndex = 2
        Me.tpCity.Text = "City"
        Me.tpCity.UseVisualStyleBackColor = True
        '
        'dgvCi
        '
        Me.dgvCi.AllowUserToAddRows = False
        Me.dgvCi.AllowUserToDeleteRows = False
        Me.dgvCi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn3, Me.DataGridViewButtonColumn4})
        Me.dgvCi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCi.Location = New System.Drawing.Point(3, 152)
        Me.dgvCi.Name = "dgvCi"
        Me.dgvCi.ReadOnly = True
        Me.dgvCi.Size = New System.Drawing.Size(672, 274)
        Me.dgvCi.TabIndex = 4
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
        'pnlCi
        '
        Me.pnlCi.Controls.Add(Me.cboCiProvince)
        Me.pnlCi.Controls.Add(Me.lblCiProvince)
        Me.pnlCi.Controls.Add(Me.cboCiRegion)
        Me.pnlCi.Controls.Add(Me.lblCiRegion)
        Me.pnlCi.Controls.Add(Me.txtCiName)
        Me.pnlCi.Controls.Add(Me.lblCiName)
        Me.pnlCi.Controls.Add(Me.txtCiCode)
        Me.pnlCi.Controls.Add(Me.lblCiCode)
        Me.pnlCi.Controls.Add(Me.btnCiCancel)
        Me.pnlCi.Controls.Add(Me.btnCiSave)
        Me.pnlCi.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCi.Location = New System.Drawing.Point(3, 3)
        Me.pnlCi.Name = "pnlCi"
        Me.pnlCi.Size = New System.Drawing.Size(672, 149)
        Me.pnlCi.TabIndex = 3
        '
        'cboCiProvince
        '
        Me.cboCiProvince.FormattingEnabled = True
        Me.cboCiProvince.Location = New System.Drawing.Point(125, 36)
        Me.cboCiProvince.Name = "cboCiProvince"
        Me.cboCiProvince.Size = New System.Drawing.Size(350, 22)
        Me.cboCiProvince.TabIndex = 13
        '
        'lblCiProvince
        '
        Me.lblCiProvince.AutoSize = True
        Me.lblCiProvince.Location = New System.Drawing.Point(7, 39)
        Me.lblCiProvince.Name = "lblCiProvince"
        Me.lblCiProvince.Size = New System.Drawing.Size(52, 14)
        Me.lblCiProvince.TabIndex = 12
        Me.lblCiProvince.Text = "Province"
        '
        'cboCiRegion
        '
        Me.cboCiRegion.FormattingEnabled = True
        Me.cboCiRegion.Location = New System.Drawing.Point(125, 12)
        Me.cboCiRegion.Name = "cboCiRegion"
        Me.cboCiRegion.Size = New System.Drawing.Size(350, 22)
        Me.cboCiRegion.TabIndex = 11
        '
        'lblCiRegion
        '
        Me.lblCiRegion.AutoSize = True
        Me.lblCiRegion.Location = New System.Drawing.Point(7, 15)
        Me.lblCiRegion.Name = "lblCiRegion"
        Me.lblCiRegion.Size = New System.Drawing.Size(45, 14)
        Me.lblCiRegion.TabIndex = 10
        Me.lblCiRegion.Text = "Region"
        '
        'txtCiName
        '
        Me.txtCiName.Location = New System.Drawing.Point(125, 84)
        Me.txtCiName.MaxLength = 150
        Me.txtCiName.Name = "txtCiName"
        Me.txtCiName.Size = New System.Drawing.Size(350, 22)
        Me.txtCiName.TabIndex = 7
        '
        'lblCiName
        '
        Me.lblCiName.AutoSize = True
        Me.lblCiName.Location = New System.Drawing.Point(7, 87)
        Me.lblCiName.Name = "lblCiName"
        Me.lblCiName.Size = New System.Drawing.Size(61, 14)
        Me.lblCiName.TabIndex = 6
        Me.lblCiName.Text = "City Name"
        '
        'txtCiCode
        '
        Me.txtCiCode.Location = New System.Drawing.Point(125, 60)
        Me.txtCiCode.MaxLength = 25
        Me.txtCiCode.Name = "txtCiCode"
        Me.txtCiCode.Size = New System.Drawing.Size(150, 22)
        Me.txtCiCode.TabIndex = 5
        '
        'lblCiCode
        '
        Me.lblCiCode.AutoSize = True
        Me.lblCiCode.Location = New System.Drawing.Point(7, 63)
        Me.lblCiCode.Name = "lblCiCode"
        Me.lblCiCode.Size = New System.Drawing.Size(56, 14)
        Me.lblCiCode.TabIndex = 4
        Me.lblCiCode.Text = "City Code"
        '
        'btnCiCancel
        '
        Me.btnCiCancel.Image = CType(resources.GetObject("btnCiCancel.Image"), System.Drawing.Image)
        Me.btnCiCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCiCancel.Location = New System.Drawing.Point(203, 112)
        Me.btnCiCancel.Name = "btnCiCancel"
        Me.btnCiCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCiCancel.TabIndex = 3
        Me.btnCiCancel.Text = "Cancel"
        Me.btnCiCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCiCancel.UseVisualStyleBackColor = True
        '
        'btnCiSave
        '
        Me.btnCiSave.Image = CType(resources.GetObject("btnCiSave.Image"), System.Drawing.Image)
        Me.btnCiSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCiSave.Location = New System.Drawing.Point(125, 112)
        Me.btnCiSave.Name = "btnCiSave"
        Me.btnCiSave.Size = New System.Drawing.Size(75, 25)
        Me.btnCiSave.TabIndex = 2
        Me.btnCiSave.Text = "Save"
        Me.btnCiSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCiSave.UseVisualStyleBackColor = True
        '
        'frmGeneralSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 493)
        Me.Controls.Add(Me.tcGS)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGeneralSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General System Setup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcGS.ResumeLayout(False)
        Me.tpSystem.ResumeLayout(False)
        Me.tcLic.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlCnUser.ResumeLayout(False)
        Me.pnlCnUser.PerformLayout()
        Me.pnlCnUseString.ResumeLayout(False)
        Me.pnlCnUseString.PerformLayout()
        Me.tpMailServer.ResumeLayout(False)
        Me.tpLocation.ResumeLayout(False)
        Me.tcLocation.ResumeLayout(False)
        Me.tpRegion.ResumeLayout(False)
        CType(Me.dgvRe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRe.ResumeLayout(False)
        Me.pnlRe.PerformLayout()
        Me.tpProvince.ResumeLayout(False)
        CType(Me.dgvPr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPr.ResumeLayout(False)
        Me.pnlPr.PerformLayout()
        Me.tpCity.ResumeLayout(False)
        CType(Me.dgvCi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCi.ResumeLayout(False)
        Me.pnlCi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcGS As System.Windows.Forms.TabControl
    Friend WithEvents tpLocation As System.Windows.Forms.TabPage
    Friend WithEvents tcLocation As System.Windows.Forms.TabControl
    Friend WithEvents tpRegion As System.Windows.Forms.TabPage
    Friend WithEvents pnlRe As System.Windows.Forms.Panel
    Friend WithEvents tpProvince As System.Windows.Forms.TabPage
    Friend WithEvents tpCity As System.Windows.Forms.TabPage
    Friend WithEvents btnReCancel As System.Windows.Forms.Button
    Friend WithEvents btnReSave As System.Windows.Forms.Button
    Friend WithEvents txtReCode As System.Windows.Forms.TextBox
    Friend WithEvents lblReCode As System.Windows.Forms.Label
    Friend WithEvents txtReName As System.Windows.Forms.TextBox
    Friend WithEvents lblReName As System.Windows.Forms.Label
    Friend WithEvents dgvRe As System.Windows.Forms.DataGridView
    Friend WithEvents colReSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colReDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvPr As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlPr As System.Windows.Forms.Panel
    Friend WithEvents cboPrRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrRegion As System.Windows.Forms.Label
    Friend WithEvents txtPrName As System.Windows.Forms.TextBox
    Friend WithEvents lblPrName As System.Windows.Forms.Label
    Friend WithEvents txtPrCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPrCode As System.Windows.Forms.Label
    Friend WithEvents btnPrCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrSave As System.Windows.Forms.Button
    Friend WithEvents dgvCi As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewButtonColumn3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlCi As System.Windows.Forms.Panel
    Friend WithEvents cboCiProvince As System.Windows.Forms.ComboBox
    Friend WithEvents lblCiProvince As System.Windows.Forms.Label
    Friend WithEvents cboCiRegion As System.Windows.Forms.ComboBox
    Friend WithEvents lblCiRegion As System.Windows.Forms.Label
    Friend WithEvents txtCiName As System.Windows.Forms.TextBox
    Friend WithEvents lblCiName As System.Windows.Forms.Label
    Friend WithEvents txtCiCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCiCode As System.Windows.Forms.Label
    Friend WithEvents btnCiCancel As System.Windows.Forms.Button
    Friend WithEvents btnCiSave As System.Windows.Forms.Button
    Friend WithEvents tpSystem As System.Windows.Forms.TabPage
    Friend WithEvents tcLic As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnCnTest As System.Windows.Forms.Button
    Friend WithEvents btnCnSave As System.Windows.Forms.Button
    Friend WithEvents pnlCnUser As System.Windows.Forms.Panel
    Friend WithEvents lblCnDefPort As System.Windows.Forms.Label
    Friend WithEvents txtCnDefPort As System.Windows.Forms.TextBox
    Friend WithEvents lblCnLogPw As System.Windows.Forms.Label
    Friend WithEvents txtCnLogPw As System.Windows.Forms.TextBox
    Friend WithEvents lblCnLogId As System.Windows.Forms.Label
    Friend WithEvents txtCnLogId As System.Windows.Forms.TextBox
    Friend WithEvents lblCnDbase As System.Windows.Forms.Label
    Friend WithEvents txtCnDbase As System.Windows.Forms.TextBox
    Friend WithEvents lblCnServer As System.Windows.Forms.Label
    Friend WithEvents rdbCnUserDef As System.Windows.Forms.RadioButton
    Friend WithEvents txtCnServer As System.Windows.Forms.TextBox
    Friend WithEvents pnlCnUseString As System.Windows.Forms.Panel
    Friend WithEvents rdbCnUseString As System.Windows.Forms.RadioButton
    Friend WithEvents txtCnUseString As System.Windows.Forms.TextBox
    Friend WithEvents cboCnDbEnv As System.Windows.Forms.ComboBox
    Friend WithEvents lblCnDbEnv As System.Windows.Forms.Label
    Friend WithEvents tpMailServer As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
