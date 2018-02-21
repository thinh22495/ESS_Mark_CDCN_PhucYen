<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_QuyHocBongList
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewQuyHocBong = New System.Windows.Forms.DataGridView
        Me.Hoc_ky = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nam_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Loai_quy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tu_khoa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Den_khoa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sotien_ngansach = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sotien_khac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ghi_chu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdViewQuyHocBong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 28
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
        'grdViewQuyHocBong
        '
        Me.grdViewQuyHocBong.AllowUserToAddRows = False
        Me.grdViewQuyHocBong.AllowUserToDeleteRows = False
        Me.grdViewQuyHocBong.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewQuyHocBong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewQuyHocBong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewQuyHocBong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewQuyHocBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewQuyHocBong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hoc_ky, Me.Nam_hoc, Me.Loai_quy, Me.Tu_khoa, Me.Den_khoa, Me.Sotien_ngansach, Me.Sotien_khac, Me.Ghi_chu})
        Me.grdViewQuyHocBong.Location = New System.Drawing.Point(5, 58)
        Me.grdViewQuyHocBong.Name = "grdViewQuyHocBong"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewQuyHocBong.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdViewQuyHocBong.RowHeadersVisible = False
        Me.grdViewQuyHocBong.Size = New System.Drawing.Size(787, 504)
        Me.grdViewQuyHocBong.TabIndex = 89
        '
        'Hoc_ky
        '
        Me.Hoc_ky.DataPropertyName = "Hoc_ky"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Hoc_ky.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hoc_ky.HeaderText = "Học kỳ"
        Me.Hoc_ky.MinimumWidth = 80
        Me.Hoc_ky.Name = "Hoc_ky"
        Me.Hoc_ky.ReadOnly = True
        Me.Hoc_ky.Width = 80
        '
        'Nam_hoc
        '
        Me.Nam_hoc.DataPropertyName = "Nam_hoc"
        Me.Nam_hoc.HeaderText = "Năm học"
        Me.Nam_hoc.MinimumWidth = 90
        Me.Nam_hoc.Name = "Nam_hoc"
        Me.Nam_hoc.ReadOnly = True
        Me.Nam_hoc.Width = 90
        '
        'Loai_quy
        '
        Me.Loai_quy.DataPropertyName = "Loai_quy"
        Me.Loai_quy.HeaderText = "Loại quỹ HB"
        Me.Loai_quy.MinimumWidth = 120
        Me.Loai_quy.Name = "Loai_quy"
        Me.Loai_quy.ReadOnly = True
        Me.Loai_quy.Width = 120
        '
        'Tu_khoa
        '
        Me.Tu_khoa.DataPropertyName = "Tu_khoa"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tu_khoa.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tu_khoa.HeaderText = "Từ khóa"
        Me.Tu_khoa.MinimumWidth = 90
        Me.Tu_khoa.Name = "Tu_khoa"
        Me.Tu_khoa.ReadOnly = True
        Me.Tu_khoa.Width = 90
        '
        'Den_khoa
        '
        Me.Den_khoa.DataPropertyName = "Den_khoa"
        Me.Den_khoa.HeaderText = "Đến khóa"
        Me.Den_khoa.MinimumWidth = 95
        Me.Den_khoa.Name = "Den_khoa"
        Me.Den_khoa.ReadOnly = True
        Me.Den_khoa.Width = 95
        '
        'Sotien_ngansach
        '
        Me.Sotien_ngansach.DataPropertyName = "Sotien_ngansach"
        Me.Sotien_ngansach.HeaderText = "Số tiền ngân sách"
        Me.Sotien_ngansach.MinimumWidth = 150
        Me.Sotien_ngansach.Name = "Sotien_ngansach"
        Me.Sotien_ngansach.ReadOnly = True
        Me.Sotien_ngansach.Width = 150
        '
        'Sotien_khac
        '
        Me.Sotien_khac.DataPropertyName = "Sotien_khac"
        Me.Sotien_khac.HeaderText = "Số tiền khác"
        Me.Sotien_khac.MinimumWidth = 120
        Me.Sotien_khac.Name = "Sotien_khac"
        Me.Sotien_khac.ReadOnly = True
        Me.Sotien_khac.Width = 120
        '
        'Ghi_chu
        '
        Me.Ghi_chu.DataPropertyName = "Ghi_chu"
        Me.Ghi_chu.HeaderText = "Ghi chú"
        Me.Ghi_chu.MinimumWidth = 100
        Me.Ghi_chu.Name = "Ghi_chu"
        Me.Ghi_chu.ReadOnly = True
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(87, 28)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(49, 24)
        Me.cmbHoc_ky.TabIndex = 149
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(256, 29)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(111, 24)
        Me.cmbNam_hoc.TabIndex = 150
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(2, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Học kỳ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(183, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_QuyHocBongList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grdViewQuyHocBong)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_QuyHocBongList"
        Me.Text = "Danh sách quỹ học bổng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdViewQuyHocBong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewQuyHocBong As System.Windows.Forms.DataGridView
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Hoc_ky As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nam_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Loai_quy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tu_khoa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Den_khoa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sotien_ngansach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sotien_khac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ghi_chu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
