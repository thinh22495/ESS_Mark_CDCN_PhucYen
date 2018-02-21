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
    Public Class LoaiPhong_Bussines
        Private arrLoaiPhong As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Loại phòng
            Try
                arrLoaiPhong = New ArrayList
                Dim objLoaiPhong_dal As New LoaiPhong_DataAccess
                Dim dt As DataTable = objLoaiPhong_dal.HienThi_ESSLoaiPhong_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objLoaiPhong As New ESSLoaiPhong
                        objLoaiPhong = Mapping(dt.Rows(i))
                        arrLoaiPhong.Add(objLoaiPhong)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucLoaiPhong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_loai_phong", GetType(Integer))
                dt.Columns.Add("Ten_loai_phong", GetType(String))
                For i As Integer = 0 To arrLoaiPhong.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objLoaiPhong As ESSLoaiPhong = CType(arrLoaiPhong(i), ESSLoaiPhong)
                    row("ID_loai_phong") = objLoaiPhong.ID_loai_phong
                    row("Ten_loai_phong") = objLoaiPhong.Ten_loai_phong
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiPhong(ByVal objLoaiPhong As ESSLoaiPhong) As Integer
            Try
                Dim obj As LoaiPhong_DataAccess = New LoaiPhong_DataAccess
                Return obj.ThemMoi_ESSLoaiPhong(objLoaiPhong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiPhong(ByVal objLoaiPhong As ESSLoaiPhong, ByVal ID_loai_phong As Integer) As Integer
            Try
                Dim obj As LoaiPhong_DataAccess = New LoaiPhong_DataAccess
                Return obj.CapNhat_ESSLoaiPhong(objLoaiPhong, ID_loai_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiPhong(ByVal ID_loai_phong As Integer) As Integer
            Try
                Dim obj As LoaiPhong_DataAccess = New LoaiPhong_DataAccess
                Return obj.Xoa_ESSLoaiPhong(ID_loai_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiPhong(ByVal ID_loai_phong As Integer) As Boolean
            Try
                Dim obj As LoaiPhong_DataAccess = New LoaiPhong_DataAccess
                obj.CheckExist_LoaiPhong(ID_loai_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drLoaiPhong As DataRow) As ESSLoaiPhong
            Dim result As ESSLoaiPhong
            Try
                result = New ESSLoaiPhong
                If drLoaiPhong("ID_loai_phong").ToString() <> "" Then result.ID_loai_phong = CType(drLoaiPhong("ID_loai_phong").ToString(), Integer)
                result.Ma_loai = drLoaiPhong("Ma_loai").ToString()
                result.Ten_loai_phong = drLoaiPhong("Ten_loai_phong").ToString()
                result.Thuc_hanh = drLoaiPhong("Thuc_hanh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
