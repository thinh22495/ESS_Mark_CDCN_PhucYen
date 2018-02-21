'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, August 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class LoaiThuChi_Bussines
        Private arrLoaiThuChi As New ArrayList
#Region "Initialize"
        Public Sub New()
            Try
                Dim obj As LoaiThuChi_DataAccess = New LoaiThuChi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSLoaiThuChi_DanhSach()
                Dim objLoaiThuChi As ESSLoaiThuChi = Nothing
                If dt.Rows.Count > 0 Then objLoaiThuChi = New ESSLoaiThuChi
                For Each r As DataRow In dt.Rows
                    objLoaiThuChi = Mapping(r)
                    arrLoaiThuChi.Add(objLoaiThuChi)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSLoaiThuChi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_thu_chi")
                dt.Columns.Add("Ten_thu_chi")
                dt.Columns.Add("Thu_chi")
                dt.Columns.Add("So_tien", GetType(Integer))
                dt.Columns.Add("Thu_bat_buoc")
                dt.Columns.Add("Theo_nien_khoa")
                dt.Columns.Add("Hoc_phi")
                Dim dr As DataRow
                Dim obj As New ESSLoaiThuChi
                For i As Integer = 0 To arrLoaiThuChi.Count - 1
                    obj = CType(arrLoaiThuChi(i), ESSLoaiThuChi)
                    dr = dt.NewRow
                    dr("ID_thu_chi") = obj.ID_thu_chi
                    dr("Ten_thu_chi") = obj.Ten_thu_chi
                    dr("Thu_chi") = obj.Thu_chi
                    dr("So_tien") = obj.So_tien
                    dr("Thu_bat_buoc") = obj.Thu_bat_buoc
                    dr("Theo_nien_khoa") = obj.Theo_nien_khoa
                    dr("Hoc_phi") = obj.Hoc_phi
                    dt.Rows.Add(dr)
                Next
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub ThemMoi_ESSObject(ByVal objLoaiThuChi As ESSLoaiThuChi)
            Try
                arrLoaiThuChi.Add(objLoaiThuChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function ThemMoi_ESSLoaiThuChi(ByVal objLoaiThuChi As ESSLoaiThuChi) As Integer
            Try
                Dim obj As LoaiThuChi_DataAccess = New LoaiThuChi_DataAccess
                Return obj.ThemMoi_ESSLoaiThuChi(objLoaiThuChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub CapNhat_ESSObject(ByVal objLoaiThuChi As ESSLoaiThuChi, ByVal idx As Integer)
            Try
                arrLoaiThuChi(idx) = objLoaiThuChi
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function CapNhat_ESSLoaiThuChi(ByVal objLoaiThuChi As ESSLoaiThuChi) As Integer
            Try
                Dim obj As LoaiThuChi_DataAccess = New LoaiThuChi_DataAccess
                Return obj.CapNhat_ESSLoaiThuChi(objLoaiThuChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiThuChi(ByVal ID_thu_chi As Integer) As Integer
            Try
                Dim obj As LoaiThuChi_DataAccess = New LoaiThuChi_DataAccess
                Return obj.Xoa_ESSLoaiThuChi(ID_thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSObject(ByVal Idx As Integer) As Integer
            Try
                arrLoaiThuChi.RemoveAt(Idx)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiThuChi(ByVal Ten_thu_chi As String) As Boolean
            Try
                Dim obj As LoaiThuChi_DataAccess = New LoaiThuChi_DataAccess
                Return obj.CheckExist_LoaiThuChi(Ten_thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drLoaiThuChi As DataRow) As ESSLoaiThuChi
            Dim result As ESSLoaiThuChi
            Try
                result = New ESSLoaiThuChi
                If drLoaiThuChi("ID_thu_chi").ToString() <> "" Then result.ID_thu_chi = CType(drLoaiThuChi("ID_thu_chi").ToString(), Integer)
                result.Ten_thu_chi = drLoaiThuChi("Ten_thu_chi").ToString()
                result.Thu_chi = drLoaiThuChi("Thu_chi").ToString()
                result.So_tien = drLoaiThuChi("So_tien").ToString()
                result.Thu_bat_buoc = drLoaiThuChi("Thu_bat_buoc").ToString()
                result.Theo_nien_khoa = drLoaiThuChi("Theo_nien_khoa").ToString()
                result.Hoc_phi = drLoaiThuChi("Hoc_phi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
