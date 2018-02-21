'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSSukien_lop
        Private _ID As Long
        Private _ID_lop As Integer
        Private _Ten_lop As String
        Private _Thu As eTHU
        Private _Tiet As Integer
        Private _So_tiet As Integer
        Private _Mo_ta As String
        Public Sub New()
            Me._ID = -1
            Me._ID_lop = -1
            Me._Ten_lop = ""
            Me._Thu = eTHU.KHONG_XAC_DINH
            Me._Tiet = -1
            Me._So_tiet = 0
            Me._Mo_ta = ""
        End Sub
        Public Sub New(ByVal ID As Long, _
            ByVal ID_lop As Integer, _
            ByVal Ten_lop As String, _
            ByVal Thu As eTHU, _
            ByVal Tiet As Integer, _
            ByVal So_tiet As Integer, _
            ByVal Mo_ta As String)
            Me._ID = ID
            Me._ID_lop = ID_lop
            Me._Ten_lop = Ten_lop
            Me._Thu = Thu
            Me._Tiet = Tiet
            Me._So_tiet = So_tiet
            Me._Mo_ta = Mo_ta
        End Sub
        Public Property ID() As Long
            Get
                Return Me._ID
            End Get
            Set(ByVal Value As Long)
                Me._ID = Value
            End Set
        End Property
        Public Property ID_lop_tc() As Integer
            Get
                Return Me._ID_lop
            End Get
            Set(ByVal Value As Integer)
                Me._ID_lop = Value
            End Set
        End Property
        Public Property Ten_lop() As String
            Get
                Return Me._Ten_lop
            End Get
            Set(ByVal Value As String)
                Me._Ten_lop = Value
            End Set
        End Property
        Public Property Thu() As eTHU
            Get
                Return Me._Thu
            End Get
            Set(ByVal Value As eTHU)
                Me._Thu = Value
            End Set
        End Property
        Public Property Tiet() As Integer
            Get
                Return Me._Tiet
            End Get
            Set(ByVal Value As Integer)
                Me._Tiet = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return Me._So_tiet
            End Get
            Set(ByVal Value As Integer)
                Me._So_tiet = Value
            End Set
        End Property
        Public Property Mo_ta() As String
            Get
                Return Me._Mo_ta
            End Get
            Set(ByVal Value As String)
                Me._Mo_ta = Value
            End Set
        End Property
    End Class

    Public Class ESSSukien_phong
        Private _ID As Long
        Private _ID_phong As Integer
        Private _Ten_phong As String
        Private _Thu As eTHU
        Private _Tiet As Integer
        Private _So_tiet As Integer
        Private _Mo_ta As String
        Public Sub New()
            Me._ID = -1
            Me._ID_phong = -1
            Me._Ten_phong = ""
            Me._Thu = eTHU.KHONG_XAC_DINH
            Me._Tiet = -1
            Me._So_tiet = 0
            Me._Mo_ta = ""
        End Sub
        Public Sub New(ByVal ID As Long, _
            ByVal ID_phong As Integer, _
            ByVal Ten_phong As String, _
            ByVal Thu As eTHU, _
            ByVal Tiet As Integer, _
            ByVal So_tiet As Integer, _
            ByVal Mo_ta As String)
            Me._ID = ID
            Me._ID_phong = ID_phong
            Me._Ten_phong = Ten_phong
            Me._Thu = Thu
            Me._Tiet = Tiet
            Me._So_tiet = So_tiet
            Me._Mo_ta = Mo_ta
        End Sub
        Public Property ID() As Long
            Get
                Return Me._ID
            End Get
            Set(ByVal Value As Long)
                Me._ID = Value
            End Set
        End Property
        Public Property ID_phong() As Integer
            Get
                Return Me._ID_phong
            End Get
            Set(ByVal Value As Integer)
                Me._ID_phong = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return Me._Ten_phong
            End Get
            Set(ByVal Value As String)
                Me._Ten_phong = Value
            End Set
        End Property
        Public Property Thu() As eTHU
            Get
                Return Me._Thu
            End Get
            Set(ByVal Value As eTHU)
                Me._Thu = Value
            End Set
        End Property
        Public Property Tiet() As Integer
            Get
                Return Me._Tiet
            End Get
            Set(ByVal Value As Integer)
                Me._Tiet = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return Me._So_tiet
            End Get
            Set(ByVal Value As Integer)
                Me._So_tiet = Value
            End Set
        End Property
        Public Property Mo_ta() As String
            Get
                Return Me._Mo_ta
            End Get
            Set(ByVal Value As String)
                Me._Mo_ta = Value
            End Set
        End Property
    End Class

    Public Class ESSSukien_gv
        Private _ID As Long
        Private _ID_cb As Integer
        Private _Ten_gv As String
        Private _Thu As eTHU
        Private _Tiet As Integer
        Private _So_tiet As Integer
        Private _Mo_ta As String
        Public Sub New()
            Me._ID = -1
            Me._ID_cb = -1
            Me._Ten_gv = ""
            Me._Thu = eTHU.KHONG_XAC_DINH
            Me._Tiet = -1
            Me._So_tiet = 0
            Me._Mo_ta = ""
        End Sub
        Public Sub New(ByVal ID As Long, _
            ByVal ID_cb As Integer, _
            ByVal Ten_gv As String, _
            ByVal Thu As eTHU, _
            ByVal Tiet As Integer, _
            ByVal So_tiet As Integer, _
            ByVal Mo_ta As String)
            Me._ID = ID
            Me._ID_cb = ID_cb
            Me._Ten_gv = Ten_gv
            Me._Thu = Thu
            Me._Tiet = Tiet
            Me._So_tiet = So_tiet
            Me._Mo_ta = Mo_ta
        End Sub
        Public Property ID() As Long
            Get
                Return Me._ID
            End Get
            Set(ByVal Value As Long)
                Me._ID = Value
            End Set
        End Property
        Public Property ID_cb() As String
            Get
                Return Me._ID_cb
            End Get
            Set(ByVal Value As String)
                Me._ID_cb = Value
            End Set
        End Property
        Public Property Ten_gv() As String
            Get
                Return Me._Ten_gv
            End Get
            Set(ByVal Value As String)
                Me._Ten_gv = Value
            End Set
        End Property
        Public Property Thu() As eTHU
            Get
                Return Me._Thu
            End Get
            Set(ByVal Value As eTHU)
                Me._Thu = Value
            End Set
        End Property
        Public Property Tiet() As Integer
            Get
                Return Me._Tiet
            End Get
            Set(ByVal Value As Integer)
                Me._Tiet = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return Me._So_tiet
            End Get
            Set(ByVal Value As Integer)
                Me._So_tiet = Value
            End Set
        End Property
        Public Property Mo_ta() As String
            Get
                Return Me._Mo_ta
            End Get
            Set(ByVal Value As String)
                Me._Mo_ta = Value
            End Set
        End Property
    End Class
End Namespace