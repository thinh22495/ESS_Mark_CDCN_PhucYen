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
    Public Class Khoa_Bussines
        Private arrKhoa As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Khoa
            Try
                arrKhoa = New ArrayList
                Dim objKhoa_dal As New Khoa_DataAccess
                Dim dt As DataTable = objKhoa_dal.HienThi_ESSKhoa_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objKhoa As New ESSKhoa
                        objKhoa = Mapping(dt.Rows(i))
                        arrKhoa.Add(objKhoa)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucKhoa() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            For i As Integer = 0 To arrKhoa.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objKhoa As ESSKhoa = CType(arrKhoa(i), ESSKhoa)
                row("ID_khoa") = objKhoa.ID_khoa
                row("Ten_khoa") = objKhoa.Ten_khoa
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function ThemMoi_ESSKhoa(ByVal objKhoa As ESSKhoa) As Integer
            Try
                Dim obj As Khoa_DataAccess = New Khoa_DataAccess
                Return obj.ThemMoi_ESSKhoa(objKhoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKhoa(ByVal objKhoa As ESSKhoa, ByVal ID_khoa As Integer) As Integer
            Try
                Dim obj As Khoa_DataAccess = New Khoa_DataAccess
                Return obj.CapNhat_ESSKhoa(objKhoa, ID_khoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKhoa(ByVal ID_khoa As Integer) As Integer
            Try
                Dim obj As Khoa_DataAccess = New Khoa_DataAccess
                Return obj.Xoa_ESSKhoa(ID_khoa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drKhoa As DataRow) As ESSKhoa
            Dim result As ESSKhoa
            Try
                result = New ESSKhoa
                If drKhoa("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drKhoa("ID_khoa").ToString(), Integer)
                result.Ma_khoa = drKhoa("Ma_khoa").ToString()
                result.Ten_khoa = drKhoa("Ten_khoa").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
