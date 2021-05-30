Imports System.Data.SqlClient
Public Class IngresoUsuario

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

    Private Sub IngresoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        llenaCombo()
    End Sub

    Private Sub btnIngresa_Click(sender As Object, e As EventArgs) Handles btnIngresa.Click
        Dim insert As String
        insert = "insert into l_usuario values ('" + txtUser.Text + "','" + txtPass.Text + "','" + txtRut.Text + "','" + txtNomb.Text + "','" + txtApe.Text + "'," + id_int.ToString + "," + id_tip_user.ToString + ",getDate())"

        If (Insertar(insert)) Then
            MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
            op = MsgBox("¿Desea ingresar otra institución?", MsgBoxStyle.YesNo, "Confirmación")
            If (op = 6) Then
                txtNomb.Clear()
                txtApe.Clear()
                txtPass.Clear()
                txtRut.Clear()
                txtUser.Clear()
            Else
                Principal.Show()
                Me.Close()
            End If
        Else
            MsgBox("Error al ingresar institución",, "Error")
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


End Class