'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSChuongTrinhDaoTaoChiTiet
        Inherits ESSMonHoc
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_dt_mon As Integer = 0
        Private mID_dt As Integer = 0
        Private mKy_thu As Integer = 0
        Private mSo_hoc_trinh As Integer = 0
        Private mLy_thuyet As Integer = 0
        Private mThuc_hanh As Integer = 0
        Private mBai_tap As Integer = 0
        Private mBai_tap_lon As Integer = 0
        Private mThuc_tap As Integer = 0
        Private mTu_chon As Boolean = 0
        Private mSTT_mon As Integer = 0
        Private mHe_so As Double = 0
        Private mKien_thuc As Integer = 0
        Private mNhom_tu_chon As Integer = 0
        Private mTen_kien_thuc As String = ""
        Private mChon As String = ""
        Private mKhong_tinh_TBCHT As Boolean = False
        Private mHP_tuong_duong As Boolean = False
        Private mMon_tot_nghiep As Boolean = False
        Private mHocPhan_DaiCuong As Boolean = False
        Private mTu_hoc As Integer = 0
        Private mMa_khoa_phu_trach As String = ""
        Private mSo_hoc_trinh_tien_quyet As Integer
        Private mTy_le_ly_thuyet As Integer = 0
        Private mTy_le_thuc_hanh As Integer = 0
        Private mSo_tien_tai_lieu As Integer = 0
        Private mMonRangBuoc As ESSChuongTrinhDaoTaoMonHocRangBuoc
        Private mChuongTrinhDaoTaoChiTiet As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal ctdtChiTiet As ESSChuongTrinhDaoTaoChiTiet)
            mChuongTrinhDaoTaoChiTiet.Add(ctdtChiTiet)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mChuongTrinhDaoTaoChiTiet.RemoveAt(idx)
        End Sub
#End Region

#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mChuongTrinhDaoTaoChiTiet.Count
            End Get
        End Property
        Public Property ESSChuongTrinhDaoTaoChiTiet(ByVal idx As Integer) As ESSChuongTrinhDaoTaoChiTiet
            Get
                Return CType(mChuongTrinhDaoTaoChiTiet(idx), ESSChuongTrinhDaoTaoChiTiet)
            End Get
            Set(ByVal Value As ESSChuongTrinhDaoTaoChiTiet)
                mChuongTrinhDaoTaoChiTiet(idx) = Value
            End Set
        End Property

        Public Function Tim_idx(ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To mChuongTrinhDaoTaoChiTiet.Count - 1
                If CType(mChuongTrinhDaoTaoChiTiet(i), ESSChuongTrinhDaoTaoChiTiet).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Property ID_dt_mon() As Integer
            Get
                Return mID_dt_mon
            End Get
            Set(ByVal Value As Integer)
                mID_dt_mon = Value
            End Set
        End Property
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
        Public Property Ky_thu() As Integer
            Get
                Return mKy_thu
            End Get
            Set(ByVal Value As Integer)
                mKy_thu = Value
            End Set
        End Property
        Public Property So_hoc_trinh() As Integer
            Get
                Return mSo_hoc_trinh
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh = Value
            End Set
        End Property
        Public Property Ly_thuyet() As Integer
            Get
                Return mLy_thuyet
            End Get
            Set(ByVal Value As Integer)
                mLy_thuyet = Value
            End Set
        End Property
        Public Property Thuc_hanh() As Integer
            Get
                Return mThuc_hanh
            End Get
            Set(ByVal Value As Integer)
                mThuc_hanh = Value
            End Set
        End Property
        Public Property Bai_tap() As Integer
            Get
                Return mBai_tap
            End Get
            Set(ByVal Value As Integer)
                mBai_tap = Value
            End Set
        End Property
        Public Property Bai_tap_lon() As Integer
            Get
                Return mBai_tap_lon
            End Get
            Set(ByVal Value As Integer)
                mBai_tap_lon = Value
            End Set
        End Property
        Public Property Thuc_tap() As Integer
            Get
                Return mThuc_tap
            End Get
            Set(ByVal Value As Integer)
                mThuc_tap = Value
            End Set
        End Property
        Public Property Tu_chon() As Boolean
            Get
                Return mTu_chon
            End Get
            Set(ByVal Value As Boolean)
                mTu_chon = Value
            End Set
        End Property
        Public Property STT_mon() As Integer
            Get
                Return mSTT_mon
            End Get
            Set(ByVal Value As Integer)
                mSTT_mon = Value
            End Set
        End Property
        Public Property He_so() As Double
            Get
                Return mHe_so
            End Get
            Set(ByVal Value As Double)
                mHe_so = Value
            End Set
        End Property
        Public Property Kien_thuc() As Integer
            Get
                Return mKien_thuc
            End Get
            Set(ByVal Value As Integer)
                mKien_thuc = Value
            End Set
        End Property
        Public Property Nhom_tu_chon() As Integer
            Get
                Return mNhom_tu_chon
            End Get
            Set(ByVal Value As Integer)
                mNhom_tu_chon = Value
            End Set
        End Property
        Public Property Ten_kien_thuc() As String
            Get
                Return mTen_kien_thuc
            End Get
            Set(ByVal Value As String)
                mTen_kien_thuc = Value
            End Set
        End Property
        Public Property Chon() As String
            Get
                Return mChon
            End Get
            Set(ByVal Value As String)
                mChon = Value
            End Set
        End Property
        Public Property Khong_tinh_TBCHT() As Boolean
            Get
                Return mKhong_tinh_TBCHT
            End Get
            Set(ByVal Value As Boolean)
                mKhong_tinh_TBCHT = Value
            End Set
        End Property
        Public Property Mon_tot_nghiep() As Boolean
            Get
                Return mMon_tot_nghiep
            End Get
            Set(ByVal Value As Boolean)
                mMon_tot_nghiep = Value
            End Set
        End Property
        Public Property HocPhan_DaiCuong() As Boolean
            Get
                Return mHocPhan_DaiCuong
            End Get
            Set(ByVal Value As Boolean)
                mHocPhan_DaiCuong = Value
            End Set
        End Property
        Public Property Tu_hoc() As Integer
            Get
                Return mTu_hoc
            End Get
            Set(ByVal Value As Integer)
                mTu_hoc = Value
            End Set
        End Property
        Public Property So_hoc_trinh_tien_quyet() As Integer
            Get
                Return mSo_hoc_trinh_tien_quyet
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_tien_quyet = Value
            End Set
        End Property

        Public Property Ma_khoa_phu_trach() As String
            Get
                Return mMa_khoa_phu_trach
            End Get
            Set(ByVal Value As String)
                mMa_khoa_phu_trach = Value
            End Set
        End Property
        Public Property MonRangBuoc() As ESSChuongTrinhDaoTaoMonHocRangBuoc
            Get
                Return mMonRangBuoc
            End Get
            Set(ByVal Value As ESSChuongTrinhDaoTaoMonHocRangBuoc)
                mMonRangBuoc = Value
            End Set
        End Property

        Public Property Ty_le_ly_thuyet() As Integer
            Get
                Return mTy_le_ly_thuyet
            End Get
            Set(ByVal Value As Integer)
                mTy_le_ly_thuyet = Value
            End Set
        End Property
        Public Property Ty_le_thuc_hanh() As Integer
            Get
                Return mTy_le_thuc_hanh
            End Get
            Set(ByVal Value As Integer)
                mTy_le_thuc_hanh = Value
            End Set
        End Property

        Public Property HP_tuong_duong() As Boolean
            Get
                Return mHP_tuong_duong
            End Get
            Set(ByVal Value As Boolean)
                mHP_tuong_duong = Value
            End Set
        End Property

        Public Property So_tien_tai_lieu() As Integer
            Get
                Return mSo_tien_tai_lieu
            End Get
            Set(ByVal Value As Integer)
                mSo_tien_tai_lieu = Value
            End Set
        End Property
#End Region
    End Class
End Namespace