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


    'Carga pagina Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        validaUser(Login.id_tip_user)
        bienvenidaUser(Login.id_int)
    End Sub

    'Menu
    Private Sub CrearInstituciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaInstitucion.Click
        AgregaInstitucion.Show()
    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaUser.Click
        IngresoUsuario.Show()
    End Sub

    Private Sub CreaZona_Click(sender As Object, e As EventArgs) Handles CreaZona.Click
        IngresoZona.Show()
    End Sub

    Private Sub CreaSector_Click(sender As Object, e As EventArgs) Handles CreaSector.Click
        IngresoSector.Show()
    End Sub

    Private Sub CreaDelito_Click(sender As Object, e As EventArgs) Handles CreaDelito.Click
        IngresoDelito.Show()
    End Sub

    Private Sub CreaControl_Click(sender As Object, e As EventArgs) Handles CreaControl.Click
        IngresoControl.Show()
    End Sub

    Private Sub CreaBanda_Click(sender As Object, e As EventArgs) Handles CreaBanda.Click
        IngresoBanda.Show()
    End Sub

    Private Sub ActDelincuente_Click(sender As Object, e As EventArgs) Handles ActDelincuente.Click
        ActualizaDelincuente.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        op = MsgBox("¿Está seguro que desea salir?", MsgBoxStyle.YesNo, "Salir del Sistema")
        If (op = 6) Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub RegistrarDelincuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaDelincuente.Click
        IngresaDelincuente.Show()
    End Sub

    'Metodo para conectar
    Public Sub Conectar()
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar" + ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    'Metodos y Funciones

    'Muestra/Oculta opciones en el menu de acuerdo al tipo de usuario
    Public Sub validaUser(ByVal id As Integer)
        If id = 1 Then
            CreaUser.Visible = True
            CreaInstitucion.Visible = True
            Espacio.Visible = True
            DelUser.Visible = True
            DelInst.Visible = True
        ElseIf id = 2 Then
            CreaUser.Visible = True
            CreaZona.Visible = True
            CreaSector.Visible = True
            CreaDelito.Visible = True
            CreaControl.Visible = True
            CreaBanda.Visible = True
            CreaDelincuente.Visible = True
            ActDelincuente.Visible = True
        ElseIf id = 3 Then
            CreaUser.Visible = True
            CreaZona.Visible = True
            CreaSector.Visible = True
            CreaDelito.Visible = True
            CreaControl.Visible = True
            CreaBanda.Visible = True
            CreaDelincuente.Visible = True
            ActDelincuente.Visible = True
            Reportes.Visible = True
        Else
            CreaDelincuente.Visible = True
            CreaControl.Visible = True
            CreaDelito.Visible = True
            ActDelincuente.Visible = True
        End If
    End Sub

    'Muestra Nombre usuario y logo segun corresponda
    Public Sub bienvenidaUser(ByVal id As Integer)
        lblBienvenido.Text = "Bienvenid@ " + Login.nombre + " " + Login.apellido
        If id = 1 Then
            picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\carabineros.png")
        ElseIf id = 2 Then
            picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\os10.png")
        ElseIf id = 3 Then
            picPrincipal.Image = Image.FromFile("C:\Users\sgome\source\repos\sugomez01\SIRP\SIRP\Resources\pdi.png")
        Else
            picPrincipal.Visible = False
        End If
    End Sub

End Class