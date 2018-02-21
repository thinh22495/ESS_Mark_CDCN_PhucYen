Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmESS_LapDanhSachThi_ThiLai
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private mEdit As Boolean = False
    Private clsDiem As New Diem_Bussines
    Private clsCTDT As ChuongTrinhDaoTao_Bussines

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadComboBox()
            Loader = True
            SetQuyenTruyCap(, cmdSave, , )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_NhapDiemThiLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            mEdit = False
            Dim clsTCTDangKyThiCaiThien As New ToChucThiDangKyCaiThienDiem_Bussines
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim dv As DataView = grvDanhSachThi.DataSource
            Dim cls As New TochucThi_Bussines
            For i As Integer = 0 To dv.Count - 1
                Dim obj As New ESSToChucThiDangKyCaiThienDiem
                obj.ID_sv = dv.Item(i)("ID_sv")
                obj.Hoc_ky = Hoc_ky
                obj.Nam_hoc = Nam_hoc
                obj.ID_mon = ID_mon
                obj.Hinh_thuc = cmbLoaiDSThi.SelectedIndex
                obj.Duyet = IIf(dv.Item(i)("Chon"), 1, 0)
                obj.Ghi_chu = dv.Item(i)("Ghi_chu").ToString
                clsTCTDangKyThiCaiThien.CapNhat_ESSToChucThiDangKyCaiThienDiem(obj)
            Next
            Thongbao("Duyệt đăng ký thi cải thiện thành công", MsgBoxStyle.Information)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSachThi)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader AndAlso (cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "") Then
                Dim cls As New DanhMuc_Bussines
                Dim SQL As String = "SELECT Distinct a.ID_mon,  a.Ky_hieu + ' - '+ Ten_mon from  MARK_MonHoc a INNER join MARK_ToChucThiDangKyCaiThienDiem_TC b ON a.ID_mon=b.ID_mon WHERE Hoc_ky=" & cmbHoc_ky.Text & " AND Nam_hoc='" & cmbNam_hoc.Text & "'"
                Dim dt As DataTable = cls.DanhMuc_Load(SQL)
                FillCombo(cmbID_mon, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged, cmbLoaiDSThi.SelectedIndexChanged
        Try
            Try
                If Loader Then
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim Hinh_thuc As Integer = cmbLoaiDSThi.SelectedIndex
                    Dim cls As New TochucThi_Bussines
                    Dim dv As DataView = cls.HienThi_ESSDS_dangkyThiLai(ID_mon, Hoc_ky, Nam_hoc, Hinh_thuc).DefaultView
                    grcDanhSachThi.DataSource = dv
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Duyet") = chkAll.Checked
            Next
        End If
    End Sub

    Private Sub cmdPrint_DSThi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi.ItemClick
        Try
            Dim dv1 As DataView = grvDanhSachThi.DataSource
            Dim Tieu_de1 As String = ""

            If dv1.Count > 0 Then
                Dim dt As DataTable = dv1.Table.Copy
                dt.Columns.Add("Ten_mon", GetType(String))
                dt.Columns.Add("Ten_phong", GetType(String))
                dt.Columns.Add("Ngay_thi", GetType(String))
                dt.Columns.Add("Lan_thi", GetType(String))
                dt.Columns.Add("Ca_thi", GetType(String))
                dt.Columns.Add("Nhom_tiet", GetType(String))
                dt.Columns.Add("Gio_thi", GetType(String))
                dt.Columns.Add("Hinh_thuc_thi", GetType(String))
                dt.Columns.Add("So_sv")
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ten_mon") = cmbID_mon.Text
                    dt.Rows(i).Item("Ten_phong") = ""
                    dt.Rows(i).Item("Ngay_thi") = ""
                    dt.Rows(i).Item("Lan_thi") = "2"
                    dt.Rows(i).Item("Ca_thi") = ""
                    dt.Rows(i).Item("Nhom_tiet") = ""
                    dt.Rows(i).Item("Gio_thi") = ""
                    dt.Rows(i).Item("Hinh_thuc_thi") = "Viết"
                    dt.Rows(i).Item("So_sv") = dt.Rows.Count
                Next
                If cmbLoaiDSThi.SelectedIndex = 0 Then
                    Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI CẢI THIỆN HỌC PHẦN"
                ElseIf cmbLoaiDSThi.SelectedIndex = 1 Then
                    Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                End If

                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_Viet", dt.DefaultView, Tieu_de1)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DSThi2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi2.ItemClick
        Try
            Dim dv1 As DataView = grvDanhSachThi.DataSource
            Dim Tieu_de1 As String = ""

            If dv1.Count > 0 Then
                Dim dt As DataTable = dv1.Table.Copy
                dt.Columns.Add("Ten_mon", GetType(String))
                dt.Columns.Add("Ten_phong", GetType(String))
                dt.Columns.Add("Ngay_thi", GetType(String))
                dt.Columns.Add("Ca_thi", GetType(String))
                dt.Columns.Add("Nhom_tiet", GetType(String))
                dt.Columns.Add("Gio_thi", GetType(String))
                dt.Columns.Add("Hinh_thuc_thi", GetType(String))
                dt.Columns.Add("So_sv")
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ten_mon") = cmbID_mon.Text
                    dt.Rows(i).Item("Ten_phong") = ""
                    dt.Rows(i).Item("Ngay_thi") = ""
                    dt.Rows(i).Item("Ca_thi") = ""
                    dt.Rows(i).Item("Nhom_tiet") = ""
                    dt.Rows(i).Item("Gio_thi") = ""
                    dt.Rows(i).Item("Hinh_thuc_thi") = "Viết"
                    dt.Rows(i).Item("So_sv") = dt.Rows.Count
                Next

                If cmbLoaiDSThi.SelectedIndex = 0 Then
                    Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI CẢI THIỆN HỌC PHẦN"
                ElseIf cmbLoaiDSThi.SelectedIndex = 1 Then
                    Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                End If
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_VanDap", dt.DefaultView, Tieu_de1)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class