'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports ESS.DataAccess
Namespace Bussines
    Public Class Connect_data_Bussines
        Function ConnectDatabase(ByVal sConnString As String, ByVal DBType As Integer) As Boolean
            Try
                Dim obj As New Connect_data_DataAccess()
                Return obj.ConnectDatabase(sConnString, DBType)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
