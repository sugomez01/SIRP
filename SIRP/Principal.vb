Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenido.Text = "Hola " & Login.txtUser.Text
    End Sub

    Private Sub picPrincipal_Click(sender As Object, e As EventArgs) Handles picPrincipal.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub
End Class