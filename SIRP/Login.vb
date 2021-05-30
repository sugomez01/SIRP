Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class Login
    Public id_user, id_int, id_tip_user, op As Integer
    Public nombre, apellido, pass As String

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

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    'Metodo de Conexión a la DB
    Public Sub Conectar()
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar" + ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

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
                nombre = dr.Item("desc_nombre")
                apellido = dr.Item("desc_apellido")
                pass = dr.Item("password")
                id_int = dr.Item("l_id_institucion")
                id_tip_user = dr.Item("l_id_tipo_user")
            Else
                resultado = False
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
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Debe ingresar datos")
            txtUser.Clear()
            txtPass.Clear()
        Else
            Try
                If usuarioRegistrado(txtUser.Text) = True Then

                    If pass = txtPass.Text Then
                        If id_tip_user = 1 Then
                            Me.Hide()
                            Principal.Show()
                        ElseIf id_tip_user = 2 Then
                            Me.Hide()
                            Principal.Show()
                        ElseIf id_tip_user = 3 Then
                            Me.Hide()
                            Principal.Show()
                        Else
                            Principal.Show()
                            Me.Hide()
                        End If
                    Else
                        MsgBox("Usuario o contraseña erróneas")
                        txtUser.Clear()
                        txtPass.Clear()
                    End If
                Else
                    MsgBox("Usuario no existe")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txtUser.Clear()
            txtPass.Clear()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MsgBox("¿Está seguro que desea salir de la aplicación?", MsgBoxStyle.YesNo, "Salir del programa")
        If (op = 6) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        'valida el campo de texto
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MsgBox("No debe ingresar espacios")
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        'valida el campo de texto
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MsgBox("No debe ingresar espacios")
        End If
    End Sub
End Class
