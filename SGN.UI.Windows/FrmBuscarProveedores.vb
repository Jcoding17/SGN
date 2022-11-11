Imports SGN.BLL
Imports SGN.Entity

Public Class FrmBuscarProveedores
    Private _idproveedor As Integer

    Public ReadOnly Property Idproveedor() As Integer
        Get
            Return _idproveedor
        End Get
    End Property

    Private Sub GetAllTipoDoc()
        Dim coltipodoc As DataGridViewComboBoxColumn = DgvProveedores.Columns.Item(2)

        coltipodoc.DataSource = TipoDocBLL.GetAll()
        coltipodoc.DisplayMember = "Nombre"
        coltipodoc.ValueMember = "Id"

        coltipodoc.DataPropertyName = "IdDoc"
    End Sub

    Private Sub UpdateProveedor()
        Dim frm As New FrmMantenimientoProveedor

        If DgvProveedores.SelectedRows.Count > 0 Then

            _idproveedor = DgvProveedores.CurrentRow.Cells(0).Value

            Dim OProveedor As ProveedorEntity = ProveedorBLL.GetById(Idproveedor)

            frm.TxtId.Text = OProveedor.Id
            frm.TxtNombre.Text = OProveedor.Nombre

            frm.CboxIdDoc.DataSource = TipoDocBLL.GetAll()
            frm.CboxIdDoc.DisplayMember = "Nombre"
            frm.CboxIdDoc.ValueMember = "Id"
            frm.CboxIdDoc.SelectedValue = OProveedor.IdDoc
            frm.TxtNoDoc.Text = OProveedor.NoDoc
            frm.TxtTelefono.Text = OProveedor.Telefono
            frm.TxtEmail.Text = OProveedor.Email
            frm.TxtDireccion.Text = OProveedor.Direccion
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.ShowDialog()
            DgvProveedores.DataSource = ProveedorBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub Buscar()

        If TxtBuscar.Text <> "" Then
            DgvProveedores.DataSource = ProveedorBLL.GetByValue(TxtBuscar.Text)
        Else
            DgvProveedores.DataSource = ProveedorBLL.GetAll()
        End If
    End Sub

    Private Sub DeleteProveedor()
        If DgvProveedores.SelectedRows.Count > 0 Then

            If MessageBox.Show("¿Seguro que desea eliminar el proveedor?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _idproveedor = DgvProveedores.CurrentRow.Cells(0).Value
                ProveedorBLL.Delete(Idproveedor)
                DgvProveedores.DataSource = ProveedorBLL.GetAll()
            End If

        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmBuscarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvProveedores.AutoGenerateColumns = False
        DgvProveedores.DataSource = ProveedorBLL.GetAll()
        GetAllTipoDoc()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMantenimientoProveedor
        frm.creating = True
        frm.ShowDialog()
        DgvProveedores.DataSource = ProveedorBLL.GetAll()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        UpdateProveedor()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        DeleteProveedor()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
    End Sub
End Class