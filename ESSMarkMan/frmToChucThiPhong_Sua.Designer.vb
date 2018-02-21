<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToChucThiPhong_Sua
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
        Me.cmbNhom_tiet = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpNgay_thi = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGio_thi = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbID_nha = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbID_phong = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_co_so = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbNhom_tiet
        '
        Me.cmbNhom_tiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNhom_tiet.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbNhom_tiet.Location = New System.Drawing.Point(273, 34)
        Me.cmbNhom_tiet.Name = "cmbNhom_tiet"
        Me.cmbNhom_tiet.Size = New System.Drawing.Size(43, 25)
        Me.cmbNhom_tiet.TabIndex = 65
        Me.cmbNhom_tiet.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(197, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 24)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Nhóm tiết:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'cmbCa
        '
        Me.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCa.Items.AddRange(New Object() {"Sáng", "Chiều", "Tối"})
        Me.cmbCa.Location = New System.Drawing.Point(102, 34)
        Me.cmbCa.Name = "cmbCa"
        Me.cmbCa.Size = New System.Drawing.Size(95, 25)
        Me.cmbCa.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(42, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Ca thi:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_thi
        '
        Me.dtpNgay_thi.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_thi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_thi.Location = New System.Drawing.Point(105, 3)
        Me.dtpNgay_thi.Name = "dtpNgay_thi"
        Me.dtpNgay_thi.Size = New System.Drawing.Size(92, 25)
        Me.dtpNgay_thi.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(42, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Ngày thi:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGio_thi
        '
        Me.txtGio_thi.Location = New System.Drawing.Point(102, 65)
        Me.txtGio_thi.MaxLength = 200
        Me.txtGio_thi.Name = "txtGio_thi"
        Me.txtGio_thi.Size = New System.Drawing.Size(260, 25)
        Me.txtGio_thi.TabIndex = 69
        Me.txtGio_thi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(22, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Thời gian:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1, 192)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 27)
        Me.btnSave.TabIndex = 70
        Me.btnSave.Text = "Cập nhật"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(82, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbID_nha
        '
        Me.cmbID_nha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_nha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_nha.Location = New System.Drawing.Point(102, 125)
        Me.cmbID_nha.Name = "cmbID_nha"
        Me.cmbID_nha.Size = New System.Drawing.Size(185, 25)
        Me.cmbID_nha.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(32, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Toà nhà:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_phong
        '
        Me.cmbID_phong.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_phong.Location = New System.Drawing.Point(102, 155)
        Me.cmbID_phong.Name = "cmbID_phong"
        Me.cmbID_phong.Size = New System.Drawing.Size(185, 25)
        Me.cmbID_phong.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(32, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Phòng thi:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_co_so
        '
        Me.cmbID_co_so.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_co_so.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_co_so.Location = New System.Drawing.Point(102, 94)
        Me.cmbID_co_so.Name = "cmbID_co_so"
        Me.cmbID_co_so.Size = New System.Drawing.Size(185, 25)
        Me.cmbID_co_so.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(32, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Cơ sở:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmToChucThiPhong_Sua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 223)
        Me.Controls.Add(Me.cmbID_co_so)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbID_phong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_nha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtGio_thi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpNgay_thi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbNhom_tiet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbCa)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmToChucThiPhong_Sua"
        Me.Text = "SỬA THÔNG TIN PHÒNG THI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbNhom_tiet As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_thi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGio_thi As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbID_nha As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbID_phong As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_co_so As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
