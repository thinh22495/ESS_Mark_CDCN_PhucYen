<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TimKiemDonGian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_TimKiemDonGian))
        Me.txtHo_khau_tt = New System.Windows.Forms.TextBox
        Me.lblSBD = New System.Windows.Forms.Label
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.lblHokhau_thuongtru = New System.Windows.Forms.Label
        Me.lblHo_ten = New System.Windows.Forms.Label
        Me.lblMa_sv = New System.Windows.Forms.Label
        Me.txtNgay_sinh = New System.Windows.Forms.TextBox
        Me.txtSBD = New System.Windows.Forms.TextBox
        Me.lblNgay_sinh = New System.Windows.Forms.Label
        Me.cmbID_hien_thi = New System.Windows.Forms.ComboBox
        Me.lblNhom_hien_thi = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.lblTon_so_sv = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdView = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHo_khau_tt
        '
        Me.txtHo_khau_tt.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHo_khau_tt.Location = New System.Drawing.Point(143, 86)
        Me.txtHo_khau_tt.Name = "txtHo_khau_tt"
        Me.txtHo_khau_tt.Size = New System.Drawing.Size(639, 23)
        Me.txtHo_khau_tt.TabIndex = 33
        '
        'lblSBD
        '
        Me.lblSBD.BackColor = System.Drawing.Color.Transparent
        Me.lblSBD.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSBD.Location = New System.Drawing.Point(491, 28)
        Me.lblSBD.Name = "lblSBD"
        Me.lblSBD.Size = New System.Drawing.Size(144, 23)
        Me.lblSBD.TabIndex = 34
        Me.lblSBD.Text = "SBD thi tuyển:"
        Me.lblSBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHo_ten.Location = New System.Drawing.Point(143, 57)
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(225, 23)
        Me.txtHo_ten.TabIndex = 30
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMa_sv.Location = New System.Drawing.Point(143, 28)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(130, 23)
        Me.txtMa_sv.TabIndex = 28
        '
        'lblHokhau_thuongtru
        '
        Me.lblHokhau_thuongtru.BackColor = System.Drawing.Color.Transparent
        Me.lblHokhau_thuongtru.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHokhau_thuongtru.Location = New System.Drawing.Point(6, 86)
        Me.lblHokhau_thuongtru.Name = "lblHokhau_thuongtru"
        Me.lblHokhau_thuongtru.Size = New System.Drawing.Size(140, 23)
        Me.lblHokhau_thuongtru.TabIndex = 37
        Me.lblHokhau_thuongtru.Text = "Hộ khẩu thường trú:"
        Me.lblHokhau_thuongtru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHo_ten
        '
        Me.lblHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.lblHo_ten.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHo_ten.Location = New System.Drawing.Point(32, 57)
        Me.lblHo_ten.Name = "lblHo_ten"
        Me.lblHo_ten.Size = New System.Drawing.Size(114, 23)
        Me.lblHo_ten.TabIndex = 35
        Me.lblHo_ten.Text = "Họ và tên:"
        Me.lblHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMa_sv
        '
        Me.lblMa_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblMa_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMa_sv.Location = New System.Drawing.Point(29, 28)
        Me.lblMa_sv.Name = "lblMa_sv"
        Me.lblMa_sv.Size = New System.Drawing.Size(119, 23)
        Me.lblMa_sv.TabIndex = 32
        Me.lblMa_sv.Text = "Mã sinh viên:"
        Me.lblMa_sv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNgay_sinh
        '
        Me.txtNgay_sinh.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNgay_sinh.Location = New System.Drawing.Point(641, 57)
        Me.txtNgay_sinh.Name = "txtNgay_sinh"
        Me.txtNgay_sinh.Size = New System.Drawing.Size(141, 23)
        Me.txtNgay_sinh.TabIndex = 31
        '
        'txtSBD
        '
        Me.txtSBD.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBD.Location = New System.Drawing.Point(641, 28)
        Me.txtSBD.Name = "txtSBD"
        Me.txtSBD.Size = New System.Drawing.Size(141, 23)
        Me.txtSBD.TabIndex = 29
        '
        'lblNgay_sinh
        '
        Me.lblNgay_sinh.BackColor = System.Drawing.Color.Transparent
        Me.lblNgay_sinh.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgay_sinh.Location = New System.Drawing.Point(531, 57)
        Me.lblNgay_sinh.Name = "lblNgay_sinh"
        Me.lblNgay_sinh.Size = New System.Drawing.Size(104, 23)
        Me.lblNgay_sinh.TabIndex = 36
        Me.lblNgay_sinh.Text = "Ngày sinh:"
        Me.lblNgay_sinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_hien_thi
        '
        Me.cmbID_hien_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_hien_thi.Location = New System.Drawing.Point(510, 114)
        Me.cmbID_hien_thi.Name = "cmbID_hien_thi"
        Me.cmbID_hien_thi.Size = New System.Drawing.Size(216, 24)
        Me.cmbID_hien_thi.TabIndex = 66
        '
        'lblNhom_hien_thi
        '
        Me.lblNhom_hien_thi.BackColor = System.Drawing.Color.Transparent
        Me.lblNhom_hien_thi.Location = New System.Drawing.Point(318, 114)
        Me.lblNhom_hien_thi.Name = "lblNhom_hien_thi"
        Me.lblNhom_hien_thi.Size = New System.Drawing.Size(194, 24)
        Me.lblNhom_hien_thi.TabIndex = 65
        Me.lblNhom_hien_thi.Text = "Hiển thị thông tin theo:"
        Me.lblNhom_hien_thi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_sv
        '
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(143, 114)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(81, 24)
        Me.lblSo_sv.TabIndex = 69
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTon_so_sv
        '
        Me.lblTon_so_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblTon_so_sv.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTon_so_sv.Location = New System.Drawing.Point(11, 114)
        Me.lblTon_so_sv.Name = "lblTon_so_sv"
        Me.lblTon_so_sv.Size = New System.Drawing.Size(135, 24)
        Me.lblTon_so_sv.TabIndex = 68
        Me.lblTon_so_sv.Text = "Tống số bản ghi:"
        Me.lblTon_so_sv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(2, 154)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(789, 372)
        Me.grcDanhSach.TabIndex = 241
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach.OptionsView.ShowViewCaption = True
        Me.grvDanhSach.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(585, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(97, 30)
        Me.cmdExport.TabIndex = 249
        Me.cmdExport.Text = "Xuất Excel"
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
        'cmdView
        '
        Me.cmdView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdView.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Appearance.Options.UseFont = True
        Me.cmdView.ImageIndex = 8
        Me.cmdView.ImageList = Me.ImgMain
        Me.cmdView.Location = New System.Drawing.Point(482, 532)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(97, 30)
        Me.cmdView.TabIndex = 250
        Me.cmdView.Text = "Xem hồ sơ"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageIndex = 7
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(687, 532)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(97, 30)
        Me.SimpleButton1.TabIndex = 247
        Me.SimpleButton1.Text = "Thoát"
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.ImageIndex = 19
        Me.cmdSearch.ImageList = Me.ImgMain
        Me.cmdSearch.Location = New System.Drawing.Point(379, 532)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(97, 30)
        Me.cmdSearch.TabIndex = 248
        Me.cmdSearch.Text = "Tìm kiếm"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ImageIndex = 0
        Me.btnEdit.ImageList = Me.ImgMain
        Me.btnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEdit.Location = New System.Drawing.Point(732, 114)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 24)
        Me.btnEdit.TabIndex = 252
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblMa_sv)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.lblNgay_sinh)
        Me.GroupBox1.Controls.Add(Me.txtSBD)
        Me.GroupBox1.Controls.Add(Me.txtNgay_sinh)
        Me.GroupBox1.Controls.Add(Me.lblHo_ten)
        Me.GroupBox1.Controls.Add(Me.lblHokhau_thuongtru)
        Me.GroupBox1.Controls.Add(Me.txtMa_sv)
        Me.GroupBox1.Controls.Add(Me.lblSo_sv)
        Me.GroupBox1.Controls.Add(Me.txtHo_ten)
        Me.GroupBox1.Controls.Add(Me.lblTon_so_sv)
        Me.GroupBox1.Controls.Add(Me.lblSBD)
        Me.GroupBox1.Controls.Add(Me.cmbID_hien_thi)
        Me.GroupBox1.Controls.Add(Me.txtHo_khau_tt)
        Me.GroupBox1.Controls.Add(Me.lblNhom_hien_thi)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 146)
        Me.GroupBox1.TabIndex = 253
        Me.GroupBox1.TabStop = False
        '
        'frmESS_TimKiemDonGian
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_TimKiemDonGian"
        Me.Text = "Tìm kiếm đơn giản"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHo_khau_tt As System.Windows.Forms.TextBox
    Friend WithEvents lblSBD As System.Windows.Forms.Label
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents lblHokhau_thuongtru As System.Windows.Forms.Label
    Friend WithEvents lblHo_ten As System.Windows.Forms.Label
    Friend WithEvents lblMa_sv As System.Windows.Forms.Label
    Friend WithEvents txtNgay_sinh As System.Windows.Forms.TextBox
    Friend WithEvents txtSBD As System.Windows.Forms.TextBox
    Friend WithEvents lblNgay_sinh As System.Windows.Forms.Label
    Friend WithEvents cmbID_hien_thi As System.Windows.Forms.ComboBox
    Friend WithEvents lblNhom_hien_thi As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTon_so_sv As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
