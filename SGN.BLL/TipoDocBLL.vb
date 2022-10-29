Imports SGN.DAL
Imports SGN.Entity

Public Class TipoDocBLL
    Public Shared Sub Create(tipodoc As TipoDocEntity)
        If tipodoc.Id = 0 Then
            TipoDocDAL.Create(tipodoc)
        Else
            TipoDocDAL.Update(tipodoc)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return TipoDocDAL.Delete(id)
    End Function

    Public Shared Function GetAll() As List(Of TipoDocEntity)
        Return TipoDocDAL.GetAll()
    End Function
End Class
