Imports System.Data.SqlClient
Public Class EliminaUsuario

    Dim user As String

    'Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable


    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click

        Dim elimina, usuario As String

        usuario = txtUser.Text

        If usuario = "" Then
            MsgBox("Debe ingresar Usuario!",, "Error")
        Else
            'AGREGAR VALIDACION (EXISTE INSTITUCION)
            elimina = "delete from l_usuario where username ='" + usuario.ToString + "'"
            Eliminar(elimina)
            'Me.Close()
        End If
        ' MenuPrincipal.Show()
        Me.Close()
    End Sub


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


End Class