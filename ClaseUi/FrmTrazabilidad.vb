
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn


Public Class FrmTrazabilidad
    Private productoln As New ProductoLN
    Dim fechadesde As String
    Dim fechahasta As String
    Dim contador As Integer

    Private Sub FrmTrazabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()

    End Sub

    Public Sub cargar()

        'Fetch the Statistical data from database.
        Dim query As String = "SELECT ShipCountry, DATEPART(Year, OrderDate) [Year], COUNT(OrderId) [Total]"
        query += " FROM Orders WHERE ShipCountry IN ('France', 'Germany', 'Brazil')"
        query += " GROUP BY ShipCountry, DATEPART(Year, OrderDate)"
        Dim dt As DataTable = GetData(query)

        'Get the DISTINCT Countries.
        Dim countries As List(Of String) = (From p In dt.AsEnumerable()
                                            Select p.Field(Of String)("ShipCountry")).Distinct().ToList()

        'Remove the Default Series.
        If Chart5.Series.Count() = 1 Then
            Chart5.Series.Remove(Chart5.Series(0))
        End If

        'Loop through the Countries.
        For Each country As String In countries

            'Get the Year for each Country.
            Dim x As Integer() = (From p In dt.AsEnumerable()
                                  Where p.Field(Of String)("ShipCountry") = country
                                  Order By p.Field(Of Integer)("Year")
                                  Select p.Field(Of Integer)("Year")).ToArray()

            'Get the Total of Orders for each Country.
            Dim y As Integer() = (From p In dt.AsEnumerable()
                                  Where p.Field(Of String)("ShipCountry") = country
                                  Order By p.Field(Of Integer)("Year")
                                  Select p.Field(Of Integer)("Total")).ToArray()

            'Add Series to the Chart.
            Chart5.Series.Add(New Series(country))
            Chart5.Series(country).IsValueShownAsLabel = True
            Chart5.Series(country).ChartType = SeriesChartType.StackedBar
            Chart5.Series(country).Points.DataBindXY(x, y)
        Next

        Chart5.Legends(0).Enabled = True
    End Sub

    Public Sub GeneraGraficoTotalportipo()
        Try
            Dim ds1 As DataSet
            ds1 = productoln.GeneraGrafico(fechadesde, fechahasta)
            Chart5.DataSource = ds1.Tables(0)
            Dim Series1 As Series = Chart5.Series("Series2")
            Series1.Name = "Ventas"
            Chart5.Series(Series1.Name).XValueMember = "Nombre"
            Chart5.Series(Series1.Name).YValueMembers = "total"
            Chart5.Series(Series1.Name).LabelFormat = " $ {0.00}"
            Chart5.Size = New System.Drawing.Size(668, 372)

        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class