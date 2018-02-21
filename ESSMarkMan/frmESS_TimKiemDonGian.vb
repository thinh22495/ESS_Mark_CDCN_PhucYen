Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports DevExpress.XtraGrid.Views.Base
Public Class frmESS_TimKiemDonGian
    Private Loader As Boolean = False
#Region "Form Event"
    Private Sub frmESS_TimKiemDonGian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gobjUser.UserGroup = -1 Then
            btnEdit.Enabled = True
        Else
            btnEdit.Enabled = False
        End If
        Dim clsSearch As New TimKiemNangCao_Bussines
        Dim dt As DataTable
        dt = clsSearch.getFieldGroup(2)
        ' Xóa bổ một số nhóm trường hiển thị chưa cần thiết
        For i As Integer = dt.Rows.Count - 1 To 0 Step -1
            If dt.Rows(i)("FieldGroup") <> 201 And dt.Rows(i)("FieldGroup") <> 202 And dt.Rows(i)("FieldGroup") <> 203 And dt.Rows(i)("FieldGroup") <> 204 And dt.Rows(i)("FieldGroup") <> 205 Then
                dt.Rows(i).Delete()
            End If
        Next
        FillCombo(cmbID_hien_thi, dt)
        'Default nhóm hiển thị là Lý lịch sinh viên
        If cmbID_hien_thi.Items.Count >= 2 Then
            cmbID_hien_thi.SelectedIndex = 2
        End If
        Loader = True
    End Sub
    Private Sub frmESS_TimKiemDonGian_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_TimKiemDonGian_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim clsSearch As New TimKiemNangCao_Bussines
            'Add các điều kiện tìm kiếm
            If txtMa_sv.Text.Trim <> "" Then
                clsSearch.AddFieldSearch(clsSearch.getFieldSearchID("Ma_sv", "STU_HoSoSinhVien", 203), "=", "AND", txtMa_sv.Text.Trim, "")
            End If
            If txtSBD.Text.Trim <> "" Then
                clsSearch.AddFieldSearch(clsSearch.getFieldSearchID("SBD", "STU_HoSoSinhVien", 203), "=", "AND", txtSBD.Text.Trim, "")
            End If
            If txtHo_ten.Text.Trim <> "" Then
                clsSearch.AddFieldSearch(clsSearch.getFieldSearchID("Ho_ten", "STU_HoSoSinhVien", 203), "LIKE", "AND", txtHo_ten.Text.Trim, "")
            End If
            If txtNgay_sinh.Text.Trim <> "" Then
                clsSearch.AddFieldSearch(clsSearch.getFieldSearchID("Ngay_sinh", "STU_HoSoSinhVien", 203), "=", "AND", txtNgay_sinh.Text.Trim, "")
            End If
            If txtHo_khau_tt.Text.Trim <> "" Then
                clsSearch.AddFieldSearch(clsSearch.getFieldSearchID("Dia_chi", "STU_HoSoSinhVien", 203), "LIKE", "AND", txtHo_khau_tt.Text.Trim, "")
            End If
            'Add kết quả hiện thị
            clsSearch.AddFieldShow(cmbID_hien_thi.SelectedValue, gobjUser.UserID, gID_ph)
            ''Format kết quả trên DataGridView
            'Me.grViewKetQua.Columns.Clear()
            'For i As Integer = 0 To clsSearch.FieldShow.Count - 1
            '    Dim col As New DataGridViewTextBoxColumn
            '    With clsSearch.FieldShow.FieldShow(i)
            '        col.Name = .FieldID
            '        Dim arr() As String
            '        arr = .FieldID.Split(" ")
            '        If arr.Length > 1 Then
            '            col.DataPropertyName = arr(arr.Length - 1).ToString
            '        Else
            '            col.DataPropertyName = .FieldID
            '        End If
            '        col.HeaderText = .FieldName
            '        col.Width = .FieldSize * 40
            '        col.DefaultCellStyle.Alignment = .Align
            '        col.DefaultCellStyle.NullValue = ""
            '    End With
            '    Me.grViewKetQua.Columns.Add(col)
            'Next
            ''Hiển thị Kết quả tìm kiếm
            'Me.grViewKetQua.DataSource = clsSearch.KetQuaTimKiem(0, "").DefaultView
            'Me.lblSo_sv.Text = Me.grViewKetQua.DataSource.Count


            Dim view As ColumnView = CType(grcDanhSach.MainView, ColumnView)
            view.Columns.Clear()
            For i As Integer = 0 To clsSearch.FieldShow.Count - 1
                Dim coll As New DevExpress.XtraGrid.Columns.GridColumn

                With clsSearch.FieldShow.FieldShow(i)
                    coll.Name = .FieldID
                    Dim arr() As String
                    arr = .FieldID.Split(" ")
                    If arr.Length > 1 Then
                        coll.FieldName = arr(arr.Length - 1).ToString
                    Else
                        coll.FieldName = .FieldID
                    End If
                    coll.Caption = .FieldName
                    coll.Width = .FieldSize * 40
                    coll.OptionsColumn.ReadOnly = True
                    coll.Visible = True
                    coll.VisibleIndex = i
                End With
                view.Columns.Add(coll)
            Next

            grcDanhSach.DataSource = clsSearch.KetQuaTimKiem(0, "").DefaultView
            Me.lblSo_sv.Text = grvDanhSach.DataSource.Count
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        ' Danh sach ID_sv
        If grvDanhSach.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As New DataView
        dv = grvDanhSach.DataSource
        Dim arrID_sv As New ArrayList
        For i As Integer = 0 To dv.Count - 1
            arrID_sv.Add(dv.Item(i).Item("ID_sv"))
        Next

        Dim idx As Integer = grvDanhSach.FocusedRowHandle  'grvDanhSach.GetSelectedRows.GetValue(0)

        Dim ID_lops As String = gobjUser.dsID_lop
        Dim frmESS_ As New frmESS_HoSoSinhVien(arrID_sv, idx, ID_lops)
        frmESS_.MdiParent = frmESS_Main
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.Show()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frmESS_ As New frmESS_ChonTruongHienThi(cmbID_hien_thi.SelectedValue)
        frmESS_.ShowDialog()
    End Sub

    Private Sub cmdExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
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
#End Region
#Region "Change"
    Private Sub cmbID_hien_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_hien_thi.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            If cmbID_hien_thi.SelectedValue = gID_ph * 100 + 1 Then
                btnEdit.Enabled = True
            ElseIf gobjUser.UserGroup <> -1 Then
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Functions And Subs"
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra nhóm hiển thị
        If cmbID_hien_thi.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_hien_thi, ErrorProvider1, "Bạn hãy chọn nhóm hiển thị !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_hien_thi
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