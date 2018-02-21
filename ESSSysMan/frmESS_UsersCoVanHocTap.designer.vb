<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_UsersCoVanHocTap
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdViewChonDanhSach = New System.Windows.Forms.DataGridView
        Me.Chon1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.lblCoVan = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.trvLop = New ESSSysMan.TreeViewLop
        CType(Me.grdViewChonDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdViewChonDanhSach
        '
        Me.grdViewChonDanhSach.AllowUserToAddRows = False
        Me.grdViewChonDanhSach.AllowUserToDeleteRows = False
        Me.grdViewChonDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewChonDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewChonDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewChonDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdViewChonDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewChonDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon1, Me.Ma_sv2, Me.Ho_ten2, Me.Ngay_sinh2, Me.Ten_lop2})
        Me.grdViewChonDanhSach.Location = New System.Drawing.Point(265, 342)
        Me.grdViewChonDanhSach.Name = "grdViewChonDanhSach"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewChonDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grdViewChonDanhSach.RowHeadersVisible = False
        Me.grdViewChonDanhSach.RowHeadersWidth = 25
        Me.grdViewChonDanhSach.Size = New System.Drawing.Size(669, 263)
        Me.grdViewChonDanhSach.TabIndex = 111
        '
        'Chon1
        '
        Me.Chon1.DataPropertyName = "Chon"
        Me.Chon1.HeaderText = "Chọn"
        Me.Chon1.MinimumWidth = 45
        Me.Chon1.Name = "Chon1"
        Me.Chon1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon1.Width = 45
        '
        'Ma_sv2
        '
        Me.Ma_sv2.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv2.DefaultCellStyle = DataGridViewCellStyle12
        Me.Ma_sv2.HeaderText = "Mã sv"
        Me.Ma_sv2.MinimumWidth = 100
        Me.Ma_sv2.Name = "Ma_sv2"
        Me.Ma_sv2.ReadOnly = True
        '
        'Ho_ten2
        '
        Me.Ho_ten2.DataPropertyName = "Ho_ten"
        Me.Ho_ten2.HeaderText = "Họ và tên"
        Me.Ho_ten2.MinimumWidth = 160
        Me.Ho_ten2.Name = "Ho_ten2"
        Me.Ho_ten2.ReadOnly = True
        Me.Ho_ten2.Width = 160
        '
        'Ngay_sinh2
        '
        Me.Ngay_sinh2.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Format = "dd/MM/yyyy"
        DataGridViewCellStyle13.NullValue = """"""
        Me.Ngay_sinh2.DefaultCellStyle = DataGridViewCellStyle13
        Me.Ngay_sinh2.HeaderText = "Ngày sinh"
        Me.Ngay_sinh2.MinimumWidth = 100
        Me.Ngay_sinh2.Name = "Ngay_sinh2"
        Me.Ngay_sinh2.ReadOnly = True
        '
        'Ten_lop2
        '
        Me.Ten_lop2.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop2.DefaultCellStyle = DataGridViewCellStyle14
        Me.Ten_lop2.HeaderText = "Tên lớp"
        Me.Ten_lop2.MinimumWidth = 100
        Me.Ten_lop2.Name = "Ten_lop2"
        Me.Ten_lop2.ReadOnly = True
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.grdViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.Ma_sv, Me.Ho_ten, Me.Ngay_sinh, Me.Ten_lop})
        Me.grdViewDanhSach.Location = New System.Drawing.Point(265, 51)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.grdViewDanhSach.RowHeadersVisible = False
        Me.grdViewDanhSach.RowHeadersWidth = 25
        Me.grdViewDanhSach.Size = New System.Drawing.Size(669, 257)
        Me.grdViewDanhSach.TabIndex = 110
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.Frozen = True
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.MinimumWidth = 45
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.Width = 45
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ma_sv.DefaultCellStyle = DataGridViewCellStyle17
        Me.Ma_sv.Frozen = True
        Me.Ma_sv.HeaderText = "Mã sv"
        Me.Ma_sv.MinimumWidth = 100
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.Frozen = True
        Me.Ho_ten.HeaderText = "Họ và tên"
        Me.Ho_ten.MinimumWidth = 160
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 160
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Format = "dd/MM/yyyy"
        DataGridViewCellStyle18.NullValue = """"""
        Me.Ngay_sinh.DefaultCellStyle = DataGridViewCellStyle18
        Me.Ngay_sinh.Frozen = True
        Me.Ngay_sinh.HeaderText = "Ngày sinh"
        Me.Ngay_sinh.MinimumWidth = 100
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.ReadOnly = True
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle19
        Me.Ten_lop.Frozen = True
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 100
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(280, 29)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(124, 19)
        Me.optAll1.TabIndex = 109
        Me.optAll1.Text = "Chọn tất cả "
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Image = Global.ESSSysMan.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(786, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(66, 25)
        Me.btnAdd.TabIndex = 108
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDel.Image = Global.ESSSysMan.My.Resources.Resources.Remove
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(859, 313)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(66, 25)
        Me.btnDel.TabIndex = 107
        Me.btnDel.Text = "Xoá"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(934, 25)
        Me.ToolStrip.TabIndex = 106
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSSysMan.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(280, 313)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(106, 24)
        Me.optAll.TabIndex = 112
        Me.optAll.Text = "Chọn tất cả "
        Me.optAll.UseVisualStyleBackColor = False
        '
        'lblCoVan
        '
        Me.lblCoVan.BackColor = System.Drawing.Color.Transparent
        Me.lblCoVan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoVan.Location = New System.Drawing.Point(0, 27)
        Me.lblCoVan.Name = "lblCoVan"
        Me.lblCoVan.Size = New System.Drawing.Size(263, 21)
        Me.lblCoVan.TabIndex = 113
        Me.lblCoVan.Text = "Cố vấn học tập"
        Me.lblCoVan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(407, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 21)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Số sinh viên cố vấn:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_sv
        '
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(554, 315)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(50, 21)
        Me.lblSo_sv.TabIndex = 115
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(-1, 51)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(264, 557)
        Me.trvLop.TabIndex = 0
        '
        'frmESS_UsersCoVanHocTap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 606)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCoVan)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.grdViewChonDanhSach)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.trvLop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_UsersCoVanHocTap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Có vấn học tập"
        CType(Me.grdViewChonDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trvLop As ESSSysMan.TreeViewLop
    Friend WithEvents grdViewChonDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblCoVan As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents Chon1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
