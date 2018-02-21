<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetLuanVan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_XetLuanVan))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabLuanVan = New System.Windows.Forms.TabPage
        Me.grcLuanVan = New DevExpress.XtraGrid.GridControl
        Me.grvLanVan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_tin_chi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinhVien_duyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCoVan_duyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSo_tin_chi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.labSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTBCHT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.TabThiTotNghiep = New System.Windows.Forms.TabPage
        Me.grcThiTotNghiep = New DevExpress.XtraGrid.GridControl
        Me.grvThiTotNghiep = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinhVien_duyet_tn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCoVan_duyet_TN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblSV_Thi = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TreeViewLop1 = New ESSMarkMan.TreeViewLop
        Me.TabNoThiTotNghiep = New System.Windows.Forms.TabPage
        Me.grcNoTotNghiep = New DevExpress.XtraGrid.GridControl
        Me.grvNoTotNghiep = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblNoThi = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TreeViewLop2 = New ESSMarkMan.TreeViewLop
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DS_luanvan = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DS_totnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DS_nototnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdChuyenThi = New DevExpress.XtraEditors.SimpleButton
        Me.cmdXetLV = New DevExpress.XtraEditors.SimpleButton
        Me.cmdChuyenLamLV = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDuyet = New DevExpress.XtraEditors.SimpleButton
        Me.cmdXet_BoSung = New DevExpress.XtraEditors.SimpleButton
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabControl1.SuspendLayout()
        Me.TabLuanVan.SuspendLayout()
        CType(Me.grcLuanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLanVan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabThiTotNghiep.SuspendLayout()
        CType(Me.grcThiTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvThiTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNoThiTotNghiep.SuspendLayout()
        CType(Me.grcNoTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvNoTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabLuanVan)
        Me.TabControl1.Controls.Add(Me.TabThiTotNghiep)
        Me.TabControl1.Controls.Add(Me.TabNoThiTotNghiep)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 478)
        Me.TabControl1.TabIndex = 102
        '
        'TabLuanVan
        '
        Me.TabLuanVan.Controls.Add(Me.grcLuanVan)
        Me.TabLuanVan.Controls.Add(Me.txtSo_tin_chi)
        Me.TabLuanVan.Controls.Add(Me.Label2)
        Me.TabLuanVan.Controls.Add(Me.labSo_sv)
        Me.TabLuanVan.Controls.Add(Me.Label4)
        Me.TabLuanVan.Controls.Add(Me.txtTBCHT)
        Me.TabLuanVan.Controls.Add(Me.Label1)
        Me.TabLuanVan.Controls.Add(Me.TreeViewLop)
        Me.TabLuanVan.Location = New System.Drawing.Point(4, 25)
        Me.TabLuanVan.Name = "TabLuanVan"
        Me.TabLuanVan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLuanVan.Size = New System.Drawing.Size(784, 449)
        Me.TabLuanVan.TabIndex = 0
        Me.TabLuanVan.Text = "Làm khóa luận"
        Me.TabLuanVan.UseVisualStyleBackColor = True
        '
        'grcLuanVan
        '
        Me.grcLuanVan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcLuanVan.Location = New System.Drawing.Point(258, 32)
        Me.grcLuanVan.MainView = Me.grvLanVan
        Me.grcLuanVan.Name = "grcLuanVan"
        Me.grcLuanVan.Size = New System.Drawing.Size(525, 408)
        Me.grcLuanVan.TabIndex = 110
        Me.grcLuanVan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLanVan})
        '
        'grvLanVan
        '
        Me.grvLanVan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clChon, Me.GridColumn13, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colSo_tin_chi, Me.colTBCHT, Me.colSinhVien_duyet, Me.colCoVan_duyet})
        Me.grvLanVan.GridControl = Me.grcLuanVan
        Me.grvLanVan.Name = "grvLanVan"
        Me.grvLanVan.OptionsSelection.MultiSelect = True
        Me.grvLanVan.OptionsView.ShowAutoFilterRow = True
        Me.grvLanVan.OptionsView.ShowGroupPanel = False
        '
        'clChon
        '
        Me.clChon.Caption = "Chọn"
        Me.clChon.FieldName = "Chon1"
        Me.clChon.Name = "clChon"
        Me.clChon.Visible = True
        Me.clChon.VisibleIndex = 0
        Me.clChon.Width = 39
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.AllowEdit = False
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 163
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.AllowEdit = False
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 3
        Me.colNgay_sinh.Width = 85
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.AllowEdit = False
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 4
        Me.colTen_lop.Width = 76
        '
        'colSo_tin_chi
        '
        Me.colSo_tin_chi.Caption = "Số tín chỉ"
        Me.colSo_tin_chi.FieldName = "So_tin_chi"
        Me.colSo_tin_chi.Name = "colSo_tin_chi"
        Me.colSo_tin_chi.OptionsColumn.AllowEdit = False
        Me.colSo_tin_chi.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colSo_tin_chi.Visible = True
        Me.colSo_tin_chi.VisibleIndex = 5
        Me.colSo_tin_chi.Width = 58
        '
        'colTBCHT
        '
        Me.colTBCHT.Caption = "TBC tích lũy"
        Me.colTBCHT.FieldName = "TBCHT"
        Me.colTBCHT.Name = "colTBCHT"
        Me.colTBCHT.OptionsColumn.AllowEdit = False
        Me.colTBCHT.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colTBCHT.Visible = True
        Me.colTBCHT.VisibleIndex = 6
        Me.colTBCHT.Width = 83
        '
        'colSinhVien_duyet
        '
        Me.colSinhVien_duyet.Caption = "SV đăng ký"
        Me.colSinhVien_duyet.FieldName = "SinhVien_duyet"
        Me.colSinhVien_duyet.Name = "colSinhVien_duyet"
        Me.colSinhVien_duyet.Visible = True
        Me.colSinhVien_duyet.VisibleIndex = 7
        '
        'colCoVan_duyet
        '
        Me.colCoVan_duyet.Caption = "Cố vấn HT duyệt"
        Me.colCoVan_duyet.FieldName = "CoVan_duyet"
        Me.colCoVan_duyet.Name = "colCoVan_duyet"
        Me.colCoVan_duyet.Visible = True
        Me.colCoVan_duyet.VisibleIndex = 8
        '
        'txtSo_tin_chi
        '
        Me.txtSo_tin_chi.Location = New System.Drawing.Point(488, 6)
        Me.txtSo_tin_chi.Name = "txtSo_tin_chi"
        Me.txtSo_tin_chi.Size = New System.Drawing.Size(54, 23)
        Me.txtSo_tin_chi.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 23)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Số tín chỉ tích luỹ>=:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labSo_sv
        '
        Me.labSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(736, 0)
        Me.labSo_sv.Name = "labSo_sv"
        Me.labSo_sv.Size = New System.Drawing.Size(40, 23)
        Me.labSo_sv.TabIndex = 107
        Me.labSo_sv.Text = "0"
        Me.labSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(594, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Tống số sinh viên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTBCHT
        '
        Me.txtTBCHT.Location = New System.Drawing.Point(213, 6)
        Me.txtTBCHT.Name = "txtTBCHT"
        Me.txtTBCHT.Size = New System.Drawing.Size(54, 23)
        Me.txtTBCHT.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 23)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Điều kiện TBCHT tích luỹ>=:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(3, 23)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(258, 417)
        Me.TreeViewLop.TabIndex = 102
        '
        'TabThiTotNghiep
        '
        Me.TabThiTotNghiep.Controls.Add(Me.grcThiTotNghiep)
        Me.TabThiTotNghiep.Controls.Add(Me.lblSV_Thi)
        Me.TabThiTotNghiep.Controls.Add(Me.Label3)
        Me.TabThiTotNghiep.Controls.Add(Me.TreeViewLop1)
        Me.TabThiTotNghiep.Location = New System.Drawing.Point(4, 22)
        Me.TabThiTotNghiep.Name = "TabThiTotNghiep"
        Me.TabThiTotNghiep.Padding = New System.Windows.Forms.Padding(3)
        Me.TabThiTotNghiep.Size = New System.Drawing.Size(784, 452)
        Me.TabThiTotNghiep.TabIndex = 1
        Me.TabThiTotNghiep.Text = "Làm thay thế khóa luận"
        Me.TabThiTotNghiep.UseVisualStyleBackColor = True
        '
        'grcThiTotNghiep
        '
        Me.grcThiTotNghiep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcThiTotNghiep.Location = New System.Drawing.Point(261, 18)
        Me.grcThiTotNghiep.MainView = Me.grvThiTotNghiep
        Me.grcThiTotNghiep.Name = "grcThiTotNghiep"
        Me.grcThiTotNghiep.Size = New System.Drawing.Size(525, 416)
        Me.grcThiTotNghiep.TabIndex = 111
        Me.grcThiTotNghiep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvThiTotNghiep})
        '
        'grvThiTotNghiep
        '
        Me.grvThiTotNghiep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn12, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.colSinhVien_duyet_tn, Me.colCoVan_duyet_TN})
        Me.grvThiTotNghiep.GridControl = Me.grcThiTotNghiep
        Me.grvThiTotNghiep.Name = "grvThiTotNghiep"
        Me.grvThiTotNghiep.OptionsSelection.MultiSelect = True
        Me.grvThiTotNghiep.OptionsView.ShowAutoFilterRow = True
        Me.grvThiTotNghiep.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Chọn"
        Me.GridColumn1.FieldName = "Chon2"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 37
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Mã sinh viên"
        Me.GridColumn12.FieldName = "Ma_sv2"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Họ tên"
        Me.GridColumn2.FieldName = "Ho_ten2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 157
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ngày sinh"
        Me.GridColumn3.FieldName = "Ngay_sinh2"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 82
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên lớp"
        Me.GridColumn4.FieldName = "Ten_lop2"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 73
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "TBC tích lũy"
        Me.GridColumn6.FieldName = "TBCHT2"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 80
        '
        'colSinhVien_duyet_tn
        '
        Me.colSinhVien_duyet_tn.Caption = "SV đăng ký"
        Me.colSinhVien_duyet_tn.FieldName = "SinhVien_duyet"
        Me.colSinhVien_duyet_tn.Name = "colSinhVien_duyet_tn"
        '
        'colCoVan_duyet_TN
        '
        Me.colCoVan_duyet_TN.Caption = "Cố vấn HT duyệt"
        Me.colCoVan_duyet_TN.FieldName = "CoVan_duyet"
        Me.colCoVan_duyet_TN.Name = "colCoVan_duyet_TN"
        Me.colCoVan_duyet_TN.Width = 20
        '
        'lblSV_Thi
        '
        Me.lblSV_Thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSV_Thi.BackColor = System.Drawing.Color.Transparent
        Me.lblSV_Thi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSV_Thi.Location = New System.Drawing.Point(736, 2)
        Me.lblSV_Thi.Name = "lblSV_Thi"
        Me.lblSV_Thi.Size = New System.Drawing.Size(40, 23)
        Me.lblSV_Thi.TabIndex = 109
        Me.lblSV_Thi.Text = "0"
        Me.lblSV_Thi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(594, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Tống số sinh viên:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TreeViewLop1
        '
        Me.TreeViewLop1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop1.dtLop = Nothing
        Me.TreeViewLop1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop1.Location = New System.Drawing.Point(3, 2)
        Me.TreeViewLop1.Name = "TreeViewLop1"
        Me.TreeViewLop1.Size = New System.Drawing.Size(258, 432)
        Me.TreeViewLop1.TabIndex = 104
        '
        'TabNoThiTotNghiep
        '
        Me.TabNoThiTotNghiep.Controls.Add(Me.grcNoTotNghiep)
        Me.TabNoThiTotNghiep.Controls.Add(Me.lblNoThi)
        Me.TabNoThiTotNghiep.Controls.Add(Me.Label6)
        Me.TabNoThiTotNghiep.Controls.Add(Me.TreeViewLop2)
        Me.TabNoThiTotNghiep.Location = New System.Drawing.Point(4, 22)
        Me.TabNoThiTotNghiep.Name = "TabNoThiTotNghiep"
        Me.TabNoThiTotNghiep.Size = New System.Drawing.Size(784, 452)
        Me.TabNoThiTotNghiep.TabIndex = 2
        Me.TabNoThiTotNghiep.Text = "Không đủ điều kiện làm tốt nghiệp"
        Me.TabNoThiTotNghiep.UseVisualStyleBackColor = True
        '
        'grcNoTotNghiep
        '
        Me.grcNoTotNghiep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcNoTotNghiep.Location = New System.Drawing.Point(259, 18)
        Me.grcNoTotNghiep.MainView = Me.grvNoTotNghiep
        Me.grcNoTotNghiep.Name = "grcNoTotNghiep"
        Me.grcNoTotNghiep.Size = New System.Drawing.Size(525, 424)
        Me.grcNoTotNghiep.TabIndex = 114
        Me.grcNoTotNghiep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvNoTotNghiep})
        '
        'grvNoTotNghiep
        '
        Me.grvNoTotNghiep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.grvNoTotNghiep.GridControl = Me.grcNoTotNghiep
        Me.grvNoTotNghiep.Name = "grvNoTotNghiep"
        Me.grvNoTotNghiep.OptionsSelection.MultiSelect = True
        Me.grvNoTotNghiep.OptionsView.ShowAutoFilterRow = True
        Me.grvNoTotNghiep.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Mã sinh viên"
        Me.GridColumn5.FieldName = "Ma_sv3"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 70
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Họ tên"
        Me.GridColumn7.FieldName = "Ho_ten3"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 140
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Ngày sinh"
        Me.GridColumn8.FieldName = "Ngay_sinh3"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 78
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tên lớp"
        Me.GridColumn9.FieldName = "Ten_lop3"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.GridColumn9.Width = 58
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "TBC tích lũy"
        Me.GridColumn10.FieldName = "TBCHT3"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 69
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Lý do "
        Me.GridColumn11.FieldName = "Ly_do"
        Me.GridColumn11.MaxWidth = 1000
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        Me.GridColumn11.Width = 89
        '
        'lblNoThi
        '
        Me.lblNoThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoThi.BackColor = System.Drawing.Color.Transparent
        Me.lblNoThi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoThi.Location = New System.Drawing.Point(736, 2)
        Me.lblNoThi.Name = "lblNoThi"
        Me.lblNoThi.Size = New System.Drawing.Size(40, 23)
        Me.lblNoThi.TabIndex = 113
        Me.lblNoThi.Text = "0"
        Me.lblNoThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(594, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Tống số sinh viên:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TreeViewLop2
        '
        Me.TreeViewLop2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop2.dtLop = Nothing
        Me.TreeViewLop2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop2.Location = New System.Drawing.Point(3, 2)
        Me.TreeViewLop2.Name = "TreeViewLop2"
        Me.TreeViewLop2.Size = New System.Drawing.Size(258, 451)
        Me.TreeViewLop2.TabIndex = 110
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_luanvan), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_totnghiep), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_nototnghiep), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_luanvan), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_totnghiep)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DS_luanvan
        '
        Me.cmdPrint_DS_luanvan.Caption = "Làm luận văn"
        Me.cmdPrint_DS_luanvan.Id = 0
        Me.cmdPrint_DS_luanvan.ImageIndex = 16
        Me.cmdPrint_DS_luanvan.Name = "cmdPrint_DS_luanvan"
        '
        'cmdPrint_DS_totnghiep
        '
        Me.cmdPrint_DS_totnghiep.Caption = "Thi tốt nghiệp"
        Me.cmdPrint_DS_totnghiep.Id = 1
        Me.cmdPrint_DS_totnghiep.ImageIndex = 16
        Me.cmdPrint_DS_totnghiep.Name = "cmdPrint_DS_totnghiep"
        '
        'cmdPrint_DS_nototnghiep
        '
        Me.cmdPrint_DS_nototnghiep.Caption = "Nợ thi tốt nghiệp"
        Me.cmdPrint_DS_nototnghiep.Id = 2
        Me.cmdPrint_DS_nototnghiep.ImageIndex = 16
        Me.cmdPrint_DS_nototnghiep.Name = "cmdPrint_DS_nototnghiep"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_DS_luanvan, Me.cmdPrint_DS_totnghiep, Me.cmdPrint_DS_nototnghiep})
        Me.BarManager1.MaxItemId = 3
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 513)
        Me.barDockControlBottom.Size = New System.Drawing.Size(792, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 513)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(792, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 513)
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(673, 480)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 165
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(549, 480)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(115, 30)
        Me.cmdExport.TabIndex = 164
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(404, 480)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(135, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdChuyenThi
        '
        Me.cmdChuyenThi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChuyenThi.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChuyenThi.Appearance.Options.UseFont = True
        Me.cmdChuyenThi.ImageIndex = 3
        Me.cmdChuyenThi.ImageList = Me.ImgMain
        Me.cmdChuyenThi.Location = New System.Drawing.Point(283, 480)
        Me.cmdChuyenThi.Name = "cmdChuyenThi"
        Me.cmdChuyenThi.Size = New System.Drawing.Size(115, 30)
        Me.cmdChuyenThi.TabIndex = 164
        Me.cmdChuyenThi.Text = "Chuyển thi TN"
        '
        'cmdXetLV
        '
        Me.cmdXetLV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdXetLV.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXetLV.Appearance.Options.UseFont = True
        Me.cmdXetLV.ImageIndex = 15
        Me.cmdXetLV.ImageList = Me.ImgMain
        Me.cmdXetLV.Location = New System.Drawing.Point(162, 480)
        Me.cmdXetLV.Name = "cmdXetLV"
        Me.cmdXetLV.Size = New System.Drawing.Size(115, 30)
        Me.cmdXetLV.TabIndex = 164
        Me.cmdXetLV.Text = "Xét luận văn"
        '
        'cmdChuyenLamLV
        '
        Me.cmdChuyenLamLV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChuyenLamLV.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChuyenLamLV.Appearance.Options.UseFont = True
        Me.cmdChuyenLamLV.ImageIndex = 3
        Me.cmdChuyenLamLV.ImageList = Me.ImgMain
        Me.cmdChuyenLamLV.Location = New System.Drawing.Point(283, 480)
        Me.cmdChuyenLamLV.Name = "cmdChuyenLamLV"
        Me.cmdChuyenLamLV.Size = New System.Drawing.Size(115, 30)
        Me.cmdChuyenLamLV.TabIndex = 164
        Me.cmdChuyenLamLV.Text = "Chuyển làm LV"
        '
        'cmdDuyet
        '
        Me.cmdDuyet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDuyet.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDuyet.Appearance.Options.UseFont = True
        Me.cmdDuyet.ImageIndex = 17
        Me.cmdDuyet.ImageList = Me.ImgMain
        Me.cmdDuyet.Location = New System.Drawing.Point(23, 480)
        Me.cmdDuyet.Name = "cmdDuyet"
        Me.cmdDuyet.Size = New System.Drawing.Size(133, 30)
        Me.cmdDuyet.TabIndex = 170
        Me.cmdDuyet.Text = "Duyệt làm khóa luận"
        '
        'cmdXet_BoSung
        '
        Me.cmdXet_BoSung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdXet_BoSung.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXet_BoSung.Appearance.Options.UseFont = True
        Me.cmdXet_BoSung.ImageIndex = 15
        Me.cmdXet_BoSung.ImageList = Me.ImgMain
        Me.cmdXet_BoSung.Location = New System.Drawing.Point(162, 480)
        Me.cmdXet_BoSung.Name = "cmdXet_BoSung"
        Me.cmdXet_BoSung.Size = New System.Drawing.Size(115, 30)
        Me.cmdXet_BoSung.TabIndex = 175
        Me.cmdXet_BoSung.Text = "Xét bổ sung TN"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Mã sv"
        Me.GridColumn13.FieldName = "Ma_sv"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        '
        'frmESS_XetLuanVan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 513)
        Me.Controls.Add(Me.cmdDuyet)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdChuyenThi)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdChuyenLamLV)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdXetLV)
        Me.Controls.Add(Me.cmdXet_BoSung)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_XetLuanVan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XET LUAN VAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabLuanVan.ResumeLayout(False)
        Me.TabLuanVan.PerformLayout()
        CType(Me.grcLuanVan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLanVan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabThiTotNghiep.ResumeLayout(False)
        CType(Me.grcThiTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvThiTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNoThiTotNghiep.ResumeLayout(False)
        CType(Me.grcNoTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvNoTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabLuanVan As System.Windows.Forms.TabPage
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents TabThiTotNghiep As System.Windows.Forms.TabPage
    Friend WithEvents TabNoThiTotNghiep As System.Windows.Forms.TabPage
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTBCHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSV_Thi As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TreeViewLop1 As ESSMarkMan.TreeViewLop
    Friend WithEvents lblNoThi As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TreeViewLop2 As ESSMarkMan.TreeViewLop
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdXetLV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdChuyenThi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_DS_luanvan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DS_totnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdPrint_DS_nototnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdChuyenLamLV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSo_tin_chi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grcLuanVan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLanVan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_tin_chi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcThiTotNghiep As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvThiTotNghiep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcNoTotNghiep As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvNoTotNghiep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinhVien_duyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoVan_duyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdDuyet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSinhVien_duyet_tn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoVan_duyet_TN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdXet_BoSung As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
End Class
