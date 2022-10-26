Public Class DetalleReparacionEntity
    Public Property Id As Integer
    Public Property IdFacturaReparacion As Integer
    Public Property Articulo As String
    Public Property Cantidad As Integer
    Public Property Descripcion As String
    Public Property Precio As Double
    Public Property Descuento As Double

    'Propiedades Calculadas'
    'Computed Properties'

    Public ReadOnly Property SubTotal() As Double
        Get
            Return Cantidad * Precio
        End Get
    End Property
    Public ReadOnly Property Total() As Double
        Get
            Return SubTotal - Descuento
        End Get
    End Property

End Class
