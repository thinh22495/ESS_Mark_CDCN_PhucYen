<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DangNhap))
        Me.txtPassWord = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdConfig = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLogin = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassWord
        '
        Me.txtPassWord.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWord.Location = New System.Drawing.Point(134, 97)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(161, 23)
        Me.txtPassWord.TabIndex = 5
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(134, 60)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(161, 23)
        Me.txtUserName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mật khẩu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tên đăng nhập:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(303, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 22)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(303, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 22)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(255, 130)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(116, 28)
        Me.cmdClose.TabIndex = 8
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
        'cmdConfig
        '
        Me.cmdConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfig.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfig.Appearance.Options.UseFont = True
        Me.cmdConfig.ImageIndex = 8
        Me.cmdConfig.ImageList = Me.ImgMain
        Me.cmdConfig.Location = New System.Drawing.Point(128, 130)
        Me.cmdConfig.Name = "cmdConfig"
        Me.cmdConfig.Size = New System.Drawing.Size(122, 28)
        Me.cmdConfig.TabIndex = 7
        Me.cmdConfig.Text = "Cấu hình CSDL"
        '
        'cmdLogin
        '
        Me.cmdLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLogin.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Appearance.Options.UseFont = True
        Me.cmdLogin.ImageIndex = 17
        Me.cmdLogin.ImageList = Me.ImgMain
        Me.cmdLogin.Location = New System.Drawing.Point(1, 130)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(122, 28)
        Me.cmdLogin.TabIndex = 6
        Me.cmdLogin.Text = "Đăng nhập"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(101, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(183, 19)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ĐĂNG NHẬP HỆ THỐNG"
        '
        'frmESS_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 159)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.cmdConfig)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "DANG NHAP"
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdConfig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
