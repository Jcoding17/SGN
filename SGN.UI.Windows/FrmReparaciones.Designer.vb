<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReparaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReparaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ReparacionesTabs = New System.Windows.Forms.TabControl()
        Me.TabReparaciones = New System.Windows.Forms.TabPage()
        Me.BtnReparado = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnNueva = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.DgvReparaciones = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTecnico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCobrar = New System.Windows.Forms.TabPage()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBuscarReparacion = New System.Windows.Forms.Button()
        Me.TxtDescuentoArticulo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodigoDetReparacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTecnico = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCodigoTecnico = New System.Windows.Forms.TextBox()
        Me.DtpFechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtCodigoReparacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ReparacionesTabs.SuspendLayout()
        Me.TabReparaciones.SuspendLayout()
        CType(Me.DgvReparaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCobrar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReparacionesTabs
        '
        Me.ReparacionesTabs.Controls.Add(Me.TabReparaciones)
        Me.ReparacionesTabs.Controls.Add(Me.TabCobrar)
        Me.ReparacionesTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReparacionesTabs.Location = New System.Drawing.Point(0, 0)
        Me.ReparacionesTabs.Name = "ReparacionesTabs"
        Me.ReparacionesTabs.SelectedIndex = 0
        Me.ReparacionesTabs.Size = New System.Drawing.Size(1341, 887)
        Me.ReparacionesTabs.TabIndex = 0
        '
        'TabReparaciones
        '
        Me.TabReparaciones.Controls.Add(Me.BtnReparado)
        Me.TabReparaciones.Controls.Add(Me.TxtBuscar)
        Me.TabReparaciones.Controls.Add(Me.BtnNueva)
        Me.TabReparaciones.Controls.Add(Me.BtnBuscar)
        Me.TabReparaciones.Controls.Add(Me.Lbltitle)
        Me.TabReparaciones.Controls.Add(Me.DgvReparaciones)
        Me.TabReparaciones.Location = New System.Drawing.Point(4, 29)
        Me.TabReparaciones.Name = "TabReparaciones"
        Me.TabReparaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReparaciones.Size = New System.Drawing.Size(1333, 854)
        Me.TabReparaciones.TabIndex = 0
        Me.TabReparaciones.Text = "Reparaciones"
        Me.TabReparaciones.UseVisualStyleBackColor = True
        '
        'BtnReparado
        '
        Me.BtnReparado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnReparado.BackColor = System.Drawing.Color.Transparent
        Me.BtnReparado.FlatAppearance.BorderSize = 0
        Me.BtnReparado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReparado.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReparado.Image = CType(resources.GetObject("BtnReparado.Image"), System.Drawing.Image)
        Me.BtnReparado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReparado.Location = New System.Drawing.Point(1099, 379)
        Me.BtnReparado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReparado.Name = "BtnReparado"
        Me.BtnReparado.Size = New System.Drawing.Size(190, 70)
        Me.BtnReparado.TabIndex = 42
        Me.BtnReparado.Tag = ""
        Me.BtnReparado.Text = "  Reparado"
        Me.BtnReparado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReparado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReparado.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.Black
        Me.TxtBuscar.Location = New System.Drawing.Point(123, 33)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(791, 38)
        Me.TxtBuscar.TabIndex = 41
        '
        'BtnNueva
        '
        Me.BtnNueva.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnNueva.BackColor = System.Drawing.Color.Transparent
        Me.BtnNueva.FlatAppearance.BorderSize = 0
        Me.BtnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNueva.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNueva.Image = CType(resources.GetObject("BtnNueva.Image"), System.Drawing.Image)
        Me.BtnNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNueva.Location = New System.Drawing.Point(1099, 259)
        Me.BtnNueva.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNueva.Name = "BtnNueva"
        Me.BtnNueva.Size = New System.Drawing.Size(190, 70)
        Me.BtnNueva.TabIndex = 40
        Me.BtnNueva.Tag = ""
        Me.BtnNueva.Text = "  Nueva"
        Me.BtnNueva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNueva.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Enabled = False
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.SGN.UI.Windows.My.Resources.Resources.buscar32
        Me.BtnBuscar.Location = New System.Drawing.Point(924, 29)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(48, 49)
        Me.BtnBuscar.TabIndex = 39
        Me.BtnBuscar.Tag = ""
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(20, 36)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(86, 32)
        Me.Lbltitle.TabIndex = 38
        Me.Lbltitle.Text = "Buscar"
        '
        'DgvReparaciones
        '
        Me.DgvReparaciones.AllowUserToAddRows = False
        Me.DgvReparaciones.AllowUserToDeleteRows = False
        Me.DgvReparaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvReparaciones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgvReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReparaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.IDCliente, Me.IDTecnico, Me.FechaEntrada, Me.PrecioVenta, Me.Descripcion, Me.Estado})
        Me.DgvReparaciones.Location = New System.Drawing.Point(22, 103)
        Me.DgvReparaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvReparaciones.Name = "DgvReparaciones"
        Me.DgvReparaciones.ReadOnly = True
        Me.DgvReparaciones.RowHeadersWidth = 62
        Me.DgvReparaciones.Size = New System.Drawing.Size(1034, 494)
        Me.DgvReparaciones.TabIndex = 37
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        'IDCliente
        '
        Me.IDCliente.DataPropertyName = "IdCliente"
        Me.IDCliente.HeaderText = "Cliente"
        Me.IDCliente.MinimumWidth = 8
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.ReadOnly = True
        Me.IDCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDCliente.Width = 150
        '
        'IDTecnico
        '
        Me.IDTecnico.DataPropertyName = "IdEmpleado"
        Me.IDTecnico.HeaderText = "Tecnico"
        Me.IDTecnico.MinimumWidth = 8
        Me.IDTecnico.Name = "IDTecnico"
        Me.IDTecnico.ReadOnly = True
        Me.IDTecnico.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDTecnico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDTecnico.Width = 150
        '
        'FechaEntrada
        '
        Me.FechaEntrada.DataPropertyName = "FechaEntrada"
        DataGridViewCellStyle1.Format = "g"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaEntrada.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaEntrada.HeaderText = "Fecha de entrada"
        Me.FechaEntrada.MinimumWidth = 8
        Me.FechaEntrada.Name = "FechaEntrada"
        Me.FechaEntrada.ReadOnly = True
        Me.FechaEntrada.Width = 170
        '
        'PrecioVenta
        '
        Me.PrecioVenta.DataPropertyName = "FechaSalida"
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PrecioVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioVenta.HeaderText = "Fecha de salida"
        Me.PrecioVenta.MinimumWidth = 8
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.ReadOnly = True
        Me.PrecioVenta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrecioVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PrecioVenta.Width = 150
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 8
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 150
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 8
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 150
        '
        'TabCobrar
        '
        Me.TabCobrar.Controls.Add(Me.BtnNuevo)
        Me.TabCobrar.Controls.Add(Me.BtnGuardar)
        Me.TabCobrar.Controls.Add(Me.BtnCancelar)
        Me.TabCobrar.Controls.Add(Me.TxtTotal)
        Me.TabCobrar.Controls.Add(Me.Label16)
        Me.TabCobrar.Controls.Add(Me.TxtDescuento)
        Me.TabCobrar.Controls.Add(Me.Label18)
        Me.TabCobrar.Controls.Add(Me.TxtSubTotal)
        Me.TabCobrar.Controls.Add(Me.Label19)
        Me.TabCobrar.Controls.Add(Me.DataGridView1)
        Me.TabCobrar.Controls.Add(Me.GroupBox3)
        Me.TabCobrar.Controls.Add(Me.GroupBox2)
        Me.TabCobrar.Controls.Add(Me.GroupBox1)
        Me.TabCobrar.Location = New System.Drawing.Point(4, 29)
        Me.TabCobrar.Name = "TabCobrar"
        Me.TabCobrar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCobrar.Size = New System.Drawing.Size(1333, 854)
        Me.TabCobrar.TabIndex = 1
        Me.TabCobrar.Text = "Cobrar"
        Me.TabCobrar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Location = New System.Drawing.Point(6, 780)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(110, 65)
        Me.BtnNuevo.TabIndex = 42
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(122, 780)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(110, 65)
        Me.BtnGuardar.TabIndex = 41
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(238, 780)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 65)
        Me.BtnCancelar.TabIndex = 40
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(1208, 807)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(98, 31)
        Me.TxtTotal.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1208, 775)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 25)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Total"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuento.Location = New System.Drawing.Point(1037, 807)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(98, 31)
        Me.TxtDescuento.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1037, 775)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 25)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Descuento"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.Location = New System.Drawing.Point(879, 807)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(98, 31)
        Me.TxtSubTotal.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(879, 775)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 25)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Sub Total"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Articulo, Me.Cantidad, Me.DescripcionDet, Me.Precio, Me.Subtotal, Me.Descuento})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 485)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1312, 275)
        Me.DataGridView1.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle3.Format = "N0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.MinimumWidth = 8
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Articulo.Width = 200
        '
        'Cantidad
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 8
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 111
        '
        'DescripcionDet
        '
        Me.DescripcionDet.HeaderText = "Descripcion"
        Me.DescripcionDet.MinimumWidth = 8
        Me.DescripcionDet.Name = "DescripcionDet"
        Me.DescripcionDet.ReadOnly = True
        Me.DescripcionDet.Width = 200
        '
        'Precio
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle5
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 8
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 150
        '
        'Subtotal
        '
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.Subtotal.HeaderText = "Sub Total"
        Me.Subtotal.MinimumWidth = 8
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 150
        '
        'Descuento
        '
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Descuento.DefaultCellStyle = DataGridViewCellStyle7
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.MinimumWidth = 8
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox3.Controls.Add(Me.BtnAgregar)
        Me.GroupBox3.Controls.Add(Me.BtnBuscarReparacion)
        Me.GroupBox3.Controls.Add(Me.TxtDescuentoArticulo)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtPrecio)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtArticulo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtCodigoDetReparacion)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 365)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1312, 108)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de la Reparacion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(481, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 25)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(477, 53)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(221, 31)
        Me.TxtDescripcion.TabIndex = 17
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(1115, 26)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(110, 65)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnBuscarReparacion
        '
        Me.BtnBuscarReparacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnBuscarReparacion.FlatAppearance.BorderSize = 0
        Me.BtnBuscarReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarReparacion.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarReparacion.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarReparacion.Location = New System.Drawing.Point(991, 26)
        Me.BtnBuscarReparacion.Name = "BtnBuscarReparacion"
        Me.BtnBuscarReparacion.Size = New System.Drawing.Size(110, 65)
        Me.BtnBuscarReparacion.TabIndex = 7
        Me.BtnBuscarReparacion.Text = "Buscar"
        Me.BtnBuscarReparacion.UseVisualStyleBackColor = False
        '
        'TxtDescuentoArticulo
        '
        Me.TxtDescuentoArticulo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoArticulo.Location = New System.Drawing.Point(824, 53)
        Me.TxtDescuentoArticulo.Name = "TxtDescuentoArticulo"
        Me.TxtDescuentoArticulo.Size = New System.Drawing.Size(98, 31)
        Me.TxtDescuentoArticulo.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(825, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Descuento"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(712, 53)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(98, 31)
        Me.TxtCantidad.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(708, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(365, 53)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(98, 31)
        Me.TxtPrecio.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(367, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Precio"
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArticulo.Location = New System.Drawing.Point(130, 53)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(221, 31)
        Me.TxtArticulo.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Articulo"
        '
        'TxtCodigoDetReparacion
        '
        Me.TxtCodigoDetReparacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoDetReparacion.Location = New System.Drawing.Point(18, 53)
        Me.TxtCodigoDetReparacion.Name = "TxtCodigoDetReparacion"
        Me.TxtCodigoDetReparacion.ReadOnly = True
        Me.TxtCodigoDetReparacion.Size = New System.Drawing.Size(98, 31)
        Me.TxtCodigoDetReparacion.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.DtpFechaVenc)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoReparacion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(565, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(753, 345)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la reparacion"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTecnico)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TxtCodigoTecnico)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(729, 141)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del tecnico"
        '
        'TxtTecnico
        '
        Me.TxtTecnico.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTecnico.Location = New System.Drawing.Point(121, 36)
        Me.TxtTecnico.Name = "TxtTecnico"
        Me.TxtTecnico.ReadOnly = True
        Me.TxtTecnico.Size = New System.Drawing.Size(280, 34)
        Me.TxtTecnico.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 28)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Tecnico"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 28)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Codigo"
        '
        'TxtCodigoTecnico
        '
        Me.TxtCodigoTecnico.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoTecnico.Location = New System.Drawing.Point(121, 89)
        Me.TxtCodigoTecnico.Name = "TxtCodigoTecnico"
        Me.TxtCodigoTecnico.ReadOnly = True
        Me.TxtCodigoTecnico.Size = New System.Drawing.Size(154, 34)
        Me.TxtCodigoTecnico.TabIndex = 8
        '
        'DtpFechaVenc
        '
        Me.DtpFechaVenc.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVenc.Location = New System.Drawing.Point(119, 144)
        Me.DtpFechaVenc.Name = "DtpFechaVenc"
        Me.DtpFechaVenc.Size = New System.Drawing.Size(154, 26)
        Me.DtpFechaVenc.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 28)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Vence"
        '
        'DtpFecha
        '
        Me.DtpFecha.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(119, 90)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(154, 26)
        Me.DtpFecha.TabIndex = 4
        '
        'TxtCodigoReparacion
        '
        Me.TxtCodigoReparacion.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoReparacion.Location = New System.Drawing.Point(119, 35)
        Me.TxtCodigoReparacion.Name = "TxtCodigoReparacion"
        Me.TxtCodigoReparacion.ReadOnly = True
        Me.TxtCodigoReparacion.Size = New System.Drawing.Size(154, 34)
        Me.TxtCodigoReparacion.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.TxtCedula)
        Me.GroupBox1.Controls.Add(Me.TxtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 208)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(394, 75)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(110, 65)
        Me.BtnBuscarCliente.TabIndex = 6
        Me.BtnBuscarCliente.Text = "Buscar"
        Me.BtnBuscarCliente.UseVisualStyleBackColor = False
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(93, 87)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(280, 34)
        Me.TxtCliente.TabIndex = 5
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(93, 139)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(280, 34)
        Me.TxtCedula.TabIndex = 4
        '
        'TxtCodigoCliente
        '
        Me.TxtCodigoCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoCliente.Location = New System.Drawing.Point(93, 35)
        Me.TxtCodigoCliente.Name = "TxtCodigoCliente"
        Me.TxtCodigoCliente.ReadOnly = True
        Me.TxtCodigoCliente.Size = New System.Drawing.Size(280, 34)
        Me.TxtCodigoCliente.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmReparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1341, 887)
        Me.Controls.Add(Me.ReparacionesTabs)
        Me.Name = "FrmReparaciones"
        Me.Text = "Reparaciones"
        Me.ReparacionesTabs.ResumeLayout(False)
        Me.TabReparaciones.ResumeLayout(False)
        Me.TabReparaciones.PerformLayout()
        CType(Me.DgvReparaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCobrar.ResumeLayout(False)
        Me.TabCobrar.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReparacionesTabs As TabControl
    Friend WithEvents TabReparaciones As TabPage
    Friend WithEvents BtnReparado As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnNueva As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Lbltitle As Label
    Friend WithEvents DgvReparaciones As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnBuscarReparacion As Button
    Friend WithEvents TxtDescuentoArticulo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodigoDetReparacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtTecnico As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCodigoTecnico As TextBox
    Friend WithEvents DtpFechaVenc As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TxtCodigoReparacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtCodigoCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TabCobrar As TabPage
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents IDTecnico As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrada As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDet As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label13 As Label
End Class
