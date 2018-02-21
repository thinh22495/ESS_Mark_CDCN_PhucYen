<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhungChuongTrinhDaoTao_NhomTuChon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhungChuongTrinhDaoTao_NhomTuChon))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbNhom_tu_chon = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSo_mon_dang_ky = New System.Windows.Forms.TextBox
        Me.txtSo_mon_tu_chon = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grcHocPhan = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNhom_tu_chon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_kien_thuc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcHocPhanChon = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhanChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNhom_tu_chon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_mon_dang_ky = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhanChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhanChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(350, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Chọn"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nhóm tự chọn:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNhom_tu_chon
        '
        Me.cmbNhom_tu_chon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhom_tu_chon.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbNhom_tu_chon.ItemHeight = 16
        Me.cmbNhom_tu_chon.Location = New System.Drawing.Point(113, 277)
        Me.cmbNhom_tu_chon.Name = "cmbNhom_tu_chon"
        Me.cmbNhom_tu_chon.Size = New System.Drawing.Size(231, 24)
        Me.cmbNhom_tu_chon.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(444, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "trong"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(541, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Học phần"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSo_mon_dang_ky
        '
        Me.txtSo_mon_dang_ky.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSo_mon_dang_ky.Location = New System.Drawing.Point(394, 278)
        Me.txtSo_mon_dang_ky.MaxLength = 2
        Me.txtSo_mon_dang_ky.Name = "txtSo_mon_dang_ky"
        Me.txtSo_mon_dang_ky.Size = New System.Drawing.Size(44, 23)
        Me.txtSo_mon_dang_ky.TabIndex = 45
        '
        'txtSo_mon_tu_chon
        '
        Me.txtSo_mon_tu_chon.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSo_mon_tu_chon.Location = New System.Drawing.Point(493, 278)
        Me.txtSo_mon_tu_chon.MaxLength = 2
        Me.txtSo_mon_tu_chon.Name = "txtSo_mon_tu_chon"
        Me.txtSo_mon_tu_chon.ReadOnly = True
        Me.txtSo_mon_tu_chon.Size = New System.Drawing.Size(44, 23)
        Me.txtSo_mon_tu_chon.TabIndex = 46
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grcHocPhan
        '
        Me.grcHocPhan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhan.Location = New System.Drawing.Point(2, 1)
        Me.grcHocPhan.MainView = Me.grvHocPhan
        Me.grcHocPhan.Name = "grcHocPhan"
        Me.grcHocPhan.Size = New System.Drawing.Size(787, 270)
        Me.grcHocPhan.TabIndex = 52
        Me.grcHocPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhan})
        '
        'grvHocPhan
        '
        Me.grvHocPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu, Me.colTen_mon, Me.colSo_hoc_trinh, Me.colNhom_tu_chon, Me.colTen_kien_thuc})
        Me.grvHocPhan.GridControl = Me.grcHocPhan
        Me.grvHocPhan.Name = "grvHocPhan"
        Me.grvHocPhan.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Mã học phần"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 0
        Me.colKy_hieu.Width = 87
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 264
        '
        'colSo_hoc_trinh
        '
        Me.colSo_hoc_trinh.Caption = "Số tín chỉ"
        Me.colSo_hoc_trinh.FieldName = "So_hoc_trinh"
        Me.colSo_hoc_trinh.Name = "colSo_hoc_trinh"
        Me.colSo_hoc_trinh.Visible = True
        Me.colSo_hoc_trinh.VisibleIndex = 2
        Me.colSo_hoc_trinh.Width = 92
        '
        'colNhom_tu_chon
        '
        Me.colNhom_tu_chon.Caption = "Nhóm tự chọn"
        Me.colNhom_tu_chon.FieldName = "Nhom_tu_chon"
        Me.colNhom_tu_chon.Name = "colNhom_tu_chon"
        Me.colNhom_tu_chon.Visible = True
        Me.colNhom_tu_chon.VisibleIndex = 3
        Me.colNhom_tu_chon.Width = 90
        '
        'colTen_kien_thuc
        '
        Me.colTen_kien_thuc.Caption = "Tên kiến thức"
        Me.colTen_kien_thuc.FieldName = "Ten_kien_thuc"
        Me.colTen_kien_thuc.Name = "colTen_kien_thuc"
        Me.colTen_kien_thuc.Visible = True
        Me.colTen_kien_thuc.VisibleIndex = 4
        Me.colTen_kien_thuc.Width = 233
        '
        'grcHocPhanChon
        '
        Me.grcHocPhanChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhanChon.Location = New System.Drawing.Point(2, 308)
        Me.grcHocPhanChon.MainView = Me.grvHocPhanChon
        Me.grcHocPhanChon.Name = "grcHocPhanChon"
        Me.grcHocPhanChon.Size = New System.Drawing.Size(787, 221)
        Me.grcHocPhanChon.TabIndex = 53
        Me.grcHocPhanChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhanChon})
        '
        'grvHocPhanChon
        '
        Me.grvHocPhanChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu2, Me.colTen_mon2, Me.colSo_hoc_trinh2, Me.colNhom_tu_chon2, Me.colSo_mon_dang_ky})
        Me.grvHocPhanChon.GridControl = Me.grcHocPhanChon
        Me.grvHocPhanChon.Name = "grvHocPhanChon"
        Me.grvHocPhanChon.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu2
        '
        Me.colKy_hieu2.Caption = "Mã học phần"
        Me.colKy_hieu2.FieldName = "Ky_hieu2"
        Me.colKy_hieu2.Name = "colKy_hieu2"
        Me.colKy_hieu2.Visible = True
        Me.colKy_hieu2.VisibleIndex = 0
        Me.colKy_hieu2.Width = 90
        '
        'colTen_mon2
        '
        Me.colTen_mon2.Caption = "Tên học phần"
        Me.colTen_mon2.FieldName = "Ten_mon2"
        Me.colTen_mon2.Name = "colTen_mon2"
        Me.colTen_mon2.Visible = True
        Me.colTen_mon2.VisibleIndex = 1
        Me.colTen_mon2.Width = 252
        '
        'colSo_hoc_trinh2
        '
        Me.colSo_hoc_trinh2.Caption = "Số tín chỉ"
        Me.colSo_hoc_trinh2.FieldName = "So_hoc_trinh2"
        Me.colSo_hoc_trinh2.Name = "colSo_hoc_trinh2"
        Me.colSo_hoc_trinh2.Visible = True
        Me.colSo_hoc_trinh2.VisibleIndex = 2
        Me.colSo_hoc_trinh2.Width = 100
        '
        'colNhom_tu_chon2
        '
        Me.colNhom_tu_chon2.Caption = "Nhóm tự chọn"
        Me.colNhom_tu_chon2.FieldName = "Nhom_tu_chon2"
        Me.colNhom_tu_chon2.Name = "colNhom_tu_chon2"
        Me.colNhom_tu_chon2.Visible = True
        Me.colNhom_tu_chon2.VisibleIndex = 3
        Me.colNhom_tu_chon2.Width = 83
        '
        'colSo_mon_dang_ky
        '
        Me.colSo_mon_dang_ky.Caption = "Số Học phần chọn"
        Me.colSo_mon_dang_ky.FieldName = "So_mon_dang_ky"
        Me.colSo_mon_dang_ky.Name = "colSo_mon_dang_ky"
        Me.colSo_mon_dang_ky.Visible = True
        Me.colSo_mon_dang_ky.VisibleIndex = 4
        Me.colSo_mon_dang_ky.Width = 241
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Appearance.Options.UseFont = True
        Me.cmdRemove.ImageIndex = 4
        Me.cmdRemove.ImageList = Me.ImgMain
        Me.cmdRemove.Location = New System.Drawing.Point(723, 274)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(66, 30)
        Me.cmdRemove.TabIndex = 172
        Me.cmdRemove.Text = "Xóa"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(652, 274)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(66, 30)
        Me.cmdAdd.TabIndex = 172
        Me.cmdAdd.Text = "Thêm"
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
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(700, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 173
        Me.cmdClose.Text = "Thoát"
        '
        'frmESS_ChuongTrinhDaoTaoMonChon
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.grcHocPhanChon)
        Me.Controls.Add(Me.grcHocPhan)
        Me.Controls.Add(Me.txtSo_mon_tu_chon)
        Me.Controls.Add(Me.txtSo_mon_dang_ky)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNhom_tu_chon)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ChuongTrinhDaoTaoMonChon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHUONG TRINH DAO TAO - MON TU CHON"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhanChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhanChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNhom_tu_chon As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSo_mon_dang_ky As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_mon_tu_chon As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grcHocPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNhom_tu_chon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_kien_thuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcHocPhanChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhanChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNhom_tu_chon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_mon_dang_ky As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
End Class
