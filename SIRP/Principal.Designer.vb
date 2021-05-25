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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearInstituciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarInstituciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarDelincuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.lblBienvenido.Location = New System.Drawing.Point(216, 54)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(78, 17)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem, Me.CrearInstituciónToolStripMenuItem, Me.ToolStripSeparator1, Me.EliminarUsuarioToolStripMenuItem, Me.EliminarInstituciónToolStripMenuItem, Me.RegistrarDelincuenteToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.CrearUsuarioToolStripMenuItem.Text = "Crear usuario"
        '
        'CrearInstituciónToolStripMenuItem
        '
        Me.CrearInstituciónToolStripMenuItem.Name = "CrearInstituciónToolStripMenuItem"
        Me.CrearInstituciónToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.CrearInstituciónToolStripMenuItem.Text = "Crear institución"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(229, 6)
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario"
        '
        'EliminarInstituciónToolStripMenuItem
        '
        Me.EliminarInstituciónToolStripMenuItem.Name = "EliminarInstituciónToolStripMenuItem"
        Me.EliminarInstituciónToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.EliminarInstituciónToolStripMenuItem.Text = "Eliminar institución"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'RegistrarDelincuenteToolStripMenuItem
        '
        Me.RegistrarDelincuenteToolStripMenuItem.Name = "RegistrarDelincuenteToolStripMenuItem"
        Me.RegistrarDelincuenteToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.RegistrarDelincuenteToolStripMenuItem.Text = "Registrar delincuente"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPrincipal As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearInstituciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EliminarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarInstituciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarDelincuenteToolStripMenuItem As ToolStripMenuItem
End Class
