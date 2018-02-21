'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class TimKiemNangCao_DataAccess
        Public Function HienThi_ESSField_Show(ByVal ID_hien_thi As Integer, ByVal ID_user As Integer, ByVal ID_phan_he As Integer) As DataTable
            Dim strSQL As String
            Dim dt As DataTable
            If ID_hien_thi = (ID_phan_he * 100) + 1 Then
                strSQL = "SELECT b.* FROM SYS_HienThiTruongNguoiDung a INNER JOIN SYS_HienThiTruong b ON a.FieldID=b.FieldID WHERE a.ID_user = '" & ID_user & "' ORDER BY a.STT"
            Else
                If ID_hien_thi = ID_phan_he * 100 Then ID_hien_thi = (ID_phan_he * 100) + 3
                strSQL = "SELECT b.* FROM SYS_HienThiTruongMacDinh a INNER JOIN SYS_HienThiTruong b ON a.FieldID=b.FieldID WHERE a.FieldGroup = '" & ID_hien_thi & "' ORDER BY a.STT"
            End If
            dt = Connect.SelectTable(strSQL)
            Return dt
        End Function
        Public Function HienThi_ESSField_Search(ByVal FieldID As Integer) As DataTable
            Dim strSQL As String
            Dim dt As DataTable
            strSQL = "SELECT * FROM SYS_TimKiemTruong WHERE ID = " & FieldID
            dt = Connect.SelectTable(strSQL)
            Return dt
        End Function
        Public Function KetQuaTimKiem(ByVal strSQL As String) As DataTable
            Dim dt As DataTable
            dt = Connect.SelectTable(strSQL)
            Return dt
        End Function
        Public Function getFieldSearchID(ByVal FieldID As String, ByVal WTable As String, ByVal FieldGroup As Long) As Long
            Dim StrSQL As String
            Dim dt As DataTable
            StrSQL = "SELECT ID FROM SYS_TimKiemTruong " _
                    + "WHERE FieldID Like N'" & FieldID & "' AND WTable Like N'" & WTable & "' AND FieldGroup=" & FieldGroup
            dt = Connect.SelectTable(StrSQL)
            If dt.Rows.Count > 0 Then
                Return IIf(IsDBNull(dt.Rows(0).Item(0)), 0, dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        End Function
        ' Get nhóm trường hiển thị
        Public Function getFieldGroup(ByVal ID_phan_he As Integer) As DataTable
            Dim StrSQL As String
            Dim dt As DataTable
            StrSQL = "SELECT * FROM SYS_NhomTruong " _
                    + "WHERE FieldGroup > " & ID_phan_he * 100 & " and FieldGroup <" & (ID_phan_he + 1) * 100
            dt = Connect.SelectTable(StrSQL)
            Return dt
        End Function
        ' Get trường tìm kiếm
        Public Function getFieldSeach(ByVal ID_phan_he As Integer) As DataTable
            Dim StrSQL As String
            Dim dt As DataTable
            StrSQL = "SELECT * FROM SYS_TimKiemTruong " _
                    + "WHERE FieldGroup > " & ID_phan_he * 100 & " and FieldGroup <" & (ID_phan_he + 1) * 100
            dt = Connect.SelectTable(StrSQL)
            Return dt
        End Function
        ' Get trường tìm kiếm theo FieldGroup
        Public Function getFieldSeach_Group(ByVal FieldGroup As Integer) As DataTable
            Dim StrSQL As String
            Dim dt As DataTable
            StrSQL = "SELECT ID,FieldName FROM SYS_TimKiemTruong " _
                    + "WHERE FieldGroup = " & FieldGroup
            dt = Connect.SelectTable(StrSQL)
            Return dt
        End Function
        ' Get toán tử tìm kếm
        Public Function getOperator(ByVal Kieu_truong As Integer) As DataTable
            Dim StrSQL As String
            Dim dt As DataTable
            StrSQL = "SELECT FieldOperator,FieldOperator FROM SYS_ToanTuTruong WHERE FieldType = " & Kieu_truong
            dt = Connect.SelectTable(StrSQL)
            Return dt
        End Function
    End Class
End Namespace
