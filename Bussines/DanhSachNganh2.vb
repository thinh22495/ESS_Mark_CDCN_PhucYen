Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachNganh2_Bussines
        Private arrsvDanhSachNganh2 As ArrayList
        Private arrsvDanhSachMonNganh1TrungNganh2 As ArrayList
        Private arrsvDanhSachMonNganh1TrungNganh2DaChon As ArrayList

        Private arrsvDanhSachMonNganh1TuongDuong_Nganh2 As ArrayList
        Private arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon As ArrayList

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt2 As Integer)
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhSachMonNganh1TrungNganh2_DanhSach(ID_dv, ID_sv, ID_dt2)
                Dim objsvDanhSachChuongTrinh2 As ESSDanhSachNganh2 = Nothing
                Dim dr As DataRow = Nothing
                arrsvDanhSachMonNganh1TrungNganh2 = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachChuongTrinh2 = MappingMonNganh(dr)
                    arrsvDanhSachMonNganh1TrungNganh2.Add(objsvDanhSachChuongTrinh2)
                Next

                dt = obj.HienThi_ESSDanhSachMonNganh1TrungNganh2DaChon_DanhSach(ID_dv, ID_sv)
                objsvDanhSachChuongTrinh2 = Nothing
                dr = Nothing
                arrsvDanhSachMonNganh1TrungNganh2DaChon = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachChuongTrinh2 = MappingMonNganhDaChon(dr)
                    arrsvDanhSachMonNganh1TrungNganh2DaChon.Add(objsvDanhSachChuongTrinh2)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt2 As Integer, ByVal HP_TuongDuong As Byte)
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhSachMonNganh1_TuongDuong_Nganh2_ChuaChon(ID_dv, ID_sv, ID_dt2)
                Dim objsvDanhSachChuongTrinh2 As ESSDanhSachNganh2 = Nothing
                Dim dr As DataRow = Nothing
                arrsvDanhSachMonNganh1TuongDuong_Nganh2 = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachChuongTrinh2 = MappingMon_TuongDuong_ChuaChon(dr)
                    arrsvDanhSachMonNganh1TuongDuong_Nganh2.Add(objsvDanhSachChuongTrinh2)
                Next

                dt = obj.HienThi_ESSDanhSachMonNganh1TrungNganh2_TuongDuong_Nganh2_DaChon(ID_dv, ID_sv)
                objsvDanhSachChuongTrinh2 = Nothing
                dr = Nothing
                arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachChuongTrinh2 = MappingMon_TuongDuong_DaChon(dr)
                    arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon.Add(objsvDanhSachChuongTrinh2)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Ma_sv As String)
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSChuongTrinhNganh2_DanhSach(Ma_sv, ID_nganh, ID_chuyen_nganh)
                Dim objsvDanhSachChuongTrinh2 As ESSDanhSachNganh2 = Nothing
                Dim dr As DataRow = Nothing
                arrsvDanhSachNganh2 = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachChuongTrinh2 = Mapping(dr)
                    arrsvDanhSachNganh2.Add(objsvDanhSachChuongTrinh2)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub Add(ByVal DSN As ESSDanhSachNganh2)
            arrsvDanhSachNganh2.Add(DSN)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrsvDanhSachNganh2.RemoveAt(idx)
        End Sub


        Public Function ThemMoi_ESSsvDanhSachNganh2(ByVal objsvDanhSachNganh2 As ESSDanhSachNganh2) As Integer
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Return obj.ThemMoi_ESSsvDanhSachNganh2(objsvDanhSachNganh2)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSsvDanhSachNganh2(ByVal objsvDanhSachNganh2 As ESSDanhSachNganh2, ByVal ID_dt_old As Integer) As Integer
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Return obj.CapNhat_ESSDanhSachNganh2(objsvDanhSachNganh2, ID_dt_old)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSsvSinhVienNganh2_NgungHoc(ByVal ID_sv As Integer, ByVal ID_dt2 As Integer, ByVal Ngung_Hoc As Boolean) As Integer
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Return obj.CapNhat_ESSSinhVienNganh2_NgungHoc(ID_sv, ID_dt2, Ngung_Hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSsvDanhSachNganh2(ByVal ID_sv As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
                Remove(ID_dt)
                Return obj.Xoa_ESSsvDanhSachNganh2(ID_sv, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVienChuongTrinh2(ByVal Ngung_hoc As Boolean) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("ID_dt1", GetType(Integer))
            dt.Columns.Add("ID_dt2", GetType(Integer))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_cn1", GetType(Integer))
            dt.Columns.Add("Chuyen_nganh", GetType(String))

            dt.Columns.Add("ID_cn2", GetType(Integer))
            dt.Columns.Add("Chuyen_nganh2", GetType(String))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Noi_dung", GetType(String))
            dt.Columns.Add("Ngung_hoc", GetType(Boolean))
            dt.Columns.Add("Khoa_hoc2", GetType(Integer))
            dt.Columns.Add("Ten_lop_N2", GetType(String))

            For i As Integer = 0 To arrsvDanhSachNganh2.Count - 1
                If CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Nam_hoc <> "" AndAlso CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngung_hoc = Ngung_hoc Then
                    Dim row As DataRow = dt.NewRow()
                    row("Khoa_hoc2") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Khoa_hoc2
                    row("ID_he") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_he
                    row("ID_dt1") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt1
                    row("ID_dt2") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt2
                    row("ID_sv") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_sv
                    row("Ma_sv") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ma_sv
                    row("Ho_ten") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ho_ten
                    row("Ngay_sinh") = IIf(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_sinh.Year < 1900, System.DBNull.Value, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_sinh)
                    row("Ten_lop") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ten_lop
                    row("Chuyen_nganh") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Chuyen_nganh
                    row("ID_cn1") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh1
                    row("Ten_nganh") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ten_nganh

                    row("ID_cn2") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh2), 0, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh2)
                    row("Chuyen_nganh2") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Chuyen_nganh2
                    row("ID_nganh") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_nganh), 0, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_nganh)
                    row("Hoc_ky") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Hoc_ky), 0, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Hoc_ky)
                    row("Nam_hoc") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Nam_hoc), "", CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Nam_hoc)
                    row("So_qd") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).So_qd), "", CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).So_qd)
                    row("Ngay_qd") = IIf(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_qd.Year < 1900, System.DBNull.Value, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_qd)
                    row("Noi_dung") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Noi_dung), "", CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Noi_dung)
                    row("Ngung_hoc") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngung_hoc), 0, 1)
                    row("Ten_lop_N2") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ten_lop_N2

                    row("Chon") = False
                    dt.Rows.Add(row)
                End If
            Next
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function SinhVienChuongTrinh2() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_dt1", GetType(Integer))
            dt.Columns.Add("ID_dt2", GetType(Integer))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_cn1", GetType(Integer))
            dt.Columns.Add("Chuyen_nganh", GetType(String))
            dt.Columns.Add("ID_he", GetType(Integer))
            dt.Columns.Add("Khoa_hoc", GetType(Integer))

            dt.Columns.Add("ID_cn2", GetType(Integer))
            dt.Columns.Add("ID_nganh", GetType(Integer))
            dt.Columns.Add("Ten_nganh", GetType(String))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Noi_dung", GetType(String))
            dt.Columns.Add("Ngung_hoc", GetType(Boolean))

            For i As Integer = 0 To arrsvDanhSachNganh2.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_dt1") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt1
                row("ID_dt2") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt2
                row("ID_sv") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_sv
                row("Ma_sv") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ma_sv
                row("Ho_ten") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ho_ten
                row("Ngay_sinh") = IIf(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_sinh.Year < 1900, System.DBNull.Value, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_sinh)
                row("Ten_lop") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ten_lop
                row("Chuyen_nganh") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Chuyen_nganh
                row("ID_cn1") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh1
                row("Ten_nganh") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ten_nganh
                row("ID_he") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_he
                row("Khoa_hoc") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Khoa_hoc

                row("ID_cn2") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh2), 0, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh2)
                row("ID_nganh") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_nganh), 0, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_nganh)
                row("Hoc_ky") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Hoc_ky), 0, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Hoc_ky)
                row("Nam_hoc") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Nam_hoc), "", CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Nam_hoc)
                row("So_qd") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).So_qd), "", CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).So_qd)
                row("Ngay_qd") = IIf(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_qd.Year < 1900, System.DBNull.Value, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_qd)
                row("Noi_dung") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Noi_dung), "", CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Noi_dung)
                row("Ngung_hoc") = IIf(IsDBNull(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngung_hoc), 0, 1)

                row("Chon") = False
                dt.Rows.Add(row)
            Next
            dt.AcceptChanges()
            Return dt
        End Function

        Public Function DanhSachSinhVienChuongTrinh2_ChuyenDiem() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_dt", GetType(Integer))
            dt.Columns.Add("ID_dt2", GetType(Integer))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dt.Columns.Add("Chuyen_nganh", GetType(String))

            For i As Integer = 0 To arrsvDanhSachNganh2.Count - 1
                If CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt2 > 0 AndAlso CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngung_hoc = False Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_dt") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt1
                    row("ID_dt2") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt2
                    row("ID_sv") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_sv
                    row("Ma_sv") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ma_sv
                    row("Ho_ten") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ho_ten
                    row("Ngay_sinh") = IIf(CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_sinh.Year < 1900, System.DBNull.Value, CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ngay_sinh)
                    row("Ten_lop") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Ten_lop
                    row("Chuyen_nganh") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).Chuyen_nganh
                    row("ID_chuyen_nganh") = CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_chuyen_nganh1

                    row("Chon") = False
                    dt.Rows.Add(row)
                End If
            Next
            dt.AcceptChanges()
            Return dt
        End Function
        Private Function Mapping(ByVal drDSHoc2ChuongTrinh As DataRow) As ESSDanhSachNganh2
            Dim result As ESSDanhSachNganh2
            Try
                result = New ESSDanhSachNganh2
                If drDSHoc2ChuongTrinh("ID_dt1").ToString() <> "" Then result.ID_dt1 = CType(drDSHoc2ChuongTrinh("ID_dt1").ToString(), Integer)
                If drDSHoc2ChuongTrinh("ID_dt2").ToString() <> "" Then result.ID_dt2 = CType(drDSHoc2ChuongTrinh("ID_dt2").ToString(), Integer)
                If drDSHoc2ChuongTrinh("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDSHoc2ChuongTrinh("ID_sv").ToString(), Integer)
                If drDSHoc2ChuongTrinh("ID_cn1").ToString() <> "" Then result.ID_chuyen_nganh1 = CType(drDSHoc2ChuongTrinh("ID_cn1").ToString(), Integer)
                If drDSHoc2ChuongTrinh("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = drDSHoc2ChuongTrinh("Ngay_sinh").ToString
                result.Ma_sv = drDSHoc2ChuongTrinh("Ma_sv").ToString
                result.Ho_ten = drDSHoc2ChuongTrinh("Ho_ten").ToString
                result.Ten_lop = drDSHoc2ChuongTrinh("Ten_lop").ToString
                result.Chuyen_nganh = drDSHoc2ChuongTrinh("Chuyen_nganh").ToString
                result.Chuyen_nganh2 = drDSHoc2ChuongTrinh("Chuyen_nganh2").ToString
                result.Ten_nganh = drDSHoc2ChuongTrinh("Ten_nganh").ToString
                result.ID_he = drDSHoc2ChuongTrinh("ID_he").ToString
                result.Khoa_hoc = drDSHoc2ChuongTrinh("Khoa_hoc").ToString
                result.Ten_lop_N2 = drDSHoc2ChuongTrinh("Ten_lop_N2").ToString
                If drDSHoc2ChuongTrinh("Khoa_hoc2").ToString <> "" Then result.Khoa_hoc2 = drDSHoc2ChuongTrinh("Khoa_hoc2").ToString

                If drDSHoc2ChuongTrinh("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drDSHoc2ChuongTrinh("ID_nganh").ToString(), Integer)
                If drDSHoc2ChuongTrinh("ID_cn2").ToString() <> "" Then result.ID_chuyen_nganh2 = CType(drDSHoc2ChuongTrinh("ID_cn2").ToString(), Integer)
                If drDSHoc2ChuongTrinh("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDSHoc2ChuongTrinh("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDSHoc2ChuongTrinh("Nam_hoc").ToString
                result.So_qd = drDSHoc2ChuongTrinh("So_qd").ToString
                If drDSHoc2ChuongTrinh("Ngay_qd").ToString() <> "" Then result.Ngay_qd = CType(drDSHoc2ChuongTrinh("Ngay_qd").ToString(), Date)
                result.Noi_dung = drDSHoc2ChuongTrinh("Noi_dung").ToString
                If drDSHoc2ChuongTrinh("Ngung_hoc").ToString() <> "" Then result.Ngung_hoc = CType(drDSHoc2ChuongTrinh("Ngung_hoc").ToString(), Boolean)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function DanhSachMonSinhVienNganh1TrungNganh2() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))

            For i As Integer = 0 To arrsvDanhSachMonNganh1TrungNganh2.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_mon") = CType(arrsvDanhSachMonNganh1TrungNganh2(i), ESSDanhSachNganh2).ID_mon
                row("Ky_hieu") = CType(arrsvDanhSachMonNganh1TrungNganh2(i), ESSDanhSachNganh2).Ky_hieu
                row("Ten_mon") = CType(arrsvDanhSachMonNganh1TrungNganh2(i), ESSDanhSachNganh2).Ten_mon
                row("So_hoc_trinh") = CType(arrsvDanhSachMonNganh1TrungNganh2(i), ESSDanhSachNganh2).So_hoc_trinh
                row("Hoc_ky") = CType(arrsvDanhSachMonNganh1TrungNganh2(i), ESSDanhSachNganh2).Hoc_ky
                row("Nam_hoc") = CType(arrsvDanhSachMonNganh1TrungNganh2(i), ESSDanhSachNganh2).Nam_hoc
                dt.Rows.Add(row)
            Next

            dt.AcceptChanges()
            Return dt
        End Function
        Public Function DanhSachMonSinhVienNganh1TrungNganh2DaChon() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("TBCM", GetType(Double))
            dt.Columns.Add("Diem_chu", GetType(String))
            dt.Columns.Add("ID_diem", GetType(Integer))
            dt.Columns.Add("Lan_thi", GetType(Integer))
            dt.Columns.Add("Ghi_chu", GetType(String))

            For i As Integer = 0 To arrsvDanhSachMonNganh1TrungNganh2DaChon.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("Chon") = False
                row("ID_mon") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).ID_mon
                row("Ky_hieu") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Ky_hieu
                row("Ten_mon") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Ten_mon
                row("So_hoc_trinh") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).So_hoc_trinh
                row("Hoc_ky") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Hoc_ky
                row("Nam_hoc") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Nam_hoc
                row("TBCM") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).TBCM
                row("Diem_chu") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Diem_chu
                row("ID_diem") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).ID_diem
                row("Lan_thi") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Lan_thi
                row("Ghi_chu") = CType(arrsvDanhSachMonNganh1TrungNganh2DaChon(i), ESSDanhSachNganh2).Ghi_chu
                dt.Rows.Add(row)
            Next

            dt.AcceptChanges()
            Return dt
        End Function
        Private Function MappingMonNganh(ByVal dr As DataRow) As ESSDanhSachNganh2
            Dim result As ESSDanhSachNganh2
            Try
                result = New ESSDanhSachNganh2
                If dr("ID_mon").ToString() <> "" Then result.ID_mon = CType(dr("ID_mon").ToString(), Integer)
                If dr("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(dr("So_hoc_trinh").ToString(), Integer)
                If dr("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(dr("Hoc_ky").ToString(), Integer)
                If dr("ID_diem").ToString() <> "" Then result.ID_diem = CType(dr("ID_diem").ToString(), Integer)

                result.Ten_mon = dr("Ten_mon").ToString
                result.Ky_hieu = dr("Ky_hieu").ToString
                result.Nam_hoc = dr("Nam_hoc").ToString
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function MappingMonNganhDaChon(ByVal dr As DataRow) As ESSDanhSachNganh2
            Dim result As ESSDanhSachNganh2
            Try
                result = New ESSDanhSachNganh2
                If dr("ID_mon").ToString() <> "" Then result.ID_mon = CType(dr("ID_mon").ToString(), Integer)
                If dr("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(dr("So_hoc_trinh").ToString(), Integer)
                If dr("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(dr("Hoc_ky").ToString(), Integer)
                If dr("ID_diem").ToString() <> "" Then result.ID_diem = CType(dr("ID_diem").ToString(), Integer)
                If dr("TBCM").ToString() <> "" Then result.TBCM = CType(dr("TBCM").ToString(), Double)
                If dr("Lan_thi").ToString() <> "" Then result.Lan_thi = CType(dr("Lan_thi").ToString(), Integer)

                result.Ten_mon = dr("Ten_mon").ToString
                result.Ghi_chu = dr("Ghi_chu").ToString
                result.Ky_hieu = dr("Ky_hieu").ToString
                result.Nam_hoc = dr("Nam_hoc").ToString
                result.Diem_chu = dr("Diem_chu").ToString
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Check_IDSV(ByVal ID_SV As Integer, ByVal dv As DataView) As Boolean
            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("ID_sv") = ID_SV Then Return True
            Next
            Return False
        End Function

        Function Get_CTDT(ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer, ByVal ID_he As Integer) As Integer
            Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
            Dim dt As DataTable = obj.Get_IDDT(ID_chuyen_nganh, Khoa_hoc, ID_he)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("ID_DT")
            Else
                Return -1
            End If
        End Function

        Private Function Tim_idx(ByVal ID_dt As Integer) As Integer
            For i As Integer = 0 To arrsvDanhSachNganh2.Count - 1
                If CType(arrsvDanhSachNganh2(i), ESSDanhSachNganh2).ID_dt1 = ID_dt Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Sub InserDiem()

        End Sub

        Function DanhSachSinhVien_HocNganh2(ByVal ID_dt As Integer) As DataTable
            Dim obj As DanhSachNganh2_DataAccess = New DanhSachNganh2_DataAccess
            Return obj.DanhSachSinhVien_HocNganh2(ID_dt)
        End Function

        '-----------------MON TUONG DUONG--------------------
        Private Function MappingMon_TuongDuong_ChuaChon(ByVal dr As DataRow) As ESSDanhSachNganh2
            Dim result As ESSDanhSachNganh2
            Try
                result = New ESSDanhSachNganh2
                If dr("ID_mon").ToString() <> "" Then result.ID_mon = CType(dr("ID_mon").ToString(), Integer)
                If dr("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(dr("So_hoc_trinh").ToString(), Integer)
                If dr("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(dr("Hoc_ky").ToString(), Integer)
                If dr("ID_diem").ToString() <> "" Then result.ID_diem = CType(dr("ID_diem").ToString(), Integer)

                result.Ten_mon = dr("Ten_mon").ToString
                result.Ten_mon2 = dr("Ten_mon2").ToString
                result.Ky_hieu = dr("Ky_hieu").ToString
                result.Nam_hoc = dr("Nam_hoc").ToString
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function MappingMon_TuongDuong_DaChon(ByVal dr As DataRow) As ESSDanhSachNganh2
            Dim result As ESSDanhSachNganh2
            Try
                result = New ESSDanhSachNganh2
                If dr("ID_mon").ToString() <> "" Then result.ID_mon = CType(dr("ID_mon").ToString(), Integer)
                If dr("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(dr("So_hoc_trinh").ToString(), Integer)
                If dr("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(dr("Hoc_ky").ToString(), Integer)
                If dr("ID_diem").ToString() <> "" Then result.ID_diem = CType(dr("ID_diem").ToString(), Integer)
                If dr("TBCM").ToString() <> "" Then result.TBCM = CType(dr("TBCM").ToString(), Double)
                If dr("Lan_thi").ToString() <> "" Then result.Lan_thi = CType(dr("Lan_thi").ToString(), Integer)

                result.Ten_mon = dr("Ten_mon").ToString
                result.Ten_mon2 = dr("Ten_mon2").ToString
                result.Ghi_chu = dr("Ghi_chu").ToString
                result.Ky_hieu = dr("Ky_hieu").ToString
                result.Nam_hoc = dr("Nam_hoc").ToString
                result.Diem_chu = dr("Diem_chu").ToString
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Function DanhSachMonSinhVienNganh1_TuongDuong_Nganh2_ChuaChon() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("ID_mon_tuong_duong", GetType(Integer))
            dt.Columns.Add("Ten_mon2", GetType(String))
            dt.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))

            For i As Integer = 0 To arrsvDanhSachMonNganh1TuongDuong_Nganh2.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_mon") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).ID_mon
                row("Ky_hieu") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).Ky_hieu
                row("Ten_mon") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).Ten_mon
                row("ID_mon_tuong_duong") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).ID_mon_tuong_duong
                row("Ten_mon2") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).Ten_mon2
                row("So_hoc_trinh") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).So_hoc_trinh
                row("Hoc_ky") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).Hoc_ky
                row("Nam_hoc") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2(i), ESSDanhSachNganh2).Nam_hoc
                dt.Rows.Add(row)
            Next

            dt.AcceptChanges()
            Return dt
        End Function
        Public Function DanhSachMonSinhVienNganh1_TuongDuong_Nganh2DaChon() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("ID_mon_tuong_duong", GetType(Integer))
            dt.Columns.Add("Ten_mon2", GetType(String))
            dt.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("TBCM", GetType(Double))
            dt.Columns.Add("Diem_chu", GetType(String))
            dt.Columns.Add("ID_diem", GetType(Integer))
            dt.Columns.Add("Lan_thi", GetType(Integer))
            dt.Columns.Add("Ghi_chu", GetType(String))

            For i As Integer = 0 To arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("Chon") = False
                row("ID_mon") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).ID_mon
                row("Ky_hieu") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Ky_hieu
                row("Ten_mon") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Ten_mon
                row("ID_mon_tuong_duong") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).ID_mon_tuong_duong
                row("Ten_mon2") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Ten_mon2
                row("So_hoc_trinh") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).So_hoc_trinh
                row("Hoc_ky") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Hoc_ky
                row("Nam_hoc") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Nam_hoc
                row("TBCM") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).TBCM
                row("Diem_chu") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Diem_chu
                row("ID_diem") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).ID_diem
                row("Lan_thi") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Lan_thi
                row("Ghi_chu") = CType(arrsvDanhSachMonNganh1TuongDuong_Nganh2DaChon(i), ESSDanhSachNganh2).Ghi_chu
                dt.Rows.Add(row)
            Next

            dt.AcceptChanges()
            Return dt
        End Function
#End Region
    End Class
End Namespace