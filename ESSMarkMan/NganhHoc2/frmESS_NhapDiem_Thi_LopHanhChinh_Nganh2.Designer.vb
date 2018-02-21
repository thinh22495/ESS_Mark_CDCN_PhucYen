<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiem_Thi_LopHanhChinh_Nganh2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiem_Thi_LopHanhChinh_Nganh2))
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_ngoai_ngu = New System.Windows.Forms.ComboBox
        Me.cmbKy_hieu = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbNam_hoc_Thi = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky_Thi = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdGhiChu = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_BDT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DSThi = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_DSThi2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.chkUpdate = New System.Windows.Forms.CheckBox
        Me.cmdHelp = New DevExpress.XtraEditors.SimpleButton
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox
        Me.lblThanh_phan = New System.Windows.Forms.Label
        Me.cmdDongBo = New DevExpress.XtraEditors.SimpleButton
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox
        Me.lblCot_diem = New System.Windows.Forms.Label
        Me.cmbMa_sv = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.cmdImport = New DevExpress.XtraEditors.SimpleButton
        Me.TreeViewChuyenNganh_Nganh21 = New ESSMarkMan.TreeViewChuyenNganh_Nganh2
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(696, 65)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(233, 24)
        Me.cmbID_mon.TabIndex = 91
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(624, 65)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 90
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(325, 65)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(56, 24)
        Me.cmbHoc_ky.TabIndex = 93
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(265, 65)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 92
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(448, 65)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(72, 24)
        Me.cmbNam_hoc.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(381, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(520, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Location = New System.Drawing.Point(575, 65)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(49, 24)
        Me.cmbLan_thi.TabIndex = 97
        '
        'chkNot_show_all
        '
        Me.chkNot_show_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNot_show_all.BackColor = System.Drawing.Color.Transparent
        Me.chkNot_show_all.Checked = True
        Me.chkNot_show_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNot_show_all.Location = New System.Drawing.Point(266, 149)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(653, 19)
        Me.chkNot_show_all.TabIndex = 98
        Me.chkNot_show_all.Text = "Khi nhập điểm thi từ lần 2 trở đi chỉ hiển thị những sinh viên có điểm thi <5"
        Me.chkNot_show_all.UseVisualStyleBackColor = False
        '
        'grdViewDiem
        '
        Me.grdViewDiem.AllowUserToAddRows = False
        Me.grdViewDiem.AllowUserToDeleteRows = False
        Me.grdViewDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 197)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.ShowCellErrors = False
        Me.grdViewDiem.ShowCellToolTips = False
        Me.grdViewDiem.ShowRowErrors = False
        Me.grdViewDiem.Size = New System.Drawing.Size(663, 330)
        Me.grdViewDiem.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(775, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Ngoại ngữ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_ngoai_ngu
        '
        Me.cmbID_ngoai_ngu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_ngoai_ngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_ngoai_ngu.FormattingEnabled = True
        Me.cmbID_ngoai_ngu.Items.AddRange(New Object() {"Tiếng Anh", "Tiếng Nga", "Tiếng Pháp", "Tiếng Trung", ""})
        Me.cmbID_ngoai_ngu.Location = New System.Drawing.Point(852, 96)
        Me.cmbID_ngoai_ngu.Name = "cmbID_ngoai_ngu"
        Me.cmbID_ngoai_ngu.Size = New System.Drawing.Size(77, 24)
        Me.cmbID_ngoai_ngu.TabIndex = 104
        '
        'cmbKy_hieu
        '
        Me.cmbKy_hieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKy_hieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu.FormattingEnabled = True
        Me.cmbKy_hieu.Items.AddRange(New Object() {"Từ điểm C trở xuống", "Những sinh viên thiếu điểm TP", "Những sinh viên thiếu điểm Thi", "Những sinh viên không tính điểm thành phần vào TBCHP", "Những sinh viên bảo lưu"})
        Me.cmbKy_hieu.Location = New System.Drawing.Point(663, 124)
        Me.cmbKy_hieu.Name = "cmbKy_hieu"
        Me.cmbKy_hieu.Size = New System.Drawing.Size(266, 24)
        Me.cmbKy_hieu.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(506, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Hiển thị sinh viên điểm:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(450, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 24)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Điểm của Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc_Thi
        '
        Me.cmbNam_hoc_Thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc_Thi.Location = New System.Drawing.Point(589, 95)
        Me.cmbNam_hoc_Thi.Name = "cmbNam_hoc_Thi"
        Me.cmbNam_hoc_Thi.Size = New System.Drawing.Size(84, 24)
        Me.cmbNam_hoc_Thi.TabIndex = 111
        '
        'cmbHoc_ky_Thi
        '
        Me.cmbHoc_ky_Thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky_Thi.Location = New System.Drawing.Point(386, 95)
        Me.cmbHoc_ky_Thi.Name = "cmbHoc_ky_Thi"
        Me.cmbHoc_ky_Thi.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky_Thi.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Điểm của Học kỳ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdGhiChu
        '
        Me.cmdGhiChu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGhiChu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGhiChu.Appearance.Options.UseFont = True
        Me.cmdGhiChu.ImageIndex = 8
        Me.cmdGhiChu.ImageList = Me.ImgMain
        Me.cmdGhiChu.Location = New System.Drawing.Point(466, 533)
        Me.cmdGhiChu.Name = "cmdGhiChu"
        Me.cmdGhiChu.Size = New System.Drawing.Size(152, 30)
        Me.cmdGhiChu.TabIndex = 186
        Me.cmdGhiChu.Text = "Ký hiệu ghi chú điểm"
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
        Me.cmdDelete.Location = New System.Drawing.Point(371, 536)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(83, 24)
        Me.cmdDelete.TabIndex = 188
        Me.cmdDelete.Text = "Xóa tất cả"
        Me.cmdDelete.Visible = False
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(752, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(90, 30)
        Me.cmdExport.TabIndex = 187
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(850, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(77, 30)
        Me.cmdClose.TabIndex = 185
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(355, 533)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(108, 30)
        Me.cmdSave.TabIndex = 183
        Me.cmdSave.Text = "Lưu"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(626, 533)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrintList.TabIndex = 260
        Me.cmdPrintList.Text = "In danh sách"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_BDT), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSThi), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_DSThi2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_BDT
        '
        Me.cmdPrint_BDT.Caption = "Bảng điểm thi"
        Me.cmdPrint_BDT.Id = 0
        Me.cmdPrint_BDT.ImageIndex = 16
        Me.cmdPrint_BDT.Name = "cmdPrint_BDT"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_BDT, Me.cmdPrint_DSThi, Me.cmdPrint_DSThi2})
        Me.BarManager1.MaxItemId = 15
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(931, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(931, 0)
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
        Me.BarDockControl4.Location = New System.Drawing.Point(931, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ImageIndex = 10
        Me.cmdUpdate.ImageList = Me.ImgMain
        Me.cmdUpdate.Location = New System.Drawing.Point(355, 533)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(108, 30)
        Me.cmdUpdate.TabIndex = 183
        Me.cmdUpdate.Text = "Cập nhật điểm"
        '
        'chkUpdate
        '
        Me.chkUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUpdate.BackColor = System.Drawing.Color.Transparent
        Me.chkUpdate.Location = New System.Drawing.Point(266, 172)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(653, 19)
        Me.chkUpdate.TabIndex = 98
        Me.chkUpdate.Text = "Chọn để cập nhật điểm của Học kỳ và Năm học chọn"
        Me.chkUpdate.UseVisualStyleBackColor = False
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Appearance.Options.UseFont = True
        Me.cmdHelp.ImageIndex = 20
        Me.cmdHelp.ImageList = Me.ImgMain
        Me.cmdHelp.Location = New System.Drawing.Point(841, 33)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(88, 24)
        Me.cmdHelp.TabIndex = 275
        Me.cmdHelp.Text = "Hướng dẫn"
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(728, 3)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(107, 24)
        Me.cmbThanh_phan.TabIndex = 273
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.lblThanh_phan.Location = New System.Drawing.Point(608, 3)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 274
        Me.lblThanh_phan.Text = "Thành phần môn:"
        Me.lblThanh_phan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDongBo
        '
        Me.cmdDongBo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDongBo.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDongBo.Appearance.Options.UseFont = True
        Me.cmdDongBo.ImageIndex = 1
        Me.cmdDongBo.ImageList = Me.ImgMain
        Me.cmdDongBo.Location = New System.Drawing.Point(841, 3)
        Me.cmdDongBo.Name = "cmdDongBo"
        Me.cmdDongBo.Size = New System.Drawing.Size(88, 24)
        Me.cmdDongBo.TabIndex = 272
        Me.cmdDongBo.Text = "Đồng bộ"
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(728, 33)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(107, 24)
        Me.cmbCot_diem.TabIndex = 270
        '
        'lblCot_diem
        '
        Me.lblCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(573, 37)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(155, 17)
        Me.lblCot_diem.TabIndex = 271
        Me.lblCot_diem.Text = "Chọn cột dữ liệu điểm:"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMa_sv
        '
        Me.cmbMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMa_sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_sv.Location = New System.Drawing.Point(494, 3)
        Me.cmbMa_sv.Name = "cmbMa_sv"
        Me.cmbMa_sv.Size = New System.Drawing.Size(114, 24)
        Me.cmbMa_sv.TabIndex = 268
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(444, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 269
        Me.Label10.Text = "Mã sv:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBrowse.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Appearance.Options.UseFont = True
        Me.cmdBrowse.ImageIndex = 10
        Me.cmdBrowse.ImageList = Me.ImgMain
        Me.cmdBrowse.Location = New System.Drawing.Point(382, 3)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 24)
        Me.cmdBrowse.TabIndex = 267
        Me.cmdBrowse.Text = "Open"
        '
        'cmbChonFile
        '
        Me.cmbChonFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(270, 3)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 24)
        Me.cmbChonFile.TabIndex = 265
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(178, 3)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 266
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdImport
        '
        Me.cmdImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.Appearance.Options.UseFont = True
        Me.cmdImport.ImageIndex = 10
        Me.cmdImport.ImageList = Me.ImgMain
        Me.cmdImport.Location = New System.Drawing.Point(382, 33)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(62, 24)
        Me.cmdImport.TabIndex = 280
        Me.cmdImport.Text = "Import"
        '
        'TreeViewChuyenNganh_Nganh21
        '
        Me.TreeViewChuyenNganh_Nganh21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewChuyenNganh_Nganh21.dtLop = Nothing
        Me.TreeViewChuyenNganh_Nganh21.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewChuyenNganh_Nganh21.Location = New System.Drawing.Point(-3, 22)
        Me.TreeViewChuyenNganh_Nganh21.Name = "TreeViewChuyenNganh_Nganh21"
        Me.TreeViewChuyenNganh_Nganh21.Size = New System.Drawing.Size(266, 551)
        Me.TreeViewChuyenNganh_Nganh21.TabIndex = 297
        '
        'frmESS_NhapDiem_Thi_LopHanhChinh_Nganh2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(931, 566)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmbThanh_phan)
        Me.Controls.Add(Me.lblThanh_phan)
        Me.Controls.Add(Me.cmdDongBo)
        Me.Controls.Add(Me.cmbCot_diem)
        Me.Controls.Add(Me.lblCot_diem)
        Me.Controls.Add(Me.cmbMa_sv)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.cmbChonFile)
        Me.Controls.Add(Me.lblBang_tinh)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmdGhiChu)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmbNam_hoc_Thi)
        Me.Controls.Add(Me.cmbHoc_ky_Thi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbKy_hieu)
        Me.Controls.Add(Me.cmbID_ngoai_ngu)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.TreeViewChuyenNganh_Nganh21)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_NhapDiem_Thi_LopHanhChinh_Nganh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHAP DIEM THI THEO NGANH 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_ngoai_ngu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKy_hieu As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc_Thi As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky_Thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdGhiChu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_BDT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSThi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSThi2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents cmdHelp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbThanh_phan As System.Windows.Forms.ComboBox
    Friend WithEvents lblThanh_phan As System.Windows.Forms.Label
    Friend WithEvents cmdDongBo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents cmbMa_sv As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeViewChuyenNganh_Nganh21 As ESSMarkMan.TreeViewChuyenNganh_Nganh2
End Class
