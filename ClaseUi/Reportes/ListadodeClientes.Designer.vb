<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadodeClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadodeClientes))
        Me.SP_ListadodeClientesPorfechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReportes = New ClaseUi.DataSetReportes()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.SP_ListadodeClientesPorfechaTableAdapter = New ClaseUi.DataSetReportesTableAdapters.SP_ListadodeClientesPorfechaTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.SP_ListadodeClientesPorfechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SP_ListadodeClientesPorfechaBindingSource
        '
        Me.SP_ListadodeClientesPorfechaBindingSource.DataMember = "SP_ListadodeClientesPorfecha"
        Me.SP_ListadodeClientesPorfechaBindingSource.DataSource = Me.DataSetReportes
        '
        'DataSetReportes
        '
        Me.DataSetReportes.DataSetName = "DataSetReportes"
        Me.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReporteClienteConFecha"
        ReportDataSource1.Value = Me.SP_ListadodeClientesPorfechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClaseUi.ListadoClientesPorfecha.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(614, 456)
        Me.ReportViewer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 114)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(522, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 85)
        Me.btnSalir.TabIndex = 56
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(42, 71)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Todos los registros"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(246, 35)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(110, 20)
        Me.dtpHasta.TabIndex = 37
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(88, 35)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 20)
        Me.dtpDesde.TabIndex = 36
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(447, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 76)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(39, 39)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(43, 13)
        Me.lblDesde.TabIndex = 4
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(200, 39)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(40, 13)
        Me.lblHasta.TabIndex = 3
        Me.lblHasta.Text = "Hasta"
        '
        'SP_ListadodeClientesPorfechaTableAdapter
        '
        Me.SP_ListadodeClientesPorfechaTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Listado de Clientes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 456)
        Me.Panel1.TabIndex = 10
        '
        'ListadodeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListadodeClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de clientes"
        CType(Me.SP_ListadodeClientesPorfechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ListadodeClientesPorfechaBindingSource As Windows.Forms.BindingSource
    Friend WithEvents DataSetReportes As DataSetReportes
    Friend WithEvents SP_ListadodeClientesPorfechaTableAdapter As DataSetReportesTableAdapters.SP_ListadodeClientesPorfechaTableAdapter
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lblDesde As Windows.Forms.Label
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents dtpHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
