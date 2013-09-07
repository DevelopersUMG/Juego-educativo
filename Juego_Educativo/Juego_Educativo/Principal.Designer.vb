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
        Me.Text_Usuario = New System.Windows.Forms.TextBox()
        Me.Text_Contraseña = New System.Windows.Forms.TextBox()
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.Btn_Registrarse = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(62, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(62, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Text_Usuario
        '
        Me.Text_Usuario.Location = New System.Drawing.Point(180, 283)
        Me.Text_Usuario.Name = "Text_Usuario"
        Me.Text_Usuario.Size = New System.Drawing.Size(202, 20)
        Me.Text_Usuario.TabIndex = 3
        '
        'Text_Contraseña
        '
        Me.Text_Contraseña.Location = New System.Drawing.Point(180, 341)
        Me.Text_Contraseña.Name = "Text_Contraseña"
        Me.Text_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_Contraseña.Size = New System.Drawing.Size(202, 20)
        Me.Text_Contraseña.TabIndex = 4
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.BackgroundImage = CType(resources.GetObject("Btn_Ingresar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Ingresar.Location = New System.Drawing.Point(106, 480)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Size = New System.Drawing.Size(52, 50)
        Me.Btn_Ingresar.TabIndex = 7
        Me.Btn_Ingresar.UseVisualStyleBackColor = True
        '
        'Btn_Registrarse
        '
        Me.Btn_Registrarse.BackgroundImage = CType(resources.GetObject("Btn_Registrarse.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Registrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Registrarse.Location = New System.Drawing.Point(361, 479)
        Me.Btn_Registrarse.Name = "Btn_Registrarse"
        Me.Btn_Registrarse.Size = New System.Drawing.Size(51, 51)
        Me.Btn_Registrarse.TabIndex = 8
        Me.Btn_Registrarse.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackgroundImage = CType(resources.GetObject("Btn_Salir.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Salir.Location = New System.Drawing.Point(607, 480)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(51, 51)
        Me.Btn_Salir.TabIndex = 9
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(424, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Registrarse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 533)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Iniciar Sesión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(618, 534)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Salir"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 582)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Registrarse)
        Me.Controls.Add(Me.Btn_Ingresar)
        Me.Controls.Add(Me.Text_Contraseña)
        Me.Controls.Add(Me.Text_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Text_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Text_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Ingresar As System.Windows.Forms.Button
    Friend WithEvents Btn_Registrarse As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
