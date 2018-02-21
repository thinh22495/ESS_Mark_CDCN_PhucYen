<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThamSoHeThong
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdThamSoHeThong = New System.Windows.Forms.DataGridView
        Me.Ten_tham_so = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gia_tri = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ghi_chu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdThamSoHeThong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSSysMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdThamSoHeThong
        '
        Me.grdThamSoHeThong.AllowUserToAddRows = False
        Me.grdThamSoHeThong.AllowUserToDeleteRows = False
        Me.grdThamSoHeThong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdThamSoHeThong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdThamSoHeThong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThamSoHeThong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdThamSoHeThong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdThamSoHeThong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_tham_so, Me.gia_tri, Me.ghi_chu})
        Me.grdThamSoHeThong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdThamSoHeThong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdThamSoHeThong.Location = New System.Drawing.Point(0, 25)
        Me.grdThamSoHeThong.Name = "grdThamSoHeThong"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThamSoHeThong.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdThamSoHeThong.RowHeadersWidth = 25
        Me.grdThamSoHeThong.Size = New System.Drawing.Size(792, 541)
        Me.grdThamSoHeThong.TabIndex = 25
        '
        'Ten_tham_so
        '
        Me.Ten_tham_so.DataPropertyName = "Ten_tham_so"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_tham_so.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ten_tham_so.HeaderText = "Tên tham số"
        Me.Ten_tham_so.Name = "Ten_tham_so"
        Me.Ten_tham_so.ReadOnly = True
        '
        'gia_tri
        '
        Me.gia_tri.DataPropertyName = "gia_tri"
        Me.gia_tri.HeaderText = "Giá trị"
        Me.gia_tri.Name = "gia_tri"
        '
        'ghi_chu
        '
        Me.ghi_chu.DataPropertyName = "Ghi_chu"
        Me.ghi_chu.HeaderText = "Ghi chú"
        Me.ghi_chu.Name = "ghi_chu"
        Me.ghi_chu.ReadOnly = True
        '
        'frmESS_ThamSoHeThong
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grdThamSoHeThong)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmESS_ThamSoHeThong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tham số hệ thống"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdThamSoHeThong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdThamSoHeThong As System.Windows.Forms.DataGridView
    Friend WithEvents Ten_tham_so As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gia_tri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ghi_chu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
