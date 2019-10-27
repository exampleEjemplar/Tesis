<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.EstaditicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PagosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ArtículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnPedidos = New System.Windows.Forms.Button()
		Me.btnCaja = New System.Windows.Forms.Button()
		Me.btnArticulos = New System.Windows.Forms.Button()
		Me.btnCompras = New System.Windows.Forms.Button()
		Me.btnVentas = New System.Windows.Forms.Button()
		Me.btnPagos = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip
		'
		Me.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue
		Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.ToolsMenu, Me.OpcionesToolStripMenuItem})
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
		Me.MenuStrip.Size = New System.Drawing.Size(1554, 28)
		Me.MenuStrip.TabIndex = 15
		Me.MenuStrip.Text = "MenuStrip"
		'
		'OperacionesToolStripMenuItem
		'
		Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem, Me.CompraToolStripMenuItem, Me.PagosToolStripMenuItem, Me.PedidosToolStripMenuItem})
		Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
		Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
		Me.OperacionesToolStripMenuItem.Text = "Operaciones"
		'
		'VentaToolStripMenuItem
		'
		Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
		Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.VentaToolStripMenuItem.Text = "Ventas"
		'
		'CompraToolStripMenuItem
		'
		Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
		Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.CompraToolStripMenuItem.Text = "Compras"
		'
		'PagosToolStripMenuItem
		'
		Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
		Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.PagosToolStripMenuItem.Text = "Pagos"
		'
		'PedidosToolStripMenuItem
		'
		Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
		Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.PedidosToolStripMenuItem.Text = "Pedidos"
		'
		'ToolsMenu
		'
		Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstaditicasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.VentasToolStripMenuItem1, Me.CToolStripMenuItem, Me.PagosToolStripMenuItem1, Me.ClientesToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.ArtículosToolStripMenuItem})
		Me.ToolsMenu.Name = "ToolsMenu"
		Me.ToolsMenu.Size = New System.Drawing.Size(124, 24)
		Me.ToolsMenu.Text = "&Administración"
		'
		'EstaditicasToolStripMenuItem
		'
		Me.EstaditicasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.CajaToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.StockToolStripMenuItem})
		Me.EstaditicasToolStripMenuItem.Name = "EstaditicasToolStripMenuItem"
		Me.EstaditicasToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.EstaditicasToolStripMenuItem.Text = "Estadísticas"
		'
		'ClientesToolStripMenuItem
		'
		Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
		Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.ClientesToolStripMenuItem.Text = "Clientes"
		'
		'ProveedoresToolStripMenuItem
		'
		Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
		Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
		'
		'CajaToolStripMenuItem
		'
		Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
		Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.CajaToolStripMenuItem.Text = "Caja"
		'
		'VentasToolStripMenuItem
		'
		Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
		Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.VentasToolStripMenuItem.Text = "Ventas"
		'
		'ComprasToolStripMenuItem
		'
		Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
		Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.ComprasToolStripMenuItem.Text = "Compras"
		'
		'StockToolStripMenuItem
		'
		Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
		Me.StockToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.StockToolStripMenuItem.Text = "Stock"
		'
		'UsuariosToolStripMenuItem
		'
		Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
		Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.UsuariosToolStripMenuItem.Text = "Usuarios"
		'
		'VentasToolStripMenuItem1
		'
		Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
		Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
		Me.VentasToolStripMenuItem1.Text = "Ventas"
		'
		'CToolStripMenuItem
		'
		Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
		Me.CToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.CToolStripMenuItem.Text = "Compras"
		'
		'PagosToolStripMenuItem1
		'
		Me.PagosToolStripMenuItem1.Name = "PagosToolStripMenuItem1"
		Me.PagosToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
		Me.PagosToolStripMenuItem1.Text = "Pagos"
		'
		'ClientesToolStripMenuItem1
		'
		Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
		Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
		Me.ClientesToolStripMenuItem1.Text = "Clientes"
		'
		'ProveedoresToolStripMenuItem1
		'
		Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
		Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
		Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
		'
		'ArtículosToolStripMenuItem
		'
		Me.ArtículosToolStripMenuItem.Name = "ArtículosToolStripMenuItem"
		Me.ArtículosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.ArtículosToolStripMenuItem.Text = "Artículos"
		'
		'OpcionesToolStripMenuItem
		'
		Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
		Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
		Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
		Me.OpcionesToolStripMenuItem.Text = "Opciones"
		'
		'CerrarSesiónToolStripMenuItem
		'
		Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
		Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Button4.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_moleskine_62
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.Location = New System.Drawing.Point(1002, 252)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(165, 111)
		Me.Button4.TabIndex = 30
		Me.Button4.Text = "Catalogo"
		Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_supplier_62__1_
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(813, 252)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(165, 111)
		Me.Button2.TabIndex = 26
		Me.Button2.Text = "Proveedores"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_client_management_62
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(813, 133)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(165, 111)
		Me.Button1.TabIndex = 24
		Me.Button1.Text = "Clientes"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSalir.Location = New System.Drawing.Point(909, 370)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(165, 112)
		Me.btnSalir.TabIndex = 22
		Me.btnSalir.Text = "SALIR"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnPedidos
		'
		Me.btnPedidos.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnPedidos.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PinClipart1
		Me.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnPedidos.FlatAppearance.BorderSize = 0
		Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPedidos.Location = New System.Drawing.Point(1198, 128)
		Me.btnPedidos.Margin = New System.Windows.Forms.Padding(4)
		Me.btnPedidos.Name = "btnPedidos"
		Me.btnPedidos.Size = New System.Drawing.Size(165, 111)
		Me.btnPedidos.TabIndex = 20
		Me.btnPedidos.Text = "Pedidos"
		Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.btnPedidos.UseVisualStyleBackColor = False
		'
		'btnCaja
		'
		Me.btnCaja.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnCaja.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_paper_money_62
		Me.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnCaja.FlatAppearance.BorderSize = 0
		Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCaja.Location = New System.Drawing.Point(1198, 252)
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
		Me.btnArticulos.Location = New System.Drawing.Point(1002, 128)
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
		Me.btnCompras.Location = New System.Drawing.Point(617, 252)
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
		Me.btnVentas.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_rent_64
		Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnVentas.FlatAppearance.BorderSize = 0
		Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnVentas.Location = New System.Drawing.Point(617, 133)
		Me.btnVentas.Margin = New System.Windows.Forms.Padding(4)
		Me.btnVentas.Name = "btnVentas"
		Me.btnVentas.Size = New System.Drawing.Size(165, 111)
		Me.btnVentas.TabIndex = 16
		Me.btnVentas.Text = "Ventas"
		Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.btnVentas.UseVisualStyleBackColor = False
		'
		'btnPagos
		'
		Me.btnPagos.BackColor = System.Drawing.Color.LightSteelBlue
		Me.btnPagos.BackgroundImage = Global.ClaseUi.My.Resources.Resources.money_PNG3544__1_
		Me.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnPagos.FlatAppearance.BorderSize = 0
		Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPagos.Location = New System.Drawing.Point(417, 133)
		Me.btnPagos.Margin = New System.Windows.Forms.Padding(4)
		Me.btnPagos.Name = "btnPagos"
		Me.btnPagos.Size = New System.Drawing.Size(165, 111)
		Me.btnPagos.TabIndex = 32
		Me.btnPagos.Text = "Pagos"
		Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.btnPagos.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Button3.BackgroundImage = Global.ClaseUi.My.Resources.Resources.Appliance_Plug_PNG_Photo__1_
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.Location = New System.Drawing.Point(417, 252)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(165, 111)
		Me.Button3.TabIndex = 34
		Me.Button3.Text = "Servicios"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Button3.UseVisualStyleBackColor = False
		'
		'ReportesToolStripMenuItem
		'
		Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
		Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.ReportesToolStripMenuItem.Text = "Reportes"
		'
		'MDIPrincipal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.ClaseUi.My.Resources.Resources.Jewelry_Pearl_Gray_background_543096_1280x847
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1554, 762)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.btnPagos)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnPedidos)
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
    Friend WithEvents btnPedidos As Windows.Forms.Button
    Friend WithEvents btnCaja As Windows.Forms.Button
    Friend WithEvents btnArticulos As Windows.Forms.Button
    Friend WithEvents btnCompras As Windows.Forms.Button
    Friend WithEvents btnVentas As Windows.Forms.Button
    Friend WithEvents MenuStrip As Windows.Forms.MenuStrip
	Friend WithEvents ToolsMenu As Windows.Forms.ToolStripMenuItem
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents EstaditicasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ClientesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ProveedoresToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents CajaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents VentasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ComprasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents Button4 As Windows.Forms.Button
	Friend WithEvents StockToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents btnPagos As Windows.Forms.Button
	Friend WithEvents Button3 As Windows.Forms.Button
	Friend WithEvents OperacionesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents VentaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents CompraToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents PagosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents PedidosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents UsuariosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents VentasToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
	Friend WithEvents CToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents PagosToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ClientesToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ProveedoresToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ArtículosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpcionesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents CerrarSesiónToolStripMenuItem As Windows.Forms.ToolStripMenuItem
	Friend WithEvents ReportesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
