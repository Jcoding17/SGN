Imports SGN.DAL
Imports SGN.Entity

Public Class EmpleadoBLL
    Public Shared Sub Create(empleado As EmpleadoEntity)
        If empleado.Id = 0 Then
            EmpleadoDAL.Create(empleado)
        Else
            EmpleadoDAL.Update(empleado)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return EmpleadoDAL.Delete(id)
    End Function

    Public Shared Function GetById(id As Integer) As EmpleadoEntity
        Return EmpleadoDAL.GetById(id)
    End Function

    Public Shared Function GetByValue(value As String) As List(Of EmpleadoEntity)
        Return EmpleadoDAL.GetByValue(value)
    End Function

    Public Shared Function GetAll() As List(Of EmpleadoEntity)
        Return EmpleadoDAL.GetAll()
    End Function

End Class
