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

        rdobtnAAY.Select()
    End Sub

    Private Sub frmUpdateAllotment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtbxRiceStock.TextChanged, txtbxWhtStock.TextChanged, txtbxAttaStock.TextChanged, txtbxWhtPricing.TextChanged, txtbxWhtAllotment.TextChanged, txtbxSugarStock.TextChanged, txtbxSugarPricing.TextChanged, txtbxSugarAllotment.TextChanged, txtbxRicePricing.TextChanged, txtbxRiceAllotment.TextChanged, txtbxAttaPricing.TextChanged, txtbxAttaAllotment.TextChanged
        Dim txtbxControl As TextBox = CType(sender, TextBox)
        If txtbxControl.Name.Contains("Pricing") Then
            txtbxControl.Text = String.Format("{0:n2}", Double.Parse(txtbxControl.Text))
        Else
            txtbxControl.Text = String.Format("{0:n3}", Double.Parse(txtbxControl.Text))
        End If
    End Sub

    Private Sub RadioButton_SelectionChange(sender As Object, e As EventArgs) Handles rdobtnAAY.CheckedChanged, rdobtnPHH.CheckedChanged, rdobtnSPHH.CheckedChanged, rdobtnRKSYI.CheckedChanged, rdobtnRKSYII.CheckedChanged
        Dim rdobtnCategory As RadioButton = CType(sender, RadioButton)
        LoadAllotmentData(rdobtnCategory.Text)
    End Sub

    Private Sub LoadAllotmentData(category As String)
        Dim sql As String = "SELECT * FROM Stock WHERE Category = '" & category & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        For Each table As String In {"Stock", "Allotment", "Pricing"}
            sql = "SELECT * FROM " & table & " WHERE Category = '" & category & "'"
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
        Dim txtbxName As String = "txtbx"
        Dim cmbxName As String = "cmbx"
        Dim txtbxControl As TextBox
        Dim cmbxControl As ComboBox
        Select Case Integer.Parse(dr("ProductID").ToString)
            Case 1
                txtbxName = txtbxName & "Rice"
                cmbxName = cmbxName & "Rice"
            Case 2
                txtbxName = txtbxName & "Wht"
                cmbxName = cmbxName & "Wht"
            Case 3
                txtbxName = txtbxName & "Atta"
                cmbxName = cmbxName & "Atta"
            Case 4
                txtbxName = txtbxName & "Sugar"
                cmbxName = cmbxName & "Sugar"
        End Select
        txtbxName = txtbxName & table
        txtbxControl = Me.Controls.Find(txtbxName, True)(0)
        txtbxControl.Text = dr.GetDouble(2)
        If table Is "Allotment" Then
            cmbxName = cmbxName & "Unit"
            cmbxControl = Me.Controls.Find(cmbxName, True)(0)
            cmbxControl.SelectedItem = dr.GetString(3)
        End If
    End Sub
End Class