'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, May 02, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDiem
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_diem As Integer = 0
        Private mID_dv As String = ""
        Private mID_sv As Integer = 0
        Private mID_mon As Integer = 0
        Private mID_dt As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mDiemThanhPhan As New ESSDiemThanhPhan
        Private mDiemDanh As New DiemDanh
        Private mSo_tiet As Integer = 0
        Private mDiemThi As New ESSDiemThi
        Private mTinh_tich_luy As Boolean = False
        Private mDuyet As Boolean = False
        Private mDiemKhongDuDKThi As New ESSDiemKhongDuDieuKienThi
#End Region

#Region "Property"
        Public Property ID_diem() As Integer
            Get
                Return mID_diem
            End Get
            Set(ByVal Value As Integer)
                mID_diem = Value
            End Set
        End Property
        Public Property ID_dv() As String
            Get
                Return mID_dv
            End Get
            Set(ByVal Value As String)
                mID_dv = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Tinh_tich_luy() As Boolean
            Get
                Return mTinh_tich_luy
            End Get
            Set(ByVal Value As Boolean)
                mTinh_tich_luy = Value
            End Set
        End Property
        Public Property Duyet() As Boolean
            Get
                Return mDuyet
            End Get
            Set(ByVal Value As Boolean)
                mDuyet = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property dsDiemDanh() As DiemDanh
            Get
                Return mDiemDanh
            End Get
            Set(ByVal Value As DiemDanh)
                mDiemDanh = Value
            End Set
        End Property
        Public Property So_tiet() As Integer
            Get
                Return mSo_tiet
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet = Value
            End Set
        End Property
        Public Property dsDiemThanhPhan() As ESSDiemThanhPhan
            Get
                Return mDiemThanhPhan
            End Get
            Set(ByVal Value As ESSDiemThanhPhan)
                mDiemThanhPhan = Value
            End Set
        End Property
        Public Property dsDiemThi() As ESSDiemThi
            Get
                Return mDiemThi
            End Get
            Set(ByVal Value As ESSDiemThi)
                mDiemThi = Value
            End Set
        End Property
        'Public ReadOnly Property Thi_lai(ByVal So_lan_thi_lai As Integer) As Boolean
        '    Get
        '        If dsDiemThi.Diem_chu_max = "F" Then
        '            Dim So_lan_duoc_thi As Integer = So_lan_thi_lai
        '            Dim So_lan_da_thi As Integer = 0
        '            For i As Integer = 0 To dsDiemThi.Count - 1
        '                If dsDiemThi.ESSDiemThi(i).Ghi_chu.ToUpper <> "P" And dsDiemThi.ESSDiemThi(i).Ghi_chu.ToUpper <> "M" And dsDiemThi.ESSDiemThi(i).Ghi_chu.ToUpper <> "K" Then
        '                    So_lan_da_thi += 1
        '                End If
        '            Next
        '            If So_lan_da_thi > 0 AndAlso So_lan_da_thi Mod So_lan_duoc_thi > 0 Then
        '                Return True
        '            End If
        '        End If
        '        Return False
        '    End Get
        'End Property

        Public ReadOnly Property Thi_lai_SauLan1_F(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "F" AndAlso dsDiemThi.Count > 0 Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property Thi_lai_SauLan1_FD(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If (dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "F" Or dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "D") AndAlso dsDiemThi.Count > 0 Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property

        Public ReadOnly Property Thi_lai_SauLan1_F_D_C(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If (dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "F" Or dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "D" Or dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "C") AndAlso dsDiemThi.Count > 0 Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property


        Public ReadOnly Property Thi_lai_SauLan1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) >= "B" AndAlso dsDiemThi.Count > 0 Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property


        Public ReadOnly Property Thi_lai_SauLan1_DiemDuoi5(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.TBCMH_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) < 5 AndAlso dsDiemThi.Count > 0 Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property Thi_lai_monchungchi_SauLan1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If dsDiemThi.TBCMH_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) < 5 AndAlso dsDiemThi.Count > 0 Then
                    'If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" And dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "K" Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper <> "M" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property

        Public ReadOnly Property Thi_nang_diem_SauLan1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Boolean
            Get
                If (dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "D" Or dsDiemThi.Diem_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "C") AndAlso dsDiemThi.Count > 0 Then
                    Return True
                End If
                Return False
            End Get
        End Property

        Public ReadOnly Property Hoc_lai(ByVal So_lan_thi_lai As Integer) As Boolean
            Get
                If dsDiemThi.Diem_chu_max(0, "") = "F" Then
                    Dim So_lan_duoc_thi As Integer = So_lan_thi_lai
                    Dim So_lan_da_thi As Integer = 0
                    For i As Integer = 0 To dsDiemThi.Count - 1
                        If dsDiemThi.ESSDiemThi(i).Ghi_chu.ToUpper <> "M" Then
                            So_lan_da_thi += 1
                        End If
                    Next
                    If So_lan_da_thi > 0 AndAlso So_lan_da_thi Mod So_lan_duoc_thi = 0 Then
                        Return True
                    Else
                        'If dsDiemThi.Count > 0 Then
                        '    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper = "K" Then
                        '        Return True
                        '    End If
                        'End If
                    End If
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property Hoc_lai_monchungchi(ByVal So_lan_thi_lai As Integer) As Boolean
            Get
                If dsDiemThi.TBCMH_max < 5 Then
                    Dim So_lan_duoc_thi As Integer = So_lan_thi_lai
                    Dim So_lan_da_thi As Integer = 0
                    For i As Integer = 0 To dsDiemThi.Count - 1
                        If dsDiemThi.ESSDiemThi(i).Ghi_chu.ToUpper <> "M" Then
                            So_lan_da_thi += 1
                        End If
                    Next
                    If So_lan_da_thi > 0 AndAlso So_lan_da_thi Mod So_lan_duoc_thi = 0 Then
                        Return True
                    Else
                        'If dsDiemThi.Count > 0 Then
                        '    If dsDiemThi.ESSDiemThi(0).Ghi_chu = "K" Then
                        '        Return True
                        '    End If
                        'End If
                    End If
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_X(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "" Then
                    If dsDiemThi.Count > 0 Then
                        If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper = "X" Then
                            Return True
                        End If
                    End If
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_I(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "" Then
                    If dsDiemThi.Count > 0 Then
                        If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper = "I" Then
                            Return True
                        End If
                    End If
                End If
                Return False
            End Get
        End Property

        Public ReadOnly Property GhiChu_R() As Boolean
            Get
                If dsDiemThi.Count > 0 Then
                    If dsDiemThi.ESSDiemThi(0).Ghi_chu.ToUpper = "R" Then
                        Return True
                    End If
                End If
                Return False
            End Get
        End Property


        '----------------Các ghi chú Fix, cần sửa khi đi triển khai--------------------------
        Public ReadOnly Property GhiChu_KhongDuDKDT(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "K" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_CanhCao(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "C" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_BaoLuu(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "B" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_DinhChi(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "D" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_HSGioi(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "G" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_MienThi(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "M" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_ThiOlympic(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "O" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_VangThiCoPhep(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "P" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_VangThiKoPhep(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "V" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public ReadOnly Property GhiChu_KhienTrach(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Get
                If dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc).ToUpper = "T" Then
                    Return True
                End If
                Return False
            End Get
        End Property
        Public Property dsDiemKhongDuDKThi() As ESSDiemKhongDuDieuKienThi
            Get
                Return mDiemKhongDuDKThi
            End Get
            Set(ByVal Value As ESSDiemKhongDuDieuKienThi)
                mDiemKhongDuDKThi = Value
            End Set
        End Property
#End Region
    End Class
End Namespace