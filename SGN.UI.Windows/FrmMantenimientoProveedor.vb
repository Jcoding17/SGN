Imports SGN.BLL
Imports SGN.Entity

Public Class FrmMantenimientoProveedor

    Public creating As Boolean = False
    Private Sub Nuevo()
        TxtId.Text = 0
        TxtNombre.Clear()
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
            Return
        End If

        Dim OProveedor As New ProveedorEntity
        OProveedor.Id = Convert.ToInt32(TxtId.Text)
        OProveedor.Nombre = TxtNombre.Text
        OProveedor.IdDoc = CboxIdDoc.SelectedValue
        OProveedor.NoDoc = TxtNoDoc.Text
        OProveedor.Telefono = TxtTelefono.Text
        OProveedor.Email = TxtEmail.Text
        OProveedor.Direccion = TxtDireccion.Text


        Try
            ProveedorBLL.Create(OProveedor)
            MessageBox.Show("Proveedor guardado con exito", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmMantenimientoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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