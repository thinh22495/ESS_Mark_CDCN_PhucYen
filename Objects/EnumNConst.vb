Public Module EnumNConst
    'Public Ngay_tuan As Integer = Thu_ket_thuc - Thu_bat_dau + 1
    'Public So_tiet_ca As Integer
    'Public Tong_so_sk_tuan_ca As Integer
    'Public So_tiet_ngay As Integer
    'Public So_ca_hoc As Integer
    'Public Nhom_tiet_donvi As Integer
    'Public Thu_bat_dau As eTHU
    'Public Thu_ket_thuc As eTHU
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
End Module
