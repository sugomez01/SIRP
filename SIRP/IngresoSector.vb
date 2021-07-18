Imports System.Data.SqlClient
Public Class IngresoSector

    Dim id_zona, id_comuna As String

    'CONEXION A SQL
    'Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtDetalle.Text = "" Or txtSector.Text = "" Then
            MsgBox("Debe completar todos los campos!",, "Error")
        Else
            Dim id_institucion, insert As String
            id_institucion = Login.id_int
            insert = "insert into l_sector values ('" + txtSector.Text + "','" + txtDetalle.Text + "'," + id_zona + "," + id_comuna + "," + id_institucion + ")"

            If (Insertar(insert)) Then
                MsgBox("Sector agregado exitosamente!",, "Registro existoso")
                Me.Close()
            Else
                MsgBox("Error al ingresar Sector, por favor contacte al Administrador",, "Error")
            End If
        End If
    End Sub

    Private Sub cmbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbZona.SelectedIndexChanged
        id_zona = cmbZona.SelectedValue
        llenaComboComuna(id_zona)
    End Sub
    Private Sub cmbComuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComuna.SelectedIndexChanged
        id_comuna = cmbComuna.SelectedValue.ToString
    End Sub
    Private Sub IngresoSector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaComboZona()
    End Sub
    Function Insertar(ByVal sql)
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

    ' LLENA COMBOX ZONA Y COMUNA
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

End Class