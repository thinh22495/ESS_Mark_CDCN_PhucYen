<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DangKyLopHocPhan_TinChiChoSinhVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DangKyLopHocPhan_TinChiChoSinhVien))
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSo_mon = New System.Windows.Forms.Label
        Me.lblSo_hoc_trinh = New System.Windows.Forms.Label
        Me.lblSo_tien_nop = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSo_hoc_trinh_max = New System.Windows.Forms.Label
        Me.lblSo_hoc_trinh_min = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblHo_ten = New System.Windows.Forms.Label
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grcHocPhan = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop_tc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colThoi_gian = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_phong = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHoc_lai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCon_trong = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcHocPhanDangKy = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhanDangKy = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHoc_lai1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop_tc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colThoi_gian1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGiao_vien1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_phong1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCon_trong1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdDangKy = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdHuyDangKy = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRut_HP = New DevExpress.XtraEditors.SimpleButton
        Me.EssToolBarTC1 = New ESSMarkMan.ESSToolBarTC
        Me.lblLop = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhanDangKy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhanDangKy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMa_sv.Location = New System.Drawing.Point(754, 41)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(140, 22)
        Me.txtMa_sv.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(4, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Số học phần:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(144, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Số tín chỉ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_mon
        '
        Me.lblSo_mon.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon.Location = New System.Drawing.Point(101, 354)
        Me.lblSo_mon.Name = "lblSo_mon"
        Me.lblSo_mon.Size = New System.Drawing.Size(35, 24)
        Me.lblSo_mon.TabIndex = 60
        Me.lblSo_mon.Text = "0"
        Me.lblSo_mon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_hoc_trinh
        '
        Me.lblSo_hoc_trinh.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_hoc_trinh.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_hoc_trinh.Location = New System.Drawing.Point(224, 354)
        Me.lblSo_hoc_trinh.Name = "lblSo_hoc_trinh"
        Me.lblSo_hoc_trinh.Size = New System.Drawing.Size(39, 24)
        Me.lblSo_hoc_trinh.TabIndex = 61
        Me.lblSo_hoc_trinh.Text = "0"
        Me.lblSo_hoc_trinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_tien_nop
        '
        Me.lblSo_tien_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_tien_nop.Location = New System.Drawing.Point(393, 354)
        Me.lblSo_tien_nop.Name = "lblSo_tien_nop"
        Me.lblSo_tien_nop.Size = New System.Drawing.Size(115, 24)
        Me.lblSo_tien_nop.TabIndex = 65
        Me.lblSo_tien_nop.Text = "0"
        Me.lblSo_tien_nop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(271, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 24)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Số tiền phải nộp:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_hoc_trinh_max
        '
        Me.lblSo_hoc_trinh_max.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_hoc_trinh_max.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_hoc_trinh_max.Location = New System.Drawing.Point(269, 38)
        Me.lblSo_hoc_trinh_max.Name = "lblSo_hoc_trinh_max"
        Me.lblSo_hoc_trinh_max.Size = New System.Drawing.Size(33, 24)
        Me.lblSo_hoc_trinh_max.TabIndex = 69
        Me.lblSo_hoc_trinh_max.Text = "0"
        Me.lblSo_hoc_trinh_max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_hoc_trinh_min
        '
        Me.lblSo_hoc_trinh_min.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_hoc_trinh_min.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_hoc_trinh_min.Location = New System.Drawing.Point(130, 38)
        Me.lblSo_hoc_trinh_min.Name = "lblSo_hoc_trinh_min"
        Me.lblSo_hoc_trinh_min.Size = New System.Drawing.Size(35, 24)
        Me.lblSo_hoc_trinh_min.TabIndex = 68
        Me.lblSo_hoc_trinh_min.Text = "0"
        Me.lblSo_hoc_trinh_min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(167, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 24)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Số TC tối đa:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(6, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 24)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Số TC tối thiểu:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(291, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 24)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Họ tên:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHo_ten
        '
        Me.lblHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.lblHo_ten.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHo_ten.Location = New System.Drawing.Point(330, 38)
        Me.lblHo_ten.Name = "lblHo_ten"
        Me.lblHo_ten.Size = New System.Drawing.Size(164, 24)
        Me.lblHo_ten.TabIndex = 138
        Me.lblHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'grcHocPhan
        '
        Me.grcHocPhan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhan.Location = New System.Drawing.Point(1, 67)
        Me.grcHocPhan.MainView = Me.grvHocPhan
        Me.grcHocPhan.Name = "grcHocPhan"
        Me.grcHocPhan.Size = New System.Drawing.Size(982, 281)
        Me.grcHocPhan.TabIndex = 149
        Me.grcHocPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhan})
        '
        'grvHocPhan
        '
        Me.grvHocPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colKy_hieu, Me.colTen_mon, Me.colTen_lop_tc, Me.colSo_hoc_trinh, Me.colThoi_gian, Me.colTen_phong, Me.colHo_ten, Me.colHoc_lai, Me.colCon_trong})
        Me.grvHocPhan.GridControl = Me.grcHocPhan
        Me.grvHocPhan.Name = "grvHocPhan"
        Me.grvHocPhan.OptionsSelection.MultiSelect = True
        Me.grvHocPhan.OptionsView.ShowAutoFilterRow = True
        Me.grvHocPhan.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 35
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Mã học phần"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 1
        Me.colKy_hieu.Width = 60
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 2
        Me.colTen_mon.Width = 199
        '
        'colTen_lop_tc
        '
        Me.colTen_lop_tc.Caption = "Tên lớp tín chỉ"
        Me.colTen_lop_tc.FieldName = "Ten_lop_tc"
        Me.colTen_lop_tc.Name = "colTen_lop_tc"
        Me.colTen_lop_tc.Visible = True
        Me.colTen_lop_tc.VisibleIndex = 3
        Me.colTen_lop_tc.Width = 70
        '
        'colSo_hoc_trinh
        '
        Me.colSo_hoc_trinh.Caption = "Số tín chỉ"
        Me.colSo_hoc_trinh.FieldName = "So_tin_chi"
        Me.colSo_hoc_trinh.Name = "colSo_hoc_trinh"
        Me.colSo_hoc_trinh.Visible = True
        Me.colSo_hoc_trinh.VisibleIndex = 4
        Me.colSo_hoc_trinh.Width = 36
        '
        'colThoi_gian
        '
        Me.colThoi_gian.Caption = "Thời gian"
        Me.colThoi_gian.FieldName = "Thoi_gian"
        Me.colThoi_gian.Name = "colThoi_gian"
        Me.colThoi_gian.Visible = True
        Me.colThoi_gian.VisibleIndex = 6
        Me.colThoi_gian.Width = 90
        '
        'colTen_phong
        '
        Me.colTen_phong.Caption = "Tên phòng"
        Me.colTen_phong.FieldName = "Ten_phong"
        Me.colTen_phong.Name = "colTen_phong"
        Me.colTen_phong.Visible = True
        Me.colTen_phong.VisibleIndex = 7
        Me.colTen_phong.Width = 46
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Giáo viên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 8
        Me.colHo_ten.Width = 67
        '
        'colHoc_lai
        '
        Me.colHoc_lai.Caption = "Học lại"
        Me.colHoc_lai.FieldName = "Hoc_lai"
        Me.colHoc_lai.Name = "colHoc_lai"
        Me.colHoc_lai.Visible = True
        Me.colHoc_lai.VisibleIndex = 5
        Me.colHoc_lai.Width = 41
        '
        'colCon_trong
        '
        Me.colCon_trong.Caption = "Còn trống"
        Me.colCon_trong.FieldName = "Con_trong"
        Me.colCon_trong.Name = "colCon_trong"
        Me.colCon_trong.Visible = True
        Me.colCon_trong.VisibleIndex = 9
        Me.colCon_trong.Width = 50
        '
        'grcHocPhanDangKy
        '
        Me.grcHocPhanDangKy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhanDangKy.Location = New System.Drawing.Point(1, 382)
        Me.grcHocPhanDangKy.MainView = Me.grvHocPhanDangKy
        Me.grcHocPhanDangKy.Name = "grcHocPhanDangKy"
        Me.grcHocPhanDangKy.Size = New System.Drawing.Size(982, 150)
        Me.grcHocPhanDangKy.TabIndex = 150
        Me.grcHocPhanDangKy.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhanDangKy})
        '
        'grvHocPhanDangKy
        '
        Me.grvHocPhanDangKy.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon1, Me.colHoc_lai1, Me.colKy_hieu1, Me.colTen_mon1, Me.colSo_hoc_trinh1, Me.colTen_lop_tc1, Me.colThoi_gian1, Me.colGiao_vien1, Me.colTen_phong1, Me.colCon_trong1})
        Me.grvHocPhanDangKy.GridControl = Me.grcHocPhanDangKy
        Me.grvHocPhanDangKy.Name = "grvHocPhanDangKy"
        Me.grvHocPhanDangKy.OptionsSelection.MultiSelect = True
        Me.grvHocPhanDangKy.OptionsView.ShowAutoFilterRow = True
        Me.grvHocPhanDangKy.OptionsView.ShowGroupPanel = False
        '
        'colChon1
        '
        Me.colChon1.Caption = "Chọn"
        Me.colChon1.FieldName = "Chon"
        Me.colChon1.Name = "colChon1"
        Me.colChon1.Visible = True
        Me.colChon1.VisibleIndex = 0
        Me.colChon1.Width = 35
        '
        'colHoc_lai1
        '
        Me.colHoc_lai1.Caption = "Học lại"
        Me.colHoc_lai1.FieldName = "Hoc_lai"
        Me.colHoc_lai1.Name = "colHoc_lai1"
        Me.colHoc_lai1.Visible = True
        Me.colHoc_lai1.VisibleIndex = 4
        Me.colHoc_lai1.Width = 41
        '
        'colKy_hieu1
        '
        Me.colKy_hieu1.Caption = "Mã học phần"
        Me.colKy_hieu1.FieldName = "Ky_hieu"
        Me.colKy_hieu1.Name = "colKy_hieu1"
        Me.colKy_hieu1.Visible = True
        Me.colKy_hieu1.VisibleIndex = 1
        Me.colKy_hieu1.Width = 50
        '
        'colTen_mon1
        '
        Me.colTen_mon1.Caption = "Tên học phần"
        Me.colTen_mon1.FieldName = "Ten_mon"
        Me.colTen_mon1.Name = "colTen_mon1"
        Me.colTen_mon1.Visible = True
        Me.colTen_mon1.VisibleIndex = 2
        Me.colTen_mon1.Width = 199
        '
        'colSo_hoc_trinh1
        '
        Me.colSo_hoc_trinh1.Caption = "Số tín chỉ"
        Me.colSo_hoc_trinh1.FieldName = "So_tin_chi"
        Me.colSo_hoc_trinh1.Name = "colSo_hoc_trinh1"
        Me.colSo_hoc_trinh1.Visible = True
        Me.colSo_hoc_trinh1.VisibleIndex = 5
        Me.colSo_hoc_trinh1.Width = 41
        '
        'colTen_lop_tc1
        '
        Me.colTen_lop_tc1.Caption = "Tên lớp tín chỉ"
        Me.colTen_lop_tc1.FieldName = "Ten_lop_tc"
        Me.colTen_lop_tc1.Name = "colTen_lop_tc1"
        Me.colTen_lop_tc1.Visible = True
        Me.colTen_lop_tc1.VisibleIndex = 3
        Me.colTen_lop_tc1.Width = 140
        '
        'colThoi_gian1
        '
        Me.colThoi_gian1.Caption = "Thời gian"
        Me.colThoi_gian1.FieldName = "Thoi_gian"
        Me.colThoi_gian1.Name = "colThoi_gian1"
        Me.colThoi_gian1.Visible = True
        Me.colThoi_gian1.VisibleIndex = 6
        Me.colThoi_gian1.Width = 41
        '
        'colGiao_vien1
        '
        Me.colGiao_vien1.Caption = "Giáo viên"
        Me.colGiao_vien1.FieldName = "Ho_ten"
        Me.colGiao_vien1.Name = "colGiao_vien1"
        Me.colGiao_vien1.Visible = True
        Me.colGiao_vien1.VisibleIndex = 7
        Me.colGiao_vien1.Width = 106
        '
        'colTen_phong1
        '
        Me.colTen_phong1.Caption = "Tên phòng"
        Me.colTen_phong1.FieldName = "Ten_phong"
        Me.colTen_phong1.Name = "colTen_phong1"
        Me.colTen_phong1.Visible = True
        Me.colTen_phong1.VisibleIndex = 8
        Me.colTen_phong1.Width = 90
        '
        'colCon_trong1
        '
        Me.colCon_trong1.Caption = "Rút bớt học phần"
        Me.colCon_trong1.FieldName = "Rut_bot_hoc_phan"
        Me.colCon_trong1.Name = "colCon_trong1"
        Me.colCon_trong1.Visible = True
        Me.colCon_trong1.VisibleIndex = 9
        Me.colCon_trong1.Width = 97
        '
        'cmdDangKy
        '
        Me.cmdDangKy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDangKy.ImageIndex = 0
        Me.cmdDangKy.ImageList = Me.ImgMain
        Me.cmdDangKy.Location = New System.Drawing.Point(639, 354)
        Me.cmdDangKy.Name = "cmdDangKy"
        Me.cmdDangKy.Size = New System.Drawing.Size(91, 27)
        Me.cmdDangKy.TabIndex = 155
        Me.cmdDangKy.Text = "Đăng ký"
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
        'cmdHuyDangKy
        '
        Me.cmdHuyDangKy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHuyDangKy.ImageIndex = 4
        Me.cmdHuyDangKy.ImageList = Me.ImgMain
        Me.cmdHuyDangKy.Location = New System.Drawing.Point(738, 354)
        Me.cmdHuyDangKy.Name = "cmdHuyDangKy"
        Me.cmdHuyDangKy.Size = New System.Drawing.Size(91, 27)
        Me.cmdHuyDangKy.TabIndex = 155
        Me.cmdHuyDangKy.Text = "Xóa đăng ký"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(893, 534)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 171
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(665, 534)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 30)
        Me.cmdSave.TabIndex = 172
        Me.cmdSave.Text = "Lưu"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(760, 534)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(126, 30)
        Me.cmdPrint.TabIndex = 172
        Me.cmdPrint.Text = "In phiếu đăng ký"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(689, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Mã SV:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ImageIndex = 19
        Me.btnSearch.ImageList = Me.ImgMain
        Me.btnSearch.Location = New System.Drawing.Point(902, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 26)
        Me.btnSearch.TabIndex = 180
        Me.btnSearch.Text = "Tìm kiếm"
        '
        'cmdRut_HP
        '
        Me.cmdRut_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRut_HP.ImageIndex = 1
        Me.cmdRut_HP.ImageList = Me.ImgMain
        Me.cmdRut_HP.Location = New System.Drawing.Point(866, 354)
        Me.cmdRut_HP.Name = "cmdRut_HP"
        Me.cmdRut_HP.Size = New System.Drawing.Size(114, 27)
        Me.cmdRut_HP.TabIndex = 183
        Me.cmdRut_HP.Text = "Rút bớt học phần"
        '
        'EssToolBarTC1
        '
        Me.EssToolBarTC1.BackColor = System.Drawing.SystemColors.Control
        Me.EssToolBarTC1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EssToolBarTC1.Location = New System.Drawing.Point(-1, 2)
        Me.EssToolBarTC1.Name = "EssToolBarTC1"
        Me.EssToolBarTC1.Size = New System.Drawing.Size(981, 33)
        Me.EssToolBarTC1.TabIndex = 184
        '
        'lblLop
        '
        Me.lblLop.BackColor = System.Drawing.Color.Transparent
        Me.lblLop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLop.Location = New System.Drawing.Point(572, 39)
        Me.lblLop.Name = "lblLop"
        Me.lblLop.Size = New System.Drawing.Size(111, 24)
        Me.lblLop.TabIndex = 188
        Me.lblLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(526, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Lớp:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageIndex = 19
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(498, 355)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(78, 26)
        Me.SimpleButton1.TabIndex = 189
        Me.SimpleButton1.Text = "Tìm kiếm"
        '
        'frmESS_DangKyLopHocPhan_TinChiChoSinhVien
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(984, 566)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lblLop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EssToolBarTC1)
        Me.Controls.Add(Me.cmdRut_HP)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdHuyDangKy)
        Me.Controls.Add(Me.cmdDangKy)
        Me.Controls.Add(Me.grcHocPhanDangKy)
        Me.Controls.Add(Me.grcHocPhan)
        Me.Controls.Add(Me.lblHo_ten)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSo_hoc_trinh_max)
        Me.Controls.Add(Me.lblSo_hoc_trinh_min)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSo_tien_nop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSo_hoc_trinh)
        Me.Controls.Add(Me.lblSo_mon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_DangKyLopHocPhan_TinChiChoSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ĐĂNG KÝ LỚP TÍN CHỈ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhanDangKy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhanDangKy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon As System.Windows.Forms.Label
    Friend WithEvents lblSo_hoc_trinh As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_nop As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSo_hoc_trinh_max As System.Windows.Forms.Label
    Friend WithEvents lblSo_hoc_trinh_min As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblHo_ten As System.Windows.Forms.Label
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents grcHocPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop_tc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoc_lai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThoi_gian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_phong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCon_trong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcHocPhanDangKy As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhanDangKy As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoc_lai1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_hieu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop_tc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThoi_gian1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGiao_vien1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_phong1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCon_trong1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdHuyDangKy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDangKy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRut_HP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EssToolBarTC1 As ESSToolBarTC
    Friend WithEvents lblLop As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
