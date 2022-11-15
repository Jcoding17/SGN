Imports SGN.DAL
Imports SGN.Entity

Public Class CategoriaBLL
    Public Shared Sub Create(categoria As CategoriaEntity)
        If categoria.Id = 0 Then
            CategoriaDAL.Create(categoria)
        Else
            CategoriaDAL.Update(categoria)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return CategoriaDAL.Delete(id)
    End Function

    Public Shared Function GetById(id As Integer) As CategoriaEntity
        Return CategoriaDAL.GetById(id)
    End Function

    Public Shared Function GetAll() As List(Of CategoriaEntity)
        Return CategoriaDAL.GetAll()
    End Function

End Class
