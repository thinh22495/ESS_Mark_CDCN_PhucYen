'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ThamSoHeThong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function Doc_tham_so(ByVal key As String) As String
            Try
                Dim strSQL As String = "SELECT Gia_tri FROM SYS_ThamSoHeThong WHERE ID_tham_so ='" + key + "'"
                Dim dt As DataTable = Connect.SelectTable(strSQL)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0).Item(0).ToString
                End If
                Return ""
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Doc_tham_so_Active(ByVal key As String) As Boolean
            Try
                Dim strSQL As String = "SELECT Active FROM SYS_ThamSoHeThong WHERE ID_tham_so ='" + key + "'"
                Dim dt As DataTable = Connect.SelectTable(strSQL)
                If dt.Rows.Count > 0 Then
                    Return CType(dt.Rows(0).Item(0), Boolean)
                End If
                Return True
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSThamSoHeThong() As DataTable
            Try
                Return Connect.SelectTableSP("SYS_ThamSoHeThong_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSThamSoHeThong_DanhSach(ByVal ID_ph As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_ph", ID_ph)
                Return Connect.SelectTableSP("SYS_ThamSoHeThong_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSThamSoHeThong(ByVal obj As ESSThamSoHeThong, ByVal ID_tham_so As String) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_tham_so", ID_tham_so)
                para(1) = New SqlParameter("@Ten_tham_so", obj.Ten_tham_so)
                para(2) = New SqlParameter("@ID_ph", obj.ID_ph)
                para(3) = New SqlParameter("@Gia_tri", obj.Gia_tri)
                para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(5) = New SqlParameter("@Active", obj.Active)
                Return Connect.ExecuteSP("SYS_ThamSoHeThong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSThamSoHeThong(ByVal obj As ESSThamSoHeThong) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_tham_so", obj.ID_tham_so)
                para(1) = New SqlParameter("@Gia_tri", obj.Gia_tri)
                para(2) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(3) = New SqlParameter("@Active", obj.Active)
                Return Connect.ExecuteSP("SYS_ThamSoHeThong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace
