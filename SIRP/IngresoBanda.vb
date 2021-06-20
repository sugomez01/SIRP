Imports System.Data.SqlClient


Public Class IngresoBanda


    Dim id_zona, id_comuna As String

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

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If txtBanda.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else


            Dim id_institucion, insert, id_usuario As String
            Dim op As Integer


            id_institucion = Login.id_int
            id_usuario = Login.id_user



            insert = "insert into l_banda values ('" + txtBanda.Text + "'," + id_institucion + "," + id_usuario + ",getdate())"

            'MsgBox(insert)

            If (Insertar(insert)) Then
                MsgBox("Registro ingresado exitosamente!",, "Registro existoso")
                op = MsgBox("¿Desea ingresar otra Banda?", MsgBoxStyle.YesNo, "Confirmación")
                If (op = 6) Then
                    txtBanda.Clear()
                Else
                    Principal.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Error al ingresar Sector",, "Error")
            End If
        End If

    End Sub


    'INSERT

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


End Class