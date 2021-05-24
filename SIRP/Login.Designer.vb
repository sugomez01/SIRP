<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(277, 259)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(131, 17)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Nombre de Usuario"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(277, 302)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(81, 17)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "Contraseña"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(444, 256)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(163, 22)
        Me.txtUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(444, 299)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(163, 22)
        Me.txtPass.TabIndex = 4
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(514, 340)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(93, 25)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = Global.SIRP.My.Resources.Resources.LOGO
        Me.picLogo.Location = New System.Drawing.Point(0, -1)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(490, 292)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 393)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(142, 25)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir del sistema"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 448)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.picLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
End Class
