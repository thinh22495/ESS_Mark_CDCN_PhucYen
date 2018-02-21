<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BangDiemSinhVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer ok
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_BangDiemSinhVien))
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdChuyenNganh = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTBC_tich_luy = New System.Windows.Forms.Label
        Me.lblSo_hoc_trinh_tich_luy = New System.Windows.Forms.Label
        Me.lblXep_loai_hoc_luc = New System.Windows.Forms.Label
        Me.lblSo_mon_cho_diem = New System.Windows.Forms.Label
        Me.lblSo_mon_thi_lai = New System.Windows.Forms.Label
        Me.lblSo_mon_hoc_lai = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbID_bangdiem = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.TBCHT10 = New System.Windows.Forms.Label
        Me.TBCHT4 = New System.Windows.Forms.Label
        Me.Nam_daotao = New System.Windows.Forms.Label
        Me.Xep_loai_tn = New System.Windows.Forms.Label
        Me.lblXep_loai_hoc_luc_En = New System.Windows.Forms.Label
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_BD = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DBC = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDiem = New DevExpress.XtraGrid.GridControl
        Me.grvDiem = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_hoc_trinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCMH1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCMH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiem_chu = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_lop
        '
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Location = New System.Drawing.Point(847, 9)
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(102, 24)
        Me.cmbID_lop.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(791, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Lớp:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(137, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Số tín chỉ đã tích luỹ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(330, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Số học phần chờ điểm:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(568, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "TBC tích luỹ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(780, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Xếp hạng học lực:"
        '
        'cmdChuyenNganh
        '
        Me.cmdChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdChuyenNganh.Items.AddRange(New Object() {"Bảng điểm chuyên ngành chính", "Bảng điểm chuyên ngành 2"})
        Me.cmdChuyenNganh.Location = New System.Drawing.Point(100, 9)
        Me.cmdChuyenNganh.Name = "cmdChuyenNganh"
        Me.cmdChuyenNganh.Size = New System.Drawing.Size(183, 24)
        Me.cmdChuyenNganh.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(18, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Bảng điểm:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTBC_tich_luy
        '
        Me.lblTBC_tich_luy.BackColor = System.Drawing.Color.Transparent
        Me.lblTBC_tich_luy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTBC_tich_luy.Location = New System.Drawing.Point(663, 43)
        Me.lblTBC_tich_luy.Name = "lblTBC_tich_luy"
        Me.lblTBC_tich_luy.Size = New System.Drawing.Size(53, 21)
        Me.lblTBC_tich_luy.TabIndex = 116
        '
        'lblSo_hoc_trinh_tich_luy
        '
        Me.lblSo_hoc_trinh_tich_luy.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_hoc_trinh_tich_luy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_hoc_trinh_tich_luy.Location = New System.Drawing.Point(277, 74)
        Me.lblSo_hoc_trinh_tich_luy.Name = "lblSo_hoc_trinh_tich_luy"
        Me.lblSo_hoc_trinh_tich_luy.Size = New System.Drawing.Size(53, 21)
        Me.lblSo_hoc_trinh_tich_luy.TabIndex = 117
        '
        'lblXep_loai_hoc_luc
        '
        Me.lblXep_loai_hoc_luc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXep_loai_hoc_luc.BackColor = System.Drawing.Color.Transparent
        Me.lblXep_loai_hoc_luc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblXep_loai_hoc_luc.Location = New System.Drawing.Point(909, 43)
        Me.lblXep_loai_hoc_luc.Name = "lblXep_loai_hoc_luc"
        Me.lblXep_loai_hoc_luc.Size = New System.Drawing.Size(67, 21)
        Me.lblXep_loai_hoc_luc.TabIndex = 118
        '
        'lblSo_mon_cho_diem
        '
        Me.lblSo_mon_cho_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon_cho_diem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon_cho_diem.Location = New System.Drawing.Point(484, 74)
        Me.lblSo_mon_cho_diem.Name = "lblSo_mon_cho_diem"
        Me.lblSo_mon_cho_diem.Size = New System.Drawing.Size(67, 21)
        Me.lblSo_mon_cho_diem.TabIndex = 119
        '
        'lblSo_mon_thi_lai
        '
        Me.lblSo_mon_thi_lai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_mon_thi_lai.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon_thi_lai.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon_thi_lai.Location = New System.Drawing.Point(871, 74)
        Me.lblSo_mon_thi_lai.Name = "lblSo_mon_thi_lai"
        Me.lblSo_mon_thi_lai.Size = New System.Drawing.Size(67, 21)
        Me.lblSo_mon_thi_lai.TabIndex = 123
        '
        'lblSo_mon_hoc_lai
        '
        Me.lblSo_mon_hoc_lai.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_mon_hoc_lai.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_mon_hoc_lai.Location = New System.Drawing.Point(689, 74)
        Me.lblSo_mon_hoc_lai.Name = "lblSo_mon_hoc_lai"
        Me.lblSo_mon_hoc_lai.Size = New System.Drawing.Size(53, 21)
        Me.lblSo_mon_hoc_lai.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(742, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 16)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Số học phần thi lại:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(551, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 16)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Số Học phần học lại:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Items.AddRange(New Object() {"Học kỳ", "Năm Học", "Toàn khoá học"})
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(704, 9)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(87, 24)
        Me.cmbKhoa_hoc.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(622, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Khoá học:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Items.AddRange(New Object() {"Học kỳ", "Năm Học", "Toàn khoá học"})
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(388, 9)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(234, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 127
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(283, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Chuyên ngành:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_bangdiem
        '
        Me.cmbID_bangdiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_bangdiem.Items.AddRange(New Object() {"Học kỳ", "Năm học", "Toàn khoá"})
        Me.cmbID_bangdiem.Location = New System.Drawing.Point(100, 41)
        Me.cmbID_bangdiem.Name = "cmbID_bangdiem"
        Me.cmbID_bangdiem.Size = New System.Drawing.Size(107, 24)
        Me.cmbID_bangdiem.TabIndex = 129
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(21, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 24)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Bảng điểm:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(330, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 24)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Năm học:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(409, 41)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(97, 24)
        Me.cmbNam_hoc.TabIndex = 133
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(270, 41)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(53, 24)
        Me.cmbHoc_ky.TabIndex = 131
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(211, 41)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 130
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBCHT10
        '
        Me.TBCHT10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBCHT10.BackColor = System.Drawing.Color.Transparent
        Me.TBCHT10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TBCHT10.Location = New System.Drawing.Point(538, 244)
        Me.TBCHT10.Name = "TBCHT10"
        Me.TBCHT10.Size = New System.Drawing.Size(75, 21)
        Me.TBCHT10.TabIndex = 134
        Me.TBCHT10.Visible = False
        '
        'TBCHT4
        '
        Me.TBCHT4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBCHT4.BackColor = System.Drawing.Color.Transparent
        Me.TBCHT4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TBCHT4.Location = New System.Drawing.Point(663, 244)
        Me.TBCHT4.Name = "TBCHT4"
        Me.TBCHT4.Size = New System.Drawing.Size(75, 21)
        Me.TBCHT4.TabIndex = 135
        Me.TBCHT4.Visible = False
        '
        'Nam_daotao
        '
        Me.Nam_daotao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nam_daotao.BackColor = System.Drawing.Color.Transparent
        Me.Nam_daotao.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Nam_daotao.Location = New System.Drawing.Point(786, 244)
        Me.Nam_daotao.Name = "Nam_daotao"
        Me.Nam_daotao.Size = New System.Drawing.Size(75, 21)
        Me.Nam_daotao.TabIndex = 136
        Me.Nam_daotao.Visible = False
        '
        'Xep_loai_tn
        '
        Me.Xep_loai_tn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Xep_loai_tn.BackColor = System.Drawing.Color.Transparent
        Me.Xep_loai_tn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Xep_loai_tn.Location = New System.Drawing.Point(906, 244)
        Me.Xep_loai_tn.Name = "Xep_loai_tn"
        Me.Xep_loai_tn.Size = New System.Drawing.Size(75, 21)
        Me.Xep_loai_tn.TabIndex = 137
        Me.Xep_loai_tn.Visible = False
        '
        'lblXep_loai_hoc_luc_En
        '
        Me.lblXep_loai_hoc_luc_En.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXep_loai_hoc_luc_En.BackColor = System.Drawing.Color.Transparent
        Me.lblXep_loai_hoc_luc_En.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblXep_loai_hoc_luc_En.Location = New System.Drawing.Point(538, 273)
        Me.lblXep_loai_hoc_luc_En.Name = "lblXep_loai_hoc_luc_En"
        Me.lblXep_loai_hoc_luc_En.Size = New System.Drawing.Size(119, 21)
        Me.lblXep_loai_hoc_luc_En.TabIndex = 138
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(6, 71)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(100, 24)
        Me.optAll.TabIndex = 141
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdPrint_BD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DBC)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_BD
        '
        Me.cmdPrint_BD.Caption = "Xem trước khi in bảng điểm"
        Me.cmdPrint_BD.Id = 2
        Me.cmdPrint_BD.ImageIndex = 16
        Me.cmdPrint_BD.Name = "cmdPrint_BD"
        '
        'cmdPrint_DBC
        '
        Me.cmdPrint_DBC.Caption = "In không cần xem bảng điểm"
        Me.cmdPrint_DBC.Id = 3
        Me.cmdPrint_DBC.ImageIndex = 16
        Me.cmdPrint_DBC.Name = "cmdPrint_DBC"
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("PopupMenu", New System.Guid("e259ec3f-8673-4306-bb4f-94322df1890e"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_BD, Me.cmdPrint_DBC})
        Me.BarManager1.MaxItemId = 5
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(993, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(993, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(993, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
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
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(809, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(87, 30)
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
        Me.cmdPrintList.Location = New System.Drawing.Point(668, 533)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(135, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(902, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 164
        Me.cmdClose.Text = "Thoát"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(3, 98)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(331, 430)
        Me.grcDanhSach.TabIndex = 169
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 50
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 1
        Me.colMa_sv.Width = 62
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 2
        Me.colHo_ten.Width = 94
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
        Me.colNgay_sinh.Width = 62
        '
        'grcDiem
        '
        Me.grcDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDiem.Location = New System.Drawing.Point(340, 98)
        Me.grcDiem.MainView = Me.grvDiem
        Me.grcDiem.Name = "grcDiem"
        Me.grcDiem.Size = New System.Drawing.Size(651, 430)
        Me.grcDiem.TabIndex = 170
        Me.grcDiem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDiem})
        '
        'grvDiem
        '
        Me.grvDiem.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu, Me.colTen_mon, Me.colSo_hoc_trinh, Me.colTBCMH1, Me.colTBCMH, Me.colDiem_chu})
        Me.grvDiem.GridControl = Me.grcDiem
        Me.grvDiem.Name = "grvDiem"
        Me.grvDiem.OptionsSelection.MultiSelect = True
        Me.grvDiem.OptionsView.ShowAutoFilterRow = True
        Me.grvDiem.OptionsView.ShowGroupPanel = False
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
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.ReadOnly = True
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 94
        '
        'colSo_hoc_trinh
        '
        Me.colSo_hoc_trinh.Caption = "Số tín chỉ"
        Me.colSo_hoc_trinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSo_hoc_trinh.FieldName = "So_hoc_trinh"
        Me.colSo_hoc_trinh.Name = "colSo_hoc_trinh"
        Me.colSo_hoc_trinh.OptionsColumn.ReadOnly = True
        Me.colSo_hoc_trinh.Visible = True
        Me.colSo_hoc_trinh.VisibleIndex = 2
        Me.colSo_hoc_trinh.Width = 62
        '
        'colTBCMH1
        '
        Me.colTBCMH1.Caption = "TBCMH1"
        Me.colTBCMH1.FieldName = "TBCMH1"
        Me.colTBCMH1.Name = "colTBCMH1"
        Me.colTBCMH1.Visible = True
        Me.colTBCMH1.VisibleIndex = 3
        '
        'colTBCMH
        '
        Me.colTBCMH.Caption = "TBCMH"
        Me.colTBCMH.FieldName = "TBCMH"
        Me.colTBCMH.Name = "colTBCMH"
        Me.colTBCMH.Visible = True
        Me.colTBCMH.VisibleIndex = 4
        '
        'colDiem_chu
        '
        Me.colDiem_chu.Caption = "Điểm chữ"
        Me.colDiem_chu.FieldName = "Diem_chu"
        Me.colDiem_chu.Name = "colDiem_chu"
        Me.colDiem_chu.Visible = True
        Me.colDiem_chu.VisibleIndex = 5
        '
        'frmESS_BangDiemSinhVien
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(993, 566)
        Me.Controls.Add(Me.grcDiem)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbID_bangdiem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSo_mon_thi_lai)
        Me.Controls.Add(Me.lblSo_mon_hoc_lai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSo_mon_cho_diem)
        Me.Controls.Add(Me.lblXep_loai_hoc_luc)
        Me.Controls.Add(Me.lblSo_hoc_trinh_tich_luy)
        Me.Controls.Add(Me.lblTBC_tich_luy)
        Me.Controls.Add(Me.cmdChuyenNganh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_lop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Xep_loai_tn)
        Me.Controls.Add(Me.Nam_daotao)
        Me.Controls.Add(Me.TBCHT4)
        Me.Controls.Add(Me.TBCHT10)
        Me.Controls.Add(Me.lblXep_loai_hoc_luc_En)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmESS_BangDiemSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BANG DIEM SINH VIEN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDiem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdChuyenNganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTBC_tich_luy As System.Windows.Forms.Label
    Friend WithEvents lblSo_hoc_trinh_tich_luy As System.Windows.Forms.Label
    Friend WithEvents lblXep_loai_hoc_luc As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon_cho_diem As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon_thi_lai As System.Windows.Forms.Label
    Friend WithEvents lblSo_mon_hoc_lai As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbID_bangdiem As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents TBCHT10 As System.Windows.Forms.Label
    Friend WithEvents TBCHT4 As System.Windows.Forms.Label
    Friend WithEvents Nam_daotao As System.Windows.Forms.Label
    Friend WithEvents Xep_loai_tn As System.Windows.Forms.Label
    Friend WithEvents lblXep_loai_hoc_luc_En As System.Windows.Forms.Label
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_BangDiem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_NhieuBangDiem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDiem As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDiem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_hoc_trinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCMH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCMH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiem_chu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint_BD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DBC As DevExpress.XtraBars.BarButtonItem
End Class
