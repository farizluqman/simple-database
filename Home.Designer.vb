<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container()
        Me.DatabaseDataSet = New Database_simple.DatabaseDataSet()
        Me.TblMenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMenuTableAdapter = New Database_simple.DatabaseDataSetTableAdapters.tblMenuTableAdapter()
        Me.FormSkin1 = New Database_simple.FormSkin()
        Me.cmdLogout = New Database_simple.FlatButton()
        Me.FlatStatusBar1 = New Database_simple.FlatStatusBar()
        Me.FlatTabControl1 = New Database_simple.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdGrandTotal = New Database_simple.FlatButton()
        Me.cmdDelete = New Database_simple.FlatButton()
        Me.cmdEdit = New Database_simple.FlatButton()
        Me.cmdAdd = New Database_simple.FlatButton()
        Me.dataMenu = New System.Windows.Forms.DataGridView()
        Me.MenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlatMini1 = New Database_simple.FlatMini()
        Me.FlatMax1 = New Database_simple.FlatMax()
        Me.FlatClose1 = New Database_simple.FlatClose()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dataMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMenuBindingSource
        '
        Me.TblMenuBindingSource.DataMember = "tblMenu"
        Me.TblMenuBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TblMenuTableAdapter
        '
        Me.TblMenuTableAdapter.ClearBeforeFill = True
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.cmdLogout)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatMax1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(847, 472)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Kedai Pak Mail"
        '
        'cmdLogout
        '
        Me.cmdLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLogout.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLogout.Location = New System.Drawing.Point(669, 12)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Rounded = False
        Me.cmdLogout.Size = New System.Drawing.Size(80, 32)
        Me.cmdLogout.TabIndex = 10
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 449)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(847, 23)
        Me.FlatStatusBar1.TabIndex = 5
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(2, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(845, 419)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.cmdGrandTotal)
        Me.TabPage1.Controls.Add(Me.cmdDelete)
        Me.TabPage1.Controls.Add(Me.cmdEdit)
        Me.TabPage1.Controls.Add(Me.cmdAdd)
        Me.TabPage1.Controls.Add(Me.dataMenu)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(837, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu List"
        '
        'cmdGrandTotal
        '
        Me.cmdGrandTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.cmdGrandTotal.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.cmdGrandTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGrandTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdGrandTotal.Location = New System.Drawing.Point(610, 130)
        Me.cmdGrandTotal.Name = "cmdGrandTotal"
        Me.cmdGrandTotal.Rounded = False
        Me.cmdGrandTotal.Size = New System.Drawing.Size(208, 123)
        Me.cmdGrandTotal.TabIndex = 10
        Me.cmdGrandTotal.Text = "Calculate Grand Total"
        Me.cmdGrandTotal.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.BackColor = System.Drawing.Color.Transparent
        Me.cmdDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdDelete.Location = New System.Drawing.Point(610, 259)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Rounded = False
        Me.cmdDelete.Size = New System.Drawing.Size(208, 56)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.BackColor = System.Drawing.Color.Transparent
        Me.cmdEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdEdit.Location = New System.Drawing.Point(610, 68)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Rounded = False
        Me.cmdEdit.Size = New System.Drawing.Size(208, 56)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdAdd.Location = New System.Drawing.Point(610, 6)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Rounded = False
        Me.cmdAdd.Size = New System.Drawing.Size(208, 56)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'dataMenu
        '
        Me.dataMenu.AllowUserToAddRows = False
        Me.dataMenu.AllowUserToDeleteRows = False
        Me.dataMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataMenu.AutoGenerateColumns = False
        Me.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.columnTotal})
        Me.dataMenu.DataSource = Me.TblMenuBindingSource
        Me.dataMenu.Location = New System.Drawing.Point(6, 6)
        Me.dataMenu.MultiSelect = False
        Me.dataMenu.Name = "dataMenu"
        Me.dataMenu.ReadOnly = True
        Me.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataMenu.Size = New System.Drawing.Size(598, 309)
        Me.dataMenu.TabIndex = 6
        '
        'MenuDataGridViewTextBoxColumn
        '
        Me.MenuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuDataGridViewTextBoxColumn.DataPropertyName = "Menu"
        Me.MenuDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.MenuDataGridViewTextBoxColumn.Name = "MenuDataGridViewTextBoxColumn"
        Me.MenuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price (RM)"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'columnTotal
        '
        Me.columnTotal.HeaderText = "Total (RM)"
        Me.columnTotal.Name = "columnTotal"
        Me.columnTotal.ReadOnly = True
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(769, 17)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 3
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(793, 17)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 2
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(817, 17)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 1
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 472)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dataMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Database_simple.FormSkin
    Friend WithEvents FlatMini1 As Database_simple.FlatMini
    Friend WithEvents FlatMax1 As Database_simple.FlatMax
    Friend WithEvents FlatClose1 As Database_simple.FlatClose
    Friend WithEvents FlatStatusBar1 As Database_simple.FlatStatusBar
    Friend WithEvents FlatTabControl1 As Database_simple.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdDelete As Database_simple.FlatButton
    Friend WithEvents cmdEdit As Database_simple.FlatButton
    Friend WithEvents cmdAdd As Database_simple.FlatButton
    Friend WithEvents dataMenu As System.Windows.Forms.DataGridView
    Friend WithEvents cmdLogout As Database_simple.FlatButton
    Friend WithEvents DatabaseDataSet As Database_simple.DatabaseDataSet
    Friend WithEvents TblMenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMenuTableAdapter As Database_simple.DatabaseDataSetTableAdapters.tblMenuTableAdapter
    Friend WithEvents MenuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdGrandTotal As Database_simple.FlatButton

End Class
