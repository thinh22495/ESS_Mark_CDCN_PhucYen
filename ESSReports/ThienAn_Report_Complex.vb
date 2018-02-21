'Coded By: AnhNT
'Created date: 26/3/2012
'Company: Thien An ESS Co.,Ltd
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing
Public Class ThienAn_Report_Complex
    Inherits ThienAnESS_Report
    Public Sub New(Optional ByVal pageKind As PaperKind = PaperKind.A4 _
                  , Optional ByVal landScape As Boolean = False _
                  , Optional ByVal margin As Margins = Nothing _
                  , Optional ByVal tableHeaderHeight As Single = 20 _
                  , Optional ByVal Tieu_de_bao_cao1 As String = "" _
                  , Optional ByVal Tieu_de_bao_cao2 As String = "" _
                  , Optional ByVal Tieu_de_bao_cao3 As String = "" _
                  , Optional ByVal Tieu_de_bao_cao4 As String = "" _
                  , Optional ByVal Tieu_de_bao_cao5 As String = "" _
                  , Optional ByVal Complex As Boolean = True _
                   , Optional ByVal headerFontSize As Single = 9 _
                  , Optional ByVal valueFontSize As Single = 9 _
                  , Optional ByVal Ghi_chu As String = "" _
                  , Optional ByVal Ghi_chu1 As String = "" _
                   )
        MyBase.New(pageKind, landScape, margin, tableHeaderHeight, Tieu_de_bao_cao1, Tieu_de_bao_cao2, Tieu_de_bao_cao3, Tieu_de_bao_cao4, Tieu_de_bao_cao5, Complex, headerFontSize, valueFontSize, Ghi_chu, Ghi_chu1)
    End Sub
    Public Overrides Sub SetUpHeaderTable(Optional ByVal tableHeight As Single = 40.0)
        'Define Table Header
        Me._TableHeader = New XRTable()
        Me._TableHeader.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me._TableHeader.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, tableHeight)
        Me._TableHeader.StylePriority.UseBorders = False
        Me._TableHeader.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me._TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me._TableHeader.Font = New System.Drawing.Font("Arial", _HeaderFontSize, Drawing.FontStyle.Bold)
        'Define Row Header
        _RowHeader = New XRTableRow
        _RowHeader.HeightF = tableHeight
        'Define Table Value
        Me._TableValue = New XRTable()
        Me._TableValue.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me._TableValue.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 20)
        Me._TableValue.StylePriority.UseBorders = False
        Me._TableValue.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me._TableValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me._TableValue.Font = New System.Drawing.Font("Arial", _ValueFontSize)
        'Define Row Header
        _RowValue = New XRTableRow
        _RowValue.HeightF = 27 ' Default for table value
        _RowValue.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)

        Dim pair As KeyValuePair(Of String, CellReport)
        For Each pair In ReportModel.HeaderTable
            If Not pair.Key.StartsWith("_dynamic") Then
                'Define header cell and add to TableHeader
                Dim cell As New XRTableCell()
                cell.Text = pair.Value.Text
                cell.Name = pair.Key
                cell.WidthF = pair.Value.Width
                'If pair.Value.DataBinding.Length > 0 Then
                '    cell.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
                'End If
                _RowHeader.Cells.Add(cell)

                'Define header cell and add to TableHeader
                Dim cellValue As New XRTableCell()
                cellValue.Name = pair.Key + "Val"
                cellValue.WidthF = pair.Value.Width
                cellValue.TextAlignment = pair.Value.TextAlignment
                If pair.Key.StartsWith("STT") Then
                    Dim sumary As New XRSummary
                    sumary.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
                    sumary.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
                    cellValue.Summary = sumary
                End If
                If pair.Key.StartsWith("Ho_ten") Then
                    cellValue.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
                End If
                If pair.Value.DataBinding.Length > 0 Then
                    cellValue.DataBindings.Add("Text", DataSource, pair.Value.DataBinding, pair.Value.Format)
                End If
                _RowValue.Cells.Add(cellValue)
            Else
                Dim cell As New XRTableCell()
                cell.WidthF = (Me.PageWidth - _MarginLeft - _MarginRight - CountFixedCell()) / ReportModel.ListHeaderDynamicTable.Count
                For Each dict As Dictionary(Of String, CellReport) In ReportModel.ListHeaderDynamicTable
                    If dict.Count > 0 Then
                        If _Complex Then
                            If dict.Keys.Any(Function(d) d.StartsWith(pair.Value.Tag)) Then
                                Dim dynamicTable As XRTable = Me.CreateTableHeaderDynamic(cell.WidthF, tableHeight, pair.Value.Text, 60, dict)
                                cell.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {dynamicTable})
                                _RowHeader.Cells.Add(cell)
                                'Add dynamic Cell Value
                                CreateDynamicCellValue((Me.PageWidth - _MarginLeft - _MarginRight - CountFixedCell()) / ReportModel.ListHeaderDynamicTable.Count, dict)
                            End If
                        Else
                            Dim dynamicTable As XRTable = Me.CreateTableHeaderDynamic(cell.WidthF, tableHeight, pair.Value.Text, 60, dict)
                            cell.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {dynamicTable})
                            _RowHeader.Cells.Add(cell)
                            'Add dynamic Cell Value
                            CreateDynamicCellValue((Me.PageWidth - _MarginLeft - _MarginRight - CountFixedCell()) / ReportModel.ListHeaderDynamicTable.Count, dict)
                        End If
                    End If
                Next
            End If
        Next
        'Add header Table
        Me._TableHeader.Rows.Add(_RowHeader)
        Me.PageHeader.HeightF = _TableHeader.HeightF
        Me.PageHeader.Controls.Add(_TableHeader)
        'Add Value Table
        Me._TableValue.Rows.Add(_RowValue)
        Me.Detail.Controls.Add(_TableValue)
        Me.Detail.HeightF = _RowValue.HeightF
    End Sub
    Public Overrides Sub CreateDynamicCellValue(Optional ByVal cellValueWidth As Single = 0.0, Optional ByVal dict As Dictionary(Of String, CellReport) = Nothing)
        Dim pair As KeyValuePair(Of String, CellReport)
        For Each pair In dict
            'Define the value dynamic table cell
            Dim cellValue As New XRTableCell()
            cellValue.Text = pair.Value.Text
            cellValue.Name = pair.Key
            cellValue.WidthF = cellValueWidth / dict.Count
            If pair.Value.DataBinding.Length > 0 Then
                cellValue.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
            End If
            _RowValue.Cells.Add(cellValue)
        Next
    End Sub
    Public Overrides Function CreateTableHeaderDynamic(Optional ByVal width As Single = 0.0, Optional ByVal height As Single = 0.0, Optional ByVal headerFirstRow As String = "", Optional ByVal heightFirstRow As Single = 0.0, Optional ByVal dict As Dictionary(Of String, CellReport) = Nothing) As DevExpress.XtraReports.UI.XRTable
        Dim TableHeaderDynamic = New XRTable()
        TableHeaderDynamic.Borders = DevExpress.XtraPrinting.BorderSide.All
        TableHeaderDynamic.SizeF = New System.Drawing.SizeF(width, height)
        'Add first row
        Dim row1 As New XRTableRow
        row1.HeightF = heightFirstRow
        Dim cellFirst As New XRTableCell
        cellFirst.Text = headerFirstRow
        'No border left
        cellFirst.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        row1.Cells.Add(cellFirst)
        TableHeaderDynamic.Rows.Add(row1)

        'Add second row
        Dim row2 As New XRTableRow
        row2.HeightF = height - heightFirstRow
        Dim pair As KeyValuePair(Of String, CellReport)

        Dim index As Integer = 0
        For Each pair In dict
            'Define the header dynamic table cell
            Dim cell As New XRTableCell()
            If index = 0 Then
                'No border left
                cell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            End If
            cell.Text = pair.Value.Text
            cell.Name = pair.Key
            cell.WidthF = pair.Value.Width
            cell.Multiline = True
            'If pair.Value.DataBinding.Length > 0 Then
            '    cell.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
            'End If
            row2.Cells.Add(cell)
            'Plus index
            index = index + 1
        Next
        TableHeaderDynamic.Rows.Add(row2)
        Return TableHeaderDynamic
    End Function
End Class
