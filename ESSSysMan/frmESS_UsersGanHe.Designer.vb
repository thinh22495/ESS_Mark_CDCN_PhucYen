<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_VaiTroGanLop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_VaiTroGanLop))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdLopAccess = New System.Windows.Forms.DataGridView
        Me.Ten_he = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_khoa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Khoa_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_nganh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chuyen_nganh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbID_nganh = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdLopAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdAdd, Me.cmdDelete, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
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
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 22)
        Me.cmdAdd.Text = "&Thêm"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.ESSSysMan.My.Resources.Resources.Delete
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(52, 22)
        Me.cmdDelete.Text = "&Xoá"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSSysMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Th&oát"
        '
        'grdLopAccess
        '
        Me.grdLopAccess.AllowUserToAddRows = False
        Me.grdLopAccess.AllowUserToDeleteRows = False
        Me.grdLopAccess.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLopAccess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdLopAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLopAccess.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_he, Me.Ten_khoa, Me.Khoa_hoc, Me.Ten_nganh, Me.Chuyen_nganh})
        Me.grdLopAccess.Location = New System.Drawing.Point(0, 88)
        Me.grdLopAccess.Name = "grdLopAccess"
        Me.grdLopAccess.ReadOnly = True
        Me.grdLopAccess.RowHeadersWidth = 25
        Me.grdLopAccess.Size = New System.Drawing.Size(792, 478)
        Me.grdLopAccess.TabIndex = 28
        '
        'Ten_he
        '
        Me.Ten_he.DataPropertyName = "Ten_he"
        Me.Ten_he.HeaderText = "Hệ đào tạo"
        Me.Ten_he.Name = "Ten_he"
        Me.Ten_he.ReadOnly = True
        Me.Ten_he.Width = 150
        '
        'Ten_khoa
        '
        Me.Ten_khoa.DataPropertyName = "Ten_khoa"
        Me.Ten_khoa.HeaderText = "Khoa"
        Me.Ten_khoa.Name = "Ten_khoa"
        Me.Ten_khoa.ReadOnly = True
        Me.Ten_khoa.Width = 150
        '
        'Khoa_hoc
        '
        Me.Khoa_hoc.DataPropertyName = "Khoa_hoc"
        Me.Khoa_hoc.HeaderText = "Khoá học"
        Me.Khoa_hoc.Name = "Khoa_hoc"
        Me.Khoa_hoc.ReadOnly = True
        '
        'Ten_nganh
        '
        Me.Ten_nganh.DataPropertyName = "Ten_nganh"
        Me.Ten_nganh.HeaderText = "Ngành"
        Me.Ten_nganh.Name = "Ten_nganh"
        Me.Ten_nganh.ReadOnly = True
        Me.Ten_nganh.Width = 150
        '
        'Chuyen_nganh
        '
        Me.Chuyen_nganh.DataPropertyName = "Chuyen_nganh"
        Me.Chuyen_nganh.HeaderText = "Chuyên ngành"
        Me.Chuyen_nganh.Name = "Chuyen_nganh"
        Me.Chuyen_nganh.ReadOnly = True
        Me.Chuyen_nganh.Width = 200
        '
        'cmbID_he
        '
        Me.cmbID_he.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Location = New System.Drawing.Point(122, 28)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(187, 24)
        Me.cmbID_he.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(1, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Hệ đào tạo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.Location = New System.Drawing.Point(433, 28)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(223, 24)
        Me.cmbID_khoa.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(334, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Khoa:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(636, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Khoá học:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(433, 58)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(347, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(311, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Chuyên ngành:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_nganh
        '
        Me.cmbID_nganh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbID_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nganh.Location = New System.Drawing.Point(122, 58)
        Me.cmbID_nganh.Name = "cmbID_nganh"
        Me.cmbID_nganh.Size = New System.Drawing.Size(187, 24)
        Me.cmbID_nganh.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(0, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Ngành:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(733, 28)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(47, 24)
        Me.cmbKhoa_hoc.TabIndex = 52
        '
        'frmESS_VaiTroGanLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbKhoa_hoc)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.cmbID_nganh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdLopAccess)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmESS_VaiTroGanLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gán lớp quản lý"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdLopAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdLopAccess As System.Windows.Forms.DataGridView
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbID_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Ten_he As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_khoa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Khoa_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_nganh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chuyen_nganh As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
