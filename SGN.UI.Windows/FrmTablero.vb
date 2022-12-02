Imports SGN.BLL
Imports SGN.Entity

Public Class FrmTablero
    Private Sub FrmTablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DashBoard()
    End Sub

    Private Sub DashBoard()

        Dim dashboard As New DashboardEntity

        DashBoardBLL.DashBoard(dashboard)

        LblCantClientes.Text = dashboard.Clientes
        LblCantEmpleados.Text = dashboard.Empleados
        LblCantVentas.Text = dashboard.Ventas
        LblCantCompras.Text = dashboard.Compras
        LblCantArticulos.Text = dashboard.Articulos
        LblCantProveedores.Text = dashboard.Proveedores
        LblCantCotizaciones.Text = dashboard.Cotizaciones
        LblCantReparaciones.Text = dashboard.Reparaciones

    End Sub

End Class