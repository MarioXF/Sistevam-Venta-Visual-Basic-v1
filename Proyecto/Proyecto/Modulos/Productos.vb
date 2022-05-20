Imports System.Data.SqlClient
Public Class Productos
    Dim valores As New LProducto
    Dim funciones As New DProducto
    Dim vista As New DataView
    Private Sub FListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarproductos()
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New Producto
        ventana.ShowDialog()
        mostrarproductos()

    End Sub
    Public Sub mostrarproductos()
        vista = funciones.MostrarProductos.DefaultView

        Listado.DataSource = funciones.MostrarProductos
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.Columns(1).Visible = False
        Listado.ClearSelection()
    End Sub

End Class