Public Class Form1

    Dim Count As Integer = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PhoneBookDataSet.Phonebook' table. You can move, or remove it, as needed.
        Me.PhonebookTableAdapter.Fill(Me.PhoneBookDataSet.Phonebook)
        Timer1.Start()


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.PhonebookBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try

            Me.Validate()
            Me.PhonebookBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PhoneBookDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.PhonebookBindingSource.RemoveCurrent()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Count = PhonebookBindingSource.Count

        Label1.Text = "There are " & Count & " contacts found."

        If Count > 1 Then
            Button4.Visible = True
            If Count > 2 Then
                Button5.Visible = True
            End If
        End If
        If Count <= 1 Then
            Button4.Visible = False
            Button5.Visible = False

        End If



    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        PhonebookBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PhonebookBindingSource.MovePrevious()
    End Sub


End Class
