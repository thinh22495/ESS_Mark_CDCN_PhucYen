'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Public Class Connect
#Region "Var"
    Public Enum DatabaseType As Byte
        SQLServer = 0
        Oracle9i = 1
    End Enum
    Private Shared DBType As DatabaseType
    Private Shared strConn As String
    Private Shared connSql As SqlConnection
    Private Shared transSql As SqlTransaction
    Private Shared cmdSql As SqlCommand
    Private Shared connOra As OracleConnection
    Private Shared transOra As OracleTransaction
    Private Shared cmdOra As OracleCommand
    Private Shared bTransaction As Boolean = False
#End Region

#Region "Thiết lập kết nối CSDL"
    Public Sub New()
    End Sub
    Public Shared Sub SetConnectionString(ByVal HostName As String, ByVal DataBaseName As String, ByVal UserName As String, ByVal Password As String)
        strConn = "Data Source=" + HostName + "; initial catalog=" + DataBaseName + "; User ID=" + UserName + ";PWD=" + Password
    End Sub
    Public Shared Sub SetConnectionString(ByVal ConnectString As String)
        strConn = ConnectString
    End Sub
    Public Shared Sub SetDBType(ByVal Type As Integer)
        DBType = Type
    End Sub
    Public Shared Function Connected() As Boolean
        Try
            If DBType = DatabaseType.SQLServer Then
                connSql = New SqlConnection(strConn)
                ' Mở kết nối
                connSql.Open()
                connSql.Close()
                connSql.Dispose()
            Else
                connOra = New OracleConnection(strConn)
                ' Mở kết nối
                connOra.Open()
                connOra.Close()
                connOra.Dispose()
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
#End Region

#Region "Thực thi câu lệnh SQL"
    Public Shared Function Execute(ByVal strSQL As String) As Integer
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)
                    ' Mở kết nối
                    connSql.Open()
                    ' Tạo câu lệnh SQL
                    cmdSql = New SqlCommand(strSQL, connSql)
                    Dim result As Integer = cmdSql.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL

                    Dim result As Integer = cmdSql.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                End If
            Catch se As SqlException
                Call RollBack()
                Throw se

            Catch ex As Exception
                Call RollBack()
                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)
                    ' Mở kết nối
                    connOra.Open()
                    ' Tạo câu lệnh SQL
                    cmdOra = New OracleCommand(strSQL, connOra)
                    Dim result As Integer = cmdOra.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL

                    Dim result As Integer = cmdOra.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                End If
            Catch se As OracleException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
    End Function
    Public Shared Function Execute(ByVal strSQL As String, ByVal param As Object) As Integer
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)
                    ' Mở kết nối
                    connSql.Open()
                    ' Tạo câu lệnh SQL
                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim result As Integer = cmdSql.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL
                    cmdSql.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim result As Integer = cmdSql.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                End If
            Catch se As SqlException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)
                    ' Mở kết nối
                    connOra.Open()
                    ' Tạo câu lệnh SQL
                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)

                    Dim result As Integer = cmdOra.ExecuteNonQuery()
                    connOra.Close()
                    ' Trả về giá trị
                    Return result
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL
                    cmdOra.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)

                    Dim result As Integer = cmdOra.ExecuteNonQuery()
                    ' Trả về giá trị
                    Return result
                End If
                Call Commit()
            Catch se As OracleException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If

    End Function
    Public Shared Function Execute(ByVal strSQL As String, ByVal param() As Object) As Integer
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)
                    ' Mở kết nối
                    connSql.Open()
                    ' Tạo câu lệnh SQL
                    cmdSql = New SqlCommand(strSQL, connSql)

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    Dim result As Integer = cmdSql.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL
                    cmdSql.Parameters.Clear()

                    ' Các tham số
                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    Dim result As Integer = cmdSql.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                End If
            Catch se As SqlException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)
                    ' Mở kết nối
                    connOra.Open()
                    ' Tạo câu lệnh SQL
                    cmdOra = New OracleCommand(strSQL, connOra)

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    Dim result As Integer = cmdOra.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL
                    cmdOra.Parameters.Clear()

                    ' Các tham số
                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next

                    Dim result As Integer = cmdOra.ExecuteNonQuery()
                    Call Commit()
                    ' Trả về giá trị
                    Return result
                End If
            Catch se As OracleException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
    End Function
#End Region

#Region "Load dữ liệu"
    Public Shared Function SelectTable(ByVal strSQL As String) As DataTable
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand(strSQL, connSql)

                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As SqlException
                Call RollBack()
                Throw se
            Catch ex As Exception

            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)
                    ' Mở kết nối
                    connOra.Open()
                    ' Tạo câu lệnh truy vấn
                    cmdOra = New OracleCommand(strSQL, connOra)

                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As OracleException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function SelectTable(ByVal strSQL As String, ByVal param As Object) As DataTable
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)
                    connSql.Open()

                    cmdSql = New SqlCommand(strSQL, connSql)

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim da As New SqlDataAdapter(cmdSql)
                    Dim dt As New DataTable

                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL
                    cmdSql.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As SqlException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand(strSQL, connOra)

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL
                    cmdOra.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As OracleException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function SelectTable(ByVal strSQL As String, ByVal param() As Object) As DataTable
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand(strSQL, connSql)

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL
                    cmdSql.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As SqlException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand(strSQL, connOra)

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL
                    cmdOra.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As OracleException
                Call RollBack()

                Throw se
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If

        Return Nothing
    End Function
#End Region

#Region "Thực thi câu lệnh trả về giá trị"
    Public Shared Function ExecuteScalar(ByVal strSQL As String) As Object
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand(strSQL, connSql)
                    Dim result As Object = cmdSql.ExecuteScalar()
                    Call Commit()

                    Return result
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL

                    Dim result As Object = cmdSql.ExecuteScalar()
                    Call Commit()

                    Return result
                End If
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand(strSQL, connOra)
                    Dim result As Object = cmdOra.ExecuteScalar()
                    Call Commit()

                    Return result
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL

                    Dim result As Object = cmdOra.ExecuteScalar()
                    Call Commit()

                    Return result
                End If
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function ExecuteScalar(ByVal strSQL As String, ByVal param As Object) As Object
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand(strSQL, connSql)

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim result As Object = cmdSql.ExecuteScalar()
                    Call Commit()

                    Return result
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL
                    cmdSql.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim result As Object = cmdSql.ExecuteScalar()
                    Call Commit()

                    Return result
                End If
                Call Commit()
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand(strSQL, connOra)

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    Dim result As Object = cmdOra.ExecuteScalar()
                    Call Commit()

                    Return result
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL
                    cmdOra.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)

                    Dim result As Object = cmdOra.ExecuteScalar()
                    Call Commit()

                    Return result
                End If
                Call Commit()
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function ExecuteScalar(ByVal strSQL As String, ByVal param() As Object) As Object
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand(strSQL, connSql)

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    Dim result As Object = cmdSql.ExecuteScalar()
                    Call Commit()

                    Return result
                Else
                    cmdSql.CommandType = CommandType.Text
                    cmdSql.CommandText = strSQL
                    cmdSql.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    Dim result As Object = cmdSql.ExecuteScalar()
                    Call Commit()

                    Return result
                End If
                Call Commit()
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand(strSQL, connOra)

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next

                    Dim result As Object = cmdOra.ExecuteScalar()
                    Call Commit()

                    Return result
                Else
                    cmdOra.CommandType = CommandType.Text
                    cmdOra.CommandText = strSQL
                    cmdOra.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next

                    Dim result As Object = cmdOra.ExecuteScalar()
                    Call Commit()

                    Return result
                End If
                Call Commit()
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
#End Region

#Region "Thực hiện các Stored Procedure"
    Public Shared Function ExecuteSP(ByVal storedProcedure As String) As Integer
        Dim result As Integer
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure

                    result = cmdSql.ExecuteNonQuery()
                    Call Commit()
                Else

                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure

                    result = cmdSql.ExecuteNonQuery()
                    Call Commit()
                End If
                Call Commit()
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure

                    result = cmdOra.ExecuteNonQuery()
                    Call Commit()
                Else

                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure

                    result = cmdOra.ExecuteNonQuery()
                    Call Commit()
                End If
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return result
    End Function
    Public Shared Function ExecuteSP(ByVal storedProcedure As String, ByVal param As Object) As Integer
        Dim result As Integer
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then

                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    result = cmdSql.ExecuteNonQuery()
                    Call Commit()
                Else
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure
                    cmdSql.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)

                    result = cmdSql.ExecuteNonQuery()
                    Call Commit()
                End If
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then

                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)

                    result = cmdOra.ExecuteNonQuery()
                    Call Commit()
                Else
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure
                    cmdOra.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)

                    result = cmdOra.ExecuteNonQuery()
                    Call Commit()
                End If
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return result
    End Function
    Public Shared Function ExecuteSP(ByVal storedProcedure As String, ByVal param() As Object) As Integer
        Dim result As Integer
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.Connection = connSql
                    cmdSql.CommandText = storedProcedure

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    result = cmdSql.ExecuteScalar
                    Call Commit()

                Else
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure
                    cmdSql.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next

                    result = cmdSql.ExecuteScalar()
                    Call Commit()
                End If
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.Connection = connOra
                    cmdOra.CommandText = storedProcedure

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next

                    result = cmdOra.ExecuteNonQuery()
                    Call Commit()

                Else
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure
                    cmdOra.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next

                    result = cmdOra.ExecuteNonQuery()
                    Call Commit()
                End If
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return result
    End Function
    Public Shared Function SelectTableSP(ByVal storedProcedure As String) As DataTable
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.Connection = connSql
                    cmdSql.CommandText = storedProcedure


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else

                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.Connection = connOra
                    cmdOra.CommandText = storedProcedure


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else

                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
                Call Commit()
            Catch se As OracleException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function SelectTableSP(ByVal storedProcedure As String, ByVal param As Object) As DataTable
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else

                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure
                    cmdSql.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdSql.Parameters.Add(param)


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
                Call Commit()
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else

                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure
                    cmdOra.Parameters.Clear()

                    If param.Value Is Nothing Then
                        param.Value = DBNull.Value
                    End If
                    cmdOra.Parameters.Add(param)


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function SelectTableSP(ByVal storedProcedure As String, ByVal param() As Object) As DataTable
        If DBType = DatabaseType.SQLServer Then
            Try
                Call BeginTransaction()
                If Not bTransaction Then
                    connSql = New SqlConnection(strConn)

                    connSql.Open()

                    cmdSql = New SqlCommand
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.Connection = connSql
                    cmdSql.CommandText = storedProcedure

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdSql.CommandType = CommandType.StoredProcedure
                    cmdSql.CommandText = storedProcedure
                    cmdSql.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdSql.Parameters.Add(param(i))
                    Next


                    Dim da As New SqlDataAdapter(cmdSql)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If

            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        Else
            Try
                BeginTransaction()
                If Not bTransaction Then
                    connOra = New OracleConnection(strConn)

                    connOra.Open()

                    cmdOra = New OracleCommand
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.Connection = connOra
                    cmdOra.CommandText = storedProcedure

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                Else
                    cmdOra.CommandType = CommandType.StoredProcedure
                    cmdOra.CommandText = storedProcedure
                    cmdOra.Parameters.Clear()

                    Dim i As Integer
                    For i = 0 To param.Length - 1
                        If param(i).Value Is Nothing Then
                            param(i).Value = DBNull.Value
                        End If
                        cmdOra.Parameters.Add(param(i))
                    Next


                    Dim da As New OracleDataAdapter(cmdOra)

                    Dim dt As New DataTable
                    da.Fill(dt)
                    Call Commit()

                    Return dt
                End If
                Call Commit()
            Catch se As SqlException
                Call RollBack()

                MsgBox(se.Message)
            Catch ex As Exception
                Call RollBack()

                Throw ex
            End Try
        End If
        Return Nothing
    End Function
#End Region

#Region "Quản lý các Transaction"
    Public Shared Sub BeginTransaction()
        If DBType = DatabaseType.SQLServer Then
            Try

                bTransaction = True

                connSql = New SqlConnection(strConn)
                connSql.Open()

                cmdSql = New SqlCommand
                cmdSql.Connection = connSql

                transSql = connSql.BeginTransaction()
                cmdSql.Transaction = transSql
            Catch se As SqlException
                Throw se
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Try

                bTransaction = True

                connOra = New OracleConnection(strConn)
                connOra.Open()

                cmdOra = New OracleCommand
                cmdOra.Connection = connOra

                transOra = connOra.BeginTransaction()
                cmdOra.Transaction = transOra
            Catch se As OracleException
                Throw se
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Public Shared Sub Commit()
        If DBType = DatabaseType.SQLServer Then
            Try

                transSql.Commit()
                bTransaction = False
                connSql.Close()

                cmdSql.Dispose()
                transSql.Dispose()
                connSql.Dispose()
            Catch se As SqlException
                Throw se
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Try

                transOra.Commit()
                bTransaction = False
                connOra.Close()

                cmdOra.Dispose()
                transOra.Dispose()
                connOra.Dispose()
            Catch se As OracleException
                MsgBox(se.Message)
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Public Shared Sub RollBack()
        If DBType = DatabaseType.SQLServer Then
            Try

                transSql.Rollback()
                bTransaction = False
                connSql.Close()

                cmdSql.Dispose()
                transSql.Dispose()
                connSql.Dispose()
            Catch se As SqlException
                MsgBox(se.Message)
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Try

                transOra.Rollback()
                bTransaction = False
                connOra.Close()

                cmdOra.Dispose()
                transOra.Dispose()
                connOra.Dispose()
            Catch se As OracleException
                MsgBox(se.Message)
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Public Shared ReadOnly Property InTransaction() As Boolean
        Get
            Return bTransaction
        End Get
    End Property
#End Region
End Class

