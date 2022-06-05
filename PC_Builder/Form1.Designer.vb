<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.I3 = New System.Windows.Forms.CheckBox()
        Me.Apu = New System.Windows.Forms.CheckBox()
        Me.R5 = New System.Windows.Forms.CheckBox()
        Me.I5 = New System.Windows.Forms.CheckBox()
        Me.R7 = New System.Windows.Forms.CheckBox()
        Me.I7 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Asus_Ryzen = New System.Windows.Forms.CheckBox()
        Me.Asus_Intel = New System.Windows.Forms.CheckBox()
        Me.Asus_Apu = New System.Windows.Forms.CheckBox()
        Me.MSI_Intel = New System.Windows.Forms.CheckBox()
        Me.Corsair = New System.Windows.Forms.CheckBox()
        Me.Kingston = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Cargar = New System.Windows.Forms.Button()
        Me.ram_amount = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.WestBlue = New System.Windows.Forms.CheckBox()
        Me.WestBlack = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Reiniciar = New System.Windows.Forms.Button()
        Me.Comprar = New System.Windows.Forms.Button()
        Me.total_perif = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.disco_final = New System.Windows.Forms.Label()
        Me.ram_amount_final = New System.Windows.Forms.Label()
        Me.ram_final = New System.Windows.Forms.Label()
        Me.mother_final = New System.Windows.Forms.Label()
        Me.cpu_final = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Kit = New System.Windows.Forms.CheckBox()
        Me.Samsung = New System.Windows.Forms.CheckBox()
        Me.Pen = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 478)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 59
        Me.LineShape1.X2 = 716
        Me.LineShape1.Y1 = 65
        Me.LineShape1.Y2 = 65
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(303, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(169, 37)
        Me.label1.TabIndex = 1
        Me.label1.Text = "PC Builder"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.I3)
        Me.GroupBox1.Controls.Add(Me.Apu)
        Me.GroupBox1.Controls.Add(Me.R5)
        Me.GroupBox1.Controls.Add(Me.I5)
        Me.GroupBox1.Controls.Add(Me.R7)
        Me.GroupBox1.Controls.Add(Me.I7)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(59, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 108)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Procesador "
        '
        'I3
        '
        Me.I3.AutoSize = True
        Me.I3.Location = New System.Drawing.Point(16, 74)
        Me.I3.Name = "I3"
        Me.I3.Size = New System.Drawing.Size(115, 17)
        Me.I3.TabIndex = 5
        Me.I3.Text = "Intel Core i3‑10105"
        Me.I3.UseVisualStyleBackColor = True
        '
        'Apu
        '
        Me.Apu.AutoSize = True
        Me.Apu.Location = New System.Drawing.Point(143, 74)
        Me.Apu.Name = "Apu"
        Me.Apu.Size = New System.Drawing.Size(124, 17)
        Me.Apu.TabIndex = 4
        Me.Apu.Text = "AMD A10-9700 APU"
        Me.Apu.UseVisualStyleBackColor = True
        '
        'R5
        '
        Me.R5.AutoSize = True
        Me.R5.Location = New System.Drawing.Point(143, 51)
        Me.R5.Name = "R5"
        Me.R5.Size = New System.Drawing.Size(126, 17)
        Me.R5.TabIndex = 3
        Me.R5.Text = "AMD Ryzen 5 5600X"
        Me.R5.UseVisualStyleBackColor = True
        '
        'I5
        '
        Me.I5.AutoSize = True
        Me.I5.Location = New System.Drawing.Point(16, 51)
        Me.I5.Name = "I5"
        Me.I5.Size = New System.Drawing.Size(121, 17)
        Me.I5.TabIndex = 2
        Me.I5.Text = "Intel Core i5-11400F"
        Me.I5.UseVisualStyleBackColor = True
        '
        'R7
        '
        Me.R7.AutoSize = True
        Me.R7.Location = New System.Drawing.Point(144, 28)
        Me.R7.Name = "R7"
        Me.R7.Size = New System.Drawing.Size(126, 17)
        Me.R7.TabIndex = 1
        Me.R7.Text = "AMD Ryzen 7 5800X"
        Me.R7.UseVisualStyleBackColor = True
        '
        'I7
        '
        Me.I7.AutoSize = True
        Me.I7.Location = New System.Drawing.Point(16, 28)
        Me.I7.Name = "I7"
        Me.I7.Size = New System.Drawing.Size(122, 17)
        Me.I7.TabIndex = 0
        Me.I7.Text = "Intel Core i7-11700K"
        Me.I7.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Asus_Ryzen)
        Me.GroupBox2.Controls.Add(Me.Asus_Intel)
        Me.GroupBox2.Controls.Add(Me.Asus_Apu)
        Me.GroupBox2.Controls.Add(Me.MSI_Intel)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(59, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 86)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Motherboard"
        '
        'Asus_Ryzen
        '
        Me.Asus_Ryzen.AutoSize = True
        Me.Asus_Ryzen.Location = New System.Drawing.Point(169, 28)
        Me.Asus_Ryzen.Name = "Asus_Ryzen"
        Me.Asus_Ryzen.Size = New System.Drawing.Size(168, 17)
        Me.Asus_Ryzen.TabIndex = 3
        Me.Asus_Ryzen.Text = "ASUS Prime A320m-k (Ryzen)"
        Me.Asus_Ryzen.UseVisualStyleBackColor = True
        '
        'Asus_Intel
        '
        Me.Asus_Intel.AutoSize = True
        Me.Asus_Intel.Location = New System.Drawing.Point(16, 51)
        Me.Asus_Intel.Name = "Asus_Intel"
        Me.Asus_Intel.Size = New System.Drawing.Size(149, 17)
        Me.Asus_Intel.TabIndex = 2
        Me.Asus_Intel.Text = "Asus B460m-a R2.0 (Intel)"
        Me.Asus_Intel.UseVisualStyleBackColor = True
        '
        'Asus_Apu
        '
        Me.Asus_Apu.AutoSize = True
        Me.Asus_Apu.Location = New System.Drawing.Point(169, 51)
        Me.Asus_Apu.Name = "Asus_Apu"
        Me.Asus_Apu.Size = New System.Drawing.Size(162, 17)
        Me.Asus_Apu.TabIndex = 1
        Me.Asus_Apu.Text = "ASUS Prime A320M-A (APU)"
        Me.Asus_Apu.UseVisualStyleBackColor = True
        '
        'MSI_Intel
        '
        Me.MSI_Intel.AutoSize = True
        Me.MSI_Intel.Location = New System.Drawing.Point(16, 28)
        Me.MSI_Intel.Name = "MSI_Intel"
        Me.MSI_Intel.Size = New System.Drawing.Size(147, 17)
        Me.MSI_Intel.TabIndex = 0
        Me.MSI_Intel.Text = "MSI B560M-A PRO (Intel)"
        Me.MSI_Intel.UseVisualStyleBackColor = True
        '
        'Corsair
        '
        Me.Corsair.AutoSize = True
        Me.Corsair.Location = New System.Drawing.Point(16, 28)
        Me.Corsair.Name = "Corsair"
        Me.Corsair.Size = New System.Drawing.Size(104, 17)
        Me.Corsair.TabIndex = 0
        Me.Corsair.Text = "Corsair 2666mhz"
        Me.Corsair.UseVisualStyleBackColor = True
        '
        'Kingston
        '
        Me.Kingston.AutoSize = True
        Me.Kingston.Location = New System.Drawing.Point(16, 51)
        Me.Kingston.Name = "Kingston"
        Me.Kingston.Size = New System.Drawing.Size(113, 17)
        Me.Kingston.TabIndex = 3
        Me.Kingston.Text = "Kingston 2800mhz"
        Me.Kingston.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Borrar)
        Me.GroupBox3.Controls.Add(Me.Cargar)
        Me.GroupBox3.Controls.Add(Me.ram_amount)
        Me.GroupBox3.Controls.Add(Me.Kingston)
        Me.GroupBox3.Controls.Add(Me.Corsair)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(59, 288)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 86)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione Ram"
        '
        'Borrar
        '
        Me.Borrar.Enabled = False
        Me.Borrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Borrar.Location = New System.Drawing.Point(218, 46)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(49, 29)
        Me.Borrar.TabIndex = 10
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Cargar
        '
        Me.Cargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cargar.Location = New System.Drawing.Point(167, 46)
        Me.Cargar.Name = "Cargar"
        Me.Cargar.Size = New System.Drawing.Size(49, 29)
        Me.Cargar.TabIndex = 9
        Me.Cargar.Text = "Cargar"
        Me.Cargar.UseVisualStyleBackColor = True
        '
        'ram_amount
        '
        Me.ram_amount.FormattingEnabled = True
        Me.ram_amount.Location = New System.Drawing.Point(167, 19)
        Me.ram_amount.Name = "ram_amount"
        Me.ram_amount.Size = New System.Drawing.Size(100, 21)
        Me.ram_amount.TabIndex = 8
        Me.ram_amount.Text = "Cantidad"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.WestBlue)
        Me.GroupBox4.Controls.Add(Me.WestBlack)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(59, 380)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(365, 86)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccione Almacenamiento"
        '
        'WestBlue
        '
        Me.WestBlue.AutoSize = True
        Me.WestBlue.Location = New System.Drawing.Point(16, 51)
        Me.WestBlue.Name = "WestBlue"
        Me.WestBlue.Size = New System.Drawing.Size(187, 17)
        Me.WestBlue.TabIndex = 3
        Me.WestBlue.Text = "Western Digital Blue Solid 150 GB"
        Me.WestBlue.UseVisualStyleBackColor = True
        '
        'WestBlack
        '
        Me.WestBlack.AutoSize = True
        Me.WestBlack.Location = New System.Drawing.Point(16, 28)
        Me.WestBlack.Name = "WestBlack"
        Me.WestBlack.Size = New System.Drawing.Size(170, 17)
        Me.WestBlack.TabIndex = 0
        Me.WestBlack.Text = "Western Digital Black Solid 1T"
        Me.WestBlack.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox5.Controls.Add(Me.Reiniciar)
        Me.GroupBox5.Controls.Add(Me.Comprar)
        Me.GroupBox5.Controls.Add(Me.total_perif)
        Me.GroupBox5.Controls.Add(Me.total)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.label3)
        Me.GroupBox5.Controls.Add(Me.disco_final)
        Me.GroupBox5.Controls.Add(Me.ram_amount_final)
        Me.GroupBox5.Controls.Add(Me.ram_final)
        Me.GroupBox5.Controls.Add(Me.mother_final)
        Me.GroupBox5.Controls.Add(Me.cpu_final)
        Me.GroupBox5.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(485, 196)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 270)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Componetes Seleccionados"
        '
        'Reiniciar
        '
        Me.Reiniciar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Reiniciar.Location = New System.Drawing.Point(118, 235)
        Me.Reiniciar.Name = "Reiniciar"
        Me.Reiniciar.Size = New System.Drawing.Size(75, 23)
        Me.Reiniciar.TabIndex = 11
        Me.Reiniciar.Text = "Reiniciar"
        Me.Reiniciar.UseVisualStyleBackColor = False
        '
        'Comprar
        '
        Me.Comprar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Comprar.Location = New System.Drawing.Point(36, 235)
        Me.Comprar.Name = "Comprar"
        Me.Comprar.Size = New System.Drawing.Size(75, 23)
        Me.Comprar.TabIndex = 10
        Me.Comprar.Text = "Comprar"
        Me.Comprar.UseVisualStyleBackColor = False
        '
        'total_perif
        '
        Me.total_perif.AutoSize = True
        Me.total_perif.Location = New System.Drawing.Point(110, 198)
        Me.total_perif.Name = "total_perif"
        Me.total_perif.Size = New System.Drawing.Size(13, 13)
        Me.total_perif.TabIndex = 9
        Me.total_perif.Text = "0"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(110, 147)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(13, 13)
        Me.total.TabIndex = 8
        Me.total.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Perifericos:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 147)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Total:"
        '
        'disco_final
        '
        Me.disco_final.AutoSize = True
        Me.disco_final.Location = New System.Drawing.Point(6, 121)
        Me.disco_final.Name = "disco_final"
        Me.disco_final.Size = New System.Drawing.Size(34, 13)
        Me.disco_final.TabIndex = 4
        Me.disco_final.Text = "Disco"
        '
        'ram_amount_final
        '
        Me.ram_amount_final.AutoSize = True
        Me.ram_amount_final.Location = New System.Drawing.Point(6, 96)
        Me.ram_amount_final.Name = "ram_amount_final"
        Me.ram_amount_final.Size = New System.Drawing.Size(49, 13)
        Me.ram_amount_final.TabIndex = 3
        Me.ram_amount_final.Text = "Cantidad"
        '
        'ram_final
        '
        Me.ram_final.AutoSize = True
        Me.ram_final.Location = New System.Drawing.Point(6, 70)
        Me.ram_final.Name = "ram_final"
        Me.ram_final.Size = New System.Drawing.Size(29, 13)
        Me.ram_final.TabIndex = 2
        Me.ram_final.Text = "Ram"
        '
        'mother_final
        '
        Me.mother_final.AutoSize = True
        Me.mother_final.Location = New System.Drawing.Point(6, 47)
        Me.mother_final.Name = "mother_final"
        Me.mother_final.Size = New System.Drawing.Size(67, 13)
        Me.mother_final.TabIndex = 1
        Me.mother_final.Text = "Motherboard"
        '
        'cpu_final
        '
        Me.cpu_final.AutoSize = True
        Me.cpu_final.Location = New System.Drawing.Point(6, 24)
        Me.cpu_final.Name = "cpu_final"
        Me.cpu_final.Size = New System.Drawing.Size(61, 13)
        Me.cpu_final.TabIndex = 0
        Me.cpu_final.Text = "Procesador"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(226, 251)
        Me.ShapeContainer2.TabIndex = 6
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 33
        Me.LineShape2.X2 = 189
        Me.LineShape2.Y1 = 162
        Me.LineShape2.Y2 = 162
        '
        'Kit
        '
        Me.Kit.AutoSize = True
        Me.Kit.Location = New System.Drawing.Point(16, 28)
        Me.Kit.Name = "Kit"
        Me.Kit.Size = New System.Drawing.Size(162, 17)
        Me.Kit.TabIndex = 0
        Me.Kit.Text = "Kit mouse, teclado y parlante"
        Me.Kit.UseVisualStyleBackColor = True
        '
        'Samsung
        '
        Me.Samsung.AutoSize = True
        Me.Samsung.Location = New System.Drawing.Point(16, 51)
        Me.Samsung.Name = "Samsung"
        Me.Samsung.Size = New System.Drawing.Size(152, 17)
        Me.Samsung.TabIndex = 2
        Me.Samsung.Text = "Led Samsung 24 pulgadas"
        Me.Samsung.UseVisualStyleBackColor = True
        '
        'Pen
        '
        Me.Pen.AutoSize = True
        Me.Pen.Location = New System.Drawing.Point(16, 74)
        Me.Pen.Name = "Pen"
        Me.Pen.Size = New System.Drawing.Size(148, 17)
        Me.Pen.TabIndex = 5
        Me.Pen.Text = "Pendryve Kingston 16 GB"
        Me.Pen.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Pen)
        Me.GroupBox6.Controls.Add(Me.Samsung)
        Me.GroupBox6.Controls.Add(Me.Kit)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Location = New System.Drawing.Point(485, 82)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(232, 108)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Perifericos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(784, 478)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents I3 As System.Windows.Forms.CheckBox
    Friend WithEvents Apu As System.Windows.Forms.CheckBox
    Friend WithEvents R5 As System.Windows.Forms.CheckBox
    Friend WithEvents I5 As System.Windows.Forms.CheckBox
    Friend WithEvents R7 As System.Windows.Forms.CheckBox
    Friend WithEvents I7 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Asus_Ryzen As System.Windows.Forms.CheckBox
    Friend WithEvents Asus_Intel As System.Windows.Forms.CheckBox
    Friend WithEvents Asus_Apu As System.Windows.Forms.CheckBox
    Friend WithEvents MSI_Intel As System.Windows.Forms.CheckBox
    Friend WithEvents Corsair As System.Windows.Forms.CheckBox
    Friend WithEvents Kingston As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ram_amount As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents WestBlue As System.Windows.Forms.CheckBox
    Friend WithEvents WestBlack As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents disco_final As System.Windows.Forms.Label
    Friend WithEvents ram_amount_final As System.Windows.Forms.Label
    Friend WithEvents ram_final As System.Windows.Forms.Label
    Friend WithEvents mother_final As System.Windows.Forms.Label
    Friend WithEvents cpu_final As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Reiniciar As System.Windows.Forms.Button
    Friend WithEvents Comprar As System.Windows.Forms.Button
    Friend WithEvents total_perif As System.Windows.Forms.Label
    Friend WithEvents Kit As System.Windows.Forms.CheckBox
    Friend WithEvents Samsung As System.Windows.Forms.CheckBox
    Friend WithEvents Pen As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Cargar As System.Windows.Forms.Button
    Friend WithEvents Borrar As System.Windows.Forms.Button

End Class
