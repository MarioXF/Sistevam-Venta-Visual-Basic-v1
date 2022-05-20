Public Class Clientes
    Dim valores As New LCliente
    Dim funciones As New DCliente
    Dim vista As New DataView
    Private Sub FListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarcliente()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New Cliente
        ventana.ShowDialog()
        mostrarcliente()

    End Sub
    Public Sub mostrarcliente()
        vista = funciones.MostrarClientes.DefaultView

        Listado.DataSource = funciones.MostrarClientes
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.ClearSelection()
    End Sub
End Class