Public Class Database

    'declare variables
    Dim counter As Integer = 0 'change id no
    Dim tempname As String 'Temp values for edit details button
    Dim tempbalance As String 'Temp values for edit details button
    Dim tempoverdraft 'Temp values for edit details button

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

        MessageBox.Show("Database Updated",
        "Database Updated")

    End Sub

    Private Sub frmDatabase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'prompt user program is ending
        MessageBox.Show("Program ending",
        "Program Ending")
        End

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.CustomersTableAdapter.Fill(Me.BankDataSet.customers)
        ' edit within the database 
        'make the btns not visble
        donebtn.Visible = False
        cancelbtn.Visible = False
        txtboxName.Enabled = False
        txtboxBalance.Enabled = False
        chckboxOverd.Enabled = False
        txtboxid.Enabled = False
        CustomersDataGridView.Enabled = False

    End Sub

    Private Sub Balance_AscendingToolStripButton_Click(sender As Object, e As EventArgs) Handles Balance_AscendingToolStripButton.Click

        Try
            Me.CustomersTableAdapter.Balance_Ascending(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Balance_DescendingToolStripButton_Click(sender As Object, e As EventArgs) Handles Balance_DescendingToolStripButton.Click

        Try
            Me.CustomersTableAdapter.Balance_Descending(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub NameToolStripButton_Click(sender As Object, e As EventArgs)

        Try
            Me.CustomersTableAdapter.Name(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Name1ToolStripButton_Click(sender As Object, e As EventArgs)

        Try
            Me.CustomersTableAdapter.Name1(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Name2ToolStripButton_Click(sender As Object, e As EventArgs)

        Try
            Me.CustomersTableAdapter.Name2(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Name3ToolStripButton_Click(sender As Object, e As EventArgs) Handles Name3ToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Name3(Me.BankDataSet.customers, NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ResetToolStripButton_Click(sender As Object, e As EventArgs) Handles ResetToolStripButton.Click

        Try
            Me.CustomersTableAdapter.Reset(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'clear data in search
        NameToolStripTextBox.Clear()

    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        'about info
        MessageBox.Show("Created by Brian Kelly " & vbCrLf & " © Brian Kelly",
        "About")

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles donebtn.Click

        'Validation 
        If txtboxName.Text = "" Or IsNumeric(txtboxName.Text) Then
            'prompt user for correct name.
            MessageBox.Show("Please enter a valid name",
            "Invalid name ")
            'focus on txt box name
            txtboxName.Focus()
            Exit Sub
        End If

        'Validation
        If txtboxBalance.Text = "" Then
            'prompt user for valid balance 
            MessageBox.Show("Please enter a valid balance",
            "Invalid balance")
            'focus on txt box balance 
            txtboxBalance.Focus()
            Exit Sub
            'Validation
        ElseIf Not IsNumeric(txtboxBalance.Text) Then
            'prompt user for valid balance 
            MessageBox.Show("Please enter a valid balance)",
            "Invalid balance")
            'focus on txt box balance
            txtboxBalance.Focus()
            Exit Sub
            'validate overdraft
        ElseIf chckboxOverd.CheckState = 2 Then
            'prompt user to select on option 
            MessageBox.Show("Please select a overdraft option",
            "Invalid overdraft")
            'focus on overdraft
            chckboxOverd.Focus()
            Exit Sub
        End If
        'update the data 
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.BankDataSet.AcceptChanges()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)
        'prompt user changes have been saved 
        MessageBox.Show("Database updated",
        "Updated")
        'enabed the timer 
        Timer1.Enabled = True
        'enable 
        CustomersBindingNavigator.Enabled = True
        Balance_AscendingToolStrip.Enabled = True
        Balance_DescendingToolStrip.Enabled = True
        Name3ToolStrip.Enabled = True
        ResetToolStrip.Enabled = True
        'disbale
        txtboxid.Enabled = False
        CustomersDataGridView.Enabled = False
        txtboxName.Enabled = False
        txtboxBalance.Enabled = False
        chckboxOverd.Enabled = False

        'btns are not visible 
        donebtn.Visible = False
        cancelbtn.Visible = False

        'btn edit is visible
        editbtn.Visible = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        'timer for new entry 
        Timer1.Enabled = True
        'disabled 
        CustomersBindingNavigator.Enabled = False
        Balance_AscendingToolStrip.Enabled = False
        Balance_DescendingToolStrip.Enabled = False
        Name3ToolStrip.Enabled = False
        ResetToolStrip.Enabled = False
        txtboxid.Enabled = False
        CustomersDataGridView.Enabled = False

        'enable the txt box 
        txtboxName.Enabled = True
        txtboxBalance.Enabled = True
        chckboxOverd.Enabled = True
        'btns are visible 
        donebtn.Visible = True
        cancelbtn.Visible = True

        'edit btn not viible 
        editbtn.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'increment counter
        counter += 1

        'when count is 2 update the value ID 
        If counter = 2 Then
            txtboxid.Text = BindingNavigatorPositionItem.Text
            'end the timer
            Timer1.Enabled = False
            'reset counter to 0
            counter = 0
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click


        'temp values for canceling in edit 
        txtboxName.Text = tempname
        txtboxBalance.Text = tempbalance
        chckboxOverd.CheckState = tempoverdraft
        '`promptuser that they canceled edit 
        MessageBox.Show("Cancel edit seleted",
        "Edit Canceled")
        'enable 
        CustomersBindingNavigator.Enabled = True
        Balance_AscendingToolStrip.Enabled = True
        Balance_DescendingToolStrip.Enabled = True
        Name3ToolStrip.Enabled = True
        ResetToolStrip.Enabled = True
        txtboxid.Enabled = False
        CustomersDataGridView.Enabled = False

        'enabled the text boxs 
        txtboxName.Enabled = False
        txtboxBalance.Enabled = False
        chckboxOverd.Enabled = False
        'disbable the btns 
        donebtn.Visible = False
        cancelbtn.Visible = False
        'hide the edit btn 
        editbtn.Visible = True

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles editbtn.Click

        'enable the timer for entry
        Timer1.Enabled = True
        'temp values for cancel edit
        tempname = txtboxName.Text
        tempbalance = txtboxBalance.Text
        tempoverdraft = chckboxOverd.CheckState
        'disbale the functions 
        CustomersBindingNavigator.Enabled = False
        Balance_AscendingToolStrip.Enabled = False
        Balance_DescendingToolStrip.Enabled = False
        Name3ToolStrip.Enabled = False
        ResetToolStrip.Enabled = False
        txtboxid.Enabled = False
        CustomersDataGridView.Enabled = False
        'enable the txt boxs 
        txtboxName.Enabled = True
        txtboxBalance.Enabled = True
        chckboxOverd.Enabled = True
        'make the btns visible 
        donebtn.Visible = True
        cancelbtn.Visible = True
        'hide the edit btn
        editbtn.Visible = False

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        'prompt user the entry has been deleted 
        MessageBox.Show("Entry Deleted",
        "Deleted Entry")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'prompt user the program is ending
        MessageBox.Show("Program ending",
        "Program ending")
        Me.Hide()
        Login.Show()

    End Sub

End Class