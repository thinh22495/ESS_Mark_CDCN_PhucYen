<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_DongTui
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThi_DongTui))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdLap_phach = New System.Windows.Forms.ToolStripButton
        Me.cmdXoa_tui = New System.Windows.Forms.ToolStripButton
        Me.Print = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdPrint_DiemSoChu = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrin_HoiPhach = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_Full = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_DoiChieu_PhachSBD = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_DoiChieu_PhachSBDDiem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_SBDDiem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtSophach_tu = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbTui_thi = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkAll2 = New System.Windows.Forms.CheckBox
        Me.chkAll1 = New System.Windows.Forms.CheckBox
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        Me.grcDanhSachThi = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_bao_danh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_phach = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu_thi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDanhSachThiChon = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachThiChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_bao_danh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_phach1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMa_sv1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGhi_chu_thi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdThoat = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.ToolStrip.SuspendLayout()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThiChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLap_phach, Me.cmdXoa_tui, Me.Print, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 50
        Me.ToolStrip.Text = "ToolStrip1"
        Me.ToolStrip.Visible = False
        '
        'cmdLap_phach
        '
        Me.cmdLap_phach.Image = Global.ESSMarkMan.My.Resources.Resources.Import
        Me.cmdLap_phach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLap_phach.Name = "cmdLap_phach"
        Me.cmdLap_phach.Size = New System.Drawing.Size(114, 22)
        Me.cmdLap_phach.Text = "Lập số phách"
        '
        'cmdXoa_tui
        '
        Me.cmdXoa_tui.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdXoa_tui.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXoa_tui.Name = "cmdXoa_tui"
        Me.cmdXoa_tui.Size = New System.Drawing.Size(71, 22)
        Me.cmdXoa_tui.Text = "Xoá túi"
        '
        'Print
        '
        Me.Print.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint_DiemSoChu, Me.cmdPrin_HoiPhach, Me.cmdPrint_Full, Me.cmdPrint_DoiChieu_PhachSBD, Me.cmdPrint_DoiChieu_PhachSBDDiem, Me.cmdPrint_SBDDiem})
        Me.Print.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(103, 22)
        Me.Print.Text = "In báo cáo"
        '
        'cmdPrint_DiemSoChu
        '
        Me.cmdPrint_DiemSoChu.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_DiemSoChu.Name = "cmdPrint_DiemSoChu"
        Me.cmdPrint_DiemSoChu.Size = New System.Drawing.Size(290, 22)
        Me.cmdPrint_DiemSoChu.Text = "Vào điểm số chữ"
        '
        'cmdPrin_HoiPhach
        '
        Me.cmdPrin_HoiPhach.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrin_HoiPhach.Name = "cmdPrin_HoiPhach"
        Me.cmdPrin_HoiPhach.Size = New System.Drawing.Size(290, 22)
        Me.cmdPrin_HoiPhach.Text = "Hồi phách"
        '
        'cmdPrint_Full
        '
        Me.cmdPrint_Full.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_Full.Name = "cmdPrint_Full"
        Me.cmdPrint_Full.Size = New System.Drawing.Size(290, 22)
        Me.cmdPrint_Full.Text = "Hồi phách đầy đủ"
        '
        'cmdPrint_DoiChieu_PhachSBD
        '
        Me.cmdPrint_DoiChieu_PhachSBD.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_DoiChieu_PhachSBD.Name = "cmdPrint_DoiChieu_PhachSBD"
        Me.cmdPrint_DoiChieu_PhachSBD.Size = New System.Drawing.Size(290, 22)
        Me.cmdPrint_DoiChieu_PhachSBD.Text = "Đối chiếu số phách và SBD"
        '
        'cmdPrint_DoiChieu_PhachSBDDiem
        '
        Me.cmdPrint_DoiChieu_PhachSBDDiem.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_DoiChieu_PhachSBDDiem.Name = "cmdPrint_DoiChieu_PhachSBDDiem"
        Me.cmdPrint_DoiChieu_PhachSBDDiem.Size = New System.Drawing.Size(290, 22)
        Me.cmdPrint_DoiChieu_PhachSBDDiem.Text = "Đối chiếu phách và SBD vào điểm"
        '
        'cmdPrint_SBDDiem
        '
        Me.cmdPrint_SBDDiem.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_SBDDiem.Name = "cmdPrint_SBDDiem"
        Me.cmdPrint_SBDDiem.Size = New System.Drawing.Size(290, 22)
        Me.cmdPrint_SBDDiem.Text = "SBD và điểm số - chữ"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'txtSophach_tu
        '
        Me.txtSophach_tu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSophach_tu.Location = New System.Drawing.Point(731, 1)
        Me.txtSophach_tu.MaxLength = 8
        Me.txtSophach_tu.Name = "txtSophach_tu"
        Me.txtSophach_tu.Size = New System.Drawing.Size(42, 23)
        Me.txtSophach_tu.TabIndex = 59
        Me.txtSophach_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(619, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Số phách từ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTui_thi
        '
        Me.cmbTui_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTui_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTui_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbTui_thi.Location = New System.Drawing.Point(549, 0)
        Me.cmbTui_thi.Name = "cmbTui_thi"
        Me.cmbTui_thi.Size = New System.Drawing.Size(64, 24)
        Me.cmbTui_thi.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(468, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Túi thí số:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSo_sv
        '
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(545, 264)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(60, 18)
        Me.txtSo_sv.TabIndex = 102
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(415, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Tổng số sinh viên:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll2
        '
        Me.chkAll2.AutoSize = True
        Me.chkAll2.BackColor = System.Drawing.Color.Transparent
        Me.chkAll2.Location = New System.Drawing.Point(281, 263)
        Me.chkAll2.Name = "chkAll2"
        Me.chkAll2.Size = New System.Drawing.Size(100, 20)
        Me.chkAll2.TabIndex = 104
        Me.chkAll2.Text = "Chọn tất cả"
        Me.chkAll2.UseVisualStyleBackColor = False
        '
        'chkAll1
        '
        Me.chkAll1.AutoSize = True
        Me.chkAll1.BackColor = System.Drawing.Color.Transparent
        Me.chkAll1.Location = New System.Drawing.Point(269, 2)
        Me.chkAll1.Name = "chkAll1"
        Me.chkAll1.Size = New System.Drawing.Size(100, 20)
        Me.chkAll1.TabIndex = 103
        Me.chkAll1.Text = "Chọn tất cả"
        Me.chkAll1.UseVisualStyleBackColor = False
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 0)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 565)
        Me.trvPhongThi.TabIndex = 55
        '
        'grcDanhSachThi
        '
        Me.grcDanhSachThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThi.Location = New System.Drawing.Point(265, 28)
        Me.grcDanhSachThi.MainView = Me.grvDanhSachThi
        Me.grcDanhSachThi.Name = "grcDanhSachThi"
        Me.grcDanhSachThi.Size = New System.Drawing.Size(525, 228)
        Me.grcDanhSachThi.TabIndex = 153
        Me.grcDanhSachThi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThi})
        '
        'grvDanhSachThi
        '
        Me.grvDanhSachThi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colSo_bao_danh, Me.colSo_phach, Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colGhi_chu_thi})
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
        'colSo_bao_danh
        '
        Me.colSo_bao_danh.Caption = "Số báo danh"
        Me.colSo_bao_danh.FieldName = "So_bao_danh"
        Me.colSo_bao_danh.Name = "colSo_bao_danh"
        Me.colSo_bao_danh.Visible = True
        Me.colSo_bao_danh.VisibleIndex = 1
        Me.colSo_bao_danh.Width = 80
        '
        'colSo_phach
        '
        Me.colSo_phach.Caption = "Số phách"
        Me.colSo_phach.FieldName = "So_phach"
        Me.colSo_phach.Name = "colSo_phach"
        Me.colSo_phach.OptionsColumn.ReadOnly = True
        Me.colSo_phach.Width = 85
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 2
        Me.colMa_sv.Width = 80
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 3
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
        Me.colNgay_sinh.VisibleIndex = 4
        Me.colNgay_sinh.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 5
        Me.colTen_lop.Width = 61
        '
        'colGhi_chu_thi
        '
        Me.colGhi_chu_thi.Caption = "Ghi chú "
        Me.colGhi_chu_thi.FieldName = "Ghi_chu_thi"
        Me.colGhi_chu_thi.Name = "colGhi_chu_thi"
        Me.colGhi_chu_thi.Visible = True
        Me.colGhi_chu_thi.VisibleIndex = 6
        Me.colGhi_chu_thi.Width = 83
        '
        'grcDanhSachThiChon
        '
        Me.grcDanhSachThiChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachThiChon.Location = New System.Drawing.Point(265, 289)
        Me.grcDanhSachThiChon.MainView = Me.grvDanhSachThiChon
        Me.grcDanhSachThiChon.Name = "grcDanhSachThiChon"
        Me.grcDanhSachThiChon.Size = New System.Drawing.Size(526, 236)
        Me.grcDanhSachThiChon.TabIndex = 154
        Me.grcDanhSachThiChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThiChon})
        '
        'grvDanhSachThiChon
        '
        Me.grvDanhSachThiChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon1, Me.colSo_bao_danh1, Me.colSo_phach1, Me.colMa_sv1, Me.colHo_ten1, Me.colNgay_sinh1, Me.colTen_lop1, Me.colGhi_chu_thi1})
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
        Me.colChon1.Visible = True
        Me.colChon1.VisibleIndex = 0
        Me.colChon1.Width = 47
        '
        'colSo_bao_danh1
        '
        Me.colSo_bao_danh1.Caption = "Số báo danh"
        Me.colSo_bao_danh1.FieldName = "So_bao_danh"
        Me.colSo_bao_danh1.Name = "colSo_bao_danh1"
        Me.colSo_bao_danh1.Visible = True
        Me.colSo_bao_danh1.VisibleIndex = 1
        Me.colSo_bao_danh1.Width = 80
        '
        'colSo_phach1
        '
        Me.colSo_phach1.Caption = "Số phách"
        Me.colSo_phach1.FieldName = "So_phach"
        Me.colSo_phach1.Name = "colSo_phach1"
        Me.colSo_phach1.OptionsColumn.ReadOnly = True
        Me.colSo_phach1.Visible = True
        Me.colSo_phach1.VisibleIndex = 2
        Me.colSo_phach1.Width = 85
        '
        'colMa_sv1
        '
        Me.colMa_sv1.Caption = "Mã SV"
        Me.colMa_sv1.FieldName = "Ma_sv"
        Me.colMa_sv1.Name = "colMa_sv1"
        Me.colMa_sv1.OptionsColumn.ReadOnly = True
        Me.colMa_sv1.Visible = True
        Me.colMa_sv1.VisibleIndex = 3
        Me.colMa_sv1.Width = 80
        '
        'colHo_ten1
        '
        Me.colHo_ten1.Caption = "Họ tên"
        Me.colHo_ten1.FieldName = "Ho_ten"
        Me.colHo_ten1.Name = "colHo_ten1"
        Me.colHo_ten1.OptionsColumn.ReadOnly = True
        Me.colHo_ten1.Visible = True
        Me.colHo_ten1.VisibleIndex = 4
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
        Me.colNgay_sinh1.VisibleIndex = 5
        Me.colNgay_sinh1.Width = 100
        '
        'colTen_lop1
        '
        Me.colTen_lop1.Caption = "Tên lớp"
        Me.colTen_lop1.FieldName = "Ten_lop"
        Me.colTen_lop1.Name = "colTen_lop1"
        Me.colTen_lop1.OptionsColumn.ReadOnly = True
        Me.colTen_lop1.Visible = True
        Me.colTen_lop1.VisibleIndex = 6
        Me.colTen_lop1.Width = 61
        '
        'colGhi_chu_thi1
        '
        Me.colGhi_chu_thi1.Caption = "Ghi chú "
        Me.colGhi_chu_thi1.FieldName = "Ghi_chu_thi"
        Me.colGhi_chu_thi1.Name = "colGhi_chu_thi1"
        Me.colGhi_chu_thi1.Visible = True
        Me.colGhi_chu_thi1.VisibleIndex = 7
        Me.colGhi_chu_thi1.Width = 83
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Location = New System.Drawing.Point(631, 262)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 155
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Location = New System.Drawing.Point(712, 262)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemove.TabIndex = 155
        Me.cmdRemove.Text = "Xóa"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(546, 531)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrint.TabIndex = 207
        Me.cmdPrint.Text = "In báo cáo"
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
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(420, 531)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(118, 30)
        Me.cmdDelete.TabIndex = 206
        Me.cmdDelete.Text = "Xóa túi"
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Appearance.Options.UseFont = True
        Me.cmdThoat.ImageIndex = 7
        Me.cmdThoat.ImageList = Me.ImgMain
        Me.cmdThoat.Location = New System.Drawing.Point(672, 531)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(118, 30)
        Me.cmdThoat.TabIndex = 205
        Me.cmdThoat.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(294, 531)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 30)
        Me.cmdSave.TabIndex = 204
        Me.cmdSave.Text = "Lập số phách"
        '
        'frmESS_ToChucThi_DongTui
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdThoat)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grcDanhSachThiChon)
        Me.Controls.Add(Me.grcDanhSachThi)
        Me.Controls.Add(Me.chkAll2)
        Me.Controls.Add(Me.chkAll1)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSophach_tu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTui_thi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_ToChucThi_DongTui"
        Me.Text = "DONG TUI TO CHUC THI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grcDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThiChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdLap_phach As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdXoa_tui As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents txtSophach_tu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTui_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkAll2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents Print As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdPrint_DiemSoChu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrin_HoiPhach As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_Full As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_DoiChieu_PhachSBD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_DoiChieu_PhachSBDDiem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_SBDDiem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grcDanhSachThi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_bao_danh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_phach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu_thi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDanhSachThiChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThiChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_bao_danh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_phach1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMa_sv1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGhi_chu_thi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
