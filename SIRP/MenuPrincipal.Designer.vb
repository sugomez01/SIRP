<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picChile = New System.Windows.Forms.PictureBox()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAgregaInst = New System.Windows.Forms.Label()
        Me.btnIngresaInst = New System.Windows.Forms.Button()
        Me.PanelAdmin = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picChile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblFechaActual)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1969, 101)
        Me.Panel1.TabIndex = 0
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFechaActual.Location = New System.Drawing.Point(33, 65)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(92, 20)
        Me.lblFechaActual.TabIndex = 2
        Me.lblFechaActual.Text = "Fecha y hora"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.SIRP.My.Resources.Resources.cerrarSesion
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1848, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 74)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblBienvenido.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblBienvenido.Location = New System.Drawing.Point(29, 8)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(154, 46)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "USUARIO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.picChile)
        Me.Panel2.Controls.Add(Me.lblInst)
        Me.Panel2.Controls.Add(Me.lblConexion)
        Me.Panel2.Controls.Add(Me.lblCargo)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Location = New System.Drawing.Point(70, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 669)
        Me.Panel2.TabIndex = 1
        '
        'picChile
        '
        Me.picChile.BackColor = System.Drawing.Color.Black
        Me.picChile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picChile.Image = Global.SIRP.My.Resources.Resources.chile
        Me.picChile.Location = New System.Drawing.Point(65, 289)
        Me.picChile.Name = "picChile"
        Me.picChile.Size = New System.Drawing.Size(374, 349)
        Me.picChile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChile.TabIndex = 5
        Me.picChile.TabStop = False
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblInst.Location = New System.Drawing.Point(49, 128)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(103, 28)
        Me.lblInst.TabIndex = 4
        Me.lblInst.Text = "Institución"
        '
        'lblConexion
        '
        Me.lblConexion.AutoSize = True
        Me.lblConexion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblConexion.Location = New System.Drawing.Point(49, 220)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(154, 28)
        Me.lblConexion.TabIndex = 3
        Me.lblConexion.Text = "Ultima conexión"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblCargo.Location = New System.Drawing.Point(49, 171)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(65, 28)
        Me.lblCargo.TabIndex = 2
        Me.lblCargo.Text = "Cargo"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitulo.Location = New System.Drawing.Point(32, 49)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(136, 38)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Mis datos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Location = New System.Drawing.Point(375, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 305)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel4.Controls.Add(Me.lblAgregaInst)
        Me.Panel4.Controls.Add(Me.btnIngresaInst)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 305)
        Me.Panel4.TabIndex = 3
        '
        'lblAgregaInst
        '
        Me.lblAgregaInst.AutoSize = True
        Me.lblAgregaInst.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblAgregaInst.Location = New System.Drawing.Point(102, 58)
        Me.lblAgregaInst.Name = "lblAgregaInst"
        Me.lblAgregaInst.Size = New System.Drawing.Size(147, 23)
        Me.lblAgregaInst.TabIndex = 1
        Me.lblAgregaInst.Text = "Agregar Institución"
        '
        'btnIngresaInst
        '
        Me.btnIngresaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.ins
        Me.btnIngresaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnIngresaInst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIngresaInst.FlatAppearance.BorderSize = 3
        Me.btnIngresaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.Location = New System.Drawing.Point(97, 96)
        Me.btnIngresaInst.Name = "btnIngresaInst"
        Me.btnIngresaInst.Size = New System.Drawing.Size(161, 149)
        Me.btnIngresaInst.TabIndex = 0
        Me.btnIngresaInst.UseVisualStyleBackColor = False
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.Black
        Me.PanelAdmin.Controls.Add(Me.Panel4)
        Me.PanelAdmin.Controls.Add(Me.Panel3)
        Me.PanelAdmin.Controls.Add(Me.Panel5)
        Me.PanelAdmin.Controls.Add(Me.Panel6)
        Me.PanelAdmin.Controls.Add(Me.Panel7)
        Me.PanelAdmin.Location = New System.Drawing.Point(666, 153)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(728, 669)
        Me.PanelAdmin.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SlateGray
        Me.Panel5.Location = New System.Drawing.Point(3, 314)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(722, 38)
        Me.Panel5.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Location = New System.Drawing.Point(3, 358)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(366, 308)
        Me.Panel6.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Location = New System.Drawing.Point(375, 358)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(350, 308)
        Me.Panel7.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 885)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1970, 26)
        Me.StatusStrip1.TabIndex = 6
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripStatusLabel1.Text = "SIRP S.A."
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'picPrincipal
        '
        Me.picPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.picPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrincipal.Location = New System.Drawing.Point(1577, 153)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(355, 325)
        Me.picPrincipal.TabIndex = 5
        Me.picPrincipal.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1970, 911)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picChile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelAdmin.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelAdmin As FlowLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents picPrincipal As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents picChile As PictureBox
    Friend WithEvents lblInst As Label
    Friend WithEvents lblConexion As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnIngresaInst As Button
    Friend WithEvents lblAgregaInst As Label
End Class
