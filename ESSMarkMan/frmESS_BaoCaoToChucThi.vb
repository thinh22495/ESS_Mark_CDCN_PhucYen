Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BaoCaoToChucThi
    Private cls As New TochucThi_Bussines

    Private Sub menuPrintPhongThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPrintPhongThi.Click
        If cmbHoc_ky.Text = "" Or cmbNam_hoc.Text = "" Or (cmbID_khoa.Text = "" And cmbID_nganh.Text = "") Then
            Thongbao("Hãy chọn các thông tin cần view báo cáo !", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim Ten_khoa As String = "Tên khoa: " & cmbID_khoa.Text
        If cmbID_nganh.Text <> "" Then Ten_khoa = Ten_khoa & " , Ngành: " & cmbID_nganh.Text
        Try
            Dim dt As DataTable = cls.HienThi_ESSDanhsachTheoPhong_Main(cmbID_khoa.SelectedValue, cmbID_nganh.SelectedValue, cmbHoc_ky.Text, cmbNam_hoc.Text, Ten_khoa)
            If Not dt Is Nothing Then
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog_RFix("DANHSACHTHI_MONPHONG", dt)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmESS_BaoCaoToChucThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dt_dm As DataTable
            Dim cls As New DanhMuc_Bussines
            dt_dm = cls.DanhMuc_Load("STU_Nganh", "ID_nganh", "Ten_Nganh")
            FillCombo(cmbID_nganh, dt_dm)
            dt_dm = cls.DanhMuc_Load("STU_Khoa", "ID_khoa", "Ten_khoa")
            FillCombo(cmbID_khoa, dt_dm)

            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmESS_BaoCaoToChucThi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub menuPrintDotThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPrintDotThi.Click
        If cmbHoc_ky.Text = "" Or cmbNam_hoc.Text = "" Then
            Thongbao("Hãy chọn Học kỳ, Năm học cần view báo cáo !", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dt As DataTable = cls.HienThi_ESSThongKeTheoPhong(cmbHoc_ky.Text, cmbNam_hoc.Text)
            If Not dt Is Nothing Then
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog_RFix("DANHSACHTHI_THONGKEPHONG", dt)
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class