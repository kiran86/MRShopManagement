Imports HtmlAgilityPack

Public Class frmGetBenfDetails
    Dim source As String

    Private Sub frmGetBenfDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Function GetTagContents(ByVal Source As String, ByVal startTag As String, ByVal endTag As String) As String
        Dim StringFound As String
        Dim Index As Integer = Source.IndexOf(startTag) + startTag.Length
        'Console.Write("Here: ")
        'Console.WriteLine(Source)
        StringFound = Source.Substring(Index, Source.IndexOf(endTag, Index) - Index)
        Return StringFound
    End Function

    Private Sub frmGetBenfDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Visible = False
        Me.Dispose()
        frmMain.Enabled = True
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            source = New Net.WebClient().DownloadString("https://www.wbpds.gov.in/DisplayRCData.aspx?RCNO=00" + txtbxCardNo.Text)
            Dim recentSource As String = GetTagContents(source, "<table width=""100%"" cellpadding=""5px"">", "</table>")
            txtbxName.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblName""><i>", "</i></span>")
            txtbxAge.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblAge""><i>", "</i></span>")
            txtbxGender.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblGender""><i>", "</i></span>")
            txtbxHoF.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblHOF""><i>", "</i></span>")
            txtbxFHName.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblFHName""><i>", "</i></span>")
            txtbxCategory.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblRC""><i>", "</i></span>")
            'txtbxFamilyID.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblFamily""><i>", "</i></span>")
            txtbxFamilyID.Text = GetFamilyID(txtbxCardNo.Text)
            txtbxFPS.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblFPS""><i>", "</i></span>")
        Catch ex As Exception
            MsgBox("Some error occured. Please try after some time.")
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
End Class