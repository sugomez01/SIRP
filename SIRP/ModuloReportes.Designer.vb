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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuloReportes))
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
        Me.rbtnReporte6 = New System.Windows.Forms.RadioButton()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblSubTitulo = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LdelincuenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIRPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 18.26!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(483, 22)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(242, 35)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Módulo de Reportes"
        '
        'dgvReporte
        '
        Me.dgvReporte.AllowUserToAddRows = False
        Me.dgvReporte.AllowUserToDeleteRows = False
        Me.dgvReporte.AllowUserToResizeColumns = False
        Me.dgvReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.dgvReporte.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvReporte.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dgvReporte.Location = New System.Drawing.Point(27, 55)
        Me.dgvReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReporte.MultiSelect = False
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.ReadOnly = True
        Me.dgvReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReporte.RowHeadersVisible = False
        Me.dgvReporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvReporte.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReporte.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvReporte.RowTemplate.Height = 24
        Me.dgvReporte.RowTemplate.ReadOnly = True
        Me.dgvReporte.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvReporte.Size = New System.Drawing.Size(670, 339)
        Me.dgvReporte.StandardTab = True
        Me.dgvReporte.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(22, 354)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "GENERAR REPORTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(224, 354)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "DESCARGAR REPORTE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rbtnReporte1
        '
        Me.rbtnReporte1.AutoSize = True
        Me.rbtnReporte1.Checked = True
        Me.rbtnReporte1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rbtnReporte1.ForeColor = System.Drawing.Color.White
        Me.rbtnReporte1.Location = New System.Drawing.Point(22, 55)
        Me.rbtnReporte1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtnReporte1.Name = "rbtnReporte1"
        Me.rbtnReporte1.Size = New System.Drawing.Size(350, 24)
        Me.rbtnReporte1.TabIndex = 0
        Me.rbtnReporte1.TabStop = True
        Me.rbtnReporte1.Text = "Listado de delicuente ordenado alfabéticamente"
        Me.rbtnReporte1.UseVisualStyleBackColor = True
        '
        'rbtnReporte2
        '
        Me.rbtnReporte2.AutoSize = True
        Me.rbtnReporte2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rbtnReporte2.ForeColor = System.Drawing.Color.White
        Me.rbtnReporte2.Location = New System.Drawing.Point(22, 83)
        Me.rbtnReporte2.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtnReporte2.Name = "rbtnReporte2"
        Me.rbtnReporte2.Size = New System.Drawing.Size(315, 24)
        Me.rbtnReporte2.TabIndex = 1
        Me.rbtnReporte2.TabStop = True
        Me.rbtnReporte2.Text = "Listado de delito cometido por delincuente"
        Me.rbtnReporte2.UseVisualStyleBackColor = True
        '
        'rbtnReporte3
        '
        Me.rbtnReporte3.AutoSize = True
        Me.rbtnReporte3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rbtnReporte3.ForeColor = System.Drawing.Color.White
        Me.rbtnReporte3.Location = New System.Drawing.Point(22, 111)
        Me.rbtnReporte3.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtnReporte3.Name = "rbtnReporte3"
        Me.rbtnReporte3.Size = New System.Drawing.Size(359, 24)
        Me.rbtnReporte3.TabIndex = 2
        Me.rbtnReporte3.TabStop = True
        Me.rbtnReporte3.Text = "Listado de delincuentes por comuna de residencia"
        Me.rbtnReporte3.UseVisualStyleBackColor = True
        '
        'rbtnReporte4
        '
        Me.rbtnReporte4.AutoSize = True
        Me.rbtnReporte4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rbtnReporte4.ForeColor = System.Drawing.Color.White
        Me.rbtnReporte4.Location = New System.Drawing.Point(22, 139)
        Me.rbtnReporte4.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtnReporte4.Name = "rbtnReporte4"
        Me.rbtnReporte4.Size = New System.Drawing.Size(233, 24)
        Me.rbtnReporte4.TabIndex = 3
        Me.rbtnReporte4.TabStop = True
        Me.rbtnReporte4.Text = "Listado de controles realizados"
        Me.rbtnReporte4.UseVisualStyleBackColor = True
        '
        'rbtnReporte5
        '
        Me.rbtnReporte5.AutoSize = True
        Me.rbtnReporte5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rbtnReporte5.ForeColor = System.Drawing.Color.White
        Me.rbtnReporte5.Location = New System.Drawing.Point(22, 167)
        Me.rbtnReporte5.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtnReporte5.Name = "rbtnReporte5"
        Me.rbtnReporte5.Size = New System.Drawing.Size(148, 24)
        Me.rbtnReporte5.TabIndex = 4
        Me.rbtnReporte5.TabStop = True
        Me.rbtnReporte5.Text = "Listado de bandas"
        Me.rbtnReporte5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(133, 245)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 27)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(133, 288)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(151, 27)
        Me.DateTimePicker2.TabIndex = 7
        '
        'rbtnReporte6
        '
        Me.rbtnReporte6.AutoSize = True
        Me.rbtnReporte6.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.rbtnReporte6.ForeColor = System.Drawing.Color.White
        Me.rbtnReporte6.Location = New System.Drawing.Point(20, 195)
        Me.rbtnReporte6.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtnReporte6.Name = "rbtnReporte6"
        Me.rbtnReporte6.Size = New System.Drawing.Size(235, 24)
        Me.rbtnReporte6.TabIndex = 5
        Me.rbtnReporte6.TabStop = True
        Me.rbtnReporte6.Text = "Listado de delitos por comunas"
        Me.rbtnReporte6.UseVisualStyleBackColor = True
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFechaIni.ForeColor = System.Drawing.Color.White
        Me.lblFechaIni.Location = New System.Drawing.Point(18, 250)
        Me.lblFechaIni.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(87, 20)
        Me.lblFechaIni.TabIndex = 16
        Me.lblFechaIni.Text = "Fecha Inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFechaFin.ForeColor = System.Drawing.Color.White
        Me.lblFechaFin.Location = New System.Drawing.Point(18, 293)
        Me.lblFechaFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(70, 20)
        Me.lblFechaFin.TabIndex = 17
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblSubTitulo
        '
        Me.lblSubTitulo.AutoSize = True
        Me.lblSubTitulo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblSubTitulo.ForeColor = System.Drawing.Color.White
        Me.lblSubTitulo.Location = New System.Drawing.Point(18, 22)
        Me.lblSubTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubTitulo.Name = "lblSubTitulo"
        Me.lblSubTitulo.Size = New System.Drawing.Size(188, 20)
        Me.lblSubTitulo.TabIndex = 14
        Me.lblSubTitulo.Text = "Seleccione tipo de reporte:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(29, 91)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1140, 432)
        Me.FlowLayoutPanel1.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblSubTitulo)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.rbtnReporte2)
        Me.Panel1.Controls.Add(Me.lblFechaIni)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.rbtnReporte1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.rbtnReporte6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.rbtnReporte3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.rbtnReporte4)
        Me.Panel1.Controls.Add(Me.rbtnReporte5)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 422)
        Me.Panel1.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dgvReporte)
        Me.Panel2.Location = New System.Drawing.Point(398, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 422)
        Me.Panel2.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Detalle del reporte:"
        '
        'ModuloReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1204, 558)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ModuloReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModuloReportes"
        CType(Me.LdelincuenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIRPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SIRPDataSet As SIRPDataSet
    Friend WithEvents LdelincuenteBindingSource As BindingSource
    Friend WithEvents L_delincuenteTableAdapter As SIRPDataSetTableAdapters.l_delincuenteTableAdapter
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents rbtnReporte1 As RadioButton
    Friend WithEvents rbtnReporte2 As RadioButton
    Friend WithEvents rbtnReporte3 As RadioButton
    Friend WithEvents rbtnReporte4 As RadioButton
    Friend WithEvents rbtnReporte5 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents rbtnReporte6 As RadioButton
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblSubTitulo As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReporte As DataGridView
End Class
