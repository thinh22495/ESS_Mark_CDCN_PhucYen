Imports System.Drawing.Drawing2D
Imports C1.Win.C1FlexGrid
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ToChucThi_PhanPhong
    Private Loader As Boolean = False
    Private mSave As Boolean = False
    Private dndMouseDownRow, dndMouseDownCol As Integer
    Private ID_phong As Integer = 0
    Private Ten_phong As String = ""
    Private Suc_chua As Integer = 0
    Private Drop As Boolean = False
    Private mclsPhongHoc As New PhongHoc_Bussines()
    Private mclsThi As TochucThi_Bussines
    Private mID_thi As Integer = 0
    Private mNgay_thi As Date
    Private mCa_thi As Integer
    Private msCa_thi As String
    Private mNhom_tiet As Integer
    Public Overloads Sub ShowDialog(ByVal ID_thi As Integer, ByVal clsThi As TochucThi_Bussines)
        mclsThi = clsThi
        mID_thi = ID_thi
        Dim idx_thi As Integer
        idx_thi = mclsThi.Tim_idx(ID_thi)
        If idx_thi >= 0 Then
            mNgay_thi = mclsThi.ToChucThi(idx_thi).Ngay_thi
            mCa_thi = mclsThi.ToChucThi(idx_thi).Ca_thi
            mNhom_tiet = mclsThi.ToChucThi(idx_thi).Nhom_tiet
        End If
        Me.ShowDialog()
    End Sub
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            dt = clsDM.DanhMuc_Load("PLAN_ToaNha", "ID_nha", "Ten_nha")
            FillCombo(cmbID_nha, dt)
            dt = clsDM.DanhMuc_Load("PLAN_CoSoDaoTao", "ID_co_so", "Ten_co_so")
            FillCombo(cmbID_co_so, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function ValidateTrungPhong(ByVal ID_phong As Integer, ByVal Ca_thi As String, ByVal Nhom_tiet As Integer) As Boolean
        Dim dt As DataTable = fgLop.DataSource.Table
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_phong").ToString = ID_phong.ToString And dt.Rows(i)("Ca_thi").ToString = Ca_thi.ToString And dt.Rows(i)("Nhom_tiet").ToString = Nhom_tiet.ToString Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Function ValidateSoSinhVien(ByVal So_sv As Integer, ByVal Suc_chua As Integer) As Boolean
        If Suc_chua < So_sv Then
            If Thongbao("Sức chứa của phòng nhỏ hơn số sinh viên của phòng thi. Bạn có phân tiếp không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub frmESS_PhanPhongHoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_PhanPhongHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        Flexgrid_setup(fgLop)
        Format_fix_region(fgLop)
        Flexgrid_setup(fgPhongHoc)
        Format_fix_region(fgPhongHoc)
        'Load danh sách phòng học
        fgPhongHoc.DataSource = mclsPhongHoc.DanhSachPhanPhongHoc(0)
        FormatFlexGridPhongHoc()
        'Loa phòng thi
        Me.fgLop.DataSource = mclsThi.DanhSachPhongThi(mID_thi).DefaultView
        FormatFlexGridLop()
        Loader = True
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(cmdSave)
    End Sub

    Private Sub frmESS_PhanPhongHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmbID_nha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_nha.SelectedIndexChanged, cmbID_co_so.SelectedIndexChanged
        Try
            fgPhongHoc.DataSource = mclsPhongHoc.DanhSachPhanPhongHoc(cmbID_nha.SelectedValue, cmbID_co_so.SelectedValue)
            FormatFlexGridPhongHoc()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dt As DataTable = fgLop.DataSource.Table
            Dim ID_phong_thi As Integer
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim objPhongThi As New ESSToChucThiPhong
                ID_phong_thi = dt.Rows(i)("ID_phong_thi")
                objPhongThi.ID_phong_thi = dt.Rows(i)("ID_phong_thi")
                objPhongThi.ID_thi = dt.Rows(i)("ID_thi")
                'objPhongThi.ID_lop_tc = dt.Rows(i)("ID_lop_tc")
                objPhongThi.ID_phong = dt.Rows(i)("ID_phong")
                objPhongThi.Ten_phong = dt.Rows(i)("Ten_phong")
                objPhongThi.So_sv = dt.Rows(i)("So_sv")
                'objPhongThi.Gio_thi = dt.Rows(i)("Gio_thi")
                mclsThi.CapNhat_ESSToChucThiPhong(objPhongThi, ID_phong_thi)
            Next
            Save = True
            Thongbao("Đã lưu thành công ")
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = Color.PowderBlue
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Public Sub Flexgrid_setup(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        'Định nghĩa các kiểu để hiển thị      
        Dim Font_ As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim Hoc_Style As CellStyle
        'ThucHanh_Style
        Hoc_Style = fg.Styles.Add("Hoc_Style")
        Hoc_Style.BackColor = Color.Gray
        Hoc_Style.Border.Color = Color.Gray
        Hoc_Style.ForeColor = Color.Red
        Hoc_Style.Font = Font_
        Hoc_Style.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Sub FormatFlexGridLop()
        Try
            fgLop.AllowMerging = AllowMergingEnum.Free
            fgLop.Rows.Fixed = 1
            fgLop.Cols.Fixed = 1
            'Set Caption

            fgLop.Cols("Ten_phong").Caption = "Tên phòng"
            fgLop.Cols("So_sv").Caption = "Số sinh viên"
            fgLop.Cols("Ca_thi").Caption = "Ca thi"
            fgLop.Cols("Nhom_tiet").Caption = "Nhóm tiết"
            fgLop.Cols("Gio_thi").Caption = "Giờ thi"

            fgLop.Rows(0).Height = 60
            fgLop.Cols("ID_phong_thi").Width = 0
            fgLop.Cols("ID_thi").Width = 0
            'fgLop.Cols("ID_lop_tc").Width = 0
            fgLop.Cols("ID_phong").Width = 0
            fgLop.Cols("Ten_phong").Width = 70
            fgLop.Cols("So_sv").Width = 70
            fgLop.Cols("Dot_thi").Width = 0
            fgLop.Cols("Ngay_thi").Width = 0
            fgLop.Cols("Ca_thi").Width = 70
            fgLop.Cols("Nhom_tiet").Width = 70
            fgLop.Cols("Gio_thi").Width = 70
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub FormatFlexGridPhongHoc()
        Try
            fgPhongHoc.AllowMerging = AllowMergingEnum.Free
            fgPhongHoc.Rows.Fixed = 1
            fgPhongHoc.Cols.Fixed = 1
            'Set Caption
            fgPhongHoc.Cols("Ten_phong").Caption = "Tên phòng"
            fgPhongHoc.Cols("Suc_chua").Caption = "Số sv"
            fgPhongHoc.Cols("Ten_loai_phong").Caption = "Loại phòng"

            fgPhongHoc.Rows(0).Height = 40
            fgPhongHoc.Cols("ID_phong").Width = 0
            fgPhongHoc.Cols("Ten_phong").Width = 120
            fgPhongHoc.Cols("Suc_chua").Width = 50
            fgPhongHoc.Cols("Ten_loai_phong").Width = 150

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public Property Save() As Boolean
        Get
            Return mSave
        End Get
        Set(ByVal Value As Boolean)
            mSave = Value
        End Set
    End Property

    Private Sub fgGiaoVien_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles fgPhongHoc.MouseDown
        Try
            Dim ht As C1.Win.C1FlexGrid.HitTestInfo
            ht = fgPhongHoc.HitTest(e.X, e.Y)
            Me.dndMouseDownRow = ht.Row
            Me.dndMouseDownCol = ht.Column
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub fgGiaoVien_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles fgPhongHoc.MouseMove
        Try
            Dim ht As C1.Win.C1FlexGrid.HitTestInfo
            ht = fgPhongHoc.HitTest(e.X, e.Y)
            If (e.Button = MouseButtons.Left) Then
                If (((dndMouseDownRow = -(1)) OrElse (dndMouseDownCol = -(1))) OrElse ((ht.Row = dndMouseDownRow) AndAlso (ht.Column = dndMouseDownCol))) Then
                    Return
                End If
                ID_phong = fgPhongHoc(dndMouseDownRow, "ID_phong")
                Ten_phong = fgPhongHoc(dndMouseDownRow, "Ten_phong")
                Suc_chua = fgPhongHoc(dndMouseDownRow, "Suc_chua")
                Drop = True
                Me.DoDragDrop(ID_phong.ToString + "-" + Ten_phong.ToString, DragDropEffects.Copy)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub fgLop_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles fgLop.DragDrop
        Dim p As New Point(e.X, e.Y)
        Dim ht As C1.Win.C1FlexGrid.HitTestInfo
        Dim So_sv As Integer
        ht = Me.fgLop.HitTest(Me.fgLop.PointToClient(p).X, Me.fgLop.PointToClient(p).Y)
        If ht.Row > 0 And Drop Then
            So_sv = fgLop(ht.Row, "So_sv")
            If fgLop(ht.Row, "Ca_thi") = "Ca Sáng" Then
                mCa_thi = 0
            ElseIf fgLop(ht.Row, "Ca_thi") = "Ca Chiều" Then
                mCa_thi = 1
            Else
                mCa_thi = 2
            End If
            msCa_thi = fgLop(ht.Row, "Ca_thi")
            mNhom_tiet = fgLop(ht.Row, "Nhom_tiet")
            If ValidateTrungPhong(ID_phong, msCa_thi, mNhom_tiet) And mclsThi.ValidateTrungPhong(ID_phong, mNgay_thi, mCa_thi, mNhom_tiet) Then
                If ValidateSoSinhVien(So_sv, Suc_chua) Then
                    fgLop(ht.Row, "ID_phong") = ID_phong
                    fgLop(ht.Row, "Ten_phong") = Ten_phong
                    Drop = False
                End If
            Else
                Thongbao("Tại thời điểm này, phòng này đã được phân thi rồi, bạn chọn phòng khác !")
            End If
            Drop = False
        End If
    End Sub

    Private Sub fgLop_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles fgLop.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub fgLop_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fgLop.KeyDown
        If e.KeyCode = Keys.Delete Then
            If fgLop.Selection.RightCol = 8 Then
                For i As Integer = fgLop.Selection.TopRow To fgLop.Selection.BottomRow
                    fgLop(i, "ID_phong") = 0
                    fgLop(i, "Ten_phong") = ""
                Next
            End If
        End If
    End Sub
End Class