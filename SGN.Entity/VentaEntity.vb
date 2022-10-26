Public Class VentaEntity

    Sub New()
        Detalles = New List(Of DetalleVentaEntity)
    End Sub
    Public ReadOnly Property Detalles As List(Of DetalleVentaEntity)

    Public Property Id As Integer
    Public Property IdCliente As Integer
    Public Property IdEmpleado As Integer
    Public Property Condicion As String
    Public Property Plazo As String
    Public Property Fecha As Date
    Public Property FechaVenc As Date

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
    Public ReadOnly Property TotalImpuesto() As Double
        Get
            Return (From d In Detalles Select d.Impuesto).Sum()
        End Get
    End Property
    Public ReadOnly Property Total() As Double
        Get
            Return TotalSubTotal - TotalDescuento + TotalImpuesto
        End Get
    End Property

End Class
