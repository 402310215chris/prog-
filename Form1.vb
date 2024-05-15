Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer


        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)

        MsgBox(num1 + num2)
    End Sub
End Class
