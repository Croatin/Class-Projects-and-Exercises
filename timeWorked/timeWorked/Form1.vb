Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Const decHOURLY_PAYRATE As Decimal = 12D
        Const intMAX_SUBSCRIPT As Integer = 5

        Dim dblHoursArray(intMAX_SUBSCRIPT) As Double
        Dim intcount As Integer = 0
        Dim decEmpPay As Decimal

        Do While intcount < dblHoursArray.Length

            Try
                dblHoursArray(intcount) = CDbl(InputBox("Employee number " & (intcount + 1).ToString()))

                intcount += 1
            Catch ex As Exception
                MessageBox.Show("Enter Number")

            End Try

            lstOutput.Items.Clear()

            For intcount = 0 To dblHoursArray.Length - 1
                decEmpPay = CDec(dblHoursArray(intcount) * decHOURLY_PAYRATE)

                lstOutput.Items.Add("Employee " & (intcount + 1).ToString() & " earned " & decEmpPay.ToString("c"))
            Next

        Loop

    End Sub
End Class
