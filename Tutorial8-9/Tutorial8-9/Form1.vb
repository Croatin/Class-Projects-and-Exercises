Public Class Form1

    Const intMAX_SUBSCRIPT As Integer = 4
    Dim strProdNames(intMAX_SUBSCRIPT) As String
    Dim strDesc(intMAX_SUBSCRIPT) As String
    Dim intProdNums(intMAX_SUBSCRIPT) As Integer
    Dim decPrices(intMAX_SUBSCRIPT) As Decimal
    Dim intUnitsSold(intMAX_SUBSCRIPT) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitArrays()
    End Sub

    Private Sub InitArrays()
        strProdNames(0) = "Six steps to leadership"
        strDesc(0) = "Book"
        intProdNums(0) = 914
        decPrices(0) = 12.95D

        strProdNames(1) = "Six steps to leadership"
        strDesc(1) = "CD"
        intProdNums(1) = 915
        decPrices(1) = 14.95D

        strProdNames(2) = "The road to excellence"
        strDesc(2) = "Video"
        intProdNums(2) = 916
        decPrices(2) = 16.95D

        strProdNames(0) = "Seven Lessons of Quality"
        strDesc(0) = "Book"
        intProdNums(0) = 917
        decPrices(0) = 16.95D

        strProdNames(0) = "Six steps to leadership"
        strDesc(0) = "CD"
        intProdNums(0) = 918
        decPrices(0) = 21.95D
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        Dim intCount As Integer = 0

        Do While intCount <= intMAX_SUBSCRIPT
            Try
                intUnitsSold(intCount) = CInt(InputBox("Enter units sold of product number " & intProdNums(intCount)))
                intCount += 1
            Catch ex As Exception
                MessageBox.Show("Enter a valid integer.")
            End Try
        Loop
    End Sub

    Private Sub mnuReportDisplay_Click(sender As Object, e As EventArgs) Handles mnuReportDisplay.Click
        Dim intCount As Integer
        Dim decRevenue As Decimal
        Dim decTotalRevenue As Decimal

        lstSalesData.Items.Add("SALES REPORT")
        lstSalesData.Items.Add("------------")

        For intCount = 0 To intMAX_SUBSCRIPT
            decRevenue = intUnitsSold(intCount) * decPrices(intCount)

            lstSalesData.Items.Add("Product Number: " & intProdNums(intCount))
            lstSalesData.Items.Add("Product Number: " & strProdNames(intCount))
            lstSalesData.Items.Add("Product Number: " & strDesc(intCount))
            lstSalesData.Items.Add("Product Number: " & decPrices(intCount))
            lstSalesData.Items.Add("Product Number: " & intUnitsSold(intCount))
            lstSalesData.Items.Add("Product Number: " & decRevenue(intCount))
            lstSalesData.Items.Add("")

            decTotalRevenue = decTotalRevenue + decRevenue
        Next

        lblTotalRevenue.Text = decTotalRevenue.ToString("c")

    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBos.Show("Displays a sales report for DLC.", "about")
    End Sub
End Class
