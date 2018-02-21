<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhungChuongTrinhDaoTao_NhapKhau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhungChuongTrinhDaoTao_NhapKhau))
        Me.grpDL_nguon = New System.Windows.Forms.GroupBox
        Me.grpTen_bang_ODBC = New System.Windows.Forms.GroupBox
        Me.lsvTen_bang_ODBC = New System.Windows.Forms.ListView
        Me.grpODBC = New System.Windows.Forms.GroupBox
        Me.cmbFont = New System.Windows.Forms.ComboBox
        Me.lblFont = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.optAccess = New System.Windows.Forms.RadioButton
        Me.optFoxpro = New System.Windows.Forms.RadioButton
        Me.optExcel = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkUpdate = New System.Windows.Forms.CheckBox
        Me.cmbSo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.optMa_mon = New System.Windows.Forms.RadioButton
        Me.optTen_mon = New System.Windows.Forms.RadioButton
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.grdViewCTDTChiTiet = New System.Windows.Forms.DataGridView
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.grpDL_nguon.SuspendLayout()
        Me.grpTen_bang_ODBC.SuspendLayout()
        Me.grpODBC.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdViewCTDTChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDL_nguon
        '
        Me.grpDL_nguon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDL_nguon.BackColor = System.Drawing.Color.Transparent
        Me.grpDL_nguon.Controls.Add(Me.grpTen_bang_ODBC)
        Me.grpDL_nguon.Controls.Add(Me.grpODBC)
        Me.grpDL_nguon.Location = New System.Drawing.Point(7, 89)
        Me.grpDL_nguon.Name = "grpDL_nguon"
        Me.grpDL_nguon.Size = New System.Drawing.Size(921, 155)
        Me.grpDL_nguon.TabIndex = 11
        Me.grpDL_nguon.TabStop = False
        Me.grpDL_nguon.Text = "Lựa chọn các dư liệu nguồn"
        '
        'grpTen_bang_ODBC
        '
        Me.grpTen_bang_ODBC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTen_bang_ODBC.BackColor = System.Drawing.Color.Transparent
        Me.grpTen_bang_ODBC.Controls.Add(Me.lsvTen_bang_ODBC)
        Me.grpTen_bang_ODBC.Location = New System.Drawing.Point(395, 20)
        Me.grpTen_bang_ODBC.Name = "grpTen_bang_ODBC"
        Me.grpTen_bang_ODBC.Size = New System.Drawing.Size(517, 129)
        Me.grpTen_bang_ODBC.TabIndex = 1
        Me.grpTen_bang_ODBC.TabStop = False
        Me.grpTen_bang_ODBC.Text = "Danh sách các bảng"
        '
        'lsvTen_bang_ODBC
        '
        Me.lsvTen_bang_ODBC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvTen_bang_ODBC.FullRowSelect = True
        Me.lsvTen_bang_ODBC.GridLines = True
        Me.lsvTen_bang_ODBC.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsvTen_bang_ODBC.Location = New System.Drawing.Point(9, 25)
        Me.lsvTen_bang_ODBC.MultiSelect = False
        Me.lsvTen_bang_ODBC.Name = "lsvTen_bang_ODBC"
        Me.lsvTen_bang_ODBC.Size = New System.Drawing.Size(498, 98)
        Me.lsvTen_bang_ODBC.TabIndex = 0
        Me.lsvTen_bang_ODBC.UseCompatibleStateImageBehavior = False
        Me.lsvTen_bang_ODBC.View = System.Windows.Forms.View.Details
        '
        'grpODBC
        '
        Me.grpODBC.BackColor = System.Drawing.Color.Transparent
        Me.grpODBC.Controls.Add(Me.cmbFont)
        Me.grpODBC.Controls.Add(Me.lblFont)
        Me.grpODBC.Controls.Add(Me.LinkLabel1)
        Me.grpODBC.Controls.Add(Me.Label3)
        Me.grpODBC.Controls.Add(Me.optAccess)
        Me.grpODBC.Controls.Add(Me.optFoxpro)
        Me.grpODBC.Controls.Add(Me.optExcel)
        Me.grpODBC.Location = New System.Drawing.Point(9, 20)
        Me.grpODBC.Name = "grpODBC"
        Me.grpODBC.Size = New System.Drawing.Size(380, 129)
        Me.grpODBC.TabIndex = 0
        Me.grpODBC.TabStop = False
        Me.grpODBC.Text = "Chọn kết nối CSDL: Foxpro, Access, Excel"
        '
        'cmbFont
        '
        Me.cmbFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFont.Location = New System.Drawing.Point(154, 85)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(220, 24)
        Me.cmbFont.TabIndex = 14
        '
        'lblFont
        '
        Me.lblFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFont.BackColor = System.Drawing.Color.Transparent
        Me.lblFont.Location = New System.Drawing.Point(9, 84)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(139, 24)
        Me.lblFont.TabIndex = 13
        Me.lblFont.Text = "Font dữ liệu nguồn:"
        Me.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(151, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(105, 19)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Mở file dữ liệu"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Chọn loại file:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optAccess
        '
        Me.optAccess.Location = New System.Drawing.Point(296, 25)
        Me.optAccess.Name = "optAccess"
        Me.optAccess.Size = New System.Drawing.Size(78, 30)
        Me.optAccess.TabIndex = 11
        Me.optAccess.Text = "Access"
        '
        'optFoxpro
        '
        Me.optFoxpro.Location = New System.Drawing.Point(222, 25)
        Me.optFoxpro.Name = "optFoxpro"
        Me.optFoxpro.Size = New System.Drawing.Size(84, 30)
        Me.optFoxpro.TabIndex = 10
        Me.optFoxpro.Text = "Foxpro"
        '
        'optExcel
        '
        Me.optExcel.Checked = True
        Me.optExcel.Location = New System.Drawing.Point(154, 25)
        Me.optExcel.Name = "optExcel"
        Me.optExcel.Size = New System.Drawing.Size(75, 30)
        Me.optExcel.TabIndex = 9
        Me.optExcel.TabStop = True
        Me.optExcel.Text = "Excel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkUpdate)
        Me.GroupBox1.Controls.Add(Me.cmbSo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.optMa_mon)
        Me.GroupBox1.Controls.Add(Me.optTen_mon)
        Me.GroupBox1.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbID_khoa)
        Me.GroupBox1.Controls.Add(Me.cmbID_he)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbKhoa_hoc)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 78)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lựa chọn các tùy chọn cho khung chương trình"
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Location = New System.Drawing.Point(707, 52)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(127, 20)
        Me.chkUpdate.TabIndex = 74
        Me.chkUpdate.Text = "Cập nhật CTĐT"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'cmbSo
        '
        Me.cmbSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbSo.Location = New System.Drawing.Point(819, 22)
        Me.cmbSo.Name = "cmbSo"
        Me.cmbSo.Size = New System.Drawing.Size(66, 24)
        Me.cmbSo.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(776, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 24)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Số:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optMa_mon
        '
        Me.optMa_mon.AutoSize = True
        Me.optMa_mon.Checked = True
        Me.optMa_mon.Location = New System.Drawing.Point(410, 53)
        Me.optMa_mon.Name = "optMa_mon"
        Me.optMa_mon.Size = New System.Drawing.Size(268, 20)
        Me.optMa_mon.TabIndex = 67
        Me.optMa_mon.TabStop = True
        Me.optMa_mon.Text = "Phân loại Học phần theo Mã Học phần"
        Me.optMa_mon.UseVisualStyleBackColor = True
        '
        'optTen_mon
        '
        Me.optTen_mon.AutoSize = True
        Me.optTen_mon.Location = New System.Drawing.Point(47, 53)
        Me.optTen_mon.Name = "optTen_mon"
        Me.optTen_mon.Size = New System.Drawing.Size(274, 20)
        Me.optTen_mon.TabIndex = 66
        Me.optTen_mon.Text = "Phân loại Học phần theo Tên Học phần"
        Me.optTen_mon.UseVisualStyleBackColor = True
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(572, 22)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(195, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(460, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Chuyên ngành:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_khoa.Location = New System.Drawing.Point(203, 22)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(152, 24)
        Me.cmbID_khoa.TabIndex = 63
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(47, 22)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(105, 24)
        Me.cmbID_he.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(151, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Khoa:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 24)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Hệ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(359, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 24)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Khoá:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(410, 22)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(49, 24)
        Me.cmbKhoa_hoc.TabIndex = 61
        '
        'grdViewCTDTChiTiet
        '
        Me.grdViewCTDTChiTiet.AllowUserToAddRows = False
        Me.grdViewCTDTChiTiet.AllowUserToDeleteRows = False
        Me.grdViewCTDTChiTiet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewCTDTChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewCTDTChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewCTDTChiTiet.Location = New System.Drawing.Point(0, 250)
        Me.grdViewCTDTChiTiet.Name = "grdViewCTDTChiTiet"
        Me.grdViewCTDTChiTiet.ShowCellErrors = False
        Me.grdViewCTDTChiTiet.ShowCellToolTips = False
        Me.grdViewCTDTChiTiet.Size = New System.Drawing.Size(935, 278)
        Me.grdViewCTDTChiTiet.TabIndex = 60
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(844, 534)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 171
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
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 0
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(751, 534)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 30)
        Me.cmdSave.TabIndex = 172
        Me.cmdSave.Text = "Nhập khẩu"
        '
        'frmESS_KhungChuongTrinhDaoTao_NhapKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 568)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grdViewCTDTChiTiet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpDL_nguon)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_KhungChuongTrinhDaoTao_NhapKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHAP KHAU KHUNG CHUONG TRINH DAO TAO"
        Me.grpDL_nguon.ResumeLayout(False)
        Me.grpTen_bang_ODBC.ResumeLayout(False)
        Me.grpODBC.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdViewCTDTChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDL_nguon As System.Windows.Forms.GroupBox
    Friend WithEvents grpTen_bang_ODBC As System.Windows.Forms.GroupBox
    Friend WithEvents lsvTen_bang_ODBC As System.Windows.Forms.ListView
    Friend WithEvents grpODBC As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFont As System.Windows.Forms.ComboBox
    Friend WithEvents lblFont As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents optAccess As System.Windows.Forms.RadioButton
    Friend WithEvents optFoxpro As System.Windows.Forms.RadioButton
    Friend WithEvents optExcel As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents grdViewCTDTChiTiet As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents optMa_mon As System.Windows.Forms.RadioButton
    Friend WithEvents optTen_mon As System.Windows.Forms.RadioButton
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmbSo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
End Class
