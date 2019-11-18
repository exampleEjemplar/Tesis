Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn

Public Class FrmEstadisticaVentas

    Private Ventametodo As New VentasLN
    Dim fechadesde As String
    Dim fechahasta As String
    Dim contador As Integer


    Private Sub FrmEstadisticaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dtpdesde.Format = DateTimePickerFormat.Custom
        dtpdesde.CustomFormat = " dd/MM/yyyy"
        dtphasta.Format = DateTimePickerFormat.Custom
        dtphasta.CustomFormat = " dd/MM/yyyy"
        gbFiltro.Visible = False
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Chart3.Visible = True
        Chart2.Visible = False
        Chart1.Visible = False
        GeneraGraficofechaMes()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        'RadioButton3.Enabled = False
        'RadioButton2.Enabled = False
        ' RadioButton1.Enabled = False
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Chart1.Visible = True
        Chart2.Visible = False
        Chart3.Visible = False
        ' GeneraGraficoprovincia()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        'RadioButton3.Enabled = False
        'RadioButton2.Enabled = False
        'RadioButton1.Enabled = False
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Chart2.Visible = True
        Chart1.Visible = False
        Chart3.Visible = False
        'RadioButton3.Enabled = False
        'RadioButton2.Enabled = False
        ' RadioButton1.Enabled = False
        'GeneraGraficopersoneria()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
    End Sub


    Public Sub GeneraGraficofechaMes()
        Try
            Dim ds1 As DataSet
            ds1 = Ventametodo.GeneraGraficoCantVentasFecha(fechadesde, fechahasta)
            Chart1.DataSource = ds1.Tables(0)



            Dim Series1 As Series = Chart1.Series("Series2")
            Series1.Name = "Ventas"
            Chart1.Series(Series1.Name).XValueMember = "Mes"
            Chart1.Series(Series1.Name).YValueMembers = "Cantidad"

            Chart1.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fechadesde = Format(dtpdesde.Value, "yyyy/MM/dd")
        fechahasta = Format(dtphasta.Value.AddDays(1), "yyyy/MM/dd")
        controlfecha()

        If contador > 0 Then
            gbFiltro.Visible = True
        Else

            MsgBox("No existe registro en ese intervalo de fechas", MsgBoxStyle.Critical, "Error")

        End If

    End Sub

    Public Sub controlfecha()
        Ventametodo.Controlfecha(fechadesde, fechahasta)
        contador = Ventametodo.contador

    End Sub


End Class