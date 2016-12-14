Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim stuName1 As String = txtStudentName1.Text
        Dim stuName2 As String = txtStudentName2.Text
        Dim stuName3 As String = txtStudentName3.Text

        Dim stu1Gr1 As Double = CDbl(txtStudent1Grade1.Text)
        Dim stu1Gr2 As Double = CDbl(txtStudent1Grade2.Text)
        Dim stu1Gr3 As Double = CDbl(txtStudent1Grade3.Text)
        Dim stu2Gr1 As Double = CDbl(txtStudent2Grade1.Text)
        Dim stu2Gr2 As Double = CDbl(txtStudent2Grade2.Text)
        Dim stu2Gr3 As Double = CDbl(txtStudent3Grade3.Text)
        Dim stu3Gr1 As Double = CDbl(txtStudent1Grade1.Text)
        Dim stu3Gr2 As Double = CDbl(txtStudent2Grade2.Text)
        Dim stu3Gr3 As Double = CDbl(txtStudent3Grade3.Text)

        Dim stu1Avg As Double
        Dim stu2Avg As Double
        Dim stu3Avg As Double

        Dim grade1 As Char
        Dim grade2 As Char
        Dim grade3 As Char

        stu1Avg = (stu1Gr1 + stu1Gr2 + stu1Gr3) / 3
        stu2Avg = (stu2Gr1 + stu2Gr2 + stu2Gr3) / 3
        stu3Avg = (stu3Gr1 + stu3Gr2 + stu3Gr3) / 3

        If stu1Avg < 60 Then
            grade1 = "F"
        ElseIf stu1Avg < 70 Then
            grade1 = "D"
        ElseIf stu1Avg < 80 Then
            grade1 = "C"
        ElseIf stu1Avg < 90 Then
            grade1 = "B"
        ElseIf stu1Avg < 100 Then
            grade1 = "A"
        End If

        If stu2Avg < 60 Then
            grade2 = "F"
        ElseIf stu2Avg < 70 Then
            grade2 = "D"
        ElseIf stu2Avg < 80 Then
            grade2 = "C"
        ElseIf stu2Avg < 90 Then
            grade2 = "B"
        ElseIf stu2Avg < 100 Then
            grade2 = "A"
        End If

        If stu3Avg < 60 Then
            grade3 = "F"
        ElseIf stu3Avg < 70 Then
            grade3 = "D"
        ElseIf stu3Avg < 80 Then
            grade3 = "C"
        ElseIf stu3Avg < 90 Then
            grade3 = "B"
        ElseIf stu3Avg < 100 Then
            grade3 = "A"
        End If

        Dim fullInfo1 As String = stuName1 & "'s Average: " & stu1Avg & " Grade: " & grade1 & "."
        Dim fullInfo2 As String = stuName2 & "'s Average: " & stu2Avg & " Grade: " & grade2 & "."
        Dim fullInfo3 As String = stuName3 & "'s Average: " & stu3Avg & " Grade: " & grade3 & "."

        libAverageBox.Items.Add(fullInfo1)
        libAverageBox.Items.Add(fullInfo2)
        libAverageBox.Items.Add(fullInfo3)
    End Sub

    
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
