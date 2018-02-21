'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports ESS.DataAccess
Namespace Bussines
    Public Class ReportView_Bussines
        Public Function LoadReportNote(ByVal ReportName As String) As String
            Dim ReportNote As String = ""
            Dim objReport As New ReportView_DataAccess
            'Load nội dung báo cáo
            Dim dt As DataTable = objReport.HienThi_ESSReport_Note(ReportName)
            'Lấy nội dung báo cáo
            If dt.Rows.Count > 0 Then
                ReportNote = dt.Rows(0).Item("ReportNote")
            End If
            Return ReportNote
        End Function
        Public Function GetReport(ByVal ReportName As String) As DataTable
            Dim objReport As New ReportView_DataAccess
            'Load nội dung báo cáo
            Dim dt As DataTable = objReport.HienThi_ESSReport_Note(ReportName)
            Return dt
        End Function

    End Class
End Namespace
