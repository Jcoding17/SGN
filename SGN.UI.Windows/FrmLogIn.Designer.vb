<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogIn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.BtnMinimaze = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnLogIn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 565)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.SGN.UI.Windows.My.Resources.Resources.login1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(483, 565)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(500, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingresar"
        '
        'ChkBoxShowPass
        '
        Me.ChkBoxShowPass.AutoSize = True
        Me.ChkBoxShowPass.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.ChkBoxShowPass.FlatAppearance.BorderSize = 0
        Me.ChkBoxShowPass.FlatAppearance.CheckedBackColor = System.Drawing.Color.HotPink
        Me.ChkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkBoxShowPass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxShowPass.ForeColor = System.Drawing.Color.Black
        Me.ChkBoxShowPass.Location = New System.Drawing.Point(507, 354)
        Me.ChkBoxShowPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkBoxShowPass.Name = "ChkBoxShowPass"
        Me.ChkBoxShowPass.Size = New System.Drawing.Size(212, 30)
        Me.ChkBoxShowPass.TabIndex = 6
        Me.ChkBoxShowPass.Text = "Mostrar contraseña"
        Me.ChkBoxShowPass.UseVisualStyleBackColor = True
        '
        'BtnMinimaze
        '
        Me.BtnMinimaze.FlatAppearance.BorderSize = 0
        Me.BtnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimaze.Image = Global.SGN.UI.Windows.My.Resources.Resources.minimize32
        Me.BtnMinimaze.Location = New System.Drawing.Point(808, 3)
        Me.BtnMinimaze.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMinimaze.Name = "BtnMinimaze"
        Me.BtnMinimaze.Size = New System.Drawing.Size(38, 38)
        Me.BtnMinimaze.TabIndex = 9
        Me.BtnMinimaze.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.SGN.UI.Windows.My.Resources.Resources.close32
        Me.BtnClose.Location = New System.Drawing.Point(856, 3)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(38, 38)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(502, 199)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(357, 38)
        Me.TxtUser.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(502, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 251)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(508, 289)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(357, 38)
        Me.TxtPass.TabIndex = 12
        '
        'BtnLogIn
        '
        Me.BtnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnLogIn.FlatAppearance.BorderSize = 0
        Me.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogIn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogIn.ForeColor = System.Drawing.Color.White
        Me.BtnLogIn.Location = New System.Drawing.Point(567, 428)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(250, 55)
        Me.BtnLogIn.TabIndex = 14
        Me.BtnLogIn.Text = "Ingresar"
        Me.BtnLogIn.UseVisualStyleBackColor = False
        '
        'FrmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(898, 565)
        Me.Controls.Add(Me.BtnLogIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.BtnMinimaze)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ChkBoxShowPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkBoxShowPass As CheckBox
    Friend WithEvents BtnMinimaze As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnLogIn As Button
End Class
