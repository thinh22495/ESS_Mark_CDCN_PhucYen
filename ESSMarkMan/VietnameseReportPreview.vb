Imports DevExpress.XtraPrinting.Localization
Public Class VietnameseReportPreview
    Inherits PreviewLocalizer
    Public Sub New()

    End Sub
    Public Overrides Function GetLocalizedString(ByVal id As PreviewStringId) As String
        Select Case id
            Case PreviewStringId.Msg_EmptyDocument : Return "Không có tài liệu nào được hiển thị."
            Case PreviewStringId.MenuItem_RtfDocument : Return "Xuất ra Word"
            Case PreviewStringId.ExportOption_RtfExportMode_SingleFile : Return "Xuất 1 tệp"
            Case PreviewStringId.ExportOption_RtfExportMode_SingleFilePageByPage : Return "Xuất 1 tệp theo từng trang"
            Case PreviewStringId.MenuItem_CsvDocument : Return "Xuất ra tệp CSV"
            Case PreviewStringId.MenuItem_Export
                Return "Xuất khẩu"
            Case PreviewStringId.TB_TTip_Export
                Return "Xuất khẩu"
            Case PreviewStringId.TB_TTip_Send
                Return "Gửi email"
            Case PreviewStringId.PreviewForm_Caption : Return "Xem báo cáo"
            Case PreviewStringId.MenuItem_XlsDocument : Return "Xuất ra tệp Excel 2003"
            Case PreviewStringId.MenuItem_XlsxDocument : Return "Xuất ra tệp Excel 2007, 2010"
            Case PreviewStringId.MenuItem_PdfDocument : Return "Xuất ra tệp PDF"
            Case PreviewStringId.MenuItem_Print : Return "Tìm máy in"
            Case PreviewStringId.MenuItem_TxtDocument : Return "Xuất ra tệp Text"
            Case PreviewStringId.BarText_StatusBar : Return "Thanh trạng thái"
            Case PreviewStringId.MenuItem_HtmDocument : Return "Xuất ra tệp HTML"
            Case PreviewStringId.MenuItem_MhtDocument : Return "Xuất ra tệp MHT"
            Case PreviewStringId.MenuItem_GraphicDocument : Return "Xuất ra tệp đồ họa"
            Case PreviewStringId.MenuItem_Exit : Return "Đóng"
            Case PreviewStringId.MenuItem_File : Return "Tệp"
            Case PreviewStringId.MenuItem_Background : Return "Nền"
            Case PreviewStringId.MenuItem_View : Return "Khung nhìn"
            Case PreviewStringId.MenuItem_PrintDirect : Return "In"
            Case PreviewStringId.MenuItem_Send : Return "Email"
            Case PreviewStringId.Msg_WrongPrinter : Return "Máy in không đúng"
            Case PreviewStringId.BarText_MainMenu : Return "Thực đơn chính"
            Case PreviewStringId.BarText_Toolbar : Return "Thanh công cụ"
            Case PreviewStringId.Button_Apply : Return "Áp dụng"
            Case PreviewStringId.Button_Cancel : Return "Hủy bỏ"
            Case PreviewStringId.Button_Help : Return "Trợ giúp"
            Case PreviewStringId.Button_Ok : Return "Đồng ý"
            Case PreviewStringId.MenuItem_BackgrColor : Return "Màu nền"
            Case PreviewStringId.MenuItem_PageSetup : Return "Cài đặt trang"
            Case PreviewStringId.MenuItem_PageLayout : Return "Trang hiển thị"
            Case PreviewStringId.MenuItem_ViewStatusbar : Return "Thanh trạng thái"
            Case PreviewStringId.MenuItem_ViewToolbar : Return "Thanh công cụ"
            Case PreviewStringId.MenuItem_ViewContinuous : Return "Xem nối tiếp"
            Case PreviewStringId.MenuItem_ViewFacing : Return "Xem trực diện"
            Case PreviewStringId.MenuItem_Watermark : Return "Watermark"
            Case Else : Return ""
        End Select
    End Function
End Class