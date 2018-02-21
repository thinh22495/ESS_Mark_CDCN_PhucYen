<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMHeSoHocPhi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DMHeSoHocPhi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOption3 = New System.Windows.Forms.TextBox
        Me.cmbOption0 = New System.Windows.Forms.ComboBox
        Me.LabelOption3 = New System.Windows.Forms.Label
        Me.LabelOption0 = New System.Windows.Forms.Label
        Me.txtOption2 = New System.Windows.Forms.TextBox
        Me.LabelOption2 = New System.Windows.Forms.Label
        Me.LabelOption1 = New System.Windows.Forms.Label
        Me.txtOption1 = New System.Windows.Forms.TextBox
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtOption3)
        Me.GroupBox1.Controls.Add(Me.cmbOption0)
        Me.GroupBox1.Controls.Add(Me.LabelOption3)
        Me.GroupBox1.Controls.Add(Me.LabelOption0)
        Me.GroupBox1.Controls.Add(Me.txtOption2)
        Me.GroupBox1.Controls.Add(Me.LabelOption2)
        Me.GroupBox1.Controls.Add(Me.LabelOption1)
        Me.GroupBox1.Controls.Add(Me.txtOption1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 277)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(510, 140)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(277, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 30)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(277, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 30)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(277, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 30)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(427, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOption3
        '
        Me.txtOption3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption3.Location = New System.Drawing.Point(132, 107)
        Me.txtOption3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption3.MaxLength = 7
        Me.txtOption3.Name = "txtOption3"
        Me.txtOption3.Size = New System.Drawing.Size(139, 23)
        Me.txtOption3.TabIndex = 86
        '
        'cmbOption0
        '
        Me.cmbOption0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption0.FormattingEnabled = True
        Me.cmbOption0.Location = New System.Drawing.Point(132, 14)
        Me.cmbOption0.Name = "cmbOption0"
        Me.cmbOption0.Size = New System.Drawing.Size(289, 24)
        Me.cmbOption0.TabIndex = 85
        '
        'LabelOption3
        '
        Me.LabelOption3.AutoSize = True
        Me.LabelOption3.Location = New System.Drawing.Point(10, 114)
        Me.LabelOption3.Name = "LabelOption3"
        Me.LabelOption3.Size = New System.Drawing.Size(65, 16)
        Me.LabelOption3.TabIndex = 88
        Me.LabelOption3.Text = "Ngành 2:"
        '
        'LabelOption0
        '
        Me.LabelOption0.AutoSize = True
        Me.LabelOption0.Location = New System.Drawing.Point(10, 22)
        Me.LabelOption0.Name = "LabelOption0"
        Me.LabelOption0.Size = New System.Drawing.Size(85, 16)
        Me.LabelOption0.TabIndex = 84
        Me.LabelOption0.Text = "Hệ đào tạo :"
        '
        'txtOption2
        '
        Me.txtOption2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption2.Location = New System.Drawing.Point(132, 76)
        Me.txtOption2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption2.MaxLength = 7
        Me.txtOption2.Name = "txtOption2"
        Me.txtOption2.Size = New System.Drawing.Size(139, 23)
        Me.txtOption2.TabIndex = 83
        '
        'LabelOption2
        '
        Me.LabelOption2.AutoSize = True
        Me.LabelOption2.Location = New System.Drawing.Point(10, 82)
        Me.LabelOption2.Name = "LabelOption2"
        Me.LabelOption2.Size = New System.Drawing.Size(118, 16)
        Me.LabelOption2.TabIndex = 85
        Me.LabelOption2.Text = "Ngoài ngân sách:"
        '
        'LabelOption1
        '
        Me.LabelOption1.AutoSize = True
        Me.LabelOption1.Location = New System.Drawing.Point(10, 52)
        Me.LabelOption1.Name = "LabelOption1"
        Me.LabelOption1.Size = New System.Drawing.Size(54, 16)
        Me.LabelOption1.TabIndex = 82
        Me.LabelOption1.Text = "Học lại:"
        '
        'txtOption1
        '
        Me.txtOption1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOption1.Location = New System.Drawing.Point(132, 45)
        Me.txtOption1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOption1.MaxLength = 7
        Me.txtOption1.Name = "txtOption1"
        Me.txtOption1.Size = New System.Drawing.Size(139, 23)
        Me.txtOption1.TabIndex = 76
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 1)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(524, 280)
        Me.DataGridViewDM.TabIndex = 32
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ImageIndex = 12
        Me.cmdEdit.ImageList = Me.ImgMain
        Me.cmdEdit.Location = New System.Drawing.Point(237, 424)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(89, 30)
        Me.cmdEdit.TabIndex = 258
        Me.cmdEdit.Text = "Sửa"
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
        Me.ImgMain.Images.SetKeyName(24, "2402.ico")
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(140, 424)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(89, 30)
        Me.cmdAdd.TabIndex = 261
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(429, 424)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(89, 30)
        Me.cmdClose.TabIndex = 257
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(237, 424)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 30)
        Me.cmdSave.TabIndex = 260
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.ImageIndex = 24
        Me.cmdCancel.ImageList = Me.ImgMain
        Me.cmdCancel.Location = New System.Drawing.Point(334, 424)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 30)
        Me.cmdCancel.TabIndex = 262
        Me.cmdCancel.Text = "Hủy"
        Me.cmdCancel.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(334, 424)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(89, 30)
        Me.cmdDelete.TabIndex = 259
        Me.cmdDelete.Text = "Xóa"
        '
        'frmESS_DMHeSoHocPhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 464)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DMHeSoHocPhi"
        Me.Text = "frmESS_DMHeSoHocPhi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents txtOption1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOption1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbOption0 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelOption0 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOption2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOption2 As System.Windows.Forms.Label
    Friend WithEvents txtOption3 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOption3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
End Class
