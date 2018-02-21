'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 17, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class HocHam_Bussines
        Private arrHocHam As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Hoc ham
            Try
                arrHocHam = New ArrayList
                Dim objHocHam_dal As New HocHam_DataAccess
                Dim dt As DataTable = objHocHam_dal.HienThi_ESSHocHam_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objHocHam As New ESSHocHam
                        objHocHam = Mapping(dt.Rows(i))
                        arrHocHam.Add(objHocHam)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucHocHam() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_hoc_ham", GetType(Integer))
            dt.Columns.Add("Hoc_ham", GetType(String))
            For i As Integer = 0 To arrHocHam.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objHocHam As ESSHocHam = CType(arrHocHam(i), ESSHocHam)
                row("ID_hoc_ham") = objHocHam.ID_hoc_ham
                row("Hoc_ham") = objHocHam.Hoc_ham
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function ThemMoi_ESSHocHam(ByVal objHocHam As ESSHocHam) As Integer
            Try
                Dim obj As HocHam_DataAccess = New HocHam_DataAccess
                Return obj.ThemMoi_ESSHocHam(objHocHam)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHocHam(ByVal objHocHam As ESSHocHam, ByVal ID_hoc_ham As Integer) As Integer
            Try
                Dim obj As HocHam_DataAccess = New HocHam_DataAccess
                Return obj.CapNhat_ESSHocHam(objHocHam, ID_hoc_ham)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocHam(ByVal ID_hoc_ham As Integer) As Integer
            Try
                Dim obj As HocHam_DataAccess = New HocHam_DataAccess
                Return obj.Xoa_ESSHocHam(ID_hoc_ham)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drHocHam As DataRow) As ESSHocHam
            Dim result As ESSHocHam
            Try
                result = New ESSHocHam
                If drHocHam("ID_hoc_ham").ToString() <> "" Then result.ID_hoc_ham = CType(drHocHam("ID_hoc_ham").ToString(), Integer)
                result.Ma_hoc_ham = drHocHam("Ma_hoc_ham").ToString()
                result.Hoc_ham = drHocHam("Hoc_ham").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
