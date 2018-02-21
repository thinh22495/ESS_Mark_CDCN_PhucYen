Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_HoTroNhapDiemTuExcel
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
                    Dim oleCnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & cmbChonFile.Text & "]", oleCnn)
                    Dim dt As New DataTable
                    Dim i As Integer

                    da.Fill(dt)
                    grdViewDiem.DataSource = dt
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
                Dim dt_sinhvien As New DataTable
                dt_sinhvien = clsDM.LoadDanhMuc("SELECT DISTINCT hs.ID_sv,Ma_sv,l.ID_dt FROM STU_HoSoSinhVien hs INNER JOIN STU_DanhSach ds ON hs.ID_sv=ds.ID_sv INNER JOIN STU_Lop l ON ds.ID_lop=l.ID_lop where Khoa_hoc=" & cmbKhoa_hoc.SelectedValue)
                grdViewSinhVien.DataSource = dt_sinhvien
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdFontFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFontFile.Click
        If cmbFont.Text <> "" Then
            If Not grdViewDiem.DataSource Is Nothing Then
                Me.Cursor = Cursors.WaitCursor
                Call Convert_font(cmbFont.Text, grdViewDiem.DataSource)
                'cmdFontFile.Enabled = False
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
        Dim frm As New frmESS_ProgressBar
        Try
            If Not Check_valid() Then Exit Sub
            '----------------------------------------------------------
            Me.Cursor = Cursors.Default
            Dim clsDM As New DanhMuc_Bussines
            Dim dt_diem As DataTable = grdViewDiem.DataSource
            Dim dvDiem As DataView = dt_diem.DefaultView
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text

            Dim dt_SV As DataTable = grdViewSinhVien.DataSource
            Dim dtDiemSV As DataTable


            frm.Master_Max = dt_SV.Rows.Count

            For i As Integer = 0 To dt_SV.Rows.Count - 1
                Dim ID_sv As Integer = dt_SV.Rows(i)("ID_sv").ToString
                Dim ID_dt As Integer = dt_SV.Rows(i)("ID_dt").ToString
                Dim Ma_sv As String = dt_SV.Rows(i)("Ma_sv").ToString
                If ID_sv > 0 And ID_dt > 0 And Ma_sv <> "" Then
                    dvDiem.RowFilter = "F_MASV=" & "'" & Ma_sv & "'"
                    dtDiemSV = dvDiem.ToTable
                    If dtDiemSV.Rows.Count > 0 Then
                        Dim ID_mon As Integer = 0
                        Dim Ky_hieu As String = ""
                        Dim Ten_mon As String = ""
                        Dim dt_mon As New DataTable
                        For j As Integer = 0 To dtDiemSV.Rows.Count - 1
                            frm.Slave_Max = dtDiemSV.Rows.Count
                            Try
                                If dtDiemSV.Rows(j)("F_MAMH").ToString.Trim <> "" Or dtDiemSV.Rows(j)("F_TENMHVN").ToString.Trim <> "" Then
                                    Ky_hieu = dtDiemSV.Rows(j)("F_MAMH").ToString.Trim
                                    Ten_mon = dtDiemSV.Rows(j)("F_TENMHVN").ToString.Trim
                                    If Ky_hieu <> "" Then
                                        dt_mon = clsDM.DanhMuc_Load("SELECT distinct mh.ID_mon FROM Mark_MonHoc mh inner join PLAN_ChuongTrinhDaoTaoChiTiet ctct on mh.ID_mon=ctct.ID_mon Where Ky_hieu=" & "'" & Ky_hieu & "' AND ID_dt=" & ID_dt)
                                        'ElseIf Ten_mon <> "" Then
                                        '    dt_mon = clsDM.DanhMuc_Load("SELECT distinct mh.ID_mon FROM Mark_MonHoc mh inner join PLAN_ChuongTrinhDaoTaoChiTiet ctct on mh.ID_mon=ctct.ID_mon Where Ten_mon like " & "N'" & Ten_mon & "' AND ID_dt=" & ID_dt)
                                    End If
                                    If dt_mon.Rows.Count > 0 Then
                                        ID_mon = dt_mon.Rows(0)("ID_mon")
                                    Else
                                        Continue For
                                    End If

                                    If (dtDiemSV.Rows(j)("F_DIEM1").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEM1").ToString.Trim)) Or (dtDiemSV.Rows(j)("F_DIEM2").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEM2").ToString.Trim)) Or (dtDiemSV.Rows(j)("F_DIEMBT").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEMBT").ToString.Trim)) Then
                                        Dim objDiem As New ESSDiem
                                        Dim objDiemTP As New ESSDiemThanhPhan
                                        Dim objDiemThi As New ESSDiemThi
                                        Dim ID_diem As Integer = 0
                                        Dim DiemTPKT As Double = 0
                                        Dim DiemTPBT As Double = 0
                                        Dim DiemThi1 As Double = 0
                                        Dim DiemThi2 As Double = 0
                                        Dim Ty_leKT As Integer = 0
                                        Dim Ty_leBT As Integer = 0



                                        objDiem.Hoc_ky = Hoc_ky
                                        objDiem.Nam_hoc = Nam_hoc
                                        objDiem.ID_mon = ID_mon
                                        objDiem.ID_dt = ID_dt
                                        objDiem.ID_dv = gobjUser.ID_dv
                                        objDiem.ID_sv = ID_sv
                                        ID_diem = clsDiem.CheckExist_svDiem(gobjUser.ID_dv, ID_sv, ID_mon, ID_dt)
                                        If ID_diem > 0 Then
                                            ID_diem = clsDiem.CapNhat_ESSDiem(objDiem, ID_diem)
                                        Else
                                            ID_diem = clsDiem.ThemMoi_ESSDiem(objDiem)
                                        End If

                                        If dtDiemSV.Rows(j)("F_DIEM1").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEM1").ToString.Trim) Then
                                            objDiemTP.ID_thanh_phan = 2
                                            Ty_leKT = IIf(dtDiemSV.Rows(j)("F_PHTRAMKT").ToString.Trim <> "0", txtTy_le.Text.Trim, dtDiemSV.Rows(j)("F_PHTRAMKT").ToString.Trim)
                                            objDiemTP.Ty_le = Ty_leKT
                                            objDiemTP.Hoc_ky_TP = Hoc_ky
                                            objDiemTP.Nam_hoc_TP = Nam_hoc
                                            DiemTPKT = dtDiemSV.Rows(j)("F_DIEM1").ToString.Trim
                                            objDiemTP.Diem = DiemTPKT
                                            'Hash code dữ liệu điểm để chống sửa dữ liệu từ Database
                                            objDiemTP.Hash_code = (ID_diem.ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                                            objDiemTP.Locked = 0
                                            'Update
                                            If clsDiem.CheckExist_svDiemThanhPhan(ID_diem, 2, Hoc_ky, Nam_hoc) > 0 Then
                                                clsDiem.CapNhat_ESSDiemThanhPhan(objDiemTP, ID_diem, 2)
                                            Else    'Insert
                                                clsDiem.ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemTP)
                                            End If
                                        End If

                                        If dtDiemSV.Rows(j)("F_DIEMBT").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEMBT").ToString.Trim) Then
                                            objDiemTP.ID_thanh_phan = 3
                                            Ty_leBT = IIf(dtDiemSV.Rows(j)("F_PHTRAMBT").ToString.Trim <> "0", txtTy_le.Text.Trim, dtDiemSV.Rows(j)("F_PHTRAMBT").ToString.Trim)
                                            objDiemTP.Ty_le = Ty_leBT
                                            objDiemTP.Hoc_ky_TP = Hoc_ky
                                            objDiemTP.Nam_hoc_TP = Nam_hoc
                                            DiemTPBT = dtDiemSV.Rows(j)("F_DIEMBT").ToString.Trim
                                            objDiemTP.Diem = DiemTPBT
                                            'Hash code dữ liệu điểm để chống sửa dữ liệu từ Database
                                            objDiemTP.Hash_code = (ID_diem.ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                                            objDiemTP.Locked = 0
                                            'Update
                                            If clsDiem.CheckExist_svDiemThanhPhan(ID_diem, 3, Hoc_ky, Nam_hoc) > 0 Then
                                                clsDiem.CapNhat_ESSDiemThanhPhan(objDiemTP, ID_diem, 3)
                                            Else    'Insert
                                                clsDiem.ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemTP)
                                            End If
                                        End If


                                        Dim TBCMH As Double = 0
                                        If dtDiemSV.Rows(j)("F_DIEM2").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEM2").ToString.Trim) Then

                                            objDiemThi.Hoc_ky_thi = Hoc_ky
                                            objDiemThi.Nam_hoc_thi = Nam_hoc
                                            objDiemThi.Lan_thi = 1
                                            If dtDiemSV.Rows(j)("F_DIEM2").ToString.Trim = "" Then
                                                objDiemThi.Diem_thi = -1
                                            Else
                                                DiemThi1 = dtDiemSV.Rows(j)("F_DIEM2").ToString.Trim
                                                objDiemThi.Diem_thi = DiemThi1
                                            End If
                                            If Ty_leBT + Ty_leKT >= 0 And DiemThi1 >= 0 Then
                                                TBCMH = Math.Round((DiemTPBT * Ty_leBT + DiemTPKT * Ty_leKT + DiemThi1 * (100 - Ty_leBT - Ty_leKT)) / 100 + 0.00001, 2)
                                            Else
                                                TBCMH = DiemThi1
                                            End If
                                            objDiemThi.TBCMH = TBCMH
                                            objDiemThi.Diem_chu = clsDiem.QuyDoiDiemChu(TBCMH)
                                            objDiemThi.Ghi_chu = ""

                                            If clsDiem.CheckExist_svDiemThi(ID_diem, 1, Hoc_ky, Nam_hoc) > 0 Then
                                                clsDiem.CapNhat_ESSDiemThi(objDiemThi, ID_diem, 1)
                                            Else    'Insert điểm thi mới
                                                clsDiem.ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                                            End If
                                        End If

                                        If dtDiemSV.Rows(j)("F_DIEMTL").ToString.Trim <> "" AndAlso IsNumeric(dtDiemSV.Rows(j)("F_DIEMTL").ToString.Trim) Then
                                            objDiemThi.Hoc_ky_thi = Hoc_ky
                                            objDiemThi.Nam_hoc_thi = Nam_hoc
                                            objDiemThi.Lan_thi = 2
                                            DiemThi2 = dtDiemSV.Rows(j)("F_DIEMTL").ToString.Trim
                                            objDiemThi.Diem_thi = DiemThi2
                                            If Ty_leBT + Ty_leKT >= 0 And DiemThi2 >= 0 Then
                                                TBCMH = Math.Round((DiemTPBT * Ty_leBT + DiemTPKT * Ty_leKT + DiemThi2 * (100 - Ty_leBT - Ty_leKT)) / 100 + 0.00001, 1)
                                            Else
                                                TBCMH = DiemThi2
                                            End If
                                            objDiemThi.TBCMH = TBCMH
                                            objDiemThi.Diem_chu = clsDiem.QuyDoiDiemChu(TBCMH)
                                            objDiemThi.Ghi_chu = ""

                                            If clsDiem.CheckExist_svDiemThi(ID_diem, 2, Hoc_ky, Nam_hoc) > 0 Then
                                                clsDiem.CapNhat_ESSDiemThi(objDiemThi, ID_diem, 2)
                                            Else    'Insert điểm thi mới
                                                clsDiem.ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                                            End If
                                        End If
                                    Else
                                        Continue For
                                    End If
                                End If
                                frm.Show(i, j)
                            Catch ex As Exception
                                frm.Show(i, j)
                                Continue For
                            End Try
                        Next
                    End If
                Else
                    frm.Show(i, 0)
                End If
               
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        Finally
            frm.Close()
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
        
   
        If cmbChonFile.SelectedIndex < 0 Then
            Call SetErrPro(cmbChonFile, ErrorProvider1, "Bạn phải chọn Sheet ")
            If CtrlErr Is Nothing Then CtrlErr = cmbChonFile
        End If
      
        If txtTy_le.Text.Trim = "" Or txtTy_le.Text.Trim = "0" Then
            Call SetErrPro(txtTy_le, ErrorProvider1, "Bạn hãy nhập tỷ lệ thành phần môn")
            If CtrlErr Is Nothing Then CtrlErr = txtTy_le
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        Check_valid = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Check_valid = False
        CtrlErr.Focus()
    End Function


End Class