<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMXepLoaiRenLuyen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DMXepLoaiRenLuyen))
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelMaEn = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMaEn = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LabelOther1 = New System.Windows.Forms.Label
        Me.txtHeSo = New System.Windows.Forms.TextBox
        Me.LabelOther = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDenDiem = New System.Windows.Forms.TextBox
        Me.LabelTen = New System.Windows.Forms.Label
        Me.LabelMa = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMa = New System.Windows.Forms.TextBox
        Me.txtTuDiem = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
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
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(566, 279)
        Me.DataGridViewDM.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LabelMaEn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaEn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LabelOther1)
        Me.GroupBox1.Controls.Add(Me.txtHeSo)
        Me.GroupBox1.Controls.Add(Me.LabelOther)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtDenDiem)
        Me.GroupBox1.Controls.Add(Me.LabelTen)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtTuDiem)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 277)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(551, 120)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'LabelMaEn
        '
        Me.LabelMaEn.AutoSize = True
        Me.LabelMaEn.Location = New System.Drawing.Point(6, 50)
        Me.LabelMaEn.Name = "LabelMaEn"
        Me.LabelMaEn.Size = New System.Drawing.Size(80, 16)
        Me.LabelMaEn.TabIndex = 98
        Me.LabelMaEn.Text = "Xếp loại RL"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(461, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 30)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaEn
        '
        Me.txtMaEn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMaEn.Location = New System.Drawing.Point(127, 43)
        Me.txtMaEn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMaEn.MaxLength = 50
        Me.txtMaEn.Name = "txtMaEn"
        Me.txtMaEn.Size = New System.Drawing.Size(328, 23)
        Me.txtMaEn.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(325, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 30)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelOther1
        '
        Me.LabelOther1.AutoSize = True
        Me.LabelOther1.Location = New System.Drawing.Point(368, 76)
        Me.LabelOther1.Name = "LabelOther1"
        Me.LabelOther1.Size = New System.Drawing.Size(44, 16)
        Me.LabelOther1.TabIndex = 94
        Me.LabelOther1.Text = "Hệ số"
        '
        'txtHeSo
        '
        Me.txtHeSo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtHeSo.Location = New System.Drawing.Point(419, 69)
        Me.txtHeSo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHeSo.MaxLength = 4
        Me.txtHeSo.Name = "txtHeSo"
        Me.txtHeSo.Size = New System.Drawing.Size(36, 23)
        Me.txtHeSo.TabIndex = 93
        '
        'LabelOther
        '
        Me.LabelOther.AutoSize = True
        Me.LabelOther.Location = New System.Drawing.Point(209, 76)
        Me.LabelOther.Name = "LabelOther"
        Me.LabelOther.Size = New System.Drawing.Size(68, 16)
        Me.LabelOther.TabIndex = 92
        Me.LabelOther.Text = "Đến điểm"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(458, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 30)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDenDiem
        '
        Me.TxtDenDiem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtDenDiem.Location = New System.Drawing.Point(283, 69)
        Me.TxtDenDiem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDenDiem.MaxLength = 4
        Me.TxtDenDiem.Name = "TxtDenDiem"
        Me.TxtDenDiem.Size = New System.Drawing.Size(36, 23)
        Me.TxtDenDiem.TabIndex = 90
        '
        'LabelTen
        '
        Me.LabelTen.AutoSize = True
        Me.LabelTen.Location = New System.Drawing.Point(6, 76)
        Me.LabelTen.Name = "LabelTen"
        Me.LabelTen.Size = New System.Drawing.Size(60, 16)
        Me.LabelTen.TabIndex = 89
        Me.LabelTen.Text = "Từ điểm"
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.Location = New System.Drawing.Point(6, 23)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(80, 16)
        Me.LabelMa.TabIndex = 88
        Me.LabelMa.Text = "Xếp loại RL"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(164, 65)
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
        Me.Label16.Location = New System.Drawing.Point(461, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 30)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa
        '
        Me.txtMa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMa.Location = New System.Drawing.Point(127, 16)
        Me.txtMa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMa.MaxLength = 50
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(328, 23)
        Me.txtMa.TabIndex = 84
        '
        'txtTuDiem
        '
        Me.txtTuDiem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTuDiem.Location = New System.Drawing.Point(127, 69)
        Me.txtTuDiem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTuDiem.MaxLength = 4
        Me.txtTuDiem.Name = "txtTuDiem"
        Me.txtTuDiem.Size = New System.Drawing.Size(34, 23)
        Me.txtTuDiem.TabIndex = 85
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
        Me.cmdEdit.Location = New System.Drawing.Point(279, 404)
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
        Me.cmdAdd.Location = New System.Drawing.Point(182, 404)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(89, 30)
        Me.cmdAdd.TabIndex = 255
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(471, 404)
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
        Me.cmdSave.Location = New System.Drawing.Point(279, 404)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 30)
        Me.cmdSave.TabIndex = 254
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.ImageIndex = 24
        Me.cmdCancel.ImageList = Me.ImgMain
        Me.cmdCancel.Location = New System.Drawing.Point(376, 404)
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
        Me.cmdDelete.Location = New System.Drawing.Point(376, 404)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(89, 30)
        Me.cmdDelete.TabIndex = 253
        Me.cmdDelete.Text = "Xóa"
        '
        'frmESS_DMXepLoaiRenLuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 443)
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
        Me.Name = "frmESS_DMXepLoaiRenLuyen"
        Me.Text = "frmESS_DMXepLoaiRenLuyen"
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
    Friend WithEvents LabelOther As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDenDiem As System.Windows.Forms.TextBox
    Friend WithEvents txtTuDiem As System.Windows.Forms.TextBox
    Friend WithEvents LabelOther1 As System.Windows.Forms.Label
    Friend WithEvents txtHeSo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelMaEn As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaEn As System.Windows.Forms.TextBox
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
End Class
