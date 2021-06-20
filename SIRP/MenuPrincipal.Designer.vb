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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblEliminaInstucion = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAgregaInst = New System.Windows.Forms.Label()
        Me.PanelAdmin = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelJefe = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSector = New System.Windows.Forms.Button()
        Me.btnBanda = New System.Windows.Forms.Button()
        Me.btnDelincuente = New System.Windows.Forms.Button()
        Me.btnDelito = New System.Windows.Forms.Button()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.picPrincipal = New System.Windows.Forms.PictureBox()
        Me.btnIngresaInst = New System.Windows.Forms.Button()
        Me.btnEliminaInst = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picChile = New System.Windows.Forms.PictureBox()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelJefe.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 82)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblEliminaInstucion)
        Me.Panel3.Controls.Add(Me.btnEliminaInst)
        Me.Panel3.Location = New System.Drawing.Point(280, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
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
        Me.PanelAdmin.BackColor = System.Drawing.Color.Silver
        Me.PanelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdmin.Controls.Add(Me.Panel4)
        Me.PanelAdmin.Controls.Add(Me.Panel3)
        Me.PanelAdmin.Controls.Add(Me.Panel6)
        Me.PanelAdmin.Controls.Add(Me.Panel7)
        Me.PanelAdmin.Location = New System.Drawing.Point(461, 124)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(546, 544)
        Me.PanelAdmin.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Location = New System.Drawing.Point(2, 275)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(274, 269)
        Me.Panel6.TabIndex = 5
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
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Location = New System.Drawing.Point(280, 275)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(262, 269)
        Me.Panel7.TabIndex = 6
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 694)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1263, 22)
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
        'PanelJefe
        '
        Me.PanelJefe.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelJefe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelJefe.Controls.Add(Me.Panel5)
        Me.PanelJefe.Controls.Add(Me.Panel8)
        Me.PanelJefe.Controls.Add(Me.Panel9)
        Me.PanelJefe.Controls.Add(Me.Panel10)
        Me.PanelJefe.Controls.Add(Me.Panel11)
        Me.PanelJefe.Controls.Add(Me.Panel12)
        Me.PanelJefe.Location = New System.Drawing.Point(447, 124)
        Me.PanelJefe.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelJefe.Name = "PanelJefe"
        Me.PanelJefe.Size = New System.Drawing.Size(601, 544)
        Me.PanelJefe.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.btnSector)
        Me.Panel5.Location = New System.Drawing.Point(2, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(196, 265)
        Me.Panel5.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Agregar sector"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Silver
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.btnBanda)
        Me.Panel8.Location = New System.Drawing.Point(202, 2)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(193, 265)
        Me.Panel8.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Registrar banda"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Silver
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.btnDelincuente)
        Me.Panel9.Location = New System.Drawing.Point(399, 2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(196, 265)
        Me.Panel9.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Registrar delincuente"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Silver
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.btnDelito)
        Me.Panel10.Location = New System.Drawing.Point(2, 271)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(196, 269)
        Me.Panel10.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Registrar delito cometido"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Controls.Add(Me.btnControl)
        Me.Panel11.Location = New System.Drawing.Point(202, 271)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(193, 269)
        Me.Panel11.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(40, 45)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Registrar control"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.Label8)
        Me.Panel12.Controls.Add(Me.btnReporte)
        Me.Panel12.Location = New System.Drawing.Point(399, 271)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(196, 269)
        Me.Panel12.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(65, 45)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Reportes"
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
        Me.btnSector.Location = New System.Drawing.Point(42, 100)
        Me.btnSector.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSector.Name = "btnSector"
        Me.btnSector.Size = New System.Drawing.Size(121, 121)
        Me.btnSector.TabIndex = 0
        Me.btnSector.UseVisualStyleBackColor = False
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
        Me.btnBanda.Location = New System.Drawing.Point(35, 102)
        Me.btnBanda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBanda.Name = "btnBanda"
        Me.btnBanda.Size = New System.Drawing.Size(121, 121)
        Me.btnBanda.TabIndex = 2
        Me.btnBanda.UseVisualStyleBackColor = False
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
        Me.btnDelincuente.TabIndex = 0
        Me.btnDelincuente.UseVisualStyleBackColor = False
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
        Me.btnDelito.TabIndex = 4
        Me.btnDelito.UseVisualStyleBackColor = False
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
        Me.btnReporte.TabIndex = 4
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'picPrincipal
        '
        Me.picPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.picPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrincipal.Location = New System.Drawing.Point(1070, 127)
        Me.picPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.picPrincipal.Name = "picPrincipal"
        Me.picPrincipal.Size = New System.Drawing.Size(180, 180)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.SIRP.My.Resources.Resources.fondo2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.picChile)
        Me.Panel2.Controls.Add(Me.lblInst)
        Me.Panel2.Controls.Add(Me.lblConexion)
        Me.Panel2.Controls.Add(Me.lblCargo)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Location = New System.Drawing.Point(28, 124)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 544)
        Me.Panel2.TabIndex = 1
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.SIRP.My.Resources.Resources.cerrarSesion
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1189, 10)
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
        Me.ClientSize = New System.Drawing.Size(1263, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelJefe)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picPrincipal)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
        Me.PanelJefe.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.picPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents PanelJefe As FlowLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSector As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBanda As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelincuente As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelito As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnControl As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnReporte As Button
End Class
