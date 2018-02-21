<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ChonTruongHienThi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ChonTruongHienThi))
        Me.lsvDanh_sach = New System.Windows.Forms.ListView
        Me.trvFields = New System.Windows.Forms.TreeView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdUp = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDown = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsvDanh_sach
        '
        Me.lsvDanh_sach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvDanh_sach.FullRowSelect = True
        Me.lsvDanh_sach.GridLines = True
        Me.lsvDanh_sach.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsvDanh_sach.Location = New System.Drawing.Point(3, 16)
        Me.lsvDanh_sach.MultiSelect = False
        Me.lsvDanh_sach.Name = "lsvDanh_sach"
        Me.lsvDanh_sach.Size = New System.Drawing.Size(243, 419)
        Me.lsvDanh_sach.TabIndex = 1
        Me.lsvDanh_sach.UseCompatibleStateImageBehavior = False
        Me.lsvDanh_sach.View = System.Windows.Forms.View.Details
        '
        'trvFields
        '
        Me.trvFields.CheckBoxes = True
        Me.trvFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvFields.Location = New System.Drawing.Point(3, 16)
        Me.trvFields.Name = "trvFields"
        Me.trvFields.Size = New System.Drawing.Size(233, 419)
        Me.trvFields.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvDanh_sach)
        Me.GroupBox1.Location = New System.Drawing.Point(306, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 438)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách nhóm trường chọn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.trvFields)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 438)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhóm trường"
        '
        'cmdUp
        '
        Me.cmdUp.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUp.Appearance.Options.UseFont = True
        Me.cmdUp.Location = New System.Drawing.Point(246, 192)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(57, 25)
        Me.cmdUp.TabIndex = 31
        Me.cmdUp.Text = "Lên"
        '
        'cmdDown
        '
        Me.cmdDown.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDown.Appearance.Options.UseFont = True
        Me.cmdDown.Location = New System.Drawing.Point(246, 231)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(57, 25)
        Me.cmdDown.TabIndex = 31
        Me.cmdDown.Text = "Xuống"
        '
        'cmdSave
        '
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.Location = New System.Drawing.Point(396, 447)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 32
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.Location = New System.Drawing.Point(477, 447)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 32
        Me.cmdClose.Text = "Thoát"
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
        '
        'frmESS_HienThiTruong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 477)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmESS_HienThiTruong"
        Me.Text = "frmESS_HienThiTruong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvDanh_sach As System.Windows.Forms.ListView
    Friend WithEvents trvFields As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
End Class
