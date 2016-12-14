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
        Me.lstRainfallInput = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalAnnualRainfall = New System.Windows.Forms.Label()
        Me.lblAvgMonthlyRainfall = New System.Windows.Forms.Label()
        Me.lblMinRainfall = New System.Windows.Forms.Label()
        Me.lblMaxRainfall = New System.Windows.Forms.Label()
        Me.btnRainfall = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRainfallInput
        '
        Me.lstRainfallInput.FormattingEnabled = True
        Me.lstRainfallInput.Location = New System.Drawing.Point(12, 12)
        Me.lstRainfallInput.Name = "lstRainfallInput"
        Me.lstRainfallInput.Size = New System.Drawing.Size(153, 225)
        Me.lstRainfallInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Montholy Rainfall Statistics"
        '
        'lblTotalAnnualRainfall
        '
        Me.lblTotalAnnualRainfall.AutoSize = True
        Me.lblTotalAnnualRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAnnualRainfall.Location = New System.Drawing.Point(184, 56)
        Me.lblTotalAnnualRainfall.Name = "lblTotalAnnualRainfall"
        Me.lblTotalAnnualRainfall.Size = New System.Drawing.Size(231, 15)
        Me.lblTotalAnnualRainfall.TabIndex = 2
        Me.lblTotalAnnualRainfall.Text = "                                                                          "
        '
        'lblAvgMonthlyRainfall
        '
        Me.lblAvgMonthlyRainfall.AutoSize = True
        Me.lblAvgMonthlyRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgMonthlyRainfall.Location = New System.Drawing.Point(184, 87)
        Me.lblAvgMonthlyRainfall.Name = "lblAvgMonthlyRainfall"
        Me.lblAvgMonthlyRainfall.Size = New System.Drawing.Size(231, 15)
        Me.lblAvgMonthlyRainfall.TabIndex = 3
        Me.lblAvgMonthlyRainfall.Text = "                                                                          "
        '
        'lblMinRainfall
        '
        Me.lblMinRainfall.AutoSize = True
        Me.lblMinRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinRainfall.Location = New System.Drawing.Point(184, 124)
        Me.lblMinRainfall.Name = "lblMinRainfall"
        Me.lblMinRainfall.Size = New System.Drawing.Size(231, 15)
        Me.lblMinRainfall.TabIndex = 4
        Me.lblMinRainfall.Text = "                                                                          "
        '
        'lblMaxRainfall
        '
        Me.lblMaxRainfall.AutoSize = True
        Me.lblMaxRainfall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxRainfall.Location = New System.Drawing.Point(184, 166)
        Me.lblMaxRainfall.Name = "lblMaxRainfall"
        Me.lblMaxRainfall.Size = New System.Drawing.Size(231, 15)
        Me.lblMaxRainfall.TabIndex = 5
        Me.lblMaxRainfall.Text = "                                                                          "
        '
        'btnRainfall
        '
        Me.btnRainfall.Location = New System.Drawing.Point(13, 257)
        Me.btnRainfall.Name = "btnRainfall"
        Me.btnRainfall.Size = New System.Drawing.Size(98, 49)
        Me.btnRainfall.TabIndex = 6
        Me.btnRainfall.Text = "Input Monthly Rainfall"
        Me.btnRainfall.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(117, 257)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(98, 49)
        Me.btnStats.TabIndex = 7
        Me.btnStats.Text = "Display Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(221, 257)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(98, 49)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(325, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 49)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 318)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnRainfall)
        Me.Controls.Add(Me.lblMaxRainfall)
        Me.Controls.Add(Me.lblMinRainfall)
        Me.Controls.Add(Me.lblAvgMonthlyRainfall)
        Me.Controls.Add(Me.lblTotalAnnualRainfall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRainfallInput)
        Me.Name = "Form1"
        Me.Text = "RainFall Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRainfallInput As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAnnualRainfall As System.Windows.Forms.Label
    Friend WithEvents lblAvgMonthlyRainfall As System.Windows.Forms.Label
    Friend WithEvents lblMinRainfall As System.Windows.Forms.Label
    Friend WithEvents lblMaxRainfall As System.Windows.Forms.Label
    Friend WithEvents btnRainfall As System.Windows.Forms.Button
    Friend WithEvents btnStats As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
