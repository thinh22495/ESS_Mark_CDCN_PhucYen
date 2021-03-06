'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.DirectoryServices
Imports ESS.Objects
Imports ESS.DataAccess
'Imports ESSUtility

Namespace Bussines
    Public Class Users_Bussines
#Region "Variable"
        Private aUsers As ArrayList
#End Region

#Region "Initialize"
        Public Sub New()

        End Sub
        Public Sub New(ByVal UserID As Integer, ByVal ID_Khoa As Integer, ByVal ID_Bomon As Integer, ByVal ID_Phong As Integer)
            Try
                aUsers = New ArrayList
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim objVaitro As VaiTro_DataAccess = New VaiTro_DataAccess
                Dim dt1 As DataTable = obj.HienThi_ESSUsers_DanhSach(UserID, ID_Khoa, ID_Bomon, ID_Phong)
                If dt1.Rows.Count > 0 Then
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        Dim objUsers As New ESSUsers
                        objUsers = Mapping(dt1.Rows(i))
                        'Load quyền truy cập các lớp của User
                        Dim dtLop As DataTable = obj.HienThi_ESSUsersHeAccess_DanhSach(objUsers.UserID)
                        Dim dr1 As DataRow
                        For Each dr1 In dtLop.Rows
                            'Add He, ESSKhoa, Khoá, ngành, chuyên ngành truy cap cua User
                            Dim usersaccesshe As ESSUsersHeAcess = MappingUsersHeAcess(dr1)
                            objUsers.HeAccess.Add(usersaccesshe)
                        Next
                        'Load vai tro User vào danh sách
                        Dim dtVaiTro As DataTable = objVaitro.HienThi_ESSVaiTro_DanhSach(objUsers.UserID)
                        For Each dr1 In dtVaiTro.Rows
                            Dim gobjVaitro As New ESSVaiTro
                            gobjVaitro.ID_vai_tro = dr1("ID_vai_tro")
                            gobjVaitro.Ten_vai_tro = dr1("Ten_vai_tro")
                            gobjVaitro.Mo_ta = dr1("Mo_ta")
                            'Add vai tro cua User
                            objUsers.ESSVaiTro.Add(gobjVaitro)
                        Next
                        aUsers.Add(objUsers)
                    Next
                End If
            Catch ex As Exception
                Throw (ex)
            End Try

        End Sub
        Public Sub New(ByVal ID_ph As Integer, ByVal UserName As String)
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim objVaitro As VaiTro_DataAccess = New VaiTro_DataAccess
                Dim objUsers As New ESSUsers
                Dim n As Integer = 0, Exits As Boolean = False
                Dim dt As DataTable = obj.HienThi_ESSUsers(UserName)
                Dim dr As DataRow
                If dt.Rows.Count > 0 Then
                    objUsers = Mapping(dt.Rows(0))
                    'Load quyền truy cập các chức năng của User
                    Dim dtQuyen As DataTable = obj.HienThi_ESSUsersQuyen_DanhSach(ID_ph, objUsers.UserID)
                    For Each dr In dtQuyen.Rows
                        If n > 0 Then
                            For i As Integer = 0 To n - 1
                                If dr("ID_Quyen") = objUsers.ESSQuyen.Quyen(i).ID_quyen Then
                                    Exits = True
                                End If
                            Next
                        End If

                        If Not Exits Then
                            Dim objQuyen As New ESSUsersQuyen
                            objQuyen.ID_ph = dr("ID_ph")
                            objQuyen.Phan_he = dr("Phan_he")
                            objQuyen.ID_quyen = dr("ID_quyen")
                            objQuyen.ID_nhom_quyen = dr("ID_nhom_quyen")
                            objQuyen.Ten_quyen = dr("Ten_quyen")
                            objQuyen.Them = dr("Them")
                            objQuyen.Sua = dr("Sua")
                            objQuyen.Xoa = dr("Xoa")
                            'Add Quyen cua User
                            objUsers.ESSQuyen.Add(objQuyen)
                            n += 1
                        End If
                        Exits = False

                    Next
                    'Load quyền truy cập den cac He, ESSKhoa, Khoá, ngành, chuyên ngành của User
                    Dim dtHe As DataTable = obj.HienThi_ESSUsersHeAccess_DanhSach(objUsers.UserID)
                    For Each dr In dtHe.Rows
                        'Add He, ESSKhoa, Khoá, ngành, chuyên ngành truy cap cua User
                        Dim UsersHeAccess As ESSUsersHeAcess = MappingUsersHeAcess(dr)
                        objUsers.HeAccess.Add(UsersHeAccess)
                        'Add các lớp được truy cập
                        Dim dtLop As DataTable = obj.HienThi_ESSUsersLopAccess_DanhSach(UsersHeAccess.ID_he, UsersHeAccess.ID_khoa, UsersHeAccess.Khoa_hoc, UsersHeAccess.ID_nganh, UsersHeAccess.ID_chuyen_nganh)
                        For i As Integer = 0 To dtLop.Rows.Count - 1
                            objUsers.LopAaccess.Add(dtLop.Rows(i)("ID_lop"))
                            objUsers.dsID_lop += "," + dtLop.Rows(i)("ID_lop").ToString
                            If Not objUsers.dsID_dt.Contains("," + dtLop.Rows(i)("ID_dt").ToString + ",") Then
                                objUsers.dsID_dt += "," + dtLop.Rows(i)("ID_dt").ToString
                            End If
                        Next
                    Next
                    'Load vai tro User vào danh sách
                    Dim dtVaiTro As DataTable = objVaitro.HienThi_ESSVaiTro_DanhSach(objUsers.UserID)
                    For Each dr In dtVaiTro.Rows
                        Dim gobjVaitro As New ESSVaiTro
                        gobjVaitro.ID_vai_tro = dr("ID_vai_tro")
                        gobjVaitro.Ten_vai_tro = dr("Ten_vai_tro")
                        gobjVaitro.Mo_ta = dr("Mo_ta")
                        Dim dtVaiTroQuyen As DataTable = obj.HienThi_ESSVaiTroQuyen(gobjVaitro.ID_vai_tro)
                        For i As Integer = 0 To dtVaiTroQuyen.Rows.Count - 1
                            Dim aVaiTroQuyen As New ESSVaiTroQuyen
                            aVaiTroQuyen.ID_ph = dtVaiTroQuyen.Rows(i)("ID_ph")
                            aVaiTroQuyen.ID_quyen = dtVaiTroQuyen.Rows(i)("ID_quyen")
                            aVaiTroQuyen.Ten_quyen = dtVaiTroQuyen.Rows(i)("Ten_quyen")
                            aVaiTroQuyen.Sua = dtVaiTroQuyen.Rows(i)("Sua")
                            aVaiTroQuyen.Them = dtVaiTroQuyen.Rows(i)("Them")
                            aVaiTroQuyen.Xoa = dtVaiTroQuyen.Rows(i)("Xoa")
                            gobjVaitro.ESSVaiTroQuyen.Add(aVaiTroQuyen)
                        Next
                        'Add vai tro cua User
                        objUsers.ESSVaiTro.Add(gobjVaitro)
                    Next
                End If
                'Add đối tượng User vào danh sách
                aUsers = New ArrayList
                aUsers.Add(objUsers)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Add(ByVal users As ESSUsers)
            aUsers.Add(users)
        End Sub
        Public Sub Remove(ByVal idx_User As Integer)
            aUsers.RemoveAt(idx_User)
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub ChangePassword(ByVal UserID As Integer, ByVal NewPassword As String)
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim Password As String
                Password = XCrypto.MD5(NewPassword)
                obj.ChangePassword(UserID, Password)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function HienThi_ESSUsersQuyen_DanhSach() As DataTable
            Try
                Dim objUsers As New ESSUsers
                objUsers = Users(0)
                Dim dt As DataTable = New DataTable
                Dim i As Integer
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("ID_Quyen", GetType(Integer))
                dt.Columns.Add("Ten_Quyen", GetType(String))
                dt.Columns.Add("Them", GetType(Boolean))
                dt.Columns.Add("Sua", GetType(Boolean))
                dt.Columns.Add("Xoa", GetType(Boolean))
                For i = 0 To objUsers.ESSQuyen.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_ph") = objUsers.ESSQuyen.Quyen(i).ID_ph
                    row("ID_Quyen") = objUsers.ESSQuyen.Quyen(i).ID_quyen
                    row("Ten_Quyen") = objUsers.ESSQuyen.Quyen(i).Ten_quyen
                    row("Them") = objUsers.ESSQuyen.Quyen(i).Them
                    row("Sua") = objUsers.ESSQuyen.Quyen(i).Sua
                    row("Xoa") = objUsers.ESSQuyen.Quyen(i).Xoa

                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSUsers() As DataTable
            Try
                Dim dt As New DataTable
                Dim dr As DataRow = Nothing
                dt.Columns.Add("UserID", GetType(Integer))
                dt.Columns.Add("UserName", GetType(String))
                dt.Columns.Add("PassWord", GetType(String))
                dt.Columns.Add("FullName", GetType(String))
                dt.Columns.Add("UserGroup", GetType(Integer))
                dt.Columns.Add("GroupName", GetType(String))
                dt.Columns.Add("ID_Phong", GetType(Integer))
                dt.Columns.Add("Phong_Ban", GetType(String))
                dt.Columns.Add("ID_khoa", GetType(Integer))
                dt.Columns.Add("ID_Bomon", GetType(Integer))
                dt.Columns.Add("Active", GetType(String))
                dt.Columns.Add("May_tram", GetType(String))
                dt.Columns.Add("UserNameLDAP", GetType(String))
                dt.Columns.Add("adsPathLDAP", GetType(String))
                'Dim dr1 As DataRow
                For i As Integer = 0 To aUsers.Count - 1
                    Dim users As ESSUsers = CType(aUsers(i), ESSUsers)
                    Dim row As DataRow = dt.NewRow()
                    row("UserID") = users.UserID
                    row("UserName") = users.UserName
                    row("PassWord") = users.PassWord
                    row("FullName") = users.FullName
                    row("UserGroup") = users.UserGroup
                    row("ID_Phong") = users.ID_phong
                    row("Phong_Ban") = users.Phong_ban
                    row("GroupName") = HienThi_ESSUserGroup(users.UserGroup)
                    row("ID_khoa") = users.ID_khoa
                    row("ID_Bomon") = users.ID_Bomon
                    row("Active") = CovertingIntToStr(users.Active)
                    row("May_tram") = users.May_tram
                    row("UserNameLDAP") = users.UserNameLDAP
                    row("adsPathLDAP") = users.adsPathLDAP
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhanHeQuyen_DanhSach(ByVal ID_ph As Integer) As DataTable
            Try
                Dim dt As DataTable = New DataTable
                Dim i As Integer
                Dim dr As DataRow = Nothing
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("ID_Quyen", GetType(Integer))
                dt.Columns.Add("Ten_Quyen", GetType(String))
                dt.Columns.Add("Them", GetType(Boolean))
                dt.Columns.Add("Sua", GetType(Boolean))
                dt.Columns.Add("Xoa", GetType(Boolean))
                For i = 0 To aUsers.Count - 1
                    Dim users As ESSUsers = CType(aUsers(i), ESSUsers)
                    Dim row As DataRow = dt.NewRow()
                    If users.ESSQuyen.ID_ph = ID_ph Then
                        row("Chon") = False
                        row("ID_ph") = users.ESSQuyen.ID_ph
                        row("ID_Quyen") = users.ESSQuyen.ID_quyen
                        row("Ten_Quyen") = users.ESSQuyen.Ten_quyen
                        row("Them") = False
                        row("Sua") = False
                        row("Xoa") = False
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSVaiTro(ByVal user As ESSUsers) As DataTable
            Try
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_vai_tro", GetType(Integer))
                dt.Columns.Add("Ten_vai_tro", GetType(String))
                dt.Columns.Add("Mo_ta", GetType(String))
                For i As Integer = 0 To user.ESSVaiTro.Count - 1
                    Dim Vai_Tro As ESSVaiTro = CType(user.ESSVaiTro.ESSVaiTro(i), ESSVaiTro)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_vai_tro") = Vai_Tro.ID_vai_tro
                    row("Ten_vai_tro") = Vai_Tro.Ten_vai_tro
                    row("Mo_ta") = Vai_Tro.Mo_ta
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSVaiTro(ByVal user As ESSUsers, ByVal dtVaiTroGan As DataTable) As DataTable
            Try
                Dim Exits As Boolean = False
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_vai_tro", GetType(Integer))
                dt.Columns.Add("Ten_vai_tro", GetType(String))
                dt.Columns.Add("Mo_ta", GetType(String))
                If dtVaiTroGan.Rows.Count > 0 Then
                    For i As Integer = 0 To user.ESSVaiTro.Count - 1
                        Dim Vai_Tro As ESSVaiTro = CType(user.ESSVaiTro.ESSVaiTro(i), ESSVaiTro)
                        For j As Integer = 0 To dtVaiTroGan.Rows.Count - 1
                            If Vai_Tro.ID_vai_tro = dtVaiTroGan.Rows(j)("ID_vai_tro") Then
                                Exits = True
                                Exit For
                            End If
                        Next
                        If Not Exits Then
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_vai_tro") = Vai_Tro.ID_vai_tro
                            row("Ten_vai_tro") = Vai_Tro.Ten_vai_tro
                            row("Mo_ta") = Vai_Tro.Mo_ta
                            dt.Rows.Add(row)
                        End If
                        Exits = False
                    Next
                Else
                    For i As Integer = 0 To user.ESSVaiTro.Count - 1
                        Dim Vai_Tro As ESSVaiTro = CType(user.ESSVaiTro.ESSVaiTro(i), ESSVaiTro)
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_vai_tro") = Vai_Tro.ID_vai_tro
                        row("Ten_vai_tro") = Vai_Tro.Ten_vai_tro
                        row("Mo_ta") = Vai_Tro.Mo_ta
                        dt.Rows.Add(row)
                    Next
                End If
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSVaiTroGan(ByVal UserName As String) As DataTable
            Try
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_vai_tro", GetType(Integer))
                dt.Columns.Add("Ten_vai_tro", GetType(String))
                dt.Columns.Add("Mo_ta", GetType(String))
                Dim user As ESSUsers
                For i As Integer = 0 To aUsers.Count - 1
                    If CType(aUsers(i), ESSUsers).UserName = UserName Then user = CType(aUsers(i), ESSUsers)
                Next
                For i As Integer = 0 To user.ESSVaiTro.Count - 1
                    Dim Vai_Tro As ESSVaiTro = CType(user.ESSVaiTro.ESSVaiTro(i), ESSVaiTro)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_vai_tro") = Vai_Tro.ID_vai_tro
                    row("Ten_vai_tro") = Vai_Tro.Ten_vai_tro
                    row("Mo_ta") = Vai_Tro.Mo_ta
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSUsersLopAccess(ByVal User As ESSUsers) As DataTable
            Try
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("ID_Khoa", GetType(Integer))
                dt.Columns.Add("Ten_Khoa", GetType(String))
                dt.Columns.Add("Khoa_hoc", GetType(String))
                dt.Columns.Add("ID_Chuyen_nganh", GetType(Integer))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("ID_nganh", GetType(Integer))
                dt.Columns.Add("Ten_nganh", GetType(String))
                'Dim user As ESSUsers = CType(aUsers(idx_User), ESSUsers)
                For i As Integer = 0 To User.HeAccess.Count - 1
                    Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_he") = UsersLop.ID_he
                    row("Ten_he") = UsersLop.Ten_he
                    row("ID_Khoa") = UsersLop.ID_khoa
                    row("Ten_Khoa") = UsersLop.Ten_khoa
                    row("Khoa_hoc") = UsersLop.Khoa_hoc
                    row("ID_Chuyen_nganh") = UsersLop.ID_chuyen_nganh
                    row("Chuyen_nganh") = UsersLop.Chuyen_nganh
                    row("ID_nganh") = UsersLop.ID_nganh
                    row("Ten_nganh") = UsersLop.Ten_nganh
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSUsersHeAccessGan(ByVal UserName As String) As DataTable
            Try
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("ID_Khoa", GetType(Integer))
                dt.Columns.Add("Ten_Khoa", GetType(String))
                dt.Columns.Add("Khoa_hoc", GetType(String))
                dt.Columns.Add("ID_Chuyen_nganh", GetType(Integer))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("ID_nganh", GetType(Integer))
                dt.Columns.Add("Ten_nganh", GetType(String))
                Dim user As ESSUsers = Tim_UserName(UserName)
                For i As Integer = 0 To user.HeAccess.Count - 1
                    Dim UsersLop As ESSUsersHeAcess = CType(user.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                    Dim row As DataRow = dt.NewRow()
                    row("ID_he") = UsersLop.ID_he
                    row("Ten_he") = UsersLop.Ten_he
                    row("ID_Khoa") = UsersLop.ID_khoa
                    row("Ten_Khoa") = UsersLop.Ten_khoa
                    row("Khoa_hoc") = UsersLop.Khoa_hoc
                    row("ID_Chuyen_nganh") = UsersLop.ID_chuyen_nganh
                    row("Chuyen_nganh") = UsersLop.Chuyen_nganh
                    row("ID_nganh") = UsersLop.ID_nganh
                    row("Ten_nganh") = UsersLop.Ten_nganh
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function

        Public Function HienThi_ESSPhong_DanhSach(ByVal User As ESSUsers) As DataTable
            Try
              
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_Phong", GetType(Integer))
                dt.Columns.Add("Phong", GetType(String))
                If User.UserGroup = -1 Then
                    Dim dtPhong As DataTable = obj.HienThi_ESSPhong_DanhSach()
                    For i As Integer = 0 To dtPhong.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Phong") = dtPhong.Rows(i)("ID_Phong")
                        row("Phong") = dtPhong.Rows(i)("Phong")
                        dt.Rows.Add(row)
                    Next
                Else
                    'For i As Integer = 0 To User.HeAccess.Count - 1
                    Dim users As ESSUsers = CType(User, ESSUsers)
                    If users.ID_phong > 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_phong") = User.ID_phong
                        row("Phong") = User.Phong_ban
                        dt.Rows.Add(row)
                    End If

                    ' Next
                End If
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try

        End Function
        ''Load các khoa
        Public Function HienThi_ESSKhoa_DanhSach(ByVal User As ESSUsers) As DataTable
            Try
                ' Dim obj As Users_DataAccess = New Users_DataAccess
                ' Return obj.HienThi_ESSPhong_DanhSach()
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_Khoa", GetType(Integer))
                dt.Columns.Add("Ten_Khoa", GetType(String))
                If User.UserGroup = -1 Then
                    Dim dtKhoa As DataTable = obj.HienThi_ESSKhoa_DanhSach()
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Khoa") = dtKhoa.Rows(i)("ID_Phong")
                        row("Ten_Khoa") = dtKhoa.Rows(i)("Phong")
                        dt.Rows.Add(row)
                    Next
                Else
                    ' For i As Integer = 0 To User.HeAccess.Count - 1
                    Dim users As ESSUsers = CType(User, ESSUsers)
                    If users.ID_khoa > 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Khoa") = User.ID_khoa
                        row("Ten_Khoa") = User.Phong_ban
                        dt.Rows.Add(row)
                    End If

                    ' Next
                End If
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        
        End Function
        Public Function HienThi_ESSBomon_DanhSach(ByVal User As ESSUsers) As DataTable
            Try
   
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_bm", GetType(Integer))
                dt.Columns.Add("Bo_mon", GetType(String))
                If User.UserGroup = -1 Then
                    Dim dtBo_mon As DataTable = obj.HienThi_ESSBomon_DanhSach()
                    For i As Integer = 0 To dtBo_mon.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_bm") = dtBo_mon.Rows(i)("ID_bm")
                        row("Bo_mon") = dtBo_mon.Rows(i)("Bo_mon")
                        dt.Rows.Add(row)
                    Next
                Else
                    Dim users As ESSUsers = CType(User, ESSUsers)
                    If users.ID_Bomon > 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_bm") = User.ID_Bomon
                        row("Bo_mon") = User.Phong_ban
                        dt.Rows.Add(row)
                    End If

                    ' Next
                End If
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSUsersHe(ByVal User As ESSUsers) As DataTable
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ten_he", GetType(String))
                If User.UserGroup = -1 Then
                    Dim dtHe As DataTable = obj.HienThi_ESSHe_DanhSach()
                    For i As Integer = 0 To dtHe.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_he") = dtHe.Rows(i)("ID_he")
                        row("Ten_he") = dtHe.Rows(i)("Ten_he")
                        dt.Rows.Add(row)
                    Next
                Else
                    For i As Integer = 0 To User.HeAccess.Count - 1
                        Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                        Dim row As DataRow = dt.NewRow()
                        row("ID_he") = UsersLop.ID_he
                        row("Ten_he") = UsersLop.Ten_he
                        dt.Rows.Add(row)
                    Next
                End If

                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSUsersKhoa(ByVal User As ESSUsers) As DataTable
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_Khoa", GetType(Integer))
                dt.Columns.Add("Ten_Khoa", GetType(String))
                If User.UserGroup = -1 Then
                    Dim dtKhoa As DataTable = obj.HienThi_ESSKhoa_DanhSach()
                    For i As Integer = 0 To dtKhoa.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Khoa") = dtKhoa.Rows(i)("ID_Khoa")
                        row("Ten_Khoa") = dtKhoa.Rows(i)("Ten_Khoa")
                        dt.Rows.Add(row)
                    Next
                Else
                    For i As Integer = 0 To User.HeAccess.Count - 1
                        Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Khoa") = UsersLop.ID_khoa
                        row("Ten_Khoa") = UsersLop.Ten_khoa
                        dt.Rows.Add(row)

                    Next
                End If

                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSUsersNganh(ByVal User As ESSUsers) As DataTable
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_nganh", GetType(Integer))
                dt.Columns.Add("Ten_nganh", GetType(String))
                If User.UserGroup = -1 Then
                    Dim dtNganh As DataTable = obj.HienThi_ESSNganh_DanhSach
                    For i As Integer = 0 To dtNganh.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_nganh") = dtNganh.Rows(i)("ID_nganh")
                        row("Ten_nganh") = dtNganh.Rows(i)("Ten_nganh")
                        dt.Rows.Add(row)
                    Next
                Else
                    For i As Integer = 0 To User.HeAccess.Count - 1
                        Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                        Dim row As DataRow = dt.NewRow()
                        row("ID_nganh") = UsersLop.ID_nganh
                        row("Ten_nganh") = UsersLop.Ten_nganh
                        dt.Rows.Add(row)
                    Next
                End If

                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        Public Function HienThi_ESSUsersChuyenNganh(ByVal User As ESSUsers) As DataTable
            Try

                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_Chuyen_nganh", GetType(Integer))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                If User.UserGroup = -1 Then
                    Dim obj As Users_DataAccess = New Users_DataAccess
                    Dim dtChuyenNganh As DataTable = obj.HienThi_ESSChuyenNganh_DanhSach
                    For i As Integer = 0 To dtChuyenNganh.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Chuyen_nganh") = dtChuyenNganh.Rows(i)("ID_Chuyen_nganh")
                        row("Chuyen_nganh") = dtChuyenNganh.Rows(i)("Chuyen_nganh")
                        dt.Rows.Add(row)
                    Next
                Else
                    For i As Integer = 0 To User.HeAccess.Count - 1
                        Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                        Dim row As DataRow = dt.NewRow()
                        row("ID_Chuyen_nganh") = UsersLop.ID_chuyen_nganh
                        row("Chuyen_nganh") = UsersLop.Chuyen_nganh
                        dt.Rows.Add(row)
                    Next
                End If

                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        ''Load khóa học
        Public Function HienThi_ESSUsersKhoa_hoc(ByVal User As ESSUsers) As DataTable
            Try

                Dim dt As DataTable = New DataTable
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                If User.UserGroup = -1 Then
                    Dim obj As Users_DataAccess = New Users_DataAccess
                    Dim dtKhoaHoc As DataTable = obj.HienThi_ESSKhoaHoc_DanhSach
                    For i As Integer = 0 To dtKhoaHoc.Rows.Count - 1
                        Dim row As DataRow = dt.NewRow()
                        row("Khoa_hoc") = dtKhoaHoc.Rows(i)("Khoa_hoc")
                        dt.Rows.Add(row)
                    Next
                Else
                    For i As Integer = 0 To User.HeAccess.Count - 1
                        Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                        Dim row As DataRow = dt.NewRow()
                        row("Khoa_hoc") = UsersLop.Khoa_hoc
                        dt.Rows.Add(row)
                    Next
                End If

                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        ''Load chuyen nganh theo 1 nganh
        Public Function HienThi_ESSUsersChuyenNganh(ByVal User As ESSUsers, ByVal ID_nganh As Integer) As DataTable
            Try
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("ID_Chuyen_nganh", GetType(Integer))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                If User.UserGroup = -1 Then
                    Dim obj As Users_DataAccess = New Users_DataAccess
                    Dim dtChuyenNganh As DataTable = obj.HienThi_ESSChuyenNganh_DanhSach
                    For i As Integer = 0 To dtChuyenNganh.Rows.Count - 1
                        If dtChuyenNganh.Rows(i)("ID_nganh") = ID_nganh Then
                            Dim row As DataRow = dt.NewRow()
                            row("ID_Chuyen_nganh") = dtChuyenNganh.Rows(i)("ID_Chuyen_nganh")
                            row("Chuyen_nganh") = dtChuyenNganh.Rows(i)("Chuyen_nganh")
                            dt.Rows.Add(row)
                        End If

                    Next
                Else
                    For i As Integer = 0 To User.HeAccess.Count - 1
                        Dim UsersLop As ESSUsersHeAcess = CType(User.HeAccess.ESSUsersHeAcess(i), ESSUsersHeAcess)
                        If User.HeAccess.ESSUsersHeAcess(i).ID_nganh = ID_nganh Then
                            Dim row As DataRow = dt.NewRow()
                            row("ID_Chuyen_nganh") = UsersLop.ID_chuyen_nganh
                            row("Chuyen_nganh") = UsersLop.Chuyen_nganh
                            dt.Rows.Add(row)
                        End If

                    Next
                End If
                Return dt
            Catch ex As Exception
                Throw (ex)
            End Try
        End Function
        ''Tim User trong mảng Users
        Public Function Tim_User1(ByVal idx_user As Integer) As ESSUsers
            For i As Integer = 0 To aUsers.Count - 1
                If i = idx_user Then
                    Return CType(aUsers(i), ESSUsers)
                End If
            Next
            Return Nothing
        End Function
        Public Function Tim_UserName(ByVal UserName As String) As ESSUsers
            For i As Integer = 0 To aUsers.Count - 1
                If CType(aUsers(i), ESSUsers).UserName = UserName Then
                    Return CType(aUsers(i), ESSUsers)
                End If
            Next
            Return Nothing
        End Function
        '' Thêm mới 1 User
        Public Function ThemMoi_ESSUsers(ByVal objUsers As ESSUsers) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.ThemMoi_ESSUsers(objUsers)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Thêm mới vai trò cho User
        Public Function ThemMoi_ESSUserVaiTro(ByVal UserName As String) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim objUser As New ESSUsers
                For i As Integer = 0 To aUsers.Count - 1
                    if CType(aUsers(i), ESSUsers).UserName=UserName then  objUser = CType(aUsers(i), ESSUsers)
                Next
                For i As Integer = 0 To objUser.ESSVaiTro.Count - 1
                    obj.ThemMoi_ESSUserVaiTro(objUser.ESSVaiTro.ESSVaiTro(i), objUser.UserID)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Thay đổi thông tin của 1 User
        Public Function CapNhat_ESSUsers(ByVal objUsers As ESSUsers, ByVal UserID As Integer) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.CapNhat_ESSUsers(objUsers, UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Thêm lớp mới cho User
        Public Function ThemMoi_ESSUsersLopAccess111(ByVal UserName As String) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim objUser As New ESSUsers
                objUser = Tim_UserName(UserName)
                For i As Integer = 0 To objUser.HeAccess.Count - 1
                    obj.ThemMoi_ESSUsersAccessHe(objUser.HeAccess.ESSUsersHeAcess(i), objUser.UserID)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSUsersHeAccess(ByVal UserName As String) As Integer
            Try

                Dim obj As Users_DataAccess = New Users_DataAccess
                Dim objUser As New ESSUsers
                objUser = Tim_UserName(UserName)
                For i As Integer = 0 To objUser.HeAccess.Count - 1
                    obj.ThemMoi_ESSUsersAccessHe(objUser.HeAccess.ESSUsersHeAcess(i), objUser.UserID)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Xóa 1 lớp của User
        Public Function Xoa_ESSUsersLopAccess(ByVal UserID As Integer) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.Xoa_ESSUsersAccessHe(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSUsersHeAccess(ByVal UserID As Integer) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.Xoa_ESSUsersAccessHe(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Xóa 1 User
        Public Function Xoa_ESSUsers(ByVal UserID As Integer) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.Xoa_ESSUsers(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Xóa 1 vai trò của User
        Public Function Xoa_ESSUserVaiTro(ByVal UserID As Integer) As Integer
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.Xoa_ESSUserVaiTro(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Kiểm tra xem UserName đó đã có hay chưa?
        Public Function CheckExist_Users(ByVal UserName As String, ByVal UserID As Integer) As Boolean
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.CheckExist_Users(UserName, UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Kiểm tra xem User đó đã được gán vai trò chưa?
        Public Function KiemTra_UserVaiTro(ByVal UserID As Integer) As Boolean
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.KiemTra_UsersVaiTro(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Kiểm tra xem User đó đã được gán lớp chưa?
        Public Function KiemTra_UserLop(ByVal UserID As Integer) As Boolean
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.KiemTra_UsersAccessHe(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Kiểm tra xem lớp đó đã có chưa?
        Public Function KiemTra_UserLopAccess1(ByVal UserLop As ESSUsersHeAcess, ByVal UserName As String) As Boolean
            Try
                Dim user As ESSUsers = Tim_UserName(UserName)
                Dim i As Integer = 0
                For i = 0 To user.HeAccess.Count - 1
                    If user.HeAccess.ESSUsersHeAcess(i).ID_he = UserLop.ID_he And user.HeAccess.ESSUsersHeAcess(i).ID_khoa = UserLop.ID_khoa And user.HeAccess.ESSUsersHeAcess(i).Khoa_hoc = UserLop.Khoa_hoc And user.HeAccess.ESSUsersHeAcess(i).ID_nganh = UserLop.ID_nganh And user.HeAccess.ESSUsersHeAcess(i).ID_chuyen_nganh = UserLop.ID_chuyen_nganh Then
                        Return True
                    End If

                Next
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_UserHeAccess1(ByVal UserHe As ESSUsersHeAcess, ByVal UserName As String) As Boolean
            Try
                Dim user As ESSUsers = Tim_UserName(UserName)
                Dim i As Integer = 0
                For i = 0 To user.HeAccess.Count - 1
                    If user.HeAccess.ESSUsersHeAcess(i).ID_he = UserHe.ID_he And user.HeAccess.ESSUsersHeAcess(i).ID_khoa = UserHe.ID_khoa And user.HeAccess.ESSUsersHeAcess(i).Khoa_hoc = UserHe.Khoa_hoc And user.HeAccess.ESSUsersHeAcess(i).ID_nganh = UserHe.ID_nganh And user.HeAccess.ESSUsersHeAcess(i).ID_chuyen_nganh = UserHe.ID_chuyen_nganh Then
                        Return True
                    End If

                Next
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_Users(ByVal UserName As String) As Boolean
            Try
                Dim obj As Users_DataAccess = New Users_DataAccess
                Return obj.CheckExist_Users(UserName)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Hàm convert
        Public Function Mapping(ByVal drUsers As DataRow) As ESSUsers
            Dim result As ESSUsers
            Try
                result = New ESSUsers
                If drUsers("UserID").ToString() <> "" Then result.UserID = CType(drUsers("UserID").ToString(), Integer)
                result.UserName = drUsers("UserName").ToString()
                result.PassWord = drUsers("PassWord").ToString()
                result.FullName = drUsers("FullName").ToString()
                If drUsers("UserGroup").ToString() <> "" Then result.UserGroup = CType(drUsers("UserGroup").ToString(), Integer)
                If drUsers("ID_phong").ToString() <> "" Then result.ID_phong = CType(drUsers("ID_phong").ToString(), Integer)
                If drUsers("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drUsers("ID_khoa").ToString(), Integer)
                If drUsers("ID_Bomon").ToString() <> "" Then result.ID_Bomon = CType(drUsers("ID_Bomon").ToString(), Integer)
                If drUsers("Active").ToString() <> "" Then result.Active = CType(drUsers("Active").ToString(), Integer)
                result.May_tram = drUsers("May_tram").ToString()
                result.UserNameLDAP = drUsers("UserNameLDAP").ToString()
                result.adsPathLDAP = drUsers("adsPathLDAP").ToString()
                result.Dien_thoai = drUsers("Dien_thoai").ToString()
                result.Email = drUsers("Email").ToString()
                result.Phong_ban = CType(drUsers("Phong").ToString() + drUsers("Ten_khoa").ToString() + drUsers("Bo_mon").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingUsersHeAcess(ByVal drUsersAccessHe As DataRow) As ESSUsersHeAcess
            Dim result As ESSUsersHeAcess
            Try
                result = New ESSUsersHeAcess
                If drUsersAccessHe("ID_he").ToString() <> "" Then result.ID_he = CType(drUsersAccessHe("ID_he").ToString(), Integer)
                If drUsersAccessHe("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drUsersAccessHe("ID_khoa").ToString(), Integer)
                If drUsersAccessHe("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drUsersAccessHe("Khoa_hoc").ToString(), Integer)
                If drUsersAccessHe("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drUsersAccessHe("ID_nganh").ToString(), Integer)
                If drUsersAccessHe("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drUsersAccessHe("ID_chuyen_nganh").ToString(), Integer)
                result.Ten_he = drUsersAccessHe("Ten_he").ToString()
                result.Ten_khoa = drUsersAccessHe("Ten_khoa").ToString()
                result.Ten_nganh = drUsersAccessHe("Ten_nganh").ToString()
                result.Chuyen_nganh = drUsersAccessHe("Chuyen_nganh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Public Function CheckUser(ByVal ldapCheck As Boolean, ByVal objUser As ESSUsers, ByVal Password As String) As Boolean
            Try
                If ldapCheck Then
                    'Kiểm tra mật khẩu trong LDAP
                    If CheckUserLDAP(objUser.adsPathLDAP, objUser.UserNameLDAP, objUser.PassWord) Then Return True
                Else
                    Password = XCrypto.MD5(Password)
                    'Kiểm tra mật khẩu nhập vào có đúng không
                    If Password = objUser.PassWord Then Return True
                End If
                Return False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Private Function CheckUserLDAP(ByVal adsPath As String, ByVal UserName As String, ByVal PassWord As String) As Boolean
            Dim oSearcher As New DirectorySearcher
            Dim oResult As SearchResult
            Try
                With oSearcher
                    .SearchRoot = New DirectoryEntry(adsPath, UserName, PassWord, AuthenticationTypes.Secure)
                    oResult = .FindOne
                End With
                If Not oResult Is Nothing Then
                    Return True
                Else
                    Return False
                End If
            Catch e As Exception
                Return False
            End Try
        End Function
        Private Function HienThi_ESSUserGroup(ByVal UserGroupID As Integer) As String
            Dim str As String = ""
            Select Case UserGroupID
                Case 0
                    str = "Lãnh Đạo"
                Case 1
                    str = "Chuyên Viên"
                Case 2
                    str = "Cố vấn học tập"
                Case -1
                    str = "Quản trị hệ thống"
            End Select
            Return str
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.aUsers.Count
            End Get
        End Property
        Public Property Users(ByVal idx As Integer) As ESSUsers
            Get
                Return CType(Me.aUsers(idx), ESSUsers)
            End Get
            Set(ByVal Value As ESSUsers)
                Me.aUsers(idx) = Value
            End Set
        End Property
        '' Covert Từ Boolean sang Integer
        Public Function CovertingBoolToInt(ByVal Int As Boolean) As Integer
            If Int Then
                Return 1
            Else
                Return 0
            End If
        End Function
        '' Mapping từ Integer sang Boolean
        Private Function CovertingIntToStr(ByVal Int As Integer) As String
            Dim str As String = ""
            If Int = 1 Then
                str = "Kích Hoạt"
            ElseIf Int = 0 Then
                str = "Không Kích Hoạt"
            End If
            Return str
        End Function
        Public Function CheckMyComputer(ByVal UserIP As Integer, ByVal IP As String, ByVal MAC As String) As Boolean
            Dim obj As Users_DataAccess = New Users_DataAccess
            If obj.KiemTra_IP(UserIP, IP) And obj.KiemTra_Mac(UserIP, MAC) Then
                Return True
            Else
                Return False
            End If
        End Function
#End Region
    End Class
End Namespace
