<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KhungChuongTrinhDaoTao_HocPhanRangBuoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KhungChuongTrinhDaoTao_HocPhanRangBuoc))
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.cmbLoai_rang_buoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbKy_hieu = New System.Windows.Forms.ComboBox
        Me.grcHocPhan = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcHocPhanRB = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhanRB = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKy_hieu1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_rang_buoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_mon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.imgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhanRB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhanRB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_mon
        '
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbID_mon.ItemHeight = 16
        Me.cmbID_mon.Location = New System.Drawing.Point(254, 307)
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(167, 24)
        Me.cmbID_mon.TabIndex = 31
        '
        'cmbLoai_rang_buoc
        '
        Me.cmbLoai_rang_buoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_rang_buoc.Location = New System.Drawing.Point(530, 307)
        Me.cmbLoai_rang_buoc.Name = "cmbLoai_rang_buoc"
        Me.cmbLoai_rang_buoc.Size = New System.Drawing.Size(116, 24)
        Me.cmbLoai_rang_buoc.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(424, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Loại ràng buộc:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(185, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Học phần:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Ký hiệu:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKy_hieu
        '
        Me.cmbKy_hieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbKy_hieu.ItemHeight = 16
        Me.cmbKy_hieu.Location = New System.Drawing.Point(67, 305)
        Me.cmbKy_hieu.Name = "cmbKy_hieu"
        Me.cmbKy_hieu.Size = New System.Drawing.Size(112, 24)
        Me.cmbKy_hieu.TabIndex = 31
        '
        'grcHocPhan
        '
        Me.grcHocPhan.Location = New System.Drawing.Point(1, -1)
        Me.grcHocPhan.MainView = Me.grvHocPhan
        Me.grcHocPhan.Name = "grcHocPhan"
        Me.grcHocPhan.Size = New System.Drawing.Size(791, 299)
        Me.grcHocPhan.TabIndex = 39
        Me.grcHocPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhan})
        '
        'grvHocPhan
        '
        Me.grvHocPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu, Me.colTen_mon})
        Me.grvHocPhan.GridControl = Me.grcHocPhan
        Me.grvHocPhan.Name = "grvHocPhan"
        Me.grvHocPhan.OptionsView.ShowAutoFilterRow = True
        Me.grvHocPhan.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu
        '
        Me.colKy_hieu.Caption = "Mã học phần"
        Me.colKy_hieu.FieldName = "Ky_hieu"
        Me.colKy_hieu.Name = "colKy_hieu"
        Me.colKy_hieu.OptionsColumn.ReadOnly = True
        Me.colKy_hieu.Visible = True
        Me.colKy_hieu.VisibleIndex = 0
        Me.colKy_hieu.Width = 124
        '
        'colTen_mon
        '
        Me.colTen_mon.Caption = "Tên học phần"
        Me.colTen_mon.FieldName = "Ten_mon"
        Me.colTen_mon.Name = "colTen_mon"
        Me.colTen_mon.OptionsColumn.ReadOnly = True
        Me.colTen_mon.Visible = True
        Me.colTen_mon.VisibleIndex = 1
        Me.colTen_mon.Width = 645
        '
        'grcHocPhanRB
        '
        Me.grcHocPhanRB.Location = New System.Drawing.Point(3, 335)
        Me.grcHocPhanRB.MainView = Me.grvHocPhanRB
        Me.grcHocPhanRB.Name = "grcHocPhanRB"
        Me.grcHocPhanRB.Size = New System.Drawing.Size(791, 197)
        Me.grcHocPhanRB.TabIndex = 44
        Me.grcHocPhanRB.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhanRB})
        '
        'grvHocPhanRB
        '
        Me.grvHocPhanRB.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKy_hieu1, Me.colTen_mon1, Me.colTen_rang_buoc, Me.colTen_mon2})
        Me.grvHocPhanRB.GridControl = Me.grcHocPhanRB
        Me.grvHocPhanRB.Name = "grvHocPhanRB"
        Me.grvHocPhanRB.OptionsView.ShowAutoFilterRow = True
        Me.grvHocPhanRB.OptionsView.ShowGroupPanel = False
        '
        'colKy_hieu1
        '
        Me.colKy_hieu1.Caption = "Mã học phần"
        Me.colKy_hieu1.FieldName = "Ky_hieu1"
        Me.colKy_hieu1.Name = "colKy_hieu1"
        Me.colKy_hieu1.OptionsColumn.ReadOnly = True
        Me.colKy_hieu1.Visible = True
        Me.colKy_hieu1.VisibleIndex = 0
        Me.colKy_hieu1.Width = 122
        '
        'colTen_mon1
        '
        Me.colTen_mon1.Caption = "Tên học phần"
        Me.colTen_mon1.FieldName = "Ten_mon1"
        Me.colTen_mon1.Name = "colTen_mon1"
        Me.colTen_mon1.OptionsColumn.ReadOnly = True
        Me.colTen_mon1.Visible = True
        Me.colTen_mon1.VisibleIndex = 1
        Me.colTen_mon1.Width = 263
        '
        'colTen_rang_buoc
        '
        Me.colTen_rang_buoc.Caption = "Loại ràng buộc"
        Me.colTen_rang_buoc.FieldName = "Ten_rang_buoc"
        Me.colTen_rang_buoc.Name = "colTen_rang_buoc"
        Me.colTen_rang_buoc.OptionsColumn.ReadOnly = True
        Me.colTen_rang_buoc.Visible = True
        Me.colTen_rang_buoc.VisibleIndex = 2
        Me.colTen_rang_buoc.Width = 111
        '
        'colTen_mon2
        '
        Me.colTen_mon2.Caption = "Tên học phần ràng buôc"
        Me.colTen_mon2.FieldName = "Ten_mon2"
        Me.colTen_mon2.Name = "colTen_mon2"
        Me.colTen_mon2.OptionsColumn.ReadOnly = True
        Me.colTen_mon2.Visible = True
        Me.colTen_mon2.VisibleIndex = 3
        Me.colTen_mon2.Width = 273
        '
        'imgMain
        '
        Me.imgMain.ImageStream = CType(resources.GetObject("imgMain.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imgMain.Images.SetKeyName(0, "Add.png")
        Me.imgMain.Images.SetKeyName(1, "Back.png")
        Me.imgMain.Images.SetKeyName(2, "Bar Chart.png")
        Me.imgMain.Images.SetKeyName(3, "Comment.png")
        Me.imgMain.Images.SetKeyName(4, "Delete.png")
        Me.imgMain.Images.SetKeyName(5, "Email.png")
        Me.imgMain.Images.SetKeyName(6, "excel.ico")
        Me.imgMain.Images.SetKeyName(7, "Exit.png")
        Me.imgMain.Images.SetKeyName(8, "Info.png")
        Me.imgMain.Images.SetKeyName(9, "Line Chart.png")
        Me.imgMain.Images.SetKeyName(10, "Load.png")
        Me.imgMain.Images.SetKeyName(11, "Loading.png")
        Me.imgMain.Images.SetKeyName(12, "Modify.png")
        Me.imgMain.Images.SetKeyName(13, "Next.png")
        Me.imgMain.Images.SetKeyName(14, "Picture.png")
        Me.imgMain.Images.SetKeyName(15, "Pie Chart.png")
        Me.imgMain.Images.SetKeyName(16, "Print.png")
        Me.imgMain.Images.SetKeyName(17, "Profile.png")
        Me.imgMain.Images.SetKeyName(18, "Save.png")
        Me.imgMain.Images.SetKeyName(19, "Search.png")
        Me.imgMain.Images.SetKeyName(20, "Warning.png")
        Me.imgMain.Images.SetKeyName(21, "word.ico")
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.imgMain
        Me.cmdClose.Location = New System.Drawing.Point(704, 535)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 30)
        Me.cmdClose.TabIndex = 176
        Me.cmdClose.Text = "Thoát"
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.ImageList = Me.imgMain
        Me.cmdAdd.Location = New System.Drawing.Point(651, 304)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(67, 30)
        Me.cmdAdd.TabIndex = 174
        Me.cmdAdd.Text = "Thêm"
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Appearance.Options.UseFont = True
        Me.cmdRemove.ImageIndex = 4
        Me.cmdRemove.ImageList = Me.imgMain
        Me.cmdRemove.Location = New System.Drawing.Point(722, 304)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(67, 30)
        Me.cmdRemove.TabIndex = 175
        Me.cmdRemove.Text = "Xóa"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.imgMain
        Me.cmdPrint.Location = New System.Drawing.Point(592, 535)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(106, 30)
        Me.cmdPrint.TabIndex = 176
        Me.cmdPrint.Text = "In báo cáo"
        '
        'frmESS_ChuongTrinhDaoTaoRangBuocMonHoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.grcHocPhanRB)
        Me.Controls.Add(Me.grcHocPhan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbKy_hieu)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.cmbLoai_rang_buoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmESS_ChuongTrinhDaoTaoRangBuocMonHoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chương trình đào tạo - Ràng buộc Học phần"
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhanRB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhanRB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoai_rang_buoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKy_hieu As System.Windows.Forms.ComboBox
    Friend WithEvents grcHocPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcHocPhanRB As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhanRB As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKy_hieu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_rang_buoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_mon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
End Class
