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
    Public Class ChucDanhCanBo_Bussines
        Private arrChucDanhCanBo As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Chuc danh can bo
            Try
                arrChucDanhCanBo = New ArrayList
                Dim objChucDanhCanBo_dal As New ChucDanhCanBo_DataAccess
                Dim dt As DataTable = objChucDanhCanBo_dal.HienThi_ESSChucDanhCanBo_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objChucDanhCanBo As New ESSChucDanhCanBo
                        objChucDanhCanBo = Mapping(dt.Rows(i))
                        arrChucDanhCanBo.Add(objChucDanhCanBo)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ESSChucDanhCanBo() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_chuc_vu", GetType(Integer))
            dt.Columns.Add("Chuc_vu", GetType(String))
            For i As Integer = 0 To arrChucDanhCanBo.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objChucDanhCanBo As ESSChucDanhCanBo = CType(arrChucDanhCanBo(i), ESSChucDanhCanBo)
                row("ID_chuc_vu") = objChucDanhCanBo.ID_chuc_danh
                row("Chuc_vu") = objChucDanhCanBo.Chuc_danh
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function ThemMoi_ESSChucDanhCanBo(ByVal objChucDanhCanBo As ESSChucDanhCanBo) As Integer
            Try
                Dim obj As ChucDanhCanBo_DataAccess = New ChucDanhCanBo_DataAccess
                Return obj.ThemMoi_ESSChucDanhCanBo(objChucDanhCanBo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChucDanhCanBo(ByVal objChucDanhCanBo As ESSChucDanhCanBo, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim obj As ChucDanhCanBo_DataAccess = New ChucDanhCanBo_DataAccess
                Return obj.CapNhat_ESSChucDanhCanBo(objChucDanhCanBo, ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChucDanhCanBo(ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim obj As ChucDanhCanBo_DataAccess = New ChucDanhCanBo_DataAccess
                Return obj.Xoa_ESSChucDanhCanBo(ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drChucDanhCanBo As DataRow) As ESSChucDanhCanBo
            Dim result As ESSChucDanhCanBo
            Try
                result = New ESSChucDanhCanBo
                If drChucDanhCanBo("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drChucDanhCanBo("ID_chuc_danh").ToString(), Integer)
                result.Ma_chuc_danh = drChucDanhCanBo("Ma_chuc_danh").ToString()
                result.Chuc_danh = drChucDanhCanBo("Chuc_danh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
