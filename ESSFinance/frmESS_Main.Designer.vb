<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_Main))
        Me.imgChucNang = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuHocPhi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHocBong = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHeThong = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDanhMuc = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.staInfo1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.staInfo2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.uiHocPhi = New Janus.Windows.UI.Dock.UIPanel
        Me.uiHocPhiContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.tvHocPhi = New System.Windows.Forms.TreeView
        Me.uiHoc_bong = New Janus.Windows.UI.Dock.UIPanel
        Me.uiHoc_bongContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.tvHocBong = New System.Windows.Forms.TreeView
        Me.uiHeThong = New Janus.Windows.UI.Dock.UIPanel
        Me.uiHeThongContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.tvHeThong = New System.Windows.Forms.TreeView
        Me.uiDanhMuc = New Janus.Windows.UI.Dock.UIPanel
        Me.uiDanhMucContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.tvDanhMuc = New System.Windows.Forms.TreeView
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        CType(Me.uiHocPhi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiHocPhi.SuspendLayout()
        Me.uiHocPhiContainer.SuspendLayout()
        CType(Me.uiHoc_bong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiHoc_bong.SuspendLayout()
        Me.uiHoc_bongContainer.SuspendLayout()
        CType(Me.uiHeThong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiHeThong.SuspendLayout()
        Me.uiHeThongContainer.SuspendLayout()
        CType(Me.uiDanhMuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiDanhMuc.SuspendLayout()
        Me.uiDanhMucContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgChucNang
        '
        Me.imgChucNang.ImageStream = CType(resources.GetObject("imgChucNang.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgChucNang.TransparentColor = System.Drawing.Color.Transparent
        Me.imgChucNang.Images.SetKeyName(0, "text_code_c.ico")
        Me.imgChucNang.Images.SetKeyName(1, "alarmclock.ico")
        Me.imgChucNang.Images.SetKeyName(2, "angel.ico")
        Me.imgChucNang.Images.SetKeyName(3, "application.ico")
        Me.imgChucNang.Images.SetKeyName(4, "battery.ico")
        Me.imgChucNang.Images.SetKeyName(5, "bell.ico")
        Me.imgChucNang.Images.SetKeyName(6, "book_blue.ico")
        Me.imgChucNang.Images.SetKeyName(7, "books.ico")
        Me.imgChucNang.Images.SetKeyName(8, "bottle.ico")
        Me.imgChucNang.Images.SetKeyName(9, "box.ico")
        Me.imgChucNang.Images.SetKeyName(10, "box_closed.ico")
        Me.imgChucNang.Images.SetKeyName(11, "box_software.ico")
        Me.imgChucNang.Images.SetKeyName(12, "box_white.ico")
        Me.imgChucNang.Images.SetKeyName(13, "branch_element_new.ico")
        Me.imgChucNang.Images.SetKeyName(14, "breakpoint_into.ico")
        Me.imgChucNang.Images.SetKeyName(15, "brush2.ico")
        Me.imgChucNang.Images.SetKeyName(16, "bug_green.ico")
        Me.imgChucNang.Images.SetKeyName(17, "calculator.ico")
        Me.imgChucNang.Images.SetKeyName(18, "camera.ico")
        Me.imgChucNang.Images.SetKeyName(19, "candle.ico")
        Me.imgChucNang.Images.SetKeyName(20, "carabiner.ico")
        Me.imgChucNang.Images.SetKeyName(21, "cd.ico")
        Me.imgChucNang.Images.SetKeyName(22, "coffeebean_enterprise_new.ico")
        Me.imgChucNang.Images.SetKeyName(23, "colors.ico")
        Me.imgChucNang.Images.SetKeyName(24, "compass.ico")
        Me.imgChucNang.Images.SetKeyName(25, "component_new.ico")
        Me.imgChucNang.Images.SetKeyName(26, "cpu.ico")
        Me.imgChucNang.Images.SetKeyName(27, "cube_blue_add.ico")
        Me.imgChucNang.Images.SetKeyName(28, "cube_molecule.ico")
        Me.imgChucNang.Images.SetKeyName(29, "cubes.ico")
        Me.imgChucNang.Images.SetKeyName(30, "cup.ico")
        Me.imgChucNang.Images.SetKeyName(31, "debug.ico")
        Me.imgChucNang.Images.SetKeyName(32, "die.ico")
        Me.imgChucNang.Images.SetKeyName(33, "drink_blue.ico")
        Me.imgChucNang.Images.SetKeyName(34, "dude2.ico")
        Me.imgChucNang.Images.SetKeyName(35, "element_find.ico")
        Me.imgChucNang.Images.SetKeyName(36, "element_into.ico")
        Me.imgChucNang.Images.SetKeyName(37, "element_preferences.ico")
        Me.imgChucNang.Images.SetKeyName(38, "element_previous.ico")
        Me.imgChucNang.Images.SetKeyName(39, "factory.ico")
        Me.imgChucNang.Images.SetKeyName(40, "film.ico")
        Me.imgChucNang.Images.SetKeyName(41, "flag_blue.ico")
        Me.imgChucNang.Images.SetKeyName(42, "flashlight.ico")
        Me.imgChucNang.Images.SetKeyName(43, "gauge.ico")
        Me.imgChucNang.Images.SetKeyName(44, "ghost.ico")
        Me.imgChucNang.Images.SetKeyName(45, "graphics-tablet.ico")
        Me.imgChucNang.Images.SetKeyName(46, "hammer.ico")
        Me.imgChucNang.Images.SetKeyName(47, "headphones.ico")
        Me.imgChucNang.Images.SetKeyName(48, "hourglass.ico")
        Me.imgChucNang.Images.SetKeyName(49, "house.ico")
        Me.imgChucNang.Images.SetKeyName(50, "houses.ico")
        Me.imgChucNang.Images.SetKeyName(51, "jar.ico")
        Me.imgChucNang.Images.SetKeyName(52, "joystick.ico")
        Me.imgChucNang.Images.SetKeyName(53, "keyboard.ico")
        Me.imgChucNang.Images.SetKeyName(54, "keyboard_key.ico")
        Me.imgChucNang.Images.SetKeyName(55, "laptop2.ico")
        Me.imgChucNang.Images.SetKeyName(56, "layout_horizontal.ico")
        Me.imgChucNang.Images.SetKeyName(57, "loudspeaker.ico")
        Me.imgChucNang.Images.SetKeyName(58, "loudspeaker2.ico")
        Me.imgChucNang.Images.SetKeyName(59, "megaphone.ico")
        Me.imgChucNang.Images.SetKeyName(60, "modem.ico")
        Me.imgChucNang.Images.SetKeyName(61, "modem_earth.ico")
        Me.imgChucNang.Images.SetKeyName(62, "movie_pause.ico")
        Me.imgChucNang.Images.SetKeyName(63, "oszillograph.ico")
        Me.imgChucNang.Images.SetKeyName(64, "palette_text.ico")
        Me.imgChucNang.Images.SetKeyName(65, "registry.ico")
        Me.imgChucNang.Images.SetKeyName(66, "scanner.ico")
        Me.imgChucNang.Images.SetKeyName(67, "step_add.ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHocPhi, Me.mnuHocBong, Me.mnuHeThong, Me.mnuDanhMuc})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 108
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHocPhi
        '
        Me.mnuHocPhi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mnuHocPhi.Image = Global.ESSFinance.My.Resources.Resources.HocPhi
        Me.mnuHocPhi.Name = "mnuHocPhi"
        Me.mnuHocPhi.Size = New System.Drawing.Size(84, 20)
        Me.mnuHocPhi.Text = "Học phí"
        '
        'mnuHocBong
        '
        Me.mnuHocBong.Image = Global.ESSFinance.My.Resources.Resources.HocBong
        Me.mnuHocBong.Name = "mnuHocBong"
        Me.mnuHocBong.Size = New System.Drawing.Size(96, 20)
        Me.mnuHocBong.Text = "Học bổng"
        '
        'mnuHeThong
        '
        Me.mnuHeThong.Image = Global.ESSFinance.My.Resources.Resources.HeThong
        Me.mnuHeThong.Name = "mnuHeThong"
        Me.mnuHeThong.Size = New System.Drawing.Size(93, 20)
        Me.mnuHeThong.Text = "Hệ thống"
        '
        'mnuDanhMuc
        '
        Me.mnuDanhMuc.Image = Global.ESSFinance.My.Resources.Resources.DanhMuc
        Me.mnuDanhMuc.Name = "mnuDanhMuc"
        Me.mnuDanhMuc.Size = New System.Drawing.Size(100, 20)
        Me.mnuDanhMuc.Text = "Danh mục"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.staInfo1, Me.staInfo2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 675)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(924, 22)
        Me.StatusStrip1.TabIndex = 107
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'staInfo1
        '
        Me.staInfo1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.staInfo1.Name = "staInfo1"
        Me.staInfo1.Size = New System.Drawing.Size(102, 17)
        Me.staInfo1.Text = "Đăng nhập: ESSSoft"
        '
        'staInfo2
        '
        Me.staInfo2.Name = "staInfo2"
        Me.staInfo2.Size = New System.Drawing.Size(11, 17)
        Me.staInfo2.Text = "|"
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        Me.UiPanelManager1.DefaultTabGroupStyle = Janus.Windows.UI.Dock.TabGroupStyle.OutlookNavigator
        Me.UiPanelManager1.TabbedMdi = True
        Me.uiPanel0.Id = New System.Guid("a204bf98-e7a5-4455-addc-f8003ecbe802")
        Me.uiHocPhi.Id = New System.Guid("69d25f18-a249-4330-9f70-3f9ad3ab2455")
        Me.uiPanel0.Panels.Add(Me.uiHocPhi)
        Me.uiHoc_bong.Id = New System.Guid("dbd57594-6b27-4b6c-85ea-cc971c49a2bb")
        Me.uiPanel0.Panels.Add(Me.uiHoc_bong)
        Me.uiHeThong.Id = New System.Guid("d066fe73-5e60-4934-a02f-befd6f5c5784")
        Me.uiPanel0.Panels.Add(Me.uiHeThong)
        Me.uiDanhMuc.Id = New System.Guid("7d72e3fb-643d-426a-8df4-81769c2744b2")
        Me.uiPanel0.Panels.Add(Me.uiDanhMuc)
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("a204bf98-e7a5-4455-addc-f8003ecbe802"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, Janus.Windows.UI.Dock.PanelDockStyle.Left, True, New System.Drawing.Size(233, 645), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("69d25f18-a249-4330-9f70-3f9ad3ab2455"), New System.Guid("a204bf98-e7a5-4455-addc-f8003ecbe802"), -1, True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("dbd57594-6b27-4b6c-85ea-cc971c49a2bb"), New System.Guid("a204bf98-e7a5-4455-addc-f8003ecbe802"), -1, True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("d066fe73-5e60-4934-a02f-befd6f5c5784"), New System.Guid("a204bf98-e7a5-4455-addc-f8003ecbe802"), -1, True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("7d72e3fb-643d-426a-8df4-81769c2744b2"), New System.Guid("a204bf98-e7a5-4455-addc-f8003ecbe802"), -1, True)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.AllowOutlookButtonsResize = False
        Me.uiPanel0.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator
        Me.uiPanel0.Location = New System.Drawing.Point(3, 27)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.ShowOutlookNavigatorConfigureMenu = False
        Me.uiPanel0.Size = New System.Drawing.Size(233, 645)
        Me.uiPanel0.StaticGroup = True
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Panel 0"
        '
        'uiHocPhi
        '
        Me.uiHocPhi.Image = Global.ESSFinance.My.Resources.Resources.HocPhi
        Me.uiHocPhi.InnerContainer = Me.uiHocPhiContainer
        Me.uiHocPhi.Location = New System.Drawing.Point(0, 0)
        Me.uiHocPhi.Name = "uiHocPhi"
        Me.uiHocPhi.Size = New System.Drawing.Size(229, 517)
        Me.uiHocPhi.TabIndex = 4
        Me.uiHocPhi.Text = "Học phí"
        '
        'uiHocPhiContainer
        '
        Me.uiHocPhiContainer.Controls.Add(Me.tvHocPhi)
        Me.uiHocPhiContainer.Location = New System.Drawing.Point(1, 23)
        Me.uiHocPhiContainer.Name = "uiHocPhiContainer"
        Me.uiHocPhiContainer.Size = New System.Drawing.Size(227, 494)
        Me.uiHocPhiContainer.TabIndex = 0
        '
        'tvHocPhi
        '
        Me.tvHocPhi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvHocPhi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvHocPhi.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvHocPhi.ForeColor = System.Drawing.Color.DarkGreen
        Me.tvHocPhi.FullRowSelect = True
        Me.tvHocPhi.HideSelection = False
        Me.tvHocPhi.ItemHeight = 40
        Me.tvHocPhi.Location = New System.Drawing.Point(0, 0)
        Me.tvHocPhi.Name = "tvHocPhi"
        Me.tvHocPhi.ShowLines = False
        Me.tvHocPhi.ShowPlusMinus = False
        Me.tvHocPhi.ShowRootLines = False
        Me.tvHocPhi.Size = New System.Drawing.Size(227, 494)
        Me.tvHocPhi.TabIndex = 2
        '
        'uiHoc_bong
        '
        Me.uiHoc_bong.Image = Global.ESSFinance.My.Resources.Resources.HocBong
        Me.uiHoc_bong.InnerContainer = Me.uiHoc_bongContainer
        Me.uiHoc_bong.Location = New System.Drawing.Point(0, 0)
        Me.uiHoc_bong.Name = "uiHoc_bong"
        Me.uiHoc_bong.Size = New System.Drawing.Size(229, 517)
        Me.uiHoc_bong.TabIndex = 4
        Me.uiHoc_bong.Text = "Học bổng"
        '
        'uiHoc_bongContainer
        '
        Me.uiHoc_bongContainer.Controls.Add(Me.tvHocBong)
        Me.uiHoc_bongContainer.Location = New System.Drawing.Point(1, 23)
        Me.uiHoc_bongContainer.Name = "uiHoc_bongContainer"
        Me.uiHoc_bongContainer.Size = New System.Drawing.Size(227, 494)
        Me.uiHoc_bongContainer.TabIndex = 0
        '
        'tvHocBong
        '
        Me.tvHocBong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvHocBong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvHocBong.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvHocBong.ForeColor = System.Drawing.Color.DarkGreen
        Me.tvHocBong.FullRowSelect = True
        Me.tvHocBong.HideSelection = False
        Me.tvHocBong.ItemHeight = 40
        Me.tvHocBong.Location = New System.Drawing.Point(0, 0)
        Me.tvHocBong.Name = "tvHocBong"
        Me.tvHocBong.ShowLines = False
        Me.tvHocBong.ShowPlusMinus = False
        Me.tvHocBong.ShowRootLines = False
        Me.tvHocBong.Size = New System.Drawing.Size(227, 494)
        Me.tvHocBong.TabIndex = 3
        '
        'uiHeThong
        '
        Me.uiHeThong.Image = Global.ESSFinance.My.Resources.Resources.HeThong
        Me.uiHeThong.InnerContainer = Me.uiHeThongContainer
        Me.uiHeThong.Location = New System.Drawing.Point(0, 0)
        Me.uiHeThong.Name = "uiHeThong"
        Me.uiHeThong.Size = New System.Drawing.Size(229, 517)
        Me.uiHeThong.TabIndex = 4
        Me.uiHeThong.Text = "Hệ thống"
        '
        'uiHeThongContainer
        '
        Me.uiHeThongContainer.Controls.Add(Me.tvHeThong)
        Me.uiHeThongContainer.Location = New System.Drawing.Point(1, 23)
        Me.uiHeThongContainer.Name = "uiHeThongContainer"
        Me.uiHeThongContainer.Size = New System.Drawing.Size(227, 494)
        Me.uiHeThongContainer.TabIndex = 0
        '
        'tvHeThong
        '
        Me.tvHeThong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvHeThong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvHeThong.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvHeThong.ForeColor = System.Drawing.Color.DarkGreen
        Me.tvHeThong.FullRowSelect = True
        Me.tvHeThong.HideSelection = False
        Me.tvHeThong.ItemHeight = 40
        Me.tvHeThong.Location = New System.Drawing.Point(0, 0)
        Me.tvHeThong.Name = "tvHeThong"
        Me.tvHeThong.ShowLines = False
        Me.tvHeThong.ShowPlusMinus = False
        Me.tvHeThong.ShowRootLines = False
        Me.tvHeThong.Size = New System.Drawing.Size(227, 494)
        Me.tvHeThong.TabIndex = 3
        '
        'uiDanhMuc
        '
        Me.uiDanhMuc.Image = Global.ESSFinance.My.Resources.Resources.DanhMuc
        Me.uiDanhMuc.InnerContainer = Me.uiDanhMucContainer
        Me.uiDanhMuc.Location = New System.Drawing.Point(0, 0)
        Me.uiDanhMuc.Name = "uiDanhMuc"
        Me.uiDanhMuc.Size = New System.Drawing.Size(229, 517)
        Me.uiDanhMuc.TabIndex = 4
        Me.uiDanhMuc.Text = "Danh mục"
        '
        'uiDanhMucContainer
        '
        Me.uiDanhMucContainer.Controls.Add(Me.tvDanhMuc)
        Me.uiDanhMucContainer.Location = New System.Drawing.Point(1, 23)
        Me.uiDanhMucContainer.Name = "uiDanhMucContainer"
        Me.uiDanhMucContainer.Size = New System.Drawing.Size(227, 494)
        Me.uiDanhMucContainer.TabIndex = 0
        '
        'tvDanhMuc
        '
        Me.tvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDanhMuc.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvDanhMuc.ForeColor = System.Drawing.Color.DarkGreen
        Me.tvDanhMuc.FullRowSelect = True
        Me.tvDanhMuc.HideSelection = False
        Me.tvDanhMuc.ItemHeight = 40
        Me.tvDanhMuc.Location = New System.Drawing.Point(0, 0)
        Me.tvDanhMuc.Name = "tvDanhMuc"
        Me.tvDanhMuc.ShowLines = False
        Me.tvDanhMuc.ShowPlusMinus = False
        Me.tvDanhMuc.ShowRootLines = False
        Me.tvDanhMuc.Size = New System.Drawing.Size(227, 494)
        Me.tvDanhMuc.TabIndex = 3
        '
        'frmESS_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 697)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmESS_Main"
        Me.Text = "UniAccount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        CType(Me.uiHocPhi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiHocPhi.ResumeLayout(False)
        Me.uiHocPhiContainer.ResumeLayout(False)
        CType(Me.uiHoc_bong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiHoc_bong.ResumeLayout(False)
        Me.uiHoc_bongContainer.ResumeLayout(False)
        CType(Me.uiHeThong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiHeThong.ResumeLayout(False)
        Me.uiHeThongContainer.ResumeLayout(False)
        CType(Me.uiDanhMuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiDanhMuc.ResumeLayout(False)
        Me.uiDanhMucContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgChucNang As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuHocPhi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHeThong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDanhMuc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents staInfo1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents staInfo2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents uiHocBong As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiHocPhiContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents uiHeThong As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiHeThongContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents uiDanhMuc As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiDanhMucContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents uiHocPhi As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents tvHocPhi As System.Windows.Forms.TreeView
    Friend WithEvents tvHeThong As System.Windows.Forms.TreeView
    Friend WithEvents tvDanhMuc As System.Windows.Forms.TreeView
    Friend WithEvents uiHoc_bong As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiHoc_bongContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents tvHocBong As System.Windows.Forms.TreeView
    Friend WithEvents mnuHocBong As System.Windows.Forms.ToolStripMenuItem
End Class
