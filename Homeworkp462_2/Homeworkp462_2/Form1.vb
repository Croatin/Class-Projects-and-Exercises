Public Class Form1

    Const decBOOK_I_DID_IT As Decimal = 11.95D
    Const decBOOK_THE_HISTORY As Decimal = 14.95D
    Const decBOOK_LEARN_CALC As Decimal = 29.95D
    Const decBOOK_FEEL_THE As Decimal = 19.5D

    Const decAUDIO_LEARN_CALC As Decimal = 29.95D
    Const decAUDIO_THE_HISTORY As Decimal = 14.5D
    Const decAUDIO_THE_SCIENCE As Decimal = 12.95D
    Const decAUDIO_RELAXATION As Decimal = 11.5D

    Const decShippingPrice As Decimal = 2D

    Const strBOOK_I_DID As String = "'I Did It Your Way' (Print)"
    Const strBOOK_HISTORY_OF As String = "'The History of Scotland' (Print)"
    Const strBOOK_LEARN_CALC As String = "'Learn Calculus in One Day' (Print)"
    Const strBOOK_FEEL_THE As String = "'Feel the Stress' (Print)"

    Const strAUDIO_LEARN_CALC As String = "'Learn Calculus in One Day' (Audio)"
    Const strAUDIO_THE_HISTORY As String = "'The History of Scotland' (Audio)"
    Const strAUDIO_THE_SCIENCE As String = "'The Science of Body Language' (Audio)"
    Const strAUDIO_RELAXATION As String = "'Relaxation Techniques' (Audio)"


    Dim intShippingCounter As Integer = 0
    Dim decSubtotal As Decimal = 0
    Dim decTotal As Decimal = 0
    Dim decTax As Decimal = 0

    Private Sub mnuProdBookIDidIt_Click(sender As Object, e As EventArgs) Handles mnuProdBookIDidIt.Click
        lstItems.Items.Add(strBOOK_I_DID)
        decSubtotal += decBOOK_I_DID_IT
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub

    Private Sub mnuProdBookTheHistory_Click(sender As Object, e As EventArgs) Handles mnuProdBookTheHistory.Click
        lstItems.Items.Add(strBOOK_HISTORY_OF)
        decSubtotal += decAUDIO_THE_HISTORY
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub

    Private Sub mnuProdBooksLearnCalc_Click(sender As Object, e As EventArgs) Handles mnuProdBooksLearnCalc.Click
        lstItems.Items.Add(strBOOK_LEARN_CALC)
        decSubtotal += decBOOK_LEARN_CALC
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub


    Private Sub mnuBooksFeelThe_Click(sender As Object, e As EventArgs) Handles mnuBooksFeelThe.Click
        lstItems.Items.Add(strBOOK_LEARN_CALC)
        decSubtotal += decBOOK_FEEL_THE
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub

    Private Sub mnuProdAudioLearnCalc_Click(sender As Object, e As EventArgs) Handles mnuProdAudioLearnCalc.Click
        lstItems.Items.Add(strAUDIO_LEARN_CALC)
        decSubtotal += decAUDIO_LEARN_CALC
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub

    Private Sub mnuProdAudioTheHistory_Click(sender As Object, e As EventArgs) Handles mnuProdAudioTheHistory.Click
        lstItems.Items.Add(strAUDIO_THE_HISTORY)
        decSubtotal += decAUDIO_THE_HISTORY
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub

    Private Sub mnuProdAudioTheScience_Click(sender As Object, e As EventArgs) Handles mnuProdAudioTheScience.Click
        lstItems.Items.Add(strAUDIO_THE_SCIENCE)
        decSubtotal += decAUDIO_THE_HISTORY
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal
    End Sub

    Private Sub mnuProdAudioRelaxation_Click(sender As Object, e As EventArgs) Handles mnuProdAudioRelaxation.Click
        lstItems.Items.Add(strAUDIO_RELAXATION)
        decSubtotal += decAUDIO_RELAXATION
        intShippingCounter += 2

        decTax = 0.06 * decSubtotal
        decTotal = decTax + intShippingCounter + decSubtotal

        lblSubtotal.Text = decSubtotal
        lblTax.Text = decTax
        lblShipping.Text = intShippingCounter
        lblTotal.Text = decTotal

    End Sub

    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        lstItems.Items.Clear()
        decSubtotal = 0
        intShippingCounter = 0
        decTotal = 0
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstItems.SelectedIndex <> -1 Then
            Dim decTempTax
            If lstItems.SelectedItem.ToString == strBOOK_I_DID.ToString Then
                decSubtotal -= decBOOK_I_DID_IT
                decTempTax = decBOOK_I_DID_IT * 0.06
                decTax -= decTempTax
                decTotal -= (decBOOK_I_DID_IT + decTax)

                lstItems.ClearSelected()
                intShippingCounter -= 2

                lblSubtotal.Text = decSubtotal
                lblTax.Text = decTax
                lblShipping.Text = intShippingCounter
                lblTotal.Text = decTotal

            End If
            If lstItems.SelectedItem() == strBOOK_HISTORY_OF Then
                decSubtotal -= decBOOK_THE_HISTORY
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
            If lstItems.SelectedItem() == strBOOK_LEARN_CALC Then
                decSubtotal -= decBOOK_LEARN_CALC
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
            If lstItems.SelectedItem() == strBOOK_FEEL_THE Then
                decSubtotal -= decBOOK_FEEL_THE
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
            If lstItems.SelectedItem() == strBOOK_LEARN_CALC Then
                decSubtotal -= decAUDIO_LEARN_CALC
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
            If lstItems.SelectedItem() == strAUDIO_THE_HISTORY Then
                decSubtotal -= decAUDIO_THE_HISTORY
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
            If lstItems.SelectedItem() == strAUDIO_RELAXATION Then
                decSubtotal -= decAUDIO_RELAXATION
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
            If lstItems.SelectedItem() == strAUDIO_THE_SCIENCE Then
                decSubtotal -= decAUDIO_THE_SCIENCE
                lstItems.ClearSelected()
                intShippingCounter -= 2
            End If
        End If
    End Sub

End Class
