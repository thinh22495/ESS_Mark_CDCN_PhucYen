<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTongHop_No_HP_HeKhoaKhoaHoc
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
        Me.cmbKhoa_hoc1 = New System.Windows.Forms.ComboBox
        Me.cmbID_he = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbID_khoa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPrint_TongHop_HP = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbKhoa_hoc1
        '
        Me.cmbKhoa_hoc1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbKhoa_hoc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbKhoa_hoc1.ItemHeight = 15
        Me.cmbKhoa_hoc1.Location = New System.Drawing.Point(86, 52)
        Me.cmbKhoa_hoc1.Name = "cmbKhoa_hoc1"
        Me.cmbKhoa_hoc1.Size = New System.Drawing.Size(72, 23)
        Me.cmbKhoa_hoc1.TabIndex = 132
        '
        'cmbID_he
        '
        Me.cmbID_he.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbID_he.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_he.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbID_he.Location = New System.Drawing.Point(86, 21)
        Me.cmbID_he.Name = "cmbID_he"
        Me.cmbID_he.Size = New System.Drawing.Size(187, 23)
        Me.cmbID_he.TabIndex = 128
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(35, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 28)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Hệ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(6, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Khoa:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_khoa
        '
        Me.cmbID_khoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbID_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_khoa.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbID_khoa.ItemHeight = 15
        Me.cmbID_khoa.Location = New System.Drawing.Point(86, 83)
        Me.cmbID_khoa.Name = "cmbID_khoa"
        Me.cmbID_khoa.Size = New System.Drawing.Size(177, 23)
        Me.cmbID_khoa.TabIndex = 130
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(2, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Khoá học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdPrint_TongHop_HP
        '
        Me.cmdPrint_TongHop_HP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint_TongHop_HP.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint_TongHop_HP.Image = My.Resources.Resources.Print
        Me.cmdPrint_TongHop_HP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint_TongHop_HP.Location = New System.Drawing.Point(5, 282)
        Me.cmdPrint_TongHop_HP.Name = "cmdPrint_TongHop_HP"
        Me.cmdPrint_TongHop_HP.Size = New System.Drawing.Size(333, 28)
        Me.cmdPrint_TongHop_HP.TabIndex = 238
        Me.cmdPrint_TongHop_HP.Text = "In Tổng hợp nợ, thừa HP Hệ, Khóa, Chuyên ngành"
        Me.cmdPrint_TongHop_HP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint_TongHop_HP.UseVisualStyleBackColor = True
        '
        'frmTongHop_No_HP_HeKhoaKhoaHoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 309)
        Me.Controls.Add(Me.cmdPrint_TongHop_HP)
        Me.Controls.Add(Me.cmbKhoa_hoc1)
        Me.Controls.Add(Me.cmbID_he)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbID_khoa)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTongHop_No_HP_HeKhoaKhoaHoc"
        Me.Text = "frmTongHop_No_HP_HeKhoaKhoaHoc"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbKhoa_hoc1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbID_he As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbID_khoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint_TongHop_HP As System.Windows.Forms.Button
End Class
