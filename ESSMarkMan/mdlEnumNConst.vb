Module mdlEnumNConst
    Public Enum CtrlType
        None = 0
        TextBox = 1
        ComboBox = 2
        ListBox = 3
        CheckBox = 4
        RadioButton = 5
        DateTimePicker = 6
        LinkLabel = 7
    End Enum
    Public Enum DatabaseType As Integer
        SQLServer = 0
        Oralce9i = 1
    End Enum
    Public Enum LoaiSuKien As Integer
        Them = 0
        Sua = 1
        Xoa = 2
    End Enum
    Public Class my_Cell
        Private _row As Integer
        Private _col As Integer
        Public Sub New()
            _row = -1
            _col = -1
        End Sub
        Public Sub New(ByVal row As Integer, ByVal col As Integer, ByVal copy As Boolean)
            _row = row
            _col = col
        End Sub
        Public Property Row() As Integer
            Get
                Return _row
            End Get
            Set(ByVal Value As Integer)
                _row = Value
            End Set
        End Property
        Public Property Col() As Integer
            Get
                Return _col
            End Get
            Set(ByVal Value As Integer)
                _col = Value
            End Set
        End Property
    End Class
End Module
