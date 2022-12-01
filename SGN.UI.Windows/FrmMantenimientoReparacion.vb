Imports SGN.BLL
Imports SGN.Entity

Public Class FrmMantenimientoReparacion

    Public creating As Boolean = False
    Private Sub Nuevo()
        TxtCodigoReparacion.Text = 0
        TxtNombreCliente.Clear()
        TxtCodigoCliente.Text = 0
        TxtDescripcion.Clear()
        TxtDescripcion.Select()
        TxtEstado.Text = "No reparado"
    End Sub

    Private Function ValidarDatos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider.Clear()

        If String.IsNullOrEmpty(TxtDescripcion.Text) Then
            ErrorProvider.SetError(TxtDescripcion, "Es necesaria una descripcion")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub Guardar()

        If Not ValidarDatos() Then
            Return
        End If

        Dim OReparacion As New ReparacionEntity
        OReparacion.Id = Convert.ToInt32(TxtCodigoReparacion.Text)
        OReparacion.IdCliente = TxtCodigoCliente.Text
        OReparacion.IdEmpleado = TxtCodigoTecnico.Text
        OReparacion.Descripcion = TxtDescripcion.Text
        OReparacion.Estado = TxtEstado.Text
        OReparacion.FechaEntrada = DtpFechaEntrada.Value
        OReparacion.FechaSalida = DtpFechaSalida.Value

        Try
            ReparacionBLL.Create(OReparacion)
            MessageBox.Show("Reparacion guardada con exito", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmMantenimientoReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombreTecnico.Text = ActiveUser.Nombre & " " & ActiveUser.Apellido
        TxtCodigoTecnico.Text = ActiveUser.Id
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

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Dim frm As New FrmBuscarClientes

        frm.BtnNuevo.Enabled = False
        frm.BtnActualizar.Enabled = False
        frm.BtnBorrar.Enabled = False
        frm.BtnNuevo.Visible = False
        frm.BtnActualizar.Visible = False
        frm.BtnBorrar.Visible = False

        If frm.ShowDialog() = DialogResult.OK Then
            Dim oCliente As ClienteEntity = ClienteBLL.GetById(frm.Idcliente)

            TxtCodigoCliente.Text = oCliente.Id
            TxtNombreCliente.Text = oCliente.Nombre & " " & oCliente.Apellido
        End If

    End Sub

End Class