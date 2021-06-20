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
        Me.Label1.Location = New System.Drawing.Point(240, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso Control"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblRut.Location = New System.Drawing.Point(62, 96)
        Me.lblRut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(29, 18)
        Me.lblRut.TabIndex = 1
        Me.lblRut.Text = "Rut"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtRut.Location = New System.Drawing.Point(129, 94)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(112, 25)
        Me.txtRut.TabIndex = 7
        '
        'txtDigito
        '
        Me.txtDigito.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtDigito.Location = New System.Drawing.Point(244, 94)
        Me.txtDigito.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(32, 25)
        Me.txtDigito.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblNombre.Location = New System.Drawing.Point(62, 142)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 18)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'dtpFechaControl
        '
        Me.dtpFechaControl.AutoSize = True
        Me.dtpFechaControl.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.dtpFechaControl.Location = New System.Drawing.Point(30, 188)
        Me.dtpFechaControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dtpFechaControl.Name = "dtpFechaControl"
        Me.dtpFechaControl.Size = New System.Drawing.Size(93, 18)
        Me.dtpFechaControl.TabIndex = 10
        Me.dtpFechaControl.Text = "Fecha Control"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblUbicacion.Location = New System.Drawing.Point(344, 96)
        Me.lblUbicacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(68, 18)
        Me.lblUbicacion.TabIndex = 11
        Me.lblUbicacion.Text = "Ubicacion"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblZona.Location = New System.Drawing.Point(344, 142)
        Me.lblZona.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(38, 18)
        Me.lblZona.TabIndex = 12
        Me.lblZona.Text = "Zona"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblComuna.Location = New System.Drawing.Point(344, 184)
        Me.lblComuna.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(59, 18)
        Me.lblComuna.TabIndex = 13
        Me.lblComuna.Text = "Comuna"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtNombre.Location = New System.Drawing.Point(129, 142)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(112, 25)
        Me.txtNombre.TabIndex = 14
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtUbicacion.Location = New System.Drawing.Point(418, 91)
        Me.txtUbicacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(112, 25)
        Me.txtUbicacion.TabIndex = 16
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.dtpFecha.Location = New System.Drawing.Point(129, 184)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(112, 25)
        Me.dtpFecha.TabIndex = 19
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblSector.Location = New System.Drawing.Point(62, 236)
        Me.lblSector.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(47, 18)
        Me.lblSector.TabIndex = 20
        Me.lblSector.Text = "Sector"
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(418, 136)
        Me.cmbZona.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(112, 25)
        Me.cmbZona.TabIndex = 21
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(418, 178)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(112, 25)
        Me.cmbComuna.TabIndex = 22
        '
        'cmbSector
        '
        Me.cmbSector.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(129, 231)
        Me.cmbSector.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(112, 25)
        Me.cmbSector.TabIndex = 23
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.btnRegistrar.Location = New System.Drawing.Point(430, 275)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(99, 31)
        Me.btnRegistrar.TabIndex = 24
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'IngresoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 341)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
