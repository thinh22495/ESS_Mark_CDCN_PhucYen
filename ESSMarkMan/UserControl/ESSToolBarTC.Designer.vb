<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESSToolBarTC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.LblID_he = New System.Windows.Forms.ToolStripLabel
        Me.cmbID_he = New System.Windows.Forms.ToolStripComboBox
        Me.lblID_chuyen_nganh = New System.Windows.Forms.ToolStripLabel
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ToolStripComboBox
        Me.LblHoc_ky = New System.Windows.Forms.ToolStripLabel
        Me.cmbHoc_ky = New System.Windows.Forms.ToolStripComboBox
        Me.lblNam_hoc = New System.Windows.Forms.ToolStripLabel
        Me.cmbNam_hoc = New System.Windows.Forms.ToolStripComboBox
        Me.LblKy_dang_ky = New System.Windows.Forms.ToolStripLabel
        Me.cmbKy_dang_ky = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblID_he, Me.cmbID_he, Me.lblID_chuyen_nganh, Me.cmbID_chuyen_nganh, Me.LblHoc_ky, Me.cmbHoc_ky, Me.lblNam_hoc, Me.cmbNam_hoc, Me.LblKy_dang_ky, Me.cmbKy_dang_ky})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(800, 33)
        Me.ToolStrip.TabIndex = 233
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'LblID_he
        '
        Me.LblID_he.Name = "LblID_he"
        Me.LblID_he.Size = New System.Drawing.Size(27, 30)
        Me.LblID_he.Text = "HỆ:"
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(150, 33)
        '
        'lblID_chuyen_nganh
        '
        Me.lblID_chuyen_nganh.Name = "lblID_chuyen_nganh"
        Me.lblID_chuyen_nganh.Size = New System.Drawing.Size(68, 30)
        Me.lblID_chuyen_nganh.Text = "C.NGÀNH:"
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Items.AddRange(New Object() {"Chuyên ngành chính", "Chuyên ngành 2"})
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(140, 33)
        '
        'LblHoc_ky
        '
        Me.LblHoc_ky.Name = "LblHoc_ky"
        Me.LblHoc_ky.Size = New System.Drawing.Size(59, 30)
        Me.LblHoc_ky.Text = "HỌC KỲ:"
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(75, 33)
        '
        'lblNam_hoc
        '
        Me.lblNam_hoc.Name = "lblNam_hoc"
        Me.lblNam_hoc.Size = New System.Drawing.Size(71, 30)
        Me.lblNam_hoc.Text = "NĂM HỌC:"
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(80, 33)
        '
        'LblKy_dang_ky
        '
        Me.LblKy_dang_ky.Name = "LblKy_dang_ky"
        Me.LblKy_dang_ky.Size = New System.Drawing.Size(87, 30)
        Me.LblKy_dang_ky.Text = "KỲ ĐĂNG KÝ:"
        '
        'cmbKy_dang_ky
        '
        Me.cmbKy_dang_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_dang_ky.Name = "cmbKy_dang_ky"
        Me.cmbKy_dang_ky.Size = New System.Drawing.Size(200, 23)
        '
        'ESSToolBarTC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ESSToolBarTC"
        Me.Size = New System.Drawing.Size(800, 33)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents LblID_he As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbID_he As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LblHoc_ky As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblNam_hoc As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblID_chuyen_nganh As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbKy_dang_ky As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LblKy_dang_ky As System.Windows.Forms.ToolStripLabel

End Class
