<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhungChuongTrinhDaotao_ChungChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhungChuongTrinhDaotao_ChungChi))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ID_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ky_hieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtTen_mh = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbLoaiChungChi = New System.Windows.Forms.ComboBox
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint_TheoKy = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint_TheoKhoiKT = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.cmdAdd_HP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdRemove_HP = New DevExpress.XtraBars.BarButtonItem
        Me.cmdAdd_CT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdXoa_ESSCT = New DevExpress.XtraBars.BarButtonItem
        Me.cmdCopy = New DevExpress.XtraBars.BarButtonItem
        Me.cmdImport = New DevExpress.XtraBars.BarButtonItem
        Me.cmdUpdate_Diem = New DevExpress.XtraBars.BarButtonItem
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenu3 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdLuu = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGanLop = New DevExpress.XtraEditors.SimpleButton
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(652, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(48, 22)
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdClose
        '
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(49, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chon, Me.ID_mon, Me.Ky_hieu, Me.Ten_mon})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(652, 449)
        Me.DataGridView1.TabIndex = 29
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.FalseValue = "0"
        Me.Chon.HeaderText = "Chọn"
        Me.Chon.Name = "Chon"
        Me.Chon.TrueValue = "1"
        '
        'ID_mon
        '
        Me.ID_mon.DataPropertyName = "ID_mon"
        Me.ID_mon.HeaderText = "ID môn"
        Me.ID_mon.Name = "ID_mon"
        Me.ID_mon.ReadOnly = True
        Me.ID_mon.Visible = False
        '
        'Ky_hieu
        '
        Me.Ky_hieu.DataPropertyName = "Ky_hieu"
        Me.Ky_hieu.HeaderText = "Mã môn học"
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.ReadOnly = True
        Me.Ky_hieu.Width = 120
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        Me.Ten_mon.FillWeight = 360.0!
        Me.Ten_mon.HeaderText = "Tên môn"
        Me.Ten_mon.MinimumWidth = 360
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 360
        '
        'txtTen_mh
        '
        Me.txtTen_mh.Location = New System.Drawing.Point(131, 28)
        Me.txtTen_mh.Name = "txtTen_mh"
        Me.txtTen_mh.Size = New System.Drawing.Size(234, 23)
        Me.txtTen_mh.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(0, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Lọc theo tên môn:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(380, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Loại chúng chỉ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoaiChungChi
        '
        Me.cmbLoaiChungChi.FormattingEnabled = True
        Me.cmbLoaiChungChi.Location = New System.Drawing.Point(486, 29)
        Me.cmbLoaiChungChi.Name = "cmbLoaiChungChi"
        Me.cmbLoaiChungChi.Size = New System.Drawing.Size(163, 24)
        Me.cmbLoaiChungChi.TabIndex = 39
        '
        'ImgMain
        '
        Me.ImgMain.ImageStream = CType(resources.GetObject("ImgMain.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImgMain.Images.SetKeyName(0, "Add.png")
        Me.ImgMain.Images.SetKeyName(1, "Back.png")
        Me.ImgMain.Images.SetKeyName(2, "Bar Chart.png")
        Me.ImgMain.Images.SetKeyName(3, "Comment.png")
        Me.ImgMain.Images.SetKeyName(4, "Delete.png")
        Me.ImgMain.Images.SetKeyName(5, "Email.png")
        Me.ImgMain.Images.SetKeyName(6, "excel.ico")
        Me.ImgMain.Images.SetKeyName(7, "Exit.png")
        Me.ImgMain.Images.SetKeyName(8, "Info.png")
        Me.ImgMain.Images.SetKeyName(9, "Line Chart.png")
        Me.ImgMain.Images.SetKeyName(10, "Load.png")
        Me.ImgMain.Images.SetKeyName(11, "Loading.png")
        Me.ImgMain.Images.SetKeyName(12, "Modify.png")
        Me.ImgMain.Images.SetKeyName(13, "Next.png")
        Me.ImgMain.Images.SetKeyName(14, "Picture.png")
        Me.ImgMain.Images.SetKeyName(15, "Pie Chart.png")
        Me.ImgMain.Images.SetKeyName(16, "Print.png")
        Me.ImgMain.Images.SetKeyName(17, "Profile.png")
        Me.ImgMain.Images.SetKeyName(18, "Save.png")
        Me.ImgMain.Images.SetKeyName(19, "Search.png")
        Me.ImgMain.Images.SetKeyName(20, "Warning.png")
        Me.ImgMain.Images.SetKeyName(21, "word.ico")
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_TheoKy), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint_TheoKhoiKT)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint_TheoKy
        '
        Me.cmdPrint_TheoKy.Caption = "In theo kỳ"
        Me.cmdPrint_TheoKy.Id = 0
        Me.cmdPrint_TheoKy.ImageIndex = 16
        Me.cmdPrint_TheoKy.Name = "cmdPrint_TheoKy"
        '
        'cmdPrint_TheoKhoiKT
        '
        Me.cmdPrint_TheoKhoiKT.Caption = "In theo khối kiến thức"
        Me.cmdPrint_TheoKhoiKT.Id = 1
        Me.cmdPrint_TheoKhoiKT.ImageIndex = 16
        Me.cmdPrint_TheoKhoiKT.Name = "cmdPrint_TheoKhoiKT"
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("PopupMenu", New System.Guid("e259ec3f-8673-4306-bb4f-94322df1890e"))})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint_TheoKy, Me.cmdPrint_TheoKhoiKT, Me.cmdAdd_HP, Me.cmdRemove_HP, Me.cmdAdd_CT, Me.cmdXoa_ESSCT, Me.cmdCopy, Me.cmdImport, Me.cmdUpdate_Diem})
        Me.BarManager1.MaxItemId = 9
        '
        'BarDockControl1
        '
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(652, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 535)
        Me.BarDockControl2.Size = New System.Drawing.Size(652, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 535)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(652, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 535)
        '
        'cmdAdd_HP
        '
        Me.cmdAdd_HP.Caption = "Thêm học phần"
        Me.cmdAdd_HP.Id = 2
        Me.cmdAdd_HP.ImageIndex = 0
        Me.cmdAdd_HP.Name = "cmdAdd_HP"
        '
        'cmdRemove_HP
        '
        Me.cmdRemove_HP.Caption = "Loại học phần"
        Me.cmdRemove_HP.Id = 3
        Me.cmdRemove_HP.ImageIndex = 4
        Me.cmdRemove_HP.Name = "cmdRemove_HP"
        '
        'cmdAdd_CT
        '
        Me.cmdAdd_CT.Caption = "Thêm"
        Me.cmdAdd_CT.Id = 4
        Me.cmdAdd_CT.ImageIndex = 0
        Me.cmdAdd_CT.Name = "cmdAdd_CT"
        '
        'cmdXoa_ESSCT
        '
        Me.cmdXoa_ESSCT.Caption = "Xóa"
        Me.cmdXoa_ESSCT.Id = 5
        Me.cmdXoa_ESSCT.ImageIndex = 4
        Me.cmdXoa_ESSCT.Name = "cmdXoa_ESSCT"
        '
        'cmdCopy
        '
        Me.cmdCopy.Caption = "Sao chép"
        Me.cmdCopy.Id = 6
        Me.cmdCopy.ImageIndex = 18
        Me.cmdCopy.Name = "cmdCopy"
        '
        'cmdImport
        '
        Me.cmdImport.Caption = "Nhập khẩu"
        Me.cmdImport.Id = 7
        Me.cmdImport.ImageIndex = 11
        Me.cmdImport.Name = "cmdImport"
        '
        'cmdUpdate_Diem
        '
        Me.cmdUpdate_Diem.Caption = "Cập nhật điểm theo CTĐT"
        Me.cmdUpdate_Diem.Id = 8
        Me.cmdUpdate_Diem.ImageIndex = 18
        Me.cmdUpdate_Diem.Name = "cmdUpdate_Diem"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd_HP), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdRemove_HP), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdUpdate_Diem)})
        Me.PopupMenu2.Manager = Me.BarManager1
        Me.PopupMenu2.Name = "PopupMenu2"
        '
        'PopupMenu3
        '
        Me.PopupMenu3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd_CT), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdXoa_ESSCT), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdImport)})
        Me.PopupMenu3.Manager = Me.BarManager1
        Me.PopupMenu3.Name = "PopupMenu3"
        '
        'cmdLuu
        '
        Me.cmdLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLuu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLuu.Appearance.Options.UseFont = True
        Me.cmdLuu.ImageIndex = 18
        Me.cmdLuu.ImageList = Me.ImgMain
        Me.cmdLuu.Location = New System.Drawing.Point(473, 510)
        Me.cmdLuu.Name = "cmdLuu"
        Me.cmdLuu.Size = New System.Drawing.Size(77, 25)
        Me.cmdLuu.TabIndex = 166
        Me.cmdLuu.Text = "Cập nhật"
        '
        'cmdGanLop
        '
        Me.cmdGanLop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGanLop.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGanLop.Appearance.Options.UseFont = True
        Me.cmdGanLop.ImageIndex = 4
        Me.cmdGanLop.ImageList = Me.ImgMain
        Me.cmdGanLop.Location = New System.Drawing.Point(556, 510)
        Me.cmdGanLop.Name = "cmdGanLop"
        Me.cmdGanLop.Size = New System.Drawing.Size(77, 25)
        Me.cmdGanLop.TabIndex = 165
        Me.cmdGanLop.Text = "Thoát"
        '
        'frmfrmESS_KhungChuongTrinhDaotao_ChungChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdLuu)
        Me.Controls.Add(Me.cmdGanLop)
        Me.Controls.Add(Me.cmbLoaiChungChi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTen_mh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmfrmESS_KhungChuongTrinhDaotao_ChungChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmfrmESS_KhungChuongTrinhDaotao_ChungChi"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTen_mh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ID_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ky_hieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLoaiChungChi As System.Windows.Forms.ComboBox
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint_TheoKy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint_TheoKhoiKT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdAdd_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdRemove_HP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdAdd_CT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdXoa_ESSCT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCopy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdUpdate_Diem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenu3 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGanLop As DevExpress.XtraEditors.SimpleButton
End Class
