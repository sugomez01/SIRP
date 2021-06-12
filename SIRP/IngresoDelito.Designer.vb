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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Módulo Ingreso de delitos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(558, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Delito"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de delito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Zona"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Comuna"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(605, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sector"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(558, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Banda"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(105, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Detalles del delito"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(179, 128)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(176, 29)
        Me.txtRut.TabIndex = 10
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(256, 392)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(542, 108)
        Me.txtDetalle.TabIndex = 11
        '
        'btnRegistrar
        '
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(700, 527)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 32)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(654, 128)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 30)
        Me.ComboBox1.TabIndex = 13
        '
        'cmbSector
        '
        Me.cmbSector.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSector.FormattingEnabled = True
        Me.cmbSector.Location = New System.Drawing.Point(670, 302)
        Me.cmbSector.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.Size = New System.Drawing.Size(176, 30)
        Me.cmbSector.TabIndex = 15
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(128, 302)
        Me.cmbZona.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(176, 30)
        Me.cmbZona.TabIndex = 16
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(400, 302)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(176, 30)
        Me.cmbComuna.TabIndex = 17
        '
        'cmbBanda
        '
        Me.cmbBanda.FormattingEnabled = True
        Me.cmbBanda.Location = New System.Drawing.Point(654, 212)
        Me.cmbBanda.Name = "cmbBanda"
        Me.cmbBanda.Size = New System.Drawing.Size(176, 30)
        Me.cmbBanda.TabIndex = 18
        '
        'dtpFechaDelito
        '
        Me.dtpFechaDelito.Location = New System.Drawing.Point(179, 210)
        Me.dtpFechaDelito.Name = "dtpFechaDelito"
        Me.dtpFechaDelito.Size = New System.Drawing.Size(176, 29)
        Me.dtpFechaDelito.TabIndex = 19
        '
        'IngresoDelito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 614)
        Me.Controls.Add(Me.dtpFechaDelito)
        Me.Controls.Add(Me.cmbBanda)
        Me.Controls.Add(Me.cmbComuna)
        Me.Controls.Add(Me.cmbZona)
        Me.Controls.Add(Me.cmbSector)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IngresoDelito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoDelito"
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
End Class
