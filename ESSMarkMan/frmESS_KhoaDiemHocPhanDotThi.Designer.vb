<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhoaDiemHocPhanDotThi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhoaDiemHocPhanDotThi))
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdUnLock = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkNot_show_all
        '
        Me.chkNot_show_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNot_show_all.BackColor = System.Drawing.Color.Transparent
        Me.chkNot_show_all.Checked = True
        Me.chkNot_show_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNot_show_all.Location = New System.Drawing.Point(264, 0)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(514, 23)
        Me.chkNot_show_all.TabIndex = 106
        Me.chkNot_show_all.Text = "Khi nhập điểm thi từ lần 2 trở đi chỉ hiển thị những sinh viên có điểm thi <5"
        Me.chkNot_show_all.UseVisualStyleBackColor = False
        Me.chkNot_show_all.Visible = False
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(-3, 0)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 566)
        Me.trvPhongThi.TabIndex = 108
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
        Me.grdViewDiem.Location = New System.Drawing.Point(263, 22)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.ReadOnly = True
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(524, 504)
        Me.grdViewDiem.TabIndex = 107
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
        Me.cmdClose.Location = New System.Drawing.Point(684, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 30)
        Me.cmdClose.TabIndex = 168
        Me.cmdClose.Text = "Thoát"
        '
        'cmdUnLock
        '
        Me.cmdUnLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUnLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnLock.Appearance.Options.UseFont = True
        Me.cmdUnLock.ImageIndex = 23
        Me.cmdUnLock.ImageList = Me.ImgMain
        Me.cmdUnLock.Location = New System.Drawing.Point(575, 532)
        Me.cmdUnLock.Name = "cmdUnLock"
        Me.cmdUnLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdUnLock.TabIndex = 168
        Me.cmdUnLock.Text = "Mở khóa điểm"
        '
        'cmdLock
        '
        Me.cmdLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLock.Appearance.Options.UseFont = True
        Me.cmdLock.ImageIndex = 22
        Me.cmdLock.ImageList = Me.ImgMain
        Me.cmdLock.Location = New System.Drawing.Point(466, 532)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdLock.TabIndex = 168
        Me.cmdLock.Text = "Khóa điểm"
        '
        'frmESS_KhoaDiemHocPhanDotThi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.cmdUnLock)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmESS_KhoaDiemHocPhanDotThi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KHOA DIEM HOC PHAN THEO DOT THI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUnLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
End Class
