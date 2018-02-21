'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, May 03, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSach_Bussines
        Inherits ESSDanhSach
        Private mID_lop As Integer

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lop As Integer)
            mID_lop = ID_lop
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function GetMa_sv() As String
            Dim ID_he As Integer = 0
            Dim ID_khoa As Integer = 0
            Dim Khoa_hoc As Integer = 0
            Dim ID_cn As Integer = 0
            Dim Max_ma As String = ""
            Dim strBegin As String = ""
            Dim strEnd As String = ""
            Dim strMa As String = ""
            Dim Arr() As String = Nothing
            Dim tmp As Double
            Dim i As Integer
            Try
                MaSV_Max(Arr, strBegin, strEnd)
                tmp = Arr(0)
                For i = 1 To Arr.Length - 1
                    If tmp < Arr(i) Then tmp = Arr(i)
                Next
                strMa = strBegin & tmp + 1 & strEnd
                If strMa.Length > 20 Then
                    MsgBox("Do mã phức tạp nên chương trình không sinh mã tự động được!")
                    strMa = ""
                End If
                Return strMa
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Public Sub MaSV_Max(ByRef Arr() As String, ByRef strBegin As String, ByRef strEnd As String)
            Dim Xau As String
            Dim i As Integer = Nothing
            Dim j As Integer = Nothing
            Dim Pos As Integer = Nothing
            Dim objDanhSach_DataAccess As New DanhSach_DataAccess
            Dim objDanhSach As New ESSDanhSach
            Dim dt As DataTable = objDanhSach_DataAccess.HienThi_ESSDanhSach(mID_lop)
            If dt.Rows.Count <= 0 Then Exit Sub
            Xau = ""
            strEnd = ""
            strBegin = ""
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Ma_SV").ToString <> "" Then
                    Dim flg As Byte = 0
                    Dim MaSV_tmp As String = dt.Rows(i).Item("Ma_SV").ToString
                    For j = 1 To Len(MaSV_tmp)
                        'Cuối xâu bắt đầu là kí tự chữ
                        If flg = 0 And Not IsNumeric(Right(MaSV_tmp, j)) Then
                            MaSV_tmp = Left(MaSV_tmp, Len(MaSV_tmp) - 1)
                            strEnd = Right(dt.Rows(i).Item("Ma_SV").ToString, j)
                        End If
                        If IsNumeric(Right(MaSV_tmp, j)) Then flg = 1 'Gặp kí tự dạng số
                        If flg = 1 And Not IsNumeric(Right(MaSV_tmp, j)) Then 'Gặp ký tự chữ
                            flg = 2
                            strBegin = Left(MaSV_tmp, Len(Right(MaSV_tmp, j - 1)))
                            Exit For
                        End If
                    Next
                    If flg = 2 Then 'Xâu có chứa ký tự ở đầu xâu
                        If Xau.Trim = "" Then
                            Xau = Right(Right(MaSV_tmp, j), Len(Right(MaSV_tmp, j)) - 1)
                        Else
                            Xau = Xau & "," & Right(Right(MaSV_tmp, j), Len(Right(MaSV_tmp, j)) - 1)
                        End If
                    Else 'Tất cả xâu là số
                        If Xau.Trim = "" Then
                            Xau = Right(MaSV_tmp, j)
                        Else
                            Xau = Xau & "," & Right(MaSV_tmp, j)
                        End If
                    End If
                End If
                'For j = Len(dt.Rows(i).Item("Ma_SV")) To 0 Step -1
            Next
            Arr = Split(Xau, ",", , CompareMethod.Binary)
        End Sub
        Public Function ThemMoi_ESSDanhSach(ByVal objDanhSach As ESSDanhSach) As Integer
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.ThemMoi_ESSDanhSach(objDanhSach)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDanhSach_NhapHoc(ByVal objDanhSach As ESSDanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.CapNhat_ESSDanhSach_NhapHoc(objDanhSach, ID_svs, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDanhSach(ByVal objDanhSach As ESSDanhSach, ByVal ID_sv As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.CapNhat_ESSDanhSach(objDanhSach, ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.Xoa_ESSDanhSach(ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_DanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.KiemTra_DanhSach(ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSach_SinhVien(ByVal ID_lop As String) As Integer
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.Xoa_ESSDanhSach_SinhVien(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhSach As DataRow) As ESSDanhSach
            Dim result As ESSDanhSach
            Try
                result = New ESSDanhSach
                If drDanhSach("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSach("ID_sv").ToString(), Integer)
                If drDanhSach("Ma_sv").ToString() <> "" Then result.Ma_sv = CType(drDanhSach("Ma_sv").ToString(), String)
                If drDanhSach("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSach("ID_lop").ToString(), Integer)
                result.Mat_khau = drDanhSach("Mat_khau").ToString()
                result.Active = drDanhSach("Active").ToString()
                result.Da_tot_nghiep = drDanhSach("Da_tot_nghiep").ToString()
                result.Ma_sv = drDanhSach("Ma_sv").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region

        Public Function KiemTra_TruocKhiXoa_SV(ByVal ID_sv As Integer) As Boolean
            Try
                Dim obj As DanhSach_DataAccess = New DanhSach_DataAccess
                Return obj.KiemTra_TruocKhiXoa_SV(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
