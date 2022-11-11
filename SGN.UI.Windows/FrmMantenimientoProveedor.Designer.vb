<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoProveedor
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNoDoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.CboxIdDoc = New System.Windows.Forms.ComboBox()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 491)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(250, 55)
        Me.BtnCancelar.TabIndex = 57
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
        Me.BtnNuevo.Location = New System.Drawing.Point(278, 491)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(250, 55)
        Me.BtnNuevo.TabIndex = 56
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 370)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 32)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Codigo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(450, 272)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 32)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.ForeColor = System.Drawing.Color.Black
        Me.TxtDireccion.Location = New System.Drawing.Point(450, 318)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(343, 32)
        Me.TxtDireccion.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(451, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 32)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtEmail.Location = New System.Drawing.Point(451, 226)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(343, 32)
        Me.TxtEmail.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 276)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 32)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.ForeColor = System.Drawing.Color.Black
        Me.TxtTelefono.Location = New System.Drawing.Point(12, 323)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(343, 32)
        Me.TxtTelefono.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(450, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 32)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Tipo de Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 182)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 32)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "No. de Documento"
        '
        'TxtNoDoc
        '
        Me.TxtNoDoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNoDoc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoDoc.ForeColor = System.Drawing.Color.Black
        Me.TxtNoDoc.Location = New System.Drawing.Point(12, 229)
        Me.TxtNoDoc.Name = "TxtNoDoc"
        Me.TxtNoDoc.Size = New System.Drawing.Size(343, 32)
        Me.TxtNoDoc.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 32)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nombre"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(544, 491)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(250, 55)
        Me.BtnGuardar.TabIndex = 42
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(12, 135)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(343, 32)
        Me.TxtNombre.TabIndex = 41
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.ForeColor = System.Drawing.Color.Black
        Me.TxtId.Location = New System.Drawing.Point(12, 417)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(343, 32)
        Me.TxtId.TabIndex = 40
        '
        'CboxIdDoc
        '
        Me.CboxIdDoc.BackColor = System.Drawing.Color.White
        Me.CboxIdDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxIdDoc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxIdDoc.ForeColor = System.Drawing.Color.Black
        Me.CboxIdDoc.FormattingEnabled = True
        Me.CboxIdDoc.Location = New System.Drawing.Point(450, 130)
        Me.CboxIdDoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboxIdDoc.Name = "CboxIdDoc"
        Me.CboxIdDoc.Size = New System.Drawing.Size(343, 36)
        Me.CboxIdDoc.TabIndex = 39
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(201, 18)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(404, 45)
        Me.Lbltitle.TabIndex = 38
        Me.Lbltitle.Text = "Mantenimiento Proveedor"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmMantenimientoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(806, 564)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNoDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.CboxIdDoc)
        Me.Controls.Add(Me.Lbltitle)
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoProveedor"
        Me.ShowIcon = False
        Me.Text = "Mantenimiento Proveedor"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNoDoc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CboxIdDoc As ComboBox
    Friend WithEvents Lbltitle As Label
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
