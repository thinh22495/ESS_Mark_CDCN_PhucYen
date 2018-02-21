<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ChuyenDiemNganh1SangNganh2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdKeThuaDiem = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewDanhsachMon = New System.Windows.Forms.DataGridView
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_hoc_trinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem_chu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ghi_chu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hoc_ky = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nam_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lan_thi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_nganh = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grdViewHocChuongTrinh2 = New System.Windows.Forms.DataGridView
        Me.Ma_sv1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chuyen_nganh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDanhsachMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewHocChuongTrinh2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdKeThuaDiem, Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 91
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdKeThuaDiem
        '
        Me.cmdKeThuaDiem.Image = Global.ESSMarkMan.My.Resources.Resources.Import
        Me.cmdKeThuaDiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdKeThuaDiem.Name = "cmdKeThuaDiem"
        Me.cmdKeThuaDiem.Size = New System.Drawing.Size(211, 22)
        Me.cmdKeThuaDiem.Text = "Chuyển điểm từ ngành chính"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSMarkMan.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdViewDanhsachMon
        '
        Me.grdViewDanhsachMon.AllowUserToAddRows = False
        Me.grdViewDanhsachMon.AllowUserToDeleteRows = False
        Me.grdViewDanhsachMon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhsachMon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhsachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhsachMon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ky_hieu, Me.Ten_mon, Me.So_hoc_trinh, Me.Diem, Me.Diem_chu, Me.Ghi_chu, Me.Hoc_ky, Me.Nam_hoc, Me.Lan_thi})
        Me.grdViewDanhsachMon.Location = New System.Drawing.Point(3, 366)
        Me.grdViewDanhsachMon.Name = "grdViewDanhsachMon"
        Me.grdViewDanhsachMon.ReadOnly = True
        Me.grdViewDanhsachMon.RowHeadersVisible = False
        Me.grdViewDanhsachMon.ShowCellErrors = False
        Me.grdViewDanhsachMon.ShowCellToolTips = False
        Me.grdViewDanhsachMon.ShowRowErrors = False
        Me.grdViewDanhsachMon.Size = New System.Drawing.Size(786, 199)
        Me.grdViewDanhsachMon.TabIndex = 93
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ky_hieu.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ky_hieu.HeaderText = "Mã học phần"
        Me.Ky_hieu.MinimumWidth = 130
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 130
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.HeaderText = "Tên học phần"
        Me.Ten_mon.MinimumWidth = 300
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 300
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.DataPropertyName = "So_hoc_trinh"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_hoc_trinh.DefaultCellStyle = DataGridViewCellStyle2
        Me.So_hoc_trinh.HeaderText = "Số tín chỉ"
        Me.So_hoc_trinh.MinimumWidth = 100
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.ReadOnly = True
        '
        'Diem
        '
        Me.Diem.DataPropertyName = "TBCM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Diem.DefaultCellStyle = DataGridViewCellStyle3
        Me.Diem.HeaderText = "Điểm số"
        Me.Diem.MinimumWidth = 90
        Me.Diem.Name = "Diem"
        Me.Diem.ReadOnly = True
        Me.Diem.Width = 90
        '
        'Diem_chu
        '
        Me.Diem_chu.DataPropertyName = "Diem_chu"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Diem_chu.DefaultCellStyle = DataGridViewCellStyle4
        Me.Diem_chu.HeaderText = "Điểm chữ"
        Me.Diem_chu.MinimumWidth = 110
        Me.Diem_chu.Name = "Diem_chu"
        Me.Diem_chu.ReadOnly = True
        Me.Diem_chu.Width = 110
        '
        'Ghi_chu
        '
        Me.Ghi_chu.DataPropertyName = "Ghi_chu"
        Me.Ghi_chu.HeaderText = "Ghi chú"
        Me.Ghi_chu.MinimumWidth = 80
        Me.Ghi_chu.Name = "Ghi_chu"
        Me.Ghi_chu.ReadOnly = True
        Me.Ghi_chu.Width = 80
        '
        'Hoc_ky
        '
        Me.Hoc_ky.DataPropertyName = "Hoc_ky"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Hoc_ky.DefaultCellStyle = DataGridViewCellStyle5
        Me.Hoc_ky.HeaderText = "Học kỳ"
        Me.Hoc_ky.MinimumWidth = 75
        Me.Hoc_ky.Name = "Hoc_ky"
        Me.Hoc_ky.ReadOnly = True
        Me.Hoc_ky.Width = 75
        '
        'Nam_hoc
        '
        Me.Nam_hoc.DataPropertyName = "Nam_hoc"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Nam_hoc.DefaultCellStyle = DataGridViewCellStyle6
        Me.Nam_hoc.HeaderText = "Năm học"
        Me.Nam_hoc.MinimumWidth = 90
        Me.Nam_hoc.Name = "Nam_hoc"
        Me.Nam_hoc.ReadOnly = True
        Me.Nam_hoc.Width = 90
        '
        'Lan_thi
        '
        Me.Lan_thi.DataPropertyName = "Lan_thi"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Lan_thi.DefaultCellStyle = DataGridViewCellStyle7
        Me.Lan_thi.HeaderText = "Lần thi"
        Me.Lan_thi.MinimumWidth = 80
        Me.Lan_thi.Name = "Lan_thi"
        Me.Lan_thi.ReadOnly = True
        Me.Lan_thi.Width = 80
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(483, 28)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(306, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(374, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Chuyên ngành:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_nganh
        '
        Me.cmbID_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nganh.Location = New System.Drawing.Point(61, 28)
        Me.cmbID_nganh.Name = "cmbID_nganh"
        Me.cmbID_nganh.Size = New System.Drawing.Size(293, 24)
        Me.cmbID_nganh.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Ngành:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdViewHocChuongTrinh2
        '
        Me.grdViewHocChuongTrinh2.AllowUserToAddRows = False
        Me.grdViewHocChuongTrinh2.AllowUserToDeleteRows = False
        Me.grdViewHocChuongTrinh2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewHocChuongTrinh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewHocChuongTrinh2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewHocChuongTrinh2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdViewHocChuongTrinh2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewHocChuongTrinh2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ma_sv1, Me.Ho_ten1, Me.Ten_lop, Me.Chuyen_nganh})
        Me.grdViewHocChuongTrinh2.Location = New System.Drawing.Point(3, 58)
        Me.grdViewHocChuongTrinh2.Name = "grdViewHocChuongTrinh2"
        Me.grdViewHocChuongTrinh2.RowHeadersVisible = False
        Me.grdViewHocChuongTrinh2.Size = New System.Drawing.Size(786, 302)
        Me.grdViewHocChuongTrinh2.TabIndex = 124
        '
        'Ma_sv1
        '
        Me.Ma_sv1.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Ma_sv1.HeaderText = "Mã sv"
        Me.Ma_sv1.MinimumWidth = 130
        Me.Ma_sv1.Name = "Ma_sv1"
        Me.Ma_sv1.ReadOnly = True
        Me.Ma_sv1.Width = 130
        '
        'Ho_ten1
        '
        Me.Ho_ten1.DataPropertyName = "Ho_ten"
        Me.Ho_ten1.HeaderText = "Họ tên"
        Me.Ho_ten1.MinimumWidth = 330
        Me.Ho_ten1.Name = "Ho_ten1"
        Me.Ho_ten1.ReadOnly = True
        Me.Ho_ten1.Width = 330
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle10
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 130
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 130
        '
        'Chuyen_nganh
        '
        Me.Chuyen_nganh.DataPropertyName = "Chuyen_nganh"
        Me.Chuyen_nganh.HeaderText = "Chuyên ngành chính"
        Me.Chuyen_nganh.MinimumWidth = 300
        Me.Chuyen_nganh.Name = "Chuyen_nganh"
        Me.Chuyen_nganh.ReadOnly = True
        Me.Chuyen_nganh.Width = 300
        '
        'frmESS_ChuyenDiemNganh1SangNganh2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_nganh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdViewHocChuongTrinh2)
        Me.Controls.Add(Me.grdViewDanhsachMon)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_ChuyenDiemNganh1SangNganh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chuyển điểm ngành 1 sang ngành 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDanhsachMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewHocChuongTrinh2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewDanhsachMon As System.Windows.Forms.DataGridView
    Friend WithEvents cmdKeThuaDiem As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdViewHocChuongTrinh2 As System.Windows.Forms.DataGridView
    Friend WithEvents Ma_sv1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chuyen_nganh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_hoc_trinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem_chu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ghi_chu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hoc_ky As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nam_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lan_thi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
