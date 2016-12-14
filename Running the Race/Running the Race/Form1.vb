Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim time1 As Integer = CInt(txtTime1.Text)
        Dim time2 As Integer = CInt(txtTime2.Text)
        Dim time3 As Integer = CInt(txtTime3.Text)

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim cont As Boolean = True
        Try

            If time1 < 0 Then
                MessageBox.Show("The time for runner 1 must be positive")
                cont = False
            End If

            If time2 < 0 Then
                MessageBox.Show("The time for runner 2 must be positive")
                cont = False
            End If

            If time3 < 0 Then
                MessageBox.Show("The time for runner 3 must be positive")
                cont = False
            End If

            If txtRunner1.Text = String.Empty Then
                MessageBox.Show("The name for runner 1 cannot be empty")
                cont = False
            End If
            If txtRunner2.Text = String.Empty Then
                MessageBox.Show("The name for runner 2 cannot be empty")
                cont = False
            End If
            If txtRunner3.Text = String.Empty Then
                MessageBox.Show("The name for runner 3 cannot be empty")
            End If

            If cont Then

                If (time1 > time2 And time1 > time3) Then
                    lblThirdPlace.Text = txtRunner1.Text
                ElseIf (time1 > time2 And time1 < time3 Or time1 < time2 And time1 < time3) Then
                    lblSecondPlace.Text = txtRunner1.Text
                ElseIf (time1 < time2 And time1 < time3) Then
                    lblFirstPlace.Text = txtRunner1.Text
                End If

                If (time2 > time1 And time2 > time3) Then
                    lblThirdPlace.Text = txtRunner2.Text
                ElseIf (time2 > time1 And time2 < time3 Or time2 < time1 And time2 > time3) Then
                    lblSecondPlace.Text = txtRunner2.Text
                ElseIf (time2 < time1 And time2 < time3) Then
                    lblFirstPlace.Text = txtRunner2.Text
                End If

                If (time3 > time1 And time3 > time2) Then
                    lblThirdPlace.Text = txtRunner3.Text
                ElseIf (time3 > time1 And time3 < time2 Or time3 < time1 And time3 > time2) Then
                    lblSecondPlace.Text = txtRunner3.Text
                ElseIf (time3 < time1 And time3 < time2) Then
                    lblFirstPlace.Text = txtRunner3.Text
                End If

            End If
        Catch ex As Exception

        End Try

        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblFirstPlace.Text = String.Empty
        lblSecondPlace.Text = String.Empty
        lblThirdPlace.Text = String.Empty
        txtRunner1.Text = String.Empty
        txtRunner2.Text = String.Empty
        txtRunner3.Text = String.Empty
        txtTime1.Text = String.Empty
        txtTime2.Text = String.Empty
        txtTime3.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
