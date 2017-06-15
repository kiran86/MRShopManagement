Imports System.Data.OleDb

Public Class frmGenRegister
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private regDate As String = ""
    Private regStock As Integer = 0
    Private regSale As Integer = 1

    Private strFormat As StringFormat       'Used to format the grid rows.
    Private arrColumnLefts As New ArrayList()     'Used to save left coordinates of columns
    Private arrColumnWidths As New ArrayList()    'Used to save column widths
    Private iCellHeight As Integer = 0      'Used To Get/Set the datagridview cell height
    Private iTotalWidth As Integer = 0      '
    Private iRow As Integer = 0             'Used As counter
    Private bFirstPage As Boolean = False   'Used To check whether we are printing first page
    Private bNewPage As Boolean = False     'Used To check whether we are printing a New page
    Private iHeaderHeight = 0               'Used for the header height

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

        Dim noHead As Integer = 1
        Dim totalHead As Integer = 0
        Dim totalFamily As Integer = 0

        Dim totalRicePrice As Double = 0.0
        Dim totalWhetPrice As Double = 0.0
        Dim totalAttaPrice As Double = 0.0
        Dim totalSugrPrice As Double = 0.0

        Dim riceScale As Double
        Dim whetScale As Double
        Dim attaScale As Double
        Dim sugrScale As Double

        Dim riceUnit As String
        Dim whetUnit As String
        Dim attaUnit As String
        Dim sugrUnit As String

        datagridRegister.Rows.Clear()
        datagridRegister.Columns.Clear()

        Select Case RegType
            Case regStock

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
                End With
        End Select

        Try
            connection.Open()

            sql = "SELECT MIN(Delivery), MAX(Delivery) FROM Delivery WHERE Category = '" + Category + "'"
            cmd = New OleDbCommand(Sql, connection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows And Not dr.IsDBNull(0) Then
                startDate = dr.GetDateTime(0).Date
                endDate = dr.GetDateTime(1).Date
            End If

            sql = "SELECT * FROM Allotment WHERE Category = '" + Category + "'"
            cmd = New OleDbCommand(Sql, connection)
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
                    End Select
                End While
            End If
            Console.WriteLine(DateTime.ParseExact("03/12/2017 23:59:59", "dd/MM/yyyy HH:mm:ss", Nothing))
            delvDate = startDate
            While delvDate <> endDate.AddDays(1)
                totalHead = 0
                totalFamily = 0
                totalRicePrice = 0
                totalWhetPrice = 0
                totalAttaPrice = 0
                totalSugrPrice = 0
                sql = "SELECT RCNo, CashMemoNo FROM Delivery WHERE Category = '" + Category + "' AND Delivery BETWEEN #" + DateTime.ParseExact(delvDate.ToShortDateString & " 00:00:00", "dd/MM/yyyy HH:mm:ss", Nothing) + "# AND #" + DateTime.ParseExact(delvDate.ToShortDateString & " 23:59:59", "dd/MM/yyyy HH:mm:ss", Nothing) + "# ORDER BY CashMemoNo ASC"
                Console.WriteLine(sql)
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
                            End If
                        Next
                        .Cells(6).Value = Format(totalRicePrice, "###0.000")
                        .Cells(7).Value = Format(totalWhetPrice, "###0.000")
                        .Cells(8).Value = Format(totalAttaPrice, "###0.000")
                        .Cells(9).Value = Format(totalSugrPrice, "###0.000")
                    End With
                    Dim style As DataGridViewCellStyle = New DataGridViewCellStyle
                    style.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
                    row.DefaultCellStyle = style
                End If
                delvDate = delvDate.AddDays(1)
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox("Fatal Error: " + ex.Message + "->" + ex.StackTrace)
        End Try
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
        'If datagridRegister.RowCount > 0 Then
        '    Dim fileName As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Sale_Reg_" + cmboxCategory.SelectedItem.ToString + "_" + Format(Now, "dd-MM-yyyy").ToString + ".xls"
        '    datagridRegister.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        '    datagridRegister.SelectAll()
        '    IO.File.WriteAllText(fileName, datagridRegister.GetClipboardContent.GetText.TrimEnd)
        '    datagridRegister.ClearSelection()
        '    Process.Start(fileName)
        'End If
        ExportToExcel()
    End Sub

    Private Sub ExportToExcel()
        Dim familyMember As Integer = 0
        ' Choose the path, name, and extension for the Excel file
        Dim myFile As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Sale_Reg_" + cmboxCategory.SelectedItem.ToString + "_" + Format(Now, "dd-MM-yyyy").ToString + ".xls"
        ' Open the file and write the headers
        Dim fs As New IO.StreamWriter(myFile, False)
        Try
            fs.WriteLine("<?xml version=""1.0""?>")
            fs.WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            fs.WriteLine("<ss:Workbook xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")

            ' Create the styles for the worksheet
            fs.WriteLine("  <ss:Styles>")
            ' Style for the column headers
            fs.WriteLine("    <ss:Style ss:ID=""1"">")
            fs.WriteLine("      <ss:Font ss:Bold=""1""/>")
            fs.WriteLine("      <ss:Alignment ss:Horizontal=""Center"" ss:Vertical=""Center"" " & "ss:WrapText=""1""/>")
            fs.WriteLine("      <ss:Interior ss:Color=""#C0C0C0"" ss:Pattern=""Solid""/>")
            fs.WriteLine("    </ss:Style>")
            ' Styles for the column information
            fs.WriteLine("    <ss:Style ss:ID=""2"">")
            fs.WriteLine("      <ss:Alignment ss:Vertical=""Center"" ss:WrapText=""1""/>")
            fs.WriteLine("    </ss:Style>")
            fs.WriteLine("  </ss:Styles>")

            ' Write the worksheet contents

            fs.WriteLine("<ss:Worksheet ss:Name=""Sheet1"">")
            fs.WriteLine("  <ss:Table>")

            For i As Integer = 0 To datagridRegister.Columns.Count - 1
                fs.WriteLine(String.Format("    <ss:Column ss:Width=""{0}""/>", datagridRegister.Columns.Item(i).Width))
            Next

            fs.WriteLine("    <ss:Row>")
            For i As Integer = 0 To datagridRegister.Columns.Count - 1
                If datagridRegister.Columns(i).Visible Then
                    fs.WriteLine(String.Format("      <ss:Cell ss:StyleID=""1"">" & "<ss:Data ss:Type=""String"">{0}</ss:Data></ss:Cell>",
                        datagridRegister.Columns.Item(i).HeaderText))
                End If
            Next
            fs.WriteLine("    </ss:Row>")

            '' Check for an empty row at the end due to Adding allowed on the DataGridView
            Dim subtractBy As Integer, cellText As String
            If datagridRegister.AllowUserToAddRows = True Then subtractBy = 2 Else subtractBy = 1
            ' Write contents for each cell
            For i As Integer = 0 To datagridRegister.RowCount - subtractBy
                If datagridRegister.Rows(i).Visible Then
                    fs.WriteLine(String.Format("    <ss:Row ss:Height=""{0}"">", datagridRegister.Rows(i).Height))
                    For intCol As Integer = 0 To datagridRegister.Columns.Count - 1
                        If datagridRegister.Columns(intCol).Visible And Not datagridRegister.Item(intCol, i).Value = Nothing Then
                            cellText = datagridRegister.Item(intCol, i).Value.ToString
                            ' Check for null cell and change it to empty to avoid error
                            If cellText = vbNullString Then cellText = ""
                            Select Case intCol
                                Case 0, 1, 3
                                    fs.WriteLine(String.Format("      <ss:Cell ss:StyleID=""2"">" & "<ss:Data ss:Type=""String"">{0}</ss:Data></ss:Cell>", cellText.ToString))
                                Case 2, 4, 5
                                    If Not datagridRegister.Item(1, i).Value.ToString = "Total" Then familyMember = datagridRegister.Item(5, i).Value - 1 Else familyMember = 0
                                    Console.WriteLine(familyMember)
                                    fs.WriteLine(String.Format("      <ss:Cell ss:MergeDown=""{0}"" ss:StyleID=""2"">" & "<ss:Data ss:Type=""String"">{1}</ss:Data></ss:Cell>", familyMember, cellText.ToString))
                                Case 6, 7, 8, 9
                                    fs.WriteLine(String.Format("      <ss:Cell ss:StyleID=""2"">" & "<ss:Data ss:Type=""String"">{0}</ss:Data></ss:Cell>", cellText.ToString))
                            End Select
                        End If
                    Next
                    fs.WriteLine("    </ss:Row>")
                End If
            Next

            '' Close up the document
            fs.WriteLine("  </ss:Table>")
            fs.WriteLine("</ss:Worksheet>")
            fs.WriteLine("</ss:Workbook>")
            fs.Close()
            Process.Start(myFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ":" & ex.StackTrace, "ERROR: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Err.Clear()
        Finally
            myFile = Nothing
            fs = Nothing
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
            iCount = 0
            bFirstPage = True
            bNewPage = True

            ' Calculating Total Widths
            iTotalWidth = 0
            For Each dgvGridCol As DataGridViewColumn In dataGridView1.Columns
                iTotalWidth += dgvGridCol.Width
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class