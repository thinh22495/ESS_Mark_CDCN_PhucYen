<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_QuyHocBong
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
        Me.cmbDen_khoa = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTu_khoa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.lblHe = New System.Windows.Forms.Label
        Me.lblLoai_hocbong = New System.Windows.Forms.Label
        Me.txtSotien_khac = New System.Windows.Forms.TextBox
        Me.lblSotien_khac = New System.Windows.Forms.Label
        Me.cmbID_quy = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblHoc_ky = New System.Windows.Forms.Label
        Me.lblNam_hoc = New System.Windows.Forms.Label
        Me.txtGhi_chu = New System.Windows.Forms.TextBox
        Me.txtSotien_ngansach = New System.Windows.Forms.TextBox
        Me.lblSotien_ngansach = New System.Windows.Forms.Label
        Me.lblGhi_chu = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDen_khoa
        '
        Me.cmbDen_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDen_khoa.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDen_khoa.Location = New System.Drawing.Point(402, 127)
        Me.cmbDen_khoa.MaxDropDownItems = 5
        Me.cmbDen_khoa.Name = "cmbDen_khoa"
        Me.cmbDen_khoa.Size = New System.Drawing.Size(104, 24)
        Me.cmbDen_khoa.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(308, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Đến khoá:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTu_khoa
        '
        Me.cmbTu_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTu_khoa.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTu_khoa.Location = New System.Drawing.Point(136, 127)
        Me.cmbTu_khoa.MaxDropDownItems = 5
        Me.cmbTu_khoa.Name = "cmbTu_khoa"
        Me.cmbTu_khoa.Size = New System.Drawing.Size(77, 24)
        Me.cmbTu_khoa.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 22)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Từ khoá:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(136, 97)
        Me.cmbID_he.MaxDropDownItems = 5
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(371, 24)
        Me.cmbID_he.TabIndex = 81
        '
        'lblHe
        '
        Me.lblHe.BackColor = System.Drawing.Color.Transparent
        Me.lblHe.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHe.Location = New System.Drawing.Point(42, 99)
        Me.lblHe.Name = "lblHe"
        Me.lblHe.Size = New System.Drawing.Size(88, 22)
        Me.lblHe.TabIndex = 93
        Me.lblHe.Text = "Hệ:"
        Me.lblHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLoai_hocbong
        '
        Me.lblLoai_hocbong.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_hocbong.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_hocbong.Location = New System.Drawing.Point(4, 67)
        Me.lblLoai_hocbong.Name = "lblLoai_hocbong"
        Me.lblLoai_hocbong.Size = New System.Drawing.Size(126, 22)
        Me.lblLoai_hocbong.TabIndex = 92
        Me.lblLoai_hocbong.Text = "Loại học bổng:"
        Me.lblLoai_hocbong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSotien_khac
        '
        Me.txtSotien_khac.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien_khac.Location = New System.Drawing.Point(402, 157)
        Me.txtSotien_khac.MaxLength = 11
        Me.txtSotien_khac.Name = "txtSotien_khac"
        Me.txtSotien_khac.Size = New System.Drawing.Size(104, 23)
        Me.txtSotien_khac.TabIndex = 85
        '
        'lblSotien_khac
        '
        Me.lblSotien_khac.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien_khac.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien_khac.Location = New System.Drawing.Point(299, 157)
        Me.lblSotien_khac.Name = "lblSotien_khac"
        Me.lblSotien_khac.Size = New System.Drawing.Size(97, 23)
        Me.lblSotien_khac.TabIndex = 91
        Me.lblSotien_khac.Text = "Số tiền khác:"
        Me.lblSotien_khac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_quy
        '
        Me.cmbID_quy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_quy.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_quy.Location = New System.Drawing.Point(136, 67)
        Me.cmbID_quy.MaxDropDownItems = 5
        Me.cmbID_quy.Name = "cmbID_quy"
        Me.cmbID_quy.Size = New System.Drawing.Size(371, 24)
        Me.cmbID_quy.TabIndex = 80
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNam_hoc.Location = New System.Drawing.Point(403, 35)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(104, 24)
        Me.cmbNam_hoc.TabIndex = 79
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoc_ky.Location = New System.Drawing.Point(136, 37)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(53, 24)
        Me.cmbHoc_ky.TabIndex = 78
        '
        'lblHoc_ky
        '
        Me.lblHoc_ky.BackColor = System.Drawing.Color.Transparent
        Me.lblHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoc_ky.Location = New System.Drawing.Point(36, 39)
        Me.lblHoc_ky.Name = "lblHoc_ky"
        Me.lblHoc_ky.Size = New System.Drawing.Size(94, 22)
        Me.lblHoc_ky.TabIndex = 89
        Me.lblHoc_ky.Text = "Học kỳ:"
        Me.lblHoc_ky.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNam_hoc
        '
        Me.lblNam_hoc.BackColor = System.Drawing.Color.Transparent
        Me.lblNam_hoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam_hoc.Location = New System.Drawing.Point(317, 35)
        Me.lblNam_hoc.Name = "lblNam_hoc"
        Me.lblNam_hoc.Size = New System.Drawing.Size(80, 22)
        Me.lblNam_hoc.TabIndex = 90
        Me.lblNam_hoc.Text = "Năm học:"
        Me.lblNam_hoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGhi_chu
        '
        Me.txtGhi_chu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhi_chu.Location = New System.Drawing.Point(136, 186)
        Me.txtGhi_chu.MaxLength = 200
        Me.txtGhi_chu.Name = "txtGhi_chu"
        Me.txtGhi_chu.Size = New System.Drawing.Size(371, 23)
        Me.txtGhi_chu.TabIndex = 86
        '
        'txtSotien_ngansach
        '
        Me.txtSotien_ngansach.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSotien_ngansach.Location = New System.Drawing.Point(136, 157)
        Me.txtSotien_ngansach.MaxLength = 11
        Me.txtSotien_ngansach.Name = "txtSotien_ngansach"
        Me.txtSotien_ngansach.Size = New System.Drawing.Size(117, 23)
        Me.txtSotien_ngansach.TabIndex = 84
        '
        'lblSotien_ngansach
        '
        Me.lblSotien_ngansach.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien_ngansach.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien_ngansach.Location = New System.Drawing.Point(1, 157)
        Me.lblSotien_ngansach.Name = "lblSotien_ngansach"
        Me.lblSotien_ngansach.Size = New System.Drawing.Size(129, 23)
        Me.lblSotien_ngansach.TabIndex = 87
        Me.lblSotien_ngansach.Text = "Số tiền ngân sách:"
        Me.lblSotien_ngansach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGhi_chu
        '
        Me.lblGhi_chu.BackColor = System.Drawing.Color.Transparent
        Me.lblGhi_chu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGhi_chu.Location = New System.Drawing.Point(42, 186)
        Me.lblGhi_chu.Name = "lblGhi_chu"
        Me.lblGhi_chu.Size = New System.Drawing.Size(88, 22)
        Me.lblGhi_chu.TabIndex = 88
        Me.lblGhi_chu.Text = "Ghi chú:"
        Me.lblGhi_chu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(544, 25)
        Me.ToolStrip1.TabIndex = 96
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(195, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 24)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "(*)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(513, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 24)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "(*)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(513, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 24)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "(*)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(513, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 24)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "(*)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(512, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 24)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "(*)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(219, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 24)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "(*)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(259, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 24)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "(*)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_QuyHocBong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 227)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmbDen_khoa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTu_khoa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.lblHe)
        Me.Controls.Add(Me.lblLoai_hocbong)
        Me.Controls.Add(Me.txtSotien_khac)
        Me.Controls.Add(Me.lblSotien_khac)
        Me.Controls.Add(Me.cmbID_quy)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.lblHoc_ky)
        Me.Controls.Add(Me.lblNam_hoc)
        Me.Controls.Add(Me.txtGhi_chu)
        Me.Controls.Add(Me.txtSotien_ngansach)
        Me.Controls.Add(Me.lblSotien_ngansach)
        Me.Controls.Add(Me.lblGhi_chu)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaximizeBox = False
        Me.Name = "frmESS_QuyHocBong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quỹ học bổng"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDen_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTu_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents lblHe As System.Windows.Forms.Label
    Friend WithEvents lblLoai_hocbong As System.Windows.Forms.Label
    Friend WithEvents txtSotien_khac As System.Windows.Forms.TextBox
    Friend WithEvents lblSotien_khac As System.Windows.Forms.Label
    Friend WithEvents cmbID_quy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoc_ky As System.Windows.Forms.Label
    Friend WithEvents lblNam_hoc As System.Windows.Forms.Label
    Friend WithEvents txtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents txtSotien_ngansach As System.Windows.Forms.TextBox
    Friend WithEvents lblSotien_ngansach As System.Windows.Forms.Label
    Friend WithEvents lblGhi_chu As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
