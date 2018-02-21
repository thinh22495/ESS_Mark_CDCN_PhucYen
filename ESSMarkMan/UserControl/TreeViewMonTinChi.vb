Imports ESS.Bussines
Public Class TreeViewMonTinChi
#Region "Var"
    Private mHoc_ky As Integer = 0
    Private mID_he As Integer = 0
    Private mID_khoa As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private Loader As Boolean = False
    Private mNode As New TreeNode
    Private clsMonTC As MonTinChi_Bussines
#End Region

#Region "Events"
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
        Dim Arr() As String
        mNode.BackColor = trvLop.BackColor
        mNode = e.Node
        mNode.BackColor = System.Drawing.Color.DeepSkyBlue
        e.Node.BackColor = Color.FromArgb(100, 0, 102, 204)
        Arr = Split(e.Node.Tag, "#")
        If Arr.Length >= 5 Then
            mID_he = Arr(0)
            mID_khoa = Arr(1)
            mID_mon_tc = Arr(2)
            mID_mon = Arr(3)
            mTen_mon = Arr(4)
        Else
            mID_he = 0
            mID_khoa = 0
            mID_mon_tc = 0
            mID_mon = 0
            mTen_mon = ""
        End If
        RaiseEvent TreeNodeSelected_()
    End Sub
    Private Sub cmbKy_dang_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKy_dang_ky.SelectedIndexChanged
        If Loader Then
            Dim Ky_dang_ky As Integer = cmbKy_dang_ky.SelectedValue
            If Ky_dang_ky > 0 Then
                'clsMonTC = New MonTinChi_Bussines(Ky_dang_ky)
                If gobjUser.UserName.ToUpper = "DAOTAO" Or gobjUser.UserName.ToUpper = "ADMIN" Or Kiem_tra_AdminUser() Or gobjUser.ID_phong = 1 Then
                    clsMonTC = New MonTinChi_Bussines(Ky_dang_ky)
                Else
                    clsMonTC = New MonTinChi_Bussines(Ky_dang_ky, gobjUser.ID_Bomon, gobjUser.ID_khoa)
                End If
                mHoc_ky = clsMonTC.Hoc_ky
                mNam_hoc = clsMonTC.Nam_hoc
                Dim dtLopTC As DataTable = clsMonTC.DanhSachMonLopTinChi_TCT
                TreeView_Lop(trvLop, dtLopTC)
            End If
        End If
    End Sub
#End Region

#Region "Functions And Subs"

    Private Function Kiem_tra_AdminUser() As Boolean
        For i As Integer = 0 To gobjUser.ESSVaiTro.Count - 1
            If gobjUser.ESSVaiTro.ESSVaiTro(i).ID_vai_tro = 1 Then Return True
        Next
        Return False
    End Function

    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable

            Dim strSQL As String
            strSQL = "SELECT Ky_dang_ky, N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' FROM PLAN_HocKyDangKy_TC"
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbKy_dang_ky, dt)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub TreeView_Lop(ByVal trvLop As TreeView, ByVal dtLop As DataTable, Optional ByVal ExpanAll As Boolean = False)
        trvLop.Nodes.Clear()
        Dim dr As DataRow
        Dim ID_He As Integer = -1, ID_Khoa As Integer = -1, ID_mon As Integer = 0
        Dim i As Integer = -1, j As Integer = -1, k As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        For r As Integer = 0 To dtLop.DefaultView.Count - 1
            dr = dtLop.DefaultView.Item(r).Row
            If dr.Item("ID_MON") = 182 Then
                dr.Item("ID_MON") = 182
            End If
            If ID_He = dr.Item("ID_he") Then
Khoa:
                If ID_Khoa = dr.Item("ID_khoa") Then
MonHocTinChi:
                    If ID_mon <> dr.Item("ID_mon") Then
                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Add(dr.Item("Ten_mon").ToString)
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Tag = dr.Item("ID_he").ToString + "#" + dr.Item("ID_khoa").ToString + "#" + dr.Item("ID_mon_tc").ToString + "#" + dr.Item("ID_mon").ToString + "#" + dr.Item("Ten_mon").ToString
                        trvLop.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 4
                        trvLop.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 5
                        k += 1
                    End If
                Else 'Add node 1, ESSKhoa hoc
                    j = j + 1
                    trvLop.Nodes.Item(i).Nodes.Add("Khoa: " & dr.Item("Ten_khoa"))
                    trvLop.Nodes(i).Nodes(j).Tag = ""
                    trvLop.Nodes(i).Nodes(j).ImageIndex = 2
                    trvLop.Nodes(i).Nodes(j).SelectedImageIndex = 3
                    k = 0
                    ID_mon = 0
                    'Add node 3, ESSKhoa 
                    GoTo MonHocTinChi
                End If
            Else 'Add node 0, He
                i = i + 1
                trvLop.Nodes.Add("Hệ: " & dr.Item("Ten_he"))
                trvLop.Nodes(i).Tag = ""
                trvLop.Nodes.Item(i).ImageIndex = 0
                trvLop.Nodes.Item(i).SelectedImageIndex = 1
                j = -1
                ID_Khoa = -1
                GoTo Khoa
            End If
            ID_He = dr.Item("ID_he")
            ID_Khoa = dr.Item("ID_khoa")
            ID_mon = dr.Item("ID_mon")
        Next
    End Sub
#End Region

#Region "Property"
    Public ReadOnly Property ID_he() As Integer
        Get
            Return mID_he
        End Get
    End Property
    Public ReadOnly Property ID_khoa() As Integer
        Get
            Return mID_khoa
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
    Public ReadOnly Property ID_mon_tc() As Integer
        Get
            Return mID_mon_tc
        End Get
    End Property
    Public ReadOnly Property ID_mon() As Integer
        Get
            Return mID_mon
        End Get
    End Property
    Public ReadOnly Property Ten_mon() As String
        Get
            Return mTen_mon
        End Get
    End Property
#End Region
End Class
