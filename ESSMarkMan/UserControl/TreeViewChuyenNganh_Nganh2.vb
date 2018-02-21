Imports ESS.Bussines
Public Class TreeViewChuyenNganh_Nganh2
#Region "Var"
    Private mdtLop As DataTable
    Private mID_he As Integer
    Private mKhoa_hoc As Integer
    Private mID_chuyen_nganh As Integer
    Private mID_dt As Integer
    Private mNien_khoa As String = ""
    Private mNode As New TreeNode
#End Region

#Region "Events"
    Public Event TreeNodeSelected_()
#End Region

#Region "Event Control"
    Private Sub trvLop_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvLop.AfterSelect
        If e.Node Is Nothing Then Exit Sub
        Dim Arr() As String
        Arr = Split(e.Node.Tag, "#")
        mNode.BackColor = trvLop.BackColor
        mNode = e.Node
        mNode.BackColor = System.Drawing.Color.DeepSkyBlue
        e.Node.BackColor = Color.FromArgb(100, 0, 102, 204)
        If Arr.Length <= 1 Then Exit Sub
        If Arr.Length <= 3 Then
            If Arr.Length >= 1 Then Me.mID_he = Arr(0)
            Me.mKhoa_hoc = Arr(1)
            Me.mID_chuyen_nganh = 0
            Me.mID_dt = 0
        ElseIf Arr.Length <= 4 Then 'Chọn đến cấp khoá
            Me.mID_he = Arr(0)
            Me.mKhoa_hoc = Arr(1)
            Me.mID_chuyen_nganh = Arr(2)
            'Lấy danh sách các lớp và ID_dt
            mID_dt = 0
        ElseIf Arr.Length <= 5 Then 'Chọn đến chuyên ngành
            Me.mID_he = Arr(0)
            Me.mKhoa_hoc = Arr(1)
            Me.mID_chuyen_nganh = Arr(2)
            Me.mID_dt = Arr(3)
            Me.mNien_khoa = Arr(4)
        End If
        RaiseEvent TreeNodeSelected_()
    End Sub
#End Region

#Region "Functions And Subs"
    Public Sub HienThi_ESSTreeView_TheoCoVanHocTap(ByVal ID_lops As String)
        If Not trvLop Is Nothing Then
            Dim objLop As New Lop_Bussines(ID_lops, 0, 1, -1)
            mdtLop = objLop.Danh_sach_lop_dang_hoc()
            TreeView_Lop(trvLop, mdtLop)
        End If
    End Sub
    Public Sub HienThi_ESSTreeView()
        If Not trvLop Is Nothing Then
            Dim objLop As New Lop_Bussines()
            mdtLop = objLop.Chuyen_nganh_dao_tao_DanhSach()
            TreeView_Lop(trvLop, mdtLop)
        End If
    End Sub
    Private Sub TreeView_Lop(ByVal trvLop As TreeView, ByVal dtLop As DataTable, Optional ByVal SelectAll As Boolean = False)
        trvLop.Nodes.Clear()
        Dim dr As DataRow
        Dim ID_He As Integer = 0, Khoa_hoc As Integer = 0, ID_chuyen_nganh As Integer = 0
        Dim i As Integer = -1, k As Integer = -1, l As Integer = -1
        Dim kt_Lop As Boolean = False
        Dim node As TreeNode = Nothing
        For Each dr In dtLop.Rows
            If ID_He = dr.Item("ID_he") Then
Khoa_hoc:
                If Khoa_hoc = dr.Item("Khoa_hoc") Then
Chuyen_nganh:
                    trvLop.Nodes.Item(i).Nodes.Item(k).Nodes.Add("C.Ngành: " & dr.Item("Chuyen_nganh"))
                    trvLop.Nodes(i).Nodes(k).Nodes(l).Tag = dr.Item("ID_he") & "#" & dr.Item("Khoa_hoc") & "#" & dr.Item("ID_chuyen_nganh") & "#" & dr.Item("ID_dt") & "#" & dr.Item("Nien_khoa")
                    trvLop.Nodes(i).Nodes(k).Nodes(l).ImageIndex = 6
                    trvLop.Nodes(i).Nodes(k).Nodes(l).SelectedImageIndex = 7
                    l += 1
                Else 'Add node 2 
                    k += 1
                    trvLop.Nodes.Item(i).Nodes.Add("Khoá: " & dr.Item("Khoa_hoc"))
                    trvLop.Nodes(i).Nodes(k).Tag = dr.Item("ID_he") & "#" & dr.Item("Khoa_hoc")
                    trvLop.Nodes(i).Nodes(k).ImageIndex = 4
                    trvLop.Nodes(i).Nodes(k).SelectedImageIndex = 5
                    l = 0
                    GoTo Chuyen_nganh
                End If
            Else 'Add node 0, He
                i = i + 1
                trvLop.Nodes.Add("Hệ: " & dr.Item("Ten_he"))
                trvLop.Nodes(i).Tag = dr.Item("ID_he")
                trvLop.Nodes.Item(i).ImageIndex = 0
                trvLop.Nodes.Item(i).SelectedImageIndex = 1
                trvLop.Nodes.Item(i).Expand()
                k = -1
                Khoa_hoc = 0
                GoTo Khoa_hoc
            End If
            ID_He = dr.Item("ID_he")
            Khoa_hoc = dr.Item("khoa_hoc")
            ID_chuyen_nganh = dr.Item("ID_chuyen_nganh")
        Next
    End Sub

#End Region

#Region "Property"
    Public Property dtLop() As DataTable
        Get
            Return mdtLop
        End Get
        Set(ByVal Value As DataTable)
            mdtLop = Value
        End Set
    End Property
    Public ReadOnly Property ID_he() As Integer
        Get
            Return mID_he
        End Get
    End Property
    Public ReadOnly Property Khoa_hoc() As Integer
        Get
            Return mKhoa_hoc
        End Get
    End Property
    Public ReadOnly Property ID_chuyen_nganh() As Integer
        Get
            Return mID_chuyen_nganh
        End Get
    End Property
    Public ReadOnly Property ID_dt() As Integer
        Get
            Return mID_dt
        End Get
    End Property
    Public ReadOnly Property Nien_khoa() As String
        Get
            Return mNien_khoa
        End Get
    End Property
#End Region
End Class
