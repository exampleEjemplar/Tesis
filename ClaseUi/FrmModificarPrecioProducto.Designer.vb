<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarPrecioProducto
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
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtPorcentaje = New System.Windows.Forms.MaskedTextBox()
		Me.txtMonto = New System.Windows.Forms.MaskedTextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Location = New System.Drawing.Point(12, 222)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(661, 276)
		Me.CheckedListBox1.TabIndex = 0
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(680, 222)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(107, 98)
		Me.btnNuevo.TabIndex = 37
		Me.btnNuevo.Text = "Finalizar"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(680, 398)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 100)
		Me.btnSalir.TabIndex = 36
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(678, 61)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(109, 41)
		Me.Label1.TabIndex = 39
		Me.Label1.Text = "Porcentaje a modificar"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(675, 140)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 41)
		Me.Label2.TabIndex = 41
		Me.Label2.Text = "Monto exacto a modificar"
		'
		'txtPorcentaje
		'
		Me.txtPorcentaje.Location = New System.Drawing.Point(678, 105)
		Me.txtPorcentaje.Mask = "%99"
		Me.txtPorcentaje.Name = "txtPorcentaje"
		Me.txtPorcentaje.Size = New System.Drawing.Size(100, 22)
		Me.txtPorcentaje.TabIndex = 42
		'
		'txtMonto
		'
		Me.txtMonto.Location = New System.Drawing.Point(678, 184)
		Me.txtMonto.Mask = "$0000.00"
		Me.txtMonto.Name = "txtMonto"
		Me.txtMonto.Size = New System.Drawing.Size(100, 22)
		Me.txtMonto.TabIndex = 43
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(7, 9)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(384, 25)
		Me.Label3.TabIndex = 44
		Me.Label3.Text = "Modificador de precios de producto"
		'
		'FrmModificarPrecioProducto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(792, 510)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtMonto)
		Me.Controls.Add(Me.txtPorcentaje)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Name = "FrmModificarPrecioProducto"
		Me.Text = "FrmModificarPrecioProducto"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CheckedListBox1 As Windows.Forms.CheckedListBox
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents txtPorcentaje As Windows.Forms.MaskedTextBox
	Friend WithEvents txtMonto As Windows.Forms.MaskedTextBox
	Friend WithEvents Label3 As Windows.Forms.Label
End Class
