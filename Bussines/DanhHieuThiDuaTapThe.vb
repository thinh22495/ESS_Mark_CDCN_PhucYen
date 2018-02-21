'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, July 11, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhHieuThiDuaTapThe_Bussines
        Private arrDanhHieuTT As New ArrayList
        Private dtDanhHieuCN As DataTable
        Private dtDiemRL As DataTable
        Private dtKyLuat As DataTable
        Private mID_dv As String
        Private mHoc_ky As Integer
        Private mNam_hoc As String
#Region "Initialize"
        Public Sub New(ByVal dsID_lops As String)
            Try
                Dim obj As DanhHieuThiDuaTapThe_DataAccess = New DanhHieuThiDuaTapThe_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhHieuThiDuaTapThe_DanhSach(dsID_lops)
                Dim objDanhHieuThiDuaTapThe As ESSDanhHieuThiDuaTapThe = Nothing
                For i As Integer = 0 To dt.Rows.Count - 1
                    objDanhHieuThiDuaTapThe = New ESSDanhHieuThiDuaTapThe
                    objDanhHieuThiDuaTapThe = Mapping(dt.Rows(i))
                    arrDanhHieuTT.Add(objDanhHieuThiDuaTapThe)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal dsID_lops As String, ByVal ID_dv As String, ByVal ID_bm_chinh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dtDS_sv As DataTable)
            Try
                mID_dv = ID_dv
                mHoc_ky = Hoc_ky
                mNam_hoc = Nam_hoc
                Dim obj As DanhHieuThiDuaTapThe_DataAccess = New DanhHieuThiDuaTapThe_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhHieuThiDuaTapThe_DanhSach(dsID_lops)
                Dim objDanhHieuThiDuaTapThe As ESSDanhHieuThiDuaTapThe = Nothing
                For i As Integer = 0 To dt.Rows.Count - 1
                    objDanhHieuThiDuaTapThe = New ESSDanhHieuThiDuaTapThe
                    objDanhHieuThiDuaTapThe = Mapping(dt.Rows(i))
                    arrDanhHieuTT.Add(objDanhHieuThiDuaTapThe)
                Next
                ' Tong hop ren luyen
                Dim objRL As New DiemRenLuyen_Bussines(dsID_lops)
                dtDiemRL = objRL.TongHop_DiemRenLuyenKy(Hoc_ky, Nam_hoc)
                ' Danh hieu ca nhan
                Dim objDHCN As New DanhHieuThiDuaCaNhan_Bussines(dsID_lops)
                dtDanhHieuCN = objDHCN.DanhSach_DaXet(mHoc_ky, mNam_hoc)
                ' Ky luat
                Dim objKL As New KyLuat_Bussines(dsID_lops)
                dtKyLuat = objKL.HienThi_ESSKyLuat(mHoc_ky, mNam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        ' Danh sách lớp đạt tiêu chuẩn lớp khá
        Public Function Lop_Kha(ByVal dsID_lop As String) As DataTable
            Try
                Dim Arr() As String
                Arr = Split(dsID_lop, ",")
                Dim obj As New DanhSachSinhVien_DataAccess
                Dim dtDS As DataTable
                Dim dt As New DataTable
                dt.Columns.Add("ID_lop")
                Dim Tong_kha As Integer = 0
                Dim Tong As Integer = 0
                Dim row As DataRow
                ' Những lớp đã xét danh hiệu cá nhân
                For i As Integer = 0 To Arr.Length - 1
                    Dim dv As DataView
                    dv = dtDanhHieuCN.Copy.DefaultView
                    dv.RowFilter = "ID_lop=" & Arr(i) & " and ID_danh_hieu<=2" ' Lọc lớp có cá nhân đạt danh hiệu sv giỏi

                    row = dt.NewRow
                    dtDanhHieuCN.DefaultView.RowFilter = "ID_lop=" & Arr(i)
                    dtDS = obj.HienThi_DanhSach_DanhSachSinhVien_DanhSach(Arr(i))
                    Tong_kha = dtDanhHieuCN.DefaultView.Count
                    Tong = dtDS.Rows.Count
                    ' Lọc kỷ luật
                    Dim dvKl As DataView
                    dvKl = dtKyLuat.DefaultView
                    dvKl.RowFilter = "ID_lop=" & Arr(i)
                    ' Lọc rèn luyện kém
                    Dim dvRl As DataView
                    dvRl = dtDiemRL.DefaultView
                    dvRl.RowFilter = "ID_lop=" & Arr(i) & " and ID_xep_loai=7"
                    ' Tổng hợp điểm của lớp và lọc xếp loại kém                    
                    Dim objDiem As New Diem_Bussines(mID_dv, 0, mHoc_ky, mNam_hoc, Arr(i), dtDS.Rows(0)("ID_dt").ToString, dtDS)
                    Dim dvDiem As DataView
                    dvDiem = objDiem.TongHopDiemHocKy_XetHocBong(1, 2, False, False, mHoc_ky, mNam_hoc).DefaultView
                    dvDiem.RowFilter = "ID_xep_loai=6"
                    If (Tong_kha / Tong) * 100 >= 25 And dv.Count > 0 And dvKl.Count = 0 And dvRl.Count = 0 And dvDiem.Count = 0 Then
                        row("ID_lop") = Arr(i)
                        dt.Rows.Add(row)
                    End If
                Next
                ' Loại bỏ những lớp đã xét danh hiệu thi đua tập thể
                Dim DH As ESSDanhHieuThiDuaTapThe
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To arrDanhHieuTT.Count - 1
                        DH = New ESSDanhHieuThiDuaTapThe
                        DH = arrDanhHieuTT(j)
                        If dt.Rows(i)("ID_lop") = DH.ID_lop And DH.Hoc_ky = mHoc_ky And DH.Nam_hoc = mNam_hoc Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowNew = True
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowDelete = True
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lớp đạt tiêu chuẩn lớp khá
        Public Function Lop_XS(ByVal dsID_lop As String) As DataTable
            Try
                Dim Arr() As String
                Arr = Split(dsID_lop, ",")
                Dim obj As New DanhSachSinhVien_DataAccess
                Dim dtDS As DataTable
                Dim dt As New DataTable
                dt.Columns.Add("ID_lop")
                Dim Tong_kha As Integer = 0
                Dim Tong As Integer = 0
                Dim Temp_ID_lop As Integer = 0
                Dim row As DataRow
                ' Những lớp đã xét danh hiệu cá nhân
                For i As Integer = 0 To Arr.Length - 1
                    Dim dv As DataView
                    dv = dtDanhHieuCN.Copy.DefaultView
                    dv.RowFilter = "ID_lop=" & Arr(i) & " and ID_danh_hieu=1" ' Lọc lớp có cá nhân đạt danh hiệu sv xuất sắc
                    Dim dvGioi As DataView
                    dvGioi = dtDanhHieuCN.Copy.DefaultView
                    dvGioi.RowFilter = "ID_lop=" & Arr(i) & " and ID_danh_hieu<=2" ' Lọc lớp có cá nhân đạt danh hiệu từ giỏi trở lên

                    row = dt.NewRow
                    dtDanhHieuCN.DefaultView.RowFilter = "ID_lop=" & Arr(i)
                    dtDS = obj.HienThi_DanhSach_DanhSachSinhVien_DanhSach(Arr(i))
                    Tong_kha = dtDanhHieuCN.DefaultView.Count
                    Tong = dtDS.Rows.Count
                    ' Tính % sinh viên đạt danh hiệu giỏi trở lên
                    Dim pt_gioi As Double = 0
                    pt_gioi = (dvGioi.Count / Tong) * 100
                    ' Lọc kỷ luật
                    Dim dvKl As DataView
                    dvKl = dtKyLuat.DefaultView
                    dvKl.RowFilter = "ID_lop=" & Arr(i)
                    ' Lọc rèn luyện kém
                    Dim dvRl As DataView
                    dvRl = dtDiemRL.DefaultView
                    dvRl.RowFilter = "ID_lop=" & Arr(i) & " and ID_xep_loai=7"
                    ' Tổng hợp điểm của lớp và lọc xếp loại kém                    
                    Dim objDiem As New Diem_Bussines(mID_dv, 0, mHoc_ky, mNam_hoc, Arr(i), dtDS.Rows(0)("ID_dt").ToString, dtDS)
                    Dim dvDiem As DataView
                    dvDiem = objDiem.TongHopDiemHocKy_XetHocBong(1, 2, False, False, mHoc_ky, mNam_hoc).DefaultView
                    dvDiem.RowFilter = "ID_xep_loai=6"
                    If (Tong_kha / Tong) * 100 >= 25 And dv.Count > 0 And dvKl.Count = 0 And dvRl.Count = 0 And dvDiem.Count = 0 And pt_gioi > 10 Then
                        row("ID_lop") = Arr(i)
                        dt.Rows.Add(row)
                    End If
                Next
                ' Loại bỏ những lớp đã xét danh hiệu thi đua tập thể
                Dim DH As ESSDanhHieuThiDuaTapThe
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To arrDanhHieuTT.Count - 1
                        DH = New ESSDanhHieuThiDuaTapThe
                        DH = arrDanhHieuTT(j)
                        If dt.Rows(i)("ID_lop") = DH.ID_lop And DH.Hoc_ky = mHoc_ky And DH.Nam_hoc = mNam_hoc Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowNew = True
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowDelete = True
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lớp chua xet danh hiệu (cũ)
        Public Function DanhSach_LopChuaXet(ByVal dtDSLop As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As DataTable
                dt = dtDSLop.Copy
                Dim DH As ESSDanhHieuThiDuaTapThe
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To arrDanhHieuTT.Count - 1
                        DH = New ESSDanhHieuThiDuaTapThe
                        DH = arrDanhHieuTT(j)
                        If dt.Rows(i)("ID_lop") = DH.ID_lop And DH.Hoc_ky = Hoc_ky And DH.Nam_hoc = Nam_hoc Then
                            dt.Rows(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowNew = True
                dt.DefaultView.AllowEdit = True
                dt.DefaultView.AllowDelete = True
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Danh sách lớp chưa xét danh hiệu
        Public Function DanhSach_LopChuaXet(ByVal dtDSLop As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal Danh_hieu As Integer) As DataTable
            Try
                Dim data As DataTable
                Dim dtDH As DataTable = Nothing
                data = dtDSLop.Copy
                If Danh_hieu = 1 Then
                    dtDH = Lop_Kha(dsID_lop) ' Danh hieu tiên tiến
                ElseIf Danh_hieu = 3 Then
                    dtDH = Lop_XS(dsID_lop) ' Danh hieu XS
                ElseIf Danh_hieu = 2 Then ' Danh hiệu tập thể giỏi không xét
                    data = New DataTable
                    Return data
                    Exit Function
                Else ' Không có danh hiệu liệt kê tất cả các lớp theo hệ khoa khóa
                    Dim dv As DataView
                    dv = data.DefaultView
                    dv.RowFilter = "ID_lop in(" & dsID_lop & ")"
                    Return dv.Table
                    Exit Function
                End If
                If dtDH.Rows.Count = 0 Then ' Nếu không có lớp nào đạt danh hiệu
                    data = New DataTable
                    Return data
                    Exit Function
                End If
                ' Loại bỏ những lớp không đủ điều kiện ra khỏi danh sách
                For i As Integer = data.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtDH.Rows.Count - 1
                        If dtDSLop.Rows(i)("ID_lop") <> dtDH.Rows(j)("ID_lop") Then
                            data.Rows(i).Delete()
                            data.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
                Return data
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách lớp đã xét danh hiệu
        Public Function DanhSach_LopDaXet(ByVal dtDSLop As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_danh_hieu As Integer) As DataTable
            Try
                Dim cls As New DanhMuc_Bussines()
                Dim dvDM As New DataView
                dvDM = cls.DanhMuc_Load("STU_DanhHieu", "ID_danh_hieu", "Danh_hieu").DefaultView
                Dim dt As DataTable
                dt = dtDSLop.Copy
                dt.Columns.Add("ID_danh_hieu", GetType(Integer))
                dt.Columns.Add("Ly_do", GetType(String))
                dt.Columns.Add("ID_cap", GetType(Integer))
                dt.Columns.Add("Danh_hieu", GetType(String))
                Dim dtDaXet As DataTable
                dtDaXet = dt.Clone
                Dim DH As New ESSDanhHieuThiDuaTapThe
                For i As Integer = 0 To dt.Rows.Count - 1
                    For j As Integer = 0 To arrDanhHieuTT.Count - 1
                        DH = arrDanhHieuTT(j)
                        If dt.Rows(i)("ID_lop") = DH.ID_lop And DH.Hoc_ky = Hoc_ky And DH.Nam_hoc = Nam_hoc And DH.ID_danh_hieu = ID_danh_hieu Then
                            dt.Rows(i)("ID_danh_hieu") = DH.ID_danh_hieu
                            dt.Rows(i)("Ly_do") = DH.Ly_do
                            dt.Rows(i)("ID_cap") = DH.ID_cap
                            dvDM.RowFilter = "ID_danh_hieu=" & DH.ID_danh_hieu
                            If dvDM.Count > 0 Then dt.Rows(i)("Danh_hieu") = dvDM.Item(0)("Danh_hieu").ToString
                            Dim row As DataRow
                            row = dtDaXet.NewRow
                            row.ItemArray = dt.Rows(i).ItemArray
                            dtDaXet.Rows.Add(row)
                        End If
                    Next
                Next
                dtDaXet.AcceptChanges()
                dtDaXet.DefaultView.AllowNew = True
                dtDaXet.DefaultView.AllowEdit = True
                dtDaXet.DefaultView.AllowDelete = True
                Return dtDaXet
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhHieuThiDuaTapThe(ByVal objDanhHieuThiDuaTapThe As ESSDanhHieuThiDuaTapThe) As Integer
            Try
                Dim obj As DanhHieuThiDuaTapThe_DataAccess = New DanhHieuThiDuaTapThe_DataAccess
                Return obj.ThemMoi_ESSDanhHieuThiDuaTapThe(objDanhHieuThiDuaTapThe)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhHieuThiDuaTapThe(ByVal objDanhHieuThiDuaTapThe As ESSDanhHieuThiDuaTapThe) As Integer
            Try
                Dim obj As DanhHieuThiDuaTapThe_DataAccess = New DanhHieuThiDuaTapThe_DataAccess
                Return obj.CapNhat_ESSDanhHieuThiDuaTapThe(objDanhHieuThiDuaTapThe)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhHieuThiDuaTapThe(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhHieuThiDuaTapThe_DataAccess = New DanhHieuThiDuaTapThe_DataAccess
                Return obj.Xoa_ESSDanhHieuThiDuaTapThe(Hoc_ky, Nam_hoc, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDanhHieuThiDuaTapThe(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop As Integer) As Boolean
            Try
                Dim obj As DanhHieuThiDuaTapThe_DataAccess = New DanhHieuThiDuaTapThe_DataAccess
                Return obj.CheckExist_DanhHieuThiDuaTapThe(Hoc_ky, Nam_hoc, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhHieuThiDuaTapThe As DataRow) As ESSDanhHieuThiDuaTapThe
            Dim result As ESSDanhHieuThiDuaTapThe
            Try
                result = New ESSDanhHieuThiDuaTapThe
                If drDanhHieuThiDuaTapThe("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhHieuThiDuaTapThe("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDanhHieuThiDuaTapThe("Nam_hoc").ToString()
                If drDanhHieuThiDuaTapThe("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhHieuThiDuaTapThe("ID_lop").ToString(), Integer)
                If drDanhHieuThiDuaTapThe("ID_danh_hieu").ToString() <> "" Then result.ID_danh_hieu = CType(drDanhHieuThiDuaTapThe("ID_danh_hieu").ToString(), Integer)
                If drDanhHieuThiDuaTapThe("ID_cap").ToString() <> "" Then result.ID_cap = CType(drDanhHieuThiDuaTapThe("ID_cap").ToString(), Integer)
                result.Ly_do = drDanhHieuThiDuaTapThe("Ly_do").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
