<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTrazabilidad
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
		Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblProveedor = New System.Windows.Forms.Label()
		Me.lblPrecio = New System.Windows.Forms.Label()
		Me.lblPrecioVenta = New System.Windows.Forms.Label()
		Me.lblCliente = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblTiempoTotal = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cboProductos = New System.Windows.Forms.ComboBox()
		CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Chart5
		'
		Me.Chart5.BorderlineColor = System.Drawing.Color.Black
		Me.Chart5.BorderlineWidth = 2
		ChartArea2.Area3DStyle.Enable3D = True
		ChartArea2.Area3DStyle.Inclination = 10
		ChartArea2.Area3DStyle.IsClustered = True
		ChartArea2.Area3DStyle.IsRightAngleAxes = False
		ChartArea2.Area3DStyle.Rotation = 20
		ChartArea2.AxisX.Title = "Estados"
		ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea2.AxisY.Title = "Demora "
		ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea2.Name = "ChartArea1"
		Me.Chart5.ChartAreas.Add(ChartArea2)
		Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine
		Legend2.IsTextAutoFit = False
		Legend2.Name = "Legend1"
		Me.Chart5.Legends.Add(Legend2)
		Me.Chart5.Location = New System.Drawing.Point(3, 4)
		Me.Chart5.Margin = New System.Windows.Forms.Padding(4)
		Me.Chart5.Name = "Chart5"
		Me.Chart5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
		Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Series2.ChartArea = "ChartArea1"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
		Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Series2.IsValueShownAsLabel = True
		Series2.IsVisibleInLegend = False
		Series2.Legend = "Legend1"
		Series2.Name = "Series2"
		Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
		Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
		Series2.YValuesPerPoint = 2
		Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
		Me.Chart5.Series.Add(Series2)
		Me.Chart5.Size = New System.Drawing.Size(891, 594)
		Me.Chart5.TabIndex = 35
		Me.Chart5.Text = "Chart5"
		Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Title2.Name = "Title1"
		Title2.Text = "Traza de Pedido"
		Me.Chart5.Titles.Add(Title2)
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSalir.Location = New System.Drawing.Point(1149, 305)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 110)
		Me.btnSalir.TabIndex = 32
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 30)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 17)
		Me.Label1.TabIndex = 36
		Me.Label1.Text = "Proveedor"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cboProductos)
		Me.GroupBox1.Controls.Add(Me.lblTiempoTotal)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.lblCliente)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.lblPrecioVenta)
		Me.GroupBox1.Controls.Add(Me.lblPrecio)
		Me.GroupBox1.Controls.Add(Me.lblProveedor)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(901, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(356, 286)
		Me.GroupBox1.TabIndex = 37
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Información del pedido"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 70)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 17)
		Me.Label2.TabIndex = 37
		Me.Label2.Text = "Productos"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 115)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(106, 17)
		Me.Label3.TabIndex = 38
		Me.Label3.Text = "Precio de costo"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(6, 159)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(107, 17)
		Me.Label4.TabIndex = 39
		Me.Label4.Text = "Precio de venta"
		'
		'lblProveedor
		'
		Me.lblProveedor.AutoSize = True
		Me.lblProveedor.Location = New System.Drawing.Point(172, 30)
		Me.lblProveedor.Name = "lblProveedor"
		Me.lblProveedor.Size = New System.Drawing.Size(74, 17)
		Me.lblProveedor.TabIndex = 40
		Me.lblProveedor.Text = "Proveedor"
		'
		'lblPrecio
		'
		Me.lblPrecio.AutoSize = True
		Me.lblPrecio.Location = New System.Drawing.Point(172, 115)
		Me.lblPrecio.Name = "lblPrecio"
		Me.lblPrecio.Size = New System.Drawing.Size(72, 17)
		Me.lblPrecio.TabIndex = 41
		Me.lblPrecio.Text = "Productos"
		'
		'lblPrecioVenta
		'
		Me.lblPrecioVenta.AutoSize = True
		Me.lblPrecioVenta.Location = New System.Drawing.Point(172, 159)
		Me.lblPrecioVenta.Name = "lblPrecioVenta"
		Me.lblPrecioVenta.Size = New System.Drawing.Size(48, 17)
		Me.lblPrecioVenta.TabIndex = 42
		Me.lblPrecioVenta.Text = "Precio"
		'
		'lblCliente
		'
		Me.lblCliente.AutoSize = True
		Me.lblCliente.Location = New System.Drawing.Point(172, 198)
		Me.lblCliente.Name = "lblCliente"
		Me.lblCliente.Size = New System.Drawing.Size(74, 17)
		Me.lblCliente.TabIndex = 44
		Me.lblCliente.Text = "Proveedor"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(6, 198)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(51, 17)
		Me.Label6.TabIndex = 43
		Me.Label6.Text = "Cliente"
		'
		'lblTiempoTotal
		'
		Me.lblTiempoTotal.AutoSize = True
		Me.lblTiempoTotal.Location = New System.Drawing.Point(172, 247)
		Me.lblTiempoTotal.Name = "lblTiempoTotal"
		Me.lblTiempoTotal.Size = New System.Drawing.Size(74, 17)
		Me.lblTiempoTotal.TabIndex = 46
		Me.lblTiempoTotal.Text = "Proveedor"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(6, 247)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(156, 17)
		Me.Label7.TabIndex = 45
		Me.Label7.Text = "Tiempo total del pedido"
		'
		'cboProductos
		'
		Me.cboProductos.FormattingEnabled = True
		Me.cboProductos.Location = New System.Drawing.Point(175, 67)
		Me.cboProductos.Name = "cboProductos"
		Me.cboProductos.Size = New System.Drawing.Size(140, 24)
		Me.cboProductos.TabIndex = 47
		'
		'FrmTrazabilidad
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1269, 608)
		Me.ControlBox = False
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Chart5)
		Me.Controls.Add(Me.btnSalir)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmTrazabilidad"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Trazabilidad de pedido"
		CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Chart5 As Windows.Forms.DataVisualization.Charting.Chart
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents lblTiempoTotal As Windows.Forms.Label
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents lblCliente As Windows.Forms.Label
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents lblPrecioVenta As Windows.Forms.Label
	Friend WithEvents lblPrecio As Windows.Forms.Label
	Friend WithEvents lblProveedor As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents cboProductos As Windows.Forms.ComboBox
End Class
