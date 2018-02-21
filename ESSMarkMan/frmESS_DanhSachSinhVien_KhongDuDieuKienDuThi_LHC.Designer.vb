<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LHC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LHC))
        Me.labSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.optDanh_sach = New System.Windows.Forms.RadioButton
        Me.optHoc_phi = New System.Windows.Forms.RadioButton
        Me.optHoc_tap = New System.Windows.Forms.RadioButton
        Me.chkAll1 = New System.Windows.Forms.CheckBox
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.optHocPhi_Ky = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_do = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDanhSachKDK = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachKDK = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_do1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachKDK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachKDK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labSo_sv
        '
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(464, 307)
        Me.labSo_sv.Name = "labSo_sv"
        Me.labSo_sv.Size = New System.Drawing.Size(43, 23)
        Me.labSo_sv.TabIndex = 125
        Me.labSo_sv.Text = "0"
        Me.labSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(336, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Tống số sinh viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optDanh_sach
        '
        Me.optDanh_sach.BackColor = System.Drawing.Color.Transparent
        Me.optDanh_sach.Location = New System.Drawing.Point(500, 70)
        Me.optDanh_sach.Name = "optDanh_sach"
        Me.optDanh_sach.Size = New System.Drawing.Size(99, 24)
        Me.optDanh_sach.TabIndex = 121
        Me.optDanh_sach.Text = "Theo lớp"
        Me.optDanh_sach.UseVisualStyleBackColor = False
        '
        'optHoc_phi
        '
        Me.optHoc_phi.BackColor = System.Drawing.Color.Transparent
        Me.optHoc_phi.Location = New System.Drawing.Point(605, 70)
        Me.optHoc_phi.Name = "optHoc_phi"
        Me.optHoc_phi.Size = New System.Drawing.Size(143, 24)
        Me.optHoc_phi.TabIndex = 120
        Me.optHoc_phi.Text = "Nợ hp học phần"
        Me.optHoc_phi.UseVisualStyleBackColor = False
        '
        'optHoc_tap
        '
        Me.optHoc_tap.BackColor = System.Drawing.Color.Transparent
        Me.optHoc_tap.Checked = True
        Me.optHoc_tap.Location = New System.Drawing.Point(384, 70)
        Me.optHoc_tap.Name = "optHoc_tap"
        Me.optHoc_tap.Size = New System.Drawing.Size(109, 24)
        Me.optHoc_tap.TabIndex = 119
        Me.optHoc_tap.TabStop = True
        Me.optHoc_tap.Text = "Nợ học tập"
        Me.optHoc_tap.UseVisualStyleBackColor = False
        '
        'chkAll1
        '
        Me.chkAll1.BackColor = System.Drawing.Color.Transparent
        Me.chkAll1.Location = New System.Drawing.Point(237, 306)
        Me.chkAll1.Name = "chkAll1"
        Me.chkAll1.Size = New System.Drawing.Size(127, 24)
        Me.chkAll1.TabIndex = 118
        Me.chkAll1.Text = "Chọn tất cả "
        Me.chkAll1.UseVisualStyleBackColor = False
        '
        'chkAll
        '
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(236, 70)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(103, 24)
        Me.chkAll.TabIndex = 117
        Me.chkAll.Text = "Chọn tất cả "
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'optHocPhi_Ky
        '
        Me.optHocPhi_Ky.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optHocPhi_Ky.BackColor = System.Drawing.Color.Transparent
        Me.optHocPhi_Ky.Location = New System.Drawing.Point(663, 41)
        Me.optHocPhi_Ky.Name = "optHocPhi_Ky"
        Me.optHocPhi_Ky.Size = New System.Drawing.Size(85, 24)
        Me.optHocPhi_Ky.TabIndex = 126
        Me.optHocPhi_Ky.Text = "Nợ HP kỳ"
        Me.optHocPhi_Ky.UseVisualStyleBackColor = False
        Me.optHocPhi_Ky.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(392, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(311, 41)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(451, 24)
        Me.cmbID_mon.TabIndex = 129
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(233, 41)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 128
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(501, 10)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(109, 24)
        Me.cmbNam_hoc.TabIndex = 133
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(311, 10)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 131
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(245, 10)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 130
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(1, 3)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(226, 562)
        Me.TreeViewLop.TabIndex = 127
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(234, 100)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(557, 199)
        Me.grcDanhSachThi.TabIndex = 150
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colLy_do})
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
        Me.colChon.Width = 37
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 100
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 150
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
        Me.colNgay_sinh.VisibleIndex = 3
        Me.colNgay_sinh.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 120
        '
        'colLy_do
        '
        Me.colLy_do.Caption = "Lý do"
        Me.colLy_do.FieldName = "Ly_do"
        Me.colLy_do.Name = "colLy_do"
        Me.colLy_do.Visible = True
        Me.colLy_do.VisibleIndex = 5
        Me.colLy_do.Width = 250
        '
        'grcDanhSachKDK
        '
        Me.grcDanhSachKDK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachKDK.Location = New System.Drawing.Point(233, 333)
        Me.grcDanhSachKDK.MainView = Me.grvDanhSachKDK
        Me.grcDanhSachKDK.Name = "grcDanhSachKDK"
        Me.grcDanhSachKDK.Size = New System.Drawing.Size(557, 194)
        Me.grcDanhSachKDK.TabIndex = 151
        Me.grcDanhSachKDK.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachKDK})
        '
        'grvDanhSachKDK
        '
        Me.grvDanhSachKDK.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon1, Me.colMa_sv1, Me.colHo_ten1, Me.colNgay_sinh1, Me.colTen_lop1, Me.colLy_do1})
        Me.grvDanhSachKDK.GridControl = Me.grcDanhSachKDK
        Me.grvDanhSachKDK.Name = "grvDanhSachKDK"
        Me.grvDanhSachKDK.OptionsSelection.MultiSelect = True
        Me.grvDanhSachKDK.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachKDK.OptionsView.ShowGroupPanel = False
        '
        'colChon1
        '
        Me.colChon1.Caption = "Chọn"
        Me.colChon1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon1.FieldName = "Chon"
        Me.colChon1.Name = "colChon1"
        Me.colChon1.Visible = True
        Me.colChon1.VisibleIndex = 0
        Me.colChon1.Width = 35
        '
        'colMa_sv1
        '
        Me.colMa_sv1.Caption = "Mã SV"
        Me.colMa_sv1.FieldName = "Ma_sv"
        Me.colMa_sv1.Name = "colMa_sv1"
        Me.colMa_sv1.OptionsColumn.ReadOnly = True
        Me.colMa_sv1.Visible = True
        Me.colMa_sv1.VisibleIndex = 1
        Me.colMa_sv1.Width = 92
        '
        'colHo_ten1
        '
        Me.colHo_ten1.Caption = "Họ tên"
        Me.colHo_ten1.FieldName = "Ho_ten"
        Me.colHo_ten1.Name = "colHo_ten1"
        Me.colHo_ten1.OptionsColumn.ReadOnly = True
        Me.colHo_ten1.Visible = True
        Me.colHo_ten1.VisibleIndex = 2
        Me.colHo_ten1.Width = 139
        '
        'colNgay_sinh1
        '
        Me.colNgay_sinh1.Caption = "Ngày sinh"
        Me.colNgay_sinh1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh1.FieldName = "Ngay_sinh"
        Me.colNgay_sinh1.Name = "colNgay_sinh1"
        Me.colNgay_sinh1.OptionsColumn.ReadOnly = True
        Me.colNgay_sinh1.Visible = True
        Me.colNgay_sinh1.VisibleIndex = 3
        Me.colNgay_sinh1.Width = 111
        '
        'colTen_lop1
        '
        Me.colTen_lop1.Caption = "Tên lớp"
        Me.colTen_lop1.FieldName = "Ten_lop"
        Me.colTen_lop1.Name = "colTen_lop1"
        Me.colTen_lop1.OptionsColumn.ReadOnly = True
        Me.colTen_lop1.Visible = True
        Me.colTen_lop1.VisibleIndex = 4
        Me.colTen_lop1.Width = 139
        '
        'colLy_do1
        '
        Me.colLy_do1.Caption = "Lý do"
        Me.colLy_do1.FieldName = "Ly_do"
        Me.colLy_do1.Name = "colLy_do1"
        Me.colLy_do1.OptionsColumn.ReadOnly = True
        Me.colLy_do1.Visible = True
        Me.colLy_do1.VisibleIndex = 5
        Me.colLy_do1.Width = 250
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(634, 303)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 30)
        Me.cmdAdd.TabIndex = 152
        Me.cmdAdd.Text = "Thêm"
        '
        'ImgMain
        '
        Me.ImgMain.ImageStream = CType(resources.GetObject("ImgMain.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImgMain.Images.SetKeyName(0, "Add.png")
        Me.ImgMain.Images.SetKeyName(1, "Back.png")
        Me.ImgMain.Images.SetKeyName(2, "Bar Chart.png")
        Me.ImgMain.Images.SetKeyName(3, "Comment.png")
        Me.ImgMain.Images.SetKeyName(4, "Delete.png")
        Me.ImgMain.Images.SetKeyName(5, "Email.png")
        Me.ImgMain.Images.SetKeyName(6, "excel.ico")
        Me.ImgMain.Images.SetKeyName(7, "Exit.png")
        Me.ImgMain.Images.SetKeyName(8, "Info.png")
        Me.ImgMain.Images.SetKeyName(9, "Line Chart.png")
        Me.ImgMain.Images.SetKeyName(10, "Load.png")
        Me.ImgMain.Images.SetKeyName(11, "Loading.png")
        Me.ImgMain.Images.SetKeyName(12, "Modify.png")
        Me.ImgMain.Images.SetKeyName(13, "Next.png")
        Me.ImgMain.Images.SetKeyName(14, "Picture.png")
        Me.ImgMain.Images.SetKeyName(15, "Pie Chart.png")
        Me.ImgMain.Images.SetKeyName(16, "Print.png")
        Me.ImgMain.Images.SetKeyName(17, "Profile.png")
        Me.ImgMain.Images.SetKeyName(18, "Save.png")
        Me.ImgMain.Images.SetKeyName(19, "Search.png")
        Me.ImgMain.Images.SetKeyName(20, "Warning.png")
        Me.ImgMain.Images.SetKeyName(21, "word.ico")
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(715, 303)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 30)
        Me.cmdDelete.TabIndex = 152
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.ImageIndex = 7
        Me.cmdThoat.ImageList = Me.ImgMain
        Me.cmdThoat.Location = New System.Drawing.Point(707, 531)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(83, 31)
        Me.cmdThoat.TabIndex = 153
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(519, 531)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(93, 31)
        Me.cmdPrint.TabIndex = 154
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(618, 531)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(83, 31)
        Me.cmdExport.TabIndex = 154
        Me.cmdExport.Text = "Xuất Excel"
        '
        'frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LHC
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdThoat)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grcDanhSachKDK)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.labSo_sv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.optDanh_sach)
        Me.Controls.Add(Me.optHoc_phi)
        Me.Controls.Add(Me.optHoc_tap)
        Me.Controls.Add(Me.chkAll1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.optHocPhi_Ky)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LHC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH KHONG DU DIEU KIEN DU THI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachKDK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachKDK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optDanh_sach As System.Windows.Forms.RadioButton
    Friend WithEvents optHoc_phi As System.Windows.Forms.RadioButton
    Friend WithEvents optHoc_tap As System.Windows.Forms.RadioButton
    Friend WithEvents chkAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents optHocPhi_Ky As System.Windows.Forms.RadioButton
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_do As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDanhSachKDK As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachKDK As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_do1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
End Class
