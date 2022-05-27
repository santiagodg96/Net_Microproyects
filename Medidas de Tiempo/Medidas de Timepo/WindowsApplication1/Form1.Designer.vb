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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Input = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckHor = New System.Windows.Forms.CheckBox()
        Me.CheckMin = New System.Windows.Forms.CheckBox()
        Me.CheckSeg = New System.Windows.Forms.CheckBox()
        Me.CheckMil = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckHor2 = New System.Windows.Forms.CheckBox()
        Me.CheckMin2 = New System.Windows.Forms.CheckBox()
        Me.CheckSeg2 = New System.Windows.Forms.CheckBox()
        Me.CheckMil2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Medida = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduzca su valor"
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(165, 35)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(94, 20)
        Me.Input.TabIndex = 2
        Me.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(205, 257)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(13, 13)
        Me.Resultado.TabIndex = 3
        Me.Resultado.Text = "0"
        Me.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calcular.Location = New System.Drawing.Point(173, 222)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckHor)
        Me.GroupBox1.Controls.Add(Me.CheckMin)
        Me.GroupBox1.Controls.Add(Me.CheckSeg)
        Me.GroupBox1.Controls.Add(Me.CheckMil)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 70)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿En que medida está expresado?"
        '
        'CheckHor
        '
        Me.CheckHor.AutoSize = True
        Me.CheckHor.Location = New System.Drawing.Point(229, 29)
        Me.CheckHor.Name = "CheckHor"
        Me.CheckHor.Size = New System.Drawing.Size(54, 17)
        Me.CheckHor.TabIndex = 3
        Me.CheckHor.Text = "Horas"
        Me.CheckHor.UseVisualStyleBackColor = True
        '
        'CheckMin
        '
        Me.CheckMin.AutoSize = True
        Me.CheckMin.Location = New System.Drawing.Point(170, 29)
        Me.CheckMin.Name = "CheckMin"
        Me.CheckMin.Size = New System.Drawing.Size(63, 17)
        Me.CheckMin.TabIndex = 2
        Me.CheckMin.Text = "Minutos"
        Me.CheckMin.UseVisualStyleBackColor = True
        '
        'CheckSeg
        '
        Me.CheckSeg.AutoSize = True
        Me.CheckSeg.Location = New System.Drawing.Point(99, 29)
        Me.CheckSeg.Name = "CheckSeg"
        Me.CheckSeg.Size = New System.Drawing.Size(74, 17)
        Me.CheckSeg.TabIndex = 1
        Me.CheckSeg.Text = "Segundos"
        Me.CheckSeg.UseVisualStyleBackColor = True
        '
        'CheckMil
        '
        Me.CheckMil.AutoSize = True
        Me.CheckMil.Location = New System.Drawing.Point(6, 29)
        Me.CheckMil.Name = "CheckMil"
        Me.CheckMil.Size = New System.Drawing.Size(87, 17)
        Me.CheckMil.TabIndex = 0
        Me.CheckMil.Text = "Milisegundos"
        Me.CheckMil.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckHor2)
        Me.GroupBox2.Controls.Add(Me.CheckMin2)
        Me.GroupBox2.Controls.Add(Me.CheckSeg2)
        Me.GroupBox2.Controls.Add(Me.CheckMil2)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 70)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "¿A que medida desea convertir?"
        '
        'CheckHor2
        '
        Me.CheckHor2.AutoSize = True
        Me.CheckHor2.Location = New System.Drawing.Point(229, 29)
        Me.CheckHor2.Name = "CheckHor2"
        Me.CheckHor2.Size = New System.Drawing.Size(54, 17)
        Me.CheckHor2.TabIndex = 3
        Me.CheckHor2.Text = "Horas"
        Me.CheckHor2.UseVisualStyleBackColor = True
        '
        'CheckMin2
        '
        Me.CheckMin2.AutoSize = True
        Me.CheckMin2.Location = New System.Drawing.Point(170, 29)
        Me.CheckMin2.Name = "CheckMin2"
        Me.CheckMin2.Size = New System.Drawing.Size(63, 17)
        Me.CheckMin2.TabIndex = 2
        Me.CheckMin2.Text = "Minutos"
        Me.CheckMin2.UseVisualStyleBackColor = True
        '
        'CheckSeg2
        '
        Me.CheckSeg2.AutoSize = True
        Me.CheckSeg2.Location = New System.Drawing.Point(93, 29)
        Me.CheckSeg2.Name = "CheckSeg2"
        Me.CheckSeg2.Size = New System.Drawing.Size(74, 17)
        Me.CheckSeg2.TabIndex = 1
        Me.CheckSeg2.Text = "Segundos"
        Me.CheckSeg2.UseVisualStyleBackColor = True
        '
        'CheckMil2
        '
        Me.CheckMil2.AutoSize = True
        Me.CheckMil2.Location = New System.Drawing.Point(6, 29)
        Me.CheckMil2.Name = "CheckMil2"
        Me.CheckMil2.Size = New System.Drawing.Size(87, 17)
        Me.CheckMil2.TabIndex = 0
        Me.CheckMil2.Text = "Milisegundos"
        Me.CheckMil2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Expresado en:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Resultado:"
        '
        'Medida
        '
        Me.Medida.AutoSize = True
        Me.Medida.Location = New System.Drawing.Point(205, 281)
        Me.Medida.Name = "Medida"
        Me.Medida.Size = New System.Drawing.Size(13, 13)
        Me.Medida.TabIndex = 10
        Me.Medida.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(426, 334)
        Me.Controls.Add(Me.Medida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents Resultado As System.Windows.Forms.Label
    Friend WithEvents Calcular As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckHor As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMin As System.Windows.Forms.CheckBox
    Friend WithEvents CheckSeg As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMil As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckHor2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMin2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckSeg2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMil2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Medida As System.Windows.Forms.Label

End Class
