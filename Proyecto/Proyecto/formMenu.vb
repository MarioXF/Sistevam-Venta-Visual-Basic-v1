Imports FontAwesome.Sharp


Public Class formMenu
    Private btnActual As IconButton
    Private borderLeft As Panel
    Private currentChildForm As Form

    'Construtor
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        borderLeft = New Panel()
        borderLeft.Size = New Size(8, 39)
        PanelMenu.Controls.Add(borderLeft)

    End Sub

    'Accion de Clic al boton
    Public Sub ActivateButton(senderBtn As Object, customColor As Color)
        If (senderBtn IsNot Nothing) Then
            'boton nuevo
            DisableButton()
            btnActual = CType(senderBtn, IconButton)
            btnActual.BackColor = Color.FromArgb(227, 53, 36)
            btnActual.ForeColor = customColor
            btnActual.IconColor = customColor
            btnActual.TextAlign = ContentAlignment.MiddleLeft
            btnActual.ImageAlign = ContentAlignment.MiddleRight
            btnActual.TextImageRelation = TextImageRelation.TextBeforeImage
            'borden del boton dentro del panel
            borderLeft.BackColor = customColor
            borderLeft.Location = New Point(0, btnActual.Location.Y)
            borderLeft.Visible = True
            borderLeft.BringToFront()
            'icono a cambiar
            IconName.IconChar = btnActual.IconChar
            IconName.IconColor = customColor
            LabelName.Text = btnActual.Text


        End If


    End Sub

    'Descativar boton cuando se marque otro
    Public Sub DisableButton()
        If btnActual IsNot Nothing Then
            btnActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(52, Byte), Integer))
            btnActual.ForeColor = Color.White
            btnActual.IconColor = Color.White
            btnActual.TextAlign = ContentAlignment.MiddleRight
            btnActual.ImageAlign = ContentAlignment.MiddleLeft
            btnActual.TextImageRelation = TextImageRelation.Overlay
        End If
    End Sub

    'PanelModulos
    Private Sub OpenChillForm(panelModulo As Form)
        If (currentChildForm IsNot Nothing) Then
            currentChildForm.Close()

        End If
        currentChildForm = panelModulo
        panelModulo.TopLevel = False
        panelModulo.FormBorderStyle = FormBorderStyle.None
        panelModulo.Dock = DockStyle.Fill
        PanelModulos.Controls.Add(panelModulo)
        PanelModulos.Tag = panelModulo
        panelModulo.BringToFront()
        panelModulo.Show()

    End Sub
    Private Sub IconInicio_Click(sender As Object, e As EventArgs) Handles IconInicio.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Inicio)
    End Sub

    Private Sub IconVenta_Click(sender As Object, e As EventArgs) Handles IconVenta.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Ventas)
    End Sub

    Private Sub IconProducto_Click(sender As Object, e As EventArgs) Handles IconProducto.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Productos)
    End Sub

    Private Sub IconBonificacion_Click(sender As Object, e As EventArgs) Handles IconBonificacion.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Bonificaciones)
    End Sub

    Private Sub IconReportes_Click(sender As Object, e As EventArgs) Handles IconReportes.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Reportes)
    End Sub

    Private Sub IconEmpleados_Click(sender As Object, e As EventArgs) Handles IconEmpleados.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Empleados)
    End Sub

    Private Sub IconClientes_Click(sender As Object, e As EventArgs) Handles IconClientes.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Clientes)
    End Sub

    Private Sub IconProveedor_Click(sender As Object, e As EventArgs) Handles IconProveedor.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Proveedores)
    End Sub

    Private Sub IconSalir_Click_1(sender As Object, e As EventArgs) Handles IconSalir.Click
        ActivateButton(sender, Color.White)
        OpenChillForm(New Salir)
    End Sub
End Class
