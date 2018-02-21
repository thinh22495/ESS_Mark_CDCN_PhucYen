Imports ESS.Bussines
Public Module EnumNConst
    Public Ngay_tuan As Integer = Thu_ket_thuc - Thu_bat_dau + 1
    Public So_tiet_ca As Integer
    Public Tong_so_sk_tuan_ca As Integer
    Public So_tiet_ngay As Integer
    Public So_ca_hoc As Integer
    Public So_tiet_min As Integer
    Public Thu_bat_dau As eTHU
    Public Thu_ket_thuc As eTHU
    Public Enum eCA_HOC As Integer
        KHONG_XAC_DINH = -1

        SANG = 0
        CHIEU = 1
        TOI = 2
    End Enum

    Public Enum eLOAI_TIET As Integer
        KHONG_XAC_DINH = -1

        LY_THUYET = 0
        THUC_HANH = 1
    End Enum
    Public Enum eTHU As Integer
        KHONG_XAC_DINH = -1

        THU_HAI = 0
        THU_BA = 1
        THU_TU = 2
        THU_NAM = 3
        THU_SAU = 4
        THU_BAY = 5
        CHU_NHAT = 6
    End Enum
    Public Enum eLOAI_SK
        LICH_HOC = 0
        LK_LOP = 1
        LK_GV = 2
        LK_PHONG = 3
    End Enum
    Public Sub Doc_tham_so_he_thong()
        Try
            Dim cls As New ThamSoHeThong_Bussines
            Thu_bat_dau = cls.Doc_tham_so("Thu_bat_dau")
            Thu_ket_thuc = cls.Doc_tham_so("Thu_ket_thuc")
            So_tiet_ca = cls.Doc_tham_so("So_tiet_ca")
            So_ca_hoc = cls.Doc_tham_so("So_ca_hoc")
            So_tiet_ngay = cls.Doc_tham_so("So_tiet_ngay")
            So_tiet_min = cls.Doc_tham_so("So_tiet_min")
            Ngay_tuan = Thu_ket_thuc - Thu_bat_dau + 1
            Tong_so_sk_tuan_ca = Ngay_tuan * 2
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Module
