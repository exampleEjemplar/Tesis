﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCotizaciones
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgvCotizaciones = New System.Windows.Forms.DataGridView()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.txtMaterial = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvCotizaciones
		'
		Me.dgvCotizaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dgvCotizaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dgvCotizaciones.EnableHeadersVisualStyles = False
		Me.dgvCotizaciones.Location = New System.Drawing.Point(13, 154)
		Me.dgvCotizaciones.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvCotizaciones.MultiSelect = False
		Me.dgvCotizaciones.Name = "dgvCotizaciones"
		Me.dgvCotizaciones.ReadOnly = True
		Me.dgvCotizaciones.RowHeadersVisible = False
		Me.dgvCotizaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.dgvCotizaciones.RowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvCotizaciones.Size = New System.Drawing.Size(443, 251)
		Me.dgvCotizaciones.TabIndex = 45
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(341, 13)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(115, 110)
		Me.btnSalir.TabIndex = 50
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'txtMaterial
		'
		Me.txtMaterial.Location = New System.Drawing.Point(13, 86)
		Me.txtMaterial.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMaterial.MaxLength = 30
		Me.txtMaterial.Name = "txtMaterial"
		Me.txtMaterial.Size = New System.Drawing.Size(315, 22)
		Me.txtMaterial.TabIndex = 51
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(12, 64)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(68, 18)
		Me.Label11.TabIndex = 52
		Me.Label11.Text = "Material"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(10, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(272, 26)
		Me.Label1.TabIndex = 53
		Me.Label1.Text = "Historial de cotizaciones"
		'
		'FrmConsultaCotizaciones
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(485, 418)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtMaterial)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.dgvCotizaciones)
		Me.Name = "FrmConsultaCotizaciones"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmConsultaCotizaciones"
		CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvCotizaciones As Windows.Forms.DataGridView
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents txtMaterial As Windows.Forms.TextBox
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
End Class