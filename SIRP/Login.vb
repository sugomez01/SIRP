Public Class Login
    Dim id_int, op As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.Conectar()
        ControlBox = False
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        id_int = txtPass.Text

        If id_int = 1 Then
            Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\Desktop\PROYECTO SIRP\SIRP\IMAGES\carabineros.png")
        ElseIf id_int = 2 Then
            Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\Desktop\PROYECTO SIRP\SIRP\IMAGES\os-10.png")
        Else
            Principal.picPrincipal.Image = Image.FromFile("C:\Users\sgome\Desktop\PROYECTO SIRP\SIRP\IMAGES\pdi.png")
        End If

        Principal.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        op = MessageBox.Show("¿Está seguro que desea salir del sistema?")
        If op = 6 Then
            Me.Close()
        End If
    End Sub
End Class