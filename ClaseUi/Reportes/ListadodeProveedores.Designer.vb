﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadodeProveedores
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
		Me.SP_ListadodeProveedoresPorfechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataSetReportes = New ClaseUi.DataSetReportes()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
		Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lblDesde = New System.Windows.Forms.Label()
		Me.lblHasta = New System.Windows.Forms.Label()
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.SP_ListadodeProveedoresPorfechaTableAdapter = New ClaseUi.DataSetReportesTableAdapters.SP_ListadodeProveedoresPorfechaTableAdapter()
		Me.Label4 = New System.Windows.Forms.Label()
		CType(Me.SP_ListadodeProveedoresPorfechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SP_ListadodeProveedoresPorfechaBindingSource
		'
		Me.SP_ListadodeProveedoresPorfechaBindingSource.DataMember = "SP_ListadodeProveedoresPorfecha"
		Me.SP_ListadodeProveedoresPorfechaBindingSource.DataSource = Me.DataSetReportes
		'
		'DataSetReportes
		'
		Me.DataSetReportes.DataSetName = "DataSetReportes"
		Me.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnSalir)
		Me.GroupBox1.Controls.Add(Me.CheckBox1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.dtpHasta)
		Me.GroupBox1.Controls.Add(Me.dtpDesde)
		Me.GroupBox1.Controls.Add(Me.btnBuscar)
		Me.GroupBox1.Controls.Add(Me.lblDesde)
		Me.GroupBox1.Controls.Add(Me.lblHasta)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(16, 90)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(1185, 140)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = " Búsqueda Listado de Proveedores"
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(1063, 17)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(115, 110)
		Me.btnSalir.TabIndex = 56
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(517, 111)
		Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
		Me.CheckBox1.TabIndex = 39
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(357, 111)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(148, 17)
		Me.Label3.TabIndex = 38
		Me.Label3.Text = "Todos los registros"
		'
		'dtpHasta
		'
		Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpHasta.Location = New System.Drawing.Point(527, 60)
		Me.dtpHasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtpHasta.Name = "dtpHasta"
		Me.dtpHasta.Size = New System.Drawing.Size(188, 23)
		Me.dtpHasta.TabIndex = 37
		'
		'dtpDesde
		'
		Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDesde.Location = New System.Drawing.Point(117, 60)
		Me.dtpDesde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtpDesde.Name = "dtpDesde"
		Me.dtpDesde.Size = New System.Drawing.Size(188, 23)
		Me.dtpDesde.TabIndex = 36
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(908, 23)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(119, 110)
		Me.btnBuscar.TabIndex = 35
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'lblDesde
		'
		Me.lblDesde.AutoSize = True
		Me.lblDesde.Location = New System.Drawing.Point(52, 68)
		Me.lblDesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblDesde.Name = "lblDesde"
		Me.lblDesde.Size = New System.Drawing.Size(54, 17)
		Me.lblDesde.TabIndex = 4
		Me.lblDesde.Text = "Desde"
		'
		'lblHasta
		'
		Me.lblHasta.AutoSize = True
		Me.lblHasta.Location = New System.Drawing.Point(465, 63)
		Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHasta.Name = "lblHasta"
		Me.lblHasta.Size = New System.Drawing.Size(50, 17)
		Me.lblHasta.TabIndex = 3
		Me.lblHasta.Text = "Hasta"
		'
		'ReportViewer1
		'
		ReportDataSource1.Name = "DataSet1"
		ReportDataSource1.Value = Me.SP_ListadodeProveedoresPorfechaBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClaseUi.ListadoProveedoresPorFecha.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(16, 238)
		Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.ServerReport.BearerToken = Nothing
		Me.ReportViewer1.Size = New System.Drawing.Size(1185, 368)
		Me.ReportViewer1.TabIndex = 5
		'
		'SP_ListadodeProveedoresPorfechaTableAdapter
		'
		Me.SP_ListadodeProveedoresPorfechaTableAdapter.ClearBeforeFill = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(429, 11)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(322, 31)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Listado de Proveedores"
		'
		'ListadodeProveedores
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1217, 645)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.ReportViewer1)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "ListadodeProveedores"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Listado de proveedores"
		CType(Me.SP_ListadodeProveedoresPorfechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents dtpHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents lblDesde As Windows.Forms.Label
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ListadodeProveedoresPorfechaBindingSource As Windows.Forms.BindingSource
    Friend WithEvents DataSetReportes As DataSetReportes
    Friend WithEvents SP_ListadodeProveedoresPorfechaTableAdapter As DataSetReportesTableAdapters.SP_ListadodeProveedoresPorfechaTableAdapter
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
