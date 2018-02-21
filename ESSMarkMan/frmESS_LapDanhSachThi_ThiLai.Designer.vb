<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_LapDanhSachThi_ThiLai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_LapDanhSachThi_ThiLai))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbLoaiDSThi = New System.Windows.Forms.ComboBox
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DSThi = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DSThi2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdPrint_DSHP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DSSV = New DevExpress.XtraBars.BarButtonItem
        Me.cmdExport_HP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdExport_SV = New DevExpress.XtraBars.BarButtonItem
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDuyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ID_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ID_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ID_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(313, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(422, 3)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(109, 24)
        Me.cmbNam_hoc.TabIndex = 82
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(33, 3)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 79
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(99, 3)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 80
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(21, 33)
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
        Me.cmbID_mon.Location = New System.Drawing.Point(99, 33)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(432, 24)
        Me.cmbID_mon.TabIndex = 78
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ma_sv"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ten_lop"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ghi_chu"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ghi chú"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(680, 37)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(100, 20)
        Me.chkAll.TabIndex = 87
        Me.chkAll.Text = "Chọn tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(555, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Theo danh sách:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoaiDSThi
        '
        Me.cmbLoaiDSThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoaiDSThi.AutoCompleteCustomSource.AddRange(New String() {"Đăng ký thi lại", "Đăng ký thi cải thiện"})
        Me.cmbLoaiDSThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiDSThi.Items.AddRange(New Object() {"Thi cải thiện", "Thi lại"})
        Me.cmbLoaiDSThi.Location = New System.Drawing.Point(681, 2)
        Me.cmbLoaiDSThi.Name = "cmbLoaiDSThi"
        Me.cmbLoaiDSThi.Size = New System.Drawing.Size(101, 24)
        Me.cmbLoaiDSThi.TabIndex = 89
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(585, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(97, 30)
        Me.cmdExport.TabIndex = 193
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
        Me.cmdClose.Location = New System.Drawing.Point(690, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(97, 30)
        Me.cmdClose.TabIndex = 192
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(340, 533)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(97, 30)
        Me.cmdSave.TabIndex = 191
        Me.cmdSave.Text = "Duyệt"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(444, 533)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(135, 30)
        Me.cmdPrintList.TabIndex = 260
        Me.cmdPrintList.Text = "In danh sách"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSThi), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSThi2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DSThi
        '
        Me.cmdPrint_DSThi.Caption = "In danh sách thi (Viết)"
        Me.cmdPrint_DSThi.Id = 13
        Me.cmdPrint_DSThi.ImageIndex = 16
        Me.cmdPrint_DSThi.Name = "cmdPrint_DSThi"
        '
        'cmdPrint_DSThi2
        '
        Me.cmdPrint_DSThi2.Caption = "Danh sách thi (Vấn đáp)"
        Me.cmdPrint_DSThi2.Id = 14
        Me.cmdPrint_DSThi2.ImageIndex = 16
        Me.cmdPrint_DSThi2.Name = "cmdPrint_DSThi2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_DSHP, Me.cmdPrint_DSSV, Me.cmdExport_HP, Me.cmdExport_SV, Me.cmdPrint_DSThi, Me.cmdPrint_DSThi2})
        Me.BarManager1.MaxItemId = 15
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(792, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(792, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 566)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(792, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'cmdPrint_DSHP
        '
        Me.cmdPrint_DSHP.Caption = "Danh sách học phần"
        Me.cmdPrint_DSHP.Id = 0
        Me.cmdPrint_DSHP.ImageIndex = 16
        Me.cmdPrint_DSHP.Name = "cmdPrint_DSHP"
        '
        'cmdPrint_DSSV
        '
        Me.cmdPrint_DSSV.Caption = "Danh sách sinh viên"
        Me.cmdPrint_DSSV.Id = 1
        Me.cmdPrint_DSSV.ImageIndex = 16
        Me.cmdPrint_DSSV.Name = "cmdPrint_DSSV"
        '
        'cmdExport_HP
        '
        Me.cmdExport_HP.Caption = "Xuất DS Học phần"
        Me.cmdExport_HP.Id = 11
        Me.cmdExport_HP.ImageIndex = 6
        Me.cmdExport_HP.Name = "cmdExport_HP"
        '
        'cmdExport_SV
        '
        Me.cmdExport_SV.Caption = "Xuất DS Sinh viên"
        Me.cmdExport_SV.Id = 12
        Me.cmdExport_SV.ImageIndex = 6
        Me.cmdExport_SV.Name = "cmdExport_SV"
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(2, 60)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(785, 467)
        Me.grcDanhSachThi.TabIndex = 265
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDuyet, Me.ID_sv, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.ID_lop, Me.colTen_lop, Me.ID_khoa, Me.colTen_khoa, Me.colGhi_chu})
        Me.grvDanhSachThi.GridControl = Me.grcDanhSachThi
        Me.grvDanhSachThi.Name = "grvDanhSachThi"
        Me.grvDanhSachThi.OptionsSelection.MultiSelect = True
        Me.grvDanhSachThi.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachThi.OptionsView.ShowGroupPanel = False
        '
        'colDuyet
        '
        Me.colDuyet.Caption = "Duyệt"
        Me.colDuyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDuyet.FieldName = "Chon"
        Me.colDuyet.Name = "colDuyet"
        Me.colDuyet.Visible = True
        Me.colDuyet.VisibleIndex = 0
        Me.colDuyet.Width = 47
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
        'colGhi_chu
        '
        Me.colGhi_chu.Caption = "Ghi chú"
        Me.colGhi_chu.FieldName = "Ghi_chu"
        Me.colGhi_chu.Name = "colGhi_chu"
        Me.colGhi_chu.Visible = True
        Me.colGhi_chu.VisibleIndex = 6
        '
        'frmESS_LapDanhSachThi_ThiLai
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLoaiDSThi)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_LapDanhSachThi_ThiLai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duyệt danh sách thi cải thiện"
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLoaiDSThi As System.Windows.Forms.ComboBox
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_DSHP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSThi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSThi2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdExport_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdExport_SV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDuyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu As DevExpress.XtraGrid.Columns.GridColumn
End Class
