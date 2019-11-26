<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComprobanteVenta
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
		Me.components = New System.ComponentModel.Container()
		Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprobanteVenta))
		Me.ComprobanteVentasNEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.rpVentas = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnSalir = New System.Windows.Forms.Button()
		CType(Me.ComprobanteVentasNEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ComprobanteVentasNEBindingSource
		'
		Me.ComprobanteVentasNEBindingSource.DataSource = GetType(ClaseNe.ComprobanteVentasNE)
		'
		'rpVentas
		'
		Me.rpVentas.Dock = System.Windows.Forms.DockStyle.Fill
		ReportDataSource1.Name = "dsComprobanteVentas"
		ReportDataSource1.Value = Me.ComprobanteVentasNEBindingSource
		Me.rpVentas.LocalReport.DataSources.Add(ReportDataSource1)
		Me.rpVentas.LocalReport.ReportEmbeddedResource = "ClaseUi.ComprobanteVenta.rdlc"
		Me.rpVentas.Location = New System.Drawing.Point(0, 0)
		Me.rpVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.rpVentas.Name = "rpVentas"
		Me.rpVentas.ServerReport.BearerToken = Nothing
		Me.rpVentas.Size = New System.Drawing.Size(1192, 619)
		Me.rpVentas.TabIndex = 0
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.rpVentas)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 198)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1192, 619)
		Me.Panel1.TabIndex = 1
		'
		'lblTitulo
		'
		Me.lblTitulo.AutoSize = True
		Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitulo.Location = New System.Drawing.Point(423, 38)
		Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(267, 29)
		Me.lblTitulo.TabIndex = 2
		Me.lblTitulo.Text = "Comprobante de Cobro"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSalir
		'
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(1073, 58)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(103, 105)
		Me.btnSalir.TabIndex = 4
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = True
		'
		'FrmComprobanteVenta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(1192, 817)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmComprobanteVenta"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Compobante de Cobro"
		CType(Me.ComprobanteVentasNEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents rpVentas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents lblTitulo As Windows.Forms.Label
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents ComprobanteVentasNEBindingSource As Windows.Forms.BindingSource
End Class
