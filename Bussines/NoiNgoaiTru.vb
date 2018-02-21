'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, 25 May, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class NoiNgoaiTru_Bussines
        Inherits ESSNoiNgoaiTru
#Region "Var"
        Private aNoiNgoaiTrus As ArrayList
#End Region
#Region "Initialize"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_sv As Integer)
            Try
                aNoiNgoaiTrus = New ArrayList
                Dim obj As New NoiNgoaiTru_DataAccess
                Dim dtNoiNgoaiTru As DataTable = obj.HienThi_ESSNoiNgoaiTru(ID_sv)
                Dim objNoiNgoaiTru As New ESSNoiNgoaiTru
                Dim dr As DataRow = Nothing
                For Each dr In dtNoiNgoaiTru.Rows
                    objNoiNgoaiTru = MappingSV(dr)
                    aNoiNgoaiTrus.Add(objNoiNgoaiTru)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                aNoiNgoaiTrus = New ArrayList
                Dim obj As New NoiNgoaiTru_DataAccess
                Dim dtNoiNgoaiTru As DataTable = obj.HienThi_ESSNoiNgoaiTru(ID_lops)
                Dim objNoiNgoaiTru As New ESSNoiNgoaiTru
                Dim dr As DataRow = Nothing
                For Each dr In dtNoiNgoaiTru.Rows
                    objNoiNgoaiTru = Mapping(dr)
                    aNoiNgoaiTrus.Add(objNoiNgoaiTru)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As ESSNoiNgoaiTru
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSNoiNgoaiTru(ID_sv, Tu_ngay)
                Dim objNoiNgoaiTru As ESSNoiNgoaiTru = Nothing
                If dt.Rows.Count > 0 Then
                    objNoiNgoaiTru = Mapping(dt.Rows(0))
                End If
                Return objNoiNgoaiTru
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhongKyTucXa() As DataTable
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSPhongKyTucXa()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNoiNgoaiTru() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_phong_ktx", GetType(Integer))
                dt.Columns.Add("So_phong_ktx", GetType(String))
                dt.Columns.Add("ID_tang", GetType(Integer))
                dt.Columns.Add("ID_nha_KTX", GetType(Integer))
                dt.Columns.Add("Ten_nha", GetType(String))
                dt.Columns.Add("Dia_chi", GetType(String))
                dt.Columns.Add("Dien_thoai", GetType(String))
                dt.Columns.Add("Ten_chu_ho", GetType(String))
                dt.Columns.Add("Ghi_chu", GetType(String))
                dt.Columns.Add("Noi_o", GetType(String))
                dt.Columns.Add("Trang_thai", GetType(Integer))
                dt.Columns.Add("ID_phuong", GetType(Integer))
                dt.Columns.Add("Ten_phuong", GetType(String))
                For i As Integer = 0 To aNoiNgoaiTrus.Count - 1
                    Dim objNoiNgoaiTru As ESSNoiNgoaiTru = CType(aNoiNgoaiTrus(i), ESSNoiNgoaiTru)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = objNoiNgoaiTru.ID_sv
                    row("ID_lop") = objNoiNgoaiTru.ID_lop
                    row("Ten_lop") = objNoiNgoaiTru.Ten_lop
                    row("Ma_sv") = objNoiNgoaiTru.Ma_sv
                    row("Ho_ten") = objNoiNgoaiTru.Ho_ten
                    row("Ngay_sinh") = Format(objNoiNgoaiTru.Ngay_sinh.Date.ToString)
                    If objNoiNgoaiTru.Den_ngay <> Nothing Then row("Den_ngay") = objNoiNgoaiTru.Den_ngay
                    If objNoiNgoaiTru.Tu_ngay <> Nothing Then row("Tu_ngay") = objNoiNgoaiTru.Tu_ngay
                    row("ID_phong_ktx") = objNoiNgoaiTru.ID_phong_ktx
                    row("So_phong_ktx") = objNoiNgoaiTru.So_phong_KTX
                    row("ID_tang") = objNoiNgoaiTru.ID_tang
                    row("Ho_ten") = objNoiNgoaiTru.Ho_ten
                    row("Ngay_sinh") = Format(objNoiNgoaiTru.Ngay_sinh.Date.ToString)
                    row("ID_nha_KTX") = objNoiNgoaiTru.ID_nha_KTX
                    row("Ten_nha") = objNoiNgoaiTru.Ten_nha
                    row("Dia_chi") = objNoiNgoaiTru.Dia_chi
                    row("Dien_thoai") = objNoiNgoaiTru.Dien_thoai
                    row("Ten_chu_ho") = objNoiNgoaiTru.Ten_chu_ho
                    row("Ghi_chu") = objNoiNgoaiTru.Ghi_chu
                    row("Noi_o") = objNoiNgoaiTru.Noi_o
                    row("Trang_thai") = objNoiNgoaiTru.Trang_thai
                    If objNoiNgoaiTru.Trang_thai = -1 Then
                        dt.Rows.Add(row)
                    Else
                        If objNoiNgoaiTru.Trang_thai = 1 Then
                            dt.Rows.Add(row)
                        End If
                    End If
                    row("ID_phuong") = objNoiNgoaiTru.ID_phuong
                    row("Ten_phuong") = objNoiNgoaiTru.Ten_phuong
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load noi ngoai tru cua mot sinh vien
        Public Function HienThi_ESSNoiNgoaiTruSV() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("So_phong_ktx", GetType(String))
                dt.Columns.Add("Dia_chi", GetType(String))
                dt.Columns.Add("Ghi_chu", GetType(String))
                dt.Columns.Add("Trang_thai", GetType(Integer))
                dt.Columns.Add("Noi_o", GetType(String))
                For i As Integer = 0 To aNoiNgoaiTrus.Count - 1
                    Dim ESSNoiNgoaiTru As ESSNoiNgoaiTru = CType(aNoiNgoaiTrus(i), ESSNoiNgoaiTru)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = ESSNoiNgoaiTru.ID_sv
                    If ESSNoiNgoaiTru.Den_ngay <> Nothing Then row("Den_ngay") = ESSNoiNgoaiTru.Den_ngay
                    If ESSNoiNgoaiTru.Tu_ngay <> Nothing Then row("Tu_ngay") = ESSNoiNgoaiTru.Tu_ngay
                    row("So_phong_ktx") = ESSNoiNgoaiTru.So_phong_KTX
                    row("Dia_chi") = ESSNoiNgoaiTru.Dia_chi
                    row("Ghi_chu") = ESSNoiNgoaiTru.Ghi_chu
                    row("Trang_thai") = ESSNoiNgoaiTru.Trang_thai
                    row("Noi_o") = ESSNoiNgoaiTru.Noi_o & ESSNoiNgoaiTru.So_phong_KTX & ESSNoiNgoaiTru.Dia_chi
                    If ESSNoiNgoaiTru.Trang_thai = -1 Then
                        dt.Rows.Add(row)
                    Else
                        If ESSNoiNgoaiTru.Trang_thai = 1 Then
                            dt.Rows.Add(row)
                        End If
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function loadNoiNgoaiTruSinhVien(ByVal id_sv As Integer) As DataTable
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.HienThi_ESSNoiNgoaiTruSinhVien(id_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNoiNgoaiTru_DanhSach() As ESSNoiNgoaiTru
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSNoiNgoaiTru_DanhSach()
                Dim objNoiNgoaiTru As ESSNoiNgoaiTru = Nothing
                If dt.Rows.Count > 0 Then
                    objNoiNgoaiTru = Mapping(dt.Rows(0))
                End If
                Return objNoiNgoaiTru
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNgoaiTru(ByVal objNoiNgoaiTru As ESSNoiNgoaiTru) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.ThemMoi_ESSNgoaiTru(objNoiNgoaiTru)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNoiTru(ByVal objNoiNgoaiTru As ESSNoiNgoaiTru) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.ThemMoi_ESSNoiTru(objNoiNgoaiTru)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru(ByVal objNoiNgoaiTru As ESSNoiNgoaiTru, ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.CapNhat_ESSNoiNgoaiTru(objNoiNgoaiTru, ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru_TrangThaiAll(ByVal ID_sv As Integer, ByVal Trang_thai As Integer) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.CapNhat_ESSNoiNgoaiTru_TrangThaiAll(ID_sv, Trang_thai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru_TrangThai(ByVal ID_sv As Integer, ByVal Tu_ngay As Date, ByVal Trang_thai As Integer) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.CapNhat_ESSNoiNgoaiTru_TrangThai(ID_sv, Tu_ngay, Trang_thai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru_DenNgay(ByVal ID_sv As Integer, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.CapNhat_ESSNoiNgoaiTru_DenNgay(ID_sv, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.Xoa_ESSNoiNgoaiTru(ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Boolean
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.CheckExist_NoiNgoaiTru(ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svNoiNgoaiTru(ByVal ID_sv As Integer) As Boolean
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                Return obj.CheckExist_NoiNgoaiTru(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim obj As NoiNgoaiTru_DataAccess = New NoiNgoaiTru_DataAccess
                obj.GetMaxID_NoiNgoaiTru(ID_sv, Tu_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drNoiNgoaiTru As DataRow) As ESSNoiNgoaiTru
            Dim result As ESSNoiNgoaiTru
            Try
                result = New ESSNoiNgoaiTru
                If drNoiNgoaiTru("ID_lop").ToString() <> "" Then result.ID_lop = CType(drNoiNgoaiTru("ID_lop").ToString(), Integer)
                result.Ten_lop = drNoiNgoaiTru("Ten_lop").ToString()
                If drNoiNgoaiTru("ID_sv").ToString() <> "" Then result.ID_sv = CType(drNoiNgoaiTru("ID_sv").ToString(), Integer)
                result.Ma_sv = drNoiNgoaiTru("Ma_sv").ToString()
                result.Ho_ten = drNoiNgoaiTru("Ho_ten").ToString()
                If drNoiNgoaiTru("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drNoiNgoaiTru("Ngay_sinh").ToString(), Date)
                If drNoiNgoaiTru("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drNoiNgoaiTru("Tu_ngay").ToString(), Date)
                If drNoiNgoaiTru("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drNoiNgoaiTru("Den_ngay").ToString(), Date)
                If drNoiNgoaiTru("ID_phong_ktx").ToString() <> "" Then result.ID_phong_ktx = CType(drNoiNgoaiTru("ID_phong_ktx").ToString(), Integer)
                result.So_phong_KTX = drNoiNgoaiTru("So_phong_KTX").ToString()
                If drNoiNgoaiTru("ID_tang").ToString() <> "" Then result.ID_tang = CType(drNoiNgoaiTru("ID_tang").ToString(), Integer)
                If drNoiNgoaiTru("ID_nha_KTX").ToString() <> "" Then result.ID_nha_KTX = CType(drNoiNgoaiTru("ID_nha_KTX").ToString(), Integer)
                result.Ten_nha = drNoiNgoaiTru("Ten_nha").ToString()
                result.Dia_chi = drNoiNgoaiTru("Dia_chi").ToString()
                result.Dien_thoai = drNoiNgoaiTru("Dien_thoai").ToString()
                result.Ten_chu_ho = drNoiNgoaiTru("Ten_chu_ho").ToString()
                result.Ghi_chu = drNoiNgoaiTru("Ghi_chu").ToString()
                result.Noi_o = drNoiNgoaiTru("Noi_o").ToString()
                If drNoiNgoaiTru("Trang_thai").ToString() <> "" Then result.Trang_thai = CType(drNoiNgoaiTru("Trang_thai").ToString(), Integer)
                If drNoiNgoaiTru("ID_phuong").ToString() <> "" Then result.ID_phuong = CType(drNoiNgoaiTru("ID_phuong").ToString(), Integer)
                result.Ten_phuong = drNoiNgoaiTru("Ten_phuong").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingSV(ByVal drNoiNgoaiTru As DataRow) As ESSNoiNgoaiTru
            Dim result As ESSNoiNgoaiTru
            Try
                result = New ESSNoiNgoaiTru
                If drNoiNgoaiTru("ID_sv").ToString() <> "" Then result.ID_sv = CType(drNoiNgoaiTru("ID_sv").ToString(), Integer)
                If drNoiNgoaiTru("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drNoiNgoaiTru("Tu_ngay").ToString(), Date)
                If drNoiNgoaiTru("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drNoiNgoaiTru("Den_ngay").ToString(), Date)
                result.So_phong_KTX = drNoiNgoaiTru("So_phong_KTX").ToString()
                result.Dia_chi = drNoiNgoaiTru("Dia_chi").ToString()
                result.Ghi_chu = drNoiNgoaiTru("Ghi_chu").ToString()
                If drNoiNgoaiTru("Trang_thai").ToString() <> "" Then result.Trang_thai = IIf(drNoiNgoaiTru("Trang_thai") = True, 1, 0)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
