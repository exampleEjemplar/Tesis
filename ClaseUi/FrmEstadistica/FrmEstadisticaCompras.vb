﻿
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn


Public Class FrmEstadisticaCompras

    Private comprametodo As New ComprasLN
    Dim fechadesde As String
    Dim fechahasta As String
    Dim contador As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton5.Enabled = True
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

                MsgBox("No existe registro en ese intervalo de fecha", MsgBoxStyle.Critical, "Error")

            End If
        Else
            MsgBox("La fecha hasta NO puede ser menor que la fecha desde", MsgBoxStyle.Critical, "Error")
            Return
        End If
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Chart5.Visible = False
        Chart4.Visible = False
        Chart1.Visible = False
        Chart2.Visible = True
        Chart3.Visible = False
        RadioButton5.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        GeneraGraficoCompraporproveedor()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        Button1.Enabled = False
    End Sub



    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Chart5.Visible = False
        Chart2.Visible = False
        Chart1.Visible = True
        Chart3.Visible = False
        RadioButton5.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        GeneraGraficoMontoComprasPorMes()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Chart5.Visible = False
        Chart3.Visible = True
        Chart1.Visible = False
        Chart2.Visible = False
        RadioButton5.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        GeneraGraficoCompracantportipo()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Chart5.Visible = False
        Chart3.Visible = False
        Chart4.visible = True
        Chart1.Visible = False
        Chart2.Visible = False
        RadioButton5.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        GeneraGraficoMontocompraporusuario()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        Chart5.Visible = True
        Chart4.Visible = False
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False
        RadioButton5.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        GeneraGraficoMontocomprapormaterial()

        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        Button1.Enabled = False
    End Sub

    Public Sub GeneraGraficoCompracantportipo()
        Try
            Dim ds1 As DataSet
            ds1 = comprametodo.GeneraGraficoCompracantportipo(fechadesde, fechahasta)
            Chart3.DataSource = ds1.Tables(0)

            Dim Series1 As Series = Chart3.Series("Series2")
            Series1.Name = "Ventas"
            Chart3.Series(Series1.Name).XValueMember = "Nombre"
            Chart3.Series(Series1.Name).YValueMembers = "Total"

            Chart3.Size = New System.Drawing.Size(668, 372)
            Chart3.Series(Series1.Name).LabelFormat = " {0.00}%"
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GeneraGraficoMontoComprasPorMes()
        Try
            Dim ds1 As DataSet
            ds1 = comprametodo.GeneraGraficoMontoComprasPorMes(fechadesde, fechahasta)
            Chart1.DataSource = ds1.Tables(0)

            Dim Series1 As Series = Chart1.Series("Series2")
            Series1.Name = "Ventas"
            Chart1.Series(Series1.Name).XValueMember = "Mes"
            Chart1.Series(Series1.Name).YValueMembers = "Total"
            Chart1.Series(Series1.Name).LabelFormat = " $ {0.00}"
            Chart1.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GeneraGraficoCompraporproveedor()
        Try
            Dim ds1 As DataSet
            ds1 = comprametodo.GeneraGraficoCompraporproveedor(fechadesde, fechahasta)
            Chart2.DataSource = ds1.Tables(0)

            Dim Series1 As Series = Chart2.Series("Series2")
            Series1.Name = "Ventas"
            Chart2.Series(Series1.Name).XValueMember = "Proveedor"
            Chart2.Series(Series1.Name).YValueMembers = "Total"
            Chart2.Series(Series1.Name).LabelFormat = " $ {0.00}"
            Chart2.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GeneraGraficoMontocompraporusuario()
        Try
            Dim ds1 As DataSet
            ds1 = comprametodo.GeneraGraficoMontocompraporusuario(fechadesde, fechahasta)
            Chart4.DataSource = ds1.Tables(0)

            Dim Series1 As Series = Chart4.Series("Series2")
            Series1.Name = "ventas"
            Chart4.Series(Series1.Name).XValueMember = "nombre"
            Chart4.Series(Series1.Name).YValueMembers = "total"
            Chart4.Size = New System.Drawing.Size(668, 372)
            Chart4.Series(Series1.Name).LabelFormat = " $ {0.00}"
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Sub GeneraGraficoMontocomprapormaterial()
        Try
            Dim ds1 As DataSet
            ds1 = comprametodo.GeneraGraficoMontocomprapormaterial(fechadesde, fechahasta)
            chart5.DataSource = ds1.Tables(0)

            Dim Series1 As Series = chart5.Series("Series2")
            Series1.Name = "ventas"
            chart5.Series(Series1.Name).XValueMember = "nombre"
            chart5.Series(Series1.Name).YValueMembers = "total"
            chart5.Size = New System.Drawing.Size(668, 372)
            chart5.Series(Series1.Name).LabelFormat = " $ {0.00}"
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub controlfecha()
        comprametodo.Controlfecha(fechadesde, fechahasta)
        contador = comprametodo.contador

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        Chart5.Visible = False
        dtpdesde.Enabled = True
        dtphasta.Enabled = True
        Button1.Enabled = True


    End Sub

    Private Sub FrmEstadisticaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub




End Class