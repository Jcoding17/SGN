Imports System.Data.SqlClient
Imports SGN.Entity

Public Class EmpleadoDAL
    Inherits BaseDAL

    Public Shared Sub Create(empleado As EmpleadoEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("AddEmpleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", empleado.Nombre)
                cmd.Parameters.AddWithValue("@lastname", empleado.Apellido)
                cmd.Parameters.AddWithValue("@age", empleado.Edad)
                cmd.Parameters.AddWithValue("@iddoc", empleado.IdDoc)
                cmd.Parameters.AddWithValue("@nodoc", empleado.NoDoc)
                cmd.Parameters.AddWithValue("@phone", empleado.Telefono)
                cmd.Parameters.AddWithValue("@email", empleado.Email)
                cmd.Parameters.AddWithValue("@adress", empleado.Direccion)
                cmd.Parameters.AddWithValue("@idcargo", empleado.IdCargo)
                empleado.Id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        End Using

    End Sub

    Public Shared Sub Update(empleado As EmpleadoEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("UpdateEmpleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", empleado.Nombre)
                cmd.Parameters.AddWithValue("@lastname", empleado.Apellido)
                cmd.Parameters.AddWithValue("@age", empleado.Edad)
                cmd.Parameters.AddWithValue("@iddoc", empleado.IdDoc)
                cmd.Parameters.AddWithValue("@nodoc", empleado.NoDoc)
                cmd.Parameters.AddWithValue("@phone", empleado.Telefono)
                cmd.Parameters.AddWithValue("@email", empleado.Email)
                cmd.Parameters.AddWithValue("@adress", empleado.Direccion)
                cmd.Parameters.AddWithValue("@idcargo", empleado.IdCargo)
                cmd.Parameters.AddWithValue("@id", empleado.Id)
                cmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    Public Shared Function Delete(id As Integer) As Boolean

        Dim isdeleted As Boolean

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("DeleteEmpleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)
                isdeleted = cmd.ExecuteNonQuery() > 0
            End Using

        End Using

        Return isdeleted

    End Function

    Public Shared Function GetById(id As Integer) As EmpleadoEntity

        Dim empleado As EmpleadoEntity = Nothing

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByIdEmpleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    empleado = ConvertToObject(reader)
                End If
            End Using

        End Using

        Return empleado

    End Function

    Public Shared Function GetByValue(value As String) As List(Of EmpleadoEntity)

        Dim list As New List(Of EmpleadoEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetByValueEmpleado", conex)
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

    Public Shared Function GetAll() As List(Of EmpleadoEntity)

        Dim list As New List(Of EmpleadoEntity)

        Using conex As New SqlConnection(SqlStringConnection)

            conex.Open()

            Using cmd As New SqlCommand("GetAllEmpleados", conex)
                cmd.CommandType = CommandType.StoredProcedure

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    list.Add(ConvertToObject(reader))
                End While

            End Using

        End Using

        Return list

    End Function

    Private Shared Function ConvertToObject(reader As IDataReader) As EmpleadoEntity

        Dim empleado As New EmpleadoEntity With {
            .Id = Convert.ToInt32(reader(0)),
            .Nombre = Convert.ToString(reader(1)),
            .Apellido = Convert.ToString(reader(2)),
            .Edad = Convert.ToInt32(reader(3)),
            .IdDoc = Convert.ToInt32(reader(4)),
            .NoDoc = Convert.ToString(reader(5)),
            .Telefono = Convert.ToString(reader(6)),
            .Email = Convert.ToString(reader(7)),
            .Direccion = Convert.ToString(reader(8)),
            .IdCargo = Convert.ToInt32(reader(9))
        }

        Return empleado

    End Function
End Class
