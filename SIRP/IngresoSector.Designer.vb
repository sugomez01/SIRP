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
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!)
        Me.Label1.Location = New System.Drawing.Point(336, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Sector"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblZona.Location = New System.Drawing.Point(223, 139)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblZona.Size = New System.Drawing.Size(48, 23)
        Me.lblZona.TabIndex = 1
        Me.lblZona.Text = "Zona"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblComuna.Location = New System.Drawing.Point(223, 199)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(74, 23)
        Me.lblComuna.TabIndex = 2
        Me.lblComuna.Text = "Comuna"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblSector.Location = New System.Drawing.Point(223, 260)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(59, 23)
        Me.lblSector.TabIndex = 3
        Me.lblSector.Text = "Sector"
        '
        'lblDetalleSec
        '
        Me.lblDetalleSec.AutoSize = True
        Me.lblDetalleSec.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.lblDetalleSec.Location = New System.Drawing.Point(223, 321)
        Me.lblDetalleSec.Name = "lblDetalleSec"
        Me.lblDetalleSec.Size = New System.Drawing.Size(63, 23)
        Me.lblDetalleSec.TabIndex = 4
        Me.lblDetalleSec.Text = "Detalle"
        '
        'cmbZona
        '
        Me.cmbZona.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(325, 138)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(149, 30)
        Me.cmbZona.TabIndex = 5
        '
        'cmbComuna
        '
        Me.cmbComuna.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.cmbComuna.FormattingEnabled = True
        Me.cmbComuna.Location = New System.Drawing.Point(325, 199)
        Me.cmbComuna.Name = "cmbComuna"
        Me.cmbComuna.Size = New System.Drawing.Size(149, 30)
        Me.cmbComuna.TabIndex = 6
        '
        'txtSector
        '
        Me.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSector.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtSector.Location = New System.Drawing.Point(325, 260)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(149, 29)
        Me.txtSector.TabIndex = 7
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtDetalle.ForeColor = System.Drawing.Color.Black
        Me.txtDetalle.Location = New System.Drawing.Point(325, 320)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(272, 120)
        Me.txtDetalle.TabIndex = 8
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.btnIngresar.Location = New System.Drawing.Point(487, 487)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(110, 31)
        Me.btnIngresar.TabIndex = 9
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'IngresoSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(912, 882)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "IngresoSector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoSector"
        Me.TransparencyKey = System.Drawing.Color.Transparent
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
