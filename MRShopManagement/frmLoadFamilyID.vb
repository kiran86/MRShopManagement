﻿Imports System.Data.OleDb
Imports HtmlAgilityPack


Public Class frmLoadFamilyID
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public connection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim threadLoadFamilyID As Threading.Thread

    Private Sub frmLoadFamilyID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        dataFile = "|DataDirectory|\mrshop.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString

        LoadForm()
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub frmLoadFamilyID_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        frmMain.Show()
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
            sql = "SELECT COUNT(RCNo) FROM Beneficiaries WHERE FamilyID IS NULL OR FamilyID = ''"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MsgBox("No matching data found", MsgBoxStyle.OkOnly, "Error")
            Else
                dr.Read()
                prgbrStatus.Value = 0
                prgbrStatus.Maximum = Integer.Parse(dr(0).ToString)
                prgbrStatus.Step = 1
                txtbxStatus.AppendText("Total " + dr(0).ToString + " no. of Benificiaries Familiy ID not present." + Environment.NewLine)
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
        Dim source As String
        Dim RCNo As String
        Dim count As Integer = 0
        txtbxStatus.Cursor = Cursors.WaitCursor
        Try
            connection.Open()
            sql = "SELECT RCNo FROM Beneficiaries WHERE FamilyID IS NULL OR FamilyID = ''"
            cmd = New OleDbCommand(sql, connection)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                MsgBox("No matching data found", MsgBoxStyle.OkOnly, "Error")
            Else
                While dr.Read()
                    prgbrStatus.PerformStep()
                    prgbrStatus.Refresh()
                    RCNo = dr("RCNo").ToString.PadLeft(10, "0"c)
                    txtbxStatus.AppendText("RC No " & RCNo & ": ")
                    Try
                        Console.WriteLine(GetFamilyID(RCNo))
                        sql = "UPDATE Beneficiaries SET [FamilyID] = '" + GetFamilyID(RCNo) + "' WHERE [RCNo] = " + dr("RCNo").ToString
                        cmd = New OleDbCommand(sql, connection)
                        If cmd.ExecuteNonQuery = 1 Then
                            txtbxStatus.AppendText("Success" + Environment.NewLine)
                            count = count + 1
                        End If
                    Catch exception As Exception
                        txtbxStatus.AppendText("Failed " + exception.Message + Environment.NewLine)
                        Console.WriteLine(exception.StackTrace)
                    End Try
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

    Private Function GetFamilyID(ByVal RCNo As String) As String
        Dim FamilyID As String
        RCNo.PadLeft(10, "0"c)
        Dim uri As String = "https://www.wbpds.gov.in/DisplayRCData.aspx?RCNO=" + RCNo
        Dim i, j As Integer
        Dim web As New HtmlWeb()
        'Console.WriteLine(uri)
        Dim doc As HtmlDocument = web.Load(uri)

        ' Test connection
        Dim node = doc.DocumentNode.SelectSingleNode("//head/title")
        'Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml)

        ' Get all tables in the document
        'Dim tables As HtmlNodeCollection = doc.DocumentNode.SelectNodes("//table[@id='ctl00_ContentPlaceHolder1_gd_view']")
        Dim tables As HtmlNode = doc.GetElementbyId("ctl00_ContentPlaceHolder1_gd_view")

        ' Iterate all rows in the first table
        Dim rows As HtmlNodeCollection = tables.SelectNodes("tr")

        ' Iterate all columns in the first table
        Dim cols As HtmlNodeCollection = rows(1).SelectNodes("td")

        FamilyID = cols(11).InnerText

        Return FamilyID
    End Function

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