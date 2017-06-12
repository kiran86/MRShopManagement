Imports System.Data.OleDb

Public Class frmUpdateAllotment
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection

    Private Sub frmUpdateAllotment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString

        LoadAllotmentData("AAY")
    End Sub

    Private Sub frmUpdateAllotment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub LoadAllotmentData(category As String)
        Dim sql As String = "SELECT * FROM Stock WHERE Category = '" & category & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        For Each table As String In {"Stock", "Allotment", "Pricing"}
            sql = "SELECT * FROM " & table & " WHERE Category = '" & category & "'"
            Console.WriteLine(sql)
            Try
                connection.Open()
                cmd = New OleDbCommand(sql, connection)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        UpdateControls(table, dr)
                    End While
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        Next
    End Sub

    Private Sub UpdateControls(table As String, dr As OleDbDataReader)
        Dim controlName As String = "txtbx"
        Dim txtbxControl As TextBox
        Select Case Integer.Parse(dr("ProductID").ToString)
            Case 1
                controlName = controlName & "Rice"
            Case 2
                controlName = controlName & "Wht"
            Case 3
                controlName = controlName & "Atta"
            Case 4
                controlName = controlName & "Sugar"
        End Select
        controlName = controlName & table
        Console.WriteLine(controlName)
        txtbxControl = Me.Controls.Find(controlName, True)(0)
        txtbxControl.Text = dr.GetDouble(2)
    End Sub
End Class