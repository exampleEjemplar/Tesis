Imports System.Data.SqlClient
Imports ClaseNE

Public Class ConexionDA

    Public Shared scon As New SqlConnection
    Public Function Abrir() As SqlConnection
        Dim con As String
		con = "Data Source= DESKTOP-PDNSPVO\LOCAL;Initial Catalog=JoyeriaCrisol6;Integrated Security=True"
		scon = New SqlConnection(con)
        scon.Open()
        Return scon
    End Function

    Public Shared Function Cerrar() As Boolean
        Try
            If scon.State = ConnectionState.Open Then
                scon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class
