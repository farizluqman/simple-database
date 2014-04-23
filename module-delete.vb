Imports System.Data.OleDb

Module module_delete
    Public Function deleteRecord(ByVal meselectMenu As String) As Boolean
        Dim success As Boolean = False

        Try
            ' Declare what kind of database, and where is the database file located.
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;")
            connection.Open()
            ' Declare what command to be executed when the function started
            Dim command As New OleDbCommand("Delete * FROM tblMenu where Menu = inmenu", connection)
            command.Parameters.AddWithValue("inmenu", meselectMenu)
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
