<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoArticulo
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboxIdCategoria = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.CboxIdMarca = New System.Windows.Forms.ComboBox()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.BtnAgregarCategoria = New System.Windows.Forms.Button()
        Me.BtnAgregarMarca = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 181)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 32)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Categoria"
        '
        'CboxIdCategoria
        '
        Me.CboxIdCategoria.BackColor = System.Drawing.Color.White
        Me.CboxIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxIdCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxIdCategoria.ForeColor = System.Drawing.Color.Black
        Me.CboxIdCategoria.FormattingEnabled = True
        Me.CboxIdCategoria.Location = New System.Drawing.Point(12, 228)
        Me.CboxIdCategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboxIdCategoria.Name = "CboxIdCategoria"
        Me.CboxIdCategoria.Size = New System.Drawing.Size(343, 36)
        Me.CboxIdCategoria.TabIndex = 84
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 513)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 55)
        Me.BtnCancelar.TabIndex = 81
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Location = New System.Drawing.Point(278, 513)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(250, 55)
        Me.BtnNuevo.TabIndex = 80
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(450, 377)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 32)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Codigo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 281)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 32)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Precio Venta"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPrecioVenta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioVenta.ForeColor = System.Drawing.Color.Black
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(450, 329)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(343, 32)
        Me.TxtPrecioVenta.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 376)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 32)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Stock"
        '
        'TxtStock
        '
        Me.TxtStock.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtStock.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.ForeColor = System.Drawing.Color.Black
        Me.TxtStock.Location = New System.Drawing.Point(12, 424)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(343, 32)
        Me.TxtStock.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(450, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 32)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.TxtDescripcion.Location = New System.Drawing.Point(450, 233)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(343, 32)
        Me.TxtDescripcion.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(450, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 32)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 280)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 32)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Precio Compra"
        '
        'TxtPrecioCompra
        '
        Me.TxtPrecioCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPrecioCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioCompra.ForeColor = System.Drawing.Color.Black
        Me.TxtPrecioCompra.Location = New System.Drawing.Point(12, 328)
        Me.TxtPrecioCompra.Name = "TxtPrecioCompra"
        Me.TxtPrecioCompra.Size = New System.Drawing.Size(343, 32)
        Me.TxtPrecioCompra.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 32)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Nombre"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(544, 513)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 55)
        Me.BtnGuardar.TabIndex = 66
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(12, 132)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(343, 32)
        Me.TxtNombre.TabIndex = 65
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.ForeColor = System.Drawing.Color.Black
        Me.TxtId.Location = New System.Drawing.Point(450, 425)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(343, 32)
        Me.TxtId.TabIndex = 64
        '
        'CboxIdMarca
        '
        Me.CboxIdMarca.BackColor = System.Drawing.Color.White
        Me.CboxIdMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxIdMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxIdMarca.ForeColor = System.Drawing.Color.Black
        Me.CboxIdMarca.FormattingEnabled = True
        Me.CboxIdMarca.Location = New System.Drawing.Point(450, 133)
        Me.CboxIdMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboxIdMarca.Name = "CboxIdMarca"
        Me.CboxIdMarca.Size = New System.Drawing.Size(343, 36)
        Me.CboxIdMarca.TabIndex = 63
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(219, 14)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(369, 45)
        Me.Lbltitle.TabIndex = 62
        Me.Lbltitle.Text = "Mantenimiento Articulo"
        '
        'BtnAgregarCategoria
        '
        Me.BtnAgregarCategoria.BackColor = System.Drawing.Color.White
        Me.BtnAgregarCategoria.FlatAppearance.BorderSize = 0
        Me.BtnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarCategoria.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregarCategoria.Image = Global.SGN.UI.Windows.My.Resources.Resources.addcircle32
        Me.BtnAgregarCategoria.Location = New System.Drawing.Point(130, 177)
        Me.BtnAgregarCategoria.Name = "BtnAgregarCategoria"
        Me.BtnAgregarCategoria.Size = New System.Drawing.Size(44, 41)
        Me.BtnAgregarCategoria.TabIndex = 87
        Me.BtnAgregarCategoria.UseVisualStyleBackColor = False
        '
        'BtnAgregarMarca
        '
        Me.BtnAgregarMarca.BackColor = System.Drawing.Color.White
        Me.BtnAgregarMarca.FlatAppearance.BorderSize = 0
        Me.BtnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarMarca.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregarMarca.Image = Global.SGN.UI.Windows.My.Resources.Resources.addcircle32
        Me.BtnAgregarMarca.Location = New System.Drawing.Point(528, 81)
        Me.BtnAgregarMarca.Name = "BtnAgregarMarca"
        Me.BtnAgregarMarca.Size = New System.Drawing.Size(44, 41)
        Me.BtnAgregarMarca.TabIndex = 86
        Me.BtnAgregarMarca.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmMantenimientoArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(806, 588)
        Me.Controls.Add(Me.BtnAgregarCategoria)
        Me.Controls.Add(Me.BtnAgregarMarca)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CboxIdCategoria)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtPrecioVenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPrecioCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.CboxIdMarca)
        Me.Controls.Add(Me.Lbltitle)
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoArticulo"
        Me.ShowIcon = False
        Me.Text = "Mantenimiento Articulo"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents CboxIdCategoria As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrecioCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CboxIdMarca As ComboBox
    Friend WithEvents Lbltitle As Label
    Friend WithEvents BtnAgregarMarca As Button
    Friend WithEvents BtnAgregarCategoria As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
