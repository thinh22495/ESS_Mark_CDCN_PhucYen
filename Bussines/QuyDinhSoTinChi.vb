'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, July 07, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class QuyDinhSoTinChi_Bussines
        Private arrQuyDinhSoTinChi As ArrayList

#Region "Initialize"
        Public Sub New()
            Dim obj As QuyDinhSoTinChi_DataAccess = New QuyDinhSoTinChi_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSQuyDinhSoTinChi_DanhSach()
            arrQuyDinhSoTinChi = New ArrayList
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim ph As New ESSQuyDinhSoTinChi
                ph = Mapping(dt.Rows(i))
                arrQuyDinhSoTinChi.Add(ph)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachQuyDinhSoTinChi() As DataTable
            Dim dt As New DataTable
            Try
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("Check_So_hoc_trinh_max", GetType(Boolean))
                dt.Columns.Add("Check_So_hoc_trinh_min", GetType(Boolean))
                dt.Columns.Add("Den_ngay1", GetType(Date))
                dt.Columns.Add("Den_ngay2", GetType(Date))
                dt.Columns.Add("Ky_dang_ky", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("ID_khoa", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("So_hoc_trinh_max", GetType(Integer))
                dt.Columns.Add("So_hoc_trinh_min", GetType(Integer))
                dt.Columns.Add("So_hoc_trinh_option", GetType(Integer))
                dt.Columns.Add("Tu_ngay1", GetType(Date))
                dt.Columns.Add("Tu_ngay2", GetType(Date))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                For i As Integer = 0 To arrQuyDinhSoTinChi.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objQuyDinhSoTinChi As ESSQuyDinhSoTinChi = CType(arrQuyDinhSoTinChi(i), ESSQuyDinhSoTinChi)
                    row("Chon") = False
                    row("Check_So_hoc_trinh_max") = objQuyDinhSoTinChi.KiemTra_So_hoc_trinh_max_bt
                    row("Check_So_hoc_trinh_max") = objQuyDinhSoTinChi.KiemTra_So_hoc_trinh_max_yeu
                    row("Check_So_hoc_trinh_min") = objQuyDinhSoTinChi.KiemTra_So_hoc_trinh_min_bt
                    row("Check_So_hoc_trinh_min") = objQuyDinhSoTinChi.KiemTra_So_hoc_trinh_min_yeu
                    row("Den_ngay1") = objQuyDinhSoTinChi.Den_ngay1.ToString
                    If Not IsNothing(objQuyDinhSoTinChi.Den_ngay2) Then
                        row("Den_ngay2") = objQuyDinhSoTinChi.Den_ngay2.ToString
                    End If
                    row("Ky_dang_ky") = objQuyDinhSoTinChi.Ky_dang_ky
                    row("ID_he") = objQuyDinhSoTinChi.ID_he
                    row("ID_khoa") = objQuyDinhSoTinChi.ID_khoa
                    row("Khoa_hoc") = objQuyDinhSoTinChi.Khoa_hoc
                    row("So_hoc_trinh_max") = objQuyDinhSoTinChi.So_hoc_trinh_max_bt
                    row("So_hoc_trinh_max") = objQuyDinhSoTinChi.So_hoc_trinh_max_yeu
                    row("So_hoc_trinh_min") = objQuyDinhSoTinChi.So_hoc_trinh_min_bt
                    row("So_hoc_trinh_min") = objQuyDinhSoTinChi.So_hoc_trinh_min_yeu
                    row("So_hoc_trinh_option") = objQuyDinhSoTinChi.So_hoc_trinh_option_bt
                    row("So_hoc_trinh_option") = objQuyDinhSoTinChi.So_hoc_trinh_option_yeu
                    row("Tu_ngay1") = objQuyDinhSoTinChi.Tu_ngay1.ToString
                    If Not IsNothing(objQuyDinhSoTinChi.Tu_ngay2) Then
                        row("Tu_ngay2") = objQuyDinhSoTinChi.Tu_ngay2.ToString
                    End If
                    row("Ten_he") = objQuyDinhSoTinChi.Ten_he
                    row("Ten_khoa") = objQuyDinhSoTinChi.Ten_khoa
                    row("Ten") = objQuyDinhSoTinChi.Ten_he & "," & objQuyDinhSoTinChi.Ten_khoa & "," & objQuyDinhSoTinChi.Khoa_hoc
                    dt.Rows.Add(row)
                Next
            Catch ex As Exception
            End Try
            Return dt
        End Function
        Public Function GetQuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As ESSQuyDinhSoTinChi
            Dim objQuyDinhSoTinChi As New ESSQuyDinhSoTinChi
            Dim idx As Integer = TimIdx(ID_he, ID_khoa, Khoa_hoc, Ky_dang_ky)
            Return arrQuyDinhSoTinChi(idx)
        End Function
        Public Function ThemMoi_ESSQuyDinhSoTinChi(ByVal objQuyDinhSoTinChi As ESSQuyDinhSoTinChi) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DataAccess = New QuyDinhSoTinChi_DataAccess
                Return obj.ThemMoi_ESSQuyDinhSoTinChi(objQuyDinhSoTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyDinhSoTinChi(ByVal objQuyDinhSoTinChi As ESSQuyDinhSoTinChi) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DataAccess = New QuyDinhSoTinChi_DataAccess
                Return obj.CapNhat_ESSQuyDinhSoTinChi(objQuyDinhSoTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSChonDotDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DataAccess = New QuyDinhSoTinChi_DataAccess
                Return obj.CapNhat_ESSChonDotDangKy(Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As QuyDinhSoTinChi_DataAccess = New QuyDinhSoTinChi_DataAccess
                Return obj.Xoa_ESSQuyDinhSoTinChi(ID_he, ID_khoa, Khoa_hoc, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Boolean
            Try
                Dim obj As QuyDinhSoTinChi_DataAccess = New QuyDinhSoTinChi_DataAccess
                Return obj.CheckExist_QuyDinhSoTinChi(ID_he, ID_khoa, Khoa_hoc, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drQuyDinhSoTinChi As DataRow) As ESSQuyDinhSoTinChi
            Dim result As ESSQuyDinhSoTinChi
            Try
                result = New ESSQuyDinhSoTinChi
                If drQuyDinhSoTinChi("ID_he").ToString() <> "" Then result.ID_he = CType(drQuyDinhSoTinChi("ID_he").ToString(), Integer)
                If drQuyDinhSoTinChi("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drQuyDinhSoTinChi("ID_khoa").ToString(), Integer)
                If drQuyDinhSoTinChi("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drQuyDinhSoTinChi("Khoa_hoc").ToString(), Integer)
                If drQuyDinhSoTinChi("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drQuyDinhSoTinChi("Ky_dang_ky").ToString(), Integer)
                If drQuyDinhSoTinChi("So_hoc_trinh_min_bt").ToString() <> "" Then result.So_hoc_trinh_min_bt = CType(drQuyDinhSoTinChi("So_hoc_trinh_min_bt").ToString(), Integer)
                If drQuyDinhSoTinChi("So_hoc_trinh_min_yeu").ToString() <> "" Then result.So_hoc_trinh_min_yeu = CType(drQuyDinhSoTinChi("So_hoc_trinh_min_yeu").ToString(), Integer)
                If drQuyDinhSoTinChi("So_hoc_trinh_max_bt").ToString() <> "" Then result.So_hoc_trinh_max_bt = CType(drQuyDinhSoTinChi("So_hoc_trinh_max_bt").ToString(), Integer)
                If drQuyDinhSoTinChi("So_hoc_trinh_max_yeu").ToString() <> "" Then result.So_hoc_trinh_max_yeu = CType(drQuyDinhSoTinChi("So_hoc_trinh_max_yeu").ToString(), Integer)
                If drQuyDinhSoTinChi("So_hoc_trinh_option_bt").ToString() <> "" Then result.So_hoc_trinh_option_bt = CType(drQuyDinhSoTinChi("So_hoc_trinh_option_bt").ToString(), Integer)
                If drQuyDinhSoTinChi("So_hoc_trinh_option_yeu").ToString() <> "" Then result.So_hoc_trinh_option_yeu = CType(drQuyDinhSoTinChi("So_hoc_trinh_option_yeu").ToString(), Integer)
                result.KiemTra_So_hoc_trinh_min_bt = drQuyDinhSoTinChi("Check_So_hoc_trinh_min_bt").ToString()
                result.KiemTra_So_hoc_trinh_min_yeu = drQuyDinhSoTinChi("Check_So_hoc_trinh_min_yeu").ToString()
                result.KiemTra_So_hoc_trinh_max_bt = drQuyDinhSoTinChi("Check_So_hoc_trinh_max_bt").ToString()
                result.KiemTra_So_hoc_trinh_max_yeu = drQuyDinhSoTinChi("Check_So_hoc_trinh_max_yeu").ToString()
                If drQuyDinhSoTinChi("Tu_ngay1").ToString() <> "" Then result.Tu_ngay1 = CType(drQuyDinhSoTinChi("Tu_ngay1").ToString(), Date)
                If drQuyDinhSoTinChi("Den_ngay1").ToString() <> "" Then result.Den_ngay1 = CType(drQuyDinhSoTinChi("Den_ngay1").ToString(), Date)
                If drQuyDinhSoTinChi("Tu_ngay2").ToString() <> "" Then result.Tu_ngay2 = CType(drQuyDinhSoTinChi("Tu_ngay2").ToString(), Date)
                If drQuyDinhSoTinChi("Den_ngay2").ToString() <> "" Then result.Den_ngay2 = CType(drQuyDinhSoTinChi("Den_ngay2").ToString(), Date)
                If drQuyDinhSoTinChi("Ten_he").ToString() <> "" Then result.Ten_he = CType(drQuyDinhSoTinChi("Ten_he").ToString(), String)
                If drQuyDinhSoTinChi("Ten_khoa").ToString() <> "" Then result.Ten_khoa = CType(drQuyDinhSoTinChi("Ten_khoa").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function TimIdx(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Integer
            For i As Integer = 0 To arrQuyDinhSoTinChi.Count - 1
                If CType(arrQuyDinhSoTinChi(i), ESSQuyDinhSoTinChi).ID_he = ID_he _
                And CType(arrQuyDinhSoTinChi(i), ESSQuyDinhSoTinChi).ID_khoa = ID_khoa _
                And CType(arrQuyDinhSoTinChi(i), ESSQuyDinhSoTinChi).Khoa_hoc = Khoa_hoc _
                And CType(arrQuyDinhSoTinChi(i), ESSQuyDinhSoTinChi).Ky_dang_ky = Ky_dang_ky Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
