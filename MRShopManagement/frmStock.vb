Imports System.Data.OleDb

Public Class frmStock
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim TextBoxArray() As TextBox

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        ReDim TextBoxArray(3)
        TextBoxArray(0) = txtbxRice
        TextBoxArray(1) = txtbxWheat
        TextBoxArray(2) = txtbxAtta
        TextBoxArray(3) = txtbxSugar
    End Sub

    Private Sub frmStock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Enabled = True
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmboxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxCategory.SelectedIndexChanged
        LoadStockValues(cmboxCategory.SelectedItem)
    End Sub

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click
        UpdateStockValues(cmboxCategory.SelectedItem)
    End Sub

    Private Sub LoadStockValues(category As String)
        connection.Open()
        Dim sql = "SELECT Stock.* FROM Stock WHERE Category = '" + category + "'"
        Dim cmd = New OleDbCommand(sql, connection)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            txtbxRice.Text = ""
            txtbxWheat.Text = ""
            txtbxAtta.Text = ""
            txtbxSugar.Text = ""
            MsgBox(sql + "No matching data found", MsgBoxStyle.OkOnly, "Error")
        Else
            While dr.Read
                If Integer.Parse(dr("ProductID").ToString) = 1 Then
                    txtbxRice.Text = String.Format("{0:0.000}", dr("Scale"))
                End If
                If Integer.Parse(dr("ProductID").ToString) = 2 Then
                    txtbxWheat.Text = String.Format("{0:0.000}", dr("Scale"))
                End If
                If Integer.Parse(dr("ProductID").ToString) = 3 Then
                    txtbxAtta.Text = String.Format("{0:0.000}", dr("Scale"))
                End If
                If Integer.Parse(dr("ProductID").ToString) = 4 Then
                    txtbxSugar.Text = String.Format("{0:0.000}", dr("Scale"))
                End If
            End While
        End If
        connection.Close()
    End Sub

    Private Sub UpdateStockValues(category As String)
        connection.Open()
        Dim sql As String
        Dim cmd As OleDbCommand
        Dim i As Integer
        For i = 0 To 3
            sql = "UPDATE Stock SET Scale = " + TextBoxArray(i).Text + " WHERE Category = '" + category + "' AND ProductID = " + (i + 1).ToString
            cmd = New OleDbCommand(sql, connection)
            If cmd.ExecuteNonQuery() < 0 Then
                Exit For
            End If
        Next
        If i <> 4 Then
            MessageBox.Show("Some Error Occurred!")
        Else
            MessageBox.Show("Stock Updated!")
        End If
        connection.Close()
    End Sub

    Private Sub bttnReset_Click(sender As Object, e As EventArgs) Handles bttnReset.Click
        txtbxRice.Text = 0.000
        txtbxWheat.Text = 0.000
        txtbxAtta.Text = 0.000
        txtbxSugar.Text = 0.000
    End Sub
End Class