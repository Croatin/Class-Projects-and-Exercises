Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAdultFee As Decimal = CDec(txtAdultPrice.Text)
        Dim decChildFee As Decimal = CDec(txtChildrenPrice.Text)
        Dim decGrossRevenue As Decimal
        Dim decNetRevenue As Decimal
        Dim intAdultSales As Integer = CDec(txtAdultSold.Text)
        Dim intChildSales As Integer = CDec(txtChildrenSold.Text)

        Dim blnInputOk As Boolean = True

        Const decPercentage As Decimal = CDec(0.2)

        Dim decAdultTotal As Decimal
        Dim decChildTotal As Decimal
        Dim decAdultTotalNet As Decimal
        Dim decChildTotalNet As Decimal


        If Decimal.TryParse(txtAdultPrice.Text, decAdultFee) = False Then
            MessageBox.Show("Invalid input for Adult Price")
            blnInputOk = False
        ElseIf Decimal.TryParse(txtAdultSold.Text, decAdultFee) = False Then
            MessageBox.Show("Invalid input for Adult Sold")
            blnInputOk = False
        ElseIf Decimal.TryParse(txtChildrenPrice.Text, decAdultFee) = False Then
            MessageBox.Show("Invalid input for Child Price")
            blnInputOk = False
        ElseIf Decimal.TryParse(txtChildrenSold.Text, decAdultFee) = False Then
            MessageBox.Show("Invalid input for Children sold")
            blnInputOk = False
        End If

        If blnInputOk = True Then
            decAdultTotal = decAdultFee * intAdultSales
            decChildFee *= intChildSales
            decGrossRevenue = decAdultFee + decChildFee
            lblAdultTicketSales.Text = decAdultFee
            lblChildTicketSales.Text = decChildFee
            lblGrossRevenue.Text = decGrossRevenue

            decAdultFee *= decPercentage
            decChildFee *= decPercentage
            lblAdultNet.Text = decAdultTotal
            lblChildNet.Text = decChildFee
            lblTotalNet.Text = decAdultFee + decChildFee

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Text = String.Empty
        txtAdultSold.Text = String.Empty
        txtChildrenPrice.Text = String.Empty
        txtChildrenSold.Text = String.Empty

        lblAdultTicketSales.Text = String.Empty
        lblChildTicketSales.Text = String.Empty
        lblGrossRevenue.Text = String.Empty
        lblAdultNet.Text = String.Empty
        lblTotalNet.Text = String.Empty
        lblChildNet.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

