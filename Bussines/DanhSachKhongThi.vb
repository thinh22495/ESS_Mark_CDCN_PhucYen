'Tungnk

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachKhongThi_Bussines
        Private arrDanhSachNoHocTap As ArrayList
        Private arrDanhSachNoHocPhiMon As ArrayList
        Private arrDanhSachNoHocPhiHocKy As ArrayList
        Private mID_mon_tc As Integer
        Private mID_lop_tc As Integer
        Private mHoc_ky As Integer
        Private mNam_hoc As String
        Private mID_lop As String = ""


#Region "Initialize"
        Sub New(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_lops As String)
            Try
                mID_mon_tc = ID_mon_tc
                mID_lop_tc = ID_lop_tc
                mHoc_ky = Hoc_ky
                mNam_hoc = Nam_hoc
                mID_lop = ID_lops

                arrDanhSachNoHocTap = New ArrayList
                Dim obj As New DanhSachKhongThi_DataAccess
                Dim dtNoHocTap As DataTable = obj.DanhSachKhongDuDKDuThi_HienThi_DanhSach(ID_mon_tc, ID_lop_tc, Hoc_ky, Nam_hoc, ID_mon, mID_lop)
                Dim objNoHocTap As New ESSDanhSachKhongThi
                Dim dr As DataRow = Nothing
                For Each dr In dtNoHocTap.Rows
                    objNoHocTap = Mapping(dr)
                    arrDanhSachNoHocTap.Add(objNoHocTap)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachKhongDuDieuKienDuThi_DanhSachLopTinChi(ByVal dtDanhSachSinhVien As DataTable, ByVal dv_tontai As DataView) As DataTable
            Dim dtDiem As DataTable = dtDanhSachSinhVien.Copy

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))

            'Gán dữ liệu vào bảng danh sách sinh viên

            For j As Integer = 0 To dtDiem.Rows.Count - 1
                dv_tontai.Sort = "ID_SV"
                If dv_tontai.Find(dtDiem.Rows(j).Item("ID_SV")) < 0 Then
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_SV") = dtDiem.Rows(j).Item("ID_SV")
                    row("Ma_sv") = dtDiem.Rows(j).Item("Ma_sv")
                    row("Ho_ten") = dtDiem.Rows(j).Item("Ho_ten")
                    row("Ngay_sinh") = dtDiem.Rows(j).Item("Ngay_sinh")
                    row("Ten_lop") = dtDiem.Rows(j).Item("Ten_lop")
                    row("Hoc_ky") = mHoc_ky
                    row("Nam_hoc") = mNam_hoc
                    row("Ly_do") = ""

                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function Danh_sach_sinh_vien_no_HocTap() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ly_do", GetType(String))
                For i As Integer = 0 To arrDanhSachNoHocTap.Count - 1
                    Dim ds As ESSDanhSachKhongThi = CType(arrDanhSachNoHocTap(i), ESSDanhSachKhongThi)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = ds.Ngay_sinh
                    row("Ten_lop") = ds.Ten_lop
                    row("Ly_do") = ds.Ly_do
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachKhongDuDieuKienDuThi_LopHC(ByVal dt_DaNo As DataTable, ByVal mdtDanhSachSinhVien As DataTable) As DataTable
            Dim dtMain As DataTable = mdtDanhSachSinhVien.Copy

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))


            For j As Integer = 0 To dtMain.Rows.Count - 1
                Dim row As DataRow = dt.NewRow()
                dt_DaNo.DefaultView.Sort = "ID_sv"
                If dt_DaNo.DefaultView.Find(dtMain.Rows(j).Item("ID_SV")) < 0 Then
                    row("Chon") = False
                    row("ID_SV") = dtMain.Rows(j).Item("ID_SV")
                    row("Ma_sv") = dtMain.Rows(j).Item("Ma_sv")
                    row("Ho_ten") = dtMain.Rows(j).Item("Ho_ten")
                    row("Ngay_sinh") = dtMain.Rows(j).Item("Ngay_sinh")
                    row("Ten_lop") = dtMain.Rows(j).Item("Ten_lop")
                    row("Ly_do") = ""

                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function DanhSachKhongDuDieuKienDuThi_NoHocPhiMon(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_lops As String) As DataTable
            Dim obj As New DanhSachKhongThi_DataAccess
            Dim dt_noHP As DataTable = obj.DanhSachNoHocPhiMon_HienThi_DanhSach(ID_mon_tc, ID_lop_tc, Hoc_ky, Nam_hoc, ID_mon, ID_lops)
            Dim dt As DataTable = dt_noHP.Copy
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Ly_do", GetType(String))

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("Chon") = False
                dt.Rows(i).Item("Ly_do") = "Nợ học phí học phần"
            Next
            Return dt
        End Function

        Public Function ThemMoi_ESSDanhSachKhongThi(ByVal objDanhSachKhongThi As ESSDanhSachKhongThi) As Integer
            Try
                Dim obj As DanhSachKhongThi_DataAccess = New DanhSachKhongThi_DataAccess
                Return obj.ThemMoi_ESSDanhSachKhongThi(objDanhSachKhongThi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachKhongThi_09(ByVal objDanhSachKhongThi As ESSDanhSachKhongThi) As Integer
            Try
                Dim obj As DanhSachKhongThi_DataAccess = New DanhSachKhongThi_DataAccess
                Return obj.ThemMoi_ESSDanhSachKhongThi_09(objDanhSachKhongThi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachKhongThi(ByVal objDanhSachKhongThi As ESSDanhSachKhongThi, ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DanhSachKhongThi_DataAccess = New DanhSachKhongThi_DataAccess
                Return obj.CapNhat_ESSDanhSachKhongThi(objDanhSachKhongThi, ID_sv, ID_mon, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachKhongThi(ByVal objDanhSachKhongThi As ESSDanhSachKhongThi) As Integer
            Try
                Dim obj As DanhSachKhongThi_DataAccess = New DanhSachKhongThi_DataAccess
                Return obj.Xoa_ESSDanhSachKhongThi(objDanhSachKhongThi.ID_sv, objDanhSachKhongThi.ID_mon, objDanhSachKhongThi.Hoc_ky, objDanhSachKhongThi.Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping(ByVal drNoThi As DataRow) As ESSDanhSachKhongThi
            Dim result As ESSDanhSachKhongThi
            Try
                result = New ESSDanhSachKhongThi
                If drNoThi("ID_SV").ToString() <> "" Then result.ID_sv = CType(drNoThi("ID_SV").ToString(), Integer)
                If drNoThi("ID_mon").ToString() <> "" Then result.ID_mon = CType(drNoThi("ID_mon").ToString(), Integer)
                If drNoThi("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drNoThi("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drNoThi("Nam_hoc").ToString()
                result.Ly_do = drNoThi("Ly_do").ToString()
                result.Ho_ten = drNoThi("Ho_ten").ToString()
                result.Ngay_sinh = drNoThi("Ngay_sinh").ToString()
                result.Ten_lop = drNoThi("Ten_lop").ToString()
                result.Ma_sv = drNoThi("Ma_sv").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function MappingHocPhiMon(ByVal drNoHocPhiMon As DataRow) As ESSDanhSachKhongThi
            Dim result As ESSDanhSachKhongThi
            Try
                result = New ESSDanhSachKhongThi
                If drNoHocPhiMon("ID_SV").ToString() <> "" Then result.ID_sv = CType(drNoHocPhiMon("ID_SV").ToString(), Integer)
                If drNoHocPhiMon("ID_mon").ToString() <> "" Then result.ID_mon = CType(drNoHocPhiMon("ID_mon").ToString(), Integer)
                result.Hoc_ky = mHoc_ky
                result.Nam_hoc = mNam_hoc
                result.Ly_do = "Nợ học phí với số tiền " & drNoHocPhiMon("No_tien").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace