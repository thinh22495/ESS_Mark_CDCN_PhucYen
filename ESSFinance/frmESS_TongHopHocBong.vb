Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_TongHopHocBong
    Private Loader As Boolean = False
    Private Sub frmESS_LapDanhSachThuKhac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        Loader = True
    End Sub
    Private Sub frmESS_LapDanhSachThuKhac_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_LapDanhSachThuKhac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#Region "Button"
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim dt As DataTable
            Dim cls As New TongHopThongKe_Bussines
            Dim ID_lop As Integer = 0
            If Not cmbID_lop.SelectedValue Is Nothing Then ID_lop = cmbID_lop.SelectedValue
            dt = cls.TongHop_DSSV_HocBong(cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, ID_lop, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            Dim frmESS_ As New frmESS_ReportView
            Dim Tieu_de1 As String = "BẢNG CHI TIẾT CHI HỌC BỔNG"
            Dim Tieu_de2 As String = ""
            If cmbID_lop.SelectedValue > 0 Then
                Tieu_de2 = "LỚP : K" & cmbKhoa_hoc.Text & "/" & cmbID_lop.Text
            Else
                Tieu_de2 = "KHÓA : " & cmbKhoa_hoc.Text
            End If
            Dim Tieu_de3 As String = "KHOA : " & cmbID_khoa.Text
            Dim Tieu_de4 As String = "Học kỳ : " & cmbHoc_ky.SelectedValue + 1 & ",năm học : " & cmbNam_hoc.Text
            frmESS_.ShowDialog("RpBangChiTietHocBong", dt, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrintTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintTH.Click
        Try
            If Not CheckInputData1() Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim dt As DataTable
            Dim cls As New TongHopThongKe_Bussines
            Dim ID_lop As Integer = 0
            If Not cmbID_lop.SelectedValue Is Nothing Then ID_lop = cmbID_lop.SelectedValue
            dt = cls.TongHop_HocBong_ToanKhoa(cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, 0, ID_lop, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            Dim frmESS_ As New frmESS_ReportView
            Dim Tieu_de1 As String = "BẢNG TỔNG HỢP CHI HỌC BỔNG"
            Dim Tieu_de2 As String = ""
            If cmbID_lop.SelectedValue > 0 Then
                Tieu_de2 = "LỚP : K" & cmbKhoa_hoc.Text & "/" & cmbID_lop.Text
            Else
                Tieu_de2 = "KHÓA : " & cmbKhoa_hoc.Text
            End If
            Dim Tieu_de3 As String = "KHOA : Toàn bộ "
            Dim Tieu_de4 As String = "Học kỳ : " & cmbHoc_ky.SelectedValue + 1 & ",năm học : " & cmbNam_hoc.Text
            frmESS_.ShowDialog("RpBangTongHopChiHocBong", dt, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)

        Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        Dim dt As New DataTable
        'Load combobox Hệ đào tạo
        dt = clsLop.He_dao_tao()
        FillCombo(cmbID_he, dt)

        'Load combobox khoá đào tạo
        dt = clsLop.Khoa_hoc()
        FillCombo(cmbKhoa_hoc, dt)

        'Load combobox khoá đào tạo
        dt = clsLop.Khoa()
        FillCombo(cmbID_khoa, dt)
    End Sub
    Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrPro Is Nothing Then ErrPro.Dispose()

        ' Kiểm tra 
        If cmbHoc_ky.SelectedValue Is Nothing Then
            Call SetErrPro(cmbHoc_ky, ErrPro, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        ' Kiểm tra 
        If cmbNam_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbNam_hoc, ErrPro, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        ' Kiểm tra 
        If cmbID_he.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_he, ErrPro, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbHoc_ky.SelectedValue Is Nothing Then
            Call SetErrPro(cmbHoc_ky, ErrPro, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbNam_hoc, ErrPro, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If cmbKhoa_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbKhoa_hoc, ErrPro, "Bạn hãy chọn khóa học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbKhoa_hoc
        End If
        If cmbID_khoa.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_khoa, ErrPro, "Bạn hãy chọn khoa !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_khoa
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function

    Function CheckInputData1() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrPro Is Nothing Then ErrPro.Dispose()

        ' Kiểm tra 
        If cmbHoc_ky.SelectedValue Is Nothing Then
            Call SetErrPro(cmbHoc_ky, ErrPro, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        ' Kiểm tra 
        If cmbNam_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbNam_hoc, ErrPro, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        ' Kiểm tra 
        If cmbID_he.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_he, ErrPro, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbHoc_ky.SelectedValue Is Nothing Then
            Call SetErrPro(cmbHoc_ky, ErrPro, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbNam_hoc, ErrPro, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If cmbKhoa_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbKhoa_hoc, ErrPro, "Bạn hãy chọn khóa học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbKhoa_hoc
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData1 = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData1 = False
        CtrlErr.Focus()
    End Function
#End Region

    Private Sub cmdTong_hop_HB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTong_hop_HB.Click
        Try
            If cmbHoc_ky.SelectedValue < 0 Then
                Thongbao("Bạn phải chọn học kỳ !")
                Exit Sub
            End If
            If cmbNam_hoc.SelectedValue < 0 Then
                Thongbao("Bạn phải chọn Năm học !")
                Exit Sub
            End If
            If cmbKhoa_hoc.SelectedValue < 0 Then
                Thongbao("Bạn phải chọn Khóa học !")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim dt As DataTable
            Dim cls As New TongHopThongKe_Bussines
            dt = cls.TongHop_HocBong(cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            Dim frmESS_ As New frmESS_ReportView
            Dim Tieu_de1 As String = "BẢNG TỔNG HỢP HỌC BỔNG TOÀN HỌC VIỆN KHÓA : " & cmbKhoa_hoc.SelectedValue
            Dim Tieu_de2 As String = "( Học kỳ : " & cmbHoc_ky.SelectedValue + 1 & " năm học : " & cmbNam_hoc.Text & " )"
            frmESS_.ShowDialog("RpTongHopHocBongKhoa", dt, Tieu_de1, Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            ' Load combo lop
            Dim dvLop As DataView
            Dim cls As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dvLop = cls.Danh_sach_lop_dang_hoc().DefaultView
            Dim dk As String = "1=1 "
            If Not cmbID_khoa.SelectedValue Is Nothing Then dk += " And ID_khoa=" & cmbID_khoa.SelectedValue
            If Not cmbKhoa_hoc.SelectedValue Is Nothing Then dk += " And Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            dvLop.RowFilter = dk
            dvLop.Sort = "Ten_lop"
            Dim dt1 As New DataTable
            dt1.Columns.Add("ID_lop")
            dt1.Columns.Add("Ten_lop")
            Dim r As DataRow
            For i As Integer = 0 To dvLop.Count - 1
                r = dt1.NewRow
                r("ID_lop") = dvLop.Item(i)("ID_lop")
                r("Ten_lop") = dvLop.Item(i)("Ten_lop")
                dt1.Rows.Add(r)
            Next
            FillCombo(cmbID_lop, dt1)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class