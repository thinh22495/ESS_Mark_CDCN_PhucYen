<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_Users
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPassWord = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassWordTry = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LinkLDAP = New System.Windows.Forms.LinkLabel
        Me.txtFullname = New System.Windows.Forms.TextBox
        Me.cmbID_bm = New System.Windows.Forms.ComboBox
        Me.optKhoa = New System.Windows.Forms.RadioButton
        Me.optPhong = New System.Windows.Forms.RadioButton
        Me.cmbID_phong = New System.Windows.Forms.ComboBox
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbNhom = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbKhong_Kich_Hoat = New System.Windows.Forms.RadioButton
        Me.rbKich_hoat = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDien_Thoai = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtMAC = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(572, 25)
        Me.ToolStrip.TabIndex = 20
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSSysMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "&Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Th&oát"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(360, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 30)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(127, 41)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(227, 23)
        Me.txtUserName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tên đăng nhập:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassWord
        '
        Me.txtPassWord.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWord.Location = New System.Drawing.Point(127, 70)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.Size = New System.Drawing.Size(112, 23)
        Me.txtPassWord.TabIndex = 2
        Me.txtPassWord.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Mật khẩu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassWordTry
        '
        Me.txtPassWordTry.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWordTry.Location = New System.Drawing.Point(424, 69)
        Me.txtPassWordTry.Name = "txtPassWordTry"
        Me.txtPassWordTry.Size = New System.Drawing.Size(112, 23)
        Me.txtPassWordTry.TabIndex = 3
        Me.txtPassWordTry.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(269, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 24)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nhập lại mật khẩu:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(542, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(245, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 30)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "(*)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLDAP
        '
        Me.LinkLDAP.BackColor = System.Drawing.Color.Transparent
        Me.LinkLDAP.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLDAP.Location = New System.Drawing.Point(390, 39)
        Me.LinkLDAP.Name = "LinkLDAP"
        Me.LinkLDAP.Size = New System.Drawing.Size(173, 24)
        Me.LinkLDAP.TabIndex = 1
        Me.LinkLDAP.TabStop = True
        Me.LinkLDAP.Text = "Sử dụng User LDAP"
        Me.LinkLDAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLDAP.Visible = False
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(127, 99)
        Me.txtFullname.MaxLength = 30
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(409, 22)
        Me.txtFullname.TabIndex = 4
        '
        'cmbID_bm
        '
        Me.cmbID_bm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_bm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_bm.Location = New System.Drawing.Point(127, 245)
        Me.cmbID_bm.Name = "cmbID_bm"
        Me.cmbID_bm.Size = New System.Drawing.Size(409, 24)
        Me.cmbID_bm.TabIndex = 9
        '
        'optKhoa
        '
        Me.optKhoa.BackColor = System.Drawing.Color.Transparent
        Me.optKhoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optKhoa.ForeColor = System.Drawing.Color.Black
        Me.optKhoa.Location = New System.Drawing.Point(54, 215)
        Me.optKhoa.Name = "optKhoa"
        Me.optKhoa.Size = New System.Drawing.Size(72, 24)
        Me.optKhoa.TabIndex = 58
        Me.optKhoa.Text = "Khoa"
        Me.optKhoa.UseVisualStyleBackColor = False
        '
        'optPhong
        '
        Me.optPhong.BackColor = System.Drawing.Color.Transparent
        Me.optPhong.Checked = True
        Me.optPhong.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPhong.ForeColor = System.Drawing.Color.Black
        Me.optPhong.Location = New System.Drawing.Point(54, 184)
        Me.optPhong.Name = "optPhong"
        Me.optPhong.Size = New System.Drawing.Size(72, 25)
        Me.optPhong.TabIndex = 56
        Me.optPhong.TabStop = True
        Me.optPhong.Text = "Phòng"
        Me.optPhong.UseVisualStyleBackColor = False
        '
        'cmbID_phong
        '
        Me.cmbID_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_phong.Enabled = False
        Me.cmbID_phong.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_phong.Location = New System.Drawing.Point(127, 185)
        Me.cmbID_phong.Name = "cmbID_phong"
        Me.cmbID_phong.Size = New System.Drawing.Size(409, 24)
        Me.cmbID_phong.TabIndex = 7
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Enabled = False
        Me.cmbID_khoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_khoa.Location = New System.Drawing.Point(127, 215)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(409, 24)
        Me.cmbID_khoa.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(542, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 30)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "(*)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 24)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Họ và tên:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNhom
        '
        Me.cmbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhom.Items.AddRange(New Object() {"Lãnh đạo", "Chuyên Viên", "Cố vấn học tập"})
        Me.cmbNhom.Location = New System.Drawing.Point(127, 275)
        Me.cmbNhom.Name = "cmbNhom"
        Me.cmbNhom.Size = New System.Drawing.Size(409, 24)
        Me.cmbNhom.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 24)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Nhóm:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(542, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 30)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "(*)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(542, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 30)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "(*)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbKhong_Kich_Hoat)
        Me.GroupBox1.Controls.Add(Me.rbKich_hoat)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 53)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trạng thái"
        '
        'rbKhong_Kich_Hoat
        '
        Me.rbKhong_Kich_Hoat.Location = New System.Drawing.Point(260, 22)
        Me.rbKhong_Kich_Hoat.Name = "rbKhong_Kich_Hoat"
        Me.rbKhong_Kich_Hoat.Size = New System.Drawing.Size(143, 20)
        Me.rbKhong_Kich_Hoat.TabIndex = 1
        Me.rbKhong_Kich_Hoat.Text = "Không kích hoạt"
        Me.rbKhong_Kich_Hoat.UseVisualStyleBackColor = True
        '
        'rbKich_hoat
        '
        Me.rbKich_hoat.Checked = True
        Me.rbKich_hoat.Location = New System.Drawing.Point(34, 23)
        Me.rbKich_hoat.Name = "rbKich_hoat"
        Me.rbKich_hoat.Size = New System.Drawing.Size(112, 24)
        Me.rbKich_hoat.TabIndex = 0
        Me.rbKich_hoat.TabStop = True
        Me.rbKich_hoat.Text = "Kích hoạt"
        Me.rbKich_hoat.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 24)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Điện thoại:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDien_Thoai
        '
        Me.txtDien_Thoai.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDien_Thoai.Location = New System.Drawing.Point(127, 156)
        Me.txtDien_Thoai.MaxLength = 100
        Me.txtDien_Thoai.Name = "txtDien_Thoai"
        Me.txtDien_Thoai.Size = New System.Drawing.Size(146, 22)
        Me.txtDien_Thoai.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(295, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 24)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "E-mail:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(363, 156)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 22)
        Me.txtEmail.TabIndex = 6
        '
        'txtMAC
        '
        Me.txtMAC.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAC.Location = New System.Drawing.Point(318, 125)
        Me.txtMAC.MaxLength = 40
        Me.txtMAC.Name = "txtMAC"
        Me.txtMAC.Size = New System.Drawing.Size(218, 23)
        Me.txtMAC.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(279, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 24)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "MAC:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(127, 126)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(146, 23)
        Me.txtIP.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 24)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "IP:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(65, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 16)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Bộ môn:"
        '
        'frmESS_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 369)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMAC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDien_Thoai)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbNhom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LinkLDAP)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.cmbID_bm)
        Me.Controls.Add(Me.optKhoa)
        Me.Controls.Add(Me.optPhong)
        Me.Controls.Add(Me.cmbID_phong)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassWordTry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmESS_Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Người dùng"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassWordTry As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLDAP As System.Windows.Forms.LinkLabel
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents cmbID_bm As System.Windows.Forms.ComboBox
    Friend WithEvents optKhoa As System.Windows.Forms.RadioButton
    Friend WithEvents optPhong As System.Windows.Forms.RadioButton
    Friend WithEvents cmbID_phong As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbNhom As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbKhong_Kich_Hoat As System.Windows.Forms.RadioButton
    Friend WithEvents rbKich_hoat As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDien_Thoai As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMAC As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
