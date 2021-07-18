<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioInstitucion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioInstitucion))
        Me.lblIngresa = New System.Windows.Forms.Label()
        Me.lblInstitucion = New System.Windows.Forms.Label()
        Me.txtInst = New System.Windows.Forms.TextBox()
        Me.cmbInstituciones = New System.Windows.Forms.ComboBox()
        Me.lblElimina = New System.Windows.Forms.Label()
        Me.btnElimina = New System.Windows.Forms.Button()
        Me.btnRegistra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIngresa
        '
        Me.lblIngresa.AutoSize = True
        Me.lblIngresa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresa.ForeColor = System.Drawing.Color.White
        Me.lblIngresa.Location = New System.Drawing.Point(212, 36)
        Me.lblIngresa.Name = "lblIngresa"
        Me.lblIngresa.Size = New System.Drawing.Size(219, 32)
        Me.lblIngresa.TabIndex = 1
        Me.lblIngresa.Text = "Registro Institución"
        '
        'lblInstitucion
        '
        Me.lblInstitucion.AutoSize = True
        Me.lblInstitucion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstitucion.ForeColor = System.Drawing.Color.White
        Me.lblInstitucion.Location = New System.Drawing.Point(80, 121)
        Me.lblInstitucion.Name = "lblInstitucion"
        Me.lblInstitucion.Size = New System.Drawing.Size(206, 25)
        Me.lblInstitucion.TabIndex = 2
        Me.lblInstitucion.Text = "NOMBRE INSTITUCIÓN"
        '
        'txtInst
        '
        Me.txtInst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInst.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInst.Location = New System.Drawing.Point(317, 117)
        Me.txtInst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInst.Name = "txtInst"
        Me.txtInst.Size = New System.Drawing.Size(212, 29)
        Me.txtInst.TabIndex = 3
        '
        'cmbInstituciones
        '
        Me.cmbInstituciones.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbInstituciones.FormattingEnabled = True
        Me.cmbInstituciones.Location = New System.Drawing.Point(317, 117)
        Me.cmbInstituciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbInstituciones.Name = "cmbInstituciones"
        Me.cmbInstituciones.Size = New System.Drawing.Size(273, 33)
        Me.cmbInstituciones.TabIndex = 6
        '
        'lblElimina
        '
        Me.lblElimina.AutoSize = True
        Me.lblElimina.Font = New System.Drawing.Font("Segoe UI", 16.25!)
        Me.lblElimina.ForeColor = System.Drawing.Color.White
        Me.lblElimina.Location = New System.Drawing.Point(212, 36)
        Me.lblElimina.Name = "lblElimina"
        Me.lblElimina.Size = New System.Drawing.Size(242, 38)
        Me.lblElimina.TabIndex = 7
        Me.lblElimina.Text = "Elimina Institución"
        '
        'btnElimina
        '
        Me.btnElimina.BackColor = System.Drawing.Color.Transparent
        Me.btnElimina.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnElimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnElimina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnElimina.ForeColor = System.Drawing.Color.Transparent
        Me.btnElimina.Location = New System.Drawing.Point(241, 218)
        Me.btnElimina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(157, 31)
        Me.btnElimina.TabIndex = 5
        Me.btnElimina.Text = "ELIMINAR"
        Me.btnElimina.UseVisualStyleBackColor = False
        '
        'btnRegistra
        '
        Me.btnRegistra.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegistra.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnRegistra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistra.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegistra.ForeColor = System.Drawing.Color.Transparent
        Me.btnRegistra.Location = New System.Drawing.Point(241, 218)
        Me.btnRegistra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistra.Name = "btnRegistra"
        Me.btnRegistra.Size = New System.Drawing.Size(157, 31)
        Me.btnRegistra.TabIndex = 4
        Me.btnRegistra.Text = "&REGISTRAR"
        Me.btnRegistra.UseVisualStyleBackColor = False
        '
        'CambioInstitucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 334)
        Me.Controls.Add(Me.lblElimina)
        Me.Controls.Add(Me.cmbInstituciones)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.btnRegistra)
        Me.Controls.Add(Me.txtInst)
        Me.Controls.Add(Me.lblInstitucion)
        Me.Controls.Add(Me.lblIngresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CambioInstitucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresa Institucion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIngresa As Label
    Friend WithEvents lblInstitucion As Label
    Friend WithEvents txtInst As TextBox
    Friend WithEvents btnRegistra As Button
    Friend WithEvents btnElimina As Button
    Friend WithEvents cmbInstituciones As ComboBox
    Friend WithEvents lblElimina As Label
End Class
