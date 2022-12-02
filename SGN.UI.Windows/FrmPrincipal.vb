Imports System.Runtime.InteropServices
Imports SGN.Entity

Public Class FrmPrincipal

    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(5, 40)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            'Button'
            currentBtn = CType(senderBtn, Button)
            'Left Border'
            leftBorderBtn.BackColor = Color.FromArgb(41, 94, 204)
            leftBorderBtn.Location = New Point(1, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        Lbltitle.Text = childForm.Text.ToUpper()
    End Sub
    Private Sub Reset()
        leftBorderBtn.Visible = False
        Lbltitle.Text = "Home"
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Collapsemenu()

        If Me.PanelMenu.Width > 200 Then
            PanelMenu.Width = 122
            PboxLogo.Visible = False
            BtnTogleMenu.Dock = DockStyle.Top

            For Each menubutton As Button In PanelMenu.Controls.OfType(Of Button)
                menubutton.Text = ""
                menubutton.ImageAlign = ContentAlignment.MiddleCenter
                menubutton.Padding = New Padding(0)
            Next

            hideSubmenu()
        Else
            PanelMenu.Width = 210
            PboxLogo.Visible = True
            BtnTogleMenu.Dock = DockStyle.None

            For Each menubutton As Button In PanelMenu.Controls.OfType(Of Button)
                menubutton.Text = "  " + menubutton.Tag.ToString()
                menubutton.ImageAlign = ContentAlignment.MiddleLeft
                menubutton.Padding = New Padding(10, 0, 0, 0)
            Next
            hideSubmenu()
        End If

    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            If PanelMenu.Width = 122 Then
                For Each menubutton As Button In submenu.Controls.OfType(Of Button)
                    menubutton.Text = ""
                    menubutton.Padding = New Padding(40, 0, 0, 0)
                Next
            ElseIf PanelMenu.Width = 210 Then
                For Each menubutton As Button In submenu.Controls.OfType(Of Button)
                    menubutton.Text = "  " + menubutton.Tag.ToString()
                Next
            End If
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub hideSubmenu()
        PanelSubMenuVentas.Visible = False
        PanelSubMenuCompras.Visible = False
    End Sub

    Private Sub FrmDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = ActiveUser.Nombre & " " & ActiveUser.Apellido
        Collapsemenu()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MessageBox.Show("¿Seguro que desea cerrar la aplicacion?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
            DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnMaximaze_Click(sender As Object, e As EventArgs) Handles BtnMaximaze.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BtnMinimaze_Click(sender As Object, e As EventArgs) Handles BtnMinimaze.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmDashBoard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LblFecha.Text = Date.Today.ToLongDateString()
        LblHora.Text = Date.Now.ToLongTimeString()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        If MessageBox.Show("¿Seguro que desea cerrar session?", ActiveUser.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
            DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub BtnTogleMenu_Click(sender As Object, e As EventArgs) Handles BtnTogleMenu.Click
        Collapsemenu()
    End Sub

    Private Sub BtnDashBoard_Click(sender As Object, e As EventArgs) Handles BtnDashBoard.Click
        hideSubmenu()
        ActivateButton(sender)
        OpenChildForm(New FrmTablero)
    End Sub

    Private Sub BtnClintes_Click(sender As Object, e As EventArgs) Handles BtnClintes.Click
        hideSubmenu()
        ActivateButton(sender)
        OpenChildForm(New FrmBuscarClientes)
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        hideSubmenu()
        ActivateButton(sender)
        OpenChildForm(New FrmBuscarEmpleados)
    End Sub

    Private Sub BtnArticulos_Click(sender As Object, e As EventArgs) Handles BtnArticulos.Click
        hideSubmenu()
        ActivateButton(sender)
        OpenChildForm(New FrmBuscarArticulos)
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        showSubmenu(PanelSubMenuVentas)
        ActivateButton(sender)
    End Sub

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles BtnVender.Click
        OpenChildForm(New FrmVenta)
    End Sub

    Private Sub BtnCotizar_Click(sender As Object, e As EventArgs) Handles BtnCotizar.Click
        OpenChildForm(New FrmCotizacion)
    End Sub

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        showSubmenu(PanelSubMenuCompras)
        ActivateButton(sender)
    End Sub

    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click
        OpenChildForm(New FrmCompra)
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        OpenChildForm(New FrmBuscarProveedores)
    End Sub

    Private Sub PboxLogo_Click(sender As Object, e As EventArgs) Handles PboxLogo.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub BtnReportesDeVentas_Click(sender As Object, e As EventArgs) Handles BtnReportesDeVentas.Click
        OpenChildForm(New FrmTop10ArticulosReporte)
    End Sub

    Private Sub BtnReparaciones_Click(sender As Object, e As EventArgs) Handles BtnReparaciones.Click
        hideSubmenu()
        ActivateButton(sender)
        OpenChildForm(New FrmReparaciones)
    End Sub

End Class