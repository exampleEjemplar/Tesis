<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.login2
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.btncerrar)
        Me.panel1.Controls.Add(Me.lblFecha)
        Me.panel1.Controls.Add(Me.txtContrasena)
        Me.panel1.Controls.Add(Me.txtUsuario)
        Me.panel1.Location = New System.Drawing.Point(2, 2)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.panel1.Size = New System.Drawing.Size(667, 345)
        Me.panel1.TabIndex = 11
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(259, 289)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFecha.Size = New System.Drawing.Size(72, 25)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.SkyBlue
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContrasena.Location = New System.Drawing.Point(160, 191)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContrasena.Size = New System.Drawing.Size(299, 27)
        Me.txtContrasena.TabIndex = 1
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.SkyBlue
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUsuario.Location = New System.Drawing.Point(160, 128)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsuario.Size = New System.Drawing.Size(299, 23)
        Me.txtUsuario.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.btn_ingresar
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(489, 118)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(120, 105)
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.btn_cerrar
        Me.btncerrar.Location = New System.Drawing.Point(27, 289)
        Me.btncerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(47, 37)
        Me.btncerrar.TabIndex = 5
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 348)
        Me.Controls.Add(Me.panel1)
        Me.Name = "LogIn"
        Me.Text = "LogIn"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Windows.Forms.Panel
    Private WithEvents pictureBox1 As Windows.Forms.PictureBox
    Private WithEvents btncerrar As Windows.Forms.Button
    Private WithEvents lblFecha As Windows.Forms.Label
    Private WithEvents txtContrasena As Windows.Forms.TextBox
    Private WithEvents txtUsuario As Windows.Forms.TextBox
End Class
