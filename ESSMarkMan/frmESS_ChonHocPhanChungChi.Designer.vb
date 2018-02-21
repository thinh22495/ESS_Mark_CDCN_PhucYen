<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ChonHocPhanChungChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ChonHocPhanChungChi))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbLoaiChungChi = New System.Windows.Forms.ComboBox
        Me.grcDanhSachHP = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSachHP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_tieng_anh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcDanhSachHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(108, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Chọn loại chứng chỉ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoaiChungChi
        '
        Me.cmbLoaiChungChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoaiChungChi.FormattingEnabled = True
        Me.cmbLoaiChungChi.Location = New System.Drawing.Point(260, 501)
        Me.cmbLoaiChungChi.Name = "cmbLoaiChungChi"
        Me.cmbLoaiChungChi.Size = New System.Drawing.Size(163, 24)
        Me.cmbLoaiChungChi.TabIndex = 39
        '
        'grcDanhSachHP
        '
        Me.grcDanhSachHP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSachHP.Location = New System.Drawing.Point(1, 2)
        Me.grcDanhSachHP.MainView = Me.grvDanhSachHP
        Me.grcDanhSachHP.Name = "grcDanhSachHP"
        Me.grcDanhSachHP.Size = New System.Drawing.Size(649, 491)
        Me.grcDanhSachHP.TabIndex = 154
        Me.grcDanhSachHP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachHP})
        '
        'grvDanhSachHP
        '
        Me.grvDanhSachHP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colKy_hieu, Me.colTen_mon, Me.colTen_tieng_anh, Me.colID_mon})
        Me.grvDanhSachHP.GridControl = Me.grcDanhSachHP
        Me.grvDanhSachHP.Name = "grvDanhSachHP"
        Me.grvDanhSachHP.OptionsSelection.MultiSelect = True
        Me.grvDanhSachHP.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSachHP.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 59
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Ký hiệu"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.ReadOnly = True
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 1
        Me.colKy_hieu.Width = 111
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.ReadOnly = True
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 2
        Me.colTen_mon.Width = 292
        '
        'colTen_tieng_anh
        '
        Me.colTen_tieng_anh.Caption = "Tên tiếng anh"
        Me.colTen_tieng_anh.FieldName = "Ten_tieng_anh"
        Me.colTen_tieng_anh.Name = "colTen_tieng_anh"
        Me.colTen_tieng_anh.Visible = True
        Me.colTen_tieng_anh.VisibleIndex = 3
        Me.colTen_tieng_anh.Width = 166
        '
        'colID_mon
        '
        Me.colID_mon.Caption = "ID_mon"
        Me.colID_mon.FieldName = "ID_mon"
        Me.colID_mon.Name = "colID_mon"
        Me.colID_mon.OptionsColumn.ReadOnly = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(553, 498)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 30)
        Me.cmdClose.TabIndex = 184
        Me.cmdClose.Text = "Thoát"
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
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.ImgMain
        Me.cmdAdd.Location = New System.Drawing.Point(448, 498)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(96, 30)
        Me.cmdAdd.TabIndex = 185
        Me.cmdAdd.Text = "Thêm"
        '
        'frmESS_ChonMonHocChungChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 535)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.grcDanhSachHP)
        Me.Controls.Add(Me.cmbLoaiChungChi)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmESS_ChonMonHocChungChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn Học phần cho Bộ môn"
        CType(Me.grcDanhSachHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLoaiChungChi As System.Windows.Forms.ComboBox
    Friend WithEvents grcDanhSachHP As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachHP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_tieng_anh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
End Class
