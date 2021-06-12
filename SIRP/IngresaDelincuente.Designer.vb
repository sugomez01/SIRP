<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresaDelincuente
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDelincuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarDatosDelincuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDelitoCometidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarUltimaVezVistoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMeúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtApodo = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbBanda = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(648, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDelincuenteToolStripMenuItem, Me.ActualizarDatosDelincuenteToolStripMenuItem, Me.IngresarDelitoCometidoToolStripMenuItem, Me.IngresarUltimaVezVistoToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'IngresarDelincuenteToolStripMenuItem
        '
        Me.IngresarDelincuenteToolStripMenuItem.Name = "IngresarDelincuenteToolStripMenuItem"
        Me.IngresarDelincuenteToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.IngresarDelincuenteToolStripMenuItem.Text = "Ingresar Delincuente"
        '
        'ActualizarDatosDelincuenteToolStripMenuItem
        '
        Me.ActualizarDatosDelincuenteToolStripMenuItem.Name = "ActualizarDatosDelincuenteToolStripMenuItem"
        Me.ActualizarDatosDelincuenteToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.ActualizarDatosDelincuenteToolStripMenuItem.Text = "Actualizar datos Delincuente"
        '
        'IngresarDelitoCometidoToolStripMenuItem
        '
        Me.IngresarDelitoCometidoToolStripMenuItem.Name = "IngresarDelitoCometidoToolStripMenuItem"
        Me.IngresarDelitoCometidoToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.IngresarDelitoCometidoToolStripMenuItem.Text = "Ingresar Delito cometido"
        '
        'IngresarUltimaVezVistoToolStripMenuItem
        '
        Me.IngresarUltimaVezVistoToolStripMenuItem.Name = "IngresarUltimaVezVistoToolStripMenuItem"
        Me.IngresarUltimaVezVistoToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.IngresarUltimaVezVistoToolStripMenuItem.Text = "Ingresar ultima vez visto"
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
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(105, 119)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(81, 23)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombres"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(149, 44)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(336, 29)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Módulo Ingreso de Delincuentes"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(340, 114)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(215, 29)
        Me.txtNombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apodo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 462)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbEstado.Location = New System.Drawing.Point(340, 458)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(215, 30)
        Me.cmbEstado.TabIndex = 11
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNac.Location = New System.Drawing.Point(340, 414)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(215, 29)
        Me.dtpFechaNac.TabIndex = 12
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(340, 155)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(215, 29)
        Me.txtApellido.TabIndex = 13
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(340, 194)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(215, 29)
        Me.txtRut.TabIndex = 14
        '
        'txtApodo
        '
        Me.txtApodo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApodo.Location = New System.Drawing.Point(340, 235)
        Me.txtApodo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(215, 29)
        Me.txtApodo.TabIndex = 15
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(340, 282)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(215, 29)
        Me.txtDomicilio.TabIndex = 16
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(340, 326)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(215, 29)
        Me.txtTelefono.TabIndex = 17
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(447, 492)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(108, 30)
        Me.btnRegistrar.TabIndex = 18
        Me.btnRegistrar.Text = "&Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.Label8.Location = New System.Drawing.Point(105, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Banda"
        '
        'cmbBanda
        '
        Me.cmbBanda.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(340, 370)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(215, 30)
        Me.cmbBanda.TabIndex = 20
        '
        'IngresaDelincuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 533)
        Me.Controls.Add(Me.cmbBanda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtApodo)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "IngresaDelincuente"
        Me.Text = "Ingreso de Delincuente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDelincuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarDatosDelincuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDelitoCometidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarUltimaVezVistoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMeúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtApodo As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbBanda As ComboBox
End Class
