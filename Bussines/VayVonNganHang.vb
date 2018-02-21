'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 05/10/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class VayVonNganHang_Bussines
        Private arrVayVonNganHang As New ArrayList
        Private dtSinhVienVayVon As DataTable

#Region "Initialize"
        Public Sub New()
        End Sub

        Public Sub New(ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Dim obj As VayVonNganHang_DataAccess = New VayVonNganHang_DataAccess
                dtSinhVienVayVon = obj.HienThi_ESSSinhVienVayVonNganHang(ID_lops, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ' Load danh sách sinh vien vay vốn
        Public Function HienThi_ESSDanhSachSinhVienVayVon() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_vay_von")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("So_tien")
                dt.Columns.Add("Ngay_vay")
                dt.Columns.Add("ID_ngan_hang")
                dt.Columns.Add("Ten_ngan_hang")
                Dim row As DataRow
                For i As Integer = 0 To dtSinhVienVayVon.Rows.Count - 1
                    row = dt.NewRow
                    row("Chon") = False
                    row("ID_vay_von") = dtSinhVienVayVon.Rows(i)("ID_vay_von")
                    row("ID_sv") = dtSinhVienVayVon.Rows(i)("ID_sv")
                    row("Ma_sv") = dtSinhVienVayVon.Rows(i)("Ma_sv")
                    row("Ho_ten") = dtSinhVienVayVon.Rows(i)("Ho_ten")
                    If dtSinhVienVayVon.Rows(i)("Ngay_sinh").ToString <> "" Then row("Ngay_sinh") = Format(dtSinhVienVayVon.Rows(i)("Ngay_sinh"), "dd/MM/yyyy")
                    row("Ten_lop") = dtSinhVienVayVon.Rows(i)("Ten_lop")
                    row("So_tien") = dtSinhVienVayVon.Rows(i)("So_tien")
                    If dtSinhVienVayVon.Rows(i)("Ngay_vay").ToString() <> "" Then row("Ngay_vay") = Format(dtSinhVienVayVon.Rows(i)("Ngay_vay"), "dd/MM/yyyy")
                    If dtSinhVienVayVon.Rows(i)("ID_ngan_hang").ToString() <> "" Then row("ID_ngan_hang") = dtSinhVienVayVon.Rows(i)("ID_ngan_hang")
                    row("Ten_ngan_hang") = dtSinhVienVayVon.Rows(i)("Ten_ngan_hang")
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Load danh sách sinh vien vay vốn
        Public Function HienThi_ESSSinhVienVayVon(ByVal ID_vay_von As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_vay_von")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("So_tien")
                dt.Columns.Add("Ngay_vay")
                dt.Columns.Add("ID_ngan_hang")
                dt.Columns.Add("Ten_ngan_hang")
                Dim row As DataRow
                For i As Integer = 0 To dtSinhVienVayVon.Rows.Count - 1
                    If (dtSinhVienVayVon.Rows(i)("ID_vay_von") = ID_vay_von) Then
                        row = dt.NewRow
                        row("Chon") = False
                        row("ID_vay_von") = dtSinhVienVayVon.Rows(i)("ID_vay_von")
                        row("ID_sv") = dtSinhVienVayVon.Rows(i)("ID_sv")
                        row("Ma_sv") = dtSinhVienVayVon.Rows(i)("Ma_sv")
                        row("Ho_ten") = dtSinhVienVayVon.Rows(i)("Ho_ten")
                        If dtSinhVienVayVon.Rows(i)("Ngay_sinh").ToString <> "" Then row("Ngay_sinh") = Format(dtSinhVienVayVon.Rows(i)("Ngay_sinh"), "dd/MM/yyyy")
                        row("Ten_lop") = dtSinhVienVayVon.Rows(i)("Ten_lop")
                        row("So_tien") = dtSinhVienVayVon.Rows(i)("So_tien")
                        If dtSinhVienVayVon.Rows(i)("Ngay_vay").ToString() <> "" Then row("Ngay_vay") = Format(dtSinhVienVayVon.Rows(i)("Ngay_vay"), "dd/MM/yyyy")
                        If dtSinhVienVayVon.Rows(i)("ID_ngan_hang").ToString() <> "" Then row("ID_ngan_hang") = dtSinhVienVayVon.Rows(i)("ID_ngan_hang")
                        row("Ten_ngan_hang") = dtSinhVienVayVon.Rows(i)("Ten_ngan_hang")
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Functions And Subs"
        Private Function Mapping(ByVal drVayVonNganHang As DataRow) As ESSVayVonNganHang
            Dim result As ESSVayVonNganHang
            Try
                result = New ESSVayVonNganHang
                If (drVayVonNganHang.Item("ID_vay_von").ToString <> "") Then result.ID_vay_von = CInt(drVayVonNganHang.Item("ID_vay_von").ToString)
                If (drVayVonNganHang.Item("ID_sv").ToString <> "") Then result.ID_sv = CInt(drVayVonNganHang.Item("ID_sv").ToString)
                If drVayVonNganHang("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drVayVonNganHang("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drVayVonNganHang("Nam_hoc").ToString()
                If drVayVonNganHang("So_tien").ToString() <> "" Then result.So_tien = CType(drVayVonNganHang("So_tien").ToString(), Integer)
                If drVayVonNganHang("Ngay_vay").ToString() <> "" Then result.Ngay_vay = Format(drVayVonNganHang("Ngay_vay"), "dd/MM/yyyy")
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function GetMaxID_svVayVonNganHang() As Integer
            Try
                Dim obj As VayVonNganHang_DataAccess = New VayVonNganHang_DataAccess
                Return obj.GetMaxID_svVayVonNganHang()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSSinhVienVayVonNganHang(ByVal ID_vay_von As Integer) As Integer
            Try
                Dim obj As VayVonNganHang_DataAccess = New VayVonNganHang_DataAccess
                Return obj.Xoa_ESSSinhVienVayVonNganHang(ID_vay_von)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSSinhVienVayVonNganHang(ByVal objVayVonNganHang As ESSVayVonNganHang, ByVal ID_vay_von As Integer) As Integer
            Try
                Dim obj As VayVonNganHang_DataAccess = New VayVonNganHang_DataAccess
                Return obj.CapNhat_ESSSinhVienVayVonNganHang(objVayVonNganHang, ID_vay_von)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSSinhVienVayVonNganHang(ByVal objVayVonNganHang As ESSVayVonNganHang) As Integer
            Try
                Dim obj As VayVonNganHang_DataAccess = New VayVonNganHang_DataAccess
                Return obj.ThemMoi_ESSSinhVienVayVonNganHang(objVayVonNganHang)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_SinhVienVayVonNganHang(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim obj As VayVonNganHang_DataAccess = New VayVonNganHang_DataAccess
                Return obj.CheckExist_SinhVienVayVonNganHang(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
    End Class
End Namespace

