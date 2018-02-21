'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, May 08, 2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class BangDiemCaNhan_Bussines
        Private mTBCHT10 As Double = 0
        Private mTBCHT4 As Double = 0
        Private mID_xep_hang_hoc_luc As Integer = 0
        Private mXep_hang_hoc_luc As String = ""
        Private mXep_loai_TN As String = ""
        Private mXep_loai_TN_En As String = ""
        Private mTBC_tich_luy As Double = 0
        Private mSo_hoc_trinh_tich_luy As Integer = 0
        Private mSo_mon_hoc_lai As Integer = 0
        Private mSo_mon_thi_lai As Integer = 0
        Private mSo_mon_cho_diem As Integer = 0
        Private mNam_thu As Integer = 1
        Private dtBangDiem As DataTable
        Private clsDiem As Diem_Bussines
        Sub New(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, Optional ByVal full As Boolean = False)
            Dim dtTongKet As DataTable
            clsDiem = New Diem_Bussines(ID_dv, ID_sv, ID_dt)
            dtTongKet = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(ID_sv, Hoc_ky, Nam_hoc)
            If dtTongKet.Rows.Count > 0 Then
                mTBCHT10 = IIf(IsDBNull(dtTongKet.Rows(0)("TBCHT10")), 0, dtTongKet.Rows(0)("TBCHT10"))
                mTBCHT4 = IIf(IsDBNull(dtTongKet.Rows(0)("TBCHT4")), 0, dtTongKet.Rows(0)("TBCHT4"))
                mNam_thu = IIf(IsDBNull(dtTongKet.Rows(0)("Nam_thu")), 0, dtTongKet.Rows(0)("Nam_thu"))
                mID_xep_hang_hoc_luc = IIf(IsDBNull(dtTongKet.Rows(0)("ID_xep_hang_hoc_luc")), 0, dtTongKet.Rows(0)("ID_xep_hang_hoc_luc"))
                mXep_hang_hoc_luc = dtTongKet.Rows(0)("Xep_hang_hoc_tap").ToString
                mXep_loai_TN = dtTongKet.Rows(0)("Xep_loai_TN").ToString
                mXep_loai_TN_En = dtTongKet.Rows(0)("Xep_loai_TN_En").ToString
                mTBC_tich_luy = IIf(IsDBNull(dtTongKet.Rows(0)("TBC_tich_luy")), 0, dtTongKet.Rows(0)("TBC_tich_luy"))
                mSo_hoc_trinh_tich_luy = IIf(IsDBNull(dtTongKet.Rows(0)("So_hoc_trinh_tich_luy")), 0, dtTongKet.Rows(0)("So_hoc_trinh_tich_luy"))
                mSo_mon_hoc_lai = IIf(IsDBNull(dtTongKet.Rows(0)("So_mon_hoc_lai")), 0, dtTongKet.Rows(0)("So_mon_hoc_lai"))
                mSo_mon_thi_lai = IIf(IsDBNull(dtTongKet.Rows(0)("So_mon_thi_lai")), 0, dtTongKet.Rows(0)("So_mon_thi_lai"))
                mSo_mon_cho_diem = IIf(IsDBNull(dtTongKet.Rows(0)("So_mon_cho_diem")), 0, dtTongKet.Rows(0)("So_mon_cho_diem"))

            End If
            If full Then
                dtBangDiem = clsDiem.BangDiemSinhVienFull(ID_sv)
            Else
                dtBangDiem = clsDiem.BangDiemSinhVien(ID_sv, Hoc_ky, Nam_hoc)
            End If
        End Sub

        Public Function BangDiem() As System.Data.DataTable
            Return dtBangDiem
        End Function
        Public ReadOnly Property TBCHT10() As Double
            Get
                Return mTBCHT10
            End Get
        End Property
        Public ReadOnly Property TBCHT4() As Double
            Get
                Return mTBCHT4
            End Get
        End Property
        Public ReadOnly Property ID_xep_hang_hoc_luc() As Integer
            Get
                Return mID_xep_hang_hoc_luc
            End Get
        End Property
        Public ReadOnly Property Xep_hang_hoc_luc() As String
            Get
                Return mXep_hang_hoc_luc
            End Get
        End Property
        Public ReadOnly Property Xep_loai_TN() As String
            Get
                Return mXep_loai_TN
            End Get
        End Property
        Public ReadOnly Property Xep_loai_TN_En() As String
            Get
                Return mXep_loai_TN_En
            End Get
        End Property
        Public ReadOnly Property TBC_tich_luy() As Double
            Get
                Return mTBC_tich_luy
            End Get
        End Property
        Public ReadOnly Property So_hoc_trinh_tich_luy() As Integer
            Get
                Return mSo_hoc_trinh_tich_luy
            End Get
        End Property
        Public ReadOnly Property So_mon_hoc_lai() As Integer
            Get
                Return mSo_mon_hoc_lai
            End Get
        End Property
        Public ReadOnly Property So_mon_thi_lai() As Integer
            Get
                Return mSo_mon_thi_lai
            End Get
        End Property
        Public ReadOnly Property So_mon_cho_diem() As Integer
            Get
                Return mSo_mon_cho_diem
            End Get
        End Property
        Public ReadOnly Property Nam_thu() As Integer
            Get
                Return mNam_thu
            End Get
        End Property
    End Class
End Namespace

