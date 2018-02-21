<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiemTu_Excel_TheoSBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiemTu_Excel_TheoSBD))
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.cmdOpen = New System.Windows.Forms.Button
        Me.lblCot_diem = New System.Windows.Forms.Label
        Me.lblCot_ma = New System.Windows.Forms.Label
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox
        Me.cmbCot_ma = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.cmbFont = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        Me.cmdConvertFont = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbChonFile
        '
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(366, 25)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(168, 24)
        Me.cmbChonFile.TabIndex = 36
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.BackColor = System.Drawing.Color.Transparent
        Me.lblBang_tinh.Location = New System.Drawing.Point(268, 24)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 39
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOpen
        '
        Me.cmdOpen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpen.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.ForeColor = System.Drawing.Color.Brown
        Me.cmdOpen.Image = Global.ESSMarkMan.My.Resources.Resources.Folder
        Me.cmdOpen.Location = New System.Drawing.Point(540, 25)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(34, 25)
        Me.cmdOpen.TabIndex = 37
        Me.cmdOpen.UseVisualStyleBackColor = False
        '
        'lblCot_diem
        '
        Me.lblCot_diem.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_diem.Location = New System.Drawing.Point(6, 55)
        Me.lblCot_diem.Name = "lblCot_diem"
        Me.lblCot_diem.Size = New System.Drawing.Size(146, 17)
        Me.lblCot_diem.TabIndex = 46
        Me.lblCot_diem.Text = "Chọn cột dữ liệu điểm"
        Me.lblCot_diem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCot_ma
        '
        Me.lblCot_ma.BackColor = System.Drawing.Color.Transparent
        Me.lblCot_ma.Location = New System.Drawing.Point(6, 15)
        Me.lblCot_ma.Name = "lblCot_ma"
        Me.lblCot_ma.Size = New System.Drawing.Size(142, 19)
        Me.lblCot_ma.TabIndex = 45
        Me.lblCot_ma.Text = "SBD sinh viên"
        Me.lblCot_ma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(6, 72)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(180, 24)
        Me.cmbCot_diem.TabIndex = 44
        '
        'cmbCot_ma
        '
        Me.cmbCot_ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_ma.Location = New System.Drawing.Point(6, 31)
        Me.cmbCot_ma.Name = "cmbCot_ma"
        Me.cmbCot_ma.Size = New System.Drawing.Size(180, 24)
        Me.cmbCot_ma.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbCot_ma)
        Me.GroupBox2.Controls.Add(Me.lblCot_diem)
        Me.GroupBox2.Controls.Add(Me.lblCot_ma)
        Me.GroupBox2.Controls.Add(Me.cmbCot_diem)
        Me.GroupBox2.Location = New System.Drawing.Point(593, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 99)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chọn cột SBD và điểm thi"
        '
        'grdViewDiem
        '
        Me.grdViewDiem.AllowUserToAddRows = False
        Me.grdViewDiem.AllowUserToDeleteRows = False
        Me.grdViewDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDiem.Location = New System.Drawing.Point(261, 102)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.ReadOnly = True
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(530, 425)
        Me.grdViewDiem.TabIndex = 87
        '
        'cmbFont
        '
        Me.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFont.Location = New System.Drawing.Point(366, 55)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(221, 24)
        Me.cmbFont.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(258, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 17)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Chọn Font chữ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, -1)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(259, 572)
        Me.trvPhongThi.TabIndex = 105
        '
        'cmdConvertFont
        '
        Me.cmdConvertFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConvertFont.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConvertFont.Appearance.Options.UseFont = True
        Me.cmdConvertFont.ImageIndex = 3
        Me.cmdConvertFont.ImageList = Me.ImgMain
        Me.cmdConvertFont.Location = New System.Drawing.Point(381, 533)
        Me.cmdConvertFont.Name = "cmdConvertFont"
        Me.cmdConvertFont.Size = New System.Drawing.Size(158, 30)
        Me.cmdConvertFont.TabIndex = 177
        Me.cmdConvertFont.Text = "Chuyển Font Unicode"
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
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(673, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(118, 30)
        Me.cmdClose.TabIndex = 179
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(549, 533)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 30)
        Me.cmdSave.TabIndex = 178
        Me.cmdSave.Text = "Lưu"
        '
        'frmESS_NhapDiemExcel_SBD
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdConvertFont)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.cmbFont)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.cmbChonFile)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.lblBang_tinh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_NhapDiemExcel_SBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHAP DIEM THI THEO SBD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents lblCot_ma As System.Windows.Forms.Label
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCot_ma As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFont As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents cmdConvertFont As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
