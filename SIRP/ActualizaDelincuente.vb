Imports System.Data.SqlClient
Public Class ActualizaDelincuente

    Dim desc_nombre, desc_apellido, desc_apodo, fono1, desc_domicilio As String

    'Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable





    Function Buscar(ByVal sql)
        conn.Close()
        conn.Open()
        comando = New SqlCommand(sql, conn)
        Dim i As Integer = comando.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Registro Encontrado")
            Return True
        Else
            MsgBox("El registro que busca no se encuentra, intente nuevamente")
            Return False
        End If

    End Function

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click

        Dim rut As String

        rut = txtRut.Text + "-" + txtDigito.Text

        If validaRut() = True Then

            delincuenteRegistrado(rut)
            llenaCombo()

            txtNombre.Text = desc_nombre
            txtApellido.Text = desc_apellido
            txtApodo.Text = desc_apodo
            txtTelefono.Text = fono1
            txtDomicilio.Text = desc_domicilio
        Else
            MsgBox("Ingrese rut valido")
        End If

    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click

        Dim id_comuna, id_banda, id_estado As String
        Dim rut, comando As String

        rut = txtRut.Text + "-" + txtDigito.Text


        id_comuna = cmbComuna.SelectedValue.ToString
        id_banda = cmbBanda.SelectedValue.ToString
        id_estado = cmbEstado.SelectedValue.ToString


        comando = "update l_delincuente set fono1= " + txtTelefono.Text + ",desc_domicilio = '" + txtDomicilio.Text + "',l_id_comuna=" + id_comuna + ",l_id_banda=" + id_banda + ",l_id_estado =" + id_estado + " where rut_delincuente = '" + rut + "'"
        actualizaRegistro(comando)
        Me.Close()
        MenuPrincipal.Show()

    End Sub


    Function delincuenteRegistrado(ByVal rut As String)
        conn.Close()
        conn.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select desc_nombre,desc_apellido,desc_apodo,fono1,desc_domicilio from l_delincuente where rut_delincuente = '" + rut + "'", conn)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = True
                desc_nombre = dr.Item("desc_nombre")
                desc_apellido = dr.Item("desc_apellido")
                desc_apodo = dr.Item("desc_apodo")
                fono1 = dr.Item("fono1")
                desc_domicilio = dr.Item("desc_domicilio")

            Else
                resultado = False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Sub llenaCombo()


        comando = New SqlCommand("select * from l_comuna ", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbComuna.DisplayMember = "desc_comuna"
        cmbComuna.ValueMember = "id_comuna"
        cmbComuna.DataSource = dt

        comando = New SqlCommand("select * from l_banda", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbBanda.DisplayMember = "desc_banda"
        cmbBanda.ValueMember = "id_banda"
        cmbBanda.DataSource = dt

        comando = New SqlCommand("select * from l_estado", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbEstado.DisplayMember = "desc_estado"
        cmbEstado.ValueMember = "id_estado"
        cmbEstado.DataSource = dt



    End Sub

    Function actualizaRegistro(ByVal sql)
        conn.Close()
        conn.Open()
        comando = New SqlCommand(sql, conn)
        Dim i As Integer = comando.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Registro actualizado exitosamente")
            Return True
        Else
            MsgBox("Error al actualizar registro")
            Return False
        End If

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


End Class