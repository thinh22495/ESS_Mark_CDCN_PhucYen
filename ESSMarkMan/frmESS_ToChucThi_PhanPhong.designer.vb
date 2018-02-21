<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_PhanPhong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThi_PhanPhong))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.fgLop = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.fgPhongHoc = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.cmbID_nha = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbID_co_so = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.fgLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgPhongHoc, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.TabIndex = 57
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'fgLop
        '
        Me.fgLop.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgLop.AllowEditing = False
        Me.fgLop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgLop.Cols = New C1.Win.C1FlexGrid.ColumnCollection(4, 1, 0, 0, 0, 95, "0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9))
        Me.fgLop.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fgLop.Location = New System.Drawing.Point(0, 59)
        Me.fgLop.Name = "fgLop"
        Me.fgLop.Rows.Count = 20
        Me.fgLop.Size = New System.Drawing.Size(409, 507)
        Me.fgLop.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgLop.Styles"))
        Me.fgLop.TabIndex = 80
        '
        'fgPhongHoc
        '
        Me.fgPhongHoc.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgPhongHoc.AllowEditing = False
        Me.fgPhongHoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgPhongHoc.Cols = New C1.Win.C1FlexGrid.ColumnCollection(3, 1, 0, 0, 0, 95, "0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9))
        Me.fgPhongHoc.Location = New System.Drawing.Point(422, 59)
        Me.fgPhongHoc.Name = "fgPhongHoc"
        Me.fgPhongHoc.Rows.Count = 20
        Me.fgPhongHoc.Size = New System.Drawing.Size(370, 511)
        Me.fgPhongHoc.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgPhongHoc.Styles"))
        Me.fgPhongHoc.TabIndex = 81
        '
        'cmbID_nha
        '
        Me.cmbID_nha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_nha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nha.Location = New System.Drawing.Point(710, 29)
        Me.cmbID_nha.Name = "cmbID_nha"
        Me.cmbID_nha.Size = New System.Drawing.Size(76, 24)
        Me.cmbID_nha.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(634, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Toà nhà:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_co_so
        '
        Me.cmbID_co_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_co_so.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_co_so.Location = New System.Drawing.Point(422, 29)
        Me.cmbID_co_so.Name = "cmbID_co_so"
        Me.cmbID_co_so.Size = New System.Drawing.Size(209, 24)
        Me.cmbID_co_so.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(350, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Cơ sở:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_ToChucThiPhanPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbID_co_so)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_nha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fgPhongHoc)
        Me.Controls.Add(Me.fgLop)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmESS_ToChucThiPhanPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phân phòng thi"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.fgLop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgPhongHoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents fgLop As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgPhongHoc As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cmbID_nha As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbID_co_so As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
