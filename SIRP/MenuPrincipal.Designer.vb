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
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblEliminaInstucion = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAgregaInst = New System.Windows.Forms.Label()
        Me.PanelAdmin = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.btnIngresaInst = New System.Windows.Forms.Button()
        Me.btnEliminaInst = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picChile = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblFechaActual)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 82)
        Me.Panel1.TabIndex = 0
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFechaActual.Location = New System.Drawing.Point(25, 53)
        Me.lblFechaActual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(74, 15)
        Me.lblFechaActual.TabIndex = 2
        Me.lblFechaActual.Text = "Fecha y hora"
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblBienvenido.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblBienvenido.Location = New System.Drawing.Point(22, 6)
        Me.lblBienvenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(122, 37)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "USUARIO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.Controls.Add(Me.picChile)
        Me.Panel2.Controls.Add(Me.lblInst)
        Me.Panel2.Controls.Add(Me.lblConexion)
        Me.Panel2.Controls.Add(Me.lblCargo)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Location = New System.Drawing.Point(28, 124)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 544)
        Me.Panel2.TabIndex = 1
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.ForeColor = System.Drawing.Color.Black
        Me.lblInst.Location = New System.Drawing.Point(37, 104)
        Me.lblInst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(82, 21)
        Me.lblInst.TabIndex = 4
        Me.lblInst.Text = "Institución"
        '
        'lblConexion
        '
        Me.lblConexion.AutoSize = True
        Me.lblConexion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexion.ForeColor = System.Drawing.Color.Black
        Me.lblConexion.Location = New System.Drawing.Point(37, 179)
        Me.lblConexion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(122, 21)
        Me.lblConexion.TabIndex = 3
        Me.lblConexion.Text = "Ultima conexión"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.Color.Black
        Me.lblCargo.Location = New System.Drawing.Point(37, 139)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(52, 21)
        Me.lblCargo.TabIndex = 2
        Me.lblCargo.Text = "Cargo"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(24, 40)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(132, 37)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Mis datos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblEliminaInstucion)
        Me.Panel3.Controls.Add(Me.btnEliminaInst)
        Me.Panel3.Location = New System.Drawing.Point(280, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 269)
        Me.Panel3.TabIndex = 2
        '
        'lblEliminaInstucion
        '
        Me.lblEliminaInstucion.AutoSize = True
        Me.lblEliminaInstucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblEliminaInstucion.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblEliminaInstucion.ForeColor = System.Drawing.Color.White
        Me.lblEliminaInstucion.Location = New System.Drawing.Point(81, 47)
        Me.lblEliminaInstucion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEliminaInstucion.Name = "lblEliminaInstucion"
        Me.lblEliminaInstucion.Size = New System.Drawing.Size(112, 19)
        Me.lblEliminaInstucion.TabIndex = 2
        Me.lblEliminaInstucion.Text = "Elimina Institución"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblAgregaInst)
        Me.Panel4.Controls.Add(Me.btnIngresaInst)
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(274, 269)
        Me.Panel4.TabIndex = 3
        '
        'lblAgregaInst
        '
        Me.lblAgregaInst.AutoSize = True
        Me.lblAgregaInst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAgregaInst.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblAgregaInst.ForeColor = System.Drawing.Color.White
        Me.lblAgregaInst.Location = New System.Drawing.Point(76, 47)
        Me.lblAgregaInst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAgregaInst.Name = "lblAgregaInst"
        Me.lblAgregaInst.Size = New System.Drawing.Size(119, 19)
        Me.lblAgregaInst.TabIndex = 1
        Me.lblAgregaInst.Text = "Agregar Institución"
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.Black
        Me.PanelAdmin.Controls.Add(Me.Panel4)
        Me.PanelAdmin.Controls.Add(Me.Panel3)
        Me.PanelAdmin.Controls.Add(Me.Panel6)
        Me.PanelAdmin.Controls.Add(Me.Panel7)
        Me.PanelAdmin.Location = New System.Drawing.Point(461, 124)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(546, 544)
        Me.PanelAdmin.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Location = New System.Drawing.Point(2, 275)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(274, 269)
        Me.Panel6.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Location = New System.Drawing.Point(280, 275)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(262, 269)
        Me.Panel7.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 704)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1249, 22)
        Me.StatusStrip1.TabIndex = 6
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel1.Text = "SIRP S.A."
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elimina Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agregar Usuario"
        '
        'picPrincipal
        '
        Me.picPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.picPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrincipal.Location = New System.Drawing.Point(1070, 127)
        Me.picPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(150, 162)
        Me.picPrincipal.TabIndex = 5
        Me.picPrincipal.TabStop = False
        '
        'btnIngresaInst
        '
        Me.btnIngresaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.agregaInstitucion2
        Me.btnIngresaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnIngresaInst.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnIngresaInst.FlatAppearance.BorderSize = 3
        Me.btnIngresaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIngresaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.Location = New System.Drawing.Point(73, 78)
        Me.btnIngresaInst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresaInst.Name = "btnIngresaInst"
        Me.btnIngresaInst.Size = New System.Drawing.Size(121, 121)
        Me.btnIngresaInst.TabIndex = 0
        Me.btnIngresaInst.UseVisualStyleBackColor = False
        '
        'btnEliminaInst
        '
        Me.btnEliminaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.eliminaInstitucion1
        Me.btnEliminaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEliminaInst.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEliminaInst.FlatAppearance.BorderSize = 3
        Me.btnEliminaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEliminaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminaInst.Location = New System.Drawing.Point(77, 78)
        Me.btnEliminaInst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminaInst.Name = "btnEliminaInst"
        Me.btnEliminaInst.Size = New System.Drawing.Size(121, 121)
        Me.btnEliminaInst.TabIndex = 2
        Me.btnEliminaInst.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.SIRP.My.Resources.Resources.agregaUser
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(76, 80)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 121)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.SIRP.My.Resources.Resources.eliminaUser
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(71, 80)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 121)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'picChile
        '
        Me.picChile.BackColor = System.Drawing.Color.Black
        Me.picChile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picChile.Image = Global.SIRP.My.Resources.Resources.chile
        Me.picChile.Location = New System.Drawing.Point(49, 235)
        Me.picChile.Margin = New System.Windows.Forms.Padding(2)
        Me.picChile.Name = "picChile"
        Me.picChile.Size = New System.Drawing.Size(280, 284)
        Me.picChile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChile.TabIndex = 5
        Me.picChile.TabStop = False
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
        Me.Button1.Location = New System.Drawing.Point(1157, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1249, 726)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelAdmin.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelAdmin As FlowLayoutPanel
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
    Friend WithEvents lblEliminaInstucion As Label
    Friend WithEvents btnEliminaInst As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
