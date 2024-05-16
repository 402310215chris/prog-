Public Class Form2
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim base, height, area As Double


        base = Val(TextBox1.Text)
        height = Val(TextBox2.Text)


        area = 0.5 * base * height
        TextBox3.Text = area




    End Sub
End Class