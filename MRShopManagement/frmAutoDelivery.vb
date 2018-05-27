Imports System.Data.OleDb

Public Class frmAutoDelivery
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim threadAutoDelivery As Threading.Thread
    Dim MemoNo As Integer = 0
    Dim oldFamily, newFamily As String
    Dim DelvDate As Date

    Private Sub frmAutoDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString

        LoadForm()
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub frmAutoDelivery_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        frmMain.Show()
    End Sub

    Private Sub bttnDeliver_Click(sender As Object, e As EventArgs) Handles bttnDeliver.Click
        threadAutoDelivery = New Threading.Thread(AddressOf AutoDelivery)
        threadAutoDelivery.Start()
        bttnStop.Enabled = True
        bttnDeliver.Enabled = False
    End Sub

    Private Sub LoadForm()
        Dim sql As String
        txtbxStatus.Text = ""
        bttnStop.Enabled = False
        Try
            connection.Open()
            sql = "SELECT MAX(Delivery.Delivery) FROM Delivery"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                DelvDate = dr.GetDateTime(0)
                DelvDate = New DateTime(DelvDate.Year, DelvDate.Month, DelvDate.Day + 1, 8, 0, 0, 0)
                dttmDeliveryDate.Value = DelvDate
            End If
            sql = "SELECT COUNT(RCNo), MAX(CashMemoNo), MAX(Delivery.Delivery) FROM Delivery WHERE Delivery IS NULL"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                prgbrStatus.Value = 0
                prgbrStatus.Maximum = Integer.Parse(dr(0).ToString)
                prgbrStatus.Step = 1
                txtbxStatus.AppendText("Total " + dr(0).ToString + " no. of Benificiaries didn't came." + Environment.NewLine)
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message + "\n" + ex.StackTrace)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub AutoDelivery()
        Dim sql As String
        Dim cmd As OleDbCommand
        Dim dr1 As OleDbDataReader
        Dim count As Integer = 0
        txtbxStatus.Cursor = Cursors.WaitCursor

        Try
            connection.Open()
            sql = "SELECT Beneficiaries.RCNo, Beneficiaries.FamilyID, Beneficiaries.HoFName, Beneficiaries.Category FROM Beneficiaries, Delivery WHERE Beneficiaries.RCNo = Delivery.RCNo AND Delivery.Delivery IS NULL"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MsgBox("No matching data found", MsgBoxStyle.OkOnly, "Error")
            Else
                While dr.Read()
                    If dr.IsDBNull(1) Then
                        newFamily = dr.GetString(2)
                    Else
                        newFamily = dr.GetString(1)
                    End If

                    If Not newFamily = oldFamily Then
                        oldFamily = newFamily

                        sql = "SELECT CashMemoNo FROM Delivery WHERE Delivery.Category = '" + dr.GetString(3) +
                              "' AND Delivery.Delivery = (SELECT MAX(Delivery.Delivery) FROM Delivery WHERE Delivery.Category = '" + dr.GetString(3) + "')"
                        cmd = New OleDbCommand(sql, connection)
                        dr1 = cmd.ExecuteReader
                        If dr1.HasRows Then
                            dr1.Read()
                            MemoNo = dr1.GetInt32(0)
                        End If

                        If MemoNo >= 5000 Then
                            MemoNo = 1
                        Else
                            MemoNo = MemoNo + 1
                        End If
                    End If

                    DelvDate.AddSeconds(30)

                    sql = "UPDATE Delivery SET Delivery.CashMemoNo = " & MemoNo & ", Delivery.Delivery = '" & DelvDate.ToString & "' WHERE Delivery.RCNo = " & dr(0).ToString
                    cmd = New OleDbCommand(sql, connection)
                    If cmd.ExecuteNonQuery <= 0 Then
                        Console.WriteLine("Error in updation: " + sql)
                    Else
                        count = count + 1
                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.OkOnly)
            Console.WriteLine(ex.ToString)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            txtbxStatus.AppendText("Total " & count & " no of Benificiaries data updated successfully." & Environment.NewLine)
            txtbxStatus.Cursor = Cursors.Default
            If bttnStop.Enabled = True Then
                bttnStop.Enabled = False
            End If
        End Try
    End Sub

    Private Sub bttnStop_Click(sender As Object, e As EventArgs) Handles bttnStop.Click
        If threadAutoDelivery.IsAlive Then
            threadAutoDelivery.Abort()
            threadAutoDelivery.Join()
            bttnDeliver.Enabled = True
        End If
        If Not threadAutoDelivery.IsAlive Then
            LoadForm()
        End If
    End Sub
End Class