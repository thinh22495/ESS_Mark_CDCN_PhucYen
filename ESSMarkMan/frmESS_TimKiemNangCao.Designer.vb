<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmbFieldGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cmbFieldGroup))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.FillGroup = New System.Windows.Forms.ToolStripComboBox
        Me.cmbID_hien_thi = New System.Windows.Forms.ComboBox
        Me.lblNhom_hien_thi = New System.Windows.Forms.Label
        Me.cmbOperatorb2 = New System.Windows.Forms.ComboBox
        Me.cmbField2 = New System.Windows.Forms.ComboBox
        Me.cmbOperatorb1 = New System.Windows.Forms.ComboBox
        Me.cmbField4 = New System.Windows.Forms.ComboBox
        Me.cmbValue2 = New System.Windows.Forms.ComboBox
        Me.lblValues2 = New System.Windows.Forms.Label
        Me.cmbValue3 = New System.Windows.Forms.ComboBox
        Me.cmbField1 = New System.Windows.Forms.ComboBox
        Me.cmbValue4 = New System.Windows.Forms.ComboBox
        Me.cmbOperator4 = New System.Windows.Forms.ComboBox
        Me.lblFields = New System.Windows.Forms.Label
        Me.txtValue4 = New System.Windows.Forms.TextBox
        Me.txtValue3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtValue2 = New System.Windows.Forms.TextBox
        Me.lblToantu_logic = New System.Windows.Forms.Label
        Me.txtValue1 = New System.Windows.Forms.TextBox
        Me.lblDieu_kien4 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.cmbOperator2 = New System.Windows.Forms.ComboBox
        Me.lblDieu_kien2 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.lblDieu_kien1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbOperator1 = New System.Windows.Forms.ComboBox
        Me.cmbValue1 = New System.Windows.Forms.ComboBox
        Me.cmbOperator3 = New System.Windows.Forms.ComboBox
        Me.lblValues1 = New System.Windows.Forms.Label
        Me.lblOperators = New System.Windows.Forms.Label
        Me.cmbField3 = New System.Windows.Forms.ComboBox
        Me.cmbOperatorb3 = New System.Windows.Forms.ComboBox
        Me.lblDieu_kien3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.lblTon_so_sv = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton
        Me.ImgMain = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdView = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.grcDanhSach = New DevExpress.XtraGrid.GridControl
        Me.grvDanhSach = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.FillGroup})
        Me.ToolStrip.Location = New System.Drawing.Point(8, 13)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(258, 25)
        Me.ToolStrip.TabIndex = 27
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel1.Text = "Tìm theo:"
        '
        'FillGroup
        '
        Me.FillGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FillGroup.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FillGroup.Items.AddRange(New Object() {"Ngành đào tạo", "Lý lịch sinh viên", "Khen thưởng", "Kỷ luật"})
        Me.FillGroup.Name = "FillGroup"
        Me.FillGroup.Size = New System.Drawing.Size(170, 25)
        '
        'cmbID_hien_thi
        '
        Me.cmbID_hien_thi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_hien_thi.Location = New System.Drawing.Point(458, 185)
        Me.cmbID_hien_thi.Name = "cmbID_hien_thi"
        Me.cmbID_hien_thi.Size = New System.Drawing.Size(239, 24)
        Me.cmbID_hien_thi.TabIndex = 66
        '
        'lblNhom_hien_thi
        '
        Me.lblNhom_hien_thi.BackColor = System.Drawing.Color.Transparent
        Me.lblNhom_hien_thi.Location = New System.Drawing.Point(291, 185)
        Me.lblNhom_hien_thi.Name = "lblNhom_hien_thi"
        Me.lblNhom_hien_thi.Size = New System.Drawing.Size(159, 24)
        Me.lblNhom_hien_thi.TabIndex = 65
        Me.lblNhom_hien_thi.Text = "Hiển thị thông tin theo:"
        Me.lblNhom_hien_thi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOperatorb2
        '
        Me.cmbOperatorb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperatorb2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperatorb2.ItemHeight = 16
        Me.cmbOperatorb2.Items.AddRange(New Object() {"AND", "OR"})
        Me.cmbOperatorb2.Location = New System.Drawing.Point(7, 126)
        Me.cmbOperatorb2.Name = "cmbOperatorb2"
        Me.cmbOperatorb2.Size = New System.Drawing.Size(72, 24)
        Me.cmbOperatorb2.TabIndex = 77
        '
        'cmbField2
        '
        Me.cmbField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbField2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbField2.ItemHeight = 16
        Me.cmbField2.Location = New System.Drawing.Point(167, 97)
        Me.cmbField2.Name = "cmbField2"
        Me.cmbField2.Size = New System.Drawing.Size(164, 24)
        Me.cmbField2.TabIndex = 73
        '
        'cmbOperatorb1
        '
        Me.cmbOperatorb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperatorb1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperatorb1.ItemHeight = 16
        Me.cmbOperatorb1.Items.AddRange(New Object() {"AND", "OR"})
        Me.cmbOperatorb1.Location = New System.Drawing.Point(7, 97)
        Me.cmbOperatorb1.Name = "cmbOperatorb1"
        Me.cmbOperatorb1.Size = New System.Drawing.Size(72, 24)
        Me.cmbOperatorb1.TabIndex = 72
        '
        'cmbField4
        '
        Me.cmbField4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbField4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbField4.ItemHeight = 16
        Me.cmbField4.Location = New System.Drawing.Point(167, 155)
        Me.cmbField4.Name = "cmbField4"
        Me.cmbField4.Size = New System.Drawing.Size(164, 24)
        Me.cmbField4.TabIndex = 83
        '
        'cmbValue2
        '
        Me.cmbValue2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbValue2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValue2.ItemHeight = 16
        Me.cmbValue2.Location = New System.Drawing.Point(439, 97)
        Me.cmbValue2.Name = "cmbValue2"
        Me.cmbValue2.Size = New System.Drawing.Size(172, 24)
        Me.cmbValue2.TabIndex = 75
        '
        'lblValues2
        '
        Me.lblValues2.AutoSize = True
        Me.lblValues2.BackColor = System.Drawing.Color.Transparent
        Me.lblValues2.Location = New System.Drawing.Point(647, 45)
        Me.lblValues2.Name = "lblValues2"
        Me.lblValues2.Size = New System.Drawing.Size(58, 16)
        Me.lblValues2.TabIndex = 94
        Me.lblValues2.Text = "Giá trị 2"
        '
        'cmbValue3
        '
        Me.cmbValue3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbValue3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValue3.ItemHeight = 16
        Me.cmbValue3.Location = New System.Drawing.Point(439, 126)
        Me.cmbValue3.Name = "cmbValue3"
        Me.cmbValue3.Size = New System.Drawing.Size(172, 24)
        Me.cmbValue3.TabIndex = 80
        '
        'cmbField1
        '
        Me.cmbField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbField1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbField1.ItemHeight = 16
        Me.cmbField1.Location = New System.Drawing.Point(167, 68)
        Me.cmbField1.Name = "cmbField1"
        Me.cmbField1.Size = New System.Drawing.Size(164, 24)
        Me.cmbField1.TabIndex = 68
        '
        'cmbValue4
        '
        Me.cmbValue4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbValue4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValue4.ItemHeight = 16
        Me.cmbValue4.Location = New System.Drawing.Point(439, 155)
        Me.cmbValue4.Name = "cmbValue4"
        Me.cmbValue4.Size = New System.Drawing.Size(172, 24)
        Me.cmbValue4.TabIndex = 85
        '
        'cmbOperator4
        '
        Me.cmbOperator4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator4.ItemHeight = 16
        Me.cmbOperator4.Location = New System.Drawing.Point(343, 155)
        Me.cmbOperator4.Name = "cmbOperator4"
        Me.cmbOperator4.Size = New System.Drawing.Size(80, 24)
        Me.cmbOperator4.TabIndex = 84
        '
        'lblFields
        '
        Me.lblFields.AutoSize = True
        Me.lblFields.BackColor = System.Drawing.Color.Transparent
        Me.lblFields.Location = New System.Drawing.Point(167, 45)
        Me.lblFields.Name = "lblFields"
        Me.lblFields.Size = New System.Drawing.Size(136, 16)
        Me.lblFields.TabIndex = 91
        Me.lblFields.Text = "Tên trường tìm kiếm"
        '
        'txtValue4
        '
        Me.txtValue4.Enabled = False
        Me.txtValue4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue4.Location = New System.Drawing.Point(631, 156)
        Me.txtValue4.Name = "txtValue4"
        Me.txtValue4.Size = New System.Drawing.Size(120, 23)
        Me.txtValue4.TabIndex = 86
        '
        'txtValue3
        '
        Me.txtValue3.Enabled = False
        Me.txtValue3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue3.Location = New System.Drawing.Point(631, 127)
        Me.txtValue3.Name = "txtValue3"
        Me.txtValue3.Size = New System.Drawing.Size(120, 23)
        Me.txtValue3.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(95, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 87
        '
        'txtValue2
        '
        Me.txtValue2.Enabled = False
        Me.txtValue2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue2.Location = New System.Drawing.Point(631, 98)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(120, 23)
        Me.txtValue2.TabIndex = 76
        '
        'lblToantu_logic
        '
        Me.lblToantu_logic.BackColor = System.Drawing.Color.Transparent
        Me.lblToantu_logic.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToantu_logic.Location = New System.Drawing.Point(-1, 53)
        Me.lblToantu_logic.Name = "lblToantu_logic"
        Me.lblToantu_logic.Size = New System.Drawing.Size(88, 40)
        Me.lblToantu_logic.TabIndex = 99
        Me.lblToantu_logic.Text = "Toán tử kết hợp tìm kiếm"
        Me.lblToantu_logic.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtValue1
        '
        Me.txtValue1.Enabled = False
        Me.txtValue1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue1.Location = New System.Drawing.Point(631, 69)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(120, 23)
        Me.txtValue1.TabIndex = 71
        '
        'lblDieu_kien4
        '
        Me.lblDieu_kien4.AutoSize = True
        Me.lblDieu_kien4.BackColor = System.Drawing.Color.Transparent
        Me.lblDieu_kien4.Location = New System.Drawing.Point(87, 159)
        Me.lblDieu_kien4.Name = "lblDieu_kien4"
        Me.lblDieu_kien4.Size = New System.Drawing.Size(79, 16)
        Me.lblDieu_kien4.TabIndex = 98
        Me.lblDieu_kien4.Text = "Điều kiện 4"
        Me.lblDieu_kien4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(527, 45)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(0, 13)
        Me.Label90.TabIndex = 90
        '
        'cmbOperator2
        '
        Me.cmbOperator2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator2.ItemHeight = 16
        Me.cmbOperator2.Location = New System.Drawing.Point(343, 97)
        Me.cmbOperator2.Name = "cmbOperator2"
        Me.cmbOperator2.Size = New System.Drawing.Size(80, 24)
        Me.cmbOperator2.TabIndex = 74
        '
        'lblDieu_kien2
        '
        Me.lblDieu_kien2.AutoSize = True
        Me.lblDieu_kien2.BackColor = System.Drawing.Color.Transparent
        Me.lblDieu_kien2.Location = New System.Drawing.Point(87, 101)
        Me.lblDieu_kien2.Name = "lblDieu_kien2"
        Me.lblDieu_kien2.Size = New System.Drawing.Size(79, 16)
        Me.lblDieu_kien2.TabIndex = 96
        Me.lblDieu_kien2.Text = "Điều kiện 2"
        Me.lblDieu_kien2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(319, 45)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(0, 13)
        Me.Label100.TabIndex = 89
        '
        'lblDieu_kien1
        '
        Me.lblDieu_kien1.AutoSize = True
        Me.lblDieu_kien1.BackColor = System.Drawing.Color.Transparent
        Me.lblDieu_kien1.Location = New System.Drawing.Point(87, 72)
        Me.lblDieu_kien1.Name = "lblDieu_kien1"
        Me.lblDieu_kien1.Size = New System.Drawing.Size(79, 16)
        Me.lblDieu_kien1.TabIndex = 95
        Me.lblDieu_kien1.Text = "Điều kiện 1"
        Me.lblDieu_kien1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(207, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 88
        '
        'cmbOperator1
        '
        Me.cmbOperator1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator1.ItemHeight = 16
        Me.cmbOperator1.Location = New System.Drawing.Point(343, 68)
        Me.cmbOperator1.Name = "cmbOperator1"
        Me.cmbOperator1.Size = New System.Drawing.Size(80, 24)
        Me.cmbOperator1.TabIndex = 69
        '
        'cmbValue1
        '
        Me.cmbValue1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbValue1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValue1.ItemHeight = 16
        Me.cmbValue1.Location = New System.Drawing.Point(439, 68)
        Me.cmbValue1.Name = "cmbValue1"
        Me.cmbValue1.Size = New System.Drawing.Size(172, 24)
        Me.cmbValue1.TabIndex = 70
        '
        'cmbOperator3
        '
        Me.cmbOperator3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperator3.ItemHeight = 16
        Me.cmbOperator3.Location = New System.Drawing.Point(343, 126)
        Me.cmbOperator3.Name = "cmbOperator3"
        Me.cmbOperator3.Size = New System.Drawing.Size(80, 24)
        Me.cmbOperator3.TabIndex = 79
        '
        'lblValues1
        '
        Me.lblValues1.AutoSize = True
        Me.lblValues1.BackColor = System.Drawing.Color.Transparent
        Me.lblValues1.Location = New System.Drawing.Point(479, 45)
        Me.lblValues1.Name = "lblValues1"
        Me.lblValues1.Size = New System.Drawing.Size(58, 16)
        Me.lblValues1.TabIndex = 93
        Me.lblValues1.Text = "Giá trị 1"
        '
        'lblOperators
        '
        Me.lblOperators.AutoSize = True
        Me.lblOperators.BackColor = System.Drawing.Color.Transparent
        Me.lblOperators.Location = New System.Drawing.Point(351, 45)
        Me.lblOperators.Name = "lblOperators"
        Me.lblOperators.Size = New System.Drawing.Size(56, 16)
        Me.lblOperators.TabIndex = 92
        Me.lblOperators.Text = "Toán tử"
        '
        'cmbField3
        '
        Me.cmbField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbField3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbField3.ItemHeight = 16
        Me.cmbField3.Location = New System.Drawing.Point(167, 126)
        Me.cmbField3.Name = "cmbField3"
        Me.cmbField3.Size = New System.Drawing.Size(164, 24)
        Me.cmbField3.TabIndex = 78
        '
        'cmbOperatorb3
        '
        Me.cmbOperatorb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperatorb3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperatorb3.ItemHeight = 16
        Me.cmbOperatorb3.Items.AddRange(New Object() {"AND", "OR"})
        Me.cmbOperatorb3.Location = New System.Drawing.Point(7, 155)
        Me.cmbOperatorb3.Name = "cmbOperatorb3"
        Me.cmbOperatorb3.Size = New System.Drawing.Size(72, 24)
        Me.cmbOperatorb3.TabIndex = 82
        '
        'lblDieu_kien3
        '
        Me.lblDieu_kien3.AutoSize = True
        Me.lblDieu_kien3.BackColor = System.Drawing.Color.Transparent
        Me.lblDieu_kien3.Location = New System.Drawing.Point(87, 130)
        Me.lblDieu_kien3.Name = "lblDieu_kien3"
        Me.lblDieu_kien3.Size = New System.Drawing.Size(79, 16)
        Me.lblDieu_kien3.TabIndex = 97
        Me.lblDieu_kien3.Text = "Điều kiện 3"
        Me.lblDieu_kien3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(755, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 24)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "(*)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_sv
        '
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_sv.Location = New System.Drawing.Point(135, 185)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(72, 24)
        Me.lblSo_sv.TabIndex = 102
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTon_so_sv
        '
        Me.lblTon_so_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblTon_so_sv.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTon_so_sv.Location = New System.Drawing.Point(-6, 185)
        Me.lblTon_so_sv.Name = "lblTon_so_sv"
        Me.lblTon_so_sv.Size = New System.Drawing.Size(135, 24)
        Me.lblTon_so_sv.TabIndex = 101
        Me.lblTon_so_sv.Text = "Tống số bản ghi:"
        Me.lblTon_so_sv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Appearance.Options.UseFont = True
        Me.cmdExport.ImageIndex = 6
        Me.cmdExport.ImageList = Me.ImgMain
        Me.cmdExport.Location = New System.Drawing.Point(589, 533)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(97, 30)
        Me.cmdExport.TabIndex = 253
        Me.cmdExport.Text = "Xuất Excel"
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
        'cmdView
        '
        Me.cmdView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdView.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.Appearance.Options.UseFont = True
        Me.cmdView.ImageIndex = 8
        Me.cmdView.ImageList = Me.ImgMain
        Me.cmdView.Location = New System.Drawing.Point(486, 533)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(97, 30)
        Me.cmdView.TabIndex = 254
        Me.cmdView.Text = "Xem hồ sơ"
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.ImageIndex = 19
        Me.cmdSearch.ImageList = Me.ImgMain
        Me.cmdSearch.Location = New System.Drawing.Point(383, 533)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(97, 30)
        Me.cmdSearch.TabIndex = 252
        Me.cmdSearch.Text = "Tìm kiếm"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageIndex = 7
        Me.SimpleButton1.ImageList = Me.ImgMain
        Me.SimpleButton1.Location = New System.Drawing.Point(691, 533)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(97, 30)
        Me.SimpleButton1.TabIndex = 251
        Me.SimpleButton1.Text = "Thoát"
        '
        'grcDanhSach
        '
        Me.grcDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcDanhSach.Location = New System.Drawing.Point(3, 223)
        Me.grcDanhSach.MainView = Me.grvDanhSach
        Me.grcDanhSach.Name = "grcDanhSach"
        Me.grcDanhSach.Size = New System.Drawing.Size(787, 304)
        Me.grcDanhSach.TabIndex = 255
        Me.grcDanhSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSach})
        '
        'grvDanhSach
        '
        Me.grvDanhSach.GridControl = Me.grcDanhSach
        Me.grvDanhSach.Name = "grvDanhSach"
        Me.grvDanhSach.OptionsSelection.MultiSelect = True
        Me.grvDanhSach.OptionsView.ShowGroupPanel = False
        Me.grvDanhSach.OptionsView.ShowViewCaption = True
        Me.grvDanhSach.ViewCaption = "DANH SÁCH SINH VIÊN"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ImageIndex = 0
        Me.btnEdit.ImageList = Me.ImgMain
        Me.btnEdit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEdit.Location = New System.Drawing.Point(705, 185)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 24)
        Me.btnEdit.TabIndex = 256
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbField3)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.lblNhom_hien_thi)
        Me.GroupBox1.Controls.Add(Me.cmbID_hien_thi)
        Me.GroupBox1.Controls.Add(Me.lblDieu_kien3)
        Me.GroupBox1.Controls.Add(Me.cmbOperatorb3)
        Me.GroupBox1.Controls.Add(Me.ToolStrip)
        Me.GroupBox1.Controls.Add(Me.lblOperators)
        Me.GroupBox1.Controls.Add(Me.lblValues1)
        Me.GroupBox1.Controls.Add(Me.lblSo_sv)
        Me.GroupBox1.Controls.Add(Me.cmbOperator3)
        Me.GroupBox1.Controls.Add(Me.lblTon_so_sv)
        Me.GroupBox1.Controls.Add(Me.cmbValue1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbOperator1)
        Me.GroupBox1.Controls.Add(Me.cmbOperatorb2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbField2)
        Me.GroupBox1.Controls.Add(Me.lblDieu_kien1)
        Me.GroupBox1.Controls.Add(Me.cmbOperatorb1)
        Me.GroupBox1.Controls.Add(Me.Label100)
        Me.GroupBox1.Controls.Add(Me.cmbField4)
        Me.GroupBox1.Controls.Add(Me.lblDieu_kien2)
        Me.GroupBox1.Controls.Add(Me.cmbValue2)
        Me.GroupBox1.Controls.Add(Me.cmbOperator2)
        Me.GroupBox1.Controls.Add(Me.lblValues2)
        Me.GroupBox1.Controls.Add(Me.Label90)
        Me.GroupBox1.Controls.Add(Me.cmbValue3)
        Me.GroupBox1.Controls.Add(Me.lblDieu_kien4)
        Me.GroupBox1.Controls.Add(Me.cmbField1)
        Me.GroupBox1.Controls.Add(Me.txtValue1)
        Me.GroupBox1.Controls.Add(Me.cmbValue4)
        Me.GroupBox1.Controls.Add(Me.lblToantu_logic)
        Me.GroupBox1.Controls.Add(Me.cmbOperator4)
        Me.GroupBox1.Controls.Add(Me.txtValue2)
        Me.GroupBox1.Controls.Add(Me.lblFields)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtValue4)
        Me.GroupBox1.Controls.Add(Me.txtValue3)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 215)
        Me.GroupBox1.TabIndex = 257
        Me.GroupBox1.TabStop = False
        '
        'cmbFieldGroup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grcDanhSach)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "cmbFieldGroup"
        Me.Text = "Tìm kiếm nâng cao"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbID_hien_thi As System.Windows.Forms.ComboBox
    Friend WithEvents lblNhom_hien_thi As System.Windows.Forms.Label
    Friend WithEvents cmbOperatorb2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbField2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOperatorb1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbField4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValue2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblValues2 As System.Windows.Forms.Label
    Friend WithEvents cmbValue3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbField1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValue4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOperator4 As System.Windows.Forms.ComboBox
    Friend WithEvents lblFields As System.Windows.Forms.Label
    Friend WithEvents txtValue4 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtValue2 As System.Windows.Forms.TextBox
    Friend WithEvents lblToantu_logic As System.Windows.Forms.Label
    Friend WithEvents txtValue1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDieu_kien4 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents cmbOperator2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblDieu_kien2 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents lblDieu_kien1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbOperator1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValue1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOperator3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblValues1 As System.Windows.Forms.Label
    Friend WithEvents lblOperators As System.Windows.Forms.Label
    Friend WithEvents cmbField3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOperatorb3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblDieu_kien3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FillGroup As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents lblTon_so_sv As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImgMain As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDanhSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
