Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class frmMain
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Dim totalHead = 0
    Dim totalRice = 0.0
    Dim totalRicePrice = 0.0
    Dim totalWheat = 0.0
    Dim totalWheatPrice = 0.0
    Dim totalAtta = 0.0
    Dim totalAttaPrice = 0.0
    Dim totalSugar = 0.0
    Dim totalSugarPrice = 0.0
    Dim totalKOil = 0.0
    Dim totalKOilPrice = 0.0
    Dim totalPrice = 0.0


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DeliveryDate As String
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString

        DeliveryDate = Now.ToShortDateString
        SetMemoNo()
        Dim customFont As PrivateFontCollection = New PrivateFontCollection
        customFont.AddFontFile("Fonts/digital-7.ttf")
        lblSystemDateTime.Font = New Font(customFont.Families(0), 16, FontStyle.Regular)
        timerSystemDateTime.Start()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim lastDelvDate As Date = Date.Now
        Try
            connection.Open()
            Dim sql As String = "SELECT MAX(Delivery) FROM Delivery"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                lastDelvDate = dr.GetDateTime(0)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        If Now.AddDays(-4).Date >= lastDelvDate.Date Then
            If MsgBox("Looks like its a new week. Clear previous deliveries?", MsgBoxStyle.YesNo, "New Week") = MsgBoxResult.Yes Then
                ClearDelivery()
            End If
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        lstvwFamily.Clear()
        lstvwRcNos.Clear()
        totalHead = 0
        totalRice = 0.0
        totalRicePrice = 0.0
        totalWheat = 0.0
        totalWheatPrice = 0.0
        totalAtta = 0.0
        totalAttaPrice = 0.0
        totalSugar = 0.0
        totalSugarPrice = 0.0
        totalKOil = 0.0
        totalKoilPrice = 0.0
        totalPrice = 0.0
        If Not txtbxCardNo.Text.Equals("") And IsNumeric(txtbxCardNo.Text) Then
            LoadData()
        End If
    End Sub

    Private Sub SetMemoNo()
        Try
            connection.Open()
            Dim memoNo As Integer
            Dim sql As String = "SELECT MAX(CashMemoNo) FROM Delivery"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Console.WriteLine(dr.IsDBNull(0))
                If Not dr.IsDBNull(0) Then
                    memoNo = dr.GetInt32(0) + 1
                Else
                    memoNo = 1
                End If
            Else
                memoNo = 1
            End If
            txtbxCashMemoNo.Text = memoNo
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadData()
        Dim familyID As String = ""
        Try
            connection.Open()
            Dim sql As String
            sql = "SELECT * FROM Beneficiaries WHERE RCNo = " & txtbxCardNo.Text
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MsgBox("No matching data found", MsgBoxStyle.OkOnly, "Error")
            Else
                While dr.Read
                    txtbxName.Text = dr("Name").ToString
                    txtbxAge.Text = dr("Age").ToString
                    txtbxCategory.Text = dr("Category").ToString
                    If txtbxCategory.Text.Equals("AAY") Then
                        lblHead.Text = "Family:"
                    Else
                        lblHead.Text = "Head:"
                    End If
                    txtbxGender.Text = dr("Gender").ToString
                    txtbxFHName.Text = dr("FHName").ToString
                    txtbxHoF.Text = dr("HoFName").ToString
                    familyID = dr("FamilyID").ToString
                End While
                Console.WriteLine(familyID)
                If Not familyID = DBNull.Value.ToString Then
                    sql = "SELECT Beneficiaries.*, Delivery.Delivery FROM Beneficiaries, Delivery WHERE (((Beneficiaries.FamilyID)= '" & familyID & "') AND ((Delivery.RCNo)=(Beneficiaries.RCNo)))"
                ElseIf txtbxHoF.Text = "" Or txtbxHoF.Text = vbNullString Or Trim(txtbxHoF.Text) = "" Then
                    sql = "SELECT Beneficiaries.*, Delivery.Delivery FROM Beneficiaries, Delivery WHERE (((Beneficiaries.RCNo)= " & txtbxCardNo.Text & ") AND ((Delivery.RCNo)=(Beneficiaries.RCNo)))"
                Else
                    sql = "SELECT Beneficiaries.*, Delivery.Delivery FROM Beneficiaries, Delivery WHERE (((Beneficiaries.HoFName)= '" & txtbxHoF.Text & "') AND ((Delivery.RCNo)=(Beneficiaries.RCNo)))"
                End If
                cmd = New OleDbCommand(sql, connection)
                dr = cmd.ExecuteReader
                With lstvwFamily
                    .Columns.Add(dr.GetName(0), 80, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(1), 80, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(2), 150, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(3), 150, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(4), 150, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(5), 80, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(6), 80, HorizontalAlignment.Left)
                    .Columns.Add(dr.GetName(8), 80, HorizontalAlignment.Left)
                End With

                With lstvwRcNos
                    .Columns.Add(lstvwFamily.Columns(0).Text, 80, HorizontalAlignment.Left)
                    .Columns.Add(lstvwFamily.Columns(2).Text, 80, HorizontalAlignment.Left)
                    .Columns.Add(lstvwFamily.Columns(1).Text, 80, HorizontalAlignment.Left)
                    .Columns.Add("Rice", 80, HorizontalAlignment.Left)
                    .Columns.Add("Price", 80, HorizontalAlignment.Left)
                    .Columns.Add("Wheat", 80, HorizontalAlignment.Left)
                    .Columns.Add("Price", 80, HorizontalAlignment.Left)
                    .Columns.Add("Atta", 80, HorizontalAlignment.Left)
                    .Columns.Add("Price", 80, HorizontalAlignment.Left)
                    .Columns.Add("Sugar", 80, HorizontalAlignment.Left)
                    .Columns.Add("Price", 80, HorizontalAlignment.Left)
                    .Columns.Add("K. Oil", 80, HorizontalAlignment.Left)
                    .Columns.Add("Price", 80, HorizontalAlignment.Left)
                End With

                While dr.Read
                    Dim ls As New ListViewItem(dr.Item("RCNo").ToString)
                    ls.SubItems.Add(dr.Item("Category").ToString)
                    ls.SubItems.Add(dr.Item("Name").ToString)
                    ls.SubItems.Add(dr.Item("FHName").ToString)
                    ls.SubItems.Add(dr.Item("HoFName").ToString)
                    ls.SubItems.Add(dr.Item("Gender").ToString)
                    ls.SubItems.Add(dr.Item("Age").ToString)
                    If Not IsDBNull(dr.Item("Delivery")) Then
                        ls.SubItems.Add(dr.GetDateTime(8).ToShortDateString)
                    End If
                    lstvwFamily.Items.Add(ls)
                    lstvwFamily.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    lstvwFamily.Refresh()
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.OkOnly, "Error")
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim category As String
        If lstvwFamily.SelectedItems.Count > 0 Then
            category = lstvwFamily.SelectedItems.Item(0).SubItems(1).Text
            lstvwRcNos.Items.Insert(lstvwRcNos.Items.Count, lstvwFamily.SelectedItems.Item(0).Text)
            lstvwRcNos.Items(lstvwRcNos.Items.Count - 1).SubItems.Add(lstvwFamily.SelectedItems.Item(0).SubItems(2).Text)
            lstvwRcNos.Items(lstvwRcNos.Items.Count - 1).SubItems.Add(lstvwFamily.SelectedItems.Item(0).SubItems(1).Text)
            lstvwFamily.SelectedItems.Item(0).Remove()
            Calculate(category, lstvwRcNos.Items.Count)
            totalHead = Integer.Parse(lstvwRcNos.Items.Count.ToString)
            UpdatePriceList()
        End If
        If lstvwRcNos.Items.Count > 0 Then
            btnDeliver.Enabled = True
        Else
            btnDeliver.Enabled = False
        End If
    End Sub

    Private Sub btnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAll.Click
        While lstvwFamily.Items.Count > 0
            lstvwRcNos.Items.Insert(lstvwRcNos.Items.Count, lstvwFamily.Items(0).Text)
            lstvwRcNos.Items(lstvwRcNos.Items.Count - 1).SubItems.Add(lstvwFamily.Items(0).SubItems(2).Text)
            lstvwRcNos.Items(lstvwRcNos.Items.Count - 1).SubItems.Add(lstvwFamily.Items(0).SubItems(1).Text)
            Calculate(lstvwFamily.Items(0).SubItems(1).Text, lstvwRcNos.Items.Count)
            lstvwFamily.Items(0).Remove()
            totalHead = Integer.Parse(lstvwRcNos.Items.Count.ToString)
            UpdatePriceList()
        End While
        If lstvwRcNos.Items.Count > 0 Then
            btnDeliver.Enabled = True
        Else
            btnDeliver.Enabled = False
        End If
    End Sub

    Private Sub Calculate(ByVal category As String, ByVal row As Integer)
        Dim price As Double
        Dim qty As Double
        Dim unit As String
        Dim sql As String
        Dim cmd As OleDbCommand
        connection.Open()
        'If Not category.Equals("AAY") Or row = 1 Then
        For i As Integer = 1 To 5
            Dim massUnit As String = " KG"
            If i = 5 Then
                massUnit = " Ltr"
            End If
            sql = "SELECT Scale, Unit FROM Allotment WHERE ProductID = " & i & " And Category = '" & category & "'"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                qty = dr.Item("Scale")
                unit = dr.Item("Unit")
            Else
                qty = 0.0
                unit = ""
            End If
            If Not unit.Equals("Family") Or row = 1 Then
                lstvwRcNos.Items(row - 1).SubItems.Add(Format(qty, "###0.000") & massUnit)

                sql = "SELECT Price FROM Pricing WHERE ProductID = " & i & " AND Category = '" & category & "'"
                cmd = New OleDbCommand(sql, connection)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    price = dr.Item("Price")
                Else
                    price = 0.0
                End If
                lstvwRcNos.Items(row - 1).SubItems.Add("₹ " & Format(price, "f"))

                Select Case i
                    Case 1
                        totalRice = totalRice + qty
                        totalRicePrice = totalRicePrice + (qty * price)
                    Case 2
                        totalWheat = totalWheat + qty
                        totalWheatPrice = totalWheatPrice + (qty * price)
                    Case 3
                        totalAtta = totalAtta + qty
                        totalAttaPrice = totalAttaPrice + (qty * price)
                    Case 4
                        totalSugar = totalSugar + qty
                        totalSugarPrice = totalSugarPrice + (qty * price)
                    Case 5
                        totalKOil = totalKOil + qty
                        totalKOilPrice = totalKOilPrice + (qty * price)
                End Select
                totalPrice = totalRicePrice + totalWheatPrice + totalAttaPrice + totalSugarPrice + totalKOilPrice
            Else
                lstvwRcNos.Items(row - 1).SubItems.Add("--")
                lstvwRcNos.Items(row - 1).SubItems.Add("--")
            End If
        Next
        'End If
        connection.Close()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim qty As Double
        Dim price As Double
        If lstvwRcNos.SelectedItems.Count > 0 Then
            connection.Open()
            Dim sql = "SELECT Beneficiaries.*, Delivery.Delivery FROM Beneficiaries, Delivery WHERE (((Beneficiaries.RCNo)= " & lstvwRcNos.SelectedItems.Item(0).Text & ") AND ((Delivery.RCNo)=(Beneficiaries.RCNo)))"
            Dim cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim ls As New ListViewItem(dr.Item("RCNo").ToString)
                ls.SubItems.Add(dr.Item("Category").ToString)
                ls.SubItems.Add(dr.Item("Name").ToString)
                ls.SubItems.Add(dr.Item("FHName").ToString)
                ls.SubItems.Add(dr.Item("HoFName").ToString)
                ls.SubItems.Add(dr.Item("Gender").ToString)
                ls.SubItems.Add(dr.Item("Age").ToString)
                If Not IsDBNull(dr.Item("Delivery")) Then
                    ls.SubItems.Add(dr.GetDateTime(8).ToShortDateString)
                End If
                lstvwFamily.Items.Add(ls)
                lstvwFamily.Refresh()
            End While

            Try
                qty = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(3).Text)(0))
                price = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(4).Text)(1))
            Catch ex As ArgumentOutOfRangeException
                qty = 0
                price = 0
            End Try
            totalRice = totalRice - qty
            totalRicePrice = totalRicePrice - (price * qty)

            Try
                qty = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(5).Text)(0))
                price = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(6).Text)(1))
            Catch ex As ArgumentOutOfRangeException
                qty = 0
                price = 0
            End Try
            totalWheat = totalWheat - qty
            totalWheatPrice = totalWheatPrice - (price * qty)

            Try
                qty = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(7).Text)(0))
                price = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(8).Text)(1))
            Catch ex As ArgumentOutOfRangeException
                qty = 0
                price = 0
            End Try
            totalAtta = totalAtta - qty
            totalAttaPrice = totalAttaPrice - (price * qty)

            Try
                qty = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(9).Text)(0))
                price = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(10).Text)(1))
            Catch ex As ArgumentOutOfRangeException
                qty = 0
                price = 0
            End Try
            totalSugar = totalSugar - qty
            totalSugarPrice = totalSugarPrice - (price * qty)

            Try
                qty = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(11).Text)(0))
                price = Double.Parse(Split(lstvwRcNos.SelectedItems.Item(0).SubItems(12).Text)(1))
            Catch ex As ArgumentOutOfRangeException
                qty = 0
                price = 0
            End Try
            totalKOil = totalKOil - qty
            totalKOilPrice = totalKOilPrice - (price * qty)

            totalPrice = totalRicePrice + totalWheatPrice + totalAttaPrice + totalSugarPrice + totalKOilPrice

            lstvwRcNos.SelectedItems.Item(0).Remove()
            If Not txtbxCategory.Text.Equals("AAY") Then
                totalHead = Integer.Parse(lstvwRcNos.Items.Count.ToString)
            End If
            UpdatePriceList()

            connection.Close()
        End If
        If lstvwRcNos.Items.Count > 0 Then
            btnDeliver.Enabled = True
        Else
            btnDeliver.Enabled = False
        End If
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        While lstvwRcNos.Items.Count > 0
            connection.Open()
            Dim sql = "SELECT Beneficiaries.*, Delivery.Delivery FROM Beneficiaries, Delivery WHERE (((Beneficiaries.RCNo)= " & lstvwRcNos.Items(lstvwRcNos.Items.Count - 1).Text & ") AND ((Delivery.RCNo)=(Beneficiaries.RCNo)))"
            Dim cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim ls As New ListViewItem(dr.Item("RCNo").ToString)
                ls.SubItems.Add(dr.Item("Category").ToString)
                ls.SubItems.Add(dr.Item("Name").ToString)
                ls.SubItems.Add(dr.Item("FHName").ToString)
                ls.SubItems.Add(dr.Item("HoFName").ToString)
                ls.SubItems.Add(dr.Item("Gender").ToString)
                ls.SubItems.Add(dr.Item("Age").ToString)
                If Not IsDBNull(dr.Item("Delivery")) Then
                    ls.SubItems.Add(dr.GetDateTime(8).ToShortDateString)
                End If
                lstvwFamily.Items.Add(ls)
                lstvwFamily.Refresh()
            End While
            lstvwRcNos.Items(lstvwRcNos.Items.Count - 1).Remove()

            If Not txtbxCategory.Text.Equals("AAY") Then
                totalHead = totalHead - 1
            End If
            totalRice = 0.0
            totalRicePrice = 0.0
            totalWheat = 0.0
            totalWheatPrice = 0.0
            totalAtta = 0.0
            totalAttaPrice = 0.0
            totalSugar = 0.0
            totalSugarPrice = 0.0
            totalPrice = 0.0
            totalKOil = 0.0
            totalKOilPrice = 0.0
            If Not txtbxCategory.Text.Equals("AAY") Then
                totalHead = Integer.Parse(lstvwRcNos.Items.Count.ToString)
            End If
            UpdatePriceList()
            connection.Close()
        End While
        If lstvwRcNos.Items.Count > 0 Then
            btnDeliver.Enabled = True
        Else
            btnDeliver.Enabled = False
        End If
    End Sub

    Private Sub UpdatePriceList()
        If Not txtbxCategory.Text.Equals("AAY") Then
            txtbxHead.Text = totalHead
        Else
            txtbxHead.Text = 1
        End If
        txtbxRiceQty.Text = Format(totalRice, "###0.000") & "KG"
        txtbxRicePrice.Text = "₹" & Format(totalRicePrice, "##0.00")
        txtbxWhtQty.Text = Format(totalWheat, "###0.000") & "KG"
        txtbxWhtPrice.Text = "₹" & Format(totalWheatPrice, "##0.00")
        txtbxAttaQty.Text = Format(totalAtta, "###0.000") & "KG"
        txtbxAttaPrice.Text = "₹" & Format(totalAttaPrice, "##0.00")
        txtbxSugar.Text = Format(totalSugar, "###0.000") & "KG"
        txtbxSugarPrice.Text = "₹" & Format(totalSugarPrice, "##0.00")
        txtbxKOil.Text = Format(totalKOil, "###0.00") & "Ltr"
        txtbxKOilPrice.Text = "₹" & Format(totalKOilPrice, "##0.00")
        txtbxTotal.Text = "₹" & Format(totalPrice, "##0.00")
    End Sub

    Private Sub btnDeliver_Click(sender As System.Object, e As System.EventArgs) Handles btnDeliver.Click
        Dim sql As String
        connection.Open()
        For i As Integer = 0 To lstvwRcNos.Items.Count - 1
            sql = "UPDATE Delivery Set [Delivery] = '" & Now & "', [CashMemoNo] = " & txtbxCashMemoNo.Text & " WHERE [RCNo] = " & lstvwRcNos.Items(i).Text
            Dim cmd = New OleDbCommand(sql, connection)
            cmd.ExecuteNonQuery()
        Next
        connection.Close()
        If MsgBox("Food supply delivered!", MsgBoxStyle.OkOnly, "Delivered") = MsgBoxResult.Ok Then
            ApplicationReload()
        End If
    End Sub

    Private Sub ApplicationReload()
        For Each control As Control In Me.Controls
            If control.GetType Is GetType(TextBox) And control.Name <> lblSystemDateTime.Name Then
                control.Text = ""
            End If
            lstvwFamily.Clear()
            lstvwRcNos.Clear()
        Next
        SetMemoNo()
    End Sub

    Private Sub ViewSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSalesToolStripMenuItem.Click
        Me.Hide()
        frmViewSales.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Me.Enabled = False
        frmStock.Show()
    End Sub

    Private Sub AllotmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllotmentToolStripMenuItem.Click
        Me.Enabled = False
        frmAllotment.Show()
    End Sub

    Private Sub PricingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PricingToolStripMenuItem.Click
        Me.Enabled = False
        frmPricing.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Me.Enabled = False
        frmGetBenfDetails.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        'Dim bkupDestFolder As New FolderBrowserDialog
        'If bkupDestFolder.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Dim bkupDestPath As String = bkupDestFolder.SelectedPath
        '    Try
        '        FileCopy(dataFile, bkupDestPath + "\mrshop_bkup.mdb")
        '        MsgBox("Database Backedup.")
        '    Catch ex As Exception
        '        MsgBox("Database Backup unsuccessful. Some error occured: " + connection.DataSource + " || " + bkupDestPath)
        '    End Try
        'End If
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDataToolStripMenuItem.Click
        Me.Enabled = False
        frmLoadFamilyID.Show()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click

    End Sub

    Private Sub StockRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockRegisterToolStripMenuItem.Click
        Me.Hide()
        frmGenRegister.Show()
    End Sub

    Private Sub timerSystemDateTime_Tick(sender As Object, e As EventArgs) Handles timerSystemDateTime.Tick
        lblSystemDateTime.Text = Format(Now, "dd/MM/yyyy hh:mm:ss")
    End Sub

    Private Sub EditFamilyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditFamilyToolStripMenuItem.Click
        Me.Enabled = False
        frmEditFamilyID.Show()
    End Sub

    Private Sub AutoDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoDeliveryToolStripMenuItem.Click
        'Me.Enabled = False
        'frmAutoDelivery.Show()
    End Sub

    Private Sub ClearDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDeliveryToolStripMenuItem.Click
        ClearDelivery()
    End Sub

    Private Sub ClearDelivery()
        Dim sql As String
        If MsgBox("Are you sure to clear past deliveries?", MsgBoxStyle.YesNo, "Alert!") = MsgBoxResult.Yes Then
            Try
                connection.Open()
                sql = "UPDATE Delivery Set [Delivery] = NULL"
                Dim cmd = New OleDbCommand(sql, connection)
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Delivery Cleared!", MsgBoxStyle.OkOnly)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub UpdateDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDatabaseToolStripMenuItem.Click
        Me.Enabled = False
        frmUpdateDB.Show()
    End Sub

    Private Sub UpdateAllotmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAllotmentToolStripMenuItem.Click
        Me.Hide()
        frmUpdateAllotment.Show()
    End Sub
End Class
