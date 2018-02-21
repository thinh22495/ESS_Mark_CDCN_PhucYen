<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTongHopThuKhac
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblSo_SV = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.grdDanhSach = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thieu_thua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Label25 = New System.Windows.Forms.Label
        Me.C1Report1 = New C1.Win.C1Report.C1Report
        Me.grdDanhSach_View = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdPrint_TongHop_HP = New System.Windows.Forms.Button
        Me.cmdIn_No_HP = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnThoat = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.trvLop = New ESSMarkMan.TreeViewLop
        Me.btnView_TT_HP = New System.Windows.Forms.Button
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDanhSach_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSo_SV
        '
        Me.lblSo_SV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_SV.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_SV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_SV.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_SV.Location = New System.Drawing.Point(711, 31)
        Me.lblSo_SV.Name = "lblSo_SV"
        Me.lblSo_SV.Size = New System.Drawing.Size(69, 20)
        Me.lblSo_SV.TabIndex = 148
        Me.lblSo_SV.Text = "0"
        Me.lblSo_SV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(609, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 20)
        Me.Label20.TabIndex = 147
        Me.Label20.Text = "Tổng số SV:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdDanhSach
        '
        Me.grdDanhSach.AllowUserToAddRows = False
        Me.grdDanhSach.AllowUserToDeleteRows = False
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.grdDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Ten_lop, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Phai_nop, Me.Da_nop, Me.Thieu_thua})
        Me.grdDanhSach.Location = New System.Drawing.Point(264, 227)
        Me.grdDanhSach.Name = "grdDanhSach"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.grdDanhSach.RowHeadersVisible = False
        Me.grdDanhSach.Size = New System.Drawing.Size(528, 217)
        Me.grdDanhSach.TabIndex = 149
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã sv"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 130
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "So_tien"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "###,###"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn3.HeaderText = "Số tiền phải nộp"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "So_tien_mien_giam"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "###,###"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn4.HeaderText = "Miễn giảm"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Phai_nop
        '
        Me.Phai_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "###,###"
        Me.Phai_nop.DefaultCellStyle = DataGridViewCellStyle18
        Me.Phai_nop.HeaderText = "Phải nộp"
        Me.Phai_nop.MinimumWidth = 120
        Me.Phai_nop.Name = "Phai_nop"
        Me.Phai_nop.ReadOnly = True
        '
        'Da_nop
        '
        Me.Da_nop.DataPropertyName = "So_tien_da_nop"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "###,###"
        Me.Da_nop.DefaultCellStyle = DataGridViewCellStyle19
        Me.Da_nop.HeaderText = "Đã nộp"
        Me.Da_nop.MinimumWidth = 120
        Me.Da_nop.Name = "Da_nop"
        Me.Da_nop.ReadOnly = True
        '
        'Thieu_thua
        '
        Me.Thieu_thua.DataPropertyName = "Thieu_thua"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "###,###"
        Me.Thieu_thua.DefaultCellStyle = DataGridViewCellStyle20
        Me.Thieu_thua.HeaderText = "Thiếu thừa"
        Me.Thieu_thua.MinimumWidth = 120
        Me.Thieu_thua.Name = "Thieu_thua"
        Me.Thieu_thua.ReadOnly = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(590, 1)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(202, 23)
        Me.ProgressBar.TabIndex = 181
        Me.ProgressBar.Visible = False
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(232, 1)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(354, 22)
        Me.Label25.TabIndex = 231
        Me.Label25.Text = "TỔNG HỢP THU HỌC PHÍ THEO KỲ"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1Report1
        '
        Me.C1Report1.ReportName = "C1Report1"
        '
        'grdDanhSach_View
        '
        Me.grdDanhSach_View.AllowUserToAddRows = False
        Me.grdDanhSach_View.AllowUserToDeleteRows = False
        Me.grdDanhSach_View.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDanhSach_View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSach_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSach_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.grdDanhSach_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSach_View.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.grdDanhSach_View.Location = New System.Drawing.Point(260, 54)
        Me.grdDanhSach_View.Name = "grdDanhSach_View"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSach_View.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.grdDanhSach_View.RowHeadersVisible = False
        Me.grdDanhSach_View.Size = New System.Drawing.Size(535, 390)
        Me.grdDanhSach_View.TabIndex = 235
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mã sv"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Tien_Thua"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "###,###"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tiền thừa"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Tien_Thieu"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "###,###"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tiền thiếu"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'cmdPrint_TongHop_HP
        '
        Me.cmdPrint_TongHop_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint_TongHop_HP.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint_TongHop_HP.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdPrint_TongHop_HP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint_TongHop_HP.Location = New System.Drawing.Point(183, 540)
        Me.cmdPrint_TongHop_HP.Name = "cmdPrint_TongHop_HP"
        Me.cmdPrint_TongHop_HP.Size = New System.Drawing.Size(300, 28)
        Me.cmdPrint_TongHop_HP.TabIndex = 237
        Me.cmdPrint_TongHop_HP.Text = "Tổng hợp nợ, thừa HP Hệ, Khóa, Chuyên ngành"
        Me.cmdPrint_TongHop_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint_TongHop_HP.UseVisualStyleBackColor = True
        '
        'cmdIn_No_HP
        '
        Me.cmdIn_No_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdIn_No_HP.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIn_No_HP.Image = Global.ESSMarkMan.My.Resources.Resources.Print
        Me.cmdIn_No_HP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdIn_No_HP.Location = New System.Drawing.Point(593, 540)
        Me.cmdIn_No_HP.Name = "cmdIn_No_HP"
        Me.cmdIn_No_HP.Size = New System.Drawing.Size(122, 28)
        Me.cmdIn_No_HP.TabIndex = 236
        Me.cmdIn_No_HP.Text = "In nợ, thừa HP"
        Me.cmdIn_No_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdIn_No_HP.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ESSMarkMan.My.Resources.Resources.Search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(484, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 28)
        Me.Button1.TabIndex = 234
        Me.Button1.Text = "Tổng hợp HP"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = Global.ESSMarkMan.My.Resources.Resources.Delete
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(717, 540)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 28)
        Me.btnThoat.TabIndex = 221
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(261, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 238
        Me.Label1.Text = "Hướng dẫn người dùng:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(294, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(486, 20)
        Me.Label2.TabIndex = 239
        Me.Label2.Text = "- Để In nợ, thừa HP người dùng phải Tổng hợp HP trước"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(294, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(486, 33)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "- Để Tổng hợp nợ, thừa HP Hệ, Khóa, Chuyên ngành: người dùng chọn chức năng này v" & _
            "à Thống kê theo hệ, khóa học để có được chi tiết Nợ của từng lớp"
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(-2, 30)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(264, 508)
        Me.trvLop.TabIndex = 129
        '
        'btnView_TT_HP
        '
        Me.btnView_TT_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView_TT_HP.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView_TT_HP.Image = Global.ESSMarkMan.My.Resources.Resources.RangBuocMonHoc
        Me.btnView_TT_HP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView_TT_HP.Location = New System.Drawing.Point(12, 540)
        Me.btnView_TT_HP.Name = "btnView_TT_HP"
        Me.btnView_TT_HP.Size = New System.Drawing.Size(165, 28)
        Me.btnView_TT_HP.TabIndex = 241
        Me.btnView_TT_HP.Text = "Xem thông tin học phí"
        Me.btnView_TT_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView_TT_HP.UseVisualStyleBackColor = True
        '
        'frmTongHopThuKhac
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.btnView_TT_HP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdPrint_TongHop_HP)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lblSo_SV)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.grdDanhSach_View)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.cmdIn_No_HP)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmTongHopThuKhac"
        Me.Text = "TONG HOP THU HOC PHI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDanhSach_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvLop As TreeViewLop
    Friend WithEvents lblSo_SV As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents grdDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thieu_thua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents C1Report1 As C1.Win.C1Report.C1Report
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grdDanhSach_View As System.Windows.Forms.DataGridView
    Friend WithEvents cmdIn_No_HP As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint_TongHop_HP As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnView_TT_HP As System.Windows.Forms.Button
End Class
