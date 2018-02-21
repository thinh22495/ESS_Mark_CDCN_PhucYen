<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_PhanBoQuyHocBongChiTiet
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
        Me.txtSo_tien_toi_da = New System.Windows.Forms.TextBox
        Me.txtSo_tien_con_lai = New System.Windows.Forms.TextBox
        Me.txtSo_tien_da_phan = New System.Windows.Forms.TextBox
        Me.txtSo_sv = New System.Windows.Forms.TextBox
        Me.txtTen_phan_bo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSotien = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewPhanBo = New System.Windows.Forms.DataGridView
        Me.Ten_phan_bo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kieu_phan_bo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdViewPhanBo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSo_tien_toi_da
        '
        Me.txtSo_tien_toi_da.BackColor = System.Drawing.Color.White
        Me.txtSo_tien_toi_da.Enabled = False
        Me.txtSo_tien_toi_da.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_tien_toi_da.Location = New System.Drawing.Point(487, 84)
        Me.txtSo_tien_toi_da.Name = "txtSo_tien_toi_da"
        Me.txtSo_tien_toi_da.Size = New System.Drawing.Size(152, 22)
        Me.txtSo_tien_toi_da.TabIndex = 145
        '
        'txtSo_tien_con_lai
        '
        Me.txtSo_tien_con_lai.BackColor = System.Drawing.Color.White
        Me.txtSo_tien_con_lai.Enabled = False
        Me.txtSo_tien_con_lai.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_tien_con_lai.Location = New System.Drawing.Point(487, 56)
        Me.txtSo_tien_con_lai.Name = "txtSo_tien_con_lai"
        Me.txtSo_tien_con_lai.Size = New System.Drawing.Size(152, 22)
        Me.txtSo_tien_con_lai.TabIndex = 143
        '
        'txtSo_tien_da_phan
        '
        Me.txtSo_tien_da_phan.BackColor = System.Drawing.Color.White
        Me.txtSo_tien_da_phan.Enabled = False
        Me.txtSo_tien_da_phan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_tien_da_phan.Location = New System.Drawing.Point(116, 84)
        Me.txtSo_tien_da_phan.MaxLength = 11
        Me.txtSo_tien_da_phan.Name = "txtSo_tien_da_phan"
        Me.txtSo_tien_da_phan.Size = New System.Drawing.Size(152, 22)
        Me.txtSo_tien_da_phan.TabIndex = 144
        '
        'txtSo_sv
        '
        Me.txtSo_sv.BackColor = System.Drawing.Color.White
        Me.txtSo_sv.Enabled = False
        Me.txtSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_sv.Location = New System.Drawing.Point(116, 56)
        Me.txtSo_sv.Name = "txtSo_sv"
        Me.txtSo_sv.Size = New System.Drawing.Size(64, 22)
        Me.txtSo_sv.TabIndex = 142
        '
        'txtTen_phan_bo
        '
        Me.txtTen_phan_bo.BackColor = System.Drawing.Color.White
        Me.txtTen_phan_bo.Enabled = False
        Me.txtTen_phan_bo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_phan_bo.Location = New System.Drawing.Point(116, 28)
        Me.txtTen_phan_bo.MaxLength = 199
        Me.txtTen_phan_bo.Name = "txtTen_phan_bo"
        Me.txtTen_phan_bo.Size = New System.Drawing.Size(523, 22)
        Me.txtTen_phan_bo.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 22)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Số tiền tối đa cho phép phân:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 22)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Số tiền chưa phân:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 22)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Số tiền đã phân:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Số sinh viên:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSotien
        '
        Me.lblSotien.BackColor = System.Drawing.Color.Transparent
        Me.lblSotien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSotien.Location = New System.Drawing.Point(6, 28)
        Me.lblSotien.Name = "lblSotien"
        Me.lblSotien.Size = New System.Drawing.Size(104, 22)
        Me.lblSotien.TabIndex = 146
        Me.lblSotien.Text = "Tên phân bổ:"
        Me.lblSotien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdEdit, Me.cmdDelete, Me.cmdCancel, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(651, 25)
        Me.ToolStrip1.TabIndex = 151
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
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
        'grdViewPhanBo
        '
        Me.grdViewPhanBo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewPhanBo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewPhanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewPhanBo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_phan_bo, Me.So_sv, Me.So_tien, Me.Kieu_phan_bo})
        Me.grdViewPhanBo.Location = New System.Drawing.Point(9, 112)
        Me.grdViewPhanBo.Name = "grdViewPhanBo"
        Me.grdViewPhanBo.Size = New System.Drawing.Size(630, 366)
        Me.grdViewPhanBo.TabIndex = 155
        '
        'Ten_phan_bo
        '
        Me.Ten_phan_bo.DataPropertyName = "Ten_phan_bo"
        Me.Ten_phan_bo.HeaderText = "Tên phân bổ"
        Me.Ten_phan_bo.MinimumWidth = 300
        Me.Ten_phan_bo.Name = "Ten_phan_bo"
        Me.Ten_phan_bo.ReadOnly = True
        Me.Ten_phan_bo.Width = 300
        '
        'So_sv
        '
        Me.So_sv.DataPropertyName = "So_sv"
        Me.So_sv.HeaderText = "Số sinh viên"
        Me.So_sv.MinimumWidth = 150
        Me.So_sv.Name = "So_sv"
        Me.So_sv.ReadOnly = True
        Me.So_sv.Width = 150
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        Me.So_tien.HeaderText = "Số tiền phân bổ"
        Me.So_tien.MinimumWidth = 150
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        Me.So_tien.Width = 150
        '
        'Kieu_phan_bo
        '
        Me.Kieu_phan_bo.DataPropertyName = "Kieu_phan_bo"
        Me.Kieu_phan_bo.HeaderText = "Kiểu phân bổ"
        Me.Kieu_phan_bo.MinimumWidth = 120
        Me.Kieu_phan_bo.Name = "Kieu_phan_bo"
        Me.Kieu_phan_bo.ReadOnly = True
        Me.Kieu_phan_bo.Width = 120
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESS_PhanBoQuyHocBongChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 481)
        Me.Controls.Add(Me.grdViewPhanBo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtSo_tien_toi_da)
        Me.Controls.Add(Me.txtSo_tien_con_lai)
        Me.Controls.Add(Me.txtSo_tien_da_phan)
        Me.Controls.Add(Me.txtSo_sv)
        Me.Controls.Add(Me.txtTen_phan_bo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSotien)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaximizeBox = False
        Me.Name = "frmESS_PhanBoQuyHocBongChiTiet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phân bổ quỹ học bổng chi tiết"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdViewPhanBo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSo_tien_toi_da As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_tien_con_lai As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_tien_da_phan As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_sv As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_phan_bo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSotien As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewPhanBo As System.Windows.Forms.DataGridView
    Friend WithEvents Ten_phan_bo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kieu_phan_bo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
End Class
