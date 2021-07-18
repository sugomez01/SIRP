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
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.btnIngresa = New System.Windows.Forms.Button()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmbIns = New System.Windows.Forms.ComboBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomb = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(170, 26)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(191, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro de usuario"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.ForeColor = System.Drawing.Color.White
        Me.lblRut.Location = New System.Drawing.Point(43, 196)
        Me.lblRut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(36, 20)
        Me.lblRut.TabIndex = 4
        Me.lblRut.Text = "RUT"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(43, 243)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(159, 20)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "NOMBRE DE USUARIO"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(43, 291)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(104, 20)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "CONTRASEÑA"
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.ForeColor = System.Drawing.Color.White
        Me.lblInst.Location = New System.Drawing.Point(43, 330)
        Me.lblInst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(97, 20)
        Me.lblInst.TabIndex = 7
        Me.lblInst.Text = "INSTITUCIÓN"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(43, 381)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(129, 20)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "TIPO DE USUARIO"
        '
        'btnIngresa
        '
        Me.btnIngresa.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnIngresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresa.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresa.ForeColor = System.Drawing.Color.Transparent
        Me.btnIngresa.Location = New System.Drawing.Point(303, 493)
        Me.btnIngresa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresa.Name = "btnIngresa"
        Me.btnIngresa.Size = New System.Drawing.Size(163, 25)
        Me.btnIngresa.TabIndex = 9
        Me.btnIngresa.Text = "REGISTRAR USUARIO"
        Me.btnIngresa.UseVisualStyleBackColor = True
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(227, 192)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(168, 27)
        Me.txtRut.TabIndex = 2
        '
        'txtDV
        '
        Me.txtDV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDV.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDV.Location = New System.Drawing.Point(428, 192)
        Me.txtDV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(38, 27)
        Me.txtDV.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(227, 240)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.MaxLength = 50
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(239, 27)
        Me.txtUser.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(227, 284)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(239, 27)
        Me.txtPass.TabIndex = 5
        '
        'cmbIns
        '
        Me.cmbIns.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIns.FormattingEnabled = True
        Me.cmbIns.Location = New System.Drawing.Point(227, 327)
        Me.cmbIns.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbIns.Name = "cmbIns"
        Me.cmbIns.Size = New System.Drawing.Size(239, 28)
        Me.cmbIns.TabIndex = 6
        '
        'cmbTipo
        '
        Me.cmbTipo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(227, 378)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(239, 28)
        Me.cmbTipo.TabIndex = 7
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.Color.White
        Me.lblSexo.Location = New System.Drawing.Point(43, 430)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(45, 20)
        Me.lblSexo.TabIndex = 27
        Me.lblSexo.Text = "SEXO"
        '
        'cmbSexo
        '
        Me.cmbSexo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO", "OTRO"})
        Me.cmbSexo.Location = New System.Drawing.Point(227, 427)
        Me.cmbSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(239, 28)
        Me.cmbSexo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(403, 196)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "-"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(43, 103)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "NOMBRES"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(43, 149)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(83, 20)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "APELLIDOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 180)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "-"
        '
        'txtNomb
        '
        Me.txtNomb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomb.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomb.Location = New System.Drawing.Point(227, 100)
        Me.txtNomb.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomb.MaxLength = 50
        Me.txtNomb.Name = "txtNomb"
        Me.txtNomb.Size = New System.Drawing.Size(239, 27)
        Me.txtNomb.TabIndex = 0
        '
        'txtApe
        '
        Me.txtApe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe.Location = New System.Drawing.Point(227, 146)
        Me.txtApe.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApe.MaxLength = 50
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(239, 27)
        Me.txtApe.TabIndex = 1
        '
        'IngresoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.cmbIns)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtDV)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.txtNomb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIngresa)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "IngresoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblInst As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents btnIngresa As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtDV As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbIns As ComboBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomb As TextBox
    Friend WithEvents txtApe As TextBox
End Class
