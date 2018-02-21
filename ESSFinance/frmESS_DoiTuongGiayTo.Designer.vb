<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DoiTuongGiayTo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdViewDoiTuongHB = New System.Windows.Forms.DataGridView
        Me.Ten_dt_hb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_dt_hb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewDoiTuongGT = New System.Windows.Forms.DataGridView
        Me.Ten_he = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbID_loai_giay_to = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optDoiTuong_CS = New System.Windows.Forms.RadioButton
        Me.optDoiTuong_hb = New System.Windows.Forms.RadioButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        CType(Me.grdViewDoiTuongHB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDoiTuongGT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdViewDoiTuongHB
        '
        Me.grdViewDoiTuongHB.AllowUserToAddRows = False
        Me.grdViewDoiTuongHB.AllowUserToDeleteRows = False
        Me.grdViewDoiTuongHB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDoiTuongHB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDoiTuongHB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDoiTuongHB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewDoiTuongHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDoiTuongHB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_dt_hb, Me.Ma_dt_hb})
        Me.grdViewDoiTuongHB.Location = New System.Drawing.Point(6, 47)
        Me.grdViewDoiTuongHB.Name = "grdViewDoiTuongHB"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDoiTuongHB.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdViewDoiTuongHB.RowHeadersVisible = False
        Me.grdViewDoiTuongHB.Size = New System.Drawing.Size(771, 352)
        Me.grdViewDoiTuongHB.TabIndex = 90
        '
        'Ten_dt_hb
        '
        Me.Ten_dt_hb.DataPropertyName = "Ten_dt_hb"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_dt_hb.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ten_dt_hb.HeaderText = "Tên đối tượng HB"
        Me.Ten_dt_hb.MinimumWidth = 500
        Me.Ten_dt_hb.Name = "Ten_dt_hb"
        Me.Ten_dt_hb.ReadOnly = True
        Me.Ten_dt_hb.Width = 500
        '
        'Ma_dt_hb
        '
        Me.Ma_dt_hb.DataPropertyName = "Ma_dt_hb"
        Me.Ma_dt_hb.HeaderText = "Mã ĐT"
        Me.Ma_dt_hb.MinimumWidth = 210
        Me.Ma_dt_hb.Name = "Ma_dt_hb"
        Me.Ma_dt_hb.ReadOnly = True
        Me.Ma_dt_hb.Width = 210
        '
        'grdViewDoiTuongGT
        '
        Me.grdViewDoiTuongGT.AllowUserToAddRows = False
        Me.grdViewDoiTuongGT.AllowUserToDeleteRows = False
        Me.grdViewDoiTuongGT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDoiTuongGT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDoiTuongGT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDoiTuongGT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdViewDoiTuongGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDoiTuongGT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_he})
        Me.grdViewDoiTuongGT.Location = New System.Drawing.Point(0, 49)
        Me.grdViewDoiTuongGT.Name = "grdViewDoiTuongGT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDoiTuongGT.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdViewDoiTuongGT.RowHeadersVisible = False
        Me.grdViewDoiTuongGT.Size = New System.Drawing.Size(769, 76)
        Me.grdViewDoiTuongGT.TabIndex = 90
        '
        'Ten_he
        '
        Me.Ten_he.DataPropertyName = "Ten_giay_to"
        Me.Ten_he.HeaderText = "Tên giấy tờ cần nộp"
        Me.Ten_he.MinimumWidth = 500
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.ReadOnly = True
        Me.Ten_he.Width = 500
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbID_loai_giay_to)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.grdViewDoiTuongGT)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 437)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(769, 125)
        Me.GroupBox2.TabIndex = 134
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loại giấy tờ cần nộp kèm theo"
        '
        'cmbID_loai_giay_to
        '
        Me.cmbID_loai_giay_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_loai_giay_to.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_loai_giay_to.Location = New System.Drawing.Point(143, 19)
        Me.cmbID_loai_giay_to.MaxDropDownItems = 5
        Me.cmbID_loai_giay_to.Name = "cmbID_loai_giay_to"
        Me.cmbID_loai_giay_to.Size = New System.Drawing.Size(418, 24)
        Me.cmbID_loai_giay_to.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Loại giấy tờ cần nộp"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.optDoiTuong_CS)
        Me.GroupBox1.Controls.Add(Me.grdViewDoiTuongHB)
        Me.GroupBox1.Controls.Add(Me.optDoiTuong_hb)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 405)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sác đối tượng xác định giấy tờ cần nộp kèm theo"
        '
        'optDoiTuong_CS
        '
        Me.optDoiTuong_CS.BackColor = System.Drawing.Color.Transparent
        Me.optDoiTuong_CS.Location = New System.Drawing.Point(242, 17)
        Me.optDoiTuong_CS.Name = "optDoiTuong_CS"
        Me.optDoiTuong_CS.Size = New System.Drawing.Size(195, 23)
        Me.optDoiTuong_CS.TabIndex = 147
        Me.optDoiTuong_CS.Text = "Đối tượng chính sách"
        Me.optDoiTuong_CS.UseVisualStyleBackColor = False
        '
        'optDoiTuong_hb
        '
        Me.optDoiTuong_hb.BackColor = System.Drawing.Color.Transparent
        Me.optDoiTuong_hb.Checked = True
        Me.optDoiTuong_hb.Location = New System.Drawing.Point(9, 18)
        Me.optDoiTuong_hb.Name = "optDoiTuong_hb"
        Me.optDoiTuong_hb.Size = New System.Drawing.Size(176, 23)
        Me.optDoiTuong_hb.TabIndex = 146
        Me.optDoiTuong_hb.TabStop = True
        Me.optDoiTuong_hb.Text = "Đối tượng học bổng"
        Me.optDoiTuong_hb.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdDelete, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 136
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdAdd.Image = Global.ESSFinance.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdDelete.Image = Global.ESSFinance.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "Xóa"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'frmESS_DoiTuongGiayTo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmESS_DoiTuongGiayTo"
        Me.Text = "Phân loại đối tượng giấy tờ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDoiTuongHB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDoiTuongGT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdViewDoiTuongHB As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewDoiTuongGT As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ten_dt_hb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_dt_hb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_he As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbID_loai_giay_to As System.Windows.Forms.ComboBox
    Friend WithEvents optDoiTuong_CS As System.Windows.Forms.RadioButton
    Friend WithEvents optDoiTuong_hb As System.Windows.Forms.RadioButton
End Class
