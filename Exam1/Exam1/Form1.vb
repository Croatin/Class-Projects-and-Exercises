Public Class Form1

    
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Const dblNO_DISCOUNT As Double = 1.0
        Const dblTWENTY_PERCENT_DISCOUNT As Double = 0.8
        Const dblTHIRTY_PERCENT_DISCOUNT As Double = 0.7
        Const dblFOURTY_PERCENT_DISCOUNT As Double = 0.6
        Const dblFIFTY_PERCENT_DISCOUNT As Double = 0.5

        Const dblRETAIL_PRICE_PACKAGE_A As Double = 99.0
        Const dblRETAIL_PRICE_PACKAGE_B As Double = 199.0
        Const dblRETAIL_PRICE_PACKAGE_C As Double = 299.0

        Dim intQuantitySoldPackageA As Integer
        Dim intQuantitySoldPackageB As Integer
        Dim intQuantitySoldPackageC As Integer

        Dim dblDiscountPackageA As Double
        Dim dblDiscountPackageB As Double
        Dim dblDiscountPackageC As Double

        Dim dblTotalCostPackageA As Double
        Dim dblTotalCostPackageB As Double
        Dim dblTotalCostPackageC As Double
        Dim dblGrandTotal As Double

        Dim strOutputPackageA As String
        Dim strOutputPackageB As String
        Dim strOutputPackageC As String
        Dim strOutputGrandTotal As String

        Dim isInteger As Boolean = True

        Try
            intQuantitySoldPackageA = CInt(txtQuantitySoldPackageA.Text)
        Catch
            MessageBox.Show("Input in Package A is not an integer")
            isInteger = False
        End Try

        Try
            intQuantitySoldPackageB = CInt(txtQuantitySoldPackageB.Text)
        Catch
            MessageBox.Show("Input in Package B is not an integer")
            isInteger = False
        End Try

        Try
            intQuantitySoldPackageC = CInt(txtQuantitySoldPackageC.Text)
        Catch
            MessageBox.Show("Input in Package C is not an integer")
            isInteger = False
        End Try

        'intQuantitySoldPackageA = txtQuantitySoldPackageA.Text
        'intQuantitySoldPackageB = txtQuantitySoldPackageB.Text
        'intQuantitySoldPackageC = txtQuantitySoldPackageC.Text

        dblTotalCostPackageA = intQuantitySoldPackageA * dblRETAIL_PRICE_PACKAGE_A
        dblTotalCostPackageB = intQuantitySoldPackageB * dblRETAIL_PRICE_PACKAGE_B
        dblTotalCostPackageC = intQuantitySoldPackageC * dblRETAIL_PRICE_PACKAGE_C


        If isInteger Then
            'Package A'
            If intQuantitySoldPackageA >= 10 And intQuantitySoldPackageA <= 19 Then
                dblDiscountPackageA = dblTWENTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageA >= 20 And intQuantitySoldPackageA <= 49 Then
                dblDiscountPackageA = dblTHIRTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageA >= 50 And intQuantitySoldPackageA <= 99 Then
                dblDiscountPackageA = dblFOURTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageA > 99 Then
                dblDiscountPackageA = dblFIFTY_PERCENT_DISCOUNT
            End If
            'PackageB'
            If intQuantitySoldPackageB >= 10 And intQuantitySoldPackageB <= 19 Then
                dblDiscountPackageB = dblTWENTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageB >= 20 And intQuantitySoldPackageB <= 49 Then
                dblDiscountPackageB = dblTHIRTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageB >= 50 And intQuantitySoldPackageB <= 99 Then
                dblDiscountPackageB = dblFOURTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageB > 99 Then
                dblDiscountPackageB = dblFIFTY_PERCENT_DISCOUNT
            End If
            'PackageC'
            If intQuantitySoldPackageC >= 10 And intQuantitySoldPackageC <= 19 Then
                dblDiscountPackageC = dblTWENTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageC >= 20 And intQuantitySoldPackageC <= 49 Then
                dblDiscountPackageC = dblTHIRTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageC >= 50 And intQuantitySoldPackageC <= 99 Then
                dblDiscountPackageC = dblFOURTY_PERCENT_DISCOUNT
            ElseIf intQuantitySoldPackageC > 99 Then
                dblDiscountPackageC = dblFIFTY_PERCENT_DISCOUNT
            End If

            dblTotalCostPackageA *= dblDiscountPackageA
            dblTotalCostPackageB *= dblDiscountPackageB
            dblTotalCostPackageC *= dblDiscountPackageC

            dblGrandTotal = dblTotalCostPackageA + dblTotalCostPackageB + dblTotalCostPackageC

            strOutputPackageA = "Package A: " & dblTotalCostPackageA & "."
            strOutputPackageB = "Package B: " & dblTotalCostPackageB & "."
            strOutputPackageC = "Package C: " & dblTotalCostPackageC & "."
            strOutputGrandTotal = "Grand Total: " & dblGrandTotal & "."

            lstSales.Items.Add(strOutputPackageA)
            lstSales.Items.Add(strOutputPackageB)
            lstSales.Items.Add(strOutputPackageC)
            lstSales.Items.Add(strOutputGrandTotal)

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSales.Items.Clear()
        txtQuantitySoldPackageA.Text = String.Empty
        txtQuantitySoldPackageB.Text = String.Empty
        txtQuantitySoldPackageC.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
