<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_ThemSinhVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThi_ThemSinhVien))
        Me.cmbLocTheo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkAll1 = New System.Windows.Forms.CheckBox
        Me.chkAll2 = New System.Windows.Forms.CheckBox
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_ngoai_ngu = New System.Windows.Forms.ComboBox
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.optTheoKhoa = New System.Windows.Forms.CheckBox
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.trvLopTinChi = New ESSMarkMan.TreeViewLopTinChi
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDanhSachThiChon = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThiChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbLocTheo
        '
        Me.cmbLocTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocTheo.FormattingEnabled = True
        Me.cmbLocTheo.Items.AddRange(New Object() {"Theo lớp tín chỉ", "Sinh viên thi lại lớp tín chỉ", "Sinh viên thi lại lớp hành chính", "Theo lớp hành chính", "Theo sinh viên tốt nghiệp", "Theo sinh viên làm luận văn", "Sinh viên thi nâng điểm theo lớp tín chỉ", "Sinh viên thi nâng điểm theo lớp hành chính", "Sinh viên đăng ký thi cải thiện", "Sinh viên thi lại không ktra tài chính", "Sinh viên thi lại (<5)"})
        Me.cmbLocTheo.Location = New System.Drawing.Point(129, 2)
        Me.cmbLocTheo.Name = "cmbLocTheo"
        Me.cmbLocTheo.Size = New System.Drawing.Size(245, 24)
        Me.cmbLocTheo.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Lọc sinh viên theo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll1
        '
        Me.chkAll1.AutoSize = True
        Me.chkAll1.BackColor = System.Drawing.Color.Transparent
        Me.chkAll1.Location = New System.Drawing.Point(280, 32)
        Me.chkAll1.Name = "chkAll1"
        Me.chkAll1.Size = New System.Drawing.Size(100, 20)
        Me.chkAll1.TabIndex = 59
        Me.chkAll1.Text = "Chọn tất cả"
        Me.chkAll1.UseVisualStyleBackColor = False
        '
        'chkAll2
        '
        Me.chkAll2.AutoSize = True
        Me.chkAll2.BackColor = System.Drawing.Color.Transparent
        Me.chkAll2.Location = New System.Drawing.Point(280, 275)
        Me.chkAll2.Name = "chkAll2"
        Me.chkAll2.Size = New System.Drawing.Size(100, 20)
        Me.chkAll2.TabIndex = 61
        Me.chkAll2.Text = "Chọn tất cả"
        Me.chkAll2.UseVisualStyleBackColor = False
        '
        'txtSo_sv
        '
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(674, 276)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(65, 18)
        Me.txtSo_sv.TabIndex = 98
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTong_so
        '
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTong_so.Location = New System.Drawing.Point(533, 276)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(140, 18)
        Me.lblTong_so.TabIndex = 97
        Me.lblTong_so.Text = "Tổng số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(703, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Ngoại ngữ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_ngoai_ngu
        '
        Me.cmbID_ngoai_ngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_ngoai_ngu.FormattingEnabled = True
        Me.cmbID_ngoai_ngu.Items.AddRange(New Object() {"Tiếng Anh", "Tiếng Nga", "Tiếng Pháp"})
        Me.cmbID_ngoai_ngu.Location = New System.Drawing.Point(783, 3)
        Me.cmbID_ngoai_ngu.Name = "cmbID_ngoai_ngu"
        Me.cmbID_ngoai_ngu.Size = New System.Drawing.Size(104, 24)
        Me.cmbID_ngoai_ngu.TabIndex = 100
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.lblSo_sv.Location = New System.Drawing.Point(660, 5)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(46, 18)
        Me.lblSo_sv.TabIndex = 103
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(535, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Tổng số sinh viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optTheoKhoa
        '
        Me.optTheoKhoa.AutoSize = True
        Me.optTheoKhoa.BackColor = System.Drawing.Color.Transparent
        Me.optTheoKhoa.Location = New System.Drawing.Point(5, 32)
        Me.optTheoKhoa.Name = "optTheoKhoa"
        Me.optTheoKhoa.Size = New System.Drawing.Size(190, 20)
        Me.optTheoKhoa.TabIndex = 178
        Me.optTheoKhoa.Text = "Chỉ hiện thị sv đã đăng ký"
        Me.optTheoKhoa.UseVisualStyleBackColor = False
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(0, 54)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(264, 568)
        Me.TreeViewLop.TabIndex = 54
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
        Me.trvLopTinChi.Khoa_hoc = 0
        Me.trvLopTinChi.Location = New System.Drawing.Point(0, 54)
        Me.trvLopTinChi.Name = "trvLopTinChi"
        Me.trvLopTinChi.Size = New System.Drawing.Size(264, 568)
        Me.trvLopTinChi.TabIndex = 99
        Me.trvLopTinChi.Ten_he = ""
        Me.trvLopTinChi.Ten_lop_tc = ""
        Me.trvLopTinChi.Ten_mon = ""
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(268, 54)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(619, 215)
        Me.grcDanhSachThi.TabIndex = 179
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop})
        Me.grvDanhSachThi.GridControl = Me.grcDanhSachThi
        Me.grvDanhSachThi.Name = "grvDanhSachThi"
        Me.grvDanhSachThi.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThi.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThi.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 47
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 80
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 120
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
        Me.colNgay_sinh.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 61
        '
        'grcDanhSachThiChon
        '
        Me.grcDanhSachThiChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThiChon.Location = New System.Drawing.Point(268, 302)
        Me.grcDanhSachThiChon.MainView = Me.grvDanhSachThiChon
        Me.grcDanhSachThiChon.Name = "grcDanhSachThiChon"
        Me.grcDanhSachThiChon.Size = New System.Drawing.Size(619, 283)
        Me.grcDanhSachThiChon.TabIndex = 180
        Me.grcDanhSachThiChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThiChon})
        '
        'grvDanhSachThiChon
        '
        Me.grvDanhSachThiChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon1, Me.colMa_sv1, Me.colHo_ten1, Me.colNgay_sinh1, Me.colTen_lop1})
        Me.grvDanhSachThiChon.GridControl = Me.grcDanhSachThiChon
        Me.grvDanhSachThiChon.Name = "grvDanhSachThiChon"
        Me.grvDanhSachThiChon.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThiChon.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThiChon.OptionsView.ShowGroupPanel = False
        '
        'colChon1
        '
        Me.colChon1.Caption = "Chọn"
        Me.colChon1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon1.FieldName = "Chon"
        Me.colChon1.Name = "colChon1"
        Me.colChon1.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colChon1.Visible = True
        Me.colChon1.VisibleIndex = 0
        Me.colChon1.Width = 47
        '
        'colMa_sv1
        '
        Me.colMa_sv1.Caption = "Mã SV"
        Me.colMa_sv1.FieldName = "Ma_sv"
        Me.colMa_sv1.Name = "colMa_sv1"
        Me.colMa_sv1.OptionsColumn.ReadOnly = True
        Me.colMa_sv1.Visible = True
        Me.colMa_sv1.VisibleIndex = 1
        Me.colMa_sv1.Width = 80
        '
        'colHo_ten1
        '
        Me.colHo_ten1.Caption = "Họ tên"
        Me.colHo_ten1.FieldName = "Ho_ten"
        Me.colHo_ten1.Name = "colHo_ten1"
        Me.colHo_ten1.OptionsColumn.ReadOnly = True
        Me.colHo_ten1.Visible = True
        Me.colHo_ten1.VisibleIndex = 2
        Me.colHo_ten1.Width = 120
        '
        'colNgay_sinh1
        '
        Me.colNgay_sinh1.Caption = "Ngày sinh"
        Me.colNgay_sinh1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh1.FieldName = "Ngay_sinh"
        Me.colNgay_sinh1.Name = "colNgay_sinh1"
        Me.colNgay_sinh1.OptionsColumn.ReadOnly = True
        Me.colNgay_sinh1.Visible = True
        Me.colNgay_sinh1.VisibleIndex = 3
        Me.colNgay_sinh1.Width = 100
        '
        'colTen_lop1
        '
        Me.colTen_lop1.Caption = "Tên lớp"
        Me.colTen_lop1.FieldName = "Ten_lop"
        Me.colTen_lop1.Name = "colTen_lop1"
        Me.colTen_lop1.OptionsColumn.ReadOnly = True
        Me.colTen_lop1.Visible = True
        Me.colTen_lop1.VisibleIndex = 4
        Me.colTen_lop1.Width = 61
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.ImageIndex = 4
        Me.cmdRemove.ImageList = Me.ImgMain
        Me.cmdRemove.Location = New System.Drawing.Point(811, 271)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 29)
        Me.cmdRemove.TabIndex = 182
        Me.cmdRemove.Text = "Xóa"
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
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(730, 271)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 29)
        Me.cmdAdd.TabIndex = 181
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(730, 591)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(77, 31)
        Me.cmdSave.TabIndex = 184
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(811, 591)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 31)
        Me.cmdClose.TabIndex = 185
        Me.cmdClose.Text = "Thoát"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFind.ImageIndex = 19
        Me.cmdFind.ImageList = Me.ImgMain
        Me.cmdFind.Location = New System.Drawing.Point(647, 591)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(77, 31)
        Me.cmdFind.TabIndex = 183
        Me.cmdFind.Text = "Tìm kiếm"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 23)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Mã sv:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(425, 3)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(110, 23)
        Me.txtMa_sv.TabIndex = 177
        '
        'frmESS_ToChucThi_ThemSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 626)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grcDanhSachThiChon)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.optTheoKhoa)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_ngoai_ngu)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.chkAll2)
        Me.Controls.Add(Me.chkAll1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLocTheo)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.trvLopTinChi)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ToChucThi_ThemSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Tổ chức thi thêm sinh viên"
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents cmbLocTheo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents trvLopTinChi As ESSMarkMan.TreeViewLopTinChi
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_ngoai_ngu As System.Windows.Forms.ComboBox
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optTheoKhoa As System.Windows.Forms.CheckBox
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grvDanhSachThiChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Public WithEvents grcDanhSachThiChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
End Class
