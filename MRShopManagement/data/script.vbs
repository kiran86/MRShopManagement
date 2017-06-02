Dim provider, dataFile, connString, connection, sql, dr, memoNo
provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
dataFile = "|DataDirectory|\mrshop.mdb"
connString = provider & dataFile
Set connection = CreateObject("ADODB.Connection")
connection.Open connString
sql = "SELECT MAX(CashMemoNo) FROM Delivery"
dr = connection.Execute(sql)
If Not dr.EOF Then
	memoNo = dr.Fields(0)
End If
MsgBox(memoNo)