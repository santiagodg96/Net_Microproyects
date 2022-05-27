Public Class Form1

    Private Sub Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.Click

        If Input.Text = "" Then
            MsgBox("No es posible calcular si usted no ingresa ningún valor.")
        End If

        'Sector milisegundos'

        If CheckMil.Checked Then
            If CheckMil2.Checked Then
                MsgBox("Seleccione una unidad de medida distinta para convertir.")
                Medida.Text = "-"
            End If
            If CheckSeg2.Checked Then
                Medida.Text = "Segundos"
                Resultado.Text = (Input.Text) / 1000
            End If
            If CheckMin2.Checked Then
                Medida.Text = "Minutos"
                Resultado.Text = (Input.Text) / 60000
            End If
            If CheckHor2.Checked Then
                Medida.Text = "Horas"
                Resultado.Text = (Input.Text) / 3600000.0 '3.6 millones
            End If
        End If

        'Sector segundos'

        If CheckSeg.Checked Then
            If CheckMil2.Checked Then
                Medida.Text = "Miliegundos"
                Resultado.Text = (Input.Text) * 1000
            End If
            If CheckSeg2.Checked Then
                Medida.Text = "-"
                MsgBox("Seleccione una unidad de medida distinta para convertir.")
            End If
            If CheckMin2.Checked Then
                Medida.Text = "Minutos"
                Resultado.Text = (Input.Text) / 60
            End If
            If CheckHor2.Checked Then
                Medida.Text = "Horas"
                Resultado.Text = (Input.Text) / 3600
            End If
        End If

        'Sector minutos'

        If CheckMin.Checked Then

            If CheckMil2.Checked Then
                Medida.Text = "Milisegundos"
                Resultado.Text = (Input.Text) * 60000
            End If
            If CheckSeg2.Checked Then
                Medida.Text = "Segundos"
                Resultado.Text = (Input.Text) * 60
            End If
            If CheckMin2.Checked Then
                Medida.Text = "-"
                MsgBox("Seleccione una unidad de medida distinta para convertir.")
            End If
            If CheckHor2.Checked Then
                Medida.Text = "Horas"
                Resultado.Text = (Input.Text) / 60
            End If
        End If

        'Sector horas'

        If CheckHor.Checked Then
            If CheckMil2.Checked Then
                Medida.Text = "Milisegundos"
                Resultado.Text = (Input.Text) * 3600000.0
            End If
            If CheckSeg2.Checked Then
                Medida.Text = "Segundos"
                Resultado.Text = (Input.Text) * 3600
            End If
            If CheckMin2.Checked Then
                Medida.Text = "Minutos"
                Resultado.Text = (Input.Text) * 60
            End If
            If CheckHor2.Checked Then
                Medida.Text = "-"
                MsgBox("Seleccione una unidad de medida distinta para convertir.")
            End If
        End If

        Input.Text = ""
        CheckMil.CheckState = CheckState.Unchecked
        CheckMil2.CheckState = CheckState.Unchecked
        CheckSeg.CheckState = CheckState.Unchecked
        CheckSeg2.CheckState = CheckState.Unchecked
        CheckMin.CheckState = CheckState.Unchecked
        CheckMin2.CheckState = CheckState.Unchecked
        CheckHor.CheckState = CheckState.Unchecked
        CheckHor2.CheckState = CheckState.Unchecked
    End Sub

    'Check status'
    Private Sub CheckMil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMil.CheckedChanged
        If CheckMil.Checked Then
            CheckSeg.Enabled = False
            CheckMin.Enabled = False
            CheckHor.Enabled = False
        Else
            CheckSeg.Enabled = True
            CheckMin.Enabled = True
            CheckHor.Enabled = True
        End If
    End Sub

    Private Sub CheckSeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSeg.CheckedChanged
        If CheckSeg.Checked Then
            CheckMil.Enabled = False
            CheckMin.Enabled = False
            CheckHor.Enabled = False
        Else
            CheckMil.Enabled = True
            CheckMin.Enabled = True
            CheckHor.Enabled = True
        End If
    End Sub

    Private Sub CheckMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMin.CheckedChanged
        If CheckMin.Checked Then
            CheckMil.Enabled = False
            CheckSeg.Enabled = False
            CheckHor.Enabled = False
        Else
            CheckMil.Enabled = True
            CheckSeg.Enabled = True
            CheckHor.Enabled = True
        End If
    End Sub

    Private Sub CheckHor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckHor.CheckedChanged
        If CheckHor.Checked Then
            CheckMil.Enabled = False
            CheckSeg.Enabled = False
            CheckMin.Enabled = False
        Else
            CheckMil.Enabled = True
            CheckSeg.Enabled = True
            CheckMin.Enabled = True
        End If
    End Sub

    'Check status segundo grupo'

    Private Sub CheckMil2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMil2.CheckedChanged
        If CheckMil2.Checked Then
            CheckSeg2.Enabled = False
            CheckMin2.Enabled = False
            CheckHor2.Enabled = False
        Else
            CheckSeg2.Enabled = True
            CheckMin2.Enabled = True
            CheckHor2.Enabled = True
        End If
    End Sub

    Private Sub CheckSeg2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSeg2.CheckedChanged
        If CheckSeg2.Checked Then
            CheckMil2.Enabled = False
            CheckMin2.Enabled = False
            CheckHor2.Enabled = False
        Else
            CheckMil2.Enabled = True
            CheckMin2.Enabled = True
            CheckHor2.Enabled = True
        End If
    End Sub

    Private Sub CheckMin2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckMin2.CheckedChanged
        If CheckMin2.Checked Then
            CheckMil2.Enabled = False
            CheckSeg2.Enabled = False
            CheckHor2.Enabled = False
        Else
            CheckMil2.Enabled = True
            CheckSeg2.Enabled = True
            CheckHor2.Enabled = True
        End If
    End Sub

    Private Sub CheckHor2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckHor2.CheckedChanged
        If CheckHor2.Checked Then
            CheckMil2.Enabled = False
            CheckSeg2.Enabled = False
            CheckMin2.Enabled = False
        Else
            CheckMil2.Enabled = True
            CheckSeg2.Enabled = True
            CheckMin2.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
