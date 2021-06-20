<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuJefe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuJefe))
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
        Me.PanelAdmin = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAgregaInst = New System.Windows.Forms.Label()
        Me.btnIngresaInst = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminaInst = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblEliminaInstucion = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picChile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdmin.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblFechaActual)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 82)
        Me.Panel1.TabIndex = 1
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
        Me.Panel2.Location = New System.Drawing.Point(29, 124)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 544)
        Me.Panel2.TabIndex = 2
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
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.Black
        Me.PanelAdmin.Controls.Add(Me.Panel4)
        Me.PanelAdmin.Controls.Add(Me.Panel3)
        Me.PanelAdmin.Controls.Add(Me.Panel5)
        Me.PanelAdmin.Controls.Add(Me.Panel9)
        Me.PanelAdmin.Controls.Add(Me.Panel7)
        Me.PanelAdmin.Controls.Add(Me.Panel8)
        Me.PanelAdmin.Location = New System.Drawing.Point(452, 124)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(601, 544)
        Me.PanelAdmin.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblAgregaInst)
        Me.Panel4.Controls.Add(Me.btnIngresaInst)
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(207, 265)
        Me.Panel4.TabIndex = 3
        '
        'lblAgregaInst
        '
        Me.lblAgregaInst.AutoSize = True
        Me.lblAgregaInst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAgregaInst.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblAgregaInst.ForeColor = System.Drawing.Color.Black
        Me.lblAgregaInst.Location = New System.Drawing.Point(53, 47)
        Me.lblAgregaInst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAgregaInst.Name = "lblAgregaInst"
        Me.lblAgregaInst.Size = New System.Drawing.Size(97, 19)
        Me.lblAgregaInst.TabIndex = 1
        Me.lblAgregaInst.Text = "Agregar sector"
        '
        'btnIngresaInst
        '
        Me.btnIngresaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.sector
        Me.btnIngresaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnIngresaInst.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnIngresaInst.FlatAppearance.BorderSize = 3
        Me.btnIngresaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnIngresaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.Location = New System.Drawing.Point(42, 100)
        Me.btnIngresaInst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresaInst.Name = "btnIngresaInst"
        Me.btnIngresaInst.Size = New System.Drawing.Size(121, 121)
        Me.btnIngresaInst.TabIndex = 0
        Me.btnIngresaInst.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnEliminaInst)
        Me.Panel3.Location = New System.Drawing.Point(213, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(186, 265)
        Me.Panel3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Registrar banda"
        '
        'btnEliminaInst
        '
        Me.btnEliminaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.banda
        Me.btnEliminaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEliminaInst.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEliminaInst.FlatAppearance.BorderSize = 3
        Me.btnEliminaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEliminaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminaInst.Location = New System.Drawing.Point(35, 102)
        Me.btnEliminaInst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminaInst.Name = "btnEliminaInst"
        Me.btnEliminaInst.Size = New System.Drawing.Size(121, 121)
        Me.btnEliminaInst.TabIndex = 2
        Me.btnEliminaInst.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Location = New System.Drawing.Point(403, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(196, 265)
        Me.Panel5.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registrar delincuente"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.SIRP.My.Resources.Resources.delincuente
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(41, 100)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 121)
        Me.Button4.TabIndex = 0
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel9.Controls.Add(Me.lblEliminaInstucion)
        Me.Panel9.Controls.Add(Me.Button6)
        Me.Panel9.Location = New System.Drawing.Point(2, 271)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(207, 269)
        Me.Panel9.TabIndex = 7
        '
        'lblEliminaInstucion
        '
        Me.lblEliminaInstucion.AutoSize = True
        Me.lblEliminaInstucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblEliminaInstucion.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblEliminaInstucion.ForeColor = System.Drawing.Color.Black
        Me.lblEliminaInstucion.Location = New System.Drawing.Point(28, 45)
        Me.lblEliminaInstucion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEliminaInstucion.Name = "lblEliminaInstucion"
        Me.lblEliminaInstucion.Size = New System.Drawing.Size(158, 19)
        Me.lblEliminaInstucion.TabIndex = 2
        Me.lblEliminaInstucion.Text = "Registrar delito cometido"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.SIRP.My.Resources.Resources.delito
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(42, 89)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 121)
        Me.Button6.TabIndex = 4
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Location = New System.Drawing.Point(213, 271)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(186, 269)
        Me.Panel7.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Registrar control"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.SIRP.My.Resources.Resources.control
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(33, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 121)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.Button5)
        Me.Panel8.Location = New System.Drawing.Point(403, 271)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(196, 269)
        Me.Panel8.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(65, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Reportes"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.SIRP.My.Resources.Resources.reporte
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button5.FlatAppearance.BorderSize = 3
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(41, 89)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 121)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'picPrincipal
        '
        Me.picPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.picPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrincipal.Location = New System.Drawing.Point(1069, 127)
        Me.picPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(150, 162)
        Me.picPrincipal.TabIndex = 6
        Me.picPrincipal.TabStop = False
        '
        'MenuJefe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1233, 687)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuJefe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuJefe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picChile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdmin.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picChile As PictureBox
    Friend WithEvents lblInst As Label
    Friend WithEvents lblConexion As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents picPrincipal As PictureBox
    Friend WithEvents PanelAdmin As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAgregaInst As Label
    Friend WithEvents btnIngresaInst As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblEliminaInstucion As Label
    Friend WithEvents btnEliminaInst As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
End Class
