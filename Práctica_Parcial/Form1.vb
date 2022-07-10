Public Class Form1
    Public Function limpiar()
        Comboconsulta.Text = ""
        Outputlocalidad.Text = ""
        Outputsucursal.Text = ""
        Outputpais.Text = ""
        Return 0

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btnañadir.Enabled = False
        Btnconsultar.Enabled = False
        Btnborrar.Enabled = False
        Btnlimpiar.Enabled = False

    End Sub
    Private Sub Inputprov_TextChanged(sender As Object, e As EventArgs) Handles Inputprov.TextChanged
        If Inputprov.Text <> "" Then
            Btnañadir.Enabled = True
        Else
            Btnañadir.Enabled = False
        End If
    End Sub
    Private Sub Btnañadir_Click(sender As Object, e As EventArgs) Handles Btnañadir.Click
        cantbase += 1

        If cantbase > 5 Then
            MsgBox("La el storage esta límitado a 5 proveedores.")
            cantbase -= 1
        Else
            If Inputprov.Text = "" Or Combolocalidad.Text = "" Or Combosucursal.Text = "" Or Combopais.Text = "" Then
                MsgBox("Debe elegir un elemento en cada lista.")
                cantbase -= 1
            Else
                base(cantbase).provBase = Inputprov.Text
                base(cantbase).locBase = Combolocalidad.Text
                base(cantbase).paisBase = Combopais.Text
                base(cantbase).sucBase = Val(Combosucursal.Text)
                Comboconsulta.Items.Add(Inputprov.Text)
                Outputcount.Text = cantbase
                Btnconsultar.Enabled = True
                Btnborrar.Enabled = True
                Btnlimpiar.Enabled = True
                MsgBox("Dato ingresado con éxito.")
                Inputprov.Text = ""
                Combolocalidad.Text = ""
                Combopais.Text = ""
                Combosucursal.Text = ""
            End If
        End If
    End Sub

    Private Sub Btnconsultar_Click(sender As Object, e As EventArgs) Handles Btnconsultar.Click
        For i = 1 To cantbase 'Marca la cantidad de ciclos'
            If UCase(Comboconsulta.Text) = UCase(base(i).provBase) Then
                Outputlocalidad.Text = base(i).locBase
                Outputsucursal.Text = base(i).sucBase
                Outputpais.Text = base(i).paisBase
                Exit Sub
            End If
        Next
        MsgBox("No se ha encontrado registro.")

    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub Btnborrar_Click(sender As Object, e As EventArgs) Handles Btnborrar.Click
        For a = 1 To cantbase 'Marca la cantidad de ciclos para recorrer la matriz'
            If UCase(Comboconsulta.Text) = UCase(base(a).provBase) Then
                Outputlocalidad.Text = base(a).locBase
                Outputsucursal.Text = base(a).sucBase
                Outputpais.Text = base(a).paisBase

                Dim decision As Integer = MsgBox("Registro encontrado ¿Desea borrar?", 32 + 1)

                If decision = 1 Then 'Quiere borrar'
                    Comboconsulta.Items.Remove(base(a).provBase) 'Borro en posición A del combo consulta'
                    cantbase -= 1 'Retiro un indice de la tabla
                    Outputcount.Text = cantbase
                    For b = a To cantbase 'Recorro de nuevo para subir un punto cada item'
                        base(b).provBase = base(b + 1).provBase
                        base(b).locBase = base(b + 1).locBase
                        base(b).sucBase = base(b + 1).sucBase
                        base(b).paisBase = base(b + 1).paisBase
                    Next
                    MsgBox("Registro eliminado con exito.")
                    limpiar()
                    Exit Sub
                End If
                Exit Sub
            End If
        Next
        MsgBox("No se ha encontrado registro.")

    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        MsgBox("Cerrando app.")
        End

    End Sub

    Private Sub Btnrestart_Click(sender As Object, e As EventArgs) Handles Btnrestart.Click
        MsgBox("Reiniciando app.")
        Application.Restart()

    End Sub

End Class
