<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormSkin1 = New Database_simple.FormSkin()
        Me.cmdClose = New Database_simple.FlatButton()
        Me.cmdAdd = New Database_simple.FlatButton()
        Me.FlatLabel3 = New Database_simple.FlatLabel()
        Me.txtQuantity = New Database_simple.FlatTextBox()
        Me.FlatLabel2 = New Database_simple.FlatLabel()
        Me.txtPrice = New Database_simple.FlatTextBox()
        Me.FlatLabel1 = New Database_simple.FlatLabel()
        Me.txtMenu = New Database_simple.FlatTextBox()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.cmdClose)
        Me.FormSkin1.Controls.Add(Me.cmdAdd)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.txtQuantity)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.txtPrice)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.txtMenu)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(407, 311)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Add Record"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdClose.Location = New System.Drawing.Point(271, 246)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Rounded = False
        Me.cmdClose.Size = New System.Drawing.Size(106, 32)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAdd.Location = New System.Drawing.Point(146, 246)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Rounded = False
        Me.cmdAdd.Size = New System.Drawing.Size(106, 32)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(39, 185)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(65, 20)
        Me.FlatLabel3.TabIndex = 10
        Me.FlatLabel3.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.Transparent
        Me.txtQuantity.Location = New System.Drawing.Point(114, 179)
        Me.txtQuantity.MaxLength = 32767
        Me.txtQuantity.Multiline = False
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = False
        Me.txtQuantity.Size = New System.Drawing.Size(217, 29)
        Me.txtQuantity.TabIndex = 9
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtQuantity.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuantity.UseSystemPasswordChar = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(39, 132)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(41, 20)
        Me.FlatLabel2.TabIndex = 8
        Me.FlatLabel2.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.Location = New System.Drawing.Point(114, 126)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Multiline = False
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = False
        Me.txtPrice.Size = New System.Drawing.Size(217, 29)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPrice.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrice.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(39, 80)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(46, 20)
        Me.FlatLabel1.TabIndex = 6
        Me.FlatLabel1.Text = "Menu"
        '
        'txtMenu
        '
        Me.txtMenu.BackColor = System.Drawing.Color.Transparent
        Me.txtMenu.Location = New System.Drawing.Point(114, 74)
        Me.txtMenu.MaxLength = 32767
        Me.txtMenu.Multiline = False
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.ReadOnly = False
        Me.txtMenu.Size = New System.Drawing.Size(217, 29)
        Me.txtMenu.TabIndex = 5
        Me.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMenu.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMenu.UseSystemPasswordChar = False
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 311)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Database_simple.FormSkin
    Friend WithEvents cmdClose As Database_simple.FlatButton
    Friend WithEvents cmdAdd As Database_simple.FlatButton
    Friend WithEvents FlatLabel3 As Database_simple.FlatLabel
    Friend WithEvents txtQuantity As Database_simple.FlatTextBox
    Friend WithEvents FlatLabel2 As Database_simple.FlatLabel
    Friend WithEvents txtPrice As Database_simple.FlatTextBox
    Friend WithEvents FlatLabel1 As Database_simple.FlatLabel
    Friend WithEvents txtMenu As Database_simple.FlatTextBox
End Class
