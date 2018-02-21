'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, May 02, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDiemThi
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_diem As Integer = 0
        Private mLan_thi As Integer = 0
        Private mNam_hoc_thi As String = ""
        Private mHoc_ky_thi As Integer = 0
        Private mDiem_thi As Double = 0
        Private mDiem_chu As String = ""
        Private mDiem_so As Double = -1
        Private mTBCMH As Double = -1
        Private mGhi_chu As String = ""
        Private mHash_code As Integer = 0
        Private mLocked As Integer = 0
        Private mDiemThi As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal diem As ESSDiemThi)
            mDiemThi.Add(diem)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemThi.RemoveAt(idx)
        End Sub
        Public Function idx_diem_thi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                'If CType(mDiemThi(i), ESSDiemThi).ID_diem > 0 And ((CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi) Then
                If ((CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi) Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Function Tim_idx_diem_Thi(ByVal ID_diem As Integer, ByVal Hoc_ky_thi As Integer, ByVal Nam_hoc_thi As String, ByVal Lan_thi As Integer) As Boolean
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).ID_diem = ID_diem And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi And CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky_thi And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc_thi Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Function Diem_thi_lan(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), ESSDiemThi).Diem_thi
                End If
            Next
            Return -1
        End Function
        Public Function Diem_chu_lan(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            For i As Integer = 0 To mDiemThi.Count - 1
                If Hoc_ky <> 0 And Nam_hoc <> "" Then
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                        Return CType(mDiemThi(i), ESSDiemThi).Diem_chu.ToString
                    End If
                Else
                    If CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                        Return CType(mDiemThi(i), ESSDiemThi).Diem_chu.ToString
                    End If
                End If
            Next
            Return ""
        End Function
        Public Function Diem_chu_LanHoc1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            For i As Integer = 0 To mDiemThi.Count - 1
                If Hoc_ky <> 0 And Nam_hoc <> "" Then
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                        Return CType(mDiemThi(i), ESSDiemThi).Diem_chu.ToString
                    End If
                Else
                    If CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                        Return CType(mDiemThi(i), ESSDiemThi).Diem_chu.ToString
                    End If
                End If
            Next
            Return ""
        End Function
        Public Function TBCMH_lan(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), ESSDiemThi).TBCMH
                End If
            Next
            Return -1
        End Function
        Public Function TBCMH_lanthu(ByVal Lan_thi As Integer) As Double
            If mDiemThi.Count >= Lan_thi Then
                Return CType(mDiemThi(Lan_thi - 1), ESSDiemThi).TBCMH
            End If
            Return -1
        End Function
        Public Function TBCMH_max(Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As Double
            Dim DiemMax As Double = -1
            If Hoc_ky > 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Then
                        If CType(mDiemThi(i), ESSDiemThi).TBCMH >= 0 AndAlso CType(mDiemThi(i), ESSDiemThi).Ghi_chu = "NC" Then
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                            Exit For
                        End If
                        If CType(mDiemThi(i), ESSDiemThi).TBCMH > DiemMax Then
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                        End If
                    End If
                Next
            ElseIf Hoc_ky = 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc Then
                        If CType(mDiemThi(i), ESSDiemThi).TBCMH >= 0 AndAlso CType(mDiemThi(i), ESSDiemThi).Ghi_chu = "NC" Then
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                            Exit For
                        End If

                        If CType(mDiemThi(i), ESSDiemThi).TBCMH > DiemMax Then
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                        End If
                    End If
                Next
            Else
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).TBCMH >= 0 AndAlso CType(mDiemThi(i), ESSDiemThi).Ghi_chu = "NC" Then
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                        Exit For
                    End If

                    If CType(mDiemThi(i), ESSDiemThi).TBCMH > DiemMax Then
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                    End If
                Next
            End If
            Return DiemMax
        End Function
        Public Function Diem_so_max() As Double
            Dim DiemMax As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_so > DiemMax Then
                    DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                End If
            Next
            Return DiemMax
        End Function
        Public Function Diem_so_min_TongHop() As Double
            Dim DiemMin As Double = -1
            Dim mHoc_ky_thi As Integer = 2
            Dim mNam_hoc_thi As String = "2020-2021"
            Dim mLan_thi As Integer = 0
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                    If mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                        If mHoc_ky_thi > CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                            mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                            mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_so
                        ElseIf mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            If CType(mDiemThi(i), ESSDiemThi).Lan_thi = 1 Then
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_so
                            End If
                        End If
                    ElseIf mNam_hoc_thi > CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_so
                    End If
                End If
            Next
            Return DiemMin
        End Function
        Public Function Diem_so_max_TongHop() As Double
            Dim DiemMax As Double = -1
            Dim mHoc_ky_thi As Integer = 0
            Dim mNam_hoc_thi As String = "2000-2001"
            Dim mLan_thi As Integer = 0
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                    If mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                        If mHoc_ky_thi < CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                            mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                            mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                        ElseIf mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            If CType(mDiemThi(i), ESSDiemThi).Lan_thi = 1 Then
                                If mLan_thi > 1 Then
                                    If CType(mDiemThi(i), ESSDiemThi).Diem_so > DiemMax And CType(mDiemThi(i), ESSDiemThi).Diem_so = 0 Then
                                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                        DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                                    End If
                                Else
                                    mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                    mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                    DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                                End If
                                'Lay diem thi cai thien chu ko lay diem ky nay
                            ElseIf CType(mDiemThi(i), ESSDiemThi).Lan_thi > mLan_thi AndAlso CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                                If (mLan_thi = 1 And DiemMax > 0) Or (CType(mDiemThi(i), ESSDiemThi).Diem_chu_lan(1, mHoc_ky_thi, mNam_hoc_thi).ToString <> "" AndAlso CType(mDiemThi(i), ESSDiemThi).Diem_chu_lan(1, mHoc_ky_thi, mNam_hoc_thi) < "F") Then
                                    DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                                Else
                                    If CType(mDiemThi(i), ESSDiemThi).Diem_so >= DiemMax Then ' Cu tam gan la diem cao nhat
                                        DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                                    End If
                                End If
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            End If
                        End If
                    ElseIf mNam_hoc_thi < CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi AndAlso CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                    End If
                End If
            Next
            Return DiemMax
        End Function
        Public Function Diem_chu_max_TongHop() As String
            Dim DiemMin As String = "Z"
            Dim mHoc_ky_thi As Integer = 0
            Dim mNam_hoc_thi As String = "2000-2001"
            Dim mLan_thi As Integer = 0
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" Then
                    If CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                        If mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                            If mHoc_ky_thi < CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                            ElseIf mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                                If CType(mDiemThi(i), ESSDiemThi).Lan_thi = 1 Then
                                    If mLan_thi > 1 Then
                                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin And CType(mDiemThi(i), ESSDiemThi).Diem_so = 0 Then
                                            mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                            mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                            mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_so
                                        End If
                                    Else
                                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                                    End If
                                    'Lay diem cai thien chu ko lay diem ky nay
                                ElseIf CType(mDiemThi(i), ESSDiemThi).Lan_thi > mLan_thi Then
                                    If (mLan_thi = 1 And DiemMin < "F") Or (CType(mDiemThi(i), ESSDiemThi).Diem_chu_lan(1, mHoc_ky_thi, mNam_hoc_thi).ToString <> "" AndAlso CType(mDiemThi(i), ESSDiemThi).Diem_chu_lan(1, mHoc_ky_thi, mNam_hoc_thi) < "F") Then
                                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                                    Else
                                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then ' La thi lai
                                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                                        End If
                                    End If
                                    mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                    mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                End If
                                End If
                        ElseIf mNam_hoc_thi < CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                            mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                            mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                            mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        End If
                    End If
                End If
            Next
            If DiemMin = "Z" Then
                Return ""
            Else
                Return DiemMin
            End If
        End Function
        Public Function Diem_chu_min_TongHop() As String
            Dim DiemMin As String = "Z"
            Dim mHoc_ky_thi As Integer = 2
            Dim mNam_hoc_thi As String = "2020-2021"
            Dim mLan_thi As Integer = 3
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                    If CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                        If mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                            If mHoc_ky_thi > CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                            ElseIf mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                                If CType(mDiemThi(i), ESSDiemThi).Lan_thi = 1 Then
                                    mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                    mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                    DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                                ElseIf CType(mDiemThi(i), ESSDiemThi).Lan_thi < mLan_thi Then
                                    mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                    mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                    DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                                End If
                            End If
                        ElseIf mNam_hoc_thi > CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                            mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                            mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                            mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        End If
                    End If
                End If
            Next
            If DiemMin = "Z" Then
                Return ""
            Else
                Return DiemMin
            End If
        End Function

        Public Function TBCMH_max_TongHop() As Double
            Dim DiemMax As Double = -1
            Dim mLan_thi As Integer = 0
            Dim mHoc_ky_thi As Integer = 2
            Dim mNam_hoc_thi As String = "2000-2001"
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                If mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                    If mHoc_ky_thi < CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                    ElseIf mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            If CType(mDiemThi(i), ESSDiemThi).Lan_thi = 1 Then
                                If mLan_thi > 1 Then
                                    If CType(mDiemThi(i), ESSDiemThi).Diem_so > DiemMax And CType(mDiemThi(i), ESSDiemThi).Diem_so = 0 Then
                                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                        DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                                    End If
                                Else
                                    mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                    mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                    DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                                End If
                            ElseIf CType(mDiemThi(i), ESSDiemThi).Lan_thi > mLan_thi Then
                                If (mLan_thi = 1 And DiemMax >= 4) Or (CType(mDiemThi(i), ESSDiemThi).Diem_chu_lan(1, mHoc_ky_thi, mNam_hoc_thi).ToString <> "" AndAlso CType(mDiemThi(i), ESSDiemThi).Diem_chu_lan(1, mHoc_ky_thi, mNam_hoc_thi) < "F") Then
                                    DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                                Else
                                    If CType(mDiemThi(i), ESSDiemThi).TBCMH > DiemMax Then ' La thi lai
                                        DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                                    End If
                                End If
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            End If
                            End If
                ElseIf mNam_hoc_thi < CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                    mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                    mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                    DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                    End If
                End If
            Next
            Return DiemMax
        End Function

        Public Function TBCMH_min_TongHop() As Double
            Dim DiemMax As Double = -1
            Dim mHoc_ky_thi As Integer = 2
            Dim mNam_hoc_thi As String = "2020-2021"
            Dim mLan_thi As Integer = 3
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_so >= 0 Then
                    If mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                        If mHoc_ky_thi > CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                            mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                            mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                        ElseIf mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi Then
                            If CType(mDiemThi(i), ESSDiemThi).Lan_thi = 1 Then
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                            ElseIf CType(mDiemThi(i), ESSDiemThi).Lan_thi < mLan_thi Then
                                mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                                mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                                mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                                DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                            End If
                        End If
                    ElseIf mNam_hoc_thi > CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi Then
                        mHoc_ky_thi = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
                        mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
                        mLan_thi = CType(mDiemThi(i), ESSDiemThi).Lan_thi
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
                    End If
                End If
            Next
            Return DiemMax
        End Function
        Public Function Diem_chu_max(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim DiemMin As String = "Z"
            If Hoc_ky > 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi < Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Or (CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi < Nam_hoc) Then
                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        End If
                    End If
                Next
                If DiemMin = "Z" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            Else
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                    End If
                Next
                If DiemMin = "Z" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            End If
        End Function

        Public Function Diem_chu_max_TongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim DiemMin As String = "Z"
            If Hoc_ky > 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Then
                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" AndAlso CType(mDiemThi(i), ESSDiemThi).Ghi_chu = "NC" Then
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                            Exit For
                        End If

                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        End If
                    End If
                Next
                If DiemMin = "Z" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            ElseIf Hoc_ky = 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc Then
                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" AndAlso CType(mDiemThi(i), ESSDiemThi).Ghi_chu = "NC" Then
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                            Exit For
                        End If

                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        End If
                    End If
                Next
                If DiemMin = "Z" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            Else
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" AndAlso CType(mDiemThi(i), ESSDiemThi).Ghi_chu = "NC" Then
                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        Exit For
                    End If

                    If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                    End If
                Next
                If DiemMin = "Z" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            End If
        End Function

        Public Function Diem_chu_Min(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim DiemMin As String = "Z"
            If Hoc_ky > 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi < Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Or (CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi < Nam_hoc) Then
                        If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                            DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                        End If
                    End If
                Next
                If DiemMin = "A" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            Else
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                    End If
                Next
                If DiemMin = "A" Then
                    Return ""
                Else
                    Return DiemMin
                End If
            End If
        End Function

        'Public Function Diem_chu_max(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
        '    Dim DiemMin As String = "Z"
        '    For i As Integer = 0 To mDiemThi.Count - 1
        '        If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi < Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Or (CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi < Nam_hoc) Then
        '            If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
        '                DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
        '            End If
        '        End If
        '    Next
        '    If DiemMin = "Z" Then
        '        Return ""
        '    Else
        '        Return DiemMin
        '    End If
        'End Function
        Public Function Diem_so_lan(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), ESSDiemThi).Diem_so
                End If
            Next
            Return -1
        End Function
        Public Function Ghi_chu_lan(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), ESSDiemThi).Ghi_chu
                End If
            Next
            Return ""
        End Function
        Public Function Diem_thi_lan_Locked(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) And CType(mDiemThi(i), ESSDiemThi).Lan_thi = Lan_thi Then
                    Return CType(mDiemThi(i), ESSDiemThi).Locked
                End If
            Next
            Return False
        End Function
        Public Function Diem_thi_max(Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As Double
            Dim DiemMax As Double = -1
            If Hoc_ky > 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Then
                        If CType(mDiemThi(i), ESSDiemThi).Diem_thi > DiemMax Then
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_thi
                        End If
                    End If
                Next
            ElseIf Hoc_ky = 0 And Nam_hoc <> "" Then
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi(i) = Nam_hoc Then
                        If CType(mDiemThi(i), ESSDiemThi).Diem_thi > DiemMax Then
                            DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_thi
                        End If
                    End If
                Next
            Else
                For i As Integer = 0 To mDiemThi.Count - 1
                    If CType(mDiemThi(i), ESSDiemThi).Diem_thi > DiemMax Then
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_thi
                    End If
                Next
            End If
            Return DiemMax
        End Function

        Public Function Diem_thi_lan_cac_lan_view(ByVal Ghi_chu As Boolean) As String
            Dim Diem_thi_view As String = ""
            For i As Integer = 0 To mDiemThi.Count - 1
                If CType(mDiemThi(i), ESSDiemThi).Diem_thi >= 0 Then
                    Diem_thi_view += CType(mDiemThi(i), ESSDiemThi).Diem_thi.ToString
                    If Ghi_chu And CType(mDiemThi(i), ESSDiemThi).Ghi_chu <> "" Then
                        Diem_thi_view += "(" + CType(mDiemThi(i), ESSDiemThi).Ghi_chu + ")"
                    End If
                    Diem_thi_view += "-"
                End If
            Next
            If Diem_thi_view <> "" Then Diem_thi_view = Left(Diem_thi_view, Len(Diem_thi_view) - 1)
            Return Diem_thi_view
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemThi.Count
            End Get
        End Property
        Public Property ESSDiemThi(ByVal idx As Integer) As ESSDiemThi
            Get
                Return CType(mDiemThi(idx), ESSDiemThi)
            End Get
            Set(ByVal Value As ESSDiemThi)
                mDiemThi(idx) = Value
            End Set
        End Property
        Public Property Lan_thi() As Integer
            Get
                Return mLan_thi
            End Get
            Set(ByVal Value As Integer)
                mLan_thi = Value
            End Set
        End Property
        Public Property ID_diem() As Integer
            Get
                Return mID_diem
            End Get
            Set(ByVal Value As Integer)
                mID_diem = Value
            End Set
        End Property
        Public Property Diem_thi() As Double
            Get
                Return mDiem_thi
            End Get
            Set(ByVal Value As Double)
                mDiem_thi = Value
            End Set
        End Property
        Public Property TBCMH() As Double
            Get
                Return mTBCMH
            End Get
            Set(ByVal Value As Double)
                mTBCMH = Value
            End Set
        End Property
        Public Property Diem_chu() As String
            Get
                Return mDiem_chu
            End Get
            Set(ByVal Value As String)
                mDiem_chu = Value
            End Set
        End Property
        Public Property Diem_so() As Double
            Get
                Return mDiem_so
            End Get
            Set(ByVal Value As Double)
                mDiem_so = Value
            End Set
        End Property
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
        Public Property Hash_code() As Integer
            Get
                Return mHash_code
            End Get
            Set(ByVal Value As Integer)
                mHash_code = Value
            End Set
        End Property
        Public Property Locked() As Integer
            Get
                Return mLocked
            End Get
            Set(ByVal Value As Integer)
                mLocked = Value
            End Set
        End Property

        Public Property Hoc_ky_thi() As Integer
            Get
                Return mHoc_ky_thi
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky_thi = Value
            End Set
        End Property
        Public Property Nam_hoc_thi() As String
            Get
                Return mNam_hoc_thi
            End Get
            Set(ByVal Value As String)
                mNam_hoc_thi = Value
            End Set
        End Property

        Function Diem_TBCMH_max_KyNam(ByRef mHoc_ky As Integer, ByRef mNam_hoc As String) As Integer
            'Dim DiemMax As Double = -1
            'For i As Integer = 0 To mDiemThi.Count - 1
            '    'If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Then
            '    'If CType(mDiemThi(i), ESSDiemThi).TBCMH > DiemMax Then
            '    mHoc_ky = CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi
            '    mNam_hoc_thi = CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi
            '    'DiemMax = CType(mDiemThi(i), ESSDiemThi).TBCMH
            '    'End If
            '    'End If
            'Next
            Dim check As Integer = -1
            If mDiemThi.Count > 0 Then
                mHoc_ky = CType(mDiemThi(0), ESSDiemThi).Hoc_ky_thi
                mNam_hoc = CType(mDiemThi(0), ESSDiemThi).Nam_hoc_thi
                check = 0
            End If
            Return check
        End Function
#End Region

        Function Diem_So_max_KyNam(ByVal mHoc_ky As Integer, ByVal mNam_hoc As String) As Double
            Dim DiemMax As Double = -1
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = mHoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = mNam_hoc) Then
                    If CType(mDiemThi(i), ESSDiemThi).Diem_so > DiemMax Then
                        DiemMax = CType(mDiemThi(i), ESSDiemThi).Diem_so
                    End If
                End If
            Next
            Return DiemMax
        End Function

        Public Function Diem_chu_max_KyNam(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim DiemMin As String = "Z"
            For i As Integer = 0 To mDiemThi.Count - 1
                If (CType(mDiemThi(i), ESSDiemThi).Hoc_ky_thi = Hoc_ky And CType(mDiemThi(i), ESSDiemThi).Nam_hoc_thi = Nam_hoc) Then
                    If CType(mDiemThi(i), ESSDiemThi).Diem_chu <> "" And CType(mDiemThi(i), ESSDiemThi).Diem_chu < DiemMin Then
                        DiemMin = CType(mDiemThi(i), ESSDiemThi).Diem_chu
                    End If
                End If
            Next
            If DiemMin = "Z" Then
                Return ""
            Else
                Return DiemMin
            End If
        End Function
    End Class
End Namespace
