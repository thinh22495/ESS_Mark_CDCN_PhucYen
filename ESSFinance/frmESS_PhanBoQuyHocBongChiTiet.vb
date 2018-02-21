Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_PhanBoQuyHocBongChiTiet
    Private mQuy_hb As New ESSQuyHocBong
    Dim idx As Integer = 0
    Dim Loader = False
    Public Sub New(ByVal Quy_hb As ESSQuyHocBong)
        mQuy_hb = Quy_hb
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmESS_PhanBoQuyHocBongChiTiet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clock_Control(False)
        SetUpDataGridView(grdViewPhanBo)
        HienThi_ESSdata()
        SetQuyenTruyCap(cmdSave, , cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_PhanBoQuyHocBongThuCong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub grdViewPhanBo_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewPhanBo.CurrentCellChanged
        Try
            'If Not Loader Then Exit Sub
            Dim dv As New DataView
            dv = grdViewPhanBo.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim idx As Integer = 0
            idx = grdViewPhanBo.CurrentRow.Index
            txtSo_sv.Text = dv.Item(idx)("So_sv")
            txtTen_phan_bo.Text = dv.Item(idx)("Ten_phan_bo")
            txtSo_tien_da_phan.Text = dv.Item(idx)("So_tien")
            ' Số tiền đã cấp
            Dim SoTien_DaCap As Double = 0
            For i As Integer = 0 To dv.Count - 1
                SoTien_DaCap += dv.Item(i)("So_tien")
            Next
            ' Số tiền còn lại
            txtSo_tien_con_lai.Text = Format((mQuy_hb.Sotien_ngansach + mQuy_hb.Sotien_khac) - SoTien_DaCap, "###,##0")
            txtSo_tien_toi_da.Text = Format(CDbl(txtSo_tien_con_lai.Text) + CDbl(txtSo_tien_da_phan.Text), "###,##0")
        Catch ex As Exception
            'Thongbao(ex.Message)
        End Try
    End Sub
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dv As New DataView
            dv = grdViewPhanBo.DataSource
            If dv.Count = 0 Then Exit Sub
            If Not CheckInputData() Then Exit Sub
            Dim obj_Bussines As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
            Dim obj As New ESSQuyHocBongPhanBo
            obj.ID_hb = dv.Item(idx)("ID_hb")
            obj.ID_phan_bo = dv.Item(idx)("ID_phan_bo")
            obj.Phan_dac_biet = dv.Item(idx)("Phan_dac_biet")
            obj.So_sv = txtSo_sv.Text
            obj.So_tien = txtSo_tien_da_phan.Text
            obj.Ten_phan_bo = txtTen_phan_bo.Text
            obj_Bussines.CapNhat_ESSQuyHocBongPhanBo(obj, obj.ID_phan_bo)
            ' Cập nhật lại danh sách trên dv
            dv.Item(idx)("So_sv") = txtSo_sv.Text
            dv.Item(idx)("So_tien") = Format(CDbl(txtSo_tien_da_phan.Text), "###,##0")
            dv.Item(idx)("Ten_phan_bo") = txtTen_phan_bo.Text
            Thongbao("Bạn đã cập nhật thành công !")
            ' Cập nhật lại số tiền
            txtSo_tien_con_lai.Text = Format(CDbl(txtSo_tien_toi_da.Text) - CDbl(txtSo_tien_da_phan.Text), "###,##0")
            txtSo_tien_toi_da.Text = Format(CDbl(txtSo_tien_con_lai.Text) + CDbl(txtSo_tien_da_phan.Text), "###,##0")
            Clock_Control(False)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Clock_Control(True)
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Clock_Control(False)
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            Dim dv As New DataView
            dv = grdViewPhanBo.DataSource
            If dv.Count = 0 Then Exit Sub
            If Thongbao("Bạn có muốn xóa phân bổ hiện chọn trên danh sách không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            idx = grdViewPhanBo.CurrentRow.Index
            Dim obj_Bussines As New QuyHocBongPhanBo_Bussines()
            obj_Bussines.Xoa_ESSQuyHocBongPhanBo(dv.Item(idx)("ID_phan_bo")) ' xóa quỹ học bổng phân bổ trên database
            obj_Bussines.Xoa_ESSQuyHocBongPhanBoLop(dv.Item(idx)("ID_phan_bo")) ' xóa quỹ học bổng phân bổ lớp trên database            
            txtSo_tien_con_lai.Text = Format(CDbl(txtSo_tien_con_lai.Text) + CDbl(dv.Item(idx)("So_tien")), "###,##0")
            txtSo_tien_toi_da.Text = Format(CDbl(txtSo_tien_con_lai.Text) + CDbl(txtSo_tien_da_phan.Text), "###,##0")
            dv.Item(idx).Delete() ' Xóa trên danh sách        
            dv.Table.AcceptChanges()
            grdViewPhanBo.DataSource = dv
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Functions And Subs"
    Public Sub HienThi_ESSdata()
        Dim obj As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
        Dim dt As DataTable
        dt = obj.DanhSach_QuyHocBongPhanBo()
        grdViewPhanBo.DataSource = dt.DefaultView
    End Sub
    Private Sub Clock_Control(ByVal Status As Boolean)
        cmdSave.Visible = Status
        cmdEdit.Visible = Not Status
        txtSo_sv.Enabled = Status
        txtSo_tien_da_phan.Enabled = Status
        txtTen_phan_bo.Enabled = Status
        cmdCancel.Visible = Status
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra đối tượng phân bổ
        If txtTen_phan_bo.Text = "" Then
            Call SetErrPro(txtTen_phan_bo, ErrorProvider1, "Bạn hãy nhập tên đối tượng phân bổ !")
            If CtrlErr Is Nothing Then CtrlErr = txtTen_phan_bo
        End If
        ' Kiểm tra Số tiền phân bổ
        If txtSo_tien_da_phan.Text = "" Then
            Call SetErrPro(txtSo_tien_da_phan, ErrorProvider1, "Bạn hãy nhập tên đối tượng phân bổ !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien_da_phan
        ElseIf Not IsNumeric(txtSo_tien_da_phan.Text) Then
            Call SetErrPro(txtSo_tien_da_phan, ErrorProvider1, "Bạn hãy nhập số tiền phân bổ ở dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien_da_phan
        ElseIf CDbl(txtSo_tien_da_phan.Text) > CDbl(txtSo_tien_toi_da.Text) Then
            Call SetErrPro(txtSo_tien_da_phan, ErrorProvider1, "Số tiền phân bổ lớn hơn số tiền tối đa có thể phân bổ !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien_da_phan
        End If
        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
#End Region
End Class