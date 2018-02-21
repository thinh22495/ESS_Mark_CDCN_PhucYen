Module mdlCommon
    Public Function GetReportDate() As String
        Return ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Function
End Module
