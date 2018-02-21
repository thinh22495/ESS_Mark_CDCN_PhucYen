Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_DoiTuongGiayTo
    Private Loader As Boolean = False
    Private Edit As Boolean = False
    Private mMa_dt As String = ""
    Private Sub frmESS_DoiTuongGiayTo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewDoiTuongHB)
        SetUpDataGridView(grdViewDoiTuongGT)
        SetQuyenTruyCap(, cmdAdd, , cmdDelete)
        ' Fill com bo
        Fill_Combo()
        ' Load danh sách đối tượng 
        Dim dv As DataView
        If optDoiTuong_hb.Checked Then ' đối tượng học bổng
            Dim obj_Bussines As New LoaiHocBong_Bussines()
            dv = obj_Bussines.HienThi_ESSDoiTuongHocBong().DefaultView
        Else ' Đối tượng chính sách
            Dim dt As New DataTable
            dt.Columns.Add("Ma_dt_hb")
            dt.Columns.Add("Ten_dt_hb")
            Dim cls As New DanhMuc_Bussines
            dt = cls.DanhMuc_Load("STU_DoiTuong", "Ma_dt", "Ten_dt")
            Dim dr As DataRow
            For Each r As DataRow In dt.Rows
                dr = dt.NewRow
                dr("Ma_dt_hb") = r("Ma_dt").ToString
                dr("Ten_dt_hb") = r("Ten_dt").ToString
                dt.Rows.Add(dr)
            Next
            dv = dt.DefaultView
        End If
        grdViewDoiTuongHB.DataSource = dv
        Loader = True
    End Sub
    Private Sub frmESS_DoiTuongGiayTo_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#Region "Button"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If Not CheckInputData() Then Exit Sub
            If mMa_dt = "" Then Exit Sub
            Dim cls As New LoaiGiayTo_Bussines
            If Not cls.KiemTra_DoiTuongGiayTo(mMa_dt, cmbID_loai_giay_to.SelectedValue) Then
                cls.ThemMoi_ESSDoiTuongGiayTo(mMa_dt, cmbID_loai_giay_to.SelectedValue)
            End If
            Dim dv As New DataView
            dv = grdViewDoiTuongGT.DataSource
            HienThi_ESSData()
            Thongbao("Bạn đã thêm thành công giấy tờ cần nộp !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Thongbao("Bạn có muốn xóa giấy tờ liên quan không !", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim dv As New DataView
            dv = grdViewDoiTuongGT.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim idx As Integer = 0
            idx = grdViewDoiTuongGT.CurrentRow.Index
            Dim cls As New LoaiGiayTo_Bussines
            cls.Xoa_ESSDoiTuongGiayTo(dv.Item(idx)("Ma_dt"), dv.Item(idx)("ID_giay_to"))
            dv.Item(idx).Delete()
            grdViewDoiTuongGT.DataSource = dv
            Thongbao("Bạn đã xóa thành công loại giấy tờ liên quan !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Try
            Dim cls As New DanhMuc_Bussines
            Dim dt As DataTable
            dt = cls.DanhMuc_Load("STU_LoaiGiayTo", "ID_giay_to", "Ten_giay_to")
            FillCombo(cmbID_loai_giay_to, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        ' Kiểm tra         
        If cmbID_loai_giay_to.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_loai_giay_to, ErrorProvider1, "Bạn hãy chọn loại giấy tờ cần nộp !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_loai_giay_to
        End If
        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub HienThi_ESSData()
        Try
            Dim cls As New LoaiGiayTo_Bussines()
            Dim dv As New DataView
            dv = grdViewDoiTuongHB.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim idx As Integer = 0
            idx = grdViewDoiTuongHB.CurrentRow.Index
            mMa_dt = dv.Item(idx)("Ma_dt_hb")
            Dim dv1 As New DataView
            dv1 = cls.DoiTuong_GiayTo(mMa_dt).DefaultView
            grdViewDoiTuongGT.DataSource = dv1
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Change"
    Private Sub grdViewDoiTuongHB__CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewDoiTuongHB.CurrentCellChanged
        If Not Loader Then Exit Sub
        HienThi_ESSData()
    End Sub
    Private Sub optDoiTuong_hb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDoiTuong_hb.CheckedChanged, optDoiTuong_CS.CheckedChanged
        Try
            If Not Loader Then Exit Sub
            ' Load danh sách đối tượng 
            Dim dv As DataView
            If optDoiTuong_hb.Checked Then
                Dim obj_Bussines As New LoaiHocBong_Bussines()
                dv = obj_Bussines.HienThi_ESSDoiTuongHocBong().DefaultView
            Else
                Dim dt As New DataTable
                dt.Columns.Add("Ma_dt_hb")
                dt.Columns.Add("Ten_dt_hb")
                Dim cls As New DanhMuc_Bussines
                Dim dtDT As DataTable
                dtDT = cls.DanhMuc_Load("STU_DoiTuong", "Ma_dt", "Ten_dt")
                Dim dr As DataRow
                For Each r As DataRow In dtDT.Rows
                    dr = dt.NewRow
                    dr("Ma_dt_hb") = r("Ma_dt").ToString
                    dr("Ten_dt_hb") = r("Ten_dt").ToString
                    dt.Rows.Add(dr)
                Next
                dv = dt.DefaultView
            End If
            grdViewDoiTuongHB.DataSource = dv
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class