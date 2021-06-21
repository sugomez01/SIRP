<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoDelito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoDelito))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblRUT = New System.Windows.Forms.Label()
        Me.lblDelito = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblBanda = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbSector = New System.Windows.Forms.ComboBox()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.cmbBanda = New System.Windows.Forms.ComboBox()
        Me.dtpFechaDelito = New System.Windows.Forms.DateTimePicker()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.25!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(437, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(245, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ingreso delito cometido"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblRUT.ForeColor = System.Drawing.Color.White
        Me.lblRUT.Location = New System.Drawing.Point(24, 28)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(36, 20)
        Me.lblRUT.TabIndex = 1
        Me.lblRUT.Text = "RUT"
        '
        'lblDelito
        '
        Me.lblDelito.AutoSize = True
        Me.lblDelito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblDelito.ForeColor = System.Drawing.Color.White
        Me.lblDelito.Location = New System.Drawing.Point(24, 100)
        Me.lblDelito.Name = "lblDelito"
        Me.lblDelito.Size = New System.Drawing.Size(57, 20)
        Me.lblDelito.TabIndex = 3
        Me.lblDelito.Text = "DELITO"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(24, 66)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(106, 20)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "FECHA DELITO"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblZona.ForeColor = System.Drawing.Color.White
        Me.lblZona.Location = New System.Drawing.Point(54, 47)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(50, 20)
        Me.lblZona.TabIndex = 5
        Me.lblZona.Text = "ZONA"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblComuna.ForeColor = System.Drawing.Color.White
        Me.lblComuna.Location = New System.Drawing.Point(54, 104)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(73, 20)
        Me.lblComuna.TabIndex = 6
        Me.lblComuna.Text = "COMUNA"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblSector.ForeColor = System.Drawing.Color.White
        Me.lblSector.Location = New System.Drawing.Point(54, 165)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(61, 20)
        Me.lblSector.TabIndex = 7
        Me.lblSector.Text = "SECTOR"
        '
        'lblBanda
        '
        Me.lblBanda.AutoSize = True
        Me.lblBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblBanda.ForeColor = System.Drawing.Color.White
        Me.lblBanda.Location = New System.Drawing.Point(54, 225)
        Me.lblBanda.Name = "lblBanda"
        Me.lblBanda.Size = New System.Drawing.Size(60, 20)
        Me.lblBanda.TabIndex = 8
        Me.lblBanda.Text = "BANDA"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblDetalle.ForeColor = System.Drawing.Color.White
        Me.lblDetalle.Location = New System.Drawing.Point(24, 141)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(157, 20)
        Me.lblDetalle.TabIndex = 9
        Me.lblDetalle.Text = "DETALLES DEL DELITO"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRut.Location = New System.Drawing.Point(142, 25)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(159, 27)
        Me.txtRut.TabIndex = 0
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDetalle.Location = New System.Drawing.Point(28, 166)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDetalle.MaxLength = 500
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(479, 126)
        Me.txtDetalle.TabIndex = 4
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.Location = New System.Drawing.Point(844, 435)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(146, 30)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "REGISTRAR DELITO"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 97)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(365, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'cmbSector
        '
        Me.cmbSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(142, 162)
        Me.cmbSector.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(201, 28)
        Me.cmbSector.TabIndex = 7
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(142, 44)
        Me.cmbZona.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(201, 28)
        Me.cmbZona.TabIndex = 5
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(142, 101)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(201, 28)
        Me.cmbComuna.TabIndex = 6
        '
        'cmbBanda
        '
        Me.cmbBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(142, 222)
        Me.cmbBanda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(201, 28)
        Me.cmbBanda.TabIndex = 8
        '
        'dtpFechaDelito
        '
        Me.dtpFechaDelito.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaDelito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.dtpFechaDelito.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDelito.Location = New System.Drawing.Point(142, 61)
        Me.dtpFechaDelito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaDelito.MaxDate = New Date(2021, 6, 21, 0, 0, 0, 0)
        Me.dtpFechaDelito.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaDelito.Name = "dtpFechaDelito"
        Me.dtpFechaDelito.Size = New System.Drawing.Size(159, 27)
        Me.dtpFechaDelito.TabIndex = 3
        Me.dtpFechaDelito.Value = New Date(2021, 6, 21, 0, 0, 0, 0)
        '
        'txtDigito
        '
        Me.txtDigito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDigito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDigito.Location = New System.Drawing.Point(330, 25)
        Me.txtDigito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDigito.MaxLength = 1
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(34, 27)
        Me.txtDigito.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblGuion)
        Me.Panel2.Controls.Add(Me.lblRUT)
        Me.Panel2.Controls.Add(Me.dtpFechaDelito)
        Me.Panel2.Controls.Add(Me.lblFecha)
        Me.Panel2.Controls.Add(Me.txtDigito)
        Me.Panel2.Controls.Add(Me.txtDetalle)
        Me.Panel2.Controls.Add(Me.txtRut)
        Me.Panel2.Controls.Add(Me.lblDetalle)
        Me.Panel2.Controls.Add(Me.lblDelito)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 317)
        Me.Panel2.TabIndex = 0
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblGuion.ForeColor = System.Drawing.Color.White
        Me.lblGuion.Location = New System.Drawing.Point(309, 28)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 20)
        Me.lblGuion.TabIndex = 21
        Me.lblGuion.Text = "-"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblSector)
        Me.Panel3.Controls.Add(Me.cmbSector)
        Me.Panel3.Controls.Add(Me.cmbBanda)
        Me.Panel3.Controls.Add(Me.cmbZona)
        Me.Panel3.Controls.Add(Me.cmbComuna)
        Me.Panel3.Controls.Add(Me.lblComuna)
        Me.Panel3.Controls.Add(Me.lblZona)
        Me.Panel3.Controls.Add(Me.lblBanda)
        Me.Panel3.Location = New System.Drawing.Point(549, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(428, 317)
        Me.Panel3.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(38, 88)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(980, 323)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'IngresoDelito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1068, 489)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "IngresoDelito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoDelito"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblRUT As Label
    Friend WithEvents lblDelito As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblZona As Label
    Friend WithEvents lblComuna As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents lblBanda As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmbSector As ComboBox
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents cmbBanda As ComboBox
    Friend WithEvents dtpFechaDelito As DateTimePicker
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblGuion As Label
End Class
