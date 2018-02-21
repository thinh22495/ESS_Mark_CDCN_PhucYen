Public Class ColumnFormatRecord
    Private fPayment As Double
    Private fLenght As Long
    Private fPurchaseDate As DateTime
    Private fNumber As Integer

    Public Sub New(ByVal fPayment As Double, ByVal fLenght As Long, ByVal fPurchaseDate As DateTime, ByVal fNumber As Integer)
        Me.fPayment = fPayment
        Me.fLenght = fLenght
        Me.fPurchaseDate = fPurchaseDate
        Me.fNumber = fNumber
    End Sub

    Public Property Payment() As Double
        Get
            Return fPayment
        End Get
        Set(ByVal value As Double)
            fPayment = Value
        End Set
    End Property

    Public Property Lenght() As Long
        Get
            Return fLenght
        End Get
        Set(ByVal value As Long)
            fLenght = Value
        End Set
    End Property

    Public Property PurchaseDate() As DateTime
        Get
            Return fPurchaseDate
        End Get
        Set(ByVal value As DateTime)
            fPurchaseDate = Value
        End Set
    End Property

    Public Property Number() As Integer
        Get
            Return fNumber
        End Get
        Set(ByVal value As Integer)
            fNumber = Value
        End Set
    End Property
End Class
Public Class BaseFormatter
    Implements IFormatProvider, ICustomFormatter

    Public Function GetFormat(ByVal fFormat As Type) As Object Implements IFormatProvider.GetFormat
        If fFormat Is GetType(ICustomFormatter) Then
            Return Me
        Else
            Return Nothing
        End If
    End Function

    Public Function Format(ByVal fFormat As String, ByVal arg As Object, ByVal provider As IFormatProvider) As String Implements ICustomFormatter.Format
        If fFormat Is Nothing Then
            If TypeOf arg Is IFormattable Then
                Return (CType(arg, IFormattable)).ToString(fFormat, provider)
            Else
                Return arg.ToString()
            End If
        End If


        If (Not fFormat.StartsWith("B")) Then
            If TypeOf arg Is IFormattable Then
                Return (CType(arg, IFormattable)).ToString(fFormat, provider)
            Else
                Return arg.ToString()
            End If
        End If

        fFormat = fFormat.Trim(New Char() {"B"c})
        Dim b As Integer = Convert.ToInt32(fFormat)
        Return Convert.ToString(CInt(Fix(arg)), b)
    End Function
End Class
