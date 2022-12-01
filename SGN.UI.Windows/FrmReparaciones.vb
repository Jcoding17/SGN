Imports SGN.BLL
Imports SGN.Entity

Public Class FrmReparaciones

#Region "Buscar Reparacion"

    Private _idreparacion As Integer

    Public ReadOnly Property Idreparacion() As Integer
        Get
            Return _idreparacion
        End Get
    End Property

    Private Sub UpdateEstadoReparacion()
        Dim frm As New FrmMantenimientoReparacion

        If DgvReparaciones.SelectedRows.Count > 0 Then

            _idreparacion = DgvReparaciones.CurrentRow.Cells(0).Value

            Dim OReparacion As ReparacionEntity = ReparacionBLL.GetById(Idreparacion)
            frm.TxtCodigoCliente.Text = OReparacion.IdCliente
            frm.TxtCodigoTecnico.Text = OReparacion.IdEmpleado
            frm.TxtCodigoReparacion.Text = OReparacion.Id
            frm.TxtDescripcion.Text = OReparacion.Descripcion
            frm.DtpFechaEntrada.Value = OReparacion.FechaEntrada
            frm.DtpFechaSalida.Value = OReparacion.FechaSalida
            frm.TxtEstado.Text = OReparacion.Estado
            frm.BtnNuevo.Enabled = False
            frm.BtnNuevo.Visible = False
            frm.DtpFechaEntrada.Enabled = False
            frm.DtpFechaSalida.Enabled = False
            frm.BtnBuscarCliente.Enabled = False
            frm.BtnBuscarCliente.Visible = False
            frm.TxtDescripcion.Enabled = False
            frm.ShowDialog()
            DgvReparaciones.DataSource = ReparacionBLL.GetAll()
        Else
            MessageBox.Show("Por favor seleccione una fila", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodigoTecnico.Text = ActiveUser.Id
        TxtTecnico.Text = ActiveUser.Nombre & " " & ActiveUser.Apellido
        Inicializar()
        DgvReparaciones.AutoGenerateColumns = False
        DgvReparaciones.DataSource = ReparacionBLL.GetAll()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNueva.Click
        Dim frm As New FrmMantenimientoReparacion
        frm.creating = True
        frm.ShowDialog()
        DgvReparaciones.DataSource = ReparacionBLL.GetAll()
    End Sub

    Private Sub BtnReparado_Click(sender As Object, e As EventArgs) Handles BtnReparado.Click
        UpdateEstadoReparacion()
    End Sub

    Private Sub DgvReparaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReparaciones.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If

        _idreparacion = DgvReparaciones.CurrentRow.Cells(0).Value

        DialogResult = DialogResult.OK

        Close()
    End Sub

#End Region

    '-----------------------------------------------------------------------'

#Region "Cobrar"

    Dim oFacturaReparacion As FacturaReparacionEntity

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
            TxtCliente.Text = oCliente.Nombre & " " & oCliente.Apellido
            TxtCedula.Text = oCliente.NoDoc
        End If

    End Sub

    Private Sub BtnBuscarReparacion_Click(sender As Object, e As EventArgs) Handles BtnBuscarReparacion.Click

        Dim frm As New FrmReparaciones

        frm.TabCobrar.Visible = False

        If frm.ShowDialog() = DialogResult.OK Then
            Dim oReparacion As ReparacionEntity = ReparacionBLL.GetById(frm.Idreparacion)

            TxtCodigoDetReparacion.Text = oReparacion.Id
            TxtDescripcion.Text = oReparacion.Descripcion
        End If

    End Sub

    Private Sub InicializarControlesDetalle()
        TxtCodigoDetReparacion.Text = ""
        TxtArticulo.Text = ""
        TxtCantidad.Text = 0
        TxtDescripcion.Text = ""
        TxtPrecio.Text = 0
        TxtDescuentoArticulo.Text = 0
    End Sub

    Private Function ValidarDetalle() As Boolean

        Dim resultado As Boolean = True

        ErrorProvider.Clear()

        If TxtCodigoDetReparacion.Text = 0 Then
            MessageBox.Show("Por favor, agregue el o los productos", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarReparacion.Select()
            resultado = False
        End If

        If Val(TxtCodigoDetReparacion.Text) = 0 Then
            ErrorProvider.SetError(TxtCantidad, "Introduzca la cantidad")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub Inicializar()

        oFacturaReparacion = New FacturaReparacionEntity()

        TxtCodigoCliente.Text = 0
        TxtCliente.Text = ""
        TxtCedula.Text = ""
        TxtCodigoReparacion.Text = 0
        DtpFecha.Value = Date.Now
        DtpFechaVenc.Value = Date.Now.AddMonths(1)
        TxtSubTotal.Text = 0.ToString("C")
        TxtDescuento.Text = 0.ToString("C")
        TxtTotal.Text = 0.ToString("C")

        DgvReparaciones.AutoGenerateColumns = False
        DgvReparaciones.DataSource = Nothing

        InicializarControlesDetalle()

    End Sub

    Private Function ValidarVenta() As Boolean

        If String.IsNullOrEmpty(TxtCliente.Text) Then
            MessageBox.Show("Por favor, seleccione el cliente", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarCliente.Select()
            Return False
        End If

        If DgvReparaciones.Rows.Count = 0 Then
            MessageBox.Show("Por favor, agregue el o los productos", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarReparacion.Select()
            Return False
        End If

        Return True

    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Not ValidarDetalle() Then
            Return
        End If

        Dim detalle As New DetalleReparacionEntity
        detalle.IdFacturaReparacion = TxtCodigoReparacion.Text
        detalle.Articulo = TxtArticulo.Text
        detalle.Cantidad = TxtCantidad.Text
        detalle.Descripcion = TxtDescripcion.Text
        detalle.Precio = TxtPrecio.Text
        detalle.Descuento = TxtDescuentoArticulo.Text

        oFacturaReparacion.Detalles.Add(detalle)

        DgvReparaciones.DataSource = Nothing
        DgvReparaciones.DataSource = oFacturaReparacion.Detalles

        TxtSubTotal.Text = oFacturaReparacion.TotalSubTotal.ToString("C")
        TxtDescuento.Text = oFacturaReparacion.TotalDescuento.ToString("C")
        TxtTotal.Text = oFacturaReparacion.Total.ToString("C")

        InicializarControlesDetalle()

    End Sub

    Private Sub BtnNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Inicializar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Not ValidarVenta() Then
            Exit Sub
        End If

        oFacturaReparacion.IdCliente = TxtCodigoCliente.Text
        oFacturaReparacion.IdEmpleado = TxtCodigoTecnico.Text
        oFacturaReparacion.IdReparacion = TxtCodigoDetReparacion.Text
        oFacturaReparacion.Fecha = DtpFecha.Value

        Try
            FacturaReparacionBLL.Create(oFacturaReparacion)
            MessageBox.Show("Venta generada correctamente", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Inicializar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class