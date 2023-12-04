Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHello.Click
        lblHello.Text = "Hello Miss. " + Form1.name
    End Sub

    Private Sub SportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportsToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class