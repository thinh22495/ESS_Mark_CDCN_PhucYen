Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ChonTruongHienThi
#Region "Var"
    Dim Indx As Integer ' Chỉ số hiện tại của listViewItem
    Dim mdtDaChon As DataTable  ' Bảng các trường đã chọn
    Private mFieldGroup As Integer = 0
#End Region
    Public Sub New(ByVal FieldGroup As Integer)
        mFieldGroup = FieldGroup
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region "Form Event"
    Private Sub frmESS_HienThiTruong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call LsvFields(lsvDanh_sach) ' Format listView
            Dim dt As New DataTable
            Dim cls As New HienThiTruong_Bussines()
            dt = cls.HienThi_ESSNhomTruongHienThi(2)
            ' Xóa bổ một số nhóm trường hiển thị chưa cần thiết
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                If dt.Rows(i)("FieldGroup") <> 202 And dt.Rows(i)("FieldGroup") <> 203 And dt.Rows(i)("FieldGroup") <> 204 And dt.Rows(i)("FieldGroup") <> 205 Then
                    dt.Rows(i).Delete()
                End If
            Next
            dt.AcceptChanges()
            Fields_list(trvFields, dt) ' hiển thị treeView            
            If mFieldGroup <> gID_ph * 100 + 1 Then ' Nếu là nhóm người dùng định nghĩa
                mdtDaChon = cls.HienThi_ESSTruongHienThiMacDinh(mFieldGroup)
            Else
                mdtDaChon = cls.HienThi_ESSTruongHienThiNguoiDung(gID_ph, gobjUser.UserID)
            End If
            Display_list(lsvDanh_sach, mdtDaChon, trvFields) ' Hiển thị trường đã định nghĩa
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_HienThiTruong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub trvFields_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvFields.AfterCheck
        If e.Action = TreeViewAction.ByKeyboard Or e.Action = TreeViewAction.ByMouse Then
            CheckNode(e.Node, e.Node.Checked)
            Dim Arr() As String = Split(e.Node.Tag, "$#", , CompareMethod.Binary)
            If Arr.Length > 1 Then
                If e.Node.Checked = False Then
                    'Xoa mot node
                    UnCheckNode_deleted(Arr(1))
                Else
                    'Them node moi
                    CheckNode_Added(Arr(1), e.Node.Text, Arr(0), Arr(2))
                End If
            End If
            Display_list(lsvDanh_sach, mdtDaChon)
            SetButton(False)
        End If
    End Sub
    Private Sub LsvDanh_sach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvDanh_sach.Click
        Try
            Indx = lsvDanh_sach.FocusedItem.Index
            SetButton(True)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If lsvDanh_sach.Items.Count <= 0 Then
                Thongbao("Bạn phải chọn ít nhất một trường hiển thị", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If mdtDaChon.Rows.Count = 0 Then Exit Sub
                Dim cls As New HienThiTruong_Bussines
                ' Xóa các bản ghi cũ
                If mFieldGroup = gID_ph * 100 + 1 Then
                    cls.Xoa_ESSFielUser(gobjUser.UserID)
                Else
                    cls.Xoa_ESSFielDefaul(mFieldGroup)
                End If
                ' Insert Các bản ghi mới đã chọn            
                For i As Integer = 0 To mdtDaChon.Rows.Count - 1
                    With mdtDaChon.Rows(i)
                        If mFieldGroup = gID_ph * 100 + 1 Then
                            cls.ThemMoi_ESSFieldUser(gobjUser.UserID, .Item("FieldID"), .Item("FieldSize"), .Item("STT"))
                        Else
                            cls.ThemMoi_ESSFieldDefault(mFieldGroup, .Item("FieldID"), .Item("STT"))
                        End If
                    End With
                Next
                Me.Close()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        MoveUp(Indx)
        Indx = Indx - 1
        Display_list(lsvDanh_sach, mdtDaChon)
        Lsv_Selected(lsvDanh_sach, Indx)
    End Sub

    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown.Click
        MoveDown(Indx)
        Indx = Indx + 1
        Display_list(lsvDanh_sach, mdtDaChon)
        Lsv_Selected(lsvDanh_sach, Indx)
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Lsv_Selected(ByVal lsv As ListView, ByRef Ind As Integer) ' Chọn list view
        If Ind < 0 Then
            Ind = 0
        ElseIf Ind > lsv.Items.Count - 1 Then
            Ind = lsv.Items.Count - 1
        End If
        lsv.Items(Ind).Selected = True
        lsv.Select()
    End Sub

    Private Sub SetButton(ByVal Trangthai As Boolean)
        cmdUp.Enabled = Trangthai
        cmdDown.Enabled = Trangthai
    End Sub

    Public Sub LsvFields(ByVal lsv As ListView) ' Format listView
        lsv.Clear()
        lsv.Columns.Add("FieldID", 0, HorizontalAlignment.Right)
        lsv.Columns.Add("STT", 40, HorizontalAlignment.Center).TextAlign = HorizontalAlignment.Center
        lsv.Columns.Add("Tên trường được chọn", 183, HorizontalAlignment.Left)
        lsv.Columns.Add("FieldSize", 0, HorizontalAlignment.Center)
    End Sub

    Sub Fields_list(ByVal trvFields As TreeView, ByVal dt As DataTable) ' Hiển thị treeView
        Try
            trvFields.Nodes.Clear()
            If dt Is Nothing Then Exit Sub
            If dt.Rows.Count <= 0 Then Exit Sub
            Dim dr As DataRow
            Dim FieldGroup As Integer = 0, i As Integer = -1, j As Integer = 0
            Dim node As New TreeNode
            For Each dr In dt.Rows
                If FieldGroup = dr.Item("FieldGroup") Then
Field:              ' Add moi Field Node 1
                    trvFields.Nodes.Item(i).Nodes.Add(dr.Item("FieldName"))
                    trvFields.Nodes(i).Nodes(j).Tag = dr.Item("FieldGroup") & "$#" & dr.Item("FieldID") & "$#" & dr.Item("FieldSize")
                    trvFields.Nodes(i).Nodes(j).ImageIndex = 3
                    trvFields.Nodes(i).Nodes(j).SelectedImageIndex = 3
                    j += 1
                Else    'Add node 0, Nhom Field
                    i = i + 1
                    trvFields.Nodes.Add(dr.Item("GroupName"))
                    trvFields.Nodes(i).Tag = dr.Item("FieldGroup").ToString()
                    j = 0
                    GoTo Field
                End If
                FieldGroup = dr.Item("FieldGroup")
            Next
            dt.Dispose()
        Catch
        End Try
    End Sub

    Sub Display_list(ByVal lsv As ListView, ByVal dt As DataTable, Optional ByVal trv As TreeView = Nothing) ' Hiển thị listView
        Dim i As Integer = 0
        lsv.Items.Clear()
        If dt.Rows.Count <= 0 Then Exit Sub
        Do While i < dt.Rows.Count
            With dt.Rows(i)
                'Add vao List View
                lsv.Items.Add(.Item("FieldID").ToString())
                lsv.Items(i).SubItems.Add(i + 1)
                lsv.Items(i).SubItems.Add(.Item("FieldName").ToString())
                lsv.Items(i).SubItems.Add(.Item("FieldSize").ToString())
                If Not trv Is Nothing Then    'Neu co TreeView thi tim de Check cac Node
                    Checked_Node(trv.Nodes, .Item("FieldGroup"), .Item("FieldID"))
                End If
            End With
            i = i + 1
        Loop
    End Sub
    Private Sub Checked_Node(ByVal Nodes As TreeNodeCollection, ByVal GroupID As Long, ByVal FieldID As String)
        Dim node As TreeNode
        For Each node In Nodes
            If node.Tag = CType(GroupID, String) Or InStr(node.Tag, GroupID & "$#" & FieldID & "$#") > 0 Then
                node.Checked = True
                node.Expand()
            End If
            Checked_Node(node.Nodes, GroupID, FieldID)
        Next
    End Sub

    Public Sub CheckNode(ByVal node As TreeNode, ByVal blnCheck As Boolean)
        If Not node Is Nothing Then
            If blnCheck Then
                CheckChild(node, True)
                CheckParent(node, True)
            Else
                CheckChild(node, False)
                If HasChildCheck(node.Parent) = False Then CheckParent(node, False)
            End If
        End If
    End Sub
    Private Sub CheckChild(ByVal Node As TreeNode, ByVal blnCheck As Boolean)
        If Not Node Is Nothing Then
            Dim tempnode As TreeNode = Node.FirstNode
            If blnCheck Then
                While (tempnode Is Node.LastNode Or Not tempnode Is Node.LastNode) And Not tempnode Is Nothing
                    Dim Arr() As String = Split(tempnode.Tag, "$#")
                    If Arr.Length > 2 Then
                        'Add node moi
                        CheckNode_Added(Arr(1), tempnode.Text, Arr(0), Arr(2))
                    End If
                    tempnode.Checked = True
                    CheckChild(tempnode, blnCheck)
                    tempnode = tempnode.NextNode
                End While
            Else
                While (tempnode Is Node.LastNode Or Not tempnode Is Node.LastNode) And Not tempnode Is Nothing
                    Dim Arr() As String = Split(tempnode.Tag, "$#")
                    If Arr.Length > 1 Then
                        'Xoa node cu
                        UnCheckNode_deleted(arr(1))
                    End If
                    tempnode.Checked = False
                    CheckChild(tempnode, blnCheck)
                    tempnode = tempnode.NextNode
                End While
            End If
        End If
    End Sub
    Private Sub CheckParent(ByVal Node As TreeNode, ByVal blnCheck As Boolean)
        If Not Node Is Nothing Then
            Dim tempnode As TreeNode = Node.Parent
            If blnCheck Then
                If Not tempnode Is Nothing Then
                    tempnode.Checked = True
                    CheckParent(tempnode, True)
                End If
            Else
                If Not tempnode Is Nothing Then
                    tempnode.Checked = False
                    If HasChildCheck(tempnode.Parent) = False Then CheckParent(tempnode, False)
                End If
            End If
        End If
    End Sub
    Private Function HasChildCheck(ByVal Node As TreeNode) As Boolean
        If Not Node Is Nothing Then
            Dim tempnode As TreeNode = Node.FirstNode
            While Not tempnode Is Nothing
                If tempnode.Checked = True Then Return True
                If HasChildCheck(tempnode) = True Then Return True
                tempnode = tempnode.NextNode
            End While
            Return False
        End If
    End Function
    Private Sub UnCheckNode_deleted(ByVal FieldID As String)
        If mdtDaChon.Rows.Count <= 0 Then Exit Sub

        Dim j, CurrentStt As Integer
        Dim Ktra As Boolean = False
        Dim i As Integer = 0

        Do While i < mdtDaChon.Rows.Count
            If mdtDaChon.Rows(i).Item("FieldID").ToString() = FieldID Then
                Ktra = True
                Exit Do
            End If
            i = i + 1
        Loop
        If Not Ktra Then Exit Sub

        'Xoa ban ghi hien thoi
        CurrentStt = mdtDaChon.Rows(i).Item("Stt")
        mdtDaChon.Rows(i).Delete()

        'Update lai Stt cho cac ban ghi sau
        If i = mdtDaChon.Rows.Count - 1 Then GoTo QUIT
        For j = i To mdtDaChon.Rows.Count - 1
            With mdtDaChon.Rows(j)
                If Not .RowState = DataRowState.Deleted Then
                    .Item("Stt") = CurrentStt
                    CurrentStt = CurrentStt + 1
                End If
            End With
        Next
QUIT:
        mdtDaChon.AcceptChanges()
    End Sub
    Private Sub CheckNode_Added(ByVal FieldID As String, Optional ByVal FieldName As String = "", Optional ByVal FieldGroup As Long = 0, Optional ByVal FieldSize As Double = 1)
        Dim CurrentStt As Integer = 1
        If mdtDaChon.Rows.Count > 0 Then
            CurrentStt = mdtDaChon.Rows(mdtDaChon.Rows.Count - 1).Item("Stt") + 1
        End If
        Dim dr As DataRow = mdtDaChon.NewRow
        With dr
            .Item("Stt") = CurrentStt
            .Item("FieldID") = FieldID
            .Item("FieldName") = FieldName
            .Item("FieldGroup") = FieldGroup
            .Item("FieldSize") = FieldSize
        End With
        mdtDaChon.Rows.Add(dr)
        mdtDaChon.AcceptChanges()
    End Sub
    Private Sub MoveUp(ByVal Indx As Integer)
        Try
            If Indx <= 0 Or Indx >= mdtDaChon.Rows.Count Then Exit Sub
            Dim Arr() As Object
            Arr = mdtDaChon.Rows(Indx).ItemArray
            mdtDaChon.Rows(Indx).ItemArray = mdtDaChon.Rows(Indx - 1).ItemArray
            mdtDaChon.Rows(Indx).Item("STT") += 1
            '--------------------------
            mdtDaChon.Rows(Indx - 1).ItemArray = Arr
            mdtDaChon.Rows(Indx - 1).Item("STT") -= 1
            mdtDaChon.AcceptChanges()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub MoveDown(ByVal Indx As Integer)
        Try
            If Indx < 0 Or Indx >= mdtDaChon.Rows.Count - 1 Then Exit Sub
            Dim Arr() As Object
            Arr = mdtDaChon.Rows(Indx).ItemArray
            mdtDaChon.Rows(Indx).ItemArray = mdtDaChon.Rows(Indx + 1).ItemArray
            mdtDaChon.Rows(Indx).Item("STT") -= 1
            '--------------------------
            mdtDaChon.Rows(Indx + 1).ItemArray = Arr
            mdtDaChon.Rows(Indx + 1).Item("STT") += 1
            mdtDaChon.AcceptChanges()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class