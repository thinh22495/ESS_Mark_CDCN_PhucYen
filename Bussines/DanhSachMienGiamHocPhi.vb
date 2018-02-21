'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachMienGiamHocPhi_Bussines
        Private arrDanhSachMienGiamHocPhi As New ArrayList
        Private dtDTGT As DataTable  ' Bảng danh sách các loại giấy tờ cần nộp
#Region "Initialize"
        Sub New()
            Dim obj_DataAccess As New DanhSachMienGiamHocPhi_DataAccess
            dtDTGT = obj_DataAccess.HienThi_ESSGiayToCanNop()
        End Sub
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String)
            Dim obj_DataAccess As New DanhSachMienGiamHocPhi_DataAccess
            Dim dt As DataTable
            dt = obj_DataAccess.HienThi_ESSDanhSachMienGiamHocPhi(Hoc_ky, Nam_hoc, dsID_lop)
            Dim obj As ESSDanhSachMienGiamHocPhi
            Dim dr As DataRow
            For Each dr In dt.Rows
                obj = New ESSDanhSachMienGiamHocPhi
                obj = Mapping(dr)
                arrDanhSachMienGiamHocPhi.Add(obj)
            Next
        End Sub
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer)
            Dim obj_DataAccess As New DanhSachMienGiamHocPhi_DataAccess
            Dim dt As DataTable
            dt = obj_DataAccess.HienThi_ESSDanhSachMienGiamHocPhi(Hoc_ky, Nam_hoc, ID_sv)
            Dim obj As ESSDanhSachMienGiamHocPhi
            Dim dr As DataRow
            For Each dr In dt.Rows
                obj = New ESSDanhSachMienGiamHocPhi
                obj = Mapping(dr)
                arrDanhSachMienGiamHocPhi.Add(obj)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrDanhSachMienGiamHocPhi.Count
            End Get
        End Property
        Public Property MienGiamHocPhi(ByVal idx As Integer) As ESSDanhSachMienGiamHocPhi
            Get
                Return CType(Me.arrDanhSachMienGiamHocPhi(idx), ESSDanhSachMienGiamHocPhi)
            End Get
            Set(ByVal Value As ESSDanhSachMienGiamHocPhi)
                Me.arrDanhSachMienGiamHocPhi(idx) = Value
            End Set
        End Property
        ' Danh sách miễn giảm học phí của một sinh viên
        Public Function DanhSach_MG() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Phan_tram")
                Dim obj As ESSDanhSachMienGiamHocPhi
                Dim row As DataRow
                Dim dv As New DataView
                For i As Integer = 0 To arrDanhSachMienGiamHocPhi.Count - 1
                    row = dt.NewRow
                    obj = New ESSDanhSachMienGiamHocPhi
                    obj = CType(arrDanhSachMienGiamHocPhi(i), ESSDanhSachMienGiamHocPhi)
                    row("ID_sv") = obj.ID_sv
                    row("Hoc_ky") = obj.Hoc_ky
                    row("Nam_hoc") = obj.Nam_hoc
                    row("Phan_tram") = obj.Phan_tram
                    dt.Rows.Add(row)
                Next
                dt.DefaultView.AllowDelete = True
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowNew = True
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Danh sách Giấy tờ cần nộp nhưng chưa nộp
        Public Function DoiTuong_GiayTo_Thieu(ByVal dtHoSoNop As DataTable, ByVal Ma_dt As String) As DataTable
            Try
                Dim cls As New DanhMuc_Bussines
                Dim dvGT As DataView
                dvGT = cls.DanhMuc_Load("STU_LoaiGiayTo", "ID_giay_to", "Ten_giay_to").DefaultView
                Dim dt As New DataTable ' giấy tờ đã nộp
                dt.Columns.Add("ID_giay_to")
                dt.Columns.Add("Ten_giay_to")
                Dim row As DataRow
                For i As Integer = 0 To dtHoSoNop.Rows.Count - 1
                    For j As Integer = 0 To dtDTGT.Rows.Count - 1
                        ' Nếu giấy tờ cần nộp đã nộp
                        If dtHoSoNop.Rows(i)("ID_giay_to") = dtDTGT.Rows(j)("ID_giay_to") And dtDTGT.Rows(j)("Ma_dt") = Ma_dt Then
                            row = dt.NewRow
                            row("ID_giay_to") = dtHoSoNop.Rows(i)("ID_giay_to")
                            row("Ten_giay_to") = dtHoSoNop.Rows(i)("Ten_giay_to")
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Dim dtThieu As New DataTable
                dtThieu.Columns.Add("ID_giay_to")
                dtThieu.Columns.Add("Ten_giay_to")
                Dim dr As DataRow
                Dim dv As DataView
                dv = dtDTGT.DefaultView
                dv.RowFilter = "Ma_dt='" & Ma_dt & "'" ' Giấy tờ cần nộp
                For i As Integer = 0 To dv.Count - 1
                    dt.DefaultView.RowFilter = "ID_giay_to=" & dv.Item(i)("ID_giay_to")
                    If dt.DefaultView.Count <= 0 Then ' Nếu giấy tờ chưa nộp
                        dr = dtThieu.NewRow
                        dr("ID_giay_to") = dv.Item(i)("ID_giay_to")
                        dvGT.RowFilter = "ID_giay_to=" & dv.Item(i)("ID_giay_to")
                        dr("Ten_giay_to") = dvGT.Item(0)("Ten_giay_to").ToString
                        dtThieu.Rows.Add(dr)
                    End If
                Next
                Return dtThieu
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên đã xác đinh miễn giảm
        Public Function DanhSach_MienGiam(ByVal dtSinhVien As DataTable, ByVal ID_doi_tuong_TS As Integer) As DataView
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Phan_tram")
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Integer))
                Dim obj As ESSDanhSachMienGiamHocPhi
                Dim row As DataRow
                Dim dv As New DataView
                dv = dtSinhVien.Copy.DefaultView
                For i As Integer = 0 To dv.Count - 1
                    For j As Integer = 0 To arrDanhSachMienGiamHocPhi.Count - 1
                        obj = New ESSDanhSachMienGiamHocPhi
                        obj = CType(arrDanhSachMienGiamHocPhi(j), ESSDanhSachMienGiamHocPhi)
                        If dv.Item(i)("ID_sv") = obj.ID_sv And dv.Item(i)("ID_doi_tuong_TS") = ID_doi_tuong_TS Then
                            row = dt.NewRow
                            row("Chon") = False
                            row("ID_sv") = dv.Item(i)("ID_sv")
                            row("Ma_sv") = dv.Item(i)("Ma_sv")
                            row("Ho_ten") = dv.Item(i)("Ho_ten")
                            row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                            row("Phan_tram") = obj.Phan_tram
                            row("Ngoai_ngan_sach") = IIf(dv.Item(i)("Ngoai_ngan_sach") = False, 0, 1)
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                dt.DefaultView.AllowDelete = True
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowNew = True
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên chưa xác định miễn giảm
        Public Function DanhSach_ChuaMienGiam(ByVal dtSinhVien As DataTable, ByVal ID_doi_tuong_TS As Integer, ByVal ID_doi_tuong_HB As Integer) As DataView
            Try
                Dim dv As New DataView
                dv = dtSinhVien.Copy.DefaultView
                dv.RowFilter = "ID_doi_tuong_TS=" & ID_doi_tuong_TS
                If ID_doi_tuong_HB > 0 Then dv.RowFilter = "ID_doi_tuong_TC=" & ID_doi_tuong_HB
                Dim obj As ESSDanhSachMienGiamHocPhi
                For i As Integer = dv.Count - 1 To 0 Step -1
                    For j As Integer = 0 To arrDanhSachMienGiamHocPhi.Count - 1
                        obj = New ESSDanhSachMienGiamHocPhi
                        obj = CType(arrDanhSachMienGiamHocPhi(j), ESSDanhSachMienGiamHocPhi)
                        If dv.Item(i)("ID_sv") = obj.ID_sv Then
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
                dt.Columns.Add("Phan_tram")
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Integer))
                Dim row As DataRow
                For i As Integer = dv.Count - 1 To 0 Step -1
                    row = dt.NewRow
                    row("Chon") = False
                    row("ID_sv") = dv.Item(i)("ID_sv")
                    row("Ma_sv") = dv.Item(i)("Ma_sv")
                    row("Ho_ten") = dv.Item(i)("Ho_ten")
                    row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                    row("Phan_tram") = 0
                    row("Ngoai_ngan_sach") = IIf(dv.Item(i)("Ngoai_ngan_sach") = False, 0, 1)
                    dt.Rows.Add(row)
                Next
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_DanhSachMienGiamHocPhi(ByVal objDanhSachMienGiamHocPhi As ESSDanhSachMienGiamHocPhi) As Boolean
            Try
                Dim obj As DanhSachMienGiamHocPhi_DataAccess = New DanhSachMienGiamHocPhi_DataAccess
                Return obj.KiemTra_DanhSachMienGiamHocPhi(objDanhSachMienGiamHocPhi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachMienGiamHocPhi(ByVal objDanhSachMienGiamHocPhi As ESSDanhSachMienGiamHocPhi) As Integer
            Try
                Dim obj As DanhSachMienGiamHocPhi_DataAccess = New DanhSachMienGiamHocPhi_DataAccess
                Return obj.ThemMoi_ESSDanhSachMienGiamHocPhi(objDanhSachMienGiamHocPhi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachMienGiamHocPhi(ByVal objDanhSachMienGiamHocPhi As ESSDanhSachMienGiamHocPhi) As Integer
            Try
                Dim obj As DanhSachMienGiamHocPhi_DataAccess = New DanhSachMienGiamHocPhi_DataAccess
                Return obj.CapNhat_ESSDanhSachMienGiamHocPhi(objDanhSachMienGiamHocPhi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachMienGiamHocPhi(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DanhSachMienGiamHocPhi_DataAccess = New DanhSachMienGiamHocPhi_DataAccess
                Return obj.Xoa_ESSDanhSachMienGiamHocPhi(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhSachMienGiamHocPhi As DataRow) As ESSDanhSachMienGiamHocPhi
            Dim result As ESSDanhSachMienGiamHocPhi
            Try
                result = New ESSDanhSachMienGiamHocPhi
                If drDanhSachMienGiamHocPhi("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachMienGiamHocPhi("ID_sv").ToString(), Integer)
                If drDanhSachMienGiamHocPhi("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSachMienGiamHocPhi("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDanhSachMienGiamHocPhi("Nam_hoc").ToString()
                If drDanhSachMienGiamHocPhi("Phan_tram").ToString() <> "" Then result.Phan_tram = CType(drDanhSachMienGiamHocPhi("Phan_tram").ToString(), Double)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
