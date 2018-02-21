<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_NhapDiem_TheoSoPhach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_NhapDiem_TheoSoPhach))
        Me.chkNot_show_all = New System.Windows.Forms.CheckBox
        Me.grdViewDiem = New System.Windows.Forms.DataGridView
        Me.trvPhongThi = New ESSMarkMan.TreeViewPhongThi
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_ngoai_ngu = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbKy_hieu = New System.Windows.Forms.ComboBox
        Me.cmdGhiChu = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkNot_show_all
        '
        Me.chkNot_show_all.BackColor = System.Drawing.Color.Transparent
        Me.chkNot_show_all.Checked = True
        Me.chkNot_show_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNot_show_all.Location = New System.Drawing.Point(268, 28)
        Me.chkNot_show_all.Name = "chkNot_show_all"
        Me.chkNot_show_all.Size = New System.Drawing.Size(514, 24)
        Me.chkNot_show_all.TabIndex = 106
        Me.chkNot_show_all.Text = "Khi nhập điểm thi từ lần 2 trở đi chỉ hiển thị những sinh viên có điểm thi <5"
        Me.chkNot_show_all.UseVisualStyleBackColor = False
        '
        'grdViewDiem
        '
        Me.grdViewDiem.AllowUserToAddRows = False
        Me.grdViewDiem.AllowUserToDeleteRows = False
        Me.grdViewDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDiem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDiem.Location = New System.Drawing.Point(266, 53)
        Me.grdViewDiem.Name = "grdViewDiem"
        Me.grdViewDiem.RowHeadersVisible = False
        Me.grdViewDiem.Size = New System.Drawing.Size(524, 471)
        Me.grdViewDiem.TabIndex = 107
        '
        'trvPhongThi
        '
        Me.trvPhongThi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvPhongThi.BackColor = System.Drawing.Color.Transparent
        Me.trvPhongThi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvPhongThi.Location = New System.Drawing.Point(0, 25)
        Me.trvPhongThi.Name = "trvPhongThi"
        Me.trvPhongThi.Size = New System.Drawing.Size(264, 545)
        Me.trvPhongThi.TabIndex = 108
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(598, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Ngoại ngữ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_ngoai_ngu
        '
        Me.cmbID_ngoai_ngu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_ngoai_ngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_ngoai_ngu.FormattingEnabled = True
        Me.cmbID_ngoai_ngu.Items.AddRange(New Object() {"Tiếng Anh", "Tiếng Nga", "Tiếng Pháp", "Tiếng Trung"})
        Me.cmbID_ngoai_ngu.Location = New System.Drawing.Point(678, 2)
        Me.cmbID_ngoai_ngu.Name = "cmbID_ngoai_ngu"
        Me.cmbID_ngoai_ngu.Size = New System.Drawing.Size(109, 24)
        Me.cmbID_ngoai_ngu.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(43, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Hiển thị sinh viên điểm:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKy_hieu
        '
        Me.cmbKy_hieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKy_hieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu.FormattingEnabled = True
        Me.cmbKy_hieu.Items.AddRange(New Object() {"Từ điểm D trở xuống", "Những sinh viên thiếu điểm TP", "Những sinh viên thiếu điểm Thi", "Những sinh viên không tính điểm thành phần vào TBCHP", "Những sinh viên bảo lưu"})
        Me.cmbKy_hieu.Location = New System.Drawing.Point(199, 2)
        Me.cmbKy_hieu.Name = "cmbKy_hieu"
        Me.cmbKy_hieu.Size = New System.Drawing.Size(367, 24)
        Me.cmbKy_hieu.TabIndex = 119
        '
        'cmdGhiChu
        '
        Me.cmdGhiChu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGhiChu.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGhiChu.Appearance.Options.UseFont = True
        Me.cmdGhiChu.ImageIndex = 8
        Me.cmdGhiChu.ImageList = Me.ImgMain
        Me.cmdGhiChu.Location = New System.Drawing.Point(260, 530)
        Me.cmdGhiChu.Name = "cmdGhiChu"
        Me.cmdGhiChu.Size = New System.Drawing.Size(152, 30)
        Me.cmdGhiChu.TabIndex = 180
        Me.cmdGhiChu.Text = "Ký hiệu ghi chú điểm"
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
        Me.ImgMain.Images.SetKeyName(22, "1665.ico")
        Me.ImgMain.Images.SetKeyName(23, "1669.ico")
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(542, 530)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(118, 30)
        Me.cmdExport.TabIndex = 181
        Me.cmdExport.Text = "Xuất Excel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ImageIndex = 4
        Me.cmdDelete.ImageList = Me.ImgMain
        Me.cmdDelete.Location = New System.Drawing.Point(136, 530)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(118, 30)
        Me.cmdDelete.TabIndex = 182
        Me.cmdDelete.Text = "Xóa tất cả"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(668, 530)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(118, 30)
        Me.cmdClose.TabIndex = 179
        Me.cmdClose.Text = "Thoát"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ImageIndex = 16
        Me.cmdPrint.ImageList = Me.ImgMain
        Me.cmdPrint.Location = New System.Drawing.Point(418, 530)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(118, 30)
        Me.cmdPrint.TabIndex = 178
        Me.cmdPrint.Text = "In DS Bảng điểm"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.ImageIndex = 10
        Me.cmdSave.ImageList = Me.ImgMain
        Me.cmdSave.Location = New System.Drawing.Point(12, 530)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 30)
        Me.cmdSave.TabIndex = 177
        Me.cmdSave.Text = "Lưu"
        '
        'frmESS_NhapDiemSoPhach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmdGhiChu)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbKy_hieu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_ngoai_ngu)
        Me.Controls.Add(Me.chkNot_show_all)
        Me.Controls.Add(Me.grdViewDiem)
        Me.Controls.Add(Me.trvPhongThi)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmESS_NhapDiemSoPhach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHAP DIEM THI THEO SO PHACH"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewDiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkNot_show_all As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewDiem As System.Windows.Forms.DataGridView
    Friend WithEvents trvPhongThi As ESSMarkMan.TreeViewPhongThi
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_ngoai_ngu As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbKy_hieu As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGhiChu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
