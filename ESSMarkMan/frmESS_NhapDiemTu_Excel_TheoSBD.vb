Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_NhapDiemTu_Excel_TheoSBD
    Dim Loader As Boolean = False
    Dim xlsFileName As String = ""
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private clsDiem As New Diem_Bussines
    Dim dt_main As DataTable
    Private So_lan_thi_lai As Integer = 2
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0

    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""

    Private mHoc_ky_TP As Integer = 0
    Private mNam_hoc_TP As String = ""
    Private mHoc_ky_thi As Integer = 0
    Private mNam_hoc_thi As String = ""

    Private mID_thi As Integer = 0
    Private mLan_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private mTen_mon As String = ""
    Private mID_khoa As Integer = 0
    Private mTen_khoa As String = ""
    Private mNgay_thi As String = ""
    Private mTen_phong As String = ""
    Private clsTCThi As TochucThi_Bussines
    Private dtDanhSachSinhVien As New DataTable



#Region "Form Events"
    Private Sub frmESS_NhapDiemExcel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_NhapDiemExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            If Loader Then
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi

                mTen_mon = trvPhongThi.Ten_mon
                mTen_phong = trvPhongThi.Phong_thi
                mTen_khoa = trvPhongThi.Ten_khoa
                mID_khoa = trvPhongThi.ID_khoa
                If mID_thi > 0 Then
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    If mID_phong_thi > 0 Then
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
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





    Private Function Check_valid() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        If mHoc_ky <= 0 Then
            Call SetErrPro(trvPhongThi, ErrorProvider1, "Bạn phải chọn học kỳ")
            If CtrlErr Is Nothing Then CtrlErr = trvPhongThi
        End If
        If mNam_hoc = "" Then
            Call SetErrPro(trvPhongThi, ErrorProvider1, "Bạn phải chọn năm học")
            If CtrlErr Is Nothing Then CtrlErr = trvPhongThi
        End If
        If mLan_thi <= 0 Then
            Call SetErrPro(trvPhongThi, ErrorProvider1, "Bạn phải chọn lần thi")
            If CtrlErr Is Nothing Then CtrlErr = trvPhongThi
        End If
        If mID_mon <= 0 Then
            Call SetErrPro(trvPhongThi, ErrorProvider1, "Bạn phải chọn Học phần")
            If CtrlErr Is Nothing Then CtrlErr = trvPhongThi
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

        If Not CtrlErr Is Nothing Then GoTo QUIT
        Check_valid = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Check_valid = False
        CtrlErr.Focus()
    End Function


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If dtDanhSachSinhVien Is Nothing Then Exit Sub
            If Not Check_valid() Then Exit Sub
            Dim dtDiem_TonTai, dtDiem_MoiTonTai, dtDiem_Sai, dtDiem_MoiChuan As DataTable
            Me.Cursor = Cursors.WaitCursor

            clsDiem.CapNhat_ESSdata_Diem_SBD(dtDanhSachSinhVien, grdViewDiem.DataSource, gobjUser.ID_dv, mHoc_ky, mNam_hoc, mLan_thi, mID_mon, _
                                  cmbCot_ma.Text, cmbCot_diem.Text, dtDiem_TonTai, dtDiem_MoiTonTai, dtDiem_Sai, dtDiem_MoiChuan, _
                                  0, 0)
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
            frmESS_.Tag = "0"
            frmESS_.ShowDialog()
            If frmESS_.Tag = "1" Then
                Dim dt As DataTable = grdViewDiem.DataSource
                dt.Columns(cmbCot_diem.Text).ReadOnly = True
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdConvertFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvertFont.Click
        If cmbFont.Text <> "" Then
            If Not grdViewDiem.DataSource Is Nothing Then
                Me.Cursor = Cursors.WaitCursor
                Call Convert_font(cmbFont.Text, grdViewDiem.DataSource)
                cmdConvertFont.Enabled = False
                Me.Cursor = Cursors.Default
            Else
                Thongbao("Không có dữ liệu để chuyển đổi, bạn hãy mở file dữ liệu để chuyển đổi ")
            End If
        Else
            Thongbao("Bạn hãy chọn font chữ của file dữ liệu nguồn !")
            cmbFont.Focus()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class