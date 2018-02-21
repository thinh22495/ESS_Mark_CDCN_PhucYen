Imports ESS.Bussines
Imports ESSUtility

Public Class ESSToolBarTC
#Region "Var"
    Private mdtLop As DataTable
    Private mID_he As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mKy_dang_ky As Integer = 0
    Private mChuyen_nganh_dang_ky As Integer = 1
    Private clsLop As Lop_Bussines
    Private loader As Boolean = False
#End Region

#Region "Events"
    Public Event ToolBarSelected_()
#End Region

#Region "Property"
    Public ReadOnly Property ID_he() As Integer
        Get
            Return mID_he
        End Get
    End Property
    Public ReadOnly Property Hoc_ky() As Integer
        Get
            Return mHoc_ky
        End Get
    End Property
    Public ReadOnly Property Nam_hoc() As String
        Get
            Return mNam_hoc
        End Get
    End Property




    Public ReadOnly Property Chuyen_nganh_dang_ky() As Integer
        Get
            Return mChuyen_nganh_dang_ky
        End Get
    End Property
    Public ReadOnly Property Ky_dang_ky() As Integer
        Get
            Return mKy_dang_ky
        End Get
    End Property

#End Region

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Dim dt As New DataTable
            Add_Hocky(cmbHoc_ky.ComboBox)
            Add_Namhoc(cmbNam_hoc.ComboBox)

            'Load combobox Hệ đào tạo
            clsLop = New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he.ComboBox, dt)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ESSToolBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadComboBox()
        cmbID_chuyen_nganh.ComboBox.SelectedIndex = 0
        loader = True
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged
        Try
            If loader Then
                Dim clsDM As New DanhMuc_Bussines
                Dim dt As New DataTable
                Dim strSQL As String
                If cmbID_he.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" Then

                    strSQL = "SELECT DISTINCT a.Ky_dang_ky,N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' AS Ten_dot_dk FROM PLAN_HocKyDangKy_TC a INNER JOIN PLAN_MonTinChi_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                          "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                          "WHERE ID_he=" & cmbID_he.ComboBox.SelectedValue.ToString & " AND Hoc_ky=" & cmbHoc_ky.ComboBox.SelectedValue.ToString & " AND Nam_hoc='" & cmbNam_hoc.Text.Trim & "'"

                Else
                    strSQL = "SELECT Ky_dang_ky, N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' FROM PLAN_HocKyDangKy_TC"
                End If
                dt = clsDM.DanhMuc_Load(strSQL)
                FillCombo(cmbKy_dang_ky.ComboBox, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Public Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If loader Then
                If cmbID_he.ComboBox.SelectedValue > 0 Then mID_he = cmbID_he.ComboBox.SelectedValue
                mChuyen_nganh_dang_ky = cmbID_chuyen_nganh.SelectedIndex + 1
                If cmbHoc_ky.ComboBox.SelectedValue > 0 Then mHoc_ky = cmbHoc_ky.ComboBox.SelectedValue
                If cmbNam_hoc.ComboBox.Text <> "" Then mNam_hoc = cmbNam_hoc.ComboBox.Text
                If cmbKy_dang_ky.ComboBox.SelectedValue > 0 Then mKy_dang_ky = cmbKy_dang_ky.ComboBox.SelectedValue
                RaiseEvent ToolBarSelected_()
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Sub cmbKy_dang_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKy_dang_ky.SelectedIndexChanged
        Try
            If loader Then
                If cmbID_he.ComboBox.SelectedValue > 0 Then mID_he = cmbID_he.ComboBox.SelectedValue
                mChuyen_nganh_dang_ky = cmbID_chuyen_nganh.SelectedIndex + 1
                If cmbHoc_ky.ComboBox.SelectedValue > 0 Then mHoc_ky = cmbHoc_ky.ComboBox.SelectedValue
                If cmbNam_hoc.ComboBox.Text <> "" Then mNam_hoc = cmbNam_hoc.ComboBox.Text
                If cmbKy_dang_ky.ComboBox.SelectedValue > 0 Then mKy_dang_ky = cmbKy_dang_ky.ComboBox.SelectedValue
                RaiseEvent ToolBarSelected_()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub ESSToolBarTC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
End Class
