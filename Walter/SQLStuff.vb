Imports System.Data.OleDb, System.IO
Module SQLStuff

    'Fields/Variables
    Public walterDbConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
    Public walterDbCommand As New OleDbCommand("", walterDbConnection)

    'Methods/Subs
    Public Sub Populate_ComboBox(ByVal varcombo, ByVal mySelectQuery)
        varcombo.Items.Clear()
        walterDbCommand = New OleDbCommand(mySelectQuery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            varcombo.Items.Add(myReader.GetValue(0))
        End While
        myReader.Close()
        varcombo = vbNull
        mySelectQuery = vbNullString
    End Sub

    Public Function SQLReading(ByVal mySelectQuery)
        Dim varread As Object
        walterDbCommand = New OleDbCommand(mySelectQuery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        varread = vbNull
        While myReader.Read()
            varread = myReader.GetValue(0)
        End While
        myReader.Close()
        Return varread
    End Function

    Public Function GetTableWorker() As DataTable
        Dim myselectquery As String
        Dim table As New DataTable
        table.Columns.Add("Date", GetType(Date))
        table.Columns.Add("Task", GetType(String))
        table.Columns.Add("Hours Worked", GetType(Integer))
        table.Columns.Add("Pay (£)", GetType(Integer))
        myselectquery = "SELECT Task, Hours_Worked, Date_Worked FROM Workers_hours WHERE WorkerID = " & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + Invoices.I_N.Text + "'") & " AND Date_worked >= #" + Invoices.I_Date1.Text + "# AND Date_worked <= #" + Invoices.I_Date2.Text + "#"
        walterDbCommand = New OleDbCommand(myselectquery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            table.Rows.Add(myReader.GetValue(2), myReader.GetValue(0), myReader.GetValue(1), (myReader.GetValue(1) * SQLReading("SELECT Hourly_Rate FROM Worker WHERE Worker_Name = '" + Invoices.I_N.Text + "'")))
        End While
        myReader.Close()
        Try
            Invoices.I_Total.Text = "£" & (SQLReading("SELECT Hourly_Rate FROM Worker WHERE Worker_Name = '" + Invoices.I_N.Text + "'") * SQLReading("SELECT SUM(Hours_Worked) FROM Workers_hours WHERE WorkerID = " & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + Invoices.I_N.Text + "'") & " AND Date_worked >= #" + Invoices.I_Date1.Text + "# AND Date_worked <= #" + Invoices.I_Date2.Text + "#"))
        Catch ex As Exception

        End Try
                Return (table)
    End Function

    Public Function GetTableJob() As DataTable
        Dim myselectquery As String
        Dim eachworker, Tcost, TotalLabour As Integer
        Dim table As New DataTable
        table.Columns.Add("Date", GetType(Date))
        table.Columns.Add("Labour or Materials", GetType(String))
        table.Columns.Add("Task or Supplier Name", GetType(String))
        table.Columns.Add("Cost (£)", GetType(Integer))
        TotalLabour = 0
        'Labour
        myselectquery = "SELECT Task, Date_Worked, WorkerID FROM Workers_hours WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + Invoices.I_N.Text + "'") & " AND Date_worked >= #" + Invoices.I_Date1.Text + "# AND Date_worked <= #" + Invoices.I_Date2.Text + "#"
        walterDbCommand = New OleDbCommand(myselectquery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            eachworker = (SQLReading("SELECT Hourly_Rate FROM Worker WHERE WorkerID = " & myReader(2)) * (SQLReading("SELECT Hours_Worked FROM Workers_hours WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + Invoices.I_N.Text + "'") & " AND Date_worked >= #" + Invoices.I_Date1.Text + "# AND Date_worked <= #" + Invoices.I_Date2.Text + "# AND WorkerID = " & myReader.GetValue(2))))
            TotalLabour = TotalLabour + eachworker
            table.Rows.Add(myReader.GetValue(1), "Labour", myReader.GetValue(0), eachworker)
        End While
        myReader.Close()
        'Supplier
        Dim myselectquery1 As String
        myselectquery1 = "SELECT SupplierID, Cost, Date_of_invoice FROM supplier_outgoings WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + Invoices.I_N.Text + "'") & " AND Date_of_invoice >= #" + Invoices.I_Date1.Text + "# AND Date_of_invoice <= #" + Invoices.I_Date2.Text + "#"
        walterDbCommand = New OleDbCommand(myselectquery1, walterDbConnection)
        Dim myReader1 As OleDbDataReader
        myReader1 = walterDbCommand.ExecuteReader()
        While myReader1.Read()
            table.Rows.Add(myReader1.GetValue(2), "Materials", SQLReading("SELECT Supplier_Name FROM Supplier WHERE SupplierID = " & myReader1.GetValue(0)), myReader1.GetValue(1))
        End While
        myReader.Close()
        If SQLReading("SELECT SUM(Cost) FROM supplier_outgoings WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + Invoices.I_N.Text + "'") & " AND Date_of_invoice >= #" + Invoices.I_Date1.Text + "# AND Date_of_invoice <= #" + Invoices.I_Date2.Text + "#").Equals(DBNull.Value) Then
            Tcost = 0
        Else
            Tcost = SQLReading("SELECT SUM(Cost) FROM supplier_outgoings WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + Invoices.I_N.Text + "'") & " AND Date_of_invoice >= #" + Invoices.I_Date1.Text + "# AND Date_of_invoice <= #" + Invoices.I_Date2.Text + "#")
        End If
        Invoices.I_Total.Text = "£" & (Tcost + TotalLabour)
        Return (table)
    End Function

    Public Function GetTableSupplier() As DataTable
        Dim myselectquery As String
        Dim table As New DataTable
        table.Columns.Add("Date", GetType(Date))
        table.Columns.Add("Job", GetType(String))
        table.Columns.Add("Cost", GetType(Integer))
        myselectquery = "SELECT JobID, Cost, Date_of_invoice FROM supplier_outgoings WHERE SupplierID = " & SQLReading("SELECT SupplierID FROM Supplier WHERE Supplier_Name = '" + Invoices.I_N.Text + "'") & " AND Date_of_invoice >= #" + Invoices.I_Date1.Text + "# AND Date_of_invoice <= #" + Invoices.I_Date2.Text + "#"
        walterDbCommand = New OleDbCommand(myselectquery, walterDbConnection)
        Dim myReader As OleDbDataReader
        Dim JobID As String
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            JobID = myReader.GetValue(0)
            table.Rows.Add(myReader.GetValue(2), SQLReading("SELECT Job_Name FROM Jobs WHERE JobID = " + JobID), myReader.GetValue(1))
        End While
        myReader.Close()
        Invoices.I_Total.Text = "£" & SQLReading("SELECT SUM(Cost) FROM supplier_outgoings WHERE SupplierID = " & SQLReading("SELECT SupplierID FROM Supplier WHERE Supplier_Name = '" + Invoices.I_N.Text + "'") & " AND Date_of_invoice >= #" + Invoices.I_Date1.Text + "# AND Date_of_invoice <= #" + Invoices.I_Date2.Text + "#")
        Return (table)
    End Function

    Public Sub SQLWriting(ByVal sql)

        walterDbCommand = New OleDbCommand(sql, walterDbConnection)
        walterDbCommand.ExecuteNonQuery()
        MsgBox("Success!")
    End Sub

    Public Sub SQLWritingLogin(ByVal Log)
        walterDbCommand = New OleDbCommand(Log, walterDbConnection)
        walterDbCommand.ExecuteScalar()
    End Sub
End Module
