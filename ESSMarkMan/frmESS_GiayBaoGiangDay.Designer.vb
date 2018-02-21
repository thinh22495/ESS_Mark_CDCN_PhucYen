<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_GiayBaoGiangDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_GiayBaoGiangDay))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.txtHei = New System.Windows.Forms.ToolStripTextBox
        Me.txtWid = New System.Windows.Forms.ToolStripTextBox
        Me.cmbID_BM = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.picLock = New System.Windows.Forms.PictureBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdOpen = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExportExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "SuKien.png")
        Me.ImageList.Images.SetKeyName(1, "Lop.png")
        Me.ImageList.Images.SetKeyName(2, "GiaoVien.png")
        Me.ImageList.Images.SetKeyName(3, "Home.png")
        '
        'cmbID_he
        '
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbID_he.Location = New System.Drawing.Point(39, 29)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(185, 24)
        Me.cmbID_he.TabIndex = 111
        '
        'txtHei
        '
        Me.txtHei.Name = "txtHei"
        Me.txtHei.Size = New System.Drawing.Size(25, 25)
        Me.txtHei.Text = "50"
        Me.txtHei.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHei.Visible = False
        '
        'txtWid
        '
        Me.txtWid.Name = "txtWid"
        Me.txtWid.Size = New System.Drawing.Size(25, 25)
        Me.txtWid.Text = "50"
        Me.txtWid.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtWid.Visible = False
        '
        'cmbID_BM
        '
        Me.cmbID_BM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_BM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_BM.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbID_BM.ItemHeight = 16
        Me.cmbID_BM.Location = New System.Drawing.Point(582, 29)
        Me.cmbID_BM.Name = "cmbID_BM"
        Me.cmbID_BM.Size = New System.Drawing.Size(208, 24)
        Me.cmbID_BM.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(512, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Bộ môn:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 24)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Hệ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(230, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 24)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Khoa:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbID_khoa.ItemHeight = 16
        Me.cmbID_khoa.Location = New System.Drawing.Point(282, 29)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(224, 24)
        Me.cmbID_khoa.TabIndex = 113
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.Cols = New C1.Win.C1FlexGrid.ColumnCollection(10, 1, 0, 0, 0, 95, "")
        Me.fg.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.fg.Location = New System.Drawing.Point(0, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 0
        Me.fg.Rows.Fixed = 0
        Me.fg.Size = New System.Drawing.Size(792, 510)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 110
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(447, 319)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(10, 9)
        Me.picLock.TabIndex = 109
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdOpen, Me.cmdPrint, Me.cmdExportExcel, Me.cmdClose, Me.txtWid, Me.txtHei})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 108
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdOpen
        '
        Me.cmdOpen.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(32, 22)
        Me.cmdOpen.Text = "Mở"
        '
        'cmdPrint
        '
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(117, 22)
        Me.cmdPrint.Text = "In thời khoá biểu"
        '
        'cmdExportExcel
        '
        Me.cmdExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExportExcel.Name = "cmdExportExcel"
        Me.cmdExportExcel.Size = New System.Drawing.Size(94, 22)
        Me.cmdExportExcel.Text = "Xuất ra Excel"
        '
        'cmdClose
        '
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(49, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'frmESS_GiayBaoGiangDay
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.cmbID_BM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_GiayBaoGiangDay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giấy báo giảng dậy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents txtHei As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtWid As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmbID_BM As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExportExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
End Class
