<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cboestado = New System.Windows.Forms.ComboBox()
        Me.cboestadocivil = New System.Windows.Forms.ComboBox()
        Me.txtfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.cbosexo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbocargo = New System.Windows.Forms.ComboBox()
        Me.btncargo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(134, 141)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(75, 20)
        Me.txtid.TabIndex = 41
        Me.txtid.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(123, 370)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(33, 370)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboestado
        '
        Me.cboestado.FormattingEnabled = True
        Me.cboestado.Items.AddRange(New Object() {"Activo", "No Activo"})
        Me.cboestado.Location = New System.Drawing.Point(12, 338)
        Me.cboestado.Name = "cboestado"
        Me.cboestado.Size = New System.Drawing.Size(121, 21)
        Me.cboestado.TabIndex = 38
        Me.cboestado.Text = "Activo"
        '
        'cboestadocivil
        '
        Me.cboestadocivil.FormattingEnabled = True
        Me.cboestadocivil.Items.AddRange(New Object() {"Casado(a)", "Soltero(a)", "Viudo(a)"})
        Me.cboestadocivil.Location = New System.Drawing.Point(12, 298)
        Me.cboestadocivil.Name = "cboestadocivil"
        Me.cboestadocivil.Size = New System.Drawing.Size(121, 21)
        Me.cboestadocivil.TabIndex = 37
        Me.cboestadocivil.Text = "Soltero(a)"
        '
        'txtfechanacimiento
        '
        Me.txtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechanacimiento.Location = New System.Drawing.Point(15, 220)
        Me.txtfechanacimiento.Name = "txtfechanacimiento"
        Me.txtfechanacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtfechanacimiento.TabIndex = 36
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(12, 259)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(197, 20)
        Me.txtdireccion.TabIndex = 35
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(15, 181)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 34
        '
        'cbosexo
        '
        Me.cbosexo.FormattingEnabled = True
        Me.cbosexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbosexo.Location = New System.Drawing.Point(12, 141)
        Me.cbosexo.Name = "cbosexo"
        Me.cbosexo.Size = New System.Drawing.Size(103, 21)
        Me.cbosexo.TabIndex = 33
        Me.cbosexo.Text = "Masculino"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Estado Civil:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Fecha Nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Dni:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Sexo:"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(12, 102)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(197, 20)
        Me.txtapellido.TabIndex = 26
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(12, 63)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(197, 20)
        Me.txtnombre.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Apellidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cargo:"
        '
        'cbocargo
        '
        Me.cbocargo.FormattingEnabled = True
        Me.cbocargo.Location = New System.Drawing.Point(12, 23)
        Me.cbocargo.Name = "cbocargo"
        Me.cbocargo.Size = New System.Drawing.Size(129, 21)
        Me.cbocargo.TabIndex = 21
        '
        'btncargo
        '
        Me.btncargo.Location = New System.Drawing.Point(147, 21)
        Me.btncargo.Name = "btncargo"
        Me.btncargo.Size = New System.Drawing.Size(62, 23)
        Me.btncargo.TabIndex = 20
        Me.btncargo.Text = "Cargo"
        Me.btncargo.UseVisualStyleBackColor = True
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(221, 400)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cboestado)
        Me.Controls.Add(Me.cboestadocivil)
        Me.Controls.Add(Me.txtfechanacimiento)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.cbosexo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbocargo)
        Me.Controls.Add(Me.btncargo)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cboestado As ComboBox
    Friend WithEvents cboestadocivil As ComboBox
    Friend WithEvents txtfechanacimiento As DateTimePicker
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents cbosexo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbocargo As ComboBox
    Friend WithEvents btncargo As Button
End Class
