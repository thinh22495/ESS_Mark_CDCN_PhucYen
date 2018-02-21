<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetHocBong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_XetHocBong))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbID_phan_bo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.lblHe = New System.Windows.Forms.Label
        Me.cmbID_quy = New System.Windows.Forms.ComboBox
        Me.lblQuy_hb = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblHoc_ky = New System.Windows.Forms.Label
        Me.lblNam_hoc = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSo_sv = New System.Windows.Forms.TextBox
        Me.txtSotien_con = New System.Windows.Forms.TextBox
        Me.txtTong_sotien = New System.Windows.Forms.TextBox
        Me.lblSo_svHB = New System.Windows.Forms.Label
        Me.lblSotien_con = New System.Windows.Forms.Label
        Me.lblSotien_chi = New System.Windows.Forms.Label
        Me.lblTong_sotien = New System.Windows.Forms.Label
        Me.lblTien_trocap = New System.Windows.Forms.Label
        Me.txtSotien_chi = New System.Windows.Forms.TextBox
        Me.txtTien_trocap = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdProcess = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint_ds = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint_HBHT = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdView = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Xep_loai_HT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Xep_loai_RL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Xep_loai_HB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_mon_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Xu_ly_ky_luat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TBCHT10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TBCHT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tong_diem_rl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HB_CS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tong_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.optDa_xet = New System.Windows.Forms.RadioButton
        Me.optChua_xet = New System.Windows.Forms.RadioButton
        Me.lblTong_so = New System.Windows.Forms.Label
        Me.lblNum_sv = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbID_phan_bo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbID_he)
        Me.GroupBox1.Controls.Add(Me.lblHe)
        Me.GroupBox1.Controls.Add(Me.cmbID_quy)
        Me.GroupBox1.Controls.Add(Me.lblQuy_hb)
        Me.GroupBox1.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox1.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox1.Controls.Add(Me.lblHoc_ky)
        Me.GroupBox1.Controls.Add(Me.lblNam_hoc)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chọn quỹ học bổng"
        '
        'cmbID_phan_bo
        '
        Me.cmbID_phan_bo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_phan_bo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_phan_bo.Location = New System.Drawing.Point(126, 121)
        Me.cmbID_phan_bo.MaxDropDownItems = 5
        Me.cmbID_phan_bo.Name = "cmbID_phan_bo"
        Me.cmbID_phan_bo.Size = New System.Drawing.Size(288, 24)
        Me.cmbID_phan_bo.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-6, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Đối tượng phân bổ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(126, 88)
        Me.cmbID_he.MaxDropDownItems = 5
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(288, 24)
        Me.cmbID_he.TabIndex = 112
        '
        'lblHe
        '
        Me.lblHe.BackColor = System.Drawing.Color.Transparent
        Me.lblHe.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHe.Location = New System.Drawing.Point(6, 89)
        Me.lblHe.Name = "lblHe"
        Me.lblHe.Size = New System.Drawing.Size(124, 22)
        Me.lblHe.TabIndex = 116
        Me.lblHe.Text = "Hệ đào tạo:"
        Me.lblHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_quy
        '
        Me.cmbID_quy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_quy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_quy.Location = New System.Drawing.Point(126, 56)
        Me.cmbID_quy.MaxDropDownItems = 5
        Me.cmbID_quy.Name = "cmbID_quy"
        Me.cmbID_quy.Size = New System.Drawing.Size(288, 24)
        Me.cmbID_quy.TabIndex = 111
        '
        'lblQuy_hb
        '
        Me.lblQuy_hb.BackColor = System.Drawing.Color.Transparent
        Me.lblQuy_hb.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuy_hb.Location = New System.Drawing.Point(0, 57)
        Me.lblQuy_hb.Name = "lblQuy_hb"
        Me.lblQuy_hb.Size = New System.Drawing.Size(130, 22)
        Me.lblQuy_hb.TabIndex = 115
        Me.lblQuy_hb.Text = "Loại quỹ học bổng:"
        Me.lblQuy_hb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNam_hoc.Location = New System.Drawing.Point(294, 24)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(120, 24)
        Me.cmbNam_hoc.TabIndex = 110
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoc_ky.Location = New System.Drawing.Point(126, 24)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(60, 24)
        Me.cmbHoc_ky.TabIndex = 109
        '
        'lblHoc_ky
        '
        Me.lblHoc_ky.BackColor = System.Drawing.Color.Transparent
        Me.lblHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoc_ky.Location = New System.Drawing.Point(6, 25)
        Me.lblHoc_ky.Name = "lblHoc_ky"
        Me.lblHoc_ky.Size = New System.Drawing.Size(120, 22)
        Me.lblHoc_ky.TabIndex = 113
        Me.lblHoc_ky.Text = "Học kỳ:"
        Me.lblHoc_ky.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNam_hoc
        '
        Me.lblNam_hoc.BackColor = System.Drawing.Color.Transparent
        Me.lblNam_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam_hoc.Location = New System.Drawing.Point(210, 25)
        Me.lblNam_hoc.Name = "lblNam_hoc"
        Me.lblNam_hoc.Size = New System.Drawing.Size(80, 22)
        Me.lblNam_hoc.TabIndex = 114
        Me.lblNam_hoc.Text = "Năm học:"
        Me.lblNam_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtSo_sv)
        Me.GroupBox2.Controls.Add(Me.txtSotien_con)
        Me.GroupBox2.Controls.Add(Me.txtTong_sotien)
        Me.GroupBox2.Controls.Add(Me.lblSo_svHB)
        Me.GroupBox2.Controls.Add(Me.lblSotien_con)
        Me.GroupBox2.Controls.Add(Me.lblSotien_chi)
        Me.GroupBox2.Controls.Add(Me.lblTong_sotien)
        Me.GroupBox2.Controls.Add(Me.lblTien_trocap)
        Me.GroupBox2.Controls.Add(Me.txtSotien_chi)
        Me.GroupBox2.Controls.Add(Me.txtTien_trocap)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiền quỹ học bổng phân bổ"
        '
        'txtSo_sv
        '
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_sv.Location = New System.Drawing.Point(210, 121)
        Me.txtSo_sv.MaxLength = 12
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.ReadOnly = True
        Me.txtSo_sv.Size = New System.Drawing.Size(129, 23)
        Me.txtSo_sv.TabIndex = 125
        Me.txtSo_sv.TabStop = False
        Me.txtSo_sv.Text = "0"
        Me.txtSo_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSotien_con
        '
        Me.txtSotien_con.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien_con.Location = New System.Drawing.Point(210, 87)
        Me.txtSotien_con.MaxLength = 12
        Me.txtSotien_con.Name = "txtSotien_con"
        Me.txtSotien_con.ReadOnly = True
        Me.txtSotien_con.Size = New System.Drawing.Size(129, 23)
        Me.txtSotien_con.TabIndex = 123
        Me.txtSotien_con.TabStop = False
        Me.txtSotien_con.Text = "0"
        Me.txtSotien_con.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTong_sotien
        '
        Me.txtTong_sotien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTong_sotien.Location = New System.Drawing.Point(210, 22)
        Me.txtTong_sotien.MaxLength = 12
        Me.txtTong_sotien.Name = "txtTong_sotien"
        Me.txtTong_sotien.ReadOnly = True
        Me.txtTong_sotien.Size = New System.Drawing.Size(129, 23)
        Me.txtTong_sotien.TabIndex = 119
        Me.txtTong_sotien.TabStop = False
        Me.txtTong_sotien.Text = "0"
        Me.txtTong_sotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSo_svHB
        '
        Me.lblSo_svHB.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_svHB.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_svHB.Location = New System.Drawing.Point(6, 121)
        Me.lblSo_svHB.Name = "lblSo_svHB"
        Me.lblSo_svHB.Size = New System.Drawing.Size(198, 22)
        Me.lblSo_svHB.TabIndex = 126
        Me.lblSo_svHB.Text = "Số sv được cấp học bổng:"
        Me.lblSo_svHB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSotien_con
        '
        Me.lblSotien_con.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien_con.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien_con.Location = New System.Drawing.Point(15, 87)
        Me.lblSotien_con.Name = "lblSotien_con"
        Me.lblSotien_con.Size = New System.Drawing.Size(189, 24)
        Me.lblSotien_con.TabIndex = 124
        Me.lblSotien_con.Text = "Số tiền còn lại:"
        Me.lblSotien_con.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSotien_chi
        '
        Me.lblSotien_chi.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien_chi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien_chi.Location = New System.Drawing.Point(15, 54)
        Me.lblSotien_chi.Name = "lblSotien_chi"
        Me.lblSotien_chi.Size = New System.Drawing.Size(189, 22)
        Me.lblSotien_chi.TabIndex = 122
        Me.lblSotien_chi.Text = "Số tiền HB học tập:"
        Me.lblSotien_chi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTong_sotien
        '
        Me.lblTong_sotien.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_sotien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTong_sotien.Location = New System.Drawing.Point(15, 22)
        Me.lblTong_sotien.Name = "lblTong_sotien"
        Me.lblTong_sotien.Size = New System.Drawing.Size(189, 24)
        Me.lblTong_sotien.TabIndex = 120
        Me.lblTong_sotien.Text = "Tổng số tiền phân bổ:"
        Me.lblTong_sotien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTien_trocap
        '
        Me.lblTien_trocap.BackColor = System.Drawing.Color.Transparent
        Me.lblTien_trocap.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTien_trocap.Location = New System.Drawing.Point(15, 50)
        Me.lblTien_trocap.Name = "lblTien_trocap"
        Me.lblTien_trocap.Size = New System.Drawing.Size(189, 24)
        Me.lblTien_trocap.TabIndex = 128
        Me.lblTien_trocap.Text = "Số tiền HB chính sách:"
        Me.lblTien_trocap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTien_trocap.Visible = False
        '
        'txtSotien_chi
        '
        Me.txtSotien_chi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien_chi.Location = New System.Drawing.Point(210, 54)
        Me.txtSotien_chi.MaxLength = 12
        Me.txtSotien_chi.Name = "txtSotien_chi"
        Me.txtSotien_chi.ReadOnly = True
        Me.txtSotien_chi.Size = New System.Drawing.Size(129, 23)
        Me.txtSotien_chi.TabIndex = 121
        Me.txtSotien_chi.TabStop = False
        Me.txtSotien_chi.Text = "0"
        Me.txtSotien_chi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTien_trocap
        '
        Me.txtTien_trocap.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTien_trocap.Location = New System.Drawing.Point(210, 54)
        Me.txtTien_trocap.MaxLength = 12
        Me.txtTien_trocap.Name = "txtTien_trocap"
        Me.txtTien_trocap.ReadOnly = True
        Me.txtTien_trocap.Size = New System.Drawing.Size(129, 23)
        Me.txtTien_trocap.TabIndex = 127
        Me.txtTien_trocap.TabStop = False
        Me.txtTien_trocap.Text = "0"
        Me.txtTien_trocap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTien_trocap.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdProcess, Me.cmdPrint_ds, Me.cmdPrint_HBHT, Me.cmdExcel, Me.cmdDelete, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdProcess
        '
        Me.cmdProcess.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdProcess.Image = Global.ESSFinance.My.Resources.Resources.Import
        Me.cmdProcess.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.Size = New System.Drawing.Size(164, 22)
        Me.cmdProcess.Text = "Xét học bổng tự động"
        '
        'cmdPrint_ds
        '
        Me.cmdPrint_ds.Image = CType(resources.GetObject("cmdPrint_ds.Image"), System.Drawing.Image)
        Me.cmdPrint_ds.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint_ds.Name = "cmdPrint_ds"
        Me.cmdPrint_ds.Size = New System.Drawing.Size(121, 22)
        Me.cmdPrint_ds.Text = "In ds học bổng"
        '
        'cmdPrint_HBHT
        '
        Me.cmdPrint_HBHT.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdPrint_HBHT.Image = CType(resources.GetObject("cmdPrint_HBHT.Image"), System.Drawing.Image)
        Me.cmdPrint_HBHT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint_HBHT.Name = "cmdPrint_HBHT"
        Me.cmdPrint_HBHT.Size = New System.Drawing.Size(158, 22)
        Me.cmdPrint_HBHT.Text = "In bảng HB tổng hợp"
        Me.cmdPrint_HBHT.Visible = False
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSFinance.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(92, 22)
        Me.cmdExcel.Text = "Xuất excel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSFinance.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(112, 22)
        Me.cmdDelete.Text = "Xóa sinh viên"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdView
        '
        Me.grdView.AllowUserToAddRows = False
        Me.grdView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop, Me.Ma_dt, Me.Xep_loai_HT, Me.Xep_loai_RL, Me.Xep_loai_HB, Me.So_mon_no, Me.Xu_ly_ky_luat, Me.TBCHT10, Me.TBCHT, Me.Tong_diem_rl, Me.So_tien, Me.HB_CS, Me.Tong_tien})
        Me.grdView.Location = New System.Drawing.Point(0, 238)
        Me.grdView.Name = "grdView"
        Me.grdView.Size = New System.Drawing.Size(792, 328)
        Me.grdView.TabIndex = 31
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.FalseValue = "FALSE"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.TrueValue = "TRUE"
        Me.Chon.Visible = False
        Me.Chon.Width = 45
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        Me.Ma_sv.HeaderText = "Mã sv"
        Me.Ma_sv.MinimumWidth = 100
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Họ tên"
        Me.Ho_ten.MinimumWidth = 140
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 140
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.MinimumWidth = 95
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        Me.Ngay_sinh.Width = 95
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 120
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 120
        '
        'Ma_dt
        '
        Me.Ma_dt.DataPropertyName = "Ma_dt"
        Me.Ma_dt.HeaderText = "Mã ĐT"
        Me.Ma_dt.MinimumWidth = 100
        Me.Ma_dt.Name = "Ma_dt"
        Me.Ma_dt.ReadOnly = True
        '
        'Xep_loai_HT
        '
        Me.Xep_loai_HT.DataPropertyName = "Xep_loai_HT"
        Me.Xep_loai_HT.HeaderText = "Xếp loại HT"
        Me.Xep_loai_HT.MinimumWidth = 105
        Me.Xep_loai_HT.Name = "Xep_loai_HT"
        Me.Xep_loai_HT.ReadOnly = True
        Me.Xep_loai_HT.Width = 105
        '
        'Xep_loai_RL
        '
        Me.Xep_loai_RL.DataPropertyName = "Xep_loai_RL"
        Me.Xep_loai_RL.HeaderText = "Xếp loại RL"
        Me.Xep_loai_RL.MinimumWidth = 105
        Me.Xep_loai_RL.Name = "Xep_loai_RL"
        Me.Xep_loai_RL.ReadOnly = True
        Me.Xep_loai_RL.Width = 105
        '
        'Xep_loai_HB
        '
        Me.Xep_loai_HB.DataPropertyName = "Xep_loai_HB"
        Me.Xep_loai_HB.HeaderText = "Xếp loại HB"
        Me.Xep_loai_HB.MinimumWidth = 105
        Me.Xep_loai_HB.Name = "Xep_loai_HB"
        Me.Xep_loai_HB.ReadOnly = True
        Me.Xep_loai_HB.Width = 105
        '
        'So_mon_no
        '
        Me.So_mon_no.DataPropertyName = "So_mon_no"
        Me.So_mon_no.HeaderText = "Số Học phần nợ"
        Me.So_mon_no.MinimumWidth = 100
        Me.So_mon_no.Name = "So_mon_no"
        Me.So_mon_no.ReadOnly = True
        '
        'Xu_ly_ky_luat
        '
        Me.Xu_ly_ky_luat.DataPropertyName = "Xu_ly_ky_luat"
        Me.Xu_ly_ky_luat.HeaderText = "Kỷ luật"
        Me.Xu_ly_ky_luat.MinimumWidth = 100
        Me.Xu_ly_ky_luat.Name = "Xu_ly_ky_luat"
        Me.Xu_ly_ky_luat.ReadOnly = True
        '
        'TBCHT10
        '
        Me.TBCHT10.DataPropertyName = "TBCHT10"
        Me.TBCHT10.HeaderText = "TBCHT(10)"
        Me.TBCHT10.Name = "TBCHT10"
        Me.TBCHT10.ReadOnly = True
        '
        'TBCHT
        '
        Me.TBCHT.DataPropertyName = "TBCHT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TBCHT.DefaultCellStyle = DataGridViewCellStyle2
        Me.TBCHT.HeaderText = "TBCHT(4)"
        Me.TBCHT.MinimumWidth = 85
        Me.TBCHT.Name = "TBCHT"
        Me.TBCHT.ReadOnly = True
        Me.TBCHT.Visible = False
        Me.TBCHT.Width = 85
        '
        'Tong_diem_rl
        '
        Me.Tong_diem_rl.DataPropertyName = "Tong_diem_rl"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tong_diem_rl.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tong_diem_rl.HeaderText = "Tổng điểm RL"
        Me.Tong_diem_rl.MinimumWidth = 120
        Me.Tong_diem_rl.Name = "Tong_diem_rl"
        Me.Tong_diem_rl.ReadOnly = True
        Me.Tong_diem_rl.Width = 120
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "HB_HT"
        DataGridViewCellStyle4.Format = "###,###"
        Me.So_tien.DefaultCellStyle = DataGridViewCellStyle4
        Me.So_tien.HeaderText = "Số tiền HB"
        Me.So_tien.MinimumWidth = 100
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        '
        'HB_CS
        '
        Me.HB_CS.DataPropertyName = "HB_CS"
        DataGridViewCellStyle5.Format = "###,###"
        Me.HB_CS.DefaultCellStyle = DataGridViewCellStyle5
        Me.HB_CS.HeaderText = "Học bổng CS"
        Me.HB_CS.MinimumWidth = 100
        Me.HB_CS.Name = "HB_CS"
        Me.HB_CS.ReadOnly = True
        '
        'Tong_tien
        '
        Me.Tong_tien.DataPropertyName = "Tong_tien"
        DataGridViewCellStyle6.Format = "###,###"
        Me.Tong_tien.DefaultCellStyle = DataGridViewCellStyle6
        Me.Tong_tien.HeaderText = "Tổng tiền"
        Me.Tong_tien.Name = "Tong_tien"
        '
        'optDa_xet
        '
        Me.optDa_xet.BackColor = System.Drawing.Color.Transparent
        Me.optDa_xet.Location = New System.Drawing.Point(351, 187)
        Me.optDa_xet.Name = "optDa_xet"
        Me.optDa_xet.Size = New System.Drawing.Size(315, 24)
        Me.optDa_xet.TabIndex = 33
        Me.optDa_xet.Text = "Danh sách sinh viên đã được xét học bổng"
        Me.optDa_xet.UseVisualStyleBackColor = False
        '
        'optChua_xet
        '
        Me.optChua_xet.BackColor = System.Drawing.Color.Transparent
        Me.optChua_xet.Checked = True
        Me.optChua_xet.Location = New System.Drawing.Point(5, 187)
        Me.optChua_xet.Name = "optChua_xet"
        Me.optChua_xet.Size = New System.Drawing.Size(383, 24)
        Me.optChua_xet.TabIndex = 32
        Me.optChua_xet.TabStop = True
        Me.optChua_xet.Text = "Xem danh sách sinh viên chưa được xét học bổng"
        Me.optChua_xet.UseVisualStyleBackColor = False
        '
        'lblTong_so
        '
        Me.lblTong_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_so.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_so.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTong_so.Location = New System.Drawing.Point(653, 186)
        Me.lblTong_so.Name = "lblTong_so"
        Me.lblTong_so.Size = New System.Drawing.Size(95, 24)
        Me.lblTong_so.TabIndex = 113
        Me.lblTong_so.Text = "Số sinh viên:"
        Me.lblTong_so.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum_sv
        '
        Me.lblNum_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNum_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblNum_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum_sv.ForeColor = System.Drawing.Color.Red
        Me.lblNum_sv.Location = New System.Drawing.Point(752, 186)
        Me.lblNum_sv.Name = "lblNum_sv"
        Me.lblNum_sv.Size = New System.Drawing.Size(40, 24)
        Me.lblNum_sv.TabIndex = 114
        Me.lblNum_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(2, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(790, 24)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Chú ý : Sinh viên phải được gán đối tượng trợ cấp, có điểm rèn luyện, có kết quả " & _
            "học tập thì được xét học bổng"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmESS_XetHocBong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTong_so)
        Me.Controls.Add(Me.lblNum_sv)
        Me.Controls.Add(Me.optDa_xet)
        Me.Controls.Add(Me.optChua_xet)
        Me.Controls.Add(Me.grdView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_XetHocBong"
        Me.Text = "Xét học bổng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents lblHe As System.Windows.Forms.Label
    Friend WithEvents cmbID_quy As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuy_hb As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoc_ky As System.Windows.Forms.Label
    Friend WithEvents lblNam_hoc As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTien_trocap As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_sv As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien_con As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien_chi As System.Windows.Forms.TextBox
    Friend WithEvents txtTong_sotien As System.Windows.Forms.TextBox
    Friend WithEvents lblTien_trocap As System.Windows.Forms.Label
    Friend WithEvents lblSo_svHB As System.Windows.Forms.Label
    Friend WithEvents lblSotien_con As System.Windows.Forms.Label
    Friend WithEvents lblSotien_chi As System.Windows.Forms.Label
    Friend WithEvents lblTong_sotien As System.Windows.Forms.Label
    Friend WithEvents cmbID_phan_bo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdProcess As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint_ds As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdPrint_HBHT As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdView As System.Windows.Forms.DataGridView
    Friend WithEvents optDa_xet As System.Windows.Forms.RadioButton
    Friend WithEvents optChua_xet As System.Windows.Forms.RadioButton
    Friend WithEvents lblTong_so As System.Windows.Forms.Label
    Friend WithEvents lblNum_sv As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Xep_loai_HT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Xep_loai_RL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Xep_loai_HB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_mon_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Xu_ly_ky_luat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBCHT10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBCHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tong_diem_rl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HB_CS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tong_tien As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
