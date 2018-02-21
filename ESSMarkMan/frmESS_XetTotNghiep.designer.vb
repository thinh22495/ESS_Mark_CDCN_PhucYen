<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetTotNghiep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_XetTotNghiep))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabTotNghiep = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDo_dai_So_van_bang = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDo_dai_So_hieu = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTien_to_SoVaoSo = New System.Windows.Forms.TextBox
        Me.btnSave_SoVaoSo = New System.Windows.Forms.Button
        Me.txtTu_So_SoVaoSo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTienTo_SoHieu = New System.Windows.Forms.TextBox
        Me.dtmNgay_QD = New System.Windows.Forms.DateTimePicker
        Me.lblNgay_sinh = New System.Windows.Forms.Label
        Me.txtSo_QD = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grcTotNghiep = New DevExpress.XtraGrid.GridControl
        Me.grvTotNghiep = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Lock = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Chon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PhanTram_ThiLai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_tin_chi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.So_QD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColSoHieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColSo_vao_so = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnLap_so_SoHieu = New System.Windows.Forms.Button
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.trvLop1 = New ESSMarkMan.TreeViewLop
        Me.txtTu_so_so_hieu = New System.Windows.Forms.TextBox
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.labSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbChon = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabChuaTotNghiep = New System.Windows.Forms.TabPage
        Me.grcNoTotNghiep = New DevExpress.XtraGrid.GridControl
        Me.grvNoTotNghiep = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbNam_hoc_CTN = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblSV_CTN = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.trvLop2 = New ESSMarkMan.TreeViewLop
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_DS_totnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_BD_toankhoa = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_QD_totnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DS_nototnghiep = New DevExpress.XtraBars.BarButtonItem
        Me.btnInBang_TN = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdTongHop_XetTN = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdXetTN = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLapSB = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.lblXet_TN = New System.Windows.Forms.Label
        Me.cmdSave_QD = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.TabControl1.SuspendLayout()
        Me.TabTotNghiep.SuspendLayout()
        CType(Me.grcTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChuaTotNghiep.SuspendLayout()
        CType(Me.grcNoTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvNoTotNghiep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabTotNghiep)
        Me.TabControl1.Controls.Add(Me.TabChuaTotNghiep)
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 495)
        Me.TabControl1.TabIndex = 102
        '
        'TabTotNghiep
        '
        Me.TabTotNghiep.Controls.Add(Me.Label12)
        Me.TabTotNghiep.Controls.Add(Me.txtDo_dai_So_van_bang)
        Me.TabTotNghiep.Controls.Add(Me.Label10)
        Me.TabTotNghiep.Controls.Add(Me.txtDo_dai_So_hieu)
        Me.TabTotNghiep.Controls.Add(Me.Label7)
        Me.TabTotNghiep.Controls.Add(Me.txtTien_to_SoVaoSo)
        Me.TabTotNghiep.Controls.Add(Me.btnSave_SoVaoSo)
        Me.TabTotNghiep.Controls.Add(Me.txtTu_So_SoVaoSo)
        Me.TabTotNghiep.Controls.Add(Me.Label9)
        Me.TabTotNghiep.Controls.Add(Me.Label6)
        Me.TabTotNghiep.Controls.Add(Me.txtTienTo_SoHieu)
        Me.TabTotNghiep.Controls.Add(Me.dtmNgay_QD)
        Me.TabTotNghiep.Controls.Add(Me.lblNgay_sinh)
        Me.TabTotNghiep.Controls.Add(Me.txtSo_QD)
        Me.TabTotNghiep.Controls.Add(Me.Label2)
        Me.TabTotNghiep.Controls.Add(Me.grcTotNghiep)
        Me.TabTotNghiep.Controls.Add(Me.btnLap_so_SoHieu)
        Me.TabTotNghiep.Controls.Add(Me.cmbNam_hoc)
        Me.TabTotNghiep.Controls.Add(Me.Label1)
        Me.TabTotNghiep.Controls.Add(Me.trvLop1)
        Me.TabTotNghiep.Controls.Add(Me.txtTu_so_so_hieu)
        Me.TabTotNghiep.Controls.Add(Me.cmbLan_thu)
        Me.TabTotNghiep.Controls.Add(Me.Label11)
        Me.TabTotNghiep.Controls.Add(Me.Label8)
        Me.TabTotNghiep.Controls.Add(Me.labSo_sv)
        Me.TabTotNghiep.Controls.Add(Me.Label4)
        Me.TabTotNghiep.Controls.Add(Me.cbChon)
        Me.TabTotNghiep.Controls.Add(Me.Label13)
        Me.TabTotNghiep.Location = New System.Drawing.Point(4, 25)
        Me.TabTotNghiep.Name = "TabTotNghiep"
        Me.TabTotNghiep.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTotNghiep.Size = New System.Drawing.Size(784, 466)
        Me.TabTotNghiep.TabIndex = 0
        Me.TabTotNghiep.Text = "Đủ điều kiện tôt nghiệp ra trường"
        Me.TabTotNghiep.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(660, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 23)
        Me.Label12.TabIndex = 167
        Me.Label12.Text = "Độ dài số:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDo_dai_So_van_bang
        '
        Me.txtDo_dai_So_van_bang.Location = New System.Drawing.Point(741, 61)
        Me.txtDo_dai_So_van_bang.MaxLength = 2
        Me.txtDo_dai_So_van_bang.Name = "txtDo_dai_So_van_bang"
        Me.txtDo_dai_So_van_bang.Size = New System.Drawing.Size(38, 23)
        Me.txtDo_dai_So_van_bang.TabIndex = 166
        Me.txtDo_dai_So_van_bang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(629, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 23)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Độ dài số:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDo_dai_So_hieu
        '
        Me.txtDo_dai_So_hieu.Location = New System.Drawing.Point(741, 32)
        Me.txtDo_dai_So_hieu.MaxLength = 2
        Me.txtDo_dai_So_hieu.Name = "txtDo_dai_So_hieu"
        Me.txtDo_dai_So_hieu.Size = New System.Drawing.Size(38, 23)
        Me.txtDo_dai_So_hieu.TabIndex = 164
        Me.txtDo_dai_So_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(466, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 23)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Từ số:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTien_to_SoVaoSo
        '
        Me.txtTien_to_SoVaoSo.Location = New System.Drawing.Point(413, 57)
        Me.txtTien_to_SoVaoSo.MaxLength = 8
        Me.txtTien_to_SoVaoSo.Name = "txtTien_to_SoVaoSo"
        Me.txtTien_to_SoVaoSo.Size = New System.Drawing.Size(59, 23)
        Me.txtTien_to_SoVaoSo.TabIndex = 162
        Me.txtTien_to_SoVaoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave_SoVaoSo
        '
        Me.btnSave_SoVaoSo.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.btnSave_SoVaoSo.Location = New System.Drawing.Point(592, 58)
        Me.btnSave_SoVaoSo.Name = "btnSave_SoVaoSo"
        Me.btnSave_SoVaoSo.Size = New System.Drawing.Size(30, 24)
        Me.btnSave_SoVaoSo.TabIndex = 161
        Me.btnSave_SoVaoSo.UseVisualStyleBackColor = True
        '
        'txtTu_So_SoVaoSo
        '
        Me.txtTu_So_SoVaoSo.Location = New System.Drawing.Point(519, 58)
        Me.txtTu_So_SoVaoSo.MaxLength = 8
        Me.txtTu_So_SoVaoSo.Name = "txtTu_So_SoVaoSo"
        Me.txtTu_So_SoVaoSo.Size = New System.Drawing.Size(67, 23)
        Me.txtTu_So_SoVaoSo.TabIndex = 160
        Me.txtTu_So_SoVaoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(264, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 23)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Số vào sổ - Tiền tố:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(466, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 23)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "Từ số:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTienTo_SoHieu
        '
        Me.txtTienTo_SoHieu.Location = New System.Drawing.Point(413, 32)
        Me.txtTienTo_SoHieu.MaxLength = 8
        Me.txtTienTo_SoHieu.Name = "txtTienTo_SoHieu"
        Me.txtTienTo_SoHieu.Size = New System.Drawing.Size(59, 23)
        Me.txtTienTo_SoHieu.TabIndex = 157
        Me.txtTienTo_SoHieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtmNgay_QD
        '
        Me.dtmNgay_QD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtmNgay_QD.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText
        Me.dtmNgay_QD.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtmNgay_QD.CustomFormat = "dd/MM/yyyy"
        Me.dtmNgay_QD.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dtmNgay_QD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmNgay_QD.Location = New System.Drawing.Point(536, 3)
        Me.dtmNgay_QD.Name = "dtmNgay_QD"
        Me.dtmNgay_QD.ShowCheckBox = True
        Me.dtmNgay_QD.Size = New System.Drawing.Size(124, 23)
        Me.dtmNgay_QD.TabIndex = 155
        '
        'lblNgay_sinh
        '
        Me.lblNgay_sinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNgay_sinh.BackColor = System.Drawing.Color.Transparent
        Me.lblNgay_sinh.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblNgay_sinh.ForeColor = System.Drawing.Color.Black
        Me.lblNgay_sinh.Location = New System.Drawing.Point(470, 3)
        Me.lblNgay_sinh.Name = "lblNgay_sinh"
        Me.lblNgay_sinh.Size = New System.Drawing.Size(69, 23)
        Me.lblNgay_sinh.TabIndex = 156
        Me.lblNgay_sinh.Text = "Ngày QĐ"
        Me.lblNgay_sinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSo_QD
        '
        Me.txtSo_QD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_QD.Location = New System.Drawing.Point(384, 3)
        Me.txtSo_QD.MaxLength = 30
        Me.txtSo_QD.Name = "txtSo_QD"
        Me.txtSo_QD.Size = New System.Drawing.Size(80, 23)
        Me.txtSo_QD.TabIndex = 154
        Me.txtSo_QD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(308, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Số QĐ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grcTotNghiep
        '
        Me.grcTotNghiep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcTotNghiep.Location = New System.Drawing.Point(254, 96)
        Me.grcTotNghiep.MainView = Me.grvTotNghiep
        Me.grcTotNghiep.Name = "grcTotNghiep"
        Me.grcTotNghiep.Size = New System.Drawing.Size(529, 331)
        Me.grcTotNghiep.TabIndex = 118
        Me.grcTotNghiep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvTotNghiep})
        '
        'grvTotNghiep
        '
        Me.grvTotNghiep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Lock, Me.Chon, Me.GridColumn4, Me.GridColumn1, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTBCHT, Me.GridColumn3, Me.PhanTram_ThiLai, Me.colSo_tin_chi, Me.So_QD, Me.GridColumn2, Me.GridColumn5, Me.ColSoHieu, Me.ColSo_vao_so})
        Me.grvTotNghiep.GridControl = Me.grcTotNghiep
        Me.grvTotNghiep.Name = "grvTotNghiep"
        Me.grvTotNghiep.OptionsSelection.MultiSelect = True
        Me.grvTotNghiep.OptionsView.ShowAutoFilterRow = True
        Me.grvTotNghiep.OptionsView.ShowGroupPanel = False
        '
        'Lock
        '
        Me.Lock.Caption = "Khóa"
        Me.Lock.FieldName = "Lock"
        Me.Lock.Name = "Lock"
        Me.Lock.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.Lock.Visible = True
        Me.Lock.VisibleIndex = 0
        Me.Lock.Width = 40
        '
        'Chon
        '
        Me.Chon.Caption = "Chọn"
        Me.Chon.FieldName = "Chon"
        Me.Chon.Name = "Chon"
        Me.Chon.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.Chon.Visible = True
        Me.Chon.VisibleIndex = 1
        Me.Chon.Width = 21
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Số QĐ"
        Me.GridColumn4.FieldName = "So_qd"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 65
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã sinh viên"
        Me.GridColumn1.FieldName = "Ma_sv"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 23
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.AllowEdit = False
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 3
        Me.colHo_ten.Width = 55
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.OptionsColumn.AllowEdit = False
        Me.colNgay_sinh.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 4
        Me.colNgay_sinh.Width = 27
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.AllowEdit = False
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 5
        Me.colTen_lop.Width = 23
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
        Me.colTBCHT.Width = 26
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "TBCHT hệ 10"
        Me.GridColumn3.FieldName = "TBCHT10"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 9
        Me.GridColumn3.Width = 34
        '
        'PhanTram_ThiLai
        '
        Me.PhanTram_ThiLai.Caption = "% thi lại"
        Me.PhanTram_ThiLai.FieldName = "PhanTram_ThiLai"
        Me.PhanTram_ThiLai.Name = "PhanTram_ThiLai"
        Me.PhanTram_ThiLai.OptionsColumn.AllowEdit = False
        Me.PhanTram_ThiLai.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.PhanTram_ThiLai.Visible = True
        Me.PhanTram_ThiLai.VisibleIndex = 8
        Me.PhanTram_ThiLai.Width = 22
        '
        'colSo_tin_chi
        '
        Me.colSo_tin_chi.Caption = "Xếp hạng"
        Me.colSo_tin_chi.FieldName = "Xep_hang"
        Me.colSo_tin_chi.Name = "colSo_tin_chi"
        Me.colSo_tin_chi.OptionsColumn.AllowEdit = False
        Me.colSo_tin_chi.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colSo_tin_chi.Visible = True
        Me.colSo_tin_chi.VisibleIndex = 7
        Me.colSo_tin_chi.Width = 21
        '
        'So_QD
        '
        Me.So_QD.Caption = "Số QĐ"
        Me.So_QD.FieldName = "So_QD"
        Me.So_QD.Name = "So_QD"
        Me.So_QD.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.So_QD.Visible = True
        Me.So_QD.VisibleIndex = 10
        Me.So_QD.Width = 36
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Ngày QĐ"
        Me.GridColumn2.FieldName = "Ngay_QD"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 11
        Me.GridColumn2.Width = 51
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "GridColumn5"
        Me.GridColumn5.FieldName = "Gioi_tinh"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 20
        '
        'ColSoHieu
        '
        Me.ColSoHieu.Caption = "Số hiệu bằng"
        Me.ColSoHieu.FieldName = "So_hieu"
        Me.ColSoHieu.Name = "ColSoHieu"
        Me.ColSoHieu.Visible = True
        Me.ColSoHieu.VisibleIndex = 12
        Me.ColSoHieu.Width = 68
        '
        'ColSo_vao_so
        '
        Me.ColSo_vao_so.Caption = "Số vào sổ"
        Me.ColSo_vao_so.FieldName = "So_vao_so"
        Me.ColSo_vao_so.Name = "ColSo_vao_so"
        Me.ColSo_vao_so.Visible = True
        Me.ColSo_vao_so.VisibleIndex = 13
        Me.ColSo_vao_so.Width = 61
        '
        'btnLap_so_SoHieu
        '
        Me.btnLap_so_SoHieu.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.btnLap_so_SoHieu.Location = New System.Drawing.Point(592, 33)
        Me.btnLap_so_SoHieu.Name = "btnLap_so_SoHieu"
        Me.btnLap_so_SoHieu.Size = New System.Drawing.Size(30, 24)
        Me.btnLap_so_SoHieu.TabIndex = 117
        Me.btnLap_so_SoHieu.UseVisualStyleBackColor = True
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNam_hoc.Location = New System.Drawing.Point(76, 3)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(108, 24)
        Me.cmbNam_hoc.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvLop1
        '
        Me.trvLop1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop1.BackColor = System.Drawing.Color.Transparent
        Me.trvLop1.dtLop = Nothing
        Me.trvLop1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop1.Location = New System.Drawing.Point(0, 25)
        Me.trvLop1.Name = "trvLop1"
        Me.trvLop1.Size = New System.Drawing.Size(258, 408)
        Me.trvLop1.TabIndex = 114
        '
        'txtTu_so_so_hieu
        '
        Me.txtTu_so_so_hieu.Location = New System.Drawing.Point(519, 33)
        Me.txtTu_so_so_hieu.MaxLength = 8
        Me.txtTu_so_so_hieu.Name = "txtTu_so_so_hieu"
        Me.txtTu_so_so_hieu.Size = New System.Drawing.Size(67, 23)
        Me.txtTu_so_so_hieu.TabIndex = 110
        Me.txtTu_so_so_hieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Items.AddRange(New Object() {"01", "02", "03"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(252, 3)
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(50, 24)
        Me.cmbLan_thu.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(193, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "Lần xét:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(264, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 23)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Số hiệu bằng - Tiền tố:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labSo_sv
        '
        Me.labSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(730, 0)
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
        Me.Label4.Location = New System.Drawing.Point(658, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Tống số:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbChon
        '
        Me.cbChon.AutoSize = True
        Me.cbChon.BackColor = System.Drawing.Color.Transparent
        Me.cbChon.Location = New System.Drawing.Point(308, 78)
        Me.cbChon.Name = "cbChon"
        Me.cbChon.Size = New System.Drawing.Size(100, 20)
        Me.cbChon.TabIndex = 152
        Me.cbChon.Text = "Chọn tất cả"
        Me.cbChon.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(592, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 23)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "Không tính độ dài tiền tố"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabChuaTotNghiep
        '
        Me.TabChuaTotNghiep.Controls.Add(Me.grcNoTotNghiep)
        Me.TabChuaTotNghiep.Controls.Add(Me.cmbNam_hoc_CTN)
        Me.TabChuaTotNghiep.Controls.Add(Me.Label5)
        Me.TabChuaTotNghiep.Controls.Add(Me.lblSV_CTN)
        Me.TabChuaTotNghiep.Controls.Add(Me.Label3)
        Me.TabChuaTotNghiep.Controls.Add(Me.trvLop2)
        Me.TabChuaTotNghiep.Location = New System.Drawing.Point(4, 22)
        Me.TabChuaTotNghiep.Name = "TabChuaTotNghiep"
        Me.TabChuaTotNghiep.Padding = New System.Windows.Forms.Padding(3)
        Me.TabChuaTotNghiep.Size = New System.Drawing.Size(784, 469)
        Me.TabChuaTotNghiep.TabIndex = 1
        Me.TabChuaTotNghiep.Text = "Chưa đủ điều kiện tốt nghiệp"
        Me.TabChuaTotNghiep.UseVisualStyleBackColor = True
        '
        'grcNoTotNghiep
        '
        Me.grcNoTotNghiep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcNoTotNghiep.Location = New System.Drawing.Point(255, 28)
        Me.grcNoTotNghiep.MainView = Me.grvNoTotNghiep
        Me.grcNoTotNghiep.Name = "grcNoTotNghiep"
        Me.grcNoTotNghiep.Size = New System.Drawing.Size(529, 471)
        Me.grcNoTotNghiep.TabIndex = 119
        Me.grcNoTotNghiep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvNoTotNghiep})
        '
        'grvNoTotNghiep
        '
        Me.grvNoTotNghiep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn14})
        Me.grvNoTotNghiep.GridControl = Me.grcNoTotNghiep
        Me.grvNoTotNghiep.Name = "grvNoTotNghiep"
        Me.grvNoTotNghiep.OptionsSelection.MultiSelect = True
        Me.grvNoTotNghiep.OptionsView.ShowAutoFilterRow = True
        Me.grvNoTotNghiep.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Mã sinh viên"
        Me.GridColumn7.FieldName = "Ma_sv1"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 59
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Họ tên"
        Me.GridColumn8.FieldName = "Ho_ten1"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 131
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ngày sinh"
        Me.GridColumn9.FieldName = "Ngay_sinh1"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 68
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tên lớp"
        Me.GridColumn10.FieldName = "Ten_lop1"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 59
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "TBC tích lũy"
        Me.GridColumn11.FieldName = "TBCHT1"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 66
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "TBCHT hệ 10"
        Me.GridColumn12.FieldName = "TBCHT10"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        Me.GridColumn12.Width = 74
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Lý do"
        Me.GridColumn14.FieldName = "Ly_do"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        Me.GridColumn14.Width = 51
        '
        'cmbNam_hoc_CTN
        '
        Me.cmbNam_hoc_CTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc_CTN.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNam_hoc_CTN.Location = New System.Drawing.Point(329, 3)
        Me.cmbNam_hoc_CTN.Name = "cmbNam_hoc_CTN"
        Me.cmbNam_hoc_CTN.Size = New System.Drawing.Size(108, 24)
        Me.cmbNam_hoc_CTN.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSV_CTN
        '
        Me.lblSV_CTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSV_CTN.BackColor = System.Drawing.Color.Transparent
        Me.lblSV_CTN.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSV_CTN.Location = New System.Drawing.Point(736, 2)
        Me.lblSV_CTN.Name = "lblSV_CTN"
        Me.lblSV_CTN.Size = New System.Drawing.Size(40, 23)
        Me.lblSV_CTN.TabIndex = 109
        Me.lblSV_CTN.Text = "0"
        Me.lblSV_CTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'trvLop2
        '
        Me.trvLop2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop2.BackColor = System.Drawing.Color.Transparent
        Me.trvLop2.dtLop = Nothing
        Me.trvLop2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop2.Location = New System.Drawing.Point(3, 2)
        Me.trvLop2.Name = "trvLop2"
        Me.trvLop2.Size = New System.Drawing.Size(258, 500)
        Me.trvLop2.TabIndex = 104
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_totnghiep), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_BD_toankhoa), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_QD_totnghiep), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DS_nototnghiep), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnInBang_TN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdTongHop_XetTN)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_DS_totnghiep
        '
        Me.cmdPrint_DS_totnghiep.Caption = "Danh sách tốt nghiệp"
        Me.cmdPrint_DS_totnghiep.Id = 2
        Me.cmdPrint_DS_totnghiep.ImageIndex = 16
        Me.cmdPrint_DS_totnghiep.Name = "cmdPrint_DS_totnghiep"
        '
        'cmdPrint_BD_toankhoa
        '
        Me.cmdPrint_BD_toankhoa.Caption = "Bảng điểm toàn khóa liên thông"
        Me.cmdPrint_BD_toankhoa.Id = 0
        Me.cmdPrint_BD_toankhoa.ImageIndex = 16
        Me.cmdPrint_BD_toankhoa.Name = "cmdPrint_BD_toankhoa"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Bảng điểm toàn khóa chính quy"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.ImageIndex = 10
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'cmdPrint_QD_totnghiep
        '
        Me.cmdPrint_QD_totnghiep.Caption = "Giấy chứng nhận tốt nghiệp"
        Me.cmdPrint_QD_totnghiep.Id = 1
        Me.cmdPrint_QD_totnghiep.ImageIndex = 16
        Me.cmdPrint_QD_totnghiep.Name = "cmdPrint_QD_totnghiep"
        '
        'cmdPrint_DS_nototnghiep
        '
        Me.cmdPrint_DS_nototnghiep.Caption = "Danh sách nợ tốt nghiệp"
        Me.cmdPrint_DS_nototnghiep.Id = 3
        Me.cmdPrint_DS_nototnghiep.ImageIndex = 16
        Me.cmdPrint_DS_nototnghiep.Name = "cmdPrint_DS_nototnghiep"
        '
        'btnInBang_TN
        '
        Me.btnInBang_TN.Caption = "Bằng tốt nghiệp"
        Me.btnInBang_TN.Id = 5
        Me.btnInBang_TN.ImageIndex = 11
        Me.btnInBang_TN.Name = "btnInBang_TN"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Bằng tốt nghiệp theo phôi"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "In bảng điểm theo lớp"
        Me.BarButtonItem3.Id = 6
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Danh sách cấp phát bằng"
        Me.BarButtonItem4.Id = 8
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'cmdTongHop_XetTN
        '
        Me.cmdTongHop_XetTN.Caption = "Báo cáo tổng hợp tình hình xét tốt nghiệp"
        Me.cmdTongHop_XetTN.Id = 9
        Me.cmdTongHop_XetTN.Name = "cmdTongHop_XetTN"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_BD_toankhoa, Me.cmdPrint_QD_totnghiep, Me.cmdPrint_DS_totnghiep, Me.cmdPrint_DS_nototnghiep, Me.BarButtonItem1, Me.btnInBang_TN, Me.BarButtonItem3, Me.BarButtonItem2, Me.BarButtonItem4, Me.cmdTongHop_XetTN})
        Me.BarManager1.MaxItemId = 10
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(792, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(792, 0)
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
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(675, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 174
        Me.cmdClose.Text = "Thoát"
        '
        'cmdXetTN
        '
        Me.cmdXetTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdXetTN.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXetTN.Appearance.Options.UseFont = True
        Me.cmdXetTN.ImageIndex = 15
        Me.cmdXetTN.ImageList = Me.ImgMain
        Me.cmdXetTN.Location = New System.Drawing.Point(106, 533)
        Me.cmdXetTN.Name = "cmdXetTN"
        Me.cmdXetTN.Size = New System.Drawing.Size(115, 30)
        Me.cmdXetTN.TabIndex = 173
        Me.cmdXetTN.Text = "Xét tốt nghiệp"
        '
        'cmdLapSB
        '
        Me.cmdLapSB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLapSB.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLapSB.Appearance.Options.UseFont = True
        Me.cmdLapSB.ImageIndex = 3
        Me.cmdLapSB.ImageList = Me.ImgMain
        Me.cmdLapSB.Location = New System.Drawing.Point(223, 533)
        Me.cmdLapSB.Name = "cmdLapSB"
        Me.cmdLapSB.Size = New System.Drawing.Size(115, 30)
        Me.cmdLapSB.TabIndex = 172
        Me.cmdLapSB.Text = "Lập số văn bằng"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(554, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(115, 30)
        Me.cmdExport.TabIndex = 171
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
        Me.cmdPrintList.Location = New System.Drawing.Point(439, 533)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(113, 30)
        Me.cmdPrintList.TabIndex = 170
        Me.cmdPrintList.Text = "In danh sách"
        '
        'lblXet_TN
        '
        Me.lblXet_TN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXet_TN.BackColor = System.Drawing.Color.Transparent
        Me.lblXet_TN.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXet_TN.Location = New System.Drawing.Point(119, -6)
        Me.lblXet_TN.Name = "lblXet_TN"
        Me.lblXet_TN.Size = New System.Drawing.Size(550, 42)
        Me.lblXet_TN.TabIndex = 179
        Me.lblXet_TN.Text = "XÉT TỐT NGHIỆP"
        Me.lblXet_TN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSave_QD
        '
        Me.cmdSave_QD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave_QD.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave_QD.Appearance.Options.UseFont = True
        Me.cmdSave_QD.ImageIndex = 11
        Me.cmdSave_QD.ImageList = Me.ImgMain
        Me.cmdSave_QD.Location = New System.Drawing.Point(339, 534)
        Me.cmdSave_QD.Name = "cmdSave_QD"
        Me.cmdSave_QD.Size = New System.Drawing.Size(98, 30)
        Me.cmdSave_QD.TabIndex = 174
        Me.cmdSave_QD.Text = "Cập nhật QĐ"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageIndex = 15
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(516, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 30)
        Me.SimpleButton1.TabIndex = 184
        Me.SimpleButton1.Text = "Cập nhập vào lần 1"
        Me.SimpleButton1.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageIndex = 15
        Me.SimpleButton2.ImageList = Me.ImgMain
        Me.SimpleButton2.Location = New System.Drawing.Point(659, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(129, 30)
        Me.SimpleButton2.TabIndex = 185
        Me.SimpleButton2.Text = "Cập nhật vào lần 2"
        Me.SimpleButton2.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageIndex = 8
        Me.SimpleButton3.ImageList = Me.ImgMain
        Me.SimpleButton3.Location = New System.Drawing.Point(4, 534)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(100, 30)
        Me.SimpleButton3.TabIndex = 190
        Me.SimpleButton3.Text = "Chốt DS TN"
        '
        'frmESS_XetTotNghiep
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdSave_QD)
        Me.Controls.Add(Me.lblXet_TN)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdXetTN)
        Me.Controls.Add(Me.cmdLapSB)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_XetTotNghiep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XET TOT NGHIEP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabTotNghiep.ResumeLayout(False)
        Me.TabTotNghiep.PerformLayout()
        CType(Me.grcTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChuaTotNghiep.ResumeLayout(False)
        CType(Me.grcNoTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvNoTotNghiep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabTotNghiep As System.Windows.Forms.TabPage
    Friend WithEvents TabChuaTotNghiep As System.Windows.Forms.TabPage
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSV_CTN As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents trvLop2 As ESSMarkMan.TreeViewLop
    Friend WithEvents txtTu_so_so_hieu As System.Windows.Forms.TextBox
    Friend WithEvents cmbLan_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents trvLop1 As ESSMarkMan.TreeViewLop
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc_CTN As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnLap_so_SoHieu As System.Windows.Forms.Button
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_BD_toankhoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_QD_totnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DS_totnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdXetTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLapSB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdPrint_DS_nototnghiep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grcTotNghiep As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvTotNghiep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBCHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PhanTram_ThiLai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_tin_chi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcNoTotNghiep As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvNoTotNghiep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblXet_TN As System.Windows.Forms.Label
    Friend WithEvents btnInBang_TN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Chon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbChon As System.Windows.Forms.CheckBox
    Friend WithEvents txtSo_QD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dtmNgay_QD As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNgay_sinh As System.Windows.Forms.Label
    Friend WithEvents cmdSave_QD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents So_QD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ColSoHieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSo_vao_so As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTienTo_SoHieu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTien_to_SoVaoSo As System.Windows.Forms.TextBox
    Friend WithEvents btnSave_SoVaoSo As System.Windows.Forms.Button
    Friend WithEvents txtTu_So_SoVaoSo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDo_dai_So_van_bang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDo_dai_So_hieu As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Lock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTongHop_XetTN As DevExpress.XtraBars.BarButtonItem
End Class
