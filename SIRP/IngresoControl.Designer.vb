<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoControl))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.cmbSector = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.25!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(419, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(270, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ingreso control preventivo"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblRut.ForeColor = System.Drawing.Color.White
        Me.lblRut.Location = New System.Drawing.Point(26, 41)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(36, 20)
        Me.lblRut.TabIndex = 1
        Me.lblRut.Text = "RUT"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRut.Location = New System.Drawing.Point(171, 37)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(171, 27)
        Me.txtRut.TabIndex = 7
        '
        'txtDigito
        '
        Me.txtDigito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDigito.Location = New System.Drawing.Point(368, 37)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(41, 27)
        Me.txtDigito.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(26, 127)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(123, 20)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "OBSERVACIONES"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(26, 85)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(124, 20)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "FECHA CONTROL"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblUbicacion.ForeColor = System.Drawing.Color.White
        Me.lblUbicacion.Location = New System.Drawing.Point(51, 65)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(50, 20)
        Me.lblUbicacion.TabIndex = 11
        Me.lblUbicacion.Text = "CALLE"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblZona.ForeColor = System.Drawing.Color.White
        Me.lblZona.Location = New System.Drawing.Point(51, 108)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(50, 20)
        Me.lblZona.TabIndex = 12
        Me.lblZona.Text = "ZONA"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblComuna.ForeColor = System.Drawing.Color.White
        Me.lblComuna.Location = New System.Drawing.Point(51, 154)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(73, 20)
        Me.lblComuna.TabIndex = 13
        Me.lblComuna.Text = "COMUNA"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtObservaciones.Location = New System.Drawing.Point(171, 124)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(311, 127)
        Me.txtObservaciones.TabIndex = 14
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtUbicacion.Location = New System.Drawing.Point(141, 61)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(221, 27)
        Me.txtUbicacion.TabIndex = 16
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.dtpFecha.Location = New System.Drawing.Point(171, 80)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(171, 27)
        Me.dtpFecha.TabIndex = 19
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblSector.ForeColor = System.Drawing.Color.White
        Me.lblSector.Location = New System.Drawing.Point(51, 201)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(61, 20)
        Me.lblSector.TabIndex = 20
        Me.lblSector.Text = "SECTOR"
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(141, 105)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(221, 28)
        Me.cmbZona.TabIndex = 21
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(141, 152)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(221, 28)
        Me.cmbComuna.TabIndex = 22
        '
        'cmbSector
        '
        Me.cmbSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(141, 199)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(221, 28)
        Me.cmbSector.TabIndex = 23
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.Location = New System.Drawing.Point(860, 396)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(157, 28)
        Me.btnRegistrar.TabIndex = 24
        Me.btnRegistrar.Text = "REGISTRAR CONTROL"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblGuion.ForeColor = System.Drawing.Color.White
        Me.lblGuion.Location = New System.Drawing.Point(347, 44)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 20)
        Me.lblGuion.TabIndex = 25
        Me.lblGuion.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblRut)
        Me.Panel1.Controls.Add(Me.lblGuion)
        Me.Panel1.Controls.Add(Me.txtRut)
        Me.Panel1.Controls.Add(Me.txtDigito)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 285)
        Me.Panel1.TabIndex = 26
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(50, 80)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(967, 295)
        Me.FlowLayoutPanel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblUbicacion)
        Me.Panel2.Controls.Add(Me.lblZona)
        Me.Panel2.Controls.Add(Me.cmbSector)
        Me.Panel2.Controls.Add(Me.lblComuna)
        Me.Panel2.Controls.Add(Me.cmbComuna)
        Me.Panel2.Controls.Add(Me.lblSector)
        Me.Panel2.Controls.Add(Me.txtUbicacion)
        Me.Panel2.Controls.Add(Me.cmbZona)
        Me.Panel2.Location = New System.Drawing.Point(535, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(426, 285)
        Me.Panel2.TabIndex = 27
        '
        'IngresoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 450)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IngresoControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoControl"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblZona As Label
    Friend WithEvents lblComuna As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblSector As Label
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents cmbSector As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lblGuion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
End Class
