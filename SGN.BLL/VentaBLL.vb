Imports SGN.DAL
Imports SGN.Entity

Public Class VentaBLL
    Public Shared Sub Create(venta As VentaEntity)
        VentaDAL.Create(venta)
    End Sub

    Public Shared Function GetById(id As Integer) As VentaEntity
        Return VentaDAL.GetById(id)
    End Function

    Public Shared Function GetAll() As List(Of VentaEntity)
        Return VentaDAL.GetAll()
    End Function

End Class
