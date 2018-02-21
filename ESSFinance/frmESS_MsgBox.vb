Imports System.Drawing.Drawing2D
Public Class frmESS_MsgBox
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblMSG As System.Windows.Forms.Label
    Friend WithEvents picExclame As System.Windows.Forms.PictureBox
    Friend WithEvents picQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents picCritical As System.Windows.Forms.PictureBox
    Friend WithEvents picInfo As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmESS_MsgBox))
        Me.lblMSG = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.picExclame = New System.Windows.Forms.PictureBox
        Me.picQuestion = New System.Windows.Forms.PictureBox
        Me.picCritical = New System.Windows.Forms.PictureBox
        Me.picInfo = New System.Windows.Forms.PictureBox
        Me.picIcon = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'lblMSG
        '
        Me.lblMSG.AllowDrop = True
        Me.lblMSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMSG.BackColor = System.Drawing.Color.Transparent
        Me.lblMSG.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSG.Location = New System.Drawing.Point(56, 8)
        Me.lblMSG.Name = "lblMSG"
        Me.lblMSG.Size = New System.Drawing.Size(360, 128)
        Me.lblMSG.TabIndex = 2
        Me.lblMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(90, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Firebrick
        Me.Button3.Location = New System.Drawing.Point(274, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 30)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Button3"
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Firebrick
        Me.Button2.Location = New System.Drawing.Point(182, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.Visible = False
        '
        'picExclame
        '
        Me.picExclame.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picExclame.BackColor = System.Drawing.Color.Transparent
        Me.picExclame.Image = CType(resources.GetObject("picExclame.Image"), System.Drawing.Image)
        Me.picExclame.Location = New System.Drawing.Point(16, 56)
        Me.picExclame.Name = "picExclame"
        Me.picExclame.Size = New System.Drawing.Size(32, 32)
        Me.picExclame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExclame.TabIndex = 4
        Me.picExclame.TabStop = False
        Me.picExclame.Visible = False
        '
        'picQuestion
        '
        Me.picQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picQuestion.BackColor = System.Drawing.Color.Transparent
        Me.picQuestion.Image = CType(resources.GetObject("picQuestion.Image"), System.Drawing.Image)
        Me.picQuestion.Location = New System.Drawing.Point(16, 56)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(32, 32)
        Me.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuestion.TabIndex = 5
        Me.picQuestion.TabStop = False
        Me.picQuestion.Visible = False
        '
        'picCritical
        '
        Me.picCritical.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picCritical.BackColor = System.Drawing.Color.Transparent
        Me.picCritical.Image = CType(resources.GetObject("picCritical.Image"), System.Drawing.Image)
        Me.picCritical.Location = New System.Drawing.Point(16, 56)
        Me.picCritical.Name = "picCritical"
        Me.picCritical.Size = New System.Drawing.Size(32, 32)
        Me.picCritical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCritical.TabIndex = 6
        Me.picCritical.TabStop = False
        Me.picCritical.Visible = False
        '
        'picInfo
        '
        Me.picInfo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picInfo.BackColor = System.Drawing.Color.Transparent
        Me.picInfo.Image = CType(resources.GetObject("picInfo.Image"), System.Drawing.Image)
        Me.picInfo.Location = New System.Drawing.Point(16, 56)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(32, 32)
        Me.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfo.TabIndex = 7
        Me.picInfo.TabStop = False
        Me.picInfo.Visible = False
        '
        'picIcon
        '
        Me.picIcon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picIcon.BackColor = System.Drawing.Color.Transparent
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(16, 56)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(32, 32)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 1
        Me.picIcon.TabStop = False
        '
        'frmESS_MsgBox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(444, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMSG)
        Me.Controls.Add(Me.picCritical)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.picExclame)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.picInfo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 40
        Me.DockPadding.Top = 10
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmESS_MsgBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Thông báo"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Tag = 1
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Tag = 2
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Tag = 3
        Me.Close()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter
        sender.Font = New Font("Arial", 10, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave
        sender.Font = New Font("Arial", 10)
    End Sub

    Private Sub frmESS_MsgBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
End Class
