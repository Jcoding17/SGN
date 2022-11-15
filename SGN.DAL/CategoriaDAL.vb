Imports SGN.Entity
Imports System.Data.SqlClient

Public Class CategoriaDAL
    Inherits BaseDAL

    Public Shared Sub Create(categoria As CategoriaEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("Addcategoria", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", categoria.Nombre)
                categoria.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(categoria As CategoriaEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("Updatecategoria", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", categoria.Nombre)
                cmd.Parameters.AddWithValue("@id", categoria.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("Deletecategoria", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetById(id As Integer) As CategoriaEntity

        Dim categoria As CategoriaEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdCategoria", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    categoria = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return categoria

    End Function

    Public Shared Function GetAll() As List(Of CategoriaEntity)

        Dim list As New List(Of CategoriaEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("GetAllcategorias", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As CategoriaEntity

        Dim cargo As New CategoriaEntity With {
            .Id = reader(0),
            .Nombre = reader(1)
        }

        Return cargo

    End Function

End Class
