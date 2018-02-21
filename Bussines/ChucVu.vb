'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 17, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ChucVu_Bussines
        Private arrChucVu As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Chuc vu
            Try
                arrChucVu = New ArrayList
                Dim objChucVu_dal As New ChucVu_DataAccess
                Dim dt As DataTable = objChucVu_dal.HienThi_ESSChucVu_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objChucVu As New ESSChucVu
                        objChucVu = Mapping(dt.Rows(i))
                        arrChucVu.Add(objChucVu)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucChucVu() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_chuc_vu", GetType(Integer))
            dt.Columns.Add("Chuc_vu", GetType(String))
            For i As Integer = 0 To arrChucVu.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objChucVu As ESSChucVu = CType(arrChucVu(i), ESSChucVu)
                row("ID_chuc_vu") = objChucVu.ID_chuc_vu
                row("Chuc_vu") = objChucVu.Chuc_vu
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function ThemMoi_ESSChucVu(ByVal objChucVu As ESSChucVu) As Integer
            Try
                Dim obj As ChucVu_DataAccess = New ChucVu_DataAccess
                Return obj.ThemMoi_ESSChucVu(objChucVu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChucVu(ByVal objChucVu As ESSChucVu, ByVal ID_chuc_vu As Integer) As Integer
            Try
                Dim obj As ChucVu_DataAccess = New ChucVu_DataAccess
                Return obj.CapNhat_ESSChucVu(objChucVu, ID_chuc_vu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChucVu(ByVal ID_chuc_vu As Integer) As Integer
            Try
                Dim obj As ChucVu_DataAccess = New ChucVu_DataAccess
                Return obj.Xoa_ESSChucVu(ID_chuc_vu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drChucVu As DataRow) As ESSChucVu
            Dim result As ESSChucVu
            Try
                result = New ESSChucVu
                If drChucVu("ID_chuc_vu").ToString() <> "" Then result.ID_chuc_vu = CType(drChucVu("ID_chuc_vu").ToString(), Integer)
                result.Ma_chuc_vu = drChucVu("Ma_chuc_vu").ToString()
                result.Chuc_vu = drChucVu("Chuc_vu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
