Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel
Imports ESSUtility
Partial Public Class frmESS_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Dim Loader As Boolean = False
    Public Sub New()
        InitializeComponent()
        InitEditors()
        UserLookAndFeel.Default.SetSkinStyle("Office 2010")
    End Sub

    Private Sub frmESS_Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            SaveLog(LoaiSuKien.Them, "Người dùng: " & gobjUser.UserName & " - đăng xuất khỏi hệ thống")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub InitEditors()
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
        biStyle.EditValue = RibMain.RibbonStyle
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        If UCheckVersion() = "1" Then
            End
        End If

        'Đăng nhập chương trình
        Dim frm As New frmESS_DangNhap
        frm.ShowDialog()
        'Đăng nhập thành công
        If frm.Tag = 1 Then
            RibMain.ForceInitialize()
            For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = RibMain.Items.CreateCheckItem(skin.SkinName, False)
                item.Tag = skin.SkinName
                AddHandler item.ItemClick, AddressOf OnPaintStyleClick
                mnuPainStyle.ItemLinks.Add(item)
            Next skin
            'Load chuc nang
            HienThi_ESSchuc_nang()
            Loader = True
        Else    'Đăng nhập không thành công
            Close()
        End If

    End Sub

    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
    End Sub


    Private Sub ribMain_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RibMain.ItemClick
        If Not e.Item.Tag Is Nothing AndAlso IsNumeric(e.Item.Tag) Then
            Show_form(e.Item.Tag, e.Item.Caption)
        End If
    End Sub

    Private Sub biStyle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biStyle.EditValueChanged
        RibMain.RibbonStyle = CType(biStyle.EditValue, RibbonControlStyle)
    End Sub

    Private Sub mnuPainStyle_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPainStyle.Popup
        For Each link As BarItemLink In mnuPainStyle.ItemLinks
            CType(link.Item, BarCheckItem).Checked = link.Item.Caption = defaultLookAndFeel1.LookAndFeel.ActiveSkinName
        Next link
    End Sub
#Region "Funs"

    Private Sub Show_form(ByVal FunctionID As String, ByVal Caption As String)
        Try
            gFunctionID = FunctionID
            Dim frmESS_ As Form = Nothing
            Select Case FunctionID
                Case 12310
                    frmESS_ = New frmESS_KhoaDuLieuDiemThanhPhanLop
                Case 12311
                    frmESS_ = New frmESS_KhoaDulieuDiemThanhPhanLopTinChi
                Case 12312
                    frmESS_ = New frmESS_KhoaDulieuDiemThiLopHC
                Case 12313
                    frmESS_ = New frmESS_KhoaDulieuDiemThiLopTinChi
                Case 12314
                    frmESS_ = New frmESS_KhoaDulieuDiemThiTheoPhong
                Case 12315
                    'frmESS_ = New frmESS_DoiChieuDuLieuDiem
                Case 12316
                    'frmESS_ = New frmESS_KiemTraDuLieuSai_CSDL
                Case 12317
                    frmESS_ = New frmESS_KhoaDiemHocPhanDotThi
                Case 12318
                    frmESS_ = New frmESS_TimKiemDonGian
                Case 12319
                    frmESS_ = New cmbFieldGroup
                Case 12320
                    frmESS_ = New frmESS_ThamSoHeThong
                Case 12321
                    frmESS_ = New frmESS_ThayDoiMatKhau

                Case 123202
                    frmESS_ = New frmESS_HocPhan_DanhSach
                Case 123203
                    frmESS_ = New frmESS_DMHeDaoTao
                Case 123204
                    frmESS_ = New frmESS_DMKhoa

                Case 123210
                    frmESS_ = New frmESS_DMDiemQuyDoi
                Case 123211
                    frmESS_ = New frmESS_DMNganhDaoTao
                Case 123212
                    frmESS_ = New frmESS_DMChuyenNganh
                Case 123213
                    frmESS_ = New frmESS_DMXepHangHocLuc
                Case 123214
                    frmESS_ = New frmESS_DMXepHangTotNghiep
                Case 123215
                    frmESS_ = New frmESS_DMXepHangNamDaoTao
                Case 123216
                    frmESS_ = New frmESS_DMXepLoaiHocTap
                Case 123217
                    frmESS_ = New frmESS_DMLoaiChungChi
                Case 123218
                    frmESS_ = New frmESS_DMXepLoaiChungChi
                Case 123219
                    frmESS_ = New frmESS_TieuDeBaoCao(gobjUser)
                Case 123220
                    frmESS_ = New frmESS_DMNoiThucTap
                Case 12323
                    frmESS_ = New frmESS_KhungChuongTrinhDaoTao_DanhSach
                Case 12324
                    frmESS_ = New frmESS_LapDanhSachThi_CaiThienDiem
                Case 12325
                    frmESS_ = New frmESS_ToChucThi_DanhSach
                Case 12326
                    frmESS_ = New frmESS_ToChucThi_DongTui
                Case 12327
                    frmESS_ = New frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LTC
                Case 12328
                    frmESS_ = New frmESS_TongHop_SinhVienThiLai
                Case 12329
                    frmESS_ = New frmESS_ToChucThi_DongTuiThi
                Case 12330
                    frmESS_ = New frmTongHopThuKhac
                Case 12331
                    frmESS_ = New frmESS_DanhSachSinhVien_LopTinChi
                Case 12332
                    frmESS_ = New frmESS_NhapDiem_Thi_LopHanhChinh
                Case 12333
                    frmESS_ = New frmESS_NhapDiem_ThanhPhan_LopHanhChinh
                Case 12334
                    frmESS_ = New frmESS_NhapDiemTu_Excel
                Case 12335
                    frmESS_ = New frmESS_NhapDiem_Thi_Phong
                Case 12336
                    frmESS_ = New frmESS_NhapDiem_ThanhPhan_LopTinChi
                Case 12337
                    frmESS_ = New frmESS_NhapDiem_Thi_LopTinChi
                Case 12338
                    frmESS_ = New frmESS_DanhSachSinhVien_LopTinChi
                Case 12339
                    frmESS_ = New frmESS_KeThuaDiem_Nganh2
                Case 123309
                    frmESS_ = New frmESS_NhapDiem_Thi_TheoSBD_CaiThien
                Case 123310
                    frmESS_ = New frmESS_NhapDiem_Thi_TheoSBD
                Case 123311
                    frmESS_ = New frmESS_NhapDiem_TheoSoPhach
                Case 123312
                    frmESS_ = New frmESS_NhapDiem_Thi_TuiThi
                Case 123313
                    frmESS_ = New frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LHC
                Case 123314
                    frmESS_ = New frmESS_NhapDiemTu_Excel_TheoSBD
                Case 12353
                    frmESS_ = New frmESS_TongHop_DiemHocKy
                Case 12354
                    frmESS_ = New frmESS_TongHop_DiemNamHoc
                Case 12355
                    frmESS_ = New frmESS_TongHop_DiemHocTichLuy
                Case 12356
                    frmESS_ = New frmESS_DanhSachSinhVien_Lop
                Case 123512
                    frmESS_ = New frmESS_BangDiemSinhVien
                Case 123513
                    frmESS_ = New frmESS_TongHop_HocPhanChungChi
                Case 123514
                    frmESS_ = New frmESS_GiayBaoGiangDay
                Case 12361
                    frmESS_ = New frmEDU_XetLenLop
                Case 123525
                    frmESS_ = New frmEDU_XetLenLop_TongHop
                Case 12362
                    frmESS_ = New frmESS_DanhSachSinhVien_QuyetDinh_DanhSach
                Case 12363
                    frmESS_ = New frmESS_XetLuanVan
                Case 12364
                    frmESS_ = New frmESS_PhanCongThucTap
                Case 12365
                    'frmESS_ = New frmESS_NoKhacKhiXetTotNghiep
                Case 12366
                    frmESS_ = New frmESS_XetTotNghiep
                Case 12367
                    frmESS_ = New frmESS_DanhSachSinhVien_DangKyNganh2
                    'Case 12368
                    '    frmESS_ = New frmESS_XetTotNghiep_Nganh2
                Case 12369
                    frmESS_ = New frmESS_XetLenLop_NganhThu2
                Case 12370
                    frmESS_ = New frmESS_XetTotNghiep_DangKy_Xet
                Case 123182
                    frmESS_ = New frmESS_DangKyLopHocPhan_TinChiChoSinhVien
                Case 123183
                    frmESS_ = New frmESS_DuyetDangKyTinChiChoLop
                Case 123184
                    frmESS_ = New frmESS_DuyetDangKyTinChiChoLop_Nganh2
                Case 123515
                    frmESS_ = New frmESS_NhapDiem_ThanhPhan_LopHanhChinh_Nganh2
                Case 123516
                    frmESS_ = New frmESS_NhapDiem_Thi_LopHanhChinh_Nganh2
                Case 123517
                    frmESS_ = New frmESS_TongHop_DiemHocKy_Nganh2
                Case 123518
                    frmESS_ = New frmESS_TongHop_DiemNamHoc_NganhHoc2
                Case 123519
                    frmESS_ = New frmESS_TongHop_DiemHocTichLuy_NganhHoc2
                Case 123520
                    frmESS_ = New frmESS_XetTotNghiep_Nganh2

                Case 123521
                    frmESS_ = New frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi
                Case 123522
                    frmESS_ = New frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi
            End Select
            gFunctionID = FunctionID
            If Not frmESS_ Is Nothing Then
                frmESS_.Text = Caption
                Me.FormSelected(frmESS_)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub HienThi_ESSchuc_nang()
        Dim idx As Integer = 0
        'Chương trình đào tạo
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 18 Then

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribChuongTrinhDaoTao.Groups(0).ItemLinks.Add(xBarItem)
                mnuChuongTrinhDaoTao.ItemLinks.Add(xBarItem)

                idx += 1
            End If
        Next
        'Quản lý và tổ chức thi
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 10 Then
                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribToChucThi.Groups(0).ItemLinks.Add(xBarItem)
                mnuToChucThi.AddItem(xBarItem)
                idx += 1
            End If
        Next
        'Quá trình điểm
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 3 Then
                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribQuanLyDiem.Groups(0).ItemLinks.Add(xBarItem)
                mnuQuanLyDiem.AddItem(xBarItem)


                idx += 1
            End If
        Next


        'Tong hop Bao cao
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 5 Then
              

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribTongHop.Groups(0).ItemLinks.Add(xBarItem)
                mnuTongHop.AddItem(xBarItem)
                idx += 1
            End If
        Next
        'Xét duyệt
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 11 Then

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribXetDuyet.Groups(0).ItemLinks.Add(xBarItem)
                mnuXetDuyet.AddItem(xBarItem)
                idx += 1
            End If
        Next

        'Tim Kiem
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 4 Then
              
                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribTimKiem.Groups(0).ItemLinks.Add(xBarItem)
                mnuTimKiem.AddItem(xBarItem)
                idx += 1
            End If
        Next


        'Danh muc
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 2 Then

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribDanhMuc.Groups(0).ItemLinks.Add(xBarItem)
                mnuDanhMuc.AddItem(xBarItem)

                idx += 1
            End If
        Next
        'Ngành học thứ 2
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 21 Then
                ' Add Item to NavBarGroup
                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx

                xBarItem.RibbonStyle = RibbonItemStyles.Large

                RibNganh2.Groups(0).ItemLinks.Add(xBarItem)
                mnuNganh2.AddItem(xBarItem)
                idx += 1
            End If
        Next

        'Hệ thống
        idx = 0
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 1 Then

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx

                xBarItem.RibbonStyle = RibbonItemStyles.Large

                ribHeThong.Groups(0).ItemLinks.Add(xBarItem)
                mnuHeThong.AddItem(xBarItem)


                idx += 1
            End If
        Next


    End Sub

    Private Function CheckFormExist(ByVal frmESS_ As Form) As Boolean
        For Each frmESS_Children As Form In Me.MdiChildren
            If frmESS_Children.Name = frmESS_.Name Then
                frmESS_Children.Select()
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub FormSelected(ByVal frmESS_ As Form)
        If CheckFormExist(frmESS_) Then Exit Sub
        'frmESS_.Text = "Mã chức năng " & FunctionID
        staInfomation.Caption = "CHỨC NĂNG: " & frmESS_.Text & " - NGƯỜI DÙNG: " & gobjUser.FullName.ToUpper & " - PHÒNG: " & gobjUser.Phong_ban.ToUpper & " -ĐANG SỬ DỤNG"
        frmESS_.MdiParent = Me
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.WindowState = FormWindowState.Maximized
        frmESS_.Show()
    End Sub
#End Region
End Class