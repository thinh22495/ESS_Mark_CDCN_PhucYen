'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class Quyen_Bussines
#Region "Variable"
        Private aVaiTroQuyen As ArrayList
        Private aPhanHe As ArrayList
        Private aUsersQuyen As ArrayList
        Private aID_Quyen As ArrayList

#End Region

        Public Sub New(ByVal UserID As Integer, ByVal ID_Vai_Tro As Integer)
            Try
                Dim obj As Quyen_DataAccess = New Quyen_DataAccess
                Dim objVaiTro As VaiTro_DataAccess = New VaiTro_DataAccess
                Dim dtUsersQuyen As DataTable = obj.HienThi_ESSUsersQuyen_DanhSach(UserID, ID_Vai_Tro)
                Dim objUsersQuyen As ESSUsersQuyen = Nothing
                Dim drUsersQuyen As DataRow = Nothing
                aUsersQuyen = New ArrayList
                For Each drUsersQuyen In dtUsersQuyen.Rows
                    objUsersQuyen = Mapping(drUsersQuyen)
                    aUsersQuyen.Add(objUsersQuyen)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region " Function"
        Private Function Mapping(ByVal drQuyen As DataRow) As ESSUsersQuyen
            Dim result As ESSUsersQuyen
            Try
                result = New ESSUsersQuyen
                If drQuyen("ID_quyen").ToString() <> "" Then result.ID_quyen = CType(drQuyen("ID_quyen").ToString(), Integer)
                result.Ten_quyen = drQuyen("Ten_quyen").ToString()
                'If drQuyen("ID_ph").ToString() <> "" Then result.ID_ph = CType(drQuyen("ID_ph").ToString(), Integer)
                If drQuyen("ID_nhom_quyen").ToString() <> "" Then result.ID_nhom_quyen = CType(drQuyen("ID_nhom_quyen").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingVaiTroQuyen(ByVal drVaiTroQuyen As DataRow) As ESSVaiTroQuyen
            Dim result As ESSVaiTroQuyen
            Try
                result = New ESSVaiTroQuyen
                If drVaiTroQuyen("ID_quyen").ToString() <> "" Then result.ID_quyen = CType(drVaiTroQuyen("ID_quyen").ToString(), Integer)
                result.Ten_quyen = drVaiTroQuyen("Ten_quyen").ToString()
                If drVaiTroQuyen("ID_ph").ToString() <> "" Then result.ID_ph = CType(drVaiTroQuyen("ID_ph").ToString(), Integer)
                If drVaiTroQuyen("ID_nhom_quyen").ToString() <> "" Then result.ID_nhom_quyen = CType(drVaiTroQuyen("ID_nhom_quyen").ToString(), Integer)
                If drVaiTroQuyen("Them").ToString() <> "" Then result.Them = CType(drVaiTroQuyen("Them").ToString(), Integer)
                If drVaiTroQuyen("Sua").ToString() <> "" Then result.Sua = CType(drVaiTroQuyen("Sua").ToString(), Integer)
                If drVaiTroQuyen("Xoa").ToString() <> "" Then result.Xoa = CType(drVaiTroQuyen("Xoa").ToString(), Integer)

            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function CovertingIntToBool(ByVal Int As Integer) As Boolean
            If Int = 1 Then
                Return True
            ElseIf Int = 0 Then
                Return False
            End If
        End Function
#End Region

    End Class
End Namespace
