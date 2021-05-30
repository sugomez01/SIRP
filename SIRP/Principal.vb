Imports System.Data.SqlClient

Public Class Principal
    Dim id_user, id_int, id_tip_user, op As Integer
    Dim pass, nombre, apellido As String

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
        Catch ex As Exception
            MessageBox.Show("Error al conectar" + ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CrearInstituciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearInstituciónToolStripMenuItem.Click
        Me.Hide()
        AgregaInstitucion.Show()
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

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        bienvenidaUser(id_int)
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub RegistrarDelincuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarDelincuenteToolStripMenuItem.Click
        IngresaDelincuente.Show()
        Me.Close()
    End Sub

    Public Sub bienvenidaUser(ByVal id As Integer)
        usuarioRegistrado(Login.txtUser.Text)

        lblBienvenido.Text = "Bienvenid@ " + nombre + " " + apellido
        If id = 1 Then
            picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\carabineros.png")
        ElseIf id = 2 Then
            picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources'os-10.png")
        Else
            picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\pdi.png")
        End If
    End Sub

End Class