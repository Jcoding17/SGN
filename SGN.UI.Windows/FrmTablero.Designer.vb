<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTablero
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCantClientes = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblCantProveedores = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblCantCompras = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LblCantEmpleados = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblCantVentas = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LblCantArticulos = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LblCantCotizaciones = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LblCantReparaciones = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 71)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblCantClientes)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(52, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 130)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "a dia de hoy"
        '
        'LblCantClientes
        '
        Me.LblCantClientes.AutoSize = True
        Me.LblCantClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantClientes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantClientes.Location = New System.Drawing.Point(267, 54)
        Me.LblCantClientes.Name = "LblCantClientes"
        Me.LblCantClientes.Size = New System.Drawing.Size(42, 32)
        Me.LblCantClientes.TabIndex = 4
        Me.LblCantClientes.Text = "12"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LblCantProveedores)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(776, 245)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 130)
        Me.Panel3.TabIndex = 5
        '
        'LblCantProveedores
        '
        Me.LblCantProveedores.AutoSize = True
        Me.LblCantProveedores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantProveedores.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantProveedores.Location = New System.Drawing.Point(267, 54)
        Me.LblCantProveedores.Name = "LblCantProveedores"
        Me.LblCantProveedores.Size = New System.Drawing.Size(42, 32)
        Me.LblCantProveedores.TabIndex = 4
        Me.LblCantProveedores.Text = "12"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(9, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "a dia de hoy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(9, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 38)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Proveedores"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LblCantCompras)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(52, 245)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(327, 130)
        Me.Panel4.TabIndex = 6
        '
        'LblCantCompras
        '
        Me.LblCantCompras.AutoSize = True
        Me.LblCantCompras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantCompras.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantCompras.Location = New System.Drawing.Point(267, 54)
        Me.LblCantCompras.Name = "LblCantCompras"
        Me.LblCantCompras.Size = New System.Drawing.Size(42, 32)
        Me.LblCantCompras.TabIndex = 4
        Me.LblCantCompras.Text = "12"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(9, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 28)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "a dia de hoy"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(9, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 38)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Compras"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Controls.Add(Me.LblCantEmpleados)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Location = New System.Drawing.Point(414, 93)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(327, 130)
        Me.Panel5.TabIndex = 7
        '
        'LblCantEmpleados
        '
        Me.LblCantEmpleados.AutoSize = True
        Me.LblCantEmpleados.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantEmpleados.Location = New System.Drawing.Point(267, 54)
        Me.LblCantEmpleados.Name = "LblCantEmpleados"
        Me.LblCantEmpleados.Size = New System.Drawing.Size(42, 32)
        Me.LblCantEmpleados.TabIndex = 4
        Me.LblCantEmpleados.Text = "12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(9, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 28)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "a dia de hoy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(9, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 38)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Empleados"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel6.Controls.Add(Me.LblCantVentas)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Location = New System.Drawing.Point(776, 93)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(327, 130)
        Me.Panel6.TabIndex = 8
        '
        'LblCantVentas
        '
        Me.LblCantVentas.AutoSize = True
        Me.LblCantVentas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantVentas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantVentas.Location = New System.Drawing.Point(267, 54)
        Me.LblCantVentas.Name = "LblCantVentas"
        Me.LblCantVentas.Size = New System.Drawing.Size(42, 32)
        Me.LblCantVentas.TabIndex = 4
        Me.LblCantVentas.Text = "12"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(9, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 28)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "a dia de hoy"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(9, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 38)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Ventas"
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LblCantArticulos)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Location = New System.Drawing.Point(414, 245)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(327, 130)
        Me.Panel7.TabIndex = 9
        '
        'LblCantArticulos
        '
        Me.LblCantArticulos.AutoSize = True
        Me.LblCantArticulos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantArticulos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantArticulos.Location = New System.Drawing.Point(267, 54)
        Me.LblCantArticulos.Name = "LblCantArticulos"
        Me.LblCantArticulos.Size = New System.Drawing.Size(42, 32)
        Me.LblCantArticulos.TabIndex = 4
        Me.LblCantArticulos.Text = "12"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(9, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 28)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "a dia de hoy"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(9, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(144, 38)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Articulos"
        '
        'Panel8
        '
        Me.Panel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel8.Controls.Add(Me.LblCantCotizaciones)
        Me.Panel8.Controls.Add(Me.Label20)
        Me.Panel8.Controls.Add(Me.Label21)
        Me.Panel8.Location = New System.Drawing.Point(236, 402)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(327, 130)
        Me.Panel8.TabIndex = 10
        '
        'LblCantCotizaciones
        '
        Me.LblCantCotizaciones.AutoSize = True
        Me.LblCantCotizaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantCotizaciones.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantCotizaciones.Location = New System.Drawing.Point(267, 54)
        Me.LblCantCotizaciones.Name = "LblCantCotizaciones"
        Me.LblCantCotizaciones.Size = New System.Drawing.Size(42, 32)
        Me.LblCantCotizaciones.TabIndex = 4
        Me.LblCantCotizaciones.Text = "12"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(9, 92)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 28)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "a dia de hoy"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Location = New System.Drawing.Point(9, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(193, 38)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Cotizaciones"
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel9.Controls.Add(Me.LblCantReparaciones)
        Me.Panel9.Controls.Add(Me.Label23)
        Me.Panel9.Controls.Add(Me.Label24)
        Me.Panel9.Location = New System.Drawing.Point(597, 402)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(327, 130)
        Me.Panel9.TabIndex = 11
        '
        'LblCantReparaciones
        '
        Me.LblCantReparaciones.AutoSize = True
        Me.LblCantReparaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantReparaciones.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblCantReparaciones.Location = New System.Drawing.Point(267, 54)
        Me.LblCantReparaciones.Name = "LblCantReparaciones"
        Me.LblCantReparaciones.Size = New System.Drawing.Size(42, 32)
        Me.LblCantReparaciones.TabIndex = 4
        Me.LblCantReparaciones.Text = "12"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(9, 92)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 28)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "a dia de hoy"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(9, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(203, 38)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Reparaciones"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(469, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(223, 45)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "DASHBOARD"
        '
        'FrmTablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1160, 590)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTablero"
        Me.Text = "Tablero"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblCantClientes As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblCantProveedores As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblCantCompras As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblCantEmpleados As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblCantVentas As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LblCantArticulos As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents LblCantCotizaciones As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents LblCantReparaciones As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
End Class
