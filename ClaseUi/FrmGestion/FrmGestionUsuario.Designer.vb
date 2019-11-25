<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionUsuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBusActivoSN = New System.Windows.Forms.ComboBox()
        Me.txtBusUserName = New System.Windows.Forms.TextBox()
        Me.cboBusRol = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboActivoSN = New System.Windows.Forms.ComboBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRepetirContrasena = New System.Windows.Forms.TextBox()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.lblNumIdent = New System.Windows.Forms.Label()
        Me.lblTipoIdentificacion = New System.Windows.Forms.Label()
        Me.lable13 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnValidarUserName = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(273, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 89)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnBuscar)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.cboBusActivoSN)
        Me.GroupBox5.Controls.Add(Me.dgvUsuarios)
        Me.GroupBox5.Controls.Add(Me.txtBusUserName)
        Me.GroupBox5.Controls.Add(Me.cboBusRol)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(558, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(393, 262)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Búsqueda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "UserName *"
        '
        'cboBusActivoSN
        '
        Me.cboBusActivoSN.AccessibleDescription = ""
        Me.cboBusActivoSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusActivoSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusActivoSN.FormattingEnabled = True
        Me.cboBusActivoSN.Location = New System.Drawing.Point(102, 84)
        Me.cboBusActivoSN.Name = "cboBusActivoSN"
        Me.cboBusActivoSN.Size = New System.Drawing.Size(76, 21)
        Me.cboBusActivoSN.TabIndex = 28
        '
        'txtBusUserName
        '
        Me.txtBusUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusUserName.Location = New System.Drawing.Point(102, 28)
        Me.txtBusUserName.MaxLength = 15
        Me.txtBusUserName.Name = "txtBusUserName"
        Me.txtBusUserName.Size = New System.Drawing.Size(133, 20)
        Me.txtBusUserName.TabIndex = 20
        '
        'cboBusRol
        '
        Me.cboBusRol.AccessibleDescription = ""
        Me.cboBusRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusRol.FormattingEnabled = True
        Me.cboBusRol.Location = New System.Drawing.Point(102, 58)
        Me.cboBusRol.Name = "cboBusRol"
        Me.cboBusRol.Size = New System.Drawing.Size(76, 21)
        Me.cboBusRol.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Rol *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Activo? *"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(206, 191)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(103, 91)
        Me.btnNuevo.TabIndex = 35
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(315, 193)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(103, 89)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(424, 191)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 89)
        Me.btnSalir.TabIndex = 33
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.Location = New System.Drawing.Point(0, 116)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.Size = New System.Drawing.Size(393, 144)
        Me.dgvUsuarios.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 178)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Gestión de Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboActivoSN)
        Me.GroupBox2.Controls.Add(Me.txtContrasena)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRepetirContrasena)
        Me.GroupBox2.Controls.Add(Me.cboRol)
        Me.GroupBox2.Controls.Add(Me.lblNumIdent)
        Me.GroupBox2.Controls.Add(Me.lblTipoIdentificacion)
        Me.GroupBox2.Controls.Add(Me.lable13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(9, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 70)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'cboActivoSN
        '
        Me.cboActivoSN.AccessibleDescription = ""
        Me.cboActivoSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActivoSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActivoSN.FormattingEnabled = True
        Me.cboActivoSN.Location = New System.Drawing.Point(360, 37)
        Me.cboActivoSN.Name = "cboActivoSN"
        Me.cboActivoSN.Size = New System.Drawing.Size(104, 21)
        Me.cboActivoSN.TabIndex = 24
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(142, 11)
        Me.txtContrasena.MaxLength = 20
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(133, 20)
        Me.txtContrasena.TabIndex = 23
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Contraseña *"
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(142, 37)
        Me.txtRepetirContrasena.MaxLength = 20
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(133, 20)
        Me.txtRepetirContrasena.TabIndex = 21
        Me.txtRepetirContrasena.UseSystemPasswordChar = True
        '
        'cboRol
        '
        Me.cboRol.AccessibleDescription = ""
        Me.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.Location = New System.Drawing.Point(360, 12)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(104, 21)
        Me.cboRol.TabIndex = 20
        '
        'lblNumIdent
        '
        Me.lblNumIdent.AutoSize = True
        Me.lblNumIdent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumIdent.Location = New System.Drawing.Point(300, 39)
        Me.lblNumIdent.Name = "lblNumIdent"
        Me.lblNumIdent.Size = New System.Drawing.Size(59, 13)
        Me.lblNumIdent.TabIndex = 15
        Me.lblNumIdent.Text = "Activo? *"
        '
        'lblTipoIdentificacion
        '
        Me.lblTipoIdentificacion.AutoSize = True
        Me.lblTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIdentificacion.Location = New System.Drawing.Point(4, 39)
        Me.lblTipoIdentificacion.Name = "lblTipoIdentificacion"
        Me.lblTipoIdentificacion.Size = New System.Drawing.Size(125, 13)
        Me.lblTipoIdentificacion.TabIndex = 9
        Me.lblTipoIdentificacion.Text = "Repetir Contraseña *"
        '
        'lable13
        '
        Me.lable13.AutoSize = True
        Me.lable13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable13.Location = New System.Drawing.Point(300, 13)
        Me.lable13.Name = "lable13"
        Me.lable13.Size = New System.Drawing.Size(35, 13)
        Me.lable13.TabIndex = 19
        Me.lable13.Text = "Rol *"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnValidarUserName)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txtUserName)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(9, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(526, 61)
        Me.GroupBox6.TabIndex = 24
        Me.GroupBox6.TabStop = False
        '
        'btnValidarUserName
        '
        Me.btnValidarUserName.BackColor = System.Drawing.SystemColors.Control
        Me.btnValidarUserName.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_approval_48
        Me.btnValidarUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnValidarUserName.FlatAppearance.BorderSize = 0
        Me.btnValidarUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidarUserName.Location = New System.Drawing.Point(345, 8)
        Me.btnValidarUserName.Name = "btnValidarUserName"
        Me.btnValidarUserName.Size = New System.Drawing.Size(163, 49)
        Me.btnValidarUserName.TabIndex = 17
        Me.btnValidarUserName.Text = "Verificar "
        Me.btnValidarUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidarUserName.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "UserName *"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(102, 26)
        Me.txtUserName.MaxLength = 15
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(133, 20)
        Me.txtUserName.TabIndex = 16
        '
        'FrmGestionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 305)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion Usuarios"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As Windows.Forms.Button
    Friend WithEvents btnGuardar As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents dgvUsuarios As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents lblTipoIdentificacion As Windows.Forms.Label
    Friend WithEvents cboRol As Windows.Forms.ComboBox
    Friend WithEvents lable13 As Windows.Forms.Label
    Friend WithEvents lblNumIdent As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtUserName As Windows.Forms.TextBox
    Friend WithEvents txtRepetirContrasena As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents cboBusActivoSN As Windows.Forms.ComboBox
    Friend WithEvents txtBusUserName As Windows.Forms.TextBox
    Friend WithEvents cboBusRol As Windows.Forms.ComboBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cboActivoSN As Windows.Forms.ComboBox
    Friend WithEvents txtContrasena As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnValidarUserName As Windows.Forms.Button
End Class
