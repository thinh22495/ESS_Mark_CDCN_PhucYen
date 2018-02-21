Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_PhanBoQuyHocBong
    Private mQuy_hb As New ESSQuyHocBong
    Private mdtDieuKien As DataTable = Nothing ' Danh sác các lớp được phân bổ
    Private Loader As Boolean = False
    Private Sub frmESS_PhanBoQuyHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        SetUpDataGridView(grdViewPhanBo)
        SetQuyenTruyCap(cmdSave, , , cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_PhanBoQuyHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#Region "Button"
    Private Sub cmdPhanTuDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPhanTuDong.Click
        If Not CheckInputData() Then Exit Sub
        If txtSotien_conlai.Text < 1000 Then ' Số tiền phân bổ quá nhỏ không phân nữa
            Thongbao("Số tiền để phân quá nhỏ.Bạn không thể phân bổ tiếp !")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New ESSQuyHocBongPhanBo
        Dim obj_Bussines As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
        ' Lấy ra dữ liệu cần để phân tự động theo điều kiện Khoa, khóa học,chuyên ngành và lớp        
        mdtDieuKien = getDieuKien_PhanBo(mQuy_hb.ID_he, chkKhoa.Checked, chkKhoa_hoc.Checked, chkChuyen_nganh.Checked, chkLop.Checked, mQuy_hb.Tu_khoa, mQuy_hb.Den_khoa, chkNganh.Checked)
        If mdtDieuKien Is Nothing Then Exit Sub
        ' Loại bỏ những lớp đã phân theo hình thức thủ công
        Dim dtTC As DataTable
        dtTC = obj_Bussines.Lop_PhanBo_ThuCong()
        For i As Integer = mdtDieuKien.Rows.Count - 1 To 0 Step -1
            For Each r As DataRow In dtTC.Rows
                If mdtDieuKien.Rows(i)("ID_lop") = r("ID_lop") Then
                    mdtDieuKien.Rows(i).Delete()
                    Exit For
                End If
            Next
        Next
        mdtDieuKien.AcceptChanges()
        ' Tính tổng số sv của một phân bổ và tổng số sinh viên xét học bổng
        Dim Tong_sv As Integer = 0
        Dim data As New DataTable
        data.Columns.Add("Ten_phan_bo")
        data.Columns.Add("So_sv")
        data.Columns.Add("So_sv_tc")
        Dim row As DataRow
        Dim dv As DataView
        Dim Temp As String = ""
        For i As Integer = 0 To mdtDieuKien.Rows.Count - 1
            If Temp <> mdtDieuKien.Rows(i)("Ten_phan_bo") Then
                dv = mdtDieuKien.DefaultView
                dv.RowFilter = "Ten_phan_bo='" & mdtDieuKien.Rows(i)("Ten_phan_bo") & "'"
                Dim So_sv As Integer = 0
                Dim So_sv_tc As Integer = 0
                For j As Integer = 0 To dv.Count - 1
                    So_sv += dv.Item(j)("So_sv")
                    So_sv_tc += dv.Item(j)("So_sv_tro_cap_xh")
                Next
                row = data.NewRow
                row("Ten_phan_bo") = mdtDieuKien.Rows(i)("Ten_phan_bo")
                row("So_sv") = So_sv ' Tong so sv mot phan bo
                row("So_sv_tc") = So_sv_tc ' Tong so sv tro cap
                Tong_sv += So_sv
                data.Rows.Add(row)
                Temp = mdtDieuKien.Rows(i)("Ten_phan_bo")
            End If
        Next
        '--------------
        Dim SoTien As Double = CDbl(txtSotien_conlai.Text)
        Dim SoTienDaPhan As Double = 0
        Dim SoTienConLai As Double = 0
        Dim dtView As New DataTable
        dtView = grdViewPhanBo.DataSource.Table
        Dim dr As DataRow
        For i As Integer = 0 To data.Rows.Count - 1
            dr = dtView.NewRow
            ' Tính số tiền cho một đối tượng phần bổ
            Dim So_tien As Double
            So_tien = SoTien_Mot_DoiTuong_PhanBo(SoTien, Tong_sv, IIf(data.Rows(i)("So_sv").ToString = "", 0, data.Rows(i)("So_sv")))
            dr("ID_phan_bo") = 0
            dr("Ten_phan_bo") = data.Rows(i)("Ten_phan_bo")
            dr("So_sv") = data.Rows(i)("So_sv")
            dr("So_tien") = So_tien
            dr("Phan_dac_biet") = 0
            dr("Kieu_phan_bo") = "Phân tự động"
            dtView.Rows.Add(dr)
            SoTienDaPhan += So_tien
        Next
        txtSotien_dacap.Text = Format(SoTienDaPhan, "###,##0") ' Số tiền đã phân
        SoTienConLai = SoTien - SoTienDaPhan
        If SoTienConLai < 0 Then
            txtSotien_conlai.Text = 0
        Else
            txtSotien_conlai.Text = Format(SoTienConLai, "###,##0") ' Số tiền còn lại
        End If
        dtView.DefaultView.AllowNew = False
        grdViewPhanBo.DataSource = dtView.DefaultView
        Thongbao("Bạn đã phân bổ quỹ học bổng thành công !")
        Me.Cursor = Cursors.Default
    End Sub
    Private Function SoTien_Mot_DoiTuong_PhanBo(ByVal Tong_tien_phan As Double, ByVal Tong_sv As Integer, ByVal Tong_sv_Mot_PhanBo As Integer) As Double
        Try
            Dim So_tien As Double = 0
            So_tien = (Tong_tien_phan / Tong_sv) * Tong_sv_Mot_PhanBo
            Return So_tien
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function

    Private Sub cmdPhanThuCong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPhanThuCong.Click
        If mQuy_hb.ID_quy = 0 Then Exit Sub ' Nếu chưa chọn quỹ học bổng thì kết thúc
        If Not CheckInputData() Then Exit Sub
        If txtSotien_conlai.Text < 1000 Then ' Số tiền phân bổ quá nhỏ không phân nữa
            Thongbao("Số tiền để phân quá nhỏ.Bạn không thể phân bổ tiếp !")
            Exit Sub
        End If
        Dim frmESS_ As New frmESS_PhanBoQuyHocBongThuCong(mQuy_hb)
        frmESS_.ShowDialog()
        HienThi_ESSDataQuyHocBong(mQuy_hb)
    End Sub
    Private Sub cmdPrintTK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintTK.Click
        Try
            If mQuy_hb.ID_quy = 0 Then Exit Sub ' Nếu chưa chọn quỹ học bổng thì kết thúc
            If cmbID_quy.SelectedValue Is Nothing Then
                Thongbao("Bạn phải chọn loại quỹ học bổng !")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim cls As New TongHopThongKe_Bussines
            Dim dt As DataTable
            Dim Khoa_hoc As String = ""
            Dim Tu_khoa As Integer = mQuy_hb.Tu_khoa
            Dim Den_khoa As Integer = mQuy_hb.Den_khoa
            If Den_khoa > Tu_khoa Then
                For i As Integer = Tu_khoa To Den_khoa
                    Khoa_hoc += i & ","
                Next
                Khoa_hoc = Khoa_hoc.Substring(0, Khoa_hoc.Length - 1)
            Else
                Khoa_hoc = Tu_khoa
            End If
            dt = cls.TongHop_SoLieu_XetHocBong(cmbID_he.SelectedValue, Khoa_hoc, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            Dim Title1 As String = "THỐNG KÊ SỐ LIỆU SINH VIÊN ĐỂ XÉT HỌC BỔNG"
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpThongKeSoLieu_XetHocBong", dt, Title1, , , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        If mQuy_hb.ID_quy = 0 Then Exit Sub ' Nếu chưa chọn quỹ học bổng thì kết thúc
        Dim frmESS_ As New frmESS_PhanBoQuyHocBongChiTiet(mQuy_hb)
        frmESS_.ShowDialog()
        HienThi_ESSDataQuyHocBong(mQuy_hb)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim dv As New DataView
        dv = grdViewPhanBo.DataSource
        If dv Is Nothing Then Exit Sub
        Dim obj_Bussines As New QuyHocBongPhanBo_Bussines()
        Dim So_tien_da_phan As Double = 0
        For i As Integer = 0 To dv.Count - 1
            Dim objPB As New ESSQuyHocBongPhanBo
            objPB.ID_phan_bo = dv.Item(i)("ID_phan_bo")
            objPB.Ten_phan_bo = dv.Item(i)("Ten_phan_bo")
            objPB.ID_hb = mQuy_hb.ID_hb
            objPB.Phan_dac_biet = dv.Item(i)("Phan_dac_biet")
            objPB.So_sv = dv.Item(i)("So_sv")
            objPB.So_tien = CDbl(dv.Item(i)("So_tien"))
            So_tien_da_phan += CDbl(dv.Item(i)("So_tien"))
            If objPB.ID_phan_bo = 0 Then ' Thêm mới
                Dim ID_phan_bo As Integer = 0
                ID_phan_bo = obj_Bussines.ThemMoi_ESSQuyHocBongPhanBo(objPB)
                ' Cập nhật ID_phan_bo vào dv
                dv.Item(i)("ID_phan_bo") = ID_phan_bo
            Else
                obj_Bussines.CapNhat_ESSQuyHocBongPhanBo(objPB, objPB.ID_phan_bo)
            End If
        Next
        dv.Table.AcceptChanges()
        ' Cập nhật danh sách các lóp được phân bổ        
        If Not mdtDieuKien Is Nothing Then ' Khi mới phân
            For i As Integer = 0 To dv.Count - 1
                For j As Integer = mdtDieuKien.Rows.Count - 1 To 0 Step -1
                    If dv.Item(i)("Ten_phan_bo") = mdtDieuKien.Rows(j)("Ten_phan_bo") Then
                        If Not obj_Bussines.CheckExits_QuyHocBongPhanBoLop(dv.Item(i)("ID_phan_bo"), mdtDieuKien.Rows(j)("ID_lop")) Then
                            obj_Bussines.ThemMoi_ESSQuyHocBongPhanBoLop(dv(i)("ID_phan_bo"), mdtDieuKien.Rows(j)("ID_lop"))
                        End If
                    End If
                Next
            Next
        End If
        mdtDieuKien = Nothing
        HienThi_ESSDataQuyHocBong(mQuy_hb) ' Load lại dữ liệu
        Thongbao("Bạn đã cập nhật phân bổ quỹ học bổng thành công !")
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            Dim dv As New DataView
            dv = grdViewPhanBo.DataSource
            If dv Is Nothing Then Exit Sub
            If Thongbao("Bạn có muốn xóa phân bổ hiện chọn trên danh sách không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim idx As Integer = grdViewPhanBo.CurrentRow.Index
            Dim obj_Bussines As New QuyHocBongPhanBo_Bussines()
            obj_Bussines.Xoa_ESSQuyHocBongPhanBo(dv.Item(idx)("ID_phan_bo")) ' xóa quỹ học bổng phân bổ trên database
            obj_Bussines.Xoa_ESSQuyHocBongPhanBoLop(dv.Item(idx)("ID_phan_bo")) ' xóa quỹ học bổng phân bổ lớp trên database
            txtSotien_dacap.Text = Format(CDbl(txtSotien_dacap.Text) - dv.Item(idx)("So_tien"), "###,##0")
            txtSotien_conlai.Text = Format(CDbl(txtSotien_conlai.Text) + dv.Item(idx)("So_tien"), "###,##0")
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

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbID_he.SelectedIndexChanged, cmbID_quy.SelectedIndexChanged
        If Not Loader Then Exit Sub
        ' Load dữ liệu quỹ học bổng            
        Dim obj As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        mQuy_hb = obj.HienThi_ESSQuyHocBong(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbID_he.SelectedValue, cmbID_quy.SelectedValue)
        HienThi_ESSDataQuyHocBong(mQuy_hb)

        ' Load tổng số tiền trợ cấp
        Dim cls As New TongHopThongKe_Bussines
        Dim dt As DataTable
        Dim Khoa_hoc As String = ""
        Dim Tu_khoa As Integer = mQuy_hb.Tu_khoa
        Dim Den_khoa As Integer = mQuy_hb.Den_khoa
        If Den_khoa > Tu_khoa Then
            For i As Integer = Tu_khoa To Den_khoa
                Khoa_hoc += i & ","
            Next
            Khoa_hoc = Khoa_hoc.Substring(0, Khoa_hoc.Length - 1)
        Else
            Khoa_hoc = Tu_khoa
        End If
    End Sub

    Private Sub txtSotien_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSotien.TextChanged, txtSotien_dacap.TextChanged, txtSotien_conlai.TextChanged
        txtSotien_chu.Text = "(" & ChuyenChu(CType("0" & txtSotien.Text, Long)) & " đồng )"
        txtSotien_dacap_chu.Text = "(" & ChuyenChu(CType("0" & txtSotien_dacap.Text, Long)) & " đồng )"
        txtSotien_conlai_chu.Text = "(" & ChuyenChu(CType("0" & txtSotien_conlai.Text, Long)) & " đồng )"
        If Loader Then
            ' Số tiền còn lại
            Dim SoTien_ConLai As Double = CDbl(txtSotien.Text) - CDbl(txtSotien_dacap.Text)
            If SoTien_ConLai < 0 Then
                txtSotien_conlai.Text = 0
            Else
                txtSotien_conlai.Text = Format(SoTien_ConLai, "###,##0") ' Số tiền còn lại
            End If
        End If
    End Sub
#End Region
#Region "Fucntion"
    Private Function getDieuKien_PhanBo(ByVal ID_he As Integer, ByVal Khoa As Boolean, ByVal Khoa_hoc As Boolean, ByVal Chuyen_nganh As Boolean, ByVal Lop As Boolean, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer, ByVal Nganh As Boolean) As DataTable
        Try
            ' Danh sách sinh viên
            Dim objSV As New DanhSachSinhVien_Bussines(gobjUser.dsID_lop)
            Dim dvSV As DataView
            dvSV = objSV.Danh_sach_sinh_vien().DefaultView
            ' Danh sác lớp
            Dim dvLop As DataView
            Dim objLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dvLop = objLop.Danh_sach_lop_dang_hoc().DefaultView
            Dim dk As String = "1=1"
            dk += " And ID_he=" & ID_he ' Lọc lớp theo hệ            
            dvLop.RowFilter = dk

            Dim dt As New DataTable
            dt.Columns.Add("Ten_phan_bo")
            dt.Columns.Add("So_sv")
            dt.Columns.Add("So_sv_tro_cap_xh") ' Số sinh viên được hưởng trợ cấp xã hội
            dt.Columns.Add("So_tien")
            dt.Columns.Add("ID_lop")
            Dim dr As DataRow
            If Lop Then ' TH1 Phân theo lớp
                For i As Integer = 0 To dvLop.Count - 1
                    Dim dtSV As DataTable
                    If dvLop.Item(i)("Khoa_hoc") >= Tu_khoa And dvLop.Item(i)("Khoa_hoc") <= Den_khoa Then
                        dr = dt.NewRow
                        dtSV = dvSV.Table.Copy
                        dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(i)("ID_lop")
                        dr("Ten_phan_bo") = "Lớp " & dvLop.Item(i)("Ten_Lop")
                        dr("So_sv") = dtSV.DefaultView.Count ' Số sinh viên lớp học
                        dr("So_tien") = 0
                        dr("ID_lop") = dvLop.Item(i)("ID_lop")
                        ' Danh sách sinh viên trợ cấp
                        Dim dtTroCap As DataTable
                        Dim objQ As New QuyHocBongPhanBo_Bussines
                        dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                        dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                        dt.Rows.Add(dr)
                    End If
                Next
            Else ' Các trường hợp khác                
                If Khoa And Not Khoa_hoc And Not Chuyen_nganh And Not Nganh Then ' TH2 Phân theo khoa   
                    Dim dtKhoa As DataTable
                    dtKhoa = objLop.Khoa()
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        For j As Integer = 0 To dvLop.Count - 1
                            If dtKhoa.Rows(i)("ID_khoa") = dvLop.Item(j)("ID_khoa") And dvLop.Item(j)("Khoa_hoc") >= Tu_khoa And dvLop.Item(j)("Khoa_hoc") <= Den_khoa Then
                                dr = dt.NewRow
                                dtSV = dvSV.Table.Copy
                                dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(j)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                dr("Ten_phan_bo") = "Khoa " & dvLop.Item(j)("Ten_khoa")
                                dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                dr("So_tien") = 0
                                dr("ID_lop") = dvLop.Item(j)("ID_lop")
                                ' Danh sách sinh viên trợ cấp
                                Dim dtTroCap As DataTable
                                Dim objQ As New QuyHocBongPhanBo_Bussines
                                dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                dt.Rows.Add(dr)
                            End If
                        Next
                    Next
                ElseIf Not Khoa And Khoa_hoc And Not Chuyen_nganh And Not Nganh Then ' TH3 Phân theo khóa học
                    Dim dtKhoaHoc As DataTable
                    dtKhoaHoc = objLop.Khoa_hoc
                    Dim dtSV As DataTable
                    Dim SoSv As Integer = 0
                    For i As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                        For j As Integer = 0 To dvLop.Count - 1
                            If dtKhoaHoc.Rows(i)("Khoa_hoc") = dvLop.Item(j)("Khoa_hoc") And dvLop.Item(j)("Khoa_hoc") >= Tu_khoa And dvLop.Item(j)("Khoa_hoc") <= Den_khoa Then
                                dr = dt.NewRow
                                dtSV = dvSV.Table.Copy
                                dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(j)("ID_lop")   ' Lọc để tính tổng sv theo lớp
                                dr("Ten_phan_bo") = "Khóa học " & dvLop.Item(j)("Khoa_hoc")
                                dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                dr("So_tien") = 0
                                dr("ID_lop") = dvLop.Item(j)("ID_lop")
                                SoSv += dtSV.DefaultView.Count
                                ' Danh sách sinh viên trợ cấp
                                Dim dtTroCap As DataTable
                                Dim objQ As New QuyHocBongPhanBo_Bussines
                                dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                dt.Rows.Add(dr)
                            End If
                        Next
                    Next
                ElseIf Not Khoa And Not Khoa_hoc And Nganh Then ' TH4 Phân theo ngành
                    Dim dtN As DataTable
                    dtN = objLop.Nganh_dao_tao(ID_he)
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtN.Rows.Count - 1
                        For j As Integer = 0 To dvLop.Count - 1
                            If dtN.Rows(i)("ID_nganh") = dvLop.Item(j)("ID_nganh") And dvLop.Item(j)("Khoa_hoc") >= Tu_khoa And dvLop.Item(j)("Khoa_hoc") <= Den_khoa Then
                                dr = dt.NewRow
                                dtSV = dvSV.Table.Copy
                                dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(j)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                dr("Ten_phan_bo") = "Ngành " & dvLop.Item(j)("Ten_nganh")
                                dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                dr("So_tien") = 0
                                dr("ID_lop") = dvLop.Item(j)("ID_lop")
                                ' Danh sách sinh viên trợ cấp
                                Dim dtTroCap As DataTable
                                Dim objQ As New QuyHocBongPhanBo_Bussines
                                dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                dt.Rows.Add(dr)
                            End If
                        Next
                    Next
                ElseIf Not Khoa And Not Khoa_hoc And Chuyen_nganh And Not Nganh Then ' TH4 Phân theo chuyên ngành
                    Dim dtCN As DataTable
                    dtCN = objLop.Chuyen_nganh_dao_tao()
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtCN.Rows.Count - 1
                        For j As Integer = 0 To dvLop.Count - 1
                            If dtCN.Rows(i)("ID_chuyen_nganh") = dvLop.Item(j)("ID_chuyen_nganh") And dvLop.Item(j)("Khoa_hoc") >= Tu_khoa And dvLop.Item(j)("Khoa_hoc") <= Den_khoa Then
                                dr = dt.NewRow
                                dtSV = dvSV.Table.Copy
                                dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(j)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                dr("Ten_phan_bo") = "Chuyên ngành " & dvLop.Item(j)("Chuyen_nganh")
                                dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                dr("So_tien") = 0
                                dr("ID_lop") = dvLop.Item(j)("ID_lop")
                                ' Danh sách sinh viên trợ cấp
                                Dim dtTroCap As DataTable
                                Dim objQ As New QuyHocBongPhanBo_Bussines
                                dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                dt.Rows.Add(dr)
                            End If
                        Next
                    Next
                ElseIf Khoa And Khoa_hoc And Not Chuyen_nganh And Not Nganh Then ' TH5 Phân theo Khoa và khóa học
                    Dim dtKhoa As DataTable
                    Dim dtKhoaHoc As DataTable
                    dtKhoa = objLop.Khoa()
                    dtKhoaHoc = objLop.Khoa_hoc()
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        For j As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                            For k As Integer = 0 To dvLop.Count - 1
                                If dtKhoa.Rows(i)("ID_khoa") = dvLop.Item(k)("ID_khoa") And dtKhoaHoc.Rows(j)("Khoa_hoc") = dvLop.Item(k)("Khoa_hoc") And dvLop.Item(k)("Khoa_hoc") >= Tu_khoa And dvLop.Item(k)("Khoa_hoc") <= Den_khoa Then
                                    dr = dt.NewRow
                                    dtSV = dvSV.Table.Copy
                                    dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(k)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                    dr("Ten_phan_bo") = "Khoa " & dvLop.Item(k)("Ten_khoa") & " Khóa học " & dvLop.Item(k)("Khoa_hoc")
                                    dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                    dr("So_tien") = 0
                                    dr("ID_lop") = dvLop.Item(k)("ID_lop")
                                    ' Danh sách sinh viên trợ cấp
                                    Dim dtTroCap As DataTable
                                    Dim objQ As New QuyHocBongPhanBo_Bussines
                                    dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                    dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        Next
                    Next
                ElseIf Khoa And Not Khoa_hoc And Nganh Then ' TH6 Phân theo Khoa và  ngành
                    Dim dtKhoa As DataTable
                    Dim dtN As DataTable
                    dtKhoa = objLop.Khoa()
                    dtN = objLop.Nganh_dao_tao(ID_he)
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        For j As Integer = 0 To dtN.Rows.Count - 1
                            For k As Integer = 0 To dvLop.Count - 1
                                If dtKhoa.Rows(i)("ID_khoa") = dvLop.Item(k)("ID_khoa") And dtN.Rows(j)("ID_nganh") = dvLop.Item(k)("ID_nganh") And dvLop.Item(k)("Khoa_hoc") >= Tu_khoa And dvLop.Item(k)("Khoa_hoc") <= Den_khoa Then
                                    dr = dt.NewRow
                                    dtSV = dvSV.Table.Copy
                                    dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(k)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                    dr("Ten_phan_bo") = "Khoa " & dvLop.Item(k)("Ten_khoa") & " Ngành " & dvLop.Item(k)("Ten_nganh")
                                    dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                    dr("So_tien") = 0
                                    dr("ID_lop") = dvLop.Item(k)("ID_lop")
                                    ' Danh sách sinh viên trợ cấp
                                    Dim dtTroCap As DataTable
                                    Dim objQ As New QuyHocBongPhanBo_Bussines
                                    dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                    dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        Next
                    Next
                ElseIf Khoa And Not Khoa_hoc And Chuyen_nganh Then ' TH6 Phân theo Khoa và chuyên ngành
                    Dim dtKhoa As DataTable
                    Dim dtCN As DataTable
                    dtKhoa = objLop.Khoa()
                    dtCN = objLop.Chuyen_nganh_dao_tao()
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        For j As Integer = 0 To dtCN.Rows.Count - 1
                            For k As Integer = 0 To dvLop.Count - 1
                                If dtKhoa.Rows(i)("ID_khoa") = dvLop.Item(k)("ID_khoa") And dtCN.Rows(j)("ID_chuyen_nganh") = dvLop.Item(k)("ID_chuyen_nganh") And dvLop.Item(k)("Khoa_hoc") >= Tu_khoa And dvLop.Item(k)("Khoa_hoc") <= Den_khoa Then
                                    dr = dt.NewRow
                                    dtSV = dvSV.Table.Copy
                                    dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(k)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                    dr("Ten_phan_bo") = "Khoa " & dvLop.Item(k)("Ten_khoa") & " Chuyên ngành " & dvLop.Item(k)("Chuyen_nganh")
                                    dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                    dr("So_tien") = 0
                                    dr("ID_lop") = dvLop.Item(k)("ID_lop")
                                    ' Danh sách sinh viên trợ cấp
                                    Dim dtTroCap As DataTable
                                    Dim objQ As New QuyHocBongPhanBo_Bussines
                                    dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                    dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        Next
                    Next
                ElseIf Not Khoa And Khoa_hoc And Nganh Then ' TH7 Phân theo Khóa học và chuyên ngành
                    Dim dtKhoaHoc As DataTable
                    Dim dtN As DataTable
                    dtKhoaHoc = objLop.Khoa_hoc()
                    dtN = objLop.Nganh_dao_tao(ID_he)
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                        For j As Integer = 0 To dtN.Rows.Count - 1
                            For k As Integer = 0 To dvLop.Count - 1
                                If dtKhoaHoc.Rows(i)("Khoa_hoc") = dvLop.Item(k)("Khoa_hoc") And dtN.Rows(j)("ID_nganh") = dvLop.Item(k)("ID_nganh") And dvLop.Item(k)("Khoa_hoc") >= Tu_khoa And dvLop.Item(k)("Khoa_hoc") <= Den_khoa Then
                                    dr = dt.NewRow
                                    dtSV = dvSV.Table.Copy
                                    dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(k)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                    dr("Ten_phan_bo") = "Khóa học " & dvLop.Item(k)("Khoa_hoc") & " Ngành " & dvLop.Item(k)("Ten_nganh")
                                    dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                    dr("So_tien") = 0
                                    dr("ID_lop") = dvLop.Item(k)("ID_lop")
                                    ' Danh sách sinh viên trợ cấp
                                    Dim dtTroCap As DataTable
                                    Dim objQ As New QuyHocBongPhanBo_Bussines
                                    dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                    dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        Next
                    Next
                ElseIf Not Khoa And Khoa_hoc And Chuyen_nganh Then ' TH7 Phân theo Khóa học và chuyên ngành
                    Dim dtKhoaHoc As DataTable
                    Dim dtCN As DataTable
                    dtKhoaHoc = objLop.Khoa_hoc()
                    dtCN = objLop.Chuyen_nganh_dao_tao()
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                        For j As Integer = 0 To dtCN.Rows.Count - 1
                            For k As Integer = 0 To dvLop.Count - 1
                                If dtKhoaHoc.Rows(i)("Khoa_hoc") = dvLop.Item(k)("Khoa_hoc") And dtCN.Rows(j)("ID_chuyen_nganh") = dvLop.Item(k)("ID_chuyen_nganh") And dvLop.Item(k)("Khoa_hoc") >= Tu_khoa And dvLop.Item(k)("Khoa_hoc") <= Den_khoa Then
                                    dr = dt.NewRow
                                    dtSV = dvSV.Table.Copy
                                    dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(k)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                    dr("Ten_phan_bo") = "Khóa học " & dvLop.Item(k)("Khoa_hoc") & " Chuyên ngành " & dvLop.Item(k)("Chuyen_nganh")
                                    dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                    dr("So_tien") = 0
                                    dr("ID_lop") = dvLop.Item(k)("ID_lop")
                                    ' Danh sách sinh viên trợ cấp
                                    Dim dtTroCap As DataTable
                                    Dim objQ As New QuyHocBongPhanBo_Bussines
                                    dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                    dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        Next
                    Next
                ElseIf Khoa And Khoa_hoc And Nganh Then ' TH8 Phân theo Khoa , khóa học và chuyên ngành
                    Dim dtKhoa As DataTable
                    Dim dtKhoaHoc As DataTable
                    Dim dtN As DataTable
                    dtKhoa = objLop.Khoa()
                    dtKhoaHoc = objLop.Khoa_hoc()
                    dtN = objLop.Nganh_dao_tao(ID_he)
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        For j As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                            For k As Integer = 0 To dtN.Rows.Count - 1
                                For l As Integer = 0 To dvLop.Count - 1
                                    If dtKhoa.Rows(i)("ID_khoa") = dvLop.Item(l)("ID_khoa") And dtKhoaHoc.Rows(j)("Khoa_hoc") = dvLop.Item(l)("Khoa_hoc") And dtN.Rows(k)("ID_nganh") = dvLop.Item(l)("ID_nganh") And dvLop.Item(l)("Khoa_hoc") >= Tu_khoa And dvLop.Item(l)("Khoa_hoc") <= Den_khoa Then
                                        dr = dt.NewRow
                                        dtSV = dvSV.Table.Copy
                                        dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(l)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                        dr("Ten_phan_bo") = "Khoa " & dvLop(l)("Ten_khoa") & "Khóa học " & dvLop.Item(l)("Khoa_hoc") & " Ngành " & dvLop.Item(l)("Ten_nganh")
                                        dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                        dr("So_tien") = 0
                                        dr("ID_lop") = dvLop.Item(l)("ID_lop")
                                        ' Danh sách sinh viên trợ cấp
                                        Dim dtTroCap As DataTable
                                        Dim objQ As New QuyHocBongPhanBo_Bussines
                                        dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                        dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                        dt.Rows.Add(dr)
                                    End If
                                Next
                            Next
                        Next
                    Next
                ElseIf Khoa And Khoa_hoc And Chuyen_nganh Then ' TH8 Phân theo Khoa , khóa học và chuyên ngành
                    Dim dtKhoa As DataTable
                    Dim dtKhoaHoc As DataTable
                    Dim dtCN As DataTable
                    dtKhoa = objLop.Khoa()
                    dtKhoaHoc = objLop.Khoa_hoc()
                    dtCN = objLop.Chuyen_nganh_dao_tao()
                    Dim dtSV As DataTable
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        For j As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                            For k As Integer = 0 To dtCN.Rows.Count - 1
                                For l As Integer = 0 To dvLop.Count - 1
                                    If dtKhoa.Rows(i)("ID_khoa") = dvLop.Item(l)("ID_khoa") And dtKhoaHoc.Rows(j)("Khoa_hoc") = dvLop.Item(l)("Khoa_hoc") And dtCN.Rows(k)("ID_chuyen_nganh") = dvLop.Item(l)("ID_chuyen_nganh") And dvLop.Item(l)("Khoa_hoc") >= Tu_khoa And dvLop.Item(l)("Khoa_hoc") <= Den_khoa Then
                                        dr = dt.NewRow
                                        dtSV = dvSV.Table.Copy
                                        dtSV.DefaultView.RowFilter = "ID_lop=" & dvLop.Item(l)("ID_lop") ' Lọc để tính tổng sv theo lớp
                                        dr("Ten_phan_bo") = "Khoa " & dvLop(l)("Ten_khoa") & "Khóa học " & dvLop.Item(l)("Khoa_hoc") & " Chuyên ngành " & dvLop.Item(l)("Chuyen_nganh")
                                        dr("So_sv") = dtSV.DefaultView.Count  ' Số sinh viên cả khoa
                                        dr("So_tien") = 0
                                        dr("ID_lop") = dvLop.Item(l)("ID_lop")
                                        ' Danh sách sinh viên trợ cấp
                                        Dim dtTroCap As DataTable
                                        Dim objQ As New QuyHocBongPhanBo_Bussines
                                        dtTroCap = objQ.DanhSach_TroCap(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dvLop.Item(i)("ID_lop"))
                                        dr("So_sv_tro_cap_xh") = dtTroCap.DefaultView.Count
                                        dt.Rows.Add(dr)
                                    End If
                                Next
                            Next
                        Next
                    Next
                End If
            End If
            Return dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Sub Fill_Combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable
        dt = clsDM.DanhMuc_Load("ACC_LoaiQuy", "ID_quy", "Loai_quy")
        FillCombo(cmbID_quy, dt)
        Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        dt = clsLop.He_dao_tao()
        FillCombo(cmbID_he, dt)
    End Sub
    Private Sub HienThi_ESSDataQuyHocBong(ByVal quy_hb As ESSQuyHocBong)
        Try
            txtSotien.Text = Format(quy_hb.Sotien_ngansach + quy_hb.Sotien_khac, "###,##0")
            ' Load dữ liệu phân bổ quỹ học bổng 
            Dim quy_hb_pb As New ESSQuyHocBongPhanBo
            Dim objPhanBo As New QuyHocBongPhanBo_Bussines(quy_hb.ID_hb)
            Dim dt As DataTable
            dt = objPhanBo.DanhSach_QuyHocBongPhanBo()
            grdViewPhanBo.DataSource = dt.DefaultView
            ' Số tiền đã cấp
            Dim SoTien_DaCap As Double = 0
            For i As Integer = 0 To dt.Rows.Count - 1
                SoTien_DaCap += dt.Rows(i)("So_tien")
            Next
            txtSotien_dacap.Text = Format(SoTien_DaCap, "###,##0")
            ' Số tiền còn lại
            Dim SoTien_ConLai As Double = CDbl(txtSotien.Text) - SoTien_DaCap
            If SoTien_ConLai < 0 Then
                txtSotien_conlai.Text = 0
            Else
                txtSotien_conlai.Text = Format(txtSotien.Text - SoTien_DaCap, "###,##0") ' Số tiền còn lại
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra phân bổ quỹ theo đối tượng gì
        If chkKhoa.Checked = False And chkKhoa_hoc.Checked = False And chkNganh.Checked = False And chkLop.Checked = False Then
            Call SetErrPro(chkKhoa, ErrorProvider1, "Bạn hãy chọn ít nhất là phân bổ theo khoa hoặc khóa học hoặc chuyên ngành hoặc lớp học !")
            If CtrlErr Is Nothing Then CtrlErr = chkKhoa
        End If
        ' Kiểm tra số tiền phân bổ
        If txtSotien_conlai.Text = 0 Then
            Call SetErrPro(txtSotien_conlai, ErrorProvider1, "Số tiền để phân đã hết !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_conlai
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