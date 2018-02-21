'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DoiTuongTroCap_Bussines
        Private arrDoiTuongTroCap As New ArrayList ' Danh sác sinh viên xác định đối tượng (sinh viên)
        Private arrDanhSachTroCap As New ArrayList ' Danh sách sinh viên xác định  hưởng số tiền trợ cấp (tài chính)
        Private arrDoiTuong As New ArrayList ' Danh mục đối tượng học bổng

#Region "Initialize"
        Public Sub New()
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDoiTuong()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim objDTTC As New ESSDoiTuongTroCap
                    objDTTC.ID_dt_hb = IIf(dt.Rows(i)("ID_dt_hb").ToString = "", 0, dt.Rows(i)("ID_dt_hb"))
                    objDTTC.Ma_dt_hb = IIf(dt.Rows(i)("Ma_dt_hb").ToString = "", "", dt.Rows(i)("Ma_dt_hb"))
                    objDTTC.Ten_dt_hb = IIf(dt.Rows(i)("Ten_dt_hb").ToString = "", "", dt.Rows(i)("Ten_dt_hb"))
                    objDTTC.Sotien_trocap = IIf(dt.Rows(i)("Sotien_trocap").ToString = "", 0, dt.Rows(i)("Sotien_trocap"))
                    arrDoiTuong.Add(objDTTC)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSDoiTuongTroCap(ID_lops)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim objDTTC As New ESSDoiTuongTroCap
                objDTTC.ID_sv = dt.Rows(i)("ID_sv")
                objDTTC.ID_dt_hb = IIf(dt.Rows(i)("ID_dt_hb").ToString = "", 0, dt.Rows(i)("ID_dt_hb"))
                objDTTC.Ma_dt_hb = IIf(dt.Rows(i)("Ma_dt_hb").ToString = "", "", dt.Rows(i)("Ma_dt_hb"))
                objDTTC.Ten_dt_hb = IIf(dt.Rows(i)("Ten_dt_hb").ToString = "", "", dt.Rows(i)("Ten_dt_hb"))
                arrDoiTuongTroCap.Add(objDTTC)
            Next
        End Sub
        ' Khởi tạo danh sách sinh viên xác định hưởng tiền trợ cấp (Tài chính)
        Public Sub New(ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            ' Danh sách sinh viên đã xác định đối tượng
            Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSDoiTuongTroCap(ID_lops)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim objDTTC As New ESSDoiTuongTroCap
                objDTTC.ID_sv = dt.Rows(i)("ID_sv")
                objDTTC.ID_dt_hb = IIf(dt.Rows(i)("ID_dt_hb").ToString = "", 0, dt.Rows(i)("ID_dt_hb"))
                objDTTC.Ma_dt_hb = IIf(dt.Rows(i)("Ma_dt_hb").ToString = "", "", dt.Rows(i)("Ma_dt_hb"))
                objDTTC.Ten_dt_hb = IIf(dt.Rows(i)("Ten_dt_hb").ToString = "", "", dt.Rows(i)("Ten_dt_hb"))
                arrDoiTuongTroCap.Add(objDTTC)
            Next
            ' Dánh sác sinh viên hưởng tiền trợ cấp
            Dim dtTC As DataTable = obj.HienThi_ESSDanhSachTroCap(Hoc_ky, Nam_hoc, ID_lops)
            Dim objDSTC As New ESSDanhSachTroCap
            For Each r As DataRow In dtTC.Rows
                objDSTC = Mapping(r)
                arrDanhSachTroCap.Add(objDSTC)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load danh sách sinh viên chua xác định đối tượng theo lớp
        Public Function DanhSachChuaCoDT(ByVal dtSinhVien As DataTable) As DataView
            Try
                Dim dtDoiTuong As DataTable = dtSinhVien.Copy
                dtDoiTuong.Columns.Add("Ma_dt_hb")
                dtDoiTuong.Columns.Add("Ten_dt_hb")
                For i As Integer = 0 To arrDoiTuongTroCap.Count - 1
                    For j As Integer = 0 To dtDoiTuong.Rows.Count - 1
                        If dtDoiTuong.Rows(j)("ID_sv") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).ID_sv Then
                            dtDoiTuong.Rows(j)("Ma_dt_hb") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).Ma_dt_hb
                            dtDoiTuong.Rows(j)("Ten_dt_hb") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).Ten_dt_hb
                        End If
                    Next
                Next
                dtDoiTuong.DefaultView.RowFilter = "Ma_dt_hb=''"
                Return dtDoiTuong.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách sinh viên đã xác định đối tượng và chua xác định ĐT theo lớp
        Public Function DanhSachSVDT(ByVal dtSinhVien As DataTable) As DataView
            Try
                Dim dtDoiTuong As DataTable = dtSinhVien.Copy
                dtDoiTuong.Columns.Add("ID_dt_hb")
                dtDoiTuong.Columns.Add("Ma_dt_hb")
                dtDoiTuong.Columns.Add("Ten_dt_hb")
                For i As Integer = 0 To arrDoiTuongTroCap.Count - 1
                    For j As Integer = 0 To dtDoiTuong.Rows.Count - 1
                        If dtDoiTuong.Rows(j)("ID_sv") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).ID_sv Then
                            dtDoiTuong.Rows(j)("ID_dt_hb") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).ID_dt_hb
                            dtDoiTuong.Rows(j)("Ma_dt_hb") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).Ma_dt_hb
                            dtDoiTuong.Rows(j)("Ten_dt_hb") = CType(arrDoiTuongTroCap(i), ESSDoiTuongTroCap).Ten_dt_hb
                        End If
                    Next
                Next
                Return dtDoiTuong.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDoiTuongTroCap(ByVal objDoiTuongTroCap As ESSDoiTuongTroCap) As Integer
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.ThemMoi_ESSDoiTuongTroCap(objDoiTuongTroCap)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub ThemMoi_ESSDoiTuongTroCap_Object(ByVal objDoiTuongTroCap As ESSDoiTuongTroCap)
            Try
                arrDoiTuong.Add(objDoiTuongTroCap)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function CapNhat_ESSDoiTuongTroCap(ByVal objDoiTuongTroCap As ESSDoiTuongTroCap, ByVal ID_dt_hb As Integer) As Integer
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.CapNhat_ESSDoiTuongTroCap(objDoiTuongTroCap, ID_dt_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub CapNhat_ESSDoiTuongTroCap_Object(ByVal objDoiTuongTroCap As ESSDoiTuongTroCap, ByVal Idx As Integer)
            Try
                arrDoiTuong(Idx) = objDoiTuongTroCap
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Xoa_ESSDoiTuongTroCap(ByVal ID_dt_hb As Integer) As Integer
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.Xoa_ESSDoiTuongTroCap(ID_dt_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub Xoa_ESSDoiTuongTroCap_Object(ByVal Idx As Integer)
            Try
                arrDoiTuong.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function KiemTra_DoiTuongTroCap(ByVal Ma_dt_hb As String) As Boolean
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.KiemTra_DoiTuongTroCap(Ma_dt_hb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#Region " Lập danh sách xác định số tiền trợ cấp cho sinh viên "
        ' Danh sách sinh viên đã xác định số tiền hưởng trợ cấp
        Public Function DanhSach_TroCap(ByVal dv As DataView) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Sotien_trocap", GetType(Integer))
                Dim r As DataRow
                For i As Integer = 0 To arrDanhSachTroCap.Count - 1
                    For j As Integer = 0 To dv.Count - 1
                        If dv.Item(j)("ID_sv") = CType(arrDanhSachTroCap(i), ESSDanhSachTroCap).ID_sv Then
                            r = dt.NewRow
                            r("Chon") = False
                            r("ID_sv") = dv.Item(j)("ID_sv")
                            r("Ma_sv") = dv.Item(j)("Ma_sv")
                            r("Ho_ten") = dv.Item(j)("Ho_ten")
                            r("Ngay_sinh") = dv.Item(j)("Ngay_sinh")
                            r("Sotien_trocap") = CType(arrDanhSachTroCap(i), ESSDanhSachTroCap).Sotien_trocap
                            dt.Rows.Add(r)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên chua xác định số tiền hưởng trợ cấp
        Public Function DanhSach_ChuaXacDinh_TroCap(ByVal dv As DataView, ByVal dtTC As DataTable) As DataView
            Try
                For i As Integer = dv.Count - 1 To 0 Step -1
                    For Each r As DataRow In dtTC.Rows
                        If r("ID_sv") = dv.Item(i)("ID_sv") Then
                            dv.Item(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                ' Chỉ lấy một số trường cần 
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Sotien_trocap")
                Dim row As DataRow
                For i As Integer = dv.Count - 1 To 0 Step -1
                    row = dt.NewRow
                    row("Chon") = False
                    row("ID_sv") = dv.Item(i)("ID_sv")
                    row("Ma_sv") = dv.Item(i)("Ma_sv")
                    row("Ho_ten") = dv.Item(i)("Ho_ten")
                    row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                    row("Sotien_trocap") = 0
                    dt.Rows.Add(row)
                Next
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_DanhSachTroCap(ByVal objDs As ESSDanhSachTroCap) As Boolean
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.KiemTra_DanhSachTroCap(objDs)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachTroCap(ByVal objds As ESSDanhSachTroCap) As Integer
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.ThemMoi_ESSDanhSachTroCap(objds)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachTroCap(ByVal objDs As ESSDanhSachTroCap) As Integer
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.CapNhat_ESSDanhSachTroCap(objDs)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachTroCap(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DoiTuongTroCap_DataAccess = New DoiTuongTroCap_DataAccess
                Return obj.Xoa_ESSDanhSachTroCap(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDSTroCap As DataRow) As ESSDanhSachTroCap
            Dim result As ESSDanhSachTroCap
            Try
                result = New ESSDanhSachTroCap
                result.ID_sv = drDSTroCap.Item("ID_sv")
                If drDSTroCap("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDSTroCap("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDSTroCap("Nam_hoc").ToString()
                result.Ghi_chu = drDSTroCap("Ghi_chu").ToString()
                If drDSTroCap("Sotien_trocap").ToString() <> "" Then result.Sotien_trocap = CType(drDSTroCap("Sotien_trocap").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
#Region "Danh mục đối tượng trợ cấp"
        Public Function DanhSach_DoiTuong_HocBong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_dt_hb")
                dt.Columns.Add("Ma_dt_hb")
                dt.Columns.Add("Ten_dt_hb")
                dt.Columns.Add("Sotien_trocap", GetType(Integer))
                Dim dr As DataRow
                Dim obj As New ESSDoiTuongTroCap
                For i As Integer = 0 To arrDoiTuong.Count - 1
                    obj = CType(arrDoiTuong(i), ESSDoiTuongTroCap)
                    dr = dt.NewRow
                    dr("ID_dt_hb") = obj.ID_dt_hb
                    dr("Ma_dt_hb") = obj.Ma_dt_hb
                    dr("Ten_dt_hb") = obj.Ten_dt_hb
                    dr("Sotien_trocap") = obj.Sotien_trocap
                    dt.Rows.Add(dr)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#End Region
    End Class
End Namespace
