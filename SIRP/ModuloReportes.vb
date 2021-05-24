Public Class ModuloReportes
    Private Sub ModuloReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SIRPDataSet.l_delincuente' Puede moverla o quitarla según sea necesario.
        Me.L_delincuenteTableAdapter.Fill(Me.SIRPDataSet.l_delincuente)

    End Sub


End Class