Namespace Objects
    Public Class ESSSu_kien
        Private mID As Long
        Private mID_phong As Integer
        Private mID_mon As Integer
        Private mID_bm As Integer
        Private mID_cb As Integer
        Private mID_lop_tc As Integer
        Private mTen_phong As String
        Private mKy_hieu As String
        Private mTen_mon As String
        Private mTen As String
        Private mHoten As String
        Private mTen_lop As String
        Private mCa_hoc As eCA_HOC
        Private mThu As eTHU
        Private mTiet As Integer
        Private mSo_tiet As Integer
        Private mLoai_tiet As eLOAI_TIET
        Private mDa_xep_lich As Boolean
        Private mThieu_dulieu As Boolean
        Private mUpdate As Boolean
        Private mTu_ngay As Date
        Private mDen_ngay As Date

        Public Sub New()
            Me.mID = -1
            Me.mID_phong = -1
            Me.mID_mon = -1
            Me.mID_bm = -1
            Me.mID_cb = -1
            Me.mID_lop_tc = -1
            Me.mTen_phong = ""
            Me.mKy_hieu = ""
            Me.mTen_mon = ""
            Me.mTen = ""
            Me.mHoten = ""
            Me.mTen_lop = ""
            Me.mCa_hoc = eCA_HOC.KHONG_XAC_DINH
            Me.mThu = eTHU.KHONG_XAC_DINH
            Me.mTiet = -1
            Me.mSo_tiet = 0
            Me.mLoai_tiet = eLOAI_TIET.KHONG_XAC_DINH
            Me.mDa_xep_lich = False
            Me.mThieu_dulieu = False
            Me.Update = False
        End Sub

        Public Sub New(ByVal ID As Long, ByVal ID_phong As Integer, _
            ByVal ID_mon As Integer, ByVal ID_cb As Integer, _
            ByVal ID_lop As Integer, ByVal Ten_phong As String, _
            ByVal Ten_mon As String, ByVal Ten As String, ByVal HoTen As String, _
            ByVal Ten_lop As String, ByVal Ca_hoc As eCA_HOC, _
            ByVal Thu As eTHU, ByVal Tiet As Integer, _
            ByVal So_tiet As Integer, ByVal Loai_tiet As eLOAI_TIET, ByVal Ky_hieu As String, _
            ByVal Da_xep_lich As Boolean)

            Me.mID = ID
            Me.mID_phong = ID_phong
            Me.mID_mon = ID_mon
            Me.mID_cb = ID_cb
            Me.mID_lop_tc = ID_lop
            Me.mTen_phong = Ten_phong
            Me.mKy_hieu = Ky_hieu
            Me.mTen_mon = Ten_mon
            Me.mTen = Ten
            Me.mHoten = Hoten
            Me.mTen_lop = Ten_lop
            Me.mCa_hoc = Ca_hoc
            Me.mThu = Thu
            Me.mTiet = Tiet
            Me.mSo_tiet = So_tiet
            Me.mLoai_tiet = Loai_tiet
            Me.mDa_xep_lich = Da_xep_lich
            Me.mThieu_dulieu = False
        End Sub
        Public Property ID() As Long
            Get
                Return Me.mID
            End Get
            Set(ByVal Value As Long)
                Me.mID = Value
            End Set
        End Property
        Public Property ID_lop_tc() As Integer
            Get
                Return Me.mID_lop_tc
            End Get
            Set(ByVal Value As Integer)
                Me.mID_lop_tc = Value
            End Set
        End Property
        Public Property ID_phong() As Integer
            Get
                Return Me.mID_phong
            End Get
            Set(ByVal Value As Integer)
                Me.mID_phong = Value
            End Set
        End Property
        Public Property ID_cb() As Integer
            Get
                Return Me.mID_cb
            End Get
            Set(ByVal Value As Integer)
                Me.mID_cb = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return Me.mID_mon
            End Get
            Set(ByVal Value As Integer)
                Me.mID_mon = Value
            End Set
        End Property
        Public Property ID_bm() As Integer
            Get
                Return Me.mID_bm
            End Get
            Set(ByVal Value As Integer)
                Me.mID_bm = Value
            End Set
        End Property
        Public Property Ten_lop() As String
            Get
                Return Me.mTen_lop
            End Get
            Set(ByVal Value As String)
                Me.mTen_lop = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return Me.mTen_phong
            End Get
            Set(ByVal Value As String)
                Me.mTen_phong = Value
            End Set
        End Property

        Public Property Hoten() As String
            Get
                Return Me.mHoten
            End Get
            Set(ByVal Value As String)
                Me.mHoten = Value
            End Set
        End Property

        Public Property Ten() As String
            Get
                Return Me.mTen
            End Get
            Set(ByVal Value As String)
                Me.mTen = Value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return Me.mKy_hieu
            End Get
            Set(ByVal Value As String)
                Me.mKy_hieu = Value
            End Set
        End Property
        Public Property Ten_mon() As String
            Get
                Return Me.mTen_mon
            End Get
            Set(ByVal Value As String)
                Me.mTen_mon = Value
            End Set
        End Property
        Public Property Ca_hoc() As eCA_HOC
            Get
                Return Me.mCa_hoc
            End Get
            Set(ByVal Value As eCA_HOC)
                Me.mCa_hoc = Value
            End Set
        End Property
        Public Property Thu() As eTHU
            Get
                Return Me.mThu
            End Get
            Set(ByVal Value As eTHU)
                Me.mThu = Value
            End Set
        End Property
        Public Property Tiet() As Integer
            Get
                Return Me.mTiet
            End Get
            Set(ByVal Value As Integer)
                Me.mTiet = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return Me.mSo_tiet
            End Get
            Set(ByVal Value As Integer)
                Me.mSo_tiet = Value
            End Set
        End Property
        Public Property Loai_tiet() As eLOAI_TIET
            Get
                Return Me.mLoai_tiet
            End Get
            Set(ByVal Value As eLOAI_TIET)
                Me.mLoai_tiet = Value
            End Set
        End Property
        Public Property Da_xep_lich() As Boolean
            Get
                Return Me.mDa_xep_lich
            End Get
            Set(ByVal Value As Boolean)
                Me.mDa_xep_lich = Value
            End Set
        End Property
        Public Property Thieu_dulieu() As Boolean
            Get
                Return Me.mThieu_dulieu
            End Get
            Set(ByVal Value As Boolean)
                Me.mThieu_dulieu = Value
            End Set
        End Property
        Public Property Update() As Boolean
            Get
                Return Me.mUpdate
            End Get
            Set(ByVal Value As Boolean)
                Me.mUpdate = Value
            End Set
        End Property
        Public Function Clone() As ESSSu_kien
            Dim sk As New ESSSu_kien

            sk.ID = Me.ID
            sk.ID_phong = Me.ID_phong
            sk.ID_mon = Me.ID_mon
            sk.ID_bm = Me.ID_bm
            sk.ID_cb = Me.ID_cb
            sk.ID_lop_tc = Me.ID_lop_tc
            sk.Ten_phong = Me.Ten_phong
            sk.Ky_hieu = Me.Ky_hieu
            sk.Ten_mon = Me.Ten_mon
            sk.Ten = Me.Ten
            sk.Hoten = Me.Hoten
            sk.Ten_lop = Me.Ten_lop
            sk.Ca_hoc = Me.Ca_hoc
            sk.Thu = Me.Thu
            sk.Tiet = Me.Tiet
            sk.So_tiet = Me.So_tiet
            sk.Loai_tiet = Me.Loai_tiet
            sk.Da_xep_lich = Me.Da_xep_lich
            sk.Thieu_dulieu = Me.Thieu_dulieu

            Return sk
        End Function

        Public Property Tu_ngay() As Date
            Get
                Return Me.mTu_ngay
            End Get
            Set(ByVal Value As Date)
                Me.mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return Me.mDen_ngay
            End Get
            Set(ByVal Value As Date)
                Me.mDen_ngay = Value
            End Set
        End Property
    End Class
End Namespace