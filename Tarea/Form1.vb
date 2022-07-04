Public Class Form1
    Public Function comboclear()
        combosistema.Items.Clear()
        comboaño.Items.Clear()
        combopais.Items.Clear()
        Return (0)
    End Function

    Public Function comboadd()
        'Sistema'
        combosistema.Items.Add("720p")
        combosistema.Items.Add("1080p")
        combosistema.Items.Add("4k")
        'Año'
        comboaño.Items.Add("1995")
        comboaño.Items.Add("1996")
        comboaño.Items.Add("2001")
        comboaño.Items.Add("2003")
        comboaño.Items.Add("2022")
        'Pais'
        combopais.Items.Add("Argentina")
        combopais.Items.Add("Brasil")
        combopais.Items.Add("Italia")
        combopais.Items.Add("España")
        combopais.Items.Add("Japón")
        Return (0)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contadorindice = 0
        Form2.Show()

    End Sub
    Private Sub closeapp_Click(sender As Object, e As EventArgs) Handles closeapp.Click
        MsgBox("Cerrando app.")
        Close()
    End Sub
    Private Sub restartapp_Click(sender As Object, e As EventArgs) Handles restartapp.Click
        MsgBox("Reiniciando app.")
        Application.Restart()
    End Sub
    Private Sub input_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged
        If input.Text = "" Then
            validar.Checked = False
            validar.Enabled = False
            comboclear()
        Else
            validar.Enabled = True
            comboclear()
            comboadd()
        End If

    End Sub
    Public Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        contadorindice += 1
        Form2.slots.Text = contadorindice


        If input.Text = "" Then
            MsgBox("Debe ingresar alguna película.")
            contadorindice -= 1
            Form2.slots.Text = contadorindice
            Exit Sub
        End If

        If validar.Checked = False Then
            MsgBox("Recuerde validar el título de la película.")
            contadorindice -= 1
            Form2.slots.Text = contadorindice
            Exit Sub
        End If

        If combosistema.Text.Length = 0 Or comboaño.Text.Length = 0 Or combopais.Text.Length = 0 Then
            MsgBox("Las categorias son mandatorias.")
            contadorindice -= 1
            Form2.slots.Text = contadorindice
            Exit Sub
        End If

        If contadorindice > 5 Then
            MsgBox("La lista está llena.")
            contadorindice -= 1
            Form2.slots.Text = contadorindice
            Exit Sub
        Else
            base(contadorindice).nombrepelBase = input.Text
            base(contadorindice).calidadBase = combosistema.Text
            base(contadorindice).añoBase = comboaño.Text
            base(contadorindice).paisBase = combopais.Text
            combobusqueda.Items.Add(input.Text)
            MsgBox("Dato ingresado con éxito.")
            comboclear()
            input.Text = ""
            combosistema.Text = ""
            comboaño.Text = ""
            combopais.Text = ""
            validar.Checked = False
            validar.Enabled = False
        End If

    End Sub
    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        For posicion = 1 To contadorindice 'Marca la cantidad de ciclos'
            If UCase(combobusqueda.Text) = UCase(base(posicion).nombrepelBase) Then
                outputsistema.Text = base(posicion).calidadBase
                outputaño.Text = base(posicion).añoBase
                outputpais.Text = base(posicion).paisBase
                Exit Sub
            End If
        Next
        MsgBox("No se ha encontrado registro.")

    End Sub
    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        For posicion = 1 To contadorindice 'Marca la cantidad de ciclos'
            If UCase(combobusqueda.Text) = UCase(base(posicion).nombrepelBase) Then
                outputsistema.Text = base(posicion).calidadBase
                outputaño.Text = base(posicion).añoBase
                outputpais.Text = base(posicion).paisBase

                Dim decision As Integer = MsgBox("Registro encontrado ¿Desea borrar?", 32 + 1)

                If decision = 1 Then 'Quiere borrar'
                    combobusqueda.Items.Remove(base(posicion).nombrepelBase)
                    base(posicion).nombrepelBase = base(posicion + 1).nombrepelBase
                    base(posicion).calidadBase = base(posicion + 1).calidadBase
                    base(posicion).añoBase = base(posicion + 1).añoBase
                    base(posicion).paisBase = base(posicion + 1).paisBase
                    'Subo un punto a cada item'
                    contadorindice -= 1 'Retiro un indice de la tabla'
                    Form2.slots.Text = contadorindice

                    MsgBox("Registro eliminado con exito.")
                    combobusqueda.Text = ""
                    outputsistema.Text = ""
                    outputaño.Text = ""
                    outputpais.Text = ""
                    Exit Sub
                Else
                    Exit Sub
                End If
            End If
        Next
        MsgBox("No se ha encontrado registro.")
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        input.Text = ""
        combosistema.Text = ""
        comboaño.Text = ""
        combopais.Text = ""
        validar.Checked = False
    End Sub
    Private Sub btnlimpiar2_Click(sender As Object, e As EventArgs) Handles btnlimpiar2.Click
        combobusqueda.Text = ""
        outputsistema.Text = ""
        outputaño.Text = ""
        outputpais.Text = ""
    End Sub

End Class
