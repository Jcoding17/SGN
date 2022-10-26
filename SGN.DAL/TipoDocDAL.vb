Imports System.Data.SqlClient
Imports SGN.Entity

Public Class TipoDocDAL
    Inherits BaseDAL

    Public Shared Sub Create(tipodoc As TipoDocEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("AddTipoDoc", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", tipodoc.Nombre)
                tipodoc.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(tipodoc As TipoDocEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("UpdateTipoDoc", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", tipodoc.Nombre)
                cmd.Parameters.AddWithValue("@id", tipodoc.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("DeleteTipoDoc", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetAll() As List(Of TipoDocEntity)

        Dim list As New List(Of TipoDocEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("GetAllTipoDoc", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As TipoDocEntity

        Dim tipodoc As New TipoDocEntity With {
            .Id = reader(0),
            .Nombre = reader(1)
        }

        Return tipodoc

    End Function

End Class
