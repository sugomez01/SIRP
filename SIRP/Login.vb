
Public Class Login
    Dim id_int, op As Integer
    Dim conexion As conexion = New conexion()


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        ControlBox = False
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            If conexion.usuarioRegistrado(txtUser.Text) = True Then
                Dim contra As String = conexion.contrasena(txtUser.Text)
                Dim tipoInstitucion As String = conexion.tipoInstitucion(txtUser.Text)

                If contra = txtPass.Text Then
                    MsgBox("Bienvenido a conexion")
                    If conexion.tipoUsuario(txtUser.Text) = 1 Then
                        MsgBox("administrador y su institucion es" + tipoInstitucion)
                    ElseIf conexion.tipoUsuario(txtUser.Text) = 2 Then
                        MsgBox("Jefe de Zona y su institucion es" + tipoInstitucion)
                    Else
                        MsgBox("Operador´y su institucion es" + tipoInstitucion)
                    End If
                Else
                    MsgBox("Usuario o contraseña Incorrectas" + txtPass.Text + " ** " + contra)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

<<<<<<< HEAD
    Private Sub Label3_Click(sender As Object, e As EventArgs)
=======
    Private Sub Label3_Click(sender As Object, e As EventArgs) 
>>>>>>> 70254a2f638ff4c8a3887eec2f5e21262f37ffc0

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MessageBox.Show("¿Está seguro que desea salir del sistema?")
        If op = 6 Then
            Me.Close()
        End If
    End Sub
End Class