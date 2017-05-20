Imports System.Data.OleDb

Public Class frmMain
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "C:\Users\kiran\OneDrive\Documents\Visual Studio 2010\Projects\MRShopManagement\MRShopManagement\data\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            connection.Open()
            Dim sql As String
            sql = "SELECT * FROM Beneficiaries WHERE RCNo = " & txtbxCardNo.Text
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MsgBox("No matching data find", MsgBoxStyle.OkOnly, "Error")
            Else
                While dr.Read
                    txtbxName.Text = dr("Name").ToString
                    txtbxGender.Text = dr("Gender").ToString
                    txtbxHoF.Text = dr("HoFName").ToString
                End While
                sql = "SELECT RCNo, Category, Name, Gender, Age FROM Beneficiaries WHERE HoFName = '" & txtbxHoF.Text & "'"
                cmd = New OleDbCommand(sql, connection)
                dr = cmd.ExecuteReader
                Dim dt = New DataTable
                dt.Load(dr)
                dgvFamilyData.AutoGenerateColumns = True
                dgvFamilyData.DataSource = dt
                dgvFamilyData.AutoResizeColumns()
                dgvFamilyData.Refresh()
            End If
        Catch ex As Exception
            MsgBox("Some error occured! Quiting...", MsgBoxStyle.OkOnly, "Error")
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        connection.Close()
    End Sub
    
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstvwRcNos.Items.Add(dgvFamilyData.CurrentCell.Value.ToString)
        lstvwRcNos.Items(0).SubItems.Add(dgvFamilyData.CurrentRow.Cells("Name").Value.ToString)
        lstvwRcNos.Items(0).SubItems.Add(dgvFamilyData.CurrentRow.Cells("Category").Value.ToString)
        lstvwRcNos.Ite()
    End Sub

    Private Sub btnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAll.Click
        Dim i As Integer
        For i = 0 To dgvFamilyData.RowCount - 2
            lstvwRcNos.Items.Add(dgvFamilyData.Rows(i).Cells("RCNo").Value.ToString)
        Next
    End Sub
End Class
