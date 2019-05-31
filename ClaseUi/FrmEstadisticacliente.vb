
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn

Public Class FrmEstadisticacliente

    Dim fechadesde As String
    Dim fechahasta As String
    Dim ChartArea1 As ChartArea = New ChartArea()
    Dim Legend1 As Legend = New Legend()
    Dim Series1 As Series = New Series()
    Private clientemetodo As New ClientesLN



    Private Sub FrmEstadisticacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbFiltro.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbFiltro.Visible = True
        fechadesde = Format(dtpdesde.Value, "yyyy/MM/dd")
        fechahasta = Format(dtphasta.Value, "yyyy/MM/dd")

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        GeneraGrafico()



        ' Chart1.DataSource = ds.Tables("Products")


    End Sub



    Public Sub GeneraGrafico()
        Try
            Dim ds1 As DataSet
            ds1 = clientemetodo.GeneraGrafico(fechadesde, fechahasta)
            Chart1.DataSource = ds1.Tables(0)
            Chart1.Series("Series1").XValueMember = "nombre"
            Chart1.Series("Series1").YValueMembers = "Cantidad"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class