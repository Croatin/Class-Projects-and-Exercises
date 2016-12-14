<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtChildrenSold = New System.Windows.Forms.TextBox()
        Me.txtChildrenPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGrossRevenue = New System.Windows.Forms.Label()
        Me.lblChildTicketSales = New System.Windows.Forms.Label()
        Me.lblAdultTicketSales = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalNet = New System.Windows.Forms.Label()
        Me.lblChildNet = New System.Windows.Forms.Label()
        Me.lblAdultNet = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(94, 58)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultSold.TabIndex = 2
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(94, 20)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultPrice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price Per Ticket: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildrenSold)
        Me.GroupBox2.Controls.Add(Me.txtChildrenPrice)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'txtChildrenSold
        '
        Me.txtChildrenSold.Location = New System.Drawing.Point(94, 55)
        Me.txtChildrenSold.Name = "txtChildrenSold"
        Me.txtChildrenSold.Size = New System.Drawing.Size(100, 20)
        Me.txtChildrenSold.TabIndex = 3
        '
        'txtChildrenPrice
        '
        Me.txtChildrenPrice.Location = New System.Drawing.Point(94, 20)
        Me.txtChildrenPrice.Name = "txtChildrenPrice"
        Me.txtChildrenPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtChildrenPrice.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tickets Sold: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price Per Ticket: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblChildTicketSales)
        Me.GroupBox3.Controls.Add(Me.lblAdultTicketSales)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 178)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket REvenue"
        '
        'lblGrossRevenue
        '
        Me.lblGrossRevenue.AutoSize = True
        Me.lblGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossRevenue.Location = New System.Drawing.Point(112, 116)
        Me.lblGrossRevenue.Name = "lblGrossRevenue"
        Me.lblGrossRevenue.Size = New System.Drawing.Size(75, 15)
        Me.lblGrossRevenue.TabIndex = 5
        Me.lblGrossRevenue.Text = "                      "
        '
        'lblChildTicketSales
        '
        Me.lblChildTicketSales.AutoSize = True
        Me.lblChildTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildTicketSales.Location = New System.Drawing.Point(112, 63)
        Me.lblChildTicketSales.Name = "lblChildTicketSales"
        Me.lblChildTicketSales.Size = New System.Drawing.Size(75, 15)
        Me.lblChildTicketSales.TabIndex = 4
        Me.lblChildTicketSales.Text = "                      "
        '
        'lblAdultTicketSales
        '
        Me.lblAdultTicketSales.AutoSize = True
        Me.lblAdultTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultTicketSales.Location = New System.Drawing.Point(112, 20)
        Me.lblAdultTicketSales.Name = "lblAdultTicketSales"
        Me.lblAdultTicketSales.Size = New System.Drawing.Size(75, 15)
        Me.lblAdultTicketSales.TabIndex = 3
        Me.lblAdultTicketSales.Text = "                      "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 26)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Ticket Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Child Ticket Sales: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adult Ticket Sales: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalNet)
        Me.GroupBox4.Controls.Add(Me.lblChildNet)
        Me.GroupBox4.Controls.Add(Me.lblAdultNet)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(219, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 177)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblTotalNet
        '
        Me.lblTotalNet.AutoSize = True
        Me.lblTotalNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNet.Location = New System.Drawing.Point(113, 114)
        Me.lblTotalNet.Name = "lblTotalNet"
        Me.lblTotalNet.Size = New System.Drawing.Size(75, 15)
        Me.lblTotalNet.TabIndex = 7
        Me.lblTotalNet.Text = "                      "
        '
        'lblChildNet
        '
        Me.lblChildNet.AutoSize = True
        Me.lblChildNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildNet.Location = New System.Drawing.Point(113, 62)
        Me.lblChildNet.Name = "lblChildNet"
        Me.lblChildNet.Size = New System.Drawing.Size(75, 15)
        Me.lblChildNet.TabIndex = 6
        Me.lblChildNet.Text = "                      "
        '
        'lblAdultNet
        '
        Me.lblAdultNet.AutoSize = True
        Me.lblAdultNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultNet.Location = New System.Drawing.Point(113, 25)
        Me.lblAdultNet.Name = "lblAdultNet"
        Me.lblAdultNet.Size = New System.Drawing.Size(75, 15)
        Me.lblAdultNet.TabIndex = 5
        Me.lblAdultNet.Text = "                      "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 26)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Ticket Sales:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Child Ticket Sales: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Adult Ticket Sales: "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(24, 314)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(193, 314)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 349)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdultSold As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtChildrenSold As System.Windows.Forms.TextBox
    Friend WithEvents txtChildrenPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrossRevenue As System.Windows.Forms.Label
    Friend WithEvents lblChildTicketSales As System.Windows.Forms.Label
    Friend WithEvents lblAdultTicketSales As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalNet As System.Windows.Forms.Label
    Friend WithEvents lblChildNet As System.Windows.Forms.Label
    Friend WithEvents lblAdultNet As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
