Imports SGN.BLL
Imports SGN.Entity

Public Class FrmCompra

    Dim oCompra As CompraEntity

    Private Sub BtnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor.Click

        Dim frm As New FrmBuscarProveedores

        frm.BtnNuevo.Enabled = False
        frm.BtnActualizar.Enabled = False
        frm.BtnBorrar.Enabled = False
        frm.BtnNuevo.Visible = False
        frm.BtnActualizar.Visible = False
        frm.BtnBorrar.Visible = False

        If frm.ShowDialog() = DialogResult.OK Then
            Dim oProveedor As ProveedorEntity = ProveedorBLL.GetById(frm.Idproveedor)

            TxtCodigoProveedor.Text = oProveedor.Id
            TxtProveedor.Text = oProveedor.Nombre
            TxtDocumento.Text = oProveedor.NoDoc
        End If

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
            Dim oArticulo As ArticuloEntity = ArticuloBLL.GetById(frm.Idarticulo)

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

        Dim detalle As New DetalleCompraEntity
        detalle.IdCompra = TxtCodigoCompra.Text
        detalle.IdArticulo = TxtCodigoArticulo.Text
        detalle.NombreArticulo = TxtArticulo.Text
        detalle.Cantidad = TxtCantidad.Text
        detalle.Precio = TxtPrecioVenta.Text
        detalle.Descuento = TxtDescuentoArticulo.Text

        oCompra.Detalles.Add(detalle)

        DgvArticulos.DataSource = Nothing
        DgvArticulos.DataSource = oCompra.Detalles

        TxtSubTotal.Text = oCompra.TotalSubTotal.ToString("C")
        TxtDescuento.Text = oCompra.TotalDescuento.ToString("C")
        TxtImpuesto.Text = oCompra.TotalImpuesto.ToString("C")
        TxtTotal.Text = oCompra.Total.ToString("C")

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

        oCompra = New CompraEntity()

        TxtCodigoProveedor.Text = 0
        TxtProveedor.Text = ""
        TxtDocumento.Text = ""
        TxtCodigoCompra.Text = 0
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

    Private Function ValidarCompra() As Boolean

        If String.IsNullOrEmpty(TxtProveedor.Text) Then
            MessageBox.Show("Por favor, seleccione el proveedor", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnBuscarProveedor.Select()
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

        If Not ValidarCompra() Then
            Exit Sub
        End If

        oCompra.IdProveedor = TxtCodigoProveedor.Text
        oCompra.Fecha = DtpFecha.Value
        oCompra.FechaVenc = DtpFechaVenc.Value
        oCompra.Condicion = CboxCondicion.Text
        oCompra.Plazo = CboxPlazo.Text
        oCompra.IdEmpleado = TxtCodigoEncargado.Text

        Try
            CompraBLL.Create(oCompra)
            MessageBox.Show("Compra generada correctamente", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Inicializar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEncargado.Text = ActiveUser.Nombre & " " & ActiveUser.Apellido
        TxtCodigoEncargado.Text = ActiveUser.Id
        Inicializar()
    End Sub

End Class