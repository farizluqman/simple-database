Imports System.Data.OleDb

Module module_login
    Public Function login(ByVal username As String, ByVal password As String) As Boolean
        Dim success As Boolean = False
        Try
            ' Declare what kind of database, and where is the database file located.
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;")

            ' Declare what command to be executed when the function started
            Dim command As New OleDbCommand("SELECT * FROM [tblAuthentication] WHERE [UsernameField] = username AND [PasswordField] = password", connection)

            Dim usernameParam As New OleDbParameter("username", username)
            Dim passwordParam As New OleDbParameter("password", password)
            command.Parameters.Add(usernameParam)
            command.Parameters.Add(passwordParam)

            ' start the connection
            command.Connection.Open()

            ' reader will hold the result of the connection
            Dim reader As OleDbDataReader = command.ExecuteReader()

            ' if the reader has confirmed that username and password matched
            If reader.Read() Then
                MsgBox("Login successful", vbInformation, "Success")
                success = True
            Else
                MsgBox("Login failed", vbExclamation, "Failed")
                success = False
            End If

            command.Connection.Close()
            command.Connection.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
        Return success
    End Function
End Module
