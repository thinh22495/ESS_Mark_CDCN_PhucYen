'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class MonHoc_Bussines
        Private arrMonHoc As New ArrayList
#Region "Initialize"
        Public Sub New()
            Try
                Dim obj As MonHoc_DataAccess = New MonHoc_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSMonHoc_DanhSach
                Dim objsvMonHoc As ESSMonHoc = Nothing
                Dim dr As DataRow = Nothing
                arrMonHoc = New ArrayList
                For Each dr In dt.Rows
                    objsvMonHoc = Mapping(dr)
                    arrMonHoc.Add(objsvMonHoc)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_he As Integer)
            Try
                Dim obj As MonHoc_DataAccess = New MonHoc_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSMonHoc_He_DanhSach(ID_he)
                Dim objsvMonHoc As ESSMonHoc = Nothing
                Dim dr As DataRow = Nothing
                arrMonHoc = New ArrayList
                For Each dr In dt.Rows
                    objsvMonHoc = Mapping(dr)
                    arrMonHoc.Add(objsvMonHoc)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_mon As Integer, ByVal ID_dt As Integer)
            Try

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer)
            Try
                Dim obj As MonHoc_DataAccess = New MonHoc_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSMonHoc_ChungChi_DanhSach(ID_dt)
                Dim objsvMonHoc As ESSMonHoc = Nothing
                Dim dr As DataRow = Nothing
                arrMonHoc = New ArrayList
                For Each dr In dt.Rows
                    objsvMonHoc = Mapping(dr)
                    arrMonHoc.Add(objsvMonHoc)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal mon As ESSMonHoc)
            arrMonHoc.Add(mon)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrMonHoc.RemoveAt(idx)
        End Sub
#End Region
#Region "Functions And Subs"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrMonHoc.Count
            End Get
        End Property
        Public Function DanhSachHocPhan() As DataTable
            Dim dtHP As New DataTable
            dtHP.Columns.Add("Chon", GetType(Boolean))
            dtHP.Columns.Add("ID_mon", GetType(Integer))
            dtHP.Columns.Add("Ky_hieu", GetType(String))
            dtHP.Columns.Add("Ten_mon", GetType(String))
            dtHP.Columns.Add("Ten_tieng_anh", GetType(String))
            dtHP.Columns.Add("ID_bm", GetType(Integer))
            dtHP.Columns.Add("ID_he", GetType(Integer))
            dtHP.Columns.Add("ID_nhom_hp", GetType(Integer))
            For i As Integer = 0 To arrMonHoc.Count - 1
                Dim row As DataRow = dtHP.NewRow()
                row("Chon") = 0
                row("ID_mon") = CType(arrMonHoc(i), ESSMonHoc).ID_mon
                row("Ky_hieu") = CType(arrMonHoc(i), ESSMonHoc).Ky_hieu
                row("Ten_mon") = CType(arrMonHoc(i), ESSMonHoc).Ten_mon
                row("Ten_tieng_anh") = CType(arrMonHoc(i), ESSMonHoc).Ten_tieng_anh
                row("ID_bm") = CType(arrMonHoc(i), ESSMonHoc).ID_bm
                row("ID_he") = CType(arrMonHoc(i), ESSMonHoc).ID_he
                row("ID_nhom_hp") = CType(arrMonHoc(i), ESSMonHoc).ID_nhom
                dtHP.Rows.Add(row)
            Next
            dtHP.AcceptChanges()
            dtHP.DefaultView.Sort = "Ten_mon"
            Return dtHP
        End Function

        Public Function DanhSachMonHoc_NhomHocPhan(ByVal ID_nhom_hp As Integer) As DataTable
            Dim dtHP As New DataTable
            dtHP.Columns.Add("Chon", GetType(Boolean))
            dtHP.Columns.Add("ID_mon", GetType(Integer))
            dtHP.Columns.Add("Ky_hieu", GetType(String))
            dtHP.Columns.Add("Ten_mon", GetType(String))
            dtHP.Columns.Add("Ten_tieng_anh", GetType(String))
            dtHP.Columns.Add("ID_bm", GetType(Integer))
            dtHP.Columns.Add("ID_he", GetType(Integer))
            dtHP.Columns.Add("ID_nhom_hp", GetType(Integer))
            For i As Integer = 0 To arrMonHoc.Count - 1
                If CType(arrMonHoc(i), ESSMonHoc).ID_nhom <> ID_nhom_hp Then Continue For
                Dim row As DataRow = dtHP.NewRow()
                row("Chon") = 0
                row("ID_mon") = CType(arrMonHoc(i), ESSMonHoc).ID_mon
                row("Ky_hieu") = CType(arrMonHoc(i), ESSMonHoc).Ky_hieu
                row("Ten_mon") = CType(arrMonHoc(i), ESSMonHoc).Ten_mon
                row("Ten_tieng_anh") = CType(arrMonHoc(i), ESSMonHoc).Ten_tieng_anh
                row("ID_bm") = CType(arrMonHoc(i), ESSMonHoc).ID_bm
                row("ID_he") = CType(arrMonHoc(i), ESSMonHoc).ID_he
                row("ID_nhom_hp") = CType(arrMonHoc(i), ESSMonHoc).ID_nhom
                dtHP.Rows.Add(row)
            Next
            dtHP.AcceptChanges()
            dtHP.DefaultView.Sort = "Ten_mon"
            Return dtHP
        End Function

        Public Function ThemMoi_ESSMonHoc(ByVal objMonHoc As ESSMonHoc) As Integer
            Try
                Dim obj As MonHoc_DataAccess = New MonHoc_DataAccess
                Return obj.ThemMoi_ESSMonHoc(objMonHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSMonHoc(ByVal objMonHoc As ESSMonHoc, ByVal ID_mon As Integer) As Integer
            Try
                Dim obj As MonHoc_DataAccess = New MonHoc_DataAccess
                Return obj.CapNhat_ESSMonHoc(objMonHoc, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSMonHoc(ByVal ID_mon As Integer) As Integer
            Try
                Dim obj As MonHoc_DataAccess = New MonHoc_DataAccess
                Return obj.Xoa_ESSMonHoc(ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drMonHoc As DataRow) As ESSMonHoc
            Dim result As ESSMonHoc
            Try
                result = New ESSMonHoc
                If drMonHoc("ID_mon").ToString() <> "" Then result.ID_mon = CType(drMonHoc("ID_mon").ToString(), Integer)
                result.Ky_hieu = drMonHoc("Ky_hieu").ToString()
                result.Ten_mon = drMonHoc("Ten_mon").ToString()
                result.Ten_tieng_anh = drMonHoc("Ten_tieng_anh").ToString()
                If drMonHoc("ID_bm").ToString() <> "" Then result.ID_bm = CType(drMonHoc("ID_bm").ToString(), Integer)
                If drMonHoc("ID_nhom_hp").ToString() <> "" Then result.ID_nhom = CType(drMonHoc("ID_nhom_hp").ToString(), Integer)
                If drMonHoc("ID_he_dt").ToString() <> "" Then result.ID_he = CType(drMonHoc("ID_he_dt").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function CheckExistKyHieu(ByVal ky_hieu As String, ByVal ID_he As Integer) As Boolean
            Try
                For i As Integer = 0 To arrMonHoc.Count - 1
                    If CType(arrMonHoc(i), ESSMonHoc).Ky_hieu = ky_hieu And CType(arrMonHoc(i), ESSMonHoc).ID_he = ID_he Then
                        Return True
                    End If
                Next
                Return False
            Catch ex As Exception
            End Try
        End Function
        Public Function GetMonHoc(ByVal ID_mon As Integer) As ESSMonHoc
            Dim idx As Integer = SearchIndex(ID_mon)
            Return arrMonHoc(idx)
        End Function
        Private Function SearchIndex(ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To arrMonHoc.Count - 1
                If CType(arrMonHoc(i), ESSMonHoc).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region

#Region "Danh Sach Mon Hoc"
        Public Function DanhSachMonHoc() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_tieng_anh", GetType(String))
            dt.Columns.Add("ID_bm", GetType(Integer))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_nhom_hp", GetType(Integer))

            For i As Integer = 0 To arrMonHoc.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objMonHoc As ESSMonHoc = CType(arrMonHoc(i), ESSMonHoc)
                row("Chon") = False
                row("ID_mon") = objMonHoc.ID_mon
                row("Ky_hieu") = objMonHoc.Ky_hieu
                row("Ten_mon") = objMonHoc.Ten_mon
                row("Ten_tieng_anh") = objMonHoc.Ten_tieng_anh
                row("ID_bm") = objMonHoc.ID_bm
                row("ID_he") = objMonHoc.ID_he
                row("ID_nhom_hp") = objMonHoc.ID_nhom
                dt.Rows.Add(row)
            Next
            dt.DefaultView.Sort = "Ten_mon"
            Return dt
        End Function
        Public Function ThongTimMonHoc(ByVal ID_mon As Integer) As DataTable
            Dim obj As New MonHoc_DataAccess
            Return obj.HienThi_ESSMonHoc(ID_mon)
        End Function
        Public Function ThongTinRangBuocMonHoc(ByVal ID_mon As Integer, ByVal ID_dt As Integer) As DataTable
            Dim obj As New MonHoc_DataAccess
            Return obj.HienThi_ESSChuongTrinhDaoTaoRangBuoc(ID_mon, ID_dt)
        End Function
        Public Function ThongTinMonHocNhomTuChon(ByVal ID_mon As Integer, ByVal ID_dt As Integer) As DataTable
            Dim obj As New MonHoc_DataAccess
            Return obj.HienThi_ESSChuongTrinhDaoTaoNhomTuChon(ID_mon, ID_dt)
        End Function
#End Region
    End Class
End Namespace
