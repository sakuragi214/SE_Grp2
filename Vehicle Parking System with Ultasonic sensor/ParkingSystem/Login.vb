

Public Class Login
    Dim user As String
    Dim pass As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim login As New LoginFormClass(txtUser.Text, txtPass.Text)
        login.userverify()
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        Me.Hide()
        RegisterStaff.Show()
    End Sub
End Class