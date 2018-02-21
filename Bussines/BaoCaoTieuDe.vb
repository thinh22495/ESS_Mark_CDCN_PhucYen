'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, June 21, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class BaoCaoTieuDe_Bussines
        Private arrBaoCaoTieuDe As New ArrayList
#Region "Initialize"
        Public Sub New(ByVal ID_dv As String)
            Try
                Dim obj As BaoCaoTieuDe_DataAccess = New BaoCaoTieuDe_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSBaoCaoTieuDe(ID_dv)
                Dim objBaoCaoTieuDe As ESSBaoCaoTieuDe = Nothing
                If dt.Rows.Count > 0 Then
                    objBaoCaoTieuDe = Mapping(dt.Rows(0))
                    arrBaoCaoTieuDe.Add(objBaoCaoTieuDe)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal ID_dv As String, ByVal UserID As Integer)
            Try
                Dim obj As BaoCaoTieuDe_DataAccess = New BaoCaoTieuDe_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSBaoCaoTieuDe(ID_dv, UserID)
                Dim objBaoCaoTieuDe As ESSBaoCaoTieuDe = Nothing
                If dt.Rows.Count > 0 Then
                    objBaoCaoTieuDe = Mapping(dt.Rows(0))
                    arrBaoCaoTieuDe.Add(objBaoCaoTieuDe)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region "Functions And Subs"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrBaoCaoTieuDe.Count
            End Get
        End Property
        Public Property ESSBaoCaoTieuDe(ByVal idx As Integer) As ESSBaoCaoTieuDe
            Get
                Return CType(arrBaoCaoTieuDe(idx), ESSBaoCaoTieuDe)
            End Get
            Set(ByVal Value As ESSBaoCaoTieuDe)
                arrBaoCaoTieuDe(idx) = Value
            End Set
        End Property
        Public Function ThemMoi_ESSBaoCaoTieuDe(ByVal objBaoCaoTieuDe As ESSBaoCaoTieuDe) As Integer
            Try
                Dim obj As BaoCaoTieuDe_DataAccess = New BaoCaoTieuDe_DataAccess
                Return obj.ThemMoi_ESSBaoCaoTieuDe(objBaoCaoTieuDe)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBaoCaoTieuDe(ByVal objBaoCaoTieuDe As ESSBaoCaoTieuDe, ByVal ID_dv As String) As Integer
            Try
                Dim obj As BaoCaoTieuDe_DataAccess = New BaoCaoTieuDe_DataAccess
                Return obj.CapNhat_ESSBaoCaoTieuDe(objBaoCaoTieuDe, ID_dv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBaoCaoTieuDe(ByVal ID_dv As String) As Integer
            Try
                Dim obj As BaoCaoTieuDe_DataAccess = New BaoCaoTieuDe_DataAccess
                Return obj.Xoa_ESSBaoCaoTieuDe(ID_dv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_htBaoCaoTieuDe(ByVal ID_dv As String) As Boolean
            Try
                Dim obj As BaoCaoTieuDe_DataAccess = New BaoCaoTieuDe_DataAccess
                obj.CheckExist_BaoCaoTieuDe(ID_dv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drBaoCaoTieuDe As DataRow) As ESSBaoCaoTieuDe
            Dim result As ESSBaoCaoTieuDe
            Try
                result = New ESSBaoCaoTieuDe
                result.ID_dv = drBaoCaoTieuDe("ID_dv").ToString()
                If drBaoCaoTieuDe("UserID").ToString() <> "" Then result.UserID = CType(drBaoCaoTieuDe("UserID").ToString(), Integer)
                result.Tieu_de_ten_bo = drBaoCaoTieuDe("Tieu_de_ten_bo").ToString()
                result.Tieu_de_Ten_truong = drBaoCaoTieuDe("Tieu_de_Ten_truong").ToString()
                result.Tieu_de_chuc_danh1 = drBaoCaoTieuDe("Tieu_de_chuc_danh1").ToString()
                result.Tieu_de_chuc_danh2 = drBaoCaoTieuDe("Tieu_de_chuc_danh2").ToString()
                result.Tieu_de_chuc_danh3 = drBaoCaoTieuDe("Tieu_de_chuc_danh3").ToString()
                result.Tieu_de_chuc_danh4 = drBaoCaoTieuDe("Tieu_de_chuc_danh4").ToString()
                result.Tieu_de_nguoi_ky1 = drBaoCaoTieuDe("Tieu_de_nguoi_ky1").ToString()
                result.Tieu_de_nguoi_ky2 = drBaoCaoTieuDe("Tieu_de_nguoi_ky2").ToString()
                result.Tieu_de_nguoi_ky3 = drBaoCaoTieuDe("Tieu_de_nguoi_ky3").ToString()
                result.Tieu_de_nguoi_ky4 = drBaoCaoTieuDe("Tieu_de_nguoi_ky4").ToString()
                result.Tieu_de_noi_ky = drBaoCaoTieuDe("Tieu_de_noi_ky").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace

