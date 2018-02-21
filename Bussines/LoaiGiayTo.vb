'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, May 04, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class LoaiGiayTo_Bussines
        Inherits ESSLoaiGiayTo
        Private arrLoaiGiayTo As ArrayList
        Private dtDoiTuongGT As DataTable  ' Danh sách các giấy tờ cần nộp theo đối tượng học bổng
#Region "Initialize"
        Public Sub New()
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSLoaiGiayTo_DanhSach()
                Dim objLoaiGiayTo As New ESSLoaiGiayTo
                Dim dr As DataRow = Nothing
                arrLoaiGiayTo = New ArrayList
                For Each dr In dt.Rows
                    objLoaiGiayTo = Mapping(dr)
                    arrLoaiGiayTo.Add(objLoaiGiayTo)
                Next
                ' Khởi tạo đối tượng giấy tờ cần nộp
                dtDoiTuongGT = obj.HienThi_ESSDoiTuongGiayTo_DanhSach()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer)
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSLoaiGiayTo_DanhSach(ID_he, Khoa_hoc)
                Dim objLoaiGiayTo As New ESSLoaiGiayTo
                Dim dr As DataRow = Nothing
                arrLoaiGiayTo = New ArrayList
                For Each dr In dt.Rows
                    objLoaiGiayTo = Mapping(dr)
                    arrLoaiGiayTo.Add(objLoaiGiayTo)
                Next
                'Khởi tạo đối tượng giấy tờ cần nộp
                dtDoiTuongGT = obj.HienThi_ESSDoiTuongGiayTo_DanhSach()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region "Functions And Subs"
        Public Function DanhSach_GiayTo() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ma_giay_to", GetType(String))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ban_chinh", GetType(Boolean))
                dt.Columns.Add("Ban_sao", GetType(Boolean))
                dt.Columns.Add("Ghi_chu_nop", GetType(String))
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    Dim gt As ESSLoaiGiayTo = CType(arrLoaiGiayTo(i), ESSLoaiGiayTo)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_giay_to") = gt.ID_giay_to
                    row("Ma_giay_to") = gt.Ma_giay_to
                    row("Ten_giay_to") = gt.Ten_giay_to
                    row("Ban_chinh") = False
                    row("Ban_sao") = False
                    row("Ghi_chu_nop") = ""
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Loai_GiayTo() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    Dim gt As ESSLoaiGiayTo = CType(arrLoaiGiayTo(i), ESSLoaiGiayTo)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_giay_to") = gt.ID_giay_to
                    row("Ten_giay_to") = gt.Ten_giay_to
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSLoaiGiayTo(ByVal ID_giay_to As Integer) As ESSLoaiGiayTo
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSLoaiGiayTo(ID_giay_to)
                Dim objLoaiGiayTo As ESSLoaiGiayTo = Nothing
                If dt.Rows.Count > 0 Then
                    objLoaiGiayTo = Mapping(dt.Rows(0))
                End If
                Return objLoaiGiayTo
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Cac loai giay to da nop
        Public Function HienThi_ESSLoaiGiayTo_DaNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.HienThi_ESSLoaiGiayTo_DaNop(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac Loai Giay to con thieu
        Public Function HienThi_ESSLoaiGiayTo_ConThieu(ByVal ID_sv As Integer) As DataTable
            Try
                ' Ho so đã nop
                Dim obj As New HoSoNop_Bussines
                Dim dtNop As DataTable = obj.HienThi_ESSTableHoSoNop(ID_sv)
                ' Ho so nộp
                Dim dtGiayTo As DataTable = DanhSach_GiayTo()
                For i As Integer = 0 To dtNop.Rows.Count - 1
                    Dim idx As Integer = dtGiayTo.Rows.Count - 1
                    For j As Integer = 0 To idx
                        If j > idx Then Exit For
                        If dtNop.Rows(i).Item("ID_giay_to") = dtGiayTo.Rows(j).Item("ID_giay_to") Then
                            dtGiayTo.Rows(j).Delete()
                            dtGiayTo.AcceptChanges()
                            idx -= 1
                        End If
                    Next
                Next
                Return dtGiayTo
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac Loai Giay đã nộp và chưa nộp của sinh viên
        Public Function LoadGiayTo(ByVal ID_sv As Integer) As DataTable
            Try
                ' Ho so đã nop
                Dim obj As New HoSoNop_Bussines
                Dim dtNop As DataTable = obj.HienThi_ESSTableHoSoNop(ID_sv)

                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ma_giay_to", GetType(String))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                dt.Columns.Add("Ban_chinh", GetType(Boolean))
                dt.Columns.Add("Ban_sao", GetType(Boolean))
                dt.Columns.Add("Ghi_chu_nop", GetType(String))
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    Dim gt As ESSLoaiGiayTo = CType(arrLoaiGiayTo(i), ESSLoaiGiayTo)
                    Dim row As DataRow = dt.NewRow()
                    If dtNop Is Nothing Then
                        row("Chon") = False
                        row("Ban_chinh") = False
                        row("Ban_sao") = False
                    Else
                        Dim dk As String = "ID_giay_to=" & gt.ID_giay_to
                        dtNop.DefaultView.RowFilter = dk
                        If dtNop.DefaultView.Count > 0 Then
                            row("Chon") = True
                        Else
                            row("Chon") = False
                        End If
                    End If
                    row("ID_giay_to") = gt.ID_giay_to
                    row("Ma_giay_to") = gt.Ma_giay_to
                    row("Ten_giay_to") = gt.Ten_giay_to
                    If dtNop.DefaultView.Count > 0 Then
                        row("Ghi_chu_nop") = dtNop.DefaultView.Item(0)("Ghi_chu_nop")
                        row("Ban_chinh") = dtNop.DefaultView.Item(0)("Ban_chinh")
                        row("Ban_sao") = dtNop.DefaultView.Item(0)("Ban_sao")
                    Else
                        row("Ban_chinh") = False
                        row("Ban_sao") = False
                    End If

                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSLoaiGiayTo(ByVal objLoaiGiayTo As ESSLoaiGiayTo) As Integer
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.ThemMoi_ESSLoaiGiayTo(objLoaiGiayTo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiGiayTo(ByVal objLoaiGiayTo As ESSLoaiGiayTo, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.CapNhat_ESSLoaiGiayTo(objLoaiGiayTo, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiGiayTo(ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.Xoa_ESSLoaiGiayTo(ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drLoaiGiayTo As DataRow) As ESSLoaiGiayTo
            Dim result As ESSLoaiGiayTo
            Try
                result = New ESSLoaiGiayTo
                If drLoaiGiayTo("ID_giay_to").ToString() <> "" Then result.ID_giay_to = CType(drLoaiGiayTo("ID_giay_to").ToString(), Integer)
                result.Ma_giay_to = drLoaiGiayTo("Ma_giay_to").ToString()
                result.Ten_giay_to = drLoaiGiayTo("Ten_giay_to").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#Region " Giấy tờ cần nộp theo đối tượng học bổng"
        ' Danh sách giấy tờ cần nộp theo đối tượng học bổng
        Public Function DoiTuong_GiayTo(ByVal Ma_dt As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("ID_giay_to", GetType(Integer))
                dt.Columns.Add("Ten_giay_to", GetType(String))
                Dim dr As DataRow
                Dim obj As New ESSLoaiGiayTo
                For i As Integer = 0 To arrLoaiGiayTo.Count - 1
                    obj = CType(arrLoaiGiayTo(i), ESSLoaiGiayTo)
                    For j As Integer = 0 To dtDoiTuongGT.Rows.Count - 1
                        If obj.ID_giay_to = dtDoiTuongGT.Rows(j)("ID_giay_to") And dtDoiTuongGT.Rows(j)("Ma_dt").ToString = Ma_dt Then
                            dr = dt.NewRow
                            dr("Ma_dt") = Ma_dt
                            dr("ID_giay_to") = obj.ID_giay_to
                            dr("Ten_giay_to") = obj.Ten_giay_to.ToString
                            dt.Rows.Add(dr)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.ThemMoi_ESSDoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.CapNhat_ESSDoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.Xoa_ESSDoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Boolean
            Try
                Dim obj As LoaiGiayTo_DataAccess = New LoaiGiayTo_DataAccess
                Return obj.KiemTra_DoiTuongGiayTo(Ma_dt, ID_giay_to)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#End Region
    End Class
End Namespace
