<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_VaiTroGanQuyen
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
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPhan_he = New System.Windows.Forms.ComboBox
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.optAllDel = New System.Windows.Forms.CheckBox
        Me.optAllIns = New System.Windows.Forms.CheckBox
        Me.optAllUpd = New System.Windows.Forms.CheckBox
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.grdViewQuyen = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ten_quyen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Them = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Sua = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Xoa = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.grdViewQuyenGan = New System.Windows.Forms.DataGridView
        Me.Chon1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ten_Quyen1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Them1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Sua1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Xoa1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewQuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewQuyenGan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(989, 25)
        Me.ToolStrip.TabIndex = 20
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSSysMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "&Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Th&oát"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Phân hệ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPhan_he
        '
        Me.cmbPhan_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhan_he.FormattingEnabled = True
        Me.cmbPhan_he.Location = New System.Drawing.Point(87, 28)
        Me.cmbPhan_he.Name = "cmbPhan_he"
        Me.cmbPhan_he.Size = New System.Drawing.Size(292, 24)
        Me.cmbPhan_he.TabIndex = 25
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll.ForeColor = System.Drawing.Color.Black
        Me.optAll.Location = New System.Drawing.Point(14, 59)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(112, 22)
        Me.optAll.TabIndex = 45
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'optAllDel
        '
        Me.optAllDel.BackColor = System.Drawing.Color.Transparent
        Me.optAllDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAllDel.ForeColor = System.Drawing.Color.Black
        Me.optAllDel.Location = New System.Drawing.Point(327, 59)
        Me.optAllDel.Name = "optAllDel"
        Me.optAllDel.Size = New System.Drawing.Size(19, 22)
        Me.optAllDel.TabIndex = 48
        Me.optAllDel.UseVisualStyleBackColor = False
        '
        'optAllIns
        '
        Me.optAllIns.BackColor = System.Drawing.Color.Transparent
        Me.optAllIns.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAllIns.ForeColor = System.Drawing.Color.Black
        Me.optAllIns.Location = New System.Drawing.Point(249, 59)
        Me.optAllIns.Name = "optAllIns"
        Me.optAllIns.Size = New System.Drawing.Size(19, 22)
        Me.optAllIns.TabIndex = 47
        Me.optAllIns.UseVisualStyleBackColor = False
        '
        'optAllUpd
        '
        Me.optAllUpd.BackColor = System.Drawing.Color.Transparent
        Me.optAllUpd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAllUpd.ForeColor = System.Drawing.Color.Black
        Me.optAllUpd.Location = New System.Drawing.Point(288, 59)
        Me.optAllUpd.Name = "optAllUpd"
        Me.optAllUpd.Size = New System.Drawing.Size(19, 22)
        Me.optAllUpd.TabIndex = 46
        Me.optAllUpd.UseVisualStyleBackColor = False
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll1.ForeColor = System.Drawing.Color.Black
        Me.optAll1.Location = New System.Drawing.Point(515, 55)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(112, 22)
        Me.optAll1.TabIndex = 49
        Me.optAll1.Text = "Chọn tất cả"
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.ESSSysMan.My.Resources.Resources.Delete
        Me.btnDelete.Location = New System.Drawing.Point(479, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(30, 25)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.ESSSysMan.My.Resources.Resources.Add
        Me.btnAdd.Location = New System.Drawing.Point(479, 236)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 25)
        Me.btnAdd.TabIndex = 50
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grdViewQuyen
        '
        Me.grdViewQuyen.AllowUserToAddRows = False
        Me.grdViewQuyen.AllowUserToDeleteRows = False
        Me.grdViewQuyen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdViewQuyen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewQuyen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdViewQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewQuyen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.Ten_quyen, Me.Them, Me.Sua, Me.Xoa})
        Me.grdViewQuyen.Location = New System.Drawing.Point(0, 83)
        Me.grdViewQuyen.Name = "grdViewQuyen"
        Me.grdViewQuyen.RowHeadersVisible = False
        Me.grdViewQuyen.Size = New System.Drawing.Size(473, 473)
        Me.grdViewQuyen.TabIndex = 53
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Width = 50
        '
        'Ten_quyen
        '
        Me.Ten_quyen.DataPropertyName = "Ten_Quyen"
        Me.Ten_quyen.HeaderText = "Chức năng"
        Me.Ten_quyen.Name = "Ten_quyen"
        Me.Ten_quyen.ReadOnly = True
        Me.Ten_quyen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ten_quyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ten_quyen.Width = 260
        '
        'Them
        '
        Me.Them.DataPropertyName = "Them"
        Me.Them.HeaderText = "Thêm"
        Me.Them.Name = "Them"
        Me.Them.Width = 50
        '
        'Sua
        '
        Me.Sua.DataPropertyName = "Sua"
        Me.Sua.HeaderText = "Sửa"
        Me.Sua.Name = "Sua"
        Me.Sua.Width = 40
        '
        'Xoa
        '
        Me.Xoa.DataPropertyName = "Xoa"
        Me.Xoa.HeaderText = "Xoá"
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Width = 40
        '
        'grdViewQuyenGan
        '
        Me.grdViewQuyenGan.AllowUserToAddRows = False
        Me.grdViewQuyenGan.AllowUserToDeleteRows = False
        Me.grdViewQuyenGan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdViewQuyenGan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewQuyenGan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewQuyenGan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon1, Me.Ten_Quyen1, Me.Them1, Me.Sua1, Me.Xoa1})
        Me.grdViewQuyenGan.Location = New System.Drawing.Point(515, 83)
        Me.grdViewQuyenGan.Name = "grdViewQuyenGan"
        Me.grdViewQuyenGan.RowHeadersVisible = False
        Me.grdViewQuyenGan.Size = New System.Drawing.Size(467, 473)
        Me.grdViewQuyenGan.TabIndex = 26
        '
        'Chon1
        '
        Me.Chon1.DataPropertyName = "Chon"
        Me.Chon1.HeaderText = "Chọn"
        Me.Chon1.Name = "Chon1"
        Me.Chon1.Width = 50
        '
        'Ten_Quyen1
        '
        Me.Ten_Quyen1.DataPropertyName = "Ten_Quyen"
        Me.Ten_Quyen1.HeaderText = "Chức năng"
        Me.Ten_Quyen1.Name = "Ten_Quyen1"
        Me.Ten_Quyen1.ReadOnly = True
        Me.Ten_Quyen1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ten_Quyen1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ten_Quyen1.Width = 260
        '
        'Them1
        '
        Me.Them1.DataPropertyName = "Them"
        Me.Them1.HeaderText = "Thêm"
        Me.Them1.Name = "Them1"
        Me.Them1.Width = 50
        '
        'Sua1
        '
        Me.Sua1.DataPropertyName = "Sua"
        Me.Sua1.HeaderText = "Sửa"
        Me.Sua1.Name = "Sua1"
        Me.Sua1.Width = 40
        '
        'Xoa1
        '
        Me.Xoa1.DataPropertyName = "Xoa"
        Me.Xoa1.HeaderText = "Xoá"
        Me.Xoa1.Name = "Xoa1"
        Me.Xoa1.Width = 40
        '
        'frmESS_VaiTroGanQuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 562)
        Me.Controls.Add(Me.grdViewQuyen)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.optAllDel)
        Me.Controls.Add(Me.optAllIns)
        Me.Controls.Add(Me.optAllUpd)
        Me.Controls.Add(Me.grdViewQuyenGan)
        Me.Controls.Add(Me.cmbPhan_he)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_VaiTroGanQuyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phân quyền"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewQuyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewQuyenGan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPhan_he As System.Windows.Forms.ComboBox
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents optAllDel As System.Windows.Forms.CheckBox
    Friend WithEvents optAllIns As System.Windows.Forms.CheckBox
    Friend WithEvents optAllUpd As System.Windows.Forms.CheckBox
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grdViewQuyen As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewQuyenGan As System.Windows.Forms.DataGridView
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ten_quyen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Them As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Sua As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Xoa As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Chon1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ten_Quyen1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Them1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Sua1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Xoa1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
