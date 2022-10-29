Imports SGN.DAL
Imports SGN.Entity

Public Class CargoBLL
    Public Shared Sub Create(cargo As CargoEntity)
        If cargo.Id = 0 Then
            CargoDAL.Create(cargo)
        Else
            CargoDAL.Update(cargo)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return CargoDAL.Delete(id)
    End Function

    Public Shared Function GetAll() As List(Of CargoEntity)
        Return CargoDAL.GetAll()
    End Function

End Class
