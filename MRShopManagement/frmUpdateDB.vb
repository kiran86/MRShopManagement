Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class frmUpdateDB
    Private Sub frmUpdateDB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Enabled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtbxFileLoc.Text = OpenFileDialog1.FileName
            btnLoad.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim filePath = txtbxFileLoc.Text
        Try
            Using doc As SpreadsheetDocument = SpreadsheetDocument.Open(filePath, False)
                Dim wbPart As WorkbookPart = doc.WorkbookPart
                Dim sheets = wbPart.Workbook.Descendants(Of Sheet)()
                Dim newBenfSheet As Worksheet
                For Each sheet In sheets
                    If sheet.Name.ToString = "RC Added" Then
                        newBenfSheet = DirectCast(wbPart.GetPartById(sheet.Id), WorksheetPart).Worksheet
                        Exit For
                    End If
                Next
                Dim rows As List(Of Row)
                If newBenfSheet IsNot Nothing Then
                    Console.WriteLine(newBenfSheet.Count)
                    Dim sheetData = newBenfSheet.Elements(Of SheetData).First()
                    rows = sheetData.Elements(Of Row).ToList()
                End If
                If rows.Count > 0 Then
                    Dim row = rows.First
                    For Each cell As Cell In row.Descendants(Of Cell)
                        Console.WriteLine(cell.InnerText)
                    Next
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class