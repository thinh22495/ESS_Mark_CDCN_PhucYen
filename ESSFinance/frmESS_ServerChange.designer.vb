<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ServerChange
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
        Me.txtURL = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDatabaseName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtServerName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbdbType = New System.Windows.Forms.ComboBox
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCheck = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.chkProxy = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(169, 138)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(316, 23)
        Me.txtURL.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(0, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "URL cập nhật phiên bản:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(45, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Loại CSDL :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Location = New System.Drawing.Point(169, 75)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(316, 23)
        Me.txtDatabaseName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(14, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tên CSDL ESSSoft :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(169, 44)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(316, 23)
        Me.txtServerName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên máy chủ CSDL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbdbType
        '
        Me.cmbdbType.Items.AddRange(New Object() {"SQL Server 2000", "Oracle 9i"})
        Me.cmbdbType.Location = New System.Drawing.Point(169, 106)
        Me.cmbdbType.Name = "cmbdbType"
        Me.cmbdbType.Size = New System.Drawing.Size(316, 24)
        Me.cmbdbType.TabIndex = 3
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdCheck, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(500, 25)
        Me.ToolStrip.TabIndex = 38
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdCheck
        '
        Me.cmdCheck.Image = Global.ESSFinance.My.Resources.Resources.KiemTraKetNoi
        Me.cmdCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(126, 22)
        Me.cmdCheck.Text = "Kiểm tra kết nối"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(169, 192)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(316, 23)
        Me.txtAddress.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Port:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(169, 221)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(316, 23)
        Me.txtPort.TabIndex = 7
        '
        'chkProxy
        '
        Me.chkProxy.AutoSize = True
        Me.chkProxy.BackColor = System.Drawing.Color.Transparent
        Me.chkProxy.Location = New System.Drawing.Point(169, 168)
        Me.chkProxy.Name = "chkProxy"
        Me.chkProxy.Size = New System.Drawing.Size(120, 20)
        Me.chkProxy.TabIndex = 5
        Me.chkProxy.Text = "Sử dụng Proxy"
        Me.chkProxy.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Username:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(169, 250)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(316, 23)
        Me.txtUsername.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Password:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(169, 279)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(316, 23)
        Me.txtPass.TabIndex = 9
        Me.txtPass.UseSystemPasswordChar = True
        '
        'frmESS_ServerChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 308)
        Me.Controls.Add(Me.chkProxy)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ToolStrip)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ServerChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_ServerChange"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
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
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents chkProxy As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
End Class
