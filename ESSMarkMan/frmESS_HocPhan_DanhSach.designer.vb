<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_HocPhan_DanhSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_HocPhan_DanhSach))
        Me.grcDanhSachHP = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachHP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_tieng_anh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_nhom_hp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lukNhom_hp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colID_he = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lukTrinhDo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colID_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExcel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDanhSachHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lukNhom_hp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lukTrinhDo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcDanhSachHP
        '
        Me.grcDanhSachHP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachHP.Location = New System.Drawing.Point(4, 3)
        Me.grcDanhSachHP.MainView = Me.grvDanhSachHP
        Me.grcDanhSachHP.Name = "grcDanhSachHP"
        Me.grcDanhSachHP.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lukNhom_hp, Me.lukTrinhDo})
        Me.grcDanhSachHP.Size = New System.Drawing.Size(785, 521)
        Me.grcDanhSachHP.TabIndex = 153
        Me.grcDanhSachHP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachHP})
        '
        'grvDanhSachHP
        '
        Me.grvDanhSachHP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu, Me.colTen_mon, Me.colTen_tieng_anh, Me.colID_nhom_hp, Me.colID_he, Me.colID_mon})
        Me.grvDanhSachHP.GridControl = Me.grcDanhSachHP
        Me.grvDanhSachHP.Name = "grvDanhSachHP"
        Me.grvDanhSachHP.OptionsSelection.MultiSelect = True
        Me.grvDanhSachHP.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachHP.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Ký hiệu"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.ReadOnly = True
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 0
        Me.colKy_hieu.Width = 62
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên Học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.ReadOnly = True
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 94
        '
        'colTen_tieng_anh
        '
        Me.colTen_tieng_anh.Caption = "Tên tiếng anh"
        Me.colTen_tieng_anh.FieldName = "Ten_tieng_anh"
        Me.colTen_tieng_anh.Name = "colTen_tieng_anh"
        Me.colTen_tieng_anh.Visible = True
        Me.colTen_tieng_anh.VisibleIndex = 2
        '
        'colID_nhom_hp
        '
        Me.colID_nhom_hp.Caption = "Nhóm học phần"
        Me.colID_nhom_hp.ColumnEdit = Me.lukNhom_hp
        Me.colID_nhom_hp.FieldName = "ID_nhom_hp"
        Me.colID_nhom_hp.Name = "colID_nhom_hp"
        Me.colID_nhom_hp.Visible = True
        Me.colID_nhom_hp.VisibleIndex = 3
        '
        'lukNhom_hp
        '
        Me.lukNhom_hp.AutoHeight = False
        Me.lukNhom_hp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lukNhom_hp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom", "Tên nhóm")})
        Me.lukNhom_hp.DisplayMember = "Ten_nhom"
        Me.lukNhom_hp.Name = "lukNhom_hp"
        Me.lukNhom_hp.ValueMember = "ID_nhom_hp"
        '
        'colID_he
        '
        Me.colID_he.Caption = "Trình độ đào tạo"
        Me.colID_he.ColumnEdit = Me.lukTrinhDo
        Me.colID_he.FieldName = "ID_he"
        Me.colID_he.Name = "colID_he"
        Me.colID_he.Visible = True
        Me.colID_he.VisibleIndex = 4
        '
        'lukTrinhDo
        '
        Me.lukTrinhDo.AutoHeight = False
        Me.lukTrinhDo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lukTrinhDo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_he", "Trình độ đào tạo")})
        Me.lukTrinhDo.DisplayMember = "Ten_he"
        Me.lukTrinhDo.Name = "lukTrinhDo"
        Me.lukTrinhDo.ValueMember = "ID_he"
        '
        'colID_mon
        '
        Me.colID_mon.Caption = "ID_mon"
        Me.colID_mon.FieldName = "ID_mon"
        Me.colID_mon.Name = "colID_mon"
        Me.colID_mon.OptionsColumn.ReadOnly = True
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
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ImageIndex = 12
        Me.cmdEdit.ImageList = Me.ImgMain
        Me.cmdEdit.Location = New System.Drawing.Point(550, 531)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 30)
        Me.cmdEdit.TabIndex = 154
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(631, 531)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 30)
        Me.cmdDelete.TabIndex = 154
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(712, 531)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 30)
        Me.cmdClose.TabIndex = 154
        Me.cmdClose.Text = "Thoát"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(468, 531)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 30)
        Me.cmdAdd.TabIndex = 154
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdExcel
        '
        Me.cmdExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExcel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcel.Appearance.Options.UseFont = True
        Me.cmdExcel.ImageIndex = 6
        Me.cmdExcel.ImageList = Me.ImgMain
        Me.cmdExcel.Location = New System.Drawing.Point(352, 531)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(110, 30)
        Me.cmdExcel.TabIndex = 155
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'frmESS_HocPhan_DanhSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.grcDanhSachHP)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_HocPhan_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách Học phần"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grcDanhSachHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lukNhom_hp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lukTrinhDo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grcDanhSachHP As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachHP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents colID_nhom_hp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_he As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lukNhom_hp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lukTrinhDo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colTen_tieng_anh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExcel As DevExpress.XtraEditors.SimpleButton
End Class
