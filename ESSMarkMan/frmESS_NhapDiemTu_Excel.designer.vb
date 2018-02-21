<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiemTu_Excel
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
        Me.cmbChonFile = New System.Windows.Forms.ComboBox
        Me.lblPhan_tram = New System.Windows.Forms.Label
        Me.txtTy_le = New System.Windows.Forms.TextBox
        Me.lblTy_le = New System.Windows.Forms.Label
        Me.lblBang_tinh = New System.Windows.Forms.Label
        Me.cmbThanh_phan = New System.Windows.Forms.ComboBox
        Me.lblThanh_phan = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.lblLan_thi = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.lblNam_hoc = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblHoc_ky = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.lblID_mon = New System.Windows.Forms.Label
        Me.cmdOpen = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCot_diem = New System.Windows.Forms.Label
        Me.lblCot_ma = New System.Windows.Forms.Label
        Me.cmbCot_diem = New System.Windows.Forms.ComboBox
        Me.cmbCot_ma = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdFontFile = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.cmbFont = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbChonFile
        '
        Me.cmbChonFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChonFile.Location = New System.Drawing.Point(454, 106)
        Me.cmbChonFile.Name = "cmbChonFile"
        Me.cmbChonFile.Size = New System.Drawing.Size(107, 24)
        Me.cmbChonFile.TabIndex = 36
        '
        'lblPhan_tram
        '
        Me.lblPhan_tram.Location = New System.Drawing.Point(334, 104)
        Me.lblPhan_tram.Name = "lblPhan_tram"
        Me.lblPhan_tram.Size = New System.Drawing.Size(16, 24)
        Me.lblPhan_tram.TabIndex = 41
        Me.lblPhan_tram.Text = "%"
        Me.lblPhan_tram.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTy_le
        '
        Me.txtTy_le.Location = New System.Drawing.Point(284, 105)
        Me.txtTy_le.MaxLength = 3
        Me.txtTy_le.Name = "txtTy_le"
        Me.txtTy_le.Size = New System.Drawing.Size(44, 23)
        Me.txtTy_le.TabIndex = 34
        '
        'lblTy_le
        '
        Me.lblTy_le.Location = New System.Drawing.Point(222, 104)
        Me.lblTy_le.Name = "lblTy_le"
        Me.lblTy_le.Size = New System.Drawing.Size(56, 24)
        Me.lblTy_le.TabIndex = 40
        Me.lblTy_le.Text = "Tỷ lệ:"
        Me.lblTy_le.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBang_tinh
        '
        Me.lblBang_tinh.Location = New System.Drawing.Point(356, 105)
        Me.lblBang_tinh.Name = "lblBang_tinh"
        Me.lblBang_tinh.Size = New System.Drawing.Size(92, 24)
        Me.lblBang_tinh.TabIndex = 39
        Me.lblBang_tinh.Text = "Chọn Sheet:"
        Me.lblBang_tinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbThanh_phan
        '
        Me.cmbThanh_phan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThanh_phan.Location = New System.Drawing.Point(117, 104)
        Me.cmbThanh_phan.Name = "cmbThanh_phan"
        Me.cmbThanh_phan.Size = New System.Drawing.Size(114, 24)
        Me.cmbThanh_phan.TabIndex = 33
        '
        'lblThanh_phan
        '
        Me.lblThanh_phan.Location = New System.Drawing.Point(-2, 104)
        Me.lblThanh_phan.Name = "lblThanh_phan"
        Me.lblThanh_phan.Size = New System.Drawing.Size(120, 24)
        Me.lblThanh_phan.TabIndex = 38
        Me.lblThanh_phan.Text = "Thành phần Học phần:"
        Me.lblThanh_phan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"1", "2"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(526, 75)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(75, 24)
        Me.cmbLan_thi.TabIndex = 30
        '
        'lblLan_thi
        '
        Me.lblLan_thi.Location = New System.Drawing.Point(464, 75)
        Me.lblLan_thi.Name = "lblLan_thi"
        Me.lblLan_thi.Size = New System.Drawing.Size(56, 24)
        Me.lblLan_thi.TabIndex = 32
        Me.lblLan_thi.Text = "Lần thi:"
        Me.lblLan_thi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(284, 75)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(96, 24)
        Me.cmbNam_hoc.TabIndex = 28
        '
        'lblNam_hoc
        '
        Me.lblNam_hoc.Location = New System.Drawing.Point(208, 75)
        Me.lblNam_hoc.Name = "lblNam_hoc"
        Me.lblNam_hoc.Size = New System.Drawing.Size(76, 24)
        Me.lblNam_hoc.TabIndex = 29
        Me.lblNam_hoc.Text = "Năm học:"
        Me.lblNam_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(117, 75)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(54, 24)
        Me.cmbHoc_ky.TabIndex = 27
        '
        'lblHoc_ky
        '
        Me.lblHoc_ky.Location = New System.Drawing.Point(27, 75)
        Me.lblHoc_ky.Name = "lblHoc_ky"
        Me.lblHoc_ky.Size = New System.Drawing.Size(90, 24)
        Me.lblHoc_ky.TabIndex = 26
        Me.lblHoc_ky.Text = "Học kỳ:"
        Me.lblHoc_ky.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(117, 45)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(484, 24)
        Me.cmbID_mon.TabIndex = 31
        '
        'lblID_mon
        '
        Me.lblID_mon.Location = New System.Drawing.Point(27, 45)
        Me.lblID_mon.Name = "lblID_mon"
        Me.lblID_mon.Size = New System.Drawing.Size(90, 24)
        Me.lblID_mon.TabIndex = 35
        Me.lblID_mon.Text = "Học phần:"
        Me.lblID_mon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdOpen
        '
        Me.cmdOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpen.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpen.ForeColor = System.Drawing.Color.Brown
        Me.cmdOpen.Image = Global.ESSMarkMan.My.Resources.Resources.Folder
        Me.cmdOpen.Location = New System.Drawing.Point(567, 106)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(34, 25)
        Me.cmdOpen.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbThanh_phan)
        Me.GroupBox1.Controls.Add(Me.cmbID_lop)
        Me.GroupBox1.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbKhoa_hoc)
        Me.GroupBox1.Controls.Add(Me.lblTy_le)
        Me.GroupBox1.Controls.Add(Me.cmdOpen)
        Me.GroupBox1.Controls.Add(Me.cmbChonFile)
        Me.GroupBox1.Controls.Add(Me.lblID_mon)
        Me.GroupBox1.Controls.Add(Me.lblPhan_tram)
        Me.GroupBox1.Controls.Add(Me.cmbID_mon)
        Me.GroupBox1.Controls.Add(Me.txtTy_le)
        Me.GroupBox1.Controls.Add(Me.lblHoc_ky)
        Me.GroupBox1.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox1.Controls.Add(Me.lblBang_tinh)
        Me.GroupBox1.Controls.Add(Me.lblNam_hoc)
        Me.GroupBox1.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox1.Controls.Add(Me.lblThanh_phan)
        Me.GroupBox1.Controls.Add(Me.lblLan_thi)
        Me.GroupBox1.Controls.Add(Me.cmbLan_thi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 139)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chọn Học phần và dữ liệu"
        '
        'cmbID_lop
        '
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Location = New System.Drawing.Point(485, 16)
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(116, 24)
        Me.cmbID_lop.TabIndex = 46
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(274, 16)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(170, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Khoá:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(117, 16)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(54, 24)
        Me.cmbKhoa_hoc.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(164, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Chuyên ngành:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(449, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 24)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Lớp:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.lblCot_ma.Text = "Chọn mã sinh viên"
        Me.lblCot_ma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCot_diem
        '
        Me.cmbCot_diem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_diem.Location = New System.Drawing.Point(6, 72)
        Me.cmbCot_diem.Name = "cmbCot_diem"
        Me.cmbCot_diem.Size = New System.Drawing.Size(142, 24)
        Me.cmbCot_diem.TabIndex = 44
        '
        'cmbCot_ma
        '
        Me.cmbCot_ma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCot_ma.Location = New System.Drawing.Point(6, 31)
        Me.cmbCot_ma.Name = "cmbCot_ma"
        Me.cmbCot_ma.Size = New System.Drawing.Size(142, 24)
        Me.cmbCot_ma.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbCot_ma)
        Me.GroupBox2.Controls.Add(Me.lblCot_diem)
        Me.GroupBox2.Controls.Add(Me.lblCot_ma)
        Me.GroupBox2.Controls.Add(Me.cmbCot_diem)
        Me.GroupBox2.Location = New System.Drawing.Point(618, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 99)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chọn mã sv và điểm"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdFontFile, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 85
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(133, 22)
        Me.cmdSave.Text = "Cập nhật dữ liệu"
        Me.cmdSave.ToolTipText = "Cập nhật"
        '
        'cmdFontFile
        '
        Me.cmdFontFile.Image = Global.ESSMarkMan.My.Resources.Resources.ChuyenLop
        Me.cmdFontFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFontFile.Name = "cmdFontFile"
        Me.cmdFontFile.Size = New System.Drawing.Size(231, 22)
        Me.cmdFontFile.Text = "Chuyển Font chữ sang UniCode"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
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
        Me.grdViewDiem.Location = New System.Drawing.Point(0, 173)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.ReadOnly = True
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(791, 392)
        Me.grdViewDiem.TabIndex = 87
        '
        'cmbFont
        '
        Me.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFont.Location = New System.Drawing.Point(624, 144)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(164, 24)
        Me.cmbFont.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(624, 127)
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
        'frmESS_NhapDiemExcel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbFont)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_NhapDiemExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập điểm Excel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbChonFile As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhan_tram As System.Windows.Forms.Label
    Friend WithEvents txtTy_le As System.Windows.Forms.TextBox
    Friend WithEvents lblTy_le As System.Windows.Forms.Label
    Friend WithEvents lblBang_tinh As System.Windows.Forms.Label
    Friend WithEvents cmbThanh_phan As System.Windows.Forms.ComboBox
    Friend WithEvents lblThanh_phan As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_thi As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblNam_hoc As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoc_ky As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents lblID_mon As System.Windows.Forms.Label
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCot_diem As System.Windows.Forms.Label
    Friend WithEvents lblCot_ma As System.Windows.Forms.Label
    Friend WithEvents cmbCot_diem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCot_ma As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdFontFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbFont As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
