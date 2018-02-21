<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThongTinQuyetDinhTotNghiep
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.Print = New System.Windows.Forms.ToolStripDropDownButton
        Me.cmdPrint_One = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPrint_All = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtSo_QD = New System.Windows.Forms.TextBox
        Me.dtmNgay_hop = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Print, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(304, 25)
        Me.ToolStrip.TabIndex = 106
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'Print
        '
        Me.Print.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint_One, Me.cmdPrint_All})
        Me.Print.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(103, 22)
        Me.Print.Text = "In báo cáo"
        '
        'cmdPrint_One
        '
        Me.cmdPrint_One.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_One.Name = "cmdPrint_One"
        Me.cmdPrint_One.Size = New System.Drawing.Size(327, 22)
        Me.cmdPrint_One.Text = "In cho sinh viên đã chọn"
        '
        'cmdPrint_All
        '
        Me.cmdPrint_All.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_All.Name = "cmdPrint_All"
        Me.cmdPrint_All.Size = New System.Drawing.Size(327, 22)
        Me.cmdPrint_All.Text = "In cho cả danh sách sinh viên đã xét TN"
        Me.cmdPrint_All.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'txtSo_QD
        '
        Me.txtSo_QD.Location = New System.Drawing.Point(141, 46)
        Me.txtSo_QD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSo_QD.MaxLength = 100
        Me.txtSo_QD.Name = "txtSo_QD"
        Me.txtSo_QD.Size = New System.Drawing.Size(116, 22)
        Me.txtSo_QD.TabIndex = 107
        '
        'dtmNgay_hop
        '
        Me.dtmNgay_hop.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmNgay_hop.Location = New System.Drawing.Point(141, 76)
        Me.dtmNgay_hop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtmNgay_hop.Name = "dtmNgay_hop"
        Me.dtmNgay_hop.Size = New System.Drawing.Size(116, 22)
        Me.dtmNgay_hop.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(43, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Số quyết định:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Biên bản họp ngày:"
        '
        'frmESS_NoiDungQDTotNghiep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 135)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtmNgay_hop)
        Me.Controls.Add(Me.txtSo_QD)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_NoiDungQDTotNghiep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmESS_NoiDungQDTotNghiep"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Print As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdPrint_One As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint_All As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSo_QD As System.Windows.Forms.TextBox
    Friend WithEvents dtmNgay_hop As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
