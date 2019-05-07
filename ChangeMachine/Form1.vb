Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intLeftover As Integer
        Dim strLeftover As String
        intLeftover = Integer.Parse(txtPennies.Text)
        strLeftover = intLeftover.ToString
        Debug.WriteLine("Total pennies " + strLeftover)
        lblDollars.Text = (intLeftover \ 100).ToString
        Debug.WriteLine("Dollars: " + (intLeftover \ 100).ToString)
        intLeftover = intLeftover Mod 100
        lblQuarters.Text = (intLeftover \ 25).ToString
        Debug.WriteLine("Quarters: " + (intLeftover \ 25).ToString)
        intLeftover = intLeftover Mod 25
        lblDimes.Text = (intLeftover \ 10).ToString
        Debug.WriteLine("Dimes: " + (intLeftover \ 10).ToString)
        intLeftover = intLeftover Mod 10
        lblNickels.Text = (intLeftover \ 5).ToString
        Debug.WriteLine("Nickels: " + (intLeftover \ 5).ToString)
        intLeftover = intLeftover Mod 5
        lblPennies.Text = intLeftover.ToString
        strLeftover = intLeftover.ToString
        Debug.WriteLine("Pennies: " + strLeftover)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPennies.Text = ""
        lblDollars.Text = ""
        lblQuarters.Text = ""
        lblDimes.Text = ""
        lblNickels.Text = ""
        lblPennies.Text = ""
    End Sub
End Class
