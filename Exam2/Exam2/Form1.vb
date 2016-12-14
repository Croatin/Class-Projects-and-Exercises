Public Class Form1

    Const intMAX_SUBSCRIPT As Integer = 11
    Dim dblRainfall(intMAX_SUBSCRIPT) As Double
    Dim intCount As Integer = 0
    Dim strMonths() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Dim dblTotalRain As Double
    Dim dblAvgRain As Double
    Dim dblMinRain As Double = 1000000000
    Dim intMinMonth As Integer
    Dim dblMaxRain As Double
    Dim intMaxMonth As Integer


    Private Sub btnRainfall_Click(sender As Object, e As EventArgs) Handles btnRainfall.Click
        For Me.intCount = 0 To intMAX_SUBSCRIPT
            Try
                dblRainfall(intCount) = CDec(InputBox("Enter the amount of rainfall for " & strMonths(intCount) & "."))
            Catch ex As Exception
                MessageBox.Show("Please input valid Rainfall")
            End Try
        Next

        lstRainfallInput.Items.Clear()
        For Me.intCount = 0 To intMAX_SUBSCRIPT
            lstRainfallInput.Items.Add(dblRainfall(intCount))
        Next

    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        For Me.intCount = 0 To intMAX_SUBSCRIPT
            dblTotalRain += dblRainfall(intCount)
        Next

        lblTotalAnnualRainfall.Text = ("The Total annual rainfal was: " & dblTotalRain & ".")

        dblAvgRain = dblTotalRain / 2

        lblAvgMonthlyRainfall.Text = ("The average monthly rainfall was: " & dblAvgRain & ".")

        For Me.intCount = 0 To intMAX_SUBSCRIPT
            If dblMinRain > dblRainfall(intCount) Then
                dblMinRain = dblRainfall(intCount)
                intMinMonth = intCount
            End If
        Next

        lblMinRainfall.Text = ("The minimum monthly rainfall was: " & dblMinRain & " in " & strMonths(intMinMonth) & ".")

        For Me.intCount = 0 To intMAX_SUBSCRIPT
            If dblMaxRain < dblRainfall(intCount) Then
                dblMaxRain = dblRainfall(intCount)
                intMaxMonth = intCount
            End If
        Next
        lblMaxRainfall.Text = ("The maximum monthly rainfall was: " & dblMaxRain & " in " & strMonths(intMaxMonth) & ".")

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        lstRainfallInput.Items.Clear()
        lblAvgMonthlyRainfall.Text = (" ")
        lblTotalAnnualRainfall.Text = (" ")
        lblMaxRainfall.Text = (" ")
        lblMinRainfall.Text = (" ")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
