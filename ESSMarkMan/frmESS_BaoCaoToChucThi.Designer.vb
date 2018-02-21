<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BaoCaoToChucThi
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton
        Me.menuPrintPhongThi = New System.Windows.Forms.ToolStripMenuItem
        Me.menuPrintDotThi = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDS_Thi1 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdDS_Thi2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.cmbID_nganh = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(494, 25)
        Me.ToolStrip.TabIndex = 50
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPrintPhongThi, Me.menuPrintDotThi, Me.cmdDS_Thi1, Me.cmdDS_Thi2})
        Me.ToolStripButton2.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripButton2.Text = "In danh sách thi"
        '
        'menuPrintPhongThi
        '
        Me.menuPrintPhongThi.Name = "menuPrintPhongThi"
        Me.menuPrintPhongThi.Size = New System.Drawing.Size(280, 22)
        Me.menuPrintPhongThi.Text = "Danh sách sinh viên theo phòng"
        '
        'menuPrintDotThi
        '
        Me.menuPrintDotThi.Name = "menuPrintDotThi"
        Me.menuPrintDotThi.Size = New System.Drawing.Size(280, 22)
        Me.menuPrintDotThi.Text = "Thống kê sinh viên theo phòng"
        '
        'cmdDS_Thi1
        '
        Me.cmdDS_Thi1.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdDS_Thi1.Name = "cmdDS_Thi1"
        Me.cmdDS_Thi1.Size = New System.Drawing.Size(280, 22)
        Me.cmdDS_Thi1.Text = "Danh sách thi 1"
        Me.cmdDS_Thi1.Visible = False
        '
        'cmdDS_Thi2
        '
        Me.cmdDS_Thi2.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdDS_Thi2.Name = "cmdDS_Thi2"
        Me.cmdDS_Thi2.Size = New System.Drawing.Size(280, 22)
        Me.cmdDS_Thi2.Text = "Danh sách thi 2"
        Me.cmdDS_Thi2.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'cmbID_nganh
        '
        Me.cmbID_nganh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nganh.FormattingEnabled = True
        Me.cmbID_nganh.Location = New System.Drawing.Point(97, 125)
        Me.cmbID_nganh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbID_nganh.Name = "cmbID_nganh"
        Me.cmbID_nganh.Size = New System.Drawing.Size(325, 24)
        Me.cmbID_nganh.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(39, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Ngành:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.FormattingEnabled = True
        Me.cmbID_khoa.Location = New System.Drawing.Point(97, 94)
        Me.cmbID_khoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(325, 24)
        Me.cmbID_khoa.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(43, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 22)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Khoa:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.FormattingEnabled = True
        Me.cmbHoc_ky.Location = New System.Drawing.Point(97, 41)
        Me.cmbHoc_ky.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(51, 24)
        Me.cmbHoc_ky.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(31, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Học kỳ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.FormattingEnabled = True
        Me.cmbNam_hoc.Location = New System.Drawing.Point(315, 40)
        Me.cmbNam_hoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(107, 24)
        Me.cmbNam_hoc.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(247, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Năm học:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmESS_BaoCaoToChucThi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 205)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_nganh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_BaoCaoToChucThi"
        Me.Text = "frmESS_BaoCaoToChucThi"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuPrintPhongThi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPrintDotThi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDS_Thi1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDS_Thi2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents cmbID_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
