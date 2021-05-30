Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class Login
    Public id_user, id_int, id_tip_user, op As Integer
    Public pass, nombre, apellido As String

    'Ruta para conectar a la DB
    'descomentar segun pc
    'Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    'Metodo de Conexión a la DB
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


    'Metodo para validar usuario
    Function usuarioRegistrado(ByVal nombreUSuario As String)

        conn.Close()
        conn.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select id_usuario,password,desc_nombre,desc_apellido,l_id_institucion,l_id_tipo_user from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = True
                id_user = dr.Item("id_usuario")
                pass = dr.Item("password")
                nombre = dr.Item("desc_nombre")
                apellido = dr.Item("desc_apellido")
                id_int = dr.Item("l_id_institucion")
                id_tip_user = dr.Item("l_id_tipo_user")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ControlBox = False
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            If usuarioRegistrado(txtUser.Text) = True Then

                If pass = txtPass.Text Then
                    'MsgBox("Bienvenido a conexion")
                    If id_tip_user = 1 Then
                        ' MsgBox("Usuario administrador general" + id_int)
                        'cambiaImagen(id_int)
                        Me.Hide()
                        Principal.Show()
                    ElseIf id_tip_user = 2 Then
                        MsgBox("Usuario admin institucional" + id_int)
                        '    cambiaImagen(id_int)
                        Me.Hide()
                        Principal.Show()
                    ElseIf id_tip_user = 3 Then
                        MsgBox("Usuario Jefe de Zona" + id_int)
                        ' cambiaImagen(id_int)
                        Me.Hide()
                        Principal.Show()
                    Else
                        'MsgBox("Usuario Operador" + id_int)
                        '  cambiaImagen(id_int)
                        Principal.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Usuario o contraseña erróneas")
                    txtUser.Clear()
                    txtPass.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtUser.Clear()
        txtPass.Clear()
    End Sub

    'Public Sub cambiaImagen(ByVal id As Integer)
    '    If id = 1 Then
    '        Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\carabineros.png")
    '    ElseIf id = 2 Then
    '        Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources'os-10.png")
    '    Else
    '        Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\pdi.png")
    '    End If
    'End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MsgBox("¿Está seguro que desea salir de la aplicación?", MsgBoxStyle.YesNo, "Salir del programa")
        If (op = 6) Then
            Me.Close()
        End If
    End Sub
End Class



