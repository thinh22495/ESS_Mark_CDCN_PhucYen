Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel
Imports ESSUtility

Partial Public Class frmMain
    Inherits RibbonForm
    Dim Loader As Boolean = False
#Region "User Functions"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.     
        'UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")

    End Sub
    Private Sub Show_form(ByVal FunctionID As String, ByVal Caption As String)
        Try
            'gFunctionID = FunctionID
            Dim frmESS_ As Form = Nothing
            Select Case FunctionID
                Case 921
                    frmESS_ = New frmESS_VaiTroList
                Case 922
                    frmESS_ = New frmESS_UsersList
                Case 923
                    frmESS_ = New frmESS_UserSinhVien
                Case 924
                    frmESS_ = New frmESS_TraCuuLog ' Form tra cưu log
                Case 925
                    frmESS_ = New frmESS_ThamSoHeThong ' Form tham số hệ thống
                Case 926
                    frmESS_ = New frmESS_ChangePassword
            End Select
            If Not frmESS_ Is Nothing Then
                frmESS_.Text = Caption
                Me.FormSelected(frmESS_)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub HienThi_ESSchuc_nang()
        Dim idx As Integer = 0
        'Sinh vien Nhap truong
        For i As Integer = 0 To gobjUser.ESSQuyen.Count - 1
            If gobjUser.ESSQuyen.Quyen(i).ID_nhom_quyen = 9 Then

                ' Add Item to NavBarGroup
                Dim NavItem As New NavBarItem
                NavItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                NavItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                NavItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                NavItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                NavItem.SmallImageIndex = idx
                NavQuanTriHeThong.ItemLinks.Add(NavItem)


                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                mnuQuanTriHeThong.AddItem(xBarItem)
                idx += 1
            End If
        Next
       

    End Sub



    Private Function CheckFormExist(ByVal frmESS_ As Form) As Boolean
        For Each frmESS_Children As Form In Me.MdiChildren
            If frmESS_Children.Name = frmESS_.Name Then
                frmESS_Children.Select()
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub FormSelected(ByVal frmESS_ As Form)
        If CheckFormExist(frmESS_) Then Exit Sub
        'frmESS_.Text = "Mã chức năng " & FunctionID
        staInfomation.Caption = "CHỨC NĂNG: " & frmESS_.Text & " - NGƯỜI DÙNG: " & gobjUser.FullName.ToUpper & " - HÒM THƯ: " & gobjUser.Email.ToUpper & " -ĐANG SỬ DỤNG"
        frmESS_.MdiParent = Me
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.WindowState = FormWindowState.Maximized
        frmESS_.Show()
    End Sub



#End Region

#Region " Form event "
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UCheckVersion() = "1" Then
            End
        End If

        'Đăng nhập chương trình
        Dim frm As New frmESS_DangNhap
        frm.ShowDialog()
        'Đăng nhập thành công
        If frm.Tag = 1 Then
            'Load chuc nang
            HienThi_ESSchuc_nang()

            For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = RibMain.Items.CreateCheckItem(skin.SkinName, False)
                item.Tag = skin.SkinName
                AddHandler item.ItemClick, AddressOf OnPaintStyleClick
                menuStyle.ItemLinks.Add(item)
            Next skin

            Loader = True
        Else    'Đăng nhập không thành công
            Close()
        End If
    End Sub
#End Region

#Region "Control Events"



    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Try
        '    SaveLog(LoaiSuKien.Them, "Người dùng: " & gobjUser.UserName & " - đăng xuất khỏi hệ thống")
        'Catch ex As Exception
        '    Exit Sub
        'End Try

    End Sub

    Private Sub NavBarMain_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMain.LinkClicked
        If Not e.Link.Item Is Nothing Then
            Show_form(e.Link.Item.Tag, e.Link.Item.Caption)
        End If
    End Sub


    Private Sub RibMain_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RibMain.ItemClick
        If Not e.Item.Tag Is Nothing Then
            Show_form(e.Link.Item.Tag, e.Link.Item.Caption)
        End If
    End Sub
#End Region

    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        DefaultLookAndFeelMain.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())

    End Sub

    Private Sub menuStyle_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuStyle.Popup
        For Each link As BarItemLink In menuStyle.ItemLinks
            CType(link.Item, BarCheckItem).Checked = link.Item.Caption = DefaultLookAndFeelMain.LookAndFeel.ActiveSkinName
        Next link
    End Sub
End Class