Public Class Form1
    Public name As String
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim password As String
        Dim num As Integer
        name = InputBox(name)
        password = txtPassword.Text
        num = password.Length

        Try
            If password.Length < 8 Then
                labelerror.Text = "Does not meet specification"
            Else
                name = txtUsername.Text.Remove(0, 0)
                txtUsername.Text = name.Insert(0, "Ms.")
                Form2.Show()
            End If
        Catch ex As Exception
            ' Handle the exception, for example:
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Dim temp = password.Trim
        Dim num2 As Integer = temp
        MsgBox("char" & num)
        Dim username As String = ""
        Dim firstName As String
        username = InputBox("Enter your name.", name)
        firstName = username.Substring(0, 6)
        MsgBox("Your first name is " + firstName)
    End Sub
End Class
