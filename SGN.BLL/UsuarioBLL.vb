Imports SGN.DAL
Imports SGN.Entity

Public Class UsuarioBLL
    Public Shared Sub Create(usuario As UsuarioEntity)
        If usuario.Id = 0 Then
            UsuarioDAL.Create(usuario)
        Else
            UsuarioDAL.Update(usuario)
        End If
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean
        Return UsuarioDAL.Delete(id)
    End Function

    Public Shared Function GetAll() As List(Of UsuarioEntity)
        Return UsuarioDAL.GetAll()
    End Function

    Public Shared Function Login(user As String, pass As String) As Boolean
        Return UsuarioDAL.Login(user, pass)
    End Function

End Class
