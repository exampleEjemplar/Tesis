<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArmadoVenta
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
		Me.cboCliente = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblClienteDireccion = New System.Windows.Forms.Label()
		Me.lblClienteDNI = New System.Windows.Forms.Label()
		Me.lblClienteTipoDNI = New System.Windows.Forms.Label()
		Me.lblClienteTelefono = New System.Windows.Forms.Label()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lstProdDispo = New System.Windows.Forms.ListView()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.btnQuitar = New System.Windows.Forms.Button()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.dgvProdSelec = New System.Windows.Forms.DataGridView()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.dgvProdSelec, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cboCliente
		'
		Me.cboCliente.AccessibleDescription = ""
		Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCliente.FormattingEnabled = True
		Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboCliente.Location = New System.Drawing.Point(91, 29)
		Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
		Me.cboCliente.Name = "cboCliente"
		Me.cboCliente.Size = New System.Drawing.Size(367, 25)
		Me.cboCliente.TabIndex = 24
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(9, 32)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(58, 17)
		Me.Label17.TabIndex = 25
		Me.Label17.Text = "Cliente"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(366, 25)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Armado de comprobante de venta"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblClienteDireccion)
		Me.GroupBox1.Controls.Add(Me.lblClienteDNI)
		Me.GroupBox1.Controls.Add(Me.lblClienteTipoDNI)
		Me.GroupBox1.Controls.Add(Me.lblClienteTelefono)
		Me.GroupBox1.Controls.Add(Me.lblNombre)
		Me.GroupBox1.Controls.Add(Me.cboCliente)
		Me.GroupBox1.Controls.Add(Me.Label17)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(555, 239)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cliente"
		'
		'lblClienteDireccion
		'
		Me.lblClienteDireccion.AutoSize = True
		Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDireccion.Location = New System.Drawing.Point(24, 117)
		Me.lblClienteDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteDireccion.Name = "lblClienteDireccion"
		Me.lblClienteDireccion.Size = New System.Drawing.Size(98, 20)
		Me.lblClienteDireccion.TabIndex = 30
		Me.lblClienteDireccion.Text = "*Direccion*"
		'
		'lblClienteDNI
		'
		Me.lblClienteDNI.AutoSize = True
		Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDNI.Location = New System.Drawing.Point(188, 156)
		Me.lblClienteDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteDNI.Name = "lblClienteDNI"
		Me.lblClienteDNI.Size = New System.Drawing.Size(54, 20)
		Me.lblClienteDNI.TabIndex = 29
		Me.lblClienteDNI.Text = "*DNI*"
		'
		'lblClienteTipoDNI
		'
		Me.lblClienteTipoDNI.AutoSize = True
		Me.lblClienteTipoDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteTipoDNI.Location = New System.Drawing.Point(24, 156)
		Me.lblClienteTipoDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteTipoDNI.Name = "lblClienteTipoDNI"
		Me.lblClienteTipoDNI.Size = New System.Drawing.Size(88, 20)
		Me.lblClienteTipoDNI.TabIndex = 28
		Me.lblClienteTipoDNI.Text = "*TipoDNI*"
		'
		'lblClienteTelefono
		'
		Me.lblClienteTelefono.AutoSize = True
		Me.lblClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteTelefono.Location = New System.Drawing.Point(24, 199)
		Me.lblClienteTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteTelefono.Name = "lblClienteTelefono"
		Me.lblClienteTelefono.Size = New System.Drawing.Size(93, 20)
		Me.lblClienteTelefono.TabIndex = 27
		Me.lblClienteTelefono.Text = "*Telefono*"
		'
		'lblNombre
		'
		Me.lblNombre.AutoSize = True
		Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblNombre.Location = New System.Drawing.Point(188, 69)
		Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(115, 24)
		Me.lblNombre.TabIndex = 26
		Me.lblNombre.Text = "*NOMBRE*"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Location = New System.Drawing.Point(687, 53)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(512, 239)
		Me.GroupBox2.TabIndex = 31
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Local"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(24, 117)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(155, 20)
		Me.Label2.TabIndex = 30
		Me.Label2.Text = "Velez Sarsfield 68"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(188, 156)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(54, 20)
		Me.Label3.TabIndex = 29
		Me.Label3.Text = "*DNI*"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(24, 156)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(88, 20)
		Me.Label4.TabIndex = 28
		Me.Label4.Text = "*TipoDNI*"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(24, 199)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(93, 20)
		Me.Label5.TabIndex = 27
		Me.Label5.Text = "*Telefono*"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(188, 69)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(175, 24)
		Me.Label6.TabIndex = 26
		Me.Label6.Text = "JOYERIA CRIZOL"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lstProdDispo)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 310)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(555, 579)
		Me.GroupBox3.TabIndex = 31
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Productos disponibles"
		'
		'lstProdDispo
		'
		Me.lstProdDispo.Location = New System.Drawing.Point(12, 21)
		Me.lstProdDispo.Name = "lstProdDispo"
		Me.lstProdDispo.Size = New System.Drawing.Size(537, 552)
		Me.lstProdDispo.TabIndex = 0
		Me.lstProdDispo.UseCompatibleStateImageBehavior = False
		'
		'btnAgregar
		'
		Me.btnAgregar.BackColor = System.Drawing.SystemColors.Control
		Me.btnAgregar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAgregar.FlatAppearance.BorderSize = 0
		Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAgregar.Location = New System.Drawing.Point(574, 320)
		Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(106, 100)
		Me.btnAgregar.TabIndex = 33
		Me.btnAgregar.Text = "Agregar"
		Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnAgregar.UseVisualStyleBackColor = False
		'
		'btnQuitar
		'
		Me.btnQuitar.BackColor = System.Drawing.SystemColors.Control
		Me.btnQuitar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnQuitar.FlatAppearance.BorderSize = 0
		Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnQuitar.Location = New System.Drawing.Point(574, 428)
		Me.btnQuitar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnQuitar.Name = "btnQuitar"
		Me.btnQuitar.Size = New System.Drawing.Size(106, 98)
		Me.btnQuitar.TabIndex = 32
		Me.btnQuitar.Text = "Quitar"
		Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnQuitar.UseVisualStyleBackColor = False
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.dgvProdSelec)
		Me.GroupBox4.Location = New System.Drawing.Point(687, 310)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(512, 579)
		Me.GroupBox4.TabIndex = 32
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Productos en la venta"
		'
		'dgvProdSelec
		'
		Me.dgvProdSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProdSelec.Location = New System.Drawing.Point(7, 22)
		Me.dgvProdSelec.Name = "dgvProdSelec"
		Me.dgvProdSelec.RowTemplate.Height = 24
		Me.dgvProdSelec.Size = New System.Drawing.Size(499, 551)
		Me.dgvProdSelec.TabIndex = 0
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(574, 794)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(106, 95)
		Me.btnSalir.TabIndex = 34
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'FrmArmadoVenta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1211, 950)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.btnQuitar)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FrmArmadoVenta"
		Me.Text = "FrmArmadoVenta"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		CType(Me.dgvProdSelec, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cboCliente As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents lblClienteDireccion As Windows.Forms.Label
	Friend WithEvents lblClienteDNI As Windows.Forms.Label
	Friend WithEvents lblClienteTipoDNI As Windows.Forms.Label
	Friend WithEvents lblClienteTelefono As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents lstProdDispo As Windows.Forms.ListView
	Friend WithEvents btnAgregar As Windows.Forms.Button
	Friend WithEvents btnQuitar As Windows.Forms.Button
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents dgvProdSelec As Windows.Forms.DataGridView
	Friend WithEvents btnSalir As Windows.Forms.Button
End Class
