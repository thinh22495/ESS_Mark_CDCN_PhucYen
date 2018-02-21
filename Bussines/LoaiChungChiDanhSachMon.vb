Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class LoaiChungChiDanhSachMon_Bussines
        Private arrLoaiChungChiDanhSachSinhVien As ArrayList

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                Dim obj As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDSSinhVienChungChi(ID_lops)
                Dim objLoaiChungChiDanhSachMon As ESSLoaiChungChiDanhSachMon = Nothing
                Dim dr As DataRow = Nothing
                arrLoaiChungChiDanhSachSinhVien = New ArrayList
                For Each dr In dt.Rows
                    objLoaiChungChiDanhSachMon = Mapping_ChungChi(dr)
                    arrLoaiChungChiDanhSachSinhVien.Add(objLoaiChungChiDanhSachMon)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"

        Public Function HienThi_ESSLoaiChungChiDanhSachMon(ByVal ID_dt As Integer) As DataTable
            Try
                Dim obj As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSLoaiChungChiDanhSachMon(ID_dt)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal id_dt As Integer) As Integer
            Try
                Dim obj As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Return obj.ThemMoi_ESSLoaiChungChiDanhSachMon(ID_chung_chi, ID_mon, id_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Return obj.Xoa_ESSLoaiChungChiDanhSachMon(ID_chung_chi, ID_mon, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChungChiTheoSinhVien(ByVal obj As ESSLoaiChungChiDanhSachMon) As Integer
            Try
                Dim objDal As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Return objDal.ThemMoi_ESSChungChiTheoSinhVien(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChungChiTheoSinhVien(ByVal obj As ESSLoaiChungChiDanhSachMon) As Integer
            Try
                Dim objDal As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Return objDal.Xoa_ESSChungChiTheoSinhVien(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Tim_idx(ByVal ID_sv As Integer, ByVal ID_chung_chi As Integer) As Integer
            For i As Integer = 0 To arrLoaiChungChiDanhSachSinhVien.Count - 1
                If CType(arrLoaiChungChiDanhSachSinhVien(i), ESSLoaiChungChiDanhSachMon).ID_sv = ID_sv And CType(arrLoaiChungChiDanhSachSinhVien(i), ESSLoaiChungChiDanhSachMon).ID_chung_chi = ID_chung_chi Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function DSSV_ChuaXetTheoLanXet(ByVal ID_chung_chi As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_hang", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("ID_chung_chi", GetType(Integer))
                dt.Columns.Add("Lan_xet", GetType(Integer))

                dt.Columns.Add("Hoi_dong_thi", GetType(String))
                dt.Columns.Add("So_vao_so", GetType(String))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("Ten_tinh", GetType(String))
                For i As Integer = 0 To arrLoaiChungChiDanhSachSinhVien.Count - 1
                    Dim ds As ESSLoaiChungChiDanhSachMon = CType(arrLoaiChungChiDanhSachSinhVien(i), ESSLoaiChungChiDanhSachMon)
                    If Tim_idx(ds.ID_sv, ID_chung_chi) = -1 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Ten_lop") = ds.Ten_lop
                        row("TBCHT") = ds.TBCHT
                        row("Xep_hang") = ds.Xep_hang
                        row("ID_xep_loai") = ds.ID_xep_loai
                        row("ID_chung_chi") = ds.ID_chung_chi
                        row("Lan_xet") = ds.Lan_xet

                        row("Hoi_dong_thi") = ds.Hoi_dong_thi
                        row("So_vao_so") = ds.So_vao_so
                        row("Tu_ngay") = ds.Tu_ngay
                        row("Den_ngay") = ds.Den_ngay
                        row("Ten_tinh") = ds.Noi_sinh
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DSSV_DaXetTheoLanXet(ByVal ID_chung_chi As Integer, ByVal Lan_xet As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_hang", GetType(String))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("ID_chung_chi", GetType(Integer))
                dt.Columns.Add("Lan_xet", GetType(Integer))
                dt.Columns.Add("Ly_do", GetType(String))
                dt.Columns.Add("Hoi_dong_thi", GetType(String))
                dt.Columns.Add("So_vao_so", GetType(String))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("Ten_tinh", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                For i As Integer = 0 To arrLoaiChungChiDanhSachSinhVien.Count - 1
                    Dim ds As ESSLoaiChungChiDanhSachMon = CType(arrLoaiChungChiDanhSachSinhVien(i), ESSLoaiChungChiDanhSachMon)
                    If ds.ID_chung_chi = ID_chung_chi And ds.Lan_xet = Lan_xet Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Ten_lop") = ds.Ten_lop
                        row("TBCHT") = ds.TBCHT
                        row("Xep_hang") = ds.Xep_hang
                        row("ID_xep_loai") = ds.ID_xep_loai
                        row("ID_chung_chi") = ds.ID_chung_chi
                        row("Lan_xet") = ds.Lan_xet
                        row("Ly_do") = ""

                        row("Hoi_dong_thi") = ds.Hoi_dong_thi
                        row("So_vao_so") = ds.So_vao_so
                        row("Tu_ngay") = ds.Tu_ngay
                        row("Den_ngay") = ds.Den_ngay
                        row("Ten_tinh") = ds.Noi_sinh
                        row("Ten_he") = ds.Ten_he
                        row("Chuyen_nganh") = ds.Chuyen_nganh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping_ChungChi(ByVal drLoaiChungChiDanhSachMon As DataRow) As ESSLoaiChungChiDanhSachMon
            Dim result As ESSLoaiChungChiDanhSachMon
            Try
                result = New ESSLoaiChungChiDanhSachMon
                If drLoaiChungChiDanhSachMon("ID_chung_chi").ToString() <> "" Then result.ID_chung_chi = CType(drLoaiChungChiDanhSachMon("ID_chung_chi").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("ID_sv").ToString() <> "" Then result.ID_sv = CType(drLoaiChungChiDanhSachMon("ID_sv").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("ID_dt").ToString() <> "" Then result.ID_dt = CType(drLoaiChungChiDanhSachMon("ID_dt").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("Lan_xet").ToString() <> "" Then result.Lan_xet = CType(drLoaiChungChiDanhSachMon("Lan_xet").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drLoaiChungChiDanhSachMon("ID_xep_loai").ToString(), Integer)
                If drLoaiChungChiDanhSachMon("TBCHT").ToString() <> "" Then result.TBCHT = CType(drLoaiChungChiDanhSachMon("TBCHT").ToString(), Double)
                If drLoaiChungChiDanhSachMon("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drLoaiChungChiDanhSachMon("Ngay_sinh").ToString(), Date)
                result.Xep_hang = drLoaiChungChiDanhSachMon("Xep_hang").ToString()
                result.Ma_sv = drLoaiChungChiDanhSachMon("Ma_sv").ToString()
                result.Ho_ten = drLoaiChungChiDanhSachMon("Ho_ten").ToString()
                result.Ten_lop = drLoaiChungChiDanhSachMon("Ten_lop").ToString()
                result.Hoi_dong_thi = drLoaiChungChiDanhSachMon("Hoi_dong_thi").ToString()
                result.Noi_sinh = drLoaiChungChiDanhSachMon("Ten_tinh").ToString()
                result.So_vao_so = drLoaiChungChiDanhSachMon("So_vao_so").ToString()
                result.Ten_he = drLoaiChungChiDanhSachMon("Ten_he").ToString()
                result.Chuyen_nganh = drLoaiChungChiDanhSachMon("Chuyen_nganh").ToString()
                result.Gioi_tinh = drLoaiChungChiDanhSachMon("Gioi_tinh").ToString()

                If drLoaiChungChiDanhSachMon("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drLoaiChungChiDanhSachMon("Tu_ngay").ToString(), Date)
                If drLoaiChungChiDanhSachMon("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drLoaiChungChiDanhSachMon("Den_ngay").ToString(), Date)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region

        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Return obj.CapNhat_SoVaoSo(So_vao_so, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ThongTin_ChungChi(ByVal ID_SV As Integer, ByVal Hoi_dong_thi As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As LoaiChungChiDanhSachMon_DataAccess = New LoaiChungChiDanhSachMon_DataAccess
                Return obj.CapNhat_ThongTin_ChungChi(ID_SV, Hoi_dong_thi, Tu_ngay, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
