<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_LopTinChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DanhSachSinhVien_LopTinChi))
        Me.trvLopTinChi = New ESSMarkMan.TreeViewLopTinChi
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNoi_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DanhSach = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DSDiemDanh = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trvLopTinChi
        '
        Me.trvLopTinChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLopTinChi.BackColor = System.Drawing.Color.Transparent
        Me.trvLopTinChi.dsID_lop_tc = ""
        Me.trvLopTinChi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLopTinChi.ID_lop_tc = 0
        Me.trvLopTinChi.ID_mon = 0
        Me.trvLopTinChi.ID_mon_tc = 0
        Me.trvLopTinChi.ID_mon_tc_thi = 0
        Me.trvLopTinChi.Location = New System.Drawing.Point(0, 0)
        Me.trvLopTinChi.Name = "trvLopTinChi"
        Me.trvLopTinChi.Size = New System.Drawing.Size(264, 564)
        Me.trvLopTinChi.TabIndex = 87
        Me.trvLopTinChi.Ten_lop_tc = ""
        Me.trvLopTinChi.Ten_mon = ""
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(263, 12)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(527, 514)
        Me.grcDanhSach.TabIndex = 152
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTen_khoa, Me.colNoi_sinh})
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
        Me.colMa_sv.Width = 62
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 94
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
        Me.colNgay_sinh.Width = 62
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        '
        'colTen_khoa
        '
        Me.colTen_khoa.Caption = "Tên khoa"
        Me.colTen_khoa.FieldName = "Ten_khoa"
        Me.colTen_khoa.Name = "colTen_khoa"
        Me.colTen_khoa.Visible = True
        Me.colTen_khoa.VisibleIndex = 5
        Me.colTen_khoa.Width = 163
        '
        'colNoi_sinh
        '
        Me.colNoi_sinh.Caption = "Nơi sinh"
        Me.colNoi_sinh.FieldName = "Noi_sinh"
        Me.colNoi_sinh.Name = "colNoi_sinh"
        Me.colNoi_sinh.Visible = True
        Me.colNoi_sinh.VisibleIndex = 6
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(403, 532)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(135, 30)
        Me.cmdPrintList.TabIndex = 153
        Me.cmdPrintList.Text = "In danh sách"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DanhSach), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSDiemDanh)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DanhSach
        '
        Me.cmdPrint_DanhSach.Caption = "Danh sách lớp"
        Me.cmdPrint_DanhSach.Id = 0
        Me.cmdPrint_DanhSach.ImageIndex = 16
        Me.cmdPrint_DanhSach.Name = "cmdPrint_DanhSach"
        '
        'cmdPrint_DSDiemDanh
        '
        Me.cmdPrint_DSDiemDanh.Caption = "Danh sách điểm danh"
        Me.cmdPrint_DSDiemDanh.Id = 1
        Me.cmdPrint_DSDiemDanh.ImageIndex = 16
        Me.cmdPrint_DSDiemDanh.Name = "cmdPrint_DSDiemDanh"
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("PopupMenu", New System.Guid("e259ec3f-8673-4306-bb4f-94322df1890e"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_DanhSach, Me.cmdPrint_DSDiemDanh})
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
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(548, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(115, 30)
        Me.cmdExport.TabIndex = 158
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(672, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 158
        Me.cmdClose.Text = "Thoát"
        '
        'frmESS_DanhSachSinhVienLopTinChi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.trvLopTinChi)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmESS_DanhSachSinhVienLopTinChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH SINH VIEN LOP TIN CHI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvLopTinChi As ESSMarkMan.TreeViewLopTinChi
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoi_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_DanhSach As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdPrint_DSDiemDanh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
End Class
