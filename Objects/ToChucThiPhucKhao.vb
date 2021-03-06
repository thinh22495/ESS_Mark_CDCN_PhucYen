'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, October 12, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSToChucThiPhucKhao
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_he As Integer = 0
        Private mTen_he As String = ""
        Private mID_khoa As Integer = 0
        Private mTen_khoa As String = ""
        Private mID_chuyen_nganh As Integer = 0
        Private mChuyen_nganh As String = ""
        Private mID_lop As Integer = 0
        Private mTen_lop As String = ""
        Private mID_sv As Integer = 0
        Private mSo_bao_danh As String = ""
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date

        Private mID_mon As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_mon As String = ""
        Private mNgay_thi As Date

        Private mID_phuc_khao As Integer = 0
        Private mID_thi As Integer = 0
        Private mID_ds_thi As Integer = 0
        Private mLan As Integer = 0
        Private mDiem1 As Double = 0
        Private mDiem2 As Double = 0
        Private mGhi_chu As String = ""
        Private mToChucThiPhucKhao As New ArrayList
#End Region

#Region "Sub"
        Public Sub Add(ByVal phuckhao As ESSToChucThiPhucKhao)
            mToChucThiPhucKhao.Add(phuckhao)
        End Sub

        Public Sub Remove(ByVal phuckhao As ESSToChucThiPhucKhao)
            mToChucThiPhucKhao.Remove(phuckhao)
        End Sub

        Public Function Tim_idx(ByVal ID_ds_thi As Integer) As Integer
            For i As Integer = 0 To mToChucThiPhucKhao.Count - 1
                If CType(mToChucThiPhucKhao(i), ESSToChucThiPhucKhao).ID_ds_thi = ID_ds_thi Then
                    Return i
                End If
            Next
            Return -1
        End Function


#End Region

#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mToChucThiPhucKhao.Count
            End Get
        End Property

        Public Property ESSToChucThiPhucKhao(ByVal idx As Integer) As ESSToChucThiPhucKhao
            Get
                Return CType(mToChucThiPhucKhao(idx), ESSToChucThiPhucKhao)
            End Get
            Set(ByVal value As ESSToChucThiPhucKhao)
                mToChucThiPhucKhao(idx) = value
            End Set
        End Property

        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal value As Integer)
                mHoc_ky = value
            End Set
        End Property

        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal value As String)
                mNam_hoc = value
            End Set
        End Property

        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal value As Integer)
                mID_he = value
            End Set
        End Property

        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal value As String)
                mTen_he = value
            End Set
        End Property


        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal value As Integer)
                mID_khoa = value
            End Set
        End Property

        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal value As String)
                mTen_khoa = value
            End Set
        End Property

        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal value As Integer)
                mID_chuyen_nganh = value
            End Set
        End Property

        Public Property Chuyen_nganh() As String
            Get
                Return mChuyen_nganh
            End Get
            Set(ByVal value As String)
                mChuyen_nganh = value
            End Set
        End Property


        Public Property ID_lop() As Integer
            Get
                Return mID_lop
            End Get
            Set(ByVal value As Integer)
                mID_lop = value
            End Set
        End Property

        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal value As String)
                mTen_lop = value
            End Set
        End Property


        Public Property Ngay_thi() As Date
            Get
                Return mNgay_thi
            End Get
            Set(ByVal value As DateTime)
                mNgay_thi = value
            End Set
        End Property

        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property

        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal value As String)
                mKy_hieu = value
            End Set
        End Property

        Public Property Ten_mon() As String
            Get
                Return mTen_mon
            End Get
            Set(ByVal value As String)
                mTen_mon = value
            End Set
        End Property

        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal value As Integer)
                mID_sv = value
            End Set
        End Property


        Public Property So_bao_danh() As String
            Get
                Return mSo_bao_danh
            End Get
            Set(ByVal value As String)
                mSo_bao_danh = value
            End Set
        End Property

        Public Property Ma_sv() As String
            Get
                Return mMa_sv
            End Get
            Set(ByVal value As String)
                mMa_sv = value
            End Set
        End Property

        Public Property Ho_ten() As String
            Get
                Return mHo_ten
            End Get
            Set(ByVal value As String)
                mHo_ten = value
            End Set
        End Property

        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal value As Date)
                mNgay_sinh = value
            End Set
        End Property

        Public Property ID_phuc_khao() As Integer
            Get
                Return mID_phuc_khao
            End Get
            Set(ByVal Value As Integer)
                mID_phuc_khao = Value
            End Set
        End Property

        Public Property ID_thi() As Integer
            Get
                Return mID_thi
            End Get
            Set(ByVal Value As Integer)
                mID_thi = Value
            End Set
        End Property

        Public Property ID_ds_thi() As Integer
            Get
                Return mID_ds_thi
            End Get
            Set(ByVal Value As Integer)
                mID_ds_thi = Value
            End Set
        End Property
        Public Property Lan() As Integer
            Get
                Return mLan
            End Get
            Set(ByVal Value As Integer)
                mLan = Value
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
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property


#End Region

    End Class
End Namespace
