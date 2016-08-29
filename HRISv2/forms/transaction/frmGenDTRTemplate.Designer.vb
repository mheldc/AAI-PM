<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenDTRTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenDTRTemplate))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbTemp = New System.Windows.Forms.ProgressBar()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tcTemplate = New System.Windows.Forms.TabControl()
        Me.tpTemplate = New System.Windows.Forms.TabPage()
        Me.cboPayPeriod = New System.Windows.Forms.ComboBox()
        Me.lblPayPeriod = New System.Windows.Forms.Label()
        Me.cboProcEmps = New System.Windows.Forms.ComboBox()
        Me.lblProcEmps = New System.Windows.Forms.Label()
        Me.rdbXLS = New System.Windows.Forms.RadioButton()
        Me.lblTempType = New System.Windows.Forms.Label()
        Me.rdbEDF = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.tcTemplate.SuspendLayout()
        Me.tpTemplate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbTemp)
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 30)
        Me.Panel1.TabIndex = 3
        '
        'pbTemp
        '
        Me.pbTemp.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbTemp.Location = New System.Drawing.Point(0, 0)
        Me.pbTemp.Name = "pbTemp"
        Me.pbTemp.Size = New System.Drawing.Size(150, 30)
        Me.pbTemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbTemp.TabIndex = 3
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGenerate.Image = CType(resources.GetObject("btnGenerate.Image"), System.Drawing.Image)
        Me.btnGenerate.Location = New System.Drawing.Point(315, 0)
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
        Me.btnCancel.Location = New System.Drawing.Point(400, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tcTemplate
        '
        Me.tcTemplate.Controls.Add(Me.tpTemplate)
        Me.tcTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcTemplate.Location = New System.Drawing.Point(0, 0)
        Me.tcTemplate.Name = "tcTemplate"
        Me.tcTemplate.SelectedIndex = 0
        Me.tcTemplate.Size = New System.Drawing.Size(475, 245)
        Me.tcTemplate.TabIndex = 4
        '
        'tpTemplate
        '
        Me.tpTemplate.AutoScroll = True
        Me.tpTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpTemplate.Controls.Add(Me.cboPayPeriod)
        Me.tpTemplate.Controls.Add(Me.lblPayPeriod)
        Me.tpTemplate.Controls.Add(Me.cboProcEmps)
        Me.tpTemplate.Controls.Add(Me.lblProcEmps)
        Me.tpTemplate.Controls.Add(Me.rdbXLS)
        Me.tpTemplate.Controls.Add(Me.lblTempType)
        Me.tpTemplate.Controls.Add(Me.rdbEDF)
        Me.tpTemplate.Location = New System.Drawing.Point(4, 23)
        Me.tpTemplate.Name = "tpTemplate"
        Me.tpTemplate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTemplate.Size = New System.Drawing.Size(467, 218)
        Me.tpTemplate.TabIndex = 0
        Me.tpTemplate.Text = "Template Information"
        Me.tpTemplate.UseVisualStyleBackColor = True
        '
        'cboPayPeriod
        '
        Me.cboPayPeriod.FormattingEnabled = True
        Me.cboPayPeriod.Location = New System.Drawing.Point(7, 89)
        Me.cboPayPeriod.Name = "cboPayPeriod"
        Me.cboPayPeriod.Size = New System.Drawing.Size(451, 22)
        Me.cboPayPeriod.TabIndex = 6
        '
        'lblPayPeriod
        '
        Me.lblPayPeriod.AutoSize = True
        Me.lblPayPeriod.Location = New System.Drawing.Point(4, 70)
        Me.lblPayPeriod.Name = "lblPayPeriod"
        Me.lblPayPeriod.Size = New System.Drawing.Size(82, 14)
        Me.lblPayPeriod.TabIndex = 5
        Me.lblPayPeriod.Text = "Payroll Period"
        '
        'cboProcEmps
        '
        Me.cboProcEmps.FormattingEnabled = True
        Me.cboProcEmps.Location = New System.Drawing.Point(7, 36)
        Me.cboProcEmps.Name = "cboProcEmps"
        Me.cboProcEmps.Size = New System.Drawing.Size(451, 22)
        Me.cboProcEmps.TabIndex = 4
        '
        'lblProcEmps
        '
        Me.lblProcEmps.AutoSize = True
        Me.lblProcEmps.Location = New System.Drawing.Point(4, 17)
        Me.lblProcEmps.Name = "lblProcEmps"
        Me.lblProcEmps.Size = New System.Drawing.Size(172, 14)
        Me.lblProcEmps.TabIndex = 3
        Me.lblProcEmps.Text = "Allowed Employees to Process"
        '
        'rdbXLS
        '
        Me.rdbXLS.AutoSize = True
        Me.rdbXLS.Location = New System.Drawing.Point(137, 162)
        Me.rdbXLS.Name = "rdbXLS"
        Me.rdbXLS.Size = New System.Drawing.Size(196, 18)
        Me.rdbXLS.TabIndex = 2
        Me.rdbXLS.TabStop = True
        Me.rdbXLS.Text = "Employee DTR File (*.xls, *.xlsx)"
        Me.rdbXLS.UseVisualStyleBackColor = True
        '
        'lblTempType
        '
        Me.lblTempType.AutoSize = True
        Me.lblTempType.Location = New System.Drawing.Point(4, 140)
        Me.lblTempType.Name = "lblTempType"
        Me.lblTempType.Size = New System.Drawing.Size(85, 14)
        Me.lblTempType.TabIndex = 0
        Me.lblTempType.Text = "Template Type"
        '
        'rdbEDF
        '
        Me.rdbEDF.AutoSize = True
        Me.rdbEDF.Checked = True
        Me.rdbEDF.Location = New System.Drawing.Point(137, 138)
        Me.rdbEDF.Name = "rdbEDF"
        Me.rdbEDF.Size = New System.Drawing.Size(164, 18)
        Me.rdbEDF.TabIndex = 1
        Me.rdbEDF.TabStop = True
        Me.rdbEDF.Text = "Employee DTR File (*.edf)"
        Me.rdbEDF.UseVisualStyleBackColor = True
        '
        'frmGenDTRTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 275)
        Me.Controls.Add(Me.tcTemplate)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenDTRTemplate"
        Me.Text = "Generate DTR Template"
        Me.Panel1.ResumeLayout(False)
        Me.tcTemplate.ResumeLayout(False)
        Me.tpTemplate.ResumeLayout(False)
        Me.tpTemplate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbTemp As System.Windows.Forms.ProgressBar
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tcTemplate As System.Windows.Forms.TabControl
    Friend WithEvents tpTemplate As System.Windows.Forms.TabPage
    Friend WithEvents cboPayPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayPeriod As System.Windows.Forms.Label
    Friend WithEvents cboProcEmps As System.Windows.Forms.ComboBox
    Friend WithEvents lblProcEmps As System.Windows.Forms.Label
    Friend WithEvents rdbXLS As System.Windows.Forms.RadioButton
    Friend WithEvents lblTempType As System.Windows.Forms.Label
    Friend WithEvents rdbEDF As System.Windows.Forms.RadioButton
End Class
