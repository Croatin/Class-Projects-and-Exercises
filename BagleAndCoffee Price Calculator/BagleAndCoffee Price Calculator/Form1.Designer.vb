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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.radWholeWheat = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radMocha = New System.Windows.Forms.RadioButton()
        Me.radLatte = New System.Windows.Forms.RadioButton()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.chkSourCream = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkCinnamon = New System.Windows.Forms.CheckBox()
        Me.chkPeanut = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWholeWheat)
        Me.GroupBox1.Controls.Add(Me.radWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bagel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkButter)
        Me.GroupBox3.Controls.Add(Me.chkPeanut)
        Me.GroupBox3.Controls.Add(Me.chkCinnamon)
        Me.GroupBox3.Controls.Add(Me.chkOnions)
        Me.GroupBox3.Controls.Add(Me.chkSourCream)
        Me.GroupBox3.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Toppings"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radLatte)
        Me.GroupBox4.Controls.Add(Me.radMocha)
        Me.GroupBox4.Controls.Add(Me.radRegular)
        Me.GroupBox4.Controls.Add(Me.radNone)
        Me.GroupBox4.Location = New System.Drawing.Point(399, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Coffee"
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Location = New System.Drawing.Point(24, 19)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(83, 17)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White (1.25)"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'radWholeWheat
        '
        Me.radWholeWheat.AutoSize = True
        Me.radWholeWheat.Location = New System.Drawing.Point(24, 42)
        Me.radWholeWheat.Name = "radWholeWheat"
        Me.radWholeWheat.Size = New System.Drawing.Size(121, 17)
        Me.radWholeWheat.TabIndex = 1
        Me.radWholeWheat.TabStop = True
        Me.radWholeWheat.Text = "Whole Wheat (1.50)"
        Me.radWholeWheat.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(25, 19)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(25, 42)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 1
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radMocha
        '
        Me.radMocha.AutoSize = True
        Me.radMocha.Location = New System.Drawing.Point(25, 65)
        Me.radMocha.Name = "radMocha"
        Me.radMocha.Size = New System.Drawing.Size(58, 17)
        Me.radMocha.TabIndex = 2
        Me.radMocha.TabStop = True
        Me.radMocha.Text = "Mocha"
        Me.radMocha.UseVisualStyleBackColor = True
        '
        'radLatte
        '
        Me.radLatte.AutoSize = True
        Me.radLatte.Location = New System.Drawing.Point(121, 19)
        Me.radLatte.Name = "radLatte"
        Me.radLatte.Size = New System.Drawing.Size(49, 17)
        Me.radLatte.TabIndex = 3
        Me.radLatte.TabStop = True
        Me.radLatte.Text = "Latte"
        Me.radLatte.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(24, 20)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(95, 17)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'chkSourCream
        '
        Me.chkSourCream.AutoSize = True
        Me.chkSourCream.Location = New System.Drawing.Point(24, 44)
        Me.chkSourCream.Name = "chkSourCream"
        Me.chkSourCream.Size = New System.Drawing.Size(81, 17)
        Me.chkSourCream.TabIndex = 1
        Me.chkSourCream.Text = "Sour Cream"
        Me.chkSourCream.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(24, 68)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(59, 17)
        Me.chkOnions.TabIndex = 2
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkCinnamon
        '
        Me.chkCinnamon.AutoSize = True
        Me.chkCinnamon.Location = New System.Drawing.Point(119, 19)
        Me.chkCinnamon.Name = "chkCinnamon"
        Me.chkCinnamon.Size = New System.Drawing.Size(73, 17)
        Me.chkCinnamon.TabIndex = 3
        Me.chkCinnamon.Text = "Cinnamon"
        Me.chkCinnamon.UseVisualStyleBackColor = True
        '
        'chkPeanut
        '
        Me.chkPeanut.AutoSize = True
        Me.chkPeanut.Location = New System.Drawing.Point(119, 45)
        Me.chkPeanut.Name = "chkPeanut"
        Me.chkPeanut.Size = New System.Drawing.Size(60, 17)
        Me.chkPeanut.TabIndex = 4
        Me.chkPeanut.Text = "Peanut"
        Me.chkPeanut.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(119, 68)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(54, 17)
        Me.chkButter.TabIndex = 5
        Me.chkButter.Text = "Butter"
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(132, 20)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(54, 15)
        Me.lblSubTotal.TabIndex = 3
        Me.lblSubTotal.Text = "               "
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(132, 45)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(54, 15)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "               "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(132, 68)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(54, 15)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "               "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(36, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(281, 324)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(509, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bagel House"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 387)
        Me.Controls.Add(Me.Label4)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radWholeWheat As System.Windows.Forms.RadioButton
    Friend WithEvents radWhite As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkButter As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeanut As System.Windows.Forms.CheckBox
    Friend WithEvents chkCinnamon As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkSourCream As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreamCheese As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radLatte As System.Windows.Forms.RadioButton
    Friend WithEvents radMocha As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
