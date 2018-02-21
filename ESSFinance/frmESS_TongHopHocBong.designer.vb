<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopHocBong
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdTong_hop_HB = New System.Windows.Forms.ToolStripButton
        Me.cmdPrintTH = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrPro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint, Me.cmdTong_hop_HB, Me.cmdPrintTH, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(624, 25)
        Me.ToolStrip.TabIndex = 130
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(184, 22)
        Me.cmdPrint.Text = "Bảng chi tiết HB theo lớp"
        '
        'cmdTong_hop_HB
        '
        Me.cmdTong_hop_HB.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdTong_hop_HB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTong_hop_HB.Name = "cmdTong_hop_HB"
        Me.cmdTong_hop_HB.Size = New System.Drawing.Size(188, 22)
        Me.cmdTong_hop_HB.Text = "Tổng hợp học bổng khóa"
        '
        'cmdPrintTH
        '
        Me.cmdPrintTH.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrintTH.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintTH.Name = "cmdPrintTH"
        Me.cmdPrintTH.Size = New System.Drawing.Size(166, 22)
        Me.cmdPrintTH.Text = "Bảng tổng hợp chi HB"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(132, 43)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(49, 24)
        Me.cmbHoc_ky.TabIndex = 145
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(501, 43)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(111, 24)
        Me.cmbNam_hoc.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(62, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Học kỳ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(428, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(132, 160)
        Me.cmbKhoa_hoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(480, 24)
        Me.cmbKhoa_hoc.TabIndex = 154
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 30)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Khóa học :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_lop
        '
        Me.cmbID_lop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_lop.Location = New System.Drawing.Point(132, 201)
        Me.cmbID_lop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(480, 24)
        Me.cmbID_lop.TabIndex = 152
        '
        'cmbID_he
        '
        Me.cmbID_he.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(132, 85)
        Me.cmbID_he.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(480, 24)
        Me.cmbID_he.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 30)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Lớp học"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 30)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Hệ đào tạo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrPro
        '
        Me.ErrPro.ContainerControl = Me
        Me.ErrPro.DataMember = ""
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_khoa.Location = New System.Drawing.Point(132, 122)
        Me.cmbID_khoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(480, 24)
        Me.cmbID_khoa.TabIndex = 156
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 30)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Khoa :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_TongHopHocBong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(624, 242)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_lop)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmESS_TongHopHocBong"
        Me.Text = "Lập danh sách thu khác"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintTH As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrPro As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdTong_hop_HB As System.Windows.Forms.ToolStripButton
End Class
