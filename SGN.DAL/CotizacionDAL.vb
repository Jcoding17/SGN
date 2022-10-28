Imports SGN.Entity
Imports System.Data.SqlClient
Imports System.Transactions

Public Class CotizacionDAL
    Inherits BaseDAL

    Public Shared Sub Create(cotizacion As CotizacionEntity)

        Using scope As New TransactionScope()

            Using conex As New SqlConnection(SqlStringConnection)

                conex.Open()

                Using cmd As New SqlCommand("Addcotizacion", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@idcliente", cotizacion.IdCliente)
                    cmd.Parameters.AddWithValue("@idempleado", cotizacion.IdEmpleado)
                    cmd.Parameters.AddWithValue("@condition", cotizacion.Condicion)
                    cmd.Parameters.AddWithValue("@term", cotizacion.Plazo)
                    cmd.Parameters.AddWithValue("@date", cotizacion.Fecha)
                    cmd.Parameters.AddWithValue("@expiration", cotizacion.FechaVenc)
                    cmd.Parameters.AddWithValue("@tolsub", cotizacion.TotalSubTotal)
                    cmd.Parameters.AddWithValue("@toldiscount", cotizacion.TotalDescuento)
                    cmd.Parameters.AddWithValue("@tolimpo", cotizacion.TotalImpuesto)
                    cmd.Parameters.AddWithValue("@toltotal", cotizacion.Total)
                    cotizacion.Id = Convert.ToInt32(cmd.ExecuteScalar())

                    Using cmddv As New SqlCommand("AddDetallescotizacions", conex)
                        cmddv.CommandType = CommandType.StoredProcedure

                        For Each detalle In cotizacion.Detalles

                            cmddv.Parameters.Clear()

                            cmddv.Parameters.AddWithValue("@idcotizacion", cotizacion.Id)
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
    Public Shared Function GetAll() As List(Of CotizacionEntity)

        Dim list As New List(Of CotizacionEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllcotizaciones", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Public Shared Function GetById(id As Integer) As CotizacionEntity

        Dim cotizacion As CotizacionEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Dim cmd As New SqlCommand("GetByIdcotizacion", conex)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then

                cotizacion = ConvertToObject(reader)

                cmd = New SqlCommand("SelectDetallescotizacion", conex)
                cmd.CommandType = CommandType.StoredProcedure

                reader.Close()
                reader = cmd.ExecuteReader()

                While reader.Read()
                    Dim det As DetalleCotizacionEntity = ConvertToObjectDetalle(reader)
                    cotizacion.Detalles.Add(det)
                End While

            End If

        End Using

        Return cotizacion

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As CotizacionEntity

        Dim objcotizacion As New CotizacionEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdCliente = Convert.ToInt32(reader(1)),
            .Fecha = Convert.ToDateTime(reader(5))
        }

        Return objcotizacion

    End Function

    Private Shared Function ConvertToObjectDetalle(reader As IDataReader) As DetalleCotizacionEntity

        Dim detalle As New DetalleCotizacionEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdCotizacion = Convert.ToInt32(reader(1)),
            .IdArticulo = Convert.ToInt32(reader(2)),
            .Cantidad = Convert.ToInt32(reader(3)),
            .Precio = Convert.ToDouble(reader(4)),
            .Descuento = Convert.ToDouble(reader(5))
        }

        Return detalle

    End Function

End Class
