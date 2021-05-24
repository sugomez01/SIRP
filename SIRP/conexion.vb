Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexion
    ' descomentar segun pc
    'Public conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")


    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    'Conexión a la DB
    Public Sub Conectar()
        Try
            conexion.Open()
            '    MessageBox.Show("Conectado")
        Catch ex As Exception
            '  MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub


    Function usuarioRegistrado(ByVal nombreUSuario As String)
        conexion.Close()
        conexion.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select * from l_usuario where username = '" + nombreUSuario + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function contrasena(ByVal nombreUSuario As String)
        conexion.Close()
        conexion.Open()
        Dim resultado As String = ""
        Try
            comando = New SqlCommand("select password from l_usuario where username = '" + nombreUSuario + "'", conexion)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = dr.Item("password")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function tipoUsuario(ByVal nombreUSuario As String) As Integer
        conexion.Close()
        conexion.Open()
        Dim resultado As String = ""
        Try
            comando = New SqlCommand("select l_id_tipo_user from l_usuario where username = '" + nombreUSuario + "'", conexion)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = CInt(dr.Item("l_id_tipo_user"))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

    Function tipoInstitucion(ByVal nombreUSuario As String) As Integer
        conexion.Close()
        conexion.Open()
        Dim resultado As String = ""
        Try
            comando = New SqlCommand("select l_id_institucion from l_usuario where username = '" + nombreUSuario + "'", conexion)
            dr = comando.ExecuteReader

            If dr.Read Then
                resultado = CInt(dr.Item("l_id_institucion"))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado

    End Function

End Class
