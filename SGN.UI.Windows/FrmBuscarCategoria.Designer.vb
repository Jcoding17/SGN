<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarCategoria))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.DgvCategorias = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.Black
        Me.TxtBuscar.Location = New System.Drawing.Point(125, 22)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(791, 38)
        Me.TxtBuscar.TabIndex = 30
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(22, 25)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(86, 32)
        Me.Lbltitle.TabIndex = 26
        Me.Lbltitle.Text = "Buscar"
        '
        'DgvCategorias
        '
        Me.DgvCategorias.AllowUserToAddRows = False
        Me.DgvCategorias.AllowUserToDeleteRows = False
        Me.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre})
        Me.DgvCategorias.Location = New System.Drawing.Point(24, 92)
        Me.DgvCategorias.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvCategorias.Name = "DgvCategorias"
        Me.DgvCategorias.ReadOnly = True
        Me.DgvCategorias.RowHeadersWidth = 62
        Me.DgvCategorias.Size = New System.Drawing.Size(964, 431)
        Me.DgvCategorias.TabIndex = 25
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 75
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 825
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(1010, 264)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(165, 61)
        Me.BtnActualizar.TabIndex = 31
        Me.BtnActualizar.Tag = ""
        Me.BtnActualizar.Text = "  Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.Location = New System.Drawing.Point(1010, 345)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(165, 61)
        Me.BtnBorrar.TabIndex = 29
        Me.BtnBorrar.Tag = ""
        Me.BtnBorrar.Text = "  Borrar"
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(1010, 183)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(165, 61)
        Me.BtnNuevo.TabIndex = 28
        Me.BtnNuevo.Tag = ""
        Me.BtnNuevo.Text = "  Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Enabled = False
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.SGN.UI.Windows.My.Resources.Resources.buscar32
        Me.BtnBuscar.Location = New System.Drawing.Point(926, 17)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(48, 49)
        Me.BtnBuscar.TabIndex = 27
        Me.BtnBuscar.Tag = ""
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmBuscarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 540)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.DgvCategorias)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarCategoria"
        Me.ShowIcon = False
        Me.Text = "Buscar Categoria"
        CType(Me.DgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Lbltitle As Label
    Friend WithEvents DgvCategorias As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
End Class
