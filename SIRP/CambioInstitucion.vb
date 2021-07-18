Imports System.Data.SqlClient
Public Class CambioInstitucion
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

    Private Sub IngresarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        IngresoUsuario.Show()
        Me.Close()
    End Sub

    Private Sub VolverAlMenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        op = MsgBox("¿Está seguro que desea salir?", MsgBoxStyle.YesNo, "Salir del Sistema")
        If (op = 6) Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click

        Dim institucion As Integer
        Dim elimina As String

        institucion = cmbInstituciones.SelectedValue

        If institucion = 0 Then
            MsgBox("Debe ingresar Institución!",, "Error")
        Else
            'AGREGAR VALIDACION (EXISTE INSTITUCION)
            elimina = "delete from l_institucion where id_institucion =" + institucion.ToString + ""
            Eliminar(elimina)
            'Me.Close()
        End If
        ' MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub AgregaInstitucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        llenaCombo()
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
            MsgBox("Institución agregada exitosamente")
            Return True
        Else
            MsgBox("Error al agregar Institución")
            Return False
        End If

    End Function

    Function Eliminar(ByVal sql)
        conn.Close()
        conn.Open()
        comando = New SqlCommand(sql, conn)
        Dim i As Integer = comando.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Institución Eliminada exitosamente")
            Return True
        Else
            MsgBox("Error al eliminar Institución")
            Return False
        End If

    End Function

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        Dim consulta As String

        consulta = "select desc_institucion from l_institucion where desc_institucion='" + txtInst.Text + "'"

        If txtInst.Text = "" Then
            MsgBox("Debe ingresar Institución!",, "Error")
        ElseIf validaRegistro(consulta) = True Then

            MsgBox("Institución Duplicada",, "Error")

        Else
            'AGREGAR VALIDACION (EXISTE INSTITUCION)
            Dim insert As String
            insert = "insert into l_institucion values ('" + txtInst.Text + "')"
            Insertar(insert)
            Me.Close()
        End If
    End Sub

    Sub llenaCombo()


        comando = New SqlCommand("select * from l_institucion", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbInstituciones.DisplayMember = "desc_institucion"
        cmbInstituciones.ValueMember = "id_institucion"
        cmbInstituciones.DataSource = dt

    End Sub

End Class