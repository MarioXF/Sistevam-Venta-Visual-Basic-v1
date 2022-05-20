Imports System.Data.SqlClient
Public Class DEmpleado
    Inherits dConexion
    Public Function MostrarEmpleado() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarEmpleados", con)
            Dim tablaempleados As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)


            If cmd.ExecuteNonQuery Then
                adaptador.Fill(tablaempleados)
                Return tablaempleados
            Else
                Return Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class
