Imports SGN.Entity
Imports System.Data.SqlClient
Imports System.Transactions

Public Class FacturaReparacionDAL
    Inherits BaseDAL

    Public Shared Sub Create(factura As FacturaReparacionEntity)

        Using scope As New TransactionScope()

            Using conex As New SqlConnection(SqlStringConnection)

                conex.Open()

                Using cmd As New SqlCommand("AddFacturaReparacion", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@idcliente", factura.IdCliente)
                    cmd.Parameters.AddWithValue("@idempleado", factura.IdEmpleado)
                    cmd.Parameters.AddWithValue("@idreparacion", factura.IdReparacion)
                    cmd.Parameters.AddWithValue("@date", factura.Fecha)
                    cmd.Parameters.AddWithValue("@toldiscount", factura.TotalDescuento)
                    cmd.Parameters.AddWithValue("@tolsub", factura.TotalSubTotal)
                    factura.Id = Convert.ToInt32(cmd.ExecuteScalar())

                    Using cmddv As New SqlCommand("AddDetallesReparaciones", conex)
                        cmd.CommandType = CommandType.StoredProcedure

                        For Each detalle In factura.Detalles

                            cmddv.Parameters.Clear()

                            cmddv.Parameters.AddWithValue("@idfacturareparacion", factura.Id)
                            cmddv.Parameters.AddWithValue("@idarticulo", detalle.Articulo)
                            cmddv.Parameters.AddWithValue("@cant", detalle.Cantidad)
                            cmddv.Parameters.AddWithValue("@price", detalle.Precio)
                            cmddv.Parameters.AddWithValue("@discount", detalle.Descuento)
                            cmddv.Parameters.AddWithValue("@subtotal", detalle.SubTotal)
                            cmddv.Parameters.AddWithValue("@total", detalle.Total)
                            detalle.Id = Convert.ToInt32(cmddv.ExecuteScalar())
                        Next

                    End Using

                End Using

            End Using

            scope.Complete()

        End Using

    End Sub
    Public Shared Function GetAll() As List(Of FacturaReparacionEntity)

        Dim list As New List(Of FacturaReparacionEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllFacturasReparaciones", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Public Shared Function GetById(id As Integer) As FacturaReparacionEntity

        Dim factura As FacturaReparacionEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Dim cmd As New SqlCommand("GetByIdFacturasReparaciones", conex)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then

                factura = ConvertToObject(reader)

                cmd = New SqlCommand("SelectDetallesReparacion", conex)
                cmd.CommandType = CommandType.StoredProcedure

                reader.Close()
                reader = cmd.ExecuteReader()

                While reader.Read()
                    Dim det As DetalleReparacionEntity = ConvertToObjectDetalle(reader)
                    factura.Detalles.Add(det)
                End While

            End If

        End Using

        Return factura

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As FacturaReparacionEntity

        Dim objfactura As New FacturaReparacionEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdCliente = Convert.ToInt32(reader(1)),
            .Fecha = Convert.ToDateTime(reader(4))
        }

        Return objfactura

    End Function

    Private Shared Function ConvertToObjectDetalle(reader As IDataReader) As DetalleReparacionEntity

        Dim detalle As New DetalleReparacionEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdFacturaReparacion = Convert.ToInt32(reader(1)),
            .Articulo = Convert.ToInt32(reader(2)),
            .Cantidad = Convert.ToInt32(reader(3)),
            .Descripcion = Convert.ToString(reader(4)),
            .Precio = Convert.ToDouble(reader(5)),
            .Descuento = Convert.ToDouble(reader(6))
        }

        Return detalle

    End Function

End Class
