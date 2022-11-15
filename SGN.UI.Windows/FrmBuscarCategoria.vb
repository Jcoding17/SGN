Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarCategoria

    Private _idcategoria As Integer

    Public ReadOnly Property Idcategoria() As Integer
        Get
            Return _idcategoria
        End Get
    End Property

    Private Sub UpdateCategoria()
        Dim frm As New FrmMantenimientoCategoria

        If DgvCategorias.SelectedRows.Count > 0 Then

            _idcategoria = DgvCategorias.CurrentRow.Cells(0).Value

            Dim OCategoria As CategoriaEntity = CategoriaBLL.GetById(Idcategoria)

            frm.TxtId.Text = OCategoria.Id
            frm.TxtNombre.Text = OCategoria.Nombre
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.ShowDialog()
            DgvCategorias.DataSource = CategoriaBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Buscar()

        DgvCategorias.DataSource = CategoriaBLL.GetAll()

    End Sub

    Private Sub DeleteCategoria()
        If DgvCategorias.SelectedRows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea eliminar la categoria?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idcategoria = DgvCategorias.CurrentRow.Cells(0).Value
                CategoriaBLL.Delete(Idcategoria)
                DgvCategorias.DataSource = CategoriaBLL.GetAll()
            End If

        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmBuscarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvCategorias.AutoGenerateColumns = False
        DgvCategorias.DataSource = CategoriaBLL.GetAll()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantenimientoCategoria
        frm.creating = True
        frm.ShowDialog()
        DgvCategorias.DataSource = CategoriaBLL.GetAll()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateCategoria()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteCategoria()
    End Sub

End Class