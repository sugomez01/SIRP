<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuloReportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMeúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RutdelincuenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescapellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescapodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescdomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechanacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LidestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LidbandaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LidusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechacreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LdelincuenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIRPDataSet = New SIRP.SIRPDataSet()
        Me.L_delincuenteTableAdapter = New SIRP.SIRPDataSetTableAdapters.l_delincuenteTableAdapter()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LdelincuenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIRPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMeúPrincipalToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'VolverAlMeúPrincipalToolStripMenuItem
        '
        Me.VolverAlMeúPrincipalToolStripMenuItem.Name = "VolverAlMeúPrincipalToolStripMenuItem"
        Me.VolverAlMeúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.VolverAlMeúPrincipalToolStripMenuItem.Text = "Volver al meú principal"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del sistema"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutdelincuenteDataGridViewTextBoxColumn, Me.DescnombreDataGridViewTextBoxColumn, Me.DescapellidoDataGridViewTextBoxColumn, Me.DescapodoDataGridViewTextBoxColumn, Me.DescdomicilioDataGridViewTextBoxColumn, Me.Fono1DataGridViewTextBoxColumn, Me.FechanacimientoDataGridViewTextBoxColumn, Me.LidestadoDataGridViewTextBoxColumn, Me.LidbandaDataGridViewTextBoxColumn, Me.LidusuarioDataGridViewTextBoxColumn, Me.FechacreacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LdelincuenteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(71, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1047, 235)
        Me.DataGridView1.TabIndex = 1
        '
        'RutdelincuenteDataGridViewTextBoxColumn
        '
        Me.RutdelincuenteDataGridViewTextBoxColumn.DataPropertyName = "rut_delincuente"
        Me.RutdelincuenteDataGridViewTextBoxColumn.HeaderText = "rut_delincuente"
        Me.RutdelincuenteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RutdelincuenteDataGridViewTextBoxColumn.Name = "RutdelincuenteDataGridViewTextBoxColumn"
        Me.RutdelincuenteDataGridViewTextBoxColumn.Width = 125
        '
        'DescnombreDataGridViewTextBoxColumn
        '
        Me.DescnombreDataGridViewTextBoxColumn.DataPropertyName = "desc_nombre"
        Me.DescnombreDataGridViewTextBoxColumn.HeaderText = "desc_nombre"
        Me.DescnombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescnombreDataGridViewTextBoxColumn.Name = "DescnombreDataGridViewTextBoxColumn"
        Me.DescnombreDataGridViewTextBoxColumn.Width = 125
        '
        'DescapellidoDataGridViewTextBoxColumn
        '
        Me.DescapellidoDataGridViewTextBoxColumn.DataPropertyName = "desc_apellido"
        Me.DescapellidoDataGridViewTextBoxColumn.HeaderText = "desc_apellido"
        Me.DescapellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescapellidoDataGridViewTextBoxColumn.Name = "DescapellidoDataGridViewTextBoxColumn"
        Me.DescapellidoDataGridViewTextBoxColumn.Width = 125
        '
        'DescapodoDataGridViewTextBoxColumn
        '
        Me.DescapodoDataGridViewTextBoxColumn.DataPropertyName = "desc_apodo"
        Me.DescapodoDataGridViewTextBoxColumn.HeaderText = "desc_apodo"
        Me.DescapodoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescapodoDataGridViewTextBoxColumn.Name = "DescapodoDataGridViewTextBoxColumn"
        Me.DescapodoDataGridViewTextBoxColumn.Width = 125
        '
        'DescdomicilioDataGridViewTextBoxColumn
        '
        Me.DescdomicilioDataGridViewTextBoxColumn.DataPropertyName = "desc_domicilio"
        Me.DescdomicilioDataGridViewTextBoxColumn.HeaderText = "desc_domicilio"
        Me.DescdomicilioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescdomicilioDataGridViewTextBoxColumn.Name = "DescdomicilioDataGridViewTextBoxColumn"
        Me.DescdomicilioDataGridViewTextBoxColumn.Width = 125
        '
        'Fono1DataGridViewTextBoxColumn
        '
        Me.Fono1DataGridViewTextBoxColumn.DataPropertyName = "fono1"
        Me.Fono1DataGridViewTextBoxColumn.HeaderText = "fono1"
        Me.Fono1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.Fono1DataGridViewTextBoxColumn.Name = "Fono1DataGridViewTextBoxColumn"
        Me.Fono1DataGridViewTextBoxColumn.Width = 125
        '
        'FechanacimientoDataGridViewTextBoxColumn
        '
        Me.FechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento"
        Me.FechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento"
        Me.FechanacimientoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechanacimientoDataGridViewTextBoxColumn.Name = "FechanacimientoDataGridViewTextBoxColumn"
        Me.FechanacimientoDataGridViewTextBoxColumn.Width = 125
        '
        'LidestadoDataGridViewTextBoxColumn
        '
        Me.LidestadoDataGridViewTextBoxColumn.DataPropertyName = "l_id_estado"
        Me.LidestadoDataGridViewTextBoxColumn.HeaderText = "l_id_estado"
        Me.LidestadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LidestadoDataGridViewTextBoxColumn.Name = "LidestadoDataGridViewTextBoxColumn"
        Me.LidestadoDataGridViewTextBoxColumn.Width = 125
        '
        'LidbandaDataGridViewTextBoxColumn
        '
        Me.LidbandaDataGridViewTextBoxColumn.DataPropertyName = "l_id_banda"
        Me.LidbandaDataGridViewTextBoxColumn.HeaderText = "l_id_banda"
        Me.LidbandaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LidbandaDataGridViewTextBoxColumn.Name = "LidbandaDataGridViewTextBoxColumn"
        Me.LidbandaDataGridViewTextBoxColumn.Width = 125
        '
        'LidusuarioDataGridViewTextBoxColumn
        '
        Me.LidusuarioDataGridViewTextBoxColumn.DataPropertyName = "l_id_usuario"
        Me.LidusuarioDataGridViewTextBoxColumn.HeaderText = "l_id_usuario"
        Me.LidusuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LidusuarioDataGridViewTextBoxColumn.Name = "LidusuarioDataGridViewTextBoxColumn"
        Me.LidusuarioDataGridViewTextBoxColumn.Width = 125
        '
        'FechacreacionDataGridViewTextBoxColumn
        '
        Me.FechacreacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_creacion"
        Me.FechacreacionDataGridViewTextBoxColumn.HeaderText = "fecha_creacion"
        Me.FechacreacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechacreacionDataGridViewTextBoxColumn.Name = "FechacreacionDataGridViewTextBoxColumn"
        Me.FechacreacionDataGridViewTextBoxColumn.Width = 125
        '
        'LdelincuenteBindingSource
        '
        Me.LdelincuenteBindingSource.DataMember = "l_delincuente"
        Me.LdelincuenteBindingSource.DataSource = Me.SIRPDataSet
        '
        'SIRPDataSet
        '
        Me.SIRPDataSet.DataSetName = "SIRPDataSet"
        Me.SIRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L_delincuenteTableAdapter
        '
        Me.L_delincuenteTableAdapter.ClearBeforeFill = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(530, 55)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(94, 29)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Reporte"
        '
        'ModuloReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 476)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ModuloReportes"
        Me.Text = "ModuloReportes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LdelincuenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIRPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMeúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SIRPDataSet As SIRPDataSet
    Friend WithEvents LdelincuenteBindingSource As BindingSource
    Friend WithEvents L_delincuenteTableAdapter As SIRPDataSetTableAdapters.l_delincuenteTableAdapter
    Friend WithEvents RutdelincuenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescnombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescapellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescapodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescdomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Fono1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechanacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LidestadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LidbandaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LidusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechacreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTitulo As Label
End Class
