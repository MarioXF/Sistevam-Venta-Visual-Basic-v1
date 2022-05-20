Imports System.Data.SqlClient
Public Class DProducto
    Inherits dConexion

    Public Function MostrarProductos() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarProductos", con)
            Dim tablaproductos As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)


            If cmd.ExecuteNonQuery Then
                adaptador.Fill(tablaproductos)
                Return tablaproductos
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
