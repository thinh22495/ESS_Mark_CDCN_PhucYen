Imports ESS.Bussines
Imports ESS.Objects
Public Class TreeViewLopTinChi
#Region "Var"
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mID_mon_tc_thi As Integer = 0
    Private mTen_he As String = ""
    Private mTen_mon As String = ""
    Private mKhoa_hoc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mdsID_lop_tc As String = ""
    Private mTen_lop_tc As String = ""
    Private mPhong_hoc As String = ""
    Private mSo_tc As String = ""
    Private Loader As Boolean = False
    Private mNode As New TreeNode
    Private clsMonTC As MonTinChi_Bussines
    Private mSo_tiet_lt As String = ""
    Private mSo_tiet_th As String = ""
#End Region

#Region "Events"
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Event TreeNodeSelected_()
    Public Sub ReLoad()
        Call cmbKy_dang_ky_SelectedIndexChanged(Nothing, Nothing)
    End Sub
#End Region

#Region "Event Control"
    Private Sub TreeViewLopTinChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        Loader = True
    End Sub
    Private Sub trvLop_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvLop.AfterSelect
        If e.Node Is Nothing Then Exit Sub
        Dim objLTC As ESSLopTinChi
        mNode.BackColor = trvLop.BackColor
        mNode = e.Node
        mNode.BackColor = System.Drawing.Color.DeepSkyBlue
        e.Node.BackColor = Color.FromArgb(100, 0, 102, 204)
        objLTC = CType(e.Node.Tag, ESSLopTinChi)
        ID_lop_tc = objLTC.ID_lop_tc
        ID_mon = objLTC.ID_mon
        ID_mon_tc = objLTC.ID_mon_tc
        Ten_lop_tc = objLTC.Ky_hieu_lop_tc
        Ten_mon = objLTC.Ten_mon
        Ten_he = objLTC.Ten_he
        mSo_tc = objLTC.So_hoc_trinh.ToString
        mSo_tiet_lt = objLTC.Ly_thuyet.ToString
        mSo_tiet_th = objLTC.Thuc_hanh.ToString
        mPhong_hoc = objLTC.Ten_phong
        If e.Node.Level = 2 Then
            mdsID_lop_tc = ""
            If e.Node.Nodes.Count > 0 Then
                For Each node As TreeNode In e.Node.Nodes
                    mdsID_lop_tc += CType(node.Tag, ESSLopTinChi).ID_lop_tc & "," & CType(node.Tag, ESSLopTinChi).Ten_lop_tc & ","
                Next
            Else
                mdsID_lop_tc = ""
            End If
        ElseIf e.Node.Level = 3 Then
            mdsID_lop_tc = ID_lop_tc.ToString & "," & Ten_lop_tc
        Else
            mdsID_lop_tc = ""
        End If
        dsID_lop_tc = mdsID_lop_tc
        RaiseEvent TreeNodeSelected_()
    End Sub
    Private Sub cmbKy_dang_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKy_dang_ky.SelectedIndexChanged
        If Loader Then
            Dim Ky_dang_ky As Integer = cmbKy_dang_ky.SelectedValue
            Dim dtLopTC As DataTable
            If Ky_dang_ky > 0 Then

                If gobjUser.UserName.ToUpper = "DAOTAO" Or gobjUser.UserName.ToUpper = "ADMIN" Or Kiem_tra_AdminUser() Or (gobjUser.ID_phong = 1 And gobjUser.ID_Bomon <= 0) Then
                    'Or gobjUser.UserName.ToUpper.Split(".").GetValue(0) = "KHOA"
                    clsMonTC = New MonTinChi_Bussines(Ky_dang_ky)
                Else
                    clsMonTC = New MonTinChi_Bussines(Ky_dang_ky, gobjUser.ID_Bomon, gobjUser.ID_khoa, gobjUser.UserName)
                End If
                mHoc_ky = clsMonTC.Hoc_ky
                mNam_hoc = clsMonTC.Nam_hoc
                If ID_mon_tc_thi > 0 Then
                    dtLopTC = clsMonTC.DanhSachMonLopTinChi(ID_mon_tc_thi)
                Else
                    dtLopTC = clsMonTC.DanhSachMonLopTinChi
                End If
                TreeView_Lop(trvLop, dtLopTC)
            Else
                trvLop.Nodes.Clear()
            End If
        End If
    End Sub

    Private Function Kiem_tra_AdminUser() As Boolean
        For i As Integer = 0 To gobjUser.ESSVaiTro.Count - 1
            If gobjUser.ESSVaiTro.ESSVaiTro(i).ID_vai_tro = 1 Then Return True
        Next
        Return False
    End Function
#End Region

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub TreeView_Lop(ByVal trvLop As TreeView, ByVal dtLop As DataTable, Optional ByVal ExpanAll As Boolean = False)
        trvLop.Nodes.Clear()
        Dim ID_He As Integer = -1, ID_Khoa As Integer = -1, Ky_hieu_lop_tc As String = ""
        Dim i As Integer = -1, j As Integer = -1, k As Integer = -1, l As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        Dim objLopTC As ESSLopTinChi
        Dim dv As DataView = dtLop.DefaultView
        dv.Sort = "ID_he,ID_khoa"
        For h As Integer = 0 To dv.Count - 1
            If ID_He = dv.Item(h)("ID_he") Then
Khoa:
                If ID_Khoa = dv.Item(h)("ID_khoa") Then
MonHocTinChi:
                    If Ky_hieu_lop_tc = dv.Item(h)("Ky_hieu_lop_tc") Then
LopTinChi:
                        objLopTC = New ESSLopTinChi
                        objLopTC.ID_lop_tc = dv.Item(h)("ID_lop_tc")
                        objLopTC.ID_mon = dv.Item(h)("ID_mon")
                        objLopTC.ID_mon_tc = dv.Item(h)("ID_mon_tc")
                        objLopTC.Ten_lop_tc = dv.Item(h)("Ten_lop_tc")
                        objLopTC.Ten_mon = dv.Item(h)("Ten_mon") + "|" + dv.Item(h)("Ky_hieu") + "|" + dv.Item(h)("So_hoc_trinh").ToString
                        objLopTC.Ten_he = dv.Item(h)("Ten_he")
                        objLopTC.Khoa_hoc = dv.Item(h)("Khoa_hoc")
                        objLopTC.So_hoc_trinh = dv.Item(h)("So_hoc_trinh")

                        'objLopTC.So_hoc_trinh = dv.Item(h)("So_hoc_trinh")
                        'objLopTC.Ten_phong = dv.Item(h)("Phong_hoc")

                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Item(k).Nodes.Add("Lớp: " & dv.Item(h)("Ten_lop_tc").ToString)
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Tag = objLopTC
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).ImageIndex = 6
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).SelectedImageIndex = 7
                        l += 1
                    Else 'Add node 2, ESSKhoa
                        k += 1
                        objLopTC = New ESSLopTinChi
                        objLopTC.ID_lop_tc = 0
                        objLopTC.ID_mon = dv.Item(h)("ID_mon")
                        objLopTC.ID_mon_tc = dv.Item(h)("ID_mon_tc")
                        objLopTC.Ten_lop_tc = ""
                        objLopTC.Ten_mon = dv.Item(h)("Ten_mon") + "|" + dv.Item(h)("Ky_hieu") + "|" + dv.Item(h)("So_hoc_trinh").ToString
                        objLopTC.Ten_he = dv.Item(h)("Ten_he")
                        objLopTC.Khoa_hoc = dv.Item(h)("Khoa_hoc")
                        'objLopTC.So_hoc_trinh = dv.Item(h)("So_hoc_trinh")
                        'objLopTC.Ten_phong = dv.Item(h)("Phong_hoc")

                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Add(dv.Item(h)("Ten_mon").ToString & "(" & dv.Item(h)("Ky_hieu_lop_tc").ToString & ")")
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Tag = objLopTC
                        trvLop.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 4
                        trvLop.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 5
                        l = 0
                        'Add node 3, Chuyen nganh
                        GoTo LopTinChi
                    End If
                Else 'Add node 1, ESSKhoa hoc
                    j = j + 1
                    objLopTC = New ESSLopTinChi
                    trvLop.Nodes.Item(i).Nodes.Add("Khoa: " & dv.Item(h)("Ten_khoa"))
                    trvLop.Nodes(i).Nodes(j).Tag = objLopTC
                    trvLop.Nodes(i).Nodes(j).ImageIndex = 2
                    trvLop.Nodes(i).Nodes(j).SelectedImageIndex = 3
                    k = -1
                    Ky_hieu_lop_tc = ""
                    'Add node 3, ESSKhoa 
                    GoTo MonHocTinChi
                End If
            Else 'Add node 0, He
                i = i + 1
                objLopTC = New ESSLopTinChi
                trvLop.Nodes.Add("Hệ: " & dv.Item(h)("Ten_he"))
                trvLop.Nodes(i).Tag = objLopTC
                trvLop.Nodes.Item(i).ImageIndex = 0
                trvLop.Nodes.Item(i).SelectedImageIndex = 1
                j = -1
                ID_Khoa = -1
                GoTo Khoa
            End If
            ID_He = dv.Item(h)("ID_he")
            Ten_he = dv.Item(h)("Ten_he")
            Khoa_hoc = dv.Item(h)("Khoa_hoc")

            ID_Khoa = dv.Item(h)("ID_khoa")
            Ky_hieu_lop_tc = dv.Item(h)("Ky_hieu_lop_tc")
        Next
    End Sub
#End Region

#Region "Property"
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
    Public Property ID_mon_tc() As Integer
        Get
            Return mID_mon_tc
        End Get
        Set(ByVal value As Integer)
            mID_mon_tc = value
        End Set
    End Property
    Public Property ID_mon() As Integer
        Get
            Return mID_mon
        End Get
        Set(ByVal value As Integer)
            mID_mon = value
        End Set
    End Property
    Public Property ID_mon_tc_thi() As Integer
        Get
            Return mID_mon_tc_thi
        End Get
        Set(ByVal value As Integer)
            mID_mon_tc_thi = value
        End Set
    End Property
    Public Property Ten_mon() As String
        Get
            Return mTen_mon
        End Get
        Set(ByVal value As String)
            mTen_mon = value
        End Set
    End Property
    Public Property ID_lop_tc() As Integer
        Get
            Return mID_lop_tc
        End Get
        Set(ByVal value As Integer)
            mID_lop_tc = value
        End Set
    End Property
    Public Property Ten_lop_tc() As String
        Get
            Return mTen_lop_tc
        End Get
        Set(ByVal value As String)
            mTen_lop_tc = value
        End Set
    End Property
    Public Property dsID_lop_tc() As String
        Get
            Return mdsID_lop_tc
        End Get
        Set(ByVal value As String)
            mdsID_lop_tc = value
        End Set
    End Property
    Public ReadOnly Property Phong_hoc() As String
        Get
            Return mPhong_hoc
        End Get
    End Property
    Public ReadOnly Property So_hoc_trinh() As String
        Get
            Return mSo_tc
        End Get
    End Property
    Public ReadOnly Property So_tiet_lt() As String
        Get
            Return mSo_tiet_lt
        End Get
    End Property
    Public ReadOnly Property So_tiet_th() As String
        Get
            Return mSo_tiet_th
        End Get
    End Property
    Public Property Ten_he() As String
        Get
            Return mTen_he
        End Get
        Set(ByVal value As String)
            mTen_he = value
        End Set
    End Property

    Public Property Khoa_hoc() As Integer
        Get
            Return mKhoa_hoc
        End Get
        Set(ByVal value As Integer)
            mKhoa_hoc = value
        End Set
    End Property

#End Region

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If cmbNam_hoc.Text = "" Or cmbHoc_ky.Text = "" Or cmbID_he.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim strSQL As String
            If cmbID_he.Text.Trim <> "" Then
                strSQL = "SELECT DISTINCT a.Ky_dang_ky,Dot AS Ten_dot_dk FROM PLAN_HocKyDangKy_TC a INNER JOIN PLAN_MonTinChi_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "WHERE ID_he=" & cmbID_he.SelectedValue & " AND hoc_ky=" & cmbHoc_ky.Text & " AND Nam_hoc='" & cmbNam_hoc.Text & "'"
            Else
                strSQL = "SELECT Ky_dang_ky, Dot  AS Ten_dot_dk FROM PLAN_HocKyDangKy_TC"
            End If
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbKy_dang_ky, dt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbNam_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If cmbNam_hoc.Text = "" Or cmbHoc_ky.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim strSQL As String
            strSQL = "SELECT DISTINCT  c.ID_he,Ten_he FROM PLAN_HocKyDangKy_TC a " & _
                        " INNER JOIN PLAN_MonTinChi_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "INNER JOIN STU_HE d ON c.ID_he=d.ID_he " & _
                       "WHERE hoc_ky=" & cmbHoc_ky.Text & " AND Nam_hoc='" & cmbNam_hoc.Text & "'"
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
        End Try
    End Sub
End Class
