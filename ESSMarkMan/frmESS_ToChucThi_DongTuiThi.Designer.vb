<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_DongTuiThi
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
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_phach = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ghi_chu_thi1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdPrint_DoiChieu_PhachSBD = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_HD_dontui = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdDongTui = New System.Windows.Forms.ToolStripButton
        Me.cmdXoa_tui = New System.Windows.Forms.ToolStripButton
        Me.Print = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdPrint_Phach_DiemSoChu = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdInAll_Phach_SBD = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdInAll_HD_DonTui = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdInAll_DiemSoChu = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtSo_sinhvien_Max = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbTui_thi = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSophach_tu = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.So_phach, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Ghi_chu_thi1})
        Me.grdViewDanhSach.Location = New System.Drawing.Point(264, 56)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        Me.grdViewDanhSach.RowHeadersVisible = False
        Me.grdViewDanhSach.Size = New System.Drawing.Size(526, 498)
        Me.grdViewDanhSach.TabIndex = 112
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Tui_so"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Túi số"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 49
        '
        'So_phach
        '
        Me.So_phach.DataPropertyName = "So_phach"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_phach.DefaultCellStyle = DataGridViewCellStyle2
        Me.So_phach.HeaderText = "Số phách"
        Me.So_phach.Name = "So_phach"
        Me.So_phach.Visible = False
        Me.So_phach.Width = 69
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 105
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 87
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 91
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lớp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 56
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ten_phong"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phòng thi"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'Ghi_chu_thi1
        '
        Me.Ghi_chu_thi1.DataPropertyName = "Ghi_chu_thi"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ghi_chu_thi1.DefaultCellStyle = DataGridViewCellStyle8
        Me.Ghi_chu_thi1.HeaderText = "Ghi chú"
        Me.Ghi_chu_thi1.Name = "Ghi_chu_thi1"
        Me.Ghi_chu_thi1.Width = 78
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSo_sv.ForeColor = System.Drawing.Color.Maroon
        Me.txtSo_sv.Location = New System.Drawing.Point(727, 29)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(65, 18)
        Me.txtSo_sv.TabIndex = 116
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(589, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Tổng số sinh viên:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdPrint_DoiChieu_PhachSBD
        '
        Me.cmdPrint_DoiChieu_PhachSBD.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_DoiChieu_PhachSBD.Name = "cmdPrint_DoiChieu_PhachSBD"
        Me.cmdPrint_DoiChieu_PhachSBD.Size = New System.Drawing.Size(321, 22)
        Me.cmdPrint_DoiChieu_PhachSBD.Text = "Bản đối chiếu Phách - SBD"
        '
        'cmdPrint_HD_dontui
        '
        Me.cmdPrint_HD_dontui.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_HD_dontui.Name = "cmdPrint_HD_dontui"
        Me.cmdPrint_HD_dontui.Size = New System.Drawing.Size(321, 22)
        Me.cmdPrint_HD_dontui.Text = "Bản hướng dẫn dồn túi"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdDongTui, Me.cmdXoa_tui, Me.Print, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 105
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdDongTui
        '
        Me.cmdDongTui.Image = Global.ESSMarkMan.My.Resources.Resources.DoiChieuDuLieu
        Me.cmdDongTui.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDongTui.Name = "cmdDongTui"
        Me.cmdDongTui.Size = New System.Drawing.Size(81, 22)
        Me.cmdDongTui.Text = "Đóng túi"
        '
        'cmdXoa_tui
        '
        Me.cmdXoa_tui.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdXoa_tui.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXoa_tui.Name = "cmdXoa_tui"
        Me.cmdXoa_tui.Size = New System.Drawing.Size(71, 22)
        Me.cmdXoa_tui.Text = "Xoá túi"
        Me.cmdXoa_tui.Visible = False
        '
        'Print
        '
        Me.Print.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint_DoiChieu_PhachSBD, Me.cmdPrint_HD_dontui, Me.cmdPrint_Phach_DiemSoChu, Me.cmdInAll_Phach_SBD, Me.cmdInAll_HD_DonTui, Me.cmdInAll_DiemSoChu})
        Me.Print.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(103, 22)
        Me.Print.Text = "In báo cáo"
        '
        'cmdPrint_Phach_DiemSoChu
        '
        Me.cmdPrint_Phach_DiemSoChu.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_Phach_DiemSoChu.Name = "cmdPrint_Phach_DiemSoChu"
        Me.cmdPrint_Phach_DiemSoChu.Size = New System.Drawing.Size(321, 22)
        Me.cmdPrint_Phach_DiemSoChu.Text = "Bản Phách - Điểm số và chữ"
        '
        'cmdInAll_Phach_SBD
        '
        Me.cmdInAll_Phach_SBD.Name = "cmdInAll_Phach_SBD"
        Me.cmdInAll_Phach_SBD.Size = New System.Drawing.Size(321, 22)
        Me.cmdInAll_Phach_SBD.Text = "In tất cả Bản đối chiếu Phách - SBD"
        '
        'cmdInAll_HD_DonTui
        '
        Me.cmdInAll_HD_DonTui.Name = "cmdInAll_HD_DonTui"
        Me.cmdInAll_HD_DonTui.Size = New System.Drawing.Size(321, 22)
        Me.cmdInAll_HD_DonTui.Text = "In tất cả Bản hướng dẫn dồn túi"
        '
        'cmdInAll_DiemSoChu
        '
        Me.cmdInAll_DiemSoChu.Name = "cmdInAll_DiemSoChu"
        Me.cmdInAll_DiemSoChu.Size = New System.Drawing.Size(321, 22)
        Me.cmdInAll_DiemSoChu.Text = "In tất cả Bản Phách - Điểm số và chữ"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'txtSo_sinhvien_Max
        '
        Me.txtSo_sinhvien_Max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_sinhvien_Max.Location = New System.Drawing.Point(411, 27)
        Me.txtSo_sinhvien_Max.MaxLength = 8
        Me.txtSo_sinhvien_Max.Name = "txtSo_sinhvien_Max"
        Me.txtSo_sinhvien_Max.Size = New System.Drawing.Size(42, 22)
        Me.txtSo_sinhvien_Max.TabIndex = 110
        Me.txtSo_sinhvien_Max.Text = "30"
        Me.txtSo_sinhvien_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(261, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 24)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Số sinh viên tối đa/ 1 túi:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTui_thi
        '
        Me.cmbTui_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTui_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTui_thi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbTui_thi.Location = New System.Drawing.Point(541, 26)
        Me.cmbTui_thi.Name = "cmbTui_thi"
        Me.cmbTui_thi.Size = New System.Drawing.Size(41, 24)
        Me.cmbTui_thi.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(468, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Túi thí số:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSophach_tu
        '
        Me.txtSophach_tu.Location = New System.Drawing.Point(209, 27)
        Me.txtSophach_tu.MaxLength = 8
        Me.txtSophach_tu.Name = "txtSophach_tu"
        Me.txtSophach_tu.Size = New System.Drawing.Size(42, 22)
        Me.txtSophach_tu.TabIndex = 118
        Me.txtSophach_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(114, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Số phách từ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 48)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 518)
        Me.trvPhongThi.TabIndex = 106
        '
        'frmESS_DongTuiThi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.txtSophach_tu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.txtSo_sinhvien_Max)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTui_thi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DongTuiThi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DONG TUI THI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents cmdPrint_DoiChieu_PhachSBD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_HD_dontui As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdXoa_tui As System.Windows.Forms.ToolStripButton
    Friend WithEvents Print As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSo_sinhvien_Max As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTui_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdDongTui As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSophach_tu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint_Phach_DiemSoChu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_phach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ghi_chu_thi1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdInAll_Phach_SBD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdInAll_HD_DonTui As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdInAll_DiemSoChu As System.Windows.Forms.ToolStripMenuItem
End Class
