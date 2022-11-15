﻿Imports SGN.BLL
Imports SGN.Entity

Public Class FrmMantenimientoMarca

    Public creating As Boolean = False
    Private Sub Nuevo()
        TxtId.Text = 0
        TxtNombre.Clear()
        TxtNombre.Select()
    End Sub

    Private Function ValidarDatos() As Boolean
        Dim resultado As Boolean = True

        ErrorProvider.Clear()

        If String.IsNullOrEmpty(TxtNombre.Text) Then
            ErrorProvider.SetError(TxtNombre, "El nombre es requerido")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub Guardar()

        If Not ValidarDatos() Then
            Return
        End If

        Dim OMarca As New MarcaEntity
        OMarca.Id = Convert.ToInt32(TxtId.Text)
        OMarca.Nombre = TxtNombre.Text

        Try
            MarcaBLL.Create(OMarca)
            MessageBox.Show("Marca guardada con exito", ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ActiveUser.Msg, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmMantenimientoMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If creating = True Then
            Nuevo()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Nuevo()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Guardar()
    End Sub

End Class