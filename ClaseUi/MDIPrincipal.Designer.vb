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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticaProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísitcasDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnReparaciones = New System.Windows.Forms.Button()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnVentas)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCompras)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnArticulos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPedidos)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReparaciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnServicios)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 94)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(150, 630)
        Me.FlowLayoutPanel1.TabIndex = 32
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblUsuario, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1028, 94)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(884, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(141, 94)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(156, 307)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 102)
        Me.Panel1.TabIndex = 36
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EstadisticaProveedoresToolStripMenuItem, Me.EstadisticasDeComprasToolStripMenuItem, Me.EstadisticasDeVentasToolStripMenuItem, Me.EstadísitcasDeStockToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(204, 101)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(197, 19)
        Me.ToolStripMenuItem1.Text = "Estadisticas de Clientes"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstadisticaProveedoresToolStripMenuItem
        '
        Me.EstadisticaProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem})
        Me.EstadisticaProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadisticaProveedoresToolStripMenuItem.Name = "EstadisticaProveedoresToolStripMenuItem"
        Me.EstadisticaProveedoresToolStripMenuItem.Size = New System.Drawing.Size(197, 19)
        Me.EstadisticaProveedoresToolStripMenuItem.Text = "Estadisticas de Proveedores"
        Me.EstadisticaProveedoresToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EstadisticaProveedoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        Me.ServiciosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ServiciosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'EstadisticasDeComprasToolStripMenuItem
        '
        Me.EstadisticasDeComprasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadisticasDeComprasToolStripMenuItem.Name = "EstadisticasDeComprasToolStripMenuItem"
        Me.EstadisticasDeComprasToolStripMenuItem.Size = New System.Drawing.Size(197, 19)
        Me.EstadisticasDeComprasToolStripMenuItem.Text = "Estadisticas de Compras"
        Me.EstadisticasDeComprasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstadisticasDeVentasToolStripMenuItem
        '
        Me.EstadisticasDeVentasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadisticasDeVentasToolStripMenuItem.Name = "EstadisticasDeVentasToolStripMenuItem"
        Me.EstadisticasDeVentasToolStripMenuItem.Size = New System.Drawing.Size(197, 19)
        Me.EstadisticasDeVentasToolStripMenuItem.Text = "Estadisticas de Ventas"
        Me.EstadisticasDeVentasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstadísitcasDeStockToolStripMenuItem
        '
        Me.EstadísitcasDeStockToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadísitcasDeStockToolStripMenuItem.Name = "EstadísitcasDeStockToolStripMenuItem"
        Me.EstadísitcasDeStockToolStripMenuItem.Size = New System.Drawing.Size(197, 19)
        Me.EstadísitcasDeStockToolStripMenuItem.Text = "Estadísitcas de Stock"
        Me.EstadísitcasDeStockToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip2)
        Me.Panel2.Location = New System.Drawing.Point(156, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 40)
        Me.Panel2.TabIndex = 38
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(204, 44)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(197, 19)
        Me.ToolStripMenuItem2.Text = "Cerrar Caja"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(197, 19)
        Me.ToolStripMenuItem3.Text = "Historial de Cierres de Caja"
        Me.ToolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Location = New System.Drawing.Point(159, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(866, 205)
        Me.Panel3.TabIndex = 40
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(156, 433)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(866, 279)
        Me.Panel4.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 40)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Clientes"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 45)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 40)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Proveedores"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(3, 87)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(147, 40)
        Me.btnVentas.TabIndex = 16
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(3, 129)
        Me.btnCompras.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(147, 40)
        Me.btnCompras.TabIndex = 17
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnArticulos
        '
        Me.btnArticulos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.Image = CType(resources.GetObject("btnArticulos.Image"), System.Drawing.Image)
        Me.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArticulos.Location = New System.Drawing.Point(3, 171)
        Me.btnArticulos.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(147, 40)
        Me.btnArticulos.TabIndex = 18
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArticulos.UseVisualStyleBackColor = False
        '
        'btnPedidos
        '
        Me.btnPedidos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPedidos.FlatAppearance.BorderSize = 0
        Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.Image = CType(resources.GetObject("btnPedidos.Image"), System.Drawing.Image)
        Me.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedidos.Location = New System.Drawing.Point(3, 213)
        Me.btnPedidos.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(147, 40)
        Me.btnPedidos.TabIndex = 20
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPedidos.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(3, 255)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(147, 40)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "Estadisticas "
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 297)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 40)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Cierre Caja"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(3, 339)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(147, 40)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "Stock"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 381)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 40)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Catalogo"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnReparaciones
        '
        Me.btnReparaciones.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReparaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReparaciones.FlatAppearance.BorderSize = 0
        Me.btnReparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReparaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReparaciones.Image = CType(resources.GetObject("btnReparaciones.Image"), System.Drawing.Image)
        Me.btnReparaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReparaciones.Location = New System.Drawing.Point(3, 423)
        Me.btnReparaciones.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.btnReparaciones.Name = "btnReparaciones"
        Me.btnReparaciones.Size = New System.Drawing.Size(147, 40)
        Me.btnReparaciones.TabIndex = 32
        Me.btnReparaciones.Text = "Reparaciones"
        Me.btnReparaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReparaciones.UseVisualStyleBackColor = False
        '
        'btnServicios
        '
        Me.btnServicios.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnServicios.FlatAppearance.BorderSize = 0
        Me.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicios.Image = CType(resources.GetObject("btnServicios.Image"), System.Drawing.Image)
        Me.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServicios.Location = New System.Drawing.Point(3, 465)
        Me.btnServicios.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(147, 40)
        Me.btnServicios.TabIndex = 34
        Me.btnServicios.Text = "Pagos"
        Me.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnServicios.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(3, 507)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 40)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Usuarios"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 549)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 40)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "SALIR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClaseUi.My.Resources.Resources.LogoCrizolPSPequeño
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 88)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1028, 724)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "MDIPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPedidos As Windows.Forms.Button
    Friend WithEvents btnArticulos As Windows.Forms.Button
    Friend WithEvents btnCompras As Windows.Forms.Button
    Friend WithEvents btnVentas As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUsuario As Windows.Forms.Label
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents btnReparaciones As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents btnServicios As Windows.Forms.Button
    Friend WithEvents Button6 As Windows.Forms.Button
    Friend WithEvents Button7 As Windows.Forms.Button
    Friend WithEvents ContextMenuStrip2 As Windows.Forms.ContextMenuStrip
    Friend WithEvents Button8 As Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticaProveedoresToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasDeComprasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasDeVentasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísitcasDeStockToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents MenuStrip2 As Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
