Imports System.Data.SqlClient
Public Class Ventas
    Private Sub FListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarVenta()
    End Sub
    Dim valores As New LDetalleVenta
    Dim funciones As New DVenta
    Dim vista As New DataView


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Sub MostrarVenta()
        vista = funciones.MostrarVenta.DefaultView


        Listado.DataSource = funciones.MostrarVenta
        Listado.DataSource = vista

        Listado.BackgroundColor = Color.FromArgb(188, 216, 52)
        Listado.Columns(0).Visible = False
        Listado.ClearSelection()
    End Sub
End Class