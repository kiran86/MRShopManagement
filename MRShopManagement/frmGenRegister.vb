Imports Microsoft.Office.Interop
Public Class frmGenRegister
    Private regDate As String = ""
    Private regStock As Integer = 1
    Private regSale As Integer = 2

    Private Sub frmGenRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With System.DateTime.Today
            regDate = regDate + .Day.ToString + "-"
            regDate = regDate + .Month.ToString + "-"
            regDate = regDate + .Year.ToString
        End With
    End Sub
    Private Sub frmStockReg_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        frmMain.Enabled = True
        frmMain.BringToFront()
    End Sub

    Private Sub bttnBrowse_Click(sender As Object, e As EventArgs) Handles bttnBrowse.Click
        If ValidateForm(sender) Then
            SaveRegFileDialog.FileName = "RegisterBook_" + regDate + ".xls"
            If SaveRegFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtbxFileLoc.Text = SaveRegFileDialog.FileName
            End If
        End If
    End Sub

    Private Sub cmboxRegisterType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxRegisterType.SelectedIndexChanged
        If cmboxRegisterType.SelectedItem.ToString = "Sale" Then
            lblCategory.Visible = True
            cmboxCategory.Visible = True
        Else
            lblCategory.Visible = False
            cmboxCategory.Visible = False
        End If
    End Sub

    Private Sub bttnGenerate_Click(sender As Object, e As EventArgs) Handles bttnGenerate.Click
        If ValidateForm(sender) Then
            GenerateRegister(cmboxRegisterType.SelectedIndex, cmboxCategory.SelectedItem.ToString, txtbxFileLoc.Text)
        End If
    End Sub

    Private Function ValidateForm(ByVal sender As Object) As Boolean
        Dim flag As Boolean = False
        If cmboxRegisterType.SelectedIndex = -1 Then
            MsgBox("Select Register!")
        ElseIf cmboxRegisterType.SelectedIndex = 1 And cmboxCategory.SelectedIndex = -1 Then
            MsgBox("Select Category!")
        ElseIf DirectCast(sender, Button).Text = "Generate" And txtbxFileLoc.Text = "" Then
            MsgBox("Choose save file location!")
        Else
            flag = True
        End If
        Return flag
    End Function

    Private Sub GenerateRegister(ByVal RegType As Integer, ByVal Category As String, ByVal FileLoc As String)
        'Dim exlApp As Excel.Application
        'Dim exlWrkBk As Excel._Workbook
        'Dim exlWrkBks As Excel.Workbooks
        'Dim exlSheets As Excel.Sheets
        'Dim exlSheet As Excel._Worksheet
        'Dim exlRange As Excel.Range
        'Dim exlSheetName As String = ""
        'If RegType = regStock Then
        '    exlSheetName = "Stock"
        'ElseIf RegType = regSale Then
        '    exlSheetName = "Sale : " + Category
        'End If
        'Try
        '    exlApp = New Excel.Application()
        '    exlWrkBks = exlApp.Workbooks
        '    exlWrkBk = exlWrkBks.Add
        '    exlSheets = exlWrkBk.Sheets
        '    exlSheet = exlSheets(1)
        '    exlSheet.Name = exlSheetName

        '    exlSheet.Cells(1, 1) = "Date"
        '    exlSheet.Cells(1, 2) = "Category"
        '    exlSheet.Cells(1, 3) = "Comodity"
        '    exlSheet.Cells(1, 4) = "Opening Balance (in qt-kg-gms)"
        '    exlSheet.Cells(1, 5) = "Stock Received (in qt-kg-gms)"
        '    exlSheet.Cells(1, 6) = "Total Stock (in qt-kg-gms)"
        '    exlSheet.Cells(1, 7) = "Stock Sold (in qt-kg-gms)"
        '    exlSheet.Cells(1, 8) = "Handling Loss (in qt-kg-gms)"
        '    exlSheet.Cells(1, 9) = "Closing Balance (in qt-kg-gms)"
        '    exlSheet.Cells(1, 10) = "Sale Register Page Serial No"
        '    exlSheet.Cells(1, 11) = "Signature & Remarks of Inspector, F&S"

        '    exlApp.Visible = True
        '    exlApp.UserControl = True
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message + ":" + ex.StackTrace)
        'End Try

    End Sub
End Class