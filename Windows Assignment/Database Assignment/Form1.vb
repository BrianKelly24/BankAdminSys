Public Class Login


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

        'enter correct name and password
        If txtUname.Text = "admin" And txtPass.Text = "password" Then
            MessageBox.Show("Login Successful",
            "Login Successful")
            'hide the login form
            Me.Hide()
            'show the second form 
            Database.Show()
            txtUname.Clear()
            txtPass.Clear()

            Exit Sub
        End If

        'Validation
        If txtUname.Text <> "admin" Then
            'prompt user to enter correct details
            MessageBox.Show("Please enter a username",
            "Invalid Username")
            'focus on username txt box
            txtUname.Focus()
            Exit Sub
        End If

        'validation
        If txtPass.Text <> "password" Then
            'prompt the user to enter correct details
            MessageBox.Show("Please enter a password",
            "Invalid Password")
            'focus on password txt box
            txtPass.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        'file>about information
        MessageBox.Show("Created by Brian Kelly " & vbCrLf & " © Brian Kelly",
        "About")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles clearbtn.Click

        'clears the username textbox
        txtUname.Clear()
        'clears the password textbox
        txtPass.Clear()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'prompt user to show program ending
        MessageBox.Show("Program ending",
        "Program ending")

        'code for exiting the application
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'prompt user that the program is ending
        MessageBox.Show("Program ending",
        "Program ending")

        End


    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
