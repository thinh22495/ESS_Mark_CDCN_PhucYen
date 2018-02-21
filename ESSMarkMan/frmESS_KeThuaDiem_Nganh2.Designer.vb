<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KeThuaDiem_Nganh2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TreeViewChuyenNganh_Nganh21 = New ESSMarkMan.TreeViewChuyenNganh_Nganh2
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMa_sv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHo_ten = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNgay_sinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTen_lop = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcHocPhan = New DevExpress.XtraGrid.GridControl
        Me.grvHocPhan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdKeThua_Nganh1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdKeThuaDiem_HP_TuongDuong = New DevExpress.XtraEditors.SimpleButton
        Me.lblSo_Sv = New System.Windows.Forms.Label
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeViewChuyenNganh_Nganh21
        '
        Me.TreeViewChuyenNganh_Nganh21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeViewChuyenNganh_Nganh21.dtLop = Nothing
        Me.TreeViewChuyenNganh_Nganh21.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TreeViewChuyenNganh_Nganh21.Location = New System.Drawing.Point(-2, 1)
        Me.TreeViewChuyenNganh_Nganh21.Name = "TreeViewChuyenNganh_Nganh21"
        Me.TreeViewChuyenNganh_Nganh21.Size = New System.Drawing.Size(266, 548)
        Me.TreeViewChuyenNganh_Nganh21.TabIndex = 0
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(269, 6)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(594, 186)
        Me.grcDanhSach.TabIndex = 221
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDanhSach.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvDanhSach.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDanhSach.Appearance.Row.Options.UseFont = True
        Me.grvDanhSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMa_sv, Me.colHo_ten, Me.colNgay_sinh, Me.colTen_lop})
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowAutoFilterRow = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        '
        'colMa_sv
        '
        Me.colMa_sv.Caption = "Mã SV"
        Me.colMa_sv.FieldName = "Ma_sv"
        Me.colMa_sv.Name = "colMa_sv"
        Me.colMa_sv.OptionsColumn.ReadOnly = True
        Me.colMa_sv.Visible = True
        Me.colMa_sv.VisibleIndex = 0
        Me.colMa_sv.Width = 100
        '
        'colHo_ten
        '
        Me.colHo_ten.Caption = "Họ tên"
        Me.colHo_ten.FieldName = "Ho_ten"
        Me.colHo_ten.Name = "colHo_ten"
        Me.colHo_ten.OptionsColumn.ReadOnly = True
        Me.colHo_ten.Visible = True
        Me.colHo_ten.VisibleIndex = 1
        Me.colHo_ten.Width = 200
        '
        'colNgay_sinh
        '
        Me.colNgay_sinh.Caption = "Ngày sinh"
        Me.colNgay_sinh.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colNgay_sinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNgay_sinh.FieldName = "Ngay_sinh"
        Me.colNgay_sinh.Name = "colNgay_sinh"
        Me.colNgay_sinh.Visible = True
        Me.colNgay_sinh.VisibleIndex = 2
        Me.colNgay_sinh.Width = 100
        '
        'colTen_lop
        '
        Me.colTen_lop.Caption = "Tên lớp ngành 1"
        Me.colTen_lop.FieldName = "Ten_lop"
        Me.colTen_lop.Name = "colTen_lop"
        Me.colTen_lop.Visible = True
        Me.colTen_lop.VisibleIndex = 3
        Me.colTen_lop.Width = 112
        '
        'grcHocPhan
        '
        Me.grcHocPhan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcHocPhan.Location = New System.Drawing.Point(269, 221)
        Me.grcHocPhan.MainView = Me.grvHocPhan
        Me.grcHocPhan.Name = "grcHocPhan"
        Me.grcHocPhan.Size = New System.Drawing.Size(594, 321)
        Me.grcHocPhan.TabIndex = 222
        Me.grcHocPhan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvHocPhan})
        '
        'grvHocPhan
        '
        Me.grvHocPhan.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvHocPhan.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvHocPhan.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvHocPhan.Appearance.Row.Options.UseFont = True
        Me.grvHocPhan.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridTen_mon, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn1})
        Me.grvHocPhan.GridControl = Me.grcHocPhan
        Me.grvHocPhan.Name = "grvHocPhan"
        Me.grvHocPhan.OptionsSelection.MultiSelect = True
        Me.grvHocPhan.OptionsView.ShowAutoFilterRow = True
        Me.grvHocPhan.OptionsView.ShowGroupPanel = False
        '
        'GridTen_mon
        '
        Me.GridTen_mon.Caption = "Học phần"
        Me.GridTen_mon.FieldName = "Ten_mon"
        Me.GridTen_mon.Name = "GridTen_mon"
        Me.GridTen_mon.OptionsColumn.ReadOnly = True
        Me.GridTen_mon.Visible = True
        Me.GridTen_mon.VisibleIndex = 0
        Me.GridTen_mon.Width = 230
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Số tín chỉ"
        Me.GridColumn2.FieldName = "So_hoc_trinh"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 71
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Điểm số"
        Me.GridColumn3.FieldName = "TBCM"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Điểm chữ"
        Me.GridColumn4.FieldName = "Diem_chu"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 112
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ghi chú"
        Me.GridColumn1.FieldName = "Ghi_chu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 58
        '
        'cmdKeThua_Nganh1
        '
        Me.cmdKeThua_Nganh1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdKeThua_Nganh1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeThua_Nganh1.Appearance.Options.UseFont = True
        Me.cmdKeThua_Nganh1.ImageIndex = 0
        Me.cmdKeThua_Nganh1.Location = New System.Drawing.Point(270, 193)
        Me.cmdKeThua_Nganh1.Name = "cmdKeThua_Nganh1"
        Me.cmdKeThua_Nganh1.Size = New System.Drawing.Size(203, 30)
        Me.cmdKeThua_Nganh1.TabIndex = 223
        Me.cmdKeThua_Nganh1.Text = "Thực hiện kế thừa điểm từ ngành 1"
        '
        'cmdKeThuaDiem_HP_TuongDuong
        '
        Me.cmdKeThuaDiem_HP_TuongDuong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdKeThuaDiem_HP_TuongDuong.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKeThuaDiem_HP_TuongDuong.Appearance.Options.UseFont = True
        Me.cmdKeThuaDiem_HP_TuongDuong.ImageIndex = 0
        Me.cmdKeThuaDiem_HP_TuongDuong.Location = New System.Drawing.Point(476, 193)
        Me.cmdKeThuaDiem_HP_TuongDuong.Name = "cmdKeThuaDiem_HP_TuongDuong"
        Me.cmdKeThuaDiem_HP_TuongDuong.Size = New System.Drawing.Size(283, 30)
        Me.cmdKeThuaDiem_HP_TuongDuong.TabIndex = 224
        Me.cmdKeThuaDiem_HP_TuongDuong.Text = "Thực hiện kế thừa điểm HP tương đương từ ngành 1"
        '
        'lblSo_Sv
        '
        Me.lblSo_Sv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_Sv.AutoSize = True
        Me.lblSo_Sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_Sv.Location = New System.Drawing.Point(774, 200)
        Me.lblSo_Sv.Name = "lblSo_Sv"
        Me.lblSo_Sv.Size = New System.Drawing.Size(80, 16)
        Me.lblSo_Sv.TabIndex = 225
        Me.lblSo_Sv.Text = "Số sinh viên: 0"
        Me.lblSo_Sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmESS_KeThuaDiem_Nganh2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 542)
        Me.Controls.Add(Me.lblSo_Sv)
        Me.Controls.Add(Me.cmdKeThuaDiem_HP_TuongDuong)
        Me.Controls.Add(Me.cmdKeThua_Nganh1)
        Me.Controls.Add(Me.grcHocPhan)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.TreeViewChuyenNganh_Nganh21)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_KeThuaDiem_Nganh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kế thừa dữ liệu ngành chinh sang ngành học thứ 2"
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvHocPhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeViewChuyenNganh_Nganh21 As ESSMarkMan.TreeViewChuyenNganh_Nganh2
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMa_sv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHo_ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNgay_sinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTen_lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcHocPhan As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvHocPhan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdKeThua_Nganh1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdKeThuaDiem_HP_TuongDuong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSo_Sv As System.Windows.Forms.Label
End Class
