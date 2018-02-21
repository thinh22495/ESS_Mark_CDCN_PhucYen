Imports ESS.Bussines
Public Class frmESS_ReportView
    Public Overloads Sub ShowDialog(ByVal ReportName As String, ByVal DataReport As Object, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        Try
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(ReportName)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, ReportName)
                C1Report1.DataSource.Recordset = DataReport
                'Gán các tiêu đề cho báo cáo
                If Tieu_de1 <> "" Then C1Report1.Fields("Tieu_de1").Text = Tieu_de1
                If Tieu_de2 <> "" Then C1Report1.Fields("Tieu_de2").Text = Tieu_de2
                If Tieu_de3 <> "" Then C1Report1.Fields("Tieu_de3").Text = Tieu_de3
                If Tieu_de4 <> "" Then C1Report1.Fields("Tieu_de4").Text = Tieu_de4
                If objBaoCaoTieuDe.Count > 0 Then
                    C1Report1.Fields("Tieu_de_ten_bo").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    C1Report1.Fields("Tieu_de_Ten_truong").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    C1Report1.Fields("Tieu_de_chuc_danh1").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
                    C1Report1.Fields("Tieu_de_chuc_danh2").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
                    C1Report1.Fields("Tieu_de_noi_ky").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
                Else
                    C1Report1.Fields("Tieu_de_ten_bo").Text = ""
                    C1Report1.Fields("Tieu_de_Ten_truong").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh1").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh2").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = ""
                    C1Report1.Fields("Tieu_de_noi_ky").Text = ""
                End If
                'Hiển thị nội dung C1R trên báo cáo
                C1PrintPreview1.Document = C1Report1.Document
            Else
                Thongbao("Không có nội dung báo cáo !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.ShowDialog()
    End Sub
    ' Hiển thị báo cáo sub
    Public Overloads Sub ShowDialog(ByVal rptName_main As String, ByVal dtRpt_main As DataTable, ByVal rptName_sub As String, ByVal dtRpt_sub As DataTable, ByVal FieldReportSub As String, Optional ByVal FieldReportSub1 As String = "", Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        Try
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(rptName_main)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, rptName_main)
                C1Report1.DataSource.Recordset = dtRpt_main
                'Gán các tiêu đề cho báo cáo
                If Tieu_de1 <> "" Then C1Report1.Fields("Tieu_de1").Text = Tieu_de1
                If Tieu_de2 <> "" Then C1Report1.Fields("Tieu_de2").Text = Tieu_de2
                If Tieu_de3 <> "" Then C1Report1.Fields("Tieu_de3").Text = Tieu_de3
                If Tieu_de4 <> "" Then C1Report1.Fields("Tieu_de4").Text = Tieu_de4
                If objBaoCaoTieuDe.Count > 0 Then
                    C1Report1.Fields("Tieu_de_ten_bo").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    C1Report1.Fields("Tieu_de_Ten_truong").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    C1Report1.Fields("Tieu_de_chuc_danh1").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
                    C1Report1.Fields("Tieu_de_chuc_danh2").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
                    C1Report1.Fields("Tieu_de_noi_ky").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
                Else
                    C1Report1.Fields("Tieu_de_ten_bo").Text = ""
                    C1Report1.Fields("Tieu_de_Ten_truong").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh1").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh2").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = ""
                    C1Report1.Fields("Tieu_de_noi_ky").Text = ""
                End If
                '======Report Sub=================
                Dim C1rSub As New C1.Win.C1Report.C1Report
                Dim ReportNoteSub As String
                ReportNoteSub = objReport.LoadReportNote(rptName_sub)
                If ReportNoteSub <> "" Then
                    Dim DocSub As New System.Xml.XmlDocument
                    'Đưa nội dung báo cáo vào đối tượng Doc
                    DocSub.LoadXml(ReportNoteSub)
                    'Đưa nội dung và dữ liệu vào đối tượng C1R
                    C1rSub.Load(DocSub, rptName_sub)
                    C1rSub.DataSource.Recordset = dtRpt_sub
                    C1Report1.Fields(FieldReportSub).Subreport = C1rSub
                    If FieldReportSub1 <> "" Then C1Report1.Fields(FieldReportSub1).Subreport = C1rSub
                End If
                'Hien thi bao cao len man hinh
                C1PrintPreview1.Document = C1Report1.Document
            End If
        Catch Er As Exception
            Throw Er
        End Try
        Me.ShowDialog()
    End Sub
    ' Hiển thị báo cáo sub
    Public Overloads Sub ShowDialogBienLai(ByVal rptName_main As String, ByVal dtRpt_main As DataTable, ByVal rptName_sub As String, ByVal dtRpt_sub As DataTable, ByVal FieldReportSub As String, Optional ByVal FieldReportSub1 As String = "", Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        Try
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(rptName_main)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, rptName_main)
                C1Report1.DataSource.Recordset = dtRpt_main
                'Gán các tiêu đề cho báo cáo
                If Tieu_de1 <> "" Then C1Report1.Fields("Tieu_de1").Text = Tieu_de1
                If Tieu_de2 <> "" Then C1Report1.Fields("Tieu_de2").Text = Tieu_de2
                If Tieu_de3 <> "" Then C1Report1.Fields("Tieu_de3").Text = Tieu_de3
                If Tieu_de4 <> "" Then C1Report1.Fields("Tieu_de4").Text = Tieu_de4
                '======Report Sub=================
                Dim C1rSub As New C1.Win.C1Report.C1Report
                Dim ReportNoteSub As String
                ReportNoteSub = objReport.LoadReportNote(rptName_sub)
                If ReportNoteSub <> "" Then
                    Dim DocSub As New System.Xml.XmlDocument
                    'Đưa nội dung báo cáo vào đối tượng Doc
                    DocSub.LoadXml(ReportNoteSub)
                    'Đưa nội dung và dữ liệu vào đối tượng C1R
                    C1rSub.Load(DocSub, rptName_sub)
                    C1rSub.DataSource.Recordset = dtRpt_sub
                    C1Report1.Fields(FieldReportSub).Subreport = C1rSub
                    If FieldReportSub1 <> "" Then C1Report1.Fields(FieldReportSub1).Subreport = C1rSub
                End If
                'Hien thi bao cao len man hinh
                C1PrintPreview1.Document = C1Report1.Document
            End If
        Catch Er As Exception
            Throw Er
        End Try
        Me.ShowDialog()
    End Sub
    Public Overloads Sub ShowDialogBienLai(ByVal rptName_main As String, ByVal dtRpt_main As DataTable)
        Try
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(rptName_main)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, rptName_main)
                C1Report1.DataSource.Recordset = dtRpt_main
                '======Report Sub=================
                Dim C1rSub As New C1.Win.C1Report.C1Report
                'Hien thi bao cao len man hinh
                C1PrintPreview1.Document = C1Report1.Document
            End If
        Catch Er As Exception
            Throw Er
        End Try
        Me.ShowDialog()
    End Sub
    ' Print báo cáo sub
    Public Overloads Sub PrintBienLai(ByVal rptName_main As String, ByVal dtRpt_main As DataTable, ByVal rptName_sub As String, ByVal dtRpt_sub As DataTable, ByVal FieldReportSub As String, Optional ByVal FieldReportSub1 As String = "", Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        Try
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(rptName_main)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, rptName_main)
                C1Report1.DataSource.Recordset = dtRpt_main
                'Gán các tiêu đề cho báo cáo
                If Tieu_de1 <> "" Then C1Report1.Fields("Tieu_de1").Text = Tieu_de1
                If Tieu_de2 <> "" Then C1Report1.Fields("Tieu_de2").Text = Tieu_de2
                If Tieu_de3 <> "" Then C1Report1.Fields("Tieu_de3").Text = Tieu_de3
                If Tieu_de4 <> "" Then C1Report1.Fields("Tieu_de4").Text = Tieu_de4
                '======Report Sub=================
                Dim C1rSub As New C1.Win.C1Report.C1Report
                Dim ReportNoteSub As String
                ReportNoteSub = objReport.LoadReportNote(rptName_sub)
                If ReportNoteSub <> "" Then
                    Dim DocSub As New System.Xml.XmlDocument
                    'Đưa nội dung báo cáo vào đối tượng Doc
                    DocSub.LoadXml(ReportNoteSub)
                    'Đưa nội dung và dữ liệu vào đối tượng C1R
                    C1rSub.Load(DocSub, rptName_sub)
                    C1rSub.DataSource.Recordset = dtRpt_sub
                    C1Report1.Fields(FieldReportSub).Subreport = C1rSub
                    If FieldReportSub1 <> "" Then C1Report1.Fields(FieldReportSub1).Subreport = C1rSub
                End If
                'Hien thi bao cao len man hinh
                C1PrintPreview1.Document = C1Report1.Document
                Dim ps As New System.Drawing.Printing.PrinterSettings
                ps.DefaultPageSettings.PaperSize = C1PrintPreview1.PageSettings.PaperSize
                C1PrintPreview1.Print(ps)
            End If
        Catch Er As Exception
            Throw Er
        End Try
    End Sub
    Public Overloads Sub PrintBienLai(ByVal rptName_main As String, ByVal dtRpt_main As DataTable)
        Try
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(rptName_main)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, rptName_main)
                C1Report1.DataSource.Recordset = dtRpt_main
                'Hien thi bao cao len man hinh
                C1PrintPreview1.Document = C1Report1.Document
                Dim ps As New System.Drawing.Printing.PrinterSettings
                ps.DefaultPageSettings.PaperSize = C1PrintPreview1.PageSettings.PaperSize
                C1PrintPreview1.Print(ps)
            End If
        Catch Er As Exception
            Throw Er
        End Try
    End Sub


    Public Overloads Sub ShowDialog_RFix(ByVal ReportName As String, ByVal DataReport As DataTable)
        Try
            Dim objReport As New ReportView_Bussines
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(ReportName)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)

                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, ReportName)
                C1Report1.DataSource.Recordset = DataReport

                'Hiển thị nội dung C1R trên báo cáo
                C1PrintPreview1.Document = C1Report1.Document
            Else
                Thongbao("Không có nội dung báo cáo !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.ShowDialog()
    End Sub
    Public Overloads Sub ShowDialog(ByVal c1r As C1.Win.C1Report.C1Report)
        Try
            'Hiển thị nội dung C1R trên báo cáo
            C1PrintPreview1.Document = c1r.Document
            Me.ShowDialog()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class