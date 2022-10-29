Imports SGN.DAL
Imports SGN.Entity

Public Class FacturaReparacionBLL
    Public Shared Sub Create(factura As FacturaReparacionEntity)
        FacturaReparacionDAL.Create(factura)
    End Sub

    Public Shared Function GetById(id As Integer) As FacturaReparacionEntity
        Return FacturaReparacionDAL.GetById(id)
    End Function

    Public Shared Function GetAll() As List(Of FacturaReparacionEntity)
        Return FacturaReparacionDAL.GetAll()
    End Function

End Class
