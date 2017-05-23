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
        RKSY_I
        RKSY_II
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

        datagridRegister.AutoGenerateColumns = False
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
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim sql As String

        Dim row As DataGridViewRow

        Dim startDate As Date
        Dim endDate As Date
        Dim delvDate As Date

        Dim minMemoNo As Integer
        Dim maxMemoNo As Integer
        Dim cashMemoNo As Integer

        Dim riceScale As Double
        Dim whetScale As Double
        Dim attaScale As Double
        Dim sugrScale As Double

        Dim riceUnit As String
        Dim whetUnit As String
        Dim attaUnit As String
        Dim sugrUnit As String

        datagridRegister.Rows.Clear()

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

        Try
            connection.Open()

            Sql = "SELECT MIN(Delivery), MAX(Delivery), MIN(CashMemoNo), MAX(CashMemoNo) FROM Delivery WHERE Category = '" + Category + "'"
            cmd = New OleDbCommand(Sql, connection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows And Not dr.IsDBNull(0) Then
                startDate = dr.GetDateTime(0)
                endDate = dr.GetDateTime(1)
                minMemoNo = dr.GetInt32(2)
                maxMemoNo = dr.GetInt32(3)
            End If

            Sql = "SELECT * FROM Allotment WHERE Category = '" + Category + "'"
            cmd = New OleDbCommand(Sql, connection)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Select Case Integer.Parse(dr(0).ToString)
                        Case 1
                            riceScale = dr.GetDouble(2)
                            riceUnit = dr.GetString(3)
                        Case 2
                            whetScale = dr.GetDouble(2)
                            whetUnit = dr.GetString(3)
                        Case 3
                            attaScale = dr.GetDouble(2)
                            attaUnit = dr.GetString(3)
                        Case 4
                            sugrScale = dr.GetDouble(2)
                            sugrUnit = dr.GetString(3)
                    End Select
                End While
            End If

            delvDate = startDate
            While delvDate.Date <> endDate.AddDays(1).Date
                Sql = "SELECT RCNo, CashMemoNo FROM Delivery WHERE Category = '" + Category + "' AND Delivery = #" + delvDate + "#"
                cmd = New OleDbCommand(Sql, connection)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read()
                        'row = New String() {delvDate.ToShortDateString, dr(0).ToString, dr(1).ToString, Category, Format(riceScale, "###0.000"), Format(whetScale, "###0.000"), Format(attaScale, "###0.000"), Format(sugrScale, "###0.000"), Format(riceScale, "###0.000")}
                        'datagridRegister.Rows.Add(row)
                        Dim rowID As Integer = datagridRegister.Rows.Add
                        row = datagridRegister.Rows(rowID)

                    End While
                End If
                'row = New String() {delvDate.ToShortDateString, "Total", "", Category, "", "", "", "", ""}
                'datagridRegister.Rows.Add(row)
                delvDate = delvDate.AddDays(1)
            End While

            connection.Close()


        Catch ex As Exception
            MsgBox("Fatal Error: " + ex.Message + "->" + ex.StackTrace)
        End Try

    End Sub

    Private Function IsCellValueEqual(ByVal row As Integer) As Boolean
        Dim flag As Boolean = False
        Dim cell1 As DataGridViewCell = datagridRegister.Rows(row).Cells(2)
        Dim cell2 As DataGridViewCell = datagridRegister.Rows(row - 1).Cells(2)

        If cell1.Value.ToString = String.Empty Or cell2.Value.ToString = String.Empty Then
            Return flag
        End If
        If Integer.Parse(cell1.Value.ToString) = Integer.Parse(cell2.Value.ToString()) Then
            flag = True
        End If
        Return flag
    End Function

    Private Sub datagridRegister_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles datagridRegister.CellPainting
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        If e.RowIndex < 1 Or e.ColumnIndex < 0 Then
            Return
        End If
        If IsCellValueEqual(e.RowIndex) Then
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            e.AdvancedBorderStyle.Top = datagridRegister.AdvancedCellBorderStyle.Top
        End If
    End Sub

    Private Sub datagridRegister_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagridRegister.CellFormatting
        If e.RowIndex = 0 Or Not e.ColumnIndex = 2 Then
            Return
        End If
        If IsCellValueEqual(e.RowIndex) Then
            e.Value = ""
        End If
        e.FormattingApplied = True
    End Sub
End Class