<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoSector
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.lblComuna = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblDetalleSec = New System.Windows.Forms.Label()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.cmbComuna = New System.Windows.Forms.ComboBox()
        Me.txtSector = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(273, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de sector"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblZona.ForeColor = System.Drawing.Color.White
        Me.lblZona.Location = New System.Drawing.Point(39, 112)
        Me.lblZona.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblZona.Size = New System.Drawing.Size(50, 20)
        Me.lblZona.TabIndex = 1
        Me.lblZona.Text = "ZONA"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblComuna.ForeColor = System.Drawing.Color.White
        Me.lblComuna.Location = New System.Drawing.Point(35, 162)
        Me.lblComuna.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(73, 20)
        Me.lblComuna.TabIndex = 2
        Me.lblComuna.Text = "COMUNA"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblSector.ForeColor = System.Drawing.Color.White
        Me.lblSector.Location = New System.Drawing.Point(35, 217)
        Me.lblSector.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(61, 20)
        Me.lblSector.TabIndex = 3
        Me.lblSector.Text = "SECTOR"
        '
        'lblDetalleSec
        '
        Me.lblDetalleSec.AutoSize = True
        Me.lblDetalleSec.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblDetalleSec.ForeColor = System.Drawing.Color.White
        Me.lblDetalleSec.Location = New System.Drawing.Point(398, 112)
        Me.lblDetalleSec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetalleSec.Name = "lblDetalleSec"
        Me.lblDetalleSec.Size = New System.Drawing.Size(67, 20)
        Me.lblDetalleSec.TabIndex = 4
        Me.lblDetalleSec.Text = "DETALLE"
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(129, 109)
        Me.cmbZona.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(186, 28)
        Me.cmbZona.TabIndex = 0
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(129, 159)
        Me.cmbComuna.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(186, 28)
        Me.cmbComuna.TabIndex = 1
        '
        'txtSector
        '
        Me.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSector.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtSector.Location = New System.Drawing.Point(129, 214)
        Me.txtSector.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(186, 27)
        Me.txtSector.TabIndex = 2
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtDetalle.ForeColor = System.Drawing.Color.Black
        Me.txtDetalle.Location = New System.Drawing.Point(402, 142)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(293, 99)
        Me.txtDetalle.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnIngresar.ForeColor = System.Drawing.Color.Transparent
        Me.btnIngresar.Location = New System.Drawing.Point(563, 286)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(132, 29)
        Me.btnIngresar.TabIndex = 9
        Me.btnIngresar.Text = "REGISTRAR SECTOR"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'IngresoSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 361)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.cmbComuna)
        Me.Controls.Add(Me.cmbZona)
        Me.Controls.Add(Me.lblDetalleSec)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.lblComuna)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IngresoSector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoSector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblZona As Label
    Friend WithEvents lblComuna As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents lblDetalleSec As Label
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents txtSector As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btnIngresar As Button
End Class
