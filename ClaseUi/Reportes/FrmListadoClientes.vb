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
        fechahasta = Format(dtphasta.Value.AddDays(1), "yyyy/MM/dd")


        Controlfecha()

		If contador > 0 Then

			'Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.dslistadocliente.SP_ListadodeClientesPorfecha)

			Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.JoyeriaCrisol12DataSet.SP_ListadodeClientesPorfecha, CType(fechadesde, Date), CType(fechahasta, Date))

			Me.ReportViewer1.RefreshReport()
		Else

			MsgBox("No existe registro en ese intervalo de fechas", MsgBoxStyle.Critical, "Error")

		End If



	End Sub

	Public Sub Controlfecha()

		clientemetodo.Controlfecha(fechadesde, fechahasta)
		contador = clientemetodo.contador

	End Sub



	Private Sub FrmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: esta línea de código carga datos en la tabla 'JoyeriaCrisol11DataSet.SP_ListadodeClientesPorfecha' Puede moverla o quitarla según sea necesario.

		'TODO: esta línea de código carga datos en la tabla 'JoyeriaCrisol11DataSet.SP_ListadodeClientesPorfecha' Puede moverla o quitarla según sea necesario.

		dtpdesde.Format = DateTimePickerFormat.Custom
        dtpdesde.CustomFormat = " dd/MM/yyyy"
		dtphasta.Format = DateTimePickerFormat.Custom
		dtphasta.CustomFormat = " dd/MM/yyyy"

	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

	End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs)
		Me.Close()

	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Close()
	End Sub
End Class