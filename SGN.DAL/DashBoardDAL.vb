Imports System.Data.SqlClient
Imports SGN.Entity

Public Class DashBoardDAL
    Inherits BaseDAL

    Public Shared Sub Dashboard(dash As DashboardEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("Dashboard", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim articulos As New SqlParameter("@articulos", 0) With {
                    .Direction = ParameterDirection.Output
                }

                Dim clientes As New SqlParameter("@clientes", 0) With {
                    .Direction = ParameterDirection.Output
                }

                Dim empleados As New SqlParameter("@empleados", 0) With {
                   .Direction = ParameterDirection.Output
                }
                Dim proveedores As New SqlParameter("@proveedores", 0) With {
                   .Direction = ParameterDirection.Output
                }
                Dim ventas As New SqlParameter("@ventas", 0) With {
                   .Direction = ParameterDirection.Output
                }
                Dim compras As New SqlParameter("@compras", 0) With {
                   .Direction = ParameterDirection.Output
                }
                Dim cotizaciones As New SqlParameter("@cotizaciones", 0) With {
                   .Direction = ParameterDirection.Output
                }
                Dim reparaciones As New SqlParameter("@reparaciones", 0) With {
                   .Direction = ParameterDirection.Output
                }

                cmd.Parameters.Add(articulos)
                cmd.Parameters.Add(clientes)
                cmd.Parameters.Add(empleados)
                cmd.Parameters.Add(proveedores)
                cmd.Parameters.Add(ventas)
                cmd.Parameters.Add(compras)
                cmd.Parameters.Add(cotizaciones)
                cmd.Parameters.Add(reparaciones)

                cmd.ExecuteNonQuery()

                dash.Articulos = cmd.Parameters("@articulos").Value.ToString()
                dash.Clientes = cmd.Parameters("@clientes").Value.ToString()
                dash.Empleados = cmd.Parameters("@empleados").Value.ToString()
                dash.Proveedores = cmd.Parameters("@proveedores").Value.ToString()
                dash.Ventas = cmd.Parameters("@ventas").Value.ToString()
                dash.Compras = cmd.Parameters("@compras").Value.ToString()
                dash.Cotizaciones = cmd.Parameters("@cotizaciones").Value.ToString()
                dash.Reparaciones = cmd.Parameters("@reparaciones").Value.ToString()

            End Using

        End Using

    End Sub

    Public Shared Sub ArtPreferidos(articulo As DashboardEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("ArtPreferidos", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    articulo.Producto.Add(reader.GetString(0))
                    articulo.Cant.Add(reader.GetInt32(1))
                End While

                reader.Close()

            End Using

        End Using

    End Sub

    Public Shared Sub ArtPorCategoria(articulo As DashboardEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("ArtPorCategoria", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    articulo.Categoria.Add(reader.GetString(0))
                    articulo.CantProducto.Add(reader.GetInt32(1))
                End While

                reader.Close()

            End Using

        End Using

    End Sub


End Class
