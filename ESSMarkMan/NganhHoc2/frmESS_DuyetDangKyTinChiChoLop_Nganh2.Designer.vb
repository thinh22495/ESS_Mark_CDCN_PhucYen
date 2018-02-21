<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DuyetDangKyTinChiChoLop_Nganh2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DuyetDangKyTinChiChoLop_Nganh2))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSo_mon = New System.Windows.Forms.Label
        Me.lblSo_hoc_trinh = New System.Windows.Forms.Label
        Me.cbChon = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbNgoai_ngu = New System.Windows.Forms.ComboBox
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnDuyet = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcHocPhanDangKy = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhanDangKy = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDuyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop_tc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHoc_lai1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colThoi_gian1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_phong1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGiao_vien1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRut_bot_hoc_phan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint_All = New DevExpress.XtraEditors.SimpleButton
        Me.EssToolBarTC1 = New ESSMarkMan.ESSToolBarTC
        Me.TreeViewLop_ChuanHoa1 = New ESSMarkMan.TreeViewLop_ChuanHoa
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTrang_thai_duyet = New System.Windows.Forms.ComboBox
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhanDangKy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhanDangKy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(826, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Số học phần:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(948, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Số tín chỉ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_mon
        '
        Me.lblSo_mon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_mon.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon.Location = New System.Drawing.Point(921, 265)
        Me.lblSo_mon.Name = "lblSo_mon"
        Me.lblSo_mon.Size = New System.Drawing.Size(27, 24)
        Me.lblSo_mon.TabIndex = 60
        Me.lblSo_mon.Text = "0"
        Me.lblSo_mon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_hoc_trinh
        '
        Me.lblSo_hoc_trinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_hoc_trinh.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_hoc_trinh.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_hoc_trinh.Location = New System.Drawing.Point(1020, 265)
        Me.lblSo_hoc_trinh.Name = "lblSo_hoc_trinh"
        Me.lblSo_hoc_trinh.Size = New System.Drawing.Size(40, 24)
        Me.lblSo_hoc_trinh.TabIndex = 61
        Me.lblSo_hoc_trinh.Text = "0"
        Me.lblSo_hoc_trinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbChon
        '
        Me.cbChon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbChon.AutoSize = True
        Me.cbChon.BackColor = System.Drawing.Color.Transparent
        Me.cbChon.Location = New System.Drawing.Point(272, 269)
        Me.cbChon.Name = "cbChon"
        Me.cbChon.Size = New System.Drawing.Size(100, 20)
        Me.cbChon.TabIndex = 151
        Me.cbChon.Text = "Chọn tất cả"
        Me.cbChon.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(928, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Ngoại ngữ:"
        '
        'cmbNgoai_ngu
        '
        Me.cmbNgoai_ngu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNgoai_ngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNgoai_ngu.ItemHeight = 16
        Me.cmbNgoai_ngu.Items.AddRange(New Object() {"Tiếng Anh", "Tiếng Nga", "Tiếng Pháp", "Tiếng Trung"})
        Me.cmbNgoai_ngu.Location = New System.Drawing.Point(1011, 36)
        Me.cmbNgoai_ngu.Name = "cmbNgoai_ngu"
        Me.cmbNgoai_ngu.Size = New System.Drawing.Size(109, 24)
        Me.cmbNgoai_ngu.TabIndex = 145
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
        'btnDuyet
        '
        Me.btnDuyet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDuyet.ImageIndex = 0
        Me.btnDuyet.ImageList = Me.ImgMain
        Me.btnDuyet.Location = New System.Drawing.Point(375, 257)
        Me.btnDuyet.Name = "btnDuyet"
        Me.btnDuyet.Size = New System.Drawing.Size(109, 30)
        Me.btnDuyet.TabIndex = 174
        Me.btnDuyet.Text = "Duyệt đăng ký"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(231, 65)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(889, 188)
        Me.grcDanhSach.TabIndex = 180
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDanhSach.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvDanhSach.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDanhSach.Appearance.Row.Options.UseFont = True
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 50
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 245
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 370
        '
        'grcHocPhanDangKy
        '
        Me.grcHocPhanDangKy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhanDangKy.Location = New System.Drawing.Point(231, 286)
        Me.grcHocPhanDangKy.MainView = Me.grvHocPhanDangKy
        Me.grcHocPhanDangKy.Name = "grcHocPhanDangKy"
        Me.grcHocPhanDangKy.Size = New System.Drawing.Size(889, 278)
        Me.grcHocPhanDangKy.TabIndex = 182
        Me.grcHocPhanDangKy.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhanDangKy})
        '
        'grvHocPhanDangKy
        '
        Me.grvHocPhanDangKy.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvHocPhanDangKy.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvHocPhanDangKy.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvHocPhanDangKy.Appearance.Row.Options.UseFont = True
        Me.grvHocPhanDangKy.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDuyet, Me.colTen_mon1, Me.colTen_lop_tc1, Me.colSo_hoc_trinh1, Me.colHoc_lai1, Me.colThoi_gian1, Me.colTen_phong1, Me.colGiao_vien1, Me.colRut_bot_hoc_phan})
        Me.grvHocPhanDangKy.GridControl = Me.grcHocPhanDangKy
        Me.grvHocPhanDangKy.Name = "grvHocPhanDangKy"
        Me.grvHocPhanDangKy.OptionsSelection.MultiSelect = True
        Me.grvHocPhanDangKy.OptionsView.ShowGroupPanel = False
        '
        'colDuyet
        '
        Me.colDuyet.Caption = "Duyệt"
        Me.colDuyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDuyet.FieldName = "Duyet"
        Me.colDuyet.Name = "colDuyet"
        Me.colDuyet.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colDuyet.Visible = True
        Me.colDuyet.VisibleIndex = 0
        Me.colDuyet.Width = 50
        '
        'colTen_mon1
        '
        Me.colTen_mon1.Caption = "Tên học phần"
        Me.colTen_mon1.FieldName = "Ten_mon"
        Me.colTen_mon1.Name = "colTen_mon1"
        Me.colTen_mon1.OptionsColumn.ReadOnly = True
        Me.colTen_mon1.Visible = True
        Me.colTen_mon1.VisibleIndex = 1
        Me.colTen_mon1.Width = 200
        '
        'colTen_lop_tc1
        '
        Me.colTen_lop_tc1.Caption = "Tên lớp tín chỉ"
        Me.colTen_lop_tc1.FieldName = "Ten_lop_tc"
        Me.colTen_lop_tc1.Name = "colTen_lop_tc1"
        Me.colTen_lop_tc1.OptionsColumn.ReadOnly = True
        Me.colTen_lop_tc1.Visible = True
        Me.colTen_lop_tc1.VisibleIndex = 2
        Me.colTen_lop_tc1.Width = 92
        '
        'colSo_hoc_trinh1
        '
        Me.colSo_hoc_trinh1.Caption = "Số tín chỉ"
        Me.colSo_hoc_trinh1.FieldName = "So_tin_chi"
        Me.colSo_hoc_trinh1.Name = "colSo_hoc_trinh1"
        Me.colSo_hoc_trinh1.OptionsColumn.ReadOnly = True
        Me.colSo_hoc_trinh1.Visible = True
        Me.colSo_hoc_trinh1.VisibleIndex = 3
        Me.colSo_hoc_trinh1.Width = 41
        '
        'colHoc_lai1
        '
        Me.colHoc_lai1.Caption = "Học lại"
        Me.colHoc_lai1.FieldName = "Hoc_lai"
        Me.colHoc_lai1.Name = "colHoc_lai1"
        Me.colHoc_lai1.OptionsColumn.ReadOnly = True
        Me.colHoc_lai1.Visible = True
        Me.colHoc_lai1.VisibleIndex = 4
        Me.colHoc_lai1.Width = 41
        '
        'colThoi_gian1
        '
        Me.colThoi_gian1.Caption = "Thời gian"
        Me.colThoi_gian1.FieldName = "Thoi_gian"
        Me.colThoi_gian1.Name = "colThoi_gian1"
        Me.colThoi_gian1.OptionsColumn.ReadOnly = True
        Me.colThoi_gian1.Visible = True
        Me.colThoi_gian1.VisibleIndex = 5
        Me.colThoi_gian1.Width = 134
        '
        'colTen_phong1
        '
        Me.colTen_phong1.Caption = "Tên phòng"
        Me.colTen_phong1.FieldName = "Ten_phong"
        Me.colTen_phong1.Name = "colTen_phong1"
        Me.colTen_phong1.OptionsColumn.ReadOnly = True
        Me.colTen_phong1.Visible = True
        Me.colTen_phong1.VisibleIndex = 6
        Me.colTen_phong1.Width = 80
        '
        'colGiao_vien1
        '
        Me.colGiao_vien1.Caption = "Giáo viên"
        Me.colGiao_vien1.FieldName = "Ho_ten"
        Me.colGiao_vien1.Name = "colGiao_vien1"
        Me.colGiao_vien1.OptionsColumn.ReadOnly = True
        Me.colGiao_vien1.Visible = True
        Me.colGiao_vien1.VisibleIndex = 7
        Me.colGiao_vien1.Width = 71
        '
        'colRut_bot_hoc_phan
        '
        Me.colRut_bot_hoc_phan.Caption = "Rút HP"
        Me.colRut_bot_hoc_phan.FieldName = "Rut_bot_hoc_phan"
        Me.colRut_bot_hoc_phan.Name = "colRut_bot_hoc_phan"
        Me.colRut_bot_hoc_phan.OptionsColumn.ReadOnly = True
        Me.colRut_bot_hoc_phan.Visible = True
        Me.colRut_bot_hoc_phan.VisibleIndex = 8
        Me.colRut_bot_hoc_phan.Width = 50
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(491, 257)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(126, 30)
        Me.cmdPrint.TabIndex = 183
        Me.cmdPrint.Text = "In phiếu đăng ký"
        '
        'cmdPrint_All
        '
        Me.cmdPrint_All.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint_All.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint_All.Appearance.Options.UseFont = True
        Me.cmdPrint_All.ImageIndex = 16
        Me.cmdPrint_All.ImageList = Me.ImgMain
        Me.cmdPrint_All.Location = New System.Drawing.Point(0, 35)
        Me.cmdPrint_All.Name = "cmdPrint_All"
        Me.cmdPrint_All.Size = New System.Drawing.Size(140, 30)
        Me.cmdPrint_All.TabIndex = 184
        Me.cmdPrint_All.Text = "In KQ đăng ký lớp"
        Me.cmdPrint_All.Visible = False
        '
        'EssToolBarTC1
        '
        Me.EssToolBarTC1.BackColor = System.Drawing.SystemColors.Control
        Me.EssToolBarTC1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EssToolBarTC1.Location = New System.Drawing.Point(0, 0)
        Me.EssToolBarTC1.Name = "EssToolBarTC1"
        Me.EssToolBarTC1.Size = New System.Drawing.Size(1114, 33)
        Me.EssToolBarTC1.TabIndex = 185
        '
        'TreeViewLop_ChuanHoa1
        '
        Me.TreeViewLop_ChuanHoa1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop_ChuanHoa1.dtLop = Nothing
        Me.TreeViewLop_ChuanHoa1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop_ChuanHoa1.Location = New System.Drawing.Point(-9, 28)
        Me.TreeViewLop_ChuanHoa1.Name = "TreeViewLop_ChuanHoa1"
        Me.TreeViewLop_ChuanHoa1.Size = New System.Drawing.Size(238, 550)
        Me.TreeViewLop_ChuanHoa1.TabIndex = 186
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(283, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Trạng thái duyệt:"
        '
        'cmbTrang_thai_duyet
        '
        Me.cmbTrang_thai_duyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrang_thai_duyet.ItemHeight = 16
        Me.cmbTrang_thai_duyet.Items.AddRange(New Object() {"Đã duyệt", "Chưa duyệt"})
        Me.cmbTrang_thai_duyet.Location = New System.Drawing.Point(404, 35)
        Me.cmbTrang_thai_duyet.Name = "cmbTrang_thai_duyet"
        Me.cmbTrang_thai_duyet.Size = New System.Drawing.Size(152, 24)
        Me.cmbTrang_thai_duyet.TabIndex = 188
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.AutoSize = True
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(784, 40)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(42, 16)
        Me.lblSo_sv.TabIndex = 189
        Me.lblSo_sv.Text = "So sv"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageIndex = 0
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(1011, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 30)
        Me.SimpleButton1.TabIndex = 190
        Me.SimpleButton1.Text = "Duyệt đăng ký"
        Me.SimpleButton1.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(623, 257)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(109, 30)
        Me.cmdDelete.TabIndex = 191
        Me.cmdDelete.Text = "Xóa lớp đăng ký"
        Me.cmdDelete.Visible = False
        '
        'frmESS_DuyetDangKyTinChiChoLop_Nganh2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1123, 566)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTrang_thai_duyet)
        Me.Controls.Add(Me.TreeViewLop_ChuanHoa1)
        Me.Controls.Add(Me.EssToolBarTC1)
        Me.Controls.Add(Me.cmdPrint_All)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.grcHocPhanDangKy)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.btnDuyet)
        Me.Controls.Add(Me.cbChon)
        Me.Controls.Add(Me.lblSo_hoc_trinh)
        Me.Controls.Add(Me.lblSo_mon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbNgoai_ngu)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_DuyetDangKyTinChiChoLop_Nganh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DUYET DANG KY LOP TIN CHI CHO LOP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhanDangKy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhanDangKy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon As System.Windows.Forms.Label
    Friend WithEvents lblSo_hoc_trinh As System.Windows.Forms.Label
    Friend WithEvents cbChon As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbNgoai_ngu As System.Windows.Forms.ComboBox
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents btnDuyet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcHocPhanDangKy As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhanDangKy As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDuyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoc_lai1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop_tc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThoi_gian1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiao_vien1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_phong1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRut_bot_hoc_phan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint_All As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EssToolBarTC1 As ESSMarkMan.ESSToolBarTC
    Friend WithEvents TreeViewLop_ChuanHoa1 As ESSMarkMan.TreeViewLop_ChuanHoa
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTrang_thai_duyet As System.Windows.Forms.ComboBox
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
End Class
