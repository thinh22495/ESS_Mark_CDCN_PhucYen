<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ToChucThi_Phong
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_ToChucThi_Phong))
        Me.cmbID_nha = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.So_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_phong = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_phong_main = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewPhongThi = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSuc_chua = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSV_Con = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkCheckSoSinhVien = New System.Windows.Forms.CheckBox
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdChon = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grdViewPhongThi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbID_nha
        '
        Me.cmbID_nha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_nha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nha.Location = New System.Drawing.Point(64, 4)
        Me.cmbID_nha.Name = "cmbID_nha"
        Me.cmbID_nha.Size = New System.Drawing.Size(185, 24)
        Me.cmbID_nha.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Toà nhà:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'So_sv
        '
        Me.So_sv.DataPropertyName = "So_sv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_sv.DefaultCellStyle = DataGridViewCellStyle3
        Me.So_sv.HeaderText = "Số sinh viên/phòng"
        Me.So_sv.Name = "So_sv"
        Me.So_sv.Width = 160
        '
        'Ten_phong
        '
        Me.Ten_phong.DataPropertyName = "Ten_phong"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_phong.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ten_phong.HeaderText = "Phòng thi"
        Me.Ten_phong.Name = "Ten_phong"
        Me.Ten_phong.ReadOnly = True
        Me.Ten_phong.Width = 150
        '
        'Ten_phong_main
        '
        Me.Ten_phong_main.HeaderText = "Tên phòng main"
        Me.Ten_phong_main.Name = "Ten_phong_main"
        '
        'grdViewPhongThi
        '
        Me.grdViewPhongThi.AllowUserToAddRows = False
        Me.grdViewPhongThi.AllowUserToDeleteRows = False
        Me.grdViewPhongThi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewPhongThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewPhongThi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_phong_main, Me.Ten_phong, Me.So_sv})
        Me.grdViewPhongThi.Location = New System.Drawing.Point(0, 64)
        Me.grdViewPhongThi.Name = "grdViewPhongThi"
        Me.grdViewPhongThi.RowHeadersVisible = False
        Me.grdViewPhongThi.Size = New System.Drawing.Size(572, 314)
        Me.grdViewPhongThi.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(335, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Đã tổ chức:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSuc_chua
        '
        Me.lblSuc_chua.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSuc_chua.BackColor = System.Drawing.Color.Transparent
        Me.lblSuc_chua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuc_chua.Location = New System.Drawing.Point(419, 6)
        Me.lblSuc_chua.Name = "lblSuc_chua"
        Me.lblSuc_chua.Size = New System.Drawing.Size(42, 20)
        Me.lblSuc_chua.TabIndex = 91
        Me.lblSuc_chua.Text = "0"
        Me.lblSuc_chua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(300, 6)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(38, 20)
        Me.lblSo_sv.TabIndex = 93
        Me.lblSo_sv.Text = "0"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(253, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Số sv:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSV_Con
        '
        Me.lblSV_Con.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSV_Con.BackColor = System.Drawing.Color.Transparent
        Me.lblSV_Con.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSV_Con.Location = New System.Drawing.Point(517, 5)
        Me.lblSV_Con.Name = "lblSV_Con"
        Me.lblSV_Con.Size = New System.Drawing.Size(55, 20)
        Me.lblSV_Con.TabIndex = 95
        Me.lblSV_Con.Text = "0"
        Me.lblSV_Con.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(446, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Còn lại:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCheckSoSinhVien
        '
        Me.chkCheckSoSinhVien.AutoSize = True
        Me.chkCheckSoSinhVien.Location = New System.Drawing.Point(12, 38)
        Me.chkCheckSoSinhVien.Name = "chkCheckSoSinhVien"
        Me.chkCheckSoSinhVien.Size = New System.Drawing.Size(307, 20)
        Me.chkCheckSoSinhVien.TabIndex = 96
        Me.chkCheckSoSinhVien.Text = "Kiểm tra số sinh viên với sức chứa phòng thi"
        Me.chkCheckSoSinhVien.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.ImageIndex = 7
        Me.cmdClose.ImageList = Me.ImgMain
        Me.cmdClose.Location = New System.Drawing.Point(461, 384)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(107, 31)
        Me.cmdClose.TabIndex = 178
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
        'cmdChon
        '
        Me.cmdChon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChon.ImageIndex = 0
        Me.cmdChon.ImageList = Me.ImgMain
        Me.cmdChon.Location = New System.Drawing.Point(350, 384)
        Me.cmdChon.Name = "cmdChon"
        Me.cmdChon.Size = New System.Drawing.Size(107, 31)
        Me.cmdChon.TabIndex = 177
        Me.cmdChon.Text = "Chọn "
        '
        'frmESS_ToChucThiPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 419)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdChon)
        Me.Controls.Add(Me.chkCheckSoSinhVien)
        Me.Controls.Add(Me.lblSV_Con)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSuc_chua)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbID_nha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdViewPhongThi)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESS_ToChucThiPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "0"
        Me.Text = "PHÂN PHÒNG THI"
        CType(Me.grdViewPhongThi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbID_nha As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents So_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_phong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_phong_main As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdViewPhongThi As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSuc_chua As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSV_Con As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkCheckSoSinhVien As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdChon As DevExpress.XtraEditors.SimpleButton
End Class
