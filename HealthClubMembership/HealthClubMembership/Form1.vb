Public Class Form1


    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim intStartIndex As Integer
        Dim intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If (txtToFind.Text.Length > 0) Then

                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)

                If intFoundIndex = -1 Then
                    lblResults.Text = "The string was not found"
                Else : lblResults.Text = "the string was found at index" & intFoundIndex

                End If
            Else
                MessageBox.Show("Enter a valid string")

            End If
        Else
            MessageBox.Show("Enter a valid number")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
