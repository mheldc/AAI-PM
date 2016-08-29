<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeMaster))
        Me.tcEmpInfo = New System.Windows.Forms.TabControl()
        Me.tpEmpInfo = New System.Windows.Forms.TabPage()
        Me.txtEmpOCN = New System.Windows.Forms.TextBox()
        Me.lblEmpOCN = New System.Windows.Forms.Label()
        Me.txtTin = New System.Windows.Forms.TextBox()
        Me.lblTin = New System.Windows.Forms.Label()
        Me.btnSelImg = New System.Windows.Forms.Button()
        Me.pnlEmpImg = New System.Windows.Forms.Panel()
        Me.picEmpImg = New System.Windows.Forms.PictureBox()
        Me.txtEmpBioId = New System.Windows.Forms.TextBox()
        Me.lblEmpBioId = New System.Windows.Forms.Label()
        Me.txtEmpPHNo = New System.Windows.Forms.TextBox()
        Me.lblEmpPHNo = New System.Windows.Forms.Label()
        Me.txtEmpHNo = New System.Windows.Forms.TextBox()
        Me.lblEmpHNo = New System.Windows.Forms.Label()
        Me.txtEmpSNo = New System.Windows.Forms.TextBox()
        Me.lblEmpSNo = New System.Windows.Forms.Label()
        Me.cboCStatus = New System.Windows.Forms.ComboBox()
        Me.lblCStatus = New System.Windows.Forms.Label()
        Me.dtpBDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBDate = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.tpEEmpInfo = New System.Windows.Forms.TabPage()
        Me.cboEmpCC = New System.Windows.Forms.ComboBox()
        Me.lblEmpCC = New System.Windows.Forms.Label()
        Me.cboEmpGroup = New System.Windows.Forms.ComboBox()
        Me.lblEmpGroup = New System.Windows.Forms.Label()
        Me.cboEmpSect = New System.Windows.Forms.ComboBox()
        Me.cboEmpDivi = New System.Windows.Forms.ComboBox()
        Me.cboEmpDept = New System.Windows.Forms.ComboBox()
        Me.cboEmpLR = New System.Windows.Forms.ComboBox()
        Me.lblEmpLeftReason = New System.Windows.Forms.Label()
        Me.lblEmpLeftDate = New System.Windows.Forms.Label()
        Me.lblEmpRepDate = New System.Windows.Forms.Label()
        Me.lblEmpHireDate = New System.Windows.Forms.Label()
        Me.dtpEmpLD = New System.Windows.Forms.DateTimePicker()
        Me.dtpEmpRD = New System.Windows.Forms.DateTimePicker()
        Me.dtpEmpHD = New System.Windows.Forms.DateTimePicker()
        Me.cboEmpClass = New System.Windows.Forms.ComboBox()
        Me.lblEmpClass = New System.Windows.Forms.Label()
        Me.txtEmpJP = New System.Windows.Forms.TextBox()
        Me.lblEmpJP = New System.Windows.Forms.Label()
        Me.lblEmpSect = New System.Windows.Forms.Label()
        Me.lblEmpDivi = New System.Windows.Forms.Label()
        Me.lblEmpDept = New System.Windows.Forms.Label()
        Me.cboEmpComp = New System.Windows.Forms.ComboBox()
        Me.lblEmpComp = New System.Windows.Forms.Label()
        Me.tpEPayInfo = New System.Windows.Forms.TabPage()
        Me.cboRateType = New System.Windows.Forms.ComboBox()
        Me.cboEmpPC = New System.Windows.Forms.ComboBox()
        Me.lblEmpPC = New System.Windows.Forms.Label()
        Me.chkHDMF = New System.Windows.Forms.CheckBox()
        Me.chkPH = New System.Windows.Forms.CheckBox()
        Me.chkSSS = New System.Windows.Forms.CheckBox()
        Me.cboEmpPR = New System.Windows.Forms.ComboBox()
        Me.lblPayRef = New System.Windows.Forms.Label()
        Me.cboEmpEB = New System.Windows.Forms.ComboBox()
        Me.lblEmpEcolaBase = New System.Windows.Forms.Label()
        Me.txtEmpAN = New System.Windows.Forms.TextBox()
        Me.lblEmpAN = New System.Windows.Forms.Label()
        Me.cboEmpPB = New System.Windows.Forms.ComboBox()
        Me.lblEmpPB = New System.Windows.Forms.Label()
        Me.chkEmpMW = New System.Windows.Forms.CheckBox()
        Me.txtEmpSR = New System.Windows.Forms.TextBox()
        Me.lblEmpSR = New System.Windows.Forms.Label()
        Me.cboEmpPyB = New System.Windows.Forms.ComboBox()
        Me.lblEmpPayBasis = New System.Windows.Forms.Label()
        Me.cboEmpTxT = New System.Windows.Forms.ComboBox()
        Me.lblEmpTxType = New System.Windows.Forms.Label()
        Me.pnlBottomControl = New System.Windows.Forms.Panel()
        Me.pnlPStat = New System.Windows.Forms.Panel()
        Me.lblPStat = New System.Windows.Forms.Label()
        Me.pnlImport = New System.Windows.Forms.Panel()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pnlBottomRight = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlEMS = New System.Windows.Forms.Panel()
        Me.dgvEMS = New System.Windows.Forms.DataGridView()
        Me.colEmpSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colEmpDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ofdEmpImg = New System.Windows.Forms.OpenFileDialog()
        Me.ofdImportFile = New System.Windows.Forms.OpenFileDialog()
        Me.cboEmpLoc = New System.Windows.Forms.ComboBox()
        Me.lblEmpLoc = New System.Windows.Forms.Label()
        Me.cboEmpLC = New System.Windows.Forms.ComboBox()
        Me.lblEmpLC = New System.Windows.Forms.Label()
        Me.tcEmpInfo.SuspendLayout()
        Me.tpEmpInfo.SuspendLayout()
        Me.pnlEmpImg.SuspendLayout()
        CType(Me.picEmpImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEEmpInfo.SuspendLayout()
        Me.tpEPayInfo.SuspendLayout()
        Me.pnlBottomControl.SuspendLayout()
        Me.pnlPStat.SuspendLayout()
        Me.pnlImport.SuspendLayout()
        Me.pnlBottomRight.SuspendLayout()
        Me.pnlEMS.SuspendLayout()
        CType(Me.dgvEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcEmpInfo
        '
        Me.tcEmpInfo.Controls.Add(Me.tpEmpInfo)
        Me.tcEmpInfo.Controls.Add(Me.tpEEmpInfo)
        Me.tcEmpInfo.Controls.Add(Me.tpEPayInfo)
        Me.tcEmpInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.tcEmpInfo.Location = New System.Drawing.Point(0, 0)
        Me.tcEmpInfo.Name = "tcEmpInfo"
        Me.tcEmpInfo.SelectedIndex = 0
        Me.tcEmpInfo.Size = New System.Drawing.Size(964, 305)
        Me.tcEmpInfo.TabIndex = 4
        '
        'tpEmpInfo
        '
        Me.tpEmpInfo.AutoScroll = True
        Me.tpEmpInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpEmpInfo.Controls.Add(Me.txtEmpOCN)
        Me.tpEmpInfo.Controls.Add(Me.lblEmpOCN)
        Me.tpEmpInfo.Controls.Add(Me.txtTin)
        Me.tpEmpInfo.Controls.Add(Me.lblTin)
        Me.tpEmpInfo.Controls.Add(Me.btnSelImg)
        Me.tpEmpInfo.Controls.Add(Me.pnlEmpImg)
        Me.tpEmpInfo.Controls.Add(Me.txtEmpBioId)
        Me.tpEmpInfo.Controls.Add(Me.lblEmpBioId)
        Me.tpEmpInfo.Controls.Add(Me.txtEmpPHNo)
        Me.tpEmpInfo.Controls.Add(Me.lblEmpPHNo)
        Me.tpEmpInfo.Controls.Add(Me.txtEmpHNo)
        Me.tpEmpInfo.Controls.Add(Me.lblEmpHNo)
        Me.tpEmpInfo.Controls.Add(Me.txtEmpSNo)
        Me.tpEmpInfo.Controls.Add(Me.lblEmpSNo)
        Me.tpEmpInfo.Controls.Add(Me.cboCStatus)
        Me.tpEmpInfo.Controls.Add(Me.lblCStatus)
        Me.tpEmpInfo.Controls.Add(Me.dtpBDate)
        Me.tpEmpInfo.Controls.Add(Me.lblBDate)
        Me.tpEmpInfo.Controls.Add(Me.cboGender)
        Me.tpEmpInfo.Controls.Add(Me.lblGender)
        Me.tpEmpInfo.Controls.Add(Me.txtSuffix)
        Me.tpEmpInfo.Controls.Add(Me.lblSuffix)
        Me.tpEmpInfo.Controls.Add(Me.txtMiddleName)
        Me.tpEmpInfo.Controls.Add(Me.lblMiddleName)
        Me.tpEmpInfo.Controls.Add(Me.txtFirstName)
        Me.tpEmpInfo.Controls.Add(Me.lblFirstName)
        Me.tpEmpInfo.Controls.Add(Me.txtLastName)
        Me.tpEmpInfo.Controls.Add(Me.lblLastName)
        Me.tpEmpInfo.Controls.Add(Me.txtEmpNo)
        Me.tpEmpInfo.Controls.Add(Me.lblEmpNo)
        Me.tpEmpInfo.Location = New System.Drawing.Point(4, 23)
        Me.tpEmpInfo.Name = "tpEmpInfo"
        Me.tpEmpInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmpInfo.Size = New System.Drawing.Size(956, 278)
        Me.tpEmpInfo.TabIndex = 0
        Me.tpEmpInfo.Text = "Employee Information"
        Me.tpEmpInfo.ToolTipText = "New Employee Profile"
        Me.tpEmpInfo.UseVisualStyleBackColor = True
        '
        'txtEmpOCN
        '
        Me.txtEmpOCN.Location = New System.Drawing.Point(301, 59)
        Me.txtEmpOCN.MaxLength = 15
        Me.txtEmpOCN.Name = "txtEmpOCN"
        Me.txtEmpOCN.Size = New System.Drawing.Size(150, 22)
        Me.txtEmpOCN.TabIndex = 3
        '
        'lblEmpOCN
        '
        Me.lblEmpOCN.AutoSize = True
        Me.lblEmpOCN.Location = New System.Drawing.Point(168, 62)
        Me.lblEmpOCN.Name = "lblEmpOCN"
        Me.lblEmpOCN.Size = New System.Drawing.Size(29, 14)
        Me.lblEmpOCN.TabIndex = 55
        Me.lblEmpOCN.Text = "OCN"
        '
        'txtTin
        '
        Me.txtTin.Location = New System.Drawing.Point(724, 84)
        Me.txtTin.MaxLength = 25
        Me.txtTin.Name = "txtTin"
        Me.txtTin.Size = New System.Drawing.Size(199, 22)
        Me.txtTin.TabIndex = 11
        '
        'lblTin
        '
        Me.lblTin.AutoSize = True
        Me.lblTin.Location = New System.Drawing.Point(590, 87)
        Me.lblTin.Name = "lblTin"
        Me.lblTin.Size = New System.Drawing.Size(25, 14)
        Me.lblTin.TabIndex = 53
        Me.lblTin.Text = "TIN"
        '
        'btnSelImg
        '
        Me.btnSelImg.Image = CType(resources.GetObject("btnSelImg.Image"), System.Drawing.Image)
        Me.btnSelImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelImg.Location = New System.Drawing.Point(5, 146)
        Me.btnSelImg.Name = "btnSelImg"
        Me.btnSelImg.Size = New System.Drawing.Size(141, 25)
        Me.btnSelImg.TabIndex = 52
        Me.btnSelImg.Text = "Choose Image"
        Me.btnSelImg.UseVisualStyleBackColor = True
        '
        'pnlEmpImg
        '
        Me.pnlEmpImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEmpImg.Controls.Add(Me.picEmpImg)
        Me.pnlEmpImg.Location = New System.Drawing.Point(5, 5)
        Me.pnlEmpImg.Name = "pnlEmpImg"
        Me.pnlEmpImg.Size = New System.Drawing.Size(141, 135)
        Me.pnlEmpImg.TabIndex = 51
        '
        'picEmpImg
        '
        Me.picEmpImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picEmpImg.Image = CType(resources.GetObject("picEmpImg.Image"), System.Drawing.Image)
        Me.picEmpImg.InitialImage = CType(resources.GetObject("picEmpImg.InitialImage"), System.Drawing.Image)
        Me.picEmpImg.Location = New System.Drawing.Point(0, 0)
        Me.picEmpImg.Name = "picEmpImg"
        Me.picEmpImg.Size = New System.Drawing.Size(139, 133)
        Me.picEmpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEmpImg.TabIndex = 50
        Me.picEmpImg.TabStop = False
        '
        'txtEmpBioId
        '
        Me.txtEmpBioId.Location = New System.Drawing.Point(301, 34)
        Me.txtEmpBioId.MaxLength = 25
        Me.txtEmpBioId.Name = "txtEmpBioId"
        Me.txtEmpBioId.Size = New System.Drawing.Size(150, 22)
        Me.txtEmpBioId.TabIndex = 2
        '
        'lblEmpBioId
        '
        Me.lblEmpBioId.AutoSize = True
        Me.lblEmpBioId.Location = New System.Drawing.Point(168, 37)
        Me.lblEmpBioId.Name = "lblEmpBioId"
        Me.lblEmpBioId.Size = New System.Drawing.Size(79, 14)
        Me.lblEmpBioId.TabIndex = 47
        Me.lblEmpBioId.Text = "Biometrics Id"
        '
        'txtEmpPHNo
        '
        Me.txtEmpPHNo.Location = New System.Drawing.Point(724, 159)
        Me.txtEmpPHNo.MaxLength = 25
        Me.txtEmpPHNo.Name = "txtEmpPHNo"
        Me.txtEmpPHNo.Size = New System.Drawing.Size(199, 22)
        Me.txtEmpPHNo.TabIndex = 14
        '
        'lblEmpPHNo
        '
        Me.lblEmpPHNo.AutoSize = True
        Me.lblEmpPHNo.Location = New System.Drawing.Point(590, 162)
        Me.lblEmpPHNo.Name = "lblEmpPHNo"
        Me.lblEmpPHNo.Size = New System.Drawing.Size(110, 14)
        Me.lblEmpPHNo.TabIndex = 20
        Me.lblEmpPHNo.Text = "Philhealth Number"
        '
        'txtEmpHNo
        '
        Me.txtEmpHNo.Location = New System.Drawing.Point(724, 134)
        Me.txtEmpHNo.MaxLength = 25
        Me.txtEmpHNo.Name = "txtEmpHNo"
        Me.txtEmpHNo.Size = New System.Drawing.Size(199, 22)
        Me.txtEmpHNo.TabIndex = 13
        '
        'lblEmpHNo
        '
        Me.lblEmpHNo.AutoSize = True
        Me.lblEmpHNo.Location = New System.Drawing.Point(590, 137)
        Me.lblEmpHNo.Name = "lblEmpHNo"
        Me.lblEmpHNo.Size = New System.Drawing.Size(85, 14)
        Me.lblEmpHNo.TabIndex = 18
        Me.lblEmpHNo.Text = "HDMF Number"
        '
        'txtEmpSNo
        '
        Me.txtEmpSNo.Location = New System.Drawing.Point(724, 109)
        Me.txtEmpSNo.MaxLength = 25
        Me.txtEmpSNo.Name = "txtEmpSNo"
        Me.txtEmpSNo.Size = New System.Drawing.Size(199, 22)
        Me.txtEmpSNo.TabIndex = 12
        '
        'lblEmpSNo
        '
        Me.lblEmpSNo.AutoSize = True
        Me.lblEmpSNo.Location = New System.Drawing.Point(590, 112)
        Me.lblEmpSNo.Name = "lblEmpSNo"
        Me.lblEmpSNo.Size = New System.Drawing.Size(71, 14)
        Me.lblEmpSNo.TabIndex = 16
        Me.lblEmpSNo.Text = "SSS Number"
        '
        'cboCStatus
        '
        Me.cboCStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStatus.FormattingEnabled = True
        Me.cboCStatus.Location = New System.Drawing.Point(724, 59)
        Me.cboCStatus.Name = "cboCStatus"
        Me.cboCStatus.Size = New System.Drawing.Size(199, 22)
        Me.cboCStatus.TabIndex = 10
        '
        'lblCStatus
        '
        Me.lblCStatus.AutoSize = True
        Me.lblCStatus.Location = New System.Drawing.Point(590, 62)
        Me.lblCStatus.Name = "lblCStatus"
        Me.lblCStatus.Size = New System.Drawing.Size(67, 14)
        Me.lblCStatus.TabIndex = 14
        Me.lblCStatus.Text = "Civil Status"
        '
        'dtpBDate
        '
        Me.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBDate.Location = New System.Drawing.Point(724, 34)
        Me.dtpBDate.Name = "dtpBDate"
        Me.dtpBDate.Size = New System.Drawing.Size(199, 22)
        Me.dtpBDate.TabIndex = 9
        Me.dtpBDate.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lblBDate
        '
        Me.lblBDate.AutoSize = True
        Me.lblBDate.Location = New System.Drawing.Point(590, 38)
        Me.lblBDate.Name = "lblBDate"
        Me.lblBDate.Size = New System.Drawing.Size(61, 14)
        Me.lblBDate.TabIndex = 12
        Me.lblBDate.Text = "Birth date"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"- Select Gender -", "Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(724, 9)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(199, 22)
        Me.cboGender.TabIndex = 8
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(590, 12)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(47, 14)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(301, 109)
        Me.txtSuffix.MaxLength = 10
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(77, 22)
        Me.txtSuffix.TabIndex = 5
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Location = New System.Drawing.Point(168, 112)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(35, 14)
        Me.lblSuffix.TabIndex = 8
        Me.lblSuffix.Text = "Suffix"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(301, 159)
        Me.txtMiddleName.MaxLength = 50
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(250, 22)
        Me.txtMiddleName.TabIndex = 7
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(168, 162)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(81, 14)
        Me.lblMiddleName.TabIndex = 6
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(301, 134)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(250, 22)
        Me.txtFirstName.TabIndex = 6
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(168, 137)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(66, 14)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(301, 84)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(250, 22)
        Me.txtLastName.TabIndex = 4
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(168, 87)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(64, 14)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(301, 9)
        Me.txtEmpNo.MaxLength = 25
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(150, 22)
        Me.txtEmpNo.TabIndex = 1
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Location = New System.Drawing.Point(168, 12)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(81, 14)
        Me.lblEmpNo.TabIndex = 0
        Me.lblEmpNo.Text = "Employee No."
        '
        'tpEEmpInfo
        '
        Me.tpEEmpInfo.AutoScroll = True
        Me.tpEEmpInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpLoc)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpLoc)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpLC)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpLC)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpCC)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpCC)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpGroup)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpGroup)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpSect)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpDivi)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpDept)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpLR)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpLeftReason)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpLeftDate)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpRepDate)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpHireDate)
        Me.tpEEmpInfo.Controls.Add(Me.dtpEmpLD)
        Me.tpEEmpInfo.Controls.Add(Me.dtpEmpRD)
        Me.tpEEmpInfo.Controls.Add(Me.dtpEmpHD)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpClass)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpClass)
        Me.tpEEmpInfo.Controls.Add(Me.txtEmpJP)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpJP)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpSect)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpDivi)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpDept)
        Me.tpEEmpInfo.Controls.Add(Me.cboEmpComp)
        Me.tpEEmpInfo.Controls.Add(Me.lblEmpComp)
        Me.tpEEmpInfo.Location = New System.Drawing.Point(4, 23)
        Me.tpEEmpInfo.Name = "tpEEmpInfo"
        Me.tpEEmpInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEEmpInfo.Size = New System.Drawing.Size(956, 278)
        Me.tpEEmpInfo.TabIndex = 1
        Me.tpEEmpInfo.Text = "Employment Information"
        Me.tpEEmpInfo.UseVisualStyleBackColor = True
        '
        'cboEmpCC
        '
        Me.cboEmpCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpCC.FormattingEnabled = True
        Me.cboEmpCC.Location = New System.Drawing.Point(135, 162)
        Me.cboEmpCC.Name = "cboEmpCC"
        Me.cboEmpCC.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpCC.TabIndex = 70
        '
        'lblEmpCC
        '
        Me.lblEmpCC.AutoSize = True
        Me.lblEmpCC.Location = New System.Drawing.Point(7, 165)
        Me.lblEmpCC.Name = "lblEmpCC"
        Me.lblEmpCC.Size = New System.Drawing.Size(68, 14)
        Me.lblEmpCC.TabIndex = 71
        Me.lblEmpCC.Text = "Cost Center"
        '
        'cboEmpGroup
        '
        Me.cboEmpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpGroup.FormattingEnabled = True
        Me.cboEmpGroup.Items.AddRange(New Object() {"- Select a Payroll Basis -", "Daily", "Weekly", "Semi-Monthly", "Monthly"})
        Me.cboEmpGroup.Location = New System.Drawing.Point(135, 62)
        Me.cboEmpGroup.Name = "cboEmpGroup"
        Me.cboEmpGroup.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpGroup.TabIndex = 17
        '
        'lblEmpGroup
        '
        Me.lblEmpGroup.AutoSize = True
        Me.lblEmpGroup.Location = New System.Drawing.Point(7, 67)
        Me.lblEmpGroup.Name = "lblEmpGroup"
        Me.lblEmpGroup.Size = New System.Drawing.Size(96, 14)
        Me.lblEmpGroup.TabIndex = 69
        Me.lblEmpGroup.Text = "Employee Group"
        '
        'cboEmpSect
        '
        Me.cboEmpSect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpSect.FormattingEnabled = True
        Me.cboEmpSect.Location = New System.Drawing.Point(135, 137)
        Me.cboEmpSect.Name = "cboEmpSect"
        Me.cboEmpSect.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpSect.TabIndex = 20
        '
        'cboEmpDivi
        '
        Me.cboEmpDivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpDivi.FormattingEnabled = True
        Me.cboEmpDivi.Location = New System.Drawing.Point(135, 112)
        Me.cboEmpDivi.Name = "cboEmpDivi"
        Me.cboEmpDivi.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpDivi.TabIndex = 19
        '
        'cboEmpDept
        '
        Me.cboEmpDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpDept.FormattingEnabled = True
        Me.cboEmpDept.Location = New System.Drawing.Point(135, 87)
        Me.cboEmpDept.Name = "cboEmpDept"
        Me.cboEmpDept.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpDept.TabIndex = 18
        '
        'cboEmpLR
        '
        Me.cboEmpLR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpLR.FormattingEnabled = True
        Me.cboEmpLR.Items.AddRange(New Object() {"- Select a Leave Reason -", "End-of-Contract", "Contract Termination", "Voluntary Resignation", "Retirement"})
        Me.cboEmpLR.Location = New System.Drawing.Point(635, 84)
        Me.cboEmpLR.Name = "cboEmpLR"
        Me.cboEmpLR.Size = New System.Drawing.Size(310, 22)
        Me.cboEmpLR.TabIndex = 25
        '
        'lblEmpLeftReason
        '
        Me.lblEmpLeftReason.AutoSize = True
        Me.lblEmpLeftReason.Location = New System.Drawing.Point(507, 87)
        Me.lblEmpLeftReason.Name = "lblEmpLeftReason"
        Me.lblEmpLeftReason.Size = New System.Drawing.Size(110, 14)
        Me.lblEmpLeftReason.TabIndex = 67
        Me.lblEmpLeftReason.Text = "Reason for Leaving"
        '
        'lblEmpLeftDate
        '
        Me.lblEmpLeftDate.AutoSize = True
        Me.lblEmpLeftDate.Location = New System.Drawing.Point(507, 65)
        Me.lblEmpLeftDate.Name = "lblEmpLeftDate"
        Me.lblEmpLeftDate.Size = New System.Drawing.Size(55, 14)
        Me.lblEmpLeftDate.TabIndex = 66
        Me.lblEmpLeftDate.Text = "Date Left"
        '
        'lblEmpRepDate
        '
        Me.lblEmpRepDate.AutoSize = True
        Me.lblEmpRepDate.Location = New System.Drawing.Point(507, 40)
        Me.lblEmpRepDate.Name = "lblEmpRepDate"
        Me.lblEmpRepDate.Size = New System.Drawing.Size(88, 14)
        Me.lblEmpRepDate.TabIndex = 65
        Me.lblEmpRepDate.Text = "Reporting Date"
        '
        'lblEmpHireDate
        '
        Me.lblEmpHireDate.AutoSize = True
        Me.lblEmpHireDate.Location = New System.Drawing.Point(507, 15)
        Me.lblEmpHireDate.Name = "lblEmpHireDate"
        Me.lblEmpHireDate.Size = New System.Drawing.Size(66, 14)
        Me.lblEmpHireDate.TabIndex = 64
        Me.lblEmpHireDate.Text = "Date Hired"
        '
        'dtpEmpLD
        '
        Me.dtpEmpLD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmpLD.Location = New System.Drawing.Point(635, 59)
        Me.dtpEmpLD.Name = "dtpEmpLD"
        Me.dtpEmpLD.Size = New System.Drawing.Size(150, 22)
        Me.dtpEmpLD.TabIndex = 24
        Me.dtpEmpLD.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtpEmpRD
        '
        Me.dtpEmpRD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmpRD.Location = New System.Drawing.Point(635, 34)
        Me.dtpEmpRD.Name = "dtpEmpRD"
        Me.dtpEmpRD.Size = New System.Drawing.Size(150, 22)
        Me.dtpEmpRD.TabIndex = 23
        Me.dtpEmpRD.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtpEmpHD
        '
        Me.dtpEmpHD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmpHD.Location = New System.Drawing.Point(635, 9)
        Me.dtpEmpHD.Name = "dtpEmpHD"
        Me.dtpEmpHD.Size = New System.Drawing.Size(150, 22)
        Me.dtpEmpHD.TabIndex = 22
        Me.dtpEmpHD.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'cboEmpClass
        '
        Me.cboEmpClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpClass.FormattingEnabled = True
        Me.cboEmpClass.Items.AddRange(New Object() {"- Select a Payroll Basis -", "Daily", "Weekly", "Semi-Monthly", "Monthly"})
        Me.cboEmpClass.Location = New System.Drawing.Point(135, 37)
        Me.cboEmpClass.Name = "cboEmpClass"
        Me.cboEmpClass.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpClass.TabIndex = 16
        '
        'lblEmpClass
        '
        Me.lblEmpClass.AutoSize = True
        Me.lblEmpClass.Location = New System.Drawing.Point(7, 42)
        Me.lblEmpClass.Name = "lblEmpClass"
        Me.lblEmpClass.Size = New System.Drawing.Size(92, 14)
        Me.lblEmpClass.TabIndex = 59
        Me.lblEmpClass.Text = "Employee Class"
        '
        'txtEmpJP
        '
        Me.txtEmpJP.Location = New System.Drawing.Point(135, 237)
        Me.txtEmpJP.MaxLength = 150
        Me.txtEmpJP.Name = "txtEmpJP"
        Me.txtEmpJP.Size = New System.Drawing.Size(350, 22)
        Me.txtEmpJP.TabIndex = 21
        '
        'lblEmpJP
        '
        Me.lblEmpJP.AutoSize = True
        Me.lblEmpJP.Location = New System.Drawing.Point(7, 240)
        Me.lblEmpJP.Name = "lblEmpJP"
        Me.lblEmpJP.Size = New System.Drawing.Size(72, 14)
        Me.lblEmpJP.TabIndex = 57
        Me.lblEmpJP.Text = "Job Position"
        '
        'lblEmpSect
        '
        Me.lblEmpSect.AutoSize = True
        Me.lblEmpSect.Location = New System.Drawing.Point(7, 140)
        Me.lblEmpSect.Name = "lblEmpSect"
        Me.lblEmpSect.Size = New System.Drawing.Size(46, 14)
        Me.lblEmpSect.TabIndex = 55
        Me.lblEmpSect.Text = "Section"
        '
        'lblEmpDivi
        '
        Me.lblEmpDivi.AutoSize = True
        Me.lblEmpDivi.Location = New System.Drawing.Point(7, 115)
        Me.lblEmpDivi.Name = "lblEmpDivi"
        Me.lblEmpDivi.Size = New System.Drawing.Size(52, 14)
        Me.lblEmpDivi.TabIndex = 53
        Me.lblEmpDivi.Text = "Division"
        '
        'lblEmpDept
        '
        Me.lblEmpDept.AutoSize = True
        Me.lblEmpDept.Location = New System.Drawing.Point(7, 90)
        Me.lblEmpDept.Name = "lblEmpDept"
        Me.lblEmpDept.Size = New System.Drawing.Size(105, 14)
        Me.lblEmpDept.TabIndex = 51
        Me.lblEmpDept.Text = "Deparment/Client"
        '
        'cboEmpComp
        '
        Me.cboEmpComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpComp.FormattingEnabled = True
        Me.cboEmpComp.Location = New System.Drawing.Point(135, 12)
        Me.cboEmpComp.Name = "cboEmpComp"
        Me.cboEmpComp.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpComp.TabIndex = 15
        '
        'lblEmpComp
        '
        Me.lblEmpComp.AutoSize = True
        Me.lblEmpComp.Location = New System.Drawing.Point(7, 15)
        Me.lblEmpComp.Name = "lblEmpComp"
        Me.lblEmpComp.Size = New System.Drawing.Size(56, 14)
        Me.lblEmpComp.TabIndex = 49
        Me.lblEmpComp.Text = "Company"
        '
        'tpEPayInfo
        '
        Me.tpEPayInfo.AutoScroll = True
        Me.tpEPayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpEPayInfo.Controls.Add(Me.cboRateType)
        Me.tpEPayInfo.Controls.Add(Me.cboEmpPC)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpPC)
        Me.tpEPayInfo.Controls.Add(Me.chkHDMF)
        Me.tpEPayInfo.Controls.Add(Me.chkPH)
        Me.tpEPayInfo.Controls.Add(Me.chkSSS)
        Me.tpEPayInfo.Controls.Add(Me.cboEmpPR)
        Me.tpEPayInfo.Controls.Add(Me.lblPayRef)
        Me.tpEPayInfo.Controls.Add(Me.cboEmpEB)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpEcolaBase)
        Me.tpEPayInfo.Controls.Add(Me.txtEmpAN)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpAN)
        Me.tpEPayInfo.Controls.Add(Me.cboEmpPB)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpPB)
        Me.tpEPayInfo.Controls.Add(Me.chkEmpMW)
        Me.tpEPayInfo.Controls.Add(Me.txtEmpSR)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpSR)
        Me.tpEPayInfo.Controls.Add(Me.cboEmpPyB)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpPayBasis)
        Me.tpEPayInfo.Controls.Add(Me.cboEmpTxT)
        Me.tpEPayInfo.Controls.Add(Me.lblEmpTxType)
        Me.tpEPayInfo.Location = New System.Drawing.Point(4, 23)
        Me.tpEPayInfo.Name = "tpEPayInfo"
        Me.tpEPayInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEPayInfo.Size = New System.Drawing.Size(956, 278)
        Me.tpEPayInfo.TabIndex = 2
        Me.tpEPayInfo.Text = "Payroll Information"
        Me.tpEPayInfo.UseVisualStyleBackColor = True
        '
        'cboRateType
        '
        Me.cboRateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRateType.FormattingEnabled = True
        Me.cboRateType.Location = New System.Drawing.Point(261, 12)
        Me.cboRateType.Name = "cboRateType"
        Me.cboRateType.Size = New System.Drawing.Size(224, 22)
        Me.cboRateType.TabIndex = 75
        '
        'cboEmpPC
        '
        Me.cboEmpPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpPC.FormattingEnabled = True
        Me.cboEmpPC.Location = New System.Drawing.Point(641, 12)
        Me.cboEmpPC.Name = "cboEmpPC"
        Me.cboEmpPC.Size = New System.Drawing.Size(306, 22)
        Me.cboEmpPC.TabIndex = 35
        '
        'lblEmpPC
        '
        Me.lblEmpPC.AutoSize = True
        Me.lblEmpPC.Location = New System.Drawing.Point(513, 15)
        Me.lblEmpPC.Name = "lblEmpPC"
        Me.lblEmpPC.Size = New System.Drawing.Size(73, 14)
        Me.lblEmpPC.TabIndex = 74
        Me.lblEmpPC.Text = "Pay Channel"
        '
        'chkHDMF
        '
        Me.chkHDMF.AutoSize = True
        Me.chkHDMF.Location = New System.Drawing.Point(135, 214)
        Me.chkHDMF.Name = "chkHDMF"
        Me.chkHDMF.Size = New System.Drawing.Size(169, 18)
        Me.chkHDMF.TabIndex = 34
        Me.chkHDMF.Text = "Deduct HDMF Contribution"
        Me.chkHDMF.UseVisualStyleBackColor = True
        '
        'chkPH
        '
        Me.chkPH.AutoSize = True
        Me.chkPH.Location = New System.Drawing.Point(135, 190)
        Me.chkPH.Name = "chkPH"
        Me.chkPH.Size = New System.Drawing.Size(194, 18)
        Me.chkPH.TabIndex = 33
        Me.chkPH.Text = "Deduct Philhealth Contribution"
        Me.chkPH.UseVisualStyleBackColor = True
        '
        'chkSSS
        '
        Me.chkSSS.AutoSize = True
        Me.chkSSS.Location = New System.Drawing.Point(135, 166)
        Me.chkSSS.Name = "chkSSS"
        Me.chkSSS.Size = New System.Drawing.Size(155, 18)
        Me.chkSSS.TabIndex = 32
        Me.chkSSS.Text = "Deduct SSS Contribution"
        Me.chkSSS.UseVisualStyleBackColor = True
        '
        'cboEmpPR
        '
        Me.cboEmpPR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpPR.FormattingEnabled = True
        Me.cboEmpPR.Items.AddRange(New Object() {"- Select an exemption type -", "Z : Zero Exemption", "S : Single without qualified dependent", "S1 : Single with 1 qualified dependent", "S2 : Single with 2 qualified dependent", "S3 : Single with 3 qualified dependent", "S4 : Single with 4 qualified dependent", "ME : Married without qualified dependent", "M1 : Married with 1 qualified dependent", "M2 : Married with 2 qualified dependent", "M3 : Married with 3 qualified dependent", "M4 : Married with 4 qualified dependent"})
        Me.cboEmpPR.Location = New System.Drawing.Point(135, 63)
        Me.cboEmpPR.Name = "cboEmpPR"
        Me.cboEmpPR.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpPR.TabIndex = 28
        '
        'lblPayRef
        '
        Me.lblPayRef.AutoSize = True
        Me.lblPayRef.Location = New System.Drawing.Point(6, 66)
        Me.lblPayRef.Name = "lblPayRef"
        Me.lblPayRef.Size = New System.Drawing.Size(83, 14)
        Me.lblPayRef.TabIndex = 69
        Me.lblPayRef.Text = "Pay Reference"
        '
        'cboEmpEB
        '
        Me.cboEmpEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpEB.FormattingEnabled = True
        Me.cboEmpEB.Items.AddRange(New Object() {"- Select a basis for computation of dues -", "Base Salary", "Gross Salary"})
        Me.cboEmpEB.Location = New System.Drawing.Point(135, 138)
        Me.cboEmpEB.Name = "cboEmpEB"
        Me.cboEmpEB.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpEB.TabIndex = 31
        '
        'lblEmpEcolaBase
        '
        Me.lblEmpEcolaBase.AutoSize = True
        Me.lblEmpEcolaBase.Location = New System.Drawing.Point(7, 141)
        Me.lblEmpEcolaBase.Name = "lblEmpEcolaBase"
        Me.lblEmpEcolaBase.Size = New System.Drawing.Size(72, 14)
        Me.lblEmpEcolaBase.TabIndex = 67
        Me.lblEmpEcolaBase.Text = "ECOLA Basis"
        '
        'txtEmpAN
        '
        Me.txtEmpAN.Location = New System.Drawing.Point(641, 62)
        Me.txtEmpAN.MaxLength = 25
        Me.txtEmpAN.Name = "txtEmpAN"
        Me.txtEmpAN.Size = New System.Drawing.Size(150, 22)
        Me.txtEmpAN.TabIndex = 37
        '
        'lblEmpAN
        '
        Me.lblEmpAN.AutoSize = True
        Me.lblEmpAN.Location = New System.Drawing.Point(513, 65)
        Me.lblEmpAN.Name = "lblEmpAN"
        Me.lblEmpAN.Size = New System.Drawing.Size(95, 14)
        Me.lblEmpAN.TabIndex = 62
        Me.lblEmpAN.Text = "Account Number"
        '
        'cboEmpPB
        '
        Me.cboEmpPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpPB.FormattingEnabled = True
        Me.cboEmpPB.Location = New System.Drawing.Point(641, 37)
        Me.cboEmpPB.Name = "cboEmpPB"
        Me.cboEmpPB.Size = New System.Drawing.Size(306, 22)
        Me.cboEmpPB.TabIndex = 36
        '
        'lblEmpPB
        '
        Me.lblEmpPB.AutoSize = True
        Me.lblEmpPB.Location = New System.Drawing.Point(513, 40)
        Me.lblEmpPB.Name = "lblEmpPB"
        Me.lblEmpPB.Size = New System.Drawing.Size(74, 14)
        Me.lblEmpPB.TabIndex = 60
        Me.lblEmpPB.Text = "Payroll Bank"
        '
        'chkEmpMW
        '
        Me.chkEmpMW.AutoSize = True
        Me.chkEmpMW.Location = New System.Drawing.Point(135, 40)
        Me.chkEmpMW.Name = "chkEmpMW"
        Me.chkEmpMW.Size = New System.Drawing.Size(169, 18)
        Me.chkEmpMW.TabIndex = 27
        Me.chkEmpMW.Text = "Minimum-Wage Employee"
        Me.chkEmpMW.UseVisualStyleBackColor = True
        '
        'txtEmpSR
        '
        Me.txtEmpSR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpSR.Location = New System.Drawing.Point(135, 11)
        Me.txtEmpSR.MaxLength = 25
        Me.txtEmpSR.Name = "txtEmpSR"
        Me.txtEmpSR.Size = New System.Drawing.Size(120, 23)
        Me.txtEmpSR.TabIndex = 26
        Me.txtEmpSR.Text = "0.00"
        Me.txtEmpSR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmpSR
        '
        Me.lblEmpSR.AutoSize = True
        Me.lblEmpSR.Location = New System.Drawing.Point(7, 15)
        Me.lblEmpSR.Name = "lblEmpSR"
        Me.lblEmpSR.Size = New System.Drawing.Size(68, 14)
        Me.lblEmpSR.TabIndex = 50
        Me.lblEmpSR.Text = "Salary Rate"
        '
        'cboEmpPyB
        '
        Me.cboEmpPyB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpPyB.FormattingEnabled = True
        Me.cboEmpPyB.Items.AddRange(New Object() {"- Select a Payroll Basis -", "Daily", "Weekly", "Semi-Monthly", "Monthly"})
        Me.cboEmpPyB.Location = New System.Drawing.Point(135, 88)
        Me.cboEmpPyB.Name = "cboEmpPyB"
        Me.cboEmpPyB.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpPyB.TabIndex = 29
        '
        'lblEmpPayBasis
        '
        Me.lblEmpPayBasis.AutoSize = True
        Me.lblEmpPayBasis.Location = New System.Drawing.Point(6, 91)
        Me.lblEmpPayBasis.Name = "lblEmpPayBasis"
        Me.lblEmpPayBasis.Size = New System.Drawing.Size(82, 14)
        Me.lblEmpPayBasis.TabIndex = 48
        Me.lblEmpPayBasis.Text = "Payroll Period"
        '
        'cboEmpTxT
        '
        Me.cboEmpTxT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpTxT.FormattingEnabled = True
        Me.cboEmpTxT.Items.AddRange(New Object() {"- Select an exemption type -", "Z : Zero Exemption", "S : Single without qualified dependent", "S1 : Single with 1 qualified dependent", "S2 : Single with 2 qualified dependent", "S3 : Single with 3 qualified dependent", "S4 : Single with 4 qualified dependent", "ME : Married without qualified dependent", "M1 : Married with 1 qualified dependent", "M2 : Married with 2 qualified dependent", "M3 : Married with 3 qualified dependent", "M4 : Married with 4 qualified dependent"})
        Me.cboEmpTxT.Location = New System.Drawing.Point(135, 113)
        Me.cboEmpTxT.Name = "cboEmpTxT"
        Me.cboEmpTxT.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpTxT.TabIndex = 30
        '
        'lblEmpTxType
        '
        Me.lblEmpTxType.AutoSize = True
        Me.lblEmpTxType.Location = New System.Drawing.Point(7, 116)
        Me.lblEmpTxType.Name = "lblEmpTxType"
        Me.lblEmpTxType.Size = New System.Drawing.Size(93, 14)
        Me.lblEmpTxType.TabIndex = 46
        Me.lblEmpTxType.Text = "Tax Exempt Type"
        '
        'pnlBottomControl
        '
        Me.pnlBottomControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottomControl.Controls.Add(Me.pnlPStat)
        Me.pnlBottomControl.Controls.Add(Me.pnlImport)
        Me.pnlBottomControl.Controls.Add(Me.pnlBottomRight)
        Me.pnlBottomControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBottomControl.Location = New System.Drawing.Point(0, 305)
        Me.pnlBottomControl.Name = "pnlBottomControl"
        Me.pnlBottomControl.Size = New System.Drawing.Size(964, 34)
        Me.pnlBottomControl.TabIndex = 5
        '
        'pnlPStat
        '
        Me.pnlPStat.Controls.Add(Me.lblPStat)
        Me.pnlPStat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPStat.Location = New System.Drawing.Point(278, 0)
        Me.pnlPStat.Name = "pnlPStat"
        Me.pnlPStat.Size = New System.Drawing.Size(494, 32)
        Me.pnlPStat.TabIndex = 43
        '
        'lblPStat
        '
        Me.lblPStat.AutoSize = True
        Me.lblPStat.Location = New System.Drawing.Point(6, 9)
        Me.lblPStat.Name = "lblPStat"
        Me.lblPStat.Size = New System.Drawing.Size(142, 14)
        Me.lblPStat.TabIndex = 0
        Me.lblPStat.Text = "Awaiting file to process..."
        '
        'pnlImport
        '
        Me.pnlImport.Controls.Add(Me.btnImport)
        Me.pnlImport.Controls.Add(Me.btnGenerate)
        Me.pnlImport.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlImport.Location = New System.Drawing.Point(0, 0)
        Me.pnlImport.Name = "pnlImport"
        Me.pnlImport.Size = New System.Drawing.Size(278, 32)
        Me.pnlImport.TabIndex = 42
        '
        'btnImport
        '
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(3, 1)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(129, 30)
        Me.btnImport.TabIndex = 40
        Me.btnImport.Text = "Import Masterlist"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(135, 1)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(139, 30)
        Me.btnGenerate.TabIndex = 41
        Me.btnGenerate.Text = "Generate Template"
        Me.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'pnlBottomRight
        '
        Me.pnlBottomRight.Controls.Add(Me.btnSave)
        Me.pnlBottomRight.Controls.Add(Me.btnCancel)
        Me.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBottomRight.Location = New System.Drawing.Point(772, 0)
        Me.pnlBottomRight.Name = "pnlBottomRight"
        Me.pnlBottomRight.Size = New System.Drawing.Size(190, 32)
        Me.pnlBottomRight.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(3, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 30)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(96, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlEMS
        '
        Me.pnlEMS.Controls.Add(Me.dgvEMS)
        Me.pnlEMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEMS.Location = New System.Drawing.Point(0, 339)
        Me.pnlEMS.Name = "pnlEMS"
        Me.pnlEMS.Size = New System.Drawing.Size(964, 172)
        Me.pnlEMS.TabIndex = 6
        '
        'dgvEMS
        '
        Me.dgvEMS.AllowUserToAddRows = False
        Me.dgvEMS.AllowUserToDeleteRows = False
        Me.dgvEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmpSel, Me.colEmpDel})
        Me.dgvEMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEMS.Location = New System.Drawing.Point(0, 0)
        Me.dgvEMS.Name = "dgvEMS"
        Me.dgvEMS.ReadOnly = True
        Me.dgvEMS.Size = New System.Drawing.Size(964, 172)
        Me.dgvEMS.TabIndex = 2
        '
        'colEmpSel
        '
        Me.colEmpSel.Frozen = True
        Me.colEmpSel.HeaderText = ""
        Me.colEmpSel.Name = "colEmpSel"
        Me.colEmpSel.ReadOnly = True
        Me.colEmpSel.Text = "Select"
        Me.colEmpSel.UseColumnTextForButtonValue = True
        Me.colEmpSel.Width = 60
        '
        'colEmpDel
        '
        Me.colEmpDel.Frozen = True
        Me.colEmpDel.HeaderText = ""
        Me.colEmpDel.Name = "colEmpDel"
        Me.colEmpDel.ReadOnly = True
        Me.colEmpDel.Text = "Delete"
        Me.colEmpDel.UseColumnTextForButtonValue = True
        Me.colEmpDel.Width = 60
        '
        'ofdEmpImg
        '
        Me.ofdEmpImg.FileName = "Image"
        Me.ofdEmpImg.Filter = "Image files | *.BMP;*.GIF;*.TIF;*.TIFF;*.PNG"
        '
        'ofdImportFile
        '
        Me.ofdImportFile.FileName = "Employee Template"
        Me.ofdImportFile.Filter = "Employee Data File (*.xls, *.xlsx)|*.xls;*.xlsx"
        '
        'cboEmpLoc
        '
        Me.cboEmpLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpLoc.FormattingEnabled = True
        Me.cboEmpLoc.Location = New System.Drawing.Point(135, 212)
        Me.cboEmpLoc.Name = "cboEmpLoc"
        Me.cboEmpLoc.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpLoc.TabIndex = 74
        '
        'lblEmpLoc
        '
        Me.lblEmpLoc.AutoSize = True
        Me.lblEmpLoc.Location = New System.Drawing.Point(7, 215)
        Me.lblEmpLoc.Name = "lblEmpLoc"
        Me.lblEmpLoc.Size = New System.Drawing.Size(95, 14)
        Me.lblEmpLoc.TabIndex = 75
        Me.lblEmpLoc.Text = "Location/Station"
        '
        'cboEmpLC
        '
        Me.cboEmpLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpLC.FormattingEnabled = True
        Me.cboEmpLC.Location = New System.Drawing.Point(135, 187)
        Me.cboEmpLC.Name = "cboEmpLC"
        Me.cboEmpLC.Size = New System.Drawing.Size(350, 22)
        Me.cboEmpLC.TabIndex = 72
        '
        'lblEmpLC
        '
        Me.lblEmpLC.AutoSize = True
        Me.lblEmpLC.Location = New System.Drawing.Point(7, 190)
        Me.lblEmpLC.Name = "lblEmpLC"
        Me.lblEmpLC.Size = New System.Drawing.Size(112, 14)
        Me.lblEmpLC.TabIndex = 73
        Me.lblEmpLC.Text = "Labor Classification"
        '
        'frmEmployeeMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 511)
        Me.Controls.Add(Me.pnlEMS)
        Me.Controls.Add(Me.pnlBottomControl)
        Me.Controls.Add(Me.tcEmpInfo)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcEmpInfo.ResumeLayout(False)
        Me.tpEmpInfo.ResumeLayout(False)
        Me.tpEmpInfo.PerformLayout()
        Me.pnlEmpImg.ResumeLayout(False)
        CType(Me.picEmpImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEEmpInfo.ResumeLayout(False)
        Me.tpEEmpInfo.PerformLayout()
        Me.tpEPayInfo.ResumeLayout(False)
        Me.tpEPayInfo.PerformLayout()
        Me.pnlBottomControl.ResumeLayout(False)
        Me.pnlPStat.ResumeLayout(False)
        Me.pnlPStat.PerformLayout()
        Me.pnlImport.ResumeLayout(False)
        Me.pnlBottomRight.ResumeLayout(False)
        Me.pnlEMS.ResumeLayout(False)
        CType(Me.dgvEMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tcEmpInfo As System.Windows.Forms.TabControl
    Private WithEvents tpEmpInfo As System.Windows.Forms.TabPage
    Private WithEvents txtEmpBioId As System.Windows.Forms.TextBox
    Private WithEvents lblEmpBioId As System.Windows.Forms.Label
    Private WithEvents txtEmpPHNo As System.Windows.Forms.TextBox
    Private WithEvents lblEmpPHNo As System.Windows.Forms.Label
    Private WithEvents txtEmpHNo As System.Windows.Forms.TextBox
    Private WithEvents lblEmpHNo As System.Windows.Forms.Label
    Private WithEvents txtEmpSNo As System.Windows.Forms.TextBox
    Private WithEvents lblEmpSNo As System.Windows.Forms.Label
    Private WithEvents cboCStatus As System.Windows.Forms.ComboBox
    Private WithEvents lblCStatus As System.Windows.Forms.Label
    Private WithEvents dtpBDate As System.Windows.Forms.DateTimePicker
    Private WithEvents lblBDate As System.Windows.Forms.Label
    Private WithEvents cboGender As System.Windows.Forms.ComboBox
    Private WithEvents lblGender As System.Windows.Forms.Label
    Private WithEvents txtSuffix As System.Windows.Forms.TextBox
    Private WithEvents lblSuffix As System.Windows.Forms.Label
    Private WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Private WithEvents lblMiddleName As System.Windows.Forms.Label
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents lblFirstName As System.Windows.Forms.Label
    Private WithEvents txtLastName As System.Windows.Forms.TextBox
    Private WithEvents lblLastName As System.Windows.Forms.Label
    Private WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Private WithEvents lblEmpNo As System.Windows.Forms.Label
    Private WithEvents tpEEmpInfo As System.Windows.Forms.TabPage
    Private WithEvents cboEmpSect As System.Windows.Forms.ComboBox
    Private WithEvents cboEmpDivi As System.Windows.Forms.ComboBox
    Private WithEvents cboEmpDept As System.Windows.Forms.ComboBox
    Private WithEvents cboEmpLR As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpLeftReason As System.Windows.Forms.Label
    Private WithEvents lblEmpLeftDate As System.Windows.Forms.Label
    Private WithEvents lblEmpRepDate As System.Windows.Forms.Label
    Private WithEvents lblEmpHireDate As System.Windows.Forms.Label
    Private WithEvents dtpEmpLD As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpEmpRD As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpEmpHD As System.Windows.Forms.DateTimePicker
    Private WithEvents cboEmpClass As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpClass As System.Windows.Forms.Label
    Private WithEvents txtEmpJP As System.Windows.Forms.TextBox
    Private WithEvents lblEmpJP As System.Windows.Forms.Label
    Private WithEvents lblEmpSect As System.Windows.Forms.Label
    Private WithEvents lblEmpDivi As System.Windows.Forms.Label
    Private WithEvents lblEmpDept As System.Windows.Forms.Label
    Private WithEvents cboEmpComp As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpComp As System.Windows.Forms.Label
    Private WithEvents tpEPayInfo As System.Windows.Forms.TabPage
    Private WithEvents cboEmpEB As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpEcolaBase As System.Windows.Forms.Label
    Private WithEvents txtEmpAN As System.Windows.Forms.TextBox
    Private WithEvents lblEmpAN As System.Windows.Forms.Label
    Private WithEvents cboEmpPB As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpPB As System.Windows.Forms.Label
    Private WithEvents chkEmpMW As System.Windows.Forms.CheckBox
    Private WithEvents txtEmpSR As System.Windows.Forms.TextBox
    Private WithEvents lblEmpSR As System.Windows.Forms.Label
    Private WithEvents cboEmpPyB As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpPayBasis As System.Windows.Forms.Label
    Private WithEvents cboEmpTxT As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpTxType As System.Windows.Forms.Label
    Friend WithEvents pnlEmpImg As System.Windows.Forms.Panel
    Friend WithEvents picEmpImg As System.Windows.Forms.PictureBox
    Friend WithEvents pnlBottomControl As System.Windows.Forms.Panel
    Friend WithEvents pnlBottomRight As System.Windows.Forms.Panel
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents pnlEMS As System.Windows.Forms.Panel
    Friend WithEvents dgvEMS As System.Windows.Forms.DataGridView
    Friend WithEvents colEmpSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colEmpDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnSelImg As System.Windows.Forms.Button
    Private WithEvents cboEmpPR As System.Windows.Forms.ComboBox
    Private WithEvents lblPayRef As System.Windows.Forms.Label
    Friend WithEvents ofdEmpImg As System.Windows.Forms.OpenFileDialog
    Private WithEvents txtTin As System.Windows.Forms.TextBox
    Private WithEvents lblTin As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents cboEmpGroup As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpGroup As System.Windows.Forms.Label
    Private WithEvents cboEmpPC As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpPC As System.Windows.Forms.Label
    Private WithEvents chkHDMF As System.Windows.Forms.CheckBox
    Private WithEvents chkPH As System.Windows.Forms.CheckBox
    Private WithEvents chkSSS As System.Windows.Forms.CheckBox
    Private WithEvents txtEmpOCN As System.Windows.Forms.TextBox
    Private WithEvents lblEmpOCN As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents ofdImportFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlPStat As System.Windows.Forms.Panel
    Friend WithEvents lblPStat As System.Windows.Forms.Label
    Friend WithEvents pnlImport As System.Windows.Forms.Panel
    Friend WithEvents cboRateType As System.Windows.Forms.ComboBox
    Private WithEvents cboEmpCC As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpCC As System.Windows.Forms.Label
    Private WithEvents cboEmpLoc As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpLoc As System.Windows.Forms.Label
    Private WithEvents cboEmpLC As System.Windows.Forms.ComboBox
    Private WithEvents lblEmpLC As System.Windows.Forms.Label
End Class
