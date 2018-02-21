'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, May 08, 2010
'---------------------------------------------------------------------------
Namespace Bussines
    Public Class ESSBaoCaoChiTietTruong
#Region "Var"
        Private mSTT As Integer = 0
        Private mFieldID As String = 0
        Private mFieldName As String = ""
        Private mFieldSize As Double = 0
        Private mFieldObject As Integer = 0
        Private mFieldAlign As Integer = 0
        Private mFieldType As Integer = 0
        Private mSo_hoc_trinh As Integer = 0
        Private mColFix As Boolean = True
        Private mField As New ArrayList
#End Region
        Public Sub Add(ByVal Field As ESSBaoCaoChiTietTruong)
            mField.Add(Field)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mField.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mField.Count
            End Get
        End Property
        Public Property ESSBaoCaoChiTietTruong(ByVal idx As Integer) As ESSBaoCaoChiTietTruong
            Get
                Return CType(mField(idx), ESSBaoCaoChiTietTruong)
            End Get
            Set(ByVal Value As ESSBaoCaoChiTietTruong)
                mField(idx) = Value
            End Set
        End Property
        Public Property STT() As Integer
            Get
                Return mSTT
            End Get
            Set(ByVal Value As Integer)
                mSTT = Value
            End Set
        End Property
        Public Property FieldID() As String
            Get
                Return mFieldID
            End Get
            Set(ByVal Value As String)
                mFieldID = Value
            End Set
        End Property
        Public Property FieldName() As String
            Get
                Return mFieldName
            End Get
            Set(ByVal Value As String)
                mFieldName = Value
            End Set
        End Property
        Public Property FieldSize() As Double
            Get
                Return mFieldSize
            End Get
            Set(ByVal Value As Double)
                mFieldSize = Value
            End Set
        End Property
        Public Property FieldObject() As Integer
            Get
                Return mFieldObject
            End Get
            Set(ByVal Value As Integer)
                mFieldObject = Value
            End Set
        End Property
        Public Property FieldAlign() As Integer
            Get
                Return mFieldAlign
            End Get
            Set(ByVal Value As Integer)
                mFieldAlign = Value
            End Set
        End Property
        Public Property FieldType() As Integer
            Get
                Return mFieldType
            End Get
            Set(ByVal Value As Integer)
                mFieldType = Value
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
        Public Property ColFix() As Boolean
            Get
                Return mColFix
            End Get
            Set(ByVal Value As Boolean)
                mColFix = Value
            End Set
        End Property
    End Class
End Namespace