<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DSHocBongHocPhi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_DSHocBongHocPhi))
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdHienThi = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.fgTongHopKy = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.chkThanh_phan = New System.Windows.Forms.CheckBox
        Me.chkGhi_chu = New System.Windows.Forms.CheckBox
        Me.optDiem10 = New System.Windows.Forms.RadioButton
        Me.optDiemSo = New System.Windows.Forms.RadioButton
        Me.optDiemChu = New System.Windows.Forms.RadioButton
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbKho_giay = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.TreeViewLop = New ESSFinance.TreeViewLop
        Me.txtGhi_chu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNguoi_ky = New System.Windows.Forms.TextBox
        Me.txtChuc_danh = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNguoi_lap = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHienThi, Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 50
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdHienThi
        '
        Me.cmdHienThi.Image = Global.ESSFinance.My.Resources.Resources.ThongKe
        Me.cmdHienThi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHienThi.Name = "cmdHienThi"
        Me.cmdHienThi.Size = New System.Drawing.Size(75, 22)
        Me.cmdHienThi.Text = "Hiển thị"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(94, 22)
        Me.cmdPrint.Text = "In báo cáo"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSFinance.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'fgTongHopKy
        '
        Me.fgTongHopKy.AllowEditing = False
        Me.fgTongHopKy.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.fgTongHopKy.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fgTongHopKy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgTongHopKy.BackColor = System.Drawing.Color.White
        Me.fgTongHopKy.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.fgTongHopKy.Cols = New C1.Win.C1FlexGrid.ColumnCollection(10, 1, 0, 0, 0, 90, "")
        Me.fgTongHopKy.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fgTongHopKy.Location = New System.Drawing.Point(274, 110)
        Me.fgTongHopKy.Name = "fgTongHopKy"
        Me.fgTongHopKy.Rows.Count = 0
        Me.fgTongHopKy.Rows.Fixed = 0
        Me.fgTongHopKy.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopKy.Size = New System.Drawing.Size(515, 384)
        Me.fgTongHopKy.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopKy.Styles"))
        Me.fgTongHopKy.TabIndex = 118
        '
        'chkThanh_phan
        '
        Me.chkThanh_phan.AutoSize = True
        Me.chkThanh_phan.BackColor = System.Drawing.Color.Transparent
        Me.chkThanh_phan.Location = New System.Drawing.Point(616, 84)
        Me.chkThanh_phan.Name = "chkThanh_phan"
        Me.chkThanh_phan.Size = New System.Drawing.Size(171, 20)
        Me.chkThanh_phan.TabIndex = 127
        Me.chkThanh_phan.Text = "Hiển thị điểm thành phần"
        Me.chkThanh_phan.UseVisualStyleBackColor = False
        '
        'chkGhi_chu
        '
        Me.chkGhi_chu.AutoSize = True
        Me.chkGhi_chu.BackColor = System.Drawing.Color.Transparent
        Me.chkGhi_chu.Location = New System.Drawing.Point(452, 85)
        Me.chkGhi_chu.Name = "chkGhi_chu"
        Me.chkGhi_chu.Size = New System.Drawing.Size(149, 20)
        Me.chkGhi_chu.TabIndex = 126
        Me.chkGhi_chu.Text = "Hiển thị ghi chú điểm"
        Me.chkGhi_chu.UseVisualStyleBackColor = False
        '
        'optDiem10
        '
        Me.optDiem10.AutoSize = True
        Me.optDiem10.BackColor = System.Drawing.Color.Transparent
        Me.optDiem10.Location = New System.Drawing.Point(279, 85)
        Me.optDiem10.Name = "optDiem10"
        Me.optDiem10.Size = New System.Drawing.Size(156, 20)
        Me.optDiem10.TabIndex = 125
        Me.optDiem10.Text = "Hiển thị thang điểm 10"
        Me.optDiem10.UseVisualStyleBackColor = False
        '
        'optDiemSo
        '
        Me.optDiemSo.AutoSize = True
        Me.optDiemSo.BackColor = System.Drawing.Color.Transparent
        Me.optDiemSo.Location = New System.Drawing.Point(452, 59)
        Me.optDiemSo.Name = "optDiemSo"
        Me.optDiemSo.Size = New System.Drawing.Size(120, 20)
        Me.optDiemSo.TabIndex = 124
        Me.optDiemSo.Text = "Hiển thị điểm số"
        Me.optDiemSo.UseVisualStyleBackColor = False
        '
        'optDiemChu
        '
        Me.optDiemChu.AutoSize = True
        Me.optDiemChu.BackColor = System.Drawing.Color.Transparent
        Me.optDiemChu.Checked = True
        Me.optDiemChu.Location = New System.Drawing.Point(279, 59)
        Me.optDiemChu.Name = "optDiemChu"
        Me.optDiemChu.Size = New System.Drawing.Size(129, 20)
        Me.optDiemChu.TabIndex = 123
        Me.optDiemChu.TabStop = True
        Me.optDiemChu.Text = "Hiển thị điểm chữ"
        Me.optDiemChu.UseVisualStyleBackColor = False
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(473, 27)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(119, 24)
        Me.cmbNam_hoc.TabIndex = 117
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(611, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Khổ giấy:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKho_giay
        '
        Me.cmbKho_giay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKho_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKho_giay.Items.AddRange(New Object() {"A4 dọc", "A4 ngang", "A3 dọc", "A3 ngang"})
        Me.cmbKho_giay.Location = New System.Drawing.Point(708, 27)
        Me.cmbKho_giay.Name = "cmbKho_giay"
        Me.cmbKho_giay.Size = New System.Drawing.Size(75, 24)
        Me.cmbKho_giay.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(647, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"Lần 1", "Cao nhất"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(708, 57)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(75, 24)
        Me.cmbLan_thi.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(392, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(274, 27)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 114
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(340, 27)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(50, 24)
        Me.cmbHoc_ky.TabIndex = 115
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(4, 28)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(264, 537)
        Me.TreeViewLop.TabIndex = 128
        '
        'txtGhi_chu
        '
        Me.txtGhi_chu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGhi_chu.Location = New System.Drawing.Point(332, 500)
        Me.txtGhi_chu.MaxLength = 1500
        Me.txtGhi_chu.Multiline = True
        Me.txtGhi_chu.Name = "txtGhi_chu"
        Me.txtGhi_chu.Size = New System.Drawing.Size(455, 39)
        Me.txtGhi_chu.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(441, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Chức danh"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNguoi_ky
        '
        Me.txtNguoi_ky.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNguoi_ky.Location = New System.Drawing.Point(693, 541)
        Me.txtNguoi_ky.MaxLength = 200
        Me.txtNguoi_ky.Name = "txtNguoi_ky"
        Me.txtNguoi_ky.Size = New System.Drawing.Size(94, 22)
        Me.txtNguoi_ky.TabIndex = 149
        '
        'txtChuc_danh
        '
        Me.txtChuc_danh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtChuc_danh.Location = New System.Drawing.Point(522, 541)
        Me.txtChuc_danh.MaxLength = 200
        Me.txtChuc_danh.Name = "txtChuc_danh"
        Me.txtChuc_danh.Size = New System.Drawing.Size(101, 22)
        Me.txtChuc_danh.TabIndex = 148
        Me.txtChuc_danh.Text = "Trưởng Ban Khảo Thí & KĐCL"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(266, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Ghi chú"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNguoi_lap
        '
        Me.txtNguoi_lap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNguoi_lap.Location = New System.Drawing.Point(332, 541)
        Me.txtNguoi_lap.MaxLength = 200
        Me.txtNguoi_lap.Name = "txtNguoi_lap"
        Me.txtNguoi_lap.Size = New System.Drawing.Size(97, 22)
        Me.txtNguoi_lap.TabIndex = 146
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(265, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 22)
        Me.Label8.TabIndex = 150
        Me.Label8.Text = "Người lập"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(630, 541)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Người ký"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_DSHocBongHocPhi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.txtGhi_chu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNguoi_ky)
        Me.Controls.Add(Me.txtChuc_danh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNguoi_lap)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.fgTongHopKy)
        Me.Controls.Add(Me.chkThanh_phan)
        Me.Controls.Add(Me.chkGhi_chu)
        Me.Controls.Add(Me.optDiem10)
        Me.Controls.Add(Me.optDiemSo)
        Me.Controls.Add(Me.optDiemChu)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbKho_giay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_DSHocBongHocPhi"
        Me.Text = "Danh sách học bổng học phí"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdHienThi As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents fgTongHopKy As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkThanh_phan As System.Windows.Forms.CheckBox
    Friend WithEvents chkGhi_chu As System.Windows.Forms.CheckBox
    Friend WithEvents optDiem10 As System.Windows.Forms.RadioButton
    Friend WithEvents optDiemSo As System.Windows.Forms.RadioButton
    Friend WithEvents optDiemChu As System.Windows.Forms.RadioButton
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbKho_giay As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents TreeViewLop As ESSFinance.TreeViewLop
    Private WithEvents txtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNguoi_ky As System.Windows.Forms.TextBox
    Friend WithEvents txtChuc_danh As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNguoi_lap As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
