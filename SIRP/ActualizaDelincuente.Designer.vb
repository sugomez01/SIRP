<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizaDelincuente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizaDelincuente))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblRUT = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDato2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbBanda = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblBanda = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblDato1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.lblFono = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApodo = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtApodo = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnActualiza = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.75!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(508, 36)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(446, 38)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Actualización Registro Delincuente"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblRUT.ForeColor = System.Drawing.Color.White
        Me.lblRUT.Location = New System.Drawing.Point(480, 128)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(46, 25)
        Me.lblRUT.TabIndex = 25
        Me.lblRUT.Text = "RUT"
        '
        'txtRut
        '
        Me.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRut.Location = New System.Drawing.Point(553, 124)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(224, 32)
        Me.txtRut.TabIndex = 23
        '
        'txtDigito
        '
        Me.txtDigito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDigito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDigito.Location = New System.Drawing.Point(808, 124)
        Me.txtDigito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDigito.MaxLength = 1
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(47, 32)
        Me.txtDigito.TabIndex = 24
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblGuion.ForeColor = System.Drawing.Color.White
        Me.lblGuion.Location = New System.Drawing.Point(784, 128)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(20, 25)
        Me.lblGuion.TabIndex = 26
        Me.lblGuion.Text = "-"
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.Color.Transparent
        Me.btnBusca.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBusca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBusca.ForeColor = System.Drawing.Color.White
        Me.btnBusca.Location = New System.Drawing.Point(917, 124)
        Me.btnBusca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(147, 34)
        Me.btnBusca.TabIndex = 27
        Me.btnBusca.Text = "BUSCAR"
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 513.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 513.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 559.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDato2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInfo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDato1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 204)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 289.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1520, 242)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'lblDato2
        '
        Me.lblDato2.AutoSize = True
        Me.lblDato2.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblDato2.ForeColor = System.Drawing.Color.Transparent
        Me.lblDato2.Location = New System.Drawing.Point(523, 3)
        Me.lblDato2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDato2.Name = "lblDato2"
        Me.lblDato2.Size = New System.Drawing.Size(223, 21)
        Me.lblDato2.TabIndex = 31
        Me.lblDato2.Text = "INFORMACIÓN DOMICILIARIA"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblInfo.ForeColor = System.Drawing.Color.Transparent
        Me.lblInfo.Location = New System.Drawing.Point(1039, 3)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(203, 21)
        Me.lblInfo.TabIndex = 27
        Me.lblInfo.Text = "INFORMACIÓN ADICIONAL"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cmbBanda)
        Me.Panel3.Controls.Add(Me.lblEstado)
        Me.Panel3.Controls.Add(Me.lblBanda)
        Me.Panel3.Controls.Add(Me.cmbEstado)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Panel3.Location = New System.Drawing.Point(1039, 31)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(468, 203)
        Me.Panel3.TabIndex = 2
        '
        'cmbBanda
        '
        Me.cmbBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(141, 58)
        Me.cmbBanda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(264, 33)
        Me.cmbBanda.TabIndex = 9
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(39, 112)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(80, 25)
        Me.lblEstado.TabIndex = 10
        Me.lblEstado.Text = "ESTADO"
        '
        'lblBanda
        '
        Me.lblBanda.AutoSize = True
        Me.lblBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblBanda.ForeColor = System.Drawing.Color.White
        Me.lblBanda.Location = New System.Drawing.Point(39, 62)
        Me.lblBanda.Name = "lblBanda"
        Me.lblBanda.Size = New System.Drawing.Size(74, 25)
        Me.lblBanda.TabIndex = 19
        Me.lblBanda.Text = "BANDA"
        '
        'cmbEstado
        '
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbEstado.Location = New System.Drawing.Point(141, 110)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(264, 33)
        Me.cmbEstado.TabIndex = 10
        '
        'lblDato1
        '
        Me.lblDato1.AutoSize = True
        Me.lblDato1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblDato1.ForeColor = System.Drawing.Color.Transparent
        Me.lblDato1.Location = New System.Drawing.Point(7, 3)
        Me.lblDato1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDato1.Name = "lblDato1"
        Me.lblDato1.Size = New System.Drawing.Size(157, 21)
        Me.lblDato1.TabIndex = 25
        Me.lblDato1.Text = "DATOS PERSONALES"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbComuna)
        Me.Panel2.Controls.Add(Me.lblComuna)
        Me.Panel2.Controls.Add(Me.txtDomicilio)
        Me.Panel2.Controls.Add(Me.lblFono)
        Me.Panel2.Controls.Add(Me.lblDomicilio)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Location = New System.Drawing.Point(523, 31)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 203)
        Me.Panel2.TabIndex = 1
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbComuna.Location = New System.Drawing.Point(173, 132)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(304, 33)
        Me.cmbComuna.TabIndex = 7
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblComuna.ForeColor = System.Drawing.Color.White
        Me.lblComuna.Location = New System.Drawing.Point(29, 135)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(93, 25)
        Me.lblComuna.TabIndex = 8
        Me.lblComuna.Text = "COMUNA"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDomicilio.Location = New System.Drawing.Point(173, 85)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDomicilio.MaxLength = 100
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(304, 32)
        Me.txtDomicilio.TabIndex = 6
        '
        'lblFono
        '
        Me.lblFono.AutoSize = True
        Me.lblFono.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFono.ForeColor = System.Drawing.Color.White
        Me.lblFono.Location = New System.Drawing.Point(29, 39)
        Me.lblFono.Name = "lblFono"
        Me.lblFono.Size = New System.Drawing.Size(102, 25)
        Me.lblFono.TabIndex = 8
        Me.lblFono.Text = "TELÉFONO"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblDomicilio.ForeColor = System.Drawing.Color.White
        Me.lblDomicilio.Location = New System.Drawing.Point(29, 85)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(106, 25)
        Me.lblDomicilio.TabIndex = 7
        Me.lblDomicilio.Text = "DOMICILIO"
        '
        'txtTelefono
        '
        Me.txtTelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(173, 36)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(304, 32)
        Me.txtTelefono.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblNombre)
        Me.Panel4.Controls.Add(Me.lblApodo)
        Me.Panel4.Controls.Add(Me.txtApellido)
        Me.Panel4.Controls.Add(Me.txtApodo)
        Me.Panel4.Controls.Add(Me.lblApellido)
        Me.Panel4.Controls.Add(Me.txtNombre)
        Me.Panel4.Location = New System.Drawing.Point(7, 31)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(504, 203)
        Me.Panel4.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(21, 36)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(99, 25)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "NOMBRES"
        '
        'lblApodo
        '
        Me.lblApodo.AutoSize = True
        Me.lblApodo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblApodo.ForeColor = System.Drawing.Color.White
        Me.lblApodo.Location = New System.Drawing.Point(21, 137)
        Me.lblApodo.Name = "lblApodo"
        Me.lblApodo.Size = New System.Drawing.Size(76, 25)
        Me.lblApodo.TabIndex = 6
        Me.lblApodo.Text = "APODO"
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Enabled = False
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtApellido.Location = New System.Drawing.Point(165, 85)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(301, 32)
        Me.txtApellido.TabIndex = 1
        '
        'txtApodo
        '
        Me.txtApodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApodo.Enabled = False
        Me.txtApodo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtApodo.Location = New System.Drawing.Point(165, 133)
        Me.txtApodo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApodo.MaxLength = 50
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(301, 32)
        Me.txtApodo.TabIndex = 8
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(21, 85)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(105, 25)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "APELLIDOS"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(165, 36)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(301, 32)
        Me.txtNombre.TabIndex = 0
        '
        'btnActualiza
        '
        Me.btnActualiza.BackColor = System.Drawing.Color.Transparent
        Me.btnActualiza.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnActualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualiza.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualiza.ForeColor = System.Drawing.Color.White
        Me.btnActualiza.Location = New System.Drawing.Point(675, 497)
        Me.btnActualiza.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(216, 34)
        Me.btnActualiza.TabIndex = 29
        Me.btnActualiza.Text = "ACTUALIZAR DATOS"
        Me.btnActualiza.UseVisualStyleBackColor = False
        '
        'ActualizaDelincuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1568, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnActualiza)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.lblRUT)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtDigito)
        Me.Controls.Add(Me.lblGuion)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ActualizaDelincuente"
        Me.Text = "ActualizaDelincuente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblRUT As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents lblGuion As Label
    Friend WithEvents btnBusca As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDato2 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents lblComuna As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents lblFono As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbBanda As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblBanda As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents lblDato1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApodo As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtApodo As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnActualiza As Button
End Class
