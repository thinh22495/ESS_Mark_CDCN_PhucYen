Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.LookAndFeel
Imports ESSUtility
Partial Public Class frmESS_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Dim Loader As Boolean = False
    Public Sub New()
        InitializeComponent()
        InitEditors()
        UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
    End Sub

    Private Sub frmESS_Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            SaveLog(LoaiSuKien.Them, "Người dùng: " & gobjUser.UserName & " - đăng xuất khỏi hệ thống")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub InitEditors()
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
        biStyle.EditValue = RibMain.RibbonStyle
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        If UCheckVersion() = "1" Then

        End If

        'Đăng nhập chương trình
        Dim frm As New frmESS_DangNhap
        frm.ShowDialog()
        'Đăng nhập thành công
        If frm.Tag = 1 Then
            RibMain.ForceInitialize()
            For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = RibMain.Items.CreateCheckItem(skin.SkinName, False)
                item.Tag = skin.SkinName
                AddHandler item.ItemClick, AddressOf OnPaintStyleClick
                mnuPainStyle.ItemLinks.Add(item)
            Next skin
            'Load chuc nang
            HienThi_ESSchuc_nang()
            Loader = True
        Else    'Đăng nhập không thành công
            Close()
        End If

    End Sub

    Private Sub OnPaintStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        defaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
    End Sub


    Private Sub ribMain_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RibMain.ItemClick
        If Not e.Item.Tag Is Nothing AndAlso IsNumeric(e.Item.Tag) Then
            Show_form(e.Item.Tag, e.Item.Caption)
        End If
    End Sub

    Private Sub biStyle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biStyle.EditValueChanged
        RibMain.RibbonStyle = CType(biStyle.EditValue, RibbonControlStyle)
    End Sub

    Private Sub mnuPainStyle_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPainStyle.Popup
        For Each link As BarItemLink In mnuPainStyle.ItemLinks
            CType(link.Item, BarCheckItem).Checked = link.Item.Caption = defaultLookAndFeel1.LookAndFeel.ActiveSkinName
        Next link
    End Sub


#Region "Funs"
    Private Sub Show_form(ByVal FunctionID As String, ByVal Caption As String)
        Try
            gFunctionID = FunctionID
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

                Dim xBarItem As New BarButtonItem
                'xBarItem = BarMain.Items.Item(0)
                xBarItem.Tag = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Name = gobjUser.ESSQuyen.Quyen(i).ID_quyen
                xBarItem.Caption = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.Hint = gobjUser.ESSQuyen.Quyen(i).Ten_quyen
                xBarItem.ImageIndex = idx
                mnuHeThong.AddItem(xBarItem)
                ribHeThong.Groups(0).ItemLinks.Add(xBarItem)
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
        staInfomation.Caption = "CHỨC NĂNG: " & frmESS_.Text & " - NGƯỜI DÙNG: " & gobjUser.FullName.ToUpper & " - PHÒNG: " & gobjUser.Phong_ban.ToUpper & " -ĐANG SỬ DỤNG"
        frmESS_.MdiParent = Me
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.WindowState = FormWindowState.Maximized
        frmESS_.Show()
    End Sub
#End Region

 
 
 
End Class
