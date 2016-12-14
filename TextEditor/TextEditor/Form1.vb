Imports System.IO

Public Class Form1

    Private strFileName As String = String.Empty

    Dim blnIsChanged As Boolean = False

    Sub ClearDocument()
        txtDocument.Clear()
        strFileName = String.Empty

        blnIsChanged = False

    End Sub

    Sub OpenDocument()

        Dim inputFile As StreamReader
        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpenFile.FileName

            Try

                inputFile = File.OpenText(strFileName)
                txtDocument.Text = inputFile.ReadToEnd
                inputFile.Close()
                blnIsChanged = False

            Catch ex As Exception

                MessageBox.Show("Error opening file")

            End Try
        End If

    End Sub

    Sub SaveDocument()
        Dim outputFile As StreamWriter

        Try
            outputFile = File.CreateText(strFileName)
            outputFile.Write(txtDocument.Text)

            outputFile.Close()
            blnIsChanged = False
        Catch ex As Exception
            MessageBox.Show("Error creating the file")
        End Try
    End Sub



    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. Do you want to save first?" & "Are you sure?", "Confirm", MessageBox.YesNo) = Windows.Forms.DialogResult.Yes Then
                ClearDocument()

            End If

            SaveDocument()

        End If

    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " & " are you sure?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.yesThen Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            SaveDocument()

        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        If sfdSaveFile.showDialog = Windows.Forms.DialogResult.OK Then
            strFileName = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Simple Text Editor version 1.0")
    End Sub
End Class
