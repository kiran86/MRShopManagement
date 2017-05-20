Imports System.Data.OleDb
Public Class frmViewSales
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    'Dim dataAdapter As OleDbDataAdapter
    'Dim dataSet As DataSet = New DataSet
    'Dim dataTable = dataSet.Tables
    'Dim bindingSource As New BindingSource
    'Dim sql
    'Dim view As DataView

    Dim categoryComboClicked As Boolean = False
    Dim datepickFromClicked As Boolean = False
    Dim datepickToClicked As Boolean = False

    Private Sub frmViewSales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Activate()
        frmMain.Show()
    End Sub

    Private Sub frmViewSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        LoadTable(categoryComboClicked, datepickFromClicked, datepickToClicked)
    End Sub

    Private Sub cmboxCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmboxCategory.SelectionChangeCommitted
        categoryComboClicked = True
        LoadTable(categoryComboClicked, datepickFromClicked, datepickToClicked)
    End Sub

    Private Sub dateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dateFrom.ValueChanged
        datepickFromClicked = True
        LoadTable(categoryComboClicked, datepickFromClicked, datepickToClicked)
    End Sub

    Private Sub dateTo_ValueChanged(sender As Object, e As EventArgs) Handles dateTo.ValueChanged
        datepickToClicked = True
        LoadTable(categoryComboClicked, datepickFromClicked, datepickToClicked)
    End Sub

    Private Sub bttnReset_Click(sender As Object, e As EventArgs) Handles bttnReset.Click
        categoryComboClicked = False
        datepickFromClicked = False
        datepickToClicked = False
        LoadTable(categoryComboClicked, datepickFromClicked, datepickToClicked)
    End Sub

    Private Sub LoadTable(isCategorySet As Boolean, isFromDateSet As Boolean, isToDateSet As Boolean)

        Dim dataAdapter As OleDbDataAdapter
        Dim dataSet As DataSet = New DataSet
        Dim dataTable = dataSet.Tables
        Dim bindingSource As New BindingSource
        Dim sql
        Dim view As DataView

        datagridRegister.DataSource = DBNull.Value
        dataSet.Clear()

        sql = "SELECT Beneficiaries.*, Delivery.Delivery FROM Beneficiaries, Delivery WHERE ((Delivery.RCNo)=(Beneficiaries.RCNo))"

        If isCategorySet And cmboxCategory.SelectedIndex <> 0 Then
            sql = sql + " AND Beneficiaries.Category = '" + cmboxCategory.SelectedItem.ToString + "'"
        End If
        If isFromDateSet Or isToDateSet Then
            sql = sql + " AND Delivery.Delivery BETWEEN #" + dateFrom.Text + "# AND #" + dateTo.Text + "#"
        End If
        dataAdapter = New OleDbDataAdapter(sql, connection)
        dataAdapter.Fill(dataSet, OleDbDataAdapter.DefaultSourceTableName)
        view = New DataView(dataTable(0))
        bindingSource.DataSource = view
        datagridRegister.DataSource = view
    End Sub
End Class