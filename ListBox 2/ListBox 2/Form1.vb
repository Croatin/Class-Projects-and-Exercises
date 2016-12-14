Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRunDemo.Click
        Dim intCount As Integer = 100
        Do intCount < 10
            lstOutput.Items.Add("HELLO WORLD")
            intCount += 1
        Loop While intCount < 10
    End Sub
End Class
