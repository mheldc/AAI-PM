<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessPayroll))
        Me.tcProcDTR = New System.Windows.Forms.TabControl()
        Me.tpDTRImport = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tcDTRFile = New System.Windows.Forms.TabControl()
        Me.tpCDTR = New System.Windows.Forms.TabPage()
        Me.dgvCDTR = New System.Windows.Forms.DataGridView()
        Me.tpCAdj = New System.Windows.Forms.TabPage()
        Me.dgvCAdj = New System.Windows.Forms.DataGridView()
        Me.pnlDTRProc = New System.Windows.Forms.Panel()
        Me.lnkSelDTRFile = New System.Windows.Forms.LinkLabel()
        Me.btnGenTemplate = New System.Windows.Forms.Button()
        Me.lblCTFL = New System.Windows.Forms.Label()
        Me.txtCTFL = New System.Windows.Forms.TextBox()
        Me.lblCPD = New System.Windows.Forms.Label()
        Me.lblCPCSE = New System.Windows.Forms.Label()
        Me.lblCPMY = New System.Windows.Forms.Label()
        Me.txtCPM = New System.Windows.Forms.TextBox()
        Me.txtCPD = New System.Windows.Forms.TextBox()
        Me.txtCPCE = New System.Windows.Forms.TextBox()
        Me.txtCPCS = New System.Windows.Forms.TextBox()
        Me.txtCPY = New System.Windows.Forms.TextBox()
        Me.lblCDFT = New System.Windows.Forms.Label()
        Me.lblCDFH = New System.Windows.Forms.Label()
        Me.btnProcDTR = New System.Windows.Forms.Button()
        Me.btnCCancel = New System.Windows.Forms.Button()
        Me.txtSelDTRFile = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tcHDTR = New System.Windows.Forms.TabControl()
        Me.tpHDTR = New System.Windows.Forms.TabPage()
        Me.dgvHDTR = New System.Windows.Forms.DataGridView()
        Me.tpHDTRR = New System.Windows.Forms.TabPage()
        Me.dgvHDTRR = New System.Windows.Forms.DataGridView()
        Me.tpHPayout = New System.Windows.Forms.TabPage()
        Me.dgvPayout = New System.Windows.Forms.DataGridView()
        Me.pnlHDTR = New System.Windows.Forms.Panel()
        Me.btnPostPayroll = New System.Windows.Forms.Button()
        Me.cboLProcFiles = New System.Windows.Forms.ComboBox()
        Me.lblHTPL = New System.Windows.Forms.Label()
        Me.txtHTPL = New System.Windows.Forms.TextBox()
        Me.lblHPD = New System.Windows.Forms.Label()
        Me.lblHPCSE = New System.Windows.Forms.Label()
        Me.lblHPMY = New System.Windows.Forms.Label()
        Me.txtHPY = New System.Windows.Forms.TextBox()
        Me.txtHPD = New System.Windows.Forms.TextBox()
        Me.txtHPCE = New System.Windows.Forms.TextBox()
        Me.txtHPCS = New System.Windows.Forms.TextBox()
        Me.txtHPM = New System.Windows.Forms.TextBox()
        Me.lblHDFT = New System.Windows.Forms.Label()
        Me.lblHDFH = New System.Windows.Forms.Label()
        Me.lblHProcFiles = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProcStat = New System.Windows.Forms.Label()
        Me.lblPProcessed = New System.Windows.Forms.Label()
        Me.lblPSuccess = New System.Windows.Forms.Label()
        Me.lblPFail = New System.Windows.Forms.Label()
        Me.ofdDTR = New System.Windows.Forms.OpenFileDialog()
        Me.sfdDTR = New System.Windows.Forms.SaveFileDialog()
        Me.lblTALines = New System.Windows.Forms.Label()
        Me.txtTALines = New System.Windows.Forms.TextBox()
        Me.tcProcDTR.SuspendLayout()
        Me.tpDTRImport.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tcDTRFile.SuspendLayout()
        Me.tpCDTR.SuspendLayout()
        CType(Me.dgvCDTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCAdj.SuspendLayout()
        CType(Me.dgvCAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDTRProc.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.tcHDTR.SuspendLayout()
        Me.tpHDTR.SuspendLayout()
        CType(Me.dgvHDTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHDTRR.SuspendLayout()
        CType(Me.dgvHDTRR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHPayout.SuspendLayout()
        CType(Me.dgvPayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHDTR.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcProcDTR
        '
        Me.tcProcDTR.Controls.Add(Me.tpDTRImport)
        Me.tcProcDTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcProcDTR.Location = New System.Drawing.Point(0, 0)
        Me.tcProcDTR.Name = "tcProcDTR"
        Me.tcProcDTR.SelectedIndex = 0
        Me.tcProcDTR.Size = New System.Drawing.Size(1316, 540)
        Me.tcProcDTR.TabIndex = 2
        '
        'tpDTRImport
        '
        Me.tpDTRImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpDTRImport.Controls.Add(Me.TabControl1)
        Me.tpDTRImport.Controls.Add(Me.Panel1)
        Me.tpDTRImport.Location = New System.Drawing.Point(4, 23)
        Me.tpDTRImport.Name = "tpDTRImport"
        Me.tpDTRImport.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDTRImport.Size = New System.Drawing.Size(1308, 513)
        Me.tpDTRImport.TabIndex = 1
        Me.tpDTRImport.Text = "DTR and Payroll Processing"
        Me.tpDTRImport.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1300, 480)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.tcDTRFile)
        Me.TabPage1.Controls.Add(Me.pnlDTRProc)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1292, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DTR Uploading and Processing"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tcDTRFile
        '
        Me.tcDTRFile.Controls.Add(Me.tpCDTR)
        Me.tcDTRFile.Controls.Add(Me.tpCAdj)
        Me.tcDTRFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcDTRFile.Location = New System.Drawing.Point(3, 140)
        Me.tcDTRFile.Name = "tcDTRFile"
        Me.tcDTRFile.SelectedIndex = 0
        Me.tcDTRFile.Size = New System.Drawing.Size(1284, 308)
        Me.tcDTRFile.TabIndex = 1
        '
        'tpCDTR
        '
        Me.tpCDTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpCDTR.Controls.Add(Me.dgvCDTR)
        Me.tpCDTR.Location = New System.Drawing.Point(4, 23)
        Me.tpCDTR.Name = "tpCDTR"
        Me.tpCDTR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCDTR.Size = New System.Drawing.Size(1276, 281)
        Me.tpCDTR.TabIndex = 0
        Me.tpCDTR.Text = "DTR Summary"
        Me.tpCDTR.UseVisualStyleBackColor = True
        '
        'dgvCDTR
        '
        Me.dgvCDTR.AllowUserToAddRows = False
        Me.dgvCDTR.AllowUserToDeleteRows = False
        Me.dgvCDTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCDTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCDTR.Location = New System.Drawing.Point(3, 3)
        Me.dgvCDTR.Name = "dgvCDTR"
        Me.dgvCDTR.ReadOnly = True
        Me.dgvCDTR.Size = New System.Drawing.Size(1268, 273)
        Me.dgvCDTR.TabIndex = 0
        '
        'tpCAdj
        '
        Me.tpCAdj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpCAdj.Controls.Add(Me.dgvCAdj)
        Me.tpCAdj.Location = New System.Drawing.Point(4, 23)
        Me.tpCAdj.Name = "tpCAdj"
        Me.tpCAdj.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCAdj.Size = New System.Drawing.Size(1276, 282)
        Me.tpCAdj.TabIndex = 1
        Me.tpCAdj.Text = "Adjustment Summary"
        Me.tpCAdj.UseVisualStyleBackColor = True
        '
        'dgvCAdj
        '
        Me.dgvCAdj.AllowUserToAddRows = False
        Me.dgvCAdj.AllowUserToDeleteRows = False
        Me.dgvCAdj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCAdj.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCAdj.Location = New System.Drawing.Point(3, 3)
        Me.dgvCAdj.Name = "dgvCAdj"
        Me.dgvCAdj.ReadOnly = True
        Me.dgvCAdj.Size = New System.Drawing.Size(1268, 274)
        Me.dgvCAdj.TabIndex = 1
        '
        'pnlDTRProc
        '
        Me.pnlDTRProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDTRProc.Controls.Add(Me.lblTALines)
        Me.pnlDTRProc.Controls.Add(Me.txtTALines)
        Me.pnlDTRProc.Controls.Add(Me.lnkSelDTRFile)
        Me.pnlDTRProc.Controls.Add(Me.btnGenTemplate)
        Me.pnlDTRProc.Controls.Add(Me.lblCTFL)
        Me.pnlDTRProc.Controls.Add(Me.txtCTFL)
        Me.pnlDTRProc.Controls.Add(Me.lblCPD)
        Me.pnlDTRProc.Controls.Add(Me.lblCPCSE)
        Me.pnlDTRProc.Controls.Add(Me.lblCPMY)
        Me.pnlDTRProc.Controls.Add(Me.txtCPM)
        Me.pnlDTRProc.Controls.Add(Me.txtCPD)
        Me.pnlDTRProc.Controls.Add(Me.txtCPCE)
        Me.pnlDTRProc.Controls.Add(Me.txtCPCS)
        Me.pnlDTRProc.Controls.Add(Me.txtCPY)
        Me.pnlDTRProc.Controls.Add(Me.lblCDFT)
        Me.pnlDTRProc.Controls.Add(Me.lblCDFH)
        Me.pnlDTRProc.Controls.Add(Me.btnProcDTR)
        Me.pnlDTRProc.Controls.Add(Me.btnCCancel)
        Me.pnlDTRProc.Controls.Add(Me.txtSelDTRFile)
        Me.pnlDTRProc.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDTRProc.Location = New System.Drawing.Point(3, 3)
        Me.pnlDTRProc.Name = "pnlDTRProc"
        Me.pnlDTRProc.Size = New System.Drawing.Size(1284, 137)
        Me.pnlDTRProc.TabIndex = 0
        '
        'lnkSelDTRFile
        '
        Me.lnkSelDTRFile.AutoSize = True
        Me.lnkSelDTRFile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lnkSelDTRFile.Location = New System.Drawing.Point(7, 15)
        Me.lnkSelDTRFile.Name = "lnkSelDTRFile"
        Me.lnkSelDTRFile.Size = New System.Drawing.Size(146, 14)
        Me.lnkSelDTRFile.TabIndex = 22
        Me.lnkSelDTRFile.TabStop = True
        Me.lnkSelDTRFile.Text = "Select DTR File to Process"
        '
        'btnGenTemplate
        '
        Me.btnGenTemplate.Image = CType(resources.GetObject("btnGenTemplate.Image"), System.Drawing.Image)
        Me.btnGenTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenTemplate.Location = New System.Drawing.Point(245, 89)
        Me.btnGenTemplate.Name = "btnGenTemplate"
        Me.btnGenTemplate.Size = New System.Drawing.Size(163, 30)
        Me.btnGenTemplate.TabIndex = 21
        Me.btnGenTemplate.Text = "Generate DTR Template"
        Me.btnGenTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenTemplate.UseVisualStyleBackColor = True
        '
        'lblCTFL
        '
        Me.lblCTFL.AutoSize = True
        Me.lblCTFL.Location = New System.Drawing.Point(774, 48)
        Me.lblCTFL.Name = "lblCTFL"
        Me.lblCTFL.Size = New System.Drawing.Size(148, 14)
        Me.lblCTFL.TabIndex = 20
        Me.lblCTFL.Text = "DTR Total Processed Lines"
        '
        'txtCTFL
        '
        Me.txtCTFL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTFL.Location = New System.Drawing.Point(928, 44)
        Me.txtCTFL.MaxLength = 7
        Me.txtCTFL.Name = "txtCTFL"
        Me.txtCTFL.ReadOnly = True
        Me.txtCTFL.Size = New System.Drawing.Size(80, 23)
        Me.txtCTFL.TabIndex = 19
        Me.txtCTFL.Text = "0"
        Me.txtCTFL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCPD
        '
        Me.lblCPD.AutoSize = True
        Me.lblCPD.Location = New System.Drawing.Point(457, 100)
        Me.lblCPD.Name = "lblCPD"
        Me.lblCPD.Size = New System.Drawing.Size(73, 14)
        Me.lblCPD.TabIndex = 18
        Me.lblCPD.Text = "Payroll Date"
        '
        'lblCPCSE
        '
        Me.lblCPCSE.AutoSize = True
        Me.lblCPCSE.Location = New System.Drawing.Point(457, 74)
        Me.lblCPCSE.Name = "lblCPCSE"
        Me.lblCPCSE.Size = New System.Drawing.Size(137, 14)
        Me.lblCPCSE.TabIndex = 17
        Me.lblCPCSE.Text = "Payroll Cutoff Start / End"
        '
        'lblCPMY
        '
        Me.lblCPMY.AutoSize = True
        Me.lblCPMY.Location = New System.Drawing.Point(457, 48)
        Me.lblCPMY.Name = "lblCPMY"
        Me.lblCPMY.Size = New System.Drawing.Size(110, 14)
        Me.lblCPMY.TabIndex = 16
        Me.lblCPMY.Text = "Payroll Month/Year"
        '
        'txtCPM
        '
        Me.txtCPM.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPM.Location = New System.Drawing.Point(656, 44)
        Me.txtCPM.MaxLength = 5
        Me.txtCPM.Name = "txtCPM"
        Me.txtCPM.ReadOnly = True
        Me.txtCPM.Size = New System.Drawing.Size(50, 23)
        Me.txtCPM.TabIndex = 15
        Me.txtCPM.Text = "1900"
        Me.txtCPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCPD
        '
        Me.txtCPD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPD.Location = New System.Drawing.Point(600, 96)
        Me.txtCPD.MaxLength = 3
        Me.txtCPD.Name = "txtCPD"
        Me.txtCPD.ReadOnly = True
        Me.txtCPD.Size = New System.Drawing.Size(50, 23)
        Me.txtCPD.TabIndex = 14
        Me.txtCPD.Text = "1"
        Me.txtCPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCPCE
        '
        Me.txtCPCE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPCE.Location = New System.Drawing.Point(656, 70)
        Me.txtCPCE.MaxLength = 3
        Me.txtCPCE.Name = "txtCPCE"
        Me.txtCPCE.ReadOnly = True
        Me.txtCPCE.Size = New System.Drawing.Size(50, 23)
        Me.txtCPCE.TabIndex = 13
        Me.txtCPCE.Text = "31"
        Me.txtCPCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCPCS
        '
        Me.txtCPCS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPCS.Location = New System.Drawing.Point(600, 70)
        Me.txtCPCS.MaxLength = 3
        Me.txtCPCS.Name = "txtCPCS"
        Me.txtCPCS.ReadOnly = True
        Me.txtCPCS.Size = New System.Drawing.Size(50, 23)
        Me.txtCPCS.TabIndex = 12
        Me.txtCPCS.Text = "1"
        Me.txtCPCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCPY
        '
        Me.txtCPY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPY.Location = New System.Drawing.Point(600, 44)
        Me.txtCPY.MaxLength = 3
        Me.txtCPY.Name = "txtCPY"
        Me.txtCPY.ReadOnly = True
        Me.txtCPY.Size = New System.Drawing.Size(50, 23)
        Me.txtCPY.TabIndex = 11
        Me.txtCPY.Text = "1"
        Me.txtCPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCDFT
        '
        Me.lblCDFT.AutoSize = True
        Me.lblCDFT.Location = New System.Drawing.Point(774, 15)
        Me.lblCDFT.Name = "lblCDFT"
        Me.lblCDFT.Size = New System.Drawing.Size(174, 14)
        Me.lblCDFT.TabIndex = 10
        Me.lblCDFT.Text = "DTR and Adjustments File Trail"
        '
        'lblCDFH
        '
        Me.lblCDFH.AutoSize = True
        Me.lblCDFH.Location = New System.Drawing.Point(457, 15)
        Me.lblCDFH.Name = "lblCDFH"
        Me.lblCDFH.Size = New System.Drawing.Size(95, 14)
        Me.lblCDFH.TabIndex = 9
        Me.lblCDFH.Text = "DTR File Header"
        '
        'btnProcDTR
        '
        Me.btnProcDTR.Image = CType(resources.GetObject("btnProcDTR.Image"), System.Drawing.Image)
        Me.btnProcDTR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcDTR.Location = New System.Drawing.Point(10, 89)
        Me.btnProcDTR.Name = "btnProcDTR"
        Me.btnProcDTR.Size = New System.Drawing.Size(100, 30)
        Me.btnProcDTR.TabIndex = 8
        Me.btnProcDTR.Text = "Process File"
        Me.btnProcDTR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcDTR.UseVisualStyleBackColor = True
        '
        'btnCCancel
        '
        Me.btnCCancel.Image = CType(resources.GetObject("btnCCancel.Image"), System.Drawing.Image)
        Me.btnCCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCCancel.Location = New System.Drawing.Point(113, 89)
        Me.btnCCancel.Name = "btnCCancel"
        Me.btnCCancel.Size = New System.Drawing.Size(69, 30)
        Me.btnCCancel.TabIndex = 7
        Me.btnCCancel.Text = "Cancel"
        Me.btnCCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCCancel.UseVisualStyleBackColor = True
        '
        'txtSelDTRFile
        '
        Me.txtSelDTRFile.Location = New System.Drawing.Point(10, 32)
        Me.txtSelDTRFile.Multiline = True
        Me.txtSelDTRFile.Name = "txtSelDTRFile"
        Me.txtSelDTRFile.ReadOnly = True
        Me.txtSelDTRFile.Size = New System.Drawing.Size(398, 51)
        Me.txtSelDTRFile.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.tcHDTR)
        Me.TabPage4.Controls.Add(Me.pnlHDTR)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1292, 453)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Payroll Processing"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tcHDTR
        '
        Me.tcHDTR.Controls.Add(Me.tpHDTR)
        Me.tcHDTR.Controls.Add(Me.tpHDTRR)
        Me.tcHDTR.Controls.Add(Me.tpHPayout)
        Me.tcHDTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcHDTR.Location = New System.Drawing.Point(3, 140)
        Me.tcHDTR.Name = "tcHDTR"
        Me.tcHDTR.SelectedIndex = 0
        Me.tcHDTR.Size = New System.Drawing.Size(1284, 308)
        Me.tcHDTR.TabIndex = 2
        '
        'tpHDTR
        '
        Me.tpHDTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpHDTR.Controls.Add(Me.dgvHDTR)
        Me.tpHDTR.Location = New System.Drawing.Point(4, 23)
        Me.tpHDTR.Name = "tpHDTR"
        Me.tpHDTR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHDTR.Size = New System.Drawing.Size(1276, 281)
        Me.tpHDTR.TabIndex = 0
        Me.tpHDTR.Text = "DTR Summary"
        Me.tpHDTR.UseVisualStyleBackColor = True
        '
        'dgvHDTR
        '
        Me.dgvHDTR.AllowUserToAddRows = False
        Me.dgvHDTR.AllowUserToDeleteRows = False
        Me.dgvHDTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHDTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHDTR.Location = New System.Drawing.Point(3, 3)
        Me.dgvHDTR.Name = "dgvHDTR"
        Me.dgvHDTR.ReadOnly = True
        Me.dgvHDTR.Size = New System.Drawing.Size(1268, 273)
        Me.dgvHDTR.TabIndex = 0
        '
        'tpHDTRR
        '
        Me.tpHDTRR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpHDTRR.Controls.Add(Me.dgvHDTRR)
        Me.tpHDTRR.Location = New System.Drawing.Point(4, 23)
        Me.tpHDTRR.Name = "tpHDTRR"
        Me.tpHDTRR.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHDTRR.Size = New System.Drawing.Size(1276, 282)
        Me.tpHDTRR.TabIndex = 1
        Me.tpHDTRR.Text = "DTR-Rates Summary"
        Me.tpHDTRR.UseVisualStyleBackColor = True
        '
        'dgvHDTRR
        '
        Me.dgvHDTRR.AllowUserToAddRows = False
        Me.dgvHDTRR.AllowUserToDeleteRows = False
        Me.dgvHDTRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHDTRR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHDTRR.Location = New System.Drawing.Point(3, 3)
        Me.dgvHDTRR.Name = "dgvHDTRR"
        Me.dgvHDTRR.ReadOnly = True
        Me.dgvHDTRR.Size = New System.Drawing.Size(1268, 274)
        Me.dgvHDTRR.TabIndex = 1
        '
        'tpHPayout
        '
        Me.tpHPayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpHPayout.Controls.Add(Me.dgvPayout)
        Me.tpHPayout.Location = New System.Drawing.Point(4, 23)
        Me.tpHPayout.Name = "tpHPayout"
        Me.tpHPayout.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHPayout.Size = New System.Drawing.Size(1276, 282)
        Me.tpHPayout.TabIndex = 2
        Me.tpHPayout.Text = "Pay-Out Summary"
        Me.tpHPayout.UseVisualStyleBackColor = True
        '
        'dgvPayout
        '
        Me.dgvPayout.AllowUserToAddRows = False
        Me.dgvPayout.AllowUserToDeleteRows = False
        Me.dgvPayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPayout.Location = New System.Drawing.Point(3, 3)
        Me.dgvPayout.Name = "dgvPayout"
        Me.dgvPayout.ReadOnly = True
        Me.dgvPayout.Size = New System.Drawing.Size(1268, 274)
        Me.dgvPayout.TabIndex = 2
        '
        'pnlHDTR
        '
        Me.pnlHDTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHDTR.Controls.Add(Me.btnPostPayroll)
        Me.pnlHDTR.Controls.Add(Me.cboLProcFiles)
        Me.pnlHDTR.Controls.Add(Me.lblHTPL)
        Me.pnlHDTR.Controls.Add(Me.txtHTPL)
        Me.pnlHDTR.Controls.Add(Me.lblHPD)
        Me.pnlHDTR.Controls.Add(Me.lblHPCSE)
        Me.pnlHDTR.Controls.Add(Me.lblHPMY)
        Me.pnlHDTR.Controls.Add(Me.txtHPY)
        Me.pnlHDTR.Controls.Add(Me.txtHPD)
        Me.pnlHDTR.Controls.Add(Me.txtHPCE)
        Me.pnlHDTR.Controls.Add(Me.txtHPCS)
        Me.pnlHDTR.Controls.Add(Me.txtHPM)
        Me.pnlHDTR.Controls.Add(Me.lblHDFT)
        Me.pnlHDTR.Controls.Add(Me.lblHDFH)
        Me.pnlHDTR.Controls.Add(Me.lblHProcFiles)
        Me.pnlHDTR.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHDTR.Location = New System.Drawing.Point(3, 3)
        Me.pnlHDTR.Name = "pnlHDTR"
        Me.pnlHDTR.Size = New System.Drawing.Size(1284, 137)
        Me.pnlHDTR.TabIndex = 1
        '
        'btnPostPayroll
        '
        Me.btnPostPayroll.Image = CType(resources.GetObject("btnPostPayroll.Image"), System.Drawing.Image)
        Me.btnPostPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPostPayroll.Location = New System.Drawing.Point(10, 66)
        Me.btnPostPayroll.Name = "btnPostPayroll"
        Me.btnPostPayroll.Size = New System.Drawing.Size(100, 30)
        Me.btnPostPayroll.TabIndex = 22
        Me.btnPostPayroll.Text = "Post Payroll"
        Me.btnPostPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPostPayroll.UseVisualStyleBackColor = True
        '
        'cboLProcFiles
        '
        Me.cboLProcFiles.FormattingEnabled = True
        Me.cboLProcFiles.Location = New System.Drawing.Point(10, 36)
        Me.cboLProcFiles.Name = "cboLProcFiles"
        Me.cboLProcFiles.Size = New System.Drawing.Size(416, 22)
        Me.cboLProcFiles.TabIndex = 21
        '
        'lblHTPL
        '
        Me.lblHTPL.AutoSize = True
        Me.lblHTPL.Location = New System.Drawing.Point(774, 48)
        Me.lblHTPL.Name = "lblHTPL"
        Me.lblHTPL.Size = New System.Drawing.Size(124, 14)
        Me.lblHTPL.TabIndex = 20
        Me.lblHTPL.Text = "Total Processed Lines"
        '
        'txtHTPL
        '
        Me.txtHTPL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHTPL.Location = New System.Drawing.Point(917, 44)
        Me.txtHTPL.MaxLength = 7
        Me.txtHTPL.Name = "txtHTPL"
        Me.txtHTPL.ReadOnly = True
        Me.txtHTPL.Size = New System.Drawing.Size(80, 23)
        Me.txtHTPL.TabIndex = 19
        Me.txtHTPL.Text = "0"
        Me.txtHTPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHPD
        '
        Me.lblHPD.AutoSize = True
        Me.lblHPD.Location = New System.Drawing.Point(457, 100)
        Me.lblHPD.Name = "lblHPD"
        Me.lblHPD.Size = New System.Drawing.Size(73, 14)
        Me.lblHPD.TabIndex = 18
        Me.lblHPD.Text = "Payroll Date"
        '
        'lblHPCSE
        '
        Me.lblHPCSE.AutoSize = True
        Me.lblHPCSE.Location = New System.Drawing.Point(457, 74)
        Me.lblHPCSE.Name = "lblHPCSE"
        Me.lblHPCSE.Size = New System.Drawing.Size(137, 14)
        Me.lblHPCSE.TabIndex = 17
        Me.lblHPCSE.Text = "Payroll Cutoff Start / End"
        '
        'lblHPMY
        '
        Me.lblHPMY.AutoSize = True
        Me.lblHPMY.Location = New System.Drawing.Point(457, 48)
        Me.lblHPMY.Name = "lblHPMY"
        Me.lblHPMY.Size = New System.Drawing.Size(110, 14)
        Me.lblHPMY.TabIndex = 16
        Me.lblHPMY.Text = "Payroll Month/Year"
        '
        'txtHPY
        '
        Me.txtHPY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHPY.Location = New System.Drawing.Point(656, 44)
        Me.txtHPY.MaxLength = 5
        Me.txtHPY.Name = "txtHPY"
        Me.txtHPY.ReadOnly = True
        Me.txtHPY.Size = New System.Drawing.Size(50, 23)
        Me.txtHPY.TabIndex = 15
        Me.txtHPY.Text = "1900"
        Me.txtHPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHPD
        '
        Me.txtHPD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHPD.Location = New System.Drawing.Point(600, 96)
        Me.txtHPD.MaxLength = 3
        Me.txtHPD.Name = "txtHPD"
        Me.txtHPD.ReadOnly = True
        Me.txtHPD.Size = New System.Drawing.Size(50, 23)
        Me.txtHPD.TabIndex = 14
        Me.txtHPD.Text = "1"
        Me.txtHPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHPCE
        '
        Me.txtHPCE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHPCE.Location = New System.Drawing.Point(656, 70)
        Me.txtHPCE.MaxLength = 3
        Me.txtHPCE.Name = "txtHPCE"
        Me.txtHPCE.ReadOnly = True
        Me.txtHPCE.Size = New System.Drawing.Size(50, 23)
        Me.txtHPCE.TabIndex = 13
        Me.txtHPCE.Text = "31"
        Me.txtHPCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHPCS
        '
        Me.txtHPCS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHPCS.Location = New System.Drawing.Point(600, 70)
        Me.txtHPCS.MaxLength = 3
        Me.txtHPCS.Name = "txtHPCS"
        Me.txtHPCS.ReadOnly = True
        Me.txtHPCS.Size = New System.Drawing.Size(50, 23)
        Me.txtHPCS.TabIndex = 12
        Me.txtHPCS.Text = "1"
        Me.txtHPCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHPM
        '
        Me.txtHPM.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHPM.Location = New System.Drawing.Point(600, 44)
        Me.txtHPM.MaxLength = 3
        Me.txtHPM.Name = "txtHPM"
        Me.txtHPM.ReadOnly = True
        Me.txtHPM.Size = New System.Drawing.Size(50, 23)
        Me.txtHPM.TabIndex = 11
        Me.txtHPM.Text = "1"
        Me.txtHPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHDFT
        '
        Me.lblHDFT.AutoSize = True
        Me.lblHDFT.Location = New System.Drawing.Point(774, 15)
        Me.lblHDFT.Name = "lblHDFT"
        Me.lblHDFT.Size = New System.Drawing.Size(79, 14)
        Me.lblHDFT.TabIndex = 10
        Me.lblHDFT.Text = "DTR File Trail"
        '
        'lblHDFH
        '
        Me.lblHDFH.AutoSize = True
        Me.lblHDFH.Location = New System.Drawing.Point(457, 15)
        Me.lblHDFH.Name = "lblHDFH"
        Me.lblHDFH.Size = New System.Drawing.Size(95, 14)
        Me.lblHDFH.TabIndex = 9
        Me.lblHDFH.Text = "DTR File Header"
        '
        'lblHProcFiles
        '
        Me.lblHProcFiles.AutoSize = True
        Me.lblHProcFiles.Location = New System.Drawing.Point(7, 15)
        Me.lblHProcFiles.Name = "lblHProcFiles"
        Me.lblHProcFiles.Size = New System.Drawing.Size(207, 14)
        Me.lblHProcFiles.TabIndex = 0
        Me.lblHProcFiles.Text = "Recent Uploaded and Processed DTR"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblProcStat)
        Me.Panel1.Controls.Add(Me.lblPProcessed)
        Me.Panel1.Controls.Add(Me.lblPSuccess)
        Me.Panel1.Controls.Add(Me.lblPFail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 483)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 25)
        Me.Panel1.TabIndex = 2
        '
        'lblProcStat
        '
        Me.lblProcStat.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblProcStat.Location = New System.Drawing.Point(0, 0)
        Me.lblProcStat.Name = "lblProcStat"
        Me.lblProcStat.Size = New System.Drawing.Size(932, 23)
        Me.lblProcStat.TabIndex = 4
        Me.lblProcStat.Text = "Awaiting data to process..."
        Me.lblProcStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPProcessed
        '
        Me.lblPProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPProcessed.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPProcessed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPProcessed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPProcessed.Location = New System.Drawing.Point(938, 0)
        Me.lblPProcessed.Name = "lblPProcessed"
        Me.lblPProcessed.Size = New System.Drawing.Size(120, 23)
        Me.lblPProcessed.TabIndex = 3
        Me.lblPProcessed.Text = "Processed : 0"
        Me.lblPProcessed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPSuccess
        '
        Me.lblPSuccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPSuccess.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPSuccess.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPSuccess.ForeColor = System.Drawing.Color.Green
        Me.lblPSuccess.Location = New System.Drawing.Point(1058, 0)
        Me.lblPSuccess.Name = "lblPSuccess"
        Me.lblPSuccess.Size = New System.Drawing.Size(120, 23)
        Me.lblPSuccess.TabIndex = 2
        Me.lblPSuccess.Text = "Success : 0"
        Me.lblPSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPFail
        '
        Me.lblPFail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPFail.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPFail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPFail.ForeColor = System.Drawing.Color.Red
        Me.lblPFail.Location = New System.Drawing.Point(1178, 0)
        Me.lblPFail.Name = "lblPFail"
        Me.lblPFail.Size = New System.Drawing.Size(120, 23)
        Me.lblPFail.TabIndex = 1
        Me.lblPFail.Text = "Failed : 0"
        Me.lblPFail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ofdDTR
        '
        Me.ofdDTR.Filter = "Employee DTR File (*.xls, *.xlsx)| *.xls; *.xlsx"
        Me.ofdDTR.InitialDirectory = "%APPPATH%"
        '
        'sfdDTR
        '
        Me.sfdDTR.Filter = "Employee DTR File (*.edf)| *.edf| Employee DTR File (*.xls, *.xlsx)| *.xls; *.xls" & _
    "x"
        Me.sfdDTR.InitialDirectory = "%APPPATH%"
        '
        'lblTALines
        '
        Me.lblTALines.AutoSize = True
        Me.lblTALines.Location = New System.Drawing.Point(774, 74)
        Me.lblTALines.Name = "lblTALines"
        Me.lblTALines.Size = New System.Drawing.Size(146, 14)
        Me.lblTALines.TabIndex = 24
        Me.lblTALines.Text = "ADJ Total Processed Lines"
        '
        'txtTALines
        '
        Me.txtTALines.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTALines.Location = New System.Drawing.Point(928, 70)
        Me.txtTALines.MaxLength = 7
        Me.txtTALines.Name = "txtTALines"
        Me.txtTALines.ReadOnly = True
        Me.txtTALines.Size = New System.Drawing.Size(80, 23)
        Me.txtTALines.TabIndex = 23
        Me.txtTALines.Text = "0"
        Me.txtTALines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmProcessPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 540)
        Me.Controls.Add(Me.tcProcDTR)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcessPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DTR and Payroll Processor"
        Me.tcProcDTR.ResumeLayout(False)
        Me.tpDTRImport.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tcDTRFile.ResumeLayout(False)
        Me.tpCDTR.ResumeLayout(False)
        CType(Me.dgvCDTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCAdj.ResumeLayout(False)
        CType(Me.dgvCAdj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDTRProc.ResumeLayout(False)
        Me.pnlDTRProc.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.tcHDTR.ResumeLayout(False)
        Me.tpHDTR.ResumeLayout(False)
        CType(Me.dgvHDTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHDTRR.ResumeLayout(False)
        CType(Me.dgvHDTRR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHPayout.ResumeLayout(False)
        CType(Me.dgvPayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHDTR.ResumeLayout(False)
        Me.pnlHDTR.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcProcDTR As System.Windows.Forms.TabControl
    Friend WithEvents tpDTRImport As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblProcStat As System.Windows.Forms.Label
    Friend WithEvents lblPProcessed As System.Windows.Forms.Label
    Friend WithEvents lblPSuccess As System.Windows.Forms.Label
    Friend WithEvents lblPFail As System.Windows.Forms.Label
    Friend WithEvents pnlDTRProc As System.Windows.Forms.Panel
    Friend WithEvents btnCCancel As System.Windows.Forms.Button
    Friend WithEvents txtSelDTRFile As System.Windows.Forms.TextBox
    Friend WithEvents lblCTFL As System.Windows.Forms.Label
    Friend WithEvents txtCTFL As System.Windows.Forms.TextBox
    Friend WithEvents lblCPD As System.Windows.Forms.Label
    Friend WithEvents lblCPCSE As System.Windows.Forms.Label
    Friend WithEvents lblCPMY As System.Windows.Forms.Label
    Friend WithEvents txtCPM As System.Windows.Forms.TextBox
    Friend WithEvents txtCPD As System.Windows.Forms.TextBox
    Friend WithEvents txtCPCE As System.Windows.Forms.TextBox
    Friend WithEvents txtCPCS As System.Windows.Forms.TextBox
    Friend WithEvents txtCPY As System.Windows.Forms.TextBox
    Friend WithEvents lblCDFT As System.Windows.Forms.Label
    Friend WithEvents lblCDFH As System.Windows.Forms.Label
    Friend WithEvents btnProcDTR As System.Windows.Forms.Button
    Friend WithEvents tcDTRFile As System.Windows.Forms.TabControl
    Friend WithEvents tpCDTR As System.Windows.Forms.TabPage
    Friend WithEvents dgvCDTR As System.Windows.Forms.DataGridView
    Friend WithEvents tpCAdj As System.Windows.Forms.TabPage
    Friend WithEvents dgvCAdj As System.Windows.Forms.DataGridView
    Friend WithEvents tcHDTR As System.Windows.Forms.TabControl
    Friend WithEvents tpHDTR As System.Windows.Forms.TabPage
    Friend WithEvents dgvHDTR As System.Windows.Forms.DataGridView
    Friend WithEvents tpHDTRR As System.Windows.Forms.TabPage
    Friend WithEvents dgvHDTRR As System.Windows.Forms.DataGridView
    Friend WithEvents pnlHDTR As System.Windows.Forms.Panel
    Friend WithEvents cboLProcFiles As System.Windows.Forms.ComboBox
    Friend WithEvents lblHTPL As System.Windows.Forms.Label
    Friend WithEvents txtHTPL As System.Windows.Forms.TextBox
    Friend WithEvents lblHPD As System.Windows.Forms.Label
    Friend WithEvents lblHPCSE As System.Windows.Forms.Label
    Friend WithEvents lblHPMY As System.Windows.Forms.Label
    Friend WithEvents txtHPY As System.Windows.Forms.TextBox
    Friend WithEvents txtHPD As System.Windows.Forms.TextBox
    Friend WithEvents txtHPCE As System.Windows.Forms.TextBox
    Friend WithEvents txtHPCS As System.Windows.Forms.TextBox
    Friend WithEvents txtHPM As System.Windows.Forms.TextBox
    Friend WithEvents lblHDFT As System.Windows.Forms.Label
    Friend WithEvents lblHDFH As System.Windows.Forms.Label
    Friend WithEvents lblHProcFiles As System.Windows.Forms.Label
    Friend WithEvents ofdDTR As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGenTemplate As System.Windows.Forms.Button
    Friend WithEvents sfdDTR As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lnkSelDTRFile As System.Windows.Forms.LinkLabel
    Friend WithEvents tpHPayout As System.Windows.Forms.TabPage
    Friend WithEvents dgvPayout As System.Windows.Forms.DataGridView
    Friend WithEvents btnPostPayroll As System.Windows.Forms.Button
    Friend WithEvents lblTALines As System.Windows.Forms.Label
    Friend WithEvents txtTALines As System.Windows.Forms.TextBox
End Class
