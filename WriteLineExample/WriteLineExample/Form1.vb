Imports System.IO

Public Class Form1

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        Const intNUM_FRIENDS As Integer = 3

        Dim strFilename As String
        Dim strFriend As String
        Dim strPhone As String
        Dim intCount As Integer
        Dim friendFile As StreamReader

        strFilename = InputBox("Enter filename")

        Try
            friendFile = File.OpenText(strFilename)

            For intCount = 1 To intNUM_FRIENDS
                strFriend = friendFile.ReadLine()
                strPhone = friendFile.ReadLine()
                lstFriends.Items.Add("Name Is " & strFriend)
                lstFriends.Items.Add("Phone Number is " & strPhone)
                lstFriends.Items.Add(" ")
            Next
            friendFile.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lstFriends.Items.Clear()
    End Sub


End Class
