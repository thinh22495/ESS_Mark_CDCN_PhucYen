<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_NoTotNghiepKhac
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.txtNoi_thuctap = New System.Windows.Forms.TextBox
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewNoTotNghiepKhac = New System.Windows.Forms.DataGridView
        Me.Chon1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_sv1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ly_do = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewNoTotNghiepKhac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 32
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSMarkMan.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'TreeViewLop
        '
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(0, 28)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(264, 538)
        Me.TreeViewLop.TabIndex = 90
        '
        'txtNoi_thuctap
        '
        Me.txtNoi_thuctap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoi_thuctap.Location = New System.Drawing.Point(359, 29)
        Me.txtNoi_thuctap.Name = "txtNoi_thuctap"
        Me.txtNoi_thuctap.Size = New System.Drawing.Size(421, 23)
        Me.txtNoi_thuctap.TabIndex = 92
        '
        'optAll1
        '
        Me.optAll1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(308, 58)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(124, 24)
        Me.optAll1.TabIndex = 96
        Me.optAll1.Text = "Chọn tất cả "
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(308, 304)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(124, 24)
        Me.optAll.TabIndex = 95
        Me.optAll.Text = "Chọn tất cả "
        Me.optAll.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Brown
        Me.btnAdd.Image = Global.ESSMarkMan.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(643, 303)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 25)
        Me.btnAdd.TabIndex = 94
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Brown
        Me.btnDel.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(715, 303)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(65, 25)
        Me.btnDel.TabIndex = 93
        Me.btnDel.Text = "Xoá"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(270, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Lý do"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop})
        Me.grdViewDanhSach.Location = New System.Drawing.Point(265, 85)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdViewDanhSach.RowHeadersWidth = 30
        Me.grdViewDanhSach.Size = New System.Drawing.Size(527, 213)
        Me.grdViewDanhSach.TabIndex = 104
        '
        'Chon
        '
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Width = 50
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ma_sv.HeaderText = "Mã sinh viên"
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.Width = 90
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.Width = 175
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.Width = 70
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Width = 85
        '
        'grdViewNoTotNghiepKhac
        '
        Me.grdViewNoTotNghiepKhac.AllowUserToAddRows = False
        Me.grdViewNoTotNghiepKhac.AllowUserToDeleteRows = False
        Me.grdViewNoTotNghiepKhac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewNoTotNghiepKhac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewNoTotNghiepKhac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewNoTotNghiepKhac.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdViewNoTotNghiepKhac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewNoTotNghiepKhac.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon1, Me.Ma_sv1, Me.Ho_ten1, Me.Ngay_sinh1, Me.Ten_lop1, Me.Ly_do})
        Me.grdViewNoTotNghiepKhac.Location = New System.Drawing.Point(265, 334)
        Me.grdViewNoTotNghiepKhac.Name = "grdViewNoTotNghiepKhac"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewNoTotNghiepKhac.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdViewNoTotNghiepKhac.RowHeadersWidth = 30
        Me.grdViewNoTotNghiepKhac.Size = New System.Drawing.Size(527, 232)
        Me.grdViewNoTotNghiepKhac.TabIndex = 105
        '
        'Chon1
        '
        Me.Chon1.DataPropertyName = "Chon"
        Me.Chon1.HeaderText = "Chọn"
        Me.Chon1.Name = "Chon1"
        Me.Chon1.Width = 50
        '
        'Ma_sv1
        '
        Me.Ma_sv1.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ma_sv1.HeaderText = "Mã sinh viên"
        Me.Ma_sv1.Name = "Ma_sv1"
        Me.Ma_sv1.Width = 90
        '
        'Ho_ten1
        '
        Me.Ho_ten1.DataPropertyName = "Ho_ten"
        Me.Ho_ten1.HeaderText = "Họ và tên"
        Me.Ho_ten1.Name = "Ho_ten1"
        Me.Ho_ten1.Width = 175
        '
        'Ngay_sinh1
        '
        Me.Ngay_sinh1.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "dd/MM/yyyy"
        Me.Ngay_sinh1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Ngay_sinh1.HeaderText = "Ngày sinh"
        Me.Ngay_sinh1.Name = "Ngay_sinh1"
        Me.Ngay_sinh1.Width = 70
        '
        'Ten_lop1
        '
        Me.Ten_lop1.DataPropertyName = "Ten_lop"
        Me.Ten_lop1.HeaderText = "Tên lớp"
        Me.Ten_lop1.Name = "Ten_lop1"
        Me.Ten_lop1.Width = 85
        '
        'Ly_do
        '
        Me.Ly_do.DataPropertyName = "Ly_do"
        Me.Ly_do.HeaderText = "Lý do nợ"
        Me.Ly_do.Name = "Ly_do"
        Me.Ly_do.Width = 300
        '
        'frmESS_DanhSachNoTotNghiepKhac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grdViewNoTotNghiepKhac)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.txtNoi_thuctap)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_DanhSachNoTotNghiepKhac"
        Me.Text = "DANH SACH NO TOT NGHIEP"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewNoTotNghiepKhac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents txtNoi_thuctap As System.Windows.Forms.TextBox
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdViewNoTotNghiepKhac As System.Windows.Forms.DataGridView
    Friend WithEvents Chon1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_sv1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ly_do As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
