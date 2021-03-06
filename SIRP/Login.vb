Imports System.Data.SqlClient


Public Class Login
    Public id_user, id_int, id_tip_user, op As Integer
    Public nombre, apellido, pass, sexo As String
    Dim formPosition As Point
    Dim mouseAction As Boolean

    'Ruta para conectar a la DB
    'descomentar segun pc
    'Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
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

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        formPosition = New Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y)
        mouseAction = True
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseAction = True Then
            Location = New Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y)
        End If
    End Sub

    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseAction = False
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MsgBox("¿Está seguro que desea salir?", MsgBoxStyle.YesNo, "Salir del Sistema")
        If (op = 6) Then
            Principal.cierres()
            Me.Close()
        Else
            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus()
        End If
    End Sub


    'Metodo para validar usuario
    Function usuarioRegistrado(ByVal nombreUSuario As String)
        conn.Close()
        conn.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select id_usuario,password,desc_nombre,desc_apellido,sexo,l_id_institucion,l_id_tipo_user from l_usuario where username = '" + nombreUSuario + "'", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = True
                id_user = dr.Item("id_usuario")
                nombre = dr.Item("desc_nombre")
                apellido = dr.Item("desc_apellido")
                pass = dr.Item("password")
                sexo = dr.Item("sexo")
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
        txtUser.Focus()
    End Sub

    Private Sub chkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If chkPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUser.Text = "" Then
            MsgBox("Debe ingresar usuario")
            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus()
        ElseIf txtPass.Text = "" Then
            MsgBox("Debe ingresar contraseña")
            txtPass.Clear()
            txtPass.Focus()
        Else
            Try
                If usuarioRegistrado(txtUser.Text) = True Then
                    If pass = txtPass.Text Then
                        actualizaConexion(id_user)
                        If id_tip_user = 1 Then
                            Me.Hide()
                            MenuPrincipal.Show()
                        ElseIf id_tip_user = 2 Then
                            Me.Hide()
                            MenuPrincipal.Show()
                        ElseIf id_tip_user = 3 Then
                            Me.Hide()
                            MenuPrincipal.Show()
                        Else
                            Me.Hide()
                            MenuPrincipal.Show()
                        End If
                    Else
                        MsgBox("Contraseña errónea")
                        txtPass.Clear()
                        txtUser.Focus()
                    End If
                Else
                    MsgBox("Usuario no existe")
                    txtUser.Clear()
                    txtPass.Clear()
                    txtUser.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            txtUser.Clear()
            txtPass.Clear()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
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

    Sub actualizaConexion(ByVal id As Integer)
        Dim insert As String
        insert = "insert into l_conexion values (" + id.ToString + ",getDate())"
        If (Insertar(insert)) Then
            '  MsgBox("ACTUALIZADO",, "Registro existoso")
        Else
            MsgBox("Error al conectar",, "Error")
        End If
    End Sub

    Function Insertar(ByVal sql)
        conn.Close()
        conn.Open()
        comando = New SqlCommand(sql, conn)
        Dim i As Integer = comando.ExecuteNonQuery()
        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


End Class
