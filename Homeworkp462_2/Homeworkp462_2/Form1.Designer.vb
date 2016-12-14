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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdBookIDidIt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdBookTheHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdBooksLearnCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBooksFeelThe = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdAudioLearnCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdAudioTheHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdAudioTheScience = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdAudioRelaxation = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReset, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(152, 22)
        Me.mnuReset.Text = "R&eset "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBooksToolStripMenuItem, Me.AudioBooksToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'PrintBooksToolStripMenuItem
        '
        Me.PrintBooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProdBookIDidIt, Me.mnuProdBookTheHistory, Me.mnuProdBooksLearnCalc, Me.mnuBooksFeelThe})
        Me.PrintBooksToolStripMenuItem.Name = "PrintBooksToolStripMenuItem"
        Me.PrintBooksToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PrintBooksToolStripMenuItem.Text = "P&rint Books"
        '
        'mnuProdBookIDidIt
        '
        Me.mnuProdBookIDidIt.Name = "mnuProdBookIDidIt"
        Me.mnuProdBookIDidIt.Size = New System.Drawing.Size(212, 22)
        Me.mnuProdBookIDidIt.Text = "I Did It Your Way"
        '
        'mnuProdBookTheHistory
        '
        Me.mnuProdBookTheHistory.Name = "mnuProdBookTheHistory"
        Me.mnuProdBookTheHistory.Size = New System.Drawing.Size(212, 22)
        Me.mnuProdBookTheHistory.Text = "The History Of Scotland"
        '
        'mnuProdBooksLearnCalc
        '
        Me.mnuProdBooksLearnCalc.Name = "mnuProdBooksLearnCalc"
        Me.mnuProdBooksLearnCalc.Size = New System.Drawing.Size(212, 22)
        Me.mnuProdBooksLearnCalc.Text = "Learn Calculus in One Day"
        '
        'mnuBooksFeelThe
        '
        Me.mnuBooksFeelThe.Name = "mnuBooksFeelThe"
        Me.mnuBooksFeelThe.Size = New System.Drawing.Size(212, 22)
        Me.mnuBooksFeelThe.Text = "Feel the Stress"
        '
        'AudioBooksToolStripMenuItem
        '
        Me.AudioBooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProdAudioLearnCalc, Me.mnuProdAudioTheHistory, Me.mnuProdAudioTheScience, Me.mnuProdAudioRelaxation})
        Me.AudioBooksToolStripMenuItem.Name = "AudioBooksToolStripMenuItem"
        Me.AudioBooksToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AudioBooksToolStripMenuItem.Text = "&Audio Books"
        '
        'mnuProdAudioLearnCalc
        '
        Me.mnuProdAudioLearnCalc.Name = "mnuProdAudioLearnCalc"
        Me.mnuProdAudioLearnCalc.Size = New System.Drawing.Size(236, 22)
        Me.mnuProdAudioLearnCalc.Text = "Learn Calculus in One Day"
        '
        'mnuProdAudioTheHistory
        '
        Me.mnuProdAudioTheHistory.Name = "mnuProdAudioTheHistory"
        Me.mnuProdAudioTheHistory.Size = New System.Drawing.Size(236, 22)
        Me.mnuProdAudioTheHistory.Text = "The History of Scotland"
        '
        'mnuProdAudioTheScience
        '
        Me.mnuProdAudioTheScience.Name = "mnuProdAudioTheScience"
        Me.mnuProdAudioTheScience.Size = New System.Drawing.Size(236, 22)
        Me.mnuProdAudioTheScience.Text = "The Science of Body Language"
        '
        'mnuProdAudioRelaxation
        '
        Me.mnuProdAudioRelaxation.Name = "mnuProdAudioRelaxation"
        Me.mnuProdAudioRelaxation.Size = New System.Drawing.Size(236, 22)
        Me.mnuProdAudioRelaxation.Text = "Relaxation Techniques"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstItems)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 189)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Products"
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(18, 20)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(246, 121)
        Me.lstItems.TabIndex = 19
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(351, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 15)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "                   "
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipping.Location = New System.Drawing.Point(351, 70)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(66, 15)
        Me.lblShipping.TabIndex = 17
        Me.lblShipping.Text = "                   "
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(351, 18)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(66, 15)
        Me.lblSubtotal.TabIndex = 16
        Me.lblSubtotal.Text = "                   "
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(55, 155)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(124, 23)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(351, 46)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(66, 15)
        Me.lblTax.TabIndex = 12
        Me.lblTax.Text = "                   "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Shipping:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tax:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 260)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents mnuReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdBookIDidIt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdBookTheHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdBooksLearnCalc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBooksFeelThe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudioBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdAudioLearnCalc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdAudioTheHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdAudioTheScience As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdAudioRelaxation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
