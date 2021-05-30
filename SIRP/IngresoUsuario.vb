Imports System.Data.SqlClient
Public Class IngresoUsuario

    Dim id_user, id_int, id_tip_user, op As Integer
    Dim pass, nombre, apellido, rut As String

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


    Private Sub VolverAlMenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenúPrincipalToolStripMenuItem.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub IngresarInstituciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarInstituciónToolStripMenuItem.Click
        AgregaInstitucion.Show()
        Me.Close()
    End Sub

    Private Sub SalirDelSisemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSisemaToolStripMenuItem.Click
        op = MsgBox("¿Está seguro que desea salir?", MsgBoxStyle.YesNo, "Salir del Sistema")
        If (op = 6) Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cmbIns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIns.SelectedIndexChanged
        id_int = cmbIns.SelectedValue()
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        id_tip_user = cmbTipo.SelectedValue()
    End Sub

    Private Sub txtNomb_TextChanged(sender As Object, e As EventArgs) Handles txtNomb.TextChanged

    End Sub

    Private Sub IngresoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        txtPass.PasswordChar = "*"
        llenaCombo()
    End Sub

    Private Sub txtApe_TextChanged(sender As Object, e As EventArgs) Handles txtApe.TextChanged

    End Sub

    Private Sub btnIngresa_Click(sender As Object, e As EventArgs) Handles btnIngresa.Click



        If txtNomb.Text = "" Or txtApe.Text = "" Or txtPass.Text = "" Or txtRut.Text = "" Or txtUser.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else


            Dim insert, consulta As String

            consulta = "select rut_usuario,username from l_usuario where rut_usuario='" + rut + "' or username='" + txtUser.Text + "'"
            insert = "insert into l_usuario values ('" + txtUser.Text + "','" + txtPass.Text + "','" + txtRut.Text + "','" + txtNomb.Text + "','" + txtApe.Text + "'," + id_int.ToString + "," + id_tip_user.ToString + ",getDate())"

            If validaRegistro(consulta) = False Then
                If (Insertar(insert)) Then
                    MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
                    op = MsgBox("¿Desea ingresar otra institución?", MsgBoxStyle.YesNo, "Confirmación")
                    If (op = 6) Then
                        txtNomb.Clear()
                        txtApe.Clear()
                        txtPass.Clear()
                        txtRut.Clear()
                        txtUser.Clear()
                        cmbIns.SelectedIndex = 0
                        cmbTipo.SelectedIndex = 0
                    Else
                        Principal.Show()
                        Me.Close()
                    End If
                Else
                    MsgBox("Error al ingresar usuario",, "Error")
                End If
            Else
                MsgBox("Rut o nombre de usuario ya existe",, "Error")
                txtRut.Clear()
                txtUser.Clear()
            End If
        End If
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

        If txtRut.TextLength = 8 Then txtRut.Text = ValidaRut(txtRut.Text)

        rut = txtRut.Text
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

    'Funcion para insertar institucion
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

    Sub llenaCombo()
        comando = New SqlCommand("select * from l_institucion", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbIns.DisplayMember = "desc_institucion"
        cmbIns.ValueMember = "id_institucion"
        cmbIns.DataSource = dt


        comando = New SqlCommand("select * from l_tipo_usuario", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbTipo.DisplayMember = "desc_usuario"
        cmbTipo.ValueMember = "id_tipo_user"
        cmbTipo.DataSource = dt

    End Sub

    Private Sub txtNomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomb.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede ingresar letras")
        End If
    End Sub

    Private Sub txtApe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApe.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede ingresar letras")
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede ingresar letras")
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MsgBox("No debe ingresar espacios")
        Else
            e.Handled = False

        End If
    End Sub

    Public Function ValidaRut(ByVal ElNumero As String) As String
        Dim Resultado As String = ""
        Dim Multiplicador As Integer = 2
        Dim iNum As Integer = 0
        Dim Suma As Integer = 0

        For i As Integer = 8 To 1 Step -1
            iNum = Mid(ElNumero, i, 1)
            Suma += iNum * Multiplicador
            Multiplicador += 1
            If Multiplicador = 8 Then Multiplicador = 2
        Next
        Resultado = CStr(11 - (Suma Mod 11))
        If Resultado = "10" Then Resultado = "K"
        If Resultado = "11" Then Resultado = "0"
        Return ElNumero & "-" & Resultado
    End Function


    'valida insert que los datos no existan en la db
    Function validaRegistro(ByVal sql)
        conn.Close()
        conn.Open()
        Dim resultado As Boolean = False

        Try
            comando = New SqlCommand(sql, conn)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento : " + ex.ToString)
        End Try

        Return resultado

    End Function

End Class