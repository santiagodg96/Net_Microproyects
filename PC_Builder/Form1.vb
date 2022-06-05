Public Class Form1
    Dim totalval, totalperval, ramaux As Double
    'CPUs'
    Dim i7val As Double = 50000
    Dim i5val As Double = 42000
    Dim i3val As Double = 19000
    Dim r7val As Double = 49000
    Dim r5val As Double = 37200
    Dim apuval As Double = 33900
    'Mothers'
    Dim msi_intelval As Double = 17000
    Dim asus_intelval As Double = 12000
    Dim asus_ryzenval As Double = 10100
    Dim asus_apuval As Double = 8200
    'Ram'
    Dim corsair_4 As Double = 5400
    Dim corsair_8 As Double = 10200
    Dim corsair_16 As Double = 21000
    Dim kingston_4 As Double = 6200
    Dim kingston_8 As Double = 11000
    Dim kingston_16 As Double = 20050
    Dim kingston_24 As Double = 34800
    'Discos'
    Dim WestBlackval As Double = 18000
    Dim WestBlueVal As Double = 3000
    'Perifericos'
    Dim Kitval As Double = 11000
    Dim Samsungval As Double = 25599
    Dim Penval As Double = 619

    Private Sub I7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I7.CheckedChanged
        If I7.Checked Then
            I5.Enabled = False
            I3.Enabled = False
            R5.Enabled = False
            R7.Enabled = False
            Apu.Enabled = False
            cpu_final.Text = I7.Text
            total.Text = Val(total.Text + i7val)
        Else
            I5.Enabled = True
            I3.Enabled = True
            R5.Enabled = True
            R7.Enabled = True
            Apu.Enabled = True
            cpu_final.Text = "Procesador"
            total.Text -= i7val
        End If
    End Sub

    Private Sub I5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I5.CheckedChanged
        If I5.Checked Then
            I7.Enabled = False
            I3.Enabled = False
            R5.Enabled = False
            R7.Enabled = False
            Apu.Enabled = False
            cpu_final.Text = I5.Text
            total.Text = Val(total.Text + i5val)
        Else
            I7.Enabled = True
            I3.Enabled = True
            R5.Enabled = True
            R7.Enabled = True
            Apu.Enabled = True
            cpu_final.Text = "Procesador"
            total.Text -= i5val
        End If
    End Sub

    Private Sub I3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I3.CheckedChanged
        If I3.Checked Then
            I7.Enabled = False
            I5.Enabled = False
            R5.Enabled = False
            R7.Enabled = False
            Apu.Enabled = False
            cpu_final.Text = I3.Text
            total.Text = Val(total.Text + i3val)
        Else
            I7.Enabled = True
            I5.Enabled = True
            R5.Enabled = True
            R7.Enabled = True
            Apu.Enabled = True
            cpu_final.Text = "Procesador"
            total.Text -= i3val
        End If
    End Sub

    Private Sub R7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R7.CheckedChanged
        If R7.Checked Then
            I7.Enabled = False
            I5.Enabled = False
            R5.Enabled = False
            I3.Enabled = False
            Apu.Enabled = False
            cpu_final.Text = R7.Text
            total.Text = Val(total.Text + r7val)
        Else
            I7.Enabled = True
            I5.Enabled = True
            R5.Enabled = True
            I3.Enabled = True
            Apu.Enabled = True
            cpu_final.Text = "Procesador"
            total.Text -= r7val
        End If
    End Sub

    Private Sub R5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R5.CheckedChanged
        If R5.Checked Then
            I7.Enabled = False
            I5.Enabled = False
            R7.Enabled = False
            I3.Enabled = False
            Apu.Enabled = False
            cpu_final.Text = R5.Text
            total.Text = Val(total.Text + r5val)
        Else
            I7.Enabled = True
            I5.Enabled = True
            R7.Enabled = True
            I3.Enabled = True
            Apu.Enabled = True
            cpu_final.Text = "Procesador"
            total.Text -= r5val
        End If
    End Sub

    Private Sub Apu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apu.CheckedChanged
        If Apu.Checked Then
            I7.Enabled = False
            I5.Enabled = False
            R5.Enabled = False
            I3.Enabled = False
            R7.Enabled = False
            cpu_final.Text = Apu.Text
            total.Text = Val(total.Text + apuval)
        Else
            I7.Enabled = True
            I5.Enabled = True
            R5.Enabled = True
            I3.Enabled = True
            R7.Enabled = True
            cpu_final.Text = "Procesador"
            total.Text -= apuval
        End If
    End Sub

    Private Sub MSI_Intel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSI_Intel.CheckedChanged
        If MSI_Intel.Checked Then
            Asus_Intel.Enabled = False
            Asus_Ryzen.Enabled = False
            Asus_Apu.Enabled = False
            mother_final.Text = MSI_Intel.Text
            total.Text = Val(total.Text + msi_intelval)
        Else
            Asus_Intel.Enabled = True
            Asus_Ryzen.Enabled = True
            Asus_Apu.Enabled = True
            mother_final.Text = "Motherboard"
            total.Text -= msi_intelval
        End If
    End Sub

    Private Sub Asus_Intel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asus_Intel.CheckedChanged
        If Asus_Intel.Checked Then
            MSI_Intel.Enabled = False
            Asus_Ryzen.Enabled = False
            Asus_Apu.Enabled = False
            mother_final.Text = Asus_Intel.Text
            total.Text = Val(total.Text + asus_intelval)
        Else
            MSI_Intel.Enabled = True
            Asus_Ryzen.Enabled = True
            Asus_Apu.Enabled = True
            mother_final.Text = "Motherboard"
            total.Text -= asus_intelval
        End If
    End Sub

    Private Sub Asus_Ryzen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asus_Ryzen.CheckedChanged
        If Asus_Ryzen.Checked Then
            MSI_Intel.Enabled = False
            Asus_Intel.Enabled = False
            Asus_Apu.Enabled = False
            mother_final.Text = Asus_Ryzen.Text
            total.Text = Val(total.Text + asus_ryzenval)
        Else
            MSI_Intel.Enabled = True
            Asus_Intel.Enabled = True
            Asus_Apu.Enabled = True
            mother_final.Text = "Motherboard"
            total.Text -= asus_ryzenval
        End If
    End Sub

    Private Sub Asus_Apu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asus_Apu.CheckedChanged
        If Asus_Apu.Checked Then
            MSI_Intel.Enabled = False
            Asus_Ryzen.Enabled = False
            Asus_Intel.Enabled = False
            mother_final.Text = Asus_Intel.Text
            total.Text = Val(total.Text + asus_apuval)
        Else
            MSI_Intel.Enabled = True
            Asus_Ryzen.Enabled = True
            Asus_Intel.Enabled = True
            mother_final.Text = "Motherboard"
            total.Text -= asus_apuval
        End If
    End Sub

    Private Sub Corsair_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Corsair.CheckedChanged

        If Corsair.Checked Then
            Kingston.Enabled = False
            ram_final.Text = Corsair.Text
            ram_amount.Items.Add("4")
            ram_amount.Items.Add("8")
            ram_amount.Items.Add("16")
        Else
            Kingston.Enabled = True
            ram_final.Text = "Ram"
            ram_amount.Items.Remove("4")
            ram_amount.Items.Remove("8")
            ram_amount.Items.Remove("16")
        End If
    End Sub

    Private Sub Kingston_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kingston.CheckedChanged

        If Kingston.Checked Then
            Corsair.Enabled = False
            ram_final.Text = Kingston.Text
            ram_amount.Items.Add("4")
            ram_amount.Items.Add("8")
            ram_amount.Items.Add("16")
            ram_amount.Items.Add("24")
        Else
            Corsair.Enabled = True
            ram_final.Text = "Ram"
            ram_amount.Items.Remove("4")
            ram_amount.Items.Remove("8")
            ram_amount.Items.Remove("16")
            ram_amount.Items.Remove("24")
        End If
    End Sub

    Private Sub Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cargar.Click
        Borrar.Enabled = True

        If ram_amount.Text <> "Cantidad" Then
            Dim aux As Double = ram_amount.Text
            If Corsair.Checked Then
                If aux = 4 Then
                    total.Text += corsair_4
                    ramaux = corsair_4
                    ram_amount_final.Text = 4
                    ram_amount.Enabled = False
                    Corsair.Enabled = False
                End If
                If aux = 8 Then
                    total.Text += corsair_8
                    ramaux = corsair_8
                    ram_amount_final.Text = 8
                    ram_amount.Enabled = False
                    Corsair.Enabled = False
                End If
                If aux = 16 Then
                    total.Text += corsair_16
                    ramaux = corsair_16
                    ram_amount_final.Text = 16
                    ram_amount.Enabled = False
                    Corsair.Enabled = False
                End If
            End If

            If Kingston.Checked Then
                If aux = 4 Then
                    total.Text += kingston_4
                    ramaux = kingston_4
                    ram_amount_final.Text = 4
                    ram_amount.Enabled = False
                    Kingston.Enabled = False
                End If
                If aux = 8 Then
                    total.Text += kingston_8
                    ramaux = kingston_8
                    ram_amount_final.Text = 8
                    ram_amount.Enabled = False
                    Kingston.Enabled = False
                End If
                If aux = 16 Then
                    total.Text += kingston_16
                    ramaux = kingston_16
                    ram_amount_final.Text = 16
                    ram_amount.Enabled = False
                    Kingston.Enabled = False
                End If
                If aux = 24 Then
                    total.Text += kingston_24
                    ramaux = kingston_24
                    ram_amount_final.Text = 24
                    ram_amount.Enabled = False
                    Kingston.Enabled = False
                End If
            End If
        Else
            MsgBox("Debe seleccionar una cantidad primero.")
        End If
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click
        If total.Text <> "0" Then
            ram_amount.Enabled = True
            Corsair.Enabled = True
            Kingston.Enabled = True
            Corsair.Checked = False
            Kingston.Checked = False
            ram_amount.Text = "Cantidad"
            ram_amount_final.Text = "Cantidad"
            total.Text -= ramaux
        End If
    End Sub
    
    Private Sub WestBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WestBlack.CheckedChanged
        If WestBlack.Checked Then
            WestBlue.Enabled = False
            disco_final.Text = WestBlack.Text
            total.Text = Val(total.Text + WestBlackval)
        Else
            WestBlue.Enabled = True
            WestBlack.Enabled = True
            disco_final.Text = "Disco"
            total.Text -= WestBlackVal
        End If
    End Sub

    Private Sub WestBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WestBlue.CheckedChanged
        If WestBlue.Checked Then
            WestBlack.Enabled = False
            disco_final.Text = WestBlue.Text
            total.Text = Val(total.Text + WestBlueVal)
        Else
            WestBlue.Enabled = True
            WestBlack.Enabled = True
            disco_final.Text = "Disco"
            total.Text -= WestBlueVal
        End If
    End Sub

    Private Sub Kit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kit.CheckedChanged
        If Kit.Checked Then
            Samsung.Enabled = True
            Pen.Enabled = True
            total.Text = Val(total.Text + Kitval)
            total_perif.Text = Val(total_perif.Text + Kitval)
        Else
            Samsung.Enabled = True
            Pen.Enabled = True
            total.Text -= Kitval
            total_perif.Text -= Kitval
        End If
    End Sub

    Private Sub Samsung_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Samsung.CheckedChanged
        If Samsung.Checked Then
            Kit.Enabled = True
            Pen.Enabled = True
            total.Text = Val(total.Text + Samsungval)
            total_perif.Text = Val(total_perif.Text + Samsungval)
        Else
            Kit.Enabled = True
            Pen.Enabled = True
            total.Text -= Samsungval
            total_perif.Text -= Samsungval
        End If
    End Sub

    Private Sub Pen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pen.CheckedChanged
        If Pen.Checked Then
            Kit.Enabled = True
            Samsung.Enabled = True
            total.Text = Val(total.Text + Penval)
            total_perif.Text = Val(total_perif.Text + Penval)
        Else
            Samsung.Enabled = True
            Kit.Enabled = True
            total.Text -= Penval
            total_perif.Text -= Penval
        End If
    End Sub

    Private Sub Comprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comprar.Click
        If total.Text And total_perif.Text <> "" Then
            MsgBox("Muchas gracias por su compra. Próximamente podrá imprimir su boleta. Presione reiniciar si desea volver a comenzar.")
        Else
            MsgBox("Debe seleccionar al menos un producto para poder comprar.")
        End If
    End Sub

    Private Sub Reiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reiniciar.Click
        MsgBox("Reiniciando.")
        Application.Restart()
    End Sub

End Class
