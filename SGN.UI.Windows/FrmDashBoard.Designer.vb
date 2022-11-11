<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashBoard))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnReparaciones = New System.Windows.Forms.Button()
        Me.BtnCotizaciones = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnDashBoard = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.BtnTogleMenu = New System.Windows.Forms.Button()
        Me.LblLogo = New System.Windows.Forms.Label()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.BtnMinimaze = New System.Windows.Forms.Button()
        Me.BtnMaximaze = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.BtnLogOut)
        Me.PanelMenu.Controls.Add(Me.BtnReparaciones)
        Me.PanelMenu.Controls.Add(Me.BtnCotizaciones)
        Me.PanelMenu.Controls.Add(Me.BtnCompras)
        Me.PanelMenu.Controls.Add(Me.BtnVentas)
        Me.PanelMenu.Controls.Add(Me.BtnEmpleados)
        Me.PanelMenu.Controls.Add(Me.BtnClientes)
        Me.PanelMenu.Controls.Add(Me.BtnDashBoard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(315, 900)
        Me.PanelMenu.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SGN.UI.Windows.My.Resources.Resources.proveedor32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1, 394)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(314, 69)
        Me.Button1.TabIndex = 7
        Me.Button1.Tag = "Empleados"
        Me.Button1.Text = "  Proveedores"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.FlatAppearance.BorderSize = 0
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.Image = CType(resources.GetObject("BtnLogOut.Image"), System.Drawing.Image)
        Me.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogOut.Location = New System.Drawing.Point(1, 829)
        Me.BtnLogOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(314, 69)
        Me.BtnLogOut.TabIndex = 6
        Me.BtnLogOut.Tag = "Salir"
        Me.BtnLogOut.Text = "  Salir"
        Me.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'BtnReparaciones
        '
        Me.BtnReparaciones.BackColor = System.Drawing.Color.Transparent
        Me.BtnReparaciones.FlatAppearance.BorderSize = 0
        Me.BtnReparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReparaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReparaciones.Image = CType(resources.GetObject("BtnReparaciones.Image"), System.Drawing.Image)
        Me.BtnReparaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReparaciones.Location = New System.Drawing.Point(1, 742)
        Me.BtnReparaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReparaciones.Name = "BtnReparaciones"
        Me.BtnReparaciones.Size = New System.Drawing.Size(314, 69)
        Me.BtnReparaciones.TabIndex = 2
        Me.BtnReparaciones.Tag = "Reparaciones"
        Me.BtnReparaciones.Text = "  Reparaciones"
        Me.BtnReparaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReparaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReparaciones.UseVisualStyleBackColor = False
        '
        'BtnCotizaciones
        '
        Me.BtnCotizaciones.BackColor = System.Drawing.Color.Transparent
        Me.BtnCotizaciones.FlatAppearance.BorderSize = 0
        Me.BtnCotizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCotizaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCotizaciones.Image = CType(resources.GetObject("BtnCotizaciones.Image"), System.Drawing.Image)
        Me.BtnCotizaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCotizaciones.Location = New System.Drawing.Point(1, 655)
        Me.BtnCotizaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCotizaciones.Name = "BtnCotizaciones"
        Me.BtnCotizaciones.Size = New System.Drawing.Size(314, 69)
        Me.BtnCotizaciones.TabIndex = 5
        Me.BtnCotizaciones.Tag = "Cotizaciones"
        Me.BtnCotizaciones.Text = "  Cotizaciones"
        Me.BtnCotizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCotizaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCotizaciones.UseVisualStyleBackColor = False
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.Color.Transparent
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.Image = CType(resources.GetObject("BtnCompras.Image"), System.Drawing.Image)
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(1, 568)
        Me.BtnCompras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(314, 69)
        Me.BtnCompras.TabIndex = 4
        Me.BtnCompras.Tag = "Compras"
        Me.BtnCompras.Text = "  Compras"
        Me.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(1, 481)
        Me.BtnVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(314, 69)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Tag = "Ventas"
        Me.BtnVentas.Text = "  Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Image = CType(resources.GetObject("BtnEmpleados.Image"), System.Drawing.Image)
        Me.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.Location = New System.Drawing.Point(1, 307)
        Me.BtnEmpleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(314, 69)
        Me.BtnEmpleados.TabIndex = 2
        Me.BtnEmpleados.Tag = "Empleados"
        Me.BtnEmpleados.Text = "  Empleados"
        Me.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(1, 220)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(314, 69)
        Me.BtnClientes.TabIndex = 1
        Me.BtnClientes.Tag = "Clientes"
        Me.BtnClientes.Text = "  Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnDashBoard
        '
        Me.BtnDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashBoard.FlatAppearance.BorderSize = 0
        Me.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashBoard.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashBoard.Image = CType(resources.GetObject("BtnDashBoard.Image"), System.Drawing.Image)
        Me.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.Location = New System.Drawing.Point(1, 133)
        Me.BtnDashBoard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDashBoard.Name = "BtnDashBoard"
        Me.BtnDashBoard.Size = New System.Drawing.Size(314, 69)
        Me.BtnDashBoard.TabIndex = 0
        Me.BtnDashBoard.Tag = "Dashboard"
        Me.BtnDashBoard.Text = "  Dashboard"
        Me.BtnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashBoard.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.BtnTogleMenu)
        Me.PanelLogo.Controls.Add(Me.LblLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(315, 115)
        Me.PanelLogo.TabIndex = 0
        '
        'BtnTogleMenu
        '
        Me.BtnTogleMenu.FlatAppearance.BorderSize = 0
        Me.BtnTogleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTogleMenu.Image = Global.SGN.UI.Windows.My.Resources.Resources.menu32
        Me.BtnTogleMenu.Location = New System.Drawing.Point(254, 68)
        Me.BtnTogleMenu.Name = "BtnTogleMenu"
        Me.BtnTogleMenu.Size = New System.Drawing.Size(52, 40)
        Me.BtnTogleMenu.TabIndex = 0
        Me.BtnTogleMenu.UseVisualStyleBackColor = True
        '
        'LblLogo
        '
        Me.LblLogo.AutoSize = True
        Me.LblLogo.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogo.Location = New System.Drawing.Point(10, 18)
        Me.LblLogo.Name = "LblLogo"
        Me.LblLogo.Size = New System.Drawing.Size(105, 45)
        Me.LblLogo.TabIndex = 0
        Me.LblLogo.Text = "Logo."
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.White
        Me.PanelTitulo.Controls.Add(Me.LblUser)
        Me.PanelTitulo.Controls.Add(Me.Lbltitle)
        Me.PanelTitulo.Controls.Add(Me.BtnMinimaze)
        Me.PanelTitulo.Controls.Add(Me.BtnMaximaze)
        Me.PanelTitulo.Controls.Add(Me.BtnClose)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(315, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1340, 55)
        Me.PanelTitulo.TabIndex = 1
        '
        'LblUser
        '
        Me.LblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(1093, 14)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(53, 28)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "User"
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
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.White
        Me.PanelDesktop.Controls.Add(Me.LblHora)
        Me.PanelDesktop.Controls.Add(Me.LblFecha)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(315, 55)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1340, 845)
        Me.PanelDesktop.TabIndex = 2
        '
        'LblHora
        '
        Me.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(534, 439)
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
        Me.LblFecha.Location = New System.Drawing.Point(326, 351)
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
        'FrmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1655, 900)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashBoard"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LblLogo As Label
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents BtnTogleMenu As Button
    Friend WithEvents BtnDashBoard As Button
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents BtnReparaciones As Button
    Friend WithEvents BtnCotizaciones As Button
    Friend WithEvents BtnCompras As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMaximaze As Button
    Friend WithEvents BtnMinimaze As Button
    Friend WithEvents Lbltitle As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LblUser As Label
    Friend WithEvents Button1 As Button
End Class
