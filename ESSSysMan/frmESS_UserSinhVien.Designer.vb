<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_UserSinhVien
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdDanhSachSinhVien = New System.Windows.Forms.DataGridView
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mat_khau = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdCreate = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.chkNgay_sinh = New System.Windows.Forms.CheckBox
        Me.chkMa_sv = New System.Windows.Forms.CheckBox
        Me.lblTao_mk = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.trvLop = New ESSSysMan.TreeViewLop
        CType(Me.grdDanhSachSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDanhSachSinhVien
        '
        Me.grdDanhSachSinhVien.AllowUserToAddRows = False
        Me.grdDanhSachSinhVien.AllowUserToDeleteRows = False
        Me.grdDanhSachSinhVien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSachSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSachSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSachSinhVien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSachSinhVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Active, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Mat_khau})
        Me.grdDanhSachSinhVien.Location = New System.Drawing.Point(261, 112)
        Me.grdDanhSachSinhVien.Name = "grdDanhSachSinhVien"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSachSinhVien.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdDanhSachSinhVien.RowHeadersVisible = False
        Me.grdDanhSachSinhVien.Size = New System.Drawing.Size(530, 454)
        Me.grdDanhSachSinhVien.TabIndex = 5
        '
        'Active
        '
        Me.Active.DataPropertyName = "Active"
        Me.Active.HeaderText = "Active"
        Me.Active.MinimumWidth = 60
        Me.Active.Name = "Active"
        Me.Active.Width = 60
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ma_sv.HeaderText = "Mã sinh viên"
        Me.Ma_sv.MinimumWidth = 130
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        Me.Ma_sv.Width = 130
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.MinimumWidth = 300
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 300
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        DataGridViewCellStyle3.NullValue = "   "
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.MinimumWidth = 110
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        Me.Ngay_sinh.Width = 110
        '
        'Mat_khau
        '
        Me.Mat_khau.DataPropertyName = "Mat_khau"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Mat_khau.DefaultCellStyle = DataGridViewCellStyle4
        Me.Mat_khau.HeaderText = "Mật khẩu"
        Me.Mat_khau.MinimumWidth = 150
        Me.Mat_khau.Name = "Mat_khau"
        Me.Mat_khau.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCreate, Me.cmdSave, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdCreate
        '
        Me.cmdCreate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdCreate.Image = Global.ESSSysMan.My.Resources.Resources.Import
        Me.cmdCreate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(168, 22)
        Me.cmdCreate.Text = "Tạo mật khẩu tự động"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSSysMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Location = New System.Drawing.Point(273, 32)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(142, 20)
        Me.chkAll.TabIndex = 24
        Me.chkAll.Text = "Chọn tất cả Active"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'chkNgay_sinh
        '
        Me.chkNgay_sinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNgay_sinh.BackColor = System.Drawing.Color.Transparent
        Me.chkNgay_sinh.Location = New System.Drawing.Point(697, 32)
        Me.chkNgay_sinh.Name = "chkNgay_sinh"
        Me.chkNgay_sinh.Size = New System.Drawing.Size(89, 20)
        Me.chkNgay_sinh.TabIndex = 27
        Me.chkNgay_sinh.Text = "Ngày sinh"
        Me.chkNgay_sinh.UseVisualStyleBackColor = False
        '
        'chkMa_sv
        '
        Me.chkMa_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMa_sv.BackColor = System.Drawing.Color.Transparent
        Me.chkMa_sv.Location = New System.Drawing.Point(570, 32)
        Me.chkMa_sv.Name = "chkMa_sv"
        Me.chkMa_sv.Size = New System.Drawing.Size(106, 20)
        Me.chkMa_sv.TabIndex = 26
        Me.chkMa_sv.Text = "Mã sinh viên"
        Me.chkMa_sv.UseVisualStyleBackColor = False
        '
        'lblTao_mk
        '
        Me.lblTao_mk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTao_mk.BackColor = System.Drawing.Color.Transparent
        Me.lblTao_mk.Location = New System.Drawing.Point(403, 32)
        Me.lblTao_mk.Name = "lblTao_mk"
        Me.lblTao_mk.Size = New System.Drawing.Size(161, 20)
        Me.lblTao_mk.TabIndex = 25
        Me.lblTao_mk.Text = "Tạo mật khẩu sinh viên theo:"
        Me.lblTao_mk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(679, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "+"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHo_ten)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMa_sv)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 56)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Điều kiện lọc sinh viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ tên"
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Location = New System.Drawing.Point(286, 22)
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(213, 23)
        Me.txtHo_ten.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã sinh viên"
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(102, 22)
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(123, 23)
        Me.txtMa_sv.TabIndex = 0
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(0, 28)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(264, 538)
        Me.trvLop.TabIndex = 31
        '
        'frmESS_UserSinhVien
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkNgay_sinh)
        Me.Controls.Add(Me.chkMa_sv)
        Me.Controls.Add(Me.lblTao_mk)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdDanhSachSinhVien)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmESS_UserSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cấp quyền cho sinh viên"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdDanhSachSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDanhSachSinhVien As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdCreate As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkNgay_sinh As System.Windows.Forms.CheckBox
    Friend WithEvents chkMa_sv As System.Windows.Forms.CheckBox
    Friend WithEvents lblTao_mk As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents trvLop As ESSSysMan.TreeViewLop
    Friend WithEvents Active As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mat_khau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
End Class
