<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhomHocPhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhomHocPhan))
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelTen = New System.Windows.Forms.Label
        Me.LabelMa = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMa = New System.Windows.Forms.TextBox
        Me.txtTen = New System.Windows.Forms.TextBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvMonHoc = New System.Windows.Forms.DataGridView
        Me.ID_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd_HP = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRemove_HP = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMonHoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDM
        '
        Me.DataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDM.Location = New System.Drawing.Point(0, 83)
        Me.DataGridViewDM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewDM.Name = "DataGridViewDM"
        Me.DataGridViewDM.ReadOnly = True
        Me.DataGridViewDM.Size = New System.Drawing.Size(389, 490)
        Me.DataGridViewDM.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LabelTen)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(787, 73)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'LabelTen
        '
        Me.LabelTen.AutoSize = True
        Me.LabelTen.Location = New System.Drawing.Point(9, 42)
        Me.LabelTen.Name = "LabelTen"
        Me.LabelTen.Size = New System.Drawing.Size(57, 16)
        Me.LabelTen.TabIndex = 83
        Me.LabelTen.Text = "Tên hệ:"
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.Location = New System.Drawing.Point(15, 16)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(51, 16)
        Me.LabelMa.TabIndex = 82
        Me.LabelMa.Text = "Mã hệ:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(476, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 30)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "(*)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(322, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 30)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa
        '
        Me.txtMa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMa.Location = New System.Drawing.Point(163, 13)
        Me.txtMa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMa.MaxLength = 20
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(153, 23)
        Me.txtMa.TabIndex = 76
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTen.Location = New System.Drawing.Point(163, 39)
        Me.txtTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTen.MaxLength = 50
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(307, 23)
        Me.txtTen.TabIndex = 77
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvMonHoc
        '
        Me.dgvMonHoc.AllowUserToAddRows = False
        Me.dgvMonHoc.AllowUserToDeleteRows = False
        Me.dgvMonHoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonHoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_mon, Me.Ky_hieu, Me.Ten_mon})
        Me.dgvMonHoc.Location = New System.Drawing.Point(395, 83)
        Me.dgvMonHoc.Name = "dgvMonHoc"
        Me.dgvMonHoc.ReadOnly = True
        Me.dgvMonHoc.Size = New System.Drawing.Size(414, 490)
        Me.dgvMonHoc.TabIndex = 42
        '
        'ID_mon
        '
        Me.ID_mon.DataPropertyName = "ID_mon"
        Me.ID_mon.HeaderText = "ID môn"
        Me.ID_mon.Name = "ID_mon"
        Me.ID_mon.ReadOnly = True
        Me.ID_mon.Visible = False
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        Me.Ky_hieu.HeaderText = "Ký hiệu"
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 80
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.FillWeight = 250.0!
        Me.Ten_mon.HeaderText = "Tên môn"
        Me.Ten_mon.MinimumWidth = 250
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 250
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
        'cmdAdd_HP
        '
        Me.cmdAdd_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd_HP.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd_HP.Appearance.Options.UseFont = True
        Me.cmdAdd_HP.ImageIndex = 0
        Me.cmdAdd_HP.ImageList = Me.ImgMain
        Me.cmdAdd_HP.Location = New System.Drawing.Point(557, 580)
        Me.cmdAdd_HP.Name = "cmdAdd_HP"
        Me.cmdAdd_HP.Size = New System.Drawing.Size(121, 30)
        Me.cmdAdd_HP.TabIndex = 265
        Me.cmdAdd_HP.Text = "Thêm học phần"
        '
        'cmdRemove_HP
        '
        Me.cmdRemove_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove_HP.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove_HP.Appearance.Options.UseFont = True
        Me.cmdRemove_HP.ImageIndex = 4
        Me.cmdRemove_HP.ImageList = Me.ImgMain
        Me.cmdRemove_HP.Location = New System.Drawing.Point(684, 580)
        Me.cmdRemove_HP.Name = "cmdRemove_HP"
        Me.cmdRemove_HP.Size = New System.Drawing.Size(121, 30)
        Me.cmdRemove_HP.TabIndex = 264
        Me.cmdRemove_HP.Text = "Loại học phần"
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ImageIndex = 12
        Me.cmdEdit.ImageList = Me.ImgMain
        Me.cmdEdit.Location = New System.Drawing.Point(107, 580)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(89, 30)
        Me.cmdEdit.TabIndex = 267
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(10, 580)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(89, 30)
        Me.cmdAdd.TabIndex = 270
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(299, 580)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(89, 30)
        Me.cmdClose.TabIndex = 266
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(107, 580)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 30)
        Me.cmdSave.TabIndex = 269
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.ImageIndex = 24
        Me.cmdCancel.ImageList = Me.ImgMain
        Me.cmdCancel.Location = New System.Drawing.Point(204, 580)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 30)
        Me.cmdCancel.TabIndex = 271
        Me.cmdCancel.Text = "Hủy"
        Me.cmdCancel.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(204, 580)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(89, 30)
        Me.cmdDelete.TabIndex = 268
        Me.cmdDelete.Text = "Xóa"
        '
        'frmESS_NhomHocPhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 615)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdRemove_HP)
        Me.Controls.Add(Me.cmdAdd_HP)
        Me.Controls.Add(Me.dgvMonHoc)
        Me.Controls.Add(Me.DataGridViewDM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_NhomHocPhan"
        Me.Text = "frmESS_NhomHocPhan"
        CType(Me.DataGridViewDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMonHoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewDM As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTen As System.Windows.Forms.Label
    Friend WithEvents LabelMa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvMonHoc As System.Windows.Forms.DataGridView
    Friend WithEvents ID_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdRemove_HP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd_HP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
End Class
