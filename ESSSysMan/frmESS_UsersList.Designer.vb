<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_UsersList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_UsersList))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.cmdGan_quyen = New System.Windows.Forms.ToolStripButton
        Me.cmdGan_lop = New System.Windows.Forms.ToolStripButton
        Me.cmdCoVan = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.UserName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGroupName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPhongBan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Active1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ToolStrip.SuspendLayout()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdEdit, Me.cmdDelete, Me.cmdGan_quyen, Me.cmdGan_lop, Me.cmdCoVan, Me.cmdClose})
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
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
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
        Me.cmdGan_quyen.Image = Global.ESSSysMan.My.Resources.Resources.HosoSV
        Me.cmdGan_quyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGan_quyen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGan_quyen.Name = "cmdGan_quyen"
        Me.cmdGan_quyen.Size = New System.Drawing.Size(98, 22)
        Me.cmdGan_quyen.Text = "Gán vai trò"
        '
        'cmdGan_lop
        '
        Me.cmdGan_lop.Image = Global.ESSSysMan.My.Resources.Resources.ChuyenLop
        Me.cmdGan_lop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGan_lop.Name = "cmdGan_lop"
        Me.cmdGan_lop.Size = New System.Drawing.Size(129, 22)
        Me.cmdGan_lop.Text = "Gán lớp quản lý"
        '
        'cmdCoVan
        '
        Me.cmdCoVan.Image = Global.ESSSysMan.My.Resources.Resources.User
        Me.cmdCoVan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCoVan.Name = "cmdCoVan"
        Me.cmdCoVan.Size = New System.Drawing.Size(211, 22)
        Me.cmdCoVan.Text = "Cố vấn học tập cho sinh viên"
        '
        'cmdClose
        '
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Th&oát"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(0, 25)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(792, 540)
        Me.grcDanhSach.TabIndex = 119
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.UserName1, Me.GridColumn1, Me.colPhongBan, Me.colGroupName, Me.Active1})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'UserName1
        '
        Me.UserName1.Caption = "Tên đăng nhập"
        Me.UserName1.FieldName = "UserName"
        Me.UserName1.Name = "UserName1"
        Me.UserName1.Visible = True
        Me.UserName1.VisibleIndex = 0
        Me.UserName1.Width = 110
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Họ tên"
        Me.GridColumn1.FieldName = "FullName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 177
        '
        'colGroupName
        '
        Me.colGroupName.Caption = "Nhóm"
        Me.colGroupName.FieldName = "GroupName"
        Me.colGroupName.Name = "colGroupName"
        Me.colGroupName.OptionsColumn.AllowEdit = False
        Me.colGroupName.Visible = True
        Me.colGroupName.VisibleIndex = 2
        Me.colGroupName.Width = 229
        '
        'colPhongBan
        '
        Me.colPhongBan.Caption = "Tên phòng"
        Me.colPhongBan.FieldName = "Phong_ban"
        Me.colPhongBan.Name = "colPhongBan"
        Me.colPhongBan.OptionsColumn.AllowEdit = False
        Me.colPhongBan.Visible = True
        Me.colPhongBan.VisibleIndex = 3
        Me.colPhongBan.Width = 142
        '
        'Active1
        '
        Me.Active1.Caption = "Trạng thái"
        Me.Active1.FieldName = "Active"
        Me.Active1.Name = "Active1"
        Me.Active1.OptionsColumn.AllowEdit = False
        Me.Active1.Visible = True
        Me.Active1.VisibleIndex = 4
        Me.Active1.Width = 113
        '
        'frmESS_UsersList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_UsersList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Quản lý người dùng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdGan_quyen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdGan_lop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCoVan As System.Windows.Forms.ToolStripButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhongBan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Active1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
