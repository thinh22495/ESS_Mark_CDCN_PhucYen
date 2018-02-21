'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, May 27, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSTimKiemNangCaoTruongTimKiem
#Region "Initialize"

#End Region

#Region "Var"
        Private mID As Integer = 0
        Private mFieldGroup As Integer = 0
        Private mSTT As Integer = 0
        Private mFieldName As String = ""
        Private mFieldStatistic As Boolean = 0
        Private mFieldID As String = ""
        Private mFieldType As Integer = 0
        Private mDTable As String = ""
        Private mDFieldID As String = ""
        Private mDFieldName As String = ""
        Private mWTable As String = ""
        Private mLTable As String = ""
        Private mMTable As String = ""
        Private mRTable As String = ""
        Private mLField As String = ""
        Private mMField As String = ""
        Private mM1Field As String = ""
        Private mRField As String = ""
        Private mFieldSelect As Integer = 0
        Private mFieldOperator As String = ""
        Private mFieldOperatorB As String = ""
        Private mValue1 As Object
        Private mValue2 As Object
        Private mFieldSearch As New ArrayList
#End Region
        Public Sub New()

        End Sub
        Public Sub Add(ByVal Field As ESSTimKiemNangCaoTruongTimKiem)
            mFieldSearch.Add(Field)
        End Sub
        Public Sub Remove(ByVal idx_sk As Integer)
            mFieldSearch.RemoveAt(idx_sk)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mFieldSearch.Count
            End Get
        End Property
        Public Property FieldSearch(ByVal idx As Integer) As ESSTimKiemNangCaoTruongTimKiem
            Get
                Return CType(mFieldSearch(idx), ESSTimKiemNangCaoTruongTimKiem)
            End Get
            Set(ByVal Value As ESSTimKiemNangCaoTruongTimKiem)
                mFieldSearch(idx) = Value
            End Set
        End Property
#Region "Property"
        Public Property ID() As Integer
            Get
                Return mID
            End Get
            Set(ByVal Value As Integer)
                mID = Value
            End Set
        End Property
        Public Property FieldGroup() As Integer
            Get
                Return mFieldGroup
            End Get
            Set(ByVal Value As Integer)
                mFieldGroup = Value
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
        Public Property FieldName() As String
            Get
                Return mFieldName
            End Get
            Set(ByVal Value As String)
                mFieldName = Value
            End Set
        End Property
        Public Property FieldStatistic() As Boolean
            Get
                Return mFieldStatistic
            End Get
            Set(ByVal Value As Boolean)
                mFieldStatistic = Value
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
        Public Property FieldType() As Integer
            Get
                Return mFieldType
            End Get
            Set(ByVal Value As Integer)
                mFieldType = Value
            End Set
        End Property
        Public Property DTable() As String
            Get
                Return mDTable
            End Get
            Set(ByVal Value As String)
                mDTable = Value
            End Set
        End Property
        Public Property DFieldID() As String
            Get
                Return mDFieldID
            End Get
            Set(ByVal Value As String)
                mDFieldID = Value
            End Set
        End Property
        Public Property DFieldName() As String
            Get
                Return mDFieldName
            End Get
            Set(ByVal Value As String)
                mDFieldName = Value
            End Set
        End Property
        Public Property WTable() As String
            Get
                Return mWTable
            End Get
            Set(ByVal Value As String)
                mWTable = Value
            End Set
        End Property
        Public Property LTable() As String
            Get
                Return mLTable
            End Get
            Set(ByVal Value As String)
                mLTable = Value
            End Set
        End Property
        Public Property MTable() As String
            Get
                Return mMTable
            End Get
            Set(ByVal Value As String)
                mMTable = Value
            End Set
        End Property
        Public Property RTable() As String
            Get
                Return mRTable
            End Get
            Set(ByVal Value As String)
                mRTable = Value
            End Set
        End Property
        Public Property LField() As String
            Get
                Return mLField
            End Get
            Set(ByVal Value As String)
                mLField = Value
            End Set
        End Property
        Public Property MField() As String
            Get
                Return mMField
            End Get
            Set(ByVal Value As String)
                mMField = Value
            End Set
        End Property
        Public Property M1Field() As String
            Get
                Return mM1Field
            End Get
            Set(ByVal Value As String)
                mM1Field = Value
            End Set
        End Property
        Public Property RField() As String
            Get
                Return mRField
            End Get
            Set(ByVal Value As String)
                mRField = Value
            End Set
        End Property
        Public Property FieldSelect() As Integer
            Get
                Return mFieldSelect
            End Get
            Set(ByVal Value As Integer)
                mFieldSelect = Value
            End Set
        End Property
        Public Property FieldOperator() As String
            Get
                Return mFieldOperator
            End Get
            Set(ByVal Value As String)
                mFieldOperator = Value
            End Set
        End Property
        Public Property FieldOperatorB() As String
            Get
                Return mFieldOperatorB
            End Get
            Set(ByVal Value As String)
                mFieldOperatorB = Value
            End Set
        End Property
        Public Property Value1() As Object
            Get
                Return mValue1
            End Get
            Set(ByVal Value As Object)
                mValue1 = Value
            End Set
        End Property
        Public Property Value2() As Object
            Get
                Return mValue2
            End Get
            Set(ByVal Value As Object)
                mValue2 = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
