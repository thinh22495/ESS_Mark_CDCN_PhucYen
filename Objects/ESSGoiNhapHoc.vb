'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, June 13, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSGoiNhapHoc
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mSBD As String = ""
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date = Nothing
        Private mTong_diem As Single
        Private mNgay_nhap_hoc As Date = Nothing
        Private mUserName_tiep_nhan As String = ""
        Private mUserID_tiep_nhan As Integer = 0
        Private mKhoi_thi As String = ""
        Private mNganh_tuyen_sinh As String = ""
        Private mDang_ky_hoc As Integer = 0
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mID_gioi_tinh As Integer = 0
        Private mID_lop As Integer = 0
        Private mLop As String = ""
        Private mNam_hoc As String = ""
        Private mSo_tien As Integer = 0
        Private mNguoi_thu As String = ""
        Private mXep_loai_tot_nghiep As String = ""
        Private mTenHuyen As String = ""
        Private mTen_tinh As String = ""
#End Region

#Region "Property"
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
            End Set
        End Property
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
            End Set
        End Property
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
            End Set
        End Property
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
            End Set
        End Property
        Public Property ID_lop() As Integer
            Get
                Return mID_lop
            End Get
            Set(ByVal Value As Integer)
                mID_lop = Value
            End Set
        End Property
        Public Property UserID_tiep_nhan() As Integer
            Get
                Return mUserID_tiep_nhan
            End Get
            Set(ByVal Value As Integer)
                mUserID_tiep_nhan = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property Dang_ky_hoc() As Integer
            Get
                Return mDang_ky_hoc
            End Get
            Set(ByVal Value As Integer)
                mDang_ky_hoc = Value
            End Set
        End Property
        Public Property Nganh_tuyen_sinh() As String
            Get
                Return mNganh_tuyen_sinh
            End Get
            Set(ByVal Value As String)
                mNganh_tuyen_sinh = Value
            End Set
        End Property
        Public Property Lop() As String
            Get
                Return mLop
            End Get
            Set(ByVal Value As String)
                mLop = Value
            End Set
        End Property

        Public Property Khoi_thi() As String
            Get
                Return mKhoi_thi
            End Get
            Set(ByVal Value As String)
                mKhoi_thi = Value
            End Set
        End Property
        Public Property SBD() As String
            Get
                Return mSBD
            End Get
            Set(ByVal Value As String)
                mSBD = Value
            End Set
        End Property
        Public Property Ma_sv() As String
            Get
                Return mMa_sv
            End Get
            Set(ByVal Value As String)
                mMa_sv = Value
            End Set
        End Property

        Public Property Ho_ten() As String
            Get
                Return mHo_ten
            End Get
            Set(ByVal Value As String)
                mHo_ten = Value
            End Set
        End Property
        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Date)
                mNgay_sinh = Value
            End Set
        End Property
        Public Property ID_gioi_tinh() As Integer
            Get
                Return mID_gioi_tinh
            End Get
            Set(ByVal value As Integer)
                mID_gioi_tinh = value
            End Set
        End Property
        Public Property Tong_diem() As Single
            Get
                Return mTong_diem
            End Get
            Set(ByVal Value As Single)
                mTong_diem = Value
            End Set
        End Property
        Public Property Ngay_nhap_hoc() As Date
            Get
                Return mNgay_nhap_hoc
            End Get
            Set(ByVal Value As Date)
                mNgay_nhap_hoc = Value
            End Set
        End Property
        Public Property UserName_tiep_nhan() As String
            Get
                Return mUserName_tiep_nhan
            End Get
            Set(ByVal Value As String)
                mUserName_tiep_nhan = Value
            End Set
        End Property

        Public Property So_tien() As Integer
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Integer)
                mSo_tien = Value
            End Set
        End Property
        Public Property Nguoi_thu() As String
            Get
                Return mNguoi_thu
            End Get
            Set(ByVal Value As String)
                mNguoi_thu = Value
            End Set
        End Property
        Public Property Xep_loai_tot_nghiep() As String
            Get
                Return mXep_loai_tot_nghiep
            End Get
            Set(ByVal Value As String)
                mXep_loai_tot_nghiep = Value
            End Set
        End Property


        Public Property Ten_tinh() As String
            Get
                Return mTen_tinh
            End Get
            Set(ByVal Value As String)
                mTen_tinh = Value
            End Set
        End Property

        Public Property TenHuyen() As String
            Get
                Return mTenHuyen
            End Get
            Set(ByVal Value As String)
                mTenHuyen = Value
            End Set
        End Property

#End Region

    End Class
End Namespace
