Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachThuctap_Bussines
        Private arrDanhSachThuctap As ArrayList
        'Private arrDanhSachSinhVien As ArrayList

#Region "Initialize"
        Sub New(ByVal ID_lops As String)
            Try
                arrDanhSachThuctap = New ArrayList
                Dim obj As New DanhSachThuctap_DataAccess
                Dim dtThucTap As DataTable = obj.DanhSachThuctap_HienThi_DanhSach(ID_lops)
                Dim objThucTap As New ESSDanhSachThuctap
                Dim dr As DataRow = Nothing
                For Each dr In dtThucTap.Rows
                    objThucTap = Mapping(dr)
                    arrDanhSachThuctap.Add(objThucTap)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub Add(ByVal DSN As ESSDanhSachThuctap)
            arrDanhSachThuctap.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDanhSachThuctap.RemoveAt(idx)
        End Sub

        Public Function DanhSachThucTap() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon1", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv2", GetType(String))
            dt.Columns.Add("Ho_ten2", GetType(String))
            dt.Columns.Add("Ten_lop2", GetType(String))
            dt.Columns.Add("ID_noi_thuc_tap", GetType(String))
            dt.Columns.Add("Ma_noi_thuc_tap", GetType(String))
            dt.Columns.Add("Noi_thuc_tap", GetType(String))
            dt.Columns.Add("Dia_chi_thuc_tap", GetType(String))
            dt.Columns.Add("Ngay_sinh2", GetType(String))
            dt.Columns.Add("ID_SVs", GetType(String))
            Dim ID_svs As String = "-1"
            For i As Integer = 0 To arrDanhSachThuctap.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_sv") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).ID_sv
                row("Ma_sv2") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Ma_sv
                row("Ho_ten2") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Ho_ten
                row("Ten_lop2") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Ten_lop
                row("ID_noi_thuc_tap") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).ID_noi_thuc_tap
                row("Ma_noi_thuc_tap") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Ma_noi_thuc_tap
                row("Noi_thuc_tap") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Ten_noi_thuc_tap
                row("Dia_chi_thuc_tap") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Dia_chi_thuc_tap
                row("Ngay_sinh2") = CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).Ngay_sinh
                row("Chon1") = False
                ID_svs += "," & CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).ID_sv
                dt.Rows.Add(row)
            Next
            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("ID_svs") = ID_svs
            End If
            dt.AcceptChanges()
            Return dt
        End Function

        Public Function ThemMoi_ESSDanhSachThuctap(ByVal objDanhSachThuctap As ESSDanhSachThuctap) As Integer
            Try
                Dim obj As DanhSachThuctap_DataAccess = New DanhSachThuctap_DataAccess
                Return obj.ThemMoi_ESSDanhSachThuctap(objDanhSachThuctap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachThuctap(ByVal objDanhSachThuctap As ESSDanhSachThuctap, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachThuctap_DataAccess = New DanhSachThuctap_DataAccess
                Return obj.CapNhat_ESSDanhSachThuctap(objDanhSachThuctap, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachThuctap(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachThuctap_DataAccess = New DanhSachThuctap_DataAccess
                Tim_idx(ID_sv)
                Return obj.Xoa_ESSDanhSachThuctap(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping(ByVal drThucTap As DataRow) As ESSDanhSachThuctap
            Dim result As ESSDanhSachThuctap
            Try
                result = New ESSDanhSachThuctap
                If drThucTap("ID_SV").ToString() <> "" Then result.ID_sv = CType(drThucTap("ID_SV").ToString(), Integer)
                If drThucTap("ID_noi_thuc_tap").ToString() <> "" Then result.ID_noi_thuc_tap = CType(drThucTap("ID_noi_thuc_tap").ToString(), Integer)
                result.Ma_noi_thuc_tap = drThucTap("Ma_noi_thuc_tap").ToString()
                result.Ten_noi_thuc_tap = drThucTap("Noi_thuc_tap").ToString()
                result.Dia_chi_thuc_tap = drThucTap("Dia_chi_thuc_tap").ToString()
                result.Ma_sv = drThucTap("Ma_sv").ToString()
                result.Ho_ten = drThucTap("Ho_ten").ToString()
                If Not IsDBNull(drThucTap("Ngay_sinh")) Then
                    result.Ngay_sinh = CType(drThucTap("Ngay_sinh"), Date)
                End If
                result.Ten_lop = drThucTap("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachThuctap.Count - 1
                If CType(arrDanhSachThuctap(i), ESSDanhSachThuctap).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
