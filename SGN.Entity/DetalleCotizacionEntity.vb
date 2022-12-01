Public Class DetalleCotizacionEntity
    Public Property Id As Integer
    Public Property IdCotizacion As Integer
    Public Property IdArticulo As Integer
    Public Property NombreArticulo() As String
    Public Property Cantidad As Integer
    Public Property Precio As Double
    Public Property Descuento As Double

    'Propiedades Calculadas'
    'Computed Propierties'

    Public ReadOnly Property SubTotal() As Double
        Get
            Return Precio * Cantidad
        End Get
    End Property
    Public ReadOnly Property Impuesto() As Double
        Get
            Return SubTotal * 0.18
        End Get
    End Property
    Public ReadOnly Property Total() As Double
        Get
            Return SubTotal - Descuento + Impuesto
        End Get
    End Property
End Class
