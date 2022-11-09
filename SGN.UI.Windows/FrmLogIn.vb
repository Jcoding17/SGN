Imports System.Runtime.InteropServices
Imports SGN.BLL

Public Class FrmLogIn
    Private Sub ChkBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxShowPass.CheckedChanged
        If ChkBoxShowPass.Checked Then
            TxtPass.PasswordChar = ""
        Else
            TxtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub LogIn()

        Dim validlogin = UsuarioBLL.Login(TxtUser.Text, TxtPass.Text)

        If validlogin = True Then
            Dim frm As New FrmDashBoard()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
            Hide()
        Else
            MessageBox.Show("Nombre de usuario o contraseña incorrecto, pruebe otra vez", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPass.Clear()
            TxtUser.Select()
        End If

    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)

        TxtUser.Clear()
        TxtPass.Clear()
        Show()
        TxtUser.Select()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub FrmLogIn_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnLogIn_Click_1(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        LogIn()
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnMinimaze_Click(sender As Object, e As EventArgs) Handles BtnMinimaze.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized

        Else
            WindowState = FormWindowState.Normal

        End If
    End Sub

    Private Sub BtnLogIn_MouseMove_1(sender As Object, e As MouseEventArgs) Handles BtnLogIn.MouseMove
        BtnLogIn.BackColor = Color.FromArgb(240, 240, 240)
        BtnLogIn.ForeColor = Color.Black
    End Sub

    Private Sub BtnLogIn_MouseLeave(sender As Object, e As EventArgs) Handles BtnLogIn.MouseLeave
        BtnLogIn.BackColor = Color.FromArgb(0, 50, 154)
        BtnLogIn.ForeColor = Color.White
    End Sub

End Class