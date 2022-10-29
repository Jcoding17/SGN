Imports SGN.DAL
Imports SGN.Entity

Public Class CotizacionBLL
    Public Shared Sub Create(cotizacion As CotizacionEntity)
        CotizacionDAL.Create(cotizacion)
    End Sub

    Public Shared Function GetById(id As Integer) As CotizacionEntity
        Return CotizacionDAL.GetById(id)
    End Function

    Public Shared Function GetAll() As List(Of CotizacionEntity)
        Return CotizacionDAL.GetAll()
    End Function

End Class
