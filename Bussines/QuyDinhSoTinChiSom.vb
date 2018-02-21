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
    Public Class QuyDinhSoTinChiSom_Bussines
        Private arrQuyDinhSoTinChiSom As ArrayList

#Region "Initialize"
        Public Sub New()
            Dim obj As QuyDinhSoTinChiSom_DataAccess = New QuyDinhSoTinChiSom_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSQuyDinhSoTinChiSom_DanhSach()
            arrQuyDinhSoTinChiSom = New ArrayList
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim ph As New ESSQuyDinhSoTinChiSom
                ph = Mapping(dt.Rows(i))
                arrQuyDinhSoTinChiSom.Add(ph)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachQuyDinhSoTinChiSom() As DataTable
            Dim dt As New DataTable
            Try
                dt.Columns.Add("Check_So_hoc_trinh_max", GetType(Boolean))
                dt.Columns.Add("Check_So_hoc_trinh_min", GetType(Boolean))
                dt.Columns.Add("Den_ngay", GetType(Date))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("ID_khoa", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("So_hoc_trinh_max", GetType(Integer))
                dt.Columns.Add("So_hoc_trinh_min", GetType(Integer))
                dt.Columns.Add("So_hoc_trinh_option", GetType(Integer))
                dt.Columns.Add("Tu_ngay", GetType(Date))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                For i As Integer = 0 To arrQuyDinhSoTinChiSom.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objQuyDinhSoTinChiSom As ESSQuyDinhSoTinChiSom = CType(arrQuyDinhSoTinChiSom(i), ESSQuyDinhSoTinChiSom)
                    row("Check_So_hoc_trinh_max") = objQuyDinhSoTinChiSom.KiemTra_So_hoc_trinh_max_bt
                    row("Check_So_hoc_trinh_max") = objQuyDinhSoTinChiSom.KiemTra_So_hoc_trinh_max_yeu
                    row("Check_So_hoc_trinh_min") = objQuyDinhSoTinChiSom.KiemTra_So_hoc_trinh_min_bt
                    row("Check_So_hoc_trinh_min") = objQuyDinhSoTinChiSom.KiemTra_So_hoc_trinh_min_yeu
                    row("Den_ngay") = objQuyDinhSoTinChiSom.Den_ngay.ToString
                    row("Hoc_ky") = objQuyDinhSoTinChiSom.Hoc_ky
                    row("Nam_hoc") = objQuyDinhSoTinChiSom.Nam_hoc
                    row("ID_he") = objQuyDinhSoTinChiSom.ID_he
                    row("ID_khoa") = objQuyDinhSoTinChiSom.ID_khoa
                    row("Khoa_hoc") = objQuyDinhSoTinChiSom.Khoa_hoc
                    row("So_hoc_trinh_max") = objQuyDinhSoTinChiSom.So_hoc_trinh_max_bt
                    row("So_hoc_trinh_max") = objQuyDinhSoTinChiSom.So_hoc_trinh_max_yeu
                    row("So_hoc_trinh_min") = objQuyDinhSoTinChiSom.So_hoc_trinh_min_bt
                    row("So_hoc_trinh_min") = objQuyDinhSoTinChiSom.So_hoc_trinh_min_yeu
                    row("So_hoc_trinh_option") = objQuyDinhSoTinChiSom.So_hoc_trinh_option_bt
                    row("So_hoc_trinh_option") = objQuyDinhSoTinChiSom.So_hoc_trinh_option_yeu
                    row("Tu_ngay") = objQuyDinhSoTinChiSom.Tu_ngay.ToString
                    row("Ten_he") = objQuyDinhSoTinChiSom.Ten_he
                    row("Ten_khoa") = objQuyDinhSoTinChiSom.Ten_khoa
                    row("Ten") = objQuyDinhSoTinChiSom.Ten_he & "," & objQuyDinhSoTinChiSom.Ten_khoa & "," & objQuyDinhSoTinChiSom.Khoa_hoc
                    dt.Rows.Add(row)
                Next
            Catch ex As Exception
            End Try
            Return dt
        End Function
        Public Function GetQuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As ESSQuyDinhSoTinChiSom
            Dim objQuyDinhSoTinChiSom As New ESSQuyDinhSoTinChiSom
            Dim idx As Integer = TimIdx(ID_he, ID_khoa, Khoa_hoc, Hoc_ky, Nam_hoc)
            Return arrQuyDinhSoTinChiSom(idx)
        End Function
        Public Function ThemMoi_ESSQuyDinhSoTinChiSom(ByVal objQuyDinhSoTinChiSom As ESSQuyDinhSoTinChiSom) As Integer
            Try
                Dim obj As QuyDinhSoTinChiSom_DataAccess = New QuyDinhSoTinChiSom_DataAccess
                Return obj.ThemMoi_ESSQuyDinhSoTinChiSom(objQuyDinhSoTinChiSom)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyDinhSoTinChiSom(ByVal objQuyDinhSoTinChiSom As ESSQuyDinhSoTinChiSom) As Integer
            Try
                Dim obj As QuyDinhSoTinChiSom_DataAccess = New QuyDinhSoTinChiSom_DataAccess
                Return obj.CapNhat_ESSQuyDinhSoTinChiSom(objQuyDinhSoTinChiSom)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSQuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As QuyDinhSoTinChiSom_DataAccess = New QuyDinhSoTinChiSom_DataAccess
                Return obj.Xoa_ESSQuyDinhSoTinChiSom(ID_he, ID_khoa, Khoa_hoc, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim obj As QuyDinhSoTinChiSom_DataAccess = New QuyDinhSoTinChiSom_DataAccess
                Return obj.CheckExist_QuyDinhSoTinChiSom(ID_he, ID_khoa, Khoa_hoc, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drQuyDinhSoTinChiSom As DataRow) As ESSQuyDinhSoTinChiSom
            Dim result As ESSQuyDinhSoTinChiSom
            Try
                result = New ESSQuyDinhSoTinChiSom
                If drQuyDinhSoTinChiSom("ID_he").ToString() <> "" Then result.ID_he = CType(drQuyDinhSoTinChiSom("ID_he").ToString(), Integer)
                If drQuyDinhSoTinChiSom("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drQuyDinhSoTinChiSom("ID_khoa").ToString(), Integer)
                If drQuyDinhSoTinChiSom("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drQuyDinhSoTinChiSom("Khoa_hoc").ToString(), Integer)
                If drQuyDinhSoTinChiSom("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drQuyDinhSoTinChiSom("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drQuyDinhSoTinChiSom("Nam_hoc").ToString()
                If drQuyDinhSoTinChiSom("So_hoc_trinh_min_bt").ToString() <> "" Then result.So_hoc_trinh_min_bt = CType(drQuyDinhSoTinChiSom("So_hoc_trinh_min_bt").ToString(), Integer)
                If drQuyDinhSoTinChiSom("So_hoc_trinh_min_yeu").ToString() <> "" Then result.So_hoc_trinh_min_yeu = CType(drQuyDinhSoTinChiSom("So_hoc_trinh_min_yeu").ToString(), Integer)
                If drQuyDinhSoTinChiSom("So_hoc_trinh_max_bt").ToString() <> "" Then result.So_hoc_trinh_max_bt = CType(drQuyDinhSoTinChiSom("So_hoc_trinh_max_bt").ToString(), Integer)
                If drQuyDinhSoTinChiSom("So_hoc_trinh_max_yeu").ToString() <> "" Then result.So_hoc_trinh_max_yeu = CType(drQuyDinhSoTinChiSom("So_hoc_trinh_max_yeu").ToString(), Integer)
                If drQuyDinhSoTinChiSom("So_hoc_trinh_option_bt").ToString() <> "" Then result.So_hoc_trinh_option_bt = CType(drQuyDinhSoTinChiSom("So_hoc_trinh_option_bt").ToString(), Integer)
                If drQuyDinhSoTinChiSom("So_hoc_trinh_option_yeu").ToString() <> "" Then result.So_hoc_trinh_option_yeu = CType(drQuyDinhSoTinChiSom("So_hoc_trinh_option_yeu").ToString(), Integer)
                result.KiemTra_So_hoc_trinh_min_bt = drQuyDinhSoTinChiSom("Check_So_hoc_trinh_min_bt").ToString()
                result.KiemTra_So_hoc_trinh_min_yeu = drQuyDinhSoTinChiSom("Check_So_hoc_trinh_min_yeu").ToString()
                result.KiemTra_So_hoc_trinh_max_bt = drQuyDinhSoTinChiSom("Check_So_hoc_trinh_max_bt").ToString()
                result.KiemTra_So_hoc_trinh_max_yeu = drQuyDinhSoTinChiSom("Check_So_hoc_trinh_max_yeu").ToString()
                If drQuyDinhSoTinChiSom("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drQuyDinhSoTinChiSom("Tu_ngay").ToString(), Date)
                If drQuyDinhSoTinChiSom("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drQuyDinhSoTinChiSom("Den_ngay").ToString(), Date)
                If drQuyDinhSoTinChiSom("Ten_he").ToString() <> "" Then result.Ten_he = CType(drQuyDinhSoTinChiSom("Ten_he").ToString(), String)
                If drQuyDinhSoTinChiSom("Ten_khoa").ToString() <> "" Then result.Ten_khoa = CType(drQuyDinhSoTinChiSom("Ten_khoa").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function TimIdx(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            For i As Integer = 0 To arrQuyDinhSoTinChiSom.Count - 1
                If CType(arrQuyDinhSoTinChiSom(i), ESSQuyDinhSoTinChiSom).ID_he = ID_he _
                And CType(arrQuyDinhSoTinChiSom(i), ESSQuyDinhSoTinChiSom).ID_khoa = ID_khoa _
                And CType(arrQuyDinhSoTinChiSom(i), ESSQuyDinhSoTinChiSom).Khoa_hoc = Khoa_hoc _
                And CType(arrQuyDinhSoTinChiSom(i), ESSQuyDinhSoTinChiSom).Nam_hoc = Nam_hoc _
                And CType(arrQuyDinhSoTinChiSom(i), ESSQuyDinhSoTinChiSom).Hoc_ky = Hoc_ky Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
