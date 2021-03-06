Imports DevExpress.XtraReports.UI
Imports ESS.Bussines
Public Class rptBangTotNghiep_All
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        'Me.DataSource = dv
        'Binding()

        'Me.Ten_en.Text = ChuyenSangKhongDau(dv.Item(0)("Ho_ten").ToString)
        'Ngay_sinh_en.Text = Format(dv.Item(0)("Ngay_sinh"), "MMMM dd, yyyy")
    End Sub
    Public Sub Binding()
        Me.Ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        'Me.So_bang.DataBindings.Add("Text", DataSource, "So_bang")
        Me.Nganh_dao_tao.DataBindings.Add("Text", DataSource, "Ten_nganh")
        Me.Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")
        Me.Hinh_thuc.DataBindings.Add("Text", DataSource, "Ten_he")

        Nganh_dao_tao_en.DataBindings.Add("Text", DataSource, "Ten_nganh_En")
        Xep_loai_en.DataBindings.Add("Text", DataSource, "Xep_hang_En")
        Ten_he_en.DataBindings.Add("Text", DataSource, "Ten_he_En")
        Me.So_bang_en.DataBindings.Add("Text", DataSource, "So_bang")
    End Sub
    Public Function ChuyenSangKhongDau(ByVal mystr As String) As String
        Dim myChar() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬ", "ÒÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ", "EÈÉẺẼẸÊỀẾỂỄỆ", "UÙÚỦŨỤƯỪỨỬỮỰ", "IÌÍỈĨỊ", "YỲÝỶỸỴ", "Đ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
        Dim myChar1() As String = {"a", "A", "O", "E", "U", "I", "Y", "Đ", "o", "e", "u", "i", "y", "d"}
        Dim str As String = mystr
        Dim strReturn As String = ""
        For i As Int32 = 0 To str.Length - 1
            Dim iStr As String = str.Substring(i, 1)
            Dim rStr As String = iStr

            For j As Int32 = 0 To myChar.Length - 1
                If myChar(j).IndexOf(iStr) >= 0 Then
                    rStr = myChar1(j)
                    Exit For
                End If
            Next
            strReturn += rStr
        Next
        Return strReturn
    End Function
End Class