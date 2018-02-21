Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmESS_Main

#Region "Designer generated code"
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_Main))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.RibMain = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.pmAppMain = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.mnuPainStyle = New DevExpress.XtraBars.BarSubItem
        Me.biStyle = New DevExpress.XtraBars.BarEditItem
        Me.riicStyle = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.staInfomation = New DevExpress.XtraBars.BarStaticItem
        Me.mnuHeThong = New DevExpress.XtraBars.BarSubItem
        Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribHeThong = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.ribgHeThong = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
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
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibMain.Images = Me.imageCollection1
        Me.RibMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibMain.ExpandCollapseItem, Me.mnuPainStyle, Me.biStyle, Me.staInfomation, Me.mnuHeThong})
        Me.RibMain.LargeImages = Me.imageCollection2
        Me.RibMain.Location = New System.Drawing.Point(0, 0)
        Me.RibMain.MaxItemId = 126
        Me.RibMain.Name = "RibMain"
        Me.RibMain.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.ribbonPageCategory1})
        Me.RibMain.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
        Me.RibMain.PageHeaderItemLinks.Add(Me.biStyle)
        Me.RibMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribHeThong})
        Me.RibMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.RepositoryItemPictureEdit1, Me.riicStyle})
        Me.RibMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibMain.SelectedPage = Me.ribHeThong
        Me.RibMain.ShowToolbarCustomizeItem = False
        Me.RibMain.Size = New System.Drawing.Size(1093, 160)
        Me.RibMain.StatusBar = Me.ribbonStatusBar1
        Me.RibMain.Toolbar.ItemLinks.Add(Me.mnuHeThong)
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
        'staInfomation
        '
        Me.staInfomation.Caption = "THÔNG TIN NGƯỜI DÙNG"
        Me.staInfomation.Id = 122
        Me.staInfomation.ImageIndex = 24
        Me.staInfomation.Name = "staInfomation"
        Me.staInfomation.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'mnuHeThong
        '
        Me.mnuHeThong.Caption = "HỆ THỐNG"
        Me.mnuHeThong.Id = 125
        Me.mnuHeThong.ImageIndex = 8
        Me.mnuHeThong.Name = "mnuHeThong"
        '
        'imageCollection2
        '
        Me.imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection2.Images.SetKeyName(0, "1.jpg")
        Me.imageCollection2.Images.SetKeyName(1, "2.jpg")
        Me.imageCollection2.Images.SetKeyName(2, "3.jpg")
        Me.imageCollection2.Images.SetKeyName(3, "4.jpg")
        Me.imageCollection2.Images.SetKeyName(4, "5.jpg")
        Me.imageCollection2.Images.SetKeyName(5, "6.jpg")
        Me.imageCollection2.Images.SetKeyName(6, "7.jpg")
        Me.imageCollection2.Images.SetKeyName(7, "8.jpg")
        Me.imageCollection2.Images.SetKeyName(8, "9.jpg")
        Me.imageCollection2.Images.SetKeyName(9, "10.jpg")
        Me.imageCollection2.Images.SetKeyName(10, "11.jpg")
        Me.imageCollection2.Images.SetKeyName(11, "12.jpg")
        Me.imageCollection2.Images.SetKeyName(12, "13.jpg")
        Me.imageCollection2.Images.SetKeyName(13, "14.jpg")
        Me.imageCollection2.Images.SetKeyName(14, "15.jpg")
        Me.imageCollection2.Images.SetKeyName(15, "16.jpg")
        Me.imageCollection2.Images.SetKeyName(16, "17.jpg")
        Me.imageCollection2.Images.SetKeyName(17, "18.jpg")
        Me.imageCollection2.Images.SetKeyName(18, "19.jpg")
        Me.imageCollection2.Images.SetKeyName(19, "20.jpg")
        Me.imageCollection2.Images.SetKeyName(20, "21.jpg")
        Me.imageCollection2.Images.SetKeyName(21, "22.jpg")
        Me.imageCollection2.Images.SetKeyName(22, "23.jpg")
        Me.imageCollection2.Images.SetKeyName(23, "24.jpg")
        Me.imageCollection2.Images.SetKeyName(24, "25.jpg")
        Me.imageCollection2.Images.SetKeyName(25, "26.jpg")
        Me.imageCollection2.Images.SetKeyName(26, "27.jpg")
        Me.imageCollection2.Images.SetKeyName(27, "28.jpg")
        Me.imageCollection2.Images.SetKeyName(28, "29.jpg")
        Me.imageCollection2.Images.SetKeyName(29, "30.jpg")
        Me.imageCollection2.Images.SetKeyName(30, "31.jpg")
        Me.imageCollection2.Images.SetKeyName(31, "32.jpg")
        Me.imageCollection2.Images.SetKeyName(32, "33.jpg")
        Me.imageCollection2.Images.SetKeyName(33, "34.jpg")
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
        'ribHeThong
        '
        Me.ribHeThong.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribgHeThong})
        Me.ribHeThong.ImageIndex = 8
        Me.ribHeThong.Name = "ribHeThong"
        Me.ribHeThong.Text = "QUẢN TRỊ HỆ THỐNG"
        '
        'ribgHeThong
        '
        Me.ribgHeThong.Name = "ribgHeThong"
        ToolTipTitleItem1.Text = "HỆ THỐNG"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.ribgHeThong.SuperTip = SuperToolTip1
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
        Me.Text = "PHẦN MỀM QUẢN TRỊ HỆ THỐNG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pmAppMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Private imageCollection1 As DevExpress.Utils.ImageCollection
    Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents mnuPainStyle As DevExpress.XtraBars.BarSubItem
    Private pmAppMain As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
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
    Friend WithEvents staInfomation As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents mnuHeThong As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ribHeThong As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ribgHeThong As DevExpress.XtraBars.Ribbon.RibbonPageGroup

End Class
