<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_QuyetDinhThoiHoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_QuyetDinhThoiHoc))
        Me.txtSo_QD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtmNgay_qd = New System.Windows.Forms.DateTimePicker
        Me.txtLy_do = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLoai_qd = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.lblLop = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.lblKhoaHoc = New System.Windows.Forms.Label
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSachChon = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMa_sv1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSo_QD
        '
        Me.txtSo_QD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_QD.Location = New System.Drawing.Point(123, 34)
        Me.txtSo_QD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSo_QD.MaxLength = 30
        Me.txtSo_QD.Name = "txtSo_QD"
        Me.txtSo_QD.Size = New System.Drawing.Size(124, 26)
        Me.txtSo_QD.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(36, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 26)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Số QĐ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNam_hoc.Location = New System.Drawing.Point(593, 2)
        Me.cmbNam_hoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(138, 27)
        Me.cmbNam_hoc.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(503, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 27)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Items.AddRange(New Object() {"01", "02"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(123, 2)
        Me.cmbHoc_ky.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(63, 27)
        Me.cmbHoc_ky.TabIndex = 121
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 4)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 25)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Học kỳ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmNgay_qd
        '
        Me.dtmNgay_qd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmNgay_qd.Location = New System.Drawing.Point(593, 34)
        Me.dtmNgay_qd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtmNgay_qd.Name = "dtmNgay_qd"
        Me.dtmNgay_qd.ShowCheckBox = True
        Me.dtmNgay_qd.Size = New System.Drawing.Size(138, 26)
        Me.dtmNgay_qd.TabIndex = 125
        '
        'txtLy_do
        '
        Me.txtLy_do.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLy_do.Location = New System.Drawing.Point(123, 100)
        Me.txtLy_do.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLy_do.MaxLength = 500
        Me.txtLy_do.Multiline = True
        Me.txtLy_do.Name = "txtLy_do"
        Me.txtLy_do.Size = New System.Drawing.Size(607, 44)
        Me.txtLy_do.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(36, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 44)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Nội dung:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(498, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 26)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Ngày QĐ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_qd
        '
        Me.cmbLoai_qd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbLoai_qd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_qd.Location = New System.Drawing.Point(123, 67)
        Me.cmbLoai_qd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLoai_qd.Name = "cmbLoai_qd"
        Me.cmbLoai_qd.Size = New System.Drawing.Size(607, 27)
        Me.cmbLoai_qd.TabIndex = 129
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(36, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Loại QĐ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(193, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 19)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "(*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(273, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 19)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "(*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(732, 71)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 19)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "(*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(732, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "(*)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(730, 37)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 19)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "(*)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(732, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 19)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "(*)"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmbID_lop
        '
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Location = New System.Drawing.Point(522, 152)
        Me.cmbID_lop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(207, 27)
        Me.cmbID_lop.TabIndex = 138
        Me.cmbID_lop.Visible = False
        '
        'lblLop
        '
        Me.lblLop.BackColor = System.Drawing.Color.Transparent
        Me.lblLop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLop.Location = New System.Drawing.Point(399, 154)
        Me.lblLop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLop.Name = "lblLop"
        Me.lblLop.Size = New System.Drawing.Size(123, 22)
        Me.lblLop.TabIndex = 139
        Me.lblLop.Text = "Lớp học tiếp:"
        Me.lblLop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLop.Visible = False
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(123, 152)
        Me.cmbKhoa_hoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(216, 27)
        Me.cmbKhoa_hoc.TabIndex = 140
        Me.cmbKhoa_hoc.Visible = False
        '
        'lblKhoaHoc
        '
        Me.lblKhoaHoc.BackColor = System.Drawing.Color.Transparent
        Me.lblKhoaHoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKhoaHoc.Location = New System.Drawing.Point(0, 154)
        Me.lblKhoaHoc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKhoaHoc.Name = "lblKhoaHoc"
        Me.lblKhoaHoc.Size = New System.Drawing.Size(123, 22)
        Me.lblKhoaHoc.TabIndex = 141
        Me.lblKhoaHoc.Text = "Khoá học:"
        Me.lblKhoaHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblKhoaHoc.Visible = False
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Appearance.Options.UseFont = True
        Me.cmdRemove.ImageIndex = 4
        Me.cmdRemove.ImageList = Me.ImgMain
        Me.cmdRemove.Location = New System.Drawing.Point(546, 487)
        Me.cmdRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(100, 30)
        Me.cmdRemove.TabIndex = 202
        Me.cmdRemove.Text = "Loại SV"
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
        Me.ImgMain.Images.SetKeyName(22, "1665.ico")
        Me.ImgMain.Images.SetKeyName(23, "1669.ico")
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(654, 487)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 30)
        Me.cmdClose.TabIndex = 201
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(330, 487)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 30)
        Me.cmdSave.TabIndex = 200
        Me.cmdSave.Text = "Lưu"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(438, 487)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(100, 30)
        Me.cmdAdd.TabIndex = 203
        Me.cmdAdd.Text = "Thêm SV"
        '
        'grcDanhSachChon
        '
        Me.grcDanhSachChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachChon.Location = New System.Drawing.Point(3, 186)
        Me.grcDanhSachChon.MainView = Me.grvDanhSachChon
        Me.grcDanhSachChon.Name = "grcDanhSachChon"
        Me.grcDanhSachChon.Size = New System.Drawing.Size(750, 294)
        Me.grcDanhSachChon.TabIndex = 217
        Me.grcDanhSachChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachChon})
        '
        'grvDanhSachChon
        '
        Me.grvDanhSachChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMa_sv1, Me.colHo_ten1, Me.colNgay_sinh1, Me.colTen_lop})
        Me.grvDanhSachChon.GridControl = Me.grcDanhSachChon
        Me.grvDanhSachChon.Name = "grvDanhSachChon"
        Me.grvDanhSachChon.OptionsSelection.MultiSelect = True
        Me.grvDanhSachChon.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachChon.OptionsView.ShowGroupPanel = False
        '
        'colMa_sv1
        '
        Me.colMa_sv1.Caption = "Mã SV"
        Me.colMa_sv1.FieldName = "Ma_sv"
        Me.colMa_sv1.Name = "colMa_sv1"
        Me.colMa_sv1.OptionsColumn.ReadOnly = True
        Me.colMa_sv1.Visible = True
        Me.colMa_sv1.VisibleIndex = 0
        Me.colMa_sv1.Width = 80
        '
        'colHo_ten1
        '
        Me.colHo_ten1.Caption = "Họ tên"
        Me.colHo_ten1.FieldName = "Ho_ten"
        Me.colHo_ten1.Name = "colHo_ten1"
        Me.colHo_ten1.OptionsColumn.ReadOnly = True
        Me.colHo_ten1.Visible = True
        Me.colHo_ten1.VisibleIndex = 1
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
        Me.colNgay_sinh1.VisibleIndex = 2
        Me.colNgay_sinh1.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 3
        Me.colTen_lop.Width = 61
        '
        'frmESS_QuyetDinhThoiHoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 520)
        Me.Controls.Add(Me.grcDanhSachChon)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.lblKhoaHoc)
        Me.Controls.Add(Me.cmbID_lop)
        Me.Controls.Add(Me.lblLop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLoai_qd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLy_do)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtmNgay_qd)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSo_QD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_QuyetDinhThoiHoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUYET DINH THOI HOC"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_QD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtmNgay_qd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtLy_do As System.Windows.Forms.TextBox
    Friend WithEvents cmbLoai_qd As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
    Friend WithEvents lblLop As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblKhoaHoc As System.Windows.Forms.Label
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Public WithEvents grcDanhSachChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMa_sv1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
End Class
