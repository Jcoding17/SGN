Imports SGN.Entity
Imports System.Data.SqlClient

Public Class CargoDAL
    Inherits BaseDAL

    Public Shared Sub Create(cargo As CargoEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("AddCargo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", cargo.Nombre)
                cargo.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(cargo As CargoEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("UpdateCargo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", cargo.Nombre)
                cmd.Parameters.AddWithValue("@id", cargo.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("DeleteCargo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetAll() As List(Of CargoEntity)

        Dim list As New List(Of CargoEntity)

        Using conex As New SqlConnection(SqlStringConnection)
            conex.Open()

            Using cmd As New SqlCommand("GetAllCargos", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As CargoEntity

        Dim tipodoc As New CargoEntity With {
            .Id = reader(0),
            .Nombre = reader(1)
        }

        Return tipodoc

    End Function
End Class
