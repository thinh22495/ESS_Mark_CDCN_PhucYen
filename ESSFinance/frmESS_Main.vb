Imports ESSUtility
Public Class frmESS_Main
    Dim Loader As Boolean = False
#Region "User Functions"

    Private Function CheckFormExist(ByVal frmESS_ As Form) As Boolean
        For Each frmESS_Children As Form In Me.MdiChildren
            If frmESS_Children.Name = frmESS_.Name Then
                frmESS_Children.Select()
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub FormSelected(ByVal frmESS_ As Form, ByVal FunctionID As String)
        If CheckFormExist(frmESS_) Then Exit Sub
        'frmESS_.Text = "Mã chức năng " & FunctionID
        'staInfo1.Text = "Mã chức năng " & FunctionID & " - Người dùng: " & gobjUser.FullName & " -đang sử dụng"
        frmESS_.MdiParent = Me
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.WindowState = FormWindowState.Maximized
        frmESS_.Show()
    End Sub

    Private Sub Show_form(ByVal FunctionID As String)
        Try
            gFunctionID = FunctionID
            Dim frmESS_ As Form = Nothing
            Select Case FunctionID
                Case 521    'Loại quỹ học bổng
                    frmESS_ = New frmESS_LoaiQuyHocBong
                Case 522    'Loại học bổng
                    'frmESS_ = New frmESS_XepLoaiHocBong
                    frmESS_ = New frmESS_DoiTuongHocBong
                Case 523    'Phân loại học bổng theo đối tượng
                    frmESS_ = New frmESS_PhanLoaiHocBongTheoDoiTuong
                Case 524    'Các loại thu chi
                    frmESS_ = New frmESS_LoaiThuChi
                Case 531
                    frmESS_ = New frmESS_QuyHocBongList
                Case 532
                    frmESS_ = New frmESS_PhanBoQuyHocBong
                Case 533
                    frmESS_ = New frmESS_LapDanhSachTroCapHocBong
                Case 534
                    frmESS_ = New frmESS_XetHocBong
                Case 535
                    frmESS_ = New frmESS_DSHocBongHocPhi
                Case 541
                    frmESS_ = New frmESS_LapDanhSachMienGiamHocPhi
                Case 542
                    frmESS_ = New frmESS_LapDanhSachThuKhac
                Case 543
                    frmESS_ = New frmESS_BienLaiThuList
                Case 544
                    frmESS_ = New frmESS_BienLaiThuHocKyList
                Case 545
                    frmESS_ = New frmESS_TongHopThuHocPhi
                Case 546
                    frmESS_ = New frmESS_TongHopThuKhac
                Case 547
                    frmESS_ = New frmESS_TieuDeBaoCao
                Case 548
                    frmESS_ = New frmESS_DoiTuongGiayTo
                Case 549
                    frmESS_ = New frmESS_ChangePassword
                Case 550
                    frmESS_ = New frmESS_DMXepLoaiHocTap
                Case 5410
                    frmESS_ = New frmESS_DanhSachSinhVienNgoaiNganSach
                Case 525
                    frmESS_ = New frmESS_DMMucHocPhiTinChi
                Case 5151
                    frmESS_ = New frmESS_BienLaiThuThiLaiList
                Case 5152
                    frmESS_ = New frmESS_ThongTinTaiChinhSinhVien
            End Select
            If Not frmESS_ Is Nothing Then
                Me.FormSelected(frmESS_, FunctionID)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub HienThi_ESSchuc_nang(ByVal tvName As TreeView, ByVal mnuName As ToolStripMenuItem, ByVal Nhom As Byte)
        Dim idx As Integer = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = Nhom Then
                'Add Panel
                tvName.Nodes.Add(New TreeNode(gobjUser.ESSQuyen.Quyen(i).Ten_quyen, 1, 1))
                tvName.Nodes(idx).Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                tvName.Nodes(idx).ImageIndex = idx
                'Add menu
                mnuName.DropDownItems.Add(gobjUser.ESSQuyen.Quyen(i).Ten_quyen, imgChucNang.Images(idx), New EventHandler(AddressOf mnuChuc_nang_Click))
                mnuName.DropDownItems.Item(idx).Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                idx += 1
            End If
        Next
        'Format Treeview
        TreeView_setting(tvName)
    End Sub
    Private Sub HienThi_ESSnhom_chuc_nang()
        Dim idx As Integer = 0
        HienThi_ESSchuc_nang(tvHocPhi, mnuHocPhi, 15)
        HienThi_ESSchuc_nang(tvHocBong, mnuHocBong, 16)
        HienThi_ESSchuc_nang(tvHeThong, mnuHeThong, 2)
        HienThi_ESSchuc_nang(tvDanhMuc, mnuDanhMuc, 1)
        staInfo1.Text = " - Người dùng: " & gobjUser.FullName & " - Hòm thư - " & gobjUser.Email
    End Sub
    Private Sub TreeView_setting(ByVal tvName As TreeView)
        Dim font As Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim color As Color = System.Drawing.Color.RoyalBlue
        tvName.ForeColor = color
        tvName.ItemHeight = 30
        tvName.Font = font
        tvName.ImageList = Me.imgChucNang
    End Sub
#End Region

#Region " Form event "
    Private Sub frmESS_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCheckVersion() = "1" Then
            End
        End If
        'Đăng nhập chương trình
        Dim frmESS_ As New frmESS_Login
        frmESS_.ShowDialog()
        'Đăng nhập thành công
        If frmESS_.Tag = 1 Then
            'Load chuc nang
            HienThi_ESSnhom_chuc_nang()
            Loader = True
        Else    'Đăng nhập không thành công
            Close()
        End If
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvChuc_nang_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvHocPhi.DoubleClick, tvHocBong.DoubleClick, _
                                                                                                        tvHeThong.DoubleClick, tvDanhMuc.DoubleClick
        If Not sender.SelectedNode Is Nothing Then
            Show_form(sender.SelectedNode.Tag)
        End If
    End Sub
    Private Sub mnuChuc_nang_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not sender Is Nothing Then
            Show_form(sender.Tag)
        End If
    End Sub
#End Region
End Class
