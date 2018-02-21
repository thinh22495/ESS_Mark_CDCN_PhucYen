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
    Public Class HocVi_Bussines
        Private arrHocVi As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Hoc vi
            Try
                arrHocVi = New ArrayList
                Dim objHocVi_dal As New HocVi_DataAccess
                Dim dt As DataTable = objHocVi_dal.HienThi_ESSHocVi_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objHocVi As New ESSHocVi
                        objHocVi = Mapping(dt.Rows(i))
                        arrHocVi.Add(objHocVi)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucHocVi() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_hoc_vi", GetType(Integer))
            dt.Columns.Add("Hoc_vi", GetType(String))
            For i As Integer = 0 To arrHocVi.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objHocVi As ESSHocVi = CType(arrHocVi(i), ESSHocVi)
                row("ID_hoc_vi") = objHocVi.ID_hoc_vi
                row("Hoc_vi") = objHocVi.Hoc_vi
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function ThemMoi_ESSHocVi(ByVal objHocVi As ESSHocVi) As Integer
            Try
                Dim obj As HocVi_DataAccess = New HocVi_DataAccess
                Return obj.ThemMoi_ESSHocVi(objHocVi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHocVi(ByVal objHocVi As ESSHocVi, ByVal ID_hoc_vi As Integer) As Integer
            Try
                Dim obj As HocVi_DataAccess = New HocVi_DataAccess
                Return obj.CapNhat_ESSHocVi(objHocVi, ID_hoc_vi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocVi(ByVal ID_hoc_vi As Integer) As Integer
            Try
                Dim obj As HocVi_DataAccess = New HocVi_DataAccess
                Return obj.Xoa_ESSHocVi(ID_hoc_vi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drHocVi As DataRow) As ESSHocVi
            Dim result As ESSHocVi
            Try
                result = New ESSHocVi
                If drHocVi("ID_hoc_vi").ToString() <> "" Then result.ID_hoc_vi = CType(drHocVi("ID_hoc_vi").ToString(), Integer)
                result.Ma_hoc_vi = drHocVi("Ma_hoc_vi").ToString()
                result.Hoc_vi = drHocVi("Hoc_vi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
