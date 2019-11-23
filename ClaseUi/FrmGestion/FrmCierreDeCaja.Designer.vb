<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCierreDeCaja
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreDeCaja))
		Me.dgvGrilla = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.chkFechaDesde = New System.Windows.Forms.CheckBox()
		Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblFechacierre = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblUsuario = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnSalirr = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvGrilla
		'
		Me.dgvGrilla.AllowDrop = True
		Me.dgvGrilla.AllowUserToAddRows = False
		Me.dgvGrilla.AllowUserToDeleteRows = False
		Me.dgvGrilla.AllowUserToResizeColumns = False
		Me.dgvGrilla.AllowUserToResizeRows = False
		Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
		Me.dgvGrilla.Location = New System.Drawing.Point(52, 230)
		Me.dgvGrilla.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvGrilla.MultiSelect = False
		Me.dgvGrilla.Name = "dgvGrilla"
		Me.dgvGrilla.ReadOnly = True
		Me.dgvGrilla.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dgvGrilla.RowHeadersVisible = False
		Me.dgvGrilla.RowHeadersWidth = 56
		Me.dgvGrilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvGrilla.Size = New System.Drawing.Size(839, 359)
		Me.dgvGrilla.TabIndex = 68
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(415, 36)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(202, 31)
		Me.Label1.TabIndex = 69
		Me.Label1.Text = "Cierre de Caja"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.chkFechaDesde)
		Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.lblFechacierre)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.lblUsuario)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(52, 99)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(839, 123)
		Me.GroupBox1.TabIndex = 70
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Información de Cierre de Caja"
		'
		'chkFechaDesde
		'
		Me.chkFechaDesde.AutoSize = True
		Me.chkFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkFechaDesde.Location = New System.Drawing.Point(16, 79)
		Me.chkFechaDesde.Name = "chkFechaDesde"
		Me.chkFechaDesde.Size = New System.Drawing.Size(237, 29)
		Me.chkFechaDesde.TabIndex = 7
		Me.chkFechaDesde.Text = "Habilitar fecha desde"
		Me.chkFechaDesde.UseVisualStyleBackColor = True
		'
		'dtpFechaDesde
		'
		Me.dtpFechaDesde.Enabled = False
		Me.dtpFechaDesde.Location = New System.Drawing.Point(513, 37)
		Me.dtpFechaDesde.Name = "dtpFechaDesde"
		Me.dtpFechaDesde.Size = New System.Drawing.Size(315, 23)
		Me.dtpFechaDesde.TabIndex = 6
		Me.dtpFechaDesde.Value = New Date(2019, 11, 22, 23, 37, 17, 0)
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(335, 35)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(144, 25)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Fecha desde:"
		'
		'lblFechacierre
		'
		Me.lblFechacierre.AutoSize = True
		Me.lblFechacierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechacierre.Location = New System.Drawing.Point(569, 79)
		Me.lblFechacierre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechacierre.Name = "lblFechacierre"
		Me.lblFechacierre.Size = New System.Drawing.Size(148, 25)
		Me.lblFechacierre.TabIndex = 3
		Me.lblFechacierre.Text = "lblFechacierre"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(337, 79)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(174, 25)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Fecha de Cierre:"
		'
		'lblUsuario
		'
		Me.lblUsuario.AutoSize = True
		Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsuario.Location = New System.Drawing.Point(120, 35)
		Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(108, 25)
		Me.lblUsuario.TabIndex = 1
		Me.lblUsuario.Text = "lblUsuario"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(11, 35)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(93, 25)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Usuario:"
		'
		'btnSalirr
		'
		Me.btnSalirr.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalirr.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalirr.FlatAppearance.BorderSize = 0
		Me.btnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalirr.Location = New System.Drawing.Point(899, 478)
		Me.btnSalirr.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalirr.Name = "btnSalirr"
		Me.btnSalirr.Size = New System.Drawing.Size(115, 110)
		Me.btnSalirr.TabIndex = 67
		Me.btnSalirr.Text = "Salir"
		Me.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalirr.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(899, 250)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(115, 153)
		Me.Button1.TabIndex = 71
		Me.Button1.Text = "Realizar Cierre"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnBuscar.Location = New System.Drawing.Point(922, 124)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(92, 98)
		Me.btnBuscar.TabIndex = 72
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'FrmCierreDeCaja
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1067, 602)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dgvGrilla)
		Me.Controls.Add(Me.btnSalirr)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "FrmCierreDeCaja"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvGrilla As Windows.Forms.DataGridView
    Friend WithEvents btnSalirr As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lblFechacierre As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lblUsuario As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents chkFechaDesde As Windows.Forms.CheckBox
	Friend WithEvents btnBuscar As Windows.Forms.Button
End Class
