<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_PhanBoQuyHocBong
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdPhanTuDong = New System.Windows.Forms.ToolStripButton
        Me.cmdPhanThuCong = New System.Windows.Forms.ToolStripButton
        Me.cmdPrintTK = New System.Windows.Forms.ToolStripButton
        Me.cmdView = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.chkLop = New System.Windows.Forms.CheckBox
        Me.chkChuyen_nganh = New System.Windows.Forms.CheckBox
        Me.chkKhoa_hoc = New System.Windows.Forms.CheckBox
        Me.chkKhoa = New System.Windows.Forms.CheckBox
        Me.txtSotien_dacap_chu = New System.Windows.Forms.Label
        Me.txtSotien_chu = New System.Windows.Forms.Label
        Me.lblSotien_dacap = New System.Windows.Forms.Label
        Me.txtSotien_dacap = New System.Windows.Forms.TextBox
        Me.txtSotien = New System.Windows.Forms.TextBox
        Me.txtSotien_conlai = New System.Windows.Forms.TextBox
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.lblHe = New System.Windows.Forms.Label
        Me.lblSotien = New System.Windows.Forms.Label
        Me.lblLoai_quy = New System.Windows.Forms.Label
        Me.cmbID_quy = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblHoc_ky = New System.Windows.Forms.Label
        Me.lblNam_hoc = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSotien_conlai_chu = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkNganh = New System.Windows.Forms.CheckBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdViewPhanBo = New System.Windows.Forms.DataGridView
        Me.Ten_phan_bo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kieu_phan_bo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewPhanBo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPhanTuDong, Me.cmdPhanThuCong, Me.cmdPrintTK, Me.cmdView, Me.cmdSave, Me.cmdDelete, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdPhanTuDong
        '
        Me.cmdPhanTuDong.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdPhanTuDong.Image = Global.ESSFinance.My.Resources.Resources.Import
        Me.cmdPhanTuDong.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPhanTuDong.Name = "cmdPhanTuDong"
        Me.cmdPhanTuDong.Size = New System.Drawing.Size(141, 22)
        Me.cmdPhanTuDong.Text = "Phân quỹ tự động"
        '
        'cmdPhanThuCong
        '
        Me.cmdPhanThuCong.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdPhanThuCong.Image = Global.ESSFinance.My.Resources.Resources.CauHinh
        Me.cmdPhanThuCong.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPhanThuCong.Name = "cmdPhanThuCong"
        Me.cmdPhanThuCong.Size = New System.Drawing.Size(147, 22)
        Me.cmdPhanThuCong.Text = "Phân quỹ thủ công"
        '
        'cmdPrintTK
        '
        Me.cmdPrintTK.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdPrintTK.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrintTK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintTK.Name = "cmdPrintTK"
        Me.cmdPrintTK.Size = New System.Drawing.Size(140, 22)
        Me.cmdPrintTK.Text = "TK số liệu trợ cấp"
        Me.cmdPrintTK.Visible = False
        '
        'cmdView
        '
        Me.cmdView.Image = Global.ESSFinance.My.Resources.Resources.Edit
        Me.cmdView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(100, 22)
        Me.cmdView.Text = "Xem chi tiết"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSFinance.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "Xoá"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'chkLop
        '
        Me.chkLop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLop.Location = New System.Drawing.Point(15, 98)
        Me.chkLop.Name = "chkLop"
        Me.chkLop.Size = New System.Drawing.Size(80, 24)
        Me.chkLop.TabIndex = 7
        Me.chkLop.Text = "Lớp học"
        '
        'chkChuyen_nganh
        '
        Me.chkChuyen_nganh.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChuyen_nganh.Location = New System.Drawing.Point(15, 98)
        Me.chkChuyen_nganh.Name = "chkChuyen_nganh"
        Me.chkChuyen_nganh.Size = New System.Drawing.Size(120, 24)
        Me.chkChuyen_nganh.TabIndex = 6
        Me.chkChuyen_nganh.Text = "Chuyên ngành"
        Me.chkChuyen_nganh.Visible = False
        '
        'chkKhoa_hoc
        '
        Me.chkKhoa_hoc.Checked = True
        Me.chkKhoa_hoc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKhoa_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKhoa_hoc.Location = New System.Drawing.Point(15, 48)
        Me.chkKhoa_hoc.Name = "chkKhoa_hoc"
        Me.chkKhoa_hoc.Size = New System.Drawing.Size(88, 24)
        Me.chkKhoa_hoc.TabIndex = 5
        Me.chkKhoa_hoc.Text = "Khoá học"
        '
        'chkKhoa
        '
        Me.chkKhoa.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKhoa.Location = New System.Drawing.Point(15, 22)
        Me.chkKhoa.Name = "chkKhoa"
        Me.chkKhoa.Size = New System.Drawing.Size(64, 24)
        Me.chkKhoa.TabIndex = 4
        Me.chkKhoa.Text = "Khoa"
        '
        'txtSotien_dacap_chu
        '
        Me.txtSotien_dacap_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSotien_dacap_chu.BackColor = System.Drawing.Color.Transparent
        Me.txtSotien_dacap_chu.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic)
        Me.txtSotien_dacap_chu.ForeColor = System.Drawing.Color.Black
        Me.txtSotien_dacap_chu.Location = New System.Drawing.Point(224, 111)
        Me.txtSotien_dacap_chu.Name = "txtSotien_dacap_chu"
        Me.txtSotien_dacap_chu.Size = New System.Drawing.Size(398, 23)
        Me.txtSotien_dacap_chu.TabIndex = 142
        Me.txtSotien_dacap_chu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSotien_chu
        '
        Me.txtSotien_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSotien_chu.BackColor = System.Drawing.Color.Transparent
        Me.txtSotien_chu.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic)
        Me.txtSotien_chu.ForeColor = System.Drawing.Color.Black
        Me.txtSotien_chu.Location = New System.Drawing.Point(224, 82)
        Me.txtSotien_chu.Name = "txtSotien_chu"
        Me.txtSotien_chu.Size = New System.Drawing.Size(398, 23)
        Me.txtSotien_chu.TabIndex = 141
        Me.txtSotien_chu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSotien_dacap
        '
        Me.lblSotien_dacap.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien_dacap.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien_dacap.Location = New System.Drawing.Point(-7, 110)
        Me.lblSotien_dacap.Name = "lblSotien_dacap"
        Me.lblSotien_dacap.Size = New System.Drawing.Size(120, 19)
        Me.lblSotien_dacap.TabIndex = 138
        Me.lblSotien_dacap.Text = "Số tiền đã phân:"
        Me.lblSotien_dacap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSotien_dacap
        '
        Me.txtSotien_dacap.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien_dacap.Location = New System.Drawing.Point(118, 110)
        Me.txtSotien_dacap.MaxLength = 12
        Me.txtSotien_dacap.Name = "txtSotien_dacap"
        Me.txtSotien_dacap.ReadOnly = True
        Me.txtSotien_dacap.Size = New System.Drawing.Size(98, 23)
        Me.txtSotien_dacap.TabIndex = 132
        Me.txtSotien_dacap.TabStop = False
        Me.txtSotien_dacap.Text = "0"
        Me.txtSotien_dacap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSotien
        '
        Me.txtSotien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien.Location = New System.Drawing.Point(118, 81)
        Me.txtSotien.MaxLength = 12
        Me.txtSotien.Name = "txtSotien"
        Me.txtSotien.ReadOnly = True
        Me.txtSotien.Size = New System.Drawing.Size(98, 23)
        Me.txtSotien.TabIndex = 131
        Me.txtSotien.TabStop = False
        Me.txtSotien.Text = "0"
        Me.txtSotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSotien_conlai
        '
        Me.txtSotien_conlai.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien_conlai.Location = New System.Drawing.Point(118, 141)
        Me.txtSotien_conlai.MaxLength = 12
        Me.txtSotien_conlai.Name = "txtSotien_conlai"
        Me.txtSotien_conlai.ReadOnly = True
        Me.txtSotien_conlai.Size = New System.Drawing.Size(98, 23)
        Me.txtSotien_conlai.TabIndex = 133
        Me.txtSotien_conlai.TabStop = False
        Me.txtSotien_conlai.Text = "0"
        Me.txtSotien_conlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(118, 52)
        Me.cmbID_he.MaxDropDownItems = 5
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(184, 24)
        Me.cmbID_he.TabIndex = 130
        '
        'lblHe
        '
        Me.lblHe.BackColor = System.Drawing.Color.Transparent
        Me.lblHe.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHe.Location = New System.Drawing.Point(47, 52)
        Me.lblHe.Name = "lblHe"
        Me.lblHe.Size = New System.Drawing.Size(65, 22)
        Me.lblHe.TabIndex = 139
        Me.lblHe.Text = "Hệ:"
        Me.lblHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSotien
        '
        Me.lblSotien.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien.Location = New System.Drawing.Point(8, 81)
        Me.lblSotien.Name = "lblSotien"
        Me.lblSotien.Size = New System.Drawing.Size(105, 22)
        Me.lblSotien.TabIndex = 137
        Me.lblSotien.Text = "Số tiền quỹ:"
        Me.lblSotien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLoai_quy
        '
        Me.lblLoai_quy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoai_quy.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_quy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_quy.Location = New System.Drawing.Point(308, 54)
        Me.lblLoai_quy.Name = "lblLoai_quy"
        Me.lblLoai_quy.Size = New System.Drawing.Size(68, 22)
        Me.lblLoai_quy.TabIndex = 136
        Me.lblLoai_quy.Text = "Loại quỹ:"
        Me.lblLoai_quy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_quy
        '
        Me.cmbID_quy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_quy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_quy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_quy.Location = New System.Drawing.Point(382, 52)
        Me.cmbID_quy.MaxDropDownItems = 5
        Me.cmbID_quy.Name = "cmbID_quy"
        Me.cmbID_quy.Size = New System.Drawing.Size(240, 24)
        Me.cmbID_quy.TabIndex = 129
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNam_hoc.Location = New System.Drawing.Point(502, 22)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(120, 24)
        Me.cmbNam_hoc.TabIndex = 128
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoc_ky.Location = New System.Drawing.Point(118, 22)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(71, 24)
        Me.cmbHoc_ky.TabIndex = 127
        '
        'lblHoc_ky
        '
        Me.lblHoc_ky.BackColor = System.Drawing.Color.Transparent
        Me.lblHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoc_ky.Location = New System.Drawing.Point(44, 22)
        Me.lblHoc_ky.Name = "lblHoc_ky"
        Me.lblHoc_ky.Size = New System.Drawing.Size(68, 23)
        Me.lblHoc_ky.TabIndex = 134
        Me.lblHoc_ky.Text = "Học kỳ:"
        Me.lblHoc_ky.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNam_hoc
        '
        Me.lblNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNam_hoc.BackColor = System.Drawing.Color.Transparent
        Me.lblNam_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam_hoc.Location = New System.Drawing.Point(416, 23)
        Me.lblNam_hoc.Name = "lblNam_hoc"
        Me.lblNam_hoc.Size = New System.Drawing.Size(80, 22)
        Me.lblNam_hoc.TabIndex = 135
        Me.lblNam_hoc.Text = "Năm học:"
        Me.lblNam_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-8, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Số tiền còn lại:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSotien_conlai_chu
        '
        Me.txtSotien_conlai_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSotien_conlai_chu.BackColor = System.Drawing.Color.Transparent
        Me.txtSotien_conlai_chu.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic)
        Me.txtSotien_conlai_chu.ForeColor = System.Drawing.Color.Black
        Me.txtSotien_conlai_chu.Location = New System.Drawing.Point(224, 142)
        Me.txtSotien_conlai_chu.Name = "txtSotien_conlai_chu"
        Me.txtSotien_conlai_chu.Size = New System.Drawing.Size(398, 23)
        Me.txtSotien_conlai_chu.TabIndex = 143
        Me.txtSotien_conlai_chu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtSotien_conlai_chu)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSotien_conlai)
        Me.GroupBox2.Controls.Add(Me.txtSotien_dacap_chu)
        Me.GroupBox2.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox2.Controls.Add(Me.lblSotien_dacap)
        Me.GroupBox2.Controls.Add(Me.txtSotien_chu)
        Me.GroupBox2.Controls.Add(Me.txtSotien_dacap)
        Me.GroupBox2.Controls.Add(Me.lblHoc_ky)
        Me.GroupBox2.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox2.Controls.Add(Me.lblNam_hoc)
        Me.GroupBox2.Controls.Add(Me.txtSotien)
        Me.GroupBox2.Controls.Add(Me.cmbID_quy)
        Me.GroupBox2.Controls.Add(Me.lblLoai_quy)
        Me.GroupBox2.Controls.Add(Me.lblSotien)
        Me.GroupBox2.Controls.Add(Me.lblHe)
        Me.GroupBox2.Controls.Add(Me.cmbID_he)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 176)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chọn quỹ học bổng để phân bổ"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chkNganh)
        Me.GroupBox3.Controls.Add(Me.chkLop)
        Me.GroupBox3.Controls.Add(Me.chkKhoa)
        Me.GroupBox3.Controls.Add(Me.chkChuyen_nganh)
        Me.GroupBox3.Controls.Add(Me.chkKhoa_hoc)
        Me.GroupBox3.Location = New System.Drawing.Point(638, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 176)
        Me.GroupBox3.TabIndex = 133
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Phân bổ quỹ theo"
        '
        'chkNganh
        '
        Me.chkNganh.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNganh.Location = New System.Drawing.Point(15, 73)
        Me.chkNganh.Name = "chkNganh"
        Me.chkNganh.Size = New System.Drawing.Size(120, 24)
        Me.chkNganh.TabIndex = 8
        Me.chkNganh.Text = "Ngành học"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grdViewPhanBo
        '
        Me.grdViewPhanBo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewPhanBo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewPhanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewPhanBo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_phan_bo, Me.So_sv, Me.So_tien, Me.Kieu_phan_bo})
        Me.grdViewPhanBo.Location = New System.Drawing.Point(4, 211)
        Me.grdViewPhanBo.Name = "grdViewPhanBo"
        Me.grdViewPhanBo.Size = New System.Drawing.Size(776, 350)
        Me.grdViewPhanBo.TabIndex = 154
        '
        'Ten_phan_bo
        '
        Me.Ten_phan_bo.DataPropertyName = "Ten_phan_bo"
        Me.Ten_phan_bo.HeaderText = "Tên phân bổ"
        Me.Ten_phan_bo.MinimumWidth = 300
        Me.Ten_phan_bo.Name = "Ten_phan_bo"
        Me.Ten_phan_bo.ReadOnly = True
        Me.Ten_phan_bo.Width = 300
        '
        'So_sv
        '
        Me.So_sv.DataPropertyName = "So_sv"
        Me.So_sv.HeaderText = "Số sinh viên"
        Me.So_sv.MinimumWidth = 150
        Me.So_sv.Name = "So_sv"
        Me.So_sv.ReadOnly = True
        Me.So_sv.Width = 150
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        Me.So_tien.HeaderText = "Số tiền phân bổ"
        Me.So_tien.MinimumWidth = 150
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        Me.So_tien.Width = 150
        '
        'Kieu_phan_bo
        '
        Me.Kieu_phan_bo.DataPropertyName = "Kieu_phan_bo"
        Me.Kieu_phan_bo.HeaderText = "Kiểu phân bổ"
        Me.Kieu_phan_bo.MinimumWidth = 120
        Me.Kieu_phan_bo.Name = "Kieu_phan_bo"
        Me.Kieu_phan_bo.ReadOnly = True
        Me.Kieu_phan_bo.Width = 120
        '
        'frmESS_PhanBoQuyHocBong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grdViewPhanBo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_PhanBoQuyHocBong"
        Me.Text = "Phân bổ quỹ học bổng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewPhanBo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdPhanTuDong As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdPhanThuCong As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkLop As System.Windows.Forms.CheckBox
    Friend WithEvents chkChuyen_nganh As System.Windows.Forms.CheckBox
    Friend WithEvents chkKhoa_hoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkKhoa As System.Windows.Forms.CheckBox
    Friend WithEvents txtSotien_dacap_chu As System.Windows.Forms.Label
    Friend WithEvents txtSotien_chu As System.Windows.Forms.Label
    Friend WithEvents lblSotien_dacap As System.Windows.Forms.Label
    Friend WithEvents txtSotien_dacap As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien_conlai As System.Windows.Forms.TextBox
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents lblHe As System.Windows.Forms.Label
    Friend WithEvents lblSotien As System.Windows.Forms.Label
    Friend WithEvents lblLoai_quy As System.Windows.Forms.Label
    Friend WithEvents cmbID_quy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoc_ky As System.Windows.Forms.Label
    Friend WithEvents lblNam_hoc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSotien_conlai_chu As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grdViewPhanBo As System.Windows.Forms.DataGridView
    Friend WithEvents Ten_phan_bo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kieu_phan_bo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkNganh As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrintTK As System.Windows.Forms.ToolStripButton
End Class
