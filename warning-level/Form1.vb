Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        PictureBox2.Height = 205 - ProgressBar1.Value * 2
        Label1.Text = ProgressBar1.Value & (" %")




        If ProgressBar1.Value = 10 Then
            Label2.Text = "Prepare"

        End If
        If ProgressBar1.Value >= 50 Then
            Label2.Text = "Warning"

        End If
        If ProgressBar1.Value >= 85 Then
            Label2.Text = "SEVERE! EVACUATE"

        End If

    End Sub
End Class
