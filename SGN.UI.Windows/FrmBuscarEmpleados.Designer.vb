﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarEmpleados))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDoc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCargo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.Black
        Me.TxtBuscar.Location = New System.Drawing.Point(125, 22)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(791, 38)
        Me.TxtBuscar.TabIndex = 23
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.Location = New System.Drawing.Point(997, 342)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(190, 70)
        Me.BtnBorrar.TabIndex = 22
        Me.BtnBorrar.Tag = ""
        Me.BtnBorrar.Text = "  Borrar"
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(997, 180)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(190, 70)
        Me.BtnNuevo.TabIndex = 21
        Me.BtnNuevo.Tag = ""
        Me.BtnNuevo.Text = "  Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.BtnBuscar.Location = New System.Drawing.Point(926, 18)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(48, 49)
        Me.BtnBuscar.TabIndex = 20
        Me.BtnBuscar.Tag = ""
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(22, 25)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(86, 32)
        Me.Lbltitle.TabIndex = 19
        Me.Lbltitle.Text = "Buscar"
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellido, Me.Edad, Me.IDDoc, Me.NoDoc, Me.Telefono, Me.Email, Me.Direccion, Me.IDCargo})
        Me.DgvEmpleados.Location = New System.Drawing.Point(24, 92)
        Me.DgvEmpleados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.RowHeadersWidth = 62
        Me.DgvEmpleados.Size = New System.Drawing.Size(964, 431)
        Me.DgvEmpleados.TabIndex = 18
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
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.MinimumWidth = 8
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 150
        '
        'Edad
        '
        Me.Edad.DataPropertyName = "Edad"
        Me.Edad.HeaderText = "Edad"
        Me.Edad.MinimumWidth = 8
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 75
        '
        'IDDoc
        '
        Me.IDDoc.HeaderText = "Documento"
        Me.IDDoc.MinimumWidth = 8
        Me.IDDoc.Name = "IDDoc"
        Me.IDDoc.ReadOnly = True
        Me.IDDoc.Width = 150
        '
        'NoDoc
        '
        Me.NoDoc.DataPropertyName = "NoDoc"
        Me.NoDoc.HeaderText = "No Documento"
        Me.NoDoc.MinimumWidth = 8
        Me.NoDoc.Name = "NoDoc"
        Me.NoDoc.ReadOnly = True
        Me.NoDoc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NoDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NoDoc.Width = 150
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.MinimumWidth = 8
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 150
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 8
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 150
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.MinimumWidth = 8
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 150
        '
        'IDCargo
        '
        Me.IDCargo.HeaderText = "Cargo"
        Me.IDCargo.MinimumWidth = 8
        Me.IDCargo.Name = "IDCargo"
        Me.IDCargo.ReadOnly = True
        Me.IDCargo.Width = 150
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = Global.SGN.UI.Windows.My.Resources.Resources.cliente32
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(997, 261)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(190, 70)
        Me.BtnActualizar.TabIndex = 24
        Me.BtnActualizar.Text = "  Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'FrmBuscarEmpleados
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
        Me.Controls.Add(Me.DgvEmpleados)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarEmpleados"
        Me.ShowIcon = False
        Me.Text = "Buscar Empleados"
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Lbltitle As Label
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents IDDoc As DataGridViewComboBoxColumn
    Friend WithEvents NoDoc As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents IDCargo As DataGridViewComboBoxColumn
    Friend WithEvents BtnActualizar As Button
End Class
