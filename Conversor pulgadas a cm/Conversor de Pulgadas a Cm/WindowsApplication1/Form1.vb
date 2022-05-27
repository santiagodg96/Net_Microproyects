Public Class Form1

    Private Sub button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button.Click
        If TextBox1.Text = "" Or TextBox1.Text = "0" Then
            MsgBox("No puede dejar el campo vacio ni tampoco ingresar 0")
        Else
            cm.Text = TextBox1.Text * 2.54
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        If TextBox2.Text = "" Or TextBox2.Text = "0" Then
            MsgBox("No puede dejar el campo vacio ni tampoco ingresar 0")
        Else
            pulg.Text = TextBox2.Text / 2.54
            TextBox2.Text = ""
        End If
    End Sub

End Class
