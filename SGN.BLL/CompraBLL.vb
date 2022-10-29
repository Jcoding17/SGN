Imports SGN.DAL
Imports SGN.Entity

Public Class CompraBLL
    Public Shared Sub Create(compra As CompraEntity)
        CompraDAL.Create(compra)
    End Sub

    Public Shared Function GetById(id As Integer) As CompraEntity
        Return CompraDAL.GetById(id)
    End Function

    Public Shared Function GetAll() As List(Of CompraEntity)
        Return CompraDAL.GetAll()
    End Function

End Class
