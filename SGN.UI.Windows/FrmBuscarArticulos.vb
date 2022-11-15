Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarArticulos

    Private _idarticulo As Integer

    Public ReadOnly Property Idarticulo() As Integer
        Get
            Return _idarticulo
        End Get
    End Property

    Private Sub GetAllMarcas()
        Dim colmarca As DataGridViewComboBoxColumn = DgvArticulos.Columns.Item(2)

        colmarca.DataSource = MarcaBLL.GetAll()
        colmarca.DisplayMember = "Nombre"
        colmarca.ValueMember = "Id"

        colmarca.DataPropertyName = "IdMarca"
    End Sub

    Private Sub GetAllCategorias()
        Dim colcategoria As DataGridViewComboBoxColumn = DgvArticulos.Columns.Item(3)

        colcategoria.DataSource = CategoriaBLL.GetAll()
        colcategoria.DisplayMember = "Nombre"
        colcategoria.ValueMember = "Id"

        colcategoria.DataPropertyName = "IdCategoria"
    End Sub

    Private Sub UpdateArticulo()
        Dim frm As New FrmMantenimientoArticulo

        If DgvArticulos.SelectedRows.Count > 0 Then

            _idarticulo = DgvArticulos.CurrentRow.Cells(0).Value

            Dim OArticulo As ArticuloEntity = ArticuloBLL.GetById(Idarticulo)

            frm.TxtId.Text = OArticulo.Id
            frm.TxtNombre.Text = OArticulo.Nombre
            frm.CboxIdMarca.DataSource = MarcaBLL.GetAll()
            frm.CboxIdMarca.DisplayMember = "Nombre"
            frm.CboxIdMarca.ValueMember = "Id"
            frm.CboxIdMarca.SelectedValue = OArticulo.IdMarca
            frm.CboxIdCategoria.DataSource = CategoriaBLL.GetAll()
            frm.CboxIdCategoria.DisplayMember = "Nombre"
            frm.CboxIdCategoria.ValueMember = "Id"
            frm.CboxIdCategoria.SelectedValue = OArticulo.IdCategoria
            frm.TxtDescripcion.Text = OArticulo.Descripcion
            frm.TxtPrecioCompra.Text = OArticulo.PrecioCompra
            frm.TxtPrecioVenta.Text = OArticulo.PrecioVenta
            frm.TxtStock.Text = OArticulo.Stock
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.ShowDialog()
            GetAllMarcas()
            GetAllCategorias()
            DgvArticulos.DataSource = ArticuloBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Buscar()

        If TxtBuscar.Text <> "" Then
            DgvArticulos.DataSource = ArticuloBLL.GetByValue(TxtBuscar.Text)
        Else
            DgvArticulos.DataSource = ArticuloBLL.GetAll()
        End If
    End Sub

    Private Sub DeleteArticulo()
        If DgvArticulos.SelectedRows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea eliminar el articulo?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idarticulo = DgvArticulos.CurrentRow.Cells(0).Value
                ArticuloBLL.Delete(Idarticulo)
                DgvArticulos.DataSource = ArticuloBLL.GetAll()
            End If

        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmBuscarArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvArticulos.AutoGenerateColumns = False
        DgvArticulos.DataSource = ArticuloBLL.GetAll()
        GetAllMarcas()
        GetAllCategorias()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantenimientoArticulo
        frm.creating = True
        frm.ShowDialog()
        GetAllMarcas()
        GetAllCategorias()
        DgvArticulos.DataSource = ArticuloBLL.GetAll()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateArticulo()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteArticulo()
    End Sub

End Class