''---------------------------------------------------------------------------
'' Author : Education Solution Soft - ESS
'' Company : Education Solution Soft - ESS
'' Created Date : Sunday, May 04, 2010
''---------------------------------------------------------------------------
'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports ESS.Objects
'Imports ESS.DataAccess
'Namespace Bussines
'    Public Class TongHopDiem_Bussines
'        Private mDiem As Diem_Bussines
'        Private mdtDanhSachSinhVien As DataTable
'        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal dtDanhSachSinhVien As DataTable)
'            mdtDanhSachSinhVien = dtDanhSachSinhVien
'            Dim dtMonHoc As New DataTable
'            'Load ESSDiem sinh vien
'            mDiem = New Diem_Bussines(mdtDanhSachSinhVien)
'            'Load cac mon hoc
'        End Sub
'        Function TongHopHocKy(ByVal Lan_thi As Byte) As DataTable
'            Dim dtTongHop As New DataTable
'            Dim idx_diem As Integer = -1, ID_mon As Integer
'            Dim DiemShow As String = "", DiemTBMH As Double
'            Dim dr As DataRow
'            Dim Tong_diem As Double = 0, Tong_so_hoc_trinh As Integer = 0
'            dtTongHop = mdtDanhSachSinhVien.Copy
'            'Add cac cot ESSDiem cua cac mon hoc
'            For i As Integer = 0 To mCTDT.Count - 1
'                dtTongHop.Columns.Add(mCTDT.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon)
'            Next
'            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
'            For Each dr In dtTongHop.Rows
'                'Duyet cac mon hoc
'                For i As Integer = 0 To mCTDT.Count - 1
'                    ID_mon = mCTDT.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
'                    'Tim ESSDiem cua sinh vien nay
'                    idx_diem = mDiem.Tim_idx(dr("ID_sv"), ID_mon)
'                    If idx_diem >= 0 Then
'                        Dim ESSDiem As ESSDiem = mDiem.ESSDiem(idx_diem)
'                        'Tính điểm TBCMH
'                        If Lan_thi = 1 Then
'                            DiemTBMH = TinhDiemTBMH(ESSDiem.dsDiemThi.Diem_thi_lan(1), ESSDiem.dsDiemThanhPhan)
'                        Else
'                            DiemTBMH = TinhDiemTBMH(ESSDiem.dsDiemThi.Diem_thi_max, ESSDiem.dsDiemThanhPhan)
'                        End If
'                        'Điểm hiển thị
'                        DiemShow = DiemHienThi(mDiem.ESSDiem(idx_diem))

'                        dr(mCTDT.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = DiemShow
'                    End If
'                Next
'            Next
'            Return dtTongHop
'        End Function

'        'Hàm này để tính điểm TBCMH
'        Private Function TinhDiemTBMH(ByVal Diem_thi As Double, ByVal diemTP As ESSDiemThanhPhan) As Double
'            Dim DiemTBMH As Double = 0, Tong_ty_le As Byte = 0, Tong_diemTP As Byte = 0
'            For i As Byte = 0 To diemTP.Count - 1
'                Tong_ty_le += diemTP.ESSDiemThanhPhan(i).Ty_le
'                Tong_diemTP += diemTP.ESSDiemThanhPhan(i).ESSDiem * diemTP.ESSDiemThanhPhan(i).Ty_le
'            Next
'            DiemTBMH = (Tong_diemTP + (100 - Tong_ty_le) * Diem_thi) / 100

'            'Lam tron ESSDiem TBCMH
'            DiemTBMH = Math.Round(DiemTBMH, gLam_tron_TBCMH)

'            Return DiemTBMH
'        End Function

'        Private Function DiemHienThi(ByVal ESSDiem As ESSDiem) As String
'            Dim Diem_hien_thi As String = ""
'            For Lan_thi As Integer = 0 To ESSDiem.dsDiemThi.Count - 1
'                Diem_hien_thi += TinhDiemTBMH(ESSDiem.dsDiemThi.Diem_thi_lan(Lan_thi), ESSDiem.dsDiemThanhPhan) + "-"
'            Next
'            If Diem_hien_thi <> "" Then Diem_hien_thi = Left(Diem_hien_thi, Len(Diem_hien_thi) - 1)
'            Return Diem_hien_thi
'        End Function
'    End Class
'End Namespace