Imports System.Data.SqlClient
Imports SGN.Entity

Public Class ReparacionDAL
    Inherits BaseDAL

    Public Shared Sub Create(reparacion As ReparacionEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("AddReparacion", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idcliente", reparacion.IdCliente)
                cmd.Parameters.AddWithValue("@idempleado", reparacion.IdEmpleado)
                cmd.Parameters.AddWithValue("@enterdate", reparacion.FechaEntrada)
                cmd.Parameters.AddWithValue("@outdate", reparacion.FechaSalida)
                cmd.Parameters.AddWithValue("@description", reparacion.Descripcion)
                cmd.Parameters.AddWithValue("@status", reparacion.Estado)
                reparacion.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(reparacion As ReparacionEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("UpdateEstadoReparacion", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@status", reparacion.Estado)
                cmd.Parameters.AddWithValue("@id", reparacion.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    Public Shared Function GetById(id As Integer) As ReparacionEntity

        Dim reparacion As ReparacionEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdreparacion", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    reparacion = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return reparacion

    End Function

    Public Shared Function GetAll() As List(Of ReparacionEntity)

        Dim list As New List(Of ReparacionEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllreparaciones", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As ReparacionEntity

        Dim reparacion As New ReparacionEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .IdCliente = Convert.ToInt32(reader(1)),
            .IdEmpleado = Convert.ToInt32(reader(2)),
            .FechaEntrada = Convert.ToDateTime(reader(3)),
            .FechaSalida = Convert.ToDateTime(reader(4)),
            .Descripcion = Convert.ToString(reader(5)),
            .Estado = Convert.ToString(reader(6))
        }

        Return reparacion

    End Function

End Class
