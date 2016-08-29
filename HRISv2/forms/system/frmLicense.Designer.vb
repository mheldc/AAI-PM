<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicense))
        Me.btnLicReg = New System.Windows.Forms.Button()
        Me.txtLicKey = New System.Windows.Forms.TextBox()
        Me.lblLicKey = New System.Windows.Forms.Label()
        Me.txtLicEmpCount = New System.Windows.Forms.TextBox()
        Me.lblLicEmpCount = New System.Windows.Forms.Label()
        Me.txtLicCompany = New System.Windows.Forms.TextBox()
        Me.lblLicCompany = New System.Windows.Forms.Label()
        Me.lblLicType = New System.Windows.Forms.Label()
        Me.lblLicTypeStat = New System.Windows.Forms.Label()
        Me.lblLicTypeVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLicReg
        '
        Me.btnLicReg.Image = CType(resources.GetObject("btnLicReg.Image"), System.Drawing.Image)
        Me.btnLicReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLicReg.Location = New System.Drawing.Point(158, 195)
        Me.btnLicReg.Name = "btnLicReg"
        Me.btnLicReg.Size = New System.Drawing.Size(213, 30)
        Me.btnLicReg.TabIndex = 27
        Me.btnLicReg.Text = "   Register and Activate Software"
        Me.btnLicReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLicReg.UseVisualStyleBackColor = True
        '
        'txtLicKey
        '
        Me.txtLicKey.Location = New System.Drawing.Point(158, 92)
        Me.txtLicKey.Multiline = True
        Me.txtLicKey.Name = "txtLicKey"
        Me.txtLicKey.Size = New System.Drawing.Size(309, 66)
        Me.txtLicKey.TabIndex = 26
        '
        'lblLicKey
        '
        Me.lblLicKey.AutoSize = True
        Me.lblLicKey.Location = New System.Drawing.Point(12, 95)
        Me.lblLicKey.Name = "lblLicKey"
        Me.lblLicKey.Size = New System.Drawing.Size(69, 14)
        Me.lblLicKey.TabIndex = 25
        Me.lblLicKey.Text = "License Key"
        '
        'txtLicEmpCount
        '
        Me.txtLicEmpCount.Location = New System.Drawing.Point(158, 64)
        Me.txtLicEmpCount.Name = "txtLicEmpCount"
        Me.txtLicEmpCount.Size = New System.Drawing.Size(59, 22)
        Me.txtLicEmpCount.TabIndex = 24
        Me.txtLicEmpCount.Text = "0"
        Me.txtLicEmpCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLicEmpCount
        '
        Me.lblLicEmpCount.AutoSize = True
        Me.lblLicEmpCount.Location = New System.Drawing.Point(12, 67)
        Me.lblLicEmpCount.Name = "lblLicEmpCount"
        Me.lblLicEmpCount.Size = New System.Drawing.Size(119, 14)
        Me.lblLicEmpCount.TabIndex = 23
        Me.lblLicEmpCount.Text = "Max Employee Count"
        '
        'txtLicCompany
        '
        Me.txtLicCompany.Location = New System.Drawing.Point(158, 40)
        Me.txtLicCompany.Name = "txtLicCompany"
        Me.txtLicCompany.Size = New System.Drawing.Size(309, 22)
        Me.txtLicCompany.TabIndex = 22
        '
        'lblLicCompany
        '
        Me.lblLicCompany.AutoSize = True
        Me.lblLicCompany.Location = New System.Drawing.Point(12, 43)
        Me.lblLicCompany.Name = "lblLicCompany"
        Me.lblLicCompany.Size = New System.Drawing.Size(56, 14)
        Me.lblLicCompany.TabIndex = 21
        Me.lblLicCompany.Text = "Company"
        '
        'lblLicType
        '
        Me.lblLicType.AutoSize = True
        Me.lblLicType.Location = New System.Drawing.Point(12, 19)
        Me.lblLicType.Name = "lblLicType"
        Me.lblLicType.Size = New System.Drawing.Size(75, 14)
        Me.lblLicType.TabIndex = 19
        Me.lblLicType.Text = "License Type"
        '
        'lblLicTypeStat
        '
        Me.lblLicTypeStat.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicTypeStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLicTypeStat.Location = New System.Drawing.Point(158, 161)
        Me.lblLicTypeStat.Name = "lblLicTypeStat"
        Me.lblLicTypeStat.Size = New System.Drawing.Size(309, 13)
        Me.lblLicTypeStat.TabIndex = 28
        Me.lblLicTypeStat.Text = "Trial / Demo Version"
        Me.lblLicTypeStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLicTypeVal
        '
        Me.lblLicTypeVal.AutoSize = True
        Me.lblLicTypeVal.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicTypeVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLicTypeVal.Location = New System.Drawing.Point(155, 19)
        Me.lblLicTypeVal.Name = "lblLicTypeVal"
        Me.lblLicTypeVal.Size = New System.Drawing.Size(67, 14)
        Me.lblLicTypeVal.TabIndex = 29
        Me.lblLicTypeVal.Text = "30-Day Trial"
        '
        'frmLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 233)
        Me.Controls.Add(Me.lblLicTypeVal)
        Me.Controls.Add(Me.lblLicTypeStat)
        Me.Controls.Add(Me.btnLicReg)
        Me.Controls.Add(Me.txtLicKey)
        Me.Controls.Add(Me.lblLicKey)
        Me.Controls.Add(Me.txtLicEmpCount)
        Me.Controls.Add(Me.lblLicEmpCount)
        Me.Controls.Add(Me.txtLicCompany)
        Me.Controls.Add(Me.lblLicCompany)
        Me.Controls.Add(Me.lblLicType)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLicense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLicReg As System.Windows.Forms.Button
    Friend WithEvents txtLicKey As System.Windows.Forms.TextBox
    Friend WithEvents lblLicKey As System.Windows.Forms.Label
    Friend WithEvents txtLicEmpCount As System.Windows.Forms.TextBox
    Friend WithEvents lblLicEmpCount As System.Windows.Forms.Label
    Friend WithEvents txtLicCompany As System.Windows.Forms.TextBox
    Friend WithEvents lblLicCompany As System.Windows.Forms.Label
    Friend WithEvents lblLicType As System.Windows.Forms.Label
    Friend WithEvents lblLicTypeStat As System.Windows.Forms.Label
    Friend WithEvents lblLicTypeVal As System.Windows.Forms.Label
End Class
