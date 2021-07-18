<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminaUsuario))
        Me.lblElimina = New System.Windows.Forms.Label()
        Me.lblInstitucion = New System.Windows.Forms.Label()
        Me.txtInst = New System.Windows.Forms.TextBox()
        Me.btnElimina = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblElimina
        '
        Me.lblElimina.AutoSize = True
        Me.lblElimina.Font = New System.Drawing.Font("Segoe UI", 16.25!)
        Me.lblElimina.ForeColor = System.Drawing.Color.White
        Me.lblElimina.Location = New System.Drawing.Point(156, 33)
        Me.lblElimina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblElimina.Name = "lblElimina"
        Me.lblElimina.Size = New System.Drawing.Size(160, 30)
        Me.lblElimina.TabIndex = 8
        Me.lblElimina.Text = "Elimina Usuario"
        '
        'lblInstitucion
        '
        Me.lblInstitucion.AutoSize = True
        Me.lblInstitucion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstitucion.ForeColor = System.Drawing.Color.White
        Me.lblInstitucion.Location = New System.Drawing.Point(28, 112)
        Me.lblInstitucion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstitucion.Name = "lblInstitucion"
        Me.lblInstitucion.Size = New System.Drawing.Size(136, 20)
        Me.lblInstitucion.TabIndex = 9
        Me.lblInstitucion.Text = "NOMBRE USUARIO"
        '
        'txtInst
        '
        Me.txtInst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInst.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInst.Location = New System.Drawing.Point(187, 112)
        Me.txtInst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInst.Name = "txtInst"
        Me.txtInst.Size = New System.Drawing.Size(212, 25)
        Me.txtInst.TabIndex = 10
        '
        'btnElimina
        '
        Me.btnElimina.BackColor = System.Drawing.Color.Transparent
        Me.btnElimina.BackgroundImage = Global.SIRP.My.Resources.Resources.boton
        Me.btnElimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnElimina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnElimina.ForeColor = System.Drawing.Color.Transparent
        Me.btnElimina.Location = New System.Drawing.Point(171, 190)
        Me.btnElimina.Margin = New System.Windows.Forms.Padding(2)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(118, 25)
        Me.btnElimina.TabIndex = 11
        Me.btnElimina.Text = "ELIMINAR"
        Me.btnElimina.UseVisualStyleBackColor = False
        '
        'EliminaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.txtInst)
        Me.Controls.Add(Me.lblInstitucion)
        Me.Controls.Add(Me.lblElimina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EliminaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EliminaUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblElimina As Label
    Friend WithEvents lblInstitucion As Label
    Friend WithEvents txtInst As TextBox
    Friend WithEvents btnElimina As Button
End Class
