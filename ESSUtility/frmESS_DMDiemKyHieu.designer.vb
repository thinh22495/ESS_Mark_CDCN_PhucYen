﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DMDiemKyHieu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DMDiemKyHieu))
        Me.DataGridViewDM = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optKhongDiemTP = New System.Windows.Forms.CheckBox
        Me.rdbOption2 = New System.Windows.Forms.RadioButton
        Me.rdbOption1 = New System.Windows.Forms.RadioButton
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
        Me.DataGridViewDM.Size = New System.Drawing.Size(581, 303)
        Me.DataGridViewDM.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.optKhongDiemTP)
        Me.GroupBox1.Controls.Add(Me.rdbOption2)
        Me.GroupBox1.Controls.Add(Me.rdbOption1)
        Me.GroupBox1.Controls.Add(Me.LabelTen)
        Me.GroupBox1.Controls.Add(Me.LabelMa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 297)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(575, 99)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'optKhongDiemTP
        '
        Me.optKhongDiemTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optKhongDiemTP.AutoSize = True
        Me.optKhongDiemTP.Location = New System.Drawing.Point(322, 73)
        Me.optKhongDiemTP.Name = "optKhongDiemTP"
        Me.optKhongDiemTP.Size = New System.Drawing.Size(231, 20)
        Me.optKhongDiemTP.TabIndex = 92
        Me.optKhongDiemTP.Text = "Không tính điểm TP vào TBCMH"
        Me.optKhongDiemTP.UseVisualStyleBackColor = True
        '
        'rdbOption2
        '
        Me.rdbOption2.AutoSize = True
        Me.rdbOption2.Location = New System.Drawing.Point(160, 72)
        Me.rdbOption2.Name = "rdbOption2"
        Me.rdbOption2.Size = New System.Drawing.Size(78, 20)
        Me.rdbOption2.TabIndex = 91
        Me.rdbOption2.TabStop = True
        Me.rdbOption2.Text = "Có lý do"
        Me.rdbOption2.UseVisualStyleBackColor = True
        '
        'rdbOption1
        '
        Me.rdbOption1.AutoSize = True
        Me.rdbOption1.Location = New System.Drawing.Point(71, 72)
        Me.rdbOption1.Name = "rdbOption1"
        Me.rdbOption1.Size = New System.Drawing.Size(68, 20)
        Me.rdbOption1.TabIndex = 90
        Me.rdbOption1.TabStop = True
        Me.rdbOption1.Text = "Học lại"
        Me.rdbOption1.UseVisualStyleBackColor = True
        '
        'LabelTen
        '
        Me.LabelTen.AutoSize = True
        Me.LabelTen.Location = New System.Drawing.Point(6, 49)
        Me.LabelTen.Name = "LabelTen"
        Me.LabelTen.Size = New System.Drawing.Size(60, 16)
        Me.LabelTen.TabIndex = 89
        Me.LabelTen.Text = "Ý nghĩa:"
        '
        'LabelMa
        '
        Me.LabelMa.AutoSize = True
        Me.LabelMa.Location = New System.Drawing.Point(6, 23)
        Me.LabelMa.Name = "LabelMa"
        Me.LabelMa.Size = New System.Drawing.Size(59, 16)
        Me.LabelMa.TabIndex = 88
        Me.LabelMa.Text = "Ký hiệu:"
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
        Me.txtMa.Location = New System.Drawing.Point(71, 16)
        Me.txtMa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMa.MaxLength = 2
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(346, 23)
        Me.txtMa.TabIndex = 84
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTen.Location = New System.Drawing.Point(71, 42)
        Me.txtTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTen.MaxLength = 50
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(346, 23)
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
        Me.cmdEdit.Location = New System.Drawing.Point(297, 403)
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
        Me.cmdAdd.Location = New System.Drawing.Point(200, 403)
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
        Me.cmdCancel.Location = New System.Drawing.Point(394, 403)
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
        Me.cmdDelete.Location = New System.Drawing.Point(394, 403)
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
        Me.cmdClose.Location = New System.Drawing.Point(489, 403)
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
        Me.cmdSave.Location = New System.Drawing.Point(297, 403)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 30)
        Me.cmdSave.TabIndex = 254
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'frmESS_DMDiemKyHieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 442)
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
        Me.Name = "frmESS_DMDiemKyHieu"
        Me.Text = "frmESS_DMDiemKyHieu"
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
    Friend WithEvents rdbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents optKhongDiemTP As System.Windows.Forms.CheckBox
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
