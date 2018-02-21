Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_NhapDiemTu_Excel
    Dim Loader As Boolean = False
    Dim xlsFileName As String = ""
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private clsDiem As New Diem_Bussines
    Dim dt As DataTable

#Region "Form Events"

    Private Sub frmESS_NhapDiemExcel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_NhapDiemExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)

        Dim clsDM As New DanhMuc_Bussines
        Dim dt_dm As New DataTable
        dt_dm = clsDM.LoadDanhMuc("SELECT DISTINCT Khoa_hoc,Khoa_hoc from  STU_Lop where Tinh_chat=0")
        FillCombo(cmbKhoa_hoc, dt_dm)
        dt_dm = clsDM.LoadDanhMuc("SELECT DISTINCT ID_thanh_phan,Ten_thanh_phan from  MARK_ThanhPhanMon_TC")
        FillCombo(cmbThanh_phan, dt_dm)

        clsCTDT = New ChuongTrinhDaoTao_Bussines(gobjUser.dsID_dt)
        dt = clsCTDT.DanhSachChuongTrinhDaoTao

        Call getFont(cmbFont)

        SetQuyenTruyCap(, cmdSave, , )
        Loader = True
    End Sub

    Private Sub frmESS_NhapDiemExcel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"

#End Region

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        With dlgOpenFile
            .InitialDirectory = Application.StartupPath
            .Filter = "Tệp Excel|*.xls"
            .FilterIndex = 1
        End With
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            xlsFileName = dlgOpenFile.FileName
            Dim xlsFile As String = xlsFileName.Trim.ToLower.Substring(xlsFileName.Trim.Length - 3, 3)
            If xlsFile = "xls" Then
                Loader = False
                Try
                    cmbChonFile.Items.Clear()
                    Dim conADO As New ADODB.Connection
                    Dim myrs As New ADODB.Recordset
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    myrs = conADO.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
                    While Not myrs.EOF
                        If myrs.Fields("TABLE_NAME").Value.ToString.Length > 0 Then
                            If myrs.Fields("TABLE_NAME").Value.ToString.Substring(myrs.Fields("TABLE_NAME").Value.ToString.Length - 1, 1) = "$" Then
                                cmbChonFile.Items.Add(myrs.Fields("TABLE_NAME").Value)
                            End If
                        End If
                        myrs.MoveNext()
                    End While
                    myrs.Close()
                    Loader = True
                    If cmbChonFile.Items.Count > 0 Then
                        cmbChonFile.SelectedIndex = 0
                    End If
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmbChonFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChonFile.SelectedIndexChanged
        If Not Loader Then Exit Sub
        If cmbChonFile.SelectedIndex >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            If xlsFileName.Trim <> "" Then
                Try
                    Loader = False
                    grdViewDiem.DataSource = Nothing
                    cmbCot_ma.Items.Clear()
                    cmbCot_diem.Items.Clear()
                    Dim oleCnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & cmbChonFile.Text & "]", oleCnn)
                    Dim dt As New DataTable
                    Dim i As Integer

                    da.Fill(dt)
                    grdViewDiem.DataSource = dt
                    If dt.Columns.Count > 0 Then
                        For i = 0 To dt.Columns.Count - 1
                            cmbCot_ma.Items.Add(dt.Columns(i).ColumnName)
                            cmbCot_diem.Items.Add(dt.Columns(i).ColumnName)
                            dt.Columns(i).ReadOnly = False
                        Next
                    End If
                    Loader = True
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader AndAlso cmbKhoa_hoc.Text.Trim <> "" Then
                Dim clsDM As New DanhMuc_Bussines
                Dim dt_dm As New DataTable
                dt_dm = clsDM.LoadDanhMuc("SELECT DISTINCT a.ID_chuyen_nganh,Chuyen_nganh from  STU_ChuyenNganh a INNER join STU_Lop b ON a.ID_chuyen_nganh=b.ID_chuyen_nganh WHERE Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                FillCombo(cmbID_chuyen_nganh, dt_dm)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        If Loader AndAlso cmbID_chuyen_nganh.Text.Trim <> "" Then
            Dim clsDM As New DanhMuc_Bussines
            Dim dt_dm As New DataTable
            dt_dm = clsDM.LoadDanhMuc("SELECT DISTINCT ID_lop,Ten_lop from  STU_Lop WHERE ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue)
            FillCombo(cmbID_lop, dt_dm)
        End If
    End Sub

    Private Sub cmbID_lop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_lop.SelectedIndexChanged
        Try
            If Loader Then
                dt.DefaultView.RowFilter = "1=1"
                If cmbKhoa_hoc.SelectedValue > 0 Then dt.DefaultView.RowFilter += " AND Khoa_hoc=" + cmbKhoa_hoc.SelectedValue.ToString
                If cmbID_chuyen_nganh.SelectedValue > 0 Then dt.DefaultView.RowFilter += " AND ID_chuyen_nganh=" + cmbID_chuyen_nganh.SelectedValue.ToString
                If dt.DefaultView.Count > 0 Then
                    clsCTDT.HienThi_ESSCTDTChiTiet(dt.DefaultView.Item(0)("ID_dt"))
                    Dim dt_CTrDT_ChiTiet As DataTable = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(dt.DefaultView.Item(0)("ID_dt"))
                    Dim dt_mon As New DataTable
                    dt_mon.Columns.Add("ID_mon", GetType(Integer))
                    dt_mon.Columns.Add("Ten_mon", GetType(String))

                    For i As Integer = 0 To dt_CTrDT_ChiTiet.Rows.Count - 1
                        Dim row As DataRow = dt_mon.NewRow()
                        row("ID_mon") = dt_CTrDT_ChiTiet.Rows(i).Item("ID_mon")
                        row("Ten_mon") = dt_CTrDT_ChiTiet.Rows(i).Item("Ten_mon").ToString
                        dt_mon.Rows.Add(row)
                    Next
                    dt_mon.AcceptChanges()
                    FillCombo(cmbID_mon, dt_mon)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdFontFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFontFile.Click
        If cmbFont.Text <> "" Then
            If Not grdViewDiem.DataSource Is Nothing Then
                Me.Cursor = Cursors.WaitCursor
                Call Convert_font(cmbFont.Text, grdViewDiem.DataSource)
                cmdFontFile.Enabled = False
                Me.Cursor = Cursors.Default
            Else
                Thongbao("Không có dữ liệu để chuyển đổi, bạn hãy mở file dữ liệu để chuyển đổi ")
            End If
        Else
            Thongbao("Bạn hãy chọn font chữ của file dữ liệu nguồn !")
            cmbFont.Focus()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not Check_valid() Then Exit Sub
            Dim dtDiem_TonTai, dtDiem_MoiTonTai, dtDiem_Sai, dtDiem_MoiChuan As DataTable
            Me.Cursor = Cursors.WaitCursor

            clsDiem.CapNhat_ESSdata(grdViewDiem.DataSource, gobjUser.ID_dv, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thi.Text, cmbID_mon.SelectedValue, _
                                  cmbCot_ma.Text, cmbCot_diem.Text, dtDiem_TonTai, dtDiem_MoiTonTai, dtDiem_Sai, dtDiem_MoiChuan, _
                                  IIf(cmbThanh_phan.SelectedIndex < 0, 0, cmbThanh_phan.SelectedValue), IIf(txtTy_le.Text.Trim = "", 0, txtTy_le.Text))
            Dim frmESS_ As New frmESS_NhapDiemTu_Excel_Sub
            '----------------------------------------------------------
            Dim dc As New DataColumn("Chon", GetType(Boolean))
            dc.DefaultValue = False
            dtDiem_MoiTonTai.Columns.Add(dc)
            '----------------------------------------------------------
            frmESS_.lblSV_NEW.Text = dtDiem_MoiChuan.Rows.Count
            frmESS_.lblSV_Trung.Text = dtDiem_MoiTonTai.Rows.Count
            frmESS_.lblSV_False.Text = dtDiem_Sai.Rows.Count
            '----------------------------------------------------------
            SetUpDataGridView(frmESS_.grdViewDiem_TonTai)
            SetUpDataGridView(frmESS_.grdViewDiem_MoiTonTai)
            SetUpDataGridView(frmESS_.grdViewDiem_Sai)
            SetUpDataGridView(frmESS_.grdViewDiem_MoiChuan)
            frmESS_.grdViewDiem_TonTai.DataSource = dtDiem_TonTai
            frmESS_.grdViewDiem_MoiTonTai.DataSource = dtDiem_MoiTonTai
            frmESS_.grdViewDiem_Sai.DataSource = dtDiem_Sai
            frmESS_.grdViewDiem_MoiChuan.DataSource = dtDiem_MoiChuan
            '----------------------------------------------------------
            Me.Cursor = Cursors.Default
            frmESS_.Tag = "0"
            frmESS_.ShowDialog()
            If frmESS_.Tag = "1" Then
                Dim dt As DataTable = grdViewDiem.DataSource
                dt.Columns(cmbCot_diem.Text).ReadOnly = True
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Function Check_valid() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        If cmbHoc_ky.SelectedIndex < 0 Then
            Call SetErrPro(cmbHoc_ky, ErrorProvider1, "Bạn phải chọn học kỳ")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.SelectedIndex < 0 Then
            Call SetErrPro(cmbNam_hoc, ErrorProvider1, "Bạn phải chọn năm học")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If cmbLan_thi.SelectedIndex < 0 Then
            Call SetErrPro(cmbLan_thi, ErrorProvider1, "Bạn phải chọn lần thi")
            If CtrlErr Is Nothing Then CtrlErr = cmbLan_thi
        End If
        If cmbID_mon.SelectedIndex < 0 Then
            Call SetErrPro(cmbID_mon, ErrorProvider1, "Bạn phải chọn Học phần")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_mon
        End If
        If cmbChonFile.SelectedIndex < 0 Then
            Call SetErrPro(cmbChonFile, ErrorProvider1, "Bạn phải chọn Sheet ")
            If CtrlErr Is Nothing Then CtrlErr = cmbChonFile
        End If
        If cmbCot_ma.SelectedIndex < 0 Then
            Call SetErrPro(cmbCot_ma, ErrorProvider1, "Bạn phải chọn cột mã")
            If CtrlErr Is Nothing Then CtrlErr = cmbCot_ma
        End If
        If cmbCot_diem.SelectedIndex < 0 Then
            Call SetErrPro(cmbCot_diem, ErrorProvider1, "Bạn phải chọn cột điểm")
            If CtrlErr Is Nothing Then CtrlErr = cmbCot_diem
        End If
        If cmbCot_ma.Text.Trim <> "" And cmbCot_ma.Text = cmbCot_diem.Text Then
            Call SetErrPro(cmbCot_ma, ErrorProvider1, "Cột mã và cột điểm không được trùng nhau")
            Call SetErrPro(cmbCot_diem, ErrorProvider1, "Cột mã và cột điểm không được trùng nhau")
            If CtrlErr Is Nothing Then CtrlErr = cmbCot_ma
        End If
        If cmbThanh_phan.SelectedIndex >= 0 Then
            If txtTy_le.Text.Trim = "" Then
                Call SetErrPro(txtTy_le, ErrorProvider1, "Bạn phải chọn tỷ lệ")
                If CtrlErr Is Nothing Then CtrlErr = txtTy_le
            ElseIf Not IsNumeric(txtTy_le.Text) Then
                Call SetErrPro(txtTy_le, ErrorProvider1, "Tỷ lệ phải nhập giá trị số")
                If CtrlErr Is Nothing Then CtrlErr = txtTy_le
            ElseIf CType(txtTy_le.Text, Long) > 100 Or CType(txtTy_le.Text, Long) <= 0 Then
                Call SetErrPro(txtTy_le, ErrorProvider1, "Tỷ lệ phải > 0 và <= 100")
                If CtrlErr Is Nothing Then CtrlErr = txtTy_le
            End If
        End If
        If (txtTy_le.Text.Trim <> "" Or cmbThanh_phan.Text.Trim <> "") And cmbLan_thi.Text = "2" Then
            Call SetErrPro(cmbLan_thi, ErrorProvider1, "Điểm thành phần chỉ có điểm lần 1 ")
            If CtrlErr Is Nothing Then CtrlErr = cmbLan_thi
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        Check_valid = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Check_valid = False
        CtrlErr.Focus()
    End Function

    Private Sub cmbThanh_phan_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbThanh_phan.SelectedIndexChanged
        'If Loader Then
        '    txtTy_le.Text = 0
        'End If
    End Sub
End Class