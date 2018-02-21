Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports System.IO
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmESS_KhungChuongTrinhDaoTao_NhapKhau
#Region "Var"
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Private Loader As Boolean = False
    Private flagConvert As Boolean = False
    Private conADO As ADODB.Connection
    Private cnnODBC As Odbc.OdbcConnection
    Private cnnSQL As Object
    Private RsSrc As ADODB.Recordset
    Private dtSrc As DataTable
    Private Index1 As Integer = -1, Index2 As Integer = -1
    Private tblSrcName As String = ""
#End Region
#Region "User Function"
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsDM.LoadDanhMuc("Select ID_he,Ten_he from  STU_He")
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub FormatDataViewCTDTChiTiet()
        Try
            grdViewCTDTChiTiet.Columns.Clear()
            grdViewCTDTChiTiet.AllowUserToOrderColumns = False

            'STT
            Dim col1 As New DataGridViewTextBoxColumn
            With col1
                .Name = "STT_mon"
                .DataPropertyName = "STT_mon"
                .HeaderText = "STT"
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col1)

            Dim col15 As New DataGridViewTextBoxColumn
            With col15
                .Name = "Ten_kien_thuc"
                .DataPropertyName = "Ten_kien_thuc"
                .HeaderText = "Khối kiến thức"
                .Width = 150
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col15)

            'Ký hiệu
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ky_hieu"
                .DataPropertyName = "Ky_hieu"
                .HeaderText = "Mã học phần"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col2)
            'Tên học phần
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ten_mon"
                .DataPropertyName = "Ten_mon"
                .HeaderText = "Tên học phần"
                .Width = 250
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col3)

            'Kỳ thứ
            Dim col0 As New DataGridViewTextBoxColumn
            With col0
                .Name = "Ky_thu"
                .DataPropertyName = "Ky_thu"
                .HeaderText = "Kỳ thứ"
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col0)

            'Số học trình
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "So_hoc_trinh"
                .DataPropertyName = "So_hoc_trinh"
                .HeaderText = "Số học trình"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col4)

            'Hệ số
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "He_so"
                .DataPropertyName = "He_so"
                .HeaderText = "Hệ số"
                .Width = 30
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col5)

            'Lý thuyết
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "Ly_thuyet"
                .DataPropertyName = "Ly_thuyet"
                .HeaderText = "Lý thuyết"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col7)

            'Thực hành
            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Thuc_hanh"
                .DataPropertyName = "Thuc_hanh"
                .HeaderText = "Thực hành"
                .Width = 45
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col8)

            'Bài tập
            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Bai_tap"
                .DataPropertyName = "Bai_tap"
                .HeaderText = "Bài tập"
                .Width = 30
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col9)

            'Bài tập lớn
            Dim col10 As New DataGridViewTextBoxColumn
            With col10
                .Name = "Bai_tap_lon"
                .DataPropertyName = "Bai_tap_lon"
                .HeaderText = "Bài tập lớn"
                .Width = 35
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col10)
            'Thực tập
            Dim col13 As New DataGridViewTextBoxColumn
            With col13
                .Name = "Thuc_tap"
                .DataPropertyName = "Thuc_tap"
                .HeaderText = "Thực tập"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col13)
            'Tổng số tiết
            Dim col11 As New DataGridViewTextBoxColumn
            With col11
                .Name = "Tong_so_tiet"
                .DataPropertyName = "Tong_so_tiet"
                .HeaderText = "Tổng số tiết"
                .Width = 43
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col11)

            'Tự chọn
            Dim col12 As New DataGridViewCheckBoxColumn
            With col12
                .Name = "Tu_chon"
                .DataPropertyName = "Tu_chon"
                .HeaderText = "Tự chọn"
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col12)
            'Không tính điểm
            Dim col14 As New DataGridViewCheckBoxColumn
            With col14
                .Name = "Khong_tinh_TBCHT"
                .DataPropertyName = "Khong_tinh_TBCHT"
                .HeaderText = "Không tính TBCHT"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col14)

            Dim col16 As New DataGridViewCheckBoxColumn
            With col16
                .Name = "Mon_thi_TN"
                .DataPropertyName = "Mon_tot_nghiep"
                .HeaderText = "Học phần thi tốt nghiệp"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewCTDTChiTiet.Columns.Add(col16)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckValidate() As Boolean
        If cmbID_he.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn hệ đào tạo")
            cmbID_he.Focus()
            Return False
        End If
        If cmbID_khoa.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoa đào tạo")
            cmbID_khoa.Focus()
            Return False
        End If
        If cmbKhoa_hoc.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoá đào tạo")
            cmbKhoa_hoc.Focus()
            Return False
        End If
        If cmbID_chuyen_nganh.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn chuyên ngành đào tạo")
            cmbID_chuyen_nganh.Focus()
            Return False
        End If
        Dim dv As DataView = grdViewCTDTChiTiet.DataSource
        If dv Is Nothing Then
            Thongbao("Bạn phải chọn bảng dữ liệu chương trình đào tạo khung để nhập khẩu")
            Return False
        End If
        Return True
    End Function
    Private Sub Open_struc()
        Dim myrs As New ADODB.Recordset
        Me.lsvTen_bang_ODBC.Items.Clear()
        Me.grpTen_bang_ODBC.Text = "Tên bảng"
        myrs = conADO.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
        While Not myrs.EOF
            If cnnODBC.DataSource = "EXCEL" Then
                If myrs.Fields("TABLE_NAME").Value.ToString.Substring(myrs.Fields("TABLE_NAME").Value.ToString.Length - 1, 1) <> "_" Then
                    Me.lsvTen_bang_ODBC.Items.Add(myrs.Fields("TABLE_NAME").Value)
                End If
            Else
                If myrs.Fields("TABLE_TYPE").Value = "TABLE" Then
                    Me.lsvTen_bang_ODBC.Items.Add(myrs.Fields("TABLE_NAME").Value)
                End If
            End If
            myrs.MoveNext()
        End While
        myrs.Close()
    End Sub
    Private Sub lsvFormat_table(ByVal lsv As ListView)
        lsv.Clear()
        lsv.View = View.Details
        lsv.HeaderStyle = ColumnHeaderStyle.None
        lsv.Columns.Add("Tên bảng", 340, HorizontalAlignment.Left)
    End Sub
    Private Sub getFont(ByVal cmbName As ComboBox)
        cmbName.Items.Add("UniCode")
        cmbName.Items.Add("TCVN")
        cmbName.Items.Add("VNI")
        cmbName.Items.Add("VietRes")
        cmbName.SelectedIndex = 0
    End Sub
    Private Function LoadODBCData(ByVal strSQL As String, ByVal Cnn As Odbc.OdbcConnection) As DataSet
        Try
            Dim adpt As New Odbc.OdbcDataAdapter(strSQL, Cnn)
            LoadODBCData = New DataSet
            adpt.Fill(LoadODBCData)
        Catch exc As Exception
            MsgBox(exc.Message, strSQL)
            LoadODBCData = Nothing
        End Try
    End Function
    Private Sub ChuyenDuLieuChuongTrinhDaoTaoChiTiet(ByVal dtSrc As DataTable, ByVal optTen_mon As Boolean, ByVal Row_start As Integer)
        Dim ID_mon, ID_mon_rb, idx_mon As Integer
        Dim ctdt_idx, ID_dt_new As Integer
        Dim clsMon As New MonHoc_Bussines()
        ctdt_idx = mclsCTDT.Count - 1
        ID_dt_new = mclsCTDT.ESSChuongTrinhDaoTao(ctdt_idx).ID_dt
        Dim dtKien_thuc As DataTable
        Dim cls As New DanhMuc_Bussines
        dtKien_thuc = cls.LoadDanhMuc("Select * from  PLAN_ChuongTrinhDaoTaoKienThuc")
        Dim dtMon As DataTable
        dtMon = clsMon.DanhSachMonHoc()
        For i As Integer = Row_start To dtSrc.Rows.Count - 1
            Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
            objCTDTChiTiet.ID_dt = ID_dt_new
            If dtSrc.Columns.Contains("STT_mon") = True AndAlso dtSrc.Rows(i)("STT_mon").ToString.Trim <> "" Then
                objCTDTChiTiet.STT_mon = dtSrc.Rows(i)("STT_mon").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Ky_thu") = True AndAlso dtSrc.Rows(i)("Ky_thu").ToString.Trim <> "" Then
                objCTDTChiTiet.Ky_thu = dtSrc.Rows(i)("Ky_thu").ToString.Trim
            End If
            If dtSrc.Columns.Contains("So_hoc_trinh") = True AndAlso dtSrc.Rows(i)("So_hoc_trinh").ToString.Trim <> "" Then
                objCTDTChiTiet.So_hoc_trinh = dtSrc.Rows(i)("So_hoc_trinh").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Ly_thuyet") = True AndAlso dtSrc.Rows(i)("Ly_thuyet").ToString.Trim <> "" Then
                objCTDTChiTiet.Ly_thuyet = dtSrc.Rows(i)("Ly_thuyet").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Thuc_hanh") = True AndAlso dtSrc.Rows(i)("Thuc_hanh").ToString.Trim <> "" Then
                objCTDTChiTiet.Thuc_hanh = dtSrc.Rows(i)("Thuc_hanh").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Bai_tap") = True AndAlso dtSrc.Rows(i)("Bai_tap").ToString.Trim <> "" Then
                objCTDTChiTiet.Bai_tap = dtSrc.Rows(i)("Bai_tap").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Bai_tap_lon") = True AndAlso dtSrc.Rows(i)("Bai_tap_lon").ToString.Trim <> "" Then
                objCTDTChiTiet.Bai_tap_lon = dtSrc.Rows(i)("Bai_tap_lon").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Thuc_tap") = True AndAlso dtSrc.Rows(i)("Thuc_tap").ToString.Trim <> "" Then
                objCTDTChiTiet.Thuc_tap = dtSrc.Rows(i)("Thuc_tap").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Tu_chon") = True AndAlso dtSrc.Rows(i)("Tu_chon").ToString.Trim <> "" Then
                objCTDTChiTiet.Tu_chon = IIf(CType(dtSrc.Rows(i)("Khong_tinh_TBCHT").ToString.Trim, Integer) > 0, True, False)
                objCTDTChiTiet.Nhom_tu_chon = CType(dtSrc.Rows(i)("Tu_chon").ToString.Trim, Integer)
            End If
            If dtSrc.Columns.Contains("Kien_thuc") = True AndAlso dtSrc.Rows(i)("Kien_thuc").ToString.Trim <> "" Then
                If IsNumeric(dtSrc.Rows(i)("Kien_thuc").ToString.Trim) Then
                    objCTDTChiTiet.Kien_thuc = dtSrc.Rows(i)("Kien_thuc").ToString.Trim
                    objCTDTChiTiet.Ten_kien_thuc = ""
                Else
                    objCTDTChiTiet.Kien_thuc = Tim_kien_thuc(dtSrc.Rows(i)("Kien_thuc").ToString.Trim, dtKien_thuc)
                    objCTDTChiTiet.Ten_kien_thuc = dtSrc.Rows(i)("Kien_thuc").ToString.Trim
                End If
            End If
            If dtSrc.Columns.Contains("Khong_tinh_TBCHT") = True AndAlso dtSrc.Rows(i)("Khong_tinh_TBCHT").ToString.Trim <> "" Then
                objCTDTChiTiet.Khong_tinh_TBCHT = IIf(CType(dtSrc.Rows(i)("Khong_tinh_TBCHT").ToString.Trim, Integer) = 1, True, False)
            End If
            If dtSrc.Columns.Contains("Tu_hoc") = True AndAlso dtSrc.Rows(i)("Tu_hoc").ToString.Trim <> "" Then
                objCTDTChiTiet.Tu_hoc = dtSrc.Rows(i)("Tu_hoc").ToString.Trim
            End If
            If dtSrc.Columns.Contains("So_hoc_trinh_tien_quyet") = True AndAlso dtSrc.Rows(i)("So_hoc_trinh_tien_quyet").ToString.Trim <> "" Then
                objCTDTChiTiet.So_hoc_trinh_tien_quyet = dtSrc.Rows(i)("So_hoc_trinh_tien_quyet").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Ma_khoa_phu_trach") = True Then objCTDTChiTiet.Ma_khoa_phu_trach = dtSrc.Rows(i)("Ma_khoa_phu_trach").ToString.Trim
            If dtSrc.Columns.Contains("Ky_hieu") = True Then objCTDTChiTiet.Ky_hieu = dtSrc.Rows(i)("Ky_hieu").ToString.Trim
            If dtSrc.Columns.Contains("Ten_mon") = True Then objCTDTChiTiet.Ten_mon = dtSrc.Rows(i)("Ten_mon").ToString.Trim
            If dtSrc.Columns.Contains("Ten_tieng_anh") = True Then objCTDTChiTiet.Ten_tieng_anh = dtSrc.Rows(i)("Ten_tieng_anh").ToString.Trim
            'Phân loại Học phần theo tên Học phần
            If optTen_mon = True And dtSrc.Columns.Contains("Ten_mon") = True AndAlso dtSrc.Rows(i)("Ten_mon").ToString.Trim <> "" Then
                ID_mon = Tim_ID_mon("", dtSrc.Rows(i)("Ten_mon").Trim, True, dtMon)
                If ID_mon <= 0 Then ID_mon = Tim_ID_mon_ctdt("", dtSrc.Rows(i)("Ten_mon").Trim, True)
                If ID_mon <= 0 Then
                    'Insert Học phần mới
                    Dim objMonHoc As New ESSMonHoc
                    objMonHoc.Ky_hieu = objCTDTChiTiet.Ky_hieu
                    objMonHoc.Ten_mon = objCTDTChiTiet.Ten_mon
                    objMonHoc.Ten_tieng_anh = objCTDTChiTiet.Ten_tieng_anh
                    ID_mon = clsMon.ThemMoi_ESSMonHoc(objMonHoc)
                End If
                objCTDTChiTiet.ID_mon = ID_mon
            End If
            'Phân loại Học phần theo Ký hiệu
            If optTen_mon = False And dtSrc.Columns.Contains("Ky_hieu") = True AndAlso dtSrc.Rows(i)("Ky_hieu").ToString.Trim <> "" Then
                ID_mon = Tim_ID_mon(dtSrc.Rows(i)("Ky_hieu").ToString.Trim, "", False, dtMon)
                If ID_mon <= 0 Then ID_mon = Tim_ID_mon_ctdt(dtSrc.Rows(i)("Ky_hieu").ToString.Trim, "", False)
                If ID_mon <= 0 Then
                    'Insert Học phần mới
                    Dim objMonHoc As New ESSMonHoc
                    objMonHoc.Ky_hieu = objCTDTChiTiet.Ky_hieu
                    objMonHoc.Ten_mon = objCTDTChiTiet.Ten_mon
                    objMonHoc.Ten_tieng_anh = objCTDTChiTiet.Ten_tieng_anh
                    ID_mon = clsMon.ThemMoi_ESSMonHoc(objMonHoc)
                End If
                objCTDTChiTiet.ID_mon = ID_mon
            End If
            If objCTDTChiTiet.ID_mon > 0 Then
                idx_mon = mclsCTDT.ESSChuongTrinhDaoTao(ctdt_idx).ESSChuongTrinhDaoTaoChiTiet.Tim_idx(ID_mon)
                If idx_mon < 0 Then
                    'Insert Object
                    mclsCTDT.ESSChuongTrinhDaoTao(ctdt_idx).ESSChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                    'Insert Database
                    mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet)
                End If
                'Insert ràng buộc Học phần tiên quyết
                If dtSrc.Columns.Contains("Ma_mon_tien_quyet") = True AndAlso dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim <> "" Then
                    ID_mon_rb = Tim_ID_mon(dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim, "", False, dtMon)
                    If ID_mon_rb <= 0 Then ID_mon_rb = Tim_ID_mon_ctdt(dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim, "", False)
                    If ID_mon_rb > 0 Then
                        mclsCTDT.GanMonRangBuoc(ID_dt_new, ID_mon, ID_mon_rb, 1, objCTDTChiTiet.Ky_hieu, objCTDTChiTiet.Ten_mon, dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim, "Tiên quyết")
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub ChuyenDuLieuChuongTrinhDaoTaoChiTiet_Update(ByVal dtSrc As DataTable, ByVal optTen_mon As Boolean, ByVal Row_start As Integer, ByVal ID_dt As Integer)
        Dim ID_mon, ID_mon_rb, idx_mon As Integer
        Dim ctdt_idx As Integer
        Dim clsMon As New MonHoc_Bussines()
        ctdt_idx = mclsCTDT.Tim_idx(ID_dt)

        Dim dtKien_thuc As DataTable
        Dim cls As New DanhMuc_Bussines
        dtKien_thuc = cls.LoadDanhMuc("Select * from  PLAN_ChuongTrinhDaoTaoKienThuc")
        Dim dtMon As DataTable
        dtMon = clsMon.DanhSachMonHoc()
        For i As Integer = Row_start To dtSrc.Rows.Count - 1
            Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
            objCTDTChiTiet.ID_dt = ID_dt
            If dtSrc.Columns.Contains("STT_mon") = True AndAlso dtSrc.Rows(i)("STT_mon").ToString.Trim <> "" Then
                objCTDTChiTiet.STT_mon = dtSrc.Rows(i)("STT_mon").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Ky_thu") = True AndAlso dtSrc.Rows(i)("Ky_thu").ToString.Trim <> "" Then
                objCTDTChiTiet.Ky_thu = dtSrc.Rows(i)("Ky_thu").ToString.Trim
            End If
            If dtSrc.Columns.Contains("So_hoc_trinh") = True AndAlso dtSrc.Rows(i)("So_hoc_trinh").ToString.Trim <> "" Then
                objCTDTChiTiet.So_hoc_trinh = dtSrc.Rows(i)("So_hoc_trinh").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Ly_thuyet") = True AndAlso dtSrc.Rows(i)("Ly_thuyet").ToString.Trim <> "" Then
                objCTDTChiTiet.Ly_thuyet = dtSrc.Rows(i)("Ly_thuyet").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Thuc_hanh") = True AndAlso dtSrc.Rows(i)("Thuc_hanh").ToString.Trim <> "" Then
                objCTDTChiTiet.Thuc_hanh = dtSrc.Rows(i)("Thuc_hanh").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Bai_tap") = True AndAlso dtSrc.Rows(i)("Bai_tap").ToString.Trim <> "" Then
                objCTDTChiTiet.Bai_tap = dtSrc.Rows(i)("Bai_tap").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Bai_tap_lon") = True AndAlso dtSrc.Rows(i)("Bai_tap_lon").ToString.Trim <> "" Then
                objCTDTChiTiet.Bai_tap_lon = dtSrc.Rows(i)("Bai_tap_lon").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Thuc_tap") = True AndAlso dtSrc.Rows(i)("Thuc_tap").ToString.Trim <> "" Then
                objCTDTChiTiet.Thuc_tap = dtSrc.Rows(i)("Thuc_tap").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Tu_chon") = True AndAlso dtSrc.Rows(i)("Tu_chon").ToString.Trim <> "" Then
                objCTDTChiTiet.Tu_chon = dtSrc.Rows(i)("Tu_chon")
                objCTDTChiTiet.Nhom_tu_chon = dtSrc.Rows(i)("Tu_chon")
            End If
            If dtSrc.Columns.Contains("Kien_thuc") = True AndAlso dtSrc.Rows(i)("Kien_thuc").ToString.Trim <> "" Then
                If IsNumeric(dtSrc.Rows(i)("Kien_thuc").ToString.Trim) Then
                    objCTDTChiTiet.Kien_thuc = dtSrc.Rows(i)("Kien_thuc").ToString.Trim
                    objCTDTChiTiet.Ten_kien_thuc = ""
                Else
                    objCTDTChiTiet.Kien_thuc = Tim_kien_thuc(dtSrc.Rows(i)("Kien_thuc").ToString.Trim, dtKien_thuc)
                    objCTDTChiTiet.Ten_kien_thuc = dtSrc.Rows(i)("Kien_thuc").ToString.Trim
                End If
            End If
            If dtSrc.Columns.Contains("Khong_tinh_TBCHT") = True AndAlso dtSrc.Rows(i)("Khong_tinh_TBCHT").ToString.Trim <> "" Then
                objCTDTChiTiet.Khong_tinh_TBCHT = dtSrc.Rows(i)("Khong_tinh_TBCHT")
            End If
            If dtSrc.Columns.Contains("Tu_hoc") = True AndAlso dtSrc.Rows(i)("Tu_hoc").ToString.Trim <> "" Then
                objCTDTChiTiet.Tu_hoc = dtSrc.Rows(i)("Tu_hoc")
            End If
            If dtSrc.Columns.Contains("So_hoc_trinh_tien_quyet") = True AndAlso dtSrc.Rows(i)("So_hoc_trinh_tien_quyet").ToString.Trim <> "" Then
                objCTDTChiTiet.So_hoc_trinh_tien_quyet = dtSrc.Rows(i)("So_hoc_trinh_tien_quyet").ToString.Trim
            End If
            If dtSrc.Columns.Contains("Ma_khoa_phu_trach") = True Then objCTDTChiTiet.Ma_khoa_phu_trach = dtSrc.Rows(i)("Ma_khoa_phu_trach").ToString.Trim
            If dtSrc.Columns.Contains("Ky_hieu") = True Then objCTDTChiTiet.Ky_hieu = dtSrc.Rows(i)("Ky_hieu").ToString.Trim
            If dtSrc.Columns.Contains("Ten_mon") = True Then objCTDTChiTiet.Ten_mon = dtSrc.Rows(i)("Ten_mon").ToString.Trim
            If dtSrc.Columns.Contains("Ten_tieng_anh") = True Then objCTDTChiTiet.Ten_tieng_anh = dtSrc.Rows(i)("Ten_tieng_anh").ToString.Trim
            'Phân loại Học phần theo tên Học phần
            If optTen_mon = True And dtSrc.Columns.Contains("Ten_mon") = True AndAlso dtSrc.Rows(i)("Ten_mon").ToString.Trim <> "" Then
                ID_mon = Tim_ID_mon("", dtSrc.Rows(i)("Ten_mon").ToString.Trim, True, dtMon)
                If ID_mon <= 0 Then ID_mon = Tim_ID_mon_ctdt("", dtSrc.Rows(i)("Ten_mon").ToString.Trim, True)
                If ID_mon <= 0 Then
                    'Insert Học phần mới
                    Dim objMonHoc As New ESSMonHoc
                    objMonHoc.Ky_hieu = objCTDTChiTiet.Ky_hieu
                    objMonHoc.Ten_mon = objCTDTChiTiet.Ten_mon
                    objMonHoc.Ten_tieng_anh = objCTDTChiTiet.Ten_tieng_anh
                    ID_mon = clsMon.ThemMoi_ESSMonHoc(objMonHoc)
                End If
                objCTDTChiTiet.ID_mon = ID_mon
            End If
            'Phân loại Học phần theo Ký hiệu
            If optTen_mon = False And dtSrc.Columns.Contains("Ky_hieu") = True AndAlso dtSrc.Rows(i)("Ky_hieu").ToString.Trim <> "" Then
                ID_mon = Tim_ID_mon(dtSrc.Rows(i)("Ky_hieu").ToString.Trim, "", False, dtMon)
                If ID_mon <= 0 Then ID_mon = Tim_ID_mon_ctdt(dtSrc.Rows(i)("Ky_hieu").ToString.Trim, "", False)
                If ID_mon <= 0 Then
                    'Insert Học phần mới
                    Dim objMonHoc As New ESSMonHoc
                    objMonHoc.Ky_hieu = objCTDTChiTiet.Ky_hieu
                    objMonHoc.Ten_mon = objCTDTChiTiet.Ten_mon
                    objMonHoc.Ten_tieng_anh = objCTDTChiTiet.Ten_tieng_anh
                    ID_mon = clsMon.ThemMoi_ESSMonHoc(objMonHoc)
                End If
                objCTDTChiTiet.ID_mon = ID_mon
            End If
            If objCTDTChiTiet.ID_mon > 0 Then
                idx_mon = mclsCTDT.ESSChuongTrinhDaoTao(ctdt_idx).ESSChuongTrinhDaoTaoChiTiet.Tim_idx(ID_mon)
                If idx_mon < 0 Then
                    'Insert Object
                    mclsCTDT.ESSChuongTrinhDaoTao(ctdt_idx).ESSChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                    'Insert Database
                    mclsCTDT.ThemMoi_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet)
                End If
                'Insert ràng buộc Học phần tiên quyết
                If dtSrc.Columns.Contains("Ma_mon_tien_quyet") = True AndAlso dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim <> "" Then
                    ID_mon_rb = Tim_ID_mon(dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim, "", False, dtMon)
                    If ID_mon_rb <= 0 Then ID_mon_rb = Tim_ID_mon_ctdt(dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim, "", False)
                    If ID_mon_rb > 0 Then
                        mclsCTDT.GanMonRangBuoc(ID_dt, ID_mon, ID_mon_rb, 1, objCTDTChiTiet.Ky_hieu, objCTDTChiTiet.Ten_mon, dtSrc.Rows(i)("Ma_mon_tien_quyet").ToString.Trim, "Tiên quyết")
                    End If
                End If
            End If
        Next
    End Sub

    Private Function Tim_kien_thuc(ByVal Ten_kien_thuc As String) As Integer
        For i As Integer = 0 To mclsCTDT.Count - 1
            For j As Integer = 0 To mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.Count - 1
                If mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(j).Ten_kien_thuc = Ten_kien_thuc Then
                    Return mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(j).Kien_thuc
                End If
            Next
        Next
        Return 0
    End Function
    Private Function Tim_kien_thuc(ByVal Ten_kien_thuc As String, ByVal dtKien_thuc As DataTable) As Integer
        For i As Integer = 0 To dtKien_thuc.Rows.Count - 1
            If dtKien_thuc.Rows(i)("Ten_kien_thuc").ToString.Trim.ToUpper = Ten_kien_thuc.Trim.ToUpper Then
                Return dtKien_thuc.Rows(i)("ID_kien_thuc")
            End If
        Next
        Return 0
    End Function
    Private Function Tim_ID_mon_ctdt(ByVal Ky_hieu As String, ByVal Ten_mon As String, ByVal optTen_mon As Boolean) As Integer
        For i As Integer = 0 To mclsCTDT.Count - 1
            For j As Integer = 0 To mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.Count - 1
                If optTen_mon Then
                    If mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(j).Ten_mon.Trim.ToUpper = Ten_mon.Trim.ToUpper Then
                        Return mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(j).ID_mon
                    End If
                Else
                    If mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(j).Ky_hieu.Trim.ToUpper = Ky_hieu.Trim.ToUpper Then
                        Return mclsCTDT.ESSChuongTrinhDaoTao(i).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(j).ID_mon
                    End If
                End If
            Next
        Next
        Return 0
    End Function
    Private Function Tim_ID_mon(ByVal Ky_hieu As String, ByVal Ten_mon As String, ByVal optTen_mon As Boolean, ByVal dtMon As DataTable) As Integer
        For i As Integer = 0 To dtMon.Rows.Count - 1
            If optTen_mon Then
                If dtMon.Rows(i)("Ten_mon").ToString.Trim.ToUpper = Ten_mon.Trim.ToUpper Then
                    Return dtMon.Rows(i)("ID_mon")
                End If
            Else
                If dtMon.Rows(i)("Ky_hieu").ToString.Trim.ToUpper = Ky_hieu.Trim.ToUpper Then
                    Return dtMon.Rows(i)("ID_mon")
                End If
            End If
        Next
        Return 0
    End Function
#End Region
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_Bussines)
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadComboBox()
        Call lsvFormat_table(Me.lsvTen_bang_ODBC)
        Call getFont(cmbFont)
        Loader = True
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoImport_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_Bussines
                Dim dt As DataTable
                dt = cls.LoadDanhMuc("Select distinct ID_khoa,Ten_khoa from  STU_Khoa")
                FillCombo(cmbID_khoa, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_Bussines
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct l.Khoa_hoc,l.Khoa_hoc from  STU_Lop l where " & dk)
                FillCombo(cmbKhoa_hoc, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Dim cls As New DanhMuc_Bussines
                Dim dt As DataTable
                Dim dk As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then dk += " And l.ID_he=" & cmbID_he.SelectedValue
                If cmbID_khoa.SelectedValue > 0 Then dk += " And l.ID_khoa=" & cmbID_khoa.SelectedValue
                If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And l.Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                dt = cls.LoadDanhMuc("Select distinct cn.ID_chuyen_nganh,cn.Chuyen_nganh from  STU_Lop l inner join  STU_ChuyenNganh cn On l.ID_chuyen_nganh=cn.ID_chuyen_nganh where " & dk)
                FillCombo(cmbID_chuyen_nganh, dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim FileName, PathName As String
        With OpenFile
            .InitialDirectory = Application.StartupPath
            If optExcel.Checked Then
                .Filter = "Tệp Excel|*.xls"
            ElseIf optFoxpro.Checked Then
                .Filter = "Tệp Foxpro|*.dbf"
            Else
                .Filter = "Tệp Access|*.mdb"
            End If
            .FilterIndex = 1
        End With
        If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Khai bao cac bien
            FileName = OpenFile.FileName
            PathName = Mid(OpenFile.FileName, 1, InStrRev(OpenFile.FileName, "\"))
            conADO = Nothing
            cnnODBC = Nothing
            RsSrc = Nothing
            dtSrc = Nothing
            Try
                If optExcel.Checked Then
                    ' Ket noi bang AOD
                    conADO = New ADODB.Connection
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & FileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    'Ket noi bang ODBC
                    cnnODBC = New Odbc.OdbcConnection
                    cnnODBC.ConnectionString = "Driver={Microsoft Excel Driver (*.xls)};DriverId=790;Dbq=" & FileName & ";"
                    cnnODBC.Open()
                ElseIf optFoxpro.Checked Then
                    ' Ket noi bang AOD
                    conADO = New ADODB.Connection
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + PathName + ";Extended Properties=DBASE IV;User ID=;Password=;")
                    'Ket noi bang ODBC
                    cnnODBC = New Odbc.OdbcConnection
                    cnnODBC.ConnectionString = "driver=Microsoft Visual FoxPro Driver;SourceDB=" + PathName + ";SourceType=DBF;Exclusive=No"
                    cnnODBC.Open()
                Else 'Access
                    ' Ket noi bang AOD
                    conADO = New ADODB.Connection
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + "; User ID=;Password=;")
                    'Ket noi bang ODBC
                    cnnODBC = New Odbc.OdbcConnection
                    cnnODBC.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" + FileName + ";" + "Uid=;" + "Pwd="
                    cnnODBC.Open()
                End If
                'Lay ra cac bang trong CSLD
                Call Open_struc()
            Catch er As Exception
                conADO = Nothing
                cnnODBC = Nothing
                Thongbao("Lỗi không kết nối file được file dữ liệu này :!" & er.Message & "Bạn hãy kiểm tra lại file dữ liệu cần import", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
    Private Sub lsvTen_bang_ODBC_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvTen_bang_ODBC.SelectedIndexChanged
        Try
            If Not lsvTen_bang_ODBC.FocusedItem Is Nothing Then
                If lsvTen_bang_ODBC.FocusedItem.Index >= 0 Then

                    If conADO Is Nothing Then Exit Sub
                    RsSrc = New ADODB.Recordset
                    dtSrc = New DataTable
                    flagConvert = False

                    Me.Cursor = Cursors.WaitCursor
                    If Not ErrPro Is Nothing Then ErrPro.Dispose()
                    Me.grdViewCTDTChiTiet.DataSource = Nothing
                    If Index1 >= 0 Then lsvTen_bang_ODBC.Items(Index1).BackColor = Color.White
                    Index1 = lsvTen_bang_ODBC.FocusedItem.Index
                    lsvTen_bang_ODBC.Items(Index1).BackColor = Color.SkyBlue
                    tblSrcName = lsvTen_bang_ODBC.Items(Index1).SubItems(0).Text
                    'Load tat ca noi dung cua du lieu
                    dtSrc = LoadODBCData("SELECT * FROM [" & tblSrcName & "]", cnnODBC).Tables(0)
                    ' Chuyển font dữ liệu
                    If cmbFont.SelectedIndex > 0 Then
                        Convert_font(cmbFont.Text, dtSrc)
                    End If
                    dtSrc.DefaultView.AllowDelete = False
                    dtSrc.DefaultView.AllowEdit = False
                    dtSrc.DefaultView.AllowNew = False
                    Me.grdViewCTDTChiTiet.DataSource = dtSrc.DefaultView

                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch exp As Exception
            Thongbao("Bạn hãy chọn tên CSDL !")
        End Try
    End Sub

    Private Sub grdViewCTDTChiTiet_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdViewCTDTChiTiet.DataError
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If CheckValidate() Then
                Dim ID_dt As Integer = 0
                ID_dt = mclsCTDT.CheckExist_ChuongTrinhDaoTao(cmbID_he.SelectedValue, cmbID_khoa.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_chuyen_nganh.SelectedValue, cmbSo.Text)
                If ID_dt = 0 Then
                    Dim objCTDT As New ESSChuongTrinhDaoTao
                    Dim ID_dt_new As Integer
                    objCTDT.ID_he = cmbID_he.SelectedValue
                    objCTDT.ID_khoa = cmbID_khoa.SelectedValue
                    objCTDT.Khoa_hoc = cmbKhoa_hoc.SelectedValue
                    objCTDT.ID_chuyen_nganh = cmbID_chuyen_nganh.SelectedValue

                    objCTDT.Ten_he = cmbID_he.Text
                    objCTDT.Ten_khoa = cmbID_khoa.Text
                    objCTDT.Chuyen_nganh = cmbID_chuyen_nganh.Text
                    objCTDT.So = cmbSo.Text

                    'Insert vao Database
                    ID_dt_new = mclsCTDT.ThemMoi_ESSChuongTrinhDaoTao(objCTDT)
                    'Insert vao object
                    objCTDT.ID_dt = ID_dt_new
                    mclsCTDT.Add(objCTDT)
                    'Chuyển chương trình đào tạo chi tiết
                    ChuyenDuLieuChuongTrinhDaoTaoChiTiet(dtSrc, optTen_mon.Checked, 2)
                    'Load chương trình đào tạo chi tiết
                    mclsCTDT.HienThi_ESSCTDTChiTiet(ID_dt_new)
                    'Hiển thị các học phần
                    grdViewCTDTChiTiet.DataSource = mclsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(ID_dt_new).DefaultView
                    FormatDataViewCTDTChiTiet()
                    Thongbao("Đã nhập khẩu chương trình đào tạo thành công !")
                    Me.Tag = "1"
                ElseIf chkUpdate.Checked Then ' Cập nhật thêm môn học cho Chương trình đào tạo
                    mclsCTDT.HienThi_ESSCTDTChiTiet(ID_dt)
                    'Chuyển chương trình đào tạo chi tiết
                    ChuyenDuLieuChuongTrinhDaoTaoChiTiet_Update(dtSrc, optTen_mon.Checked, 2, ID_dt)
                    'Load chương trình đào tạo chi tiết
                    mclsCTDT.HienThi_ESSCTDTChiTiet(ID_dt)
                    'Hiển thị các học phần
                    grdViewCTDTChiTiet.DataSource = mclsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(ID_dt).DefaultView
                    FormatDataViewCTDTChiTiet()
                    Thongbao("Đã cập nhật nhập khẩu chương trình đào tạo thành công !")
                    Me.Tag = "1"
                Else
                    Thongbao("Chương trình đào tạo này đã tồn tại, bạn không thể nhập được")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class