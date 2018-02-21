'Coded By: AnhNT
'Created date: 22/3/2012
'Company: Thien An ESS Co.,Ltd
Public Class CellReport
    Private mText As String = ""
    Private mWidth As Single = 0
    Private mDataBinding As String = ""
    Private mFormat As String = ""
    Private mTextAlignment As DevExpress.XtraPrinting.TextAlignment
    Private mBoders As DevExpress.XtraPrinting.BorderSide = DevExpress.XtraPrinting.BorderSide.None
    Public Sub New(Optional ByVal text As String = "", Optional ByVal width As Single = 0, Optional ByVal dataBinding As String = "", Optional ByVal format As String = "", Optional ByVal textAlignment As DevExpress.XtraPrinting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter, Optional ByVal tag As String = "", Optional ByVal Boders As DevExpress.XtraPrinting.BorderSide = DevExpress.XtraPrinting.BorderSide.All)
        Me.mText = text
        Me.mWidth = width
        Me.mDataBinding = dataBinding
        Me.mFormat = format
        Me.TextAlignment = textAlignment
        Me.mTag = tag
        Me.mBoders = Boders
    End Sub
    Private mTag As String = ""
    Public Property Tag() As String
        Get
            Return mTag
        End Get
        Set(ByVal value As String)
            mTag = value
        End Set
    End Property

    Private mPadding As DevExpress.XtraPrinting.PaddingInfo = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
    Public Property TextPadding() As DevExpress.XtraPrinting.PaddingInfo
        Get
            Return mPadding
        End Get
        Set(ByVal value As DevExpress.XtraPrinting.PaddingInfo)
            mPadding = value
        End Set
    End Property

    Public Property TextAlignment() As DevExpress.XtraPrinting.TextAlignment
        Get
            Return mTextAlignment
        End Get
        Set(ByVal value As DevExpress.XtraPrinting.TextAlignment)
            mTextAlignment = value
        End Set
    End Property

    Public Property Borders() As DevExpress.XtraPrinting.BorderSide
        Get
            Return mBoders
        End Get
        Set(ByVal value As DevExpress.XtraPrinting.BorderSide)
            mBoders = value
        End Set
    End Property

    Public Property Text() As String
        Get
            Return mText
        End Get
        Set(ByVal value As String)
            mText = value
        End Set
    End Property
    Public Property Width() As Single
        Get
            Return mWidth
        End Get
        Set(ByVal value As Single)
            mWidth = value
        End Set
    End Property
    Public Property DataBinding() As String
        Get
            Return mDataBinding
        End Get
        Set(ByVal value As String)
            mDataBinding = value
        End Set
    End Property
    Public Property Format() As String
        Get
            Return mFormat
        End Get
        Set(ByVal value As String)
            mFormat = value
        End Set
    End Property

End Class
