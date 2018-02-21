Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSConnect
Public Class frmSua_Nganh2
    Private clsNganh2 As DanhSachNganh2_Bussines
    Private mID_he As Integer = 0
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0

    Public Overloads Sub ShowDialog(ByVal ID_he As Integer, ByVal ID_SV As Integer)
        mID_he = ID_he
        mID_sv = ID_SV
        Me.ShowDialog()
    End Sub
    Private Sub frmSua_Nganh2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsDanhMuc As New DanhMuc_Bussines
        Dim dt As DataTable = clsDanhMuc.LoadDanhMuc("SELECT DISTINCT Khoa_hoc,Khoa_hoc AS KhoaHoc from  STU_Lop ORDER BY Khoa_hoc")
        FillCombo(cmbKhoa_hoc, dt, "Khoa_hoc", "Khoa_hoc")
        Loader = True
    End Sub

    Private Sub frmSua_Nganh2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If cmbKhoa_hoc.Text = "" Or cmbID_chuyen_nganh.Text = "" Then
                Thongbao("Hãy chọn Khóa học, Chuyên ngành theo ngành 2!")
                Exit Sub
            End If
            clsNganh2 = New DanhSachNganh2_Bussines
            Dim mID_dt2 As Integer = clsNganh2.Get_CTDT(cmbID_chuyen_nganh.SelectedValue, CType(cmbKhoa_hoc.Text, Integer), mID_he)
            If mID_dt2 > 0 Then
                Dim clsDanhMuc As New DanhMuc_Bussines
                Dim dt_Nganh2 As DataTable = clsDanhMuc.LoadDanhMuc("SELECT ID_dt FROM STU_DANHSACHNGANH2 WHERE ID_SV=" & mID_sv)
                If dt_Nganh2.Rows.Count > 0 Then
                    clsDanhMuc.Execute("UPDATE Mark_Diem_TC SET ID_dt=" & mID_dt2 & " WHERE ID_SV=" & mID_sv & " AND ID_dt =" & dt_Nganh2.Rows(0)("ID_dt"))
                    clsDanhMuc.Execute("UPDATE STU_DANHSACHNGANH2 SET ID_dt=" & mID_dt2 & ",Khoa_hoc=" & cmbKhoa_hoc.Text & ",ID_lop=" & cmbID_lop.SelectedValue & " WHERE ID_SV=" & mID_sv)
                End If
            End If
            Thongbao("Cập nhật thành công !")
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader Then
                If cmbKhoa_hoc.Text.Trim = "" Then Exit Sub
                Dim clsDanhMuc As New DanhMuc_Bussines
                Dim dt As DataTable = clsDanhMuc.LoadDanhMuc("SELECT DISTINCT a.ID_chuyen_nganh,Chuyen_nganh from  STU_CHUYENNGANH a INNER JOIN STU_LOP b ON a.ID_chuyen_nganh=b.ID_chuyen_nganh WHERE ID_he=" & mID_he & " AND Khoa_hoc=" & cmbKhoa_hoc.Text & " ORDER BY Chuyen_nganh")
                FillCombo(cmbID_chuyen_nganh, dt, "ID_chuyen_nganh", "Chuyen_nganh")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If Loader Then
                If cmbKhoa_hoc.Text.Trim = "" Or cmbID_chuyen_nganh.Text = "" Then Exit Sub
                Dim clsDanhMuc As New DanhMuc_Bussines
                Dim dt As DataTable = clsDanhMuc.LoadDanhMuc("SELECT DISTINCT ID_lop,Ten_lop from  STU_LOP WHERE ID_he=" & mID_he & " AND Khoa_hoc=" & cmbKhoa_hoc.Text & " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue & " ORDER BY Ten_lop")
                FillCombo(cmbID_lop, dt, "ID_lop", "Ten_lop")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class