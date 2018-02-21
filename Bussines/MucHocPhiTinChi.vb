'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class MucHocPhiTinChi_Bussines
        Private arrMucHocPhiTinChi As New ArrayList
#Region "Initialize"
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer)
            Try
                Dim obj As MucHocPhiTinChi_DataAccess = New MucHocPhiTinChi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSMucHocPhiTinChi(Hoc_ky, Nam_hoc, ID_he)
                Dim objMucHocPhiTinChi As ESSMucHocPhiTinChi = Nothing
                If dt.Rows.Count > 0 Then
                    objMucHocPhiTinChi = Mapping(dt.Rows(0))
                    arrMucHocPhiTinChi.Add(objMucHocPhiTinChi)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrMucHocPhiTinChi.Count
            End Get
        End Property
        Public Property ESSMucHocPhiTinChi(ByVal idx As Integer) As ESSMucHocPhiTinChi
            Get
                Return CType(Me.arrMucHocPhiTinChi(idx), ESSMucHocPhiTinChi)
            End Get
            Set(ByVal Value As ESSMucHocPhiTinChi)
                Me.arrMucHocPhiTinChi(idx) = Value
            End Set
        End Property
        Public Function ThemMoi_ESSMucHocPhiTinChi(ByVal objMucHocPhiTinChi As ESSMucHocPhiTinChi) As Integer
            Try
                Dim obj As MucHocPhiTinChi_DataAccess = New MucHocPhiTinChi_DataAccess
                Return obj.ThemMoi_ESSMucHocPhiTinChi(objMucHocPhiTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSMucHocPhiTinChi(ByVal objMucHocPhiTinChi As ESSMucHocPhiTinChi, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As Integer
            Try
                Dim obj As MucHocPhiTinChi_DataAccess = New MucHocPhiTinChi_DataAccess
                Return obj.CapNhat_ESSMucHocPhiTinChi(objMucHocPhiTinChi, Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSMucHocPhiTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As Integer
            Try
                Dim obj As MucHocPhiTinChi_DataAccess = New MucHocPhiTinChi_DataAccess
                Return obj.Xoa_ESSMucHocPhiTinChi(Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drMucHocPhiTinChi As DataRow) As ESSMucHocPhiTinChi
            Dim result As ESSMucHocPhiTinChi
            Try
                result = New ESSMucHocPhiTinChi
                If drMucHocPhiTinChi("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drMucHocPhiTinChi("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drMucHocPhiTinChi("Nam_hoc").ToString()
                If drMucHocPhiTinChi("ID_he").ToString() <> "" Then result.ID_he = CType(drMucHocPhiTinChi("ID_he").ToString(), Integer)
                If drMucHocPhiTinChi("So_tien").ToString() <> "" Then result.So_tien = CType(drMucHocPhiTinChi("So_tien").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
