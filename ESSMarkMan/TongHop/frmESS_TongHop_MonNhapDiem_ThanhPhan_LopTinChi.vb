Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi
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
        dt_ChuaNhapDiem.Columns.Add("ID_lop_tc", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("ID_mon", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("STT_lop", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("Ky_hieu_lop_tc", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("Ten_mon", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("So_hoc_trinh", GetType(String))
        dt_ChuaNhapDiem.Columns.Add("Phan_tram", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("So_sv_lop", GetType(Integer))
        dt_ChuaNhapDiem.Columns.Add("So_sv_co_diem", GetType(Integer))

        Dim dt_NhapDiem_ChuaDu As New DataTable
        dt_NhapDiem_ChuaDu.Columns.Add("ID_lop_tc", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("ID_mon", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("STT_lop", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("Ky_hieu_lop_tc", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("Ten_mon", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("So_hoc_trinh", GetType(String))
        dt_NhapDiem_ChuaDu.Columns.Add("Phan_tram", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("So_sv_lop", GetType(Integer))
        dt_NhapDiem_ChuaDu.Columns.Add("So_sv_co_diem", GetType(Integer))

        Dim dt_NhapDiem_Du As New DataTable
        dt_NhapDiem_Du.Columns.Add("ID_lop_tc", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("ID_mon", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("STT_lop", GetType(String))
        dt_NhapDiem_Du.Columns.Add("Ky_hieu_lop_tc", GetType(String))
        dt_NhapDiem_Du.Columns.Add("Ten_mon", GetType(String))
        dt_NhapDiem_Du.Columns.Add("So_hoc_trinh", GetType(String))
        dt_NhapDiem_Du.Columns.Add("Phan_tram", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("So_sv_lop", GetType(Integer))
        dt_NhapDiem_Du.Columns.Add("So_sv_co_diem", GetType(Integer))

        Dim dt_NhapDiem_Du_DaKhoa As New DataTable
        dt_NhapDiem_Du_DaKhoa.Columns.Add("ID_lop_tc", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("ID_mon", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("STT_lop", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Ky_hieu_lop_tc", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Ten_mon", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("So_hoc_trinh", GetType(String))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("Phan_tram", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("So_sv_lop", GetType(Integer))
        dt_NhapDiem_Du_DaKhoa.Columns.Add("So_sv_co_diem", GetType(Integer))

        SQL = "SELECT b.Ky_hieu_lop_tc,STT_lop , a.ID_lop_tc,COUNT(*) AS So_sv_lop,b.ID_mon,Ten_mon,b.So_tin_chi FROM PLAN_LopTinChi_TC a " & _
                "INNER JOIN PLAN_MonTinChi_TC b ON a.ID_mon_tc=b.ID_mon_tc " & _
                "INNER JOIN STU_DANHSACHLOPTINCHI c ON a.ID_lop_tc=c.ID_lop_tc " & _
                "INNER JOIN MARK_MonHoc d ON b.ID_mon=d.ID_mon WHERE ID_lop_lt=0 AND Ky_dang_ky=" & cmbKy_dang_ky.SelectedValue & _
                " GROUP BY b.Ky_hieu_lop_tc,a.ID_lop_tc,STT_lop,b.ID_mon,Ten_mon,b.So_tin_chi"
        Dim dt_Lop As DataTable = clsdm.LoadDanhMuc(SQL)
        For i As Integer = 0 To dt_Lop.Rows.Count - 1
            SQL = "SELECT DISTINCT a.ID_diem,c.ID_lop_tc,f.ID_mon,Ten_mon FROM MARK_DiemThanhPhan_TC a " & _
                    "INNER JOIN MARK_Diem_TC b ON a.ID_diem=b.ID_diem " & _
                    "INNER JOIN STU_DANHSACHLOPTINCHI c ON b.ID_sv=c.ID_sv " & _
                    "INNER JOIN PLAN_LopTinChi_TC e ON c.ID_lop_tc=e.ID_lop_tc " & _
                    "INNER JOIN PLAN_MonTinChi_TC d ON b.ID_mon=d.ID_mon AND e.ID_mon_tc=d.ID_mon_tc " & _
                    "INNER JOIN MARK_MonHoc f ON d.ID_mon=f.ID_mon " & _
                    "WHERE c.ID_lop_tc =" & dt_Lop.Rows(i)("ID_lop_tc")
            Dim dt_Diem As DataTable = clsdm.LoadDanhMuc(SQL)

            Dim dr As DataRow
            If dt_Diem.Rows.Count > 0 Then 'Da co diem
                If dt_Diem.Rows.Count = dt_Lop.Rows(i)("So_sv_lop") Then 'Da nhap du diem
                    SQL = "SELECT DISTINCT a.ID_diem FROM MARK_DiemThanhPhan_TC a " & _
                           "INNER JOIN MARK_Diem_TC b ON a.ID_diem=b.ID_diem " & _
                           "INNER JOIN STU_DANHSACHLOPTINCHI c ON b.ID_sv=c.ID_sv " & _
                           "INNER JOIN PLAN_LopTinChi_TC e ON c.ID_lop_tc=e.ID_lop_tc " & _
                           "INNER JOIN PLAN_MonTinChi_TC d ON b.ID_mon=d.ID_mon AND e.ID_mon_tc=d.ID_mon_tc " & _
                           "WHERE Locked_tp=1 AND c.ID_lop_tc =" & dt_Lop.Rows(i)("ID_lop_tc")
                    Dim dt_Diem_Lock As DataTable = clsdm.LoadDanhMuc(SQL)

                    If dt_Diem_Lock.Rows.Count > 0 Then
                        If dt_Diem_Lock.Rows.Count = dt_Lop.Rows(i)("So_sv_lop") Then
                            dr = dt_NhapDiem_Du_DaKhoa.NewRow
                            dr("ID_lop_tc") = dt_Lop.Rows(i)("ID_lop_tc")
                            dr("STT_lop") = dt_Lop.Rows(i)("STT_lop")
                            dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                            dr("So_sv_co_diem") = dt_Lop.Rows(i)("So_sv_lop")
                            dr("Phan_tram") = 100
                            dr("ID_mon") = dt_Diem.Rows(0)("ID_mon")
                            dr("Ky_hieu_lop_tc") = dt_Lop.Rows(i)("Ky_hieu_lop_tc")
                            dr("So_hoc_trinh") = dt_Lop.Rows(i)("So_tin_chi")
                            dr("Ten_mon") = dt_Diem.Rows(0)("Ten_mon")
                            dt_NhapDiem_Du_DaKhoa.Rows.Add(dr)
                        Else
                            dr = dt_NhapDiem_Du.NewRow
                            dr("ID_lop_tc") = dt_Lop.Rows(i)("ID_lop_tc")
                            dr("STT_lop") = dt_Lop.Rows(i)("STT_lop")
                            dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                            dr("So_sv_co_diem") = dt_Lop.Rows(i)("So_sv_lop")
                            dr("ID_mon") = dt_Diem.Rows(0)("ID_mon")
                            dr("Ky_hieu_lop_tc") = dt_Lop.Rows(i)("Ky_hieu_lop_tc")
                            dr("So_hoc_trinh") = dt_Lop.Rows(i)("So_tin_chi")
                            dr("Ten_mon") = dt_Diem.Rows(0)("Ten_mon")
                            dr("Phan_tram") = (dt_Diem_Lock.Rows.Count / dt_Lop.Rows(i)("So_sv_lop")) * 100
                            dt_NhapDiem_Du.Rows.Add(dr)
                        End If
                    End If
                Else 'Chua nhap du diem
                    dr = dt_NhapDiem_ChuaDu.NewRow
                    dr("ID_lop_tc") = dt_Lop.Rows(i)("ID_lop_tc")
                    dr("STT_lop") = dt_Lop.Rows(i)("STT_lop")
                    dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                    dr("ID_mon") = dt_Diem.Rows(0)("ID_mon")
                    dr("Ky_hieu_lop_tc") = dt_Lop.Rows(i)("Ky_hieu_lop_tc")
                    dr("So_hoc_trinh") = dt_Lop.Rows(i)("So_tin_chi")
                    dr("Ten_mon") = dt_Diem.Rows(0)("Ten_mon")
                    dr("So_sv_co_diem") = dt_Diem.Rows.Count
                    dr("Phan_tram") = (dt_Diem.Rows.Count / dt_Lop.Rows(i)("So_sv_lop")) * 100
                    dt_NhapDiem_ChuaDu.Rows.Add(dr)
                End If
            Else 'Chua nhap diem
                dr = dt_ChuaNhapDiem.NewRow
                dr("ID_lop_tc") = dt_Lop.Rows(i)("ID_lop_tc")
                dr("STT_lop") = dt_Lop.Rows(i)("STT_lop")
                dr("So_sv_lop") = dt_Lop.Rows(i)("So_sv_lop")
                dr("ID_mon") = dt_Lop.Rows(0I)("ID_mon")
                dr("Ky_hieu_lop_tc") = dt_Lop.Rows(i)("Ky_hieu_lop_tc")
                dr("So_hoc_trinh") = dt_Lop.Rows(i)("So_tin_chi")
                dr("Ten_mon") = dt_Lop.Rows(i)("Ten_mon")
                dr("So_sv_co_diem") = 0
                dr("Phan_tram") = 0
                dt_ChuaNhapDiem.Rows.Add(dr)
            End If
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
            FillCombo(cmbKy_dang_ky, dt_KhoaHoc)

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

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If cmbNam_hoc.Text = "" Or cmbHoc_ky.Text = "" Or cmbID_he.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim strSQL As String
            If cmbID_he.Text.Trim <> "" Then
                strSQL = "SELECT DISTINCT a.Ky_dang_ky,Dot AS Ten_dot_dk FROM PLAN_HocKyDangKy_TC a INNER JOIN PLAN_MonTinChi_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "WHERE ID_he=" & cmbID_he.SelectedValue & " AND hoc_ky=" & cmbHoc_ky.Text & " AND Nam_hoc='" & cmbNam_hoc.Text & "'"
            Else
                strSQL = "SELECT Ky_dang_ky, Dot  AS Ten_dot_dk FROM PLAN_HocKyDangKy_TC"
            End If
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbKy_dang_ky, dt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbNam_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If cmbNam_hoc.Text = "" Or cmbHoc_ky.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim strSQL As String
            strSQL = "SELECT DISTINCT  c.ID_he,Ten_he FROM PLAN_HocKyDangKy_TC a " & _
                        " INNER JOIN PLAN_MonTinChi_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "INNER JOIN STU_HE d ON c.ID_he=d.ID_he " & _
                       "WHERE hoc_ky=" & cmbHoc_ky.Text & " AND Nam_hoc='" & cmbNam_hoc.Text & "'"
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
        End Try
    End Sub
End Class