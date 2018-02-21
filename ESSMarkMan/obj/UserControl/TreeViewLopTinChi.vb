Imports ThienAn.BLL.Business
Imports ThienAn.Entity.Entity
Public Class TreeViewLopTinChi
#Region "Var"
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mID_mon_tc_thi As Integer = 0
    Private mTen_mon As String = ""
    Private mID_lop_tc As Integer
    Private mTen_lop_tc As String = ""
    Private Loader As Boolean = False
    Private mNode As New TreeNode
    Private clsMonTC As MonTinChi_BLL
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
        Dim objLTC As LopTinChi
        mNode.BackColor = trvLop.BackColor
        mNode = e.Node
        mNode.BackColor = System.Drawing.Color.DeepSkyBlue
        e.Node.BackColor = Color.FromArgb(100, 0, 102, 204)
        objLTC = CType(e.Node.Tag, LopTinChi)
        ID_lop_tc = objLTC.ID_lop_tc
        ID_mon = objLTC.ID_mon
        ID_mon_tc = objLTC.ID_mon_tc
        Ten_lop_tc = objLTC.Ten_lop_tc
        Ten_mon = objLTC.Ten_mon
        RaiseEvent TreeNodeSelected_()
    End Sub
    Private Sub cmbKy_dang_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKy_dang_ky.SelectedIndexChanged
        If Loader Then
            Dim Ky_dang_ky As Integer = cmbKy_dang_ky.SelectedValue
            Dim dtLopTC As DataTable
            If Ky_dang_ky > 0 Then
                If gobjUser.UserName.ToUpper = "DAOTAO" Or gobjUser.UserName.ToUpper = "ADMIN" Then
                    clsMonTC = New MonTinChi_BLL(Ky_dang_ky)
                Else
                    clsMonTC = New MonTinChi_BLL(Ky_dang_ky, gobjUser.UserID)
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

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            Dim clsDM As New DanhMuc_BLL
            Dim dt As New DataTable
            Dim strSQL As String
            If cmbID_he.Text.Trim <> "" Then
                strSQL = "SELECT DISTINCT a.Ky_dang_ky, N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' AS Ten_dot_dk FROM tkbHocKyDangKy a INNER JOIN tkbMonTinChi b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN tkbPhamViDangKy c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "WHERE ID_he=" & cmbID_he.SelectedValue
            Else
                strSQL = "SELECT Ky_dang_ky, N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' FROM tkbHocKyDangKy"
            End If
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbKy_dang_ky, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

#Region "Function"
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_BLL
            Dim dt As New DataTable
            Dim strSQL As String
            strSQL = "SELECT ID_he,Ten_he FROM svHe"
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TreeView_Lop(ByVal trvLop As TreeView, ByVal dtLop As DataTable, Optional ByVal ExpanAll As Boolean = False)
        trvLop.Nodes.Clear()
        Dim dr As DataRow
        Dim ID_He As Integer = -1, ID_Khoa As Integer = -1, Ky_hieu_lop_tc As String = ""
        Dim i As Integer = -1, j As Integer = -1, k As Integer = -1, l As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        Dim objLopTC As LopTinChi
        For Each dr In dtLop.Rows
            If ID_He = dr.Item("ID_he") Then
Khoa:
                If ID_Khoa = dr.Item("ID_khoa") Then
MonHocTinChi:
                    If Ky_hieu_lop_tc = dr.Item("Ky_hieu_lop_tc") Then
LopTinChi:
                        objLopTC = New LopTinChi
                        objLopTC.ID_lop_tc = dr.Item("ID_lop_tc")
                        objLopTC.ID_mon = dr.Item("ID_mon")
                        objLopTC.ID_mon_tc = dr.Item("ID_mon_tc")
                        objLopTC.Ten_lop_tc = dr.Item("Ten_lop_tc")
                        objLopTC.Ten_mon = dr.Item("Ten_mon")

                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Item(k).Nodes.Add("Lớp: " & dr.Item("Ten_lop_tc").ToString)
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Tag = objLopTC
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).ImageIndex = 6
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).SelectedImageIndex = 7
                        l += 1
                    Else 'Add node 2, Khoa
                        k += 1
                        objLopTC = New LopTinChi
                        objLopTC.ID_lop_tc = 0
                        objLopTC.ID_mon = dr.Item("ID_mon")
                        objLopTC.ID_mon_tc = dr.Item("ID_mon_tc")
                        objLopTC.Ten_lop_tc = ""
                        objLopTC.Ten_mon = dr.Item("Ten_mon")

                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Add(dr.Item("Ten_mon").ToString & "(" & dr.Item("Ky_hieu_lop_tc").ToString & ")")
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Tag = objLopTC
                        trvLop.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 4
                        trvLop.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 5
                        l = 0
                        'Add node 3, Chuyen nganh
                        GoTo LopTinChi
                    End If
                Else 'Add node 1, Khoa hoc
                    j = j + 1
                    objLopTC = New LopTinChi
                    trvLop.Nodes.Item(i).Nodes.Add("Khoa: " & dr.Item("Ten_khoa"))
                    trvLop.Nodes(i).Nodes(j).Tag = objLopTC
                    trvLop.Nodes(i).Nodes(j).ImageIndex = 2
                    trvLop.Nodes(i).Nodes(j).SelectedImageIndex = 3
                    k = -1
                    Ky_hieu_lop_tc = ""
                    'Add node 3, Khoa 
                    GoTo MonHocTinChi
                End If
            Else 'Add node 0, He
                i = i + 1
                objLopTC = New LopTinChi
                trvLop.Nodes.Add("Hệ: " & dr.Item("Ten_he"))
                trvLop.Nodes(i).Tag = objLopTC
                trvLop.Nodes.Item(i).ImageIndex = 0
                trvLop.Nodes.Item(i).SelectedImageIndex = 1
                j = -1
                ID_Khoa = -1
                GoTo Khoa
                End If
            ID_He = dr.Item("ID_he")
            ID_Khoa = dr.Item("ID_khoa")
            Ky_hieu_lop_tc = dr.Item("Ky_hieu_lop_tc")
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
#End Region
End Class
