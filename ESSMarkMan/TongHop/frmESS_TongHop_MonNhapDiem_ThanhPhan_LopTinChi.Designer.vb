<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi
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
        Me.grcChuaCoDiem = New DevExpress.XtraGrid.GridControl
        Me.grvChuaCoDiem = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Ten_lop1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueKhoiKienThuc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.SpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.grcChuaDuDiem = New DevExpress.XtraGrid.GridControl
        Me.grvChuaDuDiem = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Ten_lop2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.So_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Phan_tram = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.grcDuDiemDaKhoa = New DevExpress.XtraGrid.GridControl
        Me.grvDuDiemDaKhoa = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Ten_lop4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDuDiemChuaKhoa = New DevExpress.XtraGrid.GridControl
        Me.grvDuDiemChuaKhoa = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Ten_lop3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Phan_tram2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdKhoa_Diem = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbKy_dang_ky = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.grcChuaCoDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvChuaCoDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKhoiKienThuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcChuaDuDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvChuaDuDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDuDiemDaKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDuDiemDaKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDuDiemChuaKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDuDiemChuaKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcChuaCoDiem
        '
        Me.grcChuaCoDiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grcChuaCoDiem.Location = New System.Drawing.Point(1, 83)
        Me.grcChuaCoDiem.MainView = Me.grvChuaCoDiem
        Me.grcChuaCoDiem.Name = "grcChuaCoDiem"
        Me.grcChuaCoDiem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueKhoiKienThuc, Me.SpinEdit1, Me.SpinEdit2})
        Me.grcChuaCoDiem.Size = New System.Drawing.Size(450, 265)
        Me.grcChuaCoDiem.TabIndex = 92
        Me.grcChuaCoDiem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvChuaCoDiem})
        '
        'grvChuaCoDiem
        '
        Me.grvChuaCoDiem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ten_lop1, Me.colKy_hieu, Me.colTen_mon, Me.colSo_hoc_trinh})
        Me.grvChuaCoDiem.GridControl = Me.grcChuaCoDiem
        Me.grvChuaCoDiem.GroupPanelText = "Hãy chọn và kéo cột bạn muốn nhóm vào đây"
        Me.grvChuaCoDiem.Name = "grvChuaCoDiem"
        Me.grvChuaCoDiem.OptionsMenu.EnableColumnMenu = False
        Me.grvChuaCoDiem.OptionsMenu.EnableFooterMenu = False
        Me.grvChuaCoDiem.OptionsMenu.EnableGroupPanelMenu = False
        Me.grvChuaCoDiem.OptionsView.ShowAutoFilterRow = True
        Me.grvChuaCoDiem.OptionsView.ShowGroupPanel = False
        '
        'Ten_lop1
        '
        Me.Ten_lop1.Caption = "Nhóm lớp"
        Me.Ten_lop1.FieldName = "STT_lop"
        Me.Ten_lop1.Name = "Ten_lop1"
        Me.Ten_lop1.OptionsColumn.AllowEdit = False
        Me.Ten_lop1.Visible = True
        Me.Ten_lop1.VisibleIndex = 0
        Me.Ten_lop1.Width = 54
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Ký hiệu lớp"
        Me.colKy_hieu.FieldName = "Ky_hieu_lop_tc"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.AllowEdit = False
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 1
        Me.colKy_hieu.Width = 96
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.AllowEdit = False
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 2
        Me.colTen_mon.Width = 206
        '
        'colSo_hoc_trinh
        '
        Me.colSo_hoc_trinh.Caption = "SốTC "
        Me.colSo_hoc_trinh.FieldName = "So_hoc_trinh"
        Me.colSo_hoc_trinh.Name = "colSo_hoc_trinh"
        Me.colSo_hoc_trinh.OptionsColumn.AllowEdit = False
        Me.colSo_hoc_trinh.Visible = True
        Me.colSo_hoc_trinh.VisibleIndex = 3
        Me.colSo_hoc_trinh.Width = 49
        '
        'lueKhoiKienThuc
        '
        Me.lueKhoiKienThuc.AutoHeight = False
        Me.lueKhoiKienThuc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKhoiKienThuc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kien_thuc", 100, "Kiến thức")})
        Me.lueKhoiKienThuc.DisplayMember = "Ten_kien_thuc"
        Me.lueKhoiKienThuc.DropDownRows = 5
        Me.lueKhoiKienThuc.Name = "lueKhoiKienThuc"
        Me.lueKhoiKienThuc.ValueMember = "ID_kien_thuc"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.AutoHeight = False
        Me.SpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Name = "SpinEdit1"
        '
        'SpinEdit2
        '
        Me.SpinEdit2.AutoHeight = False
        Me.SpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit2.Name = "SpinEdit2"
        '
        'grcChuaDuDiem
        '
        Me.grcChuaDuDiem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcChuaDuDiem.Location = New System.Drawing.Point(473, 83)
        Me.grcChuaDuDiem.MainView = Me.grvChuaDuDiem
        Me.grcChuaDuDiem.Name = "grcChuaDuDiem"
        Me.grcChuaDuDiem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2})
        Me.grcChuaDuDiem.Size = New System.Drawing.Size(444, 265)
        Me.grcChuaDuDiem.TabIndex = 93
        Me.grcChuaDuDiem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvChuaDuDiem})
        '
        'grvChuaDuDiem
        '
        Me.grvChuaDuDiem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ten_lop2, Me.GridColumn1, Me.GridColumn2, Me.So_hoc_trinh, Me.Phan_tram})
        Me.grvChuaDuDiem.GridControl = Me.grcChuaDuDiem
        Me.grvChuaDuDiem.GroupPanelText = "Hãy chọn và kéo cột bạn muốn nhóm vào đây"
        Me.grvChuaDuDiem.Name = "grvChuaDuDiem"
        Me.grvChuaDuDiem.OptionsMenu.EnableColumnMenu = False
        Me.grvChuaDuDiem.OptionsMenu.EnableFooterMenu = False
        Me.grvChuaDuDiem.OptionsMenu.EnableGroupPanelMenu = False
        Me.grvChuaDuDiem.OptionsView.ShowAutoFilterRow = True
        Me.grvChuaDuDiem.OptionsView.ShowGroupPanel = False
        '
        'Ten_lop2
        '
        Me.Ten_lop2.Caption = "Nhóm lớp"
        Me.Ten_lop2.FieldName = "STT_lop"
        Me.Ten_lop2.Name = "Ten_lop2"
        Me.Ten_lop2.OptionsColumn.AllowEdit = False
        Me.Ten_lop2.Visible = True
        Me.Ten_lop2.VisibleIndex = 0
        Me.Ten_lop2.Width = 54
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ký hiệu lớp"
        Me.GridColumn1.FieldName = "Ky_hieu_lop_tc"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tên học phần"
        Me.GridColumn2.FieldName = "Ten_mon"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 165
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.Caption = "SốTC "
        Me.So_hoc_trinh.FieldName = "So_hoc_trinh"
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.OptionsColumn.AllowEdit = False
        Me.So_hoc_trinh.Visible = True
        Me.So_hoc_trinh.VisibleIndex = 3
        Me.So_hoc_trinh.Width = 42
        '
        'Phan_tram
        '
        Me.Phan_tram.Caption = "TL %"
        Me.Phan_tram.FieldName = "Phan_tram"
        Me.Phan_tram.Name = "Phan_tram"
        Me.Phan_tram.OptionsColumn.AllowEdit = False
        Me.Phan_tram.Visible = True
        Me.Phan_tram.VisibleIndex = 4
        Me.Phan_tram.Width = 44
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kien_thuc", 100, "Kiến thức")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Ten_kien_thuc"
        Me.RepositoryItemLookUpEdit1.DropDownRows = 5
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID_kien_thuc"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'grcDuDiemDaKhoa
        '
        Me.grcDuDiemDaKhoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDuDiemDaKhoa.Location = New System.Drawing.Point(470, 371)
        Me.grcDuDiemDaKhoa.MainView = Me.grvDuDiemDaKhoa
        Me.grcDuDiemDaKhoa.Name = "grcDuDiemDaKhoa"
        Me.grcDuDiemDaKhoa.Size = New System.Drawing.Size(447, 241)
        Me.grcDuDiemDaKhoa.TabIndex = 95
        Me.grcDuDiemDaKhoa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDuDiemDaKhoa})
        '
        'grvDuDiemDaKhoa
        '
        Me.grvDuDiemDaKhoa.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ten_lop4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.grvDuDiemDaKhoa.GridControl = Me.grcDuDiemDaKhoa
        Me.grvDuDiemDaKhoa.GroupPanelText = "Hãy chọn và kéo cột bạn muốn nhóm vào đây"
        Me.grvDuDiemDaKhoa.Name = "grvDuDiemDaKhoa"
        Me.grvDuDiemDaKhoa.OptionsMenu.EnableColumnMenu = False
        Me.grvDuDiemDaKhoa.OptionsMenu.EnableFooterMenu = False
        Me.grvDuDiemDaKhoa.OptionsMenu.EnableGroupPanelMenu = False
        Me.grvDuDiemDaKhoa.OptionsView.ShowAutoFilterRow = True
        Me.grvDuDiemDaKhoa.OptionsView.ShowGroupPanel = False
        '
        'Ten_lop4
        '
        Me.Ten_lop4.Caption = "Nhóm lớp"
        Me.Ten_lop4.FieldName = "STT_lop"
        Me.Ten_lop4.Name = "Ten_lop4"
        Me.Ten_lop4.OptionsColumn.AllowEdit = False
        Me.Ten_lop4.Visible = True
        Me.Ten_lop4.VisibleIndex = 0
        Me.Ten_lop4.Width = 55
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ký hiệu lớp"
        Me.GridColumn5.FieldName = "Ky_hieu_lop_tc"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 86
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tên học phần"
        Me.GridColumn6.FieldName = "Ten_mon"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 218
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "SốTC "
        Me.GridColumn7.FieldName = "So_hoc_trinh"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 42
        '
        'grcDuDiemChuaKhoa
        '
        Me.grcDuDiemChuaKhoa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grcDuDiemChuaKhoa.Location = New System.Drawing.Point(0, 371)
        Me.grcDuDiemChuaKhoa.MainView = Me.grvDuDiemChuaKhoa
        Me.grcDuDiemChuaKhoa.Name = "grcDuDiemChuaKhoa"
        Me.grcDuDiemChuaKhoa.Size = New System.Drawing.Size(451, 241)
        Me.grcDuDiemChuaKhoa.TabIndex = 94
        Me.grcDuDiemChuaKhoa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDuDiemChuaKhoa})
        '
        'grvDuDiemChuaKhoa
        '
        Me.grvDuDiemChuaKhoa.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ten_lop3, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.Phan_tram2})
        Me.grvDuDiemChuaKhoa.GridControl = Me.grcDuDiemChuaKhoa
        Me.grvDuDiemChuaKhoa.GroupPanelText = "Hãy chọn và kéo cột bạn muốn nhóm vào đây"
        Me.grvDuDiemChuaKhoa.Name = "grvDuDiemChuaKhoa"
        Me.grvDuDiemChuaKhoa.OptionsMenu.EnableColumnMenu = False
        Me.grvDuDiemChuaKhoa.OptionsMenu.EnableFooterMenu = False
        Me.grvDuDiemChuaKhoa.OptionsMenu.EnableGroupPanelMenu = False
        Me.grvDuDiemChuaKhoa.OptionsView.ShowAutoFilterRow = True
        Me.grvDuDiemChuaKhoa.OptionsView.ShowGroupPanel = False
        '
        'Ten_lop3
        '
        Me.Ten_lop3.Caption = "Nhóm lớp"
        Me.Ten_lop3.FieldName = "STT_lop"
        Me.Ten_lop3.Name = "Ten_lop3"
        Me.Ten_lop3.OptionsColumn.AllowEdit = False
        Me.Ten_lop3.Visible = True
        Me.Ten_lop3.VisibleIndex = 0
        Me.Ten_lop3.Width = 54
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ký hiệu lớp"
        Me.GridColumn9.FieldName = "Ky_hieu_lop_tc"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 77
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tên học phần"
        Me.GridColumn10.FieldName = "Ten_mon"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 192
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "SốTC "
        Me.GridColumn11.FieldName = "So_hoc_trinh"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 44
        '
        'Phan_tram2
        '
        Me.Phan_tram2.Caption = "TL %"
        Me.Phan_tram2.FieldName = "Phan_tram"
        Me.Phan_tram2.Name = "Phan_tram2"
        Me.Phan_tram2.Visible = True
        Me.Phan_tram2.VisibleIndex = 4
        Me.Phan_tram2.Width = 37
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 17)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "CÁC LỚP HỌC PHẦN CHƯA CÓ ĐIỂM"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(512, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(386, 17)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "CÁC LỚP HỌC PHẦN ĐANG NHẬP ĐIỂM (CHƯA ĐỦ)"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(495, 17)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "CÁC LỚP HỌC PHẦN ĐÃ HOÀN THÀNH NHẬP ĐIỂM(CHƯA KHÓA)"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(581, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 17)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "CÁC LỚP HỌC PHẦN ĐÃ KHÓA ĐIỂM"
        '
        'cmdKhoa_Diem
        '
        Me.cmdKhoa_Diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdKhoa_Diem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKhoa_Diem.Appearance.Options.UseFont = True
        Me.cmdKhoa_Diem.ImageIndex = 22
        Me.cmdKhoa_Diem.Location = New System.Drawing.Point(584, 615)
        Me.cmdKhoa_Diem.Name = "cmdKhoa_Diem"
        Me.cmdKhoa_Diem.Size = New System.Drawing.Size(101, 30)
        Me.cmdKhoa_Diem.TabIndex = 294
        Me.cmdKhoa_Diem.Text = "Tổng hợp"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.Location = New System.Drawing.Point(689, 615)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrintList.TabIndex = 293
        Me.cmdPrintList.Text = "In tổng hợp"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.Location = New System.Drawing.Point(811, 615)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(106, 30)
        Me.cmdClose.TabIndex = 292
        Me.cmdClose.Text = "Thoát"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(122, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(672, 19)
        Me.Label8.TabIndex = 295
        Me.Label8.Text = "TỔNG HỢP QUÁ TRÌNH NHẬP ĐIỂM THÀNH PHẦN THEO LỚP TÍN CHỈ CỦA GIẢNG VIÊN"
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNam_hoc.Location = New System.Drawing.Point(211, 27)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(98, 23)
        Me.cmbNam_hoc.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 28)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoc_ky.Location = New System.Drawing.Point(72, 27)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(74, 23)
        Me.cmbHoc_ky.TabIndex = 84
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLan_cap.Location = New System.Drawing.Point(2, 25)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(70, 28)
        Me.lblLan_cap.TabIndex = 83
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKy_dang_ky
        '
        Me.cmbKy_dang_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_dang_ky.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKy_dang_ky.Location = New System.Drawing.Point(670, 27)
        Me.cmbKy_dang_ky.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbKy_dang_ky.Name = "cmbKy_dang_ky"
        Me.cmbKy_dang_ky.Size = New System.Drawing.Size(233, 23)
        Me.cmbKy_dang_ky.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(621, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 27)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Đợt:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(408, 25)
        Me.cmbID_he.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(215, 23)
        Me.cmbID_he.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(312, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 23)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Hệ đào tạo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 647)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdKhoa_Diem)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grcDuDiemDaKhoa)
        Me.Controls.Add(Me.grcDuDiemChuaKhoa)
        Me.Controls.Add(Me.grcChuaDuDiem)
        Me.Controls.Add(Me.grcChuaCoDiem)
        Me.Controls.Add(Me.cmbKy_dang_ky)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_TongHop_MonNhapDiem_ThanhPhan"
        CType(Me.grcChuaCoDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvChuaCoDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKhoiKienThuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcChuaDuDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvChuaDuDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDuDiemDaKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDuDiemDaKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDuDiemChuaKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDuDiemChuaKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grcChuaCoDiem As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvChuaCoDiem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKhoiKienThuc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grcChuaDuDiem As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvChuaDuDiem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents So_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Phan_tram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents grcDuDiemDaKhoa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDuDiemDaKhoa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDuDiemChuaKhoa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDuDiemChuaKhoa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdKhoa_Diem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Phan_tram2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ten_lop1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ten_lop2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ten_lop4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ten_lop3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbKy_dang_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
