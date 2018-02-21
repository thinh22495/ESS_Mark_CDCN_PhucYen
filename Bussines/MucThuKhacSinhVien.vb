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
    Public Class MucThuKhacSinhVien_Bussines
        Inherits ESSMucThuKhacSinhVien
        Private arrDanhSachSVThuKhac As New ArrayList
#Region "Initialize"
        Sub New()

        End Sub
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String)
            Dim obj_DataAccess As MucThuKhacSinhVien_DataAccess = New MucThuKhacSinhVien_DataAccess
            Dim dt As DataTable
            dt = obj_DataAccess.HienThi_ESSMucThuKhacSinhVien_DanhSach(Hoc_ky, Nam_hoc, dsID_lop)
            Dim obj As ESSMucThuKhacSinhVien
            Dim dr As DataRow
            For Each dr In dt.Rows
                obj = New ESSMucThuKhacSinhVien
                obj = Mapping(dr)
                arrDanhSachSVThuKhac.Add(obj)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        ' Danh sách sinh viên xác đinh khoản thu khác
        Public Function DanhSach_Thu(ByVal dtSinhVien As DataTable, Optional ByVal ID_thu_chi As Integer = 0) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("ID_thu_chi")
                dt.Columns.Add("Ten_thu_chi")
                dt.Columns.Add("So_tien")
                Dim obj As ESSMucThuKhacSinhVien
                Dim row As DataRow
                For Each dr As DataRow In dtSinhVien.Rows
                    For i As Integer = 0 To arrDanhSachSVThuKhac.Count - 1
                        obj = New ESSMucThuKhacSinhVien
                        obj = CType(arrDanhSachSVThuKhac(i), ESSMucThuKhacSinhVien)
                        If dr("ID_sv") = obj.ID_sv And obj.ID_thu_chi = ID_thu_chi Then
                            row = dt.NewRow
                            row("Chon") = False
                            row("ID_sv") = dr("ID_sv")
                            row("Ma_sv") = dr("Ma_sv")
                            row("Ho_ten") = dr("Ho_ten")
                            row("Ngay_sinh") = dr("Ngay_sinh")
                            row("Hoc_ky") = obj.Hoc_ky
                            row("Nam_hoc") = obj.Nam_hoc
                            row("Ten_thu_chi") = obj.Ten_thu_chi
                            row("ID_thu_chi") = obj.ID_thu_chi
                            row("So_tien") = Format(obj.So_tien, "###,##0")
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên chưa xác định khoản thu khác
        Public Function DanhSach_ChuaXacDinh_Thu(ByVal dtSinhVien As DataTable, ByVal ID_thu_chi As Integer) As DataTable
            Try
                Dim dt As DataTable
                dt = dtSinhVien.Copy
                Dim obj As ESSMucThuKhacSinhVien
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To arrDanhSachSVThuKhac.Count - 1
                        obj = New ESSMucThuKhacSinhVien
                        obj = CType(arrDanhSachSVThuKhac(j), ESSMucThuKhacSinhVien)
                        If dt.Rows(i)("ID_sv") = obj.ID_sv And obj.ID_thu_chi = ID_thu_chi Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                ' Chỉ xác định lấy một số trường
                Dim dtDS As New DataTable
                dtDS.Columns.Add("Chon")
                dtDS.Columns.Add("ID_sv")
                dtDS.Columns.Add("Ma_sv")
                dtDS.Columns.Add("Ho_ten")
                dtDS.Columns.Add("Ngay_sinh", GetType(Date))
                dtDS.Columns.Add("Hoc_ky")
                dtDS.Columns.Add("Nam_hoc")
                dtDS.Columns.Add("ID_thu_chi")
                dtDS.Columns.Add("Ten_thu_chi")
                dtDS.Columns.Add("So_tien")
                Dim row As DataRow
                For Each dr As DataRow In dt.Rows
                    row = dtDS.NewRow
                    row("Chon") = False
                    row("ID_sv") = dr("ID_sv")
                    row("Ma_sv") = dr("Ma_sv")
                    row("Ho_ten") = dr("Ho_ten")
                    row("Ngay_sinh") = dr("Ngay_sinh")
                    row("Hoc_ky") = 1
                    row("Nam_hoc") = ""
                    row("Ten_thu_chi") = ""
                    row("ID_thu_chi") = 0
                    row("So_tien") = 0
                    dtDS.Rows.Add(row)
                Next
                Return dtDS
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSMucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As ESSMucThuKhacSinhVien) As Integer
            Try
                Dim obj As MucThuKhacSinhVien_DataAccess = New MucThuKhacSinhVien_DataAccess
                Return obj.ThemMoi_ESSMucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSMucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As ESSMucThuKhacSinhVien) As Integer
            Try
                Dim obj As MucThuKhacSinhVien_DataAccess = New MucThuKhacSinhVien_DataAccess
                Return obj.CapNhat_ESSMucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSMucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As ESSMucThuKhacSinhVien) As Integer
            Try
                Dim obj As MucThuKhacSinhVien_DataAccess = New MucThuKhacSinhVien_DataAccess
                Return obj.Xoa_ESSMucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svMucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As ESSMucThuKhacSinhVien) As Boolean
            Try
                Dim obj As MucThuKhacSinhVien_DataAccess = New MucThuKhacSinhVien_DataAccess
                Return obj.CheckExist_MucThuKhacSinhVien(objMucThuKhacSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drMucThuKhacSinhVien As DataRow) As ESSMucThuKhacSinhVien
            Dim result As ESSMucThuKhacSinhVien
            Try
                result = New ESSMucThuKhacSinhVien
                If drMucThuKhacSinhVien("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drMucThuKhacSinhVien("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drMucThuKhacSinhVien("Nam_hoc").ToString()
                If drMucThuKhacSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drMucThuKhacSinhVien("ID_sv").ToString(), Integer)
                If drMucThuKhacSinhVien("ID_thu_chi").ToString() <> "" Then result.ID_thu_chi = CType(drMucThuKhacSinhVien("ID_thu_chi").ToString(), Integer)
                If drMucThuKhacSinhVien("So_tien").ToString() <> "" Then result.So_tien = CType(drMucThuKhacSinhVien("So_tien").ToString(), Integer)
                result.Ghi_chu = drMucThuKhacSinhVien("Ghi_chu").ToString()
                result.Ten_thu_chi = drMucThuKhacSinhVien("Ten_thu_chi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
