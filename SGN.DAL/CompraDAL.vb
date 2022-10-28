Imports SGN.Entity
Imports System.Data.SqlClient
Imports System.Transactions

Public Class CompraDAL
    Inherits BaseDAL

    Public Shared Sub Create(compra As CompraEntity)

        Using scope As New TransactionScope()

            Using conex As New SqlConnection(SqlStringConnection)

                conex.Open()

                Using cmd As New SqlCommand("AddCompra", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@idempleado", compra.IdEmpleado)
                    cmd.Parameters.AddWithValue("@idcliente", compra.IdProveedor)
                    cmd.Parameters.AddWithValue("@condition", compra.Condicion)
                    cmd.Parameters.AddWithValue("@term", compra.Plazo)
                    cmd.Parameters.AddWithValue("@date", compra.Fecha)
                    cmd.Parameters.AddWithValue("@expiration", compra.FechaVenc)
                    cmd.Parameters.AddWithValue("@tolsub", compra.TotalSubTotal)
                    cmd.Parameters.AddWithValue("@toldiscount", compra.TotalDescuento)
                    cmd.Parameters.AddWithValue("@tolimpo", compra.TotalImpuesto)
                    cmd.Parameters.AddWithValue("@toltotal", compra.Total)
                    compra.Id = Convert.ToInt32(cmd.ExecuteScalar())

                    Using cmddv As New SqlCommand("AddDetallescompras", conex)
                        cmddv.CommandType = CommandType.StoredProcedure
                        For Each detalle In compra.Detalles

                            cmddv.Parameters.Clear()

                            cmddv.Parameters.AddWithValue("@idcompra", compra.Id)
                            cmddv.Parameters.AddWithValue("@idarticulo", detalle.IdArticulo)
                            cmddv.Parameters.AddWithValue("@cant", detalle.Cantidad)
                            cmddv.Parameters.AddWithValue("@price", detalle.Precio)
                            cmddv.Parameters.AddWithValue("@discount", detalle.Descuento)
                            cmddv.Parameters.AddWithValue("@subtotal", detalle.SubTotal)
                            cmddv.Parameters.AddWithValue("@impo", detalle.Impuesto)
                            cmddv.Parameters.AddWithValue("@total", detalle.Total)
                            detalle.Id = Convert.ToInt32(cmddv.ExecuteScalar())
                        Next

                    End Using

                End Using

            End Using

            scope.Complete()

        End Using

    End Sub
    Public Shared Function GetAll() As List(Of CompraEntity)

        Dim list As New List(Of CompraEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllcompras", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Public Shared Function GetById(id As Integer) As CompraEntity

        Dim compra As CompraEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Dim cmd As New SqlCommand("GetByIdcompra", conex)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then

                compra = ConvertToObject(reader)

                cmd = New SqlCommand("SelectDetallescompra", conex)
                cmd.CommandType = CommandType.StoredProcedure

                reader.Close()
                reader = cmd.ExecuteReader()

                While reader.Read()
                    Dim det As DetalleCompraEntity = ConvertToObjectDetalle(reader)
                    compra.Detalles.Add(det)
                End While

            End If

        End Using

        Return compra

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As CompraEntity

        Dim objcompra As New CompraEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdEmpleado = Convert.ToInt32(reader(1)),
            .Fecha = Convert.ToDateTime(reader(5))
        }

        Return objcompra

    End Function

    Private Shared Function ConvertToObjectDetalle(reader As IDataReader) As DetalleCompraEntity

        Dim detalle As New DetalleCompraEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdCompra = Convert.ToInt32(reader(1)),
            .IdArticulo = Convert.ToInt32(reader(2)),
            .Cantidad = Convert.ToInt32(reader(3)),
            .Precio = Convert.ToDouble(reader(4)),
            .Descuento = Convert.ToDouble(reader(5))
        }

        Return detalle

    End Function

End Class
