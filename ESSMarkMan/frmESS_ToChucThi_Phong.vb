Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ToChucThi_Phong
    Private mSo_sv_chua_xep, mSo_sv_da_xep As Integer
    Public dtPhongHoc As New DataTable
    Private Loader As Boolean = False

    Private Sub FormatGridviewLopTinChi(ByVal grdView As DataGridView)
        Dim col1 As New DataGridViewCheckBoxColumn
        With col1
            .Name = "Chon"
            .DataPropertyName = "Chon"
            .HeaderText = "Chọn"
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.NullValue = ""
            .ReadOnly = False
        End With
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .HeaderText = "Phòng học"
            .DataPropertyName = "Ten_phong_main"
            .Visible = True
            .ReadOnly = True
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        'End With
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .HeaderText = "Số sv"
            .DataPropertyName = "So_sv"
            .Visible = True
            .ReadOnly = False
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .HeaderText = "Sức chứa"
            .DataPropertyName = "Suc_chua"
            .Visible = True
            .ReadOnly = True
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        Dim col5 As New DataGridViewCheckBoxColumn
        With col5
            .Name = "Khong_thay_doi"
            .DataPropertyName = "Khong_thay_doi"
            .HeaderText = "Không thay đổi"
            .Width = 140
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.NullValue = ""
            .ReadOnly = False
        End With
        grdViewPhongThi.Columns.Clear()
        With grdView.Columns
            .Add(col1)
            .Add(col2)
            .Add(col3)
            .Add(col4)
            .Add(col5)
        End With
    End Sub

    Public Overloads Sub ShowDialog(ByVal dt As DataTable, ByVal So_sv_chua_xep As Integer, ByVal So_sv_da_xep As Integer)
        mSo_sv_chua_xep = So_sv_chua_xep
        mSo_sv_da_xep = So_sv_da_xep
        lblSo_sv.Text = mSo_sv_chua_xep
        lblSuc_chua.Text = mSo_sv_da_xep
        dtPhongHoc = dt.Copy
        grdViewPhongThi.DataSource = dtPhongHoc.DefaultView
        Me.ShowDialog()
    End Sub



    Private Sub frmESS_ToChucThiPhong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable = clsDM.DanhMuc_Load("PLAN_ToaNha", "ID_nha", "Ten_nha")
        FillCombo(cmbID_nha, dt)

        SetUpDataGridView(grdViewPhongThi)
        FormatGridviewLopTinChi(grdViewPhongThi)
        Loader = True
    End Sub

    Private Sub cmbID_nha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_nha.SelectedIndexChanged
        If Loader = False Then Exit Sub
        Try
            Dim clsPhongHoc As New PhongHoc_Bussines
            Dim So_sv_da_chon As Integer = 0
            Dim dv As DataView = grdViewPhongThi.DataSource
            dtPhongHoc = clsPhongHoc.DanhSachPhongThi_FillTer_TheoToaNha(dv, dtPhongHoc, So_sv_da_chon)
            lblSuc_chua.Text = So_sv_da_chon
            If cmbID_nha.Text <> "" Then dtPhongHoc.DefaultView.RowFilter = "ID_nha=" & cmbID_nha.SelectedValue
            grdViewPhongThi.DataSource = dtPhongHoc.DefaultView
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grdViewPhongThi_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewPhongThi.CellEndEdit
        Try
            'Dim Suc_chua As Integer = CType(lblSuc_chua.Text, Integer)
            Dim Suc_chua As Integer = 0
            Dim dv As DataView = grdViewPhongThi.DataSource
            For i As Integer = 0 To dv.Count - 1
                If Not grdViewPhongThi.CurrentCell.Value Is Nothing AndAlso grdViewPhongThi.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdViewPhongThi.CurrentCell.Value) Then
                    Thongbao("Bạn phải nhập số sinh viên là số !")
                    grdViewPhongThi.CurrentCell.Value = 0
                End If
                If dv.Item(i)("Chon") = True Then
                    If chkCheckSoSinhVien.Checked Then
                        If Suc_chua + dv.Item(i)("So_sv") > mSo_sv_chua_xep Then
                            dv.Item(i)("So_sv") = 0
                        End If
                        If dv.Item(i)("So_sv") > dv.Item(i)("Suc_chua") Then
                            dv.Item(i)("So_sv") = dv.Item(i)("Suc_chua")
                        End If
                        Suc_chua += dv.Item(i)("So_sv")
                    Else
                        If Suc_chua + dv.Item(i)("So_sv") > mSo_sv_chua_xep Then
                            dv.Item(i)("So_sv") = mSo_sv_chua_xep - Suc_chua
                        End If
                        Suc_chua += dv.Item(i)("So_sv")
                    End If

                End If
            Next

            Dim Suc_chua_nha As Integer = 0
            If cmbID_nha.Text <> "" Then
                Dim dt As New DataTable
                dt = dtPhongHoc.Copy
                dt.DefaultView.RowFilter = "ID_nha<>" & cmbID_nha.SelectedValue
                For i As Integer = 0 To dt.DefaultView.Count - 1
                    Suc_chua_nha += dt.DefaultView.Item(i)("So_sv")
                Next
            End If
            Suc_chua = Suc_chua + Suc_chua_nha
            lblSuc_chua.Text = Suc_chua

            lblSV_Con.Text = CType(lblSo_sv.Text, Integer) - Suc_chua
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdChon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChon.Click
        Dim clsPhongHoc As New PhongHoc_Bussines
        Dim dv As DataView = grdViewPhongThi.DataSource
        Dim So_sv_da_chon As Integer = 0
        dtPhongHoc = clsPhongHoc.DanhSachPhongThi_FillTer_TheoToaNha(dv, dtPhongHoc, So_sv_da_chon)
        lblSuc_chua.Text = So_sv_da_chon
        'Kiểm tra tổng số sinh viên của các phòng thi so với số sinh viên tổ chức thi
        If So_sv_da_chon < mSo_sv_chua_xep Then
            Thongbao("Tổng số sinh viên của các phòng thi nhỏ hơn số sinh viên tổ chức thi là" + mSo_sv_chua_xep.ToString + " (sv) .Bạn nhập lại số sinh viên / phòng thi!")
        Else
            Me.Tag = 1
            Me.Close()
        End If
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = 0
        Me.Close()
    End Sub
End Class