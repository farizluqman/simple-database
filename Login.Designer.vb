<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.FlatClose1 = New Database_simple.FlatClose()
        Me.FlatLabel2 = New Database_simple.FlatLabel()
        Me.FlatLabel1 = New Database_simple.FlatLabel()
        Me.txtPassword = New Database_simple.FlatTextBox()
        Me.txtUsername = New Database_simple.FlatTextBox()
        Me.cmdReset = New Database_simple.FlatButton()
        Me.cmdLogin = New Database_simple.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.txtPassword)
        Me.FormSkin1.Controls.Add(Me.txtUsername)
        Me.FormSkin1.Controls.Add(Me.cmdReset)
        Me.FormSkin1.Controls.Add(Me.cmdLogin)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(282, 262)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Login"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(253, 14)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 6
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(105, 127)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(71, 20)
        Me.FlatLabel2.TabIndex = 5
        Me.FlatLabel2.Text = "Password"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(105, 63)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(75, 20)
        Me.FlatLabel1.TabIndex = 4
        Me.FlatLabel1.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.Location = New System.Drawing.Point(33, 153)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(217, 29)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.Location = New System.Drawing.Point(33, 94)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(217, 29)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.Transparent
        Me.cmdReset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReset.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdReset.Location = New System.Drawing.Point(151, 199)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Rounded = True
        Me.cmdReset.Size = New System.Drawing.Size(99, 37)
        Me.cmdReset.TabIndex = 1
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLogin.Location = New System.Drawing.Point(33, 199)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Rounded = True
        Me.cmdLogin.Size = New System.Drawing.Size(99, 37)
        Me.cmdLogin.TabIndex = 0
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 262)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Database_simple.FormSkin
    Friend WithEvents cmdReset As Database_simple.FlatButton
    Friend WithEvents cmdLogin As Database_simple.FlatButton
    Friend WithEvents txtPassword As Database_simple.FlatTextBox
    Friend WithEvents txtUsername As Database_simple.FlatTextBox
    Friend WithEvents FlatLabel2 As Database_simple.FlatLabel
    Friend WithEvents FlatLabel1 As Database_simple.FlatLabel
    Friend WithEvents FlatClose1 As Database_simple.FlatClose
End Class
