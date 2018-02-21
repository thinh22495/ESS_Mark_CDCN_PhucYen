<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThamSoHeThong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ThamSoHeThong))
        Me.grcDanhSachThamSo = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThamSo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTen_tham_so = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGia_tri = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDanhSachThamSo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThamSo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcDanhSachThamSo
        '
        Me.grcDanhSachThamSo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThamSo.Location = New System.Drawing.Point(2, 1)
        Me.grcDanhSachThamSo.MainView = Me.grvDanhSachThamSo
        Me.grcDanhSachThamSo.Name = "grcDanhSachThamSo"
        Me.grcDanhSachThamSo.Size = New System.Drawing.Size(790, 522)
        Me.grcDanhSachThamSo.TabIndex = 151
        Me.grcDanhSachThamSo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThamSo})
        '
        'grvDanhSachThamSo
        '
        Me.grvDanhSachThamSo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTen_tham_so, Me.colGia_tri, Me.colGhi_chu, Me.colActive})
        Me.grvDanhSachThamSo.GridControl = Me.grcDanhSachThamSo
        Me.grvDanhSachThamSo.Name = "grvDanhSachThamSo"
        Me.grvDanhSachThamSo.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThamSo.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThamSo.OptionsView.ShowGroupPanel = False
        '
        'colTen_tham_so
        '
        Me.colTen_tham_so.Caption = "Tên tham số"
        Me.colTen_tham_so.FieldName = "Ten_tham_so"
        Me.colTen_tham_so.Name = "colTen_tham_so"
        Me.colTen_tham_so.OptionsColumn.ReadOnly = True
        Me.colTen_tham_so.Visible = True
        Me.colTen_tham_so.VisibleIndex = 0
        Me.colTen_tham_so.Width = 188
        '
        'colGia_tri
        '
        Me.colGia_tri.Caption = "Giá trị"
        Me.colGia_tri.FieldName = "Gia_tri"
        Me.colGia_tri.Name = "colGia_tri"
        Me.colGia_tri.Visible = True
        Me.colGia_tri.VisibleIndex = 1
        Me.colGia_tri.Width = 100
        '
        'colGhi_chu
        '
        Me.colGhi_chu.Caption = "Ghi chú"
        Me.colGhi_chu.FieldName = "Ghi_chu"
        Me.colGhi_chu.Name = "colGhi_chu"
        Me.colGhi_chu.OptionsColumn.ReadOnly = True
        Me.colGhi_chu.Visible = True
        Me.colGhi_chu.VisibleIndex = 2
        Me.colGhi_chu.Width = 364
        '
        'colActive
        '
        Me.colActive.Caption = "Áp dụng"
        Me.colActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 3
        Me.colActive.Width = 100
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
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(712, 530)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 31)
        Me.cmdClose.TabIndex = 153
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(631, 530)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 31)
        Me.cmdSave.TabIndex = 152
        Me.cmdSave.Text = "Lưu"
        '
        'frmESS_ThamSoHeThong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grcDanhSachThamSo)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_ThamSoHeThong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tham số hệ thống"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcDanhSachThamSo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThamSo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grcDanhSachThamSo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThamSo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_tham_so As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGia_tri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
