Public Class Form1

    Const decWHITE_BAGEL As Decimal = 1.25
    Const decWHOLE_WHEAT As Decimal = 1.5
    Const decLATTE As Decimal = 1.52

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetBagels()
        resetToppings()
        resetPrice()
        resetCoffee()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim dectotal As Decimal

        decSubtotal = calcBagel() + calcCoffee() + calcToppings()
        decTax = calcTax(decSubtotal)
        dectotal = decSubtotal + decTax

        lblSubTotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = dectotal.ToString("c")

    End Sub
    Function calcBagel() As Decimal
        Dim decBagel As Decimal

        If radWhite.Checked = True Then
            decBagel = decWHITE_BAGEL
        Else
            decBagel = decWHOLE_WHEAT
        End If
        Return decBagel
    End Function

    Function calcCoffee() As Decimal
        Dim decCoffee As Decimal

        If radNone.Checked = True Then
            decCoffee = 0D
        ElseIf radRegular.Checked = True Then
            decCoffee = 1.25D
        ElseIf radLatte.Checked = True Then
            decCoffee = 1.5D
        ElseIf radMocha.Checked = True Then
            decCoffee = 1.5D
        End If

        Return decCoffee
    End Function

    Function calcToppings() As Decimal
        Dim decTopping As Decimal

        If chkButter.Checked = True Then
            decTopping += decBUTTER
        End If
        If chkCreamCheese.Checked = True Then
            decTopping += decCREAMCHEESE
        End If
        If chkCinnamon.Checked = True Then
            decTopping += decCINNAMON
        End If
        If chkOnions.Checked = True Then
            decTopping += decONION
        End If
        If chkSourCream.Checked = True Then
            decTopping += decSOURCREAM
        End If

        Return decTopping
    End Function

    Function calcTax(ByVal decAmount As Decimal)
        Return decAmount * decTAX_RATE
    End Function


    Sub ResetBagels()
        radWhite.Checked = True
    End Sub
    Sub resetCoffee()
        radNone.Checked = True
    End Sub
    Sub resetToppings()
        chkButter.Checked = False
        chkCreamCheese.Checked = False
        chkCinnamon.Checked = False
        chkOnions.Checked = False
        chkSourCream.Checked = False
        chkButter.Checked = False
    End Sub
    Sub resetPrice()
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
