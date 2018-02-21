'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, May 27, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class HoSoNop_Bussines
        Inherits ESSHoSoNop
        Dim arrHoSoNop As New ArrayList

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal dsID_lop As String)
            Try
                Dim obj As HoSoNop_DataAccess = New HoSoNop_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSHoSoNop_DanhSach(dsID_lop)
                Dim objsvHoSoNop As ESSHoSoNop = Nothing
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objsvHoSoNop = Mapping(dr)
                    arrHoSoNop.Add(objsvHoSoNop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load ho so nop
        Public Function HienThi_ESSTableHoSoNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As HoSoNop_DataAccess = New HoSoNop_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSTableHoSoNop(ID_sv)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load bang ho so nop 
        Public Function HienThi_ESSHoSoNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ngay_tra", GetType(Date))
                dt.Columns.Add("Da_tra", GetType(Boolean))
                dt.Columns.Add("Ghi_chu_tra", GetType(String))
                dt.Columns.Add("Ghi_chu_nop")
                Dim obj As New ESSHoSoNop
                For i As Integer = 0 To arrHoSoNop.Count - 1
                    obj = CType(arrHoSoNop(i), ESSHoSoNop)
                    If obj.ID_sv = ID_sv Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = obj.ID_sv
                        row("ID_giay_to") = obj.ID_giay_to
                        row("Ten_giay_to") = obj.Ten_giay_to
                        If obj.Ngay_tra <> Nothing Then row("Ngay_tra") = obj.Ngay_tra
                        row("Da_tra") = obj.Da_tra
                        row("Ghi_chu_tra") = obj.Ghi_chu_tra
                        row("Ghi_chu_nop") = obj.Ghi_chu_nop
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load  ho so nop theo danh sách sinh viên (Dung in bao cáo)
        Public Function HienThi_ESSDSSV_HoSoNop(ByVal dtSV As DataTable) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To dtSV.Rows.Count - 1
                    Dim obj As New ESSHoSoNop
                    For j As Integer = 0 To arrHoSoNop.Count - 1
                        obj = CType(arrHoSoNop(j), ESSHoSoNop)
                        If obj.ID_sv = dtSV.Rows(i)("ID_sv") Then
                            Dim row As DataRow = dt.NewRow()
                            row("ID_sv") = dtSV.Rows(i)("ID_sv")
                            row("Ma_sv") = dtSV.Rows(i)("Ma_sv")
                            row("Ho_ten") = dtSV.Rows(i)("Ho_ten")
                            If dtSV.Rows(i)("Ngay_sinh").ToString <> "" Then row("Ngay_sinh") = dtSV.Rows(i)("Ngay_sinh")
                            row("Ten_lop") = dtSV.Rows(i)("Ten_lop")
                            row("Ten_giay_to") = obj.Ten_giay_to
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load  ho so thieu theo danh sách sinh viên (Dung in bao cáo)
        Public Function HienThi_ESSDSSV_HoSoThieu(ByVal dtSV As DataTable, ByVal dtGT As DataTable) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To dtSV.Rows.Count - 1
                    Dim obj As New ESSHoSoNop
                    ' Hồ sơ nộp của sinh viên
                    Dim dtNop As New DataTable
                    dtNop.Columns.Add("ID_giay_to")
                    For j As Integer = 0 To arrHoSoNop.Count - 1
                        obj = CType(arrHoSoNop(j), ESSHoSoNop)
                        If obj.ID_sv = dtSV.Rows(i)("ID_sv") Then
                            Dim row As DataRow = dtNop.NewRow()
                            row("ID_giay_to") = obj.ID_giay_to
                            dtNop.Rows.Add(row)
                        End If
                    Next
                    Dim dtThieu As DataTable
                    dtThieu = dtGT.Copy
                    ' Xóa những giấy tờ đã nộp
                    For j As Integer = dtThieu.Rows.Count - 1 To 0 Step -1
                        For k As Integer = dtNop.Rows.Count - 1 To 0 Step -1
                            If dtThieu.Rows(j)("ID_giay_to") = dtNop.Rows(k)("ID_giay_to") Then
                                dtThieu.Rows(j).Delete()
                                Exit For
                            End If
                        Next
                    Next
                    dtThieu.AcceptChanges()
                    ' Fill vào Table mới
                    For j As Integer = 0 To dtThieu.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = dtSV.Rows(i)("ID_sv")
                        row("Ma_sv") = dtSV.Rows(i)("Ma_sv")
                        row("Ho_ten") = dtSV.Rows(i)("Ho_ten")
                        If dtSV.Rows(i)("Ngay_sinh").ToString <> "" Then row("Ngay_sinh") = dtSV.Rows(i)("Ngay_sinh")
                        row("Ten_giay_to") = dtThieu.Rows(j)("Ten_giay_to").ToString
                        row("Ten_lop") = dtSV.Rows(i)("Ten_lop")
                        dt.Rows.Add(row)
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoNop(ByVal objHoSoNop As ESSHoSoNop) As Integer
            Try
                Dim obj As HoSoNop_DataAccess = New HoSoNop_DataAccess
                Return obj.ThemMoi_ESSHoSoNop(objHoSoNop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoNop(ByVal objHoSoNop As ESSHoSoNop) As Integer
            Try
                Dim obj As HoSoNop_DataAccess = New HoSoNop_DataAccess
                Return obj.CapNhat_ESSHoSoNop(objHoSoNop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As New HoSoNop_DataAccess
                Return obj.Xoa_ESSHoSoNop(ID_sv, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Xóa tất cả hồ sơ nộp của sinh viên
        Public Function Xoa_ESSHoSoNop(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As New HoSoNop_DataAccess
                Return obj.Xoa_ESSHoSoNop(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svHoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Boolean
            Try
                Dim obj As HoSoNop_DataAccess = New HoSoNop_DataAccess
                Return obj.CheckExist_HoSoNop(ID_sv, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svHoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As HoSoNop_DataAccess = New HoSoNop_DataAccess
                obj.GetMaxID_HoSoNop(ID_sv, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drHoSoNop As DataRow) As ESSHoSoNop
            Dim result As ESSHoSoNop
            Try
                result = New ESSHoSoNop
                If drHoSoNop("ID_sv").ToString() <> "" Then result.ID_sv = CType(drHoSoNop("ID_sv").ToString(), Integer)
                If drHoSoNop("ID_giay_to").ToString() <> "" Then result.ID_giay_to = CType(drHoSoNop("ID_giay_to").ToString(), Integer)
                result.Ghi_chu_nop = drHoSoNop("Ghi_chu_nop").ToString()
                result.Ghi_chu_tra = drHoSoNop("Ghi_chu_tra").ToString()
                result.Da_tra = drHoSoNop("Da_tra").ToString()
                result.Ten_giay_to = drHoSoNop("Ten_giay_to").ToString()
                If drHoSoNop("Ngay_tra").ToString() <> "" Then result.Ngay_tra = CType(drHoSoNop("Ngay_tra").ToString(), Date)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
