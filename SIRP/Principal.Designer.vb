<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.Opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaInstitucion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaDelincuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.Espacio = New System.Windows.Forms.ToolStripSeparator()
        Me.DelUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelInst = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaZona = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaSector = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaDelito = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActDelincuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaBanda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rep1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPrincipal
        '
        Me.picPrincipal.Location = New System.Drawing.Point(606, 27)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(153, 137)
        Me.picPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPrincipal.TabIndex = 0
        Me.picPrincipal.TabStop = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(182, 56)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(125, 29)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'Menu
        '
        Me.Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Opciones, Me.Reportes, Me.Salir})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(800, 28)
        Me.Menu.TabIndex = 2
        Me.Menu.Text = "MenuStrip1"
        '
        'Opciones
        '
        Me.Opciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreaUser, Me.CreaInstitucion, Me.CreaZona, Me.CreaSector, Me.CreaDelito, Me.CreaControl, Me.CreaBanda, Me.CreaDelincuente, Me.ActDelincuente, Me.Espacio, Me.DelUser, Me.DelInst})
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(85, 24)
        Me.Opciones.Text = "Opciones"
        '
        'CreaUser
        '
        Me.CreaUser.Name = "CreaUser"
        Me.CreaUser.Size = New System.Drawing.Size(241, 26)
        Me.CreaUser.Text = "Crear usuario"
        Me.CreaUser.Visible = False
        '
        'CreaInstitucion
        '
        Me.CreaInstitucion.Name = "CreaInstitucion"
        Me.CreaInstitucion.Size = New System.Drawing.Size(241, 26)
        Me.CreaInstitucion.Text = "Crear institución"
        Me.CreaInstitucion.Visible = False
        '
        'CreaDelincuente
        '
        Me.CreaDelincuente.Name = "CreaDelincuente"
        Me.CreaDelincuente.Size = New System.Drawing.Size(241, 26)
        Me.CreaDelincuente.Text = "Registrar delincuente"
        Me.CreaDelincuente.Visible = False
        '
        'Espacio
        '
        Me.Espacio.Name = "Espacio"
        Me.Espacio.Size = New System.Drawing.Size(238, 6)
        Me.Espacio.Visible = False
        '
        'DelUser
        '
        Me.DelUser.Name = "DelUser"
        Me.DelUser.Size = New System.Drawing.Size(241, 26)
        Me.DelUser.Text = "Eliminar usuario"
        Me.DelUser.Visible = False
        '
        'DelInst
        '
        Me.DelInst.Name = "DelInst"
        Me.DelInst.Size = New System.Drawing.Size(241, 26)
        Me.DelInst.Text = "Eliminar institución"
        Me.DelInst.Visible = False
        '
        'Salir
        '
        Me.Salir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesion})
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(52, 24)
        Me.Salir.Text = "Salir"
        '
        'CerrarSesion
        '
        Me.CerrarSesion.Name = "CerrarSesion"
        Me.CerrarSesion.Size = New System.Drawing.Size(179, 26)
        Me.CerrarSesion.Text = "Cerrar Sesión"
        '
        'CreaZona
        '
        Me.CreaZona.Name = "CreaZona"
        Me.CreaZona.Size = New System.Drawing.Size(241, 26)
        Me.CreaZona.Text = "Crear Zona"
        Me.CreaZona.Visible = False
        '
        'CreaSector
        '
        Me.CreaSector.Name = "CreaSector"
        Me.CreaSector.Size = New System.Drawing.Size(241, 26)
        Me.CreaSector.Text = "Crear Sector"
        Me.CreaSector.Visible = False
        '
        'CreaDelito
        '
        Me.CreaDelito.Name = "CreaDelito"
        Me.CreaDelito.Size = New System.Drawing.Size(241, 26)
        Me.CreaDelito.Text = "Registrar Delito"
        Me.CreaDelito.Visible = False
        '
        'CreaControl
        '
        Me.CreaControl.Name = "CreaControl"
        Me.CreaControl.Size = New System.Drawing.Size(241, 26)
        Me.CreaControl.Text = "Registrar Control"
        Me.CreaControl.Visible = False
        '
        'ActDelincuente
        '
        Me.ActDelincuente.Name = "ActDelincuente"
        Me.ActDelincuente.Size = New System.Drawing.Size(241, 26)
        Me.ActDelincuente.Text = "Actualizar Delincuente"
        Me.ActDelincuente.Visible = False
        '
        'CreaBanda
        '
        Me.CreaBanda.Name = "CreaBanda"
        Me.CreaBanda.Size = New System.Drawing.Size(241, 26)
        Me.CreaBanda.Text = "Crear Banda"
        Me.CreaBanda.Visible = False
        '
        'Reportes
        '
        Me.Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Rep1})
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(82, 24)
        Me.Reportes.Text = "Reportes"
        Me.Reportes.Visible = False
        '
        'Rep1
        '
        Me.Rep1.Name = "Rep1"
        Me.Rep1.Size = New System.Drawing.Size(153, 26)
        Me.Rep1.Text = "Reporte1"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPrincipal As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Opciones As ToolStripMenuItem
    Friend WithEvents CreaUser As ToolStripMenuItem
    Friend WithEvents CreaInstitucion As ToolStripMenuItem
    Friend WithEvents Espacio As ToolStripSeparator
    Friend WithEvents DelUser As ToolStripMenuItem
    Friend WithEvents DelInst As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
    Friend WithEvents CerrarSesion As ToolStripMenuItem
    Friend WithEvents CreaDelincuente As ToolStripMenuItem
    Friend WithEvents CreaZona As ToolStripMenuItem
    Friend WithEvents CreaSector As ToolStripMenuItem
    Friend WithEvents CreaDelito As ToolStripMenuItem
    Friend WithEvents CreaControl As ToolStripMenuItem
    Friend WithEvents CreaBanda As ToolStripMenuItem
    Friend WithEvents ActDelincuente As ToolStripMenuItem
    Friend WithEvents Reportes As ToolStripMenuItem
    Friend WithEvents Rep1 As ToolStripMenuItem
End Class
