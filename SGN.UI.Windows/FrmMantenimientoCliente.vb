Imports SGN.BLL
Imports SGN.Entity

Public Class FrmMantenimientoCliente
    Public creating As Boolean = False
    Private Sub Nuevo()
        TxtId.Text = 0
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtNoDoc.Clear()
        TxtTelefono.Clear()
        TxtEmail.Clear()
        TxtDireccion.Clear()
        CargarTipoDoc()
        TxtNombre.Select()
    End Sub

    Private Sub CargarTipoDoc()
        CboxIdDoc.ValueMember = "Id"
        CboxIdDoc.DisplayMember = "Nombre"
        CboxIdDoc.DataSource = TipoDocBLL.GetAll()
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

        End If

        Dim OCliente As New ClienteEntity
        OCliente.Id = Convert.ToInt32(TxtId.Text)
        OCliente.Nombre = TxtNombre.Text
        OCliente.Apellido = TxtApellido.Text
        OCliente.IdDoc = CboxIdDoc.SelectedValue
        OCliente.NoDoc = TxtNoDoc.Text
        OCliente.Telefono = TxtTelefono.Text
        OCliente.Email = TxtEmail.Text
        OCliente.Direccion = TxtDireccion.Text


        Try
            ClienteBLL.Create(OCliente)
            MessageBox.Show("Cliente guardado con exito", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub FrmMantenimientoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If creating = True Then
            Nuevo()
        Else
            'CargarTipoDoc()
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