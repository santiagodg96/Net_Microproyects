Public Class Form1

    Dim num1, num2 As Double
    Dim operacion As String

    Private Sub Nueve_Click(sender As Object, e As EventArgs) Handles Nueve.Click
        Pantalla.Text = Pantalla.Text & "9"
    End Sub

    Private Sub Ocho_Click(sender As Object, e As EventArgs) Handles Ocho.Click
        Pantalla.Text = Pantalla.Text & "8"
    End Sub

    Private Sub Siete_Click(sender As Object, e As EventArgs) Handles Siete.Click
        Pantalla.Text = Pantalla.Text & "7"
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles Seis.Click
        Pantalla.Text = Pantalla.Text & "6"
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles Cinco.Click
        Pantalla.Text = Pantalla.Text & "5"
    End Sub

    Private Sub Cuatro_Click(sender As Object, e As EventArgs) Handles Cuatro.Click
        Pantalla.Text = Pantalla.Text & "4"
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles Tres.Click
        Pantalla.Text = Pantalla.Text & "3"
    End Sub

    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        Pantalla.Text = Pantalla.Text & "2"
    End Sub

    Private Sub Uno_Click(sender As Object, e As EventArgs) Handles Uno.Click
        Pantalla.Text = Pantalla.Text & "1"
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        If Pantalla.Text <> "" Then
            num1 = Val(Pantalla.Text)
            Pantalla.Text = ""
            operacion = "/"
        End If
    End Sub

    Private Sub Multiplicacion_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click
        If Pantalla.Text <> "" Then
            num1 = Val(Pantalla.Text)
            Pantalla.Text = ""
            operacion = "X"
        End If
    End Sub

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Suma.Click
        If Pantalla.Text <> "" Then
            num1 = Val(Pantalla.Text)
            Pantalla.Text = ""
            operacion = "+"
        End If
    End Sub

    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles Resta.Click
        If Pantalla.Text <> "" Then
            num1 = Val(Pantalla.Text)
            Pantalla.Text = ""
            operacion = "-"
        End If
    End Sub

    Private Sub Porcentaje_Click(sender As Object, e As EventArgs) Handles Porcentaje.Click
        If Pantalla.Text <> "" Then
            num1 = Val(Pantalla.Text)
            Pantalla.Text = ""
            operacion = "%"
        End If
    End Sub

    Private Sub Raiz_Click(sender As Object, e As EventArgs) Handles Raiz.Click
        If Pantalla.Text <> "" Then
            num1 = Val(Pantalla.Text)
            Pantalla.Text = ""
            operacion = "Raiz"
        End If
    End Sub

    Private Sub Resultado_Click(sender As Object, e As EventArgs) Handles Resultado.Click
        If Pantalla.Text <> "" Then
            num2 = Val(Pantalla.Text)
            Select Case operacion
                Case "+"
                    Pantalla.Text = num1 + num2
                Case "-"
                    Pantalla.Text = num1 - num2
                Case "X"
                    Pantalla.Text = num1 * num2
                Case "/"
                    Pantalla.Text = num1 / num2
                Case "%"
                    Pantalla.Text = (num1 * num2) / 100
                Case "Raiz"
                    Pantalla.Text = num1 ^ (1 / num2)
            End Select
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Pantalla.Text = ""
        num1 = 0
        num2 = 0
    End Sub

    Private Sub Cero_Click(sender As Object, e As EventArgs) Handles Cero.Click
        Pantalla.Text = Pantalla.Text & "0"
    End Sub

    Private Sub Off_Click_1(sender As Object, e As EventArgs) Handles Off.Click
        Close()
    End Sub

    Private Sub Punto_Click(sender As Object, e As EventArgs) Handles Punto.Click

        If InStr(Pantalla.Text, ".", CompareMethod.Text) = 0 Then
            Pantalla.Text &= "0."
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Pantalla.TextChanged

    End Sub

End Class
