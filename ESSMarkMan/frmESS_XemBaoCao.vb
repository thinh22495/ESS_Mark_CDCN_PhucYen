Imports ESS.Bussines
Public Class frmESS_XemBaoCao
    Public Overloads Sub ShowDialog_New(ByVal ReportName As String, ByVal DataReport As DataTable, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
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
                    C1Report1.Fields("Tieu_de_chuc_danh3").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
                    C1Report1.Fields("Tieu_de_chuc_danh4").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
                    C1Report1.Fields("Tieu_de_nguoi_ky3").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
                    C1Report1.Fields("Tieu_de_nguoi_ky4").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4
                    C1Report1.Fields("Tieu_de_noi_ky").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
                Else
                    C1Report1.Fields("Tieu_de_ten_bo").Text = ""
                    C1Report1.Fields("Tieu_de_Ten_truong").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh1").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh2").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh3").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh4").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky3").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky4").Text = ""
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

    Public Overloads Sub ShowDialog(ByVal ReportName As String, ByVal DataReport As DataTable, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
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
                    C1Report1.Fields("Tieu_de_chuc_danh3").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
                    C1Report1.Fields("Tieu_de_nguoi_ky3").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
                    C1Report1.Fields("Tieu_de_noi_ky").Text = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
                Else
                    C1Report1.Fields("Tieu_de_ten_bo").Text = ""
                    C1Report1.Fields("Tieu_de_Ten_truong").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh1").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh2").Text = ""
                    C1Report1.Fields("Tieu_de_chuc_danh3").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky1").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky2").Text = ""
                    C1Report1.Fields("Tieu_de_nguoi_ky3").Text = ""
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

    Public Overloads Sub ShowDialog_RFix(ByVal ReportName As String, ByVal DataReport As DataTable)
        Try
            Dim objReport As New ReportView_Bussines
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(ReportName)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)

                'Gán các tiêu đề cho báo cáo
                If DataReport.Rows.Count > 0 Then

                End If
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

    Public Overloads Sub ShowDialog_RFix_Print(ByVal ReportName As String, ByVal DataReport As DataTable)
        Try
            Dim objReport As New ReportView_Bussines
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(ReportName)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)

                'Gán các tiêu đề cho báo cáo
                If DataReport.Rows.Count > 0 Then

                End If
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, ReportName)
                C1Report1.DataSource.Recordset = DataReport

                'Hiển thị nội dung C1R trên báo cáo
                C1PrintPreview1.Document = C1Report1.Document
                ' Print
                Dim ps As New System.Drawing.Printing.PrinterSettings
                ps.DefaultPageSettings.PaperSize = C1PrintPreview1.PageSettings.PaperSize
                C1PrintPreview1.Print(ps)
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

    Public Overloads Sub ShowDialog_Tuithi(ByVal dtRpt_main As DataTable, ByVal mID_thi As Integer, ByVal clsTCThi As TochucThi_Bussines, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ReportNam_Main As String, ByVal ReportNam_Sub As String)
        Try
            Dim dt_dsTuithi As DataTable = clsTCThi.DanhSachTuiThi(mID_thi)
            Dim So_lan_in As Integer = 0
            Dim So_du As Integer = 0
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote, mCa_thi As String

            dt_dsTuithi.DefaultView.Sort = "Tui_so"
            If dt_dsTuithi.Rows.Count >= 4 Then
                So_lan_in = dt_dsTuithi.Rows.Count / 4 - 0.49
                So_du = dt_dsTuithi.Rows.Count Mod 4
            Else
                So_du = dt_dsTuithi.Rows.Count
            End If

            If dtRpt_main.Rows.Count > 0 Then
                If dtRpt_main.Rows(0).Item("Ca_thi") = "0" Then mCa_thi = "Sáng"
                If dtRpt_main.Rows(0).Item("Ca_thi") = "1" Then mCa_thi = "Chiều"
                If dtRpt_main.Rows(0).Item("Ca_thi") = "2" Then mCa_thi = "Tối"
            End If
            For i As Integer = 0 To dtRpt_main.Rows.Count - 1
                clsTCThi.DanhSachMonToChucThi()
                dtRpt_main.Rows(i).Item("Ten_ca") = mCa_thi
                dtRpt_main.Rows(i).Item("Nhom_tiet") = dtRpt_main.Rows(0).Item("Nhom_tiet") + 1
                dtRpt_main.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dtRpt_main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                dtRpt_main.Rows(i).Item("Hoc_ky") = Hoc_ky
                dtRpt_main.Rows(i).Item("Nam_hoc") = Nam_hoc
            Next


            If So_lan_in > 0 Then
                For k As Integer = 0 To So_lan_in - 1
                    ReportNote = objReport.LoadReportNote(ReportNam_Main & 4)
                    If ReportNote <> "" Then
                        Dim Doc As New System.Xml.XmlDocument
                        'Đưa nội dung báo cáo vào đối tượng Doc
                        Doc.LoadXml(ReportNote)
                        'Đưa nội dung và dữ liệu vào đối tượng C1R
                        C1Report1.Load(Doc, ReportNam_Main & 4)
                        C1Report1.DataSource.Recordset = dtRpt_main

                        '======Report Sub=================
                        For i As Integer = 1 To 4
                            Dim C1rSub As New C1.Win.C1Report.C1Report
                            Dim ReportNoteSub As String
                            ReportNoteSub = objReport.LoadReportNote(ReportNam_Sub & i)
                            If ReportNoteSub <> "" Then
                                Dim DocSub As New System.Xml.XmlDocument
                                'Đưa nội dung báo cáo vào đối tượng Doc
                                DocSub.LoadXml(ReportNoteSub)
                                'Đưa nội dung và dữ liệu vào đối tượng C1R
                                C1rSub.Load(DocSub, ReportNam_Sub & i)
                                C1rSub.DataSource.Recordset = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, dt_dsTuithi.DefaultView.Item(i + 4 * k - 1)("Tui_so"))

                                C1Report1.Fields("rptSub" & i).Subreport = C1rSub
                            End If
                        Next

                        C1PrintPreview1.Document = C1Report1.Document
                        Me.ShowDialog()
                    End If
                Next
            End If
            'In danh sach khi con so du phong ca 2 truong hop So_lan_in>0 va So_lan_in=0
            If So_du > 0 Then
                ReportNote = objReport.LoadReportNote(ReportNam_Main & So_du)
                If ReportNote <> "" Then
                    Dim Doc As New System.Xml.XmlDocument
                    Doc.LoadXml(ReportNote)
                    C1Report1.Load(Doc, ReportNam_Main & So_du)
                    C1Report1.DataSource.Recordset = dtRpt_main
                    For i As Integer = 1 To So_du
                        Dim C1rSub As New C1.Win.C1Report.C1Report
                        Dim ReportNoteSub As String
                        ReportNoteSub = objReport.LoadReportNote(ReportNam_Sub & i)
                        If ReportNoteSub <> "" Then
                            Dim DocSub As New System.Xml.XmlDocument
                            DocSub.LoadXml(ReportNoteSub)
                            C1rSub.Load(DocSub, ReportNam_Sub & i)
                            C1rSub.DataSource.Recordset = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, dt_dsTuithi.DefaultView.Item(i + 4 * So_lan_in - 1)("Tui_so"))
                            C1Report1.Fields("rptSub" & i).Subreport = C1rSub
                        End If
                    Next
                    C1PrintPreview1.Document = C1Report1.Document
                    Me.ShowDialog()
                End If
            End If
        Catch Er As Exception
            Throw Er
        End Try
    End Sub

    Public Overloads Sub ShowDialog_Tuithi_HuongDan(ByVal dtRpt_main As DataTable, ByVal mID_thi As Integer, ByVal clsTCThi As TochucThi_Bussines, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ReportNam_Main As String, ByVal ReportNam_Sub As String)
        Try
            Dim dt_dsTuithi As DataTable = clsTCThi.DanhSachTuiThi(mID_thi)
            Dim So_lan_in As Integer = 0
            Dim So_du As Integer = 0
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote, mCa_thi As String

            dt_dsTuithi.DefaultView.Sort = "Tui_so"
            If dt_dsTuithi.Rows.Count >= 4 Then
                So_lan_in = dt_dsTuithi.Rows.Count / 4 - 0.49
                So_du = dt_dsTuithi.Rows.Count Mod 4
            Else
                So_du = dt_dsTuithi.Rows.Count
            End If

            If dtRpt_main.Rows.Count > 0 Then
                If dtRpt_main.Rows(0).Item("Ca_thi") = "0" Then mCa_thi = "Sáng"
                If dtRpt_main.Rows(0).Item("Ca_thi") = "1" Then mCa_thi = "Chiều"
                If dtRpt_main.Rows(0).Item("Ca_thi") = "2" Then mCa_thi = "Tối"
            End If
            For i As Integer = 0 To dtRpt_main.Rows.Count - 1
                clsTCThi.DanhSachMonToChucThi()
                dtRpt_main.Rows(i).Item("Ten_ca") = mCa_thi
                dtRpt_main.Rows(i).Item("Nhom_tiet") = dtRpt_main.Rows(0).Item("Nhom_tiet") + 1
                dtRpt_main.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dtRpt_main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                dtRpt_main.Rows(i).Item("Hoc_ky") = Hoc_ky
                dtRpt_main.Rows(i).Item("Nam_hoc") = Nam_hoc
            Next


            If So_lan_in > 0 Then
                For k As Integer = 0 To So_lan_in - 1
                    ReportNote = objReport.LoadReportNote(ReportNam_Main & 4)
                    If ReportNote <> "" Then
                        Dim Doc As New System.Xml.XmlDocument
                        'Đưa nội dung báo cáo vào đối tượng Doc
                        Doc.LoadXml(ReportNote)
                        'Đưa nội dung và dữ liệu vào đối tượng C1R
                        C1Report1.Load(Doc, ReportNam_Main & 4)
                        C1Report1.DataSource.Recordset = dtRpt_main

                        '======Report Sub=================
                        For i As Integer = 1 To 4
                            Dim C1rSub As New C1.Win.C1Report.C1Report
                            Dim ReportNoteSub As String
                            ReportNoteSub = objReport.LoadReportNote(ReportNam_Sub & i)
                            If ReportNoteSub <> "" Then
                                Dim DocSub As New System.Xml.XmlDocument
                                'Đưa nội dung báo cáo vào đối tượng Doc
                                DocSub.LoadXml(ReportNoteSub)
                                'Đưa nội dung và dữ liệu vào đối tượng C1R
                                C1rSub.Load(DocSub, ReportNam_Sub & i)
                                C1rSub.DataSource.Recordset = clsTCThi.DanhSachSinhVienTheoTuiThi_HuongDan(mID_thi, dt_dsTuithi.DefaultView.Item(i + 4 * k - 1)("Tui_so"))

                                C1Report1.Fields("rptSub" & i).Subreport = C1rSub
                            End If
                        Next

                        C1PrintPreview1.Document = C1Report1.Document
                        Me.ShowDialog()
                    End If
                Next
            End If
            'In danh sach khi con so du phong ca 2 truong hop So_lan_in>0 va So_lan_in=0
            If So_du > 0 Then
                ReportNote = objReport.LoadReportNote(ReportNam_Main & So_du)
                If ReportNote <> "" Then
                    Dim Doc As New System.Xml.XmlDocument
                    Doc.LoadXml(ReportNote)
                    C1Report1.Load(Doc, ReportNam_Main & So_du)
                    C1Report1.DataSource.Recordset = dtRpt_main
                    For i As Integer = 1 To So_du
                        Dim C1rSub As New C1.Win.C1Report.C1Report
                        Dim ReportNoteSub As String
                        ReportNoteSub = objReport.LoadReportNote(ReportNam_Sub & i)
                        If ReportNoteSub <> "" Then
                            Dim DocSub As New System.Xml.XmlDocument
                            DocSub.LoadXml(ReportNoteSub)
                            C1rSub.Load(DocSub, ReportNam_Sub & i)
                            C1rSub.DataSource.Recordset = clsTCThi.DanhSachSinhVienTheoTuiThi_HuongDan(mID_thi, dt_dsTuithi.DefaultView.Item(i + 4 * So_lan_in - 1)("Tui_so"))
                            C1Report1.Fields("rptSub" & i).Subreport = C1rSub
                        End If
                    Next
                    C1PrintPreview1.Document = C1Report1.Document
                    Me.ShowDialog()
                End If
            End If
        Catch Er As Exception
            Throw Er
        End Try
    End Sub

    Public Overloads Sub ShowDialog(ByVal dtRpt_main As DataTable, ByVal mID_thi As Integer, ByVal clsTCThi As TochucThi_Bussines, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ReportNam_Main As String, ByVal ReportNam_Sub As String)
        Try
            Dim dt_dsPhong As DataTable = clsTCThi.DanhSachPhongThi(mID_thi)
            Dim So_lan_in As Integer = 0
            Dim So_du As Integer = 0
            Dim objReport As New ReportView_Bussines
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            Dim ReportNote, mCa_thi As String

            If dt_dsPhong.Rows.Count >= 4 Then
                So_lan_in = dt_dsPhong.Rows.Count / 4 - 0.49
                So_du = dt_dsPhong.Rows.Count Mod 4
            Else
                So_du = dt_dsPhong.Rows.Count
            End If

            If dtRpt_main.Rows.Count > 0 Then
                If dtRpt_main.Rows(0).Item("Ca_thi") = "0" Then mCa_thi = "Sáng"
                If dtRpt_main.Rows(0).Item("Ca_thi") = "1" Then mCa_thi = "Chiều"
                If dtRpt_main.Rows(0).Item("Ca_thi") = "2" Then mCa_thi = "Tối"
            End If
            For i As Integer = 0 To dtRpt_main.Rows.Count - 1
                clsTCThi.DanhSachMonToChucThi()
                dtRpt_main.Rows(i).Item("Ten_ca") = mCa_thi
                dtRpt_main.Rows(i).Item("Nhom_tiet") = dtRpt_main.Rows(0).Item("Nhom_tiet") + 1
                dtRpt_main.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dtRpt_main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                dtRpt_main.Rows(i).Item("Hoc_ky") = Hoc_ky
                dtRpt_main.Rows(i).Item("Nam_hoc") = Nam_hoc
            Next


            If So_lan_in > 0 Then
                For k As Integer = 0 To So_lan_in - 1
                    ReportNote = objReport.LoadReportNote(ReportNam_Main & 4)
                    If ReportNote <> "" Then
                        Dim Doc As New System.Xml.XmlDocument
                        'Đưa nội dung báo cáo vào đối tượng Doc
                        Doc.LoadXml(ReportNote)
                        'Đưa nội dung và dữ liệu vào đối tượng C1R
                        C1Report1.Load(Doc, ReportNam_Main & 4)
                        C1Report1.DataSource.Recordset = dtRpt_main

                        '======Report Sub=================
                        For i As Integer = 1 To 4
                            Dim C1rSub As New C1.Win.C1Report.C1Report
                            Dim ReportNoteSub As String
                            ReportNoteSub = objReport.LoadReportNote(ReportNam_Sub & i)
                            If ReportNoteSub <> "" Then
                                Dim DocSub As New System.Xml.XmlDocument
                                'Đưa nội dung báo cáo vào đối tượng Doc
                                DocSub.LoadXml(ReportNoteSub)
                                'Đưa nội dung và dữ liệu vào đối tượng C1R
                                C1rSub.Load(DocSub, ReportNam_Sub & i)
                                C1rSub.DataSource.Recordset = clsTCThi.DanhSachSBDSoPhachTheoPhongThi(mID_thi, dt_dsPhong.Rows(i + 4 * k - 1).Item("ID_phong_thi"))

                                C1Report1.Fields("rptSub" & i).Subreport = C1rSub
                            End If
                        Next

                        C1PrintPreview1.Document = C1Report1.Document
                        Me.ShowDialog()
                    End If
                Next
            End If
            'In danh sach khi con so du phong ca 2 truong hop So_lan_in>0 va So_lan_in=0
            If So_du > 0 Then
                ReportNote = objReport.LoadReportNote(ReportNam_Main & So_du)
                If ReportNote <> "" Then
                    Dim Doc As New System.Xml.XmlDocument
                    Doc.LoadXml(ReportNote)
                    C1Report1.Load(Doc, ReportNam_Main & So_du)
                    C1Report1.DataSource.Recordset = dtRpt_main
                    For i As Integer = 1 To So_du
                        Dim C1rSub As New C1.Win.C1Report.C1Report
                        Dim ReportNoteSub As String
                        ReportNoteSub = objReport.LoadReportNote(ReportNam_Sub & i)
                        If ReportNoteSub <> "" Then
                            Dim DocSub As New System.Xml.XmlDocument
                            DocSub.LoadXml(ReportNoteSub)
                            C1rSub.Load(DocSub, ReportNam_Sub & i)
                            C1rSub.DataSource.Recordset = clsTCThi.DanhSachSBDSoPhachTheoPhongThi(mID_thi, dt_dsPhong.Rows(i + 4 * So_lan_in - 1).Item("ID_phong_thi"))
                            C1Report1.Fields("rptSub" & i).Subreport = C1rSub
                        End If
                    Next
                    C1PrintPreview1.Document = C1Report1.Document
                    Me.ShowDialog()
                End If
            End If
        Catch Er As Exception
            Throw Er
        End Try
    End Sub
    Public Overloads Sub ShowDialog_PrintAll(ByVal ReportName As String, ByVal DataReport As DataTable)
        Try
            Dim objReport As New ReportView_Bussines
            Dim ReportNote As String
            ReportNote = objReport.LoadReportNote(ReportName)
            If ReportNote <> "" Then
                Dim Doc As New System.Xml.XmlDocument
                'Đưa nội dung báo cáo vào đối tượng Doc
                Doc.LoadXml(ReportNote)

                'Gán các tiêu đề cho báo cáo
                If DataReport.Rows.Count > 0 Then

                End If
                'Đưa nội dung và dữ liệu vào đối tượng C1R
                C1Report1.Load(Doc, ReportName)
                C1Report1.DataSource.Recordset = DataReport

                'Hiển thị nội dung C1R trên báo cáo
                C1PrintPreview1.Document = C1Report1.Document
                C1PrintPreview1.Document.PrinterSettings = C1PrintPreview1.PrinterSettings
                C1PrintPreview1.Document.Print()
            Else
                Thongbao("Không có nội dung báo cáo !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Overloads Sub ShowDialog_Print(ByVal c1r As C1.Win.C1Report.C1Report)
        Try
            'Hiển thị nội dung C1R trên báo cáo
            C1PrintPreview1.Document = c1r.Document
            'Hiển thị nội dung C1R trên báo cáo
            C1PrintPreview1.Document.PrinterSettings = C1PrintPreview1.PrinterSettings
            C1PrintPreview1.Document.Print()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class