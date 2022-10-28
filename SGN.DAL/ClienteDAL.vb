Imports System.Data.SqlClient
Imports SGN.Entity

Public Class ClienteDAL
    Inherits BaseDAL

    Public Shared Sub Create(cliente As ClienteEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("AddCliente", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", cliente.Nombre)
                cmd.Parameters.AddWithValue("@lastname", cliente.Apellido)
                cmd.Parameters.AddWithValue("@iddoc", cliente.IdDoc)
                cmd.Parameters.AddWithValue("@nodoc", cliente.NoDoc)
                cmd.Parameters.AddWithValue("@phone", cliente.Telefono)
                cmd.Parameters.AddWithValue("@email", cliente.Email)
                cmd.Parameters.AddWithValue("@adress", cliente.Direccion)
                cliente.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(cliente As ClienteEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("UpdateCliente", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", cliente.Nombre)
                cmd.Parameters.AddWithValue("@lastname", cliente.Apellido)
                cmd.Parameters.AddWithValue("@iddoc", cliente.IdDoc)
                cmd.Parameters.AddWithValue("@nodoc", cliente.NoDoc)
                cmd.Parameters.AddWithValue("@phone", cliente.Telefono)
                cmd.Parameters.AddWithValue("@email", cliente.Email)
                cmd.Parameters.AddWithValue("@adress", cliente.Direccion)
                cmd.Parameters.AddWithValue("@id", cliente.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("DeleteCliente", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetById(id As Integer) As ClienteEntity

        Dim cliente As ClienteEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdCliente", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    cliente = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return cliente

    End Function

    Public Shared Function GetByValue(value As String) As List(Of ClienteEntity)

        Dim list As New List(Of ClienteEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByValueCliente", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@value", value)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While
            End Using

        End Using

        Return list

    End Function

    Public Shared Function GetAll() As List(Of ClienteEntity)

        Dim list As New List(Of ClienteEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllClientes", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As ClienteEntity

        Dim cliente As New ClienteEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .Nombre = Convert.ToString(reader(1)),
            .Apellido = Convert.ToString(reader(2)),
            .IdDoc = Convert.ToInt32(reader(3)),
            .NoDoc = Convert.ToString(reader(4)),
            .Telefono = Convert.ToString(reader(5)),
            .Email = Convert.ToString(reader(6)),
            .Direccion = Convert.ToString(reader(7))
        }

        Return cliente

    End Function


End Class
