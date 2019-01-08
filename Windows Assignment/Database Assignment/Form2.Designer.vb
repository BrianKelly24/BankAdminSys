<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
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
        Dim lblID As System.Windows.Forms.Label
        Dim lblName As System.Windows.Forms.Label
        Dim lblBalance As System.Windows.Forms.Label
        Dim lblOverdraft As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Database))
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Database_Assignment.bankDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtboxid = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxBalance = New System.Windows.Forms.TextBox()
        Me.chckboxOverd = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Balance_AscendingToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Balance_AscendingToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Balance_DescendingToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Balance_DescendingToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Name3ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Name3ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResetToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ResetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomersTableAdapter = New Database_Assignment.bankDataSetTableAdapters.customersTableAdapter()
        Me.TableAdapterManager = New Database_Assignment.bankDataSetTableAdapters.TableAdapterManager()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.donebtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        lblID = New System.Windows.Forms.Label()
        lblName = New System.Windows.Forms.Label()
        lblBalance = New System.Windows.Forms.Label()
        lblOverdraft = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Balance_AscendingToolStrip.SuspendLayout()
        Me.Balance_DescendingToolStrip.SuspendLayout()
        Me.Name3ToolStrip.SuspendLayout()
        Me.ResetToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Location = New System.Drawing.Point(67, 190)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(19, 13)
        lblID.TabIndex = 2
        lblID.Text = "Id:"
        '
        'lblName
        '
        lblName.AutoSize = True
        lblName.Location = New System.Drawing.Point(49, 234)
        lblName.Name = "lblName"
        lblName.Size = New System.Drawing.Size(38, 13)
        lblName.TabIndex = 4
        lblName.Text = "Name:"
        '
        'lblBalance
        '
        lblBalance.AutoSize = True
        lblBalance.Location = New System.Drawing.Point(37, 274)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New System.Drawing.Size(49, 13)
        lblBalance.TabIndex = 6
        lblBalance.Text = "Balance:"
        '
        'lblOverdraft
        '
        lblOverdraft.AutoSize = True
        lblOverdraft.Location = New System.Drawing.Point(37, 315)
        lblOverdraft.Name = "lblOverdraft"
        lblOverdraft.Size = New System.Drawing.Size(54, 13)
        lblOverdraft.TabIndex = 8
        lblOverdraft.Text = "Overdraft:"
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(807, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "bankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(308, 187)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.Size = New System.Drawing.Size(443, 287)
        Me.CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn3.HeaderText = "balance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "overdraft"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "overdraft"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'txtboxid
        '
        Me.txtboxid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "id", True))
        Me.txtboxid.Location = New System.Drawing.Point(95, 187)
        Me.txtboxid.Name = "txtboxid"
        Me.txtboxid.Size = New System.Drawing.Size(100, 20)
        Me.txtboxid.TabIndex = 3
        '
        'txtboxName
        '
        Me.txtboxName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "name", True))
        Me.txtboxName.Location = New System.Drawing.Point(95, 231)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(100, 20)
        Me.txtboxName.TabIndex = 5
        '
        'txtboxBalance
        '
        Me.txtboxBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "balance", True))
        Me.txtboxBalance.Location = New System.Drawing.Point(95, 271)
        Me.txtboxBalance.Name = "txtboxBalance"
        Me.txtboxBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtboxBalance.TabIndex = 6
        '
        'chckboxOverd
        '
        Me.chckboxOverd.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustomersBindingSource, "overdraft", True))
        Me.chckboxOverd.Location = New System.Drawing.Point(95, 310)
        Me.chckboxOverd.Name = "chckboxOverd"
        Me.chckboxOverd.Size = New System.Drawing.Size(104, 24)
        Me.chckboxOverd.TabIndex = 7
        Me.chckboxOverd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(807, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Balance_AscendingToolStrip
        '
        Me.Balance_AscendingToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Balance_AscendingToolStripButton})
        Me.Balance_AscendingToolStrip.Location = New System.Drawing.Point(0, 49)
        Me.Balance_AscendingToolStrip.Name = "Balance_AscendingToolStrip"
        Me.Balance_AscendingToolStrip.Size = New System.Drawing.Size(807, 25)
        Me.Balance_AscendingToolStrip.TabIndex = 11
        Me.Balance_AscendingToolStrip.Text = "Balance_AscendingToolStrip"
        '
        'Balance_AscendingToolStripButton
        '
        Me.Balance_AscendingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Balance_AscendingToolStripButton.Name = "Balance_AscendingToolStripButton"
        Me.Balance_AscendingToolStripButton.Size = New System.Drawing.Size(111, 22)
        Me.Balance_AscendingToolStripButton.Text = "Balance Ascending"
        '
        'Balance_DescendingToolStrip
        '
        Me.Balance_DescendingToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Balance_DescendingToolStripButton})
        Me.Balance_DescendingToolStrip.Location = New System.Drawing.Point(0, 74)
        Me.Balance_DescendingToolStrip.Name = "Balance_DescendingToolStrip"
        Me.Balance_DescendingToolStrip.Size = New System.Drawing.Size(807, 25)
        Me.Balance_DescendingToolStrip.TabIndex = 12
        Me.Balance_DescendingToolStrip.Text = "Balance_DescendingToolStrip"
        '
        'Balance_DescendingToolStripButton
        '
        Me.Balance_DescendingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Balance_DescendingToolStripButton.Name = "Balance_DescendingToolStripButton"
        Me.Balance_DescendingToolStripButton.Size = New System.Drawing.Size(117, 22)
        Me.Balance_DescendingToolStripButton.Text = "Balance Descending"
        '
        'Name3ToolStrip
        '
        Me.Name3ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripLabel, Me.NameToolStripTextBox, Me.Name3ToolStripButton})
        Me.Name3ToolStrip.Location = New System.Drawing.Point(0, 99)
        Me.Name3ToolStrip.Name = "Name3ToolStrip"
        Me.Name3ToolStrip.Size = New System.Drawing.Size(807, 25)
        Me.Name3ToolStrip.TabIndex = 13
        Me.Name3ToolStrip.Text = "Name3ToolStrip"
        '
        'NameToolStripLabel
        '
        Me.NameToolStripLabel.Name = "NameToolStripLabel"
        Me.NameToolStripLabel.Size = New System.Drawing.Size(42, 22)
        Me.NameToolStripLabel.Text = "Name:"
        '
        'NameToolStripTextBox
        '
        Me.NameToolStripTextBox.Name = "NameToolStripTextBox"
        Me.NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Name3ToolStripButton
        '
        Me.Name3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Name3ToolStripButton.Name = "Name3ToolStripButton"
        Me.Name3ToolStripButton.Size = New System.Drawing.Size(49, 22)
        Me.Name3ToolStripButton.Text = "Search "
        '
        'ResetToolStrip
        '
        Me.ResetToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripButton})
        Me.ResetToolStrip.Location = New System.Drawing.Point(0, 124)
        Me.ResetToolStrip.Name = "ResetToolStrip"
        Me.ResetToolStrip.Size = New System.Drawing.Size(807, 25)
        Me.ResetToolStrip.TabIndex = 14
        Me.ResetToolStrip.Text = "ResetToolStrip"
        '
        'ResetToolStripButton
        '
        Me.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetToolStripButton.Name = "ResetToolStripButton"
        Me.ResetToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.ResetToolStripButton.Text = "Reset"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Database_Assignment.bankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(14, 359)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 1
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(95, 359)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(75, 23)
        Me.editbtn.TabIndex = 4
        Me.editbtn.Text = "Edit Details"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'donebtn
        '
        Me.donebtn.Location = New System.Drawing.Point(176, 359)
        Me.donebtn.Name = "donebtn"
        Me.donebtn.Size = New System.Drawing.Size(75, 23)
        Me.donebtn.TabIndex = 2
        Me.donebtn.Text = "Done"
        Me.donebtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 496)
        Me.Controls.Add(Me.donebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.ResetToolStrip)
        Me.Controls.Add(Me.Name3ToolStrip)
        Me.Controls.Add(Me.Balance_DescendingToolStrip)
        Me.Controls.Add(Me.Balance_AscendingToolStrip)
        Me.Controls.Add(lblOverdraft)
        Me.Controls.Add(Me.chckboxOverd)
        Me.Controls.Add(lblBalance)
        Me.Controls.Add(Me.txtboxBalance)
        Me.Controls.Add(lblName)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(lblID)
        Me.Controls.Add(Me.txtboxid)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(823, 535)
        Me.MinimumSize = New System.Drawing.Size(823, 535)
        Me.Name = "Database"
        Me.Text = "Database"
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Balance_AscendingToolStrip.ResumeLayout(False)
        Me.Balance_AscendingToolStrip.PerformLayout()
        Me.Balance_DescendingToolStrip.ResumeLayout(False)
        Me.Balance_DescendingToolStrip.PerformLayout()
        Me.Name3ToolStrip.ResumeLayout(False)
        Me.Name3ToolStrip.PerformLayout()
        Me.ResetToolStrip.ResumeLayout(False)
        Me.ResetToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As Database_Assignment.bankDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Database_Assignment.bankDataSetTableAdapters.customersTableAdapter
    Friend WithEvents TableAdapterManager As Database_Assignment.bankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtboxid As System.Windows.Forms.TextBox
    Friend WithEvents txtboxName As System.Windows.Forms.TextBox
    Friend WithEvents txtboxBalance As System.Windows.Forms.TextBox
    Friend WithEvents chckboxOverd As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Balance_AscendingToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Balance_AscendingToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Balance_DescendingToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Balance_DescendingToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Name3ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Name3ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResetToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ResetToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cancelbtn As System.Windows.Forms.Button
    Friend WithEvents editbtn As System.Windows.Forms.Button
    Friend WithEvents donebtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
