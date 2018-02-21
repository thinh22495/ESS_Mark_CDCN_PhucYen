<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_UsersGanVaiTro
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
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.grdViewQuyenGan = New System.Windows.Forms.DataGridView
        Me.Chon1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ten_vai_tro1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mo_ta1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewQuyen = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Ten_vai_tro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mo_ta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        CType(Me.grdViewQuyenGan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewQuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.ESSSysMan.My.Resources.Resources.Delete
        Me.btnDelete.Location = New System.Drawing.Point(423, 263)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(50, 30)
        Me.btnDelete.TabIndex = 58
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.ESSSysMan.My.Resources.Resources.Add
        Me.btnAdd.Location = New System.Drawing.Point(423, 227)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 30)
        Me.btnAdd.TabIndex = 57
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll1.ForeColor = System.Drawing.Color.Black
        Me.optAll1.Location = New System.Drawing.Point(475, 31)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(142, 18)
        Me.optAll1.TabIndex = 56
        Me.optAll1.Text = "Chọn tất cả"
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll.ForeColor = System.Drawing.Color.Black
        Me.optAll.Location = New System.Drawing.Point(12, 31)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(121, 18)
        Me.optAll.TabIndex = 55
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'grdViewQuyenGan
        '
        Me.grdViewQuyenGan.AllowUserToAddRows = False
        Me.grdViewQuyenGan.AllowUserToDeleteRows = False
        Me.grdViewQuyenGan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdViewQuyenGan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewQuyenGan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewQuyenGan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon1, Me.Ten_vai_tro1, Me.Mo_ta1})
        Me.grdViewQuyenGan.Location = New System.Drawing.Point(475, 55)
        Me.grdViewQuyenGan.Name = "grdViewQuyenGan"
        Me.grdViewQuyenGan.RowHeadersVisible = False
        Me.grdViewQuyenGan.Size = New System.Drawing.Size(423, 507)
        Me.grdViewQuyenGan.TabIndex = 54
        '
        'Chon1
        '
        Me.Chon1.DataPropertyName = "Chon"
        Me.Chon1.HeaderText = "Chọn"
        Me.Chon1.Name = "Chon1"
        Me.Chon1.Width = 48
        '
        'Ten_vai_tro1
        '
        Me.Ten_vai_tro1.DataPropertyName = "Ten_vai_tro"
        Me.Ten_vai_tro1.HeaderText = "Chức năng"
        Me.Ten_vai_tro1.Name = "Ten_vai_tro1"
        Me.Ten_vai_tro1.ReadOnly = True
        Me.Ten_vai_tro1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ten_vai_tro1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ten_vai_tro1.Width = 84
        '
        'Mo_ta1
        '
        Me.Mo_ta1.DataPropertyName = "Mo_ta"
        Me.Mo_ta1.HeaderText = "Mô tả"
        Me.Mo_ta1.Name = "Mo_ta1"
        Me.Mo_ta1.ReadOnly = True
        Me.Mo_ta1.Width = 68
        '
        'grdViewQuyen
        '
        Me.grdViewQuyen.AllowUserToAddRows = False
        Me.grdViewQuyen.AllowUserToDeleteRows = False
        Me.grdViewQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdViewQuyen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewQuyen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdViewQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewQuyen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.Ten_vai_tro, Me.Mo_ta})
        Me.grdViewQuyen.Location = New System.Drawing.Point(0, 53)
        Me.grdViewQuyen.Name = "grdViewQuyen"
        Me.grdViewQuyen.RowHeadersVisible = False
        Me.grdViewQuyen.Size = New System.Drawing.Size(419, 509)
        Me.grdViewQuyen.TabIndex = 53
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.Width = 48
        '
        'Ten_vai_tro
        '
        Me.Ten_vai_tro.DataPropertyName = "Ten_vai_tro"
        Me.Ten_vai_tro.HeaderText = "Vai trò"
        Me.Ten_vai_tro.Name = "Ten_vai_tro"
        Me.Ten_vai_tro.ReadOnly = True
        Me.Ten_vai_tro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ten_vai_tro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ten_vai_tro.Width = 55
        '
        'Mo_ta
        '
        Me.Mo_ta.DataPropertyName = "Mo_ta"
        Me.Mo_ta.HeaderText = "Mô tả"
        Me.Mo_ta.Name = "Mo_ta"
        Me.Mo_ta.ReadOnly = True
        Me.Mo_ta.Width = 68
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(902, 25)
        Me.ToolStrip.TabIndex = 52
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
        'frmESS_UsersGanVaiTro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 568)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.grdViewQuyenGan)
        Me.Controls.Add(Me.grdViewQuyen)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmESS_UsersGanVaiTro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gán vai trò"
        CType(Me.grdViewQuyenGan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewQuyen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewQuyenGan As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewQuyen As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Chon1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ten_vai_tro1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mo_ta1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Ten_vai_tro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mo_ta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
