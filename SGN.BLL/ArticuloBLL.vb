Imports SGN.DAL
Imports SGN.Entity

Public Class ArticuloBLL

    Public Shared Sub Create(articulo As ArticuloEntity)
        If articulo.Id = 0 Then
            ArticuloDAL.Create(articulo)
        Else
            ArticuloDAL.Update(articulo)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return ArticuloDAL.Delete(id)
    End Function

    Public Shared Function GetById(id As Integer) As ArticuloEntity
        Return ArticuloDAL.GetById(id)
    End Function

    Public Shared Function GetByValue(value As String) As List(Of ArticuloEntity)
        Return ArticuloDAL.GetByValue(value)
    End Function

    Public Shared Function GetAll() As List(Of ArticuloEntity)
        Return ArticuloDAL.GetAll()
    End Function

End Class
