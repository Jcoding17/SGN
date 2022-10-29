Imports SGN.DAL
Imports SGN.Entity

Public Class ProveedorBLL
    Public Shared Sub Create(proveedor As ProveedorEntity)
        If proveedor.Id = 0 Then
            ProveedorDAL.Create(proveedor)
        Else
            ProveedorDAL.Update(proveedor)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return ProveedorDAL.Delete(id)
    End Function

    Public Shared Function GetById(id As Integer) As ProveedorEntity
        Return ProveedorDAL.GetById(id)
    End Function

    Public Shared Function GetByValue(value As String) As List(Of ProveedorEntity)
        Return ProveedorDAL.GetByValue(value)
    End Function

    Public Shared Function GetAll() As List(Of ProveedorEntity)
        Return ProveedorDAL.GetAll()
    End Function
End Class
