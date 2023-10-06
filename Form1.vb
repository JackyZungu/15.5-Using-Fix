Public Class Form1
    Private Sub BtnCom_Click(sender As Object, e As EventArgs) Handles BtnCom.Click
        lbFixN1.Text = Fix(Val(txtNum1.Text))
        lbFixN2.Text = Fix(Val(txtNum2.Text))
    End Sub
End Class
