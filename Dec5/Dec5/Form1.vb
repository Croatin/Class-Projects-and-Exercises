Public Class Form1

    //Tutorial 12.1

    Private strLastName As String
    Private strFirstName As String
    Private strId As String
    Private dblTestAverage As Double

    Public Sub New()
        strFirstName = "(Unknown)"
        strLastName = "(Unknown)"
        strId = "(Unknown)"
    End Sub

    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(value As String)
            strLastName = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(value As String)
            strFirstName = value
        End Set
    End Property

    Public Property Id() As String
        Get
            Return Id
        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property TestAverage() As Double
        Get
            Return dblTestAverage
        End Get
        Set(value As Double)
            dblTestAverage = value
        End Set
    End Property

    Public ReadOnly Property Grade() As String
        Get
            Dim strGrade As String
            If dblTestAverage >= 90.0 Then
                strGrade = "A"
            ElseIf dblTestAverage >= 80 Then
                strGrade = "B"
            ElseIf dblTestAverage >= 70 Then
                strGrade = "C"
            ElseIf dblTestAverage >= 60 Then
                strGrade = "D"
            ElseIf dblTestAverage >= 50 Then
                strGrade = "F"
            End If

            Return strGrade
        End Get
    End Property

End Class


imports System.IO

Public Class Form1
    Private Sub GetData(ByVal objStudent As student)
        Try
            objStudent.LastName = txtLastName.Text
            objStudent.FirstName = txtFirstName.Text
            objStudent.IdNumber = txtIdNumber.Text
            objStudent.TestAverage = CDbl(txtTestAverage.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class