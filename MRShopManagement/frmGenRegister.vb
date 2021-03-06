﻿Imports System.Data.OleDb
Imports System.Globalization

Public Class frmGenRegister
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private regDate As String = ""
    Private regStock As Integer = 0
    Private regSale As Integer = 1
    Private regName As String

    Private strFormat As StringFormat           'Used to format the grid rows.
    Private arrColumnLefts As New ArrayList()   'Used to save left coordinates of columns
    Private arrColumnWidths As New ArrayList()  'Used to save column widths
    Private iCellHeight As Integer = 0          'Used To Get/Set the datagridview cell height
    Private iTotalWidth As Integer = 0          '
    Private iRow As Integer = 0                 'Used As counter
    Private bFirstPage As Boolean = False       'Used To check whether we are printing first page
    Private bNewPage As Boolean = False         'Used To check whether we are printing a New page
    Private iHeaderHeight = 0                   'Used for the header height

    Private Sub frmGenRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString

        With System.DateTime.Today
            regDate = regDate + .Day.ToString + "-"
            regDate = regDate + .Month.ToString + "-"
            regDate = regDate + .Year.ToString
        End With

        datagridRegister.AutoGenerateColumns = True
    End Sub
    Private Sub frmStockReg_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub cmboxRegisterType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxRegisterType.SelectedIndexChanged
        If cmboxRegisterType.SelectedItem.ToString = "Sale" Then
            lblCategory.Enabled = True
            cmboxCategory.Enabled = True
        Else
            lblCategory.Enabled = False
            cmboxCategory.Enabled = False
        End If
    End Sub

    Private Sub bttnGenerate_Click(sender As Object, e As EventArgs) Handles bttnGenerate.Click
        'regName = IIf(cmboxCategory.SelectedIndex < 0, "", cmboxCategory.SelectedItem.ToString) & " " & cmboxRegisterType.SelectedItem.ToString & " " & "Register"
        If ValidateForm(sender) Then
            Select Case cmboxRegisterType.SelectedIndex
                Case regStock
                    GenerateRegister(regStock, vbNullString)
                Case regSale
                    GenerateRegister(regSale, cmboxCategory.SelectedItem.ToString)
            End Select
        End If
    End Sub

    Private Function ValidateForm(ByVal sender As Object) As Boolean
        Dim flag As Boolean = False
        If cmboxRegisterType.SelectedIndex = -1 Then
            MsgBox("Select Register!")
        ElseIf cmboxRegisterType.SelectedIndex = 1 And cmboxCategory.SelectedIndex = -1 Then
            MsgBox("Select Category!")
        Else
            flag = True
        End If
        Return flag
    End Function

    Private Sub GenerateRegister(ByVal RegType As Integer, ByVal Category As String)
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim sql As String

        Dim row As DataGridViewRow
        Dim rowID As Integer
        Dim parentRowID As Integer

        Dim startDate As Date
        Dim endDate As Date
        Dim delvDate As Date

        Dim scale As Double = 0.0
        Dim unit As String
        Dim criteria As String
        Dim noUnit As Integer

        Dim noHead As Integer = 1
        Dim totalHead As Integer = 0
        Dim totalFamily As Integer = 0

        Dim totalRicePrice As Double = 0.0
        Dim totalWhetPrice As Double = 0.0
        Dim totalAttaPrice As Double = 0.0
        Dim totalSugrPrice As Double = 0.0
        Dim totalKOilPrice As Double = 0.0

        Dim riceStock As Double
        Dim whetStock As Double
        Dim attaStock As Double
        Dim sugrStock As Double
        Dim koilStock As Double

        Dim riceScale As Double
        Dim whetScale As Double
        Dim attaScale As Double
        Dim sugrScale As Double
        Dim koilScale As Double

        Dim riceUnit As String
        Dim whetUnit As String
        Dim attaUnit As String
        Dim sugrUnit As String
        Dim koilUnit As String

        datagridRegister.Rows.Clear()
        datagridRegister.Columns.Clear()
        Me.Cursor = Cursors.WaitCursor
        'Console.WriteLine(RegType)
        Select Case RegType
            Case regStock
                With datagridRegister
                    .Columns.Add("delvDate", "Date")
                    .Columns.Add("rcCategory", "Category")
                    .Columns.Add("rcProduct", "Product")
                    .Columns.Add("stockOB", "Openning Balance")
                    .Columns.Add("stockReceived", "Received")
                    .Columns.Add("stockTotal", "Total")
                    .Columns.Add("stockSold", "Sold")
                    .Columns.Add("stockLoss", "Handling Loss")
                    .Columns.Add("stockClosing", "Closing Balance")
                End With
                Try
                    connection.Open()

                    sql = "SELECT MIN(Delivery), MAX(Delivery) FROM Delivery"
                    cmd = New OleDbCommand(sql, connection)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows And Not dr.IsDBNull(0) Then
                        startDate = dr.GetDateTime(0).Date
                        endDate = dr.GetDateTime(1).Date
                    End If
                    Dim myCulture As CultureInfo = CultureInfo.CurrentCulture
                    delvDate = startDate
                    While delvDate <> endDate.AddDays(1)
                        For Each catg As String In {"AAY", "PHH", "SPHH", "RKSY-I", "RKSY-II"}
                            For product As Integer = 1 To 5
                                rowID = datagridRegister.Rows.Add
                                row = datagridRegister.Rows(rowID)
                                With row
                                    .Cells(0).Value = delvDate.ToShortDateString
                                    .Cells(1).Value = catg
                                End With

                                sql = "SELECT Name FROM Products WHERE ProductID=" & product
                                cmd = New OleDbCommand(sql, connection)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                row.Cells(2).Value = dr(0).ToString

                                If delvDate = startDate Then
                                    sql = "SELECT Received FROM Stock WHERE Category = '" & catg & "' AND ProductID = " & product
                                    cmd = New OleDbCommand(sql, connection)
                                    dr = cmd.ExecuteReader
                                    dr.Read()
                                    row.Cells(3).Value = Format(dr.GetDouble(0), "###0.000")
                                Else
                                    row.Cells(3).Value = datagridRegister(8, rowID - 26).Value
                                End If

                                row.Cells(4).Value = Format(0, "###0.000")
                                'Total Stock = Opening Balance + Received Stock
                                row.Cells(5).Value = Format(Double.Parse(datagridRegister(3, rowID).Value) + Double.Parse(datagridRegister(4, rowID).Value), "###0.000")

                                sql = "SELECT Scale, Unit FROM Allotment WHERE ProductID = " & product & " AND Category = '" & catg & "'"
                                cmd = New OleDbCommand(sql, connection)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                scale = dr.GetDouble(0)
                                unit = dr.GetString(1)
                                If unit = "Head" Then
                                    criteria = "RCNo"
                                Else
                                    criteria = "CashMemoNo"
                                End If
                                sql = "SELECT COUNT(*) FROM (SELECT DISTINCT " & criteria & " FROM Delivery WHERE Category = '" + catg + "' AND Delivery BETWEEN FORMAT(#" + DateTime.ParseExact(delvDate.ToShortDateString & " 00:00:01", "dd/MM/yyyy HH:mm:ss", myCulture) + "#, 'mm/dd/yyyy hh:nn:ss am/pm') AND FORMAT(#" + DateTime.ParseExact(delvDate.ToShortDateString & " 23:59:59", "dd/MM/yyyy HH:mm:ss", myCulture) + "#, 'mm/dd/yyyy hh:nn:ss am/pm'))"
                                cmd = New OleDbCommand(sql, connection)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                noUnit = dr.GetInt32(0)
                                'Console.WriteLine(delvDate & " " & catg & " " & product & " " & scale & " " & unit & " " & criteria & " " & noUnit)
                                row.Cells(6).Value = Format(noUnit * scale, "###0.000")

                                row.Cells(7).Value = Format(0.0, "###0.000")
                                row.Cells(8).Value = Format(Double.Parse(datagridRegister(5, rowID).Value) - (Double.Parse(datagridRegister(6, rowID).Value) + Double.Parse(datagridRegister(7, rowID).Value)), "###0.000")
                            Next
                        Next
                        delvDate = delvDate.AddDays(1)
                        rowID = datagridRegister.Rows.Add()
                        row = datagridRegister.Rows(rowID)
                        For i As Integer = 0 To 8
                            row.Cells(i).Value = " "
                        Next
                    End While
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    MsgBox("Fatal Error: " + ex.Message + "->" + ex.StackTrace)
                Finally
                    connection.Close()
                End Try

            Case regSale
                With datagridRegister
                    .Columns.Add("delvDate", "Date")
                    .Columns.Add("rcNo", "Ration Card No.")
                    .Columns.Add("memoNo", "Cash Memo No.")
                    .Columns.Add("rcCategory", "Category")
                    .Columns.Add("rcFamily", "Family")
                    .Columns.Add("headNo", "No(s) of Head")
                    .Columns.Add("riceQty", "Rice")
                    .Columns.Add("whtQty", "Wheat")
                    .Columns.Add("attaQty", "Atta")
                    .Columns.Add("sugarQty", "Sugar")
                    .Columns.Add("koilQty", "K. Oil")
                End With

                Try
                    connection.Open()

                    sql = "SELECT MIN(Delivery), MAX(Delivery) FROM Delivery WHERE Category = '" + Category + "'"
                    cmd = New OleDbCommand(sql, connection)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows And Not dr.IsDBNull(0) Then
                        startDate = dr.GetDateTime(0).Date
                        endDate = dr.GetDateTime(1).Date
                    End If

                    sql = "SELECT * FROM Allotment WHERE Category = '" + Category + "'"
                    cmd = New OleDbCommand(sql, connection)
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            Select Case Integer.Parse(dr(0).ToString)
                                Case 1
                                    riceScale = dr.GetDouble(2)
                                    riceUnit = dr.GetString(3)
                                Case 2
                                    whetScale = dr.GetDouble(2)
                                    whetUnit = dr.GetString(3)
                                Case 3
                                    attaScale = dr.GetDouble(2)
                                    attaUnit = dr.GetString(3)
                                Case 4
                                    sugrScale = dr.GetDouble(2)
                                    sugrUnit = dr.GetString(3)
                                Case 5
                                    koilScale = dr.GetDouble(2)
                                    koilUnit = dr.GetString(3)
                            End Select
                        End While
                    End If
                    'Console.WriteLine(startDate.ToOADate)

                    Dim myCulture As CultureInfo = CultureInfo.CurrentCulture
                    'Console.WriteLine(DateTime.ParseExact(startDate.ToShortDateString, "d", myCulture))

                    delvDate = startDate
                    While delvDate <> endDate.AddDays(1)
                        totalHead = 0
                        totalFamily = 0
                        totalRicePrice = 0
                        totalWhetPrice = 0
                        totalAttaPrice = 0
                        totalSugrPrice = 0
                        totalKOilPrice = 0

                        sql = "SELECT RCNo, CashMemoNo FROM Delivery WHERE Category = '" + Category + "' AND Delivery BETWEEN FORMAT(#" + DateTime.ParseExact(delvDate.ToShortDateString & " 00:00:01", "dd/MM/yyyy HH:mm:ss", myCulture) + "#, 'mm/dd/yyyy hh:nn:ss am/pm') AND FORMAT(#" + DateTime.ParseExact(delvDate.ToShortDateString & " 23:59:59", "dd/MM/yyyy HH:mm:ss", myCulture) + "#, 'mm/dd/yyyy hh:nn:ss am/pm') ORDER BY CashMemoNo ASC"
                        'Console.WriteLine(sql)
                        cmd = New OleDbCommand(sql, connection)
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            While dr.Read()
                                rowID = datagridRegister.Rows.Add
                                totalHead = totalHead + 1
                                row = datagridRegister.Rows(rowID)
                                With row
                                    .Cells(0).Value = delvDate.ToShortDateString
                                    .Cells(1).Value = dr(0).ToString
                                    If rowID = 0 Then
                                        parentRowID = rowID
                                        totalFamily = totalFamily + 1
                                        .Cells(2).Value = dr(1).ToString
                                        .Cells(4).Value = 1
                                        .Cells(5).Value = noHead
                                    ElseIf dr.GetInt32(1) = datagridRegister.Rows(parentRowID).Cells(2).Value Then
                                        '.Cells(2).Value = 
                                        '.Cells(4).Value =
                                        '.Cells(5).Value = 
                                        noHead = noHead + 1
                                        datagridRegister.Rows(parentRowID).Cells(5).Value = noHead
                                    Else
                                        parentRowID = rowID
                                        totalFamily = totalFamily + 1
                                        noHead = 1
                                        .Cells(2).Value = dr(1).ToString
                                        .Cells(4).Value = 1
                                        .Cells(5).Value = noHead
                                    End If
                                    .Cells(3).Value = Category
                                    If parentRowID = rowID Then
                                        .Cells(6).Value = Format(riceScale, "###0.000")
                                        .Cells(7).Value = Format(whetScale, "###0.000")
                                        .Cells(8).Value = Format(attaScale, "###0.000")
                                        .Cells(9).Value = Format(sugrScale, "###0.000")
                                        .Cells(10).Value = Format(koilScale, "###0.000")
                                    Else
                                        If riceUnit = "Head" Then
                                            .Cells(6).Value = Format(riceScale, "###0.000")
                                        End If
                                        If whetUnit = "Head" Then
                                            .Cells(7).Value = Format(whetScale, "###0.000")
                                        End If
                                        If attaUnit = "Head" Then
                                            .Cells(8).Value = Format(attaScale, "###0.000")
                                        End If
                                        If sugrUnit = "Head" Then
                                            .Cells(9).Value = Format(sugrScale, "###0.000")
                                        End If
                                        If koilUnit = "Head" Then
                                            .Cells(10).Value = Format(koilScale, "###0.000")
                                        End If
                                    End If
                                End With
                            End While

                            rowID = datagridRegister.Rows.Add
                            row = datagridRegister.Rows(rowID)
                            With row
                                .Cells(0).Value = delvDate.ToShortDateString
                                .Cells(1).Value = "Total"
                                .Cells(2).Value = "-"
                                .Cells(3).Value = Category
                                .Cells(4).Value = totalFamily
                                .Cells(5).Value = totalHead
                                For Each r As DataGridViewRow In datagridRegister.Rows
                                    If r.Cells(0).Value = .Cells(0).Value And Not r.Index = rowID Then
                                        If Not r.Cells(6).Value = Nothing Then
                                            totalRicePrice = totalRicePrice + Double.Parse(r.Cells(6).Value)
                                        End If
                                        If Not r.Cells(7).Value = Nothing Then
                                            totalWhetPrice = totalWhetPrice + Double.Parse(r.Cells(7).Value)
                                        End If
                                        If Not r.Cells(8).Value = Nothing Then
                                            totalAttaPrice = totalAttaPrice + Double.Parse(r.Cells(8).Value)
                                        End If
                                        If Not r.Cells(9).Value = Nothing Then
                                            totalSugrPrice = totalSugrPrice + Double.Parse(r.Cells(9).Value)
                                        End If
                                        If Not r.Cells(10).Value = Nothing Then
                                            totalKOilPrice = totalKOilPrice + Double.Parse(r.Cells(10).Value)
                                        End If
                                    End If
                                Next
                                .Cells(6).Value = Format(totalRicePrice, "###0.000")
                                .Cells(7).Value = Format(totalWhetPrice, "###0.000")
                                .Cells(8).Value = Format(totalAttaPrice, "###0.000")
                                .Cells(9).Value = Format(totalSugrPrice, "###0.000")
                                .Cells(10).Value = Format(totalKOilPrice, "###0.000")
                            End With
                            Dim style As DataGridViewCellStyle = New DataGridViewCellStyle
                            style.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
                            row.DefaultCellStyle = style
                        End If
                        delvDate = delvDate.AddDays(1)
                    End While
                    connection.Close()
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    MsgBox("Fatal Error: " + ex.Message + "->" + ex.StackTrace)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
        End Select
    End Sub

    Private Sub datagridRegister_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles datagridRegister.CellPainting
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        If e.RowIndex < 1 Or e.ColumnIndex < 0 Then
            Return
        End If
        If e.Value = Nothing Then
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            e.AdvancedBorderStyle.Top = datagridRegister.AdvancedCellBorderStyle.Top
        End If
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        ExportToExcel(datagridRegister)
    End Sub

    Private Sub ExportToExcel(ByVal DGV As DataGridView)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To DGV.ColumnCount - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(DGV.Columns(CLS).Name.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To DGV.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To DGV.ColumnCount - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = DGV.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()

            Dim DST As New DataSet
            DST.Tables.Add(DTB)
            Dim FLE As String = "C:\Users\kiran\Documents\TEXT.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
            DTB.WriteXml(FLE)
            Dim EXL As String = "C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
            Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Open the print dialog
        Dim printDialog As PrintDialog = New PrintDialog()
        printDialog.Document = PrintDocument1
        printDialog.UseEXDialog = True
        'Get the document
        If DialogResult.OK = printDialog.ShowDialog() Then
            PrintDocument1.DocumentName = "Test"
            PrintDocument1.Print()
        End If

        'Note: In case you want to show the Print Preview Dialog instead of 
        'Print Dialog then comment the above code And uncomment the following code

        'Open the print preview dialog
        'Dim objPPdialog As PrintPreviewDialog = New PrintPreviewDialog()
        'objPPdialog.Document = PrintDocument1
        'objPPdialog.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Try
            strFormat = New StringFormat()
            strFormat.Alignment = StringAlignment.Near
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter

            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            iRow = 0
            bFirstPage = True
            bNewPage = True

            ' Calculating Total Widths
            iTotalWidth = 0
            For Each dgvGridCol As DataGridViewColumn In datagridRegister.Columns
                iTotalWidth += dgvGridCol.Width
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Try
            'Set the left margin
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            'Set the top margin
            Dim iTopMargin As Integer = e.MarginBounds.Top
            'Whether more pages have to print or not
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0

            'For the first page to print set the cell width and header height
            If bFirstPage Then
                For Each GridCol As DataGridViewColumn In datagridRegister.Columns
                    iTmpWidth = CInt(Math.Floor(CDbl(CDbl(GridCol.Width) / CDbl(iTotalWidth) * CDbl(iTotalWidth) * (CDbl(e.MarginBounds.Width) / CDbl(iTotalWidth)))))

                    iHeaderHeight = CInt(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11

                    ' Save width and height of headers
                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin += iTmpWidth
                Next
            End If
            'Loop till all the grid rows not get printed
            While iRow <= datagridRegister.Rows.Count - 1
                Dim GridRow As DataGridViewRow = datagridRegister.Rows(iRow)
                'Set the cell height
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0
                'Check whether the current page settings allow more rows to print
                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    Exit While
                Else
                    If bNewPage Then
                        'Draw Header
                        e.Graphics.DrawString(regName, New Font(datagridRegister.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(regName, New Font(datagridRegister.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        Dim strDate As [String] = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString()
                        'Draw Date
                        e.Graphics.DrawString(strDate, New Font(datagridRegister.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(datagridRegister.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary", New Font(New Font(datagridRegister.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        'Draw Columns                 
                        iTopMargin = e.MarginBounds.Top
                        For Each GridCol As DataGridViewColumn In datagridRegister.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight), strFormat)
                            iCount += 1
                        Next
                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If
                    iCount = 0
                    'Draw Columns Contents                
                    For Each Cel As DataGridViewCell In GridRow.Cells
                        If Cel.Value IsNot Nothing Then
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font, New SolidBrush(Cel.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), CSng(iTopMargin), CInt(arrColumnWidths(iCount)), CSng(iCellHeight)), strFormat)
                        End If
                        'Drawing Cells Borders 
                        'Left
                        e.Graphics.DrawLine(Pens.Black, CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnLefts(iCount)), iTopMargin + iCellHeight)
                        'Right
                        e.Graphics.DrawLine(Pens.Black, CInt(arrColumnLefts(iCount)) + CInt(arrColumnWidths(iCount)), iTopMargin, CInt(arrColumnLefts(iCount)) + CInt(arrColumnWidths(iCount)), iTopMargin + iCellHeight)
                        'Top
                        If Cel.Value IsNot Nothing Then
                            e.Graphics.DrawLine(Pens.Black, CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnLefts(iCount)) + CInt(arrColumnWidths(iCount)), iTopMargin)
                        End If
                        'e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iCellHeight))
                        iCount += 1
                    Next
                End If
                iRow += 1
                iTopMargin += iCellHeight
            End While

            'If more lines exist, print another page.
            If bMorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class