<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoDelito
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
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblDelito = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.lblBanda = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.cmbDelito = New System.Windows.Forms.ComboBox()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.cmbSector = New System.Windows.Forms.ComboBox()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbBanda = New System.Windows.Forms.ComboBox()
        Me.lblObserv = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(158, 114)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(30, 13)
        Me.lblRut.TabIndex = 0
        Me.lblRut.Text = "RUT"
        '
        'lblDelito
        '
        Me.lblDelito.AutoSize = True
        Me.lblDelito.Location = New System.Drawing.Point(158, 175)
        Me.lblDelito.Name = "lblDelito"
        Me.lblDelito.Size = New System.Drawing.Size(34, 13)
        Me.lblDelito.TabIndex = 1
        Me.lblDelito.Text = "Delito"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(158, 236)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Location = New System.Drawing.Point(444, 114)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(32, 13)
        Me.lblZona.TabIndex = 3
        Me.lblZona.Text = "Zona"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Location = New System.Drawing.Point(444, 238)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(41, 13)
        Me.lblSector.TabIndex = 4
        Me.lblSector.Text = "Sector "
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Location = New System.Drawing.Point(444, 175)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(46, 13)
        Me.lblComuna.TabIndex = 5
        Me.lblComuna.Text = "Comuna"
        '
        'lblBanda
        '
        Me.lblBanda.AutoSize = True
        Me.lblBanda.Location = New System.Drawing.Point(158, 303)
        Me.lblBanda.Name = "lblBanda"
        Me.lblBanda.Size = New System.Drawing.Size(38, 13)
        Me.lblBanda.TabIndex = 6
        Me.lblBanda.Text = "Banda"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(161, 140)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(159, 20)
        Me.txtRut.TabIndex = 7
        '
        'cmbDelito
        '
        Me.cmbDelito.FormattingEnabled = True
        Me.cmbDelito.Location = New System.Drawing.Point(161, 201)
        Me.cmbDelito.Name = "cmbDelito"
        Me.cmbDelito.Size = New System.Drawing.Size(159, 21)
        Me.cmbDelito.TabIndex = 8
        '
        'cmbZona
        '
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(447, 140)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(159, 21)
        Me.cmbZona.TabIndex = 9
        '
        'cmbComuna
        '
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(447, 201)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(159, 21)
        Me.cmbComuna.TabIndex = 10
        '
        'cmbSector
        '
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(447, 265)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(159, 21)
        Me.cmbSector.TabIndex = 11
        '
        'txtObserv
        '
        Me.txtObserv.Location = New System.Drawing.Point(161, 395)
        Me.txtObserv.Multiline = True
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(455, 55)
        Me.txtObserv.TabIndex = 12
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(161, 266)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(159, 20)
        Me.dtpFecha.TabIndex = 13
        '
        'cmbBanda
        '
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(161, 329)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(159, 21)
        Me.cmbBanda.TabIndex = 14
        '
        'lblObserv
        '
        Me.lblObserv.AutoSize = True
        Me.lblObserv.Location = New System.Drawing.Point(158, 369)
        Me.lblObserv.Name = "lblObserv"
        Me.lblObserv.Size = New System.Drawing.Size(78, 13)
        Me.lblObserv.TabIndex = 15
        Me.lblObserv.Text = "Observaciones"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(529, 475)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 16
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(229, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(255, 24)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Modulo Ingreso de Delitos"
        '
        'frmIngresoDelito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 519)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.lblObserv)
        Me.Controls.Add(Me.cmbBanda)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtObserv)
        Me.Controls.Add(Me.cmbSector)
        Me.Controls.Add(Me.cmbComuna)
        Me.Controls.Add(Me.cmbZona)
        Me.Controls.Add(Me.cmbDelito)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.lblBanda)
        Me.Controls.Add(Me.lblComuna)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblDelito)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIngresoDelito"
        Me.Text = "Ingreso Delito"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRut As Label
    Friend WithEvents lblDelito As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblZona As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents lblComuna As Label
    Friend WithEvents lblBanda As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents cmbDelito As ComboBox
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents cmbSector As ComboBox
    Friend WithEvents txtObserv As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmbBanda As ComboBox
    Friend WithEvents lblObserv As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitulo As Label
End Class
