<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CantidadDragAndDrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CantidadDragAndDrop))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCantidad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(171, 98)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 81)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.ClaseUi.My.Resources.Resources.icons8_checkmark_62
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(171, 9)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 81)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "Aceptar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cuantos productos "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "desea agregar?"
        '
        'cboCantidad
        '
        Me.cboCantidad.FormattingEnabled = True
        Me.cboCantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cboCantidad.Location = New System.Drawing.Point(12, 63)
        Me.cboCantidad.Name = "cboCantidad"
        Me.cboCantidad.Size = New System.Drawing.Size(148, 21)
        Me.cboCantidad.TabIndex = 32
        '
        'CantidadDragAndDrop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(253, 189)
        Me.Controls.Add(Me.cboCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CantidadDragAndDrop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents cboCantidad As Windows.Forms.ComboBox
End Class
