Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LapMa_DataAccess

#Region "Initialize"
        Public Sub New()

        End Sub
#End Region

#Region "Functions And Subs"
        Public Function KiemTra_Ma_sv(ByVal Ma_sv As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                If Connect.SelectTableSP("STU_HoSoSinhVien_KiemTraTonTai_MaSV", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub UpdateMa_sv(ByVal ID_sv As Integer, ByVal Ma_sv As String)
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ma_sv", Ma_sv)
                Connect.ExecuteSP("STU_CapNhatMa_sv", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

    End Class
End Namespace

