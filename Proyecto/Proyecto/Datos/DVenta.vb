Imports System.Data.SqlClient
Public Class DVenta
    Inherits dConexion
    Public Function MostrarVenta() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarVenta", con)
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
