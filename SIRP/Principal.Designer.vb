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
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.Opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaInstitucion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaZona = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaSector = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaDelito = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaBanda = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaDelincuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActDelincuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.Espacio = New System.Windows.Forms.ToolStripSeparator()
        Me.DelUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelInst = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rep1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.Menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(16, 17)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(125, 29)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido"
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Opciones, Me.Reportes, Me.Salir})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.MaximumSize = New System.Drawing.Size(0, 100)
        Me.Menu.MinimumSize = New System.Drawing.Size(0, 80)
        Me.Menu.Name = "Menu"
        Me.Menu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.Menu.Size = New System.Drawing.Size(1540, 80)
        Me.Menu.Stretch = False
        Me.Menu.TabIndex = 2
        Me.Menu.Text = "MenuStrip122"
        '
        'Opciones
        '
        Me.Opciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreaUser, Me.CreaInstitucion, Me.CreaZona, Me.CreaSector, Me.CreaDelito, Me.CreaControl, Me.CreaBanda, Me.CreaDelincuente, Me.ActDelincuente, Me.Espacio, Me.DelUser, Me.DelInst})
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(92, 76)
        Me.Opciones.Text = "Opciones"
        '
        'CreaUser
        '
        Me.CreaUser.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaUser.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaUser.Name = "CreaUser"
        Me.CreaUser.Size = New System.Drawing.Size(266, 28)
        Me.CreaUser.Text = "Crear usuario"
        Me.CreaUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaUser.Visible = False
        '
        'CreaInstitucion
        '
        Me.CreaInstitucion.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaInstitucion.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaInstitucion.Name = "CreaInstitucion"
        Me.CreaInstitucion.Size = New System.Drawing.Size(266, 28)
        Me.CreaInstitucion.Text = "Crear institución"
        Me.CreaInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaInstitucion.Visible = False
        '
        'CreaZona
        '
        Me.CreaZona.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaZona.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaZona.Name = "CreaZona"
        Me.CreaZona.Size = New System.Drawing.Size(266, 28)
        Me.CreaZona.Text = "Crear Zona"
        Me.CreaZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaZona.Visible = False
        '
        'CreaSector
        '
        Me.CreaSector.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaSector.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaSector.Name = "CreaSector"
        Me.CreaSector.Size = New System.Drawing.Size(266, 28)
        Me.CreaSector.Text = "Crear Sector"
        Me.CreaSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaSector.Visible = False
        '
        'CreaDelito
        '
        Me.CreaDelito.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaDelito.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaDelito.Name = "CreaDelito"
        Me.CreaDelito.Size = New System.Drawing.Size(266, 28)
        Me.CreaDelito.Text = "Registrar Delito"
        Me.CreaDelito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaDelito.Visible = False
        '
        'CreaControl
        '
        Me.CreaControl.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaControl.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaControl.Name = "CreaControl"
        Me.CreaControl.Size = New System.Drawing.Size(266, 28)
        Me.CreaControl.Text = "Registrar Control"
        Me.CreaControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaControl.Visible = False
        '
        'CreaBanda
        '
        Me.CreaBanda.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaBanda.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaBanda.Name = "CreaBanda"
        Me.CreaBanda.Size = New System.Drawing.Size(266, 28)
        Me.CreaBanda.Text = "Crear Banda"
        Me.CreaBanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaBanda.Visible = False
        '
        'CreaDelincuente
        '
        Me.CreaDelincuente.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreaDelincuente.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CreaDelincuente.Name = "CreaDelincuente"
        Me.CreaDelincuente.Size = New System.Drawing.Size(266, 28)
        Me.CreaDelincuente.Text = "Registrar delincuente"
        Me.CreaDelincuente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreaDelincuente.Visible = False
        '
        'ActDelincuente
        '
        Me.ActDelincuente.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActDelincuente.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ActDelincuente.Name = "ActDelincuente"
        Me.ActDelincuente.Size = New System.Drawing.Size(266, 28)
        Me.ActDelincuente.Text = "Actualizar Delincuente"
        Me.ActDelincuente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActDelincuente.Visible = False
        '
        'Espacio
        '
        Me.Espacio.Name = "Espacio"
        Me.Espacio.Size = New System.Drawing.Size(263, 6)
        Me.Espacio.Visible = False
        '
        'DelUser
        '
        Me.DelUser.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelUser.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.DelUser.Name = "DelUser"
        Me.DelUser.Size = New System.Drawing.Size(266, 28)
        Me.DelUser.Text = "Eliminar usuario"
        Me.DelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelUser.Visible = False
        '
        'DelInst
        '
        Me.DelInst.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelInst.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.DelInst.Name = "DelInst"
        Me.DelInst.Size = New System.Drawing.Size(266, 28)
        Me.DelInst.Text = "Eliminar institución"
        Me.DelInst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelInst.Visible = False
        '
        'Reportes
        '
        Me.Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Rep1})
        Me.Reportes.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(91, 76)
        Me.Reportes.Text = "Reportes"
        Me.Reportes.Visible = False
        '
        'Rep1
        '
        Me.Rep1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Rep1.Name = "Rep1"
        Me.Rep1.Size = New System.Drawing.Size(162, 28)
        Me.Rep1.Text = "Reporte1"
        Me.Rep1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Salir
        '
        Me.Salir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesion})
        Me.Salir.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(58, 76)
        Me.Salir.Text = "Salir"
        '
        'CerrarSesion
        '
        Me.CerrarSesion.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.CerrarSesion.Name = "CerrarSesion"
        Me.CerrarSesion.Size = New System.Drawing.Size(224, 28)
        Me.CerrarSesion.Text = "Cerrar Sesión"
        Me.CerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(25, 149)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 568)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ultima conexión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cargo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Institución"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label6"
        '
        'picPrincipal
        '
        Me.picPrincipal.Location = New System.Drawing.Point(589, 149)
        Me.picPrincipal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(709, 568)
        Me.picPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPrincipal.TabIndex = 0
        Me.picPrincipal.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1540, 779)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
