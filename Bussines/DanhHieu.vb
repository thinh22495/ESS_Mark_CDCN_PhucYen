'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 10, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhHieu_Bussines
        Private arrDanhHieu As New ArrayList

#Region "Initialize"
        Public Sub New()
            Try
                Dim obj As DanhHieu_DataAccess = New DanhHieu_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhHieu_DanhSach()
                Dim objDH As ESSDanhHieu
                Dim dr As DataRow
                For Each dr In dt.Rows
                    objDH = New ESSDanhHieu
                    objDH = Mapping(dr)
                    arrDanhHieu.Add(objDH)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function Danh_hieu(ByVal TBCMR As Double) As String
            For i As Integer = 0 To arrDanhHieu.Count - 1
                If CType(arrDanhHieu(i), ESSDanhHieu).Tu_diem <= TBCMR And _
                    CType(arrDanhHieu(i), ESSDanhHieu).Den_diem >= TBCMR Then
                    Return CType(arrDanhHieu(i), ESSDanhHieu).Danh_hieu
                End If
            Next
            Return ""
        End Function
        Public Function Danh_hieu(ByVal ID_danh_hieu As Integer) As String
            For i As Integer = 0 To arrDanhHieu.Count - 1
                If CType(arrDanhHieu(i), ESSDanhHieu).ID_danh_hieu = ID_danh_hieu Then
                    Return CType(arrDanhHieu(i), ESSDanhHieu).Danh_hieu
                End If
            Next
            Return ""
        End Function
        Public Function ID_danh_hieu(ByVal TBCMR As Double) As Integer
            For i As Integer = 0 To arrDanhHieu.Count - 1
                If CType(arrDanhHieu(i), ESSDanhHieu).Tu_diem <= TBCMR And _
                    CType(arrDanhHieu(i), ESSDanhHieu).Den_diem >= TBCMR Then
                    Return CType(arrDanhHieu(i), ESSDanhHieu).ID_danh_hieu
                End If
            Next
            Return -1
        End Function

        Public Function ThemMoi_ESSDanhHieu(ByVal objDanhHieu As ESSDanhHieu) As Integer
            Try
                Dim obj As DanhHieu_DataAccess = New DanhHieu_DataAccess
                Return obj.ThemMoi_ESSDanhHieu(objDanhHieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhHieu(ByVal objDanhHieu As ESSDanhHieu, ByVal ID_danh_hieu As Integer) As Integer
            Try
                Dim obj As DanhHieu_DataAccess = New DanhHieu_DataAccess
                Return obj.CapNhat_ESSDanhHieu(objDanhHieu, ID_danh_hieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhHieu(ByVal ID_danh_hieu As Integer) As Integer
            Try
                Dim obj As DanhHieu_DataAccess = New DanhHieu_DataAccess
                Return obj.Xoa_ESSDanhHieu(ID_danh_hieu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhHieu As DataRow) As ESSDanhHieu
            Dim result As ESSDanhHieu
            Try
                result = New ESSDanhHieu
                If drDanhHieu("ID_danh_hieu").ToString() <> "" Then result.ID_danh_hieu = CType(drDanhHieu("ID_danh_hieu").ToString(), Integer)
                result.Danh_hieu = drDanhHieu("Danh_hieu").ToString()
                If drDanhHieu("Tu_diem").ToString() <> "" Then result.Tu_diem = CType(drDanhHieu("Tu_diem").ToString(), Integer)
                If drDanhHieu("Den_diem").ToString() <> "" Then result.Den_diem = CType(drDanhHieu("Den_diem").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
