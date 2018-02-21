<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_frmESS_KhungChuongTrinhDaoTao_ThietLapMonChungChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_frmESS_KhungChuongTrinhDaoTao_ThietLapMonChungChi))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grcLoaiChungChi = New DevExpress.XtraGrid.GridControl
        Me.grvLoaiChungChi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu_cc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLoai_chung_chi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_chung_chi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcMonChungChi = New DevExpress.XtraGrid.GridControl
        Me.grvMonChungChi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu_m = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdChonMon = New DevExpress.XtraEditors.SimpleButton
        Me.cmdHuyMon = New DevExpress.XtraEditors.SimpleButton
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcLoaiChungChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvLoaiChungChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcMonChungChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMonChungChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grcLoaiChungChi
        '
        Me.grcLoaiChungChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcLoaiChungChi.Location = New System.Drawing.Point(0, 0)
        Me.grcLoaiChungChi.MainView = Me.grvLoaiChungChi
        Me.grcLoaiChungChi.Name = "grcLoaiChungChi"
        Me.grcLoaiChungChi.Size = New System.Drawing.Size(541, 170)
        Me.grcLoaiChungChi.TabIndex = 153
        Me.grcLoaiChungChi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvLoaiChungChi})
        '
        'grvLoaiChungChi
        '
        Me.grvLoaiChungChi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu_cc, Me.colLoai_chung_chi, Me.colID_chung_chi})
        Me.grvLoaiChungChi.GridControl = Me.grcLoaiChungChi
        Me.grvLoaiChungChi.Name = "grvLoaiChungChi"
        Me.grvLoaiChungChi.OptionsSelection.MultiSelect = True
        Me.grvLoaiChungChi.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu_cc
        '
        Me.colKy_hieu_cc.Caption = "Ký hiệu"
        Me.colKy_hieu_cc.FieldName = "Ky_hieu_cc"
        Me.colKy_hieu_cc.Name = "colKy_hieu_cc"
        Me.colKy_hieu_cc.OptionsColumn.ReadOnly = True
        Me.colKy_hieu_cc.Visible = True
        Me.colKy_hieu_cc.VisibleIndex = 0
        Me.colKy_hieu_cc.Width = 100
        '
        'colLoai_chung_chi
        '
        Me.colLoai_chung_chi.Caption = "Loại chứng chỉ"
        Me.colLoai_chung_chi.FieldName = "Loai_chung_chi"
        Me.colLoai_chung_chi.Name = "colLoai_chung_chi"
        Me.colLoai_chung_chi.OptionsColumn.ReadOnly = True
        Me.colLoai_chung_chi.Visible = True
        Me.colLoai_chung_chi.VisibleIndex = 1
        Me.colLoai_chung_chi.Width = 300
        '
        'colID_chung_chi
        '
        Me.colID_chung_chi.Caption = "ID_chung_chi"
        Me.colID_chung_chi.FieldName = "ID_chung_chi"
        Me.colID_chung_chi.Name = "colID_chung_chi"
        Me.colID_chung_chi.OptionsColumn.ReadOnly = True
        Me.colID_chung_chi.Width = 364
        '
        'grcMonChungChi
        '
        Me.grcMonChungChi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcMonChungChi.Location = New System.Drawing.Point(0, 176)
        Me.grcMonChungChi.MainView = Me.grvMonChungChi
        Me.grcMonChungChi.Name = "grcMonChungChi"
        Me.grcMonChungChi.Size = New System.Drawing.Size(541, 172)
        Me.grcMonChungChi.TabIndex = 154
        Me.grcMonChungChi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMonChungChi})
        '
        'grvMonChungChi
        '
        Me.grvMonChungChi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu_m, Me.colTen_mon, Me.colID_mon})
        Me.grvMonChungChi.GridControl = Me.grcMonChungChi
        Me.grvMonChungChi.Name = "grvMonChungChi"
        Me.grvMonChungChi.OptionsSelection.MultiSelect = True
        Me.grvMonChungChi.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu_m
        '
        Me.colKy_hieu_m.Caption = "Ký hiệu"
        Me.colKy_hieu_m.FieldName = "ky_hieu_m"
        Me.colKy_hieu_m.Name = "colKy_hieu_m"
        Me.colKy_hieu_m.OptionsColumn.ReadOnly = True
        Me.colKy_hieu_m.Visible = True
        Me.colKy_hieu_m.VisibleIndex = 0
        Me.colKy_hieu_m.Width = 100
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.ReadOnly = True
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 300
        '
        'colID_mon
        '
        Me.colID_mon.Caption = "ID_mon"
        Me.colID_mon.FieldName = "ID_mon"
        Me.colID_mon.Name = "colID_mon"
        Me.colID_mon.OptionsColumn.ReadOnly = True
        Me.colID_mon.Width = 315
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(449, 352)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 25)
        Me.cmdClose.TabIndex = 157
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
        'cmdChonMon
        '
        Me.cmdChonMon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChonMon.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChonMon.Appearance.Options.UseFont = True
        Me.cmdChonMon.ImageIndex = 10
        Me.cmdChonMon.ImageList = Me.ImgMain
        Me.cmdChonMon.Location = New System.Drawing.Point(205, 352)
        Me.cmdChonMon.Name = "cmdChonMon"
        Me.cmdChonMon.Size = New System.Drawing.Size(114, 25)
        Me.cmdChonMon.TabIndex = 156
        Me.cmdChonMon.Text = "Chọn Học phần"
        '
        'cmdHuyMon
        '
        Me.cmdHuyMon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHuyMon.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHuyMon.Appearance.Options.UseFont = True
        Me.cmdHuyMon.ImageIndex = 4
        Me.cmdHuyMon.ImageList = Me.ImgMain
        Me.cmdHuyMon.Location = New System.Drawing.Point(327, 352)
        Me.cmdHuyMon.Name = "cmdHuyMon"
        Me.cmdHuyMon.Size = New System.Drawing.Size(114, 25)
        Me.cmdHuyMon.TabIndex = 157
        Me.cmdHuyMon.Text = "Hủy Học phần"
        '
        'frmESS_ThietLapMonChungChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 380)
        Me.Controls.Add(Me.cmdHuyMon)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdChonMon)
        Me.Controls.Add(Me.grcMonChungChi)
        Me.Controls.Add(Me.grcLoaiChungChi)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ThietLapMonChungChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thiết lập Học phần chứng chỉ"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcLoaiChungChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvLoaiChungChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcMonChungChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMonChungChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents grcLoaiChungChi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvLoaiChungChi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu_cc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoai_chung_chi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_chung_chi As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents grcMonChungChi As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMonChungChi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu_m As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdChonMon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdHuyMon As DevExpress.XtraEditors.SimpleButton
End Class
