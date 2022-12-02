<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTop10ArticulosReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Top10ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Top10Articulos = New SGN.UI.Windows.Top10Articulos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Top10ArticulosTableAdapter = New SGN.UI.Windows.Top10ArticulosTableAdapters.Top10ArticulosTableAdapter()
        CType(Me.Top10ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top10Articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Top10ArticulosBindingSource
        '
        Me.Top10ArticulosBindingSource.DataMember = "Top10Articulos"
        Me.Top10ArticulosBindingSource.DataSource = Me.Top10Articulos
        '
        'Top10Articulos
        '
        Me.Top10Articulos.DataSetName = "Top10Articulos"
        Me.Top10Articulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Top10Articulos"
        ReportDataSource1.Value = Me.Top10ArticulosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SGN.UI.Windows.Top10MasVendidosReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Padding = New System.Windows.Forms.Padding(10)
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(929, 664)
        Me.ReportViewer1.TabIndex = 0
        '
        'Top10ArticulosTableAdapter
        '
        Me.Top10ArticulosTableAdapter.ClearBeforeFill = True
        '
        'FrmTop10ArticulosReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 664)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmTop10ArticulosReporte"
        Me.Text = "Top 10 ArticulosReporte"
        CType(Me.Top10ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top10Articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Top10Articulos As Top10Articulos
    Friend WithEvents Top10ArticulosBindingSource As BindingSource
    Friend WithEvents Top10ArticulosTableAdapter As Top10ArticulosTableAdapters.Top10ArticulosTableAdapter
End Class
