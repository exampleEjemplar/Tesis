﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListadoClientes
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
		Me.components = New System.ComponentModel.Container()
		Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
		Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dtphasta = New System.Windows.Forms.DateTimePicker()
		Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.JoyeriaCrisol12DataSet = New ClaseUi.JoyeriaCrisol12DataSet()
		Me.SPListadodeClientesPorfechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.SP_ListadodeClientesPorfechaTableAdapter = New ClaseUi.JoyeriaCrisol12DataSetTableAdapters.SP_ListadodeClientesPorfechaTableAdapter()
		Me.JoyeriaCrisol11DataSet = New ClaseUi.JoyeriaCrisol11DataSet()
		Me.SP_ListadodeClientesPorfechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.SPListadodeClientesPorfechaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.Button2 = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		CType(Me.JoyeriaCrisol12DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SPListadodeClientesPorfechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.JoyeriaCrisol11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SP_ListadodeClientesPorfechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SPListadodeClientesPorfechaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.dtphasta)
		Me.GroupBox1.Controls.Add(Me.dtpdesde)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(293, 26)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(908, 117)
		Me.GroupBox1.TabIndex = 17
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Listado de  clientes registrado entre fechas"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_search_48
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(701, 18)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(152, 91)
		Me.Button1.TabIndex = 17
		Me.Button1.Tag = ""
		Me.Button1.Text = "Buscar"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(440, 65)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(50, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Hasta"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(123, 65)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Desde"
		'
		'dtphasta
		'
		Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtphasta.Location = New System.Drawing.Point(501, 58)
		Me.dtphasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtphasta.Name = "dtphasta"
		Me.dtphasta.Size = New System.Drawing.Size(165, 23)
		Me.dtphasta.TabIndex = 4
		'
		'dtpdesde
		'
		Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpdesde.Location = New System.Drawing.Point(181, 58)
		Me.dtpdesde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtpdesde.Name = "dtpdesde"
		Me.dtpdesde.Size = New System.Drawing.Size(165, 23)
		Me.dtpdesde.TabIndex = 3
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(1368, 33)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(119, 110)
		Me.btnSalir.TabIndex = 46
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'ReportViewer1
		'
		Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
		ReportDataSource3.Name = "dslistadocliente"
		ReportDataSource3.Value = Me.SP_ListadodeClientesPorfechaBindingSource
		ReportDataSource4.Name = "DataSet1"
		ReportDataSource4.Value = Me.SP_ListadodeClientesPorfechaBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClaseUi.ListadoClientePorFecha.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(0, 150)
		Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.ServerReport.BearerToken = Nothing
		Me.ReportViewer1.Size = New System.Drawing.Size(1379, 630)
		Me.ReportViewer1.TabIndex = 49
		'
		'JoyeriaCrisol12DataSet
		'
		Me.JoyeriaCrisol12DataSet.DataSetName = "JoyeriaCrisol12DataSet"
		Me.JoyeriaCrisol12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SPListadodeClientesPorfechaBindingSource
		'
		Me.SPListadodeClientesPorfechaBindingSource.DataMember = "SP_ListadodeClientesPorfecha"
		Me.SPListadodeClientesPorfechaBindingSource.DataSource = Me.JoyeriaCrisol12DataSet
		'
		'SP_ListadodeClientesPorfechaTableAdapter
		'
		Me.SP_ListadodeClientesPorfechaTableAdapter.ClearBeforeFill = True
		'
		'JoyeriaCrisol11DataSet
		'
		Me.JoyeriaCrisol11DataSet.DataSetName = "JoyeriaCrisol11DataSet"
		Me.JoyeriaCrisol11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SP_ListadodeClientesPorfechaBindingSource
		'
		Me.SP_ListadodeClientesPorfechaBindingSource.DataMember = "SP_ListadodeClientesPorfecha"
		Me.SP_ListadodeClientesPorfechaBindingSource.DataSource = Me.JoyeriaCrisol11DataSet
		'
		'SPListadodeClientesPorfechaBindingSource1
		'
		Me.SPListadodeClientesPorfechaBindingSource1.DataMember = "SP_ListadodeClientesPorfecha"
		Me.SPListadodeClientesPorfechaBindingSource1.DataSource = Me.JoyeriaCrisol12DataSet
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Control
		Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(1253, 26)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(107, 100)
		Me.Button2.TabIndex = 50
		Me.Button2.Text = "Salir"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = False
		'
		'FrmListadoClientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(1379, 780)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.ReportViewer1)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmListadoClientes"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmListadoClientes"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.JoyeriaCrisol12DataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SPListadodeClientesPorfechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.JoyeriaCrisol11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SP_ListadodeClientesPorfechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SPListadodeClientesPorfechaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dtphasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As Windows.Forms.DateTimePicker
    Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
	Friend WithEvents SP_ListadodeClientesPorfechaBindingSource As Windows.Forms.BindingSource
	Friend WithEvents JoyeriaCrisol11DataSet As JoyeriaCrisol11DataSet
	Friend WithEvents JoyeriaCrisol12DataSet As JoyeriaCrisol12DataSet
	Friend WithEvents SPListadodeClientesPorfechaBindingSource As Windows.Forms.BindingSource
	Friend WithEvents SP_ListadodeClientesPorfechaTableAdapter As JoyeriaCrisol12DataSetTableAdapters.SP_ListadodeClientesPorfechaTableAdapter
	Friend WithEvents SPListadodeClientesPorfechaBindingSource1 As Windows.Forms.BindingSource
	Friend WithEvents Button2 As Windows.Forms.Button
End Class
