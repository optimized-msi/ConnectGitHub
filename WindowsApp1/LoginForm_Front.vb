Public Class LoginForm_Front

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Hide()
        Form_MainMenu.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        Form_MainMenu.Show()
    End Sub

    Private Sub LoginForm_Front_load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.FormClosed

    End Sub

    Private Sub LoginForm_Front_load(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form_MainMenu.Show()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles Label_Username.Click

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Txb_Username.Click

    End Sub
End Class


