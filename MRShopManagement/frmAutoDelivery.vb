Imports System.Data.OleDb

Public Class frmAutoDelivery
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim threadLoadFamilyID As Threading.Thread

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
        Me.Visible = False
        Me.Dispose()
        frmMain.Enabled = True
    End Sub

    Private Sub bttnLoad_Click(sender As Object, e As EventArgs) Handles bttnLoad.Click
        threadLoadFamilyID = New Threading.Thread(AddressOf LoadFamilyID)
        threadLoadFamilyID.Start()
        bttnStop.Enabled = True
        bttnLoad.Enabled = False
    End Sub

    Private Sub LoadForm()
        Dim sql As String
        txtbxStatus.Text = ""
        bttnStop.Enabled = False
        Try
            connection.Open()
            sql = "SELECT COUNT(RCNo) FROM Delivery WHERE Delivery IS NULL"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
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

    Private Sub LoadFamilyID()
        Dim sql As String
        Dim cmd As OleDbCommand
        Dim dr1 As OleDbDataReader
        Dim count As Integer = 0
        txtbxStatus.Cursor = Cursors.WaitCursor
        Try
            connection.Open()
            sql = "SELECT Beneficiaries.RCNo, Beneficiaries.FamilyID, Beneficiaries.HoFName FROM Beneficiaries, Delivery WHERE Beneficiaries.RCNo = Delivery.RCNo AND Delivery.Delivery = NULL"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MsgBox("No matching data found", MsgBoxStyle.OkOnly, "Error")
            Else
                While dr.Read()
                    If Not dr.IsDBNull("Beneficiaries.FamilyID") Then
                        sql = "SELECT Delivery.Delivery FROM Beneficiaries, Delivery WHERE Beneficiaries.FamilyID = " & dr.GetString("Beneficiaries.FamilyID") & " AND Beneficiaries.RCNo = " & dr.GetInt32("Beneficiaries.RCNo") & " AND Beneficiaries.RCNo = Delivery.RCNo"
                        cmd = New OleDbCommand(sql, connection)
                        dr1 = cmd.ExecuteReader
                        If dr1.HasRows Then
                            If Not dr1.IsDBNull(0) Then

                            End If
                        End If
                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.OkOnly)
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
        If threadLoadFamilyID.IsAlive Then
            threadLoadFamilyID.Abort()
            threadLoadFamilyID.Join()
            bttnLoad.Enabled = True
        End If
        If Not threadLoadFamilyID.IsAlive Then
            LoadForm()
        End If
    End Sub
End Class