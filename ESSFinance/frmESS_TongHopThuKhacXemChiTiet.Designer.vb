<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopThuKhacXemChiTiet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grdViewBienLai = New System.Windows.Forms.DataGridView
        Me.Hoc_ky = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nam_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_phieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_thu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_dung = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewBienLai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip.TabIndex = 70
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'grdViewBienLai
        '
        Me.grdViewBienLai.AllowUserToAddRows = False
        Me.grdViewBienLai.AllowUserToDeleteRows = False
        Me.grdViewBienLai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewBienLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewBienLai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hoc_ky, Me.Nam_hoc, Me.So_phieu, Me.Ngay_thu, Me.Noi_dung, Me.So_tien})
        Me.grdViewBienLai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdViewBienLai.Location = New System.Drawing.Point(0, 25)
        Me.grdViewBienLai.Name = "grdViewBienLai"
        Me.grdViewBienLai.RowHeadersWidth = 25
        Me.grdViewBienLai.Size = New System.Drawing.Size(692, 441)
        Me.grdViewBienLai.TabIndex = 130
        '
        'Hoc_ky
        '
        Me.Hoc_ky.DataPropertyName = "Hoc_ky"
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
        Me.Nam_hoc.MinimumWidth = 100
        Me.Nam_hoc.Name = "Nam_hoc"
        Me.Nam_hoc.ReadOnly = True
        '
        'So_phieu
        '
        Me.So_phieu.DataPropertyName = "So_phieu"
        Me.So_phieu.HeaderText = "Số phiếu"
        Me.So_phieu.MinimumWidth = 100
        Me.So_phieu.Name = "So_phieu"
        Me.So_phieu.ReadOnly = True
        '
        'Ngay_thu
        '
        Me.Ngay_thu.DataPropertyName = "Ngay_thu"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.Ngay_thu.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ngay_thu.HeaderText = "Ngày thu"
        Me.Ngay_thu.MinimumWidth = 100
        Me.Ngay_thu.Name = "Ngay_thu"
        Me.Ngay_thu.ReadOnly = True
        '
        'Noi_dung
        '
        Me.Noi_dung.DataPropertyName = "Noi_dung"
        Me.Noi_dung.HeaderText = "Nội dung"
        Me.Noi_dung.MinimumWidth = 180
        Me.Noi_dung.Name = "Noi_dung"
        Me.Noi_dung.ReadOnly = True
        Me.Noi_dung.Width = 180
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        DataGridViewCellStyle2.Format = "###,###"
        Me.So_tien.DefaultCellStyle = DataGridViewCellStyle2
        Me.So_tien.HeaderText = "Số tiền"
        Me.So_tien.MinimumWidth = 90
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        Me.So_tien.Width = 90
        '
        'frmESS_TongHopThuKhacXemChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 466)
        Me.Controls.Add(Me.grdViewBienLai)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaximizeBox = False
        Me.Name = "frmESS_TongHopThuKhacXemChiTiet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tổng hợp thu phí xem chi tiết"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewBienLai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdViewBienLai As System.Windows.Forms.DataGridView
    Friend WithEvents Hoc_ky As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nam_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_phieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_thu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_dung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
