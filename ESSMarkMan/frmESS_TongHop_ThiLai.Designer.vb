<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHop_ThiLai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_TongHop_ThiLai))
        Me.fgTongHopKy = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.optDiemSo = New System.Windows.Forms.RadioButton
        Me.optDiemChu = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdTongHop = New System.Windows.Forms.ToolStripButton
        Me.cmbKho_giay = New System.Windows.Forms.ComboBox
        Me.TreeViewLop = New ESSMarkMan.TreeViewLop
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdPhanLoai_Lop = New System.Windows.Forms.ToolStripButton
        Me.cmdPhanLoaiHocTap_mon = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLan_thi = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
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
        Me.fgTongHopKy.Location = New System.Drawing.Point(264, 88)
        Me.fgTongHopKy.Name = "fgTongHopKy"
        Me.fgTongHopKy.Rows.Count = 0
        Me.fgTongHopKy.Rows.Fixed = 0
        Me.fgTongHopKy.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fgTongHopKy.Size = New System.Drawing.Size(529, 478)
        Me.fgTongHopKy.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgTongHopKy.Styles"))
        Me.fgTongHopKy.TabIndex = 120
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSMarkMan.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'optDiemSo
        '
        Me.optDiemSo.AutoSize = True
        Me.optDiemSo.BackColor = System.Drawing.Color.Transparent
        Me.optDiemSo.Location = New System.Drawing.Point(443, 63)
        Me.optDiemSo.Name = "optDiemSo"
        Me.optDiemSo.Size = New System.Drawing.Size(120, 20)
        Me.optDiemSo.TabIndex = 126
        Me.optDiemSo.Text = "Hiển thị điểm số"
        Me.optDiemSo.UseVisualStyleBackColor = False
        '
        'optDiemChu
        '
        Me.optDiemChu.AutoSize = True
        Me.optDiemChu.BackColor = System.Drawing.Color.Transparent
        Me.optDiemChu.Checked = True
        Me.optDiemChu.Location = New System.Drawing.Point(270, 63)
        Me.optDiemChu.Name = "optDiemChu"
        Me.optDiemChu.Size = New System.Drawing.Size(129, 20)
        Me.optDiemChu.TabIndex = 125
        Me.optDiemChu.TabStop = True
        Me.optDiemChu.Text = "Hiển thị điểm chữ"
        Me.optDiemChu.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(612, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Khổ giấy:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdTongHop
        '
        Me.cmdTongHop.Image = Global.ESSMarkMan.My.Resources.Resources.Import
        Me.cmdTongHop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTongHop.Name = "cmdTongHop"
        Me.cmdTongHop.Size = New System.Drawing.Size(90, 22)
        Me.cmdTongHop.Text = "Tổng hợp"
        '
        'cmbKho_giay
        '
        Me.cmbKho_giay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKho_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKho_giay.Items.AddRange(New Object() {"A4 dọc", "A4 ngang", "A3 dọc", "A3 ngang"})
        Me.cmbKho_giay.Location = New System.Drawing.Point(709, 31)
        Me.cmbKho_giay.Name = "cmbKho_giay"
        Me.cmbKho_giay.Size = New System.Drawing.Size(75, 24)
        Me.cmbKho_giay.TabIndex = 124
        '
        'TreeViewLop
        '
        Me.TreeViewLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewLop.BackColor = System.Drawing.Color.Transparent
        Me.TreeViewLop.dtLop = Nothing
        Me.TreeViewLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewLop.Location = New System.Drawing.Point(0, 29)
        Me.TreeViewLop.Name = "TreeViewLop"
        Me.TreeViewLop.Size = New System.Drawing.Size(264, 537)
        Me.TreeViewLop.TabIndex = 115
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTongHop, Me.cmdPhanLoai_Lop, Me.cmdPhanLoaiHocTap_mon, Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 114
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdPhanLoai_Lop
        '
        Me.cmdPhanLoai_Lop.Image = Global.ESSMarkMan.My.Resources.Resources.DoiChieuDuLieu
        Me.cmdPhanLoai_Lop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPhanLoai_Lop.Name = "cmdPhanLoai_Lop"
        Me.cmdPhanLoai_Lop.Size = New System.Drawing.Size(194, 22)
        Me.cmdPhanLoai_Lop.Text = "Phân loại học tập theo lớp"
        '
        'cmdPhanLoaiHocTap_mon
        '
        Me.cmdPhanLoaiHocTap_mon.Image = Global.ESSMarkMan.My.Resources.Resources.PhanLoaiHocTap
        Me.cmdPhanLoaiHocTap_mon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPhanLoaiHocTap_mon.Name = "cmdPhanLoaiHocTap_mon"
        Me.cmdPhanLoaiHocTap_mon.Size = New System.Drawing.Size(201, 22)
        Me.cmdPhanLoaiHocTap_mon.Text = "Phân loại học tập theo Học phần"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(94, 22)
        Me.cmdPrint.Text = "In báo cáo"
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(464, 31)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(119, 24)
        Me.cmbNam_hoc.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(648, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Lần thi:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thi
        '
        Me.cmbLan_thi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thi.Items.AddRange(New Object() {"Lần 1", "Cao nhất"})
        Me.cmbLan_thi.Location = New System.Drawing.Point(709, 61)
        Me.cmbLan_thi.Name = "cmbLan_thi"
        Me.cmbLan_thi.Size = New System.Drawing.Size(75, 24)
        Me.cmbLan_thi.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(383, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(265, 31)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(60, 24)
        Me.lblLan_cap.TabIndex = 116
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(331, 31)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(50, 24)
        Me.cmbHoc_ky.TabIndex = 117
        '
        'frmESS_TongHopThiLai
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.fgTongHopKy)
        Me.Controls.Add(Me.optDiemSo)
        Me.Controls.Add(Me.optDiemChu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbKho_giay)
        Me.Controls.Add(Me.TreeViewLop)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbLan_thi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLan_cap)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmESS_TongHopThiLai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tổng hợp thi lại"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fgTongHopKy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fgTongHopKy As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents optDiemSo As System.Windows.Forms.RadioButton
    Friend WithEvents optDiemChu As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdTongHop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbKho_giay As System.Windows.Forms.ComboBox
    Friend WithEvents TreeViewLop As ESSMarkMan.TreeViewLop
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPhanLoai_Lop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPhanLoaiHocTap_mon As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
End Class
