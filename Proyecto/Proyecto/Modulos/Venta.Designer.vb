<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.lblidproducto = New System.Windows.Forms.Label()
        Me.listado = New System.Windows.Forms.DataGridView()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.btnbuscarP = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.gbcliente = New System.Windows.Forms.GroupBox()
        Me.lblidcliente = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtdoc = New System.Windows.Forms.TextBox()
        Me.btnbuscarC = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbempleado = New System.Windows.Forms.GroupBox()
        Me.lblidempleado = New System.Windows.Forms.Label()
        Me.btnbuscarE = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnya = New System.Windows.Forms.TextBox()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.lblnrodoc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbotipodocumento = New System.Windows.Forms.ComboBox()
        CType(Me.listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcliente.SuspendLayout()
        Me.gbempleado.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblidproducto
        '
        Me.lblidproducto.AutoSize = True
        Me.lblidproducto.Location = New System.Drawing.Point(325, 232)
        Me.lblidproducto.Name = "lblidproducto"
        Me.lblidproducto.Size = New System.Drawing.Size(13, 13)
        Me.lblidproducto.TabIndex = 25
        Me.lblidproducto.Text = "0"
        Me.lblidproducto.Visible = False
        '
        'listado
        '
        Me.listado.AllowUserToAddRows = False
        Me.listado.AllowUserToDeleteRows = False
        Me.listado.AllowUserToResizeColumns = False
        Me.listado.AllowUserToResizeRows = False
        Me.listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listado.Location = New System.Drawing.Point(12, 341)
        Me.listado.MultiSelect = False
        Me.listado.Name = "listado"
        Me.listado.ReadOnly = True
        Me.listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listado.Size = New System.Drawing.Size(476, 163)
        Me.listado.TabIndex = 24
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(375, 99)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(106, 20)
        Me.txtidventa.TabIndex = 23
        Me.txtidventa.Text = "0"
        Me.txtidventa.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnagregar)
        Me.GroupBox5.Controls.Add(Me.txtcantidad)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtprecio)
        Me.GroupBox5.Controls.Add(Me.txtstock)
        Me.GroupBox5.Controls.Add(Me.btnbuscarP)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtdescripcion)
        Me.GroupBox5.Controls.Add(Me.txtproducto)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(476, 84)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Producto"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(352, 49)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(118, 23)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(307, 51)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(39, 20)
        Me.txtcantidad.TabIndex = 11
        Me.txtcantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(249, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cantidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(102, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Precio Venta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Stock:"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(176, 51)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(64, 20)
        Me.txtprecio.TabIndex = 6
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(47, 51)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = True
        Me.txtstock.Size = New System.Drawing.Size(49, 20)
        Me.txtstock.TabIndex = 5
        '
        'btnbuscarP
        '
        Me.btnbuscarP.Location = New System.Drawing.Point(416, 17)
        Me.btnbuscarP.Name = "btnbuscarP"
        Me.btnbuscarP.Size = New System.Drawing.Size(53, 23)
        Me.btnbuscarP.TabIndex = 4
        Me.btnbuscarP.Text = "Buscar"
        Me.btnbuscarP.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Descripcion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Producto:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(234, 19)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(176, 20)
        Me.txtdescripcion.TabIndex = 1
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(61, 19)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtproducto.TabIndex = 0
        '
        'gbcliente
        '
        Me.gbcliente.Controls.Add(Me.lblidcliente)
        Me.gbcliente.Controls.Add(Me.txtcliente)
        Me.gbcliente.Controls.Add(Me.txtdoc)
        Me.gbcliente.Controls.Add(Me.btnbuscarC)
        Me.gbcliente.Controls.Add(Me.Label7)
        Me.gbcliente.Controls.Add(Me.Label6)
        Me.gbcliente.Location = New System.Drawing.Point(12, 162)
        Me.gbcliente.Name = "gbcliente"
        Me.gbcliente.Size = New System.Drawing.Size(307, 83)
        Me.gbcliente.TabIndex = 20
        Me.gbcliente.TabStop = False
        Me.gbcliente.Text = "Cliente"
        '
        'lblidcliente
        '
        Me.lblidcliente.AutoSize = True
        Me.lblidcliente.Location = New System.Drawing.Point(276, 24)
        Me.lblidcliente.Name = "lblidcliente"
        Me.lblidcliente.Size = New System.Drawing.Size(13, 13)
        Me.lblidcliente.TabIndex = 4
        Me.lblidcliente.Text = "0"
        Me.lblidcliente.Visible = False
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(92, 49)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = True
        Me.txtcliente.Size = New System.Drawing.Size(209, 20)
        Me.txtcliente.TabIndex = 4
        '
        'txtdoc
        '
        Me.txtdoc.Location = New System.Drawing.Point(92, 21)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.ReadOnly = True
        Me.txtdoc.Size = New System.Drawing.Size(100, 20)
        Me.txtdoc.TabIndex = 3
        '
        'btnbuscarC
        '
        Me.btnbuscarC.Location = New System.Drawing.Point(198, 19)
        Me.btnbuscarC.Name = "btnbuscarC"
        Me.btnbuscarC.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarC.TabIndex = 2
        Me.btnbuscarC.Text = "Buscar"
        Me.btnbuscarC.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cliente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Doc. Identidad:"
        '
        'gbempleado
        '
        Me.gbempleado.Controls.Add(Me.lblidempleado)
        Me.gbempleado.Controls.Add(Me.btnbuscarE)
        Me.gbempleado.Controls.Add(Me.Label5)
        Me.gbempleado.Controls.Add(Me.Label4)
        Me.gbempleado.Controls.Add(Me.txtnya)
        Me.gbempleado.Controls.Add(Me.txtcargo)
        Me.gbempleado.Location = New System.Drawing.Point(12, 80)
        Me.gbempleado.Name = "gbempleado"
        Me.gbempleado.Size = New System.Drawing.Size(307, 76)
        Me.gbempleado.TabIndex = 21
        Me.gbempleado.TabStop = False
        Me.gbempleado.Text = "Empleado"
        '
        'lblidempleado
        '
        Me.lblidempleado.AutoSize = True
        Me.lblidempleado.Location = New System.Drawing.Point(262, 22)
        Me.lblidempleado.Name = "lblidempleado"
        Me.lblidempleado.Size = New System.Drawing.Size(13, 13)
        Me.lblidempleado.TabIndex = 4
        Me.lblidempleado.Text = "0"
        Me.lblidempleado.Visible = False
        '
        'btnbuscarE
        '
        Me.btnbuscarE.Location = New System.Drawing.Point(183, 17)
        Me.btnbuscarE.Name = "btnbuscarE"
        Me.btnbuscarE.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarE.TabIndex = 3
        Me.btnbuscarE.Text = "Buscar"
        Me.btnbuscarE.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Empleado(a):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cargo:"
        '
        'txtnya
        '
        Me.txtnya.Location = New System.Drawing.Point(77, 45)
        Me.txtnya.Name = "txtnya"
        Me.txtnya.ReadOnly = True
        Me.txtnya.Size = New System.Drawing.Size(224, 20)
        Me.txtnya.TabIndex = 1
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(77, 19)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.ReadOnly = True
        Me.txtcargo.Size = New System.Drawing.Size(100, 20)
        Me.txtcargo.TabIndex = 0
        '
        'lblnrodoc
        '
        Me.lblnrodoc.AutoSize = True
        Me.lblnrodoc.BackColor = System.Drawing.Color.White
        Me.lblnrodoc.Location = New System.Drawing.Point(418, 70)
        Me.lblnrodoc.Name = "lblnrodoc"
        Me.lblnrodoc.Size = New System.Drawing.Size(13, 13)
        Me.lblnrodoc.TabIndex = 19
        Me.lblnrodoc.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(373, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NRO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(373, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Boleta de Venta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(373, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "R. U. C. 20103129061"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtfecha)
        Me.GroupBox2.Location = New System.Drawing.Point(148, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 50)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha de Venta"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(15, 16)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(127, 20)
        Me.txtfecha.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbotipodocumento)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 50)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Documento"
        '
        'cbotipodocumento
        '
        Me.cbotipodocumento.FormattingEnabled = True
        Me.cbotipodocumento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cbotipodocumento.Location = New System.Drawing.Point(6, 19)
        Me.cbotipodocumento.Name = "cbotipodocumento"
        Me.cbotipodocumento.Size = New System.Drawing.Size(113, 21)
        Me.cbotipodocumento.TabIndex = 0
        Me.cbotipodocumento.Text = "Boleta"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(505, 563)
        Me.Controls.Add(Me.lblidproducto)
        Me.Controls.Add(Me.listado)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gbcliente)
        Me.Controls.Add(Me.gbempleado)
        Me.Controls.Add(Me.lblnrodoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Venta"
        Me.Text = "Venta"
        CType(Me.listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcliente.ResumeLayout(False)
        Me.gbcliente.PerformLayout()
        Me.gbempleado.ResumeLayout(False)
        Me.gbempleado.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblidproducto As Label
    Friend WithEvents listado As DataGridView
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnagregar As Button
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents btnbuscarP As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents gbcliente As GroupBox
    Friend WithEvents lblidcliente As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents txtdoc As TextBox
    Friend WithEvents btnbuscarC As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbempleado As GroupBox
    Friend WithEvents lblidempleado As Label
    Friend WithEvents btnbuscarE As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnya As TextBox
    Friend WithEvents txtcargo As TextBox
    Friend WithEvents lblnrodoc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbotipodocumento As ComboBox
End Class
