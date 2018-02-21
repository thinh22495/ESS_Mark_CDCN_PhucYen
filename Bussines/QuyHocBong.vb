'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class QuyHocBong_Bussines
        Private arrQuyHocBong As New ArrayList
        Private arrLoaiQuy As New ArrayList ' Loại quỹ học bổng
#Region "Initialize"
        Public Sub New()

        End Sub
        Public Sub New(ByVal LoaiQuy_hb As Boolean)
            Try
                Dim obj_DataAccess As New QuyHocBong_DataAccess
                Dim dt As DataTable
                dt = obj_DataAccess.HienThi_ESSLoaiQuy_DanhSach()
                Dim obj As New ESSLoaiQuy
                For Each dr As DataRow In dt.Rows
                    obj = Mapping_LoaiQuy(dr)
                    arrLoaiQuy.Add(obj)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim obj_DataAccess As New QuyHocBong_DataAccess
                Dim dt As DataTable
                dt = obj_DataAccess.HienThi_ESSQuyHocBong_DanhSach(Hoc_ky, Nam_hoc)
                Dim obj As New ESSQuyHocBong
                For Each dr As DataRow In dt.Rows
                    obj = Mapping(dr)
                    arrQuyHocBong.Add(obj)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        ' Danh sác quỹ học bổng
        Public Function DanhSach_QuyHocBong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_hb")
                dt.Columns.Add("ID_quy")
                dt.Columns.Add("ID_he")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Tu_khoa")
                dt.Columns.Add("Den_khoa")
                dt.Columns.Add("Sotien_ngansach")
                dt.Columns.Add("Sotien_khac")
                dt.Columns.Add("Ghi_chu")
                dt.Columns.Add("Loai_quy")
                Dim row As DataRow
                Dim obj As New ESSQuyHocBong
                For i As Integer = 0 To arrQuyHocBong.Count - 1
                    obj = CType(arrQuyHocBong(i), ESSQuyHocBong)
                    row = dt.NewRow
                    row("ID_hb") = obj.ID_hb
                    row("ID_quy") = obj.ID_quy
                    row("ID_he") = obj.ID_he
                    row("Hoc_ky") = obj.Hoc_ky
                    row("Nam_hoc") = obj.Nam_hoc
                    row("Tu_khoa") = obj.Tu_khoa
                    row("Den_khoa") = obj.Den_khoa
                    row("Sotien_ngansach") = Format(obj.Sotien_ngansach, "###,##0")
                    row("Sotien_khac") = Format(obj.Sotien_khac, "###,##0")
                    row("Ghi_chu") = obj.Ghi_chu
                    row("Loai_quy") = obj.Loai_quy
                    dt.Rows.Add(row)
                Next
                dt.DefaultView.AllowDelete = True
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Quỹ học bổng theo kỳ , năm học, hệ đào tạo,loại quỹ
        Public Function HienThi_ESSQuyHocBong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_quy As Integer) As ESSQuyHocBong
            Try
                Dim objQHB As New ESSQuyHocBong
                Dim obj As New ESSQuyHocBong
                For i As Integer = 0 To arrQuyHocBong.Count - 1
                    obj = CType(arrQuyHocBong(i), ESSQuyHocBong)
                    If obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc And obj.ID_he = ID_he And obj.ID_quy = ID_quy Then
                        objQHB = obj
                    End If
                Next
                Return objQHB
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Quỹ học bổng thữ idx trong mảng
        Public Function QuyHocBong_Index(ByVal idx As Integer) As ESSQuyHocBong
            Try
                Dim obj As New ESSQuyHocBong
                obj = CType(arrQuyHocBong(idx), ESSQuyHocBong)
                Return obj
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub UpdateMemory_QuyHocBong(ByVal obj As ESSQuyHocBong, ByVal idx As Integer)
            Try
                arrQuyHocBong(idx) = obj
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function ThemMoi_ESSQuyHocBong(ByVal objQuyHocBong As ESSQuyHocBong) As Integer
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.ThemMoi_ESSQuyHocBong(objQuyHocBong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyHocBong(ByVal objQuyHocBong As ESSQuyHocBong, ByVal ID_hb As Integer) As Integer
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.CapNhat_ESSQuyHocBong(objQuyHocBong, ID_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyHocBong(ByVal ID_hb As Integer) As Integer
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.Xoa_ESSQuyHocBong(ID_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyHocBong_Memory(ByVal Idx As Integer) As Integer
            Try
                arrQuyHocBong.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyHocBong(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_quy As Integer) As Boolean
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.CheckExist_QuyHocBong(ID_he, Hoc_ky, Nam_hoc, ID_quy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drQuyHocBong As DataRow) As ESSQuyHocBong
            Dim result As ESSQuyHocBong
            Try
                result = New ESSQuyHocBong
                If drQuyHocBong("ID_hb").ToString() <> "" Then result.ID_hb = CType(drQuyHocBong("ID_hb").ToString(), Integer)
                If drQuyHocBong("ID_quy").ToString() <> "" Then result.ID_quy = CType(drQuyHocBong("ID_quy").ToString(), Integer)
                If drQuyHocBong("ID_he").ToString() <> "" Then result.ID_he = CType(drQuyHocBong("ID_he").ToString(), Integer)
                If drQuyHocBong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drQuyHocBong("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drQuyHocBong("Nam_hoc").ToString()
                If drQuyHocBong("Tu_khoa").ToString() <> "" Then result.Tu_khoa = CType(drQuyHocBong("Tu_khoa").ToString(), Integer)
                If drQuyHocBong("Den_khoa").ToString() <> "" Then result.Den_khoa = CType(drQuyHocBong("Den_khoa").ToString(), Integer)
                result.Sotien_ngansach = drQuyHocBong("Sotien_ngansach").ToString()
                result.Sotien_khac = drQuyHocBong("Sotien_khac").ToString()
                result.Ghi_chu = drQuyHocBong("Ghi_chu").ToString()
                result.Loai_quy = drQuyHocBong("Loai_quy").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
#Region "Function loại quỹ học bổng"
        Public Function HienThi_ESSLoaiQuy() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_quy")
                dt.Columns.Add("Loai_quy")
                dt.Columns.Add("Ghi_chu")
                Dim dr As DataRow
                Dim obj As New ESSLoaiQuy
                For i As Integer = 0 To arrLoaiQuy.Count - 1
                    obj = CType(arrLoaiQuy(i), ESSLoaiQuy)
                    dr = dt.NewRow
                    dr("ID_quy") = obj.ID_quy
                    dr("Loai_quy") = obj.Loai_quy
                    dr("Ghi_chu") = obj.Ghi_chu
                    dt.Rows.Add(dr)
                Next
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiQuy(ByVal objLoaiQuy As ESSLoaiQuy) As Integer
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.ThemMoi_ESSLoaiQuy(objLoaiQuy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSObject(ByVal objLoaiQuy As ESSLoaiQuy) As Integer
            Try
                arrLoaiQuy.Add(objLoaiQuy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiQuy(ByVal objLoaiQuy As ESSLoaiQuy) As Integer
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.CapNhat_ESSLoaiQuy(objLoaiQuy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSObjec(ByVal objLoaiQuy As ESSLoaiQuy, ByVal idx As Integer) As Integer
            Try
                arrLoaiQuy(idx) = objLoaiQuy
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiQuy(ByVal ID_quy As Integer) As Integer
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.Xoa_ESSLoaiQuy(ID_quy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSObject(ByVal Idx As Integer) As Integer
            Try
                arrLoaiQuy.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svLoaiQuy(ByVal Loai_quy As String) As Boolean
            Try
                Dim obj As QuyHocBong_DataAccess = New QuyHocBong_DataAccess
                Return obj.CheckExist_LoaiQuy(Loai_quy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping_LoaiQuy(ByVal drLoaiQuy As DataRow) As ESSLoaiQuy
            Dim result As ESSLoaiQuy
            Try
                result = New ESSLoaiQuy
                If drLoaiQuy("ID_quy").ToString() <> "" Then result.ID_quy = CType(drLoaiQuy("ID_quy").ToString(), Integer)
                result.Loai_quy = drLoaiQuy("Loai_quy").ToString()
                result.Ghi_chu = drLoaiQuy("Ghi_chu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
