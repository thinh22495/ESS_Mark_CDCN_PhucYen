﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_PhanCongThucTap
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewNoiThucTap = New System.Windows.Forms.DataGridView
        Me.Chon1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_noi_thuc_tap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_noi_thuc_tap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_thuc_tap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dia_chi_thuc_tap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.cmbNoiThucTap = New System.Windows.Forms.ComboBox
        Me.lblMasv = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.lblHoTen = New System.Windows.Forms.Label
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewNoiThucTap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(266, 35)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(102, 19)
        Me.optAll1.TabIndex = 96
        Me.optAll1.Text = "Chọn tất cả "
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(270, 310)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(102, 24)
        Me.optAll.TabIndex = 95
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(372, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 24)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Địa điểm:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.grdViewDanhSach.Location = New System.Drawing.Point(265, 65)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdViewDanhSach.RowHeadersWidth = 30
        Me.grdViewDanhSach.Size = New System.Drawing.Size(541, 242)
        Me.grdViewDanhSach.TabIndex = 104
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.MinimumWidth = 50
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.Width = 50
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ma_sv.HeaderText = "Mã sv"
        Me.Ma_sv.MinimumWidth = 130
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        Me.Ma_sv.Width = 130
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.MinimumWidth = 300
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 300
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.MinimumWidth = 95
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        Me.Ngay_sinh.Width = 95
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 100
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        '
        'grdViewNoiThucTap
        '
        Me.grdViewNoiThucTap.AllowUserToAddRows = False
        Me.grdViewNoiThucTap.AllowUserToDeleteRows = False
        Me.grdViewNoiThucTap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewNoiThucTap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewNoiThucTap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewNoiThucTap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdViewNoiThucTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewNoiThucTap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon1, Me.Ma_sv2, Me.Ho_ten2, Me.Ten_lop2, Me.ID_noi_thuc_tap, Me.Ma_noi_thuc_tap, Me.Noi_thuc_tap, Me.Dia_chi_thuc_tap})
        Me.grdViewNoiThucTap.Location = New System.Drawing.Point(265, 337)
        Me.grdViewNoiThucTap.Name = "grdViewNoiThucTap"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewNoiThucTap.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdViewNoiThucTap.RowHeadersWidth = 30
        Me.grdViewNoiThucTap.Size = New System.Drawing.Size(541, 227)
        Me.grdViewNoiThucTap.TabIndex = 105
        '
        'Chon1
        '
        Me.Chon1.DataPropertyName = "Chon1"
        Me.Chon1.HeaderText = "Chọn"
        Me.Chon1.MinimumWidth = 50
        Me.Chon1.Name = "Chon1"
        Me.Chon1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon1.Width = 50
        '
        'Ma_sv2
        '
        Me.Ma_sv2.DataPropertyName = "Ma_sv2"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv2.DefaultCellStyle = DataGridViewCellStyle7
        Me.Ma_sv2.HeaderText = "Mã sv"
        Me.Ma_sv2.MinimumWidth = 100
        Me.Ma_sv2.Name = "Ma_sv2"
        Me.Ma_sv2.ReadOnly = True
        Me.Ma_sv2.Width = 130
        '
        'Ho_ten2
        '
        Me.Ho_ten2.DataPropertyName = "Ho_ten2"
        Me.Ho_ten2.HeaderText = "Họ và tên"
        Me.Ho_ten2.MinimumWidth = 200
        Me.Ho_ten2.Name = "Ho_ten2"
        Me.Ho_ten2.ReadOnly = True
        Me.Ho_ten2.Width = 200
        '
        'Ten_lop2
        '
        Me.Ten_lop2.DataPropertyName = "Ten_lop2"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop2.DefaultCellStyle = DataGridViewCellStyle8
        Me.Ten_lop2.HeaderText = "Tên lớp"
        Me.Ten_lop2.MinimumWidth = 90
        Me.Ten_lop2.Name = "Ten_lop2"
        Me.Ten_lop2.ReadOnly = True
        Me.Ten_lop2.Width = 90
        '
        'ID_noi_thuc_tap
        '
        Me.ID_noi_thuc_tap.DataPropertyName = "ID_noi_thuc_tap"
        Me.ID_noi_thuc_tap.HeaderText = "ID_noi_thuc_tap"
        Me.ID_noi_thuc_tap.Name = "ID_noi_thuc_tap"
        Me.ID_noi_thuc_tap.Visible = False
        '
        'Ma_noi_thuc_tap
        '
        Me.Ma_noi_thuc_tap.DataPropertyName = "Ma_noi_thuc_tap"
        Me.Ma_noi_thuc_tap.HeaderText = "Ma_noi_thuc_tap"
        Me.Ma_noi_thuc_tap.Name = "Ma_noi_thuc_tap"
        Me.Ma_noi_thuc_tap.Visible = False
        '
        'Noi_thuc_tap
        '
        Me.Noi_thuc_tap.DataPropertyName = "Noi_thuc_tap"
        Me.Noi_thuc_tap.HeaderText = "Nơi thực tập"
        Me.Noi_thuc_tap.MinimumWidth = 250
        Me.Noi_thuc_tap.Name = "Noi_thuc_tap"
        Me.Noi_thuc_tap.ReadOnly = True
        Me.Noi_thuc_tap.Width = 250
        '
        'Dia_chi_thuc_tap
        '
        Me.Dia_chi_thuc_tap.DataPropertyName = "Dia_chi_thuc_tap"
        Me.Dia_chi_thuc_tap.HeaderText = "Địa chỉ"
        Me.Dia_chi_thuc_tap.MinimumWidth = 100
        Me.Dia_chi_thuc_tap.Name = "Dia_chi_thuc_tap"
        Me.Dia_chi_thuc_tap.ReadOnly = True
        Me.Dia_chi_thuc_tap.Width = 200
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(806, 25)
        Me.ToolStrip.TabIndex = 32
        Me.ToolStrip.Text = "ToolStrip1"
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(655, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 20)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Brown
        Me.btnAdd.Image = Global.ESSMarkMan.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(680, 310)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 25)
        Me.btnAdd.TabIndex = 94
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Brown
        Me.btnDel.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(743, 310)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(58, 25)
        Me.btnDel.TabIndex = 93
        Me.btnDel.Text = "Xoá"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'cmbNoiThucTap
        '
        Me.cmbNoiThucTap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNoiThucTap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNoiThucTap.FormattingEnabled = True
        Me.cmbNoiThucTap.Location = New System.Drawing.Point(441, 310)
        Me.cmbNoiThucTap.Name = "cmbNoiThucTap"
        Me.cmbNoiThucTap.Size = New System.Drawing.Size(207, 24)
        Me.cmbNoiThucTap.TabIndex = 107
        '
        'lblMasv
        '
        Me.lblMasv.AutoSize = True
        Me.lblMasv.BackColor = System.Drawing.Color.Transparent
        Me.lblMasv.Location = New System.Drawing.Point(372, 36)
        Me.lblMasv.Name = "lblMasv"
        Me.lblMasv.Size = New System.Drawing.Size(91, 16)
        Me.lblMasv.TabIndex = 108
        Me.lblMasv.Text = "Mã sinh viên:"
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(465, 33)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(100, 23)
        Me.txtMa_sv.TabIndex = 109
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.BackColor = System.Drawing.Color.Transparent
        Me.lblHoTen.Location = New System.Drawing.Point(575, 36)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(53, 16)
        Me.lblHoTen.TabIndex = 108
        Me.lblHoTen.Text = "Họ tên:"
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Location = New System.Drawing.Point(624, 33)
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(170, 23)
        Me.txtHo_ten.TabIndex = 109
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(0, 28)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(264, 538)
        Me.TreeViewLop.TabIndex = 90
        '
        'frmESS_PhanCongThucTap
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(806, 566)
        Me.Controls.Add(Me.txtHo_ten)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.lblMasv)
        Me.Controls.Add(Me.cmbNoiThucTap)
        Me.Controls.Add(Me.grdViewNoiThucTap)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optAll1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_PhanCongThucTap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phân công thực tập"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewNoiThucTap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewNoiThucTap As System.Windows.Forms.DataGridView
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents cmbNoiThucTap As System.Windows.Forms.ComboBox
    Friend WithEvents Chon1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_noi_thuc_tap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_noi_thuc_tap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_thuc_tap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dia_chi_thuc_tap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMasv As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents lblHoTen As System.Windows.Forms.Label
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
End Class
