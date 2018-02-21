Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class Portal_Bussines
        Private objDAL As New Portal_DataAccess
#Region "Initialize"
        Sub New()
        End Sub
#End Region

#Region "Functions"
        Public Function LoadDiemRenLuyen(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As DataTable = objDAL.HienThi_ESSDiemRenLuyenSinhVien(ID_sv)
                Dim obj As New DiemRenLuyen_DataAccess
                Dim dtXepLoai As DataTable = obj.HienThi_ESSXLRenLuyen()
                Dim TongDiem As Integer = 0
                dt.Columns.Add("Xep_loai", GetType(String))
                For i As Integer = 0 To dt.Rows.Count - 1
                    TongDiem = dt.Rows(i)("Tong_diem")
                    For j As Integer = 0 To dtXepLoai.Rows.Count - 1
                        If TongDiem >= dtXepLoai.Rows(j).Item("Tu_diem") And TongDiem <= dtXepLoai.Rows(j).Item("Den_diem") Then
                            dt.Rows(i)("Xep_loai") = dtXepLoai.Rows(j).Item("Xep_loai")
                            Exit For
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function LoaLichThi(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As DataTable = objDAL.HienThi_ESSLichThiSinhVien(ID_sv)
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
#End Region
        Public Function LoaDiemThanhPhan(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As String
            Try
                Dim dt As DataTable = objDAL.HienThi_ESSDiemThanhPhan(ID_sv, ID_mon)
                Dim str As String = ""
                For i As Integer = 0 To dt.Rows.Count - 1
                    str &= dt.Rows(i)("Ky_hieu") & "(" & dt.Rows(i)("Ty_le") & "%):" & dt.Rows(i)("Diem") & "; "
                Next
                Return str.Substring(0, str.Length - 2)
            Catch ex As Exception
                Return ""
            End Try
        End Function

        Public Function LoaDiemThi(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As String
            Try
                Dim dt As DataTable = objDAL.HienThi_ESSDiemThi(ID_sv, ID_mon)
                Dim str As String = ""
                For i As Integer = 0 To dt.Rows.Count - 1
                    str &= dt.Rows(i)("Diem_thi") & "; "
                Next
                Return str.Substring(0, str.Length - 2)
            Catch ex As Exception
                Return ""
            End Try
        End Function
    End Class
End Namespace
