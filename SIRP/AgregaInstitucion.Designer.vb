<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregaInstitucion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregaInstitucion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInst = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.picPrueba = New System.Windows.Forms.PictureBox()
        Me.bntSubir = New System.Windows.Forms.Button()
        CType(Me.picPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro Institución"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Institución"
        '
        'txtInst
        '
        Me.txtInst.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInst.Location = New System.Drawing.Point(395, 97)
        Me.txtInst.Name = "txtInst"
        Me.txtInst.Size = New System.Drawing.Size(212, 29)
        Me.txtInst.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(459, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Ingresar Registro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ofdImagen
        '
        Me.ofdImagen.FileName = "OpenFileDialog1"
        '
        'picPrueba
        '
        Me.picPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrueba.Location = New System.Drawing.Point(395, 170)
        Me.picPrueba.Name = "picPrueba"
        Me.picPrueba.Size = New System.Drawing.Size(211, 153)
        Me.picPrueba.TabIndex = 5
        Me.picPrueba.TabStop = False
        '
        'bntSubir
        '
        Me.bntSubir.Location = New System.Drawing.Point(162, 170)
        Me.bntSubir.Name = "bntSubir"
        Me.bntSubir.Size = New System.Drawing.Size(170, 38)
        Me.bntSubir.TabIndex = 6
        Me.bntSubir.Text = "Subir Logo"
        Me.bntSubir.UseVisualStyleBackColor = True
        '
        'AgregaInstitucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bntSubir)
        Me.Controls.Add(Me.picPrueba)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtInst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregaInstitucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresa Institucion"
        CType(Me.picPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInst As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ofdImagen As OpenFileDialog
    Friend WithEvents picPrueba As PictureBox
    Friend WithEvents bntSubir As Button
End Class
