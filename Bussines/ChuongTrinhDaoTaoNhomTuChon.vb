Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ChuongTrinhDaoTaoNhomTuChon_Bussines
        Private arrChuongTrinhDaoTaoNhomTuChon As New ArrayList
        Private arrChuongTrinhDaoTaoNotNhomTuChon As New ArrayList
#Region "Initialize"
        Public Sub New(ByVal ID_dt As Integer)
            Try
                Dim obj As ChuongTrinhDaoTaoNhomTuChon_DataAccess = New ChuongTrinhDaoTaoNhomTuChon_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSChuongTrinhDaoTaoNhomTuChon_DanhSach(ID_dt)
                Dim objNhomTuChon As ESSChuongTrinhDaoTaoNhomTuChon = Nothing
                Dim dr As DataRow = Nothing
                arrChuongTrinhDaoTaoNhomTuChon = New ArrayList
                For Each dr In dt.Rows
                    objNhomTuChon = Mapping(dr)
                    arrChuongTrinhDaoTaoNhomTuChon.Add(objNhomTuChon)
                Next


                dt = obj.HienThi_ESSChuongTrinhDaoTaoNotNhomTuChon_DanhSach(ID_dt)
                objNhomTuChon = Nothing
                dr = Nothing
                arrChuongTrinhDaoTaoNotNhomTuChon = New ArrayList
                For Each dr In dt.Rows
                    objNhomTuChon = MappingNot(dr)
                    arrChuongTrinhDaoTaoNotNhomTuChon.Add(objNhomTuChon)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachNotMonTuChon(ByVal Nhom_tu_chon As Integer) As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_dt")
            dtMon.Columns.Add("So_mon_dang_ky")
            dtMon.Columns.Add("So_mon_tu_chon")
            dtMon.Columns.Add("Nhom_tu_chon")
            dtMon.Columns.Add("Ten_kien_thuc")
            dtMon.Columns.Add("So_hoc_trinh")
            dtMon.Columns.Add("Ky_hieu")
            dtMon.Columns.Add("Ten_mon")
            For i As Integer = 0 To arrChuongTrinhDaoTaoNotNhomTuChon.Count - 1
                If Nhom_tu_chon > 0 AndAlso CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Nhom_tu_chon = Nhom_tu_chon Then
                    Dim row As DataRow = dtMon.NewRow()
                    row("ID_dt") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).ID_dt
                    row("So_mon_dang_ky") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_dang_ky
                    row("So_mon_tu_chon") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_tu_chon
                    row("Nhom_tu_chon") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Nhom_tu_chon
                    row("Ten_kien_thuc") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_kien_thuc
                    row("Ky_hieu") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ky_hieu
                    row("So_hoc_trinh") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_hoc_trinh
                    row("Ten_mon") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_mon
                    dtMon.Rows.Add(row)
                ElseIf Nhom_tu_chon = 0 Then
                    Dim row As DataRow = dtMon.NewRow()
                    row("ID_dt") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).ID_dt
                    row("So_mon_dang_ky") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_dang_ky
                    row("So_mon_tu_chon") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_tu_chon
                    row("Nhom_tu_chon") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Nhom_tu_chon
                    row("Ten_kien_thuc") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_kien_thuc
                    row("Ky_hieu") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ky_hieu
                    row("So_hoc_trinh") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_hoc_trinh
                    row("Ten_mon") = CType(arrChuongTrinhDaoTaoNotNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_mon
                    dtMon.Rows.Add(row)
                End If
            Next
            dtMon.DefaultView.Sort = "Ten_mon"
            Return dtMon
        End Function
        Public Function DanhSachMonTuChon(ByVal Nhom_tu_chon As Integer) As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_dt")
            dtMon.Columns.Add("So_mon_dang_ky")
            dtMon.Columns.Add("So_mon_tu_chon")
            dtMon.Columns.Add("Nhom_tu_chon2")
            dtMon.Columns.Add("Ten_kien_thuc2")
            dtMon.Columns.Add("So_hoc_trinh2")
            dtMon.Columns.Add("Ky_hieu2")
            dtMon.Columns.Add("Ten_mon2")
            For i As Integer = 0 To arrChuongTrinhDaoTaoNhomTuChon.Count - 1
                If Nhom_tu_chon > 0 AndAlso CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Nhom_tu_chon = Nhom_tu_chon Then
                    Dim row As DataRow = dtMon.NewRow()
                    row("ID_dt") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).ID_dt
                    row("So_mon_dang_ky") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_dang_ky & "/" & CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_tu_chon
                    row("So_mon_tu_chon") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_tu_chon
                    row("Nhom_tu_chon2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Nhom_tu_chon
                    row("Ten_kien_thuc2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_kien_thuc
                    row("Ky_hieu2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ky_hieu
                    row("So_hoc_trinh2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_hoc_trinh
                    row("Ten_mon2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_mon
                    dtMon.Rows.Add(row)
                ElseIf Nhom_tu_chon = 0 Then
                    Dim row As DataRow = dtMon.NewRow()
                    row("ID_dt") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).ID_dt
                    row("So_mon_dang_ky") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_dang_ky & "/" & CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_tu_chon
                    row("So_mon_tu_chon") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_mon_tu_chon
                    row("Nhom_tu_chon2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Nhom_tu_chon
                    row("Ten_kien_thuc2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_kien_thuc
                    row("Ky_hieu2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ky_hieu
                    row("So_hoc_trinh2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).So_hoc_trinh
                    row("Ten_mon2") = CType(arrChuongTrinhDaoTaoNhomTuChon(i), ESSChuongTrinhDaoTaoNhomTuChon).Ten_mon
                    dtMon.Rows.Add(row)
                End If
            Next
            dtMon.DefaultView.Sort = "Ten_mon2"
            Return dtMon
        End Function

        Public Function ThemMoi_ESSNhomTuChon(ByVal obj As ESSChuongTrinhDaoTaoNhomTuChon) As Integer
            Try
                Dim objCTDT As ChuongTrinhDaoTaoNhomTuChon_DataAccess = New ChuongTrinhDaoTaoNhomTuChon_DataAccess
                Return objCTDT.ThemMoi_ESSChuongTrinhDaoTaoNhomTuChon(obj)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNhomTuChon(ByVal ID_dt As Integer, ByVal Nhom_tu_chon As Integer) As Integer
            Try
                Dim objCTDT As ChuongTrinhDaoTaoNhomTuChon_DataAccess = New ChuongTrinhDaoTaoNhomTuChon_DataAccess
                Return objCTDT.Xoa_ESSChuongTrinhDaoTaoNhomTuChon(ID_dt, Nhom_tu_chon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping(ByVal dr As DataRow) As ESSChuongTrinhDaoTaoNhomTuChon
            Dim result As ESSChuongTrinhDaoTaoNhomTuChon
            Try
                result = New ESSChuongTrinhDaoTaoNhomTuChon
                If dr("ID_dt").ToString() <> "" Then result.ID_dt = CType(dr("ID_dt").ToString(), Integer)
                If dr("Nhom_tu_chon").ToString() <> "" Then result.Nhom_tu_chon = CType(dr("Nhom_tu_chon").ToString(), Integer)
                If dr("So_mon_dang_ky").ToString() <> "" Then result.So_mon_dang_ky = CType(dr("So_mon_dang_ky").ToString(), Integer)
                If dr("So_mon_tu_chon").ToString() <> "" Then result.So_mon_tu_chon = CType(dr("So_mon_tu_chon").ToString(), Integer)
                If dr("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(dr("So_hoc_trinh").ToString(), Integer)

                result.Ten_kien_thuc = dr("Ten_kien_thuc").ToString()
                result.Ten_mon = dr("Ten_mon").ToString()
                result.Ky_hieu = dr("Ky_hieu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingNot(ByVal dr As DataRow) As ESSChuongTrinhDaoTaoNhomTuChon
            Dim result As ESSChuongTrinhDaoTaoNhomTuChon
            Try
                result = New ESSChuongTrinhDaoTaoNhomTuChon
                If dr("ID_dt").ToString() <> "" Then result.ID_dt = CType(dr("ID_dt").ToString(), Integer)
                If dr("Nhom_tu_chon").ToString() <> "" Then result.Nhom_tu_chon = CType(dr("Nhom_tu_chon").ToString(), Integer)
                If dr("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(dr("So_hoc_trinh").ToString(), Integer)

                result.Ten_kien_thuc = dr("Ten_kien_thuc").ToString()
                result.Ten_mon = dr("Ten_mon").ToString()
                result.Ky_hieu = dr("Ky_hieu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
