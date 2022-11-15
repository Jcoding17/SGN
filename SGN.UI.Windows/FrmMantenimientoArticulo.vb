Imports SGN.BLL
Imports SGN.Entity

Public Class FrmMantenimientoArticulo

    Public creating As Boolean = False
    Private Sub Nuevo()
        TxtId.Text = 0
        TxtNombre.Clear()
        TxtDescripcion.Clear()
        TxtPrecioCompra.Clear()
        TxtPrecioVenta.Clear()
        TxtStock.Clear()
        CargarMarcas()
        CargarCategorias()
        TxtNombre.Select()
    End Sub

    Private Sub CargarMarcas()
        CboxIdMarca.ValueMember = "Id"
        CboxIdMarca.DisplayMember = "Nombre"
        CboxIdMarca.DataSource = MarcaBLL.GetAll()
    End Sub

    Private Sub CargarCategorias()
        CboxIdCategoria.ValueMember = "Id"
        CboxIdCategoria.DisplayMember = "Nombre"
        CboxIdCategoria.DataSource = CategoriaBLL.GetAll()
    End Sub

    Private Function ValidarDatos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider.Clear()

        If String.IsNullOrEmpty(TxtNombre.Text) Then
            ErrorProvider.SetError(TxtNombre, "El nombre es requerido")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub Guardar()

        If Not ValidarDatos() Then
            Return
        End If

        Dim OArticulo As New ArticuloEntity
        OArticulo.Id = Convert.ToInt32(TxtId.Text)
        OArticulo.Nombre = TxtNombre.Text
        OArticulo.Descripcion = TxtDescripcion.Text
        OArticulo.PrecioCompra = Convert.ToDouble(TxtPrecioCompra.Text)
        OArticulo.PrecioVenta = Convert.ToDouble(TxtPrecioVenta.Text)
        OArticulo.Stock = Convert.ToInt32(TxtStock.Text)
        OArticulo.IdMarca = CboxIdMarca.SelectedValue
        OArticulo.IdCategoria = CboxIdCategoria.SelectedValue
        Try
            ArticuloBLL.Create(OArticulo)
            MessageBox.Show("Articulo guardado con exito", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmMantenimientoArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If creating = True Then
            Nuevo()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

    Private Sub BtnAgregarMarca_Click(sender As Object, e As EventArgs) Handles BtnAgregarMarca.Click
        Dim frm As New FrmMantenimientoMarca
        frm.creating = True
        frm.ShowDialog()
        CargarMarcas()
    End Sub

    Private Sub BtnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles BtnAgregarCategoria.Click
        Dim frm As New FrmMantenimientoCategoria
        frm.creating = True
        frm.ShowDialog()
        CargarCategorias()
    End Sub

End Class