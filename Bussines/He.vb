'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 08, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class He_Bussines
        Private arrHe As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca He
            Try
                arrHe = New ArrayList
                Dim objHe_dal As New He_DataAccess
                Dim dt As DataTable = objHe_dal.HienThi_ESSHe_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objHe As New ESSHe
                        objHe = Mapping(dt.Rows(i))
                        arrHe.Add(objHe)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucHe() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_He", GetType(Integer))
            dt.Columns.Add("Ten_He", GetType(String))
            For i As Integer = 0 To arrHe.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objHe As ESSHe = CType(arrHe(i), ESSHe)
                row("ID_He") = objHe.ID_he
                row("Ten_He") = objHe.Ten_he
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function ThemMoi_ESSHe(ByVal objHe As ESSHe) As Integer
            Try
                Dim obj As He_DataAccess = New He_DataAccess
                Return obj.ThemMoi_ESSHe(objHe)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHe(ByVal objHe As ESSHe, ByVal ID_he As Integer) As Integer
            Try
                Dim obj As He_DataAccess = New He_DataAccess
                Return obj.CapNhat_ESSHe(objHe, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHe(ByVal ID_he As Integer) As Integer
            Try
                Dim obj As He_DataAccess = New He_DataAccess
                Return obj.Xoa_ESSHe(ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_He(ByVal ID_he As Integer) As Boolean
            Try
                Dim obj As He_DataAccess = New He_DataAccess
                obj.CheckExist_He(ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drHe As DataRow) As ESSHe
            Dim result As ESSHe
            Try
                result = New ESSHe
                If drHe("ID_he").ToString() <> "" Then result.ID_he = CType(drHe("ID_he").ToString(), Integer)
                result.Ma_he = drHe("Ma_he").ToString()
                result.Ten_he = drHe("Ten_he").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
