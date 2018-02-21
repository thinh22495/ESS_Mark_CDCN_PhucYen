Imports System
Namespace Objects
    Public Class ESSChuongTrinhDaoTaoNhomTuChon
        Inherits ESSChuongTrinhDaoTaoChiTiet
#Region "Var"
        Private mID_dt As Integer = 0
        Private mNhom_tu_chon As Integer = 0
        Private mSo_mon_dang_ky As Integer = 0
        Private mSo_mon_tu_chon As Integer = 0
        Private mChuongTrinhDaoTaoNhomTuChon As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Overloads Sub Add(ByVal ctdtNhomTuChon As ESSChuongTrinhDaoTaoNhomTuChon)
            mChuongTrinhDaoTaoNhomTuChon.Add(ctdtNhomTuChon)
        End Sub
        Public Overloads Sub Remove(ByVal idx As Integer)
            mChuongTrinhDaoTaoNhomTuChon.RemoveAt(idx)
        End Sub
#End Region
#Region "Property"
        Public Overloads ReadOnly Property Count() As Integer
            Get
                Return mChuongTrinhDaoTaoNhomTuChon.Count
            End Get
        End Property
        Public Property ESSChuongTrinhDaoTaoNhomTuChon(ByVal idx As Integer) As ESSChuongTrinhDaoTaoNhomTuChon
            Get
                Return CType(mChuongTrinhDaoTaoNhomTuChon(idx), ESSChuongTrinhDaoTaoNhomTuChon)
            End Get
            Set(ByVal Value As ESSChuongTrinhDaoTaoNhomTuChon)
                mChuongTrinhDaoTaoNhomTuChon(idx) = Value
            End Set
        End Property

        Public Property So_mon_dang_ky() As Integer
            Get
                Return mSo_mon_dang_ky
            End Get
            Set(ByVal Value As Integer)
                mSo_mon_dang_ky = Value
            End Set
        End Property
        Public Property So_mon_tu_chon() As Integer
            Get
                Return mSo_mon_tu_chon
            End Get
            Set(ByVal Value As Integer)
                mSo_mon_tu_chon = Value
            End Set
        End Property
#End Region
    End Class
End Namespace