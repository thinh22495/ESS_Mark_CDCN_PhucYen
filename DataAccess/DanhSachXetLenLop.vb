Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachXetLenLop_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSachTotNghiep_DanhSach(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@ID_lops", ID_lops)
                para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_DanhSachXetLenLop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachHocTiepNganh2_DanhSach(ByVal ID_nganh As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                Return Connect.SelectTableSP("STU_DanhSachXetLenLopNganh2_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachHocTiep2Nganh_DanhSach(ByVal ID_nganh As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                Return Connect.SelectTableSP("STU_DanhSachXetLenLop2Nganh_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachNgungHocThoiHoc_HienThi_DanhSach(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Loai_qd As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@ID_lops", ID_lops)
                para(4) = New SqlParameter("@Loai_qd", Loai_qd)
                Return Connect.SelectTableSP("STU_DanhSachNgungHocThoiHoc_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function ThemMoi_ESSQuyetDinhThoiHoc(ByVal obj As ESSDanhSachXetLenLop) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@So_qd", obj.So_qd)
                para(3) = New SqlParameter("@Ngay_qd", obj.Ngay_qd)
                para(4) = New SqlParameter("@Loai_qd", obj.Loai_qd)
                para(5) = New SqlParameter("@Ly_do", obj.Ly_do)
                Dim dt As DataTable = Connect.SelectTableSP("MARK_QuyetDinhThoiHoc_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyetDinhThoiHoc(ByVal obj As ESSDanhSachXetLenLop, ByVal ID_qd As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_qd", ID_qd)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@So_qd", obj.So_qd)
                para(4) = New SqlParameter("@Ngay_qd", obj.Ngay_qd)
                para(5) = New SqlParameter("@Loai_qd", obj.Loai_qd)
                para(6) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("MARK_QuyetDinhThoiHoc_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyetDinhThoiHoc(ByVal ID_qd As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_qd", ID_qd)
                Return Connect.ExecuteSP("MARK_QuyetDinhThoiHoc_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Danh sach chi tiet
        Public Function ThemMoi_ESSQuyetDinhThoiHocChiTiet(ByVal obj As ESSDanhSachXetLenLop) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_qd", obj.ID_qd)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@ID_lop_cu", obj.ID_lop_cu)
                para(3) = New SqlParameter("@ID_lop_moi", obj.ID_lop_moi)
                para(4) = New SqlParameter("@Loai_qd", obj.Loai_qd)
                Return Connect.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyetDinhThoiHocChiTiet(ByVal obj As ESSDanhSachXetLenLop, ByVal ID_qd As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_qd", ID_qd)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_lop_cu", obj.ID_lop_cu)
                para(3) = New SqlParameter("@ID_lop_moi", obj.ID_lop_moi)
                Return Connect.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyetDinhThoiHocChiTiet(ByVal ID_qd As Integer, ByVal ID_sv As Integer, ByVal ID_lop_cu As Integer, ByVal Loai_QD As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_qd", ID_qd)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_lop_cu", ID_lop_cu)
                para(3) = New SqlParameter("@Loai_QD", Loai_QD)
                Return Connect.ExecuteSP("MARK_QuyetDinhThoiHocChiTiet_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

        Public Function Load_DanhSachSinhVien_ID_SVs_HenThi_DanhSAch(ByVal ID_lops As String, ByVal ID_svs As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                para(1) = New SqlParameter("@ID_svs", ID_svs)
                Return Connect.SelectTableSP("sp_STU_DanhSachSinhVien_ID_SVs_XetLenLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Load_DanhSachDaXetLenLop_DanhSach(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer) As DataTable
        '    Try
        '        Dim para(6) As SqlParameter
        '        para(0) = New SqlParameter("@ID_he", ID_he)
        '        para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
        '        para(2) = New SqlParameter("@ID_khoa", ID_khoa)
        '        para(3) = New SqlParameter("@ID_lops", ID_lops)
        '        para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
        '        para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
        '        para(6) = New SqlParameter("@Lan_canh_bao", Lan_canh_bao)
        '        Return Connect.SelectTableSP("sp_STU_DanhSachXetLenLop_HienThi", para)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Sub Insert_XetLenLop_KhiTongHop(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer, ByVal Ly_do As String, ByVal So_TCTL As Double, ByVal TBCTL As Double, ByVal So_TCHT As Double, ByVal TBCHT_ky As Double, ByVal Duyet As Integer, ByVal XepHang_Nam_DaoTao As Integer, ByVal Ly_do_cac_ky As String)
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@Lan_canh_bao", Lan_canh_bao)
                para(4) = New SqlParameter("@Ly_do", Ly_do)
                para(5) = New SqlParameter("@So_TCTL", So_TCTL)
                para(6) = New SqlParameter("@TBCTL", TBCTL)
                para(7) = New SqlParameter("@So_TCHT", So_TCHT)
                para(8) = New SqlParameter("@TBCHT_ky", TBCHT_ky)
                para(9) = New SqlParameter("@XepHang_Nam_DaoTao", XepHang_Nam_DaoTao)
                para(10) = New SqlParameter("@Ly_do_cac_ky", Ly_do_cac_ky)
                Connect.ExecuteSP("Mark_XetLenLop_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update_XetLenLop_KhiDuyet(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer)
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@Lan_canh_bao", Lan_canh_bao)
                Connect.ExecuteSP("Mark_XetLenLop_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete_XetLenLop_DaDuyet(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer)
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@Lan_canh_bao", Lan_canh_bao)
                Connect.ExecuteSP("Mark_XetLenLop_Del", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete_XetLenLop_KhiTongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer)
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Lan_canh_bao", Lan_canh_bao)
                Connect.ExecuteSP("Mark_XetLenLop_Delete", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function DanhSachDaXet_LanCanhBao_Duyet(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Duyet As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(3) = New SqlParameter("@dsID_lop", ID_lops)
                para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(6) = New SqlParameter("@Duyet", Duyet)
                Return Connect.SelectTableSP("Mark_DiemXetLenLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function DanhSachDaXet_TongHop(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer, ByVal Duyet As Integer) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(3) = New SqlParameter("@dsID_lop", ID_lops)
                para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(6) = New SqlParameter("@Lan_canh_bao", Lan_canh_bao)
                para(7) = New SqlParameter("@Duyet", Duyet)
                Return Connect.SelectTableSP("Mark_DiemXetLenLop_TongHop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_DaXetThoiHoc(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("MARK_XETLENLOP_DANHSACH_THOIHOC", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_CacLanCanhBao_TheoSinhVien(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("MARK_XETLENLOP_THEOSINHVIEN", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub Delete_XetLenLop_KhiTongHop_TheoSV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String)
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lops", ID_lops)
                Connect.ExecuteSP("MARK_XetLenLop_Delete_TheoSinhVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        'Function getLan_canh_bao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As Integer
        '    Try
        '        Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)
        '        Dim mNam_hoc1 As String = Nam_hoc
        '        Dim mHoc_ky1 As Integer = Hoc_ky
        '        Dim mNam_hoc2 As String = Nam_hoc
        '        Dim mHoc_ky2 As Integer = 0
        '        If mHoc_ky1 = 2 Then
        '            mHoc_ky1 = 1
        '            mHoc_ky2 = 2
        '            mNam_hoc2 = Nam - 1 & "-" & Nam
        '        Else ' Hoc ky cu thuoc nam hoc cu
        '            mNam_hoc1 = Nam - 1 & "-" & Nam
        '            mHoc_ky1 = 2
        '            mHoc_ky2 = 1
        '            mNam_hoc2 = Nam - 1 & "-" & Nam
        '        End If
        '        Dim para(2) As SqlParameter
        '        para(0) = New SqlParameter("@Hoc_ky", mHoc_ky1)
        '        para(1) = New SqlParameter("@Nam_hoc", mNam_hoc1)
        '        para(2) = New SqlParameter("@ID_sv", ID_sv)

        '        Dim dt As DataTable = Connect.SelectTableSP("MARK_XetLenLop_LanCanhBao", para)
        '        If dt.Rows.Count > 0 Then
        '            Return dt.Rows(0)("Lan_canh_bao")
        '        Else
        '            para(2) = New SqlParameter
        '            para(0) = New SqlParameter("@Hoc_ky", mHoc_ky2)
        '            para(1) = New SqlParameter("@Nam_hoc", mNam_hoc2)
        '            para(2) = New SqlParameter("@ID_sv", ID_sv)
        '            dt = Connect.SelectTableSP("MARK_XetLenLop_LanCanhBao", para)
        '            If dt.Rows.Count > 0 Then
        '                If dt.Rows(0)("Lan_canh_bao") = 0 Then
        '                    Return 0
        '                ElseIf dt.Rows(0)("Lan_canh_bao") = 1 Then
        '                    Return 0
        '                ElseIf dt.Rows(0)("Lan_canh_bao") = 2 Then
        '                    Return 1
        '                End If
        '            Else
        '                Return 0
        '            End If
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Function getLan_canh_bao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByRef Ly_do_cu As String) As Integer
            Try
                Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)
                Dim mNam_hoc1 As String = Nam_hoc
                Dim mHoc_ky1 As Integer = Hoc_ky
                If mHoc_ky1 = 2 Then
                    mHoc_ky1 = 1
                Else ' Hoc ky cu thuoc nam hoc cu
                    mNam_hoc1 = Nam - 1 & "-" & Nam
                    mHoc_ky1 = 2
                End If
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", mHoc_ky1)
                para(1) = New SqlParameter("@Nam_hoc", mNam_hoc1)
                para(2) = New SqlParameter("@ID_sv", ID_sv)

                Dim dt As DataTable = Connect.SelectTableSP("MARK_XetLenLop_LanCanhBao", para)
                If dt.Rows.Count > 0 Then
                    Ly_do_cu = dt.Rows(0)("Ly_do_cac_ky").ToString
                    Return dt.Rows(0)("Lan_canh_bao")
                Else
                    Ly_do_cu = ""
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TongHop_LanCanhBao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dk", dk)
                Return Connect.SelectTableSP("MARK_TongHop_XetLenLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TongHop_LanCanhBao_Khoa(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dk", dk)
                Return Connect.SelectTableSP("MARK_TongHop_XetLenLop_TheoKhoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TongHop_LanCanhBao_Lop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dk", dk)
                Return Connect.SelectTableSP("MARK_TongHop_XetLenLop_TheoLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
