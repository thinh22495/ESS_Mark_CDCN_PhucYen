<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEDU_XetLenLop_TongHop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEDU_XetLenLop_TongHop))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.trvLop = New ESSMarkMan.TreeViewLop
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnPrint_CanhBao1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnPrint_CanhBao2 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_CanhBao3 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdZ = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddQD = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach_Lan1 = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach_CB1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Chon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ly_do_cac_ky = New DevExpress.XtraGrid.Columns.GridColumn
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.cmdNoiDung_CB = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach_Lan2 = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach_CB2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDanhSach_Lan3 = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach_CB3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdInTongHop = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach_Lan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach_CB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach_Lan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach_CB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach_Lan3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach_CB3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNam_hoc.Location = New System.Drawing.Point(641, 0)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(101, 24)
        Me.cmbNam_hoc.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Năm học xét:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Items.AddRange(New Object() {"01", "02", "03"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(494, 0)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(38, 24)
        Me.cmbHoc_ky.TabIndex = 117
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(412, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 23)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Học kỳ xét:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvLop
        '
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(-1, 4)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(262, 356)
        Me.trvLop.TabIndex = 100
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
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint_CanhBao1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint_CanhBao2), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_CanhBao3), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'btnPrint_CanhBao1
        '
        Me.btnPrint_CanhBao1.Caption = "Danh sách cảnh báo lần 1"
        Me.btnPrint_CanhBao1.Id = 4
        Me.btnPrint_CanhBao1.Name = "btnPrint_CanhBao1"
        '
        'btnPrint_CanhBao2
        '
        Me.btnPrint_CanhBao2.Caption = "Danh sách cảnh báo lần2"
        Me.btnPrint_CanhBao2.Id = 2
        Me.btnPrint_CanhBao2.Name = "btnPrint_CanhBao2"
        '
        'cmdPrint_CanhBao3
        '
        Me.cmdPrint_CanhBao3.Caption = "Danh sách sinh viên thôi học"
        Me.cmdPrint_CanhBao3.Id = 0
        Me.cmdPrint_CanhBao3.ImageIndex = 16
        Me.cmdPrint_CanhBao3.Name = "cmdPrint_CanhBao3"
        '
        'cmdPrint2
        '
        Me.cmdPrint2.Caption = "Tổng hợp danh sách"
        Me.cmdPrint2.Id = 1
        Me.cmdPrint2.ImageIndex = 16
        Me.cmdPrint2.Name = "cmdPrint2"
        Me.cmdPrint2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_CanhBao3, Me.cmdPrint2, Me.btnPrint_CanhBao2, Me.BarButtonItem2, Me.btnPrint_CanhBao1, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 6
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1063, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1063, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1063, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Danh sách cảnh báo lần 1"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(968, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 30)
        Me.cmdClose.TabIndex = 165
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(872, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 30)
        Me.cmdExport.TabIndex = 164
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(750, 532)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(115, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdZ
        '
        Me.cmdZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdZ.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZ.Appearance.Options.UseFont = True
        Me.cmdZ.ImageIndex = 15
        Me.cmdZ.ImageList = Me.ImgMain
        Me.cmdZ.Location = New System.Drawing.Point(554, 532)
        Me.cmdZ.Name = "cmdZ"
        Me.cmdZ.Size = New System.Drawing.Size(91, 30)
        Me.cmdZ.TabIndex = 164
        Me.cmdZ.Text = "Tổng hợp"
        '
        'cmdAddQD
        '
        Me.cmdAddQD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddQD.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddQD.Appearance.Options.UseFont = True
        Me.cmdAddQD.ImageIndex = 0
        Me.cmdAddQD.ImageList = Me.ImgMain
        Me.cmdAddQD.Location = New System.Drawing.Point(651, 532)
        Me.cmdAddQD.Name = "cmdAddQD"
        Me.cmdAddQD.Size = New System.Drawing.Size(91, 30)
        Me.cmdAddQD.TabIndex = 164
        Me.cmdAddQD.Text = "Nhập QĐ"
        '
        'grcDanhSach_Lan1
        '
        Me.grcDanhSach_Lan1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        Me.grcDanhSach_Lan1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grcDanhSach_Lan1.Location = New System.Drawing.Point(261, 25)
        Me.grcDanhSach_Lan1.MainView = Me.grvDanhSach_CB1
        Me.grcDanhSach_Lan1.Name = "grcDanhSach_Lan1"
        Me.grcDanhSach_Lan1.Size = New System.Drawing.Size(798, 167)
        Me.grcDanhSach_Lan1.TabIndex = 170
        Me.grcDanhSach_Lan1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach_CB1})
        '
        'grvDanhSach_CB1
        '
        Me.grvDanhSach_CB1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Chon2, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn9, Me.Ly_do_cac_ky})
        Me.grvDanhSach_CB1.GridControl = Me.grcDanhSach_Lan1
        Me.grvDanhSach_CB1.Name = "grvDanhSach_CB1"
        Me.grvDanhSach_CB1.OptionsSelection.MultiSelect = True
        Me.grvDanhSach_CB1.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach_CB1.OptionsView.ShowViewCaption = True
        Me.grvDanhSach_CB1.ViewCaption = "DANH SÁCH SINH VIÊN THUỘC CÁNH BÁO LẦN 1"
        '
        'Chon2
        '
        Me.Chon2.Caption = "Chọn"
        Me.Chon2.FieldName = "Chon"
        Me.Chon2.Name = "Chon2"
        Me.Chon2.Visible = True
        Me.Chon2.VisibleIndex = 0
        Me.Chon2.Width = 30
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã SV"
        Me.GridColumn1.FieldName = "Ma_sv"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Họ tên"
        Me.GridColumn2.FieldName = "Ho_ten"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 120
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
        Me.GridColumn3.Width = 60
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên lớp"
        Me.GridColumn4.FieldName = "Ten_lop"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 60
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Lý do cảnh báo"
        Me.GridColumn9.FieldName = "Ly_do"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 207
        '
        'Ly_do_cac_ky
        '
        Me.Ly_do_cac_ky.Caption = "Lý do tổng hợp"
        Me.Ly_do_cac_ky.Name = "Ly_do_cac_ky"
        Me.Ly_do_cac_ky.Visible = True
        Me.Ly_do_cac_ky.VisibleIndex = 6
        Me.Ly_do_cac_ky.Width = 250
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(30, 361)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(100, 24)
        Me.optAll.TabIndex = 173
        Me.optAll.Text = "Chọn tất cả "
        Me.optAll.UseVisualStyleBackColor = False
        '
        'cmdNoiDung_CB
        '
        Me.cmdNoiDung_CB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNoiDung_CB.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNoiDung_CB.Appearance.Options.UseFont = True
        Me.cmdNoiDung_CB.ImageIndex = 10
        Me.cmdNoiDung_CB.ImageList = Me.ImgMain
        Me.cmdNoiDung_CB.Location = New System.Drawing.Point(377, 532)
        Me.cmdNoiDung_CB.Name = "cmdNoiDung_CB"
        Me.cmdNoiDung_CB.Size = New System.Drawing.Size(171, 30)
        Me.cmdNoiDung_CB.TabIndex = 181
        Me.cmdNoiDung_CB.Text = "Nhập nội dung cảnh báo"
        '
        'grcDanhSach_Lan2
        '
        Me.grcDanhSach_Lan2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach_Lan2.Location = New System.Drawing.Point(261, 193)
        Me.grcDanhSach_Lan2.MainView = Me.grvDanhSach_CB2
        Me.grcDanhSach_Lan2.Name = "grcDanhSach_Lan2"
        Me.grcDanhSach_Lan2.Size = New System.Drawing.Size(798, 167)
        Me.grcDanhSach_Lan2.TabIndex = 186
        Me.grcDanhSach_Lan2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach_CB2})
        '
        'grvDanhSach_CB2
        '
        Me.grvDanhSach_CB2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn18, Me.GridColumn21})
        Me.grvDanhSach_CB2.GridControl = Me.grcDanhSach_Lan2
        Me.grvDanhSach_CB2.Name = "grvDanhSach_CB2"
        Me.grvDanhSach_CB2.OptionsSelection.MultiSelect = True
        Me.grvDanhSach_CB2.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach_CB2.OptionsView.ShowViewCaption = True
        Me.grvDanhSach_CB2.ViewCaption = "DANH SÁCH SINH VIÊN THUỘC CÁNH BÁO LẦN 2"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Chọn"
        Me.GridColumn11.FieldName = "Chon"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 30
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Mã SV"
        Me.GridColumn12.FieldName = "Ma_sv"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 40
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Họ tên"
        Me.GridColumn13.FieldName = "Ho_ten"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        Me.GridColumn13.Width = 120
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Ngày sinh"
        Me.GridColumn14.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn14.FieldName = "Ngay_sinh"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        Me.GridColumn14.Width = 60
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Tên lớp"
        Me.GridColumn15.FieldName = "Ten_lop"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        Me.GridColumn15.Width = 50
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Lý do cảnh báo"
        Me.GridColumn18.FieldName = "Ly_do"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 5
        Me.GridColumn18.Width = 226
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Lý do tổng hợp"
        Me.GridColumn21.FieldName = "Ly_do_cac_ky"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 6
        Me.GridColumn21.Width = 251
        '
        'grcDanhSach_Lan3
        '
        Me.grcDanhSach_Lan3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach_Lan3.Location = New System.Drawing.Point(-1, 380)
        Me.grcDanhSach_Lan3.MainView = Me.grvDanhSach_CB3
        Me.grcDanhSach_Lan3.Name = "grcDanhSach_Lan3"
        Me.grcDanhSach_Lan3.Size = New System.Drawing.Size(1060, 152)
        Me.grcDanhSach_Lan3.TabIndex = 187
        Me.grcDanhSach_Lan3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach_CB3})
        '
        'grvDanhSach_CB3
        '
        Me.grvDanhSach_CB3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn29, Me.GridColumn32})
        Me.grvDanhSach_CB3.GridControl = Me.grcDanhSach_Lan3
        Me.grvDanhSach_CB3.Name = "grvDanhSach_CB3"
        Me.grvDanhSach_CB3.OptionsSelection.MultiSelect = True
        Me.grvDanhSach_CB3.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach_CB3.OptionsView.ShowViewCaption = True
        Me.grvDanhSach_CB3.ViewCaption = "DANH SÁCH SINH VIÊN THUỘC CÁNH BÁO LẦN 3"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Chọn"
        Me.GridColumn22.FieldName = "Chon"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 0
        Me.GridColumn22.Width = 30
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Mã SV"
        Me.GridColumn23.FieldName = "Ma_sv"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 1
        Me.GridColumn23.Width = 40
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Họ tên"
        Me.GridColumn24.FieldName = "Ho_ten"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 2
        Me.GridColumn24.Width = 120
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Ngày sinh"
        Me.GridColumn25.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn25.FieldName = "Ngay_sinh"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 3
        Me.GridColumn25.Width = 60
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Tên lớp"
        Me.GridColumn26.FieldName = "Ten_lop"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 4
        Me.GridColumn26.Width = 43
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Lý do lần cảnh báo"
        Me.GridColumn29.FieldName = "Ly_do"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 5
        Me.GridColumn29.Width = 300
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Lý do tổng hợp"
        Me.GridColumn32.FieldName = "Ly_do_cac_ky"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.ReadOnly = True
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 6
        Me.GridColumn32.Width = 446
        '
        'cmdInTongHop
        '
        Me.cmdInTongHop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInTongHop.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInTongHop.Appearance.Options.UseFont = True
        Me.cmdInTongHop.ImageIndex = 15
        Me.cmdInTongHop.ImageList = Me.ImgMain
        Me.cmdInTongHop.Location = New System.Drawing.Point(261, 532)
        Me.cmdInTongHop.Name = "cmdInTongHop"
        Me.cmdInTongHop.Size = New System.Drawing.Size(110, 30)
        Me.cmdInTongHop.TabIndex = 192
        Me.cmdInTongHop.Text = "In tổng hợp"
        '
        'frmEDU_XetLenLop_TongHop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1063, 566)
        Me.Controls.Add(Me.cmdInTongHop)
        Me.Controls.Add(Me.grcDanhSach_Lan3)
        Me.Controls.Add(Me.grcDanhSach_Lan2)
        Me.Controls.Add(Me.cmdNoiDung_CB)
        Me.Controls.Add(Me.grcDanhSach_Lan1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAddQD)
        Me.Controls.Add(Me.cmdZ)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmEDU_XetLenLop_TongHop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xét lên lớp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach_Lan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach_CB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach_Lan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach_CB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach_Lan3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach_CB3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvLop As ESSMarkMan.TreeViewLop
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents colTong_So_hoc_trinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_CanhBao3 As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents grvDanhSach_CB1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents Chon2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents grcDanhSach_Lan1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdNoiDung_CB As DevExpress.XtraEditors.SimpleButton
    Private WithEvents grcDanhSach_Lan3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach_CB3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents grcDanhSach_Lan2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach_CB2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ly_do_cac_ky As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrint_CanhBao1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint_CanhBao2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdInTongHop As DevExpress.XtraEditors.SimpleButton
End Class
