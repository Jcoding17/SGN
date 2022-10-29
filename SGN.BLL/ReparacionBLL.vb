Imports SGN.DAL
Imports SGN.Entity

Public Class ReparacionBLL
    Public Shared Sub Create(reparacion As ReparacionEntity)
        If reparacion.Id = 0 Then
            ReparacionDAL.Create(reparacion)
        Else
            ReparacionDAL.Update(reparacion)
        End If
    End Sub

    Public Shared Function GetById(id As Integer) As ReparacionEntity
        Return ReparacionDAL.GetById(id)
    End Function

    Public Shared Function GetAll() As List(Of ReparacionEntity)
        Return ReparacionDAL.GetAll()
    End Function

End Class
