'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class NhomDoiTuong_Bussines
        Inherits ESSNhomDoiTuong

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load Danh mục nhom Doi tuong 
        Public Function HienThi_ESSNhomDoiTuong() As DataTable
            Try
                Dim obj As NhomDoiTuong_DataAccess = New NhomDoiTuong_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSNhomDoiTuong()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNhomDoiTuong(ByVal ID_nhom_dt As Integer) As ESSNhomDoiTuong
            Try
                Dim obj As NhomDoiTuong_DataAccess = New NhomDoiTuong_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSNhomDoiTuong(ID_nhom_dt)
                Dim objNhomDoiTuong As ESSNhomDoiTuong = Nothing
                If dt.Rows.Count > 0 Then
                    objNhomDoiTuong = Mapping(dt.Rows(0))
                End If
                Return objNhomDoiTuong
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNhomDoiTuong(ByVal objNhomDoiTuong As ESSNhomDoiTuong) As Integer
            Try
                Dim obj As NhomDoiTuong_DataAccess = New NhomDoiTuong_DataAccess
                Return obj.ThemMoi_ESSNhomDoiTuong(objNhomDoiTuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNhomDoiTuong(ByVal objNhomDoiTuong As ESSNhomDoiTuong, ByVal ID_nhom_dt As Integer) As Integer
            Try
                Dim obj As NhomDoiTuong_DataAccess = New NhomDoiTuong_DataAccess
                Return obj.CapNhat_ESSNhomDoiTuong(objNhomDoiTuong, ID_nhom_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNhomDoiTuong(ByVal ID_nhom_dt As Integer) As Integer
            Try
                Dim obj As NhomDoiTuong_DataAccess = New NhomDoiTuong_DataAccess
                Return obj.Xoa_ESSNhomDoiTuong(ID_nhom_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drNhomDoiTuong As DataRow) As ESSNhomDoiTuong
            Dim result As ESSNhomDoiTuong
            Try
                result = New ESSNhomDoiTuong
                If drNhomDoiTuong("ID_nhom_dt").ToString() <> "" Then result.ID_nhom_dt = CType(drNhomDoiTuong("ID_nhom_dt").ToString(), Integer)
                result.Ma_nhom = drNhomDoiTuong("Ma_nhom").ToString()
                result.Ten_nhom = drNhomDoiTuong("Ten_nhom").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
