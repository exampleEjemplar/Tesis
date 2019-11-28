Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn

Public Class FrmEstadisticaStock

    Private stockmetodo As New MovimientoStockLN


    Private Sub limpiar()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        RadioButton2.Enabled = True
        RadioButton1.Enabled = True
        Chart1.Visible = False
        Chart2.Visible = False

    End Sub


    Public Sub GeneraGraficoMAS()
        Try
            Dim ds1 As DataSet
            ds1 = stockmetodo.GeneraGraficoMas()
            Chart1.DataSource = ds1.Tables(0)
            Dim Series1 As Series = Chart1.Series("Series2")
            Series1.Name = "Clientes"
            Chart1.Series(Series1.Name).XValueMember = "nombre"
            Chart1.Series(Series1.Name).YValueMembers = "contador"

            Chart1.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub GeneragraficoMENOS()
        Try
            Dim ds1 As DataSet
            ds1 = stockmetodo.GeneragraficoMENOS()
            Chart2.DataSource = ds1.Tables(0)
            Dim Series1 As Series = Chart2.Series("Series2")
            Series1.Name = "Clientes"
            Chart2.Series(Series1.Name).XValueMember = "nombre"
            Chart2.Series(Series1.Name).YValueMembers = "contador"

            Chart2.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click

        Chart2.Visible = False
        Chart1.Visible = True
        GeneraGraficoMAS()
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False

    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click

        Chart2.Visible = True
        Chart1.Visible = False
        GeneragraficoMENOS()
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub FrmEstadisticaStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()

    End Sub
End Class