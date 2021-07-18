<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresaDelincuente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresaDelincuente))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblRUT = New System.Windows.Forms.Label()
        Me.lblApodo = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblFono = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtApodo = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDato2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbBanda = New System.Windows.Forms.ComboBox()
        Me.lblBanda = New System.Windows.Forms.Label()
        Me.lblDato1 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(16, 29)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 20)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "NOMBRES"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.75!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(428, 9)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(268, 31)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Registro de Delincuentes"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(124, 29)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 27)
        Me.txtNombre.TabIndex = 0
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(16, 69)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(83, 20)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "APELLIDOS"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblRUT.ForeColor = System.Drawing.Color.White
        Me.lblRUT.Location = New System.Drawing.Point(16, 111)
        Me.lblRUT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(36, 20)
        Me.lblRUT.TabIndex = 5
        Me.lblRUT.Text = "RUT"
        '
        'lblApodo
        '
        Me.lblApodo.AutoSize = True
        Me.lblApodo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblApodo.ForeColor = System.Drawing.Color.White
        Me.lblApodo.Location = New System.Drawing.Point(31, 54)
        Me.lblApodo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApodo.Name = "lblApodo"
        Me.lblApodo.Size = New System.Drawing.Size(60, 20)
        Me.lblApodo.TabIndex = 6
        Me.lblApodo.Text = "APODO"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblDomicilio.ForeColor = System.Drawing.Color.White
        Me.lblDomicilio.Location = New System.Drawing.Point(22, 69)
        Me.lblDomicilio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(83, 20)
        Me.lblDomicilio.TabIndex = 7
        Me.lblDomicilio.Text = "DOMICILIO"
        '
        'lblFono
        '
        Me.lblFono.AutoSize = True
        Me.lblFono.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFono.ForeColor = System.Drawing.Color.White
        Me.lblFono.Location = New System.Drawing.Point(19, 194)
        Me.lblFono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFono.Name = "lblFono"
        Me.lblFono.Size = New System.Drawing.Size(80, 20)
        Me.lblFono.TabIndex = 8
        Me.lblFono.Text = "TELÉFONO"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblNacimiento.ForeColor = System.Drawing.Color.White
        Me.lblNacimiento.Location = New System.Drawing.Point(16, 155)
        Me.lblNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(169, 20)
        Me.lblNacimiento.TabIndex = 9
        Me.lblNacimiento.Text = "FECHA DE NACIMIENTO"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(31, 136)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado.TabIndex = 10
        Me.lblEstado.Text = "ESTADO"
        '
        'cmbEstado
        '
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbEstado.Location = New System.Drawing.Point(108, 134)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(199, 28)
        Me.cmbEstado.TabIndex = 10
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.AllowDrop = True
        Me.dtpFechaNac.CustomFormat = "dd-MM-yyyy"
        Me.dtpFechaNac.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaNac.Location = New System.Drawing.Point(205, 150)
        Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaNac.MaxDate = New Date(2012, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaNac.MinDate = New Date(1871, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(147, 27)
        Me.dtpFechaNac.TabIndex = 4
        Me.dtpFechaNac.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtApellido.Location = New System.Drawing.Point(124, 69)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(227, 27)
        Me.txtApellido.TabIndex = 1
        '
        'txtRut
        '
        Me.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRut.Location = New System.Drawing.Point(124, 108)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(169, 27)
        Me.txtRut.TabIndex = 2
        '
        'txtApodo
        '
        Me.txtApodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApodo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtApodo.Location = New System.Drawing.Point(108, 51)
        Me.txtApodo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApodo.MaxLength = 50
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(199, 27)
        Me.txtApodo.TabIndex = 8
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDomicilio.Location = New System.Drawing.Point(130, 69)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDomicilio.MaxLength = 100
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(229, 27)
        Me.txtDomicilio.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(125, 194)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(229, 27)
        Me.txtTelefono.TabIndex = 5
        '
        'txtDigito
        '
        Me.txtDigito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDigito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDigito.Location = New System.Drawing.Point(315, 108)
        Me.txtDigito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigito.MaxLength = 1
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(36, 27)
        Me.txtDigito.TabIndex = 3
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblGuion.ForeColor = System.Drawing.Color.White
        Me.lblGuion.Location = New System.Drawing.Point(297, 111)
        Me.lblGuion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 20)
        Me.lblGuion.TabIndex = 22
        Me.lblGuion.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbComuna)
        Me.Panel2.Controls.Add(Me.lblComuna)
        Me.Panel2.Controls.Add(Me.txtDomicilio)
        Me.Panel2.Controls.Add(Me.lblDomicilio)
        Me.Panel2.Location = New System.Drawing.Point(394, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 248)
        Me.Panel2.TabIndex = 1
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbComuna.Location = New System.Drawing.Point(130, 112)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(227, 28)
        Me.cmbComuna.TabIndex = 7
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblComuna.ForeColor = System.Drawing.Color.White
        Me.lblComuna.Location = New System.Drawing.Point(22, 115)
        Me.lblComuna.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(73, 20)
        Me.lblComuna.TabIndex = 8
        Me.lblComuna.Text = "COMUNA"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblNombre)
        Me.Panel4.Controls.Add(Me.txtApellido)
        Me.Panel4.Controls.Add(Me.lblNacimiento)
        Me.Panel4.Controls.Add(Me.lblRUT)
        Me.Panel4.Controls.Add(Me.lblFono)
        Me.Panel4.Controls.Add(Me.lblApellido)
        Me.Panel4.Controls.Add(Me.txtTelefono)
        Me.Panel4.Controls.Add(Me.txtNombre)
        Me.Panel4.Controls.Add(Me.txtRut)
        Me.Panel4.Controls.Add(Me.dtpFechaNac)
        Me.Panel4.Controls.Add(Me.txtDigito)
        Me.Panel4.Controls.Add(Me.lblGuion)
        Me.Panel4.Location = New System.Drawing.Point(6, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 248)
        Me.Panel4.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 403.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDato2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInfo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDato1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 105)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1140, 282)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblDato2
        '
        Me.lblDato2.AutoSize = True
        Me.lblDato2.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblDato2.ForeColor = System.Drawing.Color.Transparent
        Me.lblDato2.Location = New System.Drawing.Point(394, 3)
        Me.lblDato2.Name = "lblDato2"
        Me.lblDato2.Size = New System.Drawing.Size(181, 17)
        Me.lblDato2.TabIndex = 31
        Me.lblDato2.Text = "INFORMACIÓN DOMICILIARIA"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblInfo.ForeColor = System.Drawing.Color.Transparent
        Me.lblInfo.Location = New System.Drawing.Point(782, 3)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(165, 17)
        Me.lblInfo.TabIndex = 27
        Me.lblInfo.Text = "INFORMACIÓN ADICIONAL"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cmbBanda)
        Me.Panel3.Controls.Add(Me.lblApodo)
        Me.Panel3.Controls.Add(Me.lblEstado)
        Me.Panel3.Controls.Add(Me.lblBanda)
        Me.Panel3.Controls.Add(Me.txtApodo)
        Me.Panel3.Controls.Add(Me.cmbEstado)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Panel3.Location = New System.Drawing.Point(782, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 248)
        Me.Panel3.TabIndex = 2
        '
        'cmbBanda
        '
        Me.cmbBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(108, 92)
        Me.cmbBanda.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(199, 28)
        Me.cmbBanda.TabIndex = 9
        '
        'lblBanda
        '
        Me.lblBanda.AutoSize = True
        Me.lblBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblBanda.ForeColor = System.Drawing.Color.White
        Me.lblBanda.Location = New System.Drawing.Point(31, 92)
        Me.lblBanda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBanda.Name = "lblBanda"
        Me.lblBanda.Size = New System.Drawing.Size(60, 20)
        Me.lblBanda.TabIndex = 19
        Me.lblBanda.Text = "BANDA"
        '
        'lblDato1
        '
        Me.lblDato1.AutoSize = True
        Me.lblDato1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblDato1.ForeColor = System.Drawing.Color.Transparent
        Me.lblDato1.Location = New System.Drawing.Point(6, 3)
        Me.lblDato1.Name = "lblDato1"
        Me.lblDato1.Size = New System.Drawing.Size(128, 17)
        Me.lblDato1.TabIndex = 25
        Me.lblDato1.Text = "DATOS PERSONALES"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(482, 418)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(194, 33)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "REGISTRAR DELINCUENTE"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'IngresaDelincuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1165, 493)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "IngresaDelincuente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Delincuente"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblRUT As Label
    Friend WithEvents lblApodo As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents lblFono As Label
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtApodo As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents lblGuion As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents lblComuna As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDato1 As Label
    Friend WithEvents lblDato2 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbBanda As ComboBox
    Friend WithEvents lblBanda As Label
End Class
