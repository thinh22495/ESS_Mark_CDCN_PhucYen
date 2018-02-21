<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEDU_XetLenLop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEDU_XetLenLop))
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.trvLop = New ESSMarkMan.TreeViewLop
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.cmdPrint1 = New DevExpress.XtraBars.BarButtonItem
        Me.cmdPrint2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrintList = New DevExpress.XtraEditors.DropDownButton
        Me.cmdZ = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddQD = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach_DaChon = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach_DaChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Chon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTBCHT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.cmdNoiDung_CB = New DevExpress.XtraEditors.SimpleButton
        Me.optTheo_QuyChe = New System.Windows.Forms.CheckBox
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach_DaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach_DaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNam_hoc.Location = New System.Drawing.Point(641, 0)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(101, 24)
        Me.cmbNam_hoc.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Năm học xét:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Items.AddRange(New Object() {"01", "02", "03"})
        Me.cmbHoc_ky.Location = New System.Drawing.Point(494, 0)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(38, 24)
        Me.cmbHoc_ky.TabIndex = 117
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(412, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 23)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Học kỳ xét:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(-1, 4)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(262, 559)
        Me.trvLop.TabIndex = 100
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
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrint2)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'cmdPrint1
        '
        Me.cmdPrint1.Caption = "Danh sách sinh viên "
        Me.cmdPrint1.Id = 0
        Me.cmdPrint1.ImageIndex = 16
        Me.cmdPrint1.Name = "cmdPrint1"
        '
        'cmdPrint2
        '
        Me.cmdPrint2.Caption = "Tổng hợp danh sách"
        Me.cmdPrint2.Id = 1
        Me.cmdPrint2.ImageIndex = 16
        Me.cmdPrint2.Name = "cmdPrint2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImgMain
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrint1, Me.cmdPrint2})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1063, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 566)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1063, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 566)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1063, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 566)
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 4
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(968, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 30)
        Me.cmdClose.TabIndex = 165
        Me.cmdClose.Text = "Thoát"
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(872, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(91, 30)
        Me.cmdExport.TabIndex = 164
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdPrintList
        '
        Me.cmdPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintList.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintList.Appearance.Options.UseFont = True
        Me.cmdPrintList.DropDownControl = Me.PopupMenu1
        Me.cmdPrintList.ImageIndex = 16
        Me.cmdPrintList.ImageList = Me.ImgMain
        Me.cmdPrintList.Location = New System.Drawing.Point(750, 532)
        Me.cmdPrintList.Name = "cmdPrintList"
        Me.cmdPrintList.Size = New System.Drawing.Size(115, 30)
        Me.cmdPrintList.TabIndex = 163
        Me.cmdPrintList.Text = "In danh sách"
        '
        'cmdZ
        '
        Me.cmdZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdZ.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZ.Appearance.Options.UseFont = True
        Me.cmdZ.ImageIndex = 15
        Me.cmdZ.ImageList = Me.ImgMain
        Me.cmdZ.Location = New System.Drawing.Point(554, 532)
        Me.cmdZ.Name = "cmdZ"
        Me.cmdZ.Size = New System.Drawing.Size(91, 30)
        Me.cmdZ.TabIndex = 164
        Me.cmdZ.Text = "Tổng hợp"
        '
        'cmdAddQD
        '
        Me.cmdAddQD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddQD.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddQD.Appearance.Options.UseFont = True
        Me.cmdAddQD.ImageIndex = 0
        Me.cmdAddQD.ImageList = Me.ImgMain
        Me.cmdAddQD.Location = New System.Drawing.Point(651, 532)
        Me.cmdAddQD.Name = "cmdAddQD"
        Me.cmdAddQD.Size = New System.Drawing.Size(91, 30)
        Me.cmdAddQD.TabIndex = 164
        Me.cmdAddQD.Text = "Nhập QĐ"
        '
        'grcDanhSach_DaChon
        '
        Me.grcDanhSach_DaChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach_DaChon.Location = New System.Drawing.Point(261, 25)
        Me.grcDanhSach_DaChon.MainView = Me.grvDanhSach_DaChon
        Me.grcDanhSach_DaChon.Name = "grcDanhSach_DaChon"
        Me.grcDanhSach_DaChon.Size = New System.Drawing.Size(798, 501)
        Me.grcDanhSach_DaChon.TabIndex = 170
        Me.grcDanhSach_DaChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach_DaChon})
        '
        'grvDanhSach_DaChon
        '
        Me.grvDanhSach_DaChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Chon2, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.colTBCHT, Me.GridColumn10, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.grvDanhSach_DaChon.GridControl = Me.grcDanhSach_DaChon
        Me.grvDanhSach_DaChon.Name = "grvDanhSach_DaChon"
        Me.grvDanhSach_DaChon.OptionsSelection.MultiSelect = True
        Me.grvDanhSach_DaChon.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach_DaChon.OptionsView.ShowViewCaption = True
        Me.grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN THUỘC CÁNH BÁO"
        '
        'Chon2
        '
        Me.Chon2.Caption = "Chọn"
        Me.Chon2.FieldName = "Chon"
        Me.Chon2.Name = "Chon2"
        Me.Chon2.Visible = True
        Me.Chon2.VisibleIndex = 0
        Me.Chon2.Width = 47
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mã SV"
        Me.GridColumn1.FieldName = "Ma_sv"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 35
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Họ tên"
        Me.GridColumn2.FieldName = "Ho_ten"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 55
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ngày sinh"
        Me.GridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "Ngay_sinh"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 35
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tên lớp"
        Me.GridColumn4.FieldName = "Ten_lop"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 43
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Số TCTL"
        Me.GridColumn5.FieldName = "So_TCTL"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 73
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "TBCTL"
        Me.GridColumn6.FieldName = "TBCTL"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 55
        '
        'colTBCHT
        '
        Me.colTBCHT.Caption = "TBCHT"
        Me.colTBCHT.FieldName = "TBCHT"
        Me.colTBCHT.Name = "colTBCHT"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Năm đào tạo"
        Me.GridColumn10.FieldName = "XepHang_Nam_DaoTao"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 88
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Số TCHT"
        Me.GridColumn7.FieldName = "So_TCHT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        Me.GridColumn7.Width = 73
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "TBCHT kỳ"
        Me.GridColumn8.FieldName = "TBCHT_Ky"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        Me.GridColumn8.Width = 92
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Lý do"
        Me.GridColumn9.FieldName = "Ly_do"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 10
        Me.GridColumn9.Width = 93
        '
        'optAll
        '
        Me.optAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(292, 0)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(100, 24)
        Me.optAll.TabIndex = 173
        Me.optAll.Text = "Chọn tất cả "
        Me.optAll.UseVisualStyleBackColor = False
        '
        'cmdNoiDung_CB
        '
        Me.cmdNoiDung_CB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNoiDung_CB.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNoiDung_CB.Appearance.Options.UseFont = True
        Me.cmdNoiDung_CB.ImageIndex = 10
        Me.cmdNoiDung_CB.ImageList = Me.ImgMain
        Me.cmdNoiDung_CB.Location = New System.Drawing.Point(377, 532)
        Me.cmdNoiDung_CB.Name = "cmdNoiDung_CB"
        Me.cmdNoiDung_CB.Size = New System.Drawing.Size(171, 30)
        Me.cmdNoiDung_CB.TabIndex = 181
        Me.cmdNoiDung_CB.Text = "Nhập nội dung cảnh báo"
        Me.cmdNoiDung_CB.Visible = False
        '
        'optTheo_QuyChe
        '
        Me.optTheo_QuyChe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optTheo_QuyChe.BackColor = System.Drawing.Color.Transparent
        Me.optTheo_QuyChe.Checked = True
        Me.optTheo_QuyChe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optTheo_QuyChe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTheo_QuyChe.ForeColor = System.Drawing.Color.DarkRed
        Me.optTheo_QuyChe.Location = New System.Drawing.Point(839, 0)
        Me.optTheo_QuyChe.Name = "optTheo_QuyChe"
        Me.optTheo_QuyChe.Size = New System.Drawing.Size(212, 24)
        Me.optTheo_QuyChe.TabIndex = 186
        Me.optTheo_QuyChe.Text = "Xét theo quy chế mới"
        Me.optTheo_QuyChe.UseVisualStyleBackColor = False
        '
        'frmEDU_XetLenLop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1063, 566)
        Me.Controls.Add(Me.optTheo_QuyChe)
        Me.Controls.Add(Me.cmdNoiDung_CB)
        Me.Controls.Add(Me.grcDanhSach_DaChon)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAddQD)
        Me.Controls.Add(Me.cmdZ)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrintList)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmEDU_XetLenLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xét lên lớp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach_DaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach_DaChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvLop As ESSMarkMan.TreeViewLop
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents colTong_So_hoc_trinh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents cmdPrint1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrint2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintList As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents cmdZ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddQD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grvDanhSach_DaChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents Chon2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents grcDanhSach_DaChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdNoiDung_CB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents optTheo_QuyChe As System.Windows.Forms.CheckBox
    Friend WithEvents colTBCHT As DevExpress.XtraGrid.Columns.GridColumn
End Class
