Imports System.Data.SqlClient
Public Class DCargo
    Inherits dConexion
    Public Function MostrarCargo() As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarCargo", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim tablacargo As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tablacargo)
                Return tablacargo
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
