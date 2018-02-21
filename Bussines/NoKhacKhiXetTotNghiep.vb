Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class NoKhacKhiXetTotNghiep_Bussines
        Private arrDanhSachNoKhacXetTotNghiep As ArrayList

#Region "Initialize"
        Sub New(ByVal ID_lops As String)
            Try
                arrDanhSachNoKhacXetTotNghiep = New ArrayList
                Dim obj As New NoKhacKhiXetTotNghiep_DataAccess
                Dim dt As DataTable = obj.DanhSachNoKhacKhiXetTotNghiep_HienThi_DanhSach(ID_lops)
                Dim objEn As New ESSNoKhacKhiXetTotNghiep
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objEn = Mapping(dr)
                    arrDanhSachNoKhacXetTotNghiep.Add(objEn)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub Add(ByVal DSN As ESSNoKhacKhiXetTotNghiep)
            arrDanhSachNoKhacXetTotNghiep.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDanhSachNoKhacXetTotNghiep.RemoveAt(idx)
        End Sub

        Public Function DanhSachNoKhacKhiXetTotNghiep() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(String))
            dt.Columns.Add("ID_SVs", GetType(String))
            Dim ID_svs As String = "-1"
            For i As Integer = 0 To arrDanhSachNoKhacXetTotNghiep.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_sv") = CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).ID_sv
                row("Ma_sv") = CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).Ma_sv
                row("Ho_ten") = CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).Ho_ten
                row("Ten_lop") = CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).Ten_lop
                row("Ly_do") = CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).Ly_do
                row("Ngay_sinh") = CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).Ngay_sinh
                row("Chon") = False
                ID_svs += "," & CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).ID_sv
                dt.Rows.Add(row)
            Next
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("ID_svs") = ID_svs
            End If
            dt.AcceptChanges()
            Return dt
        End Function

        Public Function ThemMoi_ESSNoKhacKhiXetTotNghiep(ByVal objEn As ESSNoKhacKhiXetTotNghiep) As Integer
            Try
                Dim obj As NoKhacKhiXetTotNghiep_DataAccess = New NoKhacKhiXetTotNghiep_DataAccess
                Return obj.ThemMoi_ESSNoKhacKhiXetTotNghiep(objEn)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoKhacKhiXetTotNghiep(ByVal objEn As ESSNoKhacKhiXetTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As NoKhacKhiXetTotNghiep_DataAccess = New NoKhacKhiXetTotNghiep_DataAccess
                Return obj.CapNhat_ESSNoKhacKhiXetTotNghiep(objEn, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNoKhacKhiXetTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As NoKhacKhiXetTotNghiep_DataAccess = New NoKhacKhiXetTotNghiep_DataAccess
                Tim_idx(ID_sv)
                Return obj.Xoa_ESSNoKhacKhiXetTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping(ByVal dr As DataRow) As ESSNoKhacKhiXetTotNghiep
            Dim result As ESSNoKhacKhiXetTotNghiep
            Try
                result = New ESSNoKhacKhiXetTotNghiep
                If dr("ID_SV").ToString() <> "" Then result.ID_sv = CType(dr("ID_SV").ToString(), Integer)
                result.Ly_do = dr("Ly_do").ToString()
                result.Ma_sv = dr("Ma_sv").ToString()
                result.Ho_ten = dr("Ho_ten").ToString()
                result.Ngay_sinh = dr("Ngay_sinh").ToString()
                result.Ten_lop = dr("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachNoKhacXetTotNghiep.Count - 1
                If CType(arrDanhSachNoKhacXetTotNghiep(i), ESSNoKhacKhiXetTotNghiep).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace