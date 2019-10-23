Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data



Public Class ConexionDA

    Public Shared cn

    Public Function Abrir() As SqlConnection
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        'Dim con As String
        ' con = "Data Source=EQUIPO007608\SQLEXPRESS;Initial Catalog=JoyeriaCrisol;Integrated Security=True"
        'con = "Data Source= DESKTOP-J1N9KFO\SQLEXPRESS;Initial Catalog=JoyeriaCrisol;Integrated Security=True"
        'con = "Data Source= DESKTOP-PDNSPVO\LOCAL;Initial Catalog=JoyeriaCrisol5;Integrated Security=True"
        ' con = "Data Source= I73770-PEDRO\LOCALDB;Initial Catalog=JoyeriaCrisol;Integrated Security=True"

        cn.Open()
        Return cn
    End Function



End Class
