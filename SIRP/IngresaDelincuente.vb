Imports System.Data.SqlClient

Public Class frmDelincuente

    Dim id_user, id_int, banda As Integer
    Dim estado, fechaNac, id_comuna, fono As String



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

    Private Sub IngresaDelincuente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombo()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        id_user = Login.id_user
        If txtApellido.Text = "" Or txtDomicilio.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else
            If txtTelefono.Text = "" Then
                fono = "NULL"
            Else
                fono = txtTelefono.Text
            End If
            If validaRut() = True Then
                Dim insert, consulta, rut, apellido, nombre As String

                apellido = txtApellido.Text.ToString()
                nombre = txtNombre.Text.ToString()

                rut = txtRut.Text + "-" + txtDigito.Text
                consulta = "select rut_delincuente from l_delincuente where rut_delincuente='" + rut + "'"
                insert = "insert into l_delincuente values ('" + rut + "','" + nombre + "','" + apellido + "','" + txtApodo.Text.ToString + "', " + id_comuna + ",'" + txtDomicilio.Text.ToString + "'," + fono + "," + "'" + fechaNac + "'," + estado.ToString + "," + banda.ToString + "," + id_user.ToString + ",getDate())"
                If validaRegistro(consulta) = False Then
                    If (Insertar(insert)) Then
                        MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
                        Me.Close()
                    Else
                        MsgBox("Error al ingresar registro de delincuente, por favor contacte al Administrador",, "Error")
                    End If
                Else
                    MsgBox("Delincuente ya existe",, "Error")
                    Me.Close()
                End If

            End If

        End If

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        estado = cmbEstado.SelectedValue().ToString
    End Sub


    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged
        fechaNac = Format(dtpFechaNac.Value, "yyyy/MM/dd").ToString()

    End Sub

    Private Sub cmbBanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanda.SelectedIndexChanged
        banda = cmbBanda.SelectedValue()
    End Sub

    Public dt As DataTable

    Private Sub VolverAlMeúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub IngresarDelitoCometidoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        IngresoDelito.Show()
        Me.Close()
    End Sub


    Public Sub Conectar()
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar" + ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub


    'Funcion para insertar Delincuente
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

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblFono.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Sub llenaCombo()

        id_int = Login.id_int

        comando = New SqlCommand("select * from l_estado", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbEstado.DisplayMember = "desc_estado"
        cmbEstado.ValueMember = "id_estado"
        cmbEstado.DataSource = dt

        comando = New SqlCommand("select * from l_banda where l_id_institucion = " + id_int.ToString() + "", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbBanda.DisplayMember = "desc_banda"
        cmbBanda.ValueMember = "id_banda"
        cmbBanda.DataSource = dt

        comando = New SqlCommand("select * from l_comuna", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbComuna.DisplayMember = "desc_comuna"
        cmbComuna.ValueMember = "id_comuna"
        cmbComuna.DataSource = dt

    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

    End Sub

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

    Function validaRut()
        Dim rut As String = txtRut.Text
        Dim digito As String = txtDigito.Text
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
            txtDigito.Clear()
        End If


        Return retorno
    End Function

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
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

    Private Sub cmbComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComuna.SelectedIndexChanged
        id_comuna = cmbComuna.SelectedValue.ToString
    End Sub

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
End Class