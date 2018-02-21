'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports ESSConnect
Namespace DataAccess
    Public Class Connect_data_DataAccess
        Function ConnectDatabase(ByVal sConnString As String, ByVal DBType As Integer) As Boolean
            Try
                gDBType = DBType
                Connect.SetConnectionString(sConnString)
                Connect.SetDBType(DBType)
                If Connect.Connected Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

