<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_PhucKhao
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdPhucKhaoThi = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.So_bao_danh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID_khoa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_khoa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diem2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ghi_chu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMonThi = New System.Windows.Forms.Label
        Me.lblHocKy = New System.Windows.Forms.Label
        Me.txtSo_sv = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdPhucKhaoThi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdDelete, Me.cmdPrint, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(804, 25)
        Me.ToolStrip.TabIndex = 52
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(86, 22)
        Me.cmdSave.Text = "Cập nhật"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdPhucKhaoThi
        '
        Me.grdPhucKhaoThi.AllowUserToAddRows = False
        Me.grdPhucKhaoThi.AllowUserToDeleteRows = False
        Me.grdPhucKhaoThi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPhucKhaoThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdPhucKhaoThi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.So_bao_danh, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop, Me.ID_khoa, Me.Ten_khoa, Me.Diem1, Me.Diem2, Me.Ghi_chu, Me.Ten_mon})
        Me.grdPhucKhaoThi.Location = New System.Drawing.Point(3, 120)
        Me.grdPhucKhaoThi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdPhucKhaoThi.Name = "grdPhucKhaoThi"
        Me.grdPhucKhaoThi.RowHeadersVisible = False
        Me.grdPhucKhaoThi.Size = New System.Drawing.Size(799, 443)
        Me.grdPhucKhaoThi.TabIndex = 54
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.FalseValue = "False"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.MinimumWidth = 50
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.TrueValue = "True"
        Me.Chon.Width = 63
        '
        'So_bao_danh
        '
        Me.So_bao_danh.DataPropertyName = "So_bao_danh"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_bao_danh.DefaultCellStyle = DataGridViewCellStyle1
        Me.So_bao_danh.HeaderText = "SBD"
        Me.So_bao_danh.MinimumWidth = 50
        Me.So_bao_danh.Name = "So_bao_danh"
        Me.So_bao_danh.ReadOnly = True
        Me.So_bao_danh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.So_bao_danh.Width = 60
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        Me.Ma_sv.HeaderText = "Mã sv"
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        Me.Ma_sv.Width = 67
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ho_ten.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ho_ten.HeaderText = "Họ tên"
        Me.Ho_ten.MinimumWidth = 100
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.MinimumWidth = 50
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        Me.Ngay_sinh.Width = 91
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Lớp"
        Me.Ten_lop.MinimumWidth = 50
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 56
        '
        'ID_khoa
        '
        Me.ID_khoa.DataPropertyName = "ID_khoa"
        Me.ID_khoa.HeaderText = "IDKhoa"
        Me.ID_khoa.Name = "ID_khoa"
        Me.ID_khoa.Visible = False
        Me.ID_khoa.Width = 75
        '
        'Ten_khoa
        '
        Me.Ten_khoa.DataPropertyName = "Ten_khoa"
        Me.Ten_khoa.HeaderText = "Khoa"
        Me.Ten_khoa.MinimumWidth = 50
        Me.Ten_khoa.Name = "Ten_khoa"
        Me.Ten_khoa.ReadOnly = True
        Me.Ten_khoa.Width = 63
        '
        'Diem1
        '
        Me.Diem1.DataPropertyName = "Diem1"
        Me.Diem1.HeaderText = "Điểm cũ"
        Me.Diem1.MinimumWidth = 50
        Me.Diem1.Name = "Diem1"
        Me.Diem1.Width = 81
        '
        'Diem2
        '
        Me.Diem2.DataPropertyName = "Diem2"
        Me.Diem2.HeaderText = "Điểm PK"
        Me.Diem2.MinimumWidth = 50
        Me.Diem2.Name = "Diem2"
        Me.Diem2.Width = 85
        '
        'Ghi_chu
        '
        Me.Ghi_chu.DataPropertyName = "Ghi_chu"
        Me.Ghi_chu.HeaderText = "Ghi chú"
        Me.Ghi_chu.MinimumWidth = 50
        Me.Ghi_chu.Name = "Ghi_chu"
        Me.Ghi_chu.ReadOnly = True
        Me.Ghi_chu.Width = 78
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.HeaderText = "Học phần thi"
        Me.Ten_mon.MinimumWidth = 50
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Visible = False
        Me.Ten_mon.Width = 76
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Location = New System.Drawing.Point(298, 91)
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(121, 22)
        Me.txtHo_ten.TabIndex = 72
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(131, 91)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(88, 22)
        Me.txtMa_sv.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Lọc theo : Mã SV"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.FormattingEnabled = True
        Me.cmbID_khoa.Location = New System.Drawing.Point(513, 90)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(136, 24)
        Me.cmbID_khoa.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(457, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Ngành:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(234, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Họ tên:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMonThi
        '
        Me.lblMonThi.BackColor = System.Drawing.Color.Transparent
        Me.lblMonThi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonThi.Location = New System.Drawing.Point(20, 30)
        Me.lblMonThi.Name = "lblMonThi"
        Me.lblMonThi.Size = New System.Drawing.Size(766, 19)
        Me.lblMonThi.TabIndex = 73
        Me.lblMonThi.Text = "DANH SÁCH PHÚC KHẢO Học phần THI"
        Me.lblMonThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHocKy
        '
        Me.lblHocKy.BackColor = System.Drawing.Color.Transparent
        Me.lblHocKy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHocKy.Location = New System.Drawing.Point(20, 59)
        Me.lblHocKy.Name = "lblHocKy"
        Me.lblHocKy.Size = New System.Drawing.Size(766, 17)
        Me.lblHocKy.TabIndex = 74
        Me.lblHocKy.Text = "DANH SÁCH PHÚC KHẢO Học phần THI"
        Me.lblHocKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSo_sv
        '
        Me.txtSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSo_sv.Location = New System.Drawing.Point(667, 92)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(125, 18)
        Me.txtSo_sv.TabIndex = 75
        Me.txtSo_sv.Text = "Số sinh viên"
        Me.txtSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmESS_ToChucThiPhucKhao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 568)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.lblHocKy)
        Me.Controls.Add(Me.lblMonThi)
        Me.Controls.Add(Me.txtHo_ten)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdPhucKhaoThi)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_ToChucThiPhucKhao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Phúc khảo thi"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdPhucKhaoThi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdPhucKhaoThi As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMonThi As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblHocKy As System.Windows.Forms.Label
    Friend WithEvents txtSo_sv As System.Windows.Forms.Label
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents So_bao_danh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_khoa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_khoa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diem2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ghi_chu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
