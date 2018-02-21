<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_PhanLoaiHocBongTheoDoiTuong
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdViewDoiTuongHB = New System.Windows.Forms.DataGridView
        Me.Ten_dt_hb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_dt_hb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewLoaiHB = New System.Windows.Forms.DataGridView
        Me.Ten_he = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_xep_loai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HB_HT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSo_tien = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLoai_HB = New System.Windows.Forms.ComboBox
        Me.lblHoc_ky = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        CType(Me.grdViewDoiTuongHB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewLoaiHB, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grdViewDoiTuongHB.Location = New System.Drawing.Point(6, 22)
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
        Me.grdViewDoiTuongHB.Size = New System.Drawing.Size(737, 230)
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
        'grdViewLoaiHB
        '
        Me.grdViewLoaiHB.AllowUserToAddRows = False
        Me.grdViewLoaiHB.AllowUserToDeleteRows = False
        Me.grdViewLoaiHB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewLoaiHB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewLoaiHB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewLoaiHB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdViewLoaiHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewLoaiHB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_he, Me.Ten_xep_loai, Me.HB_HT})
        Me.grdViewLoaiHB.Location = New System.Drawing.Point(0, 49)
        Me.grdViewLoaiHB.Name = "grdViewLoaiHB"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewLoaiHB.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdViewLoaiHB.RowHeadersVisible = False
        Me.grdViewLoaiHB.Size = New System.Drawing.Size(735, 112)
        Me.grdViewLoaiHB.TabIndex = 90
        '
        'Ten_he
        '
        Me.Ten_he.DataPropertyName = "Ten_he"
        Me.Ten_he.HeaderText = "Tên hệ đào tạo"
        Me.Ten_he.MinimumWidth = 300
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.ReadOnly = True
        Me.Ten_he.Width = 300
        '
        'Ten_xep_loai
        '
        Me.Ten_xep_loai.DataPropertyName = "Ten_xep_loai"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_xep_loai.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ten_xep_loai.HeaderText = "Loại HB"
        Me.Ten_xep_loai.MinimumWidth = 200
        Me.Ten_xep_loai.Name = "Ten_xep_loai"
        Me.Ten_xep_loai.ReadOnly = True
        Me.Ten_xep_loai.Width = 200
        '
        'HB_HT
        '
        Me.HB_HT.DataPropertyName = "HB_HT"
        Me.HB_HT.HeaderText = "Số tiền HB"
        Me.HB_HT.MinimumWidth = 150
        Me.HB_HT.Name = "HB_HT"
        Me.HB_HT.ReadOnly = True
        Me.HB_HT.Width = 150
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
        Me.GroupBox2.Controls.Add(Me.cmbID_he)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSo_tien)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.grdViewLoaiHB)
        Me.GroupBox2.Controls.Add(Me.cmbLoai_HB)
        Me.GroupBox2.Controls.Add(Me.lblHoc_ky)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 290)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(735, 161)
        Me.GroupBox2.TabIndex = 134
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loại học bổng theo đối tượng"
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Enabled = False
        Me.cmbID_he.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_he.Location = New System.Drawing.Point(82, 19)
        Me.cmbID_he.MaxDropDownItems = 5
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(203, 24)
        Me.cmbID_he.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Hệ đào tạo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSo_tien
        '
        Me.txtSo_tien.Enabled = False
        Me.txtSo_tien.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSo_tien.Location = New System.Drawing.Point(648, 19)
        Me.txtSo_tien.MaxLength = 11
        Me.txtSo_tien.Name = "txtSo_tien"
        Me.txtSo_tien.Size = New System.Drawing.Size(85, 23)
        Me.txtSo_tien.TabIndex = 168
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Số tiền"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_HB
        '
        Me.cmbLoai_HB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_HB.Enabled = False
        Me.cmbLoai_HB.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoai_HB.Location = New System.Drawing.Point(399, 19)
        Me.cmbLoai_HB.MaxDropDownItems = 5
        Me.cmbLoai_HB.Name = "cmbLoai_HB"
        Me.cmbLoai_HB.Size = New System.Drawing.Size(170, 24)
        Me.cmbLoai_HB.TabIndex = 127
        '
        'lblHoc_ky
        '
        Me.lblHoc_ky.BackColor = System.Drawing.Color.Transparent
        Me.lblHoc_ky.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoc_ky.Location = New System.Drawing.Point(293, 18)
        Me.lblHoc_ky.Name = "lblHoc_ky"
        Me.lblHoc_ky.Size = New System.Drawing.Size(103, 23)
        Me.lblHoc_ky.TabIndex = 134
        Me.lblHoc_ky.Text = "Loại học bổng"
        Me.lblHoc_ky.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.grdViewDoiTuongHB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 258)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sác đối tượng học bổng"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdSave, Me.cmdCancel, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(758, 25)
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
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdEdit.Image = Global.ESSFinance.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(54, 22)
        Me.cmdEdit.Text = "Sửa"
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
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 10.0!)
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
        'frmESS_PhanLoaiHocBongTheoDoiTuong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(758, 455)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmESS_PhanLoaiHocBongTheoDoiTuong"
        Me.Text = "Phân loại học bổng theo đối tượng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDoiTuongHB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewLoaiHB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdViewDoiTuongHB As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewLoaiHB As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbLoai_HB As System.Windows.Forms.ComboBox
    Friend WithEvents lblHoc_ky As System.Windows.Forms.Label
    Friend WithEvents txtSo_tien As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Public WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ten_dt_hb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_dt_hb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_he As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_xep_loai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HB_HT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
