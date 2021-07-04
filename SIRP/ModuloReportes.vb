Imports System.Data.SqlClient



Public Class ModuloReportes

    Dim fecha_ini, fecha_fin, reporte1 As String

    Public conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-6GF7OE4K;Initial Catalog=SIRP;Integrated Security=True")
    'Public conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-EUII0N8;User ID=sa;Password=sasa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    'declaracion de variables para realizar consultas SQL
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rbtnReporte6.Checked = True Then
            fecha_ini = Format(DateTimePicker1.Value, "yyyy/MM/dd").ToString()
            fecha_fin = Format(DateTimePicker2.Value, "yyyy/MM/dd").ToString()
        End If


        ds.Tables.Clear()

        If rbtnReporte1.Checked = True Then
            comando = New SqlCommand("select * from l_delincuente order by desc_apellido,desc_nombre", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte2.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delito_cometido", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte3.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delincuente_comuna", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte4.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delincuente_ultima_vez", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte5.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delincuente_parentesco order by desc_banda", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte6.Checked = True Then

            Dim query
            query = "select * from tb_rep_delito_ubicacion where fecha_delito between '" + fecha_ini + "' and '" + fecha_fin + "' order by desc_delito"
            comando = New SqlCommand("select * from tb_rep_delito_ubicacion where fecha_delito between '" + fecha_ini + "' and '" + fecha_fin + "' order by desc_delito", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        End If

    End Sub

    Private Sub rbtnReporte1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReporte1.CheckedChanged
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        lblFechaFin.Visible = False
        lblFechaIni.Visible = False
    End Sub

    Private Sub rbtnReporte2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReporte2.CheckedChanged

        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        lblFechaFin.Visible = False
        lblFechaIni.Visible = False

    End Sub

    Private Sub rbtnReporte3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReporte3.CheckedChanged
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
    End Sub

    Private Sub rbtnReporte4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReporte4.CheckedChanged
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        lblFechaFin.Visible = False
        lblFechaIni.Visible = False
    End Sub

    Private Sub rbtnReporte5_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReporte5.CheckedChanged
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        lblFechaFin.Visible = False
        lblFechaIni.Visible = False
    End Sub

    Private Sub rbtnReporte6_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReporte6.CheckedChanged

        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        lblFechaFin.Visible = True
        lblFechaIni.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ds.Tables.Clear()

        If rbtnReporte1.Checked = True Then
            comando = New SqlCommand("select * from l_delincuente order by desc_apellido,desc_nombre", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            '  dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte2.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delito_cometido", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            'dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte3.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delincuente_comuna", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            ' dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte4.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delincuente_ultima_vez", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte5.Checked = True Then

            comando = New SqlCommand("select * from tb_rep_delincuente_parentesco order by desc_banda", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            'dgvReporte.DataSource = ds.Tables(0).DefaultView

        ElseIf rbtnReporte6.Checked = True Then

            Dim query
            query = "select * from tb_rep_delito_ubicacion where fecha_delito between '" + fecha_ini + "' and '" + fecha_fin + "' order by desc_delito"
            comando = New SqlCommand("select * from tb_rep_delito_ubicacion where fecha_delito between '" + fecha_ini + "' and '" + fecha_fin + "' order by desc_delito", conn)
            da = New SqlDataAdapter(comando)
            dt = New DataTable()
            da.Fill(ds)

            'dgvReporte.DataSource = ds.Tables(0).DefaultView

        End If

        dgvReporte.DataSource = ds.Tables(0).DefaultView

        Dim save As New SaveFileDialog
        save.Filter = "Archivo XML (*.xml) | *.xml"
        save.FileName = "nombre_de_archivo_generado.xml"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim fs As System.IO.FileStream
            Dim xtw As System.Xml.XmlTextWriter
            dt.TableName = "items"
            fs = New System.IO.FileStream(save.FileName, IO.FileMode.Create)
            xtw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.Unicode)
            xtw.WriteProcessingInstruction("xml", "version='1.0'")
            xtw.WriteProcessingInstruction("mso-application", "progid='Excel.Sheet'")
            ds.WriteXml(xtw)
            xtw.Close()


        End If

    End Sub


End Class