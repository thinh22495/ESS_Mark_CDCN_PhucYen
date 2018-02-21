'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    <Microsoft.VisualBasic.ComClass()> Public Class DoiTuongChinhSach_Bussines
        Private arrDoiTuongChinhSach As New ArrayList
#Region "Initialize"
        Public Sub New(ByVal ID_lops As String)
            Dim obj As DoiTuongChinhSach_DataAccess = New DoiTuongChinhSach_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSDoiTuongChinhSach(ID_lops)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim objDTCS As New ESSDoiTuongChinhSach
                objDTCS.ID_sv = dt.Rows(i)("ID_sv")
                objDTCS.ID_dt = IIf(dt.Rows(i)("ID_dt").ToString = "", 0, dt.Rows(i)("ID_dt"))
                objDTCS.Ma_dt = IIf(dt.Rows(i)("Ma_dt").ToString = "", "", dt.Rows(i)("Ma_dt"))
                objDTCS.Ten_dt = IIf(dt.Rows(i)("Ten_dt").ToString = "", "", dt.Rows(i)("Ten_dt"))
                arrDoiTuongChinhSach.Add(objDTCS)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load danh sách sinh viên theo lớp (Đã xác định ĐT và chưa xác định ĐT)
        Public Function DanhSachDoiTuongChinhSach(ByVal dtSinhVien As DataTable) As DataView
            Try
                Dim dtDoiTuong As DataTable = dtSinhVien.Copy
                dtDoiTuong.Columns.Add("Ma_dt")
                dtDoiTuong.Columns.Add("Ten_dt")
                For i As Integer = 0 To arrDoiTuongChinhSach.Count - 1
                    For j As Integer = 0 To dtDoiTuong.Rows.Count - 1
                        If dtDoiTuong.Rows(j)("ID_sv") = CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).ID_sv Then
                            dtDoiTuong.Rows(j)("Ma_dt") = CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).Ma_dt
                            dtDoiTuong.Rows(j)("Ten_dt") = CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).Ten_dt
                        End If
                    Next
                Next
                Return dtDoiTuong.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách sinh viên theo lớp (Chưa xác định ĐT)
        Public Function DanhSachChuaCoDoiTuongChinhSach(ByVal dtSinhVien As DataTable) As DataView
            Try
                Dim dtDoiTuong As DataTable = dtSinhVien.Copy
                dtDoiTuong.Columns.Add("Ma_dt")
                dtDoiTuong.Columns.Add("Ten_dt")
                For i As Integer = 0 To arrDoiTuongChinhSach.Count - 1
                    For j As Integer = 0 To dtDoiTuong.Rows.Count - 1
                        If dtDoiTuong.Rows(j)("ID_sv") = CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).ID_sv Then
                            dtDoiTuong.Rows(j)("Ma_dt") = CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).Ma_dt
                            dtDoiTuong.Rows(j)("Ten_dt") = CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).Ten_dt
                        End If
                    Next
                Next
                dtDoiTuong.DefaultView.RowFilter = "Ma_dt=''"
                Return dtDoiTuong.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDoiTuong(ByVal ID_dt As Integer) As Boolean
            Try
                Dim obj As DoiTuongChinhSach_DataAccess = New DoiTuongChinhSach_DataAccess
                obj.CheckExist_DoiTuongChinhSach(ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function ThemMoi_ESSDoiTuongChinhSach(ByVal objDoiTuongChinhSach As ESSDoiTuongChinhSach) As Integer
        '    Try
        '        Dim obj As DoiTuongChinhSach_DataAccess = New DoiTuongChinhSach_DataAccess
        '        Return obj.ThemMoi_ESSDoiTuongChinhSach(objDoiTuongChinhSach)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        'Public Function CapNhat_ESSDoiTuongChinhSach(ByVal objDoiTuongChinhSach As ESSDoiTuongChinhSach, ByVal ID_dt As Integer) As Integer
        '    Try
        '        Dim obj As DoiTuongChinhSach_DataAccess = New DoiTuongChinhSach_DataAccess
        '        Return obj.CapNhat_ESSDoiTuongChinhSach(objDoiTuongChinhSach, ID_dt)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function Xoa_ESSDoiTuongChinhSach(ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As DoiTuongChinhSach_DataAccess = New DoiTuongChinhSach_DataAccess
                Return obj.Xoa_ESSDoiTuongChinhSach(ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDoiTuongChinhSach As DataRow) As ESSDoiTuongChinhSach
            Dim result As ESSDoiTuongChinhSach
            Try
                result = New ESSDoiTuongChinhSach
                If drDoiTuongChinhSach("ID_dt").ToString() <> "" Then result.ID_dt = CType(drDoiTuongChinhSach("ID_dt").ToString(), Integer)
                result.Ma_dt = drDoiTuongChinhSach("Ma_dt").ToString()
                result.Ten_dt = drDoiTuongChinhSach("Ten_dt").ToString()
                result.Mien_giam = drDoiTuongChinhSach("Mien_giam").ToString()
                If drDoiTuongChinhSach("Sotien_miengiam").ToString() <> "" Then result.Sotien_miengiam = CType(drDoiTuongChinhSach("Sotien_miengiam").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Sub AddDoiTuong(ByRef dtDSSV As DataTable)
            dtDSSV.Columns.Add("Ma_dt", GetType(String))
            Try
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("Ma_dt") = MaDoiTuong(dtDSSV.Rows(i)("ID_doi_tuong_ts"))
                Next
            Catch ex As Exception
            End Try
        End Sub

        Public Function MaDoiTuong(ByVal ID_dt As Integer) As String
            For i As Integer = 0 To arrDoiTuongChinhSach.Count - 1
                If CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).ID_dt = ID_dt Then
                    Return CType(arrDoiTuongChinhSach(i), ESSDoiTuongChinhSach).Ma_dt.ToString
                End If
            Next
            Return ""
        End Function
#End Region
    End Class
End Namespace
