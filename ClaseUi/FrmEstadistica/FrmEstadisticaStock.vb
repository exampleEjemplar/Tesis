Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn

Public Class FrmEstadisticaStock

    Dim fechadesde As String
    Dim fechahasta As String
    Dim contador As Integer
    Private stockmetodo As New MovimientoStockLN


    Private Sub limpiar()
        dtpdesde.Format = DateTimePickerFormat.Custom
        dtpdesde.CustomFormat = " dd/MM/yyyy"
        dtphasta.Format = DateTimePickerFormat.Custom
        dtphasta.CustomFormat = " dd/MM/yyyy"
        gbFiltro.Visible = False
        Chart1.Visible = False
        Chart2.Visible = False
        dtpdesde.Enabled = True
        dtphasta.Enabled = True
        Button1.Enabled = True

    End Sub


    Public Sub GeneraGraficoMAS()
        Try
            Dim ds1 As DataSet
            ds1 = stockmetodo.GeneraGraficoMas(fechadesde, fechahasta)
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
            ds1 = stockmetodo.GeneragraficoMENOS(fechadesde, fechahasta)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
        stockmetodo.Controlfecha(fechadesde, fechahasta)
        contador = stockmetodo.contador

    End Sub

End Class