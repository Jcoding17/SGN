Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarCargo

    Private _idcargo As Integer

    Public ReadOnly Property Idcargo() As Integer
        Get
            Return _idcargo
        End Get
    End Property

    Private Sub UpdateCargo()
        Dim frm As New FrmMantenimientoCargo

        If DgvCargos.SelectedRows.Count > 0 Then

            _idcargo = DgvCargos.CurrentRow.Cells(0).Value

            Dim OCargo As CargoEntity = CargoBLL.GetById(Idcargo)

            frm.TxtId.Text = OCargo.Id
            frm.TxtNombre.Text = OCargo.Nombre
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.ShowDialog()
            DgvCargos.DataSource = CargoBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Buscar()

        DgvCargos.DataSource = CargoBLL.GetAll()

    End Sub

    Private Sub DeleteCargo()
        If DgvCargos.SelectedRows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea eliminar el cargo?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idcargo = DgvCargos.CurrentRow.Cells(0).Value
                CargoBLL.Delete(Idcargo)
                DgvCargos.DataSource = CargoBLL.GetAll()
            End If

        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmBuscarCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvCargos.AutoGenerateColumns = False
        DgvCargos.DataSource = CargoBLL.GetAll()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantenimientoCargo
        frm.creating = True
        frm.ShowDialog()
        DgvCargos.DataSource = CargoBLL.GetAll()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateCargo()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteCargo()
    End Sub

End Class