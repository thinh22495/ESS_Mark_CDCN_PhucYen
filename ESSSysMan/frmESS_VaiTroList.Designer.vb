<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_VaiTroList
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
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdGan_quyen = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewVaiTro = New System.Windows.Forms.DataGridView
        Me.Ten_vai_tro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mo_ta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewVaiTro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdGan_quyen, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 18
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdAdd.Image = Global.ESSSysMan.My.Resources.Resources.Add
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "&Thêm"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESSSysMan.My.Resources.Resources.Edit
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(54, 22)
        Me.cmdEdit.Text = "&Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSSysMan.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "&Xoá"
        '
        'cmdGan_quyen
        '
        Me.cmdGan_quyen.Image = Global.ESSSysMan.My.Resources.Resources.Cancel
        Me.cmdGan_quyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGan_quyen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGan_quyen.Name = "cmdGan_quyen"
        Me.cmdGan_quyen.Size = New System.Drawing.Size(98, 22)
        Me.cmdGan_quyen.Text = "Gán quyền"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Th&oát"
        '
        'grdViewVaiTro
        '
        Me.grdViewVaiTro.AllowUserToAddRows = False
        Me.grdViewVaiTro.AllowUserToDeleteRows = False
        Me.grdViewVaiTro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewVaiTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdViewVaiTro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewVaiTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewVaiTro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_vai_tro, Me.Mo_ta, Me.Column1})
        Me.grdViewVaiTro.Location = New System.Drawing.Point(0, 25)
        Me.grdViewVaiTro.Name = "grdViewVaiTro"
        Me.grdViewVaiTro.ReadOnly = True
        Me.grdViewVaiTro.RowHeadersWidth = 25
        Me.grdViewVaiTro.Size = New System.Drawing.Size(792, 541)
        Me.grdViewVaiTro.TabIndex = 19
        '
        'Ten_vai_tro
        '
        Me.Ten_vai_tro.DataPropertyName = "Ten_vai_tro"
        Me.Ten_vai_tro.HeaderText = "Tên vai trò"
        Me.Ten_vai_tro.Name = "Ten_vai_tro"
        Me.Ten_vai_tro.ReadOnly = True
        '
        'Mo_ta
        '
        Me.Mo_ta.DataPropertyName = "Mo_ta"
        Me.Mo_ta.HeaderText = "Mô tả vai trò"
        Me.Mo_ta.Name = "Mo_ta"
        Me.Mo_ta.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_Vai_Tro"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'frmESS_VaiTroList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grdViewVaiTro)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_VaiTroList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý vai trò"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewVaiTro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdGan_quyen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewVaiTro As System.Windows.Forms.DataGridView
    Friend WithEvents Ten_vai_tro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mo_ta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
