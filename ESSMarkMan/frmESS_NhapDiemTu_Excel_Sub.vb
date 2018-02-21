Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_NhapDiemTu_Excel_Sub
    Private clsDiem As New Diem_Bussines

    Private Sub frmESS_NhapDiemExcel_Sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmESS_NhapDiemExcel_Sub_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dt As DataTable = grdViewDiem_MoiTonTai.DataSource
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i).Item("Chon") = optAll.Checked
        Next
        grdViewDiem_MoiTonTai.DataSource = dt
    End Sub


    Private Sub cmdDongBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDongBo.Click
        Dim dt_diemtontai As DataTable = grdViewDiem_TonTai.DataSource
        Dim dt_diemMoitontai As DataTable = grdViewDiem_MoiTonTai.DataSource
        Dim dt_diemtontai_Sub As DataTable = dt_diemtontai.Copy
        Dim dt_diemMoitontai_Sub As DataTable = dt_diemMoitontai.Copy
        Dim Check_DiemLock As Boolean = False

        For i As Integer = 0 To dt_diemMoitontai.Rows.Count - 1
            If dt_diemMoitontai.Rows(i).Item("Chon") = True Then
                For j As Integer = 0 To dt_diemtontai.Rows.Count - 1
                    If dt_diemMoitontai.Rows(i).Item("Ma_sv") = dt_diemtontai.Rows(j).Item("Ma_sv") Then
                        If dt_diemtontai.Rows(j).Item("Locked") = 1 Then Check_DiemLock = True
                        'Update lai Diem; neu ID_thanh_phan <>0 thi Update Diem thanh phan nguoc lai thi Update Diem thi
                        If dt_diemtontai.Rows(j).Item("ID_thanh_phan").ToString <> 0 Then
                            Dim objDiemTP As New ESSDiemThanhPhan
                            objDiemTP.ID_thanh_phan = dt_diemtontai.Rows(j).Item("ID_thanh_phan")
                            objDiemTP.Ty_le = dt_diemtontai.Rows(j).Item("Ty_le")
                            objDiemTP.Diem = dt_diemMoitontai.Rows(i).Item("Diem")
                            objDiemTP.Hoc_ky_TP = dt_diemtontai.Rows(j).Item("Hoc_ky_TP")
                            objDiemTP.Nam_hoc_TP = dt_diemtontai.Rows(j).Item("Nam_hoc_TP")


                            objDiemTP.Hash_code = (dt_diemtontai.Rows(j).Item("ID_diem_main").ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                            objDiemTP.Locked = 0
                            'Update diem thanh phan
                            clsDiem.CapNhat_ESSDiemThanhPhan(objDiemTP, dt_diemtontai.Rows(j).Item("ID_diem_main").ToString, dt_diemtontai.Rows(j).Item("ID_thanh_phan").ToString)
                        Else ' Là Điểm thi
                            Dim TBCMH As Double = 0
                            Dim DiemChu As String = ""
                            Dim objDiemThi As New ESSDiemThi
                            clsDiem.TinhTBCMH_DiemChu(dt_diemMoitontai.Rows(i).Item("ID_diem"), dt_diemMoitontai.Rows(i).Item("Diem"), TBCMH, DiemChu)

                            objDiemThi.Diem_thi = dt_diemMoitontai.Rows(i).Item("Diem").ToString
                            objDiemThi.Hoc_ky_thi = dt_diemMoitontai.Rows(j).Item("Hoc_ky_thi")
                            objDiemThi.Nam_hoc_thi = dt_diemMoitontai.Rows(j).Item("Nam_hoc_thi")
                            objDiemThi.TBCMH = TBCMH
                            objDiemThi.Diem_chu = DiemChu
                            objDiemThi.Hash_code = 0
                            objDiemThi.Locked = 0
                            objDiemThi.Ghi_chu = ""

                            clsDiem.CapNhat_ESSDiemThi(objDiemThi, dt_diemtontai.Rows(j).Item("ID_diem_main").ToString, dt_diemtontai.Rows(j).Item("Lan_thi").ToString)
                        End If
                        dt_diemMoitontai_Sub.Rows(i).Delete()
                        dt_diemtontai_Sub.Rows(j).Delete()
                    End If
                Next
            End If
        Next
        If Check_DiemLock Then
            Thongbao("Những sinh viên trên danh sách chưa được đồng bộ điểm là do điểm Học phần đang được khoá ", MsgBoxStyle.Information)
        Else
            Thongbao("Cập nhật thành công !", MsgBoxStyle.Information)
        End If
        dt_diemtontai_Sub.AcceptChanges()
        dt_diemMoitontai_Sub.AcceptChanges()
        grdViewDiem_TonTai.DataSource = dt_diemtontai_Sub
        grdViewDiem_MoiTonTai.DataSource = dt_diemMoitontai_Sub
        lblSV_Trung.Text = dt_diemMoitontai_Sub.Rows.Count
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim dt As DataTable = grdViewDiem_MoiChuan.DataSource

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim objDiem As New ESSDiem
            'Update lai Diem; neu ID_thanh_phan <>0 thi Update Diem thanh phan nguoc lai thi Update Diem thi
            If dt.Rows(i).Item("ID_thanh_phan").ToString <> 0 Then
                Dim objDiemTP As New ESSDiemThanhPhan
                'ID_diem_main = 0 thi chua ton tai diem Main
                'ID_diem_main = 0 thi Insert vao svDiem va svDiemThanhPhan
                'ID_diem_main <> 0 thi Insert vao svDiemThanhPhan theo ID_diem_main
                If dt.Rows(i).Item("ID_diem_main").ToString <> 0 Then
                    'Insert vao svDiemThanhPhan
                    objDiemTP.ID_thanh_phan = dt.Rows(i).Item("ID_thanh_phan")
                    objDiemTP.Ty_le = dt.Rows(i).Item("Ty_le")
                    objDiemTP.Diem = dt.Rows(i).Item("Diem")
                    objDiemTP.Hash_code = (dt.Rows(i).Item("ID_diem_main").ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                    objDiemTP.Locked = 0

                    objDiemTP.Hoc_ky_TP = dt.Rows(i).Item("Hoc_ky_TP")
                    objDiemTP.Nam_hoc_TP = dt.Rows(i).Item("Nam_hoc_TP")

                    clsDiem.ThemMoi_ESSDiemThanhPhan(dt.Rows(i).Item("ID_diem_main").ToString, objDiemTP)
                Else
                    'Insert vao svDiem
                    objDiem.Hoc_ky = dt.Rows(i).Item("Hoc_ky").ToString
                    objDiem.Nam_hoc = dt.Rows(i).Item("Nam_hoc").ToString
                    objDiem.ID_mon = dt.Rows(i).Item("ID_mon").ToString
                    objDiem.ID_dt = dt.Rows(i).Item("ID_dt").ToString
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dt.Rows(i).Item("ID_sv").ToString
                    objDiem.ID_diem = clsDiem.ThemMoi_ESSDiem(objDiem)


                    'Insert vao svDiemThanhPhan
                    objDiemTP.ID_thanh_phan = dt.Rows(i).Item("ID_thanh_phan")
                    objDiemTP.Ty_le = dt.Rows(i).Item("Ty_le")
                    objDiemTP.Diem = dt.Rows(i).Item("Diem")
                    objDiemTP.Hash_code = (objDiem.ID_diem.ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                    objDiemTP.Locked = 0


                    objDiemTP.Hoc_ky_TP = dt.Rows(i).Item("Hoc_ky_TP")
                    objDiemTP.Nam_hoc_TP = dt.Rows(i).Item("Nam_hoc_TP")

                    clsDiem.ThemMoi_ESSDiemThanhPhan(objDiem.ID_diem.ToString, objDiemTP)
                End If
            Else ' Là Điểm thi
                Dim objDiemThi As New ESSDiemThi
                'ID_diem_main = 0 thi chua ton tai diem Main
                'ID_diem_main = 0 thi Insert vao svDiem va svDiemThi
                'ID_diem_main <> 0 thi Insert vao svDiemThi theo ID_diem_main
                Dim TBCMH As Double = 0
                Dim DiemChu As String = ""
                If dt.Rows(i).Item("ID_diem_main").ToString <> 0 Then
                    clsDiem.TinhTBCMH_DiemChu(dt.Rows(i).Item("ID_diem_main"), dt.Rows(i).Item("Diem"), TBCMH, DiemChu)
                    'Insert vao svDiemThi
                    objDiemThi.Diem_thi = dt.Rows(i).Item("Diem").ToString
                    objDiemThi.Lan_thi = dt.Rows(i).Item("Lan_thi")
                    objDiemThi.TBCMH = TBCMH
                    objDiemThi.Diem_chu = DiemChu
                    objDiemThi.Hash_code = 0
                    objDiemThi.Locked = 0
                    objDiemThi.Ghi_chu = ""

                    objDiemThi.Hoc_ky_thi = dt.Rows(i).Item("Hoc_ky_thi")
                    objDiemThi.Nam_hoc_thi = dt.Rows(i).Item("Nam_hoc_thi")


                    clsDiem.ThemMoi_ESSDiemThi(dt.Rows(i).Item("ID_diem_main").ToString, objDiemThi)
                Else
                    'Insert vao svDiem
                    objDiem.Hoc_ky = dt.Rows(i).Item("Hoc_ky").ToString
                    objDiem.Nam_hoc = dt.Rows(i).Item("Nam_hoc").ToString
                    objDiem.ID_mon = dt.Rows(i).Item("ID_mon").ToString
                    objDiem.ID_dt = dt.Rows(i).Item("ID_dt").ToString
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dt.Rows(i).Item("ID_sv").ToString
                    objDiem.ID_diem = clsDiem.ThemMoi_ESSDiem(objDiem)

                    'Insert vao svDiemThi
                    clsDiem.TinhTBCMH_DiemChu(0, dt.Rows(i).Item("Diem"), TBCMH, DiemChu)
                    objDiemThi.Diem_thi = dt.Rows(i).Item("Diem").ToString
                    objDiemThi.Lan_thi = dt.Rows(i).Item("Lan_thi").ToString
                    objDiemThi.TBCMH = TBCMH
                    objDiemThi.Diem_chu = DiemChu
                    objDiemThi.Hash_code = 0
                    objDiemThi.Locked = 0
                    objDiemThi.Ghi_chu = ""

                    objDiemThi.Hoc_ky_thi = dt.Rows(i).Item("Hoc_ky_thi")
                    objDiemThi.Nam_hoc_thi = dt.Rows(i).Item("Nam_hoc_thi")

                    clsDiem.ThemMoi_ESSDiemThi(objDiem.ID_diem, objDiemThi)
                End If
            End If
        Next
        Thongbao("Cập nhật thành công !", MsgBoxStyle.Information)
        dt.DefaultView.RowFilter = "1=0"
        grdViewDiem_MoiChuan.DataSource = dt.DefaultView.Table
        lblSV_NEW.Text = dt.DefaultView.Count
        cmdSave.Enabled = False
    End Sub
End Class