Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ReportView
    Private reportname As String = ""
    Private rptdatasource As DataView
    Private mPrint As Boolean = False
    Public rptdatasourceSub As DataView
    Dim objBaoCaoTieuDe As BaoCaoTieuDe_Bussines

    Private Tieu_de_ten_bo As String = ""
    Private Tieu_de_ten_truong As String = ""
    Private Tieu_de1 As String = ""
    Private Tieu_de2 As String = ""
    Private Tieu_de3 As String = ""
    Private Tieu_de4 As String = ""
    Private Tieu_de5 As String = ""
    Private Tieu_de6 As String = ""
    Private Tieu_de7 As String = ""
    Private Tieu_de_noi_ky As String = ""
    Private Tieu_de_chuc_danh1 As String = ""
    Private Tieu_de_chuc_danh2 As String = ""
    Private Tieu_de_chuc_danh3 As String = ""
    Private Tieu_de_chuc_danh4 As String = ""
    Private Tieu_de_nguoi_ky1 As String = ""
    Private Tieu_de_nguoi_ky2 As String = ""
    Private Tieu_de_nguoi_ky3 As String = ""
    Private Tieu_de_nguoi_ky4 As String = ""

    Public Sub New(ByVal objNguoiDung As ESSUsers, ByVal ReportName As String, ByVal dv As DataView, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "", Optional ByVal Tieu_de5 As String = "", Optional ByVal Tieu_de6 As String = "", Optional ByVal Tieu_de7 As String = "")
        InitializeComponent()


        objBaoCaoTieuDe = New BaoCaoTieuDe_Bussines(objNguoiDung.ID_dv, objNguoiDung.UserID)
        Me.reportname = ReportName
        Me.rptdatasource = dv
        If Tieu_de1 <> "" Then
            Me.Tieu_de1 = Tieu_de1
        End If
        If Tieu_de2 <> "" Then
            Me.Tieu_de2 = Tieu_de2
        End If
        If Tieu_de3 <> "" Then
            Me.Tieu_de3 = Tieu_de3
        End If
        If Tieu_de4 <> "" Then
            Me.Tieu_de4 = Tieu_de4
        End If
        If Tieu_de5 <> "" Then
            Me.Tieu_de5 = Tieu_de5
        End If
        If Tieu_de6 <> "" Then
            Me.Tieu_de6 = Tieu_de6
        End If
        If Tieu_de7 <> "" Then
            Me.Tieu_de7 = Tieu_de7
        End If
        If objBaoCaoTieuDe.Count > 0 Then
            Me.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            Me.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            Me.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
            Me.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            Me.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            Me.Tieu_de_chuc_danh3 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
            Me.Tieu_de_chuc_danh4 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
            Me.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            Me.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            Me.Tieu_de_nguoi_ky3 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
            Me.Tieu_de_nguoi_ky4 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4
            Me.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            Me.Tieu_de_ten_bo = ""
            Me.Tieu_de_ten_truong = ""
            Me.Tieu_de_noi_ky = ""
            Me.Tieu_de_chuc_danh1 = ""
            Me.Tieu_de_chuc_danh2 = ""
            Me.Tieu_de_chuc_danh3 = ""
            Me.Tieu_de_chuc_danh4 = ""
            Me.Tieu_de_nguoi_ky1 = ""
            Me.Tieu_de_nguoi_ky2 = ""
            Me.Tieu_de_nguoi_ky3 = ""
            Me.Tieu_de_nguoi_ky4 = ""
            Me.Tieu_de_noi_ky = ""
        End If
    End Sub

    Private Sub frmESS_ReportViewDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
#Region "Function print"
    'Private Sub Print_rptESS_DanhSachDiemThiTungMonTheoLop()
    '    Dim rpt As New rptESS_DanhSachDiemThiTungMonTheoLop(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Me.Tieu_de_bao_cao, Me.Tieu_de_chuc_danh1, Me.Tieu_de_nguoi_ki1, Me.Tieu_de_noi_ki)
    '    rpt.dv = rptdatasourceSub
    '    rpt.setupDynamicControls()
    '    rpt.DataSource = Me.rptdatasource
    '    rpt.binding()
    '    PrintControl1.PrintingSystem = rpt.PrintingSystem
    '    rpt.CreateDocument()
    'End Sub

    'Private Sub Print_rptESS_DanhSachThiSinhThiLaiTheoMonHoc()
    '    Dim rpt As New rptESS_DanhSachThiSinhThiLaiTheoMonHoc(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Me.Tieu_de_bao_cao, Me.Tieu_de_chuc_danh1, Me.Tieu_de_chuc_danh3, Me.Tieu_de_nguoi_ki1, Me.Tieu_de_nguoi_ki3, Me.Tieu_de_noi_ki)
    '    rpt.DataSource = Me.rptdatasource
    '    rpt.binding()
    '    PrintControl1.PrintingSystem = rpt.PrintingSystem
    '    rpt.CreateDocument()
    'End Sub
    Private Sub Print_rptMARK_ChuongTrinhDaoTaoKhung()
        Dim rpt As New rptMARK_ChuongTrinhDaoTaoKhung(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1)
        Dim dv As DataView = Me.rptdatasource
        rpt.SetupDatasource(dv) 'truyen datasource cho subreport
        Dim dt As New DataTable()
        dt.Columns.Add("Ky_thu", GetType(Integer))
        Dim list As New List(Of Integer)
        For Each rowView As DataRowView In dv
            Dim k As Integer = rowView("Ky_thu")
            If Not list.Contains(k) Then
                list.Add(k)
                Dim row As DataRow = dt.NewRow()
                row("Ky_thu") = k
                dt.Rows.Add(row)
            End If
        Next
        rpt.DataSource = dt
        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub
    Private Sub Print_rptMARK_ChuongTrinhDaoTaoKhung1()
        Dim rpt As New rptMARK_ChuongTrinhDaoTaoKhung1(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1)
        Dim dv As DataView = Me.rptdatasource
        rpt.SetupDatasource(dv) 'truyen datasource cho subreport
        Dim dt As New DataTable()
        dt.Columns.Add("Kien_thuc", GetType(Integer))
        dt.Columns.Add("Ten_kien_thuc", GetType(String))
        Dim list As New List(Of Integer)
        For Each rowView As DataRowView In dv
            Dim k As Integer = rowView("Kien_thuc")
            Dim l As String = rowView("Ten_kien_thuc")
            If Not list.Contains(k) Then
                list.Add(k)
                Dim row As DataRow = dt.NewRow()
                row("Kien_thuc") = k
                row("Ten_kien_thuc") = l
                dt.Rows.Add(row)
            End If
        Next
        rpt.DataSource = dt
        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptPLAN_PhieuDangKyHocPhan()
        Dim rpt As New rptPLAN_PhieuDangKyHocPhan(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table

        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_DanhSachThiSinhThiLaiTheoMonHoc()
        Dim rpt As New rptMARK_DanhSachThiSinhThiLaiTheoMonHoc(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table

        If dv.Count / 34 > 1 Then
            If (dv.Count - 34) Mod 34 > 27 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 34) > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_DanhSachHocPhanThiLai()
        Dim rpt As New rptMARK_DanhSachHocPhanThiLai(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3)
        rpt.DataSource = Me.rptdatasource
        rpt.binding()

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_DanhSachSinhVien_KDDK_Thi()
        Dim rpt As New rptMARK_DanhSachSinhVien_KDDK_Thi(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 34 > 1 Then
            If (dv.Count - 34) Mod 34 > 27 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 34) > 27 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_ToChucThi_DanhSachTheoPhong()
        Dim rpt As New rptMARK_ToChucThi_DanhSachTheoPhong(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 27 > 1 Then
            If (dv.Count - 27) Mod 30 > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 27) > 20 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_BangDiemSinhVien()
        Dim rpt As New rptMARK_BangDiemSinhVien(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3)
        rpt.Ho_ten.Text = rptdatasource.Item(0)("Ho_ten").ToString
        rpt.Ma_sv.Text = rptdatasource.Item(0)("Ma_sv").ToString
        rpt.Ngay_sinh.Text = rptdatasource.Item(0)("Ngay_sinh").ToString
        'rpt.Ten_tinh.Text = rptdatasource.Item(0)("Ten_tinh").ToString
        rpt.Ten_he.Text = rptdatasource.Item(0)("Ten_he").ToString
        'rpt.Ten_khoa.Text = rptdatasource.Item(0)("Ten_khoa").ToString
        'rpt.Ten_nganh.Text = rptdatasource.Item(0)("Ten_nganh").ToString
        rpt.Chuyen_nganh.Text = rptdatasource.Item(0)("Chuyen_nganh").ToString
        'rpt.Ten_lop.Text = rptdatasource.Item(0)("Ten_lop").ToString
        rpt.Nien_khoa.Text = rptdatasource.Item(0)("Nien_khoa").ToString

        rpt.TBCHT10.Text = rptdatasource.Item(0)("TBCHT10").ToString
        rpt.TBCHT4.Text = rptdatasource.Item(0)("TBCHT4").ToString
        rpt.TBCHT.Text = rptdatasource.Item(0)("TBCHT").ToString
        rpt.XEP_LOAI.Text = rptdatasource.Item(0)("XEP_LOAI").ToString
        rpt.Xep_loai_RL.Text = rptdatasource.Item(0)("Xep_loai_RL").ToString
        rpt.TBC_RL.Text = rptdatasource.Item(0)("TBC_RL").ToString
        rpt.So_TC_Tichluy.Text = rptdatasource.Item(0)("So_TC_Tichluy").ToString
        rpt.Nam_daotao.Text = rptdatasource.Item(0)("Nam_daotao").ToString





        Dim dv As DataView = Me.rptdatasource
        Dim dt As New DataTable()
        dt.Columns.Add("Nam_hoc", GetType(String))
        Dim list As New List(Of String)
        For Each rowView As DataRowView In dv
            Dim k As String = rowView("Nam_hoc")
            If Not list.Contains(k) Then
                list.Add(k)
                Dim row As DataRow = dt.NewRow()
                row("Nam_hoc") = k
                dt.Rows.Add(row)
            End If
        Next

        Dim dt1 As DataTable
        Dim dt2 As DataTable
        dt1 = rptdatasource.Table.Clone
        dt2 = rptdatasource.Table.Clone
        Dim dr As DataRow
        Dim dvMain As DataView = rptdatasource.Table.DefaultView
        For i As Integer = 0 To dt.Rows.Count - 1
            dvMain.RowFilter = "1=1"
            dvMain.RowFilter = " Nam_hoc='" & dt.Rows(i)("Nam_hoc").ToString & "'"
            Dim dtNam As DataTable = dvMain.ToTable
            For j As Integer = 0 To dtNam.Rows.Count - 1
                If j Mod 2 = 0 Then
                    dr = dt1.NewRow
                    dr.ItemArray = dtNam.Rows(j).ItemArray
                    dt1.Rows.Add(dr)
                Else
                    dr = dt2.NewRow
                    dr.ItemArray = dtNam.Rows(j).ItemArray
                    dt2.Rows.Add(dr)
                End If
            Next
        Next

        'rpt.SetupDatasource(rptdatasource.Table.Copy.DefaultView, rptdatasource.Table.Copy.DefaultView)
        rpt.SetupDatasource(dt1.DefaultView, dt2.DefaultView)

        rpt.DataSource = dt
        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_DanhSachSinhVien_LopHC()
        Dim rpt As New rptSTU_DanhSachSinhVien_LopHC(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()


        If dv.Count / 34 > 1 Then
            If (dv.Count - 34) Mod 34 > 27 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 34) > 27 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If


        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_DonXinXacNhan()
        Dim rpt As New rptSTU_DonXinXacNhan(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub


    Private Sub Print_rptSTU_GiayXacNhan()
        Dim rpt As New rptSTU_GiayXacNhan(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub


    Private Sub Print_rptMARK_BangDiemTongKetHocPhan()
        Dim rpt As New rptMARK_BangDiemTongKetHocPhan(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 27 > 1 Then
            If (dv.Count - 27) Mod 30 > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 27) > 20 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_BangDiemTongKetHocPhan_HVCS()
        Dim rpt As New rptMARK_BangDiemTongKetHocPhan_HVCS(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 30 > 1 Then
            If (dv.Count - 30) Mod 30 > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 30) > 22 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    'Private Sub Print_rptMARK_BangDiemKiemTraHocPhan_HVCS()
    '    Dim rpt As New rptMARK_BangDiemKiemTraHocPhan_HVCS_09(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
    '    Dim dv As DataView = Me.rptdatasource
    '    rpt.DataSource = dv.Table
    '    rpt.binding()
    '    If dv.Count / 30 > 1 Then
    '        If (dv.Count - 30) Mod 30 > 25 Then
    '            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
    '        Else
    '            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
    '        End If
    '    Else
    '        If (dv.Count Mod 30) > 22 Then
    '            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
    '        Else
    '            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
    '        End If
    '    End If
    '    PrintControl1.PrintingSystem = rpt.PrintingSystem
    '    rpt.CreateDocument()
    '    If mPrint Then
    '        rpt.Print()
    '    End If
    'End Sub

    Private Sub Print_rptMARK_BangDiemKiemTraHocPhan_TinChi(ByVal clsDiem As Diem_Bussines)
        Dim rpt As New rptMARK_BangDiemKiemTraHocPhan_Lop_TinChi(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding(clsDiem)
        If dv.Count / 30 > 1 Then
            If (dv.Count - 30) Mod 30 > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 30) > 22 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_BangDiemCuoiKy_Lop_TinChi(ByVal clsDiem As Diem_Bussines)
        Dim rpt As New rptMARK_BangDiemCuoiKy_Lop_TinChi(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding(clsDiem)
        If dv.Count / 30 > 1 Then
            If (dv.Count - 30) Mod 30 > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 30) > 22 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_LyLichTrichNgang()
        Dim rpt As New rptSTU_LyLichTrichNgang(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_BangDiemKiemTraHocPhan()
        Dim rpt As New rptMARK_BangDiemKiemTraHocPhan(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub


    Private Sub Print_rptMARK_ToChucThi_DanhSachThi_Viet()
        Dim rpt As New rptMARK_ToChucThi_DanhSachThi_Viet(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()

        If dv.Count / 34 > 1 Then
            If (dv.Count - 34) Mod 34 > 26 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 34) > 26 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptMARK_ToChucThi_DanhSachThi_VanDap()
        Dim rpt As New rptMARK_ToChucThi_DanhSachThi_VanDap(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 34 > 1 Then
            If (dv.Count - 34) Mod 34 > 28 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 34) > 28 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub


    Private Sub Print_rptSTU_BangDiemRenLuyen()
        Dim rpt As New rptSTU_BangDiemRenLuyen(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If (dv.Count Mod 34) > 28 Then
            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        Else
            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_BangDiemRenLuyen_Nam()
        Dim rpt As New rptSTU_BangDiemRenLuyen_Nam(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If (dv.Count Mod 34) > 28 Then
            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        Else
            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        End If
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub



    Private Sub Print_rptSTU_BangDiemRenLuyen_ToanKhoa()
        Dim rpt As New rptSTU_BangDiemRenLuyen_ToanKhoa(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If (dv.Count Mod 34) > 28 Then
            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        Else
            rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        End If
        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub



    Private Sub Print_rptMARK_PhieuDanhGiaQuaTrinhHocPhan_CD()
        Dim rpt As New rptMARK_PhieuDanhGiaQuaTrinhHocPhan_CD(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 27 > 1 Then
            If (dv.Count - 27) Mod 30 > 25 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 27) > 20 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_ThongKeSoLuongSinhVien_Lop_KhoaHoc()
        Dim rpt As New rptSTU_ThongKeSoLuongSinhVien_Lop_KhoaHoc(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource
        rpt.SetupDatasource(rptdatasource.Table.Copy.DefaultView)

        Dim dt As New DataTable()
        dt.Columns.Add("ID_he", GetType(Integer))
        dt.Columns.Add("Ten_he", GetType(String))
        dt.Columns.Add("Khoa_hoc", GetType(Integer))
        Dim list As New List(Of String)
        For Each rowView As DataRowView In dv
            Dim ID_he As Integer = rowView("ID_he")
            Dim Ten_he As String = rowView("Ten_he")
            Dim Khoa_hoc As Integer = rowView("Khoa_hoc")
            If Not list.Contains(rowView("ID_he").ToString + "-" + rowView("Khoa_hoc").ToString) Then
                list.Add(rowView("ID_he").ToString + "-" + rowView("Khoa_hoc").ToString)
                Dim row As DataRow = dt.NewRow()
                row("ID_he") = ID_he
                row("Ten_he") = Ten_he
                row("Khoa_hoc") = Khoa_hoc
                dt.Rows.Add(row)
            End If
        Next

        rpt.DataSource = dt
        rpt.binding()
        'If (dv.Count Mod 34) > 28 Then
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        'Else
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        'End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_ThongKeSoLuongSinhVien_KhoaDaoTao()
        Dim rpt As New rptSTU_ThongKeSoLuongSinhVien_KhoaDaoTao(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource


        rpt.DataSource = dv.Table
        rpt.binding()
        'If (dv.Count Mod 34) > 28 Then
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        'Else
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        'End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub


    Private Sub Print_rptSTU_ThongKeSoLuongSinhVien_KhoaHoc()
        Dim rpt As New rptSTU_ThongKeSoLuongSinhVien_KhoaHoc(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource


        rpt.DataSource = dv.Table
        rpt.binding()
        'If (dv.Count Mod 34) > 28 Then
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        'Else
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        'End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_ThongKeSoLuongSinhVien_Lop()
        Dim rpt As New rptSTU_ThongKeSoLuongSinhVien_Lop(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource


        rpt.DataSource = dv.Table
        rpt.binding()
        'If (dv.Count Mod 34) > 28 Then
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        'Else
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        'End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_ThongKeSoLuongSinhVien_Nganh()
        Dim rpt As New rptSTU_ThongKeSoLuongSinhVien_Nganh(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource


        rpt.DataSource = dv.Table
        rpt.binding()
        'If (dv.Count Mod 34) > 28 Then
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        'Else
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        'End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub
    Private Sub rptMark_DanhSachSinhVien_TotNghiep()
        Dim rpt As New rptMark_DanhSachSinhVien_TotNghiep(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4)
        Dim dv As DataView = Me.rptdatasource


        rpt.DataSource = dv.Table
        rpt.binding()
        If dv.Count / 40 > 1 Then
            If (dv.Count - 40) Mod 40 > 34 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        Else
            If (dv.Count Mod 45) > 40 Then
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
            Else
                rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
            End If
        End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub

    Private Sub Print_rptSTU_ThongTinDanhBaSinhVien()
        Dim rpt As New rptSTU_ThongTinDanhBaSinhVien(Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Tieu_de_chuc_danh1, Tieu_de_chuc_danh2, Tieu_de_chuc_danh3, Tieu_de_chuc_danh4, Tieu_de_nguoi_ky1, Tieu_de_nguoi_ky2, Tieu_de_nguoi_ky3, Tieu_de_nguoi_ky4, Tieu_de_noi_ky, Me.Tieu_de1, Me.Tieu_de2, Me.Tieu_de3, Me.Tieu_de4, Me.Tieu_de5, Me.Tieu_de6, Me.Tieu_de7)
        Dim dv As DataView = Me.rptdatasource


        rpt.DataSource = dv.Table
        rpt.binding()
        'If (dv.Count Mod 34) > 28 Then
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        'Else
        '    rpt.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        'End If

        PrintControl1.PrintingSystem = rpt.PrintingSystem
        rpt.CreateDocument()
        If mPrint Then
            rpt.Print()
        End If
    End Sub


    Public Overloads Sub ShowDialog(Optional ByVal iPrint As Boolean = False)
        Try
            mPrint = iPrint
            Select Case reportname
                Case "rptMARK_BangDiemCuoiKy_Lop_TinChi"
                    Print_rptMARK_ChuongTrinhDaoTaoKhung()
                    Exit Select
                Case "rptMARK_ChuongTrinhDaoTaoKhung"
                    Print_rptMARK_ChuongTrinhDaoTaoKhung()
                    Exit Select
                Case "rptMARK_ChuongTrinhDaoTaoKhung1"
                    Print_rptMARK_ChuongTrinhDaoTaoKhung1()
                    Exit Select
                Case "rptPLAN_PhieuDangKyHocPhan"
                    Print_rptPLAN_PhieuDangKyHocPhan()
                    Exit Select
                Case "rptMARK_DanhSachThiSinhThiLaiTheoMonHoc"
                    Print_rptMARK_DanhSachThiSinhThiLaiTheoMonHoc()
                    Exit Select
                Case "rptMARK_DanhSachHocPhanThiLai"
                    Print_rptMARK_DanhSachHocPhanThiLai()
                    Exit Select
                Case "rptMARK_DanhSachSinhVien_KDDK_Thi"
                    Print_rptMARK_DanhSachSinhVien_KDDK_Thi()
                    Exit Select
                Case "rptMARK_ToChucThi_DanhSachTheoPhong"
                    Print_rptMARK_ToChucThi_DanhSachTheoPhong()
                    Exit Select
                Case "rptMARK_BangDiemSinhVien"
                    Print_rptMARK_BangDiemSinhVien()
                    Exit Select
                Case "rptSTU_DanhSachSinhVien_LopHC"
                    Print_rptSTU_DanhSachSinhVien_LopHC()
                    Exit Select
                Case "rptSTU_DonXinXacNhan"
                    Print_rptSTU_DonXinXacNhan()
                    Exit Select
                Case "rptSTU_GiayXacNhan"
                    Print_rptSTU_GiayXacNhan()
                    Exit Select
                Case "rptMARK_BangDiemTongKetHocPhan"
                    Print_rptMARK_BangDiemTongKetHocPhan()
                    Exit Select
                Case "rptMARK_BangDiemTongKetHocPhan_HVCS"
                    Print_rptMARK_BangDiemTongKetHocPhan_HVCS()
                    Exit Select
                Case "rptMARK_BangDiemKiemTraHocPhan"
                    Print_rptMARK_BangDiemKiemTraHocPhan()
                    Exit Select
                    'Case "rptMARK_BangDiemKiemTraHocPhan_HVCS"
                    '    Print_rptMARK_BangDiemKiemTraHocPhan_HVCS()
                    '    Exit Select
                Case "rptSTU_LyLichTrichNgang"
                    Print_rptSTU_LyLichTrichNgang()
                    Exit Select
                Case "rptMARK_ToChucThi_DanhSachThi_Viet"
                    Print_rptMARK_ToChucThi_DanhSachThi_Viet()
                    Exit Select
                Case "rptMARK_ToChucThi_DanhSachThi_VanDap"
                    Print_rptMARK_ToChucThi_DanhSachThi_VanDap()
                    Exit Select
                Case "rptSTU_BangDiemRenLuyen"
                    Print_rptSTU_BangDiemRenLuyen()
                    Exit Select
                Case "rptSTU_BangDiemRenLuyen_Nam"
                    Print_rptSTU_BangDiemRenLuyen_Nam()
                    Exit Select
                Case "rptSTU_BangDiemRenLuyen_ToanKhoa"
                    Print_rptSTU_BangDiemRenLuyen_ToanKhoa()
                    Exit Select
                Case "rptMARK_PhieuDanhGiaQuaTrinhHocPhan_CD"
                    Print_rptMARK_PhieuDanhGiaQuaTrinhHocPhan_CD()
                    Exit Select
                Case "rptSTU_ThongKeSoLuongSinhVien_Lop_KhoaHoc"
                    Print_rptSTU_ThongKeSoLuongSinhVien_Lop_KhoaHoc()
                    Exit Select
                Case "rptSTU_ThongKeSoLuongSinhVien_KhoaDaoTao"
                    Print_rptSTU_ThongKeSoLuongSinhVien_KhoaDaoTao()
                    Exit Select
                Case "rptSTU_ThongKeSoLuongSinhVien_KhoaHoc"
                    Print_rptSTU_ThongKeSoLuongSinhVien_KhoaHoc()
                    Exit Select
                Case "rptSTU_ThongKeSoLuongSinhVien_Lop"
                    Print_rptSTU_ThongKeSoLuongSinhVien_Lop()
                    Exit Select
                Case "rptSTU_ThongKeSoLuongSinhVien_Nganh"
                    Print_rptSTU_ThongKeSoLuongSinhVien_Nganh()
                    Exit Select
                Case "rptSTU_ThongTinDanhBaSinhVien"
                    Print_rptSTU_ThongTinDanhBaSinhVien()
                    Exit Select
                Case "rptMark_DanhSachSinhVien_TotNghiep"
                    rptMark_DanhSachSinhVien_TotNghiep()
                    Exit Select

            End Select
            If Not mPrint Then
                Me.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Public Overloads Sub ShowDialog(ByVal clsDiem As Diem_Bussines)
        Try
            Select Case reportname
                Case "rptMARK_BangDiemKiemTraHocPhan_Lop_TinChi"
                    Print_rptMARK_BangDiemKiemTraHocPhan_TinChi(clsDiem)
                    Exit Select
            End Select
            If Not mPrint Then
                Me.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Overloads Sub ShowDialog1(ByVal clsDiem As Diem_Bussines)
        Try
            Select Case reportname
                Case "rptMARK_BangDiemCuoiKy_Lop_TinChi"
                    Print_rptMARK_BangDiemCuoiKy_Lop_TinChi(clsDiem)
                    Exit Select
            End Select
            If Not mPrint Then
                Me.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class