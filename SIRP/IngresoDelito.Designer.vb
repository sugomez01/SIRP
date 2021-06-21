<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoDelito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoDelito))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbSector = New System.Windows.Forms.ComboBox()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.cmbBanda = New System.Windows.Forms.ComboBox()
        Me.dtpFechaDelito = New System.Windows.Forms.DateTimePicker()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(328, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso delito cometido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DELITO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FECHA DELITO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ZONA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(46, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "COMUNA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(35, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SECTOR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(35, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "BANDA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(24, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "DETALLES DEL DELITO"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtRut.Location = New System.Drawing.Point(98, 25)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(159, 27)
        Me.txtRut.TabIndex = 10
        '
        'txtDetalle
        '
        Me.txtDetalle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDetalle.Location = New System.Drawing.Point(28, 204)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(479, 126)
        Me.txtDetalle.TabIndex = 11
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.Location = New System.Drawing.Point(1020, 782)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(146, 30)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "REGISTRAR DELITO"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 76)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 28)
        Me.ComboBox1.TabIndex = 13
        '
        'cmbSector
        '
        Me.cmbSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(173, 12)
        Me.cmbSector.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(201, 28)
        Me.cmbSector.TabIndex = 15
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(173, 50)
        Me.cmbZona.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(201, 28)
        Me.cmbZona.TabIndex = 16
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(171, 86)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(201, 28)
        Me.cmbComuna.TabIndex = 17
        '
        'cmbBanda
        '
        Me.cmbBanda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(141, 116)
        Me.cmbBanda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(201, 28)
        Me.cmbBanda.TabIndex = 18
        '
        'dtpFechaDelito
        '
        Me.dtpFechaDelito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.dtpFechaDelito.Location = New System.Drawing.Point(142, 119)
        Me.dtpFechaDelito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaDelito.Name = "dtpFechaDelito"
        Me.dtpFechaDelito.Size = New System.Drawing.Size(201, 27)
        Me.dtpFechaDelito.TabIndex = 19
        '
        'txtDigito
        '
        Me.txtDigito.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDigito.Location = New System.Drawing.Point(264, 25)
        Me.txtDigito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(34, 27)
        Me.txtDigito.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpFechaDelito)
        Me.Panel2.Controls.Add(Me.txtDigito)
        Me.Panel2.Controls.Add(Me.txtDetalle)
        Me.Panel2.Controls.Add(Me.txtRut)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 353)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cmbSector)
        Me.Panel3.Controls.Add(Me.cmbBanda)
        Me.Panel3.Controls.Add(Me.cmbZona)
        Me.Panel3.Controls.Add(Me.cmbComuna)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(549, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 353)
        Me.Panel3.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(79, 144)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(980, 483)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'IngresoDelito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1230, 838)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "IngresoDelito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoDelito"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmbSector As ComboBox
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents cmbBanda As ComboBox
    Friend WithEvents dtpFechaDelito As DateTimePicker
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
