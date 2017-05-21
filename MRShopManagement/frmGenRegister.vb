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

    Private Enum Products
        Rice
        Wheat
        Atta
        Sugar
    End Enum

    Private Enum Category
        AAY
        PHH
        SPHH
        RKSYI
        RKSYII
    End Enum

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
    End Sub
    Private Sub frmStockReg_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        frmMain.Enabled = True
        frmMain.BringToFront()
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
        Dim dataAdapter As OleDbDataAdapter
        Dim dataSet As DataSet = New DataSet
        Dim dataTable = dataSet.Tables
        Dim bindingSource As New BindingSource
        Dim sql As String
        Dim dataview As DataView
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        Dim startDate As Date
        Dim endDate As Date
        Dim delvDate As Date

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

        dataSet.Clear()
        Try
            connection.Open()

            sql = "SELECT MIN(Delivery) FROM Delivery WHERE Delivery IS NOT NULL"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows And Not dr.IsDBNull(0) Then
                startDate = dr.GetDateTime(0)
            End If
            sql = "SELECT MAX(Delivery) FROM Delivery WHERE Delivery IS NOT NULL"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            dr.Read
            If dr.HasRows And Not dr.IsDBNull(0) Then
                dr.Read()
                endDate = dr.GetDateTime(0).ToShortDateString
            End If



            connection.Close()
        Catch ex As Exception
            MsgBox("Fatal Error: " + ex.Message)
        End Try

    End Sub
End Class