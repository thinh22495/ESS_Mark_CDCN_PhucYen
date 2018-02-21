<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThayDoiThanhPhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ThayDoiThanhPhan))
        Me.grcThanhPhan = New DevExpress.XtraGrid.GridControl
        Me.grvThanhPhan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_thanh_phan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTy_le = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_thanh_phan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHe_so = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNhom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcThanhPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvThanhPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcThanhPhan
        '
        Me.grcThanhPhan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcThanhPhan.Location = New System.Drawing.Point(2, 0)
        Me.grcThanhPhan.MainView = Me.grvThanhPhan
        Me.grcThanhPhan.Name = "grcThanhPhan"
        Me.grcThanhPhan.Size = New System.Drawing.Size(692, 324)
        Me.grcThanhPhan.TabIndex = 152
        Me.grcThanhPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvThanhPhan})
        '
        'grvThanhPhan
        '
        Me.grvThanhPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colSTT, Me.colKy_hieu, Me.colTen_thanh_phan, Me.colTy_le, Me.colID_thanh_phan, Me.colHe_so, Me.colNhom})
        Me.grvThanhPhan.GridControl = Me.grcThanhPhan
        Me.grvThanhPhan.Name = "grvThanhPhan"
        Me.grvThanhPhan.OptionsSelection.MultiSelect = True
        Me.grvThanhPhan.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 59
        '
        'colSTT
        '
        Me.colSTT.Caption = "STT"
        Me.colSTT.FieldName = "STT"
        Me.colSTT.Name = "colSTT"
        Me.colSTT.OptionsColumn.ReadOnly = True
        Me.colSTT.Visible = True
        Me.colSTT.VisibleIndex = 1
        Me.colSTT.Width = 49
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Ký hiệu"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.ReadOnly = True
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 2
        Me.colKy_hieu.Width = 90
        '
        'colTen_thanh_phan
        '
        Me.colTen_thanh_phan.Caption = "Tên thành phần"
        Me.colTen_thanh_phan.FieldName = "Ten_thanh_phan"
        Me.colTen_thanh_phan.Name = "colTen_thanh_phan"
        Me.colTen_thanh_phan.OptionsColumn.ReadOnly = True
        Me.colTen_thanh_phan.Visible = True
        Me.colTen_thanh_phan.VisibleIndex = 3
        Me.colTen_thanh_phan.Width = 243
        '
        'colTy_le
        '
        Me.colTy_le.Caption = "Tỷ lệ"
        Me.colTy_le.FieldName = "Ty_le"
        Me.colTy_le.Name = "colTy_le"
        Me.colTy_le.Visible = True
        Me.colTy_le.VisibleIndex = 6
        Me.colTy_le.Width = 260
        '
        'colID_thanh_phan
        '
        Me.colID_thanh_phan.Caption = "ID_thanh_phan"
        Me.colID_thanh_phan.FieldName = "ID_thanh_phan"
        Me.colID_thanh_phan.Name = "colID_thanh_phan"
        '
        'colHe_so
        '
        Me.colHe_so.Caption = "Hệ số"
        Me.colHe_so.FieldName = "He_so"
        Me.colHe_so.Name = "colHe_so"
        Me.colHe_so.Visible = True
        Me.colHe_so.VisibleIndex = 4
        Me.colHe_so.Width = 63
        '
        'colNhom
        '
        Me.colNhom.Caption = "Nhóm"
        Me.colNhom.FieldName = "Nhom"
        Me.colNhom.Name = "colNhom"
        Me.colNhom.Visible = True
        Me.colNhom.VisibleIndex = 5
        Me.colNhom.Width = 60
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(614, 329)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 31)
        Me.cmdClose.TabIndex = 155
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
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(533, 329)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 31)
        Me.cmdSave.TabIndex = 154
        Me.cmdSave.Text = "Lưu"
        '
        'frmESS_ThayDoiThanhPhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 366)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grcThanhPhan)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ThayDoiThanhPhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "Thành phần điểm"
        CType(Me.grcThanhPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvThanhPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grvThanhPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_thanh_phan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTy_le As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_thanh_phan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Public WithEvents grcThanhPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents colHe_so As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNhom As DevExpress.XtraGrid.Columns.GridColumn
End Class
