Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class PhongKyTucXa_Bussines
        Private arrPhongHoc As ArrayList
#Region "Initialize"
        Public Sub New()
            Try
                Dim obj As PhongHocKyTucXa_DataAccess = New PhongHocKyTucXa_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSPhongKyTucXa_DanhSach()
                arrPhongHoc = New ArrayList
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim objPH As New ESSPhongKyTucXa
                    objPH = Mapping(dt.Rows(i))
                    arrPhongHoc.Add(objPH)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachPhongKTX() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_phong_ktx", GetType(Integer))
            dt.Columns.Add("ID_co_so", GetType(Integer))
            dt.Columns.Add("ID_nha_ktx", GetType(Integer))
            dt.Columns.Add("ID_tang", GetType(Integer))
            dt.Columns.Add("So_phong_ktx", GetType(String))
            dt.Columns.Add("Ten_co_so", GetType(String))
            dt.Columns.Add("Suc_chua", GetType(Integer))
            dt.Columns.Add("Ten_nha", GetType(String))
            dt.Columns.Add("Ten_tang", GetType(String))
            dt.Columns.Add("Thiet_bi", GetType(String))
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objPhongHoc As ESSPhongKyTucXa = CType(arrPhongHoc(i), ESSPhongKyTucXa)
                row("ID_co_so") = objPhongHoc.ID_co_so
                row("Ten_co_so") = objPhongHoc.Ten_co_so
                row("ID_phong_ktx") = objPhongHoc.ID_phong_ktx
                row("ID_nha_ktx") = objPhongHoc.ID_nha_ktx
                row("ID_tang") = objPhongHoc.ID_tang
                row("So_phong_ktx") = objPhongHoc.So_phong_ktx
                row("Suc_chua") = objPhongHoc.Suc_chua
                row("Ten_nha") = objPhongHoc.Ten_nha
                row("Ten_tang") = objPhongHoc.Ten_tang
                row("Thiet_bi") = objPhongHoc.Thiet_bi
                dt.Rows.Add(row)
            Next
            Return dt
        End Function


        Public Function ThemMoi_ESSPhongKyTucXa(ByVal objPhongHoc As ESSPhongKyTucXa) As Integer
            Try
                Dim obj As PhongHocKyTucXa_DataAccess = New PhongHocKyTucXa_DataAccess
                Return obj.ThemMoi_ESSPhongKyTucXa(objPhongHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSPhongHocKyTucXa(ByVal objPhongHoc As ESSPhongKyTucXa, ByVal ID_phong As Integer) As Integer
            Try
                Dim obj As PhongHocKyTucXa_DataAccess = New PhongHocKyTucXa_DataAccess
                Return obj.CapNhat_ESSPhongKyTucXa(objPhongHoc, ID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSPhongKyTucXa(ByVal ID_phong As Integer) As Integer
            Try
                Dim obj As PhongHocKyTucXa_DataAccess = New PhongHocKyTucXa_DataAccess
                Return obj.Xoa_ESSPhongKyTucXa(ID_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drPhongHoc As DataRow) As ESSPhongKyTucXa
            Dim result As New ESSPhongKyTucXa
            Try
                If drPhongHoc("ID_phong_ktx").ToString() <> "" Then result.ID_phong_ktx = CType(drPhongHoc("ID_phong_ktx").ToString(), Integer)
                If drPhongHoc("ID_nha_ktx").ToString() <> "" Then result.ID_nha_ktx = CType(drPhongHoc("ID_nha_ktx").ToString(), Integer)
                If drPhongHoc("ID_tang").ToString() <> "" Then result.ID_tang = CType(drPhongHoc("ID_tang").ToString(), Integer)
                If drPhongHoc("ID_co_so").ToString() <> "" Then result.ID_co_so = CType(drPhongHoc("ID_co_so").ToString(), Integer)
                result.So_phong_ktx = drPhongHoc("So_phong_ktx").ToString()
                If drPhongHoc("Suc_chua").ToString() <> "" Then result.Suc_chua = CType(drPhongHoc("Suc_chua").ToString(), Integer)
                result.Thiet_bi = drPhongHoc("Thiet_bi").ToString()
                result.Ten_nha = drPhongHoc("Ten_nha").ToString()
                result.Ten_tang = drPhongHoc("Ten_tang").ToString()
                result.Ten_co_so = drPhongHoc("Ten_co_so").ToString()
                result.Ten_phong = result.So_phong_ktx

            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function Tim_Ten_phong(ByVal ID_phong As Integer) As String
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim ph As ESSPhongKyTucXa = CType(arrPhongHoc(i), ESSPhongKyTucXa)
                If ph.ID_phong_ktx = ID_phong Then
                    Return ph.So_phong_ktx
                End If
            Next
            Return ""
        End Function
        Public Function Tim_ID_phong(ByVal Ten_phong As String) As Integer
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim ph As ESSPhongKyTucXa = CType(arrPhongHoc(i), ESSPhongKyTucXa)
                If ph.So_phong_ktx = Ten_phong Then
                    Return ph.ID_phong_ktx
                End If
            Next
            Return -1
        End Function
        Public Function Tim_chi_so(ByVal ID_phong As Integer) As Integer
            For i As Integer = 0 To arrPhongHoc.Count - 1
                Dim ph As ESSPhongKyTucXa = CType(arrPhongHoc(i), ESSPhongKyTucXa)
                If ph.ID_phong_ktx = ID_phong Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrPhongHoc.Count
            End Get
        End Property
        Public Property Phong_ky_tuc_xa(ByVal idx As Integer) As ESSPhongKyTucXa
            Get
                Return CType(Me.arrPhongHoc(idx), ESSPhongKyTucXa)
            End Get
            Set(ByVal Value As ESSPhongKyTucXa)
                Me.arrPhongHoc(idx) = Value
            End Set
        End Property
        Public Function CheckExist_TenPhongKyTucXa(ByVal ID_co_so As Integer, ByVal ID_nha As Integer, ByVal ID_tang As Integer, ByVal So_phong As String) As Boolean
            Try
                Dim obj As PhongHocKyTucXa_DataAccess = New PhongHocKyTucXa_DataAccess
                Return obj.CheckExist_TenPhongKyTucXa(ID_co_so, ID_nha, ID_tang, So_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetPhongKyTucXa(ByVal ID_phong As Integer) As ESSPhongKyTucXa
            Dim idx As Integer = SearchIndex(ID_phong)
            Return arrPhongHoc(idx)
        End Function
        Private Function SearchIndex(ByVal ID_phong As Integer) As Integer
            For i As Integer = 0 To arrPhongHoc.Count - 1
                If CType(arrPhongHoc(i), ESSPhongKyTucXa).ID_phong_ktx = ID_phong Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace

