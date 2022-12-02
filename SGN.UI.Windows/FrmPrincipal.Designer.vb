<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnReparaciones = New System.Windows.Forms.Button()
        Me.PanelSubMenuCompras = New System.Windows.Forms.Panel()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnComprar = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.PanelSubMenuVentas = New System.Windows.Forms.Panel()
        Me.BtnReportesDeVentas = New System.Windows.Forms.Button()
        Me.BtnCotizar = New System.Windows.Forms.Button()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnClintes = New System.Windows.Forms.Button()
        Me.BtnDashBoard = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PboxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnTogleMenu = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.BtnMinimaze = New System.Windows.Forms.Button()
        Me.BtnMaximaze = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubMenuCompras.SuspendLayout()
        Me.PanelSubMenuVentas.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnReparaciones)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuCompras)
        Me.PanelMenu.Controls.Add(Me.BtnCompras)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuVentas)
        Me.PanelMenu.Controls.Add(Me.BtnVentas)
        Me.PanelMenu.Controls.Add(Me.BtnArticulos)
        Me.PanelMenu.Controls.Add(Me.BtnEmpleados)
        Me.PanelMenu.Controls.Add(Me.BtnClintes)
        Me.PanelMenu.Controls.Add(Me.BtnDashBoard)
        Me.PanelMenu.Controls.Add(Me.BtnLogOut)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(315, 1050)
        Me.PanelMenu.TabIndex = 0
        '
        'BtnReparaciones
        '
        Me.BtnReparaciones.BackColor = System.Drawing.Color.Transparent
        Me.BtnReparaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReparaciones.FlatAppearance.BorderSize = 0
        Me.BtnReparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReparaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReparaciones.Image = Global.SGN.UI.Windows.My.Resources.Resources.reparacion32
        Me.BtnReparaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReparaciones.Location = New System.Drawing.Point(0, 897)
        Me.BtnReparaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReparaciones.Name = "BtnReparaciones"
        Me.BtnReparaciones.Size = New System.Drawing.Size(315, 65)
        Me.BtnReparaciones.TabIndex = 19
        Me.BtnReparaciones.Tag = "Reparaciones"
        Me.BtnReparaciones.Text = "  Reparaciones"
        Me.BtnReparaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReparaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReparaciones.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCompras
        '
        Me.PanelSubMenuCompras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSubMenuCompras.Controls.Add(Me.BtnProveedores)
        Me.PanelSubMenuCompras.Controls.Add(Me.BtnComprar)
        Me.PanelSubMenuCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuCompras.Location = New System.Drawing.Point(0, 734)
        Me.PanelSubMenuCompras.Name = "PanelSubMenuCompras"
        Me.PanelSubMenuCompras.Size = New System.Drawing.Size(315, 163)
        Me.PanelSubMenuCompras.TabIndex = 18
        '
        'BtnProveedores
        '
        Me.BtnProveedores.BackColor = System.Drawing.Color.Transparent
        Me.BtnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProveedores.FlatAppearance.BorderSize = 0
        Me.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedores.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.Image = Global.SGN.UI.Windows.My.Resources.Resources.proveedor32
        Me.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedores.Location = New System.Drawing.Point(0, 65)
        Me.BtnProveedores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnProveedores.Size = New System.Drawing.Size(315, 65)
        Me.BtnProveedores.TabIndex = 12
        Me.BtnProveedores.Tag = "Proveedores"
        Me.BtnProveedores.Text = "  Proveedores"
        Me.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'BtnComprar
        '
        Me.BtnComprar.BackColor = System.Drawing.Color.Transparent
        Me.BtnComprar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnComprar.FlatAppearance.BorderSize = 0
        Me.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComprar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComprar.Image = Global.SGN.UI.Windows.My.Resources.Resources.compra32
        Me.BtnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComprar.Location = New System.Drawing.Point(0, 0)
        Me.BtnComprar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnComprar.Size = New System.Drawing.Size(315, 65)
        Me.BtnComprar.TabIndex = 11
        Me.BtnComprar.Tag = "Comprar"
        Me.BtnComprar.Text = "  Comprar"
        Me.BtnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnComprar.UseVisualStyleBackColor = False
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.Color.Transparent
        Me.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.Image = Global.SGN.UI.Windows.My.Resources.Resources.compra32
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(0, 669)
        Me.BtnCompras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(315, 65)
        Me.BtnCompras.TabIndex = 17
        Me.BtnCompras.Tag = "Compras"
        Me.BtnCompras.Text = "  Compras"
        Me.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'PanelSubMenuVentas
        '
        Me.PanelSubMenuVentas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSubMenuVentas.Controls.Add(Me.BtnReportesDeVentas)
        Me.PanelSubMenuVentas.Controls.Add(Me.BtnCotizar)
        Me.PanelSubMenuVentas.Controls.Add(Me.BtnVender)
        Me.PanelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuVentas.Location = New System.Drawing.Point(0, 462)
        Me.PanelSubMenuVentas.Name = "PanelSubMenuVentas"
        Me.PanelSubMenuVentas.Size = New System.Drawing.Size(315, 207)
        Me.PanelSubMenuVentas.TabIndex = 16
        '
        'BtnReportesDeVentas
        '
        Me.BtnReportesDeVentas.BackColor = System.Drawing.Color.Transparent
        Me.BtnReportesDeVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportesDeVentas.FlatAppearance.BorderSize = 0
        Me.BtnReportesDeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportesDeVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportesDeVentas.Image = Global.SGN.UI.Windows.My.Resources.Resources.report32
        Me.BtnReportesDeVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportesDeVentas.Location = New System.Drawing.Point(0, 130)
        Me.BtnReportesDeVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReportesDeVentas.Name = "BtnReportesDeVentas"
        Me.BtnReportesDeVentas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnReportesDeVentas.Size = New System.Drawing.Size(315, 65)
        Me.BtnReportesDeVentas.TabIndex = 13
        Me.BtnReportesDeVentas.Tag = "Reportes"
        Me.BtnReportesDeVentas.Text = "  Reportes"
        Me.BtnReportesDeVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportesDeVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReportesDeVentas.UseVisualStyleBackColor = False
        '
        'BtnCotizar
        '
        Me.BtnCotizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCotizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCotizar.FlatAppearance.BorderSize = 0
        Me.BtnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCotizar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCotizar.Image = Global.SGN.UI.Windows.My.Resources.Resources.cotizacion32
        Me.BtnCotizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCotizar.Location = New System.Drawing.Point(0, 65)
        Me.BtnCotizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCotizar.Name = "BtnCotizar"
        Me.BtnCotizar.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnCotizar.Size = New System.Drawing.Size(315, 65)
        Me.BtnCotizar.TabIndex = 12
        Me.BtnCotizar.Tag = "Cotizar"
        Me.BtnCotizar.Text = "  Cotizar"
        Me.BtnCotizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCotizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCotizar.UseVisualStyleBackColor = False
        '
        'BtnVender
        '
        Me.BtnVender.BackColor = System.Drawing.Color.Transparent
        Me.BtnVender.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVender.FlatAppearance.BorderSize = 0
        Me.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVender.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVender.Image = Global.SGN.UI.Windows.My.Resources.Resources.store32
        Me.BtnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVender.Location = New System.Drawing.Point(0, 0)
        Me.BtnVender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnVender.Size = New System.Drawing.Size(315, 65)
        Me.BtnVender.TabIndex = 11
        Me.BtnVender.Tag = "Vender"
        Me.BtnVender.Text = "  Vender"
        Me.BtnVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVender.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = Global.SGN.UI.Windows.My.Resources.Resources.store32
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 397)
        Me.BtnVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(315, 65)
        Me.BtnVentas.TabIndex = 15
        Me.BtnVentas.Tag = "Ventas"
        Me.BtnVentas.Text = "  Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'BtnArticulos
        '
        Me.BtnArticulos.BackColor = System.Drawing.Color.Transparent
        Me.BtnArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnArticulos.FlatAppearance.BorderSize = 0
        Me.BtnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArticulos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArticulos.Image = Global.SGN.UI.Windows.My.Resources.Resources.shelves32
        Me.BtnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnArticulos.Location = New System.Drawing.Point(0, 332)
        Me.BtnArticulos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(315, 65)
        Me.BtnArticulos.TabIndex = 14
        Me.BtnArticulos.Tag = "Articulos"
        Me.BtnArticulos.Text = "  Articulos"
        Me.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnArticulos.UseVisualStyleBackColor = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Image = Global.SGN.UI.Windows.My.Resources.Resources.work32
        Me.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.Location = New System.Drawing.Point(0, 267)
        Me.BtnEmpleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(315, 65)
        Me.BtnEmpleados.TabIndex = 9
        Me.BtnEmpleados.Tag = "Empleados"
        Me.BtnEmpleados.Text = "  Empleados"
        Me.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnClintes
        '
        Me.BtnClintes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClintes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnClintes.FlatAppearance.BorderSize = 0
        Me.BtnClintes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClintes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClintes.Image = Global.SGN.UI.Windows.My.Resources.Resources.cliente32
        Me.BtnClintes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClintes.Location = New System.Drawing.Point(0, 202)
        Me.BtnClintes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClintes.Name = "BtnClintes"
        Me.BtnClintes.Size = New System.Drawing.Size(315, 65)
        Me.BtnClintes.TabIndex = 8
        Me.BtnClintes.Tag = "Clientes"
        Me.BtnClintes.Text = "  Clientes"
        Me.BtnClintes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClintes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClintes.UseVisualStyleBackColor = False
        '
        'BtnDashBoard
        '
        Me.BtnDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashBoard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashBoard.FlatAppearance.BorderSize = 0
        Me.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashBoard.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashBoard.Image = Global.SGN.UI.Windows.My.Resources.Resources.chart32
        Me.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.Location = New System.Drawing.Point(0, 137)
        Me.BtnDashBoard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDashBoard.Name = "BtnDashBoard"
        Me.BtnDashBoard.Size = New System.Drawing.Size(315, 65)
        Me.BtnDashBoard.TabIndex = 7
        Me.BtnDashBoard.Tag = "DashBoard"
        Me.BtnDashBoard.Text = "  DashBoard"
        Me.BtnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashBoard.UseVisualStyleBackColor = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogOut.FlatAppearance.BorderSize = 0
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.Image = CType(resources.GetObject("BtnLogOut.Image"), System.Drawing.Image)
        Me.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogOut.Location = New System.Drawing.Point(0, 981)
        Me.BtnLogOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(315, 69)
        Me.BtnLogOut.TabIndex = 6
        Me.BtnLogOut.Tag = "Salir"
        Me.BtnLogOut.Text = "  Salir"
        Me.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.PboxLogo)
        Me.PanelLogo.Controls.Add(Me.BtnTogleMenu)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(315, 137)
        Me.PanelLogo.TabIndex = 0
        '
        'PboxLogo
        '
        Me.PboxLogo.Image = Global.SGN.UI.Windows.My.Resources.Resources.logo
        Me.PboxLogo.Location = New System.Drawing.Point(15, 12)
        Me.PboxLogo.Name = "PboxLogo"
        Me.PboxLogo.Size = New System.Drawing.Size(230, 111)
        Me.PboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxLogo.TabIndex = 8
        Me.PboxLogo.TabStop = False
        '
        'BtnTogleMenu
        '
        Me.BtnTogleMenu.FlatAppearance.BorderSize = 0
        Me.BtnTogleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTogleMenu.Image = Global.SGN.UI.Windows.My.Resources.Resources.menu32
        Me.BtnTogleMenu.Location = New System.Drawing.Point(254, 88)
        Me.BtnTogleMenu.Name = "BtnTogleMenu"
        Me.BtnTogleMenu.Size = New System.Drawing.Size(52, 40)
        Me.BtnTogleMenu.TabIndex = 0
        Me.BtnTogleMenu.UseVisualStyleBackColor = True
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.White
        Me.PanelTitulo.Controls.Add(Me.Lbltitle)
        Me.PanelTitulo.Controls.Add(Me.BtnMinimaze)
        Me.PanelTitulo.Controls.Add(Me.BtnMaximaze)
        Me.PanelTitulo.Controls.Add(Me.BtnClose)
        Me.PanelTitulo.Controls.Add(Me.LblUser)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(315, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1340, 55)
        Me.PanelTitulo.TabIndex = 1
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(9, 14)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(70, 28)
        Me.Lbltitle.TabIndex = 1
        Me.Lbltitle.Text = "HOME"
        '
        'BtnMinimaze
        '
        Me.BtnMinimaze.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimaze.FlatAppearance.BorderSize = 0
        Me.BtnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimaze.Image = Global.SGN.UI.Windows.My.Resources.Resources.minimize32
        Me.BtnMinimaze.Location = New System.Drawing.Point(1195, 3)
        Me.BtnMinimaze.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMinimaze.Name = "BtnMinimaze"
        Me.BtnMinimaze.Size = New System.Drawing.Size(38, 38)
        Me.BtnMinimaze.TabIndex = 1
        Me.BtnMinimaze.UseVisualStyleBackColor = True
        '
        'BtnMaximaze
        '
        Me.BtnMaximaze.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximaze.FlatAppearance.BorderSize = 0
        Me.BtnMaximaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximaze.Image = CType(resources.GetObject("BtnMaximaze.Image"), System.Drawing.Image)
        Me.BtnMaximaze.Location = New System.Drawing.Point(1245, 3)
        Me.BtnMaximaze.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMaximaze.Name = "BtnMaximaze"
        Me.BtnMaximaze.Size = New System.Drawing.Size(38, 38)
        Me.BtnMaximaze.TabIndex = 1
        Me.BtnMaximaze.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.SGN.UI.Windows.My.Resources.Resources.close32
        Me.BtnClose.Location = New System.Drawing.Point(1297, 3)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(38, 38)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(889, 14)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(81, 28)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "Usuario"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.White
        Me.PanelDesktop.Controls.Add(Me.LblHora)
        Me.PanelDesktop.Controls.Add(Me.LblFecha)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(315, 55)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1340, 995)
        Me.PanelDesktop.TabIndex = 2
        '
        'LblHora
        '
        Me.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(534, 514)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(273, 54)
        Me.LblHora.TabIndex = 3
        Me.LblHora.Text = "00:00:00 a. m."
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(326, 426)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(689, 60)
        Me.LblFecha.TabIndex = 2
        Me.LblFecha.Text = "Viernes, 11 de noviembre de 2022"
        Me.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1655, 1050)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashBoard"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubMenuCompras.ResumeLayout(False)
        Me.PanelSubMenuVentas.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents BtnTogleMenu As Button
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMaximaze As Button
    Friend WithEvents BtnMinimaze As Button
    Friend WithEvents Lbltitle As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LblUser As Label
    Friend WithEvents PboxLogo As PictureBox
    Friend WithEvents BtnReparaciones As Button
    Friend WithEvents PanelSubMenuCompras As Panel
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents BtnComprar As Button
    Friend WithEvents BtnCompras As Button
    Friend WithEvents PanelSubMenuVentas As Panel
    Friend WithEvents BtnCotizar As Button
    Friend WithEvents BtnVender As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnArticulos As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnClintes As Button
    Friend WithEvents BtnDashBoard As Button
    Friend WithEvents BtnReportesDeVentas As Button
End Class
