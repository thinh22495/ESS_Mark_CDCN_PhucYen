Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmESS_TongHop_MonNhapDiem_ThanhPhan
    Private Loader As Boolean = False
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Dim SQL As String = ""
    Private clsdm As New DanhMuc_Bussines

    Private Sub frmESS_TongHop_MonNhapDiem_ThanhPhan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LoadComboBox()
            'SetUpDataGridView(grdViewDiem)
            Loader = True
        Catch ex As Exception
        End Try
    End Sub


    Private Sub frmESS_TongHop_MonNhapDiem_ThanhPhan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub TongHop_Diem_ThanhPhan()
        Dim dt_ChuaNhapDiem As New DataTable
        dt_ChuaNhapDiem.Columns.Add("ID_lop", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("ID_mon", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("Ten_lop1", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("Ky_hieu", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("Ten_mon", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("So_hoc_trinh", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("Phan_tram", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("So_sv_lop", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("So_sv_co_diem", GetType(Integer))

        Dim dt_NhapDiem_ChuaDu As New DataTable
        dt_NhapDiem_ChuaDu.Columns.Add("ID_lop", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("ID_mon", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("Ten_lop2", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("Ky_hieu", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("Ten_mon", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("So_hoc_trinh", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("Phan_tram", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("So_sv_lop", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("So_sv_co_diem", GetType(Integer))

        Dim dt_NhapDiem_Du As New DataTable
        dt_NhapDiem_Du.Columns.Add("ID_lop", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("ID_mon", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("Ten_lop3", GetType(String))
        dt_NhapDiem_Du.Columns.Add("Ky_hieu", GetType(String))
        dt_NhapDiem_Du.Columns.Add("Ten_mon", GetType(String))
        dt_NhapDiem_Du.Columns.Add("So_hoc_trinh", GetType(String))
        dt_NhapDiem_Du.Columns.Add("Phan_tram2", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("So_sv_lop", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("So_sv_co_diem", GetType(Integer))

        Dim dt_NhapDiem_Du_DaKhoa As New DataTable
        dt_NhapDiem_Du_DaKhoa.Columns.Add("ID_lop", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("ID_mon", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Ten_lop4", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Ky_hieu", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Ten_mon", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("So_hoc_trinh", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Phan_tram", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("So_sv_lop", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("So_sv_co_diem", GetType(Integer))

        SQL = "SELECT a.ID_lop,ID_dt,COUNT(*) AS So_sv_lop,Ten_lop,Nien_khoa FROM STU_Lop a " & _
                "INNER JOIN STU_DanhSach b ON a.ID_lop=b.ID_lop WHERE ID_he=" & cmbID_he.SelectedValue & " AND Khoa_hoc=" & cmbKhoa_hoc.Text & _
                "GROUP BY a.ID_lop,ID_dt,Nien_khoa,Ten_lop ORDER BY Ten_lop"
        Dim dt_Lop As DataTable = clsdm.LoadDanhMuc(SQL)
        For i As Integer = 0 To dt_Lop.Rows.Count - 1
            Dim Ky_thu As Integer = Ky2to10(cmbHoc_ky.Text, cmbNam_hoc.Text, dt_Lop.Rows(i)("Nien_khoa"))
            SQL = "SELECT a.ID_mon,Ky_hieu,Ten_mon,So_hoc_trinh,0 AS So_sv_theo_diem,0 AS So_sv_lop,0 AS Phan_tram FROM PLAN_ChuongTrinhDaoTaoChiTiet a INNER JOIN MARK_MONHOC b ON a.ID_mon=b.ID_mon WHERE ID_dt=" & dt_Lop.Rows(i)("ID_dt") & " AND Ky_thu=" & Ky_thu
            Dim dt_Mon As DataTable = clsdm.LoadDanhMuc(SQL)
            For j As Integer = 0 To dt_Mon.Rows.Count - 1
                SQL = "SELECT DISTINCT a.ID_diem FROM MARK_DiemThanhPhan_TC a " & _
                        "INNER JOIN MARK_Diem_TC b ON a.ID_diem=b.ID_diem " & _
                        "INNER JOIN STU_DanhSach c ON b.ID_sv=c.ID_sv " & _
                        "WHERE ID_lop=" & dt_Lop.Rows(i)("ID_lop") & " AND ID_mon=" & dt_Mon.Rows(j)("ID_mon") & _
                        " AND Hoc_ky_TP=" & cmbHoc_ky.Text & " AND Nam_hoc_TP='" & cmbNam_hoc.Text & "'"
                Dim dt_Diem As DataTable = clsdm.LoadDanhMuc(SQL)

                Dim dr As DataRow
                If dt_Diem.Rows.Count > 0 Then 'Da co diem
                    If dt_Diem.Rows.Count = dt_Lop.Rows(i)("So_sv_lop") Then 'Da nhap du diem
                        SQL = "SELECT DISTINCT a.ID_diem FROM MARK_DiemThanhPhan_TC a " & _
                        "INNER JOIN MARK_Diem_TC b ON a.ID_diem=b.ID_diem " & _
                        "INNER JOIN STU_DanhSach c ON b.ID_sv=c.ID_sv " & _
                        "WHERE Locked_tp=1 AND ID_lop=" & dt_Lop.Rows(i)("ID_lop") & " AND ID_mon=" & dt_Mon.Rows(j)("ID_mon") & _
                        " AND Hoc_ky_TP=" & cmbHoc_ky.Text & " AND Nam_hoc_TP='" & cmbNam_hoc.Text & "'"
                        Dim dt_Diem_Lock As DataTable = clsdm.LoadDanhMuc(SQL)

                        If dt_Diem_Lock.Rows.Count > 0 Then
                            If dt_Diem_Lock.Rows.Count = dt_Lop.Rows(i)("So_sv_lop") Then
                                dr = dt_NhapDiem_Du_DaKhoa.NewRow
                                dr("ID_lop") = dt_Lop.Rows(i)("ID_lop")
                                dr("Ten_lop4") = dt_Lop.Rows(i)("Ten_lop")
                                dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                                dr("So_sv_co_diem") = dt_Lop.Rows(i)("So_sv_lop")
                                dr("Phan_tram") = 100
                                dr("ID_mon") = dt_Mon.Rows(j)("ID_mon")
                                dr("Ky_hieu") = dt_Mon.Rows(j)("Ky_hieu")
                                dr("So_hoc_trinh") = dt_Mon.Rows(j)("So_hoc_trinh")
                                dr("Ten_mon") = dt_Mon.Rows(j)("Ten_mon")
                                dt_NhapDiem_Du_DaKhoa.Rows.Add(dr)
                            Else
                                dr = dt_NhapDiem_Du.NewRow
                                dr("ID_lop") = dt_Lop.Rows(i)("ID_lop")
                                dr("Ten_lop3") = dt_Lop.Rows(i)("Ten_lop")
                                dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                                dr("So_sv_co_diem") = dt_Lop.Rows(i)("So_sv_lop")
                                dr("Phan_tram2") = (dt_Diem_Lock.Rows.Count / dt_Lop.Rows(i)("So_sv_lop")) * 100
                                dr("ID_mon") = dt_Mon.Rows(j)("ID_mon")
                                dr("Ky_hieu") = dt_Mon.Rows(j)("Ky_hieu")
                                dr("So_hoc_trinh") = dt_Mon.Rows(j)("So_hoc_trinh")
                                dr("Ten_mon") = dt_Mon.Rows(j)("Ten_mon")
                                dt_NhapDiem_Du.Rows.Add(dr)
                            End If
                        End If
                    Else 'Chua nhap du diem
                        dr = dt_NhapDiem_ChuaDu.NewRow
                        dr("ID_lop") = dt_Lop.Rows(i)("ID_lop")
                        dr("Ten_lop2") = dt_Lop.Rows(i)("Ten_lop")
                        dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                        dr("So_sv_co_diem") = dt_Diem.Rows.Count
                        dr("Phan_tram") = (dt_Diem.Rows.Count / dt_Lop.Rows(i)("So_sv_lop")) * 100
                        dr("ID_mon") = dt_Mon.Rows(j)("ID_mon")
                        dr("Ky_hieu") = dt_Mon.Rows(j)("Ky_hieu")
                        dr("So_hoc_trinh") = dt_Mon.Rows(j)("So_hoc_trinh")
                        dr("Ten_mon") = dt_Mon.Rows(j)("Ten_mon")
                        dt_NhapDiem_ChuaDu.Rows.Add(dr)
                    End If
                Else 'Chua nhap diem
                    dr = dt_ChuaNhapDiem.NewRow
                    dr("ID_lop") = dt_Lop.Rows(i)("ID_lop")
                    dr("Ten_lop1") = dt_Lop.Rows(i)("Ten_lop")
                    dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                    dr("So_sv_co_diem") = 0
                    dr("Phan_tram") = 0
                    dr("ID_mon") = dt_Mon.Rows(j)("ID_mon")
                    dr("Ky_hieu") = dt_Mon.Rows(j)("Ky_hieu")
                    dr("So_hoc_trinh") = dt_Mon.Rows(j)("So_hoc_trinh")
                    dr("Ten_mon") = dt_Mon.Rows(j)("Ten_mon")
                    dt_ChuaNhapDiem.Rows.Add(dr)
                End If
            Next
        Next

        grcChuaCoDiem.DataSource = dt_ChuaNhapDiem.DefaultView
        grcChuaDuDiem.DataSource = dt_NhapDiem_ChuaDu.DefaultView
        grcDuDiemChuaKhoa.DataSource = dt_NhapDiem_Du.DefaultView
        grcDuDiemDaKhoa.DataSource = dt_NhapDiem_Du_DaKhoa.DefaultView
    End Sub

    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)

            SQL = "SELECT ID_he,Ten_he FROM STU_he ORDER BY Ten_he"
            Dim dt_he As DataTable = clsdm.LoadDanhMuc(SQL)
            FillCombo(cmbID_he, dt_he)
            SQL = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM STU_LOP ORDER BY Khoa_hoc"
            Dim dt_KhoaHoc As DataTable = clsdm.LoadDanhMuc(SQL)
            FillCombo(cmbKhoa_hoc, dt_KhoaHoc)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdKhoa_Diem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKhoa_Diem.Click
        Try
            TongHop_Diem_ThanhPhan()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class