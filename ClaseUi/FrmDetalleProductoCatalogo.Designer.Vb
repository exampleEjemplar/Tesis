﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalleProductoCatalogo
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
        Me.TBPRECIO = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TBNOMBREPROD = New System.Windows.Forms.TextBox()
        Me.TBCODIGOBARRA = New System.Windows.Forms.TextBox()
        Me.PBFOTO = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCODIGO = New System.Windows.Forms.TextBox()
        CType(Me.PBFOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBPRECIO
        '
        Me.TBPRECIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPRECIO.Location = New System.Drawing.Point(180, 239)
        Me.TBPRECIO.Name = "TBPRECIO"
        Me.TBPRECIO.Size = New System.Drawing.Size(79, 15)
        Me.TBPRECIO.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(96, 238)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 16)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Precio  $"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(19, 212)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(155, 16)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "Nombre del Producto"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(47, 183)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(122, 16)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Codigo de Barra"
        '
        'TBNOMBREPROD
        '
        Me.TBNOMBREPROD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNOMBREPROD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNOMBREPROD.Location = New System.Drawing.Point(180, 213)
        Me.TBNOMBREPROD.Name = "TBNOMBREPROD"
        Me.TBNOMBREPROD.Size = New System.Drawing.Size(239, 15)
        Me.TBNOMBREPROD.TabIndex = 39
        '
        'TBCODIGOBARRA
        '
        Me.TBCODIGOBARRA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBCODIGOBARRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCODIGOBARRA.Location = New System.Drawing.Point(180, 187)
        Me.TBCODIGOBARRA.Name = "TBCODIGOBARRA"
        Me.TBCODIGOBARRA.Size = New System.Drawing.Size(239, 15)
        Me.TBCODIGOBARRA.TabIndex = 38
        '
        'PBFOTO
        '
        Me.PBFOTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBFOTO.Location = New System.Drawing.Point(439, 12)
        Me.PBFOTO.Name = "PBFOTO"
        Me.PBFOTO.Size = New System.Drawing.Size(400, 400)
        Me.PBFOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFOTO.TabIndex = 44
        Me.PBFOTO.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 29)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "DETALLE DE PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Codigo de producto"
        '
        'TBCODIGO
        '
        Me.TBCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCODIGO.Location = New System.Drawing.Point(180, 161)
        Me.TBCODIGO.Name = "TBCODIGO"
        Me.TBCODIGO.Size = New System.Drawing.Size(239, 15)
        Me.TBCODIGO.TabIndex = 47
        '
        'FrmDetalleProductoCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 441)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBCODIGO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBFOTO)
        Me.Controls.Add(Me.TBPRECIO)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.TBNOMBREPROD)
        Me.Controls.Add(Me.TBCODIGOBARRA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetalleProductoCatalogo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Producto"
        CType(Me.PBFOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBPRECIO As Windows.Forms.TextBox
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label32 As Windows.Forms.Label
    Friend WithEvents Label34 As Windows.Forms.Label
    Friend WithEvents TBNOMBREPROD As Windows.Forms.TextBox
    Friend WithEvents TBCODIGOBARRA As Windows.Forms.TextBox
    Friend WithEvents PBFOTO As Windows.Forms.PictureBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TBCODIGO As Windows.Forms.TextBox
End Class
