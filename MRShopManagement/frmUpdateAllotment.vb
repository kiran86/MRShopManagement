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

    Private Sub TextBox_Validating(sender As Object, e As EventArgs) Handles txtbxRiceStock.Validating, txtbxWhtStock.Validating, txtbxAttaStock.Validating, txtbxWhtPricing.Validating, txtbxWhtAllotment.Validating, txtbxSugarStock.Validating, txtbxSugarPricing.Validating, txtbxSugarAllotment.Validating, txtbxRicePricing.Validating, txtbxRiceAllotment.Validating, txtbxAttaPricing.Validating, txtbxAttaAllotment.Validating, txtbxKOilStock.Validating, txtbxKOilPricing.Validating, txtbxKOilAllotment.Validating
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
        Dim sql As String
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
        Dim chkbxName As String = "chkbx"
        Dim txtbxControl As TextBox
        Dim cmbxControl As ComboBox
        Dim chkbxControl As CheckBox
        Select Case Integer.Parse(dr("ProductID").ToString)
            Case 1
                txtbxName = txtbxName & "Rice"
                cmbxName = cmbxName & "Rice"
                chkbxName = chkbxName & "Rice"
            Case 2
                txtbxName = txtbxName & "Wht"
                cmbxName = cmbxName & "Wht"
                chkbxName = chkbxName & "Wht"
            Case 3
                txtbxName = txtbxName & "Atta"
                cmbxName = cmbxName & "Atta"
                chkbxName = chkbxName & "Atta"
            Case 4
                txtbxName = txtbxName & "Sugar"
                cmbxName = cmbxName & "Sugar"
                chkbxName = chkbxName & "Sugar"
            Case 5
                txtbxName = txtbxName & "KOil"
                cmbxName = cmbxName & "KOil"
                chkbxName = chkbxName & "KOil"
        End Select
        If table IsNot "Stock" And dr.GetDouble(2) = 0.0 Then
            chkbxControl = Me.Controls.Find(chkbxName, True)(0)
            chkbxControl.Checked = False
        End If
        txtbxName = txtbxName & table
        txtbxControl = Me.Controls.Find(txtbxName, True)(0)

        If txtbxControl.Name.Contains("Pricing") Then
            txtbxControl.Text = String.Format("{0:n2}", dr.GetDouble(2))
        Else
            txtbxControl.Text = String.Format("{0:n3}", dr.GetDouble(2))
        End If

        'txtbxControl.Text = dr.GetDouble(2)
        If table Is "Allotment" Then
            cmbxName = cmbxName & "Unit"
            cmbxControl = Me.Controls.Find(cmbxName, True)(0)
            cmbxControl.SelectedItem = dr.GetString(3)
        End If
    End Sub

    Private Sub lnklblClear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblClear.LinkClicked
        For Each control As Control In TableLayoutPanel1.Controls
            If TypeOf control Is TextBox Then
                control.Text = 0.0
            ElseIf TypeOf control Is CheckBox Then
                CType(control, CheckBox).Checked = False
            ElseIf TypeOf control Is ComboBox Then
                CType(control, ComboBox).SelectedIndex = 0
            End If
        Next
    End Sub

    Private Sub lnklblUpdate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblUpdate.LinkClicked

    End Sub

    Private Sub UpdateAllotmentData(category As String)
        Dim sql As String
        Dim updates As String
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        Dim txtbxName As String = "txtbx"
        Dim txtbxControl As TextBox
        Dim cmbxName As String = "cmbx"
        Dim cmbxControl As ComboBox
        For productID As Integer = 1 To 4
            For Each table As String In {"Stock", "Allotment", "Pricing"}
                sql = "UPDATE " & table & " SET "
                Select Case table
                    Case "Stock"
                        txtbxName = txtbxName & table
                        sql = sql & " Scale = "
                End Select
                sql = "UPDATE " & table & " WHERE Category = '" & category & "'"
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
        Next
    End Sub
End Class