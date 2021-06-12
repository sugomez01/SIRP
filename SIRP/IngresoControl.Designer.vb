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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dtpFechaControl = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.cmbSector = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!)
        Me.Label1.Location = New System.Drawing.Point(320, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso Control"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblRut.Location = New System.Drawing.Point(83, 118)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(36, 23)
        Me.lblRut.TabIndex = 1
        Me.lblRut.Text = "Rut"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtRut.Location = New System.Drawing.Point(172, 116)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(148, 29)
        Me.txtRut.TabIndex = 7
        '
        'txtDigito
        '
        Me.txtDigito.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtDigito.Location = New System.Drawing.Point(326, 116)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(41, 29)
        Me.txtDigito.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblNombre.Location = New System.Drawing.Point(83, 175)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 23)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'dtpFechaControl
        '
        Me.dtpFechaControl.AutoSize = True
        Me.dtpFechaControl.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.dtpFechaControl.Location = New System.Drawing.Point(40, 232)
        Me.dtpFechaControl.Name = "dtpFechaControl"
        Me.dtpFechaControl.Size = New System.Drawing.Size(116, 23)
        Me.dtpFechaControl.TabIndex = 10
        Me.dtpFechaControl.Text = "Fecha Control"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblUbicacion.Location = New System.Drawing.Point(458, 118)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(85, 23)
        Me.lblUbicacion.TabIndex = 11
        Me.lblUbicacion.Text = "Ubicacion"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblZona.Location = New System.Drawing.Point(458, 175)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(48, 23)
        Me.lblZona.TabIndex = 12
        Me.lblZona.Text = "Zona"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblComuna.Location = New System.Drawing.Point(458, 226)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(74, 23)
        Me.lblComuna.TabIndex = 13
        Me.lblComuna.Text = "Comuna"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtNombre.Location = New System.Drawing.Point(172, 175)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(148, 29)
        Me.txtNombre.TabIndex = 14
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtUbicacion.Location = New System.Drawing.Point(557, 112)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(148, 29)
        Me.txtUbicacion.TabIndex = 16
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.dtpFecha.Location = New System.Drawing.Point(172, 226)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(148, 29)
        Me.dtpFecha.TabIndex = 19
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblSector.Location = New System.Drawing.Point(83, 291)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(59, 23)
        Me.lblSector.TabIndex = 20
        Me.lblSector.Text = "Sector"
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(557, 168)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(148, 30)
        Me.cmbZona.TabIndex = 21
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(557, 219)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(148, 30)
        Me.cmbComuna.TabIndex = 22
        '
        'cmbSector
        '
        Me.cmbSector.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(172, 284)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(148, 30)
        Me.cmbSector.TabIndex = 23
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.btnRegistrar.Location = New System.Drawing.Point(573, 339)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(132, 38)
        Me.btnRegistrar.TabIndex = 24
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'IngresoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 420)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.cmbSector)
        Me.Controls.Add(Me.cmbComuna)
        Me.Controls.Add(Me.cmbZona)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblComuna)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.dtpFechaControl)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtDigito)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IngresoControl"
        Me.Text = "IngresoControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents dtpFechaControl As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblZona As Label
    Friend WithEvents lblComuna As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblSector As Label
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents cmbSector As ComboBox
    Friend WithEvents btnRegistrar As Button
End Class
