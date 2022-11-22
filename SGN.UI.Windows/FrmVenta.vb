﻿Imports SGN.BLL
Imports SGN.Entity

Public Class FrmVenta

    Dim oVenta As VentaEntity

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Dim frm As New FrmBuscarClientes

        frm.BtnNuevo.Enabled = False
        frm.BtnActualizar.Enabled = False
        frm.BtnBorrar.Enabled = False
        frm.BtnNuevo.Visible = False
        frm.BtnActualizar.Visible = False
        frm.BtnBorrar.Visible = False

        If frm.ShowDialog() = DialogResult.OK Then
            Dim oCliente As ClienteEntity = ClienteBLL.GetById(frm.IdCliente)

            TxtCodigoCliente.Text = oCliente.Id
            TxtCliente.Text = oCliente.Nombre & " " & oCliente.Apellido
            TxtCedula.Text = oCliente.NoDoc
        End If

    End Sub

    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtVendedor.Text = ActiveUser.Nombre & " " & ActiveUser.Apellido
        TxtCodigoVendedor.Text = ActiveUser.Id
        Inicializar()
    End Sub

    Private Sub BtnBuscarArticulo_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulo.Click
        Dim frm As New FrmBuscarArticulos

        frm.BtnNuevo.Enabled = False
        frm.BtnActualizar.Enabled = False
        frm.BtnBorrar.Enabled = False
        frm.BtnNuevo.Visible = False
        frm.BtnActualizar.Visible = False
        frm.BtnBorrar.Visible = False

        If frm.ShowDialog() = DialogResult.OK Then
            Dim oArticulo As ArticuloEntity = ArticuloBLL.GetById(frm.IdArticulo)

            TxtCodigoArticulo.Text = oArticulo.Id
            TxtArticulo.Text = oArticulo.Nombre
            TxtCantidad.Text = 1
            TxtPrecioVenta.Text = oArticulo.PrecioVenta
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If Not ValidarDetalle() Then
            Return
        End If

        Dim detalle As New DetalleVentaEntity
        detalle.IdVenta = TxtCodigoVenta.Text
        detalle.IdArticulo = TxtCodigoArticulo.Text
        detalle.NombreArticulo = TxtArticulo.Text
        detalle.Cantidad = TxtCantidad.Text
        detalle.Precio = TxtPrecioVenta.Text
        detalle.Descuento = TxtDescuentoArticulo.Text

        oVenta.Detalles.Add(detalle)

        DgvArticulos.DataSource = Nothing
        DgvArticulos.DataSource = oVenta.Detalles

        TxtSubTotal.Text = oVenta.TotalSubTotal.ToString("C")
        TxtDescuento.Text = oVenta.TotalDescuento.ToString("C")
        TxtImpuesto.Text = oVenta.TotalImpuesto.ToString("C")
        TxtTotal.Text = oVenta.Total.ToString("C")

        InicializarControlesDetalle()
    End Sub

    Private Sub InicializarControlesDetalle()
        TxtCodigoArticulo.Text = 0
        TxtArticulo.Text = ""
        TxtCantidad.Text = 0
        TxtPrecioVenta.Text = 0
        TxtDescuentoArticulo.Text = 0
    End Sub

    Private Function ValidarDetalle() As Boolean

        Dim resultado As Boolean = True

        ErrorProvider.Clear()

        If TxtCodigoArticulo.Text = 0 Then
            MessageBox.Show("Por favor, agregue los productos", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarArticulo.Select()
            resultado = False
        End If

        If Val(TxtCodigoArticulo.Text) = 0 Then
            ErrorProvider.SetError(TxtCantidad, "Introduzca la cantidad")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub Inicializar()

        oVenta = New VentaEntity()

        TxtCodigoCliente.Text = 0
        TxtCliente.Text = ""
        TxtCedula.Text = ""
        TxtCodigoVenta.Text = 0
        DtpFecha.Value = Date.Now
        DtpFechaVenc.Value = Date.Now.AddMonths(1)
        CboxCondicion.SelectedIndex = 0
        CboxPlazo.SelectedIndex = 0
        TxtSubTotal.Text = 0.ToString("C")
        TxtDescuento.Text = 0.ToString("C")
        TxtImpuesto.Text = 0.ToString("C")
        TxtTotal.Text = 0.ToString("C")

        DgvArticulos.AutoGenerateColumns = False
        DgvArticulos.DataSource = Nothing

        InicializarControlesDetalle()

    End Sub

    Private Function ValidarVenta() As Boolean

        If String.IsNullOrEmpty(TxtCliente.Text) Then
            MessageBox.Show("Por favor, seleccione el cliente", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarCliente.Select()
            Return False
        End If

        If DgvArticulos.Rows.Count = 0 Then
            MessageBox.Show("Por favor, agregue los productos", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarArticulo.Select()
            Return False
        End If

        Return True

    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Inicializar()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Not ValidarVenta() Then
            Exit Sub
        End If

        oVenta.IdCliente = TxtCodigoCliente.Text
        oVenta.Fecha = DtpFecha.Value
        oVenta.FechaVenc = DtpFechaVenc.Value
        oVenta.Condicion = CboxCondicion.Text
        oVenta.Plazo = CboxPlazo.Text
        oVenta.IdEmpleado = TxtCodigoVendedor.Text

        Try
            VentaBLL.Create(oVenta)
            MessageBox.Show("Venta generada correctamente", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Inicializar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class