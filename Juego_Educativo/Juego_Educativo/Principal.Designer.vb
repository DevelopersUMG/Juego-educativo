<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.Btn_Registrarse = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(22, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(22, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 196)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.BackgroundImage = CType(resources.GetObject("Btn_Ingresar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Ingresar.Location = New System.Drawing.Point(26, 381)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Size = New System.Drawing.Size(129, 35)
        Me.Btn_Ingresar.TabIndex = 7
        Me.Btn_Ingresar.UseVisualStyleBackColor = True
        '
        'Btn_Registrarse
        '
        Me.Btn_Registrarse.BackgroundImage = CType(resources.GetObject("Btn_Registrarse.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Registrarse.Location = New System.Drawing.Point(230, 381)
        Me.Btn_Registrarse.Name = "Btn_Registrarse"
        Me.Btn_Registrarse.Size = New System.Drawing.Size(126, 35)
        Me.Btn_Registrarse.TabIndex = 8
        Me.Btn_Registrarse.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackgroundImage = CType(resources.GetObject("Btn_Salir.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Salir.Location = New System.Drawing.Point(443, 381)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(126, 36)
        Me.Btn_Salir.TabIndex = 9
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(623, 428)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Registrarse)
        Me.Controls.Add(Me.Btn_Ingresar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Ingresar As System.Windows.Forms.Button
    Friend WithEvents Btn_Registrarse As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button

End Class
