<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysUser))
        Me.tcUser = New System.Windows.Forms.TabControl()
        Me.tpUser = New System.Windows.Forms.TabPage()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboUR = New System.Windows.Forms.ComboBox()
        Me.lblUR = New System.Windows.Forms.Label()
        Me.lblCLIP1 = New System.Windows.Forms.Label()
        Me.lblLIPMin = New System.Windows.Forms.Label()
        Me.lblCLIP = New System.Windows.Forms.Label()
        Me.txtCLIP = New System.Windows.Forms.TextBox()
        Me.lblLIDMin = New System.Windows.Forms.Label()
        Me.lblLIP = New System.Windows.Forms.Label()
        Me.txtLIP = New System.Windows.Forms.TextBox()
        Me.lblLID = New System.Windows.Forms.Label()
        Me.txtLID = New System.Windows.Forms.TextBox()
        Me.cboEmp = New System.Windows.Forms.ComboBox()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.cboComp = New System.Windows.Forms.ComboBox()
        Me.lblComp = New System.Windows.Forms.Label()
        Me.colSel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.tcUser.SuspendLayout()
        Me.tpUser.SuspendLayout()
        Me.pnlUser.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcUser
        '
        Me.tcUser.Controls.Add(Me.tpUser)
        Me.tcUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcUser.Location = New System.Drawing.Point(0, 0)
        Me.tcUser.Name = "tcUser"
        Me.tcUser.SelectedIndex = 0
        Me.tcUser.Size = New System.Drawing.Size(834, 491)
        Me.tcUser.TabIndex = 0
        '
        'tpUser
        '
        Me.tpUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpUser.Controls.Add(Me.lblEmail)
        Me.tpUser.Controls.Add(Me.txtEmail)
        Me.tpUser.Controls.Add(Me.pnlUser)
        Me.tpUser.Controls.Add(Me.btnCancel)
        Me.tpUser.Controls.Add(Me.btnSave)
        Me.tpUser.Controls.Add(Me.cboUR)
        Me.tpUser.Controls.Add(Me.lblUR)
        Me.tpUser.Controls.Add(Me.lblCLIP1)
        Me.tpUser.Controls.Add(Me.lblLIPMin)
        Me.tpUser.Controls.Add(Me.lblCLIP)
        Me.tpUser.Controls.Add(Me.txtCLIP)
        Me.tpUser.Controls.Add(Me.lblLIDMin)
        Me.tpUser.Controls.Add(Me.lblLIP)
        Me.tpUser.Controls.Add(Me.txtLIP)
        Me.tpUser.Controls.Add(Me.lblLID)
        Me.tpUser.Controls.Add(Me.txtLID)
        Me.tpUser.Controls.Add(Me.cboEmp)
        Me.tpUser.Controls.Add(Me.lblEmp)
        Me.tpUser.Controls.Add(Me.cboComp)
        Me.tpUser.Controls.Add(Me.lblComp)
        Me.tpUser.Location = New System.Drawing.Point(4, 24)
        Me.tpUser.Name = "tpUser"
        Me.tpUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUser.Size = New System.Drawing.Size(826, 463)
        Me.tpUser.TabIndex = 0
        Me.tpUser.Text = "User Information"
        Me.tpUser.UseVisualStyleBackColor = True
        '
        'pnlUser
        '
        Me.pnlUser.Controls.Add(Me.dgvUser)
        Me.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlUser.Location = New System.Drawing.Point(3, 233)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(818, 225)
        Me.pnlUser.TabIndex = 18
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.colDel})
        Me.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUser.Location = New System.Drawing.Point(0, 0)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.Size = New System.Drawing.Size(818, 225)
        Me.dgvUser.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(203, 197)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(125, 197)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboUR
        '
        Me.cboUR.FormattingEnabled = True
        Me.cboUR.Items.AddRange(New Object() {"- Select a User Role -", "System Administrator", "Payroll Processor"})
        Me.cboUR.Location = New System.Drawing.Point(125, 168)
        Me.cboUR.Name = "cboUR"
        Me.cboUR.Size = New System.Drawing.Size(350, 23)
        Me.cboUR.TabIndex = 15
        '
        'lblUR
        '
        Me.lblUR.AutoSize = True
        Me.lblUR.Location = New System.Drawing.Point(7, 171)
        Me.lblUR.Name = "lblUR"
        Me.lblUR.Size = New System.Drawing.Size(59, 15)
        Me.lblUR.TabIndex = 14
        Me.lblUR.Text = "User Role"
        '
        'lblCLIP1
        '
        Me.lblCLIP1.AutoSize = True
        Me.lblCLIP1.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCLIP1.Location = New System.Drawing.Point(280, 119)
        Me.lblCLIP1.Name = "lblCLIP1"
        Me.lblCLIP1.Size = New System.Drawing.Size(104, 15)
        Me.lblCLIP1.TabIndex = 12
        Me.lblCLIP1.Text = "Re-type password"
        '
        'lblLIPMin
        '
        Me.lblLIPMin.AutoSize = True
        Me.lblLIPMin.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLIPMin.Location = New System.Drawing.Point(280, 93)
        Me.lblLIPMin.Name = "lblLIPMin"
        Me.lblLIPMin.Size = New System.Drawing.Size(144, 15)
        Me.lblLIPMin.TabIndex = 11
        Me.lblLIPMin.Text = "Minimum of 6 Characters"
        '
        'lblCLIP
        '
        Me.lblCLIP.AutoSize = True
        Me.lblCLIP.Location = New System.Drawing.Point(7, 119)
        Me.lblCLIP.Name = "lblCLIP"
        Me.lblCLIP.Size = New System.Drawing.Size(107, 15)
        Me.lblCLIP.TabIndex = 10
        Me.lblCLIP.Text = "Confirm Password"
        '
        'txtCLIP
        '
        Me.txtCLIP.Location = New System.Drawing.Point(125, 116)
        Me.txtCLIP.MaxLength = 25
        Me.txtCLIP.Name = "txtCLIP"
        Me.txtCLIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtCLIP.Size = New System.Drawing.Size(149, 23)
        Me.txtCLIP.TabIndex = 9
        '
        'lblLIDMin
        '
        Me.lblLIDMin.AutoSize = True
        Me.lblLIDMin.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLIDMin.Location = New System.Drawing.Point(280, 67)
        Me.lblLIDMin.Name = "lblLIDMin"
        Me.lblLIDMin.Size = New System.Drawing.Size(144, 15)
        Me.lblLIDMin.TabIndex = 8
        Me.lblLIDMin.Text = "Minimum of 6 Characters"
        '
        'lblLIP
        '
        Me.lblLIP.AutoSize = True
        Me.lblLIP.Location = New System.Drawing.Point(7, 93)
        Me.lblLIP.Name = "lblLIP"
        Me.lblLIP.Size = New System.Drawing.Size(61, 15)
        Me.lblLIP.TabIndex = 7
        Me.lblLIP.Text = "Password"
        '
        'txtLIP
        '
        Me.txtLIP.Location = New System.Drawing.Point(125, 90)
        Me.txtLIP.MaxLength = 25
        Me.txtLIP.Name = "txtLIP"
        Me.txtLIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtLIP.Size = New System.Drawing.Size(149, 23)
        Me.txtLIP.TabIndex = 6
        '
        'lblLID
        '
        Me.lblLID.AutoSize = True
        Me.lblLID.Location = New System.Drawing.Point(6, 67)
        Me.lblLID.Name = "lblLID"
        Me.lblLID.Size = New System.Drawing.Size(50, 15)
        Me.lblLID.TabIndex = 5
        Me.lblLID.Text = "Login Id"
        '
        'txtLID
        '
        Me.txtLID.Location = New System.Drawing.Point(125, 64)
        Me.txtLID.MaxLength = 25
        Me.txtLID.Name = "txtLID"
        Me.txtLID.Size = New System.Drawing.Size(149, 23)
        Me.txtLID.TabIndex = 4
        '
        'cboEmp
        '
        Me.cboEmp.FormattingEnabled = True
        Me.cboEmp.Location = New System.Drawing.Point(125, 38)
        Me.cboEmp.Name = "cboEmp"
        Me.cboEmp.Size = New System.Drawing.Size(350, 23)
        Me.cboEmp.TabIndex = 3
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(7, 41)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(59, 15)
        Me.lblEmp.TabIndex = 2
        Me.lblEmp.Text = "Employee"
        '
        'cboComp
        '
        Me.cboComp.FormattingEnabled = True
        Me.cboComp.Location = New System.Drawing.Point(125, 12)
        Me.cboComp.Name = "cboComp"
        Me.cboComp.Size = New System.Drawing.Size(350, 23)
        Me.cboComp.TabIndex = 1
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Location = New System.Drawing.Point(7, 15)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(58, 15)
        Me.lblComp.TabIndex = 0
        Me.lblComp.Text = "Company"
        '
        'colSel
        '
        Me.colSel.Frozen = True
        Me.colSel.HeaderText = ""
        Me.colSel.Name = "colSel"
        Me.colSel.ReadOnly = True
        Me.colSel.Text = "Select"
        Me.colSel.UseColumnTextForButtonValue = True
        Me.colSel.Width = 70
        '
        'colDel
        '
        Me.colDel.Frozen = True
        Me.colDel.HeaderText = ""
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Text = "Remove"
        Me.colDel.UseColumnTextForButtonValue = True
        Me.colDel.Width = 70
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(7, 145)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(85, 15)
        Me.lblEmail.TabIndex = 20
        Me.lblEmail.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(125, 142)
        Me.txtEmail.MaxLength = 150
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtEmail.Size = New System.Drawing.Size(350, 23)
        Me.txtEmail.TabIndex = 19
        '
        'frmSysUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 491)
        Me.Controls.Add(Me.tcUser)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSysUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " System User"
        Me.tcUser.ResumeLayout(False)
        Me.tpUser.ResumeLayout(False)
        Me.tpUser.PerformLayout()
        Me.pnlUser.ResumeLayout(False)
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcUser As System.Windows.Forms.TabControl
    Friend WithEvents tpUser As System.Windows.Forms.TabPage
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboUR As System.Windows.Forms.ComboBox
    Friend WithEvents lblUR As System.Windows.Forms.Label
    Friend WithEvents lblCLIP1 As System.Windows.Forms.Label
    Friend WithEvents lblLIPMin As System.Windows.Forms.Label
    Friend WithEvents lblCLIP As System.Windows.Forms.Label
    Friend WithEvents txtCLIP As System.Windows.Forms.TextBox
    Friend WithEvents lblLIDMin As System.Windows.Forms.Label
    Friend WithEvents lblLIP As System.Windows.Forms.Label
    Friend WithEvents txtLIP As System.Windows.Forms.TextBox
    Friend WithEvents lblLID As System.Windows.Forms.Label
    Friend WithEvents txtLID As System.Windows.Forms.TextBox
    Friend WithEvents cboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmp As System.Windows.Forms.Label
    Friend WithEvents cboComp As System.Windows.Forms.ComboBox
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents pnlUser As System.Windows.Forms.Panel
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents colSel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
