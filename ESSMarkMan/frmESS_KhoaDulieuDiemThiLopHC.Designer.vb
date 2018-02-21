<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhoaDulieuDiemThiLopHC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhoaDulieuDiemThiLopHC))
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.lblLoai_chungchi = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbNam_hoc_TP = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky_TP = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdLock = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdUnLock = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
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
        Me.chkNot_show_all.Location = New System.Drawing.Point(355, 62)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(432, 20)
        Me.chkNot_show_all.TabIndex = 110
        Me.chkNot_show_all.Text = "Khi nhập điểm thi từ lần 2 trở đi chỉ hiển thị những sinh viên có điểm thi <5"
        Me.chkNot_show_all.UseVisualStyleBackColor = False
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(3, 49)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(264, 518)
        Me.TreeViewLop.TabIndex = 101
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
        Me.grdViewDiem.Location = New System.Drawing.Point(269, 83)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.ReadOnly = True
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.ShowCellErrors = False
        Me.grdViewDiem.ShowCellToolTips = False
        Me.grdViewDiem.ShowRowErrors = False
        Me.grdViewDiem.Size = New System.Drawing.Size(524, 443)
        Me.grdViewDiem.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(136, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(661, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Location = New System.Drawing.Point(722, 31)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(66, 24)
        Me.cmbLan_thi.TabIndex = 109
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(411, 1)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(376, 24)
        Me.cmbID_mon.TabIndex = 103
        '
        'lblLoai_chungchi
        '
        Me.lblLoai_chungchi.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_chungchi.Location = New System.Drawing.Point(333, 1)
        Me.lblLoai_chungchi.Name = "lblLoai_chungchi"
        Me.lblLoai_chungchi.Size = New System.Drawing.Size(72, 24)
        Me.lblLoai_chungchi.TabIndex = 102
        Me.lblLoai_chungchi.Text = "Học phần:"
        Me.lblLoai_chungchi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(208, 1)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(109, 24)
        Me.cmbNam_hoc.TabIndex = 107
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(66, 1)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky.TabIndex = 105
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(0, 1)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 104
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(276, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Điểm của Năm học:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc_TP
        '
        Me.cmbNam_hoc_TP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc_TP.Location = New System.Drawing.Point(412, 31)
        Me.cmbNam_hoc_TP.Name = "cmbNam_hoc_TP"
        Me.cmbNam_hoc_TP.Size = New System.Drawing.Size(109, 24)
        Me.cmbNam_hoc_TP.TabIndex = 115
        '
        'cmbHoc_ky_TP
        '
        Me.cmbHoc_ky_TP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky_TP.Location = New System.Drawing.Point(208, 31)
        Me.cmbHoc_ky_TP.Name = "cmbHoc_ky_TP"
        Me.cmbHoc_ky_TP.Size = New System.Drawing.Size(64, 24)
        Me.cmbHoc_ky_TP.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 24)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Điểm của Học kỳ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.cmdLock.TabIndex = 177
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
        Me.cmdUnLock.TabIndex = 176
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
        Me.cmdClose.TabIndex = 175
        Me.cmdClose.Text = "Thoát"
        '
        'frmESS_KhoaDulieuDiemThiLopHC
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdLock)
        Me.Controls.Add(Me.cmdUnLock)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbNam_hoc_TP)
        Me.Controls.Add(Me.cmbHoc_ky_TP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.lblLoai_chungchi)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_KhoaDulieuDiemThiLopHC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KHOA DIEM THI LOP HANH HCINH"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoai_chungchi As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc_TP As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky_TP As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdUnLock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
End Class
