Public Class FrmTop10ArticulosReporte
    Private Sub FrmTop10ArticulosReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Top10Articulos._Top10Articulos' Puede moverla o quitarla según sea necesario.
        Me.Top10ArticulosTableAdapter.Fill(Me.Top10Articulos._Top10Articulos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class