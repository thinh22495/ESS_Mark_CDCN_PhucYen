<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_DanhSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list. 1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThi_DanhSach))
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_bao_danh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_phong = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu_thi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbOrder = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DSThi1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DSThi2 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_All_DSThi1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_All_DSThi2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdAdd_SV = New DevExpress.XtraBars.BarButtonItem
        Me.cmdRemove_SV = New DevExpress.XtraBars.BarButtonItem
        Me.cmdAdd_SBD = New DevExpress.XtraBars.BarButtonItem
        Me.cmdRemove_SVDK = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_AllDSThi2 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdUpdate_SBD = New DevExpress.XtraBars.BarButtonItem
        Me.cmdUpdate_GhiChu = New DevExpress.XtraBars.BarButtonItem
        Me.cmdEdit_TT_PhongThi = New DevExpress.XtraBars.BarButtonItem
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdAdd_TCT = New DevExpress.XtraEditors.SimpleButton
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cmdDelete_TCT = New DevExpress.XtraEditors.SimpleButton
        Me.cmdList_SV = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHinhthuc = New System.Windows.Forms.ComboBox
        Me.cmdTongHop_NoHP = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSo_sv
        '
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(518, 7)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(63, 20)
        Me.txtSo_sv.TabIndex = 53
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(428, 7)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(87, 20)
        Me.lblTong_so.TabIndex = 52
        Me.lblTong_so.Text = "Tổng số sv:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(273, 7)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(100, 20)
        Me.chkAll.TabIndex = 58
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 0)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(258, 493)
        Me.trvPhongThi.TabIndex = 54
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(264, 32)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(762, 493)
        Me.grcDanhSachThi.TabIndex = 151
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colSo_bao_danh, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTen_khoa, Me.colTen_phong, Me.colGhi_chu_thi})
        Me.grvDanhSachThi.GridControl = Me.grcDanhSachThi
        Me.grvDanhSachThi.Name = "grvDanhSachThi"
        Me.grvDanhSachThi.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThi.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThi.OptionsView.ShowFooter = True
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
        'colTen_phong
        '
        Me.colTen_phong.Caption = "Phòng thi"
        Me.colTen_phong.FieldName = "Ten_phong"
        Me.colTen_phong.Name = "colTen_phong"
        Me.colTen_phong.Visible = True
        Me.colTen_phong.VisibleIndex = 7
        Me.colTen_phong.Width = 80
        '
        'colGhi_chu_thi
        '
        Me.colGhi_chu_thi.Caption = "Ghi chú "
        Me.colGhi_chu_thi.FieldName = "Ghi_chu_thi"
        Me.colGhi_chu_thi.Name = "colGhi_chu_thi"
        Me.colGhi_chu_thi.Visible = True
        Me.colGhi_chu_thi.VisibleIndex = 8
        Me.colGhi_chu_thi.Width = 83
        '
        'cmbOrder
        '
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.Items.AddRange(New Object() {"Họ và tên", "Mã sinh viên", "Lớp - mã sinh viên", "Ngành - lớp - mã sinh viên", "Không sắp xếp"})
        Me.cmbOrder.Location = New System.Drawing.Point(882, 5)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(118, 24)
        Me.cmbOrder.TabIndex = 67
        Me.cmbOrder.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(779, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Sắp xếp theo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
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
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSThi1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSThi2), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_All_DSThi1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_All_DSThi2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DSThi1
        '
        Me.cmdPrint_DSThi1.Caption = "Danh sách thi 1"
        Me.cmdPrint_DSThi1.Id = 0
        Me.cmdPrint_DSThi1.ImageIndex = 16
        Me.cmdPrint_DSThi1.Name = "cmdPrint_DSThi1"
        '
        'cmdPrint_DSThi2
        '
        Me.cmdPrint_DSThi2.Caption = "Danh sách thi 2"
        Me.cmdPrint_DSThi2.Id = 1
        Me.cmdPrint_DSThi2.ImageIndex = 16
        Me.cmdPrint_DSThi2.Name = "cmdPrint_DSThi2"
        '
        'cmdPrint_All_DSThi1
        '
        Me.cmdPrint_All_DSThi1.Caption = "Danh sách thi 1 (Cả đợt)"
        Me.cmdPrint_All_DSThi1.Id = 6
        Me.cmdPrint_All_DSThi1.ImageIndex = 16
        Me.cmdPrint_All_DSThi1.Name = "cmdPrint_All_DSThi1"
        '
        'cmdPrint_All_DSThi2
        '
        Me.cmdPrint_All_DSThi2.Caption = "Danh sách thi 2 (Cả đợt)"
        Me.cmdPrint_All_DSThi2.Id = 8
        Me.cmdPrint_All_DSThi2.ImageIndex = 16
        Me.cmdPrint_All_DSThi2.Name = "cmdPrint_All_DSThi2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_DSThi1, Me.cmdPrint_DSThi2, Me.cmdAdd_SV, Me.cmdRemove_SV, Me.cmdAdd_SBD, Me.cmdRemove_SVDK, Me.cmdPrint_All_DSThi1, Me.cmdPrint_AllDSThi2, Me.cmdPrint_All_DSThi2, Me.cmdUpdate_SBD, Me.cmdUpdate_GhiChu, Me.cmdEdit_TT_PhongThi})
        Me.BarManager1.MaxItemId = 12
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1028, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 562)
        Me.BarDockControl2.Size = New System.Drawing.Size(1028, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 562)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1028, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 562)
        '
        'cmdAdd_SV
        '
        Me.cmdAdd_SV.Caption = "Thêm sinh viên"
        Me.cmdAdd_SV.Id = 2
        Me.cmdAdd_SV.ImageIndex = 0
        Me.cmdAdd_SV.Name = "cmdAdd_SV"
        '
        'cmdRemove_SV
        '
        Me.cmdRemove_SV.Caption = "Loại sinh viên"
        Me.cmdRemove_SV.Id = 3
        Me.cmdRemove_SV.ImageIndex = 4
        Me.cmdRemove_SV.Name = "cmdRemove_SV"
        '
        'cmdAdd_SBD
        '
        Me.cmdAdd_SBD.Caption = "Lập số báo danh"
        Me.cmdAdd_SBD.Id = 4
        Me.cmdAdd_SBD.ImageIndex = 3
        Me.cmdAdd_SBD.Name = "cmdAdd_SBD"
        '
        'cmdRemove_SVDK
        '
        Me.cmdRemove_SVDK.Caption = "Loại sinh viên không đủ ĐK dự thi"
        Me.cmdRemove_SVDK.Id = 5
        Me.cmdRemove_SVDK.ImageIndex = 8
        Me.cmdRemove_SVDK.Name = "cmdRemove_SVDK"
        '
        'cmdPrint_AllDSThi2
        '
        Me.cmdPrint_AllDSThi2.Caption = "Danh sách thi 2 (Cả đợt)"
        Me.cmdPrint_AllDSThi2.Id = 7
        Me.cmdPrint_AllDSThi2.ImageIndex = 16
        Me.cmdPrint_AllDSThi2.Name = "cmdPrint_AllDSThi2"
        '
        'cmdUpdate_SBD
        '
        Me.cmdUpdate_SBD.Caption = "Sửa số báo danh"
        Me.cmdUpdate_SBD.Id = 9
        Me.cmdUpdate_SBD.ImageIndex = 10
        Me.cmdUpdate_SBD.Name = "cmdUpdate_SBD"
        '
        'cmdUpdate_GhiChu
        '
        Me.cmdUpdate_GhiChu.Caption = "Sửa ghi chú thi"
        Me.cmdUpdate_GhiChu.Id = 10
        Me.cmdUpdate_GhiChu.ImageIndex = 10
        Me.cmdUpdate_GhiChu.Name = "cmdUpdate_GhiChu"
        '
        'cmdEdit_TT_PhongThi
        '
        Me.cmdEdit_TT_PhongThi.Caption = "Sửa thông tin thi Phòng"
        Me.cmdEdit_TT_PhongThi.Id = 11
        Me.cmdEdit_TT_PhongThi.ImageIndex = 15
        Me.cmdEdit_TT_PhongThi.ImageIndexDisabled = 15
        Me.cmdEdit_TT_PhongThi.Name = "cmdEdit_TT_PhongThi"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(925, 528)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(101, 30)
        Me.cmdClose.TabIndex = 165
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(818, 528)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(101, 30)
        Me.cmdExport.TabIndex = 164
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(677, 528)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(135, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdAdd_TCT
        '
        Me.cmdAdd_TCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd_TCT.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd_TCT.Appearance.Options.UseFont = True
        Me.cmdAdd_TCT.ImageIndex = 0
        Me.cmdAdd_TCT.ImageList = Me.ImgMain
        Me.cmdAdd_TCT.Location = New System.Drawing.Point(319, 528)
        Me.cmdAdd_TCT.Name = "cmdAdd_TCT"
        Me.cmdAdd_TCT.Size = New System.Drawing.Size(101, 30)
        Me.cmdAdd_TCT.TabIndex = 164
        Me.cmdAdd_TCT.Text = "Tổ chức thi"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Danh sách lớp"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageIndex = 16
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Danh sách điểm danh"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageIndex = 16
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1028, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 562)
        '
        'cmdDelete_TCT
        '
        Me.cmdDelete_TCT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete_TCT.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete_TCT.Appearance.Options.UseFont = True
        Me.cmdDelete_TCT.ImageIndex = 4
        Me.cmdDelete_TCT.ImageList = Me.ImgMain
        Me.cmdDelete_TCT.Location = New System.Drawing.Point(426, 528)
        Me.cmdDelete_TCT.Name = "cmdDelete_TCT"
        Me.cmdDelete_TCT.Size = New System.Drawing.Size(101, 30)
        Me.cmdDelete_TCT.TabIndex = 164
        Me.cmdDelete_TCT.Text = "Xóa"
        '
        'cmdList_SV
        '
        Me.cmdList_SV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdList_SV.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdList_SV.Appearance.Options.UseFont = True
        Me.cmdList_SV.DropDownControl = Me.PopupMenu2
        Me.cmdList_SV.ImageIndex = 17
        Me.cmdList_SV.ImageList = Me.ImgMain
        Me.cmdList_SV.Location = New System.Drawing.Point(536, 528)
        Me.cmdList_SV.Name = "cmdList_SV"
        Me.cmdList_SV.Size = New System.Drawing.Size(135, 30)
        Me.cmdList_SV.TabIndex = 163
        Me.cmdList_SV.Text = "DS Thí sinh"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd_SV), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdRemove_SV), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd_SBD), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdRemove_SVDK), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdUpdate_SBD), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdUpdate_GhiChu), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdEdit_TT_PhongThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(555, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Hình thức thi:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHinhthuc
        '
        Me.cmbHinhthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHinhthuc.Items.AddRange(New Object() {"Viết", "Vấn đáp", "Thực hành"})
        Me.cmbHinhthuc.Location = New System.Drawing.Point(658, 4)
        Me.cmbHinhthuc.Name = "cmbHinhthuc"
        Me.cmbHinhthuc.Size = New System.Drawing.Size(118, 24)
        Me.cmbHinhthuc.TabIndex = 67
        '
        'cmdTongHop_NoHP
        '
        Me.cmdTongHop_NoHP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTongHop_NoHP.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTongHop_NoHP.Appearance.Options.UseFont = True
        Me.cmdTongHop_NoHP.ImageIndex = 15
        Me.cmdTongHop_NoHP.ImageList = Me.ImgMain
        Me.cmdTongHop_NoHP.Location = New System.Drawing.Point(79, 528)
        Me.cmdTongHop_NoHP.Name = "cmdTongHop_NoHP"
        Me.cmdTongHop_NoHP.Size = New System.Drawing.Size(234, 30)
        Me.cmdTongHop_NoHP.TabIndex = 170
        Me.cmdTongHop_NoHP.Text = "Tổng hợp ghi chú Nợ học phí, học tập"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageIndex = 15
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(43, 492)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(148, 30)
        Me.SimpleButton1.TabIndex = 175
        Me.SimpleButton1.Text = "Ghi chú Nợ Học Tập"
        Me.SimpleButton1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 496)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 26)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Tổng hợp nợ HP trước khi tổng hợp Nợ học tập"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'frmESS_ToChucThi_DanhSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1028, 562)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdTongHop_NoHP)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.cmbHinhthuc)
        Me.Controls.Add(Me.cmbOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.cmdList_SV)
        Me.Controls.Add(Me.cmdDelete_TCT)
        Me.Controls.Add(Me.cmdAdd_TCT)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_ToChucThi_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUAN LY VA TO CHUC THI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu_thi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_bao_danh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_phong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd_TCT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_DSThi1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSThi2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdDelete_TCT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdList_SV As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdAdd_SV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdRemove_SV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdAdd_SBD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdRemove_SVDK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_All_DSThi1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_All_DSThi2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_AllDSThi2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdUpdate_SBD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdUpdate_GhiChu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbHinhthuc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit_TT_PhongThi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdTongHop_NoHP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
