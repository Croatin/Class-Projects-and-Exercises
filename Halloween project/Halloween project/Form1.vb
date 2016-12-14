Public Class Form1

    Private Sub tmrGameTimer_Tick(sender As Object, e As EventArgs) Handles tmrGameTimer.Tick
        Dim rand As New Random

        Dim intNewLeft, intNewTop As Integer

        intNewLeft = rand.Next(Me.Width - btnCatchMe.Width)

        intNewTop = rand.Next(Me.Width - btnCatchMe.Height)

        btnCatchMe.Left = intNewLeft
        btnCatchMe.Top = intNewTop
    End Sub

    Private Sub btnCatchMe_Click(sender As Object, e As EventArgs) Handles btnCatchMe.Click
        tmrGameTimer.Enabled = False
        MessageBox.Show("You Win!")
    End Sub
End Class
