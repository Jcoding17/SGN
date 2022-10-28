Imports System.Data.SqlClient
Imports SGN.Entity

Public Class ArticuloDAL
    Inherits BaseDAL

    Public Shared Sub Create(articulo As ArticuloEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("AddArticulo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", articulo.Nombre)
                cmd.Parameters.AddWithValue("@idmarca", articulo.IdMarca)
                cmd.Parameters.AddWithValue("@idcategoria", articulo.IdCategoria)
                cmd.Parameters.AddWithValue("@description", articulo.Descripcion)
                cmd.Parameters.AddWithValue("@purchaseprice", articulo.PrecioCompra)
                cmd.Parameters.AddWithValue("@saleprice", articulo.PrecioVenta)
                cmd.Parameters.AddWithValue("@stock", articulo.Stock)
                articulo.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(articulo As ArticuloEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("UpdateArticulo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", articulo.Nombre)
                cmd.Parameters.AddWithValue("@idmarca", articulo.IdMarca)
                cmd.Parameters.AddWithValue("@idcategoria", articulo.IdCategoria)
                cmd.Parameters.AddWithValue("@description", articulo.Descripcion)
                cmd.Parameters.AddWithValue("@purchaseprice", articulo.PrecioCompra)
                cmd.Parameters.AddWithValue("@saleprice", articulo.PrecioVenta)
                cmd.Parameters.AddWithValue("@stock", articulo.Stock)
                cmd.Parameters.AddWithValue("@id", articulo.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("DeleteArticulo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetById(id As Integer) As ArticuloEntity

        Dim articulo As ArticuloEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdArticulo", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    articulo = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return articulo

    End Function

    Public Shared Function GetByValue(value As String) As List(Of ArticuloEntity)

        Dim list As New List(Of ArticuloEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByValueArticulo", conex)
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

    Public Shared Function GetAll() As List(Of ArticuloEntity)

        Dim list As New List(Of ArticuloEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllArticulos", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As ArticuloEntity

        Dim articulo As New ArticuloEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .Nombre = Convert.ToString(reader(1)),
            .IdMarca = Convert.ToInt32(reader(2)),
            .IdCategoria = Convert.ToInt32(reader(3)),
            .Descripcion = Convert.ToString(reader(4)),
            .PrecioCompra = Convert.ToDouble(reader(5)),
            .PrecioVenta = Convert.ToDouble(reader(6)),
            .Stock = Convert.ToInt32(reader(7))
        }

        Return articulo

    End Function
End Class
