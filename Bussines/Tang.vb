'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class Tang_Bussines
        Private arrTang As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Chuc vu
            Try
                arrTang = New ArrayList
                Dim objTang_dal As New Tang_DataAccess
                Dim dt As DataTable = objTang_dal.HienThi_ESSTang_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objTang As New ESSTang
                        objTang = Mapping(dt.Rows(i))
                        arrTang.Add(objTang)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucTang() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_TANG", GetType(Integer))
                dt.Columns.Add("Ten_tang", GetType(String))
                For i As Integer = 0 To arrTang.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objTang As ESSTang = CType(arrTang(i), ESSTang)
                    row("ID_TANG") = objTang.ID_TANG
                    row("Ten_tang") = objTang.Ten_tang
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSTang(ByVal objTang As ESSTang) As Integer
            Try
                Dim obj As Tang_DataAccess = New Tang_DataAccess
                Return obj.ThemMoi_ESSTang(objTang)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTang(ByVal objTang As ESSTang, ByVal ID_TANG As Integer) As Integer
            Try
                Dim obj As Tang_DataAccess = New Tang_DataAccess
                Return obj.CapNhat_ESSTang(objTang, ID_TANG)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSTang(ByVal ID_TANG As Integer) As Integer
            Try
                Dim obj As Tang_DataAccess = New Tang_DataAccess
                Return obj.Xoa_ESSTang(ID_TANG)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Tang(ByVal ID_TANG As Integer) As Boolean
            Try
                Dim obj As Tang_DataAccess = New Tang_DataAccess
                obj.CheckExist_Tang(ID_TANG)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drTang As DataRow) As ESSTang
            Dim result As ESSTang
            Try
                result = New ESSTang
                If drTang("ID_TANG").ToString() <> "" Then result.ID_TANG = CType(drTang("ID_TANG").ToString(), Integer)
                result.Ma_tang = drTang("Ma_tang").ToString()
                result.Ten_tang = drTang("Ten_tang").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
