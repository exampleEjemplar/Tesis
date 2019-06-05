
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn

Public Class FrmEstadisticacliente

    Dim fechadesde As String
    Dim fechahasta As String
    Dim contador As Integer
    Private clientemetodo As New ClientesLN



    Private Sub FrmEstadisticacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbFiltro.Visible = False
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fechadesde = Format(dtpdesde.Value, "yyyy/MM/dd")
        fechahasta = Format(dtphasta.Value, "yyyy/MM/dd")
        controlfecha()

        If contador > 0 Then
            gbFiltro.Visible = True
        Else

            MsgBox("No existe registro en ese intervalo de fechas", MsgBoxStyle.Critical, "Error")

        End If





    End Sub

    Public Sub controlfecha()
        clientemetodo.controlfecha(fechadesde, fechahasta)
        contador = clientemetodo.contador

    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Chart3.Visible = True
        Chart2.Visible = False
        Chart1.Visible = False
        GeneraGraficousuario()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        'RadioButton3.Enabled = False
        'RadioButton2.Enabled = False
        ' RadioButton1.Enabled = False
    End Sub



    Public Sub GeneraGraficoprovincia()
        Try
            Dim ds1 As DataSet
            ds1 = clientemetodo.GeneraGrafico(fechadesde, fechahasta)
            Chart1.DataSource = ds1.Tables(0)



            Dim Series1 As Series = Chart1.Series("Series2")
            Series1.Name = "Clientes"
            Chart1.Series(Series1.Name).XValueMember = "nombre"
            Chart1.Series(Series1.Name).YValueMembers = "Cantidad"

            Chart1.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Sub GeneraGraficopersoneria()
        Try
            Dim ds1 As DataSet
            ds1 = clientemetodo.GeneraGraficopersoneria(fechadesde, fechahasta)
            Chart2.DataSource = ds1.Tables(0)



            Dim Series2 As Series = Chart2.Series("Series2")
            Series2.Name = "Clientes"
            Chart2.Series(Series2.Name).XValueMember = "FisicaOJuridica"
            Chart2.Series(Series2.Name).YValueMembers = "Cantidad"

            Chart2.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GeneraGraficousuario()
        Try
            Dim ds1 As DataSet
            ds1 = clientemetodo.GeneraGraficousuario(fechadesde, fechahasta)
            Chart3.DataSource = ds1.Tables(0)



            Dim Series1 As Series = Chart3.Series("Series2")
            Series1.Name = "Clientes"
            Chart3.Series(Series1.Name).XValueMember = "nombre"
            Chart3.Series(Series1.Name).YValueMembers = "contador"

            Chart3.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Chart1.Visible = True
        Chart2.Visible = False
        Chart3.Visible = False
        GeneraGraficoprovincia()
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
        GeneraGraficopersoneria()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
    End Sub


End Class