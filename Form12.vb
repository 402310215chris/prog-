Imports System.Net.Security

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3 As Double

        num1 = Val(TextBox2.Text)
        num2 = Val(TextBox2.Text)
        num3 = (num1 + num2) / 2

        If num3 < 39 Then
            MsgBox("Fail")

        ElseIf num3 = 40 And num3 < 49 Then
            MsgBox("Qualify for a rewrite")

        ElseIf num3 = 50 And num3 < 75 Then
            MsgBox("Pass")

        ElseIf num3 >= 75 Then
            MsgBox("Distinction")

        End If
        TextBox3.Text = num3

    End Sub
End Class
