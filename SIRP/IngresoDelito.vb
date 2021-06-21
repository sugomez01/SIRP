Imports System.Data.SqlClient
Public Class IngresoDelito

    Dim id_delito, id_banda, id_sector, id_zona, id_comuna As Integer
    Dim fechaingreso, detalle, rut, inst As String

    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    'Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")

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
        inst = Login.id_int.ToString()
        llenaDelito()
        llenaBanda()
        llenaComboZona()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        id_delito = ComboBox1.SelectedValue()
    End Sub

    Private Sub cmbBanda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanda.SelectedIndexChanged
        id_banda = cmbBanda.SelectedValue()
    End Sub

    Private Sub dtpFechaDelito_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDelito.ValueChanged
        fechaingreso = Format(dtpFechaDelito.Value, "yyyy/MM/dd").ToString()
    End Sub

    Private Sub cmbSector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSector.SelectedIndexChanged
        id_sector = cmbSector.SelectedValue()
    End Sub

    Private Sub cmbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbZona.SelectedIndexChanged
        id_zona = cmbZona.SelectedValue()
        llenaComboComuna(id_zona)
    End Sub

    Private Sub cmbComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComuna.SelectedIndexChanged
        id_comuna = cmbComuna.SelectedValue()
        llenaComboSector()
    End Sub

    Private Sub txtRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRut.KeyPress
        'e.Handled = ValidaChar(e.KeyChar)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede ingresar números")
        End If
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

    Public Sub llenaDelito()
        comando = New SqlCommand("select * from l_delito", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        ComboBox1.DisplayMember = "desc_delito"
        ComboBox1.ValueMember = "id_delito"
        ComboBox1.DataSource = dt
    End Sub

    Public Sub llenaBanda()
        comando = New SqlCommand("select * from l_banda where l_id_institucion = " + inst + "", conn)
        ' dr = comando.ExecuteReader
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbBanda.DisplayMember = "desc_banda"
        cmbBanda.ValueMember = "id_banda"
        cmbBanda.DataSource = dt
    End Sub



    'Public Sub llenaSector()
    '    comando = New SqlCommand("select * from l_sector where l_id_institucion = " + inst + "", conn)
    '    ' dr = comando.ExecuteReader
    '    da = New SqlDataAdapter(comando)
    '    dt = New DataTable()
    '    da.Fill(dt)
    '    cmbSector.DisplayMember = "desc_sector"
    '    cmbSector.ValueMember = "id_sector"
    '    cmbSector.DataSource = dt
    'End Sub

    'Public Sub llenaZona()
    '    comando = New SqlCommand("select * from l_zona", conn)
    '    ' dr = comando.ExecuteReader
    '    da = New SqlDataAdapter(comando)
    '    dt = New DataTable()
    '    da.Fill(dt)
    '    cmbZona.DisplayMember = "desc_zona"
    '    cmbZona.ValueMember = "id_zona"
    '    cmbZona.DataSource = dt
    'End Sub

    'Public Sub llenaComuna()
    '    comando = New SqlCommand("select * from l_comuna", conn)
    '    ' dr = comando.ExecuteReader
    '    da = New SqlDataAdapter(comando)
    '    dt = New DataTable()
    '    da.Fill(dt)
    '    cmbComuna.DisplayMember = "desc_comuna"
    '    cmbComuna.ValueMember = "id_comuna"
    '    cmbComuna.DataSource = dt
    'End Sub

    Function validaRut()
        Dim rut As String = txtRut.Text
        Dim digito As String = txtDigito.Text
        Dim dig2 As String
        Dim contador, contar, acumulador, division, dig As Integer
        contar = 2
        Dim retorno As Boolean

        Do While rut <> 0
            contador = (rut Mod 10) * contar
            acumulador = acumulador + contador
            rut = rut \ 10
            contar = contar + 1
            If contar = 8 Then
                contar = 2
            End If
        Loop

        division = acumulador Mod 11
        If division = 0 Then
            division = 11
        End If
        dig = 11 - division
        dig2 = CStr(dig)
        If dig2 = 10 Then
            dig2 = "K"
        End If
        If dig2 = digito Then
            ' MsgBox("rut validado")
            retorno = True
        Else
            retorno = False
            MsgBox("Rut erróneo, favor validar")
            txtRut.Clear()
            txtDigito.Clear()
        End If

        Return retorno
    End Function

    Function InsertarDelito(ByVal sql)
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

    Function ExisteRut()
        conn.Close()
        conn.Open()
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("select * from l_delincuente where rut_delincuente = '" + rut + "'", conn)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento : " + ex.ToString)
        End Try

        Return resultado
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim InsertDel As String
        If txtRut.Text = "" And txtDigito.Text = "" Then
            MsgBox("Debe completar el RUT del delincuente!",, "Error")
        Else
            rut = txtRut.Text + "-" + txtDigito.Text
            InsertDel = "insert into b_detalle_delito values('" + rut + "'," + id_delito.ToString + ",'" + detalle + "','" + fechaingreso + "'," + id_zona.ToString + "," + id_comuna.ToString + "," + id_sector.ToString + "," + id_banda.ToString + "," + Login.id_user.ToString + "," + Login.id_int.ToString + ",getdate())"
            MsgBox(InsertDel)
            If validaRut() = True Then
                If (ExisteRut() = False) Then
                    MsgBox("Delincuente no se encuentra registrado, se direccionará al menú de registro de delincuente")
                    frmDelincuente.Show()
                    Me.Close()
                Else
                    If (InsertarDelito(InsertDel)) Then
                        MsgBox("Delito ingresado exitosamente!",, "Registro existoso")
                        Me.Close()
                    Else
                        MsgBox("Error al ingresar delito, favor contactar al Administrador",, "Error")
                    End If
                End If
            End If
        End If
    End Sub
    Sub llenaComboZona()
        comando = New SqlCommand("select * from l_zona", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbZona.DisplayMember = "desc_zona"
        cmbZona.ValueMember = "id_zona"
        cmbZona.DataSource = dt
    End Sub
    Sub llenaComboComuna(id_zona As String)
        comando = New SqlCommand("select * from l_comuna where l_id_zona = " + id_zona + "", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbComuna.DisplayMember = "desc_comuna"
        cmbComuna.ValueMember = "id_comuna"
        cmbComuna.DataSource = dt
    End Sub
    Sub llenaComboSector()
        Dim zona, comuna As String
        zona = id_zona.ToString
        comuna = id_comuna.ToString
        comando = New SqlCommand("select * from l_sector where l_id_zona = " + zona + "and l_id_comuna=" + comuna + " and l_id_institucion=" + inst, conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(dt)
        cmbSector.DisplayMember = "desc_sector"
        cmbSector.ValueMember = "id_sector"
        cmbSector.DataSource = dt
    End Sub

End Class