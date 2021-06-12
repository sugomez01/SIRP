﻿Imports System.Data.SqlClient

Public Class IngresoControl

    Dim id_institucion, id_usuario, op As Integer
    Dim fechaControl As String



    'CONEXION A SQL

    Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    'Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    Private Sub IngresoControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenaCombo()

    End Sub


    '************************ FUNCIONES PARA LLENAR COMBOBOX

    Sub llenaCombo()

        id_institucion = Login.id_int

        comando = New SqlCommand("select * from l_comuna", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbComuna.DisplayMember = "desc_comuna"
        cmbComuna.ValueMember = "id_comuna"
        cmbComuna.DataSource = dt


        comando = New SqlCommand("select * from l_sector where l_id_institucion = " + id_institucion.ToString() + "", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbSector.DisplayMember = "desc_sector"
        cmbSector.ValueMember = "id_sector"
        cmbSector.DataSource = dt

        comando = New SqlCommand("select * from l_zona", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbZona.DisplayMember = "desc_zona"
        cmbZona.ValueMember = "id_zona"
        cmbZona.DataSource = dt

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtNombre.Text = "" Or txtUbicacion.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else

            If validaRut() = True Then
                Dim insert, consulta, rut, nombre, id_usuario, id_institucion As String
                Dim zona, comuna, sector As Integer

                id_institucion = Login.id_int
                id_usuario = Login.id_user

                zona = cmbZona.SelectedValue
                comuna = cmbComuna.SelectedValue
                sector = cmbSector.SelectedValue

                nombre = txtNombre.Text.ToString()

                rut = txtRut.Text + "-" + txtDigito.Text
                consulta = "select rut_delincuente from l_delincuente where rut_delincuente='" + rut + "'"
                insert = "insert into b_detalle_controles values ('" + rut.ToString + "','" + nombre.ToString + "','" + fechaControl + "','" + txtUbicacion.Text.ToString + "'," + zona.ToString + "," + comuna.ToString + ", " + sector.ToString + "," + id_usuario.ToString + "," + id_institucion.ToString + ",getdate())"

                MsgBox(insert)

                If (Insertar(insert)) Then
                        MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
                        op = MsgBox("¿Desea ingresar otro delincuente?", MsgBoxStyle.YesNo, "Confirmación")
                        If (op = 6) Then
                        txtNombre.Clear()
                        txtRut.Clear()

                    Else
                        Principal.Show()
                            Me.Close()
                        End If
                    Else
                        MsgBox("Error al ingresar usuario",, "Error")
                    End If
                Else
                MsgBox("Rut o nombre de usuario ya existe",, "Error")

                txtRut.Enabled = True
                txtDigito.Enabled = True
                txtNombre.Clear()
                txtRut.Clear()
                txtDigito.Clear()
            End If

            End If




    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        fechaControl = Format(dtpFecha.Value, "yyyy/MM/dd").ToString()
    End Sub

    'Funcion para insertar Delito
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

    '************************* FUNCIONES PARA VALIDACIONES DE CAMPOS


    '** VALIDA RUT

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


End Class