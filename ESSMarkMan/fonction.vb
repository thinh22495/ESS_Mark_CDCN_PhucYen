Imports C1
Imports C1.Win.C1FlexGrid
Public Class fonction
    Public Shared Sub Flexgrid_setup(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        '   Định nghĩa các kiểu để hiển thị      
        Dim Font_ As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point)
        Dim Normal_Style As CellStyle
        Dim LyThuyet_Style, ThucHanh_Style As CellStyle
        Dim Chon_Style As CellStyle
        Dim Free_Style As CellStyle
        Dim ReadOnly_Style As CellStyle
        'Fixed_Style
        Free_Style = fg.Styles.Add("Free_Style")
        Free_Style.BackColor = Color.LemonChiffon
        'Normal_Style
        Normal_Style = fg.Styles.Add("Normal_Style")
        Normal_Style.BackColor = Color.Azure
        Normal_Style.ForeColor = Color.Black
        Normal_Style.Font = Font_
        Normal_Style.TextAlign = TextAlignEnum.CenterCenter
        'LyThuyet_Style
        LyThuyet_Style = fg.Styles.Add("LyThuyet_Style")
        LyThuyet_Style.BackColor = Color.CornflowerBlue
        LyThuyet_Style.ForeColor = Color.White
        LyThuyet_Style.Font = Font_
        LyThuyet_Style.TextAlign = TextAlignEnum.CenterCenter
        LyThuyet_Style.ImageAlign = ImageAlignEnum.RightBottom
        LyThuyet_Style.Border.Style = BorderStyleEnum.Raised
        LyThuyet_Style.Border.Color = Color.Blue
        'ThucHanh_Style
        ThucHanh_Style = fg.Styles.Add("ThucHanh_Style")
        ThucHanh_Style.BackColor = Color.Peru
        ThucHanh_Style.ForeColor = Color.White
        ThucHanh_Style.Font = Font_
        ThucHanh_Style.TextAlign = TextAlignEnum.CenterCenter
        ThucHanh_Style.ImageAlign = ImageAlignEnum.RightBottom
        ThucHanh_Style.Border.Style = BorderStyleEnum.Raised
        ThucHanh_Style.Border.Color = Color.Blue
        'Chon_Style
        Chon_Style = fg.Styles.Add("Chon_Style")
        Chon_Style.BackColor = Color.Tomato
        Chon_Style.ForeColor = Color.White
        Chon_Style.Font = Font_
        Chon_Style.TextAlign = TextAlignEnum.CenterCenter
        Chon_Style.ImageAlign = ImageAlignEnum.RightBottom
        Chon_Style.Border.Style = BorderStyleEnum.Raised
        Chon_Style.Border.Color = Color.Blue
        'ReadOnly_Style
        ReadOnly_Style = fg.Styles.Add("ReadOnly_Style")
        ReadOnly_Style.BackColor = Color.Gainsboro
        ReadOnly_Style.ForeColor = Color.Black
        ReadOnly_Style.Font = Font_
        ReadOnly_Style.TextAlign = TextAlignEnum.CenterCenter
        ReadOnly_Style.ImageAlign = ImageAlignEnum.RightBottom
        ReadOnly_Style.Border.Style = BorderStyleEnum.Raised
    End Sub
    Public Shared Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = Color.PowderBlue
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
    End Sub
End Class
