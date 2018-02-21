<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetLenLop_NganhThu2
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
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.labSo_sv = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdNhapQuyetDinh = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdTonghopAll = New System.Windows.Forms.ToolStripButton
        Me.cmdTongHop = New System.Windows.Forms.ToolStripButton
        Me.cmdBaoCao = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdPrintThoiHoc = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint2Nganh = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewDanhSachSinhVien = New System.Windows.Forms.DataGridView
        Me.cmbID_nganh = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDanhSachSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(169, 28)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(108, 24)
        Me.cmbNam_hoc.TabIndex = 128
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(653, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Tống số sv:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labSo_sv
        '
        Me.labSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.labSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_sv.Location = New System.Drawing.Point(740, 29)
        Me.labSo_sv.Name = "labSo_sv"
        Me.labSo_sv.Size = New System.Drawing.Size(43, 23)
        Me.labSo_sv.TabIndex = 125
        Me.labSo_sv.Text = "0"
        Me.labSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Items.AddRange(New Object() {"01", "02"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(63, 28)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(37, 24)
        Me.cmbHoc_ky.TabIndex = 126
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Học kỳ:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSMarkMan.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'cmdNhapQuyetDinh
        '
        Me.cmdNhapQuyetDinh.Image = Global.ESSMarkMan.My.Resources.Resources.PhanLoaiHocTap
        Me.cmdNhapQuyetDinh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNhapQuyetDinh.Name = "cmdNhapQuyetDinh"
        Me.cmdNhapQuyetDinh.Size = New System.Drawing.Size(97, 22)
        Me.cmdNhapQuyetDinh.Text = "Ngừng học"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTonghopAll, Me.cmdTongHop, Me.cmdNhapQuyetDinh, Me.cmdBaoCao, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 121
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdTonghopAll
        '
        Me.cmdTonghopAll.Image = Global.ESSMarkMan.My.Resources.Resources.DoiChieuDuLieu
        Me.cmdTonghopAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTonghopAll.Name = "cmdTonghopAll"
        Me.cmdTonghopAll.Size = New System.Drawing.Size(234, 22)
        Me.cmdTonghopAll.Text = "Tổng hợp KQHT cả 2 ngành học"
        '
        'cmdTongHop
        '
        Me.cmdTongHop.Image = Global.ESSMarkMan.My.Resources.Resources.Import
        Me.cmdTongHop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTongHop.Name = "cmdTongHop"
        Me.cmdTongHop.Size = New System.Drawing.Size(162, 22)
        Me.cmdTongHop.Text = "Tổng hợp ngừng học"
        '
        'cmdBaoCao
        '
        Me.cmdBaoCao.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrintThoiHoc, Me.cmdPrint2Nganh})
        Me.cmdBaoCao.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBaoCao.Name = "cmdBaoCao"
        Me.cmdBaoCao.Size = New System.Drawing.Size(103, 22)
        Me.cmdBaoCao.Text = "In báo cáo"
        '
        'cmdPrintThoiHoc
        '
        Me.cmdPrintThoiHoc.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrintThoiHoc.Name = "cmdPrintThoiHoc"
        Me.cmdPrintThoiHoc.Size = New System.Drawing.Size(227, 22)
        Me.cmdPrintThoiHoc.Text = "Danh sách ngừng học"
        '
        'cmdPrint2Nganh
        '
        Me.cmdPrint2Nganh.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint2Nganh.Name = "cmdPrint2Nganh"
        Me.cmdPrint2Nganh.Size = New System.Drawing.Size(227, 22)
        Me.cmdPrint2Nganh.Text = "KQHT cả 2 ngành học"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdViewDanhSachSinhVien
        '
        Me.grdViewDanhSachSinhVien.AllowUserToAddRows = False
        Me.grdViewDanhSachSinhVien.AllowUserToDeleteRows = False
        Me.grdViewDanhSachSinhVien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSachSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSachSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSachSinhVien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSachSinhVien.Location = New System.Drawing.Point(0, 56)
        Me.grdViewDanhSachSinhVien.Name = "grdViewDanhSachSinhVien"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSachSinhVien.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdViewDanhSachSinhVien.RowHeadersVisible = False
        Me.grdViewDanhSachSinhVien.Size = New System.Drawing.Size(792, 510)
        Me.grdViewDanhSachSinhVien.TabIndex = 123
        '
        'cmbID_nganh
        '
        Me.cmbID_nganh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nganh.Location = New System.Drawing.Point(367, 28)
        Me.cmbID_nganh.Name = "cmbID_nganh"
        Me.cmbID_nganh.Size = New System.Drawing.Size(280, 24)
        Me.cmbID_nganh.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(277, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Ngành thứ 2:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_XetLenLop_NganhThu2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbID_nganh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labSo_sv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.grdViewDanhSachSinhVien)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_XetLenLop_NganhThu2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xét lên lớp ngành 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDanhSachSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNhapQuyetDinh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdTongHop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewDanhSachSinhVien As System.Windows.Forms.DataGridView
    Friend WithEvents cmbID_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdBaoCao As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdPrintThoiHoc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint2Nganh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdTonghopAll As System.Windows.Forms.ToolStripButton
End Class
