<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combosistema = New System.Windows.Forms.ComboBox()
        Me.comboaño = New System.Windows.Forms.ComboBox()
        Me.combopais = New System.Windows.Forms.ComboBox()
        Me.input = New System.Windows.Forms.TextBox()
        Me.validar = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.outputsistema = New System.Windows.Forms.TextBox()
        Me.outputaño = New System.Windows.Forms.TextBox()
        Me.outputpais = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combobusqueda = New System.Windows.Forms.ComboBox()
        Me.closeapp = New System.Windows.Forms.Button()
        Me.btncargar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.restartapp = New System.Windows.Forms.Button()
        Me.btnlimpiar2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pelicula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "País:"
        '
        'combosistema
        '
        Me.combosistema.FormattingEnabled = True
        Me.combosistema.Location = New System.Drawing.Point(156, 192)
        Me.combosistema.Name = "combosistema"
        Me.combosistema.Size = New System.Drawing.Size(164, 28)
        Me.combosistema.TabIndex = 4
        '
        'comboaño
        '
        Me.comboaño.FormattingEnabled = True
        Me.comboaño.Location = New System.Drawing.Point(156, 248)
        Me.comboaño.Name = "comboaño"
        Me.comboaño.Size = New System.Drawing.Size(164, 28)
        Me.comboaño.TabIndex = 5
        '
        'combopais
        '
        Me.combopais.FormattingEnabled = True
        Me.combopais.Location = New System.Drawing.Point(156, 302)
        Me.combopais.Name = "combopais"
        Me.combopais.Size = New System.Drawing.Size(164, 28)
        Me.combopais.TabIndex = 6
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(156, 78)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(164, 26)
        Me.input.TabIndex = 7
        '
        'validar
        '
        Me.validar.AutoSize = True
        Me.validar.Enabled = False
        Me.validar.Location = New System.Drawing.Point(326, 82)
        Me.validar.Name = "validar"
        Me.validar.Size = New System.Drawing.Size(22, 21)
        Me.validar.TabIndex = 8
        Me.validar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Por Cargar"
        '
        'outputsistema
        '
        Me.outputsistema.Location = New System.Drawing.Point(568, 197)
        Me.outputsistema.Name = "outputsistema"
        Me.outputsistema.Size = New System.Drawing.Size(164, 26)
        Me.outputsistema.TabIndex = 10
        '
        'outputaño
        '
        Me.outputaño.Location = New System.Drawing.Point(568, 251)
        Me.outputaño.Name = "outputaño"
        Me.outputaño.Size = New System.Drawing.Size(164, 26)
        Me.outputaño.TabIndex = 11
        '
        'outputpais
        '
        Me.outputpais.Location = New System.Drawing.Point(568, 306)
        Me.outputpais.Name = "outputpais"
        Me.outputpais.Size = New System.Drawing.Size(164, 26)
        Me.outputpais.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(548, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "En Base"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(394, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 29)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Buscar por Nombre:"
        '
        'combobusqueda
        '
        Me.combobusqueda.FormattingEnabled = True
        Me.combobusqueda.Location = New System.Drawing.Point(639, 78)
        Me.combobusqueda.MaxDropDownItems = 5
        Me.combobusqueda.Name = "combobusqueda"
        Me.combobusqueda.Size = New System.Drawing.Size(164, 28)
        Me.combobusqueda.TabIndex = 15
        '
        'closeapp
        '
        Me.closeapp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closeapp.Location = New System.Drawing.Point(756, 22)
        Me.closeapp.Name = "closeapp"
        Me.closeapp.Size = New System.Drawing.Size(46, 35)
        Me.closeapp.TabIndex = 16
        Me.closeapp.Text = "X"
        Me.closeapp.UseVisualStyleBackColor = False
        '
        'btncargar
        '
        Me.btncargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncargar.Location = New System.Drawing.Point(62, 372)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(112, 49)
        Me.btncargar.TabIndex = 17
        Me.btncargar.Text = "Cargar"
        Me.btncargar.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.Gray
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpiar.Location = New System.Drawing.Point(190, 372)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(112, 49)
        Me.btnlimpiar.TabIndex = 18
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnborrar.Location = New System.Drawing.Point(658, 372)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(118, 49)
        Me.btnborrar.TabIndex = 19
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'btnconsultar
        '
        Me.btnconsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnconsultar.Location = New System.Drawing.Point(400, 372)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(112, 49)
        Me.btnconsultar.TabIndex = 20
        Me.btnconsultar.Text = "Consulta"
        Me.btnconsultar.UseVisualStyleBackColor = False
        '
        'restartapp
        '
        Me.restartapp.BackColor = System.Drawing.Color.Teal
        Me.restartapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restartapp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.restartapp.Location = New System.Drawing.Point(704, 22)
        Me.restartapp.Name = "restartapp"
        Me.restartapp.Size = New System.Drawing.Size(46, 35)
        Me.restartapp.TabIndex = 21
        Me.restartapp.Text = " ↺"
        Me.restartapp.UseVisualStyleBackColor = False
        '
        'btnlimpiar2
        '
        Me.btnlimpiar2.BackColor = System.Drawing.Color.Gray
        Me.btnlimpiar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpiar2.Location = New System.Drawing.Point(530, 372)
        Me.btnlimpiar2.Name = "btnlimpiar2"
        Me.btnlimpiar2.Size = New System.Drawing.Size(112, 49)
        Me.btnlimpiar2.TabIndex = 22
        Me.btnlimpiar2.Text = "Limpiar"
        Me.btnlimpiar2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(426, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 29)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "País:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(426, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 29)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Año:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(426, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Calidad:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 508)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnlimpiar2)
        Me.Controls.Add(Me.restartapp)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.closeapp)
        Me.Controls.Add(Me.combobusqueda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.outputpais)
        Me.Controls.Add(Me.outputaño)
        Me.Controls.Add(Me.outputsistema)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.validar)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.combopais)
        Me.Controls.Add(Me.comboaño)
        Me.Controls.Add(Me.combosistema)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents combosistema As ComboBox
    Friend WithEvents comboaño As ComboBox
    Friend WithEvents combopais As ComboBox
    Friend WithEvents input As TextBox
    Friend WithEvents validar As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents outputsistema As TextBox
    Friend WithEvents outputaño As TextBox
    Friend WithEvents outputpais As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents combobusqueda As ComboBox
    Friend WithEvents closeapp As Button
    Friend WithEvents btncargar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnconsultar As Button
    Friend WithEvents restartapp As Button
    Friend WithEvents btnlimpiar2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
