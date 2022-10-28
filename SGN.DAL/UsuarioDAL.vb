Imports System.Data.SqlClient
Imports SGN.Entity

Public Class UsuarioDAL
    Inherits BaseDAL

    Public Shared Sub Create(user As UsuarioEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("AddUser", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@user", user.Nombre)
                cmd.Parameters.AddWithValue("@pass", user.Clave)
                cmd.Parameters.AddWithValue("@tipo", user.TipoUsuario)
                cmd.Parameters.AddWithValue("@idempleado", user.IdEmpleado)
                user.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(user As UsuarioEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("UpdateUser", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@user", user.Nombre)
                cmd.Parameters.AddWithValue("@pass", user.Clave)
                cmd.Parameters.AddWithValue("@tipo", user.TipoUsuario)
                cmd.Parameters.AddWithValue("@idempleado", user.IdEmpleado)
                cmd.Parameters.AddWithValue("@id", user.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("DeleteUser", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetAll() As List(Of UsuarioEntity)

        Dim list As New List(Of UsuarioEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllUsers", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As UsuarioEntity

        Dim user As New UsuarioEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .Nombre = Convert.ToString(reader(1)),
            .Clave = Convert.ToString(reader(2)),
            .TipoUsuario = Convert.ToString(reader(3)),
            .IdEmpleado = Convert.ToInt32(reader(4))
        }

        Return user

    End Function

    Public Shared Function Login(username As String, pass As String) As Boolean

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("Log_in", conex)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", pass)

                Dim reader = cmd.ExecuteReader()

                If reader.HasRows Then

                    While reader.Read()
                        'Aqui guardamos los datos del usuario que se esta logeando en el sistema'
                        ActiveUser.Nombre = reader.GetString(0)
                        ActiveUser.Id = reader.GetInt32(1)
                        ActiveUser.Cargo = reader.GetString(2)
                    End While

                    Return True
                Else
                    Return False
                End If

            End Using

        End Using

    End Function

End Class
