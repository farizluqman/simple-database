Imports System.Data.OleDb

Public Class frmEdit
    Private meselectmenu As String = frmHome.meselectMenu

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillTextBox(meselectmenu)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim success As Boolean
        success = editRecord(meselectmenu, txtMenu.Text, txtPrice.Text, txtQuantity.Text)
        If success = True Then
            MsgBox("Record successfully updated", vbInformation, "Success")
            frmHome.TblMenuTableAdapter.Fill(frmHome.DatabaseDataSet.tblMenu)
            frmHome.calculateTotal()
            Me.Close()
        Else
            MsgBox("Error editing the database. Please check: " + vbNewLine + "1. The input for price (decimals only)" + vbNewLine + "2. The input for quantity (integers only)" + vbNewLine + "3. The menu may already exist. " + vbNewLine + "4. Please make sure the the database is accessible and writable", vbExclamation, "Error")
        End If

    End Sub

    Public Sub fillTextBox(ByVal meselectmenu As String)
        Try
            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;")
            connection.Open()
            Dim command As New OleDbCommand("SELECT * FROM tblMenu WHERE Menu = '" & meselectmenu & "'", connection)
            Dim reader As OleDbDataReader = command.ExecuteReader
            If reader.Read Then
                txtMenu.Text = reader.Item(1).ToString
                txtPrice.Text = reader.Item(2).ToString
                txtQuantity.Text = reader.Item(3).ToString
            End If
        Catch ex As Exception
            MsgBox(meselectmenu)
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class