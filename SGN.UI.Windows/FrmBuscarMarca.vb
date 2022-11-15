Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarMarca

    Private _idmarca As Integer

    Public ReadOnly Property Idmarca() As Integer
        Get
            Return _idmarca
        End Get
    End Property

    Private Sub UpdateMarca()
        Dim frm As New FrmMantenimientoMarca

        If DgvMarcas.SelectedRows.Count > 0 Then

            _idmarca = DgvMarcas.CurrentRow.Cells(0).Value

            Dim OMarca As MarcaEntity = MarcaBLL.GetById(Idmarca)

            frm.TxtId.Text = OMarca.Id
            frm.TxtNombre.Text = OMarca.Nombre
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.ShowDialog()
            DgvMarcas.DataSource = MarcaBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Buscar()

        DgvMarcas.DataSource = MarcaBLL.GetAll()

    End Sub

    Private Sub DeleteMarca()
        If DgvMarcas.SelectedRows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea eliminar la marca?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idmarca = DgvMarcas.CurrentRow.Cells(0).Value
                MarcaBLL.Delete(Idmarca)
                DgvMarcas.DataSource = MarcaBLL.GetAll()
            End If

        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmBuscarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvMarcas.AutoGenerateColumns = False
        DgvMarcas.DataSource = MarcaBLL.GetAll()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantenimientoMarca
        frm.creating = True
        frm.ShowDialog()
        DgvMarcas.DataSource = MarcaBLL.GetAll()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateMarca()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteMarca()
    End Sub

End Class