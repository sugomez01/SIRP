Imports System.Data.SqlClient
Public Class AgregaInstitucion
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As String
        insert = "insert into l_institucion values ('" + txtInst.Text + "')"

        If (Insertar(insert)) Then
            MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
            op = MsgBox("¿Desea ingresar otra institución?", MsgBoxStyle.YesNo, "Confirmación")
            If (op = 6) Then
                txtInst.Clear()
            Else
                Principal.Show()
                Me.Close()
            End If
        Else
            MsgBox("Error al ingresar institución",, "Error")
        End If


    End Sub
End Class