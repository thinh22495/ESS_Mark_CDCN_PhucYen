<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_Lop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DanhSachSinhVien_Lop))
        Me.txtNu = New System.Windows.Forms.Label
        Me.txtNam = New System.Windows.Forms.Label
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblNu = New System.Windows.Forms.Label
        Me.lblNam = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.trvLop = New ESSMarkMan.TreeViewLop
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdView = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGioi_tinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoi_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCMND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoi_cap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_cap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Trang_thai_hoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DanhSach1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DonMienGiamHP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DonXacNhan = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_PhieuXacNhan = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_GiayXacNhan = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdPrint_DanhSach2 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DanhSach3 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DanhSach4 = New DevExpress.XtraBars.BarButtonItem
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNu
        '
        Me.txtNu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNu.BackColor = System.Drawing.Color.Transparent
        Me.txtNu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNu.ForeColor = System.Drawing.Color.Maroon
        Me.txtNu.Location = New System.Drawing.Point(757, 9)
        Me.txtNu.Name = "txtNu"
        Me.txtNu.Size = New System.Drawing.Size(34, 18)
        Me.txtNu.TabIndex = 22
        Me.txtNu.Text = "0"
        Me.txtNu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNam
        '
        Me.txtNam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNam.BackColor = System.Drawing.Color.Transparent
        Me.txtNam.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNam.ForeColor = System.Drawing.Color.Maroon
        Me.txtNam.Location = New System.Drawing.Point(685, 9)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(34, 18)
        Me.txtNam.TabIndex = 21
        Me.txtNam.Text = "0"
        Me.txtNam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(602, 9)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(34, 18)
        Me.txtSo_sv.TabIndex = 20
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNu
        '
        Me.lblNu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNu.BackColor = System.Drawing.Color.Transparent
        Me.lblNu.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblNu.Location = New System.Drawing.Point(705, 9)
        Me.lblNu.Name = "lblNu"
        Me.lblNu.Size = New System.Drawing.Size(46, 18)
        Me.lblNu.TabIndex = 19
        Me.lblNu.Text = "Nữ:"
        Me.lblNu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNam
        '
        Me.lblNam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNam.BackColor = System.Drawing.Color.Transparent
        Me.lblNam.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblNam.Location = New System.Drawing.Point(633, 9)
        Me.lblNam.Name = "lblNam"
        Me.lblNam.Size = New System.Drawing.Size(46, 18)
        Me.lblNam.TabIndex = 18
        Me.lblNam.Text = "Nam:"
        Me.lblNam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(512, 9)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(90, 18)
        Me.lblTong_so.TabIndex = 17
        Me.lblTong_so.Text = "Tổng số:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(1, 2)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(257, 566)
        Me.trvLop.TabIndex = 1
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(275, 8)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(103, 21)
        Me.optAll.TabIndex = 179
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
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
        Me.ImgMain.Images.SetKeyName(22, "1665.ico")
        Me.ImgMain.Images.SetKeyName(23, "1669.ico")
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(698, 534)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 30)
        Me.cmdClose.TabIndex = 209
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(603, 534)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 30)
        Me.cmdExport.TabIndex = 211
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdView
        '
        Me.cmdView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdView.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Appearance.Options.UseFont = True
        Me.cmdView.ImageIndex = 17
        Me.cmdView.ImageList = Me.ImgMain
        Me.cmdView.Location = New System.Drawing.Point(479, 534)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(118, 30)
        Me.cmdView.TabIndex = 207
        Me.cmdView.Text = "Xem thông tin"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(258, 31)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(533, 497)
        Me.grcDanhSach.TabIndex = 220
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDanhSach.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvDanhSach.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDanhSach.Appearance.Row.Options.UseFont = True
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colGioi_tinh, Me.colNgay_sinh, Me.colNoi_sinh, Me.colCMND, Me.colNoi_cap, Me.colNgay_cap, Me.Trang_thai_hoc})
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
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 38
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 55
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 84
        '
        'colGioi_tinh
        '
        Me.colGioi_tinh.Caption = "Giới tính"
        Me.colGioi_tinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colGioi_tinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGioi_tinh.FieldName = "Gioi_tinh"
        Me.colGioi_tinh.Name = "colGioi_tinh"
        Me.colGioi_tinh.Visible = True
        Me.colGioi_tinh.VisibleIndex = 3
        Me.colGioi_tinh.Width = 52
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 4
        Me.colNgay_sinh.Width = 52
        '
        'colNoi_sinh
        '
        Me.colNoi_sinh.Caption = "Nơi sinh"
        Me.colNoi_sinh.FieldName = "Noi_sinh"
        Me.colNoi_sinh.Name = "colNoi_sinh"
        Me.colNoi_sinh.Visible = True
        Me.colNoi_sinh.VisibleIndex = 5
        Me.colNoi_sinh.Width = 52
        '
        'colCMND
        '
        Me.colCMND.Caption = "CMND"
        Me.colCMND.FieldName = "CMND"
        Me.colCMND.Name = "colCMND"
        Me.colCMND.OptionsColumn.ReadOnly = True
        Me.colCMND.Visible = True
        Me.colCMND.VisibleIndex = 6
        Me.colCMND.Width = 69
        '
        'colNoi_cap
        '
        Me.colNoi_cap.Caption = "Nơi cấp"
        Me.colNoi_cap.FieldName = "Noi_cap"
        Me.colNoi_cap.Name = "colNoi_cap"
        Me.colNoi_cap.Visible = True
        Me.colNoi_cap.VisibleIndex = 7
        Me.colNoi_cap.Width = 52
        '
        'colNgay_cap
        '
        Me.colNgay_cap.Caption = "Ngày cấp"
        Me.colNgay_cap.FieldName = "Ngay_cap"
        Me.colNgay_cap.Name = "colNgay_cap"
        Me.colNgay_cap.Visible = True
        Me.colNgay_cap.VisibleIndex = 8
        Me.colNgay_cap.Width = 58
        '
        'Trang_thai_hoc
        '
        Me.Trang_thai_hoc.Caption = "Trạng thái"
        Me.Trang_thai_hoc.FieldName = "Trang_thai_hoc"
        Me.Trang_thai_hoc.Name = "Trang_thai_hoc"
        Me.Trang_thai_hoc.OptionsColumn.AllowEdit = False
        Me.Trang_thai_hoc.Visible = True
        Me.Trang_thai_hoc.VisibleIndex = 9
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DanhSach1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DonMienGiamHP), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DonXacNhan), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_PhieuXacNhan), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_GiayXacNhan)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DanhSach1
        '
        Me.cmdPrint_DanhSach1.Caption = "Danh sách sinh viên"
        Me.cmdPrint_DanhSach1.Id = 0
        Me.cmdPrint_DanhSach1.ImageIndex = 16
        Me.cmdPrint_DanhSach1.Name = "cmdPrint_DanhSach1"
        '
        'cmdPrint_DonMienGiamHP
        '
        Me.cmdPrint_DonMienGiamHP.Caption = "Đơn xin miễn giảm học phí"
        Me.cmdPrint_DonMienGiamHP.Id = 1
        Me.cmdPrint_DonMienGiamHP.ImageIndex = 16
        Me.cmdPrint_DonMienGiamHP.Name = "cmdPrint_DonMienGiamHP"
        '
        'cmdPrint_DonXacNhan
        '
        Me.cmdPrint_DonXacNhan.Caption = "Đơn xin xác nhận"
        Me.cmdPrint_DonXacNhan.Id = 2
        Me.cmdPrint_DonXacNhan.ImageIndex = 16
        Me.cmdPrint_DonXacNhan.Name = "cmdPrint_DonXacNhan"
        '
        'cmdPrint_PhieuXacNhan
        '
        Me.cmdPrint_PhieuXacNhan.Caption = "Phiếu xác nhận"
        Me.cmdPrint_PhieuXacNhan.Id = 3
        Me.cmdPrint_PhieuXacNhan.ImageIndex = 16
        Me.cmdPrint_PhieuXacNhan.Name = "cmdPrint_PhieuXacNhan"
        '
        'cmdPrint_GiayXacNhan
        '
        Me.cmdPrint_GiayXacNhan.Caption = "Giấy xác nhận"
        Me.cmdPrint_GiayXacNhan.Id = 4
        Me.cmdPrint_GiayXacNhan.ImageIndex = 16
        Me.cmdPrint_GiayXacNhan.Name = "cmdPrint_GiayXacNhan"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_DanhSach1, Me.cmdPrint_DonMienGiamHP, Me.cmdPrint_DonXacNhan, Me.cmdPrint_PhieuXacNhan, Me.cmdPrint_GiayXacNhan, Me.cmdPrint_DanhSach2, Me.cmdPrint_DanhSach3, Me.cmdPrint_DanhSach4})
        Me.BarManager1.MaxItemId = 8
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(794, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 568)
        Me.BarDockControl2.Size = New System.Drawing.Size(794, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 568)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(794, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 568)
        '
        'cmdPrint_DanhSach2
        '
        Me.cmdPrint_DanhSach2.Caption = "Danh sách sinh viên 2"
        Me.cmdPrint_DanhSach2.Id = 5
        Me.cmdPrint_DanhSach2.ImageIndex = 16
        Me.cmdPrint_DanhSach2.Name = "cmdPrint_DanhSach2"
        '
        'cmdPrint_DanhSach3
        '
        Me.cmdPrint_DanhSach3.Caption = "Danh sách sinh viên 3"
        Me.cmdPrint_DanhSach3.Id = 6
        Me.cmdPrint_DanhSach3.ImageIndex = 16
        Me.cmdPrint_DanhSach3.Name = "cmdPrint_DanhSach3"
        '
        'cmdPrint_DanhSach4
        '
        Me.cmdPrint_DanhSach4.Caption = "Danh sách sinh viên 4"
        Me.cmdPrint_DanhSach4.Id = 7
        Me.cmdPrint_DanhSach4.ImageIndex = 11
        Me.cmdPrint_DanhSach4.Name = "cmdPrint_DanhSach4"
        '
        'frmESS_DanhSachSinhVien_Lop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.txtNu)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblNu)
        Me.Controls.Add(Me.lblNam)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmESS_DanhSachSinhVien_Lop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH SINH VIEN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvLop As TreeViewLop
    Friend WithEvents txtNu As System.Windows.Forms.Label
    Friend WithEvents txtNam As System.Windows.Forms.Label
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblNu As System.Windows.Forms.Label
    Friend WithEvents lblNam As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGioi_tinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCMND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoi_cap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_cap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoi_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_DanhSach1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DonMienGiamHP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdPrint_DonXacNhan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_PhieuXacNhan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_GiayXacNhan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DanhSach2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DanhSach3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DanhSach4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Trang_thai_hoc As DevExpress.XtraGrid.Columns.GridColumn
End Class
