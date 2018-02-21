<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_DangKyNganh2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdXet = New System.Windows.Forms.ToolStripButton
        Me.cmdNgungHoc = New System.Windows.Forms.ToolStripButton
        Me.cmdHocTiep = New System.Windows.Forms.ToolStripButton
        Me.cmdIn_ds = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdSuaNganh2 = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewHocChuongTrinh2 = New System.Windows.Forms.DataGridView
        Me.cmbID_nganh = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.optDangHoc = New System.Windows.Forms.RadioButton
        Me.optNgungHoc = New System.Windows.Forms.RadioButton
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chuyen_nganh2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Khoa_hoc2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop_n2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewHocChuongTrinh2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdXet, Me.cmdNgungHoc, Me.cmdHocTiep, Me.cmdIn_ds, Me.cmdDelete, Me.cmdSuaNganh2, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 101
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdXet
        '
        Me.cmdXet.Image = Global.ESSMarkMan.My.Resources.Resources.Search
        Me.cmdXet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXet.Name = "cmdXet"
        Me.cmdXet.Size = New System.Drawing.Size(131, 22)
        Me.cmdXet.Text = "Xét học ngành 2"
        Me.cmdXet.ToolTipText = "Xét tiêu chí"
        '
        'cmdNgungHoc
        '
        Me.cmdNgungHoc.Image = Global.ESSMarkMan.My.Resources.Resources.XetDuyet
        Me.cmdNgungHoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNgungHoc.Name = "cmdNgungHoc"
        Me.cmdNgungHoc.Size = New System.Drawing.Size(97, 22)
        Me.cmdNgungHoc.Text = "Ngừng học"
        '
        'cmdHocTiep
        '
        Me.cmdHocTiep.Image = Global.ESSMarkMan.My.Resources.Resources.ToChucThi
        Me.cmdHocTiep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHocTiep.Name = "cmdHocTiep"
        Me.cmdHocTiep.Size = New System.Drawing.Size(79, 22)
        Me.cmdHocTiep.Text = "Học tiếp"
        '
        'cmdIn_ds
        '
        Me.cmdIn_ds.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdIn_ds.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIn_ds.Name = "cmdIn_ds"
        Me.cmdIn_ds.Size = New System.Drawing.Size(109, 22)
        Me.cmdIn_ds.Text = "In danh sách"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(135, 22)
        Me.cmdDelete.Text = "Xoá học ngành 2"
        '
        'cmdSuaNganh2
        '
        Me.cmdSuaNganh2.Image = Global.ESSMarkMan.My.Resources.Resources.Add
        Me.cmdSuaNganh2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSuaNganh2.Name = "cmdSuaNganh2"
        Me.cmdSuaNganh2.Size = New System.Drawing.Size(166, 22)
        Me.cmdSuaNganh2.Text = "Sửa thông tin Ngành2"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdViewHocChuongTrinh2
        '
        Me.grdViewHocChuongTrinh2.AllowUserToAddRows = False
        Me.grdViewHocChuongTrinh2.AllowUserToDeleteRows = False
        Me.grdViewHocChuongTrinh2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewHocChuongTrinh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewHocChuongTrinh2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewHocChuongTrinh2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.Ma_sv, Me.Ho_ten, Me.Ten_lop, Me.Chuyen_nganh2, Me.Khoa_hoc2, Me.Ten_lop_n2})
        Me.grdViewHocChuongTrinh2.Location = New System.Drawing.Point(0, 84)
        Me.grdViewHocChuongTrinh2.Name = "grdViewHocChuongTrinh2"
        Me.grdViewHocChuongTrinh2.RowHeadersVisible = False
        Me.grdViewHocChuongTrinh2.ShowCellErrors = False
        Me.grdViewHocChuongTrinh2.ShowCellToolTips = False
        Me.grdViewHocChuongTrinh2.ShowRowErrors = False
        Me.grdViewHocChuongTrinh2.Size = New System.Drawing.Size(792, 470)
        Me.grdViewHocChuongTrinh2.TabIndex = 115
        '
        'cmbID_nganh
        '
        Me.cmbID_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nganh.Location = New System.Drawing.Point(73, 28)
        Me.cmbID_nganh.Name = "cmbID_nganh"
        Me.cmbID_nganh.Size = New System.Drawing.Size(286, 24)
        Me.cmbID_nganh.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Ngành:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(486, 28)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(297, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(376, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Chuyên ngành:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optDangHoc
        '
        Me.optDangHoc.AutoSize = True
        Me.optDangHoc.BackColor = System.Drawing.Color.Transparent
        Me.optDangHoc.Checked = True
        Me.optDangHoc.Location = New System.Drawing.Point(78, 58)
        Me.optDangHoc.Name = "optDangHoc"
        Me.optDangHoc.Size = New System.Drawing.Size(87, 20)
        Me.optDangHoc.TabIndex = 124
        Me.optDangHoc.TabStop = True
        Me.optDangHoc.Text = "Đang học"
        Me.optDangHoc.UseVisualStyleBackColor = False
        '
        'optNgungHoc
        '
        Me.optNgungHoc.AutoSize = True
        Me.optNgungHoc.BackColor = System.Drawing.Color.Transparent
        Me.optNgungHoc.Location = New System.Drawing.Point(672, 58)
        Me.optNgungHoc.Name = "optNgungHoc"
        Me.optNgungHoc.Size = New System.Drawing.Size(95, 20)
        Me.optNgungHoc.TabIndex = 125
        Me.optNgungHoc.Text = "Ngừng học"
        Me.optNgungHoc.UseVisualStyleBackColor = False
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.MinimumWidth = 50
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.Width = 50
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ma_sv.HeaderText = "Mã sv"
        Me.Ma_sv.MinimumWidth = 100
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Họ tên"
        Me.Ho_ten.MinimumWidth = 200
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 200
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ten_lop.HeaderText = "Lớp ngành 1"
        Me.Ten_lop.MinimumWidth = 80
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 80
        '
        'Chuyen_nganh2
        '
        Me.Chuyen_nganh2.DataPropertyName = "Chuyen_nganh2"
        Me.Chuyen_nganh2.HeaderText = "Chuyên ngành-ngành 2"
        Me.Chuyen_nganh2.MinimumWidth = 200
        Me.Chuyen_nganh2.Name = "Chuyen_nganh2"
        Me.Chuyen_nganh2.ReadOnly = True
        Me.Chuyen_nganh2.Width = 200
        '
        'Khoa_hoc2
        '
        Me.Khoa_hoc2.DataPropertyName = "Khoa_hoc2"
        Me.Khoa_hoc2.HeaderText = "Khóa học ngành 2"
        Me.Khoa_hoc2.MinimumWidth = 100
        Me.Khoa_hoc2.Name = "Khoa_hoc2"
        '
        'Ten_lop_n2
        '
        Me.Ten_lop_n2.DataPropertyName = "Ten_lop_n2"
        Me.Ten_lop_n2.HeaderText = "Tên lớp ngành 2"
        Me.Ten_lop_n2.MinimumWidth = 80
        Me.Ten_lop_n2.Name = "Ten_lop_n2"
        Me.Ten_lop_n2.Width = 80
        '
        'frmESS_DanhSachSinhVien_DangKyNganh2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.optNgungHoc)
        Me.Controls.Add(Me.optDangHoc)
        Me.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_nganh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdViewHocChuongTrinh2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_DanhSachSinhVien_DangKyNganh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách sinh viên ngành 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewHocChuongTrinh2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdXet As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdIn_ds As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewHocChuongTrinh2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdHocTiep As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbID_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents optDangHoc As System.Windows.Forms.RadioButton
    Friend WithEvents optNgungHoc As System.Windows.Forms.RadioButton
    Friend WithEvents cmdNgungHoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSuaNganh2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chuyen_nganh2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Khoa_hoc2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop_n2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
