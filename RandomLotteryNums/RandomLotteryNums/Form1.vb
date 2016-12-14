Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Const intMAX_SUBSCRIPT As Integer = 4
        Dim intIntegers(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMAX_SUBSCRIPT
            intIntegers(intCount) = rand.Next(100)
        Next

        lblFirst.Text = intIntegers(0).ToString()
        lblSecond.Text = intIntegers(1).ToString()
        lblThird.Text = intIntegers(2).ToString()
        lblFourth.Text = intIntegers(3).ToString()
        lblFifth.Text = intIntegers(4).ToString()

    End Sub
End Class
