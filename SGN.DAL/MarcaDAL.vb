Imports SGN.Entity
Imports System.Data.SqlClient

Public Class MarcaDAL
    Inherits BaseDAL

    Public Shared Sub Create(marca As MarcaEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("AddMarca", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", marca.Nombre)
                marca.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(marca As MarcaEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("UpdateMarca", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", marca.Nombre)
                cmd.Parameters.AddWithValue("@id", marca.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("DeleteMarca", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetById(id As Integer) As MarcaEntity

        Dim marca As MarcaEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdMarca", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    marca = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return marca

    End Function

    Public Shared Function GetAll() As List(Of MarcaEntity)

        Dim list As New List(Of MarcaEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("GetAllMarcas", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As MarcaEntity

        Dim marca As New MarcaEntity With {
            .Id = reader(0),
            .Nombre = reader(1)
        }

        Return marca

    End Function

End Class
