Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarEmpleados
    Private _idempleado As Integer

    Public ReadOnly Property Idempleado() As Integer
        Get
            Return _idempleado
        End Get
    End Property

    Private Sub GetAllTipoDoc()
        Dim coltipodoc As DataGridViewComboBoxColumn = DgvEmpleados.Columns.Item(4)

        coltipodoc.DataSource = TipoDocBLL.GetAll()
        coltipodoc.DisplayMember = "Nombre"
        coltipodoc.ValueMember = "Id"

        coltipodoc.DataPropertyName = "IdDoc"
    End Sub

    Private Sub GetAllCargos()
        Dim colcargo As DataGridViewComboBoxColumn = DgvEmpleados.Columns.Item(9)

        colcargo.DataSource = CargoBLL.GetAll()
        colcargo.DisplayMember = "Nombre"
        colcargo.ValueMember = "Id"

        colcargo.DataPropertyName = "IdCargo"
    End Sub

    Private Sub UpdateEmpleado()
        Dim frm As New FrmMantemientoEmpleados

        If DgvEmpleados.SelectedRows.Count > 0 Then

            _idempleado = DgvEmpleados.CurrentRow.Cells(0).Value

            Dim Oempleado As EmpleadoEntity = EmpleadoBLL.GetById(Idempleado)

            frm.TxtId.Text = Oempleado.Id
            frm.TxtNombre.Text = Oempleado.Nombre
            frm.TxtApellido.Text = Oempleado.Apellido
            frm.TxtEdad.Text = Oempleado.Edad
            frm.CboxIdDoc.DataSource = TipoDocBLL.GetAll()
            frm.CboxIdDoc.DisplayMember = "Nombre"
            frm.CboxIdDoc.ValueMember = "Id"
            frm.CboxIdDoc.SelectedValue = Oempleado.IdDoc
            frm.TxtNoDoc.Text = Oempleado.NoDoc
            frm.TxtTelefono.Text = Oempleado.Telefono
            frm.TxtEmail.Text = Oempleado.Email
            frm.TxtDireccion.Text = Oempleado.Direccion
            frm.CboxIdCargo.DataSource = CargoBLL.GetAll()
            frm.CboxIdCargo.DisplayMember = "Nombre"
            frm.CboxIdCargo.ValueMember = "Id"
            frm.CboxIdCargo.SelectedValue = Oempleado.IdCargo
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.ShowDialog()
            GetAllCargos()
            DgvEmpleados.DataSource = EmpleadoBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Buscar()

        If TxtBuscar.Text <> "" Then
            DgvEmpleados.DataSource = EmpleadoBLL.GetByValue(TxtBuscar.Text)
        Else
            DgvEmpleados.DataSource = EmpleadoBLL.GetAll()
        End If
    End Sub

    Private Sub DeleteEmpleado()
        If DgvEmpleados.SelectedRows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea eliminar el empleado?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idempleado = DgvEmpleados.CurrentRow.Cells(0).Value
                EmpleadoBLL.Delete(Idempleado)
                DgvEmpleados.DataSource = EmpleadoBLL.GetAll()
            End If

        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmBuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvEmpleados.AutoGenerateColumns = False
        DgvEmpleados.DataSource = EmpleadoBLL.GetAll()
        GetAllTipoDoc()
        GetAllCargos()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantemientoEmpleados
        frm.creating = True
        frm.ShowDialog()
        GetAllCargos()
        DgvEmpleados.DataSource = EmpleadoBLL.GetAll()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteEmpleado()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateEmpleado()
    End Sub
End Class