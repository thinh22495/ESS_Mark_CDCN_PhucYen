Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_KhungChuongTrinhDaoTao_LapMonChungChi
    Private mID_he As Integer
    Private mID_dt As Integer
    Private mdtCTDTChiChiet As DataTable
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Public Overloads Sub ShowDialog(ByRef clsCTDT As ChuongTrinhDaoTao_Bussines, ByVal ID_he As Integer, ByVal ID_dt As Integer, ByVal dtCTDTChiChiet As DataTable)
        mID_he = ID_he
        mID_dt = ID_dt
        mdtCTDTChiChiet = dtCTDTChiChiet
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            'Load combobox kiến thức
            dt = clsDM.DanhMuc_Load("PLAN_ChuongTrinhDaoTaoKienThuc", "ID_kien_thuc", "Ten_kien_thuc")
            FillCombo(cmbKien_thuc, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoChonMon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox
            LoadComboBox()
            'Load Học phần theo hệ đào tạo
            Reload()
            'Set quyền truy cập chức năng
            SetQuyenTruyCap(cmdSave, cmdAdd_Mon)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoChonMon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub


    Private Sub Reload()
        Dim clsMon As MonHoc_Bussines
        If chkAll.Checked Then
            clsMon = New MonHoc_Bussines()
        Else
            clsMon = New MonHoc_Bussines(mID_he)
        End If
        Dim dtHP As DataTable = clsMon.DanhSachHocPhan
        'Xoá các học phần đã chọn trong CTDT
        For i As Integer = 0 To mdtCTDTChiChiet.Rows.Count - 1
            For j As Integer = dtHP.Rows.Count - 1 To 0 Step -1
                If Not dtHP.Rows(j).RowState = DataRowState.Deleted Then
                    If mdtCTDTChiChiet.Rows(i)("ID_mon") = dtHP.Rows(j)("ID_mon") Then
                        dtHP.Rows(j).Delete()
                    End If
                End If
            Next
        Next
        dtHP.AcceptChanges()
        grcHocPhan.DataSource = dtHP.DefaultView
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Reload()
    End Sub



    Private Sub cmdAdd_Mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Mon.Click
        Try
            Dim objMonHoc_bll As New MonHoc_Bussines(mID_he)
            Dim objMonHoc As New ESSMonHoc
            Dim frmESS_ As New frmESS_HocPhan
            While True
                ' Hiển thị form MonHoc, lấy giá trị và insert
                frmESS_.ShowDialog(mID_he)
                If Not frmESS_.Thoat Then
                    objMonHoc = frmESS_.getValueFromUI()
                    If Not objMonHoc_bll.CheckExistKyHieu(objMonHoc.Ky_hieu, objMonHoc.ID_he) Then
                        objMonHoc_bll.ThemMoi_ESSMonHoc(objMonHoc)
                        Thongbao("Đã cập nhật thành công !", MsgBoxStyle.OkOnly)
                        Reload()
                        Exit While
                    Else
                        Thongbao("Ký hiệu mã Học phần cho hệ này đã được tạo rồi !", MsgBoxStyle.OkOnly)
                    End If
                Else
                    Exit While
                End If
            End While
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If cmbKien_thuc.SelectedValue >= 0 Then
                Dim dvHP As DataView = grvHocPhan.DataSource
                Dim idx As Integer = 0
                idx = mclsCTDT.Tim_idx(mID_dt)
                If idx >= 0 Then
                    For i As Integer = 0 To dvHP.Count - 1
                        If dvHP.Item(i)("Chon") Then
                            Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
                            objCTDTChiTiet.ID_dt = mID_dt
                            objCTDTChiTiet.Kien_thuc = cmbKien_thuc.SelectedValue
                            objCTDTChiTiet.He_so = 1
                            objCTDTChiTiet.ID_mon = dvHP.Item(i)("ID_mon")
                            objCTDTChiTiet.Ky_hieu = dvHP.Item(i)("Ky_hieu")
                            objCTDTChiTiet.Ten_mon = dvHP.Item(i)("Ten_mon")
                            Dim ID_dt_mon As Integer = 0
                            'Insert vao Database
                            ID_dt_mon = mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet)
                            objCTDTChiTiet.ID_dt_mon = ID_dt_mon
                            'Insert vao object
                            mclsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                        End If
                    Next
                End If
                Me.Tag = "1"
                Me.Close()
            Else
                Thongbao("Bạn hãy chọn loại kiến thức cho những học phần được chọn")
                cmbKien_thuc.Focus()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class