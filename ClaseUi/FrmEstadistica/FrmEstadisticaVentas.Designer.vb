﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadisticaVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtphasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart3
        '
        Me.Chart3.BorderlineColor = System.Drawing.Color.Black
        Me.Chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart3.BorderlineWidth = 2
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.AxisX.Title = "Vendedor"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.Title = "Cantidad"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend1)
        Me.Chart3.Location = New System.Drawing.Point(6, 237)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series2"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart3.Series.Add(Series1)
        Me.Chart3.Size = New System.Drawing.Size(668, 372)
        Me.Chart3.TabIndex = 22
        Me.Chart3.Text = "Chart3"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Cantidad de Ventas por Vendedor"
        Me.Chart3.Titles.Add(Title1)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.gbFiltro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtphasta)
        Me.GroupBox1.Controls.Add(Me.dtpdesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 219)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estadísticas de Ventas"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_search_48
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(567, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 74)
        Me.Button1.TabIndex = 17
        Me.Button1.Tag = ""
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.RadioButton5)
        Me.gbFiltro.Controls.Add(Me.RadioButton4)
        Me.gbFiltro.Controls.Add(Me.RadioButton3)
        Me.gbFiltro.Controls.Add(Me.RadioButton2)
        Me.gbFiltro.Controls.Add(Me.RadioButton1)
        Me.gbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFiltro.Location = New System.Drawing.Point(6, 90)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(656, 110)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Búsqueda"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(22, 51)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(216, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Facturación por Tipo de Producto"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(478, 51)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(143, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Facturación Mensual"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(286, 51)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(144, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ventas por Vendedor"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(351, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(270, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = " Cantidad de Ventas por Tipo de Productos"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(22, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(184, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cantidad de ventas por Mes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde"
        '
        'dtphasta
        '
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(335, 37)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(145, 20)
        Me.dtphasta.TabIndex = 4
        '
        'dtpdesde
        '
        Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdesde.Location = New System.Drawing.Point(117, 37)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(148, 20)
        Me.dtpdesde.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(694, 450)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 89)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderlineWidth = 2
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.Inclination = 20
        ChartArea2.AxisX.Title = "Mes"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.Title = "Cantidad de ventas"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(6, 237)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series2.BorderColor = System.Drawing.Color.Black
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.IsVisibleInLegend = False
        Series2.Legend = "Legend1"
        Series2.LegendText = "Ventas"
        Series2.Name = "Series2"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(668, 372)
        Me.Chart1.TabIndex = 23
        Me.Chart1.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Cantidad de Ventas Realizadas por Mes"
        Me.Chart1.Titles.Add(Title2)
        '
        'Chart2
        '
        Me.Chart2.BorderlineColor = System.Drawing.Color.Black
        Me.Chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart2.BorderlineWidth = 2
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.AxisX.Title = "Tipo de Productos"
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.Title = "Cantidad de Productos"
        ChartArea3.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea3)
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend3)
        Me.Chart2.Location = New System.Drawing.Point(6, 237)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series3.BorderColor = System.Drawing.Color.Black
        Series3.ChartArea = "ChartArea1"
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.IsVisibleInLegend = False
        Series3.Legend = "Legend1"
        Series3.LegendText = "Ventas"
        Series3.Name = "Series2"
        Series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(668, 372)
        Me.Chart2.TabIndex = 24
        Me.Chart2.Text = "Chart2"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Cantidad de ventas por tipo producto"
        Me.Chart2.Titles.Add(Title3)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_60
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(694, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 116)
        Me.Button2.TabIndex = 18
        Me.Button2.Tag = ""
        Me.Button2.Text = "Borrar Búsqueda"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Chart4
        '
        Me.Chart4.BorderlineColor = System.Drawing.Color.Black
        Me.Chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart4.BorderlineWidth = 4
        ChartArea4.AxisX.Title = "Mes"
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.Title = "$"
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea4)
        Legend4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend4)
        Me.Chart4.Location = New System.Drawing.Point(6, 237)
        Me.Chart4.Name = "Chart4"
        Me.Chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series4.BorderWidth = 3
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.Red
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.IsVisibleInLegend = False
        Series4.LabelForeColor = System.Drawing.Color.MediumBlue
        Series4.Legend = "Legend1"
        Series4.LegendText = "$"
        Series4.Name = "Series2"
        Series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart4.Series.Add(Series4)
        Me.Chart4.Size = New System.Drawing.Size(668, 372)
        Me.Chart4.TabIndex = 25
        Me.Chart4.Text = "Chart4"
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Facturación Mensual"
        Me.Chart4.Titles.Add(Title4)
        '
        'Chart5
        '
        Me.Chart5.BorderlineColor = System.Drawing.Color.Black
        Me.Chart5.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart5.BorderlineWidth = 2
        ChartArea5.Area3DStyle.Enable3D = True
        ChartArea5.AxisX.Title = "Tipo de producto"
        ChartArea5.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea5.AxisY.Title = "$"
        ChartArea5.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea5.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea5)
        Legend5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Me.Chart5.Legends.Add(Legend5)
        Me.Chart5.Location = New System.Drawing.Point(6, 237)
        Me.Chart5.Name = "Chart5"
        Me.Chart5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series5.ChartArea = "ChartArea1"
        Series5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.IsValueShownAsLabel = True
        Series5.IsVisibleInLegend = False
        Series5.Legend = "Legend1"
        Series5.LegendText = "$"
        Series5.Name = "Series2"
        Series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart5.Series.Add(Series5)
        Me.Chart5.Size = New System.Drawing.Size(668, 372)
        Me.Chart5.TabIndex = 26
        Me.Chart5.Text = "Chart5"
        Title5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.Name = "Title1"
        Title5.Text = "Facturación por tipo de producto"
        Me.Chart5.Titles.Add(Title5)
        '
        'FrmEstadisticaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 625)
        Me.Controls.Add(Me.Chart5)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEstadisticaVentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadisticas de Ventas"
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart3 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents gbFiltro As Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dtphasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As Windows.Forms.DateTimePicker
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Chart1 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents RadioButton4 As Windows.Forms.RadioButton
    Friend WithEvents Chart4 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents RadioButton5 As Windows.Forms.RadioButton
    Friend WithEvents Chart5 As Windows.Forms.DataVisualization.Charting.Chart
End Class
