<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetTotNghiep_DangKy123
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_XetTotNghiep_DangKy123))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DS_luanvan = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DS_totnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DS_nototnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.cmdDuyet = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.grcLuanVan = New DevExpress.XtraGrid.GridControl
        Me.grvLanVan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_tin_chi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinhVien_duyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCoVan_duyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcLuanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_luanvan), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_totnghiep), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_nototnghiep), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_luanvan), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_totnghiep)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DS_luanvan
        '
        Me.cmdPrint_DS_luanvan.Caption = "Làm luận văn"
        Me.cmdPrint_DS_luanvan.Id = 0
        Me.cmdPrint_DS_luanvan.ImageIndex = 16
        Me.cmdPrint_DS_luanvan.Name = "cmdPrint_DS_luanvan"
        '
        'cmdPrint_DS_totnghiep
        '
        Me.cmdPrint_DS_totnghiep.Caption = "Thi tốt nghiệp"
        Me.cmdPrint_DS_totnghiep.Id = 1
        Me.cmdPrint_DS_totnghiep.ImageIndex = 16
        Me.cmdPrint_DS_totnghiep.Name = "cmdPrint_DS_totnghiep"
        '
        'cmdPrint_DS_nototnghiep
        '
        Me.cmdPrint_DS_nototnghiep.Caption = "Nợ thi tốt nghiệp"
        Me.cmdPrint_DS_nototnghiep.Id = 2
        Me.cmdPrint_DS_nototnghiep.ImageIndex = 16
        Me.cmdPrint_DS_nototnghiep.Name = "cmdPrint_DS_nototnghiep"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_DS_luanvan, Me.cmdPrint_DS_totnghiep, Me.cmdPrint_DS_nototnghiep})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(784, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 562)
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 562)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 562)
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(0, 38)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(258, 524)
        Me.TreeViewLop.TabIndex = 171
        '
        'cmdDuyet
        '
        Me.cmdDuyet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDuyet.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDuyet.Appearance.Options.UseFont = True
        Me.cmdDuyet.ImageIndex = 17
        Me.cmdDuyet.ImageList = Me.ImgMain
        Me.cmdDuyet.Location = New System.Drawing.Point(407, 532)
        Me.cmdDuyet.Name = "cmdDuyet"
        Me.cmdDuyet.Size = New System.Drawing.Size(133, 30)
        Me.cmdDuyet.TabIndex = 175
        Me.cmdDuyet.Text = "Duyệt sang thi TN"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(670, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 174
        Me.cmdClose.Text = "Thoát"
        '
        'grcLuanVan
        '
        Me.grcLuanVan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcLuanVan.Location = New System.Drawing.Point(255, 47)
        Me.grcLuanVan.MainView = Me.grvLanVan
        Me.grcLuanVan.Name = "grcLuanVan"
        Me.grcLuanVan.Size = New System.Drawing.Size(525, 479)
        Me.grcLuanVan.TabIndex = 172
        Me.grcLuanVan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLanVan})
        '
        'grvLanVan
        '
        Me.grvLanVan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colSo_tin_chi, Me.colTBCHT, Me.colSinhVien_duyet, Me.colCoVan_duyet})
        Me.grvLanVan.GridControl = Me.grcLuanVan
        Me.grvLanVan.Name = "grvLanVan"
        Me.grvLanVan.OptionsSelection.MultiSelect = True
        Me.grvLanVan.OptionsView.ShowAutoFilterRow = True
        Me.grvLanVan.OptionsView.ShowGroupPanel = False
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.AllowEdit = False
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 1
        Me.colHo_ten.Width = 163
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.AllowEdit = False
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 2
        Me.colNgay_sinh.Width = 85
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.AllowEdit = False
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 3
        Me.colTen_lop.Width = 76
        '
        'colSo_tin_chi
        '
        Me.colSo_tin_chi.Caption = "Số tín chỉ"
        Me.colSo_tin_chi.FieldName = "So_tin_chi"
        Me.colSo_tin_chi.Name = "colSo_tin_chi"
        Me.colSo_tin_chi.OptionsColumn.AllowEdit = False
        Me.colSo_tin_chi.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colSo_tin_chi.Visible = True
        Me.colSo_tin_chi.VisibleIndex = 4
        Me.colSo_tin_chi.Width = 58
        '
        'colTBCHT
        '
        Me.colTBCHT.Caption = "TBC tích lũy"
        Me.colTBCHT.FieldName = "TBCHT"
        Me.colTBCHT.Name = "colTBCHT"
        Me.colTBCHT.OptionsColumn.AllowEdit = False
        Me.colTBCHT.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colTBCHT.Visible = True
        Me.colTBCHT.VisibleIndex = 5
        Me.colTBCHT.Width = 83
        '
        'colSinhVien_duyet
        '
        Me.colSinhVien_duyet.Caption = "SV đăng ký"
        Me.colSinhVien_duyet.FieldName = "SinhVien_duyet"
        Me.colSinhVien_duyet.Name = "colSinhVien_duyet"
        Me.colSinhVien_duyet.Visible = True
        Me.colSinhVien_duyet.VisibleIndex = 6
        '
        'colCoVan_duyet
        '
        Me.colCoVan_duyet.Caption = "Cố vấn HT duyệt"
        Me.colCoVan_duyet.FieldName = "CoVan_duyet"
        Me.colCoVan_duyet.Name = "colCoVan_duyet"
        Me.colCoVan_duyet.Visible = True
        Me.colCoVan_duyet.VisibleIndex = 7
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(546, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(115, 30)
        Me.cmdExport.TabIndex = 173
        Me.cmdExport.Text = "Xuất Excel"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(513, 23)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "DUYỆT SINH VIÊN ĐĂNG KÝ XÉT TỐT NGHIỆP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmESS_XetTotNghiep_DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.cmdDuyet)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grcLuanVan)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Name = "frmESS_XetTotNghiep_DangKy"
        Me.Text = "DUYET SINH VIEN DANG KY XET TOT NGHIEP"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcLuanVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLanVan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_DS_luanvan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DS_totnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DS_nototnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents cmdDuyet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcLuanVan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLanVan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_tin_chi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinhVien_duyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoVan_duyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
