Imports ESS.Objects
Imports ESS.Bussines
Public Class frmESS_ThamSoHeThong
#Region "Var"
    Private ClsThamsohethong As New ThamSoHeThong_Bussines(gID_ph)
    Private dtThamsohethong As New DataTable
    Dim Loaded As Boolean = False
#End Region
#Region "Form Events"
    Private Sub frmESS_ThamSoHeThong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdThamSoHeThong)
        HienThi_ESSdata()
        Loaded = True
    End Sub
#End Region
#Region "Control Events"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim Co As Boolean = False
            If Me.grdThamSoHeThong.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grdThamSoHeThong.DataSource
            If Thongbao("Bạn có thực sự muốn thay đổi không ? ", MsgBoxStyle.OkCancel, "Thông Báo") = MsgBoxResult.Ok Then
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i).Row.RowState = DataRowState.Modified Then
                        'ClsThamsohethong.aThamSoHeThongs.Remove(i)
                        Dim thamsohethong As New ESSThamSoHeThong
                        thamsohethong.ID_tham_so = dv.Item(i)("ID_tham_so")
                        If IsDBNull(dv.Item(i)("Gia_tri").ToString.Trim) Then
                            thamsohethong.Gia_tri = ""
                        Else
                            thamsohethong.Gia_tri = dv.Item(i)("Gia_tri")
                        End If
                        thamsohethong.Ten_tham_so = dv.Item(i)("Ten_tham_so")
                        thamsohethong.Ghi_chu = dv.Item(i)("Ghi_chu")
                        thamsohethong.ID_ph = dv.Item(i)("ID_ph")
                        thamsohethong.Active = dv.Item(i)("Active")
                        ClsThamsohethong.CapNhat_ESSThamSoHeThong(thamsohethong)
                        Co = True
                    End If
                Next
                If Not Co Then
                    HienThi_ESSdata()
                    Thongbao("Chưa thay đổi được ", MsgBoxStyle.OkOnly)
                Else
                    Thongbao("Đã thay đổi thành công ", MsgBoxStyle.OkOnly)
                End If
            Else
                HienThi_ESSdata()
            End If
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
#End Region
#Region "User Functions"
    Private Sub HienThi_ESSdata()
        dtThamsohethong = ClsThamsohethong.HienThi_ESSThamSoHeThong
        Me.grdThamSoHeThong.DataSource = dtThamsohethong.DefaultView
    End Sub
#End Region
End Class