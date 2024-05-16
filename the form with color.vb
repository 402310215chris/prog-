Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "Christine"
        TextBox1.BackColor = Color.Aqua
        Button1.BackColor = Color.Teal
        Me.BackColor = Color.AliceBlue
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()

    End Sub
End Class
