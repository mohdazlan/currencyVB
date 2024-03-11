Public Class Form1
    Private Sub nuMYR_ValueChanged(sender As Object, e As EventArgs) Handles nuMYR.ValueChanged
        If cboCurrency.Text = "BRL" Then
            lblResult.Text = Val(nuMYR.Value) * 1.07
            lblResult.BackColor = Color.LightYellow
        ElseIf cboCurrency.Text = "BND" Then
            lblResult.Text = Val(nuMYR.Value) * 0.28
            lblResult.BackColor = Color.Orange
        ElseIf cboCurrency.Text = "INR" Then
            lblResult.Text = Val(nuMYR.Value) * 17.67
            lblResult.BackColor = Color.Wheat
        Else
            MessageBox.Show("Please Select A Currency First", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
