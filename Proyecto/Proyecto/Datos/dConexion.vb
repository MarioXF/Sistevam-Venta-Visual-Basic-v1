Imports System.Data.SqlClient
Imports System.Configuration
Public Class dConexion

    Public con As SqlConnection = New SqlConnection(" data source=SHUMAQRUNAPC; initial catalog=datosventas; user id=sa; password=rupay968360732")
    Public Sub conectar()
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
