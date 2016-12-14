Public Class Form1

    Dim dblTotal As Double = 0
    Dim dblServices As Double = 0
    Dim dblParts As Double = 0
    Dim dblTax As Double = 0


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If chkOil.Checked.Equals(True) Then
            dblServices += 26.0
        End If
        If chkLube.Checked.Equals(True) Then
            dblServices += 18.0
        End If
        If chkRad.Checked.Equals(True) Then
            dblServices += 30.0
        End If
        If chkTrans.Checked.Equals(True) Then
            dblServices += 80.0
        End If
        If chkInspection.Checked.Equals(True) Then
            dblServices += 15.0
        End If
        If chkLube.Checked.Equals(True) Then
            dblServices += 18.0
        End If
        If chkMuffler.Checked.Equals(True) Then
            dblServices += 100.0
        End If
        If chkTire.Checked.Equals(True) Then
            dblServices += 18.0
        End If

        Try
            Dim temp As Double = 0
            Double.TryParse(txtParts.Text, temp)
            dblParts += temp
        Catch ex As Exception
            MessageBox.Show("Error: Parts: Not a number")
            txtParts.Text = 0
            dblParts += 0
        End Try

        Try
            Dim temp As Double = 0
            Double.TryParse(txtLabor.Text, temp)
            dblServices += (20 * temp)
        Catch ex As Exception
            MessageBox.Show("Error: Labor: Not a number")
            txtLabor.Text = 0
            dblServices += 0
        End Try


        dblTax = (dblParts + dblServices) * 0.06
        dblTotal = dblParts + dblServices + dblTax

        lblService.Text = dblServices
        lblParts.Text = dblParts
        lblTax.Text = dblTax
        lblTotal.Text = dblTax + dblParts + dblServices


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        chkOil.Checked = False
        chkInspection.Checked = False
        chkLube.Checked = False
        chkMuffler.Checked = False
        chkRad.Checked = False
        chkTire.Checked = False
        chkTrans.Checked = False

        txtLabor.Clear()
        txtParts.Clear()

        lblParts.Text = "                                "
        lblService.Text = "                                "
        lblTax.Text = "                                "
        lblTotal.Text = "                                "

        dblParts = 0
        dblServices = 0
        dblTax = 0
        dblTotal = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
