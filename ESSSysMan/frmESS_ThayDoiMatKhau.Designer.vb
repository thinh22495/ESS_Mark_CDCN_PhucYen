<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThayDoiMatKhau
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPassWordNew = New System.Windows.Forms.TextBox
        Me.txtPasswordOld = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPassWordReNew = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
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
        Me.ToolStrip.Size = New System.Drawing.Size(343, 25)
        Me.ToolStrip.TabIndex = 22
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
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(305, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 23)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(305, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 23)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassWordNew
        '
        Me.txtPassWordNew.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWordNew.Location = New System.Drawing.Point(136, 71)
        Me.txtPassWordNew.Name = "txtPassWordNew"
        Me.txtPassWordNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWordNew.Size = New System.Drawing.Size(161, 23)
        Me.txtPassWordNew.TabIndex = 89
        '
        'txtPasswordOld
        '
        Me.txtPasswordOld.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordOld.Location = New System.Drawing.Point(136, 42)
        Me.txtPasswordOld.Name = "txtPasswordOld"
        Me.txtPasswordOld.Size = New System.Drawing.Size(161, 23)
        Me.txtPasswordOld.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Mật khẩu mới:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 23)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Mật khẩu cũ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassWordReNew
        '
        Me.txtPassWordReNew.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWordReNew.Location = New System.Drawing.Point(136, 100)
        Me.txtPassWordReNew.Name = "txtPassWordReNew"
        Me.txtPassWordReNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWordReNew.Size = New System.Drawing.Size(161, 23)
        Me.txtPassWordReNew.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 23)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Nhập lại mật khẩu:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(305, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 23)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "(*)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmESS_ThayDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 146)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassWordReNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassWordNew)
        Me.Controls.Add(Me.txtPasswordOld)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ThayDoiMatKhau"
        Me.Text = "Thay đổi mật khẩu"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassWordNew As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordOld As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassWordReNew As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
