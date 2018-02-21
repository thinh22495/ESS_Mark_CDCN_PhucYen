<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhoaDulieuDiemThiLopTinChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhoaDulieuDiemThiLopTinChi))
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.trvLopTinChi = New ESSMarkMan.TreeViewLopTinChi
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdUnLock = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Location = New System.Drawing.Point(729, 1)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(66, 24)
        Me.cmbLan_thi.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(668, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvLopTinChi
        '
        Me.trvLopTinChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLopTinChi.BackColor = System.Drawing.Color.Transparent
        Me.trvLopTinChi.dsID_lop_tc = ""
        Me.trvLopTinChi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLopTinChi.ID_lop_tc = 0
        Me.trvLopTinChi.ID_mon = 0
        Me.trvLopTinChi.ID_mon_tc = 0
        Me.trvLopTinChi.ID_mon_tc_thi = 0
        Me.trvLopTinChi.Location = New System.Drawing.Point(3, 1)
        Me.trvLopTinChi.Name = "trvLopTinChi"
        Me.trvLopTinChi.Size = New System.Drawing.Size(264, 567)
        Me.trvLopTinChi.TabIndex = 106
        Me.trvLopTinChi.Ten_lop_tc = ""
        Me.trvLopTinChi.Ten_mon = ""
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
        Me.grdViewDiem.Location = New System.Drawing.Point(269, 28)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.ReadOnly = True
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(526, 498)
        Me.grdViewDiem.TabIndex = 105
        '
        'chkNot_show_all
        '
        Me.chkNot_show_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNot_show_all.BackColor = System.Drawing.Color.Transparent
        Me.chkNot_show_all.Checked = True
        Me.chkNot_show_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNot_show_all.Location = New System.Drawing.Point(269, 1)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(393, 24)
        Me.chkNot_show_all.TabIndex = 104
        Me.chkNot_show_all.Text = "Khi nhập điểm thi từ lần 2 trở đi chỉ hiển thị những sinh viên có điểm thi <5"
        Me.chkNot_show_all.UseVisualStyleBackColor = False
        '
        'cmdLock
        '
        Me.cmdLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLock.Appearance.Options.UseFont = True
        Me.cmdLock.ImageIndex = 22
        Me.cmdLock.ImageList = Me.ImgMain
        Me.cmdLock.Location = New System.Drawing.Point(469, 532)
        Me.cmdLock.Name = "cmdLock"
        Me.cmdLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdLock.TabIndex = 180
        Me.cmdLock.Text = "Khóa điểm"
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
        'cmdUnLock
        '
        Me.cmdUnLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUnLock.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnLock.Appearance.Options.UseFont = True
        Me.cmdUnLock.ImageIndex = 23
        Me.cmdUnLock.ImageList = Me.ImgMain
        Me.cmdUnLock.Location = New System.Drawing.Point(578, 532)
        Me.cmdUnLock.Name = "cmdUnLock"
        Me.cmdUnLock.Size = New System.Drawing.Size(103, 30)
        Me.cmdUnLock.TabIndex = 179
        Me.cmdUnLock.Text = "Mở khóa điểm"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(687, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 30)
        Me.cmdClose.TabIndex = 178
        Me.cmdClose.Text = "Thoát"
        '
        'frmESS_KhoaDulieuDiemThiLopTinChi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.cmdUnLock)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.trvLopTinChi)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_KhoaDulieuDiemThiLopTinChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khóa dữ liệu điểm lớp tín chỉ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trvLopTinChi As ESSMarkMan.TreeViewLopTinChi
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdUnLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
End Class
