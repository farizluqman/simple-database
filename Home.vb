Imports System.Data.OleDb

Public Class frmHome
    Public meselectMenu As String

    ' Procedures start from here

    Private Sub Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmLogin.Show()
        Me.Enabled = False
        Me.TblMenuTableAdapter.Fill(Me.DatabaseDataSet.tblMenu)
        dataMenu.ClearSelection()
        calculateTotal()
    End Sub

    ' This procedure to calculate price * quantity = total
    ' 
    Public Sub calculateTotal()
        For index As Integer = 0 To dataMenu.RowCount - 1
            Dim total As Double
            total = CDbl(dataMenu.Rows(index).Cells(1).Value.ToString) * CDbl(dataMenu.Rows(index).Cells(2).Value.ToString)
            dataMenu.Rows(index).Cells(3).Value = total
        Next
    End Sub

    Public Sub calculateGrandTotal()
        Dim grandTotal As Double = 0.0
        For index As Integer = 0 To dataMenu.RowCount - 1
            grandTotal = grandTotal + CDbl(dataMenu.Rows(index).Cells(3).Value.ToString)
        Next
        MsgBox("Grand total is : " & Format(grandTotal, "RM 0.00"), vbInformation, "Grand total")
    End Sub

    ' Procedures ends here

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim success As Boolean
        If meselectMenu = Nothing Then
            MsgBox("Please select a record!", vbExclamation, "No record selected")
        Else
            If MsgBox("Do you want to delete " & meselectMenu & "?", vbYesNo, "Delete Record") = vbYes Then
                success = deleteRecord(meselectMenu)
                If success = True Then
                    MsgBox("Record deleted successfully", vbInformation, "Delete record")
                Else
                    MsgBox("Error deleting the record from database. Please make sure that the database is accessible and writable", vbExclamation, "Error")
                End If
                meselectMenu = Nothing
            End If
        End If
        meselectMenu = Nothing
        Me.TblMenuTableAdapter.Fill(Me.DatabaseDataSet.tblMenu)
        dataMenu.ClearSelection()
        calculateTotal()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmAdd.Show()
    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Me.Enabled = False
        frmLogin.Show()
    End Sub

    Private Sub dataMenu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dataMenu.MouseClick
        Try
            meselectMenu = dataMenu.CurrentRow.Cells(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If meselectMenu = Nothing Then
            MsgBox("Please select a record!", vbExclamation, "No record selected")
        Else
            frmEdit.Show()
        End If

    End Sub

    Private Sub cmdGrandTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrandTotal.Click
        calculateGrandTotal()
    End Sub

End Class
