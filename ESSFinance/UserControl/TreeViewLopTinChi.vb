Imports ESS.Bussines
Public Class TreeViewLopTinChi
#Region "Var"
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mID_lop_tc As Integer
    Private mTen_lop_tc As String = ""
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
        Dim idx_mon, idx_lop As Integer
        Arr = Split(e.Node.Tag, "#")
        If Arr.Length = 1 Then
            mID_mon_tc = Arr(0)
            idx_mon = clsMonTC.Tim_idx(mID_mon_tc)
            If idx_mon >= 0 Then
                mID_mon = clsMonTC.ESSMonTinChi(idx_mon).ID_mon
                mTen_mon = clsMonTC.ESSMonTinChi(idx_mon).Ten_mon
            End If
            mID_lop_tc = 0
        ElseIf Arr.Length = 2 Then
            mID_mon_tc = Arr(0)
            If idx_mon >= 0 Then
                mID_mon = clsMonTC.ESSMonTinChi(idx_mon).ID_mon
                mTen_mon = clsMonTC.ESSMonTinChi(idx_mon).Ten_mon
            End If
            mID_lop_tc = Arr(1)
            idx_lop = clsMonTC.ESSMonTinChi(idx_mon).dsLopTinChi.Tim_idx(mID_lop_tc)
            If idx_lop >= 0 Then mTen_lop_tc = clsMonTC.ESSMonTinChi(idx_mon).dsLopTinChi.ESSLopTinChi(idx_lop).Ten_lop_tc
        Else
            mID_mon_tc = 0
            mID_lop_tc = 0
        End If
        RaiseEvent TreeNodeSelected_()
    End Sub
    Private Sub cmbKy_dang_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKy_dang_ky.SelectedIndexChanged
        If Loader Then
            Dim Ky_dang_ky As Integer = cmbKy_dang_ky.SelectedValue
            If Ky_dang_ky > 0 Then
                clsMonTC = New MonTinChi_Bussines(Ky_dang_ky)
                mHoc_ky = clsMonTC.Hoc_ky
                mNam_hoc = clsMonTC.Nam_hoc
                Dim dtLopTC As DataTable = clsMonTC.DanhSachMonLopTinChi
                TreeView_Lop(trvLop, dtLopTC)
            End If
        End If
    End Sub
#End Region

#Region "Functions And Subs"
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
        Dim ID_He As Integer = 0, ID_Khoa As Integer = 0, Ky_hieu_lop_tc As String = ""
        Dim i As Integer = -1, j As Integer = -1, k As Integer = -1, l As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        For Each dr In dtLop.Rows
            If ID_He = dr.Item("ID_he") Then
Khoa:
                If ID_Khoa = dr.Item("ID_khoa") Then
MonHocTinChi:
                    If Ky_hieu_lop_tc = dr.Item("Ky_hieu_lop_tc") Then
LopTinChi:
                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Item(k).Nodes.Add("Lớp: " & dr.Item("Ten_lop_tc").ToString)
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Tag = dr.Item("ID_mon_tc").ToString + "#" + dr.Item("ID_lop_tc").ToString
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).ImageIndex = 6
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Nodes(l).SelectedImageIndex = 7
                        l += 1
                    Else 'Add node 2, ESSKhoa
                        k += 1
                        trvLop.Nodes.Item(i).Nodes.Item(j).Nodes.Add(dr.Item("Ten_mon").ToString & "(" & dr.Item("Ky_hieu_lop_tc").ToString & ")")
                        trvLop.Nodes(i).Nodes(j).Nodes(k).Tag = dr.Item("ID_mon_tc").ToString
                        trvLop.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 4
                        trvLop.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 5
                        l = 0
                        Ky_hieu_lop_tc = ""
                        'Add node 3, Chuyen nganh
                        GoTo LopTinChi
                    End If
                Else 'Add node 1, ESSKhoa hoc
                    j = j + 1
                    trvLop.Nodes.Item(i).Nodes.Add("Khoa: " & dr.Item("Ten_khoa"))
                    trvLop.Nodes(i).Nodes(j).Tag = dr.Item("ID_he") & "#" & dr.Item("ID_khoa")
                    trvLop.Nodes(i).Nodes(j).ImageIndex = 2
                    trvLop.Nodes(i).Nodes(j).SelectedImageIndex = 3
                    k = -1
                    Ky_hieu_lop_tc = ""
                    'Add node 3, ESSKhoa 
                    GoTo MonHocTinChi
                End If
            Else 'Add node 0, He
                i = i + 1
                trvLop.Nodes.Add("Hệ: " & dr.Item("Ten_he"))
                trvLop.Nodes(i).Tag = dr.Item("ID_he")
                trvLop.Nodes.Item(i).ImageIndex = 0
                trvLop.Nodes.Item(i).SelectedImageIndex = 1
                j = -1
                ID_Khoa = 0
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
    Public ReadOnly Property ID_lop_tc() As Integer
        Get
            Return mID_lop_tc
        End Get
    End Property
    Public ReadOnly Property Ten_lop_tc() As String
        Get
            Return mTen_lop_tc
        End Get
    End Property
#End Region
End Class
