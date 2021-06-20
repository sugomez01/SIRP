Imports System.Data.SqlClient
Public Class MenuPrincipal

    Dim id_user, op As Integer
    Dim nombre, fecha, institucion, cargo, sexo As String
    'Dim fechaActual As DateTime



    'Ruta para conectar a la DB
    'descomentar segun pc
    Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    'Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConexion.Visible = True
        lblFechaActual.Text = "Fecha y hora actual: " + DateTime.Now.ToLongDateString + " " + DateTime.Now.ToLongTimeString

        id_user = Login.id_user
        ' MsgBox("USER ID: " + id_user.ToString)
        If datosUser(id_user) = True Then
            lblCargo.Text = "- Cargo actual: " + cargo
            lblConexion.Text = "- Última conexión: " + fecha
            lblInst.Text = "- Institución: " + institucion
            validaUser(Login.id_tip_user)
            bienvenidaUser(Login.id_int)
        Else
            MsgBox("Ha ocurrido un error inesperado, por favor contacte al Administrador.")
            lblCargo.Text = "- Cargo actual: " + cargo
            lblInst.Text = "- Institución: " + institucion
            lblConexion.Visible = False
            validaUser(Login.id_tip_user)
            bienvenidaUser(Login.id_int)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFechaActual.Text = "Fecha y hora actual: " + DateTime.Now.ToLongDateString + " " + DateTime.Now.ToLongTimeString
    End Sub

    Private Sub btnIngresaInst_Click(sender As Object, e As EventArgs) Handles btnIngresaInst.Click
        MenuInstitucion.Show()
        MenuInstitucion.btnRegistra.Show()
        MenuInstitucion.lblIngresa.Show()
        MenuInstitucion.txtInst.Show()
        MenuInstitucion.btnElimina.Hide()
        MenuInstitucion.cmbInstituciones.Hide()
        MenuInstitucion.lblElimina.Hide()

    End Sub

    Private Sub btnEliminaInst_Click(sender As Object, e As EventArgs) Handles btnEliminaInst.Click
        MenuInstitucion.Show()
        MenuInstitucion.btnRegistra.Hide()
        MenuInstitucion.lblIngresa.Hide()
        MenuInstitucion.txtInst.Hide()
        MenuInstitucion.btnElimina.Show()
        MenuInstitucion.cmbInstituciones.Show()
        MenuInstitucion.lblElimina.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IngresoUsuario.Show()
    End Sub

    Public Sub validaUser(ByVal id As Integer)
        If id = 1 Then
            PanelAdmin.Visible = True
        Else
            PanelAdmin.Visible = False
        End If
        '    CreaUser.Visible = True
        '    CreaInstitucion.Visible = True
        '    Espacio.Visible = True
        '    DelUser.Visible = True
        '    DelInst.Visible = True
        'ElseIf id = 2 Then
        '    CreaUser.Visible = True
        '    CreaZona.Visible = True
        '    CreaSector.Visible = True
        '    CreaDelito.Visible = True
        '    CreaControl.Visible = True
        '    CreaBanda.Visible = True
        '    CreaDelincuente.Visible = True
        '    ActDelincuente.Visible = True
        'ElseIf id = 3 Then
        '    CreaUser.Visible = True
        '    CreaZona.Visible = True
        '    CreaSector.Visible = True
        '    CreaDelito.Visible = True
        '    CreaControl.Visible = True
        '    CreaBanda.Visible = True
        '    CreaDelincuente.Visible = True
        '    ActDelincuente.Visible = True
        '    Reportes.Visible = True
        'Else
        '    CreaDelincuente.Visible = True
        '    CreaControl.Visible = True
        '    CreaDelito.Visible = True
        '    ActDelincuente.Visible = True
        'End If
    End Sub
    Function datosUser(ByVal idUser As String)
        'conn.Close()
        conn.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select top 1 nombre,ultima_conexion,cargo,institucion,sexo from datos_Usuario where id_usuario=" + id_user.ToString + " and id_conexion<(select max(id_conexion) from l_conexion where id_usuario=" + id_user.ToString + ") order by id_conexion desc", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = True
                nombre = dr.Item("nombre")
                fecha = dr.Item("ultima_conexion")
                cargo = dr.Item("cargo")
                institucion = dr.Item("institucion")
                sexo = dr.Item("sexo")
            Else
                resultado = False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
        conn.Close()
    End Function


    Public Sub bienvenidaUser(ByVal id As Integer)
        If sexo = "F" Then
            lblBienvenido.Text = "BIENVENIDA " + nombre '+ Login.nombre + " " + Login.apellido
        ElseIf sexo = "M" Then
            lblBienvenido.Text = "BIENVENIDO " + nombre 'Login.nombre + " " + Login.apellido
        Else
            lblBienvenido.Text = "BIENVENIDE " + nombre 'Login.nombre + " " + Login.apellido
        End If

        If id = 1 Then
            picPrincipal.BackgroundImage = Image.FromFile("C:\Users\shifl\OneDrive\Escritorio\Proyecto de titulo\SIRP\SIRP\Resources\carabineros.png")
        ElseIf id = 2 Then
            picPrincipal.BackgroundImage = Image.FromFile("C:\Users\shifl\OneDrive\Escritorio\Proyecto de titulo\SIRP\SIRP\Resources\os10.png")
        ElseIf id = 3 Then
            picPrincipal.BackColor = Color.White
            picPrincipal.BackgroundImage = Image.FromFile("C:\Users\shifl\OneDrive\Escritorio\Proyecto de titulo\SIRP\SIRP\Resources\pdi.png")
        Else
            picPrincipal.Visible = False
        End If
    End Sub

    Public Sub cierres()
        Me.Close()
        ActualizaDelincuente.Close()
        MenuInstitucion.Close()
        IngresaDelincuente.Close()
        IngresoBanda.Close()
        IngresoControl.Close()
        IngresoDelito.Close()
        IngresoSector.Close()
        IngresoUsuario.Close()
        IngresoZona.Close()
        ModuloReportes.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        op = MsgBox("¿Está seguro que desea salir?", MsgBoxStyle.YesNo, "Salir del Sistema")
        If (op = 6) Then
            Login.Show()
            Login.txtUser.Focus()
            cierres()
        End If
    End Sub
End Class