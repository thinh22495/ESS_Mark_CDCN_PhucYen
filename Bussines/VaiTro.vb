'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/21/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class VaiTro_Bussines
#Region "Variable"
        Public aVaiTro As ArrayList
#End Region
#Region "Initialize"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_vai_tro As Integer)
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSVaiTroQuyen(ID_vai_tro)
                Dim objsVaiTro As New ESSVaiTro
                Dim dr As DataRow = Nothing
                If dt.Rows.Count > 0 Then
                    objsVaiTro = Mapping(dt.Rows(0))
                    For Each dr In dt.Rows
                        Dim objVaitroQuyen As New ESSVaiTroQuyen
                        objVaitroQuyen.ID_ph = dr("ID_ph")
                        objVaitroQuyen.ID_quyen = dr("ID_quyen")
                        objVaitroQuyen.ID_nhom_quyen = dr("ID_nhom_quyen")
                        objVaitroQuyen.Ten_quyen = dr("Ten_quyen")
                        objVaitroQuyen.Them = dr("Them")
                        objVaitroQuyen.Sua = dr("Sua")
                        objVaitroQuyen.Xoa = dr("Xoa")
                        'Add Quyen cua VaiTro
                        objsVaiTro.ESSVaiTroQuyen.Add(objVaitroQuyen)
                    Next
                End If
                'Add đối tượng VaiTro vào danh sách
                aVaiTro = New ArrayList
                aVaiTro.Add(objsVaiTro)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        ''Load các quyền đã được gán cho vai trò
        Public Function HienThi_ESSVaiTroQuyenGan_DanhSach() As DataTable
            Try
                Dim dt As DataTable = New DataTable
                Dim i As Integer, j As Integer
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("ID_Quyen", GetType(Integer))
                dt.Columns.Add("Ten_Quyen", GetType(String))
                dt.Columns.Add("Them", GetType(Boolean))
                dt.Columns.Add("Sua", GetType(Boolean))
                dt.Columns.Add("Xoa", GetType(Boolean))
                For i = 0 To aVaiTro.Count - 1
                    Dim vaitro As ESSVaiTro = CType(aVaiTro(i), ESSVaiTro)
                    If Not vaitro Is Nothing Then
                        For j = 0 To vaitro.ESSVaiTroQuyen.Count - 1
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_ph") = vaitro.ESSVaiTroQuyen.ESSVaiTroQuyen(j).ID_ph
                            row("ID_Quyen") = vaitro.ESSVaiTroQuyen.ESSVaiTroQuyen(j).ID_quyen
                            row("Ten_Quyen") = vaitro.ESSVaiTroQuyen.ESSVaiTroQuyen(j).Ten_quyen
                            row("Them") = CovertingIntToBool(vaitro.ESSVaiTroQuyen.ESSVaiTroQuyen(j).Them)
                            row("Sua") = CovertingIntToBool(vaitro.ESSVaiTroQuyen.ESSVaiTroQuyen(j).Sua)
                            row("Xoa") = CovertingIntToBool(vaitro.ESSVaiTroQuyen.ESSVaiTroQuyen(j).Xoa)
                            dt.Rows.Add(row)
                        Next
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Load các vai trò của một User
        Public Function HienThi_ESSVaiTro(ByVal UserID As Integer) As DataTable
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.HienThi_ESSVaiTro_DanhSach(UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''Load các quyền của một User theo một vai trò
        Public Function HienThi_ESSUsersQuyen_DanhSach(ByVal User As ESSUsers, ByVal ID_vai_tro As Integer) As DataTable
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Dim dtUsersQuyen As DataTable = obj.HienThi_ESSUserQuyen(User.UserID, ID_vai_tro)
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_ph", GetType(Integer))
                dt.Columns.Add("ID_Quyen", GetType(Integer))
                dt.Columns.Add("Ten_Quyen", GetType(String))
                dt.Columns.Add("Them", GetType(Boolean))
                dt.Columns.Add("Sua", GetType(Boolean))
                dt.Columns.Add("Xoa", GetType(Boolean))
                For j As Integer = 0 To dtUsersQuyen.Rows.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_ph") = dtUsersQuyen.Rows(j)("ID_ph")
                    row("ID_Quyen") = dtUsersQuyen.Rows(j)("ID_Quyen")
                    row("Ten_Quyen") = dtUsersQuyen.Rows(j)("Ten_Quyen")
                    row("Them") = False
                    row("Sua") = False
                    row("Xoa") = False
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''Load các phân hệ của một User
        Public Function HienThi_ESSPhanHe_DanhSach(ByVal User As ESSUsers) As DataTable
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                If User.UserGroup = -1 Then
                    Return obj.HienThi_ESSPhanHe()
                Else
                    Return obj.HienThi_ESSPhanHe_DanhSach(User)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function




        ''Thêm mới một vai trò
        Public Function ThemMoi_ESSVaiTro(ByVal objVaiTro As ESSVaiTro) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.ThemMoi_ESSVaiTro(objVaiTro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Sửa lại một vai trò
        Public Function CapNhat_ESSVaiTro(ByVal objVaiTro As ESSVaiTro, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.CapNhat_ESSVaiTro(objVaiTro, ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Xóa Một Vai trò
        Public Function Xoa_ESSVaiTro(ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.Xoa_ESSVaiTro(ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''Thêm các quyền cho một vai trò
        Public Function ThemMoi_ESSVaiTroQuyen(ByVal idx As Integer) As Integer
            Try
                Dim objVaiTro As New ESSVaiTro
                objVaiTro = CType(aVaiTro(idx), ESSVaiTro)
                For i As Integer = 0 To objVaiTro.ESSVaiTroQuyen.Count - 1
                    ThemMoi_ESSVaiTroQuyen(objVaiTro.ESSVaiTroQuyen.ESSVaiTroQuyen(i), objVaiTro.ID_vai_tro)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Thêm mới các quyền cho một vai trò
        Public Function ThemMoi_ESSVaiTroQuyen(ByVal objVaiTroQuyen As ESSVaiTroQuyen, ByVal ID_Vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.ThemMoi_ESSVaiTroQuyen(objVaiTroQuyen, ID_Vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Xóa Hết các quyền của một vai trò
        Public Function Xoa_ESSVaiTroQuyen(ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.Xoa_ESSVaiTroQuyen(ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ''Thêm mới một vai trò cho User
        Public Function ThemMoi_ESSUsersVaiTro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.ThemMoi_ESSUsersVaiTro(UserID, ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        '' Xóa một vai trò của User
        Public Function Xoa_ESSUsersVaitro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.Xoa_ESSUsersVaitro(UserID, ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Kiểm tra vai trò đã được gán quyền chưa?
        Public Function CheckExist_htVaiTroQuyen(ByVal ID_vai_tro As Integer) As Boolean
            Try
                Dim obj As VaiTro_DataAccess = New VaiTro_DataAccess
                Return obj.CheckExist_VaiTroQuyen(ID_vai_tro)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Property VaiTro(ByVal idx As Integer) As ESSVaiTro
            Get
                Return CType(Me.aVaiTro(idx), ESSVaiTro)
            End Get
            Set(ByVal Value As ESSVaiTro)
                Me.aVaiTro(idx) = Value
            End Set
        End Property


#Region "Mapping Function" '' Các hàm Mapping
        '' Mapping sang Kiểu VaiTro
        Private Function Mapping(ByVal drVaiTro As DataRow) As ESSVaiTro
            Dim result As ESSVaiTro
            Try
                result = New ESSVaiTro
                If drVaiTro("ID_vai_tro").ToString() <> "" Then result.ID_vai_tro = CType(drVaiTro("ID_vai_tro").ToString(), Integer)
                result.Ten_vai_tro = drVaiTro("Ten_vai_tro").ToString()
                result.Mo_ta = drVaiTro("Mo_ta").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        '' Mapping sang kiểu Vaitro nhưng có thêm các trường Thêm, Sửa, Xóa, Chọn
        Private Function MappingVaiTro(ByVal drVaiTro As DataRow) As ESSVaiTro
            Dim result As ESSVaiTro
            Try
                result = New ESSVaiTro
                If drVaiTro("ID_vai_tro").ToString() <> "" Then result.ID_vai_tro = CType(drVaiTro("ID_vai_tro").ToString(), Integer)
                If drVaiTro("ID_ph").ToString() <> "" Then result.ESSVaiTroQuyen.ID_ph = CType(drVaiTro("ID_ph").ToString(), Integer)
                If drVaiTro("ID_quyen").ToString() <> "" Then result.ESSVaiTroQuyen.ID_quyen = CType(drVaiTro("ID_quyen").ToString(), Integer)
                If drVaiTro("Ten_Quyen").ToString() <> "" Then result.ESSVaiTroQuyen.Ten_quyen = CType(drVaiTro("Ten_Quyen").ToString(), String)
                If drVaiTro("Them").ToString() <> "" Then result.ESSVaiTroQuyen.Them = CType(CovertingBoolToInt(drVaiTro("Them").ToString()), Integer)
                If drVaiTro("Sua").ToString() <> "" Then result.ESSVaiTroQuyen.Sua = CType(CovertingBoolToInt(drVaiTro("Sua").ToString()), Integer)
                If drVaiTro("Xoa").ToString() <> "" Then result.ESSVaiTroQuyen.Xoa = CType(CovertingBoolToInt(drVaiTro("Xoa").ToString()), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result

        End Function
        '' Mapping sang kiểu ESSVaiTroQuyen
        Private Function MappingVaiTroQuyen(ByVal drVaiTroQuyen As DataRow) As ESSVaiTroQuyen
            Dim result As ESSVaiTroQuyen
            Try
                result = New ESSVaiTroQuyen
                If drVaiTroQuyen("ID_quyen").ToString() <> "" Then result.ID_quyen = CType(drVaiTroQuyen("ID_quyen").ToString(), Integer)
                If drVaiTroQuyen("Them").ToString() <> "" Then result.Them = CType(CovertingBoolToInt(drVaiTroQuyen("Them").ToString()), Integer)
                If drVaiTroQuyen("Sua").ToString() <> "" Then result.Sua = CType(CovertingBoolToInt(drVaiTroQuyen("Sua").ToString()), Integer)
                If drVaiTroQuyen("Xoa").ToString() <> "" Then result.Xoa = CType(CovertingBoolToInt(drVaiTroQuyen("Xoa").ToString()), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        '' Covert Từ Boolean sang Integer
        Public Function CovertingBoolToInt(ByVal Int As Boolean) As Integer
            If Int Then
                Return 1
            Else
                Return 0
            End If
        End Function
        '' Mapping từ Integer sang Boolean
        Private Function CovertingIntToBool(ByVal Int As Integer) As Boolean
            If Int = 1 Then
                Return True
            ElseIf Int = 0 Then
                Return False
            End If
        End Function
#End Region

#End Region
    End Class
End Namespace
