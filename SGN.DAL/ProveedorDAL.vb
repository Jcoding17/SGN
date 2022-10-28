Imports SGN.Entity
Imports System.Data.SqlClient

Public Class ProveedorDAL
    Inherits BaseDAL

    Public Shared Sub Create(proveedor As ProveedorEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("Addproveedor", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", proveedor.Nombre)
                cmd.Parameters.AddWithValue("@iddoc", proveedor.IdDoc)
                cmd.Parameters.AddWithValue("@nodoc", proveedor.NoDoc)
                cmd.Parameters.AddWithValue("@phone", proveedor.Telefono)
                cmd.Parameters.AddWithValue("@email", proveedor.Email)
                cmd.Parameters.AddWithValue("@adress", proveedor.Direccion)
                proveedor.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(proveedor As ProveedorEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("UpdateProveedor", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", proveedor.Nombre)
                cmd.Parameters.AddWithValue("@iddoc", proveedor.IdDoc)
                cmd.Parameters.AddWithValue("@nodoc", proveedor.NoDoc)
                cmd.Parameters.AddWithValue("@phone", proveedor.Telefono)
                cmd.Parameters.AddWithValue("@email", proveedor.Email)
                cmd.Parameters.AddWithValue("@adress", proveedor.Direccion)
                cmd.Parameters.AddWithValue("@id", proveedor.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("DeleteProveedor", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetById(id As Integer) As ProveedorEntity

        Dim proveedor As ProveedorEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdProveedor", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    proveedor = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return proveedor

    End Function

    Public Shared Function GetByValue(value As String) As List(Of ProveedorEntity)

        Dim list As New List(Of ProveedorEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByValueProveedor", conex)
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

    Public Shared Function GetAll() As List(Of ProveedorEntity)

        Dim list As New List(Of ProveedorEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllProveedores", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As ProveedorEntity

        Dim proveedor As New ProveedorEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .Nombre = Convert.ToString(reader(1)),
            .IdDoc = Convert.ToInt32(reader(2)),
            .NoDoc = Convert.ToString(reader(3)),
            .Telefono = Convert.ToString(reader(4)),
            .Email = Convert.ToString(reader(5)),
            .Direccion = Convert.ToString(reader(6))
        }

        Return proveedor

    End Function

End Class
