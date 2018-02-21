Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class PhanLoaiKetQuaHocTap_Bussines
        Sub New()
        End Sub

        Public Function HienThi_ESSXepLoaiHocTap() As DataTable
            Dim clsDAL As New Diem_DataAccess
            Return clsDAL.HienThi_ESSXepLoaiHocTap()
        End Function

        Public Function HienThi_ESSQuyDoiDiem() As DataTable
            Dim clsDAL As New Diem_DataAccess
            Return clsDAL.HienThi_ESSDiemQuyDoi
        End Function
    End Class
End Namespace