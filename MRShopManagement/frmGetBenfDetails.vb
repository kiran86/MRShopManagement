Public Class frmGetBenfDetails
    Dim source As String

    Private Sub frmGetBenfDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Function GetTagContents(ByVal Source As String, ByVal startTag As String, ByVal endTag As String) As String
        Dim StringFound As String
        Dim Index As Integer = Source.IndexOf(startTag) + startTag.Length
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
            txtbxFamilyID.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblFamily""><i>", "</i></span>")
            txtbxFPS.Text = GetTagContents(recentSource, "<span id=""ctl00_ContentPlaceHolder1_lblFPS""><i>", "</i></span>")
        Catch ex As Exception
            MsgBox("Some error occured. Please try after some time.")
        End Try
    End Sub
End Class