<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDTRSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDTRSetup))
        Me.tcTempInfo = New System.Windows.Forms.TabControl()
        Me.tpTempInfo = New System.Windows.Forms.TabPage()
        Me.chkProcEmp = New System.Windows.Forms.CheckBox()
        Me.cboPD = New System.Windows.Forms.ComboBox()
        Me.lblPD = New System.Windows.Forms.Label()
        Me.cboCOE = New System.Windows.Forms.ComboBox()
        Me.cboCOS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPM = New System.Windows.Forms.ComboBox()
        Me.lblCOSE = New System.Windows.Forms.Label()
        Me.cboPY = New System.Windows.Forms.ComboBox()
        Me.lblPMY = New System.Windows.Forms.Label()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboPP = New System.Windows.Forms.ComboBox()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.cboEG = New System.Windows.Forms.ComboBox()
        Me.cboEC = New System.Windows.Forms.ComboBox()
        Me.lblEG = New System.Windows.Forms.Label()
        Me.lblEC = New System.Windows.Forms.Label()
        Me.tcTempInfo.SuspendLayout()
        Me.tpTempInfo.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcTempInfo
        '
        Me.tcTempInfo.Controls.Add(Me.tpTempInfo)
        Me.tcTempInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTempInfo.Location = New System.Drawing.Point(0, 0)
        Me.tcTempInfo.Name = "tcTempInfo"
        Me.tcTempInfo.SelectedIndex = 0
        Me.tcTempInfo.Size = New System.Drawing.Size(511, 277)
        Me.tcTempInfo.TabIndex = 0
        '
        'tpTempInfo
        '
        Me.tpTempInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpTempInfo.Controls.Add(Me.chkProcEmp)
        Me.tpTempInfo.Controls.Add(Me.cboPD)
        Me.tpTempInfo.Controls.Add(Me.lblPD)
        Me.tpTempInfo.Controls.Add(Me.cboCOE)
        Me.tpTempInfo.Controls.Add(Me.cboCOS)
        Me.tpTempInfo.Controls.Add(Me.Label3)
        Me.tpTempInfo.Controls.Add(Me.cboPM)
        Me.tpTempInfo.Controls.Add(Me.lblCOSE)
        Me.tpTempInfo.Controls.Add(Me.cboPY)
        Me.tpTempInfo.Controls.Add(Me.lblPMY)
        Me.tpTempInfo.Controls.Add(Me.pnlControl)
        Me.tpTempInfo.Controls.Add(Me.cboPP)
        Me.tpTempInfo.Controls.Add(Me.lblPP)
        Me.tpTempInfo.Controls.Add(Me.cboEG)
        Me.tpTempInfo.Controls.Add(Me.cboEC)
        Me.tpTempInfo.Controls.Add(Me.lblEG)
        Me.tpTempInfo.Controls.Add(Me.lblEC)
        Me.tpTempInfo.Location = New System.Drawing.Point(4, 24)
        Me.tpTempInfo.Name = "tpTempInfo"
        Me.tpTempInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTempInfo.Size = New System.Drawing.Size(503, 249)
        Me.tpTempInfo.TabIndex = 0
        Me.tpTempInfo.Text = "Template Information"
        Me.tpTempInfo.UseVisualStyleBackColor = True
        '
        'chkProcEmp
        '
        Me.chkProcEmp.AutoSize = True
        Me.chkProcEmp.Location = New System.Drawing.Point(140, 171)
        Me.chkProcEmp.Name = "chkProcEmp"
        Me.chkProcEmp.Size = New System.Drawing.Size(267, 19)
        Me.chkProcEmp.TabIndex = 22
        Me.chkProcEmp.Text = "Include Processed employees for this cutoff."
        Me.chkProcEmp.UseVisualStyleBackColor = True
        '
        'cboPD
        '
        Me.cboPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPD.Enabled = False
        Me.cboPD.FormattingEnabled = True
        Me.cboPD.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboPD.Location = New System.Drawing.Point(140, 142)
        Me.cboPD.Name = "cboPD"
        Me.cboPD.Size = New System.Drawing.Size(66, 23)
        Me.cboPD.TabIndex = 21
        '
        'lblPD
        '
        Me.lblPD.AutoSize = True
        Me.lblPD.Location = New System.Drawing.Point(7, 146)
        Me.lblPD.Name = "lblPD"
        Me.lblPD.Size = New System.Drawing.Size(69, 15)
        Me.lblPD.TabIndex = 20
        Me.lblPD.Text = "Payout Day"
        '
        'cboCOE
        '
        Me.cboCOE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOE.Enabled = False
        Me.cboCOE.FormattingEnabled = True
        Me.cboCOE.Items.AddRange(New Object() {"- Cutoff End -", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboCOE.Location = New System.Drawing.Point(212, 116)
        Me.cboCOE.Name = "cboCOE"
        Me.cboCOE.Size = New System.Drawing.Size(66, 23)
        Me.cboCOE.TabIndex = 19
        '
        'cboCOS
        '
        Me.cboCOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOS.Enabled = False
        Me.cboCOS.FormattingEnabled = True
        Me.cboCOS.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboCOS.Location = New System.Drawing.Point(140, 116)
        Me.cboCOS.Name = "cboCOS"
        Me.cboCOS.Size = New System.Drawing.Size(66, 23)
        Me.cboCOS.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 17
        '
        'cboPM
        '
        Me.cboPM.FormattingEnabled = True
        Me.cboPM.Items.AddRange(New Object() {"- Select Covered Month -", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboPM.Location = New System.Drawing.Point(140, 90)
        Me.cboPM.Name = "cboPM"
        Me.cboPM.Size = New System.Drawing.Size(160, 23)
        Me.cboPM.TabIndex = 16
        '
        'lblCOSE
        '
        Me.lblCOSE.AutoSize = True
        Me.lblCOSE.Location = New System.Drawing.Point(7, 119)
        Me.lblCOSE.Name = "lblCOSE"
        Me.lblCOSE.Size = New System.Drawing.Size(94, 15)
        Me.lblCOSE.TabIndex = 15
        Me.lblCOSE.Text = "Cutoff Start/End"
        '
        'cboPY
        '
        Me.cboPY.FormattingEnabled = True
        Me.cboPY.Location = New System.Drawing.Point(306, 90)
        Me.cboPY.Name = "cboPY"
        Me.cboPY.Size = New System.Drawing.Size(100, 23)
        Me.cboPY.TabIndex = 14
        '
        'lblPMY
        '
        Me.lblPMY.AutoSize = True
        Me.lblPMY.Location = New System.Drawing.Point(7, 93)
        Me.lblPMY.Name = "lblPMY"
        Me.lblPMY.Size = New System.Drawing.Size(124, 15)
        Me.lblPMY.TabIndex = 9
        Me.lblPMY.Text = "Covered Month / Year"
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.lblStat)
        Me.pnlControl.Controls.Add(Me.btnGenerate)
        Me.pnlControl.Controls.Add(Me.btnCancel)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControl.Location = New System.Drawing.Point(3, 214)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(495, 30)
        Me.pnlControl.TabIndex = 8
        '
        'lblStat
        '
        Me.lblStat.AutoSize = True
        Me.lblStat.Location = New System.Drawing.Point(3, 8)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(147, 15)
        Me.lblStat.TabIndex = 3
        Me.lblStat.Text = "Awaiting user command..."
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.Location = New System.Drawing.Point(335, 0)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(85, 30)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(420, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboPP
        '
        Me.cboPP.FormattingEnabled = True
        Me.cboPP.Location = New System.Drawing.Point(140, 64)
        Me.cboPP.Name = "cboPP"
        Me.cboPP.Size = New System.Drawing.Size(349, 23)
        Me.cboPP.TabIndex = 7
        '
        'lblPP
        '
        Me.lblPP.AutoSize = True
        Me.lblPP.Location = New System.Drawing.Point(7, 67)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(84, 15)
        Me.lblPP.TabIndex = 6
        Me.lblPP.Text = "Payout Period"
        '
        'cboEG
        '
        Me.cboEG.FormattingEnabled = True
        Me.cboEG.Location = New System.Drawing.Point(140, 38)
        Me.cboEG.Name = "cboEG"
        Me.cboEG.Size = New System.Drawing.Size(349, 23)
        Me.cboEG.TabIndex = 5
        '
        'cboEC
        '
        Me.cboEC.FormattingEnabled = True
        Me.cboEC.Location = New System.Drawing.Point(140, 12)
        Me.cboEC.Name = "cboEC"
        Me.cboEC.Size = New System.Drawing.Size(349, 23)
        Me.cboEC.TabIndex = 4
        '
        'lblEG
        '
        Me.lblEG.AutoSize = True
        Me.lblEG.Location = New System.Drawing.Point(7, 41)
        Me.lblEG.Name = "lblEG"
        Me.lblEG.Size = New System.Drawing.Size(96, 15)
        Me.lblEG.TabIndex = 3
        Me.lblEG.Text = "Employee Group"
        '
        'lblEC
        '
        Me.lblEC.AutoSize = True
        Me.lblEC.Location = New System.Drawing.Point(7, 15)
        Me.lblEC.Name = "lblEC"
        Me.lblEC.Size = New System.Drawing.Size(92, 15)
        Me.lblEC.TabIndex = 2
        Me.lblEC.Text = "Employee Class"
        '
        'frmDTRSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcTempInfo)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDTRSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate DTR Template"
        Me.tcTempInfo.ResumeLayout(False)
        Me.tpTempInfo.ResumeLayout(False)
        Me.tpTempInfo.PerformLayout()
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTempInfo As System.Windows.Forms.TabControl
    Friend WithEvents tpTempInfo As System.Windows.Forms.TabPage
    Friend WithEvents cboPP As System.Windows.Forms.ComboBox
    Friend WithEvents lblPP As System.Windows.Forms.Label
    Friend WithEvents cboEG As System.Windows.Forms.ComboBox
    Friend WithEvents cboEC As System.Windows.Forms.ComboBox
    Friend WithEvents lblEG As System.Windows.Forms.Label
    Friend WithEvents lblEC As System.Windows.Forms.Label
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblPMY As System.Windows.Forms.Label
    Friend WithEvents cboPM As System.Windows.Forms.ComboBox
    Friend WithEvents lblCOSE As System.Windows.Forms.Label
    Friend WithEvents cboPY As System.Windows.Forms.ComboBox
    Friend WithEvents cboPD As System.Windows.Forms.ComboBox
    Friend WithEvents lblPD As System.Windows.Forms.Label
    Friend WithEvents cboCOE As System.Windows.Forms.ComboBox
    Friend WithEvents cboCOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkProcEmp As System.Windows.Forms.CheckBox
    Friend WithEvents lblStat As System.Windows.Forms.Label
End Class
