Public Class frmAdd

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim success As Boolean
        success = addRecord(txtMenu.Text, txtPrice.Text, txtQuantity.Text)
        If success = True Then
            MsgBox("Success adding " + txtMenu.Text + " into the database", vbInformation, "Adding a record")
            ' clearing text boxes for next entry
            txtMenu.Text = ""
            txtPrice.Text = ""
            txtQuantity.Text = ""
            frmHome.TblMenuTableAdapter.Fill(frmHome.DatabaseDataSet.tblMenu)
            frmHome.calculateTotal()
        Else
            MsgBox("Error adding record to the database. Please check: " + vbNewLine + "1. The input for price (decimals only)" + vbNewLine + "2. The input for quantity (integers only)" + vbNewLine + "3. The menu may already exist. " + vbNewLine + "4. Please make sure the the database is accessible and writable", vbExclamation, "Error")
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class