﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIPrincipal
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAjustes = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1109, 28)
        Me.MenuStrip.TabIndex = 15
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(66, 24)
        Me.FileMenu.Text = "&Ventas"
        '
        'EditMenu
        '
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(81, 24)
        Me.EditMenu.Text = "&Compras"
        '
        'ViewMenu
        '
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(81, 24)
        Me.ViewMenu.Text = "&Articulos"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(124, 24)
        Me.ToolsMenu.Text = "&Administración"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(118, 24)
        Me.WindowsMenu.Text = "&Configuración"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.NewWindowToolStripMenuItem.Text = "&Nueva ventana"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(65, 24)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(160, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_services_62
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(917, 616)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(165, 97)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAjustes
        '
        Me.btnAjustes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAjustes.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_services_62
        Me.btnAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAjustes.FlatAppearance.BorderSize = 0
        Me.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjustes.Location = New System.Drawing.Point(13, 524)
        Me.btnAjustes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(165, 111)
        Me.btnAjustes.TabIndex = 20
        Me.btnAjustes.Text = "Ajustes"
        Me.btnAjustes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAjustes.UseVisualStyleBackColor = False
        '
        'btnCaja
        '
        Me.btnCaja.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCaja.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_paper_money_62
        Me.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.Location = New System.Drawing.Point(13, 405)
        Me.btnCaja.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(165, 111)
        Me.btnCaja.TabIndex = 19
        Me.btnCaja.Text = "Caja"
        Me.btnCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCaja.UseVisualStyleBackColor = False
        '
        'btnArticulos
        '
        Me.btnArticulos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnArticulos.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_jewelry_62
        Me.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.Location = New System.Drawing.Point(13, 286)
        Me.btnArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(165, 111)
        Me.btnArticulos.TabIndex = 18
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnArticulos.UseVisualStyleBackColor = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCompras.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shop_62
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.Location = New System.Drawing.Point(13, 167)
        Me.btnCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(165, 111)
        Me.btnCompras.TabIndex = 17
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnVentas.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_supplier_62
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Location = New System.Drawing.Point(13, 48)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(165, 111)
        Me.btnVentas.TabIndex = 16
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_supplier_62
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(634, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 111)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Clientes"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 756)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAjustes)
        Me.Controls.Add(Me.btnCaja)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIPrincipal"
        Me.Text = "MDIPrincipal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnAjustes As Windows.Forms.Button
    Friend WithEvents btnCaja As Windows.Forms.Button
    Friend WithEvents btnArticulos As Windows.Forms.Button
    Friend WithEvents btnCompras As Windows.Forms.Button
    Friend WithEvents btnVentas As Windows.Forms.Button
    Friend WithEvents MenuStrip As Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenu As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
