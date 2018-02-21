<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhungChuongTrinhDaoTao_ChonHocPhan_ChungChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhungChuongTrinhDaoTao_ChonHocPhan_ChungChi))
        Me.grcHocPhan = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colChon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_tieng_anh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmbLoaiChungChi = New System.Windows.Forms.ComboBox
        Me.txtTen_mh = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcHocPhan
        '
        Me.grcHocPhan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhan.Location = New System.Drawing.Point(1, 39)
        Me.grcHocPhan.MainView = Me.grvHocPhan
        Me.grcHocPhan.Name = "grcHocPhan"
        Me.grcHocPhan.Size = New System.Drawing.Size(788, 498)
        Me.grcHocPhan.TabIndex = 69
        Me.grcHocPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhan})
        '
        'grvHocPhan
        '
        Me.grvHocPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChon, Me.colKy_hieu, Me.colTen_mon, Me.colTen_tieng_anh})
        Me.grvHocPhan.GridControl = Me.grcHocPhan
        Me.grvHocPhan.Name = "grvHocPhan"
        Me.grvHocPhan.OptionsSelection.MultiSelect = True
        Me.grvHocPhan.OptionsView.ShowAutoFilterRow = True
        Me.grvHocPhan.OptionsView.ShowGroupPanel = False
        '
        'colChon
        '
        Me.colChon.Caption = "Chọn"
        Me.colChon.FieldName = "Chon"
        Me.colChon.Name = "colChon"
        Me.colChon.Visible = True
        Me.colChon.VisibleIndex = 0
        Me.colChon.Width = 64
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Mã học phần"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 1
        Me.colKy_hieu.Width = 93
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 2
        Me.colTen_mon.Width = 357
        '
        'colTen_tieng_anh
        '
        Me.colTen_tieng_anh.Caption = "Tên tiếng Anh"
        Me.colTen_tieng_anh.FieldName = "Ten_tieng_anh"
        Me.colTen_tieng_anh.Name = "colTen_tieng_anh"
        Me.colTen_tieng_anh.Visible = True
        Me.colTen_tieng_anh.VisibleIndex = 3
        Me.colTen_tieng_anh.Width = 253
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(702, 541)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 169
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
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 18
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(609, 541)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(87, 30)
        Me.cmdSave.TabIndex = 170
        Me.cmdSave.Text = "Cập nhật"
        '
        'cmbLoaiChungChi
        '
        Me.cmbLoaiChungChi.FormattingEnabled = True
        Me.cmbLoaiChungChi.Location = New System.Drawing.Point(539, 11)
        Me.cmbLoaiChungChi.Name = "cmbLoaiChungChi"
        Me.cmbLoaiChungChi.Size = New System.Drawing.Size(163, 24)
        Me.cmbLoaiChungChi.TabIndex = 173
        '
        'txtTen_mh
        '
        Me.txtTen_mh.Location = New System.Drawing.Point(184, 10)
        Me.txtTen_mh.Name = "txtTen_mh"
        Me.txtTen_mh.Size = New System.Drawing.Size(234, 23)
        Me.txtTen_mh.TabIndex = 172
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(53, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 23)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "Lọc theo tên môn:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(431, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Loại chứng chỉ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_KhungChuongTrinhDaoTao_ChonHocPhan_ChungChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 574)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLoaiChungChi)
        Me.Controls.Add(Me.txtTen_mh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grcHocPhan)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_KhungChuongTrinhDaoTao_ChonHocPhan_ChungChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "CHUONG TRINH DAO TAO-CHON MON CHUNG CHI"
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grcHocPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colChon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_tieng_anh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmbLoaiChungChi As System.Windows.Forms.ComboBox
    Friend WithEvents txtTen_mh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
