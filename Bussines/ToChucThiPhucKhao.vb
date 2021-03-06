'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, October 12, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ToChucThiPhucKhao_Bussines
        Private arrToChucThiPhucKhao As ArrayList
#Region "Initialize"
        Public Sub New(ByVal ID_phuc_khao As Integer)
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSToChucThiPhucKhao(ID_phuc_khao)
                Dim objToChucThiPhucKhao As ESSToChucThiPhucKhao = Nothing
                If dt.Rows.Count > 0 Then
                    objToChucThiPhucKhao = Mapping(dt.Rows(0))
                    arrToChucThiPhucKhao.Add(objToChucThiPhucKhao)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New()
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSToChucThiPhucKhao_DanhSach()
                Dim objsvToChucThiPhucKhao As ESSToChucThiPhucKhao = Nothing
                Dim dr As DataRow = Nothing
                arrToChucThiPhucKhao = New ArrayList
                For Each dr In dt.Rows
                    objsvToChucThiPhucKhao = Mapping(dr)
                    arrToChucThiPhucKhao.Add(objsvToChucThiPhucKhao)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ThemMoi_ESSToChucThiPhucKhao(ByVal objToChucThiPhucKhao As ESSToChucThiPhucKhao) As Integer
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                Return obj.ThemMoi_ESSToChucThiPhucKhao(objToChucThiPhucKhao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSToChucThiPhucKhao(ByVal objToChucThiPhucKhao As ESSToChucThiPhucKhao, ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                Return obj.CapNhat_ESSToChucThiPhucKhao(objToChucThiPhucKhao, ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                Return obj.Xoa_ESSToChucThiPhucKhao(ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Boolean
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                obj.CheckExist_ToChucThiPhucKhao(ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim obj As ToChucThiPhucKhao_DataAccess = New ToChucThiPhucKhao_DataAccess
                obj.GetMaxID_ToChucThiPhucKhao(ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drToChucThiPhucKhao As DataRow) As ESSToChucThiPhucKhao
            Dim result As ESSToChucThiPhucKhao
            Try
                result = New ESSToChucThiPhucKhao
                If drToChucThiPhucKhao("ID_phuc_khao").ToString() <> "" Then result.ID_phuc_khao = CType(drToChucThiPhucKhao("ID_phuc_khao").ToString(), Integer)
                If drToChucThiPhucKhao("ID_ds_thi").ToString() <> "" Then result.ID_ds_thi = CType(drToChucThiPhucKhao("ID_ds_thi").ToString(), Integer)
                If drToChucThiPhucKhao("Lan").ToString() <> "" Then result.Lan = CType(drToChucThiPhucKhao("Lan").ToString(), Integer)
                If drToChucThiPhucKhao("Diem1").ToString() <> "" Then result.Diem1 = CType(drToChucThiPhucKhao("Diem1").ToString(), Double)
                If drToChucThiPhucKhao("Diem2").ToString() <> "" Then result.Diem2 = CType(drToChucThiPhucKhao("Diem2").ToString(), Double)
                result.Ghi_chu = drToChucThiPhucKhao("Ghi_chu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
