<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_KeThuaDiem_DiemNganh1View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_KeThuaDiem_DiemNganh1View))
        Me.grcChuaChon = New DevExpress.XtraGrid.GridControl
        Me.grvChuaChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridTen_mon = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grcDaChon = New DevExpress.XtraGrid.GridControl
        Me.grvDaChon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grcChuaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvChuaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcChuaChon
        '
        Me.grcChuaChon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcChuaChon.Location = New System.Drawing.Point(1, 1)
        Me.grcChuaChon.MainView = Me.grvChuaChon
        Me.grcChuaChon.Name = "grcChuaChon"
        Me.grcChuaChon.Size = New System.Drawing.Size(699, 231)
        Me.grcChuaChon.TabIndex = 223
        Me.grcChuaChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvChuaChon})
        '
        'grvChuaChon
        '
        Me.grvChuaChon.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvChuaChon.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvChuaChon.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvChuaChon.Appearance.Row.Options.UseFont = True
        Me.grvChuaChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridTen_mon, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn1})
        Me.grvChuaChon.GridControl = Me.grcChuaChon
        Me.grvChuaChon.Name = "grvChuaChon"
        Me.grvChuaChon.OptionsSelection.MultiSelect = True
        Me.grvChuaChon.OptionsView.ShowAutoFilterRow = True
        Me.grvChuaChon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Chọn"
        Me.GridColumn10.FieldName = "Chon"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        Me.GridColumn10.Width = 50
        '
        'GridTen_mon
        '
        Me.GridTen_mon.Caption = "Học phần"
        Me.GridTen_mon.FieldName = "Ten_mon"
        Me.GridTen_mon.Name = "GridTen_mon"
        Me.GridTen_mon.OptionsColumn.ReadOnly = True
        Me.GridTen_mon.Visible = True
        Me.GridTen_mon.VisibleIndex = 1
        Me.GridTen_mon.Width = 290
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Số tín chỉ"
        Me.GridColumn2.FieldName = "So_hoc_trinh"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 89
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Điểm số"
        Me.GridColumn3.FieldName = "TBCM"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 79
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Điểm chữ"
        Me.GridColumn4.FieldName = "Diem_chu"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 91
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ghi chú"
        Me.GridColumn1.FieldName = "Ghi_chu"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 79
        '
        'grcDaChon
        '
        Me.grcDaChon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDaChon.Location = New System.Drawing.Point(0, 264)
        Me.grcDaChon.MainView = Me.grvDaChon
        Me.grcDaChon.Name = "grcDaChon"
        Me.grcDaChon.Size = New System.Drawing.Size(699, 280)
        Me.grcDaChon.TabIndex = 224
        Me.grcDaChon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDaChon})
        '
        'grvDaChon
        '
        Me.grvDaChon.Appearance.HeaderPanel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDaChon.Appearance.HeaderPanel.Options.UseFont = True
        Me.grvDaChon.Appearance.Row.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grvDaChon.Appearance.Row.Options.UseFont = True
        Me.grvDaChon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.grvDaChon.GridControl = Me.grcDaChon
        Me.grvDaChon.Name = "grvDaChon"
        Me.grvDaChon.OptionsSelection.MultiSelect = True
        Me.grvDaChon.OptionsView.ShowAutoFilterRow = True
        Me.grvDaChon.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Chọn"
        Me.GridColumn11.FieldName = "Chon"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 50
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Học phần"
        Me.GridColumn5.FieldName = "Ten_mon"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 290
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Số tín chỉ"
        Me.GridColumn6.FieldName = "So_hoc_trinh"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 88
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Điểm số"
        Me.GridColumn7.FieldName = "TBCM"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 80
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Điểm chữ"
        Me.GridColumn8.FieldName = "Diem_chu"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 91
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ghi chú"
        Me.GridColumn9.FieldName = "Ghi_chu"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 79
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageIndex = 0
        Me.cmdAdd.Location = New System.Drawing.Point(544, 234)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(82, 30)
        Me.cmdAdd.TabIndex = 225
        Me.cmdAdd.Text = "Kế thừa"
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Appearance.Options.UseFont = True
        Me.cmdRemove.Image = CType(resources.GetObject("cmdRemove.Image"), System.Drawing.Image)
        Me.cmdRemove.ImageIndex = 4
        Me.cmdRemove.Location = New System.Drawing.Point(630, 234)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(67, 30)
        Me.cmdRemove.TabIndex = 226
        Me.cmdRemove.Text = "Xóa"
        '
        'frmESS_KeThuaDiem_DiemNganh1View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 542)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.grcDaChon)
        Me.Controls.Add(Me.grcChuaChon)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_KeThuaDiem_DiemNganh1View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách các đầu điểm Ngành 1 có thể kế thừa sang Ngành học 2"
        CType(Me.grcChuaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvChuaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDaChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grcChuaChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvChuaChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridTen_mon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grcDaChon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDaChon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
End Class
