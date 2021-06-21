Imports System.Data.SqlClient



Public Class ModuloReportes

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

        comando = New SqlCommand("select * from b_detalle_delito", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(ds)

        dgvReporte.DataSource = ds.Tables(0).DefaultView

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        comando = New SqlCommand("select * from b_detalle_delito", conn)
        da = New SqlDataAdapter(comando)
        dt = New DataTable()
        da.Fill(ds)

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