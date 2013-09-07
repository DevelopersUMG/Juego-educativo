<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_de_Opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_de_Opciones))
        Me.Btn_Facil = New System.Windows.Forms.Button()
        Me.Btn_Medio = New System.Windows.Forms.Button()
        Me.Btn_Dificil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_RegreInicio = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1completado = New System.Windows.Forms.Label()
        Me.label2completado = New System.Windows.Forms.Label()
        Me.label3completado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Facil
        '
        Me.Btn_Facil.BackgroundImage = CType(resources.GetObject("Btn_Facil.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Facil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Facil.Location = New System.Drawing.Point(128, 263)
        Me.Btn_Facil.Name = "Btn_Facil"
        Me.Btn_Facil.Size = New System.Drawing.Size(159, 37)
        Me.Btn_Facil.TabIndex = 0
        Me.Btn_Facil.UseVisualStyleBackColor = True
        '
        'Btn_Medio
        '
        Me.Btn_Medio.BackgroundImage = CType(resources.GetObject("Btn_Medio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Medio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Medio.Location = New System.Drawing.Point(382, 263)
        Me.Btn_Medio.Name = "Btn_Medio"
        Me.Btn_Medio.Size = New System.Drawing.Size(159, 37)
        Me.Btn_Medio.TabIndex = 1
        Me.Btn_Medio.UseVisualStyleBackColor = True
        '
        'Btn_Dificil
        '
        Me.Btn_Dificil.BackgroundImage = CType(resources.GetObject("Btn_Dificil.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Dificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Dificil.Location = New System.Drawing.Point(614, 263)
        Me.Btn_Dificil.Name = "Btn_Dificil"
        Me.Btn_Dificil.Size = New System.Drawing.Size(159, 37)
        Me.Btn_Dificil.TabIndex = 2
        Me.Btn_Dificil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(179, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(543, 73)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Niveles De Juego"
        '
        'Btn_RegreInicio
        '
        Me.Btn_RegreInicio.BackgroundImage = CType(resources.GetObject("Btn_RegreInicio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegreInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_RegreInicio.Location = New System.Drawing.Point(406, 509)
        Me.Btn_RegreInicio.Name = "Btn_RegreInicio"
        Me.Btn_RegreInicio.Size = New System.Drawing.Size(41, 41)
        Me.Btn_RegreInicio.TabIndex = 4
        Me.Btn_RegreInicio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 553)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Volver a Inicio"
        '
        'label1completado
        '
        Me.label1completado.AutoSize = True
        Me.label1completado.BackColor = System.Drawing.Color.Transparent
        Me.label1completado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1completado.Location = New System.Drawing.Point(155, 304)
        Me.label1completado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1completado.Name = "label1completado"
        Me.label1completado.Size = New System.Drawing.Size(112, 24)
        Me.label1completado.TabIndex = 6
        Me.label1completado.Text = "Completado"
        Me.label1completado.Visible = False
        '
        'label2completado
        '
        Me.label2completado.AutoSize = True
        Me.label2completado.BackColor = System.Drawing.Color.Transparent
        Me.label2completado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2completado.Location = New System.Drawing.Point(410, 304)
        Me.label2completado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2completado.Name = "label2completado"
        Me.label2completado.Size = New System.Drawing.Size(112, 24)
        Me.label2completado.TabIndex = 7
        Me.label2completado.Text = "Completado"
        Me.label2completado.Visible = False
        '
        'label3completado
        '
        Me.label3completado.AutoSize = True
        Me.label3completado.BackColor = System.Drawing.Color.Transparent
        Me.label3completado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3completado.Location = New System.Drawing.Point(642, 304)
        Me.label3completado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3completado.Name = "label3completado"
        Me.label3completado.Size = New System.Drawing.Size(112, 24)
        Me.label3completado.TabIndex = 8
        Me.label3completado.Text = "Completado"
        Me.label3completado.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(140, 509)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 62)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "         Cambiar         Contraseña"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Menu_de_Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 582)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label3completado)
        Me.Controls.Add(Me.label2completado)
        Me.Controls.Add(Me.label1completado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_RegreInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Dificil)
        Me.Controls.Add(Me.Btn_Medio)
        Me.Controls.Add(Me.Btn_Facil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu_de_Opciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_de_Opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Facil As System.Windows.Forms.Button
    Friend WithEvents Btn_Medio As System.Windows.Forms.Button
    Friend WithEvents Btn_Dificil As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_RegreInicio As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1completado As System.Windows.Forms.Label
    Friend WithEvents label2completado As System.Windows.Forms.Label
    Friend WithEvents label3completado As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
