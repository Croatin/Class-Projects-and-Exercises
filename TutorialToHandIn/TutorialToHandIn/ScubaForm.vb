Public Class ScubaForm

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Const decSCUBA_PRICE_PER_PERSON As Decimal = 3000D
        Dim intNumberofPeople As Integer
        Dim decDiscount As Decimal
        Dim decTotal As Decimal

        Try
            intNumberofPeople = CInt(txtNumberOfPeople.Text)

            decTotal = intNumberofPeople * decSCUBA_PRICE_PER_PERSON

            If intNumberofPeople >= g_intMINIMUM_FOR_DISCOUNT Then
                decDiscount = CalcDiscount(decTotal)

                decTotal = decTotal - decDiscount
            Else
                decDiscount = 0D
            End If

            lblDiscount.Text = decDiscount.ToString("c")
            lblTotal.Text = decTotal.ToString("c")
        Catch ex As Exception
            MessageBox.Show("Enter Ingeger")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOfPeople.Clear()
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class