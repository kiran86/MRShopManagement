Imports System.Data.OleDb

Public Class frmAllotment
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim TextBoxArray() As TextBox
    Dim ComboBoxArray() As ComboBox

    Private Sub frmAllotment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        ReDim TextBoxArray(4)
        TextBoxArray(0) = txtbxRice
        TextBoxArray(1) = txtbxWheat
        TextBoxArray(2) = txtbxAtta
        TextBoxArray(3) = txtbxSugar
        ReDim ComboBoxArray(4)
        ComboBoxArray(0) = cmboxUnitRice
        ComboBoxArray(1) = cmboxUnitWheat
        ComboBoxArray(2) = cmboxUnitAtta
        ComboBoxArray(3) = cmboxUnitSugar
    End Sub

    Private Sub frmAllotment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
        Me.Dispose()
        frmMain.Enabled = True
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Dim evt As FormClosedEventArgs
        frmAllotment_FormClosed(sender, evt)
    End Sub

    Private Sub cmboxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxCategory.SelectedIndexChanged
        LoadStockValues(cmboxCategory.SelectedItem)
    End Sub

    Private Sub bttnUpdate_Click(sender As Object, e As EventArgs) Handles bttnUpdate.Click
        UpdateStockValues(cmboxCategory.SelectedItem)
    End Sub

    Private Sub LoadStockValues(category As String)
        connection.Open()
        Dim sql = "SELECT Allotment.* FROM Allotment WHERE Category = '" + category + "'"
        Dim cmd = New OleDbCommand(sql, connection)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            txtbxRice.Text = ""
            txtbxWheat.Text = ""
            txtbxAtta.Text = ""
            txtbxSugar.Text = ""
            MsgBox("No matching data found", MsgBoxStyle.OkOnly, "Error")
        Else
            While dr.Read
                Select Case Integer.Parse(dr("ProductID").ToString)
                    Case 1
                        txtbxRice.Text = String.Format("{0:0.000}", dr("Scale"))
                        cmboxUnitRice.SelectedItem = dr("Unit").ToString
                    Case 2
                        txtbxWheat.Text = String.Format("{0:0.000}", dr("Scale"))
                        cmboxUnitWheat.SelectedItem = dr("Unit").ToString
                    Case 3
                        txtbxAtta.Text = String.Format("{0:0.000}", dr("Scale"))
                        cmboxUnitAtta.SelectedItem = dr("Unit").ToString
                    Case 4
                        txtbxSugar.Text = String.Format("{0:0.000}", dr("Scale"))
                        cmboxUnitSugar.SelectedItem = dr("Unit").ToString
                End Select
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
            sql = "UPDATE Allotment SET Scale = " + TextBoxArray(i).Text + ", Unit = '" + ComboBoxArray(i).SelectedItem + "' WHERE Category = '" + category + "' AND ProductID = " + (i + 1).ToString
            cmd = New OleDbCommand(sql, connection)
            If cmd.ExecuteNonQuery() < 0 Then
                Exit For
            End If
        Next
        If i <> 4 Then
            MessageBox.Show("Some Error Occurred!")
        Else
            MessageBox.Show("Allotment Updated!")
        End If
        connection.Close()
    End Sub
End Class