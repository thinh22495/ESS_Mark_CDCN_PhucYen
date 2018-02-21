<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_LapDanhSachThi_CaiThienDiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_LapDanhSachThi_CaiThienDiem))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.chkAll1 = New System.Windows.Forms.CheckBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmbLoaiDSThi = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ID_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ID_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ID_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDanhSachThiChon = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThiChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdThem = New DevExpress.XtraEditors.SimpleButton
        Me.cmdXoa = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(391, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(458, 0)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(89, 24)
        Me.cmbNam_hoc.TabIndex = 82
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(267, 0)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 79
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(327, 0)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 80
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(380, 30)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 77
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(458, 30)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(323, 24)
        Me.cmbID_mon.TabIndex = 78
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(270, 32)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(100, 20)
        Me.chkAll.TabIndex = 86
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'chkAll1
        '
        Me.chkAll1.AutoSize = True
        Me.chkAll1.BackColor = System.Drawing.Color.Transparent
        Me.chkAll1.Location = New System.Drawing.Point(267, 297)
        Me.chkAll1.Name = "chkAll1"
        Me.chkAll1.Size = New System.Drawing.Size(100, 20)
        Me.chkAll1.TabIndex = 86
        Me.chkAll1.Text = "Chọn tất cả"
        Me.chkAll1.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_lop"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_lop"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ma_sv"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ten_lop"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID_khoa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID_khoa"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ten_khoa"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Khoa"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ghi_chu"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ghi chú"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ID_sv"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID_sv"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Ma_sv"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 250
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn12.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ID_lop"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ID_lop"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Ten_lop"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ID_khoa"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID_khoa"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Ten_khoa"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Khoa"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(583, 534)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(97, 30)
        Me.cmdExport.TabIndex = 190
        Me.cmdExport.Text = "Xuất Excel"
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
        Me.cmdClose.Location = New System.Drawing.Point(688, 534)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(97, 30)
        Me.cmdClose.TabIndex = 189
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(478, 534)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(97, 30)
        Me.cmdSave.TabIndex = 188
        Me.cmdSave.Text = "Duyệt"
        '
        'cmbLoaiDSThi
        '
        Me.cmbLoaiDSThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoaiDSThi.AutoCompleteCustomSource.AddRange(New String() {"Đăng ký thi lại", "Đăng ký thi cải thiện"})
        Me.cmbLoaiDSThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiDSThi.Items.AddRange(New Object() {"Thi cải thiện", "Thi lại"})
        Me.cmbLoaiDSThi.Location = New System.Drawing.Point(679, 1)
        Me.cmbLoaiDSThi.Name = "cmbLoaiDSThi"
        Me.cmbLoaiDSThi.Size = New System.Drawing.Size(101, 24)
        Me.cmbLoaiDSThi.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(553, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Theo danh sách:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(1, 0)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(245, 565)
        Me.TreeViewLop.TabIndex = 66
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(248, 58)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(540, 232)
        Me.grcDanhSachThi.TabIndex = 191
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.ID_sv, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.ID_lop, Me.colTen_lop, Me.ID_khoa, Me.colTen_khoa})
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
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 47
        '
        'ID_sv
        '
        Me.ID_sv.Caption = "ID_sv"
        Me.ID_sv.FieldName = "ID_sv"
        Me.ID_sv.Name = "ID_sv"
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
        'ID_lop
        '
        Me.ID_lop.Caption = "ID_lop"
        Me.ID_lop.FieldName = "ID_lop"
        Me.ID_lop.Name = "ID_lop"
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
        'ID_khoa
        '
        Me.ID_khoa.Caption = "ID_khoa"
        Me.ID_khoa.FieldName = "ID_khoa"
        Me.ID_khoa.Name = "ID_khoa"
        Me.ID_khoa.Width = 80
        '
        'colTen_khoa
        '
        Me.colTen_khoa.Caption = "Tên khóa"
        Me.colTen_khoa.FieldName = "Ten_khoa"
        Me.colTen_khoa.Name = "colTen_khoa"
        Me.colTen_khoa.OptionsColumn.ReadOnly = True
        Me.colTen_khoa.Visible = True
        Me.colTen_khoa.VisibleIndex = 5
        Me.colTen_khoa.Width = 85
        '
        'grcDanhSachThiChon
        '
        Me.grcDanhSachThiChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThiChon.Location = New System.Drawing.Point(248, 327)
        Me.grcDanhSachThiChon.MainView = Me.grvDanhSachThiChon
        Me.grcDanhSachThiChon.Name = "grcDanhSachThiChon"
        Me.grcDanhSachThiChon.Size = New System.Drawing.Size(540, 202)
        Me.grcDanhSachThiChon.TabIndex = 191
        Me.grcDanhSachThiChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThiChon})
        '
        'grvDanhSachThiChon
        '
        Me.grvDanhSachThiChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.grvDanhSachThiChon.GridControl = Me.grcDanhSachThiChon
        Me.grvDanhSachThiChon.Name = "grvDanhSachThiChon"
        Me.grvDanhSachThiChon.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThiChon.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThiChon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Chọn"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Chon"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 47
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ID_sv"
        Me.GridColumn2.FieldName = "ID_sv"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Mã SV"
        Me.GridColumn3.FieldName = "Ma_sv"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 80
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Họ tên"
        Me.GridColumn4.FieldName = "Ho_ten"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ngày sinh"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "Ngay_sinh"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 100
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ID_lop"
        Me.GridColumn6.FieldName = "ID_lop"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tên lớp"
        Me.GridColumn7.FieldName = "Ten_lop"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        Me.GridColumn7.Width = 61
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID_khoa"
        Me.GridColumn8.FieldName = "ID_khoa"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 80
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tên khóa"
        Me.GridColumn9.FieldName = "Ten_khoa"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 85
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Duyệt"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Duyet"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 44
        '
        'cmdThem
        '
        Me.cmdThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThem.Appearance.Options.UseFont = True
        Me.cmdThem.ImageIndex = 0
        Me.cmdThem.ImageList = Me.ImgMain
        Me.cmdThem.Location = New System.Drawing.Point(647, 292)
        Me.cmdThem.Name = "cmdThem"
        Me.cmdThem.Size = New System.Drawing.Size(65, 30)
        Me.cmdThem.TabIndex = 188
        Me.cmdThem.Text = "Thêm"
        '
        'cmdXoa
        '
        Me.cmdXoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdXoa.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXoa.Appearance.Options.UseFont = True
        Me.cmdXoa.ImageIndex = 4
        Me.cmdXoa.ImageList = Me.ImgMain
        Me.cmdXoa.Location = New System.Drawing.Point(720, 292)
        Me.cmdXoa.Name = "cmdXoa"
        Me.cmdXoa.Size = New System.Drawing.Size(65, 30)
        Me.cmdXoa.TabIndex = 188
        Me.cmdXoa.Text = "Xóa"
        '
        'frmESS_LapDanhSachThi_CaiThienDiem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grcDanhSachThiChon)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdXoa)
        Me.Controls.Add(Me.cmdThem)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.chkAll1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.cmbLoaiDSThi)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_LapDanhSachThi_CaiThienDiem"
        Me.Text = "LẬP DANH SÁCH ĐĂNG KÝ THI LẠI HOẶC THI CẢI THIỆN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbLoaiDSThi As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDanhSachThiChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThiChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdXoa As DevExpress.XtraEditors.SimpleButton
End Class
