Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects

Public Class frmESS_KhungChuongTrinhDaotao_SaoChep
    Private mID_he As Integer
    Private mID_khoa As Integer
    Private mKhoa_hoc As Integer
    Private mID_chuyen_nganh As Integer
    Private mSo As Integer
    Private mID_dt As Integer
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Private clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, 1, -1)
    Private loaded As Boolean = False
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_Bussines, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_dt As Integer, ByVal So As Integer)
        mID_he = ID_he
        mID_khoa = ID_khoa
        mKhoa_hoc = Khoa_hoc
        mID_chuyen_nganh = ID_chuyen_nganh
        mID_dt = ID_dt
        mSo = So
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub


    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            dt2 = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)
            FillCombo(cmbID_he1, dt2)

            'Load combobox kiến thức
            dt = clsDM.DanhMuc_Load("PLAN_ChuongTrinhDaoTaoKienThuc", "ID_kien_thuc", "Ten_kien_thuc")
            FillCombo(cmbKien_thuc, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



    Private Function CheckValidate() As Boolean
        If cmbID_he1.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn hệ đào tạo")
            cmbID_he1.Focus()
            Return False
        End If
        If cmbID_khoa1.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoa đào tạo")
            cmbID_khoa1.Focus()
            Return False
        End If
        If cmbKhoa_hoc1.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoá đào tạo")
            cmbKhoa_hoc1.Focus()
            Return False
        End If
        If cmbID_chuyen_nganh1.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn chuyên ngành đào tạo")
            cmbID_chuyen_nganh1.Focus()
            Return False
        End If
        '
        If cmbID_he.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn hệ đào tạo")
            cmbID_he.Focus()
            Return False
        End If
        If cmbID_khoa.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoa đào tạo")
            cmbID_khoa.Focus()
            Return False
        End If
        If cmbKhoa_hoc.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoá đào tạo")
            cmbKhoa_hoc.Focus()
            Return False
        End If
        If cmbID_chuyen_nganh.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn chuyên ngành đào tạo")
            cmbID_chuyen_nganh.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub frmESS_ChuongTrinhDaotaoSaoChep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox
        LoadComboBox()
        loaded = True
        cmbID_he.SelectedValue = mID_he
        cmbID_he1.SelectedValue = mID_he
        cmbID_khoa.SelectedValue = mID_khoa
        cmbID_khoa1.SelectedValue = mID_khoa
        cmbKhoa_hoc.SelectedValue = mKhoa_hoc
        cmbKhoa_hoc1.SelectedValue = mKhoa_hoc
        cmbID_chuyen_nganh.SelectedValue = mID_chuyen_nganh
        cmbID_chuyen_nganh1.SelectedValue = mID_chuyen_nganh
        cmbSo.SelectedIndex = mSo - 1
        cmbSo1.SelectedIndex = mSo

        'Set quyền truy cập chức năng
        SetQuyenTruyCap(cmdSave)
    End Sub
    'Private Sub frmESS_ChuongTrinhDaotaoSaoChep_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
    '    e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    'End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = "0"
        Me.Close()
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Not loaded Then Exit Sub
            Dim dvKhoa As DataView
            dvKhoa = clsLop.Khoa().DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            dvKhoa.RowFilter = dk
            FillCombo(cmbID_khoa, dvKhoa)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Not loaded Then Exit Sub
            Dim dvKhoaHoc As DataView
            dvKhoaHoc = clsLop.Khoa_hoc.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            dvKhoaHoc.RowFilter = dk
            FillCombo(cmbKhoa_hoc, dvKhoaHoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            Dim dvCN As DataView
            dvCN = clsLop.Chuyen_nganh_dao_tao().DefaultView

            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbID_chuyen_nganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
            dvCN.RowFilter = dk
            FillCombo(cmbID_chuyen_nganh, dvCN)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbID_he1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_he1.SelectedIndexChanged
        Try
            If Not loaded Then Exit Sub
            Dim dvKhoa As DataView
            dvKhoa = clsLop.Khoa().DefaultView
            Dim dk As String = "1=1"
            If cmbID_he1.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he1.SelectedValue
            dvKhoa.RowFilter = dk
            FillCombo(cmbID_khoa1, dvKhoa)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbID_khoa1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_khoa1.SelectedIndexChanged
        Try
            If Not loaded Then Exit Sub
            Dim dvKhoaHoc As DataView
            dvKhoaHoc = clsLop.Khoa_hoc.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he1.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he1.SelectedValue
            If cmbID_khoa1.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa1.SelectedValue
            dvKhoaHoc.RowFilter = dk
            FillCombo(cmbKhoa_hoc1, dvKhoaHoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbKhoa_hoc1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc1.SelectedIndexChanged
        Try
            Dim dvCN As DataView
            dvCN = clsLop.Chuyen_nganh_dao_tao().DefaultView

            Dim dk As String = "1=1"
            If cmbID_he1.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he1.SelectedValue
            If cmbID_khoa1.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa1.SelectedValue
            If cmbKhoa_hoc1.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc1.SelectedValue
            If cmbID_chuyen_nganh1.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbID_chuyen_nganh1.SelectedValue
            dvCN.RowFilter = dk
            FillCombo(cmbID_chuyen_nganh1, dvCN)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckValidate() Then
            If mclsCTDT.CheckExist_ChuongTrinhDaoTao(cmbID_he1.SelectedValue, cmbID_khoa1.SelectedValue, cmbKhoa_hoc1.SelectedValue, cmbID_chuyen_nganh1.SelectedValue, cmbSo1.SelectedIndex + 1) = 0 Then
                ' Lấy thông tin cua chương trình đào tạo nguồn
                Dim objCTDT_old As ESSChuongTrinhDaoTao = mclsCTDT.GetChuongTrinhDaoTao(cmbID_he.SelectedValue, cmbID_khoa.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_chuyen_nganh.SelectedValue)
                Dim objCTDT As New ESSChuongTrinhDaoTao

                objCTDT.ID_he = cmbID_he1.SelectedValue
                objCTDT.ID_khoa = cmbID_khoa1.SelectedValue
                objCTDT.Khoa_hoc = cmbKhoa_hoc1.SelectedValue
                objCTDT.ID_chuyen_nganh = cmbID_chuyen_nganh1.SelectedValue
                objCTDT.Ten_he = cmbID_he1.Text
                objCTDT.Ten_khoa = cmbID_khoa1.Text
                objCTDT.Chuyen_nganh = cmbID_chuyen_nganh1.Text
                objCTDT.So = cmbSo1.SelectedIndex + 1
                objCTDT.So_ky_hoc = objCTDT_old.So_ky_hoc
                objCTDT.So_hoc_trinh = objCTDT_old.So_hoc_trinh
                'Insert vao Database
                Dim ID_dt_new As Integer = 0
                ID_dt_new = mclsCTDT.ThemMoi_ESSChuongTrinhDaoTao(objCTDT)
                'Insert vao object
                objCTDT.ID_dt = ID_dt_new
                mclsCTDT.Add(objCTDT)
                'Sao chep chuong trinh dao tao chi tiet
                mclsCTDT.HienThi_ESSCTDTChiTiet(objCTDT_old.ID_dt)
                Dim idx_old, idx_new As Integer
                idx_old = mclsCTDT.Tim_idx(objCTDT_old.ID_dt)
                idx_new = mclsCTDT.Tim_idx(ID_dt_new)
                If idx_old >= 0 And idx_new >= 0 Then
                    For i As Integer = 0 To mclsCTDT.ESSChuongTrinhDaoTao(idx_old).ESSChuongTrinhDaoTaoChiTiet.Count - 1
                        Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
                        objCTDTChiTiet = mclsCTDT.ESSChuongTrinhDaoTao(idx_old).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(i)
                        objCTDTChiTiet.ID_dt = ID_dt_new
                        If cmbKien_thuc.SelectedValue > 0 Then
                            If objCTDTChiTiet.Kien_thuc = cmbKien_thuc.SelectedValue Then
                                'Insert vao object
                                mclsCTDT.ESSChuongTrinhDaoTao(idx_new).ESSChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                                'Insert vao database
                                mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet)
                            End If
                        Else
                            'Insert vao object
                            mclsCTDT.ESSChuongTrinhDaoTao(idx_new).ESSChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                            'Insert vao database
                            mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet)
                        End If
                    Next

                    ' Sao chép ràng buộc Học phần
                    For j As Integer = 0 To mclsCTDT.ESSChuongTrinhDaoTao(idx_old).ChuongTrinhDaoTaoRangBuoc.Count - 1
                        Dim objCTDTRB As New ESSChuongTrinhDaoTaoMonHocRangBuoc
                        objCTDTRB = mclsCTDT.ESSChuongTrinhDaoTao(idx_old).ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(j)
                        objCTDTRB.ID_dt = ID_dt_new
                        mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoRangBuoc(objCTDTRB)
                    Next
                    ' Sao chép nhóm tự chọn
                    For k As Integer = 0 To mclsCTDT.ESSChuongTrinhDaoTao(idx_old).ESSChuongTrinhDaoTaoNhomTuChon.Count - 1
                        Dim objCTDT_NhomTuChon As New ESSChuongTrinhDaoTaoNhomTuChon
                        objCTDT_NhomTuChon = mclsCTDT.ESSChuongTrinhDaoTao(idx_old).ESSChuongTrinhDaoTaoNhomTuChon.ESSChuongTrinhDaoTaoNhomTuChon(k)
                        objCTDT_NhomTuChon.ID_dt = ID_dt_new
                        mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoNhomTuChon(objCTDT_NhomTuChon)
                    Next
                End If

                Me.Tag = "1"
                Me.Close()
            Else
                Thongbao("Chương trình đào tạo này đã tồn tại, bạn không thể tạo được")
            End If
        End If
    End Sub

    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Tag = "0"
        Me.Close()
    End Sub
End Class