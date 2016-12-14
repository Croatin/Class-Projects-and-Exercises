Public Class Form1

    Const dblMONTHS_YEAR As Double = 12
    Const dblNEW_RATE As Double = 0.05
    Const dblUSED_RATE As Double = 0.08

    Dim dblAnnualRate As Double = dblNEW_RATE



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVehicleCost As Double
        Dim dblDownpayment As Double
        Dim intMonths As Integer
        Dim dblLoan As Double
        Dim dblMonthlyPayment As Double
        Dim blnInputOk As Boolean

        If Not Double.TryParse(txtCost.Text, dblVehicleCost) Then
            lblMessage.Text = "Vehicle cost must be a number"
        End If

        If Not Double.TryParse(txtDownPayment.Text, dblDownpayment) Then
            lblMessage.Text = "Down payment must be a number"
        End If

        If blnInputOk = True Then
            dblLoan = dblVehicleCost - dblDownpayment
            dblMonthlyPayment = Pmt(dblAnnualRate / dblMONTHS_YEAR, intMonths, -dblLoan)
            lstOutput.Items.Add(dblMonthlyPayment)
        End If



    End Sub
End Class
