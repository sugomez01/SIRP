<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoUsuario))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarInstituciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSisemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtNomb = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmbIns = New System.Windows.Forms.ComboBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.btnIngresa = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(226, 41)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(290, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Módulo Ingreso Usuario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarInstituciónToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'IngresarInstituciónToolStripMenuItem
        '
        Me.IngresarInstituciónToolStripMenuItem.Name = "IngresarInstituciónToolStripMenuItem"
        Me.IngresarInstituciónToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.IngresarInstituciónToolStripMenuItem.Text = "Ingresar Institución"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenúPrincipalToolStripMenuItem, Me.SalirDelSisemaToolStripMenuItem})
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'VolverAlMenúPrincipalToolStripMenuItem
        '
        Me.VolverAlMenúPrincipalToolStripMenuItem.Name = "VolverAlMenúPrincipalToolStripMenuItem"
        Me.VolverAlMenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.VolverAlMenúPrincipalToolStripMenuItem.Text = "Volver al Menú Principal"
        '
        'SalirDelSisemaToolStripMenuItem
        '
        Me.SalirDelSisemaToolStripMenuItem.Name = "SalirDelSisemaToolStripMenuItem"
        Me.SalirDelSisemaToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.SalirDelSisemaToolStripMenuItem.Text = "Salir del Sisema"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(125, 129)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(81, 23)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombres"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(125, 175)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(80, 23)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "Apellidos"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(125, 225)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(41, 23)
        Me.lblRut.TabIndex = 4
        Me.lblRut.Text = "RUT"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(125, 274)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(158, 23)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Nombre de usuario"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(125, 319)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(98, 23)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "Contraseña"
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.Location = New System.Drawing.Point(125, 375)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(93, 23)
        Me.lblInst.TabIndex = 7
        Me.lblInst.Text = "Institución"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(125, 429)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(128, 23)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Tipo de usuario"
        '
        'txtNomb
        '
        Me.txtNomb.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomb.Location = New System.Drawing.Point(305, 122)
        Me.txtNomb.Name = "txtNomb"
        Me.txtNomb.Size = New System.Drawing.Size(313, 29)
        Me.txtNomb.TabIndex = 9
        '
        'txtApe
        '
        Me.txtApe.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe.Location = New System.Drawing.Point(305, 168)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(313, 29)
        Me.txtApe.TabIndex = 10
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(305, 218)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(313, 29)
        Me.txtRut.TabIndex = 11
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(305, 267)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(313, 29)
        Me.txtUser.TabIndex = 12
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(305, 312)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(313, 29)
        Me.txtPass.TabIndex = 13
        '
        'cmbIns
        '
        Me.cmbIns.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIns.FormattingEnabled = True
        Me.cmbIns.Location = New System.Drawing.Point(305, 368)
        Me.cmbIns.Name = "cmbIns"
        Me.cmbIns.Size = New System.Drawing.Size(313, 30)
        Me.cmbIns.TabIndex = 14
        '
        'cmbTipo
        '
        Me.cmbTipo.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(305, 422)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(313, 30)
        Me.cmbTipo.TabIndex = 15
        '
        'btnIngresa
        '
        Me.btnIngresa.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIngresa.Location = New System.Drawing.Point(515, 510)
        Me.btnIngresa.Name = "btnIngresa"
        Me.btnIngresa.Size = New System.Drawing.Size(165, 31)
        Me.btnIngresa.TabIndex = 16
        Me.btnIngresa.Text = "&Ingresar Registro"
        Me.btnIngresa.UseVisualStyleBackColor = True
        '
        'IngresoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 567)
        Me.Controls.Add(Me.btnIngresa)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.cmbIns)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.txtNomb)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IngresoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Usuario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarInstituciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSisemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblInst As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtNomb As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbIns As ComboBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents btnIngresa As Button
End Class
