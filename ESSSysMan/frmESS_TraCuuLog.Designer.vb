<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TraCuuLog
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
        Me.grpThong_tin = New System.Windows.Forms.GroupBox
        Me.cmbPhan_he = New System.Windows.Forms.ComboBox
        Me.txtNoi_dung = New System.Windows.Forms.TextBox
        Me.lblNoi_dung = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpTu_ngay = New System.Windows.Forms.DateTimePicker
        Me.dtpDen_ngay = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPhan_he = New System.Windows.Forms.Label
        Me.txtChuc_nang = New System.Windows.Forms.TextBox
        Me.txtMay_tram = New System.Windows.Forms.TextBox
        Me.lblChuc_nang = New System.Windows.Forms.Label
        Me.cmbSu_kien = New System.Windows.Forms.ComboBox
        Me.lblMay_tram = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblSu_kien = New System.Windows.Forms.Label
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSearch = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.grdSuKienNguoiDung = New System.Windows.Forms.DataGridView
        Me.Chuc_nang = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_dung = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phan_he = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thoi_diem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.May_tram = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpThong_tin.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdSuKienNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpThong_tin
        '
        Me.grpThong_tin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThong_tin.BackColor = System.Drawing.Color.Transparent
        Me.grpThong_tin.Controls.Add(Me.cmbPhan_he)
        Me.grpThong_tin.Controls.Add(Me.txtNoi_dung)
        Me.grpThong_tin.Controls.Add(Me.lblNoi_dung)
        Me.grpThong_tin.Controls.Add(Me.Label3)
        Me.grpThong_tin.Controls.Add(Me.dtpTu_ngay)
        Me.grpThong_tin.Controls.Add(Me.dtpDen_ngay)
        Me.grpThong_tin.Controls.Add(Me.Label2)
        Me.grpThong_tin.Controls.Add(Me.lblPhan_he)
        Me.grpThong_tin.Controls.Add(Me.txtChuc_nang)
        Me.grpThong_tin.Controls.Add(Me.txtMay_tram)
        Me.grpThong_tin.Controls.Add(Me.lblChuc_nang)
        Me.grpThong_tin.Controls.Add(Me.cmbSu_kien)
        Me.grpThong_tin.Controls.Add(Me.lblMay_tram)
        Me.grpThong_tin.Controls.Add(Me.txtUser)
        Me.grpThong_tin.Controls.Add(Me.lblUser)
        Me.grpThong_tin.Controls.Add(Me.lblSu_kien)
        Me.grpThong_tin.Location = New System.Drawing.Point(4, 28)
        Me.grpThong_tin.Name = "grpThong_tin"
        Me.grpThong_tin.Size = New System.Drawing.Size(784, 113)
        Me.grpThong_tin.TabIndex = 39
        Me.grpThong_tin.TabStop = False
        Me.grpThong_tin.Text = "Thông tin tìm kiếm"
        '
        'cmbPhan_he
        '
        Me.cmbPhan_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhan_he.FormattingEnabled = True
        Me.cmbPhan_he.Location = New System.Drawing.Point(101, 22)
        Me.cmbPhan_he.Name = "cmbPhan_he"
        Me.cmbPhan_he.Size = New System.Drawing.Size(135, 24)
        Me.cmbPhan_he.TabIndex = 62
        '
        'txtNoi_dung
        '
        Me.txtNoi_dung.Location = New System.Drawing.Point(101, 82)
        Me.txtNoi_dung.MaxLength = 500
        Me.txtNoi_dung.Name = "txtNoi_dung"
        Me.txtNoi_dung.Size = New System.Drawing.Size(677, 23)
        Me.txtNoi_dung.TabIndex = 51
        '
        'lblNoi_dung
        '
        Me.lblNoi_dung.BackColor = System.Drawing.Color.Transparent
        Me.lblNoi_dung.Location = New System.Drawing.Point(6, 82)
        Me.lblNoi_dung.Name = "lblNoi_dung"
        Me.lblNoi_dung.Size = New System.Drawing.Size(93, 24)
        Me.lblNoi_dung.TabIndex = 56
        Me.lblNoi_dung.Text = "Nội dung:"
        Me.lblNoi_dung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(603, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 24)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Đến ngày:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.Checked = False
        Me.dtpTu_ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtpTu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu_ngay.Location = New System.Drawing.Point(493, 52)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.ShowCheckBox = True
        Me.dtpTu_ngay.Size = New System.Drawing.Size(104, 23)
        Me.dtpTu_ngay.TabIndex = 58
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.Checked = False
        Me.dtpDen_ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtpDen_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen_ngay.Location = New System.Drawing.Point(674, 53)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.ShowCheckBox = True
        Me.dtpDen_ngay.Size = New System.Drawing.Size(104, 23)
        Me.dtpDen_ngay.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(419, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Từ ngày:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhan_he
        '
        Me.lblPhan_he.BackColor = System.Drawing.Color.Transparent
        Me.lblPhan_he.Location = New System.Drawing.Point(2, 22)
        Me.lblPhan_he.Name = "lblPhan_he"
        Me.lblPhan_he.Size = New System.Drawing.Size(93, 24)
        Me.lblPhan_he.TabIndex = 49
        Me.lblPhan_he.Text = "Phân hệ:"
        Me.lblPhan_he.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtChuc_nang
        '
        Me.txtChuc_nang.Location = New System.Drawing.Point(101, 52)
        Me.txtChuc_nang.MaxLength = 50
        Me.txtChuc_nang.Name = "txtChuc_nang"
        Me.txtChuc_nang.Size = New System.Drawing.Size(135, 23)
        Me.txtChuc_nang.TabIndex = 48
        '
        'txtMay_tram
        '
        Me.txtMay_tram.Location = New System.Drawing.Point(325, 53)
        Me.txtMay_tram.MaxLength = 32
        Me.txtMay_tram.Name = "txtMay_tram"
        Me.txtMay_tram.Size = New System.Drawing.Size(88, 23)
        Me.txtMay_tram.TabIndex = 53
        '
        'lblChuc_nang
        '
        Me.lblChuc_nang.BackColor = System.Drawing.Color.Transparent
        Me.lblChuc_nang.Location = New System.Drawing.Point(2, 52)
        Me.lblChuc_nang.Name = "lblChuc_nang"
        Me.lblChuc_nang.Size = New System.Drawing.Size(93, 24)
        Me.lblChuc_nang.TabIndex = 52
        Me.lblChuc_nang.Text = "Chức năng:"
        Me.lblChuc_nang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSu_kien
        '
        Me.cmbSu_kien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSu_kien.Items.AddRange(New Object() {"Thêm", "Sửa", "Xoá"})
        Me.cmbSu_kien.Location = New System.Drawing.Point(325, 23)
        Me.cmbSu_kien.MaxDropDownItems = 4
        Me.cmbSu_kien.Name = "cmbSu_kien"
        Me.cmbSu_kien.Size = New System.Drawing.Size(128, 24)
        Me.cmbSu_kien.TabIndex = 50
        '
        'lblMay_tram
        '
        Me.lblMay_tram.BackColor = System.Drawing.Color.Transparent
        Me.lblMay_tram.Location = New System.Drawing.Point(241, 53)
        Me.lblMay_tram.Name = "lblMay_tram"
        Me.lblMay_tram.Size = New System.Drawing.Size(78, 24)
        Me.lblMay_tram.TabIndex = 57
        Me.lblMay_tram.Text = "Máy trạm:"
        Me.lblMay_tram.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(618, 24)
        Me.txtUser.MaxLength = 20
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(160, 23)
        Me.txtUser.TabIndex = 47
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Location = New System.Drawing.Point(490, 24)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(120, 24)
        Me.lblUser.TabIndex = 54
        Me.lblUser.Text = "Tên người dùng:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSu_kien
        '
        Me.lblSu_kien.BackColor = System.Drawing.Color.Transparent
        Me.lblSu_kien.Location = New System.Drawing.Point(241, 23)
        Me.lblSu_kien.Name = "lblSu_kien"
        Me.lblSu_kien.Size = New System.Drawing.Size(78, 24)
        Me.lblSu_kien.TabIndex = 55
        Me.lblSu_kien.Text = "Sự kiện:"
        Me.lblSu_kien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSearch, Me.cmdClose, Me.ToolStripButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 45
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.ESSSysMan.My.Resources.Resources.Search
        Me.cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(85, 22)
        Me.cmdSearch.Text = "&Tìm kiếm"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Th&oát"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ESSSysMan.My.Resources.Resources.Excel
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripButton1.Text = "Xuất Excel"
        '
        'grdSuKienNguoiDung
        '
        Me.grdSuKienNguoiDung.AllowUserToAddRows = False
        Me.grdSuKienNguoiDung.AllowUserToDeleteRows = False
        Me.grdSuKienNguoiDung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSuKienNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdSuKienNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdSuKienNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSuKienNguoiDung.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chuc_nang, Me.Noi_dung, Me.Phan_he, Me.Thoi_diem, Me.May_tram, Me.UserName})
        Me.grdSuKienNguoiDung.Location = New System.Drawing.Point(0, 147)
        Me.grdSuKienNguoiDung.Name = "grdSuKienNguoiDung"
        Me.grdSuKienNguoiDung.RowHeadersWidth = 25
        Me.grdSuKienNguoiDung.Size = New System.Drawing.Size(792, 420)
        Me.grdSuKienNguoiDung.TabIndex = 46
        '
        'Chuc_nang
        '
        Me.Chuc_nang.DataPropertyName = "Chuc_nang"
        Me.Chuc_nang.HeaderText = "Chức Năng"
        Me.Chuc_nang.Name = "Chuc_nang"
        Me.Chuc_nang.ReadOnly = True
        '
        'Noi_dung
        '
        Me.Noi_dung.DataPropertyName = "Noi_dung"
        Me.Noi_dung.HeaderText = "Nội dung"
        Me.Noi_dung.Name = "Noi_dung"
        Me.Noi_dung.ReadOnly = True
        '
        'Phan_he
        '
        Me.Phan_he.DataPropertyName = "Phan_he"
        Me.Phan_he.HeaderText = "Phân Hệ"
        Me.Phan_he.Name = "Phan_he"
        Me.Phan_he.ReadOnly = True
        '
        'Thoi_diem
        '
        Me.Thoi_diem.DataPropertyName = "Thoi_diem"
        Me.Thoi_diem.HeaderText = "Thời điểm"
        Me.Thoi_diem.Name = "Thoi_diem"
        Me.Thoi_diem.ReadOnly = True
        '
        'May_tram
        '
        Me.May_tram.DataPropertyName = "May_tram"
        Me.May_tram.HeaderText = "Máy trạm"
        Me.May_tram.Name = "May_tram"
        Me.May_tram.ReadOnly = True
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "Người dùng"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'frmESS_TraCuuLog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grdSuKienNguoiDung)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.grpThong_tin)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_TraCuuLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tra cứu Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpThong_tin.ResumeLayout(False)
        Me.grpThong_tin.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdSuKienNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpThong_tin As System.Windows.Forms.GroupBox
    Friend WithEvents lblPhan_he As System.Windows.Forms.Label
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpTu_ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMay_tram As System.Windows.Forms.TextBox
    Friend WithEvents dtpDen_ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmbSu_kien As System.Windows.Forms.ComboBox
    Friend WithEvents lblNoi_dung As System.Windows.Forms.Label
    Friend WithEvents lblChuc_nang As System.Windows.Forms.Label
    Friend WithEvents lblSu_kien As System.Windows.Forms.Label
    Friend WithEvents lblMay_tram As System.Windows.Forms.Label
    Friend WithEvents txtChuc_nang As System.Windows.Forms.TextBox
    Friend WithEvents txtNoi_dung As System.Windows.Forms.TextBox
    Friend WithEvents grdSuKienNguoiDung As System.Windows.Forms.DataGridView
    Friend WithEvents Chuc_nang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_dung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phan_he As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thoi_diem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents May_tram As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbPhan_he As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
