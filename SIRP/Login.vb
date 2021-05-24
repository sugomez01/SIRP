
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
                    'MsgBox("Bienvenido a conexion")
                    If conexion.tipoUsuario(txtUser.Text) = 1 Then
                        MsgBox("Usuario administrador general" + tipoInstitucion)
                        id_int = CInt(tipoInstitucion)
                    ElseIf conexion.tipoUsuario(txtUser.Text) = 2 Then
                        MsgBox("Usuario admin institucional" + tipoInstitucion)
                        id_int = CInt(tipoInstitucion)
                    ElseIf conexion.tipoUsuario(txtUser.Text) = 3 Then
                        MsgBox("Usuario Jefe de Zona" + tipoInstitucion)
                        id_int = CInt(tipoInstitucion)
                    Else
                        MsgBox("Usuario Operador" + tipoInstitucion)
                        id_int = CInt(tipoInstitucion)
                    End If
                Else
                    MsgBox("Usuario o contraseña Incorrectas" + txtPass.Text)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MsgBox("¿Está seguro que desea salir de la aplicación?", MsgBoxStyle.YesNo, "Salir del programa")
        If (op = 6) Then
            End
        End If
    End Sub
End Class