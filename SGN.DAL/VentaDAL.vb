Imports System.Data.SqlClient
Imports System.Transactions
Imports SGN.Entity

Public Class VentaDAL
    Inherits BaseDAL

    Public Shared Sub Create(venta As VentaEntity)

        Using scope As New TransactionScope()

            Using conex As New SqlConnection(SqlStringConnection)

                conex.Open()

                Using cmd As New SqlCommand("Addventa", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@idcliente", venta.IdCliente)
                    cmd.Parameters.AddWithValue("@idempleado", venta.IdEmpleado)
                    cmd.Parameters.AddWithValue("@condition", venta.Condicion)
                    cmd.Parameters.AddWithValue("@term", venta.Plazo)
                    cmd.Parameters.AddWithValue("@date", venta.Fecha)
                    cmd.Parameters.AddWithValue("@expiration", venta.FechaVenc)
                    cmd.Parameters.AddWithValue("@tolsub", venta.TotalSubTotal)
                    cmd.Parameters.AddWithValue("@toldiscount", venta.TotalDescuento)
                    cmd.Parameters.AddWithValue("@tolimpo", venta.TotalImpuesto)
                    cmd.Parameters.AddWithValue("@toltotal", venta.Total)
                    venta.Id = Convert.ToInt32(cmd.ExecuteScalar())

                    Using cmddv As New SqlCommand("AddDetallesVentas", conex)
                        cmddv.CommandType = CommandType.StoredProcedure

                        For Each detalle In venta.Detalles

                            cmddv.Parameters.Clear()

                            cmddv.Parameters.AddWithValue("@idventa", venta.Id)
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
    Public Shared Function GetAll() As List(Of VentaEntity)

        Dim list As New List(Of VentaEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllVentas", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Public Shared Function GetById(id As Integer) As VentaEntity

        Dim venta As VentaEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Dim cmd As New SqlCommand("GetByIdVenta", conex)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then

                venta = ConvertToObject(reader)

                cmd = New SqlCommand("SelectDetallesVenta", conex)
                cmd.CommandType = CommandType.StoredProcedure

                reader.Close()
                reader = cmd.ExecuteReader()

                While reader.Read()
                    Dim det As DetalleVentaEntity = ConvertToObjectDetalle(reader)
                    venta.Detalles.Add(det)
                End While

            End If

        End Using

        Return venta

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As VentaEntity

        Dim objventa As New VentaEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdCliente = Convert.ToInt32(reader(1)),
            .Fecha = Convert.ToDateTime(reader(5))
        }

        Return objventa

    End Function

    Private Shared Function ConvertToObjectDetalle(reader As IDataReader) As DetalleVentaEntity

        Dim detalle As New DetalleVentaEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdVenta = Convert.ToInt32(reader(1)),
            .IdArticulo = Convert.ToInt32(reader(2)),
            .Cantidad = Convert.ToInt32(reader(3)),
            .Precio = Convert.ToDouble(reader(4)),
            .Descuento = Convert.ToDouble(reader(5))
        }

        Return detalle

    End Function

End Class
