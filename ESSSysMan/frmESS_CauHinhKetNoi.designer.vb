<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_CauHinhKetNoi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_CauHinhKetNoi))
        Me.txtURL = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDatabaseName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtServerName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbdbType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.chkProxy = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdCheckConnected = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(172, 139)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(316, 23)
        Me.txtURL.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(3, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "URL cập nhật phiên bản:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(48, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Loại CSDL :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Location = New System.Drawing.Point(172, 76)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(316, 23)
        Me.txtDatabaseName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tên CSDL ESSoft :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(172, 45)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(316, 23)
        Me.txtServerName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên máy chủ CSDL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbdbType
        '
        Me.cmbdbType.Items.AddRange(New Object() {"SQL Server 2005", "Oracle 9i"})
        Me.cmbdbType.Location = New System.Drawing.Point(172, 107)
        Me.cmbdbType.Name = "cmbdbType"
        Me.cmbdbType.Size = New System.Drawing.Size(316, 24)
        Me.cmbdbType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(172, 193)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(316, 23)
        Me.txtAddress.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Port:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(172, 222)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(316, 23)
        Me.txtPort.TabIndex = 7
        '
        'chkProxy
        '
        Me.chkProxy.AutoSize = True
        Me.chkProxy.BackColor = System.Drawing.Color.Transparent
        Me.chkProxy.Location = New System.Drawing.Point(172, 169)
        Me.chkProxy.Name = "chkProxy"
        Me.chkProxy.Size = New System.Drawing.Size(120, 20)
        Me.chkProxy.TabIndex = 5
        Me.chkProxy.Text = "Sử dụng Proxy"
        Me.chkProxy.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(15, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Username:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(172, 251)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(316, 23)
        Me.txtUsername.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(15, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Password:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(172, 280)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(316, 23)
        Me.txtPass.TabIndex = 9
        Me.txtPass.UseSystemPasswordChar = True
        '
        'cmdSave
        '
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(172, 309)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 30)
        Me.cmdSave.TabIndex = 16
        Me.cmdSave.Text = "Lưu"
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
        'cmdCheckConnected
        '
        Me.cmdCheckConnected.ImageIndex = 20
        Me.cmdCheckConnected.ImageList = Me.ImgMain
        Me.cmdCheckConnected.Location = New System.Drawing.Point(266, 309)
        Me.cmdCheckConnected.Name = "cmdCheckConnected"
        Me.cmdCheckConnected.Size = New System.Drawing.Size(128, 30)
        Me.cmdCheckConnected.TabIndex = 16
        Me.cmdCheckConnected.Text = "Kiểm tra kết nối"
        '
        'cmdClose
        '
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(400, 309)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 30)
        Me.cmdClose.TabIndex = 16
        Me.cmdClose.Text = "Thoát"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(154, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(201, 19)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "CẤU HÌNH CƠ SỞ DỮ LIỆU"
        '
        'frmESS_ServerChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 342)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCheckConnected)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.chkProxy)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDatabaseName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbdbType)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ServerChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAU HINH CO SO DU LIEU"
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbdbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents chkProxy As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCheckConnected As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
