<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiem_Thi_TheoSBD_CaiThien
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
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.Print = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdPrint_sochu = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_tinchi = New System.Windows.Forms.ToolStripMenuItem
        Me.KếtQuảThiCácPhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdKyHieuDiem = New System.Windows.Forms.ToolStripButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_ngoai_ngu = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbKy_hieu = New System.Windows.Forms.ComboBox
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkNot_show_all
        '
        Me.chkNot_show_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNot_show_all.BackColor = System.Drawing.Color.Transparent
        Me.chkNot_show_all.Checked = True
        Me.chkNot_show_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNot_show_all.Location = New System.Drawing.Point(266, 57)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(461, 24)
        Me.chkNot_show_all.TabIndex = 102
        Me.chkNot_show_all.Text = "Khi nhập điểm thi từ lần 2 trở đi chỉ hiển thị những sinh viên có điểm thi <5"
        Me.chkNot_show_all.UseVisualStyleBackColor = False
        Me.chkNot_show_all.Visible = False
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
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 80)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(524, 486)
        Me.grdViewDiem.TabIndex = 103
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdDelete, Me.cmdExcel, Me.Print, Me.cmdKyHieuDiem, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 101
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(91, 22)
        Me.cmdDelete.Text = "Xoá tất cả"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSMarkMan.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'Print
        '
        Me.Print.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint_sochu, Me.cmdPrint_tinchi, Me.KếtQuảThiCácPhòngToolStripMenuItem})
        Me.Print.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(89, 22)
        Me.Print.Text = "Báo cáo"
        '
        'cmdPrint_sochu
        '
        Me.cmdPrint_sochu.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_sochu.Name = "cmdPrint_sochu"
        Me.cmdPrint_sochu.Size = New System.Drawing.Size(225, 22)
        Me.cmdPrint_sochu.Text = "Bảng điểm số và chữ"
        '
        'cmdPrint_tinchi
        '
        Me.cmdPrint_tinchi.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_tinchi.Name = "cmdPrint_tinchi"
        Me.cmdPrint_tinchi.Size = New System.Drawing.Size(225, 22)
        Me.cmdPrint_tinchi.Text = "Bảng điểm tín chỉ"
        '
        'KếtQuảThiCácPhòngToolStripMenuItem
        '
        Me.KếtQuảThiCácPhòngToolStripMenuItem.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.KếtQuảThiCácPhòngToolStripMenuItem.Name = "KếtQuảThiCácPhòngToolStripMenuItem"
        Me.KếtQuảThiCácPhòngToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.KếtQuảThiCácPhòngToolStripMenuItem.Text = "Kết quả thi các phòng"
        '
        'cmdKyHieuDiem
        '
        Me.cmdKyHieuDiem.Image = Global.ESSMarkMan.My.Resources.Resources.RangBuocMonHoc
        Me.cmdKyHieuDiem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdKyHieuDiem.Name = "cmdKyHieuDiem"
        Me.cmdKyHieuDiem.Size = New System.Drawing.Size(125, 22)
        Me.cmdKyHieuDiem.Text = "Ký hiệu ghi chú"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(601, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Ngoại ngữ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_ngoai_ngu
        '
        Me.cmbID_ngoai_ngu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_ngoai_ngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_ngoai_ngu.FormattingEnabled = True
        Me.cmbID_ngoai_ngu.Items.AddRange(New Object() {"Tiếng Anh", "Tiếng Nga", "Tiếng Pháp", "Tiếng Trung"})
        Me.cmbID_ngoai_ngu.Location = New System.Drawing.Point(681, 29)
        Me.cmbID_ngoai_ngu.Name = "cmbID_ngoai_ngu"
        Me.cmbID_ngoai_ngu.Size = New System.Drawing.Size(109, 24)
        Me.cmbID_ngoai_ngu.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(277, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Hiển thị sinh viên điểm:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'cmbKy_hieu
        '
        Me.cmbKy_hieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKy_hieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu.FormattingEnabled = True
        Me.cmbKy_hieu.Items.AddRange(New Object() {"Từ điểm D trở xuống", "Những sinh viên thiếu điểm TP", "Những sinh viên thiếu điểm Thi", "Những sinh viên không tính điểm thành phần vào TBCHP", "Những sinh viên bảo lưu"})
        Me.cmbKy_hieu.Location = New System.Drawing.Point(425, 28)
        Me.cmbKy_hieu.Name = "cmbKy_hieu"
        Me.cmbKy_hieu.Size = New System.Drawing.Size(170, 24)
        Me.cmbKy_hieu.TabIndex = 119
        Me.cmbKy_hieu.Visible = False
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 33)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 532)
        Me.trvPhongThi.TabIndex = 104
        '
        'frmESS_NhapDiemThiSBD_NangDiem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbKy_hieu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_ngoai_ngu)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_NhapDiemThiSBD_NangDiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập điểm thi theo SBD - Nâng điểm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Print As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdPrint_sochu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_tinchi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdKyHieuDiem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_ngoai_ngu As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbKy_hieu As System.Windows.Forms.ComboBox
    Friend WithEvents KếtQuảThiCácPhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
