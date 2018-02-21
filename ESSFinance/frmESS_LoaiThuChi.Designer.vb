<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_LoaiThuChi
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtSo_tien = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdViewLoaiThuChi = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Hoc_phi = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.txtTen_thu_chi = New System.Windows.Forms.TextBox
        Me.chkHoc_phi = New System.Windows.Forms.CheckBox
        Me.chkThuTheo_NienKhoa = New System.Windows.Forms.CheckBox
        Me.optThu = New System.Windows.Forms.RadioButton
        Me.optChi = New System.Windows.Forms.RadioButton
        Me.chkThu_Batbuoc = New System.Windows.Forms.CheckBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewLoaiThuChi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdSave, Me.cmdCancel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(637, 25)
        Me.ToolStrip.TabIndex = 130
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ESSFinance.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESSFinance.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(54, 22)
        Me.cmdEdit.Text = "Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSFinance.My.Resources.Resources.Remove
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(70, 22)
        Me.cmdDelete.Text = "Xóa sv"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.ESSFinance.My.Resources.Resources.Cancel
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(52, 22)
        Me.cmdCancel.Text = "Hủy"
        Me.cmdCancel.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'txtSo_tien
        '
        Me.txtSo_tien.BackColor = System.Drawing.Color.White
        Me.txtSo_tien.Location = New System.Drawing.Point(459, 37)
        Me.txtSo_tien.MaxLength = 9
        Me.txtSo_tien.Name = "txtSo_tien"
        Me.txtSo_tien.Size = New System.Drawing.Size(111, 23)
        Me.txtSo_tien.TabIndex = 150
        Me.txtSo_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(385, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Số tiền:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Khoản nộp:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grdViewLoaiThuChi
        '
        Me.grdViewLoaiThuChi.AllowUserToAddRows = False
        Me.grdViewLoaiThuChi.AllowUserToDeleteRows = False
        Me.grdViewLoaiThuChi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewLoaiThuChi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewLoaiThuChi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewLoaiThuChi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewLoaiThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewLoaiThuChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.So_tien, Me.Hoc_phi, Me.Phai_nop})
        Me.grdViewLoaiThuChi.Location = New System.Drawing.Point(0, 133)
        Me.grdViewLoaiThuChi.Name = "grdViewLoaiThuChi"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewLoaiThuChi.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdViewLoaiThuChi.RowHeadersVisible = False
        Me.grdViewLoaiThuChi.Size = New System.Drawing.Size(637, 233)
        Me.grdViewLoaiThuChi.TabIndex = 154
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ten_thu_chi"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tên thu chi"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "So_tien"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "###,###"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Số tiền"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Thu_chi"
        Me.DataGridViewTextBoxColumn6.FalseValue = "false"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Khoản thu"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.TrueValue = "True"
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "Theo_nien_khoa"
        Me.So_tien.FalseValue = "false"
        Me.So_tien.HeaderText = "Niên khóa"
        Me.So_tien.MinimumWidth = 100
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        Me.So_tien.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.So_tien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.So_tien.TrueValue = "True"
        '
        'Hoc_phi
        '
        Me.Hoc_phi.DataPropertyName = "Hoc_phi"
        Me.Hoc_phi.FalseValue = "false"
        Me.Hoc_phi.HeaderText = "Học phí"
        Me.Hoc_phi.MinimumWidth = 90
        Me.Hoc_phi.Name = "Hoc_phi"
        Me.Hoc_phi.ReadOnly = True
        Me.Hoc_phi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hoc_phi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Hoc_phi.TrueValue = "True"
        Me.Hoc_phi.Width = 90
        '
        'Phai_nop
        '
        Me.Phai_nop.DataPropertyName = "Thu_bat_buoc"
        Me.Phai_nop.FalseValue = "false"
        Me.Phai_nop.HeaderText = "Phải nộp"
        Me.Phai_nop.MinimumWidth = 90
        Me.Phai_nop.Name = "Phai_nop"
        Me.Phai_nop.ReadOnly = True
        Me.Phai_nop.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Phai_nop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Phai_nop.TrueValue = "True"
        Me.Phai_nop.Width = 90
        '
        'txtTen_thu_chi
        '
        Me.txtTen_thu_chi.BackColor = System.Drawing.Color.White
        Me.txtTen_thu_chi.Location = New System.Drawing.Point(133, 37)
        Me.txtTen_thu_chi.MaxLength = 100
        Me.txtTen_thu_chi.Name = "txtTen_thu_chi"
        Me.txtTen_thu_chi.Size = New System.Drawing.Size(246, 23)
        Me.txtTen_thu_chi.TabIndex = 155
        '
        'chkHoc_phi
        '
        Me.chkHoc_phi.BackColor = System.Drawing.Color.Transparent
        Me.chkHoc_phi.Location = New System.Drawing.Point(137, 102)
        Me.chkHoc_phi.Name = "chkHoc_phi"
        Me.chkHoc_phi.Size = New System.Drawing.Size(87, 21)
        Me.chkHoc_phi.TabIndex = 156
        Me.chkHoc_phi.Text = "Học phí"
        Me.chkHoc_phi.UseVisualStyleBackColor = False
        '
        'chkThuTheo_NienKhoa
        '
        Me.chkThuTheo_NienKhoa.BackColor = System.Drawing.Color.Transparent
        Me.chkThuTheo_NienKhoa.Location = New System.Drawing.Point(241, 103)
        Me.chkThuTheo_NienKhoa.Name = "chkThuTheo_NienKhoa"
        Me.chkThuTheo_NienKhoa.Size = New System.Drawing.Size(164, 20)
        Me.chkThuTheo_NienKhoa.TabIndex = 157
        Me.chkThuTheo_NienKhoa.Text = "Thu theo niên khóa"
        Me.chkThuTheo_NienKhoa.UseVisualStyleBackColor = False
        '
        'optThu
        '
        Me.optThu.BackColor = System.Drawing.Color.Transparent
        Me.optThu.Location = New System.Drawing.Point(137, 68)
        Me.optThu.Name = "optThu"
        Me.optThu.Size = New System.Drawing.Size(108, 23)
        Me.optThu.TabIndex = 158
        Me.optThu.TabStop = True
        Me.optThu.Text = "Khoản thu"
        Me.optThu.UseVisualStyleBackColor = False
        '
        'optChi
        '
        Me.optChi.BackColor = System.Drawing.Color.Transparent
        Me.optChi.Location = New System.Drawing.Point(241, 68)
        Me.optChi.Name = "optChi"
        Me.optChi.Size = New System.Drawing.Size(108, 23)
        Me.optChi.TabIndex = 159
        Me.optChi.TabStop = True
        Me.optChi.Text = "Khoản chi"
        Me.optChi.UseVisualStyleBackColor = False
        '
        'chkThu_Batbuoc
        '
        Me.chkThu_Batbuoc.BackColor = System.Drawing.Color.Transparent
        Me.chkThu_Batbuoc.Location = New System.Drawing.Point(412, 102)
        Me.chkThu_Batbuoc.Name = "chkThu_Batbuoc"
        Me.chkThu_Batbuoc.Size = New System.Drawing.Size(164, 20)
        Me.chkThu_Batbuoc.TabIndex = 160
        Me.chkThu_Batbuoc.Text = "Thu bắt buộc"
        Me.chkThu_Batbuoc.UseVisualStyleBackColor = False
        '
        'frmESS_LoaiThuChi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(637, 369)
        Me.Controls.Add(Me.chkThu_Batbuoc)
        Me.Controls.Add(Me.optChi)
        Me.Controls.Add(Me.optThu)
        Me.Controls.Add(Me.chkThuTheo_NienKhoa)
        Me.Controls.Add(Me.chkHoc_phi)
        Me.Controls.Add(Me.txtTen_thu_chi)
        Me.Controls.Add(Me.grdViewLoaiThuChi)
        Me.Controls.Add(Me.txtSo_tien)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_LoaiThuChi"
        Me.Text = "Loại thu chi"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewLoaiThuChi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSo_tien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grdViewLoaiThuChi As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTen_thu_chi As System.Windows.Forms.TextBox
    Friend WithEvents chkHoc_phi As System.Windows.Forms.CheckBox
    Friend WithEvents optChi As System.Windows.Forms.RadioButton
    Friend WithEvents optThu As System.Windows.Forms.RadioButton
    Friend WithEvents chkThuTheo_NienKhoa As System.Windows.Forms.CheckBox
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkThu_Batbuoc As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Hoc_phi As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
