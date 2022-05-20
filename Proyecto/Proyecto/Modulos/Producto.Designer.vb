<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.txtfechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.cbocategoria = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(194, 63)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(64, 20)
        Me.txtid.TabIndex = 35
        Me.txtid.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(150, 305)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 30)
        Me.btnsalir.TabIndex = 34
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(41, 305)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 30)
        Me.btnaceptar.TabIndex = 33
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'txtfechavencimiento
        '
        Me.txtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechavencimiento.Location = New System.Drawing.Point(21, 270)
        Me.txtfechavencimiento.Name = "txtfechavencimiento"
        Me.txtfechavencimiento.Size = New System.Drawing.Size(108, 20)
        Me.txtfechavencimiento.TabIndex = 32
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(21, 231)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(78, 20)
        Me.txtprecioventa.TabIndex = 31
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.Location = New System.Drawing.Point(23, 192)
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(76, 20)
        Me.txtpreciocompra.TabIndex = 30
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(23, 153)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(63, 20)
        Me.txtstock.TabIndex = 29
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(23, 102)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(165, 32)
        Me.txtdescripcion.TabIndex = 28
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(23, 63)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(165, 20)
        Me.txtnombre.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Fecha Vencimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Precio Venta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Precio Compra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Categoria:"
        '
        'btnCategoria
        '
        Me.btnCategoria.Location = New System.Drawing.Point(150, 23)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(108, 21)
        Me.btnCategoria.TabIndex = 19
        Me.btnCategoria.Text = "Categoria"
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'cbocategoria
        '
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(23, 23)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbocategoria.TabIndex = 18
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(277, 343)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtfechavencimiento)
        Me.Controls.Add(Me.txtprecioventa)
        Me.Controls.Add(Me.txtpreciocompra)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCategoria)
        Me.Controls.Add(Me.cbocategoria)
        Me.Name = "Producto"
        Me.Text = "Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents txtfechavencimiento As DateTimePicker
    Friend WithEvents txtprecioventa As TextBox
    Friend WithEvents txtpreciocompra As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCategoria As Button
    Friend WithEvents cbocategoria As ComboBox
End Class
