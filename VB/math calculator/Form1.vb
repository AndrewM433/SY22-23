Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, button0.Click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub additonbutton_Click(sender As Object, e As EventArgs) Handles additonbutton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "+"
        DisplayTextBox.Clear()


    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num2)
        If oper = "+" Then
            DisplayTextBox.Text = num1 + num2


        End If

        If oper = "-" Then
            DisplayTextBox.Text = num1 - num2


        End If

        If oper = "*" Then
            DisplayTextBox.Text = num1 * num2


        End If

        If oper = "/" Then
            DisplayTextBox.Text = num1 / num2


        End If
    End Sub

    Private Sub subtractionbutton_Click(sender As Object, e As EventArgs) Handles subtractionbutton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub TimesButton_Click(sender As Object, e As EventArgs) Handles TimesButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "*"
        DisplayTextBox.Clear()
    End Sub

    Private Sub divisionbutton_Click(sender As Object, e As EventArgs) Handles divisionbutton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "/"
        DisplayTextBox.Clear()
    End Sub

    Private Sub mplusbutton_Click(sender As Object, e As EventArgs) Handles mplusbutton.Click
        Decimal.TryParse(DisplayTextBox.Text, mem)

    End Sub

    Private Sub MCbutton_Click(sender As Object, e As EventArgs) Handles MCbutton.Click
        mem = 0
    End Sub

    Private Sub MrButton_Click(sender As Object, e As EventArgs) Handles MrButton.Click
        DisplayTextBox.Text = mem

    End Sub
End Class
