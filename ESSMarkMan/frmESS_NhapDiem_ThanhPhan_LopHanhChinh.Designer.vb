<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiem_ThanhPhan_LopHanhChinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiem_ThanhPhan_LopHanhChinh))
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.Trang_thai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.chkDefault = New System.Windows.Forms.CheckBox
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbNam_hoc_TP = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky_TP = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDiemThanhPhan = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_BDT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_PhieuDanhGia = New DevExpress.XtraBars.BarButtonItem
        Me.btnBangDiemThanhPhan = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdPrint_DSThi2 = New DevExpress.XtraBars.BarButtonItem
        Me.chkUpdate = New System.Windows.Forms.CheckBox
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.cmdHelp = New DevExpress.XtraEditors.SimpleButton
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox
        Me.lblThanh_phan = New System.Windows.Forms.Label
        Me.cmdDongBo = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox
        Me.lblCot_diem = New System.Windows.Forms.Label
        Me.cmbMa_sv = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.cmdKhoa_Diem = New DevExpress.XtraEditors.SimpleButton
        Me.btn_Cap_nhap_ly_do = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grdViewDiem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Trang_thai, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.grdViewDiem.Location = New System.Drawing.Point(265, 142)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(824, 383)
        Me.grdViewDiem.TabIndex = 83
        '
        'Trang_thai
        '
        Me.Trang_thai.HeaderText = "Trạng thái"
        Me.Trang_thai.Name = "Trang_thai"
        Me.Trang_thai.Width = 50
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
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ten_lop"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(386, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(454, 58)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(85, 24)
        Me.cmbNam_hoc.TabIndex = 82
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(262, 58)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 79
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(322, 58)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 80
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(539, 58)
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
        Me.cmbID_mon.Location = New System.Drawing.Point(611, 58)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(473, 24)
        Me.cmbID_mon.TabIndex = 78
        '
        'chkDefault
        '
        Me.chkDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDefault.AutoSize = True
        Me.chkDefault.BackColor = System.Drawing.Color.Transparent
        Me.chkDefault.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefault.Location = New System.Drawing.Point(812, 90)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(267, 19)
        Me.chkDefault.TabIndex = 86
        Me.chkDefault.Text = "Chọn mặc định điểm chuyên cần ( Điểm 10)"
        Me.chkDefault.UseVisualStyleBackColor = False
        Me.chkDefault.Visible = False
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(-1, 30)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(261, 495)
        Me.TreeViewLop.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(441, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Điểm của Năm học:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc_TP
        '
        Me.cmbNam_hoc_TP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc_TP.Location = New System.Drawing.Point(577, 88)
        Me.cmbNam_hoc_TP.Name = "cmbNam_hoc_TP"
        Me.cmbNam_hoc_TP.Size = New System.Drawing.Size(85, 24)
        Me.cmbNam_hoc_TP.TabIndex = 91
        '
        'cmbHoc_ky_TP
        '
        Me.cmbHoc_ky_TP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky_TP.Location = New System.Drawing.Point(377, 88)
        Me.cmbHoc_ky_TP.Name = "cmbHoc_ky_TP"
        Me.cmbHoc_ky_TP.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky_TP.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Điểm của Học kỳ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.cmdClose.Location = New System.Drawing.Point(983, 531)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(106, 30)
        Me.cmdClose.TabIndex = 176
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(862, 531)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(118, 30)
        Me.cmdExport.TabIndex = 176
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdDiemThanhPhan
        '
        Me.cmdDiemThanhPhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDiemThanhPhan.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiemThanhPhan.Appearance.Options.UseFont = True
        Me.cmdDiemThanhPhan.ImageIndex = 8
        Me.cmdDiemThanhPhan.ImageList = Me.ImgMain
        Me.cmdDiemThanhPhan.Location = New System.Drawing.Point(516, 531)
        Me.cmdDiemThanhPhan.Name = "cmdDiemThanhPhan"
        Me.cmdDiemThanhPhan.Size = New System.Drawing.Size(118, 30)
        Me.cmdDiemThanhPhan.TabIndex = 176
        Me.cmdDiemThanhPhan.Text = "Thành phần điểm"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(414, 531)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(97, 30)
        Me.cmdDelete.TabIndex = 176
        Me.cmdDelete.Text = "Xóa"
        Me.cmdDelete.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(405, 531)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(107, 30)
        Me.cmdSave.TabIndex = 176
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
        Me.cmdPrintList.Location = New System.Drawing.Point(741, 531)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrintList.TabIndex = 265
        Me.cmdPrintList.Text = "In danh sách"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_BDT), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_PhieuDanhGia), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBangDiemThanhPhan)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_BDT
        '
        Me.cmdPrint_BDT.Caption = "Bảng điểm thành phần"
        Me.cmdPrint_BDT.Id = 0
        Me.cmdPrint_BDT.ImageIndex = 16
        Me.cmdPrint_BDT.Name = "cmdPrint_BDT"
        Me.cmdPrint_BDT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmdPrint_PhieuDanhGia
        '
        Me.cmdPrint_PhieuDanhGia.Caption = "Phiếu đánh giá điểm học phần"
        Me.cmdPrint_PhieuDanhGia.Id = 13
        Me.cmdPrint_PhieuDanhGia.ImageIndex = 16
        Me.cmdPrint_PhieuDanhGia.Name = "cmdPrint_PhieuDanhGia"
        '
        'btnBangDiemThanhPhan
        '
        Me.btnBangDiemThanhPhan.Caption = "Bảng điểm thành phần ( thông tư 09 )"
        Me.btnBangDiemThanhPhan.Id = 15
        Me.btnBangDiemThanhPhan.ImageIndex = 16
        Me.btnBangDiemThanhPhan.Name = "btnBangDiemThanhPhan"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_BDT, Me.cmdPrint_PhieuDanhGia, Me.cmdPrint_DSThi2, Me.btnBangDiemThanhPhan})
        Me.BarManager1.MaxItemId = 16
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1092, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 566)
        Me.BarDockControl2.Size = New System.Drawing.Size(1092, 0)
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
        Me.BarDockControl4.Location = New System.Drawing.Point(1092, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 566)
        '
        'cmdPrint_DSThi2
        '
        Me.cmdPrint_DSThi2.Caption = "Danh sách thi (Vấn đáp)"
        Me.cmdPrint_DSThi2.Id = 14
        Me.cmdPrint_DSThi2.ImageIndex = 16
        Me.cmdPrint_DSThi2.Name = "cmdPrint_DSThi2"
        '
        'chkUpdate
        '
        Me.chkUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUpdate.BackColor = System.Drawing.Color.Transparent
        Me.chkUpdate.Location = New System.Drawing.Point(265, 121)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(814, 19)
        Me.chkUpdate.TabIndex = 270
        Me.chkUpdate.Text = "Chọn để cập nhật điểm của Học kỳ và Năm học chọn"
        Me.chkUpdate.UseVisualStyleBackColor = False
        Me.chkUpdate.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ImageIndex = 10
        Me.cmdUpdate.ImageList = Me.ImgMain
        Me.cmdUpdate.Location = New System.Drawing.Point(411, 534)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(97, 23)
        Me.cmdUpdate.TabIndex = 271
        Me.cmdUpdate.Text = "Cập nhật điểm"
        Me.cmdUpdate.Visible = False
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Appearance.Options.UseFont = True
        Me.cmdHelp.ImageIndex = 20
        Me.cmdHelp.ImageList = Me.ImgMain
        Me.cmdHelp.Location = New System.Drawing.Point(998, 30)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(87, 24)
        Me.cmdHelp.TabIndex = 286
        Me.cmdHelp.Text = "Hướng dẫn"
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(877, 2)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(114, 24)
        Me.cmbThanh_phan.TabIndex = 284
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.lblThanh_phan.Location = New System.Drawing.Point(749, 3)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 285
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
        Me.cmdDongBo.Location = New System.Drawing.Point(999, 3)
        Me.cmdDongBo.Name = "cmdDongBo"
        Me.cmdDongBo.Size = New System.Drawing.Size(87, 24)
        Me.cmdDongBo.TabIndex = 283
        Me.cmdDongBo.Text = "Đồng bộ"
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(877, 30)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(114, 24)
        Me.cmbCot_diem.TabIndex = 281
        '
        'lblCot_diem
        '
        Me.lblCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(714, 34)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(155, 17)
        Me.lblCot_diem.TabIndex = 282
        Me.lblCot_diem.Text = "Chọn cột dữ liệu điểm:"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMa_sv
        '
        Me.cmbMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMa_sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_sv.Location = New System.Drawing.Point(627, 3)
        Me.cmbMa_sv.Name = "cmbMa_sv"
        Me.cmbMa_sv.Size = New System.Drawing.Size(114, 24)
        Me.cmbMa_sv.TabIndex = 279
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(569, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 280
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
        Me.cmdBrowse.Location = New System.Drawing.Point(494, 3)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(67, 24)
        Me.cmdBrowse.TabIndex = 278
        Me.cmdBrowse.Text = "Open"
        '
        'cmbChonFile
        '
        Me.cmbChonFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(379, 3)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 24)
        Me.cmbChonFile.TabIndex = 276
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(279, 3)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 277
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdKhoa_Diem
        '
        Me.cmdKhoa_Diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdKhoa_Diem.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKhoa_Diem.Appearance.Options.UseFont = True
        Me.cmdKhoa_Diem.ImageIndex = 22
        Me.cmdKhoa_Diem.ImageList = Me.ImgMain
        Me.cmdKhoa_Diem.Location = New System.Drawing.Point(637, 531)
        Me.cmdKhoa_Diem.Name = "cmdKhoa_Diem"
        Me.cmdKhoa_Diem.Size = New System.Drawing.Size(101, 30)
        Me.cmdKhoa_Diem.TabIndex = 291
        Me.cmdKhoa_Diem.Text = "Khóa điểm"
        '
        'btn_Cap_nhap_ly_do
        '
        Me.btn_Cap_nhap_ly_do.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cap_nhap_ly_do.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cap_nhap_ly_do.Appearance.Options.UseFont = True
        Me.btn_Cap_nhap_ly_do.Image = Global.ESSMarkMan.My.Resources.Resources.QuaTrinhDiem
        Me.btn_Cap_nhap_ly_do.ImageIndex = 10
        Me.btn_Cap_nhap_ly_do.Location = New System.Drawing.Point(241, 531)
        Me.btn_Cap_nhap_ly_do.Name = "btn_Cap_nhap_ly_do"
        Me.btn_Cap_nhap_ly_do.Size = New System.Drawing.Size(160, 30)
        Me.btn_Cap_nhap_ly_do.TabIndex = 176
        Me.btn_Cap_nhap_ly_do.Text = "Cập nhập ghi chú thi"
        '
        'frmESS_NhapDiem_ThanhPhan_LopHanhChinh
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1092, 566)
        Me.Controls.Add(Me.cmdKhoa_Diem)
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
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmdDiemThanhPhan)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNam_hoc_TP)
        Me.Controls.Add(Me.cmbHoc_ky_TP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.btn_Cap_nhap_ly_do)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_NhapDiem_ThanhPhan_LopHanhChinh"
        Me.Text = "NHAP DIEM THANH PHAN LOP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents Trang_thai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkDefault As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc_TP As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky_TP As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDiemThanhPhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_BDT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_PhieuDanhGia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_DSThi2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents cmdKhoa_Diem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBangDiemThanhPhan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Cap_nhap_ly_do As DevExpress.XtraEditors.SimpleButton
End Class
