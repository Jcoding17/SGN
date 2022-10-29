Imports SGN.DAL
Imports SGN.Entity

Public Class MarcaBLL
    Public Shared Sub Create(marca As MarcaEntity)
        If marca.Id = 0 Then
            MarcaDAL.Create(marca)
        Else
            MarcaDAL.Update(marca)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return MarcaDAL.Delete(id)
    End Function

    Public Shared Function GetAll() As List(Of MarcaEntity)
        Return MarcaDAL.GetAll()
    End Function

End Class
