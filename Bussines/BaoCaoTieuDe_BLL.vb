Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESSConnect
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class BaoCaoTieuDe_BLL
        Private arrBaoCaoTieuDe As New ArrayList
#Region "Constructor"
        Public Sub New(ByVal ID_dv As String)
            Try
                Dim obj As BaoCaoTieuDe_DAL = New BaoCaoTieuDe_DAL
                Dim dt As DataTable = obj.Load_BaoCaoTieuDe(ID_dv)
                Dim objBaoCaoTieuDe As BaoCaoTieuDe_En = Nothing
                If dt.Rows.Count > 0 Then
                    objBaoCaoTieuDe = Converting(dt.Rows(0))
                    arrBaoCaoTieuDe.Add(objBaoCaoTieuDe)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal ID_dv As String, ByVal UserID As Integer)
            Try
                Dim obj As BaoCaoTieuDe_DAL = New BaoCaoTieuDe_DAL
                Dim dt As DataTable = obj.Load_BaoCaoTieuDe(ID_dv, UserID)
                Dim objBaoCaoTieuDe As BaoCaoTieuDe_En = Nothing
                If dt.Rows.Count > 0 Then
                    objBaoCaoTieuDe = Converting(dt.Rows(0))
                    arrBaoCaoTieuDe.Add(objBaoCaoTieuDe)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region "Function"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrBaoCaoTieuDe.Count
            End Get
        End Property
        Public Property BaoCaoTieuDe(ByVal idx As Integer) As BaoCaoTieuDe_En
            Get
                Return CType(arrBaoCaoTieuDe(idx), BaoCaoTieuDe_En)
            End Get
            Set(ByVal Value As BaoCaoTieuDe_En)
                arrBaoCaoTieuDe(idx) = Value
            End Set
        End Property
        Public Function Insert_BaoCaoTieuDe(ByVal objBaoCaoTieuDe As BaoCaoTieuDe_En) As Integer
            Try
                Dim obj As BaoCaoTieuDe_DAL = New BaoCaoTieuDe_DAL
                Return obj.Insert_BaoCaoTieuDe(objBaoCaoTieuDe)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_BaoCaoTieuDe(ByVal objBaoCaoTieuDe As BaoCaoTieuDe_En, ByVal ID_dv As String) As Integer
            Try
                Dim obj As BaoCaoTieuDe_DAL = New BaoCaoTieuDe_DAL
                Return obj.Update_BaoCaoTieuDe(objBaoCaoTieuDe, ID_dv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Delete_BaoCaoTieuDe(ByVal ID_dv As String) As Integer
            Try
                Dim obj As BaoCaoTieuDe_DAL = New BaoCaoTieuDe_DAL
                Return obj.Delete_BaoCaoTieuDe(ID_dv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_htBaoCaoTieuDe(ByVal ID_dv As String) As Boolean
            Try
                Dim obj As BaoCaoTieuDe_DAL = New BaoCaoTieuDe_DAL
                obj.CheckExist_BaoCaoTieuDe(ID_dv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Converting(ByVal drBaoCaoTieuDe As DataRow) As BaoCaoTieuDe_En
            Dim result As BaoCaoTieuDe_En
            Try
                result = New BaoCaoTieuDe_En
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

