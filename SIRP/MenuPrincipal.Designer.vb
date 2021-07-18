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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.PanelDelIns = New System.Windows.Forms.Panel()
        Me.lblEliminaInstucion = New System.Windows.Forms.Label()
        Me.btnEliminaInst = New System.Windows.Forms.Button()
        Me.PanelAddIns = New System.Windows.Forms.Panel()
        Me.lblAgregaInst = New System.Windows.Forms.Label()
        Me.btnIngresaInst = New System.Windows.Forms.Button()
        Me.PanelAdmin = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelAddUser = New System.Windows.Forms.Panel()
        Me.lblAddUser = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.PanelDelUser = New System.Windows.Forms.Panel()
        Me.btnDelUser = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.StatusStrip()
        Me.MenuBarDetail = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelOperador = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelDelincuente = New System.Windows.Forms.Panel()
        Me.lblDelincuente = New System.Windows.Forms.Label()
        Me.btnDelincuente = New System.Windows.Forms.Button()
        Me.PanelDelito = New System.Windows.Forms.Panel()
        Me.lblDelito = New System.Windows.Forms.Label()
        Me.btnDelito = New System.Windows.Forms.Button()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.lblControl = New System.Windows.Forms.Label()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.PanelActualiza = New System.Windows.Forms.Panel()
        Me.lblActualiza = New System.Windows.Forms.Label()
        Me.btnActualizaDelincuente = New System.Windows.Forms.Button()
        Me.PanelSector = New System.Windows.Forms.Panel()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.btnSector = New System.Windows.Forms.Button()
        Me.PanelBanda = New System.Windows.Forms.Panel()
        Me.lblBanda = New System.Windows.Forms.Label()
        Me.btnBanda = New System.Windows.Forms.Button()
        Me.PanelRepo = New System.Windows.Forms.Panel()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelJefeZona = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelReporte = New System.Windows.Forms.Panel()
        Me.lblDelUser = New System.Windows.Forms.Label()
        Me.PanelBarra.SuspendLayout()
        Me.PanelDelIns.SuspendLayout()
        Me.PanelAddIns.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.PanelAddUser.SuspendLayout()
        Me.PanelDelUser.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.PanelOperador.SuspendLayout()
        Me.PanelDelincuente.SuspendLayout()
        Me.PanelDelito.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.PanelActualiza.SuspendLayout()
        Me.PanelSector.SuspendLayout()
        Me.PanelBanda.SuspendLayout()
        Me.PanelRepo.SuspendLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatos.SuspendLayout()
        Me.PanelJefeZona.SuspendLayout()
        Me.PanelReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarra
        '
        Me.PanelBarra.BackColor = System.Drawing.Color.White
        Me.PanelBarra.Controls.Add(Me.lblFechaActual)
        Me.PanelBarra.Controls.Add(Me.btnSalir)
        Me.PanelBarra.Controls.Add(Me.lblBienvenido)
        Me.PanelBarra.Location = New System.Drawing.Point(1, 1)
        Me.PanelBarra.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(1306, 82)
        Me.PanelBarra.TabIndex = 0
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
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = Global.SIRP.My.Resources.Resources.cerrarSesion
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSalir.Location = New System.Drawing.Point(1233, 10)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(62, 60)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.UseVisualStyleBackColor = False
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
        'PanelDelIns
        '
        Me.PanelDelIns.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelDelIns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDelIns.Controls.Add(Me.lblEliminaInstucion)
        Me.PanelDelIns.Controls.Add(Me.btnEliminaInst)
        Me.PanelDelIns.Location = New System.Drawing.Point(280, 275)
        Me.PanelDelIns.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDelIns.Name = "PanelDelIns"
        Me.PanelDelIns.Size = New System.Drawing.Size(262, 269)
        Me.PanelDelIns.TabIndex = 2
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
        'btnEliminaInst
        '
        Me.btnEliminaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.eliminaInstitucion1
        Me.btnEliminaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEliminaInst.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEliminaInst.FlatAppearance.BorderSize = 3
        Me.btnEliminaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEliminaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminaInst.Location = New System.Drawing.Point(77, 78)
        Me.btnEliminaInst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminaInst.Name = "btnEliminaInst"
        Me.btnEliminaInst.Size = New System.Drawing.Size(121, 121)
        Me.btnEliminaInst.TabIndex = 1
        Me.btnEliminaInst.UseVisualStyleBackColor = False
        '
        'PanelAddIns
        '
        Me.PanelAddIns.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelAddIns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelAddIns.Controls.Add(Me.lblAgregaInst)
        Me.PanelAddIns.Controls.Add(Me.btnIngresaInst)
        Me.PanelAddIns.Location = New System.Drawing.Point(2, 275)
        Me.PanelAddIns.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAddIns.Name = "PanelAddIns"
        Me.PanelAddIns.Size = New System.Drawing.Size(274, 269)
        Me.PanelAddIns.TabIndex = 3
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
        'btnIngresaInst
        '
        Me.btnIngresaInst.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.BackgroundImage = Global.SIRP.My.Resources.Resources.agregaInstitucion2
        Me.btnIngresaInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresaInst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresaInst.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnIngresaInst.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnIngresaInst.FlatAppearance.BorderSize = 3
        Me.btnIngresaInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnIngresaInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresaInst.ForeColor = System.Drawing.Color.Transparent
        Me.btnIngresaInst.Location = New System.Drawing.Point(73, 78)
        Me.btnIngresaInst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresaInst.Name = "btnIngresaInst"
        Me.btnIngresaInst.Size = New System.Drawing.Size(121, 121)
        Me.btnIngresaInst.TabIndex = 0
        Me.btnIngresaInst.UseVisualStyleBackColor = False
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.Silver
        Me.PanelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdmin.Controls.Add(Me.PanelAddUser)
        Me.PanelAdmin.Controls.Add(Me.PanelDelUser)
        Me.PanelAdmin.Controls.Add(Me.PanelAddIns)
        Me.PanelAdmin.Controls.Add(Me.PanelDelIns)
        Me.PanelAdmin.Location = New System.Drawing.Point(461, 124)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(546, 549)
        Me.PanelAdmin.TabIndex = 4
        '
        'PanelAddUser
        '
        Me.PanelAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelAddUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelAddUser.Controls.Add(Me.lblAddUser)
        Me.PanelAddUser.Controls.Add(Me.btnAddUser)
        Me.PanelAddUser.Location = New System.Drawing.Point(2, 2)
        Me.PanelAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAddUser.Name = "PanelAddUser"
        Me.PanelAddUser.Size = New System.Drawing.Size(274, 269)
        Me.PanelAddUser.TabIndex = 5
        '
        'lblAddUser
        '
        Me.lblAddUser.AutoSize = True
        Me.lblAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAddUser.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblAddUser.ForeColor = System.Drawing.Color.White
        Me.lblAddUser.Location = New System.Drawing.Point(79, 49)
        Me.lblAddUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddUser.Name = "lblAddUser"
        Me.lblAddUser.Size = New System.Drawing.Size(106, 19)
        Me.lblAddUser.TabIndex = 3
        Me.lblAddUser.Text = "Agregar Usuario"
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Transparent
        Me.btnAddUser.BackgroundImage = Global.SIRP.My.Resources.Resources.agregaUser
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAddUser.FlatAppearance.BorderSize = 3
        Me.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddUser.Location = New System.Drawing.Point(76, 80)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(121, 121)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'PanelDelUser
        '
        Me.PanelDelUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelDelUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDelUser.Controls.Add(Me.lblDelUser)
        Me.PanelDelUser.Controls.Add(Me.btnDelUser)
        Me.PanelDelUser.Location = New System.Drawing.Point(280, 2)
        Me.PanelDelUser.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDelUser.Name = "PanelDelUser"
        Me.PanelDelUser.Size = New System.Drawing.Size(262, 269)
        Me.PanelDelUser.TabIndex = 6
        '
        'btnDelUser
        '
        Me.btnDelUser.BackColor = System.Drawing.Color.Transparent
        Me.btnDelUser.BackgroundImage = Global.SIRP.My.Resources.Resources.eliminaUser
        Me.btnDelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelUser.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDelUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnDelUser.FlatAppearance.BorderSize = 3
        Me.btnDelUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelUser.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelUser.Location = New System.Drawing.Point(71, 80)
        Me.btnDelUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelUser.Name = "btnDelUser"
        Me.btnDelUser.Size = New System.Drawing.Size(121, 121)
        Me.btnDelUser.TabIndex = 3
        Me.btnDelUser.UseVisualStyleBackColor = False
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.White
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuBarDetail})
        Me.MenuBar.Location = New System.Drawing.Point(0, 705)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.MenuBar.Size = New System.Drawing.Size(1307, 22)
        Me.MenuBar.TabIndex = 6
        '
        'MenuBarDetail
        '
        Me.MenuBarDetail.Name = "MenuBarDetail"
        Me.MenuBarDetail.Size = New System.Drawing.Size(53, 17)
        Me.MenuBarDetail.Text = "SIRP S.A."
        Me.MenuBarDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'PanelOperador
        '
        Me.PanelOperador.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelOperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOperador.Controls.Add(Me.PanelDelincuente)
        Me.PanelOperador.Controls.Add(Me.PanelDelito)
        Me.PanelOperador.Controls.Add(Me.PanelControl)
        Me.PanelOperador.Controls.Add(Me.PanelActualiza)
        Me.PanelOperador.Location = New System.Drawing.Point(461, 125)
        Me.PanelOperador.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelOperador.Name = "PanelOperador"
        Me.PanelOperador.Size = New System.Drawing.Size(404, 548)
        Me.PanelOperador.TabIndex = 8
        '
        'PanelDelincuente
        '
        Me.PanelDelincuente.BackColor = System.Drawing.Color.Silver
        Me.PanelDelincuente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDelincuente.Controls.Add(Me.lblDelincuente)
        Me.PanelDelincuente.Controls.Add(Me.btnDelincuente)
        Me.PanelDelincuente.Location = New System.Drawing.Point(2, 2)
        Me.PanelDelincuente.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDelincuente.Name = "PanelDelincuente"
        Me.PanelDelincuente.Size = New System.Drawing.Size(196, 265)
        Me.PanelDelincuente.TabIndex = 4
        '
        'lblDelincuente
        '
        Me.lblDelincuente.AutoSize = True
        Me.lblDelincuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDelincuente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelincuente.ForeColor = System.Drawing.Color.Black
        Me.lblDelincuente.Location = New System.Drawing.Point(31, 47)
        Me.lblDelincuente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDelincuente.Name = "lblDelincuente"
        Me.lblDelincuente.Size = New System.Drawing.Size(139, 17)
        Me.lblDelincuente.TabIndex = 3
        Me.lblDelincuente.Text = "Registrar delincuente"
        '
        'btnDelincuente
        '
        Me.btnDelincuente.BackColor = System.Drawing.Color.Transparent
        Me.btnDelincuente.BackgroundImage = Global.SIRP.My.Resources.Resources.delincuente
        Me.btnDelincuente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelincuente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelincuente.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDelincuente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDelincuente.FlatAppearance.BorderSize = 3
        Me.btnDelincuente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnDelincuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelincuente.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelincuente.Location = New System.Drawing.Point(41, 100)
        Me.btnDelincuente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelincuente.Name = "btnDelincuente"
        Me.btnDelincuente.Size = New System.Drawing.Size(121, 121)
        Me.btnDelincuente.TabIndex = 2
        Me.btnDelincuente.UseVisualStyleBackColor = False
        '
        'PanelDelito
        '
        Me.PanelDelito.BackColor = System.Drawing.Color.Silver
        Me.PanelDelito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDelito.Controls.Add(Me.lblDelito)
        Me.PanelDelito.Controls.Add(Me.btnDelito)
        Me.PanelDelito.Location = New System.Drawing.Point(202, 2)
        Me.PanelDelito.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDelito.Name = "PanelDelito"
        Me.PanelDelito.Size = New System.Drawing.Size(196, 265)
        Me.PanelDelito.TabIndex = 7
        '
        'lblDelito
        '
        Me.lblDelito.AutoSize = True
        Me.lblDelito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDelito.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelito.ForeColor = System.Drawing.Color.Black
        Me.lblDelito.Location = New System.Drawing.Point(18, 45)
        Me.lblDelito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDelito.Name = "lblDelito"
        Me.lblDelito.Size = New System.Drawing.Size(165, 17)
        Me.lblDelito.TabIndex = 2
        Me.lblDelito.Text = "Registrar delito cometido"
        '
        'btnDelito
        '
        Me.btnDelito.BackColor = System.Drawing.Color.Transparent
        Me.btnDelito.BackgroundImage = Global.SIRP.My.Resources.Resources.delito
        Me.btnDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelito.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDelito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDelito.FlatAppearance.BorderSize = 3
        Me.btnDelito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnDelito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelito.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelito.Location = New System.Drawing.Point(42, 89)
        Me.btnDelito.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelito.Name = "btnDelito"
        Me.btnDelito.Size = New System.Drawing.Size(121, 121)
        Me.btnDelito.TabIndex = 3
        Me.btnDelito.UseVisualStyleBackColor = False
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.Silver
        Me.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelControl.Controls.Add(Me.lblControl)
        Me.PanelControl.Controls.Add(Me.btnControl)
        Me.PanelControl.Location = New System.Drawing.Point(2, 271)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(196, 265)
        Me.PanelControl.TabIndex = 6
        '
        'lblControl
        '
        Me.lblControl.AutoSize = True
        Me.lblControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblControl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.ForeColor = System.Drawing.Color.Black
        Me.lblControl.Location = New System.Drawing.Point(40, 45)
        Me.lblControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(111, 17)
        Me.lblControl.TabIndex = 1
        Me.lblControl.Text = "Registrar control"
        '
        'btnControl
        '
        Me.btnControl.BackColor = System.Drawing.Color.Transparent
        Me.btnControl.BackgroundImage = Global.SIRP.My.Resources.Resources.control
        Me.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControl.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnControl.FlatAppearance.BorderSize = 3
        Me.btnControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControl.ForeColor = System.Drawing.Color.Transparent
        Me.btnControl.Location = New System.Drawing.Point(33, 89)
        Me.btnControl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(121, 121)
        Me.btnControl.TabIndex = 4
        Me.btnControl.UseVisualStyleBackColor = False
        '
        'PanelActualiza
        '
        Me.PanelActualiza.BackColor = System.Drawing.Color.Silver
        Me.PanelActualiza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelActualiza.Controls.Add(Me.lblActualiza)
        Me.PanelActualiza.Controls.Add(Me.btnActualizaDelincuente)
        Me.PanelActualiza.Location = New System.Drawing.Point(202, 271)
        Me.PanelActualiza.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelActualiza.Name = "PanelActualiza"
        Me.PanelActualiza.Size = New System.Drawing.Size(196, 265)
        Me.PanelActualiza.TabIndex = 8
        '
        'lblActualiza
        '
        Me.lblActualiza.AutoSize = True
        Me.lblActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblActualiza.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualiza.ForeColor = System.Drawing.Color.Black
        Me.lblActualiza.Location = New System.Drawing.Point(30, 45)
        Me.lblActualiza.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActualiza.Name = "lblActualiza"
        Me.lblActualiza.Size = New System.Drawing.Size(140, 17)
        Me.lblActualiza.TabIndex = 3
        Me.lblActualiza.Text = "Actualiza delincuente"
        '
        'btnActualizaDelincuente
        '
        Me.btnActualizaDelincuente.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizaDelincuente.BackgroundImage = Global.SIRP.My.Resources.Resources.actualiza
        Me.btnActualizaDelincuente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizaDelincuente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizaDelincuente.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnActualizaDelincuente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnActualizaDelincuente.FlatAppearance.BorderSize = 3
        Me.btnActualizaDelincuente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnActualizaDelincuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizaDelincuente.ForeColor = System.Drawing.Color.Transparent
        Me.btnActualizaDelincuente.Location = New System.Drawing.Point(41, 89)
        Me.btnActualizaDelincuente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizaDelincuente.Name = "btnActualizaDelincuente"
        Me.btnActualizaDelincuente.Size = New System.Drawing.Size(121, 121)
        Me.btnActualizaDelincuente.TabIndex = 5
        Me.btnActualizaDelincuente.UseVisualStyleBackColor = False
        '
        'PanelSector
        '
        Me.PanelSector.BackColor = System.Drawing.Color.Silver
        Me.PanelSector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSector.Controls.Add(Me.lblSector)
        Me.PanelSector.Controls.Add(Me.btnSector)
        Me.PanelSector.Location = New System.Drawing.Point(2, 2)
        Me.PanelSector.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSector.Name = "PanelSector"
        Me.PanelSector.Size = New System.Drawing.Size(196, 265)
        Me.PanelSector.TabIndex = 3
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSector.ForeColor = System.Drawing.Color.Black
        Me.lblSector.Location = New System.Drawing.Point(53, 47)
        Me.lblSector.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(98, 17)
        Me.lblSector.TabIndex = 1
        Me.lblSector.Text = "Agregar sector"
        '
        'btnSector
        '
        Me.btnSector.BackColor = System.Drawing.Color.Transparent
        Me.btnSector.BackgroundImage = Global.SIRP.My.Resources.Resources.sector
        Me.btnSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSector.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSector.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSector.FlatAppearance.BorderSize = 3
        Me.btnSector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSector.ForeColor = System.Drawing.Color.Transparent
        Me.btnSector.Location = New System.Drawing.Point(42, 89)
        Me.btnSector.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSector.Name = "btnSector"
        Me.btnSector.Size = New System.Drawing.Size(121, 121)
        Me.btnSector.TabIndex = 0
        Me.btnSector.UseVisualStyleBackColor = False
        '
        'PanelBanda
        '
        Me.PanelBanda.BackColor = System.Drawing.Color.Silver
        Me.PanelBanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBanda.Controls.Add(Me.lblBanda)
        Me.PanelBanda.Controls.Add(Me.btnBanda)
        Me.PanelBanda.Location = New System.Drawing.Point(2, 271)
        Me.PanelBanda.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBanda.Name = "PanelBanda"
        Me.PanelBanda.Size = New System.Drawing.Size(196, 265)
        Me.PanelBanda.TabIndex = 2
        '
        'lblBanda
        '
        Me.lblBanda.AutoSize = True
        Me.lblBanda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblBanda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanda.ForeColor = System.Drawing.Color.Black
        Me.lblBanda.Location = New System.Drawing.Point(46, 45)
        Me.lblBanda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBanda.Name = "lblBanda"
        Me.lblBanda.Size = New System.Drawing.Size(105, 17)
        Me.lblBanda.TabIndex = 3
        Me.lblBanda.Text = "Registrar banda"
        '
        'btnBanda
        '
        Me.btnBanda.BackColor = System.Drawing.Color.Transparent
        Me.btnBanda.BackgroundImage = Global.SIRP.My.Resources.Resources.banda
        Me.btnBanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBanda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBanda.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnBanda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBanda.FlatAppearance.BorderSize = 3
        Me.btnBanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBanda.ForeColor = System.Drawing.Color.Transparent
        Me.btnBanda.Location = New System.Drawing.Point(42, 89)
        Me.btnBanda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBanda.Name = "btnBanda"
        Me.btnBanda.Size = New System.Drawing.Size(121, 121)
        Me.btnBanda.TabIndex = 1
        Me.btnBanda.UseVisualStyleBackColor = False
        '
        'PanelRepo
        '
        Me.PanelRepo.BackColor = System.Drawing.Color.Silver
        Me.PanelRepo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelRepo.Controls.Add(Me.lblReporte)
        Me.PanelRepo.Controls.Add(Me.btnReporte)
        Me.PanelRepo.Location = New System.Drawing.Point(-2, 5)
        Me.PanelRepo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelRepo.Name = "PanelRepo"
        Me.PanelRepo.Size = New System.Drawing.Size(196, 265)
        Me.PanelRepo.TabIndex = 7
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblReporte.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporte.ForeColor = System.Drawing.Color.Black
        Me.lblReporte.Location = New System.Drawing.Point(65, 45)
        Me.lblReporte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(62, 17)
        Me.lblReporte.TabIndex = 3
        Me.lblReporte.Text = "Reportes"
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.Transparent
        Me.btnReporte.BackgroundImage = Global.SIRP.My.Resources.Resources.reporte
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporte.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnReporte.FlatAppearance.BorderSize = 3
        Me.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.ForeColor = System.Drawing.Color.Transparent
        Me.btnReporte.Location = New System.Drawing.Point(41, 89)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(121, 121)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'picPrincipal
        '
        Me.picPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.picPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrincipal.Location = New System.Drawing.Point(1093, 125)
        Me.picPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(180, 180)
        Me.picPrincipal.TabIndex = 5
        Me.picPrincipal.TabStop = False
        '
        'PanelDatos
        '
        Me.PanelDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PanelDatos.BackgroundImage = Global.SIRP.My.Resources.Resources.fondo2
        Me.PanelDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDatos.Controls.Add(Me.lblInst)
        Me.PanelDatos.Controls.Add(Me.lblConexion)
        Me.PanelDatos.Controls.Add(Me.lblCargo)
        Me.PanelDatos.Controls.Add(Me.lblTitulo)
        Me.PanelDatos.Location = New System.Drawing.Point(28, 124)
        Me.PanelDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(396, 549)
        Me.PanelDatos.TabIndex = 1
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.BackColor = System.Drawing.Color.Transparent
        Me.lblInst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.ForeColor = System.Drawing.Color.White
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
        Me.lblConexion.BackColor = System.Drawing.Color.Transparent
        Me.lblConexion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexion.ForeColor = System.Drawing.Color.White
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
        Me.lblCargo.BackColor = System.Drawing.Color.Transparent
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.Color.White
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
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(24, 40)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(132, 37)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Mis datos"
        '
        'PanelJefeZona
        '
        Me.PanelJefeZona.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelJefeZona.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelJefeZona.Controls.Add(Me.PanelSector)
        Me.PanelJefeZona.Controls.Add(Me.PanelBanda)
        Me.PanelJefeZona.Location = New System.Drawing.Point(865, 124)
        Me.PanelJefeZona.Name = "PanelJefeZona"
        Me.PanelJefeZona.Size = New System.Drawing.Size(207, 549)
        Me.PanelJefeZona.TabIndex = 10
        '
        'PanelReporte
        '
        Me.PanelReporte.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelReporte.Controls.Add(Me.PanelRepo)
        Me.PanelReporte.Location = New System.Drawing.Point(1073, 390)
        Me.PanelReporte.Name = "PanelReporte"
        Me.PanelReporte.Size = New System.Drawing.Size(200, 283)
        Me.PanelReporte.TabIndex = 12
        '
        'lblDelUser
        '
        Me.lblDelUser.AutoSize = True
        Me.lblDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDelUser.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblDelUser.ForeColor = System.Drawing.Color.White
        Me.lblDelUser.Location = New System.Drawing.Point(75, 49)
        Me.lblDelUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDelUser.Name = "lblDelUser"
        Me.lblDelUser.Size = New System.Drawing.Size(99, 19)
        Me.lblDelUser.TabIndex = 3
        Me.lblDelUser.Text = "Elimina Usuario"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1307, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelReporte)
        Me.Controls.Add(Me.PanelJefeZona)
        Me.Controls.Add(Me.PanelOperador)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.PanelBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelBarra.PerformLayout()
        Me.PanelDelIns.ResumeLayout(False)
        Me.PanelDelIns.PerformLayout()
        Me.PanelAddIns.ResumeLayout(False)
        Me.PanelAddIns.PerformLayout()
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAddUser.ResumeLayout(False)
        Me.PanelAddUser.PerformLayout()
        Me.PanelDelUser.ResumeLayout(False)
        Me.PanelDelUser.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.PanelOperador.ResumeLayout(False)
        Me.PanelDelincuente.ResumeLayout(False)
        Me.PanelDelincuente.PerformLayout()
        Me.PanelDelito.ResumeLayout(False)
        Me.PanelDelito.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        Me.PanelActualiza.ResumeLayout(False)
        Me.PanelActualiza.PerformLayout()
        Me.PanelSector.ResumeLayout(False)
        Me.PanelSector.PerformLayout()
        Me.PanelBanda.ResumeLayout(False)
        Me.PanelBanda.PerformLayout()
        Me.PanelRepo.ResumeLayout(False)
        Me.PanelRepo.PerformLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.PanelJefeZona.ResumeLayout(False)
        Me.PanelReporte.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarra As Panel
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents PanelDelIns As Panel
    Friend WithEvents PanelAddIns As Panel
    Friend WithEvents PanelAdmin As FlowLayoutPanel
    Friend WithEvents PanelAddUser As Panel
    Friend WithEvents PanelDelUser As Panel
    Friend WithEvents picPrincipal As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblInst As Label
    Friend WithEvents lblConexion As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents MenuBar As StatusStrip
    Friend WithEvents MenuBarDetail As ToolStripStatusLabel
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents btnIngresaInst As Button
    Friend WithEvents lblAgregaInst As Label
    Friend WithEvents lblEliminaInstucion As Label
    Friend WithEvents btnEliminaInst As Button
    Friend WithEvents lblAddUser As Label
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnDelUser As Button
    Friend WithEvents PanelOperador As FlowLayoutPanel
    Friend WithEvents PanelSector As Panel
    Friend WithEvents lblSector As Label
    Friend WithEvents btnSector As Button
    Friend WithEvents PanelBanda As Panel
    Friend WithEvents lblBanda As Label
    Friend WithEvents btnBanda As Button
    Friend WithEvents PanelDelincuente As Panel
    Friend WithEvents lblDelincuente As Label
    Friend WithEvents btnDelincuente As Button
    Friend WithEvents PanelDelito As Panel
    Friend WithEvents lblDelito As Label
    Friend WithEvents btnDelito As Button
    Friend WithEvents PanelControl As Panel
    Friend WithEvents lblControl As Label
    Friend WithEvents btnControl As Button
    Friend WithEvents PanelRepo As Panel
    Friend WithEvents lblReporte As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents PanelActualiza As Panel
    Friend WithEvents lblActualiza As Label
    Friend WithEvents btnActualizaDelincuente As Button
    Friend WithEvents PanelJefeZona As FlowLayoutPanel
    Friend WithEvents PanelReporte As Panel
    Friend WithEvents lblDelUser As Label
End Class
