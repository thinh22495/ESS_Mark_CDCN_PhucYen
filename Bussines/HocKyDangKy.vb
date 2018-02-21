'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, August 10, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class HocKyDangKy_Bussines
        Private arrHocKyDangKy As ArrayList
#Region "Initialize"
        Sub New()
            'Add học kỳ đăng ký
            Try
                arrHocKyDangKy = New ArrayList
                Dim obj_dal As New HocKyDangKy_DataAccess
                Dim dt As DataTable = obj_dal.HienThi_ESSHocKyDangKy_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim obj As New ESSHocKyDangKy
                        obj = Mapping(dt.Rows(i))
                        arrHocKyDangKy.Add(obj)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucHocKyDangKy() As DataTable
            Dim dt As New DataTable
            Try
                dt.Columns.Add("ky_dang_ky", GetType(Integer))
                dt.Columns.Add("Ten_ky_dang_ky", GetType(String))
                For i As Integer = 0 To arrHocKyDangKy.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim obj As ESSHocKyDangKy = CType(arrHocKyDangKy(i), ESSHocKyDangKy)
                    row("ky_dang_ky") = obj.Ky_dang_ky
                    row("Ten_ky_dang_ky") = "Đợt " & obj.Dot & " (Học kỳ " & obj.Hoc_ky & " năm học " & obj.Nam_hoc & ")"
                    dt.Rows.Add(row)
                Next
            Catch ex As Exception
            End Try
            Return dt
        End Function
        Public Function KiemTra_HocKyDangKy(ByVal objHocKyDangKy As ESSHocKyDangKy) As Boolean
            Try
                Dim obj As HocKyDangKy_DataAccess = New HocKyDangKy_DataAccess
                Return obj.KiemTra_HocKyDangKy(objHocKyDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHocKyDangKy(ByVal objHocKyDangKy As ESSHocKyDangKy) As Integer
            Try
                Dim obj As HocKyDangKy_DataAccess = New HocKyDangKy_DataAccess
                Return obj.ThemMoi_ESSHocKyDangKy(objHocKyDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHocKyDangKy(ByVal objHocKyDangKy As ESSHocKyDangKy) As Integer
            Try
                Dim obj As HocKyDangKy_DataAccess = New HocKyDangKy_DataAccess
                Return obj.CapNhat_ESSHocKyDangKy(objHocKyDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocKyDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As HocKyDangKy_DataAccess = New HocKyDangKy_DataAccess
                Return obj.Xoa_ESSHocKyDangKy(Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drHocKyDangKy As DataRow) As ESSHocKyDangKy
            Dim result As ESSHocKyDangKy
            Try
                result = New ESSHocKyDangKy
                If drHocKyDangKy("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drHocKyDangKy("Ky_dang_ky").ToString(), Integer)
                If drHocKyDangKy("Dot").ToString() <> "" Then result.Dot = CType(drHocKyDangKy("Dot").ToString(), Integer)
                If drHocKyDangKy("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drHocKyDangKy("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drHocKyDangKy("Nam_hoc").ToString()
                If drHocKyDangKy("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drHocKyDangKy("Tu_ngay").ToString(), Date)
                If drHocKyDangKy("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drHocKyDangKy("Den_ngay").ToString(), Date)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function KiemTra_HocKyDangKy_TonTai(ByVal obj As ESSHocKyDangKy) As Boolean
            Try
                Dim clsDAL As HocKyDangKy_DataAccess = New HocKyDangKy_DataAccess
                Return clsDAL.KiemTra_HocKyDangKy_TonTai(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocKyDangKy_DaTonTai(ByVal obj As ESSHocKyDangKy) As Integer
            Try
                Dim clsDAL As HocKyDangKy_DataAccess = New HocKyDangKy_DataAccess
                Return clsDAL.Xoa_ESSHocKyDangKy_DaTonTai(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace