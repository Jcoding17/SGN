Imports SGN.DAL
Imports SGN.Entity

Public Class ClienteBLL
    Public Shared Sub Create(cliente As ClienteEntity)
        If cliente.Id = 0 Then
            ClienteDAL.Create(cliente)
        Else
            ClienteDAL.Update(cliente)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return ClienteDAL.Delete(id)
    End Function

    Public Shared Function GetById(id As Integer) As ClienteEntity
        Return ClienteDAL.GetById(id)
    End Function

    Public Shared Function GetByValue(value As String) As List(Of ClienteEntity)
        Return ClienteDAL.GetByValue(value)
    End Function

    Public Shared Function GetAll() As List(Of ClienteEntity)
        Return ClienteDAL.GetAll()
    End Function

End Class
