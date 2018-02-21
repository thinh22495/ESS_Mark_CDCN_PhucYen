<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetTotNghiep_DangKy_Xet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_XetTotNghiep_DangKy_Xet))
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grcLuanVan = New DevExpress.XtraGrid.GridControl
        Me.grvLanVan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinhVien_duyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCoVan_duyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.cmdDuyet = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcLuanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grcLuanVan
        '
        Me.grcLuanVan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcLuanVan.Location = New System.Drawing.Point(257, 31)
        Me.grcLuanVan.MainView = Me.grvLanVan
        Me.grcLuanVan.Name = "grcLuanVan"
        Me.grcLuanVan.Size = New System.Drawing.Size(525, 498)
        Me.grcLuanVan.TabIndex = 112
        Me.grcLuanVan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLanVan})
        '
        'grvLanVan
        '
        Me.grvLanVan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colSinhVien_duyet, Me.colCoVan_duyet})
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
        Me.colHo_ten.Width = 147
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.AllowEdit = False
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 2
        Me.colNgay_sinh.Width = 77
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.AllowEdit = False
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 3
        Me.colTen_lop.Width = 68
        '
        'colSinhVien_duyet
        '
        Me.colSinhVien_duyet.Caption = "SV đăng ký"
        Me.colSinhVien_duyet.FieldName = "SinhVien_duyet"
        Me.colSinhVien_duyet.Name = "colSinhVien_duyet"
        Me.colSinhVien_duyet.Tag = True
        Me.colSinhVien_duyet.Visible = True
        Me.colSinhVien_duyet.VisibleIndex = 4
        Me.colSinhVien_duyet.Width = 67
        '
        'colCoVan_duyet
        '
        Me.colCoVan_duyet.Caption = "Cố vấn HT duyệt"
        Me.colCoVan_duyet.FieldName = "CoVan_duyet"
        Me.colCoVan_duyet.Name = "colCoVan_duyet"
        Me.colCoVan_duyet.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colCoVan_duyet.Visible = True
        Me.colCoVan_duyet.VisibleIndex = 5
        Me.colCoVan_duyet.Width = 72
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(2, 29)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(258, 521)
        Me.TreeViewLop.TabIndex = 111
        '
        'cmdDuyet
        '
        Me.cmdDuyet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDuyet.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDuyet.Appearance.Options.UseFont = True
        Me.cmdDuyet.ImageIndex = 17
        Me.cmdDuyet.ImageList = Me.ImgMain
        Me.cmdDuyet.Location = New System.Drawing.Point(529, 531)
        Me.cmdDuyet.Name = "cmdDuyet"
        Me.cmdDuyet.Size = New System.Drawing.Size(133, 30)
        Me.cmdDuyet.TabIndex = 172
        Me.cmdDuyet.Text = "Duyệt Tốt Nghiệp"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(668, 531)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 171
        Me.cmdClose.Text = "Thoát"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(475, 23)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "DUYỆT KẾT QUẢ ĐĂNG KÝ XÉT TỐT NGHIỆP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã SV"
        Me.GridColumn1.FieldName = "Ma_SV"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 73
        '
        'frmESS_XetTotNghiep_DangKy_Xet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdDuyet)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grcLuanVan)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Name = "frmESS_XetTotNghiep_DangKy_Xet"
        Me.Text = "DANG KY XET TOT NGHIEP"
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcLuanVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLanVan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grcLuanVan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLanVan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinhVien_duyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoVan_duyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents cmdDuyet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
