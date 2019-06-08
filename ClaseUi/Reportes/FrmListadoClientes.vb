Imports ClaseLn
Imports System.Windows.Forms


Public Class FrmListadoClientes


    Dim clienteid As Integer
    Dim fechadesde As String
    Dim fechahasta As String


    Dim contador As Integer
    Private clientemetodo As New ClientesLN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fechadesde = Format(dtpdesde.Value, "yyyy/MM/dd")
        fechahasta = Format(dtphasta.Value, "yyyy/MM/dd")
        controlfecha()

        If contador > 0 Then

            'Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.dslistadocliente.SP_ListadodeClientesPorfecha)
            Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.dslistadocliente.SP_ListadodeClientesPorfecha, CType(fechadesde, Date), CType(fechahasta, Date))
            Me.ReportViewer1.RefreshReport()
        Else

            MsgBox("No existe registro en ese intervalo de fechas", MsgBoxStyle.Critical, "Error")

        End If



    End Sub

    Public Sub controlfecha()

        clientemetodo.controlfecha(fechadesde, fechahasta)
        contador = clientemetodo.contador

    End Sub



    Private Sub FrmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpdesde.Format = DateTimePickerFormat.Custom
        dtpdesde.CustomFormat = " dd/MM/yyyy"
        dtphasta.Format = DateTimePickerFormat.Custom
        dtphasta.CustomFormat = " dd/MM/yyyy"

    End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

	End Sub

End Class