Public Class XlsCommon
    Private _first As String
    Private _last As String
    Private _value As Object
    Private _font As Font
    Private _color As System.Drawing.Color
    Public Sub New()
        _first = "A1"
        _last = "A1"
        _value = Nothing
        _font = New Font("Arial", 10, FontStyle.Regular)
    End Sub
    Public Sub New(ByVal First As String, ByVal Last As String, ByVal value As Object, ByVal your_font As System.Drawing.Font, ByVal color As Color)
        _first = First
        _last = Last
        _value = value
        _font = your_font
        _color = color
    End Sub
    Public Property First() As String
        Get
            Return _first
        End Get
        Set(ByVal Value As String)
            _first = Value
        End Set
    End Property
    Public Property Last() As String
        Get
            Return _last
        End Get
        Set(ByVal Value As String)
            _last = Value
        End Set
    End Property
    Public Property Value() As Object
        Get
            Return _value
        End Get
        Set(ByVal Value As Object)
            _value = Value
        End Set
    End Property
    Public Property font() As System.Drawing.Font
        Get
            Return _font
        End Get
        Set(ByVal Value As System.Drawing.Font)
            _font = Value
        End Set
    End Property
    Public Property color() As System.Drawing.Color
        Get
            Return _color
        End Get
        Set(ByVal Value As System.Drawing.Color)
            _color = Value
        End Set
    End Property
End Class
