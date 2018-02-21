<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_QuyetDinh_DanhSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DanhSachSinhVien_QuyetDinh_DanhSach))
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLoai_QD = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtmNgay_xet = New System.Windows.Forms.DateTimePicker
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grcDanhSachQuyetDinh = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachQuyetDinh = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSo_QD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_QD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_do = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDanhSachSV = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachSV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLop_moi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd_NgungHoc = New DevExpress.XtraEditors.SimpleButton
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd_HocTiep = New DevExpress.XtraEditors.SimpleButton
        Me.cmdXoa_ESSQD = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint_QD = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd_ChuyenTruong = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachQuyetDinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachQuyetDinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(466, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Loại QĐ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_QD
        '
        Me.cmbLoai_QD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoai_QD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_QD.Items.AddRange(New Object() {"", "Ngừng học-Bảo lưu", "Thôi học-Xóa tên", "Chuyển trường", "Xét học tiếp"})
        Me.cmbLoai_QD.Location = New System.Drawing.Point(532, 9)
        Me.cmbLoai_QD.Name = "cmbLoai_QD"
        Me.cmbLoai_QD.Size = New System.Drawing.Size(238, 24)
        Me.cmbLoai_QD.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(122, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(193, 9)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(100, 24)
        Me.cmbNam_hoc.TabIndex = 107
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Items.AddRange(New Object() {"01", "02"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(68, 9)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(54, 24)
        Me.cmbHoc_ky.TabIndex = 123
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "Kỳ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(33, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 24)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Hệ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Location = New System.Drawing.Point(68, 39)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(225, 24)
        Me.cmbID_he.TabIndex = 126
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(370, 41)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(58, 24)
        Me.cmbKhoa_hoc.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Khoá:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Location = New System.Drawing.Point(532, 39)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(238, 24)
        Me.cmbID_khoa.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(486, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Khoa:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(294, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Ngày xét:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmNgay_xet
        '
        Me.dtmNgay_xet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmNgay_xet.Location = New System.Drawing.Point(370, 9)
        Me.dtmNgay_xet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtmNgay_xet.Name = "dtmNgay_xet"
        Me.dtmNgay_xet.Size = New System.Drawing.Size(90, 23)
        Me.dtmNgay_xet.TabIndex = 132
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "So_QD"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Số QĐ"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ngay_QD"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ngày QĐ"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ly_do"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nội dung"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 670
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 670
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 350
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 350
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tên lớp cũ"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Lop_moi"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tên lớp mới"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 140
        '
        'grcDanhSachQuyetDinh
        '
        Me.grcDanhSachQuyetDinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachQuyetDinh.Location = New System.Drawing.Point(3, 70)
        Me.grcDanhSachQuyetDinh.MainView = Me.grvDanhSachQuyetDinh
        Me.grcDanhSachQuyetDinh.Name = "grcDanhSachQuyetDinh"
        Me.grcDanhSachQuyetDinh.Size = New System.Drawing.Size(788, 206)
        Me.grcDanhSachQuyetDinh.TabIndex = 151
        Me.grcDanhSachQuyetDinh.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachQuyetDinh})
        '
        'grvDanhSachQuyetDinh
        '
        Me.grvDanhSachQuyetDinh.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSo_QD, Me.colNgay_QD, Me.colLy_do})
        Me.grvDanhSachQuyetDinh.GridControl = Me.grcDanhSachQuyetDinh
        Me.grvDanhSachQuyetDinh.Name = "grvDanhSachQuyetDinh"
        Me.grvDanhSachQuyetDinh.OptionsSelection.MultiSelect = True
        Me.grvDanhSachQuyetDinh.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachQuyetDinh.OptionsView.ShowGroupPanel = False
        '
        'colSo_QD
        '
        Me.colSo_QD.Caption = "Số quyết định"
        Me.colSo_QD.FieldName = "So_QD"
        Me.colSo_QD.Name = "colSo_QD"
        Me.colSo_QD.OptionsColumn.ReadOnly = True
        Me.colSo_QD.Visible = True
        Me.colSo_QD.VisibleIndex = 0
        Me.colSo_QD.Width = 100
        '
        'colNgay_QD
        '
        Me.colNgay_QD.Caption = "Ngày sinh"
        Me.colNgay_QD.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_QD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_QD.FieldName = "Ngay_QD"
        Me.colNgay_QD.Name = "colNgay_QD"
        Me.colNgay_QD.OptionsColumn.ReadOnly = True
        Me.colNgay_QD.Visible = True
        Me.colNgay_QD.VisibleIndex = 1
        Me.colNgay_QD.Width = 100
        '
        'colLy_do
        '
        Me.colLy_do.Caption = "Lý do"
        Me.colLy_do.FieldName = "Ly_do"
        Me.colLy_do.Name = "colLy_do"
        Me.colLy_do.Visible = True
        Me.colLy_do.VisibleIndex = 2
        Me.colLy_do.Width = 250
        '
        'grcDanhSachSV
        '
        Me.grcDanhSachSV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachSV.Location = New System.Drawing.Point(3, 320)
        Me.grcDanhSachSV.MainView = Me.grvDanhSachSV
        Me.grcDanhSachSV.Name = "grcDanhSachSV"
        Me.grcDanhSachSV.Size = New System.Drawing.Size(788, 242)
        Me.grcDanhSachSV.TabIndex = 152
        Me.grcDanhSachSV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachSV})
        '
        'grvDanhSachSV
        '
        Me.grvDanhSachSV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colLop_moi})
        Me.grvDanhSachSV.GridControl = Me.grcDanhSachSV
        Me.grvDanhSachSV.Name = "grvDanhSachSV"
        Me.grvDanhSachSV.OptionsSelection.MultiSelect = True
        Me.grvDanhSachSV.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachSV.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 37
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 100
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 150
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
        Me.colTen_lop.Caption = "Lớp mới"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 120
        '
        'colLop_moi
        '
        Me.colLop_moi.Caption = "Lớp cũ"
        Me.colLop_moi.FieldName = "Lop_moi"
        Me.colLop_moi.Name = "colLop_moi"
        Me.colLop_moi.OptionsColumn.ReadOnly = True
        Me.colLop_moi.Visible = True
        Me.colLop_moi.VisibleIndex = 5
        Me.colLop_moi.Width = 250
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(713, 283)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 31)
        Me.cmdClose.TabIndex = 157
        Me.cmdClose.Text = "Thoát"
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
        'cmdAdd_NgungHoc
        '
        Me.cmdAdd_NgungHoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd_NgungHoc.ImageIndex = 0
        Me.cmdAdd_NgungHoc.ImageList = Me.ImgMain
        Me.cmdAdd_NgungHoc.Location = New System.Drawing.Point(84, 283)
        Me.cmdAdd_NgungHoc.Name = "cmdAdd_NgungHoc"
        Me.cmdAdd_NgungHoc.Size = New System.Drawing.Size(107, 31)
        Me.cmdAdd_NgungHoc.TabIndex = 156
        Me.cmdAdd_NgungHoc.Text = "Nhập thôi học"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFind.ImageIndex = 19
        Me.cmdFind.ImageList = Me.ImgMain
        Me.cmdFind.Location = New System.Drawing.Point(4, 283)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(77, 31)
        Me.cmdFind.TabIndex = 156
        Me.cmdFind.Text = "Tìm kiếm"
        '
        'cmdAdd_HocTiep
        '
        Me.cmdAdd_HocTiep.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd_HocTiep.ImageIndex = 0
        Me.cmdAdd_HocTiep.ImageList = Me.ImgMain
        Me.cmdAdd_HocTiep.Location = New System.Drawing.Point(197, 283)
        Me.cmdAdd_HocTiep.Name = "cmdAdd_HocTiep"
        Me.cmdAdd_HocTiep.Size = New System.Drawing.Size(107, 31)
        Me.cmdAdd_HocTiep.TabIndex = 156
        Me.cmdAdd_HocTiep.Text = "Xét học tiếp"
        '
        'cmdXoa_ESSQD
        '
        Me.cmdXoa_ESSQD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdXoa_ESSQD.ImageIndex = 4
        Me.cmdXoa_ESSQD.ImageList = Me.ImgMain
        Me.cmdXoa_ESSQD.Location = New System.Drawing.Point(420, 283)
        Me.cmdXoa_ESSQD.Name = "cmdXoa_ESSQD"
        Me.cmdXoa_ESSQD.Size = New System.Drawing.Size(107, 31)
        Me.cmdXoa_ESSQD.TabIndex = 157
        Me.cmdXoa_ESSQD.Text = "Xóa Quyết định"
        '
        'cmdPrint_QD
        '
        Me.cmdPrint_QD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint_QD.ImageIndex = 16
        Me.cmdPrint_QD.ImageList = Me.ImgMain
        Me.cmdPrint_QD.Location = New System.Drawing.Point(532, 283)
        Me.cmdPrint_QD.Name = "cmdPrint_QD"
        Me.cmdPrint_QD.Size = New System.Drawing.Size(94, 31)
        Me.cmdPrint_QD.TabIndex = 157
        Me.cmdPrint_QD.Text = "In quyết định"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(632, 283)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(77, 31)
        Me.cmdExport.TabIndex = 157
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdAdd_ChuyenTruong
        '
        Me.cmdAdd_ChuyenTruong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd_ChuyenTruong.ImageIndex = 0
        Me.cmdAdd_ChuyenTruong.ImageList = Me.ImgMain
        Me.cmdAdd_ChuyenTruong.Location = New System.Drawing.Point(309, 283)
        Me.cmdAdd_ChuyenTruong.Name = "cmdAdd_ChuyenTruong"
        Me.cmdAdd_ChuyenTruong.Size = New System.Drawing.Size(107, 31)
        Me.cmdAdd_ChuyenTruong.TabIndex = 156
        Me.cmdAdd_ChuyenTruong.Text = "Chuyển trường"
        '
        'frmESS_DanhSachSinhVien_QuyetDinh_DanhSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdPrint_QD)
        Me.Controls.Add(Me.cmdXoa_ESSQD)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdAdd_ChuyenTruong)
        Me.Controls.Add(Me.cmdAdd_HocTiep)
        Me.Controls.Add(Me.cmdAdd_NgungHoc)
        Me.Controls.Add(Me.grcDanhSachSV)
        Me.Controls.Add(Me.grcDanhSachQuyetDinh)
        Me.Controls.Add(Me.dtmNgay_xet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbLoai_QD)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_DanhSachSinhVien_QuyetDinh_DanhSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH SACH NGUNG HOC THOI HOC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachQuyetDinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachQuyetDinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLoai_QD As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtmNgay_xet As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grcDanhSachQuyetDinh As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachQuyetDinh As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSo_QD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_QD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_do As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDanhSachSV As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachSV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLop_moi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd_NgungHoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdXoa_ESSQD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd_HocTiep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint_QD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd_ChuyenTruong As DevExpress.XtraEditors.SimpleButton
End Class
