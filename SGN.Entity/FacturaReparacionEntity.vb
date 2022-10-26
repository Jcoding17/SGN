Public Class FacturaReparacionEntity

    Sub New()
        Detalles = New List(Of DetalleReparacionEntity)
    End Sub
    Public ReadOnly Property Detalles As List(Of DetalleReparacionEntity)

    Public Property Id As Integer
    Public Property IdCliente As Integer
    Public Property IdEmpleado As Integer
    Public Property IdReparacion As Integer
    Public Property Fecha As Date


    'Propiedades Calculadas'
    'Computed Properties'

    Public ReadOnly Property TotalSubTotal() As Double
        Get
            Return (From d In Detalles Select d.SubTotal).Sum()
        End Get
    End Property
    Public ReadOnly Property TotalDescuento() As Double
        Get
            Return (From d In Detalles Select d.Descuento).Sum()
        End Get
    End Property
    Public ReadOnly Property Total() As Double
        Get
            Return TotalSubTotal - TotalDescuento
        End Get
    End Property
End Class
