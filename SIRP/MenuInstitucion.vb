Imports System.Data.SqlClient
Public Class MenuInstitucion
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



    Private Sub lblIngresa_Click(sender As Object, e As EventArgs) Handles lblIngresa.Click

    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub AgregaInstitucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
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
            MsgBox("Error al eliminar Institución")
            Return False
        End If

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        If txtInst.Text = "" Then
            MsgBox("Debe ingresar Institución!",, "Error")
        Else
            'AGREGAR VALIDACION (EXISTE INSTITUCION)
            Dim insert As String
            insert = "insert into l_institucion values ('" + txtInst.Text + "')"
            Insertar(insert)
            Me.Close()
        End If
    End Sub

End Class