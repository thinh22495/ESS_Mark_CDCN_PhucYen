Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_KhungChuongTrinhDaoTao_ChonHocPhan_ChungChi
    Dim MonHoc_bll As MonHoc_Bussines

#Region "Var"
    Private mMonHoc As New ArrayList
    Private mID_dt As Integer
    Private mID_chung_chi As Integer
    Private mThoat As Boolean
    Dim loader As Boolean = False
#End Region

#Region "Property"
    Property MonHoc() As ArrayList
        Get
            Return mMonHoc
        End Get
        Set(ByVal value As ArrayList)
            mMonHoc = value
        End Set
    End Property
    Property ID_dt() As Integer
        Get
            Return mID_dt
        End Get
        Set(ByVal value As Integer)
            mID_dt = value
        End Set
    End Property
    Property ID_chung_chi() As Integer
        Get
            Return mID_chung_chi
        End Get
        Set(ByVal value As Integer)
            mID_chung_chi = value
        End Set
    End Property
    Property Thoat() As Boolean
        Get
            Return mThoat
        End Get
        Set(ByVal value As Boolean)
            mThoat = value
        End Set
    End Property
#End Region

#Region "Function"
    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            MonHoc_bll = New MonHoc_Bussines(0, 0, ID_dt)
            grcHocPhan.DataSource = MonHoc_bll.DanhSachMonHoc().DefaultView
            FillComboBox()
            loader = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmBoMonChonMonHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub txtTen_gv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTen_mh.TextChanged
        If loader Then
            Dim DieuKien As String = "1=1"
            If txtTen_mh.Text.Trim <> "" Then DieuKien += " AND Ten_mon LIKE '" + txtTen_mh.Text.Trim + "%'"
            'Lọc theo các điều kiện eeeee
            grcHocPhan.DataSource.RowFilter = DieuKien
        End If
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Thoat = True
        Me.Close()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If cmbLoaiChungChi.SelectedIndex < 0 Then
            Thongbao("Bạn phải chọn loai chứng chỉ!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Thoat = False
        Dim dv As DataView = grvHocPhan.DataSource
        For i As Integer = 0 To dv.Count - 1
            Dim obj As New ESSMonHoc
            ' Lay mon hoc
            obj = MonHoc_bll.GetMonHoc(dv(i)("ID_mon"))
            MonHoc.Add(obj)
        Next
        ' Gán lại chứng chỉ
        ID_chung_chi = cmbLoaiChungChi.SelectedValue
        Me.Close()
    End Sub
    Private Sub FillComboBox()
        Dim clsDM As New DanhMuc_Bussines
        Dim dtLoaiChungChi As DataTable = clsDM.DanhMuc_Load("MARK_LoaiChungchi_TC", "ID_chung_chi", "Loai_chung_chi")
        FillCombo(cmbLoaiChungChi, dtLoaiChungChi)
        cmbLoaiChungChi.SelectedValue = ID_chung_chi
    End Sub
#End Region


End Class