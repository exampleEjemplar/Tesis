<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionMaterial
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
        Me.btnSalirr = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCotizacionesHist = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCoti = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvmaterial = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalirr
        '
        Me.btnSalirr.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalirr.FlatAppearance.BorderSize = 0
        Me.btnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirr.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalirr.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalirr.Location = New System.Drawing.Point(435, 357)
        Me.btnSalirr.Name = "btnSalirr"
        Me.btnSalirr.Size = New System.Drawing.Size(69, 82)
        Me.btnSalirr.TabIndex = 48
        Me.btnSalirr.Text = "Salir"
        Me.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalirr.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.ClaseUi.My.Resources.Resources.icons8_save_62
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(435, 91)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 82)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(435, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 82)
        Me.btnNuevo.TabIndex = 46
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCotizacionesHist)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.txtCoti)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(509, 123)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'btnCotizacionesHist
        '
        Me.btnCotizacionesHist.BackColor = System.Drawing.SystemColors.Control
        Me.btnCotizacionesHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCotizacionesHist.FlatAppearance.BorderSize = 0
        Me.btnCotizacionesHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizacionesHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCotizacionesHist.Location = New System.Drawing.Point(416, 22)
        Me.btnCotizacionesHist.Name = "btnCotizacionesHist"
        Me.btnCotizacionesHist.Size = New System.Drawing.Size(88, 99)
        Me.btnCotizacionesHist.TabIndex = 50
        Me.btnCotizacionesHist.Text = "Historial de Cotizaciones"
        Me.btnCotizacionesHist.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(2, 76)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(141, 13)
        Me.lblFecha.TabIndex = 46
        Me.lblFecha.Text = "Fecha utlima cotización"
        '
        'dtpfecha
        '
        Me.dtpfecha.CustomFormat = "dd/MM/yyy"
        Me.dtpfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha.Location = New System.Drawing.Point(5, 92)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(110, 20)
        Me.dtpfecha.TabIndex = 45
        Me.dtpfecha.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'txtCoti
        '
        Me.txtCoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoti.Location = New System.Drawing.Point(192, 44)
        Me.txtCoti.MaxLength = 30
        Me.txtCoti.Name = "txtCoti"
        Me.txtCoti.Size = New System.Drawing.Size(134, 20)
        Me.txtCoti.TabIndex = 44
        Me.txtCoti.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Cotizacion Actual * (en pesos)"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(552, 223)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 89)
        Me.btnSalir.TabIndex = 42
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(190, -314)
        Me.TextBox2.MaxLength = 30
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(242, 20)
        Me.TextBox2.TabIndex = 40
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(5, 44)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(178, 20)
        Me.txtNombre.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre *"
        '
        'dgvmaterial
        '
        Me.dgvmaterial.AllowDrop = True
        Me.dgvmaterial.AllowUserToAddRows = False
        Me.dgvmaterial.AllowUserToDeleteRows = False
        Me.dgvmaterial.AllowUserToResizeColumns = False
        Me.dgvmaterial.AllowUserToResizeRows = False
        Me.dgvmaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvmaterial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvmaterial.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvmaterial.Location = New System.Drawing.Point(0, 0)
        Me.dgvmaterial.MultiSelect = False
        Me.dgvmaterial.Name = "dgvmaterial"
        Me.dgvmaterial.ReadOnly = True
        Me.dgvmaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvmaterial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvmaterial.RowHeadersVisible = False
        Me.dgvmaterial.RowHeadersWidth = 56
        Me.dgvmaterial.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmaterial.Size = New System.Drawing.Size(429, 442)
        Me.dgvmaterial.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSalirr)
        Me.Panel1.Controls.Add(Me.dgvmaterial)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(12, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 442)
        Me.Panel1.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Gestión materiales"
        '
        'FrmGestionMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 613)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de materiales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalirr As Windows.Forms.Button
    Friend WithEvents btnGuardar As Windows.Forms.Button
    Friend WithEvents btnNuevo As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents txtNombre As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtCoti As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnCotizacionesHist As Windows.Forms.Button
    Friend WithEvents lblFecha As Windows.Forms.Label
    Friend WithEvents dtpfecha As Windows.Forms.DateTimePicker
    Friend WithEvents dgvmaterial As Windows.Forms.DataGridView
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
