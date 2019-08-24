Imports ClaseLn

Public Class FrmDetalleProductoCatalogo

    Dim productometodo As New ProductoLN
    Dim busqcod As String
    Dim busqprod As String



    Private Sub FrmDetalleProductoCatalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBCODIGO.Enabled = False
        TBCODIGOBARRA.Enabled = False
        TBNOMBREPROD.Enabled = False
        TBPRECIO.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
End Class