<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImagenAmpliada
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
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImagen
        '
        Me.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImagen.Location = New System.Drawing.Point(0, 0)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(401, 399)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'ImagenAmpliada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(401, 399)
        Me.Controls.Add(Me.pbImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImagenAmpliada"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbImagen As Windows.Forms.PictureBox
End Class
