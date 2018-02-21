'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, April 17, 2010 
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSHoSo
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mAnh As Byte()
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date = Nothing
        Private mID_gioi_tinh As Integer = 0
        Private mCMND As String = ""
        Private mNoi_cap As String = ""
        Private mNgay_cap As Date = Nothing

        Private mID_dan_toc As Integer = 0
        Private mID_quoc_tich As Integer = 0
        Private mTon_giao As String = ""
        Private mID_thanh_phan_xuat_than As Integer = 0
        Private mNgay_vao_doan As Date = Nothing
        Private mNgay_vao_dang As Date = Nothing
        Private mQue_quan As String = ""
        Private mID_tinh_ns As String = 0
        Private mDia_chi_tt As String = ""
        Private mXa_phuong_tt As String = ""
        Private mID_huyen_tt As String = 0
        Private mID_tinh_tt As String = 0
        Private mID_doi_tuong_TC As Integer = 0
        Private mID_doi_tuong_TS As Integer = 0
        Private mDien_thoai_NR As String = ""
        Private mID_nhom_doi_tuong As Integer = 0
        Private mDia_chi_bao_tin As String = ""
        Private mID_khu_vuc_TS As Integer = 0
        Private mDoi_tuong_du_thi As String = ""
        Private mDiem1 As Double = 0
        Private mDiem2 As Double = 0
        Private mDiem3 As Double = 0
        Private mDiem4 As Double = 0
        Private mTong_diem As Double = 0
        Private mSBD As String = ""
        Private mNganh_tuyen_sinh As String = ""
        Private mKhoi_thi As String = ""
        Private mXep_loai_hoc_tap As String = ""
        Private mXep_loai_hanh_kiem As String = ""
        Private mXep_loai_tot_nghiep As String = ""
        Private mNam_tot_nghiep As String = ""
        Private mDiem_thuong As Double = 0
        Private mLy_do_thuong_diem As String = ""
        Private mKhen_thuong_ky_luat As String = ""
        Private mQua_trinh_HT_LD As String = ""
        Private mHo_ten_cha As String = ""
        Private mID_quoc_tich_cha As Integer = 0
        Private mID_dan_toc_cha As Integer = 0
        Private mTon_giao_cha As String = ""
        Private mHo_khau_TT_cha As String = ""
        Private mHoat_dong_XH_CT_cha As String = ""
        Private mHo_ten_me As String = ""
        Private mID_quoc_tich_me As Integer = 0
        Private mID_dan_toc_me As Integer = 0
        Private mTon_giao_me As String = ""
        Private mHo_khau_TT_me As String = ""
        Private mHoat_dong_XH_CT_me As String = ""
        Private mHo_ten_vo_chong As String = ""
        Private mID_quoc_tich_vo_chong As Integer = 0
        Private mID_dan_toc_vo_chong As Integer = 0
        Private mTon_giao_vo_chong As String = ""
        Private mHo_khau_TT_vo_chong As String = ""
        Private mHoat_dong_XH_CT_vo_chong As String = ""
        Private mHo_ten_nghe_nghiep_anh_em As String = ""
        Private mDang_ky_hoc As Boolean = False
        Private mHoten_Order As String = ""
        Private mChuyen_nganh_dang_ky As String = ""
        Private mLop As String = ""
        Private mNgoai_ngu As String = ""
        Private mUserID As Integer = 0
        Private mNgay_nhap_hoc As Date = Nothing
        Private mUserName_tiep_nhan As String = ""
        Private mUserID_tiep_nhan As Integer = 0
        Private mDienthoai_canhan As String = ""
        Private mEmail As String = ""
        Private mNoiO_hiennay As String = ""
        Private mNamsinh_cha As String = ""
        Private mNamsinh_me As String = ""
        Private mIDCard As String = ""
        Private mNam_nhap_hoc As Integer = 0
#End Region

#Region "Property"
        Public Property Dienthoai_canhan() As String
            Get
                Return mDienthoai_canhan
            End Get
            Set(ByVal Value As String)
                mDienthoai_canhan = Value
            End Set
        End Property
        Public Property Email() As String
            Get
                Return mEmail
            End Get
            Set(ByVal Value As String)
                mEmail = Value
            End Set
        End Property
        Public Property NoiO_hiennay() As String
            Get
                Return mNoiO_hiennay
            End Get
            Set(ByVal Value As String)
                mNoiO_hiennay = Value
            End Set
        End Property
        Public Property Namsinh_cha() As String
            Get
                Return mNamsinh_cha
            End Get
            Set(ByVal Value As String)
                mNamsinh_cha = Value
            End Set
        End Property
        Public Property Namsinh_me() As String
            Get
                Return mNamsinh_me
            End Get
            Set(ByVal Value As String)
                mNamsinh_me = Value
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
        Public Property Anh() As Byte()
            Get
                Return mAnh
            End Get
            Set(ByVal Value As Byte())
                mAnh = Value
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
        Public Property CMND() As String
            Get
                Return mCMND
            End Get
            Set(ByVal Value As String)
                mCMND = Value
            End Set
        End Property
        Public Property Noi_cap() As String
            Get
                Return mNoi_cap
            End Get
            Set(ByVal Value As String)
                mNoi_cap = Value
            End Set
        End Property
        Public Property Ngay_cap() As Date
            Get
                Return mNgay_cap
            End Get
            Set(ByVal Value As Date)
                mNgay_cap = Value
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
            Set(ByVal Value As Integer)
                mID_gioi_tinh = Value
            End Set
        End Property
        Public Property ID_dan_toc() As Integer
            Get
                Return mID_dan_toc
            End Get
            Set(ByVal Value As Integer)
                mID_dan_toc = Value
            End Set
        End Property
        Public Property ID_quoc_tich() As Integer
            Get
                Return mID_quoc_tich
            End Get
            Set(ByVal Value As Integer)
                mID_quoc_tich = Value
            End Set
        End Property
        Public Property Ton_giao() As String
            Get
                Return mTon_giao
            End Get
            Set(ByVal Value As String)
                mTon_giao = Value
            End Set
        End Property
        Public Property ID_thanh_phan_xuat_than() As Integer
            Get
                Return mID_thanh_phan_xuat_than
            End Get
            Set(ByVal Value As Integer)
                mID_thanh_phan_xuat_than = Value
            End Set
        End Property
        Public Property Ngay_vao_doan() As Date
            Get
                Return mNgay_vao_doan
            End Get
            Set(ByVal Value As Date)
                mNgay_vao_doan = Value
            End Set
        End Property
        Public Property Ngay_vao_dang() As Date
            Get
                Return mNgay_vao_dang
            End Get
            Set(ByVal Value As Date)
                mNgay_vao_dang = Value
            End Set
        End Property
        Public Property Que_quan() As String
            Get
                Return mQue_quan
            End Get
            Set(ByVal Value As String)
                mQue_quan = Value
            End Set
        End Property
        Public Property ID_tinh_ns() As String
            Get
                Return mID_tinh_ns
            End Get
            Set(ByVal Value As String)
                mID_tinh_ns = Value
            End Set
        End Property
        Public Property Dia_chi_tt() As String
            Get
                Return mDia_chi_tt
            End Get
            Set(ByVal Value As String)
                mDia_chi_tt = Value
            End Set
        End Property
        Public Property Xa_phuong_tt() As String
            Get
                Return mXa_phuong_tt
            End Get
            Set(ByVal Value As String)
                mXa_phuong_tt = Value
            End Set
        End Property
        Public Property ID_huyen_tt() As String
            Get
                Return mID_huyen_tt
            End Get
            Set(ByVal Value As String)
                mID_huyen_tt = Value
            End Set
        End Property
        Public Property ID_tinh_tt() As String
            Get
                Return mID_tinh_tt
            End Get
            Set(ByVal Value As String)
                mID_tinh_tt = Value
            End Set
        End Property
        Public Property ID_doi_tuong_TC() As Integer
            Get
                Return mID_doi_tuong_TC
            End Get
            Set(ByVal Value As Integer)
                mID_doi_tuong_TC = Value
            End Set
        End Property
        Public Property ID_doi_tuong_TS() As Integer
            Get
                Return mID_doi_tuong_TS
            End Get
            Set(ByVal Value As Integer)
                mID_doi_tuong_TS = Value
            End Set
        End Property
        Public Property Dien_thoai_NR() As String
            Get
                Return mDien_thoai_NR
            End Get
            Set(ByVal Value As String)
                mDien_thoai_NR = Value
            End Set
        End Property
        Public Property ID_nhom_doi_tuong() As Integer
            Get
                Return mID_nhom_doi_tuong
            End Get
            Set(ByVal Value As Integer)
                mID_nhom_doi_tuong = Value
            End Set
        End Property
        Public Property Dia_chi_bao_tin() As String
            Get
                Return mDia_chi_bao_tin
            End Get
            Set(ByVal Value As String)
                mDia_chi_bao_tin = Value
            End Set
        End Property
        Public Property ID_khu_vuc_TS() As Integer
            Get
                Return mID_khu_vuc_TS
            End Get
            Set(ByVal Value As Integer)
                mID_khu_vuc_TS = Value
            End Set
        End Property
        Public Property Doi_tuong_du_thi() As String
            Get
                Return mDoi_tuong_du_thi
            End Get
            Set(ByVal Value As String)
                mDoi_tuong_du_thi = Value
            End Set
        End Property
        Public Property Diem1() As Double
            Get
                Return mDiem1
            End Get
            Set(ByVal Value As Double)
                mDiem1 = Value
            End Set
        End Property
        Public Property Diem2() As Double
            Get
                Return mDiem2
            End Get
            Set(ByVal Value As Double)
                mDiem2 = Value
            End Set
        End Property
        Public Property Diem3() As Double
            Get
                Return mDiem3
            End Get
            Set(ByVal Value As Double)
                mDiem3 = Value
            End Set
        End Property
        Public Property Diem4() As Double
            Get
                Return mDiem4
            End Get
            Set(ByVal Value As Double)
                mDiem4 = Value
            End Set
        End Property
        Public Property Tong_diem() As Double
            Get
                Return mTong_diem
            End Get
            Set(ByVal Value As Double)
                mTong_diem = Value
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
        Public Property Nganh_tuyen_sinh() As String
            Get
                Return mNganh_tuyen_sinh
            End Get
            Set(ByVal Value As String)
                mNganh_tuyen_sinh = Value
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
        Public Property Xep_loai_hoc_tap() As String
            Get
                Return mXep_loai_hoc_tap
            End Get
            Set(ByVal Value As String)
                mXep_loai_hoc_tap = Value
            End Set
        End Property
        Public Property Xep_loai_hanh_kiem() As String
            Get
                Return mXep_loai_hanh_kiem
            End Get
            Set(ByVal Value As String)
                mXep_loai_hanh_kiem = Value
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
        Public Property Nam_tot_nghiep() As String
            Get
                Return mNam_tot_nghiep
            End Get
            Set(ByVal Value As String)
                mNam_tot_nghiep = Value
            End Set
        End Property
        Public Property Diem_thuong() As Double
            Get
                Return mDiem_thuong
            End Get
            Set(ByVal Value As Double)
                mDiem_thuong = Value
            End Set
        End Property
        Public Property Ly_do_thuong_diem() As String
            Get
                Return mLy_do_thuong_diem
            End Get
            Set(ByVal Value As String)
                mLy_do_thuong_diem = Value
            End Set
        End Property
        Public Property Khen_thuong_ky_luat() As String
            Get
                Return mKhen_thuong_ky_luat
            End Get
            Set(ByVal Value As String)
                mKhen_thuong_ky_luat = Value
            End Set
        End Property
        Public Property Qua_trinh_HT_LD() As String
            Get
                Return mQua_trinh_HT_LD
            End Get
            Set(ByVal Value As String)
                mQua_trinh_HT_LD = Value
            End Set
        End Property
        Public Property Ho_ten_cha() As String
            Get
                Return mHo_ten_cha
            End Get
            Set(ByVal Value As String)
                mHo_ten_cha = Value
            End Set
        End Property
        Public Property ID_quoc_tich_cha() As Integer
            Get
                Return mID_quoc_tich_cha
            End Get
            Set(ByVal Value As Integer)
                mID_quoc_tich_cha = Value
            End Set
        End Property
        Public Property ID_dan_toc_cha() As Integer
            Get
                Return mID_dan_toc_cha
            End Get
            Set(ByVal Value As Integer)
                mID_dan_toc_cha = Value
            End Set
        End Property
        Public Property Ton_giao_cha() As String
            Get
                Return mTon_giao_cha
            End Get
            Set(ByVal Value As String)
                mTon_giao_cha = Value
            End Set
        End Property
        Public Property Ho_khau_TT_cha() As String
            Get
                Return mHo_khau_TT_cha
            End Get
            Set(ByVal Value As String)
                mHo_khau_TT_cha = Value
            End Set
        End Property
        Public Property Hoat_dong_XH_CT_cha() As String
            Get
                Return mHoat_dong_XH_CT_cha
            End Get
            Set(ByVal Value As String)
                mHoat_dong_XH_CT_cha = Value
            End Set
        End Property
        Public Property Ho_ten_me() As String
            Get
                Return mHo_ten_me
            End Get
            Set(ByVal Value As String)
                mHo_ten_me = Value
            End Set
        End Property
        Public Property ID_quoc_tich_me() As Integer
            Get
                Return mID_quoc_tich_me
            End Get
            Set(ByVal Value As Integer)
                mID_quoc_tich_me = Value
            End Set
        End Property
        Public Property ID_dan_toc_me() As Integer
            Get
                Return mID_dan_toc_me
            End Get
            Set(ByVal Value As Integer)
                mID_dan_toc_me = Value
            End Set
        End Property
        Public Property Ton_giao_me() As String
            Get
                Return mTon_giao_me
            End Get
            Set(ByVal Value As String)
                mTon_giao_me = Value
            End Set
        End Property
        Public Property Ho_khau_TT_me() As String
            Get
                Return mHo_khau_TT_me
            End Get
            Set(ByVal Value As String)
                mHo_khau_TT_me = Value
            End Set
        End Property
        Public Property Hoat_dong_XH_CT_me() As String
            Get
                Return mHoat_dong_XH_CT_me
            End Get
            Set(ByVal Value As String)
                mHoat_dong_XH_CT_me = Value
            End Set
        End Property
        Public Property Ho_ten_vo_chong() As String
            Get
                Return mHo_ten_vo_chong
            End Get
            Set(ByVal Value As String)
                mHo_ten_vo_chong = Value
            End Set
        End Property
        Public Property ID_quoc_tich_vo_chong() As Integer
            Get
                Return mID_quoc_tich_vo_chong
            End Get
            Set(ByVal Value As Integer)
                mID_quoc_tich_vo_chong = Value
            End Set
        End Property
        Public Property ID_dan_toc_vo_chong() As Integer
            Get
                Return mID_dan_toc_vo_chong
            End Get
            Set(ByVal Value As Integer)
                mID_dan_toc_vo_chong = Value
            End Set
        End Property
        Public Property Ton_giao_vo_chong() As String
            Get
                Return mTon_giao_vo_chong
            End Get
            Set(ByVal Value As String)
                mTon_giao_vo_chong = Value
            End Set
        End Property
        Public Property Ho_khau_TT_vo_chong() As String
            Get
                Return mHo_khau_TT_vo_chong
            End Get
            Set(ByVal Value As String)
                mHo_khau_TT_vo_chong = Value
            End Set
        End Property
        Public Property Hoat_dong_XH_CT_vo_chong() As String
            Get
                Return mHoat_dong_XH_CT_vo_chong
            End Get
            Set(ByVal Value As String)
                mHoat_dong_XH_CT_vo_chong = Value
            End Set
        End Property
        Public Property Ho_ten_nghe_nghiep_anh_em() As String
            Get
                Return mHo_ten_nghe_nghiep_anh_em
            End Get
            Set(ByVal Value As String)
                mHo_ten_nghe_nghiep_anh_em = Value
            End Set
        End Property
        Public Property Dang_ky_hoc() As Boolean
            Get
                Return mDang_ky_hoc
            End Get
            Set(ByVal Value As Boolean)
                mDang_ky_hoc = Value
            End Set
        End Property
        Public Property Hoten_Order() As String
            Get
                Return mHoten_Order
            End Get
            Set(ByVal Value As String)
                mHoten_Order = Value
            End Set
        End Property
        Public Property Chuyen_nganh_dang_ky() As String
            Get
                Return mChuyen_nganh_dang_ky
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh_dang_ky = Value
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
        Public Property Ngoai_ngu() As String
            Get
                Return mNgoai_ngu
            End Get
            Set(ByVal Value As String)
                mNgoai_ngu = Value
            End Set
        End Property
        Public Property UserID() As Integer
            Get
                Return mUserID
            End Get
            Set(ByVal Value As Integer)
                mUserID = Value
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
        Public Property UserID_tiep_nhan() As Integer
            Get
                Return mUserID_tiep_nhan
            End Get
            Set(ByVal Value As Integer)
                mUserID_tiep_nhan = Value
            End Set
        End Property

        Public Property IDCard() As String
            Get
                Return mIDCard
            End Get
            Set(ByVal Value As String)
                mIDCard = Value
            End Set
        End Property

        Public Property Nam_nhap_hoc() As Integer
            Get
                Return mNam_nhap_hoc
            End Get
            Set(ByVal Value As Integer)
                mNam_nhap_hoc = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
