<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_HoTroNhapDiemTuExcel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblPhan_tram = New System.Windows.Forms.Label
        Me.txtTy_le = New System.Windows.Forms.TextBox
        Me.lblTy_le = New System.Windows.Forms.Label
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblNam_hoc = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblHoc_ky = New System.Windows.Forms.Label
        Me.cmdOpen = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbFont = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdFontFile = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdViewSinhVien = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbChonFile
        '
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(618, 20)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 24)
        Me.cmbChonFile.TabIndex = 36
        '
        'lblPhan_tram
        '
        Me.lblPhan_tram.Location = New System.Drawing.Point(510, 20)
        Me.lblPhan_tram.Name = "lblPhan_tram"
        Me.lblPhan_tram.Size = New System.Drawing.Size(16, 24)
        Me.lblPhan_tram.TabIndex = 41
        Me.lblPhan_tram.Text = "%"
        Me.lblPhan_tram.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTy_le
        '
        Me.txtTy_le.Location = New System.Drawing.Point(466, 21)
        Me.txtTy_le.MaxLength = 3
        Me.txtTy_le.Name = "txtTy_le"
        Me.txtTy_le.Size = New System.Drawing.Size(44, 23)
        Me.txtTy_le.TabIndex = 34
        Me.txtTy_le.Text = "30"
        '
        'lblTy_le
        '
        Me.lblTy_le.Location = New System.Drawing.Point(410, 20)
        Me.lblTy_le.Name = "lblTy_le"
        Me.lblTy_le.Size = New System.Drawing.Size(56, 24)
        Me.lblTy_le.TabIndex = 40
        Me.lblTy_le.Text = "Tỷ lệ:"
        Me.lblTy_le.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.Location = New System.Drawing.Point(526, 20)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 39
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(306, 20)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(96, 24)
        Me.cmbNam_hoc.TabIndex = 28
        '
        'lblNam_hoc
        '
        Me.lblNam_hoc.Location = New System.Drawing.Point(230, 20)
        Me.lblNam_hoc.Name = "lblNam_hoc"
        Me.lblNam_hoc.Size = New System.Drawing.Size(76, 24)
        Me.lblNam_hoc.TabIndex = 29
        Me.lblNam_hoc.Text = "Năm học:"
        Me.lblNam_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(176, 20)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(54, 24)
        Me.cmbHoc_ky.TabIndex = 27
        '
        'lblHoc_ky
        '
        Me.lblHoc_ky.Location = New System.Drawing.Point(115, 20)
        Me.lblHoc_ky.Name = "lblHoc_ky"
        Me.lblHoc_ky.Size = New System.Drawing.Size(61, 24)
        Me.lblHoc_ky.TabIndex = 26
        Me.lblHoc_ky.Text = "Học kỳ:"
        Me.lblHoc_ky.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOpen
        '
        Me.cmdOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpen.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.ForeColor = System.Drawing.Color.Brown
        Me.cmdOpen.Image = Global.ESSMarkMan.My.Resources.Resources.Folder
        Me.cmdOpen.Location = New System.Drawing.Point(725, 20)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(34, 25)
        Me.cmdOpen.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbFont)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbKhoa_hoc)
        Me.GroupBox1.Controls.Add(Me.lblTy_le)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdOpen)
        Me.GroupBox1.Controls.Add(Me.cmbChonFile)
        Me.GroupBox1.Controls.Add(Me.lblPhan_tram)
        Me.GroupBox1.Controls.Add(Me.txtTy_le)
        Me.GroupBox1.Controls.Add(Me.lblHoc_ky)
        Me.GroupBox1.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox1.Controls.Add(Me.lblBang_tinh)
        Me.GroupBox1.Controls.Add(Me.lblNam_hoc)
        Me.GroupBox1.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(951, 63)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chọn các điều kiện nhập"
        '
        'cmbFont
        '
        Me.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFont.Location = New System.Drawing.Point(855, 20)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(89, 24)
        Me.cmbFont.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Khoá:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(61, 20)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(54, 24)
        Me.cmbKhoa_hoc.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(765, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Chọn Font"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdFontFile, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(965, 25)
        Me.ToolStrip.TabIndex = 85
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 22)
        Me.cmdSave.Text = "Lưu điểm"
        Me.cmdSave.ToolTipText = "Cập nhật"
        '
        'cmdFontFile
        '
        Me.cmdFontFile.Image = Global.ESSMarkMan.My.Resources.Resources.ChuyenLop
        Me.cmdFontFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFontFile.Name = "cmdFontFile"
        Me.cmdFontFile.Size = New System.Drawing.Size(111, 22)
        Me.cmdFontFile.Text = "Convert Font"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdViewDiem
        '
        Me.grdViewDiem.AllowUserToAddRows = False
        Me.grdViewDiem.AllowUserToDeleteRows = False
        Me.grdViewDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDiem.Location = New System.Drawing.Point(310, 97)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.ReadOnly = True
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(654, 468)
        Me.grdViewDiem.TabIndex = 87
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grdViewSinhVien
        '
        Me.grdViewSinhVien.AllowUserToAddRows = False
        Me.grdViewSinhVien.AllowUserToDeleteRows = False
        Me.grdViewSinhVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdViewSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewSinhVien.Location = New System.Drawing.Point(11, 97)
        Me.grdViewSinhVien.Name = "grdViewSinhVien"
        Me.grdViewSinhVien.ReadOnly = True
        Me.grdViewSinhVien.RowHeadersVisible = False
        Me.grdViewSinhVien.Size = New System.Drawing.Size(293, 468)
        Me.grdViewSinhVien.TabIndex = 87
        '
        'frmESS_HoTroNhapDiemTuExcel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(965, 566)
        Me.Controls.Add(Me.grdViewSinhVien)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_HoTroNhapDiemTuExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập điểm Excel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhan_tram As System.Windows.Forms.Label
    Friend WithEvents txtTy_le As System.Windows.Forms.TextBox
    Friend WithEvents lblTy_le As System.Windows.Forms.Label
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblNam_hoc As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoc_ky As System.Windows.Forms.Label
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmdFontFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbFont As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grdViewSinhVien As System.Windows.Forms.DataGridView
End Class
