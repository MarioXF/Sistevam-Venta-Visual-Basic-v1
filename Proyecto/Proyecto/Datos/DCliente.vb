Imports System.Data.SqlClient
Public Class DCliente
    Inherits dConexion
    Public Function MostrarClientes() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarCliente", con)
            Dim tablaclientes As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)


            If cmd.ExecuteNonQuery Then
                adaptador.Fill(tablaclientes)
                Return tablaclientes
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
