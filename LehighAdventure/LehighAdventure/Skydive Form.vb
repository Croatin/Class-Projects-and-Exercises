Public Class SkydiveForm


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNumberOfPeople.Clear()
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const decSCUBA_PRICE_PER_PERSON As Decimal = 2500D
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
End Class