Public Class Form1

    imports system.IO

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        Const intNUM_FRIENDS As Integer = 3

        Dim strFileName As String
        Dim strFriend As String
        Dim strPhone As String
        Dim intCount As Integer
        Dim friendFile As StreamWriter

        strFileName = InputBox("Enter the filename")
        Try
            friendFile = File.CreateText(strFileName)
            For Int count = 1 to intNUM_FRIENDS 
                strFriend = InputBox("Enter name " & "and a Number " & intCount.ToString())

                strPhone = InputBox("Enter phone " & intCount.ToString())

                friendFile.WriteLine(strFriend)
                friendFile.WriteLine(strPhone)
            Next
            friendFile.Close()
        Catch ex As Exception

            MessageBox.Show("File cannot be created")

        End Try

    End Sub
End Class
