﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaMovimientoStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaMovimientoStock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvCotizaciones = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidadMov = New System.Windows.Forms.TextBox()
        CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Historial de movimientos de stock"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(14, 54)
        Me.txtProducto.MaxLength = 30
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(266, 20)
        Me.txtProducto.TabIndex = 56
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(309, 57)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 89)
        Me.btnSalir.TabIndex = 55
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgvCotizaciones
        '
        Me.dgvCotizaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCotizaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvCotizaciones.EnableHeadersVisualStyles = False
        Me.dgvCotizaciones.Location = New System.Drawing.Point(12, 159)
        Me.dgvCotizaciones.MultiSelect = False
        Me.dgvCotizaciones.Name = "dgvCotizaciones"
        Me.dgvCotizaciones.ReadOnly = True
        Me.dgvCotizaciones.RowHeadersVisible = False
        Me.dgvCotizaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCotizaciones.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCotizaciones.Size = New System.Drawing.Size(383, 204)
        Me.dgvCotizaciones.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(11, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Proveedor"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(14, 96)
        Me.txtProveedor.MaxLength = 30
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(266, 20)
        Me.txtProveedor.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(11, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Stock actual"
        '
        'txtStockActual
        '
        Me.txtStockActual.Location = New System.Drawing.Point(14, 135)
        Me.txtStockActual.MaxLength = 30
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.ReadOnly = True
        Me.txtStockActual.Size = New System.Drawing.Size(86, 20)
        Me.txtStockActual.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(129, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Cantidad de movimientos"
        '
        'txtCantidadMov
        '
        Me.txtCantidadMov.Location = New System.Drawing.Point(131, 135)
        Me.txtCantidadMov.MaxLength = 30
        Me.txtCantidadMov.Name = "txtCantidadMov"
        Me.txtCantidadMov.ReadOnly = True
        Me.txtCantidadMov.Size = New System.Drawing.Size(86, 20)
        Me.txtCantidadMov.TabIndex = 63
        '
        'FrmConsultaMovimientoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 366)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidadMov)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStockActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvCotizaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaMovimientoStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimiento de stock"
        CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents txtProducto As Windows.Forms.TextBox
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents dgvCotizaciones As Windows.Forms.DataGridView
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents txtProveedor As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents txtStockActual As Windows.Forms.TextBox
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents txtCantidadMov As Windows.Forms.TextBox
End Class
