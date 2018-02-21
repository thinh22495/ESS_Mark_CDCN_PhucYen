Public Class frmESS_ThayDoiThanhPhan
    Private Function CheckValidate() As Boolean
        Dim dvTP As DataView = grvThanhPhan.DataSource
        Dim Tong_ty_le As Integer = 0
        For i As Integer = 0 To dvTP.Count - 1
            If dvTP(i)("Chon") Then
                Tong_ty_le += dvTP(i)("Ty_le")
            End If
        Next
        If Tong_ty_le > 100 Or Tong_ty_le < 0 Then
            Return True
        Else
            Return True
        End If
    End Function
    Public Overloads Sub ShowDialog(ByVal dtTP As DataTable)
        grcThanhPhan.DataSource = dtTP.DefaultView
        Me.ShowDialog()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If CheckValidate() Then
            Me.Tag = 1
            Close()
        Else
            Thongbao("Bạn phải nhập tổng tỷ lệ lớn hơn 0 và nhỏ hơn 100")
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = 0
        Close()
    End Sub

End Class