<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVien_QuyetDinh_Tim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DanhSachSinhVien_QuyetDinh_Tim))
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.cmbID_Lop = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbLoai_QD = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_khoa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKhoa_hoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSo_qd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_qd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLy_do = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdFind = New DevExpress.XtraEditors.SimpleButton
        Me.grpGroup = New System.Windows.Forms.GroupBox
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(405, 21)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(53, 24)
        Me.cmbKhoa_hoc.TabIndex = 177
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_khoa.Location = New System.Drawing.Point(220, 21)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(127, 24)
        Me.cmbID_khoa.TabIndex = 173
        '
        'cmbID_Lop
        '
        Me.cmbID_Lop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_Lop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_Lop.Location = New System.Drawing.Point(505, 21)
        Me.cmbID_Lop.Name = "cmbID_Lop"
        Me.cmbID_Lop.Size = New System.Drawing.Size(79, 24)
        Me.cmbID_Lop.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(459, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 26)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Lớp :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 26)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Khoá :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 26)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Khoa :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_he
        '
        Me.cmbID_he.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(42, 21)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(123, 24)
        Me.cmbID_he.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 26)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Hệ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_QD
        '
        Me.cmbLoai_QD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoai_QD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_QD.Items.AddRange(New Object() {"", "Ngừng học", "Thôi học", "Chuyển trường", "Xét học tiếp"})
        Me.cmbLoai_QD.Location = New System.Drawing.Point(647, 21)
        Me.cmbLoai_QD.Name = "cmbLoai_QD"
        Me.cmbLoai_QD.Size = New System.Drawing.Size(138, 24)
        Me.cmbLoai_QD.TabIndex = 179
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(588, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 26)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Loại QĐ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(3, -1)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(790, 482)
        Me.grcDanhSach.TabIndex = 181
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop, Me.colTen_khoa, Me.colKhoa_hoc, Me.colSo_qd, Me.colNgay_qd, Me.colLy_do})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 0
        Me.colMa_sv.Width = 62
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 1
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
        Me.colNgay_sinh.VisibleIndex = 2
        Me.colNgay_sinh.Width = 62
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.OptionsColumn.ReadOnly = True
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 3
        '
        'colTen_khoa
        '
        Me.colTen_khoa.Caption = "Tên khoa"
        Me.colTen_khoa.FieldName = "Ten_khoa"
        Me.colTen_khoa.Name = "colTen_khoa"
        Me.colTen_khoa.Visible = True
        Me.colTen_khoa.VisibleIndex = 4
        Me.colTen_khoa.Width = 163
        '
        'colKhoa_hoc
        '
        Me.colKhoa_hoc.Caption = "Khóa học"
        Me.colKhoa_hoc.FieldName = "Khoa_hoc"
        Me.colKhoa_hoc.Name = "colKhoa_hoc"
        Me.colKhoa_hoc.Visible = True
        Me.colKhoa_hoc.VisibleIndex = 5
        '
        'colSo_qd
        '
        Me.colSo_qd.Caption = "Số QĐ"
        Me.colSo_qd.FieldName = "So_qd"
        Me.colSo_qd.Name = "colSo_qd"
        Me.colSo_qd.Visible = True
        Me.colSo_qd.VisibleIndex = 6
        '
        'colNgay_qd
        '
        Me.colNgay_qd.Caption = "Ngày QĐ"
        Me.colNgay_qd.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_qd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_qd.FieldName = "Ngay_qd"
        Me.colNgay_qd.Name = "colNgay_qd"
        Me.colNgay_qd.Visible = True
        Me.colNgay_qd.VisibleIndex = 7
        '
        'colLy_do
        '
        Me.colLy_do.Caption = "Lý do"
        Me.colLy_do.FieldName = "Ly_do"
        Me.colLy_do.Name = "colLy_do"
        Me.colLy_do.Visible = True
        Me.colLy_do.VisibleIndex = 8
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(675, 542)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 182
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
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(551, 542)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(115, 30)
        Me.cmdExport.TabIndex = 183
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdFind
        '
        Me.cmdFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFind.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Appearance.Options.UseFont = True
        Me.cmdFind.ImageIndex = 19
        Me.cmdFind.ImageList = Me.ImgMain
        Me.cmdFind.Location = New System.Drawing.Point(426, 542)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(115, 30)
        Me.cmdFind.TabIndex = 183
        Me.cmdFind.Text = "Tìm kiếm"
        '
        'grpGroup
        '
        Me.grpGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpGroup.BackColor = System.Drawing.Color.Transparent
        Me.grpGroup.Controls.Add(Me.cmbID_Lop)
        Me.grpGroup.Controls.Add(Me.Label4)
        Me.grpGroup.Controls.Add(Me.cmbID_he)
        Me.grpGroup.Controls.Add(Me.Label3)
        Me.grpGroup.Controls.Add(Me.cmbLoai_QD)
        Me.grpGroup.Controls.Add(Me.Label5)
        Me.grpGroup.Controls.Add(Me.Label1)
        Me.grpGroup.Controls.Add(Me.cmbID_khoa)
        Me.grpGroup.Controls.Add(Me.cmbKhoa_hoc)
        Me.grpGroup.Controls.Add(Me.Label2)
        Me.grpGroup.Location = New System.Drawing.Point(3, 480)
        Me.grpGroup.Name = "grpGroup"
        Me.grpGroup.Size = New System.Drawing.Size(788, 59)
        Me.grpGroup.TabIndex = 184
        Me.grpGroup.TabStop = False
        Me.grpGroup.Text = "Tiêu chỉ tìm kiếm"
        '
        'frmESS_DanhSachThoiHocNgungHoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 576)
        Me.Controls.Add(Me.grpGroup)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmESS_DanhSachThoiHocNgungHoc"
        Me.Text = "DANH SÁCH SINH VIÊN THÔI HỌC NGỪNG HỌC"
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_Lop As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLoai_QD As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_khoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSo_qd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_qd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLy_do As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpGroup As System.Windows.Forms.GroupBox
    Friend WithEvents colKhoa_hoc As DevExpress.XtraGrid.Columns.GridColumn
End Class
