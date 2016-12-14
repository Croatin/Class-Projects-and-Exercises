Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = cboPlays.Text
        lblArtist.Text = cboArtists.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cboCountries.SelectedIndex = -1
        cboCountries.Text = String.Empty

        cboPlays.SelectedIndex = -1
        cboArtists.Text = String.Empty

        cboArtists.SelectedIndex = -1
        cboArtists.Text = String.Empty

        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub lblPlay_Click(sender As Object, e As EventArgs) Handles lblPlay.Click

    End Sub
End Class
