Module mdlMsg
    Public Const msgDELETE As String = "Chắc chắn bạn có muốn xóa bản ghi này không ?"
    Public Const msgUPDATED As String = "Dữ liệu đã được cập nhật !"
    Public Const msgADD As String = "Chắc chắn bạn có muốn bổ sung mới không ?"
    Public Const msgEXIST As String = "Dữ liệu đã tồn tại, bạn nhập dữ liệu khác !"
    Public Const msgERRO As String = "Hãy liên lạc với người quản trị để được trợ giúp"

    Private Sub EnableButton(ByVal objButton As Object, ByVal txtButton As String, ByVal leftButton As Long)
        objButton.Visible = True
        objButton.Left = leftButton
        objButton.Text = txtButton
    End Sub

    Public Function Thongbao(ByVal MSG As Object, Optional ByVal Button As MsgBoxStyle = MsgBoxStyle.Information, Optional ByVal Title As String = "Thông báo", Optional ByVal Align As ContentAlignment = ContentAlignment.MiddleCenter) As MsgBoxResult
        Dim frmESS_MSG As New frmESS_MsgBox
        Dim Result1, Result2, Result3 As MsgBoxResult
        'Dim Thongbao_icon
        'Dim ClickButton
        Dim leftBtn As Double
        frmESS_MSG.lblMSG.Text = MSG
        frmESS_MSG.lblMSG.TextAlign = Align
        frmESS_MSG.Text = Title
        frmESS_MSG.picIcon.Image = Nothing
        'Select Button Display
        Select Case Button
            Case 0, 16, 32, 48, 64, 256, 512    'OK Default
                leftBtn = (frmESS_MSG.Width - frmESS_MSG.Button1.Width) / 2
                EnableButton(frmESS_MSG.Button1, "&Thoát", leftBtn)
                Result1 = MsgBoxResult.OK
            Case 1, 17, 33, 49, 65, 257, 513
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width + 5)
                EnableButton(frmESS_MSG.Button1, "Đồn&g ý", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) + 5
                EnableButton(frmESS_MSG.Button2, "&Huỷ bỏ", leftBtn)
                Result1 = MsgBoxResult.OK
                Result2 = MsgBoxResult.Cancel
            Case 2, 18, 34, 50, 66, 258, 514
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width * 1.5 + 10)
                EnableButton(frmESS_MSG.Button1, "&Thoát", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width / 2)
                EnableButton(frmESS_MSG.Button2, "Thử &lại", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) + frmESS_MSG.Button1.Width * 0.5 + 10
                EnableButton(frmESS_MSG.Button3, "&Bỏ qua", leftBtn)
                Result1 = MsgBoxResult.Abort
                Result2 = MsgBoxResult.Retry
                Result3 = MsgBoxResult.Ignore
            Case 3, 19, 35, 51, 67, 259, 515
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width * 1.5 + 10)
                EnableButton(frmESS_MSG.Button1, "&Có", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width / 2)
                EnableButton(frmESS_MSG.Button2, "&Không", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) + frmESS_MSG.Button1.Width * 0.5 + 10
                EnableButton(frmESS_MSG.Button3, "&Huỷ bỏ", leftBtn)
                Result1 = MsgBoxResult.Yes
                Result2 = MsgBoxResult.No
                Result3 = MsgBoxResult.Cancel
            Case 4, 20, 36, 52, 68, 260, 516
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width + 5)
                EnableButton(frmESS_MSG.Button1, "&Có", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) + 5
                EnableButton(frmESS_MSG.Button2, "&Không", leftBtn)
                Result1 = MsgBoxResult.Yes
                Result2 = MsgBoxResult.No
            Case 5, 21, 37, 53, 69, 261, 517
                leftBtn = (frmESS_MSG.Width / 2) - (frmESS_MSG.Button1.Width + 5)
                EnableButton(frmESS_MSG.Button1, "Thử &lại", leftBtn)
                leftBtn = (frmESS_MSG.Width / 2) + 5
                EnableButton(frmESS_MSG.Button2, "&Huỷ bỏ", leftBtn)
                Result1 = MsgBoxResult.Retry
                Result2 = MsgBoxResult.Cancel
        End Select
        'Select icon
        Select Case Button
            Case 16, 17, 18, 19, 20, 21, 272, 528
                frmESS_MSG.picIcon.Image = frmESS_MSG.picCritical.Image
            Case 32, 33, 34, 35, 36, 37, 288, 544
                frmESS_MSG.picIcon.Image = frmESS_MSG.picQuestion.Image
            Case 48, 49, 50, 51, 52, 53, 304, 560
                frmESS_MSG.picIcon.Image = frmESS_MSG.picExclame.Image
            Case 64, 65, 66, 67, 68, 69, 310, 576
                frmESS_MSG.picIcon.Image = frmESS_MSG.picInfo.Image
            Case Else
                frmESS_MSG.picIcon.Image = frmESS_MSG.picInfo.Image
        End Select
        'Default Button
        Select Case Button
            Case 0

            Case 256

            Case 512

        End Select
        frmESS_MSG.ShowDialog()
        Select Case frmESS_MSG.Tag.ToString
            Case 1
                Thongbao = Result1
            Case 2
                Thongbao = Result2
            Case 3
                Thongbao = Result3
        End Select
    End Function
End Module
