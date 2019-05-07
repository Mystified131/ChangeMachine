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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Pennies:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dollars"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quarters"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dimes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nickels"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pennies"
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(242, 49)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(100, 26)
        Me.txtPennies.TabIndex = 6
        '
        'lblDollars
        '
        Me.lblDollars.BackColor = System.Drawing.SystemColors.Window
        Me.lblDollars.Location = New System.Drawing.Point(276, 124)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(100, 23)
        Me.lblDollars.TabIndex = 7
        '
        'lblQuarters
        '
        Me.lblQuarters.BackColor = System.Drawing.SystemColors.Window
        Me.lblQuarters.Location = New System.Drawing.Point(276, 196)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(100, 23)
        Me.lblQuarters.TabIndex = 8
        '
        'lblDimes
        '
        Me.lblDimes.BackColor = System.Drawing.SystemColors.Window
        Me.lblDimes.Location = New System.Drawing.Point(276, 265)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(100, 23)
        Me.lblDimes.TabIndex = 9
        '
        'lblNickels
        '
        Me.lblNickels.BackColor = System.Drawing.SystemColors.Window
        Me.lblNickels.Location = New System.Drawing.Point(276, 330)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(100, 23)
        Me.lblNickels.TabIndex = 10
        '
        'lblPennies
        '
        Me.lblPennies.BackColor = System.Drawing.SystemColors.Window
        Me.lblPennies.Location = New System.Drawing.Point(276, 398)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(100, 23)
        Me.lblPennies.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Location = New System.Drawing.Point(471, 105)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 30)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(471, 209)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents lblDollars As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
