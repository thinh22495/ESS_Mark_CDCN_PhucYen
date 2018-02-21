Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_KhungChuongTrinhDaoTao_GanLop
    Private mID_he As Integer
    Private mID_khoa As Integer
    Private mKhoa_hoc As Integer
    Private mID_chuyen_nganh As Integer
    Private mID_dt As Integer
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_Bussines, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_dt As Integer)
        mID_he = ID_he
        mID_khoa = ID_khoa
        mKhoa_hoc = Khoa_hoc
        mID_chuyen_nganh = ID_chuyen_nganh
        mID_dt = ID_dt
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoChonMon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
            Dim dtLop As New DataTable
            dtLop = clsLop.Danh_sach_lop(mID_he, mID_khoa, mKhoa_hoc, mID_chuyen_nganh)
            'Đánh dấu lớp đã chọn
            Dim idx As Integer = -1
            idx = mclsCTDT.Tim_idx(mID_dt)
            If idx >= 0 Then
                For i As Integer = 0 To mclsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoLop.Count - 1
                    For j As Integer = 0 To dtLop.Rows.Count - 1
                        If mclsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoLop.ESSChuongTrinhDaoTaoLop(i).ID_lop = dtLop.Rows(j)("ID_lop") Then
                            dtLop.Rows(j)("Chon") = True

                        End If
                    Next
                Next
            End If

            grcLopGan.DataSource = dtLop.DefaultView
            'Set quyền truy cập chức năng
            SetQuyenTruyCap(cmdSave)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoGanLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub chkAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachLop As DataView
        dvDanhSachLop = grvLopGan.DataSource
        If Not dvDanhSachLop Is Nothing Then
            For i As Integer = 0 To dvDanhSachLop.Count - 1
                dvDanhSachLop.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dvLop As DataView = grvLopGan.DataSource
            Dim idx, idx1 As Integer
            idx = mclsCTDT.Tim_idx(mID_dt)
            For i As Integer = 0 To dvLop.Count - 1
                idx1 = mclsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoLop.Tim_idx(dvLop.Item(i)("ID_lop"))
                If dvLop.Item(i)("Chon") Then
                    'Bổ sung thêm lớp mới đã chọn
                    If idx1 = -1 Then
                        Dim objCTDTLop As New ESSChuongTrinhDaoTaoLop
                        objCTDTLop.ID_lop = dvLop.Item(i)("ID_lop")
                        mclsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoLop.Add(objCTDTLop)
                        'Update database
                        mclsCTDT.CapNhat_ESSChuongTrinhDaoTao_Lop(dvLop.Item(i)("ID_lop"), mID_dt)
                    End If
                Else
                    'Xoá bỏ lớp chọn
                    If idx1 >= 0 Then
                        mclsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoLop.Remove(idx1)
                        'Update database
                        mclsCTDT.CapNhat_ESSChuongTrinhDaoTao_Lop(dvLop.Item(i)("ID_lop"), 0)
                    End If
                End If
            Next
            'Save Log 
            Dim Noi_dung As String
            Noi_dung = "Gán lớp học của chương trình đào tạo"
            Noi_dung += " Hệ " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Ten_he
            Noi_dung += " Khoa " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Ten_khoa
            Noi_dung += " Khoá " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Khoa_hoc.ToString
            Noi_dung += " Chuyên ngành " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Chuyen_nganh
            SaveLog(LoaiSuKien.Xoa, Noi_dung)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class