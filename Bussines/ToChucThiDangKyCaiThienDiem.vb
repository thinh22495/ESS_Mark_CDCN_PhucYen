Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ToChucThiDangKyCaiThienDiem_Bussines
        Private arrToChucThiDangKyCaiThienDiem As New ArrayList
#Region "Initialize"
        Sub New()


        End Sub

        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Hinh_thuc As Integer)
            Dim objBLL As ToChucThiDangKyCaiThienDiem_DataAccess = New ToChucThiDangKyCaiThienDiem_DataAccess
            Dim dt As DataTable = objBLL.HienThi_ESSDanhsachDangKyCaiThienDiem(Hoc_ky, Nam_hoc, ID_mon, Hinh_thuc)
            Dim obj As ESSToChucThiDangKyCaiThienDiem
            For i As Integer = 0 To dt.Rows.Count - 1
                obj = New ESSToChucThiDangKyCaiThienDiem
                obj = Mapping(dt.Rows(i))
                arrToChucThiDangKyCaiThienDiem.Add(obj)
            Next
        End Sub

#End Region
#Region "Functions And Subs"

        Public Function DanhSachSinhVienHocCaiThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Duyet", GetType(Boolean))
            dt.Columns.Add("Hinh_thuc", GetType(Integer))
            dt.Columns.Add("Ghi_chu", GetType(String))
            For i As Integer = 0 To arrToChucThiDangKyCaiThienDiem.Count - 1
                Dim dr As DataRow = dt.NewRow
                With CType(arrToChucThiDangKyCaiThienDiem(i), ESSToChucThiDangKyCaiThienDiem)
                    If .Hoc_ky = Hoc_ky AndAlso .Nam_hoc = Nam_hoc AndAlso .ID_mon = ID_mon Then
                        dr("Chon") = False
                        dr("ID_sv") = .ID_sv
                        dr("Ma_sv") = .Ma_sv
                        dr("Ho_ten") = .Ho_ten
                        dr("Ngay_sinh") = .Ngay_sinh
                        dr("ID_lop") = .ID_lop
                        dr("Ten_lop") = .Ten_lop
                        dr("ID_khoa") = .ID_khoa
                        dr("Ten_khoa") = .Ten_khoa
                        dr("Hoc_ky") = .Hoc_ky
                        dr("Nam_hoc") = .Nam_hoc
                        dr("ID_mon") = .ID_mon
                        dr("Duyet") = .Duyet
                        dr("Hinh_thuc") = .Hinh_thuc
                        dr("Ghi_chu") = .Ghi_chu
                        dt.Rows.Add(dr)
                    End If
                End With
            Next
            Return dt
        End Function

        Private Function Mapping(ByVal dr As DataRow) As ESSToChucThiDangKyCaiThienDiem
            Dim obj As New ESSToChucThiDangKyCaiThienDiem
            obj.ID_sv = dr("ID_sv")
            obj.Ma_sv = dr("Ma_sv")
            obj.Ho_ten = dr("Ho_ten")
            If dr("Ngay_sinh").ToString <> "" Then obj.Ngay_sinh = dr("Ngay_sinh")
            obj.ID_khoa = dr("ID_khoa")
            obj.Ten_khoa = dr("Ten_khoa")
            obj.ID_lop = dr("ID_lop")
            obj.Ten_lop = dr("Ten_lop")
            obj.Hoc_ky = dr("Hoc_ky")
            obj.Nam_hoc = dr("Nam_hoc")
            obj.ID_mon = dr("ID_mon")
            obj.Duyet = dr("Duyet")
            obj.Hinh_thuc = dr("Hinh_thuc")
            obj.Ghi_chu = dr("Ghi_chu").ToString
            Return obj
        End Function
        Public Function HienThi_ESSDanhsachDangKyCaiThienDiem(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Hinh_thuc As Integer) As DataTable
            Try
                Dim objBLL As ToChucThiDangKyCaiThienDiem_DataAccess = New ToChucThiDangKyCaiThienDiem_DataAccess
                Return objBLL.HienThi_ESSDanhsachDangKyCaiThienDiem(Hoc_ky, Nam_hoc, ID_mon, Hinh_thuc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSToChucThiDangKyCaiThienDiem(ByVal obj As ESSToChucThiDangKyCaiThienDiem) As Integer
            Try
                Dim objBLL As ToChucThiDangKyCaiThienDiem_DataAccess = New ToChucThiDangKyCaiThienDiem_DataAccess
                Return objBLL.ThemMoi_ESSToChucThiDangKyCaiThienDiem(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSToChucThiDangKyCaiThienDiem(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As Integer
            Try
                Dim objBLL As ToChucThiDangKyCaiThienDiem_DataAccess = New ToChucThiDangKyCaiThienDiem_DataAccess
                Return objBLL.Xoa_ESSToChucThiDangKyCaiThienDiem(ID_sv, Hoc_ky, Nam_hoc, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSToChucThiDangKyCaiThienDiem(ByVal obj As ESSToChucThiDangKyCaiThienDiem) As Integer
            Try
                Dim objDAL As ToChucThiDangKyCaiThienDiem_DataAccess = New ToChucThiDangKyCaiThienDiem_DataAccess
                Return objDAL.CapNhat_ESSToChucThiDangKyCaiThienDiem(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#End Region

    End Class
End Namespace

