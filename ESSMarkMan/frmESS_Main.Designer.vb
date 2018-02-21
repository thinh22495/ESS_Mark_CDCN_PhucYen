Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmESS_Main

#Region "Designer generated code"
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_Main))
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip12 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip13 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip14 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip15 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip16 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.RibMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.pmAppMain = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.mnuPainStyle = New DevExpress.XtraBars.BarSubItem
        Me.biStyle = New DevExpress.XtraBars.BarEditItem
        Me.riicStyle = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.mnuChuongTrinhDaoTao = New DevExpress.XtraBars.BarSubItem
        Me.mnuToChucThi = New DevExpress.XtraBars.BarSubItem
        Me.mnuQuanLyDiem = New DevExpress.XtraBars.BarSubItem
        Me.mnuTongHop = New DevExpress.XtraBars.BarSubItem
        Me.mnuTimKiem = New DevExpress.XtraBars.BarSubItem
        Me.mnuDanhMuc = New DevExpress.XtraBars.BarSubItem
        Me.staInfomation = New DevExpress.XtraBars.BarStaticItem
        Me.mnuXetDuyet = New DevExpress.XtraBars.BarSubItem
        Me.mnuHeThong = New DevExpress.XtraBars.BarSubItem
        Me.mnuNganh2 = New DevExpress.XtraBars.BarSubItem
        Me.ribbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribChuongTrinhDaoTao = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgChuongTrinhDaoTao = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribToChucThi = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgToChucThi = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribQuanLyDiem = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgQuanLyDiem = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibNganh2 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibGroupNganh2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribXetDuyet = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgXetDuyet = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribTongHop = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgTongHop = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribTimKiem = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgTimKiem = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribHeThong = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgHeThong = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.ribDanhMuc = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgDanhMuc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.pcAppMenuFileLabels = New DevExpress.XtraEditors.PanelControl
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repositoryItemSpinEdit1
        '
        Me.repositoryItemSpinEdit1.AutoHeight = False
        Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.repositoryItemSpinEdit1.IsFloatValue = False
        Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
        Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Size = New System.Drawing.Size(0, 0)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'RibMain
        '
        Me.RibMain.ApplicationButtonDropDownControl = Me.pmAppMain
        Me.RibMain.ApplicationButtonText = Nothing
        Me.RibMain.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))})
        '
        '
        '
        Me.RibMain.ExpandCollapseItem.Id = 0
        Me.RibMain.ExpandCollapseItem.Name = ""
        Me.RibMain.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        Me.RibMain.Images = Me.imageCollection2
        Me.RibMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibMain.ExpandCollapseItem, Me.mnuPainStyle, Me.biStyle, Me.mnuChuongTrinhDaoTao, Me.mnuToChucThi, Me.mnuQuanLyDiem, Me.mnuTongHop, Me.mnuTimKiem, Me.mnuDanhMuc, Me.staInfomation, Me.mnuXetDuyet, Me.mnuHeThong, Me.mnuNganh2})
        Me.RibMain.Location = New System.Drawing.Point(0, 0)
        Me.RibMain.MaxItemId = 127
        Me.RibMain.Name = "RibMain"
        Me.RibMain.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.ribbonPageCategory1})
        Me.RibMain.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
        Me.RibMain.PageHeaderItemLinks.Add(Me.biStyle)
        Me.RibMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribChuongTrinhDaoTao, Me.ribToChucThi, Me.ribQuanLyDiem, Me.RibNganh2, Me.ribXetDuyet, Me.ribTongHop, Me.ribTimKiem, Me.ribHeThong, Me.ribDanhMuc})
        Me.RibMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.RepositoryItemPictureEdit1, Me.riicStyle})
        Me.RibMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibMain.SelectedPage = Me.ribChuongTrinhDaoTao
        Me.RibMain.ShowToolbarCustomizeItem = False
        Me.RibMain.Size = New System.Drawing.Size(1093, 144)
        Me.RibMain.StatusBar = Me.ribbonStatusBar1
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuChuongTrinhDaoTao)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuToChucThi)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuQuanLyDiem)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuNganh2)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuXetDuyet)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuTongHop)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuTimKiem)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuHeThong)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuDanhMuc)
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuPainStyle)
        Me.RibMain.Toolbar.ShowCustomizeItem = False
        '
        'pmAppMain
        '
        Me.pmAppMain.BottomPaneControlContainer = Nothing
        Me.pmAppMain.Name = "pmAppMain"
        Me.pmAppMain.Ribbon = Me.RibMain
        Me.pmAppMain.RightPaneControlContainer = Nothing
        Me.pmAppMain.ShowRightPane = True
        '
        'imageCollection2
        '
        Me.imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection2.Images.SetKeyName(0, "Bill_48px.png")
        Me.imageCollection2.Images.SetKeyName(1, "Books_48px.png")
        Me.imageCollection2.Images.SetKeyName(2, "Brick_48px.png")
        Me.imageCollection2.Images.SetKeyName(3, "Calendar_48px.png")
        Me.imageCollection2.Images.SetKeyName(4, "Circled Play_48px.png")
        Me.imageCollection2.Images.SetKeyName(5, "Clear Search_48px.png")
        Me.imageCollection2.Images.SetKeyName(6, "Code File_48px.png")
        Me.imageCollection2.Images.SetKeyName(7, "Comic Book_48px.png")
        Me.imageCollection2.Images.SetKeyName(8, "Conference_48px.png")
        Me.imageCollection2.Images.SetKeyName(9, "Database View_48px.png")
        Me.imageCollection2.Images.SetKeyName(10, "Dove_48px.png")
        Me.imageCollection2.Images.SetKeyName(11, "Drop Down_48px.png")
        Me.imageCollection2.Images.SetKeyName(12, "Edit Property_48px.png")
        Me.imageCollection2.Images.SetKeyName(13, "Exam_48px.png")
        Me.imageCollection2.Images.SetKeyName(14, "Expired_48px.png")
        Me.imageCollection2.Images.SetKeyName(15, "FTP_48px.png")
        Me.imageCollection2.Images.SetKeyName(16, "Gears_48px.png")
        Me.imageCollection2.Images.SetKeyName(17, "Google Calendar_48px.png")
        Me.imageCollection2.Images.SetKeyName(18, "Graduation Cap_48px.png")
        Me.imageCollection2.Images.SetKeyName(19, "Grid 3_48px.png")
        Me.imageCollection2.Images.SetKeyName(20, "Home_48px.png")
        Me.imageCollection2.Images.SetKeyName(21, "ID Card_48px.png")
        Me.imageCollection2.Images.SetKeyName(22, "Info_48px.png")
        Me.imageCollection2.Images.SetKeyName(23, "Literature_48px.png")
        Me.imageCollection2.Images.SetKeyName(24, "Menu_64px.png")
        Me.imageCollection2.Images.SetKeyName(25, "Microsoft OneNote_48px.png")
        Me.imageCollection2.Images.SetKeyName(26, "Mockup_48px.png")
        Me.imageCollection2.Images.SetKeyName(27, "Multiple Choice_48px.png")
        Me.imageCollection2.Images.SetKeyName(28, "Octahedron_48px.png")
        Me.imageCollection2.Images.SetKeyName(29, "Open_48px.png")
        Me.imageCollection2.Images.SetKeyName(30, "Porn Folder_48px.png")
        Me.imageCollection2.Images.SetKeyName(31, "Print_48px.png")
        Me.imageCollection2.Images.SetKeyName(32, "Recycle_48px.png")
        Me.imageCollection2.Images.SetKeyName(33, "Remove Property_48px.png")
        Me.imageCollection2.Images.SetKeyName(34, "Search Property_48px.png")
        Me.imageCollection2.Images.SetKeyName(35, "Settings_48px.png")
        Me.imageCollection2.Images.SetKeyName(36, "Sheets_48px.png")
        Me.imageCollection2.Images.SetKeyName(37, "South_48px.png")
        Me.imageCollection2.Images.SetKeyName(38, "Star Filled_48px.png")
        Me.imageCollection2.Images.SetKeyName(39, "Sublime Text_48px.png")
        Me.imageCollection2.Images.SetKeyName(40, "Sugar Cube_48px.png")
        Me.imageCollection2.Images.SetKeyName(41, "Template_48px.png")
        Me.imageCollection2.Images.SetKeyName(42, "Trello_48px.png")
        Me.imageCollection2.Images.SetKeyName(43, "Triforce_48px.png")
        Me.imageCollection2.Images.SetKeyName(44, "Very Popular Topic_48px.png")
        Me.imageCollection2.Images.SetKeyName(45, "Video Conference_48px.png")
        Me.imageCollection2.Images.SetKeyName(46, "Video Trimming_48px.png")
        '
        'mnuPainStyle
        '
        Me.mnuPainStyle.Caption = "GIAO DIỆN"
        Me.mnuPainStyle.Description = "GIAO DIỆN"
        Me.mnuPainStyle.Hint = "GIAO DIỆN"
        Me.mnuPainStyle.Id = 7
        Me.mnuPainStyle.ImageIndex = 0
        Me.mnuPainStyle.Name = "mnuPainStyle"
        '
        'biStyle
        '
        Me.biStyle.Edit = Me.riicStyle
        Me.biStyle.Hint = "Ribbon Style"
        Me.biStyle.Id = 96
        Me.biStyle.Name = "biStyle"
        Me.biStyle.Width = 75
        '
        'riicStyle
        '
        Me.riicStyle.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.riicStyle.Appearance.Options.UseFont = True
        Me.riicStyle.AutoHeight = False
        Me.riicStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicStyle.Name = "riicStyle"
        '
        'mnuChuongTrinhDaoTao
        '
        Me.mnuChuongTrinhDaoTao.Caption = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.mnuChuongTrinhDaoTao.Hint = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.mnuChuongTrinhDaoTao.Id = 105
        Me.mnuChuongTrinhDaoTao.ImageIndex = 1
        Me.mnuChuongTrinhDaoTao.MenuCaption = "CHƯƠNG TRÌNH ĐÀO TẠO"
        Me.mnuChuongTrinhDaoTao.Name = "mnuChuongTrinhDaoTao"
        '
        'mnuToChucThi
        '
        Me.mnuToChucThi.Caption = "TỔ CHỨC THI"
        Me.mnuToChucThi.Hint = "TỔ CHỨC THI"
        Me.mnuToChucThi.Id = 106
        Me.mnuToChucThi.ImageIndex = 3
        Me.mnuToChucThi.MenuCaption = "TỔ CHỨC THI"
        Me.mnuToChucThi.Name = "mnuToChucThi"
        '
        'mnuQuanLyDiem
        '
        Me.mnuQuanLyDiem.Caption = "QUẢN LÝ ĐIỂM"
        Me.mnuQuanLyDiem.Hint = "QUẢN LÝ ĐIỂM"
        Me.mnuQuanLyDiem.Id = 107
        Me.mnuQuanLyDiem.ImageIndex = 4
        Me.mnuQuanLyDiem.MenuCaption = "QUẢN LÝ ĐIỂM"
        Me.mnuQuanLyDiem.Name = "mnuQuanLyDiem"
        '
        'mnuTongHop
        '
        Me.mnuTongHop.Caption = "BÁO CÁO TỔNG HỢP "
        Me.mnuTongHop.Hint = "BÁO CÁO TỔNG HỢP "
        Me.mnuTongHop.Id = 108
        Me.mnuTongHop.ImageIndex = 5
        Me.mnuTongHop.MenuCaption = "BÁO CÁO TỔNG HỢP "
        Me.mnuTongHop.Name = "mnuTongHop"
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Caption = "TÌM KIẾM"
        Me.mnuTimKiem.Hint = "TÌM KIẾM"
        Me.mnuTimKiem.Id = 109
        Me.mnuTimKiem.ImageIndex = 6
        Me.mnuTimKiem.MenuCaption = "TÌM KIẾM"
        Me.mnuTimKiem.Name = "mnuTimKiem"
        '
        'mnuDanhMuc
        '
        Me.mnuDanhMuc.Caption = "DANH MỤC"
        Me.mnuDanhMuc.Hint = "DANH MỤC"
        Me.mnuDanhMuc.Id = 110
        Me.mnuDanhMuc.ImageIndex = 7
        Me.mnuDanhMuc.MenuCaption = "DANH MỤC"
        Me.mnuDanhMuc.Name = "mnuDanhMuc"
        '
        'staInfomation
        '
        Me.staInfomation.Caption = "THÔNG TIN NGƯỜI DÙNG"
        Me.staInfomation.Id = 122
        Me.staInfomation.ImageIndex = 24
        Me.staInfomation.Name = "staInfomation"
        Me.staInfomation.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'mnuXetDuyet
        '
        Me.mnuXetDuyet.Caption = "XÉT DUYỆT"
        Me.mnuXetDuyet.Id = 124
        Me.mnuXetDuyet.ImageIndex = 7
        Me.mnuXetDuyet.Name = "mnuXetDuyet"
        '
        'mnuHeThong
        '
        Me.mnuHeThong.Caption = "HỆ THỐNG"
        Me.mnuHeThong.Id = 125
        Me.mnuHeThong.ImageIndex = 8
        Me.mnuHeThong.Name = "mnuHeThong"
        '
        'mnuNganh2
        '
        Me.mnuNganh2.Caption = "NGÀNH HỌC 2"
        Me.mnuNganh2.Id = 126
        Me.mnuNganh2.ImageIndex = 21
        Me.mnuNganh2.Name = "mnuNganh2"
        '
        'ribbonPageCategory1
        '
        Me.ribbonPageCategory1.Name = "ribbonPageCategory1"
        Me.ribbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage4})
        Me.ribbonPageCategory1.Text = "Chọn"
        '
        'ribbonPage4
        '
        Me.ribbonPage4.Name = "ribbonPage4"
        Me.ribbonPage4.Text = "Chọn"
        '
        'ribChuongTrinhDaoTao
        '
        Me.ribChuongTrinhDaoTao.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgChuongTrinhDaoTao})
        Me.ribChuongTrinhDaoTao.ImageIndex = 18
        Me.ribChuongTrinhDaoTao.Name = "ribChuongTrinhDaoTao"
        Me.ribChuongTrinhDaoTao.Text = "CHƯƠNG TRÌNH ĐÀO TẠO"
        '
        'ribgChuongTrinhDaoTao
        '
        Me.ribgChuongTrinhDaoTao.ImageIndex = 1
        Me.ribgChuongTrinhDaoTao.Name = "ribgChuongTrinhDaoTao"
        ToolTipTitleItem10.Text = "CHƯƠNG TRÌNH ĐÀO TẠO"
        ToolTipItem2.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipItem2.Appearance.Options.UseImage = True
        ToolTipItem2.Image = CType(resources.GetObject("ToolTipItem2.Image"), System.Drawing.Image)
        ToolTipItem2.LeftIndent = 6
        ToolTipTitleItem11.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipTitleItem11.Appearance.Options.UseImage = True
        ToolTipTitleItem11.Image = CType(resources.GetObject("ToolTipTitleItem11.Image"), System.Drawing.Image)
        ToolTipTitleItem11.LeftIndent = 6
        SuperToolTip9.Items.Add(ToolTipTitleItem10)
        SuperToolTip9.Items.Add(ToolTipItem2)
        SuperToolTip9.Items.Add(ToolTipTitleItem11)
        SuperToolTip9.MaxWidth = 600
        Me.ribgChuongTrinhDaoTao.SuperTip = SuperToolTip9
        '
        'ribToChucThi
        '
        Me.ribToChucThi.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgToChucThi})
        Me.ribToChucThi.ImageIndex = 2
        Me.ribToChucThi.Name = "ribToChucThi"
        Me.ribToChucThi.Text = "TỔ CHỨC THI"
        '
        'ribgToChucThi
        '
        Me.ribgToChucThi.ImageIndex = 26
        Me.ribgToChucThi.Name = "ribgToChucThi"
        ToolTipTitleItem12.Text = "TỔ CHỨC THI"
        SuperToolTip10.Items.Add(ToolTipTitleItem12)
        Me.ribgToChucThi.SuperTip = SuperToolTip10
        '
        'ribQuanLyDiem
        '
        Me.ribQuanLyDiem.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgQuanLyDiem})
        Me.ribQuanLyDiem.ImageIndex = 3
        Me.ribQuanLyDiem.Name = "ribQuanLyDiem"
        Me.ribQuanLyDiem.Text = "QUẢN LÝ ĐIỂM"
        '
        'ribgQuanLyDiem
        '
        Me.ribgQuanLyDiem.Name = "ribgQuanLyDiem"
        ToolTipTitleItem13.Text = "TỔNG HỢP"
        SuperToolTip11.Items.Add(ToolTipTitleItem13)
        Me.ribgQuanLyDiem.SuperTip = SuperToolTip11
        '
        'RibNganh2
        '
        Me.RibNganh2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibGroupNganh2})
        Me.RibNganh2.ImageIndex = 21
        Me.RibNganh2.Name = "RibNganh2"
        Me.RibNganh2.Text = "QUẢN LÝ NGÀNH 2"
        '
        'RibGroupNganh2
        '
        Me.RibGroupNganh2.Name = "RibGroupNganh2"
        '
        'ribXetDuyet
        '
        Me.ribXetDuyet.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgXetDuyet})
        Me.ribXetDuyet.ImageIndex = 7
        Me.ribXetDuyet.Name = "ribXetDuyet"
        Me.ribXetDuyet.Text = "XÉT DUYỆT"
        '
        'ribgXetDuyet
        '
        Me.ribgXetDuyet.Name = "ribgXetDuyet"
        ToolTipTitleItem14.Text = "XÉT DUYỆT"
        SuperToolTip12.Items.Add(ToolTipTitleItem14)
        Me.ribgXetDuyet.SuperTip = SuperToolTip12
        '
        'ribTongHop
        '
        Me.ribTongHop.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgTongHop})
        Me.ribTongHop.ImageIndex = 16
        Me.ribTongHop.Name = "ribTongHop"
        Me.ribTongHop.Text = "TỔNG HỢP"
        '
        'ribgTongHop
        '
        Me.ribgTongHop.Name = "ribgTongHop"
        ToolTipTitleItem15.Text = "TỔNG HỢP"
        SuperToolTip13.Items.Add(ToolTipTitleItem15)
        Me.ribgTongHop.SuperTip = SuperToolTip13
        '
        'ribTimKiem
        '
        Me.ribTimKiem.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgTimKiem})
        Me.ribTimKiem.ImageIndex = 5
        Me.ribTimKiem.Name = "ribTimKiem"
        Me.ribTimKiem.Text = "TÌM KIẾM"
        '
        'ribgTimKiem
        '
        Me.ribgTimKiem.Name = "ribgTimKiem"
        ToolTipTitleItem16.Text = "TÌM KIẾM"
        SuperToolTip14.Items.Add(ToolTipTitleItem16)
        Me.ribgTimKiem.SuperTip = SuperToolTip14
        '
        'ribHeThong
        '
        Me.ribHeThong.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgHeThong})
        Me.ribHeThong.ImageIndex = 8
        Me.ribHeThong.Name = "ribHeThong"
        Me.ribHeThong.Text = "HỆ THỐNG"
        '
        'ribgHeThong
        '
        Me.ribgHeThong.Name = "ribgHeThong"
        ToolTipTitleItem17.Text = "HỆ THỐNG"
        SuperToolTip15.Items.Add(ToolTipTitleItem17)
        Me.ribgHeThong.SuperTip = SuperToolTip15
        '
        'ribDanhMuc
        '
        Me.ribDanhMuc.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgDanhMuc})
        Me.ribDanhMuc.ImageIndex = 6
        Me.ribDanhMuc.Name = "ribDanhMuc"
        Me.ribDanhMuc.Text = "DANH MỤC"
        '
        'ribgDanhMuc
        '
        Me.ribgDanhMuc.Name = "ribgDanhMuc"
        ToolTipTitleItem18.Text = "DANH MỤC"
        SuperToolTip16.Items.Add(ToolTipTitleItem18)
        Me.ribgDanhMuc.SuperTip = SuperToolTip16
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.AllowFocused = False
        Me.RepositoryItemPictureEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'ribbonStatusBar1
        '
        Me.ribbonStatusBar1.ItemLinks.Add(Me.staInfomation)
        Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 558)
        Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
        Me.ribbonStatusBar1.Ribbon = Me.RibMain
        Me.ribbonStatusBar1.Size = New System.Drawing.Size(1093, 25)
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection1.Images.SetKeyName(0, "1.jpg")
        Me.imageCollection1.Images.SetKeyName(1, "2.jpg")
        Me.imageCollection1.Images.SetKeyName(2, "3.jpg")
        Me.imageCollection1.Images.SetKeyName(3, "4.jpg")
        Me.imageCollection1.Images.SetKeyName(4, "5.jpg")
        Me.imageCollection1.Images.SetKeyName(5, "7.jpg")
        Me.imageCollection1.Images.SetKeyName(6, "8.jpg")
        Me.imageCollection1.Images.SetKeyName(7, "9.jpg")
        Me.imageCollection1.Images.SetKeyName(8, "10.jpg")
        Me.imageCollection1.Images.SetKeyName(9, "11.jpg")
        Me.imageCollection1.Images.SetKeyName(10, "12.jpg")
        Me.imageCollection1.Images.SetKeyName(11, "13.jpg")
        Me.imageCollection1.Images.SetKeyName(12, "14.jpg")
        Me.imageCollection1.Images.SetKeyName(13, "15.jpg")
        Me.imageCollection1.Images.SetKeyName(14, "18.jpg")
        Me.imageCollection1.Images.SetKeyName(15, "19.jpg")
        Me.imageCollection1.Images.SetKeyName(16, "5.jpg")
        Me.imageCollection1.Images.SetKeyName(17, "7.jpg")
        Me.imageCollection1.Images.SetKeyName(18, "8.jpg")
        Me.imageCollection1.Images.SetKeyName(19, "9.jpg")
        Me.imageCollection1.Images.SetKeyName(20, "10.jpg")
        Me.imageCollection1.Images.SetKeyName(21, "1.jpg")
        Me.imageCollection1.Images.SetKeyName(22, "2.jpg")
        Me.imageCollection1.Images.SetKeyName(23, "15.jpg")
        Me.imageCollection1.Images.SetKeyName(24, "19.jpg")
        '
        'imageCollection3
        '
        Me.imageCollection3.ImageSize = New System.Drawing.Size(15, 15)
        Me.imageCollection3.ImageStream = CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection3.Images.SetKeyName(0, "1.jpg")
        Me.imageCollection3.Images.SetKeyName(1, "2.jpg")
        Me.imageCollection3.Images.SetKeyName(2, "3.jpg")
        Me.imageCollection3.Images.SetKeyName(3, "4.jpg")
        Me.imageCollection3.Images.SetKeyName(4, "5.jpg")
        Me.imageCollection3.Images.SetKeyName(5, "6.jpg")
        Me.imageCollection3.Images.SetKeyName(6, "7.jpg")
        Me.imageCollection3.Images.SetKeyName(7, "8.jpg")
        Me.imageCollection3.Images.SetKeyName(8, "9.jpg")
        Me.imageCollection3.Images.SetKeyName(9, "10.jpg")
        Me.imageCollection3.Images.SetKeyName(10, "11.jpg")
        Me.imageCollection3.Images.SetKeyName(11, "12.jpg")
        Me.imageCollection3.Images.SetKeyName(12, "13.jpg")
        Me.imageCollection3.Images.SetKeyName(13, "14.jpg")
        Me.imageCollection3.Images.SetKeyName(14, "15.jpg")
        Me.imageCollection3.Images.SetKeyName(15, "16.jpg")
        Me.imageCollection3.Images.SetKeyName(16, "17.jpg")
        Me.imageCollection3.Images.SetKeyName(17, "18.jpg")
        Me.imageCollection3.Images.SetKeyName(18, "19.jpg")
        Me.imageCollection3.Images.SetKeyName(19, "20.jpg")
        Me.imageCollection3.Images.SetKeyName(20, "21.jpg")
        Me.imageCollection3.Images.SetKeyName(21, "22.jpg")
        Me.imageCollection3.Images.SetKeyName(22, "23.jpg")
        Me.imageCollection3.Images.SetKeyName(23, "24.jpg")
        Me.imageCollection3.Images.SetKeyName(24, "25.jpg")
        Me.imageCollection3.Images.SetKeyName(25, "26.jpg")
        Me.imageCollection3.Images.SetKeyName(26, "27.jpg")
        Me.imageCollection3.Images.SetKeyName(27, "28.jpg")
        Me.imageCollection3.Images.SetKeyName(28, "29.jpg")
        Me.imageCollection3.Images.SetKeyName(29, "30.jpg")
        Me.imageCollection3.Images.SetKeyName(30, "31.jpg")
        Me.imageCollection3.Images.SetKeyName(31, "32.jpg")
        Me.imageCollection3.Images.SetKeyName(32, "33.jpg")
        Me.imageCollection3.Images.SetKeyName(33, "34.jpg")
        '
        'pcAppMenuFileLabels
        '
        Me.pcAppMenuFileLabels.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcAppMenuFileLabels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcAppMenuFileLabels.Location = New System.Drawing.Point(10, 19)
        Me.pcAppMenuFileLabels.Name = "pcAppMenuFileLabels"
        Me.pcAppMenuFileLabels.Size = New System.Drawing.Size(300, 143)
        Me.pcAppMenuFileLabels.TabIndex = 2
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.labelControl1.LineVisible = True
        Me.labelControl1.Location = New System.Drawing.Point(10, 0)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(300, 19)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Recent Documents:"
        '
        'panelControl1
        '
        Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelControl1.Location = New System.Drawing.Point(0, 0)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(10, 162)
        Me.panelControl1.TabIndex = 1
        '
        'defaultLookAndFeel1
        '
        Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue"
        '
        'xtraTabbedMdiManager1
        '
        Me.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtraTabbedMdiManager1.MdiParent = Me
        '
        'frmESS_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1093, 583)
        Me.Controls.Add(Me.ribbonStatusBar1)
        Me.Controls.Add(Me.RibMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmESS_Main"
        Me.Ribbon = Me.RibMain
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar1
        Me.Text = "PHẦN MỀM QUẢN LÝ KẾT QUẢ HỌC TẬP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcAppMenuFileLabels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private components As System.ComponentModel.IContainer
    Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    'Private ribMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribChuongTrinhDaoTao As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribgChuongTrinhDaoTao As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribToChucThi As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribgToChucThi As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Private imageCollection1 As DevExpress.Utils.ImageCollection
    Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents mnuPainStyle As DevExpress.XtraBars.BarSubItem
    Private pmAppMain As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private ribQuanLyDiem As DevExpress.XtraBars.Ribbon.RibbonPage
    Private imageCollection2 As DevExpress.Utils.ImageCollection
    Private ribbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    'Private pccAppMenu As PopupControlContainer
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private pcAppMenuFileLabels As DevExpress.XtraEditors.PanelControl
    Private imageCollection3 As DevExpress.Utils.ImageCollection
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents biStyle As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riicStyle As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ribTongHop As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribTimKiem As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribDanhMuc As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgQuanLyDiem As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribgTongHop As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribgTimKiem As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ribgDanhMuc As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuChuongTrinhDaoTao As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuToChucThi As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuQuanLyDiem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuTongHop As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuTimKiem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuDanhMuc As DevExpress.XtraBars.BarSubItem
    Friend WithEvents staInfomation As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ribXetDuyet As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgXetDuyet As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuXetDuyet As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuHeThong As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ribHeThong As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgHeThong As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibNganh2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibGroupNganh2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuNganh2 As DevExpress.XtraBars.BarSubItem

End Class
