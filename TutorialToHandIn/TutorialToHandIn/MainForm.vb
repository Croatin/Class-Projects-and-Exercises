Public Class MainForm

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ScubaDivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScubaDivingToolStripMenuItem.Click
        Dim frmScuba As New ScubaForm

        frmScuba.ShowDialog()
    End Sub

    Private Sub SkyDivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkyDivingToolStripMenuItem.Click
        Dim frmSkyDive As New SkyDiveForm

        frmSkyDive.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("We help calculate expenses for skydiving and scuba trips.")

    End Sub
End Class
