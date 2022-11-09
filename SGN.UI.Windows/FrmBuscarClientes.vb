Imports System.Runtime.Versioning
Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarClientes

    Private _idcliente As Integer

    Public ReadOnly Property Idcliente() As Integer
        Get
            Return _idcliente
        End Get
    End Property

    Private Sub GetAllTipoDoc()
        Dim coltipodoc As DataGridViewComboBoxColumn = DgvClientes.Columns.Item(3)

        coltipodoc.DataSource = TipoDocBLL.GetAll()
        coltipodoc.DisplayMember = "Nombre"
        coltipodoc.ValueMember = "Id"

        coltipodoc.DataPropertyName = "IdDoc"
    End Sub

    Private Sub UpdateCliente()
        Dim frm As New FrmMantenimientoCliente

        If DgvClientes.SelectedRows.Count > 0 Then

            _idcliente = DgvClientes.CurrentRow.Cells(0).Value

            Dim OCliente As ClienteEntity = ClienteBLL.GetById(Idcliente)

            frm.TxtId.Text = OCliente.Id
            frm.TxtNombre.Text = OCliente.Nombre
            frm.TxtApellido.Text = OCliente.Apellido
            frm.CboxIdDoc.DataSource = TipoDocBLL.GetAll()
            frm.CboxIdDoc.DisplayMember = "Nombre"
            frm.CboxIdDoc.ValueMember = "Id"
            frm.CboxIdDoc.SelectedValue = OCliente.IdDoc
            frm.TxtNoDoc.Text = OCliente.NoDoc
            frm.TxtTelefono.Text = OCliente.Telefono
            frm.TxtEmail.Text = OCliente.Email
            frm.TxtDireccion.Text = OCliente.Direccion
            frm.BtnNuevo.Enabled = False
            frm.ShowDialog()
        End If
    End Sub

    Private Sub Buscar()
        If CboxBuscarBy.SelectedIndex = 0 Then
            DgvClientes.DataSource = ClienteBLL.GetAll()
            TxtBuscar.Enabled = False
        ElseIf CboxBuscarBy.SelectedIndex = 1 And IsNumeric(TxtBuscar.Text) Then
            DgvClientes.DataSource = ClienteBLL.GetById(Convert.ToInt32(TxtBuscar.Text))
            TxtBuscar.Enabled = True
        ElseIf CboxBuscarBy.SelectedIndex = 2 Then
            DgvClientes.DataSource = ClienteBLL.GetByValue(TxtBuscar.Text)
            TxtBuscar.Enabled = True
        End If
    End Sub

    Private Sub DeleteCliente()
        If DgvClientes.SelectedRows.Count > 0 Then
            If MessageBox.Show("¿Seguro que desea eliminar el cliente?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idcliente = DgvClientes.CurrentRow.Cells(0).Value
                ClienteBLL.Delete(Idcliente)
                DgvClientes.DataSource = ClienteBLL.GetAll()
            End If
        End If
    End Sub

    Private Sub FrmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboxBuscarBy.SelectedIndex = 0
        DgvClientes.AutoGenerateColumns = False
        DgvClientes.DataSource = ClienteBLL.GetAll()
        GetAllTipoDoc()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantenimientoCliente
        frm.creating = True
        frm.ShowDialog()
        DgvClientes.DataSource = ClienteBLL.GetAll()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateCliente()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteCliente()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub

End Class