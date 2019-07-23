<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobanteCompra
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
		Me.components = New System.ComponentModel.Container()
		Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
		Me.ComprobanteVentasNEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.rpCompras = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnSalir = New System.Windows.Forms.Button()
		CType(Me.ComprobanteVentasNEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ComprobanteVentasNEBindingSource
		'
		Me.ComprobanteVentasNEBindingSource.DataSource = GetType(ClaseNe.ComprobanteVentasNE)
		'
		'rpCompras
		'
		Me.rpCompras.Dock = System.Windows.Forms.DockStyle.Fill
		ReportDataSource1.Name = "dsComprobanteVentas"
		ReportDataSource1.Value = Me.ComprobanteVentasNEBindingSource
		Me.rpCompras.LocalReport.DataSources.Add(ReportDataSource1)
		Me.rpCompras.LocalReport.ReportEmbeddedResource = "ClaseUi.ComprobanteVenta.rdlc"
		Me.rpCompras.Location = New System.Drawing.Point(0, 0)
		Me.rpCompras.Margin = New System.Windows.Forms.Padding(4)
		Me.rpCompras.Name = "rpCompras"
		Me.rpCompras.ServerReport.BearerToken = Nothing
		Me.rpCompras.Size = New System.Drawing.Size(1089, 619)
		Me.rpCompras.TabIndex = 0
		'
		'lblTitulo
		'
		Me.lblTitulo.AutoSize = True
		Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitulo.Location = New System.Drawing.Point(423, 38)
		Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(257, 29)
		Me.lblTitulo.TabIndex = 6
		Me.lblTitulo.Text = "Comprobante de Pago"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.rpCompras)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 76)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1089, 619)
		Me.Panel1.TabIndex = 5
		'
		'btnSalir
		'
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(941, -3)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(103, 105)
		Me.btnSalir.TabIndex = 7
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = True
		'
		'FrmComprobanteCompra
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1089, 695)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FrmComprobanteCompra"
		Me.Text = "FrmComprobanteCompra"
		CType(Me.ComprobanteVentasNEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComprobanteVentasNEBindingSource As Windows.Forms.BindingSource
	Friend WithEvents rpCompras As Microsoft.Reporting.WinForms.ReportViewer
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents lblTitulo As Windows.Forms.Label
	Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
