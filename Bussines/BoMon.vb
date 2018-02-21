'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, May 08, 2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class BoMon_Bussines
        Private arrBoMon As ArrayList
#Region "Initialize"
        Sub New()
            'Add tat ca bo mon
            Try
                arrBoMon = New ArrayList
                Dim objBm_dal As New BoMon_DataAccess
                Dim dt As DataTable = objBm_dal.HienThi_ESSBoMon_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objBoMon As New ESSBoMon
                        objBoMon = MappingBoMon(dt.Rows(i))
                        'Add tat ca cac Giang Vien cua tung bo mon
                        Dim objGv_dal As New BoMonGiangVien_DataAccess
                        Dim dt1 As DataTable = objGv_dal.HienThi_ESSGiangVien(objBoMon.ID_bm)
                        For j As Integer = 0 To dt1.Rows.Count - 1
                            Dim objBoMonGiangVien As New ESSBoMonGiangVien
                            objBoMonGiangVien = MappingBoMonGiangVien(dt1.Rows(j))
                            objBoMon.dsGiangVien.Add(objBoMonGiangVien)
                        Next
                        'Add tat ca cac Mon Hoc cua tung bo mon
                        Dim objMh_dal As New MonHoc_DataAccess
                        Dim dt2 As DataTable = objMh_dal.HienThi_ESSMonHoc_BoMon_DanhSach(objBoMon.ID_bm)
                        For j As Integer = 0 To dt2.Rows.Count - 1
                            Dim objMonHoc As New ESSMonHoc
                            objMonHoc = MappingMonHoc(dt2.Rows(j))
                            objBoMon.dsMonHoc.Add(objMonHoc)
                        Next
                        arrBoMon.Add(objBoMon)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub

#End Region
#Region "Functions And Subs"
        Public Function DanhSachBoMon() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_bm", GetType(Integer))
            dt.Columns.Add("Ma_bo_mon", GetType(String))
            dt.Columns.Add("Bo_mon", GetType(String))
            dt.Columns.Add("So_mon", GetType(String))
            dt.Columns.Add("So_giang_vien", GetType(String))
            For i As Integer = 0 To arrBoMon.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim bm As ESSBoMon = CType(arrBoMon(i), ESSBoMon)
                row("ID_bm") = bm.ID_bm
                row("Ma_bo_mon") = bm.Ma_bo_mon
                row("Bo_mon") = bm.Bo_mon
                row("So_mon") = bm.dsMonHoc.Count
                row("So_giang_vien") = bm.dsGiangVien.Count
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function DanhMucBoMon() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_bm", GetType(Integer))
            dt.Columns.Add("Bo_mon", GetType(String))
            For i As Integer = 0 To arrBoMon.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim bm As ESSBoMon = CType(arrBoMon(i), ESSBoMon)
                row("ID_bm") = bm.ID_bm
                row("Bo_mon") = bm.Bo_mon
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function DanhSachGiangVien(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            Dim idx As Integer = TimIdx(ID_bm)
            If idx >= 0 Then
                Dim objBoMon As New ESSBoMon
                objBoMon = CType(arrBoMon(idx), ESSBoMon)
                For i As Integer = 0 To objBoMon.dsGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objBoMonGiangVien As ESSBoMonGiangVien = objBoMon.dsGiangVien(i)
                    row("ID_cb") = objBoMonGiangVien.ID_cb
                    row("Ma_cb") = objBoMonGiangVien.Ma_cb
                    row("Ho_ten") = objBoMonGiangVien.Ho_ten
                    dt.Rows.Add(row)
                Next
            End If
            Return dt
        End Function
        Public Function DanhSachMonHoc(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            Dim idx As Integer = TimIdx(ID_bm)
            If idx >= 0 Then
                Dim objBoMon As New ESSBoMon
                objBoMon = CType(arrBoMon(idx), ESSBoMon)
                For i As Integer = 0 To objBoMon.dsMonHoc.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objMonHoc As ESSMonHoc = objBoMon.dsMonHoc(i)
                    row("ID_mon") = objMonHoc.ID_mon
                    row("Ky_hieu") = objMonHoc.Ky_hieu
                    row("Ten_mon") = objMonHoc.Ten_mon
                    dt.Rows.Add(row)
                Next
            End If
            Return dt
        End Function
        Private Function TimIdx(ByVal ID_bm As Integer) As Integer
            For i As Integer = 0 To arrBoMon.Count - 1
                If CType(arrBoMon(i), ESSBoMon).ID_bm = ID_bm Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function HienThi_ESSBoMon(ByVal ID_bm As Integer) As ESSBoMon
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSBoMon(ID_bm)
                Dim obBoMon As ESSBoMon = Nothing
                If dt.Rows.Count > 0 Then
                    obBoMon = MappingBoMon(dt.Rows(0))
                End If
                Return obBoMon
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBoMon(ByVal objtkbBoMon As ESSBoMon) As Integer
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                Return obj.ThemMoi_ESSBoMon(objtkbBoMon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBoMon(ByVal objtkbBoMon As ESSBoMon) As Integer
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                Return obj.CapNhat_ESSBoMon(objtkbBoMon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBoMon(ByVal ID_bm As Integer) As Integer
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                Return obj.Xoa_ESSBoMon(ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Bomon(ByVal ID_bm As Integer) As Boolean
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                Return obj.CheckExist_BoMon(ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Bomon(ByVal Ma_bo_mon As String) As Boolean
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                Return obj.CheckExist_BoMon(Ma_bo_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_Bomon(ByVal ID_bm As Integer) As Integer
            Try
                Dim obj As BoMon_DataAccess = New BoMon_DataAccess
                obj.GetMaxID_BoMon(ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function MappingBoMon(ByVal drBomon As DataRow) As ESSBoMon
            Dim result As ESSBoMon
            Try
                result = New ESSBoMon
                If drBomon("ID_bm").ToString() <> "" Then result.ID_bm = CType(drBomon("ID_bm").ToString(), Integer)
                result.Ma_bo_mon = drBomon("Ma_bo_mon").ToString()
                result.Bo_mon = drBomon("Bo_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingBoMonGiangVien(ByVal drBoMonGiangVien As DataRow) As ESSBoMonGiangVien
            Dim result As ESSBoMonGiangVien
            Try
                result = New ESSBoMonGiangVien
                If drBoMonGiangVien("id_bm").ToString() <> "" Then result.ID_bm = CType(drBoMonGiangVien("id_bm").ToString(), Integer)
                If drBoMonGiangVien("ID_cb").ToString() <> "" Then result.ID_cb = CType(drBoMonGiangVien("ID_cb").ToString(), Integer)
                result.Ma_cb = drBoMonGiangVien("Ma_cb").ToString()
                result.Ten = drBoMonGiangVien("Ten").ToString()
                result.Ho_ten = drBoMonGiangVien("Ho_ten").ToString()
                If drBoMonGiangVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drBoMonGiangVien("ID_gioi_tinh").ToString(), Integer)
                If drBoMonGiangVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drBoMonGiangVien("Ngay_sinh").ToString(), Date)
                If drBoMonGiangVien("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drBoMonGiangVien("ID_khoa").ToString(), Integer)
                If drBoMonGiangVien("ID_hoc_ham").ToString() <> "" Then result.ID_hoc_ham = CType(drBoMonGiangVien("ID_hoc_ham").ToString(), Integer)
                If drBoMonGiangVien("ID_hoc_vi").ToString() <> "" Then result.ID_hoc_vi = CType(drBoMonGiangVien("ID_hoc_vi").ToString(), Integer)
                If drBoMonGiangVien("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drBoMonGiangVien("ID_chuc_danh").ToString(), Integer)
                If drBoMonGiangVien("ID_chuc_vu").ToString() <> "" Then result.ID_chuc_vu = CType(drBoMonGiangVien("ID_chuc_vu").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingMonHoc(ByVal drMonHoc As DataRow) As ESSMonHoc
            Dim result As ESSMonHoc
            Try
                result = New ESSMonHoc
                If drMonHoc("id_bm").ToString() <> "" Then result.ID_bm = CType(drMonHoc("id_bm").ToString(), Integer)
                If drMonHoc("ID_mon").ToString() <> "" Then result.ID_mon = CType(drMonHoc("ID_mon").ToString(), Integer)
                result.Ky_hieu = drMonHoc("Ky_hieu").ToString()
                result.Ten_mon = drMonHoc("Ten_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace