Imports System.Data.SqlClient
Public Class Empleados
    Private Sub FListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarempleados()
    End Sub
    Dim valores As New LEmpleado
    Dim funciones As New DEmpleado
    Dim vista As New DataView





    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New Empleado
        ventana.ShowDialog()
        Me.mostrarempleados()
    End Sub
    Public Sub mostrarempleados()
        vista = funciones.MostrarEmpleado.DefaultView

        Listado.DataSource = funciones.MostrarEmpleado
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.Columns(1).Visible = False
        Listado.ClearSelection()
    End Sub
End Class