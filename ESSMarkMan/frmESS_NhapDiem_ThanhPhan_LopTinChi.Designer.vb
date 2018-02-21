<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiem_ThanhPhan_LopTinChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiem_ThanhPhan_LopTinChi))
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.Trang_thai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.chkDefault = New System.Windows.Forms.CheckBox
        Me.trvLopTinChi = New ESSMarkMan.TreeViewLopTinChi
        Me.cmdDiemThanhPhan = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDongBo = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox
        Me.lblCot_diem = New System.Windows.Forms.Label
        Me.cmbMa_sv = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox
        Me.lblThanh_phan = New System.Windows.Forms.Label
        Me.cmdHelp = New DevExpress.XtraEditors.SimpleButton
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.optDaDuyet = New System.Windows.Forms.CheckBox
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCap_nhap_ghi_chu = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 98)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(903, 429)
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
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.BackColor = System.Drawing.Color.Transparent
        Me.chkDefault.Location = New System.Drawing.Point(270, 100)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(303, 20)
        Me.chkDefault.TabIndex = 85
        Me.chkDefault.Text = "Chọn mặc định điểm chuyên cần ( Điểm 10)"
        Me.chkDefault.UseVisualStyleBackColor = False
        Me.chkDefault.Visible = False
        '
        'trvLopTinChi
        '
        Me.trvLopTinChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLopTinChi.BackColor = System.Drawing.Color.Transparent
        Me.trvLopTinChi.dsID_lop_tc = ""
        Me.trvLopTinChi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLopTinChi.ID_lop_tc = 0
        Me.trvLopTinChi.ID_mon = 0
        Me.trvLopTinChi.ID_mon_tc = 0
        Me.trvLopTinChi.ID_mon_tc_thi = 0
        Me.trvLopTinChi.Khoa_hoc = 0
        Me.trvLopTinChi.Location = New System.Drawing.Point(0, 34)
        Me.trvLopTinChi.Name = "trvLopTinChi"
        Me.trvLopTinChi.Size = New System.Drawing.Size(264, 531)
        Me.trvLopTinChi.TabIndex = 84
        Me.trvLopTinChi.Ten_he = ""
        Me.trvLopTinChi.Ten_lop_tc = ""
        Me.trvLopTinChi.Ten_mon = ""
        '
        'cmdDiemThanhPhan
        '
        Me.cmdDiemThanhPhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDiemThanhPhan.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiemThanhPhan.Appearance.Options.UseFont = True
        Me.cmdDiemThanhPhan.ImageIndex = 8
        Me.cmdDiemThanhPhan.ImageList = Me.ImgMain
        Me.cmdDiemThanhPhan.Location = New System.Drawing.Point(577, 533)
        Me.cmdDiemThanhPhan.Name = "cmdDiemThanhPhan"
        Me.cmdDiemThanhPhan.Size = New System.Drawing.Size(123, 30)
        Me.cmdDiemThanhPhan.TabIndex = 180
        Me.cmdDiemThanhPhan.Text = "Thành phần điểm"
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
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(706, 533)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrint.TabIndex = 181
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(830, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(118, 30)
        Me.cmdExport.TabIndex = 182
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(484, 533)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 30)
        Me.cmdSave.TabIndex = 177
        Me.cmdSave.Text = "Lưu điểm"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(495, 533)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(76, 30)
        Me.cmdDelete.TabIndex = 178
        Me.cmdDelete.Text = "Xóa"
        Me.cmdDelete.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(1049, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(118, 30)
        Me.cmdClose.TabIndex = 179
        Me.cmdClose.Text = "Thoát"
        '
        'cmdDongBo
        '
        Me.cmdDongBo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDongBo.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDongBo.Appearance.Options.UseFont = True
        Me.cmdDongBo.ImageIndex = 1
        Me.cmdDongBo.ImageList = Me.ImgMain
        Me.cmdDongBo.Location = New System.Drawing.Point(1078, 3)
        Me.cmdDongBo.Name = "cmdDongBo"
        Me.cmdDongBo.Size = New System.Drawing.Size(87, 24)
        Me.cmdDongBo.TabIndex = 233
        Me.cmdDongBo.Text = "Đồng bộ"
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(956, 30)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(114, 24)
        Me.cmbCot_diem.TabIndex = 231
        '
        'lblCot_diem
        '
        Me.lblCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(793, 34)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(155, 17)
        Me.lblCot_diem.TabIndex = 232
        Me.lblCot_diem.Text = "Chọn cột dữ liệu điểm:"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMa_sv
        '
        Me.cmbMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMa_sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_sv.Location = New System.Drawing.Point(706, 3)
        Me.cmbMa_sv.Name = "cmbMa_sv"
        Me.cmbMa_sv.Size = New System.Drawing.Size(114, 24)
        Me.cmbMa_sv.TabIndex = 229
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(648, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 230
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
        Me.cmdBrowse.Location = New System.Drawing.Point(573, 3)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(67, 24)
        Me.cmdBrowse.TabIndex = 228
        Me.cmdBrowse.Text = "Open"
        '
        'cmbChonFile
        '
        Me.cmbChonFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(458, 3)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 24)
        Me.cmbChonFile.TabIndex = 226
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(358, 3)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 227
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(956, 3)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(114, 24)
        Me.cmbThanh_phan.TabIndex = 234
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.lblThanh_phan.Location = New System.Drawing.Point(828, 3)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 235
        Me.lblThanh_phan.Text = "Thành phần môn:"
        Me.lblThanh_phan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Appearance.Options.UseFont = True
        Me.cmdHelp.ImageIndex = 20
        Me.cmdHelp.ImageList = Me.ImgMain
        Me.cmdHelp.Location = New System.Drawing.Point(1077, 30)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(87, 24)
        Me.cmdHelp.TabIndex = 236
        Me.cmdHelp.Text = "Hướng dẫn"
        '
        'cmdLock
        '
        Me.cmdLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLock.Appearance.Options.UseFont = True
        Me.cmdLock.ImageIndex = 22
        Me.cmdLock.ImageList = Me.ImgMain
        Me.cmdLock.Location = New System.Drawing.Point(955, 533)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(87, 30)
        Me.cmdLock.TabIndex = 237
        Me.cmdLock.Text = "Khóa điểm"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageIndex = 20
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(620, 30)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 24)
        Me.SimpleButton1.TabIndex = 238
        Me.SimpleButton1.Text = "Update ID_SV"
        Me.SimpleButton1.Visible = False
        '
        'optDaDuyet
        '
        Me.optDaDuyet.AutoSize = True
        Me.optDaDuyet.BackColor = System.Drawing.Color.Transparent
        Me.optDaDuyet.Checked = True
        Me.optDaDuyet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optDaDuyet.Location = New System.Drawing.Point(266, 74)
        Me.optDaDuyet.Name = "optDaDuyet"
        Me.optDaDuyet.Size = New System.Drawing.Size(198, 20)
        Me.optDaDuyet.TabIndex = 250
        Me.optDaDuyet.Text = "Chỉ hiển thị sv đã duyệt ĐK"
        Me.optDaDuyet.UseVisualStyleBackColor = False
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(982, 72)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(98, 24)
        Me.lblSo_sv.TabIndex = 253
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(882, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "Số sinh viên:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCap_nhap_ghi_chu
        '
        Me.btnCap_nhap_ghi_chu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCap_nhap_ghi_chu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCap_nhap_ghi_chu.Appearance.Options.UseFont = True
        Me.btnCap_nhap_ghi_chu.Image = Global.ESSMarkMan.My.Resources.Resources.QuaTrinhDiem
        Me.btnCap_nhap_ghi_chu.ImageIndex = 10
        Me.btnCap_nhap_ghi_chu.Location = New System.Drawing.Point(326, 533)
        Me.btnCap_nhap_ghi_chu.Name = "btnCap_nhap_ghi_chu"
        Me.btnCap_nhap_ghi_chu.Size = New System.Drawing.Size(152, 30)
        Me.btnCap_nhap_ghi_chu.TabIndex = 177
        Me.btnCap_nhap_ghi_chu.Text = "Cập nhập ghi chú thi"
        '
        'frmESS_NhapDiem_ThanhPhan_LopTinChi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1171, 566)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optDaDuyet)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.lblBang_tinh)
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
        Me.Controls.Add(Me.cmdDiemThanhPhan)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.btnCap_nhap_ghi_chu)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.trvLopTinChi)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_NhapDiem_ThanhPhan_LopTinChi"
        Me.Text = "NHAP DIEM THANH PHAN LOP TIN CHI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents trvLopTinChi As ESSMarkMan.TreeViewLopTinChi
    Friend WithEvents Trang_thai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkDefault As System.Windows.Forms.CheckBox
    Friend WithEvents cmdDiemThanhPhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdDongBo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents cmbMa_sv As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents cmbThanh_phan As System.Windows.Forms.ComboBox
    Friend WithEvents lblThanh_phan As System.Windows.Forms.Label
    Friend WithEvents cmdHelp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents optDaDuyet As System.Windows.Forms.CheckBox
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCap_nhap_ghi_chu As DevExpress.XtraEditors.SimpleButton
End Class
