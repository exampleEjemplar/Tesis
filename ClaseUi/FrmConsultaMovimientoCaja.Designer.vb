﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaMovimientoCaja
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaMovimientoCaja))
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtTipo = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNumeroDeComprobante = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtMonto = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtFecha = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(15, 170)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(157, 18)
		Me.Label3.TabIndex = 73
		Me.Label3.Text = "Tipo de transacción"
		'
		'txtTipo
		'
		Me.txtTipo.Location = New System.Drawing.Point(18, 192)
		Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTipo.MaxLength = 30
		Me.txtTipo.Name = "txtTipo"
		Me.txtTipo.ReadOnly = True
		Me.txtTipo.Size = New System.Drawing.Size(354, 22)
		Me.txtTipo.TabIndex = 72
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(15, 107)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(195, 18)
		Me.Label2.TabIndex = 71
		Me.Label2.Text = "Numero de comprobante"
		'
		'txtNumeroDeComprobante
		'
		Me.txtNumeroDeComprobante.Location = New System.Drawing.Point(18, 129)
		Me.txtNumeroDeComprobante.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNumeroDeComprobante.MaxLength = 30
		Me.txtNumeroDeComprobante.Name = "txtNumeroDeComprobante"
		Me.txtNumeroDeComprobante.ReadOnly = True
		Me.txtNumeroDeComprobante.Size = New System.Drawing.Size(354, 22)
		Me.txtNumeroDeComprobante.TabIndex = 70
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(15, 45)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(67, 18)
		Me.Label11.TabIndex = 69
		Me.Label11.Text = "Usuario"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(218, 26)
		Me.Label1.TabIndex = 68
		Me.Label1.Text = "Movimiento de caja"
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(18, 67)
		Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
		Me.txtUsuario.MaxLength = 30
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.ReadOnly = True
		Me.txtUsuario.Size = New System.Drawing.Size(354, 22)
		Me.txtUsuario.TabIndex = 67
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(417, 230)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(115, 110)
		Me.btnSalir.TabIndex = 66
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(15, 234)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(56, 18)
		Me.Label5.TabIndex = 77
		Me.Label5.Text = "Monto"
		'
		'txtMonto
		'
		Me.txtMonto.Location = New System.Drawing.Point(18, 256)
		Me.txtMonto.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMonto.MaxLength = 30
		Me.txtMonto.Name = "txtMonto"
		Me.txtMonto.ReadOnly = True
		Me.txtMonto.Size = New System.Drawing.Size(354, 22)
		Me.txtMonto.TabIndex = 76
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_send_to_printer_60
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(417, 13)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(115, 136)
		Me.Button1.TabIndex = 78
		Me.Button1.Text = "Visualizar comprobante"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(15, 296)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(54, 18)
		Me.Label6.TabIndex = 80
		Me.Label6.Text = "Fecha"
		'
		'txtFecha
		'
		Me.txtFecha.Location = New System.Drawing.Point(18, 318)
		Me.txtFecha.Margin = New System.Windows.Forms.Padding(4)
		Me.txtFecha.MaxLength = 30
		Me.txtFecha.Name = "txtFecha"
		Me.txtFecha.ReadOnly = True
		Me.txtFecha.Size = New System.Drawing.Size(354, 22)
		Me.txtFecha.TabIndex = 79
		'
		'FrmConsultaMovimientoCaja
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(545, 361)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtFecha)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtMonto)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtTipo)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtNumeroDeComprobante)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtUsuario)
		Me.Controls.Add(Me.btnSalir)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmConsultaMovimientoCaja"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Movimiento de caja"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents txtTipo As Windows.Forms.TextBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents txtNumeroDeComprobante As Windows.Forms.TextBox
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents txtUsuario As Windows.Forms.TextBox
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents txtMonto As Windows.Forms.TextBox
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents txtFecha As Windows.Forms.TextBox
End Class
