<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtGio_thi = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbNhom_tiet = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkDieuKienThi = New System.Windows.Forms.CheckBox
        Me.cmbDot_thi = New System.Windows.Forms.ComboBox
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpNgay_thi = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbOrder = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnChon_phongthi = New System.Windows.Forms.Button
        Me.chkHienThiAll = New System.Windows.Forms.CheckBox
        Me.txtSo_phong = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdLopTinChi = New System.Windows.Forms.ToolStripButton
        Me.cmdSua = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdLopHC = New System.Windows.Forms.ToolStripButton
        Me.cmdAdd_sinh_vien = New System.Windows.Forms.ToolStripButton
        Me.cmdXoa_ESSsinh_vien = New System.Windows.Forms.ToolStripButton
        Me.cmdCheck_Lich_Canhan = New System.Windows.Forms.ToolStripButton
        Me.cmdLap_so_bao_danh = New System.Windows.Forms.ToolStripButton
        Me.cmdToChucThi = New System.Windows.Forms.ToolStripButton
        Me.cmdLoaiSVKDDK = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.trvMonTinChi = New ESSMarkMan.TreeViewMonTinChi
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_bao_danh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu_thi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtGio_thi)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbNhom_tiet)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbCa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkDieuKienThi)
        Me.GroupBox1.Controls.Add(Me.cmbDot_thi)
        Me.GroupBox1.Controls.Add(Me.cmbLan_thi)
        Me.GroupBox1.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbID_mon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpNgay_thi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbOrder)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnChon_phongthi)
        Me.GroupBox1.Controls.Add(Me.chkHienThiAll)
        Me.GroupBox1.Controls.Add(Me.txtSo_phong)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(266, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 168)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin tổ chức thi"
        '
        'txtGio_thi
        '
        Me.txtGio_thi.Location = New System.Drawing.Point(352, 55)
        Me.txtGio_thi.MaxLength = 200
        Me.txtGio_thi.Name = "txtGio_thi"
        Me.txtGio_thi.Size = New System.Drawing.Size(260, 23)
        Me.txtGio_thi.TabIndex = 63
        Me.txtGio_thi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(272, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Thời gian:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNhom_tiet
        '
        Me.cmbNhom_tiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhom_tiet.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbNhom_tiet.Location = New System.Drawing.Point(229, 54)
        Me.cmbNhom_tiet.Name = "cmbNhom_tiet"
        Me.cmbNhom_tiet.Size = New System.Drawing.Size(43, 24)
        Me.cmbNhom_tiet.TabIndex = 61
        Me.cmbNhom_tiet.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(153, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 24)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Nhóm tiết:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'cmbCa
        '
        Me.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCa.Items.AddRange(New Object() {"Sáng", "Chiều", "Tối"})
        Me.cmbCa.Location = New System.Drawing.Point(58, 54)
        Me.cmbCa.Name = "cmbCa"
        Me.cmbCa.Size = New System.Drawing.Size(95, 24)
        Me.cmbCa.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-2, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Ca thi:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDieuKienThi
        '
        Me.chkDieuKienThi.AutoSize = True
        Me.chkDieuKienThi.BackColor = System.Drawing.Color.Transparent
        Me.chkDieuKienThi.Location = New System.Drawing.Point(229, 113)
        Me.chkDieuKienThi.Name = "chkDieuKienThi"
        Me.chkDieuKienThi.Size = New System.Drawing.Size(323, 20)
        Me.chkDieuKienThi.TabIndex = 57
        Me.chkDieuKienThi.Text = "Loại những sinh viên không đủ điều kiện dự thi"
        Me.chkDieuKienThi.UseVisualStyleBackColor = False
        '
        'cmbDot_thi
        '
        Me.cmbDot_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbDot_thi.Location = New System.Drawing.Point(312, 21)
        Me.cmbDot_thi.Name = "cmbDot_thi"
        Me.cmbDot_thi.Size = New System.Drawing.Size(43, 24)
        Me.cmbDot_thi.TabIndex = 11
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(411, 21)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(43, 24)
        Me.cmbLan_thi.TabIndex = 1
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Enabled = False
        Me.cmbHoc_ky.Location = New System.Drawing.Point(57, 21)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(43, 24)
        Me.cmbHoc_ky.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Học kỳ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(349, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Lần thi:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Enabled = False
        Me.cmbID_mon.Location = New System.Drawing.Point(84, 84)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(528, 24)
        Me.cmbID_mon.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Học phần:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_thi
        '
        Me.dtpNgay_thi.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_thi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_thi.Location = New System.Drawing.Point(520, 22)
        Me.dtpNgay_thi.Name = "dtpNgay_thi"
        Me.dtpNgay_thi.Size = New System.Drawing.Size(92, 23)
        Me.dtpNgay_thi.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(457, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ngày thi:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Enabled = False
        Me.cmbNam_hoc.Location = New System.Drawing.Point(173, 21)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(82, 24)
        Me.cmbNam_hoc.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(102, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Năm học:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOrder
        '
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.Items.AddRange(New Object() {"Họ và tên", "Mã sinh viên", "Lớp - mã sinh viên", "Ngành - lớp - mã sinh viên", "Không sắp xếp"})
        Me.cmbOrder.Location = New System.Drawing.Point(428, 138)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(184, 24)
        Me.cmbOrder.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(335, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Sắp xếp theo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChon_phongthi
        '
        Me.btnChon_phongthi.ForeColor = System.Drawing.Color.Black
        Me.btnChon_phongthi.Image = Global.ESSMarkMan.My.Resources.Resources.PhongHoc
        Me.btnChon_phongthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChon_phongthi.Location = New System.Drawing.Point(85, 108)
        Me.btnChon_phongthi.Name = "btnChon_phongthi"
        Me.btnChon_phongthi.Size = New System.Drawing.Size(144, 30)
        Me.btnChon_phongthi.TabIndex = 7
        Me.btnChon_phongthi.Text = "Chọn phòng thi"
        Me.btnChon_phongthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkHienThiAll
        '
        Me.chkHienThiAll.AutoSize = True
        Me.chkHienThiAll.Enabled = False
        Me.chkHienThiAll.Location = New System.Drawing.Point(84, 86)
        Me.chkHienThiAll.Name = "chkHienThiAll"
        Me.chkHienThiAll.Size = New System.Drawing.Size(300, 20)
        Me.chkHienThiAll.TabIndex = 14
        Me.chkHienThiAll.Text = "Hiển thị tất cả các học phần của các học kỳ"
        Me.chkHienThiAll.UseVisualStyleBackColor = True
        Me.chkHienThiAll.Visible = False
        '
        'txtSo_phong
        '
        Me.txtSo_phong.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSo_phong.Location = New System.Drawing.Point(84, 111)
        Me.txtSo_phong.Name = "txtSo_phong"
        Me.txtSo_phong.ReadOnly = True
        Me.txtSo_phong.Size = New System.Drawing.Size(64, 23)
        Me.txtSo_phong.TabIndex = 13
        Me.txtSo_phong.Text = "0"
        Me.txtSo_phong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSo_phong.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Số phòng:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(245, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 24)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Đợt thi:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLopTinChi, Me.cmdAdd_sinh_vien, Me.cmdSua, Me.cmdSave, Me.cmdLopHC, Me.cmdXoa_ESSsinh_vien, Me.cmdCheck_Lich_Canhan, Me.cmdLap_so_bao_danh, Me.cmdToChucThi, Me.cmdLoaiSVKDDK, Me.ToolStripSeparator1, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(894, 25)
        Me.ToolStrip.TabIndex = 50
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdLopTinChi
        '
        Me.cmdLopTinChi.Image = Global.ESSMarkMan.My.Resources.Resources.PhongHoc
        Me.cmdLopTinChi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLopTinChi.Name = "cmdLopTinChi"
        Me.cmdLopTinChi.Size = New System.Drawing.Size(154, 22)
        Me.cmdLopTinChi.Text = "Hiện theo lớp tín chỉ"
        Me.cmdLopTinChi.Visible = False
        '
        'cmdSua
        '
        Me.cmdSua.Image = Global.ESSMarkMan.My.Resources.Resources.Edit
        Me.cmdSua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(132, 22)
        Me.cmdSua.Text = "Sửa thông tin thi"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(86, 22)
        Me.cmdSave.Text = "Cập nhật"
        Me.cmdSave.Visible = False
        '
        'cmdLopHC
        '
        Me.cmdLopHC.Image = Global.ESSMarkMan.My.Resources.Resources.PhongHoc
        Me.cmdLopHC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLopHC.Name = "cmdLopHC"
        Me.cmdLopHC.Size = New System.Drawing.Size(187, 22)
        Me.cmdLopHC.Text = "Hiện theo lớp hành chính"
        Me.cmdLopHC.Visible = False
        '
        'cmdAdd_sinh_vien
        '
        Me.cmdAdd_sinh_vien.Image = Global.ESSMarkMan.My.Resources.Resources.Add
        Me.cmdAdd_sinh_vien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd_sinh_vien.Name = "cmdAdd_sinh_vien"
        Me.cmdAdd_sinh_vien.Size = New System.Drawing.Size(124, 22)
        Me.cmdAdd_sinh_vien.Text = "Thêm sinh viên"
        '
        'cmdXoa_ESSsinh_vien
        '
        Me.cmdXoa_ESSsinh_vien.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdXoa_ESSsinh_vien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXoa_ESSsinh_vien.Name = "cmdXoa_ESSsinh_vien"
        Me.cmdXoa_ESSsinh_vien.Size = New System.Drawing.Size(112, 22)
        Me.cmdXoa_ESSsinh_vien.Text = "Xoá sinh viên"
        '
        'cmdCheck_Lich_Canhan
        '
        Me.cmdCheck_Lich_Canhan.Image = Global.ESSMarkMan.My.Resources.Resources.DoiChieuDuLieu
        Me.cmdCheck_Lich_Canhan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCheck_Lich_Canhan.Name = "cmdCheck_Lich_Canhan"
        Me.cmdCheck_Lich_Canhan.Size = New System.Drawing.Size(175, 20)
        Me.cmdCheck_Lich_Canhan.Text = "Kiểm tra lịch thi từng sv"
        '
        'cmdLap_so_bao_danh
        '
        Me.cmdLap_so_bao_danh.Image = Global.ESSMarkMan.My.Resources.Resources.LapSBD
        Me.cmdLap_so_bao_danh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLap_so_bao_danh.Name = "cmdLap_so_bao_danh"
        Me.cmdLap_so_bao_danh.Size = New System.Drawing.Size(135, 20)
        Me.cmdLap_so_bao_danh.Text = "Lập số báo danh"
        '
        'cmdToChucThi
        '
        Me.cmdToChucThi.Image = Global.ESSMarkMan.My.Resources.Resources.Import
        Me.cmdToChucThi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdToChucThi.Name = "cmdToChucThi"
        Me.cmdToChucThi.Size = New System.Drawing.Size(99, 20)
        Me.cmdToChucThi.Text = "Tổ chức thi"
        '
        'cmdLoaiSVKDDK
        '
        Me.cmdLoaiSVKDDK.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdLoaiSVKDDK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLoaiSVKDDK.Name = "cmdLoaiSVKDDK"
        Me.cmdLoaiSVKDDK.Size = New System.Drawing.Size(220, 20)
        Me.cmdLoaiSVKDDK.Text = "Loại SV không đủ điều kiện thi"
        Me.cmdLoaiSVKDDK.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 20)
        Me.cmdClose.Text = "Thoát"
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(826, 201)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(55, 18)
        Me.txtSo_sv.TabIndex = 55
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(663, 201)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(157, 18)
        Me.lblTong_so.TabIndex = 54
        Me.lblTong_so.Text = "Tổng số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(277, 201)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(100, 20)
        Me.chkAll.TabIndex = 56
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'trvMonTinChi
        '
        Me.trvMonTinChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMonTinChi.BackColor = System.Drawing.Color.Transparent
        Me.trvMonTinChi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvMonTinChi.Location = New System.Drawing.Point(1, 28)
        Me.trvMonTinChi.Name = "trvMonTinChi"
        Me.trvMonTinChi.Size = New System.Drawing.Size(259, 567)
        Me.trvMonTinChi.TabIndex = 57
        '
        'TreeViewLop
        '
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(1, 28)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(259, 567)
        Me.TreeViewLop.TabIndex = 3
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(266, 222)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(622, 365)
        Me.grcDanhSachThi.TabIndex = 152
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colSo_bao_danh, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTen_khoa, Me.colGhi_chu_thi})
        Me.grvDanhSachThi.GridControl = Me.grcDanhSachThi
        Me.grvDanhSachThi.Name = "grvDanhSachThi"
        Me.grvDanhSachThi.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThi.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThi.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 47
        '
        'colSo_bao_danh
        '
        Me.colSo_bao_danh.Caption = "Số báo danh"
        Me.colSo_bao_danh.FieldName = "So_bao_danh"
        Me.colSo_bao_danh.Name = "colSo_bao_danh"
        Me.colSo_bao_danh.Visible = True
        Me.colSo_bao_danh.VisibleIndex = 1
        Me.colSo_bao_danh.Width = 80
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 2
        Me.colMa_sv.Width = 80
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 3
        Me.colHo_ten.Width = 120
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.ReadOnly = True
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 4
        Me.colNgay_sinh.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 5
        Me.colTen_lop.Width = 61
        '
        'colTen_khoa
        '
        Me.colTen_khoa.Caption = "Tên khóa"
        Me.colTen_khoa.FieldName = "Ten_khoa"
        Me.colTen_khoa.Name = "colTen_khoa"
        Me.colTen_khoa.OptionsColumn.ReadOnly = True
        Me.colTen_khoa.Visible = True
        Me.colTen_khoa.VisibleIndex = 6
        Me.colTen_khoa.Width = 85
        '
        'colGhi_chu_thi
        '
        Me.colGhi_chu_thi.Caption = "Ghi chú "
        Me.colGhi_chu_thi.FieldName = "Ghi_chu_thi"
        Me.colGhi_chu_thi.Name = "colGhi_chu_thi"
        Me.colGhi_chu_thi.Visible = True
        Me.colGhi_chu_thi.VisibleIndex = 7
        Me.colGhi_chu_thi.Width = 83
        '
        'frmESS_ToChucThi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 626)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.trvMonTinChi)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmESS_ToChucThi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Tổ chức thi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSo_phong As System.Windows.Forms.TextBox
    Friend WithEvents cmbDot_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_thi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnChon_phongthi As System.Windows.Forms.Button
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdToChucThi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAdd_sinh_vien As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdXoa_ESSsinh_vien As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents cmdLap_so_bao_danh As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkHienThiAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkDieuKienThi As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLopTinChi As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLopHC As System.Windows.Forms.ToolStripButton
    Friend WithEvents trvMonTinChi As ESSMarkMan.TreeViewMonTinChi
    Friend WithEvents cmbNhom_tiet As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtGio_thi As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdSua As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCheck_Lich_Canhan As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLoaiSVKDDK As System.Windows.Forms.ToolStripButton
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_bao_danh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu_thi As DevExpress.XtraGrid.Columns.GridColumn
End Class
