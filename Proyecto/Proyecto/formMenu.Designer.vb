<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMenu))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconSalir = New FontAwesome.Sharp.IconButton()
        Me.IconProveedor = New FontAwesome.Sharp.IconButton()
        Me.IconClientes = New FontAwesome.Sharp.IconButton()
        Me.IconEmpleados = New FontAwesome.Sharp.IconButton()
        Me.IconReportes = New FontAwesome.Sharp.IconButton()
        Me.IconBonificacion = New FontAwesome.Sharp.IconButton()
        Me.IconProducto = New FontAwesome.Sharp.IconButton()
        Me.IconVenta = New FontAwesome.Sharp.IconButton()
        Me.IconInicio = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LogoEmpresa = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.IconName = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelModulos = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.LogoEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconSalir)
        Me.PanelMenu.Controls.Add(Me.IconProveedor)
        Me.PanelMenu.Controls.Add(Me.IconClientes)
        Me.PanelMenu.Controls.Add(Me.IconEmpleados)
        Me.PanelMenu.Controls.Add(Me.IconReportes)
        Me.PanelMenu.Controls.Add(Me.IconBonificacion)
        Me.PanelMenu.Controls.Add(Me.IconProducto)
        Me.PanelMenu.Controls.Add(Me.IconVenta)
        Me.PanelMenu.Controls.Add(Me.IconInicio)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 550)
        Me.PanelMenu.TabIndex = 0
        '
        'IconSalir
        '
        Me.IconSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconSalir.FlatAppearance.BorderSize = 0
        Me.IconSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconSalir.ForeColor = System.Drawing.Color.White
        Me.IconSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconSalir.IconColor = System.Drawing.Color.White
        Me.IconSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconSalir.Location = New System.Drawing.Point(0, 412)
        Me.IconSalir.Name = "IconSalir"
        Me.IconSalir.Size = New System.Drawing.Size(200, 39)
        Me.IconSalir.TabIndex = 9
        Me.IconSalir.Text = "Salir"
        Me.IconSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconSalir.UseVisualStyleBackColor = True
        '
        'IconProveedor
        '
        Me.IconProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconProveedor.FlatAppearance.BorderSize = 0
        Me.IconProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconProveedor.ForeColor = System.Drawing.Color.White
        Me.IconProveedor.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
        Me.IconProveedor.IconColor = System.Drawing.Color.White
        Me.IconProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconProveedor.Location = New System.Drawing.Point(0, 373)
        Me.IconProveedor.Name = "IconProveedor"
        Me.IconProveedor.Size = New System.Drawing.Size(200, 39)
        Me.IconProveedor.TabIndex = 8
        Me.IconProveedor.Text = "Proveedores"
        Me.IconProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconProveedor.UseVisualStyleBackColor = True
        '
        'IconClientes
        '
        Me.IconClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconClientes.FlatAppearance.BorderSize = 0
        Me.IconClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconClientes.ForeColor = System.Drawing.Color.White
        Me.IconClientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.IconClientes.IconColor = System.Drawing.Color.White
        Me.IconClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconClientes.Location = New System.Drawing.Point(0, 334)
        Me.IconClientes.Name = "IconClientes"
        Me.IconClientes.Size = New System.Drawing.Size(200, 39)
        Me.IconClientes.TabIndex = 7
        Me.IconClientes.Text = "Clientes"
        Me.IconClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconClientes.UseVisualStyleBackColor = True
        '
        'IconEmpleados
        '
        Me.IconEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconEmpleados.FlatAppearance.BorderSize = 0
        Me.IconEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconEmpleados.ForeColor = System.Drawing.Color.White
        Me.IconEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.IconEmpleados.IconColor = System.Drawing.Color.White
        Me.IconEmpleados.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconEmpleados.Location = New System.Drawing.Point(0, 295)
        Me.IconEmpleados.Name = "IconEmpleados"
        Me.IconEmpleados.Size = New System.Drawing.Size(200, 39)
        Me.IconEmpleados.TabIndex = 6
        Me.IconEmpleados.Text = "Empleados"
        Me.IconEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconEmpleados.UseVisualStyleBackColor = True
        '
        'IconReportes
        '
        Me.IconReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconReportes.FlatAppearance.BorderSize = 0
        Me.IconReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconReportes.ForeColor = System.Drawing.Color.White
        Me.IconReportes.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.IconReportes.IconColor = System.Drawing.Color.White
        Me.IconReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconReportes.Location = New System.Drawing.Point(0, 256)
        Me.IconReportes.Name = "IconReportes"
        Me.IconReportes.Size = New System.Drawing.Size(200, 39)
        Me.IconReportes.TabIndex = 5
        Me.IconReportes.Text = "Reportes"
        Me.IconReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconReportes.UseVisualStyleBackColor = True
        '
        'IconBonificacion
        '
        Me.IconBonificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconBonificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBonificacion.FlatAppearance.BorderSize = 0
        Me.IconBonificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBonificacion.ForeColor = System.Drawing.Color.White
        Me.IconBonificacion.IconChar = FontAwesome.Sharp.IconChar.Gift
        Me.IconBonificacion.IconColor = System.Drawing.Color.White
        Me.IconBonificacion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBonificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBonificacion.Location = New System.Drawing.Point(0, 217)
        Me.IconBonificacion.Name = "IconBonificacion"
        Me.IconBonificacion.Size = New System.Drawing.Size(200, 39)
        Me.IconBonificacion.TabIndex = 4
        Me.IconBonificacion.Text = "Bonificaciones"
        Me.IconBonificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconBonificacion.UseVisualStyleBackColor = True
        '
        'IconProducto
        '
        Me.IconProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconProducto.FlatAppearance.BorderSize = 0
        Me.IconProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconProducto.ForeColor = System.Drawing.Color.White
        Me.IconProducto.IconChar = FontAwesome.Sharp.IconChar.Shopify
        Me.IconProducto.IconColor = System.Drawing.Color.White
        Me.IconProducto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconProducto.Location = New System.Drawing.Point(0, 178)
        Me.IconProducto.Name = "IconProducto"
        Me.IconProducto.Size = New System.Drawing.Size(200, 39)
        Me.IconProducto.TabIndex = 3
        Me.IconProducto.Text = "Productos"
        Me.IconProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconProducto.UseVisualStyleBackColor = True
        '
        'IconVenta
        '
        Me.IconVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconVenta.FlatAppearance.BorderSize = 0
        Me.IconVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconVenta.ForeColor = System.Drawing.Color.White
        Me.IconVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.IconVenta.IconColor = System.Drawing.Color.White
        Me.IconVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconVenta.Location = New System.Drawing.Point(0, 139)
        Me.IconVenta.Name = "IconVenta"
        Me.IconVenta.Size = New System.Drawing.Size(200, 39)
        Me.IconVenta.TabIndex = 2
        Me.IconVenta.Text = "Ventas"
        Me.IconVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconVenta.UseVisualStyleBackColor = True
        '
        'IconInicio
        '
        Me.IconInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconInicio.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.IconInicio.FlatAppearance.BorderSize = 0
        Me.IconInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconInicio.ForeColor = System.Drawing.Color.White
        Me.IconInicio.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconInicio.IconColor = System.Drawing.Color.White
        Me.IconInicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconInicio.Location = New System.Drawing.Point(0, 100)
        Me.IconInicio.Name = "IconInicio"
        Me.IconInicio.Size = New System.Drawing.Size(200, 39)
        Me.IconInicio.TabIndex = 1
        Me.IconInicio.Text = "Inicio"
        Me.IconInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconInicio.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.LogoEmpresa)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 100)
        Me.PanelLogo.TabIndex = 0
        '
        'LogoEmpresa
        '
        Me.LogoEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogoEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoEmpresa.Image = CType(resources.GetObject("LogoEmpresa.Image"), System.Drawing.Image)
        Me.LogoEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.LogoEmpresa.Name = "LogoEmpresa"
        Me.LogoEmpresa.Size = New System.Drawing.Size(200, 100)
        Me.LogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoEmpresa.TabIndex = 0
        Me.LogoEmpresa.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelName)
        Me.Panel1.Controls.Add(Me.IconName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 1
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(107, 40)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(97, 20)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Bienvenido"
        '
        'IconName
        '
        Me.IconName.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconName.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.IconName.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconName.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconName.IconSize = 52
        Me.IconName.Location = New System.Drawing.Point(23, 22)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(57, 52)
        Me.IconName.TabIndex = 0
        Me.IconName.TabStop = False
        '
        'PanelModulos
        '
        Me.PanelModulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelModulos.Location = New System.Drawing.Point(200, 100)
        Me.PanelModulos.Name = "PanelModulos"
        Me.PanelModulos.Size = New System.Drawing.Size(800, 489)
        Me.PanelModulos.TabIndex = 2
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 550)
        Me.Controls.Add(Me.PanelModulos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "formMenu"
        Me.Text = "Home"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.LogoEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents IconInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LogoEmpresa As PictureBox
    Friend WithEvents IconVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconProducto As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBonificacion As FontAwesome.Sharp.IconButton
    Friend WithEvents IconReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents IconEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelName As Label
    Friend WithEvents IconName As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents IconProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents IconSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelModulos As Panel
End Class
