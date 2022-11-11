Imports SGN.BLL
Imports SGN.Entity

Public Class FrmMantemientoEmpleados

    Public creating As Boolean = False
    Private Sub Nuevo()
        TxtId.Text = 0
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtEdad.Clear()
        TxtNoDoc.Clear()
        TxtTelefono.Clear()
        TxtEmail.Clear()
        TxtDireccion.Clear()
        CargarTipoDoc()
        CargarCargos()
        TxtNombre.Select()
    End Sub

    Private Sub CargarTipoDoc()
        CboxIdDoc.ValueMember = "Id"
        CboxIdDoc.DisplayMember = "Nombre"
        CboxIdDoc.DataSource = TipoDocBLL.GetAll()
    End Sub

    Private Sub CargarCargos()
        CboxIdCargo.ValueMember = "Id"
        CboxIdCargo.DisplayMember = "Nombre"
        CboxIdCargo.DataSource = CargoBLL.GetAll()
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

        Dim Oempleado As New EmpleadoEntity
        Oempleado.Id = Convert.ToInt32(TxtId.Text)
        Oempleado.Nombre = TxtNombre.Text
        Oempleado.Apellido = TxtApellido.Text
        Oempleado.Edad = TxtEdad.Text
        Oempleado.IdDoc = CboxIdDoc.SelectedValue
        Oempleado.NoDoc = TxtNoDoc.Text
        Oempleado.Telefono = TxtTelefono.Text
        Oempleado.Email = TxtEmail.Text
        Oempleado.Direccion = TxtDireccion.Text
        Oempleado.IdCargo = CboxIdCargo.SelectedValue

        Try
            EmpleadoBLL.Create(Oempleado)
            MessageBox.Show("Empleado guardado con exito", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmMantemientoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class