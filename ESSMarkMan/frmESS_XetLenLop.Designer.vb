<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetLenLop
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_XetLenLop))
        Me.labSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.trvLop = New ESSMarkMan.TreeViewLop
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Chon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTong_so_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCTL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTong_so_tin_chi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_do = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdZ = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddQD = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach_DaChon = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Chon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach_DaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labSo_sv
        '
        Me.labSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(734, 5)
        Me.labSo_sv.Name = "labSo_sv"
        Me.labSo_sv.Size = New System.Drawing.Size(43, 23)
        Me.labSo_sv.TabIndex = 109
        Me.labSo_sv.Text = "0"
        Me.labSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(606, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Tống số sinh viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNam_hoc.Location = New System.Drawing.Point(166, 2)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(101, 24)
        Me.cmbNam_hoc.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Items.AddRange(New Object() {"01", "02"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(54, 1)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(38, 24)
        Me.cmbHoc_ky.TabIndex = 117
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-5, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Học kỳ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(-1, 31)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(262, 532)
        Me.trvLop.TabIndex = 100
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        Me.grcDanhSach.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grcDanhSach.Location = New System.Drawing.Point(261, 31)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(527, 144)
        Me.grcDanhSach.TabIndex = 153
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Chon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTong_so_hoc_trinh, Me.colTBCTL, Me.colTong_so_tin_chi, Me.colTBCHT, Me.colLy_do})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'Chon
        '
        Me.Chon.Caption = "Chọn"
        Me.Chon.FieldName = "Chon"
        Me.Chon.Name = "Chon"
        Me.Chon.Visible = True
        Me.Chon.VisibleIndex = 0
        Me.Chon.Width = 40
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 29
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 45
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
        Me.colNgay_sinh.Width = 29
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 36
        '
        'colTong_so_hoc_trinh
        '
        Me.colTong_so_hoc_trinh.Caption = "Số TCTL"
        Me.colTong_so_hoc_trinh.FieldName = "So_TCTL"
        Me.colTong_so_hoc_trinh.Name = "colTong_so_hoc_trinh"
        Me.colTong_so_hoc_trinh.OptionsColumn.ReadOnly = True
        Me.colTong_so_hoc_trinh.Visible = True
        Me.colTong_so_hoc_trinh.VisibleIndex = 5
        Me.colTong_so_hoc_trinh.Width = 60
        '
        'colTBCTL
        '
        Me.colTBCTL.Caption = "TBCTL"
        Me.colTBCTL.FieldName = "TBCTL"
        Me.colTBCTL.Name = "colTBCTL"
        Me.colTBCTL.OptionsColumn.ReadOnly = True
        Me.colTBCTL.Visible = True
        Me.colTBCTL.VisibleIndex = 6
        Me.colTBCTL.Width = 45
        '
        'colTong_so_tin_chi
        '
        Me.colTong_so_tin_chi.Caption = "Số TCHT"
        Me.colTong_so_tin_chi.FieldName = "So_TCHT"
        Me.colTong_so_tin_chi.Name = "colTong_so_tin_chi"
        Me.colTong_so_tin_chi.OptionsColumn.ReadOnly = True
        Me.colTong_so_tin_chi.Visible = True
        Me.colTong_so_tin_chi.VisibleIndex = 7
        Me.colTong_so_tin_chi.Width = 60
        '
        'colTBCHT
        '
        Me.colTBCHT.Caption = "TBCHT kỳ"
        Me.colTBCHT.FieldName = "TBCHT_Ky"
        Me.colTBCHT.Name = "colTBCHT"
        Me.colTBCHT.OptionsColumn.ReadOnly = True
        Me.colTBCHT.Visible = True
        Me.colTBCHT.VisibleIndex = 8
        Me.colTBCHT.Width = 45
        '
        'colLy_do
        '
        Me.colLy_do.Caption = "Lý do"
        Me.colLy_do.FieldName = "Ly_do"
        Me.colLy_do.Name = "colLy_do"
        Me.colLy_do.OptionsColumn.ReadOnly = True
        Me.colLy_do.Visible = True
        Me.colLy_do.VisibleIndex = 9
        Me.colLy_do.Width = 91
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
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint1
        '
        Me.cmdPrint1.Caption = "Danh sách lớp"
        Me.cmdPrint1.Id = 0
        Me.cmdPrint1.ImageIndex = 16
        Me.cmdPrint1.Name = "cmdPrint1"
        '
        'cmdPrint2
        '
        Me.cmdPrint2.Caption = "Tổng hợp danh sách"
        Me.cmdPrint2.Id = 1
        Me.cmdPrint2.ImageIndex = 16
        Me.cmdPrint2.Name = "cmdPrint2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint1, Me.cmdPrint2})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(792, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(792, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(792, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(697, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 30)
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
        Me.cmdExport.Location = New System.Drawing.Point(601, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 30)
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
        Me.cmdPrintList.Location = New System.Drawing.Point(479, 532)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(115, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdZ
        '
        Me.cmdZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdZ.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZ.Appearance.Options.UseFont = True
        Me.cmdZ.ImageIndex = 15
        Me.cmdZ.ImageList = Me.ImgMain
        Me.cmdZ.Location = New System.Drawing.Point(283, 532)
        Me.cmdZ.Name = "cmdZ"
        Me.cmdZ.Size = New System.Drawing.Size(91, 30)
        Me.cmdZ.TabIndex = 164
        Me.cmdZ.Text = "Tổng hợp"
        '
        'cmdAddQD
        '
        Me.cmdAddQD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddQD.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddQD.Appearance.Options.UseFont = True
        Me.cmdAddQD.ImageIndex = 0
        Me.cmdAddQD.ImageList = Me.ImgMain
        Me.cmdAddQD.Location = New System.Drawing.Point(380, 532)
        Me.cmdAddQD.Name = "cmdAddQD"
        Me.cmdAddQD.Size = New System.Drawing.Size(91, 30)
        Me.cmdAddQD.TabIndex = 164
        Me.cmdAddQD.Text = "Nhập QĐ"
        '
        'grcDanhSach_DaChon
        '
        Me.grcDanhSach_DaChon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach_DaChon.Location = New System.Drawing.Point(261, 198)
        Me.grcDanhSach_DaChon.MainView = Me.GridView1
        Me.grcDanhSach_DaChon.Name = "grcDanhSach_DaChon"
        Me.grcDanhSach_DaChon.Size = New System.Drawing.Size(527, 328)
        Me.grcDanhSach_DaChon.TabIndex = 170
        Me.grcDanhSach_DaChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Chon2, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.GridControl = Me.grcDanhSach_DaChon
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Chon2
        '
        Me.Chon2.Caption = "Chọn"
        Me.Chon2.FieldName = "Chon"
        Me.Chon2.Name = "Chon2"
        Me.Chon2.Visible = True
        Me.Chon2.VisibleIndex = 0
        Me.Chon2.Width = 40
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã SV"
        Me.GridColumn1.FieldName = "Ma_sv"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 30
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Họ tên"
        Me.GridColumn2.FieldName = "Ho_ten"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 47
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ngày sinh"
        Me.GridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "Ngay_sinh"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 30
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên lớp"
        Me.GridColumn4.FieldName = "Ten_lop"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 37
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Số TCTL"
        Me.GridColumn5.FieldName = "So_TCTL"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 62
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "TBCTL"
        Me.GridColumn6.FieldName = "TBCTL"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 47
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Số TCHT"
        Me.GridColumn7.FieldName = "So_TCHT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 62
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "TBCHT kỳ"
        Me.GridColumn8.FieldName = "TBCHT_Ky"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 47
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Lý do"
        Me.GridColumn9.FieldName = "Ly_do"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 104
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Brown
        Me.btnAdd.Image = Global.ESSMarkMan.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(667, 175)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 25)
        Me.btnAdd.TabIndex = 172
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Brown
        Me.btnDel.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(730, 175)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(58, 25)
        Me.btnDel.TabIndex = 171
        Me.btnDel.Text = "Xoá"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(292, 12)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(109, 19)
        Me.optAll1.TabIndex = 174
        Me.optAll1.Text = "Chọn tất cả "
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(292, 177)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(100, 24)
        Me.optAll.TabIndex = 173
        Me.optAll.Text = "Chọn tất cả "
        Me.optAll.UseVisualStyleBackColor = False
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Items.AddRange(New Object() {"1", "2"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(528, 5)
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(52, 24)
        Me.cmbLan_thu.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(428, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Cảnh báo lần:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_XetLenLop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbLan_thu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.grcDanhSach_DaChon)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAddQD)
        Me.Controls.Add(Me.cmdZ)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.labSo_sv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_XetLenLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xét lên lớp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach_DaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvLop As ESSMarkMan.TreeViewLop
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCTL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTong_So_hoc_trinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdZ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddQD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTong_so_tin_chi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTong_so_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbLan_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Chon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Chon2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colLy_do As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Private WithEvents grcDanhSach_DaChon As DevExpress.XtraGrid.GridControl
End Class
