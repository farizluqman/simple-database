Imports System.Data.OleDb

Module module_edit
    Public Function editRecord(ByVal meselectMenu As String, ByVal menu As String, ByVal price As String, ByVal quantity As String) As Boolean
        Dim success As Boolean
        Try
            ' Declare what kind of database, and where is the database file located.
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;")
            connection.Open()
            ' Declare what command to be executed when the function started
            Dim command As New OleDbCommand("UPDATE [tblMenu] SET [Menu]=inmenu, [Price]=inprice, [Quantity]=inquantity WHERE [Menu] = inselect", connection)
            command.Parameters.AddWithValue("inmenu", menu)
            command.Parameters.AddWithValue("inprice", price)
            command.Parameters.AddWithValue("inquantity", quantity)
            command.Parameters.AddWithValue("inselect", meselectMenu)
            command.ExecuteNonQuery()
            connection.Close()
            connection.Dispose()
            success = True
        Catch ex As Exception
            success = False
        End Try

        Return success
    End Function
End Module
