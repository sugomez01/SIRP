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
        Me.lblTitulo.Location = New System.Drawing.Point(381, 29)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(368, 31)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Actualización Registro Delincuente"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblRUT.ForeColor = System.Drawing.Color.White
        Me.lblRUT.Location = New System.Drawing.Point(360, 104)
        Me.lblRUT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(36, 20)
        Me.lblRUT.TabIndex = 25
        Me.lblRUT.Text = "RUT"
        '
        'txtRut
        '
        Me.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRut.Location = New System.Drawing.Point(415, 101)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(169, 27)
        Me.txtRut.TabIndex = 23
        '
        'txtDigito
        '
        Me.txtDigito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDigito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDigito.Location = New System.Drawing.Point(606, 101)
        Me.txtDigito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDigito.MaxLength = 1
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(36, 27)
        Me.txtDigito.TabIndex = 24
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblGuion.ForeColor = System.Drawing.Color.White
        Me.lblGuion.Location = New System.Drawing.Point(588, 104)
        Me.lblGuion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(15, 20)
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
        Me.btnBusca.Location = New System.Drawing.Point(688, 101)
        Me.btnBusca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(110, 28)
        Me.btnBusca.TabIndex = 27
        Me.btnBusca.Text = "BUSCAR"
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 425.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDato2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInfo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDato1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 166)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1140, 197)
        Me.TableLayoutPanel1.TabIndex = 28
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
        Me.Panel3.Controls.Add(Me.lblEstado)
        Me.Panel3.Controls.Add(Me.lblBanda)
        Me.Panel3.Controls.Add(Me.cmbEstado)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Panel3.Location = New System.Drawing.Point(782, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 166)
        Me.Panel3.TabIndex = 2
        '
        'cmbBanda
        '
        Me.cmbBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(106, 47)
        Me.cmbBanda.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(199, 28)
        Me.cmbBanda.TabIndex = 9
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(29, 91)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado.TabIndex = 10
        Me.lblEstado.Text = "ESTADO"
        '
        'lblBanda
        '
        Me.lblBanda.AutoSize = True
        Me.lblBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblBanda.ForeColor = System.Drawing.Color.White
        Me.lblBanda.Location = New System.Drawing.Point(29, 50)
        Me.lblBanda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBanda.Name = "lblBanda"
        Me.lblBanda.Size = New System.Drawing.Size(60, 20)
        Me.lblBanda.TabIndex = 19
        Me.lblBanda.Text = "BANDA"
        '
        'cmbEstado
        '
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbEstado.Location = New System.Drawing.Point(106, 89)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(199, 28)
        Me.cmbEstado.TabIndex = 10
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmbComuna)
        Me.Panel2.Controls.Add(Me.lblComuna)
        Me.Panel2.Controls.Add(Me.txtDomicilio)
        Me.Panel2.Controls.Add(Me.lblFono)
        Me.Panel2.Controls.Add(Me.lblDomicilio)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Location = New System.Drawing.Point(394, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 166)
        Me.Panel2.TabIndex = 1
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Items.AddRange(New Object() {"Libre", "Preso", "Orden de Arresto"})
        Me.cmbComuna.Location = New System.Drawing.Point(130, 107)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(229, 28)
        Me.cmbComuna.TabIndex = 7
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblComuna.ForeColor = System.Drawing.Color.White
        Me.lblComuna.Location = New System.Drawing.Point(22, 110)
        Me.lblComuna.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(73, 20)
        Me.lblComuna.TabIndex = 8
        Me.lblComuna.Text = "COMUNA"
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
        'lblFono
        '
        Me.lblFono.AutoSize = True
        Me.lblFono.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFono.ForeColor = System.Drawing.Color.White
        Me.lblFono.Location = New System.Drawing.Point(22, 32)
        Me.lblFono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFono.Name = "lblFono"
        Me.lblFono.Size = New System.Drawing.Size(80, 20)
        Me.lblFono.TabIndex = 8
        Me.lblFono.Text = "TELÉFONO"
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
        'txtTelefono
        '
        Me.txtTelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(130, 29)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(229, 27)
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
        Me.Panel4.Location = New System.Drawing.Point(6, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 166)
        Me.Panel4.TabIndex = 0
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
        'lblApodo
        '
        Me.lblApodo.AutoSize = True
        Me.lblApodo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblApodo.ForeColor = System.Drawing.Color.White
        Me.lblApodo.Location = New System.Drawing.Point(16, 111)
        Me.lblApodo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApodo.Name = "lblApodo"
        Me.lblApodo.Size = New System.Drawing.Size(60, 20)
        Me.lblApodo.TabIndex = 6
        Me.lblApodo.Text = "APODO"
        '
        'txtApellido
        '
        Me.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellido.Enabled = False
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtApellido.Location = New System.Drawing.Point(124, 69)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(227, 27)
        Me.txtApellido.TabIndex = 1
        '
        'txtApodo
        '
        Me.txtApodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApodo.Enabled = False
        Me.txtApodo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtApodo.Location = New System.Drawing.Point(124, 108)
        Me.txtApodo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApodo.MaxLength = 50
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(227, 27)
        Me.txtApodo.TabIndex = 8
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
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(124, 29)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 27)
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
        Me.btnActualiza.Location = New System.Drawing.Point(506, 404)
        Me.btnActualiza.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(162, 28)
        Me.btnActualiza.TabIndex = 29
        Me.btnActualiza.Text = "ACTUALIZAR DATOS"
        Me.btnActualiza.UseVisualStyleBackColor = False
        '
        'ActualizaDelincuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 467)
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
        Me.Name = "ActualizaDelincuente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
