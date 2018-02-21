Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmEDU_InTongHop
    Private Loader As Boolean = False
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""

    Public Overloads Sub ShowDialog(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        Me.ShowDialog()
    End Sub

    Private Sub frmEDU_InTongHop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadComboBox()
            Loader = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEDU_InTongHop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsDM.LoadDanhMuc("Select ID_he,Ten_he from  STU_He")
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_Bussines
                Dim dt As DataTable
                dt = cls.LoadDanhMuc("Select distinct ID_khoa,Ten_khoa from  STU_Khoa")
                FillCombo(cmbID_khoa, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_Bussines
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct l.Khoa_hoc,l.Khoa_hoc from  STU_Lop l where " & dk)
                FillCombo(cmbKhoa_hoc, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_Bussines
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And l.Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct cn.ID_chuyen_nganh,cn.Chuyen_nganh from  STU_Lop l inner join  STU_ChuyenNganh cn On l.ID_chuyen_nganh=cn.ID_chuyen_nganh where " & dk)
                FillCombo(cmbID_chuyen_nganh, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub lblTongHop_SoLuongSV_CanhBaoLan123_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblTongHop_SoLuongSV_CanhBaoLan123.LinkClicked
        Try
            Dim Tieu_de1 As String = "DANH SÁCH CẢNH BÁO KẾT QUẢ HỌC TẬP HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
            Dim Tieu_de2 As String = ""

            Dim clsDSXetLenLop As DanhSachXetLenLop_Bussines
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines
            Dim dk As String = " AND 1=1"
            If cmbID_he.Text.Trim <> "" Then
                dk = dk & " AND b.ID_he=" & cmbID_he.SelectedValue
                Tieu_de2 = Tieu_de2 & "HỆ: " & cmbID_he.Text.ToUpper
            End If
            If cmbID_khoa.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_khoa=" & cmbID_khoa.SelectedValue
                Tieu_de2 = Tieu_de2 & " KHOA: " & cmbID_khoa.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.Khoa_hoc=" & cmbKhoa_hoc.Text.Trim
                Tieu_de2 = Tieu_de2 & "   KHÓA: " & cmbKhoa_hoc.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                Tieu_de2 = Tieu_de2 & "   CHUYÊN NGÀNH: " & cmbID_chuyen_nganh.Text.ToUpper
            End If
            Dim dv As DataView = clsDSXetLenLop.TongHop_LanCanhBao(mHoc_ky, mNam_hoc, dk).DefaultView
            Dim rpt As New rptCanhCaoKetQuaHocTap(dv, Tieu_de1, Tieu_de2)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblTongHop_SoLuongSV_CanhBaoLan123_Khoa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblTongHop_SoLuongSV_CanhBaoLan123_Khoa.LinkClicked
        Try
            Dim Tieu_de1 As String = "DANH SÁCH CẢNH BÁO KẾT QUẢ HỌC TẬP HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
            Dim Tieu_de2 As String = ""

            Dim clsDSXetLenLop As DanhSachXetLenLop_Bussines
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines
            Dim dk As String = " AND 1=1"
            If cmbID_he.Text.Trim <> "" Then
                dk = dk & " AND b.ID_he=" & cmbID_he.SelectedValue
                Tieu_de2 = Tieu_de2 & "HỆ: " & cmbID_he.Text.ToUpper
            End If
            If cmbID_khoa.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_khoa=" & cmbID_khoa.SelectedValue
                Tieu_de2 = Tieu_de2 & " KHOA: " & cmbID_khoa.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.Khoa_hoc=" & cmbKhoa_hoc.Text.Trim
                Tieu_de2 = Tieu_de2 & "   KHÓA: " & cmbKhoa_hoc.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                Tieu_de2 = Tieu_de2 & "   CHUYÊN NGÀNH: " & cmbID_chuyen_nganh.Text.ToUpper
            End If
            Dim dv As DataView = clsDSXetLenLop.TongHop_LanCanhBao_Khoa(mHoc_ky, mNam_hoc, dk).DefaultView
            Dim rpt As New rptTongHopKetQuaCanhBao_Khoa(dv, Tieu_de1, Tieu_de2)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblTongHop_SoLuongSV_CanhBaoLan123_Lop_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblTongHop_SoLuongSV_CanhBaoLan123_Lop.LinkClicked
        Try
            Dim Tieu_de1 As String = "DANH SÁCH CẢNH BÁO KẾT QUẢ HỌC TẬP HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
            Dim Tieu_de2 As String = ""

            Dim clsDSXetLenLop As DanhSachXetLenLop_Bussines
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines
            Dim dk As String = " AND 1=1"
            If cmbID_he.Text.Trim <> "" Then
                dk = dk & " AND b.ID_he=" & cmbID_he.SelectedValue
                Tieu_de2 = Tieu_de2 & "HỆ: " & cmbID_he.Text.ToUpper
            End If
            If cmbID_khoa.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_khoa=" & cmbID_khoa.SelectedValue
                Tieu_de2 = Tieu_de2 & " KHOA: " & cmbID_khoa.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.Khoa_hoc=" & cmbKhoa_hoc.Text.Trim
                Tieu_de2 = Tieu_de2 & "   KHÓA: " & cmbKhoa_hoc.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                Tieu_de2 = Tieu_de2 & "   CHUYÊN NGÀNH: " & cmbID_chuyen_nganh.Text.ToUpper
            End If
            Dim dv As DataView = clsDSXetLenLop.TongHop_LanCanhBao_Lop(mHoc_ky, mNam_hoc, dk).DefaultView
            Dim rpt As New rptTongHopKetQuaCanhBao_TheoLop(dv, Tieu_de1, Tieu_de2)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblIn_DangSach_CanhBaoTheoLop_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblIn_DangSach_CanhBaoTheoLop1.LinkClicked
        Try
            Dim Tieu_de1 As String = "DANH SÁCH CẢNH BÁO KẾT QUẢ HỌC TẬP HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
            Dim Tieu_de2 As String = ""

            Dim clsDSXetLenLop As DanhSachXetLenLop_Bussines
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines
            Dim dk As String = " AND 1=1"
            If cmbID_he.Text.Trim <> "" Then
                dk = dk & " AND b.ID_he=" & cmbID_he.SelectedValue
                Tieu_de2 = Tieu_de2 & "HỆ: " & cmbID_he.Text.ToUpper
            End If
            If cmbID_khoa.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_khoa=" & cmbID_khoa.SelectedValue
                Tieu_de2 = Tieu_de2 & " KHOA: " & cmbID_khoa.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.Khoa_hoc=" & cmbKhoa_hoc.Text.Trim
                Tieu_de2 = Tieu_de2 & "   KHÓA: " & cmbKhoa_hoc.Text.ToUpper
            End If
            If cmbKhoa_hoc.Text.Trim <> "" Then
                dk = dk & " AND  b.ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                Tieu_de2 = Tieu_de2 & "   CHUYÊN NGÀNH: " & cmbID_chuyen_nganh.Text.ToUpper
            End If
            Dim dv As DataView = clsDSXetLenLop.TongHop_LanCanhBao_Lop(mHoc_ky, mNam_hoc, dk).DefaultView
            Dim rpt As New rptTongHopKetQuaCanhBao_ChiTiet_TheoLop(dv, Tieu_de1, Tieu_de2)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub
End Class