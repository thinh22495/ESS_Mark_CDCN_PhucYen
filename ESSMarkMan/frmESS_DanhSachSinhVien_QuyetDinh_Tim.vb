Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_DanhSachSinhVien_QuyetDinh_Tim
#Region "Var"
    Private ID_lops As String = "SELECT ID_LOP from  STU_LOP"
    Private clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
    Private loader As Boolean = False
#End Region
#Region "Form Events"
    Private Sub frmESS_HoatDongDoanTheXaHoiList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_combo()
        'HienThi_ESSdata()
        loader = True
    End Sub
    Private Sub frmESS_HoatDongDoanTheXaHoiList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_TongHopThuHocPhi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "User Functions"

    Private Sub Fill_combo()
        Dim dt As New DataTable
        dt = clsLop.He_dao_tao()
        FillCombo(cmbID_he, dt)
        dt = clsLop.Khoa()
        FillCombo(cmbID_khoa, dt)
        dt = clsLop.Khoa_hoc()
        FillCombo(cmbKhoa_hoc, dt)
        dt = clsLop.Lop()
        FillCombo(cmbID_Lop, dt)
    End Sub

    Private Sub HienThi_ESSdata()
        Try
            Dim clsDSXetLenLop As New DanhSachXetLenLop_Bussines
            Dim dv As DataView = clsDSXetLenLop.HienThi_ESSDanhSachNgungHocThoiHoc_HienThi_DanhSach(ID_lops, cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, cmbLoai_QD.SelectedIndex).DefaultView

            grcDanhSach.DataSource = dv
        Catch ex As Exception
            Thongbao(ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If loader Then
                'Load combobox khoa đào tạo
                loader = False
                Dim dvKhoa As DataView = clsLop.Khoa().DefaultView
                dvKhoa.RowFilter = IIf(cmbID_he.Text = "", "1=1 ", "ID_he=" & cmbID_he.SelectedValue)
                FillCombo(cmbID_khoa, dvKhoa.Table)
                'Load lop
                Dim clsDM As New DanhMuc_Bussines
                Dim strSQL As String
                strSQL = "SELECT DISTINCT ID_LOP,TEN_LOP,KHOA_HOC from  STU_LOP " & _
                           "WHERE 1=1" & IIf(cmbID_he.Text = "", "", " AND ID_he=" & cmbID_he.SelectedValue) & IIf(IsNothing(cmbID_khoa.SelectedValue), "", " AND ID_khoa=" & cmbID_khoa.SelectedValue) & IIf(IsNothing(cmbKhoa_hoc.SelectedValue), "", " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                Dim dvLop As DataView = clsDM.DanhMuc_Load(strSQL).DefaultView
                FillCombo(cmbID_Lop, dvLop.Table)
                ID_lops = "SELECT ID_LOP from  STU_LOP WHERE 1=1 " & IIf(cmbID_he.Text = "", "", " AND ID_he=" & cmbID_he.SelectedValue) & IIf(IsNothing(cmbID_khoa.SelectedValue), "", " AND ID_khoa=" & cmbID_khoa.SelectedValue) & IIf(IsNothing(cmbKhoa_hoc.SelectedValue), "", " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                loader = True
                grcDanhSach.DataSource = Nothing
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
            loader = True
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If loader Then
                'Load combobox khoa đào tạo
                loader = False
                Dim dvKhoaHoc As DataView = clsLop.Khoa_hoc_By_He().DefaultView
                dvKhoaHoc.RowFilter = IIf(cmbID_he.Text = "", "1=1 ", "ID_he=" & cmbID_he.SelectedValue)
                FillCombo(cmbKhoa_hoc, dvKhoaHoc.Table)
                'Load lop
                Dim clsDM As New DanhMuc_Bussines
                Dim strSQL As String
                strSQL = "SELECT DISTINCT ID_LOP,TEN_LOP,KHOA_HOC from  STU_LOP " & _
                           "WHERE 1=1" & IIf(cmbID_he.Text = "", "", " AND ID_he=" & cmbID_he.SelectedValue) & IIf(IsNothing(cmbID_khoa.SelectedValue), "", " AND ID_khoa=" & cmbID_khoa.SelectedValue) & IIf(IsNothing(cmbKhoa_hoc.SelectedValue), "", " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                Dim dvLop As DataView = clsDM.DanhMuc_Load(strSQL).DefaultView
                FillCombo(cmbID_Lop, dvLop.Table)
                ID_lops = "SELECT ID_LOP from  STU_LOP WHERE 1=1 " & IIf(cmbID_he.Text = "", "", " AND ID_he=" & cmbID_he.SelectedValue) & IIf(IsNothing(cmbID_khoa.SelectedValue), "", " AND ID_khoa=" & cmbID_khoa.SelectedValue) & IIf(IsNothing(cmbKhoa_hoc.SelectedValue), "", " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                loader = True
                grcDanhSach.DataSource = Nothing
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
            loader = True
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If loader Then
                'Load lop
                Dim clsDM As New DanhMuc_Bussines
                Dim strSQL As String
                strSQL = "SELECT DISTINCT ID_LOP,TEN_LOP,KHOA_HOC from  STU_LOP " & _
                           "WHERE 1=1" & IIf(cmbID_he.Text = "", "", " AND ID_he=" & cmbID_he.SelectedValue) & IIf(IsNothing(cmbID_khoa.SelectedValue), "", " AND ID_khoa=" & cmbID_khoa.SelectedValue) & IIf(IsNothing(cmbKhoa_hoc.SelectedValue), "", " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                Dim dvLop As DataView = clsDM.DanhMuc_Load(strSQL).DefaultView
                FillCombo(cmbID_Lop, dvLop.Table)
                ID_lops = "SELECT ID_LOP from  STU_LOP WHERE 1=1 " & IIf(cmbID_he.Text = "", "", " AND ID_he=" & cmbID_he.SelectedValue) & IIf(IsNothing(cmbID_khoa.SelectedValue), "", " AND ID_khoa=" & cmbID_khoa.SelectedValue) & IIf(IsNothing(cmbKhoa_hoc.SelectedValue), "", " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                loader = True
                grcDanhSach.DataSource = Nothing
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
            loader = True
        End Try
    End Sub

    Private Sub cmbID_Lop_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_Lop.SelectedIndexChanged
        Try
            If loader Then
                ID_lops = "SELECT ID_LOP from  STU_LOP WHERE 1=1 " & IIf(cmbID_he.Text = "", "", " AND ID_lop=" & cmbID_Lop.SelectedValue)
                grcDanhSach.DataSource = Nothing
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
            loader = True
        End Try
    End Sub






    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If loader = False Then Exit Sub
        HienThi_ESSdata()
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            If grvDanhSach.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDevGridViewToExcel(grvDanhSach)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


End Class