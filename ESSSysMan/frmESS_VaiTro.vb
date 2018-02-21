Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Public Class frmESS_VaiTro
    Public tag1 As Integer
    Public ID_Vai_tro As Integer
    Public idx_vaitro As Integer
    Public Ten_Vai_tro As String
    Public Mo_ta As String
    Public dtVaitro As DataTable
    Private aVai_tro As New ESSVaiTro, cls As New VaiTro_Bussines(gobjUser.UserID)

#Region "Form Load"
    Private Sub frmESS_VaiTro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Tag = 1 Then
            txtTen_vai_tro.Text = Ten_Vai_tro
            txtMo_ta.Text = Mo_ta
        End If
    End Sub
    Private Sub frmESS_VaiTro_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "ConTrol Event"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Tag = 1 Then '' Tag=1 là để sửa
                gobjUser.ESSVaiTro.ESSVaiTro(idx_vaitro).ID_vai_tro = ID_Vai_tro
                gobjUser.ESSVaiTro.ESSVaiTro(idx_vaitro).Ten_vai_tro = txtTen_vai_tro.Text
                gobjUser.ESSVaiTro.ESSVaiTro(idx_vaitro).Mo_ta = txtMo_ta.Text
                'aVai_tro.ID_vai_tro = ID_Vai_tro
                'aVai_tro.Ten_vai_tro = txtTen_vai_tro.Text
                'aVai_tro.Mo_ta = txtMo_ta.Text
                If KiemTra_values() = False Then Exit Sub
                cls.CapNhat_ESSVaiTro(gobjUser.ESSVaiTro.ESSVaiTro(idx_vaitro), ID_Vai_tro)
                Thongbao(" Da cập nhật thanh cong", MsgBoxStyle.OkOnly)
            ElseIf Tag = 0 Then '' Tag=0 là để thêm mới
                'aVai_tro.ID_vai_tro = 1
                aVai_tro.Ten_vai_tro = txtTen_vai_tro.Text
                aVai_tro.Mo_ta = txtMo_ta.Text
                If KiemTra_values() = False Then Exit Sub
                Dim ID As Integer = cls.ThemMoi_ESSVaiTro(aVai_tro)
                aVai_tro.ID_vai_tro = ID
                cls.ThemMoi_ESSUsersVaiTro(gobjUser.UserID, ID)
                gobjUser.ESSVaiTro.Add(aVai_tro)
                Thongbao(" Da Them Moi thanh cong", MsgBoxStyle.OkOnly)
            End If
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region

#Region "User Functions"
    Public Function KiemTra_values() As Boolean '' Hàm kiểm tra các lỗi
        If Me.txtTen_vai_tro.Text = "" Then
            Thongbao("Bạn phải nhập đủ thông tin chỗ đáng đấu đỏ", MsgBoxStyle.Information, "Thông Báo")
            Return False
        End If
        If KiemTra_VaiTro(Me.txtTen_vai_tro.Text) Then
            Thongbao("Vai tro này đã có rôi", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
    Public Function KiemTra_VaiTro(ByVal Ten_VaiTro As String) As Boolean '' Hàm kiểm tra xem vai trò đó đã  tồn tại chưa?
        For i As Integer = 0 To dtVaitro.Rows.Count - 1
            Dim strTenVaiTro As String = CStr(dtVaitro.Rows(i)("Ten_vai_tro"))
            If Ten_VaiTro.Trim.ToUpper = strTenVaiTro.Trim.ToUpper And ID_Vai_tro <> dtVaitro.Rows(i)("ID_vai_tro") Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region
End Class