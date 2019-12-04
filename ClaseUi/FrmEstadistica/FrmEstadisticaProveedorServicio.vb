Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn


Public Class FrmEstadisticaProveedorServicio
    Dim fechadesde As String
    Dim fechahasta As String
    Dim contador As Integer
    Private Proveedormetodo As New ProveedoresLN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton4.Enabled = True
        RadioButton3.Enabled = True
        RadioButton2.Enabled = True

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

    Private Sub limpiar()

        dtpdesde.Format = DateTimePickerFormat.Custom
        dtpdesde.CustomFormat = " dd/MM/yyyy"
        dtphasta.Format = DateTimePickerFormat.Custom
        dtphasta.CustomFormat = " dd/MM/yyyy"
        gbFiltro.Visible = False
        'Chart1.Visible = False
        'Chart2.Visible = False
        Chart3.Visible = False
        Chart4.Visible = False
        Chart2.Visible = False
        dtpdesde.Enabled = True
        dtphasta.Enabled = True
        Button1.Enabled = True


    End Sub
    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Chart4.Visible = False
        Chart2.Visible = True
        Chart3.Visible = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        Button1.Enabled = False
        GeneraGraficopersoneriaservicio()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click

        Chart3.Visible = False
        Chart2.Visible = False
        Chart4.Visible = True
        GeneraGraficoprovinciaservicio()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        Button1.Enabled = False
    End Sub

    Public Sub GeneraGraficoprovinciaservicio()
        Try
            Dim ds1 As DataSet
            ds1 = Proveedormetodo.GeneraGraficoSERVICIO(fechadesde, fechahasta)
            Chart4.DataSource = ds1.Tables(0)



            Dim Series1 As Series = Chart4.Series("Series2")
            Series1.Name = "Proveedores"
            Chart4.Series(Series1.Name).XValueMember = "nombre"
            Chart4.Series(Series1.Name).YValueMembers = "Cantidad"

            Chart4.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GeneraGraficopersoneriaservicio()
        Try
            Dim ds1 As DataSet
            ds1 = Proveedormetodo.GeneraGraficopersoneria(fechadesde, fechahasta)
            Chart2.DataSource = ds1.Tables(0)
            'For index = 1 To 10

            'Next
            Dim Series2 As Series = Chart2.Series("Series2")
            Series2.Name = "Proveedores"
            Chart2.Series(Series2.Name).XValueMember = "FisicaOJuridica"
            Chart2.Series(Series2.Name).YValueMembers = "cantidad"
            Chart2.Series(Series2.Name).LabelFormat = " {0.0}%"
            Chart2.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub







    Private Sub FrmEstadisticaProveedorServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiar()

    End Sub

    Public Sub controlfecha()
        Proveedormetodo.Controlfecha(fechadesde, fechahasta)
        contador = Proveedormetodo.contador

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub


    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Chart4.Visible = False
        'Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = True
        GeneraGraficoPorPago()
        dtpdesde.Enabled = False
        dtphasta.Enabled = False
        RadioButton4.Enabled = False
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False

        Button1.Enabled = False
    End Sub


    Public Sub GeneraGraficoPorPago()
        Try
            Dim ds1 As DataSet
            ds1 = Proveedormetodo.GeneraGraficoPorPago(fechadesde, fechahasta)
            Chart3.DataSource = ds1.Tables(0)
            Dim Series1 As Series = Chart3.Series("Series2")
            Series1.Name = "Clientes"
            Chart3.Series(Series1.Name).XValueMember = "nombre"
            Chart3.Series(Series1.Name).YValueMembers = "total"

            Chart3.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class