Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class Login
    Dim id_int, op As Integer
    Dim conexion As conexion = New conexion()


    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    'Conexión a la DB
    Public Sub Conectar()
        Try
            conn.Open()
            '    MessageBox.Show("Conectado")
        Catch ex As Exception
            '  MessageBox.Show("Error al conectar")
        Finally
            conn.Close()
        End Try
    End Sub


    Function usuarioRegistrado(ByVal nombreUSuario As String)
        conn.Close()
        conn.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select * from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function contrasena(ByVal nombreUSuario As String)
        conn.Close()
        conn.Open()
        Dim resultado As String = ""
        Try
            comando = New SqlCommand("select password from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = dr.Item("password")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function tipoUsuario(ByVal nombreUSuario As String) As Integer
        conn.Close()
        conn.Open()
        Dim resultado As String = ""
        Try
            comando = New SqlCommand("select l_id_tipo_user from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = CInt(dr.Item("l_id_tipo_user"))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function tipoInstitucion(ByVal nombreUSuario As String) As Integer
        conn.Close()
        conn.Open()
        Dim resultado As String = ""
        Try
            comando = New SqlCommand("select l_id_institucion from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = CInt(dr.Item("l_id_institucion"))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function retornaUsuario(ByVal nombreUSuario As String)
        conn.Close()
        conn.Open()
        Dim cadena(2) As String
        Try
            comando = New SqlCommand("select id_usuario,desc_nombre,desc_apellido from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader
            If dr.Read Then
                cadena(0) = dr.Item("id_usuario")
                cadena(1) = dr.Item("desc_nombre")
                cadena(2) = dr.Item("desc_apellido")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return cadena

    End Function










    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ControlBox = False
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            If usuarioRegistrado(txtUser.Text) = True Then
                Dim contra As String = contrasena(txtUser.Text)
                Dim tipInst As String = tipoInstitucion(txtUser.Text)


                If contra = txtPass.Text Then
                    'MsgBox("Bienvenido a conexion")
                    If tipoUsuario(txtUser.Text) = 1 Then
                        MsgBox("Usuario administrador general" + tipInst)
                        id_int = CInt(tipInst)
                        cambiaImagen(id_int)
                        Me.Hide()
                        Principal.Show()
                    ElseIf tipoUsuario(txtUser.Text) = 2 Then
                        MsgBox("Usuario admin institucional" + tipInst)
                        id_int = CInt(tipInst)
                    ElseIf tipoUsuario(txtUser.Text) = 3 Then
                        MsgBox("Usuario Jefe de Zona" + tipInst)
                        id_int = CInt(tipInst)
                    Else
                        'MsgBox("Usuario Operador" + tipoInstitucion)
                        id_int = CInt(tipInst)
                        Principal.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Usuario o contraseña Incorrectas" + txtPass.Text)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub cambiaImagen(ByVal id As Integer)
        If id = 1 Then
            Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\carabineros.png")
        ElseIf id = 2 Then
            Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources'os-10.png")
        Else
            Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\pdi.png")
        End If
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MsgBox("¿Está seguro que desea salir de la aplicación?", MsgBoxStyle.YesNo, "Salir del programa")
        If (op = 6) Then
            Me.Close()
        End If
    End Sub
End Class



