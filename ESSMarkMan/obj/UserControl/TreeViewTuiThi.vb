Imports ThienAn.BLL.Business
Public Class TreeViewTuiThi
#Region "Var"
    Private mID_thi As Integer = 0
    Private mTui_so As Integer = 0
    Private mID_mon As Integer = 0
    Private mLan_thi As Integer = 0
    Private mID_khoa As Integer = 0
    Private mTen_mon As String = ""
    Private mTen_khoa As String = ""
    'Private mPhong_thi As String = ""
    Private mNgay_thi As String = ""
    Private Loader As Boolean = False
    Private mdtDanhSachThi As New DataTable
    Private mNode As New TreeNode
#End Region

#Region "Events"
    Public Event TreeNodeSelected_()
#End Region
#Region "Event Control"
    Private Sub trvLop_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvPhongThi.AfterSelect
        If e.Node Is Nothing Then Exit Sub
        mNode.BackColor = trvPhongThi.BackColor
        mNode = e.Node
        mNode.BackColor = System.Drawing.Color.DeepSkyBlue
        e.Node.BackColor = Color.FromArgb(100, 0, 102, 204)
        If e.Node.Tag <> "" Then
            Dim Arr() As String = Split(e.Node.Tag, "#")
            If Arr.Length = 4 Then
                mID_khoa = Arr(0)
                mID_thi = Arr(1)
                mID_mon = Arr(2)
                mLan_thi = Arr(3)
                mTui_so = 0
                mTen_khoa = e.Node.Parent.Parent.Parent.Text
                mTen_mon = e.Node.Parent.Parent.Text
            ElseIf Arr.Length = 5 Then
                mID_khoa = Arr(0)
                mID_thi = Arr(1)
                mID_mon = Arr(2)
                mLan_thi = Arr(3)
                mTui_so = Arr(4)
                mTen_khoa = e.Node.Parent.Parent.Parent.Parent.Text
                mTen_mon = e.Node.Parent.Parent.Parent.Text
                'mPhong_thi = e.Node.Text
            Else
                mID_khoa = 0
                mID_thi = 0
                mID_mon = 0
                mLan_thi = 0
                mTui_so = 0
            End If
        Else
            mID_khoa = 0
            mID_thi = 0
            mID_mon = 0
            mLan_thi = 0
            mTui_so = 0
        End If
        RaiseEvent TreeNodeSelected_()
    End Sub
    Public Sub ReLoad()
        Call cmbHocky_Namhoc_SelectedIndexChanged(Nothing, Nothing)
    End Sub
#End Region
#Region "Control Events"
    Private Sub TreeViewPhongThi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadComboBox()
        Loader = True
    End Sub
    Private Sub cmbHocky_Namhoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        If Loader Then
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            If Hoc_ky > 0 And Nam_hoc <> "" Then
                Dim clsThi As New TochucThi_BLL(Hoc_ky, Nam_hoc, gobjUser.ID_Bomon)
                Dim dtThi As DataTable = clsThi.DanhSachMonToChucThi_TheoTui
                TreeView_Lop(trvPhongThi, dtThi)
            End If
        End If
    End Sub
    Private Sub TreeView_Lop(ByVal trvThi As TreeView, ByVal dtThi As DataTable)
        trvThi.Nodes.Clear()
        Dim dr As DataRow
        Dim Nam_hoc As String = ""
        Dim ID_he As Long = -1, ID_khoa As Long = -1, ID_Mon As Long = 0, Dot_thi As Byte = 0, Lan_thi As Byte = 0, Tui_thi As Byte = 0
        Dim i As Integer = -1, j As Integer = -1, k As Integer = -1, l As Integer = -1, m As Integer = -1, n As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        For Each dr In dtThi.Rows
            If ID_he = dr.Item("ID_he") Then
KhoaHoc:
                If ID_khoa = dr.Item("ID_khoa") Then
MonHoc:
                    If ID_Mon = dr.Item("ID_mon") Then
LanThi:
                        If Lan_thi = dr.Item("Lan_thi") Then
DotThi:
                            If Dot_thi = dr.Item("Dot_thi") Then
TuiThi:
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).Nodes.Add("Túi thi: " + dr.Item("Tui_so").ToString)
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).Nodes(n).Tag = dr.Item("ID_khoa").ToString + "#" + dr.Item("ID_thi").ToString + "#" + dr.Item("ID_mon").ToString + "#" + dr.Item("Lan_thi").ToString + "#" + dr.Item("Tui_so").ToString
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).Nodes(n).ImageIndex = 5
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).Nodes(n).SelectedImageIndex = 5
                                n += 1
                            Else
                                m = m + 1
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes.Add("Dot thi: " + dr.Item("Dot_thi").ToString)
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).Tag = dr.Item("ID_khoa").ToString + "#" + dr.Item("ID_thi").ToString + "#" + dr.Item("ID_mon").ToString + "#" + dr.Item("Lan_thi").ToString
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).ImageIndex = 4
                                trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Nodes(m).SelectedImageIndex = 4
                                Tui_thi = 0
                                n = 0
                                GoTo TuiThi
                            End If  'Kết thúc tui thi
                        Else
                            l = l + 1
                            trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes.Add("Thi lần: " + dr.Item("Lan_thi").ToString)
                            trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).Tag = ""
                            trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).ImageIndex = 3
                            trvThi.Nodes(i).Nodes(j).Nodes(k).Nodes(l).SelectedImageIndex = 3
                            Dot_thi = 0
                            m = -1
                            GoTo DotThi
                        End If  'Kết thúc đợt thi
                    Else
                        k += 1
                        trvThi.Nodes(i).Nodes(j).Nodes.Add("Môn: " + dr.Item("Ten_mon").ToString)
                        trvThi.Nodes(i).Nodes(j).Nodes(k).Tag = ""
                        trvThi.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 2
                        trvThi.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 2
                        Lan_thi = 0
                        l = -1
                        GoTo LanThi
                    End If  'Kết thúc lần thi
                Else
                    j += 1
                    trvThi.Nodes(i).Nodes.Add("Khoa: " + dr.Item("Ten_khoa").ToString)
                    trvThi.Nodes(i).Nodes(j).Tag = ""
                    trvThi.Nodes(i).Nodes(j).ImageIndex = 1
                    trvThi.Nodes(i).Nodes(j).SelectedImageIndex = 1
                    trvThi.Nodes(i).Nodes(j).Expand()
                    ID_Mon = 0
                    k = -1
                    GoTo MonHoc
                End If  'Kết thúc khoá học
            Else
                i += 1
                trvThi.Nodes.Add("Hệ: " & dr.Item("Ten_he"))
                trvThi.Nodes(i).Tag = ""
                trvThi.Nodes.Item(i).ImageIndex = 0
                trvThi.Nodes.Item(i).SelectedImageIndex = 0
                trvThi.Nodes(i).Expand()
                j = -1
                ID_khoa = -1
                GoTo KhoaHoc
            End If  ' Kết thúc hệ đào tạo
            ID_he = dr.Item("ID_he")
            ID_khoa = dr.Item("ID_khoa")
            ID_Mon = dr.Item("ID_mon")
            Lan_thi = dr.Item("Lan_thi")
            Dot_thi = dr.Item("Dot_thi")
            Tui_thi = dr.Item("Tui_so")
        Next
    End Sub
#End Region
#Region "Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Property"
    Public ReadOnly Property Ten_mon() As String
        Get
            Return mTen_mon
        End Get
    End Property
    'Public ReadOnly Property Phong_thi() As String
    '    Get
    '        Return mPhong_thi
    '    End Get
    'End Property
    Public ReadOnly Property ID_khoa() As Integer
        Get
            Return mID_khoa
        End Get
    End Property
    Public ReadOnly Property Ten_khoa() As String
        Get
            Return mTen_khoa
        End Get
    End Property
    Public ReadOnly Property ID_thi() As Integer
        Get
            Return mID_thi
        End Get
    End Property
    Public ReadOnly Property Tui_so() As String
        Get
            Return mTui_so
        End Get
    End Property
    Public ReadOnly Property dtDanhSachThi() As DataTable
        Get
            Return mdtDanhSachThi
        End Get
    End Property
    Public ReadOnly Property ID_mon() As Integer
        Get
            Return mID_mon
        End Get
    End Property
    Public ReadOnly Property Lan_thi() As Integer
        Get
            Return mLan_thi
        End Get
    End Property
    Public ReadOnly Property Hoc_ky() As Integer
        Get
            Return cmbHoc_ky.SelectedValue
        End Get
    End Property
    Public ReadOnly Property Nam_hoc() As String
        Get
            Return cmbNam_hoc.Text
        End Get
    End Property
#End Region
End Class