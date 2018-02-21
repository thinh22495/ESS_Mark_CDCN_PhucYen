<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMHeDaoTao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DMHeDaoTao))
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtTen = New System.Windows.Forms.TextBox
        Me.txtMa = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelMa = New System.Windows.Forms.Label
        Me.LabelTen = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTenEn = New System.Windows.Forms.TextBox
        Me.LabelTenEn = New System.Windows.Forms.Label
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.DataGridViewDM.Size = New System.Drawing.Size(566, 285)
        Me.DataGridViewDM.TabIndex = 35
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTen.Location = New System.Drawing.Point(113, 43)
        Me.txtTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTen.MaxLength = 50
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(375, 23)
        Me.txtTen.TabIndex = 77
        '
        'txtMa
        '
        Me.txtMa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMa.Location = New System.Drawing.Point(113, 17)
        Me.txtMa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMa.MaxLength = 20
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(221, 23)
        Me.txtMa.TabIndex = 76
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(349, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 30)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(500, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 30)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.BackColor = System.Drawing.Color.Transparent
        Me.LabelMa.Location = New System.Drawing.Point(12, 20)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(51, 16)
        Me.LabelMa.TabIndex = 82
        Me.LabelMa.Text = "Mã hệ:"
        '
        'LabelTen
        '
        Me.LabelTen.AutoSize = True
        Me.LabelTen.BackColor = System.Drawing.Color.Transparent
        Me.LabelTen.Location = New System.Drawing.Point(6, 46)
        Me.LabelTen.Name = "LabelTen"
        Me.LabelTen.Size = New System.Drawing.Size(57, 16)
        Me.LabelTen.TabIndex = 83
        Me.LabelTen.Text = "Tên hệ:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtTenEn)
        Me.GroupBox1.Controls.Add(Me.LabelTen)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(Me.LabelTenEn)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 282)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(557, 100)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'txtTenEn
        '
        Me.txtTenEn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTenEn.Location = New System.Drawing.Point(113, 69)
        Me.txtTenEn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTenEn.MaxLength = 50
        Me.txtTenEn.Name = "txtTenEn"
        Me.txtTenEn.Size = New System.Drawing.Size(375, 23)
        Me.txtTenEn.TabIndex = 84
        '
        'LabelTenEn
        '
        Me.LabelTenEn.AutoSize = True
        Me.LabelTenEn.BackColor = System.Drawing.Color.Transparent
        Me.LabelTenEn.Location = New System.Drawing.Point(6, 72)
        Me.LabelTenEn.Name = "LabelTenEn"
        Me.LabelTenEn.Size = New System.Drawing.Size(100, 16)
        Me.LabelTenEn.TabIndex = 86
        Me.LabelTenEn.Text = "Tên tiếng anh:"
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ImageIndex = 12
        Me.cmdEdit.ImageList = Me.ImgMain
        Me.cmdEdit.Location = New System.Drawing.Point(281, 389)
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
        Me.cmdAdd.Location = New System.Drawing.Point(184, 389)
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
        Me.cmdCancel.Location = New System.Drawing.Point(378, 389)
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
        Me.cmdDelete.Location = New System.Drawing.Point(378, 389)
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
        Me.cmdClose.Location = New System.Drawing.Point(473, 389)
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
        Me.cmdSave.Location = New System.Drawing.Point(281, 389)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 30)
        Me.cmdSave.TabIndex = 254
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'frmESS_DMHeDaoTao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 429)
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
        Me.Name = "frmESS_DMHeDaoTao"
        Me.Text = "frmESS_DMHeDaoTao"
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTen As System.Windows.Forms.Label
    Friend WithEvents LabelMa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtTenEn As System.Windows.Forms.TextBox
    Friend WithEvents LabelTenEn As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class

