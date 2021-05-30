Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class IngresoDelito

    Dim id_delito As Integer
    Dim id_banda As Integer
    Dim id_sector As Integer
    Dim id_zona As Integer
    Dim id_comuna As Integer
    Dim fechaingreso As DateTime
    Dim detalle As String

    ' Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")


    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    'Conexión a la DB
    Public Sub Conectar()
        Try
            conn.Open()
            '    MessageBox.Show("Conectado")
        Catch ex As Exception
            '  MessageBox.Show("Error al conectar")
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub IngresoDelito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenaDelito()
        llenaBanda()
        llenaComuna()
        llenaSector()
        llenaZona()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        id_delito = ComboBox1.SelectedValue()

    End Sub

    Private Sub cmbBanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanda.SelectedIndexChanged

        id_banda = cmbBanda.SelectedValue()

    End Sub

    Private Sub dtpFechaDelito_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDelito.ValueChanged

        fechaingreso = dtpFechaDelito.Value.Date

    End Sub

    Private Sub cmbSector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSector.SelectedIndexChanged

        id_sector = cmbSector.SelectedValue()

    End Sub

    Private Sub cmbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbZona.SelectedIndexChanged

        id_zona = cmbZona.SelectedValue()

    End Sub

    Private Sub cmbComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComuna.SelectedIndexChanged

        id_comuna = cmbComuna.SelectedValue()

    End Sub

    Public Sub llenaDelito()

        comando = New SqlCommand("select * from l_usuario", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)

        ComboBox1.DisplayMember = "username"
        ComboBox1.ValueMember = "id_usuario"
        ComboBox1.DataSource = dt

        'MsgBox(dt)

    End Sub

    Public Sub llenaBanda()

        comando = New SqlCommand("select * from l_banda", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)

        cmbBanda.DisplayMember = "desc_banda"
        cmbBanda.ValueMember = "id_banda"
        cmbBanda.DataSource = dt

        'MsgBox(dt)

    End Sub

    Public Sub llenaSector()

        comando = New SqlCommand("select * from l_sector", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)

        cmbSector.DisplayMember = "desc_sector"
        cmbSector.ValueMember = "id_sector"
        cmbSector.DataSource = dt

        'MsgBox(dt)

    End Sub

    Public Sub llenaZona()

        comando = New SqlCommand("select * from l_sector", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)

        cmbZona.DisplayMember = "desc_sector"
        cmbZona.ValueMember = "id_sector"
        cmbZona.DataSource = dt

        'MsgBox(dt)

    End Sub

    Public Sub llenaComuna()

        comando = New SqlCommand("select * from l_comuna", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)

        cmbComuna.DisplayMember = "desc_comuna"
        cmbComuna.ValueMember = "id_comuna"
        cmbComuna.DataSource = dt

        'MsgBox(dt)

    End Sub

    Public Function ValidaRut(ByVal ElNumero As String) As String
        Dim Resultado As String = ""
        Dim Multiplicador As Integer = 2
        Dim iNum As Integer = 0
        Dim Suma As Integer = 0

        For i As Integer = 8 To 1 Step -1
            iNum = Mid(ElNumero, i, 1)
            Suma += iNum * Multiplicador
            Multiplicador += 1
            If Multiplicador = 8 Then Multiplicador = 2
        Next
        Resultado = CStr(11 - (Suma Mod 11))
        If Resultado = "10" Then Resultado = "K"
        If Resultado = "11" Then Resultado = "0"
        Return ElNumero & "-" & Resultado
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Label1.Text = id_banda.ToString + " " + id_comuna.ToString + " " + id_delito.ToString + " " + id_sector.ToString + " " + id_zona.ToString

    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

        If txtRut.TextLength = 8 Then txtRut.Text = ValidaRut(txtRut.Text)

    End Sub

    Private Sub txtRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRut.KeyPress
        e.Handled = ValidaChar(e.KeyChar)
    End Sub

    Public Function ValidaChar(ByVal car As Char) As Boolean
        ' sólo admitimos números y tecla retroceso
        If Char.IsNumber(car, 0) = True Or Char.IsControl(car) = True Then
            Return (False)
        Else
            Return (True)
        End If
    End Function

    Private Sub txtDetalle_TextChanged(sender As Object, e As EventArgs) Handles txtDetalle.TextChanged

        detalle = txtDetalle.Text

    End Sub
End Class