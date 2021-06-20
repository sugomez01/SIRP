<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoBanda
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBanda = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!)
        Me.Label1.Location = New System.Drawing.Point(255, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Banda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.Label2.Location = New System.Drawing.Point(156, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Banda"
        '
        'txtBanda
        '
        Me.txtBanda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanda.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.txtBanda.Location = New System.Drawing.Point(287, 136)
        Me.txtBanda.Name = "txtBanda"
        Me.txtBanda.Size = New System.Drawing.Size(137, 29)
        Me.txtBanda.TabIndex = 2
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Calibri", 10.8!)
        Me.btnIngresar.Location = New System.Drawing.Point(299, 208)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(106, 32)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'IngresoBanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(715, 360)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtBanda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IngresoBanda"
        Me.Text = "IngresoBanda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBanda As TextBox
    Friend WithEvents btnIngresar As Button
End Class
