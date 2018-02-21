'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2011
'---------------------------------------------------------------------------
Imports Microsoft.VisualBasic
Imports Excel
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports C1.Win.C1FlexGrid
Public Class ExportCommon
    Public Const hei_rate As Single = 1
    Public Const wid_rate As Single = 0.15
    Private _hien_thi_tien_trinh As Boolean = True
    Private _officeXP As Boolean = True

    Public Sub New()
    End Sub
    Public Property Hien_thi_tien_trinh() As Boolean
        Get
            Return _hien_thi_tien_trinh
        End Get
        Set(ByVal Value As Boolean)
            _hien_thi_tien_trinh = Value
        End Set
    End Property
    Public Property OfficeXP() As Boolean
        Get
            Return _officeXP
        End Get
        Set(ByVal Value As Boolean)
            _officeXP = Value
        End Set
    End Property
    Private Function Get_len(ByVal ie As IEnumerator) As Integer
        Dim no As Integer = 0
        ie.Reset()

        Do While ie.MoveNext()
            no += 1
        Loop

        Return no
    End Function
    Private Function Tim_chu(ByVal col As Integer) As Char
        Return Chr(col + Asc("A") - 1)
    End Function
    Private Function Tinh_toado(ByVal row As Integer, ByVal col As Integer) As String
        Dim kq As String
        If col <= (Asc("Z") - Asc("A") + 1) Then
            kq = Tim_chu(col) + row.ToString()
        Else
            Dim b As Integer = col Mod 26
            If b = 0 Then b = 26
            Dim a As Integer = CInt((col - b) / 26)
            kq = Tim_chu(a) + Tim_chu(b) + row.ToString()
        End If
        Return kq
    End Function
    Private Sub Write_title(ByRef ws As Excel._Worksheet, ByVal titles As ArrayList)
        Dim range1 As Excel.Range
        If Not titles Is Nothing Then
            For i As Integer = 0 To titles.Count - 1
                Dim xo As XlsCommon = CType(titles(i), XlsCommon)
                range1 = ws.Range(xo.First, xo.Last)
                range1.Font.Name = xo.font.Name
                range1.Font.Size = xo.font.Size
                range1.Font.FontStyle = xo.font.Style
                range1.Font.Color = xo.color.ToArgb()
                range1.VerticalAlignment = Excel.Constants.xlCenter
                range1.HorizontalAlignment = Excel.Constants.xlCenter
                range1.Merge()
                If Not xo.Value.GetType.FullName = "System.Drawing.Bitmap" Then
                    Dim strValue As String = xo.Value
                    If Not OfficeXP Then strValue = CStr(strValue).Replace(vbCrLf, vbLf)
                    range1.Value2 = strValue
                Else
                    range1.Value(Missing.Value) = CType(xo.Value, System.Drawing.Bitmap)
                End If
            Next
        End If
    End Sub
    Public Sub ExportFromC1flexgridToExcel(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid, Optional ByVal titles As ArrayList = Nothing, _
        Optional ByVal start_row As Integer = 1, Optional ByVal start_col As Integer = 1, Optional ByVal with_color As Boolean = False, _
        Optional ByVal font_name As String = "Arial", Optional ByVal font_size As Integer = 8)

        Dim app As Excel.Application
        Dim frm As New frmESS_ProgressBar
        frm.Master_Max = fg.Rows.Count
        frm.Slave_Max = fg.Cols.Count

        Try
            Dim first As String
            Dim last As String
            Dim range1 As Excel.Range

            app = New Excel.Application
            app.Visible = False
            Dim wb As Excel._Workbook
            wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet)
            Dim ws As Excel._Worksheet
            ws = wb.Worksheets.Add()

            Write_title(ws, titles)

            Dim b(fg.Rows.Count, fg.Cols.Count) As Boolean
            For j As Integer = 0 To fg.Cols.Count - 1
                For i As Integer = 0 To fg.Rows.Count - 1
                    If Not b(i, j) Then
                        Dim cr As C1.Win.C1FlexGrid.CellRange = fg.GetMergedRange(i, j)
                        first = Tinh_toado(cr.TopRow + start_row, cr.LeftCol + start_col)
                        last = Tinh_toado(cr.BottomRow + start_row, cr.RightCol + start_col)
                        range1 = ws.Range(first, last)
                        range1.Merge(Missing.Value)
                        If fg(i, j) Is Nothing Then
                            range1.Value2 = ""
                        Else
                            Dim o As Object = fg(i, j)
                            Select Case o.GetType.FullName
                                Case "System.Int64"
                                    o = Convert.ToInt32(o)
                                Case "System.DateTime"
                                    o = Format(o, "dd/MM/yyyy")
                                Case "System.String"
                                    ' ngay thang
                                    Dim s() As String = CStr(o).Split("/")
                                    If s.Length = 2 Then o = "'" + o
                                    Dim s1() As String = CStr(o).Split("-")
                                    If s1.Length = 2 Then o = "'" + o
                                    If Not OfficeXP Then o = CStr(o).Replace(vbCrLf, vbLf)
                            End Select
                            range1.Value2 = o
                        End If
                        range1.WrapText = True
                        If fg.Cols(j).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter Then
                            range1.HorizontalAlignment = Excel.Constants.xlCenter
                        End If
                        range1.VerticalAlignment = Excel.Constants.xlCenter
                        range1.ColumnWidth = CInt(fg.Cols(j).WidthDisplay * wid_rate)
                        range1.RowHeight = CInt(fg.Rows(i).HeightDisplay * hei_rate)
                        range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)

                        If with_color Then
                            Dim cs As C1.Win.C1FlexGrid.CellStyle = fg.GetCellStyleDisplay(i, j)
                            If Not cs Is Nothing Then
                                range1.Font.Color = cs.ForeColor.ToArgb()
                                range1.Interior.Color = cs.BackColor.ToArgb()
                            End If
                        End If

                        ' che mat na
                        For r1 As Integer = cr.TopRow To cr.BottomRow
                            For c1 As Integer = cr.LeftCol To cr.RightCol
                                b(r1, c1) = True
                            Next
                        Next
                    End If
                    If Hien_thi_tien_trinh Then frm.Show(i, j)
                Next
            Next

            first = Tinh_toado(start_row, start_col)
            last = Tinh_toado(start_row + fg.Rows.Count - 1, start_col + fg.Cols.Count - 1)
            range1 = ws.Range(first, last)
            range1.BorderAround(Missing.Value, XlBorderWeight.xlMedium)
            range1.Font.Name = font_name
            range1.Font.Size = font_size

            If Hien_thi_tien_trinh Then frm.Close()
            app.Visible = True
            wb = Nothing
            ws = Nothing
            app = Nothing

        Catch ex As Exception
            frm.Close()
            Throw ex
        End Try
    End Sub
    Public Sub ExportFromC1flexgridToExcel_WorkSheet(ByVal ws As Excel._Worksheet, ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid, Optional ByVal titles As ArrayList = Nothing, _
        Optional ByVal start_row As Integer = 1, Optional ByVal start_col As Integer = 1, Optional ByVal with_color As Boolean = False, _
        Optional ByVal font_name As String = "Arial", Optional ByVal font_size As Integer = 8)

        Dim frm As New frmESS_ProgressBar
        frm.Master_Max = fg.Rows.Count
        frm.Slave_Max = fg.Cols.Count

        Try
            Dim first As String
            Dim last As String
            Dim range1 As Excel.Range

            Write_title(ws, titles)
            Dim b(fg.Rows.Count, fg.Cols.Count) As Boolean
            For i As Integer = 0 To fg.Rows.Count - 1
                For j As Integer = 0 To fg.Cols.Count - 1
                    If Not b(i, j) Then
                        Dim cr As C1.Win.C1FlexGrid.CellRange = fg.GetMergedRange(i, j)
                        first = Tinh_toado(cr.TopRow + start_row, cr.LeftCol + start_col)
                        last = Tinh_toado(cr.BottomRow + start_row, cr.RightCol + start_col)
                        range1 = ws.Range(first, last)
                        range1.Merge(Missing.Value)
                        If fg(i, j) Is Nothing Then
                            range1.Value2 = ""
                        Else
                            Dim o As Object = fg(i, j)
                            Select Case o.GetType.FullName
                                Case "System.Int64"
                                    o = Convert.ToInt32(o)
                                Case "System.String"
                                    ' ngay thang
                                    Dim s() As String = CStr(o).Split("/")
                                    If s.Length = 2 Then o = "'" + o
                                    Dim s1() As String = CStr(o).Split("-")
                                    If s1.Length = 2 Then o = "'" + o
                                    If Not OfficeXP Then o = CStr(o).Replace(vbCrLf, vbLf)
                            End Select
                            range1.Value2 = o
                        End If
                        range1.WrapText = True
                        range1.VerticalAlignment = Excel.Constants.xlCenter
                        range1.HorizontalAlignment = Excel.Constants.xlCenter
                        range1.ColumnWidth = fg.Cols(j).WidthDisplay * wid_rate
                        range1.RowHeight = fg.Rows(i).HeightDisplay * hei_rate
                        range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)

                        If with_color Then
                            Dim cs As C1.Win.C1FlexGrid.CellStyle = fg.GetCellStyleDisplay(i, j)
                            If Not cs Is Nothing Then
                                range1.Font.Color = cs.ForeColor.ToArgb()
                                range1.Interior.Color = cs.BackColor.ToArgb()
                            End If
                        End If

                        ' che mat na
                        For r1 As Integer = cr.TopRow To cr.BottomRow
                            For c1 As Integer = cr.LeftCol To cr.RightCol
                                b(r1, c1) = True
                            Next
                        Next
                    End If
                    If Hien_thi_tien_trinh Then frm.Show(i, j)
                Next

            Next

            first = Tinh_toado(start_row, start_col)
            last = Tinh_toado(start_row + fg.Rows.Count - 1, start_col + fg.Cols.Count - 1)
            range1 = ws.Range(first, last)
            range1.BorderAround(Missing.Value, XlBorderWeight.xlMedium)
            range1.Font.Name = font_name
            range1.Font.Size = font_size

            If Hien_thi_tien_trinh Then frm.Close()
        Catch ex As Exception
            frm.Close()
            Throw ex
        End Try
    End Sub

    Public Sub ExportFromDataGridViewToExcel(ByVal grdVieew As DataGridView, Optional ByVal titles As ArrayList = Nothing, _
        Optional ByVal start_row As Integer = 1, Optional ByVal start_col As Integer = 1, _
        Optional ByVal font_name As String = "Arial", Optional ByVal font_size As Integer = 10)

        Dim app As Excel.Application
        Dim frm As New frmESS_ProgressBar
        frm.Master_Max = grdVieew.Rows.Count
        frm.Slave_Max = grdVieew.Columns.Count

        Try
            Dim first As String
            Dim last As String
            Dim range1 As Excel.Range
            Dim col As Integer
            app = New Excel.Application
            app.Visible = False
            Dim wb As Excel._Workbook
            wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet)
            Dim ws As Excel._Worksheet
            ws = wb.Worksheets.Add()

            Write_title(ws, titles)

            Dim b(grdVieew.Rows.Count, grdVieew.Columns.Count) As Boolean
            col = 0
            'Tiêu đề
            For j As Integer = 0 To grdVieew.Columns.Count - 1
                If grdVieew.Columns(j).GetType.ToString <> "System.Windows.Forms.DataGridViewImageColumn" _
                    And grdVieew.Columns(j).GetType.ToString <> "System.Windows.Forms.DataGridViewCheckBoxColumn" _
                    And grdVieew.Columns(j).Visible = True Then
                    first = Tinh_toado(start_row, col + start_col)
                    last = Tinh_toado(start_row, col + start_col)
                    range1 = ws.Range(first, last)
                    range1.Value2 = grdVieew.Columns(j).HeaderText
                    range1.WrapText = True
                    range1.HorizontalAlignment = Excel.Constants.xlCenter
                    range1.VerticalAlignment = Excel.Constants.xlCenter
                    range1.ColumnWidth = grdVieew.Columns(j).Width * wid_rate
                    range1.RowHeight = 25
                    range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)
                    col += 1
                End If
            Next
            col = 0
            start_row += 1
            'Chi tiết
            For j As Integer = 0 To grdVieew.Columns.Count - 1
                If grdVieew.Columns(j).GetType.ToString <> "System.Windows.Forms.DataGridViewImageColumn" _
                     And grdVieew.Columns(j).GetType.ToString <> "System.Windows.Forms.DataGridViewCheckBoxColumn" _
                     And grdVieew.Columns(j).Visible = True Then
                    For i As Integer = 0 To grdVieew.Rows.Count - 1
                        If Not b(i, j) Then
                            first = Tinh_toado(i + start_row, col + start_col)
                            last = Tinh_toado(i + start_row, col + start_col)
                            range1 = ws.Range(first, last)
                            range1.Merge(Missing.Value)
                            If grdVieew.Columns(j).ValueType.Name = "DateTime" Then
                                ' Kiểm tra khi cell có giá trị null
                                If (grdVieew.Rows(i).Cells(j).Value.ToString() <> "") Then
                                    'range1.Value2 = Format(grdVieew.Rows(i).Cells(j).Value, "dd/MM/yyyy")
                                    range1.Value2 = grdVieew.Rows(i).Cells(j).Value
                                End If
                            Else
                                range1.Value2 = grdVieew.Rows(i).Cells(j).Value
                            End If
                            range1.WrapText = True
                            If InStr(grdVieew.Columns(j).DefaultCellStyle.Alignment.ToString, "Center") Then
                                range1.HorizontalAlignment = Excel.Constants.xlCenter
                            ElseIf InStr(grdVieew.Columns(j).DefaultCellStyle.Alignment.ToString, "Left") Then
                                range1.HorizontalAlignment = Excel.Constants.xlLeft
                            Else
                                range1.HorizontalAlignment = Excel.Constants.xlRight
                            End If
                            range1.VerticalAlignment = Excel.Constants.xlCenter
                            range1.ColumnWidth = grdVieew.Columns(j).Width * wid_rate
                            range1.RowHeight = grdVieew.Rows(i).Height
                            range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)
                        End If
                        If Hien_thi_tien_trinh Then frm.Show(i, j)
                    Next
                    col += 1
                End If
            Next
            start_row -= 1
            first = Tinh_toado(start_row, start_col)
            last = Tinh_toado(start_row + grdVieew.Rows.Count, start_col + col - 1)
            range1 = ws.Range(first, last)
            range1.BorderAround(Missing.Value, XlBorderWeight.xlMedium)
            range1.Font.Name = font_name
            range1.Font.Size = font_size
            If Hien_thi_tien_trinh Then frm.Close()
            app.Visible = True
        Catch ex As Exception
            frm.Close()
            Throw ex
        End Try
    End Sub


    Public Sub ExportFromDevGridViewToExcel(ByVal grdVieew As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal titles As ArrayList = Nothing, _
    Optional ByVal start_row As Integer = 1, Optional ByVal start_col As Integer = 1, _
    Optional ByVal font_name As String = "Arial", Optional ByVal font_size As Integer = 10)

        Dim app As Excel.Application
        Dim frm As New frmESS_ProgressBar
        frm.Master_Max = grdVieew.RowCount
        frm.Slave_Max = grdVieew.Columns.Count
        Try
            Dim first As String
            Dim last As String
            Dim range1 As Excel.Range
            Dim col As Integer
            app = New Excel.Application
            app.Visible = False
            Dim wb As Excel._Workbook
            wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet)
            Dim ws As Excel._Worksheet
            ws = wb.Worksheets.Add()

            Write_title(ws, titles)

            Dim b(grdVieew.RowCount, grdVieew.Columns.Count) As Boolean
            col = 0
            'Tiêu đề
            For j As Integer = 0 To grdVieew.Columns.Count - 1
                If grdVieew.Columns(j).Visible = True Then
                    first = Tinh_toado(start_row, col + start_col)
                    last = Tinh_toado(start_row, col + start_col)
                    range1 = ws.Range(first, last)
                    range1.Value2 = grdVieew.Columns(j).Caption
                    range1.WrapText = True
                    range1.HorizontalAlignment = Excel.Constants.xlCenter
                    range1.VerticalAlignment = Excel.Constants.xlCenter
                    range1.ColumnWidth = grdVieew.Columns(j).Width * wid_rate
                    range1.RowHeight = 20
                    range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)
                    col += 1
                End If
            Next
            col = 0
            start_row += 1
            'Chi tiết
            For j As Integer = 0 To grdVieew.Columns.Count - 1
                If grdVieew.Columns(j).Visible = True Then
                    For i As Integer = 0 To grdVieew.RowCount - 1
                        If Not b(i, j) Then
                            first = Tinh_toado(i + start_row, col + start_col)
                            last = Tinh_toado(i + start_row, col + start_col)
                            range1 = ws.Range(first, last)
                            range1.Merge(Missing.Value)
                            If grdVieew.Columns(j).ColumnType.Name = "DateTime" Then
                                ' Kiểm tra khi cell có giá trị null
                                If (grdVieew.GetDataRow(i)(grdVieew.Columns(j).FieldName).ToString <> "") Then
                                    'range1.Value2 = Format(grdVieew.GetDataRow(i)(grdVieew.Columns(j).FieldName), "dd/MM/yyyy")
                                    range1.Value2 = CType(grdVieew.GetDataRow(i)(grdVieew.Columns(j).FieldName), Date)
                                End If
                            Else
                                range1.Value2 = grdVieew.GetDataRow(i)(grdVieew.Columns(j).FieldName)
                            End If
                            range1.WrapText = True
                            If InStr(grdVieew.Columns(j).AppearanceCell.TextOptions.VAlignment.ToString, "Center") Then
                                range1.HorizontalAlignment = Excel.Constants.xlCenter
                            ElseIf InStr(grdVieew.Columns(j).AppearanceCell.TextOptions.VAlignment.ToString, "Left") Then
                                range1.HorizontalAlignment = Excel.Constants.xlLeft
                            Else
                                range1.HorizontalAlignment = Excel.Constants.xlRight
                            End If
                            range1.VerticalAlignment = Excel.Constants.xlCenter
                            range1.ColumnWidth = grdVieew.Columns(j).Width * wid_rate
                            range1.RowHeight = 25
                            range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)
                        End If
                        If Hien_thi_tien_trinh Then frm.Show(i, j)
                    Next
                    col += 1
                End If
            Next
            start_row -= 1
            first = Tinh_toado(start_row, start_col)
            last = Tinh_toado(start_row + grdVieew.RowCount, start_col + col - 1)
            range1 = ws.Range(first, last)
            range1.BorderAround(Missing.Value, XlBorderWeight.xlMedium)
            range1.Font.Name = font_name
            range1.Font.Size = font_size
            If Hien_thi_tien_trinh Then frm.Close()
            app.Visible = True
        Catch ex As Exception
            frm.Close()
            Throw ex
        End Try
    End Sub

    Public Sub Export_FromDataView_ToExcel(ByVal fg As C1FlexGrid, Optional ByVal titles As ArrayList = Nothing, _
    Optional ByVal start_row As Integer = 1, Optional ByVal start_col As Integer = 1, _
    Optional ByVal font_name As String = "Arial", Optional ByVal font_size As Integer = 10)

        Dim app As Excel.Application
        Dim frm As New frmESS_ProgressBar
        frm.Master_Max = fg.Rows.Count
        frm.Slave_Max = fg.Cols.Count
        Try
            Dim first As String
            Dim last As String
            Dim range1 As Excel.Range
            Dim col As Integer
            app = New Excel.Application
            app.Visible = False
            Dim wb As Excel._Workbook
            wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet)
            Dim ws As Excel._Worksheet
            ws = wb.Worksheets.Add()

            Write_title(ws, titles)

            Dim b(fg.Rows.Count, fg.Cols.Count) As Boolean
            col = 0
            'Tiêu đề
            For j As Integer = 0 To fg.Cols.Count - 1
                If fg.Cols(j).Visible = True Then
                    first = Tinh_toado(start_row, col + start_col)
                    last = Tinh_toado(start_row, col + start_col)
                    range1 = ws.Range(first, last)
                    range1.Value2 = fg.Cols(j).Caption
                    range1.WrapText = True
                    range1.HorizontalAlignment = Excel.Constants.xlCenter
                    range1.VerticalAlignment = Excel.Constants.xlCenter
                    range1.ColumnWidth = fg.Cols(j).Width * wid_rate
                    range1.RowHeight = 20
                    range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)
                    col += 1
                End If
            Next
            col = 0
            start_row += 1
            'Chi tiết
            For j As Integer = 0 To fg.Cols.Count - 1
                If fg.Cols(j).Visible = True Then
                    For i As Integer = 0 To fg.Rows.Count - 1
                        If Not b(i, j) Then
                            first = Tinh_toado(i + start_row, col + start_col)
                            last = Tinh_toado(i + start_row, col + start_col)
                            range1 = ws.Range(first, last)
                            range1.Merge(Missing.Value)
                            If fg.Cols(j).Name = "DateTime" Then
                                ' Kiểm tra khi cell có giá trị null
                                If (fg.GetData(i, j)(fg.Cols(j).Name).ToString <> "") Then
                                    range1.Value2 = Format(fg.GetData(i, j)(fg.Cols(j).Name), "dd/MM/yyyy")
                                    'range1.Value2 = grdVieew.GetDataRow(i)(fg.Cols(j).FieldName)
                                End If
                            Else
                                range1.Value2 = fg.GetData(i, j)(fg.Cols(j).Name)
                            End If
                            range1.WrapText = True
                            'If InStr(fg.Cols(j).a.TextOptions.VAlignment.ToString, "Center") Then
                            '    range1.HorizontalAlignment = Excel.Constants.xlCenter
                            'ElseIf InStr(fg.Cols(j).AppearanceCell.TextOptions.VAlignment.ToString, "Left") Then
                            '    range1.HorizontalAlignment = Excel.Constants.xlLeft
                            'Else
                            '    range1.HorizontalAlignment = Excel.Constants.xlRight
                            'End If
                            range1.VerticalAlignment = Excel.Constants.xlCenter
                            range1.ColumnWidth = fg.Cols(j).Width * wid_rate
                            range1.RowHeight = 25
                            range1.BorderAround(Missing.Value, XlBorderWeight.xlThin)
                        End If
                        If Hien_thi_tien_trinh Then frm.Show(i, j)
                    Next
                    col += 1
                End If
            Next
            start_row -= 1
            first = Tinh_toado(start_row, start_col)
            last = Tinh_toado(start_row + fg.Rows.Count, start_col + col - 1)
            range1 = ws.Range(first, last)
            range1.BorderAround(Missing.Value, XlBorderWeight.xlMedium)
            range1.Font.Name = font_name
            range1.Font.Size = font_size
            If Hien_thi_tien_trinh Then frm.Close()
            app.Visible = True
        Catch ex As Exception
            frm.Close()
            Throw ex
        End Try
    End Sub





End Class
