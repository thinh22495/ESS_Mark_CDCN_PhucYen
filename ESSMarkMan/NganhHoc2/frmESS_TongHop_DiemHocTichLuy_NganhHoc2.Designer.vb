<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHop_DiemHocTichLuy_NganhHoc2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_TongHop_DiemHocTichLuy_NganhHoc2))
        Me.fgTongHopToanKhoa = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKho_giay = New System.Windows.Forms.ComboBox
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.optDiemSo = New System.Windows.Forms.RadioButton
        Me.optDiemChu = New System.Windows.Forms.RadioButton
        Me.chkGhi_chu = New System.Windows.Forms.CheckBox
        Me.optDiem10 = New System.Windows.Forms.RadioButton
        Me.chkMonhoc = New System.Windows.Forms.CheckBox
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdTong = New DevExpress.XtraEditors.SimpleButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDen_diem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTu_diem = New System.Windows.Forms.TextBox
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPhanLoai_Lop = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPhanLoai_Mon = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdPrint_BDT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint2 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPhanLoai = New DevExpress.XtraEditors.DropDownButton
        Me.TreeViewChuyenNganh_Nganh21 = New ESSMarkMan.TreeViewChuyenNganh_Nganh2
        CType(Me.fgTongHopToanKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgTongHopToanKhoa
        '
        Me.fgTongHopToanKhoa.AllowEditing = False
        Me.fgTongHopToanKhoa.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fgTongHopToanKhoa.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fgTongHopToanKhoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgTongHopToanKhoa.BackColor = System.Drawing.Color.White
        Me.fgTongHopToanKhoa.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.fgTongHopToanKhoa.Cols = New C1.Win.C1FlexGrid.ColumnCollection(10, 1, 0, 0, 0, 95, "")
        Me.fgTongHopToanKhoa.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fgTongHopToanKhoa.Location = New System.Drawing.Point(265, 4)
        Me.fgTongHopToanKhoa.Name = "fgTongHopToanKhoa"
        Me.fgTongHopToanKhoa.Rows.Count = 0
        Me.fgTongHopToanKhoa.Rows.Fixed = 0
        Me.fgTongHopToanKhoa.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopToanKhoa.Size = New System.Drawing.Size(529, 467)
        Me.fgTongHopToanKhoa.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopToanKhoa.Styles"))
        Me.fgTongHopToanKhoa.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(629, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Khổ giấy:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKho_giay
        '
        Me.cmbKho_giay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKho_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKho_giay.Items.AddRange(New Object() {"A4 dọc", "A4 ngang", "A3 dọc", "A3 ngang"})
        Me.cmbKho_giay.Location = New System.Drawing.Point(711, 477)
        Me.cmbKho_giay.Name = "cmbKho_giay"
        Me.cmbKho_giay.Size = New System.Drawing.Size(76, 24)
        Me.cmbKho_giay.TabIndex = 116
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'optDiemSo
        '
        Me.optDiemSo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optDiemSo.AutoSize = True
        Me.optDiemSo.BackColor = System.Drawing.Color.Transparent
        Me.optDiemSo.Location = New System.Drawing.Point(402, 479)
        Me.optDiemSo.Name = "optDiemSo"
        Me.optDiemSo.Size = New System.Drawing.Size(126, 20)
        Me.optDiemSo.TabIndex = 118
        Me.optDiemSo.Text = "Hiển thị điểm số"
        Me.optDiemSo.UseVisualStyleBackColor = False
        '
        'optDiemChu
        '
        Me.optDiemChu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optDiemChu.AutoSize = True
        Me.optDiemChu.BackColor = System.Drawing.Color.Transparent
        Me.optDiemChu.Checked = True
        Me.optDiemChu.Location = New System.Drawing.Point(267, 479)
        Me.optDiemChu.Name = "optDiemChu"
        Me.optDiemChu.Size = New System.Drawing.Size(135, 20)
        Me.optDiemChu.TabIndex = 117
        Me.optDiemChu.TabStop = True
        Me.optDiemChu.Text = "Hiển thị điểm chữ"
        Me.optDiemChu.UseVisualStyleBackColor = False
        '
        'chkGhi_chu
        '
        Me.chkGhi_chu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkGhi_chu.AutoSize = True
        Me.chkGhi_chu.BackColor = System.Drawing.Color.Transparent
        Me.chkGhi_chu.Location = New System.Drawing.Point(629, 504)
        Me.chkGhi_chu.Name = "chkGhi_chu"
        Me.chkGhi_chu.Size = New System.Drawing.Size(158, 20)
        Me.chkGhi_chu.TabIndex = 120
        Me.chkGhi_chu.Text = "Hiển thị ghi chú điểm"
        Me.chkGhi_chu.UseVisualStyleBackColor = False
        '
        'optDiem10
        '
        Me.optDiem10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optDiem10.AutoSize = True
        Me.optDiem10.BackColor = System.Drawing.Color.Transparent
        Me.optDiem10.Location = New System.Drawing.Point(267, 504)
        Me.optDiem10.Name = "optDiem10"
        Me.optDiem10.Size = New System.Drawing.Size(167, 20)
        Me.optDiem10.TabIndex = 119
        Me.optDiem10.Text = "Hiển thị thang điểm 10"
        Me.optDiem10.UseVisualStyleBackColor = False
        '
        'chkMonhoc
        '
        Me.chkMonhoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkMonhoc.AutoSize = True
        Me.chkMonhoc.BackColor = System.Drawing.Color.Transparent
        Me.chkMonhoc.Location = New System.Drawing.Point(450, 504)
        Me.chkMonhoc.Name = "chkMonhoc"
        Me.chkMonhoc.Size = New System.Drawing.Size(194, 20)
        Me.chkMonhoc.TabIndex = 121
        Me.chkMonhoc.Text = "Hiển thị theo tên Học phần"
        Me.chkMonhoc.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(704, 530)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(84, 31)
        Me.cmdClose.TabIndex = 165
        Me.cmdClose.Text = "Thoát"
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
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(612, 530)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(84, 31)
        Me.cmdExport.TabIndex = 166
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdTong
        '
        Me.cmdTong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTong.ImageIndex = 15
        Me.cmdTong.ImageList = Me.ImgMain
        Me.cmdTong.Location = New System.Drawing.Point(386, 531)
        Me.cmdTong.Name = "cmdTong"
        Me.cmdTong.Size = New System.Drawing.Size(95, 31)
        Me.cmdTong.TabIndex = 164
        Me.cmdTong.Text = "Tổng hợp"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(631, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 24)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Điểm <"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDen_diem
        '
        Me.txtDen_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDen_diem.Location = New System.Drawing.Point(691, 478)
        Me.txtDen_diem.MaxLength = 4
        Me.txtDen_diem.Name = "txtDen_diem"
        Me.txtDen_diem.Size = New System.Drawing.Size(42, 23)
        Me.txtDen_diem.TabIndex = 170
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(528, 477)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Điểm >="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTu_diem
        '
        Me.txtTu_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTu_diem.Location = New System.Drawing.Point(589, 478)
        Me.txtTu_diem.MaxLength = 4
        Me.txtTu_diem.Name = "txtTu_diem"
        Me.txtTu_diem.Size = New System.Drawing.Size(42, 23)
        Me.txtTu_diem.TabIndex = 168
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPhanLoai_Lop), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPhanLoai_Mon)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'cmdPhanLoai_Lop
        '
        Me.cmdPhanLoai_Lop.Caption = "Phân loại theo lớp"
        Me.cmdPhanLoai_Lop.Id = 15
        Me.cmdPhanLoai_Lop.ImageIndex = 3
        Me.cmdPhanLoai_Lop.Name = "cmdPhanLoai_Lop"
        '
        'cmdPhanLoai_Mon
        '
        Me.cmdPhanLoai_Mon.Caption = "Phân loại theo môn"
        Me.cmdPhanLoai_Mon.Id = 16
        Me.cmdPhanLoai_Mon.ImageIndex = 3
        Me.cmdPhanLoai_Mon.Name = "cmdPhanLoai_Mon"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_BDT, Me.cmdPrint1, Me.cmdPrint2, Me.cmdPhanLoai_Lop, Me.cmdPhanLoai_Mon})
        Me.BarManager1.MaxItemId = 17
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
        'cmdPrint_BDT
        '
        Me.cmdPrint_BDT.Caption = "Bảng điểm thi"
        Me.cmdPrint_BDT.Id = 0
        Me.cmdPrint_BDT.ImageIndex = 16
        Me.cmdPrint_BDT.Name = "cmdPrint_BDT"
        '
        'cmdPrint1
        '
        Me.cmdPrint1.Caption = "In báo cáo"
        Me.cmdPrint1.Id = 13
        Me.cmdPrint1.ImageIndex = 16
        Me.cmdPrint1.Name = "cmdPrint1"
        '
        'cmdPrint2
        '
        Me.cmdPrint2.Caption = "Báo cáo tổng hợp"
        Me.cmdPrint2.Id = 14
        Me.cmdPrint2.ImageIndex = 16
        Me.cmdPrint2.Name = "cmdPrint2"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(488, 531)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrintList.TabIndex = 271
        Me.cmdPrintList.Text = "In danh sách"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPhanLoai
        '
        Me.cmdPhanLoai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPhanLoai.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPhanLoai.Appearance.Options.UseFont = True
        Me.cmdPhanLoai.DropDownControl = Me.PopupMenu2
        Me.cmdPhanLoai.ImageIndex = 3
        Me.cmdPhanLoai.ImageList = Me.ImgMain
        Me.cmdPhanLoai.Location = New System.Drawing.Point(130, 479)
        Me.cmdPhanLoai.Name = "cmdPhanLoai"
        Me.cmdPhanLoai.Size = New System.Drawing.Size(128, 30)
        Me.cmdPhanLoai.TabIndex = 270
        Me.cmdPhanLoai.Text = "Phân loại KQHT"
        Me.cmdPhanLoai.Visible = False
        '
        'TreeViewChuyenNganh_Nganh21
        '
        Me.TreeViewChuyenNganh_Nganh21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewChuyenNganh_Nganh21.dtLop = Nothing
        Me.TreeViewChuyenNganh_Nganh21.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewChuyenNganh_Nganh21.Location = New System.Drawing.Point(2, 0)
        Me.TreeViewChuyenNganh_Nganh21.Name = "TreeViewChuyenNganh_Nganh21"
        Me.TreeViewChuyenNganh_Nganh21.Size = New System.Drawing.Size(260, 569)
        Me.TreeViewChuyenNganh_Nganh21.TabIndex = 299
        '
        'frmESS_TongHop_DiemHocTichLuy_NganhHoc2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.TreeViewChuyenNganh_Nganh21)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmdPhanLoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTu_diem)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdTong)
        Me.Controls.Add(Me.chkMonhoc)
        Me.Controls.Add(Me.chkGhi_chu)
        Me.Controls.Add(Me.optDiem10)
        Me.Controls.Add(Me.optDiemSo)
        Me.Controls.Add(Me.optDiemChu)
        Me.Controls.Add(Me.fgTongHopToanKhoa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDen_diem)
        Me.Controls.Add(Me.cmbKho_giay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_TongHop_DiemHocTichLuy_NganhHoc2"
        Me.Text = "TONG HOP DIEM TOAN KHOA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fgTongHopToanKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fgTongHopToanKhoa As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKho_giay As System.Windows.Forms.ComboBox
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents optDiemSo As System.Windows.Forms.RadioButton
    Friend WithEvents optDiemChu As System.Windows.Forms.RadioButton
    Friend WithEvents chkGhi_chu As System.Windows.Forms.CheckBox
    Friend WithEvents optDiem10 As System.Windows.Forms.RadioButton
    Friend WithEvents chkMonhoc As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDen_diem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTu_diem As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPhanLoai_Lop As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPhanLoai_Mon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdPrint_BDT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPhanLoai As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents TreeViewChuyenNganh_Nganh21 As ESSMarkMan.TreeViewChuyenNganh_Nganh2
End Class
