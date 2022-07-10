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
        Me.Combolocalidad = New System.Windows.Forms.ComboBox()
        Me.Combosucursal = New System.Windows.Forms.ComboBox()
        Me.Combopais = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnañadir = New System.Windows.Forms.Button()
        Me.Comboconsulta = New System.Windows.Forms.ComboBox()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.Btnconsultar = New System.Windows.Forms.Button()
        Me.Outputlocalidad = New System.Windows.Forms.TextBox()
        Me.Outputsucursal = New System.Windows.Forms.TextBox()
        Me.Outputpais = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Outputcount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Inputprov = New System.Windows.Forms.TextBox()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnrestart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Proveedor"
        '
        'Combolocalidad
        '
        Me.Combolocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combolocalidad.FormattingEnabled = True
        Me.Combolocalidad.Items.AddRange(New Object() {"San Telmo", "San Justo", "Santa Teresita", "Barracas", "Izeiza", "Ituzaingo", "Rio De Jainero", "El Alto (Bol)", "Asunción"})
        Me.Combolocalidad.Location = New System.Drawing.Point(189, 143)
        Me.Combolocalidad.Name = "Combolocalidad"
        Me.Combolocalidad.Size = New System.Drawing.Size(183, 28)
        Me.Combolocalidad.TabIndex = 4
        '
        'Combosucursal
        '
        Me.Combosucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combosucursal.FormattingEnabled = True
        Me.Combosucursal.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Combosucursal.Location = New System.Drawing.Point(189, 203)
        Me.Combosucursal.Name = "Combosucursal"
        Me.Combosucursal.Size = New System.Drawing.Size(183, 28)
        Me.Combosucursal.TabIndex = 5
        '
        'Combopais
        '
        Me.Combopais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combopais.FormattingEnabled = True
        Me.Combopais.Items.AddRange(New Object() {"Argentina", "Brasil", "Bolivia", "Paraguay"})
        Me.Combopais.Location = New System.Drawing.Point(189, 262)
        Me.Combopais.Name = "Combopais"
        Me.Combopais.Size = New System.Drawing.Size(183, 28)
        Me.Combopais.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "País"
        '
        'Btnañadir
        '
        Me.Btnañadir.BackColor = System.Drawing.Color.Lime
        Me.Btnañadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnañadir.ForeColor = System.Drawing.Color.Transparent
        Me.Btnañadir.Location = New System.Drawing.Point(219, 339)
        Me.Btnañadir.Name = "Btnañadir"
        Me.Btnañadir.Size = New System.Drawing.Size(120, 40)
        Me.Btnañadir.TabIndex = 10
        Me.Btnañadir.Text = "Añadir"
        Me.Btnañadir.UseVisualStyleBackColor = False
        '
        'Comboconsulta
        '
        Me.Comboconsulta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Comboconsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comboconsulta.FormattingEnabled = True
        Me.Comboconsulta.Location = New System.Drawing.Point(446, 80)
        Me.Comboconsulta.Name = "Comboconsulta"
        Me.Comboconsulta.Size = New System.Drawing.Size(183, 34)
        Me.Comboconsulta.TabIndex = 11
        '
        'Btnborrar
        '
        Me.Btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnborrar.ForeColor = System.Drawing.Color.White
        Me.Btnborrar.Location = New System.Drawing.Point(475, 387)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(125, 40)
        Me.Btnborrar.TabIndex = 12
        Me.Btnborrar.Text = "Borrar"
        Me.Btnborrar.UseVisualStyleBackColor = False
        '
        'Btnconsultar
        '
        Me.Btnconsultar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconsultar.ForeColor = System.Drawing.Color.White
        Me.Btnconsultar.Location = New System.Drawing.Point(415, 339)
        Me.Btnconsultar.Name = "Btnconsultar"
        Me.Btnconsultar.Size = New System.Drawing.Size(120, 40)
        Me.Btnconsultar.TabIndex = 13
        Me.Btnconsultar.Text = "Consultar"
        Me.Btnconsultar.UseVisualStyleBackColor = False
        '
        'Outputlocalidad
        '
        Me.Outputlocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outputlocalidad.Location = New System.Drawing.Point(446, 143)
        Me.Outputlocalidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Outputlocalidad.Name = "Outputlocalidad"
        Me.Outputlocalidad.Size = New System.Drawing.Size(183, 33)
        Me.Outputlocalidad.TabIndex = 14
        '
        'Outputsucursal
        '
        Me.Outputsucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outputsucursal.Location = New System.Drawing.Point(446, 202)
        Me.Outputsucursal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Outputsucursal.Name = "Outputsucursal"
        Me.Outputsucursal.Size = New System.Drawing.Size(183, 33)
        Me.Outputsucursal.TabIndex = 15
        '
        'Outputpais
        '
        Me.Outputpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outputpais.Location = New System.Drawing.Point(446, 262)
        Me.Outputpais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Outputpais.Name = "Outputpais"
        Me.Outputpais.Size = New System.Drawing.Size(183, 33)
        Me.Outputpais.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Outputcount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(684, 82)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 218)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Outputcount
        '
        Me.Outputcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outputcount.Location = New System.Drawing.Point(48, 123)
        Me.Outputcount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Outputcount.Name = "Outputcount"
        Me.Outputcount.Size = New System.Drawing.Size(198, 33)
        Me.Outputcount.TabIndex = 18
        Me.Outputcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 26)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "De proveedores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cantidad"
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.BackColor = System.Drawing.Color.DarkGray
        Me.Btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.Btnlimpiar.Location = New System.Drawing.Point(543, 339)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(120, 40)
        Me.Btnlimpiar.TabIndex = 18
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = False
        '
        'Inputprov
        '
        Me.Inputprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inputprov.Location = New System.Drawing.Point(189, 80)
        Me.Inputprov.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Inputprov.Name = "Inputprov"
        Me.Inputprov.Size = New System.Drawing.Size(183, 33)
        Me.Inputprov.TabIndex = 19
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnexit.Location = New System.Drawing.Point(941, 24)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(40, 34)
        Me.Btnexit.TabIndex = 20
        Me.Btnexit.Text = "X"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Btnrestart
        '
        Me.Btnrestart.BackColor = System.Drawing.Color.Teal
        Me.Btnrestart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnrestart.Location = New System.Drawing.Point(895, 24)
        Me.Btnrestart.Name = "Btnrestart"
        Me.Btnrestart.Size = New System.Drawing.Size(40, 34)
        Me.Btnrestart.TabIndex = 21
        Me.Btnrestart.Text = " ↺"
        Me.Btnrestart.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 481)
        Me.Controls.Add(Me.Btnrestart)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Inputprov)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Outputpais)
        Me.Controls.Add(Me.Outputsucursal)
        Me.Controls.Add(Me.Outputlocalidad)
        Me.Controls.Add(Me.Btnconsultar)
        Me.Controls.Add(Me.Btnborrar)
        Me.Controls.Add(Me.Comboconsulta)
        Me.Controls.Add(Me.Btnañadir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Combopais)
        Me.Controls.Add(Me.Combosucursal)
        Me.Controls.Add(Me.Combolocalidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Combolocalidad As ComboBox
    Friend WithEvents Combosucursal As ComboBox
    Friend WithEvents Combopais As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnañadir As Button
    Friend WithEvents Comboconsulta As ComboBox
    Friend WithEvents Btnborrar As Button
    Friend WithEvents Btnconsultar As Button
    Friend WithEvents Outputlocalidad As TextBox
    Friend WithEvents Outputsucursal As TextBox
    Friend WithEvents Outputpais As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Outputcount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Inputprov As TextBox
    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnrestart As Button
End Class
