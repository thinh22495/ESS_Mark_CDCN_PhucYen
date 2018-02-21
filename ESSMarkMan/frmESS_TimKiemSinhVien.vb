Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_TimKiemSinhVien
    Public pID_svs As String = "0"
    Public mMa_sv As String = ""
    Public HoatDongXH As Integer = 0
    Public objHoatDongXH As New ESSHoatDongXaHoi
    Private dvLop As DataView
    Private loader As Boolean = False
    Public mID_sv As Integer = 0

    Private Sub frmESS_SearchSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCombo()
        If HoatDongXH = 1 Then
            Me.cmdChon.Enabled = False
        End If
        Dim objLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
        dvLop = objLop.Danh_sach_lop_dang_hoc().DefaultView
        loader = True
    End Sub
    Private Sub frmESS_SearchSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Function CheckDate(ByVal strDate As Date) As Boolean
        If strDate.GetDateTimeFormats().ToString().Equals("MM/dd/yyyy") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub LoadCombo()
        Dim obj As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
        Dim dt As DataTable
        dt = obj.He_dao_tao()
        FillCombo(cmbID_he, dt)
        'dt = obj.Khoa()
        'FillCombo(cmbID_khoa, New DataView)
        'dt = obj.Khoa_hoc()
        'FillCombo(cmbKhoa_hoc, New DataView)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra 
        If cmbID_he.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbID_he.SelectedValue < 0 Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If


        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function



    Private Sub grdDanhSachSinhVien_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If HoatDongXH = 0 Then Exit Sub
            If loader = False Then Exit Sub
            Dim idx As Integer = grvDanhSachSV.FocusedRowHandle
            Dim dv As New DataView
            dv = grvDanhSachSV.DataSource
            If dv Is Nothing Then
                Exit Sub
            End If
            Tag = 1
            objHoatDongXH.ID_sv = dv.Item(idx).Item("ID_sv")
            objHoatDongXH.Ma_sv = dv.Item(idx).Item("Ma_sv")
            objHoatDongXH.Ho_ten = dv.Item(idx).Item("Ho_ten")
            objHoatDongXH.Ten_lop = dv.Item(idx).Item("Ten_lop")
            mMa_sv = dv.Item(idx).Item("Ma_sv").ToString
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.ToString)
        End Try
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Not loader Then Exit Sub
            Dim dvKhoa As New DataView
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
            dvKhoa = clsLop.Khoa().DefaultView
            Dim dk1 As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk1 += " and ID_he=" & cmbID_he.SelectedValue
            dvKhoa.RowFilter = dk1
            FillCombo(cmbID_khoa, dvKhoa)
            Dim cls As New DanhMuc_Bussines
            Dim dvKhoaHoc As DataView
            Dim sSQL As String = ""
            If cmbID_he.SelectedValue > 0 Then
                sSQL = "Select distinct Khoa_hoc,Khoa_hoc from  STU_Lop where ID_he = " & cmbID_he.SelectedValue
            Else
                sSQL = "Select distinct Khoa_hoc,Khoa_hoc from  STU_Lop"
            End If
            dvKhoaHoc = cls.LoadDanhMuc(sSQL).DefaultView
            FillCombo(cmbKhoa_hoc, dvKhoaHoc)
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbNganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbNganh.SelectedValue
            dvLop.RowFilter = dk
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Not loader Then Exit Sub
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            Dim dvCN As DataView
            dvCN = clsLop.Chuyen_nganh_dao_tao().DefaultView
            dvCN.RowFilter = dk
            FillCombo(cmbNganh, dvCN)
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbNganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbNganh.SelectedValue
            dvLop.RowFilter = dk
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Not loader Then Exit Sub
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbNganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbNganh.SelectedValue
            dvLop.RowFilter = dk
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbNganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNganh.SelectedIndexChanged
        Try
            If Not loader Then Exit Sub
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbNganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbNganh.SelectedValue
            dvLop.RowFilter = dk
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_SearchSinhVien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub cmbLop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLop.SelectedIndexChanged
        Try
            If Not loader Then Exit Sub
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbNganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbNganh.SelectedValue
            dvLop.RowFilter = dk
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If Not CheckInputData() Then Exit Sub
        loader = False
        Dim Ho_ten As String = ""
        Dim Ma_sv As String = ""
        Dim SBD As String = ""
        Dim Ngay_sinh As String = ""
        Ho_ten = txtHo_ten.Text
        Ma_sv = txtMa_sv.Text
        SBD = txtSo_BD.Text
        If dtpNgay_sinh.Checked Then Ngay_sinh = dtpNgay_sinh.Value

        ' Lọc ra các lớp theo điều kiện
        Dim dk As String = "1=1"
        If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
        If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
        If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
        If cmbNganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbNganh.SelectedValue
        dvLop.RowFilter = dk

        Dim dsID_lops As String = "0"
        For j As Integer = 0 To dvLop.Count - 1
            dsID_lops += "," & dvLop.Item(j).Item("ID_lop").ToString
        Next

        Dim obj As New DanhSachSinhVien_Bussines(dsID_lops)
        Dim dv As DataView = obj.Danh_sach_sinh_vien().DefaultView
        Dim dk1 As String = "1=1"
        If Ho_ten <> "" Then dk1 += " and Ho_ten like'%" & Ho_ten & "%'"
        If Ngay_sinh <> "" Then dk1 += " and Ngay_sinh ='" & Ngay_sinh & "'"
        If Ma_sv <> "" Then dk1 += " and Ma_sv like'%" & Ma_sv & "%'"
        If SBD <> "" Then dk1 += " and SBD like'%" & SBD & "%'"
        dv.RowFilter = dk1
        grcDanhSachSV.DataSource = dv
        labSoSv.Text = dv.Count
        loader = True
    End Sub

    Private Sub cmdChon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChon.Click
        Dim dv As New DataView
        dv = grvDanhSachSV.DataSource
        If dv Is Nothing Then
            Exit Sub
        End If
        Tag = 1

        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i).Item("Chon") Then
                pID_svs += "," & dv.Item(i).Item("ID_sv")
                mID_sv = dv.Item(i).Item("ID_sv")
                mMa_sv = dv.Item(i).Item("Ma_sv")
            End If
        Next
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Tag = 0
        Me.Close()
    End Sub
End Class