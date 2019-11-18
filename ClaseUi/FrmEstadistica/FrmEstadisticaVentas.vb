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

        limpiar()


    End Sub
    Private Sub limpiar()

        dtpdesde.Format = DateTimePickerFormat.Custom
        dtpdesde.CustomFormat = " dd/MM/yyyy"
        dtphasta.Format = DateTimePickerFormat.Custom
        dtphasta.CustomFormat = " dd/MM/yyyy"
        gbFiltro.Visible = False
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False
        Chart4.Visible = False
        dtpdesde.Enabled = True
        dtphasta.Enabled = True
        Button1.Enabled = True


    End Sub
    Private Sub RadioButton1_click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Chart1.Visible = True
        Chart2.Visible = False
        Chart3.Visible = False
        GeneraGraficofechaMes()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Chart2.Visible = True
        Chart1.Visible = False
        Chart3.Visible = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        GeneraGraficoCantidadportipo()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        Button1.Enabled = False
    End Sub


    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = True
        GeneraGraficoCantidadporVendedor()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        Button1.Enabled = False

    End Sub

    Private Sub RadioButton4_click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False
        Chart4.Visible = True
        GeneraGraficoFacturacion()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        Button1.Enabled = False


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

    Public Sub GeneraGraficoCantidadportipo()
        Try
            Dim ds1 As DataSet
            ds1 = Ventametodo.GeneraGraficoCantidadportipo(fechadesde, fechahasta)
            Chart2.DataSource = ds1.Tables(0)



            Dim Series1 As Series = Chart2.Series("Series2")
            Series1.Name = "Ventas"
            Chart2.Series(Series1.Name).XValueMember = "Nombre"
            Chart2.Series(Series1.Name).YValueMembers = "Cantidad"

            Chart2.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub



    Public Sub GeneraGraficoCantidadporVendedor()
        Try
            Dim ds1 As DataSet
            ds1 = Ventametodo.GeneraGraficoCantidadVendedor(fechadesde, fechahasta)
            Chart3.DataSource = ds1.Tables(0)

            Dim Series1 As Series = Chart3.Series("Series2")
            Series1.Name = "Ventas"
            Chart3.Series(Series1.Name).XValueMember = "UserName"
            Chart3.Series(Series1.Name).YValueMembers = "Cantidad"

            Chart2.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GeneraGraficoFacturacion()
        Try
            Dim ds1 As DataSet
            ds1 = Ventametodo.GeneraGraficoFacturacionPorMes(fechadesde, fechahasta)
            Chart4.DataSource = ds1.Tables(0)

            Dim Series1 As Series = Chart4.Series("Series2")
            Series1.Name = "Ventas"
            Chart4.Series(Series1.Name).XValueMember = "Mes"
            Chart4.Series(Series1.Name).YValueMembers = "Facturacion"

            Chart4.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton4.Enabled = True
        RadioButton3.Enabled = True
        RadioButton2.Enabled = True
        RadioButton1.Enabled = True

        fechadesde = Format(dtpdesde.Value, "yyyy/MM/dd")
        fechahasta = Format(dtphasta.Value.AddDays(1), "yyyy/MM/dd")
        If fechadesde <= fechahasta Then
            controlfecha()

            If contador > 0 Then
                gbFiltro.Visible = True
            Else

                MsgBox("No existe registro en ese intervalo de fechas", MsgBoxStyle.Critical, "Error")

            End If
        Else
            MsgBox("La fecha hasta NO puede ser menor que la fecha desde", MsgBoxStyle.Critical, "Error")
            Return
        End If


    End Sub

    Public Sub controlfecha()
        Ventametodo.Controlfecha(fechadesde, fechahasta)
        contador = Ventametodo.contador

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

End Class