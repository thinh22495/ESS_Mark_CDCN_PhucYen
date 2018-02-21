Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class CoVanHocTap_Bussines
        Private arrDanhSachSinhVienCoVanHocTap As ArrayList

#Region "Initialize"
        Sub New(ByVal UserName As String)
            Try
                arrDanhSachSinhVienCoVanHocTap = New ArrayList
                Dim obj As New CoVanHocTap_DataAccess
                Dim dtSVCoVanHT As DataTable = obj.DanhSachSVCoVanHocTap_HienThi_DanhSach(UserName)
                Dim objSVCoVanHT As New ESSCoVanHocTap
                Dim dr As DataRow = Nothing
                For Each dr In dtSVCoVanHT.Rows
                    objSVCoVanHT = Mapping(dr)
                    arrDanhSachSinhVienCoVanHocTap.Add(objSVCoVanHT)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub Add(ByVal DSN As ESSCoVanHocTap)
            arrDanhSachSinhVienCoVanHocTap.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDanhSachSinhVienCoVanHocTap.RemoveAt(idx)
        End Sub

        Public Function DanhSachSVCoVanHocTap() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            Dim ID_svs As String = "-1"
            For i As Integer = 0 To arrDanhSachSinhVienCoVanHocTap.Count - 1
                Dim obj As ESSCoVanHocTap = CType(arrDanhSachSinhVienCoVanHocTap(i), ESSCoVanHocTap)
                Dim row As DataRow = dt.NewRow()
                row("Chon") = False
                row("ID_sv") = obj.ID_sv
                row("Ma_sv") = obj.Ma_sv
                row("Ho_ten") = obj.Ho_ten
                row("Ten_lop") = obj.Ten_lop
                row("Ngay_sinh") = obj.Ngay_sinh
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function ThemMoi_ESSCoVanHocTap(ByVal objCoVanHocTap As ESSCoVanHocTap) As Integer
            Try
                Dim obj As CoVanHocTap_DataAccess = New CoVanHocTap_DataAccess
                Return obj.ThemMoi_ESSDanhSachSVCoVanHocTap(objCoVanHocTap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSCoVanHocTap(ByVal objCoVanHocTap As ESSCoVanHocTap, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As CoVanHocTap_DataAccess = New CoVanHocTap_DataAccess
                Return obj.CapNhat_ESSDanhSachSVCoVanHocTap(objCoVanHocTap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSCoVanHocTap(ByVal Ma_sv As String, ByVal UserName As String) As Integer
            Try
                Dim obj As CoVanHocTap_DataAccess = New CoVanHocTap_DataAccess
                Return obj.Xoa_ESSDanhSachSVCoVanHocTap(Ma_sv, UserName)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping(ByVal drThucTap As DataRow) As ESSCoVanHocTap
            Dim result As ESSCoVanHocTap
            Try
                result = New ESSCoVanHocTap
                If drThucTap("ID_SV").ToString() <> "" Then result.ID_sv = CType(drThucTap("ID_SV").ToString(), Integer)
                result.UserName = drThucTap("UserName").ToString()
                result.Ma_sv = drThucTap("Ma_sv").ToString()
                result.Ho_ten = drThucTap("Ho_ten").ToString()
                If drThucTap("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = drThucTap("Ngay_sinh").ToString()
                result.Ten_lop = drThucTap("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachSinhVienCoVanHocTap.Count - 1
                If CType(arrDanhSachSinhVienCoVanHocTap(i), ESSCoVanHocTap).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace