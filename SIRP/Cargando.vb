Public Class Cargando
    Private Sub Cargando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 20
            lblMsje.Text = "CARGANDO EL SISTEMA AL " + ProgressBar1.Value.ToString + "%"
        Else
            Timer1.Enabled = False
            MsgBox("Carga del sistema completada!")
            Me.Close()
        End If
    End Sub

    Private Sub Cargando_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub


End Class