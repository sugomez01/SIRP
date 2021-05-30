Public Class IngresaDelincuente
    Private Sub VolverAlMeúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMeúPrincipalToolStripMenuItem.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub IngresarDelitoCometidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarDelitoCometidoToolStripMenuItem.Click
        IngresoDelito.Show()
        Me.Close()
    End Sub
End Class