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

        datagridRegister.AutoGenerateColumns = True
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
        Dim rowID As Integer
        Dim parentRowID As Integer

        Dim startDate As Date
        Dim endDate As Date
        Dim delvDate As Date

        Dim noHead As Integer = 1
        Dim totalHead As Integer = 0
        Dim totalFamily As Integer = 0

        Dim totalRicePrice As Double = 0.0
        Dim totalWhetPrice As Double = 0.0
        Dim totalAttaPrice As Double = 0.0
        Dim totalSugrPrice As Double = 0.0

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

            sql = "SELECT MIN(Delivery), MAX(Delivery) FROM Delivery WHERE Category = '" + Category + "'"
            cmd = New OleDbCommand(Sql, connection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows And Not dr.IsDBNull(0) Then
                startDate = dr.GetDateTime(0)
                endDate = dr.GetDateTime(1)
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
                totalHead = 0
                totalFamily = 0
                totalRicePrice = 0
                totalWhetPrice = 0
                totalAttaPrice = 0
                totalSugrPrice = 0
                sql = "SELECT RCNo, CashMemoNo FROM Delivery WHERE Category = '" + Category + "' AND Delivery = #" + delvDate + "#"
                cmd = New OleDbCommand(Sql, connection)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read()
                        rowID = datagridRegister.Rows.Add
                        totalHead = totalHead + 1
                        row = datagridRegister.Rows(rowID)
                        With row
                            .Cells(0).Value = delvDate.ToShortDateString
                            .Cells(1).Value = dr(0).ToString
                            If rowID = 0 Then
                                parentRowID = rowID
                                totalFamily = totalFamily + 1
                                .Cells(2).Value = dr.GetInt32(1)
                                .Cells(4).Value = 1
                                .Cells(5).Value = noHead
                            ElseIf dr.GetInt32(1) = datagridRegister.Rows(parentRowID).Cells(2).Value Then
                                '.Cells(2).Value = 
                                '.Cells(4).Value =
                                '.Cells(5).Value = 
                                noHead = noHead + 1
                                datagridRegister.Rows(parentRowID).Cells(5).Value = noHead
                            Else
                                parentRowID = rowID
                                totalFamily = totalFamily + 1
                                noHead = 1
                                .Cells(2).Value = dr.GetInt32(1)
                                .Cells(4).Value = 1
                                .Cells(5).Value = noHead
                            End If
                            .Cells(3).Value = Category
                            If parentRowID = rowID Then
                                .Cells(6).Value = Format(riceScale, "###0.000")
                                .Cells(7).Value = Format(whetScale, "###0.000")
                                .Cells(8).Value = Format(attaScale, "###0.000")
                                .Cells(9).Value = Format(sugrScale, "###0.000")
                            Else
                                If riceUnit = "Head" Then
                                    .Cells(6).Value = Format(riceScale, "###0.000")
                                End If
                                If whetUnit = "Head" Then
                                    .Cells(7).Value = Format(whetScale, "###0.000")
                                End If
                                If attaUnit = "Head" Then
                                    .Cells(8).Value = Format(attaScale, "###0.000")
                                End If
                                If sugrUnit = "Head" Then
                                    .Cells(9).Value = Format(sugrScale, "###0.000")
                                End If
                            End If
                        End With
                    End While

                    rowID = datagridRegister.Rows.Add
                    row = datagridRegister.Rows(rowID)
                    With row
                        .Cells(0).Value = delvDate.ToShortDateString
                        .Cells(1).Value = "Total"
                        .Cells(2).Value = "-"
                        .Cells(3).Value = Category
                        .Cells(4).Value = totalFamily
                        .Cells(5).Value = totalHead
                        For Each r As DataGridViewRow In datagridRegister.Rows
                            If r.Cells(0).Value = .Cells(0).Value And Not r.Index = rowID Then
                                If Not r.Cells(6).Value = Nothing Then
                                    totalRicePrice = totalRicePrice + Double.Parse(r.Cells(6).Value)
                                End If
                                If Not r.Cells(7).Value = Nothing Then
                                    totalWhetPrice = totalWhetPrice + Double.Parse(r.Cells(7).Value)
                                End If
                                If Not r.Cells(8).Value = Nothing Then
                                    totalAttaPrice = totalAttaPrice + Double.Parse(r.Cells(8).Value)
                                End If
                                If Not r.Cells(9).Value = Nothing Then
                                    totalSugrPrice = totalSugrPrice + Double.Parse(r.Cells(9).Value)
                                End If
                            End If
                        Next
                        .Cells(6).Value = Format(totalRicePrice, "###0.000")
                        .Cells(7).Value = Format(totalWhetPrice, "###0.000")
                        .Cells(8).Value = Format(totalAttaPrice, "###0.000")
                        .Cells(9).Value = Format(totalSugrPrice, "###0.000")
                    End With
                End If

                delvDate = delvDate.AddDays(1)
            End While
            connection.Close()
        Catch ex As Exception
            MsgBox("Fatal Error: " + ex.Message + "->" + ex.StackTrace)
        End Try

    End Sub

    Private Sub datagridRegister_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles datagridRegister.CellPainting
        e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        If e.RowIndex < 1 Or e.ColumnIndex < 0 Then
            Return
        End If
        If e.Value = Nothing Then
            e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            e.AdvancedBorderStyle.Top = datagridRegister.AdvancedCellBorderStyle.Top
        End If
    End Sub

    Private Sub datagridRegister_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagridRegister.CellFormatting
        'If e.RowIndex = 0 Then
        '    Return
        'End If
        'If IsCellValueEqual(e.RowIndex, e.ColumnIndex) Then
        '    e.Value = ""
        'End If
        'e.FormattingApplied = True
    End Sub
End Class