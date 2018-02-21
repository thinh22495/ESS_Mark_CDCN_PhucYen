<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMDiemQuyDoi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DMDiemQuyDoi))
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkOther3 = New System.Windows.Forms.CheckBox
        Me.LabelOther2 = New System.Windows.Forms.Label
        Me.txtOther2 = New System.Windows.Forms.TextBox
        Me.LabelOther = New System.Windows.Forms.Label
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.LabelOther1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOther1 = New System.Windows.Forms.TextBox
        Me.LabelTen = New System.Windows.Forms.Label
        Me.LabelMa = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMa = New System.Windows.Forms.TextBox
        Me.txtTen = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, -1)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(566, 266)
        Me.DataGridViewDM.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkOther3)
        Me.GroupBox1.Controls.Add(Me.LabelOther2)
        Me.GroupBox1.Controls.Add(Me.txtOther2)
        Me.GroupBox1.Controls.Add(Me.LabelOther)
        Me.GroupBox1.Controls.Add(Me.txtOther)
        Me.GroupBox1.Controls.Add(Me.LabelOther1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOther1)
        Me.GroupBox1.Controls.Add(Me.LabelTen)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 264)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(559, 125)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(-229, 108)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(131, 20)
        Me.CheckBox2.TabIndex = 100
        Me.CheckBox2.Text = "Tính điểm tích lỹ"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(177, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(177, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 30)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "(*)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkOther3
        '
        Me.chkOther3.AutoSize = True
        Me.chkOther3.Location = New System.Drawing.Point(6, 101)
        Me.chkOther3.Name = "chkOther3"
        Me.chkOther3.Size = New System.Drawing.Size(131, 20)
        Me.chkOther3.TabIndex = 97
        Me.chkOther3.Text = "Tính điểm tích lỹ"
        Me.chkOther3.UseVisualStyleBackColor = True
        '
        'LabelOther2
        '
        Me.LabelOther2.AutoSize = True
        Me.LabelOther2.Location = New System.Drawing.Point(275, 75)
        Me.LabelOther2.Name = "LabelOther2"
        Me.LabelOther2.Size = New System.Drawing.Size(68, 16)
        Me.LabelOther2.TabIndex = 96
        Me.LabelOther2.Text = "Đến điểm"
        '
        'txtOther2
        '
        Me.txtOther2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOther2.Location = New System.Drawing.Point(349, 68)
        Me.txtOther2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOther2.MaxLength = 50
        Me.txtOther2.Name = "txtOther2"
        Me.txtOther2.Size = New System.Drawing.Size(69, 23)
        Me.txtOther2.TabIndex = 95
        '
        'LabelOther
        '
        Me.LabelOther.AutoSize = True
        Me.LabelOther.Location = New System.Drawing.Point(275, 49)
        Me.LabelOther.Name = "LabelOther"
        Me.LabelOther.Size = New System.Drawing.Size(59, 16)
        Me.LabelOther.TabIndex = 94
        Me.LabelOther.Text = "Điểm số"
        '
        'txtOther
        '
        Me.txtOther.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOther.Location = New System.Drawing.Point(349, 42)
        Me.txtOther.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOther.MaxLength = 20
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(69, 23)
        Me.txtOther.TabIndex = 93
        '
        'LabelOther1
        '
        Me.LabelOther1.AutoSize = True
        Me.LabelOther1.Location = New System.Drawing.Point(6, 75)
        Me.LabelOther1.Name = "LabelOther1"
        Me.LabelOther1.Size = New System.Drawing.Size(60, 16)
        Me.LabelOther1.TabIndex = 92
        Me.LabelOther1.Text = "Từ điểm"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(423, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 30)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOther1
        '
        Me.txtOther1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOther1.Location = New System.Drawing.Point(102, 68)
        Me.txtOther1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOther1.MaxLength = 50
        Me.txtOther1.Name = "txtOther1"
        Me.txtOther1.Size = New System.Drawing.Size(69, 23)
        Me.txtOther1.TabIndex = 90
        '
        'LabelTen
        '
        Me.LabelTen.AutoSize = True
        Me.LabelTen.Location = New System.Drawing.Point(6, 49)
        Me.LabelTen.Name = "LabelTen"
        Me.LabelTen.Size = New System.Drawing.Size(68, 16)
        Me.LabelTen.TabIndex = 89
        Me.LabelTen.Text = "Điểm chữ"
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.Location = New System.Drawing.Point(6, 23)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(63, 16)
        Me.LabelMa.TabIndex = 88
        Me.LabelMa.Text = "Xếp Loại"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(423, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 30)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(423, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 30)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa
        '
        Me.txtMa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMa.Location = New System.Drawing.Point(102, 16)
        Me.txtMa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMa.MaxLength = 20
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(316, 23)
        Me.txtMa.TabIndex = 84
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTen.Location = New System.Drawing.Point(102, 42)
        Me.txtTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTen.MaxLength = 50
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(69, 23)
        Me.txtTen.TabIndex = 85
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
        Me.cmdEdit.Location = New System.Drawing.Point(283, 396)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(89, 30)
        Me.cmdEdit.TabIndex = 252
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
        Me.cmdAdd.Location = New System.Drawing.Point(186, 396)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(89, 30)
        Me.cmdAdd.TabIndex = 255
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.ImageIndex = 24
        Me.cmdCancel.ImageList = Me.ImgMain
        Me.cmdCancel.Location = New System.Drawing.Point(380, 396)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 30)
        Me.cmdCancel.TabIndex = 256
        Me.cmdCancel.Text = "Hủy"
        Me.cmdCancel.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(380, 396)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(89, 30)
        Me.cmdDelete.TabIndex = 253
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(475, 396)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(89, 30)
        Me.cmdClose.TabIndex = 251
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(283, 396)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 30)
        Me.cmdSave.TabIndex = 254
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'frmESS_DMDiemQuyDoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 433)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DMDiemQuyDoi"
        Me.Text = "frmESS_DMDiemQuyDoi"
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelTen As System.Windows.Forms.Label
    Friend WithEvents LabelMa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents LabelOther1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOther1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelOther As System.Windows.Forms.Label
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents chkOther3 As System.Windows.Forms.CheckBox
    Friend WithEvents LabelOther2 As System.Windows.Forms.Label
    Friend WithEvents txtOther2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
