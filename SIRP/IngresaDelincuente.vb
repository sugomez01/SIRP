Imports System.Data.SqlClient

Public Class IngresaDelincuente

    Dim id_user, id_int, id_tip_user, op, banda, estado As Integer
    Dim pass, nombre, apellido, rut, fechaNac As String



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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtApellido.Text = "" Or txtApodo.Text = "" Or txtDomicilio.Text = "" Or txtNombre.Text = "" Or txtTelefono.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else

            Dim insert, consulta As String

            consulta = "select rut_delincuente from l_delincuente where rut_delincuente='" + txtRut.Text + "'"
            insert = "insert into l_delincuente values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtRut.Text + "','" + txtApodo.Text + "','" + txtTelefono.Text + "' ," + banda.ToString + ".'20210612'," + estado.ToString + "," + id_int.ToString + "," + id_tip_user.ToString + ",getDate())"

            If validaRegistro(consulta) = False Then
                If (Insertar(insert)) Then
                    MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
                    op = MsgBox("¿Desea ingresar otra institución?", MsgBoxStyle.YesNo, "Confirmación")
                    If (op = 6) Then
                        txtNombre.Clear()
                        txtApellido.Clear()
                        txtApodo.Clear()
                        txtRut.Clear()
                        txtTelefono.Clear()
                        cmbEstado.SelectedIndex = 0
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
                txtNombre.Clear()
                txtApellido.Clear()
                txtApodo.Clear()
                txtRut.Clear()
                txtTelefono.Clear()
            End If
        End If

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        estado = cmbEstado.SelectedValue(0)
    End Sub

    Private Sub IngresaDelincuente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombo()
    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged
        fechaNac = dtpFechaNac.Value.ToString()
    End Sub

    Private Sub cmbBanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanda.SelectedIndexChanged
        banda = cmbBanda.SelectedValue()
    End Sub

    Public dt As DataTable

    Private Sub VolverAlMeúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMeúPrincipalToolStripMenuItem.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub IngresarDelitoCometidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarDelitoCometidoToolStripMenuItem.Click
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

    Sub llenaCombo()

        id_int = Login.id_int

        comando = New SqlCommand("select * from l_estado", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbEstado.DisplayMember = "desc_institucion"
        cmbEstado.ValueMember = "id_institucion"
        cmbEstado.DataSource = dt

        comando = New SqlCommand("select * from l_banda where l_id_institucion = " + id_int.ToString() + "", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbBanda.DisplayMember = "desc_banda"
        cmbBanda.ValueMember = "id_banda"
        cmbBanda.DataSource = dt


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

End Class