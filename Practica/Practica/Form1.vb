Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Label2.Text + 0.1
        If Label2.Text = 100 Then

            Form2.Show()

        End If

    End Sub
End Class
