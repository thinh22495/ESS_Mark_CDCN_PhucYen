﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiem_Thi_LopTinChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiem_Thi_LopTinChi))
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbKy_hieu = New System.Windows.Forms.ComboBox
        Me.cmdGhiChu = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdHelp = New DevExpress.XtraEditors.SimpleButton
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox
        Me.lblThanh_phan = New System.Windows.Forms.Label
        Me.cmdDongBo = New DevExpress.XtraEditors.SimpleButton
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox
        Me.lblCot_diem = New System.Windows.Forms.Label
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.cmbMa_sv = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.trvLopTinChi = New ESSMarkMan.TreeViewLopTinChi
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton
        Me.optDaDuyet = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkNot_show_all
        '
        Me.chkNot_show_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNot_show_all.BackColor = System.Drawing.Color.Transparent
        Me.chkNot_show_all.Checked = True
        Me.chkNot_show_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNot_show_all.Location = New System.Drawing.Point(266, 85)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(531, 24)
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
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 136)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(553, 391)
        Me.grdViewDiem.TabIndex = 99
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Location = New System.Drawing.Point(753, 85)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(66, 24)
        Me.cmbLan_thi.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(692, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(267, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Hiển thị sinh viên điểm:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKy_hieu
        '
        Me.cmbKy_hieu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKy_hieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu.FormattingEnabled = True
        Me.cmbKy_hieu.Items.AddRange(New Object() {"Từ điểm D trở xuống", "Những sinh viên thiếu điểm TP", "Những sinh viên thiếu điểm Thi", "Những sinh viên không tính điểm thành phần vào TBCHP", "Những sinh viên bảo lưu"})
        Me.cmbKy_hieu.Location = New System.Drawing.Point(423, 58)
        Me.cmbKy_hieu.Name = "cmbKy_hieu"
        Me.cmbKy_hieu.Size = New System.Drawing.Size(396, 24)
        Me.cmbKy_hieu.TabIndex = 108
        '
        'cmdGhiChu
        '
        Me.cmdGhiChu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGhiChu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGhiChu.Appearance.Options.UseFont = True
        Me.cmdGhiChu.ImageIndex = 8
        Me.cmdGhiChu.ImageList = Me.ImgMain
        Me.cmdGhiChu.Location = New System.Drawing.Point(206, 532)
        Me.cmdGhiChu.Name = "cmdGhiChu"
        Me.cmdGhiChu.Size = New System.Drawing.Size(152, 30)
        Me.cmdGhiChu.TabIndex = 192
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
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(488, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(112, 30)
        Me.cmdExport.TabIndex = 193
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(697, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(118, 30)
        Me.cmdClose.TabIndex = 191
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(110, 532)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 30)
        Me.cmdSave.TabIndex = 189
        Me.cmdSave.Text = "Lưu"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(112, 532)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(88, 30)
        Me.cmdDelete.TabIndex = 194
        Me.cmdDelete.Text = "Xóa tất cả"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(364, 532)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrint.TabIndex = 190
        Me.cmdPrint.Text = "In bảng điểm"
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Appearance.Options.UseFont = True
        Me.cmdHelp.ImageIndex = 20
        Me.cmdHelp.ImageList = Me.ImgMain
        Me.cmdHelp.Location = New System.Drawing.Point(729, 31)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(88, 24)
        Me.cmdHelp.TabIndex = 247
        Me.cmdHelp.Text = "Hướng dẫn"
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(616, 1)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(107, 24)
        Me.cmbThanh_phan.TabIndex = 245
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.lblThanh_phan.Location = New System.Drawing.Point(496, 1)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 246
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
        Me.cmdDongBo.Location = New System.Drawing.Point(729, 1)
        Me.cmdDongBo.Name = "cmdDongBo"
        Me.cmdDongBo.Size = New System.Drawing.Size(88, 24)
        Me.cmdDongBo.TabIndex = 244
        Me.cmdDongBo.Text = "Đồng bộ"
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(616, 31)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(107, 24)
        Me.cmbCot_diem.TabIndex = 242
        '
        'lblCot_diem
        '
        Me.lblCot_diem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(461, 35)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(155, 17)
        Me.lblCot_diem.TabIndex = 243
        Me.lblCot_diem.Text = "Chọn cột dữ liệu điểm:"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMa_sv
        '
        Me.cmbMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMa_sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_sv.Location = New System.Drawing.Point(382, 1)
        Me.cmbMa_sv.Name = "cmbMa_sv"
        Me.cmbMa_sv.Size = New System.Drawing.Size(114, 24)
        Me.cmbMa_sv.TabIndex = 240
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(332, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 241
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
        Me.cmdBrowse.Location = New System.Drawing.Point(270, 1)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 24)
        Me.cmdBrowse.TabIndex = 239
        Me.cmdBrowse.Text = "Open"
        '
        'cmbChonFile
        '
        Me.cmbChonFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(158, 1)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 24)
        Me.cmbChonFile.TabIndex = 237
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(66, 1)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 238
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.trvLopTinChi.Location = New System.Drawing.Point(0, 1)
        Me.trvLopTinChi.Name = "trvLopTinChi"
        Me.trvLopTinChi.Size = New System.Drawing.Size(264, 529)
        Me.trvLopTinChi.TabIndex = 100
        Me.trvLopTinChi.Ten_he = ""
        Me.trvLopTinChi.Ten_lop_tc = ""
        Me.trvLopTinChi.Ten_mon = ""
        '
        'cmdLock
        '
        Me.cmdLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLock.Appearance.Options.UseFont = True
        Me.cmdLock.ImageIndex = 22
        Me.cmdLock.ImageList = Me.ImgMain
        Me.cmdLock.Location = New System.Drawing.Point(605, 532)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(87, 30)
        Me.cmdLock.TabIndex = 248
        Me.cmdLock.Text = "Khóa điểm"
        '
        'optDaDuyet
        '
        Me.optDaDuyet.AutoSize = True
        Me.optDaDuyet.BackColor = System.Drawing.Color.Transparent
        Me.optDaDuyet.Checked = True
        Me.optDaDuyet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optDaDuyet.Location = New System.Drawing.Point(266, 114)
        Me.optDaDuyet.Name = "optDaDuyet"
        Me.optDaDuyet.Size = New System.Drawing.Size(198, 20)
        Me.optDaDuyet.TabIndex = 249
        Me.optDaDuyet.Text = "Chỉ hiển thị sv đã duyệt ĐK"
        Me.optDaDuyet.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(539, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "Số sinh viên:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(639, 112)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(98, 24)
        Me.lblSo_sv.TabIndex = 251
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmESS_NhapDiem_Thi_LopTinChi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(821, 566)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optDaDuyet)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.trvLopTinChi)
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
        Me.Controls.Add(Me.cmdGhiChu)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbKy_hieu)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_NhapDiem_Thi_LopTinChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHAP DIEM THI LOP TIN CHI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents trvLopTinChi As ESSMarkMan.TreeViewLopTinChi
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbKy_hieu As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGhiChu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdHelp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbThanh_phan As System.Windows.Forms.ComboBox
    Friend WithEvents lblThanh_phan As System.Windows.Forms.Label
    Friend WithEvents cmdDongBo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbMa_sv As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents optDaDuyet As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
End Class
