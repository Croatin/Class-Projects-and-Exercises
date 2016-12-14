Public Class Scubaform

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub mnuScubaDiving_Click(sender As Object, e As EventArgs) Handles mnuScubaDiving.Click
        Dim frmScuba As New ScubaForm

        frmScuba.ShowDialog()

    End Sub

    Private Sub mnuSkyDiving_Click(sender As Object, e As EventArgs) Handles mnuSkyDiving.Click
        Dim frmSkyDive As New SkydiveForm

        frmSkyDive.ShowDialog()

    End Sub