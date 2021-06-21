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
        Me.LdelincuenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SIRPDataSet = New SIRP.SIRPDataSet()
        Me.L_delincuenteTableAdapter = New SIRP.SIRPDataSetTableAdapters.l_delincuenteTableAdapter()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rbtnReporte1 = New System.Windows.Forms.RadioButton()
        Me.rbtnReporte2 = New System.Windows.Forms.RadioButton()
        Me.rbtnReporte3 = New System.Windows.Forms.RadioButton()
        Me.rbtnReporte4 = New System.Windows.Forms.RadioButton()
        Me.rbtnReporte5 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtnReporte6 = New System.Windows.Forms.RadioButton()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.LdelincuenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIRPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 26)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMeúPrincipalToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
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
        Me.lblTitulo.Location = New System.Drawing.Point(514, 28)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(94, 29)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Reporte"
        '
        'dgvReporte
        '
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte.Location = New System.Drawing.Point(264, 87)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.RowHeadersWidth = 51
        Me.dgvReporte.RowTemplate.Height = 24
        Me.dgvReporte.Size = New System.Drawing.Size(908, 311)
        Me.dgvReporte.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.Button1.Location = New System.Drawing.Point(32, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.Button2.Location = New System.Drawing.Point(142, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Descargar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rbtnReporte1
        '
        Me.rbtnReporte1.AutoSize = True
        Me.rbtnReporte1.Checked = True
        Me.rbtnReporte1.Location = New System.Drawing.Point(32, 87)
        Me.rbtnReporte1.Name = "rbtnReporte1"
        Me.rbtnReporte1.Size = New System.Drawing.Size(198, 21)
        Me.rbtnReporte1.TabIndex = 6
        Me.rbtnReporte1.TabStop = True
        Me.rbtnReporte1.Text = "Ordenado Alfabeticamente"
        Me.rbtnReporte1.UseVisualStyleBackColor = True
        '
        'rbtnReporte2
        '
        Me.rbtnReporte2.AutoSize = True
        Me.rbtnReporte2.Location = New System.Drawing.Point(32, 114)
        Me.rbtnReporte2.Name = "rbtnReporte2"
        Me.rbtnReporte2.Size = New System.Drawing.Size(150, 21)
        Me.rbtnReporte2.TabIndex = 7
        Me.rbtnReporte2.TabStop = True
        Me.rbtnReporte2.Text = "Por delito cometido"
        Me.rbtnReporte2.UseVisualStyleBackColor = True
        '
        'rbtnReporte3
        '
        Me.rbtnReporte3.AutoSize = True
        Me.rbtnReporte3.Location = New System.Drawing.Point(32, 141)
        Me.rbtnReporte3.Name = "rbtnReporte3"
        Me.rbtnReporte3.Size = New System.Drawing.Size(201, 21)
        Me.rbtnReporte3.TabIndex = 8
        Me.rbtnReporte3.TabStop = True
        Me.rbtnReporte3.Text = "Por Comuna de Residencia"
        Me.rbtnReporte3.UseVisualStyleBackColor = True
        '
        'rbtnReporte4
        '
        Me.rbtnReporte4.AutoSize = True
        Me.rbtnReporte4.Location = New System.Drawing.Point(32, 168)
        Me.rbtnReporte4.Name = "rbtnReporte4"
        Me.rbtnReporte4.Size = New System.Drawing.Size(127, 21)
        Me.rbtnReporte4.TabIndex = 9
        Me.rbtnReporte4.TabStop = True
        Me.rbtnReporte4.Text = "Ultima vez visto"
        Me.rbtnReporte4.UseVisualStyleBackColor = True
        '
        'rbtnReporte5
        '
        Me.rbtnReporte5.AutoSize = True
        Me.rbtnReporte5.Location = New System.Drawing.Point(32, 195)
        Me.rbtnReporte5.Name = "rbtnReporte5"
        Me.rbtnReporte5.Size = New System.Drawing.Size(126, 21)
        Me.rbtnReporte5.TabIndex = 10
        Me.rbtnReporte5.TabStop = True
        Me.rbtnReporte5.Text = "Por parentesco"
        Me.rbtnReporte5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(30, 289)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 11
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DateTimePicker2.Location = New System.Drawing.Point(30, 348)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Delincuente :"
        '
        'rbtnReporte6
        '
        Me.rbtnReporte6.AutoSize = True
        Me.rbtnReporte6.Location = New System.Drawing.Point(32, 222)
        Me.rbtnReporte6.Name = "rbtnReporte6"
        Me.rbtnReporte6.Size = New System.Drawing.Size(156, 21)
        Me.rbtnReporte6.TabIndex = 15
        Me.rbtnReporte6.TabStop = True
        Me.rbtnReporte6.Text = "Delito por Ubicacion"
        Me.rbtnReporte6.UseVisualStyleBackColor = True
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(29, 268)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(83, 17)
        Me.lblFechaIni.TabIndex = 16
        Me.lblFechaIni.Text = "Fecha Inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(29, 326)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 17)
        Me.lblFechaFin.TabIndex = 17
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'ModuloReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 476)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaIni)
        Me.Controls.Add(Me.rbtnReporte6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rbtnReporte5)
        Me.Controls.Add(Me.rbtnReporte4)
        Me.Controls.Add(Me.rbtnReporte3)
        Me.Controls.Add(Me.rbtnReporte2)
        Me.Controls.Add(Me.rbtnReporte1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvReporte)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ModuloReportes"
        Me.Text = "ModuloReportes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.LdelincuenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIRPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMeúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIRPDataSet As SIRPDataSet
    Friend WithEvents LdelincuenteBindingSource As BindingSource
    Friend WithEvents L_delincuenteTableAdapter As SIRPDataSetTableAdapters.l_delincuenteTableAdapter
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents rbtnReporte1 As RadioButton
    Friend WithEvents rbtnReporte2 As RadioButton
    Friend WithEvents rbtnReporte3 As RadioButton
    Friend WithEvents rbtnReporte4 As RadioButton
    Friend WithEvents rbtnReporte5 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents rbtnReporte6 As RadioButton
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents lblFechaFin As Label
End Class
