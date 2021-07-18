Imports System.Data.SqlClient
Public Class IngresoUsuario

    Dim id_int, id_tip_user, op As Integer
    Dim sexo As String

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


    Private Sub VolverAlMenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub IngresarInstituciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CambioInstitucion.Show()
        Me.Close()
    End Sub

    Private Sub SalirDelSisemaToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub IngresoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        txtPass.PasswordChar = "*"
        llenaCombo()
    End Sub

    Private Sub btnIngresa_Click(sender As Object, e As EventArgs) Handles btnIngresa.Click
        Dim rut As String
        If txtNomb.Text = "" Or txtApe.Text = "" Or txtPass.Text = "" Or txtRut.Text = "" Or txtDV.Text = "" Or txtUser.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else
            If validaRut() = True Then
                Dim insert, consulta1, consulta2 As String
                rut = txtRut.Text & "-" & txtDV.Text

                If cmbSexo.SelectedItem = "FEMENINO" Then
                    sexo = "F"
                ElseIf cmbSexo.SelectedItem = "MASCULINO" Then
                    sexo = "M"
                Else
                    sexo = "O"
                End If

                consulta1 = "select rut_usuario from l_usuario where rut_usuario='" + rut + "'"
                consulta2 = "select username from l_usuario where username='" + txtUser.Text + "'"
                insert = "insert into l_usuario values ('" + txtUser.Text + "','" + txtPass.Text + "','" + rut + "','" + txtNomb.Text + "','" + txtApe.Text + "','" + sexo + "'," + id_int.ToString + "," + id_tip_user.ToString + ",getDate())"

                If validaRegistro(consulta1) = False Then
                        If validaRegistro(consulta2) = False Then
                            If (Insertar(insert)) Then
                            MsgBox("Usuario ingresado exitosamente!",, "Registro existoso")
                            Me.Close()
                        Else
                                MsgBox("Error al ingresar usuario",, "Error")
                            End If
                        Else
                            MsgBox("Nombre de usuario ya existe",, "Error")
                            txtRut.Enabled = True
                            txtDV.Enabled = True
                            txtRut.Clear()
                            txtDV.Clear()
                            txtUser.Clear()
                            txtPass.Clear()
                        End If
                    Else
                        MsgBox("Rut ya se encuentra registrado",, "Error")
                        txtRut.Enabled = True
                        txtDV.Enabled = True
                        txtRut.Clear()
                        txtDV.Clear()
                        txtUser.Clear()
                        txtPass.Clear()
                    End If
                End If
            End If

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

    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede ingresar números")
        End If
    End Sub


    Function validaRut()
        Dim rut As String = txtRut.Text
        Dim digito As String = txtDV.Text
        Dim dig2 As String
        Dim contador, contar, acumulador, division, dig As Integer
        contar = 2
        Dim retorno As Boolean

        Do While rut <> 0
            contador = (rut Mod 10) * contar
            acumulador = acumulador + contador
            rut = rut \ 10
            contar = contar + 1
            If contar = 8 Then
                contar = 2
            End If
        Loop

        division = acumulador Mod 11
        If division = 0 Then
            division = 11
        End If
        dig = 11 - division
        dig2 = CStr(dig)
        If dig2 = 10 Then
            dig2 = "K"
        End If
        If dig2 = digito Then
            ' MsgBox("rut validado")
            retorno = True
        Else
            retorno = False
            MsgBox("Rut erróneo, favor validar")
            txtRut.Clear()
            txtDV.Clear()
        End If
        Return retorno
    End Function

End Class