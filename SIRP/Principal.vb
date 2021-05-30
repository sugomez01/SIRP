Public Class Principal
    Dim conexion As conexion = New conexion()

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  lblBienvenido.Text = "Hola " & Login.txtUser.Text
        conexion.Conectar()
        ControlBox = False
        bienvenidaUser()

    End Sub

    Private Sub picPrincipal_Click(sender As Object, e As EventArgs) Handles picPrincipal.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub RegistrarDelincuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarDelincuenteToolStripMenuItem.Click
        IngresaDelincuente.Show()
        Me.Close()
    End Sub

    Public Sub bienvenidaUser()

    End Sub


End Class