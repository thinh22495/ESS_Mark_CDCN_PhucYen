'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Friday, August 01, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class HoSoSinhVien
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mAnh As Byte()
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date
        Private mID_gioi_tinh As Integer = 0
        Private mID_dan_toc As Integer = 0
        Private mID_quoc_tich As Integer = 0
        Private mTon_giao As String = ""
        Private mID_thanh_phan_xuat_than As Integer = 0
        Private mNgay_vao_doan As Date
        Private mNgay_vao_dang As Date
        Private mQue_quan As String = ""
        Private mID_tinh_ns As Integer = 0
        Private mDia_chi_tt As String = ""
        Private mXa_phuong_tt As String = ""
        Private mID_huyen_tt As Integer = 0
        Private mID_tinh_tt As Integer = 0
        Private mID_doi_tuong_TC As Integer = 0
        Private mID_doi_tuong_TS As Integer = 0
        Private mDien_thoai_NR As String = ""
        Private mID_nhom_doi_tuong As Integer = 0
        Private mDia_chi_bao_tin As String = ""
        Private mID_khu_vuc_TS As Integer = 0
        Private mDoi_tuong_du_thi As String = ""
        Private mDiem1 As Single
        Private mDiem2 As Single
        Private mDiem3 As Single
        Private mDiem4 As Single
        Private mTong_diem As Single
        Private mSBD As String = ""
        Private mNganh_tuyen_sinh As String = ""
        Private mKhoi_thi As String = ""
        Private mXep_loai_hoc_tap As String = ""
        Private mXep_loai_hanh_kiem As String = ""
        Private mXep_loai_tot_nghiep As String = ""
        Private mNam_tot_nghiep As String = ""
        Private mDiem_thuong As Integer = 0
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
        Private mDang_ky_hoc As Boolean = 0
        Private mHoten_Order As String = ""
        Private mChuyen_nganh As String = ""
        Private mLop As String = ""
        Private mNgoai_ngu As String = ""
        Private mUserID As Integer = 0
        Private mNgay_nhap_hoc As Date
        Private mUserName_tiep_nhan As String = ""
        Private mUserID_tiep_nhan As Integer = 0
        Private mCMND As String = ""
        Private mMat_khau As String = ""
        Private mActive As Boolean = 0
        Private mDa_tot_nghiep As Boolean = 0
        Private mID_lop As Integer = 0
        Private mTen_lop As String = ""
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mNien_khoa As String = ""
        Private mID_dt As Integer = 0
        Private mSo_sv As Integer = 0
        Private mRa_truong As Boolean = 0
        Private mMa_he As String = ""
        Private mTen_he As String = ""
        Private mMa_khoa As String = ""
        Private mTen_khoa As String = ""
        Private mID_nganh As Integer = 0
        Private mMa_chuyen_nganh As String = ""
        Private mChuyen_nganh1 As String = ""
        Private mMa_nganh As String = ""
        Private mTen_nganh As String = ""
        Private mMa_dan_toc_cha As String = ""
        Private mDan_toc_cha As String = ""
        Private mMa_quoc_tich_me As String = ""
        Private mQuoc_tichMe As String = ""
        Private mMa_dan_toc_me As String = ""
        Private mDan_toc_me As String = ""
        Private mMa_quoc_tich_cha As String = ""
        Private mQuoc_tich_cha As String = ""
        Private mMa_quoc_tich_vochong As String = ""
        Private mQuoc_tich_vochong As String = ""
        Private mMa_dan_toc As String = ""
        Private mDan_toc As String = ""
        Private mMa_quoc_tich As String = ""
        Private mQuoc_tich As String = ""
        Private mGioi_tinh As String = ""
        Private mDan_toc_vochong As String = ""
        Private mMa_dan_toc_vochong As String = ""
        Private mTen_thanh_phan As String = ""
        Private mMa_nhom As String = ""
        Private mTen_nhom As String = ""
        Private mTen_huyen_tt As String = ""
        Private mTen_tinh_tt As String = ""
        Private mMa_kv As String = ""
        Private mTen_kv As String = ""
        Private mMa_dt_ts As String = ""
        Private mTen_dt_ts As String = ""
        Private mPhan_tram_mien_giam As Integer = 0
        Private mMa_dt_tc As String = ""
        Private mTen_dt_tc As String = ""
        Private mSotien_trocap As Integer = 0
        Private mTen_tinh_ns As String = ""
#End Region

#Region "Property"
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
        Public Property ID_tinh_ns() As Integer
            Get
                Return mID_tinh_ns
            End Get
            Set(ByVal Value As Integer)
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
        Public Property ID_huyen_tt() As Integer
            Get
                Return mID_huyen_tt
            End Get
            Set(ByVal Value As Integer)
                mID_huyen_tt = Value
            End Set
        End Property
        Public Property ID_tinh_tt() As Integer
            Get
                Return mID_tinh_tt
            End Get
            Set(ByVal Value As Integer)
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
        Public Property Diem1() As Single
            Get
                Return mDiem1
            End Get
            Set(ByVal Value As Single)
                mDiem1 = Value
            End Set
        End Property
        Public Property Diem2() As Single
            Get
                Return mDiem2
            End Get
            Set(ByVal Value As Single)
                mDiem2 = Value
            End Set
        End Property
        Public Property Diem3() As Single
            Get
                Return mDiem3
            End Get
            Set(ByVal Value As Single)
                mDiem3 = Value
            End Set
        End Property
        Public Property Diem4() As Single
            Get
                Return mDiem4
            End Get
            Set(ByVal Value As Single)
                mDiem4 = Value
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
        Public Property Diem_thuong() As Integer
            Get
                Return mDiem_thuong
            End Get
            Set(ByVal Value As Integer)
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
        Public Property Chuyen_nganh() As String
            Get
                Return mChuyen_nganh
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh = Value
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
        Public Property CMND() As String
            Get
                Return mCMND
            End Get
            Set(ByVal Value As String)
                mCMND = Value
            End Set
        End Property
        Public Property Mat_khau() As String
            Get
                Return mMat_khau
            End Get
            Set(ByVal Value As String)
                mMat_khau = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return mActive
            End Get
            Set(ByVal Value As Boolean)
                mActive = Value
            End Set
        End Property
        Public Property Da_tot_nghiep() As Boolean
            Get
                Return mDa_tot_nghiep
            End Get
            Set(ByVal Value As Boolean)
                mDa_tot_nghiep = Value
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
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
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
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
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
        Public Property Nien_khoa() As String
            Get
                Return mNien_khoa
            End Get
            Set(ByVal Value As String)
                mNien_khoa = Value
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
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
            End Set
        End Property
        Public Property Ra_truong() As Boolean
            Get
                Return mRa_truong
            End Get
            Set(ByVal Value As Boolean)
                mRa_truong = Value
            End Set
        End Property
        Public Property Ma_he() As String
            Get
                Return mMa_he
            End Get
            Set(ByVal Value As String)
                mMa_he = Value
            End Set
        End Property
        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal Value As String)
                mTen_he = Value
            End Set
        End Property
        Public Property Ma_khoa() As String
            Get
                Return mMa_khoa
            End Get
            Set(ByVal Value As String)
                mMa_khoa = Value
            End Set
        End Property
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property
        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
            End Set
        End Property
        Public Property Ma_chuyen_nganh() As String
            Get
                Return mMa_chuyen_nganh
            End Get
            Set(ByVal Value As String)
                mMa_chuyen_nganh = Value
            End Set
        End Property
        Public Property Chuyen_nganh1() As String
            Get
                Return mChuyen_nganh1
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh1 = Value
            End Set
        End Property
        Public Property Ma_nganh() As String
            Get
                Return mMa_nganh
            End Get
            Set(ByVal Value As String)
                mMa_nganh = Value
            End Set
        End Property
        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
            End Set
        End Property
        Public Property Ma_dan_toc_cha() As String
            Get
                Return mMa_dan_toc_cha
            End Get
            Set(ByVal Value As String)
                mMa_dan_toc_cha = Value
            End Set
        End Property
        Public Property Dan_toc_cha() As String
            Get
                Return mDan_toc_cha
            End Get
            Set(ByVal Value As String)
                mDan_toc_cha = Value
            End Set
        End Property
        Public Property Ma_quoc_tich_me() As String
            Get
                Return mMa_quoc_tich_me
            End Get
            Set(ByVal Value As String)
                mMa_quoc_tich_me = Value
            End Set
        End Property
        Public Property Quoc_tichMe() As String
            Get
                Return mQuoc_tichMe
            End Get
            Set(ByVal Value As String)
                mQuoc_tichMe = Value
            End Set
        End Property
        Public Property Ma_dan_toc_me() As String
            Get
                Return mMa_dan_toc_me
            End Get
            Set(ByVal Value As String)
                mMa_dan_toc_me = Value
            End Set
        End Property
        Public Property Dan_toc_me() As String
            Get
                Return mDan_toc_me
            End Get
            Set(ByVal Value As String)
                mDan_toc_me = Value
            End Set
        End Property
        Public Property Ma_quoc_tich_cha() As String
            Get
                Return mMa_quoc_tich_cha
            End Get
            Set(ByVal Value As String)
                mMa_quoc_tich_cha = Value
            End Set
        End Property
        Public Property Quoc_tich_cha() As String
            Get
                Return mQuoc_tich_cha
            End Get
            Set(ByVal Value As String)
                mQuoc_tich_cha = Value
            End Set
        End Property
        Public Property Ma_quoc_tich_vochong() As String
            Get
                Return mMa_quoc_tich_vochong
            End Get
            Set(ByVal Value As String)
                mMa_quoc_tich_vochong = Value
            End Set
        End Property
        Public Property Quoc_tich_vochong() As String
            Get
                Return mQuoc_tich_vochong
            End Get
            Set(ByVal Value As String)
                mQuoc_tich_vochong = Value
            End Set
        End Property
        Public Property Ma_dan_toc() As String
            Get
                Return mMa_dan_toc
            End Get
            Set(ByVal Value As String)
                mMa_dan_toc = Value
            End Set
        End Property
        Public Property Dan_toc() As String
            Get
                Return mDan_toc
            End Get
            Set(ByVal Value As String)
                mDan_toc = Value
            End Set
        End Property
        Public Property Ma_quoc_tich() As String
            Get
                Return mMa_quoc_tich
            End Get
            Set(ByVal Value As String)
                mMa_quoc_tich = Value
            End Set
        End Property
        Public Property Quoc_tich() As String
            Get
                Return mQuoc_tich
            End Get
            Set(ByVal Value As String)
                mQuoc_tich = Value
            End Set
        End Property
        Public Property Gioi_tinh() As String
            Get
                Return mGioi_tinh
            End Get
            Set(ByVal Value As String)
                mGioi_tinh = Value
            End Set
        End Property
        Public Property Dan_toc_vochong() As String
            Get
                Return mDan_toc_vochong
            End Get
            Set(ByVal Value As String)
                mDan_toc_vochong = Value
            End Set
        End Property
        Public Property Ma_dan_toc_vochong() As String
            Get
                Return mMa_dan_toc_vochong
            End Get
            Set(ByVal Value As String)
                mMa_dan_toc_vochong = Value
            End Set
        End Property
        Public Property Ten_thanh_phan() As String
            Get
                Return mTen_thanh_phan
            End Get
            Set(ByVal Value As String)
                mTen_thanh_phan = Value
            End Set
        End Property
        Public Property Ma_nhom() As String
            Get
                Return mMa_nhom
            End Get
            Set(ByVal Value As String)
                mMa_nhom = Value
            End Set
        End Property
        Public Property Ten_nhom() As String
            Get
                Return mTen_nhom
            End Get
            Set(ByVal Value As String)
                mTen_nhom = Value
            End Set
        End Property
        Public Property Ten_huyen_tt() As String
            Get
                Return mTen_huyen_tt
            End Get
            Set(ByVal Value As String)
                mTen_huyen_tt = Value
            End Set
        End Property
        Public Property Ten_tinh_tt() As String
            Get
                Return mTen_tinh_tt
            End Get
            Set(ByVal Value As String)
                mTen_tinh_tt = Value
            End Set
        End Property
        Public Property Ma_kv() As String
            Get
                Return mMa_kv
            End Get
            Set(ByVal Value As String)
                mMa_kv = Value
            End Set
        End Property
        Public Property Ten_kv() As String
            Get
                Return mTen_kv
            End Get
            Set(ByVal Value As String)
                mTen_kv = Value
            End Set
        End Property
        Public Property Ma_dt_ts() As String
            Get
                Return mMa_dt_ts
            End Get
            Set(ByVal Value As String)
                mMa_dt_ts = Value
            End Set
        End Property
        Public Property Ten_dt_ts() As String
            Get
                Return mTen_dt_ts
            End Get
            Set(ByVal Value As String)
                mTen_dt_ts = Value
            End Set
        End Property
        Public Property Phan_tram_mien_giam() As Integer
            Get
                Return mPhan_tram_mien_giam
            End Get
            Set(ByVal Value As Integer)
                mPhan_tram_mien_giam = Value
            End Set
        End Property
        Public Property Ma_dt_tc() As String
            Get
                Return mMa_dt_tc
            End Get
            Set(ByVal Value As String)
                mMa_dt_tc = Value
            End Set
        End Property
        Public Property Ten_dt_tc() As String
            Get
                Return mTen_dt_tc
            End Get
            Set(ByVal Value As String)
                mTen_dt_tc = Value
            End Set
        End Property
        Public Property Sotien_trocap() As Integer
            Get
                Return mSotien_trocap
            End Get
            Set(ByVal Value As Integer)
                mSotien_trocap = Value
            End Set
        End Property
        Public Property Ten_tinh_ns() As String
            Get
                Return mTen_tinh_ns
            End Get
            Set(ByVal Value As String)
                mTen_tinh_ns = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
